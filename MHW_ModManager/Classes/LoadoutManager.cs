using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class LoadoutManager {

    static ModsData modsData => MainForm.instance.modsData;

    const string selectDialogFilter = "Mod Loadout File (.mlf)|*.mlf";

    public static void SaveLoadout() {

        Task scanTask = Task.Factory.StartNew(() => {
            foreach (var mod in modsData.modInfos)
                mod.CheckIfInstalled();
        });

        SaveFileDialog fileDialog = new SaveFileDialog() {
            InitialDirectory = string.IsNullOrEmpty(modsData.lastSaveDialoguePath) ? Serializer.GetMMDataFolder() : modsData.lastSaveDialoguePath,
            Title = "Input Mod Loadout Save Location",
            ValidateNames = true, AddExtension = true, FileName = "ModLoadout", Filter = selectDialogFilter
        };

        var result = fileDialog.ShowDialog();
        if (result != DialogResult.OK) {
            return;
        }

        scanTask.Wait();

        //save here
        string savePath = fileDialog.FileName;
        string saveFolder = Path.GetDirectoryName(savePath);
        modsData.lastSaveDialoguePath = saveFolder;
        Directory.CreateDirectory(saveFolder);

        ModsData saveData = new ModsData();
        saveData.modInfos = modsData.modInfos;
        Serializer.SaveObj(saveData, savePath);
    }

    public static async Task SaveLoadoutAuto(string path, bool rescan = true) {

        Task scanTask = Task.Factory.StartNew(() => {
            if (rescan) {
                foreach (var mod in modsData.modInfos)
                    mod.CheckIfInstalled();
            }
        });

        await scanTask;

        //save here
        string saveFolder = Path.GetDirectoryName(path);
        Directory.CreateDirectory(saveFolder);


        ModsData saveData = new ModsData();
        saveData.modInfos = modsData.modInfos;
        Serializer.SaveObj(saveData, path);
    }


    public static async void LoadLoadout() {

        Task saveBakTask = SaveLoadoutAuto(Serializer.GetMMDataFolder() + "LastLoadoutStateBackup.mlf", false);


        OpenFileDialog fileDialog = new OpenFileDialog() {
            InitialDirectory = string.IsNullOrEmpty(modsData.lastSaveDialoguePath) ? Serializer.GetMMDataFolder() : modsData.lastSaveDialoguePath,
            AddExtension = true, Filter = selectDialogFilter, ValidateNames = true, Multiselect = false, CheckFileExists = true
        };

        var result = fileDialog.ShowDialog();
        if (result != DialogResult.OK) {
            return;
        }

        await saveBakTask;

        try {

            ModsData loadoutData = Serializer.LoadObj(fileDialog.FileName) as ModsData;


            List<string> issues = new List<string>();

            foreach (var loadMod in loadoutData.modInfos) {

                //Console.WriteLine("");
                //foreach(var file in loadMod.archiveFiles) {
                //    Console.WriteLine($"{file.installed}: {file.path}");
                //}

                //Console.WriteLine($"{mod.modName}: {mod.intalledText}");

                if (!loadMod.archiveExists) {
                    issues.Add($"Couldnt Find: {loadMod.shortPath}");
                    continue;
                }

                ModInfo matchingMod = modsData.modInfos.Find(realMod => realMod.modName == loadMod.modName);

                if (!matchingMod) {
                    issues.Add($"Archive Not Loaded: {loadMod.modPath}");
                    continue;
                }


                RestoreModState(loadMod);
                foreach (var file in loadMod.archiveFiles) {
                    //not sure if neccessary but just clear the temporary belonging nodes just in case
                    file.belongingNode = null;

                    //update the installed status of the real mod archive files to match the status of the loadout files
                    ArchiveFile matchFile = matchingMod.archiveFiles.First(x => x.path == file.path);
                    if (matchFile) {
                        matchFile.installed = file.installed;
                        matchFile.installedCRC = file.installedCRC;
                    }
                }

            }

            IEnumerable<ModInfo> newlyAddedMods = modsData.modInfos.Where(mod => !loadoutData.modInfos.Find(loadmod => loadmod.modName == mod.modName));

            if (newlyAddedMods.Count() > 0) {
                InputBoxForm watDoBox = InputBoxForm.OKBOX("New Files Were Added!", "", "Uninstall New Mods");
                watDoBox.TitleLabel.ForeColor = Color.LightYellow;
                watDoBox.buttonClose.Visible = false;

                watDoBox.richTextBox1.AppendText("\nSince this loadout was created, new mod archives have been added.\nWhat would you like to do about this?");
                watDoBox.richTextBox1.CenterText();

                watDoBox.buttonCancel.Width += 50;
                watDoBox.buttonCancel.Left -= 50;

                watDoBox.buttonNoAll.Text = "Leave As Is";
                watDoBox.buttonNoAll.Visible = true;
                watDoBox.buttonNoAll.Width += 45;
                watDoBox.buttonNoAll.Left = watDoBox.buttonCancel.Left - watDoBox.buttonNoAll.Width - 10;

                watDoBox.checkBoxGeneric1.Text = "Update Loadout With Changes";
                watDoBox.checkBoxGeneric1.Visible = true;
                watDoBox.checkBoxGeneric1.Checked = true;
                watDoBox.checkBoxGeneric1.Top = watDoBox.buttonNoAll.Top + 5;
                watDoBox.checkBoxGeneric1.Left = 10;
                

                result = watDoBox.ShowDialog();
                if (result == DialogResult.No) {
                    //uninstall
                    foreach (var mod in newlyAddedMods) {
                        foreach (var file in mod.archiveFiles) file.belongingNode = new TreeNode() { Checked = true };
                        ArchiveManager.UninstallSelected(mod, false, true);
                        foreach (var file in mod.archiveFiles) file.belongingNode = null;
                    }
                } else {
                    //leave be
                }

                if (watDoBox.checkBoxGeneric1.Checked)
                    await SaveLoadoutAuto(fileDialog.FileName, false);
            }

            ArchiveManager.DeleteEmptyDirs(Serializer.GetGameModFolder());

            InputBoxForm infoBox;

            if (issues.Count > 0) {
                infoBox = InputBoxForm.OKBOX("Completed With Warnings", "");
                infoBox.TitleLabel.ForeColor = Color.Orange;
                infoBox.richTextBox1.AppendText("The loadout was restored but there were some issues.\n\n");

                infoBox.Height += 100;
                infoBox.richTextBox1.Height += 95;

                foreach (string issue in issues) {
                    infoBox.richTextBox1.AppendText(issue, Color.LightYellow, true);
                }

                infoBox.checkBoxGeneric1.Text = "Update Loadout With These Removed";
                infoBox.checkBoxGeneric1.Visible = true;
                infoBox.checkBoxGeneric1.Top = infoBox.buttonNoAll.Top + 5;
                infoBox.checkBoxGeneric1.Left = 10;
            } else {
                infoBox = InputBoxForm.OKBOX("Success", "");
                infoBox.TitleLabel.ForeColor = Color.PaleGreen;
                infoBox.richTextBox1.AppendText("\nMod loadout state succesfully restored.", Color.LawnGreen, true);
            }

            infoBox.richTextBox1.CenterText();
            infoBox.ShowDialog();

            if (infoBox.checkBoxGeneric1.Checked) {
                await SaveLoadoutAuto(fileDialog.FileName, false);
            }


            MainForm.RefreshListView();
            MainForm.RefreshTreeView();

        } catch (Exception ex) {
            InputBoxForm successBox = InputBoxForm.OKBOX("Failure", "");
            successBox.richTextBox1.AppendText("An error occured while trying to restore your mod loadout.", Color.Salmon, true);
            successBox.richTextBox1.AppendText("Heres the error:\n\n");
            successBox.richTextBox1.CenterText();

            successBox.richTextBox1.AppendText(ex.ToString());
        }

    }


    static void RestoreModState(ModInfo loadMod) {
        //a file being "installed" in this context means that it was installed when the loadout was saved
        //so we need to make sure files that werent installed, get uninstalled now when restoring the loadout
        foreach (var file in loadMod.archiveFiles) file.belongingNode = new TreeNode() { Checked = !file.GetInstalledStatus() };
        ArchiveManager.UninstallSelected(loadMod, false, true);


        //Check the ones that actually should be installed and install them
        foreach (var file in loadMod.archiveFiles) file.belongingNode.Checked = file.GetInstalledStatus();
        ArchiveManager.InstallSelected(loadMod, false);
    }


}


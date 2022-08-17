using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SevenZip;
using System.Drawing;
using System.Windows.Forms;

public static class ArchiveManager {

    public static ArchiveFile[] GetArchiveFiles(ModInfo modInfo) {
        try {
            List<ArchiveFile> fileList = null;
            using (Stream stream = File.OpenRead(modInfo.modPath)) {

                modInfo.fileSize = stream.Length / 1048576f;

                using (var extractor = new SevenZipExtractor(stream)) {
                    var files = extractor.ArchiveFileData;
                    fileList = new List<ArchiveFile>(files.Count);
                    foreach (var file in files) {
                        fileList.Add(new ArchiveFile() {
                            path = file.FileName.FixSlashes(),
                            crc = file.Crc,
                            isDir = file.IsDirectory,
                            size = file.Size / 1048576f,
                            directory = file.IsDirectory ? file.FileName.FixSlashes() : ""
                        });
                    }
                }
            }

            //Directory.SetCurrentDirectory("");
            for (int i = 0; i < fileList.Count; i++) {
                ArchiveFile file = fileList[i];
                file.modBelong = modInfo;

                string parentDir = Path.GetDirectoryName(file.path);
                if (string.IsNullOrEmpty(parentDir))
                    continue;

                file.parent = fileList.Find(x => x.directory == parentDir);
                if (!file.parent) {
                    ArchiveFile fixParent = new ArchiveFile() {
                        isDir = true,
                        directory = parentDir,
                        path = parentDir.FixSlashes()
                    };
                    fileList.Add(fixParent);
                    file.parent = fixParent;
                }

                file.parent.children.Add(file);
            }
            for (int i = fileList.Count; --i >= 0;) {
                ArchiveFile file = fileList[i];
                if (file.isDir) {
                    file.size = file.children.Sum(x => x.size);
                }
            }
            for (int i = 0; i < fileList.Count; i++) {
                ArchiveFile file = fileList[i];
                if (file.isDir) {
                    file.size = file.children.Sum(x => x.size);
                }
            }


            return fileList.ToArray();
        } catch (Exception ex) {
            Console.WriteLine(modInfo.modPath + " : " + ex.Message);
            return null;
        }
    }



    public static void InstallSelected(ModInfo mod, bool refresh = true) {
        try {
            if (!File.Exists(mod.modPath)) {
                MainForm.instance.richBoxMod.AppendText("\nInstall Failed!\n     Mod archive not found!", Color.Crimson, true);
                return;
            }

            bool skipWarnings = false;
            bool overwrite = false;
            int count = -1;
            int fileCounter = 0;

            List<ModInfo> modsToRefresh = new List<ModInfo>() { };

            using (Stream stream = File.OpenRead(mod.modPath)) {
                using (var extractor = new SevenZipExtractor(stream)) {

                    int fileCount = extractor.ArchiveFileData.Count(x => !x.IsDirectory);

                    foreach (var fileData in extractor.ArchiveFileData) {
                        count++;
                        if (fileData.IsDirectory) continue;
                        fileCounter++;

                        ArchiveFile matchFile = mod.archiveFiles.FirstOrDefault(x => x.crc == fileData.Crc && x.path == fileData.FileName.FixSlashes());

                        if (matchFile && matchFile.belongingNode.Checked) {

                            if (File.Exists(matchFile.installedPath)) {
                                if (!matchFile.installedNotMatching)
                                    continue;

                                CheckWarnDialogue(ref skipWarnings, ref overwrite, fileCounter, fileCount, matchFile);

                                if (!overwrite)
                                    continue;

                                File.Delete(matchFile.installedPath);
                            }

                            modsToRefresh.AddRange(matchFile.FindModsWithSameFile());

                            Directory.CreateDirectory(Path.GetDirectoryName(matchFile.installedPath));
                            using (var fileStream = File.OpenWrite(matchFile.installedPath)) {
                                extractor.ExtractFile(count, fileStream);
                            }
                        }
                    }
                }
            }

            foreach (var refreshMod in modsToRefresh.Distinct()) {
                refreshMod.CheckIfInstalled();
            }



            if (refresh) {
                MainForm.SaveData();
                MainForm.RefreshListView();
                MainForm.RefreshTreeView();

                MainForm.instance.richBoxMod.AppendText("\n");
                MainForm.instance.richBoxMod.AppendText("Install Succesful!", Color.LawnGreen, true);
            }

        } catch (Exception ex) {
            Console.WriteLine(ex);

            MainForm.instance.richBoxMod.AppendText("\n");
            MainForm.instance.richBoxMod.AppendText("Install Failed! Please copy and paste this error\n     and send it to the mod author please!", Color.Crimson, true);
            MainForm.instance.richBoxMod.AppendText(ex.ToString(), Color.Salmon, true);
        }
    }

    static void CheckWarnDialogue(ref bool skipWarnings, ref bool overwrite, int index, int fileCount, ArchiveFile matchFile) {
        if (!skipWarnings) {
            InputBoxForm warnDialogue = new InputBoxForm();
            warnDialogue.YesNoSetup($"Overwrite file? ({index} of {fileCount})", "");

            warnDialogue.richTextBox1.AppendText(matchFile.path, Color.Cyan, true);
            var actMods = matchFile.FindActualCrcMod();
            if (actMods.Count() > 0) {
                warnDialogue.richTextBox1.AppendText($"The file is from:", Color.WhiteSmoke, true);
                foreach (var rMod in actMods) {
                    warnDialogue.richTextBox1.AppendText(rMod.shortPath, Color.Orange, true);
                }
            }
            else {
                warnDialogue.richTextBox1.AppendText($"It is unknown what mod this file belongs to.", Color.Coral, true);
            }

            warnDialogue.richTextBox1.SelectAll();
            warnDialogue.richTextBox1.SelectionAlignment = HorizontalAlignment.Center;


            var result = warnDialogue.ShowDialog();

            skipWarnings = result == DialogResult.OK || result == DialogResult.Ignore ? true : false;
            overwrite = result == DialogResult.Yes || result == DialogResult.OK ? true : false;
        }
    }


    public static void UninstallSelected(ModInfo mod, bool refresh = true, bool checkForMatchingCRC = false) {
        foreach (var file in mod.archiveFiles) {
            if (!file.isDir && file.belongingNode.Checked) {
                if (File.Exists(file.installedPath)) {
                    if (checkForMatchingCRC) {
                        uint fileCRC = file.GetInstalledCRC();
                        if (file.crc != fileCRC)
                            goto finish;
                    }

                    RecycleManager.DeleteNoWarn(file.installedPath);
                    file.installedCRC = 0;
                }

                finish:
                file.installed = false;
            }
        }

        if (refresh) {
            MainForm.SaveData();
            MainForm.RefreshListView();
            MainForm.RefreshTreeView();
        }
    }


    public static void DeleteEmptyDirs(string startLocation) {
        foreach (var directory in Directory.GetDirectories(startLocation)) {
            DeleteEmptyDirs(directory);
            if (Directory.GetFiles(directory).Length == 0 &&
                Directory.GetDirectories(directory).Length == 0) {
                Directory.Delete(directory, false);
            }
        }
    }


}



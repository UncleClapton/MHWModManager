using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SevenZip;
using SharpCompress.Readers;
using System.Drawing;
using System.Windows.Forms;

public static class ArchiveManager {

    public static ArchiveFile[] GetArchiveFiles(ModInfo modInfo) {
        try {
            List<ArchiveFile> fileList = new List<ArchiveFile>();
            using (Stream stream = File.OpenRead(modInfo.modPath)) {

                modInfo.fileSize = stream.Length / 1048576f;


                if (modInfo.sevZip) {
                    using (var extractor = new SevenZipExtractor(stream)) {
                        var files = extractor.ArchiveFileData;
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
                } else {
                    using (var reader = ReaderFactory.Open(stream)) {
                        while (reader.MoveToNextEntry()) {
                            fileList.Add(new ArchiveFile() {
                                path = reader.Entry.Key.FixSlashes(),
                                crc = (uint)reader.Entry.Crc,
                                isDir = reader.Entry.IsDirectory,
                                size = reader.Entry.Size / 1048576f,
                                directory = reader.Entry.IsDirectory ? reader.Entry.Key.FixSlashes() : ""
                            });
                        }
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



    public static void InstallSelected(ModInfo mod) {
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


                if (mod.sevZip) {
                    using (var extractor = new SevenZipExtractor(stream)) {

                        int fileCount = extractor.ArchiveFileData.Count(x => !x.IsDirectory);

                        foreach (var fileData in extractor.ArchiveFileData) {
                            count++;
                            if (fileData.IsDirectory) continue;
                            fileCounter++;

                            ArchiveFile matchFile = mod.archiveFiles.First(x => x.crc == fileData.Crc && x.path == fileData.FileName.FixSlashes());

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

                        //extractor.ExtractFiles(mod.gameModDir, indiciesToExtract.ToArray());
                    }
                } else {
                    using (var reader = ReaderFactory.Open(stream)) {

                        int fileCount = mod.archiveFiles.Count(x => !x.isDir);

                        while (reader.MoveToNextEntry()) {
                            count++;
                            if (reader.Entry.IsDirectory) continue;
                            fileCounter++;

                            uint fileCRC = (uint)reader.Entry.Crc;
                            ArchiveFile matchFile = mod.archiveFiles.First(x => x.crc == fileCRC && x.path == reader.Entry.Key.FixSlashes());


                            if (matchFile && matchFile.belongingNode.Checked) {

                                if (File.Exists(matchFile.installedPath)) {
                                    if (!matchFile.installedNotMatching)
                                        continue;

                                    CheckWarnDialogue(ref skipWarnings, ref overwrite, fileCounter, fileCount, matchFile);

                                    if (!overwrite)
                                        continue;
                                }

                                modsToRefresh.AddRange(matchFile.FindModsWithSameFile());

                                Directory.CreateDirectory(Path.GetDirectoryName(matchFile.installedPath));
                                reader.WriteEntryToFile(matchFile.installedPath, new SharpCompress.Common.ExtractionOptions() {
                                    PreserveFileTime = true, PreserveAttributes = false, ExtractFullPath = true, Overwrite = true
                                });
                            }
                        }
                    }
                }
            }

            foreach (var refreshMod in modsToRefresh.Distinct()) {
                refreshMod.CheckIfInstalled();
            }


            

            MainForm.SaveData();
            MainForm.RefreshListView();
            MainForm.RefreshTreeView();

            MainForm.instance.richBoxMod.AppendText("\n");
            MainForm.instance.richBoxMod.AppendText("Install Succesful!", Color.LawnGreen, true);

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
            } else {
                warnDialogue.richTextBox1.AppendText($"It is unknown what mod this file belongs to.", Color.Coral, true);
            }

            warnDialogue.richTextBox1.SelectAll();
            warnDialogue.richTextBox1.SelectionAlignment = HorizontalAlignment.Center;


            var result = warnDialogue.ShowDialog();

            skipWarnings = result == DialogResult.OK || result == DialogResult.Ignore ? true : false;
            overwrite = result == DialogResult.Yes || result == DialogResult.OK ? true : false;
        }
    }


    public static void UninstallSelected(ModInfo mod) {
        foreach (var file in mod.archiveFiles) {
            if (!file.isDir && file.belongingNode.Checked && File.Exists(file.installedPath)) {
                RecycleManager.DeleteNoWarn(file.installedPath);
            }
        }

        MainForm.SaveData();
        MainForm.RefreshListView();
        MainForm.RefreshTreeView();
    }



}



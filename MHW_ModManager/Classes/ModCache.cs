using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ModCache {

    public static void RescanModCacheFolder() {
        Directory.CreateDirectory(Serializer.GetModsCacheFolder());

        string[] modFiles = Directory.GetFiles(Serializer.GetModsCacheFolder(), "*", SearchOption.AllDirectories);
        CheckAddNewMods(modFiles);

        MainForm.SaveData();

        MainForm.RefreshListView();
    }


    public static void CheckAddNewMods(string[] paths) {
        IEnumerable<string> newMods = paths.Where(filePath => !MainForm.instance.modsData.modInfos.Exists(mI => mI.modPath == filePath));

        foreach (string file in newMods) {
            ModInfo matchMod = MainForm.instance.modsData.modInfos.Find(x => x.modName == Path.GetFileName(file));

            if (matchMod) {
                matchMod.modPath = file;

            } else {
                ModInfo tMod = new ModInfo(file);
                if (tMod.archiveFiles != null) {
                    MainForm.instance.modsData.modInfos.Add(tMod);
                    foreach (var archFile in tMod.archiveFiles) {
                        if (!archFile.parent)
                            archFile.GetInstalled();
                    }
                }
            }
        }
    }

    public static void ReCheckMods(IEnumerable<ModInfo> modInfos) {
        foreach (var mod in modInfos) {
            if (!mod.archiveExists)
                continue;

            mod.archiveFiles = ArchiveManager.GetArchiveFiles(mod);

            if (mod.archiveFiles != null) {
                foreach (var archFile in mod.archiveFiles) {
                    if (!archFile.parent)
                        archFile.GetInstalled();
                }
            }
        }
    }

}


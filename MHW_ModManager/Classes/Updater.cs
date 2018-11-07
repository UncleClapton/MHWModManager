using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class Updater {
    public static void UpdateSaveData(ModsData modsData) {

        if(modsData.version < 1.1) {
            foreach(ModInfo mod in modsData.modInfos) {
                if (File.Exists(mod.modPath)) {
                    mod.date = File.GetCreationTime(mod.modPath);
                }
            }
        }

        if(modsData.version < 1.2) {
            foreach (ModInfo mod in modsData.modInfos) {

            }
        }

        modsData.version = MainForm.programVersion;
    }
}


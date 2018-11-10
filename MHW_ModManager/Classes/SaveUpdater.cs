using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class SaveUpdater {
    public static void UpdateSaveData(ModsData modsData) {

        if(modsData.version < 1.1) {
            foreach(ModInfo mod in modsData.modInfos) {
                if (File.Exists(mod.modPath)) {
                    mod.date = File.GetCreationTime(mod.modPath);
                }
            }
        }


        modsData.version = MainForm.programVersion;
    }
}


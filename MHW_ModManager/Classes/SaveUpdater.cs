using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class SaveUpdater {
    public static void UpdateSaveData(ModsData modsData) {

        if (modsData.version < 1.1f) {
            foreach (ModInfo mod in modsData.modInfos) {
                if (File.Exists(mod.modPath)) {
                    mod.date = File.GetCreationTime(mod.modPath);
                }
            }
        }

<<<<<<< HEAD:MHW_ModManager/Classes/SaveUpdater.cs
=======
        if (modsData.version < 1.2f) {
            foreach (ModInfo mod in modsData.modInfos) {

            }
        }
>>>>>>> master:MHW_ModManager/Classes/Updater.cs

        if (modsData.version < 1.4f) {
            string path = Serializer.GetMMDataFolder();

            try {
                (path + "SharpCompress.dll").DeleteIfPathExists();
                (path + "ObjectListView.dll").DeleteIfPathExists();
                (path + "SevenZipSharp.dll").DeleteIfPathExists();
            } catch (Exception ex) {

            }
        }

        modsData.version = MainForm.programVersion;
    }


}


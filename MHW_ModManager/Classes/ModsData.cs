using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


[Serializable]
public class ModsData {

    public string gameDir;
    public string modDir = "nativePC";
    public float version;

    public bool useTopLevelFiles = false;

    public List<ModInfo> modInfos = new List<ModInfo>();

    public ModsData() {
        version = MainForm.programVersion;
        gameDir = Serializer.GetExeDir();
    }


    public static implicit operator bool (ModsData value) => value != null;
}


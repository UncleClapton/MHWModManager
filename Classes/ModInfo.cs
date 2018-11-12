using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

[Serializable]
public class ModInfo {

    public string modPath;
    public string modName;
    public string category;
    public float fileSize;
    public string sizeSuffixed => SizeSuffixer(fileSize);
    public DateTime date;

    public static string SizeSuffixer(float inSize) {
        float floatSize = inSize;
        if (floatSize < 0.9f) {
            floatSize *= 1024f;
            return floatSize.ToString(floatSize < 1 ? "F1" : "F0") + " KB";
        } else if (floatSize < 1024f) {
            return floatSize.ToString("F1") + " MB";
        } else {
            floatSize /= 1024f;
            return floatSize.ToString("F2") + " GB";
        }
    }

    public ArchiveFile[] archiveFiles;

    public bool sevZip;

    static ModsData modsData => MainForm.instance.modsData;

    public bool archiveExists => File.Exists(modPath);

    public ModInfo(string modPath_) {
        modPath = modPath_;
        modName = Path.GetFileName(modPath);

        category = Path.GetFileName(Path.GetDirectoryName(modPath));

        sevZip = Path.GetExtension(modPath).ToLower() == ".7z";

        archiveFiles = ArchiveManager.GetArchiveFiles(this);

        if (File.Exists(modPath)) {
            date = File.GetCreationTime(modPath);
        }
    }

    public string gameModDir => $"{modsData.gameDir.FixSlashes()}\\{modsData.modDir}";
    public bool installed => archiveFiles.All(x => x.GetInstalledStatus() || (!modsData.useTopLevelFiles && x.isTopFile));
    public bool partiallyInstalled => !installed && archiveFiles.Any(x => x.GetInstalledStatus());

    public void CheckIfInstalled() {
        foreach (var file in archiveFiles.Where(x => !x.parent)) {
            file.GetInstalled();
        }
    }

    public string intalledText {
        get {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
            string textValue = "";
            if (installed) {
                textValue = resources.GetString("IntalledText.Installed");
            } else if (partiallyInstalled) {
                textValue = archiveFiles.Any(x => x.installedNotMatching) ? resources.GetString("IntalledText.Conflicting") : resources.GetString("IntalledText.Partial");
            } else {
                textValue = resources.GetString("IntalledText.NoInstalled");
            }

            if (!archiveExists)
                textValue = resources.GetString("IntalledText.NoArchive") + textValue;

            return textValue;
        }
    }

    public string shortPath => modPath.Replace(Serializer.GetModsCacheFolder(), "");

    public IEnumerable<ModInfo> FindModsThatChangeSameFiles() {
        List<ModInfo> mods = new List<ModInfo>();

        foreach (var file in archiveFiles) {
            mods.AddRange(file.FindModsWithSameFile());
        }

        return mods.Distinct();
    }

    public void SetInfo(RichTextBox textBox) {
        ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
        textBox.Clear();
        textBox.AppendText(resources.GetString("FileInformation.Path")); textBox.AppendText(shortPath, archiveExists ? Color.LawnGreen : Color.Tomato, true);

        textBox.AppendText(resources.GetString("FileInformation.Size")); textBox.AppendText(sizeSuffixed, Color.Teal, true);


        var sameMods = FindModsThatChangeSameFiles();
        if (sameMods.Count() > 0) {
            textBox.AppendText(resources.GetString("FileCheck.Existence"));

            foreach (var mod in sameMods) {
                textBox.AppendText(mod.shortPath, Color.Orange, true);
            }
        }

    }



    public static implicit operator bool(ModInfo value) => value != null;
}


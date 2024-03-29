﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

[Serializable]
public class ArchiveFile {
    static ModsData modsData => MainForm.instance.modsData;

    public string path;
    public uint crc;
    public bool isDir;
    public string directory;
    public ArchiveFile parent;
    public List<ArchiveFile> children = new List<ArchiveFile>();
    public ModInfo modBelong;
    public TreeNode belongingNode;

    public float size;
    public string sizeSuffixed => ModInfo.SizeSuffixer(size);


    public bool isTopFile => !isDir && (!parent || (parent.isTopFolder && parent.children.Any(x => x.isDir)));
    public bool isTopFolder => isDir && !parent;

    public bool installed = false;
    public uint installedCRC;
    public bool installedNotMatching => installed && installedCRC != crc;

    public string GetDirectPath() {
        if(path.ToLower().FixSlashes() == modsData.modDir.ToLower().FixSlashes())
            return "";
        
        int idxModFolder = path.ToLower().IndexOf(modsData.modDir.ToLower());
        int subIdx = idxModFolder + modsData.modDir.Length + 1;
        return idxModFolder < 0 || subIdx > path.Length ? path : path.Substring(subIdx);
    }
    public string installedPath => $"{modBelong.gameModDir}\\{GetDirectPath()}";

    public bool GetInstalledStatus() {
        if (isDir) {
            return children.All(x => x.GetInstalledStatus());
        } else {
            return installed && !installedNotMatching;
        }
    }

    public void GetInstalled() {
        if (isDir) {
            foreach (var child in children) {
                child.GetInstalled();
            }
            installed = children.All(x => x.installed);
        } else {
            if (installed = File.Exists(installedPath)) {
                installedCRC = GetInstalledCRC();
            }
        }
    }

    public uint GetInstalledCRC() {
        var crc32 = new Crc32();
        var hash = string.Empty;
        using (var fs = File.OpenRead(installedPath)) {
            return BitConverter.ToUInt32(crc32.ComputeHash(fs).Reverse().ToArray(), 0);
        }
    }

    public List<ModInfo> FindModsWithSameFile() {
        List<ModInfo> sameMods = new List<ModInfo>();

        if (!isDir) {
            foreach (var otherMod in modsData.modInfos) {
                if (otherMod == modBelong) continue;

                if (otherMod.archiveFiles.Any(file => !file.isDir && (!file.isTopFile || modsData.useTopLevelFiles) && file.installedPath.ToLower() == installedPath.ToLower())) {
                    sameMods.Add(otherMod);
                }
            }
        }

        sameMods.AddRange(FindActualCrcMod());

        return sameMods;
    }

    public IEnumerable<ModInfo> FindActualCrcMod() {
        if (!installedNotMatching) return new ModInfo[0];

        return modsData.modInfos.Where(mod => mod.archiveFiles.Any(file => file.crc == installedCRC));
    }

    public void SetInfo(RichTextBox textBox, TreeNode node) {
        textBox.Clear();

        textBox.AppendText("Path: "); textBox.AppendText(path, node.ForeColor, true);
        textBox.AppendText("Status: " + node.ToolTipText, Color.WhiteSmoke, true);
        textBox.AppendText("Install Location: "); textBox.AppendText(installedPath, Color.LightYellow, true);
        textBox.AppendText("Size: "); textBox.AppendText(sizeSuffixed, Color.AliceBlue, true);

        if (!isDir) {
            textBox.AppendText("CRC: "); textBox.AppendText(crc.ToString("X"), Color.Cyan, true);

            if (installedNotMatching) {
                textBox.AppendText("Installed CRC: "); textBox.AppendText(installedCRC.ToString("X"), node.ForeColor, true);
            }

        }
        textBox.AppendText("\n");

        var actMods = FindActualCrcMod();
        if (actMods != null && actMods.Count() > 0) {
            string plural = actMods.Count() > 1 ? "s" : "";
            textBox.AppendText($"Mod{plural} that this file is from:", Color.WhiteSmoke, true);
            foreach (var mod in actMods) {
                textBox.AppendText("    " + mod.shortPath, Color.Coral, true);
            }
            textBox.AppendText("\n");
        }

        var sameMods = FindModsWithSameFile().Distinct();
        if (sameMods.Count() > 0) {
            textBox.AppendText("Mods that also change this file: \n");

            foreach (var mod in sameMods) {
                textBox.AppendText("    " + mod.shortPath, Color.Orange, true);
            }
        }
    }

    public static implicit operator bool(ArchiveFile value) => value != null;
}

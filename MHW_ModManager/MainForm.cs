using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FileSystem = Microsoft.VisualBasic.FileIO.FileSystem;
using UIOption = Microsoft.VisualBasic.FileIO.UIOption;
using UICancelOption = Microsoft.VisualBasic.FileIO.UICancelOption;
using System.Runtime.InteropServices;

public partial class MainForm : Form {


    public const float programVersion = 1.45f;

    public static MainForm instance;
    public ModsData modsData;

    public MainForm() {
        instance = this;
        InitializeComponent();
        Init();
    }


    void Init() {
        string zipPath = Serializer.GetMMDataFolder() + "7z.dll";
        SevenZip.SevenZipBase.SetLibraryPath(zipPath);

        MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;

        LoadData();

        olvColumnSize.AspectToStringConverter = (object sizeFloat) => ModInfo.SizeSuffixer((float)sizeFloat);

        labelTitle.Text = $"MHW Mod Managaer V{programVersion} - By: BoltMan";

        NexusUpdateChecker.CheckForNewVersion();
    }

    void LoadData() {
        modsData = Serializer.LoadObj(Serializer.GetDataFilePath()) as ModsData;
        if (!modsData) {
            modsData = new ModsData();
        } else {
            SaveUpdater.UpdateSaveData(modsData);
        }

        //modsData.modInfos = new List<ModInfo>();

        textBoxGameDir.Text = modsData.gameDir;
        textBoxModFolder.Text = modsData.modDir;

        checkBoxIgnoreTopFiles.Checked = !modsData.useTopLevelFiles;
    }

    private void textBoxModFolder_TextChanged(object sender, EventArgs e) {
        textBoxModFolder.Text = textBoxModFolder.Text.FixSlashes().Replace("\\", "");
        modsData.modDir = textBoxModFolder.Text;
    }

    private void Form1_Shown(object sender, EventArgs e) {
        ModCache.RescanModCacheFolder();
        RefreshListView();

        GetSelectedMod();
        olvModList.Focus();
    }


    public static void RefreshListView() {
        instance.olvModList.BeginUpdate();

        var oldSel = instance.olvModList.SelectedObject;

        instance.olvModList.Items.Clear();
        instance.olvModList.SetObjects(instance.modsData.modInfos, true);

        //
        //foreach(ModInfo mod in instance.modsData.modInfos) {
        //    if(!mod.archiveExists) {
        //        instance.olvModList.GetItem(instance.olvModList.IndexOf(mod)).ForeColor = Color.Orange;
        //    }
        //}


        instance.olvModList.EndUpdate();

        if (oldSel != null) {
            instance.olvModList.SelectedObject = oldSel;
            instance.olvModList.EnsureModelVisible(oldSel);
        }
    }


    private void olvModList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e) {
        RefreshTreeView();
        richBoxFile.Clear();
    }

    private void treeViewFiles_AfterSelect(object sender, TreeViewEventArgs e) {
        ModInfo selMod = GetSelectedMod();
        if (!selMod || e.Node == null) return;

        ArchiveFile selFile = selMod.archiveFiles.FirstOrDefault(x => x.belongingNode == e.Node);
        if (!selFile) return;

        selFile.SetInfo(richBoxFile, e.Node);
        //richBoxFile;
    }

    public static void RefreshTreeView() {
        instance.treeViewFiles.BeginUpdate();

        instance.treeViewFiles.Nodes.Clear();

        ModInfo selMod = instance.GetSelectedMod();
        if (!selMod) return;

        instance.labelSelectedMod.Text = selMod.modName;

        selMod.SetInfo(instance.richBoxMod);

        var topFiles = selMod.archiveFiles.Where(x => !x.parent);
        foreach (ArchiveFile file in topFiles) {
            RecurseTreeView(file);
        }

        foreach (ArchiveFile file in selMod.archiveFiles) {
            if (!file.isDir && file.installed) {

            }
        }

        if (selMod.installed || selMod.partiallyInstalled) {
            CheckTreeFilesInstalled(topFiles);
        } else {
            CheckTreeFilesNotInstalled(topFiles);
        }

        instance.treeViewFiles.EndUpdate();
    }

    static void CheckTreeFilesInstalled(IEnumerable<ArchiveFile> topFiles) {
        foreach (var file in topFiles) {
            file.belongingNode.Checked = file.GetInstalledStatus();
            if (!file.isDir && file.isTopFile && !instance.modsData.useTopLevelFiles) {
                file.belongingNode.ForeColor = Color.DarkGray;
                file.belongingNode.ToolTipText = "Ignored because it is a top-level file and the \"ignore top-level files\" option is on.";

            } else if (file.installed) {
                if (file.installedNotMatching) {
                    file.belongingNode.ForeColor = Color.Orange;
                    file.belongingNode.ToolTipText = "The file exists in the folder but it is not from this mod. (Checksums don't match)\n" +
                        "   Select this file to see what mod the file actually belongs to.";
                } else {
                    file.belongingNode.ForeColor = Color.LawnGreen;
                    file.belongingNode.ToolTipText = "This file is installed in the folder and the checksum matches this mod.";
                }
            } else {
                file.belongingNode.ForeColor = Color.LightYellow;
                file.belongingNode.ToolTipText = "This file isn't found at all in the folder.";
            }
            CheckTreeFilesInstalled(file.children);
        }
    }

    static void CheckTreeFilesNotInstalled(IEnumerable<ArchiveFile> topFiles) {
        foreach (var file in topFiles) {
            file.belongingNode.Checked = instance.modsData.useTopLevelFiles || !file.isTopFile;
            if (!file.isDir && File.Exists(file.installedPath)) {
                file.belongingNode.ToolTipText = "File exists from another mod.";
                file.belongingNode.ForeColor = Color.Coral;
            } else {
                if (file.belongingNode.Checked) {
                    file.belongingNode.ToolTipText = "File does not exist in the mod folder and is ready to be installed.";
                    file.belongingNode.ForeColor = Color.WhiteSmoke;
                } else {
                    file.belongingNode.ToolTipText = "File is ignored because it is a top-level file and the \"ignore top-level files\" option is on.";
                    file.belongingNode.ForeColor = Color.DarkGray;
                }
            }

            CheckTreeFilesNotInstalled(file.children);
        }
    }

    static void RecurseTreeView(ArchiveFile pFile, TreeNode pNode = null) {
        TreeNode node = new TreeNode(Path.GetFileName(pFile.path));
        pFile.belongingNode = node;

        if (pNode == null) {
            pFile.GetInstalled();
            instance.treeViewFiles.Nodes.Add(node);
        } else {
            pNode.Nodes.Add(node);
        }

        foreach (ArchiveFile childFile in pFile.children) {
            //Console.WriteLine($"{pFile.path} -> {childFile.path}");
            RecurseTreeView(childFile, node);
        }

        node.Expand();
    }

    public ModInfo GetSelectedMod() {
        if (olvModList.GetItemCount() == 0) {
            return null;
        }

        ModInfo selMod = olvModList.SelectedObject as ModInfo;

        if (!selMod) {
            olvModList.SelectedIndex = 0;
            selMod = olvModList.GetModelObject(0) as ModInfo;
        }

        return selMod;
    }




    private void treeViewFiles_AfterCheck(object sender, TreeViewEventArgs e) {
        if (e.Action == TreeViewAction.Unknown) return;
        treeViewFiles.BeginUpdate();


        RecurseAfterCheckDown(e.Node);

        if (e.Node.Parent != null)
            RecurseAfterCheckUp(e.Node.Parent);

        treeViewFiles.SelectedNode = e.Node;

        treeViewFiles.EndUpdate();
    }

    void RecurseAfterCheckUp(TreeNode node) {
        bool check = true;
        foreach (TreeNode childNode in node.Nodes) {
            if (!childNode.Checked)
                check = false;
        }
        node.Checked = check;

        if (node.Parent != null)
            RecurseAfterCheckUp(node.Parent);
    }
    void RecurseAfterCheckDown(TreeNode node) {
        foreach (TreeNode childNode in node.Nodes) {
            childNode.Checked = node.Checked;
            RecurseAfterCheckDown(childNode);
        }
    }


    private void buttonRescanCache_Click(object sender, EventArgs e) {
        ModCache.RescanModCacheFolder();

        olvModList.Refresh();
        RefreshTreeView();
        RefreshListView();
    }

    private void buttonRescanInstall_Click(object sender, EventArgs e) {
        buttonRescanInstall.Text = "Scanning...";
        buttonRescanInstall.Refresh();

        ModCache.ReCheckMods(modsData.modInfos);

        foreach (var mod in modsData.modInfos) {
            mod.CheckIfInstalled();
        }

        buttonRescanInstall.Text = "Re-Scan Installations";

        SaveData();

        olvModList.Refresh();
        RefreshTreeView();
    }


    //✔ ✓
    private void textBoxGameDir_TextChanged(object sender, EventArgs e) {
        if (Directory.Exists(textBoxGameDir.Text)) {
            labelGameDirExists.ForeColor = Color.LawnGreen;
            labelGameDirExists.Text = "✓";
            modsData.gameDir = textBoxGameDir.Text;
        } else {
            labelGameDirExists.ForeColor = Color.Tomato;
            labelGameDirExists.Text = "X";
        }
    }



    private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
        SaveData();
    }

    public static void SaveData() {
        Serializer.SaveObj(instance.modsData, Serializer.GetDataFilePath());
    }


    private void olvModList_DragEnter(object sender, DragEventArgs e) {
        e.Effect = DragDropEffects.Move;
    }

    private void olvModList_DragDrop(object sender, DragEventArgs e) {
        string modCacheFolder = Serializer.GetModsCacheFolder();
        Directory.CreateDirectory(modCacheFolder);

        var files = e.Data.GetData(DataFormats.FileDrop) as string[];

        if (files.Length == 0)
            return;

        string[] modFiles = Directory.GetFiles(modCacheFolder, "*", SearchOption.AllDirectories);
        string lastAdded = null;


        foreach (string file in files) {
            bool isDir = Directory.Exists(file);
            string fileName = Path.GetFileName(file);

            if (isDir) {
                FileSystem.MoveDirectory(file, modCacheFolder + fileName, UIOption.OnlyErrorDialogs, UICancelOption.DoNothing);
            } else {
                if (!modFiles.Contains(file) && !File.Exists(modCacheFolder + fileName) && File.Exists(file)) {
                    File.Move(file, modCacheFolder + fileName);
                }
                lastAdded = modCacheFolder + fileName;
            }

        }

        ModCache.RescanModCacheFolder();

        if (lastAdded != null) {
            olvModList.SelectedObject = modsData.modInfos.FindLast(x => x.modPath.ToLower() == lastAdded.ToLower());
            olvModList.EnsureModelVisible(olvModList.SelectedObject);
        }


    }

    private void deleteModArchiveToolStripMenuItem_Click(object sender, EventArgs e) {
        uninstallAllFilesToolStripMenuItem_Click(sender, e);

        deleteModArchiveWithoutUninstallingToolStripMenuItem_Click(sender, e);
    }

    private void contextList_Opening(object sender, CancelEventArgs e) {
        ModInfo selMod = GetSelectedMod();
        if (!selMod) {
            e.Cancel = true;
            return;
        }

        openLocationToolStripMenuItem.Enabled = File.Exists(selMod.modPath);


        installAllFilesToolStripMenuItem.Enabled = !selMod.installed && selMod.archiveExists;
    }

    private void deleteModArchiveWithoutUninstallingToolStripMenuItem_Click(object sender, EventArgs e) {
        ModInfo selMod = GetSelectedMod();
        if (!selMod) return;

        if (File.Exists(selMod.modPath)) {
            RecycleManager.DeleteNoWarn(selMod.modPath);
        }

        modsData.modInfos.Remove(selMod);

        RefreshListView();
    }

    private void uninstallAllFilesToolStripMenuItem_Click(object sender, EventArgs e) {
        ModInfo selMod = GetSelectedMod();
        if (!selMod) return;

        ArchiveManager.UninstallSelected(selMod);
    }

    private void installAllFilesToolStripMenuItem_Click(object sender, EventArgs e) {
        ModInfo selMod = GetSelectedMod();
        if (!selMod) return;

        buttonCheckAll_Click(null, null);
        ArchiveManager.InstallSelected(selMod);
        ArchiveManager.DeleteEmptyDirs(Serializer.GetGameModFolder());
    }

    private void olvModList_AfterSorting(object sender, BrightIdeasSoftware.AfterSortingEventArgs e) {
        var obj = olvModList.SelectedObject;
        if (obj != null)
            olvModList.EnsureModelVisible(obj);
    }

    private void buttonUninstallSelected_Click(object sender, EventArgs e) {
        ModInfo selMod = GetSelectedMod();
        if (!selMod) return;

        ArchiveManager.UninstallSelected(selMod);
        ArchiveManager.DeleteEmptyDirs(Serializer.GetGameModFolder());
    }

    private void buttonInstallSelected_Click(object sender, EventArgs e) {
        ModInfo selMod = GetSelectedMod();
        if (!selMod) return;

        ArchiveManager.InstallSelected(selMod);
    }

    private void buttonUncheckAll_Click(object sender, EventArgs e) {
        foreach (TreeNode node in treeViewFiles.Nodes) {
            CheckAll(false);
        }
    }
    private void buttonCheckAll_Click(object sender, EventArgs e) {
        foreach (TreeNode node in treeViewFiles.Nodes) {
            CheckAll(true);
        }
    }

    void CheckAll(bool state) {

        var mod = GetSelectedMod();
        if (!mod) return;

        foreach (var file in mod.archiveFiles) {
            if (!file.isTopFile || modsData.useTopLevelFiles) {
                file.belongingNode.Checked = state;
            }
        }
    }

    private void openLocationToolStripMenuItem_Click(object sender, EventArgs e) {
        ModInfo selMod = GetSelectedMod();
        if (!selMod) return;

        if (File.Exists(selMod.modPath)) {
            string argument = "/select, \"" + selMod.modPath + "\"";

            System.Diagnostics.Process.Start("explorer.exe", argument);
        }
    }

    private void buttonDeleteNotFound_Click(object sender, EventArgs e) {
        modsData.modInfos.RemoveAll(mod => !File.Exists(mod.modPath));

        RefreshListView();
    }

    private void reloadArchiveToolStripMenuItem_Click(object sender, EventArgs e) {
        ModInfo selMod = GetSelectedMod();
        if (!selMod) return;

        ModCache.ReCheckMods(new ModInfo[] { selMod });

        RefreshListView();
        RefreshTreeView();
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
        System.Diagnostics.Process.Start("https://www.nexusmods.com/monsterhunterworld/mods/372?tab=files");
    }


    private void buttonSaveLoadout_Click(object sender, EventArgs e) {
        LoadoutManager.SaveLoadout();
    }

    private void buttonLoadLoadout_Click(object sender, EventArgs e) {
        LoadoutManager.LoadLoadout();
    }

    private void linkCredits_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e) {
        var credBox = InputBoxForm.OKBOX("Credits");
        credBox.TitleLabel.ForeColor = Color.White;

        credBox.richTextBox1.Height += 20;
        credBox.Height += 25;

        credBox.richTextBox1.Font = new Font("Microsoft Sans Serif", 12);
        credBox.panelBG.BorderStyle = BorderStyle.Fixed3D;

        credBox.richTextBox1.AppendText("BoltMan: Project Creator", Color.MediumSlateBlue, true);
        credBox.richTextBox1.AppendText("UncleClapton: Repo Manager/Contributor", Color.RoyalBlue, true);
        credBox.richTextBox1.AppendText("", Color.RoyalBlue, true);
        credBox.richTextBox1.AppendText("You can contribute @ https://github.com/UncleClapton/MHWModManager", Color.Orange, false);

        credBox.richTextBox1.CenterText();

        credBox.ShowDialog();
    }

    //window managemnet
    private void buttonClose_Click(object sender, EventArgs e) {
        Close();
    }

    private void button1_Click(object sender, EventArgs e) {
        WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
    }

    private void button2_Click(object sender, EventArgs e) {
        WindowState = FormWindowState.Minimized;
    }

    private void checkBoxUseTopFiles_CheckedChanged(object sender, EventArgs e) {
        modsData.useTopLevelFiles = !checkBoxIgnoreTopFiles.Checked;

        olvModList.Refresh();
        RefreshTreeView();
    }


    [StructLayout(LayoutKind.Sequential)]
    private struct RECT {
        public int left, top, right, bottom;

        public RECT(Rectangle rc) {
            this.left = rc.Left;
            this.top = rc.Top;
            this.right = rc.Right;
            this.bottom = rc.Bottom;
        }

        public Rectangle ToRectangle() {
            return Rectangle.FromLTRB(left, top, right, bottom);
        }

    }

    [StructLayout(LayoutKind.Sequential)]
    private struct WINDOWPOS {
        public IntPtr hWnd, hWndInsertAfter;
        public int x, y, cx, cy, flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct NCCALCSIZE_PARAMS {
        public RECT rgrc0, rgrc1, rgrc2;
        public WINDOWPOS lppos;
    }


    protected override void WndProc(ref Message m) {
        const uint WM_NCHITTEST = 0x0084;
        const uint WM_MOUSEMOVE = 0x0200;
        const uint HTLEFT = 10;
        const uint HTRIGHT = 11;
        const uint HTBOTTOMRIGHT = 17;
        const uint HTBOTTOM = 15;
        const uint HTBOTTOMLEFT = 16;
        const uint HTTOP = 12;
        const uint HTTOPLEFT = 13;
        const uint HTTOPRIGHT = 14;

        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;
        const int WM_NCCALCSIZE = 0x83;

        const int RESIZE_HANDLE_SIZE = 10;
        bool handled = false;
        if (m.Msg == WM_NCHITTEST || m.Msg == WM_MOUSEMOVE) {
            Size formSize = this.Size;
            Point screenPoint = new Point(m.LParam.ToInt32());
            Point clientPoint = this.PointToClient(screenPoint);

            Dictionary<uint, Rectangle> boxes = new Dictionary<uint, Rectangle>() {
            {HTBOTTOMLEFT, new Rectangle(0, formSize.Height - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
            {HTBOTTOM, new Rectangle(RESIZE_HANDLE_SIZE, formSize.Height - RESIZE_HANDLE_SIZE, formSize.Width - 2*RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
            {HTBOTTOMRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, formSize.Height - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
            {HTRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, formSize.Height - 2*RESIZE_HANDLE_SIZE)},
            {HTTOPRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, 0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
            {HTTOP, new Rectangle(RESIZE_HANDLE_SIZE, 0, formSize.Width - 2*RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
            {HTTOPLEFT, new Rectangle(0, 0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
            {HTLEFT, new Rectangle(0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, formSize.Height - 2*RESIZE_HANDLE_SIZE) }
        };

            foreach (KeyValuePair<uint, Rectangle> hitBox in boxes) {
                if (hitBox.Value.Contains(clientPoint)) {
                    m.Result = (IntPtr)hitBox.Key;
                    handled = true;
                    break;
                }
            }
        }

        if (m.Msg == WM_NCCALCSIZE) {
            if (m.WParam.Equals(IntPtr.Zero)) {
                RECT rc = (RECT)m.GetLParam(typeof(RECT));
                Rectangle r = rc.ToRectangle();
                //r.Inflate(0, 0);
                Marshal.StructureToPtr(new RECT(r), m.LParam, true);
            } else {
                NCCALCSIZE_PARAMS csp = (NCCALCSIZE_PARAMS)m.GetLParam(typeof(NCCALCSIZE_PARAMS));
                Rectangle r = csp.rgrc0.ToRectangle();
                //r.Inflate(0,0);
                csp.rgrc0 = new RECT(r);
                Marshal.StructureToPtr(csp, m.LParam, true);
            }
            m.Result = IntPtr.Zero;
            handled = true;
        }


        if (!handled)
            base.WndProc(ref m);
    }

    
}

partial class MainForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitListAndRest = new System.Windows.Forms.SplitContainer();
            this.olvModList = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumnName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnInstalled = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnSize = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnCat = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.contextList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteModArchiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteModArchiveWithoutUninstallingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installAllFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uninstallAllFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadArchiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRescanInstall = new System.Windows.Forms.Button();
            this.buttonDeleteNotFound = new System.Windows.Forms.Button();
            this.buttonRescanCache = new System.Windows.Forms.Button();
            this.splitTreeAndInfo = new System.Windows.Forms.SplitContainer();
            this.treeViewFiles = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCheckAll = new System.Windows.Forms.Button();
            this.buttonUncheckAll = new System.Windows.Forms.Button();
            this.labelSelectedMod = new System.Windows.Forms.Label();
            this.splitInfos = new System.Windows.Forms.SplitContainer();
            this.richBoxMod = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonInstallSelected = new System.Windows.Forms.Button();
            this.buttonUninstallSelected = new System.Windows.Forms.Button();
            this.richBoxFile = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxGameDir = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelGameDirExists = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonLoadLoadout = new System.Windows.Forms.Button();
            this.buttonSaveLoadout = new System.Windows.Forms.Button();
            this.checkBoxIgnoreTopFiles = new System.Windows.Forms.CheckBox();
            this.textBoxModFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tip = new System.Windows.Forms.ToolTip(this.components);
            this.topPanel = new DraggablePanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.linkCredits = new System.Windows.Forms.LinkLabel();
            this.linkNewUpdate = new System.Windows.Forms.LinkLabel();
            this.labelTitle = new PassThroughLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitListAndRest)).BeginInit();
            this.splitListAndRest.Panel1.SuspendLayout();
            this.splitListAndRest.Panel2.SuspendLayout();
            this.splitListAndRest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvModList)).BeginInit();
            this.contextList.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitTreeAndInfo)).BeginInit();
            this.splitTreeAndInfo.Panel1.SuspendLayout();
            this.splitTreeAndInfo.Panel2.SuspendLayout();
            this.splitTreeAndInfo.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitInfos)).BeginInit();
            this.splitInfos.Panel1.SuspendLayout();
            this.splitInfos.Panel2.SuspendLayout();
            this.splitInfos.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitListAndRest
            // 
            resources.ApplyResources(this.splitListAndRest, "splitListAndRest");
            this.splitListAndRest.Name = "splitListAndRest";
            // 
            // splitListAndRest.Panel1
            // 
            resources.ApplyResources(this.splitListAndRest.Panel1, "splitListAndRest.Panel1");
            this.splitListAndRest.Panel1.Controls.Add(this.olvModList);
            this.splitListAndRest.Panel1.Controls.Add(this.tableLayoutPanel3);
            this.tip.SetToolTip(this.splitListAndRest.Panel1, resources.GetString("splitListAndRest.Panel1.ToolTip"));
            // 
            // splitListAndRest.Panel2
            // 
            resources.ApplyResources(this.splitListAndRest.Panel2, "splitListAndRest.Panel2");
            this.splitListAndRest.Panel2.Controls.Add(this.splitTreeAndInfo);
            this.tip.SetToolTip(this.splitListAndRest.Panel2, resources.GetString("splitListAndRest.Panel2.ToolTip"));
            this.tip.SetToolTip(this.splitListAndRest, resources.GetString("splitListAndRest.ToolTip"));
            // 
            // olvModList
            // 
            resources.ApplyResources(this.olvModList, "olvModList");
            this.olvModList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.olvModList.AllColumns.Add(this.olvColumnName);
            this.olvModList.AllColumns.Add(this.olvColumnInstalled);
            this.olvModList.AllColumns.Add(this.olvColumnSize);
            this.olvModList.AllColumns.Add(this.olvColumnDate);
            this.olvModList.AllColumns.Add(this.olvColumnCat);
            this.olvModList.AllowColumnReorder = true;
            this.olvModList.AllowDrop = true;
            this.olvModList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.olvModList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnName,
            this.olvColumnInstalled,
            this.olvColumnSize,
            this.olvColumnDate,
            this.olvColumnCat});
            this.olvModList.ContextMenuStrip = this.contextList;
            this.olvModList.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.olvModList.FullRowSelect = true;
            this.olvModList.HideSelection = false;
            this.olvModList.MultiSelect = false;
            this.olvModList.Name = "olvModList";
            this.olvModList.OverlayText.Text = resources.GetString("resource.Text");
            this.olvModList.ShowGroups = false;
            this.tip.SetToolTip(this.olvModList, resources.GetString("olvModList.ToolTip"));
            this.olvModList.UseCompatibleStateImageBehavior = false;
            this.olvModList.View = System.Windows.Forms.View.Details;
            this.olvModList.VirtualMode = true;
            this.olvModList.AfterSorting += new System.EventHandler<BrightIdeasSoftware.AfterSortingEventArgs>(this.olvModList_AfterSorting);
            this.olvModList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.olvModList_ItemSelectionChanged);
            this.olvModList.DragDrop += new System.Windows.Forms.DragEventHandler(this.olvModList_DragDrop);
            this.olvModList.DragEnter += new System.Windows.Forms.DragEventHandler(this.olvModList_DragEnter);
            // 
            // olvColumnName
            // 
            this.olvColumnName.AspectName = "modName";
            this.olvColumnName.CellPadding = null;
            resources.ApplyResources(this.olvColumnName, "olvColumnName");
            // 
            // olvColumnInstalled
            // 
            this.olvColumnInstalled.AspectName = "intalledText";
            this.olvColumnInstalled.CellPadding = null;
            resources.ApplyResources(this.olvColumnInstalled, "olvColumnInstalled");
            // 
            // olvColumnSize
            // 
            this.olvColumnSize.AspectName = "fileSize";
            this.olvColumnSize.AspectToStringFormat = "sizeSuffixed";
            this.olvColumnSize.CellPadding = null;
            resources.ApplyResources(this.olvColumnSize, "olvColumnSize");
            // 
            // olvColumnDate
            // 
            this.olvColumnDate.AspectName = "date";
            this.olvColumnDate.CellPadding = null;
            resources.ApplyResources(this.olvColumnDate, "olvColumnDate");
            // 
            // olvColumnCat
            // 
            this.olvColumnCat.AspectName = "category";
            this.olvColumnCat.CellPadding = null;
            resources.ApplyResources(this.olvColumnCat, "olvColumnCat");
            // 
            // contextList
            // 
            resources.ApplyResources(this.contextList, "contextList");
            this.contextList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.contextList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteModArchiveToolStripMenuItem,
            this.deleteModArchiveWithoutUninstallingToolStripMenuItem,
            this.installAllFilesToolStripMenuItem,
            this.uninstallAllFilesToolStripMenuItem,
            this.openLocationToolStripMenuItem,
            this.reloadArchiveToolStripMenuItem});
            this.contextList.Name = "contextList";
            this.contextList.ShowImageMargin = false;
            this.tip.SetToolTip(this.contextList, resources.GetString("contextList.ToolTip"));
            this.contextList.Opening += new System.ComponentModel.CancelEventHandler(this.contextList_Opening);
            // 
            // deleteModArchiveToolStripMenuItem
            // 
            resources.ApplyResources(this.deleteModArchiveToolStripMenuItem, "deleteModArchiveToolStripMenuItem");
            this.deleteModArchiveToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.deleteModArchiveToolStripMenuItem.Name = "deleteModArchiveToolStripMenuItem";
            this.deleteModArchiveToolStripMenuItem.Click += new System.EventHandler(this.deleteModArchiveToolStripMenuItem_Click);
            // 
            // deleteModArchiveWithoutUninstallingToolStripMenuItem
            // 
            resources.ApplyResources(this.deleteModArchiveWithoutUninstallingToolStripMenuItem, "deleteModArchiveWithoutUninstallingToolStripMenuItem");
            this.deleteModArchiveWithoutUninstallingToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.deleteModArchiveWithoutUninstallingToolStripMenuItem.Name = "deleteModArchiveWithoutUninstallingToolStripMenuItem";
            this.deleteModArchiveWithoutUninstallingToolStripMenuItem.Click += new System.EventHandler(this.deleteModArchiveWithoutUninstallingToolStripMenuItem_Click);
            // 
            // installAllFilesToolStripMenuItem
            // 
            resources.ApplyResources(this.installAllFilesToolStripMenuItem, "installAllFilesToolStripMenuItem");
            this.installAllFilesToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.installAllFilesToolStripMenuItem.Name = "installAllFilesToolStripMenuItem";
            this.installAllFilesToolStripMenuItem.Click += new System.EventHandler(this.installAllFilesToolStripMenuItem_Click);
            // 
            // uninstallAllFilesToolStripMenuItem
            // 
            resources.ApplyResources(this.uninstallAllFilesToolStripMenuItem, "uninstallAllFilesToolStripMenuItem");
            this.uninstallAllFilesToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.uninstallAllFilesToolStripMenuItem.Name = "uninstallAllFilesToolStripMenuItem";
            this.uninstallAllFilesToolStripMenuItem.Click += new System.EventHandler(this.uninstallAllFilesToolStripMenuItem_Click);
            // 
            // openLocationToolStripMenuItem
            // 
            resources.ApplyResources(this.openLocationToolStripMenuItem, "openLocationToolStripMenuItem");
            this.openLocationToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.openLocationToolStripMenuItem.Name = "openLocationToolStripMenuItem";
            this.openLocationToolStripMenuItem.Click += new System.EventHandler(this.openLocationToolStripMenuItem_Click);
            // 
            // reloadArchiveToolStripMenuItem
            // 
            resources.ApplyResources(this.reloadArchiveToolStripMenuItem, "reloadArchiveToolStripMenuItem");
            this.reloadArchiveToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.reloadArchiveToolStripMenuItem.Name = "reloadArchiveToolStripMenuItem";
            this.reloadArchiveToolStripMenuItem.Click += new System.EventHandler(this.reloadArchiveToolStripMenuItem_Click);
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.buttonRescanInstall, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonDeleteNotFound, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonRescanCache, 0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tip.SetToolTip(this.tableLayoutPanel3, resources.GetString("tableLayoutPanel3.ToolTip"));
            // 
            // buttonRescanInstall
            // 
            resources.ApplyResources(this.buttonRescanInstall, "buttonRescanInstall");
            this.buttonRescanInstall.Name = "buttonRescanInstall";
            this.tip.SetToolTip(this.buttonRescanInstall, resources.GetString("buttonRescanInstall.ToolTip"));
            this.buttonRescanInstall.UseVisualStyleBackColor = true;
            this.buttonRescanInstall.Click += new System.EventHandler(this.buttonRescanInstall_Click);
            // 
            // buttonDeleteNotFound
            // 
            resources.ApplyResources(this.buttonDeleteNotFound, "buttonDeleteNotFound");
            this.buttonDeleteNotFound.Name = "buttonDeleteNotFound";
            this.tip.SetToolTip(this.buttonDeleteNotFound, resources.GetString("buttonDeleteNotFound.ToolTip"));
            this.buttonDeleteNotFound.UseVisualStyleBackColor = true;
            this.buttonDeleteNotFound.Click += new System.EventHandler(this.buttonDeleteNotFound_Click);
            // 
            // buttonRescanCache
            // 
            resources.ApplyResources(this.buttonRescanCache, "buttonRescanCache");
            this.buttonRescanCache.Name = "buttonRescanCache";
            this.tip.SetToolTip(this.buttonRescanCache, resources.GetString("buttonRescanCache.ToolTip"));
            this.buttonRescanCache.UseVisualStyleBackColor = true;
            this.buttonRescanCache.Click += new System.EventHandler(this.buttonRescanCache_Click);
            // 
            // splitTreeAndInfo
            // 
            resources.ApplyResources(this.splitTreeAndInfo, "splitTreeAndInfo");
            this.splitTreeAndInfo.Name = "splitTreeAndInfo";
            // 
            // splitTreeAndInfo.Panel1
            // 
            resources.ApplyResources(this.splitTreeAndInfo.Panel1, "splitTreeAndInfo.Panel1");
            this.splitTreeAndInfo.Panel1.Controls.Add(this.treeViewFiles);
            this.splitTreeAndInfo.Panel1.Controls.Add(this.tableLayoutPanel2);
            this.splitTreeAndInfo.Panel1.Controls.Add(this.labelSelectedMod);
            this.tip.SetToolTip(this.splitTreeAndInfo.Panel1, resources.GetString("splitTreeAndInfo.Panel1.ToolTip"));
            // 
            // splitTreeAndInfo.Panel2
            // 
            resources.ApplyResources(this.splitTreeAndInfo.Panel2, "splitTreeAndInfo.Panel2");
            this.splitTreeAndInfo.Panel2.Controls.Add(this.splitInfos);
            this.tip.SetToolTip(this.splitTreeAndInfo.Panel2, resources.GetString("splitTreeAndInfo.Panel2.ToolTip"));
            this.tip.SetToolTip(this.splitTreeAndInfo, resources.GetString("splitTreeAndInfo.ToolTip"));
            // 
            // treeViewFiles
            // 
            resources.ApplyResources(this.treeViewFiles, "treeViewFiles");
            this.treeViewFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.treeViewFiles.CheckBoxes = true;
            this.treeViewFiles.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.treeViewFiles.FullRowSelect = true;
            this.treeViewFiles.HideSelection = false;
            this.treeViewFiles.Name = "treeViewFiles";
            this.treeViewFiles.ShowNodeToolTips = true;
            this.tip.SetToolTip(this.treeViewFiles, resources.GetString("treeViewFiles.ToolTip"));
            this.treeViewFiles.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeViewFiles_AfterCheck);
            this.treeViewFiles.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewFiles_AfterSelect);
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.buttonCheckAll, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonUncheckAll, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tip.SetToolTip(this.tableLayoutPanel2, resources.GetString("tableLayoutPanel2.ToolTip"));
            // 
            // buttonCheckAll
            // 
            resources.ApplyResources(this.buttonCheckAll, "buttonCheckAll");
            this.buttonCheckAll.Name = "buttonCheckAll";
            this.tip.SetToolTip(this.buttonCheckAll, resources.GetString("buttonCheckAll.ToolTip"));
            this.buttonCheckAll.UseVisualStyleBackColor = true;
            this.buttonCheckAll.Click += new System.EventHandler(this.buttonCheckAll_Click);
            // 
            // buttonUncheckAll
            // 
            resources.ApplyResources(this.buttonUncheckAll, "buttonUncheckAll");
            this.buttonUncheckAll.Name = "buttonUncheckAll";
            this.tip.SetToolTip(this.buttonUncheckAll, resources.GetString("buttonUncheckAll.ToolTip"));
            this.buttonUncheckAll.UseVisualStyleBackColor = true;
            this.buttonUncheckAll.Click += new System.EventHandler(this.buttonUncheckAll_Click);
            // 
            // labelSelectedMod
            // 
            resources.ApplyResources(this.labelSelectedMod, "labelSelectedMod");
            this.labelSelectedMod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSelectedMod.Name = "labelSelectedMod";
            this.tip.SetToolTip(this.labelSelectedMod, resources.GetString("labelSelectedMod.ToolTip"));
            // 
            // splitInfos
            // 
            resources.ApplyResources(this.splitInfos, "splitInfos");
            this.splitInfos.Name = "splitInfos";
            // 
            // splitInfos.Panel1
            // 
            resources.ApplyResources(this.splitInfos.Panel1, "splitInfos.Panel1");
            this.splitInfos.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.splitInfos.Panel1.Controls.Add(this.richBoxMod);
            this.splitInfos.Panel1.Controls.Add(this.label3);
            this.splitInfos.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.tip.SetToolTip(this.splitInfos.Panel1, resources.GetString("splitInfos.Panel1.ToolTip"));
            // 
            // splitInfos.Panel2
            // 
            resources.ApplyResources(this.splitInfos.Panel2, "splitInfos.Panel2");
            this.splitInfos.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.splitInfos.Panel2.Controls.Add(this.richBoxFile);
            this.splitInfos.Panel2.Controls.Add(this.label4);
            this.tip.SetToolTip(this.splitInfos.Panel2, resources.GetString("splitInfos.Panel2.ToolTip"));
            this.tip.SetToolTip(this.splitInfos, resources.GetString("splitInfos.ToolTip"));
            // 
            // richBoxMod
            // 
            resources.ApplyResources(this.richBoxMod, "richBoxMod");
            this.richBoxMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.richBoxMod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richBoxMod.Cursor = System.Windows.Forms.Cursors.Default;
            this.richBoxMod.DetectUrls = false;
            this.richBoxMod.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.richBoxMod.HideSelection = false;
            this.richBoxMod.Name = "richBoxMod";
            this.richBoxMod.ReadOnly = true;
            this.tip.SetToolTip(this.richBoxMod, resources.GetString("richBoxMod.ToolTip"));
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Name = "label3";
            this.tip.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.buttonInstallSelected, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonUninstallSelected, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tip.SetToolTip(this.tableLayoutPanel1, resources.GetString("tableLayoutPanel1.ToolTip"));
            // 
            // buttonInstallSelected
            // 
            resources.ApplyResources(this.buttonInstallSelected, "buttonInstallSelected");
            this.buttonInstallSelected.Name = "buttonInstallSelected";
            this.tip.SetToolTip(this.buttonInstallSelected, resources.GetString("buttonInstallSelected.ToolTip"));
            this.buttonInstallSelected.UseVisualStyleBackColor = true;
            this.buttonInstallSelected.Click += new System.EventHandler(this.buttonInstallSelected_Click);
            // 
            // buttonUninstallSelected
            // 
            resources.ApplyResources(this.buttonUninstallSelected, "buttonUninstallSelected");
            this.buttonUninstallSelected.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.buttonUninstallSelected.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.buttonUninstallSelected.Name = "buttonUninstallSelected";
            this.tip.SetToolTip(this.buttonUninstallSelected, resources.GetString("buttonUninstallSelected.ToolTip"));
            this.buttonUninstallSelected.UseVisualStyleBackColor = true;
            this.buttonUninstallSelected.Click += new System.EventHandler(this.buttonUninstallSelected_Click);
            // 
            // richBoxFile
            // 
            resources.ApplyResources(this.richBoxFile, "richBoxFile");
            this.richBoxFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.richBoxFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richBoxFile.Cursor = System.Windows.Forms.Cursors.Default;
            this.richBoxFile.DetectUrls = false;
            this.richBoxFile.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.richBoxFile.HideSelection = false;
            this.richBoxFile.Name = "richBoxFile";
            this.richBoxFile.ReadOnly = true;
            this.tip.SetToolTip(this.richBoxFile, resources.GetString("richBoxFile.ToolTip"));
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Name = "label4";
            this.tip.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.textBoxGameDir);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Name = "panel1";
            this.tip.SetToolTip(this.panel1, resources.GetString("panel1.ToolTip"));
            // 
            // textBoxGameDir
            // 
            resources.ApplyResources(this.textBoxGameDir, "textBoxGameDir");
            this.textBoxGameDir.Name = "textBoxGameDir";
            this.tip.SetToolTip(this.textBoxGameDir, resources.GetString("textBoxGameDir.ToolTip"));
            this.textBoxGameDir.TextChanged += new System.EventHandler(this.textBoxGameDir_TextChanged);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelGameDirExists);
            this.panel2.ForeColor = System.Drawing.Color.Tomato;
            this.panel2.Name = "panel2";
            this.tip.SetToolTip(this.panel2, resources.GetString("panel2.ToolTip"));
            // 
            // labelGameDirExists
            // 
            resources.ApplyResources(this.labelGameDirExists, "labelGameDirExists");
            this.labelGameDirExists.Name = "labelGameDirExists";
            this.tip.SetToolTip(this.labelGameDirExists, resources.GetString("labelGameDirExists.ToolTip"));
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.tip.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Controls.Add(this.buttonLoadLoadout);
            this.panel3.Controls.Add(this.buttonSaveLoadout);
            this.panel3.Controls.Add(this.checkBoxIgnoreTopFiles);
            this.panel3.Controls.Add(this.textBoxModFolder);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Name = "panel3";
            this.tip.SetToolTip(this.panel3, resources.GetString("panel3.ToolTip"));
            // 
            // buttonLoadLoadout
            // 
            resources.ApplyResources(this.buttonLoadLoadout, "buttonLoadLoadout");
            this.buttonLoadLoadout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.buttonLoadLoadout.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonLoadLoadout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.buttonLoadLoadout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.buttonLoadLoadout.Name = "buttonLoadLoadout";
            this.tip.SetToolTip(this.buttonLoadLoadout, resources.GetString("buttonLoadLoadout.ToolTip"));
            this.buttonLoadLoadout.UseVisualStyleBackColor = false;
            this.buttonLoadLoadout.Click += new System.EventHandler(this.buttonLoadLoadout_Click);
            // 
            // buttonSaveLoadout
            // 
            resources.ApplyResources(this.buttonSaveLoadout, "buttonSaveLoadout");
            this.buttonSaveLoadout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.buttonSaveLoadout.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonSaveLoadout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.buttonSaveLoadout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.buttonSaveLoadout.Name = "buttonSaveLoadout";
            this.tip.SetToolTip(this.buttonSaveLoadout, resources.GetString("buttonSaveLoadout.ToolTip"));
            this.buttonSaveLoadout.UseVisualStyleBackColor = false;
            this.buttonSaveLoadout.Click += new System.EventHandler(this.buttonSaveLoadout_Click);
            // 
            // checkBoxIgnoreTopFiles
            // 
            resources.ApplyResources(this.checkBoxIgnoreTopFiles, "checkBoxIgnoreTopFiles");
            this.checkBoxIgnoreTopFiles.Checked = true;
            this.checkBoxIgnoreTopFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIgnoreTopFiles.Name = "checkBoxIgnoreTopFiles";
            this.tip.SetToolTip(this.checkBoxIgnoreTopFiles, resources.GetString("checkBoxIgnoreTopFiles.ToolTip"));
            this.checkBoxIgnoreTopFiles.UseVisualStyleBackColor = true;
            this.checkBoxIgnoreTopFiles.CheckedChanged += new System.EventHandler(this.checkBoxUseTopFiles_CheckedChanged);
            // 
            // textBoxModFolder
            // 
            resources.ApplyResources(this.textBoxModFolder, "textBoxModFolder");
            this.textBoxModFolder.Name = "textBoxModFolder";
            this.tip.SetToolTip(this.textBoxModFolder, resources.GetString("textBoxModFolder.ToolTip"));
            this.textBoxModFolder.TextChanged += new System.EventHandler(this.textBoxModFolder_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.tip.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // tip
            // 
            this.tip.AutoPopDelay = 500000000;
            this.tip.InitialDelay = 100;
            this.tip.ReshowDelay = 100;
            this.tip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // topPanel
            // 
            resources.ApplyResources(this.topPanel, "topPanel");
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.topPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topPanel.Controls.Add(this.button2);
            this.topPanel.Controls.Add(this.button1);
            this.topPanel.Controls.Add(this.buttonClose);
            this.topPanel.Controls.Add(this.linkCredits);
            this.topPanel.Controls.Add(this.linkNewUpdate);
            this.topPanel.Controls.Add(this.labelTitle);
            this.topPanel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.topPanel.Name = "topPanel";
            this.tip.SetToolTip(this.topPanel, resources.GetString("topPanel.ToolTip"));
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.tip.SetToolTip(this.button2, resources.GetString("button2.ToolTip"));
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.tip.SetToolTip(this.button1, resources.GetString("button1.ToolTip"));
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonClose
            // 
            resources.ApplyResources(this.buttonClose, "buttonClose");
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.buttonClose.Name = "buttonClose";
            this.tip.SetToolTip(this.buttonClose, resources.GetString("buttonClose.ToolTip"));
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // linkCredits
            // 
            resources.ApplyResources(this.linkCredits, "linkCredits");
            this.linkCredits.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.linkCredits.DisabledLinkColor = System.Drawing.Color.PaleTurquoise;
            this.linkCredits.LinkColor = System.Drawing.Color.AliceBlue;
            this.linkCredits.Name = "linkCredits";
            this.linkCredits.TabStop = true;
            this.tip.SetToolTip(this.linkCredits, resources.GetString("linkCredits.ToolTip"));
            this.linkCredits.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCredits_LinkClicked_1);
            // 
            // linkNewUpdate
            // 
            resources.ApplyResources(this.linkNewUpdate, "linkNewUpdate");
            this.linkNewUpdate.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.linkNewUpdate.DisabledLinkColor = System.Drawing.Color.PaleTurquoise;
            this.linkNewUpdate.LinkColor = System.Drawing.Color.SandyBrown;
            this.linkNewUpdate.Name = "linkNewUpdate";
            this.linkNewUpdate.TabStop = true;
            this.tip.SetToolTip(this.linkNewUpdate, resources.GetString("linkNewUpdate.ToolTip"));
            this.linkNewUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // labelTitle
            // 
            resources.ApplyResources(this.labelTitle, "labelTitle");
            this.labelTitle.Name = "labelTitle";
            this.tip.SetToolTip(this.labelTitle, resources.GetString("labelTitle.ToolTip"));
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.splitListAndRest);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topPanel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Name = "MainForm";
            this.tip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.splitListAndRest.Panel1.ResumeLayout(false);
            this.splitListAndRest.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitListAndRest)).EndInit();
            this.splitListAndRest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvModList)).EndInit();
            this.contextList.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.splitTreeAndInfo.Panel1.ResumeLayout(false);
            this.splitTreeAndInfo.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitTreeAndInfo)).EndInit();
            this.splitTreeAndInfo.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.splitInfos.Panel1.ResumeLayout(false);
            this.splitInfos.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitInfos)).EndInit();
            this.splitInfos.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private DraggablePanel topPanel;
    private PassThroughLabel labelTitle;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button buttonClose;
    private System.Windows.Forms.SplitContainer splitListAndRest;
    private BrightIdeasSoftware.FastObjectListView olvModList;    
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox textBoxGameDir;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label labelGameDirExists;
    private BrightIdeasSoftware.OLVColumn olvColumnName;
    private System.Windows.Forms.SplitContainer splitTreeAndInfo;
    private System.Windows.Forms.TreeView treeViewFiles;
    private System.Windows.Forms.SplitContainer splitInfos;
    private BrightIdeasSoftware.OLVColumn olvColumnInstalled;
    private BrightIdeasSoftware.OLVColumn olvColumnCat;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.CheckBox checkBoxIgnoreTopFiles;
    private System.Windows.Forms.TextBox textBoxModFolder;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button buttonRescanInstall;
    private System.Windows.Forms.Button buttonRescanCache;
    private System.Windows.Forms.Label labelSelectedMod;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ToolTip tip;
    private BrightIdeasSoftware.OLVColumn olvColumnSize;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.ContextMenuStrip contextList;
    private System.Windows.Forms.ToolStripMenuItem deleteModArchiveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem installAllFilesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem uninstallAllFilesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem deleteModArchiveWithoutUninstallingToolStripMenuItem;
    private System.Windows.Forms.Button buttonInstallSelected;
    private System.Windows.Forms.Button buttonUninstallSelected;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Button buttonCheckAll;
    private System.Windows.Forms.Button buttonUncheckAll;
    public System.Windows.Forms.RichTextBox richBoxMod;
    public System.Windows.Forms.RichTextBox richBoxFile;
    private BrightIdeasSoftware.OLVColumn olvColumnDate;
    private System.Windows.Forms.ToolStripMenuItem openLocationToolStripMenuItem;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.Button buttonDeleteNotFound;
    private System.Windows.Forms.ToolStripMenuItem reloadArchiveToolStripMenuItem;
    public System.Windows.Forms.LinkLabel linkNewUpdate;
    private System.Windows.Forms.Button buttonSaveLoadout;
    private System.Windows.Forms.Button buttonLoadLoadout;
    public System.Windows.Forms.LinkLabel linkCredits;
}



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
            this.splitListAndRest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitListAndRest.Location = new System.Drawing.Point(3, 85);
            this.splitListAndRest.Margin = new System.Windows.Forms.Padding(0);
            this.splitListAndRest.Name = "splitListAndRest";
            // 
            // splitListAndRest.Panel1
            // 
            this.splitListAndRest.Panel1.Controls.Add(this.olvModList);
            this.splitListAndRest.Panel1.Controls.Add(this.tableLayoutPanel3);
            // 
            // splitListAndRest.Panel2
            // 
            this.splitListAndRest.Panel2.Controls.Add(this.splitTreeAndInfo);
            this.splitListAndRest.Size = new System.Drawing.Size(1470, 698);
            this.splitListAndRest.SplitterDistance = 645;
            this.splitListAndRest.TabIndex = 1;
            // 
            // olvModList
            // 
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
            this.olvModList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvModList.EmptyListMsg = "Drag mod archives here or place them in folders and hit rescan cache to add them " +
    "to mod cache.";
            this.olvModList.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.olvModList.FullRowSelect = true;
            this.olvModList.HideSelection = false;
            this.olvModList.Location = new System.Drawing.Point(0, 0);
            this.olvModList.MultiSelect = false;
            this.olvModList.Name = "olvModList";
            this.olvModList.ShowGroups = false;
            this.olvModList.Size = new System.Drawing.Size(645, 656);
            this.olvModList.TabIndex = 0;
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
            this.olvColumnName.Text = "Name";
            this.olvColumnName.Width = 180;
            // 
            // olvColumnInstalled
            // 
            this.olvColumnInstalled.AspectName = "intalledText";
            this.olvColumnInstalled.CellPadding = null;
            this.olvColumnInstalled.Text = "Status";
            this.olvColumnInstalled.Width = 110;
            // 
            // olvColumnSize
            // 
            this.olvColumnSize.AspectName = "fileSize";
            this.olvColumnSize.AspectToStringFormat = "sizeSuffixed";
            this.olvColumnSize.CellPadding = null;
            this.olvColumnSize.Text = "Size";
            // 
            // olvColumnDate
            // 
            this.olvColumnDate.AspectName = "date";
            this.olvColumnDate.CellPadding = null;
            this.olvColumnDate.Text = "Date Created";
            this.olvColumnDate.Width = 100;
            // 
            // olvColumnCat
            // 
            this.olvColumnCat.AspectName = "category";
            this.olvColumnCat.CellPadding = null;
            this.olvColumnCat.Text = "Category";
            this.olvColumnCat.Width = 88;
            // 
            // contextList
            // 
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
            this.contextList.Size = new System.Drawing.Size(266, 136);
            this.contextList.Opening += new System.ComponentModel.CancelEventHandler(this.contextList_Opening);
            // 
            // deleteModArchiveToolStripMenuItem
            // 
            this.deleteModArchiveToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.deleteModArchiveToolStripMenuItem.Name = "deleteModArchiveToolStripMenuItem";
            this.deleteModArchiveToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.deleteModArchiveToolStripMenuItem.Text = "Delete Mod Archive And Uninstall";
            this.deleteModArchiveToolStripMenuItem.Click += new System.EventHandler(this.deleteModArchiveToolStripMenuItem_Click);
            // 
            // deleteModArchiveWithoutUninstallingToolStripMenuItem
            // 
            this.deleteModArchiveWithoutUninstallingToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.deleteModArchiveWithoutUninstallingToolStripMenuItem.Name = "deleteModArchiveWithoutUninstallingToolStripMenuItem";
            this.deleteModArchiveWithoutUninstallingToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.deleteModArchiveWithoutUninstallingToolStripMenuItem.Text = "Delete Mod Archive Without Uninstalling";
            this.deleteModArchiveWithoutUninstallingToolStripMenuItem.Click += new System.EventHandler(this.deleteModArchiveWithoutUninstallingToolStripMenuItem_Click);
            // 
            // installAllFilesToolStripMenuItem
            // 
            this.installAllFilesToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.installAllFilesToolStripMenuItem.Name = "installAllFilesToolStripMenuItem";
            this.installAllFilesToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.installAllFilesToolStripMenuItem.Text = "Install ALL Files";
            this.installAllFilesToolStripMenuItem.Click += new System.EventHandler(this.installAllFilesToolStripMenuItem_Click);
            // 
            // uninstallAllFilesToolStripMenuItem
            // 
            this.uninstallAllFilesToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.uninstallAllFilesToolStripMenuItem.Name = "uninstallAllFilesToolStripMenuItem";
            this.uninstallAllFilesToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.uninstallAllFilesToolStripMenuItem.Text = "Uninstall ALL Files";
            this.uninstallAllFilesToolStripMenuItem.Click += new System.EventHandler(this.uninstallAllFilesToolStripMenuItem_Click);
            // 
            // openLocationToolStripMenuItem
            // 
            this.openLocationToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.openLocationToolStripMenuItem.Name = "openLocationToolStripMenuItem";
            this.openLocationToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.openLocationToolStripMenuItem.Text = "Open Location";
            this.openLocationToolStripMenuItem.Click += new System.EventHandler(this.openLocationToolStripMenuItem_Click);
            // 
            // reloadArchiveToolStripMenuItem
            // 
            this.reloadArchiveToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.reloadArchiveToolStripMenuItem.Name = "reloadArchiveToolStripMenuItem";
            this.reloadArchiveToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.reloadArchiveToolStripMenuItem.Text = "Reload Archive";
            this.reloadArchiveToolStripMenuItem.Click += new System.EventHandler(this.reloadArchiveToolStripMenuItem_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.buttonRescanInstall, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonDeleteNotFound, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonRescanCache, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 656);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(645, 42);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // buttonRescanInstall
            // 
            this.buttonRescanInstall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRescanInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRescanInstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRescanInstall.Location = new System.Drawing.Point(431, 0);
            this.buttonRescanInstall.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.buttonRescanInstall.Name = "buttonRescanInstall";
            this.buttonRescanInstall.Size = new System.Drawing.Size(214, 42);
            this.buttonRescanInstall.TabIndex = 1;
            this.buttonRescanInstall.Text = "Re-Scan Installations";
            this.tip.SetToolTip(this.buttonRescanInstall, "Scan through the mod install folder and check the files against the mod cache.");
            this.buttonRescanInstall.UseVisualStyleBackColor = true;
            this.buttonRescanInstall.Click += new System.EventHandler(this.buttonRescanInstall_Click);
            // 
            // buttonDeleteNotFound
            // 
            this.buttonDeleteNotFound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDeleteNotFound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteNotFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteNotFound.Location = new System.Drawing.Point(216, 0);
            this.buttonDeleteNotFound.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.buttonDeleteNotFound.Name = "buttonDeleteNotFound";
            this.buttonDeleteNotFound.Size = new System.Drawing.Size(213, 42);
            this.buttonDeleteNotFound.TabIndex = 2;
            this.buttonDeleteNotFound.Text = "Remove Missing Archives";
            this.tip.SetToolTip(this.buttonDeleteNotFound, "Scan through the mod install folder and check the files against the mod cache.");
            this.buttonDeleteNotFound.UseVisualStyleBackColor = true;
            this.buttonDeleteNotFound.Click += new System.EventHandler(this.buttonDeleteNotFound_Click);
            // 
            // buttonRescanCache
            // 
            this.buttonRescanCache.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRescanCache.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRescanCache.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRescanCache.Location = new System.Drawing.Point(0, 0);
            this.buttonRescanCache.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.buttonRescanCache.Name = "buttonRescanCache";
            this.buttonRescanCache.Size = new System.Drawing.Size(214, 42);
            this.buttonRescanCache.TabIndex = 0;
            this.buttonRescanCache.Text = "Re-Scan Cache";
            this.tip.SetToolTip(this.buttonRescanCache, "Scan through the mod cache folders for new mods you\'ve added.");
            this.buttonRescanCache.UseVisualStyleBackColor = true;
            this.buttonRescanCache.Click += new System.EventHandler(this.buttonRescanCache_Click);
            // 
            // splitTreeAndInfo
            // 
            this.splitTreeAndInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitTreeAndInfo.Location = new System.Drawing.Point(0, 0);
            this.splitTreeAndInfo.Name = "splitTreeAndInfo";
            // 
            // splitTreeAndInfo.Panel1
            // 
            this.splitTreeAndInfo.Panel1.Controls.Add(this.treeViewFiles);
            this.splitTreeAndInfo.Panel1.Controls.Add(this.tableLayoutPanel2);
            this.splitTreeAndInfo.Panel1.Controls.Add(this.labelSelectedMod);
            // 
            // splitTreeAndInfo.Panel2
            // 
            this.splitTreeAndInfo.Panel2.Controls.Add(this.splitInfos);
            this.splitTreeAndInfo.Size = new System.Drawing.Size(821, 698);
            this.splitTreeAndInfo.SplitterDistance = 446;
            this.splitTreeAndInfo.TabIndex = 0;
            // 
            // treeViewFiles
            // 
            this.treeViewFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.treeViewFiles.CheckBoxes = true;
            this.treeViewFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewFiles.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.treeViewFiles.FullRowSelect = true;
            this.treeViewFiles.HideSelection = false;
            this.treeViewFiles.Location = new System.Drawing.Point(0, 21);
            this.treeViewFiles.Name = "treeViewFiles";
            this.treeViewFiles.ShowNodeToolTips = true;
            this.treeViewFiles.Size = new System.Drawing.Size(446, 635);
            this.treeViewFiles.TabIndex = 0;
            this.treeViewFiles.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeViewFiles_AfterCheck);
            this.treeViewFiles.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewFiles_AfterSelect);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.buttonCheckAll, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonUncheckAll, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 656);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(446, 42);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // buttonCheckAll
            // 
            this.buttonCheckAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCheckAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckAll.Location = new System.Drawing.Point(223, 0);
            this.buttonCheckAll.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCheckAll.Name = "buttonCheckAll";
            this.buttonCheckAll.Size = new System.Drawing.Size(223, 42);
            this.buttonCheckAll.TabIndex = 3;
            this.buttonCheckAll.Text = "Check All Files";
            this.buttonCheckAll.UseVisualStyleBackColor = true;
            this.buttonCheckAll.Click += new System.EventHandler(this.buttonCheckAll_Click);
            // 
            // buttonUncheckAll
            // 
            this.buttonUncheckAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUncheckAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUncheckAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUncheckAll.Location = new System.Drawing.Point(0, 0);
            this.buttonUncheckAll.Margin = new System.Windows.Forms.Padding(0);
            this.buttonUncheckAll.Name = "buttonUncheckAll";
            this.buttonUncheckAll.Size = new System.Drawing.Size(223, 42);
            this.buttonUncheckAll.TabIndex = 2;
            this.buttonUncheckAll.Text = "Uncheck All Files";
            this.buttonUncheckAll.UseVisualStyleBackColor = true;
            this.buttonUncheckAll.Click += new System.EventHandler(this.buttonUncheckAll_Click);
            // 
            // labelSelectedMod
            // 
            this.labelSelectedMod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSelectedMod.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSelectedMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedMod.Location = new System.Drawing.Point(0, 0);
            this.labelSelectedMod.Name = "labelSelectedMod";
            this.labelSelectedMod.Size = new System.Drawing.Size(446, 21);
            this.labelSelectedMod.TabIndex = 1;
            this.labelSelectedMod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitInfos
            // 
            this.splitInfos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitInfos.Location = new System.Drawing.Point(0, 0);
            this.splitInfos.Name = "splitInfos";
            this.splitInfos.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitInfos.Panel1
            // 
            this.splitInfos.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.splitInfos.Panel1.Controls.Add(this.richBoxMod);
            this.splitInfos.Panel1.Controls.Add(this.label3);
            this.splitInfos.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitInfos.Panel2
            // 
            this.splitInfos.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.splitInfos.Panel2.Controls.Add(this.richBoxFile);
            this.splitInfos.Panel2.Controls.Add(this.label4);
            this.splitInfos.Size = new System.Drawing.Size(371, 698);
            this.splitInfos.SplitterDistance = 386;
            this.splitInfos.TabIndex = 0;
            // 
            // richBoxMod
            // 
            this.richBoxMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.richBoxMod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richBoxMod.Cursor = System.Windows.Forms.Cursors.Default;
            this.richBoxMod.DetectUrls = false;
            this.richBoxMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richBoxMod.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richBoxMod.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.richBoxMod.HideSelection = false;
            this.richBoxMod.Location = new System.Drawing.Point(0, 24);
            this.richBoxMod.Margin = new System.Windows.Forms.Padding(20);
            this.richBoxMod.Name = "richBoxMod";
            this.richBoxMod.ReadOnly = true;
            this.richBoxMod.Size = new System.Drawing.Size(371, 321);
            this.richBoxMod.TabIndex = 1;
            this.richBoxMod.Text = "";
            this.richBoxMod.WordWrap = false;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(371, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mod Archive Info:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonInstallSelected, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonUninstallSelected, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 345);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(371, 41);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // buttonInstallSelected
            // 
            this.buttonInstallSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonInstallSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInstallSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInstallSelected.Location = new System.Drawing.Point(188, 3);
            this.buttonInstallSelected.Name = "buttonInstallSelected";
            this.buttonInstallSelected.Size = new System.Drawing.Size(180, 35);
            this.buttonInstallSelected.TabIndex = 2;
            this.buttonInstallSelected.Text = "Install Selected Files";
            this.buttonInstallSelected.UseVisualStyleBackColor = true;
            this.buttonInstallSelected.Click += new System.EventHandler(this.buttonInstallSelected_Click);
            // 
            // buttonUninstallSelected
            // 
            this.buttonUninstallSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUninstallSelected.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.buttonUninstallSelected.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.buttonUninstallSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUninstallSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUninstallSelected.Location = new System.Drawing.Point(3, 3);
            this.buttonUninstallSelected.Name = "buttonUninstallSelected";
            this.buttonUninstallSelected.Size = new System.Drawing.Size(179, 35);
            this.buttonUninstallSelected.TabIndex = 1;
            this.buttonUninstallSelected.Text = "Uninstall Selected Files";
            this.buttonUninstallSelected.UseVisualStyleBackColor = true;
            this.buttonUninstallSelected.Click += new System.EventHandler(this.buttonUninstallSelected_Click);
            // 
            // richBoxFile
            // 
            this.richBoxFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.richBoxFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richBoxFile.Cursor = System.Windows.Forms.Cursors.Default;
            this.richBoxFile.DetectUrls = false;
            this.richBoxFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richBoxFile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richBoxFile.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.richBoxFile.HideSelection = false;
            this.richBoxFile.Location = new System.Drawing.Point(0, 24);
            this.richBoxFile.Margin = new System.Windows.Forms.Padding(20);
            this.richBoxFile.Name = "richBoxFile";
            this.richBoxFile.ReadOnly = true;
            this.richBoxFile.Size = new System.Drawing.Size(371, 284);
            this.richBoxFile.TabIndex = 2;
            this.richBoxFile.Text = "";
            this.richBoxFile.WordWrap = false;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(371, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Archive File Info:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxGameDir);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1470, 26);
            this.panel1.TabIndex = 0;
            // 
            // textBoxGameDir
            // 
            this.textBoxGameDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGameDir.Location = new System.Drawing.Point(144, 2);
            this.textBoxGameDir.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxGameDir.Name = "textBoxGameDir";
            this.textBoxGameDir.Size = new System.Drawing.Size(2296, 23);
            this.textBoxGameDir.TabIndex = 2;
            this.textBoxGameDir.TextChanged += new System.EventHandler(this.textBoxGameDir_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelGameDirExists);
            this.panel2.ForeColor = System.Drawing.Color.Tomato;
            this.panel2.Location = new System.Drawing.Point(111, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(26, 26);
            this.panel2.TabIndex = 1;
            // 
            // labelGameDirExists
            // 
            this.labelGameDirExists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGameDirExists.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameDirExists.Location = new System.Drawing.Point(0, 0);
            this.labelGameDirExists.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.labelGameDirExists.Name = "labelGameDirExists";
            this.labelGameDirExists.Size = new System.Drawing.Size(24, 24);
            this.labelGameDirExists.TabIndex = 0;
            this.labelGameDirExists.Text = "X";
            this.labelGameDirExists.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Game Directory:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonLoadLoadout);
            this.panel3.Controls.Add(this.buttonSaveLoadout);
            this.panel3.Controls.Add(this.checkBoxIgnoreTopFiles);
            this.panel3.Controls.Add(this.textBoxModFolder);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1470, 26);
            this.panel3.TabIndex = 1;
            // 
            // buttonLoadLoadout
            // 
            this.buttonLoadLoadout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.buttonLoadLoadout.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonLoadLoadout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.buttonLoadLoadout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.buttonLoadLoadout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadLoadout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadLoadout.Location = new System.Drawing.Point(588, 0);
            this.buttonLoadLoadout.Name = "buttonLoadLoadout";
            this.buttonLoadLoadout.Size = new System.Drawing.Size(126, 25);
            this.buttonLoadLoadout.TabIndex = 6;
            this.buttonLoadLoadout.Text = "Load Loadout";
            this.tip.SetToolTip(this.buttonLoadLoadout, "This simply loads the state of your");
            this.buttonLoadLoadout.UseVisualStyleBackColor = false;
            this.buttonLoadLoadout.Click += new System.EventHandler(this.buttonLoadLoadout_Click);
            // 
            // buttonSaveLoadout
            // 
            this.buttonSaveLoadout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.buttonSaveLoadout.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonSaveLoadout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.buttonSaveLoadout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.buttonSaveLoadout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveLoadout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveLoadout.Location = new System.Drawing.Point(457, 0);
            this.buttonSaveLoadout.Name = "buttonSaveLoadout";
            this.buttonSaveLoadout.Size = new System.Drawing.Size(126, 25);
            this.buttonSaveLoadout.TabIndex = 5;
            this.buttonSaveLoadout.Text = "Save Loadout";
            this.tip.SetToolTip(this.buttonSaveLoadout, resources.GetString("buttonSaveLoadout.ToolTip"));
            this.buttonSaveLoadout.UseVisualStyleBackColor = false;
            this.buttonSaveLoadout.Click += new System.EventHandler(this.buttonSaveLoadout_Click);
            // 
            // checkBoxIgnoreTopFiles
            // 
            this.checkBoxIgnoreTopFiles.AutoSize = true;
            this.checkBoxIgnoreTopFiles.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxIgnoreTopFiles.Checked = true;
            this.checkBoxIgnoreTopFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIgnoreTopFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxIgnoreTopFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIgnoreTopFiles.Location = new System.Drawing.Point(272, 2);
            this.checkBoxIgnoreTopFiles.Name = "checkBoxIgnoreTopFiles";
            this.checkBoxIgnoreTopFiles.Size = new System.Drawing.Size(165, 21);
            this.checkBoxIgnoreTopFiles.TabIndex = 4;
            this.checkBoxIgnoreTopFiles.Text = "Ignore Top-Level Files";
            this.tip.SetToolTip(this.checkBoxIgnoreTopFiles, "When enabled, files at the root of the archive will be ignored. This is good for " +
        "ignoring files like Readme\'s that arent in any folders.");
            this.checkBoxIgnoreTopFiles.UseVisualStyleBackColor = true;
            this.checkBoxIgnoreTopFiles.CheckedChanged += new System.EventHandler(this.checkBoxUseTopFiles_CheckedChanged);
            // 
            // textBoxModFolder
            // 
            this.textBoxModFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModFolder.Location = new System.Drawing.Point(88, 0);
            this.textBoxModFolder.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxModFolder.Name = "textBoxModFolder";
            this.textBoxModFolder.Size = new System.Drawing.Size(171, 23);
            this.textBoxModFolder.TabIndex = 3;
            this.textBoxModFolder.Text = "nativePC";
            this.textBoxModFolder.TextChanged += new System.EventHandler(this.textBoxModFolder_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mod Folder:";
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
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.topPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topPanel.Controls.Add(this.button2);
            this.topPanel.Controls.Add(this.button1);
            this.topPanel.Controls.Add(this.buttonClose);
            this.topPanel.Controls.Add(this.linkCredits);
            this.topPanel.Controls.Add(this.linkNewUpdate);
            this.topPanel.Controls.Add(this.labelTitle);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.topPanel.Location = new System.Drawing.Point(3, 3);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1470, 30);
            this.topPanel.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1378, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1408, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "🗖";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(1438, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(30, 28);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // linkCredits
            // 
            this.linkCredits.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.linkCredits.DisabledLinkColor = System.Drawing.Color.PaleTurquoise;
            this.linkCredits.Dock = System.Windows.Forms.DockStyle.Left;
            this.linkCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkCredits.LinkColor = System.Drawing.Color.AliceBlue;
            this.linkCredits.Location = new System.Drawing.Point(282, 0);
            this.linkCredits.Margin = new System.Windows.Forms.Padding(0);
            this.linkCredits.Name = "linkCredits";
            this.linkCredits.Size = new System.Drawing.Size(105, 28);
            this.linkCredits.TabIndex = 5;
            this.linkCredits.TabStop = true;
            this.linkCredits.Text = "and Company";
            this.linkCredits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkCredits.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCredits_LinkClicked_1);
            // 
            // linkNewUpdate
            // 
            this.linkNewUpdate.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.linkNewUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkNewUpdate.AutoSize = true;
            this.linkNewUpdate.DisabledLinkColor = System.Drawing.Color.PaleTurquoise;
            this.linkNewUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkNewUpdate.LinkColor = System.Drawing.Color.SandyBrown;
            this.linkNewUpdate.Location = new System.Drawing.Point(393, 5);
            this.linkNewUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.linkNewUpdate.Name = "linkNewUpdate";
            this.linkNewUpdate.Size = new System.Drawing.Size(153, 18);
            this.linkNewUpdate.TabIndex = 4;
            this.linkNewUpdate.TabStop = true;
            this.linkNewUpdate.Text = "New Update Available!";
            this.linkNewUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkNewUpdate.Visible = false;
            this.linkNewUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.labelTitle.Size = new System.Drawing.Size(282, 28);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "MHW Mod Manager V1.40 - By: BoltMan";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1476, 786);
            this.Controls.Add(this.splitListAndRest);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topPanel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "MHW Mod Manager";
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



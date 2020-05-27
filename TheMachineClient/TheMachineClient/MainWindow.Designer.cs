namespace TheMachineClient
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.mainIcons = new DevExpress.XtraBars.Bar();
            this.mainMenu = new DevExpress.XtraBars.Bar();
            this.testViewBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.statusBar = new DevExpress.XtraBars.Bar();
            this.primaryStatus = new DevExpress.XtraBars.BarStaticItem();
            this.machineStatus = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.tradesPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.assetListPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.assetList = new DevExpress.XtraTreeList.TreeList();
            this.assetListName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.assetListAmount = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.assetListImages = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.tradesPanel.SuspendLayout();
            this.assetListPanel.SuspendLayout();
            this.dockPanel2_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetList)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.mainIcons,
            this.mainMenu,
            this.statusBar});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.primaryStatus,
            this.machineStatus,
            this.testViewBarButtonItem});
            this.barManager.MainMenu = this.mainMenu;
            this.barManager.MaxItemId = 3;
            this.barManager.StatusBar = this.statusBar;
            // 
            // mainIcons
            // 
            this.mainIcons.BarName = "Tools";
            this.mainIcons.DockCol = 0;
            this.mainIcons.DockRow = 1;
            this.mainIcons.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.mainIcons.Text = "Tools";
            // 
            // mainMenu
            // 
            this.mainMenu.BarName = "Main menu";
            this.mainMenu.DockCol = 0;
            this.mainMenu.DockRow = 0;
            this.mainMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.mainMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.testViewBarButtonItem)});
            this.mainMenu.OptionsBar.MultiLine = true;
            this.mainMenu.OptionsBar.UseWholeRow = true;
            this.mainMenu.Text = "Main menu";
            // 
            // testViewBarButtonItem
            // 
            this.testViewBarButtonItem.Caption = "Test view";
            this.testViewBarButtonItem.Id = 2;
            this.testViewBarButtonItem.Name = "testViewBarButtonItem";
            this.testViewBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.testViewBarButtonItem_ItemClick);
            // 
            // statusBar
            // 
            this.statusBar.BarName = "Status bar";
            this.statusBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.statusBar.DockCol = 0;
            this.statusBar.DockRow = 0;
            this.statusBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.statusBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.primaryStatus),
            new DevExpress.XtraBars.LinkPersistInfo(this.machineStatus)});
            this.statusBar.OptionsBar.AllowQuickCustomization = false;
            this.statusBar.OptionsBar.DrawDragBorder = false;
            this.statusBar.OptionsBar.UseWholeRow = true;
            this.statusBar.Text = "Status bar";
            // 
            // primaryStatus
            // 
            this.primaryStatus.Caption = "Booting, please wait...";
            this.primaryStatus.Id = 0;
            this.primaryStatus.Name = "primaryStatus";
            // 
            // machineStatus
            // 
            this.machineStatus.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.machineStatus.Caption = "Unknown machine status.";
            this.machineStatus.Id = 1;
            this.machineStatus.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Gray;
            this.machineStatus.ItemAppearance.Normal.Options.UseForeColor = true;
            this.machineStatus.Name = "machineStatus";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Size = new System.Drawing.Size(1279, 41);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 680);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(1279, 21);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 41);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 639);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1279, 41);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 639);
            // 
            // documentManager
            // 
            this.documentManager.ContainerControl = this;
            this.documentManager.MenuManager = this.barManager;
            this.documentManager.View = this.tabbedView;
            this.documentManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView});
            // 
            // tabbedView
            // 
            this.tabbedView.QueryControl += new DevExpress.XtraBars.Docking2010.Views.QueryControlEventHandler(this.tabbedView_QueryControl);
            // 
            // dockManager
            // 
            this.dockManager.DockingOptions.ShowCaptionImage = true;
            this.dockManager.Form = this;
            this.dockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.tradesPanel,
            this.assetListPanel});
            this.dockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // tradesPanel
            // 
            this.tradesPanel.Controls.Add(this.dockPanel1_Container);
            this.tradesPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.tradesPanel.ID = new System.Guid("f143e866-b4a3-4ff7-b947-570c37200a61");
            this.tradesPanel.Location = new System.Drawing.Point(0, 539);
            this.tradesPanel.Name = "tradesPanel";
            this.tradesPanel.OriginalSize = new System.Drawing.Size(200, 141);
            this.tradesPanel.Size = new System.Drawing.Size(1279, 141);
            this.tradesPanel.Text = "Open Trades";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 22);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(1273, 116);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // assetListPanel
            // 
            this.assetListPanel.Controls.Add(this.dockPanel2_Container);
            this.assetListPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.assetListPanel.ID = new System.Guid("2fd45aa6-fa38-47fa-8c5c-e0b146044aae");
            this.assetListPanel.ImageOptions.Image = global::TheMachineClient.Properties.Resources.pair;
            this.assetListPanel.Location = new System.Drawing.Point(0, 41);
            this.assetListPanel.Name = "assetListPanel";
            this.assetListPanel.Options.ShowCloseButton = false;
            this.assetListPanel.OriginalSize = new System.Drawing.Size(253, 200);
            this.assetListPanel.Size = new System.Drawing.Size(253, 498);
            this.assetListPanel.Text = "Assets";
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Controls.Add(this.assetList);
            this.dockPanel2_Container.Location = new System.Drawing.Point(3, 21);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(246, 474);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // assetList
            // 
            this.assetList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.assetListName,
            this.assetListAmount});
            this.assetList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assetList.Location = new System.Drawing.Point(0, 0);
            this.assetList.MenuManager = this.barManager;
            this.assetList.Name = "assetList";
            this.assetList.BeginUnboundLoad();
            this.assetList.AppendNode(new object[] {
            "Accounts",
            "-"}, -1, 0, 0, 0);
            this.assetList.AppendNode(new object[] {
            "Exchanges",
            "-"}, -1, 0, 0, 1);
            this.assetList.EndUnboundLoad();
            this.assetList.OptionsView.ShowIndicator = false;
            this.assetList.OptionsView.ShowRoot = false;
            this.assetList.Size = new System.Drawing.Size(246, 474);
            this.assetList.StateImageList = this.assetListImages;
            this.assetList.TabIndex = 0;
            // 
            // assetListName
            // 
            this.assetListName.AppearanceCell.BackColor = System.Drawing.Color.Transparent;
            this.assetListName.Caption = "Name";
            this.assetListName.FieldName = "name";
            this.assetListName.Name = "assetListName";
            this.assetListName.OptionsColumn.AllowEdit = false;
            this.assetListName.OptionsColumn.AllowMove = false;
            this.assetListName.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.assetListName.OptionsColumn.AllowSize = false;
            this.assetListName.OptionsColumn.ReadOnly = true;
            this.assetListName.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.String;
            this.assetListName.Visible = true;
            this.assetListName.VisibleIndex = 0;
            // 
            // assetListAmount
            // 
            this.assetListAmount.Caption = "Amount [USD]";
            this.assetListAmount.FieldName = "amount";
            this.assetListAmount.Name = "assetListAmount";
            this.assetListAmount.OptionsColumn.AllowEdit = false;
            this.assetListAmount.OptionsColumn.AllowMove = false;
            this.assetListAmount.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.assetListAmount.OptionsColumn.AllowSize = false;
            this.assetListAmount.OptionsColumn.ReadOnly = true;
            this.assetListAmount.Visible = true;
            this.assetListAmount.VisibleIndex = 1;
            // 
            // assetListImages
            // 
            this.assetListImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("assetListImages.ImageStream")));
            this.assetListImages.TransparentColor = System.Drawing.Color.Transparent;
            this.assetListImages.Images.SetKeyName(0, "accounts.png");
            this.assetListImages.Images.SetKeyName(1, "server.png");
            this.assetListImages.Images.SetKeyName(2, "pair.png");
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 701);
            this.Controls.Add(this.assetListPanel);
            this.Controls.Add(this.tradesPanel);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = global::TheMachineClient.Properties.Resources.main;
            this.Name = "MainWindow";
            this.Text = "The Machine Client";
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.tradesPanel.ResumeLayout(false);
            this.assetListPanel.ResumeLayout(false);
            this.dockPanel2_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.assetList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar mainIcons;
        private DevExpress.XtraBars.Bar mainMenu;
        private DevExpress.XtraBars.Bar statusBar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Docking.DockPanel assetListPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private DevExpress.XtraBars.Docking.DockPanel tradesPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.XtraTreeList.TreeList assetList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn assetListName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn assetListAmount;
        private System.Windows.Forms.ImageList assetListImages;
        private DevExpress.XtraBars.BarStaticItem primaryStatus;
        private DevExpress.XtraBars.BarStaticItem machineStatus;
        private DevExpress.XtraBars.BarButtonItem testViewBarButtonItem;
    }
}
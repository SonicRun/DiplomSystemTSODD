namespace TSODD.Views.TsoddContextView {
    partial class TsoddContextView {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
		 #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager();
            this.tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView();
			this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
			this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.ribbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			this.ribbonPageGroupNavigation = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.barSubItemNavigation = new DevExpress.XtraBars.BarSubItem();
			this.skinRibbonGalleryBarItem = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
			this.officeNavigationBar = new DevExpress.XtraBars.Navigation.OfficeNavigationBar();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
									this.navigationBarItemFencingCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemFencingCollectionView = new DevExpress.XtraBars.BarButtonItem();
						this.navigationBarItemPublicTransportStopCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemPublicTransportStopCollectionView = new DevExpress.XtraBars.BarButtonItem();
						this.navigationBarItemRoadSignCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemRoadSignCollectionView = new DevExpress.XtraBars.BarButtonItem();
						this.navigationBarItemStreetLightCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemStreetLightCollectionView = new DevExpress.XtraBars.BarButtonItem();
						this.navigationBarItemTrafficLightCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemTrafficLightCollectionView = new DevExpress.XtraBars.BarButtonItem();
						            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar)).BeginInit();
            this.SuspendLayout();
			// 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.MaxItemId = 14;
            this.ribbonControl.Name = "ribbonControl";
			this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {this.skinRibbonGalleryBarItem, this.barSubItemNavigation });
			this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
			this.ribbonControl.StatusBar = this.ribbonStatusBar;
            // 
            // ribbonPage
            // 
            this.ribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
			this.ribbonPageGroupNavigation,
            this.ribbonPageGroup});
			this.ribbonPage.MergeOrder = -1;
            this.ribbonPage.Name = "ribbonPage";
            this.ribbonPage.Text = "View";
			// 
            // ribbonPageGroupNavigation
            // 
            this.ribbonPageGroupNavigation.ItemLinks.Add(this.barSubItemNavigation);
            this.ribbonPageGroupNavigation.Name = "ribbonPageGroupNavigation";
            this.ribbonPageGroupNavigation.Text = "Module";
			 // 
            // barSubItemNavigation
            // 
            this.barSubItemNavigation.Caption = "Navigation";
            this.barSubItemNavigation.ImageUri.Uri = "NavigationBar";
            this.barSubItemNavigation.Name = "barSubItemNavigation";
			            // 
            // ribbonPageGroup
            // 
            this.ribbonPageGroup.AllowTextClipping = false;
			this.ribbonPageGroup.ItemLinks.Add(this.skinRibbonGalleryBarItem);
            this.ribbonPageGroup.Name = "ribbonPageGroup";
            this.ribbonPageGroup.ShowCaptionButton = false;
            this.ribbonPageGroup.Text = "Appearance";
			// 
            // ribbonStatusBar
            // 
			this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
			// 
            // officeNavigationBar
            //
			this.officeNavigationBar.Dock = System.Windows.Forms.DockStyle.Bottom; 
            this.officeNavigationBar.Items.AddRange(new DevExpress.XtraBars.Navigation.NavigationBarItem[] {
            			this.navigationBarItemFencingCollectionView,
						this.navigationBarItemPublicTransportStopCollectionView,
						this.navigationBarItemRoadSignCollectionView,
						this.navigationBarItemStreetLightCollectionView,
						this.navigationBarItemTrafficLightCollectionView,
									
			});
            this.officeNavigationBar.Name = "officeNavigationBar";
            this.officeNavigationBar.Text = "officeNavigationBar";
						// 
            // navigationBarItemFencingCollectionView
            // 
			this.navigationBarItemFencingCollectionView.Name = "navigationBarItemFencingCollectionView";
            this.navigationBarItemFencingCollectionView.Text = "Fencing";
			// 
            // barButtonItemFencingCollectionView
            // 
			this.barButtonItemFencingCollectionView.Name = "barButtonItemFencingCollectionView";
            this.barButtonItemFencingCollectionView.Caption = "Fencing";
											this.barSubItemNavigation.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemFencingCollectionView));
					
						// 
            // navigationBarItemPublicTransportStopCollectionView
            // 
			this.navigationBarItemPublicTransportStopCollectionView.Name = "navigationBarItemPublicTransportStopCollectionView";
            this.navigationBarItemPublicTransportStopCollectionView.Text = "Public Transport Stop";
			// 
            // barButtonItemPublicTransportStopCollectionView
            // 
			this.barButtonItemPublicTransportStopCollectionView.Name = "barButtonItemPublicTransportStopCollectionView";
            this.barButtonItemPublicTransportStopCollectionView.Caption = "Public Transport Stop";
											this.barSubItemNavigation.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemPublicTransportStopCollectionView));
					
						// 
            // navigationBarItemRoadSignCollectionView
            // 
			this.navigationBarItemRoadSignCollectionView.Name = "navigationBarItemRoadSignCollectionView";
            this.navigationBarItemRoadSignCollectionView.Text = "Road Sign";
			// 
            // barButtonItemRoadSignCollectionView
            // 
			this.barButtonItemRoadSignCollectionView.Name = "barButtonItemRoadSignCollectionView";
            this.barButtonItemRoadSignCollectionView.Caption = "Road Sign";
											this.barSubItemNavigation.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemRoadSignCollectionView));
					
						// 
            // navigationBarItemStreetLightCollectionView
            // 
			this.navigationBarItemStreetLightCollectionView.Name = "navigationBarItemStreetLightCollectionView";
            this.navigationBarItemStreetLightCollectionView.Text = "Street Light";
			// 
            // barButtonItemStreetLightCollectionView
            // 
			this.barButtonItemStreetLightCollectionView.Name = "barButtonItemStreetLightCollectionView";
            this.barButtonItemStreetLightCollectionView.Caption = "Street Light";
											this.barSubItemNavigation.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemStreetLightCollectionView));
					
						// 
            // navigationBarItemTrafficLightCollectionView
            // 
			this.navigationBarItemTrafficLightCollectionView.Name = "navigationBarItemTrafficLightCollectionView";
            this.navigationBarItemTrafficLightCollectionView.Text = "Traffic Light";
			// 
            // barButtonItemTrafficLightCollectionView
            // 
			this.barButtonItemTrafficLightCollectionView.Name = "barButtonItemTrafficLightCollectionView";
            this.barButtonItemTrafficLightCollectionView.Caption = "Traffic Light";
											this.barSubItemNavigation.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemTrafficLightCollectionView));
					
							
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(TSODD.ViewModels.TsoddContextViewModel);
			 // 
            // navigationFrame
            // 
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always;
            this.navigationFrame.Text = "navigationFrame";
			// 
            // TsoddContextView
            // 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.navigationFrame);
            this.Controls.Add(this.officeNavigationBar);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
			this.Size = new System.Drawing.Size(1024, 768);
            this.Name = "TsoddContextView";
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
		}
		
        #endregion

		private DevExpress.XtraBars.Docking2010.DocumentManager documentManager;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
		private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
		private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup;
		private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupNavigation;
		private DevExpress.XtraBars.BarSubItem barSubItemNavigation;
		private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem;
		private DevExpress.XtraBars.Navigation.OfficeNavigationBar officeNavigationBar;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame; 
						private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemFencingCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemFencingCollectionView;
				private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemPublicTransportStopCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemPublicTransportStopCollectionView;
				private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemRoadSignCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemRoadSignCollectionView;
				private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemStreetLightCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemStreetLightCollectionView;
				private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemTrafficLightCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemTrafficLightCollectionView;
					}
}

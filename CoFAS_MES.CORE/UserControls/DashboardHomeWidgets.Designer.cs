namespace CoFAS_MES.CORE.UserControls
{
    partial class DashboardHomeWidgets
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer widgetDockingContainer1 = new DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer();
            DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer widgetDockingContainer2 = new DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer();
            DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer widgetDockingContainer3 = new DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer();
            DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer widgetDockingContainer4 = new DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer();
            DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer widgetDockingContainer5 = new DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer();
            this.dateTimeDocument = new DevExpress.XtraBars.Docking2010.Views.Widget.Document();
            this.document1 = new DevExpress.XtraBars.Docking2010.Views.Widget.Document();
            this.document2 = new DevExpress.XtraBars.Docking2010.Views.Widget.Document();
            this.documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager();
            this.widgetView1 = new DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widgetView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimeDocument
            // 
            this.dateTimeDocument.Caption = "Date & Time";
            this.dateTimeDocument.ControlName = "Clock";
            this.dateTimeDocument.ControlTypeName = "CoFAS_MES.CORE.UserControls.Clock";
            this.dateTimeDocument.FreeLayoutHeight.UnitValue = 0.51242236024844723D;
            // 
            // document1
            // 
            this.document1.Caption = "Calendar";
            this.document1.ControlName = "Calendar";
            this.document1.ControlTypeName = "CoFAS_MES.CORE.UserControls.Calendar";
            this.document1.FreeLayoutHeight.UnitValue = 1.4875776397515526D;
            // 
            // document2
            // 
            this.document2.Caption = "Notice";
            this.document2.ControlName = "Notice"; 
            this.document2.ControlTypeName = "CoFAS_MES.CORE.UserControls.Notice";
            this.document2.FreeLayoutWidth.UnitValue = 1.5456066945606692D;
            // 
            // documentManager
            // 
            this.documentManager.ContainerControl = this;
            this.documentManager.View = this.widgetView1;
            this.documentManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.widgetView1});
            // 
            // widgetView1
            // 
            this.widgetView1.DocumentProperties.AllowClose = false;
            this.widgetView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.dateTimeDocument,
            this.document1,
            this.document2});
            this.widgetView1.FreeLayoutProperties.FreeLayoutItems.AddRange(new DevExpress.XtraBars.Docking2010.Views.Widget.Document[] {
            this.dateTimeDocument,
            this.document1,
            this.document2});
            this.widgetView1.LayoutMode = DevExpress.XtraBars.Docking2010.Views.Widget.LayoutMode.FreeLayout;
            widgetDockingContainer3.Element = this.dateTimeDocument;
            widgetDockingContainer4.Element = this.document1;
            widgetDockingContainer2.Nodes.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer[] {
            widgetDockingContainer3,
            widgetDockingContainer4});
            widgetDockingContainer2.Orientation = System.Windows.Forms.Orientation.Vertical;
            widgetDockingContainer2.Size.Width.UnitValue = 0.45439330543933049D;
            widgetDockingContainer5.Element = this.document2;
            widgetDockingContainer1.Nodes.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer[] {
            widgetDockingContainer2,
            widgetDockingContainer5});
            this.widgetView1.RootContainer.Nodes.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer[] {
            widgetDockingContainer1});
            this.widgetView1.RootContainer.Orientation = System.Windows.Forms.Orientation.Vertical;
            // 
            // DashboardHomeWidgets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "DashboardHomeWidgets";
            this.Size = new System.Drawing.Size(1200, 649);
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widgetView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager;
        private DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView widgetView1;
        private DevExpress.XtraBars.Docking2010.Views.Widget.Document dateTimeDocument;
        private DevExpress.XtraBars.Docking2010.Views.Widget.Document document1;
        private DevExpress.XtraBars.Docking2010.Views.Widget.Document document2;
    }
}

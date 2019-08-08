namespace CoFAS_MES.UI.QC
{
    partial class InspectFinalApprovalRegister_T01  
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
            this.layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
            this._gdMAIN = new DevExpress.XtraGrid.GridControl();
            this._gdMAIN_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this._luTPART_CODE = new CoFAS_MES.CORE.BaseControls.ucSearchEdit();
            this._luTUSE_YN = new CoFAS_MES.CORE.BaseControls.ucLookUpEdit();
            this._luTCOMPLETE_YN = new CoFAS_MES.CORE.BaseControls.ucLookUpEdit();
            this._luTINSPECT_DATE = new CoFAS_MES.CORE.BaseControls.ucFromToDateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this._lciTINSPECT_DATE = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciTCOMPLETE_YN = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciTPART_CODE = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciTUSE_YN = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this._pnHeader)).BeginInit();
            this._pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pnContent)).BeginInit();
            this._pnContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pnLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pnRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).BeginInit();
            this.layoutControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTINSPECT_DATE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTCOMPLETE_YN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTPART_CODE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTUSE_YN)).BeginInit();
            this.SuspendLayout();
            // 
            // _pnHeader
            // 
            this._pnHeader.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnHeader.Appearance.Options.UseBackColor = true;
            this._pnHeader.Controls.Add(this.layoutControl1);
            this._pnHeader.Size = new System.Drawing.Size(1400, 95);
            // 
            // _pnContent
            // 
            this._pnContent.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnContent.Appearance.Options.UseBackColor = true;
            this._pnContent.Controls.Add(this.layoutControl3);
            this._pnContent.Location = new System.Drawing.Point(5, 95);
            this._pnContent.Size = new System.Drawing.Size(1390, 625);
            // 
            // _pnLeft
            // 
            this._pnLeft.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnLeft.Appearance.Options.UseBackColor = true;
            this._pnLeft.Location = new System.Drawing.Point(0, 95);
            this._pnLeft.Size = new System.Drawing.Size(0, 625);
            // 
            // _pnRight
            // 
            this._pnRight.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnRight.Appearance.Options.UseBackColor = true;
            this._pnRight.Location = new System.Drawing.Point(1400, 95);
            this._pnRight.Size = new System.Drawing.Size(0, 625);
            // 
            // layoutControl3
            // 
            this.layoutControl3.Controls.Add(this._gdMAIN);
            this.layoutControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl3.Location = new System.Drawing.Point(0, 0);
            this.layoutControl3.Name = "layoutControl3";
            this.layoutControl3.Root = this.layoutControlGroup5;
            this.layoutControl3.Size = new System.Drawing.Size(1390, 625);
            this.layoutControl3.TabIndex = 1;
            this.layoutControl3.Text = "layoutControl3";
            // 
            // _gdMAIN
            // 
            this._gdMAIN.Location = new System.Drawing.Point(24, 24);
            this._gdMAIN.MainView = this._gdMAIN_VIEW;
            this._gdMAIN.Name = "_gdMAIN";
            this._gdMAIN.Size = new System.Drawing.Size(1342, 577);
            this._gdMAIN.TabIndex = 4;
            this._gdMAIN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gdMAIN_VIEW});
            // 
            // _gdMAIN_VIEW
            // 
            this._gdMAIN_VIEW.GridControl = this._gdMAIN;
            this._gdMAIN_VIEW.Name = "_gdMAIN_VIEW";
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup5.GroupBordersVisible = false;
            this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup6});
            this.layoutControlGroup5.Name = "layoutControlGroup5";
            this.layoutControlGroup5.Size = new System.Drawing.Size(1390, 625);
            this.layoutControlGroup5.TextVisible = false;
            // 
            // layoutControlGroup6
            // 
            this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup6.Name = "layoutControlGroup6";
            this.layoutControlGroup6.Size = new System.Drawing.Size(1370, 605);
            this.layoutControlGroup6.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this._gdMAIN;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1346, 581);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._luTPART_CODE);
            this.layoutControl1.Controls.Add(this._luTUSE_YN);
            this.layoutControl1.Controls.Add(this._luTCOMPLETE_YN);
            this.layoutControl1.Controls.Add(this._luTINSPECT_DATE);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(2044, 122, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1400, 95);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _luTPART_CODE
            // 
            this._luTPART_CODE.BackColor = System.Drawing.Color.Transparent;
            this._luTPART_CODE.CodeReadOnly = false;
            this._luTPART_CODE.CodeText = "";
            this._luTPART_CODE.CodeTextName = "_pCodeTextEdit";
            this._luTPART_CODE.Location = new System.Drawing.Point(145, 50);
            this._luTPART_CODE.Name = "_luTPART_CODE";
            this._luTPART_CODE.NameEnabled = true;
            this._luTPART_CODE.NameReadOnly = false;
            this._luTPART_CODE.NameText = "";
            this._luTPART_CODE.NameTextName = "_pNameButtonEdit";
            this._luTPART_CODE.Size = new System.Drawing.Size(271, 21);
            this._luTPART_CODE.TabIndex = 7;
            this._luTPART_CODE._OnOpenClick += new CoFAS_MES.CORE.BaseControls.ucSearchEdit.OnOpenClickEventHandler(this._luTPART_CODE__OnOpenClick);
            // 
            // _luTUSE_YN
            // 
            this._luTUSE_YN.ItemIndex = -1;
            this._luTUSE_YN.Location = new System.Drawing.Point(535, 50);
            this._luTUSE_YN.Margin = new System.Windows.Forms.Padding(0);
            this._luTUSE_YN.Name = "_luTUSE_YN";
            this._luTUSE_YN.ReadOnly = false;
            this._luTUSE_YN.Size = new System.Drawing.Size(100, 21);
            this._luTUSE_YN.TabIndex = 6;
            // 
            // _luTCOMPLETE_YN
            // 
            this._luTCOMPLETE_YN.ItemIndex = -1;
            this._luTCOMPLETE_YN.Location = new System.Drawing.Point(535, 24);
            this._luTCOMPLETE_YN.Margin = new System.Windows.Forms.Padding(0);
            this._luTCOMPLETE_YN.Name = "_luTCOMPLETE_YN";
            this._luTCOMPLETE_YN.ReadOnly = false;
            this._luTCOMPLETE_YN.Size = new System.Drawing.Size(100, 22);
            this._luTCOMPLETE_YN.TabIndex = 5;
            // 
            // _luTINSPECT_DATE
            // 
            this._luTINSPECT_DATE.FromDateTime = new System.DateTime(2019, 2, 1, 0, 0, 0, 0);
            this._luTINSPECT_DATE.Location = new System.Drawing.Point(145, 24);
            this._luTINSPECT_DATE.Margin = new System.Windows.Forms.Padding(0);
            this._luTINSPECT_DATE.Name = "_luTINSPECT_DATE";
            this._luTINSPECT_DATE.Size = new System.Drawing.Size(271, 22);
            this._luTINSPECT_DATE.TabIndex = 4;
            this._luTINSPECT_DATE.ToDateTime = new System.DateTime(2019, 2, 19, 23, 59, 59, 0);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(16, 16, 10, 10);
            this.layoutControlGroup1.Size = new System.Drawing.Size(1400, 95);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this._lciTINSPECT_DATE,
            this._lciTCOMPLETE_YN,
            this._lciTPART_CODE,
            this._lciTUSE_YN});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup3.Size = new System.Drawing.Size(1368, 75);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(609, 0);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(0, 26);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(10, 26);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(735, 26);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(609, 26);
            this.emptySpaceItem2.MaxSize = new System.Drawing.Size(0, 25);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(10, 25);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(735, 25);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // _lciTINSPECT_DATE
            // 
            this._lciTINSPECT_DATE.Control = this._luTINSPECT_DATE;
            this._lciTINSPECT_DATE.Location = new System.Drawing.Point(0, 0);
            this._lciTINSPECT_DATE.MaxSize = new System.Drawing.Size(0, 26);
            this._lciTINSPECT_DATE.MinSize = new System.Drawing.Size(219, 26);
            this._lciTINSPECT_DATE.Name = "_lciTINSPECT_DATE";
            this._lciTINSPECT_DATE.Size = new System.Drawing.Size(390, 26);
            this._lciTINSPECT_DATE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciTINSPECT_DATE.TextSize = new System.Drawing.Size(111, 14);
            // 
            // _lciTCOMPLETE_YN
            // 
            this._lciTCOMPLETE_YN.Control = this._luTCOMPLETE_YN;
            this._lciTCOMPLETE_YN.Location = new System.Drawing.Point(390, 0);
            this._lciTCOMPLETE_YN.Name = "_lciTCOMPLETE_YN";
            this._lciTCOMPLETE_YN.Size = new System.Drawing.Size(219, 26);
            this._lciTCOMPLETE_YN.TextSize = new System.Drawing.Size(111, 14);
            // 
            // _lciTPART_CODE
            // 
            this._lciTPART_CODE.Control = this._luTPART_CODE;
            this._lciTPART_CODE.Location = new System.Drawing.Point(0, 26);
            this._lciTPART_CODE.Name = "_lciTPART_CODE";
            this._lciTPART_CODE.Size = new System.Drawing.Size(390, 25);
            this._lciTPART_CODE.TextSize = new System.Drawing.Size(111, 14);
            // 
            // _lciTUSE_YN
            // 
            this._lciTUSE_YN.Control = this._luTUSE_YN;
            this._lciTUSE_YN.Location = new System.Drawing.Point(390, 26);
            this._lciTUSE_YN.Name = "_lciTUSE_YN";
            this._lciTUSE_YN.Size = new System.Drawing.Size(219, 25);
            this._lciTUSE_YN.TextSize = new System.Drawing.Size(111, 14);
            // 
            // InspectFinalApprovalRegister_T01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 720);
            this.Name = "InspectFinalApprovalRegister_T01";
            this.Text = "RawMaterialInspectionRegister";
            this.WindowName = "RawMaterialInspectionRegister";
            ((System.ComponentModel.ISupportInitialize)(this._pnHeader)).EndInit();
            this._pnHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pnContent)).EndInit();
            this._pnContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pnLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pnRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).EndInit();
            this.layoutControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTINSPECT_DATE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTCOMPLETE_YN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTPART_CODE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTUSE_YN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl3;
        private DevExpress.XtraGrid.GridControl _gdMAIN;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdMAIN_VIEW;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private CORE.BaseControls.ucFromToDateEdit _luTINSPECT_DATE;
        private DevExpress.XtraLayout.LayoutControlItem _lciTINSPECT_DATE;
        private CORE.BaseControls.ucSearchEdit _luTPART_CODE;
        private CORE.BaseControls.ucLookUpEdit _luTUSE_YN;
        private CORE.BaseControls.ucLookUpEdit _luTCOMPLETE_YN;
        private DevExpress.XtraLayout.LayoutControlItem _lciTCOMPLETE_YN;
        private DevExpress.XtraLayout.LayoutControlItem _lciTPART_CODE;
        private DevExpress.XtraLayout.LayoutControlItem _lciTUSE_YN;
    }
}
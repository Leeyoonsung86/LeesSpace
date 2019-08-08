namespace CoFAS_MES.UI.QC
{
    partial class InspectFinalApprovalRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InspectFinalApprovalRegister));
            this.layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
            this._gdMAIN = new DevExpress.XtraGrid.GridControl();
            this._gdMAIN_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this._luT_PART_TYPE = new CoFAS_MES.CORE.BaseControls.ucLookUpEdit();
            this._luT_PART = new CoFAS_MES.CORE.BaseControls.ucSearchEdit();
            this._luT_APPROVAL_DATE = new CoFAS_MES.CORE.BaseControls.ucFromToDateEdit();
            this._ucbtINSPECT_REQUEST = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._luT_INSPECT_APPROVAL = new CoFAS_MES.CORE.BaseControls.ucLookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this._lciT_APPROVAL_DATE = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this._lciT_PART_TYPE = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciT_PART = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciT_INSPECT_APPROVAL = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this._sdMAIN = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this._ckDelayChk = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this._pnHeader)).BeginInit();
            this._pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pnContent)).BeginInit();
            this._pnContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pnLeft)).BeginInit();
            this._pnLeft.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this._lciT_APPROVAL_DATE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciT_PART_TYPE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciT_PART)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciT_INSPECT_APPROVAL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ckDelayChk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
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
            this._pnContent.Controls.Add(this._sdMAIN);
            this._pnContent.Location = new System.Drawing.Point(205, 95);
            this._pnContent.Size = new System.Drawing.Size(990, 625);
            // 
            // _pnLeft
            // 
            this._pnLeft.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnLeft.Appearance.Options.UseBackColor = true;
            this._pnLeft.Controls.Add(this.layoutControl3);
            this._pnLeft.Location = new System.Drawing.Point(0, 95);
            this._pnLeft.Size = new System.Drawing.Size(200, 625);
            // 
            // _pnRight
            // 
            this._pnRight.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnRight.Appearance.Options.UseBackColor = true;
            this._pnRight.Location = new System.Drawing.Point(1200, 95);
            this._pnRight.Size = new System.Drawing.Size(200, 625);
            // 
            // layoutControl3
            // 
            this.layoutControl3.Controls.Add(this._gdMAIN);
            this.layoutControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl3.Location = new System.Drawing.Point(0, 0);
            this.layoutControl3.Name = "layoutControl3";
            this.layoutControl3.Root = this.layoutControlGroup5;
            this.layoutControl3.Size = new System.Drawing.Size(200, 625);
            this.layoutControl3.TabIndex = 1;
            this.layoutControl3.Text = "layoutControl3";
            // 
            // _gdMAIN
            // 
            this._gdMAIN.Location = new System.Drawing.Point(24, 24);
            this._gdMAIN.MainView = this._gdMAIN_VIEW;
            this._gdMAIN.Name = "_gdMAIN";
            this._gdMAIN.Size = new System.Drawing.Size(152, 577);
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
            this.layoutControlGroup5.Size = new System.Drawing.Size(200, 625);
            this.layoutControlGroup5.TextVisible = false;
            // 
            // layoutControlGroup6
            // 
            this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup6.Name = "layoutControlGroup6";
            this.layoutControlGroup6.Size = new System.Drawing.Size(180, 605);
            this.layoutControlGroup6.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this._gdMAIN;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(156, 581);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._ckDelayChk);
            this.layoutControl1.Controls.Add(this._luT_PART_TYPE);
            this.layoutControl1.Controls.Add(this._luT_PART);
            this.layoutControl1.Controls.Add(this._luT_APPROVAL_DATE);
            this.layoutControl1.Controls.Add(this._ucbtINSPECT_REQUEST);
            this.layoutControl1.Controls.Add(this._luT_INSPECT_APPROVAL);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1400, 95);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _luT_PART_TYPE
            // 
            this._luT_PART_TYPE.ItemIndex = -1;
            this._luT_PART_TYPE.Location = new System.Drawing.Point(181, 48);
            this._luT_PART_TYPE.Margin = new System.Windows.Forms.Padding(0);
            this._luT_PART_TYPE.Name = "_luT_PART_TYPE";
            this._luT_PART_TYPE.ReadOnly = false;
            this._luT_PART_TYPE.Size = new System.Drawing.Size(252, 22);
            this._luT_PART_TYPE.TabIndex = 10;
            // 
            // _luT_PART
            // 
            this._luT_PART.BackColor = System.Drawing.Color.White;
            this._luT_PART.CodeReadOnly = false;
            this._luT_PART.CodeText = "";
            this._luT_PART.CodeTextName = "_pCodeTextEdit";
            this._luT_PART.Location = new System.Drawing.Point(590, 24);
            this._luT_PART.Name = "_luT_PART";
            this._luT_PART.NameEnabled = true;
            this._luT_PART.NameReadOnly = false;
            this._luT_PART.NameText = "";
            this._luT_PART.NameTextName = "_pNameButtonEdit";
            this._luT_PART.Size = new System.Drawing.Size(224, 20);
            this._luT_PART.TabIndex = 4;
            this._luT_PART._OnOpenClick += new CoFAS_MES.CORE.BaseControls.ucSearchEdit.OnOpenClickEventHandler(this._luT_PART__OnOpenClick);
            // 
            // _luT_APPROVAL_DATE
            // 
            this._luT_APPROVAL_DATE.FromDateTime = new System.DateTime(2018, 4, 1, 0, 0, 0, 0);
            this._luT_APPROVAL_DATE.Location = new System.Drawing.Point(181, 24);
            this._luT_APPROVAL_DATE.Margin = new System.Windows.Forms.Padding(0);
            this._luT_APPROVAL_DATE.Name = "_luT_APPROVAL_DATE";
            this._luT_APPROVAL_DATE.Size = new System.Drawing.Size(254, 20);
            this._luT_APPROVAL_DATE.TabIndex = 4;
            this._luT_APPROVAL_DATE.ToDateTime = new System.DateTime(2018, 4, 25, 23, 59, 59, 0);
            // 
            // _ucbtINSPECT_REQUEST
            // 
            this._ucbtINSPECT_REQUEST.ButtonText = "simpleButton";
            this._ucbtINSPECT_REQUEST.Image = ((System.Drawing.Image)(resources.GetObject("_ucbtINSPECT_REQUEST.Image")));
            this._ucbtINSPECT_REQUEST.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtINSPECT_REQUEST.Location = new System.Drawing.Point(818, 24);
            this._ucbtINSPECT_REQUEST.Name = "_ucbtINSPECT_REQUEST";
            this._ucbtINSPECT_REQUEST.Size = new System.Drawing.Size(100, 22);
            this._ucbtINSPECT_REQUEST.TabIndex = 14;
            this._ucbtINSPECT_REQUEST.Visible = false;
            this._ucbtINSPECT_REQUEST.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtINSPECT_REQUEST_Click);
            // 
            // _luT_INSPECT_APPROVAL
            // 
            this._luT_INSPECT_APPROVAL.ItemIndex = -1;
            this._luT_INSPECT_APPROVAL.Location = new System.Drawing.Point(588, 48);
            this._luT_INSPECT_APPROVAL.Margin = new System.Windows.Forms.Padding(0);
            this._luT_INSPECT_APPROVAL.Name = "_luT_INSPECT_APPROVAL";
            this._luT_INSPECT_APPROVAL.ReadOnly = false;
            this._luT_INSPECT_APPROVAL.Size = new System.Drawing.Size(226, 22);
            this._luT_INSPECT_APPROVAL.TabIndex = 10;
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
            this._lciT_APPROVAL_DATE,
            this.emptySpaceItem1,
            this._lciT_PART_TYPE,
            this._lciT_PART,
            this._lciT_INSPECT_APPROVAL,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup3.Size = new System.Drawing.Size(1368, 75);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // _lciT_APPROVAL_DATE
            // 
            this._lciT_APPROVAL_DATE.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciT_APPROVAL_DATE.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciT_APPROVAL_DATE.Control = this._luT_APPROVAL_DATE;
            this._lciT_APPROVAL_DATE.Location = new System.Drawing.Point(0, 0);
            this._lciT_APPROVAL_DATE.MaxSize = new System.Drawing.Size(409, 24);
            this._lciT_APPROVAL_DATE.MinSize = new System.Drawing.Size(409, 24);
            this._lciT_APPROVAL_DATE.Name = "_lciT_APPROVAL_DATE";
            this._lciT_APPROVAL_DATE.Size = new System.Drawing.Size(409, 24);
            this._lciT_APPROVAL_DATE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciT_APPROVAL_DATE.TextSize = new System.Drawing.Size(147, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(892, 0);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(104, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(452, 51);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // _lciT_PART_TYPE
            // 
            this._lciT_PART_TYPE.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciT_PART_TYPE.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciT_PART_TYPE.Control = this._luT_PART_TYPE;
            this._lciT_PART_TYPE.Location = new System.Drawing.Point(0, 24);
            this._lciT_PART_TYPE.MaxSize = new System.Drawing.Size(0, 26);
            this._lciT_PART_TYPE.MinSize = new System.Drawing.Size(241, 26);
            this._lciT_PART_TYPE.Name = "_lciT_PART_TYPE";
            this._lciT_PART_TYPE.Size = new System.Drawing.Size(407, 27);
            this._lciT_PART_TYPE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciT_PART_TYPE.TextSize = new System.Drawing.Size(147, 14);
            // 
            // _lciT_PART
            // 
            this._lciT_PART.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciT_PART.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciT_PART.Control = this._luT_PART;
            this._lciT_PART.Location = new System.Drawing.Point(409, 0);
            this._lciT_PART.MaxSize = new System.Drawing.Size(379, 24);
            this._lciT_PART.MinSize = new System.Drawing.Size(379, 24);
            this._lciT_PART.Name = "_lciT_PART";
            this._lciT_PART.Size = new System.Drawing.Size(379, 24);
            this._lciT_PART.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciT_PART.TextSize = new System.Drawing.Size(147, 14);
            // 
            // _lciT_INSPECT_APPROVAL
            // 
            this._lciT_INSPECT_APPROVAL.Control = this._luT_INSPECT_APPROVAL;
            this._lciT_INSPECT_APPROVAL.CustomizationFormText = "_lciT_INSPECT_APPROVAL";
            this._lciT_INSPECT_APPROVAL.Location = new System.Drawing.Point(407, 24);
            this._lciT_INSPECT_APPROVAL.MaxSize = new System.Drawing.Size(0, 26);
            this._lciT_INSPECT_APPROVAL.MinSize = new System.Drawing.Size(241, 26);
            this._lciT_INSPECT_APPROVAL.Name = "_lciT_INSPECT_APPROVAL";
            this._lciT_INSPECT_APPROVAL.Size = new System.Drawing.Size(381, 27);
            this._lciT_INSPECT_APPROVAL.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciT_INSPECT_APPROVAL.TextSize = new System.Drawing.Size(147, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this._ucbtINSPECT_REQUEST;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(788, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(104, 26);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(104, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(104, 26);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            this.layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // _sdMAIN
            // 
            this._sdMAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this._sdMAIN.Location = new System.Drawing.Point(0, 0);
            this._sdMAIN.Name = "_sdMAIN";
            this._sdMAIN.Options.Import.Csv.Encoding = ((System.Text.Encoding)(resources.GetObject("_sdMAIN.Options.Import.Csv.Encoding")));
            this._sdMAIN.Options.Import.Txt.Encoding = ((System.Text.Encoding)(resources.GetObject("_sdMAIN.Options.Import.Txt.Encoding")));
            this._sdMAIN.Size = new System.Drawing.Size(990, 625);
            this._sdMAIN.TabIndex = 0;
            this._sdMAIN.Text = "spreadsheetControl1";
            // 
            // _ckDelayChk
            // 
            this._ckDelayChk.Location = new System.Drawing.Point(818, 50);
            this._ckDelayChk.Name = "_ckDelayChk";
            this._ckDelayChk.Properties.Caption = "checkEdit1";
            this._ckDelayChk.Size = new System.Drawing.Size(100, 19);
            this._ckDelayChk.StyleController = this.layoutControl1;
            this._ckDelayChk.TabIndex = 25;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this._ckDelayChk;
            this.layoutControlItem3.Location = new System.Drawing.Point(788, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(104, 25);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // InspectFinalApprovalRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 720);
            this.Name = "InspectFinalApprovalRegister";
            this.Text = "RawMaterialInspectionRegister";
            this.WindowName = "RawMaterialInspectionRegister";
            ((System.ComponentModel.ISupportInitialize)(this._pnHeader)).EndInit();
            this._pnHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pnContent)).EndInit();
            this._pnContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pnLeft)).EndInit();
            this._pnLeft.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this._lciT_APPROVAL_DATE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciT_PART_TYPE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciT_PART)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciT_INSPECT_APPROVAL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ckDelayChk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
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
        private CORE.BaseControls.ucSearchEdit _luT_PART;
        private CORE.BaseControls.ucFromToDateEdit _luT_APPROVAL_DATE;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem _lciT_APPROVAL_DATE;
        private DevExpress.XtraLayout.LayoutControlItem _lciT_PART;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private CORE.BaseControls.ucLookUpEdit _luT_PART_TYPE;
        private DevExpress.XtraLayout.LayoutControlItem _lciT_PART_TYPE;
        private CORE.BaseControls.ucSimpleButton _ucbtINSPECT_REQUEST;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraSpreadsheet.SpreadsheetControl _sdMAIN;
        private CORE.BaseControls.ucLookUpEdit _luT_INSPECT_APPROVAL;
        private DevExpress.XtraLayout.LayoutControlItem _lciT_INSPECT_APPROVAL;
        private DevExpress.XtraEditors.CheckEdit _ckDelayChk;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}
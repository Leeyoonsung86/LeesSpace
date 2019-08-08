namespace CoFAS_MES.UI.PO.UserControls
{
    partial class ucOrderNumberInfoListPopup
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this._luTORDER_DATE = new CoFAS_MES.CORE.BaseControls.ucFromToDateEdit();
            this._luTORDER_NUMBER = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._ucbtCANCLE = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._ucbtSELECT = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._ucbtCLEAR = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._gdMAIN = new DevExpress.XtraGrid.GridControl();
            this._gdMAIN_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciTORDER_NUMBER = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciTORDER_DATE = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this._luTORDER_NAME = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._lciTORDER_NAME = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTORDER_NUMBER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTORDER_DATE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTORDER_NAME)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._luTORDER_NAME);
            this.layoutControl1.Controls.Add(this._luTORDER_DATE);
            this.layoutControl1.Controls.Add(this._luTORDER_NUMBER);
            this.layoutControl1.Controls.Add(this._ucbtCANCLE);
            this.layoutControl1.Controls.Add(this._ucbtSELECT);
            this.layoutControl1.Controls.Add(this._ucbtCLEAR);
            this.layoutControl1.Controls.Add(this._gdMAIN);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(873, 526);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _luTORDER_DATE
            // 
            this._luTORDER_DATE.FromDateTime = new System.DateTime(2018, 12, 1, 0, 0, 0, 0);
            this._luTORDER_DATE.Location = new System.Drawing.Point(132, 12);
            this._luTORDER_DATE.Margin = new System.Windows.Forms.Padding(0);
            this._luTORDER_DATE.Name = "_luTORDER_DATE";
            this._luTORDER_DATE.Size = new System.Drawing.Size(302, 20);
            this._luTORDER_DATE.TabIndex = 12;
            this._luTORDER_DATE.ToDateTime = new System.DateTime(2018, 12, 13, 23, 59, 59, 0);
            // 
            // _luTORDER_NUMBER
            // 
            this._luTORDER_NUMBER.CancelButton = null;
            this._luTORDER_NUMBER.CommandButton = null;
            this._luTORDER_NUMBER.EditMask = "";
            this._luTORDER_NUMBER.Location = new System.Drawing.Point(132, 36);
            this._luTORDER_NUMBER.Margin = new System.Windows.Forms.Padding(0);
            this._luTORDER_NUMBER.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luTORDER_NUMBER.Name = "_luTORDER_NUMBER";
            this._luTORDER_NUMBER.PasswordChar = '\0';
            this._luTORDER_NUMBER.ReadOnly = false;
            this._luTORDER_NUMBER.Size = new System.Drawing.Size(100, 20);
            this._luTORDER_NUMBER.TabIndex = 11;
            this._luTORDER_NUMBER.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luTORDER_NUMBER.UseMaskAsDisplayFormat = false;
            // 
            // _ucbtCANCLE
            // 
            this._ucbtCANCLE.ButtonText = "닫기";
            this._ucbtCANCLE.Image = global::CoFAS_MES.UI.PO.Properties.Resources.close_16x16;
            this._ucbtCANCLE.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtCANCLE.Location = new System.Drawing.Point(759, 36);
            this._ucbtCANCLE.Name = "_ucbtCANCLE";
            this._ucbtCANCLE.Size = new System.Drawing.Size(102, 20);
            this._ucbtCANCLE.TabIndex = 10;
            this._ucbtCANCLE.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._btCancle_Click);
            // 
            // _ucbtSELECT
            // 
            this._ucbtSELECT.ButtonText = "조회";
            this._ucbtSELECT.Image = global::CoFAS_MES.UI.PO.Properties.Resources.zoom_16x16;
            this._ucbtSELECT.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtSELECT.Location = new System.Drawing.Point(654, 36);
            this._ucbtSELECT.Name = "_ucbtSELECT";
            this._ucbtSELECT.Size = new System.Drawing.Size(101, 20);
            this._ucbtSELECT.TabIndex = 9;
            this._ucbtSELECT.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._btSELECT_Click);
            // 
            // _ucbtCLEAR
            // 
            this._ucbtCLEAR.ButtonText = "초기화";
            this._ucbtCLEAR.Image = global::CoFAS_MES.UI.PO.Properties.Resources.refresh_16x16;
            this._ucbtCLEAR.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtCLEAR.Location = new System.Drawing.Point(546, 36);
            this._ucbtCLEAR.Name = "_ucbtCLEAR";
            this._ucbtCLEAR.Size = new System.Drawing.Size(104, 20);
            this._ucbtCLEAR.TabIndex = 8;
            this._ucbtCLEAR.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._btCLEAR_Click);
            // 
            // _gdMAIN
            // 
            this._gdMAIN.Location = new System.Drawing.Point(12, 60);
            this._gdMAIN.MainView = this._gdMAIN_VIEW;
            this._gdMAIN.Name = "_gdMAIN";
            this._gdMAIN.Size = new System.Drawing.Size(849, 454);
            this._gdMAIN.TabIndex = 4;
            this._gdMAIN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gdMAIN_VIEW});
            // 
            // _gdMAIN_VIEW
            // 
            this._gdMAIN_VIEW.GridControl = this._gdMAIN;
            this._gdMAIN_VIEW.Name = "_gdMAIN_VIEW";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem6,
            this.layoutControlItem5,
            this._lciTORDER_DATE,
            this.emptySpaceItem1,
            this._lciTORDER_NAME,
            this._lciTORDER_NUMBER,
            this.layoutControlItem7});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(873, 526);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this._gdMAIN;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(853, 458);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this._ucbtCANCLE;
            this.layoutControlItem7.Location = new System.Drawing.Point(747, 24);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(106, 24);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this._ucbtSELECT;
            this.layoutControlItem6.Location = new System.Drawing.Point(642, 24);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(105, 24);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this._ucbtCLEAR;
            this.layoutControlItem5.Location = new System.Drawing.Point(534, 24);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(108, 24);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // _lciTORDER_NUMBER
            // 
            this._lciTORDER_NUMBER.Control = this._luTORDER_NUMBER;
            this._lciTORDER_NUMBER.Location = new System.Drawing.Point(0, 24);
            this._lciTORDER_NUMBER.MaxSize = new System.Drawing.Size(0, 24);
            this._lciTORDER_NUMBER.MinSize = new System.Drawing.Size(224, 24);
            this._lciTORDER_NUMBER.Name = "_lciTORDER_NUMBER";
            this._lciTORDER_NUMBER.Size = new System.Drawing.Size(224, 24);
            this._lciTORDER_NUMBER.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciTORDER_NUMBER.TextSize = new System.Drawing.Size(117, 14);
            // 
            // _lciTORDER_DATE
            // 
            this._lciTORDER_DATE.Control = this._luTORDER_DATE;
            this._lciTORDER_DATE.Location = new System.Drawing.Point(0, 0);
            this._lciTORDER_DATE.MaxSize = new System.Drawing.Size(426, 24);
            this._lciTORDER_DATE.MinSize = new System.Drawing.Size(426, 24);
            this._lciTORDER_DATE.Name = "_lciTORDER_DATE";
            this._lciTORDER_DATE.Size = new System.Drawing.Size(426, 24);
            this._lciTORDER_DATE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciTORDER_DATE.TextSize = new System.Drawing.Size(117, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(426, 0);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(0, 24);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(10, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(427, 24);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // _luTORDER_NAME
            // 
            this._luTORDER_NAME.CancelButton = null;
            this._luTORDER_NAME.CommandButton = null;
            this._luTORDER_NAME.EditMask = "";
            this._luTORDER_NAME.Location = new System.Drawing.Point(356, 36);
            this._luTORDER_NAME.Margin = new System.Windows.Forms.Padding(0);
            this._luTORDER_NAME.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luTORDER_NAME.Name = "_luTORDER_NAME";
            this._luTORDER_NAME.PasswordChar = '\0';
            this._luTORDER_NAME.ReadOnly = false;
            this._luTORDER_NAME.Size = new System.Drawing.Size(186, 20);
            this._luTORDER_NAME.TabIndex = 13;
            this._luTORDER_NAME.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luTORDER_NAME.UseMaskAsDisplayFormat = false;
            // 
            // _lciTORDER_NAME
            // 
            this._lciTORDER_NAME.Control = this._luTORDER_NAME;
            this._lciTORDER_NAME.Location = new System.Drawing.Point(224, 24);
            this._lciTORDER_NAME.MaxSize = new System.Drawing.Size(0, 24);
            this._lciTORDER_NAME.MinSize = new System.Drawing.Size(224, 24);
            this._lciTORDER_NAME.Name = "_lciTORDER_NAME";
            this._lciTORDER_NAME.Size = new System.Drawing.Size(310, 24);
            this._lciTORDER_NAME.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciTORDER_NAME.TextSize = new System.Drawing.Size(117, 14);
            // 
            // ucOrderNumberInfoListPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ucOrderNumberInfoListPopup";
            this.Size = new System.Drawing.Size(873, 526);
            this.Load += new System.EventHandler(this.ucOrderNumberInfoListPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTORDER_NUMBER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTORDER_DATE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTORDER_NAME)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl _gdMAIN;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdMAIN_VIEW;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private CORE.BaseControls.ucSimpleButton _ucbtCANCLE;
        private CORE.BaseControls.ucSimpleButton _ucbtSELECT;
        private CORE.BaseControls.ucSimpleButton _ucbtCLEAR;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private CORE.BaseControls.ucTextEdit _luTORDER_NUMBER;
        private DevExpress.XtraLayout.LayoutControlItem _lciTORDER_NUMBER;
        private CORE.BaseControls.ucFromToDateEdit _luTORDER_DATE;
        private DevExpress.XtraLayout.LayoutControlItem _lciTORDER_DATE;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private CORE.BaseControls.ucTextEdit _luTORDER_NAME;
        private DevExpress.XtraLayout.LayoutControlItem _lciTORDER_NAME;
    }
}
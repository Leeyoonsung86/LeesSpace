namespace CoFAS_MES.UI.IM.UserForm
{
    partial class frmCategorySensorSettings
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
            this._ucbtCLOSE = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._luRESOURCE_NAME = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._ucbtSELECT = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._ucbtSAVE = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._luRESOURCE_CODE = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._gdMAIN = new DevExpress.XtraGrid.GridControl();
            this._gdMAIN_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciRESOURCE_CODE = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciRESOURCE_NAME = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this._pnSINGLE_MAIN)).BeginInit();
            this._pnSINGLE_MAIN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciRESOURCE_CODE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciRESOURCE_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // _pnSINGLE_MAIN
            // 
            this._pnSINGLE_MAIN.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnSINGLE_MAIN.Appearance.BorderColor = System.Drawing.Color.Silver;
            this._pnSINGLE_MAIN.Appearance.Options.UseBackColor = true;
            this._pnSINGLE_MAIN.Appearance.Options.UseBorderColor = true;
            this._pnSINGLE_MAIN.Controls.Add(this.layoutControl1);
            this._pnSINGLE_MAIN.Size = new System.Drawing.Size(600, 360);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._ucbtCLOSE);
            this.layoutControl1.Controls.Add(this._luRESOURCE_NAME);
            this.layoutControl1.Controls.Add(this._ucbtSELECT);
            this.layoutControl1.Controls.Add(this._ucbtSAVE);
            this.layoutControl1.Controls.Add(this._luRESOURCE_CODE);
            this.layoutControl1.Controls.Add(this._gdMAIN);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(600, 360);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _ucbtCLOSE
            // 
            this._ucbtCLOSE.ButtonText = "Close";
            this._ucbtCLOSE.FontSize = 0;
            this._ucbtCLOSE.Image = global::CoFAS_MES.UI.IM.Properties.Resources.close_16x16;
            this._ucbtCLOSE.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtCLOSE.Location = new System.Drawing.Point(474, 50);
            this._ucbtCLOSE.Name = "_ucbtCLOSE";
            this._ucbtCLOSE.Size = new System.Drawing.Size(100, 20);
            this._ucbtCLOSE.TabIndex = 9;
            this._ucbtCLOSE.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtCLOSE_Click);
            // 
            // _luRESOURCE_NAME
            // 
            this._luRESOURCE_NAME.CancelButton = null;
            this._luRESOURCE_NAME.CommandButton = null;
            this._luRESOURCE_NAME.EditMask = "";
            this._luRESOURCE_NAME.Location = new System.Drawing.Point(420, 26);
            this._luRESOURCE_NAME.Margin = new System.Windows.Forms.Padding(0);
            this._luRESOURCE_NAME.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luRESOURCE_NAME.Name = "_luRESOURCE_NAME";
            this._luRESOURCE_NAME.NumText = "";
            this._luRESOURCE_NAME.PasswordChar = '\0';
            this._luRESOURCE_NAME.ReadOnly = true;
            this._luRESOURCE_NAME.Size = new System.Drawing.Size(154, 20);
            this._luRESOURCE_NAME.TabIndex = 8;
            this._luRESOURCE_NAME.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luRESOURCE_NAME.UseMaskAsDisplayFormat = false;
            // 
            // _ucbtSELECT
            // 
            this._ucbtSELECT.ButtonText = "Select";
            this._ucbtSELECT.FontSize = 0;
            this._ucbtSELECT.Image = global::CoFAS_MES.UI.IM.Properties.Resources.zoom_16x16;
            this._ucbtSELECT.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtSELECT.Location = new System.Drawing.Point(266, 50);
            this._ucbtSELECT.Name = "_ucbtSELECT";
            this._ucbtSELECT.Size = new System.Drawing.Size(100, 20);
            this._ucbtSELECT.TabIndex = 7;
            this._ucbtSELECT.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtSELECT_Click);
            // 
            // _ucbtSAVE
            // 
            this._ucbtSAVE.ButtonText = "Save";
            this._ucbtSAVE.FontSize = 0;
            this._ucbtSAVE.Image = global::CoFAS_MES.UI.IM.Properties.Resources.save_16x16;
            this._ucbtSAVE.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtSAVE.Location = new System.Drawing.Point(370, 50);
            this._ucbtSAVE.Name = "_ucbtSAVE";
            this._ucbtSAVE.Size = new System.Drawing.Size(100, 20);
            this._ucbtSAVE.TabIndex = 6;
            this._ucbtSAVE.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtSAVE_Click);
            // 
            // _luRESOURCE_CODE
            // 
            this._luRESOURCE_CODE.CancelButton = null;
            this._luRESOURCE_CODE.CommandButton = null;
            this._luRESOURCE_CODE.EditMask = "";
            this._luRESOURCE_CODE.Location = new System.Drawing.Point(144, 26);
            this._luRESOURCE_CODE.Margin = new System.Windows.Forms.Padding(0);
            this._luRESOURCE_CODE.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luRESOURCE_CODE.Name = "_luRESOURCE_CODE";
            this._luRESOURCE_CODE.NumText = "";
            this._luRESOURCE_CODE.PasswordChar = '\0';
            this._luRESOURCE_CODE.ReadOnly = true;
            this._luRESOURCE_CODE.Size = new System.Drawing.Size(154, 20);
            this._luRESOURCE_CODE.TabIndex = 5;
            this._luRESOURCE_CODE.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luRESOURCE_CODE.UseMaskAsDisplayFormat = false;
            // 
            // _gdMAIN
            // 
            this._gdMAIN.Location = new System.Drawing.Point(14, 86);
            this._gdMAIN.MainView = this._gdMAIN_VIEW;
            this._gdMAIN.Name = "_gdMAIN";
            this._gdMAIN.Size = new System.Drawing.Size(572, 260);
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
            this.layoutControlGroup1.AppearanceGroup.BackColor = System.Drawing.Color.Transparent;
            this.layoutControlGroup1.AppearanceGroup.Options.UseBackColor = true;
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(600, 360);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlItem1});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(600, 360);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem2,
            this._lciRESOURCE_CODE,
            this.emptySpaceItem1,
            this.layoutControlItem4,
            this._lciRESOURCE_NAME});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(576, 72);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this._ucbtSAVE;
            this.layoutControlItem3.Location = new System.Drawing.Point(344, 24);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(104, 24);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this._ucbtCLOSE;
            this.layoutControlItem2.Location = new System.Drawing.Point(448, 24);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(104, 24);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // _lciRESOURCE_CODE
            // 
            this._lciRESOURCE_CODE.Control = this._luRESOURCE_CODE;
            this._lciRESOURCE_CODE.Location = new System.Drawing.Point(0, 0);
            this._lciRESOURCE_CODE.MaxSize = new System.Drawing.Size(0, 24);
            this._lciRESOURCE_CODE.MinSize = new System.Drawing.Size(221, 24);
            this._lciRESOURCE_CODE.Name = "_lciRESOURCE_CODE";
            this._lciRESOURCE_CODE.Size = new System.Drawing.Size(276, 24);
            this._lciRESOURCE_CODE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciRESOURCE_CODE.TextSize = new System.Drawing.Size(115, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 24);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(240, 24);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(240, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(240, 24);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this._ucbtSELECT;
            this.layoutControlItem4.Location = new System.Drawing.Point(240, 24);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(104, 24);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // _lciRESOURCE_NAME
            // 
            this._lciRESOURCE_NAME.Control = this._luRESOURCE_NAME;
            this._lciRESOURCE_NAME.Location = new System.Drawing.Point(276, 0);
            this._lciRESOURCE_NAME.Name = "_lciRESOURCE_NAME";
            this._lciRESOURCE_NAME.Size = new System.Drawing.Size(276, 24);
            this._lciRESOURCE_NAME.TextSize = new System.Drawing.Size(115, 14);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this._gdMAIN;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(576, 264);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmCategorySensorSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Child_Page_Setting_Visible = true;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Name = "frmCategorySensorSettings";
            this.Text = "frmCategorySensorSettings";
            this.Load += new System.EventHandler(this.frmCategorySensorSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this._pnSINGLE_MAIN)).EndInit();
            this._pnSINGLE_MAIN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciRESOURCE_CODE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciRESOURCE_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl _gdMAIN;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdMAIN_VIEW;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private CORE.BaseControls.ucSimpleButton _ucbtSELECT;
        private CORE.BaseControls.ucSimpleButton _ucbtSAVE;
        private CORE.BaseControls.ucTextEdit _luRESOURCE_CODE;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem _lciRESOURCE_CODE;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private CORE.BaseControls.ucTextEdit _luRESOURCE_NAME;
        private DevExpress.XtraLayout.LayoutControlItem _lciRESOURCE_NAME;
        private CORE.BaseControls.ucSimpleButton _ucbtCLOSE;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
    }
}
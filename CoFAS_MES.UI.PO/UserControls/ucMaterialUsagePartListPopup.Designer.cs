namespace CoFAS_MES.UI.PO.UserControls
{
    partial class ucMaterialUsagePartListPopup
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
            this._luPART_LOW = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luPART_MIDDLE = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luPART_HIGH = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._ucbtCANCLE = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._ucbtSELECT = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._ucbtCLEAR = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._luPART_REVISION_NO = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luPART_NAME = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luVEND_PART_CODE = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._gdMAIN = new DevExpress.XtraGrid.GridControl();
            this._gdMAIN_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciVEND_PART_CODE = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciPART_NAME = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciPART_REVISION_NO = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciPART_HIGH = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciPART_MIDDLE = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciPART_LOW = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this._ucbtSAVE = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciVEND_PART_CODE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPART_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPART_REVISION_NO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPART_HIGH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPART_MIDDLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPART_LOW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._ucbtSAVE);
            this.layoutControl1.Controls.Add(this._luPART_LOW);
            this.layoutControl1.Controls.Add(this._luPART_MIDDLE);
            this.layoutControl1.Controls.Add(this._luPART_HIGH);
            this.layoutControl1.Controls.Add(this._ucbtCANCLE);
            this.layoutControl1.Controls.Add(this._ucbtSELECT);
            this.layoutControl1.Controls.Add(this._ucbtCLEAR);
            this.layoutControl1.Controls.Add(this._luPART_REVISION_NO);
            this.layoutControl1.Controls.Add(this._luPART_NAME);
            this.layoutControl1.Controls.Add(this._luVEND_PART_CODE);
            this.layoutControl1.Controls.Add(this._gdMAIN);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(873, 526);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _luPART_LOW
            // 
            this._luPART_LOW.CancelButton = null;
            this._luPART_LOW.CommandButton = null;
            this._luPART_LOW.EditMask = "";
            this._luPART_LOW.Location = new System.Drawing.Point(761, 36);
            this._luPART_LOW.Margin = new System.Windows.Forms.Padding(0);
            this._luPART_LOW.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luPART_LOW.Name = "_luPART_LOW";
            this._luPART_LOW.NumText = "";
            this._luPART_LOW.PasswordChar = '\0';
            this._luPART_LOW.ReadOnly = false;
            this._luPART_LOW.Size = new System.Drawing.Size(100, 20);
            this._luPART_LOW.TabIndex = 13;
            this._luPART_LOW.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luPART_LOW.UseMaskAsDisplayFormat = false;
            // 
            // _luPART_MIDDLE
            // 
            this._luPART_MIDDLE.CancelButton = null;
            this._luPART_MIDDLE.CommandButton = null;
            this._luPART_MIDDLE.EditMask = "";
            this._luPART_MIDDLE.Location = new System.Drawing.Point(463, 36);
            this._luPART_MIDDLE.Margin = new System.Windows.Forms.Padding(0);
            this._luPART_MIDDLE.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luPART_MIDDLE.Name = "_luPART_MIDDLE";
            this._luPART_MIDDLE.NumText = "";
            this._luPART_MIDDLE.PasswordChar = '\0';
            this._luPART_MIDDLE.ReadOnly = false;
            this._luPART_MIDDLE.Size = new System.Drawing.Size(159, 20);
            this._luPART_MIDDLE.TabIndex = 12;
            this._luPART_MIDDLE.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luPART_MIDDLE.UseMaskAsDisplayFormat = false;
            // 
            // _luPART_HIGH
            // 
            this._luPART_HIGH.CancelButton = null;
            this._luPART_HIGH.CommandButton = null;
            this._luPART_HIGH.EditMask = "";
            this._luPART_HIGH.Location = new System.Drawing.Point(147, 36);
            this._luPART_HIGH.Margin = new System.Windows.Forms.Padding(0);
            this._luPART_HIGH.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luPART_HIGH.Name = "_luPART_HIGH";
            this._luPART_HIGH.NumText = "";
            this._luPART_HIGH.PasswordChar = '\0';
            this._luPART_HIGH.ReadOnly = false;
            this._luPART_HIGH.Size = new System.Drawing.Size(177, 20);
            this._luPART_HIGH.TabIndex = 11;
            this._luPART_HIGH.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luPART_HIGH.UseMaskAsDisplayFormat = false;
            // 
            // _ucbtCANCLE
            // 
            this._ucbtCANCLE.ButtonText = "닫기";
            this._ucbtCANCLE.FontSize = 0;
            this._ucbtCANCLE.Image = global::CoFAS_MES.UI.PO.Properties.Resources.close_16x16;
            this._ucbtCANCLE.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtCANCLE.Location = new System.Drawing.Point(761, 70);
            this._ucbtCANCLE.Name = "_ucbtCANCLE";
            this._ucbtCANCLE.Size = new System.Drawing.Size(100, 20);
            this._ucbtCANCLE.TabIndex = 10;
            this._ucbtCANCLE.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._btCancle_Click);
            // 
            // _ucbtSELECT
            // 
            this._ucbtSELECT.ButtonText = "조회";
            this._ucbtSELECT.FontSize = 0;
            this._ucbtSELECT.Image = global::CoFAS_MES.UI.PO.Properties.Resources.zoom_16x16;
            this._ucbtSELECT.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtSELECT.Location = new System.Drawing.Point(654, 70);
            this._ucbtSELECT.Name = "_ucbtSELECT";
            this._ucbtSELECT.Size = new System.Drawing.Size(103, 20);
            this._ucbtSELECT.TabIndex = 9;
            this._ucbtSELECT.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._btSELECT_Click);
            // 
            // _ucbtCLEAR
            // 
            this._ucbtCLEAR.ButtonText = "초기화";
            this._ucbtCLEAR.FontSize = 0;
            this._ucbtCLEAR.Image = global::CoFAS_MES.UI.PO.Properties.Resources.refresh_16x16;
            this._ucbtCLEAR.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtCLEAR.Location = new System.Drawing.Point(546, 70);
            this._ucbtCLEAR.Name = "_ucbtCLEAR";
            this._ucbtCLEAR.Size = new System.Drawing.Size(104, 20);
            this._ucbtCLEAR.TabIndex = 8;
            this._ucbtCLEAR.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._btCLEAR_Click);
            // 
            // _luPART_REVISION_NO
            // 
            this._luPART_REVISION_NO.CancelButton = null;
            this._luPART_REVISION_NO.CommandButton = null;
            this._luPART_REVISION_NO.EditMask = "";
            this._luPART_REVISION_NO.Location = new System.Drawing.Point(761, 12);
            this._luPART_REVISION_NO.Margin = new System.Windows.Forms.Padding(0);
            this._luPART_REVISION_NO.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luPART_REVISION_NO.Name = "_luPART_REVISION_NO";
            this._luPART_REVISION_NO.NumText = "";
            this._luPART_REVISION_NO.PasswordChar = '\0';
            this._luPART_REVISION_NO.ReadOnly = false;
            this._luPART_REVISION_NO.Size = new System.Drawing.Size(100, 20);
            this._luPART_REVISION_NO.TabIndex = 7;
            this._luPART_REVISION_NO.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luPART_REVISION_NO.UseMaskAsDisplayFormat = false;
            // 
            // _luPART_NAME
            // 
            this._luPART_NAME.CancelButton = null;
            this._luPART_NAME.CommandButton = null;
            this._luPART_NAME.EditMask = "";
            this._luPART_NAME.Location = new System.Drawing.Point(463, 12);
            this._luPART_NAME.Margin = new System.Windows.Forms.Padding(0);
            this._luPART_NAME.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luPART_NAME.Name = "_luPART_NAME";
            this._luPART_NAME.NumText = "";
            this._luPART_NAME.PasswordChar = '\0';
            this._luPART_NAME.ReadOnly = false;
            this._luPART_NAME.Size = new System.Drawing.Size(159, 20);
            this._luPART_NAME.TabIndex = 6;
            this._luPART_NAME.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luPART_NAME.UseMaskAsDisplayFormat = false;
            // 
            // _luVEND_PART_CODE
            // 
            this._luVEND_PART_CODE.CancelButton = null;
            this._luVEND_PART_CODE.CommandButton = null;
            this._luVEND_PART_CODE.EditMask = "";
            this._luVEND_PART_CODE.Location = new System.Drawing.Point(147, 12);
            this._luVEND_PART_CODE.Margin = new System.Windows.Forms.Padding(0);
            this._luVEND_PART_CODE.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luVEND_PART_CODE.Name = "_luVEND_PART_CODE";
            this._luVEND_PART_CODE.NumText = "";
            this._luVEND_PART_CODE.PasswordChar = '\0';
            this._luVEND_PART_CODE.ReadOnly = false;
            this._luVEND_PART_CODE.Size = new System.Drawing.Size(177, 20);
            this._luVEND_PART_CODE.TabIndex = 5;
            this._luVEND_PART_CODE.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luVEND_PART_CODE.UseMaskAsDisplayFormat = false;
            // 
            // _gdMAIN
            // 
            this._gdMAIN.Location = new System.Drawing.Point(12, 94);
            this._gdMAIN.MainView = this._gdMAIN_VIEW;
            this._gdMAIN.Name = "_gdMAIN";
            this._gdMAIN.Size = new System.Drawing.Size(849, 385);
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
            this._lciVEND_PART_CODE,
            this._lciPART_NAME,
            this._lciPART_REVISION_NO,
            this.layoutControlItem7,
            this._lciPART_HIGH,
            this._lciPART_MIDDLE,
            this._lciPART_LOW,
            this.emptySpaceItem2,
            this.layoutControlItem6,
            this.layoutControlItem5,
            this.emptySpaceItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(873, 526);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this._gdMAIN;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 82);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(853, 389);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // _lciVEND_PART_CODE
            // 
            this._lciVEND_PART_CODE.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciVEND_PART_CODE.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciVEND_PART_CODE.Control = this._luVEND_PART_CODE;
            this._lciVEND_PART_CODE.Location = new System.Drawing.Point(0, 0);
            this._lciVEND_PART_CODE.Name = "_lciVEND_PART_CODE";
            this._lciVEND_PART_CODE.Size = new System.Drawing.Size(316, 24);
            this._lciVEND_PART_CODE.TextSize = new System.Drawing.Size(132, 14);
            // 
            // _lciPART_NAME
            // 
            this._lciPART_NAME.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciPART_NAME.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciPART_NAME.Control = this._luPART_NAME;
            this._lciPART_NAME.Location = new System.Drawing.Point(316, 0);
            this._lciPART_NAME.Name = "_lciPART_NAME";
            this._lciPART_NAME.Size = new System.Drawing.Size(298, 24);
            this._lciPART_NAME.TextSize = new System.Drawing.Size(132, 14);
            // 
            // _lciPART_REVISION_NO
            // 
            this._lciPART_REVISION_NO.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciPART_REVISION_NO.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciPART_REVISION_NO.Control = this._luPART_REVISION_NO;
            this._lciPART_REVISION_NO.Location = new System.Drawing.Point(614, 0);
            this._lciPART_REVISION_NO.Name = "_lciPART_REVISION_NO";
            this._lciPART_REVISION_NO.Size = new System.Drawing.Size(239, 24);
            this._lciPART_REVISION_NO.TextSize = new System.Drawing.Size(132, 14);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this._ucbtCANCLE;
            this.layoutControlItem7.Location = new System.Drawing.Point(749, 58);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(104, 24);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // _lciPART_HIGH
            // 
            this._lciPART_HIGH.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciPART_HIGH.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciPART_HIGH.Control = this._luPART_HIGH;
            this._lciPART_HIGH.Location = new System.Drawing.Point(0, 24);
            this._lciPART_HIGH.Name = "_lciPART_HIGH";
            this._lciPART_HIGH.Size = new System.Drawing.Size(316, 24);
            this._lciPART_HIGH.TextSize = new System.Drawing.Size(132, 14);
            // 
            // _lciPART_MIDDLE
            // 
            this._lciPART_MIDDLE.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciPART_MIDDLE.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciPART_MIDDLE.Control = this._luPART_MIDDLE;
            this._lciPART_MIDDLE.Location = new System.Drawing.Point(316, 24);
            this._lciPART_MIDDLE.Name = "_lciPART_MIDDLE";
            this._lciPART_MIDDLE.Size = new System.Drawing.Size(298, 24);
            this._lciPART_MIDDLE.TextSize = new System.Drawing.Size(132, 14);
            // 
            // _lciPART_LOW
            // 
            this._lciPART_LOW.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciPART_LOW.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciPART_LOW.Control = this._luPART_LOW;
            this._lciPART_LOW.Location = new System.Drawing.Point(614, 24);
            this._lciPART_LOW.Name = "_lciPART_LOW";
            this._lciPART_LOW.Size = new System.Drawing.Size(239, 24);
            this._lciPART_LOW.TextSize = new System.Drawing.Size(132, 14);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 58);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(534, 24);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this._ucbtSELECT;
            this.layoutControlItem6.Location = new System.Drawing.Point(642, 58);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(107, 24);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this._ucbtCLEAR;
            this.layoutControlItem5.Location = new System.Drawing.Point(534, 58);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(108, 24);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 48);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(853, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // _ucbtSAVE
            // 
            this._ucbtSAVE.ButtonText = "simpleButton";
            this._ucbtSAVE.FontSize = 0;
            this._ucbtSAVE.Image = global::CoFAS_MES.UI.PO.Properties.Resources.save_16x16;
            this._ucbtSAVE.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtSAVE.Location = new System.Drawing.Point(12, 483);
            this._ucbtSAVE.Name = "_ucbtSAVE";
            this._ucbtSAVE.Size = new System.Drawing.Size(849, 31);
            this._ucbtSAVE.TabIndex = 14;
            this._ucbtSAVE.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtSAVE_Click);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this._ucbtSAVE;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 471);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(853, 35);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // ucMaterialUsagePartListPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ucMaterialUsagePartListPopup";
            this.Size = new System.Drawing.Size(873, 526);
            this.Load += new System.EventHandler(this.ucMaterialUsagePartListPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciVEND_PART_CODE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPART_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPART_REVISION_NO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPART_HIGH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPART_MIDDLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPART_LOW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl _gdMAIN;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdMAIN_VIEW;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private CORE.BaseControls.ucTextEdit _luPART_LOW;
        private CORE.BaseControls.ucTextEdit _luPART_MIDDLE;
        private CORE.BaseControls.ucTextEdit _luPART_HIGH;
        private CORE.BaseControls.ucSimpleButton _ucbtCANCLE;
        private CORE.BaseControls.ucSimpleButton _ucbtSELECT;
        private CORE.BaseControls.ucSimpleButton _ucbtCLEAR;
        private CORE.BaseControls.ucTextEdit _luPART_REVISION_NO;
        private CORE.BaseControls.ucTextEdit _luPART_NAME;
        private CORE.BaseControls.ucTextEdit _luVEND_PART_CODE;
        private DevExpress.XtraLayout.LayoutControlItem _lciVEND_PART_CODE;
        private DevExpress.XtraLayout.LayoutControlItem _lciPART_NAME;
        private DevExpress.XtraLayout.LayoutControlItem _lciPART_REVISION_NO;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem _lciPART_HIGH;
        private DevExpress.XtraLayout.LayoutControlItem _lciPART_MIDDLE;
        private DevExpress.XtraLayout.LayoutControlItem _lciPART_LOW;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private CORE.BaseControls.ucSimpleButton _ucbtSAVE;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}
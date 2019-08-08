namespace CoFAS_MES.CORE.UserControls
{
    partial class ucTabletBasedSensorInfoPopup_T01
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this._ucbtCANCLE = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._ucbtSELECT = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._ucbtCLEAR = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._gdMAIN = new DevExpress.XtraGrid.GridControl();
            this._gdMAIN_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._luCD_NM = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luCD = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._ucFROMDATE = new CoFAS_MES.CORE.BaseControls.ucFromToDateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this._lciCD_NM = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciCD = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciTPLAN_ORDER_DATE = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCD_NM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTPLAN_ORDER_DATE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._ucbtCANCLE);
            this.layoutControl1.Controls.Add(this._ucbtSELECT);
            this.layoutControl1.Controls.Add(this._ucbtCLEAR);
            this.layoutControl1.Controls.Add(this._gdMAIN);
            this.layoutControl1.Controls.Add(this._luCD_NM);
            this.layoutControl1.Controls.Add(this._luCD);
            this.layoutControl1.Controls.Add(this._ucFROMDATE);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(543, 728);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _ucbtCANCLE
            // 
            this._ucbtCANCLE.ButtonText = "CLOSE";
            this._ucbtCANCLE.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this._ucbtCANCLE.Image = global::CoFAS_MES.CORE.Properties.Resources.close_16x162;
            this._ucbtCANCLE.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtCANCLE.Location = new System.Drawing.Point(12, 672);
            this._ucbtCANCLE.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this._ucbtCANCLE.Name = "_ucbtCANCLE";
            this._ucbtCANCLE.Size = new System.Drawing.Size(519, 44);
            this._ucbtCANCLE.TabIndex = 22;
            this._ucbtCANCLE.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtCancle_Click);
            // 
            // _ucbtSELECT
            // 
            this._ucbtSELECT.ButtonText = "SEARCH";
            this._ucbtSELECT.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this._ucbtSELECT.Image = global::CoFAS_MES.CORE.Properties.Resources.zoom_16x16;
            this._ucbtSELECT.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtSELECT.Location = new System.Drawing.Point(12, 91);
            this._ucbtSELECT.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this._ucbtSELECT.Name = "_ucbtSELECT";
            this._ucbtSELECT.Size = new System.Drawing.Size(519, 44);
            this._ucbtSELECT.TabIndex = 21;
            this._ucbtSELECT.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtSELECT_Click);
            // 
            // _ucbtCLEAR
            // 
            this._ucbtCLEAR.ButtonText = "REFRESH";
            this._ucbtCLEAR.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this._ucbtCLEAR.Image = global::CoFAS_MES.CORE.Properties.Resources.refresh_16x16;
            this._ucbtCLEAR.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtCLEAR.Location = new System.Drawing.Point(12, 139);
            this._ucbtCLEAR.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this._ucbtCLEAR.Name = "_ucbtCLEAR";
            this._ucbtCLEAR.Size = new System.Drawing.Size(519, 44);
            this._ucbtCLEAR.TabIndex = 20;
            this._ucbtCLEAR.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtCLEAR_Click);
            // 
            // _gdMAIN
            // 
            this._gdMAIN.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gdMAIN.Location = new System.Drawing.Point(24, 199);
            this._gdMAIN.MainView = this._gdMAIN_VIEW;
            this._gdMAIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gdMAIN.Name = "_gdMAIN";
            this._gdMAIN.Size = new System.Drawing.Size(495, 457);
            this._gdMAIN.TabIndex = 8;
            this._gdMAIN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gdMAIN_VIEW});
            // 
            // _gdMAIN_VIEW
            // 
            this._gdMAIN_VIEW.GridControl = this._gdMAIN;
            this._gdMAIN_VIEW.Name = "_gdMAIN_VIEW";
            // 
            // _luCD_NM
            // 
            this._luCD_NM.CancelButton = null;
            this._luCD_NM.CommandButton = null;
            this._luCD_NM.EditMask = "";
            this._luCD_NM.Location = new System.Drawing.Point(318, 55);
            this._luCD_NM.Margin = new System.Windows.Forms.Padding(0);
            this._luCD_NM.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luCD_NM.Name = "_luCD_NM";
            this._luCD_NM.PasswordChar = '\0';
            this._luCD_NM.ReadOnly = false;
            this._luCD_NM.Size = new System.Drawing.Size(201, 20);
            this._luCD_NM.TabIndex = 5;
            this._luCD_NM.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luCD_NM.UseMaskAsDisplayFormat = false;
            // 
            // _luCD
            // 
            this._luCD.CancelButton = null;
            this._luCD.CommandButton = null;
            this._luCD.EditMask = "";
            this._luCD.Location = new System.Drawing.Point(60, 55);
            this._luCD.Margin = new System.Windows.Forms.Padding(0);
            this._luCD.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luCD.Name = "_luCD";
            this._luCD.PasswordChar = '\0';
            this._luCD.ReadOnly = false;
            this._luCD.Size = new System.Drawing.Size(218, 20);
            this._luCD.TabIndex = 4;
            this._luCD.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luCD.UseMaskAsDisplayFormat = false;
            // 
            // _ucFROMDATE
            // 
            this._ucFROMDATE.FromDateTime = new System.DateTime(2018, 7, 1, 0, 0, 0, 0);
            this._ucFROMDATE.Location = new System.Drawing.Point(60, 24);
            this._ucFROMDATE.Margin = new System.Windows.Forms.Padding(0);
            this._ucFROMDATE.Name = "_ucFROMDATE";
            this._ucFROMDATE.Size = new System.Drawing.Size(459, 27);
            this._ucFROMDATE.TabIndex = 19;
            this._ucFROMDATE.ToDateTime = new System.DateTime(2018, 7, 2, 23, 59, 59, 0);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3,
            this.layoutControlGroup2,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(543, 728);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 175);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup3.Size = new System.Drawing.Size(523, 485);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this._gdMAIN;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(499, 461);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this._lciCD_NM,
            this._lciCD,
            this._lciTPLAN_ORDER_DATE});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup2.Size = new System.Drawing.Size(523, 79);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // _lciCD_NM
            // 
            this._lciCD_NM.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciCD_NM.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciCD_NM.Control = this._luCD_NM;
            this._lciCD_NM.Location = new System.Drawing.Point(258, 31);
            this._lciCD_NM.MaxSize = new System.Drawing.Size(0, 24);
            this._lciCD_NM.MinSize = new System.Drawing.Size(128, 24);
            this._lciCD_NM.Name = "_lciCD_NM";
            this._lciCD_NM.Size = new System.Drawing.Size(241, 24);
            this._lciCD_NM.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciCD_NM.Text = "NAME";
            this._lciCD_NM.TextSize = new System.Drawing.Size(32, 14);
            // 
            // _lciCD
            // 
            this._lciCD.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciCD.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciCD.Control = this._luCD;
            this._lciCD.Location = new System.Drawing.Point(0, 31);
            this._lciCD.MaxSize = new System.Drawing.Size(0, 24);
            this._lciCD.MinSize = new System.Drawing.Size(128, 24);
            this._lciCD.Name = "_lciCD";
            this._lciCD.Size = new System.Drawing.Size(258, 24);
            this._lciCD.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciCD.Text = "CODE";
            this._lciCD.TextSize = new System.Drawing.Size(32, 14);
            // 
            // _lciTPLAN_ORDER_DATE
            // 
            this._lciTPLAN_ORDER_DATE.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciTPLAN_ORDER_DATE.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciTPLAN_ORDER_DATE.Control = this._ucFROMDATE;
            this._lciTPLAN_ORDER_DATE.CustomizationFormText = "_lciTPLAN_ORDER_DATE";
            this._lciTPLAN_ORDER_DATE.Location = new System.Drawing.Point(0, 0);
            this._lciTPLAN_ORDER_DATE.MinSize = new System.Drawing.Size(245, 24);
            this._lciTPLAN_ORDER_DATE.Name = "_lciTPLAN_ORDER_DATE";
            this._lciTPLAN_ORDER_DATE.Size = new System.Drawing.Size(499, 31);
            this._lciTPLAN_ORDER_DATE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciTPLAN_ORDER_DATE.Text = "DATE";
            this._lciTPLAN_ORDER_DATE.TextSize = new System.Drawing.Size(32, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this._ucbtCLEAR;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 127);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(0, 48);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(104, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(523, 48);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this._ucbtSELECT;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 79);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(0, 48);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(104, 48);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(523, 48);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this._ucbtCANCLE;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 660);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(0, 48);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(104, 48);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(523, 48);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // ucTabletBasedSensorInfoPopup_T01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucTabletBasedSensorInfoPopup_T01";
            this.Size = new System.Drawing.Size(543, 728);
            this.Load += new System.EventHandler(this.ucTabletBasedSensorInfoPopup_T01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCD_NM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTPLAN_ORDER_DATE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl _gdMAIN;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdMAIN_VIEW;
        private BaseControls.ucTextEdit _luCD_NM;
        private BaseControls.ucTextEdit _luCD;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem _lciCD;
        private DevExpress.XtraLayout.LayoutControlItem _lciCD_NM;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private BaseControls.ucFromToDateEdit _ucFROMDATE;
        private DevExpress.XtraLayout.LayoutControlItem _lciTPLAN_ORDER_DATE;
        private BaseControls.ucSimpleButton _ucbtCANCLE;
        private BaseControls.ucSimpleButton _ucbtSELECT;
        private BaseControls.ucSimpleButton _ucbtCLEAR;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    }
}

namespace CoFAS_MES.CORE.UserControls
{
    partial class ucTabletBasedSensorInfoPopup_T02
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
            this._ucbtSAVE = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._ucbtREFRESH = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._ucbtSELECT = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._ucbtCANCLE = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._gdMAIN = new DevExpress.XtraGrid.GridControl();
            this._gdMAIN_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._luCD_NM = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luCD = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
            this._lciCD_NM = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciCD = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCD_NM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._ucbtSAVE);
            this.layoutControl1.Controls.Add(this._ucbtREFRESH);
            this.layoutControl1.Controls.Add(this._ucbtSELECT);
            this.layoutControl1.Controls.Add(this._ucbtCANCLE);
            this.layoutControl1.Controls.Add(this._gdMAIN);
            this.layoutControl1.Controls.Add(this._luCD_NM);
            this.layoutControl1.Controls.Add(this._luCD);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(543, 728);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _ucbtSAVE
            // 
            this._ucbtSAVE.ButtonText = "EXPORT";
            this._ucbtSAVE.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this._ucbtSAVE.FontSize = 0;
            this._ucbtSAVE.Image = global::CoFAS_MES.CORE.Properties.Resources.customizegrid_16x16;
            this._ucbtSAVE.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtSAVE.Location = new System.Drawing.Point(343, 60);
            this._ucbtSAVE.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this._ucbtSAVE.Name = "_ucbtSAVE";
            this._ucbtSAVE.Size = new System.Drawing.Size(164, 47);
            this._ucbtSAVE.TabIndex = 25;
            this._ucbtSAVE.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtSAVE_Click);
            // 
            // _ucbtREFRESH
            // 
            this._ucbtREFRESH.ButtonText = "REFRESH";
            this._ucbtREFRESH.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this._ucbtREFRESH.FontSize = 0;
            this._ucbtREFRESH.Image = global::CoFAS_MES.CORE.Properties.Resources.refresh_16x16;
            this._ucbtREFRESH.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtREFRESH.Location = new System.Drawing.Point(183, 60);
            this._ucbtREFRESH.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this._ucbtREFRESH.Name = "_ucbtREFRESH";
            this._ucbtREFRESH.Size = new System.Drawing.Size(156, 47);
            this._ucbtREFRESH.TabIndex = 24;
            this._ucbtREFRESH.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtCLEAR_Click);
            // 
            // _ucbtSELECT
            // 
            this._ucbtSELECT.ButtonText = "SEARCH";
            this._ucbtSELECT.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this._ucbtSELECT.FontSize = 0;
            this._ucbtSELECT.Image = global::CoFAS_MES.CORE.Properties.Resources.zoom_16x16;
            this._ucbtSELECT.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtSELECT.Location = new System.Drawing.Point(36, 60);
            this._ucbtSELECT.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this._ucbtSELECT.Name = "_ucbtSELECT";
            this._ucbtSELECT.Size = new System.Drawing.Size(143, 47);
            this._ucbtSELECT.TabIndex = 23;
            this._ucbtSELECT.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtSELECT_Click);
            // 
            // _ucbtCANCLE
            // 
            this._ucbtCANCLE.ButtonText = "CLOSE";
            this._ucbtCANCLE.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this._ucbtCANCLE.FontSize = 0;
            this._ucbtCANCLE.Image = global::CoFAS_MES.CORE.Properties.Resources.close_16x162;
            this._ucbtCANCLE.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtCANCLE.Location = new System.Drawing.Point(24, 658);
            this._ucbtCANCLE.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this._ucbtCANCLE.Name = "_ucbtCANCLE";
            this._ucbtCANCLE.Size = new System.Drawing.Size(495, 46);
            this._ucbtCANCLE.TabIndex = 22;
            this._ucbtCANCLE.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtCancle_Click);
            // 
            // _gdMAIN
            // 
            this._gdMAIN.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gdMAIN.Location = new System.Drawing.Point(24, 123);
            this._gdMAIN.MainView = this._gdMAIN_VIEW;
            this._gdMAIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gdMAIN.Name = "_gdMAIN";
            this._gdMAIN.Size = new System.Drawing.Size(495, 507);
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
            this._luCD_NM.Location = new System.Drawing.Point(291, 36);
            this._luCD_NM.Margin = new System.Windows.Forms.Padding(0);
            this._luCD_NM.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luCD_NM.Name = "_luCD_NM";
            this._luCD_NM.NumText = "";
            this._luCD_NM.PasswordChar = '\0';
            this._luCD_NM.ReadOnly = false;
            this._luCD_NM.Size = new System.Drawing.Size(216, 20);
            this._luCD_NM.TabIndex = 5;
            this._luCD_NM.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luCD_NM.UseMaskAsDisplayFormat = false;
            // 
            // _luCD
            // 
            this._luCD.CancelButton = null;
            this._luCD.CommandButton = null;
            this._luCD.EditMask = "";
            this._luCD.Location = new System.Drawing.Point(72, 36);
            this._luCD.Margin = new System.Windows.Forms.Padding(0);
            this._luCD.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luCD.Name = "_luCD";
            this._luCD.NumText = "";
            this._luCD.PasswordChar = '\0';
            this._luCD.ReadOnly = false;
            this._luCD.Size = new System.Drawing.Size(179, 20);
            this._luCD.TabIndex = 4;
            this._luCD.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luCD.UseMaskAsDisplayFormat = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup5,
            this.layoutControlGroup3});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(543, 728);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.CustomizationFormText = "layoutControlGroup3";
            this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlGroup6});
            this.layoutControlGroup5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup5.Name = "layoutControlGroup5";
            this.layoutControlGroup5.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup5.Size = new System.Drawing.Size(523, 634);
            this.layoutControlGroup5.Text = "layoutControlGroup3";
            this.layoutControlGroup5.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this._gdMAIN;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 99);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(499, 511);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "layoutControlItem5";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup6
            // 
            this.layoutControlGroup6.CustomizationFormText = "layoutControlGroup2";
            this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this._lciCD_NM,
            this._lciCD,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem8});
            this.layoutControlGroup6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup6.Name = "layoutControlGroup6";
            this.layoutControlGroup6.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup6.Size = new System.Drawing.Size(499, 99);
            this.layoutControlGroup6.Text = "layoutControlGroup2";
            this.layoutControlGroup6.TextVisible = false;
            // 
            // _lciCD_NM
            // 
            this._lciCD_NM.Control = this._luCD_NM;
            this._lciCD_NM.CustomizationFormText = "NAME";
            this._lciCD_NM.Location = new System.Drawing.Point(219, 0);
            this._lciCD_NM.MaxSize = new System.Drawing.Size(256, 24);
            this._lciCD_NM.MinSize = new System.Drawing.Size(256, 24);
            this._lciCD_NM.Name = "_lciCD_NM";
            this._lciCD_NM.Size = new System.Drawing.Size(256, 24);
            this._lciCD_NM.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciCD_NM.Text = "NAME";
            this._lciCD_NM.TextSize = new System.Drawing.Size(32, 14);
            // 
            // _lciCD
            // 
            this._lciCD.Control = this._luCD;
            this._lciCD.CustomizationFormText = "CODE";
            this._lciCD.Location = new System.Drawing.Point(0, 0);
            this._lciCD.MaxSize = new System.Drawing.Size(219, 24);
            this._lciCD.MinSize = new System.Drawing.Size(219, 24);
            this._lciCD.Name = "_lciCD";
            this._lciCD.Size = new System.Drawing.Size(219, 24);
            this._lciCD.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciCD.Text = "CODE";
            this._lciCD.TextSize = new System.Drawing.Size(32, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this._ucbtSELECT;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(147, 51);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(147, 51);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(147, 51);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this._ucbtREFRESH;
            this.layoutControlItem3.Location = new System.Drawing.Point(147, 24);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(160, 51);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(160, 51);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(160, 51);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this._ucbtSAVE;
            this.layoutControlItem8.Location = new System.Drawing.Point(307, 24);
            this.layoutControlItem8.MaxSize = new System.Drawing.Size(168, 51);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(168, 51);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(168, 51);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 634);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup3.Size = new System.Drawing.Size(523, 74);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this._ucbtCANCLE;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(0, 50);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(104, 50);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(499, 50);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // ucTabletBasedSensorInfoPopup_T02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucTabletBasedSensorInfoPopup_T02";
            this.Size = new System.Drawing.Size(543, 728);
            this.Load += new System.EventHandler(this.ucTabletBasedSensorInfoPopup_T02_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCD_NM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl _gdMAIN;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdMAIN_VIEW;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private BaseControls.ucSimpleButton _ucbtSELECT;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private BaseControls.ucSimpleButton _ucbtSAVE;
        private BaseControls.ucSimpleButton _ucbtREFRESH;
        private BaseControls.ucTextEdit _luCD_NM;
        private BaseControls.ucTextEdit _luCD;
        private DevExpress.XtraLayout.LayoutControlItem _lciCD_NM;
        private DevExpress.XtraLayout.LayoutControlItem _lciCD;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private BaseControls.ucSimpleButton _ucbtCANCLE;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    }
}

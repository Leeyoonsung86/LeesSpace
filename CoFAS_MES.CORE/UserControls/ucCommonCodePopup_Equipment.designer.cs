namespace CoFAS_MES.CORE.UserControls
{
    partial class ucCommonCodePopup_Equipment
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
            this._ucbtCLEAR = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._ucbtCANCLE = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._ucbtSELECT = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._gdMAIN = new DevExpress.XtraGrid.GridControl();
            this._gdMAIN_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._luCD_NM = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luCD = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this._lciCD = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciCD_NM = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCD_NM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._ucbtCLEAR);
            this.layoutControl1.Controls.Add(this._ucbtCANCLE);
            this.layoutControl1.Controls.Add(this._ucbtSELECT);
            this.layoutControl1.Controls.Add(this._gdMAIN);
            this.layoutControl1.Controls.Add(this._luCD_NM);
            this.layoutControl1.Controls.Add(this._luCD);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(534, 532);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _ucbtCLEAR
            // 
            this._ucbtCLEAR.ButtonText = "초기화";
            this._ucbtCLEAR.Image = global::CoFAS_MES.CORE.Properties.Resources.refresh_16x16;
            this._ucbtCLEAR.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtCLEAR.Location = new System.Drawing.Point(306, 48);
            this._ucbtCLEAR.Name = "_ucbtCLEAR";
            this._ucbtCLEAR.Size = new System.Drawing.Size(100, 20);
            this._ucbtCLEAR.TabIndex = 12;
            this._ucbtCLEAR.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtCLEAR_Click);
            // 
            // _ucbtCANCLE
            // 
            this._ucbtCANCLE.ButtonText = "닫기";
            this._ucbtCANCLE.Image = global::CoFAS_MES.CORE.Properties.Resources.close_16x162;
            this._ucbtCANCLE.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtCANCLE.Location = new System.Drawing.Point(410, 48);
            this._ucbtCANCLE.Name = "_ucbtCANCLE";
            this._ucbtCANCLE.Size = new System.Drawing.Size(100, 20);
            this._ucbtCANCLE.TabIndex = 11;
            this._ucbtCANCLE.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtCancle_Click);
            // 
            // _ucbtSELECT
            // 
            this._ucbtSELECT.ButtonText = "조회";
            this._ucbtSELECT.Image = global::CoFAS_MES.CORE.Properties.Resources.zoom_16x16;
            this._ucbtSELECT.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtSELECT.Location = new System.Drawing.Point(202, 48);
            this._ucbtSELECT.Name = "_ucbtSELECT";
            this._ucbtSELECT.Size = new System.Drawing.Size(100, 20);
            this._ucbtSELECT.TabIndex = 9;
            this._ucbtSELECT.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtSELECT_Click);
            // 
            // _gdMAIN
            // 
            this._gdMAIN.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gdMAIN.Location = new System.Drawing.Point(24, 96);
            this._gdMAIN.MainView = this._gdMAIN_VIEW;
            this._gdMAIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gdMAIN.Name = "_gdMAIN";
            this._gdMAIN.Size = new System.Drawing.Size(486, 412);
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
            this._luCD_NM.Location = new System.Drawing.Point(293, 24);
            this._luCD_NM.Margin = new System.Windows.Forms.Padding(0);
            this._luCD_NM.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luCD_NM.Name = "_luCD_NM";
            this._luCD_NM.PasswordChar = '\0';
            this._luCD_NM.ReadOnly = false;
            this._luCD_NM.Size = new System.Drawing.Size(217, 20);
            this._luCD_NM.TabIndex = 5;
            this._luCD_NM.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luCD_NM.UseMaskAsDisplayFormat = false;
            // 
            // _luCD
            // 
            this._luCD.CancelButton = null;
            this._luCD.CommandButton = null;
            this._luCD.EditMask = "";
            this._luCD.Location = new System.Drawing.Point(48, 24);
            this._luCD.Margin = new System.Windows.Forms.Padding(0);
            this._luCD.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luCD.Name = "_luCD";
            this._luCD.PasswordChar = '\0';
            this._luCD.ReadOnly = false;
            this._luCD.Size = new System.Drawing.Size(217, 20);
            this._luCD.TabIndex = 4;
            this._luCD.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luCD.UseMaskAsDisplayFormat = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(534, 532);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this._lciCD,
            this._lciCD_NM,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup2.Size = new System.Drawing.Size(514, 72);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // _lciCD
            // 
            this._lciCD.Control = this._luCD;
            this._lciCD.Location = new System.Drawing.Point(0, 0);
            this._lciCD.MaxSize = new System.Drawing.Size(0, 24);
            this._lciCD.MinSize = new System.Drawing.Size(128, 24);
            this._lciCD.Name = "_lciCD";
            this._lciCD.Size = new System.Drawing.Size(245, 24);
            this._lciCD.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciCD.Text = "코드";
            this._lciCD.TextSize = new System.Drawing.Size(20, 14);
            // 
            // _lciCD_NM
            // 
            this._lciCD_NM.Control = this._luCD_NM;
            this._lciCD_NM.Location = new System.Drawing.Point(245, 0);
            this._lciCD_NM.MaxSize = new System.Drawing.Size(0, 24);
            this._lciCD_NM.MinSize = new System.Drawing.Size(128, 24);
            this._lciCD_NM.Name = "_lciCD_NM";
            this._lciCD_NM.Size = new System.Drawing.Size(245, 24);
            this._lciCD_NM.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciCD_NM.Text = "명칭";
            this._lciCD_NM.TextSize = new System.Drawing.Size(20, 14);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this._ucbtSELECT;
            this.layoutControlItem1.Location = new System.Drawing.Point(178, 24);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(104, 24);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this._ucbtCLEAR;
            this.layoutControlItem2.Location = new System.Drawing.Point(282, 24);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(104, 24);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this._ucbtCANCLE;
            this.layoutControlItem3.Location = new System.Drawing.Point(386, 24);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(104, 24);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 24);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(0, 24);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(10, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(98, 24);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(98, 24);
            this.emptySpaceItem2.MaxSize = new System.Drawing.Size(0, 24);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(10, 24);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(80, 24);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 72);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup3.Size = new System.Drawing.Size(514, 440);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this._gdMAIN;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(490, 416);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // ucCommonCodePopup_Equipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucCommonCodePopup_Equipment";
            this.Size = new System.Drawing.Size(534, 532);
            this.Load += new System.EventHandler(this.ucCommonCodePopup_Equipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCD_NM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
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
        private BaseControls.ucSimpleButton _ucbtSELECT;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private BaseControls.ucSimpleButton _ucbtCANCLE;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private BaseControls.ucSimpleButton _ucbtCLEAR;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}

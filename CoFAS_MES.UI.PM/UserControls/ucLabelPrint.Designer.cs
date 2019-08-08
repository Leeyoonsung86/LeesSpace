namespace CoFAS_MES.UI.PM.UserControls
{
    partial class ucLabelPrint
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucLabelPrint));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this._COM_STATUS = new DevExpress.XtraEditors.LabelControl();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this._lciPRINT_TYPE = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.radialMenu1 = new DevExpress.XtraBars.Ribbon.RadialMenu();
            this._ucbtCONNECTION = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._luCOM_TYPE = new CoFAS_MES.CORE.BaseControls.ucComboBox();
            this._luPRINT_SEQ = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._ucbtPRINT = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._ucbtCANCLE = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciPRINT_SEQ = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPRINT_TYPE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radialMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPRINT_SEQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._ucbtCONNECTION);
            this.layoutControl1.Controls.Add(this._COM_STATUS);
            this.layoutControl1.Controls.Add(this._luCOM_TYPE);
            this.layoutControl1.Controls.Add(this._luPRINT_SEQ);
            this.layoutControl1.Controls.Add(this.radioGroup1);
            this.layoutControl1.Controls.Add(this._ucbtPRINT);
            this.layoutControl1.Controls.Add(this._ucbtCANCLE);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(641, 149);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _COM_STATUS
            // 
            this._COM_STATUS.Appearance.Options.UseTextOptions = true;
            this._COM_STATUS.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this._COM_STATUS.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this._COM_STATUS.Location = new System.Drawing.Point(426, 24);
            this._COM_STATUS.Name = "_COM_STATUS";
            this._COM_STATUS.Size = new System.Drawing.Size(191, 20);
            this._COM_STATUS.StyleController = this.layoutControl1;
            this._COM_STATUS.TabIndex = 18;
            this._COM_STATUS.Text = "labelControl1";
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(68, 48);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Columns = 2;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "단일발행"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "자동 발행")});
            this.radioGroup1.Size = new System.Drawing.Size(549, 25);
            this.radioGroup1.StyleController = this.layoutControl1;
            this.radioGroup1.TabIndex = 13;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(641, 149);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem1,
            this._lciPRINT_TYPE,
            this._lciPRINT_SEQ,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup2.Size = new System.Drawing.Size(621, 129);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // _lciPRINT_TYPE
            // 
            this._lciPRINT_TYPE.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciPRINT_TYPE.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciPRINT_TYPE.Control = this.radioGroup1;
            this._lciPRINT_TYPE.Location = new System.Drawing.Point(0, 24);
            this._lciPRINT_TYPE.MaxSize = new System.Drawing.Size(597, 29);
            this._lciPRINT_TYPE.MinSize = new System.Drawing.Size(597, 29);
            this._lciPRINT_TYPE.Name = "_lciPRINT_TYPE";
            this._lciPRINT_TYPE.Size = new System.Drawing.Size(597, 29);
            this._lciPRINT_TYPE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciPRINT_TYPE.Text = "발행유형";
            this._lciPRINT_TYPE.TextSize = new System.Drawing.Size(40, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(298, 53);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(299, 24);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(299, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(299, 24);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this._COM_STATUS;
            this.layoutControlItem5.Location = new System.Drawing.Point(402, 0);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(74, 18);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(195, 24);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // radialMenu1
            // 
            this.radialMenu1.Name = "radialMenu1";
            // 
            // _ucbtCONNECTION
            // 
            this._ucbtCONNECTION.ButtonText = "연결상태";
            this._ucbtCONNECTION.FontSize = 0;
            this._ucbtCONNECTION.Image = ((System.Drawing.Image)(resources.GetObject("_ucbtCONNECTION.Image")));
            this._ucbtCONNECTION.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtCONNECTION.Location = new System.Drawing.Point(322, 24);
            this._ucbtCONNECTION.Name = "_ucbtCONNECTION";
            this._ucbtCONNECTION.Size = new System.Drawing.Size(100, 20);
            this._ucbtCONNECTION.TabIndex = 20;
            // 
            // _luCOM_TYPE
            // 
            this._luCOM_TYPE.Location = new System.Drawing.Point(68, 24);
            this._luCOM_TYPE.Margin = new System.Windows.Forms.Padding(0);
            this._luCOM_TYPE.Name = "_luCOM_TYPE";
            this._luCOM_TYPE.ReadOnly = false;
            this._luCOM_TYPE.SelectedIndex = -1;
            this._luCOM_TYPE.SelectedItem = null;
            this._luCOM_TYPE.Size = new System.Drawing.Size(250, 20);
            this._luCOM_TYPE.TabIndex = 15;
            // 
            // _luPRINT_SEQ
            // 
            this._luPRINT_SEQ.CancelButton = null;
            this._luPRINT_SEQ.CommandButton = null;
            this._luPRINT_SEQ.EditMask = "";
            this._luPRINT_SEQ.Location = new System.Drawing.Point(68, 77);
            this._luPRINT_SEQ.Margin = new System.Windows.Forms.Padding(0);
            this._luPRINT_SEQ.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luPRINT_SEQ.Name = "_luPRINT_SEQ";
            this._luPRINT_SEQ.NumText = "";
            this._luPRINT_SEQ.PasswordChar = '\0';
            this._luPRINT_SEQ.ReadOnly = false;
            this._luPRINT_SEQ.Size = new System.Drawing.Size(250, 20);
            this._luPRINT_SEQ.TabIndex = 14;
            this._luPRINT_SEQ.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luPRINT_SEQ.UseMaskAsDisplayFormat = false;
            // 
            // _ucbtPRINT
            // 
            this._ucbtPRINT.ButtonText = "발행";
            this._ucbtPRINT.FontSize = 0;
            this._ucbtPRINT.Image = global::CoFAS_MES.UI.PM.Properties.Resources.print_16x16;
            this._ucbtPRINT.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtPRINT.Location = new System.Drawing.Point(24, 101);
            this._ucbtPRINT.Name = "_ucbtPRINT";
            this._ucbtPRINT.Size = new System.Drawing.Size(294, 24);
            this._ucbtPRINT.TabIndex = 9;
            this._ucbtPRINT.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtRPINT_Click);
            // 
            // _ucbtCANCLE
            // 
            this._ucbtCANCLE.ButtonText = "닫기";
            this._ucbtCANCLE.FontSize = 0;
            this._ucbtCANCLE.Image = global::CoFAS_MES.UI.PM.Properties.Resources.close_16x162;
            this._ucbtCANCLE.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtCANCLE.Location = new System.Drawing.Point(322, 101);
            this._ucbtCANCLE.Name = "_ucbtCANCLE";
            this._ucbtCANCLE.Size = new System.Drawing.Size(295, 24);
            this._ucbtCANCLE.TabIndex = 11;
            this._ucbtCANCLE.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtCancle_Click);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this._ucbtCANCLE;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(298, 77);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(299, 28);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(299, 28);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(299, 28);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this._ucbtPRINT;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 77);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(298, 28);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(298, 28);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(298, 28);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // _lciPRINT_SEQ
            // 
            this._lciPRINT_SEQ.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciPRINT_SEQ.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciPRINT_SEQ.Control = this._luPRINT_SEQ;
            this._lciPRINT_SEQ.Location = new System.Drawing.Point(0, 53);
            this._lciPRINT_SEQ.MaxSize = new System.Drawing.Size(298, 24);
            this._lciPRINT_SEQ.MinSize = new System.Drawing.Size(298, 24);
            this._lciPRINT_SEQ.Name = "_lciPRINT_SEQ";
            this._lciPRINT_SEQ.Size = new System.Drawing.Size(298, 24);
            this._lciPRINT_SEQ.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciPRINT_SEQ.Text = "순번";
            this._lciPRINT_SEQ.TextSize = new System.Drawing.Size(40, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem2.Control = this._luCOM_TYPE;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(298, 24);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(298, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(298, 24);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "포트선택";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(40, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this._ucbtCONNECTION;
            this.layoutControlItem6.Location = new System.Drawing.Point(298, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(104, 24);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // ucLabelPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucLabelPrint";
            this.Size = new System.Drawing.Size(641, 149);
            this.Load += new System.EventHandler(this.ucPartCodeInfoPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPRINT_TYPE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radialMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPRINT_SEQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private CORE.BaseControls.ucSimpleButton _ucbtPRINT;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private CORE.BaseControls.ucSimpleButton _ucbtCANCLE;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraLayout.LayoutControlItem _lciPRINT_TYPE;
        private DevExpress.XtraBars.Ribbon.RadialMenu radialMenu1;
        private CORE.BaseControls.ucTextEdit _luPRINT_SEQ;
        private DevExpress.XtraLayout.LayoutControlItem _lciPRINT_SEQ;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private CORE.BaseControls.ucComboBox _luCOM_TYPE;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.LabelControl _COM_STATUS;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private CORE.BaseControls.ucSimpleButton _ucbtCONNECTION;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}
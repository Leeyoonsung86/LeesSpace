namespace CoFAS_MES.UI.IM.UserView
{
    partial class ucResourceSensor
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
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this._luUSE_YN = new CoFAS_MES.CORE.BaseControls.ucLookUpEdit();
            this._luREMARK = new CoFAS_MES.CORE.BaseControls.ucMemoEdit();
            this._luLIMIT_HIGH = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luLIMIT_LOW = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luM_LIMIT_HIGH = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luM_LIMIT_LOW = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luSENSOR_FLOAT_DIGIT = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luSENSOR_UNIT = new CoFAS_MES.CORE.BaseControls.ucLookUpEdit();
            this._lciSENSOR_UNIT = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciSENSOR_FLOAT_DIGIT = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciM_LIMIT_LOW = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciM_LIMIT_HIGH = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciLIMIT_LOW = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciLIMIT_HIGH = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciUSE_YN = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciREMARK = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciSENSOR_UNIT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciSENSOR_FLOAT_DIGIT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciM_LIMIT_LOW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciM_LIMIT_HIGH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciLIMIT_LOW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciLIMIT_HIGH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciUSE_YN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciREMARK)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._luUSE_YN);
            this.layoutControl1.Controls.Add(this._luREMARK);
            this.layoutControl1.Controls.Add(this._luLIMIT_HIGH);
            this.layoutControl1.Controls.Add(this._luLIMIT_LOW);
            this.layoutControl1.Controls.Add(this._luM_LIMIT_HIGH);
            this.layoutControl1.Controls.Add(this._luM_LIMIT_LOW);
            this.layoutControl1.Controls.Add(this._luSENSOR_FLOAT_DIGIT);
            this.layoutControl1.Controls.Add(this._luSENSOR_UNIT);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(859, 509);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3,
            this.layoutControlGroup4,
            this.layoutControlGroup5});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(859, 509);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this._lciSENSOR_UNIT,
            this._lciSENSOR_FLOAT_DIGIT});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(859, 48);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this._lciM_LIMIT_LOW,
            this._lciM_LIMIT_HIGH});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(859, 48);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this._lciLIMIT_LOW,
            this._lciLIMIT_HIGH});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 96);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(859, 48);
            this.layoutControlGroup4.TextVisible = false;
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this._lciUSE_YN,
            this.emptySpaceItem2,
            this._lciREMARK});
            this.layoutControlGroup5.Location = new System.Drawing.Point(0, 144);
            this.layoutControlGroup5.Name = "layoutControlGroup5";
            this.layoutControlGroup5.Size = new System.Drawing.Size(859, 365);
            this.layoutControlGroup5.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(417, 0);
            this.emptySpaceItem2.MaxSize = new System.Drawing.Size(0, 24);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(10, 24);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(418, 24);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // _luUSE_YN
            // 
            this._luUSE_YN.ItemIndex = -1;
            this._luUSE_YN.Location = new System.Drawing.Point(162, 158);
            this._luUSE_YN.Margin = new System.Windows.Forms.Padding(0);
            this._luUSE_YN.Name = "_luUSE_YN";
            this._luUSE_YN.ReadOnly = false;
            this._luUSE_YN.Size = new System.Drawing.Size(265, 20);
            this._luUSE_YN.TabIndex = 11;
            // 
            // _luREMARK
            // 
            this._luREMARK.Location = new System.Drawing.Point(162, 182);
            this._luREMARK.Margin = new System.Windows.Forms.Padding(0);
            this._luREMARK.Name = "_luREMARK";
            this._luREMARK.ReadOnly = false;
            this._luREMARK.Size = new System.Drawing.Size(683, 313);
            this._luREMARK.TabIndex = 10;
            // 
            // _luLIMIT_HIGH
            // 
            this._luLIMIT_HIGH.CancelButton = null;
            this._luLIMIT_HIGH.CommandButton = null;
            this._luLIMIT_HIGH.EditMask = "";
            this._luLIMIT_HIGH.Location = new System.Drawing.Point(579, 110);
            this._luLIMIT_HIGH.Margin = new System.Windows.Forms.Padding(0);
            this._luLIMIT_HIGH.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luLIMIT_HIGH.Name = "_luLIMIT_HIGH";
            this._luLIMIT_HIGH.PasswordChar = '\0';
            this._luLIMIT_HIGH.ReadOnly = false;
            this._luLIMIT_HIGH.Size = new System.Drawing.Size(266, 20);
            this._luLIMIT_HIGH.TabIndex = 9;
            this._luLIMIT_HIGH.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luLIMIT_HIGH.UseMaskAsDisplayFormat = false;
            // 
            // _luLIMIT_LOW
            // 
            this._luLIMIT_LOW.CancelButton = null;
            this._luLIMIT_LOW.CommandButton = null;
            this._luLIMIT_LOW.EditMask = "";
            this._luLIMIT_LOW.Location = new System.Drawing.Point(162, 110);
            this._luLIMIT_LOW.Margin = new System.Windows.Forms.Padding(0);
            this._luLIMIT_LOW.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luLIMIT_LOW.Name = "_luLIMIT_LOW";
            this._luLIMIT_LOW.PasswordChar = '\0';
            this._luLIMIT_LOW.ReadOnly = false;
            this._luLIMIT_LOW.Size = new System.Drawing.Size(265, 20);
            this._luLIMIT_LOW.TabIndex = 8;
            this._luLIMIT_LOW.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luLIMIT_LOW.UseMaskAsDisplayFormat = false;
            // 
            // _luM_LIMIT_HIGH
            // 
            this._luM_LIMIT_HIGH.CancelButton = null;
            this._luM_LIMIT_HIGH.CommandButton = null;
            this._luM_LIMIT_HIGH.EditMask = "";
            this._luM_LIMIT_HIGH.Location = new System.Drawing.Point(579, 62);
            this._luM_LIMIT_HIGH.Margin = new System.Windows.Forms.Padding(0);
            this._luM_LIMIT_HIGH.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luM_LIMIT_HIGH.Name = "_luM_LIMIT_HIGH";
            this._luM_LIMIT_HIGH.PasswordChar = '\0';
            this._luM_LIMIT_HIGH.ReadOnly = false;
            this._luM_LIMIT_HIGH.Size = new System.Drawing.Size(266, 20);
            this._luM_LIMIT_HIGH.TabIndex = 7;
            this._luM_LIMIT_HIGH.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luM_LIMIT_HIGH.UseMaskAsDisplayFormat = false;
            this._luM_LIMIT_HIGH._OnTextChanged += new System.EventHandler(this._luM_LIMIT_HIGH__OnTextChanged);
            // 
            // _luM_LIMIT_LOW
            // 
            this._luM_LIMIT_LOW.CancelButton = null;
            this._luM_LIMIT_LOW.CommandButton = null;
            this._luM_LIMIT_LOW.EditMask = "";
            this._luM_LIMIT_LOW.Location = new System.Drawing.Point(162, 62);
            this._luM_LIMIT_LOW.Margin = new System.Windows.Forms.Padding(0);
            this._luM_LIMIT_LOW.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luM_LIMIT_LOW.Name = "_luM_LIMIT_LOW";
            this._luM_LIMIT_LOW.PasswordChar = '\0';
            this._luM_LIMIT_LOW.ReadOnly = false;
            this._luM_LIMIT_LOW.Size = new System.Drawing.Size(265, 20);
            this._luM_LIMIT_LOW.TabIndex = 6;
            this._luM_LIMIT_LOW.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luM_LIMIT_LOW.UseMaskAsDisplayFormat = false;
            // 
            // _luSENSOR_FLOAT_DIGIT
            // 
            this._luSENSOR_FLOAT_DIGIT.CancelButton = null;
            this._luSENSOR_FLOAT_DIGIT.CommandButton = null;
            this._luSENSOR_FLOAT_DIGIT.EditMask = "";
            this._luSENSOR_FLOAT_DIGIT.Location = new System.Drawing.Point(579, 14);
            this._luSENSOR_FLOAT_DIGIT.Margin = new System.Windows.Forms.Padding(0);
            this._luSENSOR_FLOAT_DIGIT.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luSENSOR_FLOAT_DIGIT.Name = "_luSENSOR_FLOAT_DIGIT";
            this._luSENSOR_FLOAT_DIGIT.PasswordChar = '\0';
            this._luSENSOR_FLOAT_DIGIT.ReadOnly = false;
            this._luSENSOR_FLOAT_DIGIT.Size = new System.Drawing.Size(266, 20);
            this._luSENSOR_FLOAT_DIGIT.TabIndex = 5;
            this._luSENSOR_FLOAT_DIGIT.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luSENSOR_FLOAT_DIGIT.UseMaskAsDisplayFormat = false;
            // 
            // _luSENSOR_UNIT
            // 
            this._luSENSOR_UNIT.ItemIndex = -1;
            this._luSENSOR_UNIT.Location = new System.Drawing.Point(162, 14);
            this._luSENSOR_UNIT.Margin = new System.Windows.Forms.Padding(0);
            this._luSENSOR_UNIT.Name = "_luSENSOR_UNIT";
            this._luSENSOR_UNIT.ReadOnly = false;
            this._luSENSOR_UNIT.Size = new System.Drawing.Size(265, 20);
            this._luSENSOR_UNIT.TabIndex = 4;
            // 
            // _lciSENSOR_UNIT
            // 
            this._lciSENSOR_UNIT.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciSENSOR_UNIT.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciSENSOR_UNIT.Control = this._luSENSOR_UNIT;
            this._lciSENSOR_UNIT.Location = new System.Drawing.Point(0, 0);
            this._lciSENSOR_UNIT.MaxSize = new System.Drawing.Size(0, 24);
            this._lciSENSOR_UNIT.MinSize = new System.Drawing.Size(212, 24);
            this._lciSENSOR_UNIT.Name = "_lciSENSOR_UNIT";
            this._lciSENSOR_UNIT.Size = new System.Drawing.Size(417, 24);
            this._lciSENSOR_UNIT.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciSENSOR_UNIT.TextSize = new System.Drawing.Size(145, 14);
            // 
            // _lciSENSOR_FLOAT_DIGIT
            // 
            this._lciSENSOR_FLOAT_DIGIT.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciSENSOR_FLOAT_DIGIT.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciSENSOR_FLOAT_DIGIT.Control = this._luSENSOR_FLOAT_DIGIT;
            this._lciSENSOR_FLOAT_DIGIT.Location = new System.Drawing.Point(417, 0);
            this._lciSENSOR_FLOAT_DIGIT.MaxSize = new System.Drawing.Size(0, 24);
            this._lciSENSOR_FLOAT_DIGIT.MinSize = new System.Drawing.Size(212, 24);
            this._lciSENSOR_FLOAT_DIGIT.Name = "_lciSENSOR_FLOAT_DIGIT";
            this._lciSENSOR_FLOAT_DIGIT.Size = new System.Drawing.Size(418, 24);
            this._lciSENSOR_FLOAT_DIGIT.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciSENSOR_FLOAT_DIGIT.TextSize = new System.Drawing.Size(145, 14);
            // 
            // _lciM_LIMIT_LOW
            // 
            this._lciM_LIMIT_LOW.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciM_LIMIT_LOW.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciM_LIMIT_LOW.Control = this._luM_LIMIT_LOW;
            this._lciM_LIMIT_LOW.Location = new System.Drawing.Point(0, 0);
            this._lciM_LIMIT_LOW.MaxSize = new System.Drawing.Size(0, 24);
            this._lciM_LIMIT_LOW.MinSize = new System.Drawing.Size(212, 24);
            this._lciM_LIMIT_LOW.Name = "_lciM_LIMIT_LOW";
            this._lciM_LIMIT_LOW.Size = new System.Drawing.Size(417, 24);
            this._lciM_LIMIT_LOW.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciM_LIMIT_LOW.TextSize = new System.Drawing.Size(145, 14);
            // 
            // _lciM_LIMIT_HIGH
            // 
            this._lciM_LIMIT_HIGH.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciM_LIMIT_HIGH.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciM_LIMIT_HIGH.Control = this._luM_LIMIT_HIGH;
            this._lciM_LIMIT_HIGH.Location = new System.Drawing.Point(417, 0);
            this._lciM_LIMIT_HIGH.MaxSize = new System.Drawing.Size(0, 24);
            this._lciM_LIMIT_HIGH.MinSize = new System.Drawing.Size(212, 24);
            this._lciM_LIMIT_HIGH.Name = "_lciM_LIMIT_HIGH";
            this._lciM_LIMIT_HIGH.Size = new System.Drawing.Size(418, 24);
            this._lciM_LIMIT_HIGH.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciM_LIMIT_HIGH.TextSize = new System.Drawing.Size(145, 14);
            // 
            // _lciLIMIT_LOW
            // 
            this._lciLIMIT_LOW.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciLIMIT_LOW.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciLIMIT_LOW.Control = this._luLIMIT_LOW;
            this._lciLIMIT_LOW.Location = new System.Drawing.Point(0, 0);
            this._lciLIMIT_LOW.MaxSize = new System.Drawing.Size(0, 24);
            this._lciLIMIT_LOW.MinSize = new System.Drawing.Size(212, 24);
            this._lciLIMIT_LOW.Name = "_lciLIMIT_LOW";
            this._lciLIMIT_LOW.Size = new System.Drawing.Size(417, 24);
            this._lciLIMIT_LOW.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciLIMIT_LOW.TextSize = new System.Drawing.Size(145, 14);
            // 
            // _lciLIMIT_HIGH
            // 
            this._lciLIMIT_HIGH.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciLIMIT_HIGH.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciLIMIT_HIGH.Control = this._luLIMIT_HIGH;
            this._lciLIMIT_HIGH.Location = new System.Drawing.Point(417, 0);
            this._lciLIMIT_HIGH.MaxSize = new System.Drawing.Size(0, 24);
            this._lciLIMIT_HIGH.MinSize = new System.Drawing.Size(212, 24);
            this._lciLIMIT_HIGH.Name = "_lciLIMIT_HIGH";
            this._lciLIMIT_HIGH.Size = new System.Drawing.Size(418, 24);
            this._lciLIMIT_HIGH.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciLIMIT_HIGH.TextSize = new System.Drawing.Size(145, 14);
            // 
            // _lciUSE_YN
            // 
            this._lciUSE_YN.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciUSE_YN.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciUSE_YN.Control = this._luUSE_YN;
            this._lciUSE_YN.Location = new System.Drawing.Point(0, 0);
            this._lciUSE_YN.MaxSize = new System.Drawing.Size(0, 24);
            this._lciUSE_YN.MinSize = new System.Drawing.Size(212, 24);
            this._lciUSE_YN.Name = "_lciUSE_YN";
            this._lciUSE_YN.Size = new System.Drawing.Size(417, 24);
            this._lciUSE_YN.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciUSE_YN.TextSize = new System.Drawing.Size(145, 14);
            // 
            // _lciREMARK
            // 
            this._lciREMARK.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciREMARK.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciREMARK.Control = this._luREMARK;
            this._lciREMARK.Location = new System.Drawing.Point(0, 24);
            this._lciREMARK.Name = "_lciREMARK";
            this._lciREMARK.Size = new System.Drawing.Size(835, 317);
            this._lciREMARK.TextSize = new System.Drawing.Size(145, 14);
            // 
            // ucResourceSensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ucResourceSensor";
            this.Size = new System.Drawing.Size(859, 509);
            this.Load += new System.EventHandler(this.ucResourceSensor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciSENSOR_UNIT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciSENSOR_FLOAT_DIGIT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciM_LIMIT_LOW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciM_LIMIT_HIGH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciLIMIT_LOW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciLIMIT_HIGH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciUSE_YN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciREMARK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem _lciSENSOR_UNIT;
        private DevExpress.XtraLayout.LayoutControlItem _lciSENSOR_FLOAT_DIGIT;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem _lciM_LIMIT_LOW;
        private DevExpress.XtraLayout.LayoutControlItem _lciM_LIMIT_HIGH;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem _lciLIMIT_LOW;
        private DevExpress.XtraLayout.LayoutControlItem _lciLIMIT_HIGH;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
        private DevExpress.XtraLayout.LayoutControlItem _lciUSE_YN;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem _lciREMARK;
        protected CORE.BaseControls.ucLookUpEdit _luUSE_YN;
        protected CORE.BaseControls.ucMemoEdit _luREMARK;
        protected CORE.BaseControls.ucTextEdit _luLIMIT_HIGH;
        protected CORE.BaseControls.ucTextEdit _luLIMIT_LOW;
        protected CORE.BaseControls.ucTextEdit _luM_LIMIT_HIGH;
        protected CORE.BaseControls.ucTextEdit _luM_LIMIT_LOW;
        protected CORE.BaseControls.ucTextEdit _luSENSOR_FLOAT_DIGIT;
        protected CORE.BaseControls.ucLookUpEdit _luSENSOR_UNIT;
    }
}

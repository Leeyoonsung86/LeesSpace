namespace CoFAS_MES.CORE.UserControls
{
    partial class ucNoticeDetailPopup
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
            this._luUSER = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luCONTENTS = new CoFAS_MES.CORE.BaseControls.ucMemoEdit();
            this._luDATE = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luTITLE = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._lciTITLE = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciDATE = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciCONTENTS = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciUSER = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTITLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciDATE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCONTENTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciUSER)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._luUSER);
            this.layoutControl1.Controls.Add(this._luCONTENTS);
            this.layoutControl1.Controls.Add(this._luDATE);
            this.layoutControl1.Controls.Add(this._luTITLE);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(440, 560);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this._lciTITLE,
            this._lciDATE,
            this._lciCONTENTS,
            this._lciUSER});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(440, 560);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // _luUSER
            // 
            this._luUSER.CancelButton = null;
            this._luUSER.CommandButton = null;
            this._luUSER.EditMask = "";
            this._luUSER.Location = new System.Drawing.Point(328, 36);
            this._luUSER.Margin = new System.Windows.Forms.Padding(0);
            this._luUSER.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luUSER.Name = "_luUSER";
            this._luUSER.PasswordChar = '\0';
            this._luUSER.ReadOnly = false;
            this._luUSER.Size = new System.Drawing.Size(100, 20);
            this._luUSER.TabIndex = 9;
            this._luUSER.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luUSER.UseMaskAsDisplayFormat = false;
            // 
            // _luCONTENTS
            // 
            this._luCONTENTS.Location = new System.Drawing.Point(95, 60);
            this._luCONTENTS.Margin = new System.Windows.Forms.Padding(0);
            this._luCONTENTS.Name = "_luCONTENTS";
            this._luCONTENTS.ReadOnly = false;
            this._luCONTENTS.Size = new System.Drawing.Size(333, 488);
            this._luCONTENTS.TabIndex = 8;
            // 
            // _luDATE
            // 
            this._luDATE.CancelButton = null;
            this._luDATE.CommandButton = null;
            this._luDATE.EditMask = "";
            this._luDATE.Location = new System.Drawing.Point(95, 36);
            this._luDATE.Margin = new System.Windows.Forms.Padding(0);
            this._luDATE.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luDATE.Name = "_luDATE";
            this._luDATE.PasswordChar = '\0';
            this._luDATE.ReadOnly = false;
            this._luDATE.Size = new System.Drawing.Size(146, 20);
            this._luDATE.TabIndex = 7;
            this._luDATE.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luDATE.UseMaskAsDisplayFormat = false;
            // 
            // _luTITLE
            // 
            this._luTITLE.CancelButton = null;
            this._luTITLE.CommandButton = null;
            this._luTITLE.EditMask = "";
            this._luTITLE.Location = new System.Drawing.Point(95, 12);
            this._luTITLE.Margin = new System.Windows.Forms.Padding(0);
            this._luTITLE.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luTITLE.Name = "_luTITLE";
            this._luTITLE.PasswordChar = '\0';
            this._luTITLE.ReadOnly = false;
            this._luTITLE.Size = new System.Drawing.Size(333, 20);
            this._luTITLE.TabIndex = 6;
            this._luTITLE.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luTITLE.UseMaskAsDisplayFormat = false;
            // 
            // _lciTITLE
            // 
            this._lciTITLE.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciTITLE.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciTITLE.Control = this._luTITLE;
            this._lciTITLE.Location = new System.Drawing.Point(0, 0);
            this._lciTITLE.Name = "_lciTITLE";
            this._lciTITLE.Size = new System.Drawing.Size(420, 24);
            this._lciTITLE.TextSize = new System.Drawing.Size(79, 14);
            // 
            // _lciDATE
            // 
            this._lciDATE.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciDATE.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciDATE.Control = this._luDATE;
            this._lciDATE.Location = new System.Drawing.Point(0, 24);
            this._lciDATE.Name = "_lciDATE";
            this._lciDATE.Size = new System.Drawing.Size(233, 24);
            this._lciDATE.TextSize = new System.Drawing.Size(79, 14);
            // 
            // _lciCONTENTS
            // 
            this._lciCONTENTS.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciCONTENTS.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciCONTENTS.Control = this._luCONTENTS;
            this._lciCONTENTS.Location = new System.Drawing.Point(0, 48);
            this._lciCONTENTS.Name = "_lciCONTENTS";
            this._lciCONTENTS.Size = new System.Drawing.Size(420, 492);
            this._lciCONTENTS.TextSize = new System.Drawing.Size(79, 14);
            // 
            // _lciUSER
            // 
            this._lciUSER.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciUSER.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciUSER.Control = this._luUSER;
            this._lciUSER.Location = new System.Drawing.Point(233, 24);
            this._lciUSER.Name = "_lciUSER";
            this._lciUSER.Size = new System.Drawing.Size(187, 24);
            this._lciUSER.TextSize = new System.Drawing.Size(79, 14);
            // 
            // ucNoticeDetailPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucNoticeDetailPopup";
            this.Size = new System.Drawing.Size(440, 560);
            this.Load += new System.EventHandler(this.ucNoticeDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTITLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciDATE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCONTENTS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciUSER)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private BaseControls.ucTextEdit _luUSER;
        private BaseControls.ucMemoEdit _luCONTENTS;
        private BaseControls.ucTextEdit _luDATE;
        private BaseControls.ucTextEdit _luTITLE;
        private DevExpress.XtraLayout.LayoutControlItem _lciTITLE;
        private DevExpress.XtraLayout.LayoutControlItem _lciDATE;
        private DevExpress.XtraLayout.LayoutControlItem _lciCONTENTS;
        private DevExpress.XtraLayout.LayoutControlItem _lciUSER;
    }
}

namespace CoFAS_MES.CORE.BaseControls
{
    partial class ucSpinEdit
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
            this._pSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this._pSpinEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // _pSpinEdit
            // 
            this._pSpinEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this._pSpinEdit.Location = new System.Drawing.Point(0, 0);
            this._pSpinEdit.Name = "_pSpinEdit";
            this._pSpinEdit.Properties.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this._pSpinEdit.Properties.Appearance.Options.UseBackColor = true;
            this._pSpinEdit.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Tomato;
            this._pSpinEdit.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this._pSpinEdit.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Yellow;
            this._pSpinEdit.Properties.AppearanceFocused.Options.UseBackColor = true;
            this._pSpinEdit.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this._pSpinEdit.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this._pSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._pSpinEdit.Size = new System.Drawing.Size(150, 20);
            this._pSpinEdit.TabIndex = 0;
            // 
            // ucSpinEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._pSpinEdit);
            this.Name = "ucSpinEdit";
            this.Size = new System.Drawing.Size(150, 20);
            ((System.ComponentModel.ISupportInitialize)(this._pSpinEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SpinEdit _pSpinEdit;
    }
}

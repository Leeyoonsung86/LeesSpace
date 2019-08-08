namespace CoFAS_MES.CORE.BaseControls
{
    partial class ucComboBox
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
            this._pComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this._pComboBoxEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // _pComboBoxEdit
            // 
            this._pComboBoxEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pComboBoxEdit.Location = new System.Drawing.Point(0, 0);
            this._pComboBoxEdit.Margin = new System.Windows.Forms.Padding(0);
            this._pComboBoxEdit.Name = "_pComboBoxEdit";
            this._pComboBoxEdit.Properties.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this._pComboBoxEdit.Properties.Appearance.Options.UseBackColor = true;
            this._pComboBoxEdit.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Tomato;
            this._pComboBoxEdit.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this._pComboBoxEdit.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Yellow;
            this._pComboBoxEdit.Properties.AppearanceFocused.Options.UseBackColor = true;
            this._pComboBoxEdit.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this._pComboBoxEdit.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this._pComboBoxEdit.Properties.AutoHeight = false;
            this._pComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._pComboBoxEdit.Size = new System.Drawing.Size(131, 20);
            this._pComboBoxEdit.TabIndex = 0;
            // 
            // ucComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._pComboBoxEdit);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucComboBox";
            this.Size = new System.Drawing.Size(131, 19);
            ((System.ComponentModel.ISupportInitialize)(this._pComboBoxEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit _pComboBoxEdit;
    }
}

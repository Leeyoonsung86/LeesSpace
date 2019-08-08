namespace CoFAS_MES.CORE.BaseControls
{
    partial class ucLookUpEdit
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
            this._pLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this._pLookUpEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // _pLookUpEdit
            // 
            this._pLookUpEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pLookUpEdit.Location = new System.Drawing.Point(0, 0);
            this._pLookUpEdit.Margin = new System.Windows.Forms.Padding(0);
            this._pLookUpEdit.Name = "_pLookUpEdit";
            this._pLookUpEdit.Properties.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this._pLookUpEdit.Properties.Appearance.Options.UseBackColor = true;
            this._pLookUpEdit.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Tomato;
            this._pLookUpEdit.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this._pLookUpEdit.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.AliceBlue;
            this._pLookUpEdit.Properties.AppearanceDropDown.Options.UseBackColor = true;
            this._pLookUpEdit.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.AliceBlue;
            this._pLookUpEdit.Properties.AppearanceDropDownHeader.Options.UseBackColor = true;
            this._pLookUpEdit.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Yellow;
            this._pLookUpEdit.Properties.AppearanceFocused.Options.UseBackColor = true;
            this._pLookUpEdit.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this._pLookUpEdit.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this._pLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._pLookUpEdit.Size = new System.Drawing.Size(150, 20);
            this._pLookUpEdit.TabIndex = 0;
            // 
            // ucLookUpEdit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.Controls.Add(this._pLookUpEdit);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucLookUpEdit";
            this.Size = new System.Drawing.Size(150, 20);
            ((System.ComponentModel.ISupportInitialize)(this._pLookUpEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit _pLookUpEdit;
    }
}

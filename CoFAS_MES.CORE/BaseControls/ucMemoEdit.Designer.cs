namespace CoFAS_MES.CORE.BaseControls
{
    partial class ucMemoEdit
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
            this._pMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this._pMemoEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // _pMemoEdit
            // 
            this._pMemoEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pMemoEdit.Location = new System.Drawing.Point(0, 0);
            this._pMemoEdit.Margin = new System.Windows.Forms.Padding(0);
            this._pMemoEdit.Name = "_pMemoEdit";
            this._pMemoEdit.Properties.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this._pMemoEdit.Properties.Appearance.Options.UseBackColor = true;
            this._pMemoEdit.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Tomato;
            this._pMemoEdit.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this._pMemoEdit.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Yellow;
            this._pMemoEdit.Properties.AppearanceFocused.Options.UseBackColor = true;
            this._pMemoEdit.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this._pMemoEdit.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this._pMemoEdit.Size = new System.Drawing.Size(131, 120);
            this._pMemoEdit.TabIndex = 0;
            // 
            // ucMemoEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._pMemoEdit);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucMemoEdit";
            this.Size = new System.Drawing.Size(131, 120);
            ((System.ComponentModel.ISupportInitialize)(this._pMemoEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit _pMemoEdit;
    }
}

namespace CoFAS_MES.CORE.BaseControls
{
    partial class ucSimpleButton
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
            this._pSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // _pSimpleButton
            // 
            this._pSimpleButton.Appearance.ForeColor = System.Drawing.Color.Black;
            this._pSimpleButton.Appearance.Options.UseForeColor = true;
            this._pSimpleButton.AppearanceDisabled.BackColor = System.Drawing.Color.Tomato;
            this._pSimpleButton.AppearanceDisabled.Options.UseBackColor = true;
            this._pSimpleButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this._pSimpleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pSimpleButton.ImageOptions.Image = global::CoFAS_MES.CORE.Properties.Resources.None;
            this._pSimpleButton.Location = new System.Drawing.Point(0, 0);
            this._pSimpleButton.Margin = new System.Windows.Forms.Padding(0);
            this._pSimpleButton.Name = "_pSimpleButton";
            this._pSimpleButton.Size = new System.Drawing.Size(100, 23);
            this._pSimpleButton.TabIndex = 0;
            this._pSimpleButton.Text = "simpleButton";
            // 
            // ucSimpleButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._pSimpleButton);
            this.Name = "ucSimpleButton";
            this.Size = new System.Drawing.Size(100, 23);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton _pSimpleButton;
    }
}

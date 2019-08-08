namespace CoFAS_MES.CORE.BaseControls
{
    partial class ucPictureEdit
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
            this._pPictureEdit = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this._pPictureEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // _pPictureEdit
            // 
            this._pPictureEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this._pPictureEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pPictureEdit.EditValue = global::CoFAS_MES.CORE.Properties.Resources.None;
            this._pPictureEdit.Location = new System.Drawing.Point(0, 0);
            this._pPictureEdit.Margin = new System.Windows.Forms.Padding(0);
            this._pPictureEdit.Name = "_pPictureEdit";
            this._pPictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this._pPictureEdit.Properties.ShowMenu = false;
            this._pPictureEdit.Properties.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.False;
            this._pPictureEdit.Size = new System.Drawing.Size(194, 169);
            this._pPictureEdit.TabIndex = 0;
            // 
            // ucPictureEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._pPictureEdit);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucPictureEdit";
            this.Size = new System.Drawing.Size(194, 169);
            ((System.ComponentModel.ISupportInitialize)(this._pPictureEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit _pPictureEdit;
    }
}

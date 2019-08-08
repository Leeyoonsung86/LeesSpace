namespace CoFAS_MES.CORE.UserForm
{
    partial class frmImageView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImageView));
            this._PictureEdit = new CoFAS_MES.CORE.BaseControls.ucPictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this._pnSINGLE_MAIN)).BeginInit();
            this._pnSINGLE_MAIN.SuspendLayout();
            this.SuspendLayout();
            // 
            // _pnSINGLE_MAIN
            // 
            this._pnSINGLE_MAIN.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnSINGLE_MAIN.Appearance.BorderColor = System.Drawing.Color.Silver;
            this._pnSINGLE_MAIN.Appearance.Options.UseBackColor = true;
            this._pnSINGLE_MAIN.Appearance.Options.UseBorderColor = true;
            this._pnSINGLE_MAIN.Controls.Add(this._PictureEdit);
            // 
            // _PictureEdit
            // 
            this._PictureEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this._PictureEdit.Image = ((System.Drawing.Image)(resources.GetObject("_PictureEdit.Image")));
            this._PictureEdit.Location = new System.Drawing.Point(0, 0);
            this._PictureEdit.Margin = new System.Windows.Forms.Padding(0);
            this._PictureEdit.Name = "_PictureEdit";
            this._PictureEdit.Size = new System.Drawing.Size(800, 560);
            this._PictureEdit.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this._PictureEdit.TabIndex = 0;
            // 
            // frmImageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Name = "frmImageView";
            this.Text = "frmImageView";
            ((System.ComponentModel.ISupportInitialize)(this._pnSINGLE_MAIN)).EndInit();
            this._pnSINGLE_MAIN.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BaseControls.ucPictureEdit _PictureEdit;
    }
}
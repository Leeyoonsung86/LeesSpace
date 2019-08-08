namespace CoFAS_MES.UI.MO
{
    partial class SenserView
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
            ((System.ComponentModel.ISupportInitialize)(this._pnHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pnContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pnLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // _pnHeader
            // 
            this._pnHeader.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnHeader.Appearance.Options.UseBackColor = true;
            this._pnHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnHeader.Size = new System.Drawing.Size(1400, 720);
            // 
            // _pnContent
            // 
            this._pnContent.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnContent.Appearance.Options.UseBackColor = true;
            this._pnContent.Location = new System.Drawing.Point(0, 0);
            this._pnContent.Size = new System.Drawing.Size(1400, 720);
            // 
            // _pnLeft
            // 
            this._pnLeft.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnLeft.Appearance.Options.UseBackColor = true;
            this._pnLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnLeft.Location = new System.Drawing.Point(0, 0);
            this._pnLeft.Size = new System.Drawing.Size(1400, 720);
            // 
            // dashboardViewer
            // 
            this.dashboardViewer.DataSourceOptions.ObjectDataSourceLoadingBehavior = DevExpress.DataAccess.DocumentLoadingBehavior.LoadAsIs;
            this.dashboardViewer.Size = new System.Drawing.Size(1352, 672);
            // 
            // SenserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 720);
            this.Name = "SenserView";
            this.Text = "SenserView";
            this.WindowName = "SenserView";
            ((System.ComponentModel.ISupportInitialize)(this._pnHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pnContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pnLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
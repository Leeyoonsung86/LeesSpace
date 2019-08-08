namespace CoFAS_MES.CORE.BaseForm
{
    partial class frmBaseNone
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
            this._pnHeader = new DevExpress.XtraEditors.PanelControl();
            this._pnContent = new DevExpress.XtraEditors.PanelControl();
            this._pnLeft = new DevExpress.XtraEditors.PanelControl();
            this.dxValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.dxWaitViewManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::CoFAS_MES.CORE.BaseForm.frmWaitView), true, true);
            this.splitterControl2 = new DevExpress.XtraEditors.SplitterControl();
            this._pnRight = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this._pnHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pnContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pnLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pnRight)).BeginInit();
            this.SuspendLayout();
            // 
            // _pnHeader
            // 
            this._pnHeader.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnHeader.Appearance.Options.UseBackColor = true;
            this._pnHeader.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this._pnHeader.Location = new System.Drawing.Point(0, 0);
            this._pnHeader.Name = "_pnHeader";
            this._pnHeader.Size = new System.Drawing.Size(1300, 86);
            this._pnHeader.TabIndex = 0;
            // 
            // _pnContent
            // 
            this._pnContent.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnContent.Appearance.Options.UseBackColor = true;
            this._pnContent.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnContent.Location = new System.Drawing.Point(205, 86);
            this._pnContent.Name = "_pnContent";
            this._pnContent.Size = new System.Drawing.Size(890, 634);
            this._pnContent.TabIndex = 1;
            // 
            // _pnLeft
            // 
            this._pnLeft.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnLeft.Appearance.Options.UseBackColor = true;
            this._pnLeft.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this._pnLeft.Location = new System.Drawing.Point(0, 86);
            this._pnLeft.Name = "_pnLeft";
            this._pnLeft.Size = new System.Drawing.Size(200, 634);
            this._pnLeft.TabIndex = 2;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.splitterControl1.Appearance.Options.UseBackColor = true;
            this.splitterControl1.Location = new System.Drawing.Point(200, 86);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 634);
            this.splitterControl1.TabIndex = 3;
            this.splitterControl1.TabStop = false;
            // 
            // dxWaitViewManager
            // 
            this.dxWaitViewManager.ClosingDelay = 500;
            // 
            // splitterControl2
            // 
            this.splitterControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.splitterControl2.Appearance.Options.UseBackColor = true;
            this.splitterControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitterControl2.Location = new System.Drawing.Point(1095, 86);
            this.splitterControl2.Name = "splitterControl2";
            this.splitterControl2.Size = new System.Drawing.Size(5, 634);
            this.splitterControl2.TabIndex = 0;
            this.splitterControl2.TabStop = false;
            // 
            // _pnRight
            // 
            this._pnRight.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnRight.Appearance.Options.UseBackColor = true;
            this._pnRight.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._pnRight.Dock = System.Windows.Forms.DockStyle.Right;
            this._pnRight.Location = new System.Drawing.Point(1100, 86);
            this._pnRight.Name = "_pnRight";
            this._pnRight.Size = new System.Drawing.Size(200, 634);
            this._pnRight.TabIndex = 4;
            // 
            // frmBaseNone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(1300, 720);
            this.Controls.Add(this._pnContent);
            this.Controls.Add(this.splitterControl2);
            this.Controls.Add(this._pnRight);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this._pnLeft);
            this.Controls.Add(this._pnHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBaseNone";
            this.Text = "frmBaseNone";
            ((System.ComponentModel.ISupportInitialize)(this._pnHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pnContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pnLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pnRight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraEditors.PanelControl _pnHeader;
        protected DevExpress.XtraEditors.PanelControl _pnContent;
        protected DevExpress.XtraEditors.PanelControl _pnLeft;
        protected DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        protected DevExpress.XtraSplashScreen.SplashScreenManager dxWaitViewManager;
        private DevExpress.XtraEditors.SplitterControl splitterControl2;
        protected DevExpress.XtraEditors.PanelControl _pnRight;
    }
}
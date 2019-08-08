namespace CoFAS_MES.CORE.BaseForm
{
    partial class frmBaseSingle
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
            this._lbSINGLE_HEADER = new DevExpress.XtraEditors.LabelControl();
            this._pnSINGLE_TOP = new DevExpress.XtraEditors.PanelControl();
            this._btPageSetting = new DevExpress.XtraEditors.SimpleButton();
            this._btSingleNomal = new DevExpress.XtraEditors.SimpleButton();
            this._btSingleMax = new DevExpress.XtraEditors.SimpleButton();
            this._btSingleClose = new DevExpress.XtraEditors.SimpleButton();
            this._pnSINGLE_MAIN = new DevExpress.XtraEditors.PanelControl();
            this._pnSINGLE_BOTTOM = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this._pnSINGLE_TOP)).BeginInit();
            this._pnSINGLE_TOP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pnSINGLE_MAIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pnSINGLE_BOTTOM)).BeginInit();
            this.SuspendLayout();
            // 
            // _lbSINGLE_HEADER
            // 
            this._lbSINGLE_HEADER.Appearance.BackColor = System.Drawing.Color.DarkTurquoise;
            this._lbSINGLE_HEADER.Appearance.Image = global::CoFAS_MES.CORE.Properties.Resources.paneloff_16x16;
            this._lbSINGLE_HEADER.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._lbSINGLE_HEADER.Appearance.Options.UseBackColor = true;
            this._lbSINGLE_HEADER.Appearance.Options.UseImage = true;
            this._lbSINGLE_HEADER.Appearance.Options.UseImageAlign = true;
            this._lbSINGLE_HEADER.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this._lbSINGLE_HEADER.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbSINGLE_HEADER.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this._lbSINGLE_HEADER.Location = new System.Drawing.Point(0, 0);
            this._lbSINGLE_HEADER.Name = "_lbSINGLE_HEADER";
            this._lbSINGLE_HEADER.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this._lbSINGLE_HEADER.Size = new System.Drawing.Size(723, 20);
            this._lbSINGLE_HEADER.TabIndex = 0;
            this._lbSINGLE_HEADER.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_Moving);
            // 
            // _pnSINGLE_TOP
            // 
            this._pnSINGLE_TOP.Appearance.BackColor = System.Drawing.Color.DarkTurquoise;
            this._pnSINGLE_TOP.Appearance.Options.UseBackColor = true;
            this._pnSINGLE_TOP.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._pnSINGLE_TOP.Controls.Add(this._lbSINGLE_HEADER);
            this._pnSINGLE_TOP.Controls.Add(this._btPageSetting);
            this._pnSINGLE_TOP.Controls.Add(this._btSingleNomal);
            this._pnSINGLE_TOP.Controls.Add(this._btSingleMax);
            this._pnSINGLE_TOP.Controls.Add(this._btSingleClose);
            this._pnSINGLE_TOP.Dock = System.Windows.Forms.DockStyle.Top;
            this._pnSINGLE_TOP.Location = new System.Drawing.Point(0, 0);
            this._pnSINGLE_TOP.Margin = new System.Windows.Forms.Padding(0);
            this._pnSINGLE_TOP.Name = "_pnSINGLE_TOP";
            this._pnSINGLE_TOP.Size = new System.Drawing.Size(803, 20);
            this._pnSINGLE_TOP.TabIndex = 1;
            // 
            // _btPageSetting
            // 
            this._btPageSetting.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._btPageSetting.Dock = System.Windows.Forms.DockStyle.Right;
            this._btPageSetting.ImageOptions.Image = global::CoFAS_MES.CORE.Properties.Resources.customizegrid_16x16;
            this._btPageSetting.Location = new System.Drawing.Point(723, 0);
            this._btPageSetting.Name = "_btPageSetting";
            this._btPageSetting.Size = new System.Drawing.Size(20, 20);
            this._btPageSetting.TabIndex = 4;
            this._btPageSetting.Click += new System.EventHandler(this._btPageSetting_Click);
            // 
            // _btSingleNomal
            // 
            this._btSingleNomal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._btSingleNomal.Dock = System.Windows.Forms.DockStyle.Right;
            this._btSingleNomal.ImageOptions.Image = global::CoFAS_MES.CORE.Properties.Resources.alignhorizontalcenter_16x16;
            this._btSingleNomal.Location = new System.Drawing.Point(743, 0);
            this._btSingleNomal.Name = "_btSingleNomal";
            this._btSingleNomal.Size = new System.Drawing.Size(20, 20);
            this._btSingleNomal.TabIndex = 3;
            this._btSingleNomal.Click += new System.EventHandler(this._btSingleNomal_Click);
            // 
            // _btSingleMax
            // 
            this._btSingleMax.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._btSingleMax.Dock = System.Windows.Forms.DockStyle.Right;
            this._btSingleMax.ImageOptions.Image = global::CoFAS_MES.CORE.Properties.Resources.alignhorizontaltop_16x16;
            this._btSingleMax.Location = new System.Drawing.Point(763, 0);
            this._btSingleMax.Name = "_btSingleMax";
            this._btSingleMax.Size = new System.Drawing.Size(20, 20);
            this._btSingleMax.TabIndex = 2;
            this._btSingleMax.Click += new System.EventHandler(this._btSingleMax_Click);
            // 
            // _btSingleClose
            // 
            this._btSingleClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._btSingleClose.Dock = System.Windows.Forms.DockStyle.Right;
            this._btSingleClose.ImageOptions.Image = global::CoFAS_MES.CORE.Properties.Resources.close_16x16;
            this._btSingleClose.Location = new System.Drawing.Point(783, 0);
            this._btSingleClose.Name = "_btSingleClose";
            this._btSingleClose.Size = new System.Drawing.Size(20, 20);
            this._btSingleClose.TabIndex = 1;
            this._btSingleClose.Click += new System.EventHandler(this._btSingleClose_Click);
            // 
            // _pnSINGLE_MAIN
            // 
            this._pnSINGLE_MAIN.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnSINGLE_MAIN.Appearance.BorderColor = System.Drawing.Color.Silver;
            this._pnSINGLE_MAIN.Appearance.Options.UseBackColor = true;
            this._pnSINGLE_MAIN.Appearance.Options.UseBorderColor = true;
            this._pnSINGLE_MAIN.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._pnSINGLE_MAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnSINGLE_MAIN.Location = new System.Drawing.Point(0, 20);
            this._pnSINGLE_MAIN.Margin = new System.Windows.Forms.Padding(0);
            this._pnSINGLE_MAIN.Name = "_pnSINGLE_MAIN";
            this._pnSINGLE_MAIN.Size = new System.Drawing.Size(803, 560);
            this._pnSINGLE_MAIN.TabIndex = 2;
            // 
            // _pnSINGLE_BOTTOM
            // 
            this._pnSINGLE_BOTTOM.Appearance.BackColor = System.Drawing.Color.DarkTurquoise;
            this._pnSINGLE_BOTTOM.Appearance.Options.UseBackColor = true;
            this._pnSINGLE_BOTTOM.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._pnSINGLE_BOTTOM.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._pnSINGLE_BOTTOM.Location = new System.Drawing.Point(0, 580);
            this._pnSINGLE_BOTTOM.Margin = new System.Windows.Forms.Padding(0);
            this._pnSINGLE_BOTTOM.Name = "_pnSINGLE_BOTTOM";
            this._pnSINGLE_BOTTOM.Size = new System.Drawing.Size(803, 20);
            this._pnSINGLE_BOTTOM.TabIndex = 3;
            this._pnSINGLE_BOTTOM.Visible = false;
            // 
            // frmBaseSingle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(803, 600);
            this.Controls.Add(this._pnSINGLE_MAIN);
            this.Controls.Add(this._pnSINGLE_BOTTOM);
            this.Controls.Add(this._pnSINGLE_TOP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBaseSingle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmBaseSingle";
            this.Load += new System.EventHandler(this.frmBaseSingle_Load);
            ((System.ComponentModel.ISupportInitialize)(this._pnSINGLE_TOP)).EndInit();
            this._pnSINGLE_TOP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pnSINGLE_MAIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pnSINGLE_BOTTOM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl _lbSINGLE_HEADER;
        private DevExpress.XtraEditors.PanelControl _pnSINGLE_TOP;
        protected DevExpress.XtraEditors.PanelControl _pnSINGLE_MAIN;
        private DevExpress.XtraEditors.SimpleButton _btSingleClose;
        private DevExpress.XtraEditors.SimpleButton _btSingleNomal;
        private DevExpress.XtraEditors.SimpleButton _btSingleMax;
        private DevExpress.XtraEditors.PanelControl _pnSINGLE_BOTTOM;
        protected DevExpress.XtraEditors.SimpleButton _btPageSetting;
    }
}
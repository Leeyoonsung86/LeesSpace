namespace CoFAS_MES.POP
{
    partial class frmGatheringMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGatheringMain));
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this._pnGMain = new System.Windows.Forms.Panel();
            this._pnMain.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // _pnMain
            // 
            this._pnMain.Controls.Add(this.tableLayoutPanel4);
            this._pnMain.Size = new System.Drawing.Size(1224, 599);
            // 
            // _pnRight
            // 
            this._pnRight.Location = new System.Drawing.Point(1224, 0);
            this._pnRight.Size = new System.Drawing.Size(10, 599);
            // 
            // _lbHeader
            // 
            this._lbHeader.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this._lbHeader.Appearance.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbHeader.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("_lbHeader.Appearance.Image")));
            this._lbHeader.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._lbHeader.Appearance.Options.UseBackColor = true;
            this._lbHeader.Appearance.Options.UseFont = true;
            this._lbHeader.Appearance.Options.UseImage = true;
            this._lbHeader.Appearance.Options.UseImageAlign = true;
            this._lbHeader.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this._lbHeader.Size = new System.Drawing.Size(1174, 20);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.32026F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.67974F));
            this.tableLayoutPanel4.Controls.Add(this._pnGMain, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.679466F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.32053F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1224, 599);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // _pnGMain
            // 
            this._pnGMain.AutoScroll = true;
            this._pnGMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tableLayoutPanel4.SetColumnSpan(this._pnGMain, 2);
            this._pnGMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnGMain.Location = new System.Drawing.Point(3, 48);
            this._pnGMain.Name = "_pnGMain";
            this._pnGMain.Size = new System.Drawing.Size(1218, 548);
            this._pnGMain.TabIndex = 0;
            // 
            // frmGatheringMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1234, 729);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmGatheringMain";
            this._pnMain.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel _pnGMain;
    }
}
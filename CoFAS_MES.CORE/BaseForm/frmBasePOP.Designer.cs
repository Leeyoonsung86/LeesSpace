namespace CoFAS_MES.CORE.BaseForm
{
    partial class frmBasePOP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBasePOP));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this._lbTitle = new DevExpress.XtraEditors.LabelControl();
            this._lbStartName = new DevExpress.XtraEditors.LabelControl();
            this._lbCurrentName = new DevExpress.XtraEditors.LabelControl();
            this._lbStartTime = new DevExpress.XtraEditors.LabelControl();
            this._lbCurrentTime = new DevExpress.XtraEditors.LabelControl();
            this._peCI = new DevExpress.XtraEditors.PictureEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this._lbHeader = new DevExpress.XtraEditors.LabelControl();
            this._btMin = new DevExpress.XtraEditors.SimpleButton();
            this._btMax = new DevExpress.XtraEditors.SimpleButton();
            this._btClose = new DevExpress.XtraEditors.SimpleButton();
            this._lbMessage = new DevExpress.XtraEditors.LabelControl();
            this._pnBody = new System.Windows.Forms.Panel();
            this._pnMain = new System.Windows.Forms.Panel();
            this._pnRight = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._peCI.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this._pnBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._lbMessage, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this._pnBody, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(817, 729);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(817, 100);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.ColumnCount = 8;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 197F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.Controls.Add(this._lbTitle, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this._lbStartName, 5, 1);
            this.tableLayoutPanel3.Controls.Add(this._lbCurrentName, 5, 3);
            this.tableLayoutPanel3.Controls.Add(this._lbStartTime, 6, 1);
            this.tableLayoutPanel3.Controls.Add(this._lbCurrentTime, 6, 3);
            this.tableLayoutPanel3.Controls.Add(this._peCI, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 20);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(817, 80);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // _lbTitle
            // 
            this._lbTitle.Appearance.Font = new System.Drawing.Font("Meiryo UI", 18F, System.Drawing.FontStyle.Bold);
            this._lbTitle.Appearance.ForeColor = System.Drawing.Color.Black;
            this._lbTitle.Appearance.Options.UseFont = true;
            this._lbTitle.Appearance.Options.UseForeColor = true;
            this._lbTitle.Appearance.Options.UseTextOptions = true;
            this._lbTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._lbTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this._lbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbTitle.Location = new System.Drawing.Point(220, 10);
            this._lbTitle.Margin = new System.Windows.Forms.Padding(0);
            this._lbTitle.Name = "_lbTitle";
            this._lbTitle.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel3.SetRowSpan(this._lbTitle, 3);
            this._lbTitle.Size = new System.Drawing.Size(271, 60);
            this._lbTitle.TabIndex = 0;
            this._lbTitle.Text = "Title Name";
            // 
            // _lbStartName
            // 
            this._lbStartName.Appearance.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold);
            this._lbStartName.Appearance.ForeColor = System.Drawing.Color.Black;
            this._lbStartName.Appearance.Options.UseFont = true;
            this._lbStartName.Appearance.Options.UseForeColor = true;
            this._lbStartName.Appearance.Options.UseTextOptions = true;
            this._lbStartName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lbStartName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this._lbStartName.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbStartName.Location = new System.Drawing.Point(501, 10);
            this._lbStartName.Margin = new System.Windows.Forms.Padding(0);
            this._lbStartName.Name = "_lbStartName";
            this._lbStartName.Padding = new System.Windows.Forms.Padding(5);
            this._lbStartName.Size = new System.Drawing.Size(109, 25);
            this._lbStartName.TabIndex = 1;
            this._lbStartName.Text = "開始時間 :";
            // 
            // _lbCurrentName
            // 
            this._lbCurrentName.Appearance.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold);
            this._lbCurrentName.Appearance.ForeColor = System.Drawing.Color.Black;
            this._lbCurrentName.Appearance.Options.UseFont = true;
            this._lbCurrentName.Appearance.Options.UseForeColor = true;
            this._lbCurrentName.Appearance.Options.UseTextOptions = true;
            this._lbCurrentName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lbCurrentName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this._lbCurrentName.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbCurrentName.Location = new System.Drawing.Point(501, 45);
            this._lbCurrentName.Margin = new System.Windows.Forms.Padding(0);
            this._lbCurrentName.Name = "_lbCurrentName";
            this._lbCurrentName.Padding = new System.Windows.Forms.Padding(5);
            this._lbCurrentName.Size = new System.Drawing.Size(109, 25);
            this._lbCurrentName.TabIndex = 2;
            this._lbCurrentName.Text = "現在の時刻 :";
            // 
            // _lbStartTime
            // 
            this._lbStartTime.Appearance.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold);
            this._lbStartTime.Appearance.ForeColor = System.Drawing.Color.Black;
            this._lbStartTime.Appearance.Options.UseFont = true;
            this._lbStartTime.Appearance.Options.UseForeColor = true;
            this._lbStartTime.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this._lbStartTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbStartTime.Location = new System.Drawing.Point(610, 10);
            this._lbStartTime.Margin = new System.Windows.Forms.Padding(0);
            this._lbStartTime.Name = "_lbStartTime";
            this._lbStartTime.Padding = new System.Windows.Forms.Padding(5);
            this._lbStartTime.Size = new System.Drawing.Size(197, 25);
            this._lbStartTime.TabIndex = 3;
            this._lbStartTime.Text = "9999-12-31 12:59:59";
            // 
            // _lbCurrentTime
            // 
            this._lbCurrentTime.Appearance.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold);
            this._lbCurrentTime.Appearance.ForeColor = System.Drawing.Color.Black;
            this._lbCurrentTime.Appearance.Options.UseFont = true;
            this._lbCurrentTime.Appearance.Options.UseForeColor = true;
            this._lbCurrentTime.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this._lbCurrentTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbCurrentTime.Location = new System.Drawing.Point(610, 45);
            this._lbCurrentTime.Margin = new System.Windows.Forms.Padding(0);
            this._lbCurrentTime.Name = "_lbCurrentTime";
            this._lbCurrentTime.Padding = new System.Windows.Forms.Padding(5);
            this._lbCurrentTime.Size = new System.Drawing.Size(197, 25);
            this._lbCurrentTime.TabIndex = 4;
            this._lbCurrentTime.Text = "9999-12-31 12:59:59";
            // 
            // _peCI
            // 
            this._peCI.Cursor = System.Windows.Forms.Cursors.Default;
            this._peCI.Dock = System.Windows.Forms.DockStyle.Fill;
            this._peCI.EditValue = global::CoFAS_MES.CORE.Properties.Resources.Coever;
            this._peCI.Location = new System.Drawing.Point(10, 10);
            this._peCI.Margin = new System.Windows.Forms.Padding(0);
            this._peCI.Name = "_peCI";
            this._peCI.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._peCI.Properties.Appearance.Options.UseBackColor = true;
            this._peCI.Properties.Appearance.Options.UseImage = true;
            this._peCI.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._peCI.Properties.ShowMenu = false;
            this._peCI.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.tableLayoutPanel3.SetRowSpan(this._peCI, 3);
            this._peCI.Size = new System.Drawing.Size(200, 60);
            this._peCI.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._lbHeader);
            this.panel1.Controls.Add(this._btMin);
            this.panel1.Controls.Add(this._btMax);
            this.panel1.Controls.Add(this._btClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 20);
            this.panel1.TabIndex = 2;
            // 
            // _lbHeader
            // 
            this._lbHeader.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this._lbHeader.Appearance.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Bold);
            this._lbHeader.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("_lbHeader.Appearance.Image")));
            this._lbHeader.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._lbHeader.Appearance.Options.UseBackColor = true;
            this._lbHeader.Appearance.Options.UseFont = true;
            this._lbHeader.Appearance.Options.UseImage = true;
            this._lbHeader.Appearance.Options.UseImageAlign = true;
            this._lbHeader.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this._lbHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbHeader.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this._lbHeader.Location = new System.Drawing.Point(0, 0);
            this._lbHeader.Margin = new System.Windows.Forms.Padding(0);
            this._lbHeader.Name = "_lbHeader";
            this._lbHeader.Padding = new System.Windows.Forms.Padding(10);
            this._lbHeader.Size = new System.Drawing.Size(757, 20);
            this._lbHeader.TabIndex = 2;
            this._lbHeader.Text = "Menu Name_ver";
            this._lbHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_Moving);
            // 
            // _btMin
            // 
            this._btMin.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this._btMin.Appearance.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btMin.Appearance.Options.UseBackColor = true;
            this._btMin.Appearance.Options.UseFont = true;
            this._btMin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this._btMin.Dock = System.Windows.Forms.DockStyle.Right;
            this._btMin.ImageOptions.Image = global::CoFAS_MES.CORE.Properties.Resources.alignhorizontalbottom_16x16;
            this._btMin.Location = new System.Drawing.Point(757, 0);
            this._btMin.Margin = new System.Windows.Forms.Padding(0);
            this._btMin.Name = "_btMin";
            this._btMin.Size = new System.Drawing.Size(20, 20);
            this._btMin.TabIndex = 3;
            this._btMin.Click += new System.EventHandler(this._btMin_Click);
            // 
            // _btMax
            // 
            this._btMax.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this._btMax.Appearance.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btMax.Appearance.Options.UseBackColor = true;
            this._btMax.Appearance.Options.UseFont = true;
            this._btMax.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this._btMax.Dock = System.Windows.Forms.DockStyle.Right;
            this._btMax.ImageOptions.Image = global::CoFAS_MES.CORE.Properties.Resources.alignhorizontaltop_16x16;
            this._btMax.Location = new System.Drawing.Point(777, 0);
            this._btMax.Margin = new System.Windows.Forms.Padding(0);
            this._btMax.Name = "_btMax";
            this._btMax.Size = new System.Drawing.Size(20, 20);
            this._btMax.TabIndex = 4;
            this._btMax.Click += new System.EventHandler(this._btMax_Click);
            // 
            // _btClose
            // 
            this._btClose.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this._btClose.Appearance.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btClose.Appearance.Options.UseBackColor = true;
            this._btClose.Appearance.Options.UseFont = true;
            this._btClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this._btClose.Dock = System.Windows.Forms.DockStyle.Right;
            this._btClose.ImageOptions.Image = global::CoFAS_MES.CORE.Properties.Resources.close_16x16;
            this._btClose.Location = new System.Drawing.Point(797, 0);
            this._btClose.Margin = new System.Windows.Forms.Padding(0);
            this._btClose.Name = "_btClose";
            this._btClose.Size = new System.Drawing.Size(20, 20);
            this._btClose.TabIndex = 5;
            this._btClose.Click += new System.EventHandler(this._btClose_Click);
            // 
            // _lbMessage
            // 
            this._lbMessage.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this._lbMessage.Appearance.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Bold);
            this._lbMessage.Appearance.ForeColor = System.Drawing.Color.Black;
            this._lbMessage.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("_lbMessage.Appearance.Image")));
            this._lbMessage.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._lbMessage.Appearance.Options.UseBackColor = true;
            this._lbMessage.Appearance.Options.UseFont = true;
            this._lbMessage.Appearance.Options.UseForeColor = true;
            this._lbMessage.Appearance.Options.UseImage = true;
            this._lbMessage.Appearance.Options.UseImageAlign = true;
            this._lbMessage.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this._lbMessage.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._lbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbMessage.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this._lbMessage.Location = new System.Drawing.Point(0, 699);
            this._lbMessage.Margin = new System.Windows.Forms.Padding(0);
            this._lbMessage.Name = "_lbMessage";
            this._lbMessage.Padding = new System.Windows.Forms.Padding(5);
            this._lbMessage.Size = new System.Drawing.Size(817, 30);
            this._lbMessage.TabIndex = 0;
            this._lbMessage.Text = "Message 처리";
            // 
            // _pnBody
            // 
            this._pnBody.BackColor = System.Drawing.Color.Transparent;
            this._pnBody.Controls.Add(this._pnMain);
            this._pnBody.Controls.Add(this._pnRight);
            this._pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnBody.Location = new System.Drawing.Point(0, 100);
            this._pnBody.Margin = new System.Windows.Forms.Padding(0);
            this._pnBody.Name = "_pnBody";
            this._pnBody.Size = new System.Drawing.Size(817, 599);
            this._pnBody.TabIndex = 2;
            // 
            // _pnMain
            // 
            this._pnMain.BackColor = System.Drawing.Color.Transparent;
            this._pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnMain.Location = new System.Drawing.Point(0, 0);
            this._pnMain.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this._pnMain.Name = "_pnMain";
            this._pnMain.Size = new System.Drawing.Size(617, 599);
            this._pnMain.TabIndex = 1;
            // 
            // _pnRight
            // 
            this._pnRight.BackColor = System.Drawing.Color.Transparent;
            this._pnRight.Dock = System.Windows.Forms.DockStyle.Right;
            this._pnRight.Location = new System.Drawing.Point(617, 0);
            this._pnRight.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this._pnRight.Name = "_pnRight";
            this._pnRight.Size = new System.Drawing.Size(200, 599);
            this._pnRight.TabIndex = 0;
            // 
            // frmBasePOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(817, 729);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBasePOP";
            this.Text = "BaseForm";
            this.Load += new System.EventHandler(this.frm_Base_None_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._peCI.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this._pnBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.LabelControl _lbMessage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraEditors.LabelControl _lbStartName;
        private DevExpress.XtraEditors.LabelControl _lbCurrentName;
        private DevExpress.XtraEditors.LabelControl _lbStartTime;
        private DevExpress.XtraEditors.LabelControl _lbCurrentTime;
        private System.Windows.Forms.Panel _pnBody;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton _btMin;
        private DevExpress.XtraEditors.SimpleButton _btMax;
        private DevExpress.XtraEditors.SimpleButton _btClose;
        protected System.Windows.Forms.Panel _pnMain;
        protected System.Windows.Forms.Panel _pnRight;
        protected DevExpress.XtraEditors.LabelControl _lbTitle;
        protected DevExpress.XtraEditors.LabelControl _lbHeader;
        public DevExpress.XtraEditors.PictureEdit _peCI;
    }
}
namespace CoFAS_MES.POP
{
    partial class frmPOPExcel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOPExcel));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.spreadsheetControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.lc_0 = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ucTextEdit1 = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this.btnCmd10 = new DevExpress.XtraEditors.SimpleButton();
            this.btnCmd20 = new DevExpress.XtraEditors.SimpleButton();
            this.btnCmd30 = new DevExpress.XtraEditors.SimpleButton();
            this.spreadsheetControl2 = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort();
            ((System.ComponentModel.ISupportInitialize)(this._pnSINGLE_MAIN)).BeginInit();
            this._pnSINGLE_MAIN.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // _pnSINGLE_MAIN
            // 
            this._pnSINGLE_MAIN.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnSINGLE_MAIN.Appearance.BorderColor = System.Drawing.Color.Silver;
            this._pnSINGLE_MAIN.Appearance.Options.UseBackColor = true;
            this._pnSINGLE_MAIN.Appearance.Options.UseBorderColor = true;
            this._pnSINGLE_MAIN.Controls.Add(this.tableLayoutPanel1);
            this._pnSINGLE_MAIN.Size = new System.Drawing.Size(1162, 560);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.spreadsheetControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lc_0, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1162, 560);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // spreadsheetControl1
            // 
            this.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetControl1.Location = new System.Drawing.Point(3, 134);
            this.spreadsheetControl1.Name = "spreadsheetControl1";
            this.spreadsheetControl1.Options.Culture = new System.Globalization.CultureInfo("ko-KR");
            this.spreadsheetControl1.Options.Import.Csv.Encoding = ((System.Text.Encoding)(resources.GetObject("spreadsheetControl1.Options.Import.Csv.Encoding")));
            this.spreadsheetControl1.Options.Import.Txt.Encoding = ((System.Text.Encoding)(resources.GetObject("spreadsheetControl1.Options.Import.Txt.Encoding")));
            this.spreadsheetControl1.Size = new System.Drawing.Size(1156, 398);
            this.spreadsheetControl1.TabIndex = 29;
            this.spreadsheetControl1.Text = "spreadsheetControl1";
            this.spreadsheetControl1.CellValueChanged += new DevExpress.XtraSpreadsheet.CellValueChangedEventHandler(this.spreadsheetControl1_CellValueChanged);
            this.spreadsheetControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.spreadsheetControl1_KeyDown);
            // 
            // lc_0
            // 
            this.lc_0.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lc_0.Appearance.Image = global::CoFAS_MES.POP.Properties.Resources.plug_Gray;
            this.lc_0.Appearance.Options.UseFont = true;
            this.lc_0.Appearance.Options.UseImage = true;
            this.lc_0.Dock = System.Windows.Forms.DockStyle.Right;
            this.lc_0.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lc_0.Location = new System.Drawing.Point(1047, 535);
            this.lc_0.Margin = new System.Windows.Forms.Padding(0);
            this.lc_0.Name = "lc_0";
            this.lc_0.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lc_0.Size = new System.Drawing.Size(115, 28);
            this.lc_0.TabIndex = 31;
            this.lc_0.Text = "바코드스캐너";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Controls.Add(this.ucTextEdit1, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCmd10, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnCmd20, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnCmd30, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.spreadsheetControl2, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.pictureEdit1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1156, 127);
            this.tableLayoutPanel2.TabIndex = 28;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // ucTextEdit1
            // 
            this.ucTextEdit1.AutoSize = true;
            this.ucTextEdit1.CancelButton = null;
            this.ucTextEdit1.CommandButton = null;
            this.ucTextEdit1.EditMask = "";
            this.ucTextEdit1.Location = new System.Drawing.Point(0, 74);
            this.ucTextEdit1.Margin = new System.Windows.Forms.Padding(0);
            this.ucTextEdit1.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.ucTextEdit1.Name = "ucTextEdit1";
            this.ucTextEdit1.NumText = "";
            this.ucTextEdit1.PasswordChar = '\0';
            this.ucTextEdit1.ReadOnly = false;
            this.ucTextEdit1.Size = new System.Drawing.Size(0, 0);
            this.ucTextEdit1.TabIndex = 32;
            this.ucTextEdit1.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.ucTextEdit1.UseMaskAsDisplayFormat = false;
            // 
            // btnCmd10
            // 
            this.btnCmd10.Appearance.Font = new System.Drawing.Font("Verdana", 12F);
            this.btnCmd10.Appearance.Options.UseFont = true;
            this.btnCmd10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCmd10.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCmd10.Location = new System.Drawing.Point(3, 77);
            this.btnCmd10.Name = "btnCmd10";
            this.btnCmd10.Size = new System.Drawing.Size(186, 47);
            this.btnCmd10.TabIndex = 8;
            this.btnCmd10.Text = "BOM 파일 불러오기";
            this.btnCmd10.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // btnCmd20
            // 
            this.btnCmd20.Appearance.Font = new System.Drawing.Font("Verdana", 12F);
            this.btnCmd20.Appearance.Options.UseFont = true;
            this.btnCmd20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCmd20.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCmd20.Location = new System.Drawing.Point(195, 77);
            this.btnCmd20.Name = "btnCmd20";
            this.btnCmd20.Size = new System.Drawing.Size(186, 47);
            this.btnCmd20.TabIndex = 9;
            this.btnCmd20.Text = "저  장";
            this.btnCmd20.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // btnCmd30
            // 
            this.btnCmd30.Appearance.Font = new System.Drawing.Font("Verdana", 12F);
            this.btnCmd30.Appearance.Options.UseFont = true;
            this.btnCmd30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCmd30.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCmd30.Location = new System.Drawing.Point(387, 77);
            this.btnCmd30.Name = "btnCmd30";
            this.btnCmd30.Size = new System.Drawing.Size(186, 47);
            this.btnCmd30.TabIndex = 31;
            this.btnCmd30.Text = "이력 조회";
            this.btnCmd30.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // spreadsheetControl2
            // 
            this.spreadsheetControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetControl2.Location = new System.Drawing.Point(963, 77);
            this.spreadsheetControl2.Name = "spreadsheetControl2";
            this.spreadsheetControl2.Options.Culture = new System.Globalization.CultureInfo("ko-KR");
            this.spreadsheetControl2.Options.Import.Csv.Encoding = ((System.Text.Encoding)(resources.GetObject("spreadsheetControl2.Options.Import.Csv.Encoding")));
            this.spreadsheetControl2.Options.Import.Txt.Encoding = ((System.Text.Encoding)(resources.GetObject("spreadsheetControl2.Options.Import.Txt.Encoding")));
            this.spreadsheetControl2.Size = new System.Drawing.Size(190, 47);
            this.spreadsheetControl2.TabIndex = 30;
            this.spreadsheetControl2.Text = "spreadsheetControl2";
            this.spreadsheetControl2.Visible = false;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(3, 2);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(186, 70);
            this.pictureEdit1.TabIndex = 33;
            // 
            // label1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.label1, 5);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(195, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(958, 74);
            this.label1.TabIndex = 34;
            this.label1.Text = "칵핏 바코드 등록";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPOPExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Child_Page_Setting_Visible = true;
            this.ClientSize = new System.Drawing.Size(1162, 600);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPOPExcel";
            this.Text = "frmPOPExcel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this._pnSINGLE_MAIN)).EndInit();
            this._pnSINGLE_MAIN.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraSpreadsheet.SpreadsheetControl spreadsheetControl1;
        private DevExpress.XtraEditors.SimpleButton btnCmd20;
        private DevExpress.XtraEditors.SimpleButton btnCmd10;
        private DevExpress.XtraSpreadsheet.SpreadsheetControl spreadsheetControl2;
        private DevExpress.XtraEditors.LabelControl lc_0;
        private DevExpress.XtraEditors.SimpleButton btnCmd30;
        private System.IO.Ports.SerialPort serialPort1;
        private CORE.BaseControls.ucTextEdit ucTextEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.Label label1;
    }
}
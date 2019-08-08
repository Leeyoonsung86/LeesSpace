namespace CoFAS_MES.POP
{
    partial class frmPOPLabelPrint
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCmd10 = new DevExpress.XtraEditors.SimpleButton();
            this.btnCmd20 = new DevExpress.XtraEditors.SimpleButton();
            this.btnCmd30 = new DevExpress.XtraEditors.SimpleButton();
            this.btnCmd40 = new DevExpress.XtraEditors.SimpleButton();
            this.btnCmd50 = new DevExpress.XtraEditors.SimpleButton();
            this._gdMAIN = new DevExpress.XtraGrid.GridControl();
            this._gdMAIN_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this._luTPART_CODE = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luTPART_NAME = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luTSEQ = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this._pnSINGLE_MAIN)).BeginInit();
            this._pnSINGLE_MAIN.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.Controls.Add(this.btnCmd10, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCmd20, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCmd30, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCmd40, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnCmd50, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this._gdMAIN, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1162, 560);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnCmd10
            // 
            this.btnCmd10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCmd10.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources.AUp_64x;
            this.btnCmd10.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCmd10.Location = new System.Drawing.Point(1045, 3);
            this.btnCmd10.Name = "btnCmd10";
            this.btnCmd10.Size = new System.Drawing.Size(114, 78);
            this.btnCmd10.TabIndex = 0;
            this.btnCmd10.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // btnCmd20
            // 
            this.btnCmd20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCmd20.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources.Up_64x;
            this.btnCmd20.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCmd20.Location = new System.Drawing.Point(1045, 87);
            this.btnCmd20.Name = "btnCmd20";
            this.btnCmd20.Size = new System.Drawing.Size(114, 78);
            this.btnCmd20.TabIndex = 1;
            this.btnCmd20.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // btnCmd30
            // 
            this.btnCmd30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCmd30.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources.Select_64x;
            this.btnCmd30.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCmd30.Location = new System.Drawing.Point(1045, 171);
            this.btnCmd30.Name = "btnCmd30";
            this.btnCmd30.Size = new System.Drawing.Size(114, 78);
            this.btnCmd30.TabIndex = 2;
            this.btnCmd30.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // btnCmd40
            // 
            this.btnCmd40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCmd40.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources.Down_64x;
            this.btnCmd40.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.btnCmd40.Location = new System.Drawing.Point(1045, 255);
            this.btnCmd40.Name = "btnCmd40";
            this.btnCmd40.Size = new System.Drawing.Size(114, 78);
            this.btnCmd40.TabIndex = 3;
            this.btnCmd40.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // btnCmd50
            // 
            this.btnCmd50.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCmd50.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources.ADown_64x;
            this.btnCmd50.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.btnCmd50.Location = new System.Drawing.Point(1045, 339);
            this.btnCmd50.Name = "btnCmd50";
            this.btnCmd50.Size = new System.Drawing.Size(114, 78);
            this.btnCmd50.TabIndex = 4;
            this.btnCmd50.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // _gdMAIN
            // 
            this._gdMAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gdMAIN.Location = new System.Drawing.Point(0, 0);
            this._gdMAIN.MainView = this._gdMAIN_VIEW;
            this._gdMAIN.Margin = new System.Windows.Forms.Padding(0);
            this._gdMAIN.Name = "_gdMAIN";
            this.tableLayoutPanel1.SetRowSpan(this._gdMAIN, 5);
            this._gdMAIN.Size = new System.Drawing.Size(1042, 420);
            this._gdMAIN.TabIndex = 5;
            this._gdMAIN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gdMAIN_VIEW});
            // 
            // _gdMAIN_VIEW
            // 
            this._gdMAIN_VIEW.GridControl = this._gdMAIN;
            this._gdMAIN_VIEW.Name = "_gdMAIN_VIEW";
            this._gdMAIN_VIEW.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            this._gdMAIN_VIEW.OptionsView.RowAutoHeight = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.labelControl1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelControl2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelControl3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this._luTPART_CODE, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this._luTPART_NAME, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this._luTSEQ, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 423);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1156, 134);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 33F);
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(234, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(687, 61);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "품목명";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 33F);
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl2.Location = new System.Drawing.Point(3, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(225, 61);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "품목코드";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 33F);
            this.labelControl3.Appearance.Options.UseBackColor = true;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl3.Location = new System.Drawing.Point(927, 3);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(226, 61);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "발행수량";
            // 
            // _luTPART_CODE
            // 
            this._luTPART_CODE.AutoSize = true;
            this._luTPART_CODE.CancelButton = null;
            this._luTPART_CODE.CommandButton = null;
            this._luTPART_CODE.Dock = System.Windows.Forms.DockStyle.Fill;
            this._luTPART_CODE.EditMask = "";
            this._luTPART_CODE.Location = new System.Drawing.Point(0, 67);
            this._luTPART_CODE.Margin = new System.Windows.Forms.Padding(0);
            this._luTPART_CODE.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luTPART_CODE.Name = "_luTPART_CODE";
            this._luTPART_CODE.NumText = "";
            this._luTPART_CODE.PasswordChar = '\0';
            this._luTPART_CODE.ReadOnly = false;
            this._luTPART_CODE.Size = new System.Drawing.Size(231, 67);
            this._luTPART_CODE.TabIndex = 3;
            this._luTPART_CODE.TextAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._luTPART_CODE.UseMaskAsDisplayFormat = false;
            // 
            // _luTPART_NAME
            // 
            this._luTPART_NAME.AutoSize = true;
            this._luTPART_NAME.CancelButton = null;
            this._luTPART_NAME.CommandButton = null;
            this._luTPART_NAME.Dock = System.Windows.Forms.DockStyle.Fill;
            this._luTPART_NAME.EditMask = "";
            this._luTPART_NAME.Location = new System.Drawing.Point(231, 67);
            this._luTPART_NAME.Margin = new System.Windows.Forms.Padding(0);
            this._luTPART_NAME.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luTPART_NAME.Name = "_luTPART_NAME";
            this._luTPART_NAME.NumText = "";
            this._luTPART_NAME.PasswordChar = '\0';
            this._luTPART_NAME.ReadOnly = false;
            this._luTPART_NAME.Size = new System.Drawing.Size(693, 67);
            this._luTPART_NAME.TabIndex = 4;
            this._luTPART_NAME.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            this._luTPART_NAME.UseMaskAsDisplayFormat = false;
            // 
            // _luTSEQ
            // 
            this._luTSEQ.Appearance.BackColor = System.Drawing.Color.Azure;
            this._luTSEQ.Appearance.Font = new System.Drawing.Font("Tahoma", 55F);
            this._luTSEQ.Appearance.Options.UseBackColor = true;
            this._luTSEQ.Appearance.Options.UseFont = true;
            this._luTSEQ.Dock = System.Windows.Forms.DockStyle.Fill;
            this._luTSEQ.Location = new System.Drawing.Point(927, 70);
            this._luTSEQ.Name = "_luTSEQ";
            this._luTSEQ.Size = new System.Drawing.Size(226, 61);
            this._luTSEQ.TabIndex = 5;
            this._luTSEQ.Text = "1";
            this._luTSEQ.Click += new System.EventHandler(this._luTSEQ_Click);
            // 
            // frmPOPLabelPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Child_Page_Setting_Visible = true;
            this.ClientSize = new System.Drawing.Size(1162, 600);
            this.Name = "frmPOPLabelPrint";
            this.Text = "frmPOPLabelPrint";
            ((System.ComponentModel.ISupportInitialize)(this._pnSINGLE_MAIN)).EndInit();
            this._pnSINGLE_MAIN.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btnCmd10;
        private DevExpress.XtraEditors.SimpleButton btnCmd20;
        private DevExpress.XtraEditors.SimpleButton btnCmd30;
        private DevExpress.XtraEditors.SimpleButton btnCmd40;
        private DevExpress.XtraEditors.SimpleButton btnCmd50;
        private DevExpress.XtraGrid.GridControl _gdMAIN;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdMAIN_VIEW;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private CORE.BaseControls.ucTextEdit _luTPART_CODE;
        private CORE.BaseControls.ucTextEdit _luTPART_NAME;
        private DevExpress.XtraEditors.LabelControl _luTSEQ;
    }
}
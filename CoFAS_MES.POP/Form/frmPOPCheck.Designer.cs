namespace CoFAS_MES.POP
{
    partial class frmPOPCheck
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
            this._gdMAIN = new DevExpress.XtraGrid.GridControl();
            this._gdMAIN_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._luTCHECK_LIST = new CoFAS_MES.CORE.BaseControls.ucLookUpEdit();
            this._ucbtCANCEL = new DevExpress.XtraEditors.SimpleButton();
            this._ucbtSAVE = new DevExpress.XtraEditors.SimpleButton();
            this.btnCmd10 = new DevExpress.XtraEditors.SimpleButton();
            this.btnCmd20 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this._pnSINGLE_MAIN)).BeginInit();
            this._pnSINGLE_MAIN.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).BeginInit();
            this.SuspendLayout();
            // 
            // _pnSINGLE_MAIN
            // 
            this._pnSINGLE_MAIN.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnSINGLE_MAIN.Appearance.BorderColor = System.Drawing.Color.Silver;
            this._pnSINGLE_MAIN.Appearance.Options.UseBackColor = true;
            this._pnSINGLE_MAIN.Appearance.Options.UseBorderColor = true;
            this._pnSINGLE_MAIN.Controls.Add(this.tableLayoutPanel1);
            this._pnSINGLE_MAIN.Size = new System.Drawing.Size(1280, 984);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this._gdMAIN, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._luTCHECK_LIST, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._ucbtCANCEL, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this._ucbtSAVE, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnCmd10, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnCmd20, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.32683F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.93254F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.93254F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.93254F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.93254F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.94301F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1280, 984);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _gdMAIN
            // 
            this._gdMAIN.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.tableLayoutPanel1.SetColumnSpan(this._gdMAIN, 4);
            this._gdMAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gdMAIN.Location = new System.Drawing.Point(0, 131);
            this._gdMAIN.MainView = this._gdMAIN_VIEW;
            this._gdMAIN.Margin = new System.Windows.Forms.Padding(0);
            this._gdMAIN.Name = "_gdMAIN";
            this.tableLayoutPanel1.SetRowSpan(this._gdMAIN, 4);
            this._gdMAIN.Size = new System.Drawing.Size(1280, 744);
            this._gdMAIN.TabIndex = 5;
            this._gdMAIN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gdMAIN_VIEW});
            // 
            // _gdMAIN_VIEW
            // 
            this._gdMAIN_VIEW.GridControl = this._gdMAIN;
            this._gdMAIN_VIEW.Name = "_gdMAIN_VIEW";
            this._gdMAIN_VIEW.OptionsBehavior.Editable = false;
            this._gdMAIN_VIEW.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            // 
            // _luTCHECK_LIST
            // 
            this._luTCHECK_LIST.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this._luTCHECK_LIST, 4);
            this._luTCHECK_LIST.Dock = System.Windows.Forms.DockStyle.Fill;
            this._luTCHECK_LIST.ItemIndex = -1;
            this._luTCHECK_LIST.Location = new System.Drawing.Point(0, 0);
            this._luTCHECK_LIST.Margin = new System.Windows.Forms.Padding(0);
            this._luTCHECK_LIST.Name = "_luTCHECK_LIST";
            this._luTCHECK_LIST.ReadOnly = false;
            this._luTCHECK_LIST.Size = new System.Drawing.Size(1280, 131);
            this._luTCHECK_LIST.TabIndex = 8;
            // 
            // _ucbtCANCEL
            // 
            this._ucbtCANCEL.Appearance.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ucbtCANCEL.Appearance.Options.UseFont = true;
            this._ucbtCANCEL.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ucbtCANCEL.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources._1403074860_onebit_33;
            this._ucbtCANCEL.Location = new System.Drawing.Point(963, 878);
            this._ucbtCANCEL.Name = "_ucbtCANCEL";
            this._ucbtCANCEL.Size = new System.Drawing.Size(314, 103);
            this._ucbtCANCEL.TabIndex = 7;
            this._ucbtCANCEL.Text = "닫기";
            this._ucbtCANCEL.Click += new System.EventHandler(this._ucbtCANCEL_Click);
            // 
            // _ucbtSAVE
            // 
            this._ucbtSAVE.Appearance.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold);
            this._ucbtSAVE.Appearance.Options.UseFont = true;
            this._ucbtSAVE.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ucbtSAVE.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources.Down_64x;
            this._ucbtSAVE.Location = new System.Drawing.Point(643, 878);
            this._ucbtSAVE.Name = "_ucbtSAVE";
            this._ucbtSAVE.Size = new System.Drawing.Size(314, 103);
            this._ucbtSAVE.TabIndex = 6;
            this._ucbtSAVE.Text = "저장";
            this._ucbtSAVE.Click += new System.EventHandler(this._ucbtSAVE_Click);
            // 
            // btnCmd10
            // 
            this.btnCmd10.Appearance.Font = new System.Drawing.Font("Tahoma", 36F);
            this.btnCmd10.Appearance.Options.UseFont = true;
            this.btnCmd10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCmd10.Location = new System.Drawing.Point(3, 878);
            this.btnCmd10.Name = "btnCmd10";
            this.btnCmd10.Size = new System.Drawing.Size(314, 103);
            this.btnCmd10.TabIndex = 9;
            this.btnCmd10.Text = "UP";
            this.btnCmd10.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // btnCmd20
            // 
            this.btnCmd20.Appearance.Font = new System.Drawing.Font("Tahoma", 36F);
            this.btnCmd20.Appearance.Options.UseFont = true;
            this.btnCmd20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCmd20.Location = new System.Drawing.Point(323, 878);
            this.btnCmd20.Name = "btnCmd20";
            this.btnCmd20.Size = new System.Drawing.Size(314, 103);
            this.btnCmd20.TabIndex = 10;
            this.btnCmd20.Text = "DOWN";
            this.btnCmd20.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // frmPOPCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Child_Page_Setting_Visible = true;
            this.ClientSize = new System.Drawing.Size(1280, 1024);
            this.Name = "frmPOPCheck";
            this.Text = "frmPOPOrder_T01";
            ((System.ComponentModel.ISupportInitialize)(this._pnSINGLE_MAIN)).EndInit();
            this._pnSINGLE_MAIN.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl _gdMAIN;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdMAIN_VIEW;
        private DevExpress.XtraEditors.SimpleButton _ucbtSAVE;
        private DevExpress.XtraEditors.SimpleButton _ucbtCANCEL;
        private CORE.BaseControls.ucLookUpEdit _luTCHECK_LIST;
        private DevExpress.XtraEditors.SimpleButton btnCmd10;
        private DevExpress.XtraEditors.SimpleButton btnCmd20;
    }
}
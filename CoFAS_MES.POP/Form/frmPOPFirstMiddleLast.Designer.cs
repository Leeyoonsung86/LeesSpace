namespace CoFAS_MES.POP
{
    partial class frmPOPFirstMiddleLast
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
            this._luFIRSTMIDDLELAST_GUBN = new CoFAS_MES.CORE.BaseControls.ucLookUpEdit();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btncmd50 = new DevExpress.XtraEditors.SimpleButton();
            this.btncmd10 = new DevExpress.XtraEditors.SimpleButton();
            this._ucbtSAVE = new DevExpress.XtraEditors.SimpleButton();
            this._ucbtCANCEL = new DevExpress.XtraEditors.SimpleButton();
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
            this._pnSINGLE_MAIN.Size = new System.Drawing.Size(1280, 984);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this._gdMAIN, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._luFIRSTMIDDLELAST_GUBN, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.58977F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.04913F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.04913F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.04913F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.04913F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.213721F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1280, 984);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _gdMAIN
            // 
            this._gdMAIN.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.tableLayoutPanel1.SetColumnSpan(this._gdMAIN, 3);
            this._gdMAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gdMAIN.Location = new System.Drawing.Point(0, 104);
            this._gdMAIN.MainView = this._gdMAIN_VIEW;
            this._gdMAIN.Margin = new System.Windows.Forms.Padding(0);
            this._gdMAIN.Name = "_gdMAIN";
            this.tableLayoutPanel1.SetRowSpan(this._gdMAIN, 4);
            this._gdMAIN.Size = new System.Drawing.Size(1280, 788);
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
            // _luFIRSTMIDDLELAST_GUBN
            // 
            this._luFIRSTMIDDLELAST_GUBN.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this._luFIRSTMIDDLELAST_GUBN, 3);
            this._luFIRSTMIDDLELAST_GUBN.Dock = System.Windows.Forms.DockStyle.Fill;
            this._luFIRSTMIDDLELAST_GUBN.ItemIndex = -1;
            this._luFIRSTMIDDLELAST_GUBN.Location = new System.Drawing.Point(0, 0);
            this._luFIRSTMIDDLELAST_GUBN.Margin = new System.Windows.Forms.Padding(0);
            this._luFIRSTMIDDLELAST_GUBN.Name = "_luFIRSTMIDDLELAST_GUBN";
            this._luFIRSTMIDDLELAST_GUBN.ReadOnly = false;
            this._luFIRSTMIDDLELAST_GUBN.Size = new System.Drawing.Size(1280, 104);
            this._luFIRSTMIDDLELAST_GUBN.TabIndex = 8;
            this._luFIRSTMIDDLELAST_GUBN.ValueChanged += new System.EventHandler(this._luFIRSTMIDDLELAST_GUBN_ValueChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 3);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.btncmd50, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btncmd10, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this._ucbtSAVE, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this._ucbtCANCEL, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 895);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1274, 86);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // btncmd50
            // 
            this.btncmd50.Appearance.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold);
            this.btncmd50.Appearance.Options.UseFont = true;
            this.btncmd50.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btncmd50.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources.ADown_64x;
            this.btncmd50.Location = new System.Drawing.Point(321, 3);
            this.btncmd50.Name = "btncmd50";
            this.btncmd50.Size = new System.Drawing.Size(312, 80);
            this.btncmd50.TabIndex = 9;
            this.btncmd50.Text = "DOWN";
            this.btncmd50.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // btncmd10
            // 
            this.btncmd10.Appearance.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold);
            this.btncmd10.Appearance.Options.UseFont = true;
            this.btncmd10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btncmd10.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources.AUp_64x;
            this.btncmd10.Location = new System.Drawing.Point(3, 3);
            this.btncmd10.Name = "btncmd10";
            this.btncmd10.Size = new System.Drawing.Size(312, 80);
            this.btncmd10.TabIndex = 8;
            this.btncmd10.Text = "UP";
            this.btncmd10.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // _ucbtSAVE
            // 
            this._ucbtSAVE.Appearance.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold);
            this._ucbtSAVE.Appearance.Options.UseFont = true;
            this._ucbtSAVE.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ucbtSAVE.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources._48x_1403087969_Gnome_Document_Save_64;
            this._ucbtSAVE.Location = new System.Drawing.Point(639, 3);
            this._ucbtSAVE.Name = "_ucbtSAVE";
            this._ucbtSAVE.Size = new System.Drawing.Size(312, 80);
            this._ucbtSAVE.TabIndex = 6;
            this._ucbtSAVE.Text = "저장";
            this._ucbtSAVE.Click += new System.EventHandler(this._ucbtSAVE_Click);
            // 
            // _ucbtCANCEL
            // 
            this._ucbtCANCEL.Appearance.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ucbtCANCEL.Appearance.Options.UseFont = true;
            this._ucbtCANCEL.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ucbtCANCEL.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources._1403074860_onebit_33;
            this._ucbtCANCEL.Location = new System.Drawing.Point(957, 3);
            this._ucbtCANCEL.Name = "_ucbtCANCEL";
            this._ucbtCANCEL.Size = new System.Drawing.Size(314, 80);
            this._ucbtCANCEL.TabIndex = 7;
            this._ucbtCANCEL.Text = "닫기";
            this._ucbtCANCEL.Click += new System.EventHandler(this._ucbtCANCEL_Click);
            // 
            // frmPOPFirstMiddleLast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Child_Page_Setting_Visible = true;
            this.ClientSize = new System.Drawing.Size(1280, 1024);
            this.Name = "frmPOPFirstMiddleLast";
            this.Text = "frmPOPOrder_T01";
            ((System.ComponentModel.ISupportInitialize)(this._pnSINGLE_MAIN)).EndInit();
            this._pnSINGLE_MAIN.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl _gdMAIN;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdMAIN_VIEW;
        private DevExpress.XtraEditors.SimpleButton _ucbtSAVE;
        private DevExpress.XtraEditors.SimpleButton _ucbtCANCEL;
        private CORE.BaseControls.ucLookUpEdit _luFIRSTMIDDLELAST_GUBN;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton btncmd50;
        private DevExpress.XtraEditors.SimpleButton btncmd10;
    }
}
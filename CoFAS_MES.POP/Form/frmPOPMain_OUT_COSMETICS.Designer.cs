namespace CoFAS_MES.POP
{
    partial class frmPOPMain_OUT_COSMETICS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOPMain_OUT_COSMETICS));
            this.pnlDeviceConnect = new System.Windows.Forms.Panel();
            this.tlpButton = new System.Windows.Forms.TableLayoutPanel();
            this._ucbtMATERIAL_ORDER = new DevExpress.XtraEditors.SimpleButton();
            this._ucbtIN_REG = new DevExpress.XtraEditors.SimpleButton();
            this._ucbtKEYPAD = new DevExpress.XtraEditors.SimpleButton();
            this.tlpPOPMain = new System.Windows.Forms.TableLayoutPanel();
            this._gdMAIN = new DevExpress.XtraGrid.GridControl();
            this._gdMAIN_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._ucbtPART_STOCK = new DevExpress.XtraEditors.SimpleButton();
            this._pnMain.SuspendLayout();
            this.tlpButton.SuspendLayout();
            this.tlpPOPMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).BeginInit();
            this.SuspendLayout();
            // 
            // _pnMain
            // 
            this._pnMain.Controls.Add(this.tlpPOPMain);
            this._pnMain.Size = new System.Drawing.Size(1024, 599);
            // 
            // _pnRight
            // 
            this._pnRight.Location = new System.Drawing.Point(1024, 0);
            this._pnRight.Size = new System.Drawing.Size(0, 599);
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
            this._lbHeader.Size = new System.Drawing.Size(964, 20);
            // 
            // pnlDeviceConnect
            // 
            this.pnlDeviceConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDeviceConnect.Location = new System.Drawing.Point(0, 569);
            this.pnlDeviceConnect.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDeviceConnect.Name = "pnlDeviceConnect";
            this.pnlDeviceConnect.Size = new System.Drawing.Size(1024, 30);
            this.pnlDeviceConnect.TabIndex = 2;
            // 
            // tlpButton
            // 
            this.tlpButton.ColumnCount = 5;
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpButton.Controls.Add(this._ucbtMATERIAL_ORDER, 0, 0);
            this.tlpButton.Controls.Add(this._ucbtIN_REG, 1, 0);
            this.tlpButton.Controls.Add(this._ucbtKEYPAD, 4, 0);
            this.tlpButton.Controls.Add(this._ucbtPART_STOCK, 3, 0);
            this.tlpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButton.Location = new System.Drawing.Point(0, 494);
            this.tlpButton.Margin = new System.Windows.Forms.Padding(0);
            this.tlpButton.Name = "tlpButton";
            this.tlpButton.RowCount = 1;
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpButton.Size = new System.Drawing.Size(1024, 75);
            this.tlpButton.TabIndex = 0;
            // 
            // _ucbtMATERIAL_ORDER
            // 
            this._ucbtMATERIAL_ORDER.Appearance.Font = new System.Drawing.Font("굴림체", 15.75F, System.Drawing.FontStyle.Bold);
            this._ucbtMATERIAL_ORDER.Appearance.Options.UseFont = true;
            this._ucbtMATERIAL_ORDER.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ucbtMATERIAL_ORDER.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources._48x_System;
            this._ucbtMATERIAL_ORDER.Location = new System.Drawing.Point(3, 3);
            this._ucbtMATERIAL_ORDER.Name = "_ucbtMATERIAL_ORDER";
            this._ucbtMATERIAL_ORDER.Size = new System.Drawing.Size(198, 69);
            this._ucbtMATERIAL_ORDER.TabIndex = 4;
            this._ucbtMATERIAL_ORDER.Text = "출하지시조회";
            this._ucbtMATERIAL_ORDER.Click += new System.EventHandler(this._ucbtMATERIAL_ORDER_Click);
            // 
            // _ucbtIN_REG
            // 
            this._ucbtIN_REG.Appearance.Font = new System.Drawing.Font("굴림체", 15.75F, System.Drawing.FontStyle.Bold);
            this._ucbtIN_REG.Appearance.Options.UseFont = true;
            this._ucbtIN_REG.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ucbtIN_REG.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources._48x_ProductAdd;
            this._ucbtIN_REG.Location = new System.Drawing.Point(207, 3);
            this._ucbtIN_REG.Name = "_ucbtIN_REG";
            this._ucbtIN_REG.Size = new System.Drawing.Size(198, 69);
            this._ucbtIN_REG.TabIndex = 0;
            this._ucbtIN_REG.Text = "제품출고";
            this._ucbtIN_REG.Click += new System.EventHandler(this._ucbtIN_REG_Click);
            // 
            // _ucbtKEYPAD
            // 
            this._ucbtKEYPAD.Appearance.Font = new System.Drawing.Font("굴림체", 15.75F, System.Drawing.FontStyle.Bold);
            this._ucbtKEYPAD.Appearance.Options.UseFont = true;
            this._ucbtKEYPAD.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ucbtKEYPAD.Location = new System.Drawing.Point(819, 3);
            this._ucbtKEYPAD.Name = "_ucbtKEYPAD";
            this._ucbtKEYPAD.Size = new System.Drawing.Size(202, 69);
            this._ucbtKEYPAD.TabIndex = 7;
            this._ucbtKEYPAD.Text = "키패드";
            this._ucbtKEYPAD.Click += new System.EventHandler(this._ucbtKEYPAD_Click);
            // 
            // tlpPOPMain
            // 
            this.tlpPOPMain.ColumnCount = 1;
            this.tlpPOPMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPOPMain.Controls.Add(this.tlpButton, 0, 1);
            this.tlpPOPMain.Controls.Add(this.pnlDeviceConnect, 0, 2);
            this.tlpPOPMain.Controls.Add(this._gdMAIN, 0, 0);
            this.tlpPOPMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPOPMain.Location = new System.Drawing.Point(0, 0);
            this.tlpPOPMain.Name = "tlpPOPMain";
            this.tlpPOPMain.RowCount = 3;
            this.tlpPOPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPOPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpPOPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPOPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPOPMain.Size = new System.Drawing.Size(1024, 599);
            this.tlpPOPMain.TabIndex = 0;
            // 
            // _gdMAIN
            // 
            this._gdMAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gdMAIN.Location = new System.Drawing.Point(3, 3);
            this._gdMAIN.MainView = this._gdMAIN_VIEW;
            this._gdMAIN.Name = "_gdMAIN";
            this._gdMAIN.Size = new System.Drawing.Size(1018, 488);
            this._gdMAIN.TabIndex = 3;
            this._gdMAIN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gdMAIN_VIEW});
            // 
            // _gdMAIN_VIEW
            // 
            this._gdMAIN_VIEW.GridControl = this._gdMAIN;
            this._gdMAIN_VIEW.Name = "_gdMAIN_VIEW";
            // 
            // _ucbtPART_STOCK
            // 
            this._ucbtPART_STOCK.Appearance.Font = new System.Drawing.Font("굴림체", 15.75F, System.Drawing.FontStyle.Bold);
            this._ucbtPART_STOCK.Appearance.Options.UseFont = true;
            this._ucbtPART_STOCK.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ucbtPART_STOCK.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources._48x_ProductAdd;
            this._ucbtPART_STOCK.Location = new System.Drawing.Point(615, 3);
            this._ucbtPART_STOCK.Name = "_ucbtPART_STOCK";
            this._ucbtPART_STOCK.Size = new System.Drawing.Size(198, 69);
            this._ucbtPART_STOCK.TabIndex = 9;
            this._ucbtPART_STOCK.Text = "원료재고확인";
            this._ucbtPART_STOCK.Click += new System.EventHandler(this._ucbtPART_STOCK_Click);
            // 
            // frmPOPMain_OUT_COSMETICS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 729);
            this.Name = "frmPOPMain_OUT_COSMETICS";
            this.Text = "frmPOPMain_OUT_COSMETICS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this._pnMain.ResumeLayout(false);
            this.tlpButton.ResumeLayout(false);
            this.tlpPOPMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPOPMain;
        private System.Windows.Forms.TableLayoutPanel tlpButton;
        private DevExpress.XtraEditors.SimpleButton _ucbtMATERIAL_ORDER;
        private DevExpress.XtraEditors.SimpleButton _ucbtIN_REG;
        private System.Windows.Forms.Panel pnlDeviceConnect;
        private DevExpress.XtraGrid.GridControl _gdMAIN;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdMAIN_VIEW;
        private DevExpress.XtraEditors.SimpleButton _ucbtKEYPAD;
        private DevExpress.XtraEditors.SimpleButton _ucbtPART_STOCK;
    }
}
namespace CoFAS_MES.POP
{
    partial class frmPOPMain_WEIGHING_COSMETICS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOPMain_WEIGHING_COSMETICS));
            this.tlpPOPMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpDown = new System.Windows.Forms.TableLayoutPanel();
            this._gdSUB = new DevExpress.XtraGrid.GridControl();
            this._gdSUB_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._gdMAIN = new DevExpress.XtraGrid.GridControl();
            this._gdMAIN_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tlpButton = new System.Windows.Forms.TableLayoutPanel();
            this._ucbtINSPECT_REG = new DevExpress.XtraEditors.SimpleButton();
            this._ucbtWORK_ORDER = new DevExpress.XtraEditors.SimpleButton();
            this._ucbtOUT_REG = new DevExpress.XtraEditors.SimpleButton();
            this._ucbtORDERDOC_REG = new DevExpress.XtraEditors.SimpleButton();
            this._ucbtKEYPAD = new DevExpress.XtraEditors.SimpleButton();
            this._ucbtPART_STOCK = new DevExpress.XtraEditors.SimpleButton();
            this.pnlDeviceConnect = new System.Windows.Forms.Panel();
            this.tlpUp = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this._lciTPART_NAME = new DevExpress.XtraEditors.LabelControl();
            this._luPART_NAME = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this._lciTPART_CODE = new DevExpress.XtraEditors.LabelControl();
            this._luPART_CODE = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this._lciTPRODUCTION_ORDER_DATE = new DevExpress.XtraEditors.LabelControl();
            this._luORDER_DATE = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this._lciTPRODUCTION_ORDER_QTY = new DevExpress.XtraEditors.LabelControl();
            this._luORDER_QTY = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this._lciTPRODUCTION_ORDER_INFO = new DevExpress.XtraEditors.LabelControl();
            this._pnMain.SuspendLayout();
            this.tlpPOPMain.SuspendLayout();
            this.tlpDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).BeginInit();
            this.tlpButton.SuspendLayout();
            this.tlpUp.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
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
            this._lbHeader.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this._lbHeader.Size = new System.Drawing.Size(964, 20);
            // 
            // tlpPOPMain
            // 
            this.tlpPOPMain.ColumnCount = 1;
            this.tlpPOPMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPOPMain.Controls.Add(this.tlpDown, 0, 1);
            this.tlpPOPMain.Controls.Add(this.tlpButton, 0, 2);
            this.tlpPOPMain.Controls.Add(this.pnlDeviceConnect, 0, 3);
            this.tlpPOPMain.Controls.Add(this.tlpUp, 0, 0);
            this.tlpPOPMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPOPMain.Location = new System.Drawing.Point(0, 0);
            this.tlpPOPMain.Name = "tlpPOPMain";
            this.tlpPOPMain.RowCount = 4;
            this.tlpPOPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.643F));
            this.tlpPOPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.35699F));
            this.tlpPOPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpPOPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPOPMain.Size = new System.Drawing.Size(1024, 599);
            this.tlpPOPMain.TabIndex = 0;
            // 
            // tlpDown
            // 
            this.tlpDown.ColumnCount = 2;
            this.tlpDown.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDown.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 383F));
            this.tlpDown.Controls.Add(this._gdSUB, 0, 0);
            this.tlpDown.Controls.Add(this._gdMAIN, 0, 0);
            this.tlpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDown.Location = new System.Drawing.Point(0, 156);
            this.tlpDown.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDown.Name = "tlpDown";
            this.tlpDown.RowCount = 1;
            this.tlpDown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 439F));
            this.tlpDown.Size = new System.Drawing.Size(1024, 337);
            this.tlpDown.TabIndex = 4;
            // 
            // _gdSUB
            // 
            this._gdSUB.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gdSUB.Location = new System.Drawing.Point(644, 3);
            this._gdSUB.MainView = this._gdSUB_VIEW;
            this._gdSUB.Name = "_gdSUB";
            this._gdSUB.Size = new System.Drawing.Size(377, 433);
            this._gdSUB.TabIndex = 1;
            this._gdSUB.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gdSUB_VIEW});
            // 
            // _gdSUB_VIEW
            // 
            this._gdSUB_VIEW.GridControl = this._gdSUB;
            this._gdSUB_VIEW.Name = "_gdSUB_VIEW";
            this._gdSUB_VIEW.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this._gdSUB_VIEW_CellValueChanged);
            // 
            // _gdMAIN
            // 
            this._gdMAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gdMAIN.Location = new System.Drawing.Point(3, 3);
            this._gdMAIN.MainView = this._gdMAIN_VIEW;
            this._gdMAIN.Name = "_gdMAIN";
            this._gdMAIN.Size = new System.Drawing.Size(635, 433);
            this._gdMAIN.TabIndex = 0;
            this._gdMAIN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gdMAIN_VIEW});
            // 
            // _gdMAIN_VIEW
            // 
            this._gdMAIN_VIEW.GridControl = this._gdMAIN;
            this._gdMAIN_VIEW.Name = "_gdMAIN_VIEW";
            // 
            // tlpButton
            // 
            this.tlpButton.ColumnCount = 6;
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.666F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.666F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.666F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.666F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66933F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpButton.Controls.Add(this._ucbtINSPECT_REG, 0, 0);
            this.tlpButton.Controls.Add(this._ucbtWORK_ORDER, 0, 0);
            this.tlpButton.Controls.Add(this._ucbtOUT_REG, 1, 0);
            this.tlpButton.Controls.Add(this._ucbtORDERDOC_REG, 2, 0);
            this.tlpButton.Controls.Add(this._ucbtKEYPAD, 5, 0);
            this.tlpButton.Controls.Add(this._ucbtPART_STOCK, 4, 0);
            this.tlpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButton.Location = new System.Drawing.Point(0, 493);
            this.tlpButton.Margin = new System.Windows.Forms.Padding(0);
            this.tlpButton.Name = "tlpButton";
            this.tlpButton.RowCount = 1;
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButton.Size = new System.Drawing.Size(1024, 75);
            this.tlpButton.TabIndex = 0;
            // 
            // _ucbtINSPECT_REG
            // 
            this._ucbtINSPECT_REG.Appearance.Font = new System.Drawing.Font("굴림체", 15.75F, System.Drawing.FontStyle.Bold);
            this._ucbtINSPECT_REG.Appearance.Options.UseFont = true;
            this._ucbtINSPECT_REG.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ucbtINSPECT_REG.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources.request_48x48;
            this._ucbtINSPECT_REG.Location = new System.Drawing.Point(173, 3);
            this._ucbtINSPECT_REG.Name = "_ucbtINSPECT_REG";
            this._ucbtINSPECT_REG.Size = new System.Drawing.Size(164, 69);
            this._ucbtINSPECT_REG.TabIndex = 10;
            this._ucbtINSPECT_REG.Text = "검사의뢰";
            this._ucbtINSPECT_REG.Visible = false;
            this._ucbtINSPECT_REG.Click += new System.EventHandler(this._ucbtINSPECT_REG_Click);
            // 
            // _ucbtWORK_ORDER
            // 
            this._ucbtWORK_ORDER.Appearance.Font = new System.Drawing.Font("굴림체", 15.75F, System.Drawing.FontStyle.Bold);
            this._ucbtWORK_ORDER.Appearance.Options.UseFont = true;
            this._ucbtWORK_ORDER.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ucbtWORK_ORDER.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources._48x_System;
            this._ucbtWORK_ORDER.Location = new System.Drawing.Point(3, 3);
            this._ucbtWORK_ORDER.Name = "_ucbtWORK_ORDER";
            this._ucbtWORK_ORDER.Size = new System.Drawing.Size(164, 69);
            this._ucbtWORK_ORDER.TabIndex = 4;
            this._ucbtWORK_ORDER.Text = "작업지시찾기";
            this._ucbtWORK_ORDER.Click += new System.EventHandler(this._ucbtWORK_ORDER_Click);
            // 
            // _ucbtOUT_REG
            // 
            this._ucbtOUT_REG.Appearance.Font = new System.Drawing.Font("굴림체", 15.75F, System.Drawing.FontStyle.Bold);
            this._ucbtOUT_REG.Appearance.Options.UseFont = true;
            this._ucbtOUT_REG.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ucbtOUT_REG.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources._48x_ProductAdd;
            this._ucbtOUT_REG.Location = new System.Drawing.Point(343, 3);
            this._ucbtOUT_REG.Name = "_ucbtOUT_REG";
            this._ucbtOUT_REG.Size = new System.Drawing.Size(164, 69);
            this._ucbtOUT_REG.TabIndex = 5;
            this._ucbtOUT_REG.Text = "원료출고";
            this._ucbtOUT_REG.Click += new System.EventHandler(this._ucbtOUT_REG_Click);
            // 
            // _ucbtORDERDOC_REG
            // 
            this._ucbtORDERDOC_REG.Appearance.Font = new System.Drawing.Font("굴림체", 15.75F, System.Drawing.FontStyle.Bold);
            this._ucbtORDERDOC_REG.Appearance.Options.UseFont = true;
            this._ucbtORDERDOC_REG.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ucbtORDERDOC_REG.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources._48x_Paper;
            this._ucbtORDERDOC_REG.Location = new System.Drawing.Point(513, 3);
            this._ucbtORDERDOC_REG.Name = "_ucbtORDERDOC_REG";
            this._ucbtORDERDOC_REG.Size = new System.Drawing.Size(164, 69);
            this._ucbtORDERDOC_REG.TabIndex = 7;
            this._ucbtORDERDOC_REG.Text = "지시서열기";
            this._ucbtORDERDOC_REG.Click += new System.EventHandler(this._ucbtORDERDOC_REG_Click);
            // 
            // _ucbtKEYPAD
            // 
            this._ucbtKEYPAD.Appearance.Font = new System.Drawing.Font("굴림체", 15.75F, System.Drawing.FontStyle.Bold);
            this._ucbtKEYPAD.Appearance.Options.UseFont = true;
            this._ucbtKEYPAD.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ucbtKEYPAD.Location = new System.Drawing.Point(853, 3);
            this._ucbtKEYPAD.Name = "_ucbtKEYPAD";
            this._ucbtKEYPAD.Size = new System.Drawing.Size(168, 69);
            this._ucbtKEYPAD.TabIndex = 6;
            this._ucbtKEYPAD.Text = "키패드";
            this._ucbtKEYPAD.Click += new System.EventHandler(this._ucbtKEYPAD_Click);
            // 
            // _ucbtPART_STOCK
            // 
            this._ucbtPART_STOCK.Appearance.Font = new System.Drawing.Font("굴림체", 15.75F, System.Drawing.FontStyle.Bold);
            this._ucbtPART_STOCK.Appearance.Options.UseFont = true;
            this._ucbtPART_STOCK.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ucbtPART_STOCK.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources._48x_ProductAdd;
            this._ucbtPART_STOCK.Location = new System.Drawing.Point(683, 3);
            this._ucbtPART_STOCK.Name = "_ucbtPART_STOCK";
            this._ucbtPART_STOCK.Size = new System.Drawing.Size(164, 69);
            this._ucbtPART_STOCK.TabIndex = 9;
            this._ucbtPART_STOCK.Text = "반제품재고확인";
            this._ucbtPART_STOCK.Click += new System.EventHandler(this._ucbtPART_STOCK_Click);
            // 
            // pnlDeviceConnect
            // 
            this.pnlDeviceConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDeviceConnect.Location = new System.Drawing.Point(0, 568);
            this.pnlDeviceConnect.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDeviceConnect.Name = "pnlDeviceConnect";
            this.pnlDeviceConnect.Size = new System.Drawing.Size(1024, 31);
            this.pnlDeviceConnect.TabIndex = 2;
            // 
            // tlpUp
            // 
            this.tlpUp.ColumnCount = 1;
            this.tlpUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUp.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tlpUp.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.tlpUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUp.Location = new System.Drawing.Point(0, 0);
            this.tlpUp.Margin = new System.Windows.Forms.Padding(0);
            this.tlpUp.Name = "tlpUp";
            this.tlpUp.RowCount = 2;
            this.tlpUp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpUp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUp.Size = new System.Drawing.Size(1024, 156);
            this.tlpUp.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel7, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 60);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1024, 96);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(210)))), ((int)(((byte)(228)))));
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this._lciTPART_NAME, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this._luPART_NAME, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(509, 45);
            this.tableLayoutPanel8.TabIndex = 1;
            // 
            // _lciTPART_NAME
            // 
            this._lciTPART_NAME.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lciTPART_NAME.Appearance.Options.UseFont = true;
            this._lciTPART_NAME.Appearance.Options.UseTextOptions = true;
            this._lciTPART_NAME.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciTPART_NAME.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lciTPART_NAME.Location = new System.Drawing.Point(0, 0);
            this._lciTPART_NAME.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this._lciTPART_NAME.Name = "_lciTPART_NAME";
            this._lciTPART_NAME.Size = new System.Drawing.Size(190, 45);
            this._lciTPART_NAME.TabIndex = 2;
            this._lciTPART_NAME.Text = "품목명 :";
            // 
            // _luPART_NAME
            // 
            this._luPART_NAME.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._luPART_NAME.Appearance.Options.UseFont = true;
            this._luPART_NAME.Dock = System.Windows.Forms.DockStyle.Fill;
            this._luPART_NAME.Location = new System.Drawing.Point(210, 0);
            this._luPART_NAME.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this._luPART_NAME.Name = "_luPART_NAME";
            this._luPART_NAME.Size = new System.Drawing.Size(299, 45);
            this._luPART_NAME.TabIndex = 1;
            this._luPART_NAME.Text = "금속성 4x9 가공볼트";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(210)))), ((int)(((byte)(228)))));
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this._lciTPART_CODE, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this._luPART_CODE, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(513, 2);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(509, 45);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // _lciTPART_CODE
            // 
            this._lciTPART_CODE.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lciTPART_CODE.Appearance.Options.UseFont = true;
            this._lciTPART_CODE.Appearance.Options.UseTextOptions = true;
            this._lciTPART_CODE.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciTPART_CODE.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lciTPART_CODE.Location = new System.Drawing.Point(0, 0);
            this._lciTPART_CODE.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this._lciTPART_CODE.Name = "_lciTPART_CODE";
            this._lciTPART_CODE.Size = new System.Drawing.Size(190, 45);
            this._lciTPART_CODE.TabIndex = 1;
            this._lciTPART_CODE.Text = "품목코드 :";
            // 
            // _luPART_CODE
            // 
            this._luPART_CODE.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._luPART_CODE.Appearance.Options.UseFont = true;
            this._luPART_CODE.Dock = System.Windows.Forms.DockStyle.Fill;
            this._luPART_CODE.Location = new System.Drawing.Point(210, 0);
            this._luPART_CODE.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this._luPART_CODE.Name = "_luPART_CODE";
            this._luPART_CODE.Size = new System.Drawing.Size(299, 45);
            this._luPART_CODE.TabIndex = 2;
            this._luPART_CODE.Text = "MS38900023";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this._lciTPRODUCTION_ORDER_DATE, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this._luORDER_DATE, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(2, 49);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(509, 45);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // _lciTPRODUCTION_ORDER_DATE
            // 
            this._lciTPRODUCTION_ORDER_DATE.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lciTPRODUCTION_ORDER_DATE.Appearance.Options.UseFont = true;
            this._lciTPRODUCTION_ORDER_DATE.Appearance.Options.UseTextOptions = true;
            this._lciTPRODUCTION_ORDER_DATE.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciTPRODUCTION_ORDER_DATE.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lciTPRODUCTION_ORDER_DATE.Location = new System.Drawing.Point(0, 0);
            this._lciTPRODUCTION_ORDER_DATE.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this._lciTPRODUCTION_ORDER_DATE.Name = "_lciTPRODUCTION_ORDER_DATE";
            this._lciTPRODUCTION_ORDER_DATE.Size = new System.Drawing.Size(190, 45);
            this._lciTPRODUCTION_ORDER_DATE.TabIndex = 1;
            this._lciTPRODUCTION_ORDER_DATE.Text = "지시일자 :";
            // 
            // _luORDER_DATE
            // 
            this._luORDER_DATE.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._luORDER_DATE.Appearance.Options.UseFont = true;
            this._luORDER_DATE.Appearance.Options.UseTextOptions = true;
            this._luORDER_DATE.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._luORDER_DATE.Dock = System.Windows.Forms.DockStyle.Fill;
            this._luORDER_DATE.Location = new System.Drawing.Point(210, 0);
            this._luORDER_DATE.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this._luORDER_DATE.Name = "_luORDER_DATE";
            this._luORDER_DATE.Size = new System.Drawing.Size(299, 45);
            this._luORDER_DATE.TabIndex = 1;
            this._luORDER_DATE.Text = "2018-06-16";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this._lciTPRODUCTION_ORDER_QTY, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this._luORDER_QTY, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(513, 49);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(509, 45);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // _lciTPRODUCTION_ORDER_QTY
            // 
            this._lciTPRODUCTION_ORDER_QTY.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lciTPRODUCTION_ORDER_QTY.Appearance.Options.UseFont = true;
            this._lciTPRODUCTION_ORDER_QTY.Appearance.Options.UseTextOptions = true;
            this._lciTPRODUCTION_ORDER_QTY.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciTPRODUCTION_ORDER_QTY.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lciTPRODUCTION_ORDER_QTY.Location = new System.Drawing.Point(0, 0);
            this._lciTPRODUCTION_ORDER_QTY.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this._lciTPRODUCTION_ORDER_QTY.Name = "_lciTPRODUCTION_ORDER_QTY";
            this._lciTPRODUCTION_ORDER_QTY.Size = new System.Drawing.Size(190, 45);
            this._lciTPRODUCTION_ORDER_QTY.TabIndex = 1;
            this._lciTPRODUCTION_ORDER_QTY.Text = "지시수량 :";
            // 
            // _luORDER_QTY
            // 
            this._luORDER_QTY.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._luORDER_QTY.Appearance.Options.UseFont = true;
            this._luORDER_QTY.Appearance.Options.UseTextOptions = true;
            this._luORDER_QTY.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._luORDER_QTY.Dock = System.Windows.Forms.DockStyle.Fill;
            this._luORDER_QTY.Location = new System.Drawing.Point(210, 0);
            this._luORDER_QTY.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this._luORDER_QTY.Name = "_luORDER_QTY";
            this._luORDER_QTY.Size = new System.Drawing.Size(299, 45);
            this._luORDER_QTY.TabIndex = 0;
            this._luORDER_QTY.Text = "23";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this._lciTPRODUCTION_ORDER_INFO, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(1018, 54);
            this.tableLayoutPanel9.TabIndex = 2;
            // 
            // _lciTPRODUCTION_ORDER_INFO
            // 
            this._lciTPRODUCTION_ORDER_INFO.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lciTPRODUCTION_ORDER_INFO.Appearance.Options.UseFont = true;
            this._lciTPRODUCTION_ORDER_INFO.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lciTPRODUCTION_ORDER_INFO.Location = new System.Drawing.Point(30, 0);
            this._lciTPRODUCTION_ORDER_INFO.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this._lciTPRODUCTION_ORDER_INFO.Name = "_lciTPRODUCTION_ORDER_INFO";
            this._lciTPRODUCTION_ORDER_INFO.Size = new System.Drawing.Size(479, 54);
            this._lciTPRODUCTION_ORDER_INFO.TabIndex = 0;
            this._lciTPRODUCTION_ORDER_INFO.Text = "작업지시 정보";
            // 
            // frmPOPMain_WEIGHING_COSMETICS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 729);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPOPMain_WEIGHING_COSMETICS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmPOPMain_WEIGHING_COSMETICS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this._pnMain.ResumeLayout(false);
            this.tlpPOPMain.ResumeLayout(false);
            this.tlpDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).EndInit();
            this.tlpButton.ResumeLayout(false);
            this.tlpUp.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPOPMain;
        private System.Windows.Forms.TableLayoutPanel tlpButton;
        private DevExpress.XtraEditors.SimpleButton _ucbtWORK_ORDER;
        private System.Windows.Forms.Panel pnlDeviceConnect;
        private System.Windows.Forms.TableLayoutPanel tlpUp;
        private DevExpress.XtraEditors.LabelControl _lciTPRODUCTION_ORDER_INFO;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private DevExpress.XtraEditors.LabelControl _lciTPART_NAME;
        private DevExpress.XtraEditors.LabelControl _luPART_NAME;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private DevExpress.XtraEditors.LabelControl _lciTPART_CODE;
        private DevExpress.XtraEditors.LabelControl _luPART_CODE;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private DevExpress.XtraEditors.LabelControl _lciTPRODUCTION_ORDER_DATE;
        private DevExpress.XtraEditors.LabelControl _luORDER_DATE;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private DevExpress.XtraEditors.LabelControl _lciTPRODUCTION_ORDER_QTY;
        private DevExpress.XtraEditors.LabelControl _luORDER_QTY;
        private System.Windows.Forms.TableLayoutPanel tlpDown;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private DevExpress.XtraGrid.GridControl _gdSUB;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdSUB_VIEW;
        private DevExpress.XtraGrid.GridControl _gdMAIN;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdMAIN_VIEW;
        private DevExpress.XtraEditors.SimpleButton _ucbtOUT_REG;
        private DevExpress.XtraEditors.SimpleButton _ucbtKEYPAD;
        private DevExpress.XtraEditors.SimpleButton _ucbtORDERDOC_REG;
        private DevExpress.XtraEditors.SimpleButton _ucbtPART_STOCK;
        private DevExpress.XtraEditors.SimpleButton _ucbtINSPECT_REG;
    }
}
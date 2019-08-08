namespace CoFAS_MES.POP
{
    partial class frmPOPProductMonitoring
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOPProductMonitoring));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._gdMAIN = new DevExpress.XtraGrid.GridControl();
            this._gdMAIN_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Title = new System.Windows.Forms.Label();
            this._peCI = new CoFAS_MES.CORE.BaseControls.ucPictureEdit();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this._lbStartTime = new DevExpress.XtraEditors.LabelControl();
            this._lbCurrentTime = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this._lbContract = new DevExpress.XtraEditors.LabelControl();
            this._lbProductPlan = new DevExpress.XtraEditors.LabelControl();
            this._lbProductResult = new DevExpress.XtraEditors.LabelControl();
            this._lbContract_Qty = new DevExpress.XtraEditors.LabelControl();
            this._lbPlan_QTY = new DevExpress.XtraEditors.LabelControl();
            this._lbResult_Qty = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this._pnSINGLE_MAIN)).BeginInit();
            this._pnSINGLE_MAIN.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // _pnSINGLE_MAIN
            // 
            this._pnSINGLE_MAIN.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnSINGLE_MAIN.Appearance.BorderColor = System.Drawing.Color.Silver;
            this._pnSINGLE_MAIN.Appearance.Options.UseBackColor = true;
            this._pnSINGLE_MAIN.Appearance.Options.UseBorderColor = true;
            this._pnSINGLE_MAIN.Controls.Add(this.tableLayoutPanel1);
            this._pnSINGLE_MAIN.Size = new System.Drawing.Size(1920, 1040);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this._gdMAIN, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Title, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this._peCI, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1920, 1040);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _gdMAIN
            // 
            this._gdMAIN.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.tableLayoutPanel1.SetColumnSpan(this._gdMAIN, 10);
            this._gdMAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gdMAIN.Location = new System.Drawing.Point(0, 312);
            this._gdMAIN.MainView = this._gdMAIN_VIEW;
            this._gdMAIN.Margin = new System.Windows.Forms.Padding(0);
            this._gdMAIN.Name = "_gdMAIN";
            this._gdMAIN.Size = new System.Drawing.Size(1920, 728);
            this._gdMAIN.TabIndex = 5;
            this._gdMAIN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gdMAIN_VIEW});
            // 
            // _gdMAIN_VIEW
            // 
            this._gdMAIN_VIEW.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this._gdMAIN_VIEW.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._gdMAIN_VIEW.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this._gdMAIN_VIEW.GridControl = this._gdMAIN;
            this._gdMAIN_VIEW.Name = "_gdMAIN_VIEW";
            this._gdMAIN_VIEW.OptionsBehavior.Editable = false;
            this._gdMAIN_VIEW.OptionsView.AllowHtmlDrawHeaders = true;
            this._gdMAIN_VIEW.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.Title, 6);
            this.Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title.Font = new System.Drawing.Font("Tahoma", 90.25F, System.Drawing.FontStyle.Bold);
            this.Title.Location = new System.Drawing.Point(387, 0);
            this.Title.Name = "Title";
            this.tableLayoutPanel1.SetRowSpan(this.Title, 2);
            this.Title.Size = new System.Drawing.Size(1146, 156);
            this.Title.TabIndex = 6;
            this.Title.Text = "조립 생산 현황판";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _peCI
            // 
            this.tableLayoutPanel1.SetColumnSpan(this._peCI, 2);
            this._peCI.Dock = System.Windows.Forms.DockStyle.Fill;
            this._peCI.Image = ((System.Drawing.Image)(resources.GetObject("_peCI.Image")));
            this._peCI.Location = new System.Drawing.Point(0, 0);
            this._peCI.Margin = new System.Windows.Forms.Padding(0);
            this._peCI.Name = "_peCI";
            this.tableLayoutPanel1.SetRowSpan(this._peCI, 2);
            this._peCI.Size = new System.Drawing.Size(384, 156);
            this._peCI.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.StretchVertical;
            this._peCI.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this._lbStartTime, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this._lbCurrentTime, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelControl1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelControl2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1539, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(378, 150);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // _lbStartTime
            // 
            this._lbStartTime.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this._lbStartTime.Appearance.Options.UseFont = true;
            this._lbStartTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbStartTime.Location = new System.Drawing.Point(117, 4);
            this._lbStartTime.Name = "_lbStartTime";
            this._lbStartTime.Size = new System.Drawing.Size(257, 67);
            this._lbStartTime.TabIndex = 0;
            this._lbStartTime.Text = "2018-12-10 16:12:30";
            // 
            // _lbCurrentTime
            // 
            this._lbCurrentTime.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this._lbCurrentTime.Appearance.Options.UseFont = true;
            this._lbCurrentTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbCurrentTime.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this._lbCurrentTime.Location = new System.Drawing.Point(117, 78);
            this._lbCurrentTime.Name = "_lbCurrentTime";
            this._lbCurrentTime.Size = new System.Drawing.Size(257, 68);
            this._lbCurrentTime.TabIndex = 1;
            this._lbCurrentTime.Text = "2018-12-10 16:12:30";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(106, 67);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "시작시간 :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl2.Location = new System.Drawing.Point(4, 78);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(106, 68);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "현재시간 :";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel3, 10);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.01802F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.31532F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.01802F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.31532F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.01802F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.31532F));
            this.tableLayoutPanel3.Controls.Add(this._lbContract, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this._lbProductPlan, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this._lbProductResult, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this._lbContract_Qty, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this._lbPlan_QTY, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this._lbResult_Qty, 5, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 159);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1914, 150);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // _lbContract
            // 
            this._lbContract.Appearance.Font = new System.Drawing.Font("Tahoma", 60F);
            this._lbContract.Appearance.Options.UseFont = true;
            this._lbContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbContract.Location = new System.Drawing.Point(4, 4);
            this._lbContract.Name = "_lbContract";
            this._lbContract.Size = new System.Drawing.Size(337, 142);
            this._lbContract.TabIndex = 3;
            this._lbContract.Text = "수주(건) :";
            // 
            // _lbProductPlan
            // 
            this._lbProductPlan.Appearance.Font = new System.Drawing.Font("Tahoma", 60F);
            this._lbProductPlan.Appearance.Options.UseFont = true;
            this._lbProductPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbProductPlan.Location = new System.Drawing.Point(641, 4);
            this._lbProductPlan.Name = "_lbProductPlan";
            this._lbProductPlan.Size = new System.Drawing.Size(337, 142);
            this._lbProductPlan.TabIndex = 4;
            this._lbProductPlan.Text = "계획량 :";
            // 
            // _lbProductResult
            // 
            this._lbProductResult.Appearance.Font = new System.Drawing.Font("Tahoma", 60F);
            this._lbProductResult.Appearance.Options.UseFont = true;
            this._lbProductResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbProductResult.Location = new System.Drawing.Point(1278, 4);
            this._lbProductResult.Name = "_lbProductResult";
            this._lbProductResult.Size = new System.Drawing.Size(337, 142);
            this._lbProductResult.TabIndex = 5;
            this._lbProductResult.Text = "실적량 :";
            // 
            // _lbContract_Qty
            // 
            this._lbContract_Qty.Appearance.Font = new System.Drawing.Font("Tahoma", 70F);
            this._lbContract_Qty.Appearance.Options.UseFont = true;
            this._lbContract_Qty.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbContract_Qty.Location = new System.Drawing.Point(348, 4);
            this._lbContract_Qty.Name = "_lbContract_Qty";
            this._lbContract_Qty.Size = new System.Drawing.Size(286, 142);
            this._lbContract_Qty.TabIndex = 6;
            this._lbContract_Qty.Text = "0";
            // 
            // _lbPlan_QTY
            // 
            this._lbPlan_QTY.Appearance.Font = new System.Drawing.Font("Tahoma", 70F);
            this._lbPlan_QTY.Appearance.Options.UseFont = true;
            this._lbPlan_QTY.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbPlan_QTY.Location = new System.Drawing.Point(985, 4);
            this._lbPlan_QTY.Name = "_lbPlan_QTY";
            this._lbPlan_QTY.Size = new System.Drawing.Size(286, 142);
            this._lbPlan_QTY.TabIndex = 7;
            this._lbPlan_QTY.Text = "0";
            // 
            // _lbResult_Qty
            // 
            this._lbResult_Qty.Appearance.Font = new System.Drawing.Font("Tahoma", 70F);
            this._lbResult_Qty.Appearance.Options.UseFont = true;
            this._lbResult_Qty.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbResult_Qty.Location = new System.Drawing.Point(1622, 4);
            this._lbResult_Qty.Name = "_lbResult_Qty";
            this._lbResult_Qty.Size = new System.Drawing.Size(288, 142);
            this._lbResult_Qty.TabIndex = 8;
            this._lbResult_Qty.Text = "0";
            // 
            // frmPOPProductMonitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Child_Page_Setting_Visible = true;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Name = "frmPOPProductMonitoring";
            this.Text = "frmPOPOrder_T01";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this._pnSINGLE_MAIN)).EndInit();
            this._pnSINGLE_MAIN.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Title;
        private CORE.BaseControls.ucPictureEdit _peCI;
        private DevExpress.XtraGrid.GridControl _gdMAIN;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdMAIN_VIEW;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.LabelControl _lbStartTime;
        private DevExpress.XtraEditors.LabelControl _lbCurrentTime;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraEditors.LabelControl _lbContract;
        private DevExpress.XtraEditors.LabelControl _lbProductPlan;
        private DevExpress.XtraEditors.LabelControl _lbProductResult;
        private DevExpress.XtraEditors.LabelControl _lbContract_Qty;
        private DevExpress.XtraEditors.LabelControl _lbPlan_QTY;
        private DevExpress.XtraEditors.LabelControl _lbResult_Qty;
    }
}
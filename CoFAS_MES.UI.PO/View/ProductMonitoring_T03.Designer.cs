namespace CoFAS_MES.UI.PO
{
    partial class ProductMonitoring_T03
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
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this._gdMAIN = new DevExpress.XtraGrid.GridControl();
            this._gdMAIN_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup8 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._lbOrder = new System.Windows.Forms.Label();
            this._lbOrder_Count = new System.Windows.Forms.Label();
            this._lbOrder2 = new System.Windows.Forms.Label();
            this._lbOrder_qty = new System.Windows.Forms.Label();
            this._lbResult = new System.Windows.Forms.Label();
            this._lbResult_qty = new System.Windows.Forms.Label();
            this._luTORDER_DATE = new CoFAS_MES.CORE.BaseControls.ucFromToDateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
            this._lciTPRODUCTION_ORDER_DATE = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this._pnHeader)).BeginInit();
            this._pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pnContent)).BeginInit();
            this._pnContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pnLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pnRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTPRODUCTION_ORDER_DATE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // _pnHeader
            // 
            this._pnHeader.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnHeader.Appearance.Options.UseBackColor = true;
            this._pnHeader.Controls.Add(this.layoutControl1);
            this._pnHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._pnHeader.Size = new System.Drawing.Size(1200, 197);
            // 
            // _pnContent
            // 
            this._pnContent.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnContent.Appearance.Options.UseBackColor = true;
            this._pnContent.Controls.Add(this.layoutControl2);
            this._pnContent.Location = new System.Drawing.Point(6, 197);
            this._pnContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._pnContent.Size = new System.Drawing.Size(1189, 503);
            // 
            // _pnLeft
            // 
            this._pnLeft.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnLeft.Appearance.Options.UseBackColor = true;
            this._pnLeft.Location = new System.Drawing.Point(0, 197);
            this._pnLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._pnLeft.Size = new System.Drawing.Size(1, 503);
            this._pnLeft.Visible = false;
            // 
            // _pnRight
            // 
            this._pnRight.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnRight.Appearance.Options.UseBackColor = true;
            this._pnRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnRight.Location = new System.Drawing.Point(6, 197);
            this._pnRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._pnRight.Size = new System.Drawing.Size(1194, 503);
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this._gdMAIN);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(1189, 503);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // _gdMAIN
            // 
            this._gdMAIN.Location = new System.Drawing.Point(24, 24);
            this._gdMAIN.MainView = this._gdMAIN_VIEW;
            this._gdMAIN.Name = "_gdMAIN";
            this._gdMAIN.Size = new System.Drawing.Size(1141, 455);
            this._gdMAIN.TabIndex = 4;
            this._gdMAIN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gdMAIN_VIEW});
            // 
            // _gdMAIN_VIEW
            // 
            this._gdMAIN_VIEW.GridControl = this._gdMAIN;
            this._gdMAIN_VIEW.Name = "_gdMAIN_VIEW";
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup8});
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup2.Size = new System.Drawing.Size(1189, 503);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlGroup8
            // 
            this.layoutControlGroup8.CustomizationFormText = "layoutControlGroup20";
            this.layoutControlGroup8.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup8.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup8.Name = "layoutControlGroup8";
            this.layoutControlGroup8.Size = new System.Drawing.Size(1169, 483);
            this.layoutControlGroup8.Text = "layoutControlGroup20";
            this.layoutControlGroup8.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this._gdMAIN;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1145, 459);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.tableLayoutPanel1);
            this.layoutControl1.Controls.Add(this._luTORDER_DATE);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1200, 197);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this._lbOrder, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._lbOrder_Count, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._lbOrder2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this._lbOrder_qty, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this._lbResult, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this._lbResult_qty, 5, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(617, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(553, 149);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // _lbOrder
            // 
            this._lbOrder.AutoSize = true;
            this._lbOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._lbOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbOrder.Font = new System.Drawing.Font("Tahoma", 25F);
            this._lbOrder.Location = new System.Drawing.Point(3, 0);
            this._lbOrder.Name = "_lbOrder";
            this._lbOrder.Size = new System.Drawing.Size(86, 149);
            this._lbOrder.TabIndex = 0;
            this._lbOrder.Text = "지시(건) :";
            this._lbOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _lbOrder_Count
            // 
            this._lbOrder_Count.AutoSize = true;
            this._lbOrder_Count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._lbOrder_Count.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbOrder_Count.Font = new System.Drawing.Font("Tahoma", 25F);
            this._lbOrder_Count.Location = new System.Drawing.Point(95, 0);
            this._lbOrder_Count.Name = "_lbOrder_Count";
            this._lbOrder_Count.Size = new System.Drawing.Size(86, 149);
            this._lbOrder_Count.TabIndex = 1;
            this._lbOrder_Count.Text = "0";
            this._lbOrder_Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _lbOrder2
            // 
            this._lbOrder2.AutoSize = true;
            this._lbOrder2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._lbOrder2.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbOrder2.Font = new System.Drawing.Font("Tahoma", 25F);
            this._lbOrder2.Location = new System.Drawing.Point(187, 0);
            this._lbOrder2.Name = "_lbOrder2";
            this._lbOrder2.Size = new System.Drawing.Size(86, 149);
            this._lbOrder2.TabIndex = 2;
            this._lbOrder2.Text = "지시량 :";
            this._lbOrder2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _lbOrder_qty
            // 
            this._lbOrder_qty.AutoSize = true;
            this._lbOrder_qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._lbOrder_qty.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbOrder_qty.Font = new System.Drawing.Font("Tahoma", 25F);
            this._lbOrder_qty.Location = new System.Drawing.Point(279, 0);
            this._lbOrder_qty.Name = "_lbOrder_qty";
            this._lbOrder_qty.Size = new System.Drawing.Size(86, 149);
            this._lbOrder_qty.TabIndex = 3;
            this._lbOrder_qty.Text = "0";
            this._lbOrder_qty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _lbResult
            // 
            this._lbResult.AutoSize = true;
            this._lbResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._lbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbResult.Font = new System.Drawing.Font("Tahoma", 25F);
            this._lbResult.Location = new System.Drawing.Point(371, 0);
            this._lbResult.Name = "_lbResult";
            this._lbResult.Size = new System.Drawing.Size(86, 149);
            this._lbResult.TabIndex = 4;
            this._lbResult.Text = "실적량 :";
            this._lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _lbResult_qty
            // 
            this._lbResult_qty.AutoSize = true;
            this._lbResult_qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._lbResult_qty.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbResult_qty.Font = new System.Drawing.Font("Tahoma", 25F);
            this._lbResult_qty.Location = new System.Drawing.Point(463, 0);
            this._lbResult_qty.Name = "_lbResult_qty";
            this._lbResult_qty.Size = new System.Drawing.Size(87, 149);
            this._lbResult_qty.TabIndex = 5;
            this._lbResult_qty.Text = "0";
            this._lbResult_qty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _luTORDER_DATE
            // 
            this._luTORDER_DATE.FromDateTime = new System.DateTime(2018, 7, 1, 0, 0, 0, 0);
            this._luTORDER_DATE.Location = new System.Drawing.Point(217, 24);
            this._luTORDER_DATE.Margin = new System.Windows.Forms.Padding(0);
            this._luTORDER_DATE.Name = "_luTORDER_DATE";
            this._luTORDER_DATE.Size = new System.Drawing.Size(209, 20);
            this._luTORDER_DATE.TabIndex = 0;
            this._luTORDER_DATE.ToDateTime = new System.DateTime(2018, 7, 2, 23, 59, 59, 0);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup6});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(16, 16, 10, 10);
            this.layoutControlGroup1.Size = new System.Drawing.Size(1200, 197);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup6
            // 
            this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this._lciTPRODUCTION_ORDER_DATE,
            this.emptySpaceItem1,
            this.layoutControlItem2});
            this.layoutControlGroup6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup6.Name = "layoutControlGroup6";
            this.layoutControlGroup6.Size = new System.Drawing.Size(1168, 177);
            this.layoutControlGroup6.TextVisible = false;
            // 
            // _lciTPRODUCTION_ORDER_DATE
            // 
            this._lciTPRODUCTION_ORDER_DATE.Control = this._luTORDER_DATE;
            this._lciTPRODUCTION_ORDER_DATE.CustomizationFormText = "_lciTORDER_DATE";
            this._lciTPRODUCTION_ORDER_DATE.Location = new System.Drawing.Point(0, 0);
            this._lciTPRODUCTION_ORDER_DATE.MaxSize = new System.Drawing.Size(400, 24);
            this._lciTPRODUCTION_ORDER_DATE.MinSize = new System.Drawing.Size(400, 24);
            this._lciTPRODUCTION_ORDER_DATE.Name = "_lciTPRODUCTION_ORDER_DATE";
            this._lciTPRODUCTION_ORDER_DATE.Size = new System.Drawing.Size(400, 24);
            this._lciTPRODUCTION_ORDER_DATE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciTPRODUCTION_ORDER_DATE.TextSize = new System.Drawing.Size(183, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(400, 129);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.tableLayoutPanel1;
            this.layoutControlItem2.Location = new System.Drawing.Point(400, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(744, 153);
            this.layoutControlItem2.Text = " ";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(183, 14);
            // 
            // ProductMonitoring_T03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProductMonitoring_T03";
            this.Text = "ProductMonitoring_T02";
            this.WindowName = "ProductMonitoring_T02";
            ((System.ComponentModel.ISupportInitialize)(this._pnHeader)).EndInit();
            this._pnHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pnContent)).EndInit();
            this._pnContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pnLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pnRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTPRODUCTION_ORDER_DATE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup6;
        private CORE.BaseControls.ucFromToDateEdit _luTORDER_DATE;
        private DevExpress.XtraLayout.LayoutControlItem _lciTPRODUCTION_ORDER_DATE;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.GridControl _gdMAIN;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdMAIN_VIEW;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label _lbOrder;
        private System.Windows.Forms.Label _lbOrder_Count;
        private System.Windows.Forms.Label _lbOrder2;
        private System.Windows.Forms.Label _lbOrder_qty;
        private System.Windows.Forms.Label _lbResult;
        private System.Windows.Forms.Label _lbResult_qty;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}
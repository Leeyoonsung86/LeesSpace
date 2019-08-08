namespace CoFAS_MES.UI.PO
{
    partial class Scheduling_T50
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
            this.chkAll = new DevExpress.XtraEditors.CheckEdit();
            this._gdSUB = new DevExpress.XtraGrid.GridControl();
            this._gdSUB_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._luT_DATE = new CoFAS_MES.CORE.BaseControls.ucDateEdit();
            this._gdMAIN = new DevExpress.XtraGrid.GridControl();
            this._gdMAIN_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup8 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciT_DATE = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tlpEmp = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this._pnHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pnContent)).BeginInit();
            this._pnContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pnLeft)).BeginInit();
            this._pnLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pnRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciT_DATE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // _pnHeader
            // 
            this._pnHeader.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnHeader.Appearance.Options.UseBackColor = true;
            this._pnHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._pnHeader.Size = new System.Drawing.Size(1200, 10);
            // 
            // _pnContent
            // 
            this._pnContent.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnContent.Appearance.Options.UseBackColor = true;
            this._pnContent.Controls.Add(this.tlpEmp);
            this._pnContent.Location = new System.Drawing.Point(405, 10);
            this._pnContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._pnContent.Size = new System.Drawing.Size(790, 690);
            // 
            // _pnLeft
            // 
            this._pnLeft.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnLeft.Appearance.Options.UseBackColor = true;
            this._pnLeft.Controls.Add(this.layoutControl2);
            this._pnLeft.Location = new System.Drawing.Point(0, 10);
            this._pnLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._pnLeft.Size = new System.Drawing.Size(400, 690);
            this._pnLeft.Visible = false;
            // 
            // _pnRight
            // 
            this._pnRight.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnRight.Appearance.Options.UseBackColor = true;
            this._pnRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnRight.Location = new System.Drawing.Point(405, 10);
            this._pnRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._pnRight.Size = new System.Drawing.Size(795, 690);
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.chkAll);
            this.layoutControl2.Controls.Add(this._gdSUB);
            this.layoutControl2.Controls.Add(this._luT_DATE);
            this.layoutControl2.Controls.Add(this._gdMAIN);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(347, 217, 650, 400);
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(400, 690);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // chkAll
            // 
            this.chkAll.Location = new System.Drawing.Point(261, 24);
            this.chkAll.Name = "chkAll";
            this.chkAll.Properties.Caption = "완료조회";
            this.chkAll.Size = new System.Drawing.Size(115, 19);
            this.chkAll.StyleController = this.layoutControl2;
            this.chkAll.TabIndex = 10;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // _gdSUB
            // 
            this._gdSUB.Location = new System.Drawing.Point(24, 48);
            this._gdSUB.MainView = this._gdSUB_VIEW;
            this._gdSUB.Name = "_gdSUB";
            this._gdSUB.Size = new System.Drawing.Size(352, 334);
            this._gdSUB.TabIndex = 9;
            this._gdSUB.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gdSUB_VIEW});
            // 
            // _gdSUB_VIEW
            // 
            this._gdSUB_VIEW.GridControl = this._gdSUB;
            this._gdSUB_VIEW.Name = "_gdSUB_VIEW";
            // 
            // _luT_DATE
            // 
            this._luT_DATE.DateTime = new System.DateTime(2019, 1, 14, 11, 12, 24, 933);
            this._luT_DATE.Location = new System.Drawing.Point(91, 24);
            this._luT_DATE.Margin = new System.Windows.Forms.Padding(0);
            this._luT_DATE.Name = "_luT_DATE";
            this._luT_DATE.ReadOnly = false;
            this._luT_DATE.Size = new System.Drawing.Size(166, 20);
            this._luT_DATE.TabIndex = 8;
            // 
            // _gdMAIN
            // 
            this._gdMAIN.Location = new System.Drawing.Point(24, 410);
            this._gdMAIN.MainView = this._gdMAIN_VIEW;
            this._gdMAIN.Name = "_gdMAIN";
            this._gdMAIN.Size = new System.Drawing.Size(352, 256);
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
            this.layoutControlGroup8,
            this.layoutControlGroup1});
            this.layoutControlGroup2.Name = "Root";
            this.layoutControlGroup2.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup2.Size = new System.Drawing.Size(400, 690);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlGroup8
            // 
            this.layoutControlGroup8.CustomizationFormText = "layoutControlGroup20";
            this.layoutControlGroup8.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
            this.layoutControlGroup8.Location = new System.Drawing.Point(0, 386);
            this.layoutControlGroup8.Name = "layoutControlGroup8";
            this.layoutControlGroup8.Size = new System.Drawing.Size(380, 284);
            this.layoutControlGroup8.Text = "layoutControlGroup20";
            this.layoutControlGroup8.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this._gdMAIN;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(356, 260);
            this.layoutControlItem3.Text = "layoutControlItem4";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this._lciT_DATE,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(380, 386);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this._gdSUB;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(356, 338);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // _lciT_DATE
            // 
            this._lciT_DATE.Control = this._luT_DATE;
            this._lciT_DATE.Location = new System.Drawing.Point(0, 0);
            this._lciT_DATE.MaxSize = new System.Drawing.Size(0, 24);
            this._lciT_DATE.MinSize = new System.Drawing.Size(237, 24);
            this._lciT_DATE.Name = "_lciT_DATE";
            this._lciT_DATE.Size = new System.Drawing.Size(237, 24);
            this._lciT_DATE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciT_DATE.TextSize = new System.Drawing.Size(63, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.chkAll;
            this.layoutControlItem2.Location = new System.Drawing.Point(237, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(119, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // tlpEmp
            // 
            this.tlpEmp.ColumnCount = 1;
            this.tlpEmp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEmp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEmp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEmp.Location = new System.Drawing.Point(0, 0);
            this.tlpEmp.Name = "tlpEmp";
            this.tlpEmp.RowCount = 1;
            this.tlpEmp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEmp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 710F));
            this.tlpEmp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 710F));
            this.tlpEmp.Size = new System.Drawing.Size(790, 690);
            this.tlpEmp.TabIndex = 0;
            // 
            // Scheduling_T50
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Scheduling_T50";
            this.Text = "Scheduling_T50";
            this.WindowName = "Scheduling_T50";
            ((System.ComponentModel.ISupportInitialize)(this._pnHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pnContent)).EndInit();
            this._pnContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pnLeft)).EndInit();
            this._pnLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pnRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciT_DATE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraGrid.GridControl _gdMAIN;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdMAIN_VIEW;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private CORE.BaseControls.ucDateEdit _luT_DATE;
        private System.Windows.Forms.TableLayoutPanel tlpEmp;
        private DevExpress.XtraGrid.GridControl _gdSUB;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdSUB_VIEW;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem _lciT_DATE;
        private DevExpress.XtraEditors.CheckEdit chkAll;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}
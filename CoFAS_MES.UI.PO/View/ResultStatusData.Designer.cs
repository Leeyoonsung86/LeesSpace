namespace CoFAS_MES.UI.PO
{
    partial class ResultStatusData
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this._luT_PROCESS = new CoFAS_MES.CORE.BaseControls.ucLookUpEdit();
            this._luT_PART = new CoFAS_MES.CORE.BaseControls.ucSearchEdit();
            this._luT_ORDER_ID = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luT_ORDER_DATE = new CoFAS_MES.CORE.BaseControls.ucFromToDateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this._lciT_ORDER_DATE = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciT_ORDER_ID = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciT_PART = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this._lciT_PROCESS = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.dashboardViewer = new DevExpress.DashboardWin.DashboardViewer();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this._pnHeader)).BeginInit();
            this._pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pnContent)).BeginInit();
            this._pnContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pnLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pnRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciT_ORDER_DATE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciT_ORDER_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciT_PART)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciT_PROCESS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // _pnHeader
            // 
            this._pnHeader.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnHeader.Appearance.Options.UseBackColor = true;
            this._pnHeader.Controls.Add(this.layoutControl1);
            this._pnHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._pnHeader.Size = new System.Drawing.Size(1200, 95);
            // 
            // _pnContent
            // 
            this._pnContent.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnContent.Appearance.Options.UseBackColor = true;
            this._pnContent.Controls.Add(this.layoutControl2);
            this._pnContent.Location = new System.Drawing.Point(24, 95);
            this._pnContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._pnContent.Size = new System.Drawing.Size(1171, 605);
            // 
            // _pnLeft
            // 
            this._pnLeft.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnLeft.Appearance.Options.UseBackColor = true;
            this._pnLeft.Location = new System.Drawing.Point(0, 95);
            this._pnLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._pnLeft.Size = new System.Drawing.Size(19, 605);
            this._pnLeft.Visible = false;
            // 
            // _pnRight
            // 
            this._pnRight.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnRight.Appearance.Options.UseBackColor = true;
            this._pnRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnRight.Location = new System.Drawing.Point(24, 95);
            this._pnRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._pnRight.Size = new System.Drawing.Size(1176, 605);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._luT_PROCESS);
            this.layoutControl1.Controls.Add(this._luT_PART);
            this.layoutControl1.Controls.Add(this._luT_ORDER_ID);
            this.layoutControl1.Controls.Add(this._luT_ORDER_DATE);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1200, 95);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _luT_PROCESS
            // 
            this._luT_PROCESS.ItemIndex = -1;
            this._luT_PROCESS.Location = new System.Drawing.Point(551, 48);
            this._luT_PROCESS.Margin = new System.Windows.Forms.Padding(0);
            this._luT_PROCESS.Name = "_luT_PROCESS";
            this._luT_PROCESS.ReadOnly = false;
            this._luT_PROCESS.Size = new System.Drawing.Size(263, 20);
            this._luT_PROCESS.TabIndex = 10;
            // 
            // _luT_PART
            // 
            this._luT_PART.BackColor = System.Drawing.Color.White;
            this._luT_PART.CodeReadOnly = false;
            this._luT_PART.CodeText = "";
            this._luT_PART.CodeTextName = "_pCodeTextEdit";
            this._luT_PART.Location = new System.Drawing.Point(551, 24);
            this._luT_PART.Name = "_luT_PART";
            this._luT_PART.NameEnabled = true;
            this._luT_PART.NameReadOnly = false;
            this._luT_PART.NameText = "";
            this._luT_PART.NameTextName = "_pNameButtonEdit";
            this._luT_PART.Size = new System.Drawing.Size(263, 20);
            this._luT_PART.TabIndex = 4;
            this._luT_PART._OnOpenClick += new CoFAS_MES.CORE.BaseControls.ucSearchEdit.OnOpenClickEventHandler(this._luTPART__OnOpenClick);
            // 
            // _luT_ORDER_ID
            // 
            this._luT_ORDER_ID.CancelButton = null;
            this._luT_ORDER_ID.CommandButton = null;
            this._luT_ORDER_ID.EditMask = "";
            this._luT_ORDER_ID.Location = new System.Drawing.Point(142, 48);
            this._luT_ORDER_ID.Margin = new System.Windows.Forms.Padding(0);
            this._luT_ORDER_ID.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luT_ORDER_ID.Name = "_luT_ORDER_ID";
            this._luT_ORDER_ID.PasswordChar = '\0';
            this._luT_ORDER_ID.ReadOnly = false;
            this._luT_ORDER_ID.Size = new System.Drawing.Size(293, 20);
            this._luT_ORDER_ID.TabIndex = 7;
            this._luT_ORDER_ID.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luT_ORDER_ID.UseMaskAsDisplayFormat = false;
            // 
            // _luT_ORDER_DATE
            // 
            this._luT_ORDER_DATE.FromDateTime = new System.DateTime(2018, 4, 1, 0, 0, 0, 0);
            this._luT_ORDER_DATE.Location = new System.Drawing.Point(142, 24);
            this._luT_ORDER_DATE.Margin = new System.Windows.Forms.Padding(0);
            this._luT_ORDER_DATE.Name = "_luT_ORDER_DATE";
            this._luT_ORDER_DATE.Size = new System.Drawing.Size(293, 20);
            this._luT_ORDER_DATE.TabIndex = 4;
            this._luT_ORDER_DATE.ToDateTime = new System.DateTime(2018, 4, 25, 17, 49, 5, 441);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(16, 16, 10, 10);
            this.layoutControlGroup1.Size = new System.Drawing.Size(1200, 95);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this._lciT_ORDER_DATE,
            this._lciT_ORDER_ID,
            this._lciT_PART,
            this.emptySpaceItem1,
            this._lciT_PROCESS});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup3.Size = new System.Drawing.Size(1168, 75);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // _lciT_ORDER_DATE
            // 
            this._lciT_ORDER_DATE.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciT_ORDER_DATE.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciT_ORDER_DATE.Control = this._luT_ORDER_DATE;
            this._lciT_ORDER_DATE.Location = new System.Drawing.Point(0, 0);
            this._lciT_ORDER_DATE.MaxSize = new System.Drawing.Size(409, 24);
            this._lciT_ORDER_DATE.MinSize = new System.Drawing.Size(409, 24);
            this._lciT_ORDER_DATE.Name = "_lciT_ORDER_DATE";
            this._lciT_ORDER_DATE.Size = new System.Drawing.Size(409, 24);
            this._lciT_ORDER_DATE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciT_ORDER_DATE.TextSize = new System.Drawing.Size(108, 14);
            // 
            // _lciT_ORDER_ID
            // 
            this._lciT_ORDER_ID.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciT_ORDER_ID.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciT_ORDER_ID.Control = this._luT_ORDER_ID;
            this._lciT_ORDER_ID.Location = new System.Drawing.Point(0, 24);
            this._lciT_ORDER_ID.MaxSize = new System.Drawing.Size(409, 24);
            this._lciT_ORDER_ID.MinSize = new System.Drawing.Size(409, 24);
            this._lciT_ORDER_ID.Name = "_lciT_ORDER_ID";
            this._lciT_ORDER_ID.Size = new System.Drawing.Size(409, 27);
            this._lciT_ORDER_ID.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciT_ORDER_ID.TextSize = new System.Drawing.Size(108, 14);
            // 
            // _lciT_PART
            // 
            this._lciT_PART.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciT_PART.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciT_PART.Control = this._luT_PART;
            this._lciT_PART.Location = new System.Drawing.Point(409, 0);
            this._lciT_PART.MaxSize = new System.Drawing.Size(379, 24);
            this._lciT_PART.MinSize = new System.Drawing.Size(379, 24);
            this._lciT_PART.Name = "_lciT_PART";
            this._lciT_PART.Size = new System.Drawing.Size(379, 24);
            this._lciT_PART.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciT_PART.TextSize = new System.Drawing.Size(108, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(788, 0);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(104, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(356, 51);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // _lciT_PROCESS
            // 
            this._lciT_PROCESS.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciT_PROCESS.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciT_PROCESS.Control = this._luT_PROCESS;
            this._lciT_PROCESS.Location = new System.Drawing.Point(409, 24);
            this._lciT_PROCESS.MaxSize = new System.Drawing.Size(379, 24);
            this._lciT_PROCESS.MinSize = new System.Drawing.Size(379, 24);
            this._lciT_PROCESS.Name = "_lciT_PROCESS";
            this._lciT_PROCESS.Size = new System.Drawing.Size(379, 27);
            this._lciT_PROCESS.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciT_PROCESS.TextSize = new System.Drawing.Size(108, 14);
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.dashboardViewer);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(1171, 605);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // dashboardViewer
            // 
            this.dashboardViewer.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.dashboardViewer.Appearance.Options.UseBackColor = true;
            this.dashboardViewer.Location = new System.Drawing.Point(12, 12);
            this.dashboardViewer.Name = "dashboardViewer";
            this.dashboardViewer.Size = new System.Drawing.Size(1147, 581);
            this.dashboardViewer.TabIndex = 4;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup2.Size = new System.Drawing.Size(1171, 605);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dashboardViewer;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1151, 585);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ResultStatusData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ResultStatusData";
            this.Text = "ResultStatusData";
            this.WindowName = "ResultStatusData";
            ((System.ComponentModel.ISupportInitialize)(this._pnHeader)).EndInit();
            this._pnHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pnContent)).EndInit();
            this._pnContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pnLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pnRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciT_ORDER_DATE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciT_ORDER_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciT_PART)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciT_PROCESS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private CORE.BaseControls.ucFromToDateEdit _luT_ORDER_DATE;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem _lciT_ORDER_DATE;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private CORE.BaseControls.ucTextEdit _luT_ORDER_ID;
        private DevExpress.XtraLayout.LayoutControlItem _lciT_ORDER_ID;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private CORE.BaseControls.ucSearchEdit _luT_PART;
        private DevExpress.XtraLayout.LayoutControlItem _lciT_PART;
        private DevExpress.DashboardWin.DashboardViewer dashboardViewer;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private CORE.BaseControls.ucLookUpEdit _luT_PROCESS;
        private DevExpress.XtraLayout.LayoutControlItem _lciT_PROCESS;
    }
}
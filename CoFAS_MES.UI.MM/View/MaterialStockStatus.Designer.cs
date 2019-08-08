namespace CoFAS_MES.UI.MM
{
    partial class MaterialStockStatus
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
            this._luPART = new CoFAS_MES.CORE.BaseControls.ucSearchEdit();
            this._luPART_TYPE = new CoFAS_MES.CORE.BaseControls.ucLookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this._lciPART_TYPE = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this._lciPART = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this._pnHeader)).BeginInit();
            this._pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pnContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pnLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPART_TYPE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPART)).BeginInit();
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
            this._pnContent.Location = new System.Drawing.Point(200, 95);
            this._pnContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._pnContent.Size = new System.Drawing.Size(1000, 605);
            // 
            // _pnLeft
            // 
            this._pnLeft.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnLeft.Appearance.Options.UseBackColor = true;
            this._pnLeft.Location = new System.Drawing.Point(0, 95);
            this._pnLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._pnLeft.Size = new System.Drawing.Size(200, 605);
            this._pnLeft.Visible = false;
            // 
            // dashboardViewer
            // 
            this.dashboardViewer.DataSourceOptions.ObjectDataSourceLoadingBehavior = DevExpress.DataAccess.DocumentLoadingBehavior.LoadAsIs;
            this.dashboardViewer.Size = new System.Drawing.Size(952, 557);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._luPART);
            this.layoutControl1.Controls.Add(this._luPART_TYPE);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1200, 95);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _luPART
            // 
            this._luPART.BackColor = System.Drawing.Color.Transparent;
            this._luPART.CodeReadOnly = false;
            this._luPART.CodeText = "";
            this._luPART.CodeTextName = "_pCodeTextEdit";
            this._luPART.Location = new System.Drawing.Point(112, 50);
            this._luPART.Name = "_luPART";
            this._luPART.NameEnabled = true;
            this._luPART.NameReadOnly = false;
            this._luPART.NameText = "";
            this._luPART.NameTextName = "_pNameButtonEdit";
            this._luPART.Size = new System.Drawing.Size(291, 21);
            this._luPART.TabIndex = 9;
            this._luPART._OnOpenClick += new CoFAS_MES.CORE.BaseControls.ucSearchEdit.OnOpenClickEventHandler(this._luPART__OnOpenClick);
            // 
            // _luPART_TYPE
            // 
            this._luPART_TYPE.ItemIndex = -1;
            this._luPART_TYPE.Location = new System.Drawing.Point(112, 24);
            this._luPART_TYPE.Margin = new System.Windows.Forms.Padding(0);
            this._luPART_TYPE.Name = "_luPART_TYPE";
            this._luPART_TYPE.ReadOnly = false;
            this._luPART_TYPE.Size = new System.Drawing.Size(291, 22);
            this._luPART_TYPE.TabIndex = 8;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(1200, 95);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this._lciPART_TYPE,
            this.emptySpaceItem1,
            this._lciPART});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup3.Size = new System.Drawing.Size(1180, 75);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // _lciPART_TYPE
            // 
            this._lciPART_TYPE.Control = this._luPART_TYPE;
            this._lciPART_TYPE.Location = new System.Drawing.Point(0, 0);
            this._lciPART_TYPE.MaxSize = new System.Drawing.Size(383, 26);
            this._lciPART_TYPE.MinSize = new System.Drawing.Size(383, 26);
            this._lciPART_TYPE.Name = "_lciPART_TYPE";
            this._lciPART_TYPE.Size = new System.Drawing.Size(383, 26);
            this._lciPART_TYPE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciPART_TYPE.TextSize = new System.Drawing.Size(84, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(383, 0);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(773, 51);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(773, 51);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(773, 51);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // _lciPART
            // 
            this._lciPART.Control = this._luPART;
            this._lciPART.Location = new System.Drawing.Point(0, 26);
            this._lciPART.MaxSize = new System.Drawing.Size(383, 25);
            this._lciPART.MinSize = new System.Drawing.Size(383, 25);
            this._lciPART.Name = "_lciPART";
            this._lciPART.Size = new System.Drawing.Size(383, 25);
            this._lciPART.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciPART.TextSize = new System.Drawing.Size(84, 14);
            // 
            // MaterialStockStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MaterialStockStatus";
            this.Text = "MaterialOrderStatus";
            this.WindowName = "MaterialOrderStatus";
            ((System.ComponentModel.ISupportInitialize)(this._pnHeader)).EndInit();
            this._pnHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pnContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pnLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPART_TYPE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPART)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private CORE.BaseControls.ucLookUpEdit _luPART_TYPE;
        private DevExpress.XtraLayout.LayoutControlItem _lciPART_TYPE;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private CORE.BaseControls.ucSearchEdit _luPART;
        private DevExpress.XtraLayout.LayoutControlItem _lciPART;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}
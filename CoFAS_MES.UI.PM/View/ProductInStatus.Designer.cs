namespace CoFAS_MES.UI.PM
{
    partial class ProductInStatus
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
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this._luTREFERENCE_ID = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luINOUT_CODE = new CoFAS_MES.CORE.BaseControls.ucLookUpEdit();
            this._luINOUT_TYPE = new CoFAS_MES.CORE.BaseControls.ucLookUpEdit();
            this._luINOUT_DATE = new CoFAS_MES.CORE.BaseControls.ucFromToDateEdit();
            this._luVEND = new CoFAS_MES.CORE.BaseControls.ucSearchEdit();
            this._luPART = new CoFAS_MES.CORE.BaseControls.ucSearchEdit();
            this._luTINOUT_ID = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this._lciINOUT_DATE = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciINOUT_ID = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciPART = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciINOUT_CODE = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciINOUT_TYPE = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciREFERENCE_ID = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this._lciVEND = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.dashboardViewer = new DevExpress.DashboardWin.DashboardViewer(this.components);
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
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
            ((System.ComponentModel.ISupportInitialize)(this._lciINOUT_DATE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciINOUT_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPART)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciINOUT_CODE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciINOUT_TYPE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciREFERENCE_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciVEND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // _pnHeader
            // 
            this._pnHeader.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnHeader.Appearance.Options.UseBackColor = true;
            this._pnHeader.Controls.Add(this.layoutControl1);
            this._pnHeader.Size = new System.Drawing.Size(1200, 95);
            // 
            // _pnContent
            // 
            this._pnContent.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnContent.Appearance.Options.UseBackColor = true;
            this._pnContent.Controls.Add(this.layoutControl2);
            this._pnContent.Location = new System.Drawing.Point(15, 95);
            this._pnContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._pnContent.Size = new System.Drawing.Size(1180, 605);
            // 
            // _pnLeft
            // 
            this._pnLeft.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnLeft.Appearance.Options.UseBackColor = true;
            this._pnLeft.Location = new System.Drawing.Point(0, 95);
            this._pnLeft.Size = new System.Drawing.Size(10, 605);
            this._pnLeft.Visible = false;
            // 
            // _pnRight
            // 
            this._pnRight.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnRight.Appearance.Options.UseBackColor = true;
            this._pnRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnRight.Location = new System.Drawing.Point(15, 95);
            this._pnRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._pnRight.Size = new System.Drawing.Size(1185, 605);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._luTREFERENCE_ID);
            this.layoutControl1.Controls.Add(this._luINOUT_CODE);
            this.layoutControl1.Controls.Add(this._luINOUT_TYPE);
            this.layoutControl1.Controls.Add(this._luINOUT_DATE);
            this.layoutControl1.Controls.Add(this._luVEND);
            this.layoutControl1.Controls.Add(this._luPART);
            this.layoutControl1.Controls.Add(this._luTINOUT_ID);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1200, 95);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _luTREFERENCE_ID
            // 
            this._luTREFERENCE_ID.CancelButton = null;
            this._luTREFERENCE_ID.CommandButton = null;
            this._luTREFERENCE_ID.EditMask = "";
            this._luTREFERENCE_ID.Location = new System.Drawing.Point(1070, 24);
            this._luTREFERENCE_ID.Margin = new System.Windows.Forms.Padding(0);
            this._luTREFERENCE_ID.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luTREFERENCE_ID.Name = "_luTREFERENCE_ID";
            this._luTREFERENCE_ID.NumText = "";
            this._luTREFERENCE_ID.PasswordChar = '\0';
            this._luTREFERENCE_ID.ReadOnly = false;
            this._luTREFERENCE_ID.Size = new System.Drawing.Size(100, 22);
            this._luTREFERENCE_ID.TabIndex = 10;
            this._luTREFERENCE_ID.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luTREFERENCE_ID.UseMaskAsDisplayFormat = false;
            // 
            // _luINOUT_CODE
            // 
            this._luINOUT_CODE.ItemIndex = -1;
            this._luINOUT_CODE.Location = new System.Drawing.Point(811, 50);
            this._luINOUT_CODE.Margin = new System.Windows.Forms.Padding(0);
            this._luINOUT_CODE.Name = "_luINOUT_CODE";
            this._luINOUT_CODE.ReadOnly = false;
            this._luINOUT_CODE.Size = new System.Drawing.Size(100, 21);
            this._luINOUT_CODE.TabIndex = 9;
            // 
            // _luINOUT_TYPE
            // 
            this._luINOUT_TYPE.ItemIndex = -1;
            this._luINOUT_TYPE.Location = new System.Drawing.Point(811, 24);
            this._luINOUT_TYPE.Margin = new System.Windows.Forms.Padding(0);
            this._luINOUT_TYPE.Name = "_luINOUT_TYPE";
            this._luINOUT_TYPE.ReadOnly = false;
            this._luINOUT_TYPE.Size = new System.Drawing.Size(100, 22);
            this._luINOUT_TYPE.TabIndex = 8;
            // 
            // _luINOUT_DATE
            // 
            this._luINOUT_DATE.FromDateTime = new System.DateTime(2018, 4, 1, 0, 0, 0, 0);
            this._luINOUT_DATE.Location = new System.Drawing.Point(84, 24);
            this._luINOUT_DATE.Margin = new System.Windows.Forms.Padding(0);
            this._luINOUT_DATE.Name = "_luINOUT_DATE";
            this._luINOUT_DATE.Size = new System.Drawing.Size(332, 22);
            this._luINOUT_DATE.TabIndex = 4;
            this._luINOUT_DATE.ToDateTime = new System.DateTime(2018, 4, 25, 23, 59, 59, 0);
            // 
            // _luVEND
            // 
            this._luVEND.BackColor = System.Drawing.Color.White;
            this._luVEND.CodeReadOnly = false;
            this._luVEND.CodeText = "";
            this._luVEND.CodeTextName = "_luVEND_CODE";
            this._luVEND.Location = new System.Drawing.Point(474, 24);
            this._luVEND.Name = "_luVEND";
            this._luVEND.NameEnabled = true;
            this._luVEND.NameReadOnly = false;
            this._luVEND.NameText = "";
            this._luVEND.NameTextName = "_luVEND_NAME";
            this._luVEND.Size = new System.Drawing.Size(279, 22);
            this._luVEND.TabIndex = 5;
            this._luVEND._OnOpenClick += new CoFAS_MES.CORE.BaseControls.ucSearchEdit.OnOpenClickEventHandler(this._luVEND__OnOpenClick);
            // 
            // _luPART
            // 
            this._luPART.BackColor = System.Drawing.Color.White;
            this._luPART.CodeReadOnly = false;
            this._luPART.CodeText = "";
            this._luPART.CodeTextName = "_luPART_CODE";
            this._luPART.Location = new System.Drawing.Point(474, 50);
            this._luPART.Name = "_luPART";
            this._luPART.NameEnabled = true;
            this._luPART.NameReadOnly = false;
            this._luPART.NameText = "";
            this._luPART.NameTextName = "_luPART_NAME";
            this._luPART.Size = new System.Drawing.Size(279, 21);
            this._luPART.TabIndex = 4;
            this._luPART._OnOpenClick += new CoFAS_MES.CORE.BaseControls.ucSearchEdit.OnOpenClickEventHandler(this._luPART__OnOpenClick);
            // 
            // _luTINOUT_ID
            // 
            this._luTINOUT_ID.CancelButton = null;
            this._luTINOUT_ID.CommandButton = null;
            this._luTINOUT_ID.EditMask = "";
            this._luTINOUT_ID.Location = new System.Drawing.Point(84, 50);
            this._luTINOUT_ID.Margin = new System.Windows.Forms.Padding(0);
            this._luTINOUT_ID.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luTINOUT_ID.Name = "_luTINOUT_ID";
            this._luTINOUT_ID.NumText = "";
            this._luTINOUT_ID.PasswordChar = '\0';
            this._luTINOUT_ID.ReadOnly = false;
            this._luTINOUT_ID.Size = new System.Drawing.Size(332, 21);
            this._luTINOUT_ID.TabIndex = 7;
            this._luTINOUT_ID.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luTINOUT_ID.UseMaskAsDisplayFormat = false;
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
            this._lciINOUT_DATE,
            this._lciINOUT_ID,
            this._lciPART,
            this._lciINOUT_CODE,
            this._lciINOUT_TYPE,
            this._lciREFERENCE_ID,
            this.emptySpaceItem2,
            this._lciVEND});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(1168, 75);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // _lciINOUT_DATE
            // 
            this._lciINOUT_DATE.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciINOUT_DATE.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciINOUT_DATE.Control = this._luINOUT_DATE;
            this._lciINOUT_DATE.Location = new System.Drawing.Point(0, 0);
            this._lciINOUT_DATE.MaxSize = new System.Drawing.Size(390, 26);
            this._lciINOUT_DATE.MinSize = new System.Drawing.Size(390, 26);
            this._lciINOUT_DATE.Name = "_lciINOUT_DATE";
            this._lciINOUT_DATE.Size = new System.Drawing.Size(390, 26);
            this._lciINOUT_DATE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciINOUT_DATE.Text = "일자";
            this._lciINOUT_DATE.TextSize = new System.Drawing.Size(50, 14);
            // 
            // _lciINOUT_ID
            // 
            this._lciINOUT_ID.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciINOUT_ID.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciINOUT_ID.Control = this._luTINOUT_ID;
            this._lciINOUT_ID.CustomizationFormText = "_lciINOUT_ID";
            this._lciINOUT_ID.Location = new System.Drawing.Point(0, 26);
            this._lciINOUT_ID.MaxSize = new System.Drawing.Size(390, 25);
            this._lciINOUT_ID.MinSize = new System.Drawing.Size(390, 25);
            this._lciINOUT_ID.Name = "_lciINOUT_ID";
            this._lciINOUT_ID.Size = new System.Drawing.Size(390, 25);
            this._lciINOUT_ID.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciINOUT_ID.Text = "입출고번호";
            this._lciINOUT_ID.TextSize = new System.Drawing.Size(50, 14);
            // 
            // _lciPART
            // 
            this._lciPART.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciPART.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciPART.Control = this._luPART;
            this._lciPART.CustomizationFormText = "_lciPART";
            this._lciPART.Location = new System.Drawing.Point(390, 26);
            this._lciPART.MaxSize = new System.Drawing.Size(337, 25);
            this._lciPART.MinSize = new System.Drawing.Size(337, 25);
            this._lciPART.Name = "_lciPART";
            this._lciPART.Size = new System.Drawing.Size(337, 25);
            this._lciPART.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciPART.Text = "제품명";
            this._lciPART.TextSize = new System.Drawing.Size(50, 14);
            // 
            // _lciINOUT_CODE
            // 
            this._lciINOUT_CODE.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciINOUT_CODE.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciINOUT_CODE.Control = this._luINOUT_CODE;
            this._lciINOUT_CODE.Location = new System.Drawing.Point(727, 26);
            this._lciINOUT_CODE.MaxSize = new System.Drawing.Size(158, 25);
            this._lciINOUT_CODE.MinSize = new System.Drawing.Size(158, 25);
            this._lciINOUT_CODE.Name = "_lciINOUT_CODE";
            this._lciINOUT_CODE.Size = new System.Drawing.Size(158, 25);
            this._lciINOUT_CODE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciINOUT_CODE.Text = "입출고코드";
            this._lciINOUT_CODE.TextSize = new System.Drawing.Size(50, 14);
            // 
            // _lciINOUT_TYPE
            // 
            this._lciINOUT_TYPE.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciINOUT_TYPE.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciINOUT_TYPE.Control = this._luINOUT_TYPE;
            this._lciINOUT_TYPE.Location = new System.Drawing.Point(727, 0);
            this._lciINOUT_TYPE.MaxSize = new System.Drawing.Size(158, 26);
            this._lciINOUT_TYPE.MinSize = new System.Drawing.Size(158, 26);
            this._lciINOUT_TYPE.Name = "_lciINOUT_TYPE";
            this._lciINOUT_TYPE.Size = new System.Drawing.Size(158, 26);
            this._lciINOUT_TYPE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciINOUT_TYPE.Text = "입출고구분";
            this._lciINOUT_TYPE.TextSize = new System.Drawing.Size(50, 14);
            // 
            // _lciREFERENCE_ID
            // 
            this._lciREFERENCE_ID.Control = this._luTREFERENCE_ID;
            this._lciREFERENCE_ID.Location = new System.Drawing.Point(885, 0);
            this._lciREFERENCE_ID.MaxSize = new System.Drawing.Size(259, 26);
            this._lciREFERENCE_ID.MinSize = new System.Drawing.Size(259, 26);
            this._lciREFERENCE_ID.Name = "_lciREFERENCE_ID";
            this._lciREFERENCE_ID.Size = new System.Drawing.Size(259, 26);
            this._lciREFERENCE_ID.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciREFERENCE_ID.Text = "_lciREFERENCE_ID_FOR_OWELL";
            this._lciREFERENCE_ID.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this._lciREFERENCE_ID.TextSize = new System.Drawing.Size(150, 14);
            this._lciREFERENCE_ID.TextToControlDistance = 5;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem2.Location = new System.Drawing.Point(885, 26);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(104, 24);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(259, 25);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem2.Text = "emptySpaceItem1";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // _lciVEND
            // 
            this._lciVEND.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciVEND.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciVEND.Control = this._luVEND;
            this._lciVEND.CustomizationFormText = "_lciVEND";
            this._lciVEND.Location = new System.Drawing.Point(390, 0);
            this._lciVEND.MaxSize = new System.Drawing.Size(337, 26);
            this._lciVEND.MinSize = new System.Drawing.Size(337, 26);
            this._lciVEND.Name = "_lciVEND";
            this._lciVEND.Size = new System.Drawing.Size(337, 26);
            this._lciVEND.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciVEND.Text = "거래처명";
            this._lciVEND.TextSize = new System.Drawing.Size(50, 14);
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.dashboardViewer);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(1180, 605);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // dashboardViewer
            // 
            this.dashboardViewer.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.dashboardViewer.Appearance.Options.UseBackColor = true;
            this.dashboardViewer.Location = new System.Drawing.Point(24, 24);
            this.dashboardViewer.Name = "dashboardViewer";
            this.dashboardViewer.Size = new System.Drawing.Size(1132, 557);
            this.dashboardViewer.TabIndex = 5;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup4});
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup2.Size = new System.Drawing.Size(1180, 605);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(1160, 585);
            this.layoutControlGroup4.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dashboardViewer;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1136, 561);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ProductInStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProductInStatus";
            this.Text = "MaterialOrderStatus";
            this.WindowName = "MaterialOrderStatus";
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
            ((System.ComponentModel.ISupportInitialize)(this._lciINOUT_DATE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciINOUT_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPART)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciINOUT_CODE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciINOUT_TYPE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciREFERENCE_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciVEND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private CORE.BaseControls.ucFromToDateEdit _luINOUT_DATE;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem _lciINOUT_DATE;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.DashboardWin.DashboardViewer dashboardViewer;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private CORE.BaseControls.ucSearchEdit _luVEND;
        private CORE.BaseControls.ucSearchEdit _luPART;
        private DevExpress.XtraLayout.LayoutControlItem _lciPART;
        private DevExpress.XtraLayout.LayoutControlItem _lciVEND;
        private CORE.BaseControls.ucTextEdit _luTINOUT_ID;
        private DevExpress.XtraLayout.LayoutControlItem _lciINOUT_ID;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private CORE.BaseControls.ucTextEdit _luTREFERENCE_ID;
        private CORE.BaseControls.ucLookUpEdit _luINOUT_CODE;
        private CORE.BaseControls.ucLookUpEdit _luINOUT_TYPE;
        private DevExpress.XtraLayout.LayoutControlItem _lciINOUT_TYPE;
        private DevExpress.XtraLayout.LayoutControlItem _lciINOUT_CODE;
        private DevExpress.XtraLayout.LayoutControlItem _lciREFERENCE_ID;
    }
}
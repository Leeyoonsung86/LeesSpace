namespace CoFAS_MES.UI.PO
{
    partial class WorkOrdersRegister_T08
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
            this._luTDAYNIGHT = new CoFAS_MES.CORE.BaseControls.ucLookUpEdit();
            this._luTCOMPLETE_YN = new CoFAS_MES.CORE.BaseControls.ucLookUpEdit();
            this._luTWC_CODE = new CoFAS_MES.CORE.BaseControls.ucLookUpEdit();
            this._luTUSE_YN = new CoFAS_MES.CORE.BaseControls.ucLookUpEdit();
            this._luTWORK_ORDER = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luTPART_ALL = new CoFAS_MES.CORE.BaseControls.ucSearchEdit();
            this._luTORDER_DATE = new CoFAS_MES.CORE.BaseControls.ucFromToDateEdit();
            this._luTTERMINAL_CODE = new CoFAS_MES.CORE.BaseControls.ucLookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this._lciTPART_NAME = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciTWC_CODE = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciTORDER_DATE = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciTWORK_ORDER = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciTCOMPLETE_YN = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciTUSE_YN = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem10 = new DevExpress.XtraLayout.EmptySpaceItem();
            this._lciTTERMINAL_CODE = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciTDAYNIGHT = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this._gdMAIN = new DevExpress.XtraGrid.GridControl();
            this._gdMAIN_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTPART_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTWC_CODE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTORDER_DATE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTWORK_ORDER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTCOMPLETE_YN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTUSE_YN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTTERMINAL_CODE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTDAYNIGHT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
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
            this.layoutControl1.Controls.Add(this._luTDAYNIGHT);
            this.layoutControl1.Controls.Add(this._luTCOMPLETE_YN);
            this.layoutControl1.Controls.Add(this._luTWC_CODE);
            this.layoutControl1.Controls.Add(this._luTUSE_YN);
            this.layoutControl1.Controls.Add(this._luTWORK_ORDER);
            this.layoutControl1.Controls.Add(this._luTPART_ALL);
            this.layoutControl1.Controls.Add(this._luTORDER_DATE);
            this.layoutControl1.Controls.Add(this._luTTERMINAL_CODE);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(297, 203, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1200, 95);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _luTDAYNIGHT
            // 
            this._luTDAYNIGHT.ItemIndex = -1;
            this._luTDAYNIGHT.Location = new System.Drawing.Point(1038, 51);
            this._luTDAYNIGHT.Margin = new System.Windows.Forms.Padding(0);
            this._luTDAYNIGHT.Name = "_luTDAYNIGHT";
            this._luTDAYNIGHT.ReadOnly = false;
            this._luTDAYNIGHT.Size = new System.Drawing.Size(105, 23);
            this._luTDAYNIGHT.TabIndex = 20;
            // 
            // _luTCOMPLETE_YN
            // 
            this._luTCOMPLETE_YN.ItemIndex = -1;
            this._luTCOMPLETE_YN.Location = new System.Drawing.Point(593, 51);
            this._luTCOMPLETE_YN.Margin = new System.Windows.Forms.Padding(0);
            this._luTCOMPLETE_YN.Name = "_luTCOMPLETE_YN";
            this._luTCOMPLETE_YN.ReadOnly = false;
            this._luTCOMPLETE_YN.Size = new System.Drawing.Size(105, 23);
            this._luTCOMPLETE_YN.TabIndex = 19;
            // 
            // _luTWC_CODE
            // 
            this._luTWC_CODE.ItemIndex = -1;
            this._luTWC_CODE.Location = new System.Drawing.Point(818, 24);
            this._luTWC_CODE.Margin = new System.Windows.Forms.Padding(0);
            this._luTWC_CODE.Name = "_luTWC_CODE";
            this._luTWC_CODE.ReadOnly = false;
            this._luTWC_CODE.Size = new System.Drawing.Size(100, 20);
            this._luTWC_CODE.TabIndex = 17;
            // 
            // _luTUSE_YN
            // 
            this._luTUSE_YN.ItemIndex = -1;
            this._luTUSE_YN.Location = new System.Drawing.Point(818, 51);
            this._luTUSE_YN.Margin = new System.Windows.Forms.Padding(0);
            this._luTUSE_YN.Name = "_luTUSE_YN";
            this._luTUSE_YN.ReadOnly = false;
            this._luTUSE_YN.Size = new System.Drawing.Size(100, 23);
            this._luTUSE_YN.TabIndex = 16;
            // 
            // _luTWORK_ORDER
            // 
            this._luTWORK_ORDER.CancelButton = null;
            this._luTWORK_ORDER.CommandButton = null;
            this._luTWORK_ORDER.EditMask = "";
            this._luTWORK_ORDER.Location = new System.Drawing.Point(593, 24);
            this._luTWORK_ORDER.Margin = new System.Windows.Forms.Padding(0);
            this._luTWORK_ORDER.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luTWORK_ORDER.Name = "_luTWORK_ORDER";
            this._luTWORK_ORDER.NumText = "";
            this._luTWORK_ORDER.PasswordChar = '\0';
            this._luTWORK_ORDER.ReadOnly = false;
            this._luTWORK_ORDER.Size = new System.Drawing.Size(105, 23);
            this._luTWORK_ORDER.TabIndex = 11;
            this._luTWORK_ORDER.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luTWORK_ORDER.UseMaskAsDisplayFormat = false;
            // 
            // _luTPART_ALL
            // 
            this._luTPART_ALL.BackColor = System.Drawing.Color.Transparent;
            this._luTPART_ALL.CodeReadOnly = false;
            this._luTPART_ALL.CodeText = "";
            this._luTPART_ALL.CodeTextName = "_luTPART_CODE";
            this._luTPART_ALL.Location = new System.Drawing.Point(146, 51);
            this._luTPART_ALL.Name = "_luTPART_ALL";
            this._luTPART_ALL.NameEnabled = true;
            this._luTPART_ALL.NameReadOnly = false;
            this._luTPART_ALL.NameText = "";
            this._luTPART_ALL.NameTextName = "_luTPART_NAME";
            this._luTPART_ALL.Size = new System.Drawing.Size(327, 23);
            this._luTPART_ALL.TabIndex = 10;
            this._luTPART_ALL._OnButtonPressed += new CoFAS_MES.CORE.BaseControls.ucSearchEdit.OnButtonPressedEventHandler(this._luTPART_ALL__OnButtonPressed);
            // 
            // _luTORDER_DATE
            // 
            this._luTORDER_DATE.FromDateTime = new System.DateTime(2018, 7, 1, 0, 0, 0, 0);
            this._luTORDER_DATE.Location = new System.Drawing.Point(146, 24);
            this._luTORDER_DATE.Margin = new System.Windows.Forms.Padding(0);
            this._luTORDER_DATE.Name = "_luTORDER_DATE";
            this._luTORDER_DATE.Size = new System.Drawing.Size(327, 20);
            this._luTORDER_DATE.TabIndex = 9;
            this._luTORDER_DATE.ToDateTime = new System.DateTime(2018, 7, 2, 23, 59, 59, 0);
            // 
            // _luTTERMINAL_CODE
            // 
            this._luTTERMINAL_CODE.ItemIndex = -1;
            this._luTTERMINAL_CODE.Location = new System.Drawing.Point(1038, 24);
            this._luTTERMINAL_CODE.Margin = new System.Windows.Forms.Padding(0);
            this._luTTERMINAL_CODE.Name = "_luTTERMINAL_CODE";
            this._luTTERMINAL_CODE.ReadOnly = false;
            this._luTTERMINAL_CODE.Size = new System.Drawing.Size(105, 23);
            this._luTTERMINAL_CODE.TabIndex = 17;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup4});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(16, 16, 10, 10);
            this.layoutControlGroup1.Size = new System.Drawing.Size(1183, 98);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this._lciTPART_NAME,
            this._lciTWC_CODE,
            this._lciTORDER_DATE,
            this._lciTWORK_ORDER,
            this._lciTCOMPLETE_YN,
            this._lciTUSE_YN,
            this.emptySpaceItem2,
            this.emptySpaceItem10,
            this._lciTTERMINAL_CODE,
            this._lciTDAYNIGHT});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(1151, 78);
            this.layoutControlGroup4.TextVisible = false;
            // 
            // _lciTPART_NAME
            // 
            this._lciTPART_NAME.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciTPART_NAME.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciTPART_NAME.Control = this._luTPART_ALL;
            this._lciTPART_NAME.Location = new System.Drawing.Point(0, 27);
            this._lciTPART_NAME.MaxSize = new System.Drawing.Size(447, 27);
            this._lciTPART_NAME.MinSize = new System.Drawing.Size(447, 27);
            this._lciTPART_NAME.Name = "_lciTPART_NAME";
            this._lciTPART_NAME.Size = new System.Drawing.Size(447, 27);
            this._lciTPART_NAME.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciTPART_NAME.TextSize = new System.Drawing.Size(112, 14);
            // 
            // _lciTWC_CODE
            // 
            this._lciTWC_CODE.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciTWC_CODE.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciTWC_CODE.Control = this._luTWC_CODE;
            this._lciTWC_CODE.Location = new System.Drawing.Point(672, 0);
            this._lciTWC_CODE.MaxSize = new System.Drawing.Size(220, 24);
            this._lciTWC_CODE.MinSize = new System.Drawing.Size(220, 24);
            this._lciTWC_CODE.Name = "_lciTWC_CODE";
            this._lciTWC_CODE.Size = new System.Drawing.Size(220, 27);
            this._lciTWC_CODE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciTWC_CODE.TextSize = new System.Drawing.Size(112, 14);
            // 
            // _lciTORDER_DATE
            // 
            this._lciTORDER_DATE.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciTORDER_DATE.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciTORDER_DATE.Control = this._luTORDER_DATE;
            this._lciTORDER_DATE.Location = new System.Drawing.Point(0, 0);
            this._lciTORDER_DATE.MaxSize = new System.Drawing.Size(447, 24);
            this._lciTORDER_DATE.MinSize = new System.Drawing.Size(447, 24);
            this._lciTORDER_DATE.Name = "_lciTORDER_DATE";
            this._lciTORDER_DATE.Size = new System.Drawing.Size(447, 27);
            this._lciTORDER_DATE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciTORDER_DATE.TextSize = new System.Drawing.Size(112, 14);
            // 
            // _lciTWORK_ORDER
            // 
            this._lciTWORK_ORDER.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciTWORK_ORDER.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciTWORK_ORDER.Control = this._luTWORK_ORDER;
            this._lciTWORK_ORDER.Location = new System.Drawing.Point(447, 0);
            this._lciTWORK_ORDER.MaxSize = new System.Drawing.Size(225, 27);
            this._lciTWORK_ORDER.MinSize = new System.Drawing.Size(225, 27);
            this._lciTWORK_ORDER.Name = "_lciTWORK_ORDER";
            this._lciTWORK_ORDER.Size = new System.Drawing.Size(225, 27);
            this._lciTWORK_ORDER.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciTWORK_ORDER.TextSize = new System.Drawing.Size(112, 14);
            // 
            // _lciTCOMPLETE_YN
            // 
            this._lciTCOMPLETE_YN.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciTCOMPLETE_YN.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciTCOMPLETE_YN.Control = this._luTCOMPLETE_YN;
            this._lciTCOMPLETE_YN.Location = new System.Drawing.Point(447, 27);
            this._lciTCOMPLETE_YN.MaxSize = new System.Drawing.Size(225, 27);
            this._lciTCOMPLETE_YN.MinSize = new System.Drawing.Size(225, 27);
            this._lciTCOMPLETE_YN.Name = "_lciTCOMPLETE_YN";
            this._lciTCOMPLETE_YN.Size = new System.Drawing.Size(225, 27);
            this._lciTCOMPLETE_YN.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciTCOMPLETE_YN.TextSize = new System.Drawing.Size(112, 14);
            // 
            // _lciTUSE_YN
            // 
            this._lciTUSE_YN.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciTUSE_YN.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciTUSE_YN.Control = this._luTUSE_YN;
            this._lciTUSE_YN.Location = new System.Drawing.Point(672, 27);
            this._lciTUSE_YN.MaxSize = new System.Drawing.Size(220, 27);
            this._lciTUSE_YN.MinSize = new System.Drawing.Size(220, 27);
            this._lciTUSE_YN.Name = "_lciTUSE_YN";
            this._lciTUSE_YN.Size = new System.Drawing.Size(220, 27);
            this._lciTUSE_YN.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciTUSE_YN.TextSize = new System.Drawing.Size(112, 14);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(1117, 0);
            this.emptySpaceItem2.MaxSize = new System.Drawing.Size(10, 27);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(10, 27);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(10, 27);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem10
            // 
            this.emptySpaceItem10.AllowHotTrack = false;
            this.emptySpaceItem10.Location = new System.Drawing.Point(1117, 27);
            this.emptySpaceItem10.MaxSize = new System.Drawing.Size(10, 27);
            this.emptySpaceItem10.MinSize = new System.Drawing.Size(10, 27);
            this.emptySpaceItem10.Name = "emptySpaceItem10";
            this.emptySpaceItem10.Size = new System.Drawing.Size(10, 27);
            this.emptySpaceItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem10.TextSize = new System.Drawing.Size(0, 0);
            // 
            // _lciTTERMINAL_CODE
            // 
            this._lciTTERMINAL_CODE.Control = this._luTTERMINAL_CODE;
            this._lciTTERMINAL_CODE.CustomizationFormText = "_lciTERMINAL_CODE";
            this._lciTTERMINAL_CODE.Location = new System.Drawing.Point(892, 0);
            this._lciTTERMINAL_CODE.MaxSize = new System.Drawing.Size(225, 27);
            this._lciTTERMINAL_CODE.MinSize = new System.Drawing.Size(225, 27);
            this._lciTTERMINAL_CODE.Name = "_lciTTERMINAL_CODE";
            this._lciTTERMINAL_CODE.Size = new System.Drawing.Size(225, 27);
            this._lciTTERMINAL_CODE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciTTERMINAL_CODE.Text = "_lciTERMINAL_CODE";
            this._lciTTERMINAL_CODE.TextSize = new System.Drawing.Size(112, 14);
            // 
            // _lciTDAYNIGHT
            // 
            this._lciTDAYNIGHT.Control = this._luTDAYNIGHT;
            this._lciTDAYNIGHT.Location = new System.Drawing.Point(892, 27);
            this._lciTDAYNIGHT.Name = "_lciTDAYNIGHT";
            this._lciTDAYNIGHT.Size = new System.Drawing.Size(225, 27);
            this._lciTDAYNIGHT.TextSize = new System.Drawing.Size(112, 14);
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this._gdMAIN);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(2660, 229, 650, 400);
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(1180, 605);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // _gdMAIN
            // 
            this._gdMAIN.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gdMAIN.Location = new System.Drawing.Point(12, 12);
            this._gdMAIN.MainView = this._gdMAIN_VIEW;
            this._gdMAIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gdMAIN.Name = "_gdMAIN";
            this._gdMAIN.Size = new System.Drawing.Size(1156, 581);
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
            this.layoutControlItem5});
            this.layoutControlGroup2.Name = "Root";
            this.layoutControlGroup2.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup2.Size = new System.Drawing.Size(1180, 605);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this._gdMAIN;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(1160, 585);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // WorkOrdersRegister_T08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "WorkOrdersRegister_T08";
            this.Text = "WorkOrdersRegister_T08";
            this.WindowName = "WorkOrdersRegister_T08";
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
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTPART_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTWC_CODE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTORDER_DATE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTWORK_ORDER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTCOMPLETE_YN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTUSE_YN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTTERMINAL_CODE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTDAYNIGHT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraGrid.GridControl _gdMAIN;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdMAIN_VIEW;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private CORE.BaseControls.ucSearchEdit _luTPART_ALL;
        private CORE.BaseControls.ucFromToDateEdit _luTORDER_DATE;
        private DevExpress.XtraLayout.LayoutControlItem _lciTORDER_DATE;
        private DevExpress.XtraLayout.LayoutControlItem _lciTPART_NAME;
        private CORE.BaseControls.ucTextEdit _luTWORK_ORDER;
        private DevExpress.XtraLayout.LayoutControlItem _lciTWORK_ORDER;
        private CORE.BaseControls.ucLookUpEdit _luTUSE_YN;
        private DevExpress.XtraLayout.LayoutControlItem _lciTUSE_YN;
        private CORE.BaseControls.ucLookUpEdit _luTWC_CODE;
        private DevExpress.XtraLayout.LayoutControlItem _lciTWC_CODE;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private CORE.BaseControls.ucLookUpEdit _luTCOMPLETE_YN;
        private DevExpress.XtraLayout.LayoutControlItem _lciTCOMPLETE_YN;
        private CORE.BaseControls.ucLookUpEdit _luTTERMINAL_CODE;
        private DevExpress.XtraLayout.LayoutControlItem _lciTTERMINAL_CODE;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem10;
        private CORE.BaseControls.ucLookUpEdit _luTDAYNIGHT;
        private DevExpress.XtraLayout.LayoutControlItem _lciTDAYNIGHT;
    }
}
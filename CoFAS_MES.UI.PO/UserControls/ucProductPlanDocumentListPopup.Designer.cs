namespace CoFAS_MES.UI.PO.UserControls
{
    partial class ucProductPlanDocumentListPopup
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this._ucbtMOVE = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._luDOCUMENT_USE_YN = new CoFAS_MES.CORE.BaseControls.ucLookUpEdit();
            this._luUSE_YN = new CoFAS_MES.CORE.BaseControls.ucLookUpEdit();
            this._luCONTRACT_NUMBER = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luCONTRACT_ID = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._ucbtDOCUMENT_SELECT = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._luDOCUMENT_TYPE = new CoFAS_MES.CORE.BaseControls.ucLookUpEdit();
            this._luDOCUMENT_VER = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luDOCUMENT_NAME = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._gdSUB = new DevExpress.XtraGrid.GridControl();
            this._gdSUB_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._ucbtCANCLE = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._luORDER_REVISION = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._gdMAIN = new DevExpress.XtraGrid.GridControl();
            this._gdMAIN_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._ucbtSELECT = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._ucbtSAVE = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._luORDER_NUMBER = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this._lciORDER_REVISION = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciCONTRACT_ID = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciUSE_YN = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciORDER_NUMBER = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this._lciDOCUMENT_NAME = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciDOCUMENT_VER = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciDOCUMENT_TYPE = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciCONTRACT_NUMBER = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciDOCUMENT_USE_YN = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this._luPRODUCT_PLAN_ID = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciORDER_REVISION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCONTRACT_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciUSE_YN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciORDER_NUMBER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciDOCUMENT_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciDOCUMENT_VER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciDOCUMENT_TYPE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCONTRACT_NUMBER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciDOCUMENT_USE_YN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._luPRODUCT_PLAN_ID);
            this.layoutControl1.Controls.Add(this._ucbtMOVE);
            this.layoutControl1.Controls.Add(this._luDOCUMENT_USE_YN);
            this.layoutControl1.Controls.Add(this._luUSE_YN);
            this.layoutControl1.Controls.Add(this._luCONTRACT_NUMBER);
            this.layoutControl1.Controls.Add(this._luCONTRACT_ID);
            this.layoutControl1.Controls.Add(this._ucbtDOCUMENT_SELECT);
            this.layoutControl1.Controls.Add(this._luDOCUMENT_TYPE);
            this.layoutControl1.Controls.Add(this._luDOCUMENT_VER);
            this.layoutControl1.Controls.Add(this._luDOCUMENT_NAME);
            this.layoutControl1.Controls.Add(this._gdSUB);
            this.layoutControl1.Controls.Add(this._ucbtCANCLE);
            this.layoutControl1.Controls.Add(this._luORDER_REVISION);
            this.layoutControl1.Controls.Add(this._gdMAIN);
            this.layoutControl1.Controls.Add(this._ucbtSELECT);
            this.layoutControl1.Controls.Add(this._ucbtSAVE);
            this.layoutControl1.Controls.Add(this._luORDER_NUMBER);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1047, 248, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(873, 526);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _ucbtMOVE
            // 
            this._ucbtMOVE.ButtonText = "<";
            this._ucbtMOVE.Image = null;
            this._ucbtMOVE.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this._ucbtMOVE.Location = new System.Drawing.Point(426, 187);
            this._ucbtMOVE.Name = "_ucbtMOVE";
            this._ucbtMOVE.Size = new System.Drawing.Size(21, 277);
            this._ucbtMOVE.TabIndex = 23;
            this._ucbtMOVE.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtMOVE_Click);
            // 
            // _luDOCUMENT_USE_YN
            // 
            this._luDOCUMENT_USE_YN.ItemIndex = -1;
            this._luDOCUMENT_USE_YN.Location = new System.Drawing.Point(599, 96);
            this._luDOCUMENT_USE_YN.Margin = new System.Windows.Forms.Padding(0);
            this._luDOCUMENT_USE_YN.Name = "_luDOCUMENT_USE_YN";
            this._luDOCUMENT_USE_YN.ReadOnly = false;
            this._luDOCUMENT_USE_YN.Size = new System.Drawing.Size(250, 21);
            this._luDOCUMENT_USE_YN.TabIndex = 22;
            // 
            // _luUSE_YN
            // 
            this._luUSE_YN.ItemIndex = -1;
            this._luUSE_YN.Location = new System.Drawing.Point(160, 72);
            this._luUSE_YN.Margin = new System.Windows.Forms.Padding(0);
            this._luUSE_YN.Name = "_luUSE_YN";
            this._luUSE_YN.ReadOnly = false;
            this._luUSE_YN.Size = new System.Drawing.Size(250, 21);
            this._luUSE_YN.TabIndex = 21;
            // 
            // _luCONTRACT_NUMBER
            // 
            this._luCONTRACT_NUMBER.CancelButton = null;
            this._luCONTRACT_NUMBER.CommandButton = null;
            this._luCONTRACT_NUMBER.EditMask = "";
            this._luCONTRACT_NUMBER.Location = new System.Drawing.Point(599, 24);
            this._luCONTRACT_NUMBER.Margin = new System.Windows.Forms.Padding(0);
            this._luCONTRACT_NUMBER.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luCONTRACT_NUMBER.Name = "_luCONTRACT_NUMBER";
            this._luCONTRACT_NUMBER.PasswordChar = '\0';
            this._luCONTRACT_NUMBER.ReadOnly = false;
            this._luCONTRACT_NUMBER.Size = new System.Drawing.Size(250, 20);
            this._luCONTRACT_NUMBER.TabIndex = 20;
            this._luCONTRACT_NUMBER.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luCONTRACT_NUMBER.UseMaskAsDisplayFormat = false;
            // 
            // _luCONTRACT_ID
            // 
            this._luCONTRACT_ID.CancelButton = null;
            this._luCONTRACT_ID.CommandButton = null;
            this._luCONTRACT_ID.EditMask = "";
            this._luCONTRACT_ID.Location = new System.Drawing.Point(24, 97);
            this._luCONTRACT_ID.Margin = new System.Windows.Forms.Padding(0);
            this._luCONTRACT_ID.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luCONTRACT_ID.Name = "_luCONTRACT_ID";
            this._luCONTRACT_ID.PasswordChar = '\0';
            this._luCONTRACT_ID.ReadOnly = false;
            this._luCONTRACT_ID.Size = new System.Drawing.Size(386, 20);
            this._luCONTRACT_ID.TabIndex = 19;
            this._luCONTRACT_ID.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luCONTRACT_ID.UseMaskAsDisplayFormat = false;
            this._luCONTRACT_ID.Visible = false;
            // 
            // _ucbtDOCUMENT_SELECT
            // 
            this._ucbtDOCUMENT_SELECT.ButtonText = "조회";
            this._ucbtDOCUMENT_SELECT.Image = global::CoFAS_MES.UI.PO.Properties.Resources.zoom_16x16;
            this._ucbtDOCUMENT_SELECT.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtDOCUMENT_SELECT.Location = new System.Drawing.Point(463, 145);
            this._ucbtDOCUMENT_SELECT.Name = "_ucbtDOCUMENT_SELECT";
            this._ucbtDOCUMENT_SELECT.Size = new System.Drawing.Size(386, 26);
            this._ucbtDOCUMENT_SELECT.TabIndex = 18;
            this._ucbtDOCUMENT_SELECT.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtDOCUMENT_SELECT_Click);
            // 
            // _luDOCUMENT_TYPE
            // 
            this._luDOCUMENT_TYPE.ItemIndex = -1;
            this._luDOCUMENT_TYPE.Location = new System.Drawing.Point(599, 48);
            this._luDOCUMENT_TYPE.Margin = new System.Windows.Forms.Padding(0);
            this._luDOCUMENT_TYPE.Name = "_luDOCUMENT_TYPE";
            this._luDOCUMENT_TYPE.ReadOnly = false;
            this._luDOCUMENT_TYPE.Size = new System.Drawing.Size(250, 20);
            this._luDOCUMENT_TYPE.TabIndex = 17;
            // 
            // _luDOCUMENT_VER
            // 
            this._luDOCUMENT_VER.CancelButton = null;
            this._luDOCUMENT_VER.CommandButton = null;
            this._luDOCUMENT_VER.EditMask = "";
            this._luDOCUMENT_VER.Location = new System.Drawing.Point(463, 121);
            this._luDOCUMENT_VER.Margin = new System.Windows.Forms.Padding(0);
            this._luDOCUMENT_VER.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luDOCUMENT_VER.Name = "_luDOCUMENT_VER";
            this._luDOCUMENT_VER.PasswordChar = '\0';
            this._luDOCUMENT_VER.ReadOnly = false;
            this._luDOCUMENT_VER.Size = new System.Drawing.Size(386, 20);
            this._luDOCUMENT_VER.TabIndex = 16;
            this._luDOCUMENT_VER.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luDOCUMENT_VER.UseMaskAsDisplayFormat = false;
            this._luDOCUMENT_VER.Visible = false;
            // 
            // _luDOCUMENT_NAME
            // 
            this._luDOCUMENT_NAME.CancelButton = null;
            this._luDOCUMENT_NAME.CommandButton = null;
            this._luDOCUMENT_NAME.EditMask = "";
            this._luDOCUMENT_NAME.Location = new System.Drawing.Point(599, 72);
            this._luDOCUMENT_NAME.Margin = new System.Windows.Forms.Padding(0);
            this._luDOCUMENT_NAME.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luDOCUMENT_NAME.Name = "_luDOCUMENT_NAME";
            this._luDOCUMENT_NAME.PasswordChar = '\0';
            this._luDOCUMENT_NAME.ReadOnly = false;
            this._luDOCUMENT_NAME.Size = new System.Drawing.Size(250, 20);
            this._luDOCUMENT_NAME.TabIndex = 15;
            this._luDOCUMENT_NAME.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luDOCUMENT_NAME.UseMaskAsDisplayFormat = false;
            // 
            // _gdSUB
            // 
            this._gdSUB.Location = new System.Drawing.Point(463, 199);
            this._gdSUB.MainView = this._gdSUB_VIEW;
            this._gdSUB.Name = "_gdSUB";
            this._gdSUB.Size = new System.Drawing.Size(386, 253);
            this._gdSUB.TabIndex = 14;
            this._gdSUB.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gdSUB_VIEW});
            // 
            // _gdSUB_VIEW
            // 
            this._gdSUB_VIEW.GridControl = this._gdSUB;
            this._gdSUB_VIEW.Name = "_gdSUB_VIEW";
            // 
            // _ucbtCANCLE
            // 
            this._ucbtCANCLE.ButtonText = "닫기";
            this._ucbtCANCLE.Image = global::CoFAS_MES.UI.PO.Properties.Resources.close_16x16;
            this._ucbtCANCLE.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtCANCLE.Location = new System.Drawing.Point(646, 480);
            this._ucbtCANCLE.Name = "_ucbtCANCLE";
            this._ucbtCANCLE.Size = new System.Drawing.Size(203, 22);
            this._ucbtCANCLE.TabIndex = 6;
            this._ucbtCANCLE.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._btCancle_Click);
            // 
            // _luORDER_REVISION
            // 
            this._luORDER_REVISION.CancelButton = null;
            this._luORDER_REVISION.CommandButton = null;
            this._luORDER_REVISION.EditMask = "";
            this._luORDER_REVISION.Location = new System.Drawing.Point(160, 48);
            this._luORDER_REVISION.Margin = new System.Windows.Forms.Padding(0);
            this._luORDER_REVISION.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luORDER_REVISION.Name = "_luORDER_REVISION";
            this._luORDER_REVISION.PasswordChar = '\0';
            this._luORDER_REVISION.ReadOnly = true;
            this._luORDER_REVISION.Size = new System.Drawing.Size(250, 20);
            this._luORDER_REVISION.TabIndex = 11;
            this._luORDER_REVISION.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luORDER_REVISION.UseMaskAsDisplayFormat = false;
            // 
            // _gdMAIN
            // 
            this._gdMAIN.Location = new System.Drawing.Point(24, 199);
            this._gdMAIN.MainView = this._gdMAIN_VIEW;
            this._gdMAIN.Name = "_gdMAIN";
            this._gdMAIN.Size = new System.Drawing.Size(386, 253);
            this._gdMAIN.TabIndex = 10;
            this._gdMAIN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gdMAIN_VIEW});
            // 
            // _gdMAIN_VIEW
            // 
            this._gdMAIN_VIEW.GridControl = this._gdMAIN;
            this._gdMAIN_VIEW.Name = "_gdMAIN_VIEW";
            // 
            // _ucbtSELECT
            // 
            this._ucbtSELECT.ButtonText = "조회";
            this._ucbtSELECT.Image = global::CoFAS_MES.UI.PO.Properties.Resources.zoom_16x16;
            this._ucbtSELECT.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtSELECT.Location = new System.Drawing.Point(24, 145);
            this._ucbtSELECT.Name = "_ucbtSELECT";
            this._ucbtSELECT.Size = new System.Drawing.Size(386, 26);
            this._ucbtSELECT.TabIndex = 8;
            this._ucbtSELECT.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._btSELECT_Click);
            // 
            // _ucbtSAVE
            // 
            this._ucbtSAVE.ButtonText = "저장";
            this._ucbtSAVE.Image = global::CoFAS_MES.UI.PO.Properties.Resources.save_16x16;
            this._ucbtSAVE.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtSAVE.Location = new System.Drawing.Point(438, 480);
            this._ucbtSAVE.Name = "_ucbtSAVE";
            this._ucbtSAVE.Size = new System.Drawing.Size(204, 22);
            this._ucbtSAVE.TabIndex = 7;
            this._ucbtSAVE.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._btSAVE_Click);
            // 
            // _luORDER_NUMBER
            // 
            this._luORDER_NUMBER.CancelButton = null;
            this._luORDER_NUMBER.CommandButton = null;
            this._luORDER_NUMBER.EditMask = "";
            this._luORDER_NUMBER.Location = new System.Drawing.Point(160, 24);
            this._luORDER_NUMBER.Margin = new System.Windows.Forms.Padding(0);
            this._luORDER_NUMBER.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luORDER_NUMBER.Name = "_luORDER_NUMBER";
            this._luORDER_NUMBER.PasswordChar = '\0';
            this._luORDER_NUMBER.ReadOnly = true;
            this._luORDER_NUMBER.Size = new System.Drawing.Size(250, 20);
            this._luORDER_NUMBER.TabIndex = 5;
            this._luORDER_NUMBER.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luORDER_NUMBER.UseMaskAsDisplayFormat = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3,
            this.layoutControlGroup2,
            this.layoutControlGroup4,
            this.layoutControlGroup5,
            this.layoutControlGroup6,
            this.layoutControlItem8});
            this.layoutControlGroup1.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.layoutControlGroup1.Name = "Root";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition1.Width = 50D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition2.Width = 25D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition3.Width = 50D;
            this.layoutControlGroup1.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3});
            rowDefinition1.Height = 175D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition2.Height = 281D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.AutoSize;
            rowDefinition3.Height = 50D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            this.layoutControlGroup1.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3});
            this.layoutControlGroup1.Size = new System.Drawing.Size(873, 526);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.emptySpaceItem2});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 456);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlGroup3.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlGroup3.Size = new System.Drawing.Size(853, 50);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this._ucbtSAVE;
            this.layoutControlItem4.Location = new System.Drawing.Point(414, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem4.Size = new System.Drawing.Size(208, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this._ucbtCANCLE;
            this.layoutControlItem3.Location = new System.Drawing.Point(622, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(207, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(414, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this._lciORDER_REVISION,
            this.layoutControlItem5,
            this._lciCONTRACT_ID,
            this._lciUSE_YN,
            this._lciORDER_NUMBER,
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(414, 175);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // _lciORDER_REVISION
            // 
            this._lciORDER_REVISION.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciORDER_REVISION.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciORDER_REVISION.Control = this._luORDER_REVISION;
            this._lciORDER_REVISION.Location = new System.Drawing.Point(0, 24);
            this._lciORDER_REVISION.Name = "_lciORDER_REVISION";
            this._lciORDER_REVISION.Size = new System.Drawing.Size(390, 24);
            this._lciORDER_REVISION.TextSize = new System.Drawing.Size(133, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this._ucbtSELECT;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 121);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(390, 30);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // _lciCONTRACT_ID
            // 
            this._lciCONTRACT_ID.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciCONTRACT_ID.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciCONTRACT_ID.Control = this._luCONTRACT_ID;
            this._lciCONTRACT_ID.Location = new System.Drawing.Point(0, 73);
            this._lciCONTRACT_ID.Name = "_lciCONTRACT_ID";
            this._lciCONTRACT_ID.Size = new System.Drawing.Size(390, 24);
            this._lciCONTRACT_ID.Text = " ";
            this._lciCONTRACT_ID.TextSize = new System.Drawing.Size(0, 0);
            this._lciCONTRACT_ID.TextVisible = false;
            // 
            // _lciUSE_YN
            // 
            this._lciUSE_YN.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciUSE_YN.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciUSE_YN.Control = this._luUSE_YN;
            this._lciUSE_YN.Location = new System.Drawing.Point(0, 48);
            this._lciUSE_YN.Name = "_lciUSE_YN";
            this._lciUSE_YN.Size = new System.Drawing.Size(390, 25);
            this._lciUSE_YN.TextSize = new System.Drawing.Size(133, 14);
            // 
            // _lciORDER_NUMBER
            // 
            this._lciORDER_NUMBER.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciORDER_NUMBER.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciORDER_NUMBER.Control = this._luORDER_NUMBER;
            this._lciORDER_NUMBER.Location = new System.Drawing.Point(0, 0);
            this._lciORDER_NUMBER.Name = "_lciORDER_NUMBER";
            this._lciORDER_NUMBER.Size = new System.Drawing.Size(390, 24);
            this._lciORDER_NUMBER.TextSize = new System.Drawing.Size(133, 14);
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this._lciDOCUMENT_NAME,
            this._lciDOCUMENT_VER,
            this._lciDOCUMENT_TYPE,
            this.layoutControlItem11,
            this._lciCONTRACT_NUMBER,
            this._lciDOCUMENT_USE_YN});
            this.layoutControlGroup4.Location = new System.Drawing.Point(439, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlGroup4.Size = new System.Drawing.Size(414, 175);
            this.layoutControlGroup4.TextVisible = false;
            // 
            // _lciDOCUMENT_NAME
            // 
            this._lciDOCUMENT_NAME.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciDOCUMENT_NAME.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciDOCUMENT_NAME.Control = this._luDOCUMENT_NAME;
            this._lciDOCUMENT_NAME.Location = new System.Drawing.Point(0, 48);
            this._lciDOCUMENT_NAME.Name = "_lciDOCUMENT_NAME";
            this._lciDOCUMENT_NAME.OptionsTableLayoutItem.ColumnIndex = 1;
            this._lciDOCUMENT_NAME.Size = new System.Drawing.Size(390, 24);
            this._lciDOCUMENT_NAME.TextSize = new System.Drawing.Size(133, 14);
            // 
            // _lciDOCUMENT_VER
            // 
            this._lciDOCUMENT_VER.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciDOCUMENT_VER.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciDOCUMENT_VER.Control = this._luDOCUMENT_VER;
            this._lciDOCUMENT_VER.Location = new System.Drawing.Point(0, 97);
            this._lciDOCUMENT_VER.Name = "_lciDOCUMENT_VER";
            this._lciDOCUMENT_VER.Size = new System.Drawing.Size(390, 24);
            this._lciDOCUMENT_VER.TextSize = new System.Drawing.Size(0, 0);
            this._lciDOCUMENT_VER.TextVisible = false;
            // 
            // _lciDOCUMENT_TYPE
            // 
            this._lciDOCUMENT_TYPE.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciDOCUMENT_TYPE.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciDOCUMENT_TYPE.Control = this._luDOCUMENT_TYPE;
            this._lciDOCUMENT_TYPE.Location = new System.Drawing.Point(0, 24);
            this._lciDOCUMENT_TYPE.Name = "_lciDOCUMENT_TYPE";
            this._lciDOCUMENT_TYPE.Size = new System.Drawing.Size(390, 24);
            this._lciDOCUMENT_TYPE.TextSize = new System.Drawing.Size(133, 14);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this._ucbtDOCUMENT_SELECT;
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 121);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(390, 30);
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // _lciCONTRACT_NUMBER
            // 
            this._lciCONTRACT_NUMBER.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciCONTRACT_NUMBER.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciCONTRACT_NUMBER.Control = this._luCONTRACT_NUMBER;
            this._lciCONTRACT_NUMBER.Location = new System.Drawing.Point(0, 0);
            this._lciCONTRACT_NUMBER.Name = "_lciCONTRACT_NUMBER";
            this._lciCONTRACT_NUMBER.Size = new System.Drawing.Size(390, 24);
            this._lciCONTRACT_NUMBER.TextSize = new System.Drawing.Size(133, 14);
            // 
            // _lciDOCUMENT_USE_YN
            // 
            this._lciDOCUMENT_USE_YN.Control = this._luDOCUMENT_USE_YN;
            this._lciDOCUMENT_USE_YN.Location = new System.Drawing.Point(0, 72);
            this._lciDOCUMENT_USE_YN.Name = "_lciDOCUMENT_USE_YN";
            this._lciDOCUMENT_USE_YN.Size = new System.Drawing.Size(390, 25);
            this._lciDOCUMENT_USE_YN.TextSize = new System.Drawing.Size(133, 14);
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6});
            this.layoutControlGroup5.Location = new System.Drawing.Point(439, 175);
            this.layoutControlGroup5.Name = "layoutControlGroup5";
            this.layoutControlGroup5.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlGroup5.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlGroup5.Size = new System.Drawing.Size(414, 281);
            this.layoutControlGroup5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this._gdSUB;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem6.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem6.Size = new System.Drawing.Size(390, 257);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlGroup6
            // 
            this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7});
            this.layoutControlGroup6.Location = new System.Drawing.Point(0, 175);
            this.layoutControlGroup6.Name = "layoutControlGroup6";
            this.layoutControlGroup6.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlGroup6.Size = new System.Drawing.Size(414, 281);
            this.layoutControlGroup6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this._gdMAIN;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem7.Size = new System.Drawing.Size(390, 257);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this._ucbtMOVE;
            this.layoutControlItem8.Location = new System.Drawing.Point(414, 175);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem8.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem8.Size = new System.Drawing.Size(25, 281);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // _luPRODUCT_PLAN_ID
            // 
            this._luPRODUCT_PLAN_ID.CancelButton = null;
            this._luPRODUCT_PLAN_ID.CommandButton = null;
            this._luPRODUCT_PLAN_ID.EditMask = "";
            this._luPRODUCT_PLAN_ID.Location = new System.Drawing.Point(24, 121);
            this._luPRODUCT_PLAN_ID.Margin = new System.Windows.Forms.Padding(0);
            this._luPRODUCT_PLAN_ID.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luPRODUCT_PLAN_ID.Name = "_luPRODUCT_PLAN_ID";
            this._luPRODUCT_PLAN_ID.PasswordChar = '\0';
            this._luPRODUCT_PLAN_ID.ReadOnly = false;
            this._luPRODUCT_PLAN_ID.Size = new System.Drawing.Size(386, 20);
            this._luPRODUCT_PLAN_ID.TabIndex = 24;
            this._luPRODUCT_PLAN_ID.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luPRODUCT_PLAN_ID.UseMaskAsDisplayFormat = false;
            this._luPRODUCT_PLAN_ID.Visible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this._luPRODUCT_PLAN_ID;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 97);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(390, 24);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ucProductPlanDocumentListPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ucProductPlanDocumentListPopup";
            this.Size = new System.Drawing.Size(873, 526);
            this.Load += new System.EventHandler(this.ucProductPlanDocumentListPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciORDER_REVISION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCONTRACT_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciUSE_YN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciORDER_NUMBER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciDOCUMENT_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciDOCUMENT_VER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciDOCUMENT_TYPE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCONTRACT_NUMBER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciDOCUMENT_USE_YN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl _gdMAIN;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdMAIN_VIEW;
        private CORE.BaseControls.ucSimpleButton _ucbtSELECT;
        private CORE.BaseControls.ucSimpleButton _ucbtSAVE;
        private CORE.BaseControls.ucSimpleButton _ucbtCANCLE;
        private CORE.BaseControls.ucTextEdit _luORDER_NUMBER;
        private CORE.BaseControls.ucTextEdit _luORDER_REVISION;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private CORE.BaseControls.ucSimpleButton _ucbtDOCUMENT_SELECT;
        private CORE.BaseControls.ucLookUpEdit _luDOCUMENT_TYPE;
        private CORE.BaseControls.ucTextEdit _luDOCUMENT_VER;
        private CORE.BaseControls.ucTextEdit _luDOCUMENT_NAME;
        private DevExpress.XtraGrid.GridControl _gdSUB;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdSUB_VIEW;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem _lciORDER_NUMBER;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem _lciORDER_REVISION;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem _lciDOCUMENT_NAME;
        private DevExpress.XtraLayout.LayoutControlItem _lciDOCUMENT_VER;
        private DevExpress.XtraLayout.LayoutControlItem _lciDOCUMENT_TYPE;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup6;
        private CORE.BaseControls.ucTextEdit _luCONTRACT_ID;
        private DevExpress.XtraLayout.LayoutControlItem _lciCONTRACT_ID;
        private CORE.BaseControls.ucTextEdit _luCONTRACT_NUMBER;
        private DevExpress.XtraLayout.LayoutControlItem _lciCONTRACT_NUMBER;
        private CORE.BaseControls.ucLookUpEdit _luDOCUMENT_USE_YN;
        private CORE.BaseControls.ucLookUpEdit _luUSE_YN;
        private DevExpress.XtraLayout.LayoutControlItem _lciUSE_YN;
        private DevExpress.XtraLayout.LayoutControlItem _lciDOCUMENT_USE_YN;
        private CORE.BaseControls.ucSimpleButton _ucbtMOVE;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private CORE.BaseControls.ucTextEdit _luPRODUCT_PLAN_ID;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}

namespace CoFAS_MES.UI.PO.UserControls
{
    partial class ucWorkOrderInfoPopup_T01
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this._ucbtCUTALL = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._ucbtCUTBTN = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._luPLAN_COUNT = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luCUT_COUNT = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._ucbtAPPLY = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._ucbtSEARCH = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._ucbtPLAN_SAVE = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._luPLAN_ORDER_ID = new CoFAS_MES.CORE.BaseControls.ucButtonEdit();
            this._gdMAIN = new DevExpress.XtraGrid.GridControl();
            this._gdMAIN_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._luTPART_NAME = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luTPART_CODE = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this._lciTPART_CODE = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciTPART_NAME = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this._lciPRODUCTION_ORDER_ID = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this._ucbtAPPL = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciPRODUCTION_COUNT = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this._lciCUT_COUNT = new DevExpress.XtraLayout.LayoutControlItem();
            this.BTN = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTPART_CODE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTPART_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPRODUCTION_ORDER_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ucbtAPPL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPRODUCTION_COUNT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCUT_COUNT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._ucbtCUTALL);
            this.layoutControl1.Controls.Add(this._ucbtCUTBTN);
            this.layoutControl1.Controls.Add(this._luPLAN_COUNT);
            this.layoutControl1.Controls.Add(this._luCUT_COUNT);
            this.layoutControl1.Controls.Add(this._ucbtAPPLY);
            this.layoutControl1.Controls.Add(this._ucbtSEARCH);
            this.layoutControl1.Controls.Add(this._ucbtPLAN_SAVE);
            this.layoutControl1.Controls.Add(this._luPLAN_ORDER_ID);
            this.layoutControl1.Controls.Add(this._gdMAIN);
            this.layoutControl1.Controls.Add(this._luTPART_NAME);
            this.layoutControl1.Controls.Add(this._luTPART_CODE);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(790, 491);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _ucbtCUTALL
            // 
            this._ucbtCUTALL.ButtonText = "simpleButton";
            this._ucbtCUTALL.Image = null;
            this._ucbtCUTALL.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtCUTALL.Location = new System.Drawing.Point(542, 98);
            this._ucbtCUTALL.Name = "_ucbtCUTALL";
            this._ucbtCUTALL.Size = new System.Drawing.Size(110, 24);
            this._ucbtCUTALL.TabIndex = 22;
            this._ucbtCUTALL.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtCUTALL_Click);
            // 
            // _ucbtCUTBTN
            // 
            this._ucbtCUTBTN.ButtonText = "simpleButton";
            this._ucbtCUTBTN.Image = null;
            this._ucbtCUTBTN.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtCUTBTN.Location = new System.Drawing.Point(438, 98);
            this._ucbtCUTBTN.Name = "_ucbtCUTBTN";
            this._ucbtCUTBTN.Size = new System.Drawing.Size(100, 24);
            this._ucbtCUTBTN.TabIndex = 21;
            this._ucbtCUTBTN.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtCUTBTN_Click);
            // 
            // _luPLAN_COUNT
            // 
            this._luPLAN_COUNT.CancelButton = null;
            this._luPLAN_COUNT.CommandButton = null;
            this._luPLAN_COUNT.EditMask = "";
            this._luPLAN_COUNT.Location = new System.Drawing.Point(167, 98);
            this._luPLAN_COUNT.Margin = new System.Windows.Forms.Padding(0);
            this._luPLAN_COUNT.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luPLAN_COUNT.Name = "_luPLAN_COUNT";
            this._luPLAN_COUNT.PasswordChar = '\0';
            this._luPLAN_COUNT.ReadOnly = false;
            this._luPLAN_COUNT.Size = new System.Drawing.Size(60, 20);
            this._luPLAN_COUNT.TabIndex = 20;
            this._luPLAN_COUNT.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luPLAN_COUNT.UseMaskAsDisplayFormat = false;
            // 
            // _luCUT_COUNT
            // 
            this._luCUT_COUNT.CancelButton = null;
            this._luCUT_COUNT.CommandButton = null;
            this._luCUT_COUNT.EditMask = "";
            this._luCUT_COUNT.Location = new System.Drawing.Point(374, 98);
            this._luCUT_COUNT.Margin = new System.Windows.Forms.Padding(0);
            this._luCUT_COUNT.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luCUT_COUNT.Name = "_luCUT_COUNT";
            this._luCUT_COUNT.PasswordChar = '\0';
            this._luCUT_COUNT.ReadOnly = false;
            this._luCUT_COUNT.Size = new System.Drawing.Size(60, 24);
            this._luCUT_COUNT.TabIndex = 19;
            this._luCUT_COUNT.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luCUT_COUNT.UseMaskAsDisplayFormat = false;
            // 
            // _ucbtAPPLY
            // 
            this._ucbtAPPLY.ButtonText = "simpleButton";
            this._ucbtAPPLY.Image = null;
            this._ucbtAPPLY.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtAPPLY.Location = new System.Drawing.Point(231, 74);
            this._ucbtAPPLY.Name = "_ucbtAPPLY";
            this._ucbtAPPLY.Size = new System.Drawing.Size(100, 20);
            this._ucbtAPPLY.TabIndex = 17;
            this._ucbtAPPLY.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._btAPPLY_Click);
            // 
            // _ucbtSEARCH
            // 
            this._ucbtSEARCH.ButtonText = "simpleButton";
            this._ucbtSEARCH.Image = global::CoFAS_MES.UI.PO.Properties.Resources.zoom_16x16;
            this._ucbtSEARCH.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtSEARCH.Location = new System.Drawing.Point(504, 24);
            this._ucbtSEARCH.Name = "_ucbtSEARCH";
            this._ucbtSEARCH.Size = new System.Drawing.Size(100, 22);
            this._ucbtSEARCH.TabIndex = 16;
            this._ucbtSEARCH.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._btSELECT_Click);
            // 
            // _ucbtPLAN_SAVE
            // 
            this._ucbtPLAN_SAVE.ButtonText = "simpleButton";
            this._ucbtPLAN_SAVE.Image = global::CoFAS_MES.UI.PO.Properties.Resources.saveto_16x16;
            this._ucbtPLAN_SAVE.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtPLAN_SAVE.Location = new System.Drawing.Point(24, 430);
            this._ucbtPLAN_SAVE.Name = "_ucbtPLAN_SAVE";
            this._ucbtPLAN_SAVE.Size = new System.Drawing.Size(742, 37);
            this._ucbtPLAN_SAVE.TabIndex = 15;
            this._ucbtPLAN_SAVE.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtPLAN_SAVE_Click);
            // 
            // _luPLAN_ORDER_ID
            // 
            this._luPLAN_ORDER_ID.BackColor = System.Drawing.SystemColors.Control;
            this._luPLAN_ORDER_ID.Location = new System.Drawing.Point(167, 74);
            this._luPLAN_ORDER_ID.Margin = new System.Windows.Forms.Padding(0);
            this._luPLAN_ORDER_ID.Name = "_luPLAN_ORDER_ID";
            this._luPLAN_ORDER_ID.ReadOnly = false;
            this._luPLAN_ORDER_ID.Size = new System.Drawing.Size(60, 20);
            this._luPLAN_ORDER_ID.TabIndex = 9;
            this._luPLAN_ORDER_ID._OnButtonPressed += new CoFAS_MES.CORE.BaseControls.ucButtonEdit.OnButtonPressedEventHandler(this._luCONTRACT_ID__OnButtonPressed);
            // 
            // _gdMAIN
            // 
            this._gdMAIN.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gdMAIN.Location = new System.Drawing.Point(24, 150);
            this._gdMAIN.MainView = this._gdMAIN_VIEW;
            this._gdMAIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gdMAIN.Name = "_gdMAIN";
            this._gdMAIN.Size = new System.Drawing.Size(742, 276);
            this._gdMAIN.TabIndex = 8;
            this._gdMAIN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gdMAIN_VIEW});
            // 
            // _gdMAIN_VIEW
            // 
            this._gdMAIN_VIEW.GridControl = this._gdMAIN;
            this._gdMAIN_VIEW.Name = "_gdMAIN_VIEW";
            // 
            // _luTPART_NAME
            // 
            this._luTPART_NAME.CancelButton = null;
            this._luTPART_NAME.CommandButton = null;
            this._luTPART_NAME.EditMask = "";
            this._luTPART_NAME.Location = new System.Drawing.Point(389, 24);
            this._luTPART_NAME.Margin = new System.Windows.Forms.Padding(0);
            this._luTPART_NAME.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luTPART_NAME.Name = "_luTPART_NAME";
            this._luTPART_NAME.PasswordChar = '\0';
            this._luTPART_NAME.ReadOnly = false;
            this._luTPART_NAME.Size = new System.Drawing.Size(111, 22);
            this._luTPART_NAME.TabIndex = 5;
            this._luTPART_NAME.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luTPART_NAME.UseMaskAsDisplayFormat = false;
            // 
            // _luTPART_CODE
            // 
            this._luTPART_CODE.CancelButton = null;
            this._luTPART_CODE.CommandButton = null;
            this._luTPART_CODE.EditMask = "";
            this._luTPART_CODE.Location = new System.Drawing.Point(167, 24);
            this._luTPART_CODE.Margin = new System.Windows.Forms.Padding(0);
            this._luTPART_CODE.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luTPART_CODE.Name = "_luTPART_CODE";
            this._luTPART_CODE.PasswordChar = '\0';
            this._luTPART_CODE.ReadOnly = false;
            this._luTPART_CODE.Size = new System.Drawing.Size(75, 22);
            this._luTPART_CODE.TabIndex = 4;
            this._luTPART_CODE.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luTPART_CODE.UseMaskAsDisplayFormat = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3,
            this.layoutControlGroup4});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(790, 491);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this._lciTPART_CODE,
            this._lciTPART_NAME,
            this.emptySpaceItem2,
            this.layoutControlItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup2.Size = new System.Drawing.Size(770, 50);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // _lciTPART_CODE
            // 
            this._lciTPART_CODE.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciTPART_CODE.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciTPART_CODE.Control = this._luTPART_CODE;
            this._lciTPART_CODE.Location = new System.Drawing.Point(0, 0);
            this._lciTPART_CODE.MaxSize = new System.Drawing.Size(222, 26);
            this._lciTPART_CODE.MinSize = new System.Drawing.Size(222, 26);
            this._lciTPART_CODE.Name = "_lciTPART_CODE";
            this._lciTPART_CODE.Size = new System.Drawing.Size(222, 26);
            this._lciTPART_CODE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciTPART_CODE.Text = "코드";
            this._lciTPART_CODE.TextSize = new System.Drawing.Size(139, 14);
            // 
            // _lciTPART_NAME
            // 
            this._lciTPART_NAME.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciTPART_NAME.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciTPART_NAME.Control = this._luTPART_NAME;
            this._lciTPART_NAME.Location = new System.Drawing.Point(222, 0);
            this._lciTPART_NAME.MaxSize = new System.Drawing.Size(258, 26);
            this._lciTPART_NAME.MinSize = new System.Drawing.Size(258, 26);
            this._lciTPART_NAME.Name = "_lciTPART_NAME";
            this._lciTPART_NAME.Size = new System.Drawing.Size(258, 26);
            this._lciTPART_NAME.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciTPART_NAME.Text = "명칭";
            this._lciTPART_NAME.TextSize = new System.Drawing.Size(139, 14);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(584, 0);
            this.emptySpaceItem2.MaxSize = new System.Drawing.Size(162, 26);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(162, 26);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(162, 26);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this._ucbtSEARCH;
            this.layoutControlItem2.Location = new System.Drawing.Point(480, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(104, 26);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(104, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(104, 26);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            this.layoutControlItem2.Click += new System.EventHandler(this._btSELECT_Click);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlItem4});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 126);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup3.Size = new System.Drawing.Size(770, 345);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this._gdMAIN;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(746, 280);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this._ucbtPLAN_SAVE;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 280);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(746, 41);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(746, 41);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(746, 41);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this._lciPRODUCTION_ORDER_ID,
            this.emptySpaceItem4,
            this._ucbtAPPL,
            this._lciPRODUCTION_COUNT,
            this.emptySpaceItem5,
            this._lciCUT_COUNT,
            this.BTN,
            this.layoutControlItem1});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 50);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(770, 76);
            this.layoutControlGroup4.TextVisible = false;
            // 
            // _lciPRODUCTION_ORDER_ID
            // 
            this._lciPRODUCTION_ORDER_ID.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciPRODUCTION_ORDER_ID.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciPRODUCTION_ORDER_ID.Control = this._luPLAN_ORDER_ID;
            this._lciPRODUCTION_ORDER_ID.Location = new System.Drawing.Point(0, 0);
            this._lciPRODUCTION_ORDER_ID.MaxSize = new System.Drawing.Size(207, 24);
            this._lciPRODUCTION_ORDER_ID.MinSize = new System.Drawing.Size(207, 24);
            this._lciPRODUCTION_ORDER_ID.Name = "_lciPRODUCTION_ORDER_ID";
            this._lciPRODUCTION_ORDER_ID.Size = new System.Drawing.Size(207, 24);
            this._lciPRODUCTION_ORDER_ID.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciPRODUCTION_ORDER_ID.Text = "생산계획찾기";
            this._lciPRODUCTION_ORDER_ID.TextSize = new System.Drawing.Size(139, 14);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(632, 24);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(114, 28);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // _ucbtAPPL
            // 
            this._ucbtAPPL.Control = this._ucbtAPPLY;
            this._ucbtAPPL.Location = new System.Drawing.Point(207, 0);
            this._ucbtAPPL.MinSize = new System.Drawing.Size(104, 24);
            this._ucbtAPPL.Name = "_ucbtAPPL";
            this._ucbtAPPL.Size = new System.Drawing.Size(104, 24);
            this._ucbtAPPL.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._ucbtAPPL.TextSize = new System.Drawing.Size(0, 0);
            this._ucbtAPPL.TextVisible = false;
            this._ucbtAPPL.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            this._ucbtAPPL.Click += new System.EventHandler(this._btAPPLY_Click);
            // 
            // _lciPRODUCTION_COUNT
            // 
            this._lciPRODUCTION_COUNT.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciPRODUCTION_COUNT.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciPRODUCTION_COUNT.Control = this._luPLAN_COUNT;
            this._lciPRODUCTION_COUNT.Location = new System.Drawing.Point(0, 24);
            this._lciPRODUCTION_COUNT.MaxSize = new System.Drawing.Size(207, 24);
            this._lciPRODUCTION_COUNT.MinSize = new System.Drawing.Size(207, 24);
            this._lciPRODUCTION_COUNT.Name = "_lciPRODUCTION_COUNT";
            this._lciPRODUCTION_COUNT.Size = new System.Drawing.Size(207, 28);
            this._lciPRODUCTION_COUNT.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciPRODUCTION_COUNT.TextSize = new System.Drawing.Size(139, 14);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(311, 0);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(435, 24);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // _lciCUT_COUNT
            // 
            this._lciCUT_COUNT.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciCUT_COUNT.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciCUT_COUNT.Control = this._luCUT_COUNT;
            this._lciCUT_COUNT.Location = new System.Drawing.Point(207, 24);
            this._lciCUT_COUNT.MaxSize = new System.Drawing.Size(207, 28);
            this._lciCUT_COUNT.MinSize = new System.Drawing.Size(207, 28);
            this._lciCUT_COUNT.Name = "_lciCUT_COUNT";
            this._lciCUT_COUNT.Size = new System.Drawing.Size(207, 28);
            this._lciCUT_COUNT.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciCUT_COUNT.TextSize = new System.Drawing.Size(139, 14);
            this._lciCUT_COUNT.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // BTN
            // 
            this.BTN.Control = this._ucbtCUTBTN;
            this.BTN.Location = new System.Drawing.Point(414, 24);
            this.BTN.MaxSize = new System.Drawing.Size(104, 28);
            this.BTN.MinSize = new System.Drawing.Size(104, 28);
            this.BTN.Name = "BTN";
            this.BTN.Size = new System.Drawing.Size(104, 28);
            this.BTN.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.BTN.TextSize = new System.Drawing.Size(0, 0);
            this.BTN.TextVisible = false;
            this.BTN.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this._ucbtCUTALL;
            this.layoutControlItem1.Location = new System.Drawing.Point(518, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(114, 28);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            this.layoutControlItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // ucWorkOrderInfoPopup_T01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ucWorkOrderInfoPopup_T01";
            this.Size = new System.Drawing.Size(790, 491);
            this.Load += new System.EventHandler(this.ucProductPlanInfoPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTPART_CODE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTPART_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPRODUCTION_ORDER_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ucbtAPPL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPRODUCTION_COUNT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCUT_COUNT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl _gdMAIN;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdMAIN_VIEW;
        private CoFAS_MES.CORE.BaseControls.ucTextEdit _luTPART_NAME;
        private CoFAS_MES.CORE.BaseControls.ucTextEdit _luTPART_CODE;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem _lciTPART_CODE;
        private DevExpress.XtraLayout.LayoutControlItem _lciTPART_NAME;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private CoFAS_MES.CORE.BaseControls.ucButtonEdit _luPLAN_ORDER_ID;
        private DevExpress.XtraLayout.LayoutControlItem _lciPRODUCTION_ORDER_ID;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private CoFAS_MES.CORE.BaseControls.ucSimpleButton _ucbtPLAN_SAVE;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private CoFAS_MES.CORE.BaseControls.ucSimpleButton _ucbtSEARCH;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private CoFAS_MES.CORE.BaseControls.ucSimpleButton _ucbtAPPLY;
        private DevExpress.XtraLayout.LayoutControlItem _ucbtAPPL;
        private CoFAS_MES.CORE.BaseControls.ucTextEdit _luPLAN_COUNT;
        private CoFAS_MES.CORE.BaseControls.ucTextEdit _luCUT_COUNT;
        private DevExpress.XtraLayout.LayoutControlItem _lciCUT_COUNT;
        private DevExpress.XtraLayout.LayoutControlItem _lciPRODUCTION_COUNT;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private CoFAS_MES.CORE.BaseControls.ucSimpleButton _ucbtCUTBTN;
        private DevExpress.XtraLayout.LayoutControlItem BTN;
        private CoFAS_MES.CORE.BaseControls.ucSimpleButton _ucbtCUTALL;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}

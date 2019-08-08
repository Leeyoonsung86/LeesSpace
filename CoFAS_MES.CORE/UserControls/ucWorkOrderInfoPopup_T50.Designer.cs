namespace CoFAS_MES.CORE.UserControls
{
    partial class ucWorkOrderInfoPopup_T50
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
            this._luMESSAGE = new CoFAS_MES.CORE.BaseControls.ucMemoEdit();
            this._luCARVE = new CoFAS_MES.CORE.BaseControls.ucMemoEdit();
            this._luT_CONFIGURATION_NAME = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luT_CONFIGURATION_MST_NAME = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luPLAN_COUNT = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luREFERENCE_ID = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._ucbtAPPLY = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._ucbtPLAN_SAVE = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._luPLAN_ORDER_ID = new CoFAS_MES.CORE.BaseControls.ucButtonEdit();
            this._gdMAIN = new DevExpress.XtraGrid.GridControl();
            this._gdMAIN_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this._lciPLAN_ORDER_ID = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciREFERENCE_ID = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this._lciPLAN_COUNT = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this._ucbtAPPL = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciTCONFIGURATION_MST_NAME = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciTCONFIGURATION_NAME = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this._lciTCARVE = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciTMESSAGE = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPLAN_ORDER_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciREFERENCE_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPLAN_COUNT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ucbtAPPL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTCONFIGURATION_MST_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTCONFIGURATION_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTCARVE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTMESSAGE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._luMESSAGE);
            this.layoutControl1.Controls.Add(this._luCARVE);
            this.layoutControl1.Controls.Add(this._luT_CONFIGURATION_NAME);
            this.layoutControl1.Controls.Add(this._luT_CONFIGURATION_MST_NAME);
            this.layoutControl1.Controls.Add(this._luPLAN_COUNT);
            this.layoutControl1.Controls.Add(this._luREFERENCE_ID);
            this.layoutControl1.Controls.Add(this._ucbtAPPLY);
            this.layoutControl1.Controls.Add(this._ucbtPLAN_SAVE);
            this.layoutControl1.Controls.Add(this._luPLAN_ORDER_ID);
            this.layoutControl1.Controls.Add(this._gdMAIN);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1024, 500);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _luMESSAGE
            // 
            this._luMESSAGE.Location = new System.Drawing.Point(217, 128);
            this._luMESSAGE.Margin = new System.Windows.Forms.Padding(0);
            this._luMESSAGE.Name = "_luMESSAGE";
            this._luMESSAGE.ReadOnly = false;
            this._luMESSAGE.Size = new System.Drawing.Size(452, 28);
            this._luMESSAGE.TabIndex = 26;
            // 
            // _luCARVE
            // 
            this._luCARVE.Location = new System.Drawing.Point(217, 96);
            this._luCARVE.Margin = new System.Windows.Forms.Padding(0);
            this._luCARVE.Name = "_luCARVE";
            this._luCARVE.ReadOnly = false;
            this._luCARVE.Size = new System.Drawing.Size(452, 28);
            this._luCARVE.TabIndex = 25;
            // 
            // _luT_CONFIGURATION_NAME
            // 
            this._luT_CONFIGURATION_NAME.CancelButton = null;
            this._luT_CONFIGURATION_NAME.CommandButton = null;
            this._luT_CONFIGURATION_NAME.EditMask = "";
            this._luT_CONFIGURATION_NAME.Location = new System.Drawing.Point(551, 72);
            this._luT_CONFIGURATION_NAME.Margin = new System.Windows.Forms.Padding(0);
            this._luT_CONFIGURATION_NAME.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luT_CONFIGURATION_NAME.Name = "_luT_CONFIGURATION_NAME";
            this._luT_CONFIGURATION_NAME.NumText = "";
            this._luT_CONFIGURATION_NAME.PasswordChar = '\0';
            this._luT_CONFIGURATION_NAME.ReadOnly = false;
            this._luT_CONFIGURATION_NAME.Size = new System.Drawing.Size(118, 20);
            this._luT_CONFIGURATION_NAME.TabIndex = 22;
            this._luT_CONFIGURATION_NAME.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luT_CONFIGURATION_NAME.UseMaskAsDisplayFormat = false;
            // 
            // _luT_CONFIGURATION_MST_NAME
            // 
            this._luT_CONFIGURATION_MST_NAME.CancelButton = null;
            this._luT_CONFIGURATION_MST_NAME.CommandButton = null;
            this._luT_CONFIGURATION_MST_NAME.EditMask = "";
            this._luT_CONFIGURATION_MST_NAME.Location = new System.Drawing.Point(217, 72);
            this._luT_CONFIGURATION_MST_NAME.Margin = new System.Windows.Forms.Padding(0);
            this._luT_CONFIGURATION_MST_NAME.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luT_CONFIGURATION_MST_NAME.Name = "_luT_CONFIGURATION_MST_NAME";
            this._luT_CONFIGURATION_MST_NAME.NumText = "";
            this._luT_CONFIGURATION_MST_NAME.PasswordChar = '\0';
            this._luT_CONFIGURATION_MST_NAME.ReadOnly = false;
            this._luT_CONFIGURATION_MST_NAME.Size = new System.Drawing.Size(137, 20);
            this._luT_CONFIGURATION_MST_NAME.TabIndex = 21;
            this._luT_CONFIGURATION_MST_NAME.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luT_CONFIGURATION_MST_NAME.UseMaskAsDisplayFormat = false;
            // 
            // _luPLAN_COUNT
            // 
            this._luPLAN_COUNT.CancelButton = null;
            this._luPLAN_COUNT.CommandButton = null;
            this._luPLAN_COUNT.EditMask = "";
            this._luPLAN_COUNT.Location = new System.Drawing.Point(551, 48);
            this._luPLAN_COUNT.Margin = new System.Windows.Forms.Padding(0);
            this._luPLAN_COUNT.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luPLAN_COUNT.Name = "_luPLAN_COUNT";
            this._luPLAN_COUNT.NumText = "";
            this._luPLAN_COUNT.PasswordChar = '\0';
            this._luPLAN_COUNT.ReadOnly = false;
            this._luPLAN_COUNT.Size = new System.Drawing.Size(118, 20);
            this._luPLAN_COUNT.TabIndex = 20;
            this._luPLAN_COUNT.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luPLAN_COUNT.UseMaskAsDisplayFormat = false;
            // 
            // _luREFERENCE_ID
            // 
            this._luREFERENCE_ID.CancelButton = null;
            this._luREFERENCE_ID.CommandButton = null;
            this._luREFERENCE_ID.EditMask = "";
            this._luREFERENCE_ID.Location = new System.Drawing.Point(217, 48);
            this._luREFERENCE_ID.Margin = new System.Windows.Forms.Padding(0);
            this._luREFERENCE_ID.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luREFERENCE_ID.Name = "_luREFERENCE_ID";
            this._luREFERENCE_ID.NumText = "";
            this._luREFERENCE_ID.PasswordChar = '\0';
            this._luREFERENCE_ID.ReadOnly = false;
            this._luREFERENCE_ID.Size = new System.Drawing.Size(137, 20);
            this._luREFERENCE_ID.TabIndex = 18;
            this._luREFERENCE_ID.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luREFERENCE_ID.UseMaskAsDisplayFormat = false;
            // 
            // _ucbtAPPLY
            // 
            this._ucbtAPPLY.ButtonText = "simpleButton";
            this._ucbtAPPLY.FontSize = 0;
            this._ucbtAPPLY.Image = null;
            this._ucbtAPPLY.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtAPPLY.Location = new System.Drawing.Point(673, 48);
            this._ucbtAPPLY.Name = "_ucbtAPPLY";
            this._ucbtAPPLY.Size = new System.Drawing.Size(110, 20);
            this._ucbtAPPLY.TabIndex = 17;
            this._ucbtAPPLY.Visible = false;
            this._ucbtAPPLY.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._btAPPLY_Click);
            // 
            // _ucbtPLAN_SAVE
            // 
            this._ucbtPLAN_SAVE.ButtonText = "simpleButton";
            this._ucbtPLAN_SAVE.FontSize = 0;
            this._ucbtPLAN_SAVE.Image = global::CoFAS_MES.CORE.Properties.Resources.apply_32x32;
            this._ucbtPLAN_SAVE.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtPLAN_SAVE.Location = new System.Drawing.Point(12, 450);
            this._ucbtPLAN_SAVE.Name = "_ucbtPLAN_SAVE";
            this._ucbtPLAN_SAVE.Size = new System.Drawing.Size(1000, 38);
            this._ucbtPLAN_SAVE.TabIndex = 15;
            this._ucbtPLAN_SAVE.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtPLAN_SAVE_Click);
            // 
            // _luPLAN_ORDER_ID
            // 
            this._luPLAN_ORDER_ID.BackColor = System.Drawing.SystemColors.Control;
            this._luPLAN_ORDER_ID.Location = new System.Drawing.Point(217, 24);
            this._luPLAN_ORDER_ID.Margin = new System.Windows.Forms.Padding(0);
            this._luPLAN_ORDER_ID.Name = "_luPLAN_ORDER_ID";
            this._luPLAN_ORDER_ID.ReadOnly = false;
            this._luPLAN_ORDER_ID.Size = new System.Drawing.Size(137, 20);
            this._luPLAN_ORDER_ID.TabIndex = 9;
            this._luPLAN_ORDER_ID._OnButtonPressed += new CoFAS_MES.CORE.BaseControls.ucButtonEdit.OnButtonPressedEventHandler(this._luCONTRACT_ID__OnButtonPressed);
            // 
            // _gdMAIN
            // 
            this._gdMAIN.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gdMAIN.Location = new System.Drawing.Point(24, 184);
            this._gdMAIN.MainView = this._gdMAIN_VIEW;
            this._gdMAIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gdMAIN.Name = "_gdMAIN";
            this._gdMAIN.Size = new System.Drawing.Size(976, 250);
            this._gdMAIN.TabIndex = 8;
            this._gdMAIN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gdMAIN_VIEW});
            // 
            // _gdMAIN_VIEW
            // 
            this._gdMAIN_VIEW.GridControl = this._gdMAIN;
            this._gdMAIN_VIEW.Name = "_gdMAIN_VIEW";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3,
            this.layoutControlGroup4,
            this.layoutControlItem4});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(1024, 500);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 160);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup3.Size = new System.Drawing.Size(1004, 278);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this._gdMAIN;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(980, 254);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this._lciPLAN_ORDER_ID,
            this._lciREFERENCE_ID,
            this.emptySpaceItem4,
            this._lciPLAN_COUNT,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this._ucbtAPPL,
            this._lciTCONFIGURATION_MST_NAME,
            this._lciTCONFIGURATION_NAME,
            this.emptySpaceItem3,
            this.emptySpaceItem5,
            this.emptySpaceItem6,
            this._lciTCARVE,
            this._lciTMESSAGE});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(1004, 160);
            this.layoutControlGroup4.TextVisible = false;
            // 
            // _lciPLAN_ORDER_ID
            // 
            this._lciPLAN_ORDER_ID.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciPLAN_ORDER_ID.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciPLAN_ORDER_ID.Control = this._luPLAN_ORDER_ID;
            this._lciPLAN_ORDER_ID.Location = new System.Drawing.Point(0, 0);
            this._lciPLAN_ORDER_ID.MaxSize = new System.Drawing.Size(0, 24);
            this._lciPLAN_ORDER_ID.MinSize = new System.Drawing.Size(297, 24);
            this._lciPLAN_ORDER_ID.Name = "_lciPLAN_ORDER_ID";
            this._lciPLAN_ORDER_ID.Size = new System.Drawing.Size(334, 24);
            this._lciPLAN_ORDER_ID.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciPLAN_ORDER_ID.Text = "생산계획찾기";
            this._lciPLAN_ORDER_ID.TextSize = new System.Drawing.Size(189, 14);
            // 
            // _lciREFERENCE_ID
            // 
            this._lciREFERENCE_ID.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciREFERENCE_ID.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciREFERENCE_ID.Control = this._luREFERENCE_ID;
            this._lciREFERENCE_ID.Location = new System.Drawing.Point(0, 24);
            this._lciREFERENCE_ID.Name = "_lciREFERENCE_ID";
            this._lciREFERENCE_ID.Size = new System.Drawing.Size(334, 24);
            this._lciREFERENCE_ID.TextSize = new System.Drawing.Size(189, 14);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(649, 0);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(331, 24);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // _lciPLAN_COUNT
            // 
            this._lciPLAN_COUNT.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciPLAN_COUNT.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciPLAN_COUNT.Control = this._luPLAN_COUNT;
            this._lciPLAN_COUNT.Location = new System.Drawing.Point(334, 24);
            this._lciPLAN_COUNT.MaxSize = new System.Drawing.Size(315, 24);
            this._lciPLAN_COUNT.MinSize = new System.Drawing.Size(315, 24);
            this._lciPLAN_COUNT.Name = "_lciPLAN_COUNT";
            this._lciPLAN_COUNT.Size = new System.Drawing.Size(315, 24);
            this._lciPLAN_COUNT.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciPLAN_COUNT.TextSize = new System.Drawing.Size(189, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(334, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(315, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(763, 24);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(217, 24);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // _ucbtAPPL
            // 
            this._ucbtAPPL.Control = this._ucbtAPPLY;
            this._ucbtAPPL.Location = new System.Drawing.Point(649, 24);
            this._ucbtAPPL.MaxSize = new System.Drawing.Size(114, 24);
            this._ucbtAPPL.MinSize = new System.Drawing.Size(114, 24);
            this._ucbtAPPL.Name = "_ucbtAPPL";
            this._ucbtAPPL.Size = new System.Drawing.Size(114, 24);
            this._ucbtAPPL.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._ucbtAPPL.TextSize = new System.Drawing.Size(0, 0);
            this._ucbtAPPL.TextVisible = false;
            this._ucbtAPPL.Click += new System.EventHandler(this._btAPPLY_Click);
            // 
            // _lciTCONFIGURATION_MST_NAME
            // 
            this._lciTCONFIGURATION_MST_NAME.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciTCONFIGURATION_MST_NAME.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciTCONFIGURATION_MST_NAME.Control = this._luT_CONFIGURATION_MST_NAME;
            this._lciTCONFIGURATION_MST_NAME.Location = new System.Drawing.Point(0, 48);
            this._lciTCONFIGURATION_MST_NAME.Name = "_lciTCONFIGURATION_MST_NAME";
            this._lciTCONFIGURATION_MST_NAME.Size = new System.Drawing.Size(334, 24);
            this._lciTCONFIGURATION_MST_NAME.TextSize = new System.Drawing.Size(189, 14);
            // 
            // _lciTCONFIGURATION_NAME
            // 
            this._lciTCONFIGURATION_NAME.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciTCONFIGURATION_NAME.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciTCONFIGURATION_NAME.Control = this._luT_CONFIGURATION_NAME;
            this._lciTCONFIGURATION_NAME.Location = new System.Drawing.Point(334, 48);
            this._lciTCONFIGURATION_NAME.MaxSize = new System.Drawing.Size(315, 24);
            this._lciTCONFIGURATION_NAME.MinSize = new System.Drawing.Size(315, 24);
            this._lciTCONFIGURATION_NAME.Name = "_lciTCONFIGURATION_NAME";
            this._lciTCONFIGURATION_NAME.Size = new System.Drawing.Size(315, 24);
            this._lciTCONFIGURATION_NAME.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciTCONFIGURATION_NAME.TextSize = new System.Drawing.Size(189, 14);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(649, 48);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(331, 24);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(649, 72);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(331, 32);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(649, 104);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(331, 32);
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // _lciTCARVE
            // 
            this._lciTCARVE.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciTCARVE.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciTCARVE.Control = this._luCARVE;
            this._lciTCARVE.Location = new System.Drawing.Point(0, 72);
            this._lciTCARVE.MaxSize = new System.Drawing.Size(649, 32);
            this._lciTCARVE.MinSize = new System.Drawing.Size(649, 32);
            this._lciTCARVE.Name = "_lciTCARVE";
            this._lciTCARVE.Size = new System.Drawing.Size(649, 32);
            this._lciTCARVE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciTCARVE.TextSize = new System.Drawing.Size(189, 14);
            // 
            // _lciTMESSAGE
            // 
            this._lciTMESSAGE.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciTMESSAGE.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciTMESSAGE.Control = this._luMESSAGE;
            this._lciTMESSAGE.Location = new System.Drawing.Point(0, 104);
            this._lciTMESSAGE.MaxSize = new System.Drawing.Size(649, 32);
            this._lciTMESSAGE.MinSize = new System.Drawing.Size(649, 32);
            this._lciTMESSAGE.Name = "_lciTMESSAGE";
            this._lciTMESSAGE.Size = new System.Drawing.Size(649, 32);
            this._lciTMESSAGE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciTMESSAGE.TextSize = new System.Drawing.Size(189, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this._ucbtPLAN_SAVE;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 438);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(1004, 42);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // ucWorkOrderInfoPopup_T50
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ucWorkOrderInfoPopup_T50";
            this.Size = new System.Drawing.Size(1024, 500);
            this.Load += new System.EventHandler(this.ucProductPlanInfoPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPLAN_ORDER_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciREFERENCE_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPLAN_COUNT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ucbtAPPL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTCONFIGURATION_MST_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTCONFIGURATION_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTCARVE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTMESSAGE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl _gdMAIN;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdMAIN_VIEW;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private BaseControls.ucButtonEdit _luPLAN_ORDER_ID;
        private DevExpress.XtraLayout.LayoutControlItem _lciPLAN_ORDER_ID;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private BaseControls.ucSimpleButton _ucbtPLAN_SAVE;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private BaseControls.ucSimpleButton _ucbtAPPLY;
        private DevExpress.XtraLayout.LayoutControlItem _ucbtAPPL;
        private BaseControls.ucTextEdit _luREFERENCE_ID;
        private DevExpress.XtraLayout.LayoutControlItem _lciREFERENCE_ID;
        private BaseControls.ucTextEdit _luPLAN_COUNT;
        private DevExpress.XtraLayout.LayoutControlItem _lciPLAN_COUNT;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private BaseControls.ucTextEdit _luT_CONFIGURATION_NAME;
        private BaseControls.ucTextEdit _luT_CONFIGURATION_MST_NAME;
        private DevExpress.XtraLayout.LayoutControlItem _lciTCONFIGURATION_MST_NAME;
        private DevExpress.XtraLayout.LayoutControlItem _lciTCONFIGURATION_NAME;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private BaseControls.ucMemoEdit _luCARVE;
        private DevExpress.XtraLayout.LayoutControlItem _lciTCARVE;
        private BaseControls.ucMemoEdit _luMESSAGE;
        private DevExpress.XtraLayout.LayoutControlItem _lciTMESSAGE;
    }
}

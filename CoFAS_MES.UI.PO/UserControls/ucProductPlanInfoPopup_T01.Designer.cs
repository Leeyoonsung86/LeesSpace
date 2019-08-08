namespace CoFAS_MES.UI.PO.UserControls
{
    partial class ucProductPlanInfoPopup_T01
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this._luPLANID = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._ucbtAPPLY = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._ucbtPLAN_SAVE = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._luPLAN_QTY = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luPART_NAME = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luPART_CODE = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luCONTRACT_ID = new CoFAS_MES.CORE.BaseControls.ucButtonEdit();
            this._gdMAIN = new DevExpress.XtraGrid.GridControl();
            this._gdMAIN_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._luTPART_NAME = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luTPART_CODE = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luREMAIN_QTY = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luCONTRACT_QTY = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this._lciCONTRACT_ID = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciTPART_CODE = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciTPART_NAME = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this._lciPART_CODE = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciPART_NAME = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciREMAIN_QTY = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciPLANID = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciCONTRACT_QTY = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciPLAN_QTY = new DevExpress.XtraLayout.LayoutControlItem();
            this._ucbtAPPL = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCONTRACT_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTPART_CODE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTPART_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPART_CODE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPART_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciREMAIN_QTY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPLANID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCONTRACT_QTY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPLAN_QTY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ucbtAPPL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._luPLANID);
            this.layoutControl1.Controls.Add(this._ucbtAPPLY);
            this.layoutControl1.Controls.Add(this._ucbtPLAN_SAVE);
            this.layoutControl1.Controls.Add(this._luPLAN_QTY);
            this.layoutControl1.Controls.Add(this._luPART_NAME);
            this.layoutControl1.Controls.Add(this._luPART_CODE);
            this.layoutControl1.Controls.Add(this._luCONTRACT_ID);
            this.layoutControl1.Controls.Add(this._gdMAIN);
            this.layoutControl1.Controls.Add(this._luTPART_NAME);
            this.layoutControl1.Controls.Add(this._luTPART_CODE);
            this.layoutControl1.Controls.Add(this._luREMAIN_QTY);
            this.layoutControl1.Controls.Add(this._luCONTRACT_QTY);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(737, 499);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _luPLANID
            // 
            this._luPLANID.CancelButton = null;
            this._luPLANID.CommandButton = null;
            this._luPLANID.EditMask = "";
            this._luPLANID.Location = new System.Drawing.Point(512, 74);
            this._luPLANID.Margin = new System.Windows.Forms.Padding(0);
            this._luPLANID.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luPLANID.Name = "_luPLANID";
            this._luPLANID.PasswordChar = '\0';
            this._luPLANID.ReadOnly = false;
            this._luPLANID.Size = new System.Drawing.Size(201, 22);
            this._luPLANID.TabIndex = 18;
            this._luPLANID.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luPLANID.UseMaskAsDisplayFormat = false;
            // 
            // _ucbtAPPLY
            // 
            this._ucbtAPPLY.ButtonText = "simpleButton";
            this._ucbtAPPLY.Image = null;
            this._ucbtAPPLY.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtAPPLY.Location = new System.Drawing.Point(468, 100);
            this._ucbtAPPLY.Name = "_ucbtAPPLY";
            this._ucbtAPPLY.Size = new System.Drawing.Size(126, 22);
            this._ucbtAPPLY.TabIndex = 17;
            this._ucbtAPPLY.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._btAPPLY_Click);
            // 
            // _ucbtPLAN_SAVE
            // 
            this._ucbtPLAN_SAVE.ButtonText = "simpleButton";
            this._ucbtPLAN_SAVE.Image = global::CoFAS_MES.UI.PO.Properties.Resources.saveto_16x16;
            this._ucbtPLAN_SAVE.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtPLAN_SAVE.Location = new System.Drawing.Point(24, 433);
            this._ucbtPLAN_SAVE.Name = "_ucbtPLAN_SAVE";
            this._ucbtPLAN_SAVE.Size = new System.Drawing.Size(689, 42);
            this._ucbtPLAN_SAVE.TabIndex = 15;
            this._ucbtPLAN_SAVE.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtPLAN_SAVE_Click);
            // 
            // _luPLAN_QTY
            // 
            this._luPLAN_QTY.CancelButton = null;
            this._luPLAN_QTY.CommandButton = null;
            this._luPLAN_QTY.EditMask = "n2";
            this._luPLAN_QTY.Location = new System.Drawing.Point(364, 100);
            this._luPLAN_QTY.Margin = new System.Windows.Forms.Padding(0);
            this._luPLAN_QTY.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this._luPLAN_QTY.Name = "_luPLAN_QTY";
            this._luPLAN_QTY.PasswordChar = '\0';
            this._luPLAN_QTY.ReadOnly = false;
            this._luPLAN_QTY.Size = new System.Drawing.Size(100, 22);
            this._luPLAN_QTY.TabIndex = 12;
            this._luPLAN_QTY.TextAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._luPLAN_QTY.UseMaskAsDisplayFormat = true;
            this._luPLAN_QTY._OnKeyPress += new CoFAS_MES.CORE.BaseControls.ucTextEdit.OnKeyPressEventHandler(this._luTextEdit__OnKeyPress);
            // 
            // _luPART_NAME
            // 
            this._luPART_NAME.CancelButton = null;
            this._luPART_NAME.CommandButton = null;
            this._luPART_NAME.EditMask = "";
            this._luPART_NAME.Location = new System.Drawing.Point(172, 74);
            this._luPART_NAME.Margin = new System.Windows.Forms.Padding(0);
            this._luPART_NAME.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luPART_NAME.Name = "_luPART_NAME";
            this._luPART_NAME.PasswordChar = '\0';
            this._luPART_NAME.ReadOnly = false;
            this._luPART_NAME.Size = new System.Drawing.Size(292, 22);
            this._luPART_NAME.TabIndex = 11;
            this._luPART_NAME.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luPART_NAME.UseMaskAsDisplayFormat = false;
            // 
            // _luPART_CODE
            // 
            this._luPART_CODE.CancelButton = null;
            this._luPART_CODE.CommandButton = null;
            this._luPART_CODE.EditMask = "";
            this._luPART_CODE.Location = new System.Drawing.Point(68, 74);
            this._luPART_CODE.Margin = new System.Windows.Forms.Padding(0);
            this._luPART_CODE.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luPART_CODE.Name = "_luPART_CODE";
            this._luPART_CODE.PasswordChar = '\0';
            this._luPART_CODE.ReadOnly = false;
            this._luPART_CODE.Size = new System.Drawing.Size(100, 22);
            this._luPART_CODE.TabIndex = 10;
            this._luPART_CODE.TextAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._luPART_CODE.UseMaskAsDisplayFormat = false;
            // 
            // _luCONTRACT_ID
            // 
            this._luCONTRACT_ID.BackColor = System.Drawing.SystemColors.Control;
            this._luCONTRACT_ID.Location = new System.Drawing.Point(68, 24);
            this._luCONTRACT_ID.Margin = new System.Windows.Forms.Padding(0);
            this._luCONTRACT_ID.Name = "_luCONTRACT_ID";
            this._luCONTRACT_ID.ReadOnly = false;
            this._luCONTRACT_ID.Size = new System.Drawing.Size(174, 22);
            this._luCONTRACT_ID.TabIndex = 9;
            this._luCONTRACT_ID._OnButtonPressed += new CoFAS_MES.CORE.BaseControls.ucButtonEdit.OnButtonPressedEventHandler(this._luCONTRACT_ID__OnButtonPressed);
            // 
            // _gdMAIN
            // 
            this._gdMAIN.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gdMAIN.Location = new System.Drawing.Point(24, 150);
            this._gdMAIN.MainView = this._gdMAIN_VIEW;
            this._gdMAIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gdMAIN.Name = "_gdMAIN";
            this._gdMAIN.Size = new System.Drawing.Size(689, 279);
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
            this._luTPART_NAME.Location = new System.Drawing.Point(438, 24);
            this._luTPART_NAME.Margin = new System.Windows.Forms.Padding(0);
            this._luTPART_NAME.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luTPART_NAME.Name = "_luTPART_NAME";
            this._luTPART_NAME.PasswordChar = '\0';
            this._luTPART_NAME.ReadOnly = false;
            this._luTPART_NAME.Size = new System.Drawing.Size(171, 22);
            this._luTPART_NAME.TabIndex = 5;
            this._luTPART_NAME.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luTPART_NAME.UseMaskAsDisplayFormat = false;
            // 
            // _luTPART_CODE
            // 
            this._luTPART_CODE.CancelButton = null;
            this._luTPART_CODE.CommandButton = null;
            this._luTPART_CODE.EditMask = "";
            this._luTPART_CODE.Location = new System.Drawing.Point(290, 24);
            this._luTPART_CODE.Margin = new System.Windows.Forms.Padding(0);
            this._luTPART_CODE.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luTPART_CODE.Name = "_luTPART_CODE";
            this._luTPART_CODE.PasswordChar = '\0';
            this._luTPART_CODE.ReadOnly = false;
            this._luTPART_CODE.Size = new System.Drawing.Size(100, 22);
            this._luTPART_CODE.TabIndex = 4;
            this._luTPART_CODE.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luTPART_CODE.UseMaskAsDisplayFormat = false;
            // 
            // _luREMAIN_QTY
            // 
            this._luREMAIN_QTY.CancelButton = null;
            this._luREMAIN_QTY.CommandButton = null;
            this._luREMAIN_QTY.EditMask = "n2";
            this._luREMAIN_QTY.Location = new System.Drawing.Point(216, 100);
            this._luREMAIN_QTY.Margin = new System.Windows.Forms.Padding(0);
            this._luREMAIN_QTY.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this._luREMAIN_QTY.Name = "_luREMAIN_QTY";
            this._luREMAIN_QTY.PasswordChar = '\0';
            this._luREMAIN_QTY.ReadOnly = false;
            this._luREMAIN_QTY.Size = new System.Drawing.Size(100, 22);
            this._luREMAIN_QTY.TabIndex = 12;
            this._luREMAIN_QTY.TextAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._luREMAIN_QTY.UseMaskAsDisplayFormat = true;
            // 
            // _luCONTRACT_QTY
            // 
            this._luCONTRACT_QTY.CancelButton = null;
            this._luCONTRACT_QTY.CommandButton = null;
            this._luCONTRACT_QTY.EditMask = "n2";
            this._luCONTRACT_QTY.Location = new System.Drawing.Point(68, 100);
            this._luCONTRACT_QTY.Margin = new System.Windows.Forms.Padding(0);
            this._luCONTRACT_QTY.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this._luCONTRACT_QTY.Name = "_luCONTRACT_QTY";
            this._luCONTRACT_QTY.PasswordChar = '\0';
            this._luCONTRACT_QTY.ReadOnly = false;
            this._luCONTRACT_QTY.Size = new System.Drawing.Size(100, 22);
            this._luCONTRACT_QTY.TabIndex = 12;
            this._luCONTRACT_QTY.TextAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._luCONTRACT_QTY.UseMaskAsDisplayFormat = true;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(737, 499);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this._lciCONTRACT_ID,
            this._lciTPART_CODE,
            this._lciTPART_NAME});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup2.Size = new System.Drawing.Size(717, 50);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // _lciCONTRACT_ID
            // 
            this._lciCONTRACT_ID.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciCONTRACT_ID.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciCONTRACT_ID.Control = this._luCONTRACT_ID;
            this._lciCONTRACT_ID.Location = new System.Drawing.Point(0, 0);
            this._lciCONTRACT_ID.MaxSize = new System.Drawing.Size(222, 26);
            this._lciCONTRACT_ID.MinSize = new System.Drawing.Size(222, 26);
            this._lciCONTRACT_ID.Name = "_lciCONTRACT_ID";
            this._lciCONTRACT_ID.Size = new System.Drawing.Size(222, 26);
            this._lciCONTRACT_ID.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciCONTRACT_ID.Text = "수주찾기";
            this._lciCONTRACT_ID.TextSize = new System.Drawing.Size(40, 14);
            // 
            // _lciTPART_CODE
            // 
            this._lciTPART_CODE.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciTPART_CODE.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciTPART_CODE.Control = this._luTPART_CODE;
            this._lciTPART_CODE.Location = new System.Drawing.Point(222, 0);
            this._lciTPART_CODE.MaxSize = new System.Drawing.Size(148, 26);
            this._lciTPART_CODE.MinSize = new System.Drawing.Size(148, 26);
            this._lciTPART_CODE.Name = "_lciTPART_CODE";
            this._lciTPART_CODE.Size = new System.Drawing.Size(148, 26);
            this._lciTPART_CODE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciTPART_CODE.Text = "코드";
            this._lciTPART_CODE.TextSize = new System.Drawing.Size(40, 14);
            this._lciTPART_CODE.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // _lciTPART_NAME
            // 
            this._lciTPART_NAME.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciTPART_NAME.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciTPART_NAME.Control = this._luTPART_NAME;
            this._lciTPART_NAME.Location = new System.Drawing.Point(370, 0);
            this._lciTPART_NAME.MaxSize = new System.Drawing.Size(219, 26);
            this._lciTPART_NAME.MinSize = new System.Drawing.Size(219, 26);
            this._lciTPART_NAME.Name = "_lciTPART_NAME";
            this._lciTPART_NAME.Size = new System.Drawing.Size(323, 26);
            this._lciTPART_NAME.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciTPART_NAME.Text = "명칭";
            this._lciTPART_NAME.TextSize = new System.Drawing.Size(40, 14);
            this._lciTPART_NAME.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlItem4});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 126);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup3.Size = new System.Drawing.Size(717, 353);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this._gdMAIN;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(693, 283);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this._ucbtPLAN_SAVE;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 283);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(693, 46);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this._lciPART_CODE,
            this._lciPART_NAME,
            this._lciREMAIN_QTY,
            this._lciPLANID,
            this._lciCONTRACT_QTY,
            this._lciPLAN_QTY,
            this._ucbtAPPL,
            this.emptySpaceItem3});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 50);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(717, 76);
            this.layoutControlGroup4.TextVisible = false;
            // 
            // _lciPART_CODE
            // 
            this._lciPART_CODE.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciPART_CODE.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciPART_CODE.Control = this._luPART_CODE;
            this._lciPART_CODE.Location = new System.Drawing.Point(0, 0);
            this._lciPART_CODE.MaxSize = new System.Drawing.Size(148, 26);
            this._lciPART_CODE.MinSize = new System.Drawing.Size(148, 26);
            this._lciPART_CODE.Name = "_lciPART_CODE";
            this._lciPART_CODE.Size = new System.Drawing.Size(148, 26);
            this._lciPART_CODE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciPART_CODE.Text = "품목코드";
            this._lciPART_CODE.TextSize = new System.Drawing.Size(40, 14);
            // 
            // _lciPART_NAME
            // 
            this._lciPART_NAME.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciPART_NAME.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciPART_NAME.Control = this._luPART_NAME;
            this._lciPART_NAME.Location = new System.Drawing.Point(148, 0);
            this._lciPART_NAME.MaxSize = new System.Drawing.Size(296, 26);
            this._lciPART_NAME.MinSize = new System.Drawing.Size(296, 26);
            this._lciPART_NAME.Name = "_lciPART_NAME";
            this._lciPART_NAME.Size = new System.Drawing.Size(296, 26);
            this._lciPART_NAME.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciPART_NAME.Text = "품목명칭";
            this._lciPART_NAME.TextSize = new System.Drawing.Size(0, 0);
            this._lciPART_NAME.TextVisible = false;
            // 
            // _lciREMAIN_QTY
            // 
            this._lciREMAIN_QTY.Control = this._luREMAIN_QTY;
            this._lciREMAIN_QTY.CustomizationFormText = "잔여수량";
            this._lciREMAIN_QTY.Location = new System.Drawing.Point(148, 26);
            this._lciREMAIN_QTY.MaxSize = new System.Drawing.Size(148, 26);
            this._lciREMAIN_QTY.MinSize = new System.Drawing.Size(148, 26);
            this._lciREMAIN_QTY.Name = "_lciREMAIN_QTY";
            this._lciREMAIN_QTY.Size = new System.Drawing.Size(148, 26);
            this._lciREMAIN_QTY.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciREMAIN_QTY.Text = "잔여수량";
            this._lciREMAIN_QTY.TextSize = new System.Drawing.Size(40, 14);
            // 
            // _lciPLANID
            // 
            this._lciPLANID.Control = this._luPLANID;
            this._lciPLANID.Location = new System.Drawing.Point(444, 0);
            this._lciPLANID.MaxSize = new System.Drawing.Size(249, 26);
            this._lciPLANID.MinSize = new System.Drawing.Size(249, 26);
            this._lciPLANID.Name = "_lciPLANID";
            this._lciPLANID.Size = new System.Drawing.Size(249, 26);
            this._lciPLANID.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciPLANID.Text = "계획번호";
            this._lciPLANID.TextSize = new System.Drawing.Size(40, 14);
            this._lciPLANID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // _lciCONTRACT_QTY
            // 
            this._lciCONTRACT_QTY.Control = this._luCONTRACT_QTY;
            this._lciCONTRACT_QTY.CustomizationFormText = "수주수량";
            this._lciCONTRACT_QTY.Location = new System.Drawing.Point(0, 26);
            this._lciCONTRACT_QTY.MaxSize = new System.Drawing.Size(148, 26);
            this._lciCONTRACT_QTY.MinSize = new System.Drawing.Size(148, 26);
            this._lciCONTRACT_QTY.Name = "_lciCONTRACT_QTY";
            this._lciCONTRACT_QTY.Size = new System.Drawing.Size(148, 26);
            this._lciCONTRACT_QTY.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciCONTRACT_QTY.Text = "수주수량";
            this._lciCONTRACT_QTY.TextSize = new System.Drawing.Size(40, 14);
            // 
            // _lciPLAN_QTY
            // 
            this._lciPLAN_QTY.Control = this._luPLAN_QTY;
            this._lciPLAN_QTY.Location = new System.Drawing.Point(296, 26);
            this._lciPLAN_QTY.MaxSize = new System.Drawing.Size(148, 26);
            this._lciPLAN_QTY.MinSize = new System.Drawing.Size(148, 26);
            this._lciPLAN_QTY.Name = "_lciPLAN_QTY";
            this._lciPLAN_QTY.Size = new System.Drawing.Size(148, 26);
            this._lciPLAN_QTY.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciPLAN_QTY.Text = "계획수량";
            this._lciPLAN_QTY.TextSize = new System.Drawing.Size(40, 14);
            // 
            // _ucbtAPPL
            // 
            this._ucbtAPPL.Control = this._ucbtAPPLY;
            this._ucbtAPPL.Location = new System.Drawing.Point(444, 26);
            this._ucbtAPPL.MaxSize = new System.Drawing.Size(130, 26);
            this._ucbtAPPL.MinSize = new System.Drawing.Size(130, 26);
            this._ucbtAPPL.Name = "_ucbtAPPL";
            this._ucbtAPPL.Size = new System.Drawing.Size(130, 26);
            this._ucbtAPPL.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._ucbtAPPL.TextSize = new System.Drawing.Size(0, 0);
            this._ucbtAPPL.TextVisible = false;
            this._ucbtAPPL.Click += new System.EventHandler(this._btAPPLY_Click);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(574, 26);
            this.emptySpaceItem3.MaxSize = new System.Drawing.Size(119, 26);
            this.emptySpaceItem3.MinSize = new System.Drawing.Size(119, 26);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(119, 26);
            this.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ucProductPlanInfoPopup_T01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ucProductPlanInfoPopup_T01";
            this.Size = new System.Drawing.Size(737, 499);
            this.Load += new System.EventHandler(this.ucProductPlanInfoPopup_T01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCONTRACT_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTPART_CODE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTPART_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPART_CODE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPART_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciREMAIN_QTY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPLANID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCONTRACT_QTY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPLAN_QTY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ucbtAPPL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
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
        private CoFAS_MES.CORE.BaseControls.ucTextEdit _luPART_NAME;
        private CoFAS_MES.CORE.BaseControls.ucTextEdit _luPART_CODE;
        private CoFAS_MES.CORE.BaseControls.ucButtonEdit _luCONTRACT_ID;
        private DevExpress.XtraLayout.LayoutControlItem _lciCONTRACT_ID;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem _lciPART_CODE;
        private DevExpress.XtraLayout.LayoutControlItem _lciPART_NAME;
        private CoFAS_MES.CORE.BaseControls.ucTextEdit _luPLAN_QTY;
        private DevExpress.XtraLayout.LayoutControlItem _lciPLAN_QTY;
        private CoFAS_MES.CORE.BaseControls.ucSimpleButton _ucbtPLAN_SAVE;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private CoFAS_MES.CORE.BaseControls.ucSimpleButton _ucbtAPPLY;
        private DevExpress.XtraLayout.LayoutControlItem _ucbtAPPL;
        private CoFAS_MES.CORE.BaseControls.ucTextEdit _luPLANID;
        private DevExpress.XtraLayout.LayoutControlItem _lciPLANID;
        private CORE.BaseControls.ucTextEdit _luREMAIN_QTY;
        private DevExpress.XtraLayout.LayoutControlItem _lciREMAIN_QTY;
        private CORE.BaseControls.ucTextEdit _luCONTRACT_QTY;
        private DevExpress.XtraLayout.LayoutControlItem _lciCONTRACT_QTY;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
    }
}
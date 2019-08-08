namespace CoFAS_MES.CORE.UserControls
{
    partial class ucMaterialOrderInfoPopup_T01
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
            this._ucbtORDER_SAVE = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._ucbtCLEAR = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._ucbtSELECT = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._gdMAIN = new DevExpress.XtraGrid.GridControl();
            this._gdMAIN_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._luVEND_NAME = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luPART_NAME = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luTORDER_DATE = new CoFAS_MES.CORE.BaseControls.ucFromToDateEdit();
            this._ucbtCANCLE = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._luTPART_CODE = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luTPART_NAME = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._ucbtSEARCH = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this._lciPART_NAME = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciVEND_NAME = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciORDER_DATE = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            this._lciTPART_CODE = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciTPART_NAME = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPART_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciVEND_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciORDER_DATE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTPART_CODE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTPART_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._ucbtORDER_SAVE);
            this.layoutControl1.Controls.Add(this._ucbtCLEAR);
            this.layoutControl1.Controls.Add(this._ucbtSELECT);
            this.layoutControl1.Controls.Add(this._gdMAIN);
            this.layoutControl1.Controls.Add(this._luVEND_NAME);
            this.layoutControl1.Controls.Add(this._luPART_NAME);
            this.layoutControl1.Controls.Add(this._luTORDER_DATE);
            this.layoutControl1.Controls.Add(this._ucbtCANCLE);
            this.layoutControl1.Controls.Add(this._luTPART_CODE);
            this.layoutControl1.Controls.Add(this._luTPART_NAME);
            this.layoutControl1.Controls.Add(this._ucbtSEARCH);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(2485, 23, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(873, 526);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _ucbtORDER_SAVE
            // 
            this._ucbtORDER_SAVE.ButtonText = "저장";
            this._ucbtORDER_SAVE.Image = global::CoFAS_MES.CORE.Properties.Resources.saveto_16x16;
            this._ucbtORDER_SAVE.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtORDER_SAVE.Location = new System.Drawing.Point(12, 476);
            this._ucbtORDER_SAVE.Name = "_ucbtORDER_SAVE";
            this._ucbtORDER_SAVE.Size = new System.Drawing.Size(849, 38);
            this._ucbtORDER_SAVE.TabIndex = 17;
            this._ucbtORDER_SAVE.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtPLAN_SAVE_Click);
            // 
            // _ucbtCLEAR
            // 
            this._ucbtCLEAR.ButtonText = "초기화";
            this._ucbtCLEAR.Image = global::CoFAS_MES.CORE.Properties.Resources.refresh_16x16;
            this._ucbtCLEAR.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtCLEAR.Location = new System.Drawing.Point(616, 98);
            this._ucbtCLEAR.Name = "_ucbtCLEAR";
            this._ucbtCLEAR.Size = new System.Drawing.Size(122, 20);
            this._ucbtCLEAR.TabIndex = 10;
            this._ucbtCLEAR.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtCLEAR_Click);
            // 
            // _ucbtSELECT
            // 
            this._ucbtSELECT.ButtonText = "발주조회";
            this._ucbtSELECT.Image = global::CoFAS_MES.CORE.Properties.Resources.zoom_16x16;
            this._ucbtSELECT.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtSELECT.Location = new System.Drawing.Point(461, 98);
            this._ucbtSELECT.Name = "_ucbtSELECT";
            this._ucbtSELECT.Size = new System.Drawing.Size(151, 20);
            this._ucbtSELECT.TabIndex = 9;
            this._ucbtSELECT.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtSELECT_Click);
            // 
            // _gdMAIN
            // 
            this._gdMAIN.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gdMAIN.Location = new System.Drawing.Point(24, 146);
            this._gdMAIN.MainView = this._gdMAIN_VIEW;
            this._gdMAIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gdMAIN.Name = "_gdMAIN";
            this._gdMAIN.Size = new System.Drawing.Size(825, 314);
            this._gdMAIN.TabIndex = 8;
            this._gdMAIN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gdMAIN_VIEW});
            // 
            // _gdMAIN_VIEW
            // 
            this._gdMAIN_VIEW.GridControl = this._gdMAIN;
            this._gdMAIN_VIEW.Name = "_gdMAIN_VIEW";
            // 
            // _luVEND_NAME
            // 
            this._luVEND_NAME.CancelButton = null;
            this._luVEND_NAME.CommandButton = null;
            this._luVEND_NAME.EditMask = "";
            this._luVEND_NAME.Location = new System.Drawing.Point(660, 74);
            this._luVEND_NAME.Margin = new System.Windows.Forms.Padding(0);
            this._luVEND_NAME.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luVEND_NAME.Name = "_luVEND_NAME";
            this._luVEND_NAME.PasswordChar = '\0';
            this._luVEND_NAME.ReadOnly = false;
            this._luVEND_NAME.Size = new System.Drawing.Size(189, 20);
            this._luVEND_NAME.TabIndex = 5;
            this._luVEND_NAME.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luVEND_NAME.UseMaskAsDisplayFormat = false;
            // 
            // _luPART_NAME
            // 
            this._luPART_NAME.CancelButton = null;
            this._luPART_NAME.CommandButton = null;
            this._luPART_NAME.EditMask = "";
            this._luPART_NAME.Location = new System.Drawing.Point(399, 74);
            this._luPART_NAME.Margin = new System.Windows.Forms.Padding(0);
            this._luPART_NAME.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luPART_NAME.Name = "_luPART_NAME";
            this._luPART_NAME.PasswordChar = '\0';
            this._luPART_NAME.ReadOnly = false;
            this._luPART_NAME.Size = new System.Drawing.Size(213, 20);
            this._luPART_NAME.TabIndex = 4;
            this._luPART_NAME.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luPART_NAME.UseMaskAsDisplayFormat = false;
            // 
            // _luTORDER_DATE
            // 
            this._luTORDER_DATE.FromDateTime = new System.DateTime(2018, 4, 1, 0, 0, 0, 0);
            this._luTORDER_DATE.Location = new System.Drawing.Point(68, 74);
            this._luTORDER_DATE.Margin = new System.Windows.Forms.Padding(0);
            this._luTORDER_DATE.Name = "_luTORDER_DATE";
            this._luTORDER_DATE.Size = new System.Drawing.Size(283, 20);
            this._luTORDER_DATE.TabIndex = 4;
            this._luTORDER_DATE.ToDateTime = new System.DateTime(2018, 4, 26, 23, 59, 59, 0);
            // 
            // _ucbtCANCLE
            // 
            this._ucbtCANCLE.ButtonText = "닫기";
            this._ucbtCANCLE.Image = global::CoFAS_MES.CORE.Properties.Resources.close_16x162;
            this._ucbtCANCLE.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtCANCLE.Location = new System.Drawing.Point(742, 98);
            this._ucbtCANCLE.Name = "_ucbtCANCLE";
            this._ucbtCANCLE.Size = new System.Drawing.Size(107, 20);
            this._ucbtCANCLE.TabIndex = 11;
            this._ucbtCANCLE.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtCancle_Click);
            // 
            // _luTPART_CODE
            // 
            this._luTPART_CODE.CancelButton = null;
            this._luTPART_CODE.CommandButton = null;
            this._luTPART_CODE.EditMask = "";
            this._luTPART_CODE.Location = new System.Drawing.Point(68, 24);
            this._luTPART_CODE.Margin = new System.Windows.Forms.Padding(0);
            this._luTPART_CODE.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luTPART_CODE.Name = "_luTPART_CODE";
            this._luTPART_CODE.PasswordChar = '\0';
            this._luTPART_CODE.ReadOnly = false;
            this._luTPART_CODE.Size = new System.Drawing.Size(174, 22);
            this._luTPART_CODE.TabIndex = 4;
            this._luTPART_CODE.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luTPART_CODE.UseMaskAsDisplayFormat = false;
            // 
            // _luTPART_NAME
            // 
            this._luTPART_NAME.CancelButton = null;
            this._luTPART_NAME.CommandButton = null;
            this._luTPART_NAME.EditMask = "";
            this._luTPART_NAME.Location = new System.Drawing.Point(290, 24);
            this._luTPART_NAME.Margin = new System.Windows.Forms.Padding(0);
            this._luTPART_NAME.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luTPART_NAME.Name = "_luTPART_NAME";
            this._luTPART_NAME.PasswordChar = '\0';
            this._luTPART_NAME.ReadOnly = false;
            this._luTPART_NAME.Size = new System.Drawing.Size(210, 22);
            this._luTPART_NAME.TabIndex = 5;
            this._luTPART_NAME.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luTPART_NAME.UseMaskAsDisplayFormat = false;
            // 
            // _ucbtSEARCH
            // 
            this._ucbtSEARCH.ButtonText = "목록조회";
            this._ucbtSEARCH.Image = global::CoFAS_MES.CORE.Properties.Resources.zoom_16x16;
            this._ucbtSEARCH.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtSEARCH.Location = new System.Drawing.Point(504, 24);
            this._ucbtSEARCH.Name = "_ucbtSEARCH";
            this._ucbtSEARCH.Size = new System.Drawing.Size(109, 22);
            this._ucbtSEARCH.TabIndex = 16;
            this._ucbtSEARCH.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._btSELECT_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3,
            this.layoutControlGroup5,
            this.layoutControlItem6});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(873, 526);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this._lciPART_NAME,
            this._lciVEND_NAME,
            this._lciORDER_DATE,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.emptySpaceItem4,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 50);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup2.Size = new System.Drawing.Size(853, 72);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // _lciPART_NAME
            // 
            this._lciPART_NAME.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciPART_NAME.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciPART_NAME.Control = this._luPART_NAME;
            this._lciPART_NAME.CustomizationFormText = "발주일자";
            this._lciPART_NAME.Location = new System.Drawing.Point(331, 0);
            this._lciPART_NAME.Name = "_lciPART_NAME";
            this._lciPART_NAME.Size = new System.Drawing.Size(261, 24);
            this._lciPART_NAME.Text = "자재명";
            this._lciPART_NAME.TextSize = new System.Drawing.Size(40, 14);
            // 
            // _lciVEND_NAME
            // 
            this._lciVEND_NAME.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciVEND_NAME.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciVEND_NAME.Control = this._luVEND_NAME;
            this._lciVEND_NAME.CustomizationFormText = "거래처명";
            this._lciVEND_NAME.Location = new System.Drawing.Point(592, 0);
            this._lciVEND_NAME.Name = "_lciVEND_NAME";
            this._lciVEND_NAME.Size = new System.Drawing.Size(237, 24);
            this._lciVEND_NAME.Text = "거래처명";
            this._lciVEND_NAME.TextSize = new System.Drawing.Size(40, 14);
            // 
            // _lciORDER_DATE
            // 
            this._lciORDER_DATE.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciORDER_DATE.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciORDER_DATE.Control = this._luTORDER_DATE;
            this._lciORDER_DATE.CustomizationFormText = "_lciTORDER_DATE";
            this._lciORDER_DATE.Location = new System.Drawing.Point(0, 0);
            this._lciORDER_DATE.Name = "_lciORDER_DATE";
            this._lciORDER_DATE.Size = new System.Drawing.Size(331, 24);
            this._lciORDER_DATE.Text = "발주기간";
            this._lciORDER_DATE.TextSize = new System.Drawing.Size(40, 14);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 24);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(108, 24);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(108, 24);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(108, 24);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(216, 24);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(115, 24);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this._ucbtSELECT;
            this.layoutControlItem1.Location = new System.Drawing.Point(437, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(155, 24);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this._ucbtCLEAR;
            this.layoutControlItem2.Location = new System.Drawing.Point(592, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(126, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this._ucbtCANCLE;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(718, 24);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(111, 24);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(331, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(106, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 122);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup3.Size = new System.Drawing.Size(853, 342);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this._gdMAIN;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(829, 318);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.CustomizationFormText = "layoutControlGroup2";
            this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this._lciTPART_CODE,
            this._lciTPART_NAME,
            this.emptySpaceItem5,
            this.layoutControlItem4});
            this.layoutControlGroup5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup5.Name = "layoutControlGroup5";
            this.layoutControlGroup5.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup5.Size = new System.Drawing.Size(853, 50);
            this.layoutControlGroup5.Text = "layoutControlGroup2";
            this.layoutControlGroup5.TextVisible = false;
            // 
            // _lciTPART_CODE
            // 
            this._lciTPART_CODE.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciTPART_CODE.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciTPART_CODE.Control = this._luTPART_CODE;
            this._lciTPART_CODE.CustomizationFormText = "코드";
            this._lciTPART_CODE.Location = new System.Drawing.Point(0, 0);
            this._lciTPART_CODE.MaxSize = new System.Drawing.Size(222, 26);
            this._lciTPART_CODE.MinSize = new System.Drawing.Size(222, 26);
            this._lciTPART_CODE.Name = "_lciTPART_CODE";
            this._lciTPART_CODE.Size = new System.Drawing.Size(222, 26);
            this._lciTPART_CODE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciTPART_CODE.Text = "코드";
            this._lciTPART_CODE.TextSize = new System.Drawing.Size(40, 14);
            // 
            // _lciTPART_NAME
            // 
            this._lciTPART_NAME.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciTPART_NAME.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciTPART_NAME.Control = this._luTPART_NAME;
            this._lciTPART_NAME.CustomizationFormText = "명칭";
            this._lciTPART_NAME.Location = new System.Drawing.Point(222, 0);
            this._lciTPART_NAME.MaxSize = new System.Drawing.Size(258, 26);
            this._lciTPART_NAME.MinSize = new System.Drawing.Size(258, 26);
            this._lciTPART_NAME.Name = "_lciTPART_NAME";
            this._lciTPART_NAME.Size = new System.Drawing.Size(258, 26);
            this._lciTPART_NAME.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciTPART_NAME.Text = "명칭";
            this._lciTPART_NAME.TextSize = new System.Drawing.Size(40, 14);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem5.Location = new System.Drawing.Point(593, 0);
            this.emptySpaceItem5.MaxSize = new System.Drawing.Size(236, 0);
            this.emptySpaceItem5.MinSize = new System.Drawing.Size(236, 24);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(236, 26);
            this.emptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem5.Text = "emptySpaceItem2";
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this._ucbtSEARCH;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem4.Location = new System.Drawing.Point(480, 0);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(113, 26);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(113, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(113, 26);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "layoutControlItem2";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this._ucbtORDER_SAVE;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 464);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(0, 42);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(104, 42);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(853, 42);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // ucMaterialOrderInfoPopup_T01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucMaterialOrderInfoPopup_T01";
            this.Size = new System.Drawing.Size(873, 526);
            this.Load += new System.EventHandler(this.ucProductionOrderInfoPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPART_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciVEND_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciORDER_DATE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTPART_CODE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTPART_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl _gdMAIN;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdMAIN_VIEW;
        private BaseControls.ucTextEdit _luVEND_NAME;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem _lciVEND_NAME;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private BaseControls.ucTextEdit _luPART_NAME;
        private DevExpress.XtraLayout.LayoutControlItem _lciPART_NAME;
        private BaseControls.ucFromToDateEdit _luTORDER_DATE;
        private DevExpress.XtraLayout.LayoutControlItem _lciORDER_DATE;
        private BaseControls.ucSimpleButton _ucbtCLEAR;
        private BaseControls.ucSimpleButton _ucbtSELECT;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private BaseControls.ucSimpleButton _ucbtCANCLE;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private BaseControls.ucTextEdit _luTPART_CODE;
        private BaseControls.ucTextEdit _luTPART_NAME;
        private BaseControls.ucSimpleButton _ucbtSEARCH;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
        private DevExpress.XtraLayout.LayoutControlItem _lciTPART_CODE;
        private DevExpress.XtraLayout.LayoutControlItem _lciTPART_NAME;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private BaseControls.ucSimpleButton _ucbtORDER_SAVE;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}

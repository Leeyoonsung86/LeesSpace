namespace CoFAS_MES.UI.IM.UserControls
{
    partial class ucPartProcessMapping_Popup
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
            this._luPART_CODE = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luPART_NAME = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._ucbtCLOSE = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._ucbtSAVE = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._ucbtSEARCH = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._luREVISION_NO = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luCONFIGURATION_MST_NAME = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._gdMAIN = new DevExpress.XtraGrid.GridControl();
            this._gdMAIN_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._luCONFIGURATION_MST_CODE = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this._lciCONFIGURATION_MST_CODE = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciREVISION_NO = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciCONFIGURATION_MST_NAME = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this._lciPART_NAME = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciPART_CODE = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCONFIGURATION_MST_CODE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciREVISION_NO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCONFIGURATION_MST_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPART_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPART_CODE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._luPART_CODE);
            this.layoutControl1.Controls.Add(this._luPART_NAME);
            this.layoutControl1.Controls.Add(this._ucbtCLOSE);
            this.layoutControl1.Controls.Add(this._ucbtSAVE);
            this.layoutControl1.Controls.Add(this._ucbtSEARCH);
            this.layoutControl1.Controls.Add(this._luREVISION_NO);
            this.layoutControl1.Controls.Add(this._luCONFIGURATION_MST_NAME);
            this.layoutControl1.Controls.Add(this._gdMAIN);
            this.layoutControl1.Controls.Add(this._luCONFIGURATION_MST_CODE);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(633, 273, 817, 606);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(909, 582);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _luPART_CODE
            // 
            this._luPART_CODE.CancelButton = null;
            this._luPART_CODE.CommandButton = null;
            this._luPART_CODE.EditMask = "";
            this._luPART_CODE.Location = new System.Drawing.Point(129, 50);
            this._luPART_CODE.Margin = new System.Windows.Forms.Padding(0);
            this._luPART_CODE.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luPART_CODE.Name = "_luPART_CODE";
            this._luPART_CODE.PasswordChar = '\0';
            this._luPART_CODE.ReadOnly = false;
            this._luPART_CODE.Size = new System.Drawing.Size(167, 21);
            this._luPART_CODE.TabIndex = 13;
            this._luPART_CODE.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luPART_CODE.UseMaskAsDisplayFormat = false;
            // 
            // _luPART_NAME
            // 
            this._luPART_NAME.CancelButton = null;
            this._luPART_NAME.CommandButton = null;
            this._luPART_NAME.EditMask = "";
            this._luPART_NAME.Location = new System.Drawing.Point(405, 50);
            this._luPART_NAME.Margin = new System.Windows.Forms.Padding(0);
            this._luPART_NAME.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luPART_NAME.Name = "_luPART_NAME";
            this._luPART_NAME.PasswordChar = '\0';
            this._luPART_NAME.ReadOnly = false;
            this._luPART_NAME.Size = new System.Drawing.Size(206, 21);
            this._luPART_NAME.TabIndex = 12;
            this._luPART_NAME.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luPART_NAME.UseMaskAsDisplayFormat = false;
            // 
            // _ucbtCLOSE
            // 
            this._ucbtCLOSE.ButtonText = "닫기";
            this._ucbtCLOSE.Image = global::CoFAS_MES.UI.IM.Properties.Resources.close_16x16;
            this._ucbtCLOSE.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtCLOSE.Location = new System.Drawing.Point(751, 536);
            this._ucbtCLOSE.Name = "_ucbtCLOSE";
            this._ucbtCLOSE.Size = new System.Drawing.Size(134, 22);
            this._ucbtCLOSE.TabIndex = 11;
            this._ucbtCLOSE.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtCLOSE_Click);
            // 
            // _ucbtSAVE
            // 
            this._ucbtSAVE.ButtonText = "저장";
            this._ucbtSAVE.Image = global::CoFAS_MES.UI.IM.Properties.Resources.save_16x16;
            this._ucbtSAVE.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtSAVE.Location = new System.Drawing.Point(609, 536);
            this._ucbtSAVE.Name = "_ucbtSAVE";
            this._ucbtSAVE.Size = new System.Drawing.Size(138, 22);
            this._ucbtSAVE.TabIndex = 10;
            this._ucbtSAVE.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtSAVE_Click);
            // 
            // _ucbtSEARCH
            // 
            this._ucbtSEARCH.ButtonText = "조회";
            this._ucbtSEARCH.Image = global::CoFAS_MES.UI.IM.Properties.Resources.zoom_16x16;
            this._ucbtSEARCH.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtSEARCH.Location = new System.Drawing.Point(739, 50);
            this._ucbtSEARCH.Name = "_ucbtSEARCH";
            this._ucbtSEARCH.Size = new System.Drawing.Size(146, 21);
            this._ucbtSEARCH.TabIndex = 9;
            this._ucbtSEARCH.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtSEARCH_Click);
            // 
            // _luREVISION_NO
            // 
            this._luREVISION_NO.CancelButton = null;
            this._luREVISION_NO.CommandButton = null;
            this._luREVISION_NO.EditMask = "";
            this._luREVISION_NO.Location = new System.Drawing.Point(720, 24);
            this._luREVISION_NO.Margin = new System.Windows.Forms.Padding(0);
            this._luREVISION_NO.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luREVISION_NO.Name = "_luREVISION_NO";
            this._luREVISION_NO.PasswordChar = '\0';
            this._luREVISION_NO.ReadOnly = true;
            this._luREVISION_NO.Size = new System.Drawing.Size(165, 22);
            this._luREVISION_NO.TabIndex = 8;
            this._luREVISION_NO.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luREVISION_NO.UseMaskAsDisplayFormat = false;
            // 
            // _luCONFIGURATION_MST_NAME
            // 
            this._luCONFIGURATION_MST_NAME.CancelButton = null;
            this._luCONFIGURATION_MST_NAME.CommandButton = null;
            this._luCONFIGURATION_MST_NAME.EditMask = "";
            this._luCONFIGURATION_MST_NAME.Location = new System.Drawing.Point(405, 24);
            this._luCONFIGURATION_MST_NAME.Margin = new System.Windows.Forms.Padding(0);
            this._luCONFIGURATION_MST_NAME.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luCONFIGURATION_MST_NAME.Name = "_luCONFIGURATION_MST_NAME";
            this._luCONFIGURATION_MST_NAME.PasswordChar = '\0';
            this._luCONFIGURATION_MST_NAME.ReadOnly = true;
            this._luCONFIGURATION_MST_NAME.Size = new System.Drawing.Size(206, 22);
            this._luCONFIGURATION_MST_NAME.TabIndex = 6;
            this._luCONFIGURATION_MST_NAME.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luCONFIGURATION_MST_NAME.UseMaskAsDisplayFormat = false;
            // 
            // _gdMAIN
            // 
            this._gdMAIN.Location = new System.Drawing.Point(24, 99);
            this._gdMAIN.MainView = this._gdMAIN_VIEW;
            this._gdMAIN.Name = "_gdMAIN";
            this._gdMAIN.Size = new System.Drawing.Size(861, 409);
            this._gdMAIN.TabIndex = 5;
            this._gdMAIN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gdMAIN_VIEW});
            // 
            // _gdMAIN_VIEW
            // 
            this._gdMAIN_VIEW.GridControl = this._gdMAIN;
            this._gdMAIN_VIEW.Name = "_gdMAIN_VIEW";
            // 
            // _luCONFIGURATION_MST_CODE
            // 
            this._luCONFIGURATION_MST_CODE.CancelButton = null;
            this._luCONFIGURATION_MST_CODE.CommandButton = null;
            this._luCONFIGURATION_MST_CODE.EditMask = "";
            this._luCONFIGURATION_MST_CODE.Location = new System.Drawing.Point(129, 24);
            this._luCONFIGURATION_MST_CODE.Margin = new System.Windows.Forms.Padding(0);
            this._luCONFIGURATION_MST_CODE.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luCONFIGURATION_MST_CODE.Name = "_luCONFIGURATION_MST_CODE";
            this._luCONFIGURATION_MST_CODE.PasswordChar = '\0';
            this._luCONFIGURATION_MST_CODE.ReadOnly = true;
            this._luCONFIGURATION_MST_CODE.Size = new System.Drawing.Size(167, 22);
            this._luCONFIGURATION_MST_CODE.TabIndex = 4;
            this._luCONFIGURATION_MST_CODE.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luCONFIGURATION_MST_CODE.UseMaskAsDisplayFormat = false;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(909, 582);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this._lciCONFIGURATION_MST_CODE,
            this._lciREVISION_NO,
            this._lciCONFIGURATION_MST_NAME,
            this.layoutControlItem6,
            this.emptySpaceItem2,
            this._lciPART_NAME,
            this._lciPART_CODE});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(889, 75);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // _lciCONFIGURATION_MST_CODE
            // 
            this._lciCONFIGURATION_MST_CODE.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciCONFIGURATION_MST_CODE.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciCONFIGURATION_MST_CODE.Control = this._luCONFIGURATION_MST_CODE;
            this._lciCONFIGURATION_MST_CODE.Location = new System.Drawing.Point(0, 0);
            this._lciCONFIGURATION_MST_CODE.MinSize = new System.Drawing.Size(209, 24);
            this._lciCONFIGURATION_MST_CODE.Name = "_lciCONFIGURATION_MST_CODE";
            this._lciCONFIGURATION_MST_CODE.Size = new System.Drawing.Size(276, 26);
            this._lciCONFIGURATION_MST_CODE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciCONFIGURATION_MST_CODE.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this._lciCONFIGURATION_MST_CODE.TextSize = new System.Drawing.Size(100, 14);
            this._lciCONFIGURATION_MST_CODE.TextToControlDistance = 5;
            // 
            // _lciREVISION_NO
            // 
            this._lciREVISION_NO.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciREVISION_NO.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciREVISION_NO.Control = this._luREVISION_NO;
            this._lciREVISION_NO.Location = new System.Drawing.Point(591, 0);
            this._lciREVISION_NO.MinSize = new System.Drawing.Size(209, 24);
            this._lciREVISION_NO.Name = "_lciREVISION_NO";
            this._lciREVISION_NO.OptionsTableLayoutItem.ColumnIndex = 2;
            this._lciREVISION_NO.Size = new System.Drawing.Size(274, 26);
            this._lciREVISION_NO.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciREVISION_NO.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this._lciREVISION_NO.TextSize = new System.Drawing.Size(100, 14);
            this._lciREVISION_NO.TextToControlDistance = 5;
            // 
            // _lciCONFIGURATION_MST_NAME
            // 
            this._lciCONFIGURATION_MST_NAME.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciCONFIGURATION_MST_NAME.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciCONFIGURATION_MST_NAME.Control = this._luCONFIGURATION_MST_NAME;
            this._lciCONFIGURATION_MST_NAME.Location = new System.Drawing.Point(276, 0);
            this._lciCONFIGURATION_MST_NAME.MinSize = new System.Drawing.Size(209, 24);
            this._lciCONFIGURATION_MST_NAME.Name = "_lciCONFIGURATION_MST_NAME";
            this._lciCONFIGURATION_MST_NAME.OptionsTableLayoutItem.ColumnIndex = 1;
            this._lciCONFIGURATION_MST_NAME.Size = new System.Drawing.Size(315, 26);
            this._lciCONFIGURATION_MST_NAME.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciCONFIGURATION_MST_NAME.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this._lciCONFIGURATION_MST_NAME.TextSize = new System.Drawing.Size(100, 14);
            this._lciCONFIGURATION_MST_NAME.TextToControlDistance = 5;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this._ucbtSEARCH;
            this.layoutControlItem6.Location = new System.Drawing.Point(715, 26);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlItem6.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem6.Size = new System.Drawing.Size(150, 25);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(591, 26);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(124, 25);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // _lciPART_NAME
            // 
            this._lciPART_NAME.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciPART_NAME.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciPART_NAME.Control = this._luPART_NAME;
            this._lciPART_NAME.Location = new System.Drawing.Point(276, 26);
            this._lciPART_NAME.Name = "_lciPART_NAME";
            this._lciPART_NAME.Size = new System.Drawing.Size(315, 25);
            this._lciPART_NAME.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this._lciPART_NAME.TextSize = new System.Drawing.Size(100, 14);
            this._lciPART_NAME.TextToControlDistance = 5;
            // 
            // _lciPART_CODE
            // 
            this._lciPART_CODE.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciPART_CODE.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciPART_CODE.Control = this._luPART_CODE;
            this._lciPART_CODE.Location = new System.Drawing.Point(0, 26);
            this._lciPART_CODE.Name = "_lciPART_CODE";
            this._lciPART_CODE.Size = new System.Drawing.Size(276, 25);
            this._lciPART_CODE.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this._lciPART_CODE.TextSize = new System.Drawing.Size(100, 14);
            this._lciPART_CODE.TextToControlDistance = 5;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.emptySpaceItem1});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 512);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(889, 50);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this._ucbtSAVE;
            this.layoutControlItem7.Location = new System.Drawing.Point(585, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(142, 26);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this._ucbtCLOSE;
            this.layoutControlItem8.Location = new System.Drawing.Point(727, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(138, 26);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(585, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 75);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(889, 437);
            this.layoutControlGroup4.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this._gdMAIN;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(865, 413);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // ucPartProcessMapping_Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ucPartProcessMapping_Popup";
            this.Size = new System.Drawing.Size(909, 582);
            this.Load += new System.EventHandler(this.ucPartProcessMapping_Popup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCONFIGURATION_MST_CODE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciREVISION_NO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCONFIGURATION_MST_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPART_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPART_CODE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private CORE.BaseControls.ucTextEdit _luPART_CODE;
        private CORE.BaseControls.ucTextEdit _luPART_NAME;
        private CORE.BaseControls.ucSimpleButton _ucbtCLOSE;
        private CORE.BaseControls.ucSimpleButton _ucbtSAVE;
        private CORE.BaseControls.ucSimpleButton _ucbtSEARCH;
        private CORE.BaseControls.ucTextEdit _luREVISION_NO;
        private CORE.BaseControls.ucTextEdit _luCONFIGURATION_MST_NAME;
        private DevExpress.XtraGrid.GridControl _gdMAIN;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdMAIN_VIEW;
        private CORE.BaseControls.ucTextEdit _luCONFIGURATION_MST_CODE;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem _lciCONFIGURATION_MST_CODE;
        private DevExpress.XtraLayout.LayoutControlItem _lciREVISION_NO;
        private DevExpress.XtraLayout.LayoutControlItem _lciCONFIGURATION_MST_NAME;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem _lciPART_NAME;
        private DevExpress.XtraLayout.LayoutControlItem _lciPART_CODE;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}

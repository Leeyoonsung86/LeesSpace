namespace CoFAS_MES.UI.PO.UserControls
{
    partial class ucWorkResultPopUp_T01
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
            this._gdMAIN = new DevExpress.XtraGrid.GridControl();
            this._gdMAIN_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._luSTATUS_TIME = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luSTATUS_CODE = new CoFAS_MES.CORE.BaseControls.ucLookUpEdit();
            this._luSTATUS_GROUP = new CoFAS_MES.CORE.BaseControls.ucLookUpEdit();
            this._luRESULT_QTY = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luBAD_CODE = new CoFAS_MES.CORE.BaseControls.ucLookUpEdit();
            this._luBAD_GROUP = new CoFAS_MES.CORE.BaseControls.ucLookUpEdit();
            this._luPROCESS_CODE = new CoFAS_MES.CORE.BaseControls.ucLookUpEdit();
            this._luPART_NAME = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luPART_CODE = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luRESULT_GUBN = new CoFAS_MES.CORE.BaseControls.ucLookUpEdit();
            this._luWORKORDERID = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._btSAVE = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._btCancle = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciWORKORDERID = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciRESULT_GUBN = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciPART_CODE = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciPART_NAME = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciBAD_GROUP = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciRESULT_QTY = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciSTATUS_GROUP = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciBAD_CODE = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciSTATUS_CODE = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciSTATUS_TIME = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciPROCESS_CODE = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciWORKORDERID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciRESULT_GUBN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPART_CODE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPART_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciBAD_GROUP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciRESULT_QTY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciSTATUS_GROUP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciBAD_CODE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciSTATUS_CODE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciSTATUS_TIME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPROCESS_CODE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._gdMAIN);
            this.layoutControl1.Controls.Add(this._luSTATUS_TIME);
            this.layoutControl1.Controls.Add(this._luSTATUS_CODE);
            this.layoutControl1.Controls.Add(this._luSTATUS_GROUP);
            this.layoutControl1.Controls.Add(this._luRESULT_QTY);
            this.layoutControl1.Controls.Add(this._luBAD_CODE);
            this.layoutControl1.Controls.Add(this._luBAD_GROUP);
            this.layoutControl1.Controls.Add(this._luPROCESS_CODE);
            this.layoutControl1.Controls.Add(this._luPART_NAME);
            this.layoutControl1.Controls.Add(this._luPART_CODE);
            this.layoutControl1.Controls.Add(this._luRESULT_GUBN);
            this.layoutControl1.Controls.Add(this._luWORKORDERID);
            this.layoutControl1.Controls.Add(this._btSAVE);
            this.layoutControl1.Controls.Add(this._btCancle);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(484, 515);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _gdMAIN
            // 
            this._gdMAIN.Location = new System.Drawing.Point(12, 228);
            this._gdMAIN.MainView = this._gdMAIN_VIEW;
            this._gdMAIN.Name = "_gdMAIN";
            this._gdMAIN.Size = new System.Drawing.Size(460, 275);
            this._gdMAIN.TabIndex = 24;
            this._gdMAIN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gdMAIN_VIEW});
            // 
            // _gdMAIN_VIEW
            // 
            this._gdMAIN_VIEW.GridControl = this._gdMAIN;
            this._gdMAIN_VIEW.Name = "_gdMAIN_VIEW";
            // 
            // _luSTATUS_TIME
            // 
            this._luSTATUS_TIME.CancelButton = null;
            this._luSTATUS_TIME.CommandButton = null;
            this._luSTATUS_TIME.EditMask = "";
            this._luSTATUS_TIME.Location = new System.Drawing.Point(354, 168);
            this._luSTATUS_TIME.Margin = new System.Windows.Forms.Padding(0);
            this._luSTATUS_TIME.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this._luSTATUS_TIME.Name = "_luSTATUS_TIME";
            this._luSTATUS_TIME.PasswordChar = '\0';
            this._luSTATUS_TIME.ReadOnly = false;
            this._luSTATUS_TIME.Size = new System.Drawing.Size(106, 20);
            this._luSTATUS_TIME.TabIndex = 23;
            this._luSTATUS_TIME.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luSTATUS_TIME.UseMaskAsDisplayFormat = true;
            // 
            // _luSTATUS_CODE
            // 
            this._luSTATUS_CODE.ItemIndex = -1;
            this._luSTATUS_CODE.Location = new System.Drawing.Point(354, 144);
            this._luSTATUS_CODE.Margin = new System.Windows.Forms.Padding(0);
            this._luSTATUS_CODE.Name = "_luSTATUS_CODE";
            this._luSTATUS_CODE.ReadOnly = false;
            this._luSTATUS_CODE.Size = new System.Drawing.Size(106, 20);
            this._luSTATUS_CODE.TabIndex = 22;
            // 
            // _luSTATUS_GROUP
            // 
            this._luSTATUS_GROUP.ItemIndex = -1;
            this._luSTATUS_GROUP.Location = new System.Drawing.Point(137, 144);
            this._luSTATUS_GROUP.Margin = new System.Windows.Forms.Padding(0);
            this._luSTATUS_GROUP.Name = "_luSTATUS_GROUP";
            this._luSTATUS_GROUP.ReadOnly = false;
            this._luSTATUS_GROUP.Size = new System.Drawing.Size(100, 20);
            this._luSTATUS_GROUP.TabIndex = 21;
            this._luSTATUS_GROUP.ValueChanged += new System.EventHandler(this._luSTATUS_GROUP_ValueChanged);
            // 
            // _luRESULT_QTY
            // 
            this._luRESULT_QTY.CancelButton = null;
            this._luRESULT_QTY.CommandButton = null;
            this._luRESULT_QTY.EditMask = "";
            this._luRESULT_QTY.Location = new System.Drawing.Point(137, 168);
            this._luRESULT_QTY.Margin = new System.Windows.Forms.Padding(0);
            this._luRESULT_QTY.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luRESULT_QTY.Name = "_luRESULT_QTY";
            this._luRESULT_QTY.PasswordChar = '\0';
            this._luRESULT_QTY.ReadOnly = false;
            this._luRESULT_QTY.Size = new System.Drawing.Size(100, 20);
            this._luRESULT_QTY.TabIndex = 20;
            this._luRESULT_QTY.TextAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._luRESULT_QTY.UseMaskAsDisplayFormat = false;
            this._luRESULT_QTY._OnKeyPress += new CoFAS_MES.CORE.BaseControls.ucTextEdit.OnKeyPressEventHandler(this._luRESULT_QTY__OnKeyPress);
            // 
            // _luBAD_CODE
            // 
            this._luBAD_CODE.ItemIndex = -1;
            this._luBAD_CODE.Location = new System.Drawing.Point(354, 120);
            this._luBAD_CODE.Margin = new System.Windows.Forms.Padding(0);
            this._luBAD_CODE.Name = "_luBAD_CODE";
            this._luBAD_CODE.ReadOnly = false;
            this._luBAD_CODE.Size = new System.Drawing.Size(106, 20);
            this._luBAD_CODE.TabIndex = 19;
            // 
            // _luBAD_GROUP
            // 
            this._luBAD_GROUP.ItemIndex = -1;
            this._luBAD_GROUP.Location = new System.Drawing.Point(137, 120);
            this._luBAD_GROUP.Margin = new System.Windows.Forms.Padding(0);
            this._luBAD_GROUP.Name = "_luBAD_GROUP";
            this._luBAD_GROUP.ReadOnly = false;
            this._luBAD_GROUP.Size = new System.Drawing.Size(100, 20);
            this._luBAD_GROUP.TabIndex = 18;
            this._luBAD_GROUP.ValueChanged += new System.EventHandler(this._luBAD_GROUP_ValueChanged);
            // 
            // _luPROCESS_CODE
            // 
            this._luPROCESS_CODE.ItemIndex = -1;
            this._luPROCESS_CODE.Location = new System.Drawing.Point(137, 192);
            this._luPROCESS_CODE.Margin = new System.Windows.Forms.Padding(0);
            this._luPROCESS_CODE.Name = "_luPROCESS_CODE";
            this._luPROCESS_CODE.ReadOnly = false;
            this._luPROCESS_CODE.Size = new System.Drawing.Size(323, 20);
            this._luPROCESS_CODE.TabIndex = 17;
            // 
            // _luPART_NAME
            // 
            this._luPART_NAME.CancelButton = null;
            this._luPART_NAME.CommandButton = null;
            this._luPART_NAME.EditMask = "";
            this._luPART_NAME.Location = new System.Drawing.Point(241, 96);
            this._luPART_NAME.Margin = new System.Windows.Forms.Padding(0);
            this._luPART_NAME.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luPART_NAME.Name = "_luPART_NAME";
            this._luPART_NAME.PasswordChar = '\0';
            this._luPART_NAME.ReadOnly = true;
            this._luPART_NAME.Size = new System.Drawing.Size(219, 20);
            this._luPART_NAME.TabIndex = 16;
            this._luPART_NAME.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luPART_NAME.UseMaskAsDisplayFormat = false;
            // 
            // _luPART_CODE
            // 
            this._luPART_CODE.CancelButton = null;
            this._luPART_CODE.CommandButton = null;
            this._luPART_CODE.EditMask = "";
            this._luPART_CODE.Location = new System.Drawing.Point(137, 96);
            this._luPART_CODE.Margin = new System.Windows.Forms.Padding(0);
            this._luPART_CODE.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luPART_CODE.Name = "_luPART_CODE";
            this._luPART_CODE.PasswordChar = '\0';
            this._luPART_CODE.ReadOnly = true;
            this._luPART_CODE.Size = new System.Drawing.Size(100, 20);
            this._luPART_CODE.TabIndex = 15;
            this._luPART_CODE.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luPART_CODE.UseMaskAsDisplayFormat = false;
            // 
            // _luRESULT_GUBN
            // 
            this._luRESULT_GUBN.ItemIndex = -1;
            this._luRESULT_GUBN.Location = new System.Drawing.Point(137, 48);
            this._luRESULT_GUBN.Margin = new System.Windows.Forms.Padding(0);
            this._luRESULT_GUBN.Name = "_luRESULT_GUBN";
            this._luRESULT_GUBN.ReadOnly = false;
            this._luRESULT_GUBN.Size = new System.Drawing.Size(323, 20);
            this._luRESULT_GUBN.TabIndex = 14;
            this._luRESULT_GUBN.ValueChanged += new System.EventHandler(this._luRESULT_GUBN_ValueChanged);
            // 
            // _luWORKORDERID
            // 
            this._luWORKORDERID.CancelButton = null;
            this._luWORKORDERID.CommandButton = null;
            this._luWORKORDERID.EditMask = "";
            this._luWORKORDERID.Location = new System.Drawing.Point(137, 72);
            this._luWORKORDERID.Margin = new System.Windows.Forms.Padding(0);
            this._luWORKORDERID.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luWORKORDERID.Name = "_luWORKORDERID";
            this._luWORKORDERID.PasswordChar = '\0';
            this._luWORKORDERID.ReadOnly = true;
            this._luWORKORDERID.Size = new System.Drawing.Size(323, 20);
            this._luWORKORDERID.TabIndex = 13;
            this._luWORKORDERID.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luWORKORDERID.UseMaskAsDisplayFormat = false;
            // 
            // _btSAVE
            // 
            this._btSAVE.ButtonText = "저장";
            this._btSAVE.Image = global::CoFAS_MES.UI.PO.Properties.Resources.saveto_16x16;
            this._btSAVE.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._btSAVE.Location = new System.Drawing.Point(221, 24);
            this._btSAVE.Name = "_btSAVE";
            this._btSAVE.Size = new System.Drawing.Size(112, 20);
            this._btSAVE.TabIndex = 10;
            this._btSAVE.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._btSAVE_Click);
            // 
            // _btCancle
            // 
            this._btCancle.ButtonText = "닫기";
            this._btCancle.Image = global::CoFAS_MES.UI.PO.Properties.Resources.close_16x162;
            this._btCancle.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._btCancle.Location = new System.Drawing.Point(337, 24);
            this._btCancle.Name = "_btCancle";
            this._btCancle.Size = new System.Drawing.Size(123, 20);
            this._btCancle.TabIndex = 11;
            this._btCancle.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._btCancle_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(484, 515);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem2,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this._lciWORKORDERID,
            this._lciRESULT_GUBN,
            this._lciPART_CODE,
            this._lciPART_NAME,
            this._lciBAD_GROUP,
            this._lciRESULT_QTY,
            this._lciSTATUS_GROUP,
            this._lciBAD_CODE,
            this._lciSTATUS_CODE,
            this._lciSTATUS_TIME,
            this._lciPROCESS_CODE});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup2.Size = new System.Drawing.Size(464, 216);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem2.MaxSize = new System.Drawing.Size(197, 24);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(197, 24);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(197, 24);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this._btSAVE;
            this.layoutControlItem2.Location = new System.Drawing.Point(197, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(116, 24);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(116, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(116, 24);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this._btCancle;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(313, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(127, 24);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(127, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(127, 24);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // _lciWORKORDERID
            // 
            this._lciWORKORDERID.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciWORKORDERID.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciWORKORDERID.Control = this._luWORKORDERID;
            this._lciWORKORDERID.Location = new System.Drawing.Point(0, 48);
            this._lciWORKORDERID.MaxSize = new System.Drawing.Size(440, 24);
            this._lciWORKORDERID.MinSize = new System.Drawing.Size(440, 24);
            this._lciWORKORDERID.Name = "_lciWORKORDERID";
            this._lciWORKORDERID.Size = new System.Drawing.Size(440, 24);
            this._lciWORKORDERID.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciWORKORDERID.TextSize = new System.Drawing.Size(109, 14);
            // 
            // _lciRESULT_GUBN
            // 
            this._lciRESULT_GUBN.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciRESULT_GUBN.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciRESULT_GUBN.Control = this._luRESULT_GUBN;
            this._lciRESULT_GUBN.Location = new System.Drawing.Point(0, 24);
            this._lciRESULT_GUBN.MaxSize = new System.Drawing.Size(440, 24);
            this._lciRESULT_GUBN.MinSize = new System.Drawing.Size(440, 24);
            this._lciRESULT_GUBN.Name = "_lciRESULT_GUBN";
            this._lciRESULT_GUBN.Size = new System.Drawing.Size(440, 24);
            this._lciRESULT_GUBN.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciRESULT_GUBN.TextSize = new System.Drawing.Size(109, 14);
            // 
            // _lciPART_CODE
            // 
            this._lciPART_CODE.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciPART_CODE.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciPART_CODE.Control = this._luPART_CODE;
            this._lciPART_CODE.Location = new System.Drawing.Point(0, 72);
            this._lciPART_CODE.MaxSize = new System.Drawing.Size(217, 24);
            this._lciPART_CODE.MinSize = new System.Drawing.Size(217, 24);
            this._lciPART_CODE.Name = "_lciPART_CODE";
            this._lciPART_CODE.Size = new System.Drawing.Size(217, 24);
            this._lciPART_CODE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciPART_CODE.TextSize = new System.Drawing.Size(109, 14);
            // 
            // _lciPART_NAME
            // 
            this._lciPART_NAME.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciPART_NAME.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciPART_NAME.Control = this._luPART_NAME;
            this._lciPART_NAME.Location = new System.Drawing.Point(217, 72);
            this._lciPART_NAME.MaxSize = new System.Drawing.Size(223, 24);
            this._lciPART_NAME.MinSize = new System.Drawing.Size(223, 24);
            this._lciPART_NAME.Name = "_lciPART_NAME";
            this._lciPART_NAME.Size = new System.Drawing.Size(223, 24);
            this._lciPART_NAME.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciPART_NAME.TextSize = new System.Drawing.Size(0, 0);
            this._lciPART_NAME.TextVisible = false;
            // 
            // _lciBAD_GROUP
            // 
            this._lciBAD_GROUP.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciBAD_GROUP.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciBAD_GROUP.Control = this._luBAD_GROUP;
            this._lciBAD_GROUP.Location = new System.Drawing.Point(0, 96);
            this._lciBAD_GROUP.MaxSize = new System.Drawing.Size(217, 24);
            this._lciBAD_GROUP.MinSize = new System.Drawing.Size(217, 24);
            this._lciBAD_GROUP.Name = "_lciBAD_GROUP";
            this._lciBAD_GROUP.Size = new System.Drawing.Size(217, 24);
            this._lciBAD_GROUP.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciBAD_GROUP.TextSize = new System.Drawing.Size(109, 14);
            // 
            // _lciRESULT_QTY
            // 
            this._lciRESULT_QTY.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciRESULT_QTY.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciRESULT_QTY.Control = this._luRESULT_QTY;
            this._lciRESULT_QTY.Location = new System.Drawing.Point(0, 144);
            this._lciRESULT_QTY.MaxSize = new System.Drawing.Size(217, 24);
            this._lciRESULT_QTY.MinSize = new System.Drawing.Size(217, 24);
            this._lciRESULT_QTY.Name = "_lciRESULT_QTY";
            this._lciRESULT_QTY.Size = new System.Drawing.Size(217, 24);
            this._lciRESULT_QTY.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciRESULT_QTY.TextSize = new System.Drawing.Size(109, 14);
            // 
            // _lciSTATUS_GROUP
            // 
            this._lciSTATUS_GROUP.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciSTATUS_GROUP.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciSTATUS_GROUP.Control = this._luSTATUS_GROUP;
            this._lciSTATUS_GROUP.Location = new System.Drawing.Point(0, 120);
            this._lciSTATUS_GROUP.MaxSize = new System.Drawing.Size(217, 24);
            this._lciSTATUS_GROUP.MinSize = new System.Drawing.Size(217, 24);
            this._lciSTATUS_GROUP.Name = "_lciSTATUS_GROUP";
            this._lciSTATUS_GROUP.Size = new System.Drawing.Size(217, 24);
            this._lciSTATUS_GROUP.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciSTATUS_GROUP.TextSize = new System.Drawing.Size(109, 14);
            // 
            // _lciBAD_CODE
            // 
            this._lciBAD_CODE.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciBAD_CODE.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciBAD_CODE.Control = this._luBAD_CODE;
            this._lciBAD_CODE.Location = new System.Drawing.Point(217, 96);
            this._lciBAD_CODE.MaxSize = new System.Drawing.Size(223, 24);
            this._lciBAD_CODE.MinSize = new System.Drawing.Size(223, 24);
            this._lciBAD_CODE.Name = "_lciBAD_CODE";
            this._lciBAD_CODE.Size = new System.Drawing.Size(223, 24);
            this._lciBAD_CODE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciBAD_CODE.TextSize = new System.Drawing.Size(109, 14);
            // 
            // _lciSTATUS_CODE
            // 
            this._lciSTATUS_CODE.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciSTATUS_CODE.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciSTATUS_CODE.Control = this._luSTATUS_CODE;
            this._lciSTATUS_CODE.Location = new System.Drawing.Point(217, 120);
            this._lciSTATUS_CODE.MaxSize = new System.Drawing.Size(223, 24);
            this._lciSTATUS_CODE.MinSize = new System.Drawing.Size(223, 24);
            this._lciSTATUS_CODE.Name = "_lciSTATUS_CODE";
            this._lciSTATUS_CODE.Size = new System.Drawing.Size(223, 24);
            this._lciSTATUS_CODE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciSTATUS_CODE.TextSize = new System.Drawing.Size(109, 14);
            // 
            // _lciSTATUS_TIME
            // 
            this._lciSTATUS_TIME.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciSTATUS_TIME.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciSTATUS_TIME.Control = this._luSTATUS_TIME;
            this._lciSTATUS_TIME.Location = new System.Drawing.Point(217, 144);
            this._lciSTATUS_TIME.MaxSize = new System.Drawing.Size(223, 24);
            this._lciSTATUS_TIME.MinSize = new System.Drawing.Size(223, 24);
            this._lciSTATUS_TIME.Name = "_lciSTATUS_TIME";
            this._lciSTATUS_TIME.Size = new System.Drawing.Size(223, 24);
            this._lciSTATUS_TIME.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciSTATUS_TIME.TextSize = new System.Drawing.Size(109, 14);
            // 
            // _lciPROCESS_CODE
            // 
            this._lciPROCESS_CODE.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciPROCESS_CODE.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciPROCESS_CODE.Control = this._luPROCESS_CODE;
            this._lciPROCESS_CODE.Location = new System.Drawing.Point(0, 168);
            this._lciPROCESS_CODE.MaxSize = new System.Drawing.Size(440, 24);
            this._lciPROCESS_CODE.MinSize = new System.Drawing.Size(440, 24);
            this._lciPROCESS_CODE.Name = "_lciPROCESS_CODE";
            this._lciPROCESS_CODE.Size = new System.Drawing.Size(440, 24);
            this._lciPROCESS_CODE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciPROCESS_CODE.TextSize = new System.Drawing.Size(109, 14);
            this._lciPROCESS_CODE.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this._gdMAIN;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 216);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(464, 279);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ucWorkResultPopUp_T01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ucWorkResultPopUp_T01";
            this.Size = new System.Drawing.Size(484, 515);
            this.Load += new System.EventHandler(this.ucWorkResultPopUp_T01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciWORKORDERID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciRESULT_GUBN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPART_CODE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPART_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciBAD_GROUP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciRESULT_QTY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciSTATUS_GROUP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciBAD_CODE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciSTATUS_CODE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciSTATUS_TIME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPROCESS_CODE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private CoFAS_MES.CORE.BaseControls.ucSimpleButton _btSAVE;
        private CoFAS_MES.CORE.BaseControls.ucSimpleButton _btCancle;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private CoFAS_MES.CORE.BaseControls.ucTextEdit _luWORKORDERID;
        private DevExpress.XtraLayout.LayoutControlItem _lciWORKORDERID;
        private CoFAS_MES.CORE.BaseControls.ucTextEdit _luRESULT_QTY;
        private CoFAS_MES.CORE.BaseControls.ucLookUpEdit _luBAD_CODE;
        private CoFAS_MES.CORE.BaseControls.ucLookUpEdit _luBAD_GROUP;
        private CoFAS_MES.CORE.BaseControls.ucLookUpEdit _luPROCESS_CODE;
        private CoFAS_MES.CORE.BaseControls.ucTextEdit _luPART_NAME;
        private CoFAS_MES.CORE.BaseControls.ucTextEdit _luPART_CODE;
        private CoFAS_MES.CORE.BaseControls.ucLookUpEdit _luRESULT_GUBN;
        private DevExpress.XtraLayout.LayoutControlItem _lciRESULT_GUBN;
        private DevExpress.XtraLayout.LayoutControlItem _lciPART_CODE;
        private DevExpress.XtraLayout.LayoutControlItem _lciPART_NAME;
        private DevExpress.XtraLayout.LayoutControlItem _lciPROCESS_CODE;
        private DevExpress.XtraLayout.LayoutControlItem _lciBAD_GROUP;
        private DevExpress.XtraLayout.LayoutControlItem _lciBAD_CODE;
        private DevExpress.XtraLayout.LayoutControlItem _lciRESULT_QTY;
        private CoFAS_MES.CORE.BaseControls.ucLookUpEdit _luSTATUS_GROUP;
        private DevExpress.XtraLayout.LayoutControlItem _lciSTATUS_GROUP;
        private CoFAS_MES.CORE.BaseControls.ucLookUpEdit _luSTATUS_CODE;
        private DevExpress.XtraLayout.LayoutControlItem _lciSTATUS_CODE;
        private CoFAS_MES.CORE.BaseControls.ucTextEdit _luSTATUS_TIME;
        private DevExpress.XtraLayout.LayoutControlItem _lciSTATUS_TIME;
        private DevExpress.XtraGrid.GridControl _gdMAIN;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdMAIN_VIEW;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}

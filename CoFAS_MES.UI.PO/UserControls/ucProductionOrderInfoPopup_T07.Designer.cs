namespace CoFAS_MES.UI.PO.UserControls
{
    partial class ucProductionOrderInfoPopup_T07
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
            this._ucPRODUCTION_PLAN_DATE = new CoFAS_MES.CORE.BaseControls.ucFromToDateEdit();
            this._gdMAIN = new DevExpress.XtraGrid.GridControl();
            this._gdMAIN_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this._lciPRODUCTION_PLAN_DATE = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this._ucbtSC = new DevExpress.XtraLayout.LayoutControlItem();
            this._ucbtSEARCH = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this._luCONTRACT_NUMBER = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._lciCONTRACT_NUMBER = new DevExpress.XtraLayout.LayoutControlItem();
            this._luORDER_NUMBER = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._lciORDER_NUMBER = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPRODUCTION_PLAN_DATE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ucbtSC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCONTRACT_NUMBER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciORDER_NUMBER)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._luORDER_NUMBER);
            this.layoutControl1.Controls.Add(this._luCONTRACT_NUMBER);
            this.layoutControl1.Controls.Add(this._ucbtSEARCH);
            this.layoutControl1.Controls.Add(this._ucPRODUCTION_PLAN_DATE);
            this.layoutControl1.Controls.Add(this._gdMAIN);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(910, 202, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(820, 604);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _ucPRODUCTION_PLAN_DATE
            // 
            this._ucPRODUCTION_PLAN_DATE.FromDateTime = new System.DateTime(2018, 7, 1, 0, 0, 0, 0);
            this._ucPRODUCTION_PLAN_DATE.Location = new System.Drawing.Point(194, 24);
            this._ucPRODUCTION_PLAN_DATE.Margin = new System.Windows.Forms.Padding(0);
            this._ucPRODUCTION_PLAN_DATE.Name = "_ucPRODUCTION_PLAN_DATE";
            this._ucPRODUCTION_PLAN_DATE.Size = new System.Drawing.Size(273, 20);
            this._ucPRODUCTION_PLAN_DATE.TabIndex = 19;
            this._ucPRODUCTION_PLAN_DATE.ToDateTime = new System.DateTime(2018, 7, 2, 23, 59, 59, 0);
            // 
            // _gdMAIN
            // 
            this._gdMAIN.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gdMAIN.Location = new System.Drawing.Point(24, 96);
            this._gdMAIN.MainView = this._gdMAIN_VIEW;
            this._gdMAIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gdMAIN.Name = "_gdMAIN";
            this._gdMAIN.Size = new System.Drawing.Size(772, 484);
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
            this.layoutControlGroup2,
            this.layoutControlGroup3});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(820, 604);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this._lciPRODUCTION_PLAN_DATE,
            this._ucbtSC,
            this.emptySpaceItem1,
            this._lciCONTRACT_NUMBER,
            this._lciORDER_NUMBER});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup2.Size = new System.Drawing.Size(800, 72);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // _lciPRODUCTION_PLAN_DATE
            // 
            this._lciPRODUCTION_PLAN_DATE.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciPRODUCTION_PLAN_DATE.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciPRODUCTION_PLAN_DATE.Control = this._ucPRODUCTION_PLAN_DATE;
            this._lciPRODUCTION_PLAN_DATE.Location = new System.Drawing.Point(0, 0);
            this._lciPRODUCTION_PLAN_DATE.MaxSize = new System.Drawing.Size(447, 24);
            this._lciPRODUCTION_PLAN_DATE.MinSize = new System.Drawing.Size(447, 24);
            this._lciPRODUCTION_PLAN_DATE.Name = "_lciPRODUCTION_PLAN_DATE";
            this._lciPRODUCTION_PLAN_DATE.Size = new System.Drawing.Size(447, 24);
            this._lciPRODUCTION_PLAN_DATE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciPRODUCTION_PLAN_DATE.TextSize = new System.Drawing.Size(166, 14);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 72);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup3.Size = new System.Drawing.Size(800, 512);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this._gdMAIN;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(776, 488);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // _ucbtSC
            // 
            this._ucbtSC.Control = this._ucbtSEARCH;
            this._ucbtSC.Location = new System.Drawing.Point(548, 24);
            this._ucbtSC.MaxSize = new System.Drawing.Size(228, 24);
            this._ucbtSC.MinSize = new System.Drawing.Size(228, 24);
            this._ucbtSC.Name = "_ucbtSC";
            this._ucbtSC.Size = new System.Drawing.Size(228, 24);
            this._ucbtSC.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._ucbtSC.TextSize = new System.Drawing.Size(0, 0);
            this._ucbtSC.TextVisible = false;
            // 
            // _ucbtSEARCH
            // 
            this._ucbtSEARCH.ButtonText = "simpleButton";
            this._ucbtSEARCH.Image = global::CoFAS_MES.UI.PO.Properties.Resources.zoom_16x16;
            this._ucbtSEARCH.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtSEARCH.Location = new System.Drawing.Point(572, 48);
            this._ucbtSEARCH.Name = "_ucbtSEARCH";
            this._ucbtSEARCH.Size = new System.Drawing.Size(224, 20);
            this._ucbtSEARCH.TabIndex = 20;
            this._ucbtSEARCH.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtSEARCH_Click);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(447, 0);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(329, 24);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(329, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(329, 24);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // _luCONTRACT_NUMBER
            // 
            this._luCONTRACT_NUMBER.CancelButton = null;
            this._luCONTRACT_NUMBER.CommandButton = null;
            this._luCONTRACT_NUMBER.EditMask = "";
            this._luCONTRACT_NUMBER.Location = new System.Drawing.Point(194, 48);
            this._luCONTRACT_NUMBER.Margin = new System.Windows.Forms.Padding(0);
            this._luCONTRACT_NUMBER.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luCONTRACT_NUMBER.Name = "_luCONTRACT_NUMBER";
            this._luCONTRACT_NUMBER.PasswordChar = '\0';
            this._luCONTRACT_NUMBER.ReadOnly = false;
            this._luCONTRACT_NUMBER.Size = new System.Drawing.Size(100, 20);
            this._luCONTRACT_NUMBER.TabIndex = 21;
            this._luCONTRACT_NUMBER.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luCONTRACT_NUMBER.UseMaskAsDisplayFormat = false;
            // 
            // _lciCONTRACT_NUMBER
            // 
            this._lciCONTRACT_NUMBER.Control = this._luCONTRACT_NUMBER;
            this._lciCONTRACT_NUMBER.Location = new System.Drawing.Point(0, 24);
            this._lciCONTRACT_NUMBER.MaxSize = new System.Drawing.Size(274, 24);
            this._lciCONTRACT_NUMBER.MinSize = new System.Drawing.Size(274, 24);
            this._lciCONTRACT_NUMBER.Name = "_lciCONTRACT_NUMBER";
            this._lciCONTRACT_NUMBER.Size = new System.Drawing.Size(274, 24);
            this._lciCONTRACT_NUMBER.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciCONTRACT_NUMBER.TextSize = new System.Drawing.Size(166, 14);
            // 
            // _luORDER_NUMBER
            // 
            this._luORDER_NUMBER.CancelButton = null;
            this._luORDER_NUMBER.CommandButton = null;
            this._luORDER_NUMBER.EditMask = "";
            this._luORDER_NUMBER.Location = new System.Drawing.Point(468, 48);
            this._luORDER_NUMBER.Margin = new System.Windows.Forms.Padding(0);
            this._luORDER_NUMBER.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luORDER_NUMBER.Name = "_luORDER_NUMBER";
            this._luORDER_NUMBER.PasswordChar = '\0';
            this._luORDER_NUMBER.ReadOnly = false;
            this._luORDER_NUMBER.Size = new System.Drawing.Size(100, 20);
            this._luORDER_NUMBER.TabIndex = 22;
            this._luORDER_NUMBER.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luORDER_NUMBER.UseMaskAsDisplayFormat = false;
            // 
            // _lciORDER_NUMBER
            // 
            this._lciORDER_NUMBER.Control = this._luORDER_NUMBER;
            this._lciORDER_NUMBER.Location = new System.Drawing.Point(274, 24);
            this._lciORDER_NUMBER.MaxSize = new System.Drawing.Size(274, 24);
            this._lciORDER_NUMBER.MinSize = new System.Drawing.Size(274, 24);
            this._lciORDER_NUMBER.Name = "_lciORDER_NUMBER";
            this._lciORDER_NUMBER.Size = new System.Drawing.Size(274, 24);
            this._lciORDER_NUMBER.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciORDER_NUMBER.TextSize = new System.Drawing.Size(166, 14);
            // 
            // ucProductionOrderInfoPopup_T07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ucProductionOrderInfoPopup_T07";
            this.Size = new System.Drawing.Size(820, 604);
            this.Load += new System.EventHandler(this.ucProductionOrderInfoPopup_T07_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPRODUCTION_PLAN_DATE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ucbtSC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCONTRACT_NUMBER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciORDER_NUMBER)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl _gdMAIN;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdMAIN_VIEW;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private CoFAS_MES.CORE.BaseControls.ucFromToDateEdit _ucPRODUCTION_PLAN_DATE;
        private DevExpress.XtraLayout.LayoutControlItem _lciPRODUCTION_PLAN_DATE;
        private CORE.BaseControls.ucTextEdit _luORDER_NUMBER;
        private CORE.BaseControls.ucTextEdit _luCONTRACT_NUMBER;
        private CORE.BaseControls.ucSimpleButton _ucbtSEARCH;
        private DevExpress.XtraLayout.LayoutControlItem _ucbtSC;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem _lciCONTRACT_NUMBER;
        private DevExpress.XtraLayout.LayoutControlItem _lciORDER_NUMBER;
    }
}

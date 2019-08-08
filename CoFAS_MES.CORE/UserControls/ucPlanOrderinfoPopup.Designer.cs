namespace CoFAS_MES.CORE.UserControls
{
    partial class ucPlanOrderinfoPopup
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
            this._luPLAN_ORDER = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._ucbtSEARCH = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._ucFROMDATE = new CoFAS_MES.CORE.BaseControls.ucFromToDateEdit();
            this._luPART_ALL = new CoFAS_MES.CORE.BaseControls.ucSearchEdit();
            this._gdMAIN = new DevExpress.XtraGrid.GridControl();
            this._gdMAIN_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this._lciTPART_ALL = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciTPLAN_ORDER_DATE = new DevExpress.XtraLayout.LayoutControlItem();
            this._ucbtSC = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciTPLAN_ORDER = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTPART_ALL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTPLAN_ORDER_DATE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ucbtSC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTPLAN_ORDER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._luPLAN_ORDER);
            this.layoutControl1.Controls.Add(this._ucbtSEARCH);
            this.layoutControl1.Controls.Add(this._ucFROMDATE);
            this.layoutControl1.Controls.Add(this._luPART_ALL);
            this.layoutControl1.Controls.Add(this._gdMAIN);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(910, 202, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(872, 604);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _luPLAN_ORDER
            // 
            this._luPLAN_ORDER.CancelButton = null;
            this._luPLAN_ORDER.CommandButton = null;
            this._luPLAN_ORDER.EditMask = "";
            this._luPLAN_ORDER.Location = new System.Drawing.Point(165, 48);
            this._luPLAN_ORDER.Margin = new System.Windows.Forms.Padding(0);
            this._luPLAN_ORDER.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luPLAN_ORDER.Name = "_luPLAN_ORDER";
            this._luPLAN_ORDER.PasswordChar = '\0';
            this._luPLAN_ORDER.ReadOnly = false;
            this._luPLAN_ORDER.Size = new System.Drawing.Size(191, 20);
            this._luPLAN_ORDER.TabIndex = 22;
            this._luPLAN_ORDER.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luPLAN_ORDER.UseMaskAsDisplayFormat = false;
            // 
            // _ucbtSEARCH
            // 
            this._ucbtSEARCH.ButtonText = "simpleButton";
            this._ucbtSEARCH.Image = global::CoFAS_MES.CORE.Properties.Resources.zoom_16x16;
            this._ucbtSEARCH.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtSEARCH.Location = new System.Drawing.Point(360, 24);
            this._ucbtSEARCH.Name = "_ucbtSEARCH";
            this._ucbtSEARCH.Size = new System.Drawing.Size(100, 20);
            this._ucbtSEARCH.TabIndex = 20;
            this._ucbtSEARCH.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtSEARCH_Click);
            // 
            // _ucFROMDATE
            // 
            this._ucFROMDATE.FromDateTime = new System.DateTime(2018, 7, 1, 0, 0, 0, 0);
            this._ucFROMDATE.Location = new System.Drawing.Point(165, 24);
            this._ucFROMDATE.Margin = new System.Windows.Forms.Padding(0);
            this._ucFROMDATE.Name = "_ucFROMDATE";
            this._ucFROMDATE.Size = new System.Drawing.Size(191, 20);
            this._ucFROMDATE.TabIndex = 19;
            this._ucFROMDATE.ToDateTime = new System.DateTime(2018, 7, 2, 23, 59, 59, 0);
            // 
            // _luPART_ALL
            // 
            this._luPART_ALL.BackColor = System.Drawing.Color.Transparent;
            this._luPART_ALL.CodeReadOnly = false;
            this._luPART_ALL.CodeText = "";
            this._luPART_ALL.CodeTextName = "_pPART_CODE";
            this._luPART_ALL.Location = new System.Drawing.Point(501, 48);
            this._luPART_ALL.Name = "_luPART_ALL";
            this._luPART_ALL.NameEnabled = true;
            this._luPART_ALL.NameReadOnly = false;
            this._luPART_ALL.NameText = "";
            this._luPART_ALL.NameTextName = "_luPART_NAME";
            this._luPART_ALL.Size = new System.Drawing.Size(347, 20);
            this._luPART_ALL.TabIndex = 17;
            this._luPART_ALL._OnButtonPressed += new CoFAS_MES.CORE.BaseControls.ucSearchEdit.OnButtonPressedEventHandler(this._luPART_ALL__OnButtonPressed);
            // 
            // _gdMAIN
            // 
            this._gdMAIN.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gdMAIN.Location = new System.Drawing.Point(24, 96);
            this._gdMAIN.MainView = this._gdMAIN_VIEW;
            this._gdMAIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gdMAIN.Name = "_gdMAIN";
            this._gdMAIN.Size = new System.Drawing.Size(824, 484);
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(872, 604);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem2,
            this._lciTPART_ALL,
            this._lciTPLAN_ORDER_DATE,
            this._ucbtSC,
            this._lciTPLAN_ORDER});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup2.Size = new System.Drawing.Size(852, 72);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(440, 0);
            this.emptySpaceItem2.MaxSize = new System.Drawing.Size(207, 24);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(207, 24);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(388, 24);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // _lciTPART_ALL
            // 
            this._lciTPART_ALL.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciTPART_ALL.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciTPART_ALL.Control = this._luPART_ALL;
            this._lciTPART_ALL.Location = new System.Drawing.Point(336, 24);
            this._lciTPART_ALL.MinSize = new System.Drawing.Size(213, 24);
            this._lciTPART_ALL.Name = "_lciTPART_ALL";
            this._lciTPART_ALL.Size = new System.Drawing.Size(492, 24);
            this._lciTPART_ALL.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciTPART_ALL.TextSize = new System.Drawing.Size(137, 14);
            // 
            // _lciTPLAN_ORDER_DATE
            // 
            this._lciTPLAN_ORDER_DATE.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciTPLAN_ORDER_DATE.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciTPLAN_ORDER_DATE.Control = this._ucFROMDATE;
            this._lciTPLAN_ORDER_DATE.Location = new System.Drawing.Point(0, 0);
            this._lciTPLAN_ORDER_DATE.MaxSize = new System.Drawing.Size(336, 24);
            this._lciTPLAN_ORDER_DATE.MinSize = new System.Drawing.Size(336, 24);
            this._lciTPLAN_ORDER_DATE.Name = "_lciTPLAN_ORDER_DATE";
            this._lciTPLAN_ORDER_DATE.Size = new System.Drawing.Size(336, 24);
            this._lciTPLAN_ORDER_DATE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciTPLAN_ORDER_DATE.TextSize = new System.Drawing.Size(137, 14);
            // 
            // _ucbtSC
            // 
            this._ucbtSC.Control = this._ucbtSEARCH;
            this._ucbtSC.Location = new System.Drawing.Point(336, 0);
            this._ucbtSC.MaxSize = new System.Drawing.Size(104, 24);
            this._ucbtSC.MinSize = new System.Drawing.Size(104, 24);
            this._ucbtSC.Name = "_ucbtSC";
            this._ucbtSC.Size = new System.Drawing.Size(104, 24);
            this._ucbtSC.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._ucbtSC.TextSize = new System.Drawing.Size(0, 0);
            this._ucbtSC.TextVisible = false;
            // 
            // _lciTPLAN_ORDER
            // 
            this._lciTPLAN_ORDER.Control = this._luPLAN_ORDER;
            this._lciTPLAN_ORDER.Location = new System.Drawing.Point(0, 24);
            this._lciTPLAN_ORDER.MaxSize = new System.Drawing.Size(336, 24);
            this._lciTPLAN_ORDER.MinSize = new System.Drawing.Size(336, 24);
            this._lciTPLAN_ORDER.Name = "_lciTPLAN_ORDER";
            this._lciTPLAN_ORDER.Size = new System.Drawing.Size(336, 24);
            this._lciTPLAN_ORDER.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciTPLAN_ORDER.TextSize = new System.Drawing.Size(137, 14);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 72);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup3.Size = new System.Drawing.Size(852, 512);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this._gdMAIN;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(828, 488);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // ucPlanOrderinfoPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ucPlanOrderinfoPopup";
            this.Size = new System.Drawing.Size(872, 604);
            this.Load += new System.EventHandler(this.ucPlanOrderinfoPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTPART_ALL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTPLAN_ORDER_DATE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ucbtSC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTPLAN_ORDER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl _gdMAIN;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdMAIN_VIEW;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private BaseControls.ucSearchEdit _luPART_ALL;
        private DevExpress.XtraLayout.LayoutControlItem _lciTPART_ALL;
        private BaseControls.ucFromToDateEdit _ucFROMDATE;
        private DevExpress.XtraLayout.LayoutControlItem _lciTPLAN_ORDER_DATE;
        private BaseControls.ucSimpleButton _ucbtSEARCH;
        private DevExpress.XtraLayout.LayoutControlItem _ucbtSC;
        private BaseControls.ucTextEdit _luPLAN_ORDER;
        private DevExpress.XtraLayout.LayoutControlItem _lciTPLAN_ORDER;
    }
}

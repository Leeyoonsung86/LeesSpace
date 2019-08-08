namespace CoFAS_MES.UI.PO.UserControls
{
    partial class ucWorkOrderInfoPopup_T04
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
            this._luSEARCH_TYPE = new CoFAS_MES.CORE.BaseControls.ucLookUpEdit();
            this._ucbtSEARCH = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._ucbtPLAN_SAVE = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
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
            this._lciSEARCH_TYPE = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
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
            ((System.ComponentModel.ISupportInitialize)(this._lciSEARCH_TYPE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._luSEARCH_TYPE);
            this.layoutControl1.Controls.Add(this._ucbtSEARCH);
            this.layoutControl1.Controls.Add(this._ucbtPLAN_SAVE);
            this.layoutControl1.Controls.Add(this._gdMAIN);
            this.layoutControl1.Controls.Add(this._luTPART_NAME);
            this.layoutControl1.Controls.Add(this._luTPART_CODE);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1002, 491);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _luSEARCH_TYPE
            // 
            this._luSEARCH_TYPE.ItemIndex = -1;
            this._luSEARCH_TYPE.Location = new System.Drawing.Point(126, 24);
            this._luSEARCH_TYPE.Margin = new System.Windows.Forms.Padding(0);
            this._luSEARCH_TYPE.Name = "_luSEARCH_TYPE";
            this._luSEARCH_TYPE.ReadOnly = false;
            this._luSEARCH_TYPE.Size = new System.Drawing.Size(106, 22);
            this._luSEARCH_TYPE.TabIndex = 23;
            // 
            // _ucbtSEARCH
            // 
            this._ucbtSEARCH.ButtonText = "simpleButton";
            this._ucbtSEARCH.FontSize = 0;
            this._ucbtSEARCH.Image = global::CoFAS_MES.UI.PO.Properties.Resources.zoom_16x16;
            this._ucbtSEARCH.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtSEARCH.Location = new System.Drawing.Point(716, 24);
            this._ucbtSEARCH.Name = "_ucbtSEARCH";
            this._ucbtSEARCH.Size = new System.Drawing.Size(100, 22);
            this._ucbtSEARCH.TabIndex = 16;
            this._ucbtSEARCH.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._btSELECT_Click);
            // 
            // _ucbtPLAN_SAVE
            // 
            this._ucbtPLAN_SAVE.ButtonText = "simpleButton";
            this._ucbtPLAN_SAVE.FontSize = 0;
            this._ucbtPLAN_SAVE.Image = global::CoFAS_MES.UI.PO.Properties.Resources.saveto_16x16;
            this._ucbtPLAN_SAVE.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtPLAN_SAVE.Location = new System.Drawing.Point(12, 433);
            this._ucbtPLAN_SAVE.Name = "_ucbtPLAN_SAVE";
            this._ucbtPLAN_SAVE.Size = new System.Drawing.Size(978, 46);
            this._ucbtPLAN_SAVE.TabIndex = 15;
            this._ucbtPLAN_SAVE.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtPLAN_SAVE_Click);
            // 
            // _gdMAIN
            // 
            this._gdMAIN.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gdMAIN.Location = new System.Drawing.Point(24, 74);
            this._gdMAIN.MainView = this._gdMAIN_VIEW;
            this._gdMAIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gdMAIN.Name = "_gdMAIN";
            this._gdMAIN.Size = new System.Drawing.Size(954, 343);
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
            this._luTPART_NAME.Location = new System.Drawing.Point(560, 24);
            this._luTPART_NAME.Margin = new System.Windows.Forms.Padding(0);
            this._luTPART_NAME.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luTPART_NAME.Name = "_luTPART_NAME";
            this._luTPART_NAME.NumText = "";
            this._luTPART_NAME.PasswordChar = '\0';
            this._luTPART_NAME.ReadOnly = false;
            this._luTPART_NAME.Size = new System.Drawing.Size(152, 22);
            this._luTPART_NAME.TabIndex = 5;
            this._luTPART_NAME.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luTPART_NAME.UseMaskAsDisplayFormat = false;
            // 
            // _luTPART_CODE
            // 
            this._luTPART_CODE.CancelButton = null;
            this._luTPART_CODE.CommandButton = null;
            this._luTPART_CODE.EditMask = "";
            this._luTPART_CODE.Location = new System.Drawing.Point(338, 24);
            this._luTPART_CODE.Margin = new System.Windows.Forms.Padding(0);
            this._luTPART_CODE.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luTPART_CODE.Name = "_luTPART_CODE";
            this._luTPART_CODE.NumText = "";
            this._luTPART_CODE.PasswordChar = '\0';
            this._luTPART_CODE.ReadOnly = false;
            this._luTPART_CODE.Size = new System.Drawing.Size(116, 22);
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
            this.layoutControlItem4});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(1002, 491);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this._lciTPART_CODE,
            this._lciTPART_NAME,
            this.emptySpaceItem2,
            this.layoutControlItem2,
            this._lciSEARCH_TYPE});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup2.Size = new System.Drawing.Size(982, 50);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // _lciTPART_CODE
            // 
            this._lciTPART_CODE.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciTPART_CODE.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciTPART_CODE.Control = this._luTPART_CODE;
            this._lciTPART_CODE.Location = new System.Drawing.Point(212, 0);
            this._lciTPART_CODE.MaxSize = new System.Drawing.Size(222, 26);
            this._lciTPART_CODE.MinSize = new System.Drawing.Size(222, 26);
            this._lciTPART_CODE.Name = "_lciTPART_CODE";
            this._lciTPART_CODE.Size = new System.Drawing.Size(222, 26);
            this._lciTPART_CODE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciTPART_CODE.Text = "코드";
            this._lciTPART_CODE.TextSize = new System.Drawing.Size(98, 14);
            // 
            // _lciTPART_NAME
            // 
            this._lciTPART_NAME.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciTPART_NAME.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciTPART_NAME.Control = this._luTPART_NAME;
            this._lciTPART_NAME.Location = new System.Drawing.Point(434, 0);
            this._lciTPART_NAME.MaxSize = new System.Drawing.Size(258, 26);
            this._lciTPART_NAME.MinSize = new System.Drawing.Size(258, 26);
            this._lciTPART_NAME.Name = "_lciTPART_NAME";
            this._lciTPART_NAME.Size = new System.Drawing.Size(258, 26);
            this._lciTPART_NAME.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciTPART_NAME.Text = "명칭";
            this._lciTPART_NAME.TextSize = new System.Drawing.Size(98, 14);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(796, 0);
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
            this.layoutControlItem2.Location = new System.Drawing.Point(692, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(104, 26);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(104, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(104, 26);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            this.layoutControlItem2.Click += new System.EventHandler(this._btSELECT_Click);
            // 
            // _lciSEARCH_TYPE
            // 
            this._lciSEARCH_TYPE.Control = this._luSEARCH_TYPE;
            this._lciSEARCH_TYPE.Location = new System.Drawing.Point(0, 0);
            this._lciSEARCH_TYPE.Name = "_lciSEARCH_TYPE";
            this._lciSEARCH_TYPE.Size = new System.Drawing.Size(212, 26);
            this._lciSEARCH_TYPE.TextSize = new System.Drawing.Size(98, 14);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 50);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup3.Size = new System.Drawing.Size(982, 371);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this._gdMAIN;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(958, 347);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this._ucbtPLAN_SAVE;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 421);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(982, 50);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(982, 50);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(982, 50);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // ucWorkOrderInfoPopup_T04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ucWorkOrderInfoPopup_T04";
            this.Size = new System.Drawing.Size(1002, 491);
            this.Load += new System.EventHandler(this.ucProductPlanInfoPopup_Load);
            this.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.ucWorkOrderInfoPopup_T04_ControlRemoved);
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
            ((System.ComponentModel.ISupportInitialize)(this._lciSEARCH_TYPE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
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
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private CoFAS_MES.CORE.BaseControls.ucSimpleButton _ucbtPLAN_SAVE;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private CoFAS_MES.CORE.BaseControls.ucSimpleButton _ucbtSEARCH;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private CORE.BaseControls.ucLookUpEdit _luSEARCH_TYPE;
        private DevExpress.XtraLayout.LayoutControlItem _lciSEARCH_TYPE;
    }
}

namespace CoFAS_MES.CORE.UserControls
{
    partial class ucVendCostInfoPopup
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this._ucbtCancle = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._ucbtCLEAR = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._ucbtSELECT = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._gdVEND = new DevExpress.XtraGrid.GridControl();
            this._gdVEND_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._gdPART = new DevExpress.XtraGrid.GridControl();
            this._gdPART_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._luCD_NM = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luCD = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luT_PART_TYPE = new CoFAS_MES.CORE.BaseControls.ucLookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
            this._lciT_PART_TYPE = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this._lciCD = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciCD_NM = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gdVEND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdVEND_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdPART)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdPART_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciT_PART_TYPE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCD_NM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._ucbtCancle);
            this.layoutControl1.Controls.Add(this._ucbtCLEAR);
            this.layoutControl1.Controls.Add(this._ucbtSELECT);
            this.layoutControl1.Controls.Add(this._gdVEND);
            this.layoutControl1.Controls.Add(this._gdPART);
            this.layoutControl1.Controls.Add(this._luCD_NM);
            this.layoutControl1.Controls.Add(this._luCD);
            this.layoutControl1.Controls.Add(this._luT_PART_TYPE);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1020, 340, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1199, 600);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _ucbtCancle
            // 
            this._ucbtCancle.ButtonText = "닫기";
            this._ucbtCancle.Image = global::CoFAS_MES.CORE.Properties.Resources.close_16x162;
            this._ucbtCancle.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtCancle.Location = new System.Drawing.Point(941, 60);
            this._ucbtCancle.Name = "_ucbtCancle";
            this._ucbtCancle.Size = new System.Drawing.Size(222, 20);
            this._ucbtCancle.TabIndex = 12;
            this._ucbtCancle.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtCancle_Click);
            // 
            // _ucbtCLEAR
            // 
            this._ucbtCLEAR.ButtonText = "초기화";
            this._ucbtCLEAR.Image = global::CoFAS_MES.CORE.Properties.Resources.refresh_16x16;
            this._ucbtCLEAR.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtCLEAR.Location = new System.Drawing.Point(714, 60);
            this._ucbtCLEAR.Name = "_ucbtCLEAR";
            this._ucbtCLEAR.Size = new System.Drawing.Size(223, 20);
            this._ucbtCLEAR.TabIndex = 11;
            this._ucbtCLEAR.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtCLEAR_Click);
            // 
            // _ucbtSELECT
            // 
            this._ucbtSELECT.ButtonText = "조회";
            this._ucbtSELECT.Image = global::CoFAS_MES.CORE.Properties.Resources.zoom_16x16;
            this._ucbtSELECT.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtSELECT.Location = new System.Drawing.Point(489, 60);
            this._ucbtSELECT.Name = "_ucbtSELECT";
            this._ucbtSELECT.Size = new System.Drawing.Size(221, 20);
            this._ucbtSELECT.TabIndex = 10;
            this._ucbtSELECT.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtSELECT_Click);
            // 
            // _gdVEND
            // 
            this._gdVEND.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gdVEND.Location = new System.Drawing.Point(582, 120);
            this._gdVEND.MainView = this._gdVEND_VIEW;
            this._gdVEND.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gdVEND.Name = "_gdVEND";
            this._gdVEND.Size = new System.Drawing.Size(593, 456);
            this._gdVEND.TabIndex = 9;
            this._gdVEND.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gdVEND_VIEW});
            // 
            // _gdVEND_VIEW
            // 
            this._gdVEND_VIEW.GridControl = this._gdVEND;
            this._gdVEND_VIEW.Name = "_gdVEND_VIEW";
            // 
            // _gdPART
            // 
            this._gdPART.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gdPART.Location = new System.Drawing.Point(24, 120);
            this._gdPART.MainView = this._gdPART_VIEW;
            this._gdPART.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gdPART.Name = "_gdPART";
            this._gdPART.Size = new System.Drawing.Size(534, 456);
            this._gdPART.TabIndex = 8;
            this._gdPART.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gdPART_VIEW});
            // 
            // _gdPART_VIEW
            // 
            this._gdPART_VIEW.GridControl = this._gdPART;
            this._gdPART_VIEW.Name = "_gdPART_VIEW";
            // 
            // _luCD_NM
            // 
            this._luCD_NM.CancelButton = null;
            this._luCD_NM.CommandButton = null;
            this._luCD_NM.EditMask = "";
            this._luCD_NM.Location = new System.Drawing.Point(523, 36);
            this._luCD_NM.Margin = new System.Windows.Forms.Padding(0);
            this._luCD_NM.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luCD_NM.Name = "_luCD_NM";
            this._luCD_NM.PasswordChar = '\0';
            this._luCD_NM.ReadOnly = false;
            this._luCD_NM.Size = new System.Drawing.Size(414, 20);
            this._luCD_NM.TabIndex = 5;
            this._luCD_NM.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luCD_NM.UseMaskAsDisplayFormat = false;
            // 
            // _luCD
            // 
            this._luCD.CancelButton = null;
            this._luCD.CommandButton = null;
            this._luCD.EditMask = "";
            this._luCD.Location = new System.Drawing.Point(70, 36);
            this._luCD.Margin = new System.Windows.Forms.Padding(0);
            this._luCD.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luCD.Name = "_luCD";
            this._luCD.PasswordChar = '\0';
            this._luCD.ReadOnly = false;
            this._luCD.Size = new System.Drawing.Size(415, 20);
            this._luCD.TabIndex = 4;
            this._luCD.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luCD.UseMaskAsDisplayFormat = false;
            // 
            // _luT_PART_TYPE
            // 
            this._luT_PART_TYPE.ItemIndex = -1;
            this._luT_PART_TYPE.Location = new System.Drawing.Point(975, 36);
            this._luT_PART_TYPE.Margin = new System.Windows.Forms.Padding(0);
            this._luT_PART_TYPE.Name = "_luT_PART_TYPE";
            this._luT_PART_TYPE.ReadOnly = false;
            this._luT_PART_TYPE.Size = new System.Drawing.Size(188, 20);
            this._luT_PART_TYPE.TabIndex = 7;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(1199, 600);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup6});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup2.Size = new System.Drawing.Size(1179, 96);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlGroup6
            // 
            this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this._lciT_PART_TYPE,
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.emptySpaceItem1,
            this._lciCD,
            this.emptySpaceItem2,
            this.layoutControlItem2,
            this._lciCD_NM});
            this.layoutControlGroup6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup6.Name = "layoutControlGroup6";
            this.layoutControlGroup6.Size = new System.Drawing.Size(1155, 72);
            this.layoutControlGroup6.TextVisible = false;
            // 
            // _lciT_PART_TYPE
            // 
            this._lciT_PART_TYPE.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciT_PART_TYPE.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciT_PART_TYPE.Control = this._luT_PART_TYPE;
            this._lciT_PART_TYPE.CustomizationFormText = "_luVEND_TYPE";
            this._lciT_PART_TYPE.Location = new System.Drawing.Point(905, 0);
            this._lciT_PART_TYPE.Name = "_lciT_PART_TYPE";
            this._lciT_PART_TYPE.Size = new System.Drawing.Size(226, 24);
            this._lciT_PART_TYPE.Text = "구분";
            this._lciT_PART_TYPE.TextSize = new System.Drawing.Size(30, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this._ucbtCancle;
            this.layoutControlItem4.Location = new System.Drawing.Point(905, 24);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(226, 24);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this._ucbtCLEAR;
            this.layoutControlItem3.Location = new System.Drawing.Point(678, 24);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(227, 24);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(226, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(227, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // _lciCD
            // 
            this._lciCD.AppearanceItemCaption.BorderColor = System.Drawing.Color.Black;
            this._lciCD.AppearanceItemCaption.Options.UseBorderColor = true;
            this._lciCD.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciCD.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciCD.Control = this._luCD;
            this._lciCD.Location = new System.Drawing.Point(0, 0);
            this._lciCD.Name = "_lciCD";
            this._lciCD.Size = new System.Drawing.Size(453, 24);
            this._lciCD.Text = "코드";
            this._lciCD.TextLocation = DevExpress.Utils.Locations.Left;
            this._lciCD.TextSize = new System.Drawing.Size(30, 14);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 24);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(226, 24);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this._ucbtSELECT;
            this.layoutControlItem2.Location = new System.Drawing.Point(453, 24);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(225, 24);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "조회";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // _lciCD_NM
            // 
            this._lciCD_NM.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciCD_NM.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciCD_NM.Control = this._luCD_NM;
            this._lciCD_NM.Location = new System.Drawing.Point(453, 0);
            this._lciCD_NM.MaxSize = new System.Drawing.Size(0, 24);
            this._lciCD_NM.MinSize = new System.Drawing.Size(138, 24);
            this._lciCD_NM.Name = "_lciCD_NM";
            this._lciCD_NM.Size = new System.Drawing.Size(452, 24);
            this._lciCD_NM.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciCD_NM.Text = "코드명";
            this._lciCD_NM.TextSize = new System.Drawing.Size(30, 14);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlItem1});
            this.layoutControlGroup3.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 96);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.OptionsItemText.TextToControlDistance = 4;
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition1.Width = 47.368421052631575D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition2.Width = 20D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition3.Width = 52.631578947368418D;
            this.layoutControlGroup3.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3});
            rowDefinition1.Height = 50D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            rowDefinition2.Height = 50D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            this.layoutControlGroup3.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2});
            this.layoutControlGroup3.Size = new System.Drawing.Size(1179, 484);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this._gdPART;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.RowSpan = 2;
            this.layoutControlItem5.Size = new System.Drawing.Size(538, 460);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this._gdVEND;
            this.layoutControlItem1.Location = new System.Drawing.Point(558, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlItem1.OptionsTableLayoutItem.RowSpan = 2;
            this.layoutControlItem1.Size = new System.Drawing.Size(597, 460);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ucVendCostInfoPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucVendCostInfoPopup";
            this.Size = new System.Drawing.Size(1199, 600);
            this.Load += new System.EventHandler(this.ucVendCostInfoPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gdVEND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdVEND_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdPART)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdPART_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciT_PART_TYPE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCD_NM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private BaseControls.ucTextEdit _luCD_NM;
        private BaseControls.ucTextEdit _luCD;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraGrid.GridControl _gdVEND;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdVEND_VIEW;
        private DevExpress.XtraGrid.GridControl _gdPART;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdPART_VIEW;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup6;
        private BaseControls.ucSimpleButton _ucbtSELECT;
        private BaseControls.ucSimpleButton _ucbtCLEAR;
        private BaseControls.ucLookUpEdit _luT_PART_TYPE;
        private BaseControls.ucSimpleButton _ucbtCancle;
        private DevExpress.XtraLayout.LayoutControlItem _lciT_PART_TYPE;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem _lciCD_NM;
        private DevExpress.XtraLayout.LayoutControlItem _lciCD;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}

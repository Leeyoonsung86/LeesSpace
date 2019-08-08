namespace CoFAS_MES.UI.MM.UserControls
{
    partial class ucBOM_SpendQtyCalcPop
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
            this._ucbtCalc2 = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._ucbtCalc = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._ucbtSave = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._luTVEND = new CoFAS_MES.CORE.BaseControls.ucSearchEdit();
            this._luTPART = new CoFAS_MES.CORE.BaseControls.ucSearchEdit();
            this._ucbtCancle = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._ucbtCLEAR = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._ucbtSELECT = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._gdBOM = new DevExpress.XtraGrid.GridControl();
            this._gdBOM_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._gdCONTRACT = new DevExpress.XtraGrid.GridControl();
            this._gdCONTRACT_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._luTORDER_DATE = new CoFAS_MES.CORE.BaseControls.ucFromToDateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciTORDER_DATE = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciTPART = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciTVEND = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gdBOM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdBOM_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdCONTRACT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdCONTRACT_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTORDER_DATE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTPART)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTVEND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._ucbtCalc2);
            this.layoutControl1.Controls.Add(this._ucbtCalc);
            this.layoutControl1.Controls.Add(this._ucbtSave);
            this.layoutControl1.Controls.Add(this._luTVEND);
            this.layoutControl1.Controls.Add(this._luTPART);
            this.layoutControl1.Controls.Add(this._ucbtCancle);
            this.layoutControl1.Controls.Add(this._ucbtCLEAR);
            this.layoutControl1.Controls.Add(this._ucbtSELECT);
            this.layoutControl1.Controls.Add(this._gdBOM);
            this.layoutControl1.Controls.Add(this._gdCONTRACT);
            this.layoutControl1.Controls.Add(this._luTORDER_DATE);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1020, 341, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1182, 600);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _ucbtCalc2
            // 
            this._ucbtCalc2.ButtonText = "_ucbtCalc2";
            this._ucbtCalc2.FontSize = 0;
            this._ucbtCalc2.Image = global::CoFAS_MES.UI.MM.Properties.Resources.calc_16x16;
            this._ucbtCalc2.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtCalc2.Location = new System.Drawing.Point(868, 36);
            this._ucbtCalc2.Name = "_ucbtCalc2";
            this._ucbtCalc2.Size = new System.Drawing.Size(127, 20);
            this._ucbtCalc2.TabIndex = 17;
            this._ucbtCalc2.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtCalc2_Click);
            // 
            // _ucbtCalc
            // 
            this._ucbtCalc.ButtonText = "_ucbtCalc";
            this._ucbtCalc.FontSize = 0;
            this._ucbtCalc.Image = global::CoFAS_MES.UI.MM.Properties.Resources.calc_16x16;
            this._ucbtCalc.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtCalc.Location = new System.Drawing.Point(868, 60);
            this._ucbtCalc.Name = "_ucbtCalc";
            this._ucbtCalc.Size = new System.Drawing.Size(127, 20);
            this._ucbtCalc.TabIndex = 16;
            this._ucbtCalc.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtCalc_Click);
            // 
            // _ucbtSave
            // 
            this._ucbtSave.ButtonText = "ucbtSave";
            this._ucbtSave.FontSize = 0;
            this._ucbtSave.Image = global::CoFAS_MES.UI.MM.Properties.Resources.save_16x16;
            this._ucbtSave.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtSave.Location = new System.Drawing.Point(1009, 36);
            this._ucbtSave.Name = "_ucbtSave";
            this._ucbtSave.Size = new System.Drawing.Size(137, 20);
            this._ucbtSave.TabIndex = 15;
            this._ucbtSave.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtSave_Click);
            // 
            // _luTVEND
            // 
            this._luTVEND.BackColor = System.Drawing.Color.Transparent;
            this._luTVEND.CodeReadOnly = false;
            this._luTVEND.CodeText = "";
            this._luTVEND.CodeTextName = "_pCodeTextEdit";
            this._luTVEND.Location = new System.Drawing.Point(530, 60);
            this._luTVEND.Name = "_luTVEND";
            this._luTVEND.NameEnabled = true;
            this._luTVEND.NameReadOnly = false;
            this._luTVEND.NameText = "";
            this._luTVEND.NameTextName = "_pNameButtonEdit";
            this._luTVEND.Size = new System.Drawing.Size(334, 20);
            this._luTVEND.TabIndex = 14;
            this._luTVEND._OnOpenClick += new CoFAS_MES.CORE.BaseControls.ucSearchEdit.OnOpenClickEventHandler(this._luTVEND__OnOpenClick);
            // 
            // _luTPART
            // 
            this._luTPART.BackColor = System.Drawing.Color.Transparent;
            this._luTPART.CodeReadOnly = false;
            this._luTPART.CodeText = "";
            this._luTPART.CodeTextName = "_pCodeTextEdit";
            this._luTPART.Location = new System.Drawing.Point(530, 36);
            this._luTPART.Name = "_luTPART";
            this._luTPART.NameEnabled = true;
            this._luTPART.NameReadOnly = false;
            this._luTPART.NameText = "";
            this._luTPART.NameTextName = "_pNameButtonEdit";
            this._luTPART.Size = new System.Drawing.Size(334, 20);
            this._luTPART.TabIndex = 13;
            this._luTPART._OnOpenClick += new CoFAS_MES.CORE.BaseControls.ucSearchEdit.OnOpenClickEventHandler(this._luTPART__OnOpenClick);
            // 
            // _ucbtCancle
            // 
            this._ucbtCancle.ButtonText = "닫기";
            this._ucbtCancle.FontSize = 0;
            this._ucbtCancle.Image = global::CoFAS_MES.UI.MM.Properties.Resources.close_16x16;
            this._ucbtCancle.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtCancle.Location = new System.Drawing.Point(294, 60);
            this._ucbtCancle.Name = "_ucbtCancle";
            this._ucbtCancle.Size = new System.Drawing.Size(127, 20);
            this._ucbtCancle.TabIndex = 12;
            this._ucbtCancle.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._btCancle_Click);
            // 
            // _ucbtCLEAR
            // 
            this._ucbtCLEAR.ButtonText = "초기화";
            this._ucbtCLEAR.FontSize = 0;
            this._ucbtCLEAR.Image = global::CoFAS_MES.UI.MM.Properties.Resources.refresh_16x16;
            this._ucbtCLEAR.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtCLEAR.Location = new System.Drawing.Point(165, 60);
            this._ucbtCLEAR.Name = "_ucbtCLEAR";
            this._ucbtCLEAR.Size = new System.Drawing.Size(125, 20);
            this._ucbtCLEAR.TabIndex = 11;
            this._ucbtCLEAR.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._btCLEAR_Click);
            // 
            // _ucbtSELECT
            // 
            this._ucbtSELECT.ButtonText = "조회";
            this._ucbtSELECT.FontSize = 0;
            this._ucbtSELECT.Image = global::CoFAS_MES.UI.MM.Properties.Resources.zoom_16x16;
            this._ucbtSELECT.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtSELECT.Location = new System.Drawing.Point(36, 60);
            this._ucbtSELECT.Name = "_ucbtSELECT";
            this._ucbtSELECT.Size = new System.Drawing.Size(125, 20);
            this._ucbtSELECT.TabIndex = 10;
            this._ucbtSELECT.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._btSELECT_Click);
            // 
            // _gdBOM
            // 
            this._gdBOM.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gdBOM.Location = new System.Drawing.Point(458, 120);
            this._gdBOM.MainView = this._gdBOM_VIEW;
            this._gdBOM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gdBOM.Name = "_gdBOM";
            this._gdBOM.Size = new System.Drawing.Size(700, 456);
            this._gdBOM.TabIndex = 9;
            this._gdBOM.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gdBOM_VIEW});
            // 
            // _gdBOM_VIEW
            // 
            this._gdBOM_VIEW.GridControl = this._gdBOM;
            this._gdBOM_VIEW.Name = "_gdBOM_VIEW";
            // 
            // _gdCONTRACT
            // 
            this._gdCONTRACT.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gdCONTRACT.Location = new System.Drawing.Point(24, 120);
            this._gdCONTRACT.MainView = this._gdCONTRACT_VIEW;
            this._gdCONTRACT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gdCONTRACT.Name = "_gdCONTRACT";
            this._gdCONTRACT.Size = new System.Drawing.Size(410, 456);
            this._gdCONTRACT.TabIndex = 8;
            this._gdCONTRACT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gdCONTRACT_VIEW});
            // 
            // _gdCONTRACT_VIEW
            // 
            this._gdCONTRACT_VIEW.GridControl = this._gdCONTRACT;
            this._gdCONTRACT_VIEW.Name = "_gdCONTRACT_VIEW";
            // 
            // _luTORDER_DATE
            // 
            this._luTORDER_DATE.FromDateTime = new System.DateTime(2018, 4, 1, 0, 0, 0, 0);
            this._luTORDER_DATE.Location = new System.Drawing.Point(141, 36);
            this._luTORDER_DATE.Margin = new System.Windows.Forms.Padding(0);
            this._luTORDER_DATE.Name = "_luTORDER_DATE";
            this._luTORDER_DATE.Size = new System.Drawing.Size(280, 20);
            this._luTORDER_DATE.TabIndex = 4;
            this._luTORDER_DATE.ToDateTime = new System.DateTime(2018, 4, 14, 23, 59, 59, 0);
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(1182, 600);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup6});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup2.Size = new System.Drawing.Size(1162, 96);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlGroup6
            // 
            this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this._lciTORDER_DATE,
            this._lciTPART,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this._lciTVEND,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.emptySpaceItem2,
            this.layoutControlItem6,
            this.emptySpaceItem3});
            this.layoutControlGroup6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup6.Name = "layoutControlGroup6";
            this.layoutControlGroup6.Size = new System.Drawing.Size(1138, 72);
            this.layoutControlGroup6.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this._ucbtSELECT;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(129, 24);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(129, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(129, 24);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "조회";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // _lciTORDER_DATE
            // 
            this._lciTORDER_DATE.Control = this._luTORDER_DATE;
            this._lciTORDER_DATE.CustomizationFormText = "_lciTORDER_DATE";
            this._lciTORDER_DATE.Location = new System.Drawing.Point(0, 0);
            this._lciTORDER_DATE.Name = "_lciTORDER_DATE";
            this._lciTORDER_DATE.Size = new System.Drawing.Size(389, 24);
            this._lciTORDER_DATE.TextSize = new System.Drawing.Size(101, 14);
            // 
            // _lciTPART
            // 
            this._lciTPART.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciTPART.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciTPART.Control = this._luTPART;
            this._lciTPART.Location = new System.Drawing.Point(389, 0);
            this._lciTPART.MaxSize = new System.Drawing.Size(443, 24);
            this._lciTPART.MinSize = new System.Drawing.Size(443, 24);
            this._lciTPART.Name = "_lciTPART";
            this._lciTPART.Size = new System.Drawing.Size(443, 24);
            this._lciTPART.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciTPART.TextSize = new System.Drawing.Size(101, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this._ucbtCLEAR;
            this.layoutControlItem3.Location = new System.Drawing.Point(129, 24);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(129, 24);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(129, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(129, 24);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this._ucbtCancle;
            this.layoutControlItem4.Location = new System.Drawing.Point(258, 24);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(131, 24);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(131, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(131, 24);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // _lciTVEND
            // 
            this._lciTVEND.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciTVEND.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciTVEND.Control = this._luTVEND;
            this._lciTVEND.Location = new System.Drawing.Point(389, 24);
            this._lciTVEND.MaxSize = new System.Drawing.Size(443, 24);
            this._lciTVEND.MinSize = new System.Drawing.Size(443, 24);
            this._lciTVEND.Name = "_lciTVEND";
            this._lciTVEND.Size = new System.Drawing.Size(443, 24);
            this._lciTVEND.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciTVEND.TextSize = new System.Drawing.Size(101, 14);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this._ucbtCalc;
            this.layoutControlItem7.Location = new System.Drawing.Point(832, 24);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(131, 24);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(131, 24);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(131, 24);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this._ucbtCalc2;
            this.layoutControlItem8.Location = new System.Drawing.Point(832, 0);
            this.layoutControlItem8.MaxSize = new System.Drawing.Size(131, 24);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(131, 24);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(131, 24);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(963, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(10, 48);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this._ucbtSave;
            this.layoutControlItem6.Location = new System.Drawing.Point(973, 0);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(141, 24);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(141, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(141, 24);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(973, 24);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(141, 24);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
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
            columnDefinition1.Width = 37D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition2.Width = 20D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition3.Width = 63D;
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
            this.layoutControlGroup3.Size = new System.Drawing.Size(1162, 484);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this._gdCONTRACT;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.RowSpan = 2;
            this.layoutControlItem5.Size = new System.Drawing.Size(414, 460);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this._gdBOM;
            this.layoutControlItem1.Location = new System.Drawing.Point(434, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlItem1.OptionsTableLayoutItem.RowSpan = 2;
            this.layoutControlItem1.Size = new System.Drawing.Size(704, 460);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(963, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(10, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ucBOM_SpendQtyCalcPop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucBOM_SpendQtyCalcPop";
            this.Size = new System.Drawing.Size(1182, 600);
            this.Load += new System.EventHandler(this.ucBOM_SpendQtyCalcPop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gdBOM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdBOM_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdCONTRACT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdCONTRACT_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTORDER_DATE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTPART)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTVEND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraGrid.GridControl _gdBOM;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdBOM_VIEW;
        private DevExpress.XtraGrid.GridControl _gdCONTRACT;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdCONTRACT_VIEW;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup6;
        private CoFAS_MES.CORE.BaseControls.ucSimpleButton _ucbtSELECT;
        private CoFAS_MES.CORE.BaseControls.ucSimpleButton _ucbtCLEAR;
        private CoFAS_MES.CORE.BaseControls.ucSimpleButton _ucbtCancle;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private CORE.BaseControls.ucFromToDateEdit _luTORDER_DATE;
        private DevExpress.XtraLayout.LayoutControlItem _lciTORDER_DATE;
        private CORE.BaseControls.ucSearchEdit _luTVEND;
        private CORE.BaseControls.ucSearchEdit _luTPART;
        private DevExpress.XtraLayout.LayoutControlItem _lciTPART;
        private DevExpress.XtraLayout.LayoutControlItem _lciTVEND;
        private CORE.BaseControls.ucSimpleButton _ucbtSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private CORE.BaseControls.ucSimpleButton _ucbtCalc;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private CORE.BaseControls.ucSimpleButton _ucbtCalc2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}

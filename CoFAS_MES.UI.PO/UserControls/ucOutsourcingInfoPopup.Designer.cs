namespace CoFAS_MES.UI.PO.UserControls
{
    partial class ucOutsourcingInfoPopup
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
            this._ckALLCHECK = new DevExpress.XtraEditors.CheckEdit();
            this._luTPART_LOW = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luTPART_MIDDLE = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luTPART_HIGH = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luTPART_CODE = new CoFAS_MES.CORE.BaseControls.ucSearchEdit();
            this._ucbtSEARCH = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._luTORDER_NUMBER = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._ucbtSAVE = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._gdMAIN = new DevExpress.XtraGrid.GridControl();
            this._gdMAIN_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._ucbtAPPL = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this._lciTORDER_NUMBER = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciTPART_CODE = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciTPART_MIDDLE = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciTPART_LOW = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciTPART_HIGH = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._ckALLCHECK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ucbtAPPL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTORDER_NUMBER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTPART_CODE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTPART_MIDDLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTPART_LOW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTPART_HIGH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._ckALLCHECK);
            this.layoutControl1.Controls.Add(this._luTPART_LOW);
            this.layoutControl1.Controls.Add(this._luTPART_MIDDLE);
            this.layoutControl1.Controls.Add(this._luTPART_HIGH);
            this.layoutControl1.Controls.Add(this._luTPART_CODE);
            this.layoutControl1.Controls.Add(this._ucbtSEARCH);
            this.layoutControl1.Controls.Add(this._luTORDER_NUMBER);
            this.layoutControl1.Controls.Add(this._ucbtSAVE);
            this.layoutControl1.Controls.Add(this._gdMAIN);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this._ucbtAPPL});
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(590, 353, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(790, 491);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _ckALLCHECK
            // 
            this._ckALLCHECK.Location = new System.Drawing.Point(699, 48);
            this._ckALLCHECK.Name = "_ckALLCHECK";
            this._ckALLCHECK.Properties.Caption = "checkEdit1";
            this._ckALLCHECK.Size = new System.Drawing.Size(82, 19);
            this._ckALLCHECK.StyleController = this.layoutControl1;
            this._ckALLCHECK.TabIndex = 24;
            this._ckALLCHECK.CheckedChanged += new System.EventHandler(this._ckALLCHECK_CheckedChanged);
            // 
            // _luTPART_LOW
            // 
            this._luTPART_LOW.CancelButton = null;
            this._luTPART_LOW.CommandButton = null;
            this._luTPART_LOW.EditMask = "";
            this._luTPART_LOW.Location = new System.Drawing.Point(595, 48);
            this._luTPART_LOW.Margin = new System.Windows.Forms.Padding(0);
            this._luTPART_LOW.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luTPART_LOW.Name = "_luTPART_LOW";
            this._luTPART_LOW.PasswordChar = '\0';
            this._luTPART_LOW.ReadOnly = false;
            this._luTPART_LOW.Size = new System.Drawing.Size(100, 23);
            this._luTPART_LOW.TabIndex = 23;
            this._luTPART_LOW.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luTPART_LOW.UseMaskAsDisplayFormat = false;
            // 
            // _luTPART_MIDDLE
            // 
            this._luTPART_MIDDLE.CancelButton = null;
            this._luTPART_MIDDLE.CommandButton = null;
            this._luTPART_MIDDLE.EditMask = "";
            this._luTPART_MIDDLE.Location = new System.Drawing.Point(370, 48);
            this._luTPART_MIDDLE.Margin = new System.Windows.Forms.Padding(0);
            this._luTPART_MIDDLE.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luTPART_MIDDLE.Name = "_luTPART_MIDDLE";
            this._luTPART_MIDDLE.PasswordChar = '\0';
            this._luTPART_MIDDLE.ReadOnly = false;
            this._luTPART_MIDDLE.Size = new System.Drawing.Size(100, 23);
            this._luTPART_MIDDLE.TabIndex = 22;
            this._luTPART_MIDDLE.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luTPART_MIDDLE.UseMaskAsDisplayFormat = false;
            // 
            // _luTPART_HIGH
            // 
            this._luTPART_HIGH.CancelButton = null;
            this._luTPART_HIGH.CommandButton = null;
            this._luTPART_HIGH.EditMask = "";
            this._luTPART_HIGH.Location = new System.Drawing.Point(145, 48);
            this._luTPART_HIGH.Margin = new System.Windows.Forms.Padding(0);
            this._luTPART_HIGH.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luTPART_HIGH.Name = "_luTPART_HIGH";
            this._luTPART_HIGH.PasswordChar = '\0';
            this._luTPART_HIGH.ReadOnly = false;
            this._luTPART_HIGH.Size = new System.Drawing.Size(100, 23);
            this._luTPART_HIGH.TabIndex = 21;
            this._luTPART_HIGH.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luTPART_HIGH.UseMaskAsDisplayFormat = false;
            // 
            // _luTPART_CODE
            // 
            this._luTPART_CODE.BackColor = System.Drawing.Color.Transparent;
            this._luTPART_CODE.CodeReadOnly = false;
            this._luTPART_CODE.CodeText = "";
            this._luTPART_CODE.CodeTextName = "_pCodeTextEdit";
            this._luTPART_CODE.Location = new System.Drawing.Point(375, 24);
            this._luTPART_CODE.Name = "_luTPART_CODE";
            this._luTPART_CODE.NameEnabled = true;
            this._luTPART_CODE.NameReadOnly = false;
            this._luTPART_CODE.NameText = "";
            this._luTPART_CODE.NameTextName = "_pNameButtonEdit";
            this._luTPART_CODE.Size = new System.Drawing.Size(302, 20);
            this._luTPART_CODE.TabIndex = 20;
            this._luTPART_CODE._OnOpenClick += new CoFAS_MES.CORE.BaseControls.ucSearchEdit.OnOpenClickEventHandler(this._luTPART_CODE__OnOpenClick);
            // 
            // _ucbtSEARCH
            // 
            this._ucbtSEARCH.ButtonText = "simpleButton";
            this._ucbtSEARCH.Image = null;
            this._ucbtSEARCH.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtSEARCH.Location = new System.Drawing.Point(681, 24);
            this._ucbtSEARCH.Name = "_ucbtSEARCH";
            this._ucbtSEARCH.Size = new System.Drawing.Size(100, 20);
            this._ucbtSEARCH.TabIndex = 19;
            this._ucbtSEARCH.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._btnSearch_Click);
            // 
            // _luTORDER_NUMBER
            // 
            this._luTORDER_NUMBER.CancelButton = null;
            this._luTORDER_NUMBER.CommandButton = null;
            this._luTORDER_NUMBER.EditMask = "";
            this._luTORDER_NUMBER.Location = new System.Drawing.Point(145, 24);
            this._luTORDER_NUMBER.Margin = new System.Windows.Forms.Padding(0);
            this._luTORDER_NUMBER.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luTORDER_NUMBER.Name = "_luTORDER_NUMBER";
            this._luTORDER_NUMBER.PasswordChar = '\0';
            this._luTORDER_NUMBER.ReadOnly = false;
            this._luTORDER_NUMBER.Size = new System.Drawing.Size(105, 20);
            this._luTORDER_NUMBER.TabIndex = 18;
            this._luTORDER_NUMBER.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luTORDER_NUMBER.UseMaskAsDisplayFormat = false;
            // 
            // _ucbtSAVE
            // 
            this._ucbtSAVE.ButtonText = "simpleButton";
            this._ucbtSAVE.Image = null;
            this._ucbtSAVE.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtSAVE.Location = new System.Drawing.Point(24, 413);
            this._ucbtSAVE.Name = "_ucbtSAVE";
            this._ucbtSAVE.Size = new System.Drawing.Size(757, 37);
            this._ucbtSAVE.TabIndex = 15;
            this._ucbtSAVE.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtcontract_SAVE_Click);
            // 
            // _gdMAIN
            // 
            this._gdMAIN.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gdMAIN.Location = new System.Drawing.Point(24, 99);
            this._gdMAIN.MainView = this._gdMAIN_VIEW;
            this._gdMAIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gdMAIN.Name = "_gdMAIN";
            this._gdMAIN.Size = new System.Drawing.Size(757, 310);
            this._gdMAIN.TabIndex = 8;
            this._gdMAIN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gdMAIN_VIEW});
            // 
            // _gdMAIN_VIEW
            // 
            this._gdMAIN_VIEW.GridControl = this._gdMAIN;
            this._gdMAIN_VIEW.Name = "_gdMAIN_VIEW";
            // 
            // _ucbtAPPL
            // 
            this._ucbtAPPL.Location = new System.Drawing.Point(213, 0);
            this._ucbtAPPL.MinSize = new System.Drawing.Size(1, 1);
            this._ucbtAPPL.Name = "_ucbtAPPL";
            this._ucbtAPPL.Size = new System.Drawing.Size(222, 24);
            this._ucbtAPPL.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._ucbtAPPL.TextSize = new System.Drawing.Size(0, 0);
            this._ucbtAPPL.TextVisible = false;
            this._ucbtAPPL.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3,
            this.layoutControlGroup4});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(805, 474);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlItem4});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 75);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup3.Size = new System.Drawing.Size(785, 379);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this._gdMAIN;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(761, 314);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this._ucbtSAVE;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 314);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(0, 41);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(104, 41);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(761, 41);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this._lciTORDER_NUMBER,
            this._lciTPART_CODE,
            this._lciTPART_MIDDLE,
            this._lciTPART_LOW,
            this._lciTPART_HIGH,
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(785, 75);
            this.layoutControlGroup4.TextVisible = false;
            // 
            // _lciTORDER_NUMBER
            // 
            this._lciTORDER_NUMBER.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciTORDER_NUMBER.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciTORDER_NUMBER.Control = this._luTORDER_NUMBER;
            this._lciTORDER_NUMBER.Location = new System.Drawing.Point(0, 0);
            this._lciTORDER_NUMBER.MaxSize = new System.Drawing.Size(0, 24);
            this._lciTORDER_NUMBER.MinSize = new System.Drawing.Size(225, 24);
            this._lciTORDER_NUMBER.Name = "_lciTORDER_NUMBER";
            this._lciTORDER_NUMBER.Size = new System.Drawing.Size(230, 24);
            this._lciTORDER_NUMBER.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciTORDER_NUMBER.TextSize = new System.Drawing.Size(117, 14);
            // 
            // _lciTPART_CODE
            // 
            this._lciTPART_CODE.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciTPART_CODE.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciTPART_CODE.Control = this._luTPART_CODE;
            this._lciTPART_CODE.Location = new System.Drawing.Point(230, 0);
            this._lciTPART_CODE.MaxSize = new System.Drawing.Size(0, 24);
            this._lciTPART_CODE.MinSize = new System.Drawing.Size(225, 24);
            this._lciTPART_CODE.Name = "_lciTPART_CODE";
            this._lciTPART_CODE.Size = new System.Drawing.Size(427, 24);
            this._lciTPART_CODE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciTPART_CODE.TextSize = new System.Drawing.Size(117, 14);
            // 
            // _lciTPART_MIDDLE
            // 
            this._lciTPART_MIDDLE.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciTPART_MIDDLE.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciTPART_MIDDLE.Control = this._luTPART_MIDDLE;
            this._lciTPART_MIDDLE.Location = new System.Drawing.Point(225, 24);
            this._lciTPART_MIDDLE.MaxSize = new System.Drawing.Size(0, 27);
            this._lciTPART_MIDDLE.MinSize = new System.Drawing.Size(225, 27);
            this._lciTPART_MIDDLE.Name = "_lciTPART_MIDDLE";
            this._lciTPART_MIDDLE.Size = new System.Drawing.Size(225, 27);
            this._lciTPART_MIDDLE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciTPART_MIDDLE.TextSize = new System.Drawing.Size(117, 14);
            // 
            // _lciTPART_LOW
            // 
            this._lciTPART_LOW.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciTPART_LOW.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciTPART_LOW.Control = this._luTPART_LOW;
            this._lciTPART_LOW.Location = new System.Drawing.Point(450, 24);
            this._lciTPART_LOW.MaxSize = new System.Drawing.Size(0, 27);
            this._lciTPART_LOW.MinSize = new System.Drawing.Size(225, 27);
            this._lciTPART_LOW.Name = "_lciTPART_LOW";
            this._lciTPART_LOW.Size = new System.Drawing.Size(225, 27);
            this._lciTPART_LOW.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciTPART_LOW.TextSize = new System.Drawing.Size(117, 14);
            // 
            // _lciTPART_HIGH
            // 
            this._lciTPART_HIGH.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciTPART_HIGH.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciTPART_HIGH.Control = this._luTPART_HIGH;
            this._lciTPART_HIGH.Location = new System.Drawing.Point(0, 24);
            this._lciTPART_HIGH.MaxSize = new System.Drawing.Size(0, 27);
            this._lciTPART_HIGH.MinSize = new System.Drawing.Size(225, 27);
            this._lciTPART_HIGH.Name = "_lciTPART_HIGH";
            this._lciTPART_HIGH.Size = new System.Drawing.Size(225, 27);
            this._lciTPART_HIGH.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciTPART_HIGH.TextSize = new System.Drawing.Size(117, 14);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this._ucbtSEARCH;
            this.layoutControlItem1.Location = new System.Drawing.Point(657, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(104, 24);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this._ckALLCHECK;
            this.layoutControlItem2.Location = new System.Drawing.Point(675, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(86, 27);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // ucOutsourcingInfoPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ucOutsourcingInfoPopup";
            this.Size = new System.Drawing.Size(790, 491);
            this.Load += new System.EventHandler(this.ucOutsourcingInfoPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._ckALLCHECK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ucbtAPPL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTORDER_NUMBER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTPART_CODE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTPART_MIDDLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTPART_LOW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTPART_HIGH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl _gdMAIN;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdMAIN_VIEW;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private CoFAS_MES.CORE.BaseControls.ucSimpleButton _ucbtSAVE;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem _ucbtAPPL;
        private CORE.BaseControls.ucTextEdit _luTORDER_NUMBER;
        private DevExpress.XtraLayout.LayoutControlItem _lciTORDER_NUMBER;
        private CORE.BaseControls.ucSimpleButton _ucbtSEARCH;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private CORE.BaseControls.ucTextEdit _luTPART_LOW;
        private CORE.BaseControls.ucTextEdit _luTPART_MIDDLE;
        private CORE.BaseControls.ucTextEdit _luTPART_HIGH;
        private CORE.BaseControls.ucSearchEdit _luTPART_CODE;
        private DevExpress.XtraLayout.LayoutControlItem _lciTPART_CODE;
        private DevExpress.XtraLayout.LayoutControlItem _lciTPART_MIDDLE;
        private DevExpress.XtraLayout.LayoutControlItem _lciTPART_LOW;
        private DevExpress.XtraLayout.LayoutControlItem _lciTPART_HIGH;
        private DevExpress.XtraEditors.CheckEdit _ckALLCHECK;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}

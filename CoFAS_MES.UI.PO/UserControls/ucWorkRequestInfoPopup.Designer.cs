﻿namespace CoFAS_MES.UI.PO.UserControls
{
    partial class ucWorkRequestInfoPopup
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
            this._ucbtAccept = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._luPART_NAME = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._ucbtCLEAR = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._ucbtSELECT = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._gdMAIN = new DevExpress.XtraGrid.GridControl();
            this._gdMAIN_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._luTORDER_DATE = new CoFAS_MES.CORE.BaseControls.ucFromToDateEdit();
            this._ucbtCancle = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this._lciORDER_DATE = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciPART_NAME = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciORDER_DATE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPART_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._ucbtAccept);
            this.layoutControl1.Controls.Add(this._luPART_NAME);
            this.layoutControl1.Controls.Add(this._ucbtCLEAR);
            this.layoutControl1.Controls.Add(this._ucbtSELECT);
            this.layoutControl1.Controls.Add(this._gdMAIN);
            this.layoutControl1.Controls.Add(this._luTORDER_DATE);
            this.layoutControl1.Controls.Add(this._ucbtCancle);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(2485, 23, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(692, 526);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _ucbtAccept
            // 
            this._ucbtAccept.ButtonText = "simpleButton";
            this._ucbtAccept.Image = global::CoFAS_MES.UI.PO.Properties.Resources.save_16x16;
            this._ucbtAccept.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtAccept.Location = new System.Drawing.Point(565, 48);
            this._ucbtAccept.Name = "_ucbtAccept";
            this._ucbtAccept.Size = new System.Drawing.Size(105, 20);
            this._ucbtAccept.TabIndex = 14;
            this._ucbtAccept.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtAccept_Click);
            // 
            // _luPART_NAME
            // 
            this._luPART_NAME.CancelButton = null;
            this._luPART_NAME.CommandButton = null;
            this._luPART_NAME.EditMask = "";
            this._luPART_NAME.Location = new System.Drawing.Point(393, 24);
            this._luPART_NAME.Margin = new System.Windows.Forms.Padding(0);
            this._luPART_NAME.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luPART_NAME.Name = "_luPART_NAME";
            this._luPART_NAME.PasswordChar = '\0';
            this._luPART_NAME.ReadOnly = false;
            this._luPART_NAME.Size = new System.Drawing.Size(277, 20);
            this._luPART_NAME.TabIndex = 13;
            this._luPART_NAME.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luPART_NAME.UseMaskAsDisplayFormat = false;
            // 
            // _ucbtCLEAR
            // 
            this._ucbtCLEAR.ButtonText = "초기화";
            this._ucbtCLEAR.Image = global::CoFAS_MES.UI.PO.Properties.Resources.refresh_16x16;
            this._ucbtCLEAR.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtCLEAR.Location = new System.Drawing.Point(240, 48);
            this._ucbtCLEAR.Name = "_ucbtCLEAR";
            this._ucbtCLEAR.Size = new System.Drawing.Size(104, 20);
            this._ucbtCLEAR.TabIndex = 10;
            this._ucbtCLEAR.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._btCLEAR_Click);
            // 
            // _ucbtSELECT
            // 
            this._ucbtSELECT.ButtonText = "조회";
            this._ucbtSELECT.Image = global::CoFAS_MES.UI.PO.Properties.Resources.zoom_16x16;
            this._ucbtSELECT.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtSELECT.Location = new System.Drawing.Point(24, 48);
            this._ucbtSELECT.Name = "_ucbtSELECT";
            this._ucbtSELECT.Size = new System.Drawing.Size(104, 20);
            this._ucbtSELECT.TabIndex = 9;
            this._ucbtSELECT.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._btSELECT_Click);
            // 
            // _gdMAIN
            // 
            this._gdMAIN.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gdMAIN.Location = new System.Drawing.Point(24, 96);
            this._gdMAIN.MainView = this._gdMAIN_VIEW;
            this._gdMAIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gdMAIN.Name = "_gdMAIN";
            this._gdMAIN.Size = new System.Drawing.Size(646, 389);
            this._gdMAIN.TabIndex = 8;
            this._gdMAIN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gdMAIN_VIEW});
            // 
            // _gdMAIN_VIEW
            // 
            this._gdMAIN_VIEW.GridControl = this._gdMAIN;
            this._gdMAIN_VIEW.Name = "_gdMAIN_VIEW";
            // 
            // _luTORDER_DATE
            // 
            this._luTORDER_DATE.FromDateTime = new System.DateTime(2018, 4, 1, 0, 0, 0, 0);
            this._luTORDER_DATE.Location = new System.Drawing.Point(68, 24);
            this._luTORDER_DATE.Margin = new System.Windows.Forms.Padding(0);
            this._luTORDER_DATE.Name = "_luTORDER_DATE";
            this._luTORDER_DATE.Size = new System.Drawing.Size(277, 20);
            this._luTORDER_DATE.TabIndex = 4;
            this._luTORDER_DATE.ToDateTime = new System.DateTime(2018, 4, 26, 23, 59, 59, 0);
            // 
            // _ucbtCancle
            // 
            this._ucbtCancle.ButtonText = "닫기";
            this._ucbtCancle.Image = global::CoFAS_MES.UI.PO.Properties.Resources.close_16x162;
            this._ucbtCancle.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtCancle.Location = new System.Drawing.Point(132, 48);
            this._ucbtCancle.Name = "_ucbtCancle";
            this._ucbtCancle.Size = new System.Drawing.Size(104, 20);
            this._ucbtCancle.TabIndex = 11;
            this._ucbtCancle.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._btCancle_Click);
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(694, 509);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this._lciORDER_DATE,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.layoutControlItem2,
            this._lciPART_NAME,
            this.layoutControlItem4});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup2.Size = new System.Drawing.Size(674, 72);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // _lciORDER_DATE
            // 
            this._lciORDER_DATE.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciORDER_DATE.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciORDER_DATE.Control = this._luTORDER_DATE;
            this._lciORDER_DATE.CustomizationFormText = "_lciTORDER_DATE";
            this._lciORDER_DATE.Location = new System.Drawing.Point(0, 0);
            this._lciORDER_DATE.MaxSize = new System.Drawing.Size(325, 24);
            this._lciORDER_DATE.MinSize = new System.Drawing.Size(325, 24);
            this._lciORDER_DATE.Name = "_lciORDER_DATE";
            this._lciORDER_DATE.OptionsTableLayoutItem.ColumnSpan = 3;
            this._lciORDER_DATE.Size = new System.Drawing.Size(325, 24);
            this._lciORDER_DATE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciORDER_DATE.Text = "발주기간";
            this._lciORDER_DATE.TextSize = new System.Drawing.Size(40, 14);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this._ucbtSELECT;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(108, 24);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(108, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlItem1.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem1.Size = new System.Drawing.Size(108, 24);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this._ucbtCancle;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(108, 24);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(108, 24);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(108, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem3.Size = new System.Drawing.Size(108, 24);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(433, 24);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(108, 24);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(108, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(108, 24);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(324, 24);
            this.emptySpaceItem2.MaxSize = new System.Drawing.Size(109, 24);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(109, 24);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(109, 24);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this._ucbtCLEAR;
            this.layoutControlItem2.Location = new System.Drawing.Point(216, 24);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(108, 24);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(108, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem2.Size = new System.Drawing.Size(108, 24);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // _lciPART_NAME
            // 
            this._lciPART_NAME.Control = this._luPART_NAME;
            this._lciPART_NAME.Location = new System.Drawing.Point(325, 0);
            this._lciPART_NAME.MaxSize = new System.Drawing.Size(325, 24);
            this._lciPART_NAME.MinSize = new System.Drawing.Size(325, 24);
            this._lciPART_NAME.Name = "_lciPART_NAME";
            this._lciPART_NAME.OptionsTableLayoutItem.ColumnSpan = 3;
            this._lciPART_NAME.OptionsTableLayoutItem.RowIndex = 1;
            this._lciPART_NAME.Size = new System.Drawing.Size(325, 24);
            this._lciPART_NAME.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciPART_NAME.Text = "자재명";
            this._lciPART_NAME.TextSize = new System.Drawing.Size(40, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this._ucbtAccept;
            this.layoutControlItem4.Location = new System.Drawing.Point(541, 24);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(109, 24);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(109, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.ColumnIndex = 3;
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem4.Size = new System.Drawing.Size(109, 24);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 72);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup3.Size = new System.Drawing.Size(674, 417);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this._gdMAIN;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(650, 393);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // ucWorkRequestInfoPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucWorkRequestInfoPopup";
            this.Size = new System.Drawing.Size(692, 526);
            this.Load += new System.EventHandler(this.ucProductionOrderInfoPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciORDER_DATE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPART_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl _gdMAIN;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdMAIN_VIEW;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private CoFAS_MES.CORE.BaseControls.ucFromToDateEdit _luTORDER_DATE;
        private DevExpress.XtraLayout.LayoutControlItem _lciORDER_DATE;
        private CoFAS_MES.CORE.BaseControls.ucSimpleButton _ucbtCLEAR;
        private CoFAS_MES.CORE.BaseControls.ucSimpleButton _ucbtSELECT;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;

        private CoFAS_MES.CORE.BaseControls.ucSimpleButton _ucbtCancle;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private CORE.BaseControls.ucTextEdit _luPART_NAME;
        private DevExpress.XtraLayout.LayoutControlItem _lciPART_NAME;
        private CORE.BaseControls.ucSimpleButton _ucbtAccept;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}

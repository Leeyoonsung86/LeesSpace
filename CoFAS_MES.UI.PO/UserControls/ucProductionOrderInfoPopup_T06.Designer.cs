﻿namespace CoFAS_MES.UI.PO.UserControls
{
    partial class ucProductionOrderInfoPopup_T06
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this._ucbtSEARCH = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._ucFROMDATE = new CoFAS_MES.CORE.BaseControls.ucFromToDateEdit();
            this._luVEND = new CoFAS_MES.CORE.BaseControls.ucSearchEdit();
            this._luPART = new CoFAS_MES.CORE.BaseControls.ucSearchEdit();
            this._gdMAIN = new DevExpress.XtraGrid.GridControl();
            this._gdMAIN_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this._lciPART_CODE = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciVEND_CODE = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciDATE_TIME = new DevExpress.XtraLayout.LayoutControlItem();
            this._ucbtSC = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPART_CODE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciVEND_CODE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciDATE_TIME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ucbtSC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._ucbtSEARCH);
            this.layoutControl1.Controls.Add(this._ucFROMDATE);
            this.layoutControl1.Controls.Add(this._luVEND);
            this.layoutControl1.Controls.Add(this._luPART);
            this.layoutControl1.Controls.Add(this._gdMAIN);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(910, 202, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(691, 604);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _ucbtSEARCH
            // 
            this._ucbtSEARCH.ButtonText = "simpleButton";
            this._ucbtSEARCH.Image = global::CoFAS_MES.UI.PO.Properties.Resources.zoom_16x16;
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
            this._ucFROMDATE.Location = new System.Drawing.Point(114, 24);
            this._ucFROMDATE.Margin = new System.Windows.Forms.Padding(0);
            this._ucFROMDATE.Name = "_ucFROMDATE";
            this._ucFROMDATE.Size = new System.Drawing.Size(242, 20);
            this._ucFROMDATE.TabIndex = 19;
            this._ucFROMDATE.ToDateTime = new System.DateTime(2018, 7, 2, 23, 59, 59, 0);
            // 
            // _luVEND
            // 
            this._luVEND.BackColor = System.Drawing.Color.Transparent;
            this._luVEND.CodeReadOnly = false;
            this._luVEND.CodeText = "";
            this._luVEND.CodeTextName = "_pVEND_CODE";
            this._luVEND.Location = new System.Drawing.Point(450, 48);
            this._luVEND.Name = "_luVEND";
            this._luVEND.NameEnabled = true;
            this._luVEND.NameReadOnly = false;
            this._luVEND.NameText = "";
            this._luVEND.NameTextName = "_luVEND_NAME";
            this._luVEND.Size = new System.Drawing.Size(217, 20);
            this._luVEND.TabIndex = 17;
            this._luVEND._OnButtonPressed += new CoFAS_MES.CORE.BaseControls.ucSearchEdit.OnButtonPressedEventHandler(this._luVEND__OnButtonPressed);
            // 
            // _luPART
            // 
            this._luPART.BackColor = System.Drawing.Color.Transparent;
            this._luPART.CodeReadOnly = false;
            this._luPART.CodeText = "";
            this._luPART.CodeTextName = "_luPART_CODE";
            this._luPART.Location = new System.Drawing.Point(114, 48);
            this._luPART.Name = "_luPART";
            this._luPART.NameEnabled = true;
            this._luPART.NameReadOnly = false;
            this._luPART.NameText = "";
            this._luPART.NameTextName = "_luPART_NAME";
            this._luPART.Size = new System.Drawing.Size(242, 20);
            this._luPART.TabIndex = 16;
            this._luPART._OnButtonPressed += new CoFAS_MES.CORE.BaseControls.ucSearchEdit.OnButtonPressedEventHandler(this._luPART__OnButtonPressed);
            // 
            // _gdMAIN
            // 
            this._gdMAIN.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gdMAIN.Location = new System.Drawing.Point(24, 96);
            this._gdMAIN.MainView = this._gdMAIN_VIEW;
            this._gdMAIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gdMAIN.Name = "_gdMAIN";
            this._gdMAIN.Size = new System.Drawing.Size(643, 484);
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(691, 604);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem2,
            this._lciPART_CODE,
            this._lciVEND_CODE,
            this._lciDATE_TIME,
            this._ucbtSC});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup2.Size = new System.Drawing.Size(671, 72);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(440, 0);
            this.emptySpaceItem2.MaxSize = new System.Drawing.Size(207, 24);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(207, 24);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(207, 24);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // _lciPART_CODE
            // 
            this._lciPART_CODE.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciPART_CODE.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciPART_CODE.Control = this._luPART;
            this._lciPART_CODE.Location = new System.Drawing.Point(0, 24);
            this._lciPART_CODE.MaxSize = new System.Drawing.Size(336, 24);
            this._lciPART_CODE.MinSize = new System.Drawing.Size(336, 24);
            this._lciPART_CODE.Name = "_lciPART_CODE";
            this._lciPART_CODE.Size = new System.Drawing.Size(336, 24);
            this._lciPART_CODE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciPART_CODE.TextSize = new System.Drawing.Size(86, 14);
            // 
            // _lciVEND_CODE
            // 
            this._lciVEND_CODE.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciVEND_CODE.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciVEND_CODE.Control = this._luVEND;
            this._lciVEND_CODE.Location = new System.Drawing.Point(336, 24);
            this._lciVEND_CODE.MaxSize = new System.Drawing.Size(0, 24);
            this._lciVEND_CODE.MinSize = new System.Drawing.Size(194, 24);
            this._lciVEND_CODE.Name = "_lciVEND_CODE";
            this._lciVEND_CODE.Size = new System.Drawing.Size(311, 24);
            this._lciVEND_CODE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciVEND_CODE.TextSize = new System.Drawing.Size(86, 14);
            // 
            // _lciDATE_TIME
            // 
            this._lciDATE_TIME.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciDATE_TIME.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciDATE_TIME.Control = this._ucFROMDATE;
            this._lciDATE_TIME.Location = new System.Drawing.Point(0, 0);
            this._lciDATE_TIME.MaxSize = new System.Drawing.Size(336, 24);
            this._lciDATE_TIME.MinSize = new System.Drawing.Size(336, 24);
            this._lciDATE_TIME.Name = "_lciDATE_TIME";
            this._lciDATE_TIME.Size = new System.Drawing.Size(336, 24);
            this._lciDATE_TIME.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciDATE_TIME.TextSize = new System.Drawing.Size(86, 14);
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
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 72);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup3.Size = new System.Drawing.Size(671, 512);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this._gdMAIN;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(647, 488);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // ucProductionOrderInfoPopup_T06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ucProductionOrderInfoPopup_T06";
            this.Size = new System.Drawing.Size(691, 604);
            this.Load += new System.EventHandler(this.ucProductionOrderInfoPopup_T06_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPART_CODE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciVEND_CODE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciDATE_TIME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ucbtSC)).EndInit();
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
        private CoFAS_MES.CORE.BaseControls.ucSearchEdit _luVEND;
        private CoFAS_MES.CORE.BaseControls.ucSearchEdit _luPART;
        private DevExpress.XtraLayout.LayoutControlItem _lciPART_CODE;
        private DevExpress.XtraLayout.LayoutControlItem _lciVEND_CODE;
        private CoFAS_MES.CORE.BaseControls.ucFromToDateEdit _ucFROMDATE;
        private DevExpress.XtraLayout.LayoutControlItem _lciDATE_TIME;
        private CoFAS_MES.CORE.BaseControls.ucSimpleButton _ucbtSEARCH;
        private DevExpress.XtraLayout.LayoutControlItem _ucbtSC;
    }
}
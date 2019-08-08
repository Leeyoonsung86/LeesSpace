namespace CoFAS_MES.AUTO.UL
{
    partial class frmProgramUpload
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this._lbMAIN_HEADER = new DevExpress.XtraEditors.LabelControl();
            this._pnTop = new DevExpress.XtraEditors.PanelControl();
            this._btMin = new DevExpress.XtraEditors.SimpleButton();
            this._btMax = new DevExpress.XtraEditors.SimpleButton();
            this._btClose = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this._btCORP_ADD = new DevExpress.XtraEditors.SimpleButton();
            this._luCORP_CODE = new CoFAS_MES.CORE.BaseControls.ucLookUpEdit();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this._btSEARCH = new DevExpress.XtraEditors.SimpleButton();
            this._btNEWFILE = new DevExpress.XtraEditors.SimpleButton();
            this._btUPLOAD = new DevExpress.XtraEditors.SimpleButton();
            this._btREFRESH = new DevExpress.XtraEditors.SimpleButton();
            this._luFILE_TYPE = new CoFAS_MES.CORE.BaseControls.ucComboBox();
            this._gdMAIN = new DevExpress.XtraGrid.GridControl();
            this._gdMAIN_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this._pnTop)).BeginInit();
            this._pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            this.SuspendLayout();
            // 
            // _lbMAIN_HEADER
            // 
            this._lbMAIN_HEADER.Appearance.Image = global::CoFAS_MES.AUTO.UL.Properties.Resources.cube_16x16;
            this._lbMAIN_HEADER.Appearance.Options.UseImage = true;
            this._lbMAIN_HEADER.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this._lbMAIN_HEADER.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbMAIN_HEADER.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this._lbMAIN_HEADER.Location = new System.Drawing.Point(0, 0);
            this._lbMAIN_HEADER.Name = "_lbMAIN_HEADER";
            this._lbMAIN_HEADER.Size = new System.Drawing.Size(1340, 23);
            this._lbMAIN_HEADER.TabIndex = 1;
            this._lbMAIN_HEADER.Text = "CoFAS MES Upload Program";
            this._lbMAIN_HEADER.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_Moving);
            // 
            // _pnTop
            // 
            this._pnTop.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this._pnTop.Appearance.Options.UseBackColor = true;
            this._pnTop.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._pnTop.Controls.Add(this._lbMAIN_HEADER);
            this._pnTop.Controls.Add(this._btMin);
            this._pnTop.Controls.Add(this._btMax);
            this._pnTop.Controls.Add(this._btClose);
            this._pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this._pnTop.Location = new System.Drawing.Point(0, 0);
            this._pnTop.Name = "_pnTop";
            this._pnTop.Size = new System.Drawing.Size(1400, 23);
            this._pnTop.TabIndex = 2;
            // 
            // _btMin
            // 
            this._btMin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._btMin.Dock = System.Windows.Forms.DockStyle.Right;
            this._btMin.ImageOptions.Image = global::CoFAS_MES.AUTO.UL.Properties.Resources.alignhorizontalbottom_16x16;
            this._btMin.Location = new System.Drawing.Point(1340, 0);
            this._btMin.Margin = new System.Windows.Forms.Padding(0);
            this._btMin.Name = "_btMin";
            this._btMin.Size = new System.Drawing.Size(20, 23);
            this._btMin.TabIndex = 5;
            this._btMin.Click += new System.EventHandler(this._btMin_Click);
            // 
            // _btMax
            // 
            this._btMax.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._btMax.Dock = System.Windows.Forms.DockStyle.Right;
            this._btMax.ImageOptions.Image = global::CoFAS_MES.AUTO.UL.Properties.Resources.alignhorizontaltop_16x16;
            this._btMax.Location = new System.Drawing.Point(1360, 0);
            this._btMax.Margin = new System.Windows.Forms.Padding(0);
            this._btMax.Name = "_btMax";
            this._btMax.Size = new System.Drawing.Size(20, 23);
            this._btMax.TabIndex = 4;
            this._btMax.Click += new System.EventHandler(this._btMax_Click);
            // 
            // _btClose
            // 
            this._btClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._btClose.Dock = System.Windows.Forms.DockStyle.Right;
            this._btClose.ImageOptions.Image = global::CoFAS_MES.AUTO.UL.Properties.Resources.close_16x16;
            this._btClose.Location = new System.Drawing.Point(1380, 0);
            this._btClose.Margin = new System.Windows.Forms.Padding(0);
            this._btClose.Name = "_btClose";
            this._btClose.Size = new System.Drawing.Size(20, 23);
            this._btClose.TabIndex = 3;
            this._btClose.Click += new System.EventHandler(this._btClose_Click);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._btCORP_ADD);
            this.layoutControl1.Controls.Add(this._luCORP_CODE);
            this.layoutControl1.Controls.Add(this.progressBarControl1);
            this.layoutControl1.Controls.Add(this.panelControl1);
            this.layoutControl1.Controls.Add(this._btSEARCH);
            this.layoutControl1.Controls.Add(this._btNEWFILE);
            this.layoutControl1.Controls.Add(this._btUPLOAD);
            this.layoutControl1.Controls.Add(this._btREFRESH);
            this.layoutControl1.Controls.Add(this._luFILE_TYPE);
            this.layoutControl1.Controls.Add(this._gdMAIN);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 23);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1400, 833);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _btCORP_ADD
            // 
            this._btCORP_ADD.ImageOptions.Image = global::CoFAS_MES.AUTO.UL.Properties.Resources.edittask_16x16;
            this._btCORP_ADD.Location = new System.Drawing.Point(476, 24);
            this._btCORP_ADD.Name = "_btCORP_ADD";
            this._btCORP_ADD.Size = new System.Drawing.Size(448, 22);
            this._btCORP_ADD.StyleController = this.layoutControl1;
            this._btCORP_ADD.TabIndex = 15;
            this._btCORP_ADD.Text = "업체등록";
            // 
            // _luCORP_CODE
            // 
            this._luCORP_CODE.ItemIndex = -1;
            this._luCORP_CODE.Location = new System.Drawing.Point(71, 24);
            this._luCORP_CODE.Margin = new System.Windows.Forms.Padding(0);
            this._luCORP_CODE.Name = "_luCORP_CODE";
            this._luCORP_CODE.ReadOnly = false;
            this._luCORP_CODE.Size = new System.Drawing.Size(401, 22);
            this._luCORP_CODE.TabIndex = 14;
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(702, 801);
            this.progressBarControl1.Margin = new System.Windows.Forms.Padding(0);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Size = new System.Drawing.Size(686, 18);
            this.progressBarControl1.StyleController = this.layoutControl1;
            this.progressBarControl1.TabIndex = 13;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(12, 801);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(686, 20);
            this.panelControl1.TabIndex = 12;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Image = global::CoFAS_MES.AUTO.UL.Properties.Resources.pielabelstooltips_16x16;
            this.labelControl1.Appearance.Options.UseImage = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelControl1.Size = new System.Drawing.Size(686, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Message";
            // 
            // _btSEARCH
            // 
            this._btSEARCH.ImageOptions.Image = global::CoFAS_MES.AUTO.UL.Properties.Resources.zoom_16x16;
            this._btSEARCH.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this._btSEARCH.Location = new System.Drawing.Point(24, 60);
            this._btSEARCH.Name = "_btSEARCH";
            this._btSEARCH.Size = new System.Drawing.Size(335, 40);
            this._btSEARCH.StyleController = this.layoutControl1;
            this._btSEARCH.TabIndex = 11;
            this._btSEARCH.Text = "조회";
            this._btSEARCH.Click += new System.EventHandler(this._btSEARCH_Click);
            // 
            // _btNEWFILE
            // 
            this._btNEWFILE.ImageOptions.Image = global::CoFAS_MES.AUTO.UL.Properties.Resources.additem_16x16;
            this._btNEWFILE.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this._btNEWFILE.Location = new System.Drawing.Point(1041, 60);
            this._btNEWFILE.Name = "_btNEWFILE";
            this._btNEWFILE.Size = new System.Drawing.Size(335, 40);
            this._btNEWFILE.StyleController = this.layoutControl1;
            this._btNEWFILE.TabIndex = 10;
            this._btNEWFILE.Text = "신규";
            this._btNEWFILE.Click += new System.EventHandler(this._btNEWFILE_Click);
            // 
            // _btUPLOAD
            // 
            this._btUPLOAD.ImageOptions.Image = global::CoFAS_MES.AUTO.UL.Properties.Resources.editdatasource_16x16;
            this._btUPLOAD.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this._btUPLOAD.Location = new System.Drawing.Point(702, 60);
            this._btUPLOAD.Name = "_btUPLOAD";
            this._btUPLOAD.Size = new System.Drawing.Size(335, 40);
            this._btUPLOAD.StyleController = this.layoutControl1;
            this._btUPLOAD.TabIndex = 9;
            this._btUPLOAD.Text = "업로드";
            this._btUPLOAD.Click += new System.EventHandler(this._btUPLOAD_Click);
            // 
            // _btREFRESH
            // 
            this._btREFRESH.ImageOptions.Image = global::CoFAS_MES.AUTO.UL.Properties.Resources.recurrence_16x16;
            this._btREFRESH.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this._btREFRESH.Location = new System.Drawing.Point(363, 60);
            this._btREFRESH.Name = "_btREFRESH";
            this._btREFRESH.Size = new System.Drawing.Size(335, 40);
            this._btREFRESH.StyleController = this.layoutControl1;
            this._btREFRESH.TabIndex = 8;
            this._btREFRESH.Text = "새로고침";
            this._btREFRESH.Click += new System.EventHandler(this._btREFRESH_Click);
            // 
            // _luFILE_TYPE
            // 
            this._luFILE_TYPE.Location = new System.Drawing.Point(975, 24);
            this._luFILE_TYPE.Margin = new System.Windows.Forms.Padding(0);
            this._luFILE_TYPE.Name = "_luFILE_TYPE";
            this._luFILE_TYPE.ReadOnly = false;
            this._luFILE_TYPE.SelectedIndex = -1;
            this._luFILE_TYPE.SelectedItem = null;
            this._luFILE_TYPE.Size = new System.Drawing.Size(401, 22);
            this._luFILE_TYPE.TabIndex = 7;
            // 
            // _gdMAIN
            // 
            this._gdMAIN.Location = new System.Drawing.Point(24, 128);
            this._gdMAIN.MainView = this._gdMAIN_VIEW;
            this._gdMAIN.Name = "_gdMAIN";
            this._gdMAIN.Size = new System.Drawing.Size(1352, 657);
            this._gdMAIN.TabIndex = 4;
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
            this.layoutControlGroup3,
            this.layoutControlItem9,
            this.layoutControlItem10});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1400, 833);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.emptySpaceItem2,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem11,
            this.layoutControlItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1380, 104);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this._luFILE_TYPE;
            this.layoutControlItem4.Location = new System.Drawing.Point(904, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(452, 26);
            this.layoutControlItem4.Text = "파일 구분";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(44, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this._btREFRESH;
            this.layoutControlItem5.Location = new System.Drawing.Point(339, 36);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(339, 44);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this._btUPLOAD;
            this.layoutControlItem6.Location = new System.Drawing.Point(678, 36);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(339, 44);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 26);
            this.emptySpaceItem2.MaxSize = new System.Drawing.Size(1356, 10);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(1356, 10);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(1356, 10);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this._btNEWFILE;
            this.layoutControlItem7.Location = new System.Drawing.Point(1017, 36);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(339, 44);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this._btSEARCH;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 36);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(339, 44);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this._luCORP_CODE;
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(452, 26);
            this.layoutControlItem11.Text = "업체";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(44, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this._btCORP_ADD;
            this.layoutControlItem2.Location = new System.Drawing.Point(452, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(452, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 104);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(1380, 685);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this._gdMAIN;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1356, 661);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.panelControl1;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 789);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(690, 24);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.progressBarControl1;
            this.layoutControlItem10.Location = new System.Drawing.Point(690, 789);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(690, 24);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // frmProgramUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 856);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this._pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProgramUpload";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmProgramUpload_Load);
            ((System.ComponentModel.ISupportInitialize)(this._pnTop)).EndInit();
            this._pnTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl _lbMAIN_HEADER;
        private DevExpress.XtraEditors.PanelControl _pnTop;
        private DevExpress.XtraEditors.SimpleButton _btMin;
        private DevExpress.XtraEditors.SimpleButton _btMax;
        private DevExpress.XtraEditors.SimpleButton _btClose;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl _gdMAIN;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdMAIN_VIEW;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private CORE.BaseControls.ucComboBox _luFILE_TYPE;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton _btSEARCH;
        private DevExpress.XtraEditors.SimpleButton _btNEWFILE;
        private DevExpress.XtraEditors.SimpleButton _btUPLOAD;
        private DevExpress.XtraEditors.SimpleButton _btREFRESH;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton _btCORP_ADD;
        private CORE.BaseControls.ucLookUpEdit _luCORP_CODE;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}


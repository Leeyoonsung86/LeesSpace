﻿namespace CoFAS_MES.UI.SM.UserControls
{
    partial class ucUserAuthorityCopy
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
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._gdSUB = new DevExpress.XtraGrid.GridControl();
            this._gdSUB_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._ucbtCANCLE = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._gdMAIN = new DevExpress.XtraGrid.GridControl();
            this._gdMAIN_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._ucbtSAVE = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.label2);
            this.layoutControl1.Controls.Add(this.label1);
            this.layoutControl1.Controls.Add(this._gdSUB);
            this.layoutControl1.Controls.Add(this._ucbtCANCLE);
            this.layoutControl1.Controls.Add(this._gdMAIN);
            this.layoutControl1.Controls.Add(this._ucbtSAVE);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(922, 248, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(725, 658);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(379, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "권한 가져올 사용자";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "권한 복사할 사용자";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _gdSUB
            // 
            this._gdSUB.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._gdSUB.Location = new System.Drawing.Point(391, 48);
            this._gdSUB.MainView = this._gdSUB_VIEW;
            this._gdSUB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._gdSUB.Name = "_gdSUB";
            this._gdSUB.Size = new System.Drawing.Size(310, 536);
            this._gdSUB.TabIndex = 14;
            this._gdSUB.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gdSUB_VIEW});
            // 
            // _gdSUB_VIEW
            // 
            this._gdSUB_VIEW.GridControl = this._gdSUB;
            this._gdSUB_VIEW.Name = "_gdSUB_VIEW";
            // 
            // _ucbtCANCLE
            // 
            this._ucbtCANCLE.ButtonText = "닫기";
            this._ucbtCANCLE.FontSize = 0;
            this._ucbtCANCLE.Image = global::CoFAS_MES.UI.SM.Properties.Resources.close_16x16;
            this._ucbtCANCLE.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtCANCLE.Location = new System.Drawing.Point(536, 612);
            this._ucbtCANCLE.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this._ucbtCANCLE.Name = "_ucbtCANCLE";
            this._ucbtCANCLE.Size = new System.Drawing.Size(165, 22);
            this._ucbtCANCLE.TabIndex = 6;
            this._ucbtCANCLE.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._btCancle_Click);
            // 
            // _gdMAIN
            // 
            this._gdMAIN.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._gdMAIN.Location = new System.Drawing.Point(24, 48);
            this._gdMAIN.MainView = this._gdMAIN_VIEW;
            this._gdMAIN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._gdMAIN.Name = "_gdMAIN";
            this._gdMAIN.Size = new System.Drawing.Size(309, 536);
            this._gdMAIN.TabIndex = 10;
            this._gdMAIN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gdMAIN_VIEW});
            // 
            // _gdMAIN_VIEW
            // 
            this._gdMAIN_VIEW.GridControl = this._gdMAIN;
            this._gdMAIN_VIEW.Name = "_gdMAIN_VIEW";
            // 
            // _ucbtSAVE
            // 
            this._ucbtSAVE.ButtonText = "저장";
            this._ucbtSAVE.FontSize = 0;
            this._ucbtSAVE.Image = global::CoFAS_MES.UI.SM.Properties.Resources.save_16x16;
            this._ucbtSAVE.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtSAVE.Location = new System.Drawing.Point(364, 612);
            this._ucbtSAVE.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this._ucbtSAVE.Name = "_ucbtSAVE";
            this._ucbtSAVE.Size = new System.Drawing.Size(168, 22);
            this._ucbtSAVE.TabIndex = 7;
            this._ucbtSAVE.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._btSAVE_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3,
            this.layoutControlGroup5,
            this.layoutControlGroup6,
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.layoutControlGroup1.Name = "Root";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition1.Width = 50D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition2.Width = 30D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition3.Width = 50D;
            this.layoutControlGroup1.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3});
            rowDefinition1.Height = 24D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition2.Height = 564D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.AutoSize;
            rowDefinition3.Height = 50D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            this.layoutControlGroup1.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3});
            this.layoutControlGroup1.Size = new System.Drawing.Size(725, 658);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.emptySpaceItem2});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 588);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlGroup3.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlGroup3.Size = new System.Drawing.Size(705, 50);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this._ucbtSAVE;
            this.layoutControlItem4.Location = new System.Drawing.Point(340, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem4.Size = new System.Drawing.Size(172, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this._ucbtCANCLE;
            this.layoutControlItem3.Location = new System.Drawing.Point(512, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(169, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(340, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6});
            this.layoutControlGroup5.Location = new System.Drawing.Point(367, 24);
            this.layoutControlGroup5.Name = "layoutControlGroup5";
            this.layoutControlGroup5.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlGroup5.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlGroup5.Size = new System.Drawing.Size(338, 564);
            this.layoutControlGroup5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this._gdSUB;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem6.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem6.Size = new System.Drawing.Size(314, 540);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlGroup6
            // 
            this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7});
            this.layoutControlGroup6.Location = new System.Drawing.Point(0, 24);
            this.layoutControlGroup6.Name = "layoutControlGroup6";
            this.layoutControlGroup6.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlGroup6.Size = new System.Drawing.Size(337, 564);
            this.layoutControlGroup6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this._gdMAIN;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem7.Size = new System.Drawing.Size(313, 540);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.label1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(337, 24);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.label2;
            this.layoutControlItem2.Location = new System.Drawing.Point(367, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlItem2.Size = new System.Drawing.Size(338, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // ucUserAuthorityCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucUserAuthorityCopy";
            this.Size = new System.Drawing.Size(725, 658);
            this.Load += new System.EventHandler(this.ucUserAuthorityCopy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl _gdMAIN;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdMAIN_VIEW;
        private CORE.BaseControls.ucSimpleButton _ucbtSAVE;
        private CORE.BaseControls.ucSimpleButton _ucbtCANCLE;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.GridControl _gdSUB;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdSUB_VIEW;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}

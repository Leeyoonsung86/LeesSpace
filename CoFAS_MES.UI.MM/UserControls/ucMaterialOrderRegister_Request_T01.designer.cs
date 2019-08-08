namespace CoFAS_MES.UI.MM.UserControls
{
    partial class ucMaterialOrderRegister_Request_T01
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this._gdSUB = new DevExpress.XtraGrid.GridControl();
            this._gdSUB_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._luTVEND_CODE = new CoFAS_MES.CORE.BaseControls.ucSearchEdit();
            this._luTORDER_DATE = new CoFAS_MES.CORE.BaseControls.ucFromToDateEdit();
            this._ucbtSAVE = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._ucbtCANCLE = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._ucbtSELECT = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._ucbtCLEAR = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._gdMAIN = new DevExpress.XtraGrid.GridControl();
            this._gdMAIN_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciTORDER_DATE = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciTVEND_CODE = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this._ckALLCHECK = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTORDER_DATE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTVEND_CODE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ckALLCHECK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._ckALLCHECK);
            this.layoutControl1.Controls.Add(this._gdSUB);
            this.layoutControl1.Controls.Add(this._luTVEND_CODE);
            this.layoutControl1.Controls.Add(this._luTORDER_DATE);
            this.layoutControl1.Controls.Add(this._ucbtSAVE);
            this.layoutControl1.Controls.Add(this._ucbtCANCLE);
            this.layoutControl1.Controls.Add(this._ucbtSELECT);
            this.layoutControl1.Controls.Add(this._ucbtCLEAR);
            this.layoutControl1.Controls.Add(this._gdMAIN);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(873, 526);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _gdSUB
            // 
            this._gdSUB.Location = new System.Drawing.Point(358, 70);
            this._gdSUB.MainView = this._gdSUB_VIEW;
            this._gdSUB.Name = "_gdSUB";
            this._gdSUB.Size = new System.Drawing.Size(503, 420);
            this._gdSUB.TabIndex = 17;
            this._gdSUB.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gdSUB_VIEW});
            // 
            // _gdSUB_VIEW
            // 
            this._gdSUB_VIEW.GridControl = this._gdSUB;
            this._gdSUB_VIEW.Name = "_gdSUB_VIEW";
            // 
            // _luTVEND_CODE
            // 
            this._luTVEND_CODE.BackColor = System.Drawing.Color.Transparent;
            this._luTVEND_CODE.CodeReadOnly = false;
            this._luTVEND_CODE.CodeText = "";
            this._luTVEND_CODE.CodeTextName = "_pCodeTextEdit";
            this._luTVEND_CODE.Location = new System.Drawing.Point(542, 12);
            this._luTVEND_CODE.Name = "_luTVEND_CODE";
            this._luTVEND_CODE.NameEnabled = true;
            this._luTVEND_CODE.NameReadOnly = false;
            this._luTVEND_CODE.NameText = "";
            this._luTVEND_CODE.NameTextName = "_pNameButtonEdit";
            this._luTVEND_CODE.Size = new System.Drawing.Size(319, 20);
            this._luTVEND_CODE.TabIndex = 16;
            this._luTVEND_CODE._OnOpenClick += new CoFAS_MES.CORE.BaseControls.ucSearchEdit.OnOpenClickEventHandler(this._luTVEND_CODE__OnOpenClick);
            // 
            // _luTORDER_DATE
            // 
            this._luTORDER_DATE.FromDateTime = new System.DateTime(2019, 2, 1, 0, 0, 0, 0);
            this._luTORDER_DATE.Location = new System.Drawing.Point(116, 12);
            this._luTORDER_DATE.Margin = new System.Windows.Forms.Padding(0);
            this._luTORDER_DATE.Name = "_luTORDER_DATE";
            this._luTORDER_DATE.Size = new System.Drawing.Size(318, 20);
            this._luTORDER_DATE.TabIndex = 15;
            this._luTORDER_DATE.ToDateTime = new System.DateTime(2019, 2, 18, 23, 59, 59, 0);
            // 
            // _ucbtSAVE
            // 
            this._ucbtSAVE.ButtonText = "simpleButton";
            this._ucbtSAVE.FontSize = 0;
            this._ucbtSAVE.Image = null;
            this._ucbtSAVE.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtSAVE.Location = new System.Drawing.Point(12, 494);
            this._ucbtSAVE.Name = "_ucbtSAVE";
            this._ucbtSAVE.Size = new System.Drawing.Size(849, 20);
            this._ucbtSAVE.TabIndex = 14;
            this._ucbtSAVE.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtSAVE_Click);
            // 
            // _ucbtCANCLE
            // 
            this._ucbtCANCLE.ButtonText = "닫기";
            this._ucbtCANCLE.FontSize = 0;
            this._ucbtCANCLE.Image = global::CoFAS_MES.UI.MM.Properties.Resources.close_16x16;
            this._ucbtCANCLE.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtCANCLE.Location = new System.Drawing.Point(725, 46);
            this._ucbtCANCLE.Name = "_ucbtCANCLE";
            this._ucbtCANCLE.Size = new System.Drawing.Size(136, 20);
            this._ucbtCANCLE.TabIndex = 10;
            this._ucbtCANCLE.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtCANCLE_Click);
            // 
            // _ucbtSELECT
            // 
            this._ucbtSELECT.ButtonText = "조회";
            this._ucbtSELECT.FontSize = 0;
            this._ucbtSELECT.Image = global::CoFAS_MES.UI.MM.Properties.Resources.zoom_16x16;
            this._ucbtSELECT.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtSELECT.Location = new System.Drawing.Point(585, 46);
            this._ucbtSELECT.Name = "_ucbtSELECT";
            this._ucbtSELECT.Size = new System.Drawing.Size(136, 20);
            this._ucbtSELECT.TabIndex = 9;
            this._ucbtSELECT.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtSELECT_Click);
            // 
            // _ucbtCLEAR
            // 
            this._ucbtCLEAR.ButtonText = "초기화";
            this._ucbtCLEAR.FontSize = 0;
            this._ucbtCLEAR.Image = global::CoFAS_MES.UI.MM.Properties.Resources.refresh_16x16;
            this._ucbtCLEAR.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtCLEAR.Location = new System.Drawing.Point(481, 46);
            this._ucbtCLEAR.Name = "_ucbtCLEAR";
            this._ucbtCLEAR.Size = new System.Drawing.Size(100, 20);
            this._ucbtCLEAR.TabIndex = 8;
            this._ucbtCLEAR.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtCLEAR_Click);
            // 
            // _gdMAIN
            // 
            this._gdMAIN.Location = new System.Drawing.Point(12, 70);
            this._gdMAIN.MainView = this._gdMAIN_VIEW;
            this._gdMAIN.Name = "_gdMAIN";
            this._gdMAIN.Size = new System.Drawing.Size(342, 420);
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
            this.layoutControlItem1,
            this.emptySpaceItem2,
            this.layoutControlItem6,
            this.layoutControlItem5,
            this.layoutControlItem2,
            this._lciTORDER_DATE,
            this.emptySpaceItem1,
            this.layoutControlItem7,
            this._lciTVEND_CODE,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(873, 526);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this._gdMAIN;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 58);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(346, 424);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 34);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(372, 24);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this._ucbtSELECT;
            this.layoutControlItem6.Location = new System.Drawing.Point(573, 34);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(140, 24);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this._ucbtCLEAR;
            this.layoutControlItem5.Location = new System.Drawing.Point(469, 34);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(104, 24);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this._ucbtSAVE;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 482);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(853, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // _lciTORDER_DATE
            // 
            this._lciTORDER_DATE.Control = this._luTORDER_DATE;
            this._lciTORDER_DATE.Location = new System.Drawing.Point(0, 0);
            this._lciTORDER_DATE.Name = "_lciTORDER_DATE";
            this._lciTORDER_DATE.Size = new System.Drawing.Size(426, 24);
            this._lciTORDER_DATE.TextSize = new System.Drawing.Size(101, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(853, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this._ucbtCANCLE;
            this.layoutControlItem7.Location = new System.Drawing.Point(713, 34);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(140, 24);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // _lciTVEND_CODE
            // 
            this._lciTVEND_CODE.Control = this._luTVEND_CODE;
            this._lciTVEND_CODE.Location = new System.Drawing.Point(426, 0);
            this._lciTVEND_CODE.Name = "_lciTVEND_CODE";
            this._lciTVEND_CODE.Size = new System.Drawing.Size(427, 24);
            this._lciTVEND_CODE.TextSize = new System.Drawing.Size(101, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this._gdSUB;
            this.layoutControlItem3.Location = new System.Drawing.Point(346, 58);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(507, 424);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // _ckALLCHECK
            // 
            this._ckALLCHECK.Location = new System.Drawing.Point(384, 46);
            this._ckALLCHECK.Name = "_ckALLCHECK";
            this._ckALLCHECK.Properties.Caption = "checkEdit1";
            this._ckALLCHECK.Size = new System.Drawing.Size(93, 19);
            this._ckALLCHECK.StyleController = this.layoutControl1;
            this._ckALLCHECK.TabIndex = 18;
            this._ckALLCHECK.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this._ckALLCHECK;
            this.layoutControlItem4.Location = new System.Drawing.Point(372, 34);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(97, 24);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(97, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(97, 24);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // ucMaterialOrderRegister_Request_T01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ucMaterialOrderRegister_Request_T01";
            this.Size = new System.Drawing.Size(873, 526);
            this.Load += new System.EventHandler(this.ucMaterialOrderRegister_Request_T01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTORDER_DATE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTVEND_CODE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ckALLCHECK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl _gdMAIN;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdMAIN_VIEW;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private CORE.BaseControls.ucSimpleButton _ucbtCANCLE;
        private CORE.BaseControls.ucSimpleButton _ucbtSELECT;
        private CORE.BaseControls.ucSimpleButton _ucbtCLEAR;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private CORE.BaseControls.ucSimpleButton _ucbtSAVE;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private CORE.BaseControls.ucFromToDateEdit _luTORDER_DATE;
        private DevExpress.XtraLayout.LayoutControlItem _lciTORDER_DATE;
        private CORE.BaseControls.ucSearchEdit _luTVEND_CODE;
        private DevExpress.XtraLayout.LayoutControlItem _lciTVEND_CODE;
        private DevExpress.XtraGrid.GridControl _gdSUB;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdSUB_VIEW;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.CheckEdit _ckALLCHECK;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}

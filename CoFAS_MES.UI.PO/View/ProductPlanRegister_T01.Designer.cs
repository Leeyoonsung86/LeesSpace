namespace CoFAS_MES.UI.PO
{
    partial class ProductPlanRegister_T01
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
            this.layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
            this._gdMAIN = new DevExpress.XtraGrid.GridControl();
            this._gdMAIN_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this._luTCONTRACT_ID = new CoFAS_MES.CORE.BaseControls.ucButtonEdit();
            this._luTUSE_YN = new CoFAS_MES.CORE.BaseControls.ucLookUpEdit();
            this._luTPRODUCT_PLAN_DATE = new CoFAS_MES.CORE.BaseControls.ucFromToDateEdit();
            this._luTPART = new CoFAS_MES.CORE.BaseControls.ucSearchEdit();
            this._luTPLAN_ID = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
            this._lciTPRODUCT_PLAN_DATE = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this._lciTPART_NAME = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciTUSE_YN = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this._lciTCONTRACT_ID = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciTPLAN_ID = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this._pnHeader)).BeginInit();
            this._pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pnContent)).BeginInit();
            this._pnContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pnLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pnRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).BeginInit();
            this.layoutControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTPRODUCT_PLAN_DATE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTPART_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTUSE_YN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTCONTRACT_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTPLAN_ID)).BeginInit();
            this.SuspendLayout();
            // 
            // _pnHeader
            // 
            this._pnHeader.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnHeader.Appearance.Options.UseBackColor = true;
            this._pnHeader.Controls.Add(this.layoutControl1);
            this._pnHeader.Size = new System.Drawing.Size(1400, 95);
            // 
            // _pnContent
            // 
            this._pnContent.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnContent.Appearance.Options.UseBackColor = true;
            this._pnContent.Controls.Add(this.layoutControl3);
            this._pnContent.Location = new System.Drawing.Point(5, 95);
            this._pnContent.Size = new System.Drawing.Size(1390, 625);
            // 
            // _pnLeft
            // 
            this._pnLeft.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnLeft.Appearance.Options.UseBackColor = true;
            this._pnLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnLeft.Location = new System.Drawing.Point(0, 95);
            this._pnLeft.Size = new System.Drawing.Size(1400, 625);
            // 
            // _pnRight
            // 
            this._pnRight.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnRight.Appearance.Options.UseBackColor = true;
            this._pnRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnRight.Location = new System.Drawing.Point(5, 95);
            this._pnRight.Size = new System.Drawing.Size(1395, 625);
            // 
            // layoutControl3
            // 
            this.layoutControl3.Controls.Add(this._gdMAIN);
            this.layoutControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl3.Location = new System.Drawing.Point(0, 0);
            this.layoutControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl3.Name = "layoutControl3";
            this.layoutControl3.Root = this.layoutControlGroup3;
            this.layoutControl3.Size = new System.Drawing.Size(1390, 625);
            this.layoutControl3.TabIndex = 2;
            this.layoutControl3.Text = "layoutControl3";
            // 
            // _gdMAIN
            // 
            this._gdMAIN.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gdMAIN.Location = new System.Drawing.Point(24, 24);
            this._gdMAIN.MainView = this._gdMAIN_VIEW;
            this._gdMAIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gdMAIN.Name = "_gdMAIN";
            this._gdMAIN.Size = new System.Drawing.Size(1342, 577);
            this._gdMAIN.TabIndex = 4;
            this._gdMAIN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gdMAIN_VIEW,
            this.gridView1});
            // 
            // _gdMAIN_VIEW
            // 
            this._gdMAIN_VIEW.GridControl = this._gdMAIN;
            this._gdMAIN_VIEW.Name = "_gdMAIN_VIEW";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this._gdMAIN;
            this.gridView1.Name = "gridView1";
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup3.GroupBordersVisible = false;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup5});
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup3.Size = new System.Drawing.Size(1390, 625);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup5.Name = "layoutControlGroup5";
            this.layoutControlGroup5.Size = new System.Drawing.Size(1370, 605);
            this.layoutControlGroup5.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this._gdMAIN;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1346, 581);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._luTCONTRACT_ID);
            this.layoutControl1.Controls.Add(this._luTUSE_YN);
            this.layoutControl1.Controls.Add(this._luTPRODUCT_PLAN_DATE);
            this.layoutControl1.Controls.Add(this._luTPART);
            this.layoutControl1.Controls.Add(this._luTPLAN_ID);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1400, 95);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _luTCONTRACT_ID
            // 
            this._luTCONTRACT_ID.BackColor = System.Drawing.SystemColors.Control;
            this._luTCONTRACT_ID.Location = new System.Drawing.Point(187, 50);
            this._luTCONTRACT_ID.Margin = new System.Windows.Forms.Padding(0);
            this._luTCONTRACT_ID.Name = "_luTCONTRACT_ID";
            this._luTCONTRACT_ID.ReadOnly = false;
            this._luTCONTRACT_ID.Size = new System.Drawing.Size(217, 21);
            this._luTCONTRACT_ID.TabIndex = 13;
            this._luTCONTRACT_ID._OnButtonPressed += new CoFAS_MES.CORE.BaseControls.ucButtonEdit.OnButtonPressedEventHandler(this._luTCONTRACT_ID__OnButtonPressed);
            // 
            // _luTUSE_YN
            // 
            this._luTUSE_YN.ItemIndex = -1;
            this._luTUSE_YN.Location = new System.Drawing.Point(963, 24);
            this._luTUSE_YN.Margin = new System.Windows.Forms.Padding(0);
            this._luTUSE_YN.Name = "_luTUSE_YN";
            this._luTUSE_YN.ReadOnly = false;
            this._luTUSE_YN.Size = new System.Drawing.Size(100, 22);
            this._luTUSE_YN.TabIndex = 12;
            // 
            // _luTPRODUCT_PLAN_DATE
            // 
            this._luTPRODUCT_PLAN_DATE.FromDateTime = new System.DateTime(2018, 4, 1, 0, 0, 0, 0);
            this._luTPRODUCT_PLAN_DATE.Location = new System.Drawing.Point(187, 24);
            this._luTPRODUCT_PLAN_DATE.Margin = new System.Windows.Forms.Padding(0);
            this._luTPRODUCT_PLAN_DATE.Name = "_luTPRODUCT_PLAN_DATE";
            this._luTPRODUCT_PLAN_DATE.Size = new System.Drawing.Size(217, 22);
            this._luTPRODUCT_PLAN_DATE.TabIndex = 4;
            this._luTPRODUCT_PLAN_DATE.ToDateTime = new System.DateTime(2018, 4, 26, 23, 59, 59, 0);
            // 
            // _luTPART
            // 
            this._luTPART.BackColor = System.Drawing.Color.Transparent;
            this._luTPART.CodeReadOnly = false;
            this._luTPART.CodeText = "";
            this._luTPART.CodeTextName = "_luTPART_CODE";
            this._luTPART.Location = new System.Drawing.Point(565, 24);
            this._luTPART.Name = "_luTPART";
            this._luTPART.NameEnabled = true;
            this._luTPART.NameReadOnly = false;
            this._luTPART.NameText = "";
            this._luTPART.NameTextName = "_luTPART_NAME";
            this._luTPART.Size = new System.Drawing.Size(237, 22);
            this._luTPART.TabIndex = 10;
            this._luTPART._OnButtonPressed += new CoFAS_MES.CORE.BaseControls.ucSearchEdit.OnButtonPressedEventHandler(this._luTPART__OnButtonPressed);
            // 
            // _luTPLAN_ID
            // 
            this._luTPLAN_ID.CancelButton = null;
            this._luTPLAN_ID.CommandButton = null;
            this._luTPLAN_ID.EditMask = "";
            this._luTPLAN_ID.Location = new System.Drawing.Point(565, 50);
            this._luTPLAN_ID.Margin = new System.Windows.Forms.Padding(0);
            this._luTPLAN_ID.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luTPLAN_ID.Name = "_luTPLAN_ID";
            this._luTPLAN_ID.PasswordChar = '\0';
            this._luTPLAN_ID.ReadOnly = false;
            this._luTPLAN_ID.Size = new System.Drawing.Size(237, 21);
            this._luTPLAN_ID.TabIndex = 11;
            this._luTPLAN_ID.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luTPLAN_ID.UseMaskAsDisplayFormat = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup6});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(16, 16, 10, 10);
            this.layoutControlGroup1.Size = new System.Drawing.Size(1400, 95);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup6
            // 
            this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this._lciTPRODUCT_PLAN_DATE,
            this.emptySpaceItem2,
            this._lciTPART_NAME,
            this._lciTUSE_YN,
            this.emptySpaceItem6,
            this._lciTCONTRACT_ID,
            this._lciTPLAN_ID});
            this.layoutControlGroup6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup6.Name = "layoutControlGroup6";
            this.layoutControlGroup6.Size = new System.Drawing.Size(1368, 75);
            this.layoutControlGroup6.TextVisible = false;
            // 
            // _lciTPRODUCT_PLAN_DATE
            // 
            this._lciTPRODUCT_PLAN_DATE.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciTPRODUCT_PLAN_DATE.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciTPRODUCT_PLAN_DATE.Control = this._luTPRODUCT_PLAN_DATE;
            this._lciTPRODUCT_PLAN_DATE.Location = new System.Drawing.Point(0, 0);
            this._lciTPRODUCT_PLAN_DATE.MaxSize = new System.Drawing.Size(378, 26);
            this._lciTPRODUCT_PLAN_DATE.MinSize = new System.Drawing.Size(378, 26);
            this._lciTPRODUCT_PLAN_DATE.Name = "_lciTPRODUCT_PLAN_DATE";
            this._lciTPRODUCT_PLAN_DATE.Size = new System.Drawing.Size(378, 26);
            this._lciTPRODUCT_PLAN_DATE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciTPRODUCT_PLAN_DATE.TextSize = new System.Drawing.Size(153, 14);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(1037, 0);
            this.emptySpaceItem2.MaxSize = new System.Drawing.Size(307, 51);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(307, 51);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(307, 51);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // _lciTPART_NAME
            // 
            this._lciTPART_NAME.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciTPART_NAME.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciTPART_NAME.Control = this._luTPART;
            this._lciTPART_NAME.CustomizationFormText = "_lciTPART_NAME";
            this._lciTPART_NAME.Location = new System.Drawing.Point(378, 0);
            this._lciTPART_NAME.MaxSize = new System.Drawing.Size(398, 26);
            this._lciTPART_NAME.MinSize = new System.Drawing.Size(398, 26);
            this._lciTPART_NAME.Name = "_lciTPART_NAME";
            this._lciTPART_NAME.Size = new System.Drawing.Size(398, 26);
            this._lciTPART_NAME.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciTPART_NAME.TextSize = new System.Drawing.Size(153, 14);
            // 
            // _lciTUSE_YN
            // 
            this._lciTUSE_YN.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciTUSE_YN.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciTUSE_YN.Control = this._luTUSE_YN;
            this._lciTUSE_YN.Location = new System.Drawing.Point(776, 0);
            this._lciTUSE_YN.MaxSize = new System.Drawing.Size(261, 26);
            this._lciTUSE_YN.MinSize = new System.Drawing.Size(261, 26);
            this._lciTUSE_YN.Name = "_lciTUSE_YN";
            this._lciTUSE_YN.Size = new System.Drawing.Size(261, 26);
            this._lciTUSE_YN.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciTUSE_YN.TextSize = new System.Drawing.Size(153, 14);
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(776, 26);
            this.emptySpaceItem6.MaxSize = new System.Drawing.Size(261, 25);
            this.emptySpaceItem6.MinSize = new System.Drawing.Size(261, 25);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(261, 25);
            this.emptySpaceItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // _lciTCONTRACT_ID
            // 
            this._lciTCONTRACT_ID.Control = this._luTCONTRACT_ID;
            this._lciTCONTRACT_ID.Location = new System.Drawing.Point(0, 26);
            this._lciTCONTRACT_ID.MaxSize = new System.Drawing.Size(378, 25);
            this._lciTCONTRACT_ID.MinSize = new System.Drawing.Size(378, 25);
            this._lciTCONTRACT_ID.Name = "_lciTCONTRACT_ID";
            this._lciTCONTRACT_ID.Size = new System.Drawing.Size(378, 25);
            this._lciTCONTRACT_ID.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciTCONTRACT_ID.TextSize = new System.Drawing.Size(153, 14);
            // 
            // _lciTPLAN_ID
            // 
            this._lciTPLAN_ID.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciTPLAN_ID.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciTPLAN_ID.Control = this._luTPLAN_ID;
            this._lciTPLAN_ID.CustomizationFormText = "_lciTPLAN_ID";
            this._lciTPLAN_ID.Location = new System.Drawing.Point(378, 26);
            this._lciTPLAN_ID.MinSize = new System.Drawing.Size(261, 24);
            this._lciTPLAN_ID.Name = "_lciTPLAN_ID";
            this._lciTPLAN_ID.Size = new System.Drawing.Size(398, 25);
            this._lciTPLAN_ID.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciTPLAN_ID.TextSize = new System.Drawing.Size(153, 14);
            // 
            // ProductPlanRegister_T01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 720);
            this.Name = "ProductPlanRegister_T01";
            this.Text = "ProductPlanRegister_T01";
            this.WindowName = "ProductPlanRegister_T01";
            ((System.ComponentModel.ISupportInitialize)(this._pnHeader)).EndInit();
            this._pnHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pnContent)).EndInit();
            this._pnContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pnLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pnRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).EndInit();
            this.layoutControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTPRODUCT_PLAN_DATE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTPART_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTUSE_YN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTCONTRACT_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciTPLAN_ID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControl layoutControl3;
        private DevExpress.XtraGrid.GridControl _gdMAIN;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdMAIN_VIEW;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private CORE.BaseControls.ucLookUpEdit _luTUSE_YN;
        private CORE.BaseControls.ucFromToDateEdit _luTPRODUCT_PLAN_DATE;
        private CORE.BaseControls.ucSearchEdit _luTPART;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup6;
        private DevExpress.XtraLayout.LayoutControlItem _lciTPRODUCT_PLAN_DATE;
        private DevExpress.XtraLayout.LayoutControlItem _lciTUSE_YN;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem _lciTPART_NAME;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private CORE.BaseControls.ucButtonEdit _luTCONTRACT_ID;
        private DevExpress.XtraLayout.LayoutControlItem _lciTCONTRACT_ID;
        private CORE.BaseControls.ucTextEdit _luTPLAN_ID;
        private DevExpress.XtraLayout.LayoutControlItem _lciTPLAN_ID;
    }
}
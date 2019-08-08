namespace CoFAS_MES.UI.MM
{
    partial class MaterialOrderStatus_T02
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
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this._luTVEND = new CoFAS_MES.CORE.BaseControls.ucSearchEdit();
            this._luTPART = new CoFAS_MES.CORE.BaseControls.ucSearchEdit();
            this._luTORDER_ID = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luTORDER_DATE = new CoFAS_MES.CORE.BaseControls.ucFromToDateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this._lciORDER_DATE = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciORDER_ID = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this._lciPART = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciVEND = new DevExpress.XtraLayout.LayoutControlItem();
            this._gdMAIN = new DevExpress.XtraGrid.GridControl();
            this._gdMAIN_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this._pnHeader)).BeginInit();
            this._pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pnContent)).BeginInit();
            this._pnContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pnLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pnRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciORDER_DATE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciORDER_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPART)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciVEND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // _pnHeader
            // 
            this._pnHeader.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnHeader.Appearance.Options.UseBackColor = true;
            this._pnHeader.Controls.Add(this.layoutControl1);
            this._pnHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._pnHeader.Size = new System.Drawing.Size(1200, 95);
            // 
            // _pnContent
            // 
            this._pnContent.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnContent.Appearance.Options.UseBackColor = true;
            this._pnContent.Controls.Add(this.layoutControl2);
            this._pnContent.Location = new System.Drawing.Point(15, 95);
            this._pnContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._pnContent.Size = new System.Drawing.Size(1180, 605);
            // 
            // _pnLeft
            // 
            this._pnLeft.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnLeft.Appearance.Options.UseBackColor = true;
            this._pnLeft.Location = new System.Drawing.Point(0, 95);
            this._pnLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._pnLeft.Size = new System.Drawing.Size(10, 605);
            this._pnLeft.Visible = false;
            // 
            // _pnRight
            // 
            this._pnRight.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnRight.Appearance.Options.UseBackColor = true;
            this._pnRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnRight.Location = new System.Drawing.Point(15, 95);
            this._pnRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._pnRight.Size = new System.Drawing.Size(1185, 605);
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this._gdMAIN);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(1180, 605);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup2.Size = new System.Drawing.Size(1180, 605);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._luTVEND);
            this.layoutControl1.Controls.Add(this._luTPART);
            this.layoutControl1.Controls.Add(this._luTORDER_ID);
            this.layoutControl1.Controls.Add(this._luTORDER_DATE);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1200, 95);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _luTVEND
            // 
            this._luTVEND.BackColor = System.Drawing.Color.Transparent;
            this._luTVEND.CodeReadOnly = false;
            this._luTVEND.CodeText = "";
            this._luTVEND.CodeTextName = "_pCodeTextEdit";
            this._luTVEND.Location = new System.Drawing.Point(504, 24);
            this._luTVEND.Name = "_luTVEND";
            this._luTVEND.NameEnabled = true;
            this._luTVEND.NameReadOnly = false;
            this._luTVEND.NameText = "";
            this._luTVEND.NameTextName = "_pNameButtonEdit";
            this._luTVEND.Size = new System.Drawing.Size(270, 22);
            this._luTVEND.TabIndex = 9;
            this._luTVEND._OnOpenClick += new CoFAS_MES.CORE.BaseControls.ucSearchEdit.OnOpenClickEventHandler(this._luTVEND__OnOpenClick);
            // 
            // _luTPART
            // 
            this._luTPART.BackColor = System.Drawing.Color.Transparent;
            this._luTPART.CodeReadOnly = false;
            this._luTPART.CodeText = "";
            this._luTPART.CodeTextName = "_pCodeTextEdit";
            this._luTPART.Location = new System.Drawing.Point(504, 50);
            this._luTPART.Name = "_luTPART";
            this._luTPART.NameEnabled = true;
            this._luTPART.NameReadOnly = false;
            this._luTPART.NameText = "";
            this._luTPART.NameTextName = "_pNameButtonEdit";
            this._luTPART.Size = new System.Drawing.Size(270, 21);
            this._luTPART.TabIndex = 8;
            this._luTPART._OnOpenClick += new CoFAS_MES.CORE.BaseControls.ucSearchEdit.OnOpenClickEventHandler(this._luTPART__OnOpenClick);
            // 
            // _luTORDER_ID
            // 
            this._luTORDER_ID.CancelButton = null;
            this._luTORDER_ID.CommandButton = null;
            this._luTORDER_ID.EditMask = "";
            this._luTORDER_ID.Location = new System.Drawing.Point(126, 50);
            this._luTORDER_ID.Margin = new System.Windows.Forms.Padding(0);
            this._luTORDER_ID.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luTORDER_ID.Name = "_luTORDER_ID";
            this._luTORDER_ID.NumText = "";
            this._luTORDER_ID.PasswordChar = '\0';
            this._luTORDER_ID.ReadOnly = false;
            this._luTORDER_ID.Size = new System.Drawing.Size(277, 21);
            this._luTORDER_ID.TabIndex = 7;
            this._luTORDER_ID.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luTORDER_ID.UseMaskAsDisplayFormat = false;
            // 
            // _luTORDER_DATE
            // 
            this._luTORDER_DATE.FromDateTime = new System.DateTime(2018, 4, 1, 0, 0, 0, 0);
            this._luTORDER_DATE.Location = new System.Drawing.Point(126, 24);
            this._luTORDER_DATE.Margin = new System.Windows.Forms.Padding(0);
            this._luTORDER_DATE.Name = "_luTORDER_DATE";
            this._luTORDER_DATE.Size = new System.Drawing.Size(277, 22);
            this._luTORDER_DATE.TabIndex = 4;
            this._luTORDER_DATE.ToDateTime = new System.DateTime(2018, 4, 25, 23, 59, 59, 0);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(15, 15, 10, 10);
            this.layoutControlGroup1.Size = new System.Drawing.Size(1200, 95);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this._lciORDER_DATE,
            this._lciORDER_ID,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this._lciPART,
            this._lciVEND});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup3.Size = new System.Drawing.Size(1170, 75);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // _lciORDER_DATE
            // 
            this._lciORDER_DATE.Control = this._luTORDER_DATE;
            this._lciORDER_DATE.Location = new System.Drawing.Point(0, 0);
            this._lciORDER_DATE.MaxSize = new System.Drawing.Size(378, 26);
            this._lciORDER_DATE.MinSize = new System.Drawing.Size(378, 26);
            this._lciORDER_DATE.Name = "_lciORDER_DATE";
            this._lciORDER_DATE.Size = new System.Drawing.Size(378, 26);
            this._lciORDER_DATE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciORDER_DATE.TextSize = new System.Drawing.Size(93, 14);
            // 
            // _lciORDER_ID
            // 
            this._lciORDER_ID.Control = this._luTORDER_ID;
            this._lciORDER_ID.Location = new System.Drawing.Point(0, 26);
            this._lciORDER_ID.MaxSize = new System.Drawing.Size(378, 25);
            this._lciORDER_ID.MinSize = new System.Drawing.Size(378, 25);
            this._lciORDER_ID.Name = "_lciORDER_ID";
            this._lciORDER_ID.Size = new System.Drawing.Size(378, 25);
            this._lciORDER_ID.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciORDER_ID.TextSize = new System.Drawing.Size(93, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(749, 0);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(387, 26);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(387, 26);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(397, 26);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem2.Location = new System.Drawing.Point(749, 26);
            this.emptySpaceItem2.MaxSize = new System.Drawing.Size(387, 25);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(387, 25);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(397, 25);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem2.Text = "emptySpaceItem1";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // _lciPART
            // 
            this._lciPART.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciPART.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciPART.Control = this._luTPART;
            this._lciPART.Location = new System.Drawing.Point(378, 26);
            this._lciPART.MaxSize = new System.Drawing.Size(371, 25);
            this._lciPART.MinSize = new System.Drawing.Size(371, 25);
            this._lciPART.Name = "_lciPART";
            this._lciPART.Size = new System.Drawing.Size(371, 25);
            this._lciPART.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciPART.TextSize = new System.Drawing.Size(93, 14);
            // 
            // _lciVEND
            // 
            this._lciVEND.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciVEND.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciVEND.Control = this._luTVEND;
            this._lciVEND.Location = new System.Drawing.Point(378, 0);
            this._lciVEND.MaxSize = new System.Drawing.Size(371, 26);
            this._lciVEND.MinSize = new System.Drawing.Size(371, 26);
            this._lciVEND.Name = "_lciVEND";
            this._lciVEND.Size = new System.Drawing.Size(371, 26);
            this._lciVEND.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciVEND.TextSize = new System.Drawing.Size(93, 14);
            // 
            // _gdMAIN
            // 
            this._gdMAIN.Location = new System.Drawing.Point(12, 12);
            this._gdMAIN.MainView = this._gdMAIN_VIEW;
            this._gdMAIN.Name = "_gdMAIN";
            this._gdMAIN.Size = new System.Drawing.Size(1156, 581);
            this._gdMAIN.TabIndex = 4;
            this._gdMAIN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gdMAIN_VIEW});
            // 
            // _gdMAIN_VIEW
            // 
            this._gdMAIN_VIEW.GridControl = this._gdMAIN;
            this._gdMAIN_VIEW.Name = "_gdMAIN_VIEW";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this._gdMAIN;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1160, 585);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // MaterialOrderStatus_T02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MaterialOrderStatus_T02";
            this.Text = "MaterialOrderStatus";
            this.WindowName = "MaterialOrderStatus";
            ((System.ComponentModel.ISupportInitialize)(this._pnHeader)).EndInit();
            this._pnHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pnContent)).EndInit();
            this._pnContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pnLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pnRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciORDER_DATE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciORDER_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPART)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciVEND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private CORE.BaseControls.ucTextEdit _luTORDER_ID;
        private CORE.BaseControls.ucFromToDateEdit _luTORDER_DATE;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem _lciORDER_DATE;
        private DevExpress.XtraLayout.LayoutControlItem _lciORDER_ID;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private CORE.BaseControls.ucSearchEdit _luTVEND;
        private CORE.BaseControls.ucSearchEdit _luTPART;
        private DevExpress.XtraLayout.LayoutControlItem _lciPART;
        private DevExpress.XtraLayout.LayoutControlItem _lciVEND;
        private DevExpress.XtraGrid.GridControl _gdMAIN;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdMAIN_VIEW;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}
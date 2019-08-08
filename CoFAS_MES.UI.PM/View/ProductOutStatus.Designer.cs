namespace CoFAS_MES.UI.PM
{
    partial class ProductOutStatus
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
            this._luPART_CODE = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luVEND_NAME = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luPART_NAME = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luORDER_DATE = new CoFAS_MES.CORE.BaseControls.ucFromToDateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this._lciORDER_DATE = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciPART_NAME = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciVEND_NAME = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciPART_CODE = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this._gdMAIN = new DevExpress.XtraGrid.GridControl();
            this._gdMAIN_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this._pnHeader)).BeginInit();
            this._pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pnContent)).BeginInit();
            this._pnContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pnLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pnRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciORDER_DATE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPART_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciVEND_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPART_CODE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // _pnHeader
            // 
            this._pnHeader.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnHeader.Appearance.Options.UseBackColor = true;
            this._pnHeader.Controls.Add(this.layoutControl1);
            this._pnHeader.Size = new System.Drawing.Size(1200, 86);
            // 
            // _pnContent
            // 
            this._pnContent.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnContent.Appearance.Options.UseBackColor = true;
            this._pnContent.Controls.Add(this.layoutControl2);
            this._pnContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._pnContent.Size = new System.Drawing.Size(990, 614);
            // 
            // _pnLeft
            // 
            this._pnLeft.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnLeft.Appearance.Options.UseBackColor = true;
            this._pnLeft.Size = new System.Drawing.Size(200, 614);
            this._pnLeft.Visible = false;
            // 
            // _pnRight
            // 
            this._pnRight.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnRight.Appearance.Options.UseBackColor = true;
            this._pnRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnRight.Location = new System.Drawing.Point(205, 86);
            this._pnRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._pnRight.Size = new System.Drawing.Size(995, 614);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._luPART_CODE);
            this.layoutControl1.Controls.Add(this._luVEND_NAME);
            this.layoutControl1.Controls.Add(this._luPART_NAME);
            this.layoutControl1.Controls.Add(this._luORDER_DATE);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1200, 86);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _luPART_CODE
            // 
            this._luPART_CODE.CancelButton = null;
            this._luPART_CODE.CommandButton = null;
            this._luPART_CODE.EditMask = "";
            this._luPART_CODE.Location = new System.Drawing.Point(109, 36);
            this._luPART_CODE.Margin = new System.Windows.Forms.Padding(0);
            this._luPART_CODE.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luPART_CODE.Name = "_luPART_CODE";
            this._luPART_CODE.PasswordChar = '\0';
            this._luPART_CODE.ReadOnly = false;
            this._luPART_CODE.Size = new System.Drawing.Size(286, 20);
            this._luPART_CODE.TabIndex = 7;
            this._luPART_CODE.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luPART_CODE.UseMaskAsDisplayFormat = false;
            // 
            // _luVEND_NAME
            // 
            this._luVEND_NAME.CancelButton = null;
            this._luVEND_NAME.CommandButton = null;
            this._luVEND_NAME.EditMask = "";
            this._luVEND_NAME.Location = new System.Drawing.Point(109, 84);
            this._luVEND_NAME.Margin = new System.Windows.Forms.Padding(0);
            this._luVEND_NAME.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luVEND_NAME.Name = "_luVEND_NAME";
            this._luVEND_NAME.PasswordChar = '\0';
            this._luVEND_NAME.ReadOnly = false;
            this._luVEND_NAME.Size = new System.Drawing.Size(286, 20);
            this._luVEND_NAME.TabIndex = 6;
            this._luVEND_NAME.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luVEND_NAME.UseMaskAsDisplayFormat = false;
            // 
            // _luPART_NAME
            // 
            this._luPART_NAME.CancelButton = null;
            this._luPART_NAME.CommandButton = null;
            this._luPART_NAME.EditMask = "";
            this._luPART_NAME.Location = new System.Drawing.Point(109, 60);
            this._luPART_NAME.Margin = new System.Windows.Forms.Padding(0);
            this._luPART_NAME.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luPART_NAME.Name = "_luPART_NAME";
            this._luPART_NAME.PasswordChar = '\0';
            this._luPART_NAME.ReadOnly = false;
            this._luPART_NAME.Size = new System.Drawing.Size(286, 20);
            this._luPART_NAME.TabIndex = 5;
            this._luPART_NAME.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luPART_NAME.UseMaskAsDisplayFormat = false;
            // 
            // _luORDER_DATE
            // 
            this._luORDER_DATE.FromDateTime = new System.DateTime(2018, 4, 1, 0, 0, 0, 0);
            this._luORDER_DATE.Location = new System.Drawing.Point(109, 12);
            this._luORDER_DATE.Margin = new System.Windows.Forms.Padding(0);
            this._luORDER_DATE.Name = "_luORDER_DATE";
            this._luORDER_DATE.Size = new System.Drawing.Size(286, 20);
            this._luORDER_DATE.TabIndex = 4;
            this._luORDER_DATE.ToDateTime = new System.DateTime(2018, 4, 25, 17, 49, 5, 441);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this._lciORDER_DATE,
            this._lciPART_NAME,
            this._lciVEND_NAME,
            this._lciPART_CODE,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(1183, 116);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // _lciORDER_DATE
            // 
            this._lciORDER_DATE.Control = this._luORDER_DATE;
            this._lciORDER_DATE.Location = new System.Drawing.Point(0, 0);
            this._lciORDER_DATE.Name = "_lciORDER_DATE";
            this._lciORDER_DATE.Size = new System.Drawing.Size(387, 24);
            this._lciORDER_DATE.TextSize = new System.Drawing.Size(93, 14);
            // 
            // _lciPART_NAME
            // 
            this._lciPART_NAME.Control = this._luPART_NAME;
            this._lciPART_NAME.Location = new System.Drawing.Point(0, 48);
            this._lciPART_NAME.Name = "_lciPART_NAME";
            this._lciPART_NAME.Size = new System.Drawing.Size(387, 24);
            this._lciPART_NAME.TextSize = new System.Drawing.Size(93, 14);
            // 
            // _lciVEND_NAME
            // 
            this._lciVEND_NAME.Control = this._luVEND_NAME;
            this._lciVEND_NAME.Location = new System.Drawing.Point(0, 72);
            this._lciVEND_NAME.Name = "_lciVEND_NAME";
            this._lciVEND_NAME.Size = new System.Drawing.Size(387, 24);
            this._lciVEND_NAME.TextSize = new System.Drawing.Size(93, 14);
            // 
            // _lciPART_CODE
            // 
            this._lciPART_CODE.Control = this._luPART_CODE;
            this._lciPART_CODE.Location = new System.Drawing.Point(0, 24);
            this._lciPART_CODE.Name = "_lciPART_CODE";
            this._lciPART_CODE.Size = new System.Drawing.Size(387, 24);
            this._lciPART_CODE.TextSize = new System.Drawing.Size(93, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(387, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(776, 96);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this._gdMAIN);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(990, 614);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // _gdMAIN
            // 
            this._gdMAIN.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gdMAIN.Location = new System.Drawing.Point(12, 12);
            this._gdMAIN.MainView = this._gdMAIN_VIEW;
            this._gdMAIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gdMAIN.Name = "_gdMAIN";
            this._gdMAIN.Size = new System.Drawing.Size(966, 590);
            this._gdMAIN.TabIndex = 4;
            this._gdMAIN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gdMAIN_VIEW});
            // 
            // _gdMAIN_VIEW
            // 
            this._gdMAIN_VIEW.GridControl = this._gdMAIN;
            this._gdMAIN_VIEW.Name = "_gdMAIN_VIEW";
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5});
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup2.Size = new System.Drawing.Size(990, 614);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this._gdMAIN;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(970, 594);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // ProductOutStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProductOutStatus";
            this.Text = "MaterialOrderStatus";
            this.WindowName = "MaterialOrderStatus";
            ((System.ComponentModel.ISupportInitialize)(this._pnHeader)).EndInit();
            this._pnHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pnContent)).EndInit();
            this._pnContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pnLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pnRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciORDER_DATE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPART_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciVEND_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPART_CODE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private CORE.BaseControls.ucFromToDateEdit _luORDER_DATE;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem _lciORDER_DATE;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private CORE.BaseControls.ucTextEdit _luPART_NAME;
        private DevExpress.XtraLayout.LayoutControlItem _lciPART_NAME;
        private CORE.BaseControls.ucTextEdit _luVEND_NAME;
        private DevExpress.XtraLayout.LayoutControlItem _lciVEND_NAME;
        private DevExpress.XtraGrid.GridControl _gdMAIN;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdMAIN_VIEW;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private CORE.BaseControls.ucTextEdit _luPART_CODE;
        private DevExpress.XtraLayout.LayoutControlItem _lciPART_CODE;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}
namespace CoFAS_MES.POP
{
    partial class frmGatherSetting
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this._lbSettingHeader = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this._btSettingSearch = new DevExpress.XtraEditors.SimpleButton();
            this._btSettingSave = new DevExpress.XtraEditors.SimpleButton();
            this._btSettingExit = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this._gdMAIN = new DevExpress.XtraGrid.GridControl();
            this._gdMAIN_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._txtSettingFTPSERVERIP = new DevExpress.XtraEditors.TextEdit();
            this._seSettingFont_Size = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this._lciSettingFTPSERVERIP = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciSettingFontSize = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtSettingFTPSERVERIP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._seSettingFont_Size.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciSettingFTPSERVERIP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciSettingFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this._lbSettingHeader);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(600, 20);
            this.panelControl1.TabIndex = 0;
            // 
            // _lbSettingHeader
            // 
            this._lbSettingHeader.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this._lbSettingHeader.Appearance.ForeColor = System.Drawing.Color.White;
            this._lbSettingHeader.Appearance.Image = global::CoFAS_MES.POP.Properties.Resources.version_16x16;
            this._lbSettingHeader.Appearance.Options.UseFont = true;
            this._lbSettingHeader.Appearance.Options.UseForeColor = true;
            this._lbSettingHeader.Appearance.Options.UseImage = true;
            this._lbSettingHeader.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this._lbSettingHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbSettingHeader.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this._lbSettingHeader.Location = new System.Drawing.Point(0, 0);
            this._lbSettingHeader.Margin = new System.Windows.Forms.Padding(0);
            this._lbSettingHeader.Name = "_lbSettingHeader";
            this._lbSettingHeader.Padding = new System.Windows.Forms.Padding(10);
            this._lbSettingHeader.Size = new System.Drawing.Size(600, 20);
            this._lbSettingHeader.TabIndex = 0;
            this._lbSettingHeader.Text = "Gathering Setting";
            this._lbSettingHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_MouseDown);
            this._lbSettingHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_MouseMove);
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this._btSettingSearch);
            this.panelControl2.Controls.Add(this._btSettingSave);
            this.panelControl2.Controls.Add(this._btSettingExit);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 220);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(600, 30);
            this.panelControl2.TabIndex = 1;
            // 
            // _btSettingSearch
            // 
            this._btSettingSearch.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this._btSettingSearch.Appearance.Options.UseFont = true;
            this._btSettingSearch.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._btSettingSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this._btSettingSearch.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources.zoom_16x16;
            this._btSettingSearch.Location = new System.Drawing.Point(339, 0);
            this._btSettingSearch.Margin = new System.Windows.Forms.Padding(0);
            this._btSettingSearch.Name = "_btSettingSearch";
            this._btSettingSearch.Size = new System.Drawing.Size(93, 30);
            this._btSettingSearch.TabIndex = 2;
            this._btSettingSearch.Text = "Search";
            this._btSettingSearch.Click += new System.EventHandler(this._btSettingSearch_Click);
            // 
            // _btSettingSave
            // 
            this._btSettingSave.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this._btSettingSave.Appearance.Options.UseFont = true;
            this._btSettingSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._btSettingSave.Dock = System.Windows.Forms.DockStyle.Right;
            this._btSettingSave.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources.save_32x321;
            this._btSettingSave.Location = new System.Drawing.Point(432, 0);
            this._btSettingSave.Margin = new System.Windows.Forms.Padding(0);
            this._btSettingSave.Name = "_btSettingSave";
            this._btSettingSave.Size = new System.Drawing.Size(93, 30);
            this._btSettingSave.TabIndex = 0;
            this._btSettingSave.Text = "SAVE";
            this._btSettingSave.Click += new System.EventHandler(this._btSettingSave_Click);
            // 
            // _btSettingExit
            // 
            this._btSettingExit.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this._btSettingExit.Appearance.Options.UseFont = true;
            this._btSettingExit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._btSettingExit.Dock = System.Windows.Forms.DockStyle.Right;
            this._btSettingExit.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources.close_32x322;
            this._btSettingExit.Location = new System.Drawing.Point(525, 0);
            this._btSettingExit.Margin = new System.Windows.Forms.Padding(0);
            this._btSettingExit.Name = "_btSettingExit";
            this._btSettingExit.Size = new System.Drawing.Size(75, 30);
            this._btSettingExit.TabIndex = 1;
            this._btSettingExit.Text = "EXIT";
            this._btSettingExit.Click += new System.EventHandler(this._btSettingExit_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.layoutControl1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 20);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(600, 200);
            this.panelControl3.TabIndex = 2;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._gdMAIN);
            this.layoutControl1.Controls.Add(this._txtSettingFTPSERVERIP);
            this.layoutControl1.Controls.Add(this._seSettingFont_Size);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1010, 0, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(600, 200);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _gdMAIN
            // 
            this._gdMAIN.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gdMAIN.Location = new System.Drawing.Point(12, 36);
            this._gdMAIN.MainView = this._gdMAIN_VIEW;
            this._gdMAIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gdMAIN.Name = "_gdMAIN";
            this._gdMAIN.Size = new System.Drawing.Size(576, 152);
            this._gdMAIN.TabIndex = 20;
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
            // _txtSettingFTPSERVERIP
            // 
            this._txtSettingFTPSERVERIP.EditValue = "1";
            this._txtSettingFTPSERVERIP.Enabled = false;
            this._txtSettingFTPSERVERIP.Location = new System.Drawing.Point(130, 12);
            this._txtSettingFTPSERVERIP.Name = "_txtSettingFTPSERVERIP";
            this._txtSettingFTPSERVERIP.Properties.Appearance.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this._txtSettingFTPSERVERIP.Properties.Appearance.Options.UseFont = true;
            this._txtSettingFTPSERVERIP.Size = new System.Drawing.Size(57, 18);
            this._txtSettingFTPSERVERIP.StyleController = this.layoutControl1;
            this._txtSettingFTPSERVERIP.TabIndex = 19;
            // 
            // _seSettingFont_Size
            // 
            this._seSettingFont_Size.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._seSettingFont_Size.Location = new System.Drawing.Point(191, 12);
            this._seSettingFont_Size.Margin = new System.Windows.Forms.Padding(0);
            this._seSettingFont_Size.Name = "_seSettingFont_Size";
            this._seSettingFont_Size.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._seSettingFont_Size.Properties.IsFloatValue = false;
            this._seSettingFont_Size.Properties.Mask.EditMask = "N00";
            this._seSettingFont_Size.Properties.MaxValue = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this._seSettingFont_Size.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._seSettingFont_Size.Size = new System.Drawing.Size(63, 20);
            this._seSettingFont_Size.StyleController = this.layoutControl1;
            this._seSettingFont_Size.TabIndex = 18;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem2,
            this._lciSettingFTPSERVERIP,
            this._lciSettingFontSize,
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.ShowInCustomizationForm = false;
            this.layoutControlGroup1.Size = new System.Drawing.Size(600, 200);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(246, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(334, 24);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // _lciSettingFTPSERVERIP
            // 
            this._lciSettingFTPSERVERIP.AppearanceItemCaption.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this._lciSettingFTPSERVERIP.AppearanceItemCaption.Options.UseFont = true;
            this._lciSettingFTPSERVERIP.Control = this._txtSettingFTPSERVERIP;
            this._lciSettingFTPSERVERIP.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources.task_16x16;
            this._lciSettingFTPSERVERIP.Location = new System.Drawing.Point(0, 0);
            this._lciSettingFTPSERVERIP.MaxSize = new System.Drawing.Size(0, 24);
            this._lciSettingFTPSERVERIP.MinSize = new System.Drawing.Size(131, 24);
            this._lciSettingFTPSERVERIP.Name = "_lciSettingFTPSERVERIP";
            this._lciSettingFTPSERVERIP.Size = new System.Drawing.Size(179, 24);
            this._lciSettingFTPSERVERIP.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciSettingFTPSERVERIP.Text = "Average Setting";
            this._lciSettingFTPSERVERIP.TextSize = new System.Drawing.Size(115, 16);
            // 
            // _lciSettingFontSize
            // 
            this._lciSettingFontSize.Control = this._seSettingFont_Size;
            this._lciSettingFontSize.Location = new System.Drawing.Point(179, 0);
            this._lciSettingFontSize.Name = "_lciSettingFontSize";
            this._lciSettingFontSize.Size = new System.Drawing.Size(67, 24);
            this._lciSettingFontSize.TextSize = new System.Drawing.Size(0, 0);
            this._lciSettingFontSize.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this._gdMAIN;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(580, 156);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmGatherSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 250);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGatherSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSetting";
            this.Load += new System.EventHandler(this.frmGatherSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtSettingFTPSERVERIP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._seSettingFont_Size.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciSettingFTPSERVERIP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciSettingFontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton _btSettingExit;
        private DevExpress.XtraEditors.SimpleButton _btSettingSave;
        private DevExpress.XtraEditors.LabelControl _lbSettingHeader;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SpinEdit _seSettingFont_Size;
        private DevExpress.XtraLayout.LayoutControlItem _lciSettingFontSize;
        private DevExpress.XtraEditors.TextEdit _txtSettingFTPSERVERIP;
        private DevExpress.XtraLayout.LayoutControlItem _lciSettingFTPSERVERIP;
        private DevExpress.XtraEditors.SimpleButton _btSettingSearch;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraGrid.GridControl _gdMAIN;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdMAIN_VIEW;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}
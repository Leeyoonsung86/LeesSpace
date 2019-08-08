namespace CoFAS_MES.POP
{
    partial class frmPOPLogin
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
            this._lbLoginHeader = new DevExpress.XtraEditors.LabelControl();
            this._pnLoginBottm = new DevExpress.XtraEditors.PanelControl();
            this._pnLoginMain = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this._ckUserIDSave = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this._txtPassword = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._txtAccount = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._btLoginSetting = new DevExpress.XtraEditors.SimpleButton();
            this.ucPictureEdit1 = new CoFAS_MES.CORE.BaseControls.ucPictureEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciAccount = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciPassword = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this._btLoginOk = new DevExpress.XtraEditors.SimpleButton();
            this._btLoginCancel = new DevExpress.XtraEditors.SimpleButton();
            this._btLoginClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pnLoginBottm)).BeginInit();
            this._pnLoginBottm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pnLoginMain)).BeginInit();
            this._pnLoginMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._ckUserIDSave.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this._lbLoginHeader);
            this.panelControl1.Controls.Add(this._btLoginClose);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(575, 20);
            this.panelControl1.TabIndex = 0;
            // 
            // _lbLoginHeader
            // 
            this._lbLoginHeader.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this._lbLoginHeader.Appearance.ForeColor = System.Drawing.Color.White;
            this._lbLoginHeader.Appearance.Image = global::CoFAS_MES.POP.Properties.Resources.folderpanel_16x16;
            this._lbLoginHeader.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._lbLoginHeader.Appearance.Options.UseFont = true;
            this._lbLoginHeader.Appearance.Options.UseForeColor = true;
            this._lbLoginHeader.Appearance.Options.UseImage = true;
            this._lbLoginHeader.Appearance.Options.UseImageAlign = true;
            this._lbLoginHeader.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this._lbLoginHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbLoginHeader.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this._lbLoginHeader.Location = new System.Drawing.Point(0, 0);
            this._lbLoginHeader.Margin = new System.Windows.Forms.Padding(0);
            this._lbLoginHeader.Name = "_lbLoginHeader";
            this._lbLoginHeader.Padding = new System.Windows.Forms.Padding(10);
            this._lbLoginHeader.Size = new System.Drawing.Size(555, 20);
            this._lbLoginHeader.TabIndex = 1;
            this._lbLoginHeader.Text = "POP System Login";
            this._lbLoginHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_Moving);
            // 
            // _pnLoginBottm
            // 
            this._pnLoginBottm.Appearance.BackColor = System.Drawing.Color.White;
            this._pnLoginBottm.Appearance.Options.UseBackColor = true;
            this._pnLoginBottm.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._pnLoginBottm.Controls.Add(this._btLoginOk);
            this._pnLoginBottm.Controls.Add(this._btLoginCancel);
            this._pnLoginBottm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._pnLoginBottm.Location = new System.Drawing.Point(0, 210);
            this._pnLoginBottm.Margin = new System.Windows.Forms.Padding(0);
            this._pnLoginBottm.Name = "_pnLoginBottm";
            this._pnLoginBottm.Size = new System.Drawing.Size(575, 40);
            this._pnLoginBottm.TabIndex = 1;
            // 
            // _pnLoginMain
            // 
            this._pnLoginMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._pnLoginMain.Controls.Add(this.layoutControl1);
            this._pnLoginMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnLoginMain.Location = new System.Drawing.Point(0, 20);
            this._pnLoginMain.Margin = new System.Windows.Forms.Padding(0);
            this._pnLoginMain.Name = "_pnLoginMain";
            this._pnLoginMain.Size = new System.Drawing.Size(575, 190);
            this._pnLoginMain.TabIndex = 2;
            // 
            // layoutControl1
            // 
            this.layoutControl1.BackColor = System.Drawing.Color.White;
            this.layoutControl1.Controls.Add(this._btLoginSetting);
            this.layoutControl1.Controls.Add(this.ucPictureEdit1);
            this.layoutControl1.Controls.Add(this._txtPassword);
            this.layoutControl1.Controls.Add(this._txtAccount);
            this.layoutControl1.Controls.Add(this._ckUserIDSave);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1062, 512, 812, 500);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(575, 190);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _ckUserIDSave
            // 
            this._ckUserIDSave.EditValue = "Y";
            this._ckUserIDSave.Location = new System.Drawing.Point(428, 156);
            this._ckUserIDSave.Margin = new System.Windows.Forms.Padding(0);
            this._ckUserIDSave.Name = "_ckUserIDSave";
            this._ckUserIDSave.Properties.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this._ckUserIDSave.Properties.Appearance.Options.UseFont = true;
            this._ckUserIDSave.Properties.Caption = "아이디 저장";
            this._ckUserIDSave.Properties.ValueChecked = "Y";
            this._ckUserIDSave.Properties.ValueUnchecked = "N";
            this._ckUserIDSave.Size = new System.Drawing.Size(107, 19);
            this._ckUserIDSave.StyleController = this.layoutControl1;
            this._ckUserIDSave.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.BackgroundImageOptions.Visible = true;
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this._lciAccount,
            this._lciPassword,
            this.layoutControlItem1,
            this.layoutControlItem3});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(575, 190);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this._ckUserIDSave;
            this.layoutControlItem1.Location = new System.Drawing.Point(416, 144);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(111, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // _txtPassword
            // 
            this._txtPassword.CancelButton = null;
            this._txtPassword.CommandButton = null;
            this._txtPassword.EditMask = "";
            this._txtPassword.Location = new System.Drawing.Point(320, 156);
            this._txtPassword.Margin = new System.Windows.Forms.Padding(0);
            this._txtPassword.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._txtPassword.Name = "_txtPassword";
            this._txtPassword.PasswordChar = '*';
            this._txtPassword.ReadOnly = false;
            this._txtPassword.Size = new System.Drawing.Size(104, 22);
            this._txtPassword.TabIndex = 6;
            this._txtPassword.UseMaskAsDisplayFormat = false;
            this._txtPassword._OnKeyDown += new CoFAS_MES.CORE.BaseControls.ucTextEdit.OnKeyDownEventHandler(this._txtPassword_KeyDown);
            // 
            // _txtAccount
            // 
            this._txtAccount.CancelButton = null;
            this._txtAccount.CommandButton = null;
            this._txtAccount.EditMask = "";
            this._txtAccount.Location = new System.Drawing.Point(84, 156);
            this._txtAccount.Margin = new System.Windows.Forms.Padding(0);
            this._txtAccount.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._txtAccount.Name = "_txtAccount";
            this._txtAccount.PasswordChar = '\0';
            this._txtAccount.ReadOnly = false;
            this._txtAccount.Size = new System.Drawing.Size(160, 22);
            this._txtAccount.TabIndex = 5;
            this._txtAccount.UseMaskAsDisplayFormat = false;
            this._txtAccount._OnKeyDown += new CoFAS_MES.CORE.BaseControls.ucTextEdit.OnKeyDownEventHandler(this._txtAccount_KeyDown);
            // 
            // _btLoginSetting
            // 
            this._btLoginSetting.Appearance.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this._btLoginSetting.Appearance.Options.UseFont = true;
            this._btLoginSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._btLoginSetting.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources.technology_16x16;
            this._btLoginSetting.Location = new System.Drawing.Point(539, 156);
            this._btLoginSetting.Margin = new System.Windows.Forms.Padding(0);
            this._btLoginSetting.Name = "_btLoginSetting";
            this._btLoginSetting.Size = new System.Drawing.Size(24, 22);
            this._btLoginSetting.StyleController = this.layoutControl1;
            this._btLoginSetting.TabIndex = 0;
            this._btLoginSetting.Click += new System.EventHandler(this._btLoginSetting_Click);
            // 
            // ucPictureEdit1
            // 
            this.ucPictureEdit1.BackColor = System.Drawing.Color.Transparent;
            this.ucPictureEdit1.Image = global::CoFAS_MES.POP.Properties.Resources.Coever;
            this.ucPictureEdit1.Location = new System.Drawing.Point(12, 12);
            this.ucPictureEdit1.Margin = new System.Windows.Forms.Padding(0);
            this.ucPictureEdit1.Name = "ucPictureEdit1";
            this.ucPictureEdit1.Size = new System.Drawing.Size(551, 140);
            this.ucPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Clip;
            this.ucPictureEdit1.TabIndex = 7;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.ucPictureEdit1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(555, 144);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // _lciAccount
            // 
            this._lciAccount.AppearanceItemCaption.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this._lciAccount.AppearanceItemCaption.Options.UseFont = true;
            this._lciAccount.Control = this._txtAccount;
            this._lciAccount.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources.customers_16x16;
            this._lciAccount.Location = new System.Drawing.Point(0, 144);
            this._lciAccount.Name = "_lciAccount";
            this._lciAccount.Size = new System.Drawing.Size(236, 26);
            this._lciAccount.Text = "아이디";
            this._lciAccount.TextSize = new System.Drawing.Size(69, 16);
            // 
            // _lciPassword
            // 
            this._lciPassword.AppearanceItemCaption.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this._lciPassword.AppearanceItemCaption.Options.UseFont = true;
            this._lciPassword.Control = this._txtPassword;
            this._lciPassword.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources.newcustomers_16x16;
            this._lciPassword.Location = new System.Drawing.Point(236, 144);
            this._lciPassword.Name = "_lciPassword";
            this._lciPassword.Size = new System.Drawing.Size(180, 26);
            this._lciPassword.Text = "비밀번호";
            this._lciPassword.TextSize = new System.Drawing.Size(69, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this._btLoginSetting;
            this.layoutControlItem3.Location = new System.Drawing.Point(527, 144);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(28, 26);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(28, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(28, 26);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // _btLoginOk
            // 
            this._btLoginOk.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this._btLoginOk.Appearance.ForeColor = System.Drawing.Color.Black;
            this._btLoginOk.Appearance.Options.UseFont = true;
            this._btLoginOk.Appearance.Options.UseForeColor = true;
            this._btLoginOk.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._btLoginOk.Dock = System.Windows.Forms.DockStyle.Right;
            this._btLoginOk.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources.apply_32x321;
            this._btLoginOk.Location = new System.Drawing.Point(395, 0);
            this._btLoginOk.Name = "_btLoginOk";
            this._btLoginOk.Size = new System.Drawing.Size(90, 40);
            this._btLoginOk.TabIndex = 2;
            this._btLoginOk.Text = "로그인";
            this._btLoginOk.Click += new System.EventHandler(this._btLoginOk_Click);
            // 
            // _btLoginCancel
            // 
            this._btLoginCancel.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this._btLoginCancel.Appearance.ForeColor = System.Drawing.Color.Black;
            this._btLoginCancel.Appearance.Options.UseFont = true;
            this._btLoginCancel.Appearance.Options.UseForeColor = true;
            this._btLoginCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._btLoginCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this._btLoginCancel.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources.close_32x321;
            this._btLoginCancel.Location = new System.Drawing.Point(485, 0);
            this._btLoginCancel.Name = "_btLoginCancel";
            this._btLoginCancel.Size = new System.Drawing.Size(90, 40);
            this._btLoginCancel.TabIndex = 1;
            this._btLoginCancel.Text = "닫기";
            this._btLoginCancel.Click += new System.EventHandler(this._btLoginCancel_Click);
            // 
            // _btLoginClose
            // 
            this._btLoginClose.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._btLoginClose.Appearance.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this._btLoginClose.Appearance.ForeColor = System.Drawing.Color.White;
            this._btLoginClose.Appearance.Options.UseBackColor = true;
            this._btLoginClose.Appearance.Options.UseFont = true;
            this._btLoginClose.Appearance.Options.UseForeColor = true;
            this._btLoginClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._btLoginClose.Dock = System.Windows.Forms.DockStyle.Right;
            this._btLoginClose.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources.close_16x162;
            this._btLoginClose.Location = new System.Drawing.Point(555, 0);
            this._btLoginClose.Margin = new System.Windows.Forms.Padding(0);
            this._btLoginClose.Name = "_btLoginClose";
            this._btLoginClose.Size = new System.Drawing.Size(20, 20);
            this._btLoginClose.TabIndex = 0;
            this._btLoginClose.Click += new System.EventHandler(this._btLoginClose_Click);
            // 
            // frmPOPLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 250);
            this.Controls.Add(this._pnLoginMain);
            this.Controls.Add(this._pnLoginBottm);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPOPLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Login";
            this.Load += new System.EventHandler(this.frmPOPLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pnLoginBottm)).EndInit();
            this._pnLoginBottm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pnLoginMain)).EndInit();
            this._pnLoginMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._ckUserIDSave.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl _pnLoginBottm;
        private DevExpress.XtraEditors.PanelControl _pnLoginMain;
        private DevExpress.XtraEditors.LabelControl _lbLoginHeader;
        private DevExpress.XtraEditors.SimpleButton _btLoginClose;
        private DevExpress.XtraEditors.SimpleButton _btLoginOk;
        private DevExpress.XtraEditors.SimpleButton _btLoginCancel;
        private DevExpress.XtraEditors.SimpleButton _btLoginSetting;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.CheckEdit _ckUserIDSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private CORE.BaseControls.ucTextEdit _txtPassword;
        private CORE.BaseControls.ucTextEdit _txtAccount;
        private DevExpress.XtraLayout.LayoutControlItem _lciAccount;
        private DevExpress.XtraLayout.LayoutControlItem _lciPassword;
        private CORE.BaseControls.ucPictureEdit ucPictureEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}
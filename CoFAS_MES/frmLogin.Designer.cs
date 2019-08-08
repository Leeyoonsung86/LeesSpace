namespace CoFAS_MES
{
    partial class frmLogin
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
            this._btLoginClose = new DevExpress.XtraEditors.SimpleButton();
            this._pnLoginBottm = new DevExpress.XtraEditors.PanelControl();
            this._btLoginSetting = new DevExpress.XtraEditors.SimpleButton();
            this._btLoginOk = new DevExpress.XtraEditors.SimpleButton();
            this._btLoginCancel = new DevExpress.XtraEditors.SimpleButton();
            this._pnLoginMain = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this._ucIMG_LOGIN_LOGO = new DevExpress.XtraEditors.PictureEdit();
            this._ckUserIDSave = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this._txtPassword = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._txtAccount = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._lciAccount = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciPassword = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pnLoginBottm)).BeginInit();
            this._pnLoginBottm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pnLoginMain)).BeginInit();
            this._pnLoginMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._ucIMG_LOGIN_LOGO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ckUserIDSave.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPassword)).BeginInit();
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
            this.panelControl1.Size = new System.Drawing.Size(641, 20);
            this.panelControl1.TabIndex = 0;
            // 
            // _lbLoginHeader
            // 
            this._lbLoginHeader.Appearance.BackColor = System.Drawing.Color.DarkTurquoise;
            this._lbLoginHeader.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this._lbLoginHeader.Appearance.ForeColor = System.Drawing.Color.Black;
            this._lbLoginHeader.Appearance.Image = global::CoFAS_MES.Properties.Resources.folderpanel_16x16;
            this._lbLoginHeader.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._lbLoginHeader.Appearance.Options.UseBackColor = true;
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
            this._lbLoginHeader.Size = new System.Drawing.Size(621, 20);
            this._lbLoginHeader.TabIndex = 1;
            this._lbLoginHeader.Text = "System Login";
            this._lbLoginHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_Moving);
            // 
            // _btLoginClose
            // 
            this._btLoginClose.Appearance.BackColor = System.Drawing.Color.DarkTurquoise;
            this._btLoginClose.Appearance.BackColor2 = System.Drawing.Color.DarkTurquoise;
            this._btLoginClose.Appearance.BorderColor = System.Drawing.Color.DarkTurquoise;
            this._btLoginClose.Appearance.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this._btLoginClose.Appearance.ForeColor = System.Drawing.Color.White;
            this._btLoginClose.Appearance.Options.UseBackColor = true;
            this._btLoginClose.Appearance.Options.UseBorderColor = true;
            this._btLoginClose.Appearance.Options.UseFont = true;
            this._btLoginClose.Appearance.Options.UseForeColor = true;
            this._btLoginClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._btLoginClose.Dock = System.Windows.Forms.DockStyle.Right;
            this._btLoginClose.ImageOptions.Image = global::CoFAS_MES.Properties.Resources.close_16x162;
            this._btLoginClose.Location = new System.Drawing.Point(621, 0);
            this._btLoginClose.Margin = new System.Windows.Forms.Padding(0);
            this._btLoginClose.Name = "_btLoginClose";
            this._btLoginClose.Size = new System.Drawing.Size(20, 20);
            this._btLoginClose.TabIndex = 0;
            this._btLoginClose.Click += new System.EventHandler(this._btLoginClose_Click);
            // 
            // _pnLoginBottm
            // 
            this._pnLoginBottm.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this._pnLoginBottm.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this._pnLoginBottm.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this._pnLoginBottm.Appearance.Options.UseBackColor = true;
            this._pnLoginBottm.Appearance.Options.UseBorderColor = true;
            this._pnLoginBottm.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._pnLoginBottm.Controls.Add(this._btLoginSetting);
            this._pnLoginBottm.Controls.Add(this._btLoginOk);
            this._pnLoginBottm.Controls.Add(this._btLoginCancel);
            this._pnLoginBottm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._pnLoginBottm.Location = new System.Drawing.Point(0, 210);
            this._pnLoginBottm.Margin = new System.Windows.Forms.Padding(0);
            this._pnLoginBottm.Name = "_pnLoginBottm";
            this._pnLoginBottm.Size = new System.Drawing.Size(641, 40);
            this._pnLoginBottm.TabIndex = 1;
            // 
            // _btLoginSetting
            // 
            this._btLoginSetting.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this._btLoginSetting.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this._btLoginSetting.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this._btLoginSetting.Appearance.Options.UseBackColor = true;
            this._btLoginSetting.Appearance.Options.UseBorderColor = true;
            this._btLoginSetting.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._btLoginSetting.Dock = System.Windows.Forms.DockStyle.Left;
            this._btLoginSetting.ImageOptions.Image = global::CoFAS_MES.Properties.Resources.technology_32x32;
            this._btLoginSetting.Location = new System.Drawing.Point(0, 0);
            this._btLoginSetting.Name = "_btLoginSetting";
            this._btLoginSetting.Size = new System.Drawing.Size(36, 40);
            this._btLoginSetting.TabIndex = 9;
            this._btLoginSetting.Click += new System.EventHandler(this._btLoginSetting_Click);
            // 
            // _btLoginOk
            // 
            this._btLoginOk.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this._btLoginOk.Appearance.ForeColor = System.Drawing.Color.White;
            this._btLoginOk.Appearance.Options.UseFont = true;
            this._btLoginOk.Appearance.Options.UseForeColor = true;
            this._btLoginOk.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._btLoginOk.Dock = System.Windows.Forms.DockStyle.Right;
            this._btLoginOk.ImageOptions.Image = global::CoFAS_MES.Properties.Resources.apply_32x32;
            this._btLoginOk.Location = new System.Drawing.Point(461, 0);
            this._btLoginOk.Name = "_btLoginOk";
            this._btLoginOk.Size = new System.Drawing.Size(90, 40);
            this._btLoginOk.TabIndex = 2;
            this._btLoginOk.Text = "로그인";
            this._btLoginOk.Click += new System.EventHandler(this._btLoginOk_Click);
            // 
            // _btLoginCancel
            // 
            this._btLoginCancel.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this._btLoginCancel.Appearance.ForeColor = System.Drawing.Color.White;
            this._btLoginCancel.Appearance.Options.UseFont = true;
            this._btLoginCancel.Appearance.Options.UseForeColor = true;
            this._btLoginCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._btLoginCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this._btLoginCancel.ImageOptions.Image = global::CoFAS_MES.Properties.Resources.close_32x32;
            this._btLoginCancel.Location = new System.Drawing.Point(551, 0);
            this._btLoginCancel.Name = "_btLoginCancel";
            this._btLoginCancel.Size = new System.Drawing.Size(90, 40);
            this._btLoginCancel.TabIndex = 1;
            this._btLoginCancel.Text = "닫기";
            this._btLoginCancel.Click += new System.EventHandler(this._btLoginCancel_Click);
            // 
            // _pnLoginMain
            // 
            this._pnLoginMain.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnLoginMain.Appearance.Options.UseBackColor = true;
            this._pnLoginMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._pnLoginMain.Controls.Add(this.layoutControl1);
            this._pnLoginMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnLoginMain.Location = new System.Drawing.Point(0, 20);
            this._pnLoginMain.Margin = new System.Windows.Forms.Padding(0);
            this._pnLoginMain.Name = "_pnLoginMain";
            this._pnLoginMain.Size = new System.Drawing.Size(641, 190);
            this._pnLoginMain.TabIndex = 2;
            // 
            // layoutControl1
            // 
            this.layoutControl1.BackColor = System.Drawing.Color.White;
            this.layoutControl1.Controls.Add(this._ucIMG_LOGIN_LOGO);
            this.layoutControl1.Controls.Add(this._txtPassword);
            this.layoutControl1.Controls.Add(this._txtAccount);
            this.layoutControl1.Controls.Add(this._ckUserIDSave);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1062, 512, 812, 500);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(641, 190);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _ucIMG_LOGIN_LOGO
            // 
            this._ucIMG_LOGIN_LOGO.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.False;
            this._ucIMG_LOGIN_LOGO.EditValue = global::CoFAS_MES.Properties.Resources.Coever;
            this._ucIMG_LOGIN_LOGO.Location = new System.Drawing.Point(12, 12);
            this._ucIMG_LOGIN_LOGO.Name = "_ucIMG_LOGIN_LOGO";
            this._ucIMG_LOGIN_LOGO.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._ucIMG_LOGIN_LOGO.Properties.Appearance.Options.UseBackColor = true;
            this._ucIMG_LOGIN_LOGO.Properties.ReadOnly = true;
            this._ucIMG_LOGIN_LOGO.Properties.ShowMenu = false;
            this._ucIMG_LOGIN_LOGO.Properties.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.False;
            this._ucIMG_LOGIN_LOGO.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this._ucIMG_LOGIN_LOGO.Size = new System.Drawing.Size(617, 142);
            this._ucIMG_LOGIN_LOGO.StyleController = this.layoutControl1;
            this._ucIMG_LOGIN_LOGO.TabIndex = 7;
            // 
            // _ckUserIDSave
            // 
            this._ckUserIDSave.EditValue = "Y";
            this._ckUserIDSave.Location = new System.Drawing.Point(463, 158);
            this._ckUserIDSave.Margin = new System.Windows.Forms.Padding(0);
            this._ckUserIDSave.Name = "_ckUserIDSave";
            this._ckUserIDSave.Properties.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this._ckUserIDSave.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this._ckUserIDSave.Properties.Appearance.Options.UseFont = true;
            this._ckUserIDSave.Properties.Appearance.Options.UseForeColor = true;
            this._ckUserIDSave.Properties.Caption = "아이디 저장";
            this._ckUserIDSave.Properties.ValueChecked = "Y";
            this._ckUserIDSave.Properties.ValueUnchecked = "N";
            this._ckUserIDSave.Size = new System.Drawing.Size(166, 19);
            this._ckUserIDSave.StyleController = this.layoutControl1;
            this._ckUserIDSave.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.layoutControlGroup1.AppearanceGroup.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.layoutControlGroup1.AppearanceGroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.layoutControlGroup1.AppearanceGroup.Options.UseBackColor = true;
            this.layoutControlGroup1.AppearanceGroup.Options.UseBorderColor = true;
            this.layoutControlGroup1.BackgroundImageOptions.Visible = true;
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this._lciAccount,
            this._lciPassword,
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(641, 190);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this._ckUserIDSave;
            this.layoutControlItem1.Location = new System.Drawing.Point(451, 146);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(170, 24);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this._ucIMG_LOGIN_LOGO;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(621, 146);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // _txtPassword
            // 
            this._txtPassword.CancelButton = null;
            this._txtPassword.CommandButton = null;
            this._txtPassword.EditMask = "";
            this._txtPassword.Location = new System.Drawing.Point(306, 158);
            this._txtPassword.Margin = new System.Windows.Forms.Padding(0);
            this._txtPassword.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._txtPassword.Name = "_txtPassword";
            this._txtPassword.NumText = "";
            this._txtPassword.PasswordChar = '*';
            this._txtPassword.ReadOnly = false;
            this._txtPassword.Size = new System.Drawing.Size(153, 20);
            this._txtPassword.TabIndex = 6;
            this._txtPassword.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._txtPassword.UseMaskAsDisplayFormat = false;
            this._txtPassword._OnKeyDown += new CoFAS_MES.CORE.BaseControls.ucTextEdit.OnKeyDownEventHandler(this._txtPassword_KeyDown);
            // 
            // _txtAccount
            // 
            this._txtAccount.CancelButton = null;
            this._txtAccount.CommandButton = null;
            this._txtAccount.EditMask = "";
            this._txtAccount.Location = new System.Drawing.Point(84, 158);
            this._txtAccount.Margin = new System.Windows.Forms.Padding(0);
            this._txtAccount.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._txtAccount.Name = "_txtAccount";
            this._txtAccount.NumText = "";
            this._txtAccount.PasswordChar = '\0';
            this._txtAccount.ReadOnly = false;
            this._txtAccount.Size = new System.Drawing.Size(146, 20);
            this._txtAccount.TabIndex = 5;
            this._txtAccount.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._txtAccount.UseMaskAsDisplayFormat = false;
            this._txtAccount._OnKeyDown += new CoFAS_MES.CORE.BaseControls.ucTextEdit.OnKeyDownEventHandler(this._txtAccount_KeyDown);
            // 
            // _lciAccount
            // 
            this._lciAccount.AppearanceItemCaption.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this._lciAccount.AppearanceItemCaption.ForeColor = System.Drawing.Color.White;
            this._lciAccount.AppearanceItemCaption.Options.UseFont = true;
            this._lciAccount.AppearanceItemCaption.Options.UseForeColor = true;
            this._lciAccount.Control = this._txtAccount;
            this._lciAccount.ImageOptions.Image = global::CoFAS_MES.Properties.Resources.customers_16x16;
            this._lciAccount.Location = new System.Drawing.Point(0, 146);
            this._lciAccount.Name = "_lciAccount";
            this._lciAccount.Size = new System.Drawing.Size(222, 24);
            this._lciAccount.Text = "아이디";
            this._lciAccount.TextSize = new System.Drawing.Size(69, 16);
            // 
            // _lciPassword
            // 
            this._lciPassword.AppearanceItemCaption.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this._lciPassword.AppearanceItemCaption.ForeColor = System.Drawing.Color.White;
            this._lciPassword.AppearanceItemCaption.Options.UseFont = true;
            this._lciPassword.AppearanceItemCaption.Options.UseForeColor = true;
            this._lciPassword.Control = this._txtPassword;
            this._lciPassword.ImageOptions.Image = global::CoFAS_MES.Properties.Resources.newcustomers_16x16;
            this._lciPassword.Location = new System.Drawing.Point(222, 146);
            this._lciPassword.Name = "_lciPassword";
            this._lciPassword.Size = new System.Drawing.Size(229, 24);
            this._lciPassword.Text = "비밀번호";
            this._lciPassword.TextSize = new System.Drawing.Size(69, 16);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(641, 250);
            this.Controls.Add(this._pnLoginMain);
            this.Controls.Add(this._pnLoginBottm);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pnLoginBottm)).EndInit();
            this._pnLoginBottm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pnLoginMain)).EndInit();
            this._pnLoginMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._ucIMG_LOGIN_LOGO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ckUserIDSave.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPassword)).EndInit();
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
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.CheckEdit _ckUserIDSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private CORE.BaseControls.ucTextEdit _txtPassword;
        private CORE.BaseControls.ucTextEdit _txtAccount;
        private DevExpress.XtraLayout.LayoutControlItem _lciAccount;
        private DevExpress.XtraLayout.LayoutControlItem _lciPassword;
        private DevExpress.XtraEditors.SimpleButton _btLoginSetting;
        private DevExpress.XtraEditors.PictureEdit _ucIMG_LOGIN_LOGO;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}
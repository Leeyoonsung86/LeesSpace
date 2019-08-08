namespace CoFAS_MES.AUTO.DWL
{
    partial class frmAutoDownload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAutoDownload));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this._lbFileCount = new DevExpress.XtraEditors.LabelControl();
            this._btEXIT = new DevExpress.XtraEditors.SimpleButton();
            this._lbAutodownload = new DevExpress.XtraEditors.LabelControl();
            this._pgrAutodownloadFile = new DevExpress.XtraEditors.ProgressBarControl();
            this._pcAutodownload = new CoFAS_MES.CORE.BaseControls.ucPictureEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this._pgrAutodownloadAll = new DevExpress.XtraEditors.ProgressBarControl();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this._pnSINGLENONE_MAIN)).BeginInit();
            this._pnSINGLENONE_MAIN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pgrAutodownloadFile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pgrAutodownloadAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // _pnSINGLENONE_MAIN
            // 
            this._pnSINGLENONE_MAIN.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnSINGLENONE_MAIN.Appearance.BorderColor = System.Drawing.Color.Silver;
            this._pnSINGLENONE_MAIN.Appearance.Options.UseBackColor = true;
            this._pnSINGLENONE_MAIN.Appearance.Options.UseBorderColor = true;
            this._pnSINGLENONE_MAIN.Controls.Add(this.layoutControl1);
            this._pnSINGLENONE_MAIN.Size = new System.Drawing.Size(467, 263);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._pgrAutodownloadAll);
            this.layoutControl1.Controls.Add(this._lbFileCount);
            this.layoutControl1.Controls.Add(this._btEXIT);
            this.layoutControl1.Controls.Add(this._lbAutodownload);
            this.layoutControl1.Controls.Add(this._pgrAutodownloadFile);
            this.layoutControl1.Controls.Add(this._pcAutodownload);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(752, 374, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(467, 263);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _lbFileCount
            // 
            this._lbFileCount.Appearance.Options.UseTextOptions = true;
            this._lbFileCount.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lbFileCount.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this._lbFileCount.Location = new System.Drawing.Point(10, 159);
            this._lbFileCount.Name = "_lbFileCount";
            this._lbFileCount.Size = new System.Drawing.Size(447, 14);
            this._lbFileCount.StyleController = this.layoutControl1;
            this._lbFileCount.TabIndex = 8;
            this._lbFileCount.Text = "000/999";
            // 
            // _btEXIT
            // 
            this._btEXIT.Location = new System.Drawing.Point(400, 231);
            this._btEXIT.Name = "_btEXIT";
            this._btEXIT.Size = new System.Drawing.Size(57, 22);
            this._btEXIT.StyleController = this.layoutControl1;
            this._btEXIT.TabIndex = 7;
            this._btEXIT.Text = "EXIT";
            this._btEXIT.Click += new System.EventHandler(this._btEXIT_Click);
            // 
            // _lbAutodownload
            // 
            this._lbAutodownload.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this._lbAutodownload.Location = new System.Drawing.Point(10, 213);
            this._lbAutodownload.Name = "_lbAutodownload";
            this._lbAutodownload.Size = new System.Drawing.Size(447, 14);
            this._lbAutodownload.StyleController = this.layoutControl1;
            this._lbAutodownload.TabIndex = 6;
            this._lbAutodownload.Text = "Download File ...";
            // 
            // _pgrAutodownloadFile
            // 
            this._pgrAutodownloadFile.Location = new System.Drawing.Point(10, 195);
            this._pgrAutodownloadFile.Name = "_pgrAutodownloadFile";
            this._pgrAutodownloadFile.Properties.Step = 1;
            this._pgrAutodownloadFile.Size = new System.Drawing.Size(447, 14);
            this._pgrAutodownloadFile.StyleController = this.layoutControl1;
            this._pgrAutodownloadFile.TabIndex = 5;
            // 
            // _pcAutodownload
            // 
            this._pcAutodownload.Image = ((System.Drawing.Image)(resources.GetObject("_pcAutodownload.Image")));
            this._pcAutodownload.Location = new System.Drawing.Point(10, 34);
            this._pcAutodownload.Margin = new System.Windows.Forms.Padding(0);
            this._pcAutodownload.Name = "_pcAutodownload";
            this._pcAutodownload.Size = new System.Drawing.Size(447, 121);
            this._pcAutodownload.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Clip;
            this._pcAutodownload.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlGroup1.Size = new System.Drawing.Size(467, 263);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CaptionImageOptions.Image = global::CoFAS_MES.AUTO.DWL.Properties.Resources.updatetableofcontents_16x16;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem1,
            this.layoutControlItem6,
            this.layoutControlItem5});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup2.Size = new System.Drawing.Size(461, 257);
            this.layoutControlGroup2.Text = "System Auto Download...";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this._pcAutodownload;
            this.layoutControlItem1.ImageOptions.Image = global::CoFAS_MES.AUTO.DWL.Properties.Resources.updatetableofcontents_16x16;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(451, 125);
            this.layoutControlItem1.Text = "System Auto Download . . .";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this._pgrAutodownloadFile;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 161);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(451, 18);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this._lbAutodownload;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 179);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(451, 18);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this._btEXIT;
            this.layoutControlItem4.Location = new System.Drawing.Point(390, 197);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(61, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 197);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(390, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this._lbFileCount;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 125);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(451, 18);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // _pgrAutodownloadAll
            // 
            this._pgrAutodownloadAll.Location = new System.Drawing.Point(10, 177);
            this._pgrAutodownloadAll.Name = "_pgrAutodownloadAll";
            this._pgrAutodownloadAll.Size = new System.Drawing.Size(447, 14);
            this._pgrAutodownloadAll.StyleController = this.layoutControl1;
            this._pgrAutodownloadAll.TabIndex = 9;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this._pgrAutodownloadAll;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 143);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(451, 18);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // frmAutoDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 263);
            this.Name = "frmAutoDownload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto_Download";
            this.Load += new System.EventHandler(this.frmAutoDownload_Load);
            ((System.ComponentModel.ISupportInitialize)(this._pnSINGLENONE_MAIN)).EndInit();
            this._pnSINGLENONE_MAIN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pgrAutodownloadFile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pgrAutodownloadAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.LabelControl _lbAutodownload;
        private DevExpress.XtraEditors.ProgressBarControl _pgrAutodownloadFile;
        private CORE.BaseControls.ucPictureEdit _pcAutodownload;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraEditors.SimpleButton _btEXIT;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.LabelControl _lbFileCount;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.ProgressBarControl _pgrAutodownloadAll;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}


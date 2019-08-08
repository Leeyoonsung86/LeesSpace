namespace CoFAS_MES.POP
{
    partial class frmPOPBOM
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCmd10 = new DevExpress.XtraEditors.SimpleButton();
            this.btnCmd20 = new DevExpress.XtraEditors.SimpleButton();
            this.btnCmd30 = new DevExpress.XtraEditors.SimpleButton();
            this.btnCmd40 = new DevExpress.XtraEditors.SimpleButton();
            this.btnCmd50 = new DevExpress.XtraEditors.SimpleButton();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.part_code = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.file_name = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.part_name = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.part_qty = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.part_unit = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.file_image = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.part_lvl = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.part_dsp_seq = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.cur_path = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.p_part_code = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.use_yn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.used_configuration = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.part_code2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.p_part_code2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.repositoryItemImageEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this._pnSINGLE_MAIN)).BeginInit();
            this._pnSINGLE_MAIN.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // _pnSINGLE_MAIN
            // 
            this._pnSINGLE_MAIN.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnSINGLE_MAIN.Appearance.BorderColor = System.Drawing.Color.Silver;
            this._pnSINGLE_MAIN.Appearance.Options.UseBackColor = true;
            this._pnSINGLE_MAIN.Appearance.Options.UseBorderColor = true;
            this._pnSINGLE_MAIN.Controls.Add(this.tableLayoutPanel1);
            this._pnSINGLE_MAIN.Size = new System.Drawing.Size(1920, 1040);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.Controls.Add(this.btnCmd10, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCmd20, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCmd30, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCmd40, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnCmd50, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.treeList1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1920, 1040);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnCmd10
            // 
            this.btnCmd10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCmd10.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources.AUp_64x;
            this.btnCmd10.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCmd10.Location = new System.Drawing.Point(1803, 3);
            this.btnCmd10.Name = "btnCmd10";
            this.btnCmd10.Size = new System.Drawing.Size(114, 198);
            this.btnCmd10.TabIndex = 0;
            this.btnCmd10.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // btnCmd20
            // 
            this.btnCmd20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCmd20.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources.Up_64x;
            this.btnCmd20.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCmd20.Location = new System.Drawing.Point(1803, 207);
            this.btnCmd20.Name = "btnCmd20";
            this.btnCmd20.Size = new System.Drawing.Size(114, 198);
            this.btnCmd20.TabIndex = 1;
            this.btnCmd20.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // btnCmd30
            // 
            this.btnCmd30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCmd30.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources.Select_64x;
            this.btnCmd30.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCmd30.Location = new System.Drawing.Point(1803, 411);
            this.btnCmd30.Name = "btnCmd30";
            this.btnCmd30.Size = new System.Drawing.Size(114, 198);
            this.btnCmd30.TabIndex = 2;
            this.btnCmd30.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // btnCmd40
            // 
            this.btnCmd40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCmd40.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources.Down_64x;
            this.btnCmd40.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.btnCmd40.Location = new System.Drawing.Point(1803, 615);
            this.btnCmd40.Name = "btnCmd40";
            this.btnCmd40.Size = new System.Drawing.Size(114, 198);
            this.btnCmd40.TabIndex = 3;
            this.btnCmd40.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // btnCmd50
            // 
            this.btnCmd50.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCmd50.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources.ADown_64x;
            this.btnCmd50.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.btnCmd50.Location = new System.Drawing.Point(1803, 819);
            this.btnCmd50.Name = "btnCmd50";
            this.btnCmd50.Size = new System.Drawing.Size(114, 198);
            this.btnCmd50.TabIndex = 4;
            this.btnCmd50.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.part_code,
            this.file_name,
            this.part_name,
            this.part_qty,
            this.part_unit,
            this.file_image,
            this.part_lvl,
            this.part_dsp_seq,
            this.cur_path,
            this.p_part_code,
            this.use_yn,
            this.used_configuration,
            this.part_code2,
            this.p_part_code2});
            this.treeList1.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.treeList1.DataSource = null;
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(3, 3);
            this.treeList1.LookAndFeel.SkinMaskColor = System.Drawing.Color.White;
            this.treeList1.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.treeList1.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsView.AutoWidth = false;
            this.treeList1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit1,
            this.repositoryItemImageEdit2,
            this.repositoryItemPictureEdit1});
            this.treeList1.RowHeight = 20;
            this.tableLayoutPanel1.SetRowSpan(this.treeList1, 5);
            this.treeList1.Size = new System.Drawing.Size(1794, 1014);
            this.treeList1.TabIndex = 1;
            // 
            // part_code
            // 
            this.part_code.Caption = "품목코드";
            this.part_code.FieldName = "part_code";
            this.part_code.MinWidth = 100;
            this.part_code.Name = "part_code";
            this.part_code.OptionsColumn.AllowEdit = false;
            this.part_code.OptionsColumn.AllowFocus = false;
            this.part_code.OptionsColumn.ReadOnly = true;
            this.part_code.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.String;
            this.part_code.Width = 173;
            // 
            // file_name
            // 
            this.file_name.Caption = "파일명";
            this.file_name.FieldName = "file_name";
            this.file_name.MinWidth = 200;
            this.file_name.Name = "file_name";
            this.file_name.OptionsColumn.AllowEdit = false;
            this.file_name.OptionsColumn.AllowFocus = false;
            this.file_name.OptionsColumn.ReadOnly = true;
            this.file_name.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.String;
            this.file_name.Visible = true;
            this.file_name.VisibleIndex = 0;
            this.file_name.Width = 200;
            // 
            // part_name
            // 
            this.part_name.Caption = "품목명";
            this.part_name.FieldName = "part_name";
            this.part_name.MinWidth = 300;
            this.part_name.Name = "part_name";
            this.part_name.OptionsColumn.AllowEdit = false;
            this.part_name.OptionsColumn.AllowFocus = false;
            this.part_name.OptionsColumn.ReadOnly = true;
            this.part_name.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.String;
            this.part_name.Visible = true;
            this.part_name.VisibleIndex = 1;
            this.part_name.Width = 359;
            // 
            // part_qty
            // 
            this.part_qty.Caption = "파트 수량";
            this.part_qty.FieldName = "part_qty";
            this.part_qty.Name = "part_qty";
            this.part_qty.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Decimal;
            this.part_qty.Visible = true;
            this.part_qty.VisibleIndex = 2;
            this.part_qty.Width = 123;
            // 
            // part_unit
            // 
            this.part_unit.Caption = "품목 단위";
            this.part_unit.FieldName = "part_unit";
            this.part_unit.Name = "part_unit";
            this.part_unit.OptionsColumn.AllowEdit = false;
            this.part_unit.OptionsColumn.AllowFocus = false;
            this.part_unit.OptionsColumn.ReadOnly = true;
            this.part_unit.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.String;
            this.part_unit.Width = 181;
            // 
            // file_image
            // 
            this.file_image.AppearanceCell.Options.UseImage = true;
            this.file_image.Caption = "파일이미지";
            this.file_image.ColumnEdit = this.repositoryItemPictureEdit1;
            this.file_image.FieldName = "파일이미지";
            this.file_image.Name = "file_image";
            this.file_image.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Object;
            this.file_image.Visible = true;
            this.file_image.VisibleIndex = 3;
            this.file_image.Width = 120;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // part_lvl
            // 
            this.part_lvl.Caption = "Part lv";
            this.part_lvl.FieldName = "part_lvl";
            this.part_lvl.Name = "part_lvl";
            this.part_lvl.OptionsColumn.AllowEdit = false;
            this.part_lvl.OptionsColumn.AllowFocus = false;
            this.part_lvl.OptionsColumn.ReadOnly = true;
            this.part_lvl.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Integer;
            // 
            // part_dsp_seq
            // 
            this.part_dsp_seq.Caption = "Part Display";
            this.part_dsp_seq.FieldName = "part_dsp_seq";
            this.part_dsp_seq.Name = "part_dsp_seq";
            this.part_dsp_seq.OptionsColumn.AllowEdit = false;
            this.part_dsp_seq.OptionsColumn.AllowFocus = false;
            this.part_dsp_seq.OptionsColumn.ReadOnly = true;
            this.part_dsp_seq.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Integer;
            // 
            // cur_path
            // 
            this.cur_path.FieldName = "cur_path";
            this.cur_path.Name = "cur_path";
            this.cur_path.OptionsColumn.AllowEdit = false;
            this.cur_path.OptionsColumn.AllowFocus = false;
            this.cur_path.OptionsColumn.ReadOnly = true;
            this.cur_path.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.String;
            // 
            // p_part_code
            // 
            this.p_part_code.Caption = "P Part";
            this.p_part_code.FieldName = "p_part_code";
            this.p_part_code.Name = "p_part_code";
            this.p_part_code.OptionsColumn.AllowEdit = false;
            this.p_part_code.OptionsColumn.AllowFocus = false;
            this.p_part_code.OptionsColumn.ReadOnly = true;
            this.p_part_code.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.String;
            // 
            // use_yn
            // 
            this.use_yn.Caption = "Use";
            this.use_yn.FieldName = "use_yn";
            this.use_yn.Name = "use_yn";
            this.use_yn.OptionsColumn.AllowEdit = false;
            this.use_yn.OptionsColumn.AllowFocus = false;
            this.use_yn.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.String;
            // 
            // used_configuration
            // 
            this.used_configuration.Caption = "Used Configuration";
            this.used_configuration.FieldName = "used_configuration";
            this.used_configuration.Name = "used_configuration";
            this.used_configuration.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.String;
            this.used_configuration.Width = 141;
            // 
            // part_code2
            // 
            this.part_code2.Caption = "파트코드2";
            this.part_code2.FieldName = "part_code2";
            this.part_code2.Name = "part_code2";
            // 
            // p_part_code2
            // 
            this.p_part_code2.Caption = "부모노드";
            this.p_part_code2.FieldName = "p_part_code2";
            this.p_part_code2.Name = "p_part_code2";
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // repositoryItemImageEdit2
            // 
            this.repositoryItemImageEdit2.AutoHeight = false;
            this.repositoryItemImageEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit2.Name = "repositoryItemImageEdit2";
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Used Configuration";
            this.treeListColumn1.FieldName = "used_configuration";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.String;
            this.treeListColumn1.Width = 141;
            // 
            // frmPOPBOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Child_Page_Setting_Visible = true;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Name = "frmPOPBOM";
            this.Text = "frmPOPOrder_T01";
            ((System.ComponentModel.ISupportInitialize)(this._pnSINGLE_MAIN)).EndInit();
            this._pnSINGLE_MAIN.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btnCmd10;
        private DevExpress.XtraEditors.SimpleButton btnCmd20;
        private DevExpress.XtraEditors.SimpleButton btnCmd30;
        private DevExpress.XtraEditors.SimpleButton btnCmd40;
        private DevExpress.XtraEditors.SimpleButton btnCmd50;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlc_part_code;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlc_part_name;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlc_part_qty;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlc_lvl;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlc_dsp_seq;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlc_path;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlc_p_part_code;
        private DevExpress.XtraTreeList.Columns.TreeListColumn part_code;
        private DevExpress.XtraTreeList.Columns.TreeListColumn file_name;
        private DevExpress.XtraTreeList.Columns.TreeListColumn part_name;
        private DevExpress.XtraTreeList.Columns.TreeListColumn part_qty;
        private DevExpress.XtraTreeList.Columns.TreeListColumn part_lvl;
        private DevExpress.XtraTreeList.Columns.TreeListColumn part_dsp_seq;
        private DevExpress.XtraTreeList.Columns.TreeListColumn cur_path;
        private DevExpress.XtraTreeList.Columns.TreeListColumn p_part_code;
        private DevExpress.XtraTreeList.Columns.TreeListColumn part_unit;
        private DevExpress.XtraTreeList.Columns.TreeListColumn use_yn;
        private DevExpress.XtraTreeList.Columns.TreeListColumn used_configuration;
        private DevExpress.XtraTreeList.Columns.TreeListColumn image_name;
        public DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn part_code2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn p_part_code2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn file_image;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit2;
        
    }
}
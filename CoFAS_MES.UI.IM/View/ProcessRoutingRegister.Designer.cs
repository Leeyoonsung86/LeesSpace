namespace CoFAS_MES.UI.IM
{
    partial class ProcessRoutingRegister
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
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition3 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition4 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan1 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement3 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement4 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement5 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition4 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition5 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition6 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            this.tCRUD = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tCONFIGURATION_CODE = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tCONFIGURATION_NAME = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tROUTING_REVISION_NO = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tCONFIGURATION_SEQ = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this._ucbtPART_MAPPING = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._luCONFIGURATION_VEND_CODE = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luPROCESS_MST_CODE = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luPROCESS_MST_NAME = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._ckCOPY = new DevExpress.XtraEditors.CheckEdit();
            this._luR_USE_YN = new CoFAS_MES.CORE.BaseControls.ucLookUpEdit();
            this._gdROUTING_MST = new DevExpress.XtraGrid.GridControl();
            this.tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this._luUSE_YN = new CoFAS_MES.CORE.BaseControls.ucLookUpEdit();
            this._luCONFIGURATION_MST_NAME = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luCONFIGURATION_MST_CODE = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._gdROUTING = new DevExpress.XtraGrid.GridControl();
            this._gdROUTING_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._ucbtROUTING_SAVE = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this._ucbtPROCESS_SAVE = new CoFAS_MES.CORE.BaseControls.ucSimpleButton();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.routing_code = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.routing_name = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.routing_lvl = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.routing_dsp_seq = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.cur_path = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.p_routing_code = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.use_yn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.used_configuration = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.ranking_code = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this._gdSUB05 = new DevExpress.XtraGrid.GridControl();
            this._gdSUB05_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._gdSUB03 = new DevExpress.XtraGrid.GridControl();
            this._gdSUB03_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._gdSUB02 = new DevExpress.XtraGrid.GridControl();
            this._gdSUB02_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._gdSUB01 = new DevExpress.XtraGrid.GridControl();
            this._gdSUB01_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
            this._lciCONFIGURATION_MST_CODE = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciCONFIGURATION_MST_NAME = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciCONFIGURATION_VEND_CODE = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciUSE_YN = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this._lcgPROCESS_CONFIGURATION = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciPROCESS_MST_NAME = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciPROCESS_MST_CODE = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciR_USE_YN = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup7 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this._luT_USE_YN = new CoFAS_MES.CORE.BaseControls.ucLookUpEdit();
            this._luT_CONFIGURATION_MST_NAME = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luT_CONFIGURATION_MST_CODE = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._gdMAIN = new DevExpress.XtraGrid.GridControl();
            this._gdMAIN_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this._lciT_CONFIGURATION_MST_CODE = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciT_CONFIGURATION_MST_NAME = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciT_USE_YN = new DevExpress.XtraLayout.LayoutControlItem();
            this._gdSUB04 = new DevExpress.XtraGrid.GridControl();
            this._gdSUB04_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this._gdSUB06 = new DevExpress.XtraGrid.GridControl();
            this._gdSUB06_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this._pnHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pnContent)).BeginInit();
            this._pnContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pnLeft)).BeginInit();
            this._pnLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pnRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._ckCOPY.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdROUTING_MST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdROUTING)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdROUTING_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB05_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB03_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB02_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB01_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCONFIGURATION_MST_CODE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCONFIGURATION_MST_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCONFIGURATION_VEND_CODE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciUSE_YN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lcgPROCESS_CONFIGURATION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPROCESS_MST_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPROCESS_MST_CODE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciR_USE_YN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciT_CONFIGURATION_MST_CODE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciT_CONFIGURATION_MST_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciT_USE_YN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB04_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB06_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // _pnHeader
            // 
            this._pnHeader.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnHeader.Appearance.Options.UseBackColor = true;
            this._pnHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnHeader.Size = new System.Drawing.Size(1200, 700);
            // 
            // _pnContent
            // 
            this._pnContent.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnContent.Appearance.Options.UseBackColor = true;
            this._pnContent.Controls.Add(this.layoutControl2);
            this._pnContent.Location = new System.Drawing.Point(320, 0);
            this._pnContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._pnContent.Size = new System.Drawing.Size(875, 700);
            // 
            // _pnLeft
            // 
            this._pnLeft.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnLeft.Appearance.Options.UseBackColor = true;
            this._pnLeft.Controls.Add(this.layoutControl1);
            this._pnLeft.Location = new System.Drawing.Point(0, 0);
            this._pnLeft.Size = new System.Drawing.Size(315, 700);
            // 
            // _pnRight
            // 
            this._pnRight.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnRight.Appearance.Options.UseBackColor = true;
            this._pnRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnRight.Location = new System.Drawing.Point(320, 0);
            this._pnRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._pnRight.Size = new System.Drawing.Size(880, 700);
            // 
            // tCRUD
            // 
            this.tCRUD.Caption = "CRUD ";
            this.tCRUD.FieldName = "CRUD";
            this.tCRUD.Name = "tCRUD";
            this.tCRUD.Visible = true;
            this.tCRUD.VisibleIndex = 4;
            // 
            // tCONFIGURATION_CODE
            // 
            this.tCONFIGURATION_CODE.Caption = "CONFIGURATION CODE";
            this.tCONFIGURATION_CODE.FieldName = "CONFIGURATION_CODE";
            this.tCONFIGURATION_CODE.Name = "tCONFIGURATION_CODE";
            this.tCONFIGURATION_CODE.Visible = true;
            this.tCONFIGURATION_CODE.VisibleIndex = 0;
            // 
            // tCONFIGURATION_NAME
            // 
            this.tCONFIGURATION_NAME.Caption = "CONFIGURATION NAME";
            this.tCONFIGURATION_NAME.FieldName = "CONFIGURATION_NAME";
            this.tCONFIGURATION_NAME.Name = "tCONFIGURATION_NAME";
            this.tCONFIGURATION_NAME.Visible = true;
            this.tCONFIGURATION_NAME.VisibleIndex = 1;
            // 
            // tROUTING_REVISION_NO
            // 
            this.tROUTING_REVISION_NO.Caption = "ROUTING REVISION NO";
            this.tROUTING_REVISION_NO.FieldName = "ROUTING_REVISION_NO";
            this.tROUTING_REVISION_NO.Name = "tROUTING_REVISION_NO";
            this.tROUTING_REVISION_NO.Visible = true;
            this.tROUTING_REVISION_NO.VisibleIndex = 2;
            // 
            // tCONFIGURATION_SEQ
            // 
            this.tCONFIGURATION_SEQ.Caption = "CONFIGURATION SEQ";
            this.tCONFIGURATION_SEQ.FieldName = "CONFIGURATION_SEQ";
            this.tCONFIGURATION_SEQ.Name = "tCONFIGURATION_SEQ";
            this.tCONFIGURATION_SEQ.Visible = true;
            this.tCONFIGURATION_SEQ.VisibleIndex = 3;
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this._gdSUB06);
            this.layoutControl2.Controls.Add(this._gdSUB04);
            this.layoutControl2.Controls.Add(this._ucbtPART_MAPPING);
            this.layoutControl2.Controls.Add(this._luCONFIGURATION_VEND_CODE);
            this.layoutControl2.Controls.Add(this._luPROCESS_MST_CODE);
            this.layoutControl2.Controls.Add(this._luPROCESS_MST_NAME);
            this.layoutControl2.Controls.Add(this._ckCOPY);
            this.layoutControl2.Controls.Add(this._luR_USE_YN);
            this.layoutControl2.Controls.Add(this._gdROUTING_MST);
            this.layoutControl2.Controls.Add(this._luUSE_YN);
            this.layoutControl2.Controls.Add(this._luCONFIGURATION_MST_NAME);
            this.layoutControl2.Controls.Add(this._luCONFIGURATION_MST_CODE);
            this.layoutControl2.Controls.Add(this._gdROUTING);
            this.layoutControl2.Controls.Add(this._ucbtROUTING_SAVE);
            this.layoutControl2.Controls.Add(this._ucbtPROCESS_SAVE);
            this.layoutControl2.Controls.Add(this.treeList1);
            this.layoutControl2.Controls.Add(this._gdSUB05);
            this.layoutControl2.Controls.Add(this._gdSUB03);
            this.layoutControl2.Controls.Add(this._gdSUB02);
            this.layoutControl2.Controls.Add(this._gdSUB01);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(0, 75, 649, 400);
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(875, 700);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // _ucbtPART_MAPPING
            // 
            this._ucbtPART_MAPPING.ButtonText = "구성";
            this._ucbtPART_MAPPING.FontSize = 0;
            this._ucbtPART_MAPPING.Image = global::CoFAS_MES.UI.IM.Properties.Resources.additem_16x16;
            this._ucbtPART_MAPPING.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtPART_MAPPING.Location = new System.Drawing.Point(633, 632);
            this._ucbtPART_MAPPING.Name = "_ucbtPART_MAPPING";
            this._ucbtPART_MAPPING.Size = new System.Drawing.Size(218, 20);
            this._ucbtPART_MAPPING.TabIndex = 31;
            this._ucbtPART_MAPPING.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtPART_MAPPING_Click);
            // 
            // _luCONFIGURATION_VEND_CODE
            // 
            this._luCONFIGURATION_VEND_CODE.CancelButton = null;
            this._luCONFIGURATION_VEND_CODE.CommandButton = null;
            this._luCONFIGURATION_VEND_CODE.EditMask = "";
            this._luCONFIGURATION_VEND_CODE.Location = new System.Drawing.Point(450, 656);
            this._luCONFIGURATION_VEND_CODE.Margin = new System.Windows.Forms.Padding(0);
            this._luCONFIGURATION_VEND_CODE.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luCONFIGURATION_VEND_CODE.Name = "_luCONFIGURATION_VEND_CODE";
            this._luCONFIGURATION_VEND_CODE.NumText = "";
            this._luCONFIGURATION_VEND_CODE.PasswordChar = '\0';
            this._luCONFIGURATION_VEND_CODE.ReadOnly = false;
            this._luCONFIGURATION_VEND_CODE.Size = new System.Drawing.Size(179, 20);
            this._luCONFIGURATION_VEND_CODE.TabIndex = 30;
            this._luCONFIGURATION_VEND_CODE.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luCONFIGURATION_VEND_CODE.UseMaskAsDisplayFormat = false;
            // 
            // _luPROCESS_MST_CODE
            // 
            this._luPROCESS_MST_CODE.CancelButton = null;
            this._luPROCESS_MST_CODE.CommandButton = null;
            this._luPROCESS_MST_CODE.EditMask = "";
            this._luPROCESS_MST_CODE.Location = new System.Drawing.Point(109, 419);
            this._luPROCESS_MST_CODE.Margin = new System.Windows.Forms.Padding(0);
            this._luPROCESS_MST_CODE.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luPROCESS_MST_CODE.Name = "_luPROCESS_MST_CODE";
            this._luPROCESS_MST_CODE.NumText = "";
            this._luPROCESS_MST_CODE.PasswordChar = '\0';
            this._luPROCESS_MST_CODE.ReadOnly = true;
            this._luPROCESS_MST_CODE.Size = new System.Drawing.Size(100, 20);
            this._luPROCESS_MST_CODE.TabIndex = 29;
            this._luPROCESS_MST_CODE.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luPROCESS_MST_CODE.UseMaskAsDisplayFormat = false;
            // 
            // _luPROCESS_MST_NAME
            // 
            this._luPROCESS_MST_NAME.CancelButton = null;
            this._luPROCESS_MST_NAME.CommandButton = null;
            this._luPROCESS_MST_NAME.EditMask = "";
            this._luPROCESS_MST_NAME.Location = new System.Drawing.Point(298, 419);
            this._luPROCESS_MST_NAME.Margin = new System.Windows.Forms.Padding(0);
            this._luPROCESS_MST_NAME.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luPROCESS_MST_NAME.Name = "_luPROCESS_MST_NAME";
            this._luPROCESS_MST_NAME.NumText = "";
            this._luPROCESS_MST_NAME.PasswordChar = '\0';
            this._luPROCESS_MST_NAME.ReadOnly = true;
            this._luPROCESS_MST_NAME.Size = new System.Drawing.Size(166, 20);
            this._luPROCESS_MST_NAME.TabIndex = 28;
            this._luPROCESS_MST_NAME.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luPROCESS_MST_NAME.UseMaskAsDisplayFormat = false;
            // 
            // _ckCOPY
            // 
            this._ckCOPY.Location = new System.Drawing.Point(657, 419);
            this._ckCOPY.Name = "_ckCOPY";
            this._ckCOPY.Properties.AutoWidth = true;
            this._ckCOPY.Properties.Caption = "_ckCOPY";
            this._ckCOPY.Size = new System.Drawing.Size(72, 19);
            this._ckCOPY.StyleController = this.layoutControl2;
            this._ckCOPY.TabIndex = 27;
            this._ckCOPY.Visible = false;
            this._ckCOPY.CheckedChanged += new System.EventHandler(this._ckCOPY_CheckedChanged);
            // 
            // _luR_USE_YN
            // 
            this._luR_USE_YN.ItemIndex = -1;
            this._luR_USE_YN.Location = new System.Drawing.Point(553, 419);
            this._luR_USE_YN.Margin = new System.Windows.Forms.Padding(0);
            this._luR_USE_YN.Name = "_luR_USE_YN";
            this._luR_USE_YN.ReadOnly = false;
            this._luR_USE_YN.Size = new System.Drawing.Size(100, 20);
            this._luR_USE_YN.TabIndex = 26;
            this._luR_USE_YN.Visible = false;
            // 
            // _gdROUTING_MST
            // 
            this._gdROUTING_MST.AllowDrop = true;
            this._gdROUTING_MST.Location = new System.Drawing.Point(15, 458);
            this._gdROUTING_MST.MainView = this.tileView1;
            this._gdROUTING_MST.Margin = new System.Windows.Forms.Padding(0);
            this._gdROUTING_MST.Name = "_gdROUTING_MST";
            this._gdROUTING_MST.Size = new System.Drawing.Size(845, 155);
            this._gdROUTING_MST.TabIndex = 21;
            this._gdROUTING_MST.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView1});
            // 
            // tileView1
            // 
            this.tileView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.tCRUD,
            this.tCONFIGURATION_CODE,
            this.tCONFIGURATION_NAME,
            this.tROUTING_REVISION_NO,
            this.tCONFIGURATION_SEQ});
            this.tileView1.GridControl = this._gdROUTING_MST;
            this.tileView1.Name = "tileView1";
            this.tileView1.OptionsDragDrop.AllowDrag = true;
            this.tileView1.OptionsTiles.IndentBetweenGroups = 10;
            this.tileView1.OptionsTiles.IndentBetweenItems = 7;
            this.tileView1.OptionsTiles.ItemSize = new System.Drawing.Size(200, 100);
            this.tileView1.OptionsTiles.Padding = new System.Windows.Forms.Padding(3);
            this.tileView1.TileColumns.Add(tableColumnDefinition1);
            this.tileView1.TileColumns.Add(tableColumnDefinition2);
            tableRowDefinition1.Length.Value = 14D;
            tableRowDefinition2.Length.Value = 4D;
            tableRowDefinition3.Length.Value = 13D;
            tableRowDefinition4.Length.Value = 3D;
            this.tileView1.TileRows.Add(tableRowDefinition1);
            this.tileView1.TileRows.Add(tableRowDefinition2);
            this.tileView1.TileRows.Add(tableRowDefinition3);
            this.tileView1.TileRows.Add(tableRowDefinition4);
            tableSpan1.ColumnSpan = 2;
            tableSpan1.RowIndex = 2;
            this.tileView1.TileSpans.Add(tableSpan1);
            tileViewItemElement1.Column = this.tCRUD;
            tileViewItemElement1.ColumnIndex = 1;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement1.RowIndex = 3;
            tileViewItemElement1.Text = "tCRUD";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.TextVisible = false;
            tileViewItemElement2.Column = this.tCONFIGURATION_CODE;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement2.Text = "tCONFIGURATION_CODE";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.Column = this.tCONFIGURATION_NAME;
            tileViewItemElement3.ColumnIndex = 1;
            tileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement3.RowIndex = 2;
            tileViewItemElement3.Text = "tCONFIGURATION_NAME";
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.Column = this.tROUTING_REVISION_NO;
            tileViewItemElement4.ColumnIndex = 1;
            tileViewItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement4.Text = "tROUTING_REVISION_NO";
            tileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.TextVisible = false;
            tileViewItemElement5.Column = this.tCONFIGURATION_SEQ;
            tileViewItemElement5.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement5.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement5.RowIndex = 3;
            tileViewItemElement5.Text = "tCONFIGURATION_SEQ";
            tileViewItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement5.TextVisible = false;
            this.tileView1.TileTemplate.Add(tileViewItemElement1);
            this.tileView1.TileTemplate.Add(tileViewItemElement2);
            this.tileView1.TileTemplate.Add(tileViewItemElement3);
            this.tileView1.TileTemplate.Add(tileViewItemElement4);
            this.tileView1.TileTemplate.Add(tileViewItemElement5);
            // 
            // _luUSE_YN
            // 
            this._luUSE_YN.ItemIndex = -1;
            this._luUSE_YN.Location = new System.Drawing.Point(450, 632);
            this._luUSE_YN.Margin = new System.Windows.Forms.Padding(0);
            this._luUSE_YN.Name = "_luUSE_YN";
            this._luUSE_YN.ReadOnly = false;
            this._luUSE_YN.Size = new System.Drawing.Size(179, 20);
            this._luUSE_YN.TabIndex = 20;
            // 
            // _luCONFIGURATION_MST_NAME
            // 
            this._luCONFIGURATION_MST_NAME.CancelButton = null;
            this._luCONFIGURATION_MST_NAME.CommandButton = null;
            this._luCONFIGURATION_MST_NAME.EditMask = "";
            this._luCONFIGURATION_MST_NAME.Location = new System.Drawing.Point(129, 656);
            this._luCONFIGURATION_MST_NAME.Margin = new System.Windows.Forms.Padding(0);
            this._luCONFIGURATION_MST_NAME.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luCONFIGURATION_MST_NAME.Name = "_luCONFIGURATION_MST_NAME";
            this._luCONFIGURATION_MST_NAME.NumText = "";
            this._luCONFIGURATION_MST_NAME.PasswordChar = '\0';
            this._luCONFIGURATION_MST_NAME.ReadOnly = false;
            this._luCONFIGURATION_MST_NAME.Size = new System.Drawing.Size(212, 20);
            this._luCONFIGURATION_MST_NAME.TabIndex = 19;
            this._luCONFIGURATION_MST_NAME.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luCONFIGURATION_MST_NAME.UseMaskAsDisplayFormat = false;
            // 
            // _luCONFIGURATION_MST_CODE
            // 
            this._luCONFIGURATION_MST_CODE.CancelButton = null;
            this._luCONFIGURATION_MST_CODE.CommandButton = null;
            this._luCONFIGURATION_MST_CODE.EditMask = "";
            this._luCONFIGURATION_MST_CODE.Location = new System.Drawing.Point(129, 632);
            this._luCONFIGURATION_MST_CODE.Margin = new System.Windows.Forms.Padding(0);
            this._luCONFIGURATION_MST_CODE.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luCONFIGURATION_MST_CODE.Name = "_luCONFIGURATION_MST_CODE";
            this._luCONFIGURATION_MST_CODE.NumText = "";
            this._luCONFIGURATION_MST_CODE.PasswordChar = '\0';
            this._luCONFIGURATION_MST_CODE.ReadOnly = true;
            this._luCONFIGURATION_MST_CODE.Size = new System.Drawing.Size(212, 20);
            this._luCONFIGURATION_MST_CODE.TabIndex = 18;
            this._luCONFIGURATION_MST_CODE.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luCONFIGURATION_MST_CODE.UseMaskAsDisplayFormat = false;
            // 
            // _gdROUTING
            // 
            this._gdROUTING.AllowDrop = true;
            gridLevelNode1.RelationName = "Level1";
            this._gdROUTING.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this._gdROUTING.Location = new System.Drawing.Point(24, 214);
            this._gdROUTING.MainView = this._gdROUTING_VIEW;
            this._gdROUTING.Name = "_gdROUTING";
            this._gdROUTING.Size = new System.Drawing.Size(344, 201);
            this._gdROUTING.TabIndex = 15;
            this._gdROUTING.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gdROUTING_VIEW});
            // 
            // _gdROUTING_VIEW
            // 
            this._gdROUTING_VIEW.GridControl = this._gdROUTING;
            this._gdROUTING_VIEW.Name = "_gdROUTING_VIEW";
            this._gdROUTING_VIEW.OptionsBehavior.Editable = false;
            // 
            // _ucbtROUTING_SAVE
            // 
            this._ucbtROUTING_SAVE.ButtonText = "저장";
            this._ucbtROUTING_SAVE.FontSize = 0;
            this._ucbtROUTING_SAVE.Image = global::CoFAS_MES.UI.IM.Properties.Resources.save_16x16;
            this._ucbtROUTING_SAVE.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtROUTING_SAVE.Location = new System.Drawing.Point(633, 656);
            this._ucbtROUTING_SAVE.Name = "_ucbtROUTING_SAVE";
            this._ucbtROUTING_SAVE.Size = new System.Drawing.Size(218, 20);
            this._ucbtROUTING_SAVE.TabIndex = 13;
            this._ucbtROUTING_SAVE.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtROUTING_SAVE_Click);
            // 
            // _ucbtPROCESS_SAVE
            // 
            this._ucbtPROCESS_SAVE.ButtonText = "저장";
            this._ucbtPROCESS_SAVE.FontSize = 0;
            this._ucbtPROCESS_SAVE.Image = global::CoFAS_MES.UI.IM.Properties.Resources.save_16x16;
            this._ucbtPROCESS_SAVE.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.None;
            this._ucbtPROCESS_SAVE.Location = new System.Drawing.Point(743, 419);
            this._ucbtPROCESS_SAVE.Name = "_ucbtPROCESS_SAVE";
            this._ucbtPROCESS_SAVE.Size = new System.Drawing.Size(108, 20);
            this._ucbtPROCESS_SAVE.TabIndex = 12;
            this._ucbtPROCESS_SAVE.Click += new CoFAS_MES.CORE.BaseControls.ucSimpleButton.OnClickEventHandler(this._ucbtPROCESS_SAVE_Click);
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.routing_code,
            this.routing_name,
            this.routing_lvl,
            this.routing_dsp_seq,
            this.cur_path,
            this.p_routing_code,
            this.use_yn,
            this.used_configuration,
            this.ranking_code});
            this.treeList1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeList1.DataSource = null;
            this.treeList1.Location = new System.Drawing.Point(372, 214);
            this.treeList1.Name = "treeList1";
            this.treeList1.Size = new System.Drawing.Size(479, 201);
            this.treeList1.TabIndex = 11;
            // 
            // routing_code
            // 
            this.routing_code.AppearanceCell.Options.UseTextOptions = true;
            this.routing_code.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.routing_code.AppearanceHeader.Options.UseTextOptions = true;
            this.routing_code.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.routing_code.Caption = "공정 코드";
            this.routing_code.FieldName = "routing_code";
            this.routing_code.Name = "routing_code";
            this.routing_code.OptionsColumn.AllowEdit = false;
            this.routing_code.OptionsColumn.AllowFocus = false;
            this.routing_code.OptionsColumn.ReadOnly = true;
            this.routing_code.Visible = true;
            this.routing_code.VisibleIndex = 0;
            // 
            // routing_name
            // 
            this.routing_name.AppearanceHeader.Options.UseTextOptions = true;
            this.routing_name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.routing_name.Caption = "공정 이름";
            this.routing_name.FieldName = "routing_name";
            this.routing_name.Name = "routing_name";
            this.routing_name.OptionsColumn.AllowEdit = false;
            this.routing_name.OptionsColumn.AllowFocus = false;
            this.routing_name.OptionsColumn.ReadOnly = true;
            this.routing_name.Visible = true;
            this.routing_name.VisibleIndex = 1;
            // 
            // routing_lvl
            // 
            this.routing_lvl.AppearanceCell.Options.UseTextOptions = true;
            this.routing_lvl.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.routing_lvl.AppearanceHeader.Options.UseTextOptions = true;
            this.routing_lvl.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.routing_lvl.Caption = "Routing lv";
            this.routing_lvl.FieldName = "routing_lvl";
            this.routing_lvl.Name = "routing_lvl";
            this.routing_lvl.OptionsColumn.AllowEdit = false;
            this.routing_lvl.OptionsColumn.AllowFocus = false;
            this.routing_lvl.OptionsColumn.ReadOnly = true;
            // 
            // routing_dsp_seq
            // 
            this.routing_dsp_seq.AppearanceCell.Options.UseTextOptions = true;
            this.routing_dsp_seq.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.routing_dsp_seq.AppearanceHeader.Options.UseTextOptions = true;
            this.routing_dsp_seq.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.routing_dsp_seq.Caption = "Display Seq";
            this.routing_dsp_seq.FieldName = "routing_dsp_seq";
            this.routing_dsp_seq.Name = "routing_dsp_seq";
            this.routing_dsp_seq.OptionsColumn.AllowEdit = false;
            this.routing_dsp_seq.OptionsColumn.AllowFocus = false;
            this.routing_dsp_seq.OptionsColumn.ReadOnly = true;
            // 
            // cur_path
            // 
            this.cur_path.AppearanceHeader.Options.UseTextOptions = true;
            this.cur_path.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cur_path.Caption = "Cur Path";
            this.cur_path.FieldName = "cur_path";
            this.cur_path.Name = "cur_path";
            this.cur_path.OptionsColumn.AllowEdit = false;
            this.cur_path.OptionsColumn.AllowFocus = false;
            this.cur_path.OptionsColumn.ReadOnly = true;
            // 
            // p_routing_code
            // 
            this.p_routing_code.AppearanceHeader.Options.UseTextOptions = true;
            this.p_routing_code.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.p_routing_code.Caption = "P Routing Code";
            this.p_routing_code.FieldName = "p_routing_code";
            this.p_routing_code.Name = "p_routing_code";
            this.p_routing_code.OptionsColumn.AllowEdit = false;
            this.p_routing_code.OptionsColumn.AllowFocus = false;
            this.p_routing_code.OptionsColumn.ReadOnly = true;
            // 
            // use_yn
            // 
            this.use_yn.AppearanceCell.Options.UseTextOptions = true;
            this.use_yn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.use_yn.AppearanceHeader.Options.UseTextOptions = true;
            this.use_yn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.use_yn.Caption = "사용여부";
            this.use_yn.FieldName = "use_yn";
            this.use_yn.Name = "use_yn";
            this.use_yn.OptionsColumn.AllowEdit = false;
            this.use_yn.OptionsColumn.AllowFocus = false;
            this.use_yn.OptionsColumn.ReadOnly = true;
            this.use_yn.Visible = true;
            this.use_yn.VisibleIndex = 2;
            // 
            // used_configuration
            // 
            this.used_configuration.AppearanceCell.Options.UseTextOptions = true;
            this.used_configuration.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.used_configuration.AppearanceHeader.Options.UseTextOptions = true;
            this.used_configuration.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.used_configuration.Caption = "Used Configuration";
            this.used_configuration.FieldName = "used_configuration";
            this.used_configuration.Name = "used_configuration";
            this.used_configuration.OptionsColumn.AllowEdit = false;
            this.used_configuration.OptionsColumn.AllowFocus = false;
            this.used_configuration.OptionsColumn.ReadOnly = true;
            // 
            // ranking_code
            // 
            this.ranking_code.AppearanceCell.Options.UseTextOptions = true;
            this.ranking_code.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ranking_code.AppearanceHeader.Options.UseTextOptions = true;
            this.ranking_code.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ranking_code.Caption = "Rank Code";
            this.ranking_code.FieldName = "ranking_code";
            this.ranking_code.Name = "ranking_code";
            this.ranking_code.OptionsColumn.AllowEdit = false;
            this.ranking_code.OptionsColumn.AllowFocus = false;
            this.ranking_code.OptionsColumn.ReadOnly = true;
            // 
            // _gdSUB05
            // 
            this._gdSUB05.Location = new System.Drawing.Point(713, 24);
            this._gdSUB05.MainView = this._gdSUB05_VIEW;
            this._gdSUB05.Name = "_gdSUB05";
            this._gdSUB05.Size = new System.Drawing.Size(138, 162);
            this._gdSUB05.TabIndex = 9;
            this._gdSUB05.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gdSUB05_VIEW});
            // 
            // _gdSUB05_VIEW
            // 
            this._gdSUB05_VIEW.GridControl = this._gdSUB05;
            this._gdSUB05_VIEW.Name = "_gdSUB05_VIEW";
            // 
            // _gdSUB03
            // 
            this._gdSUB03.Location = new System.Drawing.Point(290, 24);
            this._gdSUB03.MainView = this._gdSUB03_VIEW;
            this._gdSUB03.Name = "_gdSUB03";
            this._gdSUB03.Size = new System.Drawing.Size(137, 162);
            this._gdSUB03.TabIndex = 7;
            this._gdSUB03.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gdSUB03_VIEW});
            // 
            // _gdSUB03_VIEW
            // 
            this._gdSUB03_VIEW.GridControl = this._gdSUB03;
            this._gdSUB03_VIEW.Name = "_gdSUB03_VIEW";
            // 
            // _gdSUB02
            // 
            this._gdSUB02.Location = new System.Drawing.Point(149, 24);
            this._gdSUB02.MainView = this._gdSUB02_VIEW;
            this._gdSUB02.Name = "_gdSUB02";
            this._gdSUB02.Size = new System.Drawing.Size(137, 162);
            this._gdSUB02.TabIndex = 6;
            this._gdSUB02.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gdSUB02_VIEW});
            // 
            // _gdSUB02_VIEW
            // 
            this._gdSUB02_VIEW.GridControl = this._gdSUB02;
            this._gdSUB02_VIEW.Name = "_gdSUB02_VIEW";
            // 
            // _gdSUB01
            // 
            this._gdSUB01.Location = new System.Drawing.Point(24, 24);
            this._gdSUB01.MainView = this._gdSUB01_VIEW;
            this._gdSUB01.Name = "_gdSUB01";
            this._gdSUB01.Size = new System.Drawing.Size(121, 162);
            this._gdSUB01.TabIndex = 4;
            this._gdSUB01.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gdSUB01_VIEW});
            // 
            // _gdSUB01_VIEW
            // 
            this._gdSUB01_VIEW.GridControl = this._gdSUB01;
            this._gdSUB01_VIEW.Name = "_gdSUB01_VIEW";
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup6,
            this._lcgPROCESS_CONFIGURATION,
            this.layoutControlGroup5,
            this.layoutControlGroup7});
            this.layoutControlGroup2.Name = "Root";
            this.layoutControlGroup2.Size = new System.Drawing.Size(875, 700);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlGroup6
            // 
            this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this._lciCONFIGURATION_MST_CODE,
            this._lciCONFIGURATION_MST_NAME,
            this._lciCONFIGURATION_VEND_CODE,
            this._lciUSE_YN,
            this.layoutControlItem3,
            this.layoutControlItem11});
            this.layoutControlGroup6.Location = new System.Drawing.Point(0, 608);
            this.layoutControlGroup6.Name = "layoutControlGroup6";
            this.layoutControlGroup6.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlGroup6.Size = new System.Drawing.Size(855, 72);
            this.layoutControlGroup6.TextVisible = false;
            // 
            // _lciCONFIGURATION_MST_CODE
            // 
            this._lciCONFIGURATION_MST_CODE.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciCONFIGURATION_MST_CODE.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciCONFIGURATION_MST_CODE.Control = this._luCONFIGURATION_MST_CODE;
            this._lciCONFIGURATION_MST_CODE.Location = new System.Drawing.Point(0, 0);
            this._lciCONFIGURATION_MST_CODE.MaxSize = new System.Drawing.Size(0, 24);
            this._lciCONFIGURATION_MST_CODE.MinSize = new System.Drawing.Size(259, 24);
            this._lciCONFIGURATION_MST_CODE.Name = "_lciCONFIGURATION_MST_CODE";
            this._lciCONFIGURATION_MST_CODE.Size = new System.Drawing.Size(321, 24);
            this._lciCONFIGURATION_MST_CODE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciCONFIGURATION_MST_CODE.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this._lciCONFIGURATION_MST_CODE.TextSize = new System.Drawing.Size(100, 14);
            this._lciCONFIGURATION_MST_CODE.TextToControlDistance = 5;
            // 
            // _lciCONFIGURATION_MST_NAME
            // 
            this._lciCONFIGURATION_MST_NAME.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciCONFIGURATION_MST_NAME.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciCONFIGURATION_MST_NAME.Control = this._luCONFIGURATION_MST_NAME;
            this._lciCONFIGURATION_MST_NAME.Location = new System.Drawing.Point(0, 24);
            this._lciCONFIGURATION_MST_NAME.MaxSize = new System.Drawing.Size(0, 24);
            this._lciCONFIGURATION_MST_NAME.MinSize = new System.Drawing.Size(250, 24);
            this._lciCONFIGURATION_MST_NAME.Name = "_lciCONFIGURATION_MST_NAME";
            this._lciCONFIGURATION_MST_NAME.Size = new System.Drawing.Size(321, 24);
            this._lciCONFIGURATION_MST_NAME.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciCONFIGURATION_MST_NAME.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this._lciCONFIGURATION_MST_NAME.TextSize = new System.Drawing.Size(100, 14);
            this._lciCONFIGURATION_MST_NAME.TextToControlDistance = 5;
            // 
            // _lciCONFIGURATION_VEND_CODE
            // 
            this._lciCONFIGURATION_VEND_CODE.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciCONFIGURATION_VEND_CODE.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciCONFIGURATION_VEND_CODE.Control = this._luCONFIGURATION_VEND_CODE;
            this._lciCONFIGURATION_VEND_CODE.Location = new System.Drawing.Point(321, 24);
            this._lciCONFIGURATION_VEND_CODE.MaxSize = new System.Drawing.Size(0, 24);
            this._lciCONFIGURATION_VEND_CODE.MinSize = new System.Drawing.Size(288, 24);
            this._lciCONFIGURATION_VEND_CODE.Name = "_lciCONFIGURATION_VEND_CODE";
            this._lciCONFIGURATION_VEND_CODE.Size = new System.Drawing.Size(288, 24);
            this._lciCONFIGURATION_VEND_CODE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciCONFIGURATION_VEND_CODE.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this._lciCONFIGURATION_VEND_CODE.TextSize = new System.Drawing.Size(100, 20);
            this._lciCONFIGURATION_VEND_CODE.TextToControlDistance = 5;
            // 
            // _lciUSE_YN
            // 
            this._lciUSE_YN.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciUSE_YN.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciUSE_YN.Control = this._luUSE_YN;
            this._lciUSE_YN.Location = new System.Drawing.Point(321, 0);
            this._lciUSE_YN.MaxSize = new System.Drawing.Size(0, 24);
            this._lciUSE_YN.MinSize = new System.Drawing.Size(150, 24);
            this._lciUSE_YN.Name = "_lciUSE_YN";
            this._lciUSE_YN.Size = new System.Drawing.Size(288, 24);
            this._lciUSE_YN.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciUSE_YN.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this._lciUSE_YN.TextSize = new System.Drawing.Size(100, 14);
            this._lciUSE_YN.TextToControlDistance = 5;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this._ucbtPART_MAPPING;
            this.layoutControlItem3.Location = new System.Drawing.Point(609, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(222, 24);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this._ucbtROUTING_SAVE;
            this.layoutControlItem11.Location = new System.Drawing.Point(609, 24);
            this.layoutControlItem11.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItem11.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(222, 24);
            this.layoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // _lcgPROCESS_CONFIGURATION
            // 
            this._lcgPROCESS_CONFIGURATION.AppearanceGroup.Options.UseTextOptions = true;
            this._lcgPROCESS_CONFIGURATION.AppearanceGroup.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._lcgPROCESS_CONFIGURATION.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem15});
            this._lcgPROCESS_CONFIGURATION.Location = new System.Drawing.Point(0, 443);
            this._lcgPROCESS_CONFIGURATION.Name = "_lcgPROCESS_CONFIGURATION";
            this._lcgPROCESS_CONFIGURATION.OptionsTableLayoutItem.RowIndex = 2;
            this._lcgPROCESS_CONFIGURATION.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this._lcgPROCESS_CONFIGURATION.Size = new System.Drawing.Size(855, 165);
            this._lcgPROCESS_CONFIGURATION.TextVisible = false;
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this._gdROUTING_MST;
            this.layoutControlItem15.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(849, 159);
            this.layoutControlItem15.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem15.TextVisible = false;
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem9,
            this.layoutControlItem12,
            this._lciPROCESS_MST_NAME,
            this._lciPROCESS_MST_CODE,
            this.layoutControlItem16,
            this._lciR_USE_YN,
            this.layoutControlItem10,
            this.emptySpaceItem1});
            this.layoutControlGroup5.Location = new System.Drawing.Point(0, 190);
            this.layoutControlGroup5.Name = "layoutControlGroup5";
            this.layoutControlGroup5.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlGroup5.Size = new System.Drawing.Size(855, 253);
            this.layoutControlGroup5.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.treeList1;
            this.layoutControlItem9.Location = new System.Drawing.Point(348, 0);
            this.layoutControlItem9.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(483, 205);
            this.layoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this._gdROUTING;
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem12.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(348, 205);
            this.layoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem12.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem12.TextVisible = false;
            // 
            // _lciPROCESS_MST_NAME
            // 
            this._lciPROCESS_MST_NAME.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciPROCESS_MST_NAME.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciPROCESS_MST_NAME.Control = this._luPROCESS_MST_NAME;
            this._lciPROCESS_MST_NAME.Location = new System.Drawing.Point(189, 205);
            this._lciPROCESS_MST_NAME.MaxSize = new System.Drawing.Size(0, 24);
            this._lciPROCESS_MST_NAME.MinSize = new System.Drawing.Size(189, 24);
            this._lciPROCESS_MST_NAME.Name = "_lciPROCESS_MST_NAME";
            this._lciPROCESS_MST_NAME.Size = new System.Drawing.Size(255, 24);
            this._lciPROCESS_MST_NAME.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciPROCESS_MST_NAME.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this._lciPROCESS_MST_NAME.TextSize = new System.Drawing.Size(80, 20);
            this._lciPROCESS_MST_NAME.TextToControlDistance = 5;
            // 
            // _lciPROCESS_MST_CODE
            // 
            this._lciPROCESS_MST_CODE.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciPROCESS_MST_CODE.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciPROCESS_MST_CODE.Control = this._luPROCESS_MST_CODE;
            this._lciPROCESS_MST_CODE.Location = new System.Drawing.Point(0, 205);
            this._lciPROCESS_MST_CODE.MaxSize = new System.Drawing.Size(0, 24);
            this._lciPROCESS_MST_CODE.MinSize = new System.Drawing.Size(189, 24);
            this._lciPROCESS_MST_CODE.Name = "_lciPROCESS_MST_CODE";
            this._lciPROCESS_MST_CODE.Size = new System.Drawing.Size(189, 24);
            this._lciPROCESS_MST_CODE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciPROCESS_MST_CODE.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this._lciPROCESS_MST_CODE.TextSize = new System.Drawing.Size(80, 20);
            this._lciPROCESS_MST_CODE.TextToControlDistance = 5;
            // 
            // layoutControlItem16
            // 
            this.layoutControlItem16.Control = this._ckCOPY;
            this.layoutControlItem16.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutControlItem16.Location = new System.Drawing.Point(633, 205);
            this.layoutControlItem16.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItem16.MinSize = new System.Drawing.Size(76, 24);
            this.layoutControlItem16.Name = "layoutControlItem16";
            this.layoutControlItem16.Size = new System.Drawing.Size(76, 24);
            this.layoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem16.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem16.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem16.TextToControlDistance = 0;
            this.layoutControlItem16.TextVisible = false;
            this.layoutControlItem16.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // _lciR_USE_YN
            // 
            this._lciR_USE_YN.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciR_USE_YN.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciR_USE_YN.Control = this._luR_USE_YN;
            this._lciR_USE_YN.Location = new System.Drawing.Point(444, 205);
            this._lciR_USE_YN.MaxSize = new System.Drawing.Size(0, 24);
            this._lciR_USE_YN.MinSize = new System.Drawing.Size(189, 24);
            this._lciR_USE_YN.Name = "_lciR_USE_YN";
            this._lciR_USE_YN.Size = new System.Drawing.Size(189, 24);
            this._lciR_USE_YN.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciR_USE_YN.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this._lciR_USE_YN.TextSize = new System.Drawing.Size(80, 14);
            this._lciR_USE_YN.TextToControlDistance = 5;
            this._lciR_USE_YN.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this._ucbtPROCESS_SAVE;
            this.layoutControlItem10.Location = new System.Drawing.Point(719, 205);
            this.layoutControlItem10.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItem10.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(112, 24);
            this.layoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(709, 205);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(0, 24);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(10, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(10, 24);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup7
            // 
            this.layoutControlGroup7.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem7,
            this.layoutControlItem6,
            this.layoutControlItem8});
            this.layoutControlGroup7.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.layoutControlGroup7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup7.Name = "layoutControlGroup7";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition1.Width = 15D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 17D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition3.Width = 17D;
            columnDefinition4.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition4.Width = 17D;
            columnDefinition5.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition5.Width = 17D;
            columnDefinition6.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition6.Width = 17D;
            this.layoutControlGroup7.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3,
            columnDefinition4,
            columnDefinition5,
            columnDefinition6});
            rowDefinition1.Height = 100D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            this.layoutControlGroup7.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1});
            this.layoutControlGroup7.Size = new System.Drawing.Size(855, 190);
            this.layoutControlGroup7.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this._gdSUB03;
            this.layoutControlItem5.Location = new System.Drawing.Point(266, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlItem5.Size = new System.Drawing.Size(141, 166);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this._gdSUB01;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(125, 166);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this._gdSUB02;
            this.layoutControlItem4.Location = new System.Drawing.Point(125, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem4.Size = new System.Drawing.Size(141, 166);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this._gdSUB05;
            this.layoutControlItem7.Location = new System.Drawing.Point(689, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.OptionsTableLayoutItem.ColumnIndex = 5;
            this.layoutControlItem7.Size = new System.Drawing.Size(142, 166);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._luT_USE_YN);
            this.layoutControl1.Controls.Add(this._luT_CONFIGURATION_MST_NAME);
            this.layoutControl1.Controls.Add(this._luT_CONFIGURATION_MST_CODE);
            this.layoutControl1.Controls.Add(this._gdMAIN);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(315, 700);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _luT_USE_YN
            // 
            this._luT_USE_YN.ItemIndex = -1;
            this._luT_USE_YN.Location = new System.Drawing.Point(235, 84);
            this._luT_USE_YN.Margin = new System.Windows.Forms.Padding(0);
            this._luT_USE_YN.Name = "_luT_USE_YN";
            this._luT_USE_YN.ReadOnly = false;
            this._luT_USE_YN.Size = new System.Drawing.Size(44, 20);
            this._luT_USE_YN.TabIndex = 7;
            // 
            // _luT_CONFIGURATION_MST_NAME
            // 
            this._luT_CONFIGURATION_MST_NAME.CancelButton = null;
            this._luT_CONFIGURATION_MST_NAME.CommandButton = null;
            this._luT_CONFIGURATION_MST_NAME.EditMask = "";
            this._luT_CONFIGURATION_MST_NAME.Location = new System.Drawing.Point(235, 60);
            this._luT_CONFIGURATION_MST_NAME.Margin = new System.Windows.Forms.Padding(0);
            this._luT_CONFIGURATION_MST_NAME.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luT_CONFIGURATION_MST_NAME.Name = "_luT_CONFIGURATION_MST_NAME";
            this._luT_CONFIGURATION_MST_NAME.NumText = "";
            this._luT_CONFIGURATION_MST_NAME.PasswordChar = '\0';
            this._luT_CONFIGURATION_MST_NAME.ReadOnly = false;
            this._luT_CONFIGURATION_MST_NAME.Size = new System.Drawing.Size(44, 20);
            this._luT_CONFIGURATION_MST_NAME.TabIndex = 6;
            this._luT_CONFIGURATION_MST_NAME.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luT_CONFIGURATION_MST_NAME.UseMaskAsDisplayFormat = false;
            // 
            // _luT_CONFIGURATION_MST_CODE
            // 
            this._luT_CONFIGURATION_MST_CODE.CancelButton = null;
            this._luT_CONFIGURATION_MST_CODE.CommandButton = null;
            this._luT_CONFIGURATION_MST_CODE.EditMask = "";
            this._luT_CONFIGURATION_MST_CODE.Location = new System.Drawing.Point(235, 36);
            this._luT_CONFIGURATION_MST_CODE.Margin = new System.Windows.Forms.Padding(0);
            this._luT_CONFIGURATION_MST_CODE.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luT_CONFIGURATION_MST_CODE.Name = "_luT_CONFIGURATION_MST_CODE";
            this._luT_CONFIGURATION_MST_CODE.NumText = "";
            this._luT_CONFIGURATION_MST_CODE.PasswordChar = '\0';
            this._luT_CONFIGURATION_MST_CODE.ReadOnly = false;
            this._luT_CONFIGURATION_MST_CODE.Size = new System.Drawing.Size(44, 20);
            this._luT_CONFIGURATION_MST_CODE.TabIndex = 5;
            this._luT_CONFIGURATION_MST_CODE.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luT_CONFIGURATION_MST_CODE.UseMaskAsDisplayFormat = false;
            // 
            // _gdMAIN
            // 
            this._gdMAIN.Location = new System.Drawing.Point(24, 120);
            this._gdMAIN.MainView = this._gdMAIN_VIEW;
            this._gdMAIN.Name = "_gdMAIN";
            this._gdMAIN.Size = new System.Drawing.Size(267, 556);
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
            this.layoutControlGroup3});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(315, 700);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlGroup4});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(295, 680);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this._gdMAIN;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(271, 560);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this._lciT_CONFIGURATION_MST_CODE,
            this._lciT_CONFIGURATION_MST_NAME,
            this._lciT_USE_YN});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(271, 96);
            this.layoutControlGroup4.TextVisible = false;
            // 
            // _lciT_CONFIGURATION_MST_CODE
            // 
            this._lciT_CONFIGURATION_MST_CODE.Control = this._luT_CONFIGURATION_MST_CODE;
            this._lciT_CONFIGURATION_MST_CODE.Location = new System.Drawing.Point(0, 0);
            this._lciT_CONFIGURATION_MST_CODE.MaxSize = new System.Drawing.Size(0, 24);
            this._lciT_CONFIGURATION_MST_CODE.MinSize = new System.Drawing.Size(246, 24);
            this._lciT_CONFIGURATION_MST_CODE.Name = "_lciT_CONFIGURATION_MST_CODE";
            this._lciT_CONFIGURATION_MST_CODE.Size = new System.Drawing.Size(247, 24);
            this._lciT_CONFIGURATION_MST_CODE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciT_CONFIGURATION_MST_CODE.TextSize = new System.Drawing.Size(196, 14);
            // 
            // _lciT_CONFIGURATION_MST_NAME
            // 
            this._lciT_CONFIGURATION_MST_NAME.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciT_CONFIGURATION_MST_NAME.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciT_CONFIGURATION_MST_NAME.Control = this._luT_CONFIGURATION_MST_NAME;
            this._lciT_CONFIGURATION_MST_NAME.Location = new System.Drawing.Point(0, 24);
            this._lciT_CONFIGURATION_MST_NAME.MaxSize = new System.Drawing.Size(0, 24);
            this._lciT_CONFIGURATION_MST_NAME.MinSize = new System.Drawing.Size(246, 24);
            this._lciT_CONFIGURATION_MST_NAME.Name = "_lciT_CONFIGURATION_MST_NAME";
            this._lciT_CONFIGURATION_MST_NAME.Size = new System.Drawing.Size(247, 24);
            this._lciT_CONFIGURATION_MST_NAME.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciT_CONFIGURATION_MST_NAME.TextSize = new System.Drawing.Size(196, 14);
            // 
            // _lciT_USE_YN
            // 
            this._lciT_USE_YN.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciT_USE_YN.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciT_USE_YN.Control = this._luT_USE_YN;
            this._lciT_USE_YN.Location = new System.Drawing.Point(0, 48);
            this._lciT_USE_YN.MaxSize = new System.Drawing.Size(0, 24);
            this._lciT_USE_YN.MinSize = new System.Drawing.Size(246, 24);
            this._lciT_USE_YN.Name = "_lciT_USE_YN";
            this._lciT_USE_YN.Size = new System.Drawing.Size(247, 24);
            this._lciT_USE_YN.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciT_USE_YN.TextSize = new System.Drawing.Size(196, 14);
            // 
            // _gdSUB04
            // 
            this._gdSUB04.Location = new System.Drawing.Point(431, 24);
            this._gdSUB04.MainView = this._gdSUB04_VIEW;
            this._gdSUB04.Name = "_gdSUB04";
            this._gdSUB04.Size = new System.Drawing.Size(137, 162);
            this._gdSUB04.TabIndex = 32;
            this._gdSUB04.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gdSUB04_VIEW});
            // 
            // _gdSUB04_VIEW
            // 
            this._gdSUB04_VIEW.GridControl = this._gdSUB04;
            this._gdSUB04_VIEW.Name = "_gdSUB04_VIEW";
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this._gdSUB04;
            this.layoutControlItem6.Location = new System.Drawing.Point(407, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.OptionsTableLayoutItem.ColumnIndex = 3;
            this.layoutControlItem6.Size = new System.Drawing.Size(141, 166);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // _gdSUB06
            // 
            this._gdSUB06.Location = new System.Drawing.Point(572, 24);
            this._gdSUB06.MainView = this._gdSUB06_VIEW;
            this._gdSUB06.Name = "_gdSUB06";
            this._gdSUB06.Size = new System.Drawing.Size(137, 162);
            this._gdSUB06.TabIndex = 33;
            this._gdSUB06.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gdSUB06_VIEW});
            // 
            // _gdSUB06_VIEW
            // 
            this._gdSUB06_VIEW.GridControl = this._gdSUB06;
            this._gdSUB06_VIEW.Name = "_gdSUB06_VIEW";
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this._gdSUB06;
            this.layoutControlItem8.Location = new System.Drawing.Point(548, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.OptionsTableLayoutItem.ColumnIndex = 4;
            this.layoutControlItem8.Size = new System.Drawing.Size(141, 166);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // ProcessRoutingRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProcessRoutingRegister";
            this.Text = "ProcessRoutingRegister";
            this.WindowName = "ProcessRoutingRegister";
            ((System.ComponentModel.ISupportInitialize)(this._pnHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pnContent)).EndInit();
            this._pnContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pnLeft)).EndInit();
            this._pnLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pnRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._ckCOPY.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdROUTING_MST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdROUTING)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdROUTING_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB05_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB03_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB02_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB01_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCONFIGURATION_MST_CODE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCONFIGURATION_MST_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCONFIGURATION_VEND_CODE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciUSE_YN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lcgPROCESS_CONFIGURATION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPROCESS_MST_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPROCESS_MST_CODE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciR_USE_YN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciT_CONFIGURATION_MST_CODE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciT_CONFIGURATION_MST_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciT_USE_YN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB04_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdSUB06_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl _gdMAIN;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdMAIN_VIEW;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl _gdSUB03;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdSUB03_VIEW;
        private DevExpress.XtraGrid.GridControl _gdSUB02;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdSUB02_VIEW;
        private DevExpress.XtraGrid.GridControl _gdSUB01;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdSUB01_VIEW;
        private DevExpress.XtraGrid.GridControl _gdSUB05;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdSUB05_VIEW;
        private CORE.BaseControls.ucLookUpEdit _luT_USE_YN;
        private CORE.BaseControls.ucTextEdit _luT_CONFIGURATION_MST_NAME;
        private CORE.BaseControls.ucTextEdit _luT_CONFIGURATION_MST_CODE;
        private DevExpress.XtraLayout.LayoutControlItem _lciT_CONFIGURATION_MST_CODE;
        private DevExpress.XtraLayout.LayoutControlItem _lciT_CONFIGURATION_MST_NAME;
        private DevExpress.XtraLayout.LayoutControlItem _lciT_USE_YN;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn routing_code;
        private DevExpress.XtraTreeList.Columns.TreeListColumn routing_name;
        private DevExpress.XtraTreeList.Columns.TreeListColumn routing_lvl;
        private DevExpress.XtraTreeList.Columns.TreeListColumn routing_dsp_seq;
        private DevExpress.XtraTreeList.Columns.TreeListColumn cur_path;
        private DevExpress.XtraTreeList.Columns.TreeListColumn p_routing_code;
        private DevExpress.XtraTreeList.Columns.TreeListColumn use_yn;
        private CORE.BaseControls.ucSimpleButton _ucbtROUTING_SAVE;
        private CORE.BaseControls.ucSimpleButton _ucbtPROCESS_SAVE;
        private DevExpress.XtraGrid.GridControl _gdROUTING;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdROUTING_VIEW;
        private CORE.BaseControls.ucTextEdit _luCONFIGURATION_MST_NAME;
        private CORE.BaseControls.ucTextEdit _luCONFIGURATION_MST_CODE;
        private CORE.BaseControls.ucLookUpEdit _luUSE_YN;
        private DevExpress.XtraGrid.GridControl _gdROUTING_MST;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
        private DevExpress.XtraGrid.Columns.TileViewColumn tCONFIGURATION_CODE;
        private DevExpress.XtraGrid.Columns.TileViewColumn tCONFIGURATION_NAME;
        private DevExpress.XtraTreeList.Columns.TreeListColumn used_configuration;
        private DevExpress.XtraTreeList.Columns.TreeListColumn ranking_code;
        private CORE.BaseControls.ucLookUpEdit _luR_USE_YN;
        private DevExpress.XtraEditors.CheckEdit _ckCOPY;
        private CORE.BaseControls.ucTextEdit _luPROCESS_MST_CODE;
        private CORE.BaseControls.ucTextEdit _luPROCESS_MST_NAME;
        private DevExpress.XtraGrid.Columns.TileViewColumn tROUTING_REVISION_NO;
        private CORE.BaseControls.ucTextEdit _luCONFIGURATION_VEND_CODE;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup6;
        private DevExpress.XtraLayout.LayoutControlItem _lciCONFIGURATION_MST_CODE;
        private DevExpress.XtraLayout.LayoutControlItem _lciCONFIGURATION_MST_NAME;
        private DevExpress.XtraLayout.LayoutControlItem _lciUSE_YN;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem _lciCONFIGURATION_VEND_CODE;
        private DevExpress.XtraLayout.LayoutControlGroup _lcgPROCESS_CONFIGURATION;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.LayoutControlItem _lciR_USE_YN;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem16;
        private DevExpress.XtraLayout.LayoutControlItem _lciPROCESS_MST_NAME;
        private DevExpress.XtraLayout.LayoutControlItem _lciPROCESS_MST_CODE;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Columns.TileViewColumn tCONFIGURATION_SEQ;
        private DevExpress.XtraGrid.Columns.TileViewColumn tCRUD;
        private CORE.BaseControls.ucSimpleButton _ucbtPART_MAPPING;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.GridControl _gdSUB06;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdSUB06_VIEW;
        private DevExpress.XtraGrid.GridControl _gdSUB04;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdSUB04_VIEW;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    }
}
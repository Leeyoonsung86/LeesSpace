namespace CoFAS_MES.POP.UserControls
{
    partial class ucGatheringCtl
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.USAList = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ConvertData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._TProcessName = new System.Windows.Forms.Label();
            this._gdMAIN = new DevExpress.XtraGrid.GridControl();
            this.tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.USAList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this._TProcessName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._gdMAIN, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.88889F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(288, 330);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // USAList
            // 
            this.USAList.BackColor = System.Drawing.Color.Black;
            this.USAList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.USAList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.ConvertData});
            this.USAList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.USAList.ForeColor = System.Drawing.Color.Lime;
            this.USAList.Location = new System.Drawing.Point(111, 41);
            this.USAList.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.USAList.Name = "USAList";
            this.USAList.Size = new System.Drawing.Size(176, 285);
            this.USAList.TabIndex = 5;
            this.USAList.UseCompatibleStateImageBehavior = false;
            this.USAList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Read Time";
            this.columnHeader7.Width = 90;
            // 
            // ConvertData
            // 
            this.ConvertData.Text = "Convert Data";
            this.ConvertData.Width = 240;
            // 
            // _TProcessName
            // 
            this._TProcessName.AutoSize = true;
            this._TProcessName.Dock = System.Windows.Forms.DockStyle.Fill;
            this._TProcessName.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this._TProcessName.Location = new System.Drawing.Point(114, 1);
            this._TProcessName.Name = "_TProcessName";
            this._TProcessName.Size = new System.Drawing.Size(170, 36);
            this._TProcessName.TabIndex = 0;
            this._TProcessName.Text = "label1";
            this._TProcessName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _gdMAIN
            // 
            this._gdMAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gdMAIN.Location = new System.Drawing.Point(1, 1);
            this._gdMAIN.MainView = this.tileView1;
            this._gdMAIN.Margin = new System.Windows.Forms.Padding(0);
            this._gdMAIN.Name = "_gdMAIN";
            this.tableLayoutPanel1.SetRowSpan(this._gdMAIN, 2);
            this._gdMAIN.Size = new System.Drawing.Size(109, 328);
            this._gdMAIN.TabIndex = 4;
            this._gdMAIN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView1});
            this._gdMAIN.Click += new System.EventHandler(this._gdMAIN_Click);
            // 
            // tileView1
            // 
            this.tileView1.ContextButtonOptions.BottomPanelPadding = new System.Windows.Forms.Padding(0);
            this.tileView1.ContextButtonOptions.CenterPanelPadding = new System.Windows.Forms.Padding(0);
            this.tileView1.ContextButtonOptions.FarPanelPadding = new System.Windows.Forms.Padding(0);
            this.tileView1.ContextButtonOptions.NearPanelPadding = new System.Windows.Forms.Padding(0);
            this.tileView1.ContextButtonOptions.TopPanelPadding = new System.Windows.Forms.Padding(0);
            this.tileView1.GridControl = this._gdMAIN;
            this.tileView1.Name = "tileView1";
            this.tileView1.OptionsTiles.ItemPadding = new System.Windows.Forms.Padding(0);
            this.tileView1.OptionsTiles.ItemSize = new System.Drawing.Size(50, 50);
            this.tileView1.OptionsTiles.Padding = new System.Windows.Forms.Padding(0);
            this.tileView1.OptionsTiles.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.None;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // ucGatheringCtl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucGatheringCtl";
            this.Size = new System.Drawing.Size(288, 330);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label _TProcessName;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.GridControl _gdMAIN;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
        private System.Windows.Forms.ListView USAList;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader ConvertData;
    }
}

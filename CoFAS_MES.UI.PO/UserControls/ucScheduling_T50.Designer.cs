namespace CoFAS_MES.UI.PO.UserControls
{
    partial class ucScheduling_T50
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._gdMAIN = new DevExpress.XtraGrid.GridControl();
            this._gdMAIN_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblequi = new System.Windows.Forms.Label();
            this.picUp = new System.Windows.Forms.PictureBox();
            this.picDown = new System.Windows.Forms.PictureBox();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this._gdMAIN, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblequi, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.picUp, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.picDown, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.picDelete, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(295, 268);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _gdMAIN
            // 
            this.tableLayoutPanel1.SetColumnSpan(this._gdMAIN, 4);
            this._gdMAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gdMAIN.Location = new System.Drawing.Point(0, 30);
            this._gdMAIN.MainView = this._gdMAIN_VIEW;
            this._gdMAIN.Margin = new System.Windows.Forms.Padding(0);
            this._gdMAIN.Name = "_gdMAIN";
            this._gdMAIN.Size = new System.Drawing.Size(295, 238);
            this._gdMAIN.TabIndex = 5;
            this._gdMAIN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gdMAIN_VIEW});
            // 
            // _gdMAIN_VIEW
            // 
            this._gdMAIN_VIEW.GridControl = this._gdMAIN;
            this._gdMAIN_VIEW.Name = "_gdMAIN_VIEW";
            // 
            // lblequi
            // 
            this.lblequi.AutoSize = true;
            this.lblequi.BackColor = System.Drawing.Color.White;
            this.lblequi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblequi.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblequi.Location = new System.Drawing.Point(0, 0);
            this.lblequi.Margin = new System.Windows.Forms.Padding(0);
            this.lblequi.Name = "lblequi";
            this.lblequi.Size = new System.Drawing.Size(235, 30);
            this.lblequi.TabIndex = 0;
            this.lblequi.Text = "설비명";
            this.lblequi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picUp
            // 
            this.picUp.BackColor = System.Drawing.Color.White;
            this.picUp.BackgroundImage = global::CoFAS_MES.UI.PO.Properties.Resources._24x_up;
            this.picUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picUp.Location = new System.Drawing.Point(235, 0);
            this.picUp.Margin = new System.Windows.Forms.Padding(0);
            this.picUp.Name = "picUp";
            this.picUp.Size = new System.Drawing.Size(20, 30);
            this.picUp.TabIndex = 6;
            this.picUp.TabStop = false;
            this.picUp.Click += new System.EventHandler(this.picUp_Click);
            // 
            // picDown
            // 
            this.picDown.BackColor = System.Drawing.Color.White;
            this.picDown.BackgroundImage = global::CoFAS_MES.UI.PO.Properties.Resources._24x_down;
            this.picDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picDown.Location = new System.Drawing.Point(255, 0);
            this.picDown.Margin = new System.Windows.Forms.Padding(0);
            this.picDown.Name = "picDown";
            this.picDown.Size = new System.Drawing.Size(20, 30);
            this.picDown.TabIndex = 7;
            this.picDown.TabStop = false;
            this.picDown.Click += new System.EventHandler(this.picDown_Click);
            // 
            // picDelete
            // 
            this.picDelete.BackColor = System.Drawing.Color.White;
            this.picDelete.BackgroundImage = global::CoFAS_MES.UI.PO.Properties.Resources._24x_delete;
            this.picDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picDelete.Location = new System.Drawing.Point(275, 0);
            this.picDelete.Margin = new System.Windows.Forms.Padding(0);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(20, 30);
            this.picDelete.TabIndex = 8;
            this.picDelete.TabStop = false;
            this.picDelete.Click += new System.EventHandler(this.picDelete_Click);
            // 
            // ucScheduling_T50
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucScheduling_T50";
            this.Size = new System.Drawing.Size(295, 268);
            this.Load += new System.EventHandler(this.ucScheduling_T50_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblequi;
        private DevExpress.XtraGrid.GridControl _gdMAIN;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdMAIN_VIEW;
        private System.Windows.Forms.PictureBox picUp;
        private System.Windows.Forms.PictureBox picDown;
        private System.Windows.Forms.PictureBox picDelete;
    }
}

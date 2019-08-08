namespace CoFAS_MES.CORE.BaseControls
{
    partial class ucFromToDateEdit
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
            this._pFromDateEdit = new DevExpress.XtraEditors.DateEdit();
            this._pLabelControl = new DevExpress.XtraEditors.LabelControl();
            this._pToDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this._pFromDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pFromDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pToDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pToDateEdit.Properties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _pFromDateEdit
            // 
            this._pFromDateEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pFromDateEdit.EditValue = null;
            this._pFromDateEdit.Location = new System.Drawing.Point(0, 0);
            this._pFromDateEdit.Margin = new System.Windows.Forms.Padding(0);
            this._pFromDateEdit.Name = "_pFromDateEdit";
            this._pFromDateEdit.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Yellow;
            this._pFromDateEdit.Properties.AppearanceFocused.Options.UseBackColor = true;
            this._pFromDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._pFromDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._pFromDateEdit.Size = new System.Drawing.Size(131, 20);
            this._pFromDateEdit.TabIndex = 0;
            // 
            // _pLabelControl
            // 
            this._pLabelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pLabelControl.Location = new System.Drawing.Point(131, 0);
            this._pLabelControl.Margin = new System.Windows.Forms.Padding(0);
            this._pLabelControl.Name = "_pLabelControl";
            this._pLabelControl.Size = new System.Drawing.Size(10, 19);
            this._pLabelControl.TabIndex = 1;
            this._pLabelControl.Text = "~";
            // 
            // _pToDateEdit
            // 
            this._pToDateEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pToDateEdit.EditValue = null;
            this._pToDateEdit.Location = new System.Drawing.Point(141, 0);
            this._pToDateEdit.Margin = new System.Windows.Forms.Padding(0);
            this._pToDateEdit.Name = "_pToDateEdit";
            this._pToDateEdit.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Yellow;
            this._pToDateEdit.Properties.AppearanceFocused.Options.UseBackColor = true;
            this._pToDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._pToDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._pToDateEdit.Size = new System.Drawing.Size(131, 20);
            this._pToDateEdit.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel1.Controls.Add(this._pLabelControl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._pToDateEdit, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this._pFromDateEdit, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(272, 19);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // ucFromToDateEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucFromToDateEdit";
            this.Size = new System.Drawing.Size(272, 19);
            ((System.ComponentModel.ISupportInitialize)(this._pFromDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pFromDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pToDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pToDateEdit.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit _pFromDateEdit;
        private DevExpress.XtraEditors.LabelControl _pLabelControl;
        private DevExpress.XtraEditors.DateEdit _pToDateEdit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

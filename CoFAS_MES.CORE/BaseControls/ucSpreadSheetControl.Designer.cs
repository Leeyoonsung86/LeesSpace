namespace CoFAS_MES.CORE.BaseControls
{
    partial class ucSpreadSheetControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSpreadSheetControl));
            this._pSpreadSheetControl = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this._pSpreadSheetFormulaBarControl = new DevExpress.XtraSpreadsheet.SpreadsheetFormulaBarControl();
            this._pSpreadSheetNameBoxControl = new DevExpress.XtraSpreadsheet.SpreadsheetNameBoxControl();
            this._pTopControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            ((System.ComponentModel.ISupportInitialize)(this._pSpreadSheetNameBoxControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pTopControl)).BeginInit();
            this._pTopControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // _pSpreadSheetControl
            // 
            this._pSpreadSheetControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pSpreadSheetControl.Location = new System.Drawing.Point(0, 27);
            this._pSpreadSheetControl.Name = "_pSpreadSheetControl";
            this._pSpreadSheetControl.Options.Import.Csv.Encoding = ((System.Text.Encoding)(resources.GetObject("_pSpreadSheetControl.Options.Import.Csv.Encoding")));
            this._pSpreadSheetControl.Options.Import.Txt.Encoding = ((System.Text.Encoding)(resources.GetObject("_pSpreadSheetControl.Options.Import.Txt.Encoding")));
            this._pSpreadSheetControl.Size = new System.Drawing.Size(700, 373);
            this._pSpreadSheetControl.TabIndex = 0;
            this._pSpreadSheetControl.Text = "spreadsheetControl1";
            // 
            // _pSpreadSheetFormulaBarControl
            // 
            this._pSpreadSheetFormulaBarControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pSpreadSheetFormulaBarControl.Location = new System.Drawing.Point(0, 0);
            this._pSpreadSheetFormulaBarControl.MinimumSize = new System.Drawing.Size(0, 22);
            this._pSpreadSheetFormulaBarControl.Name = "_pSpreadSheetFormulaBarControl";
            this._pSpreadSheetFormulaBarControl.Size = new System.Drawing.Size(550, 22);
            this._pSpreadSheetFormulaBarControl.SpreadsheetControl = this._pSpreadSheetControl;
            this._pSpreadSheetFormulaBarControl.TabIndex = 0;
            // 
            // _pSpreadSheetNameBoxControl
            // 
            this._pSpreadSheetNameBoxControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pSpreadSheetNameBoxControl.EditValue = "A1";
            this._pSpreadSheetNameBoxControl.Location = new System.Drawing.Point(0, 0);
            this._pSpreadSheetNameBoxControl.MinimumSize = new System.Drawing.Size(0, 20);
            this._pSpreadSheetNameBoxControl.Name = "_pSpreadSheetNameBoxControl";
            this._pSpreadSheetNameBoxControl.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11F);
            this._pSpreadSheetNameBoxControl.Properties.Appearance.Options.UseFont = true;
            this._pSpreadSheetNameBoxControl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._pSpreadSheetNameBoxControl.Size = new System.Drawing.Size(145, 24);
            this._pSpreadSheetNameBoxControl.SpreadsheetControl = this._pSpreadSheetControl;
            this._pSpreadSheetNameBoxControl.TabIndex = 0;
            // 
            // _pTopControl
            // 
            this._pTopControl.Dock = System.Windows.Forms.DockStyle.Top;
            this._pTopControl.Location = new System.Drawing.Point(0, 0);
            this._pTopControl.MinimumSize = new System.Drawing.Size(0, 22);
            this._pTopControl.Name = "_pTopControl";
            this._pTopControl.Panel1.Controls.Add(this._pSpreadSheetNameBoxControl);
            this._pTopControl.Panel2.Controls.Add(this._pSpreadSheetFormulaBarControl);
            this._pTopControl.Size = new System.Drawing.Size(700, 22);
            this._pTopControl.SplitterPosition = 145;
            this._pTopControl.TabIndex = 2;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterControl1.Location = new System.Drawing.Point(0, 22);
            this.splitterControl1.MinSize = 20;
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(700, 5);
            this.splitterControl1.TabIndex = 1;
            this.splitterControl1.TabStop = false;
            // 
            // ucSpreadSheetControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._pSpreadSheetControl);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this._pTopControl);
            this.Name = "ucSpreadSheetControl";
            this.Size = new System.Drawing.Size(700, 400);
            ((System.ComponentModel.ISupportInitialize)(this._pSpreadSheetNameBoxControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pTopControl)).EndInit();
            this._pTopControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraSpreadsheet.SpreadsheetControl _pSpreadSheetControl;
        private DevExpress.XtraSpreadsheet.SpreadsheetFormulaBarControl _pSpreadSheetFormulaBarControl;
        private DevExpress.XtraSpreadsheet.SpreadsheetNameBoxControl _pSpreadSheetNameBoxControl;
        private DevExpress.XtraEditors.SplitContainerControl _pTopControl;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
    }
}

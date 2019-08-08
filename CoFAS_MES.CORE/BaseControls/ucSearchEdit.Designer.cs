namespace CoFAS_MES.CORE.BaseControls
{
    partial class ucSearchEdit
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this._pCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this._pNameButtonEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this._pCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pNameButtonEdit.Properties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _pCodeTextEdit
            // 
            this._pCodeTextEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pCodeTextEdit.Location = new System.Drawing.Point(0, 0);
            this._pCodeTextEdit.Margin = new System.Windows.Forms.Padding(0);
            this._pCodeTextEdit.Name = "_pCodeTextEdit";
            this._pCodeTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this._pCodeTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this._pCodeTextEdit.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Tomato;
            this._pCodeTextEdit.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this._pCodeTextEdit.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Yellow;
            this._pCodeTextEdit.Properties.AppearanceFocused.Options.UseBackColor = true;
            this._pCodeTextEdit.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this._pCodeTextEdit.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this._pCodeTextEdit.Size = new System.Drawing.Size(100, 20);
            this._pCodeTextEdit.TabIndex = 0;
            // 
            // _pNameButtonEdit
            // 
            this._pNameButtonEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pNameButtonEdit.Location = new System.Drawing.Point(105, 0);
            this._pNameButtonEdit.Margin = new System.Windows.Forms.Padding(0);
            this._pNameButtonEdit.Name = "_pNameButtonEdit";
            this._pNameButtonEdit.Properties.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this._pNameButtonEdit.Properties.Appearance.Options.UseBackColor = true;
            this._pNameButtonEdit.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro;
            this._pNameButtonEdit.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this._pNameButtonEdit.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Yellow;
            this._pNameButtonEdit.Properties.AppearanceFocused.Options.UseBackColor = true;
            this._pNameButtonEdit.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this._pNameButtonEdit.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            editorButtonImageOptions1.Image = global::CoFAS_MES.CORE.Properties.Resources.zoom_16x16;
            this._pNameButtonEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this._pNameButtonEdit.Size = new System.Drawing.Size(150, 22);
            this._pNameButtonEdit.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Controls.Add(this._pCodeTextEdit, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._pNameButtonEdit, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(255, 20);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // ucSearchEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucSearchEdit";
            this.Size = new System.Drawing.Size(255, 20);
            ((System.ComponentModel.ISupportInitialize)(this._pCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pNameButtonEdit.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit _pCodeTextEdit;
        private DevExpress.XtraEditors.ButtonEdit _pNameButtonEdit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

namespace CoFAS_MES.CORE.BaseControls
{
    partial class ucButtonEdit
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
            this._pButtonEdit = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this._pButtonEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // _pButtonEdit
            // 
            this._pButtonEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pButtonEdit.EditValue = "";
            this._pButtonEdit.Location = new System.Drawing.Point(0, 0);
            this._pButtonEdit.Margin = new System.Windows.Forms.Padding(0);
            this._pButtonEdit.Name = "_pButtonEdit";
            this._pButtonEdit.Properties.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this._pButtonEdit.Properties.Appearance.Options.UseBackColor = true;
            this._pButtonEdit.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro;
            this._pButtonEdit.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this._pButtonEdit.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Yellow;
            this._pButtonEdit.Properties.AppearanceFocused.Options.UseBackColor = true;
            this._pButtonEdit.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this._pButtonEdit.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            editorButtonImageOptions1.Image = global::CoFAS_MES.CORE.Properties.Resources.zoom_16x16;
            this._pButtonEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this._pButtonEdit.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._pButtonEdit.Size = new System.Drawing.Size(150, 22);
            this._pButtonEdit.TabIndex = 0;
            // 
            // ucButtonEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this._pButtonEdit);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucButtonEdit";
            this.Size = new System.Drawing.Size(150, 22);
            ((System.ComponentModel.ISupportInitialize)(this._pButtonEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ButtonEdit _pButtonEdit;
    }
}

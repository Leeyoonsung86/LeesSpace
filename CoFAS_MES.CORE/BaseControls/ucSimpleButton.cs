using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoFAS_MES.CORE.Function;
using DevExpress.XtraEditors;

namespace CoFAS_MES.CORE.BaseControls
{
    public partial class ucSimpleButton : UserControl
    {
        public new event OnClickEventHandler Click;
        public delegate void OnClickEventHandler(object sender, EventArgs e);

        public new bool Enabled
        {
            get
            {
                return _pSimpleButton.Enabled;
            }
            set
            {
                _pSimpleButton.Enabled = value;
            }
        }

        public new bool Visible
        {
            get
            {
                return _pSimpleButton.Visible;
            }
            set
            {
                _pSimpleButton.Visible = value;
            }
        }

        public int FontSize
        {
            get
            {
                return _pSimpleButton.Appearance.FontSizeDelta;
            }
            set
            {
                _pSimpleButton.Appearance.FontSizeDelta = value;
            }
        }

        public Image Image
        {
            get
            {
                return _pSimpleButton.ImageOptions.Image;
            }
            set
            {
                _pSimpleButton.ImageOptions.Image = value;
            }
        }


        public new Color ForeColor
        {
            get
            {
                return _pSimpleButton.Appearance.ForeColor;
            }
            set
            {
                _pSimpleButton.Appearance.ForeColor = value;
            }
        }

        public new Color BackColor
        {
            get
            {
                return _pSimpleButton.Appearance.BackColor;
            }
            set
            {
                _pSimpleButton.Appearance.BackColor = value;
            }
        }

        public ImageAlignToText ImageToTextAlignment
        {
            get
            {
                return _pSimpleButton.ImageOptions.ImageToTextAlignment;
            }
            set
            {
                     _pSimpleButton.ImageOptions.ImageToTextAlignment = value;
            }
        }


        public string ButtonText
        {
            get
            {
                return _pSimpleButton.Text.ToString();
            }
            set
            {
                _pSimpleButton.Text = value;
            }
        }

        public override string Text
        {
            get
            {
                return _pSimpleButton.Text.ToString();
            }
            set
            {
                _pSimpleButton.Text = value;
            }
        }

        public ucSimpleButton()
        {
            InitializeComponent();

            Initialize();
        }

        #region 초기화 하기 - Initialize()

        /// <summary>
        /// 초기화 하기
        /// </summary>
        protected virtual void Initialize()
        {
            try
            {

                _pSimpleButton.Click += new EventHandler(this._pSimpleButton_Click);
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "Initialize()",
                    pException
                );
            }
        }
        #endregion

        private void _pSimpleButton_Click(object sender, EventArgs e)
        {
            if (Click != null)
                Click(this, e);
        }
    }
}

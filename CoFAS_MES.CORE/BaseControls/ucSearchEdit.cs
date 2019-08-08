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
using DevExpress.XtraEditors.Controls;

namespace CoFAS_MES.CORE.BaseControls
{
    public partial class ucSearchEdit : UserControl
    {

        public event OnButtonPressedEventHandler _OnButtonPressed;
        public delegate void OnButtonPressedEventHandler(object sender, ButtonPressedEventArgs e);

        public event OnOpenClickEventHandler _OnOpenClick;
        public delegate void OnOpenClickEventHandler(object sender, EventArgs e);

        public bool CodeReadOnly
        {
            get
            {
                return _pCodeTextEdit.Properties.ReadOnly;
            }
            set
            {
                _pCodeTextEdit.Properties.ReadOnly = value;
            }
        }

        public bool NameReadOnly
        {
            get
            {
                return _pNameButtonEdit.Properties.ReadOnly;
            }
            set
            {
                _pNameButtonEdit.Properties.ReadOnly = value;
            }
        }

        public bool NameEnabled
        {
            get
            {
                return _pNameButtonEdit.Enabled;
            }
            set
            {
                _pNameButtonEdit.Enabled = value;
                _pNameButtonEdit.ForeColor = Color.FromArgb(32, 31, 53);
            }
        }

        public string CodeText
        {
            get
            {
                return _pCodeTextEdit.Text.ToString();
            }
            set
            {
                _pCodeTextEdit.Text = value;
            }
        }

        public string CodeTextName
        {
            get
            {
                return _pCodeTextEdit.Name.ToString();
            }
            set
            {
                _pCodeTextEdit.Name = value;
            }
        }

        public string NameTextName
        {
            get
            {
                return _pNameButtonEdit.Name.ToString();
            }
            set
            {
                _pNameButtonEdit.Name = value;
            }
        }

        public string NameText
        {
            get
            {
                return _pNameButtonEdit.Text.ToString();
            }
            set
            {
                _pNameButtonEdit.Text = value;
            }
        }

        public ucSearchEdit()
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

                _pCodeTextEdit.Properties.AutoHeight = false;

                _pNameButtonEdit.Properties.AutoHeight = false;

                _pNameButtonEdit.ButtonPressed += new ButtonPressedEventHandler(_pButtonEdit_ButtonPressed);

                _pNameButtonEdit.Properties.Buttons[0].Click += ucOpen_Click;

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
        private void ucOpen_Click(object sender, EventArgs e)
        {
            if (_OnOpenClick != null)
                _OnOpenClick(this, e);
        }

        private void _pButtonEdit_ButtonPressed(object pSender, ButtonPressedEventArgs e)
        {
            try
            {
                if (_OnButtonPressed != null)
                    _OnButtonPressed(this, e);

            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "_pButtonEdit_Click(object pSender, ButtonPressedEventArgs pEventArgs)",
                    pException
                );
            }
        }
    }
}

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
    public partial class ucButtonEdit : UserControl
    {

        public event OnButtonPressedEventHandler _OnButtonPressed;
        public delegate void OnButtonPressedEventHandler(object sender, ButtonPressedEventArgs e);

        public event OnOpenClickEventHandler _OnOpenClick;
        public delegate void OnOpenClickEventHandler(object sender, EventArgs e);

        public bool ReadOnly
        {
            get
            {
                return _pButtonEdit.Properties.ReadOnly;
            }
            set
            {
                _pButtonEdit.Properties.ReadOnly = value;
            }
        }

        public new string Text
        {
            get
            {
                return _pButtonEdit.Text.ToString();
            }
            set
            {
                _pButtonEdit.Text = value;
            }
        }

        public new bool Enabled
        {
            get
            {
                return _pButtonEdit.Enabled;
            }
            set
            {
                _pButtonEdit.Enabled = value;
                _pButtonEdit.ForeColor = Color.FromArgb(32, 31, 53);
            }
        }

        public ucButtonEdit()
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

                _pButtonEdit.Properties.AutoHeight = false;

                _pButtonEdit.ButtonPressed += new ButtonPressedEventHandler(_pButtonEdit_ButtonPressed);

                _pButtonEdit.Properties.Buttons[0].Click += ucOpen_Click;
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

                //CoFAS_MES.CORE.UserForm.frmPageSetting xfrmPageSetting = new CORE.UserForm.frmPageSetting();
                ////xfrmPageSetting.PASS_CORP_CODE = _pCORP_CODE;
                ////xfrmPageSetting.PASS_PARENT_WINDOW_NAME = _pWINDOW_NAME;
                ////xfrmPageSetting.PASS_USER_CODE = _pUSER_CODE;
                ////xfrmPageSetting.PASS_PARENT_LANGUAGE = _pLANGUAGE_TYPE;
                ////xfrmPageSetting.PASS_PARENT_FONT = _pFONT_TYPE;
                //if (xfrmPageSetting.ShowDialog() == DialogResult.OK)
                //{
                //    _pButtonEdit.Text = "";


                //}

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

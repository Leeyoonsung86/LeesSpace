using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CoFAS_MES.CORE.BaseForm;
using CoFAS_MES.CORE.Function;

namespace CoFAS_MES.CORE.UserForm
{
    public partial class frmVerifyPermissions : frmBaseSingleNone
    {
        private static string _pCORP_CODE = string.Empty;       // 회사코드       
        private static string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)     
        private static string _pWINDOW_NAME = string.Empty;     // 화면명칭 
        private static string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어
        private static Font fntPARENT_FONT = null;

        //암호화 솔트 추가
        private byte[] saltBytes = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };

        private string strPermissionCode = "admin!@#$";

        private string strMsg = "";

        public static string CORP_CDDE
        {
            get { return _pCORP_CODE; }
            set { _pCORP_CODE = value; }
        }
        public static string USER_CODE
        {
            get { return _pUSER_CODE; }
            set { _pUSER_CODE = value; }
        }
        public static string LANGUAGE_TYPE
        {
            get { return _pLANGUAGE_TYPE; }
            set { _pLANGUAGE_TYPE = value; }
        }
        public static Font FONT_TYPE
        {
            get { return fntPARENT_FONT; }
            set { fntPARENT_FONT = value; }
        }

        public bool isReturnGrant = false;

        public frmVerifyPermissions()
        {
            InitializeComponent();
        }

        private void frmVerifyPermissions_Load(object sender, EventArgs e)
        {
            _btVERIFY.Text = Resources.Language._btVERIFY;
            _btVERIFY_CLOSE.Text = Resources.Language._btVERIFY_CLOSE;
            strMsg = Resources.Language._msgVERIFY;
        }

        private void _ucbtVERIFY_Click(object sender, EventArgs e)
        {
            string strEncrypt = "";
            string strDecrypt = "";
            strEncrypt = CoFAS_AES256Encrypt.EncryptToString(_luPERMISSIONS.Text.ToString(), "COEVER", saltBytes, false);

            strDecrypt = CoFAS_AES256Encrypt.DecryptToString(strEncrypt, "COEVER", saltBytes, false);

            if(strDecrypt == strPermissionCode)
            {
                isReturnGrant = true;
                Close();
            }
            else
            {
                CoFAS_DevExpressManager.ShowInformationMessage(strMsg);
            }
        }

        private void _ucbtVERIFY_CLOSE_Click(object sender, EventArgs e)
        {
            isReturnGrant = false;
            Close();
        }



        private void _luPERMISSIONS_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                //엔터키
                if (e.KeyCode == Keys.Enter)
                    _ucbtVERIFY_Click(null, null);
            }
            catch
            {

            }
        }
    }
}

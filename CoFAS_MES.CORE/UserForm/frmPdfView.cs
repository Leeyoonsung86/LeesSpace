using CoFAS_MES.CORE.BaseForm;
using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.Function;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoFAS_MES.CORE.UserForm
{
    public partial class frmPdfView : frmBaseSingle
    {
        private static string _pCORP_CODE = string.Empty;       // 회사코드       
        private static string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)     
        private static string _pWINDOW_NAME = string.Empty;     // 화면명칭 
        private static string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어

        private static Font fntPARENT_FONT = null;

        private string _pFindControl = "";

        private static FileStream _pStream = null;
        private static MemoryStream _pStream2 = null;

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

        public static FileStream FILE_STREAM
        {
            get { return _pStream; }
            set { _pStream = value; }
        }

        public static MemoryStream MS
        {
            get { return _pStream2; }
            set { _pStream2 = value; }
        } 

        public frmPdfView()
        {
            InitializeComponent();

            _pWINDOW_NAME = this.Name.ToString();

            InitializeSetting();
            //20181213 메모리스트림 처리 추가
            if (_pStream != null)
            {
                _pdfViewer.LoadDocument(_pStream);
            }
            else
            {
                _pdfViewer.LoadDocument(_pStream2);
            }

        }

        private void InitializeSetting()
        {
            //화면 설정 언어 & 명칭 변경. ==고정==
            DataTable dtLanguage = new LanguageBusiness().Language_Info(_pWINDOW_NAME, _pLANGUAGE_TYPE);

            if (dtLanguage != null && dtLanguage.Rows.Count > 0)
            {
                CoFAS_ControlManager.Language_Info(dtLanguage, this);
            }
        }
    }
}

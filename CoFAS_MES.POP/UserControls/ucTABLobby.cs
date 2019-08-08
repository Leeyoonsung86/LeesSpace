using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoFAS_MES.CORE.Business;
using CoFAS_MES.POP.Business;
using CoFAS_MES.CORE.Function;
using CoFAS_MES.POP.Entity;
using CoFAS_MES.CORE.Entity;
using DevExpress.XtraGrid.Views.Grid;

using CoFAS_MES.POP;

namespace CoFAS_MES.UI.POP.UserControls
{
    public partial class ucTABLobby : UserControl
    {
        public MessageEntity _pMessageEntity = null; //공통 메세지 엔티티

        private static string _pCORP_CODE = string.Empty;       // 회사코드       
        private static string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        private static string _pWINDOW_NAME = string.Empty;     // 화면명칭
        private static string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어

        private ucTABLobbyEntity _pucTABLobbyEntity = null; // 엔티티 생성

        private UserEntity _pUserEntity = null;

        private static Font fntPARENT_FONT = null;       // 시스템 폰트 설정

        private static object[] _pARRAY = null;
        private static object[] _pARRAY_CODE = null;
        private string _pCRUD = ""; //CRUD

        public frmTABMain _pfrmTABMain = null;

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

        public static object[] ARRAY
        {
            get { return _pARRAY; }
            set { _pARRAY = value; }
        }
        public static object[] ARRAY_CODE
        {
            get { return _pARRAY_CODE; }
            set { _pARRAY_CODE = value; }
        }

        private DataTable _dtList = null; //조회 데이터 리스트

        private DataTable _dtreturn = null; // 선택 데이터 리턴

        public DataTable dtReturn
        {
            get
            {
                return _dtreturn;
            }
            set
            {
                _dtreturn = value;
            }
        }

        public ucTABLobby(UserEntity pUserEntity, frmTABMain main)
        {
            _pUserEntity = pUserEntity;

            this._pfrmTABMain = main;

            InitializeComponent();

            _pWINDOW_NAME = this.Name.ToString();
        }

        private void ucTABLobby_Load(object sender, EventArgs e)
        {
            try
            {
                InitializeSetting();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {
                DevExpress.Utils.AppearanceObject.DefaultFont = fntPARENT_FONT;//화면에 모든 항목 폰트 재설정
            }
        }

        private void InitializeSetting()
        {
            //메뉴 화면 엔티티 설정
            _pucTABLobbyEntity = new ucTABLobbyEntity();
            _pucTABLobbyEntity.CORP_CODE = _pCORP_CODE;
            _pucTABLobbyEntity.USER_CODE = _pUSER_CODE;
            _pucTABLobbyEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;

            DateTime pDateTime = DateTime.Today;
            DateTime pFirstDateTime = pDateTime.AddDays(1 - pDateTime.Day);
        }

        //닫기버튼
        public static event OnClickEventHandler _Close_Click;
        public delegate void OnClickEventHandler(object sender, EventArgs e);
        private void _btCancle_Click(object sender, EventArgs e)
        {
            if (_Close_Click != null)
                _Close_Click(sender, e);
        }

        private void _ClickEvent(object sender, EventArgs e)
        {
            var sn = (dynamic)sender;
            string nm = sn.Name;
            string name = nm.Substring(3, nm.Length - 3);

            string windowName = null;

            switch (name)
            {
                case "SEARCH":

                    windowName = "TABSearch";

                    break;

                case "REGISTER":

                    windowName = "TABRegister";

                    break;

                case "COMMENT":

                    windowName = "TABComment";

                    break;

                case "EXCEL":

                    windowName = "TABExcel";

                    break;
                case "EQUIPMENT":

                    windowName = "TABEquipment";

                    break;
            }

            _pfrmTABMain.USER_CONTROL_CHANGE = windowName;
        }
    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevExpress.XtraGrid.Views.Grid;
using CoFAS_MES.CORE.BaseForm;
using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.Function;

using CoFAS_MES.UI.IM.Entity;
using CoFAS_MES.UI.IM.Business;
using CoFAS_MES.UI.IM.Data;

namespace CoFAS_MES.UI.IM.UserForm
{
    public partial class frmResourceMst_Popup : frmBaseSingle
    {

        private static string _pCORP_CODE = string.Empty;       // 회사코드       
        private static string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)     
        private static string _pWINDOW_NAME = string.Empty;     // 화면명칭 
        private static string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어

        private static string _pFTP_ID = string.Empty;          // FTP ID 정보
        private static string _pFTP_PATH = string.Empty;     // FTP SERVER IP 정보
        private static string _pFTP_PW = string.Empty;          //FTP PW 정보
        private static string _pPROCESS_MST_CODE = string.Empty;
        private static string _pPROCESS_NAME = string.Empty;

        private static Font fntPARENT_FONT = null;

        private static string _pCRUD = "";

        private static object[] _pARRAY = null;

        private static object[] _pARRAY_CODE = null;

        private bool _pFirstYN = true;

        //알림창메시지 복사 시작
        private string _pMSG_SEARCH = string.Empty;   // 조회 되었습니다.
        private string _pMSG_SEARCH_EMPT = string.Empty;   // 조회 항목이 없습니다.
        private string _pMSG_SAVE_QUESTION = string.Empty;   // 데이터 저장 처리 하겠습니까?
        private string _pMSG_SAVE = string.Empty;   // 저장 처리 되었습니다.
        private string _pMSG_SAVE_ERROR = string.Empty;   // 저장 처리 중 오류가 발생 하였습니다.
        private string _pMSG_DELETE_QUESTION = string.Empty;   // 데이터 삭제 처리 하겠습니까?
        private string _pMSG_DELETE = string.Empty;   // 삭제 처리 되었습니다.
        private string _pMSG_DELETE_ERROR = string.Empty;   // 삭제 처리 중 오류가 발생 하였습니다.
        private string _pMSG_DELETE_COMPLETE = string.Empty;   // 삭제된 데이터 입니다.
        private string _pMSG_INPUT_DATA = string.Empty;   // 데이터를 입력 해 주세요.
        private string _pMSG_INPUT_DATA_ERROR = string.Empty;   // 데이터 입력이 잘못되었습니다.
        private string _pMSG_WORKING = string.Empty;   // 작업중인 항목이 있습니다.
        private string _pMSG_RESET_QUESTION = string.Empty;   // 초기화 하시겠습니까?
        private string _pMSG_EXIT_QUESTION = string.Empty;   // 종료 하겠습니까?
        private string _pMSG_SELECT = string.Empty;   // 데이터를 선택해주세요.
        private string _pMSG_CHECK_VALID_ITEM = string.Empty;    //필수항목을 확인해주시기 바랍니다.  
        private string _pMSG_RESET_COMPLETE = string.Empty;     //초기화 하였습니다.  

        private frmResourceMst_PopupEntity _pfrmResourceMst_PopupEntity = null;

        private CoFAS_DevGridManager _TempMainGridView;

        private DataTable _dtList = null; //조회 데이터 리스트

        private DataTable dtMessage = null; // 화면별 메세지 관리 데이터 테이블

        public static string CRUD
        {
            get { return _pCRUD; }
            set { _pCRUD = value; }
        }
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

        public static string FTP_PATH
        {
            get { return _pFTP_PATH; }
            set { _pFTP_PATH = value; }
        }
        public static string FTP_ID
        {
            get { return _pFTP_ID; }
            set { _pFTP_ID = value; }
        }
        public static string FTP_PW
        {
            get { return _pFTP_PW; }
            set { _pFTP_PW = value; }
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

        private DataTable _dtreturn = new DataTable();

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

        public frmResourceMst_Popup()
        {
            InitializeComponent();
        }

        private void frmResourceMst_Popup_Load(object sender, EventArgs e)
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
            _luPROCESS_MST_CODE.Text = ARRAY_CODE[0].ToString();
            _luEQUIPMENT_CODE.Text = ARRAY_CODE[1].ToString();
            _pWINDOW_NAME = this.Name.ToString();

            //언어설정 창 표시 정보
            PageSetting_WINDOW_NAME = _pWINDOW_NAME;
            PageSetting_USER_CODE = _pUSER_CODE;
            PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
            PageSetting_FONT = fntPARENT_FONT;

            //메뉴 화면 엔티티 설정
            _pfrmResourceMst_PopupEntity = new frmResourceMst_PopupEntity();
            //_pfrmCategorySensorSettingsEntity.CORP_CODE = _pCORP_CODE;
            _pfrmResourceMst_PopupEntity.USER_CODE = _pUSER_CODE;
            _pfrmResourceMst_PopupEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;

            _pfrmResourceMst_PopupEntity.INSPECT_CODE = ARRAY_CODE[2].ToString();

            //화면 설정 언어 & 명칭 변경. ==고정==
            DataTable dtLanguage = new LanguageBusiness().Language_Info(_pWINDOW_NAME, _pLANGUAGE_TYPE);

            if (dtLanguage != null && dtLanguage.Rows.Count > 0)
            {
                CoFAS_ControlManager.Language_Info(dtLanguage, this);
            }

            //추가 메세지 정보 조회.
            dtMessage = new MessageBusiness().MessageValue_Mst_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME);

            if (dtMessage != null && dtMessage.Rows[0][0].ToString() != "")
            {
                _pMSG_SEARCH = dtMessage.Rows[0]["MSG_SEARCH"].ToString();
                _pMSG_SEARCH_EMPT = dtMessage.Rows[0]["MSG_SEARCH_EMPT"].ToString();
                _pMSG_SAVE_QUESTION = dtMessage.Rows[0]["MSG_SAVE_QUESTION"].ToString();
                _pMSG_SAVE = dtMessage.Rows[0]["MSG_SAVE"].ToString();
                _pMSG_SAVE_ERROR = dtMessage.Rows[0]["MSG_SAVE_ERROR"].ToString();
                _pMSG_DELETE_QUESTION = dtMessage.Rows[0]["MSG_DELETE_QUESTION"].ToString();
                _pMSG_DELETE = dtMessage.Rows[0]["MSG_DELETE"].ToString();
                _pMSG_DELETE_ERROR = dtMessage.Rows[0]["MSG_DELETE_ERROR"].ToString();
                _pMSG_DELETE_COMPLETE = dtMessage.Rows[0]["MSG_DELETE_COMPLETE"].ToString();
                _pMSG_INPUT_DATA = dtMessage.Rows[0]["MSG_INPUT_DATA"].ToString();
                _pMSG_INPUT_DATA_ERROR = dtMessage.Rows[0]["MSG_INPUT_DATA_ERROR"].ToString();
                _pMSG_WORKING = dtMessage.Rows[0]["MSG_WORKING"].ToString();
                _pMSG_RESET_QUESTION = dtMessage.Rows[0]["MSG_RESET_QUESTION"].ToString();
                _pMSG_EXIT_QUESTION = dtMessage.Rows[0]["MSG_EXIT_QUESTION"].ToString();
                _pMSG_SELECT = dtMessage.Rows[0]["MSG_SELECT"].ToString();
                _pMSG_CHECK_VALID_ITEM = dtMessage.Rows[0]["MSG_CHECK_VALID_ITEM"].ToString();
                _pMSG_RESET_COMPLETE = dtMessage.Rows[0]["MSG_RESET_COMPLETE"].ToString();
            }

            //그리드 설정
            InitializeGrid();

            //화면 컨트롤러 설정
            InitializeControl();
        }

        #region ○ 그리드 초기화 하기 - InitializeGrid()
        private void InitializeGrid()
        {
            try
            {
                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                if (_pFirstYN)
                {
                    _TempMainGridView = new CoFAS_DevGridManager();

                    _gdMAIN_VIEW = _TempMainGridView.Grid_Setting(_gdMAIN, _gdMAIN_VIEW, fntPARENT_FONT, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdMAIN.Name.ToString()));
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }


        #endregion

        #region ○ 컨트롤 초기화 - InitializeControl()

        private void InitializeControl()
        {
            try
            {
                //조회조건 영역 

                //데이터 영역
                _pfrmResourceMst_PopupEntity.CRUD = "R";
                _pfrmResourceMst_PopupEntity.PROCESS_MST_CODE = _luPROCESS_MST_CODE.Text.ToString();
                _pfrmResourceMst_PopupEntity.EQUIPMENT_CODE = _luEQUIPMENT_CODE.Text.ToString();

                MainFind_DisplayData();


            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {

            }
        }

        #endregion


        // DB 처리
        #region ○ 메인조회 - MainFind_DisplayData()
        private void MainFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _dtList = new frmResourceMst_PopupBusiness().frmResourceMst_Popup_Info(_pfrmResourceMst_PopupEntity);

                if (_pfrmResourceMst_PopupEntity.CRUD == "") _dtList.Rows.Clear();


                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pfrmResourceMst_PopupEntity.CRUD == ""))
                {

                    _TempMainGridView.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩
                }
                else
                {
                    _TempMainGridView.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {
                //_gdMAIN_VIEW.BestFitColumns();

                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }

        #endregion

        #region ○ 저장 - InputData_Save(DataTable dtSave)

        private void InputData_Save(DataTable dtSave)//DataTable dtSave)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                bool isError = false;

                isError = new frmResourceMst_PopupBusiness().frmResourceMst_Popup_Info_Save(_pfrmResourceMst_PopupEntity, dtSave);

                if (isError)
                {
                    //오류 발생.
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                    //화면 표시.
                }
                else
                {
                    //정상 처리
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);

                    _pfrmResourceMst_PopupEntity.CRUD = "R";

                    MainFind_DisplayData();
                }

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {

                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }

        #endregion

        private void _ucbtSAVE_Click(object sender, EventArgs e)
        {
            GridView gv = sender as GridView;

            InputData_Save(_gdMAIN_VIEW.GridControl.DataSource as DataTable);
        }

        private void _ucbtSELECT_Click(object sender, EventArgs e)
        {
            _pfrmResourceMst_PopupEntity.CRUD = "R";
            _pfrmResourceMst_PopupEntity.PROCESS_MST_CODE = _luPROCESS_MST_CODE.Text.ToString();
            _pfrmResourceMst_PopupEntity.EQUIPMENT_CODE = _luEQUIPMENT_CODE.Text.ToString();

            MainFind_DisplayData();
        }

        private void _ucbtCLOSE_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}

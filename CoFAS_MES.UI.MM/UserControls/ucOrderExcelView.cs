﻿using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.Function;
using CoFAS_MES.CORE.Entity;
using CoFAS_MES.UI.MM.Entity;
using CoFAS_MES.UI.MM.Business;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;
using DevExpress.Spreadsheet;
using System.Collections.Generic;
using DevExpress.DataAccess.ConnectionParameters;

namespace CoFAS_MES.UI.MM.UserControls
{
    public partial class ucOrderExcelView : UserControl
    {
        public MessageEntity _pMessageEntity = null; //공통 메세지 엔티티
        

        private static string _pCORP_CODE = string.Empty;       // 회사코드       
        private static string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        private static string _pWINDOW_NAME = string.Empty;     // 화면명칭
        private static string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어

        private static string _pFTP_ID = string.Empty;          // FTP ID 정보
        private static string _pFTP_IP_PORT = string.Empty;        // FTP SERVER IP 정보
        private static string _pFTP_PATH = string.Empty;     // FTP SERVER IP 정보
        private static string _pFTP_PW = string.Empty;          //FTP PW 정보
        private string _pLocation_Code = string.Empty;  // 저장/수정 후 로케이션 위치 저장

        private static string _strFILE_NAME = string.Empty;
        private string _pFile_Attr = string.Empty;
        private static CORE.BaseControls.ucSpreadSheetControl _sdMAIN = null;
        IWorkbook wb = null;
        private static string _strFTP_PATH = string.Empty;
        private string _pFTP_DOWNLOAD_PATH = "";
        private string strUSE_TYPE = "";

        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용
        

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
        //추가
        private string _pMSG_PLZ_CONNECT_FTP = string.Empty;    //FTP 연결을 확인해주세요.  
        private string _pMSG_AGAIN_INPUT_DATA = string.Empty;    //생산계획데이터는 다시 입력하여야 합니다  
        private string _pMSG_DOWNLOAD_COMPLETE = string.Empty;    //다운로드 되었습니다.  
        private string _pMSG_SEARCH_EMPT_DETAIL = string.Empty;    //상세 조회 내역이 없습니다.  
        private string _pMSG_SPLITQTY_LARGE_MORE = string.Empty;    //분할수량이 더 큽니다.  
        private string _pMSG_DELETE_ERROR_NO_DATA = string.Empty;    //삭제할 데이터가 없습니다.  
        private string _pMSG_ORDERQTY_LARGE_THAN_0 = string.Empty;    //발주수량이 0보다 작을 수 없습니다.  
        private string _pMSG_PLAN_LARGE_THAN_ORDER = string.Empty;    //등록할 지시수량이 계획수량보다 큽니다.  
        private string _pMSG_DELETE_ERROR_CONNECT_FTP = string.Empty;    //"삭제 처리 중 에러가 발생했습니다. FTP 연결을 확인해주세요."  
        private string _pMSG_INPUT_LESS_THAN_NOTOUTQTY = string.Empty;    //"미출고수량보다 작게 입력해주세요.미출고수량"  
        private string _pMSG_LOAD_DATA = string.Empty;    //생산계획을 불러오십시오.  
        private string _pMSG_NEW_REG_GUBN = string.Empty;    //신규등록 부분입니다.  
        private string _pMSG_INPUT_NUMERIC = string.Empty;    //숫자를 입력하시기 바랍니다.  
        private string _pMSG_NO_SELETED_ITEM = string.Empty;    //선택한 파일이 없습니다  
        private string _pMSG_EXIST_COMPANY_ID = string.Empty;    //이미 등록된 사업자등록번호 입니다.  
        private string _pMSG_NOT_DELETE_DATA_IN = string.Empty;    //생산입고 데이터는 삭제할 수 없습니다.  
        private string _pMSG_NOT_MODIFY_DATA_IN = string.Empty;    //생산입고 데이터는 수정할 수 없습니다.  
        private string _pMSG_SELECT_NEWREG_SAVE = string.Empty;    //"신규 등록을 선택하셨습니다.저장하겠습니까?"  
        private string _pMSG_INPUT_LARGER_THAN_0 = string.Empty;    //입고수량이 0보다 작을 수 없습니다.  
        private string _pMSG_NOT_DELETE_DATA_OUT = string.Empty;    //생산출고 데이터는 삭제할 수 없습니다.  
        private string _pMSG_NOT_MODIFY_DATA_OUT = string.Empty;    //생산출고 데이터는 수정할 수 없습니다.  
        private string _pMSG_CANCLE_NEWREG_MODIFY = string.Empty;    //"신규 등록을 해제하셨습니다.기존 파일을 수정하겠습니까?"  
        private string _pMSG_NO_SELETED_ITEM_OR_NO_SAVE = string.Empty;    //선택한 파일이 없거나 저장하지 않았습니다.  
        private string _pMSG_NO_INPUT_LAGER_THAN_NOTINQTY = string.Empty;    //입고 수량이 미입고 수량보다 많을 수 없습니다.  
        private string _pMSG_REG_DATA = string.Empty;    //데이터를 등록해주세요.  
        private string _pMSG_ADD_FAVORITE_ITEM = string.Empty;    //즐겨찾기에 추가 되었습니다.  
        private string _pMSG_CHECK_SEARCH_DATE = string.Empty;    //조회 일자를 확인해 주세요.  
        private string _pMSG_NOT_DISPLAY_ERROR = string.Empty;    //저장된 파일에 문제가 발생해 볼수 없습니다.  
        private string _pMSG_NO_EXIST_INPUT_DATA = string.Empty;    //입력된 조건값이 없습니다.  
        private string _pMSG_NOT_DISPLAY_NOT_SAVE = string.Empty;    //저장하지 않아서 볼 수 없습니다.  
        private string _pMSG_CHECK_VALID_ITEM = string.Empty;    //필수항목을 확인해주시기 바랍니다.  
        private string _pMSG_DELETE_FAVORITE_ITEM = string.Empty;    //즐겨찾기에서 삭제 되었습니다.  
        private string _pMSG_NOT_EXIST_PRINTING_EXCEL = string.Empty;    //해당 거래처로 저장된 인쇄용 엑셀 파일이 없습니다.  
        private string _pMSG_SELECT_DOWNLOAD_TEMPLETE = string.Empty;     //템플릿을 다운로드할 메뉴를 선택해주세요.  
        private string _pMSG_RESET_COMPLETE = string.Empty;     //초기화 하였습니다.  

        private static Font fntPARENT_FONT = null;       // 시스템 폰트 설정
        private static object[] _pARRAY = null;
        private static object[] _pARRAY_CODE = null;
        private string _pCRUD = ""; //CRUD
        int i = 0;


        public static string CORP_CDDE
        {
            get { return _pCORP_CODE; }
            set { _pCORP_CODE = value; }
        }
        public static string strFTP_PATH
        {
            get { return _strFTP_PATH; }
            set { _strFTP_PATH = value; }
        }
        public static string strFILE_NAME
        {
            get { return _strFILE_NAME; }
            set { _strFILE_NAME = value; }
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

        public static string FTP_ID
        {
            get { return _pFTP_ID; }
            set { _pFTP_ID = value; }
        }

        public static string FTP_IP_PORT
        {
            get { return _pFTP_IP_PORT; }
            set { _pFTP_IP_PORT = value; }
        }

        public static string FTP_PATH
        {
            get { return _pFTP_PATH; }
            set { _pFTP_PATH = value; }
        }

        public static string FTP_PW
        {
            get { return _pFTP_PW; }
            set { _pFTP_PW = value; }
        }

        private DataTable _dtList = null; //조회 데이터 리스트
        public static DataTable _dtreturn = null; // 선택 데이터 리턴

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

        public ucOrderExcelView()
        {
            InitializeComponent();

            _pWINDOW_NAME = this.Name.ToString();
        }

        public ucOrderExcelView(DataTable dt)
        {
            InitializeComponent();

            _dtreturn = dt;

            _pWINDOW_NAME = this.Name.ToString();
        }

        #region ○ Form_FormClosed

        private void Form_FormClosed(object pSender, FormClosedEventArgs pFormClosedEventArgs)
        {
            try
            {
                //화면 레이아웃 저장 ?
                //_gdMAIN_VIEW.CellValueChanged -= _gdMAIN_VIEW_CellValueChanged;
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        private void OrderExcelView_Load(object sender, EventArgs e)
        {
            try
            {
                _pMessageEntity = new MessageEntity();
                DataTable dtMessage = new MessageBusiness().MessageValue_Info(_pLANGUAGE_TYPE);
                if (dtMessage != null)
                {
                    _pMessageEntity.MSG_SEARCH = dtMessage.Rows[0]["MSG_SEARCH"].ToString();
                    _pMessageEntity.MSG_SEARCH_EMPT = dtMessage.Rows[0]["MSG_SEARCH_EMPT"].ToString();
                    _pMessageEntity.MSG_SAVE_QUESTION = dtMessage.Rows[0]["MSG_SAVE_QUESTION"].ToString();
                    _pMessageEntity.MSG_SAVE = dtMessage.Rows[0]["MSG_SAVE"].ToString();
                    _pMessageEntity.MSG_SAVE_ERROR = dtMessage.Rows[0]["MSG_SAVE_ERROR"].ToString();
                    _pMessageEntity.MSG_DELETE_QUESTION = dtMessage.Rows[0]["MSG_DELETE_QUESTION"].ToString();
                    _pMessageEntity.MSG_DELETE = dtMessage.Rows[0]["MSG_DELETE"].ToString();
                    _pMessageEntity.MSG_DELETE_ERROR = dtMessage.Rows[0]["MSG_DELETE_ERROR"].ToString();
                    _pMessageEntity.MSG_DELETE_COMPLETE = dtMessage.Rows[0]["MSG_DELETE_COMPLETE"].ToString();
                    _pMessageEntity.MSG_INPUT_DATA = dtMessage.Rows[0]["MSG_INPUT_DATA"].ToString();
                    _pMessageEntity.MSG_INPUT_DATA_ERROR = dtMessage.Rows[0]["MSG_INPUT_DATA_ERROR"].ToString();
                    _pMessageEntity.MSG_WORKING = dtMessage.Rows[0]["MSG_WORKING"].ToString();
                    _pMessageEntity.MSG_RESET_QUESTION = dtMessage.Rows[0]["MSG_RESET_QUESTION"].ToString();
                    _pMessageEntity.MSG_EXIT_QUESTION = dtMessage.Rows[0]["MSG_EXIT_QUESTION"].ToString();
                    _pMessageEntity.MSG_SELECT = dtMessage.Rows[0]["MSG_SELECT"].ToString();

                    //추가
                    _pMessageEntity.MSG_PLZ_CONNECT_FTP = dtMessage.Rows[0]["MSG_PLZ_CONNECT_FTP"].ToString();
                    _pMessageEntity.MSG_AGAIN_INPUT_DATA = dtMessage.Rows[0]["MSG_AGAIN_INPUT_DATA"].ToString();
                    _pMessageEntity.MSG_DOWNLOAD_COMPLETE = dtMessage.Rows[0]["MSG_DOWNLOAD_COMPLETE"].ToString();
                    _pMessageEntity.MSG_SEARCH_EMPT_DETAIL = dtMessage.Rows[0]["MSG_SEARCH_EMPT_DETAIL"].ToString();
                    _pMessageEntity.MSG_SPLITQTY_LARGE_MORE = dtMessage.Rows[0]["MSG_SPLITQTY_LARGE_MORE"].ToString();
                    _pMessageEntity.MSG_DELETE_ERROR_NO_DATA = dtMessage.Rows[0]["MSG_DELETE_ERROR_NO_DATA"].ToString();
                    _pMessageEntity.MSG_ORDERQTY_LARGE_THAN_0 = dtMessage.Rows[0]["MSG_ORDERQTY_LARGE_THAN_0"].ToString();
                    _pMessageEntity.MSG_PLAN_LARGE_THAN_ORDER = dtMessage.Rows[0]["MSG_PLAN_LARGE_THAN_ORDER"].ToString();
                    _pMessageEntity.MSG_DELETE_ERROR_CONNECT_FTP = dtMessage.Rows[0]["MSG_DELETE_ERROR_CONNECT_FTP"].ToString();
                    _pMessageEntity.MSG_INPUT_LESS_THAN_NOTOUTQTY = dtMessage.Rows[0]["MSG_INPUT_LESS_THAN_NOTOUTQTY"].ToString();
                    _pMessageEntity.MSG_LOAD_DATA = dtMessage.Rows[0]["MSG_LOAD_DATA"].ToString();
                    _pMessageEntity.MSG_NEW_REG_GUBN = dtMessage.Rows[0]["MSG_NEW_REG_GUBN"].ToString();
                    _pMessageEntity.MSG_INPUT_NUMERIC = dtMessage.Rows[0]["MSG_INPUT_NUMERIC"].ToString();
                    _pMessageEntity.MSG_NO_SELETED_ITEM = dtMessage.Rows[0]["MSG_NO_SELETED_ITEM"].ToString();
                    _pMessageEntity.MSG_EXIST_COMPANY_ID = dtMessage.Rows[0]["MSG_EXIST_COMPANY_ID"].ToString();
                    _pMessageEntity.MSG_NOT_DELETE_DATA_IN = dtMessage.Rows[0]["MSG_NOT_DELETE_DATA_IN"].ToString();
                    _pMessageEntity.MSG_NOT_MODIFY_DATA_IN = dtMessage.Rows[0]["MSG_NOT_MODIFY_DATA_IN"].ToString();
                    _pMessageEntity.MSG_SELECT_NEWREG_SAVE = dtMessage.Rows[0]["MSG_SELECT_NEWREG_SAVE"].ToString();
                    _pMessageEntity.MSG_INPUT_LARGER_THAN_0 = dtMessage.Rows[0]["MSG_INPUT_LARGER_THAN_0"].ToString();
                    _pMessageEntity.MSG_NOT_DELETE_DATA_OUT = dtMessage.Rows[0]["MSG_NOT_DELETE_DATA_OUT"].ToString();
                    _pMessageEntity.MSG_NOT_MODIFY_DATA_OUT = dtMessage.Rows[0]["MSG_NOT_MODIFY_DATA_OUT"].ToString();
                    _pMessageEntity.MSG_CANCLE_NEWREG_MODIFY = dtMessage.Rows[0]["MSG_CANCLE_NEWREG_MODIFY"].ToString();
                    _pMessageEntity.MSG_NO_SELETED_ITEM_OR_NO_SAVE = dtMessage.Rows[0]["MSG_NO_SELETED_ITEM_OR_NO_SAVE"].ToString();
                    _pMessageEntity.MSG_NO_INPUT_LAGER_THAN_NOTINQTY = dtMessage.Rows[0]["MSG_NO_INPUT_LAGER_THAN_NOTINQTY"].ToString();
                    _pMessageEntity.MSG_REG_DATA = dtMessage.Rows[0]["MSG_REG_DATA"].ToString();
                    _pMessageEntity.MSG_ADD_FAVORITE_ITEM = dtMessage.Rows[0]["MSG_ADD_FAVORITE_ITEM"].ToString();
                    _pMessageEntity.MSG_CHECK_SEARCH_DATE = dtMessage.Rows[0]["MSG_CHECK_SEARCH_DATE"].ToString();
                    _pMessageEntity.MSG_NOT_DISPLAY_ERROR = dtMessage.Rows[0]["MSG_NOT_DISPLAY_ERROR"].ToString();
                    _pMessageEntity.MSG_NO_EXIST_INPUT_DATA = dtMessage.Rows[0]["MSG_NO_EXIST_INPUT_DATA"].ToString();
                    _pMessageEntity.MSG_NOT_DISPLAY_NOT_SAVE = dtMessage.Rows[0]["MSG_NOT_DISPLAY_NOT_SAVE"].ToString();
                    _pMessageEntity.MSG_CHECK_VALID_ITEM = dtMessage.Rows[0]["MSG_CHECK_VALID_ITEM"].ToString();
                    _pMessageEntity.MSG_DELETE_FAVORITE_ITEM = dtMessage.Rows[0]["MSG_DELETE_FAVORITE_ITEM"].ToString();
                    _pMessageEntity.MSG_NOT_EXIST_PRINTING_EXCEL = dtMessage.Rows[0]["MSG_NOT_EXIST_PRINTING_EXCEL"].ToString();
                    _pMessageEntity.MSG_SELECT_DOWNLOAD_TEMPLETE = dtMessage.Rows[0]["MSG_SELECT_DOWNLOAD_TEMPLETE"].ToString();
                    _pMessageEntity.MSG_RESET_COMPLETE = dtMessage.Rows[0]["MSG_RESET_COMPLETE"].ToString();
                }

                InitializeSetting();

                

                MainFind_DisplayData();

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
            //메인 화면 공통 메세지 처리           _아래애 MainForm지우기
            _pMSG_SEARCH = _pMessageEntity.MSG_SEARCH;
            _pMSG_SEARCH_EMPT = _pMessageEntity.MSG_SEARCH_EMPT;
            _pMSG_SAVE_QUESTION = _pMessageEntity.MSG_SAVE_QUESTION;
            _pMSG_SAVE = _pMessageEntity.MSG_SAVE;
            _pMSG_SAVE_ERROR = _pMessageEntity.MSG_SAVE_ERROR;
            _pMSG_DELETE_QUESTION = _pMessageEntity.MSG_DELETE_QUESTION;
            _pMSG_DELETE = _pMessageEntity.MSG_DELETE;
            _pMSG_DELETE_ERROR = _pMessageEntity.MSG_DELETE_ERROR;
            _pMSG_DELETE_COMPLETE = _pMessageEntity.MSG_DELETE_COMPLETE;
            _pMSG_INPUT_DATA = _pMessageEntity.MSG_INPUT_DATA;
            _pMSG_INPUT_DATA_ERROR = _pMessageEntity.MSG_INPUT_DATA_ERROR;
            _pMSG_WORKING = _pMessageEntity.MSG_WORKING;
            _pMSG_RESET_QUESTION = _pMessageEntity.MSG_RESET_QUESTION;
            _pMSG_EXIT_QUESTION = _pMessageEntity.MSG_EXIT_QUESTION;
            _pMSG_SELECT = _pMessageEntity.MSG_SELECT;
            //추가
            _pMSG_PLZ_CONNECT_FTP = _pMessageEntity.MSG_PLZ_CONNECT_FTP;
            _pMSG_AGAIN_INPUT_DATA = _pMessageEntity.MSG_AGAIN_INPUT_DATA;
            _pMSG_DOWNLOAD_COMPLETE = _pMessageEntity.MSG_DOWNLOAD_COMPLETE;
            _pMSG_SEARCH_EMPT_DETAIL = _pMessageEntity.MSG_SEARCH_EMPT_DETAIL;
            _pMSG_SPLITQTY_LARGE_MORE = _pMessageEntity.MSG_SPLITQTY_LARGE_MORE;
            _pMSG_DELETE_ERROR_NO_DATA = _pMessageEntity.MSG_DELETE_ERROR_NO_DATA;
            _pMSG_ORDERQTY_LARGE_THAN_0 = _pMessageEntity.MSG_ORDERQTY_LARGE_THAN_0;
            _pMSG_PLAN_LARGE_THAN_ORDER = _pMessageEntity.MSG_PLAN_LARGE_THAN_ORDER;
            _pMSG_DELETE_ERROR_CONNECT_FTP = _pMessageEntity.MSG_DELETE_ERROR_CONNECT_FTP;
            _pMSG_INPUT_LESS_THAN_NOTOUTQTY = _pMessageEntity.MSG_INPUT_LESS_THAN_NOTOUTQTY;
            _pMSG_LOAD_DATA = _pMessageEntity.MSG_LOAD_DATA;
            _pMSG_NEW_REG_GUBN = _pMessageEntity.MSG_NEW_REG_GUBN;
            _pMSG_INPUT_NUMERIC = _pMessageEntity.MSG_INPUT_NUMERIC;
            _pMSG_NO_SELETED_ITEM = _pMessageEntity.MSG_NO_SELETED_ITEM;
            _pMSG_EXIST_COMPANY_ID = _pMessageEntity.MSG_EXIST_COMPANY_ID;
            _pMSG_NOT_DELETE_DATA_IN = _pMessageEntity.MSG_NOT_DELETE_DATA_IN;
            _pMSG_NOT_MODIFY_DATA_IN = _pMessageEntity.MSG_NOT_MODIFY_DATA_IN;
            _pMSG_SELECT_NEWREG_SAVE = _pMessageEntity.MSG_SELECT_NEWREG_SAVE;
            _pMSG_INPUT_LARGER_THAN_0 = _pMessageEntity.MSG_INPUT_LARGER_THAN_0;
            _pMSG_NOT_DELETE_DATA_OUT = _pMessageEntity.MSG_NOT_DELETE_DATA_OUT;
            _pMSG_NOT_MODIFY_DATA_OUT = _pMessageEntity.MSG_NOT_MODIFY_DATA_OUT;
            _pMSG_CANCLE_NEWREG_MODIFY = _pMessageEntity.MSG_CANCLE_NEWREG_MODIFY;
            _pMSG_NO_SELETED_ITEM_OR_NO_SAVE = _pMessageEntity.MSG_NO_SELETED_ITEM_OR_NO_SAVE;
            _pMSG_NO_INPUT_LAGER_THAN_NOTINQTY = _pMessageEntity.MSG_NO_INPUT_LAGER_THAN_NOTINQTY;
            _pMSG_REG_DATA = _pMessageEntity.MSG_REG_DATA;
            _pMSG_ADD_FAVORITE_ITEM = _pMessageEntity.MSG_ADD_FAVORITE_ITEM;
            _pMSG_CHECK_SEARCH_DATE = _pMessageEntity.MSG_CHECK_SEARCH_DATE;
            _pMSG_NOT_DISPLAY_ERROR = _pMessageEntity.MSG_NOT_DISPLAY_ERROR;
            _pMSG_NO_EXIST_INPUT_DATA = _pMessageEntity.MSG_NO_EXIST_INPUT_DATA;
            _pMSG_NOT_DISPLAY_NOT_SAVE = _pMessageEntity.MSG_NOT_DISPLAY_NOT_SAVE;
            _pMSG_CHECK_VALID_ITEM = _pMessageEntity.MSG_CHECK_VALID_ITEM;
            _pMSG_DELETE_FAVORITE_ITEM = _pMessageEntity.MSG_DELETE_FAVORITE_ITEM;
            _pMSG_NOT_EXIST_PRINTING_EXCEL = _pMessageEntity.MSG_NOT_EXIST_PRINTING_EXCEL;
            _pMSG_SELECT_DOWNLOAD_TEMPLETE = _pMessageEntity.MSG_SELECT_DOWNLOAD_TEMPLETE;
            _pMSG_RESET_COMPLETE = _pMessageEntity.MSG_RESET_COMPLETE;



            //화면 설정 언어 & 명칭 변경. ==고정==
            DataTable dtLanguage = new LanguageBusiness().Language_Info(_pWINDOW_NAME, _pLANGUAGE_TYPE);

            if (dtLanguage != null && dtLanguage.Rows.Count > 0)
            {
                CoFAS_ControlManager.Language_Info(dtLanguage, this);
            }

            //화면 컨트롤러 설정
            InitializeControl();

            //그리드 설정 ==고정==
            //_gdMAIN_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdMAIN, _gdMAIN_VIEW, fntPARENT_FONT, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdMAIN.Name.ToString()));

            if (_pFirstYN)
            {
                //_gdMAIN_VIEW.CellValueChanged += _gdMAIN_VIEW_CellValueChanged;
                //_gdMAIN_VIEW.DoubleClick += _gdMAIN_VIEW_DoubleClick;
            }
        }

        private void InitializeControl()
        {
            try
            {
                _pCRUD = "";


                //_luTORDER_NUMBER.Text = "";
                //_luTORDER_NUMBER.ReadOnly = true;

                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                //_gdMAIN.DataSource = null;


            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {

            }
        }

        public static event OnDoubleClickEventHandler _OnDoubleClick; //그리드 로우 마우스 선택으로 값 넘길경우 필수
        public delegate void OnDoubleClickEventHandler(object sender, EventArgs e); //그리드 로우 마우스 선택으로 값 넘길경우 필수

        public static event OnClickEventHandler _Close_Click;
        public delegate void OnClickEventHandler(object sender, EventArgs e);
       
        private void _btCancle_Click(object sender, EventArgs e)
        {
            if (_Close_Click != null)
                _Close_Click(sender, e);
            this.Dispose();
        }

        private void _luORDER_NUMBER__OnButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //try
            //{
            //    CoFAS_MES.UI.MM.UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
            //    CoFAS_MES.UI.MM.UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
            //    CoFAS_MES.UI.MM.UserForm.frmCommonPopup.FONT_TYPE = fntPARENT_FONT;

            //    CoFAS_MES.UI.MM.UserForm.frmCommonPopup.ARRAY = new object[2] { "", "" }; //넘기는 파라메터 에 따라 설정, 제품/조회할때 품목명을 던지기
            //    CoFAS_MES.UI.MM.UserForm.frmCommonPopup.ARRAY_CODE = new object[2] { "", "" };
            //    CoFAS_MES.UI.MM.UserForm.frmCommonPopup xfrmCommonPopup = new CoFAS_MES.UI.MM.UserForm.frmCommonPopup("ordernumberinfo_popup"); //유저컨트롤러 설정 부분

            //    xfrmCommonPopup.ShowDialog();

            //    if (xfrmCommonPopup.dtReturn == null)
            //    {
            //        xfrmCommonPopup.Dispose();
            //        return;
            //    }

            //    if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
            //    {
            //        //_luTORDER_NUMBER.Text = xfrmCommonPopup.dtReturn.Rows[0]["CONTRACT_ID"].ToString();

            //        // _luREFERENCE_ID.Text = xfrmCommonPopup.dtReturn.Rows[0]["REFERENCE_ID"].ToString();
            //        //_luTPART_NAME.Text = xfrmCommonPopup.dtReturn.Rows[0]["CONTRACT_QTY"].ToString();

            //        // BOM 조회하기
            //        //MainFind_DisplayData();


            //    }

            //    xfrmCommonPopup.Dispose();
            //}
            //catch(ExceptionManager pExceptionManager)
            //{
            //    CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            //}
        }

        #region ○ 메인그리드 더블클릭 이벤트 생성 - _gdMAIN_VIEW_DoubleClick(object sender, RowCellClickEventArgs e)
        private void _gdMAIN_VIEW_DoubleClick(object pObject, EventArgs pEventArgs)
        {
            //try
            //{
            //    GridView gv = pObject as GridView;

            //    if (gv.FocusedRowHandle < 0) return;
            //    if(gv.GetFocusedRowCellValue("CRUD").ToString().Equals("Y"))
            //    {
            //        gv.SetFocusedRowCellValue("CRUD", "N");
            //    }else
            //    {
            //        gv.SetFocusedRowCellValue("CRUD", "Y");
            //    }
            //}
            //catch (ExceptionManager pExceptionManager)
            //{
            //    CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            //}
        }
        #endregion

        #region ○ 메인조회 - MainFind_DisplayData()

        private void MainFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                Stream responseStream = null;

                responseStream = CORE.Function.CoFAS_FTPManager.FTPFileBinding(strFTP_PATH, strFILE_NAME, _pFTP_ID, _pFTP_PW);

                spreadsheetControl1.LoadDocument(responseStream);

                wb = spreadsheetControl1.Document;

                if (wb.MailMergeDataSource == null) return;

                /*
                switch (DBManager.PrimaryDBManagerType)
                {
                    case DBManagerType.MySql:
                        wb.MailMergeDataSource = new DevExpress.DataAccess.Sql.SqlDataSource(new MySqlConnectionParameters(DBManager.InitDatabaseServer, DBManager.InitDatabaseName, DBManager.InitDatabaseID, DBManager.InitDatabasePass, 3306));
                        break;
                    case DBManagerType.SQLServer:
                        wb.MailMergeDataSource = new MsSqlConnectionParameters();
                        break;
                }
                */


                Object dsTemp = wb.MailMergeDataSource;
                ParametersCollection para = wb.MailMergeParameters;




                para["v_option1"].Value = ARRAY_CODE[1].ToString(); // KEY값
                para["v_option2"].Value = ARRAY_CODE[2].ToString(); // 사용여부
                para["v_option3"].Value = USER_CODE; // 사용자
                para["v_option4"].Value = ARRAY_CODE[3].ToString(); // 페이징 행수 기준
                para["v_option5"].Value = ARRAY_CODE[4].ToString(); // 시작번호


                IList<IWorkbook> result = wb.GenerateMailMergeDocuments();
                using (MemoryStream resultStream = new MemoryStream())
                {
                    result[0].SaveDocument(resultStream, DocumentFormat.OpenXml);
                    wb.LoadDocument(resultStream);
                    
                }

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            catch (Exception ex)
            {
                CoFAS_DevExpressManager.ShowErrorMessage("Exception :" + ex.ToString());
            }
            finally
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }

        #endregion

        private void _btnSearch_Click(object sender, EventArgs e)
        {
            MainFind_DisplayData();
        }

        private void _ucbtcontract_SAVE_Click(object sender, EventArgs e)
        {
            //DataTable dt;
            //dt = _gdMAIN.DataSource as DataTable;
            //_gdMAIN_VIEW.FocusedRowHandle = -1;
            //if ((CoFAS_ConvertManager.DataTable_FindCount(dt, "CRUD = 'Y'", "")))
            //{
            //    dtReturn = CoFAS_ConvertManager.DataTable_FindValue(dt, "CRUD = 'Y'", "");
            //    PO.UserForm.frmCommonPopup._DataTable = dtReturn;
            //}

            //_btCancle_Click(null, null);
            //try
            //{
            //    CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
            //    bool isError = false;
            //    DataTable dt;
            //    DataTable dtTemp = null;

            //    //if (CoFAS_DevExpressManager.ShowQuestionMessage("저장 하시겠습니까?") == DialogResult.Yes)
            //    if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_SAVE_QUESTION) == DialogResult.Yes)
            //    {
            //        dt = _gdMAIN.DataSource as DataTable;
            //        if ((CoFAS_ConvertManager.DataTable_FindCount(dt, "CRUD IN ('C','U','D') AND ORDER_QTY > 0", "")))
            //        {
            //            dtTemp = CoFAS_ConvertManager.DataTable_FindValue(dt, "CRUD IN ('C','U','D') AND ORDER_QTY > 0", "");

            //            _pucOutsourcingInfoPopupEntity.CRUD = "C";
            //            for(int i=0;i<dtTemp.Rows.Count;i++)
            //            {
            //                dtTemp.Rows[i]["CRUD"] = "C";
            //            }
            //            isError = new ProductPlanRegister_T02Business().ProductPlanSub_Save(_pucOutsourcingInfoPopupEntity, dtTemp);

            //            if (!isError)
            //            {
            //                //CoFAS_DevExpressManager.ShowInformationMessage("저장 처리 되었습니다.");
            //                CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
            //                _pLocation_Code = _pucOutsourcingInfoPopupEntity.RTN_KEY;  //저장 위치

            //                _gdMAIN.DataSource = null;

            //                //팝업 닫기
            //                _btCancle_Click(null, null);
            //            }
            //            else
            //            {
            //                //CoFAS_DevExpressManager.ShowInformationMessage("저장 오류 발생! 데이터를 확인 하세요.");
            //                CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
            //            }
            //        }
            //    }
            //}
            //catch (ExceptionManager pExceptionManager)
            //{
            //    CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            //}
            //finally
            //{
            //    CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            //}
        }

        private void _gdMAIN_VIEW_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //_gdMAIN_VIEW.CellValueChanged -= _gdMAIN_VIEW_CellValueChanged;
            //ChangeValues(sender, e);
            //_gdMAIN_VIEW.CellValueChanged += _gdMAIN_VIEW_CellValueChanged;
        }

        private void ChangeValues(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //GridView g = sender as GridView;

            //int selectedRowNum = g.FocusedRowHandle;
            //int selectedCellNum = g.FocusedColumn.VisibleIndex;

            //if (g.GetRowCellDisplayText(selectedRowNum, "ORDER_QTY").Equals("")) return;

            //decimal order_qty = Convert.ToDecimal(g.GetRowCellDisplayText(selectedRowNum, "ORDER_QTY") == "" ? "0" : g.GetRowCellDisplayText(selectedRowNum, "ORDER_QTY"));
            //decimal unit_cost = Convert.ToDecimal(g.GetRowCellDisplayText(selectedRowNum, "UNITCOST") == "" ? "0" : g.GetRowCellDisplayText(selectedRowNum, "UNITCOST"));
            //decimal cost = 0;

            //cost = order_qty * unit_cost;
            //g.SetFocusedRowCellValue("COST", cost);
        }

        private void _luTPART_CODE__OnOpenClick(object sender, EventArgs e)
        {
            //try
            //{
            //    PO.UserForm.frmCommonPopup.CRUD = "R";
            //    PO.UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
            //    PO.UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
            //    //PO.UserForm.frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

            //    // 0 서비스네임 1 공통코드경우 CODE_TYPE 으로구분자 올린다.
            //    PO.UserForm.frmCommonPopup.ARRAY = new object[2] { "", "" };
            //    PO.UserForm.frmCommonPopup.ARRAY_CODE = new object[2] { _luTPART_CODE.CodeText.ToString(), _luTPART_CODE.NameText.ToString() };
            //    PO.UserForm.frmCommonPopup xfrmCommonPopup = new PO.UserForm.frmCommonPopup("ucProductionPartListPopup");  // new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분

            //    xfrmCommonPopup.ShowDialog();

            //    if (xfrmCommonPopup.dtReturn == null)
            //    {
            //        xfrmCommonPopup.Dispose();
            //        return;
            //    }

            //    if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
            //    {
            //        _luTPART_CODE.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["VEND_PART_CODE"].ToString();
            //        _luTPART_CODE.NameText = xfrmCommonPopup.dtReturn.Rows[0]["PART_NAME"].ToString();

            //        _pucOutsourcingInfoPopupEntity.PART_CODE = xfrmCommonPopup.dtReturn.Rows[0]["PART_CODE"].ToString();
            //    }

            //    xfrmCommonPopup.Dispose();
            //}
            //catch (ExceptionManager pExceptionManager)
            //{
            //    CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            //}
            //finally
            //{
            //    CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            //}
        }

        private void _utbtSAVE_Click(object sender, EventArgs e)
        {
            
        }



        protected override void OnHandleDestroyed(EventArgs e)

        {

            base.OnHandleDestroyed(e);

        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {
            if (i < 1)
            {
                i++;
                if (CoFAS_DevExpressManager.ShowQuestionMessage("저장하시겠습니까?") == DialogResult.Yes)
                {
                    if (strFILE_NAME != "")
                    {
                        SaveFileDialog saveFile = new SaveFileDialog();
                        saveFile.InitialDirectory = @"C:\";
                        saveFile.Filter = "Excel.XLSX(*.xlsx) | *.xls | ALL(*.*) | *.*";
                        saveFile.FileName = strFILE_NAME;

                        switch (strUSE_TYPE)
                        {
                            case "PRINT":
                                strFTP_PATH = string.Format(@"{0}{1}/{2}/", _pFTP_PATH, "ORDER_FORM", "MaterialOrderRegister_T03");
                                break;
                            case "VIEW":
                                strFTP_PATH = string.Format(@"{0}{1}/", _pFTP_PATH, "PROGRAM_VIEW");
                                break;
                        }
                        if (saveFile.ShowDialog() == DialogResult.OK)
                        {
                            _pFTP_DOWNLOAD_PATH = saveFile.FileName;
                            CoFAS_FTPManager.FTPDownLoad(strFTP_PATH, strFILE_NAME, _pFTP_ID, _pFTP_PW, _pFTP_DOWNLOAD_PATH);

                            this.Dispose();
                        }
                    }
                    else
                    {
                        MessageBox.Show("선택된 파일이 없습니다!");

                    }

                }

            }
        }
    }
}

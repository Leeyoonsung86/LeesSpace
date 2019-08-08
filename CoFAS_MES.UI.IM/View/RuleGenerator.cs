﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevExpress.Utils;

using CoFAS_MES.CORE.BaseForm;
using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.Function;

using CoFAS_MES.CORE.UserForm;

using CoFAS_MES.UI.IM.Business;
using CoFAS_MES.UI.IM.Entity;
using DevExpress.XtraGrid.Views.Grid;

using CoFAS_MES.UI.IM.View;

namespace CoFAS_MES.UI.IM
{
    public partial class RuleGenerator : frmBaseNone
    {
        public string _pCORP_CODE = string.Empty;       // 회사코드       
        public string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        public string _pUSER_NAME = string.Empty;       // 사용자이름
        public string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어
        public string _pWINDOW_NAME = string.Empty;     // 화면 명칭
        public string _pMENU_NAME = string.Empty;       // 메뉴명칭
        public string _pFONT_TYPE = string.Empty;       // 시스템 폰트 타입 설정
        public int _pFONT_SIZE = 9;                     // 시스템 폰트 사이즈 설정 기본 9
        private Font _pFONT_SETTING = null;             // 시스템 폰트 설정

        private string _pUSER_GRANT = string.Empty; // 사용자 권한

        private RuleGeneratorEntity _pRuleGeneratorEntity = null; // 엔티티 생성
        private RuleOptionSettingEntity _pRuleOptionSettingEntity = null; // 엔티티 생성
 
        string strRESOURCE_NAME = null; //OPTLIST 팝업 컴포넌트 정보로 조회
        string strWORKSHOP_NAME = null;
        string strPGMCODE = null;
        string strMODELYEAR = null;
        string strIFRULE = null;


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

        //알림창메시지 복사 끝




        //int preRuleCode = 0;
        //string preRuleDetail = null;

        int ConCount = 0; // AND/OR 추가시 카운트

        public static string ruleOption = "";
        public static string ruleValue = "";

        private DataTable _dtList = null; //조회 데이터 리스트

        private bool _pFirstYN = true ;                  // 최초실행여부 최초 설정 에서만 사용

        public RuleGenerator()
        {
            InitializeComponent();

            Activated += new EventHandler(Form_Activated);
            FormClosing += new FormClosingEventHandler(Form_Closing);
            FormClosed += new FormClosedEventHandler(Form_FormClosed);
            Load += new EventHandler(Form_Load);
        }

        //폼 이벤트 처리 영역
        #region ○ Form_Activated
        private void Form_Activated(object pSender, EventArgs pEventArgs)
        {
            try
            {
                InitializeButtons();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion

        #region ○ Form_Closing

        private void Form_Closing(object pSender, FormClosingEventArgs pFormClosingEventArgs)
        {
            try
            {

                if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_EXIT_QUESTION) == DialogResult.No)
                {
                    pFormClosingEventArgs.Cancel = true;
                    return;
                }

                pFormClosingEventArgs.Cancel = false;
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        #region ○ Form_FormClosed

        private void Form_FormClosed(object pSender, FormClosedEventArgs pFormClosedEventArgs)
        {
            try
            {
                //화면 레이아웃 저장 ?
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        #region ○ Form_Load
        private void Form_Load(object pSender, EventArgs pEventArgs)
        {
            try
            {
                InitializeSetting();

                //버튼이벤트 생성
                SearchButtonClicked += new EventHandler(Form_SearchButtonClicked);
                SaveButtonClicked += new EventHandler(Form_SaveButtonClicked);
                //AddItemButtonClicked += new EventHandler(Form_AddItemButtonClicked);
                //DeleteButtonClicked += new EventHandler(Form_DeleteButtonClicked);
                PrintButtonClicked += new EventHandler(Form_PrintButtonClicked);
                //ExportButtonClicked += new EventHandler(Form_ExportButtonClicked);
                //ImportButtonClicked += new EventHandler(Form_ImportButtonClicked);
                //InitialButtonClicked += new EventHandler(Form_InitialButtonClicked);
                SettingButtonClicked += new EventHandler(Form_SettingButtonClicked);

                FormCloseButtonClicked += new EventHandler(Form_FormCloseButtonClicked);

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {
                DevExpress.Utils.AppearanceObject.DefaultFont = _pFONT_SETTING;//화면에 모든 항목 폰트 재설정
            }
        }
        #endregion

        // 초기화 처리 영역
        #region ○ 메뉴 초기화 하기 - InitializeSetting()

        private void InitializeSetting()
        {
            try
            {
                //상속 화면 패널 사용 유무
                _pnHeader.Visible = true;
                _pnContent.Visible = true;
                _pnLeft.Visible = true;
                _pnLeft.Width = 250;

                //메인 화면 전역 변수 처리
                _pCORP_CODE = MainForm.UserEntity.CORP_CODE;
                _pUSER_CODE = MainForm.UserEntity.USER_CODE;
                _pUSER_NAME = MainForm.UserEntity.USER_NAME;
                _pLANGUAGE_TYPE = MainForm.UserEntity.LANGUAGE_TYPE;
                _pFONT_TYPE = MainForm.UserEntity.FONT_TYPE;
                _pFONT_SIZE = MainForm.UserEntity.FONT_SIZE;
                _pFONT_SETTING = new Font(_pFONT_TYPE, _pFONT_SIZE);

                _pUSER_GRANT = MainForm.UserEntity.USER_GRANT;

                _pWINDOW_NAME = this.Name;
                _pMENU_NAME = this.Text;

                //메인 화면 공통 메세지 처리
                _pMSG_SEARCH = MainForm.MessageEntity.MSG_SEARCH;
                _pMSG_SEARCH_EMPT = MainForm.MessageEntity.MSG_SEARCH_EMPT;
                _pMSG_SAVE_QUESTION = MainForm.MessageEntity.MSG_SAVE_QUESTION;
                _pMSG_SAVE = MainForm.MessageEntity.MSG_SAVE;
                _pMSG_SAVE_ERROR = MainForm.MessageEntity.MSG_SAVE_ERROR;
                _pMSG_DELETE_QUESTION = MainForm.MessageEntity.MSG_DELETE_QUESTION;
                _pMSG_DELETE = MainForm.MessageEntity.MSG_DELETE;
                _pMSG_DELETE_ERROR = MainForm.MessageEntity.MSG_DELETE_ERROR;
                _pMSG_DELETE_COMPLETE = MainForm.MessageEntity.MSG_DELETE_COMPLETE;
                _pMSG_INPUT_DATA = MainForm.MessageEntity.MSG_INPUT_DATA;
                _pMSG_INPUT_DATA_ERROR = MainForm.MessageEntity.MSG_INPUT_DATA_ERROR;
                _pMSG_WORKING = MainForm.MessageEntity.MSG_WORKING;
                _pMSG_RESET_QUESTION = MainForm.MessageEntity.MSG_RESET_QUESTION;
                _pMSG_EXIT_QUESTION = MainForm.MessageEntity.MSG_EXIT_QUESTION;
                _pMSG_SELECT = MainForm.MessageEntity.MSG_SELECT;
                //추가
                _pMSG_PLZ_CONNECT_FTP = MainForm.MessageEntity.MSG_PLZ_CONNECT_FTP;
                _pMSG_AGAIN_INPUT_DATA = MainForm.MessageEntity.MSG_AGAIN_INPUT_DATA;
                _pMSG_DOWNLOAD_COMPLETE = MainForm.MessageEntity.MSG_DOWNLOAD_COMPLETE;
                _pMSG_SEARCH_EMPT_DETAIL = MainForm.MessageEntity.MSG_SEARCH_EMPT_DETAIL;
                _pMSG_SPLITQTY_LARGE_MORE = MainForm.MessageEntity.MSG_SPLITQTY_LARGE_MORE;
                _pMSG_DELETE_ERROR_NO_DATA = MainForm.MessageEntity.MSG_DELETE_ERROR_NO_DATA;
                _pMSG_ORDERQTY_LARGE_THAN_0 = MainForm.MessageEntity.MSG_ORDERQTY_LARGE_THAN_0;
                _pMSG_PLAN_LARGE_THAN_ORDER = MainForm.MessageEntity.MSG_PLAN_LARGE_THAN_ORDER;
                _pMSG_DELETE_ERROR_CONNECT_FTP = MainForm.MessageEntity.MSG_DELETE_ERROR_CONNECT_FTP;
                _pMSG_INPUT_LESS_THAN_NOTOUTQTY = MainForm.MessageEntity.MSG_INPUT_LESS_THAN_NOTOUTQTY;
                _pMSG_LOAD_DATA = MainForm.MessageEntity.MSG_LOAD_DATA;
                _pMSG_NEW_REG_GUBN = MainForm.MessageEntity.MSG_NEW_REG_GUBN;
                _pMSG_INPUT_NUMERIC = MainForm.MessageEntity.MSG_INPUT_NUMERIC;
                _pMSG_NO_SELETED_ITEM = MainForm.MessageEntity.MSG_NO_SELETED_ITEM;
                _pMSG_EXIST_COMPANY_ID = MainForm.MessageEntity.MSG_EXIST_COMPANY_ID;
                _pMSG_NOT_DELETE_DATA_IN = MainForm.MessageEntity.MSG_NOT_DELETE_DATA_IN;
                _pMSG_NOT_MODIFY_DATA_IN = MainForm.MessageEntity.MSG_NOT_MODIFY_DATA_IN;
                _pMSG_SELECT_NEWREG_SAVE = MainForm.MessageEntity.MSG_SELECT_NEWREG_SAVE;
                _pMSG_INPUT_LARGER_THAN_0 = MainForm.MessageEntity.MSG_INPUT_LARGER_THAN_0;
                _pMSG_NOT_DELETE_DATA_OUT = MainForm.MessageEntity.MSG_NOT_DELETE_DATA_OUT;
                _pMSG_NOT_MODIFY_DATA_OUT = MainForm.MessageEntity.MSG_NOT_MODIFY_DATA_OUT;
                _pMSG_CANCLE_NEWREG_MODIFY = MainForm.MessageEntity.MSG_CANCLE_NEWREG_MODIFY;
                _pMSG_NO_SELETED_ITEM_OR_NO_SAVE = MainForm.MessageEntity.MSG_NO_SELETED_ITEM_OR_NO_SAVE;
                _pMSG_NO_INPUT_LAGER_THAN_NOTINQTY = MainForm.MessageEntity.MSG_NO_INPUT_LAGER_THAN_NOTINQTY;
                _pMSG_REG_DATA = MainForm.MessageEntity.MSG_REG_DATA;
                _pMSG_ADD_FAVORITE_ITEM = MainForm.MessageEntity.MSG_ADD_FAVORITE_ITEM;
                _pMSG_CHECK_SEARCH_DATE = MainForm.MessageEntity.MSG_CHECK_SEARCH_DATE;
                _pMSG_NOT_DISPLAY_ERROR = MainForm.MessageEntity.MSG_NOT_DISPLAY_ERROR;
                _pMSG_NO_EXIST_INPUT_DATA = MainForm.MessageEntity.MSG_NO_EXIST_INPUT_DATA;
                _pMSG_NOT_DISPLAY_NOT_SAVE = MainForm.MessageEntity.MSG_NOT_DISPLAY_NOT_SAVE;
                _pMSG_CHECK_VALID_ITEM = MainForm.MessageEntity.MSG_CHECK_VALID_ITEM;
                _pMSG_DELETE_FAVORITE_ITEM = MainForm.MessageEntity.MSG_DELETE_FAVORITE_ITEM;
                _pMSG_NOT_EXIST_PRINTING_EXCEL = MainForm.MessageEntity.MSG_NOT_EXIST_PRINTING_EXCEL;
                _pMSG_SELECT_DOWNLOAD_TEMPLETE = MainForm.MessageEntity.MSG_SELECT_DOWNLOAD_TEMPLETE;
                _pMSG_RESET_COMPLETE = MainForm.MessageEntity.MSG_RESET_COMPLETE;


                //메뉴 화면 엔티티 설정
                _pRuleGeneratorEntity = new RuleGeneratorEntity();
                _pRuleOptionSettingEntity = new RuleOptionSettingEntity();

                //화면 설정 언어 & 명칭 변경.
                DataTable dtLanguage = new LanguageBusiness().Language_Info(_pWINDOW_NAME, _pLANGUAGE_TYPE);

                if (dtLanguage != null && dtLanguage.Rows.Count > 0)
                {
                    CoFAS_ControlManager.Language_Info(dtLanguage, this);
                }

                //그리드 설정
                InitializeGrid();

                //화면 컨트롤러 설정
                InitializeControl();

                //그리드 초기화 

                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                if (_pFirstYN)
                {
                    _pRuleGeneratorEntity.CRUD = "";

                    _pRuleGeneratorEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;

                    MainFind_DisplayData(); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.

                    _pFirstYN = false;
                }

                _pRuleGeneratorEntity.CRUD = "";  // 임시 하드코딩  시연후 수정
                _pRuleGeneratorEntity.WORKSHOP_CODE = "";  // 임시 하드코딩  시연후 수정
                _pRuleGeneratorEntity.RESOURCE_CODE = "";

                SubFind_DisplayData("", ""); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.

                _gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick;

                _luIRULEOPTION.Click += Form_FormRuleOptionButtonClicked;
                _luIFADD.Click += Form_FormAddButtonClicked;
                _luIFAND.Click += Form_FormANDButtonClicked;
                _luIFOR.Click += Form_FormORButtonClicked;
                _luIFTHEN.Click += Form_FormTHENButtonClicked;
                _luIFTRUE.Click += Form_FormTRUEButtonClicked;
                _luIFFALSE.Click += Form_FormFALSEButtonClicked;

                _luIFCODITION.ValueChanged += Form_FormluIFCODITION_SelectedIndexChanged;

                _luIFAND.Enabled = false;
                _luIFOR.Enabled = false;
                _luIFTHEN.Enabled = false;
                _luIFTRUE.Enabled = false;
                _luIFFALSE.Enabled = false;
                _luIRULEOPTION.Enabled = false;
                _luIFADD.Enabled = false;

                _gdMAIN_VIEW.OptionsBehavior.Editable = false;
                _gdMAIN_VIEW.OptionsBehavior.ReadOnly = true; // 강제 ReadOnly true

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion

        #region ○ 버튼 초기화 하기 - InitializeButtons()

        private void InitializeButtons()
        {
            try
            {
                MainFormButtonSetting pButtonSetting = new MainFormButtonSetting();

                pButtonSetting.UseYNSearchButton = _pMenuSettingEntity.MENU_SEARCH == "Y" ? true : false; // 조회
                pButtonSetting.UseYNExportButton = _pMenuSettingEntity.MENU_EXPORT == "Y" ? true : false; // 내보내기
                pButtonSetting.UseYNImportButton = _pMenuSettingEntity.MENU_IMPORT == "Y" ? true : false; // 가져오기
                pButtonSetting.UseYNPrintButton = _pMenuSettingEntity.MENU_PRINT == "Y" ? true : false; // 프린터
                pButtonSetting.UseYNSaveButton = _pMenuSettingEntity.MENU_SAVE == "Y" ? true : false; // 저장
                pButtonSetting.UseYNAddItemButton = _pMenuSettingEntity.MENU_ADDITEM == "Y" ? true : false; // 신규
                pButtonSetting.UseYNDeleteButton = _pMenuSettingEntity.MENU_DELETE == "Y" ? true : false; // 삭제

                pButtonSetting.UseYNInitialButton = true; // 초기화
                if (_pUSER_GRANT == "PC160001")
                {
                    pButtonSetting.UseYNSettingButton = true; // 설정
                }
                else
                {
                    pButtonSetting.UseYNSettingButton = false; // 설정
                }
                pButtonSetting.UseYNFormCloseButton = true; // 폼닫기

                MainForm.SetButtonSetting(pButtonSetting);

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        #region ○ 그리드 초기화 하기 - InitializeGrid()
        private void InitializeGrid()
        {
            try
            {
                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                if (_pFirstYN)
                {
                    _pRuleGeneratorEntity.CRUD = "R";

                    _gdMAIN_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdMAIN, _gdMAIN_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdMAIN.Name.ToString()));
                }

                //_gdSUB_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB, _gdSUB_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE,_pWINDOW_NAME, _gdSUB.Name.ToString()));
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
                //_luT_WINDOW_NAME.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", "MENU_LIST", "", "", "").Tables[0], 0, 0, "");
                _luIFCODITION.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "COMMON_CODE", "RG01", "", "").Tables[0], 0, 0, "");
                //_luIFOPERATOR.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", "COMMON_CODE", "RG02", "", "").Tables[0], 0, 0, "");
                
                //데이터 영역
                //_luWINDOW_NAME.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", "MENU_LIST", "", "", "").Tables[0], 0, -1, "");
                //_luWINDOW_NAME.ReadOnly = false;

                //_luGRID_NAME.Text = "";
                //_luGRID_NAME.ReadOnly = false;

                //_luGRIDVIEW_NAME.Text = "";
                //_luGRIDVIEW_NAME.ReadOnly = false;

                //_luEDIT_ABLE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", "COMMON_CODE", "CD99", "", "").Tables[0], 0, 0, "");
                //_luEDITOR_SHOWMODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", "COMMON_CODE", "MM20", "", "").Tables[0], 0, 0, "");


                // 컨트롤러 유효성 검증 처리 기본 컨트롤러 에서만 사용 
                dxValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
                dxValidationProvider.Validate();

                //dxValidationProvider.SetValidationRule(_luGRID_NAME, NotEmptyValidationRule);
                //dxValidationProvider.SetValidationRule(_luGRIDVIEW_NAME, NotEmptyValidationRule);
                // 컨트롤러 유효성 검증 처리

                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                if (_pFirstYN)
                {
                    _gdMAIN.DataSource = null;
                }

                //_gdSUB.DataSource = null;
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

        // 추가 이벤트 생성
        #region ○ 메인 그리드 로우 선택 이벤트 생성 - _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        private void _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;

                CoFAS_ControlManager.Controls_Binding(gv, false, this);
                
                if (e.CellValue == null)
                {
                    _gdMAIN_VIEW.OptionsBehavior.Editable = true;

                    _gdMAIN_VIEW.OptionsBehavior.ReadOnly = false; // 강제 ReadOnly false

                    return;
                }

                _gdMAIN_VIEW.OptionsBehavior.Editable = false;

                _gdMAIN_VIEW.OptionsBehavior.ReadOnly = true; // 강제 ReadOnly true

                strWORKSHOP_NAME = gv.GetFocusedRowCellValue("WORKSHOP_NAME").ToString();
                strRESOURCE_NAME = gv.GetFocusedRowCellValue("RESOURCE_NAME").ToString();
                strPGMCODE = gv.GetFocusedRowCellValue("PGMCODE").ToString();
                strMODELYEAR = gv.GetFocusedRowCellValue("MODELYEAR").ToString();
                strIFRULE = gv.GetFocusedRowCellValue("IFRULE").ToString();

                //preRuleCode = Convert.ToInt32(gv.GetFocusedRowCellValue("RULE_CODE").ToString());
                //preRuleDetail = strIFRULE; // 기존 룰과 생성 및 수정된 룰과의 비교용

                _luIFCODITION.ItemIndex = 0;
                
                _luRULEDETAIL.Text = strIFRULE;

                _pRuleGeneratorEntity.CRUD = "R";

                //_luVALUE.Text = strRESOURCE_NAME + " | ";
                //_luVALUE.Text = _pRuleGeneratorEntity.RESOURCE_NAME + " | " + strValue;

                _luIFAND.Enabled = false;
                _luIFOR.Enabled = false;
                _luIFTHEN.Enabled = false;
                _luIFTRUE.Enabled = false;
                _luIFFALSE.Enabled = false;
                _luIRULEOPTION.Enabled = false;
                _luIFADD.Enabled = false;

                //_luOPTIONDETAIL.Enabled = false;
                //_luOPTIONDETAIL.Text = "";
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion
        
        #region ○ 그리드 버튼추가 시 클릭 이벤트 생성 - CoFAS_DevExpressManager__OnButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        private void CoFAS_DevExpressManager__OnButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //_gdMAIN_VIEW.EditingValue = "";
            switch (e.Button.Caption.ToString())
            {
                case "TEST": //해당 그리드에 필드명 // 2개 이상 그리드의 버튼 항목들은 버튼 타입에 필드 명칭이 모두 다르게 설정 되어야됨.
                    //frmCommonPopup.CORP_CDDE = _pCORP_CODE;
                    frmCommonPopup.USER_CODE = _pUSER_CODE;
                    frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                    frmCommonPopup.ARRAY = new object[2] { "common_code", "CD99" }; //넘기는 파라메터 에 따라 설정

                    frmCommonPopup xfrmcommonPopup = new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분

                    xfrmcommonPopup.ShowDialog();

                    if (xfrmcommonPopup.dtReturn == null) return;

                    xfrmcommonPopup.dtReturn.Rows[0][0].ToString();
                    // 리턴 받는 데이터의 값은 해당 그리드 뷰 필드에 설정.
                    //_gdMAIN_VIEW.SetRowCellValue(_gdMAIN_VIEW.FocusedRowHandle, _gdMAIN_VIEW.Columns["TEST1"], xfrmcommonPopup.dtReturn.Rows[0]["CD"].ToString());
                    //_gdMAIN_VIEW.SetRowCellValue(_gdMAIN_VIEW.FocusedRowHandle, _gdMAIN_VIEW.Columns["TEST2"], xfrmcommonPopup.dtReturn.Rows[0]["CD_NM"].ToString());
                    xfrmcommonPopup.Dispose();
                    break;

            }
        }

        #endregion

        // 메인 버튼 처리영역
        #region ○ 조회 버튼 클릭시 처리하기
        private void Form_SearchButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                //if (_luOPTSEARCH.Text != "")
                //{
                    //_pRuleGeneratorEntity.OPTION = _luOPTSEARCH.Text;

                    CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                    _pRuleGeneratorEntity.CRUD = "R";
                
                    MainFind_DisplayData();

                //DisplayMessage("조회 되었습니다.");
                DisplayMessage(_pMSG_SEARCH);

                //}
                //else
                //{
                //    CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                //}
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

        #region ○ 저장 버튼 클릭시 처리하기
        private void Form_SaveButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                if (_luRULEDETAIL.Text == "" && _luRULEDETAIL.Text == null)
                {
                    MessageBox.Show("룰이 정의되지않았습니다.");

                    return;
                }

                //확인
                //if (preRule == "" || preRule == null)
                //{
                //    _pRuleGeneratorEntity.CRUD = "C";
                //}
                //else
                //{
                //    _pRuleGeneratorEntity.CRUD = "U";
                //}

                _pRuleGeneratorEntity.CRUD = "U"; // 로우 데이터가 미리 테이블 생성 되어있음

                _pRuleGeneratorEntity.PARTCODE = _gdMAIN_VIEW.GetFocusedRowCellValue("PARTCODE").ToString();
                _pRuleGeneratorEntity.WORKSHOP_CODE = _gdMAIN_VIEW.GetFocusedRowCellValue("WORKSHOP_CODE").ToString();
                _pRuleGeneratorEntity.RESOURCE_CODE = _gdMAIN_VIEW.GetFocusedRowCellValue("RESOURCE_CODE").ToString();
                
                _pRuleGeneratorEntity.RULE_DETAIL = _luRULEDETAIL.Text.ToString();

                InputData_Save(_gdMAIN_VIEW.GridControl.DataSource as DataTable);

                //조회
                //_pRuleGeneratorEntity.OPTION = _luOPTSEARCH.Text;

                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _pRuleGeneratorEntity.CRUD = "R";

                MainFind_DisplayData();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            catch (Exception pException)
            {
                DisplayMessage(string.Format("{0}", pException));
            }
            finally
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }
        #endregion

        #region ○ DATA DICTIONARY 버튼 클릭시 처리하기
        private void Form_DataDictionaryButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                DataDictionary dataDictionary = new DataDictionary();

                dataDictionary.ShowDialog();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            catch (Exception pException)
            {
                DisplayMessage(string.Format("{0}", pException));
            }
            finally
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }
        #endregion

        #region ○ 인쇄 버튼 클릭시 처리하기
        private void Form_PrintButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
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

        #region ○ 화면 설정 버튼 클릭시 처리하기 - 언어 및 화면 컨트롤러 명칭 변경 설정
        private void Form_SettingButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                CoFAS_MES.CORE.UserForm.frmPageSetting xfrmPageSetting = new CORE.UserForm.frmPageSetting();
                //xfrmPageSetting.PASS_CORP_CODE = _pCORP_CODE;
                xfrmPageSetting.PASS_PARENT_WINDOW_NAME = _pWINDOW_NAME;
                xfrmPageSetting.PASS_USER_CODE = _pUSER_CODE;
                xfrmPageSetting.PASS_PARENT_LANGUAGE = _pLANGUAGE_TYPE;
                xfrmPageSetting.PASS_PARENT_FONT = _pFONT_SETTING;
                xfrmPageSetting.ShowDialog();

                if (xfrmPageSetting.PASS_RESULT)
                {
                    InitializeSetting();

                    xfrmPageSetting.Dispose();
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

        #region ○ 닫기 버튼 클릭시 처리하기
        private void Form_FormCloseButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                new SystemLogInfoBusiness().SystemEventLog_Info_Save("C", _pUSER_CODE, _pMENU_NAME, _pWINDOW_NAME, "Menu Close Event", "Form_FormCloseButton", "Button event is executed");

                Close(); //탭 화면 닫기
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        #region ○ RULE OPTION 버튼 클릭시 처리하기
        private void Form_FormRuleOptionButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                _pRuleOptionSettingEntity.COMPONENT = strRESOURCE_NAME;

                RuleOptionSetting.com_code = strRESOURCE_NAME;
                RuleOptionSetting ruleOptionSetting = new RuleOptionSetting();

                ruleOptionSetting.ShowDialog();

                if (ruleOption != "")
                {
                    _luRULEDETAIL.Text = _luRULEDETAIL.Text + " " + ruleOption + "";

                    //_luOPTIONDETAIL.Text = ruleOption + " : " + ruleValue;

                    ruleOption = "";
                    ruleValue = "";
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        #region ○ 조건식 콤보박스 클릭시 처리하기
        private void Form_FormluIFCODITION_SelectedIndexChanged(object pSender, EventArgs pEventArgs)
        {
            try
            {
                strWORKSHOP_NAME = _luIFCODITION.GetDisplayName();

                if (ConCount == 0) // 시작시
                {
                    _luRULEDETAIL.Text = "(" + _luRULEDETAIL.Text + strWORKSHOP_NAME + " = '' )";

                }
                else if (ConCount == 1) // AND,OR 추가시
                {
                    _luRULEDETAIL.Text = _luRULEDETAIL.Text + " ( " + strWORKSHOP_NAME + " = '' )";
                }

                _luIFCODITION.Enabled = false;
                _luIFADD.Enabled = true;
                //_luIFAND.Enabled = true;
                //_luIFOR.Enabled = true;
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        #region ○ Add 버튼 클릭시 처리하기
        private void Form_FormAddButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                if (_luVALUE.Text != "" && _luVALUE.Text != null)
                {
                    string ruleDetail = _luRULEDETAIL.Text;

                    string reRuleDetail = ruleDetail.Substring(0, ruleDetail.LastIndexOf('='));
                    
                    if (ConCount == 0) // 시작시
                    {
                        _luRULEDETAIL.Text = reRuleDetail + " = '" + _luVALUE.Text + "' )";
                    }
                    else if (ConCount == 1) // AND 추가시
                    {
                        ConCount = 0;

                        _luRULEDETAIL.Text = reRuleDetail + " = '" + _luVALUE.Text + "' )";

                        string ruleDetailAND = _luRULEDETAIL.Text;

                        string[] result = ruleDetailAND.Split(new string[] { "AND" }, StringSplitOptions.None);

                        for (int i = 0; i < result.Length; i++)
                        {
                            if (i == 0)
                            {
                                _luRULEDETAIL.Text = result[i];
                            }
                            else
                            {
                                _luRULEDETAIL.Text = _luRULEDETAIL.Text + "AND" + result[i];
                            }
                        }
                    }
                    else // OR 추가시
                    {
                        ConCount = 0;

                        _luRULEDETAIL.Text = reRuleDetail + " = '" + _luVALUE.Text + "' )";

                        string ruleDetailAND = _luRULEDETAIL.Text;

                        string[] result = ruleDetailAND.Split(new string[] { "OR" }, StringSplitOptions.None);

                        for (int i = 0; i < result.Length; i++)
                        {
                            if (i == 0)
                            {
                                _luRULEDETAIL.Text = result[i];
                            }
                            else
                            {
                                _luRULEDETAIL.Text = _luRULEDETAIL.Text + "OR" + result[i];
                            }
                        }
                    }

                    _luVALUE.Text = null;

                    _luIFADD.Enabled = false;
                    _luIFAND.Enabled = true;
                    _luIFOR.Enabled = true;
                    _luIFTHEN.Enabled = true;
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("입력된 조건값이 없습니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_NO_EXIST_INPUT_DATA);
                    
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        #region ○ AND 버튼 클릭시 처리하기
        private void Form_FormANDButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                    ConCount = 1;

                    _luRULEDETAIL.Text = _luRULEDETAIL.Text + " AND";

                    _luIFAND.Enabled = false;
                    _luIFOR.Enabled = false;
                    _luIFTHEN.Enabled = false;
                    _luIFCODITION.Enabled = true; 
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        #region ○ OR 버튼 클릭시 처리하기
        private void Form_FormORButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                ConCount = 1;

                _luRULEDETAIL.Text = _luRULEDETAIL.Text + " OR";

                _luIFAND.Enabled = false;
                _luIFOR.Enabled = false;
                _luIFTHEN.Enabled = false;
                _luIFCODITION.Enabled = true;
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        #region ○ THEN 버튼 클릭시 처리하기
        private void Form_FormTHENButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                _luRULEDETAIL.Text = _luRULEDETAIL.Text + " THEN";

                _luIFAND.Enabled = false;
                _luIFOR.Enabled = false;
                _luIFTHEN.Enabled = false;
                _luIRULEOPTION.Enabled = true;
                _luIFTRUE.Enabled = true;
                _luIFFALSE.Enabled = true;
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        #region ○ TRUE 버튼 클릭시 처리하기
        private void Form_FormTRUEButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                _luRULEDETAIL.Text = _luRULEDETAIL.Text + " true ";

                _luIRULEOPTION.Enabled = false;
                _luIFTRUE.Enabled = false;
                _luIFFALSE.Enabled = false;
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        #region ○ FALSE 버튼 클릭시 처리하기
        private void Form_FormFALSEButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                _luRULEDETAIL.Text = _luRULEDETAIL.Text + " false ";

                _luIRULEOPTION.Enabled = false;
                _luIFTRUE.Enabled = false;
                _luIFFALSE.Enabled = false;
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        #region ○ 신규 로우 저장 버튼 클릭시 처리하기
        private void Form_RowSaveButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _pRuleGeneratorEntity.CRUD = "C"; // 로우 데이터가 미리 테이블 생성 되어있음

                _pRuleGeneratorEntity.WORKSHOP_CODE = _gdMAIN_VIEW.GetFocusedRowCellValue("WORKSHOP_CODE").ToString();
                _pRuleGeneratorEntity.RESOURCE_NAME = _gdMAIN_VIEW.GetFocusedRowCellValue("RESOURCE_NAME").ToString();
                _pRuleGeneratorEntity.RESOURCE_CODE = _gdMAIN_VIEW.GetFocusedRowCellValue("RESOURCE_CODE").ToString();
                _pRuleGeneratorEntity.RESOURCE_NAME = _gdMAIN_VIEW.GetFocusedRowCellValue("RESOURCE_NAME").ToString();
                _pRuleGeneratorEntity.PARTCODE = _gdMAIN_VIEW.GetFocusedRowCellValue("PARTCODE").ToString();
                _pRuleGeneratorEntity.PGMCODE = _gdMAIN_VIEW.GetFocusedRowCellValue("PGMCODE").ToString();
                _pRuleGeneratorEntity.MODELYEAR = _gdMAIN_VIEW.GetFocusedRowCellValue("MODELYEAR").ToString();

                _pRuleGeneratorEntity.RULE_DETAIL = _luRULEDETAIL.Text.ToString();

                InputData_Save(_gdMAIN_VIEW.GridControl.DataSource as DataTable);
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            catch (Exception pException)
            {
                DisplayMessage(string.Format("{0}", pException));
            }
            finally
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }
        #endregion

        #region ○ 수정 버튼 클릭시 처리하기
        private void Form_RowEditButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                if (_gdMAIN_VIEW.OptionsBehavior.Editable == true)
                {
                    _gdMAIN_VIEW.OptionsBehavior.Editable = false;

                    _gdMAIN_VIEW.OptionsBehavior.ReadOnly = true; // 강제 ReadOnly false
                }
                else
                {
                    _gdMAIN_VIEW.OptionsBehavior.Editable = true;

                    _gdMAIN_VIEW.OptionsBehavior.ReadOnly = false; // 강제 ReadOnly true
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            catch (Exception pException)
            {
                DisplayMessage(string.Format("{0}", pException));
            }
            finally
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
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

                _dtList = new RuleGeneratorBusiness().RuleGenerator_Info(_pRuleGeneratorEntity);

                if (_pRuleGeneratorEntity.CRUD == "")
                {
                    _dtList.Rows.Clear();
                }
                
                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pRuleGeneratorEntity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
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

        #region ○ 서브조회 - SubFind_DisplayData()

        private void SubFind_DisplayData(string strWINDOW_NAME, string strGRID_NAME)
        {
            //try
            //{
            //    CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

            //    //_pGridInfoRegisterEntity.WINDOW_NAME = strWINDOW_NAME;
            //    //_pGridInfoRegisterEntity.GRID_NAME = strGRID_NAME;

            //    _dtList = new RuleGeneratorBusiness()._Info_Sub(_pRuleGeneratorEntity);

            //    if (_pRuleGeneratorEntity.CRUD == "") _dtList.Rows.Clear();

            //    if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pRuleGeneratorEntity.CRUD == ""))
            //    {
            //        CoFAS_DevExpressManager.BindGridControl(_gdSUB, _gdSUB_VIEW, _dtList);
            //    }
            //    else
            //    {
            //        CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
            //    }
            //}
            //catch (ExceptionManager pExceptionManager)
            //{
            //    CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            //}
            //finally
            //{
            //    // _gdSUB_VIEW.BestFitColumns();

            //    CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            //}
        }

        #endregion
        
        #region ○ 저장 - InputData_Save(DataTable dtSave)

        private void InputData_Save(DataTable dtSave)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                bool isError = false;


                isError = new RuleGeneratorBusiness().RuleGenerator_Info_Save(_pRuleGeneratorEntity, dtSave);

                if (isError)
                {
                    //오류 발생.
                    //CoFAS_DevExpressManager.ShowInformationMessage("저장 오류 발생! 데이터를 확인 하세요.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                    //화면 표시.

                }
                else
                {
                    //정상 처리
                    //CoFAS_DevExpressManager.ShowInformationMessage("저장 처리 되었습니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);

                    //MainFind_DisplayData();

                    // SubFind_DisplayData(_pRuleGeneratorEntity.WINDOW_NAME, _pRuleGeneratorEntity.GRID_NAME);
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

        private void simpleButton7_Click(object sender, EventArgs e)
        {

        }
    }
}

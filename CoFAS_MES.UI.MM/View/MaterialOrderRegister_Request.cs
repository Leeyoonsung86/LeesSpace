﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CoFAS_MES.CORE.BaseForm;
using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.Function;
using CoFAS_MES.CORE.BaseControls;
using CoFAS_MES.CORE.UserForm;
using CoFAS_MES.CORE.UserControls;
using CoFAS_MES.UI.MM.Business;
using CoFAS_MES.UI.MM.Data;
using CoFAS_MES.UI.MM.Entity;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Spreadsheet;
using System.IO;
using static CoFAS_MES.CORE.BaseControls.ucSpreadSheetControl;
using DevExpress.XtraSpreadsheet;
namespace CoFAS_MES.UI.MM
{
    public partial class MaterialOrderRegister_Request : frmBaseNone
    {
        #region ○ 변수선언

        public string _pCORP_CODE = string.Empty;       // 회사코드       
        public string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        public string _pUSER_NAME = string.Empty;       // 사용자이름
        public string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어
        public string _pWINDOW_NAME = string.Empty;     // 화면 명칭
        public string _pFONT_TYPE = string.Empty;       // 시스템 폰트 타입 설정
        public int _pFONT_SIZE = 9;                     // 시스템 폰트 사이즈 설정 기본 9
        private Font _pFONT_SETTING = null;             // 시스템 폰트 설정
        private string _pFTP_ID = string.Empty;          // FTP ID 정보
        private string _pFTP_PATH = string.Empty;     // FTP SERVER IP 정보
        private string _pFTP_PW = string.Empty;          //FTP PW 정보
        public string _pMENU_NAME = string.Empty;       // 메뉴명칭
        private string _pUSER_GRANT = string.Empty; // 사용자 권한
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

        private DataSet _dsList = null; //조회 데이터 리스트 데이터셋
        private DataTable _dtList = null; //조회 수신 데이터 리스트
        private DataTable _dtList2 = null; //조회 발신 데이터 리스트
        private MaterialOrderRegisterEntity_Request _pMaterialOrderRegister_RequestEntity = null; // 엔티티 생성
        private Object _ojList = null;    //엑셀파일  //추가
        private DataSet _stList = null;   //DataSet  //추가
        private SpreadsheetControl _sdMAIN = null;


        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용
        private string _pLocation_Code = string.Empty;  // 저장/수정 후 로케이션 위치 저장
        private bool _pLocation_YN = true;              // 저장위치 사용여부


        #endregion

        #region ○ 생성자

        public MaterialOrderRegister_Request()
        {
            InitializeComponent();

            Activated += new EventHandler(Form_Activated);
            FormClosing += new FormClosingEventHandler(Form_Closing);
            FormClosed += new FormClosedEventHandler(Form_FormClosed);
            Load += new EventHandler(Form_Load);
        }

        #endregion

        #region ● 폼 이벤트 처리 영역

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

                throw pExceptionManager;

            }
        }
        #endregion

        #region ○ Form_Closing

        private void Form_Closing(object pSender, FormClosingEventArgs pFormClosingEventArgs)
        {
            try
            {
                //그리드 작업 정보 확인 하기
                if (_gdMAIN_VIEW.GridControl != null && CoFAS_ConvertManager.DataTable_FindCount(_gdMAIN_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", ""))
                {
                    //if (CoFAS_DevExpressManager.ShowQuestionMessage("작업중인 자료가 있습니다.\n종료 하겠습니까?") == DialogResult.No)
                    if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_WORKING + "\n" + _pMSG_EXIT_QUESTION) == DialogResult.No)
                    {
                        pFormClosingEventArgs.Cancel = true;
                        return;
                    }
                }
                else
                {
                    //if (CoFAS_DevExpressManager.ShowQuestionMessage("작업 종료 하겠습니까?") == DialogResult.No)
                    if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_EXIT_QUESTION) == DialogResult.No)
                    {
                        pFormClosingEventArgs.Cancel = true;
                        return;
                    }
                }

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));

                throw pExceptionManager;

            }
            catch (Exception pException)
            {
                //throw new ExceptionManager(this, "InputData_Save(DataTable dtSave)", pException);
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

                throw pExceptionManager;

            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "InputData_Save(DataTable dtSave)", pException);
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
                DeleteButtonClicked += new EventHandler(Form_DeleteButtonClicked);
                PrintButtonClicked += new EventHandler(Form_PrintButtonClicked);
                ExportButtonClicked += new EventHandler(Form_ExportButtonClicked);
                ImportButtonClicked += new EventHandler(Form_ImportButtonClicked);
                InitialButtonClicked += new EventHandler(Form_InitialButtonClicked);
                SettingButtonClicked += new EventHandler(Form_SettingButtonClicked);

                FormCloseButtonClicked += new EventHandler(Form_FormCloseButtonClicked);

               // Form_SearchButtonClicked(null, null);
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));

                throw pExceptionManager;

            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "InputData_Save(DataTable dtSave)", pException);
            }

        }
        #endregion

        #endregion

        #region ● 초기화영역

        // 초기화 처리 영역
        #region ○ 메뉴 초기화 하기 - InitializeSetting()

        private void InitializeSetting()
        {
            try
            {
                //상속 화면 패널 사용 유무
                _pnHeader.Visible = true;
                _pnContent.Visible = true;
                _pnLeft.Visible = false;
                _pnContent.Width = 200;

                //버튼 폰트색상 및 배경색상
                _ucbtBOM_SpendQtyCalc.BackColor = Color.LightSalmon;

                //메인 화면 전역 변수 처리
                _pCORP_CODE = MainForm.UserEntity.CORP_CODE;
                _pUSER_CODE = MainForm.UserEntity.USER_CODE;
                _pUSER_NAME = MainForm.UserEntity.USER_NAME;
                _pLANGUAGE_TYPE = MainForm.UserEntity.LANGUAGE_TYPE;
                _pFONT_TYPE = MainForm.UserEntity.FONT_TYPE;
                _pFONT_SIZE = MainForm.UserEntity.FONT_SIZE;
                _pFONT_SETTING = new Font(_pFONT_TYPE, _pFONT_SIZE);
                _pFTP_ID = MainForm.UserEntity.FTP_ID;
                _pFTP_PATH = MainForm.UserEntity.FTP_IP_PORT; //string.Format(@"{0}/{1}/", MainForm.UserEntity.FTP_IP_PORT, "test"); //발주서는 ORDER_FORM // 화면조회용 PROGRAM_VIEW
                _pFTP_PW = MainForm.UserEntity.FTP_PW;
                _pUSER_GRANT = MainForm.UserEntity.USER_GRANT;
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


                _pWINDOW_NAME = this.Name;
                _pMENU_NAME = this.Text;


                //메뉴 화면 엔티티 설정
                _pMaterialOrderRegister_RequestEntity = new MaterialOrderRegisterEntity_Request();
                //_pMaterialOrderRegister_RequestEntity.CORP_CODE = _pCORP_CODE;
                _pMaterialOrderRegister_RequestEntity.USER_CODE = _pUSER_CODE;
                _pMaterialOrderRegister_RequestEntity.USER_NAME = _pUSER_NAME;
                _pMaterialOrderRegister_RequestEntity.WINDOW_NAME = _pWINDOW_NAME;
                _pMaterialOrderRegister_RequestEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;


                //화면 설정 언어 & 명칭 변경.
                DataTable dtLanguage = new LanguageBusiness().Language_Info(_pWINDOW_NAME, _pLANGUAGE_TYPE);

                if (dtLanguage != null && dtLanguage.Rows.Count > 0)
                {
                    CoFAS_ControlManager.Language_Info(dtLanguage, this);
                }

                //메인 화면 공용 버튼 설정
                //if (_pFirstYN)
                //{
                //    InitializeButtons();
                //}

                //그리드 설정
                InitializeGrid();

                //화면 컨트롤러 설정
                InitializeControl();

                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                //if (_pFirstYN)
                //{
                if (_pFirstYN)
                {
                    _pMaterialOrderRegister_RequestEntity.CRUD = "";
                    MainFind_DisplayData(_pMaterialOrderRegister_RequestEntity.CRUD); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.

                    _pFirstYN = false;
                }
                //}

                //컨트롤러 별 추가 이벤트 생성은 화면 설정 마지막에 진행
                _gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick;

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
                pButtonSetting.UseYNDeleteButton = _pMenuSettingEntity.MENU_DELETE == "Y" ? true : false; // 삭제

                pButtonSetting.UseYNInitialButton = true; // 초기화
                pButtonSetting.UseYNSettingButton = false; // 설정
                pButtonSetting.UseYNFormCloseButton = true; // 폼닫기
                if (_pUSER_GRANT == "PC160001")
                {
                    pButtonSetting.UseYNSettingButton = true; // 설정
                }
                else
                {
                    pButtonSetting.UseYNSettingButton = false; // 설정
                }
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
                    _gdMAIN_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdMAIN, _gdMAIN_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdMAIN.Name.ToString()));
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
                _luTORDER_DATE.FromDateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);  //조회 시작일, 매월 초 날짜로 설정
                _luTORDER_DATE.ToDateTime = DateTime.Today;  //조회 종료일, 당일 설정
                _luTPART_CODE.CodeText = "";
                _luTPART_CODE.NameText = "";
                _luTVEND_CODE.CodeText = "";
                _luTVEND_CODE.NameText = "";

                _luTORDER_ID.Text = "";
                _luTVEND_PART_CODE.Text = "";

                _luTUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "common_code", "CD99", "", "").Tables[0], 0, 0, "");
                _luTUSE_YN.ItemIndex = 0;

                //데이터 영역


                _luORDER_DATE.DateTime = DateTime.Today;

                _luORDER_ID.Text = "";
                _luORDER_ID.ReadOnly = true;

                _luUNIT_CODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "COMMON_CODE", "CD04", "", "").Tables[0], 0, 0, "");
                _luUNIT_CODE.ReadOnly = true;

                _luUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "common_code", "CD99", "", "").Tables[0], 0, 0, "");
                _luUSE_YN.ItemIndex = 0;

                _luPART.CodeText = "";
                _luPART.NameText = "";
                _luPART.CodeReadOnly = true;
                _luPART.NameReadOnly = true;

                _luVEND.CodeText = "";
                _luVEND.NameText = "";
                _luVEND.CodeReadOnly = true;
                _luVEND.NameReadOnly = true;

                _luORDER_QTY.Text = "0";
                _luORDER_QTY.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                _luORDER_QTY.ReadOnly = false;

                _luUNITCOST.Text = "0";
                _luUNITCOST.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                _luUNITCOST.ReadOnly = false;

                _luCOST.Text = "0";
                _luCOST.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                _luCOST.EditMask = "n2";
                _luCOST.ReadOnly = true;

                _luREQUEST_DATE.DateTime = DateTime.Today;


                _luREQUEST_LOCATION.Text = "";
                _luUNITCOST.ReadOnly = false;

                _luREMARK.Text = "";
                _luREMARK.ReadOnly = false;

                // 컨트롤러 유효성 검증 처리 기본 컨트롤러 에서만 사용 
                dxValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
                dxValidationProvider.Validate();

                dxValidationProvider.SetValidationRule(_luORDER_QTY, NotEmptyValidationRule);
                // 컨트롤러 유효성 검증 처리

                //그리드 초기화 

                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                if (_pFirstYN)
                {
                    _gdMAIN.DataSource = null;
                }

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

        // 추가이벤트 설정
        private void _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;

                CoFAS_ControlManager.Controls_Binding(gv, false, this);

                string pORDER_ID = gv.GetFocusedRowCellValue("ORDER_ID").ToString();
              //  gv.SetRowCellValue(e.RowHandle, gv.Columns["CRUD"], ucLookUpEdit);
                //if(gv.GetFocusedRowCellValue("CRUD"))

                //SubFind_DisplayData(pORDER_ID);
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion


        #region ● 메인 버튼 처리영역

        #region ○ 조회 버튼 클릭시 처리하기
        private void Form_SearchButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                if (CoFAS_ConvertManager.DataTable_FindCount(_gdMAIN_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", ""))
                {
                    if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_WORKING + "\n" + _pMSG_RESET_QUESTION) == DialogResult.No)
                    {
                        MainFind_DisplayData("R");
                        DisplayMessage(_pMSG_SEARCH);
                    }

                }
                else
                {
                    MainFind_DisplayData("R");
                    DisplayMessage(_pMSG_SEARCH);
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

        #region ○ 저장 버튼 클릭시 처리하기
        private void Form_SaveButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                if (!dxValidationProvider.Validate())
                {
                    //MessageBox.Show("빈값이 있음");
                    MessageBox.Show(_pMSG_CHECK_VALID_ITEM);
                    return;
                }
                if (_luPART.CodeText.ToString() == "")
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("자재를 선택해 주세요.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_CHECK_VALID_ITEM);
                    return;
                }
                if (_luORDER_QTY.Text == "0" || _luORDER_QTY.Text == "")
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("수량을 입력해 주세요.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_CHECK_VALID_ITEM);
                    return;
                }

                decimal intQty_chk = Convert.ToDecimal(_luORDER_QTY.Text);

                if (intQty_chk < 0)
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("발주수량이 0보다 작을 수 없습니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_ORDERQTY_LARGE_THAN_0);
                    return;
                }

                //확인
                if (_luORDER_ID.Text.ToString() != "")
                {
                    _pMaterialOrderRegister_RequestEntity.CRUD = "U";
                }
                else
                {
                    _pMaterialOrderRegister_RequestEntity.CRUD = "C";
                }
                
                _pMaterialOrderRegister_RequestEntity.USER_CODE = _pUSER_CODE;
                _pMaterialOrderRegister_RequestEntity.ORDER_ID = _luORDER_ID.Text;
                //_pMaterialOrderRegisterEntity.ORDER_DATE = _luORDER_DATE.DateTime.ToString().Substring(0,10).Replace("-", "").ToString();
                _pMaterialOrderRegister_RequestEntity.ORDER_DATE = DateTime.Parse(_luORDER_DATE.DateTime.ToString()).ToString("yyyyMMdd");

                _pMaterialOrderRegister_RequestEntity.ORDER_SEQ = "";
                _pMaterialOrderRegister_RequestEntity.VEND_CODE = _luVEND.CodeText.ToString();
                _pMaterialOrderRegister_RequestEntity.PART_CODE = _luPART.CodeText.ToString();
                _pMaterialOrderRegister_RequestEntity.ORDER_QTY = _luORDER_QTY.Text;
                //_pMaterialOrderRegisterEntity.REQUEST_DATE = _luREQUEST_DATE.DateTime.ToString().Substring(0, 10).Replace("-", "").ToString();
                _pMaterialOrderRegister_RequestEntity.REQUEST_DATE = DateTime.Parse(_luREQUEST_DATE.DateTime.ToString()).ToString("yyyyMMdd");
                _pMaterialOrderRegister_RequestEntity.REQUEST_LOCATION = _luREQUEST_LOCATION.Text;
                _pMaterialOrderRegister_RequestEntity.UNIT_CODE = _luUNIT_CODE.GetValue();
                _pMaterialOrderRegister_RequestEntity.UNITCODT_CURRENCY_CODE = _luREQUEST_LOCATION.Text;
                _pMaterialOrderRegister_RequestEntity.UNITCOST = _luUNITCOST.Text;
                _pMaterialOrderRegister_RequestEntity.COST = _luCOST.Text;
                _pMaterialOrderRegister_RequestEntity.REMARK = _luREMARK.Text;
                _pMaterialOrderRegister_RequestEntity.USE_YN = _luUSE_YN.GetValue();


                InputData_Save(_pMaterialOrderRegister_RequestEntity);
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

        #region ○ 삭제 버튼 클릭시 처리하기
        private void Form_DeleteButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {


                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                if (!dxValidationProvider.Validate())
                {
                    //MessageBox.Show("빈값이 있음");
                    MessageBox.Show(_pMSG_CHECK_VALID_ITEM);
                    return;
                }

                //확인
                if (_luORDER_ID.Text.ToString() != "")
                {
                    _pMaterialOrderRegister_RequestEntity.CRUD = "D";
                }
                else
                {
                    MessageBox.Show(_pMSG_CHECK_VALID_ITEM);
                    return;
                }

                if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_DELETE_QUESTION + " : " + _luORDER_ID.Text) == DialogResult.No)
                {
                    return;
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

        #region ○ 인쇄 버튼 클릭시 처리하기
        private void Form_PrintButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                DataTable tDataTable = _gdMAIN_VIEW.GridControl.DataSource as DataTable;


                //같은 없체인지 체크
                string before_vend = string.Empty;
                int cnt = 0;
               
                for (int i = 0; i < tDataTable.Rows.Count; i++)
                {
                    if (tDataTable.Rows[i]["CRUD"].ToString() == "Y")
                    {
                        //처음꺼 업체코드 저장
                        if (cnt == 0)

                        {
                            before_vend = tDataTable.Rows[i]["VEND_CODE"].ToString();
                        }


                        if (tDataTable.Rows[i]["VEND_CODE"].ToString() != before_vend)
                        {
                            CoFAS_DevExpressManager.ShowInformationMessage("동일한 거래처만 발주서를 발급할 수 있습니다.");
                            return;
                        }
                        cnt++;
                    }
                }
                if (cnt == 0)
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("발주를 선택해주세요.");
                    return;
                }

                DataTable tTempData = new DataTable();
                
                //테이블 스키마 복사
                // tTempData = tDataTable.Clone();
                tTempData =CoFAS_ConvertManager.DataTable_FindValue(tDataTable, "CRUD ='Y'", "");
                //입고요청일 구하기
                //  int minAccountLevel = int.MaxValue;
                //  int maxAccountLevel = int.MinValue;
                //  foreach (DataRow dr in tTempData.Rows)
                //  {
                //      int accountLevel = Convert.ToInt32(dr.Field<string>("REQUEST_DATE"));
                //      minAccountLevel = Math.Min(minAccountLevel, accountLevel);
                //      maxAccountLevel = Math.Max(maxAccountLevel, accountLevel);
                //  }
                foreach (DataRow row in tDataTable.Rows)
                {
                    row["REQUEST_DATE"] = row["REQUEST_DATE"].ToString().Replace("-", "");
                    if (row["REQUEST_DATE"].ToString() == "")
                    {
                        row["REQUEST_DATE"] = "";
                    }
                }
                

                string MIN_Request_Date =Convert.ToString(tDataTable.Compute("max([REQUEST_DATE])", null));

                SheetFind_DisplayData();
                Sheet_Info_Sheet_Data(tTempData, before_vend, MIN_Request_Date);

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
        private void Sheet_Info_Sheet_Data(DataTable tTempData, string pVend_code,string pMIN_Request_Date)   //추가
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                // _pMaterialInspectRegisterEntity.ORDER_ID = _luORDER_ID.Text.ToString();

                IWorkbook workbook = _sdMAIN.Document;

                using (DBManager pDBManager = new DBManager())
                {

                    // _dtList = new MaterialOrderRegisterProvider(pDBManager).Sheet_Info_Sheet_Data(_pMaterialInspectRegisterEntity);
                    _pMaterialOrderRegister_RequestEntity.VEND_CODE = pVend_code;
                    _pMaterialOrderRegister_RequestEntity.ORDER_ID = "";
                    _dsList = new MaterialOrderRegister_RequestProvider(pDBManager).Sheet_Info_Sheet_Data(_pMaterialOrderRegister_RequestEntity);
                    //품목정보용
                    _dtList = _dsList.Tables[0];
                    //시험항목검사결과(엑셀바인딩용)
                    _dtList2 = _dsList.Tables[1];
                   // _pMaterialOrderRegister_RequestEntity.dtListCnt = _dtList_01.Rows.Count;


                    if (_dtList != null && _dtList.Rows.Count > 0)
                    {

                        Worksheet sheet_1 = workbook.Worksheets["데이터"];
                        Worksheet sheet_0 = workbook.Worksheets[0];
                        //Worksheet sheet_2 = workbook.Worksheets["저장용 데이터"];
                        Range data_range = sheet_1.GetDataRange();
                        sheet_1.Clear(data_range);
                        ExternalDataSourceOptions dsOptions = new ExternalDataSourceOptions();
                        dsOptions.ImportHeaders = false;

                        /* 
                         * 발주서 양식에 데이터를 바인딩할 때, row와 column의 인덱스 또는 범위(range)를 직접 지정하여 바인딩해야 한다.
                         * 현재, 발주번호 1건에 1개의 품목이 정의된 상태에서는 'data' 시트에 '기본 정보'와 '품목 조회 부분'을 같이 불러왔다. 
                         * 그리고 엑셀의 참조 기능을 이용하여 발주서 양식을 완성했다. 
                         * 
                         * 하지만, 발주번호 1건에 여러 개의 품목이 정의된 상태는 바인딩 방법을 다르게 해야 한다.
                         * DataSet으로 '기본 정보'와 '품목 조회 부분'을 따로 불러와야 한다.
                         * '기본 정보'는 'data' 시트에 바인딩한 후, 엑셀의 참조 기능을 이용한다.
                         * 그리고, '품목 조회 부분'은 rows.count()를 이용해 row의 수를 파악하여 발주서 양식에 행을 추가한다.
                         * 그 후, 행을 추가한 부분에 '품목 조회 부분'의 위치를 직접 지정하여 바인딩해야 한다.
                         * 
                        */
                        sheet_1.DataBindings.BindToDataSource(_dtList, 2, 0, dsOptions);   //수신
                        sheet_1.DataBindings.BindToDataSource(_dtList2, 5, 0, dsOptions); //발신
                        sheet_1.DataBindings.BindToDataSource(tTempData, 8, 0, dsOptions);  //품목리스트

                        //금액 한글로
                        Double total_cost = Convert.ToDouble(sheet_0.GetCellValue(14, 41).ToString());
                        total_cost = Math.Round(total_cost);
                        string korean_cost=Number2Hangle(total_cost);
                        sheet_0.Cells["D11"].Value= korean_cost;

                        //요청일 최소일로
                        //DateTime request_date;
                        //request_date = DateTime.ParseExact(pMIN_Request_Date, "yyyyMMdd", null);
                        //sheet_0.Cells["D9"].Value =request_date.ToString("yyyy년 MM월 dd일");
                        sheet_1.Cells["F3"].Value = pMIN_Request_Date;
                    }
                    else
                    {

                        CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                    }
                }

                workbook.Worksheets.ActiveWorksheet = workbook.Worksheets[0];
                _sdMAIN.ShowPrintPreview();
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
        private void SheetFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _sdMAIN = new SpreadsheetControl();
                _sdMAIN.Options.Behavior.ShowPopupMenu = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled;

                string strFTP_PATH = "";
                string strUSE_TYPE = "";
                string strFILE_NAME = "";

                _pMaterialOrderRegister_RequestEntity.CRUD = "R";
                //조회할거 프로시져
                _dtList = new MaterialOrderRegister_RequestBusiness().Sheet_Info_Sheet(_pMaterialOrderRegister_RequestEntity);   //엑셀 시트 조회하기

                //엑셀서식관리 되면 다시 설정하기

                strUSE_TYPE = _dtList.Rows[0]["USE_TYPE"].ToString();
                strFILE_NAME = _dtList.Rows[0]["FILE_NAME"].ToString();
                

                switch (strUSE_TYPE)
                {

                    case "PRINT":
                        strFTP_PATH = string.Format(@"{0}{1}/{2}/", _pFTP_PATH, "ORDER_FORM", _pWINDOW_NAME);
                        break;
                    case "VIEW":
                        strFTP_PATH = string.Format(@"{0}{1}/{2}/{3}/", _pFTP_PATH, "USER", "PROGRAM_VIEW", _pWINDOW_NAME);
                        break;
                    case "REGIT":
                        strFTP_PATH = string.Format(@"{0}{1}/{2}/{3}/", _pFTP_PATH, "USER", "PROGRAM_VIEW", _pWINDOW_NAME);
                        break;
                }

                string curfile = Application.StartupPath + "\\Template\\" + strFILE_NAME;

                // 같은 것이 있으면, 폴더에서 해당 파일명을 불러와서 SpreadSheet에 띄우기 / 없으면, 폴더에 다운
                if (!File.Exists(curfile))
                {
                    CoFAS_FTPManager.FTPDownLoad(strFTP_PATH, strFILE_NAME, _pFTP_ID, _pFTP_PW, curfile, false);

                }
                //using (FileStream file = File.OpenWrite(curfile))
                using (Stream file = File.Open(curfile, FileMode.Open))
                {
                    if (file != null)

                    {
                        _sdMAIN.LoadDocument(file, DocumentFormat.Xlsx);

                    
                    }
                    else
                    {
                        _sdMAIN.CloseCellEditor(CellEditorEnterValueMode.Default);
                        _sdMAIN.CreateNewDocument();

                    }
                }
                //_sdMAIN.ShowPrintPreview();
                //  }
                //  else
                //  {
                //      CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                //  }

                //_ojList = new ProcessMaterialStockStatusBusiness().Sheet_Info_Sheet(_pProcessMaterialStockStatusEntity);

                //if (_ojList != null)
                //{
                //    _sdMAIN.LoadDocument((byte[])_ojList, DocumentFormat.Xlsx);    // 일반 컨트롤 일때 : DocumentFormat.Xls   // UC일때,  enFileFormat.Xls
                //}
                //else
                //{
                //    CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                //}

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
            }
            finally
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }
        #region 숫자 -> 한글로
        static public string Number2Hangle(Double lngNumber)
        {
            bool UseDecimal = false;
            string Sign = "";
            int i = 0;
            int Level = 0;

            string[] NumberChar = new string[] { "", "일", "이", "삼", "사", "오", "육", "칠", "팔", "구" };
            string[] LevelChar = new string[] { "", "십", "백", "천" };
            string[] DecimalChar = new string[] { "", "만", "억", "조", "경" };

            string strValue = string.Format("{0}", lngNumber);
            string NumToKorea = Sign;
            UseDecimal = false;

            for (i = 0; i < strValue.Length; i++)
            {
                Level = strValue.Length - i;
                if (strValue.Substring(i, 1) != "0")
                {
                    UseDecimal = true;
                    if (((Level - 1) % 4) == 0)
                    {
                        NumToKorea = NumToKorea + NumberChar[int.Parse(strValue.Substring(i, 1))] + DecimalChar[(Level - 1) / 4];
                        UseDecimal = false;
                    }
                    else
                    {
                        if (strValue.Substring(i, 1) == "1")
                        {
                            NumToKorea = NumToKorea + LevelChar[(Level - 1) % 4];
                        }
                        else
                        {
                            NumToKorea = NumToKorea + NumberChar[int.Parse(strValue.Substring(i, 1))] + LevelChar[(Level - 1) % 4];
                        }
                    }
                }
                else
                {
                    if ((Level % 4 == 0) && UseDecimal)
                    {
                        NumToKorea = NumToKorea + DecimalChar[Level / 4];
                        UseDecimal = false;
                    }
                }
            }
            return NumToKorea;
        }
        #endregion


        #region ○ 내보내기 버튼 클릭시 처리하기
        private void Form_ExportButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                DataTable tDataTable = _gdMAIN_VIEW.GridControl.DataSource as DataTable;
                if (_gdMAIN_VIEW.RowCount > 0)
                {

                    SaveFileDialog mDlg = new SaveFileDialog();
                    mDlg.InitialDirectory = Application.StartupPath;
                    //mDlg.Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*";
                    mDlg.Filter = "Excel files (*.xls)|*.xls|Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                    mDlg.FilterIndex = 1;
                    if (mDlg.ShowDialog() == DialogResult.OK)
                    {
                        _gdMAIN_VIEW.ExportToXlsx(mDlg.FileName);
                        CoFAS_DevExpressManager.ShowInformationMessage("저장이 완료 되었습니다.");
                    }

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

        #region ○ 가져오기 버튼 클릭시 처리하기
        private void Form_ImportButtonClicked(object pSender, EventArgs pEventArgs)
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

        #region ○ 초기화 버튼 클릭시 처리하기
        private void Form_InitialButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                if (_gdMAIN_VIEW.GridControl != null && CoFAS_ConvertManager.DataTable_FindCount(_gdMAIN_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", ""))
                {
                    //if (CoFAS_DevExpressManager.ShowQuestionMessage("작업중인 자료가 있습니다.\n초기화 하겠습니까?") == DialogResult.No)
                    if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_WORKING + "\n" + _pMSG_RESET_QUESTION) == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        InitializeSetting();

                        //DisplayMessage("초기화했습니다.");
                        DisplayMessage(_pMSG_RESET_COMPLETE);
                    }
                }
                else
                {
                    InitializeSetting();

                    //DisplayMessage("초기화했습니다.");
                    DisplayMessage(_pMSG_RESET_COMPLETE);
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

        #region ○ 화면 설정 버튼 클릭시 처리하기 - 언어 및 화면 컨트롤러 명칭 변경 설정
        private void Form_SettingButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                CoFAS_MES.CORE.UserForm.frmPageSetting xfrmPageSetting = new CORE.UserForm.frmPageSetting();
                //xfrmPageSetting.PASS_CORP_CODE = _pMaterialOrderRegister_RequestEntity.CORP_CODE;
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

        #endregion

        #region ● DB 처리

        #region ○ 메인조회 - MainFind_DisplayData(string pCRUD)

        private void MainFind_DisplayData(string pCRUD)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                _pMaterialOrderRegister_RequestEntity.CRUD = pCRUD;
                _pMaterialOrderRegister_RequestEntity.DATE_FROM = DateTime.Parse(_luTORDER_DATE.FromDateTime.ToString()).ToString("yyyyMMdd");
                _pMaterialOrderRegister_RequestEntity.DATE_TO = DateTime.Parse(_luTORDER_DATE.ToDateTime.ToString()).ToString("yyyyMMdd");

                _pMaterialOrderRegister_RequestEntity.ORDER_ID = _luTORDER_ID.Text;
                _pMaterialOrderRegister_RequestEntity.USE_YN = _luTUSE_YN.GetValue();
                _pMaterialOrderRegister_RequestEntity.VEND_CODE = _luTVEND_CODE.CodeText.ToString();
                _pMaterialOrderRegister_RequestEntity.VEND_NAME = _luTVEND_CODE.NameText.ToString();
                _pMaterialOrderRegister_RequestEntity.PART_CODE = _luTPART_CODE.CodeText.ToString();
                _pMaterialOrderRegister_RequestEntity.PART_NAME = _luTPART_CODE.NameText.ToString();
                _pMaterialOrderRegister_RequestEntity.VEND_PART_CODE = _luTVEND_PART_CODE.Text.ToString();

                using (DBManager pDBManager = new DBManager())
                {

                    _dtList = new MaterialOrderRegister_RequestProvider(pDBManager).MaterialOrderRegister_Request_R10(_pMaterialOrderRegister_RequestEntity);

                    if (_dtList != null && _dtList.Rows.Count > 0)
                    {
                        if (pCRUD == "")
                            _dtList.Rows.Clear();

                        CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList);
                        _gdMAIN_VIEW.Columns["CRUD"].AppearanceCell.BackColor = Color.Red;
                        // _gdMAIN_VIEW.Columns["ORDER_QTY"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                        // _gdMAIN_VIEW.Columns["UNITCOST"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                        // _gdMAIN_VIEW.Columns["COST"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                        //
                        // _gdMAIN_VIEW.Columns["ORDER_QTY"].DisplayFormat.FormatString = "{0:#,###.##0}";
                        // _gdMAIN_VIEW.Columns["UNITCOST"].DisplayFormat.FormatString = "{0:#,###.##0}";
                        // _gdMAIN_VIEW.Columns["COST"].DisplayFormat.FormatString = "{0:#,###.##0}";
                        //글랜젠은 컬럼 비활성
                        if (DBManager.InitDatabaseName == "coever_mes_glenzen")
                        {
                            _gdMAIN_VIEW.Columns["INSPECT_STATUS"].Visible = false;
                        }

                        if (_pLocation_Code != "" && _pLocation_YN)
                        {
                            int rowHandle = _gdMAIN_VIEW.LocateByValue("ORDER_ID", _pLocation_Code);
                            if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                                _gdMAIN_VIEW.FocusedRowHandle = rowHandle;


                            //조회 후 초기화 
                            _pLocation_Code = "";
                        }
                    }
                    else
                    {
                        if (pCRUD == "R")
                            //CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                            CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
                        _dtList.Rows.Clear();
                        CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩
                    }
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

        #region ○ 저장 - InputData_Save(DataTable dtSave)

        private void InputData_Save(MaterialOrderRegisterEntity_Request _pMaterialOrderRegister_RequestEntityt)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                bool isError = false;

                using (DBManager pDBManager = new DBManager())
                {
                    //if (CoFAS_DevExpressManager.ShowQuestionMessage("저장 하시겠습니까?") == DialogResult.Yes)
                    if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_SAVE_QUESTION) == DialogResult.Yes)
                    {

                        isError = new MaterialOrderRegister_RequestBusiness().MaterialOrderRegister_Request_Info_Save(_pMaterialOrderRegister_RequestEntityt);

                        if (isError)
                        {
                            //CoFAS_DevExpressManager.ShowInformationMessage("저장 오류 발생! 데이터를 확인 하세요.");
                            CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                        }
                        else
                        {
                            //정상 처리
                            //CoFAS_DevExpressManager.ShowInformationMessage("저장 처리 되었습니다.");
                            CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                            _pLocation_Code = _pMaterialOrderRegister_RequestEntityt.RTN_KEY;  //저장 위치 
                            MainFind_DisplayData("R");
                        }
                    }
                    else
                    {
                        return;
                    }

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

        #endregion

        private void _luTPART_CODE__OnOpenClick(object sender, EventArgs e)
        {
            //VendCostInfo
            frmCommonPopup.CRUD = "R";
            frmCommonPopup.USER_CODE = _pUSER_CODE;
            frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
            frmCommonPopup.FONT_TYPE = _pFONT_SETTING;



            // 0 서비스네임 1 공통코드경우 CODE_TYPE 으로구분자 올린다.
            frmCommonPopup.ARRAY = new object[2] { "Material_Code", "" };

            //검색조건 전달 0 코드 1 명칭
            frmCommonPopup.ARRAY_CODE = new object[2] { _luTPART_CODE.CodeText.ToString(), _luTPART_CODE.NameText.ToString() };

            //ucVendCodeInfoPopup xucVendCodeInfoPopup = new CORE.UserControls.ucVendCodeInfoPopup("PartCodeInfo"); //유저컨트롤러 설정 부분
            frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분
            xfrmCommonPopup.ShowDialog();

            if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
            {
                _luTPART_CODE.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["CD"].ToString();
                _luTPART_CODE.NameText = xfrmCommonPopup.dtReturn.Rows[0]["CD_NM"].ToString();

                //데이터 세팅
            }

            xfrmCommonPopup.Dispose();
        }

        private void _luTVEND_CODE__OnOpenClick(object sender, EventArgs e)
        {
            //VendCostInfo
            frmCommonPopup.CRUD = "R";
            frmCommonPopup.USER_CODE = _pUSER_CODE;
            frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
            frmCommonPopup.FONT_TYPE = _pFONT_SETTING;



            // 0 서비스네임 1 공통코드경우 CODE_TYPE 으로구분자 올린다.
            frmCommonPopup.ARRAY = new object[2] { "Vend_Code_I", "" };

            //검색조건 전달 0 코드 1 명칭
            frmCommonPopup.ARRAY_CODE = new object[2] { _luTVEND_CODE.CodeText.ToString(), _luTVEND_CODE.NameText.ToString() };

            //ucVendCodeInfoPopup xucVendCodeInfoPopup = new CORE.UserControls.ucVendCodeInfoPopup("PartCodeInfo"); //유저컨트롤러 설정 부분
            frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분
            xfrmCommonPopup.ShowDialog();

            if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
            {
                _luTVEND_CODE.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["CD"].ToString();
                _luTVEND_CODE.NameText = xfrmCommonPopup.dtReturn.Rows[0]["CD_NM"].ToString();

                //데이터 세팅
            }

            xfrmCommonPopup.Dispose();
        }

        private void _luPART__OnOpenClick(object sender, EventArgs e)
        {
            // 거래처 없음 체크박스에 따라 팝업 호출 변경

            // 거래처 없음
            frmCommonPopup.CRUD = "R";
            frmCommonPopup.USER_CODE = _pUSER_CODE;
            frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
            frmCommonPopup.FONT_TYPE = _pFONT_SETTING;



            // 0 서비스네임 1 공통코드경우 CODE_TYPE 으로구분자 올린다.
             frmCommonPopup.ARRAY = new object[2] { "Material_Code_T02", "" };

            //검색조건 전달 0 코드 1 명칭
            frmCommonPopup.ARRAY_CODE = new object[2] { _luPART.CodeText.ToString(), _luPART.NameText.ToString() };

            //ucVendCodeInfoPopup xucVendCodeInfoPopup = new CORE.UserControls.ucVendCodeInfoPopup("PartCodeInfo"); //유저컨트롤러 설정 부분
            frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분
            xfrmCommonPopup.ShowDialog();

            if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
            {
                _luPART.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["CD"].ToString();
                _luPART.NameText = xfrmCommonPopup.dtReturn.Rows[0]["CD_NM"].ToString();
                _luVEND.CodeText = "";
                _luVEND.NameText = "";
                _luUNITCOST.Text = "0";

                //데이터 세팅
            }

            xfrmCommonPopup.Dispose();
        }

        private void _luVEND__OnOpenClick(object sender, EventArgs e)
        {
          
            if (!_luPART.CodeText.Equals(""))
            {
                // 자재코드가 있을때 거래처 매입 공통
                //VendCostInfo
                frmCommonPopup.CRUD = "R";
                frmCommonPopup.USER_CODE = _pUSER_CODE;
                frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                frmCommonPopup.FONT_TYPE = _pFONT_SETTING;



                // 0 서비스네임 1 공통코드경우 CODE_TYPE 으로구분자 올린다.
                frmCommonPopup.ARRAY = new object[2] { "Vend_Code_I", "" };

                //검색조건 전달 0 코드 1 명칭
                frmCommonPopup.ARRAY_CODE = new object[2] { _luVEND.CodeText.ToString(), _luVEND.NameText.ToString() };

                //ucVendCodeInfoPopup xucVendCodeInfoPopup = new CORE.UserControls.ucVendCodeInfoPopup("PartCodeInfo"); //유저컨트롤러 설정 부분
                frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분
                xfrmCommonPopup.ShowDialog();

                if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                {
                    _luVEND.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["CD"].ToString();
                    _luVEND.NameText = xfrmCommonPopup.dtReturn.Rows[0]["CD_NM"].ToString();

                    //데이터 세팅
                }

                xfrmCommonPopup.Dispose();

            }
            else
            {
                // 없을때는 공통
                //VendCostInfo
                frmCommonPopup.USER_CODE = _pUSER_CODE;
                frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                frmCommonPopup.ARRAY = new object[2] { "Material_Code", "" }; //넘기는 파라메터 에 따라 설정



                //ucVendCodeInfoPopup xucVendCodeInfoPopup = new CORE.UserControls.ucVendCodeInfoPopup("PartCodeInfo"); //유저컨트롤러 설정 부분
                frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("VendCostInfo"); //유저컨트롤러 설정 부분
                xfrmCommonPopup.ShowDialog();

                if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                {
                    _luVEND.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["VEND_CODE"].ToString();
                    _luVEND.NameText = xfrmCommonPopup.dtReturn.Rows[0]["VEND_NAME"].ToString();
                    _luPART.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["PART_CODE"].ToString();
                    _luPART.NameText = xfrmCommonPopup.dtReturn.Rows[0]["PART_NAME"].ToString();
                    _luUNITCOST.Text = xfrmCommonPopup.dtReturn.Rows[0]["PART_UNITCOST"].ToString();
                }


                xfrmCommonPopup.Dispose();
            }
        }

        private void _ucbtINSPECT_REQUEST_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            DataTable tDataTable = _gdMAIN_VIEW.GridControl.DataSource as DataTable;

           // CoFAS_ConvertManager.DataTable_FindCount(_gdMAIN_VIEW.GridControl.DataSource as DataTable, "CRUD ='Y'", "");

            for (int i=0; i< tDataTable.Rows.Count; i++)
            {
                if(tDataTable.Rows[i]["CRUD"].ToString()=="Y")
                {
                    if(tDataTable.Rows[i]["INSPECT_STATUS"].ToString() != "QC010001")
                    {
                        CoFAS_DevExpressManager.ShowInformationMessage("이미 시험의뢰를 맡긴 발주가 있습니다.");
                        return;
                    }
                    cnt++;
                }
            }
            // MessageBox.Show(cnt.ToString());
            if(cnt==0)
            { 
                CoFAS_DevExpressManager.ShowInformationMessage("하나 이상의 발주를 선택하세요");
                return;
            }
            if (CoFAS_DevExpressManager.ShowQuestionMessage(cnt.ToString()+"건의 시험의뢰를 하시겠습니까?") == DialogResult.Yes)
            {
                _pMaterialOrderRegister_RequestEntity.CRUD = "U";
                bool isError;
                 isError = new MaterialOrderRegister_RequestBusiness().MaterialOrderRegister_Request_Info_Check_Save(_pMaterialOrderRegister_RequestEntity, tDataTable);

                if (isError)
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("저장 오류 발생! 데이터를 확인 하세요.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                }
                else
                {
                    //정상 처리
                    //CoFAS_DevExpressManager.ShowInformationMessage("저장 처리 되었습니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                    _pLocation_Code = _pMaterialOrderRegister_RequestEntity.RTN_KEY;  //저장 위치 
                    MainFind_DisplayData("R");
                }
            }

        }

        private void _ucbtBOM_SpendQtyCalc_Click(object sender, EventArgs e)
        {
            //VendCostInfo
            CoFAS_MES.UI.MM.UserForm.frmCommonPopup.CRUD = "R";
            CoFAS_MES.UI.MM.UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
            CoFAS_MES.UI.MM.UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
            CoFAS_MES.UI.MM.UserForm.frmCommonPopup.FONT_TYPE = _pFONT_SETTING;



            // 0 서비스네임 1 공통코드경우 CODE_TYPE 으로구분자 올린다.
            CoFAS_MES.UI.MM.UserForm.frmCommonPopup.ARRAY = new object[2] { "Vend_Code_I", "" };

            //검색조건 전달 0 코드 1 명칭
            CoFAS_MES.UI.MM.UserForm.frmCommonPopup.ARRAY_CODE = new object[2] { _luTVEND_CODE.CodeText.ToString(), _luTVEND_CODE.NameText.ToString() };

            //ucVendCodeInfoPopup xucVendCodeInfoPopup = new CORE.UserControls.ucVendCodeInfoPopup("PartCodeInfo"); //유저컨트롤러 설정 부분
            CoFAS_MES.UI.MM.UserForm.frmCommonPopup xfrmCommonPopup = new CoFAS_MES.UI.MM.UserForm.frmCommonPopup("BOM_SpendQtyCalc"); //유저컨트롤러 설정 부분
            xfrmCommonPopup.ShowDialog();

            if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
            {
                _luTVEND_CODE.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["CD"].ToString();
                _luTVEND_CODE.NameText = xfrmCommonPopup.dtReturn.Rows[0]["CD_NM"].ToString();

                //데이터 세팅
            }
            
            xfrmCommonPopup.Dispose();
            Form_SearchButtonClicked(null, null);
        }


        #region ○ 수량 / 단가 계산

        private void _luTextEdit__OnTextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal pCOST = 0;
                decimal pQTY = 0;
                decimal pUNITCOST = 0;

                pUNITCOST = Convert.ToDecimal(_luUNITCOST.Text == "" ? "0.00" : _luUNITCOST.Text);
                pQTY = Convert.ToDecimal(_luORDER_QTY.Text == "" ? "0.00" : _luORDER_QTY.Text);
                pCOST = pUNITCOST * pQTY;
                pCOST = Math.Round(pCOST, 2);

                _luCOST.Text = pCOST.ToString();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }


        #endregion

        #region ○ 숫자만 입력

        private void _luTextEdit__OnKeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b')
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("숫자를 입력하시기 바랍니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_INPUT_NUMERIC);
                    return;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        private void _ckALLCHECK_CheckedChanged(object sender, EventArgs e)
        {
            DataTable _dtTemp = _gdMAIN.DataSource as DataTable;
            if (_dtTemp == null) return;
            if (_dtTemp.Rows.Count <= 0) return;
            for (int i = 0; i < _dtTemp.Rows.Count; i++)
            {
                _dtTemp.Rows[i]["CRUD"] = _ckALLCHECK.Checked == true ? "Y" : "N";
            }
        }
    }


}

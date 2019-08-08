﻿using CoFAS_MES.CORE.BaseForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CoFAS_MES.UI.MM.Business;
using CoFAS_MES.UI.MM.Entity;
using CoFAS_MES.CORE.Function;
using CoFAS_MES.CORE.Business;
using DevExpress.XtraGrid.Views.Grid;
using CoFAS_MES.CORE.UserForm;

namespace CoFAS_MES.UI.MM
{
    public partial class WasherInRegister : frmBaseNone
    {
        
        public string _pCORP_CODE = string.Empty;       // 회사코드       
        public string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        public string _pUSER_NAME = string.Empty;       // 사용자이름
        public string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어
        public string _pWINDOW_NAME = string.Empty;     // 화면 명칭
        public string _pFONT_TYPE = string.Empty;       // 시스템 폰트 타입 설정
        public int _pFONT_SIZE = 9;                     // 시스템 폰트 사이즈 설정 기본 9
        private Font _pFONT_SETTING = null;             // 시스템 폰트 설정
        private string _pLocation_Code = string.Empty;  // 저장/수정 후 로케이션 위치 저장
        private bool _pLocation_YN = true;              // 저장위치 사용여부
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

        private WasherInRegisterEntity _pWasherInRegisterEntity = null; // 엔티티 생성

        private DataTable _dtList = null; //조회 데이터 리스트

        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용

        private decimal in_qty = 0;
        public WasherInRegister()
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

                //if (CoFAS_DevExpressManager.ShowQuestionMessage("작업 종료 하겠습니까?") == DialogResult.No)
                if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_EXIT_QUESTION) == DialogResult.No)
                {
                    pFormClosingEventArgs.Cancel = true;

                    _luT_WASHER._OnOpenClick -= _luT_WASHER_OnOpenClick;
                    _luWASHER_CODE._OnButtonPressed -= _luWASHER_OnButtonPressed;

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

                SearchButtonClicked += new EventHandler(Form_SearchButtonClicked);
                SaveButtonClicked += new EventHandler(Form_SaveButtonClicked);
                AddItemButtonClicked += new EventHandler(Form_AddItemButtonClicked);
                DeleteButtonClicked += new EventHandler(Form_DeleteButtonClicked);
                PrintButtonClicked += new EventHandler(Form_PrintButtonClicked);
                ExportButtonClicked += new EventHandler(Form_ExportButtonClicked);
                ImportButtonClicked += new EventHandler(Form_ImportButtonClicked);
                InitialButtonClicked += new EventHandler(Form_InitialButtonClicked);
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
                _pnLeft.Visible = false;

                //메인 화면 전역 변수 처리
                _pCORP_CODE = MainForm.UserEntity.CORP_CODE;
                _pUSER_CODE = MainForm.UserEntity.USER_CODE;
                _pUSER_NAME = MainForm.UserEntity.USER_NAME;
                _pLANGUAGE_TYPE = MainForm.UserEntity.LANGUAGE_TYPE;
                _pFONT_TYPE = MainForm.UserEntity.FONT_TYPE;
                _pFONT_SIZE = MainForm.UserEntity.FONT_SIZE;
                _pFONT_SETTING = new Font(_pFONT_TYPE, _pFONT_SIZE);
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

                //메뉴 화면 엔티티 설정
                _pWasherInRegisterEntity = new WasherInRegisterEntity();
                _pWasherInRegisterEntity.USER_CODE = _pUSER_CODE;
                _pWasherInRegisterEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                
                //화면 설정 언어 & 명칭 변경.
                DataTable dtLanguage = new LanguageBusiness().Language_Info(_pWINDOW_NAME, _pLANGUAGE_TYPE);

                if (dtLanguage != null && dtLanguage.Rows.Count > 0)
                {
                    CoFAS_ControlManager.Language_Info(dtLanguage, this);
                }

                //그리드 설정
                InitializeGrid();

                //화면 컨트롤러 설정
                InitializeControl(true);

                //그리드 초기화 

                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                _pWasherInRegisterEntity.CRUD = "";
                if (_pFirstYN)
                {
                    MainFind_DisplayData(); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.

                    _luT_WASHER._OnOpenClick += _luT_WASHER_OnOpenClick;
                    _luWASHER_CODE._OnButtonPressed += _luWASHER_OnButtonPressed;

                    _pFirstYN = false;
                }

                //컨트롤러 별 추가 이벤트 생성은 화면 설정 마지막에 진행
                _gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick;

                _luUNITCOST.Properties.MaxLength = 10;
                _luINOUT_QTY.Properties.MaxLength = 10;
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

        private void InitializeControl(bool bSearch)
        {
            try
            {
                //조회조건 영역
                if (bSearch)
                {
                    _luT_WASHER_DATE.FromDateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);  //조회 시작일, 매월 초 날짜로 설정
                    _luT_WASHER_DATE.ToDateTime = DateTime.Today;  //조회 종료일, 당일 설정
                    _luT_WASHER.NameText = "";
                    _luT_WASHER.CodeText = "";
                    
                    _luTUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "common_code", "CD99", "", "").Tables[0], 0, 0, "");
                    _luTUSE_YN.ItemIndex = 0;
                    
                    _luUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "common_code", "CD99", "", "").Tables[0], 0, 0, "");

                    _luPART_UNIT.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "COMMON_CODE", "CD04", "", "").Tables[0], 0, 0, "");
                    
                }

                //데이터 영역

                _luINOUT_ID.Text = "";
                _luINOUT_ID.ReadOnly = true;

                _luINOUT_DATE.DateTime = DateTime.Today;
                
                _luWASHER_CODE.Text = "";
                _luWASHER_CODE.ReadOnly = true;
                
                _luUSE_YN.ItemIndex = 0;

                _luINOUT_QTY.Text = "0";
                _luINOUT_QTY.ReadOnly = false;
                
                _luUNITCOST.Text = "0";
                _luUNITCOST.ReadOnly = false;

                _luCOST.Text = "0";
                _luCOST.ReadOnly = true;

                _luREMARK.Text = "";
                _luREMARK.ReadOnly = false;

                // 컨트롤러 유효성 검증 처리 기본 컨트롤러 에서만 사용 
                dxValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
                dxValidationProvider.Validate();

                //dxValidationProvider.SetValidationRule(_luGRID_NAME, NotEmptyValidationRule);
                //dxValidationProvider.SetValidationRule(_luGRIDVIEW_NAME, NotEmptyValidationRule);
                // 컨트롤러 유효성 검증 처리

                //그리드 초기화 
                _gdMAIN.DataSource = null;

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

        #region ○ 부분 컨트롤 초기화 - InitializeControl2()
        //private void InitializeControl2()
        //{
        //    try
        //    {
        //        _luINOUT_ID.Text = "";
        //        _luINOUT_ID.ReadOnly = true;

        //        _luINOUT_DATE.DateTime = DateTime.Today;

        //        _luINOUT_CODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", "COMMON_CODE", "MR02", "", "").Tables[0], 0, 0, "");

        //        _luPART.CodeText = "";
        //        _luPART.NameText = "";
        //        _luPART.CodeReadOnly = true;
        //        _luPART.NameReadOnly = true;


        //        _luPART_UNIT.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", "COMMON_CODE", "CD04", "", "").Tables[0], 0, 0, "");

        //        _luNIN_QTY.Text = "";
        //        //_luNIN_QTY.ReadOnly = true;
        //        //_lciNIN_QTY.Text = "미입고수량";

        //        _luVEND.CodeText = "";
        //        _luVEND.NameText = "";
        //        _luVEND.CodeReadOnly = true;
        //        _luVEND.NameReadOnly = true;

        //        _luREFERENCE_ID.Text = "";
        //        _luREFERENCE_ID.ReadOnly = true;

        //        _luINOUT_QTY.Text = "0";
        //        _luINOUT_QTY.ReadOnly = false;

        //        _luUNITCOST.Text = "0";
        //        _luUNITCOST.ReadOnly = false;

        //        _luCOST.Text = "0";
        //        _luCOST.ReadOnly = true;

        //        _luUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", "common_code", "CD99", "", "").Tables[0], 0, 0, "");
        //        _luUSE_YN.ItemIndex = 0;
        //        _luREMARK.Text = "";
        //        _luREMARK.ReadOnly = false;

        //        _luPART.CodeReadOnly = false;
        //        _luPART.NameReadOnly = false;
        //        _luPART.NameEnabled = true;

        //        _luVEND.CodeReadOnly = false;
        //        _luVEND.NameReadOnly = false;
        //        _luVEND.NameEnabled = true;

        //        dxValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
        //        dxValidationProvider.Validate();

        //    }
        //    catch (ExceptionManager pExceptionManager)
        //    {
        //        CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
        //    }
        //    finally
        //    {

        //    }
        //}
        #endregion
        
        // 추가 이벤트 생성
        #region ○ 메인 그리드 로우 선택 이벤트 생성 - _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        private void _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;

                CoFAS_ControlManager.Controls_Binding(gv, false, this); 

                _pWasherInRegisterEntity.CRUD = "R";

                //_lciNIN_QTY.Text = "발주  수량";
                //_luNIN_QTY.Text = gv.GetFocusedRowCellValue("ORDER_QTY").ToString();
                //_luNIN_QTY.Visible = false;
                in_qty = Convert.ToDecimal(_luINOUT_QTY.Text);
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion

        // 메인 버튼 처리영역
        #region ○ 조회 버튼 클릭시 처리하기
        private void Form_SearchButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                if (_luT_WASHER_DATE.FromDateTime > _luT_WASHER_DATE.ToDateTime)
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("조회 일자를 확인해 주세요.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_CHECK_SEARCH_DATE);
                }
                else
                {
                    CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                    InitializeControl(false);

                    _pWasherInRegisterEntity.CRUD = "R";
                    _pWasherInRegisterEntity.DATE_FROM = DateTime.Parse(_luT_WASHER_DATE.FromDateTime.ToString()).ToString("yyyyMMdd");//Convert.ToString(_luTORDER_DATE.FromDateTime).Replace("-", "").Substring(0, 8);//
                    _pWasherInRegisterEntity.DATE_TO = DateTime.Parse(_luT_WASHER_DATE.ToDateTime.ToString()).ToString("yyyyMMdd");//Convert.ToString(_luTORDER_DATE.ToDateTime).Replace("-", "").Substring(0, 8);//
                    _pWasherInRegisterEntity.WASHER_NAME = _luT_WASHER.NameText;
                    _pWasherInRegisterEntity.WASHER_CODE = _luT_WASHER.CodeText;
                    _pWasherInRegisterEntity.USE_YN = _luTUSE_YN.GetValue();
                    
                    MainFind_DisplayData();
                    
                    //DisplayMessage("조회 되었습니다.");
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

                if (_luINOUT_QTY.Text == "0" || _luINOUT_QTY.Text == "")
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("수량을 입력해 주세요.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_INPUT_DATA);
                    return;
                }

                decimal qty_chk;
                qty_chk = Convert.ToDecimal(_luINOUT_QTY.Text);
                if (qty_chk < 0)
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("입고수량이 0보다 작을 수 없습니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_INPUT_LARGER_THAN_0);
                    return;
                }

                if (_luWASHER_CODE.Text == null || _luWASHER_CODE.Text == "")
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("와셔를 입력해 주세요.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_INPUT_DATA);
                    return;
                }

                //확인
                if (_luINOUT_ID.Text.ToString() != "")
                    _pWasherInRegisterEntity.CRUD = "U";
                else
                    _pWasherInRegisterEntity.CRUD = "C";


                _pWasherInRegisterEntity.INOUT_TYPE = "I";
                _pWasherInRegisterEntity.INOUT_ID = _luINOUT_ID.Text.ToString();
                _pWasherInRegisterEntity.INOUT_DATE = _luINOUT_DATE.DateTime.ToString("yyyyMMdd");
                _pWasherInRegisterEntity.INOUT_SEQ = "000000";
                _pWasherInRegisterEntity.WASHER_CODE = _luWASHER_CODE.Text;
                _pWasherInRegisterEntity.INOUT_QTY = _luINOUT_QTY.Text.ToString().ToString() == "" ? "0" : _luINOUT_QTY.Text.ToString();
                _pWasherInRegisterEntity.PART_UNIT = _luPART_UNIT.GetValue();
                _pWasherInRegisterEntity.UNITCOST = _luUNITCOST.Text.ToString() == "" ? "0" : _luUNITCOST.Text.ToString().ToString();
                _pWasherInRegisterEntity.COST = _luCOST.Text.ToString() == "" ? "0" : _luCOST.Text.ToString().ToString();
                _pWasherInRegisterEntity.REFERENCE_ID = _luREFERENCE_ID.Text.ToString();
                _pWasherInRegisterEntity.REMARK = _luREMARK.Text.ToString();
                _pWasherInRegisterEntity.USE_YN = _luUSE_YN.GetValue();

                InputData_Save(_pWasherInRegisterEntity);

                //InitializeControl2();
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

        #region ○ 신규 버튼 클릭시 처리하기
        private void Form_AddItemButtonClicked(object pSender, EventArgs pEventArgs)
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
                if (_luINOUT_ID.Text.ToString() != "")
                {
                    _pWasherInRegisterEntity.CRUD = "D";
                }
                else
                {
                    //MessageBox.Show("삭제할 데이터를 선택해 주세요.");
                    MessageBox.Show(_pMSG_SELECT);
                    return;
                }
                //if (CoFAS_DevExpressManager.ShowQuestionMessage("입고 데이터를 삭제하시겠습니까? \n입고번호 : " + _luINOUT_ID.Text) == DialogResult.No)
                if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_DELETE_QUESTION + _luINOUT_ID.Text) == DialogResult.No)
                {
                    return;
                }

                _pWasherInRegisterEntity.INOUT_TYPE = "I";
                _pWasherInRegisterEntity.INOUT_ID = _luINOUT_ID.Text.ToString();
                _pWasherInRegisterEntity.INOUT_DATE = _luINOUT_DATE.DateTime.ToString("yyyyMMdd");
                _pWasherInRegisterEntity.INOUT_SEQ = "000000";
                _pWasherInRegisterEntity.WASHER_CODE = _luWASHER_CODE.Text;
                _pWasherInRegisterEntity.INOUT_QTY = _luINOUT_QTY.Text.ToString().ToString() == "" ? "0" : _luINOUT_QTY.Text.ToString();
                _pWasherInRegisterEntity.PART_UNIT = _luPART_UNIT.GetValue();
                _pWasherInRegisterEntity.UNITCOST = _luUNITCOST.Text.ToString() == "" ? "0" : _luUNITCOST.Text.ToString().ToString();
                _pWasherInRegisterEntity.COST = _luCOST.Text.ToString() == "" ? "0" : _luCOST.Text.ToString().ToString();
                _pWasherInRegisterEntity.REMARK = _luREMARK.Text.ToString();
                _pWasherInRegisterEntity.USE_YN = "N";

                InputData_Save(_pWasherInRegisterEntity);
                InitializeControl(false);
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

        #region ○ 내보내기 버튼 클릭시 처리하기
        private void Form_ExportButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                //if (fpMain.ActiveSheet.RowCount > 0)
                //{
                //    SaveFileDialog mDlg = new SaveFileDialog();
                //    mDlg.InitialDirectory = Application.StartupPath;
                //    mDlg.Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*";
                //    mDlg.FilterIndex = 1;
                //    if (mDlg.ShowDialog() == DialogResult.OK)
                //    {
                //        fpMain.SaveExcel(mDlg.FileName, FarPoint.Excel.ExcelSaveFlags.SaveCustomColumnHeaders);
                //        DevExpressManager.ShowInformationMessage("저장이 완료 되었습니다.");
                //    }
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
                //확인

                //if (CoFAS_DevExpressManager.ShowQuestionMessage("작업 초기화 하겠습니까?") == DialogResult.No)
                //{
                //    return;
                //}
                //else
                //{
                InitializeControl(false);
               
                //DisplayMessage("초기화했습니다.");
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

        #region ○ 화면 설정 버튼 클릭시 처리하기 - 언어 및 화면 컨트롤러 명칭 변경 설정
        private void Form_SettingButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                CoFAS_MES.CORE.UserForm.frmPageSetting xfrmPageSetting = new CORE.UserForm.frmPageSetting();
                //xfrmPageSetting.PASS_CORP_CODE = _pCORP_CDDE;
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
                Close(); //탭 화면 닫기
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
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
                _dtList = new WasherInRegisterBusiness().Material_In_Mst(_pWasherInRegisterEntity);

                if (_pWasherInRegisterEntity.CRUD == "") _dtList.Rows.Clear();


                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pWasherInRegisterEntity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩

                    if (_pLocation_Code != "" && _pLocation_YN)
                    {
                        int rowHandle = _gdMAIN_VIEW.LocateByValue("INOUT_ID", _pLocation_Code);
                        if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                            _gdMAIN_VIEW.FocusedRowHandle = rowHandle;


                        //조회 후 초기화 
                        _pLocation_Code = "";
                    }
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
                    _dtList.Rows.Clear();
                    Form_InitialButtonClicked(null, null);
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {
                _gdMAIN_VIEW.BestFitColumns();

                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }

        #endregion

        #region ○ 저장 - InputData_Save(DataTable dtSave)

        private void InputData_Save(WasherInRegisterEntity _pWasherInRegisterEntity)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                bool isError = false;

                //if (CoFAS_DevExpressManager.ShowQuestionMessage("저장 하시겠습니까?") == DialogResult.Yes)
                if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_SAVE_QUESTION) == DialogResult.Yes)
                {
                    isError = new WasherInRegisterBusiness().WasherInRegister_Info_Save(_pWasherInRegisterEntity);
                    // 자재입고
                    if (isError)
                    {
                        //오류 발생.
                        //CoFAS_DevExpressManager.ShowInformationMessage("저장 오류 발생! 데이터를 확인 하세요.");
                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                    }
                    else
                    {


                        _pLocation_Code = _pWasherInRegisterEntity.RTN_KEY;  //저장 위치

                        _pWasherInRegisterEntity.CRUD = "R";
                        _pWasherInRegisterEntity.DATE_FROM = DateTime.Parse(_luT_WASHER_DATE.FromDateTime.ToString()).ToString("yyyyMMdd");// Convert.ToString(_luTORDER_DATE.FromDateTime).Substring(0, 10).Replace("-", "");
                        _pWasherInRegisterEntity.DATE_TO = DateTime.Parse(_luT_WASHER_DATE.ToDateTime.ToString()).ToString("yyyyMMdd");//Convert.ToString(_luTORDER_DATE.ToDateTime).Substring(0, 10).Replace("-", "");
                        _pWasherInRegisterEntity.WASHER_CODE = _luWASHER_CODE.Text;
                        _pWasherInRegisterEntity.INOUT_ID = _luINOUT_ID.Text;
                        _pWasherInRegisterEntity.USE_YN = _luTUSE_YN.GetValue();

                        //_luINOUT_CODE.ReadOnly = false;
                        Form_SearchButtonClicked(null, null);


                        //정상 처리
                        //CoFAS_DevExpressManager.ShowInformationMessage("저장 처리 되었습니다.");
                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                        //InitializeControl(false);




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

        #region ○ 팝업 불러오기

        #region ○ 조회조건 팝업 자재코드

        private void _luT_WASHER_OnOpenClick(object sender, EventArgs e)
        {
            try
            {
                frmCommonPopup.CRUD = "R";
                frmCommonPopup.USER_CODE = _pUSER_CODE;
                frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                // 0 서비스네임 1 공통코드경우 CODE_TYPE 으로구분자 올린다.
                frmCommonPopup.ARRAY = new object[2] { "Washer_Info", "" };
                frmCommonPopup.ARRAY_CODE = new object[2] { _luT_WASHER.CodeText.ToString(), _luT_WASHER.NameText.ToString() };
                frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분

                xfrmCommonPopup.ShowDialog();

                if (xfrmCommonPopup.dtReturn == null)
                {
                    xfrmCommonPopup.Dispose();
                    return;
                }

                if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                {
                    _luT_WASHER.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["CD"].ToString();     // 와셔번호
                    _luT_WASHER.NameText = xfrmCommonPopup.dtReturn.Rows[0]["CD_NM"].ToString();     // 와셔명
                }

                xfrmCommonPopup.Dispose();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion
        
        #region ○ 자재찾기

        private void _luWASHER_OnButtonPressed(object pSender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs pButtonPressedEventArgs)
        {
            try
            {
                frmCommonPopup.CRUD = "R";
                frmCommonPopup.USER_CODE = _pUSER_CODE;
                frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                // 0 서비스네임 1 공통코드경우 CODE_TYPE 으로구분자 올린다.
                frmCommonPopup.ARRAY = new object[2] { "Washer_Info", "" };
                frmCommonPopup.ARRAY_CODE = new object[2] { _luWASHER_CODE.Text.ToString(), "" };
                frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분

                xfrmCommonPopup.ShowDialog();

                if (xfrmCommonPopup.dtReturn == null)
                {
                    xfrmCommonPopup.Dispose();
                    return;
                }

                if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                {
                    _luWASHER_CODE.Text = xfrmCommonPopup.dtReturn.Rows[0]["CD"].ToString();     // 와셔번호
                }

                xfrmCommonPopup.Dispose();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion
        
        #endregion

        #region ○ 수량 / 금액 계산

        private void _luINOUT_QTY__OnTextChanged(object sender, EventArgs e)
        {
            try
            {
                //decimal pCOST = 0;
                //decimal pQTY = 0;
                //decimal pUNITCOST = 0;

                //pUNITCOST = Convert.ToDecimal(_luUNITCOST.Text == "" ? "0.00" : _luUNITCOST.Text);
                //pQTY = Convert.ToDecimal(_luINOUT_QTY.Text == "" ? "0.00" : _luINOUT_QTY.Text);
                //pCOST = pUNITCOST * pQTY;

                //string[] qCOST = pCOST.ToString().Split('.');

                //if (qCOST.Length > 1 && qCOST[1].Length > 2)
                //    pCOST = Convert.ToDecimal(qCOST[0] + qCOST[1].Substring(0, 2));

                //_luCOST.Text = pCOST.ToString();

                decimal pCOST = 0;
                decimal pQTY = 0;
                decimal pUNITCOST = 0;

                pUNITCOST = Convert.ToDecimal(_luUNITCOST.Text == "" ? "0.00" : _luUNITCOST.Text);
                pQTY = Convert.ToDecimal(_luINOUT_QTY.Text == "" ? "0.00" : _luINOUT_QTY.Text);
                pCOST = pUNITCOST * pQTY;

                _luCOST.Text = pCOST.ToString();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        private void _luUNITCOST__OnTextChanged(object sender, EventArgs e)
        {
            try
            {
                //decimal pCOST = 0;
                //decimal pQTY = 0;
                //decimal pUNITCOST = 0;

                //pUNITCOST = Convert.ToDecimal(_luUNITCOST.Text == "" ? "0.00" : _luUNITCOST.Text);
                //pQTY = Convert.ToDecimal(_luINOUT_QTY.Text == "" ? "0.00" : _luINOUT_QTY.Text);
                //pCOST = pUNITCOST * pQTY;

                //_luCOST.Text = pCOST.ToString();

                decimal pCOST = 0;
                decimal pQTY = 0;
                decimal pUNITCOST = 0;

                pUNITCOST = Convert.ToDecimal(_luUNITCOST.Text == "" ? "0.00" : _luUNITCOST.Text);
                pQTY = Convert.ToDecimal(_luINOUT_QTY.Text == "" ? "0.00" : _luINOUT_QTY.Text);
                pCOST = pUNITCOST * pQTY;

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
                //if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b')
                //{
                //    CoFAS_DevExpressManager.ShowInformationMessage("숫자를 입력하시기 바랍니다.");
                //    e.Handled = false;
                //    return;
                //}
                //else
                //{
                //    e.Handled = true;
                //}
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("숫자를 입력하시기 바랍니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_INPUT_NUMERIC);
                    e.Handled = true;
                }

                // only allow one decimal point
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        private void _luCOST__OnMouseHover(object sender, EventArgs e)
        {
            CoFAS_DevExpressManager.SetCursor(this, Cursors.Arrow);
        }
    }
}
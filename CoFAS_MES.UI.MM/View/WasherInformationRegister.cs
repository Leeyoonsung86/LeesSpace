﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CoFAS_MES.CORE.BaseForm;
using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.Function;
using CoFAS_MES.CORE;

using CoFAS_MES.UI.MM.Business;
using CoFAS_MES.UI.MM.Data;
using CoFAS_MES.UI.MM.Entity;
using DevExpress.XtraGrid.Views.Grid;
using CoFAS_MES.CORE.UserForm;
using System.Net;
//using DevExpress.DashboardCommon;
//using DevExpress.DataAccess.ConnectionParameters;
//
namespace CoFAS_MES.UI.MM
{
    public partial class WasherInformationRegister : frmBaseNone
    {
        private string _pCORP_CODE = string.Empty;       // 회사코드       
        private string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        private string _pUSER_NAME = string.Empty;       // 사용자이름
        private string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어
        private string _pWINDOW_NAME = string.Empty;     // 화면 명칭
        private string _pFONT_TYPE = string.Empty;       // 시스템 폰트 타입 설정
        private int _pFONT_SIZE = 9;                     // 시스템 폰트 사이즈 설정 기본 9
        private Font _pFONT_SETTING = null;              // 시스템 폰트 설정
        private string _pFTP_ID = string.Empty;          // FTP ID 정보
        private string _pFTP_PATH = string.Empty;     // FTP SERVER IP 정보
        private string _pFTP_PW = string.Empty;          //FTP PW 정보
        private string _pLocation_Code = string.Empty;  // 저장/수정 후 로케이션 위치 저장
        private bool _pLocation_YN = true;              // 저장위치 사용여부
        public string _pMENU_NAME = string.Empty;       // 메뉴명칭
        private string _pUSER_GRANT = string.Empty; // 사용자 권한
        private bool _pImageDelete_YN = false;          //이미지가 휴지통으로 FTP에 삭제를 시키면 DB도 업뎃
        private string _pBefore_ImageName = string.Empty; // 이미지를 휴지통으로 삭제할 시 이전에 등록된게 있으면 ofd만 지우고, 데이터가 있었으면 FTP와 DB에서 삭제

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

        private WasherInformationRegisterEntity _pWasherInformationRegisterEntity = null; // 엔티티 생성

        private DataTable _dtList = null; //조회 데이터 리스트

        private bool _pFirstYN = true;

        // 코에버 frp 관련 변수
        private string _pFileName = "";                                 //local 파일이름   //ofd로 받아서 넣기 safe~
        private string _pFullName = "";                                 //localfile 파일명 포함 전체 경로        
        private string _pFTP_DOWNLOAD_PATH = ""; // ftp download에 사용

        OpenFileDialog ofd;

        public WasherInformationRegister()
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
                _luT_WASHER._OnButtonPressed -= _luT_WASHER_OnButtonPressed;
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
                //dxWaitViewManager.ShowWaitForm();
                InitializeSetting();

                //버튼이벤트 생성
                SearchButtonClicked += new EventHandler(Form_SearchButtonClicked);
                SaveButtonClicked += new EventHandler(Form_SaveButtonClicked);
                DeleteButtonClicked += new EventHandler(Form_DeleteButtonClicked);
                InitialButtonClicked += new EventHandler(Form_InitialButtonClicked);
                SettingButtonClicked += new EventHandler(Form_SettingButtonClicked);

                FormCloseButtonClicked += new EventHandler(Form_FormCloseButtonClicked);

                Form_SearchButtonClicked(null, null);
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {
                DevExpress.Utils.AppearanceObject.DefaultFont = _pFONT_SETTING;//화면에 모든 항목 폰트 재설정
                //dxWaitViewManager.CloseWaitForm();
            }
        }
         
        //private void Viewer_ConfigureDataConnection(object sender, DashboardConfigureDataConnectionEventArgs e)
        //{
        //    if (e.ConnectionName == "m.coever.co.kr_coever_mes_Connection")
        //    {
        //        e.ConnectionParameters = new MySqlConnectionParameters();
        //        SqlDashboardHelper.SetupSqlParameters((MySqlConnectionParameters)e.ConnectionParameters);
        //    }

        //}
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
                _pnLeft.Width = 800;

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
                _pWasherInformationRegisterEntity = new WasherInformationRegisterEntity();
                _pWasherInformationRegisterEntity.CORP_CODE = _pCORP_CODE;
                _pWasherInformationRegisterEntity.USER_CODE = _pUSER_CODE;
                _pWasherInformationRegisterEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;

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
                _pWasherInformationRegisterEntity.CRUD = "";
                if (_pFirstYN)
                {
                    MainFind_DisplayData(); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.
                    
                    _pFirstYN = false;
                }

                //컨트롤러 별 추가 이벤트 생성은 화면 설정 마지막에 진행
                _gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick;
        
                _luT_WASHER._OnButtonPressed += _luT_WASHER_OnButtonPressed;

                //그리드 버튼추가 시 클릭 이벤트 처리 
                // CoFAS_DevExpressManager._OnButtonPressed += CoFAS_DevExpressManager__OnButtonPressed;

                
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
                pButtonSetting.UseYNSaveButton = _pMenuSettingEntity.MENU_SAVE == "Y" ? true : false; // 저장
                pButtonSetting.UseYNDeleteButton = false; //_pMenuSettingEntity.MENU_DELETE == "Y" ? true : false; // 삭제  //코드성은 실제 삭제 없음.

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
                _luT_USE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "common_code", "CD99", "", "").Tables[0], 0, 0, "");
                _luT_USE_YN.ItemIndex = 0;
                _luT_USE_YN.ReadOnly = false;

                _luT_WASHER.CodeText = "";
                _luT_WASHER.NameText = "";
                
                _luWASHER_CODE.Text = "";
                _luWASHER_CODE.ReadOnly = true;
                _luWASHER_NAME.Text = "";

                _luWASHER_UNIT.Text = "";
                _luWASHER_UNIT.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "common_code", "CD04", "", "").Tables[0], 0, 0, "");
                _luWASHER_UNIT.ReadOnly = true;

                _luWASHER_STANDARD.Text = "";

                _luT_VEND_PART_CODE.Text = "";
                
                _luWASHER_COST.Text = "";
                _luWASHER_COST.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;

                _luSAFE_STOCK.Text = "";
                _luSAFE_STOCK.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;

                _luUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "USE_YN", "", "", "").Tables[0], 0, 0, "");
                _luUSE_YN.ItemIndex = 0;
                _luUSE_YN.ReadOnly = false;

                // 컨트롤러 유효성 검증 처리 기본 컨트롤러 에서만 사용 
                dxValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
                dxValidationProvider.Validate();

                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                //if (_pFirstYN)
                //{
                //    _gdMAIN.DataSource = null;
                //}

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

        private void InitializeControl2()
        {
            try
            {
                _luWASHER_CODE.Text = "";
                _luWASHER_CODE.ReadOnly = true;
                _luWASHER_NAME.Text = "";

                _luWASHER_UNIT.Text = "";
                _luWASHER_UNIT.ReadOnly = true;

                _luWASHER_STANDARD.Text = "";

                _luT_VEND_PART_CODE.Text = "";

                _luWASHER_COST.Text = "";
                _luWASHER_COST.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;

                _luSAFE_STOCK.Text = "";
                _luSAFE_STOCK.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;

                _luUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "USE_YN", "", "", "").Tables[0], 0, 0, "");
                _luUSE_YN.ItemIndex = 0;
                _luUSE_YN.ReadOnly = false;

                // 컨트롤러 유효성 검증 처리 기본 컨트롤러 에서만 사용 
                dxValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
                dxValidationProvider.Validate();
               
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

        #region ○ 메인 그리드 로우 선택 이벤트 생성 - _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        private void _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;

                CoFAS_ControlManager.Controls_Binding(gv, false, this);

                //string strPART_CODE = gv.GetFocusedRowCellValue("PART_CODE").ToString();
                //string strPART_REVISION_NO = gv.GetFocusedRowCellValue("PART_REVISION_NO").ToString();
                //string strPART_TYPE = gv.GetFocusedRowCellValue("PART_TYPE").ToString();
                //string strPART_NAME = gv.GetFocusedRowCellValue("PART_NAME").ToString();
                _pWasherInformationRegisterEntity.CRUD = "R";
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion

        // 추가 이벤트 생성
        #region ○ 조회 서치박스 - _luTAG_NAME_OnButtonPressed(object sender, EventArgs e)
        private void _luT_WASHER_OnButtonPressed(object sender, EventArgs e)
        {
            try
            {
                frmCommonPopup.CRUD = "R";
                frmCommonPopup.USER_CODE = _pUSER_CODE;
                frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                // 0 서비스네임 1 공통코드경우 CODE_TYPE 으로구분자 올린다.
                frmCommonPopup.ARRAY = new object[2] { "Washer_Info", "" };
                frmCommonPopup.ARRAY_CODE = new object[2] { _luT_WASHER.Text.ToString(), "" };
                frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분

                xfrmCommonPopup.ShowDialog();

                if (xfrmCommonPopup.dtReturn == null)
                {
                    xfrmCommonPopup.Dispose();
                    return;
                }

                if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                {
                    _luT_WASHER.Text = xfrmCommonPopup.dtReturn.Rows[0]["CD"].ToString();     // 발주번호
                }

                xfrmCommonPopup.Dispose();
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
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _pWasherInformationRegisterEntity.CRUD = "R";
                _pWasherInformationRegisterEntity.WASHER_CODE = _luT_WASHER.CodeText;
                _pWasherInformationRegisterEntity.WASHER_NAME = _luT_WASHER.NameText;
                _pWasherInformationRegisterEntity.VEND_PART_CODE = _luT_VEND_PART_CODE.Text;
                _pWasherInformationRegisterEntity.USE_YN = _luT_USE_YN.GetValue();

                MainFind_DisplayData();

                InitializeControl2();
                //DisplayMessage("조회 되었습니다.");
                DisplayMessage(_pMSG_SEARCH);
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
                 if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_SAVE_QUESTION) == DialogResult.No)
                {
                    return;
                }

                    CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                if (!dxValidationProvider.Validate())
                {
                    return;
                }

                //확인
                if (_luWASHER_CODE.Text.ToString() != "")
                {
                    _pWasherInformationRegisterEntity.CRUD = "U";
                }
                else
                {
                    _pWasherInformationRegisterEntity.CRUD = "C";
                }

                if(_luWASHER_NAME.Text.Trim().Length < 2)
                {
                    //CoFAS_DevExpressManager.ShowErrorMessage("자재명을 입력해주세요.");
                    CoFAS_DevExpressManager.ShowErrorMessage(_pMSG_INPUT_DATA);
                    return;
                }

                _pWasherInformationRegisterEntity.WASHER_CODE = _luWASHER_CODE.Text;
                _pWasherInformationRegisterEntity.WASHER_NAME = _luWASHER_NAME.Text;
                _pWasherInformationRegisterEntity.WASHER_STANDARD = _luWASHER_STANDARD.Text;
                _pWasherInformationRegisterEntity.WASHER_UNIT = _luWASHER_UNIT.GetValue();
                _pWasherInformationRegisterEntity.VEND_PART_CODE = _luVEND_PART_CODE.Text;
                _pWasherInformationRegisterEntity.WASHER_COST = _luWASHER_COST.Text;
                _pWasherInformationRegisterEntity.SAFE_STOCK = _luSAFE_STOCK.Text;
                _pWasherInformationRegisterEntity.USE_YN = _luUSE_YN.GetValue();
                _pWasherInformationRegisterEntity.REMARK = _luREMARK.Text;

                InputData_Save(_pWasherInformationRegisterEntity);
                
                //_gdMAIN_VIEW.GetRowCellValue
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            //catch (Exception pException)
            //{
            //    DisplayMessage(string.Format("{0}", pException));
            //}
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
                //확인
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
                
                GridView gv = _gdMAIN_VIEW; //바인딩 되는 데이터 마스터 그리드 설정
                CoFAS_ControlManager.Controls_Binding(gv, true, this);
                InitializeSetting();
                
                _luUSE_YN.ItemIndex = 0;
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
                new SystemLogInfoBusiness().SystemEventLog_Info_Save("C", _pUSER_CODE, _pMENU_NAME, _pWINDOW_NAME, "Menu Close Event", "Form_FormCloseButton", "Button event is executed");
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
                _dtList = new WasherInformationRegisterBusiness().WasherInformationRegister_Info(_pWasherInformationRegisterEntity);

                if (_pWasherInformationRegisterEntity.CRUD == "") _dtList.Rows.Clear();


                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pWasherInformationRegisterEntity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩

                    if (_pLocation_Code != "" && _pLocation_YN)
                    {
                        int rowHandle = _gdMAIN_VIEW.LocateByValue("WASHER_CODE", _pLocation_Code);
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
                    InitializeControl2();
                
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

        private void InputData_Save(WasherInformationRegisterEntity _pWasherInformationRegisterEntity)

        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                bool isError = false;
                
                isError = new WasherInformationRegisterBusiness().WasherInformationRegister_Info_Save(_pWasherInformationRegisterEntity);
                // 자재입고
                if (isError)
                {
                    //오류 발생.
                    //CoFAS_DevExpressManager.ShowInformationMessage("저장 오류 발생! 데이터를 확인 하세요.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                }
                else
                {

                    _pLocation_Code = _pWasherInformationRegisterEntity.RTN_KEY;  //저장 위치

                    //InitializeControl();

                    // 화면 갱신
                    _pWasherInformationRegisterEntity.CRUD = "R";
                    //_pWasherInformationRegisterEntity.DATE_FROM = DateTime.Parse(_luTCCP_DATE.FromDateTime.ToString()).ToString("yyyyMMdd");// Convert.ToString(_luTINOUT_DATE.FromDateTime).Replace("-", "").Substring(0, 8);
                    //_pWasherInformationRegisterEntity.DATE_TO = DateTime.Parse(_luTCCP_DATE.ToDateTime.ToString()).ToString("yyyyMMdd");// Convert.ToString(_luTINOUT_DATE.ToDateTime).Replace("-", "").Substring(0, 8);      
                    //_pWasherInformationRegisterEntity.PART_NAME = _luTPART.NameText;
                    //_pWasherInformationRegisterEntity.PART_CODE = _luTPART.CodeText;
                    //_pWasherInformationRegisterEntity.USE_YN = _luTUSE_YN.GetValue();  // _luUSE_YN.GetValue();    
                    Form_SearchButtonClicked(null, null);
                    //MainFind_DisplayData();

                    //정상 처리
                    //CoFAS_DevExpressManager.ShowInformationMessage("저장 처리 되었습니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);

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
    }
}

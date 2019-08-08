﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

using CoFAS_MES.CORE.BaseForm;
using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.Function;

using CoFAS_MES.CORE.UserForm;

using CoFAS_MES.UI.QC.Business;
using CoFAS_MES.UI.QC.Entity;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;



namespace CoFAS_MES.UI.QC
{
    public partial class BarcodeLabelPrint : frmBaseNone
    {
        public string _pCORP_CODE = string.Empty;       // 회사코드       
        public string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        public string _pUSER_NAME = string.Empty;       // 사용자이름
        public string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어
        public string _pWINDOW_NAME = string.Empty;     // 화면 명칭
        public string _pFONT_TYPE = string.Empty;       // 시스템 폰트 타입 설정
        public int _pFONT_SIZE = 9;                     // 시스템 폰트 사이즈 설정 기본 9
        private Font _pFONT_SETTING = null;             // 시스템 폰트 설정
        private string _pFTP_ID = string.Empty;          // FTP ID 정보
        private string _pFTP_IP_PORT = string.Empty;        // FTP SERVER IP 정보
        private string _pFTP_PATH = string.Empty;     // FTP SERVER IP 정보
        private string _pFTP_PW = string.Empty;          //FTP PW 정보
        private string _pLocation_Code = string.Empty;  // 저장/수정 후 로케이션 위치 저장
        private bool _pLocation_YN = true;              // 저장위치 사용여부
        public string _pMENU_NAME = string.Empty;       // 메뉴명칭
        private int _gdMAIN_index = -1;

        private CoFAS_Serial _pCoFAS_Serial = null;  // 시리얼 생성
        private string[] serial_port = SerialPort.GetPortNames();

        private string strVEND_CODE = null;
        private string serial_check = string.Empty;

        private BarcodeLabelPrintEntity _pBarcodeLabelPrintEntity = null; // 엔티티 생성

        private DataTable _dtList_print = null; //조회 데이터 리스트 (바코드 발행)
        private DataTable _dtList = null; //조회 데이터 리스트
        private DataTable _dtList_terminal = null; //조회 데이터 리스트 (터미널 상세 정보)
        private DataTable _dtList_vend = null; //조회 데이터 리스트 (터미널 상세 정보)

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

        private string COM_PORT = string.Empty;
        //알림창메시지 복사 끝

        private string _pUSER_GRANT = string.Empty;

        public BarcodeLabelPrint()
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
                //if (CoFAS_DevExpressManager.ShowQuestionMessage("종료 하겠습니까?") == DialogResult.No)
                if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_EXIT_QUESTION) == DialogResult.No)
                {
                    pFormClosingEventArgs.Cancel = true;

                    

                    return;
                }
               
                if(_pCoFAS_Serial.IsOpen)
                {
                    //_pCoFAS_Serial.Dispose();
                    _pCoFAS_Serial.Close();
                }
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

                //이벤트 해제
                _gdMAIN_VIEW.RowCellClick -= _gdMAIN_VIEW_RowCellClick;

                //_luTPROCESS._OnOpenClick -= _luT_INSPECT_OnOpenClick;

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
                AddItemButtonClicked += new EventHandler(Form_AddItemButtonClicked);
                DeleteButtonClicked += new EventHandler(Form_DeleteButtonClicked);
                PrintButtonClicked += new EventHandler(Form_PrintButtonClicked);
                ExportButtonClicked += new EventHandler(Form_ExportButtonClicked);
                ImportButtonClicked += new EventHandler(Form_ImportButtonClicked);
                InitialButtonClicked += new EventHandler(Form_InitialButtonClicked);
                SettingButtonClicked += new EventHandler(Form_SettingButtonClicked);

                FormCloseButtonClicked += new EventHandler(Form_FormCloseButtonClicked);

                CoFAS_ControlManager.SetFontInControls(this.Controls, _pFONT_SETTING);

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
                //_pnLeft.Width = 810;


                //버튼 폰트색상 및 배경색상
                _ucbtCONNECTION.BackColor = Color.White;
                _ucbtPRINT.BackColor = Color.White;

                //메인 화면 전역 변수 처리
                _pCORP_CODE = MainForm.UserEntity.CORP_CODE;
                _pUSER_CODE = MainForm.UserEntity.USER_CODE;
                _pUSER_NAME = MainForm.UserEntity.USER_NAME;
                _pLANGUAGE_TYPE = MainForm.UserEntity.LANGUAGE_TYPE;
                _pFONT_TYPE = MainForm.UserEntity.FONT_TYPE;
                _pFONT_SIZE = MainForm.UserEntity.FONT_SIZE;
                _pFONT_SETTING = new Font(_pFONT_TYPE, _pFONT_SIZE);
                _pFTP_ID = MainForm.UserEntity.FTP_ID;
                _pFTP_IP_PORT = MainForm.UserEntity.FTP_IP_PORT;  //string.Format(@"{0}/{1}/", MainForm.UserEntity.FTP_IP_PORT, "test"); //화면 별 해당 위치 지정
                _pFTP_PW = MainForm.UserEntity.FTP_PW;

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
                _pBarcodeLabelPrintEntity = new BarcodeLabelPrintEntity();
                //_pBarcodeLabelPrintEntity.CORP_CODE = _pCORP_CODE;
                _pBarcodeLabelPrintEntity.USER_CODE = _pUSER_CODE;
                _pBarcodeLabelPrintEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                _pBarcodeLabelPrintEntity.TERMINAL_CODE = "TD010001";

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
                //메인 그리드
                _gdMAIN.DataSource = null;

                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                _pBarcodeLabelPrintEntity.CRUD = "";
                _luPRINT_SEQ.Text = "1";
                //MainFind_DisplayData(); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.

                if (_pFirstYN)
                {
                    _lciPRINT_SEQ.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    //컨트롤러 별 추가 이벤트 생성은 화면 설정 마지막에 진행
                    _gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick;
                    _luTPART_CODE._OnOpenClick += _luTPART_TYPE_OnOpenClick;
                   // _luPART_TYPE._OnOpenClick += _luPART_TYPE_OnOpenClick;
                    //_ucbtPRINT.Click += btnPRINT_Click;
                    _ucbtCONNECTION.Click += btnCONNECTION_Click;

                    //조회조건 영역 
                    _pFirstYN = false;

                    // 사용 가능한 COM 조회
                    for (int i = 0; i < serial_port.Length; i++)
                    {
                        _luCOM_TYPE.ItemAdd(serial_port[i]);
                    }
                    GetBarcodeComPort();
                    _luCOM_TYPE.SelectedItem = COM_PORT;
                   // _luCOM_TYPE.SelectedIndex = 0;
                    _COM_STATUS.Text = "";
                    _luEND_DATE.Text = "";
                    _luSTORE_TEMP.Text = "실온";
                    _luSTORE_TEMP.Properties.MaxLength = 20;
                    SetHardware();
                   // MainFind_DisplayData();
                }



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
                //데이터 영역
                _luTINSPECT_DATE.FromDateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);  //조회 시작일, 매월 초 날짜로 설정
                _luTINSPECT_DATE.ToDateTime = DateTime.Today;  //조회 종료일, 당일 설정
                _luTPART_CODE.CodeText = "";
                _luTPART_CODE.NameText = "";
                _luTUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "USE_YN", "", "", "").Tables[0], 0, 0, "");

                _luTPART_CODE.CodeText = "";
                _luTPART_CODE.NameText = "";
                _luTPART_CODE.CodeReadOnly = true;
                _luTPART_CODE.NameReadOnly = true;

                _luTPART_TYPE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "INSPECT_PART_TYPE", "", "", "").Tables[0], 0, 0, "");
                _luSTORE_TEMP.Text = "실온";
                _luEND_DATE.Text = "";
                _luEND_DATE.Properties.MaxLength = 20;
                _luPRINT_SEQ.Text = "";
               // _luPART_QTY.Text = "";
               // _luUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "USE_YN", "", "", "").Tables[0], 0, 0, "");

                //_luPRINT_CODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "LABEL", "", "", "").Tables[0], 0, 0, "");

                // 컨트롤러 유효성 검증 처리 기본 컨트롤러 에서만 사용 
                dxValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
                dxValidationProvider.Validate();

                _ucbtPRINT.Enabled = true;

                //_luCOM_TYPE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "TERMINAL_DETAIL_SEARCH", "", "", "").Tables[0], 0, 0, "");

                _luCOM_TYPE.DisableTextEditor();
                //dxValidationProvider.SetValidationRule(_luGRID_NAME, NotEmptyValidationRule);
                //dxValidationProvider.SetValidationRule(_luGRIDVIEW_NAME, NotEmptyValidationRule);
                // 컨트롤러 유효성 검증 처리


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

        #region ○ H/W 세팅시
        private void SetHardware()
        {
            try
            {

                if (serial_check == "")
                {
                    //_pCoFAS_Serial = new CoFAS_Serial(_dtList_terminal.Rows[0]["INFO_PORTNAME"].ToString(), Convert.ToInt32(_dtList_terminal.Rows[0]["INFO_BAUDRATE"].ToString()), _dtList_terminal.Rows[0]["INFO_PARITY"].ToString(), Convert.ToInt32(_dtList_terminal.Rows[0]["INFO_DATABITS"].ToString()), _dtList_terminal.Rows[0]["INFO_STOPBITS"].ToString());
                    _pCoFAS_Serial = new CoFAS_Serial(_luCOM_TYPE.SelectedItem.ToString(), 9600, "NONE", 8, "ONE");
                    _pCoFAS_Serial.Open();

                    // 연결할 H/W 연결상태 표시. (연동시 변경)
                    //lc_0.Appearance.Image = global::CoFAS_MES.UI.QC.Properties.Resources.plug_Green;
                    _ucbtCONNECTION.Image = global::CoFAS_MES.UI.QC.Properties.Resources.plug_Green;
                    
                    //serial_check = _dtList_terminal.Rows[0]["INFO_PORTNAME"].ToString();
                    serial_check = _luCOM_TYPE.SelectedItem.ToString();

                    // CoFAS_DevExpressManager.ShowInformationMessage("연결 되었습니다.");
                    _COM_STATUS.Text = "연결 되었습니다.";
                    _COM_STATUS.ForeColor = Color.Green;
                }
                else //값이 있으면
                {
                    //컴포트값이 다르면
                    //if (serial_check != _dtList_terminal.Rows[0]["INFO_PORTNAME"].ToString())
                    if (serial_check != _luCOM_TYPE.SelectedItem.ToString())
                    {
                        //연결 끊고 새로운거로 연결

                        _pCoFAS_Serial.Dispose();
                        _pCoFAS_Serial.Close();

                        //_pCoFAS_Serial = new CoFAS_Serial(_dtList_terminal.Rows[0]["INFO_PORTNAME"].ToString(), Convert.ToInt32(_dtList_terminal.Rows[0]["INFO_BAUDRATE"].ToString()), _dtList_terminal.Rows[0]["INFO_PARITY"].ToString(), Convert.ToInt32(_dtList_terminal.Rows[0]["INFO_DATABITS"].ToString()), _dtList_terminal.Rows[0]["INFO_STOPBITS"].ToString());
                        _pCoFAS_Serial = new CoFAS_Serial(_luCOM_TYPE.SelectedItem.ToString(), 9600, "NONE", 8, "ONE");

                        _pCoFAS_Serial.Dispose();

                        //_pCoFAS_Serial = new CoFAS_Serial("com3", 9600, "NONE", 8, "ONE");
                        _pCoFAS_Serial.Open();

                        // 연결할 H/W 연결상태 표시. (연동시 변경)
                        //lc_0.Appearance.Image = global::CoFAS_MES.UI.QC.Properties.Resources.plug_Green;
                        _ucbtCONNECTION.Image = global::CoFAS_MES.UI.QC.Properties.Resources.plug_Green;

                        serial_check = _luCOM_TYPE.SelectedItem.ToString();

                        //CoFAS_DevExpressManager.ShowInformationMessage("연결 되었습니다.");
                        _COM_STATUS.Text = "연결 되었습니다.";
                        _COM_STATUS.ForeColor = Color.Green;
                    }
                    else
                    {
                        //연결되어있는 상태니 재연결 할 필요 없음
                        //CoFAS_DevExpressManager.ShowInformationMessage("이미 연결된 포트입니다.");
                        _COM_STATUS.Text = "이미 연결된 포트입니다.";
                        _COM_STATUS.ForeColor = Color.Blue;
                    }
                }

            }
            catch (Exception ex)
            {
                CoFAS_DevExpressManager.ShowInformationMessage("포트 연결을 실패했습니다.");
                _pCoFAS_Serial = new CoFAS_Serial();
                _COM_STATUS.Text = "포트 연결 실패.";
                _COM_STATUS.ForeColor = Color.Red;
                _ucbtCONNECTION.Image = global::CoFAS_MES.UI.QC.Properties.Resources.plug_Gray;
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
                CoFAS_ControlManager.Controls_Binding(gv, false, this); //그리드 정보 디테일 표기

                int qRowIndex = gv.FocusedRowHandle;
                _gdMAIN_index = qRowIndex;
                //strVEND_CODE = gv.GetFocusedRowCellValue("VEND_PART_CODE").ToString();

                //_luPRINT.Enabled = true;
                _pBarcodeLabelPrintEntity.CRUD              = "U";

                _pBarcodeLabelPrintEntity.PART_CODE         = gv.GetFocusedRowCellValue("PART_CODE").ToString();
                _pBarcodeLabelPrintEntity.PART_NAME         = gv.GetFocusedRowCellValue("PART_NAME").ToString();

                _pBarcodeLabelPrintEntity.INSPECT_DATE      = gv.GetFocusedRowCellValue("INSPECT_DATE").ToString();
                _pBarcodeLabelPrintEntity.INSPECT_ID        = gv.GetFocusedRowCellValue("INSPECT_ID").ToString();
                _pBarcodeLabelPrintEntity.VEND_CODE         = gv.GetFocusedRowCellValue("VEND_CODE").ToString();
                _pBarcodeLabelPrintEntity.STORE_TEMP        = gv.GetFocusedRowCellValue("STORE_TEMP").ToString();
                _pBarcodeLabelPrintEntity.SPECIFIC_GRAVITY  = gv.GetFocusedRowCellValue("SPECIFIC_GRAVITY").ToString();
                _pBarcodeLabelPrintEntity.SPECIFIC_GRAVITY_CODE = gv.GetFocusedRowCellValue("SPECIFIC_GRAVITY_CODE").ToString();
                _pBarcodeLabelPrintEntity.END_DATE          = gv.GetFocusedRowCellValue("END_DATE").ToString();
                _pBarcodeLabelPrintEntity.INSPECT_NO        = gv.GetFocusedRowCellValue("INSPECT_NO").ToString();
                _pBarcodeLabelPrintEntity.MAKE_NO           = gv.GetFocusedRowCellValue("MAKE_NO").ToString();
                _pBarcodeLabelPrintEntity.MAKE_VEND         = gv.GetFocusedRowCellValue("MAKE_VEND").ToString();
                _pBarcodeLabelPrintEntity.REMARK            = "";
                _pBarcodeLabelPrintEntity.INOUT_ID = gv.GetFocusedRowCellValue("INOUT_ID").ToString();
                _pBarcodeLabelPrintEntity.PART_TYPE = gv.GetFocusedRowCellValue("PART_TYPE").ToString();
                //  _pBarcodeLabelPrintEntity.PART_BARCODE      = gv.GetFocusedRowCellValue("BARCODE").ToString();
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

                _ucbtPRINT.Enabled = true;
                _pBarcodeLabelPrintEntity.CRUD = "R";

                MainFind_DisplayData();

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
                 CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                //if (CoFAS_DevExpressManager.ShowQuestionMessage("저장 하시겠습니까?") == DialogResult.No)
                if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_SAVE_QUESTION) == DialogResult.No)
                {
                    return;
                }
                if (!dxValidationProvider.Validate())
                {
                    return;
                }

              //  if (_luPRINT_SEQ.Text == "")
              //  {
              //      return;
              //  }
              //
              //  string cmd = Convert.ToInt32(_luPRINT_SEQ.Text).ToString("D3");

               // _dtList_vend = new BarcodeLabelPrintBusiness().BarcodeLabelPrint_Vend_Info(_luTPART_CODE.CodeText.ToString());

                //확인
                _pBarcodeLabelPrintEntity.CRUD = "U";

              //  _pBarcodeLabelPrintEntity.VEND_CODE = _dtList_vend.Rows[0]["VEND_PART_CODE"].ToString();
              //  _pBarcodeLabelPrintEntity.PRINT_DATE = DateTime.Now.ToString("yyyy-MM-dd");
              //  _pBarcodeLabelPrintEntity.PRINT_SEQ = _luPRINT_SEQ.Text;
              //  _pBarcodeLabelPrintEntity.PART_CODE = _luTPART_CODE.CodeText.ToString();
              // // _pBarcodeLabelPrintEntity.PART_QTY = _luPART_QTY.Text.ToString();
              //  //_pBarcodeLabelPrintEntity.USE_YN = _luUSE_YN.GetValue();
              // // _pBarcodeLabelPrintEntity.PRINT_CODE = _luPRINT_CODE.GetValue();

                InputData_Save();
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
                //확인
                //if (_gdSUB_VIEW.GetFocusedRowCellValue(_gdSUB_VIEW.Columns["CRUD"]).ToString() == "C")
                //{
                //    // 신규 데이터는 로우 삭제
                //    _gdSUB_VIEW.DeleteRow(_gdSUB_VIEW.FocusedRowHandle);
                //}
                //else
                //{
                //    // 수정 데이터는 "CRUD" 처리
                //    _gdSUB_VIEW.SetRowCellValue(_gdSUB_VIEW.FocusedRowHandle, _gdSUB_VIEW.Columns["CRUD"], "D");
                //}

                // 수정 후 포커스 이동 안되면 데이터 반영 안됨. 
                // 삭제 버튼 클릭시에는 GetFocusedDataRow().EndEdit() 처리 해야됨.
                // 마우스 팝업 메뉴에서 처리는 자동으로 처리됨.
                //_gdSUB_VIEW.GetFocusedDataRow().EndEdit();

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
                _pBarcodeLabelPrintEntity.PROCESS_CODE_MST = "";// _luTPART_TYPE.GetValue().ToString();

                _dtList_print = new BarcodeLabelPrintBusiness().BarcodeLabelPrint_Info(_pBarcodeLabelPrintEntity);
                if (_gdMAIN_index != -1)
                {
                    // 시리얼 연결 여부 확인
                    if (_pCoFAS_Serial.IsOpen)
                    {
                        try
                        {
                            //라벨 공정에서 가져오기
                            string _Barcode = string.Empty;

                            //byte[] bytes = Encoding.Default.GetBytes(_Barcode);
                            //_Barcode = Encoding.Default.GetString(bytes);

                            string cmd = null;
                            int check = 0;

                            DataTable tDataTable = _gdMAIN_VIEW.GridControl.DataSource as DataTable;
                            //CoFAS_ConvertManager.DataTable_FindCount(_gdMAIN_VIEW.GridControl.DataSource as DataTable, "CRUD ='Y'", "");
                            // for (int i = 0; i < tDataTable.Rows.Count; i++)
                            // {
                            _Barcode = _gdMAIN_VIEW.GetFocusedRowCellValue("BARCODE").ToString();// _dtList_print.Rows[0]["PRINT_CMD"].ToString();
                            string temp = string.Empty;
                            string yyyy = string.Empty;
                            string mm = string.Empty;
                            string dd = string.Empty;
                            string yyyymmdd = string.Empty;
                            // 푸른들식품 기준 10x5 라벨
                            _Barcode = _Barcode.Replace("@PART_NAME", _gdMAIN_VIEW.GetFocusedRowCellValue("PART_NAME").ToString()); // 제품명 
                            //_Barcode = _Barcode.Replace("@PART_CODE", tDataTable.Rows[0]["PART_CODE"].ToString()); //품목코드
                            _Barcode = _Barcode.Replace("@PART_CODE", _gdMAIN_VIEW.GetFocusedRowCellValue("VEND_PART_CODE").ToString()); //품목코드

                            temp = _gdMAIN_VIEW.GetFocusedRowCellValue("REQUEST_DATE").ToString().Replace("-","");
                            if (temp.Length > 7)
                            {
                                yyyy = temp.Substring(0, 4);
                                mm = temp.Substring(4, 2);
                                dd = temp.Substring(6, 2);
                                yyyymmdd = yyyy + '.' + mm + '.' + dd;
                            }
                            _Barcode = _Barcode.Replace("@INOUT_DATE", yyyymmdd); // 입고(제조)일자

                            _Barcode = _Barcode.Replace("@QTY", _gdMAIN_VIEW.GetFocusedRowCellValue("INSPECT_QTY").ToString()); // 수량

                            temp = _gdMAIN_VIEW.GetFocusedRowCellValue("SAMPLE_DATE").ToString().Replace("-", "");
                            yyyymmdd = "";
                            if (temp.Length > 7)
                            {
                                yyyy = temp.Substring(0, 4);
                                mm = temp.Substring(4, 2);
                                dd = temp.Substring(6, 2);
                                yyyymmdd = yyyy + '.' + mm + '.' + dd;
                            }
                            _Barcode = _Barcode.Replace("@SAMPLE_DATE", yyyymmdd); // 검체채취일

                            _Barcode = _Barcode.Replace("@MAKE_VEND", _gdMAIN_VIEW.GetFocusedRowCellValue("MAKE_VEND").ToString()); // 제조처
                            _Barcode = _Barcode.Replace("@BARCODE", _pBarcodeLabelPrintEntity.INOUT_ID); // 바코드

                            //2019.01.15
                            _Barcode = _Barcode.Replace("@MAKE_NO", _pBarcodeLabelPrintEntity.MAKE_NO); // 제조번호
                            _Barcode = _Barcode.Replace("@SPECIFIC_GRAVITY", _pBarcodeLabelPrintEntity.SPECIFIC_GRAVITY); // 비중
                            _Barcode = _Barcode.Replace("@INSPECT_NO", _pBarcodeLabelPrintEntity.INSPECT_NO); // 시험번호
                            _Barcode = _Barcode.Replace("@STORE_TEMP", _pBarcodeLabelPrintEntity.STORE_TEMP); // 보관온도
                             /*
                             _Barcode = _Barcode.Replace("@MAKE_NO", _luMAKE_NO.Text); // 제조번호
                             _Barcode = _Barcode.Replace("@SPECIFIC_GRAVITY", _luSPECIFIC_GRAVITY.Text); // 비중
                             _Barcode = _Barcode.Replace("@INSPECT_NO", _luINSPECT_NO.Text); // 시험번호
                             _Barcode = _Barcode.Replace("@STORE_TEMP", _luSTORE_TEMP.Text); // 보관온도
                             */

                            temp = _luEND_DATE.Text;
                            /*
                            temp = _luEND_DATE.Text.Replace("-", "");

                            yyyymmdd = "";
                            if (temp.Length > 7)
                            {

                                yyyy = temp.Substring(0, 4);
                                mm = temp.Substring(4, 2);
                                dd = temp.Substring(6, 2);
                                yyyymmdd = yyyy + '.' + mm + '.' + dd;
                            }
                            //_Barcode = _Barcode.Replace("@END_DATE", yyyymmdd); // 사용기한
                            */

                            _Barcode = _Barcode.Replace("@END_DATE", _pBarcodeLabelPrintEntity.END_DATE); // 사용기한
                            _Barcode = _Barcode.Replace("@REMARK", _pBarcodeLabelPrintEntity.REMARK); // 비고
                            //2019.01.15
                            /*
                            _Barcode = _Barcode.Replace("@END_DATE", temp); // 사용기한
                            _Barcode = _Barcode.Replace("@REMARK", _luREMARK.Text); // 비고
                            */
                            //동그라미
                            //제품
                            if (_pBarcodeLabelPrintEntity.PART_TYPE == "1001")
                            {

                                _Barcode = _Barcode + "FO502,602^GC105,5,B^FS^FS^";
                            }
                            //반제품
                            else if (_pBarcodeLabelPrintEntity.PART_TYPE == "1003")
                            {
                                _Barcode = _Barcode + "FO502,716^GC105,5,B^FS^FS^";
                            }
                            //원료
                            else if (_pBarcodeLabelPrintEntity.PART_TYPE == "1004")
                            {
                                _Barcode = _Barcode + "FO502,825^GC105,5,B^FS^FS^";
                            }

                            //자재
                            else if (_pBarcodeLabelPrintEntity.PART_TYPE == "1005")
                            {
                                _Barcode = _Barcode + "FO502,932 ^GC105,5,B^FS^FS^";
                            }
                            _Barcode = _Barcode + ",^PQ" + _luPRINT_SEQ.Text;
                            _Barcode = _Barcode + "^XZ";


                            // _Barcode = _Barcode.Replace("@PNAME", tDataTable.Rows[i]["PART_NAME"].ToString().Length < 8 ? "  " + tDataTable.Rows[i]["PART_NAME"].ToString() : tDataTable.Rows[i]["PART_NAME"].ToString()); // 제품명

                            byte[] bytes = Encoding.Default.GetBytes(_Barcode);
                            _pCoFAS_Serial.Write(bytes, 0, bytes.Length);
                            //   }

                            //CoFAS_DevExpressManager.ShowInformationMessage("발행이 완료 되었습니다.");
                            _pBarcodeLabelPrintEntity.CRUD = "U";

                            //2018.01.15
                            //인쇄는 인쇄만되게
                            //저장도 되게하면 인쇄만 하는사람도 데이터 수정이 가능함
                            InputData_Save();
                        }

                        catch (Exception ex)
                        {
                            CoFAS_DevExpressManager.ShowInformationMessage("라벨발행 오류");
                            _COM_STATUS.Text = "라벨발행 오류.";
                            _COM_STATUS.ForeColor = Color.Red;

                            _pCoFAS_Serial.Dispose();
                            _pCoFAS_Serial.Close();
                        }

                    }
                    else  //연결 끊긴 여부
                    {
                        _COM_STATUS.Text = "프린터를 연결하세요.";
                        _COM_STATUS.ForeColor = Color.Red;
                        CoFAS_DevExpressManager.ShowInformationMessage("프린터를 연결하세요");
                    }
                }
                else
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("발행할 항목을 선택하세요");
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

                InitializeControl();

                //_gdSUB.DataSource = null;
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                _pBarcodeLabelPrintEntity.CRUD = "";

                //MainFind_DisplayData(); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.

                _gdMAIN.DataSource = null;
                //DisplayMessage("초기화했습니다.");
                //DisplayMessage(_pMSG_RESET_COMPLETE);

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

        #region ○ 조회 서치박스
        private void _luTPART_TYPE_OnOpenClick(object sender, EventArgs e)
        {
            try
            {
                frmCommonPopup.CRUD = "R";
                frmCommonPopup.USER_CODE = _pUSER_CODE;
                frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                // 0 서비스네임 1 공통코드경우 CODE_TYPE 으로구분자 올린다.
                frmCommonPopup.ARRAY = new object[2] { "Product_Code_R1", "" };
                frmCommonPopup.ARRAY_CODE = new object[2] { _luTPART_CODE.CodeText.ToString(), _luTPART_CODE.NameText.ToString() };
                frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분

                xfrmCommonPopup.ShowDialog();

                if (xfrmCommonPopup.dtReturn == null)
                {
                    xfrmCommonPopup.Dispose();
                    return;
                }

                if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                {
                    _luTPART_CODE.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["CD"].ToString();
                    _luTPART_CODE.NameText = xfrmCommonPopup.dtReturn.Rows[0]["CD_NM"].ToString();
                }

                xfrmCommonPopup.Dispose();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        private void _luPART_TYPE_OnOpenClick(object sender, EventArgs e)
        {
            try
            {
                frmCommonPopup.CRUD = "R";
                frmCommonPopup.USER_CODE = _pUSER_CODE;
                frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                // 0 서비스네임 1 공통코드경우 CODE_TYPE 으로구분자 올린다.
                frmCommonPopup.ARRAY = new object[2] { "Product_Code_R1", "" };
                frmCommonPopup.ARRAY_CODE = new object[2] { _luTPART_CODE.CodeText.ToString(), _luTPART_CODE.NameText.ToString() };
                frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분

                xfrmCommonPopup.ShowDialog();

                if (xfrmCommonPopup.dtReturn == null)
                {
                    xfrmCommonPopup.Dispose();
                    return;
                }

                if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                {
                    _luTPART_CODE.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["CD"].ToString();
                    _luTPART_CODE.NameText = xfrmCommonPopup.dtReturn.Rows[0]["CD_NM"].ToString();
                }

                xfrmCommonPopup.Dispose();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        #region ○ 발행 버튼 클릭시

        private void btnPRINT_Click(object pSender, EventArgs pEventArgs)
        {
            _pBarcodeLabelPrintEntity.PROCESS_CODE_MST = "";// _luTPART_TYPE.GetValue().ToString();

            _dtList_print = new BarcodeLabelPrintBusiness().BarcodeLabelPrint_Info(_pBarcodeLabelPrintEntity);
            if (_gdMAIN_index != -1)
            {
                // 시리얼 연결 여부 확인
                if (_pCoFAS_Serial.IsOpen)
                {
                    try
                    {
                        //라벨 공정에서 가져오기
                        string _Barcode = string.Empty;

                        //byte[] bytes = Encoding.Default.GetBytes(_Barcode);
                        //_Barcode = Encoding.Default.GetString(bytes);

                        string cmd = null;
                        int check = 0;

                        DataTable tDataTable = _gdMAIN_VIEW.GridControl.DataSource as DataTable;
                        //CoFAS_ConvertManager.DataTable_FindCount(_gdMAIN_VIEW.GridControl.DataSource as DataTable, "CRUD ='Y'", "");
                        // for (int i = 0; i < tDataTable.Rows.Count; i++)
                        // {
                        _Barcode = _dtList_print.Rows[0]["PRINT_CMD"].ToString();
                        string temp = string.Empty;
                        string yyyy = string.Empty;
                        string mm = string.Empty;
                        string dd = string.Empty;
                        string yyyymmdd = string.Empty;
                        // 푸른들식품 기준 10x5 라벨
                        _Barcode = _Barcode.Replace("@PART_NAME", tDataTable.Rows[0]["PART_NAME"].ToString()); // 제품명
                        _Barcode = _Barcode.Replace("@PART_CODE", tDataTable.Rows[0]["PART_CODE"].ToString()); //품목코드

                        temp = tDataTable.Rows[0]["REQUEST_DATE"].ToString();
                        if (temp.Length > 7)
                        {
                            yyyy = temp.Substring(0, 4);
                            mm = temp.Substring(4, 2);
                            dd = temp.Substring(6, 2);
                            yyyymmdd = yyyy + '.' + mm + '.' + dd;
                        }
                        _Barcode = _Barcode.Replace("@INOUT_DATE", yyyymmdd); // 입고(제조)일자

                        _Barcode = _Barcode.Replace("@QTY", tDataTable.Rows[0]["INSPECT_QTY"].ToString()); // 수량

                        temp = tDataTable.Rows[0]["SAMPLE_DATE"].ToString();
                        yyyymmdd = "";
                        if (temp.Length > 7)
                        {
                            yyyy = temp.Substring(0, 4);
                            mm = temp.Substring(4, 2);
                            dd = temp.Substring(6, 2);
                            yyyymmdd = yyyy + '.' + mm + '.' + dd;
                        }
                        _Barcode = _Barcode.Replace("@SAMPLE_DATE", yyyymmdd); // 검체채취일

                        _Barcode = _Barcode.Replace("@MAKE_VEND", tDataTable.Rows[0]["MAKE_VEND"].ToString()); // 제조처
                        _Barcode = _Barcode.Replace("@BARCODE", _pBarcodeLabelPrintEntity.INOUT_ID); // 바코드

                        //2019.01.15
                        _Barcode = _Barcode.Replace("@MAKE_NO", _pBarcodeLabelPrintEntity.MAKE_NO); // 제조번호
                        _Barcode = _Barcode.Replace("@SPECIFIC_GRAVITY", _pBarcodeLabelPrintEntity.SPECIFIC_GRAVITY); // 비중
                        _Barcode = _Barcode.Replace("@INSPECT_NO", _pBarcodeLabelPrintEntity.INSPECT_NO); // 시험번호
                        _Barcode = _Barcode.Replace("@STORE_TEMP", _pBarcodeLabelPrintEntity.STORE_TEMP); // 보관온도
                        /*
                        _Barcode = _Barcode.Replace("@MAKE_NO", _luMAKE_NO.Text); // 제조번호
                        _Barcode = _Barcode.Replace("@SPECIFIC_GRAVITY", _luSPECIFIC_GRAVITY.Text); // 비중
                        _Barcode = _Barcode.Replace("@INSPECT_NO", _luINSPECT_NO.Text); // 시험번호
                        _Barcode = _Barcode.Replace("@STORE_TEMP", _luSTORE_TEMP.Text); // 보관온도
                        */

                        temp = _luEND_DATE.Text;
                        //문자도 들어가므로 그대로 출력
                        /*
                        yyyymmdd = "";
                        if (temp.Length > 7)
                        {

                            yyyy = temp.Substring(0, 4);
                            mm = temp.Substring(4, 2);
                            dd = temp.Substring(6, 2);
                            yyyymmdd = yyyy + '.' + mm + '.' + dd;
                        }
                        */
                        //_Barcode = _Barcode.Replace("@END_DATE", yyyymmdd); // 사용기한

                        _Barcode = _Barcode.Replace("@END_DATE", _pBarcodeLabelPrintEntity.END_DATE); // 사용기한
                        _Barcode = _Barcode.Replace("@REMARK", _pBarcodeLabelPrintEntity.REMARK); // 비고
                         //2019.01.15
                         /*
                         _Barcode = _Barcode.Replace("@END_DATE", temp); // 사용기한
                         _Barcode = _Barcode.Replace("@REMARK", _luREMARK.Text); // 비고
                         */

                        //동그라미
                        //제품
                        if (_pBarcodeLabelPrintEntity.PART_TYPE == "1001")
                        {

                            _Barcode = _Barcode + "FO502,602^GC105,5,B^FS^FS^";
                        }
                        //반제품
                        else if (_pBarcodeLabelPrintEntity.PART_TYPE == "1003")
                        {
                            _Barcode = _Barcode + "FO502,716^GC105,5,B^FS^FS^";
                        }
                        //원료
                        else if (_pBarcodeLabelPrintEntity.PART_TYPE == "1004")
                        {
                            _Barcode = _Barcode + "FO502,825^GC105,5,B^FS^FS^";
                        }

                        //자재
                        else if (_pBarcodeLabelPrintEntity.PART_TYPE == "1005")
                        {
                            _Barcode = _Barcode + "FO502,932 ^GC105,5,B^FS^FS^";
                        }
                        _Barcode = _Barcode + ",^PQ" + _luPRINT_SEQ.Text;
                        _Barcode = _Barcode + "^XZ";


                        // _Barcode = _Barcode.Replace("@PNAME", tDataTable.Rows[i]["PART_NAME"].ToString().Length < 8 ? "  " + tDataTable.Rows[i]["PART_NAME"].ToString() : tDataTable.Rows[i]["PART_NAME"].ToString()); // 제품명

                        byte[] bytes = Encoding.Default.GetBytes(_Barcode);
                        _pCoFAS_Serial.Write(bytes, 0, bytes.Length);
                        //   }

                        //CoFAS_DevExpressManager.ShowInformationMessage("발행이 완료 되었습니다.");
                        _pBarcodeLabelPrintEntity.CRUD = "U";
                        InputData_Save();
                    }

                    catch (Exception ex)
                    {
                        CoFAS_DevExpressManager.ShowInformationMessage("라벨발행 오류");
                        _COM_STATUS.Text = "라벨발행 오류.";
                        _COM_STATUS.ForeColor = Color.Red;

                        _pCoFAS_Serial.Dispose();
                        _pCoFAS_Serial.Close();
                    }

                }
                else  //연결 끊긴 여부
                {
                    _COM_STATUS.Text = "시리얼 확인.";
                    _COM_STATUS.ForeColor = Color.Red;
                    CoFAS_DevExpressManager.ShowInformationMessage("시리얼 확인");
                }
            }
        }
        #endregion

        #region ○ 연결 버튼 클릭시

        private void btnCONNECTION_Click(object pSender, EventArgs pEventArgs)
        {
            //if (_pCoFAS_Serial.IsOpen)
            //{
            //    lc_0.Appearance.Image = global::CoFAS_MES.UI.IM.Properties.Resources.plug_Gray;

            //    _pCoFAS_Serial.Close();

            //    return;
            //}

            SetHardware();
        }
        #endregion

        // DB 처리
        #region ○ 메인조회 - MainFind_DisplayData()

        private void MainFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                _pBarcodeLabelPrintEntity.CRUD = "R";
                _pBarcodeLabelPrintEntity.DATE_FROM = DateTime.Parse(_luTINSPECT_DATE.FromDateTime.ToString()).ToString("yyyyMMdd"); // Convert.ToString(_luTINOUT_DATE.FromDateTime).Replace("-", "").Substring(0, 8);
                _pBarcodeLabelPrintEntity.DATE_TO = DateTime.Parse(_luTINSPECT_DATE.ToDateTime.ToString()).ToString("yyyyMMdd"); // Convert.ToString(_luTINOUT_DATE.FromDateTime).Replace("-", "").Substring(0, 8);
                _pBarcodeLabelPrintEntity.PART_CODE = _luTPART_CODE.CodeText;
                _pBarcodeLabelPrintEntity.PART_NAME = _luTPART_CODE.NameText;
                _pBarcodeLabelPrintEntity.PART_TYPE = _luTPART_TYPE.GetValue();
                _pBarcodeLabelPrintEntity.USE_YN = _luTUSE_YN.GetValue();
                _pBarcodeLabelPrintEntity.APPROVAL_YN = "";
                // _pBarcodeLabelPrintEntity.PRINT_CODE = _luTPART_TYPE.GetValue();

                _gdMAIN_index = -1;

                _dtList = new BarcodeLabelPrintBusiness().BarcodeLabelPrint_Info_Mst(_pBarcodeLabelPrintEntity);

                if (_pBarcodeLabelPrintEntity.CRUD == "") _dtList.Rows.Clear();

                if (_dtList != null && _dtList.Rows.Count > 0)//&& _dtList.Rows.Count > 0) )|| (_dtList != null && _pBarcodeLabelPrintEntity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩

                    if (_pLocation_Code != "" && _pLocation_YN)
                    {
                        int rowHandle = _gdMAIN_VIEW.LocateByValue("PART_BARCODE", _pLocation_Code);
                        if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                            _gdMAIN_VIEW.FocusedRowHandle = rowHandle;


                        //조회 후 초기화 
                        _pLocation_Code = "";
                    }
                }
                else
                {
                    _gdMAIN.DataSource = null;
                    _pBarcodeLabelPrintEntity.DATE_FROM = "";
                    _pBarcodeLabelPrintEntity.DATE_TO = "";
                    _pBarcodeLabelPrintEntity.PART_CODE = "";
                    _pBarcodeLabelPrintEntity.PART_NAME = "";
                    _pBarcodeLabelPrintEntity.USE_YN = "";

                    _pBarcodeLabelPrintEntity.INOUT_ID = "";
                    _pBarcodeLabelPrintEntity.INSPECT_DATE = "";
                    _pBarcodeLabelPrintEntity.INSPECT_ID = "";
                    _pBarcodeLabelPrintEntity.VEND_CODE = "";
                    _pBarcodeLabelPrintEntity.STORE_TEMP = "";
                    _pBarcodeLabelPrintEntity.SPECIFIC_GRAVITY = "";
                    _pBarcodeLabelPrintEntity.END_DATE = "";
                    _pBarcodeLabelPrintEntity.INSPECT_NO = "";
                    _pBarcodeLabelPrintEntity.MAKE_NO = "";
                    _pBarcodeLabelPrintEntity.MAKE_VEND = "";
                    _pBarcodeLabelPrintEntity.REMARK = "";

                    _luINSPECT_QTY.Text = "";

                    _luSTORE_TEMP.Text = "";
                    _luSPECIFIC_GRAVITY.Text = "";
                    _luEND_DATE.Text = "";
                    _luINSPECT_NO.Text = "";
                    _luMAKE_NO.Text = "";
                    _luEND_DATE.Text = "";
                    _luREMARK.Text = "";
                    _luSAMPLE_DATE.Text = "";
                    _luREMARK.Text = "";
                    //_gdSUB.DataSource = null;
                    //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화


                    //MainFind_DisplayData(); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.

                    // InitializeControl();
                    //DisplayMessage("조회 내역이 없습니다.");
                    if(_pBarcodeLabelPrintEntity.CRUD != "")
                    { 
                        DisplayMessage(_pMSG_SEARCH_EMPT);
                        //CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
                        _pBarcodeLabelPrintEntity.CRUD = "";
                    }

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
        #region ○ 메인조회 - MainFind_DisplayData()

        private void GetBarcodeComPort()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _dtList = new BarcodeLabelPrintBusiness().BarcodeLabelPrint_COM_Info(_pBarcodeLabelPrintEntity);
                COM_PORT = "";
                if (_dtList != null && _dtList.Rows.Count > 0)//&& _dtList.Rows.Count > 0) )|| (_dtList != null && _pBarcodeLabelPrintEntity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩
                    
                        //조회 후 초기화 
                    COM_PORT = _dtList.Rows[0]["COM_PORT"].ToString();
                   
                }
                else
                {
                   
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

        #region ○ 저장 - InputData_Save()

        private void InputData_Save()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                bool isError = false;

                _pBarcodeLabelPrintEntity.USER_CODE = _pUSER_CODE;
                _pBarcodeLabelPrintEntity.USER_NAME = _pUSER_NAME;

                _pBarcodeLabelPrintEntity.STORE_TEMP = _luSTORE_TEMP.Text;
                _pBarcodeLabelPrintEntity.SPECIFIC_GRAVITY = _luSPECIFIC_GRAVITY.Text;

                _pBarcodeLabelPrintEntity.END_DATE = _luEND_DATE.Text;

                _pBarcodeLabelPrintEntity.INSPECT_NO = _luINSPECT_NO.Text;
                _pBarcodeLabelPrintEntity.MAKE_NO = _luMAKE_NO.Text;
                //_pBarcodeLabelPrintEntity.MAKE_VEND =
                _pBarcodeLabelPrintEntity.REMARK = _luREMARK.Text;
                

               isError = new BarcodeLabelPrintBusiness().BarcodeLabelPrint_Info_Save(_pBarcodeLabelPrintEntity);

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

                    MainFind_DisplayData();

                    // 화면 갱신
                    _pBarcodeLabelPrintEntity.PART_BARCODE = "";
                    _pBarcodeLabelPrintEntity.PRINT_DATE = "";
                    _pBarcodeLabelPrintEntity.PRINT_SEQ = "";
                    _pBarcodeLabelPrintEntity.PART_CODE = "";
                    _pBarcodeLabelPrintEntity.PART_QTY = "";

                    _pLocation_Code = _pBarcodeLabelPrintEntity.RTN_KEY;  //저장 위치 

                   

                   // InitializeControl();
                    _pBarcodeLabelPrintEntity.CRUD = "";
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

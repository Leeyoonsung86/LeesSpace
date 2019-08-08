using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


using CoFAS_MES.CORE.BaseForm;
using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.Function;

using CoFAS_MES.UI.EM.Business;
using CoFAS_MES.UI.EM.Entity;
using CoFAS_MES.CORE.UserForm;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CoFAS_MES.UI.EM
{
    public partial class EquipmentCodeMstRegister : frmBaseNone
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

        private string _pUSER_GRANT = string.Empty; // 사용자 권한

        private EquipmentCodeMstRegisterEntity _pEquipmentCodeMstRegisterEntity = null; // 엔티티 생성

        private DataTable _dtList = null; //조회 데이터 리스트

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

        //알림창메시지 복사 끝

        public EquipmentCodeMstRegister()
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

                //그리드 작업 정보 확인 하기
                if (_gdSUB_VIEW.GridControl != null && CoFAS_ConvertManager.DataTable_FindCount(_gdSUB_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", ""))
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
                    //if (CoFAS_DevExpressManager.ShowQuestionMessage("종료 하겠습니까?") == DialogResult.No)
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
            //    _gdMAIN_VIEW.RowCellClick -= _gdMAIN_VIEW_RowCellClick;

           //     _gdSUB_VIEW.InitNewRow -= _gdSUB_VIEW_InitNewRow;

                _luT_EQUIPMENT_MST_CODE._OnOpenClick -= _luT_EQUIPMENT_MST_CODE_OnOpenClick;

                CoFAS_DevExpressManager._OnOpenButton -= CoFAS_DevExpressManager_OnOpenButton;
                CoFAS_DevExpressManager._OnButtonPressed -= CoFAS_DevExpressManager_OnButtonPressed;

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

                Form_SearchButtonClicked(null, null);

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
                _pnLeft.Width = 300;

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
                _pEquipmentCodeMstRegisterEntity = new EquipmentCodeMstRegisterEntity();
                //_pProcessCodeMstRegisterEntity.CORP_CODE = _pCORP_CODE;
                _pEquipmentCodeMstRegisterEntity.USER_CODE = _pUSER_CODE;
                _pEquipmentCodeMstRegisterEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;

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

                //서브그리드 초기화
                _gdSUB.DataSource = null;

                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                _pEquipmentCodeMstRegisterEntity.CRUD = "";

                if (_pFirstYN)
                {
                    MainFind_DisplayData();

                    //컨트롤러 별 추가 이벤트 생성은 화면 설정 마지막에 진행
                    _gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick;
                    _gdSUB_VIEW.RowCellClick += _gdSUB_VIEW_RowCellClick;
                    //그리드 버튼추가 시 클릭 이벤트 처리 
                    //CoFAS_DevExpressManager._OnButtonPressed += CoFAS_DevExpressManager__OnButtonPressed;

                    _gdSUB_VIEW.InitNewRow += _gdSUB_VIEW_InitNewRow;
                    _luT_EQUIPMENT_MST_CODE._OnOpenClick += _luT_EQUIPMENT_MST_CODE_OnOpenClick;

                    _pFirstYN = false;
                }

                SubFind_DisplayData();


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
                    _gdMAIN.DataSource = null;
                    _gdSUB_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB, _gdSUB_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdSUB.Name.ToString()));
                    _gdSUB.DataSource = null;
                    CoFAS_DevExpressManager._OnOpenButton += CoFAS_DevExpressManager_OnOpenButton;
                    CoFAS_DevExpressManager._OnButtonPressed += CoFAS_DevExpressManager_OnButtonPressed;

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
                _luT_EQUIPMENT_MST_CODE.CodeText = "";
                _luT_EQUIPMENT_MST_CODE.NameText = "";

                _luT_EQUIPMENT_TYPE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "EQUIPMENT_TYPE", "", "", "").Tables[0], 0, 0, "",true);
                _luT_USE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "USE_YN", "", "", "").Tables[0], 0, 0, "",true);
                _luT_USE_YN.ItemIndex = 1;
                _luEQUIPMENT_MST_CODE.Text = "";
                _luEQUIPMENT_MST_NAME.Text = "";

                _luEQUIPMENT_TYPE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "EQUIPMENT_TYPE", "", "", "").Tables[0], 0, 0, "");
                _luUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "USE_YN", "", "", "").Tables[0], 0, 0, "");
             
                _luREMARK.Text = "";


                // 컨트롤러 유효성 검증 처리 기본 컨트롤러 에서만 사용 
                dxValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
                dxValidationProvider.Validate();

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

        // 추가 이벤트 생성
        #region ○ 메인 그리드 로우 선택 이벤트 생성 - _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        private void _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;

                _pEquipmentCodeMstRegisterEntity.CRUD = "R";
                _pEquipmentCodeMstRegisterEntity.EQUIPMENT_MST_CODE = gv.GetFocusedRowCellValue("EQUIPMENT_MST_CODE").ToString();

                MainBindingFind_DisplayData();

                SubFind_DisplayData();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion

        #region 서브그리드 선택 이벤트
        private void _gdSUB_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;

                if(gv.FocusedRowHandle <= 0)
                {
                    return;
                }

                _pEquipmentCodeMstRegisterEntity.CRUD = "R";
                _pEquipmentCodeMstRegisterEntity.EQUIPMENT_MST_CODE = gv.GetFocusedRowCellValue("EQUIPMENT_CODE").ToString();
                

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion

        #region ○ 서브 그리드 신규로우 생성시 이벤트 생성 - _gdSUB_VIEW_InitNewRow(object sender, InitNewRowEventArgs e)
        private void _gdSUB_VIEW_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns["USE_YN"], "Y");
        }
        #endregion

        //#region ○ 그리드 버튼추가 시 클릭 이벤트 생성 - CoFAS_DevExpressManager__OnButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        //private void CoFAS_DevExpressManager__OnButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        //{
        //    //_gdMAIN_VIEW.EditingValue = "";
        //    /*
        //    GridView view = sender as GridView;

        //    switch (e.Button.Caption.ToString())
        //    {
        //        case "PART_BUTTON": //해당 그리드에 필드명 // 2개 이상 그리드의 버튼 항목들은 버튼 타입에 필드 명칭이 모두 다르게 설정 되어야됨.
        //            frmCommonPopup.CORP_CDDE = _pCORP_CODE;
        //            frmCommonPopup.CRUD = "R";
        //            frmCommonPopup.USER_CODE = _pUSER_CODE;
        //            frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
        //            frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

        //            frmCommonPopup.ARRAY = new object[2] { "product_part_code", "" }; //넘기는 파라메터 에 따라 설정
        //            string strCODE = _gdSUB_VIEW.GetRowCellValue(_gdSUB_VIEW.FocusedRowHandle, _gdSUB_VIEW.Columns["PART_CODE"]) == null ? "" : _gdSUB_VIEW.GetRowCellValue(_gdSUB_VIEW.FocusedRowHandle, _gdSUB_VIEW.Columns["PART_CODE"]).ToString();
        //            string strNAME = _gdSUB_VIEW.GetRowCellValue(_gdSUB_VIEW.FocusedRowHandle, _gdSUB_VIEW.Columns["PART_NAME"]) == null ? "" : _gdSUB_VIEW.GetRowCellValue(_gdSUB_VIEW.FocusedRowHandle, _gdSUB_VIEW.Columns["PART_NAME"]).ToString();

        //            frmCommonPopup.ARRAY_CODE = new object[2] { strCODE, strNAME };

        //            frmCommonPopup xfrmcommonPopup = new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분

        //            xfrmcommonPopup.ShowDialog();

        //            if (xfrmcommonPopup.dtReturn == null)
        //            {
        //                xfrmcommonPopup.Dispose();
        //                return;
        //            }

        //            if (xfrmcommonPopup.dtReturn != null && xfrmcommonPopup.dtReturn.Rows.Count > 0)
        //            {
        //                _gdSUB_VIEW.SetRowCellValue(_gdSUB_VIEW.FocusedRowHandle, _gdSUB_VIEW.Columns["PART_CODE"], xfrmcommonPopup.dtReturn.Rows[0]["CD"].ToString());
        //                _gdSUB_VIEW.SetRowCellValue(_gdSUB_VIEW.FocusedRowHandle, _gdSUB_VIEW.Columns["PART_NAME"], xfrmcommonPopup.dtReturn.Rows[0]["CD_NM"].ToString());
        //            }

        //            xfrmcommonPopup.Dispose();
        //            break;
            
        //    }
        //    */
        //}
        //#endregion

        #region ○ 조회 서치박스 - _luT_EQUIPMENT_MST_CODE_OnOpenClick(object sender, EventArgs e)
        private void _luT_EQUIPMENT_MST_CODE_OnOpenClick(object sender, EventArgs e)
        {
            try
            {
                frmCommonPopup.CRUD = "R";
                frmCommonPopup.USER_CODE = _pUSER_CODE;
                frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                // 0 서비스네임 1 공통코드경우 CODE_TYPE 으로구분자 올린다.
                frmCommonPopup.ARRAY = new object[2] { "EQUIPMENT_MST_CODE", "" };
                frmCommonPopup.ARRAY_CODE = new object[2] {_luT_EQUIPMENT_MST_CODE.CodeText.ToString(), _luT_EQUIPMENT_MST_CODE.NameText.ToString() };
                frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("CommonCode_Equipment"); //유저컨트롤러 설정 부분

                xfrmCommonPopup.ShowDialog();

                if (xfrmCommonPopup.dtReturn == null)
                {
                    xfrmCommonPopup.Dispose();
                    return;
                }

                if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                {
                    _luT_EQUIPMENT_MST_CODE.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["CD"].ToString();
                    _luT_EQUIPMENT_MST_CODE.NameText = xfrmCommonPopup.dtReturn.Rows[0]["CD_NM"].ToString();
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

                _pEquipmentCodeMstRegisterEntity.CRUD = "R";

                MainFind_DisplayData();

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
                if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_SAVE_QUESTION) == DialogResult.No)
                {
                    return;
                }
                if (!dxValidationProvider.Validate())
                {
                    return;
                }

                if (_luEQUIPMENT_MST_NAME.Text.Length < 1)
                {
                    return;
                }

                //확인
                if (_luEQUIPMENT_MST_CODE.Text.Length > 0)
                {

                    _pEquipmentCodeMstRegisterEntity.CRUD = "U";
                }
                else
                {
                    _pEquipmentCodeMstRegisterEntity.CRUD = "C";
                }
                _pEquipmentCodeMstRegisterEntity.RTN_KEY = "";
                _pEquipmentCodeMstRegisterEntity.EQUIPMENT_MST_CODE = _luEQUIPMENT_MST_CODE.Text.ToString();
                _pEquipmentCodeMstRegisterEntity.EQUIPMENT_MST_NAME = _luEQUIPMENT_MST_NAME.Text.ToString();
                _pEquipmentCodeMstRegisterEntity.EQUIPMENT_TYPE = _luEQUIPMENT_TYPE.GetValue();

                _pEquipmentCodeMstRegisterEntity.REMARK = _luREMARK.Text.ToString();
                _pEquipmentCodeMstRegisterEntity.USE_YN = _luUSE_YN.GetValue();

                InputData_Save(_gdSUB_VIEW.GridControl.DataSource as DataTable);
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
                //if (_gdSUB_VIEW.GridControl != null && CoFAS_ConvertManager.DataTable_FindCount(_gdSUB_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", ""))
                //{
                //    if (CoFAS_DevExpressManager.ShowQuestionMessage("작업 초기화 하겠습니까?") == DialogResult.No)
                //    {
                //        return;
                //    }
                //    else
                //    {
                //조회조건 영역 
                //_luT_USE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "USE_YN", "", "", "").Tables[0], 0, 0, "");

                //_luT_PROCESS_TYPE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "PROCESS_TYPE", "", "", "").Tables[0], 0, 0, "",true);

                _luT_EQUIPMENT_TYPE.ItemIndex = 0;
                _luT_USE_YN.ItemIndex = 0;

                _luT_EQUIPMENT_MST_CODE.CodeText = "";
                _luT_EQUIPMENT_MST_CODE.NameText = "";

                _luEQUIPMENT_TYPE.ItemIndex = 0;
                _luUSE_YN.ItemIndex = 0;

                _luEQUIPMENT_MST_CODE.Text = "";
                _luEQUIPMENT_MST_NAME.Text = "";


                _pEquipmentCodeMstRegisterEntity.CRUD = "";
                SubFind_DisplayData();

                DisplayMessage(_pMSG_RESET_COMPLETE);
                //    }
                //}
                //else
                //{
                //    InitializeSetting();
                //    GridView gv = _gdMAIN_VIEW; //바인딩 되는 데이터 마스터 그리드 설정
                //    CoFAS_ControlManager.Controls_Binding(gv, true, this);

                //    DisplayMessage("초기화했습니다.");
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
                _pEquipmentCodeMstRegisterEntity.EQUIPMENT_MST_CODE = _luT_EQUIPMENT_MST_CODE.CodeText.ToString();
                _pEquipmentCodeMstRegisterEntity.EQUIPMENT_MST_NAME = _luT_EQUIPMENT_MST_CODE.NameText.ToString();
                _pEquipmentCodeMstRegisterEntity.EQUIPMENT_TYPE = _luT_EQUIPMENT_TYPE.GetValue();
                _pEquipmentCodeMstRegisterEntity.USE_YN = _luT_USE_YN.GetValue();


                _dtList = new EquipmentCodeMstRegisterBusiness().Equipment_Info_Mst(_pEquipmentCodeMstRegisterEntity);

                if (_pEquipmentCodeMstRegisterEntity.CRUD == "") _dtList.Rows.Clear();


                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pEquipmentCodeMstRegisterEntity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩

                    if (_pLocation_Code != "" && _pLocation_YN)
                    {
                        int rowHandle = _gdMAIN_VIEW.LocateByValue("EQUIPMENT_MST_CODE", _pLocation_Code);
                        if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                            _gdMAIN_VIEW.FocusedRowHandle = rowHandle;


                        //조회 후 초기화 
                        _pLocation_Code = "";
                    }
                }
                else
                {

                    _luUSE_YN.ItemIndex = 0;
                    _luEQUIPMENT_TYPE.ItemIndex = 0;

                    _luEQUIPMENT_MST_CODE.Text = "";
                    _luEQUIPMENT_MST_NAME.Text = "";
                    _luREMARK.Text = "";

                    _pEquipmentCodeMstRegisterEntity.CRUD = "";
                    MainFind_DisplayData();
                    SubFind_DisplayData();

                    //DisplayMessage("조회 내역이 없습니다.");
                    DisplayMessage(_pMSG_SEARCH_EMPT);
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

        #region ○ 메인바인딩조회 - MainBindingFind_DisplayData()

        private void MainBindingFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _dtList = new EquipmentCodeMstRegisterBusiness().Equipment_Info_Mst_Binding(_pEquipmentCodeMstRegisterEntity);

                if ((_dtList != null))
                {

                    CoFAS_ControlManager.Controls_Binding(_dtList, false, this);
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

        #region ○ 서브조회 - SubFind_DisplayData()

        private void SubFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _dtList = new EquipmentCodeMstRegisterBusiness().Equipment_Info_Detail(_pEquipmentCodeMstRegisterEntity);

                if (_pEquipmentCodeMstRegisterEntity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pEquipmentCodeMstRegisterEntity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB, _gdSUB_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩
                }
                else
                {
                    //DisplayMessage("상세 조회 내역이 없습니다.");
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB, _gdSUB_VIEW, _dtList);
                    DisplayMessage(_pMSG_SEARCH_EMPT_DETAIL);

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

        private void InputData_Save(DataTable dtSave)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                bool isError = false;

                isError = new EquipmentCodeMstRegisterBusiness().Equipment_Info_Save(_pEquipmentCodeMstRegisterEntity, dtSave);

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

                    // 화면 갱신
                    _pEquipmentCodeMstRegisterEntity.CRUD = "R";
                    _pEquipmentCodeMstRegisterEntity.EQUIPMENT_MST_CODE = "";
                    _pEquipmentCodeMstRegisterEntity.EQUIPMENT_MST_NAME = "";
                    _pEquipmentCodeMstRegisterEntity.USE_YN = _luT_USE_YN.GetValue();

                    _pLocation_Code = _pEquipmentCodeMstRegisterEntity.RTN_KEY;  //저장 위치 

                    MainFind_DisplayData();

                    InitializeControl();
                    _pEquipmentCodeMstRegisterEntity.CRUD = "";
                    SubFind_DisplayData();
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

        private void CoFAS_DevExpressManager_OnOpenButton(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            

            ButtonEdit btnedit = sender as ButtonEdit;
            GridView g = null;
            DataRow dr = null;
            byte[] tempa = null;


            Image IMG = null;
           // FileStream STR = null;

            if (btnedit != null)
            {
                var gridControl = btnedit.Parent as DevExpress.XtraGrid.GridControl;
                if (gridControl == null)
                    return;

                var gridView = gridControl.FocusedView as DevExpress.XtraGrid.Views.Grid.GridView;
                g = gridView;
                if (gridView == null)
                    return;

                var dataRow = gridView.GetFocusedDataRow();
                if (dataRow == null)
                    return;
                dr = dataRow;
            }

            switch (e.Button.Caption.ToString())
            {
                case "EQUIPMENT_IMAGE":

                    switch (e.Button.Index)
                    {
                        case 0:
                            //MessageBox.Show("EQUIPMENT_IMAGE 오픈");
                            try
                            {
                                OpenFileDialog ofd = new OpenFileDialog();
                                ofd.DefaultExt = "*";
                                ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png;)|*.jpg; *.jpeg; *.gif; *.bmp; *.png; | ALL(*.*) | *.*";

                                if (ofd.ShowDialog() == DialogResult.OK)
                                {

                                    IMG = Image.FromFile(ofd.FileName);

                                    btnedit.EditValue = IMG;

                                    tempa = (byte[])(new ImageConverter()).ConvertTo(IMG, typeof(byte[]));

                                    g.SetFocusedRowCellValue("EQUIPMENT_IMAGE", tempa);

                                }
                            }
                            catch (ExceptionManager pExceptionManager)
                            {
                                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
                            }
                            break;
                        case 1:
                            //MessageBox.Show("EQUIPMENT_IMAGE 다운로드");

                            object otemp = g.GetFocusedRowCellValue("EQUIPMENT_IMAGE");

                            ImageConverter imgcvt = new ImageConverter();

                            if (otemp == null || otemp.ToString() == "") return;

                            if (((byte[])otemp).Length > 1)
                            {
                                SaveFileDialog saveFile = new SaveFileDialog();
                                saveFile.InitialDirectory = @"C:\";
                                saveFile.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png;)|*.jpg; *.jpeg; *.gif; *.bmp; *.png; | ALL(*.*) | *.*";
                                saveFile.FileName = "Equipment_Image";
                                if (saveFile.ShowDialog() == DialogResult.OK)
                                {

                                    Image returnImage = (Image)imgcvt.ConvertFrom(otemp);

                                    returnImage.Save(saveFile.FileName);
                                }

                            }
                            break;
                        case 2:
                            //MessageBox.Show("EQUIPMENT_IMAGE 미리보기");

                            object otemp2 = g.GetFocusedRowCellValue("EQUIPMENT_IMAGE");
                            
                            if (otemp2 == null || otemp2.ToString() == "") return;

                            if (((byte[])otemp2).Length > 1)
                            {
                                ImageConverter imgcvt2 = new ImageConverter();
                                Image returnImage2 = (Image)imgcvt2.ConvertFrom(otemp2);

                                frmImageView.CORP_CDDE = _pCORP_CODE;
                                frmImageView.USER_CODE = _pUSER_CODE;
                                frmImageView.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                                frmImageView.FONT_TYPE = _pFONT_SETTING;
                                frmImageView.IMAGE_DATA = returnImage2;

                                frmImageView xfrmImageView = new CORE.UserForm.frmImageView(); //유저컨트롤러 설정 부분

                                xfrmImageView.ShowDialog();

                                xfrmImageView.Dispose();
                            }
                            break;
                        case 3:
                            //MessageBox.Show("EQUIPMENT_IMAGE 삭제");

                            object otemp3 = g.GetFocusedRowCellValue("EQUIPMENT_IMAGE");

                            if (otemp3 == null || otemp3.ToString() == "") return;

                            if (((byte[])otemp3).Length > 1)
                            {
                                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                                bool isError = false;

                                try
                                {
                                    _pEquipmentCodeMstRegisterEntity.CRUD = "U";
                                    _pEquipmentCodeMstRegisterEntity.EQUIPMENT_MST_CODE = _luEQUIPMENT_MST_CODE.Text.ToString();
                                    _pEquipmentCodeMstRegisterEntity.EQUIPMENT_CODE = g.GetFocusedRowCellValue("EQUIPMENT_CODE").ToString();
                                    _pEquipmentCodeMstRegisterEntity.USE_YN = g.GetFocusedRowCellValue("USE_YN").ToString();

                                    byte[] blogo = null;
                                    blogo = new byte[1];

                                    _pEquipmentCodeMstRegisterEntity.EQUIPMENT_IMAGE = blogo;

                                    isError = new EquipmentCodeMstRegisterBusiness().Equipment_Info_Image_delete(_pEquipmentCodeMstRegisterEntity);

                                    if (isError)
                                    {
                                        //오류 발생.
                                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_DELETE_ERROR);
                                    }
                                    else
                                    {
                                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_DELETE);

                                    }


                                    MainFind_DisplayData();

                                    InitializeControl();
                                    _pEquipmentCodeMstRegisterEntity.CRUD = "";
                                    SubFind_DisplayData();

                                }
                                catch (ExceptionManager pExceptionManager)
                                {
                                    CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
                                }
                            }
                            
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }

        private void CoFAS_DevExpressManager_OnButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            CoFAS_DevExpressManager._OnButtonPressed -= CoFAS_DevExpressManager_OnButtonPressed;
            btnEvent(sender, e);
            CoFAS_DevExpressManager._OnButtonPressed += CoFAS_DevExpressManager_OnButtonPressed;
        }

        private void btnEvent(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ButtonEdit btnedit = sender as ButtonEdit;
            GridView g = null;
            DataRow dr = null;
            string _sFCode = string.Empty;
            string _sFName = string.Empty;
            string _sSERVICE_NAME = string.Empty;

            string _sResultCode = string.Empty;
            string _sResultName = string.Empty;

            //switch (e.Button.Caption.ToString())
            switch (e.Button.Caption.ToString())
            {
                case "EQUIPMENT_DOCUMENT_BTN":
                    if (btnedit != null)
                    {
                        var gridControl = btnedit.Parent as DevExpress.XtraGrid.GridControl;
                        if (gridControl == null)
                            return;

                        var gridView = gridControl.FocusedView as DevExpress.XtraGrid.Views.Grid.GridView;
                        g = gridView;
                        if (gridView == null)
                            return;

                        var dataRow = gridView.GetFocusedDataRow();
                        if (dataRow == null)
                            return;
                        dr = dataRow;
                    }

                    if (dr["EQUIPMENT_CODE"].ToString() == "") return;
                    //if (dr["ORDER_NUMBER"].ToString() == "") return;
                    //if (dr["ORDER_REVISION"].ToString() == "") return;

                    EM.UserForm.frmCommonPopup.CORP_CDDE = _pCORP_CODE;
                    EM.UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
                    EM.UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    EM.UserForm.frmCommonPopup.FONT_TYPE = _pFONT_SETTING;
                    EM.UserForm.frmCommonPopup.FTP_PATH = _pFTP_IP_PORT;
                    EM.UserForm.frmCommonPopup.FTP_ID = _pFTP_ID;
                    EM.UserForm.frmCommonPopup.FTP_PW = _pFTP_PW;

                    EM.UserForm.frmCommonPopup.ARRAY = new object[2] { "", "" }; //넘기는 파라메터 에 따라 설정
                    EM.UserForm.frmCommonPopup.ARRAY_CODE = new object[5] { dr["EQUIPMENT_MST_CODE"].ToString(), dr["EQUIPMENT_CODE"].ToString(), "", "", "" };//넘기는 파라메터 에 따라 설정

                    EM.UserForm.frmCommonPopup xfrmcommonPopup2 = new EM.UserForm.frmCommonPopup("ucEquipmentDocumentListPopup"); //유저컨트롤러 설정 부분

                    xfrmcommonPopup2.ShowDialog();

                    xfrmcommonPopup2.Dispose();


                    break;
            }
        }
    }
}

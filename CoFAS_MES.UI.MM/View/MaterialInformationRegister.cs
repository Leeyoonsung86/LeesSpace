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
    public partial class MaterialInformationRegister : frmBaseNone
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
        private string _pFTP_IP_PORT = string.Empty;     // FTP SERVER IP 정보
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

        private MaterialInformationRegisterEntity _pMaterialInformationRegisterEntity = null; // 엔티티 생성

        private DataTable _dtList = null; //조회 데이터 리스트

        private bool _pFirstYN = true;

        // 코에버 frp 관련 변수
        private string _pFileName = "";                                 //local 파일이름   //ofd로 받아서 넣기 safe~
        private string _pFullName = "";                                 //localfile 파일명 포함 전체 경로        
        private string _pFTP_DOWNLOAD_PATH = ""; // ftp download에 사용

        OpenFileDialog ofd;

        public MaterialInformationRegister()
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
                if (_gdSUB_VIEW.GridControl != null && CoFAS_ConvertManager.DataTable_FindCount(_gdSUB_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", ""))
                {
                    //if (CoFAS_DevExpressManager.ShowQuestionMessage("작업중인 자료가 있습니다.\n종료 하겠습니까?") == DialogResult.No)
                    if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_WORKING + "\n" + _pMSG_EXIT_QUESTION) == DialogResult.No)
                    {
                        pFormClosingEventArgs.Cancel = true;
                        return;
                    }
                }
                //else if (CoFAS_DevExpressManager.ShowQuestionMessage("작업 종료 하겠습니까?") == DialogResult.No)
                else if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_EXIT_QUESTION) == DialogResult.No)
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
                _luT_PART._OnOpenClick -= _luT_PART_OnOpenClick;
                //_luIMAGE_NAME._OnOpenClick -= _luFILE_NAME__OnOpenClick;
                //_luIMAGE_NAME._OnDownloadClick -= _luFILE_NAME__OnDownloadClick;
                //_luIMAGE_NAME._OnViewClick -= _luFILE_NAME__OnViewClick;
                //_luIMAGE_NAME._OnDeleteClick -= _luFILE_NAME__OnDeleteClick;
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
                _gdSUB.Visible = false;
                //Form_SearchButtonClicked(null, null);
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
                //_gdSUB.Visible = false;

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
                _pMaterialInformationRegisterEntity = new MaterialInformationRegisterEntity();
                _pMaterialInformationRegisterEntity.CORP_CODE = _pCORP_CODE;
                _pMaterialInformationRegisterEntity.USER_CODE = _pUSER_CODE;
                _pMaterialInformationRegisterEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;

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
                _luT_PART._OnOpenClick += _luT_PART_OnOpenClick;
                //그리드 초기화 

                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                _pMaterialInformationRegisterEntity.CRUD = "";
                if (_pFirstYN)
                {
                    MainFind_DisplayData(); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.

                    _luIMAGE_NAME._OnOpenClick += _luFILE_NAME__OnOpenClick;
                    _luIMAGE_NAME._OnDownloadClick += _luFILE_NAME__OnDownloadClick;
                    _luIMAGE_NAME._OnViewClick += _luFILE_NAME__OnViewClick;
                    _luIMAGE_NAME._OnDeleteClick += _luFILE_NAME__OnDeleteClick;

                    _luIMAGE_NAME.DeleteVisible = true;

                    if ((DBManager.InitDatabaseName == "coever_mes_glenzen") || (DBManager.InitDatabaseName == "coever_mes_hpnc"))
                    {
                        _luPART_REVISION_NO.ReadOnly = true;
                    }
                    _pFirstYN = false;
                }

                SubFind_DisplayData("", "", "", ""); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.

                //컨트롤러 별 추가 이벤트 생성은 화면 설정 마지막에 진행
                _gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick;
                _gdSUB_VIEW.InitNewRow += _gdSUB_VIEW_InitNewRow;
                _gdSUB_VIEW.RowStyle += _gdSUB_VIEW_RowStyle;

                //그리드 버튼추가 시 클릭 이벤트 처리 
                // CoFAS_DevExpressManager._OnButtonPressed += CoFAS_DevExpressManager__OnButtonPressed;


            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion

        private void _gdSUB_VIEW_RowStyle(object sender, RowStyleEventArgs e)
        {
            DevExpress.XtraGrid.Views.Base.ColumnView view = (DevExpress.XtraGrid.Views.Base.ColumnView)sender;
            if (view.IsValidRowHandle(e.RowHandle))
            {
                if (view.GetRowCellValue(e.RowHandle, "USE_YN") != null && view.GetRowCellValue(e.RowHandle, "USE_YN").ToString() == "N")
                    e.Appearance.BackColor = Color.Tomato;

            }
            //(Color)view.GetRowCellValue(e.RowHandle, "Color");
            //view.SetRowCellValue(e.RowHandle, view.Columns["PART_UNITCOST_START_DATE"], DateTime.Today);
        }

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

                _gdSUB_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB, _gdSUB_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdSUB.Name.ToString()));
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
                _luT_PART_TYPE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "PART_TYPE_MATERIAL_T01", "", "", "").Tables[0], 0, 0, "", true);

                _luT_PART.CodeText = "";
                _luPART_CODE.ReadOnly = false;

                _luT_VEND_PART_CODE.Text = "";

                _luT_PART.NameText = "";
                _luPART_NAME.ReadOnly = false;

                _luT_PART_REVISION_NO.Text = "";

                _luT_USE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "common_code", "CD99", "", "").Tables[0], 0, 0, "");
                _luT_USE_YN.ItemIndex = 0;
                _luT_USE_YN.ReadOnly = false;

                _luPART_CODE.Text = "";
                _luPART_CODE.ReadOnly = true;
                _luPART_NAME.Text = "";

                _luPART_REVISION_NO.Text = "1.0";

                _luVEND_PART_CODE.Text = "";

                _luPART_SAFE_STOCK.Text = "";
                
                _luPART_COST.Text = "";
                _luPART_COST.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                //_luPART_START_DATE.Text = "";
                //_luPART_END_DATE.Text = "";
                _luREMARK.Text = "";

                _luPART_TYPE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "PART_TYPE_MATERIAL_T01", "", "", "").Tables[0], 0, 0, "");
                _luPART_TYPE.ItemIndex = 0;
                _luPART_TYPE.ReadOnly = false;

                //18.09.04 기존 : CD09
                _luPART_UNIT.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "COMMON_CODE", "CD04", "", "").Tables[0], 0, 0, "");
                _luPART_UNIT.ItemIndex = 0;
                _luPART_TYPE.ReadOnly = false;

                //_luSALE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", "COMMON_CODE", "CD99", "", "").Tables[0], 0, 0, "");
                //_luSALE_YN.ReadOnly = false;
                //_luPURC_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", "COMMON_CODE", "CD99", "", "").Tables[0], 0, 0, "");
                //_luPURC_YN.ReadOnly = false;
                //_luOUTT_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", "COMMON_CODE", "CD99", "", "").Tables[0], 0, 0, "");
                //_luOUTT_YN.ReadOnly = false;
                _luUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "USE_YN", "", "", "").Tables[0], 0, 0, "");
                _luUSE_YN.ItemIndex = 0;
                _luUSE_YN.ReadOnly = false;

                //이미지 파일 관련
                //_luIMAGE_NAME.initImage();
                _luIMAGE_NAME.Text = "";

                _pBefore_ImageName = "";
                // 컨트롤러 유효성 검증 처리 기본 컨트롤러 에서만 사용 
                dxValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
                dxValidationProvider.Validate();

                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                //if (_pFirstYN)
                //{
                //    _gdMAIN.DataSource = null;
                //}
                _pMaterialInformationRegisterEntity.CRUD = "";
                MainFind_DisplayData();

            //    _gdMAIN.DataSource = null;

            //    _gdSUB.DataSource = null;
            //    SubFind_DisplayData("", "", "", "");

                //데이터 영역
                _luPART_START_DATE.DateTime = DateTime.Today;
                _luPART_END_DATE.DateTime = DateTime.MaxValue;

                ofd = null;
                _pImageDelete_YN = false;

                _luPART_TYPE.ItemIndex = 0;
                _luPART_UNIT.ItemIndex = 0;
                _luUSE_YN.ItemIndex = 0;

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
                _luPART_CODE.Text = "";
                _luPART_CODE.ReadOnly = true;
                _luPART_NAME.Text = "";
                _luPART_REVISION_NO.Text = "1.0";
                _luVEND_PART_CODE.Text = "";
                _luPART_SAFE_STOCK.Text = "";
                _luPART_SAFE_STOCK.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                _luPART_COST.Text = "";
                _luPART_COST.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                _luPART_STANDARD.Text = "";
                _luPART_MANUFACTURER.Text = "";
                _luREMARK.Text = "";
                _luT_PART.CodeText = "";
                _luT_PART.NameText = "";
                _luPART_TYPE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "PART_TYPE_MATERIAL_T01", "", "", "").Tables[0], 0, 0, "");
                _luPART_TYPE.ItemIndex = 0;
                _luPART_TYPE.ReadOnly = false;

                _luPART_UNIT.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "COMMON_CODE", "CD04", "", "").Tables[0], 0, 0, "");
                _luPART_UNIT.ItemIndex = 0;
                _luPART_TYPE.ReadOnly = false;

                _luUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "COMMON_CODE", "CD99", "", "").Tables[0], 0, 0, "");
                _luUSE_YN.ItemIndex = 0;
                _luUSE_YN.ReadOnly = false;

                _pMaterialInformationRegisterEntity.CRUD = "";
                MainFind_DisplayData();


                //이미지 파일 관련
                _luIMAGE_NAME.Text = "";

                _pBefore_ImageName = "";
             
                //데이터 영역
                _luPART_START_DATE.DateTime = DateTime.Today;
                _luPART_END_DATE.DateTime = DateTime.MaxValue;

               
                _pImageDelete_YN = false;
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

        #region ○ 서브 그리드 신규로우 생성시 이벤트 생성 - _gdSUB_VIEW_InitNewRow(object sender, InitNewRowEventArgs e)
        private void _gdSUB_VIEW_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns["PART_UNITCOST_START_DATE"], DateTime.Today);
            view.SetRowCellValue(e.RowHandle, view.Columns["PART_UNITCOST_END_DATE"], DateTime.Parse("9999-12-31"));
            view.SetRowCellValue(e.RowHandle, view.Columns["USE_YN"], "Y");
        }
        #endregion

        #region ○ 메인 그리드 로우 선택 이벤트 생성 - _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        private void _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;

                CoFAS_ControlManager.Controls_Binding(gv, false, this);


                _ckDNAGEROUS_ITEM.Checked = gv.GetFocusedRowCellValue("DNAGEROUS_ITEM").ToString() == "1" ? true : false;

                string strPART_CODE = gv.GetFocusedRowCellValue("PART_CODE").ToString();
                string strPART_REVISION_NO = gv.GetFocusedRowCellValue("PART_REVISION_NO").ToString();
                string strPART_TYPE = gv.GetFocusedRowCellValue("PART_TYPE").ToString();
                string strPART_NAME = gv.GetFocusedRowCellValue("PART_NAME").ToString();
                string strFILE_NAME = gv.GetFocusedRowCellValue("IMAGE_NAME").ToString();
                string strFTP_PATH = string.Format(@"{0}{1}/{2}/", _pFTP_PATH, "ITEM", "ITEM_IMAGE");
                _pBefore_ImageName = strFILE_NAME;
                _pMaterialInformationRegisterEntity.CRUD = "R";

                _luPART_TYPE.ReadOnly = true;

                // 선택한 이미지 파일 _luIMAGE_NAME에 바인딩
                //using (Stream responseStream = CoFAS_FTPManager.FTPFileBinding(strFTP_PATH, strFILE_NAME, _pFTP_ID, _pFTP_PW))
                //{
                //    if (responseStream != null)
                //    {
                //        System.Drawing.Bitmap bitmapImage = new Bitmap(responseStream);

                //        //_luIMAGE_NAME.Image = bitmapImage;
                //    }
                //}

                SubFind_DisplayData(strPART_CODE, strPART_REVISION_NO, strPART_TYPE, strPART_NAME);
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion

        #region ○  ucOpenButtonEdit _luFILE_NAME 엑셀파일 가져오기, 내려받기, 저장하기 기능
        private void _luFILE_NAME__OnDownloadClick(object sender, EventArgs e)
        {
            string strFTP_PATH = "";

            //ftp에서 local로 다운로드 
            if (_luIMAGE_NAME.Text != null && _luIMAGE_NAME.Text != "" && _luIMAGE_NAME.Text.IndexOf("*NoSave*") < 0)
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.InitialDirectory = @"C:\";
                saveFile.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png;)|*.jpg; *.jpeg; *.gif; *.bmp; *.png; | ALL(*.*) | *.*";
                saveFile.FileName = _luIMAGE_NAME.Text.ToString();

                strFTP_PATH = string.Format(@"{0}{1}/%2F/{2}/{3}/", _pFTP_PATH, "ITEM", "ITEM_IMAGE", _pWINDOW_NAME);

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    _pFTP_DOWNLOAD_PATH = saveFile.FileName;

                    CoFAS_FTPManager.FTPDownLoad(strFTP_PATH, _luIMAGE_NAME.Text, _pFTP_ID, _pFTP_PW, _pFTP_DOWNLOAD_PATH);

                    //DisplayMessage("선택한 파일이 지정한 폴더(" + _pFTP_DOWNLOAD_PATH + ")에 저장되었습니다.");
                    DisplayMessage(_pMSG_SAVE);
                }
            }
            else
            {
                //CoFAS_DevExpressManager.ShowErrorMessage("선택한 파일이 없거나 저장하지 않았습니다.");
                CoFAS_DevExpressManager.ShowErrorMessage(_pMSG_NO_SELETED_ITEM);
            }
        }


        private void _luFILE_NAME__OnOpenClick(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();

            ofd.DefaultExt = "*";
            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png;)|*.jpg; *.jpeg; *.gif; *.bmp; *.png; | ALL(*.*) | *.*";// 이미지용
            //ofd.Filter = "Pdf Files(*.pdf;) | *.pdf; | ALL(*.*) | *.*"; //pdf 용 테스트중
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _luIMAGE_NAME.Text = "*NoSave* " + ofd.SafeFileName;



                // 선택한 이미지 파일 _luIMAGE_NAME에 바인딩
                //IMG = Image.FromFile(ofd.FileName);//이미지

                //using (FileStream stream = new FileStream(ofd.FileName.ToString(), FileMode.Open))//, FileAccess.Read))
                //{
                //    STR = stream;
                //}

            }
        }

        //Image IMG = null;
        //FileStream STR = null;

        private void _luFILE_NAME__OnViewClick(object sender, EventArgs e)
        {
            if (_luIMAGE_NAME.Text.IndexOf("*NoSave*") > -1 || _luIMAGE_NAME.Text.Trim().Length < 4)
            {
                //CoFAS_DevExpressManager.ShowInformationMessage("저장하지 않아서 볼 수 없습니다.");
                CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_NOT_DISPLAY_NOT_SAVE);
            }
            else
            {


                string strFTP_PATH = string.Format(@"{0}{1}/%2F/{2}/{3}/", _pFTP_PATH, "ITEM", "ITEM_IMAGE", _pWINDOW_NAME);

                frmImageView.CORP_CDDE = _pCORP_CODE;
                frmImageView.USER_CODE = _pUSER_CODE;
                frmImageView.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                frmImageView.FONT_TYPE = _pFONT_SETTING;
                frmImageView.IMAGE_DATA = Image.FromStream(CoFAS_FTPManager.FTPImage(strFTP_PATH, _luIMAGE_NAME.Text, _pFTP_ID, _pFTP_PW));

                frmImageView xfrmImageView = new CORE.UserForm.frmImageView(); //유저컨트롤러 설정 부분

                xfrmImageView.ShowDialog();

                xfrmImageView.Dispose();
            }

        }

        private void _luFILE_NAME__OnDeleteClick(object sender, EventArgs e)
        {
            string strFTP_PATH = "";
            if (_luPART_CODE.Text != null && _luPART_CODE.Text != "")
            {
                // ftp에서 삭제
                //if (_luIMAGE_NAME.Text != null && _luIMAGE_NAME.Text != "")
                if (_luIMAGE_NAME.Text != null && _luIMAGE_NAME.Text != "" && _luIMAGE_NAME.Text.IndexOf("*NoSave*") < 0)
                {
                    strFTP_PATH = string.Format(@"{0}{1}/%2F/{2}/{3}/", _pFTP_PATH, "ITEM", "ITEM_IMAGE", _pWINDOW_NAME);

                    CoFAS_FTPManager.FTPDelete(_luIMAGE_NAME.Text, strFTP_PATH, _pFTP_ID, _pFTP_PW);
                    _pImageDelete_YN = true;
                    _luIMAGE_NAME.Text = "";
                    ofd = null;
                    Form_SaveButtonClicked(null, null);
                    //CoFAS_DevExpressManager.ShowInformationMessage("선택한 파일이 FTP 서버에서 삭제되었습니다.");
                    //삭제한 후에 db에서도 file name 지우기
                }
                else if (_luIMAGE_NAME.Text.IndexOf("*NoSave*") > -1)
                {
                    _luIMAGE_NAME.Text = _pBefore_ImageName;// "";
                    _pImageDelete_YN = false;
                    ofd = null;
                }
                else if (_luIMAGE_NAME.Text == "")
                {
                    //CoFAS_DevExpressManager.ShowErrorMessage("선택한 파일이 FTP 서버에 없습니다");
                    ofd = null;
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowErrorMessage("선택한 파일이 FTP 서버에 없습니다");
                    CoFAS_DevExpressManager.ShowErrorMessage(_pMSG_PLZ_CONNECT_FTP);
                }
            }
            else
            {
                //신규등록이므로 -> 파일을 SaveFileDialog 초기화 시키기
                _luIMAGE_NAME.Text = _pBefore_ImageName;// "";
                _pImageDelete_YN = false;
                ofd = null;
            }
        }

        //private void _luFILE_NAME__OnOpenClick(object sender, EventArgs e)
        //{
        //    try
        //    {

        //        OpenFileDialog ofd = new OpenFileDialog();
        //        ofd.DefaultExt = "*";
        //        ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png;)|*.jpg; *.jpeg; *.gif; *.bmp; *.png; | ALL(*.*) | *.*";

        //        if (ofd.ShowDialog() == DialogResult.OK)
        //        {
        //            _pFullName = ofd.FileName;    // FTP업로드 확인용, 새로운 파일을 올렸을 때만 데이터 입력됨
        //            _pFileName = ofd.SafeFileName;

        //            _luFILE_NAME.Text = _pFileName;

        //            // 선택한 이미지 파일 _luIMAGE_NAME에 바인딩
        //            using (FileStream stream = new FileStream(ofd.FileName.ToString(), FileMode.Open, FileAccess.Read))
        //            {
        //                if (File.Exists(_pFullName))
        //                {
        //                    System.Drawing.Bitmap bitmapImage = new Bitmap(_pFullName);

        //                    //_luIMAGE_NAME.Image = bitmapImage;
        //                }
        //            }
        //        }
        //    }
        //    catch (ExceptionManager pExceptionManager)
        //    {
        //        CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
        //    }
        //}
        #endregion

        // 추가 이벤트 생성
        #region ○ 조회 서치박스 - _luT_PART_OnOpenClick(object sender, EventArgs e)
        private void _luT_PART_OnOpenClick(object sender, EventArgs e)
        {
            try
            {
                //검색조건 자재 팝업 버튼 이벤트

                frmCommonPopup.USER_CODE = _pUSER_CODE;
                frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                frmCommonPopup.ARRAY = new object[2] { "Material_Code", _luT_PART.NameText }; //넘기는 파라메터 에 따라 설정, 제품/조회할때 품목명을 던지기
                frmCommonPopup.ARRAY_CODE = new object[2] { _luT_PART.CodeText, _luT_PART.NameText };
                frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("MaterialCodeInfo"); //유저컨트롤러 설정 부분

                xfrmCommonPopup.ShowDialog();

                if (xfrmCommonPopup.dtReturn == null)
                {
                    xfrmCommonPopup.Dispose();
                    return;
                }

                if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                {
                    _luT_PART.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["PART_CODE"].ToString();
                    _luT_PART.NameText = xfrmCommonPopup.dtReturn.Rows[0]["PART_NAME"].ToString();
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

                _pMaterialInformationRegisterEntity.CRUD = "R";
             

                MainFind_DisplayData();

                //InitializeControl2();
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
                if (_luPART_CODE.Text.ToString() != "")
                {
                    _pMaterialInformationRegisterEntity.CRUD = "U";
                }
                else
                {
                    _pMaterialInformationRegisterEntity.CRUD = "C";
                }

                if (_luPART_NAME.Text.Trim().Length < 2)
                {
                    //CoFAS_DevExpressManager.ShowErrorMessage("자재명을 입력해주세요.");
                    CoFAS_DevExpressManager.ShowErrorMessage(_pMSG_INPUT_DATA);
                    return;
                }

                DataTable tmpdt = _gdSUB_VIEW.GridControl.DataSource as DataTable;

                int subcount = 0;
                string format1 = "yyyy-MM-dd tt hh:mm:ss";
                string format2 = "yyyyMMdd";

                for (int i = 0; i < tmpdt.Rows.Count; i++)
                {
                    if (tmpdt.Rows[i]["PART_UNITCOST"].ToString() != "")
                    {
                        if (tmpdt.Rows[i]["PART_UNITCOST_START_DATE"].ToString() != "" && tmpdt.Rows[i]["PART_UNITCOST_END_DATE"].ToString() != "")
                        {
                            DateTime stdate;
                            DateTime ltdate;
                            if (tmpdt.Rows[i]["PART_UNITCOST_START_DATE"].ToString().Length != 8)
                            {
                                DateTime.TryParse(tmpdt.Rows[i]["PART_UNITCOST_START_DATE"].ToString(), out stdate);
                            }
                            else
                                DateTime.TryParseExact(tmpdt.Rows[i]["PART_UNITCOST_START_DATE"].ToString(), format2, null, System.Globalization.DateTimeStyles.AssumeLocal, out stdate);

                            if (tmpdt.Rows[i]["PART_UNITCOST_END_DATE"].ToString().Length != 8)
                            {
                                DateTime.TryParse(tmpdt.Rows[i]["PART_UNITCOST_END_DATE"].ToString(), out ltdate);
                            }
                            else
                                DateTime.TryParseExact(tmpdt.Rows[i]["PART_UNITCOST_END_DATE"].ToString(), format2, null, System.Globalization.DateTimeStyles.AssumeLocal, out ltdate);

                            if ((ltdate.Date - stdate.Date).Days < 1)
                                subcount++;
                        }
                        else
                            subcount++;
                    }
                    else
                        subcount++;

                }
                if (subcount > 0)
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("단가, 시작일, 종료일을 확인해주세요.");
                    CoFAS_DevExpressManager.ShowErrorMessage(_pMSG_CHECK_SEARCH_DATE);
                    return;
                }


                _pMaterialInformationRegisterEntity.PART_REVISION_NO = _luPART_REVISION_NO.Text.ToString();
                _pMaterialInformationRegisterEntity.PART_CODE = _luPART_CODE.Text.ToString();
                _pMaterialInformationRegisterEntity.PART_NAME = _luPART_NAME.Text.ToString();
                _pMaterialInformationRegisterEntity.PART_TYPE = _luPART_TYPE.GetValue();
                _pMaterialInformationRegisterEntity.VEND_PART_CODE = _luVEND_PART_CODE.Text.ToString();
                _pMaterialInformationRegisterEntity.PART_SAFE_STOCK = _luPART_SAFE_STOCK.NumText;
                _pMaterialInformationRegisterEntity.PART_COST = _luPART_COST.Text.ToString();
                _pMaterialInformationRegisterEntity.PART_UNIT = _luPART_UNIT.GetValue();
                _pMaterialInformationRegisterEntity.PART_STANDARD = _luPART_STANDARD.Text.ToString();
                _pMaterialInformationRegisterEntity.PART_MANUFACTURER = _luPART_MANUFACTURER.Text.ToString();
                _pMaterialInformationRegisterEntity.PART_START_DATE = _luPART_START_DATE.DateTime.ToString("yyyyMMdd");
                _pMaterialInformationRegisterEntity.PART_END_DATE = _luPART_END_DATE.DateTime.ToString("yyyyMMdd");
                _pMaterialInformationRegisterEntity.REMARK = _luREMARK.Text.ToString();
                _pMaterialInformationRegisterEntity.IMAGE_NAME = _luIMAGE_NAME.Text.ToString();
                _pMaterialInformationRegisterEntity.USE_YN = _luUSE_YN.GetValue();


                InputData_Save(_gdSUB_VIEW.GridControl.DataSource as DataTable);



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
                if (_gdSUB_VIEW.GetFocusedRowCellValue(_gdSUB_VIEW.Columns["CRUD"]).ToString() == "C")
                {
                    // 신규 데이터는 로우 삭제
                    _gdSUB_VIEW.DeleteRow(_gdSUB_VIEW.FocusedRowHandle);
                }
                else
                {
                    // 수정 데이터는 "CRUD" 처리
                    _gdSUB_VIEW.SetRowCellValue(_gdSUB_VIEW.FocusedRowHandle, _gdSUB_VIEW.Columns["CRUD"], "D");
                }

                // 수정 후 포커스 이동 안되면 데이터 반영 안됨. 
                // 삭제 버튼 클릭시에는 GetFocusedDataRow().EndEdit() 처리 해야됨.
                // 마우스 팝업 메뉴에서 처리는 자동으로 처리됨.
                _gdSUB_VIEW.GetFocusedDataRow().EndEdit();

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

                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                //확인
                if (_gdSUB_VIEW.GridControl != null && CoFAS_ConvertManager.DataTable_FindCount(_gdSUB_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", ""))
                {
                    //if (CoFAS_DevExpressManager.ShowQuestionMessage("작업중인 자료가 있습니다.\n초기화 하겠습니까?") == DialogResult.No)
                    if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_WORKING + "\n" + _pMSG_RESET_QUESTION) == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        InitializeControl2();
                        DisplayMessage(_pMSG_RESET_COMPLETE);
                    }
                }
                else
                {
                    InitializeControl2();
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
                
                _pMaterialInformationRegisterEntity.PART_CODE = _luT_PART.CodeText.ToString();
                _pMaterialInformationRegisterEntity.PART_NAME = _luT_PART.NameText.ToString();
                _pMaterialInformationRegisterEntity.PART_REVISION_NO = _luT_PART_REVISION_NO.Text.ToString();
                _pMaterialInformationRegisterEntity.PART_TYPE = _luT_PART_TYPE.GetValue();
                _pMaterialInformationRegisterEntity.VEND_PART_CODE = _luT_VEND_PART_CODE.Text.ToString().Trim();
                _pMaterialInformationRegisterEntity.USE_YN = _luT_USE_YN.GetValue();

                _dtList = new MaterialInformationRegisterBusiness().MaterialInformationRegister_Info(_pMaterialInformationRegisterEntity);

                if (_pMaterialInformationRegisterEntity.CRUD == "") _dtList.Rows.Clear();


                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pMaterialInformationRegisterEntity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩

                    if (_pLocation_Code != "" && _pLocation_YN)
                    {
                        int rowHandle = _gdMAIN_VIEW.LocateByValue("PART_CODE", _pLocation_Code);
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

        private void DetailFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _pMaterialInformationRegisterEntity.PART_CODE = _luT_PART.CodeText.ToString();

                _dtList = new MaterialInformationRegisterBusiness().MaterialInformationRegister_Info(_pMaterialInformationRegisterEntity);

                if (_pMaterialInformationRegisterEntity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pMaterialInformationRegisterEntity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩

                    if (_pLocation_Code != "" && _pLocation_YN)
                    {
                        int rowHandle = _gdMAIN_VIEW.LocateByValue("PART_CODE", _pLocation_Code);
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

        #region ○ 서브조회 - SubFind_DisplayData()

        private void SubFind_DisplayData(string strPART_CODE, string strPART_REVISION_NO, string strPART_TYPE, string strPART_NAME)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _pMaterialInformationRegisterEntity.PART_CODE = strPART_CODE;
                _pMaterialInformationRegisterEntity.PART_REVISION_NO = strPART_REVISION_NO;

                _dtList = new MaterialInformationRegisterBusiness().MaterialInformationRegister_Info_Sub(_pMaterialInformationRegisterEntity);

                if (_pMaterialInformationRegisterEntity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pMaterialInformationRegisterEntity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB, _gdSUB_VIEW, _dtList);
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");

                    _pMaterialInformationRegisterEntity.CRUD = "";
                    SubFind_DisplayData(strPART_CODE, strPART_REVISION_NO, strPART_TYPE, strPART_NAME);
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {
                _gdSUB_VIEW.BestFitColumns();

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


                string strFTP_PATH = string.Format(@"{0}{1}/%2F/{2}/", _pFTP_PATH, "ITEM", "ITEM_IMAGE");

                if (ofd != null && ofd.SafeFileName.Length > 3)
                {
                    if (CoFAS_FTPManager.FTPUpload_CheckDirectory(ofd.SafeFileName, ofd.FileName, _pFTP_ID, _pFTP_PW, strFTP_PATH, _pWINDOW_NAME))
                    {
                        //CoFAS_DevExpressManager.ShowInformationMessage("저장 처리 되었습니다.");
                        _luIMAGE_NAME.Text = ofd.SafeFileName;
                        _pMaterialInformationRegisterEntity.IMAGE_NAME = _luIMAGE_NAME.Text.ToString();
                        _pFullName = "";
                    }
                    else
                    {
                        isError = true;
                        //CoFAS_DevExpressManager.ShowInformationMessage("FTP 연결을 확인해주세요.");
                    }
                }

                isError = new MaterialInformationRegisterBusiness().MaterialInformationRegister_Info_Save(_pMaterialInformationRegisterEntity, dtSave);

                if (isError)
                {
                    //오류 발생.
                    //CoFAS_DevExpressManager.ShowInformationMessage("저장 오류 발생! 데이터를 확인 하세요.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                    //화면 표시.

                }
                else
                {

                    InitializeControl2();

                    if (!_pImageDelete_YN)
                    {
                        //CoFAS_DevExpressManager.ShowInformationMessage("저장 처리 되었습니다.");
                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                    }
                    else
                    {
                        //CoFAS_DevExpressManager.ShowInformationMessage("선택한 파일이 FTP에서 삭제되었습니다.");
                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_PLZ_CONNECT_FTP + "\n" + _pMSG_DELETE);
                    }


                    _pLocation_Code = _pMaterialInformationRegisterEntity.RTN_KEY;  //저장 위치 




                    _pMaterialInformationRegisterEntity.CRUD = "R";
                    //_pMaterialInformationRegisterEntity.PART_CODE = "";
                    //_pMaterialInformationRegisterEntity.PART_REVISION_NO = "";
                    //_pMaterialInformationRegisterEntity.PART_NAME = "";
                    //_pMaterialInformationRegisterEntity.PART_TYPE = _luT_PART_TYPE.GetValue();
                    //_pMaterialInformationRegisterEntity.USE_YN = _luT_USE_YN.GetValue();
                    //_pMaterialInformationRegisterEntity.VEND_PART_CODE = _luT_VEND_PART_CODE.Text.ToString().Trim();
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

        private void _ckDANGEROUS_ITEM_CheckedChanged(object sender, EventArgs e)
        {
            if(_ckDNAGEROUS_ITEM.Checked && _luPART_CODE.Text.ToString().Length > 0)
            {
                _ucbtDANGEROUS_DETAIL.Enabled = true;
            }
            else
            {
                _ucbtDANGEROUS_DETAIL.Enabled = false;
            }
        }

        private void _ucbtDANGEROUS_DETAIL_Click(object sender, EventArgs e)
        {
            if (_luPART_CODE.Text.ToString().Length > 0)
            {
                UserForm.frmRiskMaterialInfoRegister.CORP_CDDE = _pCORP_CODE;
                UserForm.frmRiskMaterialInfoRegister.USER_CODE = _pUSER_CODE;
                UserForm.frmRiskMaterialInfoRegister.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                UserForm.frmRiskMaterialInfoRegister.FONT_TYPE = _pFONT_SETTING;
                UserForm.frmRiskMaterialInfoRegister.FTP_PATH = _pFTP_IP_PORT;
                UserForm.frmRiskMaterialInfoRegister.FTP_ID = _pFTP_ID;
                UserForm.frmRiskMaterialInfoRegister.FTP_PW = _pFTP_PW;

                UserForm.frmRiskMaterialInfoRegister.ARRAY = new object[2] { "", "" }; //넘기는 파라메터 에 따라 설정
                UserForm.frmRiskMaterialInfoRegister.ARRAY_CODE = new object[2] { _luPART_CODE.Text.ToString(), _luPART_NAME.Text.ToString() };//넘기는 파라메터 에 따라 설정

                UserForm.frmRiskMaterialInfoRegister xfrmRiskMaterialInfoRegister = new UserForm.frmRiskMaterialInfoRegister(); //유저컨트롤러 설정 부분

                xfrmRiskMaterialInfoRegister.ShowDialog();

                xfrmRiskMaterialInfoRegister.Dispose();
            }
        }
    }
}

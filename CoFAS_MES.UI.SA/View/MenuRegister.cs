using CoFAS_MES.CORE.BaseForm;
using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.Function;
using CoFAS_MES.CORE.UserForm;
using CoFAS_MES.UI.SA.Business;
using CoFAS_MES.UI.SA.Entity;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoFAS_MES.UI.SA
{
    public partial class MenuRegister : frmBaseNone
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
        private string _pFTP_PW = string.Empty;          //FTP PW 정보

        private string _pUSER_GRANT = string.Empty; // 사용자 권한

        private string _pLocation_Code = string.Empty;  // 저장/수정 후 로케이션 위치 저장
        private bool _pLocation_YN = true;              // 저장위치 사용여부

        private MenuRegisterEntity _pMenuRegisterEntity = null; // 엔티티 생성

        private DataTable _dtList = null; //조회 데이터 리스트

        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용

        private string _pFileName = "";                                 //local 파일이름   //ofd로 받아서 넣기 safe~
        private string _pFullName = "";                                 //localfile 파일명 포함 전체 경로     
        private byte[] _pXmlfile = null;

        private bool _pRowClick_chk = false;

        private string _pFTP_BEFROE_FILENAME = string.Empty;    //업로드 파일을 변경할경우, 이전파일명 가지고 있고 이전파일명으로 삭제하기

        //알림창메시지 복사 시작
        private string _pMSG_SEARCH                         = string.Empty;   // 조회 되었습니다.
        private string _pMSG_SEARCH_EMPT                    = string.Empty;   // 조회 항목이 없습니다.
        private string _pMSG_SAVE_QUESTION                  = string.Empty;   // 데이터 저장 처리 하겠습니까?
        private string _pMSG_SAVE                           = string.Empty;   // 저장 처리 되었습니다.
        private string _pMSG_SAVE_ERROR                     = string.Empty;   // 저장 처리 중 오류가 발생 하였습니다.
        private string _pMSG_DELETE_QUESTION                = string.Empty;   // 데이터 삭제 처리 하겠습니까?
        private string _pMSG_DELETE                         = string.Empty;   // 삭제 처리 되었습니다.
        private string _pMSG_DELETE_ERROR                   = string.Empty;   // 삭제 처리 중 오류가 발생 하였습니다.
        private string _pMSG_DELETE_COMPLETE                = string.Empty;   // 삭제된 데이터 입니다.
        private string _pMSG_INPUT_DATA                     = string.Empty;   // 데이터를 입력 해 주세요.
        private string _pMSG_INPUT_DATA_ERROR               = string.Empty;   // 데이터 입력이 잘못되었습니다.
        private string _pMSG_WORKING                        = string.Empty;   // 작업중인 항목이 있습니다.
        private string _pMSG_RESET_QUESTION                 = string.Empty;   // 초기화 하시겠습니까?
        private string _pMSG_EXIT_QUESTION                  = string.Empty;   // 종료 하겠습니까?
        private string _pMSG_SELECT                         = string.Empty;   // 데이터를 선택해주세요.
        //추가
        private string _pMSG_PLZ_CONNECT_FTP                = string.Empty;    //FTP 연결을 확인해주세요.  
        private string _pMSG_AGAIN_INPUT_DATA               = string.Empty;    //생산계획데이터는 다시 입력하여야 합니다  
        private string _pMSG_DOWNLOAD_COMPLETE              = string.Empty;    //다운로드 되었습니다.  
        private string _pMSG_SEARCH_EMPT_DETAIL             = string.Empty;    //상세 조회 내역이 없습니다.  
        private string _pMSG_SPLITQTY_LARGE_MORE            = string.Empty;    //분할수량이 더 큽니다.  
        private string _pMSG_DELETE_ERROR_NO_DATA           = string.Empty;    //삭제할 데이터가 없습니다.  
        private string _pMSG_ORDERQTY_LARGE_THAN_0          = string.Empty;    //발주수량이 0보다 작을 수 없습니다.  
        private string _pMSG_PLAN_LARGE_THAN_ORDER          = string.Empty;    //등록할 지시수량이 계획수량보다 큽니다.  
        private string _pMSG_DELETE_ERROR_CONNECT_FTP       = string.Empty;    //"삭제 처리 중 에러가 발생했습니다. FTP 연결을 확인해주세요."  
        private string _pMSG_INPUT_LESS_THAN_NOTOUTQTY      = string.Empty;    //"미출고수량보다 작게 입력해주세요.미출고수량"  
        private string _pMSG_LOAD_DATA                      = string.Empty;    //생산계획을 불러오십시오.  
        private string _pMSG_NEW_REG_GUBN                   = string.Empty;    //신규등록 부분입니다.  
        private string _pMSG_INPUT_NUMERIC                  = string.Empty;    //숫자를 입력하시기 바랍니다.  
        private string _pMSG_NO_SELETED_ITEM                = string.Empty;    //선택한 파일이 없습니다  
        private string _pMSG_EXIST_COMPANY_ID               = string.Empty;    //이미 등록된 사업자등록번호 입니다.  
        private string _pMSG_NOT_DELETE_DATA_IN             = string.Empty;    //생산입고 데이터는 삭제할 수 없습니다.  
        private string _pMSG_NOT_MODIFY_DATA_IN             = string.Empty;    //생산입고 데이터는 수정할 수 없습니다.  
        private string _pMSG_SELECT_NEWREG_SAVE             = string.Empty;    //"신규 등록을 선택하셨습니다.저장하겠습니까?"  
        private string _pMSG_INPUT_LARGER_THAN_0            = string.Empty;    //입고수량이 0보다 작을 수 없습니다.  
        private string _pMSG_NOT_DELETE_DATA_OUT            = string.Empty;    //생산출고 데이터는 삭제할 수 없습니다.  
        private string _pMSG_NOT_MODIFY_DATA_OUT            = string.Empty;    //생산출고 데이터는 수정할 수 없습니다.  
        private string _pMSG_CANCLE_NEWREG_MODIFY           = string.Empty;    //"신규 등록을 해제하셨습니다.기존 파일을 수정하겠습니까?"  
        private string _pMSG_NO_SELETED_ITEM_OR_NO_SAVE     = string.Empty;    //선택한 파일이 없거나 저장하지 않았습니다.  
        private string _pMSG_NO_INPUT_LAGER_THAN_NOTINQTY   = string.Empty;    //입고 수량이 미입고 수량보다 많을 수 없습니다.  
        private string _pMSG_REG_DATA                       = string.Empty;    //데이터를 등록해주세요.  
        private string _pMSG_ADD_FAVORITE_ITEM              = string.Empty;    //즐겨찾기에 추가 되었습니다.  
        private string _pMSG_CHECK_SEARCH_DATE              = string.Empty;    //조회 일자를 확인해 주세요.  
        private string _pMSG_NOT_DISPLAY_ERROR              = string.Empty;    //저장된 파일에 문제가 발생해 볼수 없습니다.  
        private string _pMSG_NO_EXIST_INPUT_DATA            = string.Empty;    //입력된 조건값이 없습니다.  
        private string _pMSG_NOT_DISPLAY_NOT_SAVE           = string.Empty;    //저장하지 않아서 볼 수 없습니다.  
        private string _pMSG_CHECK_VALID_ITEM               = string.Empty;    //필수항목을 확인해주시기 바랍니다.  
        private string _pMSG_DELETE_FAVORITE_ITEM           = string.Empty;    //즐겨찾기에서 삭제 되었습니다.  
        private string _pMSG_NOT_EXIST_PRINTING_EXCEL       = string.Empty;    //해당 거래처로 저장된 인쇄용 엑셀 파일이 없습니다.  
        private string _pMSG_SELECT_DOWNLOAD_TEMPLETE       = string.Empty;     //템플릿을 다운로드할 메뉴를 선택해주세요.  
        private string _pMSG_RESET_COMPLETE                 = string.Empty;     //템플릿을 다운로드할 메뉴를 선택해주세요.  
        
        //알림창메시지 복사 끝
        public MenuRegister()
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
                    // if (CoFAS_DevExpressManager.ShowQuestionMessage("작업중인 자료가 있습니다.\n종료 하겠습니까?") == DialogResult.No)
                    if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_WORKING+"\n"+ _pMSG_EXIT_QUESTION) == DialogResult.No)
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
                _gdMAIN_VIEW.RowCellClick -= _gdMAIN_VIEW_RowCellClick;

                _gdSUB_VIEW.InitNewRow -= _gdSUB_VIEW_InitNewRow;

                CoFAS_DevExpressManager._OnOpenButton -= CoFAS_DevExpressManager__OnOpenButton;
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
        
                //화면 컨트롤러 설정
                InitializeControl(true);

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
                _pFTP_IP_PORT = MainForm.UserEntity.FTP_IP_PORT;  //string.Format(@"{0}/{1}/", MainForm.UserEntity.FTP_IP_PORT, "test"); //화면 별 해당 위치 지정
                _pFTP_PW = MainForm.UserEntity.FTP_PW;

                _pUSER_GRANT = MainForm.UserEntity.USER_GRANT;

                _pWINDOW_NAME = this.Name;

                                //메인 화면 공통 메세지 처리

                _pMSG_SEARCH                        = MainForm.MessageEntity.MSG_SEARCH;
                _pMSG_SEARCH_EMPT                   = MainForm.MessageEntity.MSG_SEARCH_EMPT;
                _pMSG_SAVE_QUESTION                 = MainForm.MessageEntity.MSG_SAVE_QUESTION;
                _pMSG_SAVE                          = MainForm.MessageEntity.MSG_SAVE;
                _pMSG_SAVE_ERROR                    = MainForm.MessageEntity.MSG_SAVE_ERROR;
                _pMSG_DELETE_QUESTION               = MainForm.MessageEntity.MSG_DELETE_QUESTION;
                _pMSG_DELETE                        = MainForm.MessageEntity.MSG_DELETE;
                _pMSG_DELETE_ERROR                  = MainForm.MessageEntity.MSG_DELETE_ERROR;
                _pMSG_DELETE_COMPLETE               = MainForm.MessageEntity.MSG_DELETE_COMPLETE;
                _pMSG_INPUT_DATA                    = MainForm.MessageEntity.MSG_INPUT_DATA;
                _pMSG_INPUT_DATA_ERROR              = MainForm.MessageEntity.MSG_INPUT_DATA_ERROR;
                _pMSG_WORKING                       = MainForm.MessageEntity.MSG_WORKING;
                _pMSG_RESET_QUESTION                = MainForm.MessageEntity.MSG_RESET_QUESTION;
                _pMSG_EXIT_QUESTION                 = MainForm.MessageEntity.MSG_EXIT_QUESTION;
                _pMSG_SELECT                        = MainForm.MessageEntity.MSG_SELECT;
                //추가
               _pMSG_PLZ_CONNECT_FTP               = MainForm.MessageEntity.MSG_PLZ_CONNECT_FTP              ;
               _pMSG_AGAIN_INPUT_DATA              = MainForm.MessageEntity.MSG_AGAIN_INPUT_DATA             ;
               _pMSG_DOWNLOAD_COMPLETE             = MainForm.MessageEntity.MSG_DOWNLOAD_COMPLETE            ;
               _pMSG_SEARCH_EMPT_DETAIL            = MainForm.MessageEntity.MSG_SEARCH_EMPT_DETAIL           ;
               _pMSG_SPLITQTY_LARGE_MORE           = MainForm.MessageEntity.MSG_SPLITQTY_LARGE_MORE          ;
               _pMSG_DELETE_ERROR_NO_DATA          = MainForm.MessageEntity.MSG_DELETE_ERROR_NO_DATA         ;
               _pMSG_ORDERQTY_LARGE_THAN_0         = MainForm.MessageEntity.MSG_ORDERQTY_LARGE_THAN_0        ;
               _pMSG_PLAN_LARGE_THAN_ORDER         = MainForm.MessageEntity.MSG_PLAN_LARGE_THAN_ORDER        ;
               _pMSG_DELETE_ERROR_CONNECT_FTP      = MainForm.MessageEntity.MSG_DELETE_ERROR_CONNECT_FTP     ;
               _pMSG_INPUT_LESS_THAN_NOTOUTQTY     = MainForm.MessageEntity.MSG_INPUT_LESS_THAN_NOTOUTQTY    ;
               _pMSG_LOAD_DATA                     = MainForm.MessageEntity.MSG_LOAD_DATA                    ;
               _pMSG_NEW_REG_GUBN                  = MainForm.MessageEntity.MSG_NEW_REG_GUBN                 ;
               _pMSG_INPUT_NUMERIC                 = MainForm.MessageEntity.MSG_INPUT_NUMERIC                ;
               _pMSG_NO_SELETED_ITEM               = MainForm.MessageEntity.MSG_NO_SELETED_ITEM              ;
               _pMSG_EXIST_COMPANY_ID              = MainForm.MessageEntity.MSG_EXIST_COMPANY_ID             ;
               _pMSG_NOT_DELETE_DATA_IN            = MainForm.MessageEntity.MSG_NOT_DELETE_DATA_IN           ;
               _pMSG_NOT_MODIFY_DATA_IN            = MainForm.MessageEntity.MSG_NOT_MODIFY_DATA_IN           ;
               _pMSG_SELECT_NEWREG_SAVE            = MainForm.MessageEntity.MSG_SELECT_NEWREG_SAVE           ;
               _pMSG_INPUT_LARGER_THAN_0           = MainForm.MessageEntity.MSG_INPUT_LARGER_THAN_0          ;
               _pMSG_NOT_DELETE_DATA_OUT           = MainForm.MessageEntity.MSG_NOT_DELETE_DATA_OUT          ;
               _pMSG_NOT_MODIFY_DATA_OUT           = MainForm.MessageEntity.MSG_NOT_MODIFY_DATA_OUT          ;
               _pMSG_CANCLE_NEWREG_MODIFY          = MainForm.MessageEntity.MSG_CANCLE_NEWREG_MODIFY         ;
               _pMSG_NO_SELETED_ITEM_OR_NO_SAVE    = MainForm.MessageEntity.MSG_NO_SELETED_ITEM_OR_NO_SAVE   ;
               _pMSG_NO_INPUT_LAGER_THAN_NOTINQTY  = MainForm.MessageEntity.MSG_NO_INPUT_LAGER_THAN_NOTINQTY ;
               _pMSG_REG_DATA                      = MainForm.MessageEntity.MSG_REG_DATA                     ;
               _pMSG_ADD_FAVORITE_ITEM             = MainForm.MessageEntity.MSG_ADD_FAVORITE_ITEM            ;
               _pMSG_CHECK_SEARCH_DATE             = MainForm.MessageEntity.MSG_CHECK_SEARCH_DATE            ;
               _pMSG_NOT_DISPLAY_ERROR             = MainForm.MessageEntity.MSG_NOT_DISPLAY_ERROR            ;
               _pMSG_NO_EXIST_INPUT_DATA           = MainForm.MessageEntity.MSG_NO_EXIST_INPUT_DATA          ;
               _pMSG_NOT_DISPLAY_NOT_SAVE          = MainForm.MessageEntity.MSG_NOT_DISPLAY_NOT_SAVE         ;
               _pMSG_CHECK_VALID_ITEM              = MainForm.MessageEntity.MSG_CHECK_VALID_ITEM             ;
               _pMSG_DELETE_FAVORITE_ITEM          = MainForm.MessageEntity.MSG_DELETE_FAVORITE_ITEM         ;
               _pMSG_NOT_EXIST_PRINTING_EXCEL      = MainForm.MessageEntity.MSG_NOT_EXIST_PRINTING_EXCEL     ;
               _pMSG_SELECT_DOWNLOAD_TEMPLETE      = MainForm.MessageEntity.MSG_SELECT_DOWNLOAD_TEMPLETE     ;

                //메뉴 화면 엔티티 설정
                _pMenuRegisterEntity = new MenuRegisterEntity();
                _pMenuRegisterEntity.USER_CODE = _pUSER_CODE;
                _pMenuRegisterEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;

                //그리드 설정
                InitializeGrid();

                //콤보박스 설정
                _luT_MODULE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "COMMON_CODE", "CD30", "", "").Tables[0], 0, 0, "", true);
                _luT_USE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "USE_YN", "", "", "").Tables[0], 0, 0, "",true);
                _luT_USE_YN.ItemIndex = 1;
                _luUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "USE_YN", "", "", "").Tables[0], 0, 0, "");
                _luP_MENU_NO.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "MODULE_P_MENU", "", "", "").Tables[0], 0, 0, "");
                _luMODULE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "MODULE_MENU", "", "", "").Tables[0], 0, 0, "");
                _luICONCSS.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "ICONCSS", "", "", "").Tables[0], 0, 0, "");

          
                //_luMODULE.getfo
                _luP_MENU_NO.ValueChanged += _luP_MENU_NO_ValueChanged;
                //화면 설정 언어 & 명칭 변경.
                DataTable dtLanguage = new LanguageBusiness().Language_Info(_pWINDOW_NAME, _pLANGUAGE_TYPE);

                if (dtLanguage != null && dtLanguage.Rows.Count > 0)
                {
                    CoFAS_ControlManager.Language_Info(dtLanguage, this);
                }


                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                _pMenuRegisterEntity.CRUD = "";

                if (_pFirstYN)
                {

                    //컨트롤러 별 추가 이벤트 생성은 화면 설정 마지막에 진행
                    _gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick;

                    _gdSUB_VIEW.InitNewRow += _gdSUB_VIEW_InitNewRow;

                    //그리드 버튼추가 시 클릭 이벤트 처리 
                    CoFAS_DevExpressManager._OnOpenButton += CoFAS_DevExpressManager__OnOpenButton;

                    _pFirstYN = false;
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

                _gdSUB_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB, _gdSUB_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdSUB.Name.ToString()));
                //_gdSUB_VIEW2 = CoFAS_DevExpressManager.Grid_Setting(_gdSUB2, _gdSUB_VIEW2, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdSUB2.Name.ToString()));
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }


        #endregion

        #region ○ 컨트롤 초기화 - InitializeControl()

        //Bool 상단 초기화 true,하단만 초기화 false
        private void InitializeControl(bool bSearchYN)
        {
            try
            {
                //조회조건 영역 
                if (bSearchYN)
                {
                    _luT_MENU_NAME.Text = "";
                    _luT_MENU_NAME.ReadOnly = false;

                    _luT_WINDOW_NAME.Text = "";
                    _luT_WINDOW_NAME.ReadOnly = false;


                    _luT_MODULE.ItemIndex = 0;


                    //_luT_USE_YN.ItemIndex = 0;
                }

                //데이터 영역
                //_luMODULE.Text =  "";
                //_luMODULE.ReadOnly = false;

                _luMENU_NO.Text = "";
                _luMENU_NO.ReadOnly = true;

                _luWINDOW_NAME.Text = "";
                _luWINDOW_NAME.ReadOnly = false;

                _luMENU_NAME.Text = "";
                _luMENU_NAME.ReadOnly = false; 

                _luDSP_SORT.Text = "";
                _luDSP_SORT.ReadOnly = false;

                //_luICONCSS.Text = "";
                //_luICONCSS.ReadOnly = false;

                _luICONCSS.ItemIndex = 0;

                _luREMARK.Text = "";
                
               
                _luP_MENU_NO.ItemIndex = 0;

                _luMODULE.ItemIndex = 0;
                _luMODULE.ReadOnly = false;


                // 컨트롤러 유효성 검증 처리 기본 컨트롤러 에서만 사용 
                dxValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
                dxValidationProvider.Validate();


                _gdMAIN.DataSource = null;
                _gdSUB.DataSource = null;

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
                _pRowClick_chk = true;
                GridView gv = sender as GridView;

                CoFAS_ControlManager.Controls_Binding(gv, false, this); //

                //string strWINDOW_NAME = gv.GetFocusedRowCellValue("WINDOW_NAME").ToString();
                //string strGRID_NAME = gv.GetFocusedRowCellValue("GRID_NAME").ToString();

                _luMODULE.ReadOnly = true;
                
                _pMenuRegisterEntity.CRUD = "R";
                _pMenuRegisterEntity.MENU_NO = gv.GetFocusedRowCellValue("MENU_NO").ToString();

                SubFind_DisplayData();
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


        #region ○ "XML_FILE_NAME" 엑셀파일 가져오기, 내려받기, 저장하기 기능
        private void CoFAS_DevExpressManager__OnOpenButton(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Caption.ToString())
            {
                case "XML_FILE_NAME": //해당 그리드에 필드명 // 2개 이상 그리드의 버튼 항목들은 버튼 타입에 필드 명칭이 모두 다르게 설정 되어야됨.


                    switch (e.Button.Index)
                    {
                        case 0:
                            OpenFileDialog ofd = new OpenFileDialog();
                            ofd.DefaultExt = "*";
                            ofd.Filter = "XML(*.xml)|*.xml|ALL(*.*)|*.*";
                            _pFTP_BEFROE_FILENAME = _gdSUB_VIEW.GetFocusedRowCellValue("XML_FILE_NAME").ToString();
                            if (ofd.ShowDialog() == DialogResult.OK)
                            {
                                _pFullName = ofd.FileName;    // FTP업로드 확인용, 새로운 파일을 올렸을 때만 데이터 입력됨
                                _pFileName = ofd.SafeFileName;

                                

                                _gdSUB_VIEW.SetRowCellValue(_gdSUB_VIEW.FocusedRowHandle, _gdSUB_VIEW.Columns["XML_FILE_NAME"], _pFileName);


                                // 선택한 xml파일을 _pXmlfile(byte[])에 바인딩
                                using (FileStream stream = new FileStream(ofd.FileName.ToString(), FileMode.Open, FileAccess.Read))
                                {
                                    BinaryReader br = new BinaryReader(stream);
                                    _pXmlfile = br.ReadBytes((Int32)stream.Length);
                                }
                            }

                            break;

                        case 1:
                            // DB에서 local로 다운로드
                            if (_luMENU_NO.Text.ToString() == "" )
                            {
                                //메뉴 선택이 안된 것이므로 templete을 다운로드할 메뉴 화면이 없는 것임/ load됐을 때, 바로 다운로드 버튼을 누르면 실행안되게끔

                                //메인 그리드의 메뉴를 선택하도록 메시지 띄우기
                                //메시지 띄우기 - "템플릿을 다운로드할 메뉴를 선택해주세요."
                                //CoFAS_DevExpressManager.ShowInformationMessage("템플릿을 다운로드할 메뉴를 선택해주세요.");
                                CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SELECT_DOWNLOAD_TEMPLETE);

                            }
                            else if (_gdSUB_VIEW.IsNewItemRow(_gdSUB_VIEW.FocusedRowHandle))
                            {
                                //CoFAS_DevExpressManager.ShowInformationMessage("신규등록 부분입니다.");
                                CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_NEW_REG_GUBN);
                            }
                            else
                            {
                                //메뉴 선택이 되어 있는 상황
                                //그 중에서도 db에 파일이 저장이 안 된 것이면 DB에 저장된 파일이 아님을 말해줘야 함.

                                if (_gdSUB_VIEW.GetRowCellValue(_gdSUB_VIEW.FocusedRowHandle, "XML_FILE_NAME").ToString() == "")
                                {
                                    //조회된 _gdSUB에 XML_FILE_NAME이 없으면, db에 저장된 파일이 없다고 메세지 띄우기 
                                    //CoFAS_DevExpressManager.ShowInformationMessage("DB에 저장된 파일이 없습니다.");
                                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_NO_SELETED_ITEM_OR_NO_SAVE+"\n"+ _pMSG_REG_DATA);
                                }
                                else
                                {
                                    // db에 저장된 것이면 다운로드하기 
                                    //조회된 _gdSUB에 XML_FILE_NAME이 있으면, Templete_Download() 실행
                                    _pMenuRegisterEntity.XML_FILE_NAME = _gdSUB_VIEW.GetRowCellValue(_gdSUB_VIEW.FocusedRowHandle, "XML_FILE_NAME").ToString();
                                    _pMenuRegisterEntity.DSP_SORT = _gdSUB_VIEW.GetRowCellValue(_gdSUB_VIEW.FocusedRowHandle, "DSP_SORT").ToString();
                                    _pMenuRegisterEntity.USE_YN = _gdSUB_VIEW.GetRowCellValue(_gdSUB_VIEW.FocusedRowHandle, "USE_YN").ToString();

                                    Templete_Download();

                                    //DisplayMessage(string.Format("{0}", "다운로드 되었습니다."));
                                    DisplayMessage(string.Format("{0}", _pMSG_DOWNLOAD_COMPLETE));
                                    
                                }
                            }

                            break;

                        case 2:
                            // DB에서 삭제하기 - entity.menu_no의 _gdSUB_VIEW.FocusedRowHandle


                            if (_luMENU_NO.Text.ToString() == "" )
                            {
                                //메뉴 선택이 안된 것이므로 templete을 삭제할 메뉴 화면이 없는 것임/ load됐을 때, 바로 삭제버튼을 누르면 실행안되게끔

                                //메인 그리드의 메뉴를 선택하도록 메시지 띄우기
                                //메시지 띄우기 - "템플릿을 저장할 메뉴를 선택해주세요."
                                //CoFAS_DevExpressManager.ShowInformationMessage("템플릿을 삭제할 메뉴를 선택해주세요.");
                                CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SELECT);
                                

                            }
                            else if (_gdSUB_VIEW.IsNewItemRow(_gdSUB_VIEW.FocusedRowHandle))
                            {
                                //CoFAS_DevExpressManager.ShowInformationMessage("신규등록 부분입니다.");
                                CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_NEW_REG_GUBN);
                                
                            }
                            else
                            {
                                //메뉴 선택이 되어 있는 상황
                                //그 중에서도 db에 파일이 저장이 안 된 것이면 DB에 저장된 파일이 아님을 말해줘야 함.

                                if (_gdSUB_VIEW.GetRowCellValue(_gdSUB_VIEW.FocusedRowHandle, "XML_FILE_NAME").ToString() == "")
                                {
                                    //조회된 _gdSUB에 XML_FILE_NAME이 없으면, db에 저장된 파일이 없다고 메세지 띄우기 
                                    //CoFAS_DevExpressManager.ShowInformationMessage("DB에 저장된 파일이 없습니다.");
                                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_NO_SELETED_ITEM_OR_NO_SAVE+"\n"+ _pMSG_REG_DATA);
                                    

                                }
                                else
                                {
                                    //if (CoFAS_DevExpressManager.ShowQuestionMessage("삭제 하겠습니까?") == DialogResult.No)
                                    if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_DELETE_QUESTION) == DialogResult.No)
                                    {
                                        return;
                                    }
                                    else
                                    {
                                        // db에 저장된 것이면 삭제하기 
                                        //조회된 _gdSUB에 XML_FILE_NAME이 있으면, Templete_Delete() 실행
                                        _pMenuRegisterEntity.DSP_SORT = _gdSUB_VIEW.GetRowCellValue(_gdSUB_VIEW.FocusedRowHandle, "DSP_SORT").ToString();
                                        _pMenuRegisterEntity.USE_YN = _gdSUB_VIEW.GetRowCellValue(_gdSUB_VIEW.FocusedRowHandle, "USE_YN").ToString();

                                        Templete_Delete();

                                        //DisplayMessage(string.Format("{0}", "삭제 되었습니다."));
                                        DisplayMessage(string.Format("{0}", _pMSG_DELETE));
                                        

                                    }

                                }
                            }

                            break;
                    }
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
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

            

                _pMenuRegisterEntity.CRUD = "R";
                _pMenuRegisterEntity.WINDOW_NAME = _luT_WINDOW_NAME.Text.ToString();
                _pMenuRegisterEntity.MENU_NAME = _luT_MENU_NAME.Text.ToString();
                _pMenuRegisterEntity.MODULE = _luT_MODULE.GetValue();
                _pMenuRegisterEntity.USE_YN = _luT_USE_YN.GetValue();
                
                InitializeControl(false);

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

                //확인
                
                //if (_luP_MENU_NO.ReadOnly)
                if(_luMODULE.ReadOnly)
                {
                    _pMenuRegisterEntity.CRUD = "U";
                }
                else
                {
                    _pMenuRegisterEntity.CRUD = "C";
                }

                _pMenuRegisterEntity.MODULE             = _luMODULE.GetValue(); ;// _luMODULE.Text.ToString();
                _pMenuRegisterEntity.P_MENU_NO          = _luP_MENU_NO.GetValue();
                _pMenuRegisterEntity.MENU_NO            = _luMENU_NO.Text.ToString();
                _pMenuRegisterEntity.WINDOW_NAME        = _luWINDOW_NAME.Text.ToString();
                _pMenuRegisterEntity.MENU_NAME          = _luMENU_NAME.Text.ToString();
                _pMenuRegisterEntity.DSP_SORT           = _luDSP_SORT.Text.ToString();
                _pMenuRegisterEntity.ICONCSS            = _luICONCSS.GetValue();// _luICONCSS.Text.ToString();
                _pMenuRegisterEntity.USE_YN             = _luUSE_YN.GetValue();
                _pMenuRegisterEntity.REMARK             = _luREMARK.Text.ToString();

                _pMenuRegisterEntity.XML_FILE = _pXmlfile;
                _pMenuRegisterEntity.XML_FILE_NAME = _pFileName;


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
                bool chk = false;
                //확인
                if (_gdMAIN_VIEW.GridControl != null && CoFAS_ConvertManager.DataTable_FindCount(_gdMAIN_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", ""))
                {
                    chk = true;
                }else
                {
                    if (_gdSUB_VIEW.GridControl != null && CoFAS_ConvertManager.DataTable_FindCount(_gdSUB_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", ""))
                    {
                        chk = true;
                    }
                }


                if (chk)
                {
                    //if (CoFAS_DevExpressManager.ShowQuestionMessage("작업 초기화 하겠습니까?") == DialogResult.No)
                    if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_RESET_QUESTION) == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        InitializeControl(true);
                        GridView gv = _gdMAIN_VIEW; 
                     
                        _pRowClick_chk = false;
                        //DisplayMessage("초기화했습니다.");
                        DisplayMessage(_pMSG_RESET_COMPLETE);
                        
                    }
                }
                else
                {
                    //InitializeControl();
                    GridView gv = _gdMAIN_VIEW; 
                   
                    _pRowClick_chk = false;
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

                _dtList = new MenuRegisterBusiness().MenuRegister_Info(_pMenuRegisterEntity);

                if (_pMenuRegisterEntity.CRUD == "") _dtList.Rows.Clear();


                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pMenuRegisterEntity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩

                    if (_pLocation_Code != "" && _pLocation_YN)
                    {
                        int rowHandle = _gdMAIN_VIEW.LocateByValue("MENU_NO",Convert.ToInt32(_pLocation_Code));
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

        private void SubFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _pMenuRegisterEntity.MENU_NO = _luMENU_NO.Text.ToString();

                _dtList = new MenuRegisterBusiness().MenuRegister_Info_Sub(_pMenuRegisterEntity);

                if (_pMenuRegisterEntity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pMenuRegisterEntity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB, _gdSUB_VIEW, _dtList);
                    //CoFAS_DevExpressManager.BindGridControl(_gdSUB2, _gdSUB_VIEW2, _dtList);
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                    _pMenuRegisterEntity.CRUD = "";
                    SubFind_DisplayData();
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




                //데이터 검증
                string strMsg = "";
                    if(_luMENU_NAME.Text.Equals(""))
                {
                    strMsg = strMsg + "메뉴아이디/"; 
                }
                if (_luWINDOW_NAME.Text.Equals(""))
                {
                    strMsg = strMsg + "화면아이디/";
                }

                 if (_luMODULE.GetValue().Equals(""))
                {
                    strMsg = strMsg + "모듈/";
                }

                if (_luDSP_SORT.Text.Equals(""))
                {
                    strMsg = strMsg + "메뉴순서/";
                }
                if (_luICONCSS.GetValue().Equals(""))
                {
                    strMsg = strMsg + "아이콘/";
                }

                DataTable dtTemp = null;
                if (CoFAS_ConvertManager.DataTable_FindCount(dtSave, "CRUD IN ('C','U','D')", ""))
                { 
                    if (dtSave.Select("CRUD IN ('C','U','D')", "").Length > 0)
                    {
                        dtTemp = CoFAS_ConvertManager.DataTable_FindValue(dtSave, "CRUD IN ('C','U','D')", "");
                        if (dtTemp.Select("TEMPLETE_NAME ='' OR TEMPLETE_NAME is NULL OR XML_FILE_NAME='' OR XML_FILE_NAME is NULL OR USE_YN='' OR USE_YN is NULL", "").Length > 0)
                        {
                            //CoFAS_DevExpressManager.ShowInformationMessage("템플리 정보를 정확히 입력하세요.");
                            CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_INPUT_DATA_ERROR+"\n"+ _pMSG_CHECK_VALID_ITEM);
                            
                            return;
                        }
                    }

                    else
                        return;
                }
                if (strMsg.Equals(""))
                {

                    //isError = new MenuRegisterBusiness().MenuRegister_Info_Save(_pMenuRegisterEntity, dtSave);
                    isError = new MenuRegisterBusiness().MenuRegister_Info_Save(_pMenuRegisterEntity, dtTemp);

                    if (isError)
                    {
                        //오류 발생.
                        //CoFAS_DevExpressManager.ShowInformationMessage("저장 오류 발생! 데이터를 확인 하세요.");
                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR+"\n"+ _pMSG_CHECK_VALID_ITEM);
                        
                        //화면 표시.

                    }
                    else
                    {
                        if (dtTemp != null)
                        {
                            for (int i = 0; i < dtTemp.Rows.Count; i++)
                            {
                                string fileName = dtTemp.Rows[i][5].ToString();
                                _pMenuRegisterEntity.CRUD = dtTemp.Rows[i]["CRUD"].ToString();
                                int templete_check = Templete_Save(_pFileName);
                                if (templete_check.ToString() == "2")
                                    return;
                            }
                        }


                        

                        // 화면 갱신
                        _pMenuRegisterEntity.CRUD = "R";
                        _pMenuRegisterEntity.MENU_NAME = "";
                        _pMenuRegisterEntity.WINDOW_NAME = "";

                        _pMenuRegisterEntity.MODULE = "";
                        _pMenuRegisterEntity.USE_YN = _luT_USE_YN.GetValue();
                        _pMenuRegisterEntity.XML_FILE = null;
                        _pMenuRegisterEntity.XML_FILE_NAME = null;

                        _pLocation_Code = _pMenuRegisterEntity.RTN_KEY;  //저장 위치

                        InitializeControl(false);

                        MainFind_DisplayData();


                    }
                }else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage(string.Format("{0}\r\n가 입력 되지 않았습니다.",strMsg));
                    CoFAS_DevExpressManager.ShowInformationMessage(string.Format("{0}\r\n{1}", strMsg, _pMSG_INPUT_DATA));
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

        #region ○ XML 다운로드 - Templete_Download()

        private void Templete_Download()
        {
            try
            {
                
                string strFTP_PATH = "";
                
                if (_pMenuRegisterEntity.CRUD == "") _dtList.Rows.Clear();

                if (_gdSUB_VIEW.FocusedValue.ToString() == "") return;

                _pMenuRegisterEntity.XML_FILE_NAME = _gdSUB_VIEW.FocusedValue.ToString();

                //ftp에서 local로 다운로드 
                object _obList = new MenuRegisterBusiness().MenuRegister_Templete_Download(_pMenuRegisterEntity);

                if (_obList != null)
                {
                    SaveFileDialog saveFile = new SaveFileDialog();
                    saveFile.InitialDirectory = @"C:\";
                    saveFile.Filter = "XML(*.xml)|*.xml|ALL(*.*)|*.*";
                    saveFile.FileName = _pMenuRegisterEntity.XML_FILE_NAME;

                    strFTP_PATH = string.Format(@"{0}{1}/{2}/{3}/", _pFTP_IP_PORT, "USER", "PROGRAM_VIEW", _luWINDOW_NAME.Text.ToString());

                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        string _pDOWNLOAD_PATH = saveFile.FileName;

                        CoFAS_FTPManager.FTPDownLoad(strFTP_PATH, (saveFile.FileName.ToString().Split('\\')).Last(), _pFTP_ID, _pFTP_PW, _pDOWNLOAD_PATH);

                        //DisplayMessage("선택한 파일이 지정한 폴더(" + _pFTP_DOWNLOAD_PATH + ")에 저장되었습니다.");
                        DisplayMessage(_pMSG_SAVE + "(path:" + _pDOWNLOAD_PATH + ")");
                    }
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowErrorMessage("선택한 파일이 없습니다");
                    CoFAS_DevExpressManager.ShowErrorMessage(_pMSG_NO_SELETED_ITEM);

                }
                #region XML DB 저장 이전 코드

                //CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                //_pMenuRegisterEntity.MENU_NO = _luMENU_NO.Text.ToString();

                //object _obList = new MenuRegisterBusiness().MenuRegister_Templete_Download(_pMenuRegisterEntity);

                // if (_pMenuRegisterEntity.CRUD == "") _dtList.Rows.Clear();

                //if (_obList != null )
                //{
                //    //다운로드 to Local
                //    SaveFileDialog saveFile = new SaveFileDialog();
                //    saveFile.InitialDirectory = @"C:\";
                //    saveFile.Filter = "XML(*.xml)|*.xml|ALL(*.*)|*.*";
                //    saveFile.FileName = _pMenuRegisterEntity.XML_FILE_NAME;


                //    if (saveFile.ShowDialog() == DialogResult.OK)
                //    {


                //        //string _pDOWNLOAD_PATH = saveFile.FileName;   // saveFile.FileName은 선택하는 폴더로 바뀜

                //        FileInfo f = new FileInfo(saveFile.FileName);
                //        if (f.Exists)
                //        {
                //            f.Delete();
                //        }

                //        byte[] xmlfile = (byte[])_obList;

                //        using (Stream file = File.OpenWrite(saveFile.FileName))
                //        {
                //            file.Write(xmlfile, 0, xmlfile.Length);
                //        }

                //        //Process.Start(_pDOWNLOAD_PATH);   //다운로드된 파일 열기

                //        //DisplayMessage("선택한 파일이 지정한 폴더(" + saveFile.FileName + ")에 저장되었습니다.");
                //        DisplayMessage(_pMSG_SAVE+"(path : " + saveFile.FileName + ")");
                //    }
                //}
                //else
                //{
                //    //CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                //    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
                //}
                #endregion

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

        #region ○ XML 삭제 - Templete_Delete()

        private void Templete_Delete()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                GridView gv = _gdSUB_VIEW as GridView;

                CoFAS_ControlManager.Controls_Binding(gv, false, this); //


                bool isError = false;
                if (gv.GetFocusedValue() != null)
                {
                    _pMenuRegisterEntity.XML_FILE_NAME = gv.GetFocusedValue().ToString();
                }
                isError = new MenuRegisterBusiness().MenuRegister_Templete_Delete(_pMenuRegisterEntity);

                string strFTP_PATH = "";


                
                if (isError)
                {
                    //오류 발생.
                    //CoFAS_DevExpressManager.ShowInformationMessage("삭제 오류 발생! 데이터를 확인 하세요.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_DELETE_ERROR);

                    //화면 표시.

                }
                else
                {
                    //정상 처리
                    //CoFAS_DevExpressManager.ShowInformationMessage("삭제 되었습니다.");
                    strFTP_PATH = string.Format(@"{0}{1}/{2}/{3}/", _pFTP_IP_PORT, "USER", "PROGRAM_VIEW", _luWINDOW_NAME.Text.ToString());
                    
                    string qFileName = _pMenuRegisterEntity.XML_FILE_NAME;
                    string qPath = strFTP_PATH;


                    CoFAS_FTPManager.FTPDelete(qFileName, qPath, _pFTP_ID, _pFTP_PW);

                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_DELETE);
                    

                    _pMenuRegisterEntity.CRUD = "R";
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

        #region ○ XML 저장 - Templete_Save()
        private int Templete_Save(string qFileName)
        {
            try
            {
                // return 값
                // 1 : FileName == ""
                // 2 : FTP 연결 확인
                // 0 : 정상

                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                string strFTP_PATH = "";

                if (_pFullName == "") return 1;

                byte[] data = GetFileData(_pFullName);

              

                strFTP_PATH = string.Format(@"{0}{1}/{2}/", _pFTP_IP_PORT, "USER", "PROGRAM_VIEW");

                if (_pMenuRegisterEntity.CRUD == "C" && _pFullName != null) // 저장, 추가 생성
                {
                    //if (CoFAS_FTPManager.FTPUpload_DataofByte_CheckDirectory(qFileName, _pFTP_ID, _pFTP_PW, strFTP_PATH, _pMenuRegisterEntity.WINDOW_NAME, data)) // _pListofManagementEntity.WINDOW_NAME + _pListofManagementEntity.RTN_KEY + _pFileName
                    //CoFAS_FTPManager.FTPUpload_DataofStream_CheckDirectory(pMenuInfoRegisterEntity.TEMPLETE_FILE_NAME, pMenuInfoRegisterEntity.FTP_ID, pMenuInfoRegisterEntity.FTP_PW, strFTP_PATH, pMenuInfoRegisterEntity.WINDOW_NAME, data, pMenuInfoRegisterEntity.TEMPLETE_FILE_NAME_FULL)
                    if (CoFAS_FTPManager.FTPUpload_DataofStream_CheckDirectory(qFileName, _pFTP_ID, _pFTP_PW, strFTP_PATH, _pMenuRegisterEntity.WINDOW_NAME, data,_pFullName)) // _pListofManagementEntity.WINDOW_NAME + _pListofManagementEntity.RTN_KEY + _pFileName
                    {
                        //CoFAS_DevExpressManager.ShowInformationMessage("저장 되었습니다.");
                        //CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                    }
                    else
                    {
                        //CoFAS_DevExpressManager.ShowInformationMessage("FTP 연결을 확인해주세요.");
                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_PLZ_CONNECT_FTP);
                        return 2;
                    }
                }
                else if (_pMenuRegisterEntity.CRUD == "U" || _pFullName == null) // 업데이트
                {
                    //업데이트는, 이전파일명으로 삭제하기
                    //qFileName -> _pFTP_BEFROE_FILENAME
                    //if (CoFAS_FTPManager.FTPDelete(qFileName, strFTP_PATH + _pSheetInfoRegisterEntity.WINDOW_NAME + "/", _pFTP_ID, _pFTP_PW))
                    CoFAS_FTPUtilManager qFTPUtil = new CoFAS_FTPUtilManager(strFTP_PATH + _pMenuRegisterEntity.WINDOW_NAME + "/", _pFTP_ID, _pFTP_PW);

                    if (_pFTP_BEFROE_FILENAME == "") return 1;

                    if (CoFAS_FTPManager.FTPDelete(_pFTP_BEFROE_FILENAME, strFTP_PATH + _pMenuRegisterEntity.WINDOW_NAME + "/", _pFTP_ID, _pFTP_PW))
                    {
                        //if (CoFAS_FTPManager.FTPUpload_DataofByte_CheckDirectory_Encoding(qFileName, _pFTP_ID, _pFTP_PW, strFTP_PATH, _pMenuRegisterEntity.WINDOW_NAME, data, _pFullName)) // _pListofManagementEntity.WINDOW_NAME + _pListofManagementEntity.RTN_KEY + _pFileName
                        if (CoFAS_FTPManager.FTPUpload_DataofStream_CheckDirectory(qFileName, _pFTP_ID, _pFTP_PW, strFTP_PATH, _pMenuRegisterEntity.WINDOW_NAME, data, _pFullName))
                        {
                            //oFAS_DevExpressManager.ShowInformationMessage("수정 되었습니다.");
                            //CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                            _pFTP_BEFROE_FILENAME = "";
                        }

                        else
                        {
                            //CoFAS_DevExpressManager.ShowInformationMessage("FTP 연결을 확인해주세요.");
                            CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_PLZ_CONNECT_FTP);
                            _pFTP_BEFROE_FILENAME = "";
                            return 2;
                        }
                    }
                    //파일이 없는지 체크
                    else if (!qFTPUtil.IsFTPFileExsit(strFTP_PATH + _pMenuRegisterEntity.WINDOW_NAME + "/" + qFileName))
                    {
                        //정상 처리

                        //if (CoFAS_FTPManager.FTPUpload_DataofByte_CheckDirectory_Encoding(qFileName, _pFTP_ID, _pFTP_PW, strFTP_PATH, _pMenuRegisterEntity.WINDOW_NAME, data, _pFullName)) // _pListofManagementEntity.WINDOW_NAME + _pListofManagementEntity.RTN_KEY + _pFileName
                        if (CoFAS_FTPManager.FTPUpload_DataofStream_CheckDirectory(qFileName, _pFTP_ID, _pFTP_PW, strFTP_PATH, _pMenuRegisterEntity.WINDOW_NAME, data, _pFullName)) // _pListofManagementEntity.WINDOW_NAME + _pListofManagementEntity.RTN_KEY + _pFileName
                        {
                            //CoFAS_DevExpressManager.ShowInformationMessage("수정 되었습니다.");
                            //CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                        }
                        else
                        {
                            //CoFAS_DevExpressManager.ShowInformationMessage("FTP 연결을 확인해주세요.");
                            CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_PLZ_CONNECT_FTP);
                            return 2;
                        }
                    }
                    else
                    {
                        //CoFAS_DevExpressManager.ShowInformationMessage("FTP 연결을 확인해주세요.");
                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_PLZ_CONNECT_FTP);
                        return 2;
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
            return 0;
        }
        #endregion

        #region ○ 메인 그리드 신규로우 생성시 이벤트 생성 - _gdSUB_VIEW_InitNewRow(object sender, InitNewRowEventArgs e)
        private void _gdSUB_VIEW_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns["USE_YN"], "Y");
        }
        #endregion

        #region ○INOU_TYPE이 변하면 INOUT_CODE같이 변하게
        private void _luP_MENU_NO_ValueChanged(object sender, EventArgs e)
        {
            //로우 클릭햇을경우엔 그냥 지나가기
            //신규일경우만 
            if (!_pRowClick_chk)
                _luMODULE.SetValueByDisplayName(_luP_MENU_NO.GetDisplayName());
            //SetValueByDisplayName
            return;
        }
        #endregion


        Byte[] GetFileData(string filename)
        {
            using (var sr = new StreamReader(filename))
            {
                return ASCIIEncoding.ASCII.GetBytes(sr.ReadToEnd());
            }
        }
    }


}

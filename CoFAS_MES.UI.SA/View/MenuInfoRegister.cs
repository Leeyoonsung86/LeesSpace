using System;
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
using CoFAS_MES.CORE.UserForm;

using CoFAS_MES.UI.SA.Business;
using CoFAS_MES.UI.SA.Entity;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;
using DevExpress.XtraEditors;

namespace CoFAS_MES.UI.SA
{
    public partial class MenuInfoRegister : frmBaseNone
    {
        private string _pCORP_CODE = string.Empty;       // 회사코드       
        private string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        private string _pUSER_NAME = string.Empty;       // 사용자이름
        private string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어
        private string _pWINDOW_NAME = string.Empty;     // 화면 명칭
        public string _pMENU_NAME = string.Empty;       // 메뉴 명칭
        private string _pFONT_TYPE = string.Empty;       // 시스템 폰트 타입 설정
        private int _pFONT_SIZE = 9;                     // 시스템 폰트 사이즈 설정 기본 9
        private Font _pFONT_SETTING = null;              // 시스템 폰트 설정
        private string _pFTP_ID = string.Empty;          // FTP ID 정보
        private string _pFTP_IP_PORT = string.Empty;     // FTP SERVER IP 정보
        private string _pFTP_PW = string.Empty;          //FTP PW 정보

        private string _pUSER_GRANT = string.Empty; // 사용자 권한

        private string _pLocation_Code = string.Empty;  // 저장/수정 후 로케이션 위치 저장
        private bool _pLocation_YN = true;              // 저장위치 사용여부

        private MenuInfoRegisterEntity _pMenuInfoRegisterEntity = null; // 엔티티 생성

        private CoFAS_DevGridManager _TempGridView = null;

        private DataTable _dtList = null; //조회 데이터 리스트

        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용

        private string _pFileName = "";                                 //local 파일이름   //ofd로 받아서 넣기 safe~
        private string _pFullName = "";                                 //localfile 파일명 포함 전체 경로     
        private byte[] _pXmlfile = null;

        private bool _pRowClick_chk = false;

        private string _pFTP_BEFROE_FILENAME = string.Empty;    //업로드 파일을 변경할경우, 이전파일명 가지고 있고 이전파일명으로 삭제하기

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

        public MenuInfoRegister()
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
                _gdMAIN_VIEW.RowCellClick -= _gdMAIN_VIEW_RowCellClick;
                _gdSUB_VIEW.InitNewRow -= _gdSUB_VIEW_InitNewRow;

                _TempGridView._OnOpenButton -= _TempGridView__OnOpenButton;

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
                //dxWaitViewManager.CloseWaitForm();
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
                _pMSG_CHECK_VALID_ITEM = MainForm.MessageEntity.MSG_CHECK_VALID_ITEM;
                _pMSG_RESET_COMPLETE = MainForm.MessageEntity.MSG_RESET_COMPLETE;

                //메뉴 화면 엔티티 설정
                _pMenuInfoRegisterEntity = new MenuInfoRegisterEntity();
                _pMenuInfoRegisterEntity.USER_CODE = _pUSER_CODE;
                _pMenuInfoRegisterEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;

                _pMenuInfoRegisterEntity.FTP_IP_PORT = _pFTP_IP_PORT;
                _pMenuInfoRegisterEntity.FTP_ID = _pFTP_ID;
                _pMenuInfoRegisterEntity.FTP_PW = _pFTP_PW;

                //화면 설정 언어 & 명칭 변경.
                DataTable dtLanguage = new LanguageBusiness().Language_Info(_pWINDOW_NAME, _pLANGUAGE_TYPE);

                if (dtLanguage != null && dtLanguage.Rows.Count > 0)
                {
                    CoFAS_ControlManager.Language_Info(dtLanguage, this);
                }


                //그리드 설정
                InitializeGrid();

                //컨트롤러 설정
                InitializeControl();
                 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                _pMenuInfoRegisterEntity.CRUD = "R";
                _pMenuInfoRegisterEntity.MODULE = _luSYSTEM_MODULE.GetValue();
                _pMenuInfoRegisterEntity.USE_YN = _luT_USE_YN.GetValue();
                MainFind_DisplayData();

                _pMenuInfoRegisterEntity.CRUD = "";
                _pMenuInfoRegisterEntity.MENU_CODE = "";
                SubDetailFind_DisplayData();

                if (_pFirstYN)
                {
                    //컨트롤러 별 추가 이벤트 생성은 화면 설정 마지막에 진행
                    _gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick;
                    _gdSUB_VIEW.InitNewRow += _gdSUB_VIEW_InitNewRow;

                    //그리드 버튼추가 시 클릭 이벤트 처리 
                    _TempGridView._OnOpenButton += _TempGridView__OnOpenButton;

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
                    _TempGridView = new CoFAS_DevGridManager();

                    _gdMAIN_VIEW = _TempGridView.Grid_Setting(_gdMAIN, _gdMAIN_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdMAIN.Name.ToString()));

                    _gdSUB_VIEW = _TempGridView.Grid_Setting(_gdSUB, _gdSUB_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdSUB.Name.ToString()));
                }
                
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }


        #endregion

        #region ○ 컨트롤 초기화 - InitializeControl()

        //Bool 상단 초기화 true,하단만 초기화 false
        private void InitializeControl()
        {
            try
            {
                //좌측 룩업에디트 설정

                _luSYSTEM_MODULE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "MODULE_MENU", "", "", "").Tables[0], 0, 0, "", false);
                _luT_USE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "USE_YN", "", "", "").Tables[0], 0, 1, "",true);
                
                //메인 설정
                _luMODULE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "MODULE_MENU", "", "", "").Tables[0], 0, 0, "", false);
                _luP_MENU_CODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "MODULE_P", "", "", "").Tables[0], 0, 0, "", false);


                _luICONCSS.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "ICONCSS", "", "", "").Tables[0], 0, 0, "",false);

                _luUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "USE_YN", "", "", "").Tables[0], 0, 0, "",false);

                //데이터 영역
                _luMENU_CODE.Text = "";
                _luMENU_CODE.ReadOnly = true;

                _luWINDOW_NAME.Text = "";

                _luMENU_NAME.Text = "";

                _luDSP_SORT.Value = 0;

                _luREMARK.Text = "";

                // 컨트롤러 유효성 검증 처리 기본 컨트롤러 에서만 사용 
                dxValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
                dxValidationProvider.Validate();

                if (_pFirstYN)
                {

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

        // 추가 이벤트 생성
        #region ○ 메인 그리드 로우 선택 이벤트 생성 - _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        private void _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;

                _pMenuInfoRegisterEntity.CRUD = "R";
                _pMenuInfoRegisterEntity.MENU_CODE = gv.GetFocusedRowCellValue("MENU_CODE").ToString();
                _pMenuInfoRegisterEntity.MODULE = gv.GetFocusedRowCellValue("MODULE").ToString(); ;

                SubFind_DisplayData();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion

        #region ○ 파일 버튼 처리 엑셀파일 가져오기, 내려받기, 저장하기 기능
        private void _TempGridView__OnOpenButton(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Caption.ToString())
            {
                case "TEMPLETE_FILE_NAME": //해당 그리드에 필드명 // 2개 이상 그리드의 버튼 항목들은 버튼 타입에 필드 명칭이 모두 다르게 설정 되어야됨.

                    switch (e.Button.Index)
                    {
                        case 0: //오픈
                            try
                            {
                                OpenFileDialog ofd = new OpenFileDialog();
                                ofd.DefaultExt = "*";
                                ofd.Filter = "XML(*.xml)|*.xml|ALL(*.*)|*.*";

                                _pFTP_BEFROE_FILENAME = _gdSUB_VIEW.GetFocusedRowCellValue("TEMPLETE_FILE_NAME").ToString();

                                if (ofd.ShowDialog() == DialogResult.OK)
                                {

                                    _pFullName = ofd.FileName;    // FTP업로드 확인용, 새로운 파일을 올렸을 때만 데이터 입력됨
                                    _pFileName = ofd.SafeFileName; // 

                                    _gdSUB_VIEW.SetRowCellValue(_gdSUB_VIEW.FocusedRowHandle, _gdSUB_VIEW.Columns["TEMPLETE_FILE_NAME_FULL"], _pFullName);
                                    _gdSUB_VIEW.SetRowCellValue(_gdSUB_VIEW.FocusedRowHandle, _gdSUB_VIEW.Columns["TEMPLETE_FILE_NAME"], _pFileName);
                                }
                            }
                            catch (ExceptionManager pExceptionManager)
                            {
                                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
                            }
                            break;
                        case 1:
                            //다운로드
                            // DB에서 local로 다운로드
                            if (_gdSUB_VIEW.IsNewItemRow(_gdSUB_VIEW.FocusedRowHandle))
                            {
                                //CoFAS_DevExpressManager.ShowInformationMessage("신규등록 부분입니다.");
                                // CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_NEW_REG_GUBN);
                            }
                            else
                            {
                                //메뉴 선택이 되어 있는 상황
                                //그 중에서도 db에 파일이 저장이 안 된 것이면 DB에 저장된 파일이 아님을 말해줘야 함.

                                if (_gdSUB_VIEW.GetRowCellValue(_gdSUB_VIEW.FocusedRowHandle, "TEMPLETE_FILE_NAME").ToString() == "")
                                {
                                    //조회된 _gdSUB에 XML_FILE_NAME이 없으면, db에 저장된 파일이 없다고 메세지 띄우기 
                                    //CoFAS_DevExpressManager.ShowInformationMessage("DB에 저장된 파일이 없습니다.");
                                    //CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_NO_SELETED_ITEM_OR_NO_SAVE + "\n" + _pMSG_REG_DATA);
                                }
                                else
                                {
                                    //조회된 _gdSUB에 XML_FILE_NAME이 있으면, Templete_Download() 실행
                                    _pMenuInfoRegisterEntity.TEMPLETE_FILE_NAME = _gdSUB_VIEW.GetRowCellValue(_gdSUB_VIEW.FocusedRowHandle, "TEMPLETE_FILE_NAME").ToString();

                                    File_Download();

                                    //DisplayMessage(string.Format("{0}", _pMSG_DOWNLOAD_COMPLETE));

                                }
                            }
                            break;

                        case 2:
                            //삭제


                            if (_gdSUB_VIEW.IsNewItemRow(_gdSUB_VIEW.FocusedRowHandle))
                            {
                                CoFAS_DevExpressManager.ShowInformationMessage("신규등록 부분입니다.");
                                //CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_NEW_REG_GUBN);

                            }
                            else
                            {
                                //메뉴 선택이 되어 있는 상황
                                //그 중에서도 db에 파일이 저장이 안 된 것이면 DB에 저장된 파일이 아님을 말해줘야 함.

                                if (_gdSUB_VIEW.GetRowCellValue(_gdSUB_VIEW.FocusedRowHandle, "TEMPLETE_FILE_NAME").ToString() == "")
                                {
                                    //조회된 _gdSUB에 XML_FILE_NAME이 없으면, db에 저장된 파일이 없다고 메세지 띄우기 
                                    CoFAS_DevExpressManager.ShowInformationMessage("DB에 저장된 파일이 없습니다.");
                                    //CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_NO_SELETED_ITEM_OR_NO_SAVE + "\n" + _pMSG_REG_DATA);


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

                                        File_Delete();

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

        #region ○ 메인 그리드 신규로우 생성시 이벤트 생성 - _gdSUB_VIEW_InitNewRow(object sender, InitNewRowEventArgs e)
        private void _gdSUB_VIEW_InitNewRow(object sender, InitNewRowEventArgs e)
        {
           GridView view = sender as GridView;

            view.SetRowCellValue(e.RowHandle, view.Columns["USE_YN"], "Y");
        }
        #endregion

        // 메인 버튼 처리영역
        #region ○ 조회 버튼 클릭시 처리하기
        private void Form_SearchButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _pMenuInfoRegisterEntity.CRUD = "R";
                _pMenuInfoRegisterEntity.USE_YN = _luT_USE_YN.GetValue();

                MainFind_DisplayData();
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

                if (CheckInputData())
                {
                    return;
                }

                //확인
                if (_luMENU_CODE.Text.ToString().Length > 0)
                {
                    _pMenuInfoRegisterEntity.CRUD = "U";
                }
                else
                {
                    _pMenuInfoRegisterEntity.CRUD = "C";
                }


                _pMenuInfoRegisterEntity.MENU_CODE = _luMENU_CODE.Text.ToString();
                _pMenuInfoRegisterEntity.MENU_NAME = _luMENU_NAME.Text.ToString();
                _pMenuInfoRegisterEntity.WINDOW_NAME = _luWINDOW_NAME.Text.ToString();

                _pMenuInfoRegisterEntity.ICONCSS = _luICONCSS.GetValue();

                _pMenuInfoRegisterEntity.MODULE = _luMODULE.GetValue(); ;
                _pMenuInfoRegisterEntity.P_MENU_CODE = _luP_MENU_CODE.GetValue();
               
                _pMenuInfoRegisterEntity.DSP_SORT = _luDSP_SORT.Value.ToString();
               
                _pMenuInfoRegisterEntity.USE_YN = _luUSE_YN.GetValue();

                _pMenuInfoRegisterEntity.REMARK = _luREMARK.Text.ToString();

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

                _luMENU_CODE.Text = "";
                _luMENU_NAME.Text = "";
                _luWINDOW_NAME.Text = "";

                _luMODULE.ItemIndex = 0;
                _luP_MENU_CODE.ItemIndex = 0;

                _luDSP_SORT.Value = 0;
                _luUSE_YN.ItemIndex = 0;

                _luREMARK.Text = "";

                _pMenuInfoRegisterEntity.CRUD = "R";
                _pMenuInfoRegisterEntity.MODULE = _luSYSTEM_MODULE.GetValue();
                _pMenuInfoRegisterEntity.USE_YN = _luT_USE_YN.GetValue();
                MainFind_DisplayData();

                _pMenuInfoRegisterEntity.CRUD = "";
                _pMenuInfoRegisterEntity.MENU_CODE = "";
                SubDetailFind_DisplayData();

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

                _dtList = new MenuInfoRegisterBusiness().MenuInfoRegister_Info_left(_pMenuInfoRegisterEntity);

                if (_pMenuInfoRegisterEntity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pMenuInfoRegisterEntity.CRUD == ""))
                {

                    _TempGridView.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩

                    if (_pLocation_Code != "" && _pLocation_YN)
                    {
                        int rowHandle = _gdMAIN_VIEW.LocateByValue("MENU_CODE", Convert.ToInt32(_pLocation_Code));
                        if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                            _gdMAIN_VIEW.FocusedRowHandle = rowHandle;

                        _pLocation_Code = "";
                    }


                }
                else
                {
                    _TempGridView.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList);
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

                _dtList = new MenuInfoRegisterBusiness().MenuInfoRegister_Info_Mst(_pMenuInfoRegisterEntity);

                if (_dtList != null && _dtList.Rows.Count > 0)
                {
                    CoFAS_ControlManager.Controls_Binding(_dtList, false, this);

                    SubDetailFind_DisplayData();
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

        #region ○ 서브 템블릿 조회 - SubDetailFind_DisplayData()

        private void SubDetailFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _dtList = new MenuInfoRegisterBusiness().MenuInfoRegister_Info_Sub(_pMenuInfoRegisterEntity);

                if (_pMenuInfoRegisterEntity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pMenuInfoRegisterEntity.CRUD == ""))
                {
                    _TempGridView.BindGridControl(_gdSUB, _gdSUB_VIEW, _dtList);
                }
                else
                {
                    _TempGridView.BindGridControl(_gdSUB, _gdSUB_VIEW, _dtList);
                    DisplayMessage(_pMSG_SEARCH_EMPT);
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

        #region ○ 필수값 데이터 확인 - CheckInputData()

        /// <summary>
        /// 필수값 데이터 확인
        /// </summary>
        /// <returns>입력 데이터 조사 결과 (정상:false 에러:true)</returns>
        private bool CheckInputData()
        {
            bool pErrorAllYN = false;
            string pCls = string.Empty;
            string pErrName = string.Empty;

            try
            {

                if (_luMENU_NAME.Text.Equals(""))
                {
                    pErrName = pErrName + _lciMENU_NAME.Text.ToString() + "/";
                }
                if (_luWINDOW_NAME.Text.Equals(""))
                {
                    pErrName = pErrName + _lciWINDOW_NAME.Text.ToString() + " / ";
                }

                if (_luMODULE.GetValue().Equals(""))
                {
                    pErrName = pErrName + _lciMODULE.Text.ToString() + " / ";
                }
                
                if (_luP_MENU_CODE.GetValue().Equals(""))
                {
                    pErrName = pErrName + _lciP_MENU_CODE.Text.ToString() + " / ";
                }

                if (_luDSP_SORT.Value.ToString().Equals(""))
                {
                    pErrName = pErrName + _lciDSP_SORT.Text.ToString() + " / ";
                }
                if (_luICONCSS.GetValue().Equals(""))
                {
                    pErrName = pErrName + _lciICONCSS.Text.ToString() + " / ";
                }


                if (pErrName != "")
                {
                    pErrorAllYN = true;

                    CoFAS_DevExpressManager.ShowInformationMessage(pErrName + " " + _pMSG_CHECK_VALID_ITEM);

                    DisplayMessage(_pMSG_CHECK_VALID_ITEM);

                }
            }
            catch (Exception pException)
            {
                pErrorAllYN = true;
                CoFAS_DevExpressManager.ShowErrorMessage(pException);
            }
            return pErrorAllYN;
        }

        #endregion

        #region ○ 저장 - InputData_Save(DataTable dtSave)

        private void InputData_Save(DataTable dtSave)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                bool isError = false;

                isError = new MenuInfoRegisterBusiness().MenuInfoRegister_Info_Save(_pMenuInfoRegisterEntity, dtSave);

                if (isError)
                {
                    //오류 발생.
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR + "\n" + _pMSG_CHECK_VALID_ITEM);
                }
                else
                {
                    //정상 처리
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);

                    // 화면 갱신
                    _pMenuInfoRegisterEntity.CRUD = "R";
                    _pMenuInfoRegisterEntity.MENU_CODE = _pMenuInfoRegisterEntity.RTN_KEY;
                    _pMenuInfoRegisterEntity.MODULE = _luMODULE.GetValue();

                    MainFind_DisplayData();

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

        #region ○ 파일 다운로드 - File_Download()

        private void File_Download()
        {
            try
            {
                string strFTP_PATH = "";

                if (_pMenuInfoRegisterEntity.CRUD == "") _dtList.Rows.Clear();

                if (_gdSUB_VIEW.FocusedValue.ToString() == "") return;

                _pMenuInfoRegisterEntity.TEMPLETE_FILE_NAME = _gdSUB_VIEW.FocusedValue.ToString();

                //ftp에서 local로 다운로드 

                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.InitialDirectory = @"C:\";
                saveFile.Filter = "ALL(*.*)|*.*";
                saveFile.FileName = _pMenuInfoRegisterEntity.TEMPLETE_FILE_NAME;

                strFTP_PATH = string.Format(@"{0}{1}/{2}/", _pMenuInfoRegisterEntity.FTP_IP_PORT, "PROGRAM_VIEW", _luMENU_CODE.Text.ToString());

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    string _pDOWNLOAD_PATH = saveFile.FileName;

                    CoFAS_FTPManager.FTPDownLoad(strFTP_PATH, (saveFile.FileName.ToString().Split('\\')).Last(), _pFTP_ID, _pFTP_PW, _pDOWNLOAD_PATH, false);

                    //DisplayMessage("선택한 파일이 지정한 폴더(" + _pFTP_DOWNLOAD_PATH + ")에 저장되었습니다.");
                    DisplayMessage(_pMSG_SAVE + "(path:" + _pDOWNLOAD_PATH + ")");
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
        #region ○ 파일 삭제 - File_Delete()

        private void File_Delete()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                bool isError = false;
  
               _pMenuInfoRegisterEntity.CRUD = "U";
               _pMenuInfoRegisterEntity.MENU_CODE = _gdSUB_VIEW.GetFocusedRowCellValue("MENU_CODE").ToString();
               _pMenuInfoRegisterEntity.TEMPLETE_SEQ = _gdSUB_VIEW.GetFocusedRowCellValue("TEMPLETE_SEQ").ToString();
               _pMenuInfoRegisterEntity.TEMPLETE_NAME = _gdSUB_VIEW.GetFocusedRowCellValue("TEMPLETE_NAME").ToString();
               _pMenuInfoRegisterEntity.TEMPLETE_FILE_NAME = "";
               _pMenuInfoRegisterEntity.REMARK = _gdSUB_VIEW.GetFocusedRowCellValue("REMARK").ToString();
                _pMenuInfoRegisterEntity.USE_YN = _gdSUB_VIEW.GetFocusedRowCellValue("USE_YN").ToString();

                _pMenuInfoRegisterEntity.TEMPLETE_BEFROE_FILE_NAME = _gdSUB_VIEW.GetFocusedRowCellValue("TEMPLETE_BEFROE_FILE_NAME").ToString();

                isError = new MenuInfoRegisterBusiness().MenuInfoRegister_Info_Delete(_pMenuInfoRegisterEntity);

                string strFTP_PATH = "";

                if (isError)
                {
                    //오류 발생.
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_DELETE_ERROR);
                }
                else
                {
                    //정상 처리
                    strFTP_PATH = string.Format(@"{0}{1}/{2}/", _pMenuInfoRegisterEntity.FTP_IP_PORT, "PROGRAM_VIEW", _pMenuInfoRegisterEntity.MENU_CODE);

                    string qFileName = _pMenuInfoRegisterEntity.TEMPLETE_BEFROE_FILE_NAME;
                    string qPath = strFTP_PATH;

                    CoFAS_FTPManager.FTPDelete(qFileName, qPath, _pFTP_ID, _pFTP_PW);

                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_DELETE);

                    _pMenuInfoRegisterEntity.CRUD = "R";
                    _pMenuInfoRegisterEntity.MENU_CODE = _luMENU_CODE.Text.ToString();

                    SubDetailFind_DisplayData();
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
        private void _luSYSTEM_MODULE_ValueChanged(object sender, EventArgs e)
        {
            _pMenuInfoRegisterEntity.CRUD = "R";
            _pMenuInfoRegisterEntity.MODULE = _luSYSTEM_MODULE.GetValue();
            _pMenuInfoRegisterEntity.USE_YN = _luT_USE_YN.GetValue();
            MainFind_DisplayData();
        }

        private void _luT_USE_YN_ValueChanged(object sender, EventArgs e)
        {
            _pMenuInfoRegisterEntity.CRUD = "R";
            _pMenuInfoRegisterEntity.MODULE = _luSYSTEM_MODULE.GetValue();
            _pMenuInfoRegisterEntity.USE_YN = _luT_USE_YN.GetValue();
            MainFind_DisplayData();
        }
    }
}

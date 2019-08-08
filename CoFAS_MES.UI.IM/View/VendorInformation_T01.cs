using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

using CoFAS_MES.CORE.UserForm;

using CoFAS_MES.CORE.BaseForm;
using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.Function;
using CoFAS_MES.UI.IM.Business;
using CoFAS_MES.UI.IM.Entity;
using DevExpress.XtraGrid.Views.Grid;

namespace CoFAS_MES.UI.IM
{
    public partial class VendorInformation_T01 : frmBaseNone
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

        private VendorInformation_T01Entity _pVendorInformation_T01Entity = null; // 엔티티 생성

        OpenFileDialog ofd;

        // 코에버 frp 관련 변수
        private string _pFileName = "";                                 //local 파일이름   //ofd로 받아서 넣기 safe~
        private string _pFullName = "";                                 //localfile 파일명 포함 전체 경로        
        private string _pFTP_DOWNLOAD_PATH = ""; // ftp download에 사용

        private string _pFTP_ID = string.Empty;          // FTP ID 정보
        private string _pFTP_PATH = string.Empty;     // FTP SERVER IP 정보
        private string _pFTP_PW = string.Empty;          //FTP PW 정보
        private string _pLocation_Code = string.Empty;  // 저장/수정 후 로케이션 위치 저장
        private bool _pLocation_YN = true;              // 저장위치 사용여부


        private DataTable _dtList = null; //조회 데이터 리스트
        private DataTable _chkList = null; //사업자등록번호 체크

        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용
        private bool _pImageDelete_YN = false;          //이미지가 휴지통으로 FTP에 삭제를 시키면 DB도 업뎃

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


        public VendorInformation_T01()
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
                //else
                //{
                //    pFormClosingEventArgs.Cancel = true;
                //}
               // pFormClosingEventArgs.Cancel = false;
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
                _gdMAIN_VIEW.RowCellClick -= _gdMAIN_VIEW_RowCellClick;

                //_luVEND_FILENAME._OnOpenClick -= _luVEND_FILENAME__OnOpenClick;
                //_luVEND_FILENAME._OnDownloadClick -= _luVEND_FILENAME__OnDownloadClick;
                //_luVEND_FILENAME._OnViewClick -= _luVEND_FILENAME__OnViewClick;
                _luT_VEND._OnOpenClick -= _luT_VEND_OnOpenClick;
                _gdMAIN_VIEW.FocusedRowChanged -= new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(_gdMAIN_VIEW_RowChange);

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


                _pImageDelete_YN = false;
                _pFTP_ID = MainForm.UserEntity.FTP_ID;
                _pFTP_PATH = MainForm.UserEntity.FTP_IP_PORT; //string.Format(@"{0}/{1}/", MainForm.UserEntity.FTP_IP_PORT, "test"); //발주서는 ORDER_FORM // 화면조회용 PROGRAM_VIEW
                _pFTP_PW = MainForm.UserEntity.FTP_PW;


                //메뉴 화면 엔티티 설정
                _pVendorInformation_T01Entity = new VendorInformation_T01Entity();
                //_pVendorInformationEntity.CORP_CODE = _pCORP_CODE;
                _pVendorInformation_T01Entity.USER_CODE = _pUSER_CODE;
                _pVendorInformation_T01Entity.CRUD = "C";
                _pVendorInformation_T01Entity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;

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
                _pVendorInformation_T01Entity.CRUD = "";
               

                    MainFind_DisplayData(); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.


                SubFind_DisplayData(""); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.


                if (_pFirstYN)
                {
                    //컨트롤러 별 추가 이벤트 생성은 화면 설정 마지막에 진행
                    _gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick;
                    //_luVEND_FILENAME._OnOpenClick += _luVEND_FILENAME__OnOpenClick;
                    //_luVEND_FILENAME._OnDownloadClick += _luVEND_FILENAME__OnDownloadClick;
                    //_luVEND_FILENAME._OnViewClick += _luVEND_FILENAME__OnViewClick;
                    _luT_VEND._OnOpenClick += _luT_VEND_OnOpenClick;
                    _gdMAIN_VIEW.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(_gdMAIN_VIEW_RowChange);
                    _pFirstYN = false;
                }
                _gdSUB_VIEW.InitNewRow += _gdSUB_VIEW_InitNewRow;
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        private void _luVEND_FILENAME__OnViewClick(object sender, EventArgs e)
        {
            //try
            //{
            //    if (_luVEND_FILENAME.Text.IndexOf("*NoSave*") > -1 || _luVEND_FILENAME.Text.Trim().Length < 4)
            //    {
            //        //CoFAS_DevExpressManager.ShowInformationMessage("저장하지 않아서 볼 수 없습니다.");
            //        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_NOT_DISPLAY_NOT_SAVE);
                    
            //    }
            //    else
            //    {
            //        string strFTP_PATH = string.Format(@"{0}{1}/%2F/{2}/{3}/", _pFTP_PATH, "ITEM", "ITEM_IMAGE", _pWINDOW_NAME);

            //        frmImageView.CORP_CDDE = _pCORP_CODE;
            //        frmImageView.USER_CODE = _pUSER_CODE;
            //        frmImageView.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
            //        frmImageView.FONT_TYPE = _pFONT_SETTING;
            //        frmImageView.IMAGE_DATA = Image.FromStream(CoFAS_FTPManager.FTPImage(strFTP_PATH, _luVEND_FILENAME.Text, _pFTP_ID, _pFTP_PW));

            //        frmImageView xfrmImageView = new CORE.UserForm.frmImageView(); //유저컨트롤러 설정 부분

            //        xfrmImageView.ShowDialog();

            //        xfrmImageView.Dispose();
            //    }
            //}
            //    catch(Exception ex)
            //    {
            //    //    CoFAS_DevExpressManager.ShowInformationMessage("저장된 파일에 문제가 발생해 볼수 없습니다.");
            //    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_NOT_DISPLAY_ERROR);
                
            //    }
        }
        

        private void _luVEND_FILENAME__OnDownloadClick(object sender, EventArgs e)
        {
            //string strFTP_PATH = "";

            ////ftp에서 local로 다운로드 
            //if (_luVEND_FILENAME.Text != null && _luVEND_FILENAME.Text != "")
            //{
            //    SaveFileDialog saveFile = new SaveFileDialog();
            //    saveFile.InitialDirectory = @"C:\";
            //    saveFile.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png;)|*.jpg; *.jpeg; *.gif; *.bmp; *.png; | ALL(*.*) | *.*";
            //    saveFile.FileName = _luVEND_FILENAME.Text.ToString();

            //    //strFTP_PATH = string.Format(@"{0}{1}/%2F/{2}/", _pFTP_PATH, "COMPANY", "CORP_MST");
            //    strFTP_PATH = string.Format(@"{0}{1}/%2F/{2}/{3}/", _pFTP_PATH, "VEND", "VEND_IMAGE",_pVendorInformationEntity.VEND_CODE);
            //    if (saveFile.ShowDialog() == DialogResult.OK)
            //    {
            //        _pFTP_DOWNLOAD_PATH = saveFile.FileName;

            //        CoFAS_FTPManager.FTPDownLoad(strFTP_PATH, _luVEND_FILENAME.Text, _pFTP_ID, _pFTP_PW, _pFTP_DOWNLOAD_PATH);

            //        //DisplayMessage("선택한 파일이 지정한 폴더(" + _pFTP_DOWNLOAD_PATH + ")에 저장되었습니다.");
            //        DisplayMessage(_pMSG_SAVE+"(path:" + _pFTP_DOWNLOAD_PATH + ")");
            //    }
            //}
            //else
            //{
            //    CoFAS_DevExpressManager.ShowErrorMessage("선택한 파일이 없습니다");
            //}
        }

        private void _luVEND_FILENAME__OnOpenClick(object sender, EventArgs e)
        {
            //try
            //{
            //    ofd = new OpenFileDialog();

            //    ofd.DefaultExt = "*";
            //    ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png;)|*.jpg; *.jpeg; *.gif; *.bmp; *.png; | ALL(*.*) | *.*";// 이미지용
            //                                                                                                                         //ofd.Filter = "Pdf Files(*.pdf;) | *.pdf; | ALL(*.*) | *.*"; //pdf 용 테스트중
            //    if (ofd.ShowDialog() == DialogResult.OK)
            //    {
            //        _luVEND_FILENAME.Text = "*NoSave* " + ofd.SafeFileName;
            //    }
            //}
            //catch (ExceptionManager pExceptionManager)
            //{
            //    CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            //}
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
                    _gdMAIN_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdMAIN, _gdMAIN_VIEW, _pFONT_SETTING,_pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdMAIN.Name.ToString()));
                }

                _gdSUB_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB, _gdSUB_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdSUB.Name.ToString()));
                //DataGridViewColumn tel = _gdSUB_VIEW.Columns["VEND_TEL"];
                //GridView AA = _gdSUB_VIEW.Columns["VEND_TEL"];

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

                _luT_USE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "COMMON_CODE", "CD99", "", "").Tables[0], 0, 0, "", true);
                _luT_USE_YN.ItemIndex = 1;

                _luVEND_CODE.Text = "";
                _luVEND_CODE.ReadOnly = true;
                _luVEND_EIN.ReadOnly = false;
                _luVEND_EIN.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
                _luVEND_EIN.EditMask = "\\d\\d\\d-\\d\\d-\\d\\d\\d\\d\\d";
                _luVEND_EIN.UseMaskAsDisplayFormat = true;
                _luVEND_EIN.Properties.MaxLength = 14;
                _luVEND_SSN.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
                _luVEND_SSN.EditMask = "\\d\\d\\d\\d\\d\\d-\\d\\d\\d\\d\\d\\d\\d\\d";
                _luVEND_SSN.UseMaskAsDisplayFormat = true;
                _luVEND_SSN.Properties.MaxLength = 15;
                //_luVEND_EIN.Text = "";
                _luVEND_TYPE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "COMMON_CODE", "CD03", "", "").Tables[0], 0, 0, "");
                _luVEND_TYPE.ItemIndex = 0;
                _luVEND_NAME.Text = "";
                _luVEND_ENG_NAME.Text = "";
                _luVEND_CEO_NAME.Text = "";
                _luVEND_BUSINESS_OPENDATE.Text = "";
                //_luVEND_SSN.Text = "";
                _luVEND_ADDRESS_1.Text = "";
                _luVEND_ADDRESS_2.Text = "";
                _luVEND_BUSINESS.Text = "";
                _luVEND_BUSINESS_TYPE.Text = "";
                _luVEND_TEL.Text = "";
                _luVEND_TEL.Properties.MaxLength = 13;
                _luVEND_FAX.Text = "";
                _luVEND_FAX.Properties.MaxLength = 13;
                _luVEND_MAIL.Text = "";
                _luVEND_MAIL.Properties.MaxLength = 50;
                //_luVEND_FILENAME.Text = "";

                _luUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "COMMON_CODE", "CD99", "", "").Tables[0], 0, 0, "");
                _luUSE_YN.ItemIndex = 0;
                _luREMARK.Text = "";
                _luVEND_TEL.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
                _luVEND_TEL.EditMask = "\\d{1,3}-\\d{3,4}-\\d{4}";
                _luVEND_TEL.UseMaskAsDisplayFormat = true;
                _luVEND_FAX.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
                _luVEND_FAX.EditMask = "\\d{1,3}-\\d{3,4}-\\d{4}";
                _luVEND_FAX.UseMaskAsDisplayFormat = true;
                // 컨트롤러 유효성 검증 처리
                dxValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
                dxValidationProvider.Validate();

                //dxValidationProvider.SetValidationRule(_luUSER_MAIL, NotEmptyValidationRule);
                // 컨트롤러 유효성 검증 처리

                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                if (_pFirstYN)
                {
                    //조회조건 영역 
                    //_luT_VEND_CODE.Text = "";
                    //_luT_VEND_NAME.Text = "";
                    _luT_VEND.CodeText = "";
                    _luT_VEND.NameText = "";


                    //데이터 영역
                    _luT_VEND_EIN.Text = "";
                    _luT_VEND_TYPE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "COMMON_CODE", "CD03", "", "").Tables[0], 0, 0, "", true);
                    _luT_VEND_TYPE.ItemIndex = 0;
                }
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

        #region ○ 바인딩 메인뷰 초기화 - InitializeView()

        private void InitializeView()
        {
            try
            {

                _luVEND_CODE.Text = "";
                _luVEND_CODE.ReadOnly = true;

                _luVEND_EIN.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
                _luVEND_EIN.EditMask = "\\d\\d\\d-\\d\\d-\\d\\d\\d\\d\\d";
                _luVEND_EIN.UseMaskAsDisplayFormat = true;
                _luVEND_EIN.Properties.MaxLength = 14;
                _luVEND_SSN.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
                _luVEND_SSN.EditMask = "\\d\\d\\d\\d\\d\\d-\\d\\d\\d\\d\\d\\d\\d\\d";
                _luVEND_SSN.UseMaskAsDisplayFormat = true;
                _luVEND_SSN.Properties.MaxLength = 15;
                _luVEND_TEL.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
                _luVEND_TEL.EditMask = "\\d{1,3}-\\d{3,4}-\\d{4}";
                _luVEND_TEL.UseMaskAsDisplayFormat = true;
                _luVEND_FAX.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
                _luVEND_FAX.EditMask = "\\d{1,3}-\\d{3,4}-\\d{4}";
                _luVEND_FAX.UseMaskAsDisplayFormat = true;
                //_luVEND_EIN.Text = "";
                _luVEND_TYPE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "COMMON_CODE", "CD03", "", "").Tables[0], 0, 0, "");
                _luVEND_TYPE.ItemIndex = 0;
                _luVEND_NAME.Text = "";
                _luVEND_ENG_NAME.Text = "";
                _luVEND_CEO_NAME.Text = "";
                _luVEND_BUSINESS_OPENDATE.Text = "";
                //_luVEND_SSN.Text = "";
                _luVEND_ADDRESS_1.Text = "";
                _luVEND_ADDRESS_2.Text = "";
                _luVEND_BUSINESS.Text = "";
                _luVEND_BUSINESS_TYPE.Text = "";
                _luVEND_TEL.Text = "";
                _luVEND_TEL.Properties.MaxLength = 13;
                _luVEND_FAX.Text = "";
                _luVEND_FAX.Properties.MaxLength = 13;
                _luVEND_MAIL.Text = "";
                _luVEND_MAIL.Properties.MaxLength = 50;
                //_luVEND_FILENAME.Text = "";
                //_luT_VEND_EIN.Text = "";

                _luUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "COMMON_CODE", "CD99", "", "").Tables[0], 0, 0, "");
                _luUSE_YN.ItemIndex = 0;
                _luREMARK.Text = "";

                // 컨트롤러 유효성 검증 처리
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
                GridView gv = sender as GridView;

                CoFAS_ControlManager.Controls_Binding(gv, false, this);

                string strVEND_CODE = gv.GetFocusedRowCellValue("VEND_CODE").ToString();
                string strVEND_NAME = gv.GetFocusedRowCellValue("VEND_NAME").ToString();

                _luVEND_CODE.ReadOnly = true;
                _luVEND_EIN.ReadOnly = true;
                _pVendorInformation_T01Entity.CRUD = "R";
            
                SubFind_DisplayData(strVEND_CODE);
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion

        #region ○ 조회 서치박스 - _luT_VEND_OnOpenClick(object sender, EventArgs e)
        private void _luT_VEND_OnOpenClick(object sender, EventArgs e)
        {
            try
            {
                frmCommonPopup.CRUD = "R";
                frmCommonPopup.USER_CODE = _pUSER_CODE;
                frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                // 0 서비스네임 1 공통코드경우 CODE_TYPE 으로구분자 올린다.
                frmCommonPopup.ARRAY = new object[2] { "vend_code", "100" };
                frmCommonPopup.ARRAY_CODE = new object[2] { _luT_VEND.CodeText.ToString(), _luT_VEND.NameText.ToString() };
                frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분

                xfrmCommonPopup.ShowDialog();

                if (xfrmCommonPopup.dtReturn == null)
                {
                    xfrmCommonPopup.Dispose();
                    return;
                }

                if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                {
                    _luT_VEND.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["CD"].ToString();
                    _luT_VEND.NameText = xfrmCommonPopup.dtReturn.Rows[0]["CD_NM"].ToString();
                }

                xfrmCommonPopup.Dispose();
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
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
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


                //확인
                if (CoFAS_ConvertManager.DataTable_FindCount(_gdSUB_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", ""))
                {
                    //if (CoFAS_DevExpressManager.ShowQuestionMessage("작업중인 자료가 있습니다.\n조회하시겠습니까?") == DialogResult.Yes)
                        if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_WORKING + "\n" + _pMSG_RESET_QUESTION) == DialogResult.Yes)
                        {
                        _pVendorInformation_T01Entity.CRUD = "R";

                        MainFind_DisplayData();
                        _gdSUB.DataSource = null;

                        //DisplayMessage("조회 되었습니다.");
                        DisplayMessage(_pMSG_SEARCH);
                    }
                }
                else
                {
                    _pVendorInformation_T01Entity.CRUD = "R";

                    MainFind_DisplayData();
                    _gdSUB.DataSource = null;
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

                //if (CoFAS_DevExpressManager.ShowQuestionMessage("저장 하시겠습니까?") == DialogResult.No)
                if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_SAVE_QUESTION) == DialogResult.No)
                {
                    return;
                }

                string strFTP_PATH = "";

                if (!dxValidationProvider.Validate())
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("빈값이 있음");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_INPUT_DATA);
                    
                    return;
                }
                if (CheckInputData())
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("필수항목을 확인해주시기 바랍니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_CHECK_VALID_ITEM);
                    return;
                }



                //확인
                if (_luVEND_CODE.Text.Equals(""))
                {
                    _pVendorInformation_T01Entity.CRUD = "U";
                }
                else
                {
                    _pVendorInformation_T01Entity.CRUD = "C";
                }

                _pVendorInformation_T01Entity.CRUD = ""; //C U 확인 처리
                _pVendorInformation_T01Entity.VEND_CODE = _luVEND_CODE.Text.ToString();
                _pVendorInformation_T01Entity.VEND_EIN = _luVEND_EIN.Text.ToString();
                _pVendorInformation_T01Entity.VEND_TYPE = _luVEND_TYPE.GetValue();

                _pVendorInformation_T01Entity.VEND_NAME = _luVEND_NAME.Text.ToString();
                _pVendorInformation_T01Entity.VEND_ENG_NAME = _luVEND_ENG_NAME.Text.ToString();
                _pVendorInformation_T01Entity.VEND_CEO_NAME = _luVEND_CEO_NAME.Text.ToString();
                _pVendorInformation_T01Entity.VEND_BUSINESS_OPENDATE = _luVEND_BUSINESS_OPENDATE.Text.ToString();
                _pVendorInformation_T01Entity.VEND_SSN = _luVEND_SSN.Text.ToString();
                _pVendorInformation_T01Entity.VEND_ADDRESS_1 = _luVEND_ADDRESS_1.Text.ToString();
                _pVendorInformation_T01Entity.VEND_ADDRESS_2 = _luVEND_ADDRESS_2.Text.ToString();
                _pVendorInformation_T01Entity.VEND_BUSINESS = _luVEND_BUSINESS.Text.ToString();
                _pVendorInformation_T01Entity.VEND_BUSINESS_TYPE = _luVEND_BUSINESS_TYPE.Text.ToString();
                _pVendorInformation_T01Entity.VEND_TEL = _luVEND_TEL.Text.ToString();
                _pVendorInformation_T01Entity.VEND_FAX = _luVEND_FAX.Text.ToString();
                _pVendorInformation_T01Entity.VEND_MAIL = _luVEND_MAIL.Text.ToString();
                _pVendorInformation_T01Entity.VEND_FILENAME = "";
                _pVendorInformation_T01Entity.USE_YN = _luUSE_YN.GetValue();
                _pVendorInformation_T01Entity.REMARK = _luREMARK.Text.ToString();

                

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
                if (_gdSUB_VIEW.GridControl != null && CoFAS_ConvertManager.DataTable_FindCount(_gdSUB_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", ""))
                {
                    //if (CoFAS_DevExpressManager.ShowQuestionMessage("작업 중인 데이터가 있습니다.\n초기화 하시겠습니까?") == DialogResult.No)
                    if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_WORKING + "\n" + _pMSG_RESET_QUESTION) == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        InitializeSetting();
                        GridView gv = _gdMAIN_VIEW; //바인딩 되는 데이터 마스터 그리드 설정
                        CoFAS_ControlManager.Controls_Binding(gv, true, this);

                        _luVEND_TYPE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "COMMON_CODE", "CD03", "", "").Tables[0], 0, 0, "");
                        _luUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "COMMON_CODE", "CD99", "", "").Tables[0], 0, 0, "");

                        //조회조건 영역 
                        //_luT_VEND_CODE.Text = "";
                        //_luT_VEND_NAME.Text = "";
                        _luT_VEND.CodeText = "";
                        _luT_VEND.NameText = "";

                        _luT_USE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "COMMON_CODE", "CD99", "", "").Tables[0], 0, 0, "");
                        _luT_USE_YN.ItemIndex = 0;
                        //데이터 영역
                        _luT_VEND_EIN.Text = "";
                        _luT_VEND_TYPE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "COMMON_CODE", "CD03", "", "").Tables[0], 0, 0, "", true);
                        _luT_VEND_TYPE.ItemIndex = 0;

                        //DisplayMessage("초기화했습니다.");
                        DisplayMessage(_pMSG_RESET_COMPLETE);
                    }
                }
                else
                {
                    InitializeSetting();
                    GridView gv = _gdMAIN_VIEW; //바인딩 되는 데이터 마스터 그리드 설정
                    CoFAS_ControlManager.Controls_Binding(gv, true, this);
                    _luVEND_TYPE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "COMMON_CODE", "CD03", "", "").Tables[0], 0, 0, "");
                    _luUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "COMMON_CODE", "CD99", "", "").Tables[0], 0, 0, "");

                    //조회조건 영역 
                    //_luT_VEND_CODE.Text = "";
                    //_luT_VEND_NAME.Text = "";
                    _luT_VEND.CodeText = "";
                    _luT_VEND.NameText = "";

                    _luT_USE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "COMMON_CODE", "CD99", "", "").Tables[0], 0, 0, "");
                    _luT_USE_YN.ItemIndex = 0;
                    //데이터 영역
                    _luT_VEND_EIN.Text = "";
                    _luT_VEND_TYPE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "COMMON_CODE", "CD03", "", "").Tables[0], 0, 0, "", true);
                    _luT_VEND_TYPE.ItemIndex = 0;


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
                new SystemLogInfoBusiness().SystemEventLog_Info_Save("C", _pUSER_CODE, _pMENU_NAME, _pWINDOW_NAME, "Menu Close Event", "Form_FormCloseButton", "Button event is executed");

                Close(); //탭 화면 닫기
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion
        #region ○ 입력 데이터 조사하기 - CheckInputData()

        private bool CheckInputData()
        {
            bool pErrorYN = false;
            string pErrName = string.Empty;

            try
            {
                if (_luVEND_EIN.Text == "")
                    pErrName += "사업자번호. ";
                if (_luVEND_NAME.Text == "")
                    pErrName += "거래처명. ";
                //if (_luVEND_EIN.Text.Length >16 || _luVEND_EIN.Text.Length < 10)
                //    pErrName += "사업자번호 길이(XXX-XX-XXXXX). ";

                //if (_luVEND_SSN.Text.Length > 16 || _luVEND_SSN.Text.Length < 10)
                //    pErrName += "법인번호 길이(XXXXXX-XXXXXXXX).";

                if (_gdSUB_VIEW.RowCount > 0)
                {

                }

                if (pErrName != "")
                {
                    pErrorYN = true;
                    DisplayMessage(pErrName);
                }
            }
            catch (Exception pException)
            {
                pErrorYN = true;
                CoFAS_DevExpressManager.ShowErrorMessage(pException);
            }
            return pErrorYN;
        }

        #endregion

        // DB 처리
        #region ○ 메인조회 - MainFind_DisplayData()

        private void MainFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _pVendorInformation_T01Entity.VEND_CODE = _luT_VEND.CodeText.ToString();
                _pVendorInformation_T01Entity.VEND_NAME = _luT_VEND.NameText.ToString();
                _pVendorInformation_T01Entity.T_VEND_EIN = _luT_VEND_EIN.Text.ToString();
                _pVendorInformation_T01Entity.T_VEND_TYPE = _luT_VEND_TYPE.GetValue();

                _pVendorInformation_T01Entity.USE_YN = _luT_USE_YN.GetValue();

                _dtList = new VendorInformation_T01Business().Vend_Info_Mst(_pVendorInformation_T01Entity);

                if (_pVendorInformation_T01Entity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pVendorInformation_T01Entity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList);

                    if (_pVendorInformation_T01Entity.RTN_KEY != "")
                    {
                        int rowHandle = _gdMAIN_VIEW.LocateByValue("VEND_CODE", _pVendorInformation_T01Entity.RTN_KEY);
                        if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                            _gdMAIN_VIEW.FocusedRowHandle = rowHandle;
                    }
                }
                else
                {
                    _pVendorInformation_T01Entity.CRUD = "";
                    MainFind_DisplayData();
                    SubFind_DisplayData("");
                    InitializeControl();
                    InitializeView();
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
                _gdMAIN_VIEW.BestFitColumns();

                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }

        #endregion
        #region ○ 서브조회 - SubFind_DisplayData(string strVEND_CODE)

        private void SubFind_DisplayData(string strVEND_CODE)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _pVendorInformation_T01Entity.VEND_CODE = strVEND_CODE;

                _dtList = new VendorInformation_T01Business().Vend_Info_Sub(_pVendorInformation_T01Entity);

                if (_pVendorInformation_T01Entity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pVendorInformation_T01Entity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB, _gdSUB_VIEW, _dtList);
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");

                    _pVendorInformation_T01Entity.CRUD = "";
                    SubFind_DisplayData(strVEND_CODE);

                    //조회후 초기화
                    _pVendorInformation_T01Entity.RTN_KEY = ""; 
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

                if (_luVEND_CODE.Text == "") //신규 거래처
                {
                    _pVendorInformation_T01Entity.CRUD = "C";

                    _pVendorInformation_T01Entity.VEND_EIN = _luVEND_EIN.Text.ToString();

                    _chkList = new VendorInformation_T01Business().Vend_Info_chk(_pVendorInformation_T01Entity);
                    if (_chkList != null)
                    {
                        if (_chkList.Rows[0]["cnt"].ToString() != "0")
                        {
                            //CoFAS_DevExpressManager.ShowInformationMessage("이미 등록된 사업자등록번호 입니다.");
                            CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_EXIST_COMPANY_ID);
                            
                            return;
                        }
                    }
                }
                else
                {
                    _pVendorInformation_T01Entity.CRUD = "U";
                }



                string strFTP_PATH = string.Format(@"{0}{1}/%2F/{2}/", _pFTP_PATH, "ITEM", "ITEM_IMAGE");
                if (ofd != null && ofd.SafeFileName.Length > 3)
                {
                    if (CoFAS_FTPManager.FTPUpload_CheckDirectory(ofd.SafeFileName, ofd.FileName, _pFTP_ID, _pFTP_PW, strFTP_PATH, _pWINDOW_NAME))
                    {
                        //CoFAS_DevExpressManager.ShowInformationMessage("저장 처리 되었습니다.");
                        //_luVEND_FILENAME.Text = ofd.SafeFileName;
                        _pVendorInformation_T01Entity.VEND_FILENAME = "";
                        _pFullName = "";
                    }
                    else
                    {
                        isError = true;
                        //CoFAS_DevExpressManager.ShowInformationMessage("FTP 연결을 확인해주세요.");
                    }
                }

                isError = new VendorInformation_T01Business().Vend_Info_Save(_pVendorInformation_T01Entity, dtSave);

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

                    if (_pVendorInformation_T01Entity.RTN_KEY != "")
                    {
                        _luVEND_CODE.ReadOnly = true;
                        InitializeControl();
                        _luVEND_EIN.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
                        _luVEND_EIN.EditMask = "\\d\\d\\d-\\d\\d-\\d\\d\\d\\d\\d";
                        _luVEND_EIN.UseMaskAsDisplayFormat = false;
                        _luVEND_EIN.Text = "";
                        _luVEND_SSN.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
                        _luVEND_SSN.EditMask = "\\d\\d\\d\\d\\d\\d-\\d\\d\\d\\d\\d\\d\\d\\d";
                        _luVEND_SSN.UseMaskAsDisplayFormat = false;
                        _luVEND_SSN.Text = "";
                        _pVendorInformation_T01Entity.CRUD = "R";
                        MainFind_DisplayData();
                        SubFind_DisplayData("");
                        //_luVEND_FILENAME.Text = "";
                    }
                    else
                    {
                        //if (!_pImageDelete_YN)
                        //    CoFAS_DevExpressManager.ShowInformationMessage("저장 처리 되었습니다.");
                        //string strVEND_CODE = _gdMAIN_VIEW.GetFocusedRowCellValue("VEND_CODE").ToString();
                        // string strVEND_NAME = _gdMAIN_VIEW.GetFocusedRowCellValue("VEND_NAME").ToString();

                        _luVEND_CODE.ReadOnly = true;
                        InitializeControl();
                        _luVEND_EIN.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
                        _luVEND_EIN.EditMask = "\\d\\d\\d-\\d\\d-\\d\\d\\d\\d\\d";
                        _luVEND_EIN.UseMaskAsDisplayFormat = false;
                        _luVEND_EIN.Text = "";
                        _luVEND_SSN.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
                        _luVEND_SSN.EditMask = "\\d\\d\\d\\d\\d\\d-\\d\\d\\d\\d\\d\\d\\d\\d";
                        _luVEND_SSN.UseMaskAsDisplayFormat = false;
                        _luVEND_SSN.Text = "";
                        _pVendorInformation_T01Entity.CRUD = "R";
                        MainFind_DisplayData();
                 
                        SubFind_DisplayData("");

                    }
                   //_luT_VEND_CODE.Text = "";
                   //_luT_VEND_NAME.Text = "";

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

        private void _luVEND_SSN__OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                //CoFAS_DevExpressManager.ShowInformationMessage("숫자를 입력하시기 바랍니다.");
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void _ucbtVEND_INFO_DOCUMENT_BTN_Click(object sender, EventArgs e)
        {
            if(_luVEND_CODE.Text.ToString().Equals("")) return;
            
            // 거래처등록-문서등록
            UserForm.frmCommonPopup.CORP_CDDE = _pCORP_CODE;
            UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
            UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
            UserForm.frmCommonPopup.FONT_TYPE = _pFONT_SETTING;
            UserForm.frmCommonPopup.FTP_PATH = _pFTP_PATH;
            UserForm.frmCommonPopup.FTP_ID = _pFTP_ID;
            UserForm.frmCommonPopup.FTP_PW = _pFTP_PW;

            UserForm.frmCommonPopup.ARRAY = new object[2] { "", "" }; //넘기는 파라메터 에 따라 설정
            UserForm.frmCommonPopup.ARRAY_CODE = new object[2] { _luVEND_CODE.Text.ToString(), _luVEND_NAME.Text.ToString()};// dr["CONTRACT_ID"].ToString(), dr["CONTRACT_NUMBER"].ToString() }; //넘기는 파라메터 에 따라 설정

            UserForm.frmCommonPopup xfrmcommonPopup = new UserForm.frmCommonPopup("ucVendInfoDocumentListPopup"); //유저컨트롤러 설정 부분

            xfrmcommonPopup.ShowDialog();

            xfrmcommonPopup.Dispose();
        }

        #region 키보드 이동
        private void _gdMAIN_VIEW_RowChange(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;
                if ((gv.DataSource as DataTable) == null) return;
                CoFAS_ControlManager.Controls_Binding(gv, false, this);

                string strVEND_CODE = gv.GetFocusedRowCellValue("VEND_CODE").ToString();
                string strVEND_NAME = gv.GetFocusedRowCellValue("VEND_NAME").ToString();

                _luVEND_CODE.ReadOnly = true;
                _luVEND_EIN.ReadOnly = true;
                _pVendorInformation_T01Entity.CRUD = "R";

                SubFind_DisplayData(strVEND_CODE);
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion
    }
}
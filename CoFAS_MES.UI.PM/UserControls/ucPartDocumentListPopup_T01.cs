using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CoFAS_MES.CORE.Business;
using CoFAS_MES.UI.PM.Business;
using CoFAS_MES.CORE.Function;
using CoFAS_MES.UI.PM.Entity;
using CoFAS_MES.CORE.Entity;

using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils.DragDrop;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Layout.Modes;
using DevExpress.Utils.Menu;
using System.Diagnostics;
using System.IO;
using System.Security;
using DevExpress.XtraEditors;

namespace CoFAS_MES.UI.PM.UserControls
{
    public partial class ucPartDocumentListPopup_T01 : UserControl
    {
        #region ○기본전역변수
        public MessageEntity _pMessageEntity = null; //공통 메세지 엔티티

        private static string _pCORP_CODE = string.Empty;       // 회사코드       
        private static string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        private static string _pWINDOW_NAME = string.Empty;     // 화면명칭
        private static string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어

        private static string _pFTP_ID = string.Empty;          // FTP ID 정보
        private static string _pFTP_PATH = string.Empty;     // FTP SERVER IP 정보
        private static string _pFTP_PW = string.Empty;          //FTP PW 정보
        private static string _pFTP_IP_PORT = string.Empty;     // FTP SERVER IP 정보
        private static string _pFILE_FLAG = string.Empty;     // FTP SERVER IP 정보

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
        private string _pMSG_RESET_COMPLETE = string.Empty;     //초기화 하였습니다.  
                                                                //추가

        private string _pMSG_CHECK_VALID_ITEM = string.Empty;    //필수항목을 확인해주시기 바랍니다.  
        private string _pMSG_NOT_USE = string.Empty;    //사용할 수 없는 기능입니다.

        private string _pMSG_NO_FILE = string.Empty;    //DB에 저장된 파일이 없습니다.  
        private string _pMSG_NEW_REGISTER = string.Empty;    //신규등록 부분입니다.
        private string _pMSG_VIEW_DOCUMENT_ERROR = string.Empty;    //도면보기 중 오류가 발생하였습니다.  

        private ucPartDocumentListPopup_T01Entity _pucPartDocumentListPopup_T01Entity = null; // 엔티티 생성

        private static Font fntPARENT_FONT = null;       // 시스템 폰트 설정

        //private static DataTable _pDATATABLE_VALUE = null;

        private static object[] _pARRAY = null;
        private static object[] _pARRAY_CODE = null;
        private string _pCRUD = ""; //CRUD

        public static string CORP_CDDE
        {
            get { return _pCORP_CODE; }
            set { _pCORP_CODE = value; }
        }
        public static string USER_CODE
        {
            get { return _pUSER_CODE; }
            set { _pUSER_CODE = value; }
        }
        public static string LANGUAGE_TYPE
        {
            get { return _pLANGUAGE_TYPE; }
            set { _pLANGUAGE_TYPE = value; }
        }
        public static Font FONT_TYPE
        {
            get { return fntPARENT_FONT; }
            set { fntPARENT_FONT = value; }
        }
        public static string FTP_PATH
        {
            get { return _pFTP_PATH; }
            set { _pFTP_PATH = value; }
        }
        public static string FTP_ID
        {
            get { return _pFTP_ID; }
            set { _pFTP_ID = value; }
        }
        public static string FTP_PW
        {
            get { return _pFTP_PW; }
            set { _pFTP_PW = value; }
        }
        public static string FTP_IP_PORT
        {
            get { return _pFTP_IP_PORT; }
            set { _pFTP_IP_PORT = value; }
        }


        public static object[] ARRAY
        {
            get { return _pARRAY; }
            set { _pARRAY = value; }
        }
        public static object[] ARRAY_CODE
        {
            get { return _pARRAY_CODE; }
            set { _pARRAY_CODE = value; }
        }

        private DataTable _dtList = null; //조회 데이터 리스트
        private DataTable dtMessage = null; //화면별 메세지 관리 데이터 테이블

        private DataTable _dtreturn = null; // 선택 데이터 리턴

        public DataTable dtReturn
        {
            get
            {
                return _dtreturn;
            }
            set
            {
                _dtreturn = value;
            }
        }

        private string _pFileName = "";                                 //local 파일이름   //ofd로 받아서 넣기 safe~
        private string _pFullName = "";                                 //localfile 파일명 포함 전체 경로     
        private byte[] _pfile = null;
        private string _pFTP_BEFROE_FILENAME = string.Empty;    //업로드 파일을 변경할경우, 이전파일명 가지고 있고 이전파일명으로 삭제하기

        FileStream STR = null;

        #endregion

        #region ○ 생성자
        public ucPartDocumentListPopup_T01()
        {
            InitializeComponent();
            _pWINDOW_NAME = this.Name.ToString();
            
        }
        #endregion                

        private void ucPartDocumentListPopup_T01_Load(object sender, EventArgs e)
        {
            try
            {
                _pMessageEntity = new MessageEntity();
                DataTable dtMessage = new MessageBusiness().MessageValue_Info(_pLANGUAGE_TYPE);
                if (dtMessage != null)
                {
                    _pMessageEntity.MSG_SEARCH = dtMessage.Rows[0]["MSG_SEARCH"].ToString();
                    _pMessageEntity.MSG_SEARCH_EMPT = dtMessage.Rows[0]["MSG_SEARCH_EMPT"].ToString();
                    _pMessageEntity.MSG_SAVE_QUESTION = dtMessage.Rows[0]["MSG_SAVE_QUESTION"].ToString();
                    _pMessageEntity.MSG_SAVE = dtMessage.Rows[0]["MSG_SAVE"].ToString();
                    _pMessageEntity.MSG_SAVE_ERROR = dtMessage.Rows[0]["MSG_SAVE_ERROR"].ToString();
                    _pMessageEntity.MSG_DELETE_QUESTION = dtMessage.Rows[0]["MSG_DELETE_QUESTION"].ToString();
                    _pMessageEntity.MSG_DELETE = dtMessage.Rows[0]["MSG_DELETE"].ToString();
                    _pMessageEntity.MSG_DELETE_ERROR = dtMessage.Rows[0]["MSG_DELETE_ERROR"].ToString();
                    _pMessageEntity.MSG_DELETE_COMPLETE = dtMessage.Rows[0]["MSG_DELETE_COMPLETE"].ToString();
                    _pMessageEntity.MSG_INPUT_DATA = dtMessage.Rows[0]["MSG_INPUT_DATA"].ToString();
                    _pMessageEntity.MSG_INPUT_DATA_ERROR = dtMessage.Rows[0]["MSG_INPUT_DATA_ERROR"].ToString();
                    _pMessageEntity.MSG_WORKING = dtMessage.Rows[0]["MSG_WORKING"].ToString();
                    _pMessageEntity.MSG_RESET_QUESTION = dtMessage.Rows[0]["MSG_RESET_QUESTION"].ToString();
                    _pMessageEntity.MSG_EXIT_QUESTION = dtMessage.Rows[0]["MSG_EXIT_QUESTION"].ToString();
                    _pMessageEntity.MSG_SELECT = dtMessage.Rows[0]["MSG_SELECT"].ToString();
                    _pMessageEntity.MSG_RESET_COMPLETE = dtMessage.Rows[0]["MSG_RESET_COMPLETE"].ToString();
                    //_pMessageEntity.MSG_NOT_USE = dtMessage.Rows[0]["MSG_NOT_USE"].ToString();
                }

                InitializeSetting();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {
                DevExpress.Utils.AppearanceObject.DefaultFont = fntPARENT_FONT;//화면에 모든 항목 폰트 재설정
            }
        }

        #region ○메뉴초기화하기
        private void InitializeSetting()
        {            
            //메인 화면 공통 메세지 처리           _아래애 MainForm지우기
            _pMSG_SEARCH = _pMessageEntity.MSG_SEARCH;
            _pMSG_SEARCH_EMPT = _pMessageEntity.MSG_SEARCH_EMPT;
            _pMSG_SAVE_QUESTION = _pMessageEntity.MSG_SAVE_QUESTION;
            _pMSG_SAVE = _pMessageEntity.MSG_SAVE;
            _pMSG_SAVE_ERROR = _pMessageEntity.MSG_SAVE_ERROR;
            _pMSG_DELETE_QUESTION = _pMessageEntity.MSG_DELETE_QUESTION;
            _pMSG_DELETE = _pMessageEntity.MSG_DELETE;
            _pMSG_DELETE_ERROR = _pMessageEntity.MSG_DELETE_ERROR;
            _pMSG_DELETE_COMPLETE = _pMessageEntity.MSG_DELETE_COMPLETE;
            _pMSG_INPUT_DATA = _pMessageEntity.MSG_INPUT_DATA;
            _pMSG_INPUT_DATA_ERROR = _pMessageEntity.MSG_INPUT_DATA_ERROR;
            _pMSG_WORKING = _pMessageEntity.MSG_WORKING;
            _pMSG_RESET_QUESTION = _pMessageEntity.MSG_RESET_QUESTION;
            _pMSG_EXIT_QUESTION = _pMessageEntity.MSG_EXIT_QUESTION;
            _pMSG_SELECT = _pMessageEntity.MSG_SELECT;
            _pMSG_RESET_COMPLETE = _pMessageEntity.MSG_RESET_COMPLETE;
            _pMSG_CHECK_VALID_ITEM = _pMessageEntity.MSG_CHECK_VALID_ITEM;
            //_pMSG_NOT_USE = _pMessageEntity.MSG_NOT_USE;

            //메뉴 화면 엔티티 설정

            _pucPartDocumentListPopup_T01Entity = new ucPartDocumentListPopup_T01Entity();
            _pFTP_ID = ARRAY_CODE[3].ToString();
            _pFTP_PW = ARRAY_CODE[4].ToString();
            _pFTP_PATH = ARRAY_CODE[6].ToString();

            _pucPartDocumentListPopup_T01Entity.FTP_ID = _pFTP_ID;
            _pucPartDocumentListPopup_T01Entity.FTP_PW = _pFTP_PW;
            _pucPartDocumentListPopup_T01Entity.CORP_CODE = _pCORP_CODE;
            _pucPartDocumentListPopup_T01Entity.USER_CODE = _pUSER_CODE;
            _pucPartDocumentListPopup_T01Entity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
            _pucPartDocumentListPopup_T01Entity.FTP_PATH = _pFTP_PATH;
            _pucPartDocumentListPopup_T01Entity.FILE_FLAG = _pFILE_FLAG;

            //추가 메세지 정보 조회
            dtMessage = new MessageBusiness().MessageValue_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME);
            if (dtMessage != null && dtMessage.Rows[0][0].ToString() != "")
            {
                _pMSG_NOT_USE = dtMessage.Rows[0]["MSG_NOT_USE"].ToString();
                _pMSG_NO_FILE = dtMessage.Rows[0]["MSG_NO_FILE"].ToString();
                _pMSG_VIEW_DOCUMENT_ERROR = dtMessage.Rows[0]["MSG_VIEW_DOCUMENT_ERROR"].ToString();
                _pMSG_NEW_REGISTER = dtMessage.Rows[0]["MSG_NEW_REGISTER"].ToString();
            }


            //화면 설정 언어 & 명칭 변경. ==고정==
            DataTable dtLanguage = new LanguageBusiness().Language_Info(_pWINDOW_NAME, _pLANGUAGE_TYPE);

            if (dtLanguage != null && dtLanguage.Rows.Count > 0)
            {
                CoFAS_ControlManager.Language_Info(dtLanguage, this);
            }

            DateTime pDateTime = DateTime.Today;
            DateTime pFirstDateTime = pDateTime.AddDays(1 - pDateTime.Day);

            //그리드 설정 ==고정==

            _gdMAIN_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdMAIN, _gdMAIN_VIEW, fntPARENT_FONT, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdMAIN.Name.ToString()));
            _gdSUB_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB, _gdSUB_VIEW, fntPARENT_FONT, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdSUB.Name.ToString()));

            //화면컨트롤러 설정
            _luDOCUMENT_TYPE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "DOCUMENT_TYPE", "", "", "").Tables[0], 0, 0, "", false);            
            _luUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "USE_YN", "", "", "").Tables[0], 0, 1, "", true);
            _luPART_TYPE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "PART_TYPE_PRODUCT_T01", "", "", "").Tables[0], 0, 1, "", true);
            _luDOCUMENT_USE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "USE_YN", "", "", "").Tables[0], 0, 1, "", true);
            _luDOCUMENT_TYPE.ItemIndex = 3;
            _luPART_CODE.Text = ARRAY_CODE[0].ToString();
            _luPART_NAME.Text = ARRAY_CODE[1].ToString();
            _luVEND_PART_CODE.Text = ARRAY_CODE[2].ToString();
            _luPART_TYPE.SetValue(ARRAY_CODE[5].ToString()); 
            //_luPART_TYPE.Text = ARRAY_CODE[3].ToString();

            //그리드초기화                     

            MainFind_DisplayData(); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.            

            //여러그리드사용시 마스터그리드는 최초실행시에만 초기화
            _gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick;
            _gdSUB_VIEW.InitNewRow += _gdSUB_VIEW_InitNewRow;

            //그리드 버튼 추가 시 클릭 이벤트 처리
            //CoFAS_DevGridEventManager.OnViewDoubleClick += CoFAS_DevGridEventManager_OnViewDoubleClick;
            //CoFAS_DevExpressManager._OnButtonPressed += CoFAS_DevExpressManager__OnButtonPressed;          
            CoFAS_DevExpressManager._OnButtonPressed += CoFAS_DevExpressManager__OnButtonPressed;
            CoFAS_DevExpressManager._OnOpenButton += CoFAS_DevExpressManager__OnOpenButton;

            //// 컨트롤러 유효성 검증 처리 기본 컨트롤러 에서만 사용 
            dxValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            dxValidationProvider.Validate();

            //컨트롤러 별 추가 이벤트 생성은 화면 설정 마지막에 진행                 

        }
        #endregion

        //private void CoFAS_DevGridEventManager_OnViewDoubleClick(object sender, EventArgs e)
        //{
        //    GridView view = sender as GridView;

        //    if (view.GridControl.Name.ToString() == "_gdMAIN") return;

        //    DataRow dr = view.GetFocusedDataRow();
        //    if (_gdMAIN_VIEW.GridControl.DataSource == null) return;
        //    DataTable dtDbc = _gdMAIN_VIEW.GridControl.DataSource as DataTable;

        //    bool isDBCChack = CoFAS_ConvertManager.DataTable_FindCount(dtDbc, "DOCUMENT_ID IN ('" + dr["DOCUMENT_ID"].ToString() + "')", "");

        //    if (!isDBCChack)
        //    {
        //        _gdMAIN_VIEW.AddNewRow();

        //        int rowHandle = _gdMAIN_VIEW.GetRowHandle(_gdMAIN_VIEW.DataRowCount);
        //        if (_gdMAIN_VIEW.IsNewItemRow(rowHandle))
        //        {
        //            _gdMAIN_VIEW.SetRowCellValue(rowHandle, "DOCUMENT_ID", dr["DOCUMENT_ID"].ToString());
        //            _gdMAIN_VIEW.SetRowCellValue(rowHandle, "DOCUMENT_TYPE", dr["DOCUMENT_TYPE"].ToString());
        //            _gdMAIN_VIEW.SetRowCellValue(rowHandle, "DOCUMENT_NAME", dr["DOCUMENT_NAME"].ToString());
        //            _gdMAIN_VIEW.SetRowCellValue(rowHandle, "DOCUMENT_FILE_NAME", dr["DOCUMENT_FILE_NAME"].ToString());
        //            _gdMAIN_VIEW.SetRowCellValue(rowHandle, "DOCUMENT_VER", dr["DOCUMENT_VER"].ToString());
        //        }
        //    }
        //    _gdMAIN_VIEW.UpdateCurrentRow();

        //}

        #region ○ 메인 그리드 버튼 클릭 이벤트 생성 - CoFAS_DevExpressManager__OnOpenButton(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        //private void CoFAS_DevExpressManager__OnButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        //{
        //    DataRow dr = null;
        //    string strFTP_PATH = "";
        //    string tempFolderPath = "";

        //    switch (e.Button.Caption.ToString())
        //    {
        //        case "DOCUMENT_VIEW_MAIN_BTN":

        //            dr = _gdMAIN_VIEW.GetFocusedDataRow();
        //            if (dr == null) return;
        //            strFTP_PATH = string.Format(@"{0}{1}/{2}/", _pFTP_PATH, "FILE_DATA", dr["DOCUMENT_TYPE"].ToString());

        //            tempFolderPath = System.IO.Path.GetTempPath() + dr["DOCUMENT_FILE_NAME"].ToString();

        //            CoFAS_FTPManager.FTPFileView(strFTP_PATH, dr["DOCUMENT_FILE_NAME"].ToString(), _pFTP_ID, _pFTP_PW, tempFolderPath);

        //            break;
        //        case "DOCUMENT_VIEW_SUB_BTN":

        //            dr = _gdSUB_VIEW.GetFocusedDataRow();
        //            if (dr == null) return;
        //            strFTP_PATH = string.Format(@"{0}{1}/{2}/", _pFTP_PATH, "FILE_DATA", dr["DOCUMENT_TYPE"].ToString());

        //            tempFolderPath = System.IO.Path.GetTempPath() + dr["DOCUMENT_FILE_NAME"].ToString();

        //            CoFAS_FTPManager.FTPFileView(strFTP_PATH, dr["DOCUMENT_FILE_NAME"].ToString(), _pFTP_ID, _pFTP_PW, tempFolderPath);

        //            break;
        //    }
        //}
        #endregion

        #region ○ 메인 그리드 로우 선택 이벤트 생성 - _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        private void _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;

                CoFAS_ControlManager.Controls_Binding(gv, false, this);

                string strPART_CODE = gv.GetFocusedRowCellValue("PART_CODE").ToString();
                _luPART_CODE2.Text = strPART_CODE;
                _luPART_TYPE.SetValue(gv.GetFocusedRowCellValue("PART_TYPE_CODE").ToString()); 
                //SubFind_DisplayData(strPART_CODE);
                SubFind_DisplayData();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion

        #region ○ 제품조회버튼 클릭        
        private void _btSELECT_Click(object sender, EventArgs e)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

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

        #region ○ 서류조회버튼 클릭 
        private void _ucbtDOCUMENT_SELECT_Click(object sender, EventArgs e)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                SubFind_DisplayData();
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

        #region ○ 서브그리드 조회조건 변경 시

        private void _lu_DOCUMENT_TYPE_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _pucPartDocumentListPopup_T01Entity.CRUD = "R";
                SubFind_DisplayData();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        private void _lu_USE_YN_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _pucPartDocumentListPopup_T01Entity.CRUD = "R";
                SubFind_DisplayData();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion        

        #region ○ 닫기버튼
        public static event OnClickEventHandler _Close_Click;
        public delegate void OnClickEventHandler(object sender, EventArgs e);
        private void _btCancle_Click(object sender, EventArgs e)
        {
            if (_Close_Click != null)
               _Close_Click(sender, e);
             CoFAS_DevExpressManager._OnButtonPressed -= CoFAS_DevExpressManager__OnButtonPressed;
            CoFAS_DevExpressManager._OnOpenButton -= CoFAS_DevExpressManager__OnOpenButton;
            

        }

        #endregion

        #region ○ 저장버튼
        private void _btSAVE_Click(object sender, EventArgs e)
        {
            try
            {
                if (_luPART_CODE2.Text == "")
                {
                    CoFAS_DevExpressManager.ShowErrorMessage("제품이 선택되지 않았습니다.");
                }

                else
                {
                    CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                    if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_SAVE_QUESTION) == DialogResult.Yes)
                    {
                        //InputDataMain_Save(_gdMAIN_VIEW.GridControl.DataSource as DataTable);
                        InputData_Save(_gdSUB_VIEW.GridControl.DataSource as DataTable);
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

        // DB 처리

        #region ○ 메인조회 - MainFind_DisplayData()

        private void MainFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _pucPartDocumentListPopup_T01Entity.CRUD = "R";
                _pucPartDocumentListPopup_T01Entity.PART_CODE = _luPART_CODE.Text.ToString();
                _pucPartDocumentListPopup_T01Entity.PART_NAME = _luPART_NAME.Text.ToString();
                _pucPartDocumentListPopup_T01Entity.VEND_PART_CODE = _luVEND_PART_CODE.Text.ToString();
                _pucPartDocumentListPopup_T01Entity.USE_YN = _luUSE_YN.GetValue();
                _pucPartDocumentListPopup_T01Entity.PART_TYPE = _luPART_TYPE.GetValue();

                _dtList = new ucPartDocumentListPopup_T01Business().ucPartDocumentListPopup_T01_Info_Main(_pucPartDocumentListPopup_T01Entity);

                if (_pucPartDocumentListPopup_T01Entity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pucPartDocumentListPopup_T01Entity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList);
                }
                if (_dtList.Rows.Count == 0)
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList);
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

        private void SubFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _pucPartDocumentListPopup_T01Entity.CRUD = "R";
                _pucPartDocumentListPopup_T01Entity.DOCUMENT_TYPE = _luDOCUMENT_TYPE.GetValue();
                _pucPartDocumentListPopup_T01Entity.USE_YN = _luDOCUMENT_USE_YN.GetValue();
                _pucPartDocumentListPopup_T01Entity.PART_CODE = _luPART_CODE2.Text.ToString();

                //_pucPartDocumentListPopup_T01Entity.CONTRACT_ID = "";
                //_pucPartDocumentListPopup_T01Entity.CONTRACT_NUMBER = "";
                //_pucPartDocumentListPopup_T01Entity.DOCUMENT_NAME = "";// _luDOCUMENT_NAME.Text.ToString();
                //_pucPartDocumentListPopup_T01Entity.DOCUMENT_VER = "";//_luDOCUMENT_VER.Text.ToString();

                _dtList = new ucPartDocumentListPopup_T01Business().ucPartDocumentListPopup_T01_Info_Sub(_pucPartDocumentListPopup_T01Entity);

                if (_pucPartDocumentListPopup_T01Entity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pucPartDocumentListPopup_T01Entity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB, _gdSUB_VIEW, _dtList);
                }
                if (_dtList.Rows.Count == 0)
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB, _gdSUB_VIEW, _dtList);
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {
                //_gdSUB_VIEW.BestFitColumns();
                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }

        #endregion        
        
        #region ○ 서브 그리드 신규로우 생성시 이벤트 생성 - _gdSUB_VIEW_InitNewRow(object sender, InitNewRowEventArgs e)
        private void _gdSUB_VIEW_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            //if (_luDOCUMENT_TYPE.Text.ToString() == "") return;

            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns["DOCUMENT_TYPE"], _luDOCUMENT_TYPE.GetValue().ToString());
            view.SetRowCellValue(e.RowHandle, view.Columns["USE_YN"], "Y");
            view.SetRowCellValue(e.RowHandle, view.Columns["PART_CODE"], _luPART_CODE2.Text.ToString());

            //string a = _luDOCUMENT_TYPE.GetValue().ToString();

            if (_luDOCUMENT_TYPE.GetValue().ToString() == "")
            {
                
                CoFAS_DevExpressManager.ShowErrorMessage(_pMSG_CHECK_VALID_ITEM);
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
                    CoFAS_DevExpressManager.ShowErrorMessage(_pMSG_CHECK_VALID_ITEM);
                    return;
                }
                if (_luDOCUMENT_TYPE.Text.ToString() == "" || _luDOCUMENT_TYPE.Text.ToString() == "")
                {
                    CoFAS_DevExpressManager.ShowErrorMessage(_pMSG_CHECK_VALID_ITEM);
                    return;
                }

                _pucPartDocumentListPopup_T01Entity.DOCUMENT_TYPE = _luDOCUMENT_TYPE.Text.ToString();
                InputData_Save(_gdSUB_VIEW.GridControl.DataSource as DataTable);

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

        #region ○ 그리드 버튼추가 시 클릭 이벤트 생성 - CoFAS_DevExpressManager__OnButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        private void CoFAS_DevExpressManager__OnButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            CoFAS_DevExpressManager._OnButtonPressed += CoFAS_DevExpressManager__OnButtonPressed;                      
            btnEvent(sender, e);
            CoFAS_DevExpressManager._OnButtonPressed -= CoFAS_DevExpressManager__OnButtonPressed;
        }
        #endregion

        #region ○ 도면보기 버튼 - btnEvent(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEvent(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //ButtonEdit btnedit = sender as ButtonEdit;
            //GridView g = null;
            ////string _sFCode = string.Empty;
            ////string _sFName = string.Empty;

            ////string _sResultCode = string.Empty;
            ////string _sResultName = string.Empty;

            //if (btnedit != null)
            //{
            //    var gridControl = btnedit.Parent as DevExpress.XtraGrid.GridControl;
            //    if (gridControl == null)
            //        return;

            //    var gridView = gridControl.FocusedView as DevExpress.XtraGrid.Views.Grid.GridView;
            //    g = gridView;
            //    if (gridView == null)
            //        return;

            //    var dataRow = gridView.GetFocusedDataRow();
            //    if (dataRow == null)
            //        return;
            //}                        

            switch (e.Button.Caption.ToString())
            {
                case "VIEW_BUTTON": //해당 그리드에 필드명 // 2개 이상 그리드의 버튼 항목들은 버튼 타입에 필드 명칭이 모두 다르게 설정 되어야됨.
                    //_sFCode = g.GetFocusedRowCellValue("PART_CODE").ToString();
                    //_sFName = g.GetFocusedRowCellValue("PART_NAME").ToString();
                    //_gdSUB_VIEW.GetFocusedRowCellValue("DOCUMENT_ID").ToString();

                    try
                    {
                        //string strFTP_PATH = "";

                        //if (_pucPartDocumentListPopup_T01Entity.CRUD == "")
                        //    _dtList.Rows.Clear();                                       

                        ////if (_gdSUB_VIEW.GetFocusedRowCellValue("DOCUMENT_ID").ToString() == "" || _gdSUB_VIEW.GetFocusedRowCellValue("DOCUMENT_ID") == null)
                        ////    return;

                        //////if (_gdSUB_VIEW.GetRowCellValue(_gdSUB_VIEW.FocusedRowHandle, "FILE_NAME_2").ToString() == "")
                        //////    return;

                        DataRow dr = _gdSUB_VIEW.GetFocusedDataRow();

                        string strFILE_NAME_2 = "";
                        if (dr["FILE_NAME_2"] != null)
                            strFILE_NAME_2 = dr["FILE_NAME_2"].ToString(); // _gdSUB_VIEW.GetRowCellValue(_gdSUB_VIEW.FocusedRowHandle, "FILE_NAME_2").ToString();
                        else
                            CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_VIEW_DOCUMENT_ERROR); 
                        
                        //string strFILE_NAME_2 = _gdSUB_VIEW.GetFocusedRowCellValue("FILE_NAME_2").ToString();//_gdSUB_VIEW.GetRowCellValue(_gdSUB_VIEW.FocusedRowHandle, "FILE_NAME_2").ToString();

                        string strFTP_PATH = string.Format(@"{0}{1}/{2}/", _pucPartDocumentListPopup_T01Entity.FTP_PATH, "FILE_DATA", _luDOCUMENT_TYPE.GetValue().ToString());
                        
                        string strEXTENSION = dr["EXTENSION"].ToString();

                        if (strEXTENSION == ".pdf")
                        {

                            CORE.UserForm.frmPdfView.CORP_CDDE = _pCORP_CODE;
                            CORE.UserForm.frmPdfView.USER_CODE = _pUSER_CODE;
                            CORE.UserForm.frmPdfView.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                            //CORE.UserForm.frmPdfView.FONT_TYPE = _pFONT_SETTING;
                            
                            var fst =  CoFAS_FTPManager.FTPImage(strFTP_PATH, strFILE_NAME_2, _pFTP_ID, _pFTP_PW);

                            MemoryStream _ms = new MemoryStream();

                            byte[] buffer = new byte[16 * 1024];
                            int read;
                            while ((read = fst.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                _ms.Write(buffer, 0, read);
                            }

                            CORE.UserForm.frmPdfView.MS = _ms;

                            CORE.UserForm.frmPdfView xfrmPdfView = new CORE.UserForm.frmPdfView(); //유저컨트롤러 설정 부분



                            xfrmPdfView.ShowDialog();
                        }
                        else
                        {
                            CORE.UserForm.frmImageView.CORP_CDDE = _pCORP_CODE;
                            CORE.UserForm.frmImageView.USER_CODE = _pUSER_CODE;
                            CORE.UserForm.frmImageView.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                            //CORE.UserForm.frmImageView.FONT_TYPE = _pFONT_SETTING;
                            CORE.UserForm.frmImageView.IMAGE_DATA = Image.FromStream(CoFAS_FTPManager.FTPImage(strFTP_PATH, strFILE_NAME_2, _pFTP_ID, _pFTP_PW));

                            CORE.UserForm.frmImageView xfrmImageView = new CORE.UserForm.frmImageView(); //유저컨트롤러 설정 부분
                            xfrmImageView.ShowDialog();
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
                    break;
            }
    }
        #endregion
        
        #region ○ 파일 가져오기, 저장하기, 삭제하기 기능
        private void CoFAS_DevExpressManager__OnOpenButton(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Caption.ToString())
            {
                case "FILE_NAME_1": //해당 그리드에 필드명 // 2개 이상 그리드의 버튼 항목들은 버튼 타입에 필드 명칭이 모두 다르게 설정 되어야됨.

                    switch (e.Button.Index)
                    {
                        case 0: //오픈
                            try
                            {
                                //OpenFileDialog fileDlg1 = new OpenFileDialog();
                                //fileDlg1.DefaultExt = "*";
                                //fileDlg1.Filter = "Jpeg Files(*.jpg)|*.jpg|PDF Files(*.pdf)|*.pdf";
                                //if (fileDlg1.ShowDialog() == DialogResult.OK)
                                //{

                                //    txtBox135.Text = fileDlg1.FileName.ToString().Trim(); // 로컬FULL 경로
                                //    txtBox127.Text = txtBox13.Text.Replace("-", "").Replace(".", "") + "_DW" + Path.GetExtension(fileDlg1.SafeFileName);
                                //}

                                OpenFileDialog ofd = new OpenFileDialog();
                                ofd.DefaultExt = "*";
                                ofd.Filter = "ALL(*.*) | *.*";                              
                               //_pFTP_BEFROE_FILENAME = _gdSUB_VIEW.GetFocusedRowCellValue("FILE_NAME_1").ToString();

                                if (ofd.ShowDialog() == DialogResult.OK)
                                {

                                    _pFullName = ofd.FileName;    // FTP업로드 확인용, 새로운 파일을 올렸을 때만 데이터 입력됨
                                    _pFileName = ofd.SafeFileName; // 
                                    string strExtensiont = Path.GetExtension(ofd.SafeFileName);
                                    string strDirectory = Path.GetDirectoryName(ofd.FileName);

                                    _gdSUB_VIEW.SetRowCellValue(_gdSUB_VIEW.FocusedRowHandle, _gdSUB_VIEW.Columns["DIRECTORY"], strDirectory);
                                    _gdSUB_VIEW.SetRowCellValue(_gdSUB_VIEW.FocusedRowHandle, _gdSUB_VIEW.Columns["FILE_NAME_1"], _pFileName);
                                    _gdSUB_VIEW.SetRowCellValue(_gdSUB_VIEW.FocusedRowHandle, _gdSUB_VIEW.Columns["EXTENSION"], strExtensiont);

                                    using (FileStream stream = new FileStream(ofd.FileName.ToString(), FileMode.Open))//, FileAccess.Read))
                                    {
                                        STR = stream;
                                    }
                                   
                                    _pucPartDocumentListPopup_T01Entity.FILE_FLAG = "F";
                                    
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

                                if (_gdSUB_VIEW.GetRowCellValue(_gdSUB_VIEW.FocusedRowHandle, "FILE_NAME_2").ToString() == "")
                                {
                                    //조회된 _gdSUB에 XML_FILE_NAME이 없으면, db에 저장된 파일이 없다고 메세지 띄우기 
                                    //CoFAS_DevExpressManager.ShowInformationMessage("DB에 저장된 파일이 없습니다.");
                                    //CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_NO_SELETED_ITEM_OR_NO_SAVE + "\n" + _pMSG_REG_DATA);
                                }
                                else
                                {
                                    // db에 저장된 것이면 다운로드하기 
                                    //조회된 _gdSUB에 XML_FILE_NAME이 있으면, Templete_Download() 실행
                                    File_Download();

                                    //CoFAS_DevExpressManager.ShowInformationMessage(string.Format("{0}", "다운로드 되었습니다."));
                                    //DisplayMessage(string.Format("{0}", _pMSG_DOWNLOAD_COMPLETE));

                                }
                            }
                            break;

                        case 2:
                            //삭제
                            //삭제기능 사용 못하게함
                            CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_NOT_USE);
                            return;

                            if (_gdSUB_VIEW.IsNewItemRow(_gdSUB_VIEW.FocusedRowHandle))
                            {
                                CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_NEW_REGISTER);
                                //CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_NEW_REG_GUBN);

                            }
                            else
                            {
                                //메뉴 선택이 되어 있는 상황
                                //그 중에서도 db에 파일이 저장이 안 된 것이면 DB에 저장된 파일이 아님을 말해줘야 함.

                                if (_gdSUB_VIEW.GetRowCellValue(_gdSUB_VIEW.FocusedRowHandle, "FILE_NAME_2").ToString() == "")
                                {
                                    //조회된 _gdSUB에 XML_FILE_NAME이 없으면, db에 저장된 파일이 없다고 메세지 띄우기 
                                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_NO_FILE);
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
                                        //CoFAS_DevExpressManager.ShowInformationMessage(string.Format("{0}", _pMSG_DELETE));


                                    }

                                }
                            }
                            break;
                    }

                    break;
            }
        }
        #endregion;

        #region ○ 저장 - InputData_Save(DataTable dtSave)

        private void InputData_Save(DataTable dtSave)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                bool isError = false;


                isError = new ucPartDocumentListPopup_T01Business().Document_Info_Save(_pucPartDocumentListPopup_T01Entity, dtSave);

                if (isError)
                {
                    //오류 발생.
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_INPUT_DATA);
                    //화면 표시.

                }
                else
                {
                    //정상 처리
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                    _pucPartDocumentListPopup_T01Entity.CRUD = "R";
                    _pucPartDocumentListPopup_T01Entity.DOCUMENT_TYPE = _luDOCUMENT_TYPE.GetValue().ToString();// _luDOCUMENT_TYPE.Text.ToString();
                    _pucPartDocumentListPopup_T01Entity.PART_CODE = _luPART_CODE2.Text.ToString();
                    //_pucPartDocumentListPopup_T01Entity.DOCUMENT_NAME = _luDOCUMENT_NAME.Text.ToString();
                    //_pucPartDocumentListPopup_T01Entity.DOCUMENT_VER = _luDOCUMENT_VER.Text.ToString();
                    _pucPartDocumentListPopup_T01Entity.USE_YN = _luUSE_YN.GetValue();
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

                if (_pucPartDocumentListPopup_T01Entity.CRUD == "") _dtList.Rows.Clear();

                if (_gdSUB_VIEW.FocusedValue.ToString() == "") return;

                //_pucPartDocumentListPopup_T01Entity.FILE_NAME_2 = _gdSUB_VIEW.FocusedValue.ToString();
                _pucPartDocumentListPopup_T01Entity.FILE_NAME_2 = _gdSUB_VIEW.GetRowCellValue(_gdSUB_VIEW.FocusedRowHandle, "FILE_NAME_2").ToString();
                _pucPartDocumentListPopup_T01Entity.FILE_NAME_1 = _gdSUB_VIEW.GetRowCellValue(_gdSUB_VIEW.FocusedRowHandle, "FILE_NAME_1").ToString();
                _pucPartDocumentListPopup_T01Entity.EXTENSION = _gdSUB_VIEW.GetRowCellValue(_gdSUB_VIEW.FocusedRowHandle, "EXTENSION").ToString();

                 string strFILE_NAME_2 = _gdSUB_VIEW.GetRowCellValue(_gdSUB_VIEW.FocusedRowHandle, "FILE_NAME_2").ToString();
               

                //ftp에서 local로 다운로드 

                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.InitialDirectory = @"C:\";
                saveFile.Filter = "ALL(*.*)|*.*";
                saveFile.FileName = _pucPartDocumentListPopup_T01Entity.FILE_NAME_1;

                strFTP_PATH = string.Format(@"{0}{1}/{2}/", _pucPartDocumentListPopup_T01Entity.FTP_PATH, "FILE_DATA", _luDOCUMENT_TYPE.GetValue().ToString());

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    string _pDOWNLOAD_PATH = saveFile.FileName + _pucPartDocumentListPopup_T01Entity.EXTENSION;// _pucPartDocumentListPopup_T01Entity.FILE_NAME_2;// saveFile.FileName;
                  ;
                    CoFAS_FTPManager.FTPDownLoad2(strFTP_PATH, strFILE_NAME_2, _pFTP_ID, _pFTP_PW, _pDOWNLOAD_PATH, false);

                    //DisplayMessage("선택한 파일이 지정한 폴더(" + _pFTP_DOWNLOAD_PATH + ")에 저장되었습니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE + "(path:" + _pDOWNLOAD_PATH + ")");
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

                //GridView gv = _gdMAIN_VIEW as GridView;

                bool isError = false;
                //if (gv.GetFocusedValue() != null)
                //{
                _pucPartDocumentListPopup_T01Entity.CRUD = "U";
                _pucPartDocumentListPopup_T01Entity.DOCUMENT_ID = _gdSUB_VIEW.GetFocusedRowCellValue("DOCUMENT_ID").ToString();
                _pucPartDocumentListPopup_T01Entity.DOCUMENT_TYPE = _luDOCUMENT_TYPE.GetValue().ToString();
                _pucPartDocumentListPopup_T01Entity.PART_CODE = _gdSUB_VIEW.GetFocusedRowCellValue("PART_CODE").ToString();
                _pucPartDocumentListPopup_T01Entity.SEQ = _gdSUB_VIEW.GetFocusedRowCellValue("SEQ").ToString();
                _pucPartDocumentListPopup_T01Entity.FILE_NAME_1 = ""; //_gdSUB_VIEW.GetFocusedRowCellValue("FILE_NAME_1").ToString();
                _pucPartDocumentListPopup_T01Entity.FILE_NAME_2 = ""; //_gdSUB_VIEW.GetFocusedRowCellValue("FILE_NAME_2").ToString();
                _pucPartDocumentListPopup_T01Entity.EXTENSION = ""; //_gdSUB_VIEW.GetFocusedRowCellValue("EXTENSION").ToString();
                _pucPartDocumentListPopup_T01Entity.USE_YN = _gdSUB_VIEW.GetFocusedRowCellValue("USE_YN").ToString();
                _pucPartDocumentListPopup_T01Entity.REMARK = _gdSUB_VIEW.GetFocusedRowCellValue("REMARK").ToString();                                         
                
                //}

                isError = new ucPartDocumentListPopup_T01Business().Document_File_Delete(_pucPartDocumentListPopup_T01Entity);

                string strFTP_PATH = "";

                if (isError)
                {
                    //오류 발생.
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_DELETE_ERROR);
                }
                else
                {
                    //정상 처리
                    strFTP_PATH = string.Format(@"{0}{1}/{2}/", _pucPartDocumentListPopup_T01Entity.FTP_PATH, "FILE_DATA", _luDOCUMENT_TYPE.GetValue().ToString());

                    string qFileName = _pucPartDocumentListPopup_T01Entity.FILE_NAME_2;
                    string qPath = strFTP_PATH;

                    CoFAS_FTPManager.FTPDelete(qFileName, qPath, _pFTP_ID, _pFTP_PW);

                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_DELETE);

                    _pucPartDocumentListPopup_T01Entity.CRUD = "R";
                    _pucPartDocumentListPopup_T01Entity.DOCUMENT_TYPE = _luDOCUMENT_TYPE.Text.ToString();
                    //_pucPartDocumentListPopup_T01Entity.DOCUMENT_NAME = _luDOCUMENT_NAME.Text.ToString();
                    //_pucPartDocumentListPopup_T01Entity.DOCUMENT_VER = _luDOCUMENT_VER.Text.ToString();
                    _pucPartDocumentListPopup_T01Entity.USE_YN = _luUSE_YN.GetValue();
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

    }

}

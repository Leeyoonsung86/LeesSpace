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
using CoFAS_MES.UI.PO.Business;
using CoFAS_MES.CORE.Function;
using CoFAS_MES.UI.PO.Entity;
using CoFAS_MES.CORE.Entity;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils.DragDrop;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Layout.Modes;
using DevExpress.Utils.Menu;
using System.Diagnostics;
using System.IO;
using System.Security;

namespace CoFAS_MES.UI.PO.UserControls
{
    public partial class ucContractDocumentListPopup : UserControl
    {
        public MessageEntity _pMessageEntity = null; //공통 메세지 엔티티

        private static string _pCORP_CODE = string.Empty;       // 회사코드       
        private static string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        private static string _pWINDOW_NAME = string.Empty;     // 화면명칭
        private static string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어

        private static string _pFTP_ID = string.Empty;          // FTP ID 정보
        private static string _pFTP_PATH = string.Empty;     // FTP SERVER IP 정보
        private static string _pFTP_PW = string.Empty;          //FTP PW 정보

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


        private ucContractDocumentListPopupEntity _pucContractDocumentListPopupEntity = null; // 엔티티 생성

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

        public ucContractDocumentListPopup()
        {
            InitializeComponent();

            _pWINDOW_NAME = this.Name.ToString();
        }

        private void ucContractDocumentListPopup_Load(object sender, EventArgs e)
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

            //메뉴 화면 엔티티 설정
            _pucContractDocumentListPopupEntity = new ucContractDocumentListPopupEntity();
            _pucContractDocumentListPopupEntity.CORP_CODE = _pCORP_CODE;
            _pucContractDocumentListPopupEntity.USER_CODE = _pUSER_CODE;
            _pucContractDocumentListPopupEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;

            //화면 설정 언어 & 명칭 변경. ==고정==
            DataTable dtLanguage = new LanguageBusiness().Language_Info(_pWINDOW_NAME, _pLANGUAGE_TYPE);

            if (dtLanguage != null && dtLanguage.Rows.Count > 0)
            {
                CoFAS_ControlManager.Language_Info(dtLanguage, this);
            }

            _luCONTRACT_NUMBER1.Text = ARRAY_CODE[1].ToString();
            _luCONTRACT_REVISION.Text = ARRAY_CODE[2].ToString();
            _luCONTRACT_ID.Text = ARRAY_CODE[0].ToString();
            _luCONTRACT_NUMBER2.Text = ARRAY_CODE[1].ToString();


            DateTime pDateTime = DateTime.Today;
            DateTime pFirstDateTime = pDateTime.AddDays(1 - pDateTime.Day);

            //그리드 설정 ==고정==

            _gdMAIN_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdMAIN, _gdMAIN_VIEW, fntPARENT_FONT, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdMAIN.Name.ToString()));


            _gdSUB_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB, _gdSUB_VIEW, fntPARENT_FONT, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdSUB.Name.ToString()));

            CoFAS_DevGridEventManager.OnViewDoubleClick += CoFAS_DevGridEventManager_OnViewDoubleClick;
            CoFAS_DevExpressManager._OnButtonPressed += CoFAS_DevExpressManager__OnButtonPressed;

            _luDOCUMENT_TYPE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "DOCUMENT_TYPE", "", "", "").Tables[0], 0, 0, "", true);
            _luUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "USE_YN", "", "", "").Tables[0], 0, 1, "", true);
            _luDOCUMENT_USE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "USE_YN", "", "", "").Tables[0], 0, 1, "", true);

            MainFind_DisplayData(); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.

            SubFind_DisplayData();

        }

        private void CoFAS_DevGridEventManager_OnViewDoubleClick(object sender, EventArgs e)
        {
            GridView view = sender as GridView;

            if (view.GridControl.Name.ToString() == "_gdMAIN") return;

            DataRow dr = view.GetFocusedDataRow();

            if (_gdMAIN_VIEW.GridControl == null) return;

            DataTable dtDbc = _gdMAIN_VIEW.GridControl.DataSource as DataTable;

            bool isDBCChack = CoFAS_ConvertManager.DataTable_FindCount(dtDbc, "DOCUMENT_ID IN ('"+ dr["DOCUMENT_ID"].ToString() + "')", "");

            if (!isDBCChack)
            {
                _gdMAIN_VIEW.AddNewRow();

                int rowHandle = _gdMAIN_VIEW.GetRowHandle(_gdMAIN_VIEW.DataRowCount);
                if (_gdMAIN_VIEW.IsNewItemRow(rowHandle))
                {
                    _gdMAIN_VIEW.SetRowCellValue(rowHandle, "DOCUMENT_ID", dr["DOCUMENT_ID"].ToString());
                    _gdMAIN_VIEW.SetRowCellValue(rowHandle, "DOCUMENT_TYPE", dr["DOCUMENT_TYPE"].ToString());
                    _gdMAIN_VIEW.SetRowCellValue(rowHandle, "DOCUMENT_NAME", dr["DOCUMENT_NAME"].ToString());
                    _gdMAIN_VIEW.SetRowCellValue(rowHandle, "DOCUMENT_VER", dr["DOCUMENT_VER"].ToString());
                }
            }
            _gdMAIN_VIEW.UpdateCurrentRow();
        }

        #region ○ 메인 그리드 버튼 클릭 이벤트 생성 - CoFAS_DevExpressManager__OnOpenButton(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        private void CoFAS_DevExpressManager__OnButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataRow dr = null;
            string strFTP_PATH = "";
            string tempFolderPath = "";

            switch (e.Button.Caption.ToString())
            {
                case "CONTRACT_DOCUMENT_VIEW_MAIN_BTN":

                    dr = _gdMAIN_VIEW.GetFocusedDataRow();

                    if (dr == null) return;

                    strFTP_PATH = string.Format(@"{0}{1}/{2}/", _pFTP_PATH, "FILE_DATA", dr["DOCUMENT_TYPE"].ToString());

                    tempFolderPath = System.IO.Path.GetTempPath() + dr["DOCUMENT_FILE_NAME"].ToString();

                    CoFAS_FTPManager.FTPFileView(strFTP_PATH, dr["DOCUMENT_FILE_NAME"].ToString(), _pFTP_ID, _pFTP_PW, tempFolderPath);

                    break;
                case "CONTRACT_DOCUMENT_VIEW_SUB_BTN":

                    dr = _gdSUB_VIEW.GetFocusedDataRow();

                    if (dr == null) return;

                    strFTP_PATH = string.Format(@"{0}{1}/{2}/", _pFTP_PATH, "FILE_DATA", dr["DOCUMENT_TYPE"].ToString());

                    tempFolderPath = System.IO.Path.GetTempPath() + dr["DOCUMENT_FILE_NAME"].ToString();

                    CoFAS_FTPManager.FTPFileView(strFTP_PATH, dr["DOCUMENT_FILE_NAME"].ToString(), _pFTP_ID, _pFTP_PW, tempFolderPath);

                    break;
            }
        }
        #endregion

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


        private void _btCLEAR_Click(object sender, EventArgs e)
        {
            //_luPART_NAME.Text = "";  //자재명 초기화
            //_luVEND_NAME.Text = "";  //거래처명 초기화
            //_luTORDER_DATE.FromDateTime = DateTime.Now;
            ////_luORDER_DATE1.DateTime = DateTime.Now; //from
            //_gdMAIN.DataSource = null;
        }

        // DB 처리
        #region ○ 메인조회 - MainFind_DisplayData()

        private void MainFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _pucContractDocumentListPopupEntity.CRUD = "R";
                _pucContractDocumentListPopupEntity.CONTRACT_ID = _luCONTRACT_ID.Text.ToString();
                _pucContractDocumentListPopupEntity.CONTRACT_REVISION = _luCONTRACT_REVISION.Text.ToString();
                _pucContractDocumentListPopupEntity.USE_YN = _luUSE_YN.GetValue();

                _dtList = new ucContractDocumentListPopupBusiness().ucContractDocumentListPopup_Info_Main(_pucContractDocumentListPopupEntity);

                if (_pucContractDocumentListPopupEntity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pucContractDocumentListPopupEntity.CRUD == ""))
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

                _pucContractDocumentListPopupEntity.CRUD = "R";
                _pucContractDocumentListPopupEntity.CONTRACT_ID = _luCONTRACT_ID.Text.ToString();
                _pucContractDocumentListPopupEntity.CONTRACT_NUMBER = _luCONTRACT_NUMBER2.Text.ToString();
                _pucContractDocumentListPopupEntity.DOCUMENT_TYPE = _luDOCUMENT_TYPE.GetValue();
                _pucContractDocumentListPopupEntity.DOCUMENT_NAME = _luDOCUMENT_NAME.Text.ToString();
                _pucContractDocumentListPopupEntity.DOCUMENT_VER = _luDOCUMENT_VER.Text.ToString();
                _pucContractDocumentListPopupEntity.USE_YN = _luDOCUMENT_USE_YN.GetValue();

                _dtList = new ucContractDocumentListPopupBusiness().ucContractDocumentListPopup_Info_Sub(_pucContractDocumentListPopupEntity);

                if (_pucContractDocumentListPopupEntity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pucContractDocumentListPopupEntity.CRUD == ""))
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
                _gdSUB_VIEW.BestFitColumns();

                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }

        #endregion

        #region ○ 저장 - InputDataMain_Save(DataTable dtSave)

        private void InputDataMain_Save(DataTable dtSave)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                bool isError = false;

                isError = new ucContractDocumentListPopupBusiness().ucContractDocumentListPopup_Info_Save(_pucContractDocumentListPopupEntity, dtSave);

                if (isError)
                {
                    //오류 발생.
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                    //화면 표시.

                }
                else
                {
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

        private void _btSAVE_Click(object sender, EventArgs e)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_SAVE_QUESTION) == DialogResult.Yes)
                {
                    _pucContractDocumentListPopupEntity.CONTRACT_ID = _luCONTRACT_ID.Text.ToString();
                    _pucContractDocumentListPopupEntity.CONTRACT_NUMBER = _luCONTRACT_NUMBER1.Text.ToString();
                    _pucContractDocumentListPopupEntity.CONTRACT_REVISION = _luCONTRACT_REVISION.Text.ToString();

                    InputDataMain_Save(_gdMAIN_VIEW.GridControl.DataSource as DataTable);
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

        //닫기버튼
        public static event OnClickEventHandler _Close_Click;
        public delegate void OnClickEventHandler(object sender, EventArgs e);
        private void _btCancle_Click(object sender, EventArgs e)
        {
            if (_Close_Click != null)
                _Close_Click(sender, e);
        }

        private void _ucbtMOVE_Click(object sender, EventArgs e)
        {
            DataTable dt = _gdSUB_VIEW.GridControl.DataSource as DataTable;

            DataTable dtTemp = null;

            bool isChack = CoFAS_ConvertManager.DataTable_FindCount(dt, "MOVE IN ('Y')", "");

            if (isChack)
            {
                dtTemp = CoFAS_ConvertManager.DataTable_FindValue(dt, "MOVE IN ('Y')", ""); // 신규 and 수정 항목 데이터 테이블 화

                for (int a = 0; a < dtTemp.Rows.Count; a++)
                {

                    DataTable dtCheck = _gdMAIN_VIEW.GridControl.DataSource as DataTable;

                    bool isNewChack = CoFAS_ConvertManager.DataTable_FindCount(dtCheck, "DOCUMENT_ID IN ('"+ dtTemp.Rows[a]["DOCUMENT_ID"].ToString() + "')", "");

                    if (!isNewChack)
                    {
                        _gdMAIN_VIEW.AddNewRow();

                        int rowHandle = _gdMAIN_VIEW.GetRowHandle(_gdMAIN_VIEW.DataRowCount);
                        if (_gdMAIN_VIEW.IsNewItemRow(rowHandle))
                        {
                            _gdMAIN_VIEW.SetRowCellValue(rowHandle, "DOCUMENT_ID", dtTemp.Rows[a]["DOCUMENT_ID"].ToString());
                            _gdMAIN_VIEW.SetRowCellValue(rowHandle, "DOCUMENT_TYPE", dtTemp.Rows[a]["DOCUMENT_TYPE"].ToString());
                            _gdMAIN_VIEW.SetRowCellValue(rowHandle, "DOCUMENT_NAME", dtTemp.Rows[a]["DOCUMENT_NAME"].ToString());
                            _gdMAIN_VIEW.SetRowCellValue(rowHandle, "DOCUMENT_VER", dtTemp.Rows[a]["DOCUMENT_VER"].ToString());
                        }
                    }
                }
            }

            _gdMAIN_VIEW.UpdateCurrentRow();

        }
    }
}

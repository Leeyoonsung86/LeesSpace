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
using CoFAS_MES.CORE.Entity;
using CoFAS_MES.CORE.Function;

using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Reflection;
using DevExpress.XtraEditors;
using CoFAS_MES.CORE.BaseControls;

namespace CoFAS_MES.CORE.UserForm
{
    public partial class frmPageSetting : frmBaseSingle
    {

        //private string strCORP_CODE = "";
        private string strUSER_CODE = "";
        private string strPARENT_WINDOW_NAME = "";
        private string strPARENT_LANGUAGE = "";

        private Font fntPARENT_FONT = null;

        private string _pWINDOW_NAME = "";

        private bool isRESULT = false;

        private WindowPageSettingEntity _pWindowPageSettingEntity = null; // 엔티티 생성

        private DataTable _dtList = null; //조회 데이터 리스트

        private DataTable dtMessage = null; // 화면별 메세지 관리 데이터 테이블

        private bool _pFirstYN = true; // 최초실행여부 최초 설정 에서만 사용

        //공통 메시지 영역 
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
        private string _pMSG_CHECK_VALID_ITEM = string.Empty;    //필수항목을 확인해주시기 바랍니다. 

        //public string PASS_CORP_CODE
        //{
        //    get { return this.strCORP_CODE; }
        //    set { this.strCORP_CODE = value; }
        //}
        public string PASS_USER_CODE
        {
            get { return this.strUSER_CODE; }
            set { this.strUSER_CODE = value; }
        }
        public string PASS_PARENT_WINDOW_NAME
        {
            get { return this.strPARENT_WINDOW_NAME; }
            set { this.strPARENT_WINDOW_NAME = value; }
        }
        public string PASS_PARENT_LANGUAGE
        {
            get { return this.strPARENT_LANGUAGE; }
            set { this.strPARENT_LANGUAGE = value; }
        }
        public Font PASS_PARENT_FONT
        {
            get { return this.fntPARENT_FONT; }
            set { this.fntPARENT_FONT = value; }
        }
        public bool PASS_RESULT
        {
            get { return this.isRESULT; }
            set { this.isRESULT = value; }
        }


        public frmPageSetting()
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
                if ((_gdMAIN_VIEW.GridControl != null && CoFAS_ConvertManager.DataTable_FindCount(_gdMAIN_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", "")) ||
                    (_gdSUB_DETAIL_VIEW.GridControl != null && CoFAS_ConvertManager.DataTable_FindCount(_gdSUB_DETAIL_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", "")))
                {
                    if (CoFAS_DevExpressManager.ShowQuestionMessage(string.Format("{0}. {1}", _pMSG_WORKING, _pMSG_EXIT_QUESTION)) == DialogResult.No)
                    {
                        pFormClosingEventArgs.Cancel = true;
                        return;
                    }
                }
                pFormClosingEventArgs.Cancel = false;
                isRESULT = true;
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
                WindowName = strPARENT_WINDOW_NAME;

                Child_Page_Setting_Visible = false;

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
        #endregion

        // 초기화 처리 영역
        #region ○ 메뉴 초기화 하기 - InitializeSetting()

        private void InitializeSetting()
        {
            try
            {
                //상속 화면 패널 사용 유무

                //메인 화면 전역 변수 처리
                _pWINDOW_NAME = this.Name;

                //메뉴 화면 엔티티 설정
                _pWindowPageSettingEntity = new WindowPageSettingEntity();
                //_pWindowPageSettingEntity.CORP_CODE = strCORP_CODE;
                _pWindowPageSettingEntity.USER_CODE = strUSER_CODE;
                _pWindowPageSettingEntity.WINDOW_NAME = strPARENT_WINDOW_NAME;
                _pWindowPageSettingEntity.LANGUAGE_TYPE = strPARENT_LANGUAGE;

                
                //추가 메세지 정보 조회.
                dtMessage = new MessageBusiness().MessageValue_Mst_Info(strPARENT_LANGUAGE, _pWINDOW_NAME);

                if (dtMessage != null && dtMessage.Rows[0][0].ToString() != "")
                {
                    //메인 화면 공통 메세지 처리
                    _pMSG_SEARCH = dtMessage.Rows[0]["MSG_SEARCH"].ToString();
                    _pMSG_SEARCH_EMPT = dtMessage.Rows[0]["MSG_SEARCH_EMPT"].ToString();
                    _pMSG_SAVE_QUESTION = dtMessage.Rows[0]["MSG_SAVE_QUESTION"].ToString();
                    _pMSG_SAVE = dtMessage.Rows[0]["MSG_SAVE"].ToString();
                    _pMSG_SAVE_ERROR = dtMessage.Rows[0]["MSG_SAVE_ERROR"].ToString();
                    _pMSG_DELETE_QUESTION = dtMessage.Rows[0]["MSG_DELETE_QUESTION"].ToString();
                    _pMSG_DELETE = dtMessage.Rows[0]["MSG_DELETE"].ToString();
                    _pMSG_DELETE_ERROR = dtMessage.Rows[0]["MSG_DELETE_ERROR"].ToString();
                    _pMSG_DELETE_COMPLETE = dtMessage.Rows[0]["MSG_DELETE_COMPLETE"].ToString();
                    _pMSG_INPUT_DATA = dtMessage.Rows[0]["MSG_INPUT_DATA"].ToString();
                    _pMSG_INPUT_DATA_ERROR = dtMessage.Rows[0]["MSG_INPUT_DATA_ERROR"].ToString();
                    _pMSG_WORKING = dtMessage.Rows[0]["MSG_WORKING"].ToString();
                    _pMSG_RESET_QUESTION = dtMessage.Rows[0]["MSG_RESET_QUESTION"].ToString();
                    _pMSG_EXIT_QUESTION = dtMessage.Rows[0]["MSG_EXIT_QUESTION"].ToString();
                    _pMSG_SELECT = dtMessage.Rows[0]["MSG_SELECT"].ToString();
                    _pMSG_RESET_COMPLETE = dtMessage.Rows[0]["MSG_RESET_COMPLETE"].ToString();
                    _pMSG_CHECK_VALID_ITEM = dtMessage.Rows[0]["MSG_CHECK_VALID_ITEM"].ToString();
                }


                //화면 설정 언어 & 명칭 변경.
                DataTable dtLanguage = new LanguageBusiness().Language_Info(_pWINDOW_NAME, strPARENT_LANGUAGE);

                if (dtLanguage != null && dtLanguage.Rows.Count > 0)
                {
                    CoFAS_ControlManager.Language_Info(dtLanguage, this);
                }

                //메인 화면 공용 버튼 설정

                //그리드 설정
                InitializeGrid();

                //화면 컨트롤러 설정
                InitializeControl();


                ControlMainFind_DisplayData(); //데브 그리드 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈(Empt) 데이터 테이블을 바인딩 해야 됨.

                if (_pFirstYN)
                {
                    GridMainFind_DisplayData(); //데브 그리드 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈(Empt) 데이터 테이블을 바인딩 해야 됨.
                    _pFirstYN = false;
                }

                _pWindowPageSettingEntity.GRID_NAME = "";
                _pWindowPageSettingEntity.CRUD = "";
                GridSubFind_DisplayData(); //데브 그리드 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈(Empt) 데이터 테이블을 바인딩 해야 됨.

                _tabbedControl.SelectedTabPageIndex = 0;

                _gdSUB_MST_VIEW.RowCellClick += _gdSUB_MST_VIEW_RowCellClick;



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
                _gdMAIN_VIEW = Grid_Setting(_gdMAIN, _gdMAIN_VIEW, "_gdMAIN", strPARENT_LANGUAGE);

                if (_pFirstYN)
                {
                    _gdSUB_MST_VIEW = Grid_Setting(_gdSUB_MST, _gdSUB_MST_VIEW, "_gdSUB_MST", strPARENT_LANGUAGE);
                }

                _gdSUB_DETAIL_VIEW = Grid_Setting(_gdSUB_DETAIL, _gdSUB_DETAIL_VIEW, "_gdSUB_DETAIL", strPARENT_LANGUAGE);
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        private GridView Grid_Setting(GridControl _gd, GridView _gv, string strGD_NAME, string strLANGUAGE)
        {
            // 메인 그리드 설정
            DataSet dsGridSetting = null;
            Font fntHeader = new Font(fntPARENT_FONT.FontFamily, fntPARENT_FONT.Size+2, FontStyle.Bold);
            Font fntRow = fntPARENT_FONT;
            //CoFAS_DevExpressManager.pCORP_CODE = strCORP_CODE;

            GridControl _Grid_Control = _gd;
            GridView _Grid_View = _gv;

            dsGridSetting = new DevGridSettingBusiness().DevGrid_Info(strLANGUAGE, _pWINDOW_NAME, strGD_NAME); //그리드 설정 조회

            _Grid_Control.ForceInitialize();

            if (dsGridSetting != null && dsGridSetting.Tables.Count > 0 && dsGridSetting.Tables[0].Rows.Count > 0)
            {
                CoFAS_DevExpressManager.SetGridControl(_Grid_Control, dsGridSetting.Tables[0].Rows[0]["GRID_NAME"].ToString(), false); //조회 데이터 기준 그리드 컨트롤러 설정

                _Grid_View = CoFAS_DevExpressManager.GetGridSetting(dsGridSetting, fntHeader, fntRow, strLANGUAGE); // 그리드 뷰 and 컬럼 설정

                CoFAS_DevExpressManager.AddView(_Grid_Control, _Grid_View, true); // 그리드 컨트롤러 에 메인 뷰 설정

                _Grid_View.BestFitColumns();
            }

            new CoFAS_DevGridEventManager(_Grid_Control, "");

            return _Grid_View;
        }


        #endregion

        #region ○ 컨트롤 초기화 - InitializeControl()

        private void InitializeControl()
        {
            try
            {
                //조회조건 영역 

                //데이터 영역

                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화

                _gdMAIN.DataSource = null;

                if (_pFirstYN)
                {
                    _gdSUB_MST.DataSource = null;
                }

                _gdSUB_DETAIL.DataSource = null;
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
        private void _gdSUB_MST_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;

                CoFAS_ControlManager.Controls_Binding(gv, false, this);

                _pWindowPageSettingEntity.GRID_NAME = gv.GetFocusedRowCellValue("GRID_NAME").ToString();

                _pWindowPageSettingEntity.CRUD = "R";

                GridSubFind_DisplayData();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion

        private void _btSEARCH_CONTROLS_Click(object sender, EventArgs e)
        {
            //_pWindowPageSettingEntity.CRUD = "R";
            //ControlMainFind_DisplayData();
        }
        private void _btSAVE_CONTROLS_Click(object sender, EventArgs e)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                DataTable dtTemp = null;

                bool isChack = CoFAS_ConvertManager.DataTable_FindCount(_gdMAIN_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", "");

                if (isChack)
                {
                    dtTemp = CoFAS_ConvertManager.DataTable_FindValue(_gdMAIN_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", "");
                }
                else
                {
                    return;
                }


                //DataTable dtTemp = CoFAS_ConvertManager.DataTable_FindValue(_gdMAIN_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", ""); // 신규 and 수정 항목 데이터 테이블 화

                if (dtTemp.Rows.Count > 0)
                {
                    Controls_InputData_Save(dtTemp);
                }
                else
                {

                    //CoFAS_DevExpressManager.ShowInformationMessage("입력 된 저장 항목이 없습니다.");
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
        private void _btSAVE_GRID_Click(object sender, EventArgs e)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                DataTable dtTemp = null;

                bool isChack = CoFAS_ConvertManager.DataTable_FindCount(_gdSUB_DETAIL_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", "");

                if (isChack)
                {
                    dtTemp = CoFAS_ConvertManager.DataTable_FindValue(_gdSUB_DETAIL_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", "");
                }
                else
                {
                    return;
                }

               // DataTable dtTemp = CoFAS_ConvertManager.DataTable_FindValue(_gdSUB_DETAIL_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", ""); // 신규 and 수정 항목 데이터 테이블 화

                if (dtTemp.Rows.Count > 0)
                {
                    Grid_InputData_Save(dtTemp);
                }
                else
                {
                   // CoFAS_DevExpressManager.ShowInformationMessage("입력 된 저장 항목이 없습니다.");
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
        private void _btSEARCH_GRID_Click(object sender, EventArgs e)
        {
            //_pWindowPageSettingEntity.CRUD = "R";
            //GridMainFind_DisplayData();
        }
        private void _btCLOSE_Click(object sender, EventArgs e)
        {
            //그리드 작업 정보 확인 하기
            //if ((_gdMAIN_VIEW.GridControl != null && CoFAS_ConvertManager.DataTable_FindCount(_gdMAIN_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", "")) ||
            //    (_gdSUB_DETAIL_VIEW.GridControl != null && CoFAS_ConvertManager.DataTable_FindCount(_gdSUB_DETAIL_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", "")))
            //{
            //    if (CoFAS_DevExpressManager.ShowQuestionMessage("작업중인 자료가 있습니다.\n종료 하겠습니까?") == DialogResult.No)
            //    {
            //        return;
            //    }
            //}

            //isRESULT = true;

            Close();
        }

        // DB 처리
        #region ○ 컨트롤러 조회 - ControlMainFind_DisplayData()

        private void ControlMainFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _dtList = new WindowPageSettingBusiness().Controls_Info(_pWindowPageSettingEntity);

                if (_pWindowPageSettingEntity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pWindowPageSettingEntity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList);
                }
                else
                {
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));

                //throw pExceptionManager;

            }
            //catch (Exception pException)
            //{
            //    throw new ExceptionManager(this, "InputData_Save(DataTable dtSave)", pException);
            //}
            finally
            {
                _gdMAIN_VIEW.BestFitColumns();

                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }

        #endregion

        #region ○ 그리드 마스터 조회 - GridMainFind_DisplayData()

        private void GridMainFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _dtList = new WindowPageSettingBusiness().Grid_MST_Info(_pWindowPageSettingEntity);

                if (_pWindowPageSettingEntity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pWindowPageSettingEntity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB_MST, _gdSUB_MST_VIEW, _dtList);
                }
                else
                {
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {
                _gdSUB_MST_VIEW.BestFitColumns();

                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }

        #endregion

        #region ○ 그리드 상세 조회 - GridSubFind_DisplayData()

        private void GridSubFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _dtList = new WindowPageSettingBusiness().Grid_Detail_Info(_pWindowPageSettingEntity);

                if (_pWindowPageSettingEntity.CRUD == "") _dtList.Rows.Clear();


                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pWindowPageSettingEntity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB_DETAIL, _gdSUB_DETAIL_VIEW, _dtList);
                }
                else
                {
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {
                _gdSUB_DETAIL_VIEW.BestFitColumns();

                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }

        #endregion

        #region ○ 저장 - Controls_InputData_Save(DataTable dtSave)
        private void Controls_InputData_Save(DataTable dtSave)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                bool isError = false;


                isError = new WindowPageSettingBusiness().Controls_Info_Save(_pWindowPageSettingEntity, dtSave);

                if (isError)
                {
                    //오류 발생.
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                    //화면 표시.

                }
                else
                {
                    //정상 처리
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);

                    _pWindowPageSettingEntity.CRUD = "R";
                    ControlMainFind_DisplayData();
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

        #region ○ 저장 - Grid_InputData_Save(DataTable dtSave)
        private void Grid_InputData_Save(DataTable dtSave)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                bool isError = false;

                isError = new WindowPageSettingBusiness().Grid_Info_Save(_pWindowPageSettingEntity, dtSave);

                if (isError)
                {
                    //오류 발생.
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                    //화면 표시.

                }
                else
                {
                    //정상 처리
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);

                    _pWindowPageSettingEntity.CRUD = "R";

                    GridSubFind_DisplayData();
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

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
using CoFAS_MES.CORE.Function;
using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.Entity;

using CoFAS_MES.POP.Business;
using CoFAS_MES.POP.Data;
using CoFAS_MES.POP.Entity;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System.IO.Ports;

namespace CoFAS_MES.POP
{
    public partial class frmPOPMain_MATERIAL_COSMETICS : frmBasePOP
    {
        public string _pCORP_CDDE = string.Empty;       // 회사코드       
        public string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        public string _pUSER_NAME = string.Empty;       // 사용자이름
        public string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어
        public string _pWINDOW_NAME = string.Empty;     // 화면 명칭
        public string _pFONT_TYPE = string.Empty;       // 시스템 폰트 타입 설정
        public int _pFONT_SIZE = 9;                     // 시스템 폰트 사이즈 설정 기본 9
        private Font _pFONT_SETTING = null;             // 시스템 폰트 설정
        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용
        private bool _pINSPECT_CHECK_YN = false;        // 중복 시험의뢰 방지
        private bool _pPART_STOCK_YN = false;        // 재고확인용 바코드 스캔

        private string _pTERMINAL_CODE = string.Empty; //단말기코드 : TP010003(구)  / TP010006(신규)

        private DataTable _dtList = null; //조회 데이터 리스트
        private DataTable _rt_dtList = null; //조회 데이터 리스트

        private string _pLocation_Code = string.Empty;  // 저장/수정 후 로케이션 위치 저장
        private bool _pLocation_YN = true;              // 저장위치 사용여부

        private string[] PC_serial_port = SerialPort.GetPortNames();
        private string COM_PORT2 = string.Empty; //저울 포트

        private CoFAS_Serial _pBarcode_Serial1 = null;  // 바코드 시리얼 생성
        private CoFAS_Serial _pBarcode_Serial2 = null;  // 바코드 시리얼 생성
        private string COM_PORT = string.Empty;
        private string PORT_CHK = string.Empty;

        private static string _pPROCESS_CODE_MST = string.Empty;     // 공정코드
        public static string PROCESS_CODE_MST
        {
            get { return _pPROCESS_CODE_MST; }
            set { _pPROCESS_CODE_MST = value; }
        }
        private frmPOPMain_WEIGHING_COSMETICSEntity pfrmPOPMain_WEIGHING_COSMETICSEntity = null;
        public UserEntity _pUserEntity = null;
        public MessageEntity _pMessageEntity = null; //공통 메세지 엔티티
        private frmPOPMain_MATERIAL_COSMETICSEntity _pfrmPOPMain_MATERIAL_COSMETICSEntity = null; // 엔티티 생성

        public frmPOPMain_MATERIAL_COSMETICS(UserEntity pUserEntity)
        {
            InitializeComponent();

            _pUserEntity = pUserEntity;

            _pUSER_CODE = _pUserEntity.USER_CODE;
            _pUSER_NAME = _pUserEntity.USER_NAME;
            //_pTERMINAL_CODE = _pfrmPOPMain_MATERIAL_COSMETICSEntity.TERMINAL_CODE;
            _pPROCESS_CODE_MST = "PC02";

            _pMessageEntity = new MessageEntity();

            _pFONT_SETTING = new Font(_pUserEntity.FONT_TYPE, _pUserEntity.FONT_SIZE);

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
                //pFormClosingEventArgs.Cancel = false;
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
                Initialize();
                InitializeSetting();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion

        // 초기화 처리 영역
        private void Initialize()
        {
            try
            {
                switch (Properties.Settings.Default.DB_ID.ToString())
                {
                    case "MySql":
                        DBManager.PrimaryDBManagerType = DBManagerType.MySql;//.SQLServer;
                        break;
                    case "SQLServer":
                        DBManager.PrimaryDBManagerType = DBManagerType.SQLServer;//.SQLServer;
                        break;
                    default:
                        DBManager.PrimaryDBManagerType = DBManagerType.MySql;//.SQLServer;
                        break;
                }

                DBManager.PrimaryConnectionString = string.Format
               (
                   //"location = {0}; user id = {1}; password = {2}; data source = {3}",
                   "Server={0};Database={1};UID={2};PWD={3}",
                   Properties.Settings.Default.SERVER_IP.ToString(),
                   Properties.Settings.Default.DB_NAME.ToString(),
                   Properties.Settings.Default.DB_ID.ToString(),
                   "0we11Passw0rd!@#dbmes"
               );

            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Initialize()", pException);
            }
        }

        #region ○ 메뉴 초기화 하기 - InitializeSetting()

        private void InitializeSetting()
        {
            try
            {
                //상속 화면 패널 사용 유무
                _pnRight.Visible = false;

                //메인 화면 전역 변수 처리
                _pCORP_CDDE = "9999999999";//MainForm.UserEntity.CORP_CODE;
                _pUSER_CODE = "admin@coever.co.kr";// MainForm.UserEntity.USER_CODE;
                _pUSER_NAME = "";//MainForm.UserEntity.USER_NAME;
                //_pLANGUAGE_TYPE = MainForm.UserEntity.LANGUAGE_TYPE;
                //_pFONT_TYPE = MainForm.UserEntity.FONT_TYPE;

                _pWINDOW_NAME = this.Name;
                _pLANGUAGE_TYPE = _pUserEntity.LANGUAGE_TYPE;
                _pfrmPOPMain_MATERIAL_COSMETICSEntity = new frmPOPMain_MATERIAL_COSMETICSEntity();
                _pfrmPOPMain_MATERIAL_COSMETICSEntity.CORP_CODE = _pCORP_CDDE;
                _pfrmPOPMain_MATERIAL_COSMETICSEntity.USER_CODE = _pUSER_CODE;
                _pfrmPOPMain_MATERIAL_COSMETICSEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                _pfrmPOPMain_MATERIAL_COSMETICSEntity.TERMINAL_CODE = "TP010001";
                _lbTitle.Text = _pUserEntity.POP_TITLE;
                _lbHeader.Text = "";
                DisplayMessage("");


                //메뉴 화면 엔티티 설정
                //_pDQGatheringEntity = new DQGatheringEntity();
                //_pDQGatheringEntity.CORP_CODE = _pCORP_CDDE;
                //_pDQGatheringEntity.USER_CODE = _pUSER_CODE;

                //화면 설정 언어 & 명칭 변경.
                DataTable dtLanguage = new LanguageBusiness().Language_Info(_pWINDOW_NAME, _pLANGUAGE_TYPE);

                if (dtLanguage != null && dtLanguage.Rows.Count > 0)
                {
                    CoFAS_ControlManager.Language_Info(dtLanguage, this);
                }
                //화면 설정 언어 & 명칭 변경. ==고정==


                //그리드 설정
                InitializeGrid();
                //   double ddd = Math.Acos(0.912);
                // _gdMAIN_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdMAIN, _gdMAIN_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdMAIN.Name.ToString()));
                // _gdSUB_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB, _gdSUB_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdSUB.Name.ToString()));

                // _gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick; ;


                //화면 컨트롤러 설정
                InitializeControl();

                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                if (_pFirstYN)
                {

                    _pFirstYN = false;
                }
                GetBarcodeComPort();
                MainFind_DisplayData();
                // H/W 연결 설정
                SetHardware1();

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        private void InitializeGrid()
        {
            try
            {
                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                if (_pFirstYN)
                {

                    _gdMAIN_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdMAIN, _gdMAIN_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdMAIN.Name.ToString()));
                    _gdMAIN_VIEW2 = CoFAS_DevExpressManager.Grid_Setting(_gdMAIN2, _gdMAIN_VIEW2, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdMAIN2.Name.ToString()));
                    _gdMAIN_VIEW3 = CoFAS_DevExpressManager.Grid_Setting(_gdMAIN3, _gdMAIN_VIEW3, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdMAIN3.Name.ToString()));
                    _gdSUB_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB, _gdSUB_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdSUB.Name.ToString()));
                    //  _gdSUB_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB, _gdSUB_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdSUB.Name.ToString()));

                    _gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick;

                    _gdMAIN_VIEW3.RowCellClick += _gdMAIN_VIEW3_RowCellClick;
                }

                //_gdSUB_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB, _gdSUB_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pWINDOW_NAME, _gdSUB.Name.ToString()));
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        private void _gdMAIN_VIEW_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;

                CoFAS_ControlManager.Controls_Binding(gv, false, this);

                string strPART_CODE = gv.GetFocusedRowCellValue("PART_CODE").ToString();
                //  string strPART_TYPE = gv.GetFocusedRowCellValue("PART_TYPE").ToString();
                string strCRUD = "R";
                _pfrmPOPMain_MATERIAL_COSMETICSEntity.INOUT_ID = gv.GetFocusedRowCellValue("INOUT_ID").ToString();
                _pfrmPOPMain_MATERIAL_COSMETICSEntity.ORDER_ID = gv.GetFocusedRowCellValue("ORDER_ID").ToString();
                _pfrmPOPMain_MATERIAL_COSMETICSEntity.PART_CODE = gv.GetFocusedRowCellValue("PART_CODE").ToString();
                _pfrmPOPMain_MATERIAL_COSMETICSEntity.PART_NAME = gv.GetFocusedRowCellValue("PART_NAME").ToString();
                _pfrmPOPMain_MATERIAL_COSMETICSEntity.IN_QTY = gv.GetFocusedRowCellValue("IN_QTY").ToString();

                _pINSPECT_CHECK_YN = false;
                if (gv.GetFocusedRowCellValue("INSPECT_STATUS").ToString() != "QC010001")
                {
                    if (gv.GetFocusedRowCellValue("INSPECT_STATUS").ToString() != "")
                    {
                        _pINSPECT_CHECK_YN = true;
                    }
                }

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        private void _gdMAIN_VIEW3_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;

                CoFAS_ControlManager.Controls_Binding(gv, false, this);

                string strPART_CODE = gv.GetFocusedRowCellValue("PART_CODE").ToString();
                //  string strPART_TYPE = gv.GetFocusedRowCellValue("PART_TYPE").ToString();
                string strCRUD = "R";
                // decimal pQTY = Convert.ToDecimal(gv.GetFocusedRowCellValue("CONTRACT_QTY").ToString());
                _pfrmPOPMain_MATERIAL_COSMETICSEntity.PART_CODE = gv.GetFocusedRowCellValue("PART_CODE").ToString();
                _gdSUB.DataSource = null;
                SubFind_DisplayData(strCRUD, strPART_CODE);
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }


        #region ○ 서브조회 - SubFind_DisplayData()
        //(string pCRUD, string pPART_CODE, string pPART_NAME)
        private void SubFind_DisplayData(string strCRUD, string strPART_CODE)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _dtList = new frmPOPMain_MATERIAL_COSMETICSBusiness().frmPOPMain_MATERIAL_COSMETICS_Sub_Return(strCRUD, strPART_CODE).Tables[0];

                if (strCRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && strCRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB, _gdSUB_VIEW, _dtList);
                    _gdSUB_VIEW.RowCellStyle += new RowCellStyleEventHandler(gdSUB_VIEW_RowCellStyle);
                }
                else
                {
                    // CoFAS_DevExpressManager.BindGridControl(_gdVEND, _gdVEND_VIEW, null);
                    //_gdSUB.DataSource = null;
                    CoFAS_ControlManager.InvokeIfNeeded(_gdSUB, () => _gdSUB.DataSource = null);
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {
                //_gdSUB_VIEW.BestFitColumns();
                CoFAS_ControlManager.InvokeIfNeeded(_gdSUB, () => _gdSUB_VIEW.BestFitColumns());

                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }


        #endregion

        #region ○ 메인조회 - MainFind_DisplayData()

        private void MainFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                // _pfrmPOPMain_MATERIAL_COSMETICSEntity = new frmPOPMain_MATERIAL_COSMETICSEntity();
                _pfrmPOPMain_MATERIAL_COSMETICSEntity.CRUD = "R";
                _dtList = new frmPOPMain_MATERIAL_COSMETICSBusiness().frmPOPMain_MATERIAL_COSMETICS_Info(_pfrmPOPMain_MATERIAL_COSMETICSEntity);
                //  _dtList = new frmPOPMain_MATERIAL_COSMETICSBusiness().frmPOPMain_MATERIAL_COSMETICS_Info(_pCRUD, FromDATE, ToDATE, strCODE, strNAME).Tables[0];
                if (_pfrmPOPMain_MATERIAL_COSMETICSEntity.CRUD == "") _dtList.Rows.Clear();

               
                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pfrmPOPMain_MATERIAL_COSMETICSEntity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩
                    _gdMAIN_VIEW.RowHeight = 40;
                    _gdMAIN_VIEW.Appearance.Row.Font = new Font("굴림", 10);
                    _gdMAIN_VIEW.RowStyle += new RowStyleEventHandler(gdMAIN_VIEW_RowStyle);

                    //  _gdMAIN_VIEW.RowHeight = 40;
                    //  _gdMAIN_VIEW.Appearance.Row.Font = new Font("굴림", 10);
                    //  _gdMAIN_VIEW.RowCellStyle += new RowCellStyleEventHandler(gdMAIN_VIEW_RowCellStyle);
                    //_gdMAIN_VIEW.Appearance.SelectedRow.Options.UseBackColor = true;
                    //_gdMAIN_VIEW.OptionsSelection.EnableAppearanceFocusedRow = true;
                    //_gdMAIN_VIEW.OptionsView.EnableAppearanceEvenRow = true;
                    //_gdMAIN_VIEW.Appearance.EvenRow.BackColor = Color.Red;

                    //_gdMAIN_VIEW.OptionsSelection.MultiSelect = true;
                    //_gdMAIN_VIEW.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;

                    _gdMAIN_VIEW.Appearance.FocusedRow.BackColor = Color.Red;


                    //_gdMAIN_VIEW.Appearance.SelectedRow.Options.UseBackColor = true;
                    //_gdMAIN_VIEW.Appearance.SelectedRow.BackColor = Color.LightSeaGreen;

                }
                else
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
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

        //작업지시 생산출고
        private void MainFind_DisplayData2()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                //  _pfrmPOPMain_MATERIAL_COSMETICSEntity = new frmPOPMain_MATERIAL_COSMETICSEntity();
                _pfrmPOPMain_MATERIAL_COSMETICSEntity.CRUD = "R";

                _pfrmPOPMain_MATERIAL_COSMETICSEntity.LANGUAGE_TYPE = _pUserEntity.LANGUAGE_TYPE;
                _pfrmPOPMain_MATERIAL_COSMETICSEntity.PROCESS_CODE = _pUserEntity.PROCESS_CODE;
                _pfrmPOPMain_MATERIAL_COSMETICSEntity.RESOURCE_CODE = _pUserEntity.RESOURCE_CODE;
                //_pfrmPOPMain_MATERIAL_COSMETICSEntity.PRODUCTION_ORDER_ID = _pfrmPOPMain_MATERIAL_COSMETICSEntity.PRODUCTION_ORDER_ID;// _luORDER_DATE.Text;
                //_pfrmPOPMain_MATERIAL_COSMETICSEntity.PRODUCTION_ORDER_QTY = _pfrmPOPMain_MATERIAL_COSMETICSEntity.PRODUCTION_ORDER_ID;// _luORDER_DATE.Text;

                _dtList = new frmPOPMain_MATERIAL_COSMETICSBusiness().frmPOPMain_MATERIAL_COSMETICS_Info2(_pfrmPOPMain_MATERIAL_COSMETICSEntity);
                //  _dtList = new frmPOPMain_MATERIAL_COSMETICSBusiness().frmPOPMain_MATERIAL_COSMETICS_Info(_pCRUD, FromDATE, ToDATE, strCODE, strNAME).Tables[0];
                if (_pfrmPOPMain_MATERIAL_COSMETICSEntity.CRUD == "") _dtList.Rows.Clear();


                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pfrmPOPMain_MATERIAL_COSMETICSEntity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN2, _gdMAIN_VIEW2, _dtList); //데이터 필드에 맞춰 자동 바인딩
                    _gdMAIN_VIEW2.RowHeight = 40;
                    _gdMAIN_VIEW2.Appearance.Row.Font = new Font("굴림", 10);
                    _gdMAIN_VIEW2.RowStyle += new RowStyleEventHandler(gdMAIN_VIEW_RowStyle);
                    _pfrmPOPMain_MATERIAL_COSMETICSEntity.ORDER_FILE = _dtList.Rows[0]["ORDER_FILE"].ToString();
                    //  _gdMAIN_VIEW.RowHeight = 40;
                    //  _gdMAIN_VIEW.Appearance.Row.Font = new Font("굴림", 10);
                    //  _gdMAIN_VIEW.RowCellStyle += new RowCellStyleEventHandler(gdMAIN_VIEW_RowCellStyle);
                    //_gdMAIN_VIEW.Appearance.SelectedRow.Options.UseBackColor = true;
                    //_gdMAIN_VIEW.OptionsSelection.EnableAppearanceFocusedRow = true;
                    //_gdMAIN_VIEW.OptionsView.EnableAppearanceEvenRow = true;
                    //_gdMAIN_VIEW.Appearance.EvenRow.BackColor = Color.Red;

                    //_gdMAIN_VIEW.OptionsSelection.MultiSelect = true;
                    //_gdMAIN_VIEW.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;

                    _gdMAIN_VIEW2.Appearance.FocusedRow.BackColor = Color.Red;


                    //_gdMAIN_VIEW.Appearance.SelectedRow.Options.UseBackColor = true;
                    //_gdMAIN_VIEW.Appearance.SelectedRow.BackColor = Color.LightSeaGreen;

                }
                else
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
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

        private void MainFind_DisplayData3()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                //  _pfrmPOPMain_MATERIAL_COSMETICSEntity = new frmPOPMain_MATERIAL_COSMETICSEntity();
                _pfrmPOPMain_MATERIAL_COSMETICSEntity.CRUD = "R";

                _pfrmPOPMain_MATERIAL_COSMETICSEntity.LANGUAGE_TYPE = _pUserEntity.LANGUAGE_TYPE;
                _dtList = new frmPOPMain_MATERIAL_COSMETICSBusiness().frmPOPMain_MATERIAL_COSMETICS_Info3(_pfrmPOPMain_MATERIAL_COSMETICSEntity);
                //  _dtList = new frmPOPMain_MATERIAL_COSMETICSBusiness().frmPOPMain_MATERIAL_COSMETICS_Info(_pCRUD, FromDATE, ToDATE, strCODE, strNAME).Tables[0];
                if (_pfrmPOPMain_MATERIAL_COSMETICSEntity.CRUD == "") _dtList.Rows.Clear();

                _gdSUB.DataSource = null;

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pfrmPOPMain_MATERIAL_COSMETICSEntity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN3, _gdMAIN_VIEW3, _dtList); //데이터 필드에 맞춰 자동 바인딩
                    _gdMAIN_VIEW3.RowHeight = 40;
                    _gdMAIN_VIEW3.Appearance.Row.Font = new Font("굴림", 10);
                    _gdMAIN_VIEW3.RowStyle += new RowStyleEventHandler(gdMAIN_VIEW_RowStyle);
                   // _pfrmPOPMain_MATERIAL_COSMETICSEntity.ORDER_FILE = _dtList.Rows[0]["ORDER_FILE"].ToString();
                    //  _gdMAIN_VIEW.RowHeight = 40;
                    //  _gdMAIN_VIEW.Appearance.Row.Font = new Font("굴림", 10);
                    //  _gdMAIN_VIEW.RowCellStyle += new RowCellStyleEventHandler(gdMAIN_VIEW_RowCellStyle);
                    //_gdMAIN_VIEW.Appearance.SelectedRow.Options.UseBackColor = true;
                    //_gdMAIN_VIEW.OptionsSelection.EnableAppearanceFocusedRow = true;
                    //_gdMAIN_VIEW.OptionsView.EnableAppearanceEvenRow = true;
                    //_gdMAIN_VIEW.Appearance.EvenRow.BackColor = Color.Red;

                    //_gdMAIN_VIEW.OptionsSelection.MultiSelect = true;
                    //_gdMAIN_VIEW.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;

                    _gdMAIN_VIEW3.Appearance.FocusedRow.BackColor = Color.Red;


                    //_gdMAIN_VIEW.Appearance.SelectedRow.Options.UseBackColor = true;
                    //_gdMAIN_VIEW.Appearance.SelectedRow.BackColor = Color.LightSeaGreen;

                }
                else
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
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
        private void gdMAIN_VIEW_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Column != view.Columns["INPUT_QTY"])
                return;

            e.Appearance.BackColor = Color.LightSkyBlue;
            e.Appearance.Font = new Font("굴림", 10, FontStyle.Bold);
        }

        private void gdMAIN_VIEW_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            // if (((e.State & DevExpress.XtraGrid.Views.Base.GridRowCellState.Focused) != 0) && ((e.State & DevExpress.XtraGrid.Views.Base.GridRowCellState.GridFocused) != 0))
            //     e.Appearance.Assign(view.PaintAppearance.FocusedRow);
            if (view.FocusedRowHandle == e.RowHandle)
            {
                e.Appearance.BackColor = Color.Orange;
                e.Appearance.Font = new Font("굴림", 10, FontStyle.Bold);
            }
        }

        private void gdSUB_VIEW_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;

            if (view.FocusedRowHandle == e.RowHandle)
            {
                e.Appearance.BackColor = Color.Orange;
                e.Appearance.Font = new Font("굴림", 10, FontStyle.Bold);

                //if (e.Column != view.Columns["INPUT_QTY"])
                //    return;

                e.Appearance.BackColor = Color.LightSkyBlue;
                e.Appearance.Font = new Font("굴림", 10, FontStyle.Bold);

            }

            /*
            if (e.Column != view.Columns["INPUT_QTY"])
                return;
            
                e.Appearance.BackColor = Color.LightSkyBlue;
                e.Appearance.Font = new Font("굴림", 10, FontStyle.Bold);
                */

        }


        #endregion
        #region ○ 컨트롤 초기화 - InitializeControl()

        private void InitializeControl()
        {
            try
            {
                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
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


        #region ○ 버튼 클릭시

        private void btnCmd_Click(object pSender, EventArgs pEventArgs)
        {

        }

        #endregion


       
        private void GetBarcodeComPort()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _dtList = new BarcodeLabelPrintBusiness().BarcodeLabelPrint_COM_Info(_pfrmPOPMain_MATERIAL_COSMETICSEntity.LANGUAGE_TYPE, _pfrmPOPMain_MATERIAL_COSMETICSEntity.TERMINAL_CODE);
                _rt_dtList = _dtList;
                COM_PORT = "";

                if (_dtList != null && _dtList.Rows.Count > 0)//&& _dtList.Rows.Count > 0) )|| (_dtList != null && _pBarcodeLabelPrintEntity.CRUD == ""))
                {
                    //  CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩

                    //조회 후 초기화 
                    COM_PORT = _dtList.Rows[0]["COM_PORT"].ToString();
                    // COM_PORT2 = _dtList.Rows[1]["COM_PORT"].ToString(); //저울 포트
                    // 연결 표기 부분 초기화
                    //pnlDeviceConnect.Controls.Clear();

                    //for (int i = 0; i < 5; i++)
                    for (int i = 0; i < _rt_dtList.Rows.Count; i++)
                    {
                        LabelControl lc = new LabelControl();
                        lc.Name = "lc_" + _rt_dtList.Rows[i]["PORT_NAME"].ToString().ToString();
                        lc.Font = new Font("Tahoma", 9, FontStyle.Bold); // Font 설정
                                                                         // lc.Text = "프린터" + i.ToString();
                        lc.Text = (_rt_dtList.Rows[i]["PORT_NAME"].ToString() + "_" + _rt_dtList.Rows[i]["COM_PORT"].ToString()).ToString();
                        lc.Padding = new Padding(10, 0, 10, 0);
                        lc.Margin = new Padding(0);
                        lc.Appearance.Image = global::CoFAS_MES.POP.Properties.Resources.plug_Gray;
                        lc.ImageAlignToText = ImageAlignToText.LeftCenter;
                        lc.Dock = DockStyle.Right;


                        pnlDeviceConnect.Controls.Add(lc);

                        DisplayMessage(lc.Text + " OK");

                        DisplayMessage("POP Start Complete");
                    }

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
        #region ○ H/W 세팅시
        //생산출고
        private void SetHardware1()
        {

            try
            {

                /*
                // 연결 표기 부분 초기화
                //pnlDeviceConnect.Controls.Clear();

                // 연결할 H/W 갯수만큼 돌린다. (연동시 변경)
                for (int i = 0; i < 5; i++)
                {
                    LabelControl lc = new LabelControl();
                    lc.Name = "lc_" + i.ToString();
                    lc.Font = new Font("Tahoma", 9, FontStyle.Bold); // Font 설정
                    // lc.Text = "프린터" + i.ToString();
                    lc.Text = (_rt_dtList.Rows[i]["PORT_NAME"].ToString() + "_" + _rt_dtList.Rows[i]["COM_PORT"].ToString()).ToString();
                    lc.Padding = new Padding(10, 0, 10, 0);
                    lc.Margin = new Padding(0);
                    lc.Appearance.Image = global::CoFAS_MES.POP.Properties.Resources.plug_Gray;
                    lc.ImageAlignToText = ImageAlignToText.LeftCenter;
                    lc.Dock = DockStyle.Right;


                    pnlDeviceConnect.Controls.Add(lc);

                    DisplayMessage(lc.Text + " OK");

                    DisplayMessage("POP Start Complete");

                }
                */
                //_pCoFAS_Serial = new CoFAS_Serial(_dtList_terminal.Rows[0]["INFO_PORTNAME"].ToString(), Convert.ToInt32(_dtList_terminal.Rows[0]["INFO_BAUDRATE"].ToString()), _dtList_terminal.Rows[0]["INFO_PARITY"].ToString(), Convert.ToInt32(_dtList_terminal.Rows[0]["INFO_DATABITS"].ToString()), _dtList_terminal.Rows[0]["INFO_STOPBITS"].ToString());
                //_pBarcode_Serial = new CoFAS_Serial("COM3", 9600, "NONE", 8, "ONE");
                /*
                _pBarcode_Serial = new CoFAS_Serial(COM_PORT, 9600, "NONE", 8, "ONE");
                _pBarcode_Serial.Open();
                _pBarcode_Serial.evtReceived += new CoFAS_Serial.delReceive(_Barcode_Received_Data);
                */
                //포트1 : 바코드포트가 존재하는지
                if (Array.Exists(PC_serial_port, port => port == COM_PORT))
                {
                    _pBarcode_Serial1 = new CoFAS_Serial(COM_PORT, 9600, "NONE", 8, "ONE");
                    if (!_pBarcode_Serial1.IsOpen)
                        _pBarcode_Serial1.Open();
                    _pBarcode_Serial1.evtReceived += new CoFAS_Serial.delReceive(_Barcode_Received_Data1);
                }
                if (_pBarcode_Serial1.IsOpen)
                {
                    LabelControl xlb = this.Controls.Find("lc_" + _rt_dtList.Rows[0]["PORT_NAME"].ToString(), true).FirstOrDefault() as LabelControl;
                    xlb.Appearance.Image = global::CoFAS_MES.POP.Properties.Resources.plug_Green;
                }
                else
                {
                    LabelControl xlb = this.Controls.Find("lc_" + _rt_dtList.Rows[0]["PORT_NAME"].ToString(), true).FirstOrDefault() as LabelControl;
                    xlb.Appearance.Image = global::CoFAS_MES.POP.Properties.Resources.plug_Gray;
                }

            }
            catch (Exception ex)
            {
                CoFAS_DevExpressManager.ShowInformationMessage("포트 연결을 실패했습니다.");
               // _pBarcode_Serial1 = new CoFAS_Serial();
            }

        }

        void _Barcode_Received_Data1(byte[] yReceiveData)
        {
            try
            {
                if (yReceiveData.Length > 0)
                {
                    if (!_pPART_STOCK_YN)
                    {
                        string pFindData = string.Empty;
                        string vPart_code = string.Empty;
                        string vMake_no = string.Empty;
                        string vInspect_no = string.Empty;
                        string vVend_Part_Code = string.Empty;
                        string vReference_id = string.Empty;

                        pFindData = CoFAS_ConvertManager.Bytes2String(yReceiveData, 0, 0);
                        pFindData = pFindData.Substring(0, pFindData.Length - 4);//뒤에 개행문자 지울경우(2자리)
                        DataSet pDataSet = new DataSet();
                        pDataSet = new BarcodeLabelPrintBusiness().BarcodeLabelPrint_inspect_Info(_pfrmPOPMain_MATERIAL_COSMETICSEntity.LANGUAGE_TYPE, "DOC", pFindData);
                        _dtList = pDataSet.Tables[0];
                        if (_dtList != null && _dtList.Rows.Count > 0)
                        {
                            vPart_code = _dtList.Rows[0]["part_code"].ToString();
                            vMake_no = _dtList.Rows[0]["make_no"].ToString();
                            vInspect_no = _dtList.Rows[0]["inspect_no"].ToString();
                            vVend_Part_Code = _dtList.Rows[0]["vend_part_code"].ToString();
                            vReference_id = _dtList.Rows[0]["reference_id"].ToString();
                            if (tabcontrol1.TabIndex == 1)//생산출고
                            {
                                //제조
                                if (_pPROCESS_CODE_MST == "PC01")
                                    FindPartCode1(vPart_code, vVend_Part_Code, vInspect_no, vReference_id);
                                else
                                    FindPartCode1(vPart_code, vVend_Part_Code, vMake_no, vReference_id);
                            }
                            if (tabcontrol1.TabIndex == 2)//부자재출고
                            {
                                //제조
                                if (_pPROCESS_CODE_MST == "PC01")
                                    FindPartCode2(vPart_code, vVend_Part_Code, vInspect_no, vReference_id);
                                else
                                    FindPartCode2(vPart_code, vVend_Part_Code, vMake_no, vReference_id);
                            }
                        }
                        else
                        {
                            if (tabcontrol1.TabIndex == 0)//입고 (이벤트x)
                            {
                                CoFAS_DevExpressManager.ShowInformationMessage("등록되지 않은 바코드입니다.");
                            }
                        }

                        //종료시 close시키기
                        //엑셀로 커서가게
                        //바코드세팅 com번호 가져오게하기
                        //기존 USP_BarcodeLabelPrint_R30를 수정하여 같이쓰게 하든가 아니면 별도로 가져오게하기
                        //dispose 예외처리하기
                    }

                    //재고확인
                    else
                    {
                        string pFindData = string.Empty;
                        string vPart_code = string.Empty;
                        string vMake_no = string.Empty;
                        string vInspect_no = string.Empty;
                        string vVend_Part_Code = string.Empty;
                        string vReference_id = string.Empty;

                        _pfrmPOPMain_MATERIAL_COSMETICSEntity.CRUD = "R";
                        _pfrmPOPMain_MATERIAL_COSMETICSEntity.USER_CODE = _pUSER_CODE;
                        //_pPOPSelect_INSPECT_COSMETICSEntity.PART_CODE = _luPART_CODE.Text;
                        pFindData = CoFAS_ConvertManager.Bytes2String(yReceiveData, 0, 0);
                        pFindData = pFindData.Substring(0, pFindData.Length - 4);//뒤에 개행문자 지울경우(2자리)
                        frmPOPPartStockCheck frmkey = new frmPOPPartStockCheck(_pUserEntity);
                        frmkey.titleName = "부자재재고확인";
                        frmkey._pBARCODE_NO = pFindData;// "MI181128000001";

                        // if (_pBarcode_Serial.IsOpen)
                        //     _pBarcode_Serial.Close();

                        if (frmkey.ShowDialog() == DialogResult.OK)
                        {
                            // if (!_pBarcode_Serial.IsOpen)
                            //     _pBarcode_Serial.Open() ;

                            string PopupValue = frmkey.ReturnValue1;        //검체채취량
                            string PopupValue2 = frmkey.ReturnValue2;       //검체채취일
                            

                        }
                    }
                }

                // Application.DoEvents(); //화면초기화
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //품목코드 찾기(저울스캔시)
        //   private void FindPartCode(string pPart_code)
        //   {
        //       IWorkbook workbook = _sdMAIN.Document;
        //       Worksheet sheet_0 = workbook.Worksheets[0];
        //       Range rg;
        //
        //       rg = sheet_0.Range["D11:D42"];    //판정유무
        //
        //       IEnumerable<Cell> searchResult = rg.Search(pPart_code);
        //       foreach (Cell cell in searchResult)
        //       {
        //           sheet_0.Cells[cell.RowIndex, 8].SetValue("450.1");
        //           //cell.RowIndex
        //       }
        //   }

        //품목코드 찾기(저울스캔시) 
        private void FindPartCode1(string pPart_code, string pVend_Part_code, string make_inspect_code, string pReference_id)
        {
            bool find_cnt = false;

            //제조
            if (_pPROCESS_CODE_MST == "PC01")
            {
                /*
                int rowHandle = _gdMAIN_VIEW2.LocateByValue("PART_CODE", pPart_code);
                if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                {
                    CoFAS_ControlManager.InvokeIfNeeded(_gdMAIN2, () => _gdMAIN_VIEW2.FocusedRowHandle = rowHandle);

                    CoFAS_ControlManager.InvokeIfNeeded(_gdMAIN2, () => _gdMAIN_VIEW2.SetFocusedRowCellValue(_gdMAIN_VIEW2.Columns["IN_INOUT_ID"], pReference_id));
                    find_cnt = true;
                    

                }
                else
                {
                    find_cnt = false;
                }
                //cell.RowIndex

                if (!find_cnt)
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("일치하지 않는 시험번호입니다.");
                }
                */
            }
            //포장
            else
            {
                int rowHandle = _gdMAIN_VIEW2.LocateByValue("PART_CODE", pPart_code);
                if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                {
                    CoFAS_ControlManager.InvokeIfNeeded(_gdMAIN2, () => _gdMAIN_VIEW2.FocusedRowHandle = rowHandle);

                    CoFAS_ControlManager.InvokeIfNeeded(_gdMAIN2, () => _gdMAIN_VIEW2.SetFocusedRowCellValue(_gdMAIN_VIEW2.Columns["IN_INOUT_ID"], pReference_id));
                    find_cnt = true;


                }
                else
                {
                    find_cnt = false;
                }
                //cell.RowIndex

                if (!find_cnt)
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("일치하지 않는 시험번호입니다.");
                }
                /*
                rg = sheet_0.Range["C12:C27"];    //판정유무, 24 -> 39 (반제품때문에

                IEnumerable<Cell> searchResult = rg.Search(pVend_Part_Code);
                foreach (Cell cell in searchResult)
                {
                   
                        //바코드 자재번호 -> 로트번호(제조번호)를 가져와서 LOT-NO에 입력
                        sheet_0.Cells[cell.RowIndex, 7].SetValue(pFindValue);
                        find_cnt = true;
                }

                if (!find_cnt)
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("일치하는 자재코드가 없습니다.");
                }
                */
            }

            find_cnt = false;
            /*
               IWorkbook workbook = _sdMAIN.Document;
               Worksheet sheet_0 = workbook.Worksheets[0];
               Range rg;
        
               rg = sheet_0.Range["D11:D42"];    //판정유무
        
               IEnumerable<Cell> searchResult = rg.Search(pPart_code);
               foreach (Cell cell in searchResult)
               {
                   sheet_0.Cells[cell.RowIndex, 8].SetValue("450.1");
                   //cell.RowIndex
               }
               */

        }
        #endregion


        #region ○ H/W 세팅시
        //생산출고
        private void SetHardware2()
        {

            try
            {
                /*
                // 연결 표기 부분 초기화
                //pnlDeviceConnect.Controls.Clear();

                // 연결할 H/W 갯수만큼 돌린다. (연동시 변경)
                for (int i = 0; i < 5; i++)
                {
                    LabelControl lc = new LabelControl();
                    lc.Name = "lc_" + i.ToString();
                    lc.Font = new Font("Tahoma", 9, FontStyle.Bold); // Font 설정
                    // lc.Text = "프린터" + i.ToString();
                    lc.Text = (_rt_dtList.Rows[i]["PORT_NAME"].ToString() + "_" + _rt_dtList.Rows[i]["COM_PORT"].ToString()).ToString();
                    lc.Padding = new Padding(10, 0, 10, 0);
                    lc.Margin = new Padding(0);
                    lc.Appearance.Image = global::CoFAS_MES.POP.Properties.Resources.plug_Gray;
                    lc.ImageAlignToText = ImageAlignToText.LeftCenter;
                    lc.Dock = DockStyle.Right;


                    pnlDeviceConnect.Controls.Add(lc);

                    DisplayMessage(lc.Text + " OK");

                    DisplayMessage("POP Start Complete");

                }
                */

                //_pCoFAS_Serial = new CoFAS_Serial(_dtList_terminal.Rows[0]["INFO_PORTNAME"].ToString(), Convert.ToInt32(_dtList_terminal.Rows[0]["INFO_BAUDRATE"].ToString()), _dtList_terminal.Rows[0]["INFO_PARITY"].ToString(), Convert.ToInt32(_dtList_terminal.Rows[0]["INFO_DATABITS"].ToString()), _dtList_terminal.Rows[0]["INFO_STOPBITS"].ToString());
                //_pBarcode_Serial = new CoFAS_Serial("COM3", 9600, "NONE", 8, "ONE");
                /*
                _pBarcode_Serial = new CoFAS_Serial(COM_PORT, 9600, "NONE", 8, "ONE");
                _pBarcode_Serial.Open();
                _pBarcode_Serial.evtReceived += new CoFAS_Serial.delReceive(_Barcode_Received_Data2);
                */
                //포트1 : 바코드포트가 존재하는지
                if (Array.Exists(PC_serial_port, port => port == COM_PORT))
                {
                    _pBarcode_Serial2 = new CoFAS_Serial(COM_PORT, 9600, "NONE", 8, "ONE");
                    if (!_pBarcode_Serial2.IsOpen)
                        _pBarcode_Serial2.Open();
                    _pBarcode_Serial2.evtReceived += new CoFAS_Serial.delReceive(_Barcode_Received_Data2);
                }
                if (_pBarcode_Serial2.IsOpen)
                {
                    LabelControl xlb = this.Controls.Find("lc_" + _rt_dtList.Rows[0]["PORT_NAME"].ToString(), true).FirstOrDefault() as LabelControl;
                    xlb.Appearance.Image = global::CoFAS_MES.POP.Properties.Resources.plug_Green;
                }
                else
                {
                    LabelControl xlb = this.Controls.Find("lc_" + _rt_dtList.Rows[0]["PORT_NAME"].ToString(), true).FirstOrDefault() as LabelControl;
                    xlb.Appearance.Image = global::CoFAS_MES.POP.Properties.Resources.plug_Gray;
                }

            }
            catch (Exception ex)
            {
                CoFAS_DevExpressManager.ShowInformationMessage("포트 연결을 실패했습니다.");
               _pBarcode_Serial2 = new CoFAS_Serial();
            }

        }
      
        void _Barcode_Received_Data2(byte[] yReceiveData)
        {
            try
            {
                if (yReceiveData.Length > 0)
                {
                    string pFindData = string.Empty;
                    string vPart_code = string.Empty;
                    string vMake_no = string.Empty;
                    string vInspect_no = string.Empty;
                    string vVend_Part_Code = string.Empty;
                    string vReference_id = string.Empty;

                    pFindData = CoFAS_ConvertManager.Bytes2String(yReceiveData, 0, 0);
                    pFindData = pFindData.Substring(0, pFindData.Length - 4);//뒤에 개행문자 지울경우(2자리)
                    DataSet pDataSet = new DataSet();
                    pDataSet = new BarcodeLabelPrintBusiness().BarcodeLabelPrint_inspect_Info(_pfrmPOPMain_MATERIAL_COSMETICSEntity.LANGUAGE_TYPE, "DOC", pFindData);
                    _dtList = pDataSet.Tables[0];
                    if (_dtList != null && _dtList.Rows.Count > 0)
                    {
                        vPart_code = _dtList.Rows[0]["part_code"].ToString();
                        vMake_no = _dtList.Rows[0]["make_no"].ToString();
                        vInspect_no = _dtList.Rows[0]["inspect_no"].ToString();
                        vVend_Part_Code = _dtList.Rows[0]["vend_part_code"].ToString();
                        vReference_id = _dtList.Rows[0]["reference_id"].ToString();
                        //제조
                        if (_pPROCESS_CODE_MST == "PC01")
                            FindPartCode2(vPart_code, vVend_Part_Code, vInspect_no, vReference_id);
                        else
                            FindPartCode2(vPart_code, vVend_Part_Code, vMake_no, vReference_id);

                    }
                    else
                    {
                        CoFAS_DevExpressManager.ShowInformationMessage("등록되지 않은 바코드입니다.");
                    }

                    //종료시 close시키기
                    //엑셀로 커서가게
                    //바코드세팅 com번호 가져오게하기
                    //기존 USP_BarcodeLabelPrint_R30를 수정하여 같이쓰게 하든가 아니면 별도로 가져오게하기
                    //dispose 예외처리하기
                }

                // Application.DoEvents(); //화면초기화
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //품목코드 찾기(저울스캔시)
        //   private void FindPartCode(string pPart_code)
        //   {
        //       IWorkbook workbook = _sdMAIN.Document;
        //       Worksheet sheet_0 = workbook.Worksheets[0];
        //       Range rg;
        //
        //       rg = sheet_0.Range["D11:D42"];    //판정유무
        //
        //       IEnumerable<Cell> searchResult = rg.Search(pPart_code);
        //       foreach (Cell cell in searchResult)
        //       {
        //           sheet_0.Cells[cell.RowIndex, 8].SetValue("450.1");
        //           //cell.RowIndex
        //       }
        //   }

        //품목코드 찾기(저울스캔시) 
        private void FindPartCode2(string pPart_code, string pVend_Part_code, string make_inspect_code, string pReference_id)
        {
            bool find_cnt = false;

            //제조
            if (_pPROCESS_CODE_MST == "PC01")
            {

                int rowHandle = _gdMAIN_VIEW3.LocateByValue("PART_CODE", pPart_code);
                if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                {
                    CoFAS_ControlManager.InvokeIfNeeded(_gdMAIN3, () => _gdMAIN_VIEW3.FocusedRowHandle = rowHandle);
                    //_gdMAIN_VIEW.FocusedRowHandle = rowHandle;
                    SubFind_DisplayData("R", _gdMAIN_VIEW3.GetFocusedRowCellValue("PART_CODE").ToString());
                    find_cnt = true;
                    int rowHandle2 = _gdSUB_VIEW.LocateByValue("INOUT_ID", pReference_id);
                    if (rowHandle2 != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                    {
                        //     _gdSUB_VIEW.FocusedRowHandle = rowHandle2;
                        CoFAS_ControlManager.InvokeIfNeeded(_gdSUB, () => _gdSUB_VIEW.FocusedRowHandle = rowHandle2);
                        find_cnt = true;

                    }
                    else
                    {
                        find_cnt = false;
                    }

                }
                else
                {
                    find_cnt = false;
                }
                //cell.RowIndex

                if (!find_cnt)
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("일치하지 않는 시험번호입니다.");
                }
            }
            //포장
            else
            {
                /*
                rg = sheet_0.Range["C12:C27"];    //판정유무, 24 -> 39 (반제품때문에

                IEnumerable<Cell> searchResult = rg.Search(pVend_Part_Code);
                foreach (Cell cell in searchResult)
                {
                   
                        //바코드 자재번호 -> 로트번호(제조번호)를 가져와서 LOT-NO에 입력
                        sheet_0.Cells[cell.RowIndex, 7].SetValue(pFindValue);
                        find_cnt = true;
                }

                if (!find_cnt)
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("일치하는 자재코드가 없습니다.");
                }
                */
            }

            find_cnt = false;
            /*
               IWorkbook workbook = _sdMAIN.Document;
               Worksheet sheet_0 = workbook.Worksheets[0];
               Range rg;
        
               rg = sheet_0.Range["D11:D42"];    //판정유무
        
               IEnumerable<Cell> searchResult = rg.Search(pPart_code);
               foreach (Cell cell in searchResult)
               {
                   sheet_0.Cells[cell.RowIndex, 8].SetValue("450.1");
                   //cell.RowIndex
               }
               */

        }
        #endregion

        private void _ucbtIN_REG_Click(object sender, EventArgs e)
        {
            // pfrmPOPMain_WEIGHING_COSMETICSEntity.CORP_CODE = _pCORP_CODE;
            _pfrmPOPMain_MATERIAL_COSMETICSEntity.USER_CODE = _pUserEntity.USER_CODE;
            int cnt = 0;
            DataTable tDataTable = _gdMAIN_VIEW.GridControl.DataSource as DataTable;

            if (CoFAS_DevExpressManager.ShowQuestionMessage("입고를 하시겠습니까?") == DialogResult.Yes)
            {
                _pfrmPOPMain_MATERIAL_COSMETICSEntity.CRUD = "C";
                _pfrmPOPMain_MATERIAL_COSMETICSEntity.INOUT_CODE = "MR040011";
                bool isError;
                isError = new frmPOPMain_MATERIAL_COSMETICSBusiness().frmPOPMain_MATERIAL_COSMETICS_Info_Save(_pfrmPOPMain_MATERIAL_COSMETICSEntity, tDataTable);

                if (isError)
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("저장 오류 발생! 데이터를 확인 하세요.");
                    //      CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                }
                else
                {
                    //정상 처리
                    CoFAS_DevExpressManager.ShowInformationMessage("저장 처리 되었습니다.");
                    //       CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                    _pLocation_Code = _pfrmPOPMain_MATERIAL_COSMETICSEntity.RTN_KEY;  //저장 위치 
                    MainFind_DisplayData();



                }
            }
        }

        private void _ucbtKEYPAD_Click(object sender, EventArgs e)
        {

        }

        private void _ucbtMATERIAL_ORDER_Click(object sender, EventArgs e)
        {
            //메뉴확인 , 0:입고, 1:부자재, 2:생산출고
            //Change_Port_Event();
            PORT_CHK = "0";

            _ucbtORDER_SEARCH.Enabled = true;
            _ucbtIN_REG.Enabled = true;
            _ucbtINSPECT_REG.Enabled = true;
            //  tabcontrol1.TabIndex = 0;
            tabcontrol1.SelectedIndex = 0;
            MainFind_DisplayData();
            /*
            if (_pBarcode_Serial1.IsOpen)
            {
                _pBarcode_Serial1.Close();
                _pBarcode_Serial1.evtReceived -= new CoFAS_Serial.delReceive(_Barcode_Received_Data1);
            }
            if (_pBarcode_Serial2.IsOpen)
            {
                _pBarcode_Serial2.Close();
                _pBarcode_Serial2.evtReceived -= new CoFAS_Serial.delReceive(_Barcode_Received_Data2);
            }
            */
        }
        #region Label 내 AutoFontSize
        public void FontResize(LabelControl lbl)
        {

            Font ft = lbl.Font;

            try
            {
                if (lbl.Height > 4)
                {
                    string[] str = lbl.Text.Split('\n');

                    string maxText = string.Empty;
                    int maxlength = 0;

                    if (str.Length > 0)
                    {
                        maxText = str[0].Replace("\n", string.Empty);
                        maxlength = str[0].Replace("\n", string.Empty).Length + 1;
                        for (int i = 0; i < str.Length; i++)
                        {
                            if (str[i].Replace("\n", string.Empty).Length > maxlength)
                            {
                                maxlength = str[i].Replace("\n", string.Empty).Length;
                                maxText = str[i].Replace("\n", string.Empty);
                            }
                        }

                        if (maxText == "") return;

                        int textWidth = System.Windows.Forms.TextRenderer.MeasureText(maxText, new Font(ft.FontFamily, ft.Size, ft.Style)).Width;

                        //if ((textWidth > 0 && (fnt.Size * lbl.Width / 72 / 2) - 2 < lbl.Height) && lbl.Width > textWidth)

                        int textHeight = System.Windows.Forms.TextRenderer.MeasureText(maxText, new Font(ft.FontFamily, ft.Size, ft.Style)).Height * str.Length;
                        if (textHeight < lbl.Height && lbl.Width > textWidth)
                        {
                            bool result = false;

                            //크게 해준다.
                            while (lbl.Width > System.Windows.Forms.TextRenderer.MeasureText(maxText, new Font(ft.FontFamily, ft.Size, ft.Style)).Width && lbl.Height > (ft.Height * str.Length) && lbl.Height > System.Windows.Forms.TextRenderer.MeasureText(maxText, new Font(ft.FontFamily, ft.Size, ft.Style)).Height * str.Length)
                            {
                                result = true;
                                ft = new Font(ft.FontFamily, ft.Size + 0.5f, ft.Style);
                                //lbl.Font = new Font(lbl.Font.FontFamily, lbl.Font.Size + 0.5f, lbl.Font.Style);
                            }
                            if (result)
                            {
                                ft = new Font(ft.FontFamily, ft.Size - 0.5f, ft.Style);
                                //lbl.Font = new Font(lbl.Font.FontFamily, lbl.Font.Size - 0.5f, lbl.Font.Style);
                            }
                        }
                        else
                        {
                            //작게 해준다
                            while (lbl.Width < System.Windows.Forms.TextRenderer.MeasureText(maxText, new Font(ft.FontFamily, ft.Size, ft.Style)).Width || lbl.Height < System.Windows.Forms.TextRenderer.MeasureText(maxText, new Font(ft.FontFamily, ft.Size, ft.Style)).Height * str.Length)
                            {
                                if (ft.Size >= 0.6)
                                {
                                    ft = new Font(ft.FontFamily, ft.Size - 0.5f, ft.Style);
                                    //lbl.Font = new Font(lbl.Font.FontFamily, lbl.Font.Size - 0.5f, lbl.Font.Style);
                                }
                                else
                                    break;
                            }
                        }
                    }
                }
                else
                    return;

                lbl.Font = ft;
            }
            catch (Exception ex)
            {
                //LogManager.Error(this.GetType(), ex.ToString(), ex);
            }
        }
        #endregion

        private void _ucbtINSPECT_REG_Click(object sender, EventArgs e)
        {
            DataTable tDataTable = _gdMAIN_VIEW.GridControl.DataSource as DataTable;

            if (_pfrmPOPMain_MATERIAL_COSMETICSEntity.ORDER_ID == "" || _pfrmPOPMain_MATERIAL_COSMETICSEntity.ORDER_ID ==null)
            {
                CoFAS_DevExpressManager.ShowInformationMessage("발주를 먼저 선택해주세요.");
                return;
            }
            if (_pINSPECT_CHECK_YN)
            {
                CoFAS_DevExpressManager.ShowInformationMessage("이미 시험을 의뢰했습니다.");
                return;
            }
            //입고된것이 있다면
            if (Convert.ToDecimal(_pfrmPOPMain_MATERIAL_COSMETICSEntity.IN_QTY) > 0)
            {
                //검사등록
                if (CoFAS_DevExpressManager.ShowQuestionMessage("'" + _pfrmPOPMain_MATERIAL_COSMETICSEntity.PART_NAME + "'을(를) 시험의뢰 하시겠습니까?") == DialogResult.Yes)
                {
                    _pfrmPOPMain_MATERIAL_COSMETICSEntity.CRUD = "U";
                    _pfrmPOPMain_MATERIAL_COSMETICSEntity.USER_CODE = _pUSER_CODE;
                    frmPOPInputSamplingQty frmkey = new frmPOPInputSamplingQty();
                    frmkey.titleName = "의뢰수량입력";
                    if (frmkey.ShowDialog() == DialogResult.OK)
                    {
                        string PopupValue = frmkey.ReturnValue1;        //검체채취량
                        string PopupValue2 = frmkey.ReturnValue2;       //검체채취일

                        DisplayMessage(_ucbtINSPECT_REG.Name + " -> " + PopupValue);
                        _pfrmPOPMain_MATERIAL_COSMETICSEntity.SAMPLING_RESULT = PopupValue;
                        _pfrmPOPMain_MATERIAL_COSMETICSEntity.SAMPLING_DATE = PopupValue2;

                        bool isError;
                        isError = new frmPOPMain_MATERIAL_COSMETICSBusiness().frmPOPMain_MATERIAL_COSMETICS_INSPECT_Save(_pfrmPOPMain_MATERIAL_COSMETICSEntity, tDataTable);

                        if (isError)
                        {
                            //CoFAS_DevExpressManager.ShowInformationMessage("저장 오류 발생! 데이터를 확인 하세요.");
                            // CoFAS_DevExpressManager.ShowInformationMessage("저장 오류 발생! 데이터를 확인 하세요.");
                        }
                        else
                        {
                            //정상 처리
                            //CoFAS_DevExpressManager.ShowInformationMessage("저장 처리 되었습니다.");
                            CoFAS_DevExpressManager.ShowInformationMessage("저장 처리 되었습니다.");
                            // _pLocation_Code = _pPOPSelect_INSPECT_COSMETICSEntity.RTN_KEY;  //저장 위치 
                            _pfrmPOPMain_MATERIAL_COSMETICSEntity.CRUD = "R";
                            _pfrmPOPMain_MATERIAL_COSMETICSEntity.INOUT_ID = "";
                            _pfrmPOPMain_MATERIAL_COSMETICSEntity.PART_CODE = "";
                            _pfrmPOPMain_MATERIAL_COSMETICSEntity.PART_NAME = "";
                            _pINSPECT_CHECK_YN = false;
                            MainFind_DisplayData();
                            // MainFind_DisplayData();
                        }
                    }
                }
               
            }
            else
            {
                CoFAS_DevExpressManager.ShowInformationMessage("입고수량이 있어야 합니다.");
                return;
            }
        }

        private void tlpPOPMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void _ucbtORDER_SEARCH_Click(object sender, EventArgs e)
        {
            _ucbtIN_REG.Enabled = false;
            _ucbtINSPECT_REG.Enabled = false;
            _ucbtORDER_SEARCH.Enabled = true;

            tabcontrol1.TabIndex = 1;
            tabcontrol1.SelectedIndex = 1;
            //작업지시
            frmPOPOrder.PROCESS_MST_CODE_COSMETICS = "PC02";
            frmPOPOrder frmOr = new frmPOPOrder(_pUserEntity);
            frmOr.ShowDialog();
            if (frmOr.dtReturn == null)
            {
                frmOr.Dispose();
                return;
            }

            if (frmOr.dtReturn != null && frmOr.dtReturn.Rows.Count > 0)
            {
                _luORDER_DATE.Text = frmOr.dtReturn.Rows[0]["PRODUCTION_ORDER_DATE"].ToString();
                _luORDER_QTY.Text = frmOr.dtReturn.Rows[0]["PRODUCTION_ORDER_QTY"].ToString();
                _luPART_NAME.Text = frmOr.dtReturn.Rows[0]["PART_NAME"].ToString();
                // _luPART_CODE.Text = frmOr.dtReturn.Rows[0]["PART_CODE"].ToString();
                _luPART_CODE.Text = frmOr.dtReturn.Rows[0]["VEND_PART_CODE"].ToString();

                _pfrmPOPMain_MATERIAL_COSMETICSEntity.PART_CODE = frmOr.dtReturn.Rows[0]["PART_CODE"].ToString();
                _pfrmPOPMain_MATERIAL_COSMETICSEntity.PRODUCTION_ORDER_ID = frmOr.dtReturn.Rows[0]["PRODUCTION_ORDER_ID"].ToString();

                _pfrmPOPMain_MATERIAL_COSMETICSEntity.PROCESS_CODE_MST = frmOr.dtReturn.Rows[0]["PROCESS_CODE_MST"].ToString();// _pUserEntity.PROCESS_CODE;

                _pfrmPOPMain_MATERIAL_COSMETICSEntity.PRODUCTION_ORDER_QTY = frmOr.dtReturn.Rows[0]["PRODUCTION_ORDER_QTY"].ToString();
                _pfrmPOPMain_MATERIAL_COSMETICSEntity.ORDER_FILE = frmOr.dtReturn.Rows[0]["ORDER_FILE"].ToString();
                _pfrmPOPMain_MATERIAL_COSMETICSEntity.CRUD = "R";
                MainFind_DisplayData2();

            }


            frmOr.Dispose();
            /*
            if (_pBarcode_Serial1.IsOpen)
            {
                _pBarcode_Serial1.Close();
                _pBarcode_Serial1.evtReceived -= new CoFAS_Serial.delReceive(_Barcode_Received_Data1);
            }
            if (_pBarcode_Serial2.IsOpen)
            {
                _pBarcode_Serial2.Close();
                _pBarcode_Serial2.evtReceived -= new CoFAS_Serial.delReceive(_Barcode_Received_Data2);
            }
            */
            //메뉴확인 , 0:입고, 1:부자재, 2:생산출고
           // Change_Port_Event();
            PORT_CHK = "0";

            // SetHardware1();
            //  SetHardware2();
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void _ucbtPRODUCTION_DOC_Click(object sender, EventArgs e)
        {
            try
            {
                if (_pfrmPOPMain_MATERIAL_COSMETICSEntity.PRODUCTION_ORDER_ID != "" && _pfrmPOPMain_MATERIAL_COSMETICSEntity.PRODUCTION_ORDER_ID != null)
                {
                    //메뉴확인 , 0:입고, 1:부자재, 2:생산출고
                   // Change_Port_Event();
                    PORT_CHK = "1";

                    string part_type = "1005";
                    CoFAS_MES.POP.Popup.frmPOPSelect_WorkOrderDoc_COSMETICS.USER_CODE = _pUSER_CODE;
                    CoFAS_MES.POP.Popup.frmPOPSelect_WorkOrderDoc_COSMETICS.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    CoFAS_MES.POP.Popup.frmPOPSelect_WorkOrderDoc_COSMETICS.FONT_TYPE = _pFONT_SETTING;

                    CoFAS_MES.POP.Popup.frmPOPSelect_WorkOrderDoc_COSMETICS.FTP_ID = _pUserEntity.FTP_ID;
                    CoFAS_MES.POP.Popup.frmPOPSelect_WorkOrderDoc_COSMETICS.FTP_IP_PORT = _pUserEntity.FTP_IP_PORT;
                    CoFAS_MES.POP.Popup.frmPOPSelect_WorkOrderDoc_COSMETICS.FTP_PATH = _pUserEntity.FTP_IP_PORT;
                    CoFAS_MES.POP.Popup.frmPOPSelect_WorkOrderDoc_COSMETICS.FTP_PW = _pUserEntity.FTP_PW;
                    CoFAS_MES.POP.Popup.frmPOPSelect_WorkOrderDoc_COSMETICS.USER_CODE = _pUserEntity.USER_CODE;
                    CoFAS_MES.POP.Popup.frmPOPSelect_WorkOrderDoc_COSMETICS.USER_NAME = _pUserEntity.USER_NAME;

                    CoFAS_MES.POP.Popup.frmPOPSelect_WorkOrderDoc_COSMETICS.P_WINDOW_NAME = this.Name;

                    CoFAS_MES.POP.Popup.frmPOPSelect_WorkOrderDoc_COSMETICS.ARRAY = new object[5] { "ucWorkOrderDocRegPopup", _pfrmPOPMain_MATERIAL_COSMETICSEntity.PROCESS_CODE_MST, _pfrmPOPMain_MATERIAL_COSMETICSEntity.PRODUCTION_ORDER_ID, _pfrmPOPMain_MATERIAL_COSMETICSEntity.ORDER_FILE, _pfrmPOPMain_MATERIAL_COSMETICSEntity.TERMINAL_CODE }; //넘기는 파라메터 에 따라 설정, 제품/조회할때 품목명을 던지기
                    CoFAS_MES.POP.Popup.frmPOPSelect_WorkOrderDoc_COSMETICS.ARRAY_CODE = new object[3] { "", "", part_type };
                    CoFAS_MES.POP.Popup.frmPOPSelect_WorkOrderDoc_COSMETICS xfrmCommonPopup = new CoFAS_MES.POP.Popup.frmPOPSelect_WorkOrderDoc_COSMETICS("ucWorkOrderDocRegPopup"); //유저컨트롤러 설정 부분

                    xfrmCommonPopup.ShowDialog();

                    if (xfrmCommonPopup.dtReturn == null)
                    {
                        xfrmCommonPopup.Dispose();
                        MainFind_DisplayData2();
                        return;
                    }

                    if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                    {
                        //_luT_PART.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["ORDER_ID"].ToString();
                        //_luT_PART.NameText = xfrmCommonPopup.dtReturn.Rows[0]["PART_NAME"].ToString();

                    }

                    xfrmCommonPopup.Dispose();
                    _pfrmPOPMain_MATERIAL_COSMETICSEntity.CRUD = "R";
                    _pfrmPOPMain_MATERIAL_COSMETICSEntity.PRODUCTION_ORDER_ID = xfrmCommonPopup.dtReturn.Rows[0]["PRODUCTION_ORDER_ID"].ToString();
                    _pfrmPOPMain_MATERIAL_COSMETICSEntity.PART_CODE = "";
                    // _pPOPSelect_INSPECT_COSMETICSEntity.PART_NAME = "";
                    MainFind_DisplayData2();
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("작업지시를 선택하여주시기 바랍니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage("작업지시를 선택하여주시기 바랍니다.");
                    return;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        private void _ucbtPRODUCTION_OUT_Click(object sender, EventArgs e)
        {
            // pfrmPOPMain_WEIGHING_COSMETICSEntity.CORP_CODE = _pCORP_CODE;
            _pfrmPOPMain_MATERIAL_COSMETICSEntity.USER_CODE = _pUserEntity.USER_CODE;
            int cnt = 0;
            DataTable tDataTable = _gdMAIN_VIEW2.GridControl.DataSource as DataTable;

            if (CoFAS_DevExpressManager.ShowQuestionMessage("출고를 하시겠습니까?") == DialogResult.Yes)
            {
                _pfrmPOPMain_MATERIAL_COSMETICSEntity.CRUD = "C";
                _pfrmPOPMain_MATERIAL_COSMETICSEntity.INOUT_CODE = "MR050020";
                bool isError;
                isError = new frmPOPMain_MATERIAL_COSMETICSBusiness().frmPOPMain_MATERIAL_COSMETICS_Info_Save2(_pfrmPOPMain_MATERIAL_COSMETICSEntity, tDataTable);

                if (isError)
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("저장 오류 발생! 데이터를 확인 하세요.");
                    //      CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                }
                else
                {
                    //정상 처리
                    CoFAS_DevExpressManager.ShowInformationMessage("저장 처리 되었습니다.");
                    //       CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                    _pLocation_Code = _pfrmPOPMain_MATERIAL_COSMETICSEntity.RTN_KEY;  //저장 위치 
                    MainFind_DisplayData2();



                }
            }
        }

        private void _ucbtPART_SEARCH_Click(object sender, EventArgs e)
        {
            _ucbtIN_REG.Enabled = false;
            _ucbtINSPECT_REG.Enabled = false;
            _ucbtORDER_SEARCH.Enabled = true;

            tabcontrol1.TabIndex = 2;
            tabcontrol1.SelectedIndex = 2;

            MainFind_DisplayData3();

           // Change_Port_Event();
            PORT_CHK = "2";
            // if (_pBarcode_Serial2.IsOpen)
            // {
            //     _pBarcode_Serial2.Close();
            //     _pBarcode_Serial2.evtReceived -= new CoFAS_Serial.delReceive(_Barcode_Received_Data2);
            // }



            // SetHardware1();
            // SetHardware2();

        }
        private void Change_Port_Event()
        {
            //메뉴확인 , 0:입고, 1:부자재, 2:생산출고

            if (tabcontrol1.TabIndex == 0)//입고 (이벤트x)
            {
                if (PORT_CHK == "0")
                {

                }
                else if (PORT_CHK == "1")
                {

                    if (_pBarcode_Serial1.IsOpen)
                    {
                        _pBarcode_Serial1.evtReceived -= new CoFAS_Serial.delReceive(_Barcode_Received_Data1);
                    }
                }
                else if (PORT_CHK == "2")
                {
                    if (_pBarcode_Serial1.IsOpen)
                    {
                        _pBarcode_Serial1.evtReceived -= new CoFAS_Serial.delReceive(_Barcode_Received_Data1);
                    }
                }
            }
            else if (tabcontrol1.TabIndex == 1) //생산출고
            {
                if (PORT_CHK == "0")
                {
                    if (_pBarcode_Serial1.IsOpen)
                    {
                        _pBarcode_Serial1.evtReceived += new CoFAS_Serial.delReceive(_Barcode_Received_Data1);
                    }
                }
                else if (PORT_CHK == "1")
                {

                    if (_pBarcode_Serial1.IsOpen)
                    {
                    }
                }
                else if (PORT_CHK == "2")
                {
                    if (_pBarcode_Serial1.IsOpen)
                    {
                        _pBarcode_Serial1.evtReceived -= new CoFAS_Serial.delReceive(_Barcode_Received_Data2);
                        _pBarcode_Serial1.evtReceived += new CoFAS_Serial.delReceive(_Barcode_Received_Data1);
                    }
                }
            }
            else if (tabcontrol1.TabIndex == 2) // 부자재출고
            {
                if (PORT_CHK == "0")
                {
                    if (_pBarcode_Serial1.IsOpen)
                    {
                        _pBarcode_Serial1.evtReceived += new CoFAS_Serial.delReceive(_Barcode_Received_Data2);
                    }
                }
                else if (PORT_CHK == "1")
                {

                    if (_pBarcode_Serial1.IsOpen)
                    {
                        _pBarcode_Serial1.evtReceived -= new CoFAS_Serial.delReceive(_Barcode_Received_Data1);
                        _pBarcode_Serial1.evtReceived += new CoFAS_Serial.delReceive(_Barcode_Received_Data2);
                    }
                }
                else if (PORT_CHK == "2")
                {
                    if (_pBarcode_Serial1.IsOpen)
                    {
                    }
                }
            }
            
        }
        private void _ucbtMATERIAL_OUT_Click(object sender, EventArgs e)
        {
            // _pfrmPOPMain_MATERIAL_COSMETICSEntity.CORP_CODE = _pCORP_CODE;
            _pfrmPOPMain_MATERIAL_COSMETICSEntity.USER_CODE = _pUserEntity.USER_CODE;
            int cnt = 0;
            DataTable tDataTable = _gdSUB_VIEW.GridControl.DataSource as DataTable;

            if (CoFAS_DevExpressManager.ShowQuestionMessage("출고를 하시겠습니까?") == DialogResult.Yes)
            {
                _pfrmPOPMain_MATERIAL_COSMETICSEntity.CRUD = "C";
                _pfrmPOPMain_MATERIAL_COSMETICSEntity.INOUT_CODE = "MR050020"; //MR050020 = 생산출고
                bool isError;
                isError = new frmPOPMain_MATERIAL_COSMETICSBusiness().frmPOPMain_MATERIAL_COSMETICS_INSPECT_Save3(_pfrmPOPMain_MATERIAL_COSMETICSEntity, tDataTable);
                if (isError)
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("저장 오류 발생! 데이터를 확인 하세요.");
                    //      CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                }
                else
                {
                    //정상 처리
                    CoFAS_DevExpressManager.ShowInformationMessage("저장 처리 되었습니다.");
                    //       CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                    _pLocation_Code = _pfrmPOPMain_MATERIAL_COSMETICSEntity.RTN_KEY;  //저장 위치 
                    MainFind_DisplayData3();



                }
            }
        }

        private void _ucbtPART_STOCK_Click(object sender, EventArgs e)
        {
            _pPART_STOCK_YN = _pPART_STOCK_YN == false ? true : false;
        }
    }
}



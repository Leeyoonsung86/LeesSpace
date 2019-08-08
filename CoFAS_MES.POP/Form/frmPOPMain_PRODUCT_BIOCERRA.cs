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
using CoFAS_MES.CORE.Entity;

using CoFAS_MES.POP.Business;
using CoFAS_MES.POP.Data;
using CoFAS_MES.POP.Entity;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using CoFAS_MES.CORE.Business;
using System.IO.Ports;

namespace CoFAS_MES.POP
{
    public partial class frmPOPMain_PRODUCT_BIOCERRA : frmBasePOP
    {
        private string _pCORP_CODE = string.Empty;       // 회사코드       
        public string _pCORP_CDDE = string.Empty;       // 회사코드       
        public string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        public string _pUSER_NAME = string.Empty;       // 사용자이름
        public string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어
        public string _pWINDOW_NAME = string.Empty;     // 화면 명칭
        public string _pFONT_TYPE = string.Empty;       // 시스템 폰트 타입 설정
        public int _pFONT_SIZE = 9;                     // 시스템 폰트 사이즈 설정 기본 9
        private Font _pFONT_SETTING = null;             // 시스템 폰트 설정
        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용
        public UserEntity _pUserEntity = null;
        private POPProductionOrderEntity _pPOPProductionOrderEntity = null; // 엔티티 생성
        public MessageEntity _pMessageEntity = null; //공통 메세지 엔티티
        private DataTable _dtList = null; //조회 데이터 리스트
        private CoFAS_DevGridManager _tempGridMain1 = null;

        private int select_row_handle = 0;
        private CoFAS_Serial _pBarcode_Serial = null;  // 바코드 시리얼 생성
        private string COM_PORT = string.Empty;
        private int active_row = 0;

        private string[] PC_serial_port = SerialPort.GetPortNames();

        private DataTable _dtreturn = new DataTable();
        private DataTable _rt_dtList = null; //조회 데이터 리스트
        private static string _pPROCESS_MST_CODE_COSMETICS = string.Empty;     //공정

        public frmPOPMain_PRODUCT_BIOCERRA(UserEntity pUserEntity)
        {
            InitializeComponent();

            _pUserEntity = pUserEntity;
            _pCORP_CODE = _pUserEntity.USER_CODE;
            _pUSER_CODE = _pUserEntity.USER_NAME;
            _pLANGUAGE_TYPE = _pUserEntity.LANGUAGE_TYPE;

            _pPOPProductionOrderEntity = new POPProductionOrderEntity();
            _pPOPProductionOrderEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
            //TP010001 : 공장PPC = 생산
            //TP010002 : 본사PPC = 조립
            _pPOPProductionOrderEntity.RESOURCE_CODE = _pUserEntity.RESOURCE_CODE;// "TP010001";
            if (_pUserEntity.RESOURCE_CODE== "TP010001")
                _lbTitle.Text = "공장 실적등록";
            else
                _lbTitle.Text = "본사 실적등록";
            _pPOPProductionOrderEntity.CORP_CODE = "";
            _pMessageEntity = new MessageEntity();

            _pFONT_SETTING = new Font(_pUserEntity.FONT_TYPE, _pUserEntity.FONT_SIZE);

            _pUSER_CODE = _pUserEntity.USER_CODE;
            _pUSER_NAME = _pUserEntity.USER_NAME;

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

               
                _lbHeader.Text = "";
                DisplayMessage("");


                //메뉴 화면 엔티티 설정
                //_pDQGatheringEntity = new DQGatheringEntity();
                //_pDQGatheringEntity.CORP_CODE = _pCORP_CDDE;
                //_pDQGatheringEntity.USER_CODE = _pUSER_CODE;

                //화면 설정 언어 & 명칭 변경. ==고정==
                //DataTable dtLanguage = new LanguageBusiness().Language_Info(_pCORP_CDDE, _pWINDOW_NAME, _pLANGUAGE_TYPE);

                //if (dtLanguage != null && dtLanguage.Rows.Count > 0)
                //{
                //    CoFAS_ControlManager.Language_Info(dtLanguage, this);
                //}
                //화면 설정 언어 & 명칭 변경. ==고정==


                //그리드 설정

                //   double ddd = Math.Acos(0.912);

                _lbWORK_ORDER_QTY.Text ="";
                //_lbOK_QTY.Text = "";
               // _lbNG_QTY.Text = "";
                //_lbPROCESS_INFO.Text = "";
                //화면 컨트롤러 설정
                InitializeControl();

                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                if (_pFirstYN)
                {

                    MainFind_DisplayData();
                    _pFirstYN = false;
                }

                //컨트롤러 별 추가 이벤트 생성은 화면 설정 마지막에 진행
                _gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick;
                set_Process_Image();
                GetBarcodeComPort();

                // H/W 연결 설정
               // SetHardware();
                // H/W 연결 설정
                // SetHardware();

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #region ○ H/W 세팅시
        private void GetBarcodeComPort()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _dtList = new BarcodeLabelPrintBusiness().BarcodeLabelPrint_COM_Info(_pPOPProductionOrderEntity.LANGUAGE_TYPE, _pPOPProductionOrderEntity.TERMINAL_CODE);
                _rt_dtList = _dtList;
                COM_PORT = "";
                if (_dtList != null && _dtList.Rows.Count > 0)//&& _dtList.Rows.Count > 0) )|| (_dtList != null && _pBarcodeLabelPrintEntity.CRUD == ""))
                {
                    // CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩

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
        #region ○ 메인 그리드 로우 선택 이벤트 생성 - _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        private void _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;

                CoFAS_ControlManager.Controls_Binding(gv, false, this);

                int qRowIndex = gv.FocusedRowHandle;
                string qColumnHeader = e.Column.Caption;
                string qWorkOrderID = gv.GetRowCellValue(qRowIndex, "PRODUCTION_ORDER_ID").ToString();

                //_gdMAIN_index = qRowIndex;
                _pPOPProductionOrderEntity.PRODUCTION_ORDER_ID = gv.GetRowCellValue(qRowIndex, "PRODUCTION_ORDER_ID").ToString();
                _pPOPProductionOrderEntity.PART_CODE = gv.GetRowCellValue(qRowIndex, "PART_CODE").ToString();
                _pPOPProductionOrderEntity.PROCESS_CODE = gv.GetRowCellValue(qRowIndex, "PROCESS_CODE_MST").ToString();
                _pPOPProductionOrderEntity.PRODUCTION_OK_QTY = gv.GetRowCellValue(qRowIndex, "PRODUCTION_OK_QTY").ToString();
                _pPOPProductionOrderEntity.PRODUCTION_NG_QTY = gv.GetRowCellValue(qRowIndex, "PRODUCTION_NG_QTY").ToString();
                _pPOPProductionOrderEntity.PRODUCTION_ORDER_QTY = gv.GetRowCellValue(qRowIndex, "PRODUCTION_ORDER_QTY").ToString();
                _pPOPProductionOrderEntity.PART_NAME = gv.GetRowCellValue(qRowIndex, "PART_NAME").ToString();
                //_pPOPProductionOrderEntity.PRODUCTION_ORDER_SEQ = gv.GetRowCellValue(qRowIndex, "PRODUCTION_ORDER_SEQ").ToString();

                _pPOPProductionOrderEntity.PRODUCTION_SEQ = gv.GetRowCellValue(qRowIndex, "PRODUCTION_SEQ").ToString();

                _lbWORK_ORDER_QTY.Text = _pPOPProductionOrderEntity.PRODUCTION_ORDER_QTY;
                //_lbOK_QTY.Text = _pPOPProductionOrderEntity.PRODUCTION_OK_QTY;
                //_lbNG_QTY.Text = _pPOPProductionOrderEntity.PRODUCTION_NG_QTY;
                _lbPartName.Text = _pPOPProductionOrderEntity.PART_NAME;
                Size_reset();
                //_lbPROCESS_INFO.Text = _pPOPProductionOrderEntity.PROCERSS_INFO;


            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion

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
                    _tempGridMain1 = new CoFAS_DevGridManager();
                    _gdMAIN_VIEW = _tempGridMain1.Grid_Setting(_gdMAIN, _gdMAIN_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdMAIN.Name.ToString()));
                    // _gdMAIN_VIEW.OptionsView.RowAutoHeight = true;
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
            SimpleButton pCmd = pSender as SimpleButton;

            string sCls = pCmd.Name.Substring(6, 2);

            

            switch (sCls)
            {

                case "10":
                    // 실적등록
                    frmPopupKeypad frmkey = new frmPopupKeypad();
                    frmkey.titleName = pCmd.Text;
                    if(frmkey.ShowDialog() == DialogResult.OK)
                    {
                        string PopupValue = frmkey.ReturnValue1;
                        DisplayMessage(pCmd.Text + " -> " + PopupValue);
                    }
                    
                    break;

                case "20":
                    // 불량처리
                    frmPOPBad frmb = new frmPOPBad();
                    frmb.titleName = pCmd.Text;
                    if (frmb.ShowDialog() == DialogResult.OK)
                    {
                        string PopupValue = frmb.ReturnValue1;
                        DisplayMessage(pCmd.Text + " -> " + PopupValue);
                    }
                    break;

                case "30":
                    // 비가동 등록
                    frmPOPStop frmStop = new frmPOPStop();
                    if(frmStop.ShowDialog() == DialogResult.OK)
                    {

                    }

                    break;

                case "40":
                    //작업표준서
                    frmPOPDocument frmdoc = new frmPOPDocument();
                    if(frmdoc.ShowDialog() == DialogResult.OK)
                    {

                    }

                    break;

                case "50":
                    //작업지시
                    frmPOPOrder frmOr = new frmPOPOrder(_pUserEntity);
                    if(frmOr.ShowDialog() == DialogResult.OK)
                    {

                    }

                    break;

                default: break;
            }

        }

        #endregion



        private void SetHardware()
        {

            try
            {
                // 연결 표기 부분 초기화
                //pnlDeviceConnect.Controls.Clear();

                // 연결할 H/W 갯수만큼 돌린다. (연동시 변경)
                //for (int i = 0; i < 5; i++)
                for (int i = 0; i < _rt_dtList.Rows.Count; i++)
                {
                    LabelControl lc = new LabelControl();
                    //lc.Name = "lc_" + i.ToString();
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

                //_pCoFAS_Serial = new CoFAS_Serial(_dtList_terminal.Rows[0]["INFO_PORTNAME"].ToString(), Convert.ToInt32(_dtList_terminal.Rows[0]["INFO_BAUDRATE"].ToString()), _dtList_terminal.Rows[0]["INFO_PARITY"].ToString(), Convert.ToInt32(_dtList_terminal.Rows[0]["INFO_DATABITS"].ToString()), _dtList_terminal.Rows[0]["INFO_STOPBITS"].ToString());
                //_pBarcode_Serial = new CoFAS_Serial("COM3", 9600, "NONE", 8, "ONE");
                //                _pBarcode_Serial = new CoFAS_Serial(COM_PORT, 9600, "NONE", 8, "ONE");
                //포트1 : 바코드포트가 존재하는지

                if (Array.Exists(PC_serial_port, port => port == COM_PORT))
                {
                    _pBarcode_Serial = new CoFAS_Serial(COM_PORT, 9600, "NONE", 8, "ONE");
                    if (!_pBarcode_Serial.IsOpen)
                        _pBarcode_Serial.Open();
                    // _pBarcode_Serial.evtReceived += new CoFAS_Serial.delReceive(_Barcode_Received_Data);
                }
                if (_pBarcode_Serial.IsOpen)
                {
                    LabelControl xlb = this.Controls.Find("lc_" + _rt_dtList.Rows[0]["PORT_NAME"].ToString(), true).FirstOrDefault() as LabelControl;
                    xlb.Appearance.Image = global::CoFAS_MES.POP.Properties.Resources.plug_Green;
                    _pBarcode_Serial.Close();
                }
                else
                {
                    LabelControl xlb = this.Controls.Find("lc_" + _rt_dtList.Rows[0]["PORT_NAME"].ToString(), true).FirstOrDefault() as LabelControl;
                    xlb.Appearance.Image = global::CoFAS_MES.POP.Properties.Resources.plug_Gray;
                }
                // _pBarcode_Serial.Open();
                // _pBarcode_Serial.evtReceived += new CoFAS_Serial.delReceive(_Barcode_Received_Data);
                // _pBarcode_Serial.Close();

            }
            catch (Exception ex)
            {
               // CoFAS_DevExpressManager.ShowInformationMessage("포트 연결을 실패했습니다.");
               // _pBarcode_Serial = new CoFAS_Serial();
            }

        }

        private void _ucbtSEARCH_Click(object sender, EventArgs e)
        {
            MainFind_DisplayData();
        }

        private void MainFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                //lookupedit에서 가져오기
                _lbWORK_ORDER_QTY.Text = "";
                _lbPartName.Text = "";
                _pPOPProductionOrderEntity.PRODUCTION_ORDER_ID = "";
                //_lbOK_QTY.Text = "";
                // _lbNG_QTY.Text = "";

                // _lbPROCESS_INFO.Text = "";// _pPOPProductionOrderEntity.PROCERSS_INFO;

                _pPOPProductionOrderEntity.PROCESS_CODE = _pUserEntity.PROCESS_CODE;

                DataSet return_st = null;
                //DataTable Process_dt = null;

                return_st = new POPProductionOrderBusiness().POPProductionOrder_Info2(_pPOPProductionOrderEntity);
                _dtList = return_st.Tables[0];
               

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pPOPProductionOrderEntity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩
                    _gdMAIN_VIEW.RowHeight = 80;
                    _gdMAIN_VIEW.Appearance.Row.Font = new Font("굴림", 18);
                    _gdMAIN_VIEW.RowStyle += new RowStyleEventHandler(gdMAIN_VIEW_RowStyle);

                    RepositoryItemMemoEdit noteMemo = new RepositoryItemMemoEdit();
                    noteMemo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                    // noteMemo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                    //  noteMemo.apprea
                    _gdMAIN_VIEW.Columns["PART_NAME"].ColumnEdit = noteMemo;
                    this._gdMAIN_VIEW.OptionsView.RowAutoHeight = true;

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
        //공정 이미지 생성
        public void set_Process_Image()
        {
            DataSet return_st = null;
            DataTable Process_dt = null;

            return_st = new POPProductionOrderBusiness().POPProductionOrder_Info2(_pPOPProductionOrderEntity);
            Process_dt = return_st.Tables[1];
            string tmp = string.Empty;
            if (Process_dt.Rows.Count > 0)
            {

                tmp = Process_dt.Rows[0][0].ToString();
                for (int i = 1; i < Process_dt.Rows.Count - 1; i++)
                {
                    tmp = tmp + " > " + Process_dt.Rows[i][0].ToString();
                }
                tmp = tmp + " > " + Process_dt.Rows[Process_dt.Rows.Count - 1][0].ToString();
            }
            //_lbPROCESS_INFO.Text = tmp;

            if (_pPOPProductionOrderEntity.CRUD == "") _dtList.Rows.Clear();
            ////////////

            // for (int i = 0; i < Process_dt.Rows.Count; i++)
            for (int i = Process_dt.Rows.Count; i > 1; --i)
            {
                Label lc = new Label();
                //lc.Name = "lc_" + i.ToString();
                lc.Name = "lc_" + Process_dt.Rows[i-1]["process_name"].ToString().ToString();
                lc.Font = new Font("Tahoma", 20, FontStyle.Bold); // Font 설정
                                                                  // lc.Text = "프린터" + i.ToString();
                //lc.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;//DevExpress.Utils.ha
                lc.Text = Process_dt.Rows[i-1]["process_name"].ToString();
                lc.Padding = new Padding(10, 0, 10, 0);
                lc.Margin = new Padding(0);
                lc.Dock = DockStyle.Fill;
                lc.AutoSize = false;
                lc.TextAlign = ContentAlignment.MiddleCenter;
                lc.BackColor = Color.Transparent;
                Panel pn = new Panel();
                pn.BackgroundImage = global::CoFAS_MES.POP.Properties.Resources.process_icon;
                pn.BackgroundImageLayout = ImageLayout.Zoom;
                //pn.BackgroundImage.Siz
                pn.Controls.Add(lc);
                pn.Dock = DockStyle.Left;
                panel6.Controls.Add(pn);



            }
            ////////////
        }
        private void gdMAIN_VIEW_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            //if (((e.State & DevExpress.XtraGrid.Views.Base.GridRowCellState.Focused) != 0) && ((e.State & DevExpress.XtraGrid.Views.Base.GridRowCellState.GridFocused) != 0))
            //    e.Appearance.Assign(view.PaintAppearance.FocusedRow);
            if (view.FocusedRowHandle == e.RowHandle)
            {
                e.Appearance.BackColor = Color.Orange;
                e.Appearance.Font = new Font("굴림", 18, FontStyle.Bold);
            }
        }

        private void _ucbtRESULT_REG_Click(object sender, EventArgs e)
        {
            if((_pPOPProductionOrderEntity.PRODUCTION_ORDER_ID=="")|| (_pPOPProductionOrderEntity.PRODUCTION_ORDER_ID ==null))
            {
                CoFAS_DevExpressManager.ShowInformationMessage("작업지시를 선택해주세요.");
                return;
            }
            // 실적등록
            frmPopupKeypad frmkey = new frmPopupKeypad();
            if (frmkey.ShowDialog() == DialogResult.OK)
            {
                string PopupValue = frmkey.ReturnValue1;

                _pPOPProductionOrderEntity.COLLECTION_DATE = System.DateTime.Now.ToString("yyyyMMddHHmmssfff");
                _pPOPProductionOrderEntity.PRODUCTION_OK_QTY = PopupValue;
                _pPOPProductionOrderEntity.CRUD = "C";
                _pPOPProductionOrderEntity.USER_CODE = _pUSER_CODE;


                bool isError = false;


                isError = new frmPOPMain_PRODUCT_BIOCERRABusiness().frmPOPMain_PRODUCT_BIOCERRA_Result_Sub1(_pPOPProductionOrderEntity);

                if (isError)
                {
                    //오류 발생.
                    CoFAS_DevExpressManager.ShowInformationMessage("저장 오류 발생! 데이터를 확인 하세요.");
                  //  CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                    //화면 표시.

                }
                else
                {

                    CoFAS_DevExpressManager.ShowInformationMessage("저장 처리 되었습니다.");
                    //CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);

                }
                } 
        }

        private void _ucbtNG_REG_Click(object sender, EventArgs e)
        {
            if ((_pPOPProductionOrderEntity.PRODUCTION_ORDER_ID == "") || (_pPOPProductionOrderEntity.PRODUCTION_ORDER_ID == null))
            {
                CoFAS_DevExpressManager.ShowInformationMessage("작업지시를 선택해주세요.");
                return;
            }

            // 불량처리
            frmPOPBad frmb = new frmPOPBad();
            if (frmb.ShowDialog() == DialogResult.OK)
            {
                string PopupValue = frmb.ReturnValue1;

                _pPOPProductionOrderEntity.COLLECTION_DATE = System.DateTime.Now.ToString("yyyyMMddHHmmssfff");
                _pPOPProductionOrderEntity.PRODUCTION_NG_QTY = PopupValue;
                _pPOPProductionOrderEntity.CRUD = "C";
                _pPOPProductionOrderEntity.USER_CODE = _pUSER_CODE;
                _pPOPProductionOrderEntity.BAD_CODE = frmb.ReturnValue2;

                bool isError = false;


                isError = new frmPOPMain_PRODUCT_BIOCERRABusiness().frmPOPMain_PRODUCT_BIOCERRA_Result_Sub2(_pPOPProductionOrderEntity);

                if (isError)
                {
                    //오류 발생.
                    CoFAS_DevExpressManager.ShowInformationMessage("저장 오류 발생! 데이터를 확인 하세요.");
                    //화면 표시.

                }
                else
                {
                    //정상 처리
                    CoFAS_DevExpressManager.ShowInformationMessage("저장 처리 되었습니다.");

                }
                }
        }

        //작업완료

        private void _ucbtCOMPLETE_REG_Click(object sender, EventArgs e)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                if ((_pPOPProductionOrderEntity.PRODUCTION_ORDER_ID == "") || (_pPOPProductionOrderEntity.PRODUCTION_ORDER_ID == null))
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("작업지시를 선택해주세요.");
                    return;
                }

                bool isError = false;
                //_pWorkResultRegister_T09Entity.CRUD = "U";       



                _pPOPProductionOrderEntity.CRUD = "U";
                _pPOPProductionOrderEntity.USER_CODE = _pUSER_CODE;
                _pPOPProductionOrderEntity.COMPLETE_YN = "Y";
                

                isError = new frmPOPMain_PRODUCT_BIOCERRABusiness().WorkResultMst_Save(_pPOPProductionOrderEntity);
                if (!isError)
                {
                    //정상 처리
                    CoFAS_DevExpressManager.ShowInformationMessage("저장 처리 되었습니다.");
                    
                    //_pWorkResultRegister_T09Entity.CRUD = "R";
                    MainFind_DisplayData();
                }
                else
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("저장 오류 발생! 데이터를 확인 하세요.");
                }
                //Form_SearchButtonClicked(null, null); //2018.12.18 저장 후 조회 안되는 관계로 밖으로 빼둠. 
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

        public void Size_reset()
        {
            FontResize(_lbWORK_ORDER_QTY);
            FontResize(_lbPartName);

        }
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
    }
}

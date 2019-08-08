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

namespace CoFAS_MES.POP
{
    public partial class frmPOPMain_OUT_COSMETICS : frmBasePOP
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

        private DataTable _dtList = null; //조회 데이터 리스트
        private DataTable _dtList2 = null; //조회 데이터 리스트
        private DataTable _rt_dtList = null; //조회 데이터 리스트

        private string _pLocation_Code = string.Empty;  // 저장/수정 후 로케이션 위치 저장
        private bool _pLocation_YN = true;              // 저장위치 사용여부


        private CoFAS_Serial _pBarcode_Serial = null;  // 바코드 시리얼 생성
        private string COM_PORT = string.Empty;



        public UserEntity _pUserEntity = null;
        public MessageEntity _pMessageEntity = null; //공통 메세지 엔티티
        private frmPOPMain_OUT_COSMETICSEntity _pfrmPOPMain_OUT_COSMETICSEntity = null; // 엔티티 생성

        public frmPOPMain_OUT_COSMETICS(UserEntity pUserEntity)
        {
            InitializeComponent();

            _pUserEntity = pUserEntity;

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
                _pfrmPOPMain_OUT_COSMETICSEntity = new frmPOPMain_OUT_COSMETICSEntity();
                _pfrmPOPMain_OUT_COSMETICSEntity.CORP_CODE = _pCORP_CDDE;
                _pfrmPOPMain_OUT_COSMETICSEntity.USER_CODE = _pUSER_CODE;
                _pfrmPOPMain_OUT_COSMETICSEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                _pfrmPOPMain_OUT_COSMETICSEntity.TERMINAL_CODE = "TP010005";
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
                SetHardware();

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
                    //  _gdSUB_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB, _gdSUB_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdSUB.Name.ToString()));

                    _gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick; ;
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
              //  _pfrmPOPMain_OUT_COSMETICSEntity.INOUT_ID = gv.GetFocusedRowCellValue("INOUT_ID").ToString();
              //  _pfrmPOPMain_OUT_COSMETICSEntity.REFERENCE_ID = gv.GetFocusedRowCellValue("SHIPMENT_ID").ToString();
              //  _pfrmPOPMain_OUT_COSMETICSEntity.PART_CODE = gv.GetFocusedRowCellValue("PART_CODE").ToString();
              //  _pfrmPOPMain_OUT_COSMETICSEntity.PART_NAME = gv.GetFocusedRowCellValue("PART_NAME").ToString();

               // _pINSPECT_CHECK_YN = false;
               // if (gv.GetFocusedRowCellValue("INSPECT_STATUS").ToString() != "QC010001")
               // {
               //     if (gv.GetFocusedRowCellValue("INSPECT_STATUS").ToString() != "")
               //     {
               //         _pINSPECT_CHECK_YN = true;
               //     }
               // }

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }


        #region ○ 메인조회 - MainFind_DisplayData()

        private void MainFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _pfrmPOPMain_OUT_COSMETICSEntity = new frmPOPMain_OUT_COSMETICSEntity();
                _pfrmPOPMain_OUT_COSMETICSEntity.CRUD = "R";
                _pfrmPOPMain_OUT_COSMETICSEntity.DATE_FROM = "R";
                _pfrmPOPMain_OUT_COSMETICSEntity.DATE_TO = "R";
                _pfrmPOPMain_OUT_COSMETICSEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                _dtList = new frmPOPMain_OUT_COSMETICSBusiness().frmPOPMain_OUT_COSMETICS_Info(_pfrmPOPMain_OUT_COSMETICSEntity);
                //  _dtList = new frmPOPMain_OUT_COSMETICSBusiness().frmPOPMain_OUT_COSMETICS_Info(_pCRUD, FromDATE, ToDATE, strCODE, strNAME).Tables[0];
                if (_pfrmPOPMain_OUT_COSMETICSEntity.CRUD == "") _dtList.Rows.Clear();


                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pfrmPOPMain_OUT_COSMETICSEntity.CRUD == ""))
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
                    _gdMAIN_VIEW.RowCellStyle += new RowCellStyleEventHandler(gdMAIN_VIEW_RowCellStyle);
                   // 
                   // if (_pLocation_Code != "" && _pLocation_YN)
                   // {
                   //     int rowHandle = _gdMAIN_VIEW.LocateByValue("SHIPMENT_ID", _pfrmPOPMain_OUT_COSMETICSEntity.sh);
                   //     if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                   //         _gdMAIN_VIEW.FocusedRowHandle = rowHandle;
                   //     
                   //     //조회 후 초기화 
                   //     _pLocation_Code = "";
                   // }
                   //

                  //  _gdMAIN_VIEW.Appearance.FocusedRow.BackColor = Color.Red;


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


        #region ○ H/W 세팅시
        private void GetBarcodeComPort()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _dtList = new BarcodeLabelPrintBusiness().BarcodeLabelPrint_COM_Info(_pfrmPOPMain_OUT_COSMETICSEntity.LANGUAGE_TYPE, _pfrmPOPMain_OUT_COSMETICSEntity.TERMINAL_CODE);
                _rt_dtList = _dtList;
                COM_PORT = "";
                if (_dtList != null && _dtList.Rows.Count > 0)//&& _dtList.Rows.Count > 0) )|| (_dtList != null && _pBarcodeLabelPrintEntity.CRUD == ""))
                {
                    //  CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩

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
                _pBarcode_Serial = new CoFAS_Serial(COM_PORT, 9600, "NONE", 8, "ONE");

                _pBarcode_Serial.Open();
                _pBarcode_Serial.evtReceived += new CoFAS_Serial.delReceive(_Barcode_Received_Data);
                if (_pBarcode_Serial.IsOpen)
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
                _pBarcode_Serial = new CoFAS_Serial();
            }

        }

        void _Barcode_Received_Data(byte[] yReceiveData)
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

                        pDataSet = new BarcodeLabelPrintBusiness().BarcodeLabelPrint_inspect_Info(_pfrmPOPMain_OUT_COSMETICSEntity.LANGUAGE_TYPE, "DOC", pFindData);
                        _dtList = pDataSet.Tables[0];
                        _dtList2 = pDataSet.Tables[1];
                        if (_dtList != null && _dtList.Rows.Count > 0)
                        {
                            vPart_code = _dtList.Rows[0]["part_code"].ToString();
                            vMake_no = _dtList.Rows[0]["make_no"].ToString();
                            vInspect_no = _dtList.Rows[0]["inspect_no"].ToString();
                            vVend_Part_Code = _dtList.Rows[0]["vend_part_code"].ToString();
                            vReference_id = _dtList2.Rows[0]["shipment_id"].ToString(); // _dtList.Rows[0]["reference_id"].ToString();

                            FindPartCode(vPart_code, vVend_Part_Code, vMake_no, vInspect_no, vReference_id);
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

                    _pfrmPOPMain_OUT_COSMETICSEntity.CRUD = "R";
                    _pfrmPOPMain_OUT_COSMETICSEntity.USER_CODE = _pUSER_CODE;
                    //_pPOPSelect_INSPECT_COSMETICSEntity.PART_CODE = _luPART_CODE.Text;
                    pFindData = CoFAS_ConvertManager.Bytes2String(yReceiveData, 0, 0);
                    pFindData = pFindData.Substring(0, pFindData.Length - 4);//뒤에 개행문자 지울경우(2자리)
                    frmPOPPartStockCheck frmkey = new frmPOPPartStockCheck(_pUserEntity);
                    frmkey.titleName = "완제품재고확인";
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


        #endregion
        //품목코드 찾기(저울스캔시) 
        private void FindPartCode(string pPart_code, string pVend_Part_code, string  make_no, string inspect_code, string pReference_id)
        {
            bool find_cnt = false;

            //int rowHandle = _gdMAIN_VIEW.LocateByValue("PART_CODE", pPart_code);
            int rowHandle = _gdMAIN_VIEW.LocateByValue("SHIPMENT_ID", pReference_id);
            if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                {
                    CoFAS_ControlManager.InvokeIfNeeded(_gdMAIN, () => _gdMAIN_VIEW.FocusedRowHandle = rowHandle);
                    //_gdMAIN_VIEW.FocusedRowHandle = rowHandle;
                  //  SubFind_DisplayData("R", _gdMAIN_VIEW.GetFocusedRowCellValue("PART_CODE").ToString());
                    find_cnt = true;

                    }
                else
                {
                    find_cnt = false;
                }
                //cell.RowIndex

                if (!find_cnt)
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("일치하지 않는번호입니다.");
                }

        }
        
        private void _ucbtIN_REG_Click(object sender, EventArgs e)
        {
            // pfrmPOPMain_WEIGHING_COSMETICSEntity.CORP_CODE = _pCORP_CODE;
            _pfrmPOPMain_OUT_COSMETICSEntity.USER_CODE = _pUserEntity.USER_CODE;
            int cnt = 0;
            DataTable tDataTable = _gdMAIN_VIEW.GridControl.DataSource as DataTable;

            if (CoFAS_DevExpressManager.ShowQuestionMessage("출고를 하시겠습니까?") == DialogResult.Yes)
            {
                _pfrmPOPMain_OUT_COSMETICSEntity.CRUD = "C";
                _pfrmPOPMain_OUT_COSMETICSEntity.INOUT_CODE = "PD040001";   //PD040001 = 매출출고 = 수주출고

                bool isError;
                isError = new frmPOPMain_OUT_COSMETICSBusiness().frmPOPMain_OUT_COSMETICS_Info_Save(_pfrmPOPMain_OUT_COSMETICSEntity, tDataTable);

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
                    _pLocation_Code = _pfrmPOPMain_OUT_COSMETICSEntity.RTN_KEY;  //저장 위치 
                    MainFind_DisplayData();



                }
            }
        }

        private void _ucbtKEYPAD_Click(object sender, EventArgs e)
        {
            //키패드 호출
            frmPopupKeypad frmkey = new frmPopupKeypad();
            // frmkey.titleName ="수량입력";
            if (frmkey.ShowDialog() == DialogResult.OK)
            {
                string PopupValue = frmkey.ReturnValue1;
                //_gdSUB_VIEW.GetFocusedRowCellValue(_gdSUB_VIEW.Columns["INPUT_QTY"]).ToString()
                _gdMAIN_VIEW.SetFocusedRowCellValue(_gdMAIN_VIEW.Columns["INPUT_QTY"], PopupValue);
            }

        }

        private void _ucbtMATERIAL_ORDER_Click(object sender, EventArgs e)
        {
            MainFind_DisplayData();
        }

        private void _ucbtPART_STOCK_Click(object sender, EventArgs e)
        {
            _pPART_STOCK_YN = _pPART_STOCK_YN == false ? true : false;
        }
    }
}

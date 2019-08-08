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

namespace CoFAS_MES.POP
{
    public partial class frmPOPMain_SEMIPRODUCT_COSMETICS : frmBasePOP
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

        private CoFAS_Serial _pBarcode_Serial = null;  // 바코드 시리얼 생성

        private string COM_PORT = string.Empty;

        private DataTable _dtList = null; //조회 데이터 리스트
        private DataTable _rt_dtList = null; //조회 데이터 리스트

        public UserEntity _pUserEntity = null;
        private POPSelect_INSPECT_COSMETICSEntity _pPOPSelect_INSPECT_COSMETICSEntity = null; // 엔티티 생성

        private POPProductionOrderEntity _pPOPProductionOrderEntity = null; // 엔티티 생성


        public MessageEntity _pMessageEntity = null; //공통 메세지 엔티티

        #region 사용자 개체 - UserEntity

        public UserEntity UserEntity
        {
            get
            {
                return _pUserEntity;
            }
            set
            {
                _pUserEntity = value;
            }
        }

        #endregion


        #region 메세지 개체 - MessageEntity

        public MessageEntity MessageEntity
        {
            get
            {
                return _pMessageEntity;
            }
            set
            {
                _pMessageEntity = value;
            }
        }

        #endregion

        public frmPOPMain_SEMIPRODUCT_COSMETICS(UserEntity pUserEntity)
        {
            InitializeComponent();

            _pUserEntity = pUserEntity;

            _pUserEntity.PROCESS_CODE = "PC010001";

            _pMessageEntity = new MessageEntity();

            _pFONT_SETTING = new Font(_pUserEntity.FONT_TYPE, _pUserEntity.FONT_SIZE);

            //_lbUserName.Text = _pUserEntity.USER_NAME;


            //시스템 세팅 버튼
            /*
                if (_pUserEntity.USER_GRANT == "PC160001")
                {
                    _btSystem_Setting.Visible = true;
                }
                else
                {
                    _btSystem_Setting.Visible = false;
                }
            */

            Activated += new EventHandler(Form_Activated);
            FormClosing += new FormClosingEventHandler(Form_Closing);
            FormClosed += new FormClosedEventHandler(Form_FormClosed);
            Load += new EventHandler(Form_Load);
        }

        private void InitializeLanguage()
        {



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
                //_pUSER_CODE = "admin@coever.co.kr";// MainForm.UserEntity.USER_CODE;
                //_pUSER_NAME = "";//MainForm.UserEntity.USER_NAME;
                //_pLANGUAGE_TYPE = MainForm.UserEntity.LANGUAGE_TYPE;
                //_pFONT_TYPE = MainForm.UserEntity.FONT_TYPE;

                //메인 화면 전역 변수 처리
                //_pCORP_CODE = MainForm.UserEntity.CORP_CODE;
                //_pUSER_CODE = MainForm.UserEntity.USER_CODE;
                //_pUSER_NAME = MainForm.UserEntity.USER_NAME;
                //_pLANGUAGE_TYPE = MainForm.UserEntity.LANGUAGE_TYPE;
                //_pFONT_TYPE = MainForm.UserEntity.FONT_TYPE;
                //_pFONT_SIZE = MainForm.UserEntity.FONT_SIZE;
                //_pFONT_SETTING = new Font(_pFONT_TYPE, _pFONT_SIZE);


                _pWINDOW_NAME = this.Name;
                _pLANGUAGE_TYPE = _pUserEntity.LANGUAGE_TYPE;
                _lbTitle.Text = _pUserEntity.POP_TITLE;
                _lbHeader.Text = "";
                DisplayMessage("");

                _luPART_NAME.Text = "";
                _luPART_CODE.Text = "";
                _luORDER_ID.Text = "";
                _luORDER_DATE.Text = "";
                _luORDER_QTY.Text = "";
                _luNG_QTY.Text = "";
                _luRESULT_QTY.Text = "";
                _luOK_QTY.Text = "";

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
                //화면 컨트롤러 설정
                InitializeControl();
                //화면 설정 언어 & 명칭 변경. ==고정==

                _pPOPSelect_INSPECT_COSMETICSEntity = new POPSelect_INSPECT_COSMETICSEntity();
                _pPOPSelect_INSPECT_COSMETICSEntity.CORP_CODE = _pCORP_CDDE;
                _pPOPSelect_INSPECT_COSMETICSEntity.USER_CODE = _pUSER_CODE;
                _pPOPSelect_INSPECT_COSMETICSEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                _pPOPSelect_INSPECT_COSMETICSEntity.PROCESS_CODE = "";
                _pPOPSelect_INSPECT_COSMETICSEntity.RESOURCE_CODE = "";
                _pPOPSelect_INSPECT_COSMETICSEntity.TERMINAL_CODE = "TP010004";
                //그리드 설정

                //   double ddd = Math.Acos(0.912);


                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                if (_pFirstYN)
                {

                    //글랜젠은 컬럼 비활성
                    if (DBManager.InitDatabaseName == "coever_mes_glenzen")
                    {
                        _ucbtINSPECT_REG.Visible = false;
                    }
                    _pFirstYN = false;
                }
                GetBarcodeComPort();
                // H/W 연결 설정
                SetHardware();

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


        #region ○ H/W 세팅시
        private void GetBarcodeComPort()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _dtList = new BarcodeLabelPrintBusiness().BarcodeLabelPrint_COM_Info(_pPOPSelect_INSPECT_COSMETICSEntity.LANGUAGE_TYPE, _pPOPSelect_INSPECT_COSMETICSEntity.TERMINAL_CODE);
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

                //_pCoFAS_Serial = new CoFAS_Serial(_dtList_terminal.Rows[0]["INFO_PORTNAME"].ToString(), Convert.ToInt32(_dtList_terminal.Rows[0]["INFO_BAUDRATE"].ToString()), _dtList_terminal.Rows[0]["INFO_PARITY"].ToString(), Convert.ToInt32(_dtList_terminal.Rows[0]["INFO_DATABITS"].ToString()), _dtList_terminal.Rows[0]["INFO_STOPBITS"].ToString());
                //_pBarcode_Serial = new CoFAS_Serial("COM3", 9600, "NONE", 8, "ONE");
                _pBarcode_Serial = new CoFAS_Serial(COM_PORT, 9600, "NONE", 8, "ONE");

                _pBarcode_Serial.Open();
                _pBarcode_Serial.evtReceived += new CoFAS_Serial.delReceive(_Barcode_Received_Data);
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
                    string temp = string.Empty;
                    temp = CoFAS_ConvertManager.Bytes2String(yReceiveData, 0, 0);
                    temp = temp.Substring(0, temp.Length - 2);//뒤에 개행문자 지울경우(2자리)
                                                              // FindPartCode(temp);
                                                              //종료시 close시키기
                                                              //엑셀로 커서가게
                                                              //바코드세팅 com번호 가져오게하기
                                                              //기존 USP_BarcodeLabelPrint_R30를 수정하여 같이쓰게 하든가 아니면 별도로 가져오게하기
                                                              //dispose 예외처리하기
                }

                Application.DoEvents(); //화면초기화
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

        private void _ucbtWORK_ORDER_Click(object sender, EventArgs e)
        {
            //작업지시
            frmPOPOrder.PROCESS_MST_CODE_COSMETICS = "ALL";
            frmPOPOrder frmOr = new frmPOPOrder(_pUserEntity);
            frmOr.ShowDialog();
                if (frmOr.dtReturn == null)
                {
                    frmOr.Dispose();
                    return;
                }

                if (frmOr.dtReturn != null && frmOr.dtReturn.Rows.Count > 0)
                {
                    _luORDER_ID.Text = frmOr.dtReturn.Rows[0]["PRODUCTION_ORDER_ID"].ToString();
                    _luORDER_DATE.Text = frmOr.dtReturn.Rows[0]["PRODUCTION_ORDER_DATE"].ToString();
                    _luORDER_QTY.Text = frmOr.dtReturn.Rows[0]["PRODUCTION_ORDER_QTY"].ToString();
                    _luPART_NAME.Text = frmOr.dtReturn.Rows[0]["PART_NAME"].ToString();
                    // _luPART_CODE.Text = frmOr.dtReturn.Rows[0]["PART_CODE"].ToString();
                    _luPART_CODE.Text = frmOr.dtReturn.Rows[0]["VEND_PART_CODE"].ToString();
                    _luNG_QTY.Text = frmOr.dtReturn.Rows[0]["NG_QTY"].ToString();
                    _luRESULT_QTY.Text = frmOr.dtReturn.Rows[0]["RESULT_QTY"].ToString();
                    _luOK_QTY.Text = frmOr.dtReturn.Rows[0]["OK_QTY"].ToString();
                _pPOPSelect_INSPECT_COSMETICSEntity.PART_CODE = frmOr.dtReturn.Rows[0]["PART_CODE"].ToString();
                if (frmOr.dtReturn.Rows[0]["INSPECT_STATUS"].ToString() != "QC010001")
                {
                    if (frmOr.dtReturn.Rows[0]["INSPECT_STATUS"].ToString() != "")
                    {
                        _pINSPECT_CHECK_YN = true;
                    }
               }

                

            }


            frmOr.Dispose();
        }

        private void _ucbtINSPECT_REG_Click(object sender, EventArgs e)
        {
            if(_luORDER_ID.Text=="")
            {
                CoFAS_DevExpressManager.ShowInformationMessage("작업지시를 먼저 선택해주세요.");
                return;
            }
            if(_pINSPECT_CHECK_YN)
            { 
                    CoFAS_DevExpressManager.ShowInformationMessage("이미 시험의뢰를 맡긴 발주가 있습니다.");
                    return;
            }
            //검사등록
            if (CoFAS_DevExpressManager.ShowQuestionMessage("'"+_luPART_NAME.Text+"'을(를) 시험의뢰 하시겠습니까?") == DialogResult.Yes)
            {
                _pPOPSelect_INSPECT_COSMETICSEntity.CRUD = "C";
                _pPOPSelect_INSPECT_COSMETICSEntity.PRODUCTION_ORDER_ID = _luORDER_ID.Text;
                //_pPOPSelect_INSPECT_COSMETICSEntity.PART_CODE = _luPART_CODE.Text;
                bool isError;
                isError = new frmPOPMain_SEMIPRODUCT_COSMETICSBusiness().frmPOPMain_PRODUCT_COSMETIC_Info_Check_Save(_pPOPSelect_INSPECT_COSMETICSEntity);

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
                    _pPOPSelect_INSPECT_COSMETICSEntity.CRUD = "R";
                    _pPOPSelect_INSPECT_COSMETICSEntity.PRODUCTION_ORDER_ID = "";
                    _pPOPSelect_INSPECT_COSMETICSEntity.PART_CODE = "";

                    MainFind_DisplayData();
                    // MainFind_DisplayData();
                }
            }
        }

        private void _ucbtRESULT_REG_Click(object sender, EventArgs e)
        {
            //HPNC일경우 제조에서 검사의뢰 통과에 대해서 실적등록
            if (DBManager.InitDatabaseName != "coever_mes_glenzen")
                {
                    // 실적등록
                    _pUserEntity.PRODUCTION_ORDER_ID = _luORDER_ID.Text;
                    frmPOPSelect_INSPECT_COSMETICS frmkey = new frmPOPSelect_INSPECT_COSMETICS(_pUserEntity);
                    if (frmkey.ShowDialog() == DialogResult.OK)
                    {
                        //string PopupValue = frmkey.ReturnValue1;
                        //DisplayMessage(_ucbtRESULT_REG.Text + " -> " + PopupValue);
                        MainFind_DisplayData();
                    }
                }
            else
            //글랜젠용, 검사의뢰없이 실적등록
            {
                // 실적등록
                SimpleButton pCmd = sender as SimpleButton;

                frmPopupKeypad frmkey = new frmPopupKeypad();
                frmkey.titleName = pCmd.Text;

                //실적등록에서 OK누를경우 리턴값
                string PopupValue = string.Empty;
                if (frmkey.ShowDialog() == DialogResult.OK)
                {

                    PopupValue = frmkey.ReturnValue1;
                    //리턴값이 빈값이 아니고 0도 아닐경우 실적등록
                    if (PopupValue != "0" && PopupValue != "")
                    {
                        _pPOPSelect_INSPECT_COSMETICSEntity.RESOURCE_CODE = "";// _luPROCESS_CODE.GetValue();
                        _pPOPSelect_INSPECT_COSMETICSEntity.COLLECTION_DATE = DateTime.Now.ToString("yyyyMMddHHmmss");
                        _pPOPSelect_INSPECT_COSMETICSEntity.PROPERTY_VALUE = _luORDER_ID.Text; ;// _pPOPProductionOrderEntity.PRODUCTION_ORDER_ID;// _gdMAIN_VIEW.GetFocusedRowCellValue("PRODUCTION_ORDER_ID").ToString();
                        //CD501001 : 양품
                        //CD501002 : 불량
                        _pPOPSelect_INSPECT_COSMETICSEntity.CONDITION_CODE = "CD501001";
                        _pPOPSelect_INSPECT_COSMETICSEntity.COLLECTION_VALUE = PopupValue.Replace(",", "");

                        bool isError = false;
                        isError = new frmPOPMain_PRODUCT_COSMETICSBusiness().frmPOPMain_PRODUCT_COSMETICS_Save(_pPOPSelect_INSPECT_COSMETICSEntity);

                        if (!isError)
                            //this.DialogResult = DialogResult.OK; 
                                MainFind_DisplayData();
                        //작업지시상태 업데이트

                    }
                }
            }
        }

        private void MainFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _pPOPProductionOrderEntity = new POPProductionOrderEntity();
                _pPOPProductionOrderEntity.CORP_CODE = _pUserEntity.CORP_CODE;
                _pPOPProductionOrderEntity.USER_CODE = _pUserEntity.USER_CODE;
                _pPOPProductionOrderEntity.LANGUAGE_TYPE = _pUserEntity.LANGUAGE_TYPE;
                _pPOPProductionOrderEntity.PROCESS_CODE = _pUserEntity.PROCESS_CODE;
                _pPOPProductionOrderEntity.RESOURCE_CODE = _pUserEntity.RESOURCE_CODE;
                _pPOPProductionOrderEntity.PRODUCTION_ORDER_ID = _luORDER_ID.Text;

                _dtList = new POPProductionOrderBusiness().POPProductionOrder_Info_2(_pPOPProductionOrderEntity);

                if (_pPOPProductionOrderEntity.CRUD == "") _dtList.Rows.Clear();


                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pPOPProductionOrderEntity.CRUD == ""))
                {
                    _luORDER_ID.Text = _dtList.Rows[0]["PRODUCTION_ORDER_ID"].ToString();
                    _luORDER_DATE.Text = _dtList.Rows[0]["PRODUCTION_ORDER_DATE"].ToString();
                    _luORDER_QTY.Text = _dtList.Rows[0]["PRODUCTION_ORDER_QTY"].ToString();
                    _luPART_NAME.Text = _dtList.Rows[0]["PART_NAME"].ToString();
                    // _luPART_CODE.Text = frmOr.dtReturn.Rows[0]["PART_CODE"].ToString();
                    _luPART_CODE.Text = _dtList.Rows[0]["VEND_PART_CODE"].ToString();
                    _luNG_QTY.Text = _dtList.Rows[0]["PRODUCTION_NG_QTY"].ToString();
                    _luRESULT_QTY.Text = _dtList.Rows[0]["PRODUCTION_RESULT_QTY"].ToString();
                    _luOK_QTY.Text = _dtList.Rows[0]["PRODUCTION_OK_QTY"].ToString();
                    _pPOPSelect_INSPECT_COSMETICSEntity.PART_CODE = _dtList.Rows[0]["PART_CODE"].ToString();
                    if (_dtList.Rows[0]["INSPECT_STATUS"].ToString() != "QC010001")
                    {
                        if (_dtList.Rows[0]["INSPECT_STATUS"].ToString() != "")
                        {
                            _pINSPECT_CHECK_YN = true;
                        }
                    }


                    // CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩
                    // _gdMAIN_VIEW.RowHeight = 80;
                    // _gdMAIN_VIEW.Appearance.Row.Font = new Font("굴림", 18);
                    // _gdMAIN_VIEW.RowStyle += new RowStyleEventHandler(gdMAIN_VIEW_RowStyle);
                    // //_gdMAIN_VIEW.Appearance.SelectedRow.Options.UseBackColor = true;
                    // //_gdMAIN_VIEW.OptionsSelection.EnableAppearanceFocusedRow = true;
                    // //_gdMAIN_VIEW.OptionsView.EnableAppearanceEvenRow = true;
                    // //_gdMAIN_VIEW.Appearance.EvenRow.BackColor = Color.Red;
                    // 
                    // //_gdMAIN_VIEW.OptionsSelection.MultiSelect = true;
                    // //_gdMAIN_VIEW.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
                    // 
                    // _gdMAIN_VIEW.Appearance.FocusedRow.BackColor = Color.Red;
                    // 
                    // 
                    // //_gdMAIN_VIEW.Appearance.SelectedRow.Options.UseBackColor = true;
                    // //_gdMAIN_VIEW.Appearance.SelectedRow.BackColor = Color.LightSeaGreen;

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

        private void _ucbtNG_REG_Click(object sender, EventArgs e)
        {
            if (_luORDER_ID.Text == "")
            {
                CoFAS_DevExpressManager.ShowInformationMessage("작업지시를 먼저 선택해주세요.");
                return;
            }

            // 불량처리
            frmPOPBad frmb = new frmPOPBad();
            string PopupValue = string.Empty;
            string PopupValue2 = string.Empty;
            
            if (frmb.ShowDialog() == DialogResult.OK)
            {
                PopupValue = frmb.ReturnValue1;
                PopupValue2 = frmb.ReturnValue2;

                //리턴값이 빈값이 아니고 0도 아닐경우 실적등록
                if (PopupValue != "0" && PopupValue != "")
                {
                    _pPOPSelect_INSPECT_COSMETICSEntity.RESOURCE_CODE = "";// _luPROCESS_CODE.GetValue();
                    _pPOPSelect_INSPECT_COSMETICSEntity.COLLECTION_DATE = DateTime.Now.ToString("yyyyMMddHHmmss");
                    _pPOPSelect_INSPECT_COSMETICSEntity.PROPERTY_VALUE =_luORDER_ID.Text;
                    //CD501001 : 양품
                    //CD501002 : 불량
                    _pPOPSelect_INSPECT_COSMETICSEntity.CONDITION_CODE = PopupValue2.Replace(",", ""); ;
                    _pPOPSelect_INSPECT_COSMETICSEntity.COLLECTION_VALUE = PopupValue.Replace(",", "");

                    bool isError = false;
                    isError = new frmPOPMain_SEMIPRODUCT_COSMETICSBusiness().frmPOPMain_SEMIPRODUCT_COSMETICS_Save(_pPOPSelect_INSPECT_COSMETICSEntity);
                    if (!isError)
                        MainFind_DisplayData();
                }
                //string PopupValue = frmb.ReturnValue1;
                //DisplayMessage(_ucbtNG_REG.Text + " -> " + PopupValue);
            }
        }
    }
}

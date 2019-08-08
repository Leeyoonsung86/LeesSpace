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
using CoFAS_MES.CORE.Business;
using DevExpress.XtraGrid.Views.Grid;

namespace CoFAS_MES.POP
{
    public partial class frmPOPMain_PRESS_LINE : frmBasePOP
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
        public string sPRODUCTION_ORDER_ID = string.Empty;
        public string sREFERENCE_ID = string.Empty;

        public string _pPROCESS_CODE = string.Empty;
        public string _pPROCESS_NAME = string.Empty;
        

        private DataTable _dtList = null; //조회 데이터 리스트
        private DataTable _dtList_ng = null; /// 불량내역
        
        private bool _pLOT_COMPLETE = false;

        frmPOPMain_PRESS_LINEEntity pfrmPOPMain_PRESS_LINEEntity = null;

        public frmPOPMain_PRESS_LINE(UserEntity pUserEntity)
        {
            InitializeComponent();

            _pUserEntity = pUserEntity;
            _pCORP_CODE = _pUserEntity.USER_CODE;
            _pUSER_CODE = _pUserEntity.USER_NAME;
            _pLANGUAGE_TYPE = _pUserEntity.LANGUAGE_TYPE;
            _pPROCESS_CODE = _pUserEntity.PROCESS_CODE;
            _pPROCESS_NAME = _pUserEntity.PROCESS_NAME;
            _pFONT_TYPE = _pUserEntity.FONT_TYPE;
            _pFONT_SETTING = new Font(pUserEntity.FONT_TYPE, pUserEntity.FONT_SIZE);

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
                _gdMAIN_VIEW.CellValueChanged -= _gdMAIN_VIEW_CellValueChanged;
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

                _lbTitle.Text = _pPROCESS_NAME;
                _lbHeader.Text = "";
                DisplayMessage("");

                _pLOT_COMPLETE = true;

                //_lbcolumn_name1.Text = "집합체 코드" + "\n" + "FA CODE";
                //_lbcolumn_name2.Text = "로트번호" + "\n" + "LOT NO.";
                //_lbcolumn_name3.Text = "이동표번호" + "\n" + "MTC NO.";
                //_lbcolumn_name4.Text = "시방서번호" + "\n" + "SPEC. NO.";
                //_lbcolumn_name5.Text = "도면번호" + "\n" + "DRAWING NO.";
                //_lbcolumn_name6.Text = "작업지시번호" + "\n" + "W/O NO.";
                //_lbcolumn_name7.Text = "구매시방서번호" + "\n" + "PURCHASE SPEC. NO.";
                //_lbcolumn_name8.Text = "품번" + "\n" + "ITEM NO.";
                //_lbcolumn_name9.Text = "작업지시수량" + "\n" + "W/O NO.";
                //_lbcolumn_name10.Text = "주문서 번호" + "\n" + "P/O NO.";
                //_lbcolumn_name11.Text = "원자재기록서" + "\n" + "MATERIAL TRS NO.";
                //_lbcolumn_name12.Text = "생산량 누계" + "\n" + "TOTAL COUNT";


                //_lbRcolumn_name1.Text = "공정명" + "\n" + "PROCESS STEP";
                //_lbRcolumn_name2.Text = "절차서 번호" + "\n" + "Procedure No.";
                //_lbRcolumn_name3.Text = "수량" + "\n" + "Q`TY";
                //_lbRcolumn_name4.Text = "검사/합격수량" + "\n" + "Test/Accept. Q`ty";
                //_lbRcolumn_name5.Text = "제조자/검사자" + "\n" + "Manuf./Inspec" + "\n" + "날짜" + "\n" + "Date";
                //_lbRcolumn_name6.Text = "비고" + "\n" + "Remark";


                _lbCONTRACT_NUMBER.Text = "";
                _lbORDER_NUMBER.Text = "";
                _lbVEND_PART_CODE.Text = "";
                _lbPART_NAME.Text = "";
                _lbPRODUCTION_ORDER_DATE.Text = "";
                _lbPRODUCTION_ORDER_QTY.Text = "";
                _lbTPRODUCTION_OK_QTY.Text = "";
                _lbTPRODUCTION_PASS_QTY.Text = "";
                _lbTPRODUCTION_NG_QTY.Text = "";

                _lbLOT_NO.Text = "";
                _lbPRODUCTION_OK_QTY.Text = "";
                //_lbPRODUCTION_NG_QTY.Text = "";
                _lbPRODUCTION_PASS_QTY.Text = "";

                sPRODUCTION_ORDER_ID = "";
                sREFERENCE_ID = "";

                //메뉴 화면 엔티티 설정
                //_pDQGatheringEntity = new DQGatheringEntity();
                //_pDQGatheringEntity.CORP_CODE = _pCORP_CDDE;
                //_pDQGatheringEntity.USER_CODE = _pUSER_CODE;


                pfrmPOPMain_PRESS_LINEEntity = new frmPOPMain_PRESS_LINEEntity();
                pfrmPOPMain_PRESS_LINEEntity.CORP_CODE = _pCORP_CDDE;
                pfrmPOPMain_PRESS_LINEEntity.USER_CODE = _pUSER_CODE;
                pfrmPOPMain_PRESS_LINEEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                pfrmPOPMain_PRESS_LINEEntity.PROCESS_CODE = _pPROCESS_CODE;
                pfrmPOPMain_PRESS_LINEEntity.RESOURCE_CODE = "";


                _gdMAIN.Enabled = false;
                //화면 설정 언어 & 명칭 변경. ==고정==
                //DataTable dtLanguage = new LanguageBusiness().Language_Info(_pCORP_CDDE, _pWINDOW_NAME, _pLANGUAGE_TYPE);

                //if (dtLanguage != null && dtLanguage.Rows.Count > 0)
                //{
                //    CoFAS_ControlManager.Language_Info(dtLanguage, this);
                //}
                //화면 설정 언어 & 명칭 변경. ==고정==


                //그리드 설정

                //   double ddd = Math.Acos(0.912);



                //화면 컨트롤러 설정
                InitializeControl();

                //그리드 초기화 
                InitializeGrid();

                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                if (_pFirstYN)
                {

                    _pFirstYN = false;
                    _gdMAIN_VIEW.InitNewRow += _gdMAIN_VIEW_InitNewRow;
                    _gdMAIN_VIEW.RowUpdated += _gdMAIN_VIEW_RowUpdated;
                }

                // H/W 연결 설정
                //SetHardware();

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
                    _gdMAIN_VIEW.CellValueChanged += _gdMAIN_VIEW_CellValueChanged;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }


        #endregion

        #region ○ 메인 그리드 신규로우 생성시 이벤트 생성 - _gdMAIN_VIEW_InitNewRow(object sender, InitNewRowEventArgs e)
        private void _gdMAIN_VIEW_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            //view.SetRowCellValue(e.RowHandle, view.Columns["LANGUAGE_TYPE"], "한국어");
            view.SetRowCellValue(e.RowHandle, view.Columns["PROCESS_CODE"], _pPROCESS_CODE);
        }
        #endregion

        private void _gdMAIN_VIEW_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            if (pfrmPOPMain_PRESS_LINEEntity.PRODUCTION_ORDER_ID == null || pfrmPOPMain_PRESS_LINEEntity.PRODUCTION_ORDER_ID == "")
            {
                CoFAS_DevExpressManager.ShowInformationMessage("작업지시를 먼저 선택해주세요");
                return;
            }

            if(pfrmPOPMain_PRESS_LINEEntity.LOT_ID == null || pfrmPOPMain_PRESS_LINEEntity.LOT_ID == "")
            {
                CoFAS_DevExpressManager.ShowInformationMessage("LOT를 생성해주세요");
                return;
            }



            DataTable _dttemp = _gdMAIN.DataSource as DataTable;
            if (Convert.ToDecimal(_lbPRODUCTION_OK_QTY.Text.ToString()) <= 0) return;
            if(_dttemp.Rows.Count > 0)
            {
                decimal sumqty = 0;
                for(int i = 0; i < _dttemp.Rows.Count; i++)
                {
                    if (_dttemp.Rows[i]["PRODUCTION_NG_RESULT"].ToString() != "")
                    {
                        sumqty += Convert.ToDecimal(_dttemp.Rows[i]["PRODUCTION_NG_RESULT"].ToString());
                    }
                        
                }
                _lbPRODUCTION_PASS_QTY.Text = (Convert.ToDecimal(_lbPRODUCTION_OK_QTY.Text.ToString()) - sumqty).ToString();
            }
            else
            {
                _lbPRODUCTION_PASS_QTY.Text = (Convert.ToDecimal(_lbPRODUCTION_OK_QTY.Text.ToString())).ToString();
            }
        }

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
                        _lbPRODUCTION_OK_QTY.Text = PopupValue;
                        _gdMAIN.Enabled = true;
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
                    frmPOPOrder_T03 frmOr = new frmPOPOrder_T03(_pUserEntity);
                    frmOr.ShowDialog();

                    if (frmOr.dtReturn == null)
                    {
                        frmOr.Dispose();
                        return;
                    }

                    if (frmOr.dtReturn != null && frmOr.dtReturn.Rows.Count > 0)
                    {
                        _lbCONTRACT_NUMBER.Text = frmOr.dtReturn.Rows[0]["CONTRACT_NUMBER"].ToString();
                        _lbORDER_NUMBER.Text = frmOr.dtReturn.Rows[0]["ORDER_NUMBER"].ToString();
                        _lbVEND_PART_CODE.Text = frmOr.dtReturn.Rows[0]["VEND_PART_CODE"].ToString();
                        _lbPART_NAME.Text = frmOr.dtReturn.Rows[0]["PART_NAME"].ToString();
                        _lbPRODUCTION_ORDER_DATE.Text = frmOr.dtReturn.Rows[0]["PRODUCTION_ORDER_DATE"].ToString();
                        _lbPRODUCTION_ORDER_QTY.Text = frmOr.dtReturn.Rows[0]["PRODUCTION_ORDER_QTY"].ToString();
                        _lbTPRODUCTION_OK_QTY.Text = frmOr.dtReturn.Rows[0]["PRODUCTION_OK_QTY"].ToString();
                        _lbTPRODUCTION_PASS_QTY.Text = frmOr.dtReturn.Rows[0]["PRODUCTION_NG_QTY"].ToString();
                        _lbTPRODUCTION_NG_QTY.Text = frmOr.dtReturn.Rows[0]["PRODUCTION_PASS_QTY"].ToString();

                        sPRODUCTION_ORDER_ID = frmOr.dtReturn.Rows[0]["PRODUCTION_ORDER_ID"].ToString();
                        sREFERENCE_ID = frmOr.dtReturn.Rows[0]["REFERENCE_ID"].ToString();

                        _lbLOT_NO.Text = "";
                        _lbPRODUCTION_OK_QTY.Text = "";
                        //_lbPRODUCTION_NG_QTY.Text = "";
                        _lbPRODUCTION_PASS_QTY.Text = "";
                    }

                    break;

                default: break;
            }

        }

        #endregion


        #region ○ H/W 세팅시
        private void SetHardware()
        {
            // 연결 표기 부분 초기화
            //pnlDeviceConnect.Controls.Clear();

            // 연결할 H/W 갯수만큼 돌린다. (연동시 변경)
            for(int i = 0; i < 5; i++)
            {
                LabelControl lc = new LabelControl();
                lc.Name = "lc_" + i.ToString();
                lc.Font = new Font("Tahoma", 9, FontStyle.Bold); // Font 설정
                lc.Text = "프린터" + i.ToString();
                lc.Padding = new Padding(10, 0, 10, 0);
                lc.Margin = new Padding(0);
                lc.Appearance.Image = global::CoFAS_MES.POP.Properties.Resources.plug_Gray;
                lc.ImageAlignToText = ImageAlignToText.LeftCenter;
                lc.Dock = DockStyle.Right;
                

                pnlDeviceConnect.Controls.Add(lc);

                DisplayMessage(lc.Text + " OK");
            }


            DisplayMessage("POP Start Complete");
        }

        #endregion

        private void _gdMAIN_VIEW_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            _gdMAIN_VIEW.CellValueChanged -= _gdMAIN_VIEW_CellValueChanged;
            //ChangeValues(sender, e);
            _gdMAIN_VIEW_RowUpdated(sender, null);
            _gdMAIN_VIEW.CellValueChanged += _gdMAIN_VIEW_CellValueChanged;
        }

        //private void ChangeValues(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        //{
        //    GridView g = sender as GridView;

        //    int selectedRowNum = g.FocusedRowHandle;
        //    int selectedCellNum = g.FocusedColumn.VisibleIndex;
        //    if (selectedRowNum < 0) return;
        //    if(pfrmPOPMain_PRESS_LINEEntity.LOT_NO == null || pfrmPOPMain_PRESS_LINEEntity.LOT_NO == "")
        //    {
        //        g.CancelSelection();
        //        return;
        //    }

        //    if (g.GetRowCellDisplayText(selectedRowNum, "REFERENCE_ID").Equals(""))
        //    {
        //        g.SetFocusedRowCellValue("INOUT_CODE", "1002"); // 발주입고
        //    }
        //    else
        //    {
        //        g.SetFocusedRowCellValue("INOUT_CODE", "1001");  //일반입고
        //    }

        //    if (g.GetRowCellDisplayText(selectedRowNum, "INOUT_QTY").Equals("")) return;

        //    decimal order_qty = Convert.ToDecimal(g.GetRowCellDisplayText(selectedRowNum, "INOUT_QTY") == "" ? "0" : g.GetRowCellDisplayText(selectedRowNum, "INOUT_QTY"));
        //    decimal unit_cost = Convert.ToDecimal(g.GetRowCellDisplayText(selectedRowNum, "UNITCOST") == "" ? "0" : g.GetRowCellDisplayText(selectedRowNum, "UNITCOST"));
        //    decimal cost = 0;

        //    cost = order_qty * unit_cost;
        //    g.SetFocusedRowCellValue("COST", cost);
        //}

        private void ucSimpleButton1_Click(object sender, EventArgs e)
        {
            if (sPRODUCTION_ORDER_ID == "")
            {
                CoFAS_DevExpressManager.ShowInformationMessage("작업지시를 먼저 선택해주세요");
                return;
            }

            if (!_pLOT_COMPLETE)
            {
                CoFAS_DevExpressManager.ShowInformationMessage("작업중인 LOT이 있습니다");
                return;
            }

            string sUSA_LOT = "N";
            if (_ckUSA_LOT.Checked) sUSA_LOT = "Y";

            bool isError = false;

            pfrmPOPMain_PRESS_LINEEntity.CRUD = "C";
            pfrmPOPMain_PRESS_LINEEntity.USER_CODE = _pUSER_CODE;
            pfrmPOPMain_PRESS_LINEEntity.PRODUCTION_ORDER_ID = sPRODUCTION_ORDER_ID;
            pfrmPOPMain_PRESS_LINEEntity.USA_LOT_YN = sUSA_LOT;
            try
            {
                isError = new frmPOPMain_PRESS_LINEBusiness().pfrmPOPMain_PRESS_LINE_LOT_CRATE(pfrmPOPMain_PRESS_LINEEntity);

                if (!isError)
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                    //CoFAS_DevExpressManager.ShowInformationMessage("LOT 생성 완료");
                    _pLOT_COMPLETE = false;
                    pfrmPOPMain_PRESS_LINEEntity.LOT_ID = pfrmPOPMain_PRESS_LINEEntity.RTN_KEY;

                    Refresh_DisplayData();
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                    CoFAS_DevExpressManager.ShowInformationMessage("LOT 생성 실패");
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

        private void Refresh_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                pfrmPOPMain_PRESS_LINEEntity.CRUD = "R";
                pfrmPOPMain_PRESS_LINEEntity.USER_CODE = _pUSER_CODE;
                pfrmPOPMain_PRESS_LINEEntity.PRODUCTION_ORDER_ID = sPRODUCTION_ORDER_ID;
                

                _dtList = new frmPOPMain_PRESS_LINEBusiness().pfrmPOPMain_PRESS_LINE_REFRESH(pfrmPOPMain_PRESS_LINEEntity);

                if (pfrmPOPMain_PRESS_LINEEntity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && pfrmPOPMain_PRESS_LINEEntity.CRUD == ""))
                {
                    _lbLOT_NO.Text = _dtList.Rows[0]["LOT_NO"].ToString();
                    _lbPRODUCTION_OK_QTY.Text = _dtList.Rows[0]["PRODUCTION_OK_QTY"].ToString();
                    //_lbPRODUCTION_NG_QTY.Text = _dtList.Rows[0]["PRODUCTION_NG_QTY"].ToString();
                    _lbPRODUCTION_PASS_QTY.Text = _dtList.Rows[0]["PRODUCTION_PASS_QTY"].ToString();



                    // 해당 LOT의 불량조회
                    _gdMAIN.DataSource = null;
                    _dtList_ng = new frmPOPMain_PRESS_LINEBusiness().pfrmPOPMain_PRESS_LINE_NG_LIST(pfrmPOPMain_PRESS_LINEEntity);
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList_ng);
                        
                }
                else
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("LOT 조회 내역이 없습니다.");
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

        private void ucSimpleButton2_Click(object sender, EventArgs e)
        {
            bool isError = false;
            DataTable _dt = null;
            DataTable _dtTemp = null;

            try
            {
                if (CoFAS_DevExpressManager.ShowQuestionMessage("데이터를 등록하시겠습니까?") == DialogResult.Yes)
                {
                    pfrmPOPMain_PRESS_LINEEntity.CRUD = "C";
                    pfrmPOPMain_PRESS_LINEEntity.USER_CODE = _pUSER_CODE;
                    pfrmPOPMain_PRESS_LINEEntity.PRODUCTION_ORDER_ID = sPRODUCTION_ORDER_ID;

                    #region 결과테이블 생성
                    DataTable resultdt = new DataTable();
                    resultdt.Columns.Add(new DataColumn("RESOURCE_CODE", typeof(string)));
                    resultdt.Columns.Add(new DataColumn("COLLECTION_DATE", typeof(string)));
                    resultdt.Columns.Add(new DataColumn("PROPERTY_VALUE", typeof(string)));
                    resultdt.Columns.Add(new DataColumn("CONDITION_CODE", typeof(string)));
                    resultdt.Columns.Add(new DataColumn("COLLECTION_VALUE", typeof(string)));

                    DataRow row = null;
                    #endregion





                    _dt = _gdMAIN.DataSource as DataTable;
                    if (CoFAS_ConvertManager.DataTable_FindCount(_dt, "CRUD IN ('C') AND PRODUCTION_NG_RESULT > 0", ""))
                    {
                        _dtTemp = CoFAS_ConvertManager.DataTable_FindValue(_dt, "CRUD IN ('C') AND PRODUCTION_NG_RESULT > 0", "");

                        // 실적데이터 추가
                        row = resultdt.NewRow();
                        row["RESOURCE_CODE"] = pfrmPOPMain_PRESS_LINEEntity.PROCESS_CODE; ;
                        row["COLLECTION_DATE"] = DateTime.Now.ToString("yyyyMMddHHmmss");
                        row["PROPERTY_VALUE"] = pfrmPOPMain_PRESS_LINEEntity.LOT_ID;
                        row["CONDITION_CODE"] = "CD501001";
                        row["COLLECTION_VALUE"] = _lbPRODUCTION_OK_QTY.Text.ToString();
                        resultdt.Rows.Add(row);

                        // 불량데이터 추가
                        for (int i = 0; i < _dtTemp.Rows.Count; i++)
                        {

                            row = resultdt.NewRow();
                            row["RESOURCE_CODE"] = pfrmPOPMain_PRESS_LINEEntity.PROCESS_CODE;
                            row["COLLECTION_DATE"] = DateTime.Now.ToString("yyyyMMddHHmmss");
                            row["PROPERTY_VALUE"] = pfrmPOPMain_PRESS_LINEEntity.LOT_ID;
                            row["CONDITION_CODE"] = _dtTemp.Rows[i]["BAD_CODE"].ToString();
                            row["COLLECTION_VALUE"] = _dtTemp.Rows[i]["PRODUCTION_NG_RESULT"].ToString();
                            resultdt.Rows.Add(row);
                        }

                        isError = new frmPOPMain_PRESS_LINEBusiness().pfrmPOPMain_PRESS_LINE_LOT_RESULT(pfrmPOPMain_PRESS_LINEEntity, resultdt);

                        if (!isError)
                        {
                            _pLOT_COMPLETE = true;
                            Refresh_DisplayData();
                            _gdMAIN.Enabled = false;
                        }
                        else
                        {
                            //CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                            CoFAS_DevExpressManager.ShowInformationMessage("저장 실패");
                        }
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
    }
}

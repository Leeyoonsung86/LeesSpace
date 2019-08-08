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
using DevExpress.XtraGrid;
using CoFAS_MES.CORE.Business;

namespace CoFAS_MES.POP
{
    public partial class frmPOPComplete : frmBaseSingle
    {
        private string _pCORP_CODE = string.Empty;       // 회사코드       
        private string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        private string _pUSER_NAME = string.Empty;       // 사용자이름
        private string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어
        private string _pWINDOW_NAME = string.Empty;     // 화면 명칭
        private string _pFONT_TYPE = "굴림"; //string.Empty;       // 시스템 폰트 타입 설정
        private int _pFONT_SIZE = 9;                     // 시스템 폰트 사이즈 설정 기본 9
        private Font _pFONT_SETTING = null;              // 시스템 폰트 설정
        private string _pFTP_ID = string.Empty;          // FTP ID 정보
        private string _pFTP_IP_PORT = string.Empty;     // FTP SERVER IP 정보
        private string _pFTP_PW = string.Empty;          //FTP PW 정보
        
        private CoFAS_Serial _pCoFAS_Serial = null;  // 시리얼 생성

        private POPProductionOrderCommonEntity _pPOPProductionOrderCommonEntity = null; // 엔티티 생성
        private UserEntity _pUserEntity = null;

        private DataTable _dtList = null; //조회 데이터 리스트
        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용

        public string titleName = "";
        public string _pPrint_cmd = null;

        public string _pVendCode = "";
        public string _pPrintName = "";
        public string _pPrintCode = "";
        public string _pPrintSEQ = "";
        public string _pPrintQTY = "";

        public string ReturnValue1 { get; set; }

        public frmPOPComplete(string print_cmd, UserEntity pUserEntity)
        {
            _pUserEntity = pUserEntity;

            _pPrint_cmd = print_cmd;

            //메뉴 화면 엔티티 설정
            _pPOPProductionOrderCommonEntity = new POPProductionOrderCommonEntity();
            //_pPOPProductionOrderCommonEntity.USER_CODE = _pUSER_CODE;

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
                InitializeControl();
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
                WindowName = titleName;


            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Initialize()", pException);
            }
        }

        #region ○ 컨트롤 초기화 - InitializeControl()

        private void InitializeControl()
        {
            try
            {

                _luT_PrintCode.Font = new Font("굴림", 20);
                _luT_PrintSEQ.Font = new Font("굴림", 20);

                _luT_PrintCode.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("", _pLANGUAGE_TYPE, "POP_PART_COMPLETE", "", "", "").Tables[0], 0, 0, "", false);

                _luT_PrintSEQ.Text = "";


                //조회조건 영역 
                //_luT_WINDOW_NAME.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", "MENU_LIST", "", "", "").Tables[0], 0, 0, "");
                //_luT_USE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return(_pCORP_CDDE, "R", "COMMON_CODE", "CD99", "", "").Tables[0], 0, 0, "");

                //데이터 영역
                //_luWINDOW_NAME.AddValue(new CommonCodeReturnBusiness().CommonCode_Return(_pCORP_CDDE, "R", "MENU_LIST", "", "", "").Tables[0], 0, -1, "");
                //_luWINDOW_NAME.ReadOnly = false;

                //_luGRID_NAME.Text = "";
                //_luGRID_NAME.ReadOnly = false;

                //_luGRIDVIEW_NAME.Text = "";
                //_luGRIDVIEW_NAME.ReadOnly = false;

                //_luEDIT_ABLE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return(_pCORP_CDDE, "R", "COMMON_CODE", "CD99", "", "").Tables[0], 0, 0, "");
                //_luEDITOR_SHOWMODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return(_pCORP_CDDE, "R", "COMMON_CODE", "MM20", "", "").Tables[0], 0, 0, "");


                // 컨트롤러 유효성 검증 처리 기본 컨트롤러 에서만 사용 
                //dxValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
                //dxValidationProvider.Validate();

                //dxValidationProvider.SetValidationRule(_luGRID_NAME, NotEmptyValidationRule);
                //dxValidationProvider.SetValidationRule(_luGRIDVIEW_NAME, NotEmptyValidationRule);
                // 컨트롤러 유효성 검증 처리

                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                if (_pFirstYN)
                {
                    // _gdMAIN.DataSource = null;
                }

                //_gdSUB.DataSource = null;
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
            if (_luT_PrintSEQ.Text == "")
            {
                CoFAS_DevExpressManager.ShowInformationMessage("츨력갯수를 확인해주세요.");
                return;
            }

            if (_luT_PrintQTY.Text == "")
            {
                CoFAS_DevExpressManager.ShowInformationMessage("등록갯수를 확인해주세요.");
                return;
            }
            
            _pPrintName = _luT_PrintCode.Text;
            _pPrintCode = _luT_PrintCode.GetValue();
            _pPrintSEQ = _luT_PrintSEQ.Text;
            _pPrintQTY = _luT_PrintQTY.Text;

            _dtList = new frmPOPMain_PRODUCT_MIXBusiness().frmPOPMain_PRODUCT_MIX_vendCode_Info(_pPrintCode);

            _pVendCode = _dtList.Rows[0]["VEND_PART_CODE"].ToString();

            Close();
        }
        #endregion
        
        #region ○ 공정정보 받고 실행
        private void ReceivePrint(byte[] PrintCode)  // 프로세스코드로 구분
        {
            //제브라 프린터 출력 로직
        }
        #endregion
    }
}

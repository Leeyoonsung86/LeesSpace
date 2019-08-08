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

using CoFAS_MES.POP.Business;
using CoFAS_MES.POP.Data;
using CoFAS_MES.POP.Entity;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using CoFAS_MES.CORE.Business;

namespace CoFAS_MES.POP
{
    public partial class frmPOPBad_T01 : frmBaseSingle
    {
        private string _pCORP_CODE = string.Empty;       // 회사코드       
        private string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        private string _pUSER_NAME = string.Empty;       // 사용자이름
        private string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어
        private string _pWINDOW_NAME = string.Empty;     // 화면 명칭
        private string _pFONT_TYPE = "Meiryo UI"; //string.Empty;       // 시스템 폰트 타입 설정
        private int _pFONT_SIZE = 21;                     // 시스템 폰트 사이즈 설정 기본 9
        private Font _pFONT_SETTING = null;              // 시스템 폰트 설정
        private string _pFTP_ID = string.Empty;          // FTP ID 정보
        private string _pFTP_IP_PORT = string.Empty;     // FTP SERVER IP 정보
        private string _pFTP_PW = string.Empty;          //FTP PW 정보


        private POPProductionOrderEntity _pPOPProductionOrderEntity = null; // 엔티티 생성
        private DataTable _dtList = null; //조회 데이터 리스트
        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용

        public string titleName = "";
        public string ReturnValue1 { get; set; }    //수량
        public string ReturnValue2 { get; set; }    //불량코드

        public frmPOPBad_T01()
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
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Size = new Size(1280, 960);
                this.StartPosition = FormStartPosition.Manual;
                this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
                this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;

                _btPageSetting.Visible = false;
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {
                DevExpress.Utils.AppearanceObject.DefaultFont = _pFONT_SETTING;//화면에 모든 항목 폰트 재설정
                //dxWaitViewManager.CloseWaitForm();
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
                   //"0we11Passw0rd!@#dbmes"
                   "0we11Passw0rd!@#dbmes"
               );
                WindowName = titleName;
                _pFONT_SETTING = new Font(_pFONT_TYPE, _pFONT_SIZE);

                ucTextKeypad.Font = new Font("Meiryo UI", 25, FontStyle.Bold);
                ucTextKeypad.TextAlignment = DevExpress.Utils.HorzAlignment.Far;

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
                _luT_BadCode.Font = new Font("Meiryo UI", 20);
                _luT_BadSubCode.Font = new Font("Meiryo UI", 20);

                _luT_BadCode.ValueChanged += new EventHandler(_luT_BadCode_ValueChanged);
                _luT_BadCode.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("", _pLANGUAGE_TYPE, "POP_BAD1_CODE", "", "", "").Tables[0], 0, 0, "", false);
                



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

        private void _luT_BadCode_ValueChanged(object sender, EventArgs e)
        {
            _luT_BadSubCode.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("", _pLANGUAGE_TYPE, "POP_BAD2_CODE", _luT_BadCode.GetValue(), "", "").Tables[0], 0, 0, "", false);
            
            //throw new NotImplementedException();
        }

        #endregion


        #region ○ 버튼 클릭시

        private void btnCmd_Click(object pSender, EventArgs pEventArgs)
        {
            SimpleButton pCmd = pSender as SimpleButton;

            string sCls = pCmd.Name.Substring(6, 2);
            switch (sCls)
            {
                case "00":
                    ucTextKeypad.Text += "0";

                    if (ucTextKeypad.Text.Length < 4)
                    {
                        if (ucTextKeypad.Text == "-00" || ucTextKeypad.Text == "00")
                        {
                            ucTextKeypad.Text = ucTextKeypad.Text.Substring(0, ucTextKeypad.Text.Length - 1);
                        }
                    }

                    break;

                case "01":
                    ucTextKeypad.Text += "1";
                    break;

                case "02":
                    ucTextKeypad.Text += "2";
                    break;

                case "03":
                    ucTextKeypad.Text += "3";
                    break;

                case "04":
                    ucTextKeypad.Text += "4";
                    break;

                case "05":
                    ucTextKeypad.Text += "5";
                    break;

                case "06":
                    ucTextKeypad.Text += "6";
                    break;

                case "07":
                    ucTextKeypad.Text += "7";
                    break;

                case "08":
                    ucTextKeypad.Text += "8";
                    break;

                case "09":
                    ucTextKeypad.Text += "9";
                    break;

                case "10":
                    ucTextKeypad.Text += "0";
                    break;

                case "20":
                    // 저장
                    //검사등록
                    if (CoFAS_DevExpressManager.ShowQuestionMessage("不良実績を登録希望しますか？") == DialogResult.Yes)
                    {

                        decimal temp = 0;

                        if (decimal.TryParse(ucTextKeypad.Text, out temp))
                        {
                            ucTextKeypad.Text = decimal.Parse(ucTextKeypad.Text).ToString();


                            this.DialogResult = DialogResult.OK;
                            ReturnValue1 = ucTextKeypad.Text;
                            ReturnValue2 = _luT_BadSubCode.GetValue();
                            this.Close();
                        }
                        else
                        {
                            if (ucTextKeypad.Text == "0" || ucTextKeypad.Text.Trim() == "")
                            {
                                return;
                            }
                        }
                    }
                    break;

                case "30":
                    // BS
                    if (ucTextKeypad.Text.Length > 0)
                    {
                        ucTextKeypad.Text = ucTextKeypad.Text.Substring(0, ucTextKeypad.Text.Length - 1);

                    }
                    break;

                case "40":
                    //취소
                    this.DialogResult = DialogResult.No;
                    this.Close();
                    break;

                case "50":
                    //. 소수점
                    if (ucTextKeypad.Text.Length > 0 && ucTextKeypad.Text.IndexOf('.') == -1)
                    {
                        ucTextKeypad.Text += ".";
                    }
                    break;

                case "60":
                    //- 마이너스
                    if (ucTextKeypad.Text.IndexOf('-') < 0)
                    {
                        ucTextKeypad.Text = ucTextKeypad.Text.Insert(0, "-");
                    }
                    break;

                case "70":
                    //+ 플러스
                    if (ucTextKeypad.Text.IndexOf('-') > -1)
                    {
                        ucTextKeypad.Text = ucTextKeypad.Text.Replace("-", string.Empty);
                    }
                    break;


                default: break;
            }
            ucTextKeypad.Focus();

        }

        #endregion
    }
}


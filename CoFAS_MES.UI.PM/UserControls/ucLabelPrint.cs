using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.Function;
using CoFAS_MES.CORE.Entity;
using DevExpress.XtraGrid.Views.Grid;
using System.IO.Ports;

namespace CoFAS_MES.UI.PM.UserControls
{
    public partial class ucLabelPrint : UserControl
    {
        private static string _pCORP_CODE = string.Empty;       // 회사코드       
        private static string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        private static string _pWINDOW_NAME = string.Empty;     // 화면명칭
        private static string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어


        private CoFAS_Serial _pCoFAS_Serial = null;  // 시리얼 생성
        private string[] serial_port = SerialPort.GetPortNames();
       // private BarcodeLabelPrintEntity _pBarcodeLabelPrintEntity = null; // 엔티티 생성

        private string serial_check = string.Empty;
        private static Font fntPARENT_FONT = null;       // 시스템 폰트 설정

        //private static DataTable _pDATATABLE_VALUE = null;

        private static object[] _pARRAY = null;
        private static object[] _pARRAY_CODE = null;
        private string _pCRUD = ""; //CRUD
        private string _PRINT_CMD = ""; //
        private string _COM_PORT = ""; //
        private string _INOUT_ID = ""; //
        private int  _INOUT_QTY = 0; //


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
        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용
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

        public ucLabelPrint()
        {

            InitializeComponent();

            _pWINDOW_NAME = this.Name.ToString();
        }
        private void ucPartCodeInfoPopup_Load(object sender, EventArgs e)
        {
            try
            {

                if (_pARRAY != null && _pARRAY.Length > 1)
                {
                    {
                        _PRINT_CMD = _pARRAY[0].ToString();
                        _INOUT_ID = _pARRAY[1].ToString();
                        _COM_PORT = _pARRAY[2].ToString();
                        _INOUT_QTY = Convert.ToInt32(_pARRAY[3].ToString());
                    }
                }
                if (_pARRAY_CODE != null && _pARRAY_CODE.Length > 1)
                {
                    // _luCD.Text = _pARRAY_CODE[0].ToString();
                    // _luCD_NM.Text = _pARRAY_CODE[1].ToString();
                }

                InitializeSetting();
                

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


        private void InitializeSetting()
        {
            //상속 화면 패널 사용 유무



            //화면 설정 언어 & 명칭 변경. ==고정==
            DataTable dtLanguage = new LanguageBusiness().Language_Info(_pWINDOW_NAME, _pLANGUAGE_TYPE);

            if (dtLanguage != null && dtLanguage.Rows.Count > 0)
            {
                CoFAS_ControlManager.Language_Info(dtLanguage, this);
            }
            
            radioGroup1.SelectedIndexChanged += RadioGroup1_SelectedIndexChanged;
            //그리드 설정 ==고정==

            if (_pFirstYN)
            {
                // 사용 가능한 COM 조회
                for (int i = 0; i < serial_port.Length; i++)
                {
                    _luCOM_TYPE.ItemAdd(serial_port[i]);
                }
                //GetBarcodeComPort();
                _luCOM_TYPE.SelectedItem = _COM_PORT;
                // _luCOM_TYPE.SelectedIndex = 0;
                _COM_STATUS.Text = "";
                _luPRINT_SEQ.Text = "";
                _luPRINT_SEQ.Properties.MaxLength = 4;
                SetHardware();
                _pFirstYN = false;
            }
            //그리드 설정 ==고정==
        }

        private void RadioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(radioGroup1.Properties.Items[radioGroup1.SelectedIndex].Value.ToString()=="1")
            {

                _luPRINT_SEQ.ReadOnly = false;
            }
            else
            {
                _luPRINT_SEQ.ReadOnly = true;
            }
        }


        #region ○ H/W 세팅시
        private void SetHardware()
        {
            try
            {

                if (serial_check == "")
                {
                    //_pCoFAS_Serial = new CoFAS_Serial(_dtList_terminal.Rows[0]["INFO_PORTNAME"].ToString(), Convert.ToInt32(_dtList_terminal.Rows[0]["INFO_BAUDRATE"].ToString()), _dtList_terminal.Rows[0]["INFO_PARITY"].ToString(), Convert.ToInt32(_dtList_terminal.Rows[0]["INFO_DATABITS"].ToString()), _dtList_terminal.Rows[0]["INFO_STOPBITS"].ToString());
                    _pCoFAS_Serial = new CoFAS_Serial(_luCOM_TYPE.SelectedItem.ToString(), 9600, "NONE", 8, "ONE");
                    _pCoFAS_Serial.Open();

                    // 연결할 H/W 연결상태 표시. (연동시 변경)
                    //lc_0.Appearance.Image = global::CoFAS_MES.UI.QC.Properties.Resources.plug_Green;
                    _ucbtCONNECTION.Image = global::CoFAS_MES.UI.PM.Properties.Resources.plug_Green;

                    //serial_check = _dtList_terminal.Rows[0]["INFO_PORTNAME"].ToString();
                    serial_check = _luCOM_TYPE.SelectedItem.ToString();

                    // CoFAS_DevExpressManager.ShowInformationMessage("연결 되었습니다.");
                    _COM_STATUS.Text = "연결 되었습니다.";
                    _COM_STATUS.ForeColor = Color.Green;
                }
                else //값이 있으면
                {
                    //컴포트값이 다르면
                    //if (serial_check != _dtList_terminal.Rows[0]["INFO_PORTNAME"].ToString())
                    if (serial_check != _luCOM_TYPE.SelectedItem.ToString())
                    {
                        //연결 끊고 새로운거로 연결

                        _pCoFAS_Serial.Dispose();
                        _pCoFAS_Serial.Close();

                        //_pCoFAS_Serial = new CoFAS_Serial(_dtList_terminal.Rows[0]["INFO_PORTNAME"].ToString(), Convert.ToInt32(_dtList_terminal.Rows[0]["INFO_BAUDRATE"].ToString()), _dtList_terminal.Rows[0]["INFO_PARITY"].ToString(), Convert.ToInt32(_dtList_terminal.Rows[0]["INFO_DATABITS"].ToString()), _dtList_terminal.Rows[0]["INFO_STOPBITS"].ToString());
                        _pCoFAS_Serial = new CoFAS_Serial(_luCOM_TYPE.SelectedItem.ToString(), 9600, "NONE", 8, "ONE");

                        _pCoFAS_Serial.Dispose();

                        //_pCoFAS_Serial = new CoFAS_Serial("com3", 9600, "NONE", 8, "ONE");
                        _pCoFAS_Serial.Open();

                        // 연결할 H/W 연결상태 표시. (연동시 변경)
                        //lc_0.Appearance.Image = global::CoFAS_MES.UI.QC.Properties.Resources.plug_Green;
                        _ucbtCONNECTION.Image = global::CoFAS_MES.UI.PM.Properties.Resources.plug_Green;

                        serial_check = _luCOM_TYPE.SelectedItem.ToString();

                        //CoFAS_DevExpressManager.ShowInformationMessage("연결 되었습니다.");
                        _COM_STATUS.Text = "연결 되었습니다.";
                        _COM_STATUS.ForeColor = Color.Green;
                    }
                    else
                    {
                        //연결되어있는 상태니 재연결 할 필요 없음
                        //CoFAS_DevExpressManager.ShowInformationMessage("이미 연결된 포트입니다.");
                        _COM_STATUS.Text = "이미 연결된 포트입니다.";
                        _COM_STATUS.ForeColor = Color.Blue;
                    }
                }

            }
            catch (Exception ex)
            {
                CoFAS_DevExpressManager.ShowInformationMessage("포트 연결을 실패했습니다.");
                _pCoFAS_Serial = new CoFAS_Serial();
                _COM_STATUS.Text = "포트 연결 실패.";
                _COM_STATUS.ForeColor = Color.Red;
                _ucbtCONNECTION.Image = global::CoFAS_MES.UI.PM.Properties.Resources.plug_Gray;
            }
        }

        #endregion


        public static event OnDoubleClickEventHandler _OnDoubleClick; //그리드 로우 마우스 선택으로 값 넘길경우 필수
        public delegate void OnDoubleClickEventHandler(object sender, EventArgs e); //그리드 로우 마우스 선택으로 값 넘길경우 필수

        private void _gdMAIN_VIEW_DoubleClick(object sender, EventArgs e)
        {
            if (_OnDoubleClick != null)
                _OnDoubleClick(sender, e);
        }

        private void _ucbtSELECT_Click(object sender, EventArgs e)
        {
            _pCRUD = "R";
        }

        private void _ucbtCLEAR_Click(object sender, EventArgs e)
        {
           // _luCD.Text = "";
           // _luCD_NM.Text = "";
           //
           // _gdMAIN.DataSource = null;
        }


        //닫기버튼
        public static event OnClickEventHandler _Close_Click;
        public delegate void OnClickEventHandler(object sender, EventArgs e);
        private void _ucbtCancle_Click(object sender, EventArgs e)

        {
            if (_pCoFAS_Serial.IsOpen)
            {
                //_pCoFAS_Serial.Dispose();
                _pCoFAS_Serial.Close();
            }

            if (_Close_Click != null)
                _Close_Click(sender, e);
        }

        private void ucTextEdit2_Load(object sender, EventArgs e)
        {

        }

        private void _ucbtRPINT_Click(object sender, EventArgs e)
        {
            
            CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
            
            if (_PRINT_CMD != "")
            {
                // 시리얼 연결 여부 확인
                if (_pCoFAS_Serial.IsOpen)
                {
                    try
                    {

                        //라벨 공정에서 가져오기

                        if(radioGroup1.SelectedIndex==-1)
                        {
                            CoFAS_DevExpressManager.ShowInformationMessage("발행유형을 선택하세요.");
                            return;
                        }
                        //수동으로
                        if(radioGroup1.Properties.Items[radioGroup1.SelectedIndex].Value.ToString() == "1")
                        {
                            //라벨 공정에서 가져오기

                            if (_luPRINT_SEQ.Text=="")
                            {
                                CoFAS_DevExpressManager.ShowInformationMessage("순번을 입력하세요.\n(범위 : 0~9999");
                                return;


                            }
                            string _Barcode = string.Empty;

                            //byte[] bytes = Encoding.Default.GetBytes(_Barcode);
                            //_Barcode = Encoding.Default.GetString(bytes);

                            string cmd = null;
                            int check = 0;

                            _Barcode = _PRINT_CMD;// _gdMAIN_VIEW.GetFocusedRowCellValue("BARCODE").ToString();// _dtList_print.Rows[0]["PRINT_CMD"].ToString();
                            string temp = string.Empty;
                            string yyyy = string.Empty;
                            string mm = string.Empty;
                            string dd = string.Empty;
                            string yyyymmdd = string.Empty;

                            //2019.01.15
                            _Barcode = _Barcode.Replace("@BARCODE", _INOUT_ID+"-"+ _luPRINT_SEQ.Text.PadLeft(4, '0')); // 제조번호

                            //몇장뽑을건지
                           // _Barcode = _Barcode + ",^PQ" + 1;
                            _Barcode = _Barcode + "^XZ";


                            // _Barcode = _Barcode.Replace("@PNAME", tDataTable.Rows[i]["PART_NAME"].ToString().Length < 8 ? "  " + tDataTable.Rows[i]["PART_NAME"].ToString() : tDataTable.Rows[i]["PART_NAME"].ToString()); // 제품명

                            byte[] bytes = Encoding.Default.GetBytes(_Barcode);
                            _pCoFAS_Serial.Write(bytes, 0, bytes.Length);
                            //   }
                        }
                        else
                        //자동으로 seq 수량만큼
                        {
                            for(int cnt=0;cnt<_INOUT_QTY;cnt++)
                            {
                                string _Barcode = string.Empty;
                                string tmp_seq = (cnt + 1).ToString();


                                string cmd = null;
                                int check = 0;

                                _Barcode = _PRINT_CMD;// 
                                //2019.01.15
                                _Barcode = _Barcode.Replace("@BARCODE", _INOUT_ID + "-" + tmp_seq.PadLeft(4,'0')); // 제조번호

                                //몇장뽑을건지
                                // _Barcode = _Barcode + ",^PQ" + 1;
                                _Barcode = _Barcode + "^XZ";


                                // _Barcode = _Barcode.Replace("@PNAME", tDataTable.Rows[i]["PART_NAME"].ToString().Length < 8 ? "  " + tDataTable.Rows[i]["PART_NAME"].ToString() : tDataTable.Rows[i]["PART_NAME"].ToString()); // 제품명

                                byte[] bytes = Encoding.Default.GetBytes(_Barcode);
                                _pCoFAS_Serial.Write(bytes, 0, bytes.Length);
                            }
                        }
                       
                        
                    }

                    catch (Exception ex)
                    {
                        CoFAS_DevExpressManager.ShowInformationMessage("라벨발행 오류");
                        _COM_STATUS.Text = "라벨발행 오류.";
                        _COM_STATUS.ForeColor = Color.Red;

                        _pCoFAS_Serial.Dispose();
                        _pCoFAS_Serial.Close();
                    }
                    finally
                    {
                        CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
                    }

                }
                else  //연결 끊긴 여부
                {
                    _COM_STATUS.Text = "프린터를 연결하세요.";
                    _COM_STATUS.ForeColor = Color.Red;
                    CoFAS_DevExpressManager.ShowInformationMessage("프린터를 연결하세요");
                }
            }
            else
            {
                CoFAS_DevExpressManager.ShowInformationMessage("발행할 항목을 선택하세요");
            }

        }


        #region ○ 메인조회 - MainFind_DisplayData()
        /*
        private void GetBarcodeComPort()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _dtList = new BarcodeLabelPrintBusiness().BarcodeLabelPrint_COM_Info(_pBarcodeLabelPrintEntity);
                COM_PORT = "";
                if (_dtList != null && _dtList.Rows.Count > 0)//&& _dtList.Rows.Count > 0) )|| (_dtList != null && _pBarcodeLabelPrintEntity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩

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
        */
        #endregion

        private void _ucbtCONNECTION_Click(object sender, EventArgs e)
        {
            SetHardware();
        }
    }


}

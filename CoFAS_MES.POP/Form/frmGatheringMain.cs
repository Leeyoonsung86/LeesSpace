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
using CoFAS_MES.POP.UserControls;
using DevExpress.XtraEditors;


using CoFAS_MES.POP.Business;
using CoFAS_MES.POP.Data;
using CoFAS_MES.POP.Entity;
using DevExpress.XtraGrid;
using CoFAS_MES.CORE.Business;
using DevExpress.XtraGrid.Views.Grid;

namespace CoFAS_MES.POP
{
    public partial class frmGatheringMain : frmBasePOP
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

        public ucGatheringCtl[] ucG = null;
        private GatheringMainEntity _pGatheringMainEntity = null; // 엔티티 생성
        private DataTable _dtList = null; //조회 데이터 리스트
        private DataTable _dtSubList = null; //조회 데이터 리스트
        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용
        private string _pResource_Add = string.Empty;

        //MSSQL , MYSQL 변환인자
        private string ChangeSQL = string.Empty; // SQL 설정
        private string ChangeSVR = string.Empty; // 서버IP
        private string ChangeDB = string.Empty; // DB 명
        private string ChangeID = string.Empty; // ID
        private string ChangePW = string.Empty; // 패스워드

        private bool XmlSetting = false; //Xml 세팅
        private CoFAS_Log _pCoFASLog = new CoFAS_Log(Application.StartupPath + "\\LOG", "", 30, true);


        private CoFAS_XML _pCoFASXml = new CoFAS_XML(CoFAS_XML.enXmlType.File, @"./config.xml");
        public static readonly string strDSFileName = @".\config.xml";
        private string _pMessage = string.Empty;
        private int iucEngCnt = 0;

        public static DataSet dsSetting;

        private DataTable _DtMinMax = null;

        public frmGatheringMain()
        {
         //   ChangeSQL = "SQLServer";  //변경할때 이것만 변경하면 해당 SQL로 변경 해야함

            if (ChangeSQL == "SQLServer") //MSSQL
            {
                ChangeSVR = "eng.coever.co.kr";
                ChangeDB = "FEMS_TIE";
                ChangeID = "sa";
                ChangePW = "Codb89897788@$^";
                 
                Initialize_MSSQL();
            }
            else  //MYSQL
            {
                Initialize();
            }

            InitializeComponent();

            Activated += new EventHandler(Form_Activated);
            FormClosing += new FormClosingEventHandler(Form_Closing);
            FormClosed += new FormClosedEventHandler(Form_FormClosed);
            Load += new EventHandler(frmGatheringMain_Load);
           

        }

        #region ○ Form_Activated_MSSQL
        private void Initialize_MSSQL()
        {
            try
            {
                switch (ChangeSQL)
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
                   ChangeSVR,
                   ChangeDB,
                   ChangeID,
                   ChangePW
               );

            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Initialize_MSSQL()", pException);
            }
        }
        #endregion

        #region ○ Form_Activated
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
                        {
                            if(_pCoFASXml.GetSingleNodeValue("P_SET/USE") =="Y")
                            {
                                
                                XmlSetting = true;
                                
                            }
                            else
                            {
                                DBManager.PrimaryDBManagerType = DBManagerType.MySql;//.SQLServer;
                            }
                        }
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
        #endregion


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
        private void frmGatheringMain_Load(object sender, EventArgs e)
        {
            _DtMinMax = new GatheringMainBusiness().Alarm_MinMax_Mst(_pGatheringMainEntity);  // 경광등 알람 데이터 

            InitializeSetting();
         
            ucEng_Create();
        }
        #endregion

        // 초기화 처리 영역
        #region ○ 메뉴 초기화 하기 - InitializeSetting()

        private void InitializeSetting()
        {
            if (Properties.Settings.Default.DB_NAME == "coever_mes_biocerra")
            {
                DisplayMessage("데이터 표시");  // 일본어 버전
            }
            else
            {
                DisplayMessage("データの表示");  // 일본어 버전
            }
            try
            {
                if (Properties.Settings.Default.DB_NAME == "coever_mes_biocerra")
                {
                    if (!XmlSetting)  //데이터 설정이 DB연결로 되어있으면
                    {
                        //메인 화면 전역 변수 처리
                        _pFONT_SETTING = new Font(_pFONT_TYPE, _pFONT_SIZE);
                        _pWINDOW_NAME = this.Name;
                        _lbTitle.Text = "Data Gathering System";
                        //메뉴 화면 엔티티 설정
                        _pGatheringMainEntity = new GatheringMainEntity();
                        _pGatheringMainEntity.CORP_CODE = _pCORP_CODE;
                        _pGatheringMainEntity.USER_CODE = _pUSER_CODE;
                        _pGatheringMainEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                        if (_ptimeSt == "") // 언어 추가해야함.
                        {
                            _ptimeSt = "시작 시간";
                            _ptimeEt = "현재 시간";
                        }

                        //화면 설정 언어 & 명칭 변경.
                        DataTable dtLanguage = new LanguageBusiness().Language_Info(_pWINDOW_NAME, _pLANGUAGE_TYPE);
                        if (dtLanguage != null && dtLanguage.Rows.Count > 0 && Properties.Settings.Default.DB_ID.ToString() == "MySql")
                        {
                            CoFAS_ControlManager.Language_Info(dtLanguage, this);
                        }
                        //그리드 설정
                        InitializeGrid();
                        //화면 컨트롤러 설정
                        InitializeControl();
                        //그리드 초기화 
                        MainFind_DisplayData(); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.
                    }
                    else //데이터 설정이 Local 이면
                    {
                        _lbTitle.Text = _pCoFASXml.GetSingleNodeValue("IPC/TITLE");
                        //설정 데이터 초기화
                        Setting_Init();

                        //  LocalFind_DisplayData();


                    }
                }
                else if (Properties.Settings.Default.DB_NAME == "coever_mes_hwt")
                {
                    if (!XmlSetting)  //데이터 설정이 DB연결로 되어있으면
                    {
                        //메인 화면 전역 변수 처리
                        _pFONT_SETTING = new Font(_pFONT_TYPE, _pFONT_SIZE);
                        _pWINDOW_NAME = this.Name;
                        _lbTitle.Text = "Data Gathering System";
                        //메뉴 화면 엔티티 설정
                        _pGatheringMainEntity = new GatheringMainEntity();
                        _pGatheringMainEntity.CORP_CODE = _pCORP_CODE;
                        _pGatheringMainEntity.USER_CODE = _pUSER_CODE;
                        _pGatheringMainEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                        if (_ptimeSt == "") // 언어 추가해야함.
                        {
                            _ptimeSt = "시작 시간";
                            _ptimeEt = "현재 시간";
                        }

                        //화면 설정 언어 & 명칭 변경.
                        DataTable dtLanguage = new LanguageBusiness().Language_Info(_pWINDOW_NAME, _pLANGUAGE_TYPE);
                        if (dtLanguage != null && dtLanguage.Rows.Count > 0 && Properties.Settings.Default.DB_ID.ToString() == "MySql")
                        {
                            CoFAS_ControlManager.Language_Info(dtLanguage, this);
                        }
                        //그리드 설정
                        InitializeGrid();
                        //화면 컨트롤러 설정
                        InitializeControl();
                        //그리드 초기화 
                        MainFind_DisplayData(); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.
                    }
                    else //데이터 설정이 Local 이면
                    {
                        _lbTitle.Text = _pCoFASXml.GetSingleNodeValue("IPC/TITLE");
                        //설정 데이터 초기화
                        Setting_Init();

                        //  LocalFind_DisplayData();


                    }
                }
                else
                {
                    if (!XmlSetting)  //데이터 설정이 DB연결로 되어있으면
                    {
                        //메인 화면 전역 변수 처리
                        _pFONT_SETTING = new Font(_pFONT_TYPE, _pFONT_SIZE);
                        _pWINDOW_NAME = this.Name;
                        _lbTitle.Text = "Data Gathering System";
                        //메뉴 화면 엔티티 설정
                        _pGatheringMainEntity = new GatheringMainEntity();
                        _pGatheringMainEntity.CORP_CODE = _pCORP_CODE;
                        _pGatheringMainEntity.USER_CODE = _pUSER_CODE;
                        _pGatheringMainEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                        if (_ptimeSt == "") // 언어 추가해야함.
                        {
                            _ptimeSt = "開始時間";
                            _ptimeEt = "現在時刻";
                        }

                        //화면 설정 언어 & 명칭 변경.
                        DataTable dtLanguage = new LanguageBusiness().Language_Info(_pWINDOW_NAME, _pLANGUAGE_TYPE);
                        if (dtLanguage != null && dtLanguage.Rows.Count > 0 && Properties.Settings.Default.DB_ID.ToString() == "MySql")
                        {
                            CoFAS_ControlManager.Language_Info(dtLanguage, this);
                        }
                        //그리드 설정
                        InitializeGrid();
                        //화면 컨트롤러 설정
                        InitializeControl();
                        //그리드 초기화 
                        MainFind_DisplayData(); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.
                    }
                    else //데이터 설정이 Local 이면
                    {
                        _lbTitle.Text = _pCoFASXml.GetSingleNodeValue("IPC/TITLE");
                        //설정 데이터 초기화
                        Setting_Init();

                        //  LocalFind_DisplayData();


                    }
                }
              
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        private void CoFAS_DevExpressManager__OnOpenButton(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Caption.ToString())
            {
                case "TESTBUTN": //해당 그리드에 필드명 // 2개 이상 그리드의 버튼 항목들은 버튼 타입에 필드 명칭이 모두 다르게 설정 되어야됨.

                    switch (e.Button.Index)
                    {
                        case 0:
                            MessageBox.Show("TESTBUTN 오픈");


                            break;
                        case 1:
                            MessageBox.Show("TESTBUTN 다운로드");


                            break;
                        case 2:
                            MessageBox.Show("TESTBUTN 삭제");


                            break;
                    }
                    break;

            }
        }


        #endregion

        #region ○ 버튼 초기화 하기 - InitializeButtons()

        private void InitializeButtons()
        {
            try
            {
                //MainFormButtonSetting pButtonSetting = new MainFormButtonSetting();

                //pButtonSetting.UseYNSearchButton = _pMenuSettingEntity.MENU_SEARCH == "Y" ? true : false; // 조회
                //pButtonSetting.UseYNExportButton = _pMenuSettingEntity.MENU_EXPORT == "Y" ? true : false; // 내보내기
                //pButtonSetting.UseYNImportButton = _pMenuSettingEntity.MENU_IMPORT == "Y" ? true : false; // 가져오기
                //pButtonSetting.UseYNPrintButton = _pMenuSettingEntity.MENU_PRINT == "Y" ? true : false; // 프린터
                //pButtonSetting.UseYNSaveButton = _pMenuSettingEntity.MENU_SAVE == "Y" ? true : false; // 저장
                //pButtonSetting.UseYNAddItemButton = _pMenuSettingEntity.MENU_ADDITEM == "Y" ? true : false; // 신규
                //pButtonSetting.UseYNDeleteButton = _pMenuSettingEntity.MENU_DELETE == "Y" ? true : false; // 삭제

                //pButtonSetting.UseYNInitialButton = true; // 초기화
                //pButtonSetting.UseYNSettingButton = true; // 설정
                //pButtonSetting.UseYNFormCloseButton = true; // 폼닫기

                //MainForm.SetButtonSetting(pButtonSetting);

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
                ////그리드 초기화 
                ////여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                //if (_pFirstYN)
                //{
                //    _gdMAIN_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdMAIN, _gdMAIN_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pWINDOW_NAME, _gdMAIN.Name.ToString()));
                //}

                //_gdSUB_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB, _gdSUB_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pWINDOW_NAME, _gdSUB.Name.ToString()));
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

        #region ○ 메인조회 - MainFind_DisplayData()

        private void MainFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _dtList = new GatheringMainBusiness().Gathering_Search_Mst(_pGatheringMainEntity);  // 게더링 프로그램 Header 세팅


                //for(int a = 0; a < _dtList.Rows.Count; a++)
                //{
                //    if( int.Parse(_dtList.Rows[a]["GROUPCNT"].ToString()) >1)
                //    {
                    
                //    }
                //}



                // 받은 데이터 변환 시켜야함. 추가..
                
                if (_dtList != null && _dtList.Rows.Count > 0)    //값이 있으면, 설정
                {
                    try
                    {
                        ucG = new ucGatheringCtl[_dtList.Rows.Count];

                        int icnt = 0;

                        int iQty = 3; //열 표시 수량

                        double dRow = _dtList.Rows.Count; // 카드 수량

                        dRow = Math.Ceiling(dRow / iQty);
                         
                        int iWidth = 333;
                        int iHeight = 222;

                        for (int i = 0; i < _dtList.Rows.Count; i++)
                        {
                            _dtSubList = new GatheringMainBusiness().Gathering_Search_Sub(_dtList.Rows[i]);  // 게더링 프로그램 Row 세팅


                            ucG[i] = new ucGatheringCtl(_dtList.Rows[i] , _dtSubList,_DtMinMax);
                        }

                        for (int a = 0; a < dRow; a++)
                        {
                            for (int b = 0; b < iQty; b++)
                            {
                                if (icnt == _dtList.Rows.Count)
                                {
                                    break;
                                }
                                CoFAS_ControlManager.InvokeIfNeeded(ucG[icnt], () => ucG[icnt].Width = iWidth);
                                CoFAS_ControlManager.InvokeIfNeeded(ucG[icnt], () => ucG[icnt].Height = iHeight);
                                CoFAS_ControlManager.InvokeIfNeeded(ucG[icnt], () => ucG[icnt].Top = (a * (iHeight + 10)) + 10);
                                CoFAS_ControlManager.InvokeIfNeeded(ucG[icnt], () => ucG[icnt].Left = b * (iWidth + 10));
                                CoFAS_ControlManager.InvokeIfNeeded(_pnGMain, () => _pnGMain.Controls.Add(ucG[icnt]));
                                icnt++;
                            }
                        }
                        

                    }
                    catch (Exception ex)
                    {

                    }

                }
                else
                {
                    DisplayMessage("조회 내역이 없습니다.");
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


        #region ○ 로컬조회 - LocalFind_DisplayData()

        private void LocalFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);


                if (_pCoFASXml.GetSingleNodeValue("SERVERSOCKET/IP").Length >0 )    //값이 있으면, 설정
                {
                    try
                    {
                        ucG = new ucGatheringCtl[1];

                        int icnt = 0;

                        int iQty = 3; //열 표시 수량

                        double dRow = 1; // 카드 수량

                        dRow = Math.Ceiling(dRow / iQty);

                        int iWidth = 333;
                        int iHeight = 222;

                        for (int i = 0; i < _dtList.Rows.Count; i++)
                        {
                            _dtSubList = new GatheringMainBusiness().Gathering_Search_Sub(_dtList.Rows[i]);  // 게더링 프로그램 Row 세팅


                            ucG[i] = new ucGatheringCtl(_dtList.Rows[i], _dtSubList,_DtMinMax);
                        }

                        for (int a = 0; a < dRow; a++)
                        {
                            for (int b = 0; b < iQty; b++)
                            {
                                if (icnt == _dtList.Rows.Count)
                                {
                                    break;
                                }
                                CoFAS_ControlManager.InvokeIfNeeded(ucG[icnt], () => ucG[icnt].Width = iWidth);
                                CoFAS_ControlManager.InvokeIfNeeded(ucG[icnt], () => ucG[icnt].Height = iHeight);
                                CoFAS_ControlManager.InvokeIfNeeded(ucG[icnt], () => ucG[icnt].Top = (a * (iHeight + 10)) + 10);
                                CoFAS_ControlManager.InvokeIfNeeded(ucG[icnt], () => ucG[icnt].Left = b * (iWidth + 10));
                                CoFAS_ControlManager.InvokeIfNeeded(_pnGMain, () => _pnGMain.Controls.Add(ucG[icnt]));
                                icnt++;
                            }
                        }


                    }
                    catch (Exception ex)
                    {

                    }

                }
                else
                {
                    DisplayMessage("조회 내역이 없습니다.");
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


        private void Setting_Init()
        {
            dsSetting = new DataSet();

            if (CoFAS_FileManager.FileExists(strDSFileName))
            {
                dsSetting.ReadXml(strDSFileName);

                iucEngCnt = dsSetting.Tables["P_SET"].Rows.Count;

                foreach (DataTable dt in dsSetting.Tables)
                {
                    dt.PrimaryKey = new DataColumn[] { dt.Columns["RESOURCE_CODE"] };
                }
                dsSetting.AcceptChanges();
            }
            else
            {
                dsSetting = new DataSet();

                DataTable dt = new DataTable("P_SET");

                dt.Columns.Add(new DataColumn("CORP_CODE", Type.GetType("System.String")));
                dt.Columns.Add(new DataColumn("GATHERING_DUBN", Type.GetType("System.String")));
                dt.Columns.Add(new DataColumn("RESOURCE_CODE", Type.GetType("System.String")));
                dt.Columns.Add(new DataColumn("RESOURCE_NAME", Type.GetType("System.String")));
                dt.Columns.Add(new DataColumn("RESOURCE_IP", Type.GetType("System.String")));
                dt.Columns.Add(new DataColumn("RESOURCE_PORT", Type.GetType("System.String")));
                dt.Columns.Add(new DataColumn("RESOURCE_INTERVAL", Type.GetType("System.String")));
                dt.Columns.Add(new DataColumn("RESOURCE_TYPE", Type.GetType("System.String")));
                dt.PrimaryKey = new DataColumn[] { dt.Columns["RESOURCE_CODE"] };
                dsSetting.Tables.Add(dt);
            }
        }


        public void ucEng_Create()
        {
            try
            {
                ucG = new ucGatheringCtl[iucEngCnt];

                double dRow = 0;

                int icnt = 0;

                int iQty = 3; //열 표시 수량

                int iWidth = 333;
                int iHeight = 222;

                dRow = iucEngCnt;

                dRow = Math.Ceiling(dRow / iQty);

                for (int i = 0; i < iucEngCnt; i++) ucG[i] = new ucGatheringCtl(dsSetting.Tables["P_SET"].Rows[i]);

                for (int a = 0; a < dRow; a++)
                {
                    for (int b = 0; b < iQty; b++)
                    {
                        if (icnt == iucEngCnt)
                        {
                            break;
                        }

                        CoFAS_ControlManager.InvokeIfNeeded(ucG[icnt], () => ucG[icnt].Width = iWidth);
                        CoFAS_ControlManager.InvokeIfNeeded(ucG[icnt], () => ucG[icnt].Height = iHeight);
                        CoFAS_ControlManager.InvokeIfNeeded(ucG[icnt], () => ucG[icnt].Top = (a * (iHeight + 10)) + 10);
                        CoFAS_ControlManager.InvokeIfNeeded(ucG[icnt], () => ucG[icnt].Left = b * (iWidth + 10));
                        CoFAS_ControlManager.InvokeIfNeeded(_pnGMain, () => _pnGMain.Controls.Add(ucG[icnt]));
                        icnt++;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}

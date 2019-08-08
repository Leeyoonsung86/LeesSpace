using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using CoFAS_MES.CORE;
using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.Entity;
using CoFAS_MES.CORE.Function;
using CoFAS_MES.CORE.BaseForm;
using CoFAS_MES.CORE.UserControls;

using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using System.Reflection;
using DevExpress.XtraBars.Navigation;
using System.Globalization;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using System.Diagnostics;



namespace CoFAS_MES
{
    public partial class frmMain : XtraForm, IMainForm
    {
        #region Field

        public UserEntity _pUserEntity = null;
        public MessageEntity _pMessageEntity = null; //공통 메세지 엔티티

        public FavoritesMenuSettingEntity _pFavoritesMenuSettingEntity = null;

        private IForm _pActiveChildForm;

        private bool _isSliding; //좌측 메뉴 슬라이딩 플래그
        private bool _isTimeDisplay; // 좌측 시간 표시 방법 플래그
        private bool _isHomeMaxSize; // 홈 화면 (대쉬보드) 화면 표시 방법
        private bool _isLogout = false; // 로그아웃인지 프로그램 종료인지 플래그

        private static int _StartMonitorLocation = 0;

        private DataTable _dtMenuSetting = null; //메뉴 설정 리스트 

        private Image _imci = null; //사용유무 검토

        private string _strWindowName = ""; //화면 아이디 처리

        //private System.Threading.Timer _tmrNow; //시간 타이머 스레드

        private MouseEventArgs menuMouseClick; // 메뉴 리스트 컨트롤러의 마우스 버튼 클릭 이벤트 처리

        private Font _font = null; // 시스템 폰트 설정

        //private System.Threading.Timer _tmrMonitoring; //모니터링 타이머 스레드
        #endregion
        //private string  _msg                      = "";
        private string  _msgBookMark              = "";
        private string  _msgBookMarkAdd           = "";
        private string  _msgBookMarkAddMessage    = "";
        private string  _msgBookMarkDelete        = "";
        private string  _msgBookMarkDeleteMessage = "";
        private string  _msgBookMarkMessage       = "";
        private string  _msgLoginMessage          = "";
        private string  _msgMessage               = "";
        private string  _msgNotice                = "";
        private string  _msgSystemClose           = "";
        private string  _msgLogoutMessage         = "";
        //사용유무 검토
        private CoFAS_Log _pCoFAS_Log = new CoFAS_Log(Application.StartupPath + "//LOG", "", 30, true);
        protected Image _imCI
        {
            get
            {
                if (_imci == null)
                {
                    //_ptci.PropertyIdList = .PropertyItems;
                }
                return _imci;
            }
            set
            {
                _imci = value;
                //CoFASControl.Invoke_PictureBox_Image(_ptCI, _imci);

            }


        }

        //모니터위치
        /*
        public static int StartMonitorLocation
        {
            get { return _StartMonitorLocation; }
            set { _StartMonitorLocation = value; }
        }
        */
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



        #region 활성 자식 폼 - ActiveChildForm
        public IForm ActiveChildForm
        {
            get
            {
                _pActiveChildForm = ActiveMdiChild as IForm;
                return _pActiveChildForm;
            }
        }

        #endregion

        //public frmMain(UserEntity pUserEntity)
        
        public frmMain(UserEntity pUserEntity, int StartMonitorLocation)
        {
            InitializeComponent();
            //듀얼모니터에서 시작위치
            _StartMonitorLocation = StartMonitorLocation;

            if (System.IO.File.Exists(Application.StartupPath + "\\" + "logo.png"))
            {
                  _ptCI.Image = Image.FromFile(Application.StartupPath + "\\" + "logo.png");
            }
            else
            {
                  _ptCI.Image = Properties.Resources.None;
            }

            _strWindowName = this.Name.ToString(); //SCREEN ID

            _isSliding = true;
            _isTimeDisplay = true;
            _isHomeMaxSize = true;

            _pUserEntity = pUserEntity;

            _pMessageEntity = new MessageEntity();

            _pFavoritesMenuSettingEntity = new FavoritesMenuSettingEntity();

            _pFavoritesMenuSettingEntity.CORP_CODE = _pUserEntity.CORP_CODE;
            _pFavoritesMenuSettingEntity.USER_CODE = _pUserEntity.USER_CODE;

            if(_pUserEntity.USER_GRANT == "PC160001")
            {
                _btSystem_Setting.Visible = true;
            }
            else
            {
                _btSystem_Setting.Visible = false;
            }

            _font = new Font(_pUserEntity.FONT_TYPE, _pUserEntity.FONT_SIZE);
            
            _lbUserName.Text = _pUserEntity.USER_NAME;

            _acdMenuControl.MouseClick += new MouseEventHandler(_acdMenuControl_MouseClick);

            //_tmrNow = new System.Threading.Timer(new TimerCallback(Now_Date_Time), null, 0, 1000);           

            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        /*
        const int WM_NCHITTEST = 0x0084;

        const int HTCLIENT = 1;

       // const int HTCAPTION = 2;

        protected override void WndProc(ref Message m)

        {
            base.WndProc(ref m);

            switch (m.Msg)

            {

                case WM_NCHITTEST:

                    if (m.Result == (IntPtr)1)

                    {

                        m.Result = (IntPtr)2;

                    }

                    break;

            }

        }
  


        protected override CreateParams CreateParams

        {
            get
            {

                CreateParams cp = base.CreateParams;

                cp.Style |= 0x40000;

                return cp;

            }

        }
    */
              /*
        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height;

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            e.Graphics.FillRectangle(Brushes.DarkBlue, rc);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0084)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }
        */

        private void InitializeLanguage()
        {


            _msgNotice = Resources.Language._msgNotice;
            _msgLoginMessage = Resources.Language._msgLoginMessage;

             _msgBookMark             =Resources.Language._msgBookMark                 ;
             _msgBookMarkAdd          =Resources.Language._msgBookMarkAdd              ;
             _msgBookMarkAddMessage   =Resources.Language._msgBookMarkAddMessage       ;
             _msgBookMarkDelete       =Resources.Language._msgBookMarkDelete           ;
             _msgBookMarkDeleteMessage=Resources.Language._msgBookMarkDeleteMessage    ;
             _msgBookMarkMessage      =Resources.Language._msgBookMarkMessage          ;
             _msgLoginMessage         =Resources.Language._msgLoginMessage             ;
             _msgMessage              =Resources.Language._msgMessage                  ;
             _msgNotice               =Resources.Language._msgNotice                   ;
             _msgSystemClose          = Resources.Language._msgSystemClose             ;
            _msgLogoutMessage         = Resources.Language._msgLogoutMessage           ;



            _btSystem_Setting.ToolTip = Resources.Language._btSystem_Setting;
            _btMin.ToolTip = Resources.Language._btMin;
            _btMax.ToolTip = Resources.Language._btMax;
            _btLogout.ToolTip = Resources.Language._btLogout;
            _btClose.ToolTip = Resources.Language._btClose;


        }

        private void _btSystem_Setting_Click(object sender, EventArgs e)
        {
            frmSetting pSetting = new frmSetting(_pUserEntity.USER_CODE);
            pSetting.ShowDialog();
        }

        private void _btMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void _btMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized) this.WindowState = FormWindowState.Normal;
            else this.WindowState = FormWindowState.Maximized;
        }
        //제목표시줄 더블클릭시 전체화면/축소
        private void _lbMAIN_HEADER_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized) this.WindowState = FormWindowState.Normal;
            else this.WindowState = FormWindowState.Maximized;
        }

        private void _btClose_Click(object sender, EventArgs e)
        {
            try
            {
                //if (XtraMessageBox.Show("프로그램을 종료하시겠습니까?", "메시지", MessageBoxButtons.YesNo) == DialogResult.Yes)
                if (XtraMessageBox.Show(_msgSystemClose, _msgMessage, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    new SystemLogInfoBusiness().SystemEventLog_Info_Save("C", _pUserEntity.USER_CODE, _lbMAIN_HEADER.Text.ToString(), _strWindowName, "Log Out", "frmMain_Load", "System Log Out");
                    //Close();
                    Application.ExitThread();
                }
            }
            catch (Exception pException)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(pException);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                
                InitializeLanguage();

                //화면 설정 언어 변경.
                DataTable dtLanguage = new LanguageBusiness().Language_Info(_strWindowName, _pUserEntity.LANGUAGE_TYPE);

                if (dtLanguage != null)
                {
                    CoFAS_ControlManager.Language_Info(dtLanguage, this);
                }

                //공통 메세지 정보 조회.

                DataTable dtMessage = new MessageBusiness().MessageValue_Info(_pUserEntity.LANGUAGE_TYPE, _strWindowName);
                if (dtMessage != null)
                {
                    _pMessageEntity.MSG_SEARCH                      = dtMessage.Rows[0]["MSG_SEARCH"].ToString();
                    _pMessageEntity.MSG_SEARCH_EMPT                 = dtMessage.Rows[0]["MSG_SEARCH_EMPT"].ToString();
                    _pMessageEntity.MSG_SAVE_QUESTION               = dtMessage.Rows[0]["MSG_SAVE_QUESTION"].ToString();
                    _pMessageEntity.MSG_SAVE                        = dtMessage.Rows[0]["MSG_SAVE"].ToString();
                    _pMessageEntity.MSG_SAVE_ERROR                  = dtMessage.Rows[0]["MSG_SAVE_ERROR"].ToString();
                    _pMessageEntity.MSG_DELETE_QUESTION             = dtMessage.Rows[0]["MSG_DELETE_QUESTION"].ToString();
                    _pMessageEntity.MSG_DELETE                      = dtMessage.Rows[0]["MSG_DELETE"].ToString();
                    _pMessageEntity.MSG_DELETE_ERROR                = dtMessage.Rows[0]["MSG_DELETE_ERROR"].ToString();
                    _pMessageEntity.MSG_DELETE_COMPLETE             = dtMessage.Rows[0]["MSG_DELETE_COMPLETE"].ToString();
                    _pMessageEntity.MSG_INPUT_DATA                  = dtMessage.Rows[0]["MSG_INPUT_DATA"].ToString();
                    _pMessageEntity.MSG_INPUT_DATA_ERROR            = dtMessage.Rows[0]["MSG_INPUT_DATA_ERROR"].ToString();
                    _pMessageEntity.MSG_WORKING                     = dtMessage.Rows[0]["MSG_WORKING"].ToString();
                    _pMessageEntity.MSG_RESET_QUESTION              = dtMessage.Rows[0]["MSG_RESET_QUESTION"].ToString();
                    _pMessageEntity.MSG_EXIT_QUESTION               = dtMessage.Rows[0]["MSG_EXIT_QUESTION"].ToString();
                    _pMessageEntity.MSG_SELECT                      = dtMessage.Rows[0]["MSG_SELECT"].ToString();
                    _pMessageEntity.MSG_NO_SELECT_FILEFORM          = dtMessage.Rows[0]["MSG_NO_SELECT_FILEFORM"].ToString();

                    //추가
                    _pMessageEntity.MSG_PLZ_CONNECT_FTP              = dtMessage.Rows[0]["MSG_PLZ_CONNECT_FTP"].ToString();
                    _pMessageEntity.MSG_AGAIN_INPUT_DATA             = dtMessage.Rows[0]["MSG_AGAIN_INPUT_DATA"].ToString();
                    _pMessageEntity.MSG_DOWNLOAD_COMPLETE            = dtMessage.Rows[0]["MSG_DOWNLOAD_COMPLETE"].ToString();
                    _pMessageEntity.MSG_SEARCH_EMPT_DETAIL           = dtMessage.Rows[0]["MSG_SEARCH_EMPT_DETAIL"].ToString();
                    _pMessageEntity.MSG_SPLITQTY_LARGE_MORE          = dtMessage.Rows[0]["MSG_SPLITQTY_LARGE_MORE"].ToString();
                    _pMessageEntity.MSG_DELETE_ERROR_NO_DATA         = dtMessage.Rows[0]["MSG_DELETE_ERROR_NO_DATA"].ToString();
                    _pMessageEntity.MSG_ORDERQTY_LARGE_THAN_0        = dtMessage.Rows[0]["MSG_ORDERQTY_LARGE_THAN_0"].ToString();
                    _pMessageEntity.MSG_PLAN_LARGE_THAN_ORDER        = dtMessage.Rows[0]["MSG_PLAN_LARGE_THAN_ORDER"].ToString();
                    _pMessageEntity.MSG_DELETE_ERROR_CONNECT_FTP     = dtMessage.Rows[0]["MSG_DELETE_ERROR_CONNECT_FTP"].ToString();
                    _pMessageEntity.MSG_INPUT_LESS_THAN_NOTOUTQTY    = dtMessage.Rows[0]["MSG_INPUT_LESS_THAN_NOTOUTQTY"].ToString();
                    _pMessageEntity.MSG_LOAD_DATA                    = dtMessage.Rows[0]["MSG_LOAD_DATA"].ToString();
                    _pMessageEntity.MSG_NEW_REG_GUBN                 = dtMessage.Rows[0]["MSG_NEW_REG_GUBN"].ToString();
                    _pMessageEntity.MSG_INPUT_NUMERIC                = dtMessage.Rows[0]["MSG_INPUT_NUMERIC"].ToString();
                    _pMessageEntity.MSG_NO_SELETED_ITEM              = dtMessage.Rows[0]["MSG_NO_SELETED_ITEM"].ToString();
                    _pMessageEntity.MSG_EXIST_COMPANY_ID             = dtMessage.Rows[0]["MSG_EXIST_COMPANY_ID"].ToString();
                    _pMessageEntity.MSG_NOT_DELETE_DATA_IN           = dtMessage.Rows[0]["MSG_NOT_DELETE_DATA_IN"].ToString();
                    _pMessageEntity.MSG_NOT_MODIFY_DATA_IN           = dtMessage.Rows[0]["MSG_NOT_MODIFY_DATA_IN"].ToString();
                    _pMessageEntity.MSG_SELECT_NEWREG_SAVE           = dtMessage.Rows[0]["MSG_SELECT_NEWREG_SAVE"].ToString();
                    _pMessageEntity.MSG_INPUT_LARGER_THAN_0          = dtMessage.Rows[0]["MSG_INPUT_LARGER_THAN_0"].ToString();
                    _pMessageEntity.MSG_NOT_DELETE_DATA_OUT          = dtMessage.Rows[0]["MSG_NOT_DELETE_DATA_OUT"].ToString();
                    _pMessageEntity.MSG_NOT_MODIFY_DATA_OUT          = dtMessage.Rows[0]["MSG_NOT_MODIFY_DATA_OUT"].ToString();
                    _pMessageEntity.MSG_CANCLE_NEWREG_MODIFY         = dtMessage.Rows[0]["MSG_CANCLE_NEWREG_MODIFY"].ToString();
                    _pMessageEntity.MSG_NO_SELETED_ITEM_OR_NO_SAVE   = dtMessage.Rows[0]["MSG_NO_SELETED_ITEM_OR_NO_SAVE"].ToString();
                    _pMessageEntity.MSG_NO_INPUT_LAGER_THAN_NOTINQTY = dtMessage.Rows[0]["MSG_NO_INPUT_LAGER_THAN_NOTINQTY"].ToString();
                    _pMessageEntity.MSG_REG_DATA                     = dtMessage.Rows[0]["MSG_REG_DATA"].ToString();
                    _pMessageEntity.MSG_ADD_FAVORITE_ITEM            = dtMessage.Rows[0]["MSG_ADD_FAVORITE_ITEM"].ToString();
                    _pMessageEntity.MSG_CHECK_SEARCH_DATE            = dtMessage.Rows[0]["MSG_CHECK_SEARCH_DATE"].ToString();
                    _pMessageEntity.MSG_NOT_DISPLAY_ERROR            = dtMessage.Rows[0]["MSG_NOT_DISPLAY_ERROR"].ToString();
                    _pMessageEntity.MSG_NO_EXIST_INPUT_DATA          = dtMessage.Rows[0]["MSG_NO_EXIST_INPUT_DATA"].ToString();
                    _pMessageEntity.MSG_NOT_DISPLAY_NOT_SAVE         = dtMessage.Rows[0]["MSG_NOT_DISPLAY_NOT_SAVE"].ToString();
                    _pMessageEntity.MSG_CHECK_VALID_ITEM             = dtMessage.Rows[0]["MSG_CHECK_VALID_ITEM"].ToString();
                    _pMessageEntity.MSG_DELETE_FAVORITE_ITEM         = dtMessage.Rows[0]["MSG_DELETE_FAVORITE_ITEM"].ToString();
                    _pMessageEntity.MSG_NOT_EXIST_PRINTING_EXCEL     = dtMessage.Rows[0]["MSG_NOT_EXIST_PRINTING_EXCEL"].ToString();
                    _pMessageEntity.MSG_SELECT_DOWNLOAD_TEMPLETE     = dtMessage.Rows[0]["MSG_SELECT_DOWNLOAD_TEMPLETE"].ToString();
                    _pMessageEntity.MSG_RESET_COMPLETE               = dtMessage.Rows[0]["MSG_RESET_COMPLETE"].ToString();
                    _pMessageEntity.MSG_PROCESS_CODE = dtMessage.Rows[0]["MSG_PROCESS_CODE"].ToString();
                    _pMessageEntity.MSG_STATUS_OK = dtMessage.Rows[0]["MSG_STATUS_OK"].ToString();
                }


                //메뉴 리스트 조회
                SetMenuSettingList(_pUserEntity.USER_CODE);
                
                //메뉴 설정
                SetMenu();

                _lbScreenID.Text = _strWindowName;
                _lbScreenName.Text = _btHOME.Text;
                _lbScreenName.ToolTip = _strWindowName;
                _lbScreenName.ToolTipTitle = _strWindowName;

                System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
                FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
                string version = fvi.FileVersion;
                

                _lbMAIN_HEADER.Text = _lbMAIN_HEADER.Text + " " + version;

                //버튼 초기 설정
                InitializeButtons();

                //_tmrMonitoring = new System.Threading.Timer(new TimerCallback(Change_Monitoring), null, 0, 10000);

                CoFAS_ControlManager.InvokeIfNeeded(_btSet, () => _btSet.Controls.Add(DashboardHomeWidgets.Instance));
                CoFAS_ControlManager.InvokeIfNeeded(_btSet, () => DashboardHomeWidgets.Instance.Dock = DockStyle.Fill);
                CoFAS_ControlManager.InvokeIfNeeded(_btSet, () => DashboardHomeWidgets.Instance.BringToFront());

                Message_Display("");

                //실행위치 받아서 실행 모니터에 실행
                Screen[] screens = Screen.AllScreens;
                Screen scrn = null;
                if (screens.Length > 1)
                {
                    if (_StartMonitorLocation == 0)
                    {
                        scrn = screens[0];
                    }
                    else
                    {
                        scrn = screens[1];
                    }
                    this.StartPosition = FormStartPosition.Manual;

                    Location = new System.Drawing.Point(scrn.Bounds.Left, 0);
                    FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    WindowState = FormWindowState.Maximized;
                }

                //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                //this.WindowState = FormWindowState.Maximized;

                new SystemLogInfoBusiness().SystemEventLog_Info_Save("C", _pUserEntity.USER_CODE, _lbMAIN_HEADER.Text.ToString(), _strWindowName, "Log In", "frmMain_Load", "System Log in");
            }
            catch (Exception pException)
            {
                XtraMessageBox.Show(pException.ToString(), _msgNotice, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DevExpress.Utils.AppearanceObject.DefaultFont = _font;//화면에 모든 항목 폰트 재설정

                Thread.Sleep(1000);
            }
        }

        #region ○ 메뉴 설정 목록 설정하기 - SetMenuSettingList(string strUserID)

        private void SetMenuSettingList(string strUserID)
        {
            try
            {
                #region 메뉴 설정 목록이 있으면 메뉴 설정 목록을 지운다.

                if (_dtMenuSetting != null)
                {
                    _dtMenuSetting.Dispose();
                    _dtMenuSetting = null;
                }

                #endregion

                DataTable dtMenuSetting = new MenuSettingBusiness().Menu_List_Search(strUserID);
                if (dtMenuSetting == null || dtMenuSetting.Rows.Count < 2)
                {
                    return;
                }

                _dtMenuSetting = dtMenuSetting.Clone();

                int nCurrentMenuID = 0;
                int nMenuID;
                DataRow drNewMenuSetting;

                for (int i = 0; i < dtMenuSetting.Rows.Count; i++)
                {
                    nMenuID = (int)(dtMenuSetting.Rows[i]["menu_no"]);

                    if (nMenuID == nCurrentMenuID)
                    {
                        continue;
                    }
                    else
                    {
                        nCurrentMenuID = nMenuID;
                        drNewMenuSetting = _dtMenuSetting.NewRow();
                        for (int j = 0; j < _dtMenuSetting.Columns.Count; j++)
                        {
                            drNewMenuSetting[j] = dtMenuSetting.Rows[i][j];
                        }
                        _dtMenuSetting.Rows.Add(drNewMenuSetting);
                    }
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "SetMenuSettingList(string strUserID)", pException);
            }
        }

        #endregion

        #region ○ 메뉴 설정하기 - SetMenu()

        private void SetMenu()
        {
            try
            {
                _acdMenuControl.ElementClick += new DevExpress.XtraBars.Navigation.ElementClickEventHandler(acdMenuControl_ElementClick);

                if (_dtMenuSetting == null) return;

                DataRow[] drRoots = _dtMenuSetting.Select("p_menu_no = '-1'", "dsp_sort ASC");
                DataView dvChildren = _dtMenuSetting.DefaultView;
                
                //그룹 생성 즐겨찾기 , MES 메뉴

                CoFAS_DevExpressManager.BeginInitialize(_acdMenuControl);
                
                for (int i = 0; i < drRoots.Length; i++)
                {
                    int nMenuID = (int)(drRoots[i]["menu_no"]);
                    string strMenuName = drRoots[i]["menu_name"] as string;
                    string strIconName = drRoots[i]["MENU_ICONCSS"] as string; //"lan_32x32";

                    AccordionControlElement pAccordionControlElementGroup = CoFAS_DevExpressManager.AddAccordionGroup(_acdMenuControl, new Guid().ToString(), strMenuName);

                    //색상 이미지 폰트 설정

                    pAccordionControlElementGroup.Appearance.Normal.BackColor = Color.FromArgb(45, 60, 70); //Color.LightSlateGray;
                    pAccordionControlElementGroup.Appearance.Normal.Font = new Font(_pUserEntity.FONT_TYPE, 12F, System.Drawing.FontStyle.Bold);
                    pAccordionControlElementGroup.Appearance.Normal.ForeColor = Color.White;

                    pAccordionControlElementGroup.Appearance.Hovered.BackColor = Color.FromArgb(45, 60, 70);//Color.LightSteelBlue;
                    pAccordionControlElementGroup.Appearance.Hovered.Font = new Font(_pUserEntity.FONT_TYPE, 12F, System.Drawing.FontStyle.Bold);
                    pAccordionControlElementGroup.Appearance.Hovered.ForeColor = Color.White;

                    pAccordionControlElementGroup.Appearance.Pressed.BackColor = Color.FromArgb(45, 60, 70);//Color.LightSkyBlue;
                    pAccordionControlElementGroup.Appearance.Pressed.Font = new Font(_pUserEntity.FONT_TYPE, 12F, System.Drawing.FontStyle.Bold);
                    pAccordionControlElementGroup.Appearance.Pressed.ForeColor = Color.White;


                    pAccordionControlElementGroup.ImageOptions.Image = CoFAS_MES.Properties.Resources.ResourceManager.GetObject(strIconName, CultureInfo.CurrentCulture) as Image;

                    pAccordionControlElementGroup.Hint = strMenuName;

                    dvChildren.RowFilter = string.Format("p_menu_no = {0}", nMenuID);
                    dvChildren.Sort = "dsp_sort ASC";

                    for (int j = 0; j < dvChildren.Count; j++)
                    {
                        MenuSettingEntity pMenuSettingEntity = new MenuSettingEntity(dvChildren[j]);

                        AccordionControlElement pAccordionControlElementItem = CoFAS_DevExpressManager.AddAccordionItem(pAccordionControlElementGroup, new Guid().ToString(), pMenuSettingEntity.MENU_NAME);

                        pAccordionControlElementItem.Appearance.Normal.BackColor = Color.FromArgb(45, 60, 70); //Color.LightSlateGray;
                        pAccordionControlElementItem.Appearance.Normal.Font = new Font(_pUserEntity.FONT_TYPE, 9F);
                        pAccordionControlElementItem.Appearance.Normal.ForeColor = Color.White;

                        pAccordionControlElementItem.Appearance.Hovered.BackColor = Color.FromArgb(45, 60, 70); //Color.LightSteelBlue;
                        pAccordionControlElementItem.Appearance.Hovered.Font = new Font(_pUserEntity.FONT_TYPE, 9F);
                        pAccordionControlElementItem.Appearance.Hovered.ForeColor = Color.White;

                        pAccordionControlElementItem.Appearance.Pressed.BackColor = Color.FromArgb(45, 60, 70); //Color.LightSkyBlue;
                        pAccordionControlElementItem.Appearance.Pressed.Font = new Font(_pUserEntity.FONT_TYPE, 9F);
                        pAccordionControlElementItem.Appearance.Pressed.ForeColor = Color.White;


                        if (!string.IsNullOrEmpty(pMenuSettingEntity.MENU_ICONCSS))
                        {
                            try
                            {
                                pAccordionControlElementItem.ImageOptions.Image = CoFAS_MES.Properties.Resources.ResourceManager.GetObject(pMenuSettingEntity.MENU_ICONCSS, CultureInfo.CurrentCulture) as Image;
                            }
                            catch
                            {
                            }
                        }
                        else
                        {
                            pAccordionControlElementItem.ImageOptions.Image = CoFAS_MES.Properties.Resources.None;
                        }

                        //pAccordionControlElementItem.Hint = pMenuSettingEntity.MENU_NAME;

                        pAccordionControlElementItem.Tag = pMenuSettingEntity;
                    }
                }

                CoFAS_DevExpressManager.EndInitialize(_acdMenuControl);
                dvChildren.RowFilter = string.Empty;
                dvChildren.Sort = string.Empty;
                dvChildren = null;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "SetMenu()", pException);
            }
        }

        #endregion

        #region ○ 버튼 설정 설정하기 - SetButtonSetting(MainFormButtonSetting pButtonSetting)

        /// <summary>
        /// 버튼 설정 설정하기
        /// </summary>
        public void SetButtonSetting(MainFormButtonSetting pButtonSetting)
        {
            try
            {
                _btHOME.Enabled = true;
           
                _btEXPORT.Visible = pButtonSetting.UseYNExportButton;
                _btIMPORT.Visible = pButtonSetting.UseYNImportButton;
                _btPRINT.Visible = pButtonSetting.UseYNPrintButton;
                _btSAVE.Visible = pButtonSetting.UseYNSaveButton;
                _btSEARCH.Visible = pButtonSetting.UseYNSearchButton;
                _btDELETE.Visible = pButtonSetting.UseYNDeleteButton;

                _btADDITEM.Visible = pButtonSetting.UseYNAddItemButton;

                _btINITIAL.Visible = pButtonSetting.UseYNInitialButton;
                _btSETTING.Visible = pButtonSetting.UseYNSettingButton;
                _btFORMCLOSE.Visible = pButtonSetting.UseYNFormCloseButton;
             


                /*
                _btEXPORT.Enabled = pButtonSetting.UseYNExportButton;
                _btIMPORT.Enabled = pButtonSetting.UseYNImportButton;
                _btPRINT.Enabled = pButtonSetting.UseYNPrintButton;
                _btSAVE.Enabled = pButtonSetting.UseYNSaveButton;
                _btSEARCH.Enabled = pButtonSetting.UseYNSearchButton;
                _btDELETE.Enabled = pButtonSetting.UseYNDeleteButton;

                _btADDITEM.Enabled = pButtonSetting.UseYNAddItemButton;

                _btINITIAL.Enabled = pButtonSetting.UseYNInitialButton;
                _btSETTING.Enabled = pButtonSetting.UseYNSettingButton;
                _btFORMCLOSE.Enabled = pButtonSetting.UseYNFormCloseButton;
                */


            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "SetButtonSetting(MainFormButtonSetting pButtonSetting)", pException);
            }
        }

        #endregion

        #region ○ 버튼 초기화 하기 - InitializeButtons()
        private void InitializeButtons()
        {
            try
            {
                MainFormButtonSetting pButtonSetting = new MainFormButtonSetting();

                pButtonSetting.UseYNSearchButton = false; //조회
                pButtonSetting.UseYNExportButton = false; //내보내기
                pButtonSetting.UseYNImportButton = false; //가져오기
                pButtonSetting.UseYNPrintButton = false;  //프린터
                pButtonSetting.UseYNSaveButton = false;   //저장
                pButtonSetting.UseYNDeleteButton = false; //삭제

                pButtonSetting.UseYNAddItemButton = false; //신규 추가

                pButtonSetting.UseYNInitialButton = false; //초기화
                pButtonSetting.UseYNSettingButton = false; //설정

                SetButtonSetting(pButtonSetting);

            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "InitializeButtons()", pException);
            }
        }

        #endregion

        #region ○ 메뉴 별 윈도우 보여주기 - ShowWindow(pMenuSettingEntity)
        [DllImport("user32.dll")]
        //private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

        private const int SW_SHOWNORMAL = 1;
        private const int SW_SHOWMINIMIZED = 2;
        private const int SW_SHOWMAXIMIZED = 3;

        private void ShowWindow(MenuSettingEntity pMenuSettingEntity)
        {
            try
            {
                #region 열고자 하는 메뉴 화면이 존재하는 경우 해당 화면을 보여준다.

                if(pMenuSettingEntity.MENU_WINDOW_NAME == "DynamicMonitoring")
                {

                    //foreach(Process process in Process.GetProcesses())
                    //{
                    //    if(process.ProcessName.StartsWith("DynamicMonitoring"))
                    //    {
                    //        // 윈도우 타이틀명으로 핸들을 찾는다
                    //        IntPtr hWnd = FindWindow(null, "OWELL"); //process.MainWindowHandle;  //FindWindow(null,"NAVER - Internet Explorer");
                    //        if (!hWnd.Equals(IntPtr.Zero))
                    //        {
                    //            // 윈도우가 최소화 되어 있다면 활성화 시킨다
                    //            ShowWindowAsync(hWnd, SW_SHOWMAXIMIZED);
                    //            // 윈도우에 포커스를 줘서 최상위로 만든다
                    //            SetForegroundWindow(hWnd);
                    //        }
                    //        return;
                    //    }
                    //}

                    ProcessStartInfo startInfo = new ProcessStartInfo(Application.StartupPath + "\\DynamicMonitoring\\DynamicMonitoring.exe");
                    startInfo.WindowStyle = ProcessWindowStyle.Maximized;
                    startInfo.Arguments = string.Format("{0} {1} {2};{3} {4}", DBManager.PrimaryConnectionString, _pUserEntity.USER_GRANT, _pUserEntity.FONT_TYPE, _pUserEntity.FONT_SIZE, _pUserEntity.CULTURE_INFO); // string.Format("{0} {1} {2};{3}", "Server=Db3.coever.co.kr;Database=DynamicMonitoring;UID=Sa;PWD=Codb89897788@$^", _pUserEntity.USER_GRANT, _pUserEntity.FONT_TYPE, _pUserEntity.FONT_SIZE); // 

                    new SystemLogInfoBusiness().SystemEventLog_Info_Save("C", _pUserEntity.USER_CODE, pMenuSettingEntity.MENU_NAME, pMenuSettingEntity.MENU_WINDOW_NAME, "Open Screen", "ShowWindow", "Run screen open");

                    Process.Start(startInfo);

                    return;

                }
                else if(pMenuSettingEntity.MENU_WINDOW_NAME == "FBS")
                {                    
                    Process[] processes = Process.GetProcessesByName("WpfAppFishBone");

                    if (processes.Length < 1)
                    {
                        //fbd 프로그램 띄우기
                        ProcessStartInfo startInfo = new ProcessStartInfo(Application.StartupPath + "\\FBS\\WpfAppFishBone.exe");
                        startInfo.WindowStyle = ProcessWindowStyle.Maximized;
                        startInfo.Arguments = string.Format("{0}#{1}#{2}#{3}#{4}", DBManager.PrimaryConnectionString, _pUserEntity.USER_CODE, _pUserEntity.FONT_TYPE, _pUserEntity.FONT_SIZE, _pUserEntity.CULTURE_INFO);
                        new SystemLogInfoBusiness().SystemEventLog_Info_Save("C", _pUserEntity.USER_CODE, "QC", pMenuSettingEntity.MENU_NAME, "Open Screen", "ShowWindow", "Run screen open");
                        Process.Start(startInfo);
                    }
                    else
                    {
                        foreach (Process process in Process.GetProcesses())
                        {
                            if (process.ProcessName == "WpfAppFishBone")
                            {
                                Console.WriteLine(SetForegroundWindow(process.MainWindowHandle).ToString());
                                ShowWindowAsync(process.MainWindowHandle, 9);
                            }
                        }
                    }
                    return;
                }

                _pnButtonGroup.Visible = true;
                //_btSETTING.Visible = true;

                foreach (Form pChildForm in MdiChildren)
                {
                    IForm pForm = pChildForm as IForm;
                    if (pForm.MenuSettingEntity.MENU_WINDOW_NAME == pMenuSettingEntity.MENU_WINDOW_NAME)
                    {
                        _pnMain.SendToBack();
                        _pnButtonGroup.Visible = true;
                       // _btSETTING.Visible = true;
                        _lbScreenID.Text = pMenuSettingEntity.MENU_WINDOW_NAME;
                        _lbScreenName.Text = pMenuSettingEntity.MENU_NAME;
                        _lbScreenName.ToolTip = pMenuSettingEntity.MENU_WINDOW_NAME;
                        //_lbScreenName.ToolTipTitle = pMenuSettingEntity.MENU_WINDOW_NAME;
                        pChildForm.Show();
                        pChildForm.BringToFront();
                        return;
                    }
                }

                #endregion

                string pAssemblyDll = "CoFAS_MES.UI." + pMenuSettingEntity.MENU_MODULE;// + "View";
                string pAssemblyClass = pAssemblyDll + "." + pMenuSettingEntity.MENU_WINDOW_NAME;

                if (pMenuSettingEntity.MENU_WINDOW_NAME == "")
                    return;

                Assembly assembly = Assembly.LoadFile(Application.StartupPath + "\\" + pAssemblyDll + ".dll");
                Type type = assembly.GetType(pAssemblyClass);
                object obj = Activator.CreateInstance(type);

                Type formType = obj.GetType();

                new SystemLogInfoBusiness().SystemEventLog_Info_Save("C", _pUserEntity.USER_CODE, pMenuSettingEntity.MENU_NAME, pMenuSettingEntity.MENU_WINDOW_NAME, "Open Screen", "ShowWindow", "Run screen open");// string.Format("{0} : {1} - {2} [ {3} ]", _pUserEntity.USER_CODE, pMenuSettingEntity.MENU_NAME, "Open Screen", "Run screen open"));

                switch (formType.BaseType.FullName)
                {
                    case "System.Windows.Forms.Form":
                        Form form = obj as Form;
                        if (form != null)
                        {
                            _lbScreenID.Text = pMenuSettingEntity.MENU_WINDOW_NAME; //하단 프로그램 ID 표시
                            _lbScreenName.Text = pMenuSettingEntity.MENU_NAME; // 하단 프로그램 명 표시
                            _lbScreenName.ToolTip = pMenuSettingEntity.MENU_WINDOW_NAME;
                           // _lbScreenName.ToolTipTitle = pMenuSettingEntity.MENU_WINDOW_NAME;
                            form.Text = pMenuSettingEntity.MENU_NAME; // 폼 프로그램 명 표시 (탭에 표시됨)
                            form.MdiParent = this;
                            form.Show();
                        }
                        break;
                    case "CoFAS_MES.CORE.BaseForm.frmBaseNone":

                        CoFAS_MES.CORE.BaseForm.frmBaseNone xfrmBaseNone = obj as CoFAS_MES.CORE.BaseForm.frmBaseNone;

                        if (xfrmBaseNone != null)
                        {
                            _lbScreenID.Text = pMenuSettingEntity.MENU_WINDOW_NAME; //하단 프로그램 ID 표시
                            _lbScreenName.Text = pMenuSettingEntity.MENU_NAME; // 하단 프로그램 명 표시
                            _lbScreenName.ToolTip = pMenuSettingEntity.MENU_WINDOW_NAME;
                            //_lbScreenName.ToolTipTitle = pMenuSettingEntity.MENU_WINDOW_NAME;
                            xfrmBaseNone.Text = pMenuSettingEntity.MENU_NAME; // 폼 프로그램 명 표시 (탭에 표시됨)
                            xfrmBaseNone.MdiParent = this;
                            xfrmBaseNone.MessageEvent += new frmBaseNone.MessageEventHandler(Message_Display);
                            xfrmBaseNone.MenuSettingEntity = pMenuSettingEntity;
                            xfrmBaseNone.Show();
                        }

                        break;
                    case "CoFAS_MES.CORE.BaseForm.frmBaseDesign":

                        CoFAS_MES.CORE.BaseForm.frmBaseDesign xfrmBaseDesign = obj as CoFAS_MES.CORE.BaseForm.frmBaseDesign;

                        if (xfrmBaseDesign != null)
                        {
                            _lbScreenID.Text = pMenuSettingEntity.MENU_WINDOW_NAME; //하단 프로그램 ID 표시
                            _lbScreenName.Text = pMenuSettingEntity.MENU_NAME; // 하단 프로그램 명 표시
                            _lbScreenName.ToolTip = pMenuSettingEntity.MENU_WINDOW_NAME;
                           // _lbScreenName.ToolTipTitle = pMenuSettingEntity.MENU_WINDOW_NAME;
                            xfrmBaseDesign.Text = pMenuSettingEntity.MENU_NAME; // 폼 프로그램 명 표시 (탭에 표시됨)
                            xfrmBaseDesign.MdiParent = this;
                            xfrmBaseDesign.MessageEvent += new frmBaseDesign.MessageEventHandler(Message_Display);
                            xfrmBaseDesign.MenuSettingEntity = pMenuSettingEntity;
                            xfrmBaseDesign.Show();
                        }

                        break;
                }
                

            }
            catch (Exception pException)
            {
                //new SystemLogInfoBusiness().SystemEventLog_Info_Save("C", _pUserEntity.USER_CODE, pMenuSettingEntity.MENU_NAME, pMenuSettingEntity.MENU_WINDOW_NAME, "Menu Open Error", "ShowWindow", "ShowWindow :" + pException);// string.Format("{0} : {1} - {2} [ {3} ]", _pUserEntity.USER_CODE, pMenuSettingEntity.MENU_NAME, "Open Screen", "Run screen open"));
                //new SystemLogInfoBusiness().SystemEventLog_Info_Save("C", _pUserEntity.USER_CODE, pMenuSettingEntity.MENU_NAME, pMenuSettingEntity.MENU_WINDOW_NAME, "Menu Open Error", "ShowWindow", "ShowWindow_detail :" + pException.StackTrace.ToString());// string.Format("{0} : {1} - {2} [ {3} ]", _pUserEntity.USER_CODE, pMenuSettingEntity.MENU_NAME, "Open Screen", "Run screen open"));
                //new SystemLogInfoBusiness().SystemEventLog_Info_Save("C", _pUserEntity.USER_CODE, pMenuSettingEntity.MENU_NAME, pMenuSettingEntity.MENU_WINDOW_NAME, "Menu Open Error", "ShowWindow", "Path :" + Application.StartupPath);// string.Format("{0} : {1} - {2} [ {3} ]", _pUserEntity.USER_CODE, pMenuSettingEntity.MENU_NAME, "Open Screen", "Run screen open"));
                throw new ExceptionManager(this, "ShowWindow(pMenuSettingEntity)", pException);
                
            }
            finally
            {
            }
        }

        #endregion

        #region ○ 차일드 메뉴 실행 이벤트 - acdMenuControl_ElementClick(object sender, DevExpress.XtraBars.Navigation.ElementClickEventArgs e)
        private void acdMenuControl_ElementClick(object sender, DevExpress.XtraBars.Navigation.ElementClickEventArgs e)
        {
            try
            {
                if (e.Element.Style == DevExpress.XtraBars.Navigation.ElementStyle.Group) return;

                if (menuMouseClick.Button == MouseButtons.Left) //메뉴 오픈
                {
                    if (e.Element.Tag != null)
                    {
                        MenuSettingEntity pMenuSettingEntity = e.Element.Tag as MenuSettingEntity;

                        if (!string.IsNullOrEmpty(pMenuSettingEntity.MENU_NAME))
                        {
                            ShowWindow(pMenuSettingEntity);
                        }
                    }
                }
                else //팝업 열기
                {
                    _acdMenuControl_PopupMenuSetting(e.Element.Tag);
                }
            }
            catch (Exception pException)
            {
                //XtraMessageBox.Show(pException.ToString(), "메시지", MessageBoxButtons.OK, MessageBoxIcon.Error);
                XtraMessageBox.Show(pException.ToString(), _msgMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }

        /// <summary>
        /// 메뉴 마우스 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _acdMenuControl_MouseClick(object sender, MouseEventArgs e)
        {
            menuMouseClick = e;
        }

        #endregion

        #region ○ 즐겨찾기 설정 - _acdMenuControl_PopupMenuSetting(object sender)
        private void _acdMenuControl_PopupMenuSetting(object sender)
        {
            BarManager barManager = new BarManager();

            barManager.Form = this._acdMenuControl;

            PopupMenu popupMenu = new PopupMenu(barManager);

            BarButtonItem itemAddFavorites = new BarButtonItem(barManager, "&" + "Add Bookmark");
            itemAddFavorites.Tag = sender;
            itemAddFavorites.Id = 1;
            popupMenu.ItemLinks.Add(itemAddFavorites);

            BarButtonItem itemDeleteFavorites = new BarButtonItem(barManager, "&" + "Delete Bookmark");
            itemDeleteFavorites.Tag = sender;
            itemDeleteFavorites.Id = 2;
            popupMenu.ItemLinks.Add(itemDeleteFavorites);

            barManager.ItemClick += barManager_ItemClick;

            popupMenu.ShowCaption = true;

            popupMenu.MenuCaption = "Bookmark";

            popupMenu.ShowPopup(Control.MousePosition);
        }
        /// <summary>
        /// 즐겨찾기 추가 삭제 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barManager_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool isErrReturn = false;

            MenuSettingEntity pMenuFavoritesSetting = e.Item.Tag as MenuSettingEntity;

            _pFavoritesMenuSettingEntity.MENU_NO = pMenuFavoritesSetting.MENU_NO;

            DataTable dtMenuFavoritesSetting = new FavoritesMenuSettingBusiness().Favorites_Menu_Search(_pFavoritesMenuSettingEntity);
            if (dtMenuFavoritesSetting != null)
            {
                switch (e.Item.Id)
                {
                    case 1: // 즐겨 찾기 등록
                        if(dtMenuFavoritesSetting.Rows[0]["USE_YN"].ToString() == "Y")
                        {
                            CoFAS_DevExpressManager.ShowInformationMessage(_msgBookMarkMessage);
                            
                        }
                        else
                        {
                            _pFavoritesMenuSettingEntity.CRUD = "C";
                            isErrReturn = new FavoritesMenuSettingBusiness().Favorites_Menu_Save(_pFavoritesMenuSettingEntity);

                            if(!isErrReturn)
                            {
                                _acdMenuControl.BeginInit();

                                _acdMenuControl.Elements.Clear();

                                SetMenuSettingList(_pUserEntity.USER_CODE);
                                SetMenu();

                                _acdMenuControl.EndInit();

                                CoFAS_DevExpressManager.ShowInformationMessage(_msgBookMarkAddMessage);
                            }
                        }
                        break;
                    case 2: // 즐겨 찾기 삭제
                        if (dtMenuFavoritesSetting.Rows[0]["USE_YN"].ToString() == "Y")
                        {
                            _pFavoritesMenuSettingEntity.CRUD = "D";
                            isErrReturn = new FavoritesMenuSettingBusiness().Favorites_Menu_Save(_pFavoritesMenuSettingEntity);

                            if (!isErrReturn)
                            {
                                _acdMenuControl.BeginInit();

                                _acdMenuControl.Elements.Clear();

                                SetMenuSettingList(_pUserEntity.USER_CODE);
                                SetMenu();

                                _acdMenuControl.EndInit();

                                CoFAS_DevExpressManager.ShowInformationMessage(_msgBookMarkDeleteMessage);
                            }

                        }
                        
                        break;
                }


            }
        }
        #endregion

        #region ○ 메시지표시 - Message_Display(string pMessage)

        private void Message_Display(string pMessage)
        {
            _lbMessage.Text = String.Empty.PadLeft(5, ' ') + pMessage;
        }

        #endregion

        #region 기능함수

        #region ○ 메인 폼 이동

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void Form_Moving(object sender, MouseEventArgs e)
        {
            if(e.Clicks==1)
            { 
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
                }
            }
        }

        #endregion

        #region ○ 메뉴바 슬라이딩 기능

        private void _btSliding_Click(object sender, EventArgs e)
        {
            if (_isSliding)
            {
                //_pnLeftMain.Width = 60;
                //if (_pnLeftMain.Width <= 60)
                //{
                //    _isSliding = false;
                //    _isTimeDisplay = false;
                //    CoFAS_ControlManager.InvokeIfNeeded(_lbNowDateTime, () => _lbNowDateTime.Text = CoFAS_ConvertManager.Date2String(DateTime.Now, CoFAS_ConvertManager.enDateType.Time));
                //    _acdMenuControl.OptionsMinimizing.AllowMinimizing = true;
                //    _acdMenuControl.OptionsMinimizing.State = DevExpress.XtraBars.Navigation.AccordionControlState.Minimized;
                //    this.Refresh();
                //}
            }
            else
            {
               // _pnLeftMain.Width = 200;
                //if (_pnLeftMain.Width >= 200)
                //{
                //    _isSliding = true;
                //    _isTimeDisplay = true;
                //    CoFAS_ControlManager.InvokeIfNeeded(_lbNowDateTime, () => _lbNowDateTime.Text = CoFAS_ConvertManager.Date2String(DateTime.Now, CoFAS_ConvertManager.enDateType.DateTime));
                //    _acdMenuControl.OptionsMinimizing.AllowMinimizing = false;
                //    _acdMenuControl.OptionsMinimizing.State = DevExpress.XtraBars.Navigation.AccordionControlState.Normal;
   
                //    this.Refresh();
                //}
            }
        }

        #endregion

        #region ○ 공용 버튼 이벤트

        private void _btHOME_Click(object sender, EventArgs e)
        {
            _pnMain.BringToFront();
            _pnButtonGroup.Visible = false;
            _btSETTING.Visible = false;

            _lbScreenID.Text = _strWindowName;
            _lbScreenName.Text = _btHOME.Text;
            _lbScreenName.ToolTip = _strWindowName;
            _lbScreenName.ToolTipTitle = _strWindowName;
        }

        private void _btSEARCH_Click(object sender, EventArgs e)
        {
            try
            {
                if (ActiveChildForm == null)
                {
                    return;
                }
                ActiveChildForm.RaiseSearchButtonClickedEvent();
            }
            catch(Exception pException)
            {

            }
            finally
            {
                new SystemLogInfoBusiness().SystemEventLog_Info_Save("C", _pUserEntity.USER_CODE, ActiveChildForm.WindowName.ToString(), ActiveChildForm.MenuSettingEntity.MENU_WINDOW_NAME.ToString(), "Search Event", "_btSEARCH", "Button event is executed");
            }
        }

        private void _btADDITEM_Click(object sender, EventArgs e)
        {
            try
            {
                if (ActiveChildForm == null)
                {
                    return;
                }
                ActiveChildForm.RaiseAddItemButtonClickedEvent();
            }
            catch (Exception pException)
            {

            }
            finally
            {
                new SystemLogInfoBusiness().SystemEventLog_Info_Save("C", _pUserEntity.USER_CODE, ActiveChildForm.WindowName.ToString(), ActiveChildForm.MenuSettingEntity.MENU_WINDOW_NAME.ToString(), "Add New Event", "_btADDITEM", "Button event is executed");
            }
        }

        private void _btSAVE_Click(object sender, EventArgs e)
        {
            try
            {
                if (ActiveChildForm == null)
                {
                    return;
                }
                ActiveChildForm.RaiseSaveButtonClickedEvent();
            }
            catch (Exception pException)
            {
                _pCoFAS_Log.WLog(pException.Message);
            }
            finally
            {
                new SystemLogInfoBusiness().SystemEventLog_Info_Save("C", _pUserEntity.USER_CODE, ActiveChildForm.WindowName.ToString(), ActiveChildForm.MenuSettingEntity.MENU_WINDOW_NAME.ToString(), "Save Event", "_btSAVE", "Button event is executed");
            }
        }

        private void _btDELETE_Click(object sender, EventArgs e)
        {
            try
            {
                if (ActiveChildForm == null)
                {
                    return;
                }
                ActiveChildForm.RaiseDeleteButtonClickedEvent();
            }
            catch (Exception pException)
            {

            }
            finally
            {
                new SystemLogInfoBusiness().SystemEventLog_Info_Save("C", _pUserEntity.USER_CODE, ActiveChildForm.WindowName.ToString(), ActiveChildForm.MenuSettingEntity.MENU_WINDOW_NAME.ToString(), "Delete Event", "_btDELETE", "Button event is executed");
            }
        }

        private void _btEXPORT_Click(object sender, EventArgs e)
        {
            try
            {
                if (ActiveChildForm == null)
                {
                    return;
                }
                ActiveChildForm.RaiseExportButtonClickedEvent();
            }
            catch (Exception pException)
            {

            }
            finally
            {
                new SystemLogInfoBusiness().SystemEventLog_Info_Save("C", _pUserEntity.USER_CODE, ActiveChildForm.WindowName.ToString(), ActiveChildForm.MenuSettingEntity.MENU_WINDOW_NAME.ToString(), "Exprot Event", "_btEXPORT", "Button event is executed");
            }
        }

        private void _btIMPORT_Click(object sender, EventArgs e)
        {
            try
            {
                if (ActiveChildForm == null)
                {
                    return;
                }
                ActiveChildForm.RaiseImportButtonClickedEvent();
            }
            catch (Exception pException)
            {

            }
            finally
            {
                new SystemLogInfoBusiness().SystemEventLog_Info_Save("C", _pUserEntity.USER_CODE, ActiveChildForm.WindowName.ToString(), ActiveChildForm.MenuSettingEntity.MENU_WINDOW_NAME.ToString(), "Import Event", "_btIMPORT", "Button event is executed");
            }
        }

        private void _btPRINT_Click(object sender, EventArgs e)
        {
            try
            {
                if (ActiveChildForm == null)
                {
                    return;
                }
                ActiveChildForm.RaisePrintButtonClickedEvent();
            }
            catch (Exception pException)
            {

            }
            finally
            {
                new SystemLogInfoBusiness().SystemEventLog_Info_Save("C", _pUserEntity.USER_CODE, ActiveChildForm.WindowName.ToString(), ActiveChildForm.MenuSettingEntity.MENU_WINDOW_NAME.ToString(), "Print Event", "_btPRINT", "Button event is executed");
            }
        }

        private void _btINITIAL_Click(object sender, EventArgs e)
        {
            try
            {
                if (ActiveChildForm == null)
                {
                    return;
                }
                ActiveChildForm.RaiseInitialButtonClickedEvent();
            }
            catch (Exception pException)
            {

            }
        }

        private void _btSETTING_Click(object sender, EventArgs e)
        {
            try
            {
                if (ActiveChildForm == null)
                {
                    return;
                }
                ActiveChildForm.RaiseSettingButtonClickedEvent();
            }
            catch (Exception pException)
            {

            }
        }

        private void _btFORMCLOSE_Click(object sender, EventArgs e)
        {
            try
            {
                if (ActiveChildForm == null)
                {
                    return;
                }
                ActiveChildForm.RaiseFormCloseButtonClickedEvent();
            }
            catch (Exception pException)
            {

            }           
        }

        private void _btEXIT_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show(_msgSystemClose, _msgMessage, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.ExitThread();
                }
            }
            catch (Exception pException)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(pException);
            }
        }

        private void _btUSER_SETTING_Click(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (Exception pException)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(pException);
            }
        }

        private void _btHomeMaxSize_Click(object sender, EventArgs e)
        {
            if(_isHomeMaxSize)
            {
                _isHomeMaxSize = false;
                _acdMenuControl.Visible = false;
                //_pnLeftMain.Visible = false;
                _pnButton.Visible = false;
                _pnBottom.Visible = false;
                _btHomeMaxSize.ImageOptions.Image = Properties.Resources.alignhorizontalbottom_16x16;
            }
            else
            {
                _isHomeMaxSize = true;
                _acdMenuControl.Visible = true;
                //_pnLeftMain.Visible = true;
                _pnButton.Visible = true;
                _pnBottom.Visible = true;
                _btHomeMaxSize.ImageOptions.Image = Properties.Resources.alignhorizontaltop_16x16;
            }
        }

        private void _btHomeRefresh_Click(object sender, EventArgs e)
        {
           
        }

        #endregion

        #region ○ 현제 시간 업데이트
        //private void Now_Date_Time(object obj)
        //{
        //    if (_isTimeDisplay)
        //    {
        //        CoFAS_ControlManager.InvokeIfNeeded(_lbNowDateTime, () => _lbNowDateTime.Text = CoFAS_ConvertManager.Date2String(DateTime.Now, CoFAS_ConvertManager.enDateType.DateTime));
        //    }
        //    else
        //    {
        //        CoFAS_ControlManager.InvokeIfNeeded(_lbNowDateTime, () => _lbNowDateTime.Text = CoFAS_ConvertManager.Date2String(DateTime.Now, CoFAS_ConvertManager.enDateType.Time));
        //    }
        //}


        #endregion

        //bool isChange = true;
        private void Change_Monitoring (object obj)
        {
    //if (isChange)
    //{

    //    if (!_pnMainContents.Controls.Contains(ucMainMonitoring.Instance))
    //    {
    //        CoFAS_ControlManager.InvokeIfNeeded(_pnMainContents, () => _pnMainContents.Controls.Add(ucMainMonitoring.Instance));
    //        CoFAS_ControlManager.InvokeIfNeeded(_pnMainContents, () => ucMainMonitoring.Instance.Dock = DockStyle.Fill);
    //        CoFAS_ControlManager.InvokeIfNeeded(_pnMainContents, () => ucMainMonitoring.Instance.BringToFront());
    //    }
    //    else
    //    {
    //        CoFAS_ControlManager.InvokeIfNeeded(_pnMainContents, () => ucMainMonitoring.Instance.BringToFront());
    //    }

    //    isChange = false;
    //}
    //else
    //{
    //    if (!_pnMainContents.Controls.Contains(ucSubMonitoring.Instance))
    //    {
    //        CoFAS_ControlManager.InvokeIfNeeded(_pnMainContents, () => _pnMainContents.Controls.Add(ucSubMonitoring.Instance));
    //        CoFAS_ControlManager.InvokeIfNeeded(_pnMainContents, () => ucSubMonitoring.Instance.Dock = DockStyle.Fill);
    //        CoFAS_ControlManager.InvokeIfNeeded(_pnMainContents, () => ucSubMonitoring.Instance.BringToFront());
    //    }
    //    else
    //    {
    //        CoFAS_ControlManager.InvokeIfNeeded(_pnMainContents, () => ucSubMonitoring.Instance.BringToFront());
    //    }

    //    isChange = true;
    //}


    //if(isChange)
    //{

    //    CoFAS_ControlManager.InvokeIfNeeded(_ucMainMonitoring, () => _ucMainMonitoring.SendToBack());
    //    CoFAS_ControlManager.InvokeIfNeeded(_ucMainMonitoring, () => _ucMainMonitoring.Visible = false);

    //    //CoFAS_ControlManager.InvokeIfNeeded(_ucSubMonitoring, () => _ucSubMonitoring.BringToFront());
    //    //CoFAS_ControlManager.InvokeIfNeeded(_ucSubMonitoring, () => _ucSubMonitoring.Visible = true);
    //    isChange = false;

    //}
    //else
    //{

    //    CoFAS_ControlManager.InvokeIfNeeded(_ucMainMonitoring, () => _ucMainMonitoring.BringToFront());
    //    CoFAS_ControlManager.InvokeIfNeeded(_ucMainMonitoring, () => _ucMainMonitoring.Visible = true);

    //    //CoFAS_ControlManager.InvokeIfNeeded(_ucSubMonitoring, () => _ucSubMonitoring.SendToBack());
    //    //CoFAS_ControlManager.InvokeIfNeeded(_ucSubMonitoring, () => _ucSubMonitoring.Visible = false);
    //    isChange = true;
    //}
}

    /// <summary>
    /// 탭 메뉴 닫기 처리 이벤트
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void xtraTabMdiControl_PageRemoved(object sender, DevExpress.XtraTabbedMdi.MdiTabPageEventArgs e)
        {
            if (xtraTabMdiControl.Pages.Count == 0)
            {
                _pnMain.BringToFront();
            }
        }

        /// <summary>
        /// 탭 메뉴 생성시 처리 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void xtraTabMdiControl_PageAdded(object sender, DevExpress.XtraTabbedMdi.MdiTabPageEventArgs e)
        {
            if (xtraTabMdiControl.Pages.Count != 0)
            {
                _pnMain.SendToBack();
            }
        }

        /// <summary>
        /// 차일드 폼 활성화 시 상태 정보 표시
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_MdiChildActivate(object sender, EventArgs e)
        {
            if (ActiveChildForm != null)
            {
                _lbScreenID.Text = ActiveChildForm.MenuSettingEntity.MENU_WINDOW_NAME;
                _lbScreenName.Text = ActiveChildForm.MenuSettingEntity.MENU_NAME;
                _lbScreenName.ToolTip = ActiveChildForm.MenuSettingEntity.MENU_WINDOW_NAME;
                _lbScreenName.ToolTipTitle = ActiveChildForm.MenuSettingEntity.MENU_WINDOW_NAME;
            }
            else
            {
                //차일드 폼이 없을 경우 메인 홈 명칭으로 변경
                _lbScreenID.Text = _strWindowName;
                _lbScreenName.Text = _btHOME.Text;
                _lbScreenName.ToolTip = _strWindowName;
                _lbScreenName.ToolTipTitle = _strWindowName;

                InitializeButtons();
            }
        }


        #endregion

        /// <summary>
        /// 메인 메뉴 표시 설정
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _acdMenuControl_SizeChanged(object sender, EventArgs e)
        {
            //if (_pnLeftMain.Width >= 200)
            //{
            //    _isSliding = false;
            //    _isTimeDisplay = false;
            //    _lbUserName.Visible = false;
            //    //CoFAS_ControlManager.InvokeIfNeeded(_lbNowDateTime, () => _lbNowDateTime.Text = CoFAS_ConvertManager.Date2String(DateTime.Now, CoFAS_ConvertManager.enDateType.Time));
            //    // _acdMenuControl.OptionsMinimizing.AllowMinimizing = true;
            //    // _acdMenuControl.OptionsMinimizing.State = DevExpress.XtraBars.Navigation.AccordionControlState.Minimized;

            //    //_pnLeftMain.Width = 60;
            //}

            //if (_pnLeftMain.Width <= 60)
            //{
            //    _isSliding = true;
            //    _isTimeDisplay = true;
            //    _lbUserName.Visible = true;
            //    //CoFAS_ControlManager.InvokeIfNeeded(_lbNowDateTime, () => _lbNowDateTime.Text = CoFAS_ConvertManager.Date2String(DateTime.Now, CoFAS_ConvertManager.enDateType.DateTime));
            //    //  _acdMenuControl.OptionsMinimizing.AllowMinimizing = false;
            //    //  _acdMenuControl.OptionsMinimizing.State = DevExpress.XtraBars.Navigation.AccordionControlState.Normal;

            //    //_pnLeftMain.Width = 200;
            //}

            //this.Refresh();
        }

        private void Form_SizeChange(object sender, MouseEventArgs e)
        {

            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
            //if (e.Button == MouseButtons.Left)
            //{
            //    ReleaseCapture();
            //    SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            //}
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_isLogout)
                Application.ExitThread();
        }

        private void xtraTabMdiControl_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right) //팝업 열기
                {
                    // MessageBox.Show("마우스");
                    // _acdMenuControl_PopupMenuSetting(e.Element.Tag);
                }
            }
            catch (Exception pException)
            {
                XtraMessageBox.Show(pException.ToString(), _msgMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void _btLogout_Click(object sender, EventArgs e)
        {
            try
            {
                //if (XtraMessageBox.Show("프로그램을 종료하시겠습니까?", "메시지", MessageBoxButtons.YesNo) == DialogResult.Yes)
                if (XtraMessageBox.Show(_msgLogoutMessage, _msgMessage, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    new SystemLogInfoBusiness().SystemEventLog_Info_Save("C", _pUserEntity.USER_CODE, _lbMAIN_HEADER.Text.ToString(), _strWindowName, "Log Out", "frmMain_Load", "System Log Out");
                    _isLogout = true;
                    //Close();
                    //Application.ExitThread();
                    _ptCI.Image.Dispose();
                    Close();
                }
            }
            catch (Exception pException)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(pException);
            }
        }
    }
}

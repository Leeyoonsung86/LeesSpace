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
using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.Function;

using CoFAS_MES.CORE.UserForm;

using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.Entity;
using DevExpress.XtraGrid.Views.Grid;

namespace CoFAS_MES.CORE.UserControls
{
    public partial class Notice : UserControl
    {
        public string _pCORP_CODE = string.Empty;       // 회사코드       
        public string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        public string _pUSER_NAME = string.Empty;       // 사용자이름
        public static string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어

        public string _pWINDOW_NAME = string.Empty;     // 화면 명칭
        public string _pFONT_TYPE = string.Empty;       // 시스템 폰트 타입 설정
        public int _pFONT_SIZE = 9;                     // 시스템 폰트 사이즈 설정 기본 9
        private Font _pFONT_SETTING = null;             // 시스템 폰트 설정
        private string _pFTP_ID = string.Empty;          // FTP ID 정보
        private string _pFTP_IP_PORT = string.Empty;        // FTP SERVER IP 정보
        private string _pFTP_PATH = string.Empty;     // FTP SERVER IP 정보
        private string _pFTP_PW = string.Empty;          //FTP PW 정보
        private string _pLocation_Code = string.Empty;  // 저장/수정 후 로케이션 위치 저장
        private bool _pLocation_YN = true;              // 저장위치 사용여부
        public string _pMENU_NAME = string.Empty;       // 메뉴명칭

        private static Font fntPARENT_FONT = null;       // 시스템 폰트 설정

        private NoticeEntity _pNoticeEntity = null; // 엔티티 생성

        private DataTable _dtList = null; //조회 데이터 리스트

        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용

        public Notice()
        {
            InitializeComponent();

            Load += new EventHandler(Form_Load);
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

        #region ○ Form_Load
        private void Form_Load(object pSender, EventArgs pEventArgs)
        {
            try
            {
                InitializeSetting();

                CoFAS_ControlManager.SetFontInControls(this.Controls, _pFONT_SETTING);
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {
                DevExpress.Utils.AppearanceObject.DefaultFont = _pFONT_SETTING;//화면에 모든 항목 폰트 재설정
            }
        }
        #endregion

        // 초기화 처리 영역
        #region ○ 메뉴 초기화 하기 - InitializeSetting()

        private void InitializeSetting()
        {
            try
            {
                //메인 화면 전역 변수 처리
                _pWINDOW_NAME = this.Name;
                _pMENU_NAME = this.Text;

                //그리드 설정
                InitializeGrid();
                
                //그리드 초기화 
                //메인 그리드
                _gdMAIN.DataSource = null;

                //메뉴 화면 엔티티 설정
                _pNoticeEntity = new NoticeEntity();

                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                _pNoticeEntity.CRUD = "";
                
                if (_pFirstYN)
                {
                    Font f_Setting = new Font("굴림", 12);

                    //컨트롤러 별 추가 이벤트 생성은 화면 설정 마지막에 진행
                    _gdMAIN_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdMAIN, _gdMAIN_VIEW, f_Setting, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdMAIN.Name.ToString()));
                    
                    _gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick;
                    
                    MainFind_DisplayData();

                    //조회조건 영역 
                    _pFirstYN = false;
                }
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
                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                if (_pFirstYN)
                {
                    _pLANGUAGE_TYPE = "한국어";
                    _pFONT_SETTING = new Font("굴림", 9);

                    _gdMAIN_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdMAIN, _gdMAIN_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdMAIN.Name.ToString()));

                }

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion

        // 추가 이벤트 생성
        #region ○ 메인 그리드 로우 선택 이벤트 생성 - _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        private void _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;
                CoFAS_ControlManager.Controls_Binding(gv, false, this); //그리드 정보 디테일 표기

                _pNoticeEntity.CRUD = "R";
                _pNoticeEntity.NOTICE_ID = gv.GetFocusedRowCellValue("NOTICE_ID").ToString();

                string title = gv.GetFocusedRowCellValue("TITLE").ToString();
                string contents = gv.GetFocusedRowCellValue("CONTENTS").ToString();
                string user = gv.GetFocusedRowCellValue("REG_USER").ToString();
                string date = gv.GetFocusedRowCellValue("NOTICE_DATE").ToString();

                frmCommonPopup.CRUD = "R";
                frmCommonPopup.USER_CODE = _pUSER_CODE;
                frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                // 0 서비스네임 1 공통코드경우 CODE_TYPE 으로구분자 올린다.
                frmCommonPopup.ARRAY_CODE = new object[4] { title, contents, user, date };
                frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("NoticeDetail"); //유저컨트롤러 설정 부분

                xfrmCommonPopup.ShowDialog();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion

        // DB 처리
        #region ○ 메인조회 - MainFind_DisplayData()
        private void MainFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _pNoticeEntity.CRUD = "R";

                _dtList = new NoticeBusiness().Notice_Info_Mst(_pNoticeEntity);

                if (_pNoticeEntity.CRUD == "") _dtList.Rows.Clear();

                if (_dtList != null && _dtList.Rows.Count > 0)//&& _dtList.Rows.Count > 0) )|| (_dtList != null && _pNoticeRegisterEntity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩

                    if (_pLocation_Code != "" && _pLocation_YN)
                    {
                        int rowHandle = _gdMAIN_VIEW.LocateByValue("NOTICE_ID", _pLocation_Code);
                        if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                            _gdMAIN_VIEW.FocusedRowHandle = rowHandle;


                        //조회 후 초기화 
                        _pLocation_Code = "";
                    }
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
        
    }
}

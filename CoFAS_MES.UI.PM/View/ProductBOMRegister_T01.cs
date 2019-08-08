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
using CoFAS_MES.CORE;

using CoFAS_MES.UI.PM.Business;
using CoFAS_MES.UI.PM.Data;
using CoFAS_MES.UI.PM.Entity;
using DevExpress.XtraGrid.Views.Grid;
using CoFAS_MES.UI.PM.UserForm;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors;

namespace CoFAS_MES.UI.PM
{
    public partial class ProductBOMRegister_T01 : frmBaseNone
    {
        private string _pCORP_CODE = string.Empty;       // 회사코드        
        private string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        private string _pUSER_NAME = string.Empty;       // 사용자이름
        private string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어
        private string _pWINDOW_NAME = string.Empty;     // 화면 명칭
        private string _pFONT_TYPE = string.Empty;       // 시스템 폰트 타입 설정
        private int _pFONT_SIZE = 9;                     // 시스템 폰트 사이즈 설정 기본 9
        private Font _pFONT_SETTING = null;              // 시스템 폰트 설정
        private string _pFTP_ID = string.Empty;          // FTP ID 정보
        private string _pFTP_IP_PORT = string.Empty;     // FTP SERVER IP 정보
        private string _pFTP_PW = string.Empty;          //FTP PW 정보
        private string _pUSER_GRANT = string.Empty; // 사용자 권한

        //공통 메시지 영역 
        private string _pMSG_SEARCH = string.Empty;   // 조회 되었습니다.
        private string _pMSG_SEARCH_EMPT = string.Empty;   // 조회 항목이 없습니다.
        private string _pMSG_SAVE_QUESTION = string.Empty;   // 데이터 저장 처리 하겠습니까?
        private string _pMSG_SAVE = string.Empty;   // 저장 처리 되었습니다.
        private string _pMSG_SAVE_ERROR = string.Empty;   // 저장 처리 중 오류가 발생 하였습니다.
        private string _pMSG_DELETE_QUESTION = string.Empty;   // 데이터 삭제 처리 하겠습니까?
        private string _pMSG_DELETE = string.Empty;   // 삭제 처리 되었습니다.
        private string _pMSG_DELETE_ERROR = string.Empty;   // 삭제 처리 중 오류가 발생 하였습니다.
        private string _pMSG_DELETE_COMPLETE = string.Empty;   // 삭제된 데이터 입니다.
        private string _pMSG_INPUT_DATA = string.Empty;   // 데이터를 입력 해 주세요.
        private string _pMSG_INPUT_DATA_ERROR = string.Empty;   // 데이터 입력이 잘못되었습니다.
        private string _pMSG_WORKING = string.Empty;   // 작업중인 항목이 있습니다.
        private string _pMSG_RESET_QUESTION = string.Empty;   // 초기화 하시겠습니까?
        private string _pMSG_EXIT_QUESTION = string.Empty;   // 종료 하겠습니까?
        private string _pMSG_SELECT = string.Empty;   // 데이터를 선택해주세요.
        private string _pMSG_RESET_COMPLETE = string.Empty;     //초기화 하였습니다.
        private string _pMSG_CHECK_VALID_ITEM = string.Empty;    //필수항목을 확인해주시기 바랍니다. 

        //화면 추가 메시지 영역
        private string _pMSG_REVISION_CHECK = string.Empty;   // 리비젼 확인(변경) 후 작업
        private string _pMSG_BOM_COPY_CHECK = string.Empty;   // BOM 복사 시에만 가능
        private string _pMSG_BOM_DISABLE = string.Empty;   // 사용 중지된 BOM 입니다
        private string _pMSG_LEVEL_SAME_NOT = string.Empty;   // 코드를 같은 레벨 에 등록 할 수 없습니다
        private string _pMSG_PART_ALREADY_BOM = string.Empty;   // BOM 구성된 제품 입니다.
        private string _pMSG_PART_NOT_CHILD = string.Empty;   // 하위 품목 에 등록할 수 없습니다
        private string _pMSG_PART_NOT_OTHER = string.Empty;   // 제품코드 이 외에 등록 할 수 없습니다
        private string _pMSG_PART_NOT_SUB = string.Empty;   // 하위 품목 에 등록 할 수 없습니다
        private string _pMSG_PART_SAME_CODE = string.Empty;   // 상위코드와 같습니다
        private string _pMSG_PRODUCT_NOT_SUB = string.Empty;   // 제품코드 는 하위품목 으로 등록 할 수 없습니다
        private string _pMSG_REVISION_INIT = string.Empty;   // 리비젼 정보가 초기화됩니다
        private string _pMSG_SEMI_PART_NOT_REG = string.Empty;   // 반제품 품목 에 등록 할 수 없습니다


        private ProductBOMRegister_T01Entity _pProductBOMRegister_T01Entity = null; // 엔티티 생성

        private CoFAS_DevGridManager _TempGridView;

        private DataTable _dtList = null; //조회 데이터 리스트
        private DataTable ctDT = new DataTable("TreeData"); //그리드 트리 저장 처리 데이터 테이블
        private DataRow ctDR = null; // tree 저장 처리 데이터 로우
        private DataTable tmp_PRODUCTION_PART = null;
        private DataTable tmp_MATERIAL_PART = null;


        private DataTable _dtBOMCheckList = null; //선택된 BOM 리스트 체크용 백업 데이터테이블

        private DataTable dtMessage = null; // 화면별 메세지 관리 데이터 테이블

        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용


        public ProductBOMRegister_T01()
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
                InitializeButtons();
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

                if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_EXIT_QUESTION) == DialogResult.No)
                {
                    pFormClosingEventArgs.Cancel = true;
                    return;
                }

                pFormClosingEventArgs.Cancel = false;
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
                _gdMAIN_VIEW.RowCellClick -= _gdMAIN_VIEW_RowCellClick;
                _gdSUB_VIEW.InitNewRow -= _gdSUB_VIEW_InitNewRow;
                _gdSUB_VIEW.ShownEditor -= _gdSUB_VIEW_ShownEditor;
                _gdMAIN_VIEW.FocusedRowChanged -= new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(_gdMAIN_VIEW_RowChange);
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
                InitializeSetting();

                //버튼이벤트 생성
                SearchButtonClicked += new EventHandler(Form_SearchButtonClicked);
                SaveButtonClicked += new EventHandler(Form_SaveButtonClicked);
                AddItemButtonClicked += new EventHandler(Form_AddItemButtonClicked);
                DeleteButtonClicked += new EventHandler(Form_DeleteButtonClicked);
                PrintButtonClicked += new EventHandler(Form_PrintButtonClicked);
                ExportButtonClicked += new EventHandler(Form_ExportButtonClicked);
                ImportButtonClicked += new EventHandler(Form_ImportButtonClicked);
                InitialButtonClicked += new EventHandler(Form_InitialButtonClicked);
                SettingButtonClicked += new EventHandler(Form_SettingButtonClicked);

                FormCloseButtonClicked += new EventHandler(Form_FormCloseButtonClicked);
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {
                // DevExpress.Utils.AppearanceObject.DefaultFont = _pFONT_SETTING;//화면에 모든 항목 폰트 재설정
                //dxWaitViewManager.CloseWaitForm();
            }
        }

        //private void Viewer_ConfigureDataConnection(object sender, DashboardConfigureDataConnectionEventArgs e)
        //{
        //    if (e.ConnectionName == "m.coever.co.kr_coever_mes_Connection")
        //    {
        //        e.ConnectionParameters = new MySqlConnectionParameters();
        //        SqlDashboardHelper.SetupSqlParameters((MySqlConnectionParameters)e.ConnectionParameters);
        //    }

        //}
        #endregion

        // 초기화 처리 영역
        #region ○ 메뉴 초기화 하기 - InitializeSetting()

        private void InitializeSetting()
        {
            try
            {
                //상속 화면 패널 사용 유무
              

                //메인 화면 전역 변수 처리
                _pCORP_CODE = MainForm.UserEntity.CORP_CODE;
                _pUSER_CODE = MainForm.UserEntity.USER_CODE;
                _pUSER_NAME = MainForm.UserEntity.USER_NAME;
                _pLANGUAGE_TYPE = MainForm.UserEntity.LANGUAGE_TYPE;
                _pFONT_TYPE = MainForm.UserEntity.FONT_TYPE;
                _pFONT_SIZE = MainForm.UserEntity.FONT_SIZE;
                _pFONT_SETTING = new Font(_pFONT_TYPE, _pFONT_SIZE);
                _pFTP_ID = MainForm.UserEntity.FTP_ID;
                _pFTP_IP_PORT = MainForm.UserEntity.FTP_IP_PORT;  //string.Format(@"{0}/{1}/", MainForm.UserEntity.FTP_IP_PORT, "test"); //화면 별 해당 위치 지정
                _pFTP_PW = MainForm.UserEntity.FTP_PW;
                _pUSER_GRANT = MainForm.UserEntity.USER_GRANT;

                //메인 화면 공통 메세지 처리
                _pMSG_SEARCH = MainForm.MessageEntity.MSG_SEARCH;
                _pMSG_SEARCH_EMPT = MainForm.MessageEntity.MSG_SEARCH_EMPT;
                _pMSG_SAVE_QUESTION = MainForm.MessageEntity.MSG_SAVE_QUESTION;
                _pMSG_SAVE = MainForm.MessageEntity.MSG_SAVE;
                _pMSG_SAVE_ERROR = MainForm.MessageEntity.MSG_SAVE_ERROR;
                _pMSG_DELETE_QUESTION = MainForm.MessageEntity.MSG_DELETE_QUESTION;
                _pMSG_DELETE = MainForm.MessageEntity.MSG_DELETE;
                _pMSG_DELETE_ERROR = MainForm.MessageEntity.MSG_DELETE_ERROR;
                _pMSG_DELETE_COMPLETE = MainForm.MessageEntity.MSG_DELETE_COMPLETE;
                _pMSG_INPUT_DATA = MainForm.MessageEntity.MSG_INPUT_DATA;
                _pMSG_INPUT_DATA_ERROR = MainForm.MessageEntity.MSG_INPUT_DATA_ERROR;
                _pMSG_WORKING = MainForm.MessageEntity.MSG_WORKING;
                _pMSG_RESET_QUESTION = MainForm.MessageEntity.MSG_RESET_QUESTION;
                _pMSG_EXIT_QUESTION = MainForm.MessageEntity.MSG_EXIT_QUESTION;
                _pMSG_SELECT = MainForm.MessageEntity.MSG_SELECT;
                _pMSG_RESET_COMPLETE = MainForm.MessageEntity.MSG_RESET_COMPLETE;
                _pMSG_CHECK_VALID_ITEM = MainForm.MessageEntity.MSG_CHECK_VALID_ITEM;

                _pWINDOW_NAME = this.Name;

                //메뉴 화면 엔티티 설정
                _pProductBOMRegister_T01Entity = new ProductBOMRegister_T01Entity();
                _pProductBOMRegister_T01Entity.CORP_CODE = _pCORP_CODE;
                _pProductBOMRegister_T01Entity.USER_CODE = _pUSER_CODE;
                _pProductBOMRegister_T01Entity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;

                //추가 메세지 정보 조회.
                dtMessage = new MessageBusiness().MessageValue_Mst_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME);

                if (dtMessage != null && dtMessage.Rows[0][0].ToString() != "")
                {
                    _pMSG_REVISION_CHECK = dtMessage.Rows[0]["MSG_REVISION_CHECK"].ToString();
                    _pMSG_BOM_COPY_CHECK = dtMessage.Rows[0]["MSG_BOM_COPY_CHECK"].ToString();
                    _pMSG_BOM_DISABLE = dtMessage.Rows[0]["MSG_BOM_DISABLE"].ToString();
                    _pMSG_LEVEL_SAME_NOT = dtMessage.Rows[0]["MSG_LEVEL_SAME_NOT"].ToString();
                    _pMSG_PART_ALREADY_BOM = dtMessage.Rows[0]["MSG_PART_ALREADY_BOM"].ToString();
                    _pMSG_PART_NOT_CHILD = dtMessage.Rows[0]["MSG_PART_NOT_CHILD"].ToString();
                    _pMSG_PART_NOT_OTHER = dtMessage.Rows[0]["MSG_PART_NOT_OTHER"].ToString();
                    _pMSG_PART_NOT_SUB = dtMessage.Rows[0]["MSG_PART_NOT_SUB"].ToString();
                    _pMSG_PART_SAME_CODE = dtMessage.Rows[0]["MSG_PART_SAME_CODE"].ToString();
                    _pMSG_PRODUCT_NOT_SUB = dtMessage.Rows[0]["MSG_PRODUCT_NOT_SUB"].ToString();
                    _pMSG_REVISION_INIT = dtMessage.Rows[0]["MSG_REVISION_INIT"].ToString();
                    _pMSG_SEMI_PART_NOT_REG = dtMessage.Rows[0]["MSG_SEMI_PART_NOT_REG"].ToString();

                }

                //화면 설정 언어 & 명칭 변경.
                DataTable dtLanguage = new LanguageBusiness().Language_Info(_pWINDOW_NAME, _pLANGUAGE_TYPE);

                if (dtLanguage != null && dtLanguage.Rows.Count > 0)
                {
                    CoFAS_ControlManager.Language_Info(dtLanguage, this);
                }

                //그리드 설정
                InitializeGrid();

                //화면 컨트롤러 설정
                InitializeControl();

                //그리드 초기화 

                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                _pProductBOMRegister_T01Entity.CRUD = "R";
                MainFind_DisplayData();
                _pProductBOMRegister_T01Entity.CRUD = "";
                SubDetailFind_DisplayData();

                if (_pFirstYN)
                {
                    tmp_PRODUCTION_PART = new DataTable();
                    tmp_MATERIAL_PART = new DataTable();

                    tmp_PRODUCTION_PART = new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "PRODUCTION_BOM_PART", "", "", "").Tables[0];
                    tmp_MATERIAL_PART = new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "MATERIAL_BOM_PART", "", "", "").Tables[0];

                    _gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick;
                    _gdSUB_VIEW.InitNewRow += _gdSUB_VIEW_InitNewRow;
                    _gdSUB_VIEW.ShownEditor += _gdSUB_VIEW_ShownEditor;
                    _gdMAIN_VIEW.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(_gdMAIN_VIEW_RowChange);
                    _pFirstYN = false;
                }


                //컨트롤러 별 추가 이벤트 생성은 화면 설정 마지막에 진행
             
                //그리드 버튼추가 시 클릭 이벤트 처리 


                //설정 완료 후 신규 CRUD 코드  C 로변경;
                _pProductBOMRegister_T01Entity.CRUD = "C";


            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        

        #endregion

        #region ○ 버튼 초기화 하기 - InitializeButtons()

        private void InitializeButtons()
        {
            try
            {
                MainFormButtonSetting pButtonSetting = new MainFormButtonSetting();

                pButtonSetting.UseYNSearchButton = _pMenuSettingEntity.MENU_SEARCH == "Y" ? true : false; // 조회
                pButtonSetting.UseYNExportButton = _pMenuSettingEntity.MENU_EXPORT == "Y" ? true : false; // 내보내기
                pButtonSetting.UseYNImportButton = _pMenuSettingEntity.MENU_IMPORT == "Y" ? true : false; // 가져오기
                pButtonSetting.UseYNPrintButton = _pMenuSettingEntity.MENU_PRINT == "Y" ? true : false; // 프린터
                pButtonSetting.UseYNSaveButton = _pMenuSettingEntity.MENU_SAVE == "Y" ? true : false; // 저장
                pButtonSetting.UseYNAddItemButton = _pMenuSettingEntity.MENU_ADDITEM == "Y" ? true : false; // 신규
                pButtonSetting.UseYNDeleteButton = _pMenuSettingEntity.MENU_DELETE == "Y" ? true : false; // 삭제

                pButtonSetting.UseYNInitialButton = true; // 초기화
                if (_pUSER_GRANT == "PC160001")
                {
                    pButtonSetting.UseYNSettingButton = true; // 설정
                }
                else
                {
                    pButtonSetting.UseYNSettingButton = false; // 설정
                }
                
                pButtonSetting.UseYNFormCloseButton = true; // 폼닫기

                MainForm.SetButtonSetting(pButtonSetting);


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
                    _TempGridView = new CoFAS_DevGridManager();

                    _gdMAIN_VIEW = _TempGridView.Grid_Setting(_gdMAIN, _gdMAIN_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdMAIN.Name.ToString()));

                    _gdSUB_VIEW = _TempGridView.Grid_Setting(_gdSUB, _gdSUB_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdSUB.Name.ToString()));

                }

               
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
                _luT_USE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "USE_YN", "", "", "").Tables[0], 0, 1, "", true);
                _luUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "USE_YN", "", "", "").Tables[0], 0, 1, "", true);

                // 컨트롤러 유효성 검증 처리 기본 컨트롤러 에서만 사용 
                dxValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
                dxValidationProvider.Validate();

                //dxValidationProvider.SetValidationRule(_luGRID_NAME, NotEmptyValidationRule);
                //dxValidationProvider.SetValidationRule(_luGRIDVIEW_NAME, NotEmptyValidationRule);
                // 컨트롤러 유효성 검증 처리

                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                if (_pFirstYN)
                {
                }

                CreateDataTable(); //tree 저장 처리 데이터 테이블 만들기

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

        // 추가 이벤트 생성
        #region ○ 메인 그리드 신규로우 생성시 이벤트 생성 - _gdMAIN_VIEW_InitNewRow(object sender, InitNewRowEventArgs e)
        private void _gdSUB_VIEW_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            
            GridView view = sender as GridView;

            //if (_luPART_MST.CodeText.ToString().Length <= 0)
            //{
            //    view.ShowEditor();
            //    return;
            //}

            view.SetRowCellValue(e.RowHandle, view.Columns["LVL"], 1);
            view.SetRowCellValue(e.RowHandle, view.Columns["DSP_SORT"], 0);
            view.SetRowCellValue(e.RowHandle, view.Columns["P_PART_TYPE"], "1001");
            view.SetRowCellValue(e.RowHandle, view.Columns["P_PART_CODE"], _luPART_CODE.Text.ToString());
            view.SetRowCellValue(e.RowHandle, view.Columns["PART_TYPE"], "1003");
            view.SetRowCellValue(e.RowHandle, view.Columns["PART_CODE"], "");
            view.SetRowCellValue(e.RowHandle, view.Columns["PART_QTY"], 1);
            view.SetRowCellValue(e.RowHandle, view.Columns["USE_YN"], "Y");
        }
        #endregion
        #region ○ 메인 그리드 로우 선택 이벤트 생성 - _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        private void _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;

                _pProductBOMRegister_T01Entity.CRUD = "R";
                _pProductBOMRegister_T01Entity.PART_CODE = gv.GetFocusedRowCellValue("PART_CODE").ToString();
                _pProductBOMRegister_T01Entity.REVISION_NO = gv.GetFocusedRowCellValue("REVISION_NO").ToString();
                _pProductBOMRegister_T01Entity.USE_YN = gv.GetFocusedRowCellValue("USE_YN").ToString();
                _ckCOPY.Checked = false;
                SubFind_DisplayData();

                _pProductBOMRegister_T01Entity.CRUD = "U";

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion

        private void _gdSUB_VIEW_ShownEditor(object sender, EventArgs e)
        {
            try
            {
                if (_luPART_MST.CodeText.ToString().Length <= 0) return;

                ColumnView view = (ColumnView)sender;
                int qRowIndex = view.FocusedRowHandle;

                if (view.ActiveEditor.GetType().Name != "LookUpEdit") return;


                string strP_PART_TYPE = view.GetRowCellValue(qRowIndex, "P_PART_TYPE").ToString();
                string strP_PART_HIGH = view.GetRowCellValue(qRowIndex, "P_PART_HIGH").ToString();
                string strP_PART_MIDDLE = view.GetRowCellValue(qRowIndex, "P_PART_MIDDLE").ToString();
                string strP_PART_LOW = view.GetRowCellValue(qRowIndex, "P_PART_LOW").ToString();

                string strPART_TYPE = view.GetRowCellValue(qRowIndex, "PART_TYPE").ToString();
                string strPART_HIGH = view.GetRowCellValue(qRowIndex, "PART_HIGH").ToString();
                string strPART_MIDDLE = view.GetRowCellValue(qRowIndex, "PART_MIDDLE").ToString();
                string strPART_LOW = view.GetRowCellValue(qRowIndex, "PART_LOW").ToString();

                LookUpEdit edit = (LookUpEdit)view.ActiveEditor;

                DataTable empty_table = new DataTable();
                DataRow row = null;
                DataTable tmp = new DataTable();

                if (view.FocusedColumn.FieldName == "P_PART_CODE" && view.ActiveEditor is LookUpEdit)
                {
                    if (strP_PART_TYPE == "")
                    {
                        empty_table.Columns.Add(new DataColumn("CD", typeof(string)));
                        empty_table.Columns.Add(new DataColumn("CD_NM", typeof(string)));
                        empty_table.Columns.Add(new DataColumn("CD_TP", typeof(string)));
                        empty_table.Columns.Add(new DataColumn("CD_VALUE1", typeof(string)));
                        empty_table.Columns.Add(new DataColumn("CD_VALUE2", typeof(string)));
                        empty_table.Columns.Add(new DataColumn("CD_VALUE3", typeof(string)));
                        empty_table.Columns.Add(new DataColumn("CD_VALUE4", typeof(string)));

                        row = empty_table.NewRow();

                        row["CD"] = "";
                        row["CD_NM"] = "";
                        row["CD_TP"] = "";
                        row["CD_VALUE1"] = "";
                        row["CD_VALUE2"] = "";
                        row["CD_VALUE3"] = "";
                        row["CD_VALUE4"] = "";

                        empty_table.Rows.Add(row);
                        edit.Properties.DataSource = empty_table;
                        edit.Properties.DropDownRows = empty_table.Rows.Count;
                    }
                    else
                    {
                        if (tmp_PRODUCTION_PART.Select("CD_TP like'" + strP_PART_TYPE + "%' " + "AND CD_VALUE1 like'" + strP_PART_HIGH + "%' " + "AND CD_VALUE2 like'" + strP_PART_MIDDLE + "%' " + "AND CD_VALUE3 like'" + strP_PART_LOW + "%' ").Length == 0)
                        {
                            empty_table.Columns.Add(new DataColumn("CD", typeof(string)));
                            empty_table.Columns.Add(new DataColumn("CD_NM", typeof(string)));
                            empty_table.Columns.Add(new DataColumn("CD_TP", typeof(string)));
                            empty_table.Columns.Add(new DataColumn("CD_VALUE1", typeof(string)));
                            empty_table.Columns.Add(new DataColumn("CD_VALUE2", typeof(string)));
                            empty_table.Columns.Add(new DataColumn("CD_VALUE3", typeof(string)));
                            empty_table.Columns.Add(new DataColumn("CD_VALUE4", typeof(string)));

                            row = empty_table.NewRow();

                            row["CD"] = "";
                            row["CD_NM"] = "";
                            row["CD_TP"] = "";
                            row["CD_VALUE1"] = "";
                            row["CD_VALUE2"] = "";
                            row["CD_VALUE3"] = "";
                            row["CD_VALUE4"] = "";

                            empty_table.Rows.Add(row);
                            edit.Properties.DataSource = empty_table;
                            edit.Properties.DropDownRows = empty_table.Rows.Count;
                        }
                        else
                        {
                            tmp = tmp_PRODUCTION_PART.Select("CD_TP like'" + strP_PART_TYPE + "%' " + "AND CD_VALUE1 like'" + strP_PART_HIGH + "%' " + "AND CD_VALUE2 like'" + strP_PART_MIDDLE + "%' " + "AND CD_VALUE3 like'" + strP_PART_LOW + "%' ").CopyToDataTable();
                            edit.Properties.DataSource = tmp;
                            edit.Properties.DropDownRows = tmp.Rows.Count;
                            
                        }
                    }
                }

                if (view.FocusedColumn.FieldName == "PART_CODE" && view.ActiveEditor is LookUpEdit)
                {
                    if (strPART_TYPE == "")
                    {
                        empty_table.Columns.Add(new DataColumn("CD", typeof(string)));
                        empty_table.Columns.Add(new DataColumn("CD_NM", typeof(string)));
                        empty_table.Columns.Add(new DataColumn("CD_TP", typeof(string)));
                        empty_table.Columns.Add(new DataColumn("CD_VALUE1", typeof(string)));
                        empty_table.Columns.Add(new DataColumn("CD_VALUE2", typeof(string)));
                        empty_table.Columns.Add(new DataColumn("CD_VALUE3", typeof(string)));
                        empty_table.Columns.Add(new DataColumn("CD_VALUE4", typeof(string)));

                        row = empty_table.NewRow();

                        row["CD"] = "";
                        row["CD_NM"] = "";
                        row["CD_TP"] = "";
                        row["CD_VALUE1"] = "";
                        row["CD_VALUE2"] = "";
                        row["CD_VALUE3"] = "";
                        row["CD_VALUE4"] = "";

                        empty_table.Rows.Add(row);
                        edit.Properties.DataSource = empty_table;
                        edit.Properties.DropDownRows = empty_table.Rows.Count;
                    }
                    else
                    {
                        if (tmp_MATERIAL_PART.Select("CD_TP like'" + strPART_TYPE + "%' " + "AND CD_VALUE1 like'" + strPART_HIGH + "%' " + "AND CD_VALUE2 like'" + strPART_MIDDLE + "%' " + "AND CD_VALUE3 like'" + strPART_LOW + "%' ").Length == 0)
                        {
                            empty_table.Columns.Add(new DataColumn("CD", typeof(string)));
                            empty_table.Columns.Add(new DataColumn("CD_NM", typeof(string)));
                            empty_table.Columns.Add(new DataColumn("CD_TP", typeof(string)));
                            empty_table.Columns.Add(new DataColumn("CD_VALUE1", typeof(string)));
                            empty_table.Columns.Add(new DataColumn("CD_VALUE2", typeof(string)));
                            empty_table.Columns.Add(new DataColumn("CD_VALUE3", typeof(string)));
                            empty_table.Columns.Add(new DataColumn("CD_VALUE4", typeof(string)));

                            row = empty_table.NewRow();

                            row["CD"] = "";
                            row["CD_NM"] = "";
                            row["CD_TP"] = "";
                            row["CD_VALUE1"] = "";
                            row["CD_VALUE2"] = "";
                            row["CD_VALUE3"] = "";
                            row["CD_VALUE4"] = "";

                            empty_table.Rows.Add(row);
                            edit.Properties.DataSource = empty_table;
                            edit.Properties.DropDownRows = empty_table.Rows.Count;
                        }
                        else
                        {
                            tmp = tmp_MATERIAL_PART.Select("CD_TP like'" + strPART_TYPE + "%' " + "AND CD_VALUE1 like'" + strPART_HIGH + "%' " + "AND CD_VALUE2 like'" + strPART_MIDDLE + "%' " + "AND CD_VALUE3 like'" + strPART_LOW + "%' ").CopyToDataTable();
                            edit.Properties.DataSource = tmp;
                            edit.Properties.DropDownRows = tmp.Rows.Count;
                            //view.SetFocusedRowCellValue("PART_STANDARD", tmp.Rows[0]["CD_VALUE4"].ToString());
                        }
                    }
                }

                edit.Properties.ShowHeader = false;
                edit.Properties.ShowFooter = false;
                view.ShowEditor();
                view.GetFocusedDataRow().EndEdit();

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }


        // 메인 버튼 처리영역
        #region ○ 조회 버튼 클릭시 처리하기
        private void Form_SearchButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _pProductBOMRegister_T01Entity.CRUD = "R";
                _ckCOPY.Checked = false;

                MainFind_DisplayData();

                DisplayMessage(_pMSG_SEARCH);
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
        #endregion

        #region ○ 저장 버튼 클릭시 처리하기
        private void Form_SaveButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                if (_luPART_MST.CodeText.ToString().Length <= 0)
                {
                    return;
                }


                if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_SAVE_QUESTION) == DialogResult.No)
                    return;


                DataTable tempDT = _gdSUB_VIEW.GridControl.DataSource as DataTable;

                if (CheckInputData())
                {
                    DisplayMessage(_pMSG_CHECK_VALID_ITEM);
                    return;
                }

                //if (_luUSE_YN.GetValue() == "N")
                //{
                //    if (_luPART_MST.CodeText.ToString().Length > 0 && _luREVISION_NO.Text.ToString().Length > 0)
                //    {
                //        _pProductBOMRegisterEntity.CRUD = "E";
                //        _pProductBOMRegisterEntity.PART_CODE_MST = _luPART_MST.CodeText.ToString();
                //        _pProductBOMRegisterEntity.REVISION_NO = _luREVISION_NO.Text.ToString();

                //        BOMData_Delete_Save();
                //    }
                //    else
                //    {
                //        DisplayMessage(_pMSG_CHECK_VALID_ITEM);
                //    }
                //}
                //else
                //{
                    InputData_Save(tempDT);
                //}

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            catch (Exception pException)
            {
                DisplayMessage(string.Format("{0}", pException));
            }
            finally
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }
        #endregion

        #region ○ 신규 버튼 클릭시 처리하기
        private void Form_AddItemButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

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
        #endregion

        #region ○ 삭제 버튼 클릭시 처리하기
        private void Form_DeleteButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                //if (_luPART_MST.CodeText.ToString().Length > 0 && _luREVISION_NO.Text.ToString().Length > 0)
                //{
                //    _pProductBOMRegisterEntity.CRUD = "E";
                //    _pProductBOMRegisterEntity.PART_CODE_MST = _luPART_MST.CodeText.ToString();
                //    _pProductBOMRegisterEntity.REVISION_NO = _luREVISION_NO.Text.ToString();

                //    BOMData_Delete_Save();
                //}
                //else
                //{
                //    DisplayMessage(_pMSG_CHECK_VALID_ITEM);
                //}
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
        #endregion

        #region ○ 인쇄 버튼 클릭시 처리하기
        private void Form_PrintButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
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
        #endregion

        #region ○ 내보내기 버튼 클릭시 처리하기
        private void Form_ExportButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                //if (fpMain.ActiveSheet.RowCount > 0)
                //{
                //    SaveFileDialog mDlg = new SaveFileDialog();
                //    mDlg.InitialDirectory = Application.StartupPath;
                //    mDlg.Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*";
                //    mDlg.FilterIndex = 1;
                //    if (mDlg.ShowDialog() == DialogResult.OK)
                //    {
                //        fpMain.SaveExcel(mDlg.FileName, FarPoint.Excel.ExcelSaveFlags.SaveCustomColumnHeaders);
                //        DevExpressManager.ShowInformationMessage("저장이 완료 되었습니다.");
                //    }
                //}
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

        #endregion

        #region ○ 가져오기 버튼 클릭시 처리하기
        private void Form_ImportButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);


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
        #endregion

        #region ○ 초기화 버튼 클릭시 처리하기
        private void Form_InitialButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                _luT_PART_CODE.Text = "";
                _luT_PART_MST.CodeText = "";
                _luT_PART_MST.NameText = "";
                _luT_USE_YN.ItemIndex = 1;
                _luT_PART_HIGH.Text = "";
                _luT_PART_MIDDLE.Text = "";
                _luT_PART_LOW.Text = "";
                

                _luPART_MST.CodeText = "";
                _luPART_MST.NameText = "";

                _luREVISION_NO.Text = "";
                _luREVISION_NO.ReadOnly = false;

                _luUSE_YN.ItemIndex = 1;

                _luPART_CODE.Text = "";

                _dtBOMCheckList = null;

                _ckCOPY.Checked = false;

                _pProductBOMRegister_T01Entity.CRUD = "";
                _pProductBOMRegister_T01Entity.PART_CODE = "";
                _pProductBOMRegister_T01Entity.REVISION_NO = "";
                _pProductBOMRegister_T01Entity.USE_YN = "";
                SubDetailFind_DisplayData();

                _pProductBOMRegister_T01Entity.CRUD = "C";
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

        #endregion

        #region ○ 화면 설정 버튼 클릭시 처리하기 - 언어 및 화면 컨트롤러 명칭 변경 설정
        private void Form_SettingButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {

                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                CoFAS_MES.CORE.UserForm.frmPageSetting xfrmPageSetting = new CORE.UserForm.frmPageSetting();
                //xfrmPageSetting.PASS_CORP_CODE = _pCORP_CODE;
                xfrmPageSetting.PASS_PARENT_WINDOW_NAME = _pWINDOW_NAME;
                xfrmPageSetting.PASS_USER_CODE = _pUSER_CODE;
                xfrmPageSetting.PASS_PARENT_LANGUAGE = _pLANGUAGE_TYPE;
                xfrmPageSetting.PASS_PARENT_FONT = _pFONT_SETTING;
                xfrmPageSetting.ShowDialog();

                if (xfrmPageSetting.PASS_RESULT)
                {
                    InitializeSetting();

                    xfrmPageSetting.Dispose();
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

        #endregion

        #region ○ 닫기 버튼 클릭시 처리하기
        private void Form_FormCloseButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                Close(); //탭 화면 닫기
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        // DB 처리
        #region ○ 메인조회 - MainFind_DisplayData()

        private void MainFind_DisplayData() //int iRowIndex
        {
            try
            {

                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _pProductBOMRegister_T01Entity.PART_CODE = _luT_PART_CODE.Text.ToString();
                _pProductBOMRegister_T01Entity.PART_NAME = _luT_PART_MST.NameText.ToString();
                _pProductBOMRegister_T01Entity.VEND_PART_CODE = _luT_PART_MST.CodeText.ToString();
                _pProductBOMRegister_T01Entity.PART_HIGH = _luT_PART_HIGH.Text.ToString();
                _pProductBOMRegister_T01Entity.PART_MIDDLE = _luT_PART_MIDDLE.Text.ToString();
                _pProductBOMRegister_T01Entity.PART_LOW = _luT_PART_LOW.Text.ToString();
                _pProductBOMRegister_T01Entity.USE_YN = _luT_USE_YN.GetValue();

                _dtList = new ProductBOMRegister_T01Business().ProductBOMRegister_T01_Info_Left(_pProductBOMRegister_T01Entity);

                if (_pProductBOMRegister_T01Entity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pProductBOMRegister_T01Entity.CRUD == ""))
                {

                    _TempGridView.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList);

                }
                else
                {
                    _TempGridView.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList);

                    DisplayMessage(_pMSG_SEARCH_EMPT);
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {
                _gdMAIN_VIEW.BestFitColumns();

                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }

        #endregion
      
        #region ○ 서브조회 -  SubFind_DisplayData()

        private void SubFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _dtList = new ProductBOMRegister_T01Business().ProductBOMRegister_T01_Info_Mst(_pProductBOMRegister_T01Entity);

                if (_pProductBOMRegister_T01Entity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pProductBOMRegister_T01Entity.CRUD == ""))
                {
                    CoFAS_ControlManager.Controls_Binding(_dtList, false, this);

                    if (_luREVISION_NO.Text.ToString().Length > 0) _luREVISION_NO.ReadOnly = true;

                    SubDetailFind_DisplayData();
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
        #endregion

        #region ○ 서브 리스트조회 - SubDetailFind_DisplayData()
        private void SubDetailFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _dtList = new ProductBOMRegister_T01Business().ProductBOMRegister_T01_Info_Detail(_pProductBOMRegister_T01Entity);

                if (_pProductBOMRegister_T01Entity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pProductBOMRegister_T01Entity.CRUD == ""))
                {
                    _TempGridView.BindGridControl(_gdSUB, _gdSUB_VIEW, _dtList);
                }
                else
                {
                    _TempGridView.BindGridControl(_gdSUB, _gdSUB_VIEW, _dtList);

                    DisplayMessage(_pMSG_SEARCH_EMPT);
                }

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {
                _gdSUB_VIEW.BestFitColumns();

                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }

        #endregion


        #region ○ 저장 - InputData_Save(DataTable dtSave)

        private void InputData_Save(DataTable dtSave)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                string strMST = _luPART_CODE.Text.ToString();
                string strRev = _luREVISION_NO.Text.ToString().Length > 0 ? _luREVISION_NO.Text.ToString() : "1.0";
                string strQTY = _luPART_QTY.Value.ToString();
                string strYN = _luUSE_YN.GetValue();

                bool isError = false;
                ctDT.Clear();
                ctDR = null;

                DataRowADD(dtSave, strMST, strRev, strQTY, strYN);

                if (_ckCOPY.Checked)
                {
                    _pProductBOMRegister_T01Entity.CRUD = "C";
                }
                else
                {
                    _pProductBOMRegister_T01Entity.CRUD = "U";
                }

                _pProductBOMRegister_T01Entity.USE_YN = strYN;

                isError = new ProductBOMRegister_T01Business().ProductBOMRegister_T01_Info_Save(_pProductBOMRegister_T01Entity, ctDT);

                if (isError)
                {
                    //오류 발생.
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                    //화면 표시.
                }
                else
                {
                    //정상 처리
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);

                    // 화면 갱신
                    _pProductBOMRegister_T01Entity.CRUD = "R";
                    MainFind_DisplayData();

                    _pProductBOMRegister_T01Entity.PART_CODE = strMST;
                    _pProductBOMRegister_T01Entity.REVISION_NO = strRev;
                    _pProductBOMRegister_T01Entity.USE_YN = strYN;

                    SubFind_DisplayData();
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

        private void BOMData_Delete_Save()
        {
            try
            {
                //CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                //bool isError = false;

                //isError = new ProductBOMRegisterBusiness().ProductBOMRegister_Info_Enable(_pProductBOMRegisterEntity);

                //if (isError)
                //{
                //    //오류 발생.
                //    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_DELETE_ERROR);

                //}
                //else
                //{
                //    //정상 처리
                //    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_DELETE);

                //    // 화면 갱신
                //    _pProductBOMRegisterEntity.CRUD = "R";

                //    _pProductBOMRegisterEntity.PART_CODE = _luPART_CODE.Text;
                //    _pProductBOMRegisterEntity.PART_NAME = _luPART_NAME.Text;

                //    _pProductBOMRegisterEntity.USE_YN = _luT_USE_YN.GetValue();

                //    MainFind_DisplayData();

                //    treeList1.ClearNodes();

                //    _luREVISION_NO.Text = "";
                //    _luPART_MST.CodeText = "";
                //    _luPART_MST.NameText = "";
                //    _luUSE_YN.ItemIndex = 0;

                //    _ckCOPY.Checked = false;

                //    SubFind_DisplayData();

                //}

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {

                _pProductBOMRegister_T01Entity.PART_CODE_MST = "";
                _pProductBOMRegister_T01Entity.REVISION_NO = "";
                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }

        #endregion

        #region ○ 필수값 데이터 확인 - CheckInputData()

        /// <summary>
        /// 필수값 데이터 확인
        /// </summary>
        /// <returns>입력 데이터 조사 결과 (정상:false 에러:true)</returns>
        private bool CheckInputData()
        {
            bool pErrorYN = false;
            string pErrName = string.Empty;

            try
            {
                if (_luPART_MST.CodeText == "")
                    pErrName += _lciPART_MST.Text.ToString() + ". ";

                if (_luREVISION_NO.Text == "")
                    pErrName += _lciREVISION_NO.Text.ToString() + ". ";

                if (pErrName != "")
                {
                    pErrorYN = true;

                    CoFAS_DevExpressManager.ShowInformationMessage(pErrName + " " + _pMSG_CHECK_VALID_ITEM);

                    DisplayMessage(_pMSG_CHECK_VALID_ITEM);

                }
            }
            catch (Exception pException)
            {
                pErrorYN = true;
                CoFAS_DevExpressManager.ShowErrorMessage(pException);
            }
            return pErrorYN;
        }

        #endregion

        private void CreateDataTable()
        {
            ctDT.Columns.Add(new DataColumn("PART_CODE_MST", typeof(string)));
            ctDT.Columns.Add(new DataColumn("REVISION_NO", typeof(string)));

            ctDT.Columns.Add(new DataColumn("PART_CODE", typeof(string)));
            ctDT.Columns.Add(new DataColumn("P_PART_CODE", typeof(string)));
            ctDT.Columns.Add(new DataColumn("PART_QTY", typeof(decimal)));
            ctDT.Columns.Add(new DataColumn("NODE_LEVEL", typeof(int)));
            ctDT.Columns.Add(new DataColumn("NODE_ID", typeof(int)));

            ctDT.Columns.Add(new DataColumn("USE_YN", typeof(string)));
        }

        private void DataRowADD(DataTable dt, string strPART_CODE_MST, string strREVISION_NO, string strPART_QTY_MST, string strUSE_YN)
        {
            int iCnt = 0;

            ctDR = ctDT.NewRow();

            ctDR["PART_CODE_MST"] = strPART_CODE_MST;
            ctDR["REVISION_NO"] = strREVISION_NO;

            ctDR["PART_CODE"] = strPART_CODE_MST;
            ctDR["P_PART_CODE"] = strPART_CODE_MST;
            ctDR["PART_QTY"] = strPART_QTY_MST;
            ctDR["NODE_LEVEL"] = "0";
            ctDR["NODE_ID"] = "0";

            ctDR["USE_YN"] = strUSE_YN;

            ctDT.Rows.Add(ctDR);

            foreach (DataRow dr in dt.Rows)
            {
                ctDR = ctDT.NewRow();

                ctDR["PART_CODE_MST"] = strPART_CODE_MST;
                ctDR["REVISION_NO"] = strREVISION_NO;

                ctDR["PART_CODE"] = dr["PART_CODE"].ToString();
                ctDR["P_PART_CODE"] = dr["LVL"].ToString() == "1" ? strPART_CODE_MST: dr["P_PART_CODE"].ToString();
                ctDR["PART_QTY"] = dr["PART_QTY"].ToString();
                ctDR["NODE_LEVEL"] = dr["LVL"].ToString();
                ctDR["NODE_ID"] = iCnt = iCnt + 1; // node.Id;
                ctDR["USE_YN"] = dr["USE_YN"].ToString();

                ctDT.Rows.Add(ctDR);
            }
        }

        private void _luPART_CODE__OnOpenClick(object sender, EventArgs e)
        {
            try
            {
                //if (_ckCOPY.Checked)
                //{

                    frmCommonPopup.CRUD = "R";
                    frmCommonPopup.USER_CODE = _pUSER_CODE;
                    frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                    // 0 서비스네임 1 공통코드경우 CODE_TYPE 으로구분자 올린다.
                    frmCommonPopup.ARRAY = new object[2] { "", "" };
                    frmCommonPopup.ARRAY_CODE = new object[2] { _luPART_MST.CodeText.ToString(), _luPART_MST.NameText.ToString() };
                    frmCommonPopup xfrmCommonPopup = new frmCommonPopup("ucProductionPartListPopup");  // new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분

                    xfrmCommonPopup.ShowDialog();

                    if (xfrmCommonPopup.dtReturn == null)
                    {
                        xfrmCommonPopup.Dispose();
                        return;
                    }

                    if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                    {
                      _luPART_MST.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["VEND_PART_CODE"].ToString();
                      _luPART_MST.NameText = xfrmCommonPopup.dtReturn.Rows[0]["PART_NAME"].ToString();

                    _luPART_CODE.Text = xfrmCommonPopup.dtReturn.Rows[0]["PART_CODE"].ToString();

                    //treeList1.Nodes[0].SetValue(0, _luPART_MST.CodeText.ToString());
                    //treeList1.Nodes[0].SetValue(1, _luPART_MST.NameText.ToString());
                }

                    xfrmCommonPopup.Dispose();
                //}
                //else
                //{
                //    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_BOM_COPY_CHECK);
                //}
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        private void _ckCOPY_CheckedChanged(object sender, EventArgs e)
        {
            if (_ckCOPY.Checked)
            {
                if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_REVISION_INIT) == DialogResult.Yes)
                {
                    _luREVISION_NO.Text = "";
                    _luREVISION_NO.ReadOnly = false;
                }
                else
                {
                    _ckCOPY.Checked = false;
                }
            }
        }

        private void _luT_PART_MST__OnOpenClick(object sender, EventArgs e)
        {
            try
            {
                frmCommonPopup.CRUD = "R";
                frmCommonPopup.USER_CODE = _pUSER_CODE;
                frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                // 0 서비스네임 1 공통코드경우 CODE_TYPE 으로구분자 올린다.
                frmCommonPopup.ARRAY = new object[2] { "", "" };
                frmCommonPopup.ARRAY_CODE = new object[2] { _luT_PART_MST.CodeText.ToString(), _luT_PART_MST.NameText.ToString() };
                frmCommonPopup xfrmCommonPopup = new frmCommonPopup("ucProductionPartListPopup");  // new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분

                xfrmCommonPopup.ShowDialog();

                if (xfrmCommonPopup.dtReturn == null)
                {
                    xfrmCommonPopup.Dispose();
                    return;
                }

                if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                {
                    _luT_PART_MST.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["VEND_PART_CODE"].ToString();
                    _luT_PART_MST.NameText = xfrmCommonPopup.dtReturn.Rows[0]["PART_NAME"].ToString();

                    _luT_PART_CODE.Text = xfrmCommonPopup.dtReturn.Rows[0]["PART_CODE"].ToString();
                }

                xfrmCommonPopup.Dispose();
                //}
                //else
                //{
                //    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_BOM_COPY_CHECK);
                //}
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #region 키보드 이동

        private void _gdMAIN_VIEW_RowChange(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;
                if ((gv.DataSource as DataTable) == null) return;
                _pProductBOMRegister_T01Entity.CRUD = "R";
                _pProductBOMRegister_T01Entity.PART_CODE = gv.GetFocusedRowCellValue("PART_CODE").ToString();
                _pProductBOMRegister_T01Entity.REVISION_NO = gv.GetFocusedRowCellValue("REVISION_NO").ToString();
                _pProductBOMRegister_T01Entity.USE_YN = gv.GetFocusedRowCellValue("USE_YN").ToString();

                SubFind_DisplayData();

                _pProductBOMRegister_T01Entity.CRUD = "U";

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion
    }
}

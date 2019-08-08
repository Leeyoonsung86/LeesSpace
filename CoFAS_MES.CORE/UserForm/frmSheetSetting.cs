using CoFAS_MES.CORE.BaseForm;
using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.Entity;
using CoFAS_MES.CORE.Function;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using System.Net;
using System.IO;
using DevExpress.Spreadsheet;
using DevExpress.XtraGrid;
using static CoFAS_MES.CORE.BaseControls.ucSpreadSheetControl;

namespace CoFAS_MES.CORE.UserForm
{
    public partial class frmSheetSetting : frmBaseSingle
    {

        //private string strCORP_CODE = "";
        private string strUSER_CODE = "";
        private string strPARENT_WINDOW_NAME = "";
        private string strPARENT_LANGUAGE = "";
        private string strPARENT_USE_TYPE = ""; //삭제예정
        private Font fntPARENT_FONT = null;

        private string strPARENT_FTP_PATH = ""; //삭제예정
        private string strPARENT_FTP_ID = "";   //삭제예정
        private string strPARENT_FTP_PW = "";   //삭제예정

        private string _pWINDOW_NAME = "";

        private bool isRESULT = false;

        private WindowSheetSettingEntity _pWindowSheetSettingEntity = null; // 엔티티 생성

        private DataTable _dtList = null; //조회 데이터 리스트

        private bool _pFirstYN = true; // 최초실행여부 최초 설정 에서만 사용

        //// 코에버 frp 관련 변수
        //private string _pFileName = "";        //local 파일이름   //ofd로 받아서 넣기 safe~
        //private string _pFullName = "";        //localfile 파일명 포함 전체 경로        

        //public string PASS_CORP_CODE
        //{
        //    get { return this.strCORP_CODE; }
        //    set { this.strCORP_CODE = value; }
        //}
        public string PASS_USER_CODE
        {
            get { return this.strUSER_CODE; }
            set { this.strUSER_CODE = value; }
        }
        public string PASS_PARENT_WINDOW_NAME
        {
            get { return this.strPARENT_WINDOW_NAME; }
            set { this.strPARENT_WINDOW_NAME = value; }
        }
        public string PASS_PARENT_USE_TYPE    
        {
            get { return this.strPARENT_USE_TYPE; }
            set { this.strPARENT_USE_TYPE = value; }
        }
        public string PASS_PARENT_LANGUAGE
        {
            get { return this.strPARENT_LANGUAGE; }
            set { this.strPARENT_LANGUAGE = value; }
        }
        public Font PASS_PARENT_FONT
        {
            get { return this.fntPARENT_FONT; }
            set { this.fntPARENT_FONT = value; }
        }

        public string PASS_PARENT_FTP_PATH
        {
            get { return this.strPARENT_FTP_PATH; }
            set { this.strPARENT_FTP_PATH = value; }
        }

        public string PASS_PARENT_FTP_ID
        {
            get { return this.strPARENT_FTP_ID; }
            set { this.strPARENT_FTP_ID = value; }
        }

        public string PASS_PARENT_FTP_PW
        {
            get { return this.strPARENT_FTP_PW; }
            set { this.strPARENT_FTP_PW = value; }
        }



        public bool PASS_RESULT
        {
            get { return this.isRESULT; }
            set { this.isRESULT = value; }
        }



        public frmSheetSetting()
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
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
            }
        }
        #endregion


        #region ○ Form_Closing

        private void Form_Closing(object pSender, FormClosingEventArgs pFormClosingEventArgs)
        {
            try
            {
                ////그리드 작업 정보 확인 하기
                //if ((_gdMAIN_VIEW.GridControl != null && CoFAS_ConvertManager.DataTable_FindCount(_gdMAIN_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", "")) ||
                //    (_gdSUB_DETAIL_VIEW.GridControl != null && CoFAS_ConvertManager.DataTable_FindCount(_gdSUB_DETAIL_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", "")))
                //{
                //    if (CoFAS_DevExpressManager.ShowQuestionMessage("작업중인 자료가 있습니다.\n종료 하겠습니까?") == DialogResult.No)
                //    {
                //        pFormClosingEventArgs.Cancel = true;
                //        return;
                //    }
                //}
                pFormClosingEventArgs.Cancel = false;
                isRESULT = true;
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
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
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
            }
        }

        #endregion
        #region ○ Form_Load
        private void Form_Load(object pSender, EventArgs pEventArgs)
        {
            try
            {
                WindowName = strPARENT_WINDOW_NAME;

                InitializeSetting();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
            }
            finally
            {
                DevExpress.Utils.AppearanceObject.DefaultFont = fntPARENT_FONT;//화면에 모든 항목 폰트 재설정
            }
        }
        #endregion

        // 초기화 처리 영역
        #region ○ 메뉴 초기화 하기 - InitializeSetting()

        private void InitializeSetting()
        {
            try
            {
                //상속 화면 패널 사용 유무

                //메인 화면 전역 변수 처리
                _pWINDOW_NAME = this.Name;

                //메뉴 화면 엔티티 설정
                _pWindowSheetSettingEntity = new WindowSheetSettingEntity();
                //_pWindowSheetSettingEntity.CORP_CODE = strCORP_CODE;
                _pWindowSheetSettingEntity.USER_CODE = strUSER_CODE;
                _pWindowSheetSettingEntity.WINDOW_NAME = strPARENT_WINDOW_NAME;
                _pWindowSheetSettingEntity.LANGUAGE_TYPE = strPARENT_LANGUAGE;

                //화면 설정 언어 & 명칭 변경.
                DataTable dtLanguage = new LanguageBusiness().Language_Info(_pWINDOW_NAME, strPARENT_LANGUAGE);

                if (dtLanguage != null && dtLanguage.Rows.Count > 0)
                {
                    CoFAS_ControlManager.Language_Info(dtLanguage, this);
                }

                //메인 화면 공용 버튼 설정

                //그리드 설정
                InitializeGrid();

                //화면 컨트롤러 설정
                InitializeControl();

              //  SheetMainFind_DisplayData();

              //  _gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick;

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
            }
        }

        #endregion

        #region ○ 그리드 초기화 하기 - InitializeGrid()
        private void InitializeGrid()
        {
            try
            {
                if (_pFirstYN)
                {
                    _gdMAIN_VIEW = Grid_Setting(_gdMAIN, _gdMAIN_VIEW, "_gdMAIN", strPARENT_LANGUAGE);
                }

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
            }
        }

        private GridView Grid_Setting(GridControl _gd, GridView _gv, string strGD_NAME, string strLANGUAGE)
        {
            // 메인 그리드 설정
            DataSet dsGridSetting = null;
            Font fntHeader = new Font(fntPARENT_FONT.FontFamily, fntPARENT_FONT.Size + 2, FontStyle.Bold);
            Font fntRow = fntPARENT_FONT;
            //CoFAS_DevExpressManager.pCORP_CODE = strCORP_CODE;

            GridControl _Grid_Control = _gd;
            GridView _Grid_View = _gv;

            dsGridSetting = new DevGridSettingBusiness().DevGrid_Info(strLANGUAGE, _pWINDOW_NAME, strGD_NAME); //그리드 설정 조회

            _Grid_Control.ForceInitialize();

            if (dsGridSetting != null && dsGridSetting.Tables.Count > 0 && dsGridSetting.Tables[0].Rows.Count > 0)
            {
                CoFAS_DevExpressManager.SetGridControl(_Grid_Control, dsGridSetting.Tables[0].Rows[0]["GRID_NAME"].ToString(), false); //조회 데이터 기준 그리드 컨트롤러 설정

                _Grid_View = CoFAS_DevExpressManager.GetGridSetting(dsGridSetting, fntHeader, fntRow, strLANGUAGE); // 그리드 뷰 and 컬럼 설정

                CoFAS_DevExpressManager.AddView(_Grid_Control, _Grid_View, true); // 그리드 컨트롤러 에 메인 뷰 설정

                _Grid_View.BestFitColumns();
            }

            new CoFAS_DevGridEventManager(_Grid_Control, "");

            return _Grid_View;
        }


        #endregion

        #region ○ 컨트롤 초기화 - InitializeControl()

        private void InitializeControl()
        {
            try
            {
                //조회조건 영역 

                //데이터 영역

                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화

             //   _gdMAIN.DataSource = null;

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
            }
            finally
            {

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

                CoFAS_ControlManager.Controls_Binding(gv, false, this);

                //FTP에서 파일명에 맞는 엑셀 파일 가져오기

                string strFILE_NAME = "";

                strFILE_NAME = gv.GetFocusedRowCellValue("FILE_NAME").ToString();   //추가
                PASS_PARENT_USE_TYPE = gv.GetFocusedRowCellValue("USE_TYPE").ToString();

                switch (PASS_PARENT_USE_TYPE)
                {
                    case "PRINT":
                        strPARENT_FTP_PATH = string.Format(@"{0}{1}/", PASS_PARENT_FTP_PATH, "ORDER_FORM");
                        break;
                    case "VIEW":
                        strPARENT_FTP_PATH = string.Format(@"{0}{1}/", PASS_PARENT_FTP_PATH, "PROGRAM_VIEW");
                        break;
                }

                using (Stream responseStream = CoFAS_FTPManager.FTPFileBinding(strPARENT_FTP_PATH, strFILE_NAME, PASS_PARENT_FTP_ID, PASS_PARENT_FTP_PW))
                {
                    if (responseStream != null)
                    {
                        _sdMAIN.LoadDocument(responseStream, enFileFormat.Xlsx);
                    }
                    else
                    {
                        _sdMAIN.ClearSheet();
                    }
                }


            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
            }
        }
        #endregion

        #region ○ FTP 파일 바인딩   //추가
        //private void FTPFileBinding(string qFTP_Path, string qFileName, string qFTP_ID, string qFTP_PW)  //추가
        //{
        //    try
        //    {
        //        CoFAS_FTPUtilManager qFTPUtil = new CoFAS_FTPUtilManager(qFTP_Path, qFTP_ID, qFTP_PW);
        //        if (qFTPUtil.IsFTPFileExsit(qFTP_Path + qFileName))
        //        {

        //            FtpWebRequest requestFileDownload = (FtpWebRequest)WebRequest.Create("ftp://" + qFTP_Path + qFileName);
        //            requestFileDownload.Credentials = new NetworkCredential(qFTP_ID, qFTP_PW);
        //            requestFileDownload.Method = WebRequestMethods.Ftp.DownloadFile;

        //            FtpWebResponse responseFileDownload = (FtpWebResponse)requestFileDownload.GetResponse();

        //            Stream responseStream = responseFileDownload.GetResponseStream();

        //            _sdMAIN.LoadDocument(responseStream, enFileFormat.Xls);

        //            responseStream.Close();
        //        }
        //        else
        //        {
        //            CoFAS_DevExpressManager.ShowErrorMessage("FTP서버에 저장되지 않은 파일입니다. 저장을 먼저 해주세요.");
        //            _sdMAIN.ClearSheet();
        //        }
        //    }
        //    catch (ExceptionManager pExceptionManager)
        //    {
        //        CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
        //    }
        //}
        #endregion

        #region ○ FTP 업로드 _ SpreadSheetControl에 올라온 것 업로드     //추가   수정        
        //private void FTPUpload_SpreadSheetControl(string pFileName, string qFTP_ID, string qFTP_PW, string qFTP_Path)    //추가
        //{                                        //파일이름        //-ftp://를 제외한ftp 폴더 경로    //ftp ID        //ftp 비번    
        //    try
        //    {
        //        FtpWebRequest requestFTPUploader = (FtpWebRequest)WebRequest.Create("ftp://" + qFTP_Path + pFileName);
        //        requestFTPUploader.Credentials = new NetworkCredential(qFTP_ID, qFTP_PW);
        //        requestFTPUploader.Method = WebRequestMethods.Ftp.UploadFile;

        //        byte[] data = _sdMAIN.SaveDocument(enFileFormat.Xls);

        //        requestFTPUploader.ContentLength = data.Length;
        //        using (Stream reqStream = requestFTPUploader.GetRequestStream())
        //        {
        //            reqStream.Write(data, 0, data.Length);
        //        }

        //        using (FtpWebResponse resp = (FtpWebResponse)requestFTPUploader.GetResponse())
        //        {
        //            Console.WriteLine("Upload: {0}", resp.StatusDescription);
        //        }

        //    }
        //    catch (Exception pException)
        //    {
        //        return;
        //    }
        //}
        #endregion

        private void _btSEARCH_SHEET_Click(object sender, EventArgs e)   //추가
        {
            SheetMainFind_DisplayData();
        }
        private void _btSAVE_SHEET_Click(object sender, EventArgs e)    //추가
        {
            try
            {
                GridView gv = sender as GridView;

                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                string strFTP_PATH = "";
                string strFILE_NAME = "";

                if (strFILE_NAME == "")
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("저장할 엑셀 항목이 없습니다.");
                }
                else
                {
                    switch (gv.GetFocusedRowCellValue("USE_TYPE").ToString())
                    {
                        case "PRINT":
                            strFTP_PATH = string.Format(@"{0}{1}/", strPARENT_FTP_PATH, "ORDER_FORM");
                            break;
                        case "VIEW":
                            strFTP_PATH = string.Format(@"{0}{1}/", strPARENT_FTP_PATH, "PROGRAM_VIEW");
                            break;
                    }

                    byte[] data = _sdMAIN.SaveDocument(enFileFormat.Xlsx);  //uc 기능확인 필요
                    CoFAS_FTPManager.FTPUpload_CheckDFile(strFILE_NAME, strPARENT_FTP_ID, strPARENT_FTP_PW, strFTP_PATH, data);

                    CoFAS_DevExpressManager.ShowInformationMessage("저장되었습니다.");
                }


            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
            }
            finally
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }
        private void _btCLOSE_Click(object sender, EventArgs e)
        {
            //그리드 작업 정보 확인 하기
            //if ((_gdMAIN_VIEW.GridControl != null && CoFAS_ConvertManager.DataTable_FindCount(_gdMAIN_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", "")) ||
            //    (_gdSUB_DETAIL_VIEW.GridControl != null && CoFAS_ConvertManager.DataTable_FindCount(_gdSUB_DETAIL_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", "")))
            //{
            //    if (CoFAS_DevExpressManager.ShowQuestionMessage("작업중인 자료가 있습니다.\n종료 하겠습니까?") == DialogResult.No)
            //    {
            //        return;
            //    }
            //}

            //isRESULT = true;

            Close();
        }


        // DB 처리
        #region ○ 화면에 따른 시트 조회 - SheetMainFind_DisplayData()

        private void SheetMainFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _dtList = new WindowSheetSettingBusiness().SheetMainFind_DisplayData(_pWindowSheetSettingEntity);

                if (_pWindowSheetSettingEntity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pWindowSheetSettingEntity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList);
                }
                else
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));

                //throw pExceptionManager;

            }
            //catch (Exception pException)
            //{
            //    throw new ExceptionManager(this, "InputData_Save(DataTable dtSave)", pException);
            //}
            finally
            {
                _gdMAIN_VIEW.BestFitColumns();

                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }

        #endregion


        #region ○ 저장 - Sheet_InputData_Save(DataTable dtSave) (사용X)
        private void Sheet_InputData_Save(DataTable dtSave)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                bool isError = false;

                //isError = new WindowPageSettingBusiness().Controls_Info_Save(_pWindowSheetSettingEntity, dtSave);

                //if (isError)
                //{
                //    //오류 발생.
                //    CoFAS_DevExpressManager.ShowInformationMessage("저장 오류 발생! 데이터를 확인 하세요.");
                //    //화면 표시.

                //}
                //else
                //{
                //    //정상 처리
                //    CoFAS_DevExpressManager.ShowInformationMessage("저장 처리 되었습니다.");

                //    _pWindowSheetSettingEntity.CRUD = "R";
                //    //ControlMainFind_DisplayData();
                //}
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
            }
            finally
            {

                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }

        #endregion

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CoFAS_MES.CORE.Function;

using DevExpress.XtraSpreadsheet;
using DevExpress.Spreadsheet;
using System.IO;

namespace CoFAS_MES.CORE.BaseControls
{
    public delegate void SheetCelllClick();

    public partial class ucSpreadSheetControl : UserControl
    {
        #region Event

        /// <summary>
        /// 시트 셀 클릭시 
        /// </summary>
        public event SheetCelllClick SpreadSheetCellClick;
        
        #endregion

        /// <summary>
        /// 선택 된 셀 위치 값 GET / SET
        /// </summary>
        public string CellValue
        {
            get
            {
                return _pSpreadSheetNameBoxControl.Text.ToString();
            }
            set
            {
                _pSpreadSheetNameBoxControl.Text = value;
            }
        }


        public IWorkbook Document
        {
            get
            {
                return _pSpreadSheetControl.Document;
            }
        }

        /// <summary>
        /// 스프레드 컨트롤러 상단 네임박스 및 수식지정 컨트롤러 숨기기
        /// </summary>
        public bool TopControlVisible
        {
            get
            {
                return _pTopControl.Visible;
            }
            set
            {
                _pTopControl.Visible = value;
            }
        }

        public DevExpress.Utils.DefaultBoolean NameBoxReadOnly
        {
            get
            {
                return _pSpreadSheetNameBoxControl.ReadOnly;
            }
            set
            {
                _pSpreadSheetNameBoxControl.ReadOnly = value;
            }
        }

        public bool ReadOnly
        {
            get
            {
                return _pSpreadSheetControl.ReadOnly;
            }
            set
            {
                _pSpreadSheetControl.ReadOnly = value;
            }
        }

        public ucSpreadSheetControl()
        {
            InitializeComponent();
            Initialize();

        }

        #region 초기화 하기 - Initialize()

        /// <summary>
        /// 초기화 하기
        /// </summary>
        protected virtual void Initialize()
        {
            try
            {
                _pSpreadSheetControl.AllowDrop = true;

                //_pSpreadSheetControl.Document.Worksheets["Sheet1"].Name = "DATA";
                //_pSpreadSheetControl.Document.Worksheets.Add("VIEW");

                _pSpreadSheetControl.Click += _pSpreadSheetControl_Click;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "Initialize()",
                    pException
                );
            }
        }
        #endregion

        #region 스프레드 셀 클릭시 이벤트 발생시키기 - RaiseExitButtonClickedEvent()

        private void _pSpreadSheetControl_Click(object sender, EventArgs e)
        {
            if (SpreadSheetCellClick != null)
            {
                SpreadSheetCellClick();
            }
        }
        #endregion

        public void ClearSheet()
        {
            _pSpreadSheetControl.CloseCellEditor(CellEditorEnterValueMode.Default);
            _pSpreadSheetControl.CreateNewDocument();
            //_pSpreadSheetControl.Document.Worksheets["DATA"].Visible = true;
        }

        /// <summary>
        /// 출력 미리보기 창 표시
        /// </summary>
        public void ShowPrintPeview()
        {
            _pSpreadSheetControl.ShowPrintPreview();
        }

        /// <summary>
        /// 스프레드 시트 파일 포멧 형식 지정 열거형
        /// </summary>
        public enum enFileFormat
        {
            Csv,
            OpenXml,
            Text,
            Xls,
            Xlsm,
            Xlsx,
            Xlt,
            Xltm,
            Xltx,
            Undefined
        };

        /// <summary>
        /// 스프레드 시트에 파일 로드
        /// </summary>
        /// <param name="byA"></param>
        /// <param name="_enFileFormat"></param>
        public void LoadDocument(byte[] byFile, enFileFormat _enFileFormat)
        {
            DocumentFormat df = new DocumentFormat();

            switch(_enFileFormat)
            {
                case enFileFormat.Csv:
                    df = DocumentFormat.Csv;
                    break;
                case enFileFormat.OpenXml:
                    df = DocumentFormat.OpenXml;
                    break;
                case enFileFormat.Text:
                    df = DocumentFormat.Text;
                    break;
                case enFileFormat.Xls:
                    df = DocumentFormat.Xls;
                    break;
                case enFileFormat.Xlsm:
                    df = DocumentFormat.Xlsm;
                    break;
                case enFileFormat.Xlsx:
                    df = DocumentFormat.Xlsx;
                    break;
                case enFileFormat.Xlt:
                    df = DocumentFormat.Xlt;
                    break;
                case enFileFormat.Xltm:
                    df = DocumentFormat.Xltm;
                    break;
                case enFileFormat.Xltx:
                    df = DocumentFormat.Xltx;
                    break;
                case enFileFormat.Undefined:
                    df = DocumentFormat.Undefined;
                    break;
            }

            _pSpreadSheetControl.LoadDocument(byFile, df);
        }

        /// <summary>
        /// 스프레드 시트에 파일 로드
        /// </summary>
        /// <param name="byA"></param>
        /// <param name="_enFileFormat"></param>
        public void LoadDocument(Stream _pStream, enFileFormat _enFileFormat)   // 추가
        {
            DocumentFormat df = new DocumentFormat();

            switch (_enFileFormat)
            {
                case enFileFormat.Csv:
                    df = DocumentFormat.Csv;
                    break;
                case enFileFormat.OpenXml:
                    df = DocumentFormat.OpenXml;
                    break;
                case enFileFormat.Text:
                    df = DocumentFormat.Text;
                    break;
                case enFileFormat.Xls:
                    df = DocumentFormat.Xls;
                    break;
                case enFileFormat.Xlsm:
                    df = DocumentFormat.Xlsm;
                    break;
                case enFileFormat.Xlsx:
                    df = DocumentFormat.Xlsx;
                    break;
                case enFileFormat.Xlt:
                    df = DocumentFormat.Xlt;
                    break;
                case enFileFormat.Xltm:
                    df = DocumentFormat.Xltm;
                    break;
                case enFileFormat.Xltx:
                    df = DocumentFormat.Xltx;
                    break;
                case enFileFormat.Undefined:
                    df = DocumentFormat.Undefined;
                    break;
            }

            _pSpreadSheetControl.LoadDocument(_pStream, df);
        }

        public byte[] SaveDocument(enFileFormat _enFileFormat)
        {
            byte[] btDocument = null;

            DocumentFormat df = new DocumentFormat();

            switch (_enFileFormat)
            {
                case enFileFormat.Csv:
                    df = DocumentFormat.Csv;
                    break;
                case enFileFormat.OpenXml:
                    df = DocumentFormat.OpenXml;
                    break;
                case enFileFormat.Text:
                    df = DocumentFormat.Text;
                    break;
                case enFileFormat.Xls:
                    df = DocumentFormat.Xls;
                    break;
                case enFileFormat.Xlsm:
                    df = DocumentFormat.Xlsm;
                    break;
                case enFileFormat.Xlsx:
                    df = DocumentFormat.Xlsx;
                    break;
                case enFileFormat.Xlt:
                    df = DocumentFormat.Xlt;
                    break;
                case enFileFormat.Xltm:
                    df = DocumentFormat.Xltm;
                    break;
                case enFileFormat.Xltx:
                    df = DocumentFormat.Xltx;
                    break;
                case enFileFormat.Undefined:
                    df = DocumentFormat.Undefined;
                    break;
            }

            btDocument = _pSpreadSheetControl.SaveDocument(df);

            return btDocument;

        }

        /// <summary>
        /// 출력 헤더 지정
        /// </summary>
        /// <param name="strSheetName">시트명칭</param>
        /// <param name="startRow"> 시작 줄수</param>
        /// <param name="endRow"> 종료 줄수</param>
        public void SetPrintTitle(string strSheetName, int startRow, int endRow)
        {
            IWorkbook workbook = _pSpreadSheetControl.Document;

            Worksheet sheet = workbook.Worksheets[strSheetName];

            WorksheetPrintOptions printOptions = sheet.PrintOptions;

            printOptions.PrintTitles.SetRows(startRow, endRow);
        }
    }
}

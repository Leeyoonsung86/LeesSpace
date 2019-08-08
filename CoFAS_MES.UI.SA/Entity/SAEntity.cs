using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoFAS_MES.UI.SA.Entity
{
    public class LanguageInfoRegisterEntity
    {
        #region Property

        //사용자 설정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD

        public String CODE_TYPE { get; set; } // 컨트롤러 타입 구분
        public String LANGUAGE_TYPE { get; set; } //언어구분
        public String WINDOW_NAME { get; set; } // 화면 아이디
        public String FIELD_CODE { get; set; } // 필드 아이디
        public String FIELD_NAME { get; set; } // 필드 명칭
        public String FIELD_DESC { get; set; } // 필드 설명
        public String REMARK { get; set; } // 비고
        public String USE_YN { get; set; } // 사용유무


        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }


        #endregion

        #region 생성자 - LanguageInfoRegisterEntity()

        public LanguageInfoRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - LanguageInfoRegisterEntity(pLanguageInfoRegisterEntity)

        public LanguageInfoRegisterEntity(LanguageInfoRegisterEntity pLanguageInfoRegisterEntity)
        {
            CORP_CODE = pLanguageInfoRegisterEntity.CORP_CODE;
            CRUD = pLanguageInfoRegisterEntity.CRUD;
            USER_CODE = pLanguageInfoRegisterEntity.USER_CODE;

            CODE_TYPE = pLanguageInfoRegisterEntity.CODE_TYPE;
            LANGUAGE_TYPE = pLanguageInfoRegisterEntity.LANGUAGE_TYPE;
            WINDOW_NAME = pLanguageInfoRegisterEntity.WINDOW_NAME;
            FIELD_CODE = pLanguageInfoRegisterEntity.FIELD_CODE;
            FIELD_NAME = pLanguageInfoRegisterEntity.FIELD_NAME;
            FIELD_DESC = pLanguageInfoRegisterEntity.FIELD_DESC;
            REMARK = pLanguageInfoRegisterEntity.REMARK;
            USE_YN = pLanguageInfoRegisterEntity.USE_YN;

            ERR_NO = pLanguageInfoRegisterEntity.ERR_NO;
            ERR_MSG = pLanguageInfoRegisterEntity.ERR_MSG;
            RTN_KEY = pLanguageInfoRegisterEntity.RTN_KEY;
            RTN_SEQ = pLanguageInfoRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pLanguageInfoRegisterEntity.RTN_OTHERS;
        }

        #endregion

    }

    public class MessageInfoRegisterEntity
    {
        #region Property

        //사용자 설정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD

        public String LANGUAGE_TYPE { get; set; } //언어구분
        public String WINDOW_NAME { get; set; }
        public String MESSAGE_TYPE { get; set; }
        public String MESSAGE_CODE { get; set; } // 메세지 코드
        public String MESSAGE_VALUE { get; set; } // 메세지 값
        public String REMARK { get; set; } // 비고
        public String USE_YN { get; set; } // 사용유무


        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }


        #endregion

        #region 생성자 - MessageInfoRegisterEntity()

        public MessageInfoRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - MessageInfoRegisterEntity(pMessageInfoRegisterEntity)

        public MessageInfoRegisterEntity(MessageInfoRegisterEntity pMessageInfoRegisterEntity)
        {
            CORP_CODE = pMessageInfoRegisterEntity.CORP_CODE;
            CRUD = pMessageInfoRegisterEntity.CRUD;
            USER_CODE = pMessageInfoRegisterEntity.USER_CODE;

            LANGUAGE_TYPE = pMessageInfoRegisterEntity.LANGUAGE_TYPE;
            WINDOW_NAME = pMessageInfoRegisterEntity.WINDOW_NAME;
            MESSAGE_TYPE = pMessageInfoRegisterEntity.MESSAGE_TYPE;

            MESSAGE_CODE = pMessageInfoRegisterEntity.MESSAGE_CODE;
            MESSAGE_VALUE = pMessageInfoRegisterEntity.MESSAGE_VALUE;
            REMARK = pMessageInfoRegisterEntity.REMARK;
            USE_YN = pMessageInfoRegisterEntity.USE_YN;

            ERR_NO = pMessageInfoRegisterEntity.ERR_NO;
            ERR_MSG = pMessageInfoRegisterEntity.ERR_MSG;
            RTN_KEY = pMessageInfoRegisterEntity.RTN_KEY;
            RTN_SEQ = pMessageInfoRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pMessageInfoRegisterEntity.RTN_OTHERS;
        }

        #endregion

    }

    public class GridInfoRegisterEntity
    {
        #region Property

        //사용자 설정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD

        //마스터
        public String WINDOW_NAME { get; set; }
        public String GRID_NAME { get; set; }
        public String GRIDVIEW_NAME { get; set; }
        public String LANGUAGE_TYPE { get; set; } // 언어 정보 값

        public String EDIT_ABLE { get; set; }
        public String EDITOR_SHOWMODE { get; set; }
        public String READ_ONLY { get; set; }
        public String ALLOW_COLUMN_MOVING { get; set; }
        public String ALLOW_COLUMN_RESIZING { get; set; }
        public String ALLOW_FILTER { get; set; }
        public String ALLOW_SORT { get; set; }
        public String ENABLE_COLUMN_MENU { get; set; }
        public String MULTI_SELECT { get; set; }
        public String GRIDMULTI_SELECTMODE { get; set; }
        public String SHOWCHECKBOXSELECTOR_INCOLUMNHEADER { get; set; }
        public String COLUMN_AUTOWIDTH { get; set; }
        public String ENABLE_APPEARANCE_EVENROW { get; set; }
        public String ENABLE_APPEARANCE_ODDROW { get; set; }
        public String SHOW_GROUPPANEL { get; set; }
        public String SHOW_INDICATOR { get; set; }
        public String SHOW_AUTOFILTERROW { get; set; }
        public String SHOW_FOOTER { get; set; }
        public String GRID_NEWITEMROWPOSITION { get; set; }
        public String GRID_NEWITEMROWNAME { get; set; }
        public String REMARK { get; set; }
        public String USE_YN { get; set; }
        public String ALLOW_DROP { get; set; }


        //상세
        public String COLUMN_NAME { get; set; }
        public String COLUMN_SEQ { get; set; }
        public String COLUMN_CAPTION { get; set; }
        public String COLUMN_CAPTION_COLOR { get; set; }
        public String COLUMN_FIELD_NAME { get; set; }
        public String COLUMN_SIZE { get; set; }
        public String COLUMN_TYPE { get; set; }
        public String TEXT_SIZE { get; set; }
        public String PARAMETER_DATA { get; set; }
        public String UNBOUND_COLUMNTYPE { get; set; }
        public String HORZ_ALIGNMENT { get; set; }
        public String ALLOW_EDIT { get; set; }
        public String ALLOW_FOCUS { get; set; }
        public String ALLOW_MERGE { get; set; }
        public String FORMAT_TYPE { get; set; }
        public String FORMAT_STRING { get; set; }
        public String SHOWUNBOUND_EXPRESSIONMENU { get; set; }
        public String VISIBLE_INDEX { get; set; }
        public String VISIBLE { get; set; }


        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }

        #endregion

        #region 생성자 - GridInfoRegisterEntity()

        public GridInfoRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - GridInfoRegisterEntity(pGridInfoRegisterEntity)

        public GridInfoRegisterEntity(GridInfoRegisterEntity pGridInfoRegisterEntity)
        {
            CORP_CODE = pGridInfoRegisterEntity.CORP_CODE;
            CRUD = pGridInfoRegisterEntity.CRUD;
            USER_CODE = pGridInfoRegisterEntity.USER_CODE;

            //마스터
            WINDOW_NAME = pGridInfoRegisterEntity.WINDOW_NAME;
            GRID_NAME = pGridInfoRegisterEntity.GRID_NAME;
            GRIDVIEW_NAME = pGridInfoRegisterEntity.GRIDVIEW_NAME;

            EDIT_ABLE = pGridInfoRegisterEntity.EDIT_ABLE;
            EDITOR_SHOWMODE = pGridInfoRegisterEntity.EDITOR_SHOWMODE;
            READ_ONLY = pGridInfoRegisterEntity.READ_ONLY;
            ALLOW_COLUMN_MOVING = pGridInfoRegisterEntity.ALLOW_COLUMN_MOVING;
            ALLOW_COLUMN_RESIZING = pGridInfoRegisterEntity.ALLOW_COLUMN_RESIZING;
            ALLOW_FILTER = pGridInfoRegisterEntity.ALLOW_FILTER;
            ALLOW_SORT = pGridInfoRegisterEntity.ALLOW_SORT;
            MULTI_SELECT = pGridInfoRegisterEntity.MULTI_SELECT;
            GRIDMULTI_SELECTMODE = pGridInfoRegisterEntity.GRIDMULTI_SELECTMODE;
            SHOWCHECKBOXSELECTOR_INCOLUMNHEADER = pGridInfoRegisterEntity.SHOWCHECKBOXSELECTOR_INCOLUMNHEADER;
            COLUMN_AUTOWIDTH = pGridInfoRegisterEntity.COLUMN_AUTOWIDTH;
            ENABLE_APPEARANCE_EVENROW = pGridInfoRegisterEntity.ENABLE_APPEARANCE_EVENROW;
            ENABLE_APPEARANCE_ODDROW = pGridInfoRegisterEntity.ENABLE_APPEARANCE_ODDROW;
            SHOW_GROUPPANEL = pGridInfoRegisterEntity.SHOW_GROUPPANEL;
            SHOW_INDICATOR = pGridInfoRegisterEntity.SHOW_INDICATOR;
            SHOW_AUTOFILTERROW = pGridInfoRegisterEntity.SHOW_AUTOFILTERROW;
            SHOW_FOOTER = pGridInfoRegisterEntity.SHOW_FOOTER;
            GRID_NEWITEMROWPOSITION = pGridInfoRegisterEntity.GRID_NEWITEMROWPOSITION;
            GRID_NEWITEMROWNAME = pGridInfoRegisterEntity.GRID_NEWITEMROWNAME;
            REMARK = pGridInfoRegisterEntity.REMARK;
            USE_YN = pGridInfoRegisterEntity.USE_YN;
            ALLOW_DROP = pGridInfoRegisterEntity.ALLOW_DROP;


            //상세
            COLUMN_NAME = pGridInfoRegisterEntity.COLUMN_NAME;
            COLUMN_SEQ = pGridInfoRegisterEntity.COLUMN_SEQ;
            COLUMN_CAPTION = pGridInfoRegisterEntity.COLUMN_CAPTION;
            COLUMN_CAPTION_COLOR = pGridInfoRegisterEntity.COLUMN_CAPTION_COLOR;
            COLUMN_FIELD_NAME = pGridInfoRegisterEntity.COLUMN_FIELD_NAME;
            COLUMN_SIZE = pGridInfoRegisterEntity.COLUMN_SIZE;
            COLUMN_TYPE = pGridInfoRegisterEntity.COLUMN_TYPE;
            TEXT_SIZE = pGridInfoRegisterEntity.TEXT_SIZE;
            PARAMETER_DATA = pGridInfoRegisterEntity.PARAMETER_DATA;
            UNBOUND_COLUMNTYPE = pGridInfoRegisterEntity.UNBOUND_COLUMNTYPE;
            HORZ_ALIGNMENT = pGridInfoRegisterEntity.HORZ_ALIGNMENT;
            ALLOW_EDIT = pGridInfoRegisterEntity.ALLOW_EDIT;
            ALLOW_FOCUS = pGridInfoRegisterEntity.ALLOW_FOCUS;
            ALLOW_MERGE = pGridInfoRegisterEntity.ALLOW_MERGE;
            FORMAT_TYPE = pGridInfoRegisterEntity.FORMAT_TYPE;
            FORMAT_STRING = pGridInfoRegisterEntity.FORMAT_STRING;
            SHOWUNBOUND_EXPRESSIONMENU = pGridInfoRegisterEntity.SHOWUNBOUND_EXPRESSIONMENU;
            VISIBLE_INDEX = pGridInfoRegisterEntity.VISIBLE_INDEX;
            VISIBLE = pGridInfoRegisterEntity.VISIBLE;
            LANGUAGE_TYPE = pGridInfoRegisterEntity.LANGUAGE_TYPE;


            ERR_NO = pGridInfoRegisterEntity.ERR_NO;
            ERR_MSG = pGridInfoRegisterEntity.ERR_MSG;
            RTN_KEY = pGridInfoRegisterEntity.RTN_KEY;
            RTN_SEQ = pGridInfoRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pGridInfoRegisterEntity.RTN_OTHERS;
        }

        #endregion

    }

    public class DynamicColumnInfoRegisterEntity
    {
        #region Property

        //사용자 설정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // 언어 정보 값

        public String DYNAMIC_TYPE { get; set; } //상세 정보 테이블 구분 코드

        public String REMARK { get; set; } // 비고
        public String USE_YN { get; set; } // 사용유무


        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }


        #endregion

        #region 생성자 - DynamicColumnInfoRegisterEntity()

        public DynamicColumnInfoRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - DynamicColumnInfoRegisterEntity(pDynamicColumnInfoRegisterEntity)

        public DynamicColumnInfoRegisterEntity(DynamicColumnInfoRegisterEntity pDynamicColumnInfoRegisterEntity)
        {
            CORP_CODE = pDynamicColumnInfoRegisterEntity.CORP_CODE;
            CRUD = pDynamicColumnInfoRegisterEntity.CRUD;
            USER_CODE = pDynamicColumnInfoRegisterEntity.USER_CODE;
            LANGUAGE_TYPE = pDynamicColumnInfoRegisterEntity.LANGUAGE_TYPE;

            DYNAMIC_TYPE = pDynamicColumnInfoRegisterEntity.DYNAMIC_TYPE;

            REMARK = pDynamicColumnInfoRegisterEntity.REMARK;
            USE_YN = pDynamicColumnInfoRegisterEntity.USE_YN;

            ERR_NO = pDynamicColumnInfoRegisterEntity.ERR_NO;
            ERR_MSG = pDynamicColumnInfoRegisterEntity.ERR_MSG;
            RTN_KEY = pDynamicColumnInfoRegisterEntity.RTN_KEY;
            RTN_SEQ = pDynamicColumnInfoRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pDynamicColumnInfoRegisterEntity.RTN_OTHERS;
        }

        #endregion

    }

    public class MenuRegisterEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String LANGUAGE_TYPE { get; set; } // 언어 정보 값
        

        //메뉴별 추가 엔티티 입력
        public String MENU_NO { get; set; }
        public String MENU_NAME { get; set; }
        public String P_MENU_NO { get; set; }
        public String WINDOW_NAME { get; set; }
        public String MODULE { get; set; }
        public String ICONCSS { get; set; }
        public String DSP_SORT { get; set; }
        public String REMARK { get; set; }
        public String USE_YN { get; set; }


        public String TEMPLETE_NO { get; set; }
        public String TEMPLETE_NAME { get; set; }
        public byte[] XML_FILE { get; set; }
        public String XML_FILE_NAME { get; set; }

        #endregion

        #region 생성자 - MenuRegisterEntity()

        public MenuRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - MenuRegisterEntity(pMenuRegisterEntity)

        public MenuRegisterEntity(MenuRegisterEntity pMenuRegisterEntity)
        {
            CORP_CODE = pMenuRegisterEntity.CORP_CODE;
            CRUD = pMenuRegisterEntity.CRUD;
            USER_CODE = pMenuRegisterEntity.USER_CODE;
            ERR_NO = pMenuRegisterEntity.ERR_NO;
            ERR_MSG = pMenuRegisterEntity.ERR_MSG;
            RTN_KEY = pMenuRegisterEntity.RTN_KEY;
            RTN_SEQ = pMenuRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pMenuRegisterEntity.RTN_OTHERS;
            LANGUAGE_TYPE = pMenuRegisterEntity.LANGUAGE_TYPE;

            //메뉴별 추가 엔티티 입력
            REMARK = pMenuRegisterEntity.REMARK;
            USE_YN = pMenuRegisterEntity.USE_YN;

            MENU_NO = pMenuRegisterEntity.MENU_NO;
            MENU_NAME = pMenuRegisterEntity.MENU_NAME;
            P_MENU_NO = pMenuRegisterEntity.P_MENU_NO;
            WINDOW_NAME = pMenuRegisterEntity.WINDOW_NAME;
            MODULE = pMenuRegisterEntity.MODULE;
            ICONCSS = pMenuRegisterEntity.ICONCSS;
            DSP_SORT = pMenuRegisterEntity.DSP_SORT;

            TEMPLETE_NO = pMenuRegisterEntity.TEMPLETE_NO;
            TEMPLETE_NAME = pMenuRegisterEntity.TEMPLETE_NAME;
            XML_FILE = pMenuRegisterEntity.XML_FILE;
            XML_FILE_NAME = pMenuRegisterEntity.XML_FILE_NAME;


        }

        #endregion

    }

    public class MenuInfoRegisterEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String LANGUAGE_TYPE { get; set; } // 언어 정보 값
        public String FTP_IP_PORT { get; set; }
        public String FTP_ID { get; set; }
        public String FTP_PW { get; set; }


        //메뉴별 추가 엔티티 입력
        public String MENU_CODE { get; set; }
        public String MENU_NAME { get; set; }
        public String P_MENU_CODE { get; set; }
        public String WINDOW_NAME { get; set; }
        public String MODULE { get; set; }
        public String ICONCSS { get; set; }
        public String DSP_SORT { get; set; }
        public String REMARK { get; set; }
        public String USE_YN { get; set; }


        public String TEMPLETE_SEQ { get; set; }
        public String TEMPLETE_NAME { get; set; }
        public String TEMPLETE_FILE_NAME { get; set; }
        public String TEMPLETE_FILE_NAME_FULL { get; set; }
        public String TEMPLETE_BEFROE_FILE_NAME { get; set; }

        #endregion

        #region 생성자 - MenuInfoRegisterEntity()

        public MenuInfoRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - MenuInfoRegisterEntity(pMenuInfoRegisterEntity)

        public MenuInfoRegisterEntity(MenuInfoRegisterEntity pMenuInfoRegisterEntity)
        {
            CORP_CODE = pMenuInfoRegisterEntity.CORP_CODE;
            CRUD = pMenuInfoRegisterEntity.CRUD;
            USER_CODE = pMenuInfoRegisterEntity.USER_CODE;
            ERR_NO = pMenuInfoRegisterEntity.ERR_NO;
            ERR_MSG = pMenuInfoRegisterEntity.ERR_MSG;
            RTN_KEY = pMenuInfoRegisterEntity.RTN_KEY;
            RTN_SEQ = pMenuInfoRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pMenuInfoRegisterEntity.RTN_OTHERS;
            LANGUAGE_TYPE = pMenuInfoRegisterEntity.LANGUAGE_TYPE;

            FTP_IP_PORT = pMenuInfoRegisterEntity.FTP_IP_PORT;
            FTP_ID = pMenuInfoRegisterEntity.FTP_ID;
            FTP_PW = pMenuInfoRegisterEntity.FTP_PW;


            //메뉴별 추가 엔티티 입력
            REMARK = pMenuInfoRegisterEntity.REMARK;
            USE_YN = pMenuInfoRegisterEntity.USE_YN;

            MENU_CODE = pMenuInfoRegisterEntity.MENU_CODE;
            MENU_NAME = pMenuInfoRegisterEntity.MENU_NAME;
            P_MENU_CODE = pMenuInfoRegisterEntity.P_MENU_CODE;
            WINDOW_NAME = pMenuInfoRegisterEntity.WINDOW_NAME;
            MODULE = pMenuInfoRegisterEntity.MODULE;
            ICONCSS = pMenuInfoRegisterEntity.ICONCSS;
            DSP_SORT = pMenuInfoRegisterEntity.DSP_SORT;

            TEMPLETE_SEQ= pMenuInfoRegisterEntity.TEMPLETE_SEQ;
            TEMPLETE_NAME = pMenuInfoRegisterEntity.TEMPLETE_NAME;
            TEMPLETE_FILE_NAME = pMenuInfoRegisterEntity.TEMPLETE_FILE_NAME;
            TEMPLETE_FILE_NAME_FULL = pMenuInfoRegisterEntity.TEMPLETE_FILE_NAME_FULL;
            TEMPLETE_BEFROE_FILE_NAME = pMenuInfoRegisterEntity.TEMPLETE_BEFROE_FILE_NAME;


        }

        #endregion

    }

    public class ExcelFormDesignerEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String LANGUAGE_TYPE { get; set; } // 언어 정보 값

        #endregion

        #region 생성자 - ExcelFormDesignerEntity()
        public ExcelFormDesignerEntity()
        {
        }
        #endregion

        #region 생성자 - ExcelFormDesignerEntity(pExcelFormDesignerEntity)
        public ExcelFormDesignerEntity(ExcelFormDesignerEntity pExcelFormDesignerEntity)
        {
            CORP_CODE = pExcelFormDesignerEntity.CORP_CODE;
            CRUD = pExcelFormDesignerEntity.CRUD;
            USER_CODE = pExcelFormDesignerEntity.USER_CODE;
            ERR_NO = pExcelFormDesignerEntity.ERR_NO;
            ERR_MSG = pExcelFormDesignerEntity.ERR_MSG;
            RTN_KEY = pExcelFormDesignerEntity.RTN_KEY;
            RTN_SEQ = pExcelFormDesignerEntity.RTN_SEQ;
            RTN_OTHERS = pExcelFormDesignerEntity.RTN_OTHERS;
            LANGUAGE_TYPE = pExcelFormDesignerEntity.LANGUAGE_TYPE;
        }
        #endregion

    }

    public class MonitoringDesignerEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String LANGUAGE_TYPE { get; set; } // 언어 정보 값

        //메뉴별 추가 엔티티 입력
        public String WINDOW_NAME { get; set; }

        #endregion

        #region MonitoringDesignerEntity()
        public MonitoringDesignerEntity()
        {
        }
        #endregion

        #region MonitoringDesignerEntity(MonitoringDesignerEntity pMonitoringDesignerEntity)
        public MonitoringDesignerEntity(MonitoringDesignerEntity pMonitoringDesignerEntity)
        {
            CORP_CODE = pMonitoringDesignerEntity.CORP_CODE;
            CRUD = pMonitoringDesignerEntity.CRUD;
            USER_CODE = pMonitoringDesignerEntity.USER_CODE;
            ERR_NO = pMonitoringDesignerEntity.ERR_NO;
            ERR_MSG = pMonitoringDesignerEntity.ERR_MSG;
            RTN_KEY = pMonitoringDesignerEntity.RTN_KEY;
            RTN_SEQ = pMonitoringDesignerEntity.RTN_SEQ;
            RTN_OTHERS = pMonitoringDesignerEntity.RTN_OTHERS;
            LANGUAGE_TYPE = pMonitoringDesignerEntity.LANGUAGE_TYPE;

            //메뉴별 추가 엔티티 입력
            WINDOW_NAME = pMonitoringDesignerEntity.WINDOW_NAME;
        }
        #endregion
    }

    public class SystemCodeRegisterEntity
    {
        #region Property

        //사용자 설정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD



        public String CODE_TYPE { get; set; } // 컨트롤러 타입 구분
        public String LANGUAGE_TYPE { get; set; } //언어구분
        public String WINDOW_NAME { get; set; } // 화면 아이디
        public String FIELD_CODE { get; set; } // 필드 아이디
        public String FIELD_NAME { get; set; } // 필드 명칭
        public String FIELD_DESC { get; set; } // 필드 설명
        public String REMARK { get; set; } // 비고
        public String CODE { get; set; }
        public String CODE_L { get; set; }  //대분류코드
        public String CODE_M { get; set; }  //중분류코드
        public String USE_YN { get; set; } // 사용유무


        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }


        #endregion

        #region 생성자 - SystemCodeRegisterEntity()

        public SystemCodeRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - SystemCodeRegisterEntity(_pSystemCodeRegisterEntity)

        public SystemCodeRegisterEntity(SystemCodeRegisterEntity _pSystemCodeRegisterEntity)
        {
            CORP_CODE = _pSystemCodeRegisterEntity.CORP_CODE;
            CRUD = _pSystemCodeRegisterEntity.CRUD;
            USER_CODE = _pSystemCodeRegisterEntity.USER_CODE;

            CODE_TYPE = _pSystemCodeRegisterEntity.CODE_TYPE;
            LANGUAGE_TYPE = _pSystemCodeRegisterEntity.LANGUAGE_TYPE;
            WINDOW_NAME = _pSystemCodeRegisterEntity.WINDOW_NAME;
            FIELD_CODE = _pSystemCodeRegisterEntity.FIELD_CODE;
            FIELD_NAME = _pSystemCodeRegisterEntity.FIELD_NAME;
            FIELD_DESC = _pSystemCodeRegisterEntity.FIELD_DESC;
            CODE = _pSystemCodeRegisterEntity.CODE;
            REMARK = _pSystemCodeRegisterEntity.REMARK;
            USE_YN = _pSystemCodeRegisterEntity.USE_YN;

            ERR_NO = _pSystemCodeRegisterEntity.ERR_NO;
            ERR_MSG = _pSystemCodeRegisterEntity.ERR_MSG;
            RTN_KEY = _pSystemCodeRegisterEntity.RTN_KEY;
            RTN_SEQ = _pSystemCodeRegisterEntity.RTN_SEQ;
            RTN_OTHERS = _pSystemCodeRegisterEntity.RTN_OTHERS;
        }

        #endregion

    }

    public class SystemLogInfoStatusEntity
    {
        #region Property

        //사용자 설정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } //언어구분

        public String USER_ACCOUNT { get; set; }
        public String USER_NAME { get; set; }
        public String LOGDATE_FROM { get; set; }
        public String LOGDATE_TO { get; set; }
        public String LOG_MST { get; set; }




        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }


        #endregion

        #region 생성자 - SystemLogInfoStatusEntity()

        public SystemLogInfoStatusEntity()
        {
        }

        #endregion

        #region 생성자 - SystemLogInfoStatusEntity(_pSystemLogInfoStatusEntity)

        public SystemLogInfoStatusEntity(SystemLogInfoStatusEntity _pSystemLogInfoStatusEntity)
        {
            CORP_CODE = _pSystemLogInfoStatusEntity.CORP_CODE;
            CRUD = _pSystemLogInfoStatusEntity.CRUD;
            USER_CODE = _pSystemLogInfoStatusEntity.USER_CODE;
            LANGUAGE_TYPE = _pSystemLogInfoStatusEntity.LANGUAGE_TYPE;

            USER_ACCOUNT = _pSystemLogInfoStatusEntity.USER_ACCOUNT;
            USER_NAME = _pSystemLogInfoStatusEntity.USER_NAME;

            LOGDATE_FROM = _pSystemLogInfoStatusEntity.LOGDATE_FROM;
            LOGDATE_TO = _pSystemLogInfoStatusEntity.LOGDATE_TO;
            LOG_MST = _pSystemLogInfoStatusEntity.LOG_MST;



            ERR_NO = _pSystemLogInfoStatusEntity.ERR_NO;
            ERR_MSG = _pSystemLogInfoStatusEntity.ERR_MSG;
            RTN_KEY = _pSystemLogInfoStatusEntity.RTN_KEY;
            RTN_SEQ = _pSystemLogInfoStatusEntity.RTN_SEQ;
            RTN_OTHERS = _pSystemLogInfoStatusEntity.RTN_OTHERS;
        }

        #endregion

    }
}

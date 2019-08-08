using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoFAS_MES.CORE.Entity
{
    public class LoginEntity
    {
        #region Property

        //사용자 설정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String CORP_NAME { get; set; } // 회사이름
        public String USER_CODE { get; set; } // 유저아이디
        public String USER_PASS { get; set; } // 유저비번

        #endregion

        #region 생성자 - LoginEntity()

        public LoginEntity()
        {
        }

        #endregion

        #region 생성자 - LoginEntity(pLoginEntity)

        public LoginEntity(LoginEntity pLoginEntity)
        {
            CORP_CODE = pLoginEntity.CORP_CODE;
            CORP_NAME = pLoginEntity.CORP_NAME;
            USER_CODE = pLoginEntity.USER_CODE;
            USER_PASS = pLoginEntity.USER_PASS;
        }

        #endregion

    } 
    public class SystemSettingEntity
    {
        #region Property

        //시스템 설정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String CORP_NAME { get; set; } // 회사이름

        #endregion

        #region 생성자 - SystemSettingEntity()

        public SystemSettingEntity()
        {
        }

        #endregion

        #region 생성자 - SystemSettingEntity(pSystemSettingEntity)

        public SystemSettingEntity(SystemSettingEntity pSystemSettingEntity)
        {
            CORP_CODE = pSystemSettingEntity.CORP_CODE;
            CORP_NAME = pSystemSettingEntity.CORP_NAME;
        }

        #endregion
    }
    public class UserEntity
    {
        #region Property

        //사용자 설정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String CORP_NAME { get; set; } // 회사이름
        public String USER_CODE { get; set; } // 유저아이디
        public String USER_NAME { get; set; } // 유저이름

        public String USER_GRANT { get; set; } // 유저권한
        public String USER_AUTH { get; set; } // 메뉴권한
        public String DEPT_CODE { get; set; } // 부서코드
        public String DEPT_NAME { get; set; } // 부서명
        public String LANGUAGE_TYPE { get; set;} //시스템 언어 설정
        public String CULTURE_INFO { get; set; } //OS 언어설정 정보
        public String FONT_TYPE { get; set; } //글꼴 타입 설정
        public Int32 FONT_SIZE { get; set; } //글꼴 사이즈 설정
        public String POP_TITLE { get; set; } //POP 제목라벨
        public String RESOURCE_CODE { get; set; } //POP 설비
        public String PROCESS_CODE { get; set; } //POP 공정
        public String PROCESS_NAME { get; set; }
        public String PRODUCTION_ORDER_ID { get; set; } //POP 공정

        public string FTP_IP_PORT { get; set; } // FTP 연결 설정
        public string FTP_ID { get; set; } //FTP 아이디 설정
        public string FTP_PW { get; set; } //FTP 비밀번호 설정
        #endregion

        #region 생성자 - UserEntity()

        public UserEntity()
        {
        }

        #endregion

        #region 생성자 - UserEntity(pUserEntity)

        public UserEntity(UserEntity pUserEntity)
        {
            CORP_CODE = pUserEntity.CORP_CODE;
            CORP_NAME = pUserEntity.CORP_NAME;
            USER_CODE = pUserEntity.USER_CODE;
            USER_NAME = pUserEntity.USER_NAME;

            USER_GRANT = pUserEntity.USER_GRANT;

            USER_AUTH = pUserEntity.USER_AUTH;
            DEPT_CODE = pUserEntity.DEPT_CODE;
            DEPT_NAME = pUserEntity.DEPT_NAME;

            LANGUAGE_TYPE = pUserEntity.LANGUAGE_TYPE;
            CULTURE_INFO = pUserEntity.CULTURE_INFO;
            FONT_TYPE = pUserEntity.FONT_TYPE;
            FONT_SIZE = pUserEntity.FONT_SIZE;

            RESOURCE_CODE = pUserEntity.RESOURCE_CODE;
            PROCESS_CODE = pUserEntity.PROCESS_CODE;
            PRODUCTION_ORDER_ID = pUserEntity.PRODUCTION_ORDER_ID;

            FTP_IP_PORT = pUserEntity.FTP_IP_PORT;
            FTP_ID = pUserEntity.FTP_ID;
            FTP_PW = pUserEntity.FTP_PW;
        }

        #endregion

    }
    public class MessageEntity
    {
        #region Property

        //사용자 설정 엔티티
        public String Notice { get; set; } // 회사코드
        public String Message { get; set; } // 회사이름
        public String BookMark { get; set; } // 유저아이디
        public String BookMarkAdd { get; set; } // 유저이름
        public String BookMarkDelete { get; set; } // 메뉴권한
        public String BookMarkAddMessage { get; set; } // 부서코드
        public String BookMarkDeleteMessage { get; set; } // 부서명
        public String BookMarkMessage { get; set; } //시스템 언어 설정
        public String SystemClose { get; set; } //글꼴 타입 설정
        public String ProgramColose { get; set; } //글꼴 사이즈 설정
        public String LANGUAGE_TYPE { get; set; } // 언어 정보 값

        //메뉴 사용 메세지

        public String MSG_SEARCH { get; set; }
        public String MSG_SEARCH_EMPT { get; set; }
        public String MSG_SAVE_QUESTION { get; set; }
        public String MSG_SAVE { get; set; }
        public String MSG_SAVE_ERROR { get; set; }
        public String MSG_DELETE_QUESTION { get; set; }
        public String MSG_DELETE { get; set; }
        public String MSG_DELETE_ERROR { get; set; }
        public String MSG_DELETE_COMPLETE { get; set; }
        public String MSG_INPUT_DATA { get; set; }
        public String MSG_INPUT_DATA_ERROR { get; set; }
        public String MSG_WORKING { get; set; }
        public String MSG_RESET_QUESTION { get; set; }
        public String MSG_EXIT_QUESTION { get; set; }
        public String MSG_SELECT { get; set; }

        public String MSG_NO_SELECT_FILEFORM { get; set; }
        
        //추가
         public String MSG_PLZ_CONNECT_FTP                 { get; set; }
         public String MSG_AGAIN_INPUT_DATA                { get; set; }
         public String MSG_DOWNLOAD_COMPLETE               { get; set; }
         public String MSG_SEARCH_EMPT_DETAIL              { get; set; }
         public String MSG_SPLITQTY_LARGE_MORE             { get; set; }
         public String MSG_DELETE_ERROR_NO_DATA            { get; set; }
         public String MSG_ORDERQTY_LARGE_THAN_0           { get; set; }
         public String MSG_PLAN_LARGE_THAN_ORDER           { get; set; }
         public String MSG_DELETE_ERROR_CONNECT_FTP        { get; set; }
         public String MSG_INPUT_LESS_THAN_NOTOUTQTY       { get; set; }
         public String MSG_LOAD_DATA                       { get; set; }
         public String MSG_NEW_REG_GUBN                    { get; set; }
         public String MSG_INPUT_NUMERIC                   { get; set; }
         public String MSG_NO_SELETED_ITEM                 { get; set; }
         public String MSG_EXIST_COMPANY_ID                { get; set; }
         public String MSG_NOT_DELETE_DATA_IN              { get; set; }
         public String MSG_NOT_MODIFY_DATA_IN              { get; set; }
         public String MSG_SELECT_NEWREG_SAVE              { get; set; }
         public String MSG_INPUT_LARGER_THAN_0             { get; set; }
         public String MSG_NOT_DELETE_DATA_OUT             { get; set; }
         public String MSG_NOT_MODIFY_DATA_OUT             { get; set; }
         public String MSG_CANCLE_NEWREG_MODIFY            { get; set; }
         public String MSG_NO_SELETED_ITEM_OR_NO_SAVE      { get; set; }
         public String MSG_NO_INPUT_LAGER_THAN_NOTINQTY    { get; set; }
         public String MSG_REG_DATA                        { get; set; }
         public String MSG_ADD_FAVORITE_ITEM               { get; set; }
         public String MSG_CHECK_SEARCH_DATE               { get; set; }
         public String MSG_NOT_DISPLAY_ERROR               { get; set; }
         public String MSG_NO_EXIST_INPUT_DATA             { get; set; }
         public String MSG_NOT_DISPLAY_NOT_SAVE            { get; set; }
         public String MSG_CHECK_VALID_ITEM                { get; set; }
         public String MSG_DELETE_FAVORITE_ITEM            { get; set; }
         public String MSG_NOT_EXIST_PRINTING_EXCEL        { get; set; }
        public String  MSG_SELECT_DOWNLOAD_TEMPLETE          { get; set; }
        public String MSG_RESET_COMPLETE                     { get; set; }
        public String MSG_NOT_ROUTING_CONNECT { get; set; }
        public String MSG_PROCESS_CODE { get; set; }
        public String MSG_STATUS_OK { get; set; }
        public String MSG_NOT_USE { get; set; }


        #endregion

        #region 생성자 - MessageEntity()

        public MessageEntity()
        {
        }

        #endregion

        #region 생성자 - MessageEntity(pMessageEntity)

        public MessageEntity(MessageEntity pMessageEntity)
        {

            Notice = pMessageEntity.Notice;
            Message = pMessageEntity.Message;
            BookMark = pMessageEntity.BookMark;
            BookMarkAdd = pMessageEntity.BookMarkAdd;
            BookMarkDelete = pMessageEntity.BookMarkDelete;
            BookMarkAddMessage = pMessageEntity.BookMarkAddMessage;
            BookMarkDeleteMessage = pMessageEntity.BookMarkDeleteMessage;
            BookMarkMessage = pMessageEntity.BookMarkMessage;
            SystemClose = pMessageEntity.SystemClose;
            ProgramColose = pMessageEntity.ProgramColose;
            //LANGUAGE_TYPE = pMessageEntity.LANGUAGE_TYPE;

            MSG_SEARCH = pMessageEntity.MSG_SEARCH;
            MSG_SEARCH_EMPT = pMessageEntity.MSG_SEARCH_EMPT;
            MSG_SAVE_QUESTION = pMessageEntity.MSG_SAVE_QUESTION;
            MSG_SAVE = pMessageEntity.MSG_SAVE;
            MSG_SAVE_ERROR = pMessageEntity.MSG_SAVE_ERROR;
            MSG_DELETE_QUESTION = pMessageEntity.MSG_DELETE_QUESTION;
            MSG_DELETE = pMessageEntity.MSG_DELETE;
            MSG_DELETE_ERROR = pMessageEntity.MSG_DELETE_ERROR;
            MSG_DELETE_COMPLETE = pMessageEntity.MSG_DELETE_COMPLETE;
            MSG_INPUT_DATA = pMessageEntity.MSG_INPUT_DATA;
            MSG_INPUT_DATA_ERROR = pMessageEntity.MSG_INPUT_DATA_ERROR;
            MSG_WORKING = pMessageEntity.MSG_WORKING;
            MSG_RESET_QUESTION = pMessageEntity.MSG_RESET_QUESTION;
            MSG_EXIT_QUESTION = pMessageEntity.MSG_EXIT_QUESTION;
            MSG_SELECT = pMessageEntity.MSG_SELECT;
            MSG_NO_SELECT_FILEFORM = pMessageEntity.MSG_NO_SELECT_FILEFORM;
            //추가
           MSG_PLZ_CONNECT_FTP                  =pMessageEntity.MSG_PLZ_CONNECT_FTP                ;
           MSG_AGAIN_INPUT_DATA                 =pMessageEntity.MSG_AGAIN_INPUT_DATA               ;
           MSG_DOWNLOAD_COMPLETE                =pMessageEntity.MSG_DOWNLOAD_COMPLETE              ;
           MSG_SEARCH_EMPT_DETAIL               =pMessageEntity.MSG_SEARCH_EMPT_DETAIL             ;
           MSG_SPLITQTY_LARGE_MORE              =pMessageEntity.MSG_SPLITQTY_LARGE_MORE            ;
           MSG_DELETE_ERROR_NO_DATA             =pMessageEntity.MSG_DELETE_ERROR_NO_DATA           ;
           MSG_ORDERQTY_LARGE_THAN_0            =pMessageEntity.MSG_ORDERQTY_LARGE_THAN_0          ;
           MSG_PLAN_LARGE_THAN_ORDER            =pMessageEntity.MSG_PLAN_LARGE_THAN_ORDER          ;
           MSG_DELETE_ERROR_CONNECT_FTP         =pMessageEntity.MSG_DELETE_ERROR_CONNECT_FTP       ;
           MSG_INPUT_LESS_THAN_NOTOUTQTY        =pMessageEntity.MSG_INPUT_LESS_THAN_NOTOUTQTY      ;
           MSG_LOAD_DATA                        =pMessageEntity.MSG_LOAD_DATA                      ;
           MSG_NEW_REG_GUBN                     =pMessageEntity.MSG_NEW_REG_GUBN                   ;
           MSG_INPUT_NUMERIC                    =pMessageEntity.MSG_INPUT_NUMERIC                  ;
           MSG_NO_SELETED_ITEM                  =pMessageEntity.MSG_NO_SELETED_ITEM                ;
           MSG_EXIST_COMPANY_ID                 =pMessageEntity.MSG_EXIST_COMPANY_ID               ;
           MSG_NOT_DELETE_DATA_IN               =pMessageEntity.MSG_NOT_DELETE_DATA_IN             ;
           MSG_NOT_MODIFY_DATA_IN               =pMessageEntity.MSG_NOT_MODIFY_DATA_IN             ;
           MSG_SELECT_NEWREG_SAVE               =pMessageEntity.MSG_SELECT_NEWREG_SAVE             ;
           MSG_INPUT_LARGER_THAN_0              =pMessageEntity.MSG_INPUT_LARGER_THAN_0            ;
           MSG_NOT_DELETE_DATA_OUT              =pMessageEntity.MSG_NOT_DELETE_DATA_OUT            ;
           MSG_NOT_MODIFY_DATA_OUT              =pMessageEntity.MSG_NOT_MODIFY_DATA_OUT            ;
           MSG_CANCLE_NEWREG_MODIFY             =pMessageEntity.MSG_CANCLE_NEWREG_MODIFY           ;
           MSG_NO_SELETED_ITEM_OR_NO_SAVE       =pMessageEntity.MSG_NO_SELETED_ITEM_OR_NO_SAVE     ;
           MSG_NO_INPUT_LAGER_THAN_NOTINQTY     =pMessageEntity.MSG_NO_INPUT_LAGER_THAN_NOTINQTY  ;
           MSG_REG_DATA                         =pMessageEntity.MSG_REG_DATA                       ;
           MSG_ADD_FAVORITE_ITEM                =pMessageEntity.MSG_ADD_FAVORITE_ITEM              ;
           MSG_CHECK_SEARCH_DATE                =pMessageEntity.MSG_CHECK_SEARCH_DATE              ;
           MSG_NOT_DISPLAY_ERROR                =pMessageEntity.MSG_NOT_DISPLAY_ERROR              ;
           MSG_NO_EXIST_INPUT_DATA              =pMessageEntity.MSG_NO_EXIST_INPUT_DATA            ;
           MSG_NOT_DISPLAY_NOT_SAVE             =pMessageEntity.MSG_NOT_DISPLAY_NOT_SAVE           ;
           MSG_CHECK_VALID_ITEM                 =pMessageEntity.MSG_CHECK_VALID_ITEM               ;
           MSG_DELETE_FAVORITE_ITEM             =pMessageEntity.MSG_DELETE_FAVORITE_ITEM           ;
           MSG_NOT_EXIST_PRINTING_EXCEL         =pMessageEntity.MSG_NOT_EXIST_PRINTING_EXCEL       ;
           MSG_SELECT_DOWNLOAD_TEMPLETE         =pMessageEntity.MSG_SELECT_DOWNLOAD_TEMPLETE       ;
            MSG_NOT_ROUTING_CONNECT             =pMessageEntity.MSG_NOT_ROUTING_CONNECT            ;
            MSG_RESET_COMPLETE                  =pMessageEntity.MSG_RESET_COMPLETE;
            MSG_PROCESS_CODE = pMessageEntity.MSG_PROCESS_CODE;
            MSG_STATUS_OK = pMessageEntity.MSG_STATUS_OK;
            MSG_NOT_USE = pMessageEntity.MSG_NOT_USE;
        }

        #endregion

    }
    public class MenuSettingEntity
    {
        #region Property

        //사용자 설정 엔티티
        //public String CORP_CODE { get; set; } // 회사코드

        ////메뉴설정 엔티티
        public String MENU_NO { get; set; }
        public String MENU_NAME { get; set; }
        public String MENU_MODULE { get; set; }
        public String MENU_WINDOW_NAME { get; set; }
        public String MENU_USEYN { get; set; }
        public String MENU_INIT { get; set; }
        public String MENU_SEARCH { get; set; }
        public String MENU_SAVE { get; set; }
        public String MENU_ADDITEM { get; set; }
        public String MENU_DELETE { get; set; }
        public String MENU_PRINT { get; set; }
        public String MENU_IMPORT { get; set; }
        public String MENU_EXPORT { get; set; }
        public String MENU_ICONCSS { get; set; }
        #endregion

        #region 생성자 - MenuSettingEntity()

        public MenuSettingEntity()
        {
        }

        #endregion

        #region 생성자 - MenuSettingEntity(pUserEntity)

        public MenuSettingEntity(DataRowView pDataRowView)
        {
            //CORP_CODE = pDataRowView["corp_code"].ToString();
            MENU_NO = pDataRowView["menu_no"].ToString(); //menu_code , menu_no
            MENU_NAME = pDataRowView["menu_name"].ToString();
            MENU_WINDOW_NAME = pDataRowView["window_name"].ToString();
            MENU_MODULE = pDataRowView["module"].ToString();
            MENU_USEYN = pDataRowView["menu_useyn"].ToString();
            MENU_INIT = pDataRowView["menu_init"].ToString();
            MENU_SEARCH = pDataRowView["menu_search"].ToString();
            MENU_SAVE = pDataRowView["menu_save"].ToString();
            MENU_ADDITEM = pDataRowView["menu_additem"].ToString();
            MENU_DELETE = pDataRowView["menu_delete"].ToString();
            MENU_PRINT = pDataRowView["menu_print"].ToString();
            MENU_IMPORT = pDataRowView["menu_import"].ToString();
            MENU_EXPORT = pDataRowView["menu_export"].ToString();
            MENU_ICONCSS = pDataRowView["menu_iconcss"].ToString();
        }

        #endregion
    }
    public class FavoritesMenuSettingEntity
    {
        #region Property

        //사용자 설정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 유저아이디
        public String CRUD { get; set; } //CRUD

        ////메뉴설정 엔티티
        public String MENU_NO { get; set; }
        public String MENU_WINDOW_NAME { get; set; }

        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }

        #endregion

        #region 생성자 - MenuSettingEntity()

        public FavoritesMenuSettingEntity()
        {
        }

        #endregion

        #region 생성자 - FavoritesMenuSettingEntity(DataRowView pDataRowView)

        public FavoritesMenuSettingEntity(FavoritesMenuSettingEntity pFavoritesMenuSettingEntity)
        {
            CORP_CODE = pFavoritesMenuSettingEntity.CORP_CODE;
            USER_CODE = pFavoritesMenuSettingEntity.USER_CODE;
            CRUD = pFavoritesMenuSettingEntity.CRUD;

            MENU_NO = pFavoritesMenuSettingEntity.MENU_NO;
            MENU_WINDOW_NAME = pFavoritesMenuSettingEntity.MENU_WINDOW_NAME;

            ERR_NO = pFavoritesMenuSettingEntity.ERR_NO;
            ERR_MSG = pFavoritesMenuSettingEntity.ERR_MSG;
            RTN_KEY = pFavoritesMenuSettingEntity.RTN_KEY;
            RTN_SEQ = pFavoritesMenuSettingEntity.RTN_SEQ;
            RTN_OTHERS = pFavoritesMenuSettingEntity.RTN_OTHERS;
        }

        #endregion
    }
    public class LanguageEntity
    {
        #region Property

        //사용자 설정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String WINDOW_NAME { get; set; } // 화면명

        #endregion

        #region 생성자 - LanguageEntity()

        public LanguageEntity()
        {
        }

        #endregion

        #region 생성자 - LanguageEntity(pLanguageEntity)

        public LanguageEntity(LanguageEntity pLanguageEntity)
        {
            CORP_CODE = pLanguageEntity.CORP_CODE;
            WINDOW_NAME = pLanguageEntity.WINDOW_NAME;
        }

        #endregion

    }
    public class DevGridSettingEntity
    {
        #region Property

        //사용자 설정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String WINDOW_NAME { get; set; } // 화면명
        public String DEV_GRID_NAME { get; set; } // 데브 그리드 명


        #endregion

        #region 생성자 - DevGridSettingEntity()

        public DevGridSettingEntity()
        {
        }

        #endregion

        #region 생성자 - DevGridSettingEntity(pDevGridSettingEntity)

        public DevGridSettingEntity(DevGridSettingEntity pDevGridSettingEntity)
        {
            CORP_CODE = pDevGridSettingEntity.CORP_CODE;
            WINDOW_NAME = pDevGridSettingEntity.WINDOW_NAME;
            DEV_GRID_NAME = pDevGridSettingEntity.DEV_GRID_NAME;
        }

        #endregion

    }
    public class SystemLogInfoEntity
    {
        #region Property

        //사용자 설정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String CRUD { get; set; }
        public String USER_CODE { get; set; } // 유저아이디
        public String LOG_MST { get; set; }
        public String LOG_DETAIL { get; set; }
        public String REMARK { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        #endregion

        #region 생성자 - SystemLogInfoEntity()

        public SystemLogInfoEntity()
        {
        }

        #endregion

        #region 생성자 - SystemLogInfoEntity(pSystemLogInfoEntity)

        public SystemLogInfoEntity(SystemLogInfoEntity pSystemLogInfoEntity)
        {
            CORP_CODE = pSystemLogInfoEntity.CORP_CODE;
            CRUD = pSystemLogInfoEntity.CRUD;
            USER_CODE = pSystemLogInfoEntity.USER_CODE;
            LOG_MST = pSystemLogInfoEntity.LOG_MST;
            LOG_DETAIL = pSystemLogInfoEntity.LOG_DETAIL;
            REMARK = pSystemLogInfoEntity.REMARK;

            ERR_NO = pSystemLogInfoEntity.ERR_NO;
            ERR_MSG = pSystemLogInfoEntity.ERR_MSG;
            RTN_KEY = pSystemLogInfoEntity.RTN_KEY;
            RTN_SEQ = pSystemLogInfoEntity.RTN_SEQ;
            RTN_OTHERS = pSystemLogInfoEntity.RTN_OTHERS;
        }

        #endregion
    }

    public class XMLDesignEntity
    {
        #region Property

        //사용자 설정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String WINDOW_NAME { get; set; } // 화면명
        public String LANGUAGE_TYPE { get; set; } // 언어

        #endregion

        #region 생성자 - XMLDesignEntity()

        public XMLDesignEntity()
        {
        }

        #endregion

        #region 생성자 - XMLDesignEntity(pXMLDesignEntity)

        public XMLDesignEntity(XMLDesignEntity pXMLDesignEntity)
        {
            WINDOW_NAME = pXMLDesignEntity.WINDOW_NAME;
            LANGUAGE_TYPE = pXMLDesignEntity.LANGUAGE_TYPE;

        }

        #endregion

    }

    public class WindowPageSettingEntity
    {
        #region Property

        //사용자 설정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } //


        //public String CODE_TYPE { get; set; } // 컨트롤러 타입 구분
        public String LANGUAGE_TYPE { get; set; } //언어구분
        public String WINDOW_NAME { get; set; } // 화면 아이디
        public String GRID_NAME { get; set; } //그리드 아이디
        public String GRIDNAME_VIEW { get; set; } // 그리드 뷰 아이디
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

        #region 생성자 - WindowPageSettingEntity()

        public WindowPageSettingEntity()
        {
        }

        #endregion

        #region 생성자 - WindowPageSettingEntity(WindowPageSettingEntity pWindowPageSettingEntity)

        public WindowPageSettingEntity(WindowPageSettingEntity pWindowPageSettingEntity)
        {
            CORP_CODE = pWindowPageSettingEntity.CORP_CODE;
            USER_CODE = pWindowPageSettingEntity.USER_CODE;
            CRUD = pWindowPageSettingEntity.CRUD;

            LANGUAGE_TYPE = pWindowPageSettingEntity.LANGUAGE_TYPE;
            WINDOW_NAME = pWindowPageSettingEntity.WINDOW_NAME;

            GRID_NAME = pWindowPageSettingEntity.GRID_NAME;
            GRIDNAME_VIEW = pWindowPageSettingEntity.GRIDNAME_VIEW;

            FIELD_CODE = pWindowPageSettingEntity.FIELD_CODE;
            FIELD_NAME = pWindowPageSettingEntity.FIELD_NAME;
            FIELD_DESC = pWindowPageSettingEntity.FIELD_DESC;

            REMARK = pWindowPageSettingEntity.REMARK;
            USE_YN = pWindowPageSettingEntity.USE_YN;

            ERR_NO = pWindowPageSettingEntity.ERR_NO;
            ERR_MSG = pWindowPageSettingEntity.ERR_MSG;
            RTN_KEY = pWindowPageSettingEntity.RTN_KEY;
            RTN_SEQ = pWindowPageSettingEntity.RTN_SEQ;
            RTN_OTHERS = pWindowPageSettingEntity.RTN_OTHERS;
        }

        #endregion
    }
    public class WindowSheetSettingEntity
    {
        #region Property

        //사용자 설정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } //


        //public String CODE_TYPE { get; set; } // 컨트롤러 타입 구분
        public String LANGUAGE_TYPE { get; set; } //언어구분
        public String WINDOW_NAME { get; set; } // 화면 아이디

        public String SHEETINFO_MST_CODE { get; set; } // 엑셀파일 코드
        public String FILE_NAME { get; set; } // 파일 아이디
        public String USE_VEND_CODE { get; set; }  // 사용업체명
        public String USE_TYPE { get; set; } // 사용화면명


        public String REMARK { get; set; } // 비고
        public String USE_YN { get; set; } // 사용유무


        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }


        #endregion

        #region 생성자 - WindowSheetSettingEntity()

        public WindowSheetSettingEntity()
        {
        }

        #endregion

        #region 생성자 - WindowSheetSettingEntity(WindowSheetSettingEntity pWindowSheetSettingEntity) //추가

        public WindowSheetSettingEntity(WindowSheetSettingEntity pWindowSheetSettingEntity)  //추가
        {
            CORP_CODE = pWindowSheetSettingEntity.CORP_CODE;
            USER_CODE = pWindowSheetSettingEntity.USER_CODE;
            CRUD = pWindowSheetSettingEntity.CRUD;

            LANGUAGE_TYPE = pWindowSheetSettingEntity.LANGUAGE_TYPE;
            WINDOW_NAME = pWindowSheetSettingEntity.WINDOW_NAME;

            SHEETINFO_MST_CODE = pWindowSheetSettingEntity.SHEETINFO_MST_CODE;
            FILE_NAME = pWindowSheetSettingEntity.FILE_NAME;
            USE_VEND_CODE = pWindowSheetSettingEntity.USE_VEND_CODE;
            USE_TYPE = pWindowSheetSettingEntity.USE_TYPE;
            REMARK = pWindowSheetSettingEntity.REMARK;
            USE_YN = pWindowSheetSettingEntity.USE_YN;

            ERR_NO = pWindowSheetSettingEntity.ERR_NO;
            ERR_MSG = pWindowSheetSettingEntity.ERR_MSG;
            RTN_KEY = pWindowSheetSettingEntity.RTN_KEY;
            RTN_SEQ = pWindowSheetSettingEntity.RTN_SEQ;
            RTN_OTHERS = pWindowSheetSettingEntity.RTN_OTHERS;
        }

        #endregion
    }
    public class CommonCodeReturnEntity
    {
        #region Property

        //사용자 설정 엔티티
        public String CORP_CODE { get; set; } // 회사코드


        #endregion

        #region 생성자 - CommonCodeReturnEntity()

        public CommonCodeReturnEntity()
        {
        }

        #endregion

        #region 생성자 - CommonCodeReturnEntity(pCommonCodeReturnEntity)

        public CommonCodeReturnEntity(CommonCodeReturnEntity pCommonCodeReturnEntity)
        {
            CORP_CODE = pCommonCodeReturnEntity.CORP_CODE;
        }

        #endregion
    }

    public class CodePopUpEntity
    {
        #region Property

        //사용자 설정 엔티티
        public String CORP_CODE { get; set; } // 회사코드


        #endregion

        #region 생성자 - CommonCodeReturnEntity()

        public CodePopUpEntity()
        {
        }

        #endregion

        #region 생성자 - CodePopUpEntity(pCodePopUpEntity)

        public CodePopUpEntity(CodePopUpEntity pCodePopUpEntity)
        {
            CORP_CODE = pCodePopUpEntity.CORP_CODE;
        }

        #endregion
    }

    public class PartCodePopUpEntity
    {
        #region Property

        //사용자 설정 엔티티
        public String CORP_CODE { get; set; } // 
        public String PART_CODE { get; set; } // 
        public String PART_NAME { get; set; } //
        public String PART_TYPE { get; set; } 
        public String CRUD { get; set; } // 
        public String LANGUAGE_TYPE { get; set; }

        #endregion

        #region 생성자 - PartCodePopUpEntity()

        public PartCodePopUpEntity()
        {
        }

        #endregion

        #region 생성자 - PartCodePopUpEntity(PartCodePopUpEntity pPartCodePopUpEntity)

        public PartCodePopUpEntity(PartCodePopUpEntity pPartCodePopUpEntity)
        {
            CORP_CODE = pPartCodePopUpEntity.CORP_CODE;
            PART_CODE = pPartCodePopUpEntity.PART_CODE;
            PART_NAME = pPartCodePopUpEntity.PART_NAME;
            PART_TYPE = pPartCodePopUpEntity.PART_TYPE;
            CRUD = pPartCodePopUpEntity.CRUD;
            LANGUAGE_TYPE = pPartCodePopUpEntity.LANGUAGE_TYPE;
        }

        #endregion
    }

    public class VendCostInfoPopupEntity
    {
        #region Property

        //사용자 설정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String CODE { get; set; } // 회사코드
        public String CODE_NAME { get; set; } // 회사코드


        #endregion

        #region 생성자 - CommonCodeReturnEntity()

        public VendCostInfoPopupEntity()
        {
        }

        #endregion

        #region 생성자 - VendCostInfoPopupEntity(pVendCostInfoPopupEntity)

        public VendCostInfoPopupEntity(VendCostInfoPopupEntity pVendCostInfoPopupEntity)
        {
            CORP_CODE = pVendCostInfoPopupEntity.CORP_CODE;
            CODE = pVendCostInfoPopupEntity.CODE;
            CODE_NAME = pVendCostInfoPopupEntity.CODE_NAME;
        }

        #endregion
    }
    public class VendCodeInfoPopupEntity
    {
        #region Property

        //사용자 설정 엔티티

        public String CORP_CODE { get; set; } // 
        public String VEND_CODE { get; set; } // 
        public String VEND_NAME { get; set; } // 
        public String VEND_TYPE { get; set; } // 
        public String CRUD { get; set; } // 
        
        #endregion

        #region 생성자 - CommonCodeReturnEntity()

        public VendCodeInfoPopupEntity()
        {
        }

        #endregion

        #region 생성자 - VendCodeInfoPopupEntity(pVendCodeInfoPopupEntity)

        public VendCodeInfoPopupEntity(VendCodeInfoPopupEntity pVendCodeInfoPopupEntity)
        {
            VEND_CODE = pVendCodeInfoPopupEntity.VEND_CODE;
            VEND_NAME = pVendCodeInfoPopupEntity.VEND_NAME;
            VEND_TYPE = pVendCodeInfoPopupEntity.VEND_TYPE;
            CRUD = pVendCodeInfoPopupEntity.CRUD;
            CORP_CODE = pVendCodeInfoPopupEntity.CORP_CODE;
        }

        #endregion
    }

    public class VendCodeInfoPopup_T02Entity
    {
        #region Property

        //사용자 설정 엔티티

        public String CORP_CODE { get; set; } // 
        public String VEND_CODE { get; set; } // 
        public String VEND_NAME { get; set; } // 
        public String VEND_TYPE { get; set; } // 
        public String CRUD { get; set; } // 

        #endregion

        #region 생성자 - VendCodeInfoPopup_T02Entity()

        public VendCodeInfoPopup_T02Entity()
        {
        }

        #endregion

        #region 생성자 - VendCodeInfoPopup_T02Entity(VendCodeInfoPopup_T02Entity pVendCodeInfoPopup_T02Entity)

        public VendCodeInfoPopup_T02Entity(VendCodeInfoPopup_T02Entity pVendCodeInfoPopup_T02Entity)
        {
            VEND_CODE = pVendCodeInfoPopup_T02Entity.VEND_CODE;
            VEND_NAME = pVendCodeInfoPopup_T02Entity.VEND_NAME;
            VEND_TYPE = pVendCodeInfoPopup_T02Entity.VEND_TYPE;
            CRUD = pVendCodeInfoPopup_T02Entity.CRUD;
            CORP_CODE = pVendCodeInfoPopup_T02Entity.CORP_CODE;
        }

        #endregion
    }

    public class VendCodeInfoPopup_T04Entity
    {
        #region Property

        //사용자 설정 엔티티

        public String CORP_CODE { get; set; } // 
        public String VEND_CODE { get; set; } // 
        public String VEND_NAME { get; set; } // 
        public String VEND_TYPE { get; set; } // 
        public String CRUD { get; set; } // 

        #endregion

        #region 생성자 - VendCodeInfoPopup_T04Entity()

        public VendCodeInfoPopup_T04Entity()
        {
        }

        #endregion

        #region 생성자 - VendCodeInfoPopup_T04Entity(VendCodeInfoPopup_T04Entity pVendCodeInfoPopup_T04Entity)

        public VendCodeInfoPopup_T04Entity(VendCodeInfoPopup_T04Entity pVendCodeInfoPopup_T04Entity)
        {
            VEND_CODE = pVendCodeInfoPopup_T04Entity.VEND_CODE;
            VEND_NAME = pVendCodeInfoPopup_T04Entity.VEND_NAME;
            VEND_TYPE = pVendCodeInfoPopup_T04Entity.VEND_TYPE;
            CRUD = pVendCodeInfoPopup_T04Entity.CRUD;
            CORP_CODE = pVendCodeInfoPopup_T04Entity.CORP_CODE;
        }

        #endregion
    }


    public class ProductionOrderInfoPopupEntity
    {
        #region Property

        //사용자 설정 엔티티

        public String CORP_CODE { get; set; } // 
        public String VEND_CODE { get; set; } // 
        public String VEND_NAME { get; set; } // 

        public String JOBORDER_CD { get; set; } // 
        public String MATERIAL_CD { get; set; } // 
        public String MATERIAL_NM { get; set; } // 
        public String JOB_FRIST_DATE { get; set; } //       
        public String JOB_LAST_DATE { get; set; } //       

        #endregion

        #region 생성자 - CommonCodeReturnEntity()

        public ProductionOrderInfoPopupEntity()
        {
        }

        #endregion

        #region 생성자 - ProductionOrderInfoPopupEntity(pVendCodeInfoPopupEntity)

        public ProductionOrderInfoPopupEntity(ProductionOrderInfoPopupEntity pProductionOrderInfoPopupEntity)
        {
            JOBORDER_CD = pProductionOrderInfoPopupEntity.JOBORDER_CD;
            VEND_CODE = pProductionOrderInfoPopupEntity.VEND_CODE;
            VEND_NAME = pProductionOrderInfoPopupEntity.VEND_NAME;
            MATERIAL_CD = pProductionOrderInfoPopupEntity.MATERIAL_CD;
            MATERIAL_NM = pProductionOrderInfoPopupEntity.MATERIAL_NM;
            JOB_FRIST_DATE = pProductionOrderInfoPopupEntity.JOB_FRIST_DATE;
            JOB_LAST_DATE = pProductionOrderInfoPopupEntity.JOB_LAST_DATE;
        }

        #endregion
    }

    public class SubMonitoringEntity
    {
        #region Property

        //사용자 설정 엔티티
        public String CORP_CODE { get; set; } // 회사코드


        #endregion

        #region 생성자 - SubMonitoringEntity()

        public SubMonitoringEntity()
        {
        }

        #endregion

        #region 생성자 - SubMonitoringEntity(pSubMonitoringEntity)

        public SubMonitoringEntity(SubMonitoringEntity pSubMonitoringEntity)
        {
            CORP_CODE = pSubMonitoringEntity.CORP_CODE;
        }

        #endregion
    }
  
    public class ContractInfoPopUpEntity
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

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - GridInfoRegisterEntity()

        public ContractInfoPopUpEntity()
        {
        }

        #endregion

        #region 생성자 - ContractInfoPopUpEntity(pGridInfoRegisterEntity)

        public ContractInfoPopUpEntity(ContractInfoPopUpEntity pContractInfoPopUpEntity)
        {
            CORP_CODE = pContractInfoPopUpEntity.CORP_CODE;
            CRUD = pContractInfoPopUpEntity.CRUD;
            USER_CODE = pContractInfoPopUpEntity.USER_CODE;
            ERR_NO = pContractInfoPopUpEntity.ERR_NO;
            ERR_MSG = pContractInfoPopUpEntity.ERR_MSG;
            RTN_KEY = pContractInfoPopUpEntity.RTN_KEY;
            RTN_SEQ = pContractInfoPopUpEntity.RTN_SEQ;
            RTN_OTHERS = pContractInfoPopUpEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ProductPlanInfoPopupEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD

        public String PART_CODE_MST { get; set; }
        public String CONTRACT_ID { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_AQ { get; set; } // 리턴 순번 값
        public String RTN_SQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - ProductPlanInfoPopupEntity()

        public ProductPlanInfoPopupEntity()
        {
        }

        #endregion

        #region 생성자 - ProductPlanInfoPopupEntity(pProductPlanInfoPopupEntity)

        public ProductPlanInfoPopupEntity(ProductPlanInfoPopupEntity pProductPlanInfoPopupEntity)
        {
            CORP_CODE = pProductPlanInfoPopupEntity.CORP_CODE;
            CRUD = pProductPlanInfoPopupEntity.CRUD;
            USER_CODE = pProductPlanInfoPopupEntity.USER_CODE;

            PART_CODE_MST = pProductPlanInfoPopupEntity.PART_CODE_MST;
            CONTRACT_ID = pProductPlanInfoPopupEntity.CONTRACT_ID;

            ERR_NO = pProductPlanInfoPopupEntity.ERR_NO;
            ERR_MSG = pProductPlanInfoPopupEntity.ERR_MSG;
            RTN_KEY = pProductPlanInfoPopupEntity.RTN_KEY;
            RTN_SEQ = pProductPlanInfoPopupEntity.RTN_SEQ;
            RTN_AQ = pProductPlanInfoPopupEntity.RTN_AQ;
            RTN_SQ = pProductPlanInfoPopupEntity.RTN_SQ;
            RTN_OTHERS = pProductPlanInfoPopupEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class ProductPlanInfoPopup_T50Entity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD

        public String PART_CODE_MST { get; set; }
        public String CONTRACT_ID { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_AQ { get; set; } // 리턴 순번 값
        public String RTN_SQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - ProductPlanInfoPopup_T50Entity()

        public ProductPlanInfoPopup_T50Entity()
        {
        }

        #endregion

        #region 생성자 - ProductPlanInfoPopup_T50Entity(pProductPlanInfoPopup_T50Entity)

        public ProductPlanInfoPopup_T50Entity(ProductPlanInfoPopup_T50Entity pProductPlanInfoPopup_T50Entity)
        {
            CORP_CODE = pProductPlanInfoPopup_T50Entity.CORP_CODE;
            CRUD = pProductPlanInfoPopup_T50Entity.CRUD;
            USER_CODE = pProductPlanInfoPopup_T50Entity.USER_CODE;

            PART_CODE_MST = pProductPlanInfoPopup_T50Entity.PART_CODE_MST;
            CONTRACT_ID = pProductPlanInfoPopup_T50Entity.CONTRACT_ID;

            ERR_NO = pProductPlanInfoPopup_T50Entity.ERR_NO;
            ERR_MSG = pProductPlanInfoPopup_T50Entity.ERR_MSG;
            RTN_KEY = pProductPlanInfoPopup_T50Entity.RTN_KEY;
            RTN_SEQ = pProductPlanInfoPopup_T50Entity.RTN_SEQ;
            RTN_AQ = pProductPlanInfoPopup_T50Entity.RTN_AQ;
            RTN_SQ = pProductPlanInfoPopup_T50Entity.RTN_SQ;
            RTN_OTHERS = pProductPlanInfoPopup_T50Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class ucProductionOrderInfoPopup_T02_Entity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // 언어 정보 값

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_AQ { get; set; } // 리턴 순번 값
        public String RTN_SQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값


        //메뉴별 추가 엔티티 입력

        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String VEND_CODE { get; set; }
        public String VEND_NAME { get; set; }

        #endregion

        #region 생성자 - ucProductionOrderInfoPopup_T02_Entity()

        public ucProductionOrderInfoPopup_T02_Entity()
        {
        }

        #endregion

        #region 생성자 - ucProductionOrderInfoPopup_T02_Entity(ucProductionOrderInfoPopup_T02_Entity pucProductionOrderInfoPopup_T02_Entity)

        public ucProductionOrderInfoPopup_T02_Entity(ucProductionOrderInfoPopup_T02_Entity pucProductionOrderInfoPopup_T02_Entity)
        {
            CORP_CODE = pucProductionOrderInfoPopup_T02_Entity.CORP_CODE;
            CRUD = pucProductionOrderInfoPopup_T02_Entity.CRUD;
            USER_CODE = pucProductionOrderInfoPopup_T02_Entity.USER_CODE;
            LANGUAGE_TYPE = pucProductionOrderInfoPopup_T02_Entity.LANGUAGE_TYPE;

            ERR_NO = pucProductionOrderInfoPopup_T02_Entity.ERR_NO;
            ERR_MSG = pucProductionOrderInfoPopup_T02_Entity.ERR_MSG;
            RTN_KEY = pucProductionOrderInfoPopup_T02_Entity.RTN_KEY;
            RTN_SEQ = pucProductionOrderInfoPopup_T02_Entity.RTN_SEQ;
            RTN_AQ = pucProductionOrderInfoPopup_T02_Entity.RTN_AQ;
            RTN_SQ = pucProductionOrderInfoPopup_T02_Entity.RTN_SQ;
            RTN_OTHERS = pucProductionOrderInfoPopup_T02_Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            DATE_FROM = pucProductionOrderInfoPopup_T02_Entity.DATE_FROM;
            DATE_TO = pucProductionOrderInfoPopup_T02_Entity.DATE_TO;
            PART_CODE = pucProductionOrderInfoPopup_T02_Entity.PART_CODE;
            PART_NAME = pucProductionOrderInfoPopup_T02_Entity.PART_NAME;
            VEND_CODE = pucProductionOrderInfoPopup_T02_Entity.VEND_CODE;
            VEND_NAME = pucProductionOrderInfoPopup_T02_Entity.VEND_NAME;

        }

        #endregion
    }
    public class ucProductionOrderInfoPopup_T03_Entity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // 언어 정보 값

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_AQ { get; set; } // 리턴 순번 값
        public String RTN_SQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값


        //메뉴별 추가 엔티티 입력

        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String VEND_CODE { get; set; }
        public String VEND_NAME { get; set; }

        #endregion

        #region 생성자 - ucProductionOrderInfoPopup_T03_Entity()

        public ucProductionOrderInfoPopup_T03_Entity()
        {
        }

        #endregion

        #region 생성자 - ucProductionOrderInfoPopup_T03_Entity(ucProductionOrderInfoPopup_T03_Entity pucProductionOrderInfoPopup_T03_Entity)

        public ucProductionOrderInfoPopup_T03_Entity(ucProductionOrderInfoPopup_T03_Entity pucProductionOrderInfoPopup_T03_Entity)
        {
            CORP_CODE = pucProductionOrderInfoPopup_T03_Entity.CORP_CODE;
            CRUD = pucProductionOrderInfoPopup_T03_Entity.CRUD;
            USER_CODE = pucProductionOrderInfoPopup_T03_Entity.USER_CODE;
            LANGUAGE_TYPE = pucProductionOrderInfoPopup_T03_Entity.LANGUAGE_TYPE;

            ERR_NO = pucProductionOrderInfoPopup_T03_Entity.ERR_NO;
            ERR_MSG = pucProductionOrderInfoPopup_T03_Entity.ERR_MSG;
            RTN_KEY = pucProductionOrderInfoPopup_T03_Entity.RTN_KEY;
            RTN_SEQ = pucProductionOrderInfoPopup_T03_Entity.RTN_SEQ;
            RTN_AQ = pucProductionOrderInfoPopup_T03_Entity.RTN_AQ;
            RTN_SQ = pucProductionOrderInfoPopup_T03_Entity.RTN_SQ;
            RTN_OTHERS = pucProductionOrderInfoPopup_T03_Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            DATE_FROM = pucProductionOrderInfoPopup_T03_Entity.DATE_FROM;
            DATE_TO = pucProductionOrderInfoPopup_T03_Entity.DATE_TO;
            PART_CODE = pucProductionOrderInfoPopup_T03_Entity.PART_CODE;
            PART_NAME = pucProductionOrderInfoPopup_T03_Entity.PART_NAME;
            VEND_CODE = pucProductionOrderInfoPopup_T03_Entity.VEND_CODE;
            VEND_NAME = pucProductionOrderInfoPopup_T03_Entity.VEND_NAME;

        }

        #endregion
    }
    public class WorkOrderInfoPopupEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // 언어 정보 값

        public String PART_CODE_MST { get; set; }
        public String WORKORDER_ID { get; set; }
        public String REFERENCE_ID { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_AQ { get; set; } // 리턴 순번 값
        public String RTN_SQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - WorkOrderInfoPopupEntity()

        public WorkOrderInfoPopupEntity()
        {
        }

        #endregion

        #region 생성자 - WorkOrderInfoPopupEntity(pWorkOrderInfoPopupEntity)

        public WorkOrderInfoPopupEntity(WorkOrderInfoPopupEntity pWorkOrderInfoPopupEntity)
        {
            CORP_CODE = pWorkOrderInfoPopupEntity.CORP_CODE;
            CRUD = pWorkOrderInfoPopupEntity.CRUD;
            USER_CODE = pWorkOrderInfoPopupEntity.USER_CODE;
            LANGUAGE_TYPE = pWorkOrderInfoPopupEntity.LANGUAGE_TYPE;

            PART_CODE_MST = pWorkOrderInfoPopupEntity.PART_CODE_MST;
            WORKORDER_ID = pWorkOrderInfoPopupEntity.WORKORDER_ID;
            REFERENCE_ID = pWorkOrderInfoPopupEntity.REFERENCE_ID;

            ERR_NO = pWorkOrderInfoPopupEntity.ERR_NO;
            ERR_MSG = pWorkOrderInfoPopupEntity.ERR_MSG;
            RTN_KEY = pWorkOrderInfoPopupEntity.RTN_KEY;
            RTN_SEQ = pWorkOrderInfoPopupEntity.RTN_SEQ;
            RTN_AQ = pWorkOrderInfoPopupEntity.RTN_AQ;
            RTN_SQ = pWorkOrderInfoPopupEntity.RTN_SQ;
            RTN_OTHERS = pWorkOrderInfoPopupEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class ucWorkOrderInfoPopup_T50Entity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // 언어 정보 값

        public String WINDOW_NAME { get; set; } // 언어 정보 값

        public String CARVE { get; set; } //각인정보
        public String MESSAGE { get; set; } // 지시사항

        public String PART_CODE_MST { get; set; }
        public String WORKORDER_ID { get; set; }
        public String REFERENCE_ID { get; set; }
        public String PRODUCTION_ORDER_ID { get; set; }

        public String PART_CODE { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_AQ { get; set; } // 리턴 순번 값
        public String RTN_SQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - ucWorkOrderInfoPopup_T50Entity()

        public ucWorkOrderInfoPopup_T50Entity()
        {
        }

        #endregion

        #region 생성자 - ucWorkOrderInfoPopup_T50Entity(pucWorkOrderInfoPopup_T50Entity)

        public ucWorkOrderInfoPopup_T50Entity(ucWorkOrderInfoPopup_T50Entity pucWorkOrderInfoPopup_T50Entity)
        {
            CORP_CODE = pucWorkOrderInfoPopup_T50Entity.CORP_CODE;
            CRUD = pucWorkOrderInfoPopup_T50Entity.CRUD;
            USER_CODE = pucWorkOrderInfoPopup_T50Entity.USER_CODE;
            LANGUAGE_TYPE = pucWorkOrderInfoPopup_T50Entity.LANGUAGE_TYPE;
            CARVE = pucWorkOrderInfoPopup_T50Entity.CARVE;
            MESSAGE = pucWorkOrderInfoPopup_T50Entity.MESSAGE;
            PART_CODE_MST = pucWorkOrderInfoPopup_T50Entity.PART_CODE_MST;
            WORKORDER_ID = pucWorkOrderInfoPopup_T50Entity.WORKORDER_ID;
            REFERENCE_ID = pucWorkOrderInfoPopup_T50Entity.REFERENCE_ID;
            WINDOW_NAME = pucWorkOrderInfoPopup_T50Entity.WINDOW_NAME;
            ERR_NO = pucWorkOrderInfoPopup_T50Entity.ERR_NO;
            ERR_MSG = pucWorkOrderInfoPopup_T50Entity.ERR_MSG;
            RTN_KEY = pucWorkOrderInfoPopup_T50Entity.RTN_KEY;
            RTN_SEQ = pucWorkOrderInfoPopup_T50Entity.RTN_SEQ;
            RTN_AQ = pucWorkOrderInfoPopup_T50Entity.RTN_AQ;
            RTN_SQ = pucWorkOrderInfoPopup_T50Entity.RTN_SQ;
            RTN_OTHERS = pucWorkOrderInfoPopup_T50Entity.RTN_OTHERS;
            PRODUCTION_ORDER_ID = pucWorkOrderInfoPopup_T50Entity.PRODUCTION_ORDER_ID;
            PART_CODE = pucWorkOrderInfoPopup_T50Entity.PART_CODE;
            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class ucPlanOrderinfoPopup_Entity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // 언어 정보 값

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_AQ { get; set; } // 리턴 순번 값
        public String RTN_SQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값


        //메뉴별 추가 엔티티 입력

        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String PLAN_ORDER_ID { get; set; }

        #endregion

        #region 생성자 - ucPlanOrderinfoPopup_Entity()

        public ucPlanOrderinfoPopup_Entity()
        {
        }

        #endregion

        #region 생성자 - ucPlanOrderinfoPopup_Entity(ucPlanOrderinfoPopup_Entity pucPlanOrderinfoPopup_Entity)

        public ucPlanOrderinfoPopup_Entity(ucPlanOrderinfoPopup_Entity pucPlanOrderinfoPopup_Entity)
        {
            CORP_CODE = pucPlanOrderinfoPopup_Entity.CORP_CODE;
            CRUD = pucPlanOrderinfoPopup_Entity.CRUD;
            USER_CODE = pucPlanOrderinfoPopup_Entity.USER_CODE;
            LANGUAGE_TYPE = pucPlanOrderinfoPopup_Entity.LANGUAGE_TYPE;

            ERR_NO = pucPlanOrderinfoPopup_Entity.ERR_NO;
            ERR_MSG = pucPlanOrderinfoPopup_Entity.ERR_MSG;
            RTN_KEY = pucPlanOrderinfoPopup_Entity.RTN_KEY;
            RTN_SEQ = pucPlanOrderinfoPopup_Entity.RTN_SEQ;
            RTN_AQ = pucPlanOrderinfoPopup_Entity.RTN_AQ;
            RTN_SQ = pucPlanOrderinfoPopup_Entity.RTN_SQ;
            RTN_OTHERS = pucPlanOrderinfoPopup_Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            DATE_FROM = pucPlanOrderinfoPopup_Entity.DATE_FROM;
            DATE_TO = pucPlanOrderinfoPopup_Entity.DATE_TO;
            PART_CODE = pucPlanOrderinfoPopup_Entity.PART_CODE;
            PART_NAME = pucPlanOrderinfoPopup_Entity.PART_NAME;
            PLAN_ORDER_ID = pucPlanOrderinfoPopup_Entity.PLAN_ORDER_ID;

        }

        #endregion
    }

    public class ucPlanOrderinfoPopup_T50_Entity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // 언어 정보 값

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_AQ { get; set; } // 리턴 순번 값
        public String RTN_SQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값


        //메뉴별 추가 엔티티 입력

        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String PLAN_ORDER_ID { get; set; }
        public String CONFIGURATION_MST_NAME { get; set; }
        public String CONFIGURATION_NAME { get; set; }

        #endregion

        #region 생성자 - ucPlanOrderinfoPopup_T50_Entity()

        public ucPlanOrderinfoPopup_T50_Entity()
        {
        }

        #endregion

        #region 생성자 - ucPlanOrderinfoPopup_T50_Entity(ucPlanOrderinfoPopup_T50_Entity pucPlanOrderinfoPopup_T50_Entity)

        public ucPlanOrderinfoPopup_T50_Entity(ucPlanOrderinfoPopup_T50_Entity pucPlanOrderinfoPopup_T50_Entity)
        {
            CORP_CODE = pucPlanOrderinfoPopup_T50_Entity.CORP_CODE;
            CRUD = pucPlanOrderinfoPopup_T50_Entity.CRUD;
            USER_CODE = pucPlanOrderinfoPopup_T50_Entity.USER_CODE;
            LANGUAGE_TYPE = pucPlanOrderinfoPopup_T50_Entity.LANGUAGE_TYPE;

            ERR_NO = pucPlanOrderinfoPopup_T50_Entity.ERR_NO;
            ERR_MSG = pucPlanOrderinfoPopup_T50_Entity.ERR_MSG;
            RTN_KEY = pucPlanOrderinfoPopup_T50_Entity.RTN_KEY;
            RTN_SEQ = pucPlanOrderinfoPopup_T50_Entity.RTN_SEQ;
            RTN_AQ = pucPlanOrderinfoPopup_T50_Entity.RTN_AQ;
            RTN_SQ = pucPlanOrderinfoPopup_T50_Entity.RTN_SQ;
            RTN_OTHERS = pucPlanOrderinfoPopup_T50_Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            DATE_FROM = pucPlanOrderinfoPopup_T50_Entity.DATE_FROM;
            DATE_TO = pucPlanOrderinfoPopup_T50_Entity.DATE_TO;
            PART_CODE = pucPlanOrderinfoPopup_T50_Entity.PART_CODE;
            PART_NAME = pucPlanOrderinfoPopup_T50_Entity.PART_NAME;
            PLAN_ORDER_ID = pucPlanOrderinfoPopup_T50_Entity.PLAN_ORDER_ID;
            CONFIGURATION_MST_NAME = pucPlanOrderinfoPopup_T50_Entity.CONFIGURATION_MST_NAME;
            CONFIGURATION_NAME = pucPlanOrderinfoPopup_T50_Entity.CONFIGURATION_NAME;

        }

        #endregion
    }

    public class ucWorkResultPopup_Entity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // 언어 정보 값

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_AQ { get; set; } // 리턴 순번 값
        public String RTN_SQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값


        //메뉴별 추가 엔티티 입력
        public String RESOURCE_CODE { get; set; }
        public String COLLECTION_DATE { get; set; }
        public String PROPERTY_VALUE { get; set; }
        public String CONDITION_CODE { get; set; }
        public String COLLECTION_VALUE { get; set; }

        public String PRODUCTION_ORDER_ID { get; set; }
        public String COMPLETE_YN { get; set; }
        public String OPTION_CODE { get; set; }
        public String COLLECTION_VALUE_STR { get; set; }


        #endregion

        #region 생성자 - ucWorkResultPopup_Entity()

        public ucWorkResultPopup_Entity()
        {
        }

        #endregion

        #region 생성자 - ucWorkResultPopup_Entity(ucWorkResultPopup_Entity pucWorkResultPopup_Entity)

        public ucWorkResultPopup_Entity(ucWorkResultPopup_Entity pucWorkResultPopup_Entity)
        {
            CORP_CODE = pucWorkResultPopup_Entity.CORP_CODE;
            CRUD = pucWorkResultPopup_Entity.CRUD;
            USER_CODE = pucWorkResultPopup_Entity.USER_CODE;
            LANGUAGE_TYPE = pucWorkResultPopup_Entity.LANGUAGE_TYPE;

            ERR_NO = pucWorkResultPopup_Entity.ERR_NO;
            ERR_MSG = pucWorkResultPopup_Entity.ERR_MSG;
            RTN_KEY = pucWorkResultPopup_Entity.RTN_KEY;
            RTN_SEQ = pucWorkResultPopup_Entity.RTN_SEQ;
            RTN_AQ = pucWorkResultPopup_Entity.RTN_AQ;
            RTN_SQ = pucWorkResultPopup_Entity.RTN_SQ;
            RTN_OTHERS = pucWorkResultPopup_Entity.RTN_OTHERS;

            RESOURCE_CODE = pucWorkResultPopup_Entity.RESOURCE_CODE;
            COLLECTION_DATE = pucWorkResultPopup_Entity.COLLECTION_DATE;
            PROPERTY_VALUE = pucWorkResultPopup_Entity.PROPERTY_VALUE;
            CONDITION_CODE = pucWorkResultPopup_Entity.CONDITION_CODE;
            COLLECTION_VALUE = pucWorkResultPopup_Entity.COLLECTION_VALUE;
            OPTION_CODE = pucWorkResultPopup_Entity.OPTION_CODE;
            COLLECTION_VALUE_STR = pucWorkResultPopup_Entity.COLLECTION_VALUE_STR;

            PRODUCTION_ORDER_ID = pucWorkResultPopup_Entity.PRODUCTION_ORDER_ID;
            COMPLETE_YN = pucWorkResultPopup_Entity.COMPLETE_YN;
        }

        #endregion
    }

    public class NoticeEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE


        public String WINDOW_NAME { get; set; }
        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        public String NOTICE_ID { get; set; }
        public String NOTICE_NAME { get; set; }
        public String NOTICE_DATE { get; set; }
        public String NOTICE_DETAIL { get; set; }
        public String USE_YN { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - NoticeEntity()

        public NoticeEntity()
        {
        }

        #endregion

        #region 생성자 - NoticeEntity(pNoticeEntity)

        public NoticeEntity(NoticeEntity pNoticeEntity)
        {
            CORP_CODE = pNoticeEntity.CORP_CODE;
            CRUD = pNoticeEntity.CRUD;
            USER_CODE = pNoticeEntity.USER_CODE;
            LANGUAGE_TYPE = pNoticeEntity.LANGUAGE_TYPE;

            pNoticeEntity.DATE_FROM = DATE_FROM;
            pNoticeEntity.DATE_TO = DATE_TO;
            pNoticeEntity.NOTICE_ID = NOTICE_ID;
            pNoticeEntity.NOTICE_NAME = NOTICE_NAME;
            pNoticeEntity.NOTICE_DATE = NOTICE_DATE;
            pNoticeEntity.NOTICE_DETAIL = NOTICE_DETAIL;
            pNoticeEntity.USE_YN = USE_YN;

            ERR_NO = pNoticeEntity.ERR_NO;
            ERR_MSG = pNoticeEntity.ERR_MSG;
            RTN_KEY = pNoticeEntity.RTN_KEY;
            RTN_SEQ = pNoticeEntity.RTN_SEQ;
            RTN_OTHERS = pNoticeEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class MaterialOrderInfoPopup_T01Entity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // 언어 정보 값

        public String PART_CODE_MST { get; set; }
        public String WORKORDER_ID { get; set; }
        public String REFERENCE_ID { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_AQ { get; set; } // 리턴 순번 값
        public String RTN_SQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - MaterialOrderInfoPopup_T01Entity()

        public MaterialOrderInfoPopup_T01Entity()
        {
        }

        #endregion

        #region 생성자 - MaterialOrderInfoPopup_T01Entity(pMaterialOrderInfoPopup_T01Entity)

        public MaterialOrderInfoPopup_T01Entity(MaterialOrderInfoPopup_T01Entity pMaterialOrderInfoPopup_T01Entity)
        {
            CORP_CODE = pMaterialOrderInfoPopup_T01Entity.CORP_CODE;
            CRUD = pMaterialOrderInfoPopup_T01Entity.CRUD;
            USER_CODE = pMaterialOrderInfoPopup_T01Entity.USER_CODE;
            LANGUAGE_TYPE = pMaterialOrderInfoPopup_T01Entity.LANGUAGE_TYPE;

            PART_CODE_MST = pMaterialOrderInfoPopup_T01Entity.PART_CODE_MST;
            WORKORDER_ID = pMaterialOrderInfoPopup_T01Entity.WORKORDER_ID;
            REFERENCE_ID = pMaterialOrderInfoPopup_T01Entity.REFERENCE_ID;

            ERR_NO = pMaterialOrderInfoPopup_T01Entity.ERR_NO;
            ERR_MSG = pMaterialOrderInfoPopup_T01Entity.ERR_MSG;
            RTN_KEY = pMaterialOrderInfoPopup_T01Entity.RTN_KEY;
            RTN_SEQ = pMaterialOrderInfoPopup_T01Entity.RTN_SEQ;
            RTN_AQ = pMaterialOrderInfoPopup_T01Entity.RTN_AQ;
            RTN_SQ = pMaterialOrderInfoPopup_T01Entity.RTN_SQ;
            RTN_OTHERS = pMaterialOrderInfoPopup_T01Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class TabletBasedSensorInfoPopup_T02Entity
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


        //고정 엔티티
        public String COLLECTION_DATE { get; set; }

        //메뉴별 추가 엔티티 입력
        public String WINDOW_NAME { get; set; }

        public String LANGUAGE_TYPE { get; set; }

        //추가
        public String HACCP_TYPE { get; set; }
        public String DATE_TO { get; set; }
        public String DATE_FROM { get; set; }
        public String PART_NAME { get; set; }
        public String HACCP_ID { get; set; }
        public String HACCP_DATE { get; set; }
        public String HACCP_SEQ { get; set; }
        public String PROCESS_NAME { get; set; }
        public String REQUEST_DEPT { get; set; }
        public String CODE_NAME { get; set; }
        public String INOUT_DATE { get; set; }
        public String INOUT_QTY { get; set; }
        public String PACKING_REMARK { get; set; }
        public String SAMPLE_DEPT { get; set; }
        public String SAMPLE_NO { get; set; }
        public String SAMPLE_USER { get; set; }
        public String USER_YN { get; set; }
        public String REMARK { get; set; }



        public int dtListCnt { get; set; }

        public String MISSING_CHECK { get; set; }


        #endregion

        #region 생성자 - TabletBasedSensorInfoPopup_T02Entity()

        public TabletBasedSensorInfoPopup_T02Entity()
        {
        }

        #endregion

        #region 생성자 - TabletBasedSensorInfoPopup_T02Entity(pTabletBasedSensorInfoPopup_T02Entity)

        public TabletBasedSensorInfoPopup_T02Entity(TabletBasedSensorInfoPopup_T02Entity pTabletBasedSensorInfoPopup_T02Entity)
        {
            CORP_CODE = pTabletBasedSensorInfoPopup_T02Entity.CORP_CODE;
            CRUD = pTabletBasedSensorInfoPopup_T02Entity.CRUD;
            USER_CODE = pTabletBasedSensorInfoPopup_T02Entity.USER_CODE;

            COLLECTION_DATE = pTabletBasedSensorInfoPopup_T02Entity.COLLECTION_DATE;

            pTabletBasedSensorInfoPopup_T02Entity.WINDOW_NAME = WINDOW_NAME;

            HACCP_TYPE = pTabletBasedSensorInfoPopup_T02Entity.HACCP_TYPE;
            DATE_FROM = pTabletBasedSensorInfoPopup_T02Entity.DATE_FROM;
            DATE_TO = pTabletBasedSensorInfoPopup_T02Entity.DATE_TO;
            PART_NAME = pTabletBasedSensorInfoPopup_T02Entity.PART_NAME;
            HACCP_ID = pTabletBasedSensorInfoPopup_T02Entity.HACCP_ID;
            HACCP_DATE = pTabletBasedSensorInfoPopup_T02Entity.HACCP_DATE;
            HACCP_SEQ = pTabletBasedSensorInfoPopup_T02Entity.HACCP_SEQ;
            PROCESS_NAME = pTabletBasedSensorInfoPopup_T02Entity.PROCESS_NAME;
            REQUEST_DEPT = pTabletBasedSensorInfoPopup_T02Entity.REQUEST_DEPT;
            CODE_NAME = pTabletBasedSensorInfoPopup_T02Entity.CODE_NAME;
            INOUT_DATE = pTabletBasedSensorInfoPopup_T02Entity.INOUT_DATE;
            INOUT_QTY = pTabletBasedSensorInfoPopup_T02Entity.INOUT_QTY;
            PACKING_REMARK = pTabletBasedSensorInfoPopup_T02Entity.PACKING_REMARK;
            SAMPLE_DEPT = pTabletBasedSensorInfoPopup_T02Entity.SAMPLE_DEPT;
            SAMPLE_NO = pTabletBasedSensorInfoPopup_T02Entity.SAMPLE_NO;
            SAMPLE_USER = pTabletBasedSensorInfoPopup_T02Entity.SAMPLE_USER;
            REMARK = pTabletBasedSensorInfoPopup_T02Entity.REMARK;
            USER_YN = pTabletBasedSensorInfoPopup_T02Entity.USER_YN;
            dtListCnt = pTabletBasedSensorInfoPopup_T02Entity.dtListCnt;

            MISSING_CHECK = pTabletBasedSensorInfoPopup_T02Entity.MISSING_CHECK;

            ERR_NO = pTabletBasedSensorInfoPopup_T02Entity.ERR_NO;
            ERR_MSG = pTabletBasedSensorInfoPopup_T02Entity.ERR_MSG;
            RTN_KEY = pTabletBasedSensorInfoPopup_T02Entity.RTN_KEY;
            RTN_SEQ = pTabletBasedSensorInfoPopup_T02Entity.RTN_SEQ;
            RTN_OTHERS = pTabletBasedSensorInfoPopup_T02Entity.RTN_OTHERS;

            LANGUAGE_TYPE = pTabletBasedSensorInfoPopup_T02Entity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ResourceCodeInfoPopUpEntity
    {
        #region Property

        //사용자 설정 엔티티
        public String CORP_CODE { get; set; } // 
        public String PART_CODE { get; set; } // 
        public String PART_NAME { get; set; } //
        public String PART_TYPE { get; set; }
        public String CRUD { get; set; } // 
        public String LANGUAGE_TYPE { get; set; }
        public String FROM_DATE { get; set; }
        public String TO_DATE { get; set; }
        public String INTERVAL { get; set; }
        public String RESOURCE_CODE { get; set; }
        public String RESOURCE_NAME { get; set; }
        public String RESOURCE_MIN_1 { get; set; }
        public String RESOURCE_MAX_1 { get; set; }
        public String RESOURCE_MIN_2 { get; set; }
        public String RESOURCE_MAX_2 { get; set; }
        public String RESOURCE_MIN_3 { get; set; }
        public String RESOURCE_MAX_3 { get; set; }
        public String RESOURCE_MIN_4 { get; set; }
        public String RESOURCE_MAX_4 { get; set; }
        public String RESOURCE_MIN_5 { get; set; }
        public String RESOURCE_MAX_5 { get; set; }
        public String USE_YN { get; set; }
        public String SensorCnt { get; set; }
        public String REMARK { get; set; }
        public String WINDOW_NAME { get; set; }
        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }

        #endregion

        #region 생성자 - ResourceCodeInfoPopUpEntity()

        public ResourceCodeInfoPopUpEntity()
        {
        }

        #endregion

        #region 생성자 - PartCodePopUpEntity(ResourceCodeInfoPopUpEntity pResourceCodeInfoPopUpEntity)

        public ResourceCodeInfoPopUpEntity(ResourceCodeInfoPopUpEntity pResourceCodeInfoPopUpEntity)
        {
            CORP_CODE = pResourceCodeInfoPopUpEntity.CORP_CODE;
            PART_CODE = pResourceCodeInfoPopUpEntity.PART_CODE;
            PART_NAME = pResourceCodeInfoPopUpEntity.PART_NAME;
            PART_TYPE = pResourceCodeInfoPopUpEntity.PART_TYPE;
            CRUD = pResourceCodeInfoPopUpEntity.CRUD;
            LANGUAGE_TYPE = pResourceCodeInfoPopUpEntity.LANGUAGE_TYPE;
            pResourceCodeInfoPopUpEntity.FROM_DATE = FROM_DATE;
            pResourceCodeInfoPopUpEntity.TO_DATE = TO_DATE;
            pResourceCodeInfoPopUpEntity.INTERVAL = INTERVAL;
            pResourceCodeInfoPopUpEntity.RESOURCE_CODE = RESOURCE_CODE;
            pResourceCodeInfoPopUpEntity.RESOURCE_MIN_1 = RESOURCE_MIN_1;
            pResourceCodeInfoPopUpEntity.RESOURCE_MAX_1 = RESOURCE_MAX_1;
            pResourceCodeInfoPopUpEntity.RESOURCE_MIN_2 = RESOURCE_MIN_2;
            pResourceCodeInfoPopUpEntity.RESOURCE_MAX_2 = RESOURCE_MAX_2;
            pResourceCodeInfoPopUpEntity.RESOURCE_MIN_3 = RESOURCE_MIN_3;
            pResourceCodeInfoPopUpEntity.RESOURCE_MAX_3 = RESOURCE_MAX_3;
            pResourceCodeInfoPopUpEntity.RESOURCE_MIN_4 = RESOURCE_MIN_4;
            pResourceCodeInfoPopUpEntity.RESOURCE_MAX_4 = RESOURCE_MAX_4;
            pResourceCodeInfoPopUpEntity.RESOURCE_MIN_5 = RESOURCE_MIN_5;
            pResourceCodeInfoPopUpEntity.RESOURCE_MAX_5 = RESOURCE_MAX_5;
            pResourceCodeInfoPopUpEntity.REMARK = REMARK;
            WINDOW_NAME = pResourceCodeInfoPopUpEntity.WINDOW_NAME;
            SensorCnt = pResourceCodeInfoPopUpEntity.SensorCnt;
            ERR_NO = pResourceCodeInfoPopUpEntity.ERR_NO;
            ERR_MSG = pResourceCodeInfoPopUpEntity.ERR_MSG;
            RTN_KEY = pResourceCodeInfoPopUpEntity.RTN_KEY;
            RTN_SEQ = pResourceCodeInfoPopUpEntity.RTN_SEQ;
            RTN_OTHERS = pResourceCodeInfoPopUpEntity.RTN_OTHERS;
        }

        #endregion
    }

    public class ucEquipmentInspectInfoPopupEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // 언어 정보 값

        public String PART_CODE_MST { get; set; }
        public String WORKORDER_ID { get; set; }
        public String REFERENCE_ID { get; set; }

        public String DATE { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_AQ { get; set; } // 리턴 순번 값
        public String RTN_SQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - ucEquipmentInspectInfoPopupEntity()

        public ucEquipmentInspectInfoPopupEntity()
        {
        }

        #endregion

        #region 생성자 - ucEquipmentInspectInfoPopupEntity(pucEquipmentInspectInfoPopupEntity)

        public ucEquipmentInspectInfoPopupEntity(ucEquipmentInspectInfoPopupEntity pucEquipmentInspectInfoPopupEntity)
        {
            CORP_CODE = pucEquipmentInspectInfoPopupEntity.CORP_CODE;
            CRUD = pucEquipmentInspectInfoPopupEntity.CRUD;
            USER_CODE = pucEquipmentInspectInfoPopupEntity.USER_CODE;
            LANGUAGE_TYPE = pucEquipmentInspectInfoPopupEntity.LANGUAGE_TYPE;

            PART_CODE_MST = pucEquipmentInspectInfoPopupEntity.PART_CODE_MST;
            WORKORDER_ID = pucEquipmentInspectInfoPopupEntity.WORKORDER_ID;
            REFERENCE_ID = pucEquipmentInspectInfoPopupEntity.REFERENCE_ID;

            DATE = pucEquipmentInspectInfoPopupEntity.DATE;

            ERR_NO = pucEquipmentInspectInfoPopupEntity.ERR_NO;
            ERR_MSG = pucEquipmentInspectInfoPopupEntity.ERR_MSG;
            RTN_KEY = pucEquipmentInspectInfoPopupEntity.RTN_KEY;
            RTN_SEQ = pucEquipmentInspectInfoPopupEntity.RTN_SEQ;
            RTN_AQ = pucEquipmentInspectInfoPopupEntity.RTN_AQ;
            RTN_SQ = pucEquipmentInspectInfoPopupEntity.RTN_SQ;
            RTN_OTHERS = pucEquipmentInspectInfoPopupEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoFAS_MES.UI.SM.Entity
{
    public class CommonCodeRegisterEntity
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

        #region 생성자 - CommonCodeRegisterEntity()

        public CommonCodeRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - CommonCodeRegisterEntity(_pCommonCodeRegisterEntity)

        public CommonCodeRegisterEntity(CommonCodeRegisterEntity _pCommonCodeRegisterEntity)
        {
            CORP_CODE = _pCommonCodeRegisterEntity.CORP_CODE;
            CRUD = _pCommonCodeRegisterEntity.CRUD;
            USER_CODE = _pCommonCodeRegisterEntity.USER_CODE;

            CODE_TYPE = _pCommonCodeRegisterEntity.CODE_TYPE;
            LANGUAGE_TYPE = _pCommonCodeRegisterEntity.LANGUAGE_TYPE;
            WINDOW_NAME = _pCommonCodeRegisterEntity.WINDOW_NAME;
            FIELD_CODE = _pCommonCodeRegisterEntity.FIELD_CODE;
            FIELD_NAME = _pCommonCodeRegisterEntity.FIELD_NAME;
            FIELD_DESC = _pCommonCodeRegisterEntity.FIELD_DESC;
            CODE = _pCommonCodeRegisterEntity.CODE;
            REMARK = _pCommonCodeRegisterEntity.REMARK;
            USE_YN = _pCommonCodeRegisterEntity.USE_YN;

            ERR_NO = _pCommonCodeRegisterEntity.ERR_NO;
            ERR_MSG = _pCommonCodeRegisterEntity.ERR_MSG;
            RTN_KEY = _pCommonCodeRegisterEntity.RTN_KEY;
            RTN_SEQ = _pCommonCodeRegisterEntity.RTN_SEQ;
            RTN_OTHERS = _pCommonCodeRegisterEntity.RTN_OTHERS;
        }

        #endregion

    }

    public class CorporationInformationEntity
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
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE

        //고정 엔티티


        //메뉴별 추가 엔티티 입력

        public String CORP_NAME { get; set; }
        public String CORP_ENG_NAME { get; set; }
        public String CORP_EIN { get; set; }
        public String CORP_SSN { get; set; }
        public String CORP_CEO_NAME { get; set; }
        public String CORP_BUSINESS_OPENDATE { get; set; }
        public String CORP_TEL { get; set; }
        public String CORP_FAX { get; set; }
        public String CORP_MAIL { get; set; }
        public String CORP_ADDRESS_1 { get; set; }
        public String CORP_ADDRESS_2 { get; set; }
        public String CORP_BUSINESS { get; set; }
        public String CORP_BUSINESS_TYPE { get; set; }
        public String CORP_SERVER_ID { get; set; }

        public String MAIL_SERVER_IP { get; set; }
        public Int32 MAIL_SERVER_PORT { get; set; }
        public String MAIL_SERVER_ID { get; set; }
        public String MAIL_SERVER_PASSWORD { get; set; }
        public String MAIL_SERVER_SSL { get; set; }


        public String REMARK { get; set; }
        public String USE_YN { get; set; }
        public string LOGO_FIRST_NAME { get; set; }
        public byte[] LOGO_FIRST { get; set; }
        public string LOGO_SECOND_NAME { get; set; }
        public byte[] LOGO_SECOND { get; set; }
        public string IMAGE_CHOICE { get; set; }
        public string CORP_REGISTRATION_NAME { get; set; }
        public byte[] CORP_REGISTRATION { get; set; }

        #endregion

        #region 생성자 - CorporationInformationEntity()

        public CorporationInformationEntity()
        {
        }

        #endregion

        #region 생성자 - CorporationInformationEntity(pCorporationInformationEntity)

        public CorporationInformationEntity(CorporationInformationEntity pCorporationInformationEntity)
        {
            CORP_CODE = pCorporationInformationEntity.CORP_CODE;
            CRUD = pCorporationInformationEntity.CRUD;
            USER_CODE = pCorporationInformationEntity.USER_CODE;
            ERR_NO = pCorporationInformationEntity.ERR_NO;
            ERR_MSG = pCorporationInformationEntity.ERR_MSG;
            RTN_KEY = pCorporationInformationEntity.RTN_KEY;
            RTN_SEQ = pCorporationInformationEntity.RTN_SEQ;
            RTN_OTHERS = pCorporationInformationEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            CORP_NAME = pCorporationInformationEntity.CORP_NAME;
            CORP_ENG_NAME = pCorporationInformationEntity.CORP_ENG_NAME;
            CORP_EIN = pCorporationInformationEntity.CORP_EIN;
            CORP_SSN = pCorporationInformationEntity.CORP_SSN;
            CORP_CEO_NAME = pCorporationInformationEntity.CORP_CEO_NAME;
            CORP_BUSINESS_OPENDATE = pCorporationInformationEntity.CORP_BUSINESS_OPENDATE;
            CORP_TEL = pCorporationInformationEntity.CORP_TEL;
            CORP_FAX = pCorporationInformationEntity.CORP_FAX;
            CORP_MAIL = pCorporationInformationEntity.CORP_MAIL;
            CORP_ADDRESS_1 = pCorporationInformationEntity.CORP_ADDRESS_1;
            CORP_ADDRESS_2 = pCorporationInformationEntity.CORP_ADDRESS_2;
            CORP_BUSINESS = pCorporationInformationEntity.CORP_BUSINESS;
            CORP_BUSINESS_TYPE = pCorporationInformationEntity.CORP_BUSINESS_TYPE;
            CORP_SERVER_ID = pCorporationInformationEntity.CORP_SERVER_ID;

            MAIL_SERVER_IP = pCorporationInformationEntity.MAIL_SERVER_IP;
            MAIL_SERVER_PORT = pCorporationInformationEntity.MAIL_SERVER_PORT;
            MAIL_SERVER_ID = pCorporationInformationEntity.MAIL_SERVER_ID;
            MAIL_SERVER_PASSWORD = pCorporationInformationEntity.MAIL_SERVER_PASSWORD;
            MAIL_SERVER_SSL = pCorporationInformationEntity.MAIL_SERVER_SSL;

            REMARK = pCorporationInformationEntity.REMARK;
            USE_YN = pCorporationInformationEntity.USE_YN;
            LANGUAGE_TYPE = pCorporationInformationEntity.LANGUAGE_TYPE;
            LOGO_FIRST = pCorporationInformationEntity.LOGO_FIRST;
            LOGO_FIRST_NAME = pCorporationInformationEntity.LOGO_FIRST_NAME;
            LOGO_SECOND = pCorporationInformationEntity.LOGO_SECOND;
            LOGO_SECOND_NAME = pCorporationInformationEntity.LOGO_SECOND_NAME;
            IMAGE_CHOICE = pCorporationInformationEntity.IMAGE_CHOICE;
        }

        #endregion

    }

    public class UserInformationEntity
    {
        #region Property

        //사용자 설정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE



        public String USER_ACCOUNT { get; set; }
        public String USER_MAIL { get; set; }
        public String MAIL_RECEIVE_CHECK { get; set; }
        public String USER_ID { get; set; }
        public String USER_PASSWORD { get; set; }
        public String USER_NAME { get; set; }
        public String USER_GRANT { get; set; }
        public String USER_IMAGE_NAME { get; set; }
        public Byte[] USER_IMAGE { get; set; }
        public String USER_EMP_NUMBER { get; set; }
        public String USER_DEPARTMENT { get; set; }
        public String USER_JOB_TITLE { get; set; }
        public String USER_TEL { get; set; }
        public String USER_TEL_NUMBER { get; set; }
        public String USER_FAX { get; set; }
        public String USER_ENTRY_DATE { get; set; }
        public String USER_LEAVING_DATE { get; set; }

        public String REMARK { get; set; } // 비고
        public String USE_YN { get; set; } // 사용유무


        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }


        public String FILE_TYPE { get; set; }

        #endregion

        #region 생성자 - UserInformationEntity()

        public UserInformationEntity()
        {
        }

        #endregion

        #region 생성자 - UserInformationEntity(pUserInformationEntity)

        public UserInformationEntity(UserInformationEntity pUserInformationEntity)
        {
         // CORP_CODE = pUserInformationEntity.CORP_CODE;
            CRUD = pUserInformationEntity.CRUD;
            USER_CODE = pUserInformationEntity.USER_CODE;

            USER_ACCOUNT = pUserInformationEntity.USER_ACCOUNT;
            USER_MAIL = pUserInformationEntity.USER_MAIL;
            MAIL_RECEIVE_CHECK = pUserInformationEntity.MAIL_RECEIVE_CHECK;
            USER_ID = pUserInformationEntity.USER_ID;
            USER_PASSWORD = pUserInformationEntity.USER_PASSWORD;
            USER_NAME = pUserInformationEntity.USER_NAME;
            USER_GRANT = pUserInformationEntity.USER_GRANT;
            USER_IMAGE_NAME = pUserInformationEntity.USER_IMAGE_NAME;
            USER_IMAGE = pUserInformationEntity.USER_IMAGE;
            USER_EMP_NUMBER = pUserInformationEntity.USER_EMP_NUMBER;
            USER_DEPARTMENT = pUserInformationEntity.USER_DEPARTMENT;
            USER_JOB_TITLE = pUserInformationEntity.USER_JOB_TITLE;
            USER_TEL = pUserInformationEntity.USER_TEL;
            USER_TEL_NUMBER = pUserInformationEntity.USER_TEL_NUMBER;
            USER_FAX = pUserInformationEntity.USER_FAX;
            USER_ENTRY_DATE = pUserInformationEntity.USER_ENTRY_DATE;
            USER_LEAVING_DATE = pUserInformationEntity.USER_LEAVING_DATE;

            REMARK = pUserInformationEntity.REMARK;
            USE_YN = pUserInformationEntity.USE_YN;

            ERR_NO = pUserInformationEntity.ERR_NO;
            ERR_MSG = pUserInformationEntity.ERR_MSG;
            RTN_KEY = pUserInformationEntity.RTN_KEY;
            RTN_SEQ = pUserInformationEntity.RTN_SEQ;
            RTN_OTHERS = pUserInformationEntity.RTN_OTHERS;

            FILE_TYPE = pUserInformationEntity.FILE_TYPE;
            LANGUAGE_TYPE = pUserInformationEntity.LANGUAGE_TYPE;
        }

        #endregion

    }

    public class SheetInfoRegisterEntity
    {
        #region Property
        //사용자 설정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE


        //마스터
        public String WINDOW_NAME { get; set; } // 화면 아이디
        public String SHEETINFO_ID { get; set; } // 엑셀파일 코드
        public String FILE_NAME { get; set; } // 파일 아이디
        public String PROCESS_CODE { get; set; }
        public String FILE_TYPE     { get; set; }
        public String USE_VEND_CODE { get; set; } // 사용업체명
        public String USE_TYPE { get; set; } // 사용화면명
        public String REMARK { get; set; }
        public String USE_YN { get; set; }


        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }

        #endregion

        #region 생성자 - SheetInfoRegisterEntity()

        public SheetInfoRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - SheetInfoRegisterEntity(pSheetInfoRegisterEntity)

        public SheetInfoRegisterEntity(SheetInfoRegisterEntity pSheetInfoRegisterEntity)
        {
            CORP_CODE = pSheetInfoRegisterEntity.CORP_CODE;
            CRUD = pSheetInfoRegisterEntity.CRUD;
            USER_CODE = pSheetInfoRegisterEntity.USER_CODE;
            LANGUAGE_TYPE = pSheetInfoRegisterEntity.LANGUAGE_TYPE;
            //마스터
            WINDOW_NAME = pSheetInfoRegisterEntity.WINDOW_NAME;
            SHEETINFO_ID = pSheetInfoRegisterEntity.SHEETINFO_ID;
            FILE_NAME = pSheetInfoRegisterEntity.FILE_NAME;
            USE_VEND_CODE = pSheetInfoRegisterEntity.USE_VEND_CODE;
            USE_TYPE = pSheetInfoRegisterEntity.USE_TYPE;
            PROCESS_CODE = pSheetInfoRegisterEntity.PROCESS_CODE;
            FILE_TYPE = pSheetInfoRegisterEntity.FILE_TYPE;
            REMARK = pSheetInfoRegisterEntity.REMARK;
            USE_YN = pSheetInfoRegisterEntity.USE_YN;

            ERR_NO = pSheetInfoRegisterEntity.ERR_NO;
            ERR_MSG = pSheetInfoRegisterEntity.ERR_MSG;
            RTN_KEY = pSheetInfoRegisterEntity.RTN_KEY;
            RTN_SEQ = pSheetInfoRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pSheetInfoRegisterEntity.RTN_OTHERS;
        }
        #endregion
    }

    public class MenuAuthorityEntity
    {
        #region Property

        //사용자 설정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD

        public String USER_ACCOUNT { get; set; } // 사용자 아이디
        public String USER_NAME { get; set; } // 사용자 명

        public String CODE_TYPE { get; set; } // 컨트롤러 타입 구분
        public String LANGUAGE_TYPE { get; set; } //언어구분
        public String WINDOW_NAME { get; set; } // 화면 아이디
        public String FIELD_CODE { get; set; } // 필드 아이디
        public String FIELD_NAME { get; set; } // 필드 명칭
        public String FIELD_DESC { get; set; } // 필드 설명
        public String REMARK { get; set; } // 비고
        public String CODE { get; set; }
        public String USE_YN { get; set; } // 사용유무


        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }


        #endregion

        #region 생성자 - CommonCodeRegisterEntity()

        public MenuAuthorityEntity()
        {
        }

        #endregion

        #region 생성자 - MenuAuthorityEntity(_pMenuAuthorityEntity)

        public MenuAuthorityEntity(MenuAuthorityEntity _pMenuAuthorityEntity)
        {
            CORP_CODE = _pMenuAuthorityEntity.CORP_CODE;
            CRUD = _pMenuAuthorityEntity.CRUD;
            USER_CODE = _pMenuAuthorityEntity.USER_CODE;

            USER_ACCOUNT = _pMenuAuthorityEntity.USER_ACCOUNT;

            CODE_TYPE = _pMenuAuthorityEntity.CODE_TYPE;
            LANGUAGE_TYPE = _pMenuAuthorityEntity.LANGUAGE_TYPE;
            WINDOW_NAME = _pMenuAuthorityEntity.WINDOW_NAME;
            FIELD_CODE = _pMenuAuthorityEntity.FIELD_CODE;
            FIELD_NAME = _pMenuAuthorityEntity.FIELD_NAME;
            FIELD_DESC = _pMenuAuthorityEntity.FIELD_DESC;
            CODE = _pMenuAuthorityEntity.CODE;
            REMARK = _pMenuAuthorityEntity.REMARK;
            USE_YN = _pMenuAuthorityEntity.USE_YN;

            ERR_NO = _pMenuAuthorityEntity.ERR_NO;
            ERR_MSG = _pMenuAuthorityEntity.ERR_MSG;
            RTN_KEY = _pMenuAuthorityEntity.RTN_KEY;
            RTN_SEQ = _pMenuAuthorityEntity.RTN_SEQ;
            RTN_OTHERS = _pMenuAuthorityEntity.RTN_OTHERS;
        }

        #endregion

    }

    public class MenuAuthority_T01Entity
    {
        #region Property

        //사용자 설정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD

        public String USER_ACCOUNT { get; set; } // 사용자 아이디
        public String USER_NAME { get; set; } // 사용자 명

        public String CODE_TYPE { get; set; } // 컨트롤러 타입 구분
        public String LANGUAGE_TYPE { get; set; } //언어구분
        public String WINDOW_NAME { get; set; } // 화면 아이디
        public String FIELD_CODE { get; set; } // 필드 아이디
        public String FIELD_NAME { get; set; } // 필드 명칭
        public String FIELD_DESC { get; set; } // 필드 설명
        public String REMARK { get; set; } // 비고
        public String CODE { get; set; }
        public String USE_YN { get; set; } // 사용유무


        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }


        #endregion

        #region 생성자 - CommonCodeRegisterEntity()

        public MenuAuthority_T01Entity()
        {
        }

        #endregion

        #region 생성자 - MenuAuthority_T01Entity(_pMenuAuthority_T01Entity)

        public MenuAuthority_T01Entity(MenuAuthority_T01Entity _pMenuAuthority_T01Entity)
        {
            CORP_CODE = _pMenuAuthority_T01Entity.CORP_CODE;
            CRUD = _pMenuAuthority_T01Entity.CRUD;
            USER_CODE = _pMenuAuthority_T01Entity.USER_CODE;

            USER_ACCOUNT = _pMenuAuthority_T01Entity.USER_ACCOUNT;

            CODE_TYPE = _pMenuAuthority_T01Entity.CODE_TYPE;
            LANGUAGE_TYPE = _pMenuAuthority_T01Entity.LANGUAGE_TYPE;
            WINDOW_NAME = _pMenuAuthority_T01Entity.WINDOW_NAME;
            FIELD_CODE = _pMenuAuthority_T01Entity.FIELD_CODE;
            FIELD_NAME = _pMenuAuthority_T01Entity.FIELD_NAME;
            FIELD_DESC = _pMenuAuthority_T01Entity.FIELD_DESC;
            CODE = _pMenuAuthority_T01Entity.CODE;
            REMARK = _pMenuAuthority_T01Entity.REMARK;
            USE_YN = _pMenuAuthority_T01Entity.USE_YN;

            ERR_NO = _pMenuAuthority_T01Entity.ERR_NO;
            ERR_MSG = _pMenuAuthority_T01Entity.ERR_MSG;
            RTN_KEY = _pMenuAuthority_T01Entity.RTN_KEY;
            RTN_SEQ = _pMenuAuthority_T01Entity.RTN_SEQ;
            RTN_OTHERS = _pMenuAuthority_T01Entity.RTN_OTHERS;
        }

        #endregion

    }
    public class MenuAuthority_T02Entity
    {
        #region Property

        //사용자 설정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD

        public String USER_ACCOUNT { get; set; } // 사용자 아이디
        public String USER_NAME { get; set; } // 사용자 명

        public String CODE_TYPE { get; set; } // 컨트롤러 타입 구분
        public String LANGUAGE_TYPE { get; set; } //언어구분
        public String WINDOW_NAME { get; set; } // 화면 아이디
        public String FIELD_CODE { get; set; } // 필드 아이디
        public String FIELD_NAME { get; set; } // 필드 명칭
        public String FIELD_DESC { get; set; } // 필드 설명
        public String REMARK { get; set; } // 비고
        public String CODE { get; set; }
        public String USE_YN { get; set; } // 사용유무
        public String COPY_USER_ID { get; set; } // 
        

        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }


        #endregion

        #region 생성자 - CommonCodeRegisterEntity()

        public MenuAuthority_T02Entity()
        {
        }

        #endregion

        #region 생성자 - MenuAuthority_T02Entity(_pMenuAuthority_T02Entity)

        public MenuAuthority_T02Entity(MenuAuthority_T02Entity _pMenuAuthority_T02Entity)
        {
            CORP_CODE = _pMenuAuthority_T02Entity.CORP_CODE;
            CRUD = _pMenuAuthority_T02Entity.CRUD;
            USER_CODE = _pMenuAuthority_T02Entity.USER_CODE;

            USER_ACCOUNT = _pMenuAuthority_T02Entity.USER_ACCOUNT;

            CODE_TYPE = _pMenuAuthority_T02Entity.CODE_TYPE;
            LANGUAGE_TYPE = _pMenuAuthority_T02Entity.LANGUAGE_TYPE;
            WINDOW_NAME = _pMenuAuthority_T02Entity.WINDOW_NAME;
            FIELD_CODE = _pMenuAuthority_T02Entity.FIELD_CODE;
            FIELD_NAME = _pMenuAuthority_T02Entity.FIELD_NAME;
            FIELD_DESC = _pMenuAuthority_T02Entity.FIELD_DESC;
            CODE = _pMenuAuthority_T02Entity.CODE;
            REMARK = _pMenuAuthority_T02Entity.REMARK;
            USE_YN = _pMenuAuthority_T02Entity.USE_YN;
            COPY_USER_ID = _pMenuAuthority_T02Entity.COPY_USER_ID;
            

            ERR_NO = _pMenuAuthority_T02Entity.ERR_NO;
            ERR_MSG = _pMenuAuthority_T02Entity.ERR_MSG;
            RTN_KEY = _pMenuAuthority_T02Entity.RTN_KEY;
            RTN_SEQ = _pMenuAuthority_T02Entity.RTN_SEQ;
            RTN_OTHERS = _pMenuAuthority_T02Entity.RTN_OTHERS;
        }

        #endregion

    }

    public class GroupMenuAuthorityEntity
    {
        #region Property

        //사용자 설정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String GROUP_CODE { get; set; } // 그룹 정보
        public String CRUD { get; set; } // CRUD
        public String USER_CODE { get; set; } // 사용자 정보

        public String GROUP_ACCOUNT { get; set; } // 사용자 아이디
        public String GROUP_NAME { get; set; } // 사용자 명

        public String CODE_TYPE { get; set; } // 컨트롤러 타입 구분
        public String LANGUAGE_TYPE { get; set; } //언어구분
        public String WINDOW_NAME { get; set; } // 화면 아이디
        public String FIELD_CODE { get; set; } // 필드 아이디
        public String FIELD_NAME { get; set; } // 필드 명칭
        public String FIELD_DESC { get; set; } // 필드 설명
        public String REMARK { get; set; } // 비고
        public String CODE { get; set; }
        public String USE_YN { get; set; } // 사용유무


        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }


        #endregion

        #region 생성자 - CommonCodeRegisterEntity()

        public GroupMenuAuthorityEntity()
        {
        }

        #endregion

        #region 생성자 - GroupMenuAuthorityEntity(_pGroupMenuAuthorityEntity)

        public GroupMenuAuthorityEntity(GroupMenuAuthorityEntity _pGroupMenuAuthorityEntity)
        {
            CORP_CODE = _pGroupMenuAuthorityEntity.CORP_CODE;
            CRUD = _pGroupMenuAuthorityEntity.CRUD;
            GROUP_CODE = _pGroupMenuAuthorityEntity.GROUP_CODE;
            USER_CODE = _pGroupMenuAuthorityEntity.USER_CODE;

            GROUP_ACCOUNT = _pGroupMenuAuthorityEntity.GROUP_ACCOUNT;

            CODE_TYPE = _pGroupMenuAuthorityEntity.CODE_TYPE;
            LANGUAGE_TYPE = _pGroupMenuAuthorityEntity.LANGUAGE_TYPE;
            WINDOW_NAME = _pGroupMenuAuthorityEntity.WINDOW_NAME;
            FIELD_CODE = _pGroupMenuAuthorityEntity.FIELD_CODE;
            FIELD_NAME = _pGroupMenuAuthorityEntity.FIELD_NAME;
            FIELD_DESC = _pGroupMenuAuthorityEntity.FIELD_DESC;
            CODE = _pGroupMenuAuthorityEntity.CODE;
            REMARK = _pGroupMenuAuthorityEntity.REMARK;
            USE_YN = _pGroupMenuAuthorityEntity.USE_YN;

            ERR_NO = _pGroupMenuAuthorityEntity.ERR_NO;
            ERR_MSG = _pGroupMenuAuthorityEntity.ERR_MSG;
            RTN_KEY = _pGroupMenuAuthorityEntity.RTN_KEY;
            RTN_SEQ = _pGroupMenuAuthorityEntity.RTN_SEQ;
            RTN_OTHERS = _pGroupMenuAuthorityEntity.RTN_OTHERS;
        }

        #endregion

    }



    public class UserScreenPermissionsRegisterEntity
    {
        #region Property

        //사용자 설정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD

        public String USER_ACCOUNT { get; set; } // 사용자 아이디
        public String USER_NAME { get; set; } // 사용자 명

        public String CODE_TYPE { get; set; } // 컨트롤러 타입 구분
        public String LANGUAGE_TYPE { get; set; } //언어구분
        public String WINDOW_NAME { get; set; } // 화면 아이디
        public String FIELD_CODE { get; set; } // 필드 아이디
        public String FIELD_NAME { get; set; } // 필드 명칭
        public String FIELD_DESC { get; set; } // 필드 설명
        public String REMARK { get; set; } // 비고
        public String CODE { get; set; }
        public String USE_YN { get; set; } // 사용유무


        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }


        #endregion

        #region 생성자 - UserScreenPermissionsRegisterEntity()

        public UserScreenPermissionsRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - UserScreenPermissionsRegisterEntity(_pUserScreenPermissionsRegisterEntity)

        public UserScreenPermissionsRegisterEntity(UserScreenPermissionsRegisterEntity _pUserScreenPermissionsRegisterEntity)
        {
            CORP_CODE = _pUserScreenPermissionsRegisterEntity.CORP_CODE;
            CRUD = _pUserScreenPermissionsRegisterEntity.CRUD;
            USER_CODE = _pUserScreenPermissionsRegisterEntity.USER_CODE;

            USER_ACCOUNT = _pUserScreenPermissionsRegisterEntity.USER_ACCOUNT;

            CODE_TYPE = _pUserScreenPermissionsRegisterEntity.CODE_TYPE;
            LANGUAGE_TYPE = _pUserScreenPermissionsRegisterEntity.LANGUAGE_TYPE;
            WINDOW_NAME = _pUserScreenPermissionsRegisterEntity.WINDOW_NAME;
            FIELD_CODE = _pUserScreenPermissionsRegisterEntity.FIELD_CODE;
            FIELD_NAME = _pUserScreenPermissionsRegisterEntity.FIELD_NAME;
            FIELD_DESC = _pUserScreenPermissionsRegisterEntity.FIELD_DESC;
            CODE = _pUserScreenPermissionsRegisterEntity.CODE;
            REMARK = _pUserScreenPermissionsRegisterEntity.REMARK;
            USE_YN = _pUserScreenPermissionsRegisterEntity.USE_YN;

            ERR_NO = _pUserScreenPermissionsRegisterEntity.ERR_NO;
            ERR_MSG = _pUserScreenPermissionsRegisterEntity.ERR_MSG;
            RTN_KEY = _pUserScreenPermissionsRegisterEntity.RTN_KEY;
            RTN_SEQ = _pUserScreenPermissionsRegisterEntity.RTN_SEQ;
            RTN_OTHERS = _pUserScreenPermissionsRegisterEntity.RTN_OTHERS;
        }

        #endregion

    }

    public class Teamviewer_Info_T01Entity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE
        //마스터
        public String PART_CODE { get; set; }
        public String PART_REVISION_NO { get; set; }
        public String PART_NAME { get; set; }
        public String PART_TYPE { get; set; }
        public String VEND_PART_CODE { get; set; }
        public String PART_UNIT { get; set; }
        public String PART_STANDARD { get; set; }
        public String PART_MANUFACTURER { get; set; }
        public String PART_COST { get; set; }
        public String PART_SAFE_STOCK { get; set; }
        public String PART_START_DATE { get; set; }
        public String PART_END_DATE { get; set; }
        public String SALE_YN { get; set; }
        public String PURC_YN { get; set; }
        public String OUTT_YN { get; set; }
        public String REMARK { get; set; }
        public String IMAGE_NAME { get; set; }
        public String USE_YN { get; set; }
        public String TEAMVIEWER_ID { get; set; }
        public String TEAMVIEWER_PW { get; set; }
        public String TEAMVIEWER_NAME { get; set; }
        public String TEAMVIEWER_VEND { get; set; }
        public String TEAMVIEWER_ADMIN { get; set; }

        public String VEND_CODE { get; set; } // 단가 조회 (상세)

        //고정 엔티티

        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }

        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - Teamviewer_Info_T01Entity()

        public Teamviewer_Info_T01Entity()
        {
        }

        #endregion

        #region 생성자 - Teamviewer_Info_T01Entity(pTeamviewer_Info_T01Entity)

        public Teamviewer_Info_T01Entity(Teamviewer_Info_T01Entity pTeamviewer_Info_T01Entity)
        {
            CORP_CODE = pTeamviewer_Info_T01Entity.CORP_CODE;
            CRUD = pTeamviewer_Info_T01Entity.CRUD;
            PART_CODE = pTeamviewer_Info_T01Entity.PART_CODE;
            PART_REVISION_NO = pTeamviewer_Info_T01Entity.PART_REVISION_NO;
            PART_NAME = pTeamviewer_Info_T01Entity.PART_NAME;
            PART_TYPE = pTeamviewer_Info_T01Entity.PART_TYPE;
            VEND_PART_CODE = pTeamviewer_Info_T01Entity.VEND_PART_CODE;
            PART_UNIT = pTeamviewer_Info_T01Entity.PART_UNIT;
            PART_STANDARD = pTeamviewer_Info_T01Entity.PART_STANDARD;
            PART_MANUFACTURER = pTeamviewer_Info_T01Entity.PART_MANUFACTURER;
            PART_COST = pTeamviewer_Info_T01Entity.PART_COST;
            PART_SAFE_STOCK = pTeamviewer_Info_T01Entity.PART_SAFE_STOCK;
            PART_START_DATE = pTeamviewer_Info_T01Entity.PART_START_DATE;
            PART_END_DATE = pTeamviewer_Info_T01Entity.PART_END_DATE;
            SALE_YN = pTeamviewer_Info_T01Entity.SALE_YN;
            PURC_YN = pTeamviewer_Info_T01Entity.PURC_YN;
            OUTT_YN = pTeamviewer_Info_T01Entity.OUTT_YN;
            USE_YN = pTeamviewer_Info_T01Entity.USE_YN;
            REMARK = pTeamviewer_Info_T01Entity.REMARK;
            IMAGE_NAME = pTeamviewer_Info_T01Entity.IMAGE_NAME;


            LANGUAGE_TYPE = pTeamviewer_Info_T01Entity.LANGUAGE_TYPE;


            VEND_CODE = pTeamviewer_Info_T01Entity.VEND_CODE;

            ERR_NO = pTeamviewer_Info_T01Entity.ERR_NO;
            ERR_MSG = pTeamviewer_Info_T01Entity.ERR_MSG;
            RTN_KEY = pTeamviewer_Info_T01Entity.RTN_KEY;
            RTN_SEQ = pTeamviewer_Info_T01Entity.RTN_SEQ;
            RTN_OTHERS = pTeamviewer_Info_T01Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class GroupUserMailingEntity
    {
        #region Property

        //사용자 설정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD



        public String LANGUAGE_TYPE { get; set; } //언어구분
        public String WINDOW_NAME { get; set; } // 화면 아이디
        public String USE_YN { get; set; } // 사용유무

        public String RESOURCE_NAME { get; set; }

        public String RESOURCE_CODE { get; set; }

        public String USER_ID { get; set; }


        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }


        #endregion

        #region 생성자 - GroupUserMailingEntity()

        public GroupUserMailingEntity()
        {
        }

        #endregion

        #region 생성자 - GroupUserMailingEntity(_pGroupUserMailingEntity)

        public GroupUserMailingEntity(GroupUserMailingEntity _pGroupUserMailingEntity)
        {
            CORP_CODE = _pGroupUserMailingEntity.CORP_CODE;
            CRUD = _pGroupUserMailingEntity.CRUD;
            USER_CODE = _pGroupUserMailingEntity.USER_CODE;

            LANGUAGE_TYPE = _pGroupUserMailingEntity.LANGUAGE_TYPE;
            WINDOW_NAME = _pGroupUserMailingEntity.WINDOW_NAME;
            USE_YN = _pGroupUserMailingEntity.USE_YN;
            RESOURCE_NAME = _pGroupUserMailingEntity.RESOURCE_NAME;
            RESOURCE_CODE = _pGroupUserMailingEntity.RESOURCE_CODE;
            USER_ID = _pGroupUserMailingEntity.USER_ID;

            ERR_NO = _pGroupUserMailingEntity.ERR_NO;
            ERR_MSG = _pGroupUserMailingEntity.ERR_MSG;
            RTN_KEY = _pGroupUserMailingEntity.RTN_KEY;
            RTN_SEQ = _pGroupUserMailingEntity.RTN_SEQ;
            RTN_OTHERS = _pGroupUserMailingEntity.RTN_OTHERS;
        }

        #endregion

    }


}

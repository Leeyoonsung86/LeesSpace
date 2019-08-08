using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoFAS_MES.UI.EM.Entity
{
    public class EquipmentCodeMstRegisterEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String LANGUAGE_TYPE { get; set; } //언어구분
        public String CRUD { get; set; } // CRUD
        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티

        //메뉴별 추가 엔티티 입력
        public String EQUIPMENT_MST_CODE { get; set; }
        public String EQUIPMENT_MST_NAME { get; set; }
        public String EQUIPMENT_TYPE { get; set; }
        public String EQUIPMENT_CODE { get; set; }
        public String EQUIPMENT_NAME { get; set; }
        public Byte[] EQUIPMENT_IMAGE { get; set; }
        public String EQUIPMENT_SERIAL_NUMBER { get; set; }
        public String PRODUCE_CONUTRY { get; set; }
        public String PRODUCE_COMPANY { get; set; }
        public String PUCHASE_COMPANY { get; set; }
        public String PURCHASE_PRICE { get; set; }
        public String PURCHASE_DATE { get; set; }

        public String REMARK { get; set; }
        public String USE_YN { get; set; }

        #endregion

        #region 생성자 - EquipmentCodeMstRegisterEntity()

        public EquipmentCodeMstRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - EquipmentCodeMstRegisterEntity(pEquipmentCodeMstRegisterEntity)

        public EquipmentCodeMstRegisterEntity(EquipmentCodeMstRegisterEntity pEquipmentCodeMstRegisterEntity)
        {
            CRUD = pEquipmentCodeMstRegisterEntity.CRUD;
            CORP_CODE = pEquipmentCodeMstRegisterEntity.CORP_CODE;
            USER_CODE = pEquipmentCodeMstRegisterEntity.USER_CODE;
            LANGUAGE_TYPE = pEquipmentCodeMstRegisterEntity.LANGUAGE_TYPE;
            ERR_NO = pEquipmentCodeMstRegisterEntity.ERR_NO;
            ERR_MSG = pEquipmentCodeMstRegisterEntity.ERR_MSG;
            RTN_KEY = pEquipmentCodeMstRegisterEntity.RTN_KEY;
            RTN_SEQ = pEquipmentCodeMstRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pEquipmentCodeMstRegisterEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            EQUIPMENT_MST_CODE = pEquipmentCodeMstRegisterEntity.EQUIPMENT_MST_CODE;
            EQUIPMENT_MST_NAME = pEquipmentCodeMstRegisterEntity.EQUIPMENT_MST_NAME;
            EQUIPMENT_TYPE = pEquipmentCodeMstRegisterEntity.EQUIPMENT_TYPE;
            EQUIPMENT_CODE = pEquipmentCodeMstRegisterEntity.EQUIPMENT_CODE;
            EQUIPMENT_NAME = pEquipmentCodeMstRegisterEntity.EQUIPMENT_NAME;
            EQUIPMENT_IMAGE = pEquipmentCodeMstRegisterEntity.EQUIPMENT_IMAGE;

            PRODUCE_CONUTRY = pEquipmentCodeMstRegisterEntity.PRODUCE_CONUTRY;
            PRODUCE_COMPANY = pEquipmentCodeMstRegisterEntity.PRODUCE_COMPANY;
            PUCHASE_COMPANY = pEquipmentCodeMstRegisterEntity.PUCHASE_COMPANY;
            PURCHASE_PRICE = pEquipmentCodeMstRegisterEntity.PURCHASE_PRICE;
            PURCHASE_DATE = pEquipmentCodeMstRegisterEntity.PURCHASE_DATE;

            REMARK = pEquipmentCodeMstRegisterEntity.REMARK;
            USE_YN = pEquipmentCodeMstRegisterEntity.USE_YN;
        }

        #endregion

    }

    public class EquipmentCheckEntity 
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
        public String SHEETINFO_ID { get; set; }
        public String WINDOW_NAME { get; set; }
        public String PROCESS_CODE { get; set; }
        public String FILE_TYPE { get; set; }
        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        public String USE_YN { get; set; }
        public String FILE_NAME { get; set; }
        public String FILE_NICKNAME { get; set; }
        public String DSP_SEQ { get; set; }
        public String USE_TYPE { get; set; }
        public String REMARK    { get; set; }

        #endregion

        #region 생성자 - EquipmentCheckEntity()

        public EquipmentCheckEntity()
        {
        }

        #endregion

        #region 생성자 - ListofManagementEntity(pListofManagementEntity)

        public EquipmentCheckEntity(EquipmentCheckEntity pEquipmentCheckEntity)
        {
            CORP_CODE = pEquipmentCheckEntity.CORP_CODE;
            CRUD = pEquipmentCheckEntity.CRUD;
            USER_CODE = pEquipmentCheckEntity.USER_CODE;
            ERR_NO = pEquipmentCheckEntity.ERR_NO;
            ERR_MSG = pEquipmentCheckEntity.ERR_MSG;
            RTN_KEY = pEquipmentCheckEntity.RTN_KEY;
            RTN_SEQ = pEquipmentCheckEntity.RTN_SEQ;
            RTN_OTHERS = pEquipmentCheckEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            SHEETINFO_ID = pEquipmentCheckEntity.SHEETINFO_ID;
            WINDOW_NAME = pEquipmentCheckEntity.WINDOW_NAME;
            PROCESS_CODE = pEquipmentCheckEntity.PROCESS_CODE;
            FILE_TYPE = pEquipmentCheckEntity.FILE_TYPE;
            FILE_NICKNAME = pEquipmentCheckEntity.FILE_NICKNAME;
            FILE_NAME = pEquipmentCheckEntity.FILE_NAME;
            DATE_FROM = pEquipmentCheckEntity.DATE_FROM;
            DATE_TO = pEquipmentCheckEntity.DATE_TO;
            USE_YN = pEquipmentCheckEntity.USE_YN;
            DSP_SEQ = pEquipmentCheckEntity.DSP_SEQ;
            USE_TYPE = pEquipmentCheckEntity.USE_TYPE;
            REMARK = pEquipmentCheckEntity.REMARK;
            LANGUAGE_TYPE = pEquipmentCheckEntity.LANGUAGE_TYPE;
        }
        #endregion

    }

    public class ucEquipmentDocumentListPopupEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String WINDOW_NAME { get; set; }
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE

        public String EQUIPMENT_MST_CODE { get; set; }
        public String EQUIPMENT_CODE { get; set; }
        public String DOCUMENT_TYPE { get; set; }
        public String DOCUMENT_NAME { get; set; }
        public String DOCUMENT_VER { get; set; }

        public String USE_YN { get; set; }

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

        #region 생성자 - ucEquipmentDocumentListPopupEntity()

        public ucEquipmentDocumentListPopupEntity()
        {
        }

        #endregion

        #region 생성자 - ucEquipmentDocumentListPopupEntity(ucEquipmentDocumentListPopupEntity pucEquipmentDocumentListPopupEntityEntity)

        public ucEquipmentDocumentListPopupEntity(ucEquipmentDocumentListPopupEntity pucEquipmentDocumentListPopupEntityEntity)
        {
            CORP_CODE = pucEquipmentDocumentListPopupEntityEntity.CORP_CODE;
            CRUD = pucEquipmentDocumentListPopupEntityEntity.CRUD;
            USER_CODE = pucEquipmentDocumentListPopupEntityEntity.USER_CODE;
            LANGUAGE_TYPE = pucEquipmentDocumentListPopupEntityEntity.LANGUAGE_TYPE;
            WINDOW_NAME = pucEquipmentDocumentListPopupEntityEntity.WINDOW_NAME;

            EQUIPMENT_MST_CODE = pucEquipmentDocumentListPopupEntityEntity.EQUIPMENT_MST_CODE;
            EQUIPMENT_CODE = pucEquipmentDocumentListPopupEntityEntity.EQUIPMENT_CODE;

            DOCUMENT_TYPE = pucEquipmentDocumentListPopupEntityEntity.DOCUMENT_TYPE;
            DOCUMENT_NAME = pucEquipmentDocumentListPopupEntityEntity.DOCUMENT_NAME;
            DOCUMENT_VER = pucEquipmentDocumentListPopupEntityEntity.DOCUMENT_VER;

            USE_YN = pucEquipmentDocumentListPopupEntityEntity.USE_YN;

            ERR_NO = pucEquipmentDocumentListPopupEntityEntity.ERR_NO;
            ERR_MSG = pucEquipmentDocumentListPopupEntityEntity.ERR_MSG;
            RTN_KEY = pucEquipmentDocumentListPopupEntityEntity.RTN_KEY;
            RTN_SEQ = pucEquipmentDocumentListPopupEntityEntity.RTN_SEQ;
            RTN_AQ = pucEquipmentDocumentListPopupEntityEntity.RTN_AQ;
            RTN_SQ = pucEquipmentDocumentListPopupEntityEntity.RTN_SQ;
            RTN_OTHERS = pucEquipmentDocumentListPopupEntityEntity.RTN_OTHERS;
            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class EquipmentChangeEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String ERR_NO { get; set; } //오류 번호
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력
        public String SHEETINFO_ID { get; set; }
        public String WINDOW_NAME { get; set; }
        public String PROCESS_CODE { get; set; }
        public String FILE_TYPE { get; set; }
        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        public String USE_YN { get; set; }
        public String FILE_NAME { get; set; }
        public String FILE_NICKNAME { get; set; }
        public String DSP_SEQ { get; set; }
        public String USE_TYPE { get; set; }
        public String REMARK { get; set; }

        #endregion

        #region 생성자 - EquipmentChangeEntity()

        public EquipmentChangeEntity()
        {
        }

        #endregion

        #region 생성자 - EquipmentChangeEntity(EquipmentChangeEntity pEquipmentChangeEntity)

        public EquipmentChangeEntity(EquipmentChangeEntity pEquipmentChangeEntity)
        {
            CORP_CODE = pEquipmentChangeEntity.CORP_CODE;
            CRUD = pEquipmentChangeEntity.CRUD;
            USER_CODE = pEquipmentChangeEntity.USER_CODE;
            ERR_NO = pEquipmentChangeEntity.ERR_NO;
            ERR_MSG = pEquipmentChangeEntity.ERR_MSG;
            RTN_KEY = pEquipmentChangeEntity.RTN_KEY;
            RTN_SEQ = pEquipmentChangeEntity.RTN_SEQ;
            RTN_OTHERS = pEquipmentChangeEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            SHEETINFO_ID = pEquipmentChangeEntity.SHEETINFO_ID;
            WINDOW_NAME = pEquipmentChangeEntity.WINDOW_NAME;
            PROCESS_CODE = pEquipmentChangeEntity.PROCESS_CODE;
            FILE_TYPE = pEquipmentChangeEntity.FILE_TYPE;
            FILE_NICKNAME = pEquipmentChangeEntity.FILE_NICKNAME;
            FILE_NAME = pEquipmentChangeEntity.FILE_NAME;
            DATE_FROM = pEquipmentChangeEntity.DATE_FROM;
            DATE_TO = pEquipmentChangeEntity.DATE_TO;
            USE_YN = pEquipmentChangeEntity.USE_YN;
            DSP_SEQ = pEquipmentChangeEntity.DSP_SEQ;
            USE_TYPE = pEquipmentChangeEntity.USE_TYPE;
            REMARK = pEquipmentChangeEntity.REMARK;
            LANGUAGE_TYPE = pEquipmentChangeEntity.LANGUAGE_TYPE;
        }
        #endregion



    }
    public class EquipmentHistoryEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String WINDOW_NAME { get; set; }
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE


        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        public String PRODUCTION_ORDER_ID { get; set; }
        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String PRODUCTION_PLAN_ID { get; set; }
        public String PROCESS_CODE_MST { get; set; }
        public String PROCESS_CODE { get; set; }
        public String CODE_GUBN { get; set; }
        public String USE_YN { get; set; }
        public String COMPLETE_YN { get; set; }
        public String TERMINAL_CODE { get; set; }
        public String TERMINAL_NAME { get; set; }
        public String CHECK_LIST { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - EquipmentHistoryEntity()

        public EquipmentHistoryEntity()
        {
        }

        #endregion

        #region 생성자 - EquipmentHistoryEntity(WorkResultRegister_T02Entity pWorkResultRegister_T02Entity)

        public EquipmentHistoryEntity(EquipmentHistoryEntity pEquipmentHistoryEntity)
        {
            CORP_CODE = pEquipmentHistoryEntity.CORP_CODE;
            CRUD = pEquipmentHistoryEntity.CRUD;
            USER_CODE = pEquipmentHistoryEntity.USER_CODE;
            WINDOW_NAME = pEquipmentHistoryEntity.WINDOW_NAME;
            LANGUAGE_TYPE = pEquipmentHistoryEntity.LANGUAGE_TYPE;

            DATE_FROM = pEquipmentHistoryEntity.DATE_FROM;
            DATE_TO = pEquipmentHistoryEntity.DATE_TO;
            PRODUCTION_ORDER_ID = pEquipmentHistoryEntity.PRODUCTION_ORDER_ID;
            PART_CODE = pEquipmentHistoryEntity.PART_CODE;
            PART_NAME = pEquipmentHistoryEntity.PART_NAME;
            PRODUCTION_PLAN_ID = pEquipmentHistoryEntity.PRODUCTION_PLAN_ID;
            PROCESS_CODE_MST = pEquipmentHistoryEntity.PROCESS_CODE_MST;
            PROCESS_CODE = pEquipmentHistoryEntity.PROCESS_CODE;
            CODE_GUBN = pEquipmentHistoryEntity.CODE_GUBN;
            USE_YN = pEquipmentHistoryEntity.USE_YN;
            COMPLETE_YN = pEquipmentHistoryEntity.COMPLETE_YN;
            TERMINAL_CODE = pEquipmentHistoryEntity.TERMINAL_CODE;
            TERMINAL_NAME = pEquipmentHistoryEntity.TERMINAL_NAME;
            CHECK_LIST = pEquipmentHistoryEntity.CHECK_LIST;

            ERR_NO = pEquipmentHistoryEntity.ERR_NO;
            ERR_MSG = pEquipmentHistoryEntity.ERR_MSG;
            RTN_KEY = pEquipmentHistoryEntity.RTN_KEY;
            RTN_SEQ = pEquipmentHistoryEntity.RTN_SEQ;
            RTN_OTHERS = pEquipmentHistoryEntity.RTN_OTHERS;


            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }
    public class EquipmentStopHistoryEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String WINDOW_NAME { get; set; }
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE


        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        public String PRODUCTION_ORDER_ID { get; set; }
        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String PRODUCTION_PLAN_ID { get; set; }
        public String PROCESS_CODE_MST { get; set; }
        public String PROCESS_CODE { get; set; }
        public String CODE_GUBN { get; set; }
        public String USE_YN { get; set; }
        public String COMPLETE_YN { get; set; }
        public String TERMINAL_CODE { get; set; }
        public String TERMINAL_NAME { get; set; }
        public String CHECK_LIST { get; set; }
        public String EQUIPMENT_CODE { get; set; }
        public String STOP_MST { get; set; }
        public String STOP_DETAIL { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - EquipmentHistoryEntity()

        public EquipmentStopHistoryEntity()
        {
        }

        #endregion

        #region 생성자 - EquipmentHistoryEntity(WorkResultRegister_T02Entity pWorkResultRegister_T02Entity)

        public EquipmentStopHistoryEntity(EquipmentStopHistoryEntity pEquipmentStopHistoryEntity)
        {
            CORP_CODE = pEquipmentStopHistoryEntity.CORP_CODE;
            CRUD = pEquipmentStopHistoryEntity.CRUD;
            USER_CODE = pEquipmentStopHistoryEntity.USER_CODE;
            WINDOW_NAME = pEquipmentStopHistoryEntity.WINDOW_NAME;
            LANGUAGE_TYPE = pEquipmentStopHistoryEntity.LANGUAGE_TYPE;

            DATE_FROM = pEquipmentStopHistoryEntity.DATE_FROM;
            DATE_TO = pEquipmentStopHistoryEntity.DATE_TO;
            PRODUCTION_ORDER_ID = pEquipmentStopHistoryEntity.PRODUCTION_ORDER_ID;
            PART_CODE = pEquipmentStopHistoryEntity.PART_CODE;
            PART_NAME = pEquipmentStopHistoryEntity.PART_NAME;
            PRODUCTION_PLAN_ID = pEquipmentStopHistoryEntity.PRODUCTION_PLAN_ID;
            PROCESS_CODE_MST = pEquipmentStopHistoryEntity.PROCESS_CODE_MST;
            PROCESS_CODE = pEquipmentStopHistoryEntity.PROCESS_CODE;
            CODE_GUBN = pEquipmentStopHistoryEntity.CODE_GUBN;
            USE_YN = pEquipmentStopHistoryEntity.USE_YN;
            COMPLETE_YN = pEquipmentStopHistoryEntity.COMPLETE_YN;
            TERMINAL_CODE = pEquipmentStopHistoryEntity.TERMINAL_CODE;
            TERMINAL_NAME = pEquipmentStopHistoryEntity.TERMINAL_NAME;
            CHECK_LIST = pEquipmentStopHistoryEntity.CHECK_LIST;
            EQUIPMENT_CODE = pEquipmentStopHistoryEntity.EQUIPMENT_CODE;
            STOP_MST = pEquipmentStopHistoryEntity.STOP_MST;
            STOP_DETAIL = pEquipmentStopHistoryEntity.STOP_DETAIL;
            
            ERR_NO = pEquipmentStopHistoryEntity.ERR_NO;
            ERR_MSG = pEquipmentStopHistoryEntity.ERR_MSG;
            RTN_KEY = pEquipmentStopHistoryEntity.RTN_KEY;
            RTN_SEQ = pEquipmentStopHistoryEntity.RTN_SEQ;
            RTN_OTHERS = pEquipmentStopHistoryEntity.RTN_OTHERS;


            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }


    public class EquipmentCheck_T01Entity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE


        public String WINDOW_NAME { get; set; }
        public String PART_NAME { get; set; }
        public String PART_TYPE { get; set; }
        public String PART_CODE { get; set; }
        public String VEND_PART_CODE { get; set; }
        public String CHECK_CYCLE { get; set; }
        public String EQUIPMENT_CODE { get; set; }
        public String CHECK_DATE { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - EquipmentCheck_T01Entity()

        public EquipmentCheck_T01Entity()
        {
        }

        #endregion

        #region 생성자 - EquipmentCheck_T01Entity(pEquipmentCheck_T01Entity)

        public EquipmentCheck_T01Entity(EquipmentCheck_T01Entity pEquipmentCheck_T01Entity)
        {
            CORP_CODE = pEquipmentCheck_T01Entity.CORP_CODE;
            CRUD = pEquipmentCheck_T01Entity.CRUD;
            USER_CODE = pEquipmentCheck_T01Entity.USER_CODE;

            LANGUAGE_TYPE = pEquipmentCheck_T01Entity.LANGUAGE_TYPE;


            pEquipmentCheck_T01Entity.PART_TYPE = PART_TYPE;
            pEquipmentCheck_T01Entity.PART_NAME = PART_NAME;
            pEquipmentCheck_T01Entity.PART_CODE = PART_CODE;
            pEquipmentCheck_T01Entity.VEND_PART_CODE = PART_CODE;
            pEquipmentCheck_T01Entity.CHECK_CYCLE = CHECK_CYCLE;
            pEquipmentCheck_T01Entity.EQUIPMENT_CODE = EQUIPMENT_CODE;
            pEquipmentCheck_T01Entity.CHECK_DATE = CHECK_DATE;

            ERR_NO = pEquipmentCheck_T01Entity.ERR_NO;
            ERR_MSG = pEquipmentCheck_T01Entity.ERR_MSG;
            RTN_KEY = pEquipmentCheck_T01Entity.RTN_KEY;
            RTN_SEQ = pEquipmentCheck_T01Entity.RTN_SEQ;
            RTN_OTHERS = pEquipmentCheck_T01Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class EquipmentBaseRegister_T50Entity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE


        public String WINDOW_NAME { get; set; }
        public String PART_NAME { get; set; }
        public String PART_TYPE { get; set; }
        public String PART_CODE { get; set; }
        public String VEND_PART_CODE { get; set; }
        public String CHECK_CYCLE { get; set; }
        public String EQUIPMENT_CODE { get; set; }
        public String CHECK_DATE { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - EquipmentBaseRegister_T50Entity()

        public EquipmentBaseRegister_T50Entity()
        {
        }

        #endregion

        #region 생성자 - EquipmentBaseRegister_T50Entity(pEquipmentBaseRegister_T50Entity)

        public EquipmentBaseRegister_T50Entity(EquipmentBaseRegister_T50Entity pEquipmentBaseRegister_T50Entity)
        {
            CORP_CODE = pEquipmentBaseRegister_T50Entity.CORP_CODE;
            CRUD = pEquipmentBaseRegister_T50Entity.CRUD;
            USER_CODE = pEquipmentBaseRegister_T50Entity.USER_CODE;

            LANGUAGE_TYPE = pEquipmentBaseRegister_T50Entity.LANGUAGE_TYPE;


            pEquipmentBaseRegister_T50Entity.PART_TYPE = PART_TYPE;
            pEquipmentBaseRegister_T50Entity.PART_NAME = PART_NAME;
            pEquipmentBaseRegister_T50Entity.PART_CODE = PART_CODE;
            pEquipmentBaseRegister_T50Entity.VEND_PART_CODE = PART_CODE;
            pEquipmentBaseRegister_T50Entity.CHECK_CYCLE = CHECK_CYCLE;
            pEquipmentBaseRegister_T50Entity.EQUIPMENT_CODE = EQUIPMENT_CODE;
            pEquipmentBaseRegister_T50Entity.CHECK_DATE = CHECK_DATE;

            ERR_NO = pEquipmentBaseRegister_T50Entity.ERR_NO;
            ERR_MSG = pEquipmentBaseRegister_T50Entity.ERR_MSG;
            RTN_KEY = pEquipmentBaseRegister_T50Entity.RTN_KEY;
            RTN_SEQ = pEquipmentBaseRegister_T50Entity.RTN_SEQ;
            RTN_OTHERS = pEquipmentBaseRegister_T50Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class EquipmentCheckListMonth_T50Entity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE


        public String WINDOW_NAME { get; set; }
        public String PART_NAME { get; set; }
        public String PART_TYPE { get; set; }
        public String PART_CODE { get; set; }
        public String VEND_PART_CODE { get; set; }
        public String CHECK_CYCLE { get; set; }
        public String EQUIPMENT_CODE { get; set; }
        public String CHECK_DATE { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - EquipmentCheckListMonth_T50Entity()

        public EquipmentCheckListMonth_T50Entity()
        {
        }

        #endregion

        #region 생성자 - EquipmentCheckListMonth_T50Entity(pEquipmentCheckListMonth_T50Entity)

        public EquipmentCheckListMonth_T50Entity(EquipmentCheckListMonth_T50Entity pEquipmentCheckListMonth_T50Entity)
        {
            CORP_CODE = pEquipmentCheckListMonth_T50Entity.CORP_CODE;
            CRUD = pEquipmentCheckListMonth_T50Entity.CRUD;
            USER_CODE = pEquipmentCheckListMonth_T50Entity.USER_CODE;

            LANGUAGE_TYPE = pEquipmentCheckListMonth_T50Entity.LANGUAGE_TYPE;


            pEquipmentCheckListMonth_T50Entity.PART_TYPE = PART_TYPE;
            pEquipmentCheckListMonth_T50Entity.PART_NAME = PART_NAME;
            pEquipmentCheckListMonth_T50Entity.PART_CODE = PART_CODE;
            pEquipmentCheckListMonth_T50Entity.VEND_PART_CODE = PART_CODE;
            pEquipmentCheckListMonth_T50Entity.CHECK_CYCLE = CHECK_CYCLE;
            pEquipmentCheckListMonth_T50Entity.EQUIPMENT_CODE = EQUIPMENT_CODE;
            pEquipmentCheckListMonth_T50Entity.CHECK_DATE = CHECK_DATE;

            ERR_NO = pEquipmentCheckListMonth_T50Entity.ERR_NO;
            ERR_MSG = pEquipmentCheckListMonth_T50Entity.ERR_MSG;
            RTN_KEY = pEquipmentCheckListMonth_T50Entity.RTN_KEY;
            RTN_SEQ = pEquipmentCheckListMonth_T50Entity.RTN_SEQ;
            RTN_OTHERS = pEquipmentCheckListMonth_T50Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }
}

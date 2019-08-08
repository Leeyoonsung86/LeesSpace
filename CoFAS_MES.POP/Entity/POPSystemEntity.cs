using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoFAS_MES.POP.Entity
{
    public class DQGatheringEntity
    {
        #region Property

        //사용자 설정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE



        public String COLLECTION_CODE { get; set; } // 수집 위치
        public String COLLECTION_DATE { get; set; } // 수집 시간
        public String PROPERTY_VALUE { get; set; } // 속성값

        public String CONDITION_CODE { get; set; } // 조건 값
        public String COLLECTION_VALUE { get; set; } //수집 데이터 값

        public String REMARK { get; set; } // 비고
        public String USE_YN { get; set; } // 사용유무


        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }


        #endregion

        #region 생성자 - DQGatheringEntity()

        public DQGatheringEntity()
        {
        }

        #endregion

        #region 생성자 - DQGatheringEntity(pDQGatheringEntity)

        public DQGatheringEntity(DQGatheringEntity pDQGatheringEntity)
        {
            CORP_CODE = pDQGatheringEntity.CORP_CODE;
            CRUD = pDQGatheringEntity.CRUD;
            USER_CODE = pDQGatheringEntity.USER_CODE;
            LANGUAGE_TYPE = pDQGatheringEntity.LANGUAGE_TYPE;
            REMARK = pDQGatheringEntity.REMARK;
            USE_YN = pDQGatheringEntity.USE_YN;

            ERR_NO = pDQGatheringEntity.ERR_NO;
            ERR_MSG = pDQGatheringEntity.ERR_MSG;
            RTN_KEY = pDQGatheringEntity.RTN_KEY;
            RTN_SEQ = pDQGatheringEntity.RTN_SEQ;
            RTN_OTHERS = pDQGatheringEntity.RTN_OTHERS;
        }

        #endregion

    }

    public class DBInterfaceEntity
    {
        #region Property

        //사용자 설정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE



        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }


        #endregion

        #region 생성자 - DBInterfaceEntity()

        public DBInterfaceEntity()
        {
        }

        #endregion

        #region 생성자 - DBInterfaceEntity(pDBInterfaceEntity)

        public DBInterfaceEntity(DBInterfaceEntity pDBInterfaceEntity)
        {
            CORP_CODE = pDBInterfaceEntity.CORP_CODE;
            CRUD = pDBInterfaceEntity.CRUD;
            USER_CODE = pDBInterfaceEntity.USER_CODE;
            LANGUAGE_TYPE = pDBInterfaceEntity.LANGUAGE_TYPE;

            ERR_NO = pDBInterfaceEntity.ERR_NO;
            ERR_MSG = pDBInterfaceEntity.ERR_MSG;
            RTN_KEY = pDBInterfaceEntity.RTN_KEY;
            RTN_SEQ = pDBInterfaceEntity.RTN_SEQ;
            RTN_OTHERS = pDBInterfaceEntity.RTN_OTHERS;
        }

        #endregion

    }

    public class POPProductionOrderEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String USER_NAME { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE


        //고정 엔티티


        //메뉴별 추가 엔티티 입력
        public String WINDOW_NAME { get; set; }

        public String RESOURCE_CODE { get; set; }
        public String PROCESS_CODE { get; set; }
        public String PROCESS_CODE_MST { get; set; }
        public String TERMINAL_CODE { get; set; } 
        
        //메뉴별 추가 엔티티 입력
        public String COLLECTION_DATE { get; set; }
        public String PROPERTY_VALUE { get; set; }
        public String CONDITION_CODE { get; set; }
        public String COLLECTION_VALUE { get; set; }

        public String PRODUCTION_ORDER_ID { get; set; }
        public String PRODUCTION_SEQ { get; set; }
        public String PRODUCTION_ORDER_QTY { get; set; }
        public String PRODUCTION_OK_QTY { get; set; }
        public String PRODUCTION_NG_QTY { get; set; }
        public String PROCERSS_INFO { get; set; }
        public String PRODUCTION_ORDER_SEQ { get; set; }
        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String BAD_CODE { get; set; }

        public String COMPLETE_YN { get; set; }



        #endregion

        #region 생성자 - POPProductionOrderEntity()

        public POPProductionOrderEntity()
        {
        }

        #endregion

        #region 생성자 - POPProductionOrderEntity(pPOPProductionOrderEntity)

        public POPProductionOrderEntity(POPProductionOrderEntity pPOPProductionOrderEntity)
        {
            CORP_CODE = pPOPProductionOrderEntity.CORP_CODE;
            CRUD = pPOPProductionOrderEntity.CRUD;
            USER_CODE = pPOPProductionOrderEntity.USER_CODE;
            USER_NAME = pPOPProductionOrderEntity.USER_NAME;
            ERR_NO = pPOPProductionOrderEntity.ERR_NO;
            ERR_MSG = pPOPProductionOrderEntity.ERR_MSG;
            RTN_KEY = pPOPProductionOrderEntity.RTN_KEY;
            RTN_SEQ = pPOPProductionOrderEntity.RTN_SEQ;
            RTN_OTHERS = pPOPProductionOrderEntity.RTN_OTHERS;
            LANGUAGE_TYPE = pPOPProductionOrderEntity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
            WINDOW_NAME = pPOPProductionOrderEntity.WINDOW_NAME;
            RESOURCE_CODE = pPOPProductionOrderEntity.RESOURCE_CODE;
            RESOURCE_CODE = pPOPProductionOrderEntity.RESOURCE_CODE;
            COLLECTION_DATE = pPOPProductionOrderEntity.COLLECTION_DATE;
            PROPERTY_VALUE = pPOPProductionOrderEntity.PROPERTY_VALUE;
            CONDITION_CODE = pPOPProductionOrderEntity.CONDITION_CODE;
            COLLECTION_VALUE = pPOPProductionOrderEntity.COLLECTION_VALUE;

            PRODUCTION_ORDER_ID = pPOPProductionOrderEntity.PRODUCTION_ORDER_ID;
            COMPLETE_YN = pPOPProductionOrderEntity.COMPLETE_YN;

            PROCESS_CODE_MST = pPOPProductionOrderEntity.PROCESS_CODE_MST;
            TERMINAL_CODE = pPOPProductionOrderEntity.TERMINAL_CODE;
            BAD_CODE = pPOPProductionOrderEntity.BAD_CODE;

            PRODUCTION_SEQ = pPOPProductionOrderEntity.PRODUCTION_SEQ;

            PRODUCTION_ORDER_QTY = pPOPProductionOrderEntity.PRODUCTION_ORDER_QTY;
            PRODUCTION_OK_QTY = pPOPProductionOrderEntity.PRODUCTION_OK_QTY;
            PRODUCTION_NG_QTY = pPOPProductionOrderEntity.PRODUCTION_NG_QTY;
            PROCERSS_INFO = pPOPProductionOrderEntity.PROCERSS_INFO;
            PRODUCTION_ORDER_SEQ = pPOPProductionOrderEntity.PRODUCTION_ORDER_SEQ;
            PART_CODE = pPOPProductionOrderEntity.PART_CODE;
            PART_NAME = pPOPProductionOrderEntity.PART_NAME;
        }
        #endregion

    }

    public class POPProductionOrder_T03Entity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String USER_NAME { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE


        //고정 엔티티


        //메뉴별 추가 엔티티 입력
        public String WINDOW_NAME { get; set; }

        public String RESOURCE_CODE { get; set; }
        public String PROCESS_CODE { get; set; }
        public String PROCESS_CODE_MST { get; set; }
        public String TERMINAL_CODE { get; set; }

        //메뉴별 추가 엔티티 입력
        public String COLLECTION_DATE { get; set; }
        public String PROPERTY_VALUE { get; set; }
        public String CONDITION_CODE { get; set; }
        public String COLLECTION_VALUE { get; set; }

        public String PRODUCTION_ORDER_ID { get; set; }
        public String COMPLETE_YN { get; set; }

        #endregion

        #region 생성자 - POPProductionOrderEntity()

        public POPProductionOrder_T03Entity()
        {
        }

        #endregion

        #region 생성자 - POPProductionOrderEntity(pPOPProductionOrderEntity)

        public POPProductionOrder_T03Entity(POPProductionOrder_T03Entity pPOPProductionOrder_T03Entity)
        {
            CORP_CODE = pPOPProductionOrder_T03Entity.CORP_CODE;
            CRUD = pPOPProductionOrder_T03Entity.CRUD;
            USER_CODE = pPOPProductionOrder_T03Entity.USER_CODE;
            USER_NAME = pPOPProductionOrder_T03Entity.USER_NAME;
            ERR_NO = pPOPProductionOrder_T03Entity.ERR_NO;
            ERR_MSG = pPOPProductionOrder_T03Entity.ERR_MSG;
            RTN_KEY = pPOPProductionOrder_T03Entity.RTN_KEY;
            RTN_SEQ = pPOPProductionOrder_T03Entity.RTN_SEQ;
            RTN_OTHERS = pPOPProductionOrder_T03Entity.RTN_OTHERS;
            LANGUAGE_TYPE = pPOPProductionOrder_T03Entity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
            WINDOW_NAME = pPOPProductionOrder_T03Entity.WINDOW_NAME;
            RESOURCE_CODE = pPOPProductionOrder_T03Entity.RESOURCE_CODE;
            RESOURCE_CODE = pPOPProductionOrder_T03Entity.RESOURCE_CODE;
            COLLECTION_DATE = pPOPProductionOrder_T03Entity.COLLECTION_DATE;
            PROPERTY_VALUE = pPOPProductionOrder_T03Entity.PROPERTY_VALUE;
            CONDITION_CODE = pPOPProductionOrder_T03Entity.CONDITION_CODE;
            COLLECTION_VALUE = pPOPProductionOrder_T03Entity.COLLECTION_VALUE;

            PRODUCTION_ORDER_ID = pPOPProductionOrder_T03Entity.PRODUCTION_ORDER_ID;
            COMPLETE_YN = pPOPProductionOrder_T03Entity.COMPLETE_YN;

            PROCESS_CODE_MST = pPOPProductionOrder_T03Entity.PROCESS_CODE_MST;
            TERMINAL_CODE = pPOPProductionOrder_T03Entity.TERMINAL_CODE;
        }
        #endregion

    }

    public class POPProductionOrder_T50Entity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String USER_NAME { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE


        //고정 엔티티


        //메뉴별 추가 엔티티 입력
        public String WINDOW_NAME { get; set; }

        public String RESOURCE_CODE { get; set; }
        public String PROCESS_CODE { get; set; }
        public String PROCESS_CODE_MST { get; set; }
        public String TERMINAL_CODE { get; set; }

        //메뉴별 추가 엔티티 입력
        public String COLLECTION_DATE { get; set; }
        public String PROPERTY_VALUE { get; set; }
        public String CONDITION_CODE { get; set; }
        public String COLLECTION_VALUE { get; set; }

        public String PRODUCTION_ORDER_ID { get; set; }
        public String COMPLETE_YN { get; set; }

        #endregion

        #region 생성자 - POPProductionOrderEntity()

        public POPProductionOrder_T50Entity()
        {
        }

        #endregion

        #region 생성자 - POPProductionOrderEntity(pPOPProductionOrderEntity)

        public POPProductionOrder_T50Entity(POPProductionOrder_T50Entity pPOPProductionOrder_T50Entity)
        {
            CORP_CODE = pPOPProductionOrder_T50Entity.CORP_CODE;
            CRUD = pPOPProductionOrder_T50Entity.CRUD;
            USER_CODE = pPOPProductionOrder_T50Entity.USER_CODE;
            USER_NAME = pPOPProductionOrder_T50Entity.USER_NAME;
            ERR_NO = pPOPProductionOrder_T50Entity.ERR_NO;
            ERR_MSG = pPOPProductionOrder_T50Entity.ERR_MSG;
            RTN_KEY = pPOPProductionOrder_T50Entity.RTN_KEY;
            RTN_SEQ = pPOPProductionOrder_T50Entity.RTN_SEQ;
            RTN_OTHERS = pPOPProductionOrder_T50Entity.RTN_OTHERS;
            LANGUAGE_TYPE = pPOPProductionOrder_T50Entity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
            WINDOW_NAME = pPOPProductionOrder_T50Entity.WINDOW_NAME;
            RESOURCE_CODE = pPOPProductionOrder_T50Entity.RESOURCE_CODE;
            RESOURCE_CODE = pPOPProductionOrder_T50Entity.RESOURCE_CODE;
            COLLECTION_DATE = pPOPProductionOrder_T50Entity.COLLECTION_DATE;
            PROPERTY_VALUE = pPOPProductionOrder_T50Entity.PROPERTY_VALUE;
            CONDITION_CODE = pPOPProductionOrder_T50Entity.CONDITION_CODE;
            COLLECTION_VALUE = pPOPProductionOrder_T50Entity.COLLECTION_VALUE;

            PRODUCTION_ORDER_ID = pPOPProductionOrder_T50Entity.PRODUCTION_ORDER_ID;
            COMPLETE_YN = pPOPProductionOrder_T50Entity.COMPLETE_YN;

            PROCESS_CODE_MST = pPOPProductionOrder_T50Entity.PROCESS_CODE_MST;
            TERMINAL_CODE = pPOPProductionOrder_T50Entity.TERMINAL_CODE;
        }
        #endregion

    }

    public class POPLabelPrintEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String USER_NAME { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE


        //고정 엔티티


        //메뉴별 추가 엔티티 입력
        public String WINDOW_NAME { get; set; }

        public String RESOURCE_CODE { get; set; }
        public String PROCESS_CODE { get; set; }
        public String PROCESS_CODE_MST { get; set; }
        public String TERMINAL_CODE { get; set; }

        //메뉴별 추가 엔티티 입력
        public String COLLECTION_DATE { get; set; }
        public String PROPERTY_VALUE { get; set; }
        public String CONDITION_CODE { get; set; }
        public String COLLECTION_VALUE { get; set; }

        public String PRODUCTION_ORDER_ID { get; set; }
        public String COMPLETE_YN { get; set; }

        #endregion

        #region 생성자 - POPProductionOrderEntity()

        public POPLabelPrintEntity()
        {
        }

        #endregion

        #region 생성자 - POPProductionOrderEntity(pPOPProductionOrderEntity)

        public POPLabelPrintEntity(POPLabelPrintEntity pPOPLabelPrintEntity)
        {
            CORP_CODE = pPOPLabelPrintEntity.CORP_CODE;
            CRUD = pPOPLabelPrintEntity.CRUD;
            USER_CODE = pPOPLabelPrintEntity.USER_CODE;
            USER_NAME = pPOPLabelPrintEntity.USER_NAME;
            ERR_NO = pPOPLabelPrintEntity.ERR_NO;
            ERR_MSG = pPOPLabelPrintEntity.ERR_MSG;
            RTN_KEY = pPOPLabelPrintEntity.RTN_KEY;
            RTN_SEQ = pPOPLabelPrintEntity.RTN_SEQ;
            RTN_OTHERS = pPOPLabelPrintEntity.RTN_OTHERS;
            LANGUAGE_TYPE = pPOPLabelPrintEntity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
            WINDOW_NAME = pPOPLabelPrintEntity.WINDOW_NAME;
            RESOURCE_CODE = pPOPLabelPrintEntity.RESOURCE_CODE;
            RESOURCE_CODE = pPOPLabelPrintEntity.RESOURCE_CODE;
            COLLECTION_DATE = pPOPLabelPrintEntity.COLLECTION_DATE;
            PROPERTY_VALUE = pPOPLabelPrintEntity.PROPERTY_VALUE;
            CONDITION_CODE = pPOPLabelPrintEntity.CONDITION_CODE;
            COLLECTION_VALUE = pPOPLabelPrintEntity.COLLECTION_VALUE;

            PRODUCTION_ORDER_ID = pPOPLabelPrintEntity.PRODUCTION_ORDER_ID;
            COMPLETE_YN = pPOPLabelPrintEntity.COMPLETE_YN;

            PROCESS_CODE_MST = pPOPLabelPrintEntity.PROCESS_CODE_MST;
            TERMINAL_CODE = pPOPLabelPrintEntity.TERMINAL_CODE;
        }
        #endregion

    }
    public class frmPOPMain_RAWMATERIAL_COSMETICSEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String USER_NAME { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE


        //고정 엔티티


        //메뉴별 추가 엔티티 입력
        public String WINDOW_NAME { get; set; }

        public String RESOURCE_CODE { get; set; }
        public String PROCESS_CODE { get; set; }
        public String PROCESS_CODE_MST { get; set; }
        public String TERMINAL_CODE { get; set; }
        

        //메뉴별 추가 엔티티 입력
        public String COLLECTION_DATE { get; set; }
        public String PROPERTY_VALUE { get; set; }
        public String CONDITION_CODE { get; set; }
        public String COLLECTION_VALUE { get; set; }

        public String PRODUCTION_ORDER_ID { get; set; }
        public String COMPLETE_YN { get; set; }
        public String INOUT_ID { get; set; }
        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String ORDER_ID { get; set; }
        public String SAMPLING_RESULT { get; set; }
        public String SAMPLING_DATE { get; set; }
        public String IN_QTY { get; set; }
        #endregion

        #region 생성자 - frmPOPMain_RAWMATERIAL_COSMETICSEntity()

        public frmPOPMain_RAWMATERIAL_COSMETICSEntity()
        {
        }

        #endregion

        #region 생성자 - frmPOPMain_RAWMATERIAL_COSMETICSEntity(pfrmPOPMain_RAWMATERIAL_COSMETICSEntity)

        public frmPOPMain_RAWMATERIAL_COSMETICSEntity(frmPOPMain_RAWMATERIAL_COSMETICSEntity pfrmPOPMain_RAWMATERIAL_COSMETICSEntity)
        {
            CORP_CODE = pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.CORP_CODE;
            CRUD = pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.CRUD;
            USER_CODE = pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.USER_CODE;
            USER_NAME = pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.USER_NAME;
            ERR_NO = pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.ERR_NO;
            ERR_MSG = pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.ERR_MSG;
            RTN_KEY = pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.RTN_KEY;
            RTN_SEQ = pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.RTN_SEQ;
            RTN_OTHERS = pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.RTN_OTHERS;
            LANGUAGE_TYPE = pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
            WINDOW_NAME = pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.WINDOW_NAME;
            RESOURCE_CODE = pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.RESOURCE_CODE;
            RESOURCE_CODE = pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.RESOURCE_CODE;
            COLLECTION_DATE = pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.COLLECTION_DATE;
            PROPERTY_VALUE = pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.PROPERTY_VALUE;
            CONDITION_CODE = pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.CONDITION_CODE;
            COLLECTION_VALUE = pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.COLLECTION_VALUE;
            TERMINAL_CODE = pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.TERMINAL_CODE;
            PRODUCTION_ORDER_ID = pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.PRODUCTION_ORDER_ID;
            COMPLETE_YN = pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.COMPLETE_YN;

            PROCESS_CODE_MST = pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.PROCESS_CODE_MST;

            INOUT_ID = pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.INOUT_ID;
            PART_CODE = pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.PART_CODE;
            PART_NAME = pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.PART_NAME;

            ORDER_ID = pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.ORDER_ID;

            SAMPLING_RESULT = pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.SAMPLING_RESULT;
            SAMPLING_DATE = pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.SAMPLING_DATE;
            IN_QTY = pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.IN_QTY;
        }
        #endregion

    }
    public class frmPOPInfoEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String USER_NAME { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE


        //고정 엔티티


        //메뉴별 추가 엔티티 입력
        public String WINDOW_NAME { get; set; }

        public String RESOURCE_CODE { get; set; }
        public String PROCESS_CODE { get; set; }
        public String PROCESS_CODE_MST { get; set; }
        public String TERMINAL_CODE { get; set; }


        #endregion

        #region 생성자 - frmPOPMain_RAWMATERIAL_COSMETICSEntity()

        public frmPOPInfoEntity()
        {
        }

        #endregion

        #region 생성자 - frmPOPMain_RAWMATERIAL_COSMETICSEntity(pfrmPOPInfoEntity)

        public frmPOPInfoEntity(frmPOPInfoEntity pfrmPOPInfoEntity)
        {
            CORP_CODE = pfrmPOPInfoEntity.CORP_CODE;
            CRUD = pfrmPOPInfoEntity.CRUD;
            USER_CODE = pfrmPOPInfoEntity.USER_CODE;
            USER_NAME = pfrmPOPInfoEntity.USER_NAME;
            ERR_NO = pfrmPOPInfoEntity.ERR_NO;
            ERR_MSG = pfrmPOPInfoEntity.ERR_MSG;
            RTN_KEY = pfrmPOPInfoEntity.RTN_KEY;
            RTN_SEQ = pfrmPOPInfoEntity.RTN_SEQ;
            RTN_OTHERS = pfrmPOPInfoEntity.RTN_OTHERS;
            LANGUAGE_TYPE = pfrmPOPInfoEntity.LANGUAGE_TYPE;
            TERMINAL_CODE = pfrmPOPInfoEntity.TERMINAL_CODE;
            //메뉴별 추가 엔티티 입력
            WINDOW_NAME = pfrmPOPInfoEntity.WINDOW_NAME;
            RESOURCE_CODE = pfrmPOPInfoEntity.RESOURCE_CODE;
            RESOURCE_CODE = pfrmPOPInfoEntity.RESOURCE_CODE;
            PROCESS_CODE_MST = pfrmPOPInfoEntity.PROCESS_CODE_MST;

        }
        #endregion

    }

    public class frmPOPMain_MATERIAL_COSMETICSEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String USER_NAME { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE

        
        


        //고정 엔티티


        //메뉴별 추가 엔티티 입력
        public String WINDOW_NAME { get; set; }

        public String RESOURCE_CODE { get; set; }
        public String PROCESS_CODE { get; set; }
        public String PROCESS_CODE_MST { get; set; }
        public String TERMINAL_CODE { get; set; } // TERMINAL_CODE

        //메뉴별 추가 엔티티 입력
        public String COLLECTION_DATE { get; set; }
        public String PROPERTY_VALUE { get; set; }
        public String CONDITION_CODE { get; set; }
        public String COLLECTION_VALUE { get; set; }
        public String PRODUCTION_ORDER_QTY { get; set; }
        
        public String PRODUCTION_ORDER_ID { get; set; }
        public String COMPLETE_YN { get; set; }
        public String INOUT_ID { get; set; }
        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String ORDER_ID { get; set; }
        public String INOUT_CODE { get; set; }
        public String ORDER_FILE { get; set; }

        public String SAMPLING_RESULT { get; set; }
        public String SAMPLING_DATE { get; set; }
        public String IN_QTY { get; set; }
        #endregion

        #region 생성자 - frmPOPMain_MATERIAL_COSMETICSEntity()

        public frmPOPMain_MATERIAL_COSMETICSEntity()
        {
        }

        #endregion

        #region 생성자 - frmPOPMain_MATERIAL_COSMETICSEntity(pfrmPOPMain_MATERIAL_COSMETICSEntity)

        public frmPOPMain_MATERIAL_COSMETICSEntity(frmPOPMain_MATERIAL_COSMETICSEntity pfrmPOPMain_MATERIAL_COSMETICSEntity)
        {
            CORP_CODE = pfrmPOPMain_MATERIAL_COSMETICSEntity.CORP_CODE;
            CRUD = pfrmPOPMain_MATERIAL_COSMETICSEntity.CRUD;
            USER_CODE = pfrmPOPMain_MATERIAL_COSMETICSEntity.USER_CODE;
            USER_NAME = pfrmPOPMain_MATERIAL_COSMETICSEntity.USER_NAME;
            ERR_NO = pfrmPOPMain_MATERIAL_COSMETICSEntity.ERR_NO;
            ERR_MSG = pfrmPOPMain_MATERIAL_COSMETICSEntity.ERR_MSG;
            RTN_KEY = pfrmPOPMain_MATERIAL_COSMETICSEntity.RTN_KEY;
            RTN_SEQ = pfrmPOPMain_MATERIAL_COSMETICSEntity.RTN_SEQ;
            RTN_OTHERS = pfrmPOPMain_MATERIAL_COSMETICSEntity.RTN_OTHERS;
            LANGUAGE_TYPE = pfrmPOPMain_MATERIAL_COSMETICSEntity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
            WINDOW_NAME = pfrmPOPMain_MATERIAL_COSMETICSEntity.WINDOW_NAME;
            RESOURCE_CODE = pfrmPOPMain_MATERIAL_COSMETICSEntity.RESOURCE_CODE;
            RESOURCE_CODE = pfrmPOPMain_MATERIAL_COSMETICSEntity.RESOURCE_CODE;
            COLLECTION_DATE = pfrmPOPMain_MATERIAL_COSMETICSEntity.COLLECTION_DATE;
            PROPERTY_VALUE = pfrmPOPMain_MATERIAL_COSMETICSEntity.PROPERTY_VALUE;
            CONDITION_CODE = pfrmPOPMain_MATERIAL_COSMETICSEntity.CONDITION_CODE;
            COLLECTION_VALUE = pfrmPOPMain_MATERIAL_COSMETICSEntity.COLLECTION_VALUE;

            PRODUCTION_ORDER_ID = pfrmPOPMain_MATERIAL_COSMETICSEntity.PRODUCTION_ORDER_ID;
            COMPLETE_YN = pfrmPOPMain_MATERIAL_COSMETICSEntity.COMPLETE_YN;

            PROCESS_CODE_MST = pfrmPOPMain_MATERIAL_COSMETICSEntity.PROCESS_CODE_MST;

            INOUT_ID = pfrmPOPMain_MATERIAL_COSMETICSEntity.INOUT_ID;
            PART_CODE = pfrmPOPMain_MATERIAL_COSMETICSEntity.PART_CODE;
            PART_NAME = pfrmPOPMain_MATERIAL_COSMETICSEntity.PART_NAME;

            ORDER_ID = pfrmPOPMain_MATERIAL_COSMETICSEntity.ORDER_ID;

            INOUT_CODE = pfrmPOPMain_MATERIAL_COSMETICSEntity.INOUT_CODE;
            TERMINAL_CODE = pfrmPOPMain_MATERIAL_COSMETICSEntity.TERMINAL_CODE;

            ORDER_FILE = pfrmPOPMain_MATERIAL_COSMETICSEntity.ORDER_FILE;
            PRODUCTION_ORDER_QTY = pfrmPOPMain_MATERIAL_COSMETICSEntity.PRODUCTION_ORDER_QTY;

            SAMPLING_RESULT = pfrmPOPMain_MATERIAL_COSMETICSEntity.SAMPLING_RESULT;
            SAMPLING_DATE = pfrmPOPMain_MATERIAL_COSMETICSEntity.SAMPLING_DATE;
            IN_QTY = pfrmPOPMain_MATERIAL_COSMETICSEntity.IN_QTY;
        }
        #endregion

    }
    public class POPProductionOrderCommonEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String USER_NAME { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE


        //고정 엔티티


        //메뉴별 추가 엔티티 입력
        public String WINDOW_NAME { get; set; }

        public String RESOURCE_CODE { get; set; }
        public String PROCESS_CODE { get; set; }
        public String TERMINAL_CODE { get; set; }

        //메뉴별 추가 엔티티 입력
        public String COLLECTION_DATE { get; set; }
        public String PROPERTY_VALUE { get; set; }
        public String CONDITION_CODE { get; set; }
        public String COLLECTION_VALUE { get; set; }
        public String COMMON_TYPE { get; set; } // 공정구분

        public String PRODUCTION_ORDER_ID { get; set; }
        public String COMPLETE_YN { get; set; }

        //바코드 정보 저장
        public String PART_BARCODE { get; set; }
        public String PRINT_DATE { get; set; }
        public String PRINT_SEQ { get; set; }
        public String PART_CODE { get; set; }
        public String PART_QTY { get; set; }
        #endregion

        #region 생성자 - POPProductionOrderCommonEntity()

        public POPProductionOrderCommonEntity()
        {
        }

        #endregion

        #region 생성자 - POPProductionOrderCommonEntity(pPOPProductionOrderCommonEntity)

        public POPProductionOrderCommonEntity(POPProductionOrderCommonEntity pPOPProductionOrderCommonEntity)
        {
            CORP_CODE = pPOPProductionOrderCommonEntity.CORP_CODE;
            CRUD = pPOPProductionOrderCommonEntity.CRUD;
            USER_CODE = pPOPProductionOrderCommonEntity.USER_CODE;
            USER_NAME = pPOPProductionOrderCommonEntity.USER_NAME;
            ERR_NO = pPOPProductionOrderCommonEntity.ERR_NO;
            ERR_MSG = pPOPProductionOrderCommonEntity.ERR_MSG;
            RTN_KEY = pPOPProductionOrderCommonEntity.RTN_KEY;
            RTN_SEQ = pPOPProductionOrderCommonEntity.RTN_SEQ;
            RTN_OTHERS = pPOPProductionOrderCommonEntity.RTN_OTHERS;
            LANGUAGE_TYPE = pPOPProductionOrderCommonEntity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
            WINDOW_NAME = pPOPProductionOrderCommonEntity.WINDOW_NAME;
            RESOURCE_CODE = pPOPProductionOrderCommonEntity.RESOURCE_CODE;
            RESOURCE_CODE = pPOPProductionOrderCommonEntity.RESOURCE_CODE;
            TERMINAL_CODE = pPOPProductionOrderCommonEntity.TERMINAL_CODE;
            COLLECTION_DATE = pPOPProductionOrderCommonEntity.COLLECTION_DATE;
            PROPERTY_VALUE = pPOPProductionOrderCommonEntity.PROPERTY_VALUE;
            CONDITION_CODE = pPOPProductionOrderCommonEntity.CONDITION_CODE;
            COLLECTION_VALUE = pPOPProductionOrderCommonEntity.COLLECTION_VALUE;
            COMMON_TYPE = pPOPProductionOrderCommonEntity.COMMON_TYPE;

            PRODUCTION_ORDER_ID = pPOPProductionOrderCommonEntity.PRODUCTION_ORDER_ID;
            COMPLETE_YN = pPOPProductionOrderCommonEntity.COMPLETE_YN;

            PART_BARCODE = pPOPProductionOrderCommonEntity.PART_BARCODE;
            PRINT_DATE = pPOPProductionOrderCommonEntity.PRINT_DATE;
            PRINT_SEQ = pPOPProductionOrderCommonEntity.PRINT_SEQ;
            PART_CODE = pPOPProductionOrderCommonEntity.PART_CODE;
            PART_QTY = pPOPProductionOrderCommonEntity.PART_QTY;
        }
        #endregion

    }

    public class POPProductMonitoringEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String USER_NAME { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE


        //고정 엔티티


        //메뉴별 추가 엔티티 입력
        public String WINDOW_NAME { get; set; }

        public String RESOURCE_CODE { get; set; }
        public String PROCESS_CODE { get; set; }

        //메뉴별 추가 엔티티 입력
        public String COLLECTION_DATE { get; set; }
        public String PROPERTY_VALUE { get; set; }
        public String CONDITION_CODE { get; set; }
        public String COLLECTION_VALUE { get; set; }
        public String COMMON_TYPE { get; set; } // 공정구분

        public String PRODUCTION_ORDER_ID { get; set; }
        public String COMPLETE_YN { get; set; }

        //바코드 정보 저장
        public String PART_BARCODE { get; set; }
        public String PRINT_DATE { get; set; }
        public String PRINT_SEQ { get; set; }
        public String PART_CODE { get; set; }
        public String PART_QTY { get; set; }
        #endregion

        #region 생성자 - POPProductMonitoringEntity()

        public POPProductMonitoringEntity()
        {
        }

        #endregion

        #region 생성자 - POPProductMonitoringEntity(pPOPProductMonitoringEntity)

        public POPProductMonitoringEntity(POPProductMonitoringEntity pPOPProductMonitoringEntity)
        {
            CORP_CODE = pPOPProductMonitoringEntity.CORP_CODE;
            CRUD = pPOPProductMonitoringEntity.CRUD;
            USER_CODE = pPOPProductMonitoringEntity.USER_CODE;
            USER_NAME = pPOPProductMonitoringEntity.USER_NAME;
            ERR_NO = pPOPProductMonitoringEntity.ERR_NO;
            ERR_MSG = pPOPProductMonitoringEntity.ERR_MSG;
            RTN_KEY = pPOPProductMonitoringEntity.RTN_KEY;
            RTN_SEQ = pPOPProductMonitoringEntity.RTN_SEQ;
            RTN_OTHERS = pPOPProductMonitoringEntity.RTN_OTHERS;
            LANGUAGE_TYPE = pPOPProductMonitoringEntity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
            WINDOW_NAME = pPOPProductMonitoringEntity.WINDOW_NAME;
            RESOURCE_CODE = pPOPProductMonitoringEntity.RESOURCE_CODE;
            RESOURCE_CODE = pPOPProductMonitoringEntity.RESOURCE_CODE;
            COLLECTION_DATE = pPOPProductMonitoringEntity.COLLECTION_DATE;
            PROPERTY_VALUE = pPOPProductMonitoringEntity.PROPERTY_VALUE;
            CONDITION_CODE = pPOPProductMonitoringEntity.CONDITION_CODE;
            COLLECTION_VALUE = pPOPProductMonitoringEntity.COLLECTION_VALUE;
            COMMON_TYPE = pPOPProductMonitoringEntity.COMMON_TYPE;

            PRODUCTION_ORDER_ID = pPOPProductMonitoringEntity.PRODUCTION_ORDER_ID;
            COMPLETE_YN = pPOPProductMonitoringEntity.COMPLETE_YN;

            PART_BARCODE = pPOPProductMonitoringEntity.PART_BARCODE;
            PRINT_DATE = pPOPProductMonitoringEntity.PRINT_DATE;
            PRINT_SEQ = pPOPProductMonitoringEntity.PRINT_SEQ;
            PART_CODE = pPOPProductMonitoringEntity.PART_CODE;
            PART_QTY = pPOPProductMonitoringEntity.PART_QTY;
        }
        #endregion

    }

    public class POPProductBOMEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } //언어정보
        public String WINDOW_NAME { get; set; }

        public String PART_CODE_MST { get; set; }
        public String REVISION_NO { get; set; }
        public String PART_NAME { get; set; }
        public String PART_TYPE { get; set; }
        public String PART_CODE { get; set; }
        public String USE_YN { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - POPProductBOMEntity()

        public POPProductBOMEntity()
        {
        }

        #endregion

        #region 생성자 - POPProductBOMEntity(pPOPProductBOMEntity)

        public POPProductBOMEntity(POPProductBOMEntity pPOPProductBOMREntity)
        {
            CORP_CODE = pPOPProductBOMREntity.CORP_CODE;
            CRUD = pPOPProductBOMREntity.CRUD;
            USER_CODE = pPOPProductBOMREntity.USER_CODE;
            LANGUAGE_TYPE = pPOPProductBOMREntity.LANGUAGE_TYPE;
            WINDOW_NAME = pPOPProductBOMREntity.WINDOW_NAME;

            PART_CODE_MST = pPOPProductBOMREntity.PART_CODE_MST;
            REVISION_NO = pPOPProductBOMREntity.REVISION_NO;

            PART_TYPE = pPOPProductBOMREntity.PART_TYPE;
            PART_NAME = pPOPProductBOMREntity.PART_NAME;
            PART_CODE = pPOPProductBOMREntity.PART_CODE;
            USE_YN = pPOPProductBOMREntity.USE_YN;


            ERR_NO = pPOPProductBOMREntity.ERR_NO;
            ERR_MSG = pPOPProductBOMREntity.ERR_MSG;
            RTN_KEY = pPOPProductBOMREntity.RTN_KEY;
            RTN_SEQ = pPOPProductBOMREntity.RTN_SEQ;
            RTN_OTHERS = pPOPProductBOMREntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class POPSelect_INSPECT_COSMETICSEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String USER_NAME { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE
        public String ORDER_FILE { get; set; } // LANGUAGE_TYPE
        public String REQUEST_FILE { get; set; } // LANGUAGE_TYPE

        public String TERMINAL_CODE { get; set; } // LANGUAGE_TYPE

        
        //고정 엔티티


        //메뉴별 추가 엔티티 입력
        public String WINDOW_NAME { get; set; }

        public String RESOURCE_CODE { get; set; }
        public String PROCESS_CODE { get; set; }
        public String PROCESS_CODE_MST { get; set; }
        public String TODAY { get; set; }
        public String PART_CODE { get; set; }

        //메뉴별 추가 엔티티 입력
        public String COLLECTION_DATE { get; set; }
        public String PROPERTY_VALUE { get; set; }
        public String CONDITION_CODE { get; set; }
        public String COLLECTION_VALUE { get; set; }
        
        public String PRODUCTION_STATUS_PACKING { get; set; }
        public String PRODUCTION_ORDER_ID { get; set; }
        public String COMPLETE_YN { get; set; }
        public String SAMPLING_RESULT { get; set; }
        public String SAMPLING_DATE { get; set; }
        public String INOUT_ID { get; set; }
        public String INOUT_DATE { get; set; }
        public String INOUT_SEQ { get; set; }
        public String INOUT_TYPE { get; set; }
        public String REFERENCE_ID { get; set; }
        public String PART_NAME { get; set; }
        public String VEND_CODE { get; set; }
        public String VEND_NAME { get; set; }
        public String INOUT_QTY { get; set; }
        public String PART_UNIT { get; set; }
        public String UNITCOST { get; set; }
        public String COST { get; set; }
        public String REMARK { get; set; }
        public String INOUT_CODE { get; set; }
        public String USE_YN { get; set; }
         public String RTN_AQ { get; set; }
        public String RTN_SQ { get; set; }

        #endregion

        #region 생성자 - POPSelect_INSPECT_COSMETICSEntity()

        public POPSelect_INSPECT_COSMETICSEntity()
        {
        }

        #endregion

        #region 생성자 - POPSelect_INSPECT_COSMETICSEntity(pPOPSelect_INSPECT_COSMETICSEntity)

        public POPSelect_INSPECT_COSMETICSEntity(POPSelect_INSPECT_COSMETICSEntity pPOPSelect_INSPECT_COSMETICSEntity)
        {
            CORP_CODE = pPOPSelect_INSPECT_COSMETICSEntity.CORP_CODE;
            CRUD = pPOPSelect_INSPECT_COSMETICSEntity.CRUD;
            USER_CODE = pPOPSelect_INSPECT_COSMETICSEntity.USER_CODE;
            USER_NAME = pPOPSelect_INSPECT_COSMETICSEntity.USER_NAME;
            ERR_NO = pPOPSelect_INSPECT_COSMETICSEntity.ERR_NO;
            ERR_MSG = pPOPSelect_INSPECT_COSMETICSEntity.ERR_MSG;
            RTN_KEY = pPOPSelect_INSPECT_COSMETICSEntity.RTN_KEY;
            RTN_SEQ = pPOPSelect_INSPECT_COSMETICSEntity.RTN_SEQ;
            RTN_AQ = pPOPSelect_INSPECT_COSMETICSEntity.RTN_AQ;
            RTN_SQ = pPOPSelect_INSPECT_COSMETICSEntity.RTN_SQ;
            RTN_OTHERS = pPOPSelect_INSPECT_COSMETICSEntity.RTN_OTHERS;
            LANGUAGE_TYPE = pPOPSelect_INSPECT_COSMETICSEntity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
            WINDOW_NAME = pPOPSelect_INSPECT_COSMETICSEntity.WINDOW_NAME;
            RESOURCE_CODE = pPOPSelect_INSPECT_COSMETICSEntity.RESOURCE_CODE;
            RESOURCE_CODE = pPOPSelect_INSPECT_COSMETICSEntity.RESOURCE_CODE;
            COLLECTION_DATE = pPOPSelect_INSPECT_COSMETICSEntity.COLLECTION_DATE;
            PROPERTY_VALUE = pPOPSelect_INSPECT_COSMETICSEntity.PROPERTY_VALUE;
            CONDITION_CODE = pPOPSelect_INSPECT_COSMETICSEntity.CONDITION_CODE;
            COLLECTION_VALUE = pPOPSelect_INSPECT_COSMETICSEntity.COLLECTION_VALUE;

            SAMPLING_RESULT = pPOPSelect_INSPECT_COSMETICSEntity.SAMPLING_RESULT;
            SAMPLING_DATE = pPOPSelect_INSPECT_COSMETICSEntity.SAMPLING_DATE;

            PRODUCTION_ORDER_ID = pPOPSelect_INSPECT_COSMETICSEntity.PRODUCTION_ORDER_ID;
            COMPLETE_YN = pPOPSelect_INSPECT_COSMETICSEntity.COMPLETE_YN;
            TODAY = pPOPSelect_INSPECT_COSMETICSEntity.COMPLETE_YN;
            PROCESS_CODE_MST = pPOPSelect_INSPECT_COSMETICSEntity.PROCESS_CODE_MST;
            PART_CODE = pPOPSelect_INSPECT_COSMETICSEntity.PART_CODE;
            ORDER_FILE = pPOPSelect_INSPECT_COSMETICSEntity.ORDER_FILE;
            REQUEST_FILE = pPOPSelect_INSPECT_COSMETICSEntity.REQUEST_FILE;
            TERMINAL_CODE = pPOPSelect_INSPECT_COSMETICSEntity.TERMINAL_CODE;
            PRODUCTION_STATUS_PACKING = pPOPSelect_INSPECT_COSMETICSEntity.PRODUCTION_STATUS_PACKING;
            INOUT_ID = pPOPSelect_INSPECT_COSMETICSEntity.INOUT_ID;
            INOUT_DATE = pPOPSelect_INSPECT_COSMETICSEntity.INOUT_DATE;
            INOUT_SEQ = pPOPSelect_INSPECT_COSMETICSEntity.INOUT_SEQ;
            INOUT_TYPE = pPOPSelect_INSPECT_COSMETICSEntity.INOUT_TYPE;
            REFERENCE_ID = pPOPSelect_INSPECT_COSMETICSEntity.REFERENCE_ID;
            PART_CODE = pPOPSelect_INSPECT_COSMETICSEntity.PART_CODE;
            PART_NAME = pPOPSelect_INSPECT_COSMETICSEntity.PART_NAME;
            VEND_CODE = pPOPSelect_INSPECT_COSMETICSEntity.VEND_CODE;
            VEND_NAME = pPOPSelect_INSPECT_COSMETICSEntity.VEND_NAME;
            INOUT_QTY = pPOPSelect_INSPECT_COSMETICSEntity.INOUT_QTY;
            PART_UNIT = pPOPSelect_INSPECT_COSMETICSEntity.PART_UNIT;
            UNITCOST = pPOPSelect_INSPECT_COSMETICSEntity.UNITCOST;
            COST = pPOPSelect_INSPECT_COSMETICSEntity.COST;
            REMARK = pPOPSelect_INSPECT_COSMETICSEntity.REMARK;
            INOUT_CODE = pPOPSelect_INSPECT_COSMETICSEntity.INOUT_CODE;
            USE_YN = pPOPSelect_INSPECT_COSMETICSEntity.USE_YN;
        }

        #endregion

    }

    public class frmPOPMain_WEIGHING_COSMETICSEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String USER_NAME { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE
        public String ORDER_FILE { get; set; } // LANGUAGE_TYPE
        public String REQUEST_FILE { get; set; } // LANGUAGE_TYPE
        public String TERMINAL_CODE { get; set; } // LANGUAGE_TYPE
        
        //고정 엔티티


        //메뉴별 추가 엔티티 입력
        public String WINDOW_NAME { get; set; }

        public String RESOURCE_CODE { get; set; }
        public String PROCESS_CODE { get; set; }
        public String PROCESS_CODE_MST { get; set; }
        public String TODAY { get; set; }
        public String PART_CODE { get; set; }
        public String INOUT_CODE { get; set; }
        public String PROCESS_SEQ { get; set; }

        //메뉴별 추가 엔티티 입력
        public String COLLECTION_DATE { get; set; }
        public String PROPERTY_VALUE { get; set; }
        public String CONDITION_CODE { get; set; }
        public String COLLECTION_VALUE { get; set; }

        public String PRODUCTION_ORDER_ID { get; set; }
        public String PRODUCTION_ORDER_QTY { get; set; }
        public String COMPLETE_YN { get; set; }

        #endregion

        #region 생성자 - frmPOPMain_WEIGHING_COSMETICSEntity()

        public frmPOPMain_WEIGHING_COSMETICSEntity()
        {
        }

        #endregion

        #region 생성자 - frmPOPMain_WEIGHING_COSMETICSEntity(pfrmPOPMain_WEIGHING_COSMETICSEntity)

        public frmPOPMain_WEIGHING_COSMETICSEntity(frmPOPMain_WEIGHING_COSMETICSEntity pfrmPOPMain_WEIGHING_COSMETICSEntity)
        {
            CORP_CODE = pfrmPOPMain_WEIGHING_COSMETICSEntity.CORP_CODE;
            CRUD = pfrmPOPMain_WEIGHING_COSMETICSEntity.CRUD;
            USER_CODE = pfrmPOPMain_WEIGHING_COSMETICSEntity.USER_CODE;
            USER_NAME = pfrmPOPMain_WEIGHING_COSMETICSEntity.USER_NAME;
            ERR_NO = pfrmPOPMain_WEIGHING_COSMETICSEntity.ERR_NO;
            ERR_MSG = pfrmPOPMain_WEIGHING_COSMETICSEntity.ERR_MSG;
            RTN_KEY = pfrmPOPMain_WEIGHING_COSMETICSEntity.RTN_KEY;
            RTN_SEQ = pfrmPOPMain_WEIGHING_COSMETICSEntity.RTN_SEQ;
            RTN_OTHERS = pfrmPOPMain_WEIGHING_COSMETICSEntity.RTN_OTHERS;
            LANGUAGE_TYPE = pfrmPOPMain_WEIGHING_COSMETICSEntity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
            WINDOW_NAME = pfrmPOPMain_WEIGHING_COSMETICSEntity.WINDOW_NAME;
            RESOURCE_CODE = pfrmPOPMain_WEIGHING_COSMETICSEntity.RESOURCE_CODE;
            RESOURCE_CODE = pfrmPOPMain_WEIGHING_COSMETICSEntity.RESOURCE_CODE;
            COLLECTION_DATE = pfrmPOPMain_WEIGHING_COSMETICSEntity.COLLECTION_DATE;
            PROPERTY_VALUE = pfrmPOPMain_WEIGHING_COSMETICSEntity.PROPERTY_VALUE;
            CONDITION_CODE = pfrmPOPMain_WEIGHING_COSMETICSEntity.CONDITION_CODE;
            COLLECTION_VALUE = pfrmPOPMain_WEIGHING_COSMETICSEntity.COLLECTION_VALUE;

            PRODUCTION_ORDER_ID = pfrmPOPMain_WEIGHING_COSMETICSEntity.PRODUCTION_ORDER_ID;
            COMPLETE_YN = pfrmPOPMain_WEIGHING_COSMETICSEntity.COMPLETE_YN;
            TODAY = pfrmPOPMain_WEIGHING_COSMETICSEntity.COMPLETE_YN;
            PROCESS_CODE_MST = pfrmPOPMain_WEIGHING_COSMETICSEntity.PROCESS_CODE_MST;
            PART_CODE = pfrmPOPMain_WEIGHING_COSMETICSEntity.PART_CODE;
            ORDER_FILE = pfrmPOPMain_WEIGHING_COSMETICSEntity.ORDER_FILE;
            REQUEST_FILE = pfrmPOPMain_WEIGHING_COSMETICSEntity.REQUEST_FILE;
            PRODUCTION_ORDER_QTY = pfrmPOPMain_WEIGHING_COSMETICSEntity.PRODUCTION_ORDER_QTY;

            INOUT_CODE = pfrmPOPMain_WEIGHING_COSMETICSEntity.INOUT_CODE;

            TERMINAL_CODE = pfrmPOPMain_WEIGHING_COSMETICSEntity.TERMINAL_CODE;

            PROCESS_SEQ = pfrmPOPMain_WEIGHING_COSMETICSEntity.PROCESS_SEQ;
        }
        #endregion

    }
    public class POPSelect_INSPECT_MIXEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String USER_NAME { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE


        public String INOUT_TYPE { get; set; } // LANGUAGE_TYPE
        public String INOUT_DATE { get; set; } // LANGUAGE_TYPE
        public String INOUT_SEQ { get; set; } // LANGUAGE_TYPE
        public String INOUT_CODE { get; set; } // LANGUAGE_TYPE
        public String VEND_CODE { get; set; } // LANGUAGE_TYPE
        public String INOUT_QTY { get; set; } // LANGUAGE_TYPE
        public String USE_YN { get; set; } // LANGUAGE_TYPE

        //고정 엔티티


        //메뉴별 추가 엔티티 입력
        public String WINDOW_NAME { get; set; }
        public String TERMINAL_CODE { get; set; }
        public String PRINT_CODE { get; set; }

        public String RESOURCE_CODE { get; set; }
        public String PROCESS_CODE { get; set; }
        public String PROCESS_CODE_MST { get; set; }
        public String TODAY { get; set; }
        public String PART_CODE { get; set; }
        public String PART_UNIT { get; set; }

        public String OPTION_CODE { get; set; }

        //메뉴별 추가 엔티티 입력
        public String COLLECTION_DATE { get; set; }
        public String PROPERTY_VALUE { get; set; }
        public String CONDITION_CODE { get; set; }
        public String COLLECTION_VALUE { get; set; }

        public String PRODUCTION_ORDER_ID { get; set; }
        public String COMPLETE_YN { get; set; }

        #endregion

        #region 생성자 - POPSelect_INSPECT_MIXEntity()

        public POPSelect_INSPECT_MIXEntity()
        {
        }

        #endregion

        #region 생성자 - POPSelect_INSPECT_MIXEntity(pPOPSelect_INSPECT_MIXEntity)

        public POPSelect_INSPECT_MIXEntity(POPSelect_INSPECT_MIXEntity pPOPSelect_INSPECT_MIXEntity)
        {
            CORP_CODE = pPOPSelect_INSPECT_MIXEntity.CORP_CODE;
            CRUD = pPOPSelect_INSPECT_MIXEntity.CRUD;
            USER_CODE = pPOPSelect_INSPECT_MIXEntity.USER_CODE;
            USER_NAME = pPOPSelect_INSPECT_MIXEntity.USER_NAME;
            ERR_NO = pPOPSelect_INSPECT_MIXEntity.ERR_NO;
            ERR_MSG = pPOPSelect_INSPECT_MIXEntity.ERR_MSG;
            RTN_KEY = pPOPSelect_INSPECT_MIXEntity.RTN_KEY;
            RTN_SEQ = pPOPSelect_INSPECT_MIXEntity.RTN_SEQ;
            RTN_OTHERS = pPOPSelect_INSPECT_MIXEntity.RTN_OTHERS;
            LANGUAGE_TYPE = pPOPSelect_INSPECT_MIXEntity.LANGUAGE_TYPE;

            INOUT_TYPE = pPOPSelect_INSPECT_MIXEntity.INOUT_TYPE;
            INOUT_DATE = pPOPSelect_INSPECT_MIXEntity.INOUT_DATE;
            INOUT_SEQ = pPOPSelect_INSPECT_MIXEntity.INOUT_SEQ;
            INOUT_CODE = pPOPSelect_INSPECT_MIXEntity.INOUT_CODE;
            VEND_CODE = pPOPSelect_INSPECT_MIXEntity.VEND_CODE;
            INOUT_QTY = pPOPSelect_INSPECT_MIXEntity.INOUT_QTY;
            PART_UNIT = pPOPSelect_INSPECT_MIXEntity.PART_UNIT;

            USE_YN = pPOPSelect_INSPECT_MIXEntity.USE_YN;

            //메뉴별 추가 엔티티 입력
            WINDOW_NAME = pPOPSelect_INSPECT_MIXEntity.WINDOW_NAME;
            TERMINAL_CODE = pPOPSelect_INSPECT_MIXEntity.TERMINAL_CODE;
            PRINT_CODE = pPOPSelect_INSPECT_MIXEntity.PRINT_CODE;
            RESOURCE_CODE = pPOPSelect_INSPECT_MIXEntity.RESOURCE_CODE;
            RESOURCE_CODE = pPOPSelect_INSPECT_MIXEntity.RESOURCE_CODE;
            COLLECTION_DATE = pPOPSelect_INSPECT_MIXEntity.COLLECTION_DATE;
            PROPERTY_VALUE = pPOPSelect_INSPECT_MIXEntity.PROPERTY_VALUE;
            CONDITION_CODE = pPOPSelect_INSPECT_MIXEntity.CONDITION_CODE;
            COLLECTION_VALUE = pPOPSelect_INSPECT_MIXEntity.COLLECTION_VALUE;

            OPTION_CODE = pPOPSelect_INSPECT_MIXEntity.OPTION_CODE;

            PRODUCTION_ORDER_ID = pPOPSelect_INSPECT_MIXEntity.PRODUCTION_ORDER_ID;
            COMPLETE_YN = pPOPSelect_INSPECT_MIXEntity.COMPLETE_YN;
            TODAY = pPOPSelect_INSPECT_MIXEntity.COMPLETE_YN;
            PROCESS_CODE_MST = pPOPSelect_INSPECT_MIXEntity.PROCESS_CODE_MST;
            PART_CODE = pPOPSelect_INSPECT_MIXEntity.PART_CODE;
        }
        #endregion

    }
    public class frmPOPPartStockCheckEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String USER_NAME { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE


        //고정 엔티티


        //메뉴별 추가 엔티티 입력
        public String WINDOW_NAME { get; set; }
        public String TERMINAL_CODE { get; set; }
        public String PRINT_CODE { get; set; }

        public String RESOURCE_CODE { get; set; }
        public String PROCESS_CODE { get; set; }
        public String PROCESS_CODE_MST { get; set; }
        public String TODAY { get; set; }
        public String PART_CODE { get; set; }
        public String BARCODE { get; set; }



        public String PRODUCTION_ORDER_ID { get; set; }
        public String COMPLETE_YN { get; set; }

        #endregion

        #region 생성자 - POPSelect_INSPECT_MIXEntity()

        public frmPOPPartStockCheckEntity()
        {
        }

        #endregion

        #region 생성자 - POPSelect_INSPECT_MIXEntity(pPOPSelect_INSPECT_MIXEntity)

        public frmPOPPartStockCheckEntity(frmPOPPartStockCheckEntity pfrmPOPPartStockCheckEntity)
        {
            CORP_CODE = pfrmPOPPartStockCheckEntity.CORP_CODE;
            CRUD = pfrmPOPPartStockCheckEntity.CRUD;
            USER_CODE = pfrmPOPPartStockCheckEntity.USER_CODE;
            USER_NAME = pfrmPOPPartStockCheckEntity.USER_NAME;
            ERR_NO = pfrmPOPPartStockCheckEntity.ERR_NO;
            ERR_MSG = pfrmPOPPartStockCheckEntity.ERR_MSG;
            RTN_KEY = pfrmPOPPartStockCheckEntity.RTN_KEY;
            RTN_SEQ = pfrmPOPPartStockCheckEntity.RTN_SEQ;
            RTN_OTHERS = pfrmPOPPartStockCheckEntity.RTN_OTHERS;
            LANGUAGE_TYPE = pfrmPOPPartStockCheckEntity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
            WINDOW_NAME = pfrmPOPPartStockCheckEntity.WINDOW_NAME;
            TERMINAL_CODE = pfrmPOPPartStockCheckEntity.TERMINAL_CODE;
            PRINT_CODE = pfrmPOPPartStockCheckEntity.PRINT_CODE;
            RESOURCE_CODE = pfrmPOPPartStockCheckEntity.RESOURCE_CODE;
            RESOURCE_CODE = pfrmPOPPartStockCheckEntity.RESOURCE_CODE;
            BARCODE = pfrmPOPPartStockCheckEntity.BARCODE;

            PRODUCTION_ORDER_ID = pfrmPOPPartStockCheckEntity.PRODUCTION_ORDER_ID;
            COMPLETE_YN = pfrmPOPPartStockCheckEntity.COMPLETE_YN;
            TODAY = pfrmPOPPartStockCheckEntity.COMPLETE_YN;
            PROCESS_CODE_MST = pfrmPOPPartStockCheckEntity.PROCESS_CODE_MST;
            PART_CODE = pfrmPOPPartStockCheckEntity.PART_CODE;
        }
        #endregion

    }
    public class POPMain_ProductEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String USER_NAME { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE


        //고정 엔티티


        //메뉴별 추가 엔티티 입력
        public String WINDOW_NAME { get; set; }
        public String TERMINAL_CODE { get; set; }
        public String PRINT_CODE { get; set; }

        public String RESOURCE_CODE { get; set; }
        public String PROCESS_CODE { get; set; }
        public String PROCESS_CODE_MST { get; set; }
        public String TODAY { get; set; }
        public String PART_CODE { get; set; }

        //메뉴별 추가 엔티티 입력
        public String COLLECTION_DATE { get; set; }
        public String PROPERTY_VALUE { get; set; }
        public String CONDITION_CODE { get; set; }
        public String OPTION_CODE { get; set; }
        public String COLLECTION_VALUE { get; set; }
        public String COLLECTION_VALUE_STR { get; set; }

        public String PRODUCTION_ORDER_ID { get; set; }
        public String COMPLETE_YN { get; set; }
        public String DOCUMENT_TYPE { get; set; }

        #endregion

        #region 생성자 - POPWorkResult_MIXEntity()

        public POPMain_ProductEntity()
        {
        }

        #endregion

        #region 생성자 - POPWorkResult_MIXEntity(pPOPWorkResult_MIXEntity)

        public POPMain_ProductEntity(POPMain_ProductEntity pPOPMain_ProductEntity)
        {
            CORP_CODE = pPOPMain_ProductEntity.CORP_CODE;
            CRUD = pPOPMain_ProductEntity.CRUD;
            USER_CODE = pPOPMain_ProductEntity.USER_CODE;
            USER_NAME = pPOPMain_ProductEntity.USER_NAME;
            ERR_NO = pPOPMain_ProductEntity.ERR_NO;
            ERR_MSG = pPOPMain_ProductEntity.ERR_MSG;
            RTN_KEY = pPOPMain_ProductEntity.RTN_KEY;
            RTN_SEQ = pPOPMain_ProductEntity.RTN_SEQ;
            RTN_OTHERS = pPOPMain_ProductEntity.RTN_OTHERS;
            LANGUAGE_TYPE = pPOPMain_ProductEntity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
            WINDOW_NAME = pPOPMain_ProductEntity.WINDOW_NAME;
            TERMINAL_CODE = pPOPMain_ProductEntity.TERMINAL_CODE;
            PRINT_CODE = pPOPMain_ProductEntity.PRINT_CODE;
            RESOURCE_CODE = pPOPMain_ProductEntity.RESOURCE_CODE;
            RESOURCE_CODE = pPOPMain_ProductEntity.RESOURCE_CODE;
            COLLECTION_DATE = pPOPMain_ProductEntity.COLLECTION_DATE;
            PROPERTY_VALUE = pPOPMain_ProductEntity.PROPERTY_VALUE;
            CONDITION_CODE = pPOPMain_ProductEntity.CONDITION_CODE;
            OPTION_CODE = pPOPMain_ProductEntity.OPTION_CODE;
            COLLECTION_VALUE = pPOPMain_ProductEntity.COLLECTION_VALUE;
            COLLECTION_VALUE_STR = pPOPMain_ProductEntity.COLLECTION_VALUE_STR;

            PRODUCTION_ORDER_ID = pPOPMain_ProductEntity.PRODUCTION_ORDER_ID;
            COMPLETE_YN = pPOPMain_ProductEntity.COMPLETE_YN;
            TODAY = pPOPMain_ProductEntity.COMPLETE_YN;
            PROCESS_CODE_MST = pPOPMain_ProductEntity.PROCESS_CODE_MST;
            PART_CODE = pPOPMain_ProductEntity.PART_CODE;
            DOCUMENT_TYPE = pPOPMain_ProductEntity.DOCUMENT_TYPE;
        }
        #endregion

    }

    public class POPWorkResult_MIXEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String USER_NAME { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE
       


        //고정 엔티티


        //메뉴별 추가 엔티티 입력
        public String WINDOW_NAME { get; set; }
        public String TERMINAL_CODE { get; set; }
        public String PRINT_CODE { get; set; }

        public String RESOURCE_CODE { get; set; }
        public String PROCESS_CODE { get; set; }
        public String PROCESS_CODE_MST { get; set; }
        public String TODAY { get; set; }
        public String PART_CODE { get; set; }

        //메뉴별 추가 엔티티 입력
        public String COLLECTION_DATE { get; set; }
        public String PROPERTY_VALUE { get; set; }
        public String CONDITION_CODE { get; set; }
        public String OPTION_CODE { get; set; }
        public String COLLECTION_VALUE { get; set; }
        public String COLLECTION_VALUE_STR { get; set; }

        public String PRODUCTION_ORDER_ID { get; set; }
        public String COMPLETE_YN { get; set; }
        public String DOCUMENT_TYPE { get; set; }

        #endregion

        #region 생성자 - POPWorkResult_MIXEntity()

        public POPWorkResult_MIXEntity()
        {
        }

        #endregion

        #region 생성자 - POPWorkResult_MIXEntity(pPOPWorkResult_MIXEntity)

        public POPWorkResult_MIXEntity(POPWorkResult_MIXEntity pPOPWorkResult_MIXEntity)
        {
            CORP_CODE = pPOPWorkResult_MIXEntity.CORP_CODE;
            CRUD = pPOPWorkResult_MIXEntity.CRUD;
            USER_CODE = pPOPWorkResult_MIXEntity.USER_CODE;
            USER_NAME = pPOPWorkResult_MIXEntity.USER_NAME;
            ERR_NO = pPOPWorkResult_MIXEntity.ERR_NO;
            ERR_MSG = pPOPWorkResult_MIXEntity.ERR_MSG;
            RTN_KEY = pPOPWorkResult_MIXEntity.RTN_KEY;
            RTN_SEQ = pPOPWorkResult_MIXEntity.RTN_SEQ;
            RTN_OTHERS = pPOPWorkResult_MIXEntity.RTN_OTHERS;
            LANGUAGE_TYPE = pPOPWorkResult_MIXEntity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
            WINDOW_NAME = pPOPWorkResult_MIXEntity.WINDOW_NAME;
            TERMINAL_CODE = pPOPWorkResult_MIXEntity.TERMINAL_CODE;
            PRINT_CODE = pPOPWorkResult_MIXEntity.PRINT_CODE;
            RESOURCE_CODE = pPOPWorkResult_MIXEntity.RESOURCE_CODE;
            RESOURCE_CODE = pPOPWorkResult_MIXEntity.RESOURCE_CODE;
            COLLECTION_DATE = pPOPWorkResult_MIXEntity.COLLECTION_DATE;
            PROPERTY_VALUE = pPOPWorkResult_MIXEntity.PROPERTY_VALUE;
            CONDITION_CODE = pPOPWorkResult_MIXEntity.CONDITION_CODE;
            OPTION_CODE = pPOPWorkResult_MIXEntity.OPTION_CODE;
            COLLECTION_VALUE = pPOPWorkResult_MIXEntity.COLLECTION_VALUE;
            COLLECTION_VALUE_STR = pPOPWorkResult_MIXEntity.COLLECTION_VALUE_STR;

            PRODUCTION_ORDER_ID = pPOPWorkResult_MIXEntity.PRODUCTION_ORDER_ID;
            COMPLETE_YN = pPOPWorkResult_MIXEntity.COMPLETE_YN;
            TODAY = pPOPWorkResult_MIXEntity.COMPLETE_YN;
            PROCESS_CODE_MST = pPOPWorkResult_MIXEntity.PROCESS_CODE_MST;
            PART_CODE = pPOPWorkResult_MIXEntity.PART_CODE;
            DOCUMENT_TYPE = pPOPWorkResult_MIXEntity.DOCUMENT_TYPE;
        }
        #endregion

    }
    public class POPWorkResult_T50Entity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String USER_NAME { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE


        //고정 엔티티


        //메뉴별 추가 엔티티 입력
        public String WINDOW_NAME { get; set; }
        public String TERMINAL_CODE { get; set; }
        public String PRINT_CODE { get; set; }

        public String RESOURCE_CODE { get; set; }
        public String PROCESS_CODE { get; set; }
        public String PROCESS_CODE_MST { get; set; }
        public String TODAY { get; set; }
        public String PART_CODE { get; set; }

        //메뉴별 추가 엔티티 입력
        public String COLLECTION_DATE { get; set; }
        public String PROPERTY_VALUE { get; set; }
        public String CONDITION_CODE { get; set; }
        public String OPTION_CODE { get; set; }
        public String COLLECTION_VALUE { get; set; }
        public String COLLECTION_VALUE_STR { get; set; }

        public String PRODUCTION_ORDER_ID { get; set; }

        public String PRODUCTION_ORDER_SEQ { get; set; }
        public String COMPLETE_YN { get; set; }

        #endregion

        #region 생성자 - POPWorkResult_T50Entity()

        public POPWorkResult_T50Entity()
        {
        }

        #endregion

        #region 생성자 - POPWorkResult_T50Entity(pPOPWorkResult_T50Entity)

        public POPWorkResult_T50Entity(POPWorkResult_T50Entity pPOPWorkResult_T50Entity)
        {
            CORP_CODE = pPOPWorkResult_T50Entity.CORP_CODE;
            CRUD = pPOPWorkResult_T50Entity.CRUD;
            USER_CODE = pPOPWorkResult_T50Entity.USER_CODE;
            USER_NAME = pPOPWorkResult_T50Entity.USER_NAME;
            ERR_NO = pPOPWorkResult_T50Entity.ERR_NO;
            ERR_MSG = pPOPWorkResult_T50Entity.ERR_MSG;
            RTN_KEY = pPOPWorkResult_T50Entity.RTN_KEY;
            RTN_SEQ = pPOPWorkResult_T50Entity.RTN_SEQ;
            RTN_OTHERS = pPOPWorkResult_T50Entity.RTN_OTHERS;
            LANGUAGE_TYPE = pPOPWorkResult_T50Entity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
            WINDOW_NAME = pPOPWorkResult_T50Entity.WINDOW_NAME;
            TERMINAL_CODE = pPOPWorkResult_T50Entity.TERMINAL_CODE;
            PRINT_CODE = pPOPWorkResult_T50Entity.PRINT_CODE;
            RESOURCE_CODE = pPOPWorkResult_T50Entity.RESOURCE_CODE;
            RESOURCE_CODE = pPOPWorkResult_T50Entity.RESOURCE_CODE;
            COLLECTION_DATE = pPOPWorkResult_T50Entity.COLLECTION_DATE;
            PROPERTY_VALUE = pPOPWorkResult_T50Entity.PROPERTY_VALUE;
            CONDITION_CODE = pPOPWorkResult_T50Entity.CONDITION_CODE;
            OPTION_CODE = pPOPWorkResult_T50Entity.OPTION_CODE;
            COLLECTION_VALUE = pPOPWorkResult_T50Entity.COLLECTION_VALUE;
            COLLECTION_VALUE_STR = pPOPWorkResult_T50Entity.COLLECTION_VALUE_STR;

            PRODUCTION_ORDER_ID = pPOPWorkResult_T50Entity.PRODUCTION_ORDER_ID;
            PRODUCTION_ORDER_SEQ = pPOPWorkResult_T50Entity.PRODUCTION_ORDER_SEQ;
            COMPLETE_YN = pPOPWorkResult_T50Entity.COMPLETE_YN;
            TODAY = pPOPWorkResult_T50Entity.COMPLETE_YN;
            PROCESS_CODE_MST = pPOPWorkResult_T50Entity.PROCESS_CODE_MST;
            PART_CODE = pPOPWorkResult_T50Entity.PART_CODE;
        }
        #endregion

    }

    public class frmPOPMain_PRESS_LINEEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String USER_NAME { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE


        //고정 엔티티


        //메뉴별 추가 엔티티 입력
        public String WINDOW_NAME { get; set; }
        public String TERMINAL_CODE { get; set; }
        public String PRINT_CODE { get; set; }

        public String RESOURCE_CODE { get; set; }
        public String PROCESS_CODE { get; set; }
        public String PROCESS_CODE_MST { get; set; }
        public String TODAY { get; set; }
        public String PART_CODE { get; set; }

        //메뉴별 추가 엔티티 입력
        public String COLLECTION_DATE { get; set; }
        public String PROPERTY_VALUE { get; set; }
        public String CONDITION_CODE { get; set; }
        public String COLLECTION_VALUE { get; set; }

        public String PRODUCTION_ORDER_ID { get; set; }
        public String COMPLETE_YN { get; set; }
        public String USA_LOT_YN { get; set; }
        public String NEW_LOT { get; set; }
        public String LOT_ID { get; set; }

        #endregion

        #region 생성자 - POPSelect_INSPECT_MIXEntity()

        public frmPOPMain_PRESS_LINEEntity()
        {
        }

        #endregion

        #region 생성자 - POPSelect_INSPECT_MIXEntity(pPOPSelect_INSPECT_MIXEntity)

        public frmPOPMain_PRESS_LINEEntity(frmPOPMain_PRESS_LINEEntity pfrmPOPMain_PRESS_LINEEntity)
        {
            CORP_CODE = pfrmPOPMain_PRESS_LINEEntity.CORP_CODE;
            CRUD = pfrmPOPMain_PRESS_LINEEntity.CRUD;
            USER_CODE = pfrmPOPMain_PRESS_LINEEntity.USER_CODE;
            USER_NAME = pfrmPOPMain_PRESS_LINEEntity.USER_NAME;
            ERR_NO = pfrmPOPMain_PRESS_LINEEntity.ERR_NO;
            ERR_MSG = pfrmPOPMain_PRESS_LINEEntity.ERR_MSG;
            RTN_KEY = pfrmPOPMain_PRESS_LINEEntity.RTN_KEY;
            RTN_SEQ = pfrmPOPMain_PRESS_LINEEntity.RTN_SEQ;
            RTN_OTHERS = pfrmPOPMain_PRESS_LINEEntity.RTN_OTHERS;
            LANGUAGE_TYPE = pfrmPOPMain_PRESS_LINEEntity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
            WINDOW_NAME = pfrmPOPMain_PRESS_LINEEntity.WINDOW_NAME;
            TERMINAL_CODE = pfrmPOPMain_PRESS_LINEEntity.TERMINAL_CODE;
            PRINT_CODE = pfrmPOPMain_PRESS_LINEEntity.PRINT_CODE;
            RESOURCE_CODE = pfrmPOPMain_PRESS_LINEEntity.RESOURCE_CODE;
            RESOURCE_CODE = pfrmPOPMain_PRESS_LINEEntity.RESOURCE_CODE;
            COLLECTION_DATE = pfrmPOPMain_PRESS_LINEEntity.COLLECTION_DATE;
            PROPERTY_VALUE = pfrmPOPMain_PRESS_LINEEntity.PROPERTY_VALUE;
            CONDITION_CODE = pfrmPOPMain_PRESS_LINEEntity.CONDITION_CODE;
            COLLECTION_VALUE = pfrmPOPMain_PRESS_LINEEntity.COLLECTION_VALUE;

            USA_LOT_YN = pfrmPOPMain_PRESS_LINEEntity.USA_LOT_YN;
            NEW_LOT = pfrmPOPMain_PRESS_LINEEntity.NEW_LOT;
            LOT_ID = pfrmPOPMain_PRESS_LINEEntity.LOT_ID;

            PRODUCTION_ORDER_ID = pfrmPOPMain_PRESS_LINEEntity.PRODUCTION_ORDER_ID;
            COMPLETE_YN = pfrmPOPMain_PRESS_LINEEntity.COMPLETE_YN;
            TODAY = pfrmPOPMain_PRESS_LINEEntity.COMPLETE_YN;
            PROCESS_CODE_MST = pfrmPOPMain_PRESS_LINEEntity.PROCESS_CODE_MST;
            PART_CODE = pfrmPOPMain_PRESS_LINEEntity.PART_CODE;
        }
        #endregion

    }

    public class GatheringMainEntity
    {
        #region Property

        //사용자 설정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE


        public String COLLECTION_CODE { get; set; } // 수집 위치
        public String COLLECTION_DATE { get; set; } // 수집 시간
        public String PROPERTY_VALUE { get; set; } // 속성값

        public String CONDITION_CODE { get; set; } // 조건 값
        public String COLLECTION_VALUE { get; set; } //수집 데이터 값

        public String REMARK { get; set; } // 비고
        public String USE_YN { get; set; } // 사용유무


        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }


        #endregion

        #region 생성자 - GatheringMainEntity()

        public GatheringMainEntity()
        {
        }

        #endregion

        #region 생성자 - GatheringMainEntity(pGatheringMainEntity)

        public GatheringMainEntity(GatheringMainEntity pGatheringMainEntity)
        {
            CORP_CODE = pGatheringMainEntity.CORP_CODE;
            CRUD = pGatheringMainEntity.CRUD;
            USER_CODE = pGatheringMainEntity.USER_CODE;
            LANGUAGE_TYPE = pGatheringMainEntity.LANGUAGE_TYPE;
            REMARK = pGatheringMainEntity.REMARK;
            USE_YN = pGatheringMainEntity.USE_YN;

            ERR_NO = pGatheringMainEntity.ERR_NO;
            ERR_MSG = pGatheringMainEntity.ERR_MSG;
            RTN_KEY = pGatheringMainEntity.RTN_KEY;
            RTN_SEQ = pGatheringMainEntity.RTN_SEQ;
            RTN_OTHERS = pGatheringMainEntity.RTN_OTHERS;
        }

        #endregion

    }

    public class GatheringUcCtlEntity
    {
        #region Property

        //사용자 설정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE


        public String RESOURCE_CODE { get; set; } // 수집 위치
        public String RESOURCE_NAME { get; set; } // 수집 시간
        public String PROCESS_CODE { get; set; } // 속성값

        public String PROCESS_NAME { get; set; } // 조건 값
        public String RESOURCE_TYPE { get; set; } //수집 데이터 값

        public String RESOURCE_SERIAL { get; set; } // 비고
        public String RESOURCE_IP { get; set; } // 사용유무
        public String RESOURCE_PORT { get; set; } // 사용유무
        public String RESOURCE_INTERVAL { get; set; } // 사용유무
        public String SETTING_YN { get; set; } // 사용유무

        public String RESOURCE_GUBN { get; set; } // 사용유무

        public String GROUP_CNT { get; set; } // 그룹

        public String RESOURCE_SERVER { get; set; } // 수집 서버
        public String ATTR1 { get; set; } // 속성1
        public String ATTR2 { get; set; } // 속성2
        public Decimal VALUES { get; set; } // 수집 데이터

        public String STRING_VALUES { get; set; } // 수집 데이터
        


        public String E_EQUIPMENT_CODE { get; set; } // 설비코드
        public String E_GROUP_CODE { get; set; } // 그룹코드
        public String E_STATUS_CODE { get; set; } // 상태코드

        public String E_HW_CODE { get; set; } // 상태코드
        public String E_AVG_P_VOLTAGE { get; set; } // 평균상전압
        public String E_AVG_L_VOLTAGE { get; set; } // 평균선간전압
        public String E_AVG_VOL_FACTOR { get; set; } // 평균전압파고율
        public String E_AVG_P_CURRENT { get; set; } // 평균상전류
        public String E_AVG_CUR_FACTOR { get; set; } // 평균전류파고율
        public String E_ACTIVE_POWER { get; set; } // 유효전력량
        public String E_REACTIVE_POWER { get; set; } // 무효전력량
        public String E_POWER_FACTOR { get; set; } // 역률
        public String E_AVG_FREQUENCY { get; set; } // 평균주파수
        public String E_AVG_VOLTAGE { get; set; } // 평균전압
        public String E_AVG_CURRENT { get; set; } // 평균전류
        public String E_TEMP { get; set; } // 평균온도
        public String E_HUMI { get; set; } // 평균온도
        public String E_VOC { get; set; } // 유기화합물
        public String E_AVG_VOL_HAMONIC { get; set; } // 평균전압고조파

        public String E_AVG_CURR_HAMONIC { get; set; } // 평균전압고조파
        public String E_POWER_CONSUMPTION { get; set; } // 누적전력량
        public String E_ELECTRIC_CHARGE { get; set; } // 누적요금
        public String E_RS_LINE_VOLTAGE { get; set; } // RS간선간전압
        public String E_ST_LINE_VOLTAGE { get; set; } // ST간선간전압
        public String E_TR_LINE_VOLTAGE { get; set; } // TR간선간전압
        public String E_MONTH_POWER_CONSUMPTION { get; set; } // 당월누적전력량
        public String E_MONTH_ELECTRIC_CHARGE { get; set; } // 당월누적요금
        public String E_R_CURRENT { get; set; } // R상전류
        public String E_S_CURRENT { get; set; } // S상전류
        public String E_T_CURRENT { get; set; } // T상전류
        public String E_N_CURRENT { get; set; } // N상전류
        public String E_R_VOLTAGE { get; set; } // R상전압
        public String E_S_VOLTAGE { get; set; } // S상전압
        public String E_T_VOLTAGE { get; set; } // T상전압
        public String E_N_VOLTAGE { get; set; } // N상전압

        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }

        #endregion

        #region 생성자 - GatheringUcCtlEntity()

        public GatheringUcCtlEntity()
        {
        }

        #endregion

        #region 생성자 - GatheringUcCtlEntity(pGatheringUcCtlEntity)

        public GatheringUcCtlEntity(GatheringUcCtlEntity pGatheringUcCtlEntity)
        {
            CORP_CODE = pGatheringUcCtlEntity.CORP_CODE;
            CRUD = pGatheringUcCtlEntity.CRUD;
            USER_CODE = pGatheringUcCtlEntity.USER_CODE;
            LANGUAGE_TYPE = pGatheringUcCtlEntity.LANGUAGE_TYPE;

            RESOURCE_CODE = pGatheringUcCtlEntity.RESOURCE_CODE;
            RESOURCE_NAME = pGatheringUcCtlEntity.RESOURCE_NAME;
            PROCESS_CODE  = pGatheringUcCtlEntity.PROCESS_CODE;
            PROCESS_NAME = pGatheringUcCtlEntity.PROCESS_NAME;
            RESOURCE_TYPE = pGatheringUcCtlEntity.RESOURCE_TYPE;
            RESOURCE_SERIAL = pGatheringUcCtlEntity.RESOURCE_SERIAL;
            RESOURCE_IP = pGatheringUcCtlEntity.RESOURCE_IP;
            RESOURCE_PORT = pGatheringUcCtlEntity.RESOURCE_PORT;
            RESOURCE_INTERVAL = pGatheringUcCtlEntity.RESOURCE_INTERVAL;
            RESOURCE_GUBN = pGatheringUcCtlEntity.RESOURCE_GUBN;
            SETTING_YN = pGatheringUcCtlEntity.SETTING_YN;
            GROUP_CNT = pGatheringUcCtlEntity.GROUP_CNT;
            ERR_NO = pGatheringUcCtlEntity.ERR_NO;
            ERR_MSG = pGatheringUcCtlEntity.ERR_MSG;
            RTN_KEY = pGatheringUcCtlEntity.RTN_KEY;
            RTN_SEQ = pGatheringUcCtlEntity.RTN_SEQ;
            RTN_OTHERS = pGatheringUcCtlEntity.RTN_OTHERS;

            RESOURCE_SERVER = pGatheringUcCtlEntity.RESOURCE_SERVER;
            ATTR1 = pGatheringUcCtlEntity.ATTR1;
            ATTR2 = pGatheringUcCtlEntity.ATTR2;
            VALUES = pGatheringUcCtlEntity.VALUES;
            STRING_VALUES = pGatheringUcCtlEntity.STRING_VALUES;

            //코아칩스 전력 데이터

             E_EQUIPMENT_CODE = pGatheringUcCtlEntity.E_EQUIPMENT_CODE;
            E_GROUP_CODE = pGatheringUcCtlEntity.E_GROUP_CODE;
            E_STATUS_CODE = pGatheringUcCtlEntity.E_STATUS_CODE;
            E_HW_CODE = pGatheringUcCtlEntity.E_HW_CODE;
            E_AVG_P_VOLTAGE = pGatheringUcCtlEntity.E_AVG_P_VOLTAGE;
            E_AVG_L_VOLTAGE = pGatheringUcCtlEntity.E_AVG_L_VOLTAGE;
            E_AVG_VOL_FACTOR = pGatheringUcCtlEntity.E_AVG_VOL_FACTOR;
            E_AVG_P_CURRENT = pGatheringUcCtlEntity.E_AVG_P_CURRENT;
            E_AVG_CUR_FACTOR = pGatheringUcCtlEntity.E_AVG_CUR_FACTOR;
            E_ACTIVE_POWER = pGatheringUcCtlEntity.E_ACTIVE_POWER;
            E_REACTIVE_POWER = pGatheringUcCtlEntity.E_REACTIVE_POWER;
            E_POWER_FACTOR = pGatheringUcCtlEntity.E_POWER_FACTOR;
            E_AVG_FREQUENCY = pGatheringUcCtlEntity.E_AVG_FREQUENCY;
            E_AVG_VOLTAGE = pGatheringUcCtlEntity.E_AVG_VOLTAGE;
            E_AVG_CURRENT = pGatheringUcCtlEntity.E_AVG_CURRENT;
            E_TEMP = pGatheringUcCtlEntity.E_TEMP;
            E_HUMI = pGatheringUcCtlEntity.E_HUMI;
            E_VOC = pGatheringUcCtlEntity.E_VOC;
            E_AVG_VOL_HAMONIC = pGatheringUcCtlEntity.E_AVG_VOL_HAMONIC;
            E_AVG_CURR_HAMONIC = pGatheringUcCtlEntity.E_AVG_CURR_HAMONIC;
            E_POWER_CONSUMPTION = pGatheringUcCtlEntity.E_POWER_CONSUMPTION;
            E_ELECTRIC_CHARGE = pGatheringUcCtlEntity.E_ELECTRIC_CHARGE;
            E_RS_LINE_VOLTAGE = pGatheringUcCtlEntity.E_RS_LINE_VOLTAGE;
            E_ST_LINE_VOLTAGE = pGatheringUcCtlEntity.E_ST_LINE_VOLTAGE;
            E_TR_LINE_VOLTAGE = pGatheringUcCtlEntity.E_TR_LINE_VOLTAGE;
            E_MONTH_POWER_CONSUMPTION = pGatheringUcCtlEntity.E_MONTH_POWER_CONSUMPTION;
            E_MONTH_ELECTRIC_CHARGE = pGatheringUcCtlEntity.E_MONTH_ELECTRIC_CHARGE;
            E_R_CURRENT = pGatheringUcCtlEntity.E_R_CURRENT;
            E_S_CURRENT = pGatheringUcCtlEntity.E_S_CURRENT;
            E_T_CURRENT = pGatheringUcCtlEntity.E_T_CURRENT;
            E_N_CURRENT = pGatheringUcCtlEntity.E_N_CURRENT;
            E_R_VOLTAGE = pGatheringUcCtlEntity.E_R_VOLTAGE;
            E_S_VOLTAGE = pGatheringUcCtlEntity.E_S_VOLTAGE;
            E_T_VOLTAGE = pGatheringUcCtlEntity.E_T_VOLTAGE;
            E_N_VOLTAGE = pGatheringUcCtlEntity.E_N_VOLTAGE;
        }

        #endregion

    }

    public class GatheringSettingUcCtlEntity
    {
        #region Property

        //사용자 설정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE


        public String RESOURCE_CODE { get; set; } // 수집 위치
        public String RESOURCE_NAME { get; set; } // 수집 시간
        public String PROCESS_CODE { get; set; } // 속성값

        public String PROCESS_NAME { get; set; } // 조건 값
        public String RESOURCE_TYPE { get; set; } //수집 데이터 값

        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }

        #endregion

        #region 생성자 - GatheringUcCtlEntity()

        public GatheringSettingUcCtlEntity()
        {
        }

        #endregion

        #region 생성자 - GatheringSettingUcCtlEntity(pGatheringSettingUcCtlEntity)

        public GatheringSettingUcCtlEntity(GatheringSettingUcCtlEntity pGatheringSettingUcCtlEntity)
        {
            CORP_CODE     = pGatheringSettingUcCtlEntity.CORP_CODE;
            CRUD          = pGatheringSettingUcCtlEntity.CRUD;
            USER_CODE     = pGatheringSettingUcCtlEntity.USER_CODE;
            LANGUAGE_TYPE = pGatheringSettingUcCtlEntity.LANGUAGE_TYPE;

            RESOURCE_CODE = pGatheringSettingUcCtlEntity.RESOURCE_CODE;
            RESOURCE_NAME = pGatheringSettingUcCtlEntity.RESOURCE_NAME;
            PROCESS_CODE  = pGatheringSettingUcCtlEntity.PROCESS_CODE;
            PROCESS_NAME  = pGatheringSettingUcCtlEntity.PROCESS_NAME;
            RESOURCE_TYPE = pGatheringSettingUcCtlEntity.RESOURCE_TYPE;
  
            ERR_NO        = pGatheringSettingUcCtlEntity.ERR_NO;
            ERR_MSG       = pGatheringSettingUcCtlEntity.ERR_MSG;
            RTN_KEY       = pGatheringSettingUcCtlEntity.RTN_KEY;
            RTN_SEQ       = pGatheringSettingUcCtlEntity.RTN_SEQ;
            RTN_OTHERS    = pGatheringSettingUcCtlEntity.RTN_OTHERS;



        }

        #endregion

    }

    //CORE UserEntity사용안하면 주석 풀기
    /*
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

            FTP_IP_PORT = pUserEntity.FTP_IP_PORT;
            FTP_ID = pUserEntity.FTP_ID;
            FTP_PW = pUserEntity.FTP_PW;
        }

        #endregion

    }
    */
    public class frmPOPSelect_WorkOrderDoc_COSMETICSEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE


        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력
        public String WINDOW_NAME { get; set; }
        public String P_WINDOW_NAME { get; set; }
        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        public String PROCESS_CODE { get; set; }
        public String PROCESS_CODE_MST { get; set; }
        public String PART_NAME { get; set; } //
        public String PART_TYPE { get; set; } //
        public String VEND_ANME { get; set; } //
        public String FILE_NAME { get; set; } //
        public String PRODUCTION_ORDER_ID { get; set; } //
        public String MAKE_NO { get; set; } //
        public String TERMINAL_CODE { get; set; } //
        public String PRODUCTION_RESULT_QTY { get; set; } //
        public String APPROVER_SIGN_CHK { get; set; } //
        public String PRODUCTION_NG_RESULT_QTY { get; set; } //
        public String PART_CODE { get; set; } //
        

        //메뉴별 추가 엔티티 입력
        public String RESOURCE_CODE { get; set; }
        public String COLLECTION_DATE { get; set; }
        public String PROPERTY_VALUE { get; set; }
        public String CONDITION_CODE { get; set; }
        public String COLLECTION_VALUE { get; set; }
        public String SEMI_PRODUCTION_RESULT_QTY { get; set; } //

        #endregion

        #region 생성자 - frmPOPSelect_WorkOrderDoc_COSMETICSEntity()

        public frmPOPSelect_WorkOrderDoc_COSMETICSEntity()
        {
        }

        #endregion

        #region 생성자 - frmPOPSelect_WorkOrderDoc_COSMETICSEntity(pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity)

        public frmPOPSelect_WorkOrderDoc_COSMETICSEntity(frmPOPSelect_WorkOrderDoc_COSMETICSEntity pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity)
        {
            CORP_CODE = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.CORP_CODE;
            CRUD = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.CRUD;
            USER_CODE = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.USER_CODE;

            pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.WINDOW_NAME = WINDOW_NAME;
            pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.P_WINDOW_NAME = P_WINDOW_NAME;
            
            LANGUAGE_TYPE = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.LANGUAGE_TYPE;
            pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.DATE_FROM = DATE_FROM;
            pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.DATE_TO = DATE_TO;
            pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.PROCESS_CODE = PROCESS_CODE;
            pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.PART_TYPE = PART_TYPE;

            ERR_NO = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.ERR_NO;
            ERR_MSG = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.ERR_MSG;
            RTN_KEY = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.RTN_KEY;
            RTN_SEQ = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.RTN_SEQ;
            RTN_OTHERS = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.RTN_OTHERS;

            PROCESS_CODE_MST = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.PROCESS_CODE_MST;

            FILE_NAME = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.FILE_NAME;
            PRODUCTION_ORDER_ID = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.PRODUCTION_ORDER_ID;
            MAKE_NO = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.MAKE_NO;

            TERMINAL_CODE = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.TERMINAL_CODE;
            PRODUCTION_RESULT_QTY = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.PRODUCTION_RESULT_QTY;
            APPROVER_SIGN_CHK = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.APPROVER_SIGN_CHK;
            PRODUCTION_NG_RESULT_QTY = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.PRODUCTION_NG_RESULT_QTY;
            //메뉴별 추가 엔티티 입력

            RESOURCE_CODE = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.RESOURCE_CODE;
            COLLECTION_DATE = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.COLLECTION_DATE;
            PROPERTY_VALUE = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.PROPERTY_VALUE;
            CONDITION_CODE = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.CONDITION_CODE;
            COLLECTION_VALUE = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.COLLECTION_VALUE;
            SEMI_PRODUCTION_RESULT_QTY = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.SEMI_PRODUCTION_RESULT_QTY;

            PART_CODE = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.PART_CODE;
        }

        #endregion

    }

    public class frmPOPSelect_WorkRequestDoc_COSMETICSEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE


        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력
        public String WINDOW_NAME { get; set; }
        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        public String PROCESS_CODE { get; set; }
        public String PROCESS_CODE_MST { get; set; }
        public String PART_NAME { get; set; } //
        public String PART_TYPE { get; set; } //
        public String VEND_ANME { get; set; } //
        public String FILE_NAME { get; set; } //
        public String PRODUCTION_ORDER_ID { get; set; } //

        #endregion

        #region 생성자 - frmPOPSelect_WorkRequestDoc_COSMETICSEntity()

        public frmPOPSelect_WorkRequestDoc_COSMETICSEntity()
        {
        }

        #endregion

        #region 생성자 - frmPOPSelect_WorkRequestDoc_COSMETICSEntity(pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity)

        public frmPOPSelect_WorkRequestDoc_COSMETICSEntity(frmPOPSelect_WorkRequestDoc_COSMETICSEntity pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity)
        {
            CORP_CODE = pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.CORP_CODE;
            CRUD = pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.CRUD;
            USER_CODE = pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.USER_CODE;

            pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.WINDOW_NAME = WINDOW_NAME;
            LANGUAGE_TYPE = pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.LANGUAGE_TYPE;
            pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.DATE_FROM = DATE_FROM;
            pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.DATE_TO = DATE_TO;
            pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.PROCESS_CODE = PROCESS_CODE;
            pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.PART_TYPE = PART_TYPE;

            ERR_NO = pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.ERR_NO;
            ERR_MSG = pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.ERR_MSG;
            RTN_KEY = pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.RTN_KEY;
            RTN_SEQ = pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.RTN_SEQ;
            RTN_OTHERS = pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.RTN_OTHERS;

            PROCESS_CODE_MST = pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.PROCESS_CODE_MST;

            FILE_NAME = pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.FILE_NAME;
            PRODUCTION_ORDER_ID = pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.PRODUCTION_ORDER_ID;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }
    

    public class frmPOPMain_OUT_COSMETICSEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE


        /*
        _luINOUT_ID
        _luINOUT_DATE
        _luINOUT_SEQ
        _luINOUT_TYPE
        _luREFERENCE_ID
        _luPART_CODE
        _luPART_NAME
        _luVEND_CODE
        _luVEND_NAME
        _luINOUT_QTY
        _luUNITCOST_CURRENCY_CODE
        _luUNITCOST
        _luCOST
        _luREMARK
        */
        public String INOUT_ID { get; set; }
        public String INOUT_DATE { get; set; }
        public String INOUT_SEQ { get; set; }
        public String INOUT_TYPE { get; set; }
        public String REFERENCE_ID { get; set; }
        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String VEND_CODE { get; set; }
        public String VEND_NAME { get; set; }
        public String INOUT_QTY { get; set; }
        public String UNITCOST_CURRENCY_CODE { get; set; }
        public String UNITCOST { get; set; }
        public String COST { get; set; }
        public String REMARK { get; set; }

        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        // -----------
        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String INOUT_CODE { get; set; }
        public String USE_YN { get; set; }
        public String TERMINAL_CODE { get; set; }
        //고정 엔티티
        

        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - frmPOPMain_OUT_COSMETICSEntity()

        public frmPOPMain_OUT_COSMETICSEntity()
        {
        }

        #endregion

        #region 생성자 - frmPOPMain_OUT_COSMETICSEntity(frmPOPMain_OUT_COSMETICSEntity pMaterialInRegisterEntity)

        public frmPOPMain_OUT_COSMETICSEntity(frmPOPMain_OUT_COSMETICSEntity pfrmPOPMain_OUT_COSMETICSEntity)
        {
            CORP_CODE = pfrmPOPMain_OUT_COSMETICSEntity.CORP_CODE;
            CRUD = pfrmPOPMain_OUT_COSMETICSEntity.CRUD;
            USER_CODE = pfrmPOPMain_OUT_COSMETICSEntity.USER_CODE;
            LANGUAGE_TYPE = pfrmPOPMain_OUT_COSMETICSEntity.LANGUAGE_TYPE;

            ERR_NO = pfrmPOPMain_OUT_COSMETICSEntity.ERR_NO;
            ERR_MSG = pfrmPOPMain_OUT_COSMETICSEntity.ERR_MSG;
            RTN_KEY = pfrmPOPMain_OUT_COSMETICSEntity.RTN_KEY;
            RTN_SEQ = pfrmPOPMain_OUT_COSMETICSEntity.RTN_SEQ;
            RTN_OTHERS = pfrmPOPMain_OUT_COSMETICSEntity.RTN_OTHERS;

            INOUT_ID = pfrmPOPMain_OUT_COSMETICSEntity.INOUT_ID;
            INOUT_DATE = pfrmPOPMain_OUT_COSMETICSEntity.INOUT_DATE;
            INOUT_SEQ = pfrmPOPMain_OUT_COSMETICSEntity.INOUT_SEQ;
            INOUT_TYPE = pfrmPOPMain_OUT_COSMETICSEntity.INOUT_TYPE;
            REFERENCE_ID = pfrmPOPMain_OUT_COSMETICSEntity.REFERENCE_ID;
            PART_CODE = pfrmPOPMain_OUT_COSMETICSEntity.PART_CODE;
            PART_NAME = pfrmPOPMain_OUT_COSMETICSEntity.PART_NAME;
            VEND_CODE = pfrmPOPMain_OUT_COSMETICSEntity.VEND_CODE;
            VEND_NAME = pfrmPOPMain_OUT_COSMETICSEntity.VEND_NAME;
            INOUT_QTY = pfrmPOPMain_OUT_COSMETICSEntity.INOUT_QTY;
            UNITCOST_CURRENCY_CODE = pfrmPOPMain_OUT_COSMETICSEntity.UNITCOST_CURRENCY_CODE;
            UNITCOST = pfrmPOPMain_OUT_COSMETICSEntity.UNITCOST;
            COST = pfrmPOPMain_OUT_COSMETICSEntity.COST;
            REMARK = pfrmPOPMain_OUT_COSMETICSEntity.REMARK;
            INOUT_CODE = pfrmPOPMain_OUT_COSMETICSEntity.INOUT_CODE;
            USE_YN = pfrmPOPMain_OUT_COSMETICSEntity.USE_YN;
            DATE_FROM = pfrmPOPMain_OUT_COSMETICSEntity.DATE_FROM;
            DATE_TO = pfrmPOPMain_OUT_COSMETICSEntity.DATE_TO;

            TERMINAL_CODE = pfrmPOPMain_OUT_COSMETICSEntity.TERMINAL_CODE;
            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class POPCheckEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String USER_NAME { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE


        //고정 엔티티


        //메뉴별 추가 엔티티 입력
        public String WINDOW_NAME { get; set; }

        public String RESOURCE_CODE { get; set; }
        public String PROCESS_CODE { get; set; }
        public String CHECK_CYCLE { get; set; }
        public String EQUIPMENT_CODE { get; set; }
        public String STOP_GROUP { get; set; }
        public String STOP_DETAIL { get; set; }

        //메뉴별 추가 엔티티 입력
        public String COLLECTION_DATE { get; set; }
        public String PROPERTY_VALUE { get; set; }
        public String CONDITION_CODE { get; set; }
        public String COLLECTION_VALUE { get; set; }
        public String COMMON_TYPE { get; set; } // 공정구분

        public String PRODUCTION_ORDER_ID { get; set; }
        public String COMPLETE_YN { get; set; }

        //바코드 정보 저장
        public String PART_BARCODE { get; set; }
        public String PRINT_DATE { get; set; }
        public String PRINT_SEQ { get; set; }
        public String PART_CODE { get; set; }
        public String PART_QTY { get; set; }
        public DateTime START_DATE { get; set; }
        public DateTime END_DATE { get; set; }
        public String USE_YN { get; set; }
        public String STOP_ID { get; set; }
        #endregion

        #region 생성자 - POPProductionOrderCommonEntity()

        public POPCheckEntity()
        {
        }

        #endregion

        #region 생성자 - POPProductionOrderCommonEntity(pPOPProductionOrderCommonEntity)

        public POPCheckEntity(POPCheckEntity pPOPCheckEntity)
        {
            CORP_CODE = pPOPCheckEntity.CORP_CODE;
            CRUD = pPOPCheckEntity.CRUD;
            USER_CODE = pPOPCheckEntity.USER_CODE;
            USER_NAME = pPOPCheckEntity.USER_NAME;
            ERR_NO = pPOPCheckEntity.ERR_NO;
            ERR_MSG = pPOPCheckEntity.ERR_MSG;
            RTN_KEY = pPOPCheckEntity.RTN_KEY;
            RTN_SEQ = pPOPCheckEntity.RTN_SEQ;
            RTN_OTHERS = pPOPCheckEntity.RTN_OTHERS;
            LANGUAGE_TYPE = pPOPCheckEntity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
            WINDOW_NAME = pPOPCheckEntity.WINDOW_NAME;
            RESOURCE_CODE = pPOPCheckEntity.RESOURCE_CODE;
            RESOURCE_CODE = pPOPCheckEntity.RESOURCE_CODE;
            COLLECTION_DATE = pPOPCheckEntity.COLLECTION_DATE;
            PROPERTY_VALUE = pPOPCheckEntity.PROPERTY_VALUE;
            CONDITION_CODE = pPOPCheckEntity.CONDITION_CODE;
            COLLECTION_VALUE = pPOPCheckEntity.COLLECTION_VALUE;
            COMMON_TYPE = pPOPCheckEntity.COMMON_TYPE;
            START_DATE = pPOPCheckEntity.START_DATE;
            END_DATE = pPOPCheckEntity.END_DATE;
            STOP_GROUP = pPOPCheckEntity.STOP_GROUP;
            STOP_DETAIL = pPOPCheckEntity.STOP_DETAIL;
            USE_YN = pPOPCheckEntity.USE_YN;
            STOP_ID = pPOPCheckEntity.STOP_ID;

            CHECK_CYCLE = pPOPCheckEntity.CHECK_CYCLE;
            EQUIPMENT_CODE = pPOPCheckEntity.EQUIPMENT_CODE;

            PRODUCTION_ORDER_ID = pPOPCheckEntity.PRODUCTION_ORDER_ID;
            COMPLETE_YN = pPOPCheckEntity.COMPLETE_YN;

            PART_BARCODE = pPOPCheckEntity.PART_BARCODE;
            PRINT_DATE = pPOPCheckEntity.PRINT_DATE;
            PRINT_SEQ = pPOPCheckEntity.PRINT_SEQ;
            PART_CODE = pPOPCheckEntity.PART_CODE;
            PART_QTY = pPOPCheckEntity.PART_QTY;

        }
        #endregion

    }

    public class POP_MAIN_HWTEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String USER_NAME { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE


        //고정 엔티티


        //메뉴별 추가 엔티티 입력
        public String WINDOW_NAME { get; set; }

        public String RESOURCE_CODE { get; set; }
        public String PROCESS_CODE { get; set; }
        public String CHECK_CYCLE { get; set; }
        public String EQUIPMENT_CODE { get; set; }
        public String STOP_GROUP { get; set; }
        public String STOP_DETAIL { get; set; }

        //메뉴별 추가 엔티티 입력
        public String COLLECTION_DATE { get; set; }
        public String PROPERTY_VALUE { get; set; }
        public String CONDITION_CODE { get; set; }
        public String COLLECTION_VALUE { get; set; }
        public String COMMON_TYPE { get; set; } // 공정구분

        public String PRODUCTION_ORDER_ID { get; set; }
        public String COMPLETE_YN { get; set; }

        //바코드 정보 저장
        public String PART_BARCODE { get; set; }
        public String PRINT_DATE { get; set; }
        public String PRINT_SEQ { get; set; }
        public String PART_CODE { get; set; }
        public String PART_QTY { get; set; }
        public DateTime START_DATE { get; set; }
        public DateTime END_DATE { get; set; }
        public String USE_YN { get; set; }
        public String STOP_ID { get; set; }
        #endregion

        #region 생성자 - POPProductionOrderCommonEntity()

        public POP_MAIN_HWTEntity()
        {
        }

        #endregion

        #region 생성자 - POPProductionOrderCommonEntity(pPOPProductionOrderCommonEntity)

        public POP_MAIN_HWTEntity(POP_MAIN_HWTEntity pPOP_MAIN_HWTEntity)
        {
            CORP_CODE = pPOP_MAIN_HWTEntity.CORP_CODE;
            CRUD = pPOP_MAIN_HWTEntity.CRUD;
            USER_CODE = pPOP_MAIN_HWTEntity.USER_CODE;
            USER_NAME = pPOP_MAIN_HWTEntity.USER_NAME;
            ERR_NO = pPOP_MAIN_HWTEntity.ERR_NO;
            ERR_MSG = pPOP_MAIN_HWTEntity.ERR_MSG;
            RTN_KEY = pPOP_MAIN_HWTEntity.RTN_KEY;
            RTN_SEQ = pPOP_MAIN_HWTEntity.RTN_SEQ;
            RTN_OTHERS = pPOP_MAIN_HWTEntity.RTN_OTHERS;
            LANGUAGE_TYPE = pPOP_MAIN_HWTEntity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
            WINDOW_NAME = pPOP_MAIN_HWTEntity.WINDOW_NAME;
            RESOURCE_CODE = pPOP_MAIN_HWTEntity.RESOURCE_CODE;
            RESOURCE_CODE = pPOP_MAIN_HWTEntity.RESOURCE_CODE;
            COLLECTION_DATE = pPOP_MAIN_HWTEntity.COLLECTION_DATE;
            PROPERTY_VALUE = pPOP_MAIN_HWTEntity.PROPERTY_VALUE;
            CONDITION_CODE = pPOP_MAIN_HWTEntity.CONDITION_CODE;
            COLLECTION_VALUE = pPOP_MAIN_HWTEntity.COLLECTION_VALUE;
            COMMON_TYPE = pPOP_MAIN_HWTEntity.COMMON_TYPE;
            START_DATE = pPOP_MAIN_HWTEntity.START_DATE;
            END_DATE = pPOP_MAIN_HWTEntity.END_DATE;
            STOP_GROUP = pPOP_MAIN_HWTEntity.STOP_GROUP;
            STOP_DETAIL = pPOP_MAIN_HWTEntity.STOP_DETAIL;
            USE_YN = pPOP_MAIN_HWTEntity.USE_YN;
            STOP_ID = pPOP_MAIN_HWTEntity.STOP_ID;

            CHECK_CYCLE = pPOP_MAIN_HWTEntity.CHECK_CYCLE;
            EQUIPMENT_CODE = pPOP_MAIN_HWTEntity.EQUIPMENT_CODE;

            PRODUCTION_ORDER_ID = pPOP_MAIN_HWTEntity.PRODUCTION_ORDER_ID;
            COMPLETE_YN = pPOP_MAIN_HWTEntity.COMPLETE_YN;

            PART_BARCODE = pPOP_MAIN_HWTEntity.PART_BARCODE;
            PRINT_DATE = pPOP_MAIN_HWTEntity.PRINT_DATE;
            PRINT_SEQ = pPOP_MAIN_HWTEntity.PRINT_SEQ;
            PART_CODE = pPOP_MAIN_HWTEntity.PART_CODE;
            PART_QTY = pPOP_MAIN_HWTEntity.PART_QTY;

        }
        #endregion

    }

    public class POPFirstMiddleLastEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String USER_NAME { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE


        //고정 엔티티


        //메뉴별 추가 엔티티 입력
        public String WINDOW_NAME { get; set; }

        public String RESOURCE_CODE { get; set; }
        public String PROCESS_CODE { get; set; }
        public String CHECK_CYCLE { get; set; }
        public String EQUIPMENT_CODE { get; set; }
        public String STOP_GROUP { get; set; }
        public String STOP_DETAIL { get; set; }

        //메뉴별 추가 엔티티 입력
        public String COLLECTION_DATE { get; set; }
        public String PROPERTY_VALUE { get; set; }
        public String CONDITION_CODE { get; set; }
        public String COLLECTION_VALUE { get; set; }
        public String COMMON_TYPE { get; set; } // 공정구분

        public String PRODUCTION_ORDER_ID { get; set; }
        public String COMPLETE_YN { get; set; }

        //바코드 정보 저장
        public String PART_BARCODE { get; set; }
        public String PRINT_DATE { get; set; }
        public String PRINT_SEQ { get; set; }
        public String PART_CODE { get; set; }
        public String PART_QTY { get; set; }
        public DateTime START_DATE { get; set; }
        public DateTime END_DATE { get; set; }
        public String USE_YN { get; set; }
        public String STOP_ID { get; set; }

        public String RESULT_DATA { get; set; }
        #endregion

        #region 생성자 - POPProductionOrderCommonEntity()

        public POPFirstMiddleLastEntity()
        {
        }

        #endregion

        #region 생성자 - POPProductionOrderCommonEntity(pPOPProductionOrderCommonEntity)

        public POPFirstMiddleLastEntity(POPFirstMiddleLastEntity pPOPFirstMiddleLastEntity)
        {
            CORP_CODE = pPOPFirstMiddleLastEntity.CORP_CODE;
            CRUD = pPOPFirstMiddleLastEntity.CRUD;
            USER_CODE = pPOPFirstMiddleLastEntity.USER_CODE;
            USER_NAME = pPOPFirstMiddleLastEntity.USER_NAME;
            ERR_NO = pPOPFirstMiddleLastEntity.ERR_NO;
            ERR_MSG = pPOPFirstMiddleLastEntity.ERR_MSG;
            RTN_KEY = pPOPFirstMiddleLastEntity.RTN_KEY;
            RTN_SEQ = pPOPFirstMiddleLastEntity.RTN_SEQ;
            RTN_OTHERS = pPOPFirstMiddleLastEntity.RTN_OTHERS;
            LANGUAGE_TYPE = pPOPFirstMiddleLastEntity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
            WINDOW_NAME = pPOPFirstMiddleLastEntity.WINDOW_NAME;
            RESOURCE_CODE = pPOPFirstMiddleLastEntity.RESOURCE_CODE;
            RESOURCE_CODE = pPOPFirstMiddleLastEntity.RESOURCE_CODE;
            COLLECTION_DATE = pPOPFirstMiddleLastEntity.COLLECTION_DATE;
            PROPERTY_VALUE = pPOPFirstMiddleLastEntity.PROPERTY_VALUE;
            CONDITION_CODE = pPOPFirstMiddleLastEntity.CONDITION_CODE;
            COLLECTION_VALUE = pPOPFirstMiddleLastEntity.COLLECTION_VALUE;
            COMMON_TYPE = pPOPFirstMiddleLastEntity.COMMON_TYPE;
            START_DATE = pPOPFirstMiddleLastEntity.START_DATE;
            END_DATE = pPOPFirstMiddleLastEntity.END_DATE;
            STOP_GROUP = pPOPFirstMiddleLastEntity.STOP_GROUP;
            STOP_DETAIL = pPOPFirstMiddleLastEntity.STOP_DETAIL;
            USE_YN = pPOPFirstMiddleLastEntity.USE_YN;
            STOP_ID = pPOPFirstMiddleLastEntity.STOP_ID;

            CHECK_CYCLE = pPOPFirstMiddleLastEntity.CHECK_CYCLE;
            EQUIPMENT_CODE = pPOPFirstMiddleLastEntity.EQUIPMENT_CODE;

            PRODUCTION_ORDER_ID = pPOPFirstMiddleLastEntity.PRODUCTION_ORDER_ID;
            COMPLETE_YN = pPOPFirstMiddleLastEntity.COMPLETE_YN;

            PART_BARCODE = pPOPFirstMiddleLastEntity.PART_BARCODE;
            PRINT_DATE = pPOPFirstMiddleLastEntity.PRINT_DATE;
            PRINT_SEQ = pPOPFirstMiddleLastEntity.PRINT_SEQ;
            PART_CODE = pPOPFirstMiddleLastEntity.PART_CODE;
            PART_QTY = pPOPFirstMiddleLastEntity.PART_QTY;
            RESULT_DATA = pPOPFirstMiddleLastEntity.RESULT_DATA;

        }
        #endregion

    }


    public class CreaPOPEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String USER_NAME { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE


        //고정 엔티티


        //메뉴별 추가 엔티티 입력
        public String WINDOW_NAME { get; set; }

        public String RESOURCE_CODE { get; set; }
        public String PROCESS_CODE { get; set; }
        public String CHECK_CYCLE { get; set; }
        public String EQUIPMENT_CODE { get; set; }

        public String PONO { get; set; }

        public String EVENTDATE { get; set; }
        public String EVENTSEQ { get; set; }


        //메뉴별 추가 엔티티 입력
        public String COLLECTION_DATE { get; set; }
        public String PROPERTY_VALUE { get; set; }
        public String CONDITION_CODE { get; set; }
        public String COLLECTION_VALUE { get; set; }
        public String COMMON_TYPE { get; set; } // 공정구분

        public String PRODUCTION_ORDER_ID { get; set; }
        public String COMPLETE_YN { get; set; }

        //바코드 정보 저장
        public String PART_BARCODE { get; set; }
        public String PRINT_DATE { get; set; }
        public String PRINT_SEQ { get; set; }
        public String PART_CODE { get; set; }
        public String PART_QTY { get; set; }
        #endregion

        #region 생성자 - CreaPOPEntity()

        public CreaPOPEntity()
        {
        }

        #endregion

        #region 생성자 - CreaPOPEntity(pCreaPOPEntity)

        public CreaPOPEntity(CreaPOPEntity pCreaPOPEntity)
        {
            CORP_CODE = pCreaPOPEntity.CORP_CODE;
            CRUD = pCreaPOPEntity.CRUD;
            USER_CODE = pCreaPOPEntity.USER_CODE;
            USER_NAME = pCreaPOPEntity.USER_NAME;
            ERR_NO = pCreaPOPEntity.ERR_NO;
            ERR_MSG = pCreaPOPEntity.ERR_MSG;
            RTN_KEY = pCreaPOPEntity.RTN_KEY;
            RTN_SEQ = pCreaPOPEntity.RTN_SEQ;
            RTN_OTHERS = pCreaPOPEntity.RTN_OTHERS;
            LANGUAGE_TYPE = pCreaPOPEntity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
            WINDOW_NAME = pCreaPOPEntity.WINDOW_NAME;
            RESOURCE_CODE = pCreaPOPEntity.RESOURCE_CODE;
            RESOURCE_CODE = pCreaPOPEntity.RESOURCE_CODE;
            COLLECTION_DATE = pCreaPOPEntity.COLLECTION_DATE;
            PROPERTY_VALUE = pCreaPOPEntity.PROPERTY_VALUE;
            CONDITION_CODE = pCreaPOPEntity.CONDITION_CODE;
            COLLECTION_VALUE = pCreaPOPEntity.COLLECTION_VALUE;
            COMMON_TYPE = pCreaPOPEntity.COMMON_TYPE;
            // 작업지시 엔티티
            PONO = pCreaPOPEntity.PONO;
            EVENTDATE = pCreaPOPEntity.EVENTDATE;
            EVENTSEQ = pCreaPOPEntity.EVENTSEQ;

            CHECK_CYCLE = pCreaPOPEntity.CHECK_CYCLE;
            EQUIPMENT_CODE = pCreaPOPEntity.EQUIPMENT_CODE;

            PRODUCTION_ORDER_ID = pCreaPOPEntity.PRODUCTION_ORDER_ID;
            COMPLETE_YN = pCreaPOPEntity.COMPLETE_YN;

            PART_BARCODE = pCreaPOPEntity.PART_BARCODE;
            PRINT_DATE = pCreaPOPEntity.PRINT_DATE;
            PRINT_SEQ = pCreaPOPEntity.PRINT_SEQ;
            PART_CODE = pCreaPOPEntity.PART_CODE;
            PART_QTY = pCreaPOPEntity.PART_QTY;

        }
        #endregion

    }

    public class ucTABSearchEntity
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

        #region 생성자 - ucTABSearchEntity()

        public ucTABSearchEntity()
        {
        }

        #endregion

        #region 생성자 - ucTABSearchEntity(ucTABSearchEntity pucTABSearchEntity)

        public ucTABSearchEntity(ucTABSearchEntity pucTABSearchEntity)
        {
            CORP_CODE = pucTABSearchEntity.CORP_CODE;
            CRUD = pucTABSearchEntity.CRUD;
            USER_CODE = pucTABSearchEntity.USER_CODE;
            LANGUAGE_TYPE = pucTABSearchEntity.LANGUAGE_TYPE;
            WINDOW_NAME = pucTABSearchEntity.WINDOW_NAME;

            DATE_FROM = pucTABSearchEntity.DATE_FROM;
            DATE_TO = pucTABSearchEntity.DATE_TO;

            ERR_NO = pucTABSearchEntity.ERR_NO;
            ERR_MSG = pucTABSearchEntity.ERR_MSG;
            RTN_KEY = pucTABSearchEntity.RTN_KEY;
            RTN_SEQ = pucTABSearchEntity.RTN_SEQ;
            RTN_AQ = pucTABSearchEntity.RTN_AQ;
            RTN_SQ = pucTABSearchEntity.RTN_SQ;
            RTN_OTHERS = pucTABSearchEntity.RTN_OTHERS;
            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class ucTABRegisterEntity
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
        public String WINDOW_NAME { get; set; }

        public String LANGUAGE_TYPE { get; set; }

        //추가
        public String DATE_TIME { get; set; }
        public String RESOURCE_CODE { get; set; }
        public String RESOURCE_NAME { get; set; }
        public String VALUE { get; set; }

        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }

        public String COLLECTION_DATE { get; set; }

        public String COMMENT1 { get; set; }
        public String COMMENT2 { get; set; }
        public String COMMENT3 { get; set; }

        public String USER_YN { get; set; }
        public String REMARK { get; set; }
        

        public int dtListCnt { get; set; }

        public String MISSING_CHECK { get; set; }


        #endregion

        #region 생성자 - ucTABRegisterEntity()

        public ucTABRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - ucTABRegisterEntity(pucTABRegisterEntity)

        public ucTABRegisterEntity(ucTABRegisterEntity pucTABRegisterEntity)
        {
            CORP_CODE = pucTABRegisterEntity.CORP_CODE;
            CRUD = pucTABRegisterEntity.CRUD;
            USER_CODE = pucTABRegisterEntity.USER_CODE;

            pucTABRegisterEntity.WINDOW_NAME = WINDOW_NAME;

            DATE_TIME = pucTABRegisterEntity.DATE_TIME;

            RESOURCE_CODE = pucTABRegisterEntity.RESOURCE_CODE;
            RESOURCE_NAME = pucTABRegisterEntity.RESOURCE_NAME;
            VALUE = pucTABRegisterEntity.VALUE;

            DATE_FROM = pucTABRegisterEntity.DATE_FROM;
            DATE_TO = pucTABRegisterEntity.DATE_TO;

            COLLECTION_DATE = pucTABRegisterEntity.COLLECTION_DATE;

            COMMENT1 = pucTABRegisterEntity.COMMENT1;
            COMMENT2 = pucTABRegisterEntity.COMMENT2;
            COMMENT3 = pucTABRegisterEntity.COMMENT3;

            REMARK = pucTABRegisterEntity.REMARK;
            USER_YN = pucTABRegisterEntity.USER_YN;
            dtListCnt = pucTABRegisterEntity.dtListCnt;

            MISSING_CHECK = pucTABRegisterEntity.MISSING_CHECK;

            ERR_NO = pucTABRegisterEntity.ERR_NO;
            ERR_MSG = pucTABRegisterEntity.ERR_MSG;
            RTN_KEY = pucTABRegisterEntity.RTN_KEY;
            RTN_SEQ = pucTABRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pucTABRegisterEntity.RTN_OTHERS;

            LANGUAGE_TYPE = pucTABRegisterEntity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ucTABExcelEntity
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

        #region 생성자 - ucTABExcelEntity()

        public ucTABExcelEntity()
        {
        }

        #endregion

        #region 생성자 - ucTABExcelEntity(pucTABExcelEntity)

        public ucTABExcelEntity(ucTABExcelEntity pucTABExcelEntity)
        {
            CORP_CODE = pucTABExcelEntity.CORP_CODE;
            CRUD = pucTABExcelEntity.CRUD;
            USER_CODE = pucTABExcelEntity.USER_CODE;

            COLLECTION_DATE = pucTABExcelEntity.COLLECTION_DATE;

            pucTABExcelEntity.WINDOW_NAME = WINDOW_NAME;

            HACCP_TYPE = pucTABExcelEntity.HACCP_TYPE;
            DATE_FROM = pucTABExcelEntity.DATE_FROM;
            DATE_TO = pucTABExcelEntity.DATE_TO;
            PART_NAME = pucTABExcelEntity.PART_NAME;
            HACCP_ID = pucTABExcelEntity.HACCP_ID;
            HACCP_DATE = pucTABExcelEntity.HACCP_DATE;
            HACCP_SEQ = pucTABExcelEntity.HACCP_SEQ;
            PROCESS_NAME = pucTABExcelEntity.PROCESS_NAME;
            REQUEST_DEPT = pucTABExcelEntity.REQUEST_DEPT;
            CODE_NAME = pucTABExcelEntity.CODE_NAME;
            INOUT_DATE = pucTABExcelEntity.INOUT_DATE;
            INOUT_QTY = pucTABExcelEntity.INOUT_QTY;
            PACKING_REMARK = pucTABExcelEntity.PACKING_REMARK;
            SAMPLE_DEPT = pucTABExcelEntity.SAMPLE_DEPT;
            SAMPLE_NO = pucTABExcelEntity.SAMPLE_NO;
            SAMPLE_USER = pucTABExcelEntity.SAMPLE_USER;
            REMARK = pucTABExcelEntity.REMARK;
            USER_YN = pucTABExcelEntity.USER_YN;
            dtListCnt = pucTABExcelEntity.dtListCnt;

            MISSING_CHECK = pucTABExcelEntity.MISSING_CHECK;

            ERR_NO = pucTABExcelEntity.ERR_NO;
            ERR_MSG = pucTABExcelEntity.ERR_MSG;
            RTN_KEY = pucTABExcelEntity.RTN_KEY;
            RTN_SEQ = pucTABExcelEntity.RTN_SEQ;
            RTN_OTHERS = pucTABExcelEntity.RTN_OTHERS;

            LANGUAGE_TYPE = pucTABExcelEntity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class ucTABCommentEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String WINDOW_NAME { get; set; }
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE

        public String COOMMENT_ID { get; set; }
        public String COOMMENT_DATA { get; set; }

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

        #region 생성자 - ucTABCommentEntity()

        public ucTABCommentEntity()
        {
        }

        #endregion

        #region 생성자 - ucTABCommentEntity(ucTABCommentEntity pucTABCommentEntity)

        public ucTABCommentEntity(ucTABCommentEntity pucTABCommentEntity)
        {
            CORP_CODE = pucTABCommentEntity.CORP_CODE;
            CRUD = pucTABCommentEntity.CRUD;
            USER_CODE = pucTABCommentEntity.USER_CODE;
            LANGUAGE_TYPE = pucTABCommentEntity.LANGUAGE_TYPE;
            WINDOW_NAME = pucTABCommentEntity.WINDOW_NAME;

            COOMMENT_ID = pucTABCommentEntity.COOMMENT_ID;
            COOMMENT_DATA = pucTABCommentEntity.COOMMENT_DATA;

            ERR_NO = pucTABCommentEntity.ERR_NO;
            ERR_MSG = pucTABCommentEntity.ERR_MSG;
            RTN_KEY = pucTABCommentEntity.RTN_KEY;
            RTN_SEQ = pucTABCommentEntity.RTN_SEQ;
            RTN_AQ = pucTABCommentEntity.RTN_AQ;
            RTN_SQ = pucTABCommentEntity.RTN_SQ;
            RTN_OTHERS = pucTABCommentEntity.RTN_OTHERS;
            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class ucTABLobbyEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String WINDOW_NAME { get; set; }
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE

        public String CONTRACT_ID { get; set; }
        public String CONTRACT_DATE_FROM { get; set; }
        public String CONTRACT_DATE_TO { get; set; }
        public String CONTRACT_NUMBER { get; set; }

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

        #region 생성자 - ucTABLobbyEntity()

        public ucTABLobbyEntity()
        {
        }

        #endregion

        #region 생성자 - ucTABLobbyEntity(ucTABLobbyEntity pucTABLobbyEntity)

        public ucTABLobbyEntity(ucTABLobbyEntity pucTABLobbyEntity)
        {
            CORP_CODE = pucTABLobbyEntity.CORP_CODE;
            CRUD = pucTABLobbyEntity.CRUD;
            USER_CODE = pucTABLobbyEntity.USER_CODE;
            LANGUAGE_TYPE = pucTABLobbyEntity.LANGUAGE_TYPE;
            WINDOW_NAME = pucTABLobbyEntity.WINDOW_NAME;

            CONTRACT_ID = pucTABLobbyEntity.CONTRACT_ID;
            CONTRACT_DATE_FROM = pucTABLobbyEntity.CONTRACT_DATE_FROM;
            CONTRACT_DATE_TO = pucTABLobbyEntity.CONTRACT_DATE_TO;
            CONTRACT_NUMBER = pucTABLobbyEntity.CONTRACT_NUMBER;

            ERR_NO = pucTABLobbyEntity.ERR_NO;
            ERR_MSG = pucTABLobbyEntity.ERR_MSG;
            RTN_KEY = pucTABLobbyEntity.RTN_KEY;
            RTN_SEQ = pucTABLobbyEntity.RTN_SEQ;
            RTN_AQ = pucTABLobbyEntity.RTN_AQ;
            RTN_SQ = pucTABLobbyEntity.RTN_SQ;
            RTN_OTHERS = pucTABLobbyEntity.RTN_OTHERS;
            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class ucTABEquipmentEntity
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
        public String WINDOW_NAME { get; set; }

        public String LANGUAGE_TYPE { get; set; }
        
        public String EQUIPMENT_CODE { get; set; }

        public String ATTRIBUTE { get; set; }

        //추가
        public String DATE_TIME { get; set; }
        public String RESOURCE_CODE { get; set; }
        public String RESOURCE_NAME { get; set; }
        public String VALUE { get; set; }

        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }

        public String COLLECTION_DATE { get; set; }

        public String INSPECT_ID { get; set; }

        public String USER_YN { get; set; }
        public String REMARK { get; set; }

        public String DAY { get; set; }

        public int dtListCnt { get; set; }

        public String MISSING_CHECK { get; set; }


        #endregion

        #region 생성자 - ucTABEquipmentEntity()

        public ucTABEquipmentEntity()
        {
        }

        #endregion

        #region 생성자 - ucTABEquipmentEntity(pucTABEquipmentEntity)

        public ucTABEquipmentEntity(ucTABEquipmentEntity pucTABEquipmentEntity)
        {
            CORP_CODE = pucTABEquipmentEntity.CORP_CODE;
            CRUD = pucTABEquipmentEntity.CRUD;
            USER_CODE = pucTABEquipmentEntity.USER_CODE;

            pucTABEquipmentEntity.WINDOW_NAME = WINDOW_NAME;

            DATE_TIME = pucTABEquipmentEntity.DATE_TIME;

            EQUIPMENT_CODE = pucTABEquipmentEntity.EQUIPMENT_CODE;

            ATTRIBUTE = pucTABEquipmentEntity.ATTRIBUTE;

            RESOURCE_CODE = pucTABEquipmentEntity.RESOURCE_CODE;
            RESOURCE_NAME = pucTABEquipmentEntity.RESOURCE_NAME;
            VALUE = pucTABEquipmentEntity.VALUE;

            DATE_FROM = pucTABEquipmentEntity.DATE_FROM;
            DATE_TO = pucTABEquipmentEntity.DATE_TO;

            COLLECTION_DATE = pucTABEquipmentEntity.COLLECTION_DATE;

            INSPECT_ID = pucTABEquipmentEntity.INSPECT_ID;

            DAY = pucTABEquipmentEntity.DAY;

            REMARK = pucTABEquipmentEntity.REMARK;
            USER_YN = pucTABEquipmentEntity.USER_YN;
            dtListCnt = pucTABEquipmentEntity.dtListCnt;

            MISSING_CHECK = pucTABEquipmentEntity.MISSING_CHECK;

            ERR_NO = pucTABEquipmentEntity.ERR_NO;
            ERR_MSG = pucTABEquipmentEntity.ERR_MSG;
            RTN_KEY = pucTABEquipmentEntity.RTN_KEY;
            RTN_SEQ = pucTABEquipmentEntity.RTN_SEQ;
            RTN_OTHERS = pucTABEquipmentEntity.RTN_OTHERS;

            LANGUAGE_TYPE = pucTABEquipmentEntity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }
}

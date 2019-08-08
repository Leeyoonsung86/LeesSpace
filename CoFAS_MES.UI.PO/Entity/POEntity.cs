using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoFAS_MES.UI.PO.Entity
{
    public class Dyeing_RecipeInformationRegisterEntity
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


        #endregion

        #region 생성자 - Dyeing_RecipeInformationRegisterEntity()

        public Dyeing_RecipeInformationRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - Dyeing_RecipeInformationRegisterEntity(Dyeing_RecipeInformationRegisterEntity pDyeing_RecipeInformationRegisterEntity)

        public Dyeing_RecipeInformationRegisterEntity(Dyeing_RecipeInformationRegisterEntity pDyeing_RecipeInformationRegisterEntity)
        {
            CORP_CODE = pDyeing_RecipeInformationRegisterEntity.CORP_CODE;
            CRUD = pDyeing_RecipeInformationRegisterEntity.CRUD;
            USER_CODE = pDyeing_RecipeInformationRegisterEntity.USER_CODE;
            ERR_NO = pDyeing_RecipeInformationRegisterEntity.ERR_NO;
            ERR_MSG = pDyeing_RecipeInformationRegisterEntity.ERR_MSG;
            RTN_KEY = pDyeing_RecipeInformationRegisterEntity.RTN_KEY;
            RTN_SEQ = pDyeing_RecipeInformationRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pDyeing_RecipeInformationRegisterEntity.RTN_OTHERS;
            LANGUAGE_TYPE = pDyeing_RecipeInformationRegisterEntity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class Dyeing_WorkOrdersRegisterEntity
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


        #endregion

        #region 생성자 - Dyeing_WorkOrdersRegisterEntity()

        public Dyeing_WorkOrdersRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - Dyeing_WorkOrdersRegisterEntity(Dyeing_WorkOrdersRegisterEntity pDyeing_WorkOrdersRegisterEntity)

        public Dyeing_WorkOrdersRegisterEntity(Dyeing_WorkOrdersRegisterEntity pDyeing_WorkOrdersRegisterEntity)
        {
            CORP_CODE = pDyeing_WorkOrdersRegisterEntity.CORP_CODE;
            CRUD = pDyeing_WorkOrdersRegisterEntity.CRUD;
            USER_CODE = pDyeing_WorkOrdersRegisterEntity.USER_CODE;
            ERR_NO = pDyeing_WorkOrdersRegisterEntity.ERR_NO;
            ERR_MSG = pDyeing_WorkOrdersRegisterEntity.ERR_MSG;
            RTN_KEY = pDyeing_WorkOrdersRegisterEntity.RTN_KEY;
            RTN_SEQ = pDyeing_WorkOrdersRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pDyeing_WorkOrdersRegisterEntity.RTN_OTHERS;
            LANGUAGE_TYPE = pDyeing_WorkOrdersRegisterEntity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class WorkOrdersRegisterEntity
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
        public String DATE_FROM         { get; set; } //조회 시작 날짜
        public String DATE_TO           { get; set; } //조회 마감 날짜
        public String ORDER_CODE        { get; set; } //작업지시 코드

        public String ORDER_DATE { get; set; } //작업지시 코드
        public String PLAN_CODE         { get; set; } //생산계획 코드
        public String PART_NAME         { get; set; } //품목명
        public String PART_CODE         { get; set; } //품목 코드
        public String PROCESS_CODE      { get; set; } //공정코드
        public String RESOURCE_CODE     { get; set; } //설비명
        public String RESOURCE_NAME     { get; set; } //설비 코드
        public String USE_YN            { get; set; } //사용 유무

        public String ORDER_QTY { get; set; } //사용 유무

        public String COMPLETE_YN { get; set; } //사용 유무

        public String WORKCENTER_CODE { get; set; } //사용 유무

        public String REFERENCE_ID { get; set; } //사용 유무



        #endregion

        #region 생성자 - WorkOrdersRegisterEntity()

        public WorkOrdersRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - WorkOrdersRegisterEntity(WorkOrdersRegisterEntity pWorkOrdersRegisterEntity)

        public WorkOrdersRegisterEntity(WorkOrdersRegisterEntity pWorkOrdersRegisterEntity)
        {
            CORP_CODE = pWorkOrdersRegisterEntity.CORP_CODE;
            CRUD = pWorkOrdersRegisterEntity.CRUD;
            USER_CODE = pWorkOrdersRegisterEntity.USER_CODE;
            LANGUAGE_TYPE = pWorkOrdersRegisterEntity.LANGUAGE_TYPE;

            ERR_NO = pWorkOrdersRegisterEntity.ERR_NO;
            ERR_MSG = pWorkOrdersRegisterEntity.ERR_MSG;
            RTN_KEY = pWorkOrdersRegisterEntity.RTN_KEY;
            RTN_SEQ = pWorkOrdersRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pWorkOrdersRegisterEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            DATE_FROM = pWorkOrdersRegisterEntity.DATE_FROM;
            DATE_TO = pWorkOrdersRegisterEntity.DATE_TO;
            ORDER_CODE = pWorkOrdersRegisterEntity.ORDER_CODE;
            ORDER_DATE = pWorkOrdersRegisterEntity.ORDER_DATE;
            PLAN_CODE = pWorkOrdersRegisterEntity.PLAN_CODE;
            PART_NAME = pWorkOrdersRegisterEntity.PART_NAME;
            PART_CODE = pWorkOrdersRegisterEntity.PART_CODE;
            RESOURCE_CODE = pWorkOrdersRegisterEntity.RESOURCE_CODE;
            RESOURCE_NAME = pWorkOrdersRegisterEntity.RESOURCE_NAME;
            PROCESS_CODE = pWorkOrdersRegisterEntity.PROCESS_CODE;
            USE_YN = pWorkOrdersRegisterEntity.USE_YN;
            ORDER_QTY = pWorkOrdersRegisterEntity.ORDER_QTY;
            COMPLETE_YN = pWorkOrdersRegisterEntity.COMPLETE_YN;
            WORKCENTER_CODE = pWorkOrdersRegisterEntity.WORKCENTER_CODE;
            REFERENCE_ID = pWorkOrdersRegisterEntity.REFERENCE_ID;


        }

        #endregion

    }

    public class WorkOrdersRegister_T50Entity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE

        public String WINDOW_NAME { get; set; } // CRUD

        public String CARVE { get; set; } // 각인정보
        public String MESSAGE { get; set; } // 도면정보

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력
        public String DATE_FROM { get; set; } //조회 시작 날짜
        public String DATE_TO { get; set; } //조회 마감 날짜
        public String ORDER_CODE { get; set; } //작업지시 코드

        public String ORDER_DATE { get; set; } //작업지시 코드
        public String PLAN_CODE { get; set; } //생산계획 코드
        public String PART_NAME { get; set; } //품목명
        public String PART_CODE { get; set; } //품목 코드

        public String PRODUCTION_ORDER_ID { get; set; } //생산지시번호

        public String PROCESS_CODE { get; set; } //공정코드
        public String RESOURCE_CODE { get; set; } //설비명
        public String RESOURCE_NAME { get; set; } //설비 코드
        public String USE_YN { get; set; } //사용 유무

        public String ORDER_QTY { get; set; } //사용 유무

        public String COMPLETE_YN { get; set; } //사용 유무

        public String WORKCENTER_CODE { get; set; } //사용 유무

        public String REFERENCE_ID { get; set; } //사용 유무



        #endregion

        #region 생성자 - WorkOrdersRegister_T50Entity()

        public WorkOrdersRegister_T50Entity()
        {
        }

        #endregion

        #region 생성자 - WorkOrdersRegister_T50Entity(WorkOrdersRegister_T50Entity pWorkOrdersRegister_T50Entity)

        public WorkOrdersRegister_T50Entity(WorkOrdersRegister_T50Entity pWorkOrdersRegister_T50Entity)
        {
            CORP_CODE = pWorkOrdersRegister_T50Entity.CORP_CODE;
            CRUD = pWorkOrdersRegister_T50Entity.CRUD;
            USER_CODE = pWorkOrdersRegister_T50Entity.USER_CODE;
            LANGUAGE_TYPE = pWorkOrdersRegister_T50Entity.LANGUAGE_TYPE;
            WINDOW_NAME = pWorkOrdersRegister_T50Entity.WINDOW_NAME;
            ERR_NO = pWorkOrdersRegister_T50Entity.ERR_NO;
            ERR_MSG = pWorkOrdersRegister_T50Entity.ERR_MSG;
            RTN_KEY = pWorkOrdersRegister_T50Entity.RTN_KEY;
            RTN_SEQ = pWorkOrdersRegister_T50Entity.RTN_SEQ;
            RTN_OTHERS = pWorkOrdersRegister_T50Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            DATE_FROM = pWorkOrdersRegister_T50Entity.DATE_FROM;
            DATE_TO = pWorkOrdersRegister_T50Entity.DATE_TO;
            ORDER_CODE = pWorkOrdersRegister_T50Entity.ORDER_CODE;
            ORDER_DATE = pWorkOrdersRegister_T50Entity.ORDER_DATE;
            PLAN_CODE = pWorkOrdersRegister_T50Entity.PLAN_CODE;
            PART_NAME = pWorkOrdersRegister_T50Entity.PART_NAME;
            PART_CODE = pWorkOrdersRegister_T50Entity.PART_CODE;
            RESOURCE_CODE = pWorkOrdersRegister_T50Entity.RESOURCE_CODE;
            RESOURCE_NAME = pWorkOrdersRegister_T50Entity.RESOURCE_NAME;
            PROCESS_CODE = pWorkOrdersRegister_T50Entity.PROCESS_CODE;
            USE_YN = pWorkOrdersRegister_T50Entity.USE_YN;
            ORDER_QTY = pWorkOrdersRegister_T50Entity.ORDER_QTY;
            COMPLETE_YN = pWorkOrdersRegister_T50Entity.COMPLETE_YN;
            WORKCENTER_CODE = pWorkOrdersRegister_T50Entity.WORKCENTER_CODE;
            REFERENCE_ID = pWorkOrdersRegister_T50Entity.REFERENCE_ID;
            PRODUCTION_ORDER_ID = pWorkOrdersRegister_T50Entity.PRODUCTION_ORDER_ID;
            CARVE = pWorkOrdersRegister_T50Entity.CARVE;
            MESSAGE = pWorkOrdersRegister_T50Entity.MESSAGE;
        }

        #endregion

    }

    public class WorkOrdersRegister_T07Entity
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
        public String DATE_FROM { get; set; } //조회 시작 날짜
        public String DATE_TO { get; set; } //조회 마감 날짜
        public String ORDER_CODE { get; set; } //작업지시 코드

        public String ORDER_DATE { get; set; } //작업지시 코드
        public String PLAN_CODE { get; set; } //생산계획 코드
        public String PART_NAME { get; set; } //품목명
        public String PART_CODE { get; set; } //품목 코드
        public String PROCESS_CODE { get; set; } //공정코드
        public String RESOURCE_CODE { get; set; } //설비명
        public String RESOURCE_NAME { get; set; } //설비 코드
        public String USE_YN { get; set; } //사용 유무

        public String ORDER_QTY { get; set; } //사용 유무

        public String COMPLETE_YN { get; set; } //사용 유무

        public String WORKCENTER_CODE { get; set; } //사용 유무

        public String REFERENCE_ID { get; set; } //사용 유무



        #endregion

        #region 생성자 - WorkOrdersRegister_T07Entity()

        public WorkOrdersRegister_T07Entity()
        {
        }

        #endregion

        #region 생성자 - WorkOrdersRegister_T07Entity(WorkOrdersRegister_T07Entity pWorkOrdersRegister_T07Entity)

        public WorkOrdersRegister_T07Entity(WorkOrdersRegister_T07Entity pWorkOrdersRegister_T07Entity)
        {
            CORP_CODE = pWorkOrdersRegister_T07Entity.CORP_CODE;
            CRUD = pWorkOrdersRegister_T07Entity.CRUD;
            USER_CODE = pWorkOrdersRegister_T07Entity.USER_CODE;
            LANGUAGE_TYPE = pWorkOrdersRegister_T07Entity.LANGUAGE_TYPE;

            ERR_NO = pWorkOrdersRegister_T07Entity.ERR_NO;
            ERR_MSG = pWorkOrdersRegister_T07Entity.ERR_MSG;
            RTN_KEY = pWorkOrdersRegister_T07Entity.RTN_KEY;
            RTN_SEQ = pWorkOrdersRegister_T07Entity.RTN_SEQ;
            RTN_OTHERS = pWorkOrdersRegister_T07Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            DATE_FROM = pWorkOrdersRegister_T07Entity.DATE_FROM;
            DATE_TO = pWorkOrdersRegister_T07Entity.DATE_TO;
            ORDER_CODE = pWorkOrdersRegister_T07Entity.ORDER_CODE;
            ORDER_DATE = pWorkOrdersRegister_T07Entity.ORDER_DATE;
            PLAN_CODE = pWorkOrdersRegister_T07Entity.PLAN_CODE;
            PART_NAME = pWorkOrdersRegister_T07Entity.PART_NAME;
            PART_CODE = pWorkOrdersRegister_T07Entity.PART_CODE;
            RESOURCE_CODE = pWorkOrdersRegister_T07Entity.RESOURCE_CODE;
            RESOURCE_NAME = pWorkOrdersRegister_T07Entity.RESOURCE_NAME;
            PROCESS_CODE = pWorkOrdersRegister_T07Entity.PROCESS_CODE;
            USE_YN = pWorkOrdersRegister_T07Entity.USE_YN;
            ORDER_QTY = pWorkOrdersRegister_T07Entity.ORDER_QTY;
            COMPLETE_YN = pWorkOrdersRegister_T07Entity.COMPLETE_YN;
            WORKCENTER_CODE = pWorkOrdersRegister_T07Entity.WORKCENTER_CODE;
            REFERENCE_ID = pWorkOrdersRegister_T07Entity.REFERENCE_ID;


        }

        #endregion

    }


    public class LotManagementSatusEntity
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
        public String DATE_FROM { get; set; } //조회 시작 날짜
        public String DATE_TO { get; set; } //조회 마감 날짜
        public String ORDER_CODE { get; set; } //작업지시 코드

        public String ORDER_DATE { get; set; } //작업지시 코드
        public String PLAN_CODE { get; set; } //생산계획 코드
        public String PART_NAME { get; set; } //품목명
        public String PART_CODE { get; set; } //품목 코드
        public String PROCESS_CODE { get; set; } //공정코드
        public String RESOURCE_CODE { get; set; } //설비명
        public String RESOURCE_NAME { get; set; } //설비 코드
        public String USE_YN { get; set; } //사용 유무

        public String ORDER_QTY { get; set; } //사용 유무

        public String COMPLETE_YN { get; set; } //사용 유무

        public String WORKCENTER_CODE { get; set; } //사용 유무

        public String REFERENCE_ID { get; set; } //사용 유무



        #endregion

        #region 생성자 - LotManagementSatusEntity()

        public LotManagementSatusEntity()
        {
        }

        #endregion

        #region 생성자 - LotManagementSatusEntity(LotManagementSatusEntity pLotManagementSatusEntity)

        public LotManagementSatusEntity(LotManagementSatusEntity pLotManagementSatusEntity)
        {
            CORP_CODE = pLotManagementSatusEntity.CORP_CODE;
            CRUD = pLotManagementSatusEntity.CRUD;
            USER_CODE = pLotManagementSatusEntity.USER_CODE;
            LANGUAGE_TYPE = pLotManagementSatusEntity.LANGUAGE_TYPE;

            ERR_NO = pLotManagementSatusEntity.ERR_NO;
            ERR_MSG = pLotManagementSatusEntity.ERR_MSG;
            RTN_KEY = pLotManagementSatusEntity.RTN_KEY;
            RTN_SEQ = pLotManagementSatusEntity.RTN_SEQ;
            RTN_OTHERS = pLotManagementSatusEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            DATE_FROM = pLotManagementSatusEntity.DATE_FROM;
            DATE_TO = pLotManagementSatusEntity.DATE_TO;
            ORDER_CODE = pLotManagementSatusEntity.ORDER_CODE;
            ORDER_DATE = pLotManagementSatusEntity.ORDER_DATE;
            PLAN_CODE = pLotManagementSatusEntity.PLAN_CODE;
            PART_NAME = pLotManagementSatusEntity.PART_NAME;
            PART_CODE = pLotManagementSatusEntity.PART_CODE;
            RESOURCE_CODE = pLotManagementSatusEntity.RESOURCE_CODE;
            RESOURCE_NAME = pLotManagementSatusEntity.RESOURCE_NAME;
            PROCESS_CODE = pLotManagementSatusEntity.PROCESS_CODE;
            USE_YN = pLotManagementSatusEntity.USE_YN;
            ORDER_QTY = pLotManagementSatusEntity.ORDER_QTY;
            COMPLETE_YN = pLotManagementSatusEntity.COMPLETE_YN;
            WORKCENTER_CODE = pLotManagementSatusEntity.WORKCENTER_CODE;
            REFERENCE_ID = pLotManagementSatusEntity.REFERENCE_ID;


        }

        #endregion

    }


    public class WorkOrdersRegister_T01Entity
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
        public String DATE_FROM { get; set; } //조회 시작 날짜
        public String DATE_TO { get; set; } //조회 마감 날짜
        public String ORDER_CODE { get; set; } //작업지시 코드

        public String ORDER_DATE { get; set; } //작업지시 코드
        public String PLAN_CODE { get; set; } //생산계획 코드
        public String PART_NAME { get; set; } //품목명
        public String PART_CODE { get; set; } //품목 코드
        public String PROCESS_CODE { get; set; } //공정코드
        public String RESOURCE_CODE { get; set; } //설비명
        public String RESOURCE_NAME { get; set; } //설비 코드
        public String USE_YN { get; set; } //사용 유무

        public String ORDER_QTY { get; set; } //사용 유무

        public String COMPLETE_YN { get; set; } //사용 유무

        public String WORKCENTER_CODE { get; set; } //사용 유무

        public String REFERENCE_ID { get; set; } //사용 유무



        #endregion

        #region 생성자 - WorkOrdersRegister_T01Entity()

        public WorkOrdersRegister_T01Entity()
        {
        }

        #endregion

        #region 생성자 - WorkOrdersRegister_T01Entity(WorkOrdersRegister_T01Entity pWorkOrdersRegister_T01Entity)

        public WorkOrdersRegister_T01Entity(WorkOrdersRegister_T01Entity pWorkOrdersRegister_T01Entity)
        {
            CORP_CODE = pWorkOrdersRegister_T01Entity.CORP_CODE;
            CRUD = pWorkOrdersRegister_T01Entity.CRUD;
            USER_CODE = pWorkOrdersRegister_T01Entity.USER_CODE;
            LANGUAGE_TYPE = pWorkOrdersRegister_T01Entity.LANGUAGE_TYPE;

            ERR_NO = pWorkOrdersRegister_T01Entity.ERR_NO;
            ERR_MSG = pWorkOrdersRegister_T01Entity.ERR_MSG;
            RTN_KEY = pWorkOrdersRegister_T01Entity.RTN_KEY;
            RTN_SEQ = pWorkOrdersRegister_T01Entity.RTN_SEQ;
            RTN_OTHERS = pWorkOrdersRegister_T01Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            DATE_FROM = pWorkOrdersRegister_T01Entity.DATE_FROM;
            DATE_TO = pWorkOrdersRegister_T01Entity.DATE_TO;
            ORDER_CODE = pWorkOrdersRegister_T01Entity.ORDER_CODE;
            ORDER_DATE = pWorkOrdersRegister_T01Entity.ORDER_DATE;
            PLAN_CODE = pWorkOrdersRegister_T01Entity.PLAN_CODE;
            PART_NAME = pWorkOrdersRegister_T01Entity.PART_NAME;
            PART_CODE = pWorkOrdersRegister_T01Entity.PART_CODE;
            RESOURCE_CODE = pWorkOrdersRegister_T01Entity.RESOURCE_CODE;
            RESOURCE_NAME = pWorkOrdersRegister_T01Entity.RESOURCE_NAME;
            PROCESS_CODE = pWorkOrdersRegister_T01Entity.PROCESS_CODE;
            USE_YN = pWorkOrdersRegister_T01Entity.USE_YN;
            ORDER_QTY = pWorkOrdersRegister_T01Entity.ORDER_QTY;
            COMPLETE_YN = pWorkOrdersRegister_T01Entity.COMPLETE_YN;
            WORKCENTER_CODE = pWorkOrdersRegister_T01Entity.WORKCENTER_CODE;
            REFERENCE_ID = pWorkOrdersRegister_T01Entity.REFERENCE_ID;


        }

        #endregion

    }

    public class WorkOrdersRegister_T02Entity
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
        public String DATE_FROM { get; set; } //조회 시작 날짜
        public String DATE_TO { get; set; } //조회 마감 날짜
        public String ORDER_CODE { get; set; } //작업지시 코드

        public String ORDER_DATE { get; set; } //작업지시 코드
        public String PLAN_CODE { get; set; } //생산계획 코드
        public String PART_NAME { get; set; } //품목명
        public String PART_CODE { get; set; } //품목 코드
        public String PROCESS_CODE { get; set; } //공정코드
        public String RESOURCE_CODE { get; set; } //설비명
        public String RESOURCE_NAME { get; set; } //설비 코드
        public String USE_YN { get; set; } //사용 유무

        public String ORDER_QTY { get; set; } //사용 유무

        public String COMPLETE_YN { get; set; } //사용 유무

        public String WORKCENTER_CODE { get; set; } //사용 유무

        public String REFERENCE_ID { get; set; } //사용 유무
        public String VEND_PART_CODE { get; set; }
        public String PRODUCTION_ORDER_ID { get; set; }
        public String ORDER_NUMBER { get; set; }
        public String ORDER_NAME { get; set; }
        public String PRODUCTION_PLAN_ID { get; set; }
        public String PRODUCTION_PLAN_DATE { get; set; }
        public String PRODUCTION_PLAN_SEQ { get; set; }
        public String CONTRACT_NUMBER { get; set; }

        #endregion

        #region 생성자 - WorkOrdersRegister_T02Entity()

        public WorkOrdersRegister_T02Entity()
        {
        }

        #endregion

        #region 생성자 - WorkOrdersRegister_T02Entity(WorkOrdersRegister_T02Entity pWorkOrdersRegister_T02Entity)

        public WorkOrdersRegister_T02Entity(WorkOrdersRegister_T02Entity pWorkOrdersRegister_T02Entity)
        {
            CORP_CODE = pWorkOrdersRegister_T02Entity.CORP_CODE;
            CRUD = pWorkOrdersRegister_T02Entity.CRUD;
            USER_CODE = pWorkOrdersRegister_T02Entity.USER_CODE;
            LANGUAGE_TYPE = pWorkOrdersRegister_T02Entity.LANGUAGE_TYPE;

            ERR_NO = pWorkOrdersRegister_T02Entity.ERR_NO;
            ERR_MSG = pWorkOrdersRegister_T02Entity.ERR_MSG;
            RTN_KEY = pWorkOrdersRegister_T02Entity.RTN_KEY;
            RTN_SEQ = pWorkOrdersRegister_T02Entity.RTN_SEQ;
            RTN_OTHERS = pWorkOrdersRegister_T02Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            DATE_FROM = pWorkOrdersRegister_T02Entity.DATE_FROM;
            DATE_TO = pWorkOrdersRegister_T02Entity.DATE_TO;
            ORDER_CODE = pWorkOrdersRegister_T02Entity.ORDER_CODE;
            ORDER_DATE = pWorkOrdersRegister_T02Entity.ORDER_DATE;
            PLAN_CODE = pWorkOrdersRegister_T02Entity.PLAN_CODE;
            PART_NAME = pWorkOrdersRegister_T02Entity.PART_NAME;
            PART_CODE = pWorkOrdersRegister_T02Entity.PART_CODE;
            RESOURCE_CODE = pWorkOrdersRegister_T02Entity.RESOURCE_CODE;
            RESOURCE_NAME = pWorkOrdersRegister_T02Entity.RESOURCE_NAME;
            PROCESS_CODE = pWorkOrdersRegister_T02Entity.PROCESS_CODE;
            USE_YN = pWorkOrdersRegister_T02Entity.USE_YN;
            ORDER_QTY = pWorkOrdersRegister_T02Entity.ORDER_QTY;
            COMPLETE_YN = pWorkOrdersRegister_T02Entity.COMPLETE_YN;
            WORKCENTER_CODE = pWorkOrdersRegister_T02Entity.WORKCENTER_CODE;
            REFERENCE_ID = pWorkOrdersRegister_T02Entity.REFERENCE_ID;
            VEND_PART_CODE = pWorkOrdersRegister_T02Entity.VEND_PART_CODE;
            PRODUCTION_ORDER_ID = pWorkOrdersRegister_T02Entity.PRODUCTION_ORDER_ID;
            ORDER_NUMBER = pWorkOrdersRegister_T02Entity.ORDER_NUMBER;
            ORDER_NAME = pWorkOrdersRegister_T02Entity.ORDER_NAME;
            PRODUCTION_PLAN_ID = pWorkOrdersRegister_T02Entity.PRODUCTION_PLAN_ID;
            PRODUCTION_PLAN_DATE = pWorkOrdersRegister_T02Entity.PRODUCTION_PLAN_DATE;
            PRODUCTION_PLAN_SEQ = pWorkOrdersRegister_T02Entity.PRODUCTION_PLAN_SEQ;
            CONTRACT_NUMBER = pWorkOrdersRegister_T02Entity.CONTRACT_NUMBER;

        }

        #endregion

    }

    public class ResultStatusDataEntity
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
        public String PART_NAME { get; set; }
        public String VEND_CODE { get; set; }
        public String VEND_NAME { get; set; }
        public String ORDER_ID { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - ResultStatusDataEntity()

        public ResultStatusDataEntity()
        {
        }

        #endregion

        #region 생성자 - ResultStatusDataEntity(pResultStatusDataEntity)

        public ResultStatusDataEntity(ResultStatusDataEntity pResultStatusDataEntity)
        {
            CORP_CODE = pResultStatusDataEntity.CORP_CODE;
            CRUD = pResultStatusDataEntity.CRUD;
            USER_CODE = pResultStatusDataEntity.USER_CODE;
            LANGUAGE_TYPE = pResultStatusDataEntity.LANGUAGE_TYPE;

            pResultStatusDataEntity.DATE_FROM = DATE_FROM;
            pResultStatusDataEntity.DATE_TO = DATE_TO;
            pResultStatusDataEntity.PART_NAME = PART_NAME;
            pResultStatusDataEntity.VEND_NAME = VEND_NAME;
            pResultStatusDataEntity.ORDER_ID = ORDER_ID;

            ERR_NO = pResultStatusDataEntity.ERR_NO;
            ERR_MSG = pResultStatusDataEntity.ERR_MSG;
            RTN_KEY = pResultStatusDataEntity.RTN_KEY;
            RTN_SEQ = pResultStatusDataEntity.RTN_SEQ;
            RTN_OTHERS = pResultStatusDataEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ResultStatusPlanResultEntity
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
        public String PART_NAME { get; set; }
        public String VEND_CODE { get; set; }
        public String VEND_NAME { get; set; }
        public String ORDER_ID { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - ResultStatusPlanResultEntity()

        public ResultStatusPlanResultEntity()
        {
        }

        #endregion

        #region 생성자 - ResultStatusPlanResultEntity(pResultStatusPlanResultEntity)

        public ResultStatusPlanResultEntity(ResultStatusPlanResultEntity pResultStatusPlanResultEntity)
        {
            CORP_CODE = pResultStatusPlanResultEntity.CORP_CODE;
            CRUD = pResultStatusPlanResultEntity.CRUD;
            USER_CODE = pResultStatusPlanResultEntity.USER_CODE;
            LANGUAGE_TYPE = pResultStatusPlanResultEntity.LANGUAGE_TYPE;

            pResultStatusPlanResultEntity.DATE_FROM = DATE_FROM;
            pResultStatusPlanResultEntity.DATE_TO = DATE_TO;
            pResultStatusPlanResultEntity.PART_NAME = PART_NAME;
            pResultStatusPlanResultEntity.VEND_NAME = VEND_NAME;
            pResultStatusPlanResultEntity.ORDER_ID = ORDER_ID;

            ERR_NO = pResultStatusPlanResultEntity.ERR_NO;
            ERR_MSG = pResultStatusPlanResultEntity.ERR_MSG;
            RTN_KEY = pResultStatusPlanResultEntity.RTN_KEY;
            RTN_SEQ = pResultStatusPlanResultEntity.RTN_SEQ;
            RTN_OTHERS = pResultStatusPlanResultEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ProductPlanMonthStatusEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE


        public String WINDOW_NAME { get; set; }
        public String DATE { get; set; }
      
        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - ProductPlanMonthStatusEntity()

        public ProductPlanMonthStatusEntity()
        {
        }

        #endregion

        #region 생성자 - ProductPlanMonthStatusEntity(pProductPlanMonthStatusEntity)

        public ProductPlanMonthStatusEntity(ProductPlanMonthStatusEntity pProductPlanMonthStatusEntity)
        {
            CORP_CODE = pProductPlanMonthStatusEntity.CORP_CODE;
            CRUD = pProductPlanMonthStatusEntity.CRUD;
            USER_CODE = pProductPlanMonthStatusEntity.USER_CODE;
            LANGUAGE_TYPE = pProductPlanMonthStatusEntity.LANGUAGE_TYPE;
            DATE = DATE;
            ERR_NO = pProductPlanMonthStatusEntity.ERR_NO;
            ERR_MSG = pProductPlanMonthStatusEntity.ERR_MSG;
            RTN_KEY = pProductPlanMonthStatusEntity.RTN_KEY;
            RTN_SEQ = pProductPlanMonthStatusEntity.RTN_SEQ;
            RTN_OTHERS = pProductPlanMonthStatusEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ProductTimeMonthLiveEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE


        public String WINDOW_NAME { get; set; }
        public String DATE { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - ProductPlanMonthStatusEntity()

        public ProductTimeMonthLiveEntity()
        {
        }

        #endregion

        #region 생성자 - ProductTimeMonthLiveEntity(pProductTimeMonthLiveEntity)

        public ProductTimeMonthLiveEntity(ProductTimeMonthLiveEntity pProductTimeMonthLiveEntity)
        {
            CORP_CODE = pProductTimeMonthLiveEntity.CORP_CODE;
            CRUD = pProductTimeMonthLiveEntity.CRUD;
            USER_CODE = pProductTimeMonthLiveEntity.USER_CODE;
            LANGUAGE_TYPE = pProductTimeMonthLiveEntity.LANGUAGE_TYPE;
            DATE = DATE;
            ERR_NO = pProductTimeMonthLiveEntity.ERR_NO;
            ERR_MSG = pProductTimeMonthLiveEntity.ERR_MSG;
            RTN_KEY = pProductTimeMonthLiveEntity.RTN_KEY;
            RTN_SEQ = pProductTimeMonthLiveEntity.RTN_SEQ;
            RTN_OTHERS = pProductTimeMonthLiveEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }


    public class ProductResultPlanStatusEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE


        public String WINDOW_NAME { get; set; }
        public String DATE { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - ProductResultPlanStatusEntity()

        public ProductResultPlanStatusEntity()
        {
        }

        #endregion

        #region 생성자 - ProductResultPlanStatusEntity(pProductResultPlanStatusEntity)

        public ProductResultPlanStatusEntity(ProductResultPlanStatusEntity pProductResultPlanStatusEntity)
        {
            CORP_CODE = pProductResultPlanStatusEntity.CORP_CODE;
            CRUD = pProductResultPlanStatusEntity.CRUD;
            USER_CODE = pProductResultPlanStatusEntity.USER_CODE;
            LANGUAGE_TYPE = pProductResultPlanStatusEntity.LANGUAGE_TYPE;
            DATE = DATE;
            ERR_NO = pProductResultPlanStatusEntity.ERR_NO;
            ERR_MSG = pProductResultPlanStatusEntity.ERR_MSG;
            RTN_KEY = pProductResultPlanStatusEntity.RTN_KEY;
            RTN_SEQ = pProductResultPlanStatusEntity.RTN_SEQ;
            RTN_OTHERS = pProductResultPlanStatusEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }
    public class ucMaterialUsagePartListPopupEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String WINDOW_NAME { get; set; }
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE

        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String PART_REVISION_NO { get; set; }
        public String VEND_PART_CODE { get; set; }

        public String PART_HIGH { get; set; }
        public String PART_MIDDLE { get; set; }
        public String PART_LOW { get; set; }

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

        #region 생성자 - ucMaterialUsagePartListPopupEntity()

        public ucMaterialUsagePartListPopupEntity()
        {
        }

        #endregion

        #region 생성자 - ucMaterialUsagePartListPopupEntity(ucMaterialUsagePartListPopupEntity pucMaterialUsagePartListPopupEntity)

        public ucMaterialUsagePartListPopupEntity(ucMaterialUsagePartListPopupEntity pucMaterialUsagePartListPopupEntity)
        {
            CORP_CODE = pucMaterialUsagePartListPopupEntity.CORP_CODE;
            CRUD = pucMaterialUsagePartListPopupEntity.CRUD;
            USER_CODE = pucMaterialUsagePartListPopupEntity.USER_CODE;
            LANGUAGE_TYPE = pucMaterialUsagePartListPopupEntity.LANGUAGE_TYPE;
            WINDOW_NAME = pucMaterialUsagePartListPopupEntity.WINDOW_NAME;

            PART_CODE = pucMaterialUsagePartListPopupEntity.PART_CODE;
            PART_NAME = pucMaterialUsagePartListPopupEntity.PART_NAME;
            PART_REVISION_NO = pucMaterialUsagePartListPopupEntity.PART_REVISION_NO;
            VEND_PART_CODE = pucMaterialUsagePartListPopupEntity.VEND_PART_CODE;

            PART_HIGH = pucMaterialUsagePartListPopupEntity.PART_HIGH;
            PART_MIDDLE = pucMaterialUsagePartListPopupEntity.PART_MIDDLE;
            PART_LOW = pucMaterialUsagePartListPopupEntity.PART_LOW;

            ERR_NO = pucMaterialUsagePartListPopupEntity.ERR_NO;
            ERR_MSG = pucMaterialUsagePartListPopupEntity.ERR_MSG;
            RTN_KEY = pucMaterialUsagePartListPopupEntity.RTN_KEY;
            RTN_SEQ = pucMaterialUsagePartListPopupEntity.RTN_SEQ;
            RTN_AQ = pucMaterialUsagePartListPopupEntity.RTN_AQ;
            RTN_SQ = pucMaterialUsagePartListPopupEntity.RTN_SQ;
            RTN_OTHERS = pucMaterialUsagePartListPopupEntity.RTN_OTHERS;
            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }


    public class ucProductionPartListPopup_T01Entity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String WINDOW_NAME { get; set; }
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE

        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String PART_REVISION_NO { get; set; }
        public String VEND_PART_CODE { get; set; }

        public String PART_HIGH { get; set; }
        public String PART_MIDDLE { get; set; }
        public String PART_LOW { get; set; }

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

        #region 생성자 - ucProductionPartListPopup_T01Entity()

        public ucProductionPartListPopup_T01Entity()
        {
        }

        #endregion

        #region 생성자 - ucProductionPartListPopup_T01Entity(ucProductionPartListPopup_T01Entity pucProductionPartListPopup_T01Entity)

        public ucProductionPartListPopup_T01Entity(ucProductionPartListPopup_T01Entity pucProductionPartListPopup_T01Entity)
        {
            CORP_CODE = pucProductionPartListPopup_T01Entity.CORP_CODE;
            CRUD = pucProductionPartListPopup_T01Entity.CRUD;
            USER_CODE = pucProductionPartListPopup_T01Entity.USER_CODE;
            LANGUAGE_TYPE = pucProductionPartListPopup_T01Entity.LANGUAGE_TYPE;
            WINDOW_NAME = pucProductionPartListPopup_T01Entity.WINDOW_NAME;

            PART_CODE = pucProductionPartListPopup_T01Entity.PART_CODE;
            PART_NAME = pucProductionPartListPopup_T01Entity.PART_NAME;
            PART_REVISION_NO = pucProductionPartListPopup_T01Entity.PART_REVISION_NO;
            VEND_PART_CODE = pucProductionPartListPopup_T01Entity.VEND_PART_CODE;

            PART_HIGH = pucProductionPartListPopup_T01Entity.PART_HIGH;
            PART_MIDDLE = pucProductionPartListPopup_T01Entity.PART_MIDDLE;
            PART_LOW = pucProductionPartListPopup_T01Entity.PART_LOW;

            ERR_NO = pucProductionPartListPopup_T01Entity.ERR_NO;
            ERR_MSG = pucProductionPartListPopup_T01Entity.ERR_MSG;
            RTN_KEY = pucProductionPartListPopup_T01Entity.RTN_KEY;
            RTN_SEQ = pucProductionPartListPopup_T01Entity.RTN_SEQ;
            RTN_AQ = pucProductionPartListPopup_T01Entity.RTN_AQ;
            RTN_SQ = pucProductionPartListPopup_T01Entity.RTN_SQ;
            RTN_OTHERS = pucProductionPartListPopup_T01Entity.RTN_OTHERS;
            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class ProductPlanRegister_T02Entity
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
        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String CONTRACT_ID { get; set; }
        public String CONTRACT_NUMBER { get; set; }
        public String USE_YN { get; set; }
        public String PRODUCTION_PLAN_ID { get; set; }
        public String ORDER_NUMBER { get; set; }
        public String ORDER_NAME { get; set; }
        public String ORDER_OPTION { get; set; }
        public String ORDER_SEQ { get; set; }
        public String ORDER_DATE { get; set; }
        public String REFERENCE_ID { get; set; }
        public String PRODUCTION_PLAN_DATE { get; set; }
        public String PRODUCTION_PLAN_SEQ { get; set; }
        public String REMARK { get; set; }
        public String ORDER_REVISION { get; set; }
        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_AQ { get; set; } // 리턴 순번 값
        public String RTN_SQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String VEND_CODE { get; set; }
        public String VEND_NAME { get; set; }

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - ProductPlanRegister_T02Entity()

        public ProductPlanRegister_T02Entity()
        {

        }

        #endregion

        #region 생성자 - ProductPlanRegister_T02Entity(ProductPlanRegister_T02Entity pProductPlanRegister_T02Entity)

        public ProductPlanRegister_T02Entity(ProductPlanRegister_T02Entity pProductPlanRegister_T02Entity)
        {
            CORP_CODE = pProductPlanRegister_T02Entity.CORP_CODE;
            CRUD = pProductPlanRegister_T02Entity.CRUD;
            USER_CODE = pProductPlanRegister_T02Entity.USER_CODE;
            LANGUAGE_TYPE = pProductPlanRegister_T02Entity.LANGUAGE_TYPE;

            pProductPlanRegister_T02Entity.DATE_FROM = DATE_FROM;
            pProductPlanRegister_T02Entity.DATE_TO = DATE_TO;
            pProductPlanRegister_T02Entity.CONTRACT_ID = CONTRACT_ID;
            pProductPlanRegister_T02Entity.PART_NAME = PART_NAME;
            pProductPlanRegister_T02Entity.CONTRACT_ID = CONTRACT_ID;
            pProductPlanRegister_T02Entity.USE_YN = USE_YN;
            pProductPlanRegister_T02Entity.PRODUCTION_PLAN_ID = PRODUCTION_PLAN_ID;
            pProductPlanRegister_T02Entity.ORDER_NAME = ORDER_NAME;
            pProductPlanRegister_T02Entity.ORDER_NUMBER = ORDER_NUMBER;
            pProductPlanRegister_T02Entity.REFERENCE_ID = REFERENCE_ID;
            pProductPlanRegister_T02Entity.ORDER_REVISION = ORDER_REVISION;
            pProductPlanRegister_T02Entity.VEND_CODE = VEND_CODE;
            pProductPlanRegister_T02Entity.VEND_NAME = VEND_NAME;
            pProductPlanRegister_T02Entity.ORDER_DATE = ORDER_DATE;
            pProductPlanRegister_T02Entity.ORDER_OPTION = ORDER_OPTION;

            pProductPlanRegister_T02Entity.PRODUCTION_PLAN_DATE = PRODUCTION_PLAN_DATE;
            pProductPlanRegister_T02Entity.PRODUCTION_PLAN_SEQ = PRODUCTION_PLAN_SEQ;
            pProductPlanRegister_T02Entity.REMARK = REMARK;

            ERR_NO = pProductPlanRegister_T02Entity.ERR_NO;
            ERR_MSG = pProductPlanRegister_T02Entity.ERR_MSG;
            RTN_KEY = pProductPlanRegister_T02Entity.RTN_KEY;
            RTN_SEQ = pProductPlanRegister_T02Entity.RTN_SEQ;
            RTN_AQ = pProductPlanRegister_T02Entity.RTN_AQ;
            RTN_SQ = pProductPlanRegister_T02Entity.RTN_SQ;
            RTN_OTHERS = pProductPlanRegister_T02Entity.RTN_OTHERS;


            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }
    public class ResultStatusProductEntity
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
        public String PART_NAME { get; set; }
        public String VEND_CODE { get; set; }
        public String VEND_NAME { get; set; }
        public String ORDER_ID { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - ResultStatusProductEntity()

        public ResultStatusProductEntity()
        {
        }

        #endregion

        #region 생성자 - ResultStatusProductEntity(pResultStatusProductEntity)

        public ResultStatusProductEntity(ResultStatusProductEntity pResultStatusProductEntity)
        {
            CORP_CODE = pResultStatusProductEntity.CORP_CODE;
            CRUD = pResultStatusProductEntity.CRUD;
            USER_CODE = pResultStatusProductEntity.USER_CODE;
            LANGUAGE_TYPE = pResultStatusProductEntity.LANGUAGE_TYPE;

            pResultStatusProductEntity.DATE_FROM = DATE_FROM;
            pResultStatusProductEntity.DATE_TO = DATE_TO;
            pResultStatusProductEntity.PART_NAME = PART_NAME;
            pResultStatusProductEntity.VEND_NAME = VEND_NAME;
            pResultStatusProductEntity.ORDER_ID = ORDER_ID;

            ERR_NO = pResultStatusProductEntity.ERR_NO;
            ERR_MSG = pResultStatusProductEntity.ERR_MSG;
            RTN_KEY = pResultStatusProductEntity.RTN_KEY;
            RTN_SEQ = pResultStatusProductEntity.RTN_SEQ;
            RTN_OTHERS = pResultStatusProductEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ContractMstRegisterEntity
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
        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String VEND_CODE { get; set; }
        public String VEND_NAME { get; set; }
        public String CONTRACT_ID { get; set; }
        public String CONTRACT_DATE { get; set; }
        public String CONTRACT_QTY { get; set; }
        public String DELIVERY_DATE { get; set; }
        public String DELIVERY_LOCATION { get; set; }
        public String UNIT_CODE { get; set; }

        public String UNITCOST { get; set; }
        public String COST { get; set; }
        public String REMARK { get; set; }
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

        #region 생성자 - ContractMstRegisterEntity()

        public ContractMstRegisterEntity()
        {

        }

        #endregion

        #region 생성자 - ContractMstRegisterEntity(pContractMstRegisterEntity)

        public ContractMstRegisterEntity(ContractMstRegisterEntity pContractMstRegisterEntity)
        {
            CORP_CODE = pContractMstRegisterEntity.CORP_CODE;
            CRUD = pContractMstRegisterEntity.CRUD;
            USER_CODE = pContractMstRegisterEntity.USER_CODE;
            LANGUAGE_TYPE = pContractMstRegisterEntity.LANGUAGE_TYPE;

            pContractMstRegisterEntity.DATE_FROM = DATE_FROM;
            pContractMstRegisterEntity.DATE_TO = DATE_TO;
            pContractMstRegisterEntity.CONTRACT_ID = CONTRACT_ID;
            pContractMstRegisterEntity.PART_NAME = PART_NAME;
            pContractMstRegisterEntity.VEND_CODE = VEND_CODE;
            pContractMstRegisterEntity.VEND_NAME = VEND_NAME;
            pContractMstRegisterEntity.CONTRACT_ID = CONTRACT_ID;

            pContractMstRegisterEntity.CONTRACT_DATE = CONTRACT_DATE;
            pContractMstRegisterEntity.CONTRACT_QTY = CONTRACT_QTY;
            pContractMstRegisterEntity.DELIVERY_DATE = DELIVERY_DATE;
            pContractMstRegisterEntity.DELIVERY_LOCATION = DELIVERY_LOCATION;
            pContractMstRegisterEntity.UNITCOST = UNITCOST;
            pContractMstRegisterEntity.COST = COST;
            pContractMstRegisterEntity.REMARK = REMARK;
            pContractMstRegisterEntity.USE_YN = USE_YN;
            pContractMstRegisterEntity.USE_YN = UNIT_CODE;
            
            ERR_NO = pContractMstRegisterEntity.ERR_NO;
            ERR_MSG = pContractMstRegisterEntity.ERR_MSG;
            RTN_KEY = pContractMstRegisterEntity.RTN_KEY;
            RTN_SEQ = pContractMstRegisterEntity.RTN_SEQ;
            RTN_AQ = pContractMstRegisterEntity.RTN_AQ;
            RTN_SQ = pContractMstRegisterEntity.RTN_SQ;
            RTN_OTHERS = pContractMstRegisterEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ContractMstRegister_T01Entity
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
        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String VEND_CODE { get; set; }
        public String VEND_NAME { get; set; }
        public String CONTRACT_ID { get; set; }
        public String CONTRACT_DATE { get; set; }
        public String CONTRACT_QTY { get; set; }
        public String DELIVERY_DATE { get; set; }
        public String DELIVERY_LOCATION { get; set; }
        public String UNIT_CODE { get; set; }

        public String UNITCOST { get; set; }
        public String COST { get; set; }
        public String CONTRACT_NUMBER { get; set; }
        public String CONTEACT_NAME { get; set; }
        public String REMARK { get; set; }
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

        #region 생성자 - ContractMstRegister_T01Entity()

        public ContractMstRegister_T01Entity()
        {

        }

        #endregion

        #region 생성자 - ContractMstRegister_T01Entity(pContractMstRegister_T01Entity)

        public ContractMstRegister_T01Entity(ContractMstRegister_T01Entity pContractMstRegister_T01Entity)
        {
            CORP_CODE = pContractMstRegister_T01Entity.CORP_CODE;
            CRUD = pContractMstRegister_T01Entity.CRUD;
            USER_CODE = pContractMstRegister_T01Entity.USER_CODE;
            LANGUAGE_TYPE = pContractMstRegister_T01Entity.LANGUAGE_TYPE;

            pContractMstRegister_T01Entity.DATE_FROM = DATE_FROM;
            pContractMstRegister_T01Entity.DATE_TO = DATE_TO;
            pContractMstRegister_T01Entity.CONTRACT_ID = CONTRACT_ID;
            pContractMstRegister_T01Entity.PART_NAME = PART_NAME;
            pContractMstRegister_T01Entity.VEND_CODE = VEND_CODE;
            pContractMstRegister_T01Entity.VEND_NAME = VEND_NAME;
            pContractMstRegister_T01Entity.CONTRACT_ID = CONTRACT_ID;
            pContractMstRegister_T01Entity.CONTRACT_NUMBER = CONTRACT_NUMBER;
            pContractMstRegister_T01Entity.CONTEACT_NAME = CONTEACT_NAME;

            pContractMstRegister_T01Entity.CONTRACT_DATE = CONTRACT_DATE;
            pContractMstRegister_T01Entity.CONTRACT_QTY = CONTRACT_QTY;
            pContractMstRegister_T01Entity.DELIVERY_DATE = DELIVERY_DATE;
            pContractMstRegister_T01Entity.DELIVERY_LOCATION = DELIVERY_LOCATION;
            pContractMstRegister_T01Entity.UNITCOST = UNITCOST;
            pContractMstRegister_T01Entity.COST = COST;
            pContractMstRegister_T01Entity.REMARK = REMARK;
            pContractMstRegister_T01Entity.USE_YN = USE_YN;
            pContractMstRegister_T01Entity.UNIT_CODE = UNIT_CODE;

            ERR_NO = pContractMstRegister_T01Entity.ERR_NO;
            ERR_MSG = pContractMstRegister_T01Entity.ERR_MSG;
            RTN_KEY = pContractMstRegister_T01Entity.RTN_KEY;
            RTN_SEQ = pContractMstRegister_T01Entity.RTN_SEQ;
            RTN_AQ = pContractMstRegister_T01Entity.RTN_AQ;
            RTN_SQ = pContractMstRegister_T01Entity.RTN_SQ;
            RTN_OTHERS = pContractMstRegister_T01Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class OutsourcingInfoRegisterEntity
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
        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String VEND_CODE { get; set; }
        public String VEND_NAME { get; set; }
        public String OUTSOURCING_ID { get; set; }
        public String OUTSOURCING_DATE { get; set; }
        public String OUTSOURCING_SEQ { get; set; }
        public String OUTSOURCING_ITEM { get; set; }
        public String OUTSOURCING_ITEM_QTY { get; set; }
        public String OUTSOURCING_STATUS { get; set; }
        public String OUTSOURCING_USER { get; set; }
        public String OUTSOURCING_NUMBER { get; set; }

        public String OUTSOURCING_MEMO { get; set; }
        public String REFERENCE_ID { get; set; }
        public String USE_YN { get; set; }
        public String PRODUCTION_ORDER_ID { get; set; }
        public String LOT_ID { get; set; }
        public String VEND_PART_CODE { get; set; }
        public String PART_HIGH { get; set; }
        public String PART_MIDDLE { get; set; }
        public String PART_LOW { get; set; }
        public String ORDER_NUMBER { get; set; }
        public String REMARK { get; set; }


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

        #region 생성자 - OutsourcingInfoRegisterEntity()

        public OutsourcingInfoRegisterEntity()
        {

        }

        #endregion

        #region 생성자 - OutsourcingInfoRegisterEntity(OutsourcingInfoRegisterEntity pOutsourcingInfoRegisterEntity)

        public OutsourcingInfoRegisterEntity(OutsourcingInfoRegisterEntity pOutsourcingInfoRegisterEntity)
        {
            CORP_CODE = pOutsourcingInfoRegisterEntity.CORP_CODE;
            CRUD = pOutsourcingInfoRegisterEntity.CRUD;
            USER_CODE = pOutsourcingInfoRegisterEntity.USER_CODE;
            LANGUAGE_TYPE = pOutsourcingInfoRegisterEntity.LANGUAGE_TYPE;

            pOutsourcingInfoRegisterEntity.DATE_FROM = DATE_FROM;
            pOutsourcingInfoRegisterEntity.DATE_TO = DATE_TO;
            pOutsourcingInfoRegisterEntity.PART_CODE = PART_CODE;
            pOutsourcingInfoRegisterEntity.PART_NAME = PART_NAME;
            pOutsourcingInfoRegisterEntity.VEND_CODE = VEND_CODE;
            pOutsourcingInfoRegisterEntity.VEND_NAME = VEND_NAME;
            pOutsourcingInfoRegisterEntity.OUTSOURCING_ID = OUTSOURCING_ID;
            pOutsourcingInfoRegisterEntity.OUTSOURCING_DATE = OUTSOURCING_DATE;
            pOutsourcingInfoRegisterEntity.OUTSOURCING_SEQ = OUTSOURCING_SEQ;
            pOutsourcingInfoRegisterEntity.OUTSOURCING_ITEM = OUTSOURCING_ITEM;
            pOutsourcingInfoRegisterEntity.OUTSOURCING_ITEM_QTY = OUTSOURCING_ITEM_QTY;
            pOutsourcingInfoRegisterEntity.OUTSOURCING_STATUS = OUTSOURCING_STATUS;
            pOutsourcingInfoRegisterEntity.REFERENCE_ID = REFERENCE_ID;
            pOutsourcingInfoRegisterEntity.USE_YN = USE_YN;
            pOutsourcingInfoRegisterEntity.PRODUCTION_ORDER_ID = PRODUCTION_ORDER_ID;
            pOutsourcingInfoRegisterEntity.LOT_ID = LOT_ID;
            pOutsourcingInfoRegisterEntity.VEND_PART_CODE = VEND_PART_CODE;
            pOutsourcingInfoRegisterEntity.PART_HIGH = PART_HIGH;
            pOutsourcingInfoRegisterEntity.PART_MIDDLE = PART_MIDDLE;
            pOutsourcingInfoRegisterEntity.PART_LOW = PART_LOW;
            pOutsourcingInfoRegisterEntity.ORDER_NUMBER = ORDER_NUMBER;
            pOutsourcingInfoRegisterEntity.REMARK = REMARK;
            pOutsourcingInfoRegisterEntity.OUTSOURCING_USER = OUTSOURCING_USER;
            pOutsourcingInfoRegisterEntity.OUTSOURCING_NUMBER = OUTSOURCING_NUMBER;
            pOutsourcingInfoRegisterEntity.OUTSOURCING_MEMO = OUTSOURCING_MEMO;


            ERR_NO = pOutsourcingInfoRegisterEntity.ERR_NO;
            ERR_MSG = pOutsourcingInfoRegisterEntity.ERR_MSG;
            RTN_KEY = pOutsourcingInfoRegisterEntity.RTN_KEY;
            RTN_SEQ = pOutsourcingInfoRegisterEntity.RTN_SEQ;
            RTN_AQ = pOutsourcingInfoRegisterEntity.RTN_AQ;
            RTN_SQ = pOutsourcingInfoRegisterEntity.RTN_SQ;
            RTN_OTHERS = pOutsourcingInfoRegisterEntity.RTN_OTHERS;
        }

        #endregion
    }

    public class ucOutsourcingInfoPopupEntity
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
        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String VEND_CODE { get; set; }
        public String VEND_NAME { get; set; }
        public String OUTSOURCING_ID { get; set; }
        public String OUTSOURCING_DATE { get; set; }
        public String OUTSOURCING_SEQ { get; set; }
        public String OUTSOURCING_ITEM { get; set; }
        public String OUTSOURCING_ITEM_QTY { get; set; }
        public String OUTSOURCING_STATUS { get; set; }
        public String REFERENCE_ID { get; set; }
        public String USE_YN { get; set; }
        public String PRODUCTION_ORDER_ID { get; set; }
        public String LOT_ID { get; set; }
        public String LOT_NO { get; set; }
        public String VEND_PART_CODE { get; set; }
        public String PART_HIGH { get; set; }
        public String PART_MIDDLE { get; set; }
        public String PART_LOW { get; set; }
        public String ORDER_NUMBER { get; set; }


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

        #region 생성자 - ucOutsourcingInfoPopupEntity()

        public ucOutsourcingInfoPopupEntity()
        {

        }

        #endregion

        #region 생성자 - ucOutsourcingInfoPopupEntity(ucOutsourcingInfoPopupEntity pucOutsourcingInfoPopupEntityEntity)

        public ucOutsourcingInfoPopupEntity(ucOutsourcingInfoPopupEntity pucOutsourcingInfoPopupEntityEntity)
        {
            CORP_CODE = pucOutsourcingInfoPopupEntityEntity.CORP_CODE;
            CRUD = pucOutsourcingInfoPopupEntityEntity.CRUD;
            USER_CODE = pucOutsourcingInfoPopupEntityEntity.USER_CODE;
            LANGUAGE_TYPE = pucOutsourcingInfoPopupEntityEntity.LANGUAGE_TYPE;

            pucOutsourcingInfoPopupEntityEntity.DATE_FROM = DATE_FROM;
            pucOutsourcingInfoPopupEntityEntity.DATE_TO = DATE_TO;
            pucOutsourcingInfoPopupEntityEntity.PART_CODE = PART_CODE;
            pucOutsourcingInfoPopupEntityEntity.PART_NAME = PART_NAME;
            pucOutsourcingInfoPopupEntityEntity.VEND_CODE = VEND_CODE;
            pucOutsourcingInfoPopupEntityEntity.VEND_NAME = VEND_NAME;
            pucOutsourcingInfoPopupEntityEntity.OUTSOURCING_ID = OUTSOURCING_ID;
            pucOutsourcingInfoPopupEntityEntity.OUTSOURCING_DATE = OUTSOURCING_DATE;
            pucOutsourcingInfoPopupEntityEntity.OUTSOURCING_SEQ = OUTSOURCING_SEQ;
            pucOutsourcingInfoPopupEntityEntity.OUTSOURCING_ITEM = OUTSOURCING_ITEM;
            pucOutsourcingInfoPopupEntityEntity.OUTSOURCING_ITEM_QTY = OUTSOURCING_ITEM_QTY;
            pucOutsourcingInfoPopupEntityEntity.OUTSOURCING_STATUS = OUTSOURCING_STATUS;
            pucOutsourcingInfoPopupEntityEntity.REFERENCE_ID = REFERENCE_ID;
            pucOutsourcingInfoPopupEntityEntity.USE_YN = USE_YN;
            pucOutsourcingInfoPopupEntityEntity.PRODUCTION_ORDER_ID = PRODUCTION_ORDER_ID;
            pucOutsourcingInfoPopupEntityEntity.LOT_ID = LOT_ID;
            pucOutsourcingInfoPopupEntityEntity.LOT_NO = LOT_NO;
            pucOutsourcingInfoPopupEntityEntity.VEND_PART_CODE = VEND_PART_CODE;
            pucOutsourcingInfoPopupEntityEntity.PART_HIGH = PART_HIGH;
            pucOutsourcingInfoPopupEntityEntity.PART_MIDDLE = PART_MIDDLE;
            pucOutsourcingInfoPopupEntityEntity.PART_LOW = PART_LOW;
            pucOutsourcingInfoPopupEntityEntity.ORDER_NUMBER = ORDER_NUMBER;


            ERR_NO = pucOutsourcingInfoPopupEntityEntity.ERR_NO;
            ERR_MSG = pucOutsourcingInfoPopupEntityEntity.ERR_MSG;
            RTN_KEY = pucOutsourcingInfoPopupEntityEntity.RTN_KEY;
            RTN_SEQ = pucOutsourcingInfoPopupEntityEntity.RTN_SEQ;
            RTN_AQ = pucOutsourcingInfoPopupEntityEntity.RTN_AQ;
            RTN_SQ = pucOutsourcingInfoPopupEntityEntity.RTN_SQ;
            RTN_OTHERS = pucOutsourcingInfoPopupEntityEntity.RTN_OTHERS;
        }

        #endregion
    }

    public class ucContractDocumentListPopupEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String WINDOW_NAME { get; set; }
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE
        
        public String CONTRACT_ID { get; set; }
        public String CONTRACT_NUMBER { get; set; }
        public String CONTRACT_REVISION { get; set; }
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
        
        #region 생성자 - ucContractDocumentListPopupEntity()

        public ucContractDocumentListPopupEntity()
        {
        }

        #endregion

        #region 생성자 - ucContractDocumentListPopupEntity(ucContractDocumentListPopupEntity pucContractDocumentListPopupEntity)

        public ucContractDocumentListPopupEntity(ucContractDocumentListPopupEntity pucContractDocumentListPopupEntity)
        {
            CORP_CODE = pucContractDocumentListPopupEntity.CORP_CODE;
            CRUD = pucContractDocumentListPopupEntity.CRUD;
            USER_CODE = pucContractDocumentListPopupEntity.USER_CODE;
            LANGUAGE_TYPE = pucContractDocumentListPopupEntity.LANGUAGE_TYPE;
            WINDOW_NAME = pucContractDocumentListPopupEntity.WINDOW_NAME;

            CONTRACT_ID = pucContractDocumentListPopupEntity.CONTRACT_ID;
            CONTRACT_NUMBER = pucContractDocumentListPopupEntity.CONTRACT_NUMBER;
            CONTRACT_REVISION = pucContractDocumentListPopupEntity.CONTRACT_REVISION;
            DOCUMENT_TYPE = pucContractDocumentListPopupEntity.DOCUMENT_TYPE;
            DOCUMENT_NAME = pucContractDocumentListPopupEntity.DOCUMENT_NAME;
            DOCUMENT_VER = pucContractDocumentListPopupEntity.DOCUMENT_VER;

            USE_YN = pucContractDocumentListPopupEntity.USE_YN;

            ERR_NO = pucContractDocumentListPopupEntity.ERR_NO;
            ERR_MSG = pucContractDocumentListPopupEntity.ERR_MSG;
            RTN_KEY = pucContractDocumentListPopupEntity.RTN_KEY;
            RTN_SEQ = pucContractDocumentListPopupEntity.RTN_SEQ;
            RTN_AQ = pucContractDocumentListPopupEntity.RTN_AQ;
            RTN_SQ = pucContractDocumentListPopupEntity.RTN_SQ;
            RTN_OTHERS = pucContractDocumentListPopupEntity.RTN_OTHERS;
            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class ProductPlanRegisterEntity
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
        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String CONTRACT_ID { get; set; }
        public String USE_YN { get; set; }
        public String  production_plan_id { get; set; }

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

        #region 생성자 - ProductPlanRegisterEntity()

        public ProductPlanRegisterEntity()
        {

        }

        #endregion

        #region 생성자 - ProductPlanRegisterEntity(pProductPlanRegisterEntity)

        public ProductPlanRegisterEntity(ProductPlanRegisterEntity pProductPlanRegisterEntity)
        {
            CORP_CODE = pProductPlanRegisterEntity.CORP_CODE;
            CRUD = pProductPlanRegisterEntity.CRUD;
            USER_CODE = pProductPlanRegisterEntity.USER_CODE;
            LANGUAGE_TYPE = pProductPlanRegisterEntity.LANGUAGE_TYPE;

            pProductPlanRegisterEntity.DATE_FROM = DATE_FROM;
            pProductPlanRegisterEntity.DATE_TO = DATE_TO;
            pProductPlanRegisterEntity.CONTRACT_ID = CONTRACT_ID;
            pProductPlanRegisterEntity.PART_NAME = PART_NAME;
            pProductPlanRegisterEntity.CONTRACT_ID = CONTRACT_ID;
            pProductPlanRegisterEntity.USE_YN = USE_YN;
            pProductPlanRegisterEntity.production_plan_id = production_plan_id;

            ERR_NO = pProductPlanRegisterEntity.ERR_NO;
            ERR_MSG = pProductPlanRegisterEntity.ERR_MSG;
            RTN_KEY = pProductPlanRegisterEntity.RTN_KEY;
            RTN_SEQ = pProductPlanRegisterEntity.RTN_SEQ;
            RTN_AQ = pProductPlanRegisterEntity.RTN_AQ;
            RTN_SQ = pProductPlanRegisterEntity.RTN_SQ;
            RTN_OTHERS = pProductPlanRegisterEntity.RTN_OTHERS;
          

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ProductPlanRegister_T50Entity
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
        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String CONTRACT_ID { get; set; }
        public String USE_YN { get; set; }
        public String production_plan_id { get; set; }

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

        #region 생성자 - ProductPlanRegister_T50Entity()

        public ProductPlanRegister_T50Entity()
        {

        }

        #endregion

        #region 생성자 - ProductPlanRegister_T50Entity(pProductPlanRegister_T50Entity)

        public ProductPlanRegister_T50Entity(ProductPlanRegister_T50Entity pProductPlanRegister_T50Entity)
        {
            CORP_CODE = pProductPlanRegister_T50Entity.CORP_CODE;
            CRUD = pProductPlanRegister_T50Entity.CRUD;
            USER_CODE = pProductPlanRegister_T50Entity.USER_CODE;
            LANGUAGE_TYPE = pProductPlanRegister_T50Entity.LANGUAGE_TYPE;

            pProductPlanRegister_T50Entity.DATE_FROM = DATE_FROM;
            pProductPlanRegister_T50Entity.DATE_TO = DATE_TO;
            pProductPlanRegister_T50Entity.CONTRACT_ID = CONTRACT_ID;
            pProductPlanRegister_T50Entity.PART_NAME = PART_NAME;
            pProductPlanRegister_T50Entity.CONTRACT_ID = CONTRACT_ID;
            pProductPlanRegister_T50Entity.USE_YN = USE_YN;
            pProductPlanRegister_T50Entity.production_plan_id = production_plan_id;

            ERR_NO = pProductPlanRegister_T50Entity.ERR_NO;
            ERR_MSG = pProductPlanRegister_T50Entity.ERR_MSG;
            RTN_KEY = pProductPlanRegister_T50Entity.RTN_KEY;
            RTN_SEQ = pProductPlanRegister_T50Entity.RTN_SEQ;
            RTN_AQ = pProductPlanRegister_T50Entity.RTN_AQ;
            RTN_SQ = pProductPlanRegister_T50Entity.RTN_SQ;
            RTN_OTHERS = pProductPlanRegister_T50Entity.RTN_OTHERS;


            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ProductPlanRegister_T01Entity
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
        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String CONTRACT_ID { get; set; }
        public String USE_YN { get; set; }
        public String production_plan_id { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_AQ { get; set; } // 리턴 순번 값
        public String RTN_SQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력        
        //작업지시 여부 확인용
        public String ORDER_CODE { get; set; } //지시번호
        public String REFERENCE_ID { get; set; } //생산계획번호
        public String PROCESS_CODE { get; set; } //공정코드
        public String WORKCENTER_CODE { get; set; } //작업장코드
        public String COMPLETE_YN { get; set; } // 완료여부
        
        #endregion

        #region 생성자 - ProductPlanRegister_T01Entity()

        public ProductPlanRegister_T01Entity()
        {

        }

        #endregion

        #region 생성자 - ProductPlanRegister_T01Entity(pProductPlanRegister_T01Entity)

        public ProductPlanRegister_T01Entity(ProductPlanRegister_T01Entity pProductPlanRegister_T01Entity)
        {
            CORP_CODE = pProductPlanRegister_T01Entity.CORP_CODE;
            CRUD = pProductPlanRegister_T01Entity.CRUD;
            USER_CODE = pProductPlanRegister_T01Entity.USER_CODE;
            LANGUAGE_TYPE = pProductPlanRegister_T01Entity.LANGUAGE_TYPE;

            pProductPlanRegister_T01Entity.DATE_FROM = DATE_FROM;
            pProductPlanRegister_T01Entity.DATE_TO = DATE_TO;
            pProductPlanRegister_T01Entity.CONTRACT_ID = CONTRACT_ID;
            pProductPlanRegister_T01Entity.PART_NAME = PART_NAME;
            pProductPlanRegister_T01Entity.CONTRACT_ID = CONTRACT_ID;
            pProductPlanRegister_T01Entity.USE_YN = USE_YN;
            pProductPlanRegister_T01Entity.production_plan_id = production_plan_id;

            ERR_NO = pProductPlanRegister_T01Entity.ERR_NO;
            ERR_MSG = pProductPlanRegister_T01Entity.ERR_MSG;
            RTN_KEY = pProductPlanRegister_T01Entity.RTN_KEY;
            RTN_SEQ = pProductPlanRegister_T01Entity.RTN_SEQ;
            RTN_AQ = pProductPlanRegister_T01Entity.RTN_AQ;
            RTN_SQ = pProductPlanRegister_T01Entity.RTN_SQ;
            RTN_OTHERS = pProductPlanRegister_T01Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            //작업지시 여부 확인용
            ORDER_CODE = pProductPlanRegister_T01Entity.ORDER_CODE;
            REFERENCE_ID = pProductPlanRegister_T01Entity.REFERENCE_ID;
            PROCESS_CODE = pProductPlanRegister_T01Entity.PROCESS_CODE;
            WORKCENTER_CODE = pProductPlanRegister_T01Entity.WORKCENTER_CODE;
            COMPLETE_YN = pProductPlanRegister_T01Entity.COMPLETE_YN;
        }

        #endregion

    }

    public class ucOrderNumberInfoListPopupEntity
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
        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String CONTRACT_ID { get; set; }
        public String CONTRACT_NUMBER { get; set; }
        public String USE_YN { get; set; }
        public String PRODUCTION_PLAN_ID { get; set; }
        public String ORDER_NUMBER { get;set;}
        public String ORDER_NAME { get; set; }
        public String ORDER_SEQ { get; set; }
        public String ORDER_DATE { get; set; }
        public String REFERENCE_ID { get; set; }
        public String PRODUCTION_PLAN_DATE { get; set; }
        public String PRODUCTION_PLAN_SEQ { get; set; }
        public String REMARK { get; set; }
        public String ORDER_REVISION { get; set; }
        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_AQ { get; set; } // 리턴 순번 값
        public String RTN_SQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String VEND_CODE { get; set; }
        public String VEND_NAME { get; set; }

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - ucOrderNumberInfoListPopupEntity()

        public ucOrderNumberInfoListPopupEntity()
        {

        }

        #endregion

        #region 생성자 - ucOrderNumberInfoListPopupEntity(ucOrderNumberInfoListPopupEntity pucOrderNumberInfoListPopupEntity)

        public ucOrderNumberInfoListPopupEntity(ucOrderNumberInfoListPopupEntity pucOrderNumberInfoListPopupEntity)
        {
            CORP_CODE = pucOrderNumberInfoListPopupEntity.CORP_CODE;
            CRUD = pucOrderNumberInfoListPopupEntity.CRUD;
            USER_CODE = pucOrderNumberInfoListPopupEntity.USER_CODE;
            LANGUAGE_TYPE = pucOrderNumberInfoListPopupEntity.LANGUAGE_TYPE;

            pucOrderNumberInfoListPopupEntity.DATE_FROM = DATE_FROM;
            pucOrderNumberInfoListPopupEntity.DATE_TO = DATE_TO;
            pucOrderNumberInfoListPopupEntity.CONTRACT_ID = CONTRACT_ID;
            pucOrderNumberInfoListPopupEntity.PART_NAME = PART_NAME;
            pucOrderNumberInfoListPopupEntity.CONTRACT_ID = CONTRACT_ID;
            pucOrderNumberInfoListPopupEntity.USE_YN = USE_YN;
            pucOrderNumberInfoListPopupEntity.PRODUCTION_PLAN_ID = PRODUCTION_PLAN_ID;
            pucOrderNumberInfoListPopupEntity.ORDER_NAME = ORDER_NAME;
            pucOrderNumberInfoListPopupEntity.ORDER_NUMBER = ORDER_NUMBER;
            pucOrderNumberInfoListPopupEntity.REFERENCE_ID = REFERENCE_ID;
            pucOrderNumberInfoListPopupEntity.ORDER_REVISION = ORDER_REVISION;
            pucOrderNumberInfoListPopupEntity.VEND_CODE = VEND_CODE;
            pucOrderNumberInfoListPopupEntity.VEND_NAME = VEND_NAME;
            pucOrderNumberInfoListPopupEntity.ORDER_DATE = ORDER_DATE;

            pucOrderNumberInfoListPopupEntity.PRODUCTION_PLAN_DATE = PRODUCTION_PLAN_DATE;
            pucOrderNumberInfoListPopupEntity.PRODUCTION_PLAN_SEQ = PRODUCTION_PLAN_SEQ;
            pucOrderNumberInfoListPopupEntity.REMARK = REMARK;

            ERR_NO = pucOrderNumberInfoListPopupEntity.ERR_NO;
            ERR_MSG = pucOrderNumberInfoListPopupEntity.ERR_MSG;
            RTN_KEY = pucOrderNumberInfoListPopupEntity.RTN_KEY;
            RTN_SEQ = pucOrderNumberInfoListPopupEntity.RTN_SEQ;
            RTN_AQ = pucOrderNumberInfoListPopupEntity.RTN_AQ;
            RTN_SQ = pucOrderNumberInfoListPopupEntity.RTN_SQ;
            RTN_OTHERS = pucOrderNumberInfoListPopupEntity.RTN_OTHERS;


            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }


    public class ucProductPlanDocumentListPopupEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String WINDOW_NAME { get; set; }
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE

        public String PRODUCTION_PLAN_ID { get; set; }
        public String PRODUCTION_PLAN_SEQ { get; set; }
        public String DOCUMENT_TYPE { get; set; }
        public String DOCUMENT_NAME { get; set; }
        public String DOCUMENT_VER { get; set; }
        public String CONTRACT_ID { get; set; }
        public String CONTRACT_NUMBER { get; set; }
        public String CONTRACT_REVISION { get; set; }
        public String ORDER_NUMBER { get; set; }
        public String ORDER_REVISION { get; set; }

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

        #region 생성자 - ucProductPlanDocumentListPopupEntity()

        public ucProductPlanDocumentListPopupEntity()
        {
        }

        #endregion

        #region 생성자 - ucProductPlanDocumentListPopupEntity(ucProductPlanDocumentListPopupEntity pucProductPlanDocumentListPopupEntity)

        public ucProductPlanDocumentListPopupEntity(ucProductPlanDocumentListPopupEntity pucProductPlanDocumentListPopupEntity)
        {
            CORP_CODE = pucProductPlanDocumentListPopupEntity.CORP_CODE;
            CRUD = pucProductPlanDocumentListPopupEntity.CRUD;
            USER_CODE = pucProductPlanDocumentListPopupEntity.USER_CODE;
            LANGUAGE_TYPE = pucProductPlanDocumentListPopupEntity.LANGUAGE_TYPE;
            WINDOW_NAME = pucProductPlanDocumentListPopupEntity.WINDOW_NAME;

            PRODUCTION_PLAN_ID = pucProductPlanDocumentListPopupEntity.PRODUCTION_PLAN_ID;
            PRODUCTION_PLAN_SEQ = pucProductPlanDocumentListPopupEntity.PRODUCTION_PLAN_SEQ;
            DOCUMENT_TYPE = pucProductPlanDocumentListPopupEntity.DOCUMENT_TYPE;
            DOCUMENT_NAME = pucProductPlanDocumentListPopupEntity.DOCUMENT_NAME;
            DOCUMENT_VER = pucProductPlanDocumentListPopupEntity.DOCUMENT_VER;
            CONTRACT_ID = pucProductPlanDocumentListPopupEntity.CONTRACT_ID;
            CONTRACT_NUMBER = pucProductPlanDocumentListPopupEntity.CONTRACT_NUMBER;
            CONTRACT_REVISION = pucProductPlanDocumentListPopupEntity.CONTRACT_REVISION;
            ORDER_NUMBER = pucProductPlanDocumentListPopupEntity.ORDER_NUMBER;
            ORDER_REVISION = pucProductPlanDocumentListPopupEntity.ORDER_REVISION;

            USE_YN = pucProductPlanDocumentListPopupEntity.USE_YN;

            ERR_NO = pucProductPlanDocumentListPopupEntity.ERR_NO;
            ERR_MSG = pucProductPlanDocumentListPopupEntity.ERR_MSG;
            RTN_KEY = pucProductPlanDocumentListPopupEntity.RTN_KEY;
            RTN_SEQ = pucProductPlanDocumentListPopupEntity.RTN_SEQ;
            RTN_AQ = pucProductPlanDocumentListPopupEntity.RTN_AQ;
            RTN_SQ = pucProductPlanDocumentListPopupEntity.RTN_SQ;
            RTN_OTHERS = pucProductPlanDocumentListPopupEntity.RTN_OTHERS;
            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class JobResultRegisterEntity
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
        public String PART_NAME { get; set; }
        public String VEND_CODE { get; set; }
        public String VEND_NAME { get; set; }
        public String ORDER_ID { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - JobResultRegisterEntity()

        public JobResultRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - JobResultRegisterEntity(pJobResultRegisterEntity)

        public JobResultRegisterEntity(JobResultRegisterEntity pJobResultRegisterEntity)
        {
            CORP_CODE = pJobResultRegisterEntity.CORP_CODE;
            CRUD = pJobResultRegisterEntity.CRUD;
            USER_CODE = pJobResultRegisterEntity.USER_CODE;
            LANGUAGE_TYPE = pJobResultRegisterEntity.LANGUAGE_TYPE;

            pJobResultRegisterEntity.DATE_FROM = DATE_FROM;
            pJobResultRegisterEntity.DATE_TO = DATE_TO;
            pJobResultRegisterEntity.PART_NAME = PART_NAME;
            pJobResultRegisterEntity.VEND_NAME = VEND_NAME;
            pJobResultRegisterEntity.ORDER_ID = ORDER_ID;

            ERR_NO = pJobResultRegisterEntity.ERR_NO;
            ERR_MSG = pJobResultRegisterEntity.ERR_MSG;
            RTN_KEY = pJobResultRegisterEntity.RTN_KEY;
            RTN_SEQ = pJobResultRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pJobResultRegisterEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class Facility_Utilization_StatusEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE
        
        public String WINDOW_NAME { get; set; }
        public String DATE_YEAR { get; set; }
        public String DATE_MONTH { get; set; }
        public String PART_NAME { get; set; }
        public String VEND_CODE { get; set; }
        public String VEND_NAME { get; set; }
        public String ORDER_ID { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - Facility_Utilization_StatusEntity()

        public Facility_Utilization_StatusEntity()
        {
        }

        #endregion

        #region 생성자 - JobResultRegisterEntity(pJobResultRegisterEntity)

        public Facility_Utilization_StatusEntity(Facility_Utilization_StatusEntity pFacility_Utilization_StatusEntity)
        {
            CORP_CODE = pFacility_Utilization_StatusEntity.CORP_CODE;
            CRUD = pFacility_Utilization_StatusEntity.CRUD;
            USER_CODE = pFacility_Utilization_StatusEntity.USER_CODE;
            LANGUAGE_TYPE = pFacility_Utilization_StatusEntity.LANGUAGE_TYPE;

            pFacility_Utilization_StatusEntity.DATE_YEAR = DATE_YEAR;
            pFacility_Utilization_StatusEntity.DATE_MONTH = DATE_MONTH;
            pFacility_Utilization_StatusEntity.PART_NAME = PART_NAME;
            pFacility_Utilization_StatusEntity.VEND_NAME = VEND_NAME;
            pFacility_Utilization_StatusEntity.ORDER_ID = ORDER_ID;

            ERR_NO = pFacility_Utilization_StatusEntity.ERR_NO;
            ERR_MSG = pFacility_Utilization_StatusEntity.ERR_MSG;
            RTN_KEY = pFacility_Utilization_StatusEntity.RTN_KEY;
            RTN_SEQ = pFacility_Utilization_StatusEntity.RTN_SEQ;
            RTN_OTHERS = pFacility_Utilization_StatusEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class JobResultStatus_NGEntity
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
        public String PART_NAME { get; set; }
        public String VEND_CODE { get; set; }
        public String VEND_NAME { get; set; }
        public String ORDER_ID { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - JobResultStatus_NGEntity()

        public JobResultStatus_NGEntity()
        {
        }

        #endregion

        #region 생성자 - JobResultStatus_NGEntity(pJobResultStatus_NGEntity)

        public JobResultStatus_NGEntity(JobResultStatus_NGEntity pJobResultStatus_NGEntity)
        {
            CORP_CODE = pJobResultStatus_NGEntity.CORP_CODE;
            CRUD = pJobResultStatus_NGEntity.CRUD;
            USER_CODE = pJobResultStatus_NGEntity.USER_CODE;
            LANGUAGE_TYPE = pJobResultStatus_NGEntity.LANGUAGE_TYPE;

            pJobResultStatus_NGEntity.DATE_FROM = DATE_FROM;
            pJobResultStatus_NGEntity.DATE_TO = DATE_TO;
            pJobResultStatus_NGEntity.PART_NAME = PART_NAME;
            pJobResultStatus_NGEntity.VEND_NAME = VEND_NAME;
            pJobResultStatus_NGEntity.ORDER_ID = ORDER_ID;

            ERR_NO = pJobResultStatus_NGEntity.ERR_NO;
            ERR_MSG = pJobResultStatus_NGEntity.ERR_MSG;
            RTN_KEY = pJobResultStatus_NGEntity.RTN_KEY;
            RTN_SEQ = pJobResultStatus_NGEntity.RTN_SEQ;
            RTN_OTHERS = pJobResultStatus_NGEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ProductMonitoringEntity
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
        public String PART_NAME { get; set; }
        public String VEND_CODE { get; set; }
        public String VEND_NAME { get; set; }
        public String ORDER_ID { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - ProductMonitoringEntity()

        public ProductMonitoringEntity()
        {
        }

        #endregion

        #region 생성자 - ProductMonitoringEntity(pProductMonitoringEntity)

        public ProductMonitoringEntity(ProductMonitoringEntity pProductMonitoringEntity)
        {
            CORP_CODE = pProductMonitoringEntity.CORP_CODE;
            CRUD = pProductMonitoringEntity.CRUD;
            USER_CODE = pProductMonitoringEntity.USER_CODE;
            LANGUAGE_TYPE = pProductMonitoringEntity.LANGUAGE_TYPE;

            pProductMonitoringEntity.DATE_FROM = DATE_FROM;
            pProductMonitoringEntity.DATE_TO = DATE_TO;
            pProductMonitoringEntity.PART_NAME = PART_NAME;
            pProductMonitoringEntity.VEND_NAME = VEND_NAME;
            pProductMonitoringEntity.ORDER_ID = ORDER_ID;

            ERR_NO = pProductMonitoringEntity.ERR_NO;
            ERR_MSG = pProductMonitoringEntity.ERR_MSG;
            RTN_KEY = pProductMonitoringEntity.RTN_KEY;
            RTN_SEQ = pProductMonitoringEntity.RTN_SEQ;
            RTN_OTHERS = pProductMonitoringEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }
    public class ProductMonitoring_T01Entity
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
        public String PART_NAME { get; set; }
        public String VEND_CODE { get; set; }
        public String VEND_NAME { get; set; }
        public String ORDER_ID { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - ProductMonitoring_T01Entity()

        public ProductMonitoring_T01Entity()
        {
        }

        #endregion

        #region 생성자 - ProductMonitoring_T01Entity(pProductMonitoring_T01Entity)

        public ProductMonitoring_T01Entity(ProductMonitoring_T01Entity pProductMonitoring_T01Entity)
        {
            CORP_CODE = pProductMonitoring_T01Entity.CORP_CODE;
            CRUD = pProductMonitoring_T01Entity.CRUD;
            USER_CODE = pProductMonitoring_T01Entity.USER_CODE;
            LANGUAGE_TYPE = pProductMonitoring_T01Entity.LANGUAGE_TYPE;

            pProductMonitoring_T01Entity.DATE_FROM = DATE_FROM;
            pProductMonitoring_T01Entity.DATE_TO = DATE_TO;
            pProductMonitoring_T01Entity.PART_NAME = PART_NAME;
            pProductMonitoring_T01Entity.VEND_NAME = VEND_NAME;
            pProductMonitoring_T01Entity.ORDER_ID = ORDER_ID;

            ERR_NO = pProductMonitoring_T01Entity.ERR_NO;
            ERR_MSG = pProductMonitoring_T01Entity.ERR_MSG;
            RTN_KEY = pProductMonitoring_T01Entity.RTN_KEY;
            RTN_SEQ = pProductMonitoring_T01Entity.RTN_SEQ;
            RTN_OTHERS = pProductMonitoring_T01Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }
    public class ProductMonitoring_T02Entity
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
        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        public String VEND_NAME { get; set; }

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

        public ProductMonitoring_T02Entity()
        {
        }

        #endregion

        #region 생성자 - POPProductMonitoringEntity(pPOPProductMonitoringEntity)

        public ProductMonitoring_T02Entity(ProductMonitoring_T02Entity pProductMonitoring_T02Entity)
        {
            CORP_CODE = pProductMonitoring_T02Entity.CORP_CODE;
            CRUD = pProductMonitoring_T02Entity.CRUD;
            USER_CODE = pProductMonitoring_T02Entity.USER_CODE;
            USER_NAME = pProductMonitoring_T02Entity.USER_NAME;
            ERR_NO = pProductMonitoring_T02Entity.ERR_NO;
            ERR_MSG = pProductMonitoring_T02Entity.ERR_MSG;
            RTN_KEY = pProductMonitoring_T02Entity.RTN_KEY;
            RTN_SEQ = pProductMonitoring_T02Entity.RTN_SEQ;
            RTN_OTHERS = pProductMonitoring_T02Entity.RTN_OTHERS;
            LANGUAGE_TYPE = pProductMonitoring_T02Entity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
            WINDOW_NAME = pProductMonitoring_T02Entity.WINDOW_NAME;
            RESOURCE_CODE = pProductMonitoring_T02Entity.RESOURCE_CODE;
            RESOURCE_CODE = pProductMonitoring_T02Entity.RESOURCE_CODE;
            COLLECTION_DATE = pProductMonitoring_T02Entity.COLLECTION_DATE;
            PROPERTY_VALUE = pProductMonitoring_T02Entity.PROPERTY_VALUE;
            CONDITION_CODE = pProductMonitoring_T02Entity.CONDITION_CODE;
            COLLECTION_VALUE = pProductMonitoring_T02Entity.COLLECTION_VALUE;
            COMMON_TYPE = pProductMonitoring_T02Entity.COMMON_TYPE;

            DATE_FROM = pProductMonitoring_T02Entity.DATE_FROM;
            DATE_TO = pProductMonitoring_T02Entity.DATE_TO;
            VEND_NAME = pProductMonitoring_T02Entity.VEND_NAME;

            PRODUCTION_ORDER_ID = pProductMonitoring_T02Entity.PRODUCTION_ORDER_ID;
            COMPLETE_YN = pProductMonitoring_T02Entity.COMPLETE_YN;

            PART_BARCODE = pProductMonitoring_T02Entity.PART_BARCODE;
            PRINT_DATE = pProductMonitoring_T02Entity.PRINT_DATE;
            PRINT_SEQ = pProductMonitoring_T02Entity.PRINT_SEQ;
            PART_CODE = pProductMonitoring_T02Entity.PART_CODE;
            PART_QTY = pProductMonitoring_T02Entity.PART_QTY;
        }
        #endregion

    }

    public class ProductMonitoring_T03Entity
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
        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        public String VEND_NAME { get; set; }

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

        public ProductMonitoring_T03Entity()
        {

        }

        #endregion

        #region 생성자 - POPProductMonitoringEntity(pPOPProductMonitoringEntity)

        public ProductMonitoring_T03Entity(ProductMonitoring_T03Entity pProductMonitoring_T03Entity)
        {
            CORP_CODE = pProductMonitoring_T03Entity.CORP_CODE;
            CRUD = pProductMonitoring_T03Entity.CRUD;
            USER_CODE = pProductMonitoring_T03Entity.USER_CODE;
            USER_NAME = pProductMonitoring_T03Entity.USER_NAME;
            ERR_NO = pProductMonitoring_T03Entity.ERR_NO;
            ERR_MSG = pProductMonitoring_T03Entity.ERR_MSG;
            RTN_KEY = pProductMonitoring_T03Entity.RTN_KEY;
            RTN_SEQ = pProductMonitoring_T03Entity.RTN_SEQ;
            RTN_OTHERS = pProductMonitoring_T03Entity.RTN_OTHERS;
            LANGUAGE_TYPE = pProductMonitoring_T03Entity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
            WINDOW_NAME = pProductMonitoring_T03Entity.WINDOW_NAME;
            RESOURCE_CODE = pProductMonitoring_T03Entity.RESOURCE_CODE;
            RESOURCE_CODE = pProductMonitoring_T03Entity.RESOURCE_CODE;
            COLLECTION_DATE = pProductMonitoring_T03Entity.COLLECTION_DATE;
            PROPERTY_VALUE = pProductMonitoring_T03Entity.PROPERTY_VALUE;
            CONDITION_CODE = pProductMonitoring_T03Entity.CONDITION_CODE;
            COLLECTION_VALUE = pProductMonitoring_T03Entity.COLLECTION_VALUE;
            COMMON_TYPE = pProductMonitoring_T03Entity.COMMON_TYPE;

            DATE_FROM = pProductMonitoring_T03Entity.DATE_FROM;
            DATE_TO = pProductMonitoring_T03Entity.DATE_TO;
            VEND_NAME = pProductMonitoring_T03Entity.VEND_NAME;

            PRODUCTION_ORDER_ID = pProductMonitoring_T03Entity.PRODUCTION_ORDER_ID;
            COMPLETE_YN = pProductMonitoring_T03Entity.COMPLETE_YN;

            PART_BARCODE = pProductMonitoring_T03Entity.PART_BARCODE;
            PRINT_DATE = pProductMonitoring_T03Entity.PRINT_DATE;
            PRINT_SEQ = pProductMonitoring_T03Entity.PRINT_SEQ;
            PART_CODE = pProductMonitoring_T03Entity.PART_CODE;
            PART_QTY = pProductMonitoring_T03Entity.PART_QTY;
        }
        #endregion

    }
    public class NgResultRegisterEntity
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
        public String PART_NAME { get; set; }
        public String VEND_CODE { get; set; }
        public String VEND_NAME { get; set; }
        public String ORDER_ID { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - NgResultRegisterEntity()

        public NgResultRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - NgResultRegisterEntity(pNgResultRegisterEntity)

        public NgResultRegisterEntity(NgResultRegisterEntity pNgResultRegisterEntity)
        {
            CORP_CODE = pNgResultRegisterEntity.CORP_CODE;
            CRUD = pNgResultRegisterEntity.CRUD;
            USER_CODE = pNgResultRegisterEntity.USER_CODE;
            LANGUAGE_TYPE = pNgResultRegisterEntity.LANGUAGE_TYPE;

            pNgResultRegisterEntity.DATE_FROM = DATE_FROM;
            pNgResultRegisterEntity.DATE_TO = DATE_TO;
            pNgResultRegisterEntity.PART_NAME = PART_NAME;
            pNgResultRegisterEntity.VEND_NAME = VEND_NAME;
            pNgResultRegisterEntity.ORDER_ID = ORDER_ID;

            ERR_NO = pNgResultRegisterEntity.ERR_NO;
            ERR_MSG = pNgResultRegisterEntity.ERR_MSG;
            RTN_KEY = pNgResultRegisterEntity.RTN_KEY;
            RTN_SEQ = pNgResultRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pNgResultRegisterEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class PlanResult_JobResultEntity
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
        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String VEND_CODE { get; set; }
        public String VEND_NAME { get; set; }
        public String ORDER_ID { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - PlanResult_JobResultEntity()

        public PlanResult_JobResultEntity()
        {
        }

        #endregion

        #region 생성자 - PlanResult_JobResultEntity(pPlanResult_JobResultEntity)

        public PlanResult_JobResultEntity(PlanResult_JobResultEntity pPlanResult_JobResultEntity)
        {
            CORP_CODE = pPlanResult_JobResultEntity.CORP_CODE;
            CRUD = pPlanResult_JobResultEntity.CRUD;
            USER_CODE = pPlanResult_JobResultEntity.USER_CODE;
            LANGUAGE_TYPE = pPlanResult_JobResultEntity.LANGUAGE_TYPE;

            pPlanResult_JobResultEntity.DATE_FROM = DATE_FROM;
            pPlanResult_JobResultEntity.DATE_TO = DATE_TO;
            pPlanResult_JobResultEntity.PART_NAME = PART_CODE;
            pPlanResult_JobResultEntity.PART_NAME = PART_NAME;
            pPlanResult_JobResultEntity.VEND_NAME = VEND_NAME;
            pPlanResult_JobResultEntity.ORDER_ID = ORDER_ID;

            ERR_NO = pPlanResult_JobResultEntity.ERR_NO;
            ERR_MSG = pPlanResult_JobResultEntity.ERR_MSG;
            RTN_KEY = pPlanResult_JobResultEntity.RTN_KEY;
            RTN_SEQ = pPlanResult_JobResultEntity.RTN_SEQ;
            RTN_OTHERS = pPlanResult_JobResultEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class WorkResultRegisterEntity
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

        public String PROCESS_CODE1 { get; set; }
        public String PROCESS_NAME1 { get; set; }
        public String WORKCENTER_CODE { get; set; }
        public String WORKCENTER_NAME { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - WorkResultRegisterEntity()

        public WorkResultRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - WorkResultRegisterEntity(WorkResultRegisterEntity pWorkResultRegisterEntity)

        public WorkResultRegisterEntity(WorkResultRegisterEntity pWorkResultRegisterEntity)
        {
            CORP_CODE = pWorkResultRegisterEntity.CORP_CODE;
            CRUD = pWorkResultRegisterEntity.CRUD;
            USER_CODE = pWorkResultRegisterEntity.USER_CODE;
            WINDOW_NAME = pWorkResultRegisterEntity.WINDOW_NAME;
            LANGUAGE_TYPE = pWorkResultRegisterEntity.LANGUAGE_TYPE;

            DATE_FROM = pWorkResultRegisterEntity.DATE_FROM;
            DATE_TO = pWorkResultRegisterEntity.DATE_TO;
            PRODUCTION_ORDER_ID = pWorkResultRegisterEntity.PRODUCTION_ORDER_ID;
            PART_CODE = pWorkResultRegisterEntity.PART_CODE;
            PART_NAME = pWorkResultRegisterEntity.PART_NAME;
            PRODUCTION_PLAN_ID = pWorkResultRegisterEntity.PRODUCTION_PLAN_ID;
            PROCESS_CODE_MST = pWorkResultRegisterEntity.PROCESS_CODE_MST;
            PROCESS_CODE = pWorkResultRegisterEntity.PROCESS_CODE;
            CODE_GUBN = pWorkResultRegisterEntity.CODE_GUBN;
            USE_YN = pWorkResultRegisterEntity.USE_YN;
            COMPLETE_YN = pWorkResultRegisterEntity.COMPLETE_YN;

            PROCESS_CODE1 = pWorkResultRegisterEntity.PROCESS_CODE1;
            PROCESS_NAME1 = pWorkResultRegisterEntity.PROCESS_NAME1;
            WORKCENTER_CODE = pWorkResultRegisterEntity.WORKCENTER_CODE;
            WORKCENTER_NAME = pWorkResultRegisterEntity.WORKCENTER_NAME;       

            ERR_NO = pWorkResultRegisterEntity.ERR_NO;
            ERR_MSG = pWorkResultRegisterEntity.ERR_MSG;
            RTN_KEY = pWorkResultRegisterEntity.RTN_KEY;
            RTN_SEQ = pWorkResultRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pWorkResultRegisterEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }
    public class WorkResultRegister_T01Entity
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
        public String ORDER_FILE { get; set; }
        public String USE_YN { get; set; }
        public String PRODUCTION_ORDER_QTY { get; set; }
        public String PRODUCTION_RESULT_QTY { get; set; }
        

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - WorkResultRegister_T01Entity()

        public WorkResultRegister_T01Entity()
        {
        }

        #endregion

        #region 생성자 - WorkResultRegister_T01Entity(WorkResultRegister_T01Entity pWorkResultRegister_T01Entity)

        public WorkResultRegister_T01Entity(WorkResultRegister_T01Entity pWorkResultRegister_T01Entity)
        {
            CORP_CODE = pWorkResultRegister_T01Entity.CORP_CODE;
            CRUD = pWorkResultRegister_T01Entity.CRUD;
            USER_CODE = pWorkResultRegister_T01Entity.USER_CODE;
            WINDOW_NAME = pWorkResultRegister_T01Entity.WINDOW_NAME;
            LANGUAGE_TYPE = pWorkResultRegister_T01Entity.LANGUAGE_TYPE;

            DATE_FROM = pWorkResultRegister_T01Entity.DATE_FROM;
            DATE_TO = pWorkResultRegister_T01Entity.DATE_TO;
            PRODUCTION_ORDER_ID = pWorkResultRegister_T01Entity.PRODUCTION_ORDER_ID;
            PART_CODE = pWorkResultRegister_T01Entity.PART_CODE;
            PART_NAME = pWorkResultRegister_T01Entity.PART_NAME;
            PRODUCTION_PLAN_ID = pWorkResultRegister_T01Entity.PRODUCTION_PLAN_ID;
            PROCESS_CODE_MST = pWorkResultRegister_T01Entity.PROCESS_CODE_MST;
            PROCESS_CODE = pWorkResultRegister_T01Entity.PROCESS_CODE;
            CODE_GUBN = pWorkResultRegister_T01Entity.CODE_GUBN;
            USE_YN = pWorkResultRegister_T01Entity.USE_YN;

            PRODUCTION_ORDER_QTY = pWorkResultRegister_T01Entity.PRODUCTION_ORDER_QTY;
            PRODUCTION_RESULT_QTY = pWorkResultRegister_T01Entity.PRODUCTION_RESULT_QTY;

            ORDER_FILE = pWorkResultRegister_T01Entity.ORDER_FILE;

            ERR_NO = pWorkResultRegister_T01Entity.ERR_NO;
            ERR_MSG = pWorkResultRegister_T01Entity.ERR_MSG;
            RTN_KEY = pWorkResultRegister_T01Entity.RTN_KEY;
            RTN_SEQ = pWorkResultRegister_T01Entity.RTN_SEQ;
            RTN_OTHERS = pWorkResultRegister_T01Entity.RTN_OTHERS;


            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }
    public class WorkResultRegister_T02Entity
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

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - WorkResultRegister_T02Entity()

        public WorkResultRegister_T02Entity()
        {
        }

        #endregion

        #region 생성자 - WorkResultRegister_T02Entity(WorkResultRegister_T02Entity pWorkResultRegister_T02Entity)

        public WorkResultRegister_T02Entity(WorkResultRegister_T02Entity pWorkResultRegister_T02Entity)
        {
            CORP_CODE = pWorkResultRegister_T02Entity.CORP_CODE;
            CRUD = pWorkResultRegister_T02Entity.CRUD;
            USER_CODE = pWorkResultRegister_T02Entity.USER_CODE;
            WINDOW_NAME = pWorkResultRegister_T02Entity.WINDOW_NAME;
            LANGUAGE_TYPE = pWorkResultRegister_T02Entity.LANGUAGE_TYPE;

            DATE_FROM = pWorkResultRegister_T02Entity.DATE_FROM;
            DATE_TO = pWorkResultRegister_T02Entity.DATE_TO;
            PRODUCTION_ORDER_ID = pWorkResultRegister_T02Entity.PRODUCTION_ORDER_ID;
            PART_CODE = pWorkResultRegister_T02Entity.PART_CODE;
            PART_NAME = pWorkResultRegister_T02Entity.PART_NAME;
            PRODUCTION_PLAN_ID = pWorkResultRegister_T02Entity.PRODUCTION_PLAN_ID;
            PROCESS_CODE_MST = pWorkResultRegister_T02Entity.PROCESS_CODE_MST;
            PROCESS_CODE = pWorkResultRegister_T02Entity.PROCESS_CODE;
            CODE_GUBN = pWorkResultRegister_T02Entity.CODE_GUBN;
            USE_YN = pWorkResultRegister_T02Entity.USE_YN;
            COMPLETE_YN = pWorkResultRegister_T02Entity.COMPLETE_YN;

            ERR_NO = pWorkResultRegister_T02Entity.ERR_NO;
            ERR_MSG = pWorkResultRegister_T02Entity.ERR_MSG;
            RTN_KEY = pWorkResultRegister_T02Entity.RTN_KEY;
            RTN_SEQ = pWorkResultRegister_T02Entity.RTN_SEQ;
            RTN_OTHERS = pWorkResultRegister_T02Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class WorkResultRegister_T03Entity
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
        public String VEND_PART_CODE { get; set; }
        public String LOT_ID { get; set; }
        public String RESOURCE_CODE { get; set; }
        public String COLLECTION_DATE { get; set; }
        public String PROPERTY_VALUE { get; set; }
        public String CONDITION_CODE { get; set; }
        public String COLLECTION_VALUE { get; set; }
        public String COMPLETE_YN { get; set; }
        public String USA_LOT_CHECK { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - WorkResultRegister_T03Entity()

        public WorkResultRegister_T03Entity()
        {
        }

        #endregion

        #region 생성자 - WorkResultRegister_T03Entity(WorkResultRegister_T03Entity pWorkResultRegister_T03Entity)

        public WorkResultRegister_T03Entity(WorkResultRegister_T03Entity pWorkResultRegister_T03Entity)
        {
            CORP_CODE = pWorkResultRegister_T03Entity.CORP_CODE;
            CRUD = pWorkResultRegister_T03Entity.CRUD;
            USER_CODE = pWorkResultRegister_T03Entity.USER_CODE;
            WINDOW_NAME = pWorkResultRegister_T03Entity.WINDOW_NAME;
            LANGUAGE_TYPE = pWorkResultRegister_T03Entity.LANGUAGE_TYPE;

            DATE_FROM = pWorkResultRegister_T03Entity.DATE_FROM;
            DATE_TO = pWorkResultRegister_T03Entity.DATE_TO;
            PRODUCTION_ORDER_ID = pWorkResultRegister_T03Entity.PRODUCTION_ORDER_ID;
            PART_CODE = pWorkResultRegister_T03Entity.PART_CODE;
            PART_NAME = pWorkResultRegister_T03Entity.PART_NAME;
            PRODUCTION_PLAN_ID = pWorkResultRegister_T03Entity.PRODUCTION_PLAN_ID;
            PROCESS_CODE_MST = pWorkResultRegister_T03Entity.PROCESS_CODE_MST;
            PROCESS_CODE = pWorkResultRegister_T03Entity.PROCESS_CODE;
            CODE_GUBN = pWorkResultRegister_T03Entity.CODE_GUBN;
            USE_YN = pWorkResultRegister_T03Entity.USE_YN;
            VEND_PART_CODE = pWorkResultRegister_T03Entity.VEND_PART_CODE;
            LOT_ID = pWorkResultRegister_T03Entity.LOT_ID;
            USA_LOT_CHECK = pWorkResultRegister_T03Entity.USA_LOT_CHECK;

            ERR_NO = pWorkResultRegister_T03Entity.ERR_NO;
            ERR_MSG = pWorkResultRegister_T03Entity.ERR_MSG;
            RTN_KEY = pWorkResultRegister_T03Entity.RTN_KEY;
            RTN_SEQ = pWorkResultRegister_T03Entity.RTN_SEQ;
            RTN_OTHERS = pWorkResultRegister_T03Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }
         
        #endregion
    }

    public class WorkResultRegister_T04Entity
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
        public String VEND_PART_CODE { get; set; }
        public String LOT_ID { get; set; }
        public String RESOURCE_CODE { get; set; }
        public String COLLECTION_DATE { get; set; }
        public String PROPERTY_VALUE { get; set; }
        public String CONDITION_CODE { get; set; }
        public String COLLECTION_VALUE { get; set; }
        public String COMPLETE_YN { get; set; }
        public String USA_LOT_CHECK { get; set; }
        public String PART_HIGH { get; set; }
        public String PART_MIDDLE { get; set; }
        public String PART_LOW { get; set; }
        public String MTC_NO { get; set; }
        public String MATERAL_TRS_NO { get; set; }
        public String ORDER_NUMBER { get; set; }
        public String SPEC_NO_FILENAME { get; set; }
        public String SPEC_NO_TYPE { get; set; }
        public String DRAWING_NO_FILENAME { get; set; }
        public String DRAWING_NO_TYPE { get; set; }
        public String PURCHASE_SPEC_NO_FILENAME { get; set; }
        public String PURCHASE_SPEC_NO_TYPE { get; set; }
        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String RTN_LOT_NO { get; set; }
        public String CONFIGURATION_CODE { get; set; }

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - WorkResultRegister_T04Entity()

        public WorkResultRegister_T04Entity()
        {
        }

        #endregion

        #region 생성자 - WorkResultRegister_T04Entity(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)

        public WorkResultRegister_T04Entity(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)
        {
            CORP_CODE = pWorkResultRegister_T04Entity.CORP_CODE;
            CRUD = pWorkResultRegister_T04Entity.CRUD;
            USER_CODE = pWorkResultRegister_T04Entity.USER_CODE;
            WINDOW_NAME = pWorkResultRegister_T04Entity.WINDOW_NAME;
            LANGUAGE_TYPE = pWorkResultRegister_T04Entity.LANGUAGE_TYPE;

            DATE_FROM = pWorkResultRegister_T04Entity.DATE_FROM;
            DATE_TO = pWorkResultRegister_T04Entity.DATE_TO;
            PRODUCTION_ORDER_ID = pWorkResultRegister_T04Entity.PRODUCTION_ORDER_ID;
            PART_CODE = pWorkResultRegister_T04Entity.PART_CODE;
            PART_NAME = pWorkResultRegister_T04Entity.PART_NAME;
            PRODUCTION_PLAN_ID = pWorkResultRegister_T04Entity.PRODUCTION_PLAN_ID;
            PROCESS_CODE_MST = pWorkResultRegister_T04Entity.PROCESS_CODE_MST;
            PROCESS_CODE = pWorkResultRegister_T04Entity.PROCESS_CODE;
            CODE_GUBN = pWorkResultRegister_T04Entity.CODE_GUBN;
            USE_YN = pWorkResultRegister_T04Entity.USE_YN;
            VEND_PART_CODE = pWorkResultRegister_T04Entity.VEND_PART_CODE;
            LOT_ID = pWorkResultRegister_T04Entity.LOT_ID;
            USA_LOT_CHECK = pWorkResultRegister_T04Entity.USA_LOT_CHECK;
            PART_HIGH = pWorkResultRegister_T04Entity.PART_HIGH;
            PART_MIDDLE = pWorkResultRegister_T04Entity.PART_MIDDLE;
            PART_LOW = pWorkResultRegister_T04Entity.PART_LOW;
            MTC_NO = pWorkResultRegister_T04Entity.MTC_NO;
            MATERAL_TRS_NO = pWorkResultRegister_T04Entity.MATERAL_TRS_NO;
            ORDER_NUMBER = pWorkResultRegister_T04Entity.ORDER_NUMBER;
            SPEC_NO_FILENAME = pWorkResultRegister_T04Entity.SPEC_NO_FILENAME;
            SPEC_NO_TYPE = pWorkResultRegister_T04Entity.SPEC_NO_TYPE;
            DRAWING_NO_FILENAME = pWorkResultRegister_T04Entity.DRAWING_NO_FILENAME;
            DRAWING_NO_TYPE = pWorkResultRegister_T04Entity.DRAWING_NO_TYPE;
            PURCHASE_SPEC_NO_FILENAME = pWorkResultRegister_T04Entity.PURCHASE_SPEC_NO_FILENAME;
            PURCHASE_SPEC_NO_TYPE = pWorkResultRegister_T04Entity.PURCHASE_SPEC_NO_TYPE;
            CONFIGURATION_CODE = pWorkResultRegister_T04Entity.CONFIGURATION_CODE;

            ERR_NO = pWorkResultRegister_T04Entity.ERR_NO;
            ERR_MSG = pWorkResultRegister_T04Entity.ERR_MSG;
            RTN_KEY = pWorkResultRegister_T04Entity.RTN_KEY;
            RTN_SEQ = pWorkResultRegister_T04Entity.RTN_SEQ;
            RTN_OTHERS = pWorkResultRegister_T04Entity.RTN_OTHERS;
            RTN_LOT_NO = pWorkResultRegister_T04Entity.RTN_LOT_NO;

            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class WorkResultRegister_T05Entity
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
        public String VEND_PART_CODE { get; set; }
        public String LOT_ID { get; set; }
        public String RESOURCE_CODE { get; set; }
        public String COLLECTION_DATE { get; set; }
        public String PROPERTY_VALUE { get; set; }
        public String CONDITION_CODE { get; set; }
        public String COLLECTION_VALUE { get; set; }
        public String COMPLETE_YN { get; set; }
        public String USA_LOT_CHECK { get; set; }
        public String PART_HIGH { get; set; }
        public String PART_MIDDLE { get; set; }
        public String PART_LOW { get; set; }
        public String MTC_NO { get; set; }
        public String MATERAL_TRS_NO { get; set; }
        public String ORDER_NUMBER { get; set; }
        public String SPEC_NO_FILENAME { get; set; }
        public String SPEC_NO_TYPE { get; set; }
        public String DRAWING_NO_FILENAME { get; set; }
        public String DRAWING_NO_TYPE { get; set; }
        public String PURCHASE_SPEC_NO_FILENAME { get; set; }
        public String PURCHASE_SPEC_NO_TYPE { get; set; }
        public String CONFIGURATION_CODE { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String RTN_LOT_NO { get; set; }

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - WorkResultRegister_T05Entity()

        public WorkResultRegister_T05Entity()
        {
        }

        #endregion

        #region 생성자 - WorkResultRegister_T05Entity(WorkResultRegister_T05Entity pWorkResultRegister_T05Entity)

        public WorkResultRegister_T05Entity(WorkResultRegister_T05Entity pWorkResultRegister_T05Entity)
        {
            CORP_CODE = pWorkResultRegister_T05Entity.CORP_CODE;
            CRUD = pWorkResultRegister_T05Entity.CRUD;
            USER_CODE = pWorkResultRegister_T05Entity.USER_CODE;
            WINDOW_NAME = pWorkResultRegister_T05Entity.WINDOW_NAME;
            LANGUAGE_TYPE = pWorkResultRegister_T05Entity.LANGUAGE_TYPE;

            DATE_FROM = pWorkResultRegister_T05Entity.DATE_FROM;
            DATE_TO = pWorkResultRegister_T05Entity.DATE_TO;
            PRODUCTION_ORDER_ID = pWorkResultRegister_T05Entity.PRODUCTION_ORDER_ID;
            PART_CODE = pWorkResultRegister_T05Entity.PART_CODE;
            PART_NAME = pWorkResultRegister_T05Entity.PART_NAME;
            PRODUCTION_PLAN_ID = pWorkResultRegister_T05Entity.PRODUCTION_PLAN_ID;
            PROCESS_CODE_MST = pWorkResultRegister_T05Entity.PROCESS_CODE_MST;
            PROCESS_CODE = pWorkResultRegister_T05Entity.PROCESS_CODE;
            CODE_GUBN = pWorkResultRegister_T05Entity.CODE_GUBN;
            USE_YN = pWorkResultRegister_T05Entity.USE_YN;
            VEND_PART_CODE = pWorkResultRegister_T05Entity.VEND_PART_CODE;
            LOT_ID = pWorkResultRegister_T05Entity.LOT_ID;
            USA_LOT_CHECK = pWorkResultRegister_T05Entity.USA_LOT_CHECK;
            PART_HIGH = pWorkResultRegister_T05Entity.PART_HIGH;
            PART_MIDDLE = pWorkResultRegister_T05Entity.PART_MIDDLE;
            PART_LOW = pWorkResultRegister_T05Entity.PART_LOW;
            MTC_NO = pWorkResultRegister_T05Entity.MTC_NO;
            MATERAL_TRS_NO = pWorkResultRegister_T05Entity.MATERAL_TRS_NO;
            ORDER_NUMBER = pWorkResultRegister_T05Entity.ORDER_NUMBER;
            SPEC_NO_FILENAME = pWorkResultRegister_T05Entity.SPEC_NO_FILENAME;
            SPEC_NO_TYPE = pWorkResultRegister_T05Entity.SPEC_NO_TYPE;
            DRAWING_NO_FILENAME = pWorkResultRegister_T05Entity.DRAWING_NO_FILENAME;
            DRAWING_NO_TYPE = pWorkResultRegister_T05Entity.DRAWING_NO_TYPE;
            PURCHASE_SPEC_NO_FILENAME = pWorkResultRegister_T05Entity.PURCHASE_SPEC_NO_FILENAME;
            PURCHASE_SPEC_NO_TYPE = pWorkResultRegister_T05Entity.PURCHASE_SPEC_NO_TYPE;
            CONFIGURATION_CODE = pWorkResultRegister_T05Entity.CONFIGURATION_CODE;

            ERR_NO = pWorkResultRegister_T05Entity.ERR_NO;
            ERR_MSG = pWorkResultRegister_T05Entity.ERR_MSG;
            RTN_KEY = pWorkResultRegister_T05Entity.RTN_KEY;
            RTN_SEQ = pWorkResultRegister_T05Entity.RTN_SEQ;
            RTN_OTHERS = pWorkResultRegister_T05Entity.RTN_OTHERS;
            RTN_LOT_NO = pWorkResultRegister_T05Entity.RTN_LOT_NO;

            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class WorkResultRegister_T06Entity
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
        public String VEND_PART_CODE { get; set; }
        public String LOT_ID { get; set; }
        public String RESOURCE_CODE { get; set; }
        public String COLLECTION_DATE { get; set; }
        public String PROPERTY_VALUE { get; set; }
        public String CONDITION_CODE { get; set; }
        public String COLLECTION_VALUE { get; set; }
        public String COMPLETE_YN { get; set; }
        public String USA_LOT_CHECK { get; set; }
        public String PART_HIGH { get; set; }
        public String PART_MIDDLE { get; set; }
        public String PART_LOW { get; set; }
        public String MTC_NO { get; set; }
        public String MATERAL_TRS_NO { get; set; }
        public String ORDER_NUMBER { get; set; }
        public String SHIPMENT_STATUS { get; set; }
        public String SHIPMENT_ID { get; set; }
        public String REMARK { get; set; }
        public String REFERENCE_ID { get; set; }
        public String SHIPMENT_DATE { get; set; }
        public String SHIPMENT_STANDARD { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String RTN_LOT_NO { get; set; }

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - WorkResultRegister_T06Entity()

        public WorkResultRegister_T06Entity()
        {
        }

        #endregion

        #region 생성자 - WorkResultRegister_T06Entity(WorkResultRegister_T06Entity pWorkResultRegister_T06Entity)

        public WorkResultRegister_T06Entity(WorkResultRegister_T06Entity pWorkResultRegister_T06Entity)
        {
            CORP_CODE = pWorkResultRegister_T06Entity.CORP_CODE;
            CRUD = pWorkResultRegister_T06Entity.CRUD;
            USER_CODE = pWorkResultRegister_T06Entity.USER_CODE;
            WINDOW_NAME = pWorkResultRegister_T06Entity.WINDOW_NAME;
            LANGUAGE_TYPE = pWorkResultRegister_T06Entity.LANGUAGE_TYPE;

            DATE_FROM = pWorkResultRegister_T06Entity.DATE_FROM;
            DATE_TO = pWorkResultRegister_T06Entity.DATE_TO;
            PRODUCTION_ORDER_ID = pWorkResultRegister_T06Entity.PRODUCTION_ORDER_ID;
            PART_CODE = pWorkResultRegister_T06Entity.PART_CODE;
            PART_NAME = pWorkResultRegister_T06Entity.PART_NAME;
            PRODUCTION_PLAN_ID = pWorkResultRegister_T06Entity.PRODUCTION_PLAN_ID;
            PROCESS_CODE_MST = pWorkResultRegister_T06Entity.PROCESS_CODE_MST;
            PROCESS_CODE = pWorkResultRegister_T06Entity.PROCESS_CODE;
            CODE_GUBN = pWorkResultRegister_T06Entity.CODE_GUBN;
            USE_YN = pWorkResultRegister_T06Entity.USE_YN;
            VEND_PART_CODE = pWorkResultRegister_T06Entity.VEND_PART_CODE;
            LOT_ID = pWorkResultRegister_T06Entity.LOT_ID;
            USA_LOT_CHECK = pWorkResultRegister_T06Entity.USA_LOT_CHECK;
            PART_HIGH = pWorkResultRegister_T06Entity.PART_HIGH;
            PART_MIDDLE = pWorkResultRegister_T06Entity.PART_MIDDLE;
            PART_LOW = pWorkResultRegister_T06Entity.PART_LOW;
            MTC_NO = pWorkResultRegister_T06Entity.MTC_NO;
            MATERAL_TRS_NO = pWorkResultRegister_T06Entity.MATERAL_TRS_NO;
            ORDER_NUMBER = pWorkResultRegister_T06Entity.ORDER_NUMBER;
            SHIPMENT_STATUS = pWorkResultRegister_T06Entity.SHIPMENT_STATUS;
            SHIPMENT_ID = pWorkResultRegister_T06Entity.SHIPMENT_ID;
            REMARK = pWorkResultRegister_T06Entity.REMARK;
            REFERENCE_ID = pWorkResultRegister_T06Entity.REFERENCE_ID;
            SHIPMENT_DATE = pWorkResultRegister_T06Entity.SHIPMENT_DATE;
            SHIPMENT_STANDARD = pWorkResultRegister_T06Entity.SHIPMENT_STANDARD;

            ERR_NO = pWorkResultRegister_T06Entity.ERR_NO;
            ERR_MSG = pWorkResultRegister_T06Entity.ERR_MSG;
            RTN_KEY = pWorkResultRegister_T06Entity.RTN_KEY;
            RTN_SEQ = pWorkResultRegister_T06Entity.RTN_SEQ;
            RTN_OTHERS = pWorkResultRegister_T06Entity.RTN_OTHERS;
            RTN_LOT_NO = pWorkResultRegister_T06Entity.RTN_LOT_NO;

            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class WorkResultRegister_T07Entity
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

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - WorkResultRegister_T07Entity()

        public WorkResultRegister_T07Entity()
        {
        }

        #endregion

        #region 생성자 - WorkResultRegister_T07Entity(WorkResultRegister_T07Entity pWorkResultRegister_T07Entity)

        public WorkResultRegister_T07Entity(WorkResultRegister_T07Entity pWorkResultRegister_T07Entity)
        {
            CORP_CODE = pWorkResultRegister_T07Entity.CORP_CODE;
            CRUD = pWorkResultRegister_T07Entity.CRUD;
            USER_CODE = pWorkResultRegister_T07Entity.USER_CODE;
            WINDOW_NAME = pWorkResultRegister_T07Entity.WINDOW_NAME;
            LANGUAGE_TYPE = pWorkResultRegister_T07Entity.LANGUAGE_TYPE;

            DATE_FROM = pWorkResultRegister_T07Entity.DATE_FROM;
            DATE_TO = pWorkResultRegister_T07Entity.DATE_TO;
            PRODUCTION_ORDER_ID = pWorkResultRegister_T07Entity.PRODUCTION_ORDER_ID;
            PART_CODE = pWorkResultRegister_T07Entity.PART_CODE;
            PART_NAME = pWorkResultRegister_T07Entity.PART_NAME;
            PRODUCTION_PLAN_ID = pWorkResultRegister_T07Entity.PRODUCTION_PLAN_ID;
            PROCESS_CODE_MST = pWorkResultRegister_T07Entity.PROCESS_CODE_MST;
            PROCESS_CODE = pWorkResultRegister_T07Entity.PROCESS_CODE;
            CODE_GUBN = pWorkResultRegister_T07Entity.CODE_GUBN;
            USE_YN = pWorkResultRegister_T07Entity.USE_YN;
            COMPLETE_YN = pWorkResultRegister_T07Entity.COMPLETE_YN;

            TERMINAL_CODE = pWorkResultRegister_T07Entity.TERMINAL_CODE;

            ERR_NO = pWorkResultRegister_T07Entity.ERR_NO;
            ERR_MSG = pWorkResultRegister_T07Entity.ERR_MSG;
            RTN_KEY = pWorkResultRegister_T07Entity.RTN_KEY;
            RTN_SEQ = pWorkResultRegister_T07Entity.RTN_SEQ;
            RTN_OTHERS = pWorkResultRegister_T07Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class WorkResultRegister_T08Entity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // _pLANGUAGE_TYPE

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_AQ { get; set; } // 리턴 순번 값
        public String RTN_SQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //메뉴별 추가 엔티티 입력
        public String WINDOW_NAME { get; set; }
        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String VEND_NAME { get; set; }
        public String VEND_CODE { get; set; }
        
        public String WORK_DATE { get; set; }
        public String WORK_QTY { get; set; }

        public String WORK_SEQ { get; set; }

        public String REMARK { get; set; }
        public String DI_TOLERRANCE { get; set; }

        #endregion

        #region 생성자 - WorkResultRegister_T08Entity()

        public WorkResultRegister_T08Entity()
        {
        }

        #endregion

        #region 생성자 - WorkResultRegister_T08Entity(WorkResultRegister_T08Entity pWorkResultRegister_T08Entity)

        public WorkResultRegister_T08Entity(WorkResultRegister_T08Entity pWorkResultRegister_T08Entity)
        {
            CORP_CODE = pWorkResultRegister_T08Entity.CORP_CODE;
            CRUD = pWorkResultRegister_T08Entity.CRUD;
            USER_CODE = pWorkResultRegister_T08Entity.USER_CODE;
            LANGUAGE_TYPE = pWorkResultRegister_T08Entity.LANGUAGE_TYPE;

            ERR_NO = pWorkResultRegister_T08Entity.ERR_NO;
            ERR_MSG = pWorkResultRegister_T08Entity.ERR_MSG;
            RTN_KEY = pWorkResultRegister_T08Entity.RTN_KEY;
            RTN_SEQ = pWorkResultRegister_T08Entity.RTN_SEQ;
            RTN_AQ = pWorkResultRegister_T08Entity.RTN_AQ;
            RTN_SQ = pWorkResultRegister_T08Entity.RTN_SQ;
            RTN_OTHERS = pWorkResultRegister_T08Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            pWorkResultRegister_T08Entity.WINDOW_NAME = WINDOW_NAME;

            pWorkResultRegister_T08Entity.DATE_FROM = DATE_FROM;
            pWorkResultRegister_T08Entity.DATE_TO = DATE_TO;
            pWorkResultRegister_T08Entity.PART_NAME = PART_NAME;
            pWorkResultRegister_T08Entity.PART_CODE = PART_CODE;
            pWorkResultRegister_T08Entity.VEND_NAME = VEND_NAME;
            pWorkResultRegister_T08Entity.VEND_CODE = VEND_CODE;

            pWorkResultRegister_T08Entity.WORK_DATE = WORK_DATE;
            pWorkResultRegister_T08Entity.WORK_QTY = WORK_QTY;

            pWorkResultRegister_T08Entity.WORK_SEQ = WORK_SEQ;

            pWorkResultRegister_T08Entity.REMARK = REMARK;
            pWorkResultRegister_T08Entity.DI_TOLERRANCE = DI_TOLERRANCE;
        }

        #endregion

    }

    public class WorkResultRegister_T09Entity
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
        public String PRODUCTION_SEQ { get; set; }

        public String RESOURCE_CODE { get; set; }
        public String COLLECTION_DATE { get; set; }
        public String PROPERTY_VALUE { get; set; }

       
        public String PROCESS_CODE1 { get; set; }
        public String PROCESS_NAME1 { get; set; }
        public String WORKCENTER_CODE { get; set; }
        public String WORKCENTER_NAME { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - WorkResultRegister_T09Entity()

        public WorkResultRegister_T09Entity()
        {
        }

        #endregion

        #region 생성자 - WorkResultRegister_T09Entity(WorkResultRegister_T09Entity pWorkResultRegister_T09Entity)

        public WorkResultRegister_T09Entity(WorkResultRegister_T09Entity pWorkResultRegister_T09Entity)
        {
            CORP_CODE = pWorkResultRegister_T09Entity.CORP_CODE;
            CRUD = pWorkResultRegister_T09Entity.CRUD;
            USER_CODE = pWorkResultRegister_T09Entity.USER_CODE;
            WINDOW_NAME = pWorkResultRegister_T09Entity.WINDOW_NAME;
            LANGUAGE_TYPE = pWorkResultRegister_T09Entity.LANGUAGE_TYPE;

            DATE_FROM = pWorkResultRegister_T09Entity.DATE_FROM;
            DATE_TO = pWorkResultRegister_T09Entity.DATE_TO;
            PRODUCTION_ORDER_ID = pWorkResultRegister_T09Entity.PRODUCTION_ORDER_ID;
            PART_CODE = pWorkResultRegister_T09Entity.PART_CODE;
            PART_NAME = pWorkResultRegister_T09Entity.PART_NAME;
            PRODUCTION_PLAN_ID = pWorkResultRegister_T09Entity.PRODUCTION_PLAN_ID;
            PROCESS_CODE_MST = pWorkResultRegister_T09Entity.PROCESS_CODE_MST;
            PROCESS_CODE = pWorkResultRegister_T09Entity.PROCESS_CODE;
            CODE_GUBN = pWorkResultRegister_T09Entity.CODE_GUBN;
            USE_YN = pWorkResultRegister_T09Entity.USE_YN;
            COMPLETE_YN = pWorkResultRegister_T09Entity.COMPLETE_YN;

            PROCESS_CODE1 = pWorkResultRegister_T09Entity.PROCESS_CODE1;
            PROCESS_NAME1 = pWorkResultRegister_T09Entity.PROCESS_NAME1;
            WORKCENTER_CODE = pWorkResultRegister_T09Entity.WORKCENTER_CODE;
            WORKCENTER_NAME = pWorkResultRegister_T09Entity.WORKCENTER_NAME;
            PRODUCTION_SEQ = pWorkResultRegister_T09Entity.PRODUCTION_SEQ;
            
            ERR_NO = pWorkResultRegister_T09Entity.ERR_NO;
            ERR_MSG = pWorkResultRegister_T09Entity.ERR_MSG;
            RTN_KEY = pWorkResultRegister_T09Entity.RTN_KEY;
            RTN_SEQ = pWorkResultRegister_T09Entity.RTN_SEQ;
            RTN_OTHERS = pWorkResultRegister_T09Entity.RTN_OTHERS;

            RESOURCE_CODE = pWorkResultRegister_T09Entity.RESOURCE_CODE;
            COLLECTION_DATE = pWorkResultRegister_T09Entity.COLLECTION_DATE;
            PROPERTY_VALUE = pWorkResultRegister_T09Entity.PROPERTY_VALUE;
            
            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class WorkResultRegister_T50Entity
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
        public String PRODUCTION_ORDER_SEQ { get; set; }
        public String PRODUCTION_SEQ { get; set; }
        
        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String PRODUCTION_PLAN_ID { get; set; }
        public String PROCESS_CODE_MST { get; set; }
        public String PROCESS_CODE { get; set; }
        public String CODE_GUBN { get; set; }
        public String USE_YN { get; set; }
        public String COMPLETE_YN { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - WorkResultRegister_T50Entity()

        public WorkResultRegister_T50Entity()
        {
        }

        #endregion

        #region 생성자 - WorkResultRegister_T50Entity(WorkResultRegister_T50Entity pWorkResultRegister_T50Entity)

        public WorkResultRegister_T50Entity(WorkResultRegister_T50Entity pWorkResultRegister_T50Entity)
        {
            CORP_CODE = pWorkResultRegister_T50Entity.CORP_CODE;
            CRUD = pWorkResultRegister_T50Entity.CRUD;
            USER_CODE = pWorkResultRegister_T50Entity.USER_CODE;
            WINDOW_NAME = pWorkResultRegister_T50Entity.WINDOW_NAME;
            LANGUAGE_TYPE = pWorkResultRegister_T50Entity.LANGUAGE_TYPE;


            PRODUCTION_SEQ = pWorkResultRegister_T50Entity.PRODUCTION_SEQ;
            DATE_FROM = pWorkResultRegister_T50Entity.DATE_FROM;
            DATE_TO = pWorkResultRegister_T50Entity.DATE_TO;
            PRODUCTION_ORDER_ID = pWorkResultRegister_T50Entity.PRODUCTION_ORDER_ID;
            PRODUCTION_ORDER_SEQ = pWorkResultRegister_T50Entity.PRODUCTION_ORDER_SEQ;
            PART_CODE = pWorkResultRegister_T50Entity.PART_CODE;
            PART_NAME = pWorkResultRegister_T50Entity.PART_NAME;
            PRODUCTION_PLAN_ID = pWorkResultRegister_T50Entity.PRODUCTION_PLAN_ID;
            PROCESS_CODE_MST = pWorkResultRegister_T50Entity.PROCESS_CODE_MST;
            PROCESS_CODE = pWorkResultRegister_T50Entity.PROCESS_CODE;
            CODE_GUBN = pWorkResultRegister_T50Entity.CODE_GUBN;
            USE_YN = pWorkResultRegister_T50Entity.USE_YN;
            COMPLETE_YN = pWorkResultRegister_T50Entity.COMPLETE_YN;

            ERR_NO = pWorkResultRegister_T50Entity.ERR_NO;
            ERR_MSG = pWorkResultRegister_T50Entity.ERR_MSG;
            RTN_KEY = pWorkResultRegister_T50Entity.RTN_KEY;
            RTN_SEQ = pWorkResultRegister_T50Entity.RTN_SEQ;
            RTN_OTHERS = pWorkResultRegister_T50Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }


    public class Scheduling_T50Entity
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
        public String PART_NAME { get; set; }
        public String VEND_CODE { get; set; }
        public String VEND_NAME { get; set; }
        public String ORDER_ID { get; set; }
        public String ORDER_SEQ { get; set; }
        public String process_code_mst { get; set; }
        public String process_code { get; set; }
        public String order_date { get; set; }
        public String equipment_code { get; set; }
        public int USER_SEQ { get; set; }
        public string EQUIPMENT_MST_CODE { get; set; }



        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - Scheduling_T50Entity()

        public Scheduling_T50Entity()
        {
        }

        #endregion

        #region 생성자 - Scheduling_T50Entity(pScheduling_T50Entity)

        public Scheduling_T50Entity(Scheduling_T50Entity pScheduling_T50Entity)
        {
            CORP_CODE = pScheduling_T50Entity.CORP_CODE;
            CRUD = pScheduling_T50Entity.CRUD;
            USER_CODE = pScheduling_T50Entity.USER_CODE;
            LANGUAGE_TYPE = pScheduling_T50Entity.LANGUAGE_TYPE;

            pScheduling_T50Entity.DATE_FROM = DATE_FROM;
            pScheduling_T50Entity.DATE_TO = DATE_TO;
            pScheduling_T50Entity.PART_NAME = PART_NAME;
            pScheduling_T50Entity.VEND_NAME = VEND_NAME;
            pScheduling_T50Entity.ORDER_ID = ORDER_ID;
            pScheduling_T50Entity.ORDER_SEQ = ORDER_SEQ;
            pScheduling_T50Entity.process_code_mst = process_code_mst;
            pScheduling_T50Entity.process_code = process_code;
            pScheduling_T50Entity.order_date = order_date;
            pScheduling_T50Entity.equipment_code = equipment_code;
            pScheduling_T50Entity.USER_SEQ = USER_SEQ;
            pScheduling_T50Entity.EQUIPMENT_MST_CODE = EQUIPMENT_MST_CODE;

            ERR_NO = pScheduling_T50Entity.ERR_NO;
            ERR_MSG = pScheduling_T50Entity.ERR_MSG;
            RTN_KEY = pScheduling_T50Entity.RTN_KEY;
            RTN_SEQ = pScheduling_T50Entity.RTN_SEQ;
            RTN_OTHERS = pScheduling_T50Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ucShipmentInfoPopupEntity
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
        public String VEND_PART_CODE { get; set; }
        public String LOT_ID { get; set; }
        public String LOT_NO { get; set; }
        public String RESOURCE_CODE { get; set; }
        public String COLLECTION_DATE { get; set; }
        public String PROPERTY_VALUE { get; set; }
        public String CONDITION_CODE { get; set; }
        public String COLLECTION_VALUE { get; set; }
        public String COMPLETE_YN { get; set; }
        public String USA_LOT_CHECK { get; set; }
        public String PART_HIGH { get; set; }
        public String PART_MIDDLE { get; set; }
        public String PART_LOW { get; set; }
        public String MTC_NO { get; set; }
        public String MATERAL_TRS_NO { get; set; }
        public String ORDER_NUMBER { get; set; }
        public String SHIPMENT_STATUS { get; set; }
        public String SHIPMENT_ID { get; set; }
        public String REMARK { get; set; }
        public String REFERENCE_ID { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String RTN_LOT_NO { get; set; }

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - ucShipmentInfoPopupEntity()

        public ucShipmentInfoPopupEntity()
        {
        }

        #endregion

        #region 생성자 - ucShipmentInfoPopupEntity(ucShipmentInfoPopupEntity pucShipmentInfoPopupEntity)

        public ucShipmentInfoPopupEntity(ucShipmentInfoPopupEntity pucShipmentInfoPopupEntity)
        {
            CORP_CODE = pucShipmentInfoPopupEntity.CORP_CODE;
            CRUD = pucShipmentInfoPopupEntity.CRUD;
            USER_CODE = pucShipmentInfoPopupEntity.USER_CODE;
            WINDOW_NAME = pucShipmentInfoPopupEntity.WINDOW_NAME;
            LANGUAGE_TYPE = pucShipmentInfoPopupEntity.LANGUAGE_TYPE;

            DATE_FROM = pucShipmentInfoPopupEntity.DATE_FROM;
            DATE_TO = pucShipmentInfoPopupEntity.DATE_TO;
            PRODUCTION_ORDER_ID = pucShipmentInfoPopupEntity.PRODUCTION_ORDER_ID;
            PART_CODE = pucShipmentInfoPopupEntity.PART_CODE;
            PART_NAME = pucShipmentInfoPopupEntity.PART_NAME;
            PRODUCTION_PLAN_ID = pucShipmentInfoPopupEntity.PRODUCTION_PLAN_ID;
            PROCESS_CODE_MST = pucShipmentInfoPopupEntity.PROCESS_CODE_MST;
            PROCESS_CODE = pucShipmentInfoPopupEntity.PROCESS_CODE;
            CODE_GUBN = pucShipmentInfoPopupEntity.CODE_GUBN;
            USE_YN = pucShipmentInfoPopupEntity.USE_YN;
            VEND_PART_CODE = pucShipmentInfoPopupEntity.VEND_PART_CODE;
            LOT_ID = pucShipmentInfoPopupEntity.LOT_ID;
            LOT_NO = pucShipmentInfoPopupEntity.LOT_NO;
            USA_LOT_CHECK = pucShipmentInfoPopupEntity.USA_LOT_CHECK;
            PART_HIGH = pucShipmentInfoPopupEntity.PART_HIGH;
            PART_MIDDLE = pucShipmentInfoPopupEntity.PART_MIDDLE;
            PART_LOW = pucShipmentInfoPopupEntity.PART_LOW;
            MTC_NO = pucShipmentInfoPopupEntity.MTC_NO;
            MATERAL_TRS_NO = pucShipmentInfoPopupEntity.MATERAL_TRS_NO;
            ORDER_NUMBER = pucShipmentInfoPopupEntity.ORDER_NUMBER;
            SHIPMENT_STATUS = pucShipmentInfoPopupEntity.SHIPMENT_STATUS;
            SHIPMENT_ID = pucShipmentInfoPopupEntity.SHIPMENT_ID;
            REMARK = pucShipmentInfoPopupEntity.REMARK;
            REFERENCE_ID = pucShipmentInfoPopupEntity.REFERENCE_ID;

            ERR_NO = pucShipmentInfoPopupEntity.ERR_NO;
            ERR_MSG = pucShipmentInfoPopupEntity.ERR_MSG;
            RTN_KEY = pucShipmentInfoPopupEntity.RTN_KEY;
            RTN_SEQ = pucShipmentInfoPopupEntity.RTN_SEQ;
            RTN_OTHERS = pucShipmentInfoPopupEntity.RTN_OTHERS;
            RTN_LOT_NO = pucShipmentInfoPopupEntity.RTN_LOT_NO;

            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class ucProductionOrderInfoPopup_T04_Entity
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
        public String PRODUCTION_ORDER_ID { get; set; }

        #endregion

        #region 생성자 - ucProductionOrderInfoPopup_T04_Entity()

        public ucProductionOrderInfoPopup_T04_Entity()
        {
        }

        #endregion

        #region 생성자 - ucProductionOrderInfoPopup_T04_Entity(ucProductionOrderInfoPopup_T04_Entity pucProductionOrderInfoPopup_T04_Entity)

        public ucProductionOrderInfoPopup_T04_Entity(ucProductionOrderInfoPopup_T04_Entity pucProductionOrderInfoPopup_T04_Entity)
        {
            CORP_CODE = pucProductionOrderInfoPopup_T04_Entity.CORP_CODE;
            CRUD = pucProductionOrderInfoPopup_T04_Entity.CRUD;
            USER_CODE = pucProductionOrderInfoPopup_T04_Entity.USER_CODE;
            LANGUAGE_TYPE = pucProductionOrderInfoPopup_T04_Entity.LANGUAGE_TYPE;

            ERR_NO = pucProductionOrderInfoPopup_T04_Entity.ERR_NO;
            ERR_MSG = pucProductionOrderInfoPopup_T04_Entity.ERR_MSG;
            RTN_KEY = pucProductionOrderInfoPopup_T04_Entity.RTN_KEY;
            RTN_SEQ = pucProductionOrderInfoPopup_T04_Entity.RTN_SEQ;
            RTN_AQ = pucProductionOrderInfoPopup_T04_Entity.RTN_AQ;
            RTN_SQ = pucProductionOrderInfoPopup_T04_Entity.RTN_SQ;
            RTN_OTHERS = pucProductionOrderInfoPopup_T04_Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            DATE_FROM = pucProductionOrderInfoPopup_T04_Entity.DATE_FROM;
            DATE_TO = pucProductionOrderInfoPopup_T04_Entity.DATE_TO;
            PART_CODE = pucProductionOrderInfoPopup_T04_Entity.PART_CODE;
            PART_NAME = pucProductionOrderInfoPopup_T04_Entity.PART_NAME;
            VEND_CODE = pucProductionOrderInfoPopup_T04_Entity.VEND_CODE;
            VEND_NAME = pucProductionOrderInfoPopup_T04_Entity.VEND_NAME;
            PRODUCTION_ORDER_ID = pucProductionOrderInfoPopup_T04_Entity.PRODUCTION_ORDER_ID;

        }

        #endregion
    }

    public class ucProductionOrderInfoPopup_T07_Entity
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
        public String PRODUCTION_ORDER_ID { get; set; }
        public String CONTRACT_NUMBER { get; set; }
        public String ORDER_NUMBER { get; set; }

        #endregion

        #region 생성자 - ucProductionOrderInfoPopup_T07_Entity()

        public ucProductionOrderInfoPopup_T07_Entity()
        {
        }

        #endregion

        #region 생성자 - ucProductionOrderInfoPopup_T07_Entity(ucProductionOrderInfoPopup_T07_Entity pucProductionOrderInfoPopup_T07_Entity)

        public ucProductionOrderInfoPopup_T07_Entity(ucProductionOrderInfoPopup_T07_Entity pucProductionOrderInfoPopup_T07_Entity)
        {
            CORP_CODE = pucProductionOrderInfoPopup_T07_Entity.CORP_CODE;
            CRUD = pucProductionOrderInfoPopup_T07_Entity.CRUD;
            USER_CODE = pucProductionOrderInfoPopup_T07_Entity.USER_CODE;
            LANGUAGE_TYPE = pucProductionOrderInfoPopup_T07_Entity.LANGUAGE_TYPE;

            ERR_NO = pucProductionOrderInfoPopup_T07_Entity.ERR_NO;
            ERR_MSG = pucProductionOrderInfoPopup_T07_Entity.ERR_MSG;
            RTN_KEY = pucProductionOrderInfoPopup_T07_Entity.RTN_KEY;
            RTN_SEQ = pucProductionOrderInfoPopup_T07_Entity.RTN_SEQ;
            RTN_AQ = pucProductionOrderInfoPopup_T07_Entity.RTN_AQ;
            RTN_SQ = pucProductionOrderInfoPopup_T07_Entity.RTN_SQ;
            RTN_OTHERS = pucProductionOrderInfoPopup_T07_Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            DATE_FROM = pucProductionOrderInfoPopup_T07_Entity.DATE_FROM;
            DATE_TO = pucProductionOrderInfoPopup_T07_Entity.DATE_TO;
            PART_CODE = pucProductionOrderInfoPopup_T07_Entity.PART_CODE;
            PART_NAME = pucProductionOrderInfoPopup_T07_Entity.PART_NAME;
            VEND_CODE = pucProductionOrderInfoPopup_T07_Entity.VEND_CODE;
            VEND_NAME = pucProductionOrderInfoPopup_T07_Entity.VEND_NAME;
            PRODUCTION_ORDER_ID = pucProductionOrderInfoPopup_T07_Entity.PRODUCTION_ORDER_ID;

        }

        #endregion
    }


    public class ucWorkOrderInfoPopup_T01Entity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE

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

        public String WINDOW_NAME { get; set; }
        public String FILE_NAME { get; set; }

        


        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - ucWorkOrderInfoPopup_T01Entity()

        public ucWorkOrderInfoPopup_T01Entity()
        {
        }

        #endregion

        #region 생성자 - ucWorkOrderInfoPopup_T01Entity(pucWorkOrderInfoPopup_T01Entity)

        public ucWorkOrderInfoPopup_T01Entity(ucWorkOrderInfoPopup_T01Entity pucWorkOrderInfoPopup_T01Entity)
        {
            CORP_CODE = pucWorkOrderInfoPopup_T01Entity.CORP_CODE;
            CRUD = pucWorkOrderInfoPopup_T01Entity.CRUD;
            USER_CODE = pucWorkOrderInfoPopup_T01Entity.USER_CODE;
            LANGUAGE_TYPE = pucWorkOrderInfoPopup_T01Entity.LANGUAGE_TYPE;
            WINDOW_NAME = pucWorkOrderInfoPopup_T01Entity.WINDOW_NAME;


            PART_CODE_MST = pucWorkOrderInfoPopup_T01Entity.PART_CODE_MST;
            WORKORDER_ID = pucWorkOrderInfoPopup_T01Entity.WORKORDER_ID;
            REFERENCE_ID = pucWorkOrderInfoPopup_T01Entity.REFERENCE_ID;

            ERR_NO = pucWorkOrderInfoPopup_T01Entity.ERR_NO;
            ERR_MSG = pucWorkOrderInfoPopup_T01Entity.ERR_MSG;
            RTN_KEY = pucWorkOrderInfoPopup_T01Entity.RTN_KEY;
            RTN_SEQ = pucWorkOrderInfoPopup_T01Entity.RTN_SEQ;
            RTN_AQ = pucWorkOrderInfoPopup_T01Entity.RTN_AQ;
            RTN_SQ = pucWorkOrderInfoPopup_T01Entity.RTN_SQ;
            RTN_OTHERS = pucWorkOrderInfoPopup_T01Entity.RTN_OTHERS;

            FILE_NAME = pucWorkOrderInfoPopup_T01Entity.FILE_NAME;

            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class ucWorkOrderInfoPopup_T03Entity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE

        public String PART_CODE_MST { get; set; }
        public String WORKORDER_ID { get; set; }
        public String REFERENCE_ID { get; set; }
        public String ORDER_NUMBER { get; set; }
        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_AQ { get; set; } // 리턴 순번 값
        public String RTN_SQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String RTN_DATE { get; set; }

        public String WINDOW_NAME { get; set; }
        public String FILE_NAME { get; set; }




        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - ucWorkOrderInfoPopup_T03Entity()

        public ucWorkOrderInfoPopup_T03Entity()
        {
        }

        #endregion

        #region 생성자 - ucWorkOrderInfoPopup_T03Entity(ucWorkOrderInfoPopup_T03Entity pucWorkOrderInfoPopup_T03Entity)

        public ucWorkOrderInfoPopup_T03Entity(ucWorkOrderInfoPopup_T03Entity pucWorkOrderInfoPopup_T03Entity)
        {
            CORP_CODE = pucWorkOrderInfoPopup_T03Entity.CORP_CODE;
            CRUD = pucWorkOrderInfoPopup_T03Entity.CRUD;
            USER_CODE = pucWorkOrderInfoPopup_T03Entity.USER_CODE;
            LANGUAGE_TYPE = pucWorkOrderInfoPopup_T03Entity.LANGUAGE_TYPE;
            WINDOW_NAME = pucWorkOrderInfoPopup_T03Entity.WINDOW_NAME;


            PART_CODE_MST = pucWorkOrderInfoPopup_T03Entity.PART_CODE_MST;
            WORKORDER_ID = pucWorkOrderInfoPopup_T03Entity.WORKORDER_ID;
            REFERENCE_ID = pucWorkOrderInfoPopup_T03Entity.REFERENCE_ID;
            ORDER_NUMBER = pucWorkOrderInfoPopup_T03Entity.ORDER_NUMBER;
            

            ERR_NO = pucWorkOrderInfoPopup_T03Entity.ERR_NO;
            ERR_MSG = pucWorkOrderInfoPopup_T03Entity.ERR_MSG;
            RTN_KEY = pucWorkOrderInfoPopup_T03Entity.RTN_KEY;
            RTN_SEQ = pucWorkOrderInfoPopup_T03Entity.RTN_SEQ;
            RTN_AQ = pucWorkOrderInfoPopup_T03Entity.RTN_AQ;
            RTN_SQ = pucWorkOrderInfoPopup_T03Entity.RTN_SQ;
            RTN_OTHERS = pucWorkOrderInfoPopup_T03Entity.RTN_OTHERS;
            RTN_DATE = pucWorkOrderInfoPopup_T03Entity.RTN_DATE;

            FILE_NAME = pucWorkOrderInfoPopup_T03Entity.FILE_NAME;

            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class ucMeterialUsagePopupEntity
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
        public String RTN_AQ { get; set; } // 리턴 순번 값
        public String RTN_SQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String RTN_DATE { get; set; }

        public String WINDOW_NAME { get; set; }

        public String MATSTOCK_ID { get; set; }
        public String MATSTOCK_DETAIL_SEQ { get; set; }
        public String PART_CODE { get; set; }
        public String VEND_PART_CODE { get; set; }
        public String PART_REVISION_NO { get; set; }
        public String PART_NAME { get; set; }
        public String PART_HIGH { get; set; }
        public String PART_MIDDLE { get; set; }
        public String PART_LOW { get; set; }
        public String PRODUCTINO_ORDER_ID { get; set; }
        public String LOT_ID { get; set; }
        public String PART_LOT_ID { get; set; }
        public String PROCESS_CODE { get; set; }
        public String USAGE_DATE { get; set; }
        public String USAGE_QTY { get; set; }
        public String WORKING_QTY { get; set; }


        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - ucWorkOrderInfoPopup_T03Entity()

        public ucMeterialUsagePopupEntity()
        {
        }

        #endregion


        #region 생성자 - ucMeterialUsagePopupEntity(ucMeterialUsagePopupEntity pucMeterialUsagePopupEntity)

        public ucMeterialUsagePopupEntity(ucMeterialUsagePopupEntity pucMeterialUsagePopupEntity)
        {
            CORP_CODE = pucMeterialUsagePopupEntity.CORP_CODE;
            CRUD = pucMeterialUsagePopupEntity.CRUD;
            USER_CODE = pucMeterialUsagePopupEntity.USER_CODE;
            LANGUAGE_TYPE = pucMeterialUsagePopupEntity.LANGUAGE_TYPE;
            WINDOW_NAME = pucMeterialUsagePopupEntity.WINDOW_NAME;


            ERR_NO = pucMeterialUsagePopupEntity.ERR_NO;
            ERR_MSG = pucMeterialUsagePopupEntity.ERR_MSG;
            RTN_KEY = pucMeterialUsagePopupEntity.RTN_KEY;
            RTN_SEQ = pucMeterialUsagePopupEntity.RTN_SEQ;
            RTN_AQ = pucMeterialUsagePopupEntity.RTN_AQ;
            RTN_SQ = pucMeterialUsagePopupEntity.RTN_SQ;
            RTN_OTHERS = pucMeterialUsagePopupEntity.RTN_OTHERS;
            RTN_DATE = pucMeterialUsagePopupEntity.RTN_DATE;

            //메뉴별 추가 엔티티 입력
            pucMeterialUsagePopupEntity.MATSTOCK_ID = MATSTOCK_ID;
            pucMeterialUsagePopupEntity.MATSTOCK_DETAIL_SEQ = MATSTOCK_DETAIL_SEQ;
            pucMeterialUsagePopupEntity.PART_CODE = PART_CODE;
            pucMeterialUsagePopupEntity.VEND_PART_CODE = VEND_PART_CODE;
            pucMeterialUsagePopupEntity.PART_REVISION_NO = PART_REVISION_NO;
            pucMeterialUsagePopupEntity.PART_NAME = PART_NAME;
            pucMeterialUsagePopupEntity.PART_HIGH = PART_HIGH;
            pucMeterialUsagePopupEntity.PART_MIDDLE = PART_MIDDLE;
            pucMeterialUsagePopupEntity.PART_LOW = PART_LOW;
            pucMeterialUsagePopupEntity.PRODUCTINO_ORDER_ID = PRODUCTINO_ORDER_ID;
            pucMeterialUsagePopupEntity.LOT_ID = LOT_ID;
            pucMeterialUsagePopupEntity.PART_LOT_ID = PART_LOT_ID;
            pucMeterialUsagePopupEntity.PROCESS_CODE = PROCESS_CODE;
            pucMeterialUsagePopupEntity.USAGE_DATE = USAGE_DATE;
            pucMeterialUsagePopupEntity.USAGE_QTY = USAGE_QTY;
            pucMeterialUsagePopupEntity.WORKING_QTY = WORKING_QTY;
        }

        #endregion
    }


    public class ucOrderNumberInfoPopup_Entity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE

        public String PART_CODE_MST { get; set; }
        public String WORKORDER_ID { get; set; }
        public String REFERENCE_ID { get; set; }
        public String CONTRACT_NUMBER { get; set; }
        public String VEND_CODE { get; set; }
        public String CONTRACT_ID { get; set; }
        public String PRODUCTION_PLAN_ID { get; set; }
        public String ORDER_NUMBER { get; set; }
        public String ORDER_SEQ { get; set; }
        public String PRODUCTION_PLAN_DATE { get; set; }
        public String PRODUCTION_PLAN_SEQ { get; set; }
        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_AQ { get; set; } // 리턴 순번 값
        public String RTN_SQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        public String WINDOW_NAME { get; set; }
        public String FILE_NAME { get; set; }




        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - ucOrderNumberInfoPopup_Entity()

        public ucOrderNumberInfoPopup_Entity()
        {
        }

        #endregion

        #region 생성자 - ucOrderNumberInfoPopup_Entity(pucWorkOrderInfoPopup_Entity)

        public ucOrderNumberInfoPopup_Entity(ucOrderNumberInfoPopup_Entity pucWorkOrderInfoPopup_T01Entity)
        {
            CORP_CODE = pucWorkOrderInfoPopup_T01Entity.CORP_CODE;
            CRUD = pucWorkOrderInfoPopup_T01Entity.CRUD;
            USER_CODE = pucWorkOrderInfoPopup_T01Entity.USER_CODE;
            LANGUAGE_TYPE = pucWorkOrderInfoPopup_T01Entity.LANGUAGE_TYPE;
            WINDOW_NAME = pucWorkOrderInfoPopup_T01Entity.WINDOW_NAME;


            PART_CODE_MST = pucWorkOrderInfoPopup_T01Entity.PART_CODE_MST;
            WORKORDER_ID = pucWorkOrderInfoPopup_T01Entity.WORKORDER_ID;
            REFERENCE_ID = pucWorkOrderInfoPopup_T01Entity.REFERENCE_ID;
            VEND_CODE = pucWorkOrderInfoPopup_T01Entity.VEND_CODE;
            CONTRACT_NUMBER = pucWorkOrderInfoPopup_T01Entity.CONTRACT_NUMBER;
            CONTRACT_ID = pucWorkOrderInfoPopup_T01Entity.CONTRACT_ID;

            pucWorkOrderInfoPopup_T01Entity.PRODUCTION_PLAN_ID = PRODUCTION_PLAN_ID;
            pucWorkOrderInfoPopup_T01Entity.ORDER_NUMBER = ORDER_NUMBER;
            pucWorkOrderInfoPopup_T01Entity.ORDER_SEQ = ORDER_SEQ;
            pucWorkOrderInfoPopup_T01Entity.PRODUCTION_PLAN_DATE = PRODUCTION_PLAN_DATE;
            pucWorkOrderInfoPopup_T01Entity.PRODUCTION_PLAN_SEQ = PRODUCTION_PLAN_SEQ;
            
            ERR_NO = pucWorkOrderInfoPopup_T01Entity.ERR_NO;
            ERR_MSG = pucWorkOrderInfoPopup_T01Entity.ERR_MSG;
            RTN_KEY = pucWorkOrderInfoPopup_T01Entity.RTN_KEY;
            RTN_SEQ = pucWorkOrderInfoPopup_T01Entity.RTN_SEQ;
            RTN_AQ = pucWorkOrderInfoPopup_T01Entity.RTN_AQ;
            RTN_SQ = pucWorkOrderInfoPopup_T01Entity.RTN_SQ;
            RTN_OTHERS = pucWorkOrderInfoPopup_T01Entity.RTN_OTHERS;

            FILE_NAME = pucWorkOrderInfoPopup_T01Entity.FILE_NAME;

            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }


    public class ProductResultHistoryEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE


        //마스터
        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String PROCESS_CODE { get; set; }
        public String PROCESS_NAME { get; set; }
        public String ORDER_ID { get; set; }
        public String LOT_NO { get; set; }
        public String REMARK { get; set; }

        //고정 엔티티

        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }

        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - ProductResultHistoryEntity()

        public ProductResultHistoryEntity()
        {
        }

        #endregion

        #region 생성자 - ProductResultHistoryEntity(pProductResultHistoryEntity)

        public ProductResultHistoryEntity(ProductResultHistoryEntity pProductResultHistoryEntity)
        {
            CORP_CODE = pProductResultHistoryEntity.CORP_CODE;
            CRUD = pProductResultHistoryEntity.CRUD;

            DATE_FROM = pProductResultHistoryEntity.DATE_FROM;
            DATE_TO = pProductResultHistoryEntity.DATE_TO;
            PART_CODE = pProductResultHistoryEntity.PART_CODE;
            PART_NAME = pProductResultHistoryEntity.PART_NAME;
            PROCESS_CODE = pProductResultHistoryEntity.PROCESS_CODE;
            PROCESS_NAME = pProductResultHistoryEntity.PROCESS_NAME;
            ORDER_ID = pProductResultHistoryEntity.ORDER_ID;
            LOT_NO = pProductResultHistoryEntity.LOT_NO;
            REMARK = pProductResultHistoryEntity.REMARK;
            LANGUAGE_TYPE = pProductResultHistoryEntity.LANGUAGE_TYPE;

            ERR_NO = pProductResultHistoryEntity.ERR_NO;
            ERR_MSG = pProductResultHistoryEntity.ERR_MSG;
            RTN_KEY = pProductResultHistoryEntity.RTN_KEY;
            RTN_SEQ = pProductResultHistoryEntity.RTN_SEQ;
            RTN_OTHERS = pProductResultHistoryEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ProductGoalMonthEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE

        //마스터
        public String GOAL_TYPE { get; set; }
        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        public String ORDER_ID { get; set; }
        public String LOT_NO { get; set; }
        public String REMARK { get; set; }

        //고정 엔티티

        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }

        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - ProductGoalMonthEntity()

        public ProductGoalMonthEntity()
        {
        }

        #endregion

        #region 생성자 - ProductGoalMonthEntity(pProductGoalMonthEntity)

        public ProductGoalMonthEntity(ProductGoalMonthEntity pProductGoalMonthEntity)
        {
            CORP_CODE = pProductGoalMonthEntity.CORP_CODE;
            CRUD = pProductGoalMonthEntity.CRUD;

            DATE_FROM = pProductGoalMonthEntity.DATE_FROM;
            DATE_TO = pProductGoalMonthEntity.DATE_TO;
            ORDER_ID = pProductGoalMonthEntity.ORDER_ID;
            LOT_NO = pProductGoalMonthEntity.LOT_NO;
            REMARK = pProductGoalMonthEntity.REMARK;
            LANGUAGE_TYPE = pProductGoalMonthEntity.LANGUAGE_TYPE;
            GOAL_TYPE = pProductGoalMonthEntity.GOAL_TYPE;
            ERR_NO = pProductGoalMonthEntity.ERR_NO;
            ERR_MSG = pProductGoalMonthEntity.ERR_MSG;
            RTN_KEY = pProductGoalMonthEntity.RTN_KEY;
            RTN_SEQ = pProductGoalMonthEntity.RTN_SEQ;
            RTN_OTHERS = pProductGoalMonthEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }


    public class ucWorkResultPopUp_T01_Entity
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

        public String BOM_CNT { get; set; }

        public String PART_CODE { get; set; }
        public String PRODUCTION_ORDER_ID { get; set; }
        public String COMPLETE_YN { get; set; }

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


        #endregion

        #region 생성자 - ucWorkResultPopUp_T01_Entity()

        public ucWorkResultPopUp_T01_Entity()
        {
        }

        #endregion

        #region 생성자 - ucWorkResultPopUp_T01_Entity(ucWorkResultPopUp_T01_Entity pucWorkResultPopUp_T01_Entity)

        public ucWorkResultPopUp_T01_Entity(ucWorkResultPopUp_T01_Entity pucWorkResultPopUp_T01_Entity)
        {
            CORP_CODE = pucWorkResultPopUp_T01_Entity.CORP_CODE;
            CRUD = pucWorkResultPopUp_T01_Entity.CRUD;
            USER_CODE = pucWorkResultPopUp_T01_Entity.USER_CODE;
            LANGUAGE_TYPE = pucWorkResultPopUp_T01_Entity.LANGUAGE_TYPE;

            ERR_NO = pucWorkResultPopUp_T01_Entity.ERR_NO;
            ERR_MSG = pucWorkResultPopUp_T01_Entity.ERR_MSG;
            RTN_KEY = pucWorkResultPopUp_T01_Entity.RTN_KEY;
            RTN_SEQ = pucWorkResultPopUp_T01_Entity.RTN_SEQ;
            RTN_AQ = pucWorkResultPopUp_T01_Entity.RTN_AQ;
            RTN_SQ = pucWorkResultPopUp_T01_Entity.RTN_SQ;
            RTN_OTHERS = pucWorkResultPopUp_T01_Entity.RTN_OTHERS;

            RESOURCE_CODE = pucWorkResultPopUp_T01_Entity.RESOURCE_CODE;
            COLLECTION_DATE = pucWorkResultPopUp_T01_Entity.COLLECTION_DATE;
            PROPERTY_VALUE = pucWorkResultPopUp_T01_Entity.PROPERTY_VALUE;
            CONDITION_CODE = pucWorkResultPopUp_T01_Entity.CONDITION_CODE;
            COLLECTION_VALUE = pucWorkResultPopUp_T01_Entity.COLLECTION_VALUE;

            BOM_CNT = pucWorkResultPopUp_T01_Entity.BOM_CNT;

            PRODUCTION_ORDER_ID = pucWorkResultPopUp_T01_Entity.PRODUCTION_ORDER_ID;
            COMPLETE_YN = pucWorkResultPopUp_T01_Entity.COMPLETE_YN;

            INOUT_ID = pucWorkResultPopUp_T01_Entity.INOUT_ID;
            INOUT_DATE = pucWorkResultPopUp_T01_Entity.INOUT_DATE;
            INOUT_SEQ = pucWorkResultPopUp_T01_Entity.INOUT_SEQ;
            INOUT_TYPE = pucWorkResultPopUp_T01_Entity.INOUT_TYPE;
            REFERENCE_ID = pucWorkResultPopUp_T01_Entity.REFERENCE_ID;
            PART_CODE = pucWorkResultPopUp_T01_Entity.PART_CODE;
            PART_NAME = pucWorkResultPopUp_T01_Entity.PART_NAME;
            VEND_CODE = pucWorkResultPopUp_T01_Entity.VEND_CODE;
            VEND_NAME = pucWorkResultPopUp_T01_Entity.VEND_NAME;
            INOUT_QTY = pucWorkResultPopUp_T01_Entity.INOUT_QTY;
            PART_UNIT = pucWorkResultPopUp_T01_Entity.PART_UNIT;
            UNITCOST = pucWorkResultPopUp_T01_Entity.UNITCOST;
            COST = pucWorkResultPopUp_T01_Entity.COST;
            REMARK = pucWorkResultPopUp_T01_Entity.REMARK;
            INOUT_CODE = pucWorkResultPopUp_T01_Entity.INOUT_CODE;
            USE_YN = pucWorkResultPopUp_T01_Entity.USE_YN;

        }

        #endregion
    }

    public class WorkRequestRegisterEntity
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
        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String INSPECT_STATUS { get; set; }
        public String INSPECT_ID { get; set; }
        public String INSPECT__DATE { get; set; }
        public String INSPECT_SEQ { get; set; }
        public String VEND_PART_CODE { get; set; }
        public String PART_TYPE { get; set; }
        public String REFERENCE_ID { get; set; }
        public String PRODUCTION_ORDER_ID { get; set; }
        public String PROCESS_CODE_MST { get; set; }

        public String MAKE_VEND { get; set; }
        public String MAKE_VEND_NAME { get; set; }
        public String VEND_CODE { get; set; }
        public String VEND_NAME { get; set; }
        public String REQUEST_DEPT { get; set; }
        public String CODE_NAME { get; set; }
        public String INOUT_DATE { get; set; }
        public String INOUT_QTY { get; set; }
        public String PACKING_REMARK { get; set; }
        public String SAMPLE_DATE { get; set; }
        public String SAMPLE_LOCATION { get; set; }
        public String SAMPLE_USER { get; set; }
        public String SAMPLE_METHOD { get; set; }
        public String SAMPLE_QTY { get; set; }
        public String MAKE_NO { get; set; }
        public String STANDARD { get; set; }
        public String REQUEST_DATE { get; set; }
        public String REQUEST_USER { get; set; }
        public String END_DATE { get; set; }
        public String TOTAL_RESULT { get; set; }
        public String TOTAL_DATE { get; set; }
        public String TOTAL_USER { get; set; }
        public String COMPLETE_YN { get; set; }
        public String REMARK { get; set; }
        public String POSITION { get; set; }
        public String USER_YN { get; set; }
        public String WORK_STATUS { get; set; }
        public String PRODUCTION_FILE { get; set; }
        public String ACCEPT_CHK { get; set; }
        public int dtListCnt { get; set; }
        public String QA_QTY { get; set; }         // 
        public String VEND_QTY { get; set; }         // 
        public String MESH { get; set; }         // 
        public String WORK_REMARK { get; set; }         // 

        #endregion

        #region 생성자 - WorkRequestRegisterEntity()

        public WorkRequestRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - WorkRequestRegisterEntity(pWorkRequestRegisterEntity)

        public WorkRequestRegisterEntity(WorkRequestRegisterEntity pWorkRequestRegisterEntity)
        {
            CORP_CODE = pWorkRequestRegisterEntity.CORP_CODE;
            CRUD = pWorkRequestRegisterEntity.CRUD;
            USER_CODE = pWorkRequestRegisterEntity.USER_CODE;

            pWorkRequestRegisterEntity.WINDOW_NAME = WINDOW_NAME;

            DATE_FROM = pWorkRequestRegisterEntity.DATE_FROM;
            DATE_TO = pWorkRequestRegisterEntity.DATE_TO;
            PART_CODE = pWorkRequestRegisterEntity.PART_CODE;
            PART_NAME = pWorkRequestRegisterEntity.PART_NAME;
            INSPECT_STATUS = pWorkRequestRegisterEntity.INSPECT_STATUS;
            INSPECT_ID = pWorkRequestRegisterEntity.INSPECT_ID;
            INSPECT__DATE = pWorkRequestRegisterEntity.INSPECT__DATE;
            INSPECT_SEQ = pWorkRequestRegisterEntity.INSPECT_SEQ;
            VEND_PART_CODE = pWorkRequestRegisterEntity.VEND_PART_CODE;
            PART_TYPE = pWorkRequestRegisterEntity.PART_TYPE;
            REFERENCE_ID = pWorkRequestRegisterEntity.REFERENCE_ID;
            MAKE_VEND = pWorkRequestRegisterEntity.MAKE_VEND;
            MAKE_VEND_NAME = pWorkRequestRegisterEntity.MAKE_VEND_NAME;
            VEND_CODE = pWorkRequestRegisterEntity.VEND_CODE;
            VEND_NAME = pWorkRequestRegisterEntity.VEND_NAME;
            REQUEST_DEPT = pWorkRequestRegisterEntity.REQUEST_DEPT;
            CODE_NAME = pWorkRequestRegisterEntity.CODE_NAME;
            INOUT_DATE = pWorkRequestRegisterEntity.INOUT_DATE;
            INOUT_QTY = pWorkRequestRegisterEntity.INOUT_QTY;
            PACKING_REMARK = pWorkRequestRegisterEntity.PACKING_REMARK;
            SAMPLE_DATE = pWorkRequestRegisterEntity.SAMPLE_DATE;
            SAMPLE_LOCATION = pWorkRequestRegisterEntity.SAMPLE_LOCATION;
            SAMPLE_USER = pWorkRequestRegisterEntity.SAMPLE_USER;
            SAMPLE_METHOD = pWorkRequestRegisterEntity.SAMPLE_METHOD;
            SAMPLE_QTY = pWorkRequestRegisterEntity.SAMPLE_QTY;
            MAKE_NO = pWorkRequestRegisterEntity.MAKE_NO;
            STANDARD = pWorkRequestRegisterEntity.STANDARD;
            REQUEST_DATE = pWorkRequestRegisterEntity.REQUEST_DATE;
            REQUEST_USER = pWorkRequestRegisterEntity.REQUEST_USER;
            END_DATE = pWorkRequestRegisterEntity.END_DATE;
            TOTAL_RESULT = pWorkRequestRegisterEntity.TOTAL_RESULT;
            TOTAL_DATE = pWorkRequestRegisterEntity.TOTAL_DATE;
            TOTAL_USER = pWorkRequestRegisterEntity.TOTAL_USER;
            COMPLETE_YN = pWorkRequestRegisterEntity.COMPLETE_YN;
            REMARK = pWorkRequestRegisterEntity.REMARK;
            USER_YN = pWorkRequestRegisterEntity.USER_YN;
            dtListCnt = pWorkRequestRegisterEntity.dtListCnt;
            PRODUCTION_ORDER_ID = pWorkRequestRegisterEntity.PRODUCTION_ORDER_ID;
            WORK_STATUS = pWorkRequestRegisterEntity.WORK_STATUS;
            POSITION = pWorkRequestRegisterEntity.POSITION;
            

            QA_QTY = pWorkRequestRegisterEntity.QA_QTY;
            VEND_QTY = pWorkRequestRegisterEntity.VEND_QTY;
            MESH = pWorkRequestRegisterEntity.MESH;
            WORK_REMARK = pWorkRequestRegisterEntity.WORK_REMARK;


            //pWorkRequestRegisterEntity.PROCESS_CODE = PROCESS_CODE;

            ERR_NO = pWorkRequestRegisterEntity.ERR_NO;
            ERR_MSG = pWorkRequestRegisterEntity.ERR_MSG;
            RTN_KEY = pWorkRequestRegisterEntity.RTN_KEY;
            RTN_SEQ = pWorkRequestRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pWorkRequestRegisterEntity.RTN_OTHERS;
            PROCESS_CODE_MST = pWorkRequestRegisterEntity.PROCESS_CODE_MST;
            LANGUAGE_TYPE = pWorkRequestRegisterEntity.LANGUAGE_TYPE;

            PRODUCTION_FILE = pWorkRequestRegisterEntity.PRODUCTION_FILE;

            ACCEPT_CHK = pWorkRequestRegisterEntity.ACCEPT_CHK;
            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ucWorkRequestInfoPopupEntity
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
        public String PART_NAME { get; set; } //
        public String PART_TYPE { get; set; } //
        public String VEND_ANME { get; set; } //

        #endregion

        #region 생성자 - ucWorkRequestInfoPopupEntity()

        public ucWorkRequestInfoPopupEntity()
        {
        }

        #endregion

        #region 생성자 - ucWorkRequestInfoPopupEntity(pucWorkRequestInfoPopupEntity)

        public ucWorkRequestInfoPopupEntity(ucWorkRequestInfoPopupEntity pucWorkRequestInfoPopupEntity)
        {
            CORP_CODE = pucWorkRequestInfoPopupEntity.CORP_CODE;
            CRUD = pucWorkRequestInfoPopupEntity.CRUD;
            USER_CODE = pucWorkRequestInfoPopupEntity.USER_CODE;

            pucWorkRequestInfoPopupEntity.WINDOW_NAME = WINDOW_NAME;
            LANGUAGE_TYPE = pucWorkRequestInfoPopupEntity.LANGUAGE_TYPE;
            pucWorkRequestInfoPopupEntity.DATE_FROM = DATE_FROM;
            pucWorkRequestInfoPopupEntity.DATE_TO = DATE_TO;
            pucWorkRequestInfoPopupEntity.PROCESS_CODE = PROCESS_CODE;
            pucWorkRequestInfoPopupEntity.PART_TYPE = PART_TYPE;

            ERR_NO = pucWorkRequestInfoPopupEntity.ERR_NO;
            ERR_MSG = pucWorkRequestInfoPopupEntity.ERR_MSG;
            RTN_KEY = pucWorkRequestInfoPopupEntity.RTN_KEY;
            RTN_SEQ = pucWorkRequestInfoPopupEntity.RTN_SEQ;
            RTN_OTHERS = pucWorkRequestInfoPopupEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ucMakeNoMappingPopupEntity
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
        public String PART_NAME { get; set; } //
        public String PART_TYPE { get; set; } //
        public String VEND_ANME { get; set; } //

        #endregion

        #region 생성자 - ucMakeNoMappingPopupEntity()

        public ucMakeNoMappingPopupEntity()
        {
        }

        #endregion

        #region 생성자 - ucMakeNoMappingPopupEntity(pucMakeNoMappingPopupEntity)

        public ucMakeNoMappingPopupEntity(ucMakeNoMappingPopupEntity pucMakeNoMappingPopupEntity)
        {
            CORP_CODE = pucMakeNoMappingPopupEntity.CORP_CODE;
            CRUD = pucMakeNoMappingPopupEntity.CRUD;
            USER_CODE = pucMakeNoMappingPopupEntity.USER_CODE;

            pucMakeNoMappingPopupEntity.WINDOW_NAME = WINDOW_NAME;
            LANGUAGE_TYPE = pucMakeNoMappingPopupEntity.LANGUAGE_TYPE;
            pucMakeNoMappingPopupEntity.DATE_FROM = DATE_FROM;
            pucMakeNoMappingPopupEntity.DATE_TO = DATE_TO;
            pucMakeNoMappingPopupEntity.PROCESS_CODE = PROCESS_CODE;
            pucMakeNoMappingPopupEntity.PART_TYPE = PART_TYPE;

            ERR_NO = pucMakeNoMappingPopupEntity.ERR_NO;
            ERR_MSG = pucMakeNoMappingPopupEntity.ERR_MSG;
            RTN_KEY = pucMakeNoMappingPopupEntity.RTN_KEY;
            RTN_SEQ = pucMakeNoMappingPopupEntity.RTN_SEQ;
            RTN_OTHERS = pucMakeNoMappingPopupEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ucWorkOrderDocRegPopupEntity
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
        public String PART_CODE { get; set; } //
        public String PART_NAME { get; set; } //
        public String PART_TYPE { get; set; } //
        public String VEND_ANME { get; set; } //
        public String FILE_NAME { get; set; } //
        public String PRODUCTION_ORDER_ID { get; set; } //
        public String TOTAL_APPROVER_SIGN { get; set; }
        public String MAKE_NO { get; set; }

        //메뉴별 추가 엔티티 입력
        public String RESOURCE_CODE { get; set; }
        public String COLLECTION_DATE { get; set; }
        public String PROPERTY_VALUE { get; set; }
        public String CONDITION_CODE { get; set; }
        public String COLLECTION_VALUE { get; set; }
        public String LOT_NO { get; set; }  //포장용

        public String APPROVER_SIGN_CHK { get; set; }
        public String PRODUCTION_RESULT_QTY { get; set; }
        public String PRODUCTION_NG_RESULT_QTY { get; set; }
        public String SEMI_PRODUCTION_RESULT_QTY { get; set; }

        #endregion

        #region 생성자 - ucWorkOrderDocRegPopupEntity()

        public ucWorkOrderDocRegPopupEntity()
        {
        }

        #endregion

        #region 생성자 - ucWorkOrderDocRegPopupEntity(pucWorkOrderDocRegPopupEntity)

        public ucWorkOrderDocRegPopupEntity(ucWorkOrderDocRegPopupEntity pucWorkOrderDocRegPopupEntity)
        {
            CORP_CODE = pucWorkOrderDocRegPopupEntity.CORP_CODE;
            CRUD = pucWorkOrderDocRegPopupEntity.CRUD;
            USER_CODE = pucWorkOrderDocRegPopupEntity.USER_CODE;

            pucWorkOrderDocRegPopupEntity.WINDOW_NAME = WINDOW_NAME;
            LANGUAGE_TYPE = pucWorkOrderDocRegPopupEntity.LANGUAGE_TYPE;
            pucWorkOrderDocRegPopupEntity.DATE_FROM = DATE_FROM;
            pucWorkOrderDocRegPopupEntity.DATE_TO = DATE_TO;
            pucWorkOrderDocRegPopupEntity.PROCESS_CODE = PROCESS_CODE;
            pucWorkOrderDocRegPopupEntity.PART_TYPE = PART_TYPE;

            ERR_NO = pucWorkOrderDocRegPopupEntity.ERR_NO;
            ERR_MSG = pucWorkOrderDocRegPopupEntity.ERR_MSG;
            RTN_KEY = pucWorkOrderDocRegPopupEntity.RTN_KEY;
            RTN_SEQ = pucWorkOrderDocRegPopupEntity.RTN_SEQ;
            RTN_OTHERS = pucWorkOrderDocRegPopupEntity.RTN_OTHERS;

            PROCESS_CODE_MST = pucWorkOrderDocRegPopupEntity.PROCESS_CODE_MST;

            FILE_NAME = pucWorkOrderDocRegPopupEntity.FILE_NAME;
            PRODUCTION_ORDER_ID = pucWorkOrderDocRegPopupEntity.PRODUCTION_ORDER_ID;

            MAKE_NO = pucWorkOrderDocRegPopupEntity.MAKE_NO;
            PART_CODE = pucWorkOrderDocRegPopupEntity.PART_CODE;
            LOT_NO = pucWorkOrderDocRegPopupEntity.LOT_NO;

            APPROVER_SIGN_CHK = pucWorkOrderDocRegPopupEntity.APPROVER_SIGN_CHK;
            PRODUCTION_RESULT_QTY = pucWorkOrderDocRegPopupEntity.PRODUCTION_RESULT_QTY;
            PRODUCTION_NG_RESULT_QTY = pucWorkOrderDocRegPopupEntity.PRODUCTION_NG_RESULT_QTY;
            
            //메뉴별 추가 엔티티 입력

            RESOURCE_CODE = pucWorkOrderDocRegPopupEntity.RESOURCE_CODE;
            COLLECTION_DATE = pucWorkOrderDocRegPopupEntity.COLLECTION_DATE;
            PROPERTY_VALUE = pucWorkOrderDocRegPopupEntity.PROPERTY_VALUE;
            CONDITION_CODE = pucWorkOrderDocRegPopupEntity.CONDITION_CODE;
            COLLECTION_VALUE = pucWorkOrderDocRegPopupEntity.COLLECTION_VALUE;
            SEMI_PRODUCTION_RESULT_QTY = pucWorkOrderDocRegPopupEntity.SEMI_PRODUCTION_RESULT_QTY;
        }

        #endregion



    }

    public class ProductPlanInfoPopup_T01Entity
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

        #region 생성자 - ProductPlanInfoPopup_T01Entity()

        public ProductPlanInfoPopup_T01Entity()
        {
        }

        #endregion

        #region 생성자 - ProductPlanInfoPopup_T01Entity(pProductPlanInfoPopup_T01Entity)

        public ProductPlanInfoPopup_T01Entity(ProductPlanInfoPopup_T01Entity pProductPlanInfoPopup_T01Entity)
        {
            CORP_CODE = pProductPlanInfoPopup_T01Entity.CORP_CODE;
            CRUD = pProductPlanInfoPopup_T01Entity.CRUD;
            USER_CODE = pProductPlanInfoPopup_T01Entity.USER_CODE;

            PART_CODE_MST = pProductPlanInfoPopup_T01Entity.PART_CODE_MST;
            CONTRACT_ID = pProductPlanInfoPopup_T01Entity.CONTRACT_ID;

            ERR_NO = pProductPlanInfoPopup_T01Entity.ERR_NO;
            ERR_MSG = pProductPlanInfoPopup_T01Entity.ERR_MSG;
            RTN_KEY = pProductPlanInfoPopup_T01Entity.RTN_KEY;
            RTN_SEQ = pProductPlanInfoPopup_T01Entity.RTN_SEQ;
            RTN_AQ = pProductPlanInfoPopup_T01Entity.RTN_AQ;
            RTN_SQ = pProductPlanInfoPopup_T01Entity.RTN_SQ;
            RTN_OTHERS = pProductPlanInfoPopup_T01Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class ucProductionOrderInfoPopup_T06_Entity
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

        #region 생성자 - ucProductionOrderInfoPopup_T06_Entity()

        public ucProductionOrderInfoPopup_T06_Entity()
        {
        }

        #endregion

        #region 생성자 - ucProductionOrderInfoPopup_T06_Entity(ucProductionOrderInfoPopup_T06_Entity pucProductionOrderInfoPopup_T06_Entity)

        public ucProductionOrderInfoPopup_T06_Entity(ucProductionOrderInfoPopup_T06_Entity pucProductionOrderInfoPopup_T06_Entity)
        {
            CORP_CODE = pucProductionOrderInfoPopup_T06_Entity.CORP_CODE;
            CRUD = pucProductionOrderInfoPopup_T06_Entity.CRUD;
            USER_CODE = pucProductionOrderInfoPopup_T06_Entity.USER_CODE;
            LANGUAGE_TYPE = pucProductionOrderInfoPopup_T06_Entity.LANGUAGE_TYPE;

            ERR_NO = pucProductionOrderInfoPopup_T06_Entity.ERR_NO;
            ERR_MSG = pucProductionOrderInfoPopup_T06_Entity.ERR_MSG;
            RTN_KEY = pucProductionOrderInfoPopup_T06_Entity.RTN_KEY;
            RTN_SEQ = pucProductionOrderInfoPopup_T06_Entity.RTN_SEQ;
            RTN_AQ = pucProductionOrderInfoPopup_T06_Entity.RTN_AQ;
            RTN_SQ = pucProductionOrderInfoPopup_T06_Entity.RTN_SQ;
            RTN_OTHERS = pucProductionOrderInfoPopup_T06_Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            DATE_FROM = pucProductionOrderInfoPopup_T06_Entity.DATE_FROM;
            DATE_TO = pucProductionOrderInfoPopup_T06_Entity.DATE_TO;
            PART_CODE = pucProductionOrderInfoPopup_T06_Entity.PART_CODE;
            PART_NAME = pucProductionOrderInfoPopup_T06_Entity.PART_NAME;
            VEND_CODE = pucProductionOrderInfoPopup_T06_Entity.VEND_CODE;
            VEND_NAME = pucProductionOrderInfoPopup_T06_Entity.VEND_NAME;

        }

        #endregion
    }

    public class WorkOrdersRegister_T03Entity
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
        public String DATE_FROM { get; set; } //조회 시작 날짜
        public String DATE_TO { get; set; } //조회 마감 날짜
        public String ORDER_CODE { get; set; } //작업지시 코드

        public String ORDER_DATE { get; set; } //작업지시 코드
        public String PLAN_CODE { get; set; } //생산계획 코드
        public String PART_NAME { get; set; } //품목명
        public String PART_CODE { get; set; } //품목 코드
        public String PROCESS_CODE { get; set; } //공정코드
        public String RESOURCE_CODE { get; set; } //설비명
        public String RESOURCE_NAME { get; set; } //설비 코드
        public String USE_YN { get; set; } //사용 유무

        public String ORDER_QTY { get; set; } //사용 유무

        public String COMPLETE_YN { get; set; } //사용 유무

        public String WORKCENTER_CODE { get; set; } //사용 유무

        public String REFERENCE_ID { get; set; } //사용 유무

        //작업일보 확인
        public String PRODUCTION_ORDER_ID { get; set; } //작업지시번호
        public String PROCESS_CODE_MST { get; set; } //공정그룹코드

        #endregion

        #region 생성자 - WorkOrdersRegister_T03Entity()

        public WorkOrdersRegister_T03Entity()
        {
        }

        #endregion

        #region 생성자 - WorkOrdersRegister_T03Entity(WorkOrdersRegister_T03Entity pWorkOrdersRegister_T03Entity)

        public WorkOrdersRegister_T03Entity(WorkOrdersRegister_T03Entity pWorkOrdersRegister_T03Entity)
        {
            CORP_CODE = pWorkOrdersRegister_T03Entity.CORP_CODE;
            CRUD = pWorkOrdersRegister_T03Entity.CRUD;
            USER_CODE = pWorkOrdersRegister_T03Entity.USER_CODE;
            LANGUAGE_TYPE = pWorkOrdersRegister_T03Entity.LANGUAGE_TYPE;

            ERR_NO = pWorkOrdersRegister_T03Entity.ERR_NO;
            ERR_MSG = pWorkOrdersRegister_T03Entity.ERR_MSG;
            RTN_KEY = pWorkOrdersRegister_T03Entity.RTN_KEY;
            RTN_SEQ = pWorkOrdersRegister_T03Entity.RTN_SEQ;
            RTN_OTHERS = pWorkOrdersRegister_T03Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            DATE_FROM = pWorkOrdersRegister_T03Entity.DATE_FROM;
            DATE_TO = pWorkOrdersRegister_T03Entity.DATE_TO;
            ORDER_CODE = pWorkOrdersRegister_T03Entity.ORDER_CODE;
            ORDER_DATE = pWorkOrdersRegister_T03Entity.ORDER_DATE;
            PLAN_CODE = pWorkOrdersRegister_T03Entity.PLAN_CODE;
            PART_NAME = pWorkOrdersRegister_T03Entity.PART_NAME;
            PART_CODE = pWorkOrdersRegister_T03Entity.PART_CODE;
            RESOURCE_CODE = pWorkOrdersRegister_T03Entity.RESOURCE_CODE;
            RESOURCE_NAME = pWorkOrdersRegister_T03Entity.RESOURCE_NAME;
            PROCESS_CODE = pWorkOrdersRegister_T03Entity.PROCESS_CODE;
            USE_YN = pWorkOrdersRegister_T03Entity.USE_YN;
            ORDER_QTY = pWorkOrdersRegister_T03Entity.ORDER_QTY;
            COMPLETE_YN = pWorkOrdersRegister_T03Entity.COMPLETE_YN;
            WORKCENTER_CODE = pWorkOrdersRegister_T03Entity.WORKCENTER_CODE;
            REFERENCE_ID = pWorkOrdersRegister_T03Entity.REFERENCE_ID;

            //작업일보 확인
            PRODUCTION_ORDER_ID = pWorkOrdersRegister_T03Entity.PRODUCTION_ORDER_ID;
            PROCESS_CODE_MST = pWorkOrdersRegister_T03Entity.PROCESS_CODE_MST;

        }

        #endregion

    }

    public class WorkOrdersRegister_T06Entity
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
        public String DATE_FROM { get; set; } //조회 시작 날짜
        public String DATE_TO { get; set; } //조회 마감 날짜
        public String ORDER_CODE { get; set; } //작업지시 코드

        public String ORDER_DATE { get; set; } //작업지시 코드
        public String PLAN_CODE { get; set; } //생산계획 코드
        public String PART_NAME { get; set; } //품목명
        public String PART_CODE { get; set; } //품목 코드
        public String PROCESS_CODE { get; set; } //공정코드
        public String RESOURCE_CODE { get; set; } //설비명
        public String RESOURCE_NAME { get; set; } //설비 코드
        public String USE_YN { get; set; } //사용 유무

        public String ORDER_QTY { get; set; } //사용 유무

        public String COMPLETE_YN { get; set; } //사용 유무

        public String WORKCENTER_CODE { get; set; } //사용 유무

        public String REFERENCE_ID { get; set; } //사용 유무

        //작업일보 확인
        public String PRODUCTION_ORDER_ID { get; set; } //작업지시번호
        public String PROCESS_CODE_MST { get; set; } //공정그룹코드

        public String TERMINAL_CODE { get; set; }
        public String DAY_AND_NIGHT { get; set; }

        #endregion

        #region 생성자 - WorkOrdersRegister_T06Entity()

        public WorkOrdersRegister_T06Entity()
        {
        }

        #endregion

        #region 생성자 - WorkOrdersRegister_T06Entity(WorkOrdersRegister_T06Entity pWorkOrdersRegister_T06Entity)

        public WorkOrdersRegister_T06Entity(WorkOrdersRegister_T06Entity pWorkOrdersRegister_T06Entity)
        {
            CORP_CODE = pWorkOrdersRegister_T06Entity.CORP_CODE;
            CRUD = pWorkOrdersRegister_T06Entity.CRUD;
            USER_CODE = pWorkOrdersRegister_T06Entity.USER_CODE;
            LANGUAGE_TYPE = pWorkOrdersRegister_T06Entity.LANGUAGE_TYPE;

            ERR_NO = pWorkOrdersRegister_T06Entity.ERR_NO;
            ERR_MSG = pWorkOrdersRegister_T06Entity.ERR_MSG;
            RTN_KEY = pWorkOrdersRegister_T06Entity.RTN_KEY;
            RTN_SEQ = pWorkOrdersRegister_T06Entity.RTN_SEQ;
            RTN_OTHERS = pWorkOrdersRegister_T06Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            DATE_FROM = pWorkOrdersRegister_T06Entity.DATE_FROM;
            DATE_TO = pWorkOrdersRegister_T06Entity.DATE_TO;
            ORDER_CODE = pWorkOrdersRegister_T06Entity.ORDER_CODE;
            ORDER_DATE = pWorkOrdersRegister_T06Entity.ORDER_DATE;
            PLAN_CODE = pWorkOrdersRegister_T06Entity.PLAN_CODE;
            PART_NAME = pWorkOrdersRegister_T06Entity.PART_NAME;
            PART_CODE = pWorkOrdersRegister_T06Entity.PART_CODE;
            RESOURCE_CODE = pWorkOrdersRegister_T06Entity.RESOURCE_CODE;
            RESOURCE_NAME = pWorkOrdersRegister_T06Entity.RESOURCE_NAME;
            PROCESS_CODE = pWorkOrdersRegister_T06Entity.PROCESS_CODE;
            USE_YN = pWorkOrdersRegister_T06Entity.USE_YN;
            ORDER_QTY = pWorkOrdersRegister_T06Entity.ORDER_QTY;
            COMPLETE_YN = pWorkOrdersRegister_T06Entity.COMPLETE_YN;
            WORKCENTER_CODE = pWorkOrdersRegister_T06Entity.WORKCENTER_CODE;
            REFERENCE_ID = pWorkOrdersRegister_T06Entity.REFERENCE_ID;

            //작업일보 확인
            PRODUCTION_ORDER_ID = pWorkOrdersRegister_T06Entity.PRODUCTION_ORDER_ID;
            PROCESS_CODE_MST = pWorkOrdersRegister_T06Entity.PROCESS_CODE_MST;

            TERMINAL_CODE = pWorkOrdersRegister_T06Entity.TERMINAL_CODE;
            DAY_AND_NIGHT = pWorkOrdersRegister_T06Entity.DAY_AND_NIGHT;

        }

        #endregion

    }


    public class WorkOrderInfoPopup_T02Entity
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

        #region 생성자 - WorkOrderInfoPopup_T02Entity()

        public WorkOrderInfoPopup_T02Entity()
        {
        }

        #endregion

        #region 생성자 - WorkOrderInfoPopup_T02Entity(pWorkOrderInfoPopup_T02Entity)

        public WorkOrderInfoPopup_T02Entity(WorkOrderInfoPopup_T02Entity pWorkOrderInfoPopup_T02Entity)
        {
            CORP_CODE = pWorkOrderInfoPopup_T02Entity.CORP_CODE;
            CRUD = pWorkOrderInfoPopup_T02Entity.CRUD;
            USER_CODE = pWorkOrderInfoPopup_T02Entity.USER_CODE;
            LANGUAGE_TYPE = pWorkOrderInfoPopup_T02Entity.LANGUAGE_TYPE;

            PART_CODE_MST = pWorkOrderInfoPopup_T02Entity.PART_CODE_MST;
            WORKORDER_ID = pWorkOrderInfoPopup_T02Entity.WORKORDER_ID;
            REFERENCE_ID = pWorkOrderInfoPopup_T02Entity.REFERENCE_ID;

            ERR_NO = pWorkOrderInfoPopup_T02Entity.ERR_NO;
            ERR_MSG = pWorkOrderInfoPopup_T02Entity.ERR_MSG;
            RTN_KEY = pWorkOrderInfoPopup_T02Entity.RTN_KEY;
            RTN_SEQ = pWorkOrderInfoPopup_T02Entity.RTN_SEQ;
            RTN_AQ = pWorkOrderInfoPopup_T02Entity.RTN_AQ;
            RTN_SQ = pWorkOrderInfoPopup_T02Entity.RTN_SQ;
            RTN_OTHERS = pWorkOrderInfoPopup_T02Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }


    public class ucPlanOrderinfoPopup_T01_Entity
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

        #region 생성자 - ucPlanOrderinfoPopup_T01_Entity()

        public ucPlanOrderinfoPopup_T01_Entity()
        {
        }

        #endregion

        #region 생성자 - ucPlanOrderinfoPopup_T01_Entity(ucPlanOrderinfoPopup_T01_Entity pucPlanOrderinfoPopup_T01_Entity)

        public ucPlanOrderinfoPopup_T01_Entity(ucPlanOrderinfoPopup_T01_Entity pucPlanOrderinfoPopup_T01_Entity)
        {
            CORP_CODE = pucPlanOrderinfoPopup_T01_Entity.CORP_CODE;
            CRUD = pucPlanOrderinfoPopup_T01_Entity.CRUD;
            USER_CODE = pucPlanOrderinfoPopup_T01_Entity.USER_CODE;
            LANGUAGE_TYPE = pucPlanOrderinfoPopup_T01_Entity.LANGUAGE_TYPE;

            ERR_NO = pucPlanOrderinfoPopup_T01_Entity.ERR_NO;
            ERR_MSG = pucPlanOrderinfoPopup_T01_Entity.ERR_MSG;
            RTN_KEY = pucPlanOrderinfoPopup_T01_Entity.RTN_KEY;
            RTN_SEQ = pucPlanOrderinfoPopup_T01_Entity.RTN_SEQ;
            RTN_AQ = pucPlanOrderinfoPopup_T01_Entity.RTN_AQ;
            RTN_SQ = pucPlanOrderinfoPopup_T01_Entity.RTN_SQ;
            RTN_OTHERS = pucPlanOrderinfoPopup_T01_Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            DATE_FROM = pucPlanOrderinfoPopup_T01_Entity.DATE_FROM;
            DATE_TO = pucPlanOrderinfoPopup_T01_Entity.DATE_TO;
            PART_CODE = pucPlanOrderinfoPopup_T01_Entity.PART_CODE;
            PART_NAME = pucPlanOrderinfoPopup_T01_Entity.PART_NAME;
            PLAN_ORDER_ID = pucPlanOrderinfoPopup_T01_Entity.PLAN_ORDER_ID;

        }

        #endregion
    }

    public class ucWorkResultPopUp_T02_Entity
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


        #endregion

        #region 생성자 - ucWorkResultPopUp_T02_Entity()

        public ucWorkResultPopUp_T02_Entity()
        {
        }

        #endregion

        #region 생성자 - ucWorkResultPopUp_T02_Entity(ucWorkResultPopUp_T02_Entity pucWorkResultPopUp_T02_Entity)

        public ucWorkResultPopUp_T02_Entity(ucWorkResultPopUp_T02_Entity pucWorkResultPopUp_T02_Entity)
        {
            CORP_CODE = pucWorkResultPopUp_T02_Entity.CORP_CODE;
            CRUD = pucWorkResultPopUp_T02_Entity.CRUD;
            USER_CODE = pucWorkResultPopUp_T02_Entity.USER_CODE;
            LANGUAGE_TYPE = pucWorkResultPopUp_T02_Entity.LANGUAGE_TYPE;

            ERR_NO = pucWorkResultPopUp_T02_Entity.ERR_NO;
            ERR_MSG = pucWorkResultPopUp_T02_Entity.ERR_MSG;
            RTN_KEY = pucWorkResultPopUp_T02_Entity.RTN_KEY;
            RTN_SEQ = pucWorkResultPopUp_T02_Entity.RTN_SEQ;
            RTN_AQ = pucWorkResultPopUp_T02_Entity.RTN_AQ;
            RTN_SQ = pucWorkResultPopUp_T02_Entity.RTN_SQ;
            RTN_OTHERS = pucWorkResultPopUp_T02_Entity.RTN_OTHERS;

            RESOURCE_CODE = pucWorkResultPopUp_T02_Entity.RESOURCE_CODE;
            COLLECTION_DATE = pucWorkResultPopUp_T02_Entity.COLLECTION_DATE;
            PROPERTY_VALUE = pucWorkResultPopUp_T02_Entity.PROPERTY_VALUE;
            CONDITION_CODE = pucWorkResultPopUp_T02_Entity.CONDITION_CODE;
            COLLECTION_VALUE = pucWorkResultPopUp_T02_Entity.COLLECTION_VALUE;

            PRODUCTION_ORDER_ID = pucWorkResultPopUp_T02_Entity.PRODUCTION_ORDER_ID;
            COMPLETE_YN = pucWorkResultPopUp_T02_Entity.COMPLETE_YN;
        }

        #endregion
    }

    public class ucWorkResultPopUp_T03_Entity
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


        #endregion

        #region 생성자 - ucWorkResultPopUp_T03_Entity()

        public ucWorkResultPopUp_T03_Entity()
        {
        }

        #endregion

        #region 생성자 - ucWorkResultPopUp_T03_Entity(ucWorkResultPopUp_T03_Entity pucWorkResultPopUp_T03_Entity)

        public ucWorkResultPopUp_T03_Entity(ucWorkResultPopUp_T03_Entity pucWorkResultPopUp_T03_Entity)
        {
            CORP_CODE = pucWorkResultPopUp_T03_Entity.CORP_CODE;
            CRUD = pucWorkResultPopUp_T03_Entity.CRUD;
            USER_CODE = pucWorkResultPopUp_T03_Entity.USER_CODE;
            LANGUAGE_TYPE = pucWorkResultPopUp_T03_Entity.LANGUAGE_TYPE;

            ERR_NO = pucWorkResultPopUp_T03_Entity.ERR_NO;
            ERR_MSG = pucWorkResultPopUp_T03_Entity.ERR_MSG;
            RTN_KEY = pucWorkResultPopUp_T03_Entity.RTN_KEY;
            RTN_SEQ = pucWorkResultPopUp_T03_Entity.RTN_SEQ;
            RTN_AQ = pucWorkResultPopUp_T03_Entity.RTN_AQ;
            RTN_SQ = pucWorkResultPopUp_T03_Entity.RTN_SQ;
            RTN_OTHERS = pucWorkResultPopUp_T03_Entity.RTN_OTHERS;

            RESOURCE_CODE = pucWorkResultPopUp_T03_Entity.RESOURCE_CODE;
            COLLECTION_DATE = pucWorkResultPopUp_T03_Entity.COLLECTION_DATE;
            PROPERTY_VALUE = pucWorkResultPopUp_T03_Entity.PROPERTY_VALUE;
            CONDITION_CODE = pucWorkResultPopUp_T03_Entity.CONDITION_CODE;
            COLLECTION_VALUE = pucWorkResultPopUp_T03_Entity.COLLECTION_VALUE;

            PRODUCTION_ORDER_ID = pucWorkResultPopUp_T03_Entity.PRODUCTION_ORDER_ID;
            COMPLETE_YN = pucWorkResultPopUp_T03_Entity.COMPLETE_YN;
        }

        #endregion
    }


    public class ucWorkResultPopUp_T50_Entity
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
        public String OPTION_CODE { get; set; }
        public String PRODUCTION_ORDER_ID { get; set; }
        public String PRODUCTION_ORDER_SEQ { get; set; }
        public String COMPLETE_YN { get; set; }


        #endregion

        #region 생성자 - ucWorkResultPopUp_T50_Entity()

        public ucWorkResultPopUp_T50_Entity()
        {
        }

        #endregion

        #region 생성자 - ucWorkResultPopUp_T50_Entity(ucWorkResultPopUp_T50_Entity pucWorkResultPopUp_T50_Entity)

        public ucWorkResultPopUp_T50_Entity(ucWorkResultPopUp_T50_Entity pucWorkResultPopUp_T50_Entity)
        {
            CORP_CODE = pucWorkResultPopUp_T50_Entity.CORP_CODE;
            CRUD = pucWorkResultPopUp_T50_Entity.CRUD;
            USER_CODE = pucWorkResultPopUp_T50_Entity.USER_CODE;
            LANGUAGE_TYPE = pucWorkResultPopUp_T50_Entity.LANGUAGE_TYPE;

            ERR_NO = pucWorkResultPopUp_T50_Entity.ERR_NO;
            ERR_MSG = pucWorkResultPopUp_T50_Entity.ERR_MSG;
            RTN_KEY = pucWorkResultPopUp_T50_Entity.RTN_KEY;
            RTN_SEQ = pucWorkResultPopUp_T50_Entity.RTN_SEQ;
            RTN_AQ = pucWorkResultPopUp_T50_Entity.RTN_AQ;
            RTN_SQ = pucWorkResultPopUp_T50_Entity.RTN_SQ;
            RTN_OTHERS = pucWorkResultPopUp_T50_Entity.RTN_OTHERS;

            RESOURCE_CODE = pucWorkResultPopUp_T50_Entity.RESOURCE_CODE;
            COLLECTION_DATE = pucWorkResultPopUp_T50_Entity.COLLECTION_DATE;
            PROPERTY_VALUE = pucWorkResultPopUp_T50_Entity.PROPERTY_VALUE;
            CONDITION_CODE = pucWorkResultPopUp_T50_Entity.CONDITION_CODE;
            COLLECTION_VALUE = pucWorkResultPopUp_T50_Entity.COLLECTION_VALUE;
            OPTION_CODE = pucWorkResultPopUp_T50_Entity.OPTION_CODE;
            PRODUCTION_ORDER_ID = pucWorkResultPopUp_T50_Entity.PRODUCTION_ORDER_ID;
            PRODUCTION_ORDER_SEQ = pucWorkResultPopUp_T50_Entity.PRODUCTION_ORDER_SEQ;
            COMPLETE_YN = pucWorkResultPopUp_T50_Entity.COMPLETE_YN;
        }

        #endregion
    }

    public class WorkReadingStatusEntity
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

        public String USER_ACCOUNT { get; set; }
        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        public String READING_TYPE { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - WorkReadingStatusEntity()

        public WorkReadingStatusEntity()
        {
        }

        #endregion

        #region 생성자 - WorkReadingStatusEntity(pWorkReadingStatusEntity)

        public WorkReadingStatusEntity(WorkReadingStatusEntity pWorkReadingStatusEntity)
        {
            CORP_CODE = pWorkReadingStatusEntity.CORP_CODE;
            CRUD = pWorkReadingStatusEntity.CRUD;
            USER_CODE = pWorkReadingStatusEntity.USER_CODE;

            LANGUAGE_TYPE = pWorkReadingStatusEntity.LANGUAGE_TYPE;


            pWorkReadingStatusEntity.PART_TYPE = PART_TYPE;
            pWorkReadingStatusEntity.PART_NAME = PART_NAME;
            pWorkReadingStatusEntity.PART_CODE = PART_CODE;

            pWorkReadingStatusEntity.USER_ACCOUNT = USER_ACCOUNT;
            pWorkReadingStatusEntity.DATE_FROM = DATE_FROM;
            pWorkReadingStatusEntity.DATE_TO = DATE_TO;
            pWorkReadingStatusEntity.READING_TYPE = READING_TYPE;

            ERR_NO = pWorkReadingStatusEntity.ERR_NO;
            ERR_MSG = pWorkReadingStatusEntity.ERR_MSG;
            RTN_KEY = pWorkReadingStatusEntity.RTN_KEY;
            RTN_SEQ = pWorkReadingStatusEntity.RTN_SEQ;
            RTN_OTHERS = pWorkReadingStatusEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class WorkResultStatus_T01Entity
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

        public String USER_ACCOUNT { get; set; }
        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        public String READING_TYPE { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - WorkResultStatus_T01Entity()

        public WorkResultStatus_T01Entity()
        {
        }

        #endregion

        #region 생성자 - WorkResultStatus_T01Entity(pWorkResultStatus_T01Entity)

        public WorkResultStatus_T01Entity(WorkResultStatus_T01Entity pWorkResultStatus_T01Entity)
        {
            CORP_CODE = pWorkResultStatus_T01Entity.CORP_CODE;
            CRUD = pWorkResultStatus_T01Entity.CRUD;
            USER_CODE = pWorkResultStatus_T01Entity.USER_CODE;

            LANGUAGE_TYPE = pWorkResultStatus_T01Entity.LANGUAGE_TYPE;


            pWorkResultStatus_T01Entity.PART_TYPE = PART_TYPE;
            pWorkResultStatus_T01Entity.PART_NAME = PART_NAME;
            pWorkResultStatus_T01Entity.PART_CODE = PART_CODE;

            pWorkResultStatus_T01Entity.USER_ACCOUNT = USER_ACCOUNT;
            pWorkResultStatus_T01Entity.DATE_FROM = DATE_FROM;
            pWorkResultStatus_T01Entity.DATE_TO = DATE_TO;
            pWorkResultStatus_T01Entity.READING_TYPE = READING_TYPE;

            ERR_NO = pWorkResultStatus_T01Entity.ERR_NO;
            ERR_MSG = pWorkResultStatus_T01Entity.ERR_MSG;
            RTN_KEY = pWorkResultStatus_T01Entity.RTN_KEY;
            RTN_SEQ = pWorkResultStatus_T01Entity.RTN_SEQ;
            RTN_OTHERS = pWorkResultStatus_T01Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ucWorkOrderInfoPopup_T04Entity
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
        public String LEAVE_QTY { get; set; }

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

        #region 생성자 - ucWorkOrderInfoPopup_T04Entity()

        public ucWorkOrderInfoPopup_T04Entity()
        {
        }

        #endregion

        #region 생성자 - ucWorkOrderInfoPopup_T04Entity(pucWorkOrderInfoPopup_T04Entity)

        public ucWorkOrderInfoPopup_T04Entity(ucWorkOrderInfoPopup_T04Entity pucWorkOrderInfoPopup_T04Entity)
        {
            CORP_CODE = pucWorkOrderInfoPopup_T04Entity.CORP_CODE;
            CRUD = pucWorkOrderInfoPopup_T04Entity.CRUD;
            USER_CODE = pucWorkOrderInfoPopup_T04Entity.USER_CODE;
            LANGUAGE_TYPE = pucWorkOrderInfoPopup_T04Entity.LANGUAGE_TYPE;

            PART_CODE_MST = pucWorkOrderInfoPopup_T04Entity.PART_CODE_MST;
            LEAVE_QTY = pucWorkOrderInfoPopup_T04Entity.LEAVE_QTY;
            WORKORDER_ID = pucWorkOrderInfoPopup_T04Entity.WORKORDER_ID;
            REFERENCE_ID = pucWorkOrderInfoPopup_T04Entity.REFERENCE_ID;

            ERR_NO = pucWorkOrderInfoPopup_T04Entity.ERR_NO;
            ERR_MSG = pucWorkOrderInfoPopup_T04Entity.ERR_MSG;
            RTN_KEY = pucWorkOrderInfoPopup_T04Entity.RTN_KEY;
            RTN_SEQ = pucWorkOrderInfoPopup_T04Entity.RTN_SEQ;
            RTN_AQ = pucWorkOrderInfoPopup_T04Entity.RTN_AQ;
            RTN_SQ = pucWorkOrderInfoPopup_T04Entity.RTN_SQ;
            RTN_OTHERS = pucWorkOrderInfoPopup_T04Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class ProductionResultState_T50Entity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE

        public String WINDOW_NAME { get; set; } // CRUD

        public String CARVE { get; set; } // 각인정보
        public String MESSAGE { get; set; } // 도면정보

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력
        public String DATE_FROM { get; set; } //조회 시작 날짜
        public String DATE_TO { get; set; } //조회 마감 날짜
        public String ORDER_CODE { get; set; } //작업지시 코드

        public String ORDER_DATE { get; set; } //작업지시 코드
        public String PLAN_CODE { get; set; } //생산계획 코드
        public String PART_NAME { get; set; } //품목명
        public String PART_CODE { get; set; } //품목 코드

        public String PRODUCTION_ORDER_ID { get; set; } //생산지시번호

        public String PROCESS_CODE { get; set; } //공정코드
        public String RESOURCE_CODE { get; set; } //설비명
        public String RESOURCE_NAME { get; set; } //설비 코드
        public String USE_YN { get; set; } //사용 유무

        public String ORDER_QTY { get; set; } //사용 유무

        public String COMPLETE_YN { get; set; } //사용 유무

        public String WORKCENTER_CODE { get; set; } //사용 유무

        public String REFERENCE_ID { get; set; } //사용 유무



        #endregion

        #region 생성자 - WorkOrdersRegister_T50Entity()

        public ProductionResultState_T50Entity()
        {
        }

        #endregion

        #region 생성자 - WorkOrdersRegister_T50Entity(WorkOrdersRegister_T50Entity pWorkOrdersRegister_T50Entity)

        public ProductionResultState_T50Entity(ProductionResultState_T50Entity pWorkOrdersRegister_T50Entity)
        {
            CORP_CODE = pWorkOrdersRegister_T50Entity.CORP_CODE;
            CRUD = pWorkOrdersRegister_T50Entity.CRUD;
            USER_CODE = pWorkOrdersRegister_T50Entity.USER_CODE;
            LANGUAGE_TYPE = pWorkOrdersRegister_T50Entity.LANGUAGE_TYPE;
            WINDOW_NAME = pWorkOrdersRegister_T50Entity.WINDOW_NAME;
            ERR_NO = pWorkOrdersRegister_T50Entity.ERR_NO;
            ERR_MSG = pWorkOrdersRegister_T50Entity.ERR_MSG;
            RTN_KEY = pWorkOrdersRegister_T50Entity.RTN_KEY;
            RTN_SEQ = pWorkOrdersRegister_T50Entity.RTN_SEQ;
            RTN_OTHERS = pWorkOrdersRegister_T50Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            DATE_FROM = pWorkOrdersRegister_T50Entity.DATE_FROM;
            DATE_TO = pWorkOrdersRegister_T50Entity.DATE_TO;
            ORDER_CODE = pWorkOrdersRegister_T50Entity.ORDER_CODE;
            ORDER_DATE = pWorkOrdersRegister_T50Entity.ORDER_DATE;
            PLAN_CODE = pWorkOrdersRegister_T50Entity.PLAN_CODE;
            PART_NAME = pWorkOrdersRegister_T50Entity.PART_NAME;
            PART_CODE = pWorkOrdersRegister_T50Entity.PART_CODE;
            RESOURCE_CODE = pWorkOrdersRegister_T50Entity.RESOURCE_CODE;
            RESOURCE_NAME = pWorkOrdersRegister_T50Entity.RESOURCE_NAME;
            PROCESS_CODE = pWorkOrdersRegister_T50Entity.PROCESS_CODE;
            USE_YN = pWorkOrdersRegister_T50Entity.USE_YN;
            ORDER_QTY = pWorkOrdersRegister_T50Entity.ORDER_QTY;
            COMPLETE_YN = pWorkOrdersRegister_T50Entity.COMPLETE_YN;
            WORKCENTER_CODE = pWorkOrdersRegister_T50Entity.WORKCENTER_CODE;
            REFERENCE_ID = pWorkOrdersRegister_T50Entity.REFERENCE_ID;
            PRODUCTION_ORDER_ID = pWorkOrdersRegister_T50Entity.PRODUCTION_ORDER_ID;
            CARVE = pWorkOrdersRegister_T50Entity.CARVE;
            MESSAGE = pWorkOrdersRegister_T50Entity.MESSAGE;
        }

        #endregion

    }

    public class ProductionStatusEntity
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

        public String USER_ACCOUNT { get; set; }
        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        public String READING_TYPE { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - ProductionStatusEntity()

        public ProductionStatusEntity()
        {
        }

        #endregion

        #region 생성자 - ProductionStatusEntity(pWorkReadingStatusEntity)

        public ProductionStatusEntity(WorkReadingStatusEntity pWorkReadingStatusEntity)
        {
            CORP_CODE = pWorkReadingStatusEntity.CORP_CODE;
            CRUD = pWorkReadingStatusEntity.CRUD;
            USER_CODE = pWorkReadingStatusEntity.USER_CODE;

            LANGUAGE_TYPE = pWorkReadingStatusEntity.LANGUAGE_TYPE;


            pWorkReadingStatusEntity.PART_TYPE = PART_TYPE;
            pWorkReadingStatusEntity.PART_NAME = PART_NAME;
            pWorkReadingStatusEntity.PART_CODE = PART_CODE;

            pWorkReadingStatusEntity.USER_ACCOUNT = USER_ACCOUNT;
            pWorkReadingStatusEntity.DATE_FROM = DATE_FROM;
            pWorkReadingStatusEntity.DATE_TO = DATE_TO;
            pWorkReadingStatusEntity.READING_TYPE = READING_TYPE;

            ERR_NO = pWorkReadingStatusEntity.ERR_NO;
            ERR_MSG = pWorkReadingStatusEntity.ERR_MSG;
            RTN_KEY = pWorkReadingStatusEntity.RTN_KEY;
            RTN_SEQ = pWorkReadingStatusEntity.RTN_SEQ;
            RTN_OTHERS = pWorkReadingStatusEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }
}

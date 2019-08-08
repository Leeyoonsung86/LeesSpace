using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoFAS_MES.UI.XX.Entity
{
    public class SampleRegisterEntity
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
        public String LANGUAGE_TYPE { get; set; }


        //메뉴별 추가 엔티티 입력
        public String WINDOW_NAME { get; set; }

        #endregion

        #region 생성자 - GridInfoRegisterEntity()

        public SampleRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - SampleRegisterEntity(pGridInfoRegisterEntity)

        public SampleRegisterEntity(SampleRegisterEntity pSampleRegisterEntity)
        {
            CORP_CODE = pSampleRegisterEntity.CORP_CODE;
            CRUD = pSampleRegisterEntity.CRUD;
            USER_CODE = pSampleRegisterEntity.USER_CODE;
            ERR_NO = pSampleRegisterEntity.ERR_NO;
            ERR_MSG = pSampleRegisterEntity.ERR_MSG;
            RTN_KEY = pSampleRegisterEntity.RTN_KEY;
            RTN_SEQ = pSampleRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pSampleRegisterEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            WINDOW_NAME = pSampleRegisterEntity.WINDOW_NAME;
        }
        #endregion

    }

    public class UsingExcelEntity
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
        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        public String USE_YN { get; set; }
        public String FILE_NAME { get; set; }
        public String FILE_NICKNAME { get; set; }
        public String DSP_SEQ { get; set; }
        public String USE_TYPE { get; set; }
        public String REMARK    { get; set; }

        #endregion

        #region 생성자 - UsingExcelEntity()

        public UsingExcelEntity()
        {
        }

        #endregion

        #region 생성자 - UsingExcelEntity(pUsingExcelEntity)

        public UsingExcelEntity(UsingExcelEntity pUsingExcelEntity)
        {
            CORP_CODE = pUsingExcelEntity.CORP_CODE;
            CRUD = pUsingExcelEntity.CRUD;
            USER_CODE = pUsingExcelEntity.USER_CODE;
            ERR_NO = pUsingExcelEntity.ERR_NO;
            ERR_MSG = pUsingExcelEntity.ERR_MSG;
            RTN_KEY = pUsingExcelEntity.RTN_KEY;
            RTN_SEQ = pUsingExcelEntity.RTN_SEQ;
            RTN_OTHERS = pUsingExcelEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            WINDOW_NAME = pUsingExcelEntity.WINDOW_NAME;
            FILE_NICKNAME = pUsingExcelEntity.FILE_NICKNAME;
            FILE_NAME = pUsingExcelEntity.FILE_NAME;
            DATE_FROM = pUsingExcelEntity.DATE_FROM;
            DATE_TO = pUsingExcelEntity.DATE_TO;
            USE_YN = pUsingExcelEntity.USE_YN;
            DSP_SEQ = pUsingExcelEntity.DSP_SEQ;
            USE_TYPE = pUsingExcelEntity.USE_TYPE;
            REMARK = pUsingExcelEntity.REMARK;
        }
        #endregion

    }



    public class SampleExcelBindingEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD

        public String WINDOW_NAME { get; set; }
        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        public String PART_NAME { get; set; }
        public String PART_CODE { get; set; }
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

        #region 생성자 - SampleExcelBindingEntity()

        public SampleExcelBindingEntity()
        {
        }

        #endregion

        #region 생성자 - SampleExcelBindingEntity(pSampleExcelBindingEntity)

        public SampleExcelBindingEntity(SampleExcelBindingEntity pSampleExcelBindingEntity)
        {
            CORP_CODE = pSampleExcelBindingEntity.CORP_CODE;
            CRUD = pSampleExcelBindingEntity.CRUD;
            USER_CODE = pSampleExcelBindingEntity.USER_CODE;

            pSampleExcelBindingEntity.DATE_FROM = DATE_FROM;
            pSampleExcelBindingEntity.DATE_TO = DATE_TO;
            pSampleExcelBindingEntity.PART_CODE = PART_CODE;
            pSampleExcelBindingEntity.PART_NAME = PART_NAME;
            pSampleExcelBindingEntity.VEND_NAME = VEND_NAME;
            pSampleExcelBindingEntity.ORDER_ID = ORDER_ID;


            ERR_NO = pSampleExcelBindingEntity.ERR_NO;
            ERR_MSG = pSampleExcelBindingEntity.ERR_MSG;
            RTN_KEY = pSampleExcelBindingEntity.RTN_KEY;
            RTN_SEQ = pSampleExcelBindingEntity.RTN_SEQ;
            RTN_OTHERS = pSampleExcelBindingEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }


    public class WorkResultViewEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD

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

        #region 생성자 - WorkResultViewEntity()

        public WorkResultViewEntity()
        {

        }

        #endregion

        #region 생성자 - WorkResultViewEntity(pWorkResultViewEntity)

        public WorkResultViewEntity(WorkResultViewEntity pWorkResultViewEntity)
        {
            CORP_CODE = pWorkResultViewEntity.CORP_CODE;
            CRUD = pWorkResultViewEntity.CRUD;
            USER_CODE = pWorkResultViewEntity.USER_CODE;

            pWorkResultViewEntity.DATE_FROM = DATE_FROM;
            pWorkResultViewEntity.DATE_TO = DATE_TO;
            pWorkResultViewEntity.CONTRACT_ID = CONTRACT_ID;
            pWorkResultViewEntity.PART_NAME = PART_NAME;
            pWorkResultViewEntity.VEND_CODE = VEND_CODE;
            pWorkResultViewEntity.VEND_NAME = VEND_NAME;
            pWorkResultViewEntity.CONTRACT_ID = CONTRACT_ID;

            pWorkResultViewEntity.CONTRACT_DATE = CONTRACT_DATE;
            pWorkResultViewEntity.CONTRACT_QTY = CONTRACT_QTY;
            pWorkResultViewEntity.DELIVERY_DATE = DELIVERY_DATE;
            pWorkResultViewEntity.DELIVERY_LOCATION = DELIVERY_LOCATION;
            pWorkResultViewEntity.UNITCOST = UNITCOST;
            pWorkResultViewEntity.COST = COST;
            pWorkResultViewEntity.REMARK = REMARK;
            pWorkResultViewEntity.USE_YN = USE_YN;
            pWorkResultViewEntity.USE_YN = UNIT_CODE;

            ERR_NO = pWorkResultViewEntity.ERR_NO;
            ERR_MSG = pWorkResultViewEntity.ERR_MSG;
            RTN_KEY = pWorkResultViewEntity.RTN_KEY;
            RTN_SEQ = pWorkResultViewEntity.RTN_SEQ;
            RTN_AQ = pWorkResultViewEntity.RTN_AQ;
            RTN_SQ = pWorkResultViewEntity.RTN_SQ;
            RTN_OTHERS = pWorkResultViewEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class WorkResultView2Entity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD

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

        #region 생성자 - WorkResultView2Entity()

        public WorkResultView2Entity()
        {

        }

        #endregion

        #region 생성자 - WorkResultView2Entity(pWorkResultView2Entity)

        public WorkResultView2Entity(WorkResultView2Entity pWorkResultView2Entity)
        {
            CORP_CODE = pWorkResultView2Entity.CORP_CODE;
            CRUD = pWorkResultView2Entity.CRUD;
            USER_CODE = pWorkResultView2Entity.USER_CODE;

            pWorkResultView2Entity.DATE_FROM = DATE_FROM;
            pWorkResultView2Entity.DATE_TO = DATE_TO;
            pWorkResultView2Entity.CONTRACT_ID = CONTRACT_ID;
            pWorkResultView2Entity.PART_NAME = PART_NAME;
            pWorkResultView2Entity.VEND_CODE = VEND_CODE;
            pWorkResultView2Entity.VEND_NAME = VEND_NAME;
            pWorkResultView2Entity.CONTRACT_ID = CONTRACT_ID;

            pWorkResultView2Entity.CONTRACT_DATE = CONTRACT_DATE;
            pWorkResultView2Entity.CONTRACT_QTY = CONTRACT_QTY;
            pWorkResultView2Entity.DELIVERY_DATE = DELIVERY_DATE;
            pWorkResultView2Entity.DELIVERY_LOCATION = DELIVERY_LOCATION;
            pWorkResultView2Entity.UNITCOST = UNITCOST;
            pWorkResultView2Entity.COST = COST;
            pWorkResultView2Entity.REMARK = REMARK;
            pWorkResultView2Entity.USE_YN = USE_YN;
            pWorkResultView2Entity.USE_YN = UNIT_CODE;

            ERR_NO = pWorkResultView2Entity.ERR_NO;
            ERR_MSG = pWorkResultView2Entity.ERR_MSG;
            RTN_KEY = pWorkResultView2Entity.RTN_KEY;
            RTN_SEQ = pWorkResultView2Entity.RTN_SEQ;
            RTN_AQ = pWorkResultView2Entity.RTN_AQ;
            RTN_SQ = pWorkResultView2Entity.RTN_SQ;
            RTN_OTHERS = pWorkResultView2Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }


    public class WorkResultView_DYEntity
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


        #endregion

        #region 생성자 - WorkResultView_DYEntity()

        public WorkResultView_DYEntity()
        {
        }

        #endregion

        #region 생성자 - WorkResultView_DYEntity(pWorkResultView_DYEntity)

        public WorkResultView_DYEntity(WorkResultView_DYEntity pWorkResultView_DYEntity)
        {
            CORP_CODE = pWorkResultView_DYEntity.CORP_CODE;
            CRUD = pWorkResultView_DYEntity.CRUD;
            USER_CODE = pWorkResultView_DYEntity.USER_CODE;

            ERR_NO = pWorkResultView_DYEntity.ERR_NO;
            ERR_MSG = pWorkResultView_DYEntity.ERR_MSG;
            RTN_KEY = pWorkResultView_DYEntity.RTN_KEY;
            RTN_SEQ = pWorkResultView_DYEntity.RTN_SEQ;
            RTN_OTHERS = pWorkResultView_DYEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }


    public class WorkResultView2_DYEntity
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


        #endregion

        #region 생성자 - WorkResultView_DYEntity()

        public WorkResultView2_DYEntity()
        {
        }

        #endregion

        #region 생성자 - WorkResultView_DYEntity(pWorkResultView_DYEntity)

        public WorkResultView2_DYEntity(WorkResultView_DYEntity pWorkResultView_DYEntity)
        {
            CORP_CODE = pWorkResultView_DYEntity.CORP_CODE;
            CRUD = pWorkResultView_DYEntity.CRUD;
            USER_CODE = pWorkResultView_DYEntity.USER_CODE;

            ERR_NO = pWorkResultView_DYEntity.ERR_NO;
            ERR_MSG = pWorkResultView_DYEntity.ERR_MSG;
            RTN_KEY = pWorkResultView_DYEntity.RTN_KEY;
            RTN_SEQ = pWorkResultView_DYEntity.RTN_SEQ;
            RTN_OTHERS = pWorkResultView_DYEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class TestDataStatusEntity
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
        public String PART_CODE { get; set; }
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

        #region 생성자 - TestDataStatusEntity()

        public TestDataStatusEntity()
        {
        }

        #endregion

        #region 생성자 - TestDataStatusEntity(pTestDataStatusEntity)

        public TestDataStatusEntity(TestDataStatusEntity pTestDataStatusEntity)
        {
            CORP_CODE = pTestDataStatusEntity.CORP_CODE;
            CRUD = pTestDataStatusEntity.CRUD;
            USER_CODE = pTestDataStatusEntity.USER_CODE;
            LANGUAGE_TYPE = pTestDataStatusEntity.LANGUAGE_TYPE;

            pTestDataStatusEntity.DATE_FROM = DATE_FROM;
            pTestDataStatusEntity.DATE_TO = DATE_TO;
            pTestDataStatusEntity.PART_CODE = PART_CODE;
            pTestDataStatusEntity.PART_NAME = PART_NAME;
            pTestDataStatusEntity.VEND_NAME = VEND_NAME;
            pTestDataStatusEntity.ORDER_ID = ORDER_ID;


            ERR_NO = pTestDataStatusEntity.ERR_NO;
            ERR_MSG = pTestDataStatusEntity.ERR_MSG;
            RTN_KEY = pTestDataStatusEntity.RTN_KEY;
            RTN_SEQ = pTestDataStatusEntity.RTN_SEQ;
            RTN_OTHERS = pTestDataStatusEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }


}

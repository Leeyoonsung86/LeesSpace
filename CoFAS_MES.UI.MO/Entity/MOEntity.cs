using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoFAS_MES.UI.MO.Entity
{
    public class SensorDataSearchEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE
        
        public String WINDOW_NAME { get; set; }
        public String FROM_DATE { get; set; }
        public String TO_DATE { get; set; }
        public String INTERVAL { get; set; }
        public String RESOURCE_CODE { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - SensorDataSearchEntity()

        public SensorDataSearchEntity()
        {
        }

        #endregion

        #region 생성자 - SensorDataSearchEntity(pSensorDataSearchEntity)

        public SensorDataSearchEntity(SensorDataSearchEntity pSensorDataSearchEntity)
        {
            CORP_CODE = pSensorDataSearchEntity.CORP_CODE;
            CRUD = pSensorDataSearchEntity.CRUD;
            USER_CODE = pSensorDataSearchEntity.USER_CODE;
            LANGUAGE_TYPE = pSensorDataSearchEntity.LANGUAGE_TYPE;

            pSensorDataSearchEntity.FROM_DATE = FROM_DATE;
            pSensorDataSearchEntity.TO_DATE = TO_DATE;
            pSensorDataSearchEntity.INTERVAL = INTERVAL;
            pSensorDataSearchEntity.RESOURCE_CODE = RESOURCE_CODE;
            WINDOW_NAME = pSensorDataSearchEntity.WINDOW_NAME;
            ERR_NO = pSensorDataSearchEntity.ERR_NO;
            ERR_MSG = pSensorDataSearchEntity.ERR_MSG;
            RTN_KEY = pSensorDataSearchEntity.RTN_KEY;
            RTN_SEQ = pSensorDataSearchEntity.RTN_SEQ;
            RTN_OTHERS = pSensorDataSearchEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class SensorStatusSeacrhEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE

        public String WINDOW_NAME { get; set; }
        public String FROM_DATE { get; set; }
        public String TO_DATE { get; set; }
        public String INTERVAL { get; set; }
        public String RESOURCE_CODE { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - SensorDataSearchEntity()

        public SensorStatusSeacrhEntity()
        {
        }

        #endregion

        #region 생성자 - SensorDataSearchEntity(pSensorDataSearchEntity)

        public SensorStatusSeacrhEntity(SensorStatusSeacrhEntity pSensorStatusSeacrhEntity)
        {
            CORP_CODE = pSensorStatusSeacrhEntity.CORP_CODE;
            CRUD = pSensorStatusSeacrhEntity.CRUD;
            USER_CODE = pSensorStatusSeacrhEntity.USER_CODE;
            LANGUAGE_TYPE = pSensorStatusSeacrhEntity.LANGUAGE_TYPE;

            pSensorStatusSeacrhEntity.FROM_DATE = FROM_DATE;
            pSensorStatusSeacrhEntity.TO_DATE = TO_DATE;
            pSensorStatusSeacrhEntity.INTERVAL = INTERVAL;
            pSensorStatusSeacrhEntity.RESOURCE_CODE = RESOURCE_CODE;
            WINDOW_NAME = pSensorStatusSeacrhEntity.WINDOW_NAME;
            ERR_NO = pSensorStatusSeacrhEntity.ERR_NO;
            ERR_MSG = pSensorStatusSeacrhEntity.ERR_MSG;
            RTN_KEY = pSensorStatusSeacrhEntity.RTN_KEY;
            RTN_SEQ = pSensorStatusSeacrhEntity.RTN_SEQ;
            RTN_OTHERS = pSensorStatusSeacrhEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class SensorStatusSeacrh_T01Entity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE

        public String WINDOW_NAME { get; set; }
        public String FROM_DATE { get; set; }
        public String TO_DATE { get; set; }
        public String INTERVAL { get; set; }
        public String RESOURCE_CODE { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - SensorDataSearchEntity()

        public SensorStatusSeacrh_T01Entity()
        {
        }

        #endregion

        #region 생성자 - SensorDataSearchEntity(pSensorDataSearchEntity)

        public SensorStatusSeacrh_T01Entity(SensorStatusSeacrh_T01Entity pSensorStatusSeacrh_T01Entity)
        {
            CORP_CODE = pSensorStatusSeacrh_T01Entity.CORP_CODE;
            CRUD = pSensorStatusSeacrh_T01Entity.CRUD;
            USER_CODE = pSensorStatusSeacrh_T01Entity.USER_CODE;
            LANGUAGE_TYPE = pSensorStatusSeacrh_T01Entity.LANGUAGE_TYPE;

            pSensorStatusSeacrh_T01Entity.FROM_DATE = FROM_DATE;
            pSensorStatusSeacrh_T01Entity.TO_DATE = TO_DATE;
            pSensorStatusSeacrh_T01Entity.INTERVAL = INTERVAL;
            pSensorStatusSeacrh_T01Entity.RESOURCE_CODE = RESOURCE_CODE;
            WINDOW_NAME = pSensorStatusSeacrh_T01Entity.WINDOW_NAME;
            ERR_NO = pSensorStatusSeacrh_T01Entity.ERR_NO;
            ERR_MSG = pSensorStatusSeacrh_T01Entity.ERR_MSG;
            RTN_KEY = pSensorStatusSeacrh_T01Entity.RTN_KEY;
            RTN_SEQ = pSensorStatusSeacrh_T01Entity.RTN_SEQ;
            RTN_OTHERS = pSensorStatusSeacrh_T01Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class SensorViewEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE

        public String WINDOW_NAME { get; set; }
    
        public String INTERVAL { get; set; }
    
        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - SensorViewEntity()

        public SensorViewEntity()
        {
        }

        #endregion

        #region 생성자 - SensorViewEntity(pSensorViewEntity)

        public SensorViewEntity(SensorViewEntity pSensorViewEntity)
        {
            CORP_CODE = pSensorViewEntity.CORP_CODE;
            CRUD = pSensorViewEntity.CRUD;
            USER_CODE = pSensorViewEntity.USER_CODE;
            LANGUAGE_TYPE = pSensorViewEntity.LANGUAGE_TYPE;

          
            WINDOW_NAME = pSensorViewEntity.WINDOW_NAME;
            ERR_NO = pSensorViewEntity.ERR_NO;
            ERR_MSG = pSensorViewEntity.ERR_MSG;
            RTN_KEY = pSensorViewEntity.RTN_KEY;
            RTN_SEQ = pSensorViewEntity.RTN_SEQ;
            RTN_OTHERS = pSensorViewEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class DoorOpeningClosingStatusEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE

        public String WINDOW_NAME { get; set; }
        public String FROM_DATE { get; set; }
        public String TO_DATE { get; set; }
        public String INTERVAL { get; set; }
        public String RESOURCE_CODE { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - DoorOpeningClosingStatusEntity()

        public DoorOpeningClosingStatusEntity()
        {
        }

        #endregion

        #region 생성자 - DoorOpeningClosingStatusEntity(pDoorOpeningClosingStatusEntity)

        public DoorOpeningClosingStatusEntity(DoorOpeningClosingStatusEntity pDoorOpeningClosingStatusEntity)
        {
            CORP_CODE = pDoorOpeningClosingStatusEntity.CORP_CODE;
            CRUD = pDoorOpeningClosingStatusEntity.CRUD;
            USER_CODE = pDoorOpeningClosingStatusEntity.USER_CODE;
            LANGUAGE_TYPE = pDoorOpeningClosingStatusEntity.LANGUAGE_TYPE;

            pDoorOpeningClosingStatusEntity.FROM_DATE = FROM_DATE;
            pDoorOpeningClosingStatusEntity.TO_DATE = TO_DATE;
            pDoorOpeningClosingStatusEntity.INTERVAL = INTERVAL;
            pDoorOpeningClosingStatusEntity.RESOURCE_CODE = RESOURCE_CODE;
            WINDOW_NAME = pDoorOpeningClosingStatusEntity.WINDOW_NAME;
            ERR_NO = pDoorOpeningClosingStatusEntity.ERR_NO;
            ERR_MSG = pDoorOpeningClosingStatusEntity.ERR_MSG;
            RTN_KEY = pDoorOpeningClosingStatusEntity.RTN_KEY;
            RTN_SEQ = pDoorOpeningClosingStatusEntity.RTN_SEQ;
            RTN_OTHERS = pDoorOpeningClosingStatusEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class Gathering_InfoEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE

        public String WINDOW_NAME { get; set; }
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

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String SensorCnt { get; set; }
        public String USE_YN { get; set; }
        public String TEAMVIEWER_VEND { get; set; }
        public String TEAMVIEWER_PW { get; set; }
        public String TEAMVIEWER_NAME { get; set; }
        public String TEAMVIEWER_ID { get; set; }
        public String TEAMVIEWER_ADMIN { get; set; }
        public String REMARK { get; set; }
        public String PART_NAME { get; set; }
        public String PART_CODE { get; set; }

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - Gathering_InfoEntity()

        public Gathering_InfoEntity()
        {

        }

        #endregion

        #region 생성자 - Gathering_InfoEntity(pGathering_InfoEntity)

        public Gathering_InfoEntity(Gathering_InfoEntity pGathering_InfoEntity)
        {
            CORP_CODE = pGathering_InfoEntity.CORP_CODE;
            CRUD = pGathering_InfoEntity.CRUD;
            USER_CODE = pGathering_InfoEntity.USER_CODE;
            LANGUAGE_TYPE = pGathering_InfoEntity.LANGUAGE_TYPE;

            pGathering_InfoEntity.FROM_DATE = FROM_DATE;
            pGathering_InfoEntity.TO_DATE = TO_DATE;
            pGathering_InfoEntity.INTERVAL = INTERVAL;
            pGathering_InfoEntity.RESOURCE_CODE = RESOURCE_CODE;
            pGathering_InfoEntity.RESOURCE_MIN_1 = RESOURCE_MIN_1;
            pGathering_InfoEntity.RESOURCE_MAX_1 = RESOURCE_MAX_1;
            pGathering_InfoEntity.RESOURCE_MIN_2 = RESOURCE_MIN_2;
            pGathering_InfoEntity.RESOURCE_MAX_2 = RESOURCE_MAX_2;
            pGathering_InfoEntity.RESOURCE_MIN_3 = RESOURCE_MIN_3;
            pGathering_InfoEntity.RESOURCE_MAX_3 = RESOURCE_MAX_3;
            pGathering_InfoEntity.RESOURCE_MIN_4 = RESOURCE_MIN_4;
            pGathering_InfoEntity.RESOURCE_MAX_4 = RESOURCE_MAX_4;
            pGathering_InfoEntity.RESOURCE_MIN_5 = RESOURCE_MIN_5;
            pGathering_InfoEntity.RESOURCE_MAX_5 = RESOURCE_MAX_5;
            pGathering_InfoEntity.REMARK = REMARK;
            WINDOW_NAME = pGathering_InfoEntity.WINDOW_NAME;
            SensorCnt = pGathering_InfoEntity.SensorCnt;
            ERR_NO = pGathering_InfoEntity.ERR_NO;
            ERR_MSG = pGathering_InfoEntity.ERR_MSG;
            RTN_KEY = pGathering_InfoEntity.RTN_KEY;
            RTN_SEQ = pGathering_InfoEntity.RTN_SEQ;
            RTN_OTHERS = pGathering_InfoEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion
    } // 게더링 수식등록 화면입니다.

    public class DPSSetting_mstEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE

        public String WINDOW_NAME { get; set; }
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
        public String MODE { get; set; }
        public String GATHERING_ID { get; set;}
        public String GATHERING_CODE { get; set; }
        public String GATHERING_NAME { get; set; }
        public String GATHERING_IP { get; set; }
        public String GATHERING_PORT { get; set; }
        public String GATHERING_INTERVAL { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String SensorCnt { get; set; }
        public String USE_YN { get; set; }
        public String TEAMVIEWER_VEND { get; set; }
        public String TEAMVIEWER_PW { get; set; }
        public String TEAMVIEWER_NAME { get; set; }
        public String TEAMVIEWER_ID { get; set; }
        public String TEAMVIEWER_ADMIN { get; set; }
        public String REMARK { get; set; }
        public String PART_NAME { get; set; }
        public String PART_CODE { get; set; }
        public String GATHERING_GUBN { get; set; }

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - DPSSetting_mstEntity()

        public DPSSetting_mstEntity()
        {

        }

        #endregion

        #region 생성자 - DPSSetting_mstEntity(pDPSSetting_mstEntity)

        public DPSSetting_mstEntity(DPSSetting_mstEntity pDPSSetting_mstEntity)
        {
            CORP_CODE = pDPSSetting_mstEntity.CORP_CODE;
            CRUD = pDPSSetting_mstEntity.CRUD;
            USER_CODE = pDPSSetting_mstEntity.USER_CODE;
            LANGUAGE_TYPE = pDPSSetting_mstEntity.LANGUAGE_TYPE;

            pDPSSetting_mstEntity.FROM_DATE = FROM_DATE;
            pDPSSetting_mstEntity.TO_DATE = TO_DATE;
            pDPSSetting_mstEntity.INTERVAL = INTERVAL;
            pDPSSetting_mstEntity.RESOURCE_CODE = RESOURCE_CODE;
            pDPSSetting_mstEntity.RESOURCE_MIN_1 = RESOURCE_MIN_1;
            pDPSSetting_mstEntity.RESOURCE_MAX_1 = RESOURCE_MAX_1;
            pDPSSetting_mstEntity.RESOURCE_MIN_2 = RESOURCE_MIN_2;
            pDPSSetting_mstEntity.RESOURCE_MAX_2 = RESOURCE_MAX_2;
            pDPSSetting_mstEntity.RESOURCE_MIN_3 = RESOURCE_MIN_3;
            pDPSSetting_mstEntity.RESOURCE_MAX_3 = RESOURCE_MAX_3;
            pDPSSetting_mstEntity.RESOURCE_MIN_4 = RESOURCE_MIN_4;
            pDPSSetting_mstEntity.RESOURCE_MAX_4 = RESOURCE_MAX_4;
            pDPSSetting_mstEntity.RESOURCE_MIN_5 = RESOURCE_MIN_5;
            pDPSSetting_mstEntity.RESOURCE_MAX_5 = RESOURCE_MAX_5;
            pDPSSetting_mstEntity.REMARK = REMARK;
            WINDOW_NAME = pDPSSetting_mstEntity.WINDOW_NAME;
            SensorCnt = pDPSSetting_mstEntity.SensorCnt;
            ERR_NO = pDPSSetting_mstEntity.ERR_NO;
            ERR_MSG = pDPSSetting_mstEntity.ERR_MSG;
            RTN_KEY = pDPSSetting_mstEntity.RTN_KEY;
            RTN_SEQ = pDPSSetting_mstEntity.RTN_SEQ;
            RTN_OTHERS = pDPSSetting_mstEntity.RTN_OTHERS;
            MODE = pDPSSetting_mstEntity.MODE;
            GATHERING_ID = pDPSSetting_mstEntity.GATHERING_ID;
            GATHERING_CODE = pDPSSetting_mstEntity.GATHERING_CODE;
            GATHERING_INTERVAL = pDPSSetting_mstEntity.GATHERING_INTERVAL;
            GATHERING_IP = pDPSSetting_mstEntity.GATHERING_IP;
            GATHERING_NAME = pDPSSetting_mstEntity.GATHERING_NAME;
            GATHERING_PORT = pDPSSetting_mstEntity.GATHERING_PORT;
            GATHERING_GUBN = pDPSSetting_mstEntity.GATHERING_GUBN;

            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

}

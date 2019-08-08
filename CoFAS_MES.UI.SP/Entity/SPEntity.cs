using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoFAS_MES.UI.SP.Entity
{
    public class ShipmentPlanRegisterEntity
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

        #endregion

        #region 생성자 - ShipmentPlanRegisterEntity()

        public ShipmentPlanRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - ShipmentPlanRegisterEntity(pShipmentPlanRegisterEntity)

        public ShipmentPlanRegisterEntity(ShipmentPlanRegisterEntity pShipmentPlanRegisterEntity)
        {
            CORP_CODE = pShipmentPlanRegisterEntity.CORP_CODE;
            CRUD = pShipmentPlanRegisterEntity.CRUD;
            USER_CODE = pShipmentPlanRegisterEntity.USER_CODE;
            ERR_NO = pShipmentPlanRegisterEntity.ERR_NO;
            ERR_MSG = pShipmentPlanRegisterEntity.ERR_MSG;
            RTN_KEY = pShipmentPlanRegisterEntity.RTN_KEY;
            RTN_SEQ = pShipmentPlanRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pShipmentPlanRegisterEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            WINDOW_NAME = pShipmentPlanRegisterEntity.WINDOW_NAME;
        }
        #endregion

    }

    public class ShipmentRegisterEntity
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

        //고정 엔티티


        //메뉴별 추가 엔티티 입력
        public String WINDOW_NAME { get; set; }

        // 조회조건
        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        public String VEND_CODE { get; set; }
        public String VEND_NAME { get; set; }
        public String PART_NAME { get; set; }

        // 상세내역
        public String SHIPMENT_ID { get; set; }
        public String SHIPMENT_DATE { get; set; }
        public String SHIPMENT_SEQ { get; set; }
        public String PART_CODE { get; set; }
        public String SHIPMENT_ORDER_QTY { get; set; }
        public String SHIPMENT_STATE { get; set; }
        public String REFERENCE_ID { get; set; }
        public String REMARK { get; set; }
        public String USE_YN { get; set; }



        #endregion

        #region 생성자 - ShipmentRegisterEntity()

        public ShipmentRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - ShipmentRegisterEntity(pShipmentRegisterEntity)

        public ShipmentRegisterEntity(ShipmentRegisterEntity pShipmentRegisterEntity)
        {
            CORP_CODE = pShipmentRegisterEntity.CORP_CODE;
            CRUD = pShipmentRegisterEntity.CRUD;
            USER_CODE = pShipmentRegisterEntity.USER_CODE;
            LANGUAGE_TYPE = pShipmentRegisterEntity.LANGUAGE_TYPE;

            ERR_NO = pShipmentRegisterEntity.ERR_NO;
            ERR_MSG = pShipmentRegisterEntity.ERR_MSG;
            RTN_KEY = pShipmentRegisterEntity.RTN_KEY;
            RTN_SEQ = pShipmentRegisterEntity.RTN_SEQ;
            RTN_AQ = pShipmentRegisterEntity.RTN_AQ;
            RTN_SQ = pShipmentRegisterEntity.RTN_SQ;
            RTN_OTHERS = pShipmentRegisterEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            WINDOW_NAME = pShipmentRegisterEntity.WINDOW_NAME;
            DATE_FROM = pShipmentRegisterEntity.DATE_FROM;
            DATE_TO = pShipmentRegisterEntity.DATE_TO;
            VEND_CODE = pShipmentRegisterEntity.VEND_CODE;
            VEND_NAME = pShipmentRegisterEntity.VEND_NAME;
            PART_NAME = pShipmentRegisterEntity.PART_NAME;

            SHIPMENT_ID = pShipmentRegisterEntity.SHIPMENT_ID;
            SHIPMENT_DATE = pShipmentRegisterEntity.SHIPMENT_DATE;
            SHIPMENT_SEQ = pShipmentRegisterEntity.SHIPMENT_SEQ;
            PART_CODE = pShipmentRegisterEntity.PART_CODE;
            SHIPMENT_ORDER_QTY = pShipmentRegisterEntity.SHIPMENT_ORDER_QTY;
            SHIPMENT_STATE = pShipmentRegisterEntity.SHIPMENT_STATE;
            REFERENCE_ID = pShipmentRegisterEntity.REFERENCE_ID;
            REMARK = pShipmentRegisterEntity.REMARK;
            USE_YN = pShipmentRegisterEntity.USE_YN;
        }
        #endregion

    }

    public class ShipmentBaseRegister_T50Entity
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

        //고정 엔티티


        //메뉴별 추가 엔티티 입력
        public String WINDOW_NAME { get; set; }

        // 조회조건
        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        public String VEND_CODE { get; set; }
        public String VEND_NAME { get; set; }
        public String PART_NAME { get; set; }
        public String TRACKING_NO { get; set; }

        // 상세내역
        public String SHIPMENT_ID { get; set; }
        public String SHIPMENT_DATE { get; set; }
        public String SHIPMENT_SEQ { get; set; }
        public String PART_CODE { get; set; }
        public String SHIPMENT_ORDER_QTY { get; set; }
        public String SHIPMENT_STATE { get; set; }
        public String REFERENCE_ID { get; set; }
        public String REMARK { get; set; }
        public String USE_YN { get; set; }



        #endregion

        #region 생성자 - ShipmentBaseRegister_T50Entity()

        public ShipmentBaseRegister_T50Entity()
        {
        }

        #endregion

        #region 생성자 - ShipmentBaseRegister_T50Entity(pShipmentBaseRegister_T50Entity)

        public ShipmentBaseRegister_T50Entity(ShipmentBaseRegister_T50Entity pShipmentBaseRegister_T50Entity)
        {
            CORP_CODE = pShipmentBaseRegister_T50Entity.CORP_CODE;
            CRUD = pShipmentBaseRegister_T50Entity.CRUD;
            USER_CODE = pShipmentBaseRegister_T50Entity.USER_CODE;
            LANGUAGE_TYPE = pShipmentBaseRegister_T50Entity.LANGUAGE_TYPE;

            ERR_NO = pShipmentBaseRegister_T50Entity.ERR_NO;
            ERR_MSG = pShipmentBaseRegister_T50Entity.ERR_MSG;
            RTN_KEY = pShipmentBaseRegister_T50Entity.RTN_KEY;
            RTN_SEQ = pShipmentBaseRegister_T50Entity.RTN_SEQ;
            RTN_AQ = pShipmentBaseRegister_T50Entity.RTN_AQ;
            RTN_SQ = pShipmentBaseRegister_T50Entity.RTN_SQ;
            RTN_OTHERS = pShipmentBaseRegister_T50Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            WINDOW_NAME = pShipmentBaseRegister_T50Entity.WINDOW_NAME;
            DATE_FROM = pShipmentBaseRegister_T50Entity.DATE_FROM;
            DATE_TO = pShipmentBaseRegister_T50Entity.DATE_TO;
            VEND_CODE = pShipmentBaseRegister_T50Entity.VEND_CODE;
            VEND_NAME = pShipmentBaseRegister_T50Entity.VEND_NAME;
            PART_NAME = pShipmentBaseRegister_T50Entity.PART_NAME;
            TRACKING_NO = pShipmentBaseRegister_T50Entity.TRACKING_NO;
            SHIPMENT_ID = pShipmentBaseRegister_T50Entity.SHIPMENT_ID;
            SHIPMENT_DATE = pShipmentBaseRegister_T50Entity.SHIPMENT_DATE;
            SHIPMENT_SEQ = pShipmentBaseRegister_T50Entity.SHIPMENT_SEQ;
            PART_CODE = pShipmentBaseRegister_T50Entity.PART_CODE;
            SHIPMENT_ORDER_QTY = pShipmentBaseRegister_T50Entity.SHIPMENT_ORDER_QTY;
            SHIPMENT_STATE = pShipmentBaseRegister_T50Entity.SHIPMENT_STATE;
            REFERENCE_ID = pShipmentBaseRegister_T50Entity.REFERENCE_ID;
            REMARK = pShipmentBaseRegister_T50Entity.REMARK;
            USE_YN = pShipmentBaseRegister_T50Entity.USE_YN;
        }
        #endregion

    }
    public class ShipmentRegister_T01Entity
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

        //고정 엔티티


        //메뉴별 추가 엔티티 입력
        public String WINDOW_NAME { get; set; }

        // 조회조건
        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        public String VEND_CODE { get; set; }
        public String VEND_NAME { get; set; }
        public String PART_NAME { get; set; }
        public String INVSTCD { get; set; }
        public String LOT_NO { get; set; }
        public String INDATE { get; set; }

        // 상세내역
        public String SHIPMENT_ID { get; set; }
        public String CONTRACT_ID { get; set; }
        public String SHIPMENT_DATE { get; set; }
        public String SHIPMENT_SEQ { get; set; }
        public String PART_CODE { get; set; }
        public String SHIPMENT_ORDER_QTY { get; set; }
        public String SHIPMENT_STATE { get; set; }
        public String REFERENCE_ID { get; set; }
        public String OUT_QTY { get; set; }
        public String REMARK { get; set; }
        public String USE_YN { get; set; }



        #endregion

        #region 생성자 - ShipmentRegister_T01Entity()

        public ShipmentRegister_T01Entity()
        {
        }

        #endregion

        #region 생성자 - ShipmentRegister_T01Entity(pShipmentRegister_T01Entity)

        public ShipmentRegister_T01Entity(ShipmentRegister_T01Entity pShipmentRegister_T01Entity)
        {
            CORP_CODE = pShipmentRegister_T01Entity.CORP_CODE;
            CRUD = pShipmentRegister_T01Entity.CRUD;
            USER_CODE = pShipmentRegister_T01Entity.USER_CODE;
            LANGUAGE_TYPE = pShipmentRegister_T01Entity.LANGUAGE_TYPE;

            ERR_NO = pShipmentRegister_T01Entity.ERR_NO;
            ERR_MSG = pShipmentRegister_T01Entity.ERR_MSG;
            RTN_KEY = pShipmentRegister_T01Entity.RTN_KEY;
            RTN_SEQ = pShipmentRegister_T01Entity.RTN_SEQ;
            RTN_AQ = pShipmentRegister_T01Entity.RTN_AQ;
            RTN_SQ = pShipmentRegister_T01Entity.RTN_SQ;
            RTN_OTHERS = pShipmentRegister_T01Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            WINDOW_NAME = pShipmentRegister_T01Entity.WINDOW_NAME;
            DATE_FROM = pShipmentRegister_T01Entity.DATE_FROM;
            DATE_TO = pShipmentRegister_T01Entity.DATE_TO;
            VEND_CODE = pShipmentRegister_T01Entity.VEND_CODE;
            VEND_NAME = pShipmentRegister_T01Entity.VEND_NAME;
            PART_NAME = pShipmentRegister_T01Entity.PART_NAME;
            LOT_NO = pShipmentRegister_T01Entity.LOT_NO;
            SHIPMENT_ID = pShipmentRegister_T01Entity.SHIPMENT_ID;
            CONTRACT_ID = pShipmentRegister_T01Entity.CONTRACT_ID;
            SHIPMENT_DATE = pShipmentRegister_T01Entity.SHIPMENT_DATE;
            SHIPMENT_SEQ = pShipmentRegister_T01Entity.SHIPMENT_SEQ;
            PART_CODE = pShipmentRegister_T01Entity.PART_CODE;
            OUT_QTY = pShipmentRegister_T01Entity.OUT_QTY;
            SHIPMENT_ORDER_QTY = pShipmentRegister_T01Entity.SHIPMENT_ORDER_QTY;
            SHIPMENT_STATE = pShipmentRegister_T01Entity.SHIPMENT_STATE;
            REFERENCE_ID = pShipmentRegister_T01Entity.REFERENCE_ID;
            REMARK = pShipmentRegister_T01Entity.REMARK;
            USE_YN = pShipmentRegister_T01Entity.USE_YN;
            INVSTCD = pShipmentRegister_T01Entity.INVSTCD;
            INDATE = pShipmentRegister_T01Entity.INDATE;
        }
        #endregion

    }

    public class ucShipmentRegisterInfoPopupEntity
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

        //고정 엔티티


        //메뉴별 추가 엔티티 입력
        public String WINDOW_NAME { get; set; }
        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        public String PART_NAME { get; set; }


        #endregion

        #region 생성자 - ucShipmentRegisterInfoPopupEntity()

        public ucShipmentRegisterInfoPopupEntity()
        {
        }

        #endregion

        #region 생성자 - ucShipmentRegisterInfoPopupEntity(pucShipmentRegisterInfoPopupEntity)

        public ucShipmentRegisterInfoPopupEntity(ucShipmentRegisterInfoPopupEntity pucShipmentRegisterInfoPopupEntity)
        {
            CORP_CODE = pucShipmentRegisterInfoPopupEntity.CORP_CODE;
            CRUD = pucShipmentRegisterInfoPopupEntity.CRUD;
            USER_CODE = pucShipmentRegisterInfoPopupEntity.USER_CODE;
            LANGUAGE_TYPE = pucShipmentRegisterInfoPopupEntity.LANGUAGE_TYPE;

            ERR_NO = pucShipmentRegisterInfoPopupEntity.ERR_NO;
            ERR_MSG = pucShipmentRegisterInfoPopupEntity.ERR_MSG;
            RTN_KEY = pucShipmentRegisterInfoPopupEntity.RTN_KEY;
            RTN_SEQ = pucShipmentRegisterInfoPopupEntity.RTN_SEQ;
            RTN_AQ = pucShipmentRegisterInfoPopupEntity.RTN_AQ;
            RTN_SQ = pucShipmentRegisterInfoPopupEntity.RTN_SQ;
            RTN_OTHERS = pucShipmentRegisterInfoPopupEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            WINDOW_NAME = pucShipmentRegisterInfoPopupEntity.WINDOW_NAME;
            DATE_FROM = pucShipmentRegisterInfoPopupEntity.DATE_FROM;
            DATE_TO = pucShipmentRegisterInfoPopupEntity.DATE_TO;
            PART_NAME = pucShipmentRegisterInfoPopupEntity.PART_NAME;
        }
        #endregion
    }

    public class ucShipmentRegisterInfoPopup_T01Entity
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

        //고정 엔티티


        //메뉴별 추가 엔티티 입력
        public String WINDOW_NAME { get; set; }
        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        public String PART_NAME { get; set; }


        #endregion

        #region 생성자 - ucShipmentRegisterInfoPopup_T01Entity()

        public ucShipmentRegisterInfoPopup_T01Entity()
        {
        }

        #endregion

        #region 생성자 - ucShipmentRegisterInfoPopup_T01Entity(pucShipmentRegisterInfoPopup_T01Entity)

        public ucShipmentRegisterInfoPopup_T01Entity(ucShipmentRegisterInfoPopup_T01Entity pucShipmentRegisterInfoPopup_T01Entity)
        {
            CORP_CODE = pucShipmentRegisterInfoPopup_T01Entity.CORP_CODE;
            CRUD = pucShipmentRegisterInfoPopup_T01Entity.CRUD;
            USER_CODE = pucShipmentRegisterInfoPopup_T01Entity.USER_CODE;
            LANGUAGE_TYPE = pucShipmentRegisterInfoPopup_T01Entity.LANGUAGE_TYPE;

            ERR_NO = pucShipmentRegisterInfoPopup_T01Entity.ERR_NO;
            ERR_MSG = pucShipmentRegisterInfoPopup_T01Entity.ERR_MSG;
            RTN_KEY = pucShipmentRegisterInfoPopup_T01Entity.RTN_KEY;
            RTN_SEQ = pucShipmentRegisterInfoPopup_T01Entity.RTN_SEQ;
            RTN_AQ = pucShipmentRegisterInfoPopup_T01Entity.RTN_AQ;
            RTN_SQ = pucShipmentRegisterInfoPopup_T01Entity.RTN_SQ;
            RTN_OTHERS = pucShipmentRegisterInfoPopup_T01Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            WINDOW_NAME = pucShipmentRegisterInfoPopup_T01Entity.WINDOW_NAME;
            DATE_FROM = pucShipmentRegisterInfoPopup_T01Entity.DATE_FROM;
            DATE_TO = pucShipmentRegisterInfoPopup_T01Entity.DATE_TO;
            PART_NAME = pucShipmentRegisterInfoPopup_T01Entity.PART_NAME;
        }
        #endregion
    }

    public class ProductOutRegister_T01Entity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE
        public String WINDOW_NAME { get; set; } // WINDOW_NAME
        public String USER_NAME { get; set; } // WINDOW_NAME

        
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
        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - ProductOutRegister_T01Entity()

        public ProductOutRegister_T01Entity()
        {
        }

        #endregion

        #region 생성자 - ProductOutRegister_T01Entity(ProductOutRegister_T01Entity pMaterialInRegisterEntity)

        public ProductOutRegister_T01Entity(ProductOutRegister_T01Entity pProductOutRegister_T01Entity)
        {
            CORP_CODE = pProductOutRegister_T01Entity.CORP_CODE;
            CRUD = pProductOutRegister_T01Entity.CRUD;
            USER_CODE = pProductOutRegister_T01Entity.USER_CODE;
            LANGUAGE_TYPE = pProductOutRegister_T01Entity.LANGUAGE_TYPE;
            WINDOW_NAME = pProductOutRegister_T01Entity.WINDOW_NAME;

            ERR_NO = pProductOutRegister_T01Entity.ERR_NO;
            ERR_MSG = pProductOutRegister_T01Entity.ERR_MSG;
            RTN_KEY = pProductOutRegister_T01Entity.RTN_KEY;
            RTN_SEQ = pProductOutRegister_T01Entity.RTN_SEQ;
            RTN_OTHERS = pProductOutRegister_T01Entity.RTN_OTHERS;

            INOUT_ID = pProductOutRegister_T01Entity.INOUT_ID;
            INOUT_DATE = pProductOutRegister_T01Entity.INOUT_DATE;
            INOUT_SEQ = pProductOutRegister_T01Entity.INOUT_SEQ;
            INOUT_TYPE = pProductOutRegister_T01Entity.INOUT_TYPE;
            REFERENCE_ID = pProductOutRegister_T01Entity.REFERENCE_ID;
            PART_CODE = pProductOutRegister_T01Entity.PART_CODE;
            PART_NAME = pProductOutRegister_T01Entity.PART_NAME;
            VEND_CODE = pProductOutRegister_T01Entity.VEND_CODE;
            VEND_NAME = pProductOutRegister_T01Entity.VEND_NAME;
            INOUT_QTY = pProductOutRegister_T01Entity.INOUT_QTY;
            UNITCOST_CURRENCY_CODE = pProductOutRegister_T01Entity.UNITCOST_CURRENCY_CODE;
            UNITCOST = pProductOutRegister_T01Entity.UNITCOST;
            COST = pProductOutRegister_T01Entity.COST;
            REMARK = pProductOutRegister_T01Entity.REMARK;
            INOUT_CODE = pProductOutRegister_T01Entity.INOUT_CODE;
            USE_YN = pProductOutRegister_T01Entity.USE_YN;
            DATE_FROM = pProductOutRegister_T01Entity.DATE_FROM;
            DATE_TO = pProductOutRegister_T01Entity.DATE_TO;
            //메뉴별 추가 엔티티 입력
            USER_NAME = pProductOutRegister_T01Entity.USER_NAME;
        }

        #endregion

    }
    public class ucSemiProductStockInfoMaterialPopupEntity
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
        public String INOUT_CODE { get; set; } //
        public String VEND_ANME { get; set; } //

        #endregion

        #region 생성자 - ucSemiProductStockInfoMaterialPopupEntity()

        public ucSemiProductStockInfoMaterialPopupEntity()
        {
        }

        #endregion

        #region 생성자 - ucSemiProductStockInfoMaterialPopupEntity(pucSemiProductStockInfoMaterialPopupEntity)

        public ucSemiProductStockInfoMaterialPopupEntity(ucSemiProductStockInfoMaterialPopupEntity pucSemiProductStockInfoMaterialPopupEntity)
        {
            CORP_CODE = pucSemiProductStockInfoMaterialPopupEntity.CORP_CODE;
            CRUD = pucSemiProductStockInfoMaterialPopupEntity.CRUD;
            USER_CODE = pucSemiProductStockInfoMaterialPopupEntity.USER_CODE;

            LANGUAGE_TYPE = pucSemiProductStockInfoMaterialPopupEntity.LANGUAGE_TYPE;


            pucSemiProductStockInfoMaterialPopupEntity.WINDOW_NAME = WINDOW_NAME;

            pucSemiProductStockInfoMaterialPopupEntity.DATE_FROM = DATE_FROM;
            pucSemiProductStockInfoMaterialPopupEntity.DATE_TO = DATE_TO;
            pucSemiProductStockInfoMaterialPopupEntity.PROCESS_CODE = PROCESS_CODE;
            pucSemiProductStockInfoMaterialPopupEntity.INOUT_CODE = INOUT_CODE;

            ERR_NO = pucSemiProductStockInfoMaterialPopupEntity.ERR_NO;
            ERR_MSG = pucSemiProductStockInfoMaterialPopupEntity.ERR_MSG;
            RTN_KEY = pucSemiProductStockInfoMaterialPopupEntity.RTN_KEY;
            RTN_SEQ = pucSemiProductStockInfoMaterialPopupEntity.RTN_SEQ;
            RTN_OTHERS = pucSemiProductStockInfoMaterialPopupEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }
    public class ucProductionOrderInfoPopup_T05_Entity
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

        #region 생성자 - ucProductionOrderInfoPopup_T05_Entity()

        public ucProductionOrderInfoPopup_T05_Entity()
        {
        }

        #endregion

        #region 생성자 - ucProductionOrderInfoPopup_T05_Entity(ucProductionOrderInfoPopup_T05_Entity pucProductionOrderInfoPopup_T05_Entity)

        public ucProductionOrderInfoPopup_T05_Entity(ucProductionOrderInfoPopup_T05_Entity pucProductionOrderInfoPopup_T05_Entity)
        {
            CORP_CODE = pucProductionOrderInfoPopup_T05_Entity.CORP_CODE;
            CRUD = pucProductionOrderInfoPopup_T05_Entity.CRUD;
            USER_CODE = pucProductionOrderInfoPopup_T05_Entity.USER_CODE;
            LANGUAGE_TYPE = pucProductionOrderInfoPopup_T05_Entity.LANGUAGE_TYPE;

            ERR_NO = pucProductionOrderInfoPopup_T05_Entity.ERR_NO;
            ERR_MSG = pucProductionOrderInfoPopup_T05_Entity.ERR_MSG;
            RTN_KEY = pucProductionOrderInfoPopup_T05_Entity.RTN_KEY;
            RTN_SEQ = pucProductionOrderInfoPopup_T05_Entity.RTN_SEQ;
            RTN_AQ = pucProductionOrderInfoPopup_T05_Entity.RTN_AQ;
            RTN_SQ = pucProductionOrderInfoPopup_T05_Entity.RTN_SQ;
            RTN_OTHERS = pucProductionOrderInfoPopup_T05_Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            DATE_FROM = pucProductionOrderInfoPopup_T05_Entity.DATE_FROM;
            DATE_TO = pucProductionOrderInfoPopup_T05_Entity.DATE_TO;
            PART_CODE = pucProductionOrderInfoPopup_T05_Entity.PART_CODE;
            PART_NAME = pucProductionOrderInfoPopup_T05_Entity.PART_NAME;
            VEND_CODE = pucProductionOrderInfoPopup_T05_Entity.VEND_CODE;
            VEND_NAME = pucProductionOrderInfoPopup_T05_Entity.VEND_NAME;

        }

        #endregion
    }


    public class ucProductStockInfoPopupEntity
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
        public String INOUT_CODE { get; set; } //
        public String VEND_ANME { get; set; } //

        #endregion

        #region 생성자 - ucProductStockInfoPopupEntity()

        public ucProductStockInfoPopupEntity()
        {
        }

        #endregion

        #region 생성자 - ucProductStockInfoPopupEntity(pucProductStockInfoPopupEntity)

        public ucProductStockInfoPopupEntity(ucProductStockInfoPopupEntity pucProductStockInfoPopupEntity)
        {
            CORP_CODE = pucProductStockInfoPopupEntity.CORP_CODE;
            CRUD = pucProductStockInfoPopupEntity.CRUD;
            USER_CODE = pucProductStockInfoPopupEntity.USER_CODE;

            LANGUAGE_TYPE = pucProductStockInfoPopupEntity.LANGUAGE_TYPE;


            pucProductStockInfoPopupEntity.WINDOW_NAME = WINDOW_NAME;

            pucProductStockInfoPopupEntity.DATE_FROM = DATE_FROM;
            pucProductStockInfoPopupEntity.DATE_TO = DATE_TO;
            pucProductStockInfoPopupEntity.PROCESS_CODE = PROCESS_CODE;
            pucProductStockInfoPopupEntity.INOUT_CODE = INOUT_CODE;

            ERR_NO = pucProductStockInfoPopupEntity.ERR_NO;
            ERR_MSG = pucProductStockInfoPopupEntity.ERR_MSG;
            RTN_KEY = pucProductStockInfoPopupEntity.RTN_KEY;
            RTN_SEQ = pucProductStockInfoPopupEntity.RTN_SEQ;
            RTN_OTHERS = pucProductStockInfoPopupEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

}

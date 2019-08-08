using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CoFAS_MES.UI.MM.Entity
{
    public class MaterialOrderRegisterEntity
    {
        #region Property
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String ORDER_ID { get; set; } // V_ORDER_ID
        public String ORDER_DATE { get; set; } // V_ORDER_DATE
        public String ORDER_SEQ { get; set; } // V_ORDER_SEQ
        public String ORDER_QTY { get; set; } // V_ORDER_QTY
        public String REQUEST_DATE { get; set; } // V_REQUEST_DATE
        public String REQUEST_LOCATION { get; set; } // V_REQUEST_LOCATION
        public String UNIT_CODE { get; set; } // V_UNIT_CODE
        public String UNITCOST { get; set; } // V_UNITCOST
        public String COST { get; set; } // V_COST
        public String CONTRACT_ID { get; set; } // V_CONTRACT_ID
        public String REMARK { get; set; } // V_REMARK
        public String USE_YN { get; set; } // V_USE_YN

        public String VEND_PART_CDOE { get; set; }

        public String LANGUAGE_TYPE { get; set; } // _pLANGUAGE_TYPE

        public String WINDOW_NAME { get; set; }
        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        public String PART_NAME { get; set; }
        public String PART_CODE { get; set; }
        public String VEND_CODE { get; set; }
        public String VEND_NAME { get; set; }
        public String REFERENCE_ID { get; set; }
        public String UNITCODT_CURRENCY_CODE { get; set; }
        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }
        #endregion

        #region 생성자 - MaterialOrderRegisterEntity()
        public MaterialOrderRegisterEntity() { }
        #endregion

        #region 생성자 - MaterialOrderRegisterEntity(MaterialOrderRegisterEntity pMaterialOrderRegisterEntity)
        public MaterialOrderRegisterEntity(MaterialOrderRegisterEntity pMaterialOrderRegisterEntity)
        {
            if (pMaterialOrderRegisterEntity == null)
                return;

            pMaterialOrderRegisterEntity.CORP_CODE = CORP_CODE;
            pMaterialOrderRegisterEntity.USER_CODE = USER_CODE;
            pMaterialOrderRegisterEntity.CRUD = CRUD;
            pMaterialOrderRegisterEntity.DATE_FROM = DATE_FROM;
            pMaterialOrderRegisterEntity.DATE_TO = DATE_TO;
            pMaterialOrderRegisterEntity.PART_NAME = PART_NAME;
            pMaterialOrderRegisterEntity.PART_CODE = PART_CODE;
            pMaterialOrderRegisterEntity.VEND_NAME = VEND_NAME;
            pMaterialOrderRegisterEntity.VEND_CODE = VEND_CODE;
            pMaterialOrderRegisterEntity.ORDER_ID = ORDER_ID;
            pMaterialOrderRegisterEntity.ORDER_DATE = ORDER_DATE;
            pMaterialOrderRegisterEntity.ORDER_SEQ = ORDER_SEQ;
            pMaterialOrderRegisterEntity.ORDER_QTY = ORDER_QTY;
            pMaterialOrderRegisterEntity.REQUEST_DATE = REQUEST_DATE;
            pMaterialOrderRegisterEntity.REQUEST_LOCATION = REQUEST_LOCATION;
            pMaterialOrderRegisterEntity.UNIT_CODE = UNIT_CODE;
            pMaterialOrderRegisterEntity.UNITCODT_CURRENCY_CODE = UNITCODT_CURRENCY_CODE;
            pMaterialOrderRegisterEntity.UNITCOST = UNITCOST;
            pMaterialOrderRegisterEntity.COST = COST;
            pMaterialOrderRegisterEntity.CONTRACT_ID = CONTRACT_ID;
            pMaterialOrderRegisterEntity.REMARK = REMARK;
            pMaterialOrderRegisterEntity.USE_YN = USE_YN;
            pMaterialOrderRegisterEntity.REFERENCE_ID = REFERENCE_ID;
            pMaterialOrderRegisterEntity.LANGUAGE_TYPE = LANGUAGE_TYPE;
            pMaterialOrderRegisterEntity.VEND_PART_CDOE = VEND_PART_CDOE;
            

            ERR_NO = pMaterialOrderRegisterEntity.ERR_NO;
            ERR_MSG = pMaterialOrderRegisterEntity.ERR_MSG;
            RTN_KEY = pMaterialOrderRegisterEntity.RTN_KEY;
            RTN_SEQ = pMaterialOrderRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pMaterialOrderRegisterEntity.RTN_OTHERS;
        }
        #endregion
    }
    public class MaterialOrderRegister_T02Entity
    {
        #region Property
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String ORDER_ID { get; set; } // V_ORDER_ID
        public String ORDER_DATE { get; set; } // V_ORDER_DATE
        public String ORDER_SEQ { get; set; } // V_ORDER_SEQ
        public String ORDER_QTY { get; set; } // V_ORDER_QTY
        public String REQUEST_DATE { get; set; } // V_REQUEST_DATE
        public String REQUEST_LOCATION { get; set; } // V_REQUEST_LOCATION
        public String UNIT_CODE { get; set; } // V_UNIT_CODE
        public String UNITCOST { get; set; } // V_UNITCOST
        public String COST { get; set; } // V_COST
        public String CONTRACT_ID { get; set; } // V_CONTRACT_ID
        public String REMARK { get; set; } // V_REMARK
        public String USE_YN { get; set; } // V_USE_YN

        public String VEND_PART_CDOE { get; set; }

        public String LANGUAGE_TYPE { get; set; } // _pLANGUAGE_TYPE

        public String WINDOW_NAME { get; set; }
        public bool check_yn { get; set; }
        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        public String PART_NAME { get; set; }
        public String PART_CODE { get; set; }
        public String VEND_CODE { get; set; }
        public String VEND_NAME { get; set; }
        public String REFERENCE_ID { get; set; }
        public String UNITCODT_CURRENCY_CODE { get; set; }
        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }
        #endregion

        #region 생성자 - MaterialOrderRegister_T02Entity()
        public MaterialOrderRegister_T02Entity() { }
        #endregion

        #region 생성자 - MaterialOrderRegister_T02Entity(MaterialOrderRegister_T02Entity pMaterialOrderRegister_T02Entity)
        public MaterialOrderRegister_T02Entity(MaterialOrderRegister_T02Entity pMaterialOrderRegister_T02Entity)
        {
            if (pMaterialOrderRegister_T02Entity == null)
                return;

            pMaterialOrderRegister_T02Entity.CORP_CODE = CORP_CODE;
            pMaterialOrderRegister_T02Entity.USER_CODE = USER_CODE;
            pMaterialOrderRegister_T02Entity.CRUD = CRUD;
            pMaterialOrderRegister_T02Entity.DATE_FROM = DATE_FROM;
            pMaterialOrderRegister_T02Entity.DATE_TO = DATE_TO;
            pMaterialOrderRegister_T02Entity.PART_NAME = PART_NAME;
            pMaterialOrderRegister_T02Entity.PART_CODE = PART_CODE;
            pMaterialOrderRegister_T02Entity.VEND_NAME = VEND_NAME;
            pMaterialOrderRegister_T02Entity.VEND_CODE = VEND_CODE;
            pMaterialOrderRegister_T02Entity.ORDER_ID = ORDER_ID;
            pMaterialOrderRegister_T02Entity.ORDER_DATE = ORDER_DATE;
            pMaterialOrderRegister_T02Entity.ORDER_SEQ = ORDER_SEQ;
            pMaterialOrderRegister_T02Entity.ORDER_QTY = ORDER_QTY;
            pMaterialOrderRegister_T02Entity.REQUEST_DATE = REQUEST_DATE;
            pMaterialOrderRegister_T02Entity.REQUEST_LOCATION = REQUEST_LOCATION;
            pMaterialOrderRegister_T02Entity.UNIT_CODE = UNIT_CODE;
            pMaterialOrderRegister_T02Entity.UNITCODT_CURRENCY_CODE = UNITCODT_CURRENCY_CODE;
            pMaterialOrderRegister_T02Entity.UNITCOST = UNITCOST;
            pMaterialOrderRegister_T02Entity.COST = COST;
            pMaterialOrderRegister_T02Entity.CONTRACT_ID = CONTRACT_ID;
            pMaterialOrderRegister_T02Entity.REMARK = REMARK;
            pMaterialOrderRegister_T02Entity.USE_YN = USE_YN;
            pMaterialOrderRegister_T02Entity.REFERENCE_ID = REFERENCE_ID;
            pMaterialOrderRegister_T02Entity.LANGUAGE_TYPE = LANGUAGE_TYPE;
            pMaterialOrderRegister_T02Entity.VEND_PART_CDOE = VEND_PART_CDOE;


            ERR_NO = pMaterialOrderRegister_T02Entity.ERR_NO;
            ERR_MSG = pMaterialOrderRegister_T02Entity.ERR_MSG;
            RTN_KEY = pMaterialOrderRegister_T02Entity.RTN_KEY;
            RTN_SEQ = pMaterialOrderRegister_T02Entity.RTN_SEQ;
            RTN_OTHERS = pMaterialOrderRegister_T02Entity.RTN_OTHERS;
        }
        #endregion
    }
    public class MaterialOrderRegister_T03Entity
    {
        #region Property
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String ORDER_ID { get; set; } // V_ORDER_ID
        public String ORDER_DATE { get; set; } // V_ORDER_DATE
        public String ORDER_SEQ { get; set; } // V_ORDER_SEQ
        public String ORDER_QTY { get; set; } // V_ORDER_QTY
        public String REQUEST_DATE { get; set; } // V_REQUEST_DATE
        public String REQUEST_LOCATION { get; set; } // V_REQUEST_LOCATION
        public String UNIT_CODE { get; set; } // V_UNIT_CODE
        public String UNITCOST { get; set; } // V_UNITCOST
        public String COST { get; set; } // V_COST
        public String CONTRACT_ID { get; set; } // V_CONTRACT_ID
        public String REMARK { get; set; } // V_REMARK
        public String USE_YN { get; set; } // V_USE_YN

        public String USER_NAME { get; set; } // V_USER

        public String VEND_PART_CDOE { get; set; }

        public String LANGUAGE_TYPE { get; set; } // _pLANGUAGE_TYPE

        public String WINDOW_NAME { get; set; }
        public bool check_yn { get; set; }
        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        public String PART_NAME { get; set; }
        public String PART_CODE { get; set; }
        public String VEND_CODE { get; set; }
        public String VEND_NAME { get; set; }
        public String REFERENCE_ID { get; set; }
        public String UNITCODT_CURRENCY_CODE { get; set; }
        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }
        #endregion

        #region 생성자 - MaterialOrderRegister_T03Entity()
        public MaterialOrderRegister_T03Entity() { }
        #endregion

        #region 생성자 - MaterialOrderRegister_T03Entity(MaterialOrderRegister_T03Entity pMaterialOrderRegister_T03Entity)
        public MaterialOrderRegister_T03Entity(MaterialOrderRegister_T03Entity pMaterialOrderRegister_T03Entity)
        {
            if (pMaterialOrderRegister_T03Entity == null)
                return;

            pMaterialOrderRegister_T03Entity.CORP_CODE = CORP_CODE;
            pMaterialOrderRegister_T03Entity.USER_CODE = USER_CODE;
            pMaterialOrderRegister_T03Entity.CRUD = CRUD;
            pMaterialOrderRegister_T03Entity.USER_NAME = USER_NAME;
            pMaterialOrderRegister_T03Entity.DATE_FROM = DATE_FROM;
            pMaterialOrderRegister_T03Entity.DATE_TO = DATE_TO;
            pMaterialOrderRegister_T03Entity.PART_NAME = PART_NAME;
            pMaterialOrderRegister_T03Entity.PART_CODE = PART_CODE;
            pMaterialOrderRegister_T03Entity.VEND_NAME = VEND_NAME;
            pMaterialOrderRegister_T03Entity.VEND_CODE = VEND_CODE;
            pMaterialOrderRegister_T03Entity.ORDER_ID = ORDER_ID;
            pMaterialOrderRegister_T03Entity.ORDER_DATE = ORDER_DATE;
            pMaterialOrderRegister_T03Entity.ORDER_SEQ = ORDER_SEQ;
            pMaterialOrderRegister_T03Entity.ORDER_QTY = ORDER_QTY;
            pMaterialOrderRegister_T03Entity.REQUEST_DATE = REQUEST_DATE;
            pMaterialOrderRegister_T03Entity.REQUEST_LOCATION = REQUEST_LOCATION;
            pMaterialOrderRegister_T03Entity.UNIT_CODE = UNIT_CODE;
            pMaterialOrderRegister_T03Entity.UNITCODT_CURRENCY_CODE = UNITCODT_CURRENCY_CODE;
            pMaterialOrderRegister_T03Entity.UNITCOST = UNITCOST;
            pMaterialOrderRegister_T03Entity.COST = COST;
            pMaterialOrderRegister_T03Entity.CONTRACT_ID = CONTRACT_ID;
            pMaterialOrderRegister_T03Entity.REMARK = REMARK;
            pMaterialOrderRegister_T03Entity.USE_YN = USE_YN;
            pMaterialOrderRegister_T03Entity.REFERENCE_ID = REFERENCE_ID;
            pMaterialOrderRegister_T03Entity.LANGUAGE_TYPE = LANGUAGE_TYPE;
            pMaterialOrderRegister_T03Entity.VEND_PART_CDOE = VEND_PART_CDOE;


            ERR_NO = pMaterialOrderRegister_T03Entity.ERR_NO;
            ERR_MSG = pMaterialOrderRegister_T03Entity.ERR_MSG;
            RTN_KEY = pMaterialOrderRegister_T03Entity.RTN_KEY;
            RTN_SEQ = pMaterialOrderRegister_T03Entity.RTN_SEQ;
            RTN_OTHERS = pMaterialOrderRegister_T03Entity.RTN_OTHERS;
        }
        #endregion
    }
    public class MaterialOrderRegister_ReportEntity
    {
        #region Property
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String ORDER_ID { get; set; } // V_ORDER_ID
        public String ORDER_DATE { get; set; } // V_ORDER_DATE
        public String ORDER_SEQ { get; set; } // V_ORDER_SEQ
        public String ORDER_QTY { get; set; } // V_ORDER_QTY
        public String REQUEST_DATE { get; set; } // V_REQUEST_DATE
        public String REQUEST_LOCATION { get; set; } // V_REQUEST_LOCATION
        public String UNIT_CODE { get; set; } // V_UNIT_CODE
        public String UNITCOST { get; set; } // V_UNITCOST
        public String COST { get; set; } // V_COST
        public String CONTRACT_ID { get; set; } // V_CONTRACT_ID
        public String REMARK { get; set; } // V_REMARK
        public String USE_YN { get; set; } // V_USE_YN

        public String LANGUAGE_TYPE { get; set; } // _pLANGUAGE_TYPE

        public String WINDOW_NAME { get; set; }
        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        public String PART_NAME { get; set; }
        public String PART_CODE { get; set; }
        public String VEND_CODE { get; set; }
        public String VEND_NAME { get; set; }
        public String REFERENCE_ID { get; set; }
        public String UNITCODT_CURRENCY_CODE { get; set; }
        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }
        #endregion

        #region 생성자 - MaterialOrderRegister_ReportEntity()
        public MaterialOrderRegister_ReportEntity() { }
        #endregion

        #region 생성자 - MaterialOrderRegister_ReportEntity(MaterialOrderRegister_ReportEntity pMaterialOrderRegister_ReportEntity)
        public MaterialOrderRegister_ReportEntity(MaterialOrderRegister_ReportEntity pMaterialOrderRegister_ReportEntity)
        {
            if (pMaterialOrderRegister_ReportEntity == null)
                return;

            pMaterialOrderRegister_ReportEntity.CORP_CODE = CORP_CODE;
            pMaterialOrderRegister_ReportEntity.USER_CODE = USER_CODE;
            pMaterialOrderRegister_ReportEntity.CRUD = CRUD;
            pMaterialOrderRegister_ReportEntity.DATE_FROM = DATE_FROM;
            pMaterialOrderRegister_ReportEntity.DATE_TO = DATE_TO;
            pMaterialOrderRegister_ReportEntity.PART_NAME = PART_NAME;
            pMaterialOrderRegister_ReportEntity.PART_CODE = PART_CODE;
            pMaterialOrderRegister_ReportEntity.VEND_NAME = VEND_NAME;
            pMaterialOrderRegister_ReportEntity.VEND_CODE = VEND_CODE;
            pMaterialOrderRegister_ReportEntity.ORDER_ID = ORDER_ID;
            pMaterialOrderRegister_ReportEntity.ORDER_DATE = ORDER_DATE;
            pMaterialOrderRegister_ReportEntity.ORDER_SEQ = ORDER_SEQ;
            pMaterialOrderRegister_ReportEntity.ORDER_QTY = ORDER_QTY;
            pMaterialOrderRegister_ReportEntity.REQUEST_DATE = REQUEST_DATE;
            pMaterialOrderRegister_ReportEntity.REQUEST_LOCATION = REQUEST_LOCATION;
            pMaterialOrderRegister_ReportEntity.UNIT_CODE = UNIT_CODE;
            pMaterialOrderRegister_ReportEntity.UNITCODT_CURRENCY_CODE = UNITCODT_CURRENCY_CODE;
            pMaterialOrderRegister_ReportEntity.UNITCOST = UNITCOST;
            pMaterialOrderRegister_ReportEntity.COST = COST;
            pMaterialOrderRegister_ReportEntity.CONTRACT_ID = CONTRACT_ID;
            pMaterialOrderRegister_ReportEntity.REMARK = REMARK;
            pMaterialOrderRegister_ReportEntity.USE_YN = USE_YN;
            pMaterialOrderRegister_ReportEntity.REFERENCE_ID = REFERENCE_ID;
            pMaterialOrderRegister_ReportEntity.LANGUAGE_TYPE = LANGUAGE_TYPE;


            ERR_NO = pMaterialOrderRegister_ReportEntity.ERR_NO;
            ERR_MSG = pMaterialOrderRegister_ReportEntity.ERR_MSG;
            RTN_KEY = pMaterialOrderRegister_ReportEntity.RTN_KEY;
            RTN_SEQ = pMaterialOrderRegister_ReportEntity.RTN_SEQ;
            RTN_OTHERS = pMaterialOrderRegister_ReportEntity.RTN_OTHERS;
        }
        #endregion
    }
    public class MaterialOrderRegisterEntity_Request
    {
        #region Property
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String USER_NAME { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String ORDER_ID { get; set; } // V_ORDER_ID
        public String ORDER_DATE { get; set; } // V_ORDER_DATE
        public String ORDER_SEQ { get; set; } // V_ORDER_SEQ
        public String ORDER_QTY { get; set; } // V_ORDER_QTY
        public String REQUEST_DATE { get; set; } // V_REQUEST_DATE
        public String REQUEST_LOCATION { get; set; } // V_REQUEST_LOCATION
        public String UNIT_CODE { get; set; } // V_UNIT_CODE
        public String UNITCOST { get; set; } // V_UNITCOST
        public String COST { get; set; } // V_COST
        public String CONTRACT_ID { get; set; } // V_CONTRACT_ID
        public String REMARK { get; set; } // V_REMARK
        public String USE_YN { get; set; } // V_USE_YN

        public String VEND_PART_CODE { get; set; }
        public String INSPECT_STATUS { get; set; } // V_INSPECT_STATUS  시험상태
        public String LANGUAGE_TYPE { get; set; }
        public String WINDOW_NAME { get; set; }
        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        public String PART_NAME { get; set; }
        public String PART_CODE { get; set; }
        public String VEND_CODE { get; set; }
        public String VEND_NAME { get; set; }
        public String REFERENCE_ID { get; set; }
        public String UNITCODT_CURRENCY_CODE { get; set; }
        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }

        #endregion

        #region 생성자 - MaterialOrderRegisterEntity_Request()
        public MaterialOrderRegisterEntity_Request() { }
        #endregion

        #region 생성자 - MaterialOrderRegisterEntity_Request(MaterialOrderRegisterEntity_Request pMaterialOrderRegisterEntity_Request)
        public MaterialOrderRegisterEntity_Request(MaterialOrderRegisterEntity_Request pMaterialOrderRegisterEntity_Request)
        {
            if (pMaterialOrderRegisterEntity_Request == null)
                return;

            pMaterialOrderRegisterEntity_Request.CORP_CODE = CORP_CODE;
            pMaterialOrderRegisterEntity_Request.USER_CODE = USER_CODE;
            pMaterialOrderRegisterEntity_Request.CRUD = CRUD;
            pMaterialOrderRegisterEntity_Request.DATE_FROM = DATE_FROM;
            pMaterialOrderRegisterEntity_Request.DATE_TO = DATE_TO;
            pMaterialOrderRegisterEntity_Request.PART_NAME = PART_NAME;
            pMaterialOrderRegisterEntity_Request.PART_CODE = PART_CODE;
            pMaterialOrderRegisterEntity_Request.VEND_NAME = VEND_NAME;
            pMaterialOrderRegisterEntity_Request.VEND_CODE = VEND_CODE;
            pMaterialOrderRegisterEntity_Request.ORDER_ID = ORDER_ID;
            pMaterialOrderRegisterEntity_Request.ORDER_DATE = ORDER_DATE;
            pMaterialOrderRegisterEntity_Request.ORDER_SEQ = ORDER_SEQ;
            pMaterialOrderRegisterEntity_Request.ORDER_QTY = ORDER_QTY;
            pMaterialOrderRegisterEntity_Request.REQUEST_DATE = REQUEST_DATE;
            pMaterialOrderRegisterEntity_Request.REQUEST_LOCATION = REQUEST_LOCATION;
            pMaterialOrderRegisterEntity_Request.UNIT_CODE = UNIT_CODE;
            pMaterialOrderRegisterEntity_Request.UNITCODT_CURRENCY_CODE = UNITCODT_CURRENCY_CODE;
            pMaterialOrderRegisterEntity_Request.UNITCOST = UNITCOST;
            pMaterialOrderRegisterEntity_Request.COST = COST;
            pMaterialOrderRegisterEntity_Request.CONTRACT_ID = CONTRACT_ID;
            pMaterialOrderRegisterEntity_Request.REMARK = REMARK;
            pMaterialOrderRegisterEntity_Request.USE_YN = USE_YN;
            pMaterialOrderRegisterEntity_Request.REFERENCE_ID = REFERENCE_ID;
            pMaterialOrderRegisterEntity_Request.INSPECT_STATUS = INSPECT_STATUS;
            pMaterialOrderRegisterEntity_Request.VEND_PART_CODE = VEND_PART_CODE;

            pMaterialOrderRegisterEntity_Request.LANGUAGE_TYPE = LANGUAGE_TYPE;
            pMaterialOrderRegisterEntity_Request.USER_NAME = USER_NAME;

            ERR_NO = pMaterialOrderRegisterEntity_Request.ERR_NO;
            ERR_MSG = pMaterialOrderRegisterEntity_Request.ERR_MSG;
            RTN_KEY = pMaterialOrderRegisterEntity_Request.RTN_KEY;
            RTN_SEQ = pMaterialOrderRegisterEntity_Request.RTN_SEQ;
            RTN_OTHERS = pMaterialOrderRegisterEntity_Request.RTN_OTHERS;
        }
        #endregion
    }

    public class MaterialOrderRegisterEntity_Request_T01
    {
        #region Property
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String USER_NAME { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String ORDER_ID { get; set; } // V_ORDER_ID
        public String ORDER_DATE { get; set; } // V_ORDER_DATE
        public String ORDER_SEQ { get; set; } // V_ORDER_SEQ
        public String ORDER_QTY { get; set; } // V_ORDER_QTY
        public String ORDER_NUMBER { get; set; } // V_ORDER_NUMBER
        public String REQUEST_DATE { get; set; } // V_REQUEST_DATE
        public String REQUEST_LOCATION { get; set; } // V_REQUEST_LOCATION
        public String UNIT_CODE { get; set; } // V_UNIT_CODE
        public String UNITCOST { get; set; } // V_UNITCOST
        public String COST { get; set; } // V_COST
        public String CONTRACT_ID { get; set; } // V_CONTRACT_ID
        public String REMARK { get; set; } // V_REMARK
        public String USE_YN { get; set; } // V_USE_YN
        public String ORDER_DETAIL_SEQ { get; set; }
        public String VEND_PART_CODE { get; set; }
        public String INSPECT_STATUS { get; set; } // V_INSPECT_STATUS  시험상태
        public String LANGUAGE_TYPE { get; set; }
        public String WINDOW_NAME { get; set; }
        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        public String PART_NAME { get; set; }
        public String PART_CODE { get; set; }
        public String VEND_CODE { get; set; }
        public String VEND_NAME { get; set; }
        public String REFERENCE_ID { get; set; }
        public String UNITCODT_CURRENCY_CODE { get; set; }
        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }
        
        public String PLACE_DELIVERY { get; set; }
        public String TRANS_CONDITION { get; set; } 
        public String TERMS_PAYMENT { get; set; }
        public String TAX_CLASSIFICATON { get; set; }
        public String CONTENTS { get; set; }

        #endregion

        #region 생성자 - MaterialOrderRegisterEntity_Request_T01()
        public MaterialOrderRegisterEntity_Request_T01() { }
        #endregion

        #region 생성자 - MaterialOrderRegisterEntity_Request_T01(MaterialOrderRegisterEntity_Request_T01 pMaterialOrderRegisterEntity_Request_T01)
        public MaterialOrderRegisterEntity_Request_T01(MaterialOrderRegisterEntity_Request_T01 pMaterialOrderRegisterEntity_Request_T01)
        {
            if (pMaterialOrderRegisterEntity_Request_T01 == null)
                return;

            pMaterialOrderRegisterEntity_Request_T01.CORP_CODE = CORP_CODE;
            pMaterialOrderRegisterEntity_Request_T01.USER_CODE = USER_CODE;
            pMaterialOrderRegisterEntity_Request_T01.CRUD = CRUD;
            pMaterialOrderRegisterEntity_Request_T01.DATE_FROM = DATE_FROM;
            pMaterialOrderRegisterEntity_Request_T01.DATE_TO = DATE_TO;
            pMaterialOrderRegisterEntity_Request_T01.PART_NAME = PART_NAME;
            pMaterialOrderRegisterEntity_Request_T01.PART_CODE = PART_CODE;
            pMaterialOrderRegisterEntity_Request_T01.VEND_NAME = VEND_NAME;
            pMaterialOrderRegisterEntity_Request_T01.VEND_CODE = VEND_CODE;
            pMaterialOrderRegisterEntity_Request_T01.ORDER_ID = ORDER_ID;
            pMaterialOrderRegisterEntity_Request_T01.ORDER_DATE = ORDER_DATE;
            pMaterialOrderRegisterEntity_Request_T01.ORDER_SEQ = ORDER_SEQ;
            pMaterialOrderRegisterEntity_Request_T01.ORDER_QTY = ORDER_QTY;
            pMaterialOrderRegisterEntity_Request_T01.REQUEST_DATE = REQUEST_DATE;
            pMaterialOrderRegisterEntity_Request_T01.REQUEST_LOCATION = REQUEST_LOCATION;
            pMaterialOrderRegisterEntity_Request_T01.UNIT_CODE = UNIT_CODE;
            pMaterialOrderRegisterEntity_Request_T01.UNITCODT_CURRENCY_CODE = UNITCODT_CURRENCY_CODE;
            pMaterialOrderRegisterEntity_Request_T01.UNITCOST = UNITCOST;
            pMaterialOrderRegisterEntity_Request_T01.COST = COST;
            pMaterialOrderRegisterEntity_Request_T01.CONTRACT_ID = CONTRACT_ID;
            pMaterialOrderRegisterEntity_Request_T01.REMARK = REMARK;
            pMaterialOrderRegisterEntity_Request_T01.USE_YN = USE_YN;
            pMaterialOrderRegisterEntity_Request_T01.REFERENCE_ID = REFERENCE_ID;
            pMaterialOrderRegisterEntity_Request_T01.INSPECT_STATUS = INSPECT_STATUS;
            pMaterialOrderRegisterEntity_Request_T01.VEND_PART_CODE = VEND_PART_CODE;
            pMaterialOrderRegisterEntity_Request_T01.LANGUAGE_TYPE = LANGUAGE_TYPE;
            pMaterialOrderRegisterEntity_Request_T01.USER_NAME = USER_NAME;
            pMaterialOrderRegisterEntity_Request_T01.ORDER_NUMBER = ORDER_NUMBER;
            pMaterialOrderRegisterEntity_Request_T01.ORDER_DETAIL_SEQ = ORDER_DETAIL_SEQ;
            pMaterialOrderRegisterEntity_Request_T01.PLACE_DELIVERY = PLACE_DELIVERY;
            pMaterialOrderRegisterEntity_Request_T01.TRANS_CONDITION = TRANS_CONDITION;
            pMaterialOrderRegisterEntity_Request_T01.TERMS_PAYMENT = TERMS_PAYMENT;
            pMaterialOrderRegisterEntity_Request_T01.TAX_CLASSIFICATON = TAX_CLASSIFICATON;
            pMaterialOrderRegisterEntity_Request_T01.CONTENTS = CONTENTS;

            ERR_NO = pMaterialOrderRegisterEntity_Request_T01.ERR_NO;
            ERR_MSG = pMaterialOrderRegisterEntity_Request_T01.ERR_MSG;
            RTN_KEY = pMaterialOrderRegisterEntity_Request_T01.RTN_KEY;
            RTN_SEQ = pMaterialOrderRegisterEntity_Request_T01.RTN_SEQ;
            RTN_OTHERS = pMaterialOrderRegisterEntity_Request_T01.RTN_OTHERS;
        }
        #endregion
    }



    public class ucMaterialOrderRegister_Request_T01Entity
    {
        #region Property
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String USER_NAME { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String ORDER_ID { get; set; } // V_ORDER_ID
        public String ORDER_DATE { get; set; } // V_ORDER_DATE
        public String ORDER_SEQ { get; set; } // V_ORDER_SEQ
        public String ORDER_QTY { get; set; } // V_ORDER_QTY
        public String ORDER_NUMBER { get; set; } // V_ORDER_NUMBER
        public String REQUEST_DATE { get; set; } // V_REQUEST_DATE
        public String REQUEST_LOCATION { get; set; } // V_REQUEST_LOCATION
        public String UNIT_CODE { get; set; } // V_UNIT_CODE
        public String UNITCOST { get; set; } // V_UNITCOST
        public String COST { get; set; } // V_COST
        public String CONTRACT_ID { get; set; } // V_CONTRACT_ID
        public String REMARK { get; set; } // V_REMARK
        public String USE_YN { get; set; } // V_USE_YN
        public String ORDER_DETAIL_SEQ { get; set; }
        public String VEND_PART_CODE { get; set; }
        public String INSPECT_STATUS { get; set; } // V_INSPECT_STATUS  시험상태
        public String LANGUAGE_TYPE { get; set; }
        public String WINDOW_NAME { get; set; }
        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        public String PART_NAME { get; set; }
        public String PART_CODE { get; set; }
        public String VEND_CODE { get; set; }
        public String VEND_NAME { get; set; }
        public String REFERENCE_ID { get; set; }
        public String UNITCODT_CURRENCY_CODE { get; set; }
        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }

        #endregion

        #region 생성자 - ucMaterialOrderRegister_Request_T01Entity()
        public ucMaterialOrderRegister_Request_T01Entity() { }
        #endregion

        #region 생성자 - ucMaterialOrderRegister_Request_T01Entity(ucMaterialOrderRegister_Request_T01Entity pucMaterialOrderRegister_Request_T01Entity)
        public ucMaterialOrderRegister_Request_T01Entity(ucMaterialOrderRegister_Request_T01Entity pucMaterialOrderRegister_Request_T01Entity)
        {
            if (pucMaterialOrderRegister_Request_T01Entity == null)
                return;

            pucMaterialOrderRegister_Request_T01Entity.CORP_CODE = CORP_CODE;
            pucMaterialOrderRegister_Request_T01Entity.USER_CODE = USER_CODE;
            pucMaterialOrderRegister_Request_T01Entity.CRUD = CRUD;
            pucMaterialOrderRegister_Request_T01Entity.DATE_FROM = DATE_FROM;
            pucMaterialOrderRegister_Request_T01Entity.DATE_TO = DATE_TO;
            pucMaterialOrderRegister_Request_T01Entity.PART_NAME = PART_NAME;
            pucMaterialOrderRegister_Request_T01Entity.PART_CODE = PART_CODE;
            pucMaterialOrderRegister_Request_T01Entity.VEND_NAME = VEND_NAME;
            pucMaterialOrderRegister_Request_T01Entity.VEND_CODE = VEND_CODE;
            pucMaterialOrderRegister_Request_T01Entity.ORDER_ID = ORDER_ID;
            pucMaterialOrderRegister_Request_T01Entity.ORDER_DATE = ORDER_DATE;
            pucMaterialOrderRegister_Request_T01Entity.ORDER_SEQ = ORDER_SEQ;
            pucMaterialOrderRegister_Request_T01Entity.ORDER_QTY = ORDER_QTY;
            pucMaterialOrderRegister_Request_T01Entity.REQUEST_DATE = REQUEST_DATE;
            pucMaterialOrderRegister_Request_T01Entity.REQUEST_LOCATION = REQUEST_LOCATION;
            pucMaterialOrderRegister_Request_T01Entity.UNIT_CODE = UNIT_CODE;
            pucMaterialOrderRegister_Request_T01Entity.UNITCODT_CURRENCY_CODE = UNITCODT_CURRENCY_CODE;
            pucMaterialOrderRegister_Request_T01Entity.UNITCOST = UNITCOST;
            pucMaterialOrderRegister_Request_T01Entity.COST = COST;
            pucMaterialOrderRegister_Request_T01Entity.CONTRACT_ID = CONTRACT_ID;
            pucMaterialOrderRegister_Request_T01Entity.REMARK = REMARK;
            pucMaterialOrderRegister_Request_T01Entity.USE_YN = USE_YN;
            pucMaterialOrderRegister_Request_T01Entity.REFERENCE_ID = REFERENCE_ID;
            pucMaterialOrderRegister_Request_T01Entity.INSPECT_STATUS = INSPECT_STATUS;
            pucMaterialOrderRegister_Request_T01Entity.VEND_PART_CODE = VEND_PART_CODE;
            pucMaterialOrderRegister_Request_T01Entity.LANGUAGE_TYPE = LANGUAGE_TYPE;
            pucMaterialOrderRegister_Request_T01Entity.USER_NAME = USER_NAME;
            pucMaterialOrderRegister_Request_T01Entity.ORDER_NUMBER = ORDER_NUMBER;
            pucMaterialOrderRegister_Request_T01Entity.ORDER_DETAIL_SEQ = ORDER_DETAIL_SEQ;

            ERR_NO = pucMaterialOrderRegister_Request_T01Entity.ERR_NO;
            ERR_MSG = pucMaterialOrderRegister_Request_T01Entity.ERR_MSG;
            RTN_KEY = pucMaterialOrderRegister_Request_T01Entity.RTN_KEY;
            RTN_SEQ = pucMaterialOrderRegister_Request_T01Entity.RTN_SEQ;
            RTN_OTHERS = pucMaterialOrderRegister_Request_T01Entity.RTN_OTHERS;
        }
        #endregion
    }

    public class MaterialOrderStatusEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // _pLANGUAGE_TYPE


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

        #region 생성자 - MaterialOrderStatusEntity()

        public MaterialOrderStatusEntity()
        {
        }

        #endregion

        #region 생성자 - MaterialOrderStatusEntity(pMaterialOrderStatusEntity)

        public MaterialOrderStatusEntity(MaterialOrderStatusEntity pMaterialOrderStatusEntity)
        {
            CORP_CODE = pMaterialOrderStatusEntity.CORP_CODE;
            CRUD = pMaterialOrderStatusEntity.CRUD;
            USER_CODE = pMaterialOrderStatusEntity.USER_CODE;
            LANGUAGE_TYPE = pMaterialOrderStatusEntity.LANGUAGE_TYPE;
            

            pMaterialOrderStatusEntity.DATE_FROM = DATE_FROM;
            pMaterialOrderStatusEntity.DATE_TO = DATE_TO;
            pMaterialOrderStatusEntity.PART_CODE = PART_CODE;
            pMaterialOrderStatusEntity.PART_NAME = PART_NAME;
            pMaterialOrderStatusEntity.VEND_NAME = VEND_NAME;
            pMaterialOrderStatusEntity.ORDER_ID = ORDER_ID;

            ERR_NO = pMaterialOrderStatusEntity.ERR_NO;
            ERR_MSG = pMaterialOrderStatusEntity.ERR_MSG;
            RTN_KEY = pMaterialOrderStatusEntity.RTN_KEY;
            RTN_SEQ = pMaterialOrderStatusEntity.RTN_SEQ;
            RTN_OTHERS = pMaterialOrderStatusEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class MaterialExpirationDateStatusEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // _pLANGUAGE_TYPE


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
    }

    public class ucBOM_SpendQtyCalcPopEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // _pLANGUAGE_TYPE


        public String WINDOW_NAME { get; set; }
        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        public String PART_NAME { get; set; }
        public String VEND_CODE { get; set; }
        public String VEND_NAME { get; set; }
        public String ORDER_ID { get; set; }
        public String CONTRACT_ID { get; set; }
        public String ORDER_DATE { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값


        //메뉴별 추가 엔티티 입력

        public String PART_CODE { get; set; }

        public String INOUT_ID { get; set; }

        public String INOUT_DATE { get; set; }
        public String INOUT_SEQ { get; set; }
        public String INOUT_TYPE { get; set; }
        public String INOUT_CODE { get; set; }
        public String REFERENCE_ID { get; set; }
        public String INOUT_QTY { get; set; }
        public String PART_UNIT { get; set; }
        public String UNITCOST { get; set; }
        public String COST { get; set; }
        public String REMARK { get; set; }
        public String USE_YN { get; set; }
        public String END_DATE { get; set; }
        public String REQUEST_DATE { get; set; }
        public bool check_yn { get; set; }



        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - ucBOM_SpendQtyCalcPopEntity()

        public ucBOM_SpendQtyCalcPopEntity()
        {
        }

        #endregion

        #region 생성자 - ucBOM_SpendQtyCalcPopEntity(pucBOM_SpendQtyCalcPopEntity)

        public ucBOM_SpendQtyCalcPopEntity(ucBOM_SpendQtyCalcPopEntity pucBOM_SpendQtyCalcPopEntity)
        {
            CORP_CODE = pucBOM_SpendQtyCalcPopEntity.CORP_CODE;
            CRUD = pucBOM_SpendQtyCalcPopEntity.CRUD;
            USER_CODE = pucBOM_SpendQtyCalcPopEntity.USER_CODE;
            LANGUAGE_TYPE = pucBOM_SpendQtyCalcPopEntity.LANGUAGE_TYPE;


            pucBOM_SpendQtyCalcPopEntity.DATE_FROM = DATE_FROM;
            pucBOM_SpendQtyCalcPopEntity.DATE_TO = DATE_TO;
            pucBOM_SpendQtyCalcPopEntity.PART_NAME = PART_NAME;
            pucBOM_SpendQtyCalcPopEntity.VEND_NAME = VEND_NAME;
            pucBOM_SpendQtyCalcPopEntity.ORDER_ID = ORDER_ID;

            ERR_NO = pucBOM_SpendQtyCalcPopEntity.ERR_NO;
            ERR_MSG = pucBOM_SpendQtyCalcPopEntity.ERR_MSG;
            RTN_KEY = pucBOM_SpendQtyCalcPopEntity.RTN_KEY;
            RTN_SEQ = pucBOM_SpendQtyCalcPopEntity.RTN_SEQ;
            RTN_OTHERS = pucBOM_SpendQtyCalcPopEntity.RTN_OTHERS;
            
            //메뉴별 추가 엔티티 입력
            pucBOM_SpendQtyCalcPopEntity.WINDOW_NAME = WINDOW_NAME;

            pucBOM_SpendQtyCalcPopEntity.DATE_FROM = DATE_FROM;
            pucBOM_SpendQtyCalcPopEntity.DATE_TO = DATE_TO;
            pucBOM_SpendQtyCalcPopEntity.PART_NAME = PART_NAME;
            pucBOM_SpendQtyCalcPopEntity.PART_CODE = PART_CODE;
            pucBOM_SpendQtyCalcPopEntity.VEND_NAME = VEND_NAME;
            pucBOM_SpendQtyCalcPopEntity.VEND_CODE = VEND_CODE;
            pucBOM_SpendQtyCalcPopEntity.INOUT_ID = INOUT_ID;

            pucBOM_SpendQtyCalcPopEntity.INOUT_DATE = INOUT_DATE;
            pucBOM_SpendQtyCalcPopEntity.INOUT_SEQ = INOUT_SEQ;
            pucBOM_SpendQtyCalcPopEntity.INOUT_TYPE = INOUT_TYPE;
            pucBOM_SpendQtyCalcPopEntity.INOUT_CODE = INOUT_CODE;
            pucBOM_SpendQtyCalcPopEntity.REFERENCE_ID = REFERENCE_ID;
            pucBOM_SpendQtyCalcPopEntity.INOUT_QTY = INOUT_QTY;
            pucBOM_SpendQtyCalcPopEntity.PART_UNIT = PART_UNIT;
            pucBOM_SpendQtyCalcPopEntity.UNITCOST = UNITCOST;
            pucBOM_SpendQtyCalcPopEntity.COST = COST;
            pucBOM_SpendQtyCalcPopEntity.REMARK = REMARK;
            pucBOM_SpendQtyCalcPopEntity.USE_YN = USE_YN;
            pucBOM_SpendQtyCalcPopEntity.END_DATE = END_DATE;

            pucBOM_SpendQtyCalcPopEntity.CONTRACT_ID = CONTRACT_ID;
            pucBOM_SpendQtyCalcPopEntity.ORDER_DATE = ORDER_DATE;
            pucBOM_SpendQtyCalcPopEntity.REQUEST_DATE = REQUEST_DATE;

            pucBOM_SpendQtyCalcPopEntity.check_yn = check_yn;
            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }
    public class MaterialInRegisterEntity
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
        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String VEND_NAME { get; set; }
        public String VEND_CODE { get; set; }
        public String INOUT_ID { get; set; }

        public String INOUT_DATE { get; set; }
        public String INOUT_SEQ { get; set; }
        public String INOUT_TYPE { get; set; }
        public String INOUT_CODE { get; set; }
        public String REFERENCE_ID { get; set; }
        public String INOUT_QTY { get; set; }
        public String PART_UNIT { get; set; }
        public String UNITCOST { get; set; }
        public String COST { get; set; }
        public String REMARK { get; set; }
        public String USE_YN { get; set; }


        #endregion

        #region 생성자 - MaterialInRegisterEntity()

        public MaterialInRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - MaterialInRegisterEntity(MaterialInRegisterEntity pMaterialInRegisterEntity)

        public MaterialInRegisterEntity(MaterialInRegisterEntity pMaterialInRegisterEntity)
        {
            CORP_CODE = pMaterialInRegisterEntity.CORP_CODE;
            CRUD = pMaterialInRegisterEntity.CRUD;
            USER_CODE = pMaterialInRegisterEntity.USER_CODE;
            LANGUAGE_TYPE = pMaterialInRegisterEntity.LANGUAGE_TYPE;

            ERR_NO = pMaterialInRegisterEntity.ERR_NO;
            ERR_MSG = pMaterialInRegisterEntity.ERR_MSG;
            RTN_KEY = pMaterialInRegisterEntity.RTN_KEY;
            RTN_SEQ = pMaterialInRegisterEntity.RTN_SEQ;
            RTN_AQ = pMaterialInRegisterEntity.RTN_AQ;
            RTN_SQ = pMaterialInRegisterEntity.RTN_SQ;
            RTN_OTHERS = pMaterialInRegisterEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            pMaterialInRegisterEntity.WINDOW_NAME = WINDOW_NAME;

            pMaterialInRegisterEntity.DATE_FROM = DATE_FROM;
            pMaterialInRegisterEntity.DATE_TO = DATE_TO;
            pMaterialInRegisterEntity.PART_NAME = PART_NAME;
            pMaterialInRegisterEntity.PART_CODE = PART_CODE;
            pMaterialInRegisterEntity.VEND_NAME   = VEND_NAME;
            pMaterialInRegisterEntity.VEND_CODE    = VEND_CODE;
            pMaterialInRegisterEntity.INOUT_ID     = INOUT_ID;

            pMaterialInRegisterEntity.INOUT_DATE = INOUT_DATE;
            pMaterialInRegisterEntity.INOUT_SEQ = INOUT_SEQ;
            pMaterialInRegisterEntity.INOUT_TYPE = INOUT_TYPE;
            pMaterialInRegisterEntity.INOUT_CODE = INOUT_CODE;
            pMaterialInRegisterEntity.REFERENCE_ID = REFERENCE_ID;
            pMaterialInRegisterEntity.INOUT_QTY = INOUT_QTY;
            pMaterialInRegisterEntity.PART_UNIT = PART_UNIT;
            pMaterialInRegisterEntity.UNITCOST = UNITCOST;
            pMaterialInRegisterEntity.COST = COST;
            pMaterialInRegisterEntity.REMARK = REMARK;
            pMaterialInRegisterEntity.USE_YN = USE_YN;

        }

        #endregion

    }


    
    public class MaterialInRegister_T01Entity
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
        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String VEND_NAME { get; set; }
        public String VEND_CODE { get; set; }
        public String INOUT_ID { get; set; }

        public String INOUT_DATE { get; set; }
        public String INOUT_SEQ { get; set; }
        public String INOUT_TYPE { get; set; }
        public String INOUT_CODE { get; set; }
        public String REFERENCE_ID { get; set; }
        public String INOUT_QTY { get; set; }
        public String PART_UNIT { get; set; }
        public String UNITCOST { get; set; }
        public String COST { get; set; }
        public String REMARK { get; set; }
        public String USE_YN { get; set; }


        #endregion

        #region 생성자 - MaterialInRegister_T01Entity()

        public MaterialInRegister_T01Entity()
        {
        }

        #endregion

        #region 생성자 - MaterialInRegister_T01Entity(MaterialInRegister_T01Entity pMaterialInRegister_T01Entity)

        public MaterialInRegister_T01Entity(MaterialInRegister_T01Entity pMaterialInRegister_T01Entity)
        {
            CORP_CODE = pMaterialInRegister_T01Entity.CORP_CODE;
            CRUD = pMaterialInRegister_T01Entity.CRUD;
            USER_CODE = pMaterialInRegister_T01Entity.USER_CODE;
            LANGUAGE_TYPE = pMaterialInRegister_T01Entity.LANGUAGE_TYPE;

            ERR_NO = pMaterialInRegister_T01Entity.ERR_NO;
            ERR_MSG = pMaterialInRegister_T01Entity.ERR_MSG;
            RTN_KEY = pMaterialInRegister_T01Entity.RTN_KEY;
            RTN_SEQ = pMaterialInRegister_T01Entity.RTN_SEQ;
            RTN_AQ = pMaterialInRegister_T01Entity.RTN_AQ;
            RTN_SQ = pMaterialInRegister_T01Entity.RTN_SQ;
            RTN_OTHERS = pMaterialInRegister_T01Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            pMaterialInRegister_T01Entity.WINDOW_NAME = WINDOW_NAME;

            pMaterialInRegister_T01Entity.DATE_FROM = DATE_FROM;
            pMaterialInRegister_T01Entity.DATE_TO = DATE_TO;
            pMaterialInRegister_T01Entity.PART_NAME = PART_NAME;
            pMaterialInRegister_T01Entity.PART_CODE = PART_CODE;
            pMaterialInRegister_T01Entity.VEND_NAME = VEND_NAME;
            pMaterialInRegister_T01Entity.VEND_CODE = VEND_CODE;
            pMaterialInRegister_T01Entity.INOUT_ID = INOUT_ID;

            pMaterialInRegister_T01Entity.INOUT_DATE = INOUT_DATE;
            pMaterialInRegister_T01Entity.INOUT_SEQ = INOUT_SEQ;
            pMaterialInRegister_T01Entity.INOUT_TYPE = INOUT_TYPE;
            pMaterialInRegister_T01Entity.INOUT_CODE = INOUT_CODE;
            pMaterialInRegister_T01Entity.REFERENCE_ID = REFERENCE_ID;
            pMaterialInRegister_T01Entity.INOUT_QTY = INOUT_QTY;
            pMaterialInRegister_T01Entity.PART_UNIT = PART_UNIT;
            pMaterialInRegister_T01Entity.UNITCOST = UNITCOST;
            pMaterialInRegister_T01Entity.COST = COST;
            pMaterialInRegister_T01Entity.REMARK = REMARK;
            pMaterialInRegister_T01Entity.USE_YN = USE_YN;

        }

        #endregion

    }

    public class MaterialInRegister_T02Entity
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
        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String VEND_NAME { get; set; }
        public String VEND_CODE { get; set; }
        public String INOUT_ID { get; set; }

        public String EXPIRATION_DATE { get; set; }

        public String INOUT_DATE { get; set; }
        public String INOUT_SEQ { get; set; }
        public String INOUT_TYPE { get; set; }
        public String INOUT_CODE { get; set; }
        public String REFERENCE_ID { get; set; }
        public String INOUT_QTY { get; set; }
        public String PART_UNIT { get; set; }
        public String UNITCOST { get; set; }
        public String COST { get; set; }
        public String REMARK { get; set; }
        public String USE_YN { get; set; }


        #endregion

        #region 생성자 - MaterialInRegister_T02Entity()

        public MaterialInRegister_T02Entity()
        {
        }

        #endregion

        #region 생성자 - MaterialInRegister_T02Entity(MaterialInRegister_T02Entity pMaterialInRegister_T02Entity)

        public MaterialInRegister_T02Entity(MaterialInRegister_T02Entity pMaterialInRegister_T02Entity)
        {
            CORP_CODE = pMaterialInRegister_T02Entity.CORP_CODE;
            CRUD = pMaterialInRegister_T02Entity.CRUD;
            USER_CODE = pMaterialInRegister_T02Entity.USER_CODE;
            LANGUAGE_TYPE = pMaterialInRegister_T02Entity.LANGUAGE_TYPE;

            ERR_NO = pMaterialInRegister_T02Entity.ERR_NO;
            ERR_MSG = pMaterialInRegister_T02Entity.ERR_MSG;
            RTN_KEY = pMaterialInRegister_T02Entity.RTN_KEY;
            RTN_SEQ = pMaterialInRegister_T02Entity.RTN_SEQ;
            RTN_AQ = pMaterialInRegister_T02Entity.RTN_AQ;
            RTN_SQ = pMaterialInRegister_T02Entity.RTN_SQ;
            RTN_OTHERS = pMaterialInRegister_T02Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            pMaterialInRegister_T02Entity.WINDOW_NAME = WINDOW_NAME;

            pMaterialInRegister_T02Entity.DATE_FROM = DATE_FROM;
            pMaterialInRegister_T02Entity.DATE_TO = DATE_TO;
            pMaterialInRegister_T02Entity.PART_NAME = PART_NAME;
            pMaterialInRegister_T02Entity.PART_CODE = PART_CODE;
            pMaterialInRegister_T02Entity.VEND_NAME = VEND_NAME;
            pMaterialInRegister_T02Entity.VEND_CODE = VEND_CODE;
            pMaterialInRegister_T02Entity.INOUT_ID = INOUT_ID;

            pMaterialInRegister_T02Entity.EXPIRATION_DATE = EXPIRATION_DATE;

            pMaterialInRegister_T02Entity.INOUT_DATE = INOUT_DATE;
            pMaterialInRegister_T02Entity.INOUT_SEQ = INOUT_SEQ;
            pMaterialInRegister_T02Entity.INOUT_TYPE = INOUT_TYPE;
            pMaterialInRegister_T02Entity.INOUT_CODE = INOUT_CODE;
            pMaterialInRegister_T02Entity.REFERENCE_ID = REFERENCE_ID;
            pMaterialInRegister_T02Entity.INOUT_QTY = INOUT_QTY;
            pMaterialInRegister_T02Entity.PART_UNIT = PART_UNIT;
            pMaterialInRegister_T02Entity.UNITCOST = UNITCOST;
            pMaterialInRegister_T02Entity.COST = COST;
            pMaterialInRegister_T02Entity.REMARK = REMARK;
            pMaterialInRegister_T02Entity.USE_YN = USE_YN;

        }

        #endregion

    }
    public class MaterialInRegister_T03Entity
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
        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String VEND_NAME { get; set; }
        public String VEND_CODE { get; set; }
        public String INOUT_ID { get; set; }

        public String INOUT_DATE { get; set; }
        public String INOUT_SEQ { get; set; }
        public String INOUT_TYPE { get; set; }
        public String INOUT_CODE { get; set; }
        public String REFERENCE_ID { get; set; }
        public String INOUT_QTY { get; set; }
        public String PART_UNIT { get; set; }
        public String LOCATION { get; set; }
        public String UNITCOST { get; set; }
        public String COST { get; set; }
        public String REMARK { get; set; }
        public String USE_YN { get; set; }


        #endregion

        #region 생성자 - MaterialInRegister_T03Entity()

        public MaterialInRegister_T03Entity()
        {
        }

        #endregion

        #region 생성자 - MaterialInRegister_T03Entity(MaterialInRegister_T03Entity pMaterialInRegister_T03Entity)

        public MaterialInRegister_T03Entity(MaterialInRegister_T03Entity pMaterialInRegister_T03Entity)
        {
            CORP_CODE = pMaterialInRegister_T03Entity.CORP_CODE;
            CRUD = pMaterialInRegister_T03Entity.CRUD;
            USER_CODE = pMaterialInRegister_T03Entity.USER_CODE;
            LANGUAGE_TYPE = pMaterialInRegister_T03Entity.LANGUAGE_TYPE;

            ERR_NO = pMaterialInRegister_T03Entity.ERR_NO;
            ERR_MSG = pMaterialInRegister_T03Entity.ERR_MSG;
            RTN_KEY = pMaterialInRegister_T03Entity.RTN_KEY;
            RTN_SEQ = pMaterialInRegister_T03Entity.RTN_SEQ;
            RTN_AQ = pMaterialInRegister_T03Entity.RTN_AQ;
            RTN_SQ = pMaterialInRegister_T03Entity.RTN_SQ;
            RTN_OTHERS = pMaterialInRegister_T03Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            pMaterialInRegister_T03Entity.WINDOW_NAME = WINDOW_NAME;

            pMaterialInRegister_T03Entity.DATE_FROM = DATE_FROM;
            pMaterialInRegister_T03Entity.DATE_TO = DATE_TO;
            pMaterialInRegister_T03Entity.PART_NAME = PART_NAME;
            pMaterialInRegister_T03Entity.PART_CODE = PART_CODE;
            pMaterialInRegister_T03Entity.VEND_NAME = VEND_NAME;
            pMaterialInRegister_T03Entity.VEND_CODE = VEND_CODE;
            pMaterialInRegister_T03Entity.INOUT_ID = INOUT_ID;

            pMaterialInRegister_T03Entity.INOUT_DATE = INOUT_DATE;
            pMaterialInRegister_T03Entity.INOUT_SEQ = INOUT_SEQ;
            pMaterialInRegister_T03Entity.INOUT_TYPE = INOUT_TYPE;
            pMaterialInRegister_T03Entity.INOUT_CODE = INOUT_CODE;
            pMaterialInRegister_T03Entity.REFERENCE_ID = REFERENCE_ID;
            pMaterialInRegister_T03Entity.INOUT_QTY = INOUT_QTY;
            pMaterialInRegister_T03Entity.PART_UNIT = PART_UNIT;
            pMaterialInRegister_T03Entity.UNITCOST = UNITCOST;
            pMaterialInRegister_T03Entity.COST = COST;
            pMaterialInRegister_T03Entity.REMARK = REMARK;
            pMaterialInRegister_T03Entity.USE_YN = USE_YN;
            pMaterialInRegister_T03Entity.LOCATION = LOCATION;
            
        }

        #endregion

    }
    public class MaterialReShipInOutEntity
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
        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String VEND_PART_CODE { get; set; }
        public String USE_YN { get; set; }

        public String MATSTOCK_ID { get; set; }
        public String MATSTOCK_DETAIL_SEQ { get; set; }
        public String MATSTOCK_DETAIL_QTY { get; set; }
        
        public String LOT_ID { get; set; }
        public String MATSTOCK_SUB_ID { get; set; }
        public String MATSTOCK_SUB_SEQ { get; set; }
        public String MATSTOCK_SUB_NAME { get; set; }
        public String MATSTOCK_SUB_QTY { get; set; }
        public String REAMRK { get; set; }

        #endregion

        #region 생성자 - MaterialReShipInOutEntity()

        public MaterialReShipInOutEntity()
        {
        }

        #endregion

        #region 생성자 - MaterialReShipInOutEntity(MaterialReShipInOutEntity pMaterialReShipInOutEntity)

        public MaterialReShipInOutEntity(MaterialReShipInOutEntity pMaterialReShipInOutEntity)
        {
            CORP_CODE = pMaterialReShipInOutEntity.CORP_CODE;
            CRUD = pMaterialReShipInOutEntity.CRUD;
            USER_CODE = pMaterialReShipInOutEntity.USER_CODE;
            LANGUAGE_TYPE = pMaterialReShipInOutEntity.LANGUAGE_TYPE;

            ERR_NO = pMaterialReShipInOutEntity.ERR_NO;
            ERR_MSG = pMaterialReShipInOutEntity.ERR_MSG;
            RTN_KEY = pMaterialReShipInOutEntity.RTN_KEY;
            RTN_SEQ = pMaterialReShipInOutEntity.RTN_SEQ;
            RTN_AQ = pMaterialReShipInOutEntity.RTN_AQ;
            RTN_SQ = pMaterialReShipInOutEntity.RTN_SQ;
            RTN_OTHERS = pMaterialReShipInOutEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            pMaterialReShipInOutEntity.WINDOW_NAME = WINDOW_NAME;

            pMaterialReShipInOutEntity.DATE_FROM = DATE_FROM;
            pMaterialReShipInOutEntity.DATE_TO = DATE_TO;
            pMaterialReShipInOutEntity.PART_NAME = PART_NAME;
            pMaterialReShipInOutEntity.PART_CODE = PART_CODE;
            pMaterialReShipInOutEntity.VEND_PART_CODE = VEND_PART_CODE;
            pMaterialReShipInOutEntity.USE_YN = USE_YN;

            pMaterialReShipInOutEntity.MATSTOCK_ID = MATSTOCK_ID;
            pMaterialReShipInOutEntity.MATSTOCK_DETAIL_SEQ = MATSTOCK_DETAIL_SEQ;
            pMaterialReShipInOutEntity.MATSTOCK_DETAIL_QTY = MATSTOCK_DETAIL_QTY;
            pMaterialReShipInOutEntity.LOT_ID = LOT_ID;
            pMaterialReShipInOutEntity.MATSTOCK_SUB_ID = MATSTOCK_SUB_ID;
            pMaterialReShipInOutEntity.MATSTOCK_SUB_SEQ = MATSTOCK_SUB_SEQ;
            pMaterialReShipInOutEntity.MATSTOCK_SUB_NAME = MATSTOCK_SUB_NAME;
            pMaterialReShipInOutEntity.MATSTOCK_SUB_QTY = MATSTOCK_SUB_QTY;
            pMaterialReShipInOutEntity.REAMRK = REAMRK;
        }

        #endregion

    }

    public class MaterialInRegister_RequestEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; }

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
        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String VEND_NAME { get; set; }
        public String VEND_CODE { get; set; }
        public String INOUT_ID { get; set; }
        public String TOTAL_RESULT { get; set; }
        public String INOUT_DATE { get; set; }
        public String INOUT_SEQ { get; set; }
        public String INOUT_TYPE { get; set; }
        public String INOUT_CODE { get; set; }
        public String REFERENCE_ID { get; set; }
        public String INOUT_QTY { get; set; }
        public String PART_UNIT { get; set; }
        public String UNITCOST { get; set; }
        public String COST { get; set; }
        public String REMARK { get; set; }
        public String USE_YN { get; set; }
        public String END_DATE { get; set; }
        public String VEND_PART_CODE { get; set; }
        

        #endregion

        #region 생성자 - MaterialInRegister_RequestEntity()

        public MaterialInRegister_RequestEntity()
        {
        }

        #endregion

        #region 생성자 - MaterialInRegister_RequestEntity(MaterialInRegister_RequestEntity pMaterialInRegister_RequestEntity)

        public MaterialInRegister_RequestEntity(MaterialInRegister_RequestEntity pMaterialInRegister_RequestEntity)
        {
            CORP_CODE = pMaterialInRegister_RequestEntity.CORP_CODE;
            CRUD = pMaterialInRegister_RequestEntity.CRUD;
            USER_CODE = pMaterialInRegister_RequestEntity.USER_CODE;
            LANGUAGE_TYPE = pMaterialInRegister_RequestEntity.LANGUAGE_TYPE;

            ERR_NO = pMaterialInRegister_RequestEntity.ERR_NO;
            ERR_MSG = pMaterialInRegister_RequestEntity.ERR_MSG;
            RTN_KEY = pMaterialInRegister_RequestEntity.RTN_KEY;
            RTN_SEQ = pMaterialInRegister_RequestEntity.RTN_SEQ;
            RTN_AQ = pMaterialInRegister_RequestEntity.RTN_AQ;
            RTN_SQ = pMaterialInRegister_RequestEntity.RTN_SQ;
            RTN_OTHERS = pMaterialInRegister_RequestEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            pMaterialInRegister_RequestEntity.WINDOW_NAME = WINDOW_NAME;

            pMaterialInRegister_RequestEntity.DATE_FROM = DATE_FROM;
            pMaterialInRegister_RequestEntity.DATE_TO = DATE_TO;
            pMaterialInRegister_RequestEntity.PART_NAME = PART_NAME;
            pMaterialInRegister_RequestEntity.PART_CODE = PART_CODE;
            pMaterialInRegister_RequestEntity.VEND_NAME = VEND_NAME;
            pMaterialInRegister_RequestEntity.VEND_CODE = VEND_CODE;
            pMaterialInRegister_RequestEntity.INOUT_ID = INOUT_ID;

            pMaterialInRegister_RequestEntity.INOUT_DATE = INOUT_DATE;
            pMaterialInRegister_RequestEntity.INOUT_SEQ = INOUT_SEQ;
            pMaterialInRegister_RequestEntity.INOUT_TYPE = INOUT_TYPE;
            pMaterialInRegister_RequestEntity.INOUT_CODE = INOUT_CODE;
            pMaterialInRegister_RequestEntity.REFERENCE_ID = REFERENCE_ID;
            pMaterialInRegister_RequestEntity.INOUT_QTY = INOUT_QTY;
            pMaterialInRegister_RequestEntity.PART_UNIT = PART_UNIT;
            pMaterialInRegister_RequestEntity.UNITCOST = UNITCOST;
            pMaterialInRegister_RequestEntity.COST = COST;
            pMaterialInRegister_RequestEntity.REMARK = REMARK;
            pMaterialInRegister_RequestEntity.USE_YN = USE_YN;
            pMaterialInRegister_RequestEntity.END_DATE = END_DATE;
            pMaterialInRegister_RequestEntity.TOTAL_RESULT = TOTAL_RESULT;

            pMaterialInRegister_RequestEntity.VEND_PART_CODE = VEND_PART_CODE;

            
        }

        #endregion

    }

    public class MaterialInRegister_Request_T01Entity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; }

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
        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String VEND_NAME { get; set; }
        public String VEND_CODE { get; set; }
        public String INOUT_ID { get; set; }

        public String INOUT_DATE { get; set; }
        public String INOUT_SEQ { get; set; }
        public String INOUT_TYPE { get; set; }
        public String INOUT_CODE { get; set; }
        public String REFERENCE_ID { get; set; }
        public String INOUT_QTY { get; set; }
        public String PART_UNIT { get; set; }
        public String UNITCOST { get; set; }
        public String COST { get; set; }
        public String REMARK { get; set; }
        public String USE_YN { get; set; }
        public String END_DATE { get; set; }
        public String VEND_PART_CODE { get; set; }
        public String MATSTOCK_ID { get; set; }
        public String MATSTOCK_DATE { get; set; }
        public String MATSTOCK_SEQ { get; set; }
        public String MATSTOCK_CODE { get; set; }
        public String ORDER_ID { get; set; }
        public String MATSTOCK_DETAIL_SEQ { get; set; }
        public String MATSTOCK_SUB_ID { get; set; }
        public String MATSTOCK_SUB_SEQ { get; set; }
        public String MATSTOCK_SUB_NAME { get; set; }
        public String MATSTOCK_SUB_QTY { get; set; }

        #endregion

        #region 생성자 - MaterialInRegister_RequestEntity()

        public MaterialInRegister_Request_T01Entity()
        {
        }

        #endregion

        #region 생성자 - MaterialInRegister_Request_T01Entity(MaterialInRegister_Request_T01Entity pMaterialInRegister_Request_T01Entity)

        public MaterialInRegister_Request_T01Entity(MaterialInRegister_Request_T01Entity pMaterialInRegister_Request_T01Entity)
        {
            CORP_CODE = pMaterialInRegister_Request_T01Entity.CORP_CODE;
            CRUD = pMaterialInRegister_Request_T01Entity.CRUD;
            USER_CODE = pMaterialInRegister_Request_T01Entity.USER_CODE;
            LANGUAGE_TYPE = pMaterialInRegister_Request_T01Entity.LANGUAGE_TYPE;

            ERR_NO = pMaterialInRegister_Request_T01Entity.ERR_NO;
            ERR_MSG = pMaterialInRegister_Request_T01Entity.ERR_MSG;
            RTN_KEY = pMaterialInRegister_Request_T01Entity.RTN_KEY;
            RTN_SEQ = pMaterialInRegister_Request_T01Entity.RTN_SEQ;
            RTN_AQ = pMaterialInRegister_Request_T01Entity.RTN_AQ;
            RTN_SQ = pMaterialInRegister_Request_T01Entity.RTN_SQ;
            RTN_OTHERS = pMaterialInRegister_Request_T01Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            pMaterialInRegister_Request_T01Entity.WINDOW_NAME = WINDOW_NAME;

            pMaterialInRegister_Request_T01Entity.DATE_FROM = DATE_FROM;
            pMaterialInRegister_Request_T01Entity.DATE_TO = DATE_TO;
            pMaterialInRegister_Request_T01Entity.PART_NAME = PART_NAME;
            pMaterialInRegister_Request_T01Entity.PART_CODE = PART_CODE;
            pMaterialInRegister_Request_T01Entity.VEND_NAME = VEND_NAME;
            pMaterialInRegister_Request_T01Entity.VEND_CODE = VEND_CODE;
            pMaterialInRegister_Request_T01Entity.INOUT_ID = INOUT_ID;

            pMaterialInRegister_Request_T01Entity.INOUT_DATE = INOUT_DATE;
            pMaterialInRegister_Request_T01Entity.INOUT_SEQ = INOUT_SEQ;
            pMaterialInRegister_Request_T01Entity.INOUT_TYPE = INOUT_TYPE;
            pMaterialInRegister_Request_T01Entity.INOUT_CODE = INOUT_CODE;
            pMaterialInRegister_Request_T01Entity.REFERENCE_ID = REFERENCE_ID;
            pMaterialInRegister_Request_T01Entity.INOUT_QTY = INOUT_QTY;
            pMaterialInRegister_Request_T01Entity.PART_UNIT = PART_UNIT;
            pMaterialInRegister_Request_T01Entity.UNITCOST = UNITCOST;
            pMaterialInRegister_Request_T01Entity.COST = COST;
            pMaterialInRegister_Request_T01Entity.REMARK = REMARK;
            pMaterialInRegister_Request_T01Entity.USE_YN = USE_YN;
            pMaterialInRegister_Request_T01Entity.END_DATE = END_DATE;
            pMaterialInRegister_Request_T01Entity.VEND_PART_CODE = VEND_PART_CODE;

            pMaterialInRegister_Request_T01Entity.MATSTOCK_ID = MATSTOCK_ID;
            pMaterialInRegister_Request_T01Entity.MATSTOCK_DATE = MATSTOCK_DATE;
            pMaterialInRegister_Request_T01Entity.MATSTOCK_SEQ = MATSTOCK_SEQ;
            pMaterialInRegister_Request_T01Entity.MATSTOCK_CODE = MATSTOCK_CODE;

            pMaterialInRegister_Request_T01Entity.ORDER_ID = ORDER_ID;
            pMaterialInRegister_Request_T01Entity.MATSTOCK_DETAIL_SEQ = MATSTOCK_DETAIL_SEQ;
            pMaterialInRegister_Request_T01Entity.MATSTOCK_SUB_ID = MATSTOCK_SUB_ID;
            pMaterialInRegister_Request_T01Entity.MATSTOCK_SUB_SEQ = MATSTOCK_SUB_SEQ;
            pMaterialInRegister_Request_T01Entity.MATSTOCK_SUB_NAME = MATSTOCK_SUB_NAME;
            pMaterialInRegister_Request_T01Entity.MATSTOCK_SUB_QTY = MATSTOCK_SUB_QTY;
        }

        #endregion

    }

    public class MaterialInStatusEntity
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
        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String VEND_NAME { get; set; }
        public String VEND_CODE { get; set; }
        public String INOUT_ID { get; set; }

        #endregion

        #region 생성자 - MaterialInStatusEntity()

        public MaterialInStatusEntity()
        {
        }

        #endregion

        #region 생성자 - MaterialInStatusEntity(pMaterialInStatusEntity)

        public MaterialInStatusEntity(MaterialInStatusEntity pMaterialInStatusEntity)
        {
            CORP_CODE = pMaterialInStatusEntity.CORP_CODE;
            CRUD = pMaterialInStatusEntity.CRUD;
            USER_CODE = pMaterialInStatusEntity.USER_CODE;
            LANGUAGE_TYPE = pMaterialInStatusEntity.LANGUAGE_TYPE;

            pMaterialInStatusEntity.WINDOW_NAME = WINDOW_NAME;

            pMaterialInStatusEntity.DATE_FROM = DATE_FROM;
            pMaterialInStatusEntity.DATE_TO = DATE_TO;
            pMaterialInStatusEntity.PART_NAME = PART_NAME;
            pMaterialInStatusEntity.PART_CODE = PART_CODE;
            pMaterialInStatusEntity.VEND_NAME = VEND_NAME;
            pMaterialInStatusEntity.VEND_CODE = VEND_CODE;
            pMaterialInStatusEntity.INOUT_ID = INOUT_ID;

            ERR_NO = pMaterialInStatusEntity.ERR_NO;
            ERR_MSG = pMaterialInStatusEntity.ERR_MSG;
            RTN_KEY = pMaterialInStatusEntity.RTN_KEY;
            RTN_SEQ = pMaterialInStatusEntity.RTN_SEQ;
            RTN_OTHERS = pMaterialInStatusEntity.RTN_OTHERS;


            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }
    public class MaterialInStatus_T02Entity
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
        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String VEND_NAME { get; set; }
        public String VEND_CODE { get; set; }
        public String INOUT_ID { get; set; }

        #endregion

        #region 생성자 - MaterialInStatusEntity()

        public MaterialInStatus_T02Entity()
        {
        }

        #endregion

        #region 생성자 - MaterialInStatusEntity(pMaterialInStatusEntity)

        public MaterialInStatus_T02Entity(MaterialInStatus_T02Entity pMaterialInStatus_T02Entity)
        {
            CORP_CODE = pMaterialInStatus_T02Entity.CORP_CODE;
            CRUD = pMaterialInStatus_T02Entity.CRUD;
            USER_CODE = pMaterialInStatus_T02Entity.USER_CODE;
            LANGUAGE_TYPE = pMaterialInStatus_T02Entity.LANGUAGE_TYPE;

            pMaterialInStatus_T02Entity.WINDOW_NAME = WINDOW_NAME;

            pMaterialInStatus_T02Entity.DATE_FROM = DATE_FROM;
            pMaterialInStatus_T02Entity.DATE_TO = DATE_TO;
            pMaterialInStatus_T02Entity.PART_NAME = PART_NAME;
            pMaterialInStatus_T02Entity.PART_CODE = PART_CODE;
            pMaterialInStatus_T02Entity.VEND_NAME = VEND_NAME;
            pMaterialInStatus_T02Entity.VEND_CODE = VEND_CODE;
            pMaterialInStatus_T02Entity.INOUT_ID = INOUT_ID;

            ERR_NO = pMaterialInStatus_T02Entity.ERR_NO;
            ERR_MSG = pMaterialInStatus_T02Entity.ERR_MSG;
            RTN_KEY = pMaterialInStatus_T02Entity.RTN_KEY;
            RTN_SEQ = pMaterialInStatus_T02Entity.RTN_SEQ;
            RTN_OTHERS = pMaterialInStatus_T02Entity.RTN_OTHERS;


            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class MaterialManagementEntity
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
        public String SHEETINFO_ID { get; set; }
        public String WINDOW_NAME { get; set; }
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE
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

        #region 생성자 - MaterialManagementEntity()

        public MaterialManagementEntity()
        {
        }

        #endregion

        #region 생성자 - MaterialManagementEntity(pMaterialManagementEntity)

        public MaterialManagementEntity(MaterialManagementEntity pMaterialManagementEntity)
        {
            CORP_CODE = pMaterialManagementEntity.CORP_CODE;
            CRUD = pMaterialManagementEntity.CRUD;
            USER_CODE = pMaterialManagementEntity.USER_CODE;
            ERR_NO = pMaterialManagementEntity.ERR_NO;
            ERR_MSG = pMaterialManagementEntity.ERR_MSG;
            RTN_KEY = pMaterialManagementEntity.RTN_KEY;
            RTN_SEQ = pMaterialManagementEntity.RTN_SEQ;
            RTN_OTHERS = pMaterialManagementEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            SHEETINFO_ID = pMaterialManagementEntity.SHEETINFO_ID;
            WINDOW_NAME = pMaterialManagementEntity.WINDOW_NAME;
            LANGUAGE_TYPE = pMaterialManagementEntity.LANGUAGE_TYPE;
            PROCESS_CODE = pMaterialManagementEntity.PROCESS_CODE;
            FILE_TYPE = pMaterialManagementEntity.FILE_TYPE;
            FILE_NICKNAME = pMaterialManagementEntity.FILE_NICKNAME;
            FILE_NAME = pMaterialManagementEntity.FILE_NAME;
            DATE_FROM = pMaterialManagementEntity.DATE_FROM;
            DATE_TO = pMaterialManagementEntity.DATE_TO;
            USE_YN = pMaterialManagementEntity.USE_YN;
            DSP_SEQ = pMaterialManagementEntity.DSP_SEQ;
            USE_TYPE = pMaterialManagementEntity.USE_TYPE;
            REMARK = pMaterialManagementEntity.REMARK;
        }
        #endregion

    }

    public class MaterialNotInStatusEntity
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

        #region 생성자 - MaterialNotInStatusEntity()

        public MaterialNotInStatusEntity()
        {
        }

        #endregion

        #region 생성자 - MaterialNotInStatusEntity(pMaterialNotInStatusEntity)

        public MaterialNotInStatusEntity(MaterialNotInStatusEntity pMaterialNotInStatusEntity)
        {
            CORP_CODE = pMaterialNotInStatusEntity.CORP_CODE;
            CRUD = pMaterialNotInStatusEntity.CRUD;
            USER_CODE = pMaterialNotInStatusEntity.USER_CODE;
            LANGUAGE_TYPE = pMaterialNotInStatusEntity.LANGUAGE_TYPE;

            pMaterialNotInStatusEntity.DATE_FROM = DATE_FROM;
            pMaterialNotInStatusEntity.DATE_TO = DATE_TO;
            pMaterialNotInStatusEntity.PART_NAME = PART_NAME;
            pMaterialNotInStatusEntity.VEND_NAME = VEND_NAME;
            pMaterialNotInStatusEntity.ORDER_ID = ORDER_ID;

            ERR_NO = pMaterialNotInStatusEntity.ERR_NO;
            ERR_MSG = pMaterialNotInStatusEntity.ERR_MSG;
            RTN_KEY = pMaterialNotInStatusEntity.RTN_KEY;
            RTN_SEQ = pMaterialNotInStatusEntity.RTN_SEQ;
            RTN_OTHERS = pMaterialNotInStatusEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class MaterialOutRegisterEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // CRUD
        

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
        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String VEND_NAME { get; set; }
        public String VEND_CODE { get; set; }
        public String INOUT_ID { get; set; }

        public String INOUT_DATE { get; set; }
        public String INOUT_SEQ { get; set; }
        public String INOUT_TYPE { get; set; }
        public String INOUT_CODE { get; set; }
        public String REFERENCE_ID { get; set; }
        public String INOUT_QTY { get; set; }
        public String UNITCOST_CURRENCY_CODE { get; set; }
        public String UNITCOST { get; set; }
        public String COST { get; set; }
        public String REMARK { get; set; }
        public String USE_YN { get; set; }

        #endregion

        #region 생성자 - MaterialOutRegisterEntity()

        public MaterialOutRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - MaterialOutRegisterEntity(MaterialInRegisterEntity pMaterialInRegisterEntity)

        public MaterialOutRegisterEntity(MaterialOutRegisterEntity pMaterialOutRegisterEntity)
        {
            CORP_CODE = pMaterialOutRegisterEntity.CORP_CODE;
            CRUD = pMaterialOutRegisterEntity.CRUD;
            USER_CODE = pMaterialOutRegisterEntity.USER_CODE;
            LANGUAGE_TYPE = pMaterialOutRegisterEntity.LANGUAGE_TYPE;

            ERR_NO = pMaterialOutRegisterEntity.ERR_NO;
            ERR_MSG = pMaterialOutRegisterEntity.ERR_MSG;
            RTN_KEY = pMaterialOutRegisterEntity.RTN_KEY;
            RTN_SEQ = pMaterialOutRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pMaterialOutRegisterEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            pMaterialOutRegisterEntity.WINDOW_NAME = WINDOW_NAME;

            pMaterialOutRegisterEntity.DATE_FROM = DATE_FROM;
            pMaterialOutRegisterEntity.DATE_TO = DATE_TO;
            pMaterialOutRegisterEntity.PART_NAME = PART_NAME;
            pMaterialOutRegisterEntity.PART_CODE = PART_CODE;
            pMaterialOutRegisterEntity.VEND_NAME = VEND_NAME;
            pMaterialOutRegisterEntity.VEND_CODE = VEND_CODE;
            pMaterialOutRegisterEntity.INOUT_ID = INOUT_ID;
            
            pMaterialOutRegisterEntity.INOUT_DATE = INOUT_DATE;
            pMaterialOutRegisterEntity.INOUT_SEQ = INOUT_SEQ;
            pMaterialOutRegisterEntity.INOUT_TYPE = INOUT_TYPE;
            pMaterialOutRegisterEntity.INOUT_CODE = INOUT_CODE;
            pMaterialOutRegisterEntity.REFERENCE_ID = REFERENCE_ID;
            pMaterialOutRegisterEntity.INOUT_QTY = INOUT_QTY;
            pMaterialOutRegisterEntity.UNITCOST_CURRENCY_CODE = UNITCOST_CURRENCY_CODE;
            pMaterialOutRegisterEntity.UNITCOST = UNITCOST;
            pMaterialOutRegisterEntity.COST = COST;
            pMaterialOutRegisterEntity.REMARK = REMARK;
            pMaterialOutRegisterEntity.USE_YN = USE_YN;
        }

        #endregion

    }
    public class MaterialOutRegister_T01Entity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // CRUD
        public String USER_NAME { get; set; } // CRUD
        

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
        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String VEND_NAME { get; set; }
        public String VEND_CODE { get; set; }
        public String INOUT_ID { get; set; }

        public String INOUT_DATE { get; set; }
        public String INOUT_SEQ { get; set; }
        public String INOUT_TYPE { get; set; }
        public String INOUT_CODE { get; set; }
        public String REFERENCE_ID { get; set; }
        public String INOUT_QTY { get; set; }
        public String UNITCOST_CURRENCY_CODE { get; set; }
        public String UNITCOST { get; set; }
        public String COST { get; set; }
        public String REMARK { get; set; }
        public String VEND_PART_CODE { get; set; }
        public String USE_YN { get; set; }

        #endregion

        #region 생성자 - MaterialOutRegister_T01Entity()

        public MaterialOutRegister_T01Entity()
        {
        }

        #endregion

        #region 생성자 - MaterialOutRegister_T01Entity(MaterialInRegisterEntity pMaterialInRegisterEntity)

        public MaterialOutRegister_T01Entity(MaterialOutRegister_T01Entity pMaterialOutRegister_T01Entity)
        {
            CORP_CODE = pMaterialOutRegister_T01Entity.CORP_CODE;
            CRUD = pMaterialOutRegister_T01Entity.CRUD;
            USER_CODE = pMaterialOutRegister_T01Entity.USER_CODE;
            USER_NAME = pMaterialOutRegister_T01Entity.USER_NAME;

            ERR_NO = pMaterialOutRegister_T01Entity.ERR_NO;
            ERR_MSG = pMaterialOutRegister_T01Entity.ERR_MSG;
            RTN_KEY = pMaterialOutRegister_T01Entity.RTN_KEY;
            RTN_SEQ = pMaterialOutRegister_T01Entity.RTN_SEQ;
            RTN_OTHERS = pMaterialOutRegister_T01Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            pMaterialOutRegister_T01Entity.WINDOW_NAME = WINDOW_NAME;

            pMaterialOutRegister_T01Entity.DATE_FROM = DATE_FROM;
            pMaterialOutRegister_T01Entity.DATE_TO = DATE_TO;
            pMaterialOutRegister_T01Entity.PART_NAME = PART_NAME;
            pMaterialOutRegister_T01Entity.PART_CODE = PART_CODE;
            pMaterialOutRegister_T01Entity.VEND_NAME = VEND_NAME;
            pMaterialOutRegister_T01Entity.VEND_CODE = VEND_CODE;
            pMaterialOutRegister_T01Entity.INOUT_ID = INOUT_ID;

            pMaterialOutRegister_T01Entity.INOUT_DATE = INOUT_DATE;
            pMaterialOutRegister_T01Entity.INOUT_SEQ = INOUT_SEQ;
            pMaterialOutRegister_T01Entity.INOUT_TYPE = INOUT_TYPE;
            pMaterialOutRegister_T01Entity.INOUT_CODE = INOUT_CODE;
            pMaterialOutRegister_T01Entity.REFERENCE_ID = REFERENCE_ID;
            pMaterialOutRegister_T01Entity.INOUT_QTY = INOUT_QTY;
            pMaterialOutRegister_T01Entity.UNITCOST_CURRENCY_CODE = UNITCOST_CURRENCY_CODE;
            pMaterialOutRegister_T01Entity.UNITCOST = UNITCOST;
            pMaterialOutRegister_T01Entity.COST = COST;
            pMaterialOutRegister_T01Entity.REMARK = REMARK;
            pMaterialOutRegister_T01Entity.USE_YN = USE_YN;

            pMaterialOutRegister_T01Entity.LANGUAGE_TYPE = LANGUAGE_TYPE;
            pMaterialOutRegister_T01Entity.VEND_PART_CODE = VEND_PART_CODE;
            
        }

        #endregion

    }

    public class MaterialOutRegister_T02Entity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // CRUD


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
        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String VEND_NAME { get; set; }
        public String VEND_CODE { get; set; }
        public String INOUT_ID { get; set; }
        public String VEND_PART_CODE { get; set; }

        public String INOUT_DATE { get; set; }
        public String INOUT_SEQ { get; set; }
        public String INOUT_TYPE { get; set; }
        public String INOUT_CODE { get; set; }
        public String REFERENCE_ID { get; set; }
        public String INOUT_QTY { get; set; }
        public String UNITCOST_CURRENCY_CODE { get; set; }
        public String UNITCOST { get; set; }
        public String COST { get; set; }
        public String REMARK { get; set; }
        public String USE_YN { get; set; }

        #endregion

        #region 생성자 - MaterialOutRegister_T02Entity()

        public MaterialOutRegister_T02Entity()
        {
        }

        #endregion

        #region 생성자 - MaterialOutRegister_T02Entity(MaterialInRegisterEntity pMaterialInRegisterEntity)

        public MaterialOutRegister_T02Entity(MaterialOutRegister_T02Entity pMaterialOutRegister_T02Entity)
        {
            CORP_CODE = pMaterialOutRegister_T02Entity.CORP_CODE;
            CRUD = pMaterialOutRegister_T02Entity.CRUD;
            USER_CODE = pMaterialOutRegister_T02Entity.USER_CODE;


            ERR_NO = pMaterialOutRegister_T02Entity.ERR_NO;
            ERR_MSG = pMaterialOutRegister_T02Entity.ERR_MSG;
            RTN_KEY = pMaterialOutRegister_T02Entity.RTN_KEY;
            RTN_SEQ = pMaterialOutRegister_T02Entity.RTN_SEQ;
            RTN_OTHERS = pMaterialOutRegister_T02Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            pMaterialOutRegister_T02Entity.WINDOW_NAME = WINDOW_NAME;

            pMaterialOutRegister_T02Entity.DATE_FROM = DATE_FROM;
            pMaterialOutRegister_T02Entity.DATE_TO = DATE_TO;
            pMaterialOutRegister_T02Entity.PART_NAME = PART_NAME;
            pMaterialOutRegister_T02Entity.PART_CODE = PART_CODE;
            pMaterialOutRegister_T02Entity.VEND_NAME = VEND_NAME;
            pMaterialOutRegister_T02Entity.VEND_CODE = VEND_CODE;
            pMaterialOutRegister_T02Entity.INOUT_ID = INOUT_ID;
            pMaterialOutRegister_T02Entity.VEND_PART_CODE = VEND_PART_CODE;

            pMaterialOutRegister_T02Entity.INOUT_DATE = INOUT_DATE;
            pMaterialOutRegister_T02Entity.INOUT_SEQ = INOUT_SEQ;
            pMaterialOutRegister_T02Entity.INOUT_TYPE = INOUT_TYPE;
            pMaterialOutRegister_T02Entity.INOUT_CODE = INOUT_CODE;
            pMaterialOutRegister_T02Entity.REFERENCE_ID = REFERENCE_ID;
            pMaterialOutRegister_T02Entity.INOUT_QTY = INOUT_QTY;
            pMaterialOutRegister_T02Entity.UNITCOST_CURRENCY_CODE = UNITCOST_CURRENCY_CODE;
            pMaterialOutRegister_T02Entity.UNITCOST = UNITCOST;
            pMaterialOutRegister_T02Entity.COST = COST;
            pMaterialOutRegister_T02Entity.REMARK = REMARK;
            pMaterialOutRegister_T02Entity.USE_YN = USE_YN;

            pMaterialOutRegister_T02Entity.LANGUAGE_TYPE = LANGUAGE_TYPE;
        }

        #endregion

    }

    public class MaterialOutRegister_T03Entity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // CRUD


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
        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String VEND_NAME { get; set; }
        public String VEND_CODE { get; set; }
        public String INOUT_ID { get; set; }

        public String INOUT_DATE { get; set; }
        public String INOUT_SEQ { get; set; }
        public String INOUT_TYPE { get; set; }
        public String INOUT_CODE { get; set; }
        public String REFERENCE_ID { get; set; }
        public String INOUT_QTY { get; set; }
        public String UNITCOST_CURRENCY_CODE { get; set; }
        public String UNITCOST { get; set; }
        public String COST { get; set; }
        public String REMARK { get; set; }
        public String USE_YN { get; set; }
        public String LOCATION { get; set; }
        
        #endregion

        #region 생성자 - MaterialOutRegister_T03Entity()

        public MaterialOutRegister_T03Entity()
        {
        }

        #endregion

        #region 생성자 - MaterialOutRegister_T03Entity(MaterialInRegisterEntity pMaterialInRegisterEntity)

        public MaterialOutRegister_T03Entity(MaterialOutRegister_T03Entity pMaterialOutRegister_T03Entity)
        {
            CORP_CODE = pMaterialOutRegister_T03Entity.CORP_CODE;
            CRUD = pMaterialOutRegister_T03Entity.CRUD;
            USER_CODE = pMaterialOutRegister_T03Entity.USER_CODE;
            LANGUAGE_TYPE = pMaterialOutRegister_T03Entity.LANGUAGE_TYPE;

            ERR_NO = pMaterialOutRegister_T03Entity.ERR_NO;
            ERR_MSG = pMaterialOutRegister_T03Entity.ERR_MSG;
            RTN_KEY = pMaterialOutRegister_T03Entity.RTN_KEY;
            RTN_SEQ = pMaterialOutRegister_T03Entity.RTN_SEQ;
            RTN_OTHERS = pMaterialOutRegister_T03Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            pMaterialOutRegister_T03Entity.WINDOW_NAME = WINDOW_NAME;

            pMaterialOutRegister_T03Entity.DATE_FROM = DATE_FROM;
            pMaterialOutRegister_T03Entity.DATE_TO = DATE_TO;
            pMaterialOutRegister_T03Entity.PART_NAME = PART_NAME;
            pMaterialOutRegister_T03Entity.PART_CODE = PART_CODE;
            pMaterialOutRegister_T03Entity.VEND_NAME = VEND_NAME;
            pMaterialOutRegister_T03Entity.VEND_CODE = VEND_CODE;
            pMaterialOutRegister_T03Entity.INOUT_ID = INOUT_ID;

            pMaterialOutRegister_T03Entity.INOUT_DATE = INOUT_DATE;
            pMaterialOutRegister_T03Entity.INOUT_SEQ = INOUT_SEQ;
            pMaterialOutRegister_T03Entity.INOUT_TYPE = INOUT_TYPE;
            pMaterialOutRegister_T03Entity.INOUT_CODE = INOUT_CODE;
            pMaterialOutRegister_T03Entity.REFERENCE_ID = REFERENCE_ID;
            pMaterialOutRegister_T03Entity.INOUT_QTY = INOUT_QTY;
            pMaterialOutRegister_T03Entity.UNITCOST_CURRENCY_CODE = UNITCOST_CURRENCY_CODE;
            pMaterialOutRegister_T03Entity.UNITCOST = UNITCOST;
            pMaterialOutRegister_T03Entity.COST = COST;
            pMaterialOutRegister_T03Entity.REMARK = REMARK;
            pMaterialOutRegister_T03Entity.USE_YN = USE_YN;
            pMaterialOutRegister_T03Entity.LOCATION = LOCATION;

            
        }

        #endregion

    }

    public class PartMoveRegisterEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // CRUD


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
        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String VEND_NAME { get; set; }
        public String VEND_CODE { get; set; }
        public String INOUT_ID { get; set; }

        public String LOCATION_OUT { get; set; }
        public String LOCATION_IN { get; set; }

        public String INOUT_DATE { get; set; }
        public String INOUT_SEQ { get; set; }
        public String INOUT_TYPE { get; set; }
        public String INOUT_CODE { get; set; }
        public String REFERENCE_ID { get; set; }
        public String INOUT_QTY { get; set; }
        public String UNITCOST_CURRENCY_CODE { get; set; }
        public String UNITCOST { get; set; }
        public String COST { get; set; }
        public String REMARK { get; set; }
        public String USE_YN { get; set; }
        public String LOCATION { get; set; }

        #endregion

        #region 생성자 - PartMoveRegisterEntity()

        public PartMoveRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - PartMoveRegisterEntity(MaterialInRegisterEntity pMaterialInRegisterEntity)

        public PartMoveRegisterEntity(PartMoveRegisterEntity pPartMoveRegisterEntity)
        {
            CORP_CODE = pPartMoveRegisterEntity.CORP_CODE;
            CRUD = pPartMoveRegisterEntity.CRUD;
            USER_CODE = pPartMoveRegisterEntity.USER_CODE;
            LANGUAGE_TYPE = pPartMoveRegisterEntity.LANGUAGE_TYPE;

            ERR_NO = pPartMoveRegisterEntity.ERR_NO;
            ERR_MSG = pPartMoveRegisterEntity.ERR_MSG;
            RTN_KEY = pPartMoveRegisterEntity.RTN_KEY;
            RTN_SEQ = pPartMoveRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pPartMoveRegisterEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            pPartMoveRegisterEntity.WINDOW_NAME = WINDOW_NAME;

            pPartMoveRegisterEntity.DATE_FROM = DATE_FROM;
            pPartMoveRegisterEntity.DATE_TO = DATE_TO;
            pPartMoveRegisterEntity.PART_NAME = PART_NAME;
            pPartMoveRegisterEntity.PART_CODE = PART_CODE;
            pPartMoveRegisterEntity.VEND_NAME = VEND_NAME;
            pPartMoveRegisterEntity.VEND_CODE = VEND_CODE;
            pPartMoveRegisterEntity.INOUT_ID = INOUT_ID;

            pPartMoveRegisterEntity.INOUT_DATE = INOUT_DATE;
            pPartMoveRegisterEntity.INOUT_SEQ = INOUT_SEQ;
            pPartMoveRegisterEntity.INOUT_TYPE = INOUT_TYPE;
            pPartMoveRegisterEntity.INOUT_CODE = INOUT_CODE;
            pPartMoveRegisterEntity.REFERENCE_ID = REFERENCE_ID;
            pPartMoveRegisterEntity.INOUT_QTY = INOUT_QTY;
            pPartMoveRegisterEntity.UNITCOST_CURRENCY_CODE = UNITCOST_CURRENCY_CODE;
            pPartMoveRegisterEntity.UNITCOST = UNITCOST;
            pPartMoveRegisterEntity.COST = COST;
            pPartMoveRegisterEntity.REMARK = REMARK;
            pPartMoveRegisterEntity.USE_YN = USE_YN;
            pPartMoveRegisterEntity.LOCATION = LOCATION;
            pPartMoveRegisterEntity.LOCATION_OUT = LOCATION_OUT;
            pPartMoveRegisterEntity.LOCATION_IN = LOCATION_IN;


        }

        #endregion

    }
    public class MaterialOutStatusEntity
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

        #region 생성자 - MaterialOutStatusEntity()

        public MaterialOutStatusEntity()
        {
        }

        #endregion

        #region 생성자 - MaterialOutStatusEntity(pMaterialOutStatusEntity)

        public MaterialOutStatusEntity(MaterialOutStatusEntity pMaterialOutStatusEntity)
        {
            CORP_CODE = pMaterialOutStatusEntity.CORP_CODE;
            CRUD = pMaterialOutStatusEntity.CRUD;
            USER_CODE = pMaterialOutStatusEntity.USER_CODE;

            LANGUAGE_TYPE = pMaterialOutStatusEntity.LANGUAGE_TYPE;

            pMaterialOutStatusEntity.DATE_FROM = DATE_FROM;
            pMaterialOutStatusEntity.DATE_TO = DATE_TO;
            pMaterialOutStatusEntity.PART_NAME = PART_NAME;
            pMaterialOutStatusEntity.VEND_NAME = VEND_NAME;
            pMaterialOutStatusEntity.ORDER_ID = ORDER_ID;

            ERR_NO = pMaterialOutStatusEntity.ERR_NO;
            ERR_MSG = pMaterialOutStatusEntity.ERR_MSG;
            RTN_KEY = pMaterialOutStatusEntity.RTN_KEY;
            RTN_SEQ = pMaterialOutStatusEntity.RTN_SEQ;
            RTN_OTHERS = pMaterialOutStatusEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }
    public class MaterialOutStatus_T02Entity
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
        public String PART_CODE { get; set; }
        public String INOUT_ID { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - MaterialOutStatusEntity()

        public MaterialOutStatus_T02Entity()
        {
        }

        #endregion

        #region 생성자 - MaterialOutStatusEntity(pMaterialOutStatusEntity)

        public MaterialOutStatus_T02Entity(MaterialOutStatus_T02Entity pMaterialOutStatus_T02Entity)
        {
            CORP_CODE = pMaterialOutStatus_T02Entity.CORP_CODE;
            CRUD = pMaterialOutStatus_T02Entity.CRUD;
            USER_CODE = pMaterialOutStatus_T02Entity.USER_CODE;

            LANGUAGE_TYPE = pMaterialOutStatus_T02Entity.LANGUAGE_TYPE;

            pMaterialOutStatus_T02Entity.DATE_FROM = DATE_FROM;
            pMaterialOutStatus_T02Entity.DATE_TO = DATE_TO;
            pMaterialOutStatus_T02Entity.PART_NAME = PART_NAME;
            pMaterialOutStatus_T02Entity.VEND_NAME = VEND_NAME;
            pMaterialOutStatus_T02Entity.ORDER_ID = ORDER_ID;
            pMaterialOutStatus_T02Entity.INOUT_ID = INOUT_ID;
            pMaterialOutStatus_T02Entity.PART_CODE = PART_CODE;

            ERR_NO = pMaterialOutStatus_T02Entity.ERR_NO;
            ERR_MSG = pMaterialOutStatus_T02Entity.ERR_MSG;
            RTN_KEY = pMaterialOutStatus_T02Entity.RTN_KEY;
            RTN_SEQ = pMaterialOutStatus_T02Entity.RTN_SEQ;
            RTN_OTHERS = pMaterialOutStatus_T02Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }
    public class MaterialStockStatusEntity
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

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - MaterialStockStatusEntity()

        public MaterialStockStatusEntity()
        {
        }

        #endregion

        #region 생성자 - MaterialStockStatusEntity(pMaterialStockStatusEntity)

        public MaterialStockStatusEntity(MaterialStockStatusEntity pMaterialStockStatusEntity)
        {
            CORP_CODE = pMaterialStockStatusEntity.CORP_CODE;
            CRUD = pMaterialStockStatusEntity.CRUD;
            USER_CODE = pMaterialStockStatusEntity.USER_CODE;

            LANGUAGE_TYPE = pMaterialStockStatusEntity.LANGUAGE_TYPE;


            pMaterialStockStatusEntity.PART_TYPE = PART_TYPE;
            pMaterialStockStatusEntity.PART_NAME = PART_NAME;
            pMaterialStockStatusEntity.PART_CODE = PART_CODE;

            ERR_NO = pMaterialStockStatusEntity.ERR_NO;
            ERR_MSG = pMaterialStockStatusEntity.ERR_MSG;
            RTN_KEY = pMaterialStockStatusEntity.RTN_KEY;
            RTN_SEQ = pMaterialStockStatusEntity.RTN_SEQ;
            RTN_OTHERS = pMaterialStockStatusEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class MaterialStockStatus_T01Entity
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

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - MaterialStockStatus_T01Entity()

        public MaterialStockStatus_T01Entity()
        {
        }

        #endregion

        #region 생성자 - MaterialStockStatus_T01Entity(pMaterialStockStatus_T01Entity)

        public MaterialStockStatus_T01Entity(MaterialStockStatus_T01Entity pMaterialStockStatus_T01Entity)
        {
            CORP_CODE = pMaterialStockStatus_T01Entity.CORP_CODE;
            CRUD = pMaterialStockStatus_T01Entity.CRUD;
            USER_CODE = pMaterialStockStatus_T01Entity.USER_CODE;

            LANGUAGE_TYPE = pMaterialStockStatus_T01Entity.LANGUAGE_TYPE;


            pMaterialStockStatus_T01Entity.PART_TYPE = PART_TYPE;
            pMaterialStockStatus_T01Entity.PART_NAME = PART_NAME;
            pMaterialStockStatus_T01Entity.PART_CODE = PART_CODE;

            ERR_NO = pMaterialStockStatus_T01Entity.ERR_NO;
            ERR_MSG = pMaterialStockStatus_T01Entity.ERR_MSG;
            RTN_KEY = pMaterialStockStatus_T01Entity.RTN_KEY;
            RTN_SEQ = pMaterialStockStatus_T01Entity.RTN_SEQ;
            RTN_OTHERS = pMaterialStockStatus_T01Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class MaterialStockStatus_T02Entity
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

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - MaterialStockStatus_T02Entity()

        public MaterialStockStatus_T02Entity()
        {
        }

        #endregion

        #region 생성자 - MaterialStockStatus_T02Entity(pMaterialStockStatus_T02Entity)

        public MaterialStockStatus_T02Entity(MaterialStockStatus_T02Entity pMaterialStockStatus_T02Entity)
        {
            CORP_CODE = pMaterialStockStatus_T02Entity.CORP_CODE;
            CRUD = pMaterialStockStatus_T02Entity.CRUD;
            USER_CODE = pMaterialStockStatus_T02Entity.USER_CODE;

            LANGUAGE_TYPE = pMaterialStockStatus_T02Entity.LANGUAGE_TYPE;


            pMaterialStockStatus_T02Entity.PART_TYPE = PART_TYPE;
            pMaterialStockStatus_T02Entity.PART_NAME = PART_NAME;
            pMaterialStockStatus_T02Entity.PART_CODE = PART_CODE;
            pMaterialStockStatus_T02Entity.VEND_PART_CODE = VEND_PART_CODE;

            ERR_NO = pMaterialStockStatus_T02Entity.ERR_NO;
            ERR_MSG = pMaterialStockStatus_T02Entity.ERR_MSG;
            RTN_KEY = pMaterialStockStatus_T02Entity.RTN_KEY;
            RTN_SEQ = pMaterialStockStatus_T02Entity.RTN_SEQ;
            RTN_OTHERS = pMaterialStockStatus_T02Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }
    public class MaterialStockStatus_T04Entity
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

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - MaterialStockStatus_T04Entity()

        public MaterialStockStatus_T04Entity()
        {
        }

        #endregion

        #region 생성자 - MaterialStockStatus_T04Entity(pMaterialStockStatus_T04Entity)

        public MaterialStockStatus_T04Entity(MaterialStockStatus_T04Entity pMaterialStockStatus_T04Entity)
        {
            CORP_CODE = pMaterialStockStatus_T04Entity.CORP_CODE;
            CRUD = pMaterialStockStatus_T04Entity.CRUD;
            USER_CODE = pMaterialStockStatus_T04Entity.USER_CODE;

            LANGUAGE_TYPE = pMaterialStockStatus_T04Entity.LANGUAGE_TYPE;


            pMaterialStockStatus_T04Entity.PART_TYPE = PART_TYPE;
            pMaterialStockStatus_T04Entity.PART_NAME = PART_NAME;
            pMaterialStockStatus_T04Entity.PART_CODE = PART_CODE;
            pMaterialStockStatus_T04Entity.VEND_PART_CODE = VEND_PART_CODE;

            ERR_NO = pMaterialStockStatus_T04Entity.ERR_NO;
            ERR_MSG = pMaterialStockStatus_T04Entity.ERR_MSG;
            RTN_KEY = pMaterialStockStatus_T04Entity.RTN_KEY;
            RTN_SEQ = pMaterialStockStatus_T04Entity.RTN_SEQ;
            RTN_OTHERS = pMaterialStockStatus_T04Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }
    public class MaterialStockStatus_T05Entity
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

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - MaterialStockStatus_T05Entity()

        public MaterialStockStatus_T05Entity()
        {
        }

        #endregion

        #region 생성자 - MaterialStockStatus_T05Entity(pMaterialStockStatus_T05Entity)

        public MaterialStockStatus_T05Entity(MaterialStockStatus_T05Entity pMaterialStockStatus_T05Entity)
        {
            CORP_CODE = pMaterialStockStatus_T05Entity.CORP_CODE;
            CRUD = pMaterialStockStatus_T05Entity.CRUD;
            USER_CODE = pMaterialStockStatus_T05Entity.USER_CODE;

            LANGUAGE_TYPE = pMaterialStockStatus_T05Entity.LANGUAGE_TYPE;


            pMaterialStockStatus_T05Entity.PART_TYPE = PART_TYPE;
            pMaterialStockStatus_T05Entity.PART_NAME = PART_NAME;
            pMaterialStockStatus_T05Entity.PART_CODE = PART_CODE;
            pMaterialStockStatus_T05Entity.VEND_PART_CODE = VEND_PART_CODE;
            

            ERR_NO = pMaterialStockStatus_T05Entity.ERR_NO;
            ERR_MSG = pMaterialStockStatus_T05Entity.ERR_MSG;
            RTN_KEY = pMaterialStockStatus_T05Entity.RTN_KEY;
            RTN_SEQ = pMaterialStockStatus_T05Entity.RTN_SEQ;
            RTN_OTHERS = pMaterialStockStatus_T05Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }
    public class ProcessMaterialStockStatusEntity
    {
        #region Property
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

        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }
        #endregion

        #region 생성자 - ProcessMaterialStockStatusEntity()
        public ProcessMaterialStockStatusEntity() { }
        #endregion

        #region 생성자 - ProcessMaterialStockStatusEntity(ProcessMaterialStockStatusEntity pProcessMaterialStockStatusEntity)
        public ProcessMaterialStockStatusEntity(ProcessMaterialStockStatusEntity pProcessMaterialStockStatusEntity)
        {
            if (pProcessMaterialStockStatusEntity == null)
                return;

            pProcessMaterialStockStatusEntity.CORP_CODE = CORP_CODE;
            pProcessMaterialStockStatusEntity.USER_CODE = USER_CODE;
            pProcessMaterialStockStatusEntity.CRUD = CRUD;

            LANGUAGE_TYPE = pProcessMaterialStockStatusEntity.LANGUAGE_TYPE;

            pProcessMaterialStockStatusEntity.DATE_FROM = DATE_FROM;
            pProcessMaterialStockStatusEntity.DATE_TO = DATE_TO;
            pProcessMaterialStockStatusEntity.PART_NAME = PART_NAME;
            pProcessMaterialStockStatusEntity.VEND_NAME = VEND_NAME;

            pProcessMaterialStockStatusEntity.ORDER_ID = ORDER_ID;

            ERR_NO = pProcessMaterialStockStatusEntity.ERR_NO;
            ERR_MSG = pProcessMaterialStockStatusEntity.ERR_MSG;
            RTN_KEY = pProcessMaterialStockStatusEntity.RTN_KEY;
            RTN_SEQ = pProcessMaterialStockStatusEntity.RTN_SEQ;
            RTN_OTHERS = pProcessMaterialStockStatusEntity.RTN_OTHERS;
        }
        #endregion
    }

    public class MaterialInformationRegisterEntity
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

        public String VEND_CODE { get; set; } // 단가 조회 (상세)

        //고정 엔티티

        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }

        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - MaterialInformationRegisterEntity()

        public MaterialInformationRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - MaterialInformationRegisterEntity(pMaterialInformationRegisterEntity)

        public MaterialInformationRegisterEntity(MaterialInformationRegisterEntity pMaterialInformationRegisterEntity)
        {
            CORP_CODE = pMaterialInformationRegisterEntity.CORP_CODE;
            CRUD = pMaterialInformationRegisterEntity.CRUD;
            PART_CODE = pMaterialInformationRegisterEntity.PART_CODE;
            PART_REVISION_NO = pMaterialInformationRegisterEntity.PART_REVISION_NO;
            PART_NAME = pMaterialInformationRegisterEntity.PART_NAME;
            PART_TYPE = pMaterialInformationRegisterEntity.PART_TYPE;
            VEND_PART_CODE = pMaterialInformationRegisterEntity.VEND_PART_CODE;
            PART_UNIT = pMaterialInformationRegisterEntity.PART_UNIT;
            PART_STANDARD = pMaterialInformationRegisterEntity.PART_STANDARD;
            PART_MANUFACTURER = pMaterialInformationRegisterEntity.PART_MANUFACTURER;
            PART_COST = pMaterialInformationRegisterEntity.PART_COST;
            PART_SAFE_STOCK = pMaterialInformationRegisterEntity.PART_SAFE_STOCK;
            PART_START_DATE = pMaterialInformationRegisterEntity.PART_START_DATE;
            PART_END_DATE = pMaterialInformationRegisterEntity.PART_END_DATE;
            SALE_YN = pMaterialInformationRegisterEntity.SALE_YN;
            PURC_YN = pMaterialInformationRegisterEntity.PURC_YN;
            OUTT_YN = pMaterialInformationRegisterEntity.OUTT_YN;
            USE_YN = pMaterialInformationRegisterEntity.USE_YN;
            REMARK = pMaterialInformationRegisterEntity.REMARK;
            IMAGE_NAME = pMaterialInformationRegisterEntity.IMAGE_NAME;


            LANGUAGE_TYPE = pMaterialInformationRegisterEntity.LANGUAGE_TYPE;


            VEND_CODE = pMaterialInformationRegisterEntity.VEND_CODE;

            ERR_NO = pMaterialInformationRegisterEntity.ERR_NO;
            ERR_MSG = pMaterialInformationRegisterEntity.ERR_MSG;
            RTN_KEY = pMaterialInformationRegisterEntity.RTN_KEY;
            RTN_SEQ = pMaterialInformationRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pMaterialInformationRegisterEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class MaterialInformationRegister_T01Entity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE


        //마스터
        public String CONTRACT_ID { get; set; }
        public String CONTRACT_NUMBER { get; set; }
        public String CONTRACT_NUMBER_QTY { get; set; }
        public String PART_CODE { get; set; }
        public String PART_REVISION_NO { get; set; }
        public String PART_NAME { get; set; }
        public String PART_TYPE { get; set; }
        public String VEND_PART_CODE { get; set; }
        public String PART_HIGH { get; set; }
        public String PART_MIDDLE { get; set; }
        public String PART_LOW { get; set; }
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

        public String VEND_CODE { get; set; } // 단가 조회 (상세)

        //고정 엔티티

        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }

        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - MaterialInformationRegister_T01Entity()

        public MaterialInformationRegister_T01Entity()
        {
        }

        #endregion

        #region 생성자 - MaterialInformationRegister_T01Entity(pMaterialInformationRegister_T01Entity)

        public MaterialInformationRegister_T01Entity(MaterialInformationRegister_T01Entity pMaterialInformationRegister_T01Entity)
        {
            CORP_CODE = pMaterialInformationRegister_T01Entity.CORP_CODE;
            CRUD = pMaterialInformationRegister_T01Entity.CRUD;

            CONTRACT_ID = pMaterialInformationRegister_T01Entity.CONTRACT_ID;
            CONTRACT_NUMBER = pMaterialInformationRegister_T01Entity.CONTRACT_NUMBER;
            CONTRACT_NUMBER_QTY = pMaterialInformationRegister_T01Entity.CONTRACT_NUMBER_QTY;

            PART_CODE = pMaterialInformationRegister_T01Entity.PART_CODE;
            PART_REVISION_NO = pMaterialInformationRegister_T01Entity.PART_REVISION_NO;
            PART_NAME = pMaterialInformationRegister_T01Entity.PART_NAME;
            PART_TYPE = pMaterialInformationRegister_T01Entity.PART_TYPE;
            VEND_PART_CODE = pMaterialInformationRegister_T01Entity.VEND_PART_CODE;

            PART_HIGH = pMaterialInformationRegister_T01Entity.PART_HIGH;
            PART_MIDDLE = pMaterialInformationRegister_T01Entity.PART_MIDDLE;
            PART_LOW = pMaterialInformationRegister_T01Entity.PART_LOW;

            PART_UNIT = pMaterialInformationRegister_T01Entity.PART_UNIT;
            PART_STANDARD = pMaterialInformationRegister_T01Entity.PART_STANDARD;
            PART_MANUFACTURER = pMaterialInformationRegister_T01Entity.PART_MANUFACTURER;
            PART_COST = pMaterialInformationRegister_T01Entity.PART_COST;
            PART_SAFE_STOCK = pMaterialInformationRegister_T01Entity.PART_SAFE_STOCK;
            PART_START_DATE = pMaterialInformationRegister_T01Entity.PART_START_DATE;
            PART_END_DATE = pMaterialInformationRegister_T01Entity.PART_END_DATE;
            SALE_YN = pMaterialInformationRegister_T01Entity.SALE_YN;
            PURC_YN = pMaterialInformationRegister_T01Entity.PURC_YN;
            OUTT_YN = pMaterialInformationRegister_T01Entity.OUTT_YN;
            USE_YN = pMaterialInformationRegister_T01Entity.USE_YN;
            REMARK = pMaterialInformationRegister_T01Entity.REMARK;
            IMAGE_NAME = pMaterialInformationRegister_T01Entity.IMAGE_NAME;
            LANGUAGE_TYPE = pMaterialInformationRegister_T01Entity.LANGUAGE_TYPE;
            VEND_CODE = pMaterialInformationRegister_T01Entity.VEND_CODE;

            ERR_NO = pMaterialInformationRegister_T01Entity.ERR_NO;
            ERR_MSG = pMaterialInformationRegister_T01Entity.ERR_MSG;
            RTN_KEY = pMaterialInformationRegister_T01Entity.RTN_KEY;
            RTN_SEQ = pMaterialInformationRegister_T01Entity.RTN_SEQ;
            RTN_OTHERS = pMaterialInformationRegister_T01Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }
    

    public class FrequentPartHistoryEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE


        //마스터
        public String CONTRACT_ID { get; set; }
        public String CONTRACT_NUMBER { get; set; }
        public String CONTRACT_NUMBER_QTY { get; set; }
        public String PART_CODE { get; set; }
        public String PART_REVISION_NO { get; set; }
        public String PART_NAME { get; set; }
        public String PART_TYPE { get; set; }
        public String VEND_PART_CODE { get; set; }
        public String PART_HIGH { get; set; }
        public String PART_MIDDLE { get; set; }
        public String PART_LOW { get; set; }
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

        public String VEND_CODE { get; set; } // 단가 조회 (상세)
        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }

        //고정 엔티티

        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }

        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - FrequentPartHistoryEntity()

        public FrequentPartHistoryEntity()
        {
        }

        #endregion

        #region 생성자 - FrequentPartHistoryEntity(FrequentPartHistoryEntity pFrequentPartHistoryEntity)

        public FrequentPartHistoryEntity(FrequentPartHistoryEntity pFrequentPartHistoryEntity)
        {
            CORP_CODE = pFrequentPartHistoryEntity.CORP_CODE;
            CRUD = pFrequentPartHistoryEntity.CRUD;

            CONTRACT_ID = pFrequentPartHistoryEntity.CONTRACT_ID;
            CONTRACT_NUMBER = pFrequentPartHistoryEntity.CONTRACT_NUMBER;
            CONTRACT_NUMBER_QTY = pFrequentPartHistoryEntity.CONTRACT_NUMBER_QTY;

            PART_CODE = pFrequentPartHistoryEntity.PART_CODE;
            PART_REVISION_NO = pFrequentPartHistoryEntity.PART_REVISION_NO;
            PART_NAME = pFrequentPartHistoryEntity.PART_NAME;
            PART_TYPE = pFrequentPartHistoryEntity.PART_TYPE;
            VEND_PART_CODE = pFrequentPartHistoryEntity.VEND_PART_CODE;

            PART_HIGH = pFrequentPartHistoryEntity.PART_HIGH;
            PART_MIDDLE = pFrequentPartHistoryEntity.PART_MIDDLE;
            PART_LOW = pFrequentPartHistoryEntity.PART_LOW;

            PART_UNIT = pFrequentPartHistoryEntity.PART_UNIT;
            PART_STANDARD = pFrequentPartHistoryEntity.PART_STANDARD;
            PART_MANUFACTURER = pFrequentPartHistoryEntity.PART_MANUFACTURER;
            PART_COST = pFrequentPartHistoryEntity.PART_COST;
            PART_SAFE_STOCK = pFrequentPartHistoryEntity.PART_SAFE_STOCK;
            PART_START_DATE = pFrequentPartHistoryEntity.PART_START_DATE;
            PART_END_DATE = pFrequentPartHistoryEntity.PART_END_DATE;
            SALE_YN = pFrequentPartHistoryEntity.SALE_YN;
            PURC_YN = pFrequentPartHistoryEntity.PURC_YN;
            OUTT_YN = pFrequentPartHistoryEntity.OUTT_YN;
            USE_YN = pFrequentPartHistoryEntity.USE_YN;
            REMARK = pFrequentPartHistoryEntity.REMARK;
            IMAGE_NAME = pFrequentPartHistoryEntity.IMAGE_NAME;
            LANGUAGE_TYPE = pFrequentPartHistoryEntity.LANGUAGE_TYPE;
            VEND_CODE = pFrequentPartHistoryEntity.VEND_CODE;
            DATE_FROM = pFrequentPartHistoryEntity.DATE_FROM;
            DATE_TO = pFrequentPartHistoryEntity.DATE_TO;

            ERR_NO = pFrequentPartHistoryEntity.ERR_NO;
            ERR_MSG = pFrequentPartHistoryEntity.ERR_MSG;
            RTN_KEY = pFrequentPartHistoryEntity.RTN_KEY;
            RTN_SEQ = pFrequentPartHistoryEntity.RTN_SEQ;
            RTN_OTHERS = pFrequentPartHistoryEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class MaterialInformationRegister_T02Entity
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
        public byte[] File_String { get; set; }
        
       



        public String VEND_CODE { get; set; } // 단가 조회 (상세)

        //고정 엔티티

        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }

        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - MaterialInformationRegister_T02Entity()

        public MaterialInformationRegister_T02Entity()
        {
        }

        #endregion

        #region 생성자 - MaterialInformationRegister_T02Entity(pMaterialInformationRegister_T02Entity)

        public MaterialInformationRegister_T02Entity(MaterialInformationRegister_T02Entity pMaterialInformationRegister_T02Entity)
        {
            CORP_CODE = pMaterialInformationRegister_T02Entity.CORP_CODE;
            CRUD = pMaterialInformationRegister_T02Entity.CRUD;
            PART_CODE = pMaterialInformationRegister_T02Entity.PART_CODE;
            PART_REVISION_NO = pMaterialInformationRegister_T02Entity.PART_REVISION_NO;
            PART_NAME = pMaterialInformationRegister_T02Entity.PART_NAME;
            PART_TYPE = pMaterialInformationRegister_T02Entity.PART_TYPE;
            VEND_PART_CODE = pMaterialInformationRegister_T02Entity.VEND_PART_CODE;
            PART_UNIT = pMaterialInformationRegister_T02Entity.PART_UNIT;
            PART_STANDARD = pMaterialInformationRegister_T02Entity.PART_STANDARD;
            PART_MANUFACTURER = pMaterialInformationRegister_T02Entity.PART_MANUFACTURER;
            PART_COST = pMaterialInformationRegister_T02Entity.PART_COST;
            PART_SAFE_STOCK = pMaterialInformationRegister_T02Entity.PART_SAFE_STOCK;
            PART_START_DATE = pMaterialInformationRegister_T02Entity.PART_START_DATE;
            PART_END_DATE = pMaterialInformationRegister_T02Entity.PART_END_DATE;
            SALE_YN = pMaterialInformationRegister_T02Entity.SALE_YN;
            PURC_YN = pMaterialInformationRegister_T02Entity.PURC_YN;
            OUTT_YN = pMaterialInformationRegister_T02Entity.OUTT_YN;
            USE_YN = pMaterialInformationRegister_T02Entity.USE_YN;
            REMARK = pMaterialInformationRegister_T02Entity.REMARK;
            IMAGE_NAME = pMaterialInformationRegister_T02Entity.IMAGE_NAME;
            File_String = pMaterialInformationRegister_T02Entity.File_String;


            LANGUAGE_TYPE = pMaterialInformationRegister_T02Entity.LANGUAGE_TYPE;


            VEND_CODE = pMaterialInformationRegister_T02Entity.VEND_CODE;

            ERR_NO = pMaterialInformationRegister_T02Entity.ERR_NO;
            ERR_MSG = pMaterialInformationRegister_T02Entity.ERR_MSG;
            RTN_KEY = pMaterialInformationRegister_T02Entity.RTN_KEY;
            RTN_SEQ = pMaterialInformationRegister_T02Entity.RTN_SEQ;
            RTN_OTHERS = pMaterialInformationRegister_T02Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ucMaterialVendCostInfoListPopupEntity
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
        public String VEND_PART_CODE { get; set; }
        public String PART_REVISION_NO { get; set; }

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

        #region 생성자 - ucMaterialVendCostInfoListPopupEntity()

        public ucMaterialVendCostInfoListPopupEntity()
        {
        }

        #endregion

        #region 생성자 - ucVendCostInfoListPopupEntity(ucMaterialVendCostInfoListPopupEntity pucMaterialVendCostInfoListPopupEntity)

        public ucMaterialVendCostInfoListPopupEntity(ucMaterialVendCostInfoListPopupEntity pucMaterialVendCostInfoListPopupEntity)
        {
            CORP_CODE = pucMaterialVendCostInfoListPopupEntity.CORP_CODE;
            CRUD = pucMaterialVendCostInfoListPopupEntity.CRUD;
            USER_CODE = pucMaterialVendCostInfoListPopupEntity.USER_CODE;
            LANGUAGE_TYPE = pucMaterialVendCostInfoListPopupEntity.LANGUAGE_TYPE;
            WINDOW_NAME = pucMaterialVendCostInfoListPopupEntity.WINDOW_NAME;

            PART_CODE = pucMaterialVendCostInfoListPopupEntity.PART_CODE;
            PART_NAME = pucMaterialVendCostInfoListPopupEntity.PART_NAME;
            PART_REVISION_NO = pucMaterialVendCostInfoListPopupEntity.PART_REVISION_NO;
            VEND_PART_CODE = pucMaterialVendCostInfoListPopupEntity.VEND_PART_CODE;

            ERR_NO = pucMaterialVendCostInfoListPopupEntity.ERR_NO;
            ERR_MSG = pucMaterialVendCostInfoListPopupEntity.ERR_MSG;
            RTN_KEY = pucMaterialVendCostInfoListPopupEntity.RTN_KEY;
            RTN_SEQ = pucMaterialVendCostInfoListPopupEntity.RTN_SEQ;
            RTN_AQ = pucMaterialVendCostInfoListPopupEntity.RTN_AQ;
            RTN_SQ = pucMaterialVendCostInfoListPopupEntity.RTN_SQ;
            RTN_OTHERS = pucMaterialVendCostInfoListPopupEntity.RTN_OTHERS;
            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class MaterialInOutStatusEntity
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
        public String INOUT_CODE { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - MaterialInOutStatusEntity()

        public MaterialInOutStatusEntity()
        {
        }

        #endregion

        #region 생성자 - MaterialInOutStatusEntity(pMaterialInOutStatusEntity)

        public MaterialInOutStatusEntity(MaterialInOutStatusEntity pMaterialInOutStatusEntity)
        {
            CORP_CODE = pMaterialInOutStatusEntity.CORP_CODE;
            CRUD = pMaterialInOutStatusEntity.CRUD;
            USER_CODE = pMaterialInOutStatusEntity.USER_CODE;

            LANGUAGE_TYPE = pMaterialInOutStatusEntity.LANGUAGE_TYPE;



            pMaterialInOutStatusEntity.DATE_FROM = DATE_FROM;
            pMaterialInOutStatusEntity.DATE_TO = DATE_TO;
            pMaterialInOutStatusEntity.PART_NAME = PART_NAME;
            pMaterialInOutStatusEntity.VEND_NAME = VEND_NAME;
            pMaterialInOutStatusEntity.ORDER_ID = ORDER_ID;
            pMaterialInOutStatusEntity.INOUT_CODE = INOUT_CODE;

            ERR_NO = pMaterialInOutStatusEntity.ERR_NO;
            ERR_MSG = pMaterialInOutStatusEntity.ERR_MSG;
            RTN_KEY = pMaterialInOutStatusEntity.RTN_KEY;
            RTN_SEQ = pMaterialInOutStatusEntity.RTN_SEQ;
            RTN_OTHERS = pMaterialInOutStatusEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class MaterialInOutStatus_T01Entity
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

        public String VEND_CODE { get; set; }
        public String VEND_NAME { get; set; }

        public String INOUT_TYPE { get; set; }
        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값        

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - MaterialInOutStatus_T01Entity()

        public MaterialInOutStatus_T01Entity()
        {
        }

        #endregion

        #region 생성자 - MaterialInOutStatus_T01Entity(pMaterialInOutStatus_T01Entity)

        public MaterialInOutStatus_T01Entity(MaterialInOutStatus_T01Entity pMaterialInOutStatus_T01Entity)
        {
            CORP_CODE = pMaterialInOutStatus_T01Entity.CORP_CODE;
            CRUD = pMaterialInOutStatus_T01Entity.CRUD;
            USER_CODE = pMaterialInOutStatus_T01Entity.USER_CODE;

            LANGUAGE_TYPE = pMaterialInOutStatus_T01Entity.LANGUAGE_TYPE;


            pMaterialInOutStatus_T01Entity.PART_TYPE = PART_TYPE;
            pMaterialInOutStatus_T01Entity.PART_NAME = PART_NAME;
            pMaterialInOutStatus_T01Entity.PART_CODE = PART_CODE;
            pMaterialInOutStatus_T01Entity.VEND_PART_CODE = VEND_PART_CODE;

            pMaterialInOutStatus_T01Entity.VEND_CODE = VEND_CODE;
            pMaterialInOutStatus_T01Entity.VEND_NAME = VEND_NAME;
            pMaterialInOutStatus_T01Entity.INOUT_TYPE = INOUT_TYPE;
            pMaterialInOutStatus_T01Entity.DATE_FROM = DATE_FROM;
            pMaterialInOutStatus_T01Entity.DATE_TO = DATE_TO;            

            ERR_NO = pMaterialInOutStatus_T01Entity.ERR_NO;
            ERR_MSG = pMaterialInOutStatus_T01Entity.ERR_MSG;
            RTN_KEY = pMaterialInOutStatus_T01Entity.RTN_KEY;
            RTN_SEQ = pMaterialInOutStatus_T01Entity.RTN_SEQ;
            RTN_OTHERS = pMaterialInOutStatus_T01Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class MaterialInOutStatus_T02Entity
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

        public String VEND_CODE { get; set; }
        public String VEND_NAME { get; set; }

        public String INOUT_TYPE { get; set; }
        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값        

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - MaterialInOutStatus_T01Entity()

        public MaterialInOutStatus_T02Entity()
        {
        }

        #endregion

        #region 생성자 - MaterialInOutStatus_T01Entity(pMaterialInOutStatus_T01Entity)

        public MaterialInOutStatus_T02Entity(MaterialInOutStatus_T02Entity pMaterialInOutStatus_T02Entity)
        {
            CORP_CODE = pMaterialInOutStatus_T02Entity.CORP_CODE;
            CRUD = pMaterialInOutStatus_T02Entity.CRUD;
            USER_CODE = pMaterialInOutStatus_T02Entity.USER_CODE;

            LANGUAGE_TYPE = pMaterialInOutStatus_T02Entity.LANGUAGE_TYPE;


            pMaterialInOutStatus_T02Entity.PART_TYPE = PART_TYPE;
            pMaterialInOutStatus_T02Entity.PART_NAME = PART_NAME;
            pMaterialInOutStatus_T02Entity.PART_CODE = PART_CODE;
            pMaterialInOutStatus_T02Entity.VEND_PART_CODE = VEND_PART_CODE;

            pMaterialInOutStatus_T02Entity.VEND_CODE = VEND_CODE;
            pMaterialInOutStatus_T02Entity.VEND_NAME = VEND_NAME;
            pMaterialInOutStatus_T02Entity.INOUT_TYPE = INOUT_TYPE;
            pMaterialInOutStatus_T02Entity.DATE_FROM = DATE_FROM;
            pMaterialInOutStatus_T02Entity.DATE_TO = DATE_TO;

            ERR_NO = pMaterialInOutStatus_T02Entity.ERR_NO;
            ERR_MSG = pMaterialInOutStatus_T02Entity.ERR_MSG;
            RTN_KEY = pMaterialInOutStatus_T02Entity.RTN_KEY;
            RTN_SEQ = pMaterialInOutStatus_T02Entity.RTN_SEQ;
            RTN_OTHERS = pMaterialInOutStatus_T02Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class MaterialCollectAndPayEntity
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
        public String VEND_PART_CODE { get; set; }
        public String PART_TYPE { get; set; }
        public String PART_CODE { get; set; }
        public String VEND_CODE { get; set; }
        public String VEND_NAME { get; set; }
        public String ORDER_ID { get; set; }
        public String INOUT_CODE { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - MaterialCollectAndPayEntity()

        public MaterialCollectAndPayEntity()
        {
        }

        #endregion

        #region 생성자 - MaterialCollectAndPayEntity(pMaterialCollectAndPayEntity)

        public MaterialCollectAndPayEntity(MaterialCollectAndPayEntity pMaterialCollectAndPayEntity)
        {
            CORP_CODE = pMaterialCollectAndPayEntity.CORP_CODE;
            CRUD = pMaterialCollectAndPayEntity.CRUD;
            USER_CODE = pMaterialCollectAndPayEntity.USER_CODE;

            LANGUAGE_TYPE = pMaterialCollectAndPayEntity.LANGUAGE_TYPE;



            pMaterialCollectAndPayEntity.DATE_FROM = DATE_FROM;
            pMaterialCollectAndPayEntity.DATE_TO = DATE_TO;
            pMaterialCollectAndPayEntity.PART_NAME = PART_NAME;
            pMaterialCollectAndPayEntity.PART_CODE = PART_CODE;
            pMaterialCollectAndPayEntity.VEND_NAME = VEND_NAME;
            pMaterialCollectAndPayEntity.ORDER_ID = ORDER_ID;
            pMaterialCollectAndPayEntity.INOUT_CODE = INOUT_CODE;
            pMaterialCollectAndPayEntity.VEND_PART_CODE = VEND_PART_CODE;
            pMaterialCollectAndPayEntity.PART_TYPE = PART_TYPE;

            ERR_NO = pMaterialCollectAndPayEntity.ERR_NO;
            ERR_MSG = pMaterialCollectAndPayEntity.ERR_MSG;
            RTN_KEY = pMaterialCollectAndPayEntity.RTN_KEY;
            RTN_SEQ = pMaterialCollectAndPayEntity.RTN_SEQ;
            RTN_OTHERS = pMaterialCollectAndPayEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class MaterialCollectAndPay_DetailEntity
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
        public String VEND_PART_CODE { get; set; }
        public String PART_TYPE { get; set; }
        public String PART_CODE { get; set; }
        public String VEND_CODE { get; set; }
        public String VEND_NAME { get; set; }
        public String ORDER_ID { get; set; }
        public String INOUT_CODE { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - MaterialCollectAndPay_DetailEntity()

        public MaterialCollectAndPay_DetailEntity()
        {
        }

        #endregion

        #region 생성자 - MaterialCollectAndPay_DetailEntity(pMaterialCollectAndPay_DetailEntity)

        public MaterialCollectAndPay_DetailEntity(MaterialCollectAndPay_DetailEntity pMaterialCollectAndPay_DetailEntity)
        {
            CORP_CODE = pMaterialCollectAndPay_DetailEntity.CORP_CODE;
            CRUD = pMaterialCollectAndPay_DetailEntity.CRUD;
            USER_CODE = pMaterialCollectAndPay_DetailEntity.USER_CODE;

            LANGUAGE_TYPE = pMaterialCollectAndPay_DetailEntity.LANGUAGE_TYPE;



            pMaterialCollectAndPay_DetailEntity.DATE_FROM = DATE_FROM;
            pMaterialCollectAndPay_DetailEntity.DATE_TO = DATE_TO;
            pMaterialCollectAndPay_DetailEntity.PART_NAME = PART_NAME;
            pMaterialCollectAndPay_DetailEntity.PART_CODE = PART_CODE;
            pMaterialCollectAndPay_DetailEntity.VEND_NAME = VEND_NAME;
            pMaterialCollectAndPay_DetailEntity.ORDER_ID = ORDER_ID;
            pMaterialCollectAndPay_DetailEntity.INOUT_CODE = INOUT_CODE;
            pMaterialCollectAndPay_DetailEntity.VEND_PART_CODE = VEND_PART_CODE;
            pMaterialCollectAndPay_DetailEntity.PART_TYPE = PART_TYPE;

            ERR_NO = pMaterialCollectAndPay_DetailEntity.ERR_NO;
            ERR_MSG = pMaterialCollectAndPay_DetailEntity.ERR_MSG;
            RTN_KEY = pMaterialCollectAndPay_DetailEntity.RTN_KEY;
            RTN_SEQ = pMaterialCollectAndPay_DetailEntity.RTN_SEQ;
            RTN_OTHERS = pMaterialCollectAndPay_DetailEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }
    public class ucMaterialStockInfoPopupEntity
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

        #region 생성자 - ucMaterialStockInfoPopupEntity()

        public ucMaterialStockInfoPopupEntity()
        {
        }

        #endregion

        #region 생성자 - ucMaterialStockInfoPopupEntity(pucMaterialStockInfoPopupEntity)

        public ucMaterialStockInfoPopupEntity(ucMaterialStockInfoPopupEntity pucMaterialStockInfoPopupEntity)
        {
            CORP_CODE = pucMaterialStockInfoPopupEntity.CORP_CODE;
            CRUD = pucMaterialStockInfoPopupEntity.CRUD;
            USER_CODE = pucMaterialStockInfoPopupEntity.USER_CODE;

            LANGUAGE_TYPE = pucMaterialStockInfoPopupEntity.LANGUAGE_TYPE;


            pucMaterialStockInfoPopupEntity.WINDOW_NAME = WINDOW_NAME;

            pucMaterialStockInfoPopupEntity.DATE_FROM = DATE_FROM;
            pucMaterialStockInfoPopupEntity.DATE_TO = DATE_TO;
            pucMaterialStockInfoPopupEntity.PROCESS_CODE = PROCESS_CODE;
            pucMaterialStockInfoPopupEntity.INOUT_CODE = INOUT_CODE;

            ERR_NO = pucMaterialStockInfoPopupEntity.ERR_NO;
            ERR_MSG = pucMaterialStockInfoPopupEntity.ERR_MSG;
            RTN_KEY = pucMaterialStockInfoPopupEntity.RTN_KEY;
            RTN_SEQ = pucMaterialStockInfoPopupEntity.RTN_SEQ;
            RTN_OTHERS = pucMaterialStockInfoPopupEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ucMaterialStockInfoPopup_T01Entity
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
        public String INOUT_CODE { get; set; } // 리턴 기타 값


        //고정 엔티티


        //메뉴별 추가 엔티티 입력
        public String WINDOW_NAME { get; set; }
        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        public String PROCESS_CODE { get; set; }
        public String PART_NAME { get; set; } //

        public String VEND_ANME { get; set; } //

        #endregion

        #region 생성자 - ucMaterialStockInfoPopup_T01Entity()

        public ucMaterialStockInfoPopup_T01Entity()
        {
        }

        #endregion

        #region 생성자 - ucMaterialStockInfoPopup_T01Entity(ucMaterialStockInfoPopup_T01Entity pucMaterialStockInfoPopup_T01Entity)

        public ucMaterialStockInfoPopup_T01Entity(ucMaterialStockInfoPopup_T01Entity pucMaterialStockInfoPopup_T01Entity)
        {
            CORP_CODE = pucMaterialStockInfoPopup_T01Entity.CORP_CODE;
            CRUD = pucMaterialStockInfoPopup_T01Entity.CRUD;
            USER_CODE = pucMaterialStockInfoPopup_T01Entity.USER_CODE;

            LANGUAGE_TYPE = pucMaterialStockInfoPopup_T01Entity.LANGUAGE_TYPE;


            pucMaterialStockInfoPopup_T01Entity.WINDOW_NAME = WINDOW_NAME;

            pucMaterialStockInfoPopup_T01Entity.DATE_FROM = DATE_FROM;
            pucMaterialStockInfoPopup_T01Entity.DATE_TO = DATE_TO;
            pucMaterialStockInfoPopup_T01Entity.PROCESS_CODE = PROCESS_CODE;
            pucMaterialStockInfoPopup_T01Entity.INOUT_CODE = INOUT_CODE;
            ERR_NO = pucMaterialStockInfoPopup_T01Entity.ERR_NO;
            ERR_MSG = pucMaterialStockInfoPopup_T01Entity.ERR_MSG;
            RTN_KEY = pucMaterialStockInfoPopup_T01Entity.RTN_KEY;
            RTN_SEQ = pucMaterialStockInfoPopup_T01Entity.RTN_SEQ;
            RTN_OTHERS = pucMaterialStockInfoPopup_T01Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ucMaterialContractInfoPopupEntity
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

        #region 생성자 - ucMaterialContractInfoPopupEntity()

        public ucMaterialContractInfoPopupEntity()
        {
        }

        #endregion

        #region 생성자 - ucMaterialContractInfoPopupEntity(ucMaterialContractInfoPopupEntity pucMaterialContractInfoPopupEntity)

        public ucMaterialContractInfoPopupEntity(ucMaterialContractInfoPopupEntity pucMaterialContractInfoPopupEntity)
        {
            CORP_CODE = pucMaterialContractInfoPopupEntity.CORP_CODE;
            CRUD = pucMaterialContractInfoPopupEntity.CRUD;
            USER_CODE = pucMaterialContractInfoPopupEntity.USER_CODE;
            LANGUAGE_TYPE = pucMaterialContractInfoPopupEntity.LANGUAGE_TYPE;
            WINDOW_NAME = pucMaterialContractInfoPopupEntity.WINDOW_NAME;

            CONTRACT_ID = pucMaterialContractInfoPopupEntity.CONTRACT_ID;
            CONTRACT_DATE_FROM = pucMaterialContractInfoPopupEntity.CONTRACT_DATE_FROM;
            CONTRACT_DATE_TO = pucMaterialContractInfoPopupEntity.CONTRACT_DATE_TO;
            CONTRACT_NUMBER = pucMaterialContractInfoPopupEntity.CONTRACT_NUMBER;

            ERR_NO = pucMaterialContractInfoPopupEntity.ERR_NO;
            ERR_MSG = pucMaterialContractInfoPopupEntity.ERR_MSG;
            RTN_KEY = pucMaterialContractInfoPopupEntity.RTN_KEY;
            RTN_SEQ = pucMaterialContractInfoPopupEntity.RTN_SEQ;
            RTN_AQ = pucMaterialContractInfoPopupEntity.RTN_AQ;
            RTN_SQ = pucMaterialContractInfoPopupEntity.RTN_SQ;
            RTN_OTHERS = pucMaterialContractInfoPopupEntity.RTN_OTHERS;
            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class ucMaterialPartDocumentListPopupEntity
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
        public String VEND_PART_CODE { get; set; }
        public String PART_REVISION_NO { get; set; }


        public String CONTRACT_ID { get; set; }
        public String CONTRACT_NUMBER { get; set; }
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

        #region 생성자 - ucMaterialPartDocumentListPopupEntity()

        public ucMaterialPartDocumentListPopupEntity()
        {
        }

        #endregion

        #region 생성자 - ucMaterialPartDocumentListPopupEntity(ucMaterialPartDocumentListPopupEntity pucMaterialPartDocumentListPopupEntity)

        public ucMaterialPartDocumentListPopupEntity(ucMaterialPartDocumentListPopupEntity pucMaterialPartDocumentListPopupEntity)
        {
            CORP_CODE = pucMaterialPartDocumentListPopupEntity.CORP_CODE;
            CRUD = pucMaterialPartDocumentListPopupEntity.CRUD;
            USER_CODE = pucMaterialPartDocumentListPopupEntity.USER_CODE;
            LANGUAGE_TYPE = pucMaterialPartDocumentListPopupEntity.LANGUAGE_TYPE;
            WINDOW_NAME = pucMaterialPartDocumentListPopupEntity.WINDOW_NAME;

            PART_CODE = pucMaterialPartDocumentListPopupEntity.PART_CODE;
            PART_NAME = pucMaterialPartDocumentListPopupEntity.PART_NAME;
            PART_REVISION_NO = pucMaterialPartDocumentListPopupEntity.PART_REVISION_NO;
            VEND_PART_CODE = pucMaterialPartDocumentListPopupEntity.VEND_PART_CODE;

            CONTRACT_ID = pucMaterialPartDocumentListPopupEntity.CONTRACT_ID;
            CONTRACT_NUMBER = pucMaterialPartDocumentListPopupEntity.CONTRACT_NUMBER;
            DOCUMENT_TYPE = pucMaterialPartDocumentListPopupEntity.DOCUMENT_TYPE;
            DOCUMENT_NAME = pucMaterialPartDocumentListPopupEntity.DOCUMENT_NAME;
            DOCUMENT_VER = pucMaterialPartDocumentListPopupEntity.DOCUMENT_VER;

            USE_YN = pucMaterialPartDocumentListPopupEntity.USE_YN;

            ERR_NO = pucMaterialPartDocumentListPopupEntity.ERR_NO;
            ERR_MSG = pucMaterialPartDocumentListPopupEntity.ERR_MSG;
            RTN_KEY = pucMaterialPartDocumentListPopupEntity.RTN_KEY;
            RTN_SEQ = pucMaterialPartDocumentListPopupEntity.RTN_SEQ;
            RTN_AQ = pucMaterialPartDocumentListPopupEntity.RTN_AQ;
            RTN_SQ = pucMaterialPartDocumentListPopupEntity.RTN_SQ;
            RTN_OTHERS = pucMaterialPartDocumentListPopupEntity.RTN_OTHERS;
            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class WasherTruckRegisterEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE

        //마스터
        public String TRUCK_CODE { get; set; }
        public String TRUCK_NAME { get; set; }
        public String WASHER_STANDARD_CODE { get; set; }
        public String WASHER_STANDARD_NAME { get; set; }
        public String TAG_CODE { get; set; }
        public String TAG_NAME { get; set; }
        public String BOX_QTY { get; set; }
        public String BOX_MAX { get; set; }
        public String USE_YN { get; set; }

        //고정 엔티티
        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }

        //메뉴별 추가 엔티티 입력
        
        #endregion

        #region 생성자 - WasherTruckRegisterEntity()

        public WasherTruckRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - WasherTruckRegisterEntity(pWasherTruckRegisterEntity)

        public WasherTruckRegisterEntity(WasherTruckRegisterEntity pWasherTruckRegisterEntity)
        {
            CORP_CODE = pWasherTruckRegisterEntity.CORP_CODE;
            CRUD = pWasherTruckRegisterEntity.CRUD;
            TRUCK_CODE = pWasherTruckRegisterEntity.TRUCK_CODE;
            TRUCK_NAME = pWasherTruckRegisterEntity.TRUCK_NAME;
            WASHER_STANDARD_CODE = pWasherTruckRegisterEntity.WASHER_STANDARD_CODE;
            WASHER_STANDARD_NAME = pWasherTruckRegisterEntity.WASHER_STANDARD_NAME;
            TAG_CODE = pWasherTruckRegisterEntity.TAG_CODE;
            TAG_NAME = pWasherTruckRegisterEntity.TAG_NAME;
            BOX_QTY = pWasherTruckRegisterEntity.BOX_QTY;
            BOX_MAX = pWasherTruckRegisterEntity.BOX_MAX;
            USE_YN = pWasherTruckRegisterEntity.USE_YN;

            LANGUAGE_TYPE = pWasherTruckRegisterEntity.LANGUAGE_TYPE;

            ERR_NO = pWasherTruckRegisterEntity.ERR_NO;
            ERR_MSG = pWasherTruckRegisterEntity.ERR_MSG;
            RTN_KEY = pWasherTruckRegisterEntity.RTN_KEY;
            RTN_SEQ = pWasherTruckRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pWasherTruckRegisterEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class WasherInformationRegisterEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE

        //마스터
        public String WASHER_CODE { get; set; }
        public String WASHER_NAME { get; set; }
        public String WASHER_UNIT { get; set; }
        public String WASHER_STANDARD { get; set; }
        public String VEND_PART_CODE { get; set; }
        public String WASHER_COST { get; set; }
        public String SAFE_STOCK { get; set; }
        public String USE_YN { get; set; }
        public String REMARK { get; set; }

        //고정 엔티티
        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }

        //메뉴별 추가 엔티티 입력

        #endregion

        #region 생성자 - WasherInformationRegisterEntity()

        public WasherInformationRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - WasherInformationRegisterEntity(pWasherInformationRegisterEntity)

        public WasherInformationRegisterEntity(WasherInformationRegisterEntity pWasherInformationRegisterEntity)
        {
            CORP_CODE = pWasherInformationRegisterEntity.CORP_CODE;
            CRUD = pWasherInformationRegisterEntity.CRUD;
            WASHER_CODE = pWasherInformationRegisterEntity.WASHER_CODE;
            WASHER_NAME = pWasherInformationRegisterEntity.WASHER_NAME;
            WASHER_UNIT = pWasherInformationRegisterEntity.WASHER_UNIT;
            WASHER_STANDARD = pWasherInformationRegisterEntity.WASHER_STANDARD;
            VEND_PART_CODE = pWasherInformationRegisterEntity.VEND_PART_CODE;
            WASHER_COST = pWasherInformationRegisterEntity.WASHER_COST;
            SAFE_STOCK = pWasherInformationRegisterEntity.SAFE_STOCK;
            USE_YN = pWasherInformationRegisterEntity.USE_YN;

            LANGUAGE_TYPE = pWasherInformationRegisterEntity.LANGUAGE_TYPE;

            ERR_NO = pWasherInformationRegisterEntity.ERR_NO;
            ERR_MSG = pWasherInformationRegisterEntity.ERR_MSG;
            RTN_KEY = pWasherInformationRegisterEntity.RTN_KEY;
            RTN_SEQ = pWasherInformationRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pWasherInformationRegisterEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class WasherInRegisterEntity
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
        public String WASHER_CODE { get; set; }
        public String WASHER_NAME { get; set; }
        public String INOUT_ID { get; set; }
        public String PART_UNIT { get; set; }
        public String INOUT_DATE { get; set; }
        public String INOUT_SEQ { get; set; }
        public String INOUT_TYPE { get; set; }
        public String INOUT_CODE { get; set; }
        public String REFERENCE_ID { get; set; }
        public String INOUT_QTY { get; set; }
        public String UNITCOST { get; set; }
        public String COST { get; set; }
        public String REMARK { get; set; }
        public String USE_YN { get; set; }


        #endregion

        #region 생성자 - WasherInRegisterEntity()

        public WasherInRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - WasherInRegisterEntity(WasherInRegisterEntity pWasherInRegisterEntity)

        public WasherInRegisterEntity(WasherInRegisterEntity pWasherInRegisterEntity)
        {
            CORP_CODE = pWasherInRegisterEntity.CORP_CODE;
            CRUD = pWasherInRegisterEntity.CRUD;
            USER_CODE = pWasherInRegisterEntity.USER_CODE;
            LANGUAGE_TYPE = pWasherInRegisterEntity.LANGUAGE_TYPE;

            ERR_NO = pWasherInRegisterEntity.ERR_NO;
            ERR_MSG = pWasherInRegisterEntity.ERR_MSG;
            RTN_KEY = pWasherInRegisterEntity.RTN_KEY;
            RTN_SEQ = pWasherInRegisterEntity.RTN_SEQ;
            RTN_AQ = pWasherInRegisterEntity.RTN_AQ;
            RTN_SQ = pWasherInRegisterEntity.RTN_SQ;
            RTN_OTHERS = pWasherInRegisterEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            pWasherInRegisterEntity.WINDOW_NAME = WINDOW_NAME;

            pWasherInRegisterEntity.DATE_FROM = DATE_FROM;
            pWasherInRegisterEntity.DATE_TO = DATE_TO;
            pWasherInRegisterEntity.WASHER_NAME = WASHER_NAME;
            pWasherInRegisterEntity.WASHER_CODE = WASHER_CODE;
            pWasherInRegisterEntity.INOUT_ID = INOUT_ID;
            pWasherInRegisterEntity.PART_UNIT = PART_UNIT;
            pWasherInRegisterEntity.INOUT_DATE = INOUT_DATE;
            pWasherInRegisterEntity.INOUT_SEQ = INOUT_SEQ;
            pWasherInRegisterEntity.INOUT_TYPE = INOUT_TYPE;
            pWasherInRegisterEntity.INOUT_CODE = INOUT_CODE;
            pWasherInRegisterEntity.REFERENCE_ID = REFERENCE_ID;
            pWasherInRegisterEntity.INOUT_QTY = INOUT_QTY;
            pWasherInRegisterEntity.UNITCOST = UNITCOST;
            pWasherInRegisterEntity.COST = COST;
            pWasherInRegisterEntity.REMARK = REMARK;
            pWasherInRegisterEntity.USE_YN = USE_YN;

        }

        #endregion

    }

    public class WasherOutRegisterEntity
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
        public String WASHER_CODE { get; set; }
        public String WASHER_NAME { get; set; }
        public String INOUT_ID { get; set; }
        public String PART_UNIT { get; set; }
        public String INOUT_DATE { get; set; }
        public String INOUT_SEQ { get; set; }
        public String INOUT_TYPE { get; set; }
        public String INOUT_CODE { get; set; }
        public String REFERENCE_ID { get; set; }
        public String INOUT_QTY { get; set; }
        public String UNITCOST { get; set; }
        public String COST { get; set; }
        public String REMARK { get; set; }
        public String USE_YN { get; set; }


        #endregion

        #region 생성자 - WasherOutRegisterEntity()

        public WasherOutRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - WasherOutRegisterEntity(WasherOutRegisterEntity pWasherOutRegisterEntity)

        public WasherOutRegisterEntity(WasherOutRegisterEntity pWasherOutRegisterEntity)
        {
            CORP_CODE = pWasherOutRegisterEntity.CORP_CODE;
            CRUD = pWasherOutRegisterEntity.CRUD;
            USER_CODE = pWasherOutRegisterEntity.USER_CODE;
            LANGUAGE_TYPE = pWasherOutRegisterEntity.LANGUAGE_TYPE;

            ERR_NO = pWasherOutRegisterEntity.ERR_NO;
            ERR_MSG = pWasherOutRegisterEntity.ERR_MSG;
            RTN_KEY = pWasherOutRegisterEntity.RTN_KEY;
            RTN_SEQ = pWasherOutRegisterEntity.RTN_SEQ;
            RTN_AQ = pWasherOutRegisterEntity.RTN_AQ;
            RTN_SQ = pWasherOutRegisterEntity.RTN_SQ;
            RTN_OTHERS = pWasherOutRegisterEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            pWasherOutRegisterEntity.WINDOW_NAME = WINDOW_NAME;

            pWasherOutRegisterEntity.DATE_FROM = DATE_FROM;
            pWasherOutRegisterEntity.DATE_TO = DATE_TO;
            pWasherOutRegisterEntity.WASHER_NAME = WASHER_NAME;
            pWasherOutRegisterEntity.WASHER_CODE = WASHER_CODE;
            pWasherOutRegisterEntity.INOUT_ID = INOUT_ID;
            pWasherOutRegisterEntity.PART_UNIT = PART_UNIT;
            pWasherOutRegisterEntity.INOUT_DATE = INOUT_DATE;
            pWasherOutRegisterEntity.INOUT_SEQ = INOUT_SEQ;
            pWasherOutRegisterEntity.INOUT_TYPE = INOUT_TYPE;
            pWasherOutRegisterEntity.INOUT_CODE = INOUT_CODE;
            pWasherOutRegisterEntity.REFERENCE_ID = REFERENCE_ID;
            pWasherOutRegisterEntity.INOUT_QTY = INOUT_QTY;
            pWasherOutRegisterEntity.UNITCOST = UNITCOST;
            pWasherOutRegisterEntity.COST = COST;
            pWasherOutRegisterEntity.REMARK = REMARK;
            pWasherOutRegisterEntity.USE_YN = USE_YN;

        }

        #endregion

    }

    public class WasherStockStatusEntity
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

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - WasherStockStatusEntity()

        public WasherStockStatusEntity()
        {
        }

        #endregion

        #region 생성자 - WasherStockStatusEntity(pWasherStockStatusEntity)

        public WasherStockStatusEntity(WasherStockStatusEntity pWasherStockStatusEntity)
        {
            CORP_CODE = pWasherStockStatusEntity.CORP_CODE;
            CRUD = pWasherStockStatusEntity.CRUD;
            USER_CODE = pWasherStockStatusEntity.USER_CODE;

            LANGUAGE_TYPE = pWasherStockStatusEntity.LANGUAGE_TYPE;


            pWasherStockStatusEntity.PART_TYPE = PART_TYPE;
            pWasherStockStatusEntity.PART_NAME = PART_NAME;
            pWasherStockStatusEntity.PART_CODE = PART_CODE;

            ERR_NO = pWasherStockStatusEntity.ERR_NO;
            ERR_MSG = pWasherStockStatusEntity.ERR_MSG;
            RTN_KEY = pWasherStockStatusEntity.RTN_KEY;
            RTN_SEQ = pWasherStockStatusEntity.RTN_SEQ;
            RTN_OTHERS = pWasherStockStatusEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ucMaterialPartListPopupEntity
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

        #region 생성자 - ucMaterialPartListPopupEntity()

        public ucMaterialPartListPopupEntity()
        {
        }

        #endregion

        #region 생성자 - ucMaterialPartListPopupEntity(ucMaterialPartListPopupEntity pucMaterialPartListPopupEntity)

        public ucMaterialPartListPopupEntity(ucMaterialPartListPopupEntity pucMaterialPartListPopupEntity)
        {
            CORP_CODE = pucMaterialPartListPopupEntity.CORP_CODE;
            CRUD = pucMaterialPartListPopupEntity.CRUD;
            USER_CODE = pucMaterialPartListPopupEntity.USER_CODE;
            LANGUAGE_TYPE = pucMaterialPartListPopupEntity.LANGUAGE_TYPE;
            WINDOW_NAME = pucMaterialPartListPopupEntity.WINDOW_NAME;

            PART_CODE = pucMaterialPartListPopupEntity.PART_CODE;
            PART_NAME = pucMaterialPartListPopupEntity.PART_NAME;
            PART_REVISION_NO = pucMaterialPartListPopupEntity.PART_REVISION_NO;
            VEND_PART_CODE = pucMaterialPartListPopupEntity.VEND_PART_CODE;

            PART_HIGH = pucMaterialPartListPopupEntity.PART_HIGH;
            PART_MIDDLE = pucMaterialPartListPopupEntity.PART_MIDDLE;
            PART_LOW = pucMaterialPartListPopupEntity.PART_LOW;

            ERR_NO = pucMaterialPartListPopupEntity.ERR_NO;
            ERR_MSG = pucMaterialPartListPopupEntity.ERR_MSG;
            RTN_KEY = pucMaterialPartListPopupEntity.RTN_KEY;
            RTN_SEQ = pucMaterialPartListPopupEntity.RTN_SEQ;
            RTN_AQ = pucMaterialPartListPopupEntity.RTN_AQ;
            RTN_SQ = pucMaterialPartListPopupEntity.RTN_SQ;
            RTN_OTHERS = pucMaterialPartListPopupEntity.RTN_OTHERS;
            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class ucMaterialPartListPopup_T01Entity
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

        #region 생성자 - ucMaterialPartListPopup_T01Entity()

        public ucMaterialPartListPopup_T01Entity()
        {
        }

        #endregion

        #region 생성자 - ucMaterialPartListPopup_T01Entity(ucMaterialPartListPopup_T01Entity pucMaterialPartListPopup_T01Entity)

        public ucMaterialPartListPopup_T01Entity(ucMaterialPartListPopup_T01Entity pucMaterialPartListPopup_T01Entity)
        {
            CORP_CODE = pucMaterialPartListPopup_T01Entity.CORP_CODE;
            CRUD = pucMaterialPartListPopup_T01Entity.CRUD;
            USER_CODE = pucMaterialPartListPopup_T01Entity.USER_CODE;
            LANGUAGE_TYPE = pucMaterialPartListPopup_T01Entity.LANGUAGE_TYPE;
            WINDOW_NAME = pucMaterialPartListPopup_T01Entity.WINDOW_NAME;

            PART_CODE = pucMaterialPartListPopup_T01Entity.PART_CODE;
            PART_NAME = pucMaterialPartListPopup_T01Entity.PART_NAME;
            PART_REVISION_NO = pucMaterialPartListPopup_T01Entity.PART_REVISION_NO;
            VEND_PART_CODE = pucMaterialPartListPopup_T01Entity.VEND_PART_CODE;

            PART_HIGH = pucMaterialPartListPopup_T01Entity.PART_HIGH;
            PART_MIDDLE = pucMaterialPartListPopup_T01Entity.PART_MIDDLE;
            PART_LOW = pucMaterialPartListPopup_T01Entity.PART_LOW;

            ERR_NO = pucMaterialPartListPopup_T01Entity.ERR_NO;
            ERR_MSG = pucMaterialPartListPopup_T01Entity.ERR_MSG;
            RTN_KEY = pucMaterialPartListPopup_T01Entity.RTN_KEY;
            RTN_SEQ = pucMaterialPartListPopup_T01Entity.RTN_SEQ;
            RTN_AQ = pucMaterialPartListPopup_T01Entity.RTN_AQ;
            RTN_SQ = pucMaterialPartListPopup_T01Entity.RTN_SQ;
            RTN_OTHERS = pucMaterialPartListPopup_T01Entity.RTN_OTHERS;
            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class ucPartDocumentListPopupEntity
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
        public String VEND_PART_CODE { get; set; }
        public String PART_REVISION_NO { get; set; }


        public String CONTRACT_ID { get; set; }
        public String CONTRACT_NUMBER { get; set; }
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

        #region 생성자 - ucPartDocumentListPopupEntity()

        public ucPartDocumentListPopupEntity()
        {
        }

        #endregion

        #region 생성자 - ucPartDocumentListPopupEntity(ucPartDocumentListPopupEntity pucPartDocumentListPopupEntity)

        public ucPartDocumentListPopupEntity(ucPartDocumentListPopupEntity pucPartDocumentListPopupEntity)
        {
            CORP_CODE = pucPartDocumentListPopupEntity.CORP_CODE;
            CRUD = pucPartDocumentListPopupEntity.CRUD;
            USER_CODE = pucPartDocumentListPopupEntity.USER_CODE;
            LANGUAGE_TYPE = pucPartDocumentListPopupEntity.LANGUAGE_TYPE;
            WINDOW_NAME = pucPartDocumentListPopupEntity.WINDOW_NAME;

            PART_CODE = pucPartDocumentListPopupEntity.PART_CODE;
            PART_NAME = pucPartDocumentListPopupEntity.PART_NAME;
            PART_REVISION_NO = pucPartDocumentListPopupEntity.PART_REVISION_NO;
            VEND_PART_CODE = pucPartDocumentListPopupEntity.VEND_PART_CODE;

            CONTRACT_ID = pucPartDocumentListPopupEntity.CONTRACT_ID;
            CONTRACT_NUMBER = pucPartDocumentListPopupEntity.CONTRACT_NUMBER;
            DOCUMENT_TYPE = pucPartDocumentListPopupEntity.DOCUMENT_TYPE;
            DOCUMENT_NAME = pucPartDocumentListPopupEntity.DOCUMENT_NAME;
            DOCUMENT_VER = pucPartDocumentListPopupEntity.DOCUMENT_VER;

            USE_YN = pucPartDocumentListPopupEntity.USE_YN;

            ERR_NO = pucPartDocumentListPopupEntity.ERR_NO;
            ERR_MSG = pucPartDocumentListPopupEntity.ERR_MSG;
            RTN_KEY = pucPartDocumentListPopupEntity.RTN_KEY;
            RTN_SEQ = pucPartDocumentListPopupEntity.RTN_SEQ;
            RTN_AQ = pucPartDocumentListPopupEntity.RTN_AQ;
            RTN_SQ = pucPartDocumentListPopupEntity.RTN_SQ;
            RTN_OTHERS = pucPartDocumentListPopupEntity.RTN_OTHERS;
            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }


    public class ucPartDocumentListPopup_T02Entity
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
        public String VEND_PART_CODE { get; set; }
        public String PART_REVISION_NO { get; set; }
        public String PART_TYPE { get; set; }

        public String CONTRACT_ID { get; set; }
        public String CONTRACT_NUMBER { get; set; }

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


        public String FTP_IP_PORT { get; set; }
        public String FTP_PATH { get; set; }
        public String FTP_ID { get; set; }
        public String FTP_PW { get; set; }
        public String DOCUMENT_ID { get; set; }
        public String DOCUMENT_TYPE_NAME { get; set; }
        public String DOCUMENT_SEQ { get; set; }
        public String DOCUMENT_FILE_NAME_FULL { get; set; }
        public String DOCUMENT_FILE_NAME { get; set; }
        public String DOCUMENT_BEFROE_FILE_NAME { get; set; }
        public String REFERENCE_CODE { get; set; }
        public String REMARK { get; set; } // 비고

        public String SEQ { get; set; } // 비고
        public String FILE_NAME_1 { get; set; } // 비고
        public String FILE_NAME_2 { get; set; } // 비고
        public String EXTENSION { get; set; } // 비고  

        public String FILE_FLAG { get; set; } // 파일플래그        

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - ucPartDocumentListPopup_T02Entity()

        public ucPartDocumentListPopup_T02Entity()
        {
        }

        #endregion

        #region 생성자 - ucPartDocumentListPopup_T02Entity(ucPartDocumentListPopup_T02Entity pucPartDocumentListPopup_T02Entity)

        public ucPartDocumentListPopup_T02Entity(ucPartDocumentListPopup_T02Entity pucPartDocumentListPopup_T02Entity)
        {
            CORP_CODE = pucPartDocumentListPopup_T02Entity.CORP_CODE;
            CRUD = pucPartDocumentListPopup_T02Entity.CRUD;
            USER_CODE = pucPartDocumentListPopup_T02Entity.USER_CODE;
            LANGUAGE_TYPE = pucPartDocumentListPopup_T02Entity.LANGUAGE_TYPE;
            WINDOW_NAME = pucPartDocumentListPopup_T02Entity.WINDOW_NAME;

            PART_CODE = pucPartDocumentListPopup_T02Entity.PART_CODE;
            PART_NAME = pucPartDocumentListPopup_T02Entity.PART_NAME;
            PART_REVISION_NO = pucPartDocumentListPopup_T02Entity.PART_REVISION_NO;
            VEND_PART_CODE = pucPartDocumentListPopup_T02Entity.VEND_PART_CODE;
            PART_TYPE = pucPartDocumentListPopup_T02Entity.PART_TYPE;

            CONTRACT_ID = pucPartDocumentListPopup_T02Entity.CONTRACT_ID;
            CONTRACT_NUMBER = pucPartDocumentListPopup_T02Entity.CONTRACT_NUMBER;
            DOCUMENT_TYPE = pucPartDocumentListPopup_T02Entity.DOCUMENT_TYPE;
            DOCUMENT_NAME = pucPartDocumentListPopup_T02Entity.DOCUMENT_NAME;
            DOCUMENT_VER = pucPartDocumentListPopup_T02Entity.DOCUMENT_VER;

            USE_YN = pucPartDocumentListPopup_T02Entity.USE_YN;

            ERR_NO = pucPartDocumentListPopup_T02Entity.ERR_NO;
            ERR_MSG = pucPartDocumentListPopup_T02Entity.ERR_MSG;
            RTN_KEY = pucPartDocumentListPopup_T02Entity.RTN_KEY;
            RTN_SEQ = pucPartDocumentListPopup_T02Entity.RTN_SEQ;
            RTN_AQ = pucPartDocumentListPopup_T02Entity.RTN_AQ;
            RTN_SQ = pucPartDocumentListPopup_T02Entity.RTN_SQ;
            RTN_OTHERS = pucPartDocumentListPopup_T02Entity.RTN_OTHERS;


            FTP_PATH = pucPartDocumentListPopup_T02Entity.FTP_PATH;

            FTP_IP_PORT = pucPartDocumentListPopup_T02Entity.FTP_IP_PORT;
            FTP_ID = pucPartDocumentListPopup_T02Entity.FTP_ID;
            FTP_PW = pucPartDocumentListPopup_T02Entity.FTP_PW;
            DOCUMENT_ID = pucPartDocumentListPopup_T02Entity.DOCUMENT_ID;
            DOCUMENT_TYPE_NAME = pucPartDocumentListPopup_T02Entity.DOCUMENT_TYPE_NAME;
            DOCUMENT_SEQ = pucPartDocumentListPopup_T02Entity.DOCUMENT_SEQ;
            DOCUMENT_FILE_NAME_FULL = pucPartDocumentListPopup_T02Entity.DOCUMENT_FILE_NAME_FULL;
            DOCUMENT_FILE_NAME = pucPartDocumentListPopup_T02Entity.DOCUMENT_FILE_NAME;
            DOCUMENT_BEFROE_FILE_NAME = pucPartDocumentListPopup_T02Entity.DOCUMENT_BEFROE_FILE_NAME;
            REFERENCE_CODE = pucPartDocumentListPopup_T02Entity.REFERENCE_CODE;
            REMARK = pucPartDocumentListPopup_T02Entity.REMARK;

            SEQ = pucPartDocumentListPopup_T02Entity.SEQ;
            FILE_NAME_1 = pucPartDocumentListPopup_T02Entity.FILE_NAME_1;
            FILE_NAME_2 = pucPartDocumentListPopup_T02Entity.FILE_NAME_2;
            EXTENSION = pucPartDocumentListPopup_T02Entity.EXTENSION;
            FILE_FLAG = pucPartDocumentListPopup_T02Entity.FILE_FLAG;

            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class MaterialInformationRegister_T03Entity
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
        public String ALLERGY_CHECK { get; set; }
        public String VEND_PART_CODE { get; set; }
        public String PART_UNIT { get; set; }
        public String PART_STANDARD { get; set; }
        public String PART_MANUFACTURER { get; set; }
        public String PART_COST { get; set; }
        public String PART_SAFE_STOCK { get; set; }
        public String PART_START_DATE { get; set; }
        public String PART_END_DATE { get; set; }
        public String EXPIRATION_DATE { get; set; }
        public String SALE_YN { get; set; }
        public String PURC_YN { get; set; }
        public String OUTT_YN { get; set; }
        public String REMARK { get; set; }
        public String PART_PDF_NAME { get; set; }
        public String USE_YN { get; set; }
        public String PART_UNITCOST_CURRENCY_CODE { get; set; }

        public String VEND_CODE { get; set; } // 단가 조회 (상세)

        //고정 엔티티

        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }

        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - MaterialInformationRegister_T03Entity()

        public MaterialInformationRegister_T03Entity()
        {
        }

        #endregion

        #region 생성자 - MaterialInformationRegister_T03Entity(pMaterialInformationRegister_T03Entity)

        public MaterialInformationRegister_T03Entity(MaterialInformationRegister_T03Entity pMaterialInformationRegister_T03Entity)
        {
            CORP_CODE = pMaterialInformationRegister_T03Entity.CORP_CODE;
            CRUD = pMaterialInformationRegister_T03Entity.CRUD;
            PART_CODE = pMaterialInformationRegister_T03Entity.PART_CODE;
            PART_REVISION_NO = pMaterialInformationRegister_T03Entity.PART_REVISION_NO;
            PART_NAME = pMaterialInformationRegister_T03Entity.PART_NAME;
            PART_TYPE = pMaterialInformationRegister_T03Entity.PART_TYPE;
            ALLERGY_CHECK = pMaterialInformationRegister_T03Entity.ALLERGY_CHECK;
            VEND_PART_CODE = pMaterialInformationRegister_T03Entity.VEND_PART_CODE;
            PART_UNIT = pMaterialInformationRegister_T03Entity.PART_UNIT;
            PART_STANDARD = pMaterialInformationRegister_T03Entity.PART_STANDARD;
            PART_MANUFACTURER = pMaterialInformationRegister_T03Entity.PART_MANUFACTURER;
            PART_COST = pMaterialInformationRegister_T03Entity.PART_COST;
            PART_SAFE_STOCK = pMaterialInformationRegister_T03Entity.PART_SAFE_STOCK;
            PART_START_DATE = pMaterialInformationRegister_T03Entity.PART_START_DATE;
            PART_END_DATE = pMaterialInformationRegister_T03Entity.PART_END_DATE;
            EXPIRATION_DATE = pMaterialInformationRegister_T03Entity.EXPIRATION_DATE;
            SALE_YN = pMaterialInformationRegister_T03Entity.SALE_YN;
            PURC_YN = pMaterialInformationRegister_T03Entity.PURC_YN;
            OUTT_YN = pMaterialInformationRegister_T03Entity.OUTT_YN;
            USE_YN = pMaterialInformationRegister_T03Entity.USE_YN;
            REMARK = pMaterialInformationRegister_T03Entity.REMARK;
            PART_PDF_NAME = pMaterialInformationRegister_T03Entity.PART_PDF_NAME;
            LANGUAGE_TYPE = pMaterialInformationRegister_T03Entity.LANGUAGE_TYPE;
            VEND_CODE = pMaterialInformationRegister_T03Entity.VEND_CODE;
            PART_UNITCOST_CURRENCY_CODE = pMaterialInformationRegister_T03Entity.PART_UNITCOST_CURRENCY_CODE;


            ERR_NO = pMaterialInformationRegister_T03Entity.ERR_NO;
            ERR_MSG = pMaterialInformationRegister_T03Entity.ERR_MSG;
            RTN_KEY = pMaterialInformationRegister_T03Entity.RTN_KEY;
            RTN_SEQ = pMaterialInformationRegister_T03Entity.RTN_SEQ;
            RTN_OTHERS = pMaterialInformationRegister_T03Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class MaterialOrderRegister_T01Entity
    {
        #region Property
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String ORDER_ID { get; set; } // V_ORDER_ID
        public String ORDER_DATE { get; set; } // V_ORDER_DATE
        public String ORDER_SEQ { get; set; } // V_ORDER_SEQ
        public String ORDER_QTY { get; set; } // V_ORDER_QTY
        public String REQUEST_DATE { get; set; } // V_REQUEST_DATE
        public String REQUEST_LOCATION { get; set; } // V_REQUEST_LOCATION
        public String UNIT_CODE { get; set; } // V_UNIT_CODE
        public String UNITCOST { get; set; } // V_UNITCOST
        public String COST { get; set; } // V_COST
        public String CONTRACT_ID { get; set; } // V_CONTRACT_ID
        public String REMARK { get; set; } // V_REMARK
        public String USE_YN { get; set; } // V_USE_YN

        public String VEND_PART_CDOE { get; set; }

        public String LANGUAGE_TYPE { get; set; } // _pLANGUAGE_TYPE

        public String WINDOW_NAME { get; set; }
        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        public String PART_NAME { get; set; }
        public String PART_CODE { get; set; }
        public String VEND_CODE { get; set; }
        public String VEND_NAME { get; set; }
        public String REFERENCE_ID { get; set; }
        public String UNITCODT_CURRENCY_CODE { get; set; }
        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }
        #endregion

        #region 생성자 - MaterialOrderRegister_T01Entity()
        public MaterialOrderRegister_T01Entity() { }
        #endregion

        #region 생성자 - MaterialOrderRegister_T01Entity(MaterialOrderRegister_T01Entity pMaterialOrderRegister_T01Entity)
        public MaterialOrderRegister_T01Entity(MaterialOrderRegister_T01Entity pMaterialOrderRegister_T01Entity)
        {
            if (pMaterialOrderRegister_T01Entity == null)
                return;

            pMaterialOrderRegister_T01Entity.CORP_CODE = CORP_CODE;
            pMaterialOrderRegister_T01Entity.USER_CODE = USER_CODE;
            pMaterialOrderRegister_T01Entity.CRUD = CRUD;
            pMaterialOrderRegister_T01Entity.DATE_FROM = DATE_FROM;
            pMaterialOrderRegister_T01Entity.DATE_TO = DATE_TO;
            pMaterialOrderRegister_T01Entity.PART_NAME = PART_NAME;
            pMaterialOrderRegister_T01Entity.PART_CODE = PART_CODE;
            pMaterialOrderRegister_T01Entity.VEND_NAME = VEND_NAME;
            pMaterialOrderRegister_T01Entity.VEND_CODE = VEND_CODE;
            pMaterialOrderRegister_T01Entity.ORDER_ID = ORDER_ID;
            pMaterialOrderRegister_T01Entity.ORDER_DATE = ORDER_DATE;
            pMaterialOrderRegister_T01Entity.ORDER_SEQ = ORDER_SEQ;
            pMaterialOrderRegister_T01Entity.ORDER_QTY = ORDER_QTY;
            pMaterialOrderRegister_T01Entity.REQUEST_DATE = REQUEST_DATE;
            pMaterialOrderRegister_T01Entity.REQUEST_LOCATION = REQUEST_LOCATION;
            pMaterialOrderRegister_T01Entity.UNIT_CODE = UNIT_CODE;
            pMaterialOrderRegister_T01Entity.UNITCODT_CURRENCY_CODE = UNITCODT_CURRENCY_CODE;
            pMaterialOrderRegister_T01Entity.UNITCOST = UNITCOST;
            pMaterialOrderRegister_T01Entity.COST = COST;
            pMaterialOrderRegister_T01Entity.CONTRACT_ID = CONTRACT_ID;
            pMaterialOrderRegister_T01Entity.REMARK = REMARK;
            pMaterialOrderRegister_T01Entity.USE_YN = USE_YN;
            pMaterialOrderRegister_T01Entity.REFERENCE_ID = REFERENCE_ID;
            pMaterialOrderRegister_T01Entity.LANGUAGE_TYPE = LANGUAGE_TYPE;
            pMaterialOrderRegister_T01Entity.VEND_PART_CDOE = VEND_PART_CDOE;


            ERR_NO = pMaterialOrderRegister_T01Entity.ERR_NO;
            ERR_MSG = pMaterialOrderRegister_T01Entity.ERR_MSG;
            RTN_KEY = pMaterialOrderRegister_T01Entity.RTN_KEY;
            RTN_SEQ = pMaterialOrderRegister_T01Entity.RTN_SEQ;
            RTN_OTHERS = pMaterialOrderRegister_T01Entity.RTN_OTHERS;
        }
        #endregion
    }

    public class frmRiskMaterialInfoRegisterEntity
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
        public String PART_CODE { get; set; }
        public String DANGEROUS_TYPE { get; set; }      
        public String PROPERTIES { get; set; }
        public String SEVERITY_RATING { get; set; }
        public Decimal DESIGNATED_QUANTITY { get; set; }
        public String DESIGNATED_QUANTITY_UNIT { get; set; }
        public String STORAGE_MANAGEMENT_PLAN { get; set; }
        public String USE_YN { get; set; }
        public String REMARK { get; set; }
        #endregion

        #region 생성자 - frmRiskMaterialInfoRegisterEntity()

        public frmRiskMaterialInfoRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - frmRiskMaterialInfoRegisterEntity(pfrmRiskMaterialInfoRegisterEntity)

        public frmRiskMaterialInfoRegisterEntity(frmRiskMaterialInfoRegisterEntity pfrmRiskMaterialInfoRegisterEntity)
        {
            CRUD = pfrmRiskMaterialInfoRegisterEntity.CRUD;
            CORP_CODE = pfrmRiskMaterialInfoRegisterEntity.CORP_CODE;
            USER_CODE = pfrmRiskMaterialInfoRegisterEntity.USER_CODE;
            LANGUAGE_TYPE = pfrmRiskMaterialInfoRegisterEntity.LANGUAGE_TYPE;
            ERR_NO = pfrmRiskMaterialInfoRegisterEntity.ERR_NO;
            ERR_MSG = pfrmRiskMaterialInfoRegisterEntity.ERR_MSG;
            RTN_KEY = pfrmRiskMaterialInfoRegisterEntity.RTN_KEY;
            RTN_SEQ = pfrmRiskMaterialInfoRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pfrmRiskMaterialInfoRegisterEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력

            PART_CODE = pfrmRiskMaterialInfoRegisterEntity.PART_CODE;
            DANGEROUS_TYPE = pfrmRiskMaterialInfoRegisterEntity.DANGEROUS_TYPE;
            PROPERTIES = pfrmRiskMaterialInfoRegisterEntity.PROPERTIES;
            SEVERITY_RATING = pfrmRiskMaterialInfoRegisterEntity.SEVERITY_RATING;
            DESIGNATED_QUANTITY = pfrmRiskMaterialInfoRegisterEntity.DESIGNATED_QUANTITY;
            DESIGNATED_QUANTITY_UNIT = pfrmRiskMaterialInfoRegisterEntity.DESIGNATED_QUANTITY_UNIT;
            
            STORAGE_MANAGEMENT_PLAN = pfrmRiskMaterialInfoRegisterEntity.STORAGE_MANAGEMENT_PLAN;
            REMARK = pfrmRiskMaterialInfoRegisterEntity.REMARK;
            USE_YN = pfrmRiskMaterialInfoRegisterEntity.USE_YN;

        }

        #endregion
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoFAS_MES.UI.PM.Entity
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
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE


        //고정 엔티티


        //메뉴별 추가 엔티티 입력


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

            LANGUAGE_TYPE = pSampleRegisterEntity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ProductInRegisterEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE



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
        public String PART_UNIT { get; set; }
        public String UNITCOST { get; set; }
        public String COST { get; set; }
        public String REMARK { get; set; }

        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        // -----------
        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 키값
        public String RTN_AQ { get; set; } // 리턴 순번 값
        public String RTN_SQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String INOUT_CODE { get; set; }
        public String USE_YN { get; set; }

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - ProductInRegisterEntity()

        public ProductInRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - ProductInRegisterEntity(ProductInRegisterEntity pProductInRegisterEntity)

        public ProductInRegisterEntity(ProductInRegisterEntity pProductInRegisterEntity)
        {
            CORP_CODE = pProductInRegisterEntity.CORP_CODE;
            CRUD = pProductInRegisterEntity.CRUD;
            USER_CODE = pProductInRegisterEntity.USER_CODE;


            ERR_NO = pProductInRegisterEntity.ERR_NO;
            ERR_MSG = pProductInRegisterEntity.ERR_MSG;
            RTN_KEY = pProductInRegisterEntity.RTN_KEY;
            RTN_SEQ = pProductInRegisterEntity.RTN_SEQ;
            RTN_AQ = pProductInRegisterEntity.RTN_AQ;
            RTN_SQ = pProductInRegisterEntity.RTN_SQ;
            RTN_OTHERS = pProductInRegisterEntity.RTN_OTHERS;
            LANGUAGE_TYPE = pProductInRegisterEntity.LANGUAGE_TYPE;

            INOUT_ID = pProductInRegisterEntity.INOUT_ID;
            INOUT_DATE = pProductInRegisterEntity.INOUT_DATE;
            INOUT_SEQ = pProductInRegisterEntity.INOUT_SEQ;
            INOUT_TYPE = pProductInRegisterEntity.INOUT_TYPE;
            REFERENCE_ID = pProductInRegisterEntity.REFERENCE_ID;
            PART_CODE = pProductInRegisterEntity.PART_CODE;
            PART_NAME = pProductInRegisterEntity.PART_NAME;
            VEND_CODE = pProductInRegisterEntity.VEND_CODE;
            VEND_NAME = pProductInRegisterEntity.VEND_NAME;
            INOUT_QTY = pProductInRegisterEntity.INOUT_QTY;
            PART_UNIT = pProductInRegisterEntity.PART_UNIT;
            UNITCOST = pProductInRegisterEntity.UNITCOST;
            COST = pProductInRegisterEntity.COST;
            REMARK = pProductInRegisterEntity.REMARK;
            INOUT_CODE = pProductInRegisterEntity.INOUT_CODE;
            USE_YN = pProductInRegisterEntity.USE_YN;
            DATE_FROM = pProductInRegisterEntity.DATE_FROM;
            DATE_TO = pProductInRegisterEntity.DATE_TO;

            //메뉴별 추가 엔티티 입력
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


    public class ProductInRegister_T02Entity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE



        public String INOUT_ID { get; set; }
        public String INOUT_DATE { get; set; }
        public String INOUT_SEQ { get; set; }
        public String INOUT_TYPE { get; set; }
        public String REFERENCE_ID { get; set; }
        public String REFERENCE_ID2 { get; set; }
        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String VEND_CODE { get; set; }
        public String VEND_NAME { get; set; }
        public String INOUT_QTY { get; set; }
        public String PART_UNIT { get; set; }
        public String UNITCOST { get; set; }
        public String COST { get; set; }
        public String REMARK { get; set; }

        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        public String END_DATE { get; set; }
        // -----------
        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 키값
        public String RTN_AQ { get; set; } // 리턴 순번 값
        public String RTN_SQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String INOUT_CODE { get; set; }
        public String USE_YN { get; set; }

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - ProductInRegister_T02Entity()

        public ProductInRegister_T02Entity()
        {
        }

        #endregion

        #region 생성자 - ProductInRegister_T02Entity(ProductInRegister_T02Entity pProductInRegister_T02Entity)

        public ProductInRegister_T02Entity(ProductInRegister_T02Entity pProductInRegister_T02Entity)
        {
            CORP_CODE = pProductInRegister_T02Entity.CORP_CODE;
            CRUD = pProductInRegister_T02Entity.CRUD;
            USER_CODE = pProductInRegister_T02Entity.USER_CODE;


            ERR_NO = pProductInRegister_T02Entity.ERR_NO;
            ERR_MSG = pProductInRegister_T02Entity.ERR_MSG;
            RTN_KEY = pProductInRegister_T02Entity.RTN_KEY;
            RTN_SEQ = pProductInRegister_T02Entity.RTN_SEQ;
            RTN_AQ = pProductInRegister_T02Entity.RTN_AQ;
            RTN_SQ = pProductInRegister_T02Entity.RTN_SQ;
            RTN_OTHERS = pProductInRegister_T02Entity.RTN_OTHERS;
            LANGUAGE_TYPE = pProductInRegister_T02Entity.LANGUAGE_TYPE;

            INOUT_ID = pProductInRegister_T02Entity.INOUT_ID;
            INOUT_DATE = pProductInRegister_T02Entity.INOUT_DATE;
            INOUT_SEQ = pProductInRegister_T02Entity.INOUT_SEQ;
            INOUT_TYPE = pProductInRegister_T02Entity.INOUT_TYPE;
            REFERENCE_ID = pProductInRegister_T02Entity.REFERENCE_ID;
            REFERENCE_ID2 = pProductInRegister_T02Entity.REFERENCE_ID2;
            PART_CODE = pProductInRegister_T02Entity.PART_CODE;
            PART_NAME = pProductInRegister_T02Entity.PART_NAME;
            VEND_CODE = pProductInRegister_T02Entity.VEND_CODE;
            VEND_NAME = pProductInRegister_T02Entity.VEND_NAME;
            INOUT_QTY = pProductInRegister_T02Entity.INOUT_QTY;
            PART_UNIT = pProductInRegister_T02Entity.PART_UNIT;
            UNITCOST = pProductInRegister_T02Entity.UNITCOST;
            COST = pProductInRegister_T02Entity.COST;
            REMARK = pProductInRegister_T02Entity.REMARK;
            INOUT_CODE = pProductInRegister_T02Entity.INOUT_CODE;
            USE_YN = pProductInRegister_T02Entity.USE_YN;
            DATE_FROM = pProductInRegister_T02Entity.DATE_FROM;
            DATE_TO = pProductInRegister_T02Entity.DATE_TO;

            END_DATE = pProductInRegister_T02Entity.END_DATE;
            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }
    public class ProductInRegister_T01Entity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE



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
        public String PART_UNIT { get; set; }
        public String UNITCOST { get; set; }
        public String COST { get; set; }
        public String REMARK { get; set; }

        public String VEND_PART_CODE { get; set; }

        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        // -----------
        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 키값
        public String RTN_AQ { get; set; } // 리턴 순번 값
        public String RTN_SQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String INOUT_CODE { get; set; }
        public String USE_YN { get; set; }

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - ProductInRegister_T01Entity()

        public ProductInRegister_T01Entity()
        {
        }

        #endregion

        #region 생성자 - ProductInRegister_T01Entity(ProductInRegisterEntity pProductInRegister_T01Entity)

        public ProductInRegister_T01Entity(ProductInRegister_T01Entity pProductInRegister_T01Entity)
        {
            CORP_CODE = pProductInRegister_T01Entity.CORP_CODE;
            CRUD = pProductInRegister_T01Entity.CRUD;
            USER_CODE = pProductInRegister_T01Entity.USER_CODE;


            ERR_NO = pProductInRegister_T01Entity.ERR_NO;
            ERR_MSG = pProductInRegister_T01Entity.ERR_MSG;
            RTN_KEY = pProductInRegister_T01Entity.RTN_KEY;
            RTN_SEQ = pProductInRegister_T01Entity.RTN_SEQ;
            RTN_AQ = pProductInRegister_T01Entity.RTN_AQ;
            RTN_SQ = pProductInRegister_T01Entity.RTN_SQ;
            RTN_OTHERS = pProductInRegister_T01Entity.RTN_OTHERS;
            LANGUAGE_TYPE = pProductInRegister_T01Entity.LANGUAGE_TYPE;

            INOUT_ID = pProductInRegister_T01Entity.INOUT_ID;
            INOUT_DATE = pProductInRegister_T01Entity.INOUT_DATE;
            INOUT_SEQ = pProductInRegister_T01Entity.INOUT_SEQ;
            INOUT_TYPE = pProductInRegister_T01Entity.INOUT_TYPE;
            REFERENCE_ID = pProductInRegister_T01Entity.REFERENCE_ID;
            PART_CODE = pProductInRegister_T01Entity.PART_CODE;
            PART_NAME = pProductInRegister_T01Entity.PART_NAME;
            VEND_CODE = pProductInRegister_T01Entity.VEND_CODE;
            VEND_NAME = pProductInRegister_T01Entity.VEND_NAME;
            INOUT_QTY = pProductInRegister_T01Entity.INOUT_QTY;
            PART_UNIT = pProductInRegister_T01Entity.PART_UNIT;
            UNITCOST = pProductInRegister_T01Entity.UNITCOST;
            COST = pProductInRegister_T01Entity.COST;
            REMARK = pProductInRegister_T01Entity.REMARK;
            INOUT_CODE = pProductInRegister_T01Entity.INOUT_CODE;
            USE_YN = pProductInRegister_T01Entity.USE_YN;
            DATE_FROM = pProductInRegister_T01Entity.DATE_FROM;
            DATE_TO = pProductInRegister_T01Entity.DATE_TO;
            VEND_PART_CODE = pProductInRegister_T01Entity.VEND_PART_CODE;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }
    public class ProductInRegister_T04Entity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD

        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE
        public String LOCATION { get; set; } // LANGUAGE_TYPE
        


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
        public String PART_UNIT { get; set; }
        public String UNITCOST { get; set; }
        public String COST { get; set; }
        public String REMARK { get; set; }

        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        // -----------
        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 키값
        public String RTN_AQ { get; set; } // 리턴 순번 값
        public String RTN_SQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String INOUT_CODE { get; set; }
        public String USE_YN { get; set; }

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - ProductInRegister_T04Entity()

        public ProductInRegister_T04Entity()
        {
        }

        #endregion

        #region 생성자 - ProductInRegister_T04Entity(ProductInRegister_T04Entity pProductInRegister_T04Entity)

        public ProductInRegister_T04Entity(ProductInRegister_T04Entity pProductInRegister_T04Entity)
        {
            CORP_CODE = pProductInRegister_T04Entity.CORP_CODE;
            CRUD = pProductInRegister_T04Entity.CRUD;
            USER_CODE = pProductInRegister_T04Entity.USER_CODE;


            ERR_NO = pProductInRegister_T04Entity.ERR_NO;
            ERR_MSG = pProductInRegister_T04Entity.ERR_MSG;
            RTN_KEY = pProductInRegister_T04Entity.RTN_KEY;
            RTN_SEQ = pProductInRegister_T04Entity.RTN_SEQ;
            RTN_AQ = pProductInRegister_T04Entity.RTN_AQ;
            RTN_SQ = pProductInRegister_T04Entity.RTN_SQ;
            RTN_OTHERS = pProductInRegister_T04Entity.RTN_OTHERS;
            LANGUAGE_TYPE = pProductInRegister_T04Entity.LANGUAGE_TYPE;

            INOUT_ID = pProductInRegister_T04Entity.INOUT_ID;
            INOUT_DATE = pProductInRegister_T04Entity.INOUT_DATE;
            INOUT_SEQ = pProductInRegister_T04Entity.INOUT_SEQ;
            INOUT_TYPE = pProductInRegister_T04Entity.INOUT_TYPE;
            REFERENCE_ID = pProductInRegister_T04Entity.REFERENCE_ID;
            PART_CODE = pProductInRegister_T04Entity.PART_CODE;
            PART_NAME = pProductInRegister_T04Entity.PART_NAME;
            VEND_CODE = pProductInRegister_T04Entity.VEND_CODE;
            VEND_NAME = pProductInRegister_T04Entity.VEND_NAME;
            INOUT_QTY = pProductInRegister_T04Entity.INOUT_QTY;
            PART_UNIT = pProductInRegister_T04Entity.PART_UNIT;
            UNITCOST = pProductInRegister_T04Entity.UNITCOST;
            COST = pProductInRegister_T04Entity.COST;
            REMARK = pProductInRegister_T04Entity.REMARK;
            INOUT_CODE = pProductInRegister_T04Entity.INOUT_CODE;
            USE_YN = pProductInRegister_T04Entity.USE_YN;
            DATE_FROM = pProductInRegister_T04Entity.DATE_FROM;
            DATE_TO = pProductInRegister_T04Entity.DATE_TO;
            LOCATION = pProductInRegister_T04Entity.LOCATION;
            

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }
    public class ProductInRegister_T05Entity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE



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
        public String PART_UNIT { get; set; }
        public String UNITCOST { get; set; }
        public String COST { get; set; }
        public String REMARK { get; set; }

        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        // -----------
        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 키값
        public String RTN_AQ { get; set; } // 리턴 순번 값
        public String RTN_SQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String INOUT_CODE { get; set; }
        public String USE_YN { get; set; }

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - ProductInRegister_T05Entity()

        public ProductInRegister_T05Entity()
        {
        }

        #endregion

        #region 생성자 - ProductInRegister_T05Entity(ProductInRegister_T05Entity pProductInRegister_T05Entity)

        public ProductInRegister_T05Entity(ProductInRegister_T05Entity pProductInRegister_T05Entity)
        {
            CORP_CODE = pProductInRegister_T05Entity.CORP_CODE;
            CRUD = pProductInRegister_T05Entity.CRUD;
            USER_CODE = pProductInRegister_T05Entity.USER_CODE;


            ERR_NO = pProductInRegister_T05Entity.ERR_NO;
            ERR_MSG = pProductInRegister_T05Entity.ERR_MSG;
            RTN_KEY = pProductInRegister_T05Entity.RTN_KEY;
            RTN_SEQ = pProductInRegister_T05Entity.RTN_SEQ;
            RTN_AQ = pProductInRegister_T05Entity.RTN_AQ;
            RTN_SQ = pProductInRegister_T05Entity.RTN_SQ;
            RTN_OTHERS = pProductInRegister_T05Entity.RTN_OTHERS;
            LANGUAGE_TYPE = pProductInRegister_T05Entity.LANGUAGE_TYPE;

            INOUT_ID = pProductInRegister_T05Entity.INOUT_ID;
            INOUT_DATE = pProductInRegister_T05Entity.INOUT_DATE;
            INOUT_SEQ = pProductInRegister_T05Entity.INOUT_SEQ;
            INOUT_TYPE = pProductInRegister_T05Entity.INOUT_TYPE;
            REFERENCE_ID = pProductInRegister_T05Entity.REFERENCE_ID;
            PART_CODE = pProductInRegister_T05Entity.PART_CODE;
            PART_NAME = pProductInRegister_T05Entity.PART_NAME;
            VEND_CODE = pProductInRegister_T05Entity.VEND_CODE;
            VEND_NAME = pProductInRegister_T05Entity.VEND_NAME;
            INOUT_QTY = pProductInRegister_T05Entity.INOUT_QTY;
            PART_UNIT = pProductInRegister_T05Entity.PART_UNIT;
            UNITCOST = pProductInRegister_T05Entity.UNITCOST;
            COST = pProductInRegister_T05Entity.COST;
            REMARK = pProductInRegister_T05Entity.REMARK;
            INOUT_CODE = pProductInRegister_T05Entity.INOUT_CODE;
            USE_YN = pProductInRegister_T05Entity.USE_YN;
            DATE_FROM = pProductInRegister_T05Entity.DATE_FROM;
            DATE_TO = pProductInRegister_T05Entity.DATE_TO;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }
    public class ProductInStatusEntity
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

        #region 생성자 - ProductInStatusEntity()

        public ProductInStatusEntity()
        {
        }

        #endregion

        #region 생성자 - ProductInStatusEntity(pProductInStatusEntity)

        public ProductInStatusEntity(ProductInStatusEntity pProductInStatusEntity)
        {
            CORP_CODE = pProductInStatusEntity.CORP_CODE;
            CRUD = pProductInStatusEntity.CRUD;
            USER_CODE = pProductInStatusEntity.USER_CODE;
            LANGUAGE_TYPE = pProductInStatusEntity.LANGUAGE_TYPE;

            pProductInStatusEntity.DATE_FROM = DATE_FROM;
            pProductInStatusEntity.DATE_TO = DATE_TO;
            pProductInStatusEntity.PART_CODE = PART_CODE;
            pProductInStatusEntity.PART_NAME = PART_NAME;
            pProductInStatusEntity.VEND_NAME = VEND_NAME;
            pProductInStatusEntity.ORDER_ID = ORDER_ID;


            ERR_NO = pProductInStatusEntity.ERR_NO;
            ERR_MSG = pProductInStatusEntity.ERR_MSG;
            RTN_KEY = pProductInStatusEntity.RTN_KEY;
            RTN_SEQ = pProductInStatusEntity.RTN_SEQ;
            RTN_OTHERS = pProductInStatusEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }
    public class ProductInOutStatusEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE
        public String INOUT_TYPE { get; set; }
        public String INOUT_ID { get; set; }



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

        #region 생성자 - ProductInStatusEntity()

        public ProductInOutStatusEntity()
        {
        }

        #endregion

        #region 생성자 - ProductInStatusEntity(pProductInStatusEntity)

        public ProductInOutStatusEntity(ProductInOutStatusEntity pProductInOutStatusEntity)
        {
            CORP_CODE = pProductInOutStatusEntity.CORP_CODE;
            CRUD = pProductInOutStatusEntity.CRUD;
            USER_CODE = pProductInOutStatusEntity.USER_CODE;
            LANGUAGE_TYPE = pProductInOutStatusEntity.LANGUAGE_TYPE;
            INOUT_TYPE = pProductInOutStatusEntity.INOUT_TYPE;
            INOUT_ID = pProductInOutStatusEntity.INOUT_ID;

            pProductInOutStatusEntity.DATE_FROM = DATE_FROM;
            pProductInOutStatusEntity.DATE_TO = DATE_TO;
            pProductInOutStatusEntity.PART_CODE = PART_CODE;
            pProductInOutStatusEntity.PART_NAME = PART_NAME;
            pProductInOutStatusEntity.VEND_NAME = VEND_NAME;
            pProductInOutStatusEntity.ORDER_ID = ORDER_ID;


            ERR_NO = pProductInOutStatusEntity.ERR_NO;
            ERR_MSG = pProductInOutStatusEntity.ERR_MSG;
            RTN_KEY = pProductInOutStatusEntity.RTN_KEY;
            RTN_SEQ = pProductInOutStatusEntity.RTN_SEQ;
            RTN_OTHERS = pProductInOutStatusEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ProductInOutStatus_T50Entity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE
        public String INOUT_TYPE { get; set; }
        public String INOUT_ID { get; set; }



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

        #region 생성자 - ProductInStatus_T50Entity()

        public ProductInOutStatus_T50Entity()
        {
        }

        #endregion

        #region 생성자 - ProductInStatus_T50Entity(pProductInStatus_T50Entity)

        public ProductInOutStatus_T50Entity(ProductInOutStatus_T50Entity pProductInOutStatus_T50Entity)
        {
            CORP_CODE = pProductInOutStatus_T50Entity.CORP_CODE;
            CRUD = pProductInOutStatus_T50Entity.CRUD;
            USER_CODE = pProductInOutStatus_T50Entity.USER_CODE;
            LANGUAGE_TYPE = pProductInOutStatus_T50Entity.LANGUAGE_TYPE;
            INOUT_TYPE = pProductInOutStatus_T50Entity.INOUT_TYPE;
            INOUT_ID = pProductInOutStatus_T50Entity.INOUT_ID;

            pProductInOutStatus_T50Entity.DATE_FROM = DATE_FROM;
            pProductInOutStatus_T50Entity.DATE_TO = DATE_TO;
            pProductInOutStatus_T50Entity.PART_CODE = PART_CODE;
            pProductInOutStatus_T50Entity.PART_NAME = PART_NAME;
            pProductInOutStatus_T50Entity.VEND_NAME = VEND_NAME;
            pProductInOutStatus_T50Entity.ORDER_ID = ORDER_ID;


            ERR_NO = pProductInOutStatus_T50Entity.ERR_NO;
            ERR_MSG = pProductInOutStatus_T50Entity.ERR_MSG;
            RTN_KEY = pProductInOutStatus_T50Entity.RTN_KEY;
            RTN_SEQ = pProductInOutStatus_T50Entity.RTN_SEQ;
            RTN_OTHERS = pProductInOutStatus_T50Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ProductInOutStatus_T01Entity
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

        #region 생성자 - ProductInOutStatus_T01Entity()

        public ProductInOutStatus_T01Entity()
        {
        }

        #endregion

        #region 생성자 - ProductInOutStatus_T01Entity(pProductInOutStatus_T01Entity)

        public ProductInOutStatus_T01Entity(ProductInOutStatus_T01Entity pProductInOutStatus_T01Entity)
        {
            CORP_CODE = pProductInOutStatus_T01Entity.CORP_CODE;
            CRUD = pProductInOutStatus_T01Entity.CRUD;
            USER_CODE = pProductInOutStatus_T01Entity.USER_CODE;

            LANGUAGE_TYPE = pProductInOutStatus_T01Entity.LANGUAGE_TYPE;


            pProductInOutStatus_T01Entity.PART_TYPE = PART_TYPE;
            pProductInOutStatus_T01Entity.PART_NAME = PART_NAME;
            pProductInOutStatus_T01Entity.PART_CODE = PART_CODE;
            pProductInOutStatus_T01Entity.VEND_PART_CODE = VEND_PART_CODE;

            pProductInOutStatus_T01Entity.VEND_CODE = VEND_CODE;
            pProductInOutStatus_T01Entity.VEND_NAME = VEND_NAME;
            pProductInOutStatus_T01Entity.INOUT_TYPE = INOUT_TYPE;
            pProductInOutStatus_T01Entity.DATE_FROM = DATE_FROM;
            pProductInOutStatus_T01Entity.DATE_TO = DATE_TO;

            ERR_NO = pProductInOutStatus_T01Entity.ERR_NO;
            ERR_MSG = pProductInOutStatus_T01Entity.ERR_MSG;
            RTN_KEY = pProductInOutStatus_T01Entity.RTN_KEY;
            RTN_SEQ = pProductInOutStatus_T01Entity.RTN_SEQ;
            RTN_OTHERS = pProductInOutStatus_T01Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ProductInStatus_T02Entity
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

        #region 생성자 - ProductInStatus_T02Entity()

        public ProductInStatus_T02Entity()
        {
        }

        #endregion

        #region 생성자 - ProductInStatus_T02Entity(pProductInStatus_T02Entity)

        public ProductInStatus_T02Entity(ProductInStatus_T02Entity pProductInStatus_T02Entity)
        {
            CORP_CODE = pProductInStatus_T02Entity.CORP_CODE;
            CRUD = pProductInStatus_T02Entity.CRUD;
            USER_CODE = pProductInStatus_T02Entity.USER_CODE;

            LANGUAGE_TYPE = pProductInStatus_T02Entity.LANGUAGE_TYPE;


            pProductInStatus_T02Entity.PART_TYPE = PART_TYPE;
            pProductInStatus_T02Entity.PART_NAME = PART_NAME;
            pProductInStatus_T02Entity.PART_CODE = PART_CODE;
            pProductInStatus_T02Entity.VEND_PART_CODE = VEND_PART_CODE;

            pProductInStatus_T02Entity.VEND_CODE = VEND_CODE;
            pProductInStatus_T02Entity.VEND_NAME = VEND_NAME;
            pProductInStatus_T02Entity.INOUT_TYPE = INOUT_TYPE;
            pProductInStatus_T02Entity.DATE_FROM = DATE_FROM;
            pProductInStatus_T02Entity.DATE_TO = DATE_TO;

            ERR_NO = pProductInStatus_T02Entity.ERR_NO;
            ERR_MSG = pProductInStatus_T02Entity.ERR_MSG;
            RTN_KEY = pProductInStatus_T02Entity.RTN_KEY;
            RTN_SEQ = pProductInStatus_T02Entity.RTN_SEQ;
            RTN_OTHERS = pProductInStatus_T02Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ProductOutStatus_T02Entity
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

        #region 생성자 - ProductOutStatus_T02Entity()

        public ProductOutStatus_T02Entity()
        {
        }

        #endregion

        #region 생성자 - ProductOutStatus_T02Entity(pProductOutStatus_T02Entity)

        public ProductOutStatus_T02Entity(ProductOutStatus_T02Entity pProductOutStatus_T02Entity)
        {
            CORP_CODE = pProductOutStatus_T02Entity.CORP_CODE;
            CRUD = pProductOutStatus_T02Entity.CRUD;
            USER_CODE = pProductOutStatus_T02Entity.USER_CODE;

            LANGUAGE_TYPE = pProductOutStatus_T02Entity.LANGUAGE_TYPE;


            pProductOutStatus_T02Entity.PART_TYPE = PART_TYPE;
            pProductOutStatus_T02Entity.PART_NAME = PART_NAME;
            pProductOutStatus_T02Entity.PART_CODE = PART_CODE;
            pProductOutStatus_T02Entity.VEND_PART_CODE = VEND_PART_CODE;

            pProductOutStatus_T02Entity.VEND_CODE = VEND_CODE;
            pProductOutStatus_T02Entity.VEND_NAME = VEND_NAME;
            pProductOutStatus_T02Entity.INOUT_TYPE = INOUT_TYPE;
            pProductOutStatus_T02Entity.DATE_FROM = DATE_FROM;
            pProductOutStatus_T02Entity.DATE_TO = DATE_TO;

            ERR_NO = pProductOutStatus_T02Entity.ERR_NO;
            ERR_MSG = pProductOutStatus_T02Entity.ERR_MSG;
            RTN_KEY = pProductOutStatus_T02Entity.RTN_KEY;
            RTN_SEQ = pProductOutStatus_T02Entity.RTN_SEQ;
            RTN_OTHERS = pProductOutStatus_T02Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }
    
    public class ProductStockStatus_T01Entity
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

        #region 생성자 - ProductStockStatus_T01Entity()

        public ProductStockStatus_T01Entity()
        {
        }

        #endregion

        #region 생성자 - ProductStockStatus_T01Entity(pProductStockStatus_T01Entity)

        public ProductStockStatus_T01Entity(ProductStockStatus_T01Entity pProductStockStatus_T01Entity)
        {
            CORP_CODE = pProductStockStatus_T01Entity.CORP_CODE;
            CRUD = pProductStockStatus_T01Entity.CRUD;
            USER_CODE = pProductStockStatus_T01Entity.USER_CODE;

            LANGUAGE_TYPE = pProductStockStatus_T01Entity.LANGUAGE_TYPE;


            pProductStockStatus_T01Entity.PART_TYPE = PART_TYPE;
            pProductStockStatus_T01Entity.PART_NAME = PART_NAME;
            pProductStockStatus_T01Entity.PART_CODE = PART_CODE;

            ERR_NO = pProductStockStatus_T01Entity.ERR_NO;
            ERR_MSG = pProductStockStatus_T01Entity.ERR_MSG;
            RTN_KEY = pProductStockStatus_T01Entity.RTN_KEY;
            RTN_SEQ = pProductStockStatus_T01Entity.RTN_SEQ;
            RTN_OTHERS = pProductStockStatus_T01Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

 
    public class ProductNotOutStatusEntity
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

        #region 생성자 - ProductNotOutStatusEntity()

        public ProductNotOutStatusEntity()
        {
        }

        #endregion

        #region 생성자 - ProductNotOutStatusEntity(pProductNotOutStatusEntity)

        public ProductNotOutStatusEntity(ProductNotOutStatusEntity pProductNotOutStatusEntity)
        {
            CORP_CODE = pProductNotOutStatusEntity.CORP_CODE;
            CRUD = pProductNotOutStatusEntity.CRUD;
            USER_CODE = pProductNotOutStatusEntity.USER_CODE;
            LANGUAGE_TYPE = pProductNotOutStatusEntity.LANGUAGE_TYPE;

            pProductNotOutStatusEntity.DATE_FROM = DATE_FROM;
            pProductNotOutStatusEntity.DATE_TO = DATE_TO;
            pProductNotOutStatusEntity.PART_CODE = PART_CODE;
            pProductNotOutStatusEntity.PART_NAME = PART_NAME;
            pProductNotOutStatusEntity.VEND_NAME = VEND_NAME;
            pProductNotOutStatusEntity.ORDER_ID = ORDER_ID;


            ERR_NO = pProductNotOutStatusEntity.ERR_NO;
            ERR_MSG = pProductNotOutStatusEntity.ERR_MSG;
            RTN_KEY = pProductNotOutStatusEntity.RTN_KEY;
            RTN_SEQ = pProductNotOutStatusEntity.RTN_SEQ;
            RTN_OTHERS = pProductNotOutStatusEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ProductOutOrderStatusEntity
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

        #region 생성자 - ProductOutOrderStatusEntity()

        public ProductOutOrderStatusEntity()
        {
        }

        #endregion

        #region 생성자 - ProductOutOrderStatusEntity(pProductOutOrderStatusEntity)

        public ProductOutOrderStatusEntity(ProductOutOrderStatusEntity pProductOutOrderStatusEntity)
        {
            CORP_CODE = pProductOutOrderStatusEntity.CORP_CODE;
            CRUD = pProductOutOrderStatusEntity.CRUD;
            USER_CODE = pProductOutOrderStatusEntity.USER_CODE;
            LANGUAGE_TYPE = pProductOutOrderStatusEntity.LANGUAGE_TYPE;

            pProductOutOrderStatusEntity.DATE_FROM = DATE_FROM;
            pProductOutOrderStatusEntity.DATE_TO = DATE_TO;
            pProductOutOrderStatusEntity.PART_CODE = PART_CODE;
            pProductOutOrderStatusEntity.PART_NAME = PART_NAME;
            pProductOutOrderStatusEntity.VEND_NAME = VEND_NAME;
            pProductOutOrderStatusEntity.ORDER_ID = ORDER_ID;


            ERR_NO = pProductOutOrderStatusEntity.ERR_NO;
            ERR_MSG = pProductOutOrderStatusEntity.ERR_MSG;
            RTN_KEY = pProductOutOrderStatusEntity.RTN_KEY;
            RTN_SEQ = pProductOutOrderStatusEntity.RTN_SEQ;
            RTN_OTHERS = pProductOutOrderStatusEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }
    public class ProductOutRegisterEntity
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
        public String PART_UNIT { get; set; }
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

        #region 생성자 - ProductOutRegisterEntity()

        public ProductOutRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - ProductOutRegisterEntity(ProductOutRegisterEntity pMaterialInRegisterEntity)

        public ProductOutRegisterEntity(ProductOutRegisterEntity pProductOutRegisterEntity)
        {
            CORP_CODE = pProductOutRegisterEntity.CORP_CODE;
            CRUD = pProductOutRegisterEntity.CRUD;
            USER_CODE = pProductOutRegisterEntity.USER_CODE;
            LANGUAGE_TYPE = pProductOutRegisterEntity.LANGUAGE_TYPE;

            ERR_NO = pProductOutRegisterEntity.ERR_NO;
            ERR_MSG = pProductOutRegisterEntity.ERR_MSG;
            RTN_KEY = pProductOutRegisterEntity.RTN_KEY;
            RTN_SEQ = pProductOutRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pProductOutRegisterEntity.RTN_OTHERS;

           INOUT_ID               = pProductOutRegisterEntity.INOUT_ID;
           INOUT_DATE             = pProductOutRegisterEntity.INOUT_DATE;
           INOUT_SEQ              = pProductOutRegisterEntity.INOUT_SEQ;
           INOUT_TYPE             = pProductOutRegisterEntity.INOUT_TYPE;
           REFERENCE_ID           = pProductOutRegisterEntity.REFERENCE_ID;
           PART_CODE              = pProductOutRegisterEntity.PART_CODE;
           PART_NAME              = pProductOutRegisterEntity.PART_NAME;
           VEND_CODE              = pProductOutRegisterEntity.VEND_CODE;
           VEND_NAME              = pProductOutRegisterEntity.VEND_NAME;
           INOUT_QTY              = pProductOutRegisterEntity.INOUT_QTY;
           PART_UNIT              = pProductOutRegisterEntity.PART_UNIT;
           UNITCOST_CURRENCY_CODE = pProductOutRegisterEntity.UNITCOST_CURRENCY_CODE;
           UNITCOST               = pProductOutRegisterEntity.UNITCOST;
           COST                   = pProductOutRegisterEntity.COST;
           REMARK                 = pProductOutRegisterEntity.REMARK;
            INOUT_CODE = pProductOutRegisterEntity.INOUT_CODE;
            USE_YN = pProductOutRegisterEntity.USE_YN;
            DATE_FROM = pProductOutRegisterEntity.DATE_FROM;
            DATE_TO = pProductOutRegisterEntity.DATE_TO;
            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ProductOutRegister_T05Entity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE

        public String LOCATION { get; set; } // LANGUAGE_TYPE


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
        public String PART_UNIT { get; set; }
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

        #region 생성자 - ProductOutRegister_T05Entity()

        public ProductOutRegister_T05Entity()
        {
        }

        #endregion

        #region 생성자 - ProductOutRegister_T05Entity(ProductOutRegister_T05Entity pMaterialInRegisterEntity)

        public ProductOutRegister_T05Entity(ProductOutRegister_T05Entity pProductOutRegister_T05Entity)
        {
            CORP_CODE = pProductOutRegister_T05Entity.CORP_CODE;
            CRUD = pProductOutRegister_T05Entity.CRUD;
            USER_CODE = pProductOutRegister_T05Entity.USER_CODE;
            LANGUAGE_TYPE = pProductOutRegister_T05Entity.LANGUAGE_TYPE;

            ERR_NO = pProductOutRegister_T05Entity.ERR_NO;
            ERR_MSG = pProductOutRegister_T05Entity.ERR_MSG;
            RTN_KEY = pProductOutRegister_T05Entity.RTN_KEY;
            RTN_SEQ = pProductOutRegister_T05Entity.RTN_SEQ;
            RTN_OTHERS = pProductOutRegister_T05Entity.RTN_OTHERS;

            INOUT_ID = pProductOutRegister_T05Entity.INOUT_ID;
            INOUT_DATE = pProductOutRegister_T05Entity.INOUT_DATE;
            INOUT_SEQ = pProductOutRegister_T05Entity.INOUT_SEQ;
            INOUT_TYPE = pProductOutRegister_T05Entity.INOUT_TYPE;
            REFERENCE_ID = pProductOutRegister_T05Entity.REFERENCE_ID;
            PART_CODE = pProductOutRegister_T05Entity.PART_CODE;
            PART_NAME = pProductOutRegister_T05Entity.PART_NAME;
            VEND_CODE = pProductOutRegister_T05Entity.VEND_CODE;
            VEND_NAME = pProductOutRegister_T05Entity.VEND_NAME;
            INOUT_QTY = pProductOutRegister_T05Entity.INOUT_QTY;
            PART_UNIT = pProductOutRegister_T05Entity.PART_UNIT;
            UNITCOST_CURRENCY_CODE = pProductOutRegister_T05Entity.UNITCOST_CURRENCY_CODE;
            UNITCOST = pProductOutRegister_T05Entity.UNITCOST;
            COST = pProductOutRegister_T05Entity.COST;
            REMARK = pProductOutRegister_T05Entity.REMARK;
            INOUT_CODE = pProductOutRegister_T05Entity.INOUT_CODE;
            USE_YN = pProductOutRegister_T05Entity.USE_YN;
            DATE_FROM = pProductOutRegister_T05Entity.DATE_FROM;
            DATE_TO = pProductOutRegister_T05Entity.DATE_TO;

            LOCATION = pProductOutRegister_T05Entity.LOCATION;
            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }



    public class ProductOutRegister_T02Entity
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
        public String VEND_PART_CODE { get; set; }

        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        public String END_DATE { get; set; }
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

        #region 생성자 - ProductOutRegisterEntity()

        public ProductOutRegister_T02Entity()
        {
        }

        #endregion

        #region 생성자 - ProductOutRegister_T02Entity(ProductOutRegister_T02Entity pProductOutRegister_T02Entity)

        public ProductOutRegister_T02Entity(ProductOutRegister_T02Entity pProductOutRegister_T02Entity)
        {
            CORP_CODE = pProductOutRegister_T02Entity.CORP_CODE;
            CRUD = pProductOutRegister_T02Entity.CRUD;
            USER_CODE = pProductOutRegister_T02Entity.USER_CODE;
            LANGUAGE_TYPE = pProductOutRegister_T02Entity.LANGUAGE_TYPE;

            ERR_NO = pProductOutRegister_T02Entity.ERR_NO;
            ERR_MSG = pProductOutRegister_T02Entity.ERR_MSG;
            RTN_KEY = pProductOutRegister_T02Entity.RTN_KEY;
            RTN_SEQ = pProductOutRegister_T02Entity.RTN_SEQ;
            RTN_OTHERS = pProductOutRegister_T02Entity.RTN_OTHERS;

            INOUT_ID = pProductOutRegister_T02Entity.INOUT_ID;
            INOUT_DATE = pProductOutRegister_T02Entity.INOUT_DATE;
            INOUT_SEQ = pProductOutRegister_T02Entity.INOUT_SEQ;
            INOUT_TYPE = pProductOutRegister_T02Entity.INOUT_TYPE;
            REFERENCE_ID = pProductOutRegister_T02Entity.REFERENCE_ID;
            PART_CODE = pProductOutRegister_T02Entity.PART_CODE;
            PART_NAME = pProductOutRegister_T02Entity.PART_NAME;
            VEND_CODE = pProductOutRegister_T02Entity.VEND_CODE;
            VEND_NAME = pProductOutRegister_T02Entity.VEND_NAME;
            INOUT_QTY = pProductOutRegister_T02Entity.INOUT_QTY;
            UNITCOST_CURRENCY_CODE = pProductOutRegister_T02Entity.UNITCOST_CURRENCY_CODE;
            UNITCOST = pProductOutRegister_T02Entity.UNITCOST;
            COST = pProductOutRegister_T02Entity.COST;
            REMARK = pProductOutRegister_T02Entity.REMARK;
            INOUT_CODE = pProductOutRegister_T02Entity.INOUT_CODE;
            USE_YN = pProductOutRegister_T02Entity.USE_YN;
            DATE_FROM = pProductOutRegister_T02Entity.DATE_FROM;
            DATE_TO = pProductOutRegister_T02Entity.DATE_TO;
            END_DATE = pProductOutRegister_T02Entity.END_DATE;
            VEND_PART_CODE = pProductOutRegister_T02Entity.VEND_PART_CODE;
            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ProductOutRegister_T03Entity
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

        #region 생성자 - ProductOutRegister_T03Entity()

        public ProductOutRegister_T03Entity()
        {
        }

        #endregion

        #region 생성자 - ProductOutRegister_T03Entity(ProductOutRegister_T03Entity pMaterialInRegisterEntity)

        public ProductOutRegister_T03Entity(ProductOutRegister_T03Entity pProductOutRegister_T03Entity)
        {
            CORP_CODE = pProductOutRegister_T03Entity.CORP_CODE;
            CRUD = pProductOutRegister_T03Entity.CRUD;
            USER_CODE = pProductOutRegister_T03Entity.USER_CODE;
            LANGUAGE_TYPE = pProductOutRegister_T03Entity.LANGUAGE_TYPE;
            WINDOW_NAME = pProductOutRegister_T03Entity.WINDOW_NAME;

            ERR_NO = pProductOutRegister_T03Entity.ERR_NO;
            ERR_MSG = pProductOutRegister_T03Entity.ERR_MSG;
            RTN_KEY = pProductOutRegister_T03Entity.RTN_KEY;
            RTN_SEQ = pProductOutRegister_T03Entity.RTN_SEQ;
            RTN_OTHERS = pProductOutRegister_T03Entity.RTN_OTHERS;

            INOUT_ID = pProductOutRegister_T03Entity.INOUT_ID;
            INOUT_DATE = pProductOutRegister_T03Entity.INOUT_DATE;
            INOUT_SEQ = pProductOutRegister_T03Entity.INOUT_SEQ;
            INOUT_TYPE = pProductOutRegister_T03Entity.INOUT_TYPE;
            REFERENCE_ID = pProductOutRegister_T03Entity.REFERENCE_ID;
            PART_CODE = pProductOutRegister_T03Entity.PART_CODE;
            PART_NAME = pProductOutRegister_T03Entity.PART_NAME;
            VEND_CODE = pProductOutRegister_T03Entity.VEND_CODE;
            VEND_NAME = pProductOutRegister_T03Entity.VEND_NAME;
            INOUT_QTY = pProductOutRegister_T03Entity.INOUT_QTY;
            UNITCOST_CURRENCY_CODE = pProductOutRegister_T03Entity.UNITCOST_CURRENCY_CODE;
            UNITCOST = pProductOutRegister_T03Entity.UNITCOST;
            COST = pProductOutRegister_T03Entity.COST;
            REMARK = pProductOutRegister_T03Entity.REMARK;
            INOUT_CODE = pProductOutRegister_T03Entity.INOUT_CODE;
            USE_YN = pProductOutRegister_T03Entity.USE_YN;
            DATE_FROM = pProductOutRegister_T03Entity.DATE_FROM;
            DATE_TO = pProductOutRegister_T03Entity.DATE_TO;
            //메뉴별 추가 엔티티 입력
            USER_NAME = pProductOutRegister_T03Entity.USER_NAME;
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

    public class ProductOutStatusEntity
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

        #region 생성자 - ProductOutStatusEntity()

        public ProductOutStatusEntity()
        {
        }

        #endregion

        #region 생성자 - ProductOutStatusEntity(pProductOutStatusEntity)

        public ProductOutStatusEntity(ProductOutStatusEntity pProductOutStatusEntity)
        {
            CORP_CODE = pProductOutStatusEntity.CORP_CODE;
            CRUD = pProductOutStatusEntity.CRUD;
            USER_CODE = pProductOutStatusEntity.USER_CODE;
            LANGUAGE_TYPE = pProductOutStatusEntity.LANGUAGE_TYPE;

            pProductOutStatusEntity.DATE_FROM = DATE_FROM;
            pProductOutStatusEntity.DATE_TO = DATE_TO;
            pProductOutStatusEntity.PART_NAME = PART_NAME;
            pProductOutStatusEntity.VEND_NAME = VEND_NAME;
            pProductOutStatusEntity.ORDER_ID = ORDER_ID;

            ERR_NO = pProductOutStatusEntity.ERR_NO;
            ERR_MSG = pProductOutStatusEntity.ERR_MSG;
            RTN_KEY = pProductOutStatusEntity.RTN_KEY;
            RTN_SEQ = pProductOutStatusEntity.RTN_SEQ;
            RTN_OTHERS = pProductOutStatusEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }
    public class ProductTrackingStatusEntity
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
        public String BAR_CODE { get; set; }


        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - ProductTrackingStatusEntity()

        public ProductTrackingStatusEntity()
        {
        }

        #endregion

        #region 생성자 - ProductTrackingStatusEntity(pProductTrackingStatusEntity)

        public ProductTrackingStatusEntity(ProductTrackingStatusEntity pProductTrackingStatusEntity)
        {
            CORP_CODE = pProductTrackingStatusEntity.CORP_CODE;
            CRUD = pProductTrackingStatusEntity.CRUD;
            USER_CODE = pProductTrackingStatusEntity.USER_CODE;
            LANGUAGE_TYPE = pProductTrackingStatusEntity.LANGUAGE_TYPE;

            pProductTrackingStatusEntity.DATE_FROM = DATE_FROM;
            pProductTrackingStatusEntity.DATE_TO = DATE_TO;
            pProductTrackingStatusEntity.PART_NAME = PART_NAME;
            pProductTrackingStatusEntity.VEND_NAME = VEND_NAME;
            pProductTrackingStatusEntity.ORDER_ID = ORDER_ID;
            pProductTrackingStatusEntity.BAR_CODE = BAR_CODE;
            ERR_NO = pProductTrackingStatusEntity.ERR_NO;
            ERR_MSG = pProductTrackingStatusEntity.ERR_MSG;
            RTN_KEY = pProductTrackingStatusEntity.RTN_KEY;
            RTN_SEQ = pProductTrackingStatusEntity.RTN_SEQ;
            RTN_OTHERS = pProductTrackingStatusEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }
    public class ProductStockStatusEntity
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

        #region 생성자 - ProductStockStatusEntity()

        public ProductStockStatusEntity()
        {
        }

        #endregion

        #region 생성자 - ProductStockStatusEntity(pProductStockStatusEntity)

        public ProductStockStatusEntity(ProductStockStatusEntity pProductStockStatusEntity)
        {
            CORP_CODE = pProductStockStatusEntity.CORP_CODE;
            CRUD = pProductStockStatusEntity.CRUD;
            USER_CODE = pProductStockStatusEntity.USER_CODE;
            LANGUAGE_TYPE = pProductStockStatusEntity.LANGUAGE_TYPE;

            pProductStockStatusEntity.PART_TYPE = PART_TYPE;
            pProductStockStatusEntity.PART_NAME = PART_NAME;
            pProductStockStatusEntity.PART_CODE = PART_CODE;

            ERR_NO = pProductStockStatusEntity.ERR_NO;
            ERR_MSG = pProductStockStatusEntity.ERR_MSG;
            RTN_KEY = pProductStockStatusEntity.RTN_KEY;
            RTN_SEQ = pProductStockStatusEntity.RTN_SEQ;
            RTN_OTHERS = pProductStockStatusEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ProductStockStatus_T05Entity
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

        #region 생성자 - ProductStockStatus_T05Entity()

        public ProductStockStatus_T05Entity()
        {
        }

        #endregion

        #region 생성자 - ProductStockStatus_T05Entity(pProductStockStatus_T05Entity)

        public ProductStockStatus_T05Entity(ProductStockStatus_T05Entity pProductStockStatus_T05Entity)
        {
            CORP_CODE = pProductStockStatus_T05Entity.CORP_CODE;
            CRUD = pProductStockStatus_T05Entity.CRUD;
            USER_CODE = pProductStockStatus_T05Entity.USER_CODE;

            LANGUAGE_TYPE = pProductStockStatus_T05Entity.LANGUAGE_TYPE;


            pProductStockStatus_T05Entity.PART_TYPE = PART_TYPE;
            pProductStockStatus_T05Entity.PART_NAME = PART_NAME;
            pProductStockStatus_T05Entity.PART_CODE = PART_CODE;
            pProductStockStatus_T05Entity.VEND_PART_CODE = VEND_PART_CODE;
            


            ERR_NO = pProductStockStatus_T05Entity.ERR_NO;
            ERR_MSG = pProductStockStatus_T05Entity.ERR_MSG;
            RTN_KEY = pProductStockStatus_T05Entity.RTN_KEY;
            RTN_SEQ = pProductStockStatus_T05Entity.RTN_SEQ;
            RTN_OTHERS = pProductStockStatus_T05Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ProductInformationRegisterEntity
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

        #region 생성자 - ProductInformationRegisterEntity()

        public ProductInformationRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - ProductInformationRegisterEntity(pProductInformationRegisterEntity)

        public ProductInformationRegisterEntity(ProductInformationRegisterEntity pProductInformationRegisterEntity)
        {
            CORP_CODE = pProductInformationRegisterEntity.CORP_CODE;
            CRUD = pProductInformationRegisterEntity.CRUD;
            PART_CODE = pProductInformationRegisterEntity.PART_CODE;
            PART_REVISION_NO = pProductInformationRegisterEntity.PART_REVISION_NO;
            PART_NAME = pProductInformationRegisterEntity.PART_NAME;
            PART_TYPE = pProductInformationRegisterEntity.PART_TYPE;
            VEND_PART_CODE = pProductInformationRegisterEntity.VEND_PART_CODE;
            PART_UNIT = pProductInformationRegisterEntity.PART_UNIT;
            PART_STANDARD = pProductInformationRegisterEntity.PART_STANDARD;
            PART_MANUFACTURER = pProductInformationRegisterEntity.PART_MANUFACTURER;
            PART_COST = pProductInformationRegisterEntity.PART_COST;
            PART_SAFE_STOCK = pProductInformationRegisterEntity.PART_SAFE_STOCK;
            PART_START_DATE = pProductInformationRegisterEntity.PART_START_DATE;
            PART_END_DATE = pProductInformationRegisterEntity.PART_END_DATE;
            SALE_YN = pProductInformationRegisterEntity.SALE_YN;
            PURC_YN = pProductInformationRegisterEntity.PURC_YN;
            OUTT_YN = pProductInformationRegisterEntity.OUTT_YN;
            USE_YN = pProductInformationRegisterEntity.USE_YN;
            REMARK = pProductInformationRegisterEntity.REMARK;
            IMAGE_NAME = pProductInformationRegisterEntity.IMAGE_NAME;
            LANGUAGE_TYPE = pProductInformationRegisterEntity.LANGUAGE_TYPE;
            VEND_CODE = pProductInformationRegisterEntity.VEND_CODE;
            PART_UNITCOST_CURRENCY_CODE = pProductInformationRegisterEntity.PART_UNITCOST_CURRENCY_CODE;


            ERR_NO = pProductInformationRegisterEntity.ERR_NO;
            ERR_MSG = pProductInformationRegisterEntity.ERR_MSG;
            RTN_KEY = pProductInformationRegisterEntity.RTN_KEY;
            RTN_SEQ = pProductInformationRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pProductInformationRegisterEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }


    public class ProductInformationRegister_T03Entity
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

        #region 생성자 - ProductInformationRegister_T03Entity()

        public ProductInformationRegister_T03Entity()
        {
        }

        #endregion

        #region 생성자 - ProductInformationRegister_T03Entity(pProductInformationRegister_T03Entity)

        public ProductInformationRegister_T03Entity(ProductInformationRegister_T03Entity pProductInformationRegister_T03Entity)
        {
            CORP_CODE = pProductInformationRegister_T03Entity.CORP_CODE;
            CRUD = pProductInformationRegister_T03Entity.CRUD;
            PART_CODE = pProductInformationRegister_T03Entity.PART_CODE;
            PART_REVISION_NO = pProductInformationRegister_T03Entity.PART_REVISION_NO;
            PART_NAME = pProductInformationRegister_T03Entity.PART_NAME;
            PART_TYPE = pProductInformationRegister_T03Entity.PART_TYPE;
            VEND_PART_CODE = pProductInformationRegister_T03Entity.VEND_PART_CODE;
            PART_UNIT = pProductInformationRegister_T03Entity.PART_UNIT;
            PART_STANDARD = pProductInformationRegister_T03Entity.PART_STANDARD;
            PART_MANUFACTURER = pProductInformationRegister_T03Entity.PART_MANUFACTURER;
            PART_COST = pProductInformationRegister_T03Entity.PART_COST;
            PART_SAFE_STOCK = pProductInformationRegister_T03Entity.PART_SAFE_STOCK;
            PART_START_DATE = pProductInformationRegister_T03Entity.PART_START_DATE;
            PART_END_DATE = pProductInformationRegister_T03Entity.PART_END_DATE;
            SALE_YN = pProductInformationRegister_T03Entity.SALE_YN;
            PURC_YN = pProductInformationRegister_T03Entity.PURC_YN;
            OUTT_YN = pProductInformationRegister_T03Entity.OUTT_YN;
            USE_YN = pProductInformationRegister_T03Entity.USE_YN;
            REMARK = pProductInformationRegister_T03Entity.REMARK;
            IMAGE_NAME = pProductInformationRegister_T03Entity.IMAGE_NAME;
            LANGUAGE_TYPE = pProductInformationRegister_T03Entity.LANGUAGE_TYPE;
            VEND_CODE = pProductInformationRegister_T03Entity.VEND_CODE;
            PART_UNITCOST_CURRENCY_CODE = pProductInformationRegister_T03Entity.PART_UNITCOST_CURRENCY_CODE;


            ERR_NO = pProductInformationRegister_T03Entity.ERR_NO;
            ERR_MSG = pProductInformationRegister_T03Entity.ERR_MSG;
            RTN_KEY = pProductInformationRegister_T03Entity.RTN_KEY;
            RTN_SEQ = pProductInformationRegister_T03Entity.RTN_SEQ;
            RTN_OTHERS = pProductInformationRegister_T03Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }
    public class ProductInformationRegister_T01Entity
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

        #region 생성자 - ProductInformationRegister_T01Entity()

        public ProductInformationRegister_T01Entity()
        {
        }

        #endregion

        #region 생성자 - ProductInformationRegister_T01Entity(pProductInformationRegister_T01Entity)

        public ProductInformationRegister_T01Entity(ProductInformationRegister_T01Entity pProductInformationRegister_T01Entity)
        {
            CORP_CODE = pProductInformationRegister_T01Entity.CORP_CODE;
            CRUD = pProductInformationRegister_T01Entity.CRUD;

            CONTRACT_ID = pProductInformationRegister_T01Entity.CONTRACT_ID;
            CONTRACT_NUMBER = pProductInformationRegister_T01Entity.CONTRACT_NUMBER;
            CONTRACT_NUMBER_QTY = pProductInformationRegister_T01Entity.CONTRACT_NUMBER_QTY;

            PART_CODE = pProductInformationRegister_T01Entity.PART_CODE;
            PART_REVISION_NO = pProductInformationRegister_T01Entity.PART_REVISION_NO;
            PART_NAME = pProductInformationRegister_T01Entity.PART_NAME;
            PART_TYPE = pProductInformationRegister_T01Entity.PART_TYPE;
            VEND_PART_CODE = pProductInformationRegister_T01Entity.VEND_PART_CODE;

            PART_HIGH = pProductInformationRegister_T01Entity.PART_HIGH;
            PART_MIDDLE = pProductInformationRegister_T01Entity.PART_MIDDLE;
            PART_LOW = pProductInformationRegister_T01Entity.PART_LOW;

            PART_UNIT = pProductInformationRegister_T01Entity.PART_UNIT;
            PART_STANDARD = pProductInformationRegister_T01Entity.PART_STANDARD;
            PART_MANUFACTURER = pProductInformationRegister_T01Entity.PART_MANUFACTURER;
            PART_COST = pProductInformationRegister_T01Entity.PART_COST;
            PART_SAFE_STOCK = pProductInformationRegister_T01Entity.PART_SAFE_STOCK;
            PART_START_DATE = pProductInformationRegister_T01Entity.PART_START_DATE;
            PART_END_DATE = pProductInformationRegister_T01Entity.PART_END_DATE;
            SALE_YN = pProductInformationRegister_T01Entity.SALE_YN;
            PURC_YN = pProductInformationRegister_T01Entity.PURC_YN;
            OUTT_YN = pProductInformationRegister_T01Entity.OUTT_YN;
            USE_YN = pProductInformationRegister_T01Entity.USE_YN;
            REMARK = pProductInformationRegister_T01Entity.REMARK;
            IMAGE_NAME = pProductInformationRegister_T01Entity.IMAGE_NAME;
            LANGUAGE_TYPE = pProductInformationRegister_T01Entity.LANGUAGE_TYPE;
            VEND_CODE = pProductInformationRegister_T01Entity.VEND_CODE;

            ERR_NO = pProductInformationRegister_T01Entity.ERR_NO;
            ERR_MSG = pProductInformationRegister_T01Entity.ERR_MSG;
            RTN_KEY = pProductInformationRegister_T01Entity.RTN_KEY;
            RTN_SEQ = pProductInformationRegister_T01Entity.RTN_SEQ;
            RTN_OTHERS = pProductInformationRegister_T01Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ProductInformationRegister_T50Entity
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

        #region 생성자 - ProductInformationRegister_T50Entity()

        public ProductInformationRegister_T50Entity()
        {
        }

        #endregion

        #region 생성자 - ProductInformationRegister_T50Entity(pProductInformationRegister_T50Entity)

        public ProductInformationRegister_T50Entity(ProductInformationRegister_T50Entity pProductInformationRegister_T50Entity)
        {
            CORP_CODE = pProductInformationRegister_T50Entity.CORP_CODE;
            CRUD = pProductInformationRegister_T50Entity.CRUD;
            PART_CODE = pProductInformationRegister_T50Entity.PART_CODE;
            PART_REVISION_NO = pProductInformationRegister_T50Entity.PART_REVISION_NO;
            PART_NAME = pProductInformationRegister_T50Entity.PART_NAME;
            PART_TYPE = pProductInformationRegister_T50Entity.PART_TYPE;
            VEND_PART_CODE = pProductInformationRegister_T50Entity.VEND_PART_CODE;
            PART_UNIT = pProductInformationRegister_T50Entity.PART_UNIT;
            PART_STANDARD = pProductInformationRegister_T50Entity.PART_STANDARD;
            PART_MANUFACTURER = pProductInformationRegister_T50Entity.PART_MANUFACTURER;
            PART_COST = pProductInformationRegister_T50Entity.PART_COST;
            PART_SAFE_STOCK = pProductInformationRegister_T50Entity.PART_SAFE_STOCK;
            PART_START_DATE = pProductInformationRegister_T50Entity.PART_START_DATE;
            PART_END_DATE = pProductInformationRegister_T50Entity.PART_END_DATE;
            SALE_YN = pProductInformationRegister_T50Entity.SALE_YN;
            PURC_YN = pProductInformationRegister_T50Entity.PURC_YN;
            OUTT_YN = pProductInformationRegister_T50Entity.OUTT_YN;
            USE_YN = pProductInformationRegister_T50Entity.USE_YN;
            REMARK = pProductInformationRegister_T50Entity.REMARK;
            IMAGE_NAME = pProductInformationRegister_T50Entity.IMAGE_NAME;
            LANGUAGE_TYPE = pProductInformationRegister_T50Entity.LANGUAGE_TYPE;
            VEND_CODE = pProductInformationRegister_T50Entity.VEND_CODE;
            PART_UNITCOST_CURRENCY_CODE = pProductInformationRegister_T50Entity.PART_UNITCOST_CURRENCY_CODE;


            ERR_NO = pProductInformationRegister_T50Entity.ERR_NO;
            ERR_MSG = pProductInformationRegister_T50Entity.ERR_MSG;
            RTN_KEY = pProductInformationRegister_T50Entity.RTN_KEY;
            RTN_SEQ = pProductInformationRegister_T50Entity.RTN_SEQ;
            RTN_OTHERS = pProductInformationRegister_T50Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ProductInformationRegister_T02Entity
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
        public byte[] FILE_STRING { get; set; }

        public String VEND_CODE { get; set; } // 단가 조회 (상세)

        //고정 엔티티

        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }

        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - ProductInformationRegister_T02Entity()

        public ProductInformationRegister_T02Entity()
        {
        }

        #endregion

        #region 생성자 - ProductInformationRegister_T02Entity(pProductInformationRegister_T02Entity)

        public ProductInformationRegister_T02Entity(ProductInformationRegister_T02Entity pProductInformationRegister_T02Entity)
        {
            CORP_CODE = pProductInformationRegister_T02Entity.CORP_CODE;
            CRUD = pProductInformationRegister_T02Entity.CRUD;
            PART_CODE = pProductInformationRegister_T02Entity.PART_CODE;
            PART_REVISION_NO = pProductInformationRegister_T02Entity.PART_REVISION_NO;
            PART_NAME = pProductInformationRegister_T02Entity.PART_NAME;
            PART_TYPE = pProductInformationRegister_T02Entity.PART_TYPE;
            VEND_PART_CODE = pProductInformationRegister_T02Entity.VEND_PART_CODE;
            PART_UNIT = pProductInformationRegister_T02Entity.PART_UNIT;
            PART_STANDARD = pProductInformationRegister_T02Entity.PART_STANDARD;
            PART_MANUFACTURER = pProductInformationRegister_T02Entity.PART_MANUFACTURER;
            PART_COST = pProductInformationRegister_T02Entity.PART_COST;
            PART_SAFE_STOCK = pProductInformationRegister_T02Entity.PART_SAFE_STOCK;
            PART_START_DATE = pProductInformationRegister_T02Entity.PART_START_DATE;
            PART_END_DATE = pProductInformationRegister_T02Entity.PART_END_DATE;
            SALE_YN = pProductInformationRegister_T02Entity.SALE_YN;
            PURC_YN = pProductInformationRegister_T02Entity.PURC_YN;
            OUTT_YN = pProductInformationRegister_T02Entity.OUTT_YN;
            USE_YN = pProductInformationRegister_T02Entity.USE_YN;
            REMARK = pProductInformationRegister_T02Entity.REMARK;
            IMAGE_NAME = pProductInformationRegister_T02Entity.IMAGE_NAME;
            LANGUAGE_TYPE = pProductInformationRegister_T02Entity.LANGUAGE_TYPE;
            VEND_CODE = pProductInformationRegister_T02Entity.VEND_CODE;
            FILE_STRING = pProductInformationRegister_T02Entity.FILE_STRING;

            ERR_NO = pProductInformationRegister_T02Entity.ERR_NO;
            ERR_MSG = pProductInformationRegister_T02Entity.ERR_MSG;
            RTN_KEY = pProductInformationRegister_T02Entity.RTN_KEY;
            RTN_SEQ = pProductInformationRegister_T02Entity.RTN_SEQ;
            RTN_OTHERS = pProductInformationRegister_T02Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ProductInformationRegister_T06Entity
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
        public String PART_IN_COST { get; set; }
        public String PART_SAFE_STOCK { get; set; }
        public String PART_START_DATE { get; set; }
        public String PART_END_DATE { get; set; }
        public String SALE_YN { get; set; }
        public String PURC_YN { get; set; }
        public String OUTT_YN { get; set; }
        public String REMARK { get; set; }
        public String IMAGE_NAME { get; set; }
        public String USE_YN { get; set; }
        public byte[] FILE_STRING { get; set; }

        public String VEND_CODE { get; set; } // 단가 조회 (상세)
        public String VEND_CODE2 { get; set; } // 품목-거래처 연결
        
        //고정 엔티티

        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }

        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - ProductInformationRegister_T06Entity()

        public ProductInformationRegister_T06Entity()
        {
        }

        #endregion

        #region 생성자 - ProductInformationRegister_T06Entity(pProductInformationRegister_T06Entity)

        public ProductInformationRegister_T06Entity(ProductInformationRegister_T06Entity pProductInformationRegister_T06Entity)
        {
            CORP_CODE = pProductInformationRegister_T06Entity.CORP_CODE;
            CRUD = pProductInformationRegister_T06Entity.CRUD;
            PART_CODE = pProductInformationRegister_T06Entity.PART_CODE;
            PART_REVISION_NO = pProductInformationRegister_T06Entity.PART_REVISION_NO;
            PART_NAME = pProductInformationRegister_T06Entity.PART_NAME;
            PART_TYPE = pProductInformationRegister_T06Entity.PART_TYPE;
            VEND_PART_CODE = pProductInformationRegister_T06Entity.VEND_PART_CODE;
            PART_UNIT = pProductInformationRegister_T06Entity.PART_UNIT;
            PART_STANDARD = pProductInformationRegister_T06Entity.PART_STANDARD;
            PART_MANUFACTURER = pProductInformationRegister_T06Entity.PART_MANUFACTURER;
            PART_COST = pProductInformationRegister_T06Entity.PART_COST;
            PART_IN_COST = pProductInformationRegister_T06Entity.PART_IN_COST;
            PART_SAFE_STOCK = pProductInformationRegister_T06Entity.PART_SAFE_STOCK;
            PART_START_DATE = pProductInformationRegister_T06Entity.PART_START_DATE;
            PART_END_DATE = pProductInformationRegister_T06Entity.PART_END_DATE;
            SALE_YN = pProductInformationRegister_T06Entity.SALE_YN;
            PURC_YN = pProductInformationRegister_T06Entity.PURC_YN;
            OUTT_YN = pProductInformationRegister_T06Entity.OUTT_YN;
            USE_YN = pProductInformationRegister_T06Entity.USE_YN;
            REMARK = pProductInformationRegister_T06Entity.REMARK;
            IMAGE_NAME = pProductInformationRegister_T06Entity.IMAGE_NAME;
            LANGUAGE_TYPE = pProductInformationRegister_T06Entity.LANGUAGE_TYPE;
            VEND_CODE = pProductInformationRegister_T06Entity.VEND_CODE;
            VEND_CODE2 = pProductInformationRegister_T06Entity.VEND_CODE2;
            FILE_STRING = pProductInformationRegister_T06Entity.FILE_STRING;

            ERR_NO = pProductInformationRegister_T06Entity.ERR_NO;
            ERR_MSG = pProductInformationRegister_T06Entity.ERR_MSG;
            RTN_KEY = pProductInformationRegister_T06Entity.RTN_KEY;
            RTN_SEQ = pProductInformationRegister_T06Entity.RTN_SEQ;
            RTN_OTHERS = pProductInformationRegister_T06Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
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
    public class ucProductionPartListPopupEntity
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

        #region 생성자 - ucProductionPartListPopupEntity()

        public ucProductionPartListPopupEntity()
        {
        }

        #endregion

        #region 생성자 - ucProductionPartListPopupEntity(ucProductionPartListPopupEntity pucProductionPartListPopupEntity)

        public ucProductionPartListPopupEntity(ucProductionPartListPopupEntity pucProductionPartListPopupEntity)
        {
            CORP_CODE = pucProductionPartListPopupEntity.CORP_CODE;
            CRUD = pucProductionPartListPopupEntity.CRUD;
            USER_CODE = pucProductionPartListPopupEntity.USER_CODE;
            LANGUAGE_TYPE = pucProductionPartListPopupEntity.LANGUAGE_TYPE;
            WINDOW_NAME = pucProductionPartListPopupEntity.WINDOW_NAME;

            PART_CODE = pucProductionPartListPopupEntity.PART_CODE;
            PART_NAME = pucProductionPartListPopupEntity.PART_NAME;
            PART_REVISION_NO = pucProductionPartListPopupEntity.PART_REVISION_NO;
            VEND_PART_CODE = pucProductionPartListPopupEntity.VEND_PART_CODE;

            PART_HIGH = pucProductionPartListPopupEntity.PART_HIGH;
            PART_MIDDLE = pucProductionPartListPopupEntity.PART_MIDDLE;
            PART_LOW = pucProductionPartListPopupEntity.PART_LOW;

            ERR_NO = pucProductionPartListPopupEntity.ERR_NO;
            ERR_MSG = pucProductionPartListPopupEntity.ERR_MSG;
            RTN_KEY = pucProductionPartListPopupEntity.RTN_KEY;
            RTN_SEQ = pucProductionPartListPopupEntity.RTN_SEQ;
            RTN_AQ = pucProductionPartListPopupEntity.RTN_AQ;
            RTN_SQ = pucProductionPartListPopupEntity.RTN_SQ;
            RTN_OTHERS = pucProductionPartListPopupEntity.RTN_OTHERS;
            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }
    public class ucContractInfoPopupEntity
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

        #region 생성자 - ucContractInfoPopupEntity()

        public ucContractInfoPopupEntity()
        {
        }

        #endregion

        #region 생성자 - ucContractInfoPopupEntity(ucContractInfoPopupEntity pucContractInfoPopupEntity)

        public ucContractInfoPopupEntity(ucContractInfoPopupEntity pucContractInfoPopupEntity)
        {
            CORP_CODE = pucContractInfoPopupEntity.CORP_CODE;
            CRUD = pucContractInfoPopupEntity.CRUD;
            USER_CODE = pucContractInfoPopupEntity.USER_CODE;
            LANGUAGE_TYPE = pucContractInfoPopupEntity.LANGUAGE_TYPE;
            WINDOW_NAME = pucContractInfoPopupEntity.WINDOW_NAME;

            CONTRACT_ID = pucContractInfoPopupEntity.CONTRACT_ID;
            CONTRACT_DATE_FROM = pucContractInfoPopupEntity.CONTRACT_DATE_FROM;
            CONTRACT_DATE_TO = pucContractInfoPopupEntity.CONTRACT_DATE_TO;
            CONTRACT_NUMBER = pucContractInfoPopupEntity.CONTRACT_NUMBER;

            ERR_NO = pucContractInfoPopupEntity.ERR_NO;
            ERR_MSG = pucContractInfoPopupEntity.ERR_MSG;
            RTN_KEY = pucContractInfoPopupEntity.RTN_KEY;
            RTN_SEQ = pucContractInfoPopupEntity.RTN_SEQ;
            RTN_AQ = pucContractInfoPopupEntity.RTN_AQ;
            RTN_SQ = pucContractInfoPopupEntity.RTN_SQ;
            RTN_OTHERS = pucContractInfoPopupEntity.RTN_OTHERS;
            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class ucVendCostInfoListPopupEntity
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

        #region 생성자 - ucVendCostInfoListPopupEntity()

        public ucVendCostInfoListPopupEntity()
        {
        }

        #endregion

        #region 생성자 - ucVendCostInfoListPopupEntity(ucVendCostInfoListPopupEntity pucVendCostInfoListPopupEntity)

        public ucVendCostInfoListPopupEntity(ucVendCostInfoListPopupEntity pucVendCostInfoListPopupEntity)
        {
            CORP_CODE = pucVendCostInfoListPopupEntity.CORP_CODE;
            CRUD = pucVendCostInfoListPopupEntity.CRUD;
            USER_CODE = pucVendCostInfoListPopupEntity.USER_CODE;
            LANGUAGE_TYPE = pucVendCostInfoListPopupEntity.LANGUAGE_TYPE;
            WINDOW_NAME = pucVendCostInfoListPopupEntity.WINDOW_NAME;

            PART_CODE = pucVendCostInfoListPopupEntity.PART_CODE;
            PART_NAME = pucVendCostInfoListPopupEntity.PART_NAME;
            PART_REVISION_NO = pucVendCostInfoListPopupEntity.PART_REVISION_NO;
            VEND_PART_CODE = pucVendCostInfoListPopupEntity.VEND_PART_CODE;

            ERR_NO = pucVendCostInfoListPopupEntity.ERR_NO;
            ERR_MSG = pucVendCostInfoListPopupEntity.ERR_MSG;
            RTN_KEY = pucVendCostInfoListPopupEntity.RTN_KEY;
            RTN_SEQ = pucVendCostInfoListPopupEntity.RTN_SEQ;
            RTN_AQ = pucVendCostInfoListPopupEntity.RTN_AQ;
            RTN_SQ = pucVendCostInfoListPopupEntity.RTN_SQ;
            RTN_OTHERS = pucVendCostInfoListPopupEntity.RTN_OTHERS;
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

    public class ucPartDocumentListPopup_T01Entity
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

        #region 생성자 - ucPartDocumentListPopup_T01Entity()

        public ucPartDocumentListPopup_T01Entity()
        {
        }

        #endregion

        #region 생성자 - ucPartDocumentListPopup_T01Entity(ucPartDocumentListPopup_T01Entity pucPartDocumentListPopup_T01Entity)

        public ucPartDocumentListPopup_T01Entity(ucPartDocumentListPopup_T01Entity pucPartDocumentListPopup_T01Entity)
        {
            CORP_CODE = pucPartDocumentListPopup_T01Entity.CORP_CODE;
            CRUD = pucPartDocumentListPopup_T01Entity.CRUD;
            USER_CODE = pucPartDocumentListPopup_T01Entity.USER_CODE;
            LANGUAGE_TYPE = pucPartDocumentListPopup_T01Entity.LANGUAGE_TYPE;
            WINDOW_NAME = pucPartDocumentListPopup_T01Entity.WINDOW_NAME;

            PART_CODE = pucPartDocumentListPopup_T01Entity.PART_CODE;
            PART_NAME = pucPartDocumentListPopup_T01Entity.PART_NAME;
            PART_REVISION_NO = pucPartDocumentListPopup_T01Entity.PART_REVISION_NO;
            VEND_PART_CODE = pucPartDocumentListPopup_T01Entity.VEND_PART_CODE;
            PART_TYPE = pucPartDocumentListPopup_T01Entity.PART_TYPE;

            CONTRACT_ID = pucPartDocumentListPopup_T01Entity.CONTRACT_ID;
            CONTRACT_NUMBER = pucPartDocumentListPopup_T01Entity.CONTRACT_NUMBER;
            DOCUMENT_TYPE = pucPartDocumentListPopup_T01Entity.DOCUMENT_TYPE;
            DOCUMENT_NAME = pucPartDocumentListPopup_T01Entity.DOCUMENT_NAME;
            DOCUMENT_VER = pucPartDocumentListPopup_T01Entity.DOCUMENT_VER;

            USE_YN = pucPartDocumentListPopup_T01Entity.USE_YN;

            ERR_NO = pucPartDocumentListPopup_T01Entity.ERR_NO;
            ERR_MSG = pucPartDocumentListPopup_T01Entity.ERR_MSG;
            RTN_KEY = pucPartDocumentListPopup_T01Entity.RTN_KEY;
            RTN_SEQ = pucPartDocumentListPopup_T01Entity.RTN_SEQ;
            RTN_AQ = pucPartDocumentListPopup_T01Entity.RTN_AQ;
            RTN_SQ = pucPartDocumentListPopup_T01Entity.RTN_SQ;
            RTN_OTHERS = pucPartDocumentListPopup_T01Entity.RTN_OTHERS;


            FTP_PATH = pucPartDocumentListPopup_T01Entity.FTP_PATH;

            FTP_IP_PORT = pucPartDocumentListPopup_T01Entity.FTP_IP_PORT;
            FTP_ID = pucPartDocumentListPopup_T01Entity.FTP_ID;
            FTP_PW = pucPartDocumentListPopup_T01Entity.FTP_PW;
            DOCUMENT_ID = pucPartDocumentListPopup_T01Entity.DOCUMENT_ID;
            DOCUMENT_TYPE_NAME = pucPartDocumentListPopup_T01Entity.DOCUMENT_TYPE_NAME;
            DOCUMENT_SEQ = pucPartDocumentListPopup_T01Entity.DOCUMENT_SEQ;
            DOCUMENT_FILE_NAME_FULL = pucPartDocumentListPopup_T01Entity.DOCUMENT_FILE_NAME_FULL;
            DOCUMENT_FILE_NAME = pucPartDocumentListPopup_T01Entity.DOCUMENT_FILE_NAME;
            DOCUMENT_BEFROE_FILE_NAME = pucPartDocumentListPopup_T01Entity.DOCUMENT_BEFROE_FILE_NAME;            
            REFERENCE_CODE = pucPartDocumentListPopup_T01Entity.REFERENCE_CODE;
            REMARK = pucPartDocumentListPopup_T01Entity.REMARK;

            SEQ = pucPartDocumentListPopup_T01Entity.SEQ;
            FILE_NAME_1 = pucPartDocumentListPopup_T01Entity.FILE_NAME_1;
            FILE_NAME_2 = pucPartDocumentListPopup_T01Entity.FILE_NAME_2;
            EXTENSION = pucPartDocumentListPopup_T01Entity.EXTENSION;
            FILE_FLAG = pucPartDocumentListPopup_T01Entity.FILE_FLAG;

            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }


    public class ProductBOMRegisterEntity
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

        #region 생성자 - ProductBOMRegisterEntity()

        public ProductBOMRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - ProductBOMRegisterEntity(pProductBOMRegisterEntity)

        public ProductBOMRegisterEntity(ProductBOMRegisterEntity pProductBOMRegisterEntity)
        {
            CORP_CODE = pProductBOMRegisterEntity.CORP_CODE;
            CRUD = pProductBOMRegisterEntity.CRUD;
            USER_CODE = pProductBOMRegisterEntity.USER_CODE;
            LANGUAGE_TYPE = pProductBOMRegisterEntity.LANGUAGE_TYPE;
            WINDOW_NAME = pProductBOMRegisterEntity.WINDOW_NAME;

            PART_CODE_MST = pProductBOMRegisterEntity.PART_CODE_MST;
            REVISION_NO = pProductBOMRegisterEntity.REVISION_NO;

            PART_TYPE = pProductBOMRegisterEntity.PART_TYPE;
            PART_NAME = pProductBOMRegisterEntity.PART_NAME;
            PART_CODE = pProductBOMRegisterEntity.PART_CODE;
            USE_YN = pProductBOMRegisterEntity.USE_YN;


            ERR_NO = pProductBOMRegisterEntity.ERR_NO;
            ERR_MSG = pProductBOMRegisterEntity.ERR_MSG;
            RTN_KEY = pProductBOMRegisterEntity.RTN_KEY;
            RTN_SEQ = pProductBOMRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pProductBOMRegisterEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }
    public class ProductBOMRegister_T03Entity
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

        #region 생성자 - ProductBOMRegister_T03Entity()

        public ProductBOMRegister_T03Entity()
        {
        }

        #endregion

        #region 생성자 - ProductBOMRegister_T03Entity(pProductBOMRegister_T03Entity)

        public ProductBOMRegister_T03Entity(ProductBOMRegister_T03Entity pProductBOMRegister_T03Entity)
        {
            CORP_CODE = pProductBOMRegister_T03Entity.CORP_CODE;
            CRUD = pProductBOMRegister_T03Entity.CRUD;
            USER_CODE = pProductBOMRegister_T03Entity.USER_CODE;
            LANGUAGE_TYPE = pProductBOMRegister_T03Entity.LANGUAGE_TYPE;
            WINDOW_NAME = pProductBOMRegister_T03Entity.WINDOW_NAME;

            PART_CODE_MST = pProductBOMRegister_T03Entity.PART_CODE_MST;
            REVISION_NO = pProductBOMRegister_T03Entity.REVISION_NO;

            PART_TYPE = pProductBOMRegister_T03Entity.PART_TYPE;
            PART_NAME = pProductBOMRegister_T03Entity.PART_NAME;
            PART_CODE = pProductBOMRegister_T03Entity.PART_CODE;
            USE_YN = pProductBOMRegister_T03Entity.USE_YN;


            ERR_NO = pProductBOMRegister_T03Entity.ERR_NO;
            ERR_MSG = pProductBOMRegister_T03Entity.ERR_MSG;
            RTN_KEY = pProductBOMRegister_T03Entity.RTN_KEY;
            RTN_SEQ = pProductBOMRegister_T03Entity.RTN_SEQ;
            RTN_OTHERS = pProductBOMRegister_T03Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ProductBOMRegister_T04Entity
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

        #region 생성자 - ProductBOMRegister_T04Entity()

        public ProductBOMRegister_T04Entity()
        {
        }

        #endregion

        #region 생성자 - ProductBOMRegister_T04Entity(pProductBOMRegister_T04Entity)

        public ProductBOMRegister_T04Entity(ProductBOMRegister_T04Entity pProductBOMRegister_T04Entity)
        {
            CORP_CODE = pProductBOMRegister_T04Entity.CORP_CODE;
            CRUD = pProductBOMRegister_T04Entity.CRUD;
            USER_CODE = pProductBOMRegister_T04Entity.USER_CODE;
            LANGUAGE_TYPE = pProductBOMRegister_T04Entity.LANGUAGE_TYPE;
            WINDOW_NAME = pProductBOMRegister_T04Entity.WINDOW_NAME;

            PART_CODE_MST = pProductBOMRegister_T04Entity.PART_CODE_MST;
            REVISION_NO = pProductBOMRegister_T04Entity.REVISION_NO;

            PART_TYPE = pProductBOMRegister_T04Entity.PART_TYPE;
            PART_NAME = pProductBOMRegister_T04Entity.PART_NAME;
            PART_CODE = pProductBOMRegister_T04Entity.PART_CODE;
            USE_YN = pProductBOMRegister_T04Entity.USE_YN;


            ERR_NO = pProductBOMRegister_T04Entity.ERR_NO;
            ERR_MSG = pProductBOMRegister_T04Entity.ERR_MSG;
            RTN_KEY = pProductBOMRegister_T04Entity.RTN_KEY;
            RTN_SEQ = pProductBOMRegister_T04Entity.RTN_SEQ;
            RTN_OTHERS = pProductBOMRegister_T04Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }
    public class ProductBOMRegister_T01Entity
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
        public String VEND_PART_CODE { get; set; }
        public String PART_HIGH { get; set; }
        public String PART_MIDDLE { get; set; }
        public String PART_LOW { get; set; }
        public String USE_YN { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - ProductBOMRegisterEntity()

        public ProductBOMRegister_T01Entity()
        {
        }

        #endregion

        #region 생성자 - ProductBOMRegister_T01Entity(pProductBOMRegister_T01Entity)

        public ProductBOMRegister_T01Entity(ProductBOMRegister_T01Entity pProductBOMRegister_T01Entity)
        {
            CORP_CODE = pProductBOMRegister_T01Entity.CORP_CODE;
            CRUD = pProductBOMRegister_T01Entity.CRUD;
            USER_CODE = pProductBOMRegister_T01Entity.USER_CODE;
            LANGUAGE_TYPE = pProductBOMRegister_T01Entity.LANGUAGE_TYPE;
            WINDOW_NAME = pProductBOMRegister_T01Entity.WINDOW_NAME;

            PART_CODE_MST = pProductBOMRegister_T01Entity.PART_CODE_MST;
            REVISION_NO = pProductBOMRegister_T01Entity.REVISION_NO;

            PART_TYPE = pProductBOMRegister_T01Entity.PART_TYPE;
            PART_NAME = pProductBOMRegister_T01Entity.PART_NAME;
            PART_CODE = pProductBOMRegister_T01Entity.PART_CODE;
            VEND_PART_CODE = pProductBOMRegister_T01Entity.VEND_PART_CODE;

            PART_HIGH = pProductBOMRegister_T01Entity.PART_HIGH;
            PART_MIDDLE = pProductBOMRegister_T01Entity.PART_MIDDLE;
            PART_LOW = pProductBOMRegister_T01Entity.PART_LOW;

            USE_YN = pProductBOMRegister_T01Entity.USE_YN;


            ERR_NO = pProductBOMRegister_T01Entity.ERR_NO;
            ERR_MSG = pProductBOMRegister_T01Entity.ERR_MSG;
            RTN_KEY = pProductBOMRegister_T01Entity.RTN_KEY;
            RTN_SEQ = pProductBOMRegister_T01Entity.RTN_SEQ;
            RTN_OTHERS = pProductBOMRegister_T01Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ProductBOMRegister_T02Entity
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

        #region 생성자 - ProductBOMRegister_T02Entity()

        public ProductBOMRegister_T02Entity()
        {
        }

        #endregion

        #region 생성자 - ProductBOMRegister_T02Entity(pProductBOMRegister_T02Entity)

        public ProductBOMRegister_T02Entity(ProductBOMRegister_T02Entity pProductBOMRegister_T02Entity)
        {
            CORP_CODE = pProductBOMRegister_T02Entity.CORP_CODE;
            CRUD = pProductBOMRegister_T02Entity.CRUD;
            USER_CODE = pProductBOMRegister_T02Entity.USER_CODE;
            LANGUAGE_TYPE = pProductBOMRegister_T02Entity.LANGUAGE_TYPE;
            WINDOW_NAME = pProductBOMRegister_T02Entity.WINDOW_NAME;

            PART_CODE_MST = pProductBOMRegister_T02Entity.PART_CODE_MST;
            REVISION_NO = pProductBOMRegister_T02Entity.REVISION_NO;

            PART_TYPE = pProductBOMRegister_T02Entity.PART_TYPE;
            PART_NAME = pProductBOMRegister_T02Entity.PART_NAME;
            PART_CODE = pProductBOMRegister_T02Entity.PART_CODE;
            USE_YN = pProductBOMRegister_T02Entity.USE_YN;


            ERR_NO = pProductBOMRegister_T02Entity.ERR_NO;
            ERR_MSG = pProductBOMRegister_T02Entity.ERR_MSG;
            RTN_KEY = pProductBOMRegister_T02Entity.RTN_KEY;
            RTN_SEQ = pProductBOMRegister_T02Entity.RTN_SEQ;
            RTN_OTHERS = pProductBOMRegister_T02Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ProductBOMRegister_T50Entity
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

        #region 생성자 - ProductBOMRegister_T50Entity()

        public ProductBOMRegister_T50Entity()
        {
        }

        #endregion

        #region 생성자 - ProductBOMRegister_T50Entity(pProductBOMRegister_T50Entity)

        public ProductBOMRegister_T50Entity(ProductBOMRegister_T50Entity pProductBOMRegister_T50Entity)
        {
            CORP_CODE = pProductBOMRegister_T50Entity.CORP_CODE;
            CRUD = pProductBOMRegister_T50Entity.CRUD;
            USER_CODE = pProductBOMRegister_T50Entity.USER_CODE;
            LANGUAGE_TYPE = pProductBOMRegister_T50Entity.LANGUAGE_TYPE;
            WINDOW_NAME = pProductBOMRegister_T50Entity.WINDOW_NAME;

            PART_CODE_MST = pProductBOMRegister_T50Entity.PART_CODE_MST;
            REVISION_NO = pProductBOMRegister_T50Entity.REVISION_NO;

            PART_TYPE = pProductBOMRegister_T50Entity.PART_TYPE;
            PART_NAME = pProductBOMRegister_T50Entity.PART_NAME;
            PART_CODE = pProductBOMRegister_T50Entity.PART_CODE;
            USE_YN = pProductBOMRegister_T50Entity.USE_YN;


            ERR_NO = pProductBOMRegister_T50Entity.ERR_NO;
            ERR_MSG = pProductBOMRegister_T50Entity.ERR_MSG;
            RTN_KEY = pProductBOMRegister_T50Entity.RTN_KEY;
            RTN_SEQ = pProductBOMRegister_T50Entity.RTN_SEQ;
            RTN_OTHERS = pProductBOMRegister_T50Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ProductStockStatus_T02Entity
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

        #region 생성자 - ProductStockStatus_T02Entity()

        public ProductStockStatus_T02Entity()
        {
        }

        #endregion

        #region 생성자 - ProductStockStatus_T02Entity(pProductStockStatus_T02Entity)

        public ProductStockStatus_T02Entity(ProductStockStatus_T02Entity pProductStockStatus_T02Entity)
        {
            CORP_CODE = pProductStockStatus_T02Entity.CORP_CODE;
            CRUD = pProductStockStatus_T02Entity.CRUD;
            USER_CODE = pProductStockStatus_T02Entity.USER_CODE;

            LANGUAGE_TYPE = pProductStockStatus_T02Entity.LANGUAGE_TYPE;


            pProductStockStatus_T02Entity.PART_TYPE = PART_TYPE;
            pProductStockStatus_T02Entity.PART_NAME = PART_NAME;
            pProductStockStatus_T02Entity.PART_CODE = PART_CODE;
            pProductStockStatus_T02Entity.VEND_PART_CODE = PART_CODE;

            ERR_NO = pProductStockStatus_T02Entity.ERR_NO;
            ERR_MSG = pProductStockStatus_T02Entity.ERR_MSG;
            RTN_KEY = pProductStockStatus_T02Entity.RTN_KEY;
            RTN_SEQ = pProductStockStatus_T02Entity.RTN_SEQ;
            RTN_OTHERS = pProductStockStatus_T02Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }
    public class ProductStockStatus_T04Entity
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

        #region 생성자 - ProductStockStatus_T04Entity()

        public ProductStockStatus_T04Entity()
        {
        }

        #endregion

        #region 생성자 - ProductStockStatus_T04Entity(pProductStockStatus_T04Entity)

        public ProductStockStatus_T04Entity(ProductStockStatus_T04Entity pProductStockStatus_T04Entity)
        {
            CORP_CODE = pProductStockStatus_T04Entity.CORP_CODE;
            CRUD = pProductStockStatus_T04Entity.CRUD;
            USER_CODE = pProductStockStatus_T04Entity.USER_CODE;

            LANGUAGE_TYPE = pProductStockStatus_T04Entity.LANGUAGE_TYPE;


            pProductStockStatus_T04Entity.PART_TYPE = PART_TYPE;
            pProductStockStatus_T04Entity.PART_NAME = PART_NAME;
            pProductStockStatus_T04Entity.PART_CODE = PART_CODE;
            pProductStockStatus_T04Entity.VEND_PART_CODE = PART_CODE;

            ERR_NO = pProductStockStatus_T04Entity.ERR_NO;
            ERR_MSG = pProductStockStatus_T04Entity.ERR_MSG;
            RTN_KEY = pProductStockStatus_T04Entity.RTN_KEY;
            RTN_SEQ = pProductStockStatus_T04Entity.RTN_SEQ;
            RTN_OTHERS = pProductStockStatus_T04Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }
    public class ProductOrderRegister_RequestEntity
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

        #region 생성자 - ProductOrderRegister_RequestEntity()
        public ProductOrderRegister_RequestEntity() { }
        #endregion

        #region 생성자 - ProductOrderRegister_RequestEntity(ProductOrderRegister_RequestEntity pProductOrderRegister_RequestEntity)
        public ProductOrderRegister_RequestEntity(ProductOrderRegister_RequestEntity pProductOrderRegister_RequestEntity)
        {
            if (pProductOrderRegister_RequestEntity == null)
                return;

            pProductOrderRegister_RequestEntity.CORP_CODE = CORP_CODE;
            pProductOrderRegister_RequestEntity.USER_CODE = USER_CODE;
            pProductOrderRegister_RequestEntity.CRUD = CRUD;
            pProductOrderRegister_RequestEntity.DATE_FROM = DATE_FROM;
            pProductOrderRegister_RequestEntity.DATE_TO = DATE_TO;
            pProductOrderRegister_RequestEntity.PART_NAME = PART_NAME;
            pProductOrderRegister_RequestEntity.PART_CODE = PART_CODE;
            pProductOrderRegister_RequestEntity.VEND_NAME = VEND_NAME;
            pProductOrderRegister_RequestEntity.VEND_CODE = VEND_CODE;
            pProductOrderRegister_RequestEntity.ORDER_ID = ORDER_ID;
            pProductOrderRegister_RequestEntity.ORDER_DATE = ORDER_DATE;
            pProductOrderRegister_RequestEntity.ORDER_SEQ = ORDER_SEQ;
            pProductOrderRegister_RequestEntity.ORDER_QTY = ORDER_QTY;
            pProductOrderRegister_RequestEntity.REQUEST_DATE = REQUEST_DATE;
            pProductOrderRegister_RequestEntity.REQUEST_LOCATION = REQUEST_LOCATION;
            pProductOrderRegister_RequestEntity.UNIT_CODE = UNIT_CODE;
            pProductOrderRegister_RequestEntity.UNITCODT_CURRENCY_CODE = UNITCODT_CURRENCY_CODE;
            pProductOrderRegister_RequestEntity.UNITCOST = UNITCOST;
            pProductOrderRegister_RequestEntity.COST = COST;
            pProductOrderRegister_RequestEntity.CONTRACT_ID = CONTRACT_ID;
            pProductOrderRegister_RequestEntity.REMARK = REMARK;
            pProductOrderRegister_RequestEntity.USE_YN = USE_YN;
            pProductOrderRegister_RequestEntity.REFERENCE_ID = REFERENCE_ID;
            pProductOrderRegister_RequestEntity.INSPECT_STATUS = INSPECT_STATUS;
            pProductOrderRegister_RequestEntity.VEND_PART_CODE = VEND_PART_CODE;

            pProductOrderRegister_RequestEntity.LANGUAGE_TYPE = LANGUAGE_TYPE;
            pProductOrderRegister_RequestEntity.USER_NAME = USER_NAME;

            ERR_NO = pProductOrderRegister_RequestEntity.ERR_NO;
            ERR_MSG = pProductOrderRegister_RequestEntity.ERR_MSG;
            RTN_KEY = pProductOrderRegister_RequestEntity.RTN_KEY;
            RTN_SEQ = pProductOrderRegister_RequestEntity.RTN_SEQ;
            RTN_OTHERS = pProductOrderRegister_RequestEntity.RTN_OTHERS;
        }
        #endregion
    }


    public class ProductInformationRegister_T04Entity
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
        public String PART_TYPE_DETAIL { get; set; }
        public String PART_EXPIRATION_DATE { get; set; }
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

        #region 생성자 - ProductInformationRegister_T04Entity()

        public ProductInformationRegister_T04Entity()
        {
        }

        #endregion

        #region 생성자 - ProductInformationRegister_T04Entity(pProductInformationRegister_T04Entity)

        public ProductInformationRegister_T04Entity(ProductInformationRegister_T04Entity pProductInformationRegister_T04Entity)
        {
            CORP_CODE = pProductInformationRegister_T04Entity.CORP_CODE;
            CRUD = pProductInformationRegister_T04Entity.CRUD;
            PART_CODE = pProductInformationRegister_T04Entity.PART_CODE;
            PART_REVISION_NO = pProductInformationRegister_T04Entity.PART_REVISION_NO;
            PART_NAME = pProductInformationRegister_T04Entity.PART_NAME;
            PART_TYPE = pProductInformationRegister_T04Entity.PART_TYPE;
            PART_TYPE_DETAIL = pProductInformationRegister_T04Entity.PART_TYPE_DETAIL;
            PART_EXPIRATION_DATE = pProductInformationRegister_T04Entity.PART_EXPIRATION_DATE;
            VEND_PART_CODE = pProductInformationRegister_T04Entity.VEND_PART_CODE;
            PART_UNIT = pProductInformationRegister_T04Entity.PART_UNIT;
            PART_STANDARD = pProductInformationRegister_T04Entity.PART_STANDARD;
            PART_MANUFACTURER = pProductInformationRegister_T04Entity.PART_MANUFACTURER;
            PART_COST = pProductInformationRegister_T04Entity.PART_COST;
            PART_SAFE_STOCK = pProductInformationRegister_T04Entity.PART_SAFE_STOCK;
            PART_START_DATE = pProductInformationRegister_T04Entity.PART_START_DATE;
            PART_END_DATE = pProductInformationRegister_T04Entity.PART_END_DATE;
            SALE_YN = pProductInformationRegister_T04Entity.SALE_YN;
            PURC_YN = pProductInformationRegister_T04Entity.PURC_YN;
            OUTT_YN = pProductInformationRegister_T04Entity.OUTT_YN;
            USE_YN = pProductInformationRegister_T04Entity.USE_YN;
            REMARK = pProductInformationRegister_T04Entity.REMARK;
            PART_PDF_NAME = pProductInformationRegister_T04Entity.PART_PDF_NAME;
            LANGUAGE_TYPE = pProductInformationRegister_T04Entity.LANGUAGE_TYPE;
            VEND_CODE = pProductInformationRegister_T04Entity.VEND_CODE;
            PART_UNITCOST_CURRENCY_CODE = pProductInformationRegister_T04Entity.PART_UNITCOST_CURRENCY_CODE;


            ERR_NO = pProductInformationRegister_T04Entity.ERR_NO;
            ERR_MSG = pProductInformationRegister_T04Entity.ERR_MSG;
            RTN_KEY = pProductInformationRegister_T04Entity.RTN_KEY;
            RTN_SEQ = pProductInformationRegister_T04Entity.RTN_SEQ;
            RTN_OTHERS = pProductInformationRegister_T04Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ProductInRegister_T03Entity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE



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
        public String PART_UNIT { get; set; }
        public String UNITCOST { get; set; }
        public String COST { get; set; }
        public String REMARK { get; set; }
        public String EXPIRATION_DATE { get; set; }

        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        // -----------
        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 키값
        public String RTN_AQ { get; set; } // 리턴 순번 값
        public String RTN_SQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String INOUT_CODE { get; set; }
        public String USE_YN { get; set; }

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - ProductInRegister_T03Entity()

        public ProductInRegister_T03Entity()
        {
        }

        #endregion

        #region 생성자 - ProductInRegister_T03Entity(ProductInRegister_T03Entity pProductInRegister_T03Entity)

        public ProductInRegister_T03Entity(ProductInRegister_T03Entity pProductInRegister_T03Entity)
        {
            CORP_CODE = pProductInRegister_T03Entity.CORP_CODE;
            CRUD = pProductInRegister_T03Entity.CRUD;
            USER_CODE = pProductInRegister_T03Entity.USER_CODE;


            ERR_NO = pProductInRegister_T03Entity.ERR_NO;
            ERR_MSG = pProductInRegister_T03Entity.ERR_MSG;
            RTN_KEY = pProductInRegister_T03Entity.RTN_KEY;
            RTN_SEQ = pProductInRegister_T03Entity.RTN_SEQ;
            RTN_AQ = pProductInRegister_T03Entity.RTN_AQ;
            RTN_SQ = pProductInRegister_T03Entity.RTN_SQ;
            RTN_OTHERS = pProductInRegister_T03Entity.RTN_OTHERS;
            LANGUAGE_TYPE = pProductInRegister_T03Entity.LANGUAGE_TYPE;

            INOUT_ID = pProductInRegister_T03Entity.INOUT_ID;
            INOUT_DATE = pProductInRegister_T03Entity.INOUT_DATE;
            INOUT_SEQ = pProductInRegister_T03Entity.INOUT_SEQ;
            INOUT_TYPE = pProductInRegister_T03Entity.INOUT_TYPE;
            REFERENCE_ID = pProductInRegister_T03Entity.REFERENCE_ID;
            PART_CODE = pProductInRegister_T03Entity.PART_CODE;
            PART_NAME = pProductInRegister_T03Entity.PART_NAME;
            VEND_CODE = pProductInRegister_T03Entity.VEND_CODE;
            VEND_NAME = pProductInRegister_T03Entity.VEND_NAME;
            INOUT_QTY = pProductInRegister_T03Entity.INOUT_QTY;
            PART_UNIT = pProductInRegister_T03Entity.PART_UNIT;
            UNITCOST = pProductInRegister_T03Entity.UNITCOST;
            COST = pProductInRegister_T03Entity.COST;
            REMARK = pProductInRegister_T03Entity.REMARK;
            EXPIRATION_DATE = pProductInRegister_T03Entity.EXPIRATION_DATE;
            INOUT_CODE = pProductInRegister_T03Entity.INOUT_CODE;
            USE_YN = pProductInRegister_T03Entity.USE_YN;
            DATE_FROM = pProductInRegister_T03Entity.DATE_FROM;
            DATE_TO = pProductInRegister_T03Entity.DATE_TO;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ProductOutRegister_T04Entity
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
        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - ProductOutRegister_T04Entity()

        public ProductOutRegister_T04Entity()
        {
        }

        #endregion

        #region 생성자 - ProductOutRegister_T04Entity(ProductOutRegister_T04Entity pMaterialInRegisterEntity)

        public ProductOutRegister_T04Entity(ProductOutRegister_T04Entity pProductOutRegister_T04Entity)
        {
            CORP_CODE = pProductOutRegister_T04Entity.CORP_CODE;
            CRUD = pProductOutRegister_T04Entity.CRUD;
            USER_CODE = pProductOutRegister_T04Entity.USER_CODE;
            LANGUAGE_TYPE = pProductOutRegister_T04Entity.LANGUAGE_TYPE;

            ERR_NO = pProductOutRegister_T04Entity.ERR_NO;
            ERR_MSG = pProductOutRegister_T04Entity.ERR_MSG;
            RTN_KEY = pProductOutRegister_T04Entity.RTN_KEY;
            RTN_SEQ = pProductOutRegister_T04Entity.RTN_SEQ;
            RTN_OTHERS = pProductOutRegister_T04Entity.RTN_OTHERS;

            INOUT_ID = pProductOutRegister_T04Entity.INOUT_ID;
            INOUT_DATE = pProductOutRegister_T04Entity.INOUT_DATE;
            INOUT_SEQ = pProductOutRegister_T04Entity.INOUT_SEQ;
            INOUT_TYPE = pProductOutRegister_T04Entity.INOUT_TYPE;
            REFERENCE_ID = pProductOutRegister_T04Entity.REFERENCE_ID;
            PART_CODE = pProductOutRegister_T04Entity.PART_CODE;
            PART_NAME = pProductOutRegister_T04Entity.PART_NAME;
            VEND_CODE = pProductOutRegister_T04Entity.VEND_CODE;
            VEND_NAME = pProductOutRegister_T04Entity.VEND_NAME;
            INOUT_QTY = pProductOutRegister_T04Entity.INOUT_QTY;
            UNITCOST_CURRENCY_CODE = pProductOutRegister_T04Entity.UNITCOST_CURRENCY_CODE;
            UNITCOST = pProductOutRegister_T04Entity.UNITCOST;
            COST = pProductOutRegister_T04Entity.COST;
            REMARK = pProductOutRegister_T04Entity.REMARK;
            INOUT_CODE = pProductOutRegister_T04Entity.INOUT_CODE;
            USE_YN = pProductOutRegister_T04Entity.USE_YN;
            DATE_FROM = pProductOutRegister_T04Entity.DATE_FROM;
            DATE_TO = pProductOutRegister_T04Entity.DATE_TO;
            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ProductRecepiStatus_T01Entity
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
        public string PRODUCTION_ORDER_ID { get; set; }
        public String READING_TYPE { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - ProductRecepiStatus_T01Entity()

        public ProductRecepiStatus_T01Entity()
        {
        }

        #endregion

        #region 생성자 - ProductRecepiStatus_T01Entity(ProductRecepiStatus_T01Entity)

        public ProductRecepiStatus_T01Entity(ProductRecepiStatus_T01Entity pProductRecepiStatus_T01Entity)
        {
            CORP_CODE = pProductRecepiStatus_T01Entity.CORP_CODE;
            CRUD = pProductRecepiStatus_T01Entity.CRUD;
            USER_CODE = pProductRecepiStatus_T01Entity.USER_CODE;

            LANGUAGE_TYPE = pProductRecepiStatus_T01Entity.LANGUAGE_TYPE;


            pProductRecepiStatus_T01Entity.PART_TYPE = PART_TYPE;
            pProductRecepiStatus_T01Entity.PART_NAME = PART_NAME;
            pProductRecepiStatus_T01Entity.PART_CODE = PART_CODE;

            pProductRecepiStatus_T01Entity.USER_ACCOUNT = USER_ACCOUNT;
            pProductRecepiStatus_T01Entity.DATE_FROM = DATE_FROM;
            pProductRecepiStatus_T01Entity.DATE_TO = DATE_TO;
            pProductRecepiStatus_T01Entity.PRODUCTION_ORDER_ID = PRODUCTION_ORDER_ID;
            pProductRecepiStatus_T01Entity.READING_TYPE = READING_TYPE;

            ERR_NO = pProductRecepiStatus_T01Entity.ERR_NO;
            ERR_MSG = pProductRecepiStatus_T01Entity.ERR_MSG;
            RTN_KEY = pProductRecepiStatus_T01Entity.RTN_KEY;
            RTN_SEQ = pProductRecepiStatus_T01Entity.RTN_SEQ;
            RTN_OTHERS = pProductRecepiStatus_T01Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력

        }

        #endregion

    }

}

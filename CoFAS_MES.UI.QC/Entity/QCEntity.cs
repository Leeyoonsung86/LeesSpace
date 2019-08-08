using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoFAS_MES.UI.QC.Entity
{
    public class ProcessTempManagementEntity
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

        #endregion

        #region 생성자 - ProcessTempManagementEntity()

        public ProcessTempManagementEntity()
        {
        }

        #endregion

        #region 생성자 - ProcessTempManagementEntity(pProcessTempManagementEntity)

        public ProcessTempManagementEntity(ProcessTempManagementEntity pProcessTempManagementEntity)
        {
            CORP_CODE = pProcessTempManagementEntity.CORP_CODE;
            CRUD = pProcessTempManagementEntity.CRUD;
            USER_CODE = pProcessTempManagementEntity.USER_CODE;
            LANGUAGE_TYPE = pProcessTempManagementEntity.LANGUAGE_TYPE;
            pProcessTempManagementEntity.WINDOW_NAME = WINDOW_NAME;

            pProcessTempManagementEntity.DATE_FROM = DATE_FROM;
            pProcessTempManagementEntity.DATE_TO = DATE_TO;
            pProcessTempManagementEntity.PROCESS_CODE = PROCESS_CODE;

            ERR_NO = pProcessTempManagementEntity.ERR_NO;
            ERR_MSG = pProcessTempManagementEntity.ERR_MSG;
            RTN_KEY = pProcessTempManagementEntity.RTN_KEY;
            RTN_SEQ = pProcessTempManagementEntity.RTN_SEQ;
            RTN_OTHERS = pProcessTempManagementEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }
    public class RawMaterialInspectRegisterEntity
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
        public String DATE_FROM             { get; set; }
        public String DATE_TO           { get; set; }
        public String PART_CODE             { get; set; }
        public String PART_NAME             { get; set; }
        public String INSPECT_STATUS             { get; set; }
        public String INSPECT_ID            { get; set; }
        public String INSPECT__DATE             { get; set; }
        public String INSPECT_SEQ       { get; set; }
        public String VEND_PART_CODE            { get; set; }
        public String PART_TYPE          { get; set; }
        public String REFERENCE_ID           { get; set; }
        public String MAKE_VEND             { get; set; }
        public String MAKE_VEND_NAME            { get; set; }
        public String VEND_CODE             { get; set; }
        public String VEND_NAME             { get; set; }
        public String REQUEST_DEPT          { get; set; }
        public String CODE_NAME             { get; set; }
        public String INOUT_DATE            { get; set; }
        public String INOUT_QTY             { get; set; }
        public String PACKING_REMARK            { get; set; }
        public String SAMPLE_DATE           { get; set; }
        public String SAMPLE_LOCATION           { get; set; }
        public String SAMPLE_USER           { get; set; }
        public String SAMPLE_METHOD             { get; set; }
        public String SAMPLE_QTY             { get; set; }
        public String MAKE_NO            { get; set; }
        public String STANDARD          { get; set; }
        public String REQUEST_DATE           { get; set; }
        public String REQUEST_USER           { get; set; }
        public String END_DATE          { get; set; }
        public String TOTAL_RESULT          { get; set; }
        public String TOTAL_DATE            { get; set; }
        public String TOTAL_USER            { get; set; }
        public String COMPLETE_YN           { get; set; }
        public String REMARK            { get; set; }
        public String USER_YN           { get; set; }

        public int dtListCnt { get; set; }

        #endregion
        
        #region 생성자 - RawMaterialInspectRegisterEntity()

        public RawMaterialInspectRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - RawMaterialInspectRegisterEntity(pRawMaterialInspectRegisterEntity)

        public RawMaterialInspectRegisterEntity(RawMaterialInspectRegisterEntity pRawMaterialInspectRegisterEntity)
        {
            CORP_CODE = pRawMaterialInspectRegisterEntity.CORP_CODE;
            CRUD = pRawMaterialInspectRegisterEntity.CRUD;
            USER_CODE = pRawMaterialInspectRegisterEntity.USER_CODE;

                    pRawMaterialInspectRegisterEntity.WINDOW_NAME = WINDOW_NAME;

                DATE_FROM      =pRawMaterialInspectRegisterEntity.DATE_FROM      ;
                DATE_TO        =pRawMaterialInspectRegisterEntity.DATE_TO        ;
                PART_CODE      =pRawMaterialInspectRegisterEntity.PART_CODE      ;
                PART_NAME      =pRawMaterialInspectRegisterEntity.PART_NAME      ;
                INSPECT_STATUS =pRawMaterialInspectRegisterEntity.INSPECT_STATUS ;
                INSPECT_ID     =pRawMaterialInspectRegisterEntity.INSPECT_ID     ;
                INSPECT__DATE  =pRawMaterialInspectRegisterEntity.INSPECT__DATE  ;
                INSPECT_SEQ    =pRawMaterialInspectRegisterEntity.INSPECT_SEQ    ;
                VEND_PART_CODE =pRawMaterialInspectRegisterEntity.VEND_PART_CODE ;
                PART_TYPE      =pRawMaterialInspectRegisterEntity.PART_TYPE      ;
                REFERENCE_ID   =pRawMaterialInspectRegisterEntity.REFERENCE_ID   ;
                MAKE_VEND      =pRawMaterialInspectRegisterEntity.MAKE_VEND      ;
                MAKE_VEND_NAME =pRawMaterialInspectRegisterEntity.MAKE_VEND_NAME ;
                VEND_CODE      =pRawMaterialInspectRegisterEntity.VEND_CODE      ;
                VEND_NAME      =pRawMaterialInspectRegisterEntity.VEND_NAME      ;
                REQUEST_DEPT   =pRawMaterialInspectRegisterEntity.REQUEST_DEPT   ;
                CODE_NAME      =pRawMaterialInspectRegisterEntity.CODE_NAME      ;
                INOUT_DATE     =pRawMaterialInspectRegisterEntity.INOUT_DATE     ;
                INOUT_QTY      =pRawMaterialInspectRegisterEntity.INOUT_QTY      ;
                PACKING_REMARK =pRawMaterialInspectRegisterEntity.PACKING_REMARK ;
                SAMPLE_DATE    =pRawMaterialInspectRegisterEntity.SAMPLE_DATE    ;
                SAMPLE_LOCATION=pRawMaterialInspectRegisterEntity.SAMPLE_LOCATION;
                SAMPLE_USER    =pRawMaterialInspectRegisterEntity.SAMPLE_USER    ;
                SAMPLE_METHOD  =pRawMaterialInspectRegisterEntity.SAMPLE_METHOD  ;
                SAMPLE_QTY     =pRawMaterialInspectRegisterEntity.SAMPLE_QTY     ;
                MAKE_NO        =pRawMaterialInspectRegisterEntity.MAKE_NO        ;
                STANDARD       =pRawMaterialInspectRegisterEntity.STANDARD       ;
                REQUEST_DATE   =pRawMaterialInspectRegisterEntity.REQUEST_DATE   ;
                REQUEST_USER   =pRawMaterialInspectRegisterEntity.REQUEST_USER   ;
                END_DATE       =pRawMaterialInspectRegisterEntity.END_DATE       ;
                TOTAL_RESULT   =pRawMaterialInspectRegisterEntity.TOTAL_RESULT   ;
                TOTAL_DATE     =pRawMaterialInspectRegisterEntity.TOTAL_DATE     ;
                TOTAL_USER     =pRawMaterialInspectRegisterEntity.TOTAL_USER     ;
                COMPLETE_YN    =pRawMaterialInspectRegisterEntity.COMPLETE_YN    ;
                REMARK         =pRawMaterialInspectRegisterEntity.REMARK         ;
                USER_YN        =pRawMaterialInspectRegisterEntity.USER_YN        ;
                dtListCnt = pRawMaterialInspectRegisterEntity.dtListCnt;
        //pRawMaterialInspectRegisterEntity.PROCESS_CODE = PROCESS_CODE;

            ERR_NO = pRawMaterialInspectRegisterEntity.ERR_NO;
            ERR_MSG = pRawMaterialInspectRegisterEntity.ERR_MSG;
            RTN_KEY = pRawMaterialInspectRegisterEntity.RTN_KEY;
            RTN_SEQ = pRawMaterialInspectRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pRawMaterialInspectRegisterEntity.RTN_OTHERS;

            LANGUAGE_TYPE   = pRawMaterialInspectRegisterEntity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class RawMaterialInspectRegisterT01Entity
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
        public String USER_YN { get; set; }
        public String PART_LOT_ID { get; set; }
        public String WEIGHT { get; set; }
        public String PART_WEIGHT_ID { get; set; }
        public int dtListCnt { get; set; }

        #endregion

        #region 생성자 - RawMaterialInspectRegisterEntity_T01()

        public RawMaterialInspectRegisterT01Entity()
        {
        }

        #endregion

        #region 생성자 - RawMaterialInspectRegisterT01Entity(pRawMaterialInspectRegisterT01Entity)

        public RawMaterialInspectRegisterT01Entity(RawMaterialInspectRegisterT01Entity pRawMaterialInspectRegisterT01Entity)
        {
            CORP_CODE = pRawMaterialInspectRegisterT01Entity.CORP_CODE;
            CRUD = pRawMaterialInspectRegisterT01Entity.CRUD;
            USER_CODE = pRawMaterialInspectRegisterT01Entity.USER_CODE;

            pRawMaterialInspectRegisterT01Entity.WINDOW_NAME = WINDOW_NAME;

            DATE_FROM = pRawMaterialInspectRegisterT01Entity.DATE_FROM;
            DATE_TO = pRawMaterialInspectRegisterT01Entity.DATE_TO;
            PART_CODE = pRawMaterialInspectRegisterT01Entity.PART_CODE;
            PART_NAME = pRawMaterialInspectRegisterT01Entity.PART_NAME;
            INSPECT_STATUS = pRawMaterialInspectRegisterT01Entity.INSPECT_STATUS;
            INSPECT_ID = pRawMaterialInspectRegisterT01Entity.INSPECT_ID;
            INSPECT__DATE = pRawMaterialInspectRegisterT01Entity.INSPECT__DATE;
            INSPECT_SEQ = pRawMaterialInspectRegisterT01Entity.INSPECT_SEQ;
            VEND_PART_CODE = pRawMaterialInspectRegisterT01Entity.VEND_PART_CODE;
            PART_TYPE = pRawMaterialInspectRegisterT01Entity.PART_TYPE;
            REFERENCE_ID = pRawMaterialInspectRegisterT01Entity.REFERENCE_ID;
            MAKE_VEND = pRawMaterialInspectRegisterT01Entity.MAKE_VEND;
            MAKE_VEND_NAME = pRawMaterialInspectRegisterT01Entity.MAKE_VEND_NAME;
            VEND_CODE = pRawMaterialInspectRegisterT01Entity.VEND_CODE;
            VEND_NAME = pRawMaterialInspectRegisterT01Entity.VEND_NAME;
            REQUEST_DEPT = pRawMaterialInspectRegisterT01Entity.REQUEST_DEPT;
            CODE_NAME = pRawMaterialInspectRegisterT01Entity.CODE_NAME;
            INOUT_DATE = pRawMaterialInspectRegisterT01Entity.INOUT_DATE;
            INOUT_QTY = pRawMaterialInspectRegisterT01Entity.INOUT_QTY;
            PACKING_REMARK = pRawMaterialInspectRegisterT01Entity.PACKING_REMARK;
            SAMPLE_DATE = pRawMaterialInspectRegisterT01Entity.SAMPLE_DATE;
            SAMPLE_LOCATION = pRawMaterialInspectRegisterT01Entity.SAMPLE_LOCATION;
            SAMPLE_USER = pRawMaterialInspectRegisterT01Entity.SAMPLE_USER;
            SAMPLE_METHOD = pRawMaterialInspectRegisterT01Entity.SAMPLE_METHOD;
            SAMPLE_QTY = pRawMaterialInspectRegisterT01Entity.SAMPLE_QTY;
            MAKE_NO = pRawMaterialInspectRegisterT01Entity.MAKE_NO;
            STANDARD = pRawMaterialInspectRegisterT01Entity.STANDARD;
            REQUEST_DATE = pRawMaterialInspectRegisterT01Entity.REQUEST_DATE;
            REQUEST_USER = pRawMaterialInspectRegisterT01Entity.REQUEST_USER;
            END_DATE = pRawMaterialInspectRegisterT01Entity.END_DATE;
            TOTAL_RESULT = pRawMaterialInspectRegisterT01Entity.TOTAL_RESULT;
            TOTAL_DATE = pRawMaterialInspectRegisterT01Entity.TOTAL_DATE;
            TOTAL_USER = pRawMaterialInspectRegisterT01Entity.TOTAL_USER;
            COMPLETE_YN = pRawMaterialInspectRegisterT01Entity.COMPLETE_YN;
            REMARK = pRawMaterialInspectRegisterT01Entity.REMARK;
            USER_YN = pRawMaterialInspectRegisterT01Entity.USER_YN;
            dtListCnt = pRawMaterialInspectRegisterT01Entity.dtListCnt;
            //pRawMaterialInspectRegisterEntity.PROCESS_CODE = PROCESS_CODE;
            PART_LOT_ID = pRawMaterialInspectRegisterT01Entity.PART_LOT_ID;
            WEIGHT = pRawMaterialInspectRegisterT01Entity.WEIGHT;
            PART_WEIGHT_ID = pRawMaterialInspectRegisterT01Entity.PART_WEIGHT_ID;

            ERR_NO = pRawMaterialInspectRegisterT01Entity.ERR_NO;
            ERR_MSG = pRawMaterialInspectRegisterT01Entity.ERR_MSG;
            RTN_KEY = pRawMaterialInspectRegisterT01Entity.RTN_KEY;
            RTN_SEQ = pRawMaterialInspectRegisterT01Entity.RTN_SEQ;
            RTN_OTHERS = pRawMaterialInspectRegisterT01Entity.RTN_OTHERS;

            LANGUAGE_TYPE = pRawMaterialInspectRegisterT01Entity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ucInspectPartListPopupEntity
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

        #region 생성자 - ucInspectPartListPopupEntity()

        public ucInspectPartListPopupEntity()
        {
        }

        #endregion

        #region 생성자 - ucInspectPartListPopupEntity(ucInspectPartListPopupEntity pucInspectPartListPopupEntityEntity)

        public ucInspectPartListPopupEntity(ucInspectPartListPopupEntity pucInspectPartListPopupEntityEntity)
        {
            CORP_CODE = pucInspectPartListPopupEntityEntity.CORP_CODE;
            CRUD = pucInspectPartListPopupEntityEntity.CRUD;
            USER_CODE = pucInspectPartListPopupEntityEntity.USER_CODE;
            LANGUAGE_TYPE = pucInspectPartListPopupEntityEntity.LANGUAGE_TYPE;
            WINDOW_NAME = pucInspectPartListPopupEntityEntity.WINDOW_NAME;

            PART_CODE = pucInspectPartListPopupEntityEntity.PART_CODE;
            PART_NAME = pucInspectPartListPopupEntityEntity.PART_NAME;
            PART_REVISION_NO = pucInspectPartListPopupEntityEntity.PART_REVISION_NO;
            VEND_PART_CODE = pucInspectPartListPopupEntityEntity.VEND_PART_CODE;

            PART_HIGH = pucInspectPartListPopupEntityEntity.PART_HIGH;
            PART_MIDDLE = pucInspectPartListPopupEntityEntity.PART_MIDDLE;
            PART_LOW = pucInspectPartListPopupEntityEntity.PART_LOW;

            ERR_NO = pucInspectPartListPopupEntityEntity.ERR_NO;
            ERR_MSG = pucInspectPartListPopupEntityEntity.ERR_MSG;
            RTN_KEY = pucInspectPartListPopupEntityEntity.RTN_KEY;
            RTN_SEQ = pucInspectPartListPopupEntityEntity.RTN_SEQ;
            RTN_AQ = pucInspectPartListPopupEntityEntity.RTN_AQ;
            RTN_SQ = pucInspectPartListPopupEntityEntity.RTN_SQ;
            RTN_OTHERS = pucInspectPartListPopupEntityEntity.RTN_OTHERS;
            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class MaterialInspectRegisterEntity
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
        public String USER_YN { get; set; }
        public String FILE_NAME { get; set; }

        public int dtListCnt { get; set; }

        #endregion

        #region 생성자 - MaterialInspectRegisterEntity()

        public MaterialInspectRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - MaterialInspectRegisterEntity(pMaterialInspectRegisterEntity)

        public MaterialInspectRegisterEntity(MaterialInspectRegisterEntity pMaterialInspectRegisterEntity)
        {
            CORP_CODE = pMaterialInspectRegisterEntity.CORP_CODE;
            CRUD = pMaterialInspectRegisterEntity.CRUD;
            USER_CODE = pMaterialInspectRegisterEntity.USER_CODE;

            pMaterialInspectRegisterEntity.WINDOW_NAME = WINDOW_NAME;

            DATE_FROM = pMaterialInspectRegisterEntity.DATE_FROM;
            DATE_TO = pMaterialInspectRegisterEntity.DATE_TO;
            PART_CODE = pMaterialInspectRegisterEntity.PART_CODE;
            PART_NAME = pMaterialInspectRegisterEntity.PART_NAME;
            INSPECT_STATUS = pMaterialInspectRegisterEntity.INSPECT_STATUS;
            INSPECT_ID = pMaterialInspectRegisterEntity.INSPECT_ID;
            INSPECT__DATE = pMaterialInspectRegisterEntity.INSPECT__DATE;
            INSPECT_SEQ = pMaterialInspectRegisterEntity.INSPECT_SEQ;
            VEND_PART_CODE = pMaterialInspectRegisterEntity.VEND_PART_CODE;
            PART_TYPE = pMaterialInspectRegisterEntity.PART_TYPE;
            REFERENCE_ID = pMaterialInspectRegisterEntity.REFERENCE_ID;
            MAKE_VEND = pMaterialInspectRegisterEntity.MAKE_VEND;
            MAKE_VEND_NAME = pMaterialInspectRegisterEntity.MAKE_VEND_NAME;
            VEND_CODE = pMaterialInspectRegisterEntity.VEND_CODE;
            VEND_NAME = pMaterialInspectRegisterEntity.VEND_NAME;
            REQUEST_DEPT = pMaterialInspectRegisterEntity.REQUEST_DEPT;
            CODE_NAME = pMaterialInspectRegisterEntity.CODE_NAME;
            INOUT_DATE = pMaterialInspectRegisterEntity.INOUT_DATE;
            INOUT_QTY = pMaterialInspectRegisterEntity.INOUT_QTY;
            PACKING_REMARK = pMaterialInspectRegisterEntity.PACKING_REMARK;
            SAMPLE_DATE = pMaterialInspectRegisterEntity.SAMPLE_DATE;
            SAMPLE_LOCATION = pMaterialInspectRegisterEntity.SAMPLE_LOCATION;
            SAMPLE_USER = pMaterialInspectRegisterEntity.SAMPLE_USER;
            SAMPLE_METHOD = pMaterialInspectRegisterEntity.SAMPLE_METHOD;
            SAMPLE_QTY = pMaterialInspectRegisterEntity.SAMPLE_QTY;
            MAKE_NO = pMaterialInspectRegisterEntity.MAKE_NO;
            STANDARD = pMaterialInspectRegisterEntity.STANDARD;
            REQUEST_DATE = pMaterialInspectRegisterEntity.REQUEST_DATE;
            REQUEST_USER = pMaterialInspectRegisterEntity.REQUEST_USER;
            END_DATE = pMaterialInspectRegisterEntity.END_DATE;
            TOTAL_RESULT = pMaterialInspectRegisterEntity.TOTAL_RESULT;
            TOTAL_DATE = pMaterialInspectRegisterEntity.TOTAL_DATE;
            TOTAL_USER = pMaterialInspectRegisterEntity.TOTAL_USER;
            COMPLETE_YN = pMaterialInspectRegisterEntity.COMPLETE_YN;
            REMARK = pMaterialInspectRegisterEntity.REMARK;
            USER_YN = pMaterialInspectRegisterEntity.USER_YN;
            FILE_NAME = pMaterialInspectRegisterEntity.FILE_NAME;
            dtListCnt = pMaterialInspectRegisterEntity.dtListCnt;
            //pMaterialInspectRegisterEntity.PROCESS_CODE = PROCESS_CODE;

            ERR_NO = pMaterialInspectRegisterEntity.ERR_NO;
            ERR_MSG = pMaterialInspectRegisterEntity.ERR_MSG;
            RTN_KEY = pMaterialInspectRegisterEntity.RTN_KEY;
            RTN_SEQ = pMaterialInspectRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pMaterialInspectRegisterEntity.RTN_OTHERS;

            LANGUAGE_TYPE = pMaterialInspectRegisterEntity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }
    public class SemiProductInspectRegisterEntity
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
        public String USER_YN { get; set; }

        public int dtListCnt { get; set; }

        #endregion

        #region 생성자 - SemiProductInspectRegisterEntity()

        public SemiProductInspectRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - SemiProductInspectRegisterEntity(pSemiProductInspectRegisterEntity)

        public SemiProductInspectRegisterEntity(SemiProductInspectRegisterEntity pSemiProductInspectRegisterEntity)
        {
            CORP_CODE = pSemiProductInspectRegisterEntity.CORP_CODE;
            CRUD = pSemiProductInspectRegisterEntity.CRUD;
            USER_CODE = pSemiProductInspectRegisterEntity.USER_CODE;

            pSemiProductInspectRegisterEntity.WINDOW_NAME = WINDOW_NAME;

            DATE_FROM = pSemiProductInspectRegisterEntity.DATE_FROM;
            DATE_TO = pSemiProductInspectRegisterEntity.DATE_TO;
            PART_CODE = pSemiProductInspectRegisterEntity.PART_CODE;
            PART_NAME = pSemiProductInspectRegisterEntity.PART_NAME;
            INSPECT_STATUS = pSemiProductInspectRegisterEntity.INSPECT_STATUS;
            INSPECT_ID = pSemiProductInspectRegisterEntity.INSPECT_ID;
            INSPECT__DATE = pSemiProductInspectRegisterEntity.INSPECT__DATE;
            INSPECT_SEQ = pSemiProductInspectRegisterEntity.INSPECT_SEQ;
            VEND_PART_CODE = pSemiProductInspectRegisterEntity.VEND_PART_CODE;
            PART_TYPE = pSemiProductInspectRegisterEntity.PART_TYPE;
            REFERENCE_ID = pSemiProductInspectRegisterEntity.REFERENCE_ID;
            MAKE_VEND = pSemiProductInspectRegisterEntity.MAKE_VEND;
            MAKE_VEND_NAME = pSemiProductInspectRegisterEntity.MAKE_VEND_NAME;
            VEND_CODE = pSemiProductInspectRegisterEntity.VEND_CODE;
            VEND_NAME = pSemiProductInspectRegisterEntity.VEND_NAME;
            REQUEST_DEPT = pSemiProductInspectRegisterEntity.REQUEST_DEPT;
            CODE_NAME = pSemiProductInspectRegisterEntity.CODE_NAME;
            INOUT_DATE = pSemiProductInspectRegisterEntity.INOUT_DATE;
            INOUT_QTY = pSemiProductInspectRegisterEntity.INOUT_QTY;
            PACKING_REMARK = pSemiProductInspectRegisterEntity.PACKING_REMARK;
            SAMPLE_DATE = pSemiProductInspectRegisterEntity.SAMPLE_DATE;
            SAMPLE_LOCATION = pSemiProductInspectRegisterEntity.SAMPLE_LOCATION;
            SAMPLE_USER = pSemiProductInspectRegisterEntity.SAMPLE_USER;
            SAMPLE_METHOD = pSemiProductInspectRegisterEntity.SAMPLE_METHOD;
            SAMPLE_QTY = pSemiProductInspectRegisterEntity.SAMPLE_QTY;
            MAKE_NO = pSemiProductInspectRegisterEntity.MAKE_NO;
            STANDARD = pSemiProductInspectRegisterEntity.STANDARD;
            REQUEST_DATE = pSemiProductInspectRegisterEntity.REQUEST_DATE;
            REQUEST_USER = pSemiProductInspectRegisterEntity.REQUEST_USER;
            END_DATE = pSemiProductInspectRegisterEntity.END_DATE;
            TOTAL_RESULT = pSemiProductInspectRegisterEntity.TOTAL_RESULT;
            TOTAL_DATE = pSemiProductInspectRegisterEntity.TOTAL_DATE;
            TOTAL_USER = pSemiProductInspectRegisterEntity.TOTAL_USER;
            COMPLETE_YN = pSemiProductInspectRegisterEntity.COMPLETE_YN;
            REMARK = pSemiProductInspectRegisterEntity.REMARK;
            USER_YN = pSemiProductInspectRegisterEntity.USER_YN;
            dtListCnt = pSemiProductInspectRegisterEntity.dtListCnt;
            //pSemiProductInspectRegisterEntity.PROCESS_CODE = PROCESS_CODE;

            ERR_NO = pSemiProductInspectRegisterEntity.ERR_NO;
            ERR_MSG = pSemiProductInspectRegisterEntity.ERR_MSG;
            RTN_KEY = pSemiProductInspectRegisterEntity.RTN_KEY;
            RTN_SEQ = pSemiProductInspectRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pSemiProductInspectRegisterEntity.RTN_OTHERS;

            LANGUAGE_TYPE = pSemiProductInspectRegisterEntity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ProductInspectRegisterEntity
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
        public String USER_YN { get; set; }

        public int dtListCnt { get; set; }

        #endregion

        #region 생성자 - ProductInspectRegisterEntity()

        public ProductInspectRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - ProductInspectRegisterEntity(pProductInspectRegisterEntity)

        public ProductInspectRegisterEntity(ProductInspectRegisterEntity pProductInspectRegisterEntity)
        {
            CORP_CODE = pProductInspectRegisterEntity.CORP_CODE;
            CRUD = pProductInspectRegisterEntity.CRUD;
            USER_CODE = pProductInspectRegisterEntity.USER_CODE;

            pProductInspectRegisterEntity.WINDOW_NAME = WINDOW_NAME;

            DATE_FROM = pProductInspectRegisterEntity.DATE_FROM;
            DATE_TO = pProductInspectRegisterEntity.DATE_TO;
            PART_CODE = pProductInspectRegisterEntity.PART_CODE;
            PART_NAME = pProductInspectRegisterEntity.PART_NAME;
            INSPECT_STATUS = pProductInspectRegisterEntity.INSPECT_STATUS;
            INSPECT_ID = pProductInspectRegisterEntity.INSPECT_ID;
            INSPECT__DATE = pProductInspectRegisterEntity.INSPECT__DATE;
            INSPECT_SEQ = pProductInspectRegisterEntity.INSPECT_SEQ;
            VEND_PART_CODE = pProductInspectRegisterEntity.VEND_PART_CODE;
            PART_TYPE = pProductInspectRegisterEntity.PART_TYPE;
            REFERENCE_ID = pProductInspectRegisterEntity.REFERENCE_ID;
            MAKE_VEND = pProductInspectRegisterEntity.MAKE_VEND;
            MAKE_VEND_NAME = pProductInspectRegisterEntity.MAKE_VEND_NAME;
            VEND_CODE = pProductInspectRegisterEntity.VEND_CODE;
            VEND_NAME = pProductInspectRegisterEntity.VEND_NAME;
            REQUEST_DEPT = pProductInspectRegisterEntity.REQUEST_DEPT;
            CODE_NAME = pProductInspectRegisterEntity.CODE_NAME;
            INOUT_DATE = pProductInspectRegisterEntity.INOUT_DATE;
            INOUT_QTY = pProductInspectRegisterEntity.INOUT_QTY;
            PACKING_REMARK = pProductInspectRegisterEntity.PACKING_REMARK;
            SAMPLE_DATE = pProductInspectRegisterEntity.SAMPLE_DATE;
            SAMPLE_LOCATION = pProductInspectRegisterEntity.SAMPLE_LOCATION;
            SAMPLE_USER = pProductInspectRegisterEntity.SAMPLE_USER;
            SAMPLE_METHOD = pProductInspectRegisterEntity.SAMPLE_METHOD;
            SAMPLE_QTY = pProductInspectRegisterEntity.SAMPLE_QTY;
            MAKE_NO = pProductInspectRegisterEntity.MAKE_NO;
            STANDARD = pProductInspectRegisterEntity.STANDARD;
            REQUEST_DATE = pProductInspectRegisterEntity.REQUEST_DATE;
            REQUEST_USER = pProductInspectRegisterEntity.REQUEST_USER;
            END_DATE = pProductInspectRegisterEntity.END_DATE;
            TOTAL_RESULT = pProductInspectRegisterEntity.TOTAL_RESULT;
            TOTAL_DATE = pProductInspectRegisterEntity.TOTAL_DATE;
            TOTAL_USER = pProductInspectRegisterEntity.TOTAL_USER;
            COMPLETE_YN = pProductInspectRegisterEntity.COMPLETE_YN;
            REMARK = pProductInspectRegisterEntity.REMARK;
            USER_YN = pProductInspectRegisterEntity.USER_YN;
            dtListCnt = pProductInspectRegisterEntity.dtListCnt;
            //pProductInspectRegisterEntity.PROCESS_CODE = PROCESS_CODE;

            ERR_NO = pProductInspectRegisterEntity.ERR_NO;
            ERR_MSG = pProductInspectRegisterEntity.ERR_MSG;
            RTN_KEY = pProductInspectRegisterEntity.RTN_KEY;
            RTN_SEQ = pProductInspectRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pProductInspectRegisterEntity.RTN_OTHERS;

            LANGUAGE_TYPE = pProductInspectRegisterEntity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }
    public class InspectFinalApprovalRegisterEntity
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
        public String TOTAL_WRITER { get; set; }
        public String TOTAL_CHECKER { get; set; }
        public String TOTAL_APPROVER { get; set; }
        public String TOTAL_APPROVER_SIGN { get; set; }
        public String APPROVAL_YN { get; set; }
        public String COMPLETE_YN { get; set; }
        public String REMARK { get; set; }
        public String FILE_NAME { get; set; }
        public String USER_YN { get; set; }

        public int dtListCnt { get; set; }

        #endregion

        #region 생성자 - InspectFinalApprovalRegisterEntity()

        public InspectFinalApprovalRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - InspectFinalApprovalRegisterEntity(pInspectFinalApprovalRegisterEntity)

        public InspectFinalApprovalRegisterEntity(InspectFinalApprovalRegisterEntity pInspectFinalApprovalRegisterEntity)
        {
            CORP_CODE = pInspectFinalApprovalRegisterEntity.CORP_CODE;
            CRUD = pInspectFinalApprovalRegisterEntity.CRUD;
            USER_CODE = pInspectFinalApprovalRegisterEntity.USER_CODE;

            pInspectFinalApprovalRegisterEntity.WINDOW_NAME = WINDOW_NAME;

            DATE_FROM = pInspectFinalApprovalRegisterEntity.DATE_FROM;
            DATE_TO = pInspectFinalApprovalRegisterEntity.DATE_TO;
            PART_CODE = pInspectFinalApprovalRegisterEntity.PART_CODE;
            PART_NAME = pInspectFinalApprovalRegisterEntity.PART_NAME;
            INSPECT_STATUS = pInspectFinalApprovalRegisterEntity.INSPECT_STATUS;
            INSPECT_ID = pInspectFinalApprovalRegisterEntity.INSPECT_ID;
            INSPECT__DATE = pInspectFinalApprovalRegisterEntity.INSPECT__DATE;
            INSPECT_SEQ = pInspectFinalApprovalRegisterEntity.INSPECT_SEQ;
            VEND_PART_CODE = pInspectFinalApprovalRegisterEntity.VEND_PART_CODE;
            PART_TYPE = pInspectFinalApprovalRegisterEntity.PART_TYPE;
            REFERENCE_ID = pInspectFinalApprovalRegisterEntity.REFERENCE_ID;
            MAKE_VEND = pInspectFinalApprovalRegisterEntity.MAKE_VEND;
            MAKE_VEND_NAME = pInspectFinalApprovalRegisterEntity.MAKE_VEND_NAME;
            VEND_CODE = pInspectFinalApprovalRegisterEntity.VEND_CODE;
            VEND_NAME = pInspectFinalApprovalRegisterEntity.VEND_NAME;
            REQUEST_DEPT = pInspectFinalApprovalRegisterEntity.REQUEST_DEPT;
            CODE_NAME = pInspectFinalApprovalRegisterEntity.CODE_NAME;
            INOUT_DATE = pInspectFinalApprovalRegisterEntity.INOUT_DATE;
            INOUT_QTY = pInspectFinalApprovalRegisterEntity.INOUT_QTY;
            PACKING_REMARK = pInspectFinalApprovalRegisterEntity.PACKING_REMARK;
            SAMPLE_DATE = pInspectFinalApprovalRegisterEntity.SAMPLE_DATE;
            SAMPLE_LOCATION = pInspectFinalApprovalRegisterEntity.SAMPLE_LOCATION;
            SAMPLE_USER = pInspectFinalApprovalRegisterEntity.SAMPLE_USER;
            SAMPLE_METHOD = pInspectFinalApprovalRegisterEntity.SAMPLE_METHOD;
            SAMPLE_QTY = pInspectFinalApprovalRegisterEntity.SAMPLE_QTY;
            MAKE_NO = pInspectFinalApprovalRegisterEntity.MAKE_NO;
            STANDARD = pInspectFinalApprovalRegisterEntity.STANDARD;
            REQUEST_DATE = pInspectFinalApprovalRegisterEntity.REQUEST_DATE;
            REQUEST_USER = pInspectFinalApprovalRegisterEntity.REQUEST_USER;
            END_DATE = pInspectFinalApprovalRegisterEntity.END_DATE;
            TOTAL_RESULT = pInspectFinalApprovalRegisterEntity.TOTAL_RESULT;
            TOTAL_DATE = pInspectFinalApprovalRegisterEntity.TOTAL_DATE;
            TOTAL_USER = pInspectFinalApprovalRegisterEntity.TOTAL_USER;
            COMPLETE_YN = pInspectFinalApprovalRegisterEntity.COMPLETE_YN;
            REMARK = pInspectFinalApprovalRegisterEntity.REMARK;
            USER_YN = pInspectFinalApprovalRegisterEntity.USER_YN;
            dtListCnt = pInspectFinalApprovalRegisterEntity.dtListCnt;
            TOTAL_WRITER = pInspectFinalApprovalRegisterEntity.TOTAL_WRITER;
            TOTAL_CHECKER = pInspectFinalApprovalRegisterEntity.TOTAL_CHECKER;
            TOTAL_APPROVER = pInspectFinalApprovalRegisterEntity.TOTAL_APPROVER;
            TOTAL_APPROVER_SIGN = pInspectFinalApprovalRegisterEntity.TOTAL_APPROVER_SIGN;
            FILE_NAME = pInspectFinalApprovalRegisterEntity.FILE_NAME;
            APPROVAL_YN = pInspectFinalApprovalRegisterEntity.APPROVAL_YN;
            //pInspectFinalApprovalRegisterEntity.PROCESS_CODE = PROCESS_CODE;

            ERR_NO = pInspectFinalApprovalRegisterEntity.ERR_NO;
            ERR_MSG = pInspectFinalApprovalRegisterEntity.ERR_MSG;
            RTN_KEY = pInspectFinalApprovalRegisterEntity.RTN_KEY;
            RTN_SEQ = pInspectFinalApprovalRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pInspectFinalApprovalRegisterEntity.RTN_OTHERS;

            LANGUAGE_TYPE = pInspectFinalApprovalRegisterEntity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }
    public class InspectFinalApprovalRegisterT01Entity
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
        public String VEND_PART_CODE { get; set; }
        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        
        public String INSPECT_ID { get; set; }
        public String INSPECT_DATE { get; set; }
        public String INSPECT_SEQ { get; set; }
        public String INSPECT_STATUS { get; set; }
        public String INSPECT_QTY { get; set; }

        public String COMPLETE_YN { get; set; }
        public String REMARK { get; set; }
        public String USE_YN { get; set; }

        public String MATSTOCK_ID { get; set; }
        public String MATSTOCK_DETAIL_SEQ { get; set; }
        public String LOT_ID { get; set; }
        

        #endregion

        #region 생성자 - InspectFinalApprovalRegisterT01Entity()

        public InspectFinalApprovalRegisterT01Entity()
        {
        }

        #endregion

        #region 생성자 - InspectFinalApprovalRegisterT01Entity(InspectFinalApprovalRegisterT01Entity pInspectFinalApprovalRegisterT01Entity)

        public InspectFinalApprovalRegisterT01Entity(InspectFinalApprovalRegisterT01Entity pInspectFinalApprovalRegisterT01Entity)
        {
            CORP_CODE = pInspectFinalApprovalRegisterT01Entity.CORP_CODE;
            CRUD = pInspectFinalApprovalRegisterT01Entity.CRUD;
            USER_CODE = pInspectFinalApprovalRegisterT01Entity.USER_CODE;

            pInspectFinalApprovalRegisterT01Entity.WINDOW_NAME = WINDOW_NAME;

            DATE_FROM = pInspectFinalApprovalRegisterT01Entity.DATE_FROM;
            DATE_TO = pInspectFinalApprovalRegisterT01Entity.DATE_TO;
            VEND_PART_CODE = pInspectFinalApprovalRegisterT01Entity.VEND_PART_CODE;
            PART_CODE = pInspectFinalApprovalRegisterT01Entity.PART_CODE;
            PART_NAME = pInspectFinalApprovalRegisterT01Entity.PART_NAME;
            
            INSPECT_ID = pInspectFinalApprovalRegisterT01Entity.INSPECT_ID;
            INSPECT_DATE = pInspectFinalApprovalRegisterT01Entity.INSPECT_DATE;
            INSPECT_SEQ = pInspectFinalApprovalRegisterT01Entity.INSPECT_SEQ;
            INSPECT_QTY = pInspectFinalApprovalRegisterT01Entity.INSPECT_QTY;
            INSPECT_STATUS = pInspectFinalApprovalRegisterT01Entity.INSPECT_STATUS;

            COMPLETE_YN = pInspectFinalApprovalRegisterT01Entity.COMPLETE_YN;
            REMARK = pInspectFinalApprovalRegisterT01Entity.REMARK;
            USE_YN = pInspectFinalApprovalRegisterT01Entity.USE_YN;

            MATSTOCK_ID = pInspectFinalApprovalRegisterT01Entity.MATSTOCK_ID;
            MATSTOCK_DETAIL_SEQ = pInspectFinalApprovalRegisterT01Entity.MATSTOCK_DETAIL_SEQ;
            LOT_ID = pInspectFinalApprovalRegisterT01Entity.LOT_ID;
            
            ERR_NO = pInspectFinalApprovalRegisterT01Entity.ERR_NO;
            ERR_MSG = pInspectFinalApprovalRegisterT01Entity.ERR_MSG;
            RTN_KEY = pInspectFinalApprovalRegisterT01Entity.RTN_KEY;
            RTN_SEQ = pInspectFinalApprovalRegisterT01Entity.RTN_SEQ;
            RTN_OTHERS = pInspectFinalApprovalRegisterT01Entity.RTN_OTHERS;

            LANGUAGE_TYPE = pInspectFinalApprovalRegisterT01Entity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ucMatInspectDocumentListPopupEntity
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
        public String VEND_PART_CODE { get; set; }
        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }

        public String INSPECT_ID { get; set; }
        public String INSPECT_DATE { get; set; }
        public String INSPECT_SEQ { get; set; }
        public String INSPECT_STATUS { get; set; }
        public String INSPECT_QTY { get; set; }

        public String COMPLETE_YN { get; set; }
        public String REMARK { get; set; }
        public String USE_YN { get; set; }

        public String MATSTOCK_ID { get; set; }
        public String MATSTOCK_DETAIL_SEQ { get; set; }
        public String LOT_ID { get; set; }
        public String DOCUMENT_TYPE { get; set; }
        public String DOCUMENT_NAME { get; set; }
        public String DOCUMENT_VER { get; set; }


        #endregion

        #region 생성자 - ucMatInspectDocumentListPopupEntity()

        public ucMatInspectDocumentListPopupEntity()
        {
        }

        #endregion

        #region 생성자 - ucMatInspectDocumentListPopupEntity(ucMatInspectDocumentListPopupEntity pucMatInspectDocumentListPopupEntity)

        public ucMatInspectDocumentListPopupEntity(ucMatInspectDocumentListPopupEntity pucMatInspectDocumentListPopupEntity)
        {
            CORP_CODE = pucMatInspectDocumentListPopupEntity.CORP_CODE;
            CRUD = pucMatInspectDocumentListPopupEntity.CRUD;
            USER_CODE = pucMatInspectDocumentListPopupEntity.USER_CODE;

            pucMatInspectDocumentListPopupEntity.WINDOW_NAME = WINDOW_NAME;

            DATE_FROM = pucMatInspectDocumentListPopupEntity.DATE_FROM;
            DATE_TO = pucMatInspectDocumentListPopupEntity.DATE_TO;
            VEND_PART_CODE = pucMatInspectDocumentListPopupEntity.VEND_PART_CODE;
            PART_CODE = pucMatInspectDocumentListPopupEntity.PART_CODE;
            PART_NAME = pucMatInspectDocumentListPopupEntity.PART_NAME;

            INSPECT_ID = pucMatInspectDocumentListPopupEntity.INSPECT_ID;
            INSPECT_DATE = pucMatInspectDocumentListPopupEntity.INSPECT_DATE;
            INSPECT_SEQ = pucMatInspectDocumentListPopupEntity.INSPECT_SEQ;
            INSPECT_QTY = pucMatInspectDocumentListPopupEntity.INSPECT_QTY;
            INSPECT_STATUS = pucMatInspectDocumentListPopupEntity.INSPECT_STATUS;

            DOCUMENT_NAME = pucMatInspectDocumentListPopupEntity.DOCUMENT_NAME;
            DOCUMENT_TYPE = pucMatInspectDocumentListPopupEntity.DOCUMENT_TYPE;
            DOCUMENT_VER = pucMatInspectDocumentListPopupEntity.DOCUMENT_VER;

            COMPLETE_YN = pucMatInspectDocumentListPopupEntity.COMPLETE_YN;
            REMARK = pucMatInspectDocumentListPopupEntity.REMARK;
            USE_YN = pucMatInspectDocumentListPopupEntity.USE_YN;

            MATSTOCK_ID = pucMatInspectDocumentListPopupEntity.MATSTOCK_ID;
            MATSTOCK_DETAIL_SEQ = pucMatInspectDocumentListPopupEntity.MATSTOCK_DETAIL_SEQ;
            LOT_ID = pucMatInspectDocumentListPopupEntity.LOT_ID;

            ERR_NO = pucMatInspectDocumentListPopupEntity.ERR_NO;
            ERR_MSG = pucMatInspectDocumentListPopupEntity.ERR_MSG;
            RTN_KEY = pucMatInspectDocumentListPopupEntity.RTN_KEY;
            RTN_SEQ = pucMatInspectDocumentListPopupEntity.RTN_SEQ;
            RTN_OTHERS = pucMatInspectDocumentListPopupEntity.RTN_OTHERS;

            LANGUAGE_TYPE = pucMatInspectDocumentListPopupEntity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ucQCMaterialPartListPopupEntity
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

        #region 생성자 - ucQCMaterialPartListPopup()

        public ucQCMaterialPartListPopupEntity()
        {
        }

        #endregion

        #region 생성자 - ucQCMaterialPartListPopup(ucQCMaterialPartListPopup pucQCMaterialPartListPopupEntity)

        public ucQCMaterialPartListPopupEntity(ucQCMaterialPartListPopupEntity pucQCMaterialPartListPopupEntity)
        {
            CORP_CODE = pucQCMaterialPartListPopupEntity.CORP_CODE;
            CRUD = pucQCMaterialPartListPopupEntity.CRUD;
            USER_CODE = pucQCMaterialPartListPopupEntity.USER_CODE;
            LANGUAGE_TYPE = pucQCMaterialPartListPopupEntity.LANGUAGE_TYPE;
            WINDOW_NAME = pucQCMaterialPartListPopupEntity.WINDOW_NAME;

            PART_CODE = pucQCMaterialPartListPopupEntity.PART_CODE;
            PART_NAME = pucQCMaterialPartListPopupEntity.PART_NAME;
            PART_REVISION_NO = pucQCMaterialPartListPopupEntity.PART_REVISION_NO;
            VEND_PART_CODE = pucQCMaterialPartListPopupEntity.VEND_PART_CODE;

            PART_HIGH = pucQCMaterialPartListPopupEntity.PART_HIGH;
            PART_MIDDLE = pucQCMaterialPartListPopupEntity.PART_MIDDLE;
            PART_LOW = pucQCMaterialPartListPopupEntity.PART_LOW;

            ERR_NO = pucQCMaterialPartListPopupEntity.ERR_NO;
            ERR_MSG = pucQCMaterialPartListPopupEntity.ERR_MSG;
            RTN_KEY = pucQCMaterialPartListPopupEntity.RTN_KEY;
            RTN_SEQ = pucQCMaterialPartListPopupEntity.RTN_SEQ;
            RTN_AQ = pucQCMaterialPartListPopupEntity.RTN_AQ;
            RTN_SQ = pucQCMaterialPartListPopupEntity.RTN_SQ;
            RTN_OTHERS = pucQCMaterialPartListPopupEntity.RTN_OTHERS;
            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }


    public class ucInspectRequestInfoPopupEntity
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

        #region 생성자 - ucInspectRequestInfoPopupEntity()

        public ucInspectRequestInfoPopupEntity()
        {
        }

        #endregion

        #region 생성자 - ucInspectRequestInfoPopupEntity(pucInspectRequestInfoPopupEntity)

        public ucInspectRequestInfoPopupEntity(ucInspectRequestInfoPopupEntity pucInspectRequestInfoPopupEntity)
        {
            CORP_CODE = pucInspectRequestInfoPopupEntity.CORP_CODE;
            CRUD = pucInspectRequestInfoPopupEntity.CRUD;
            USER_CODE = pucInspectRequestInfoPopupEntity.USER_CODE;

            pucInspectRequestInfoPopupEntity.WINDOW_NAME = WINDOW_NAME;
            LANGUAGE_TYPE = pucInspectRequestInfoPopupEntity.LANGUAGE_TYPE;
            pucInspectRequestInfoPopupEntity.DATE_FROM = DATE_FROM;
            pucInspectRequestInfoPopupEntity.DATE_TO = DATE_TO;
            pucInspectRequestInfoPopupEntity.PROCESS_CODE = PROCESS_CODE;
            pucInspectRequestInfoPopupEntity.PART_TYPE = PART_TYPE;
            
            ERR_NO = pucInspectRequestInfoPopupEntity.ERR_NO;
            ERR_MSG = pucInspectRequestInfoPopupEntity.ERR_MSG;
            RTN_KEY = pucInspectRequestInfoPopupEntity.RTN_KEY;
            RTN_SEQ = pucInspectRequestInfoPopupEntity.RTN_SEQ;
            RTN_OTHERS = pucInspectRequestInfoPopupEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ucImportinspectInfoPopupEntity
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

        #region 생성자 - ucInspectRequestInfoPopupEntity()

        public ucImportinspectInfoPopupEntity()
        {
        }

        #endregion

        #region 생성자 - ucInspectRequestInfoPopupEntity(pucInspectRequestInfoPopupEntity)

        public ucImportinspectInfoPopupEntity(ucImportinspectInfoPopupEntity pucImportinspectInfoPopupEntity)
        {
            CORP_CODE = pucImportinspectInfoPopupEntity.CORP_CODE;
            CRUD = pucImportinspectInfoPopupEntity.CRUD;
            USER_CODE = pucImportinspectInfoPopupEntity.USER_CODE;

            pucImportinspectInfoPopupEntity.WINDOW_NAME = WINDOW_NAME;
            LANGUAGE_TYPE = pucImportinspectInfoPopupEntity.LANGUAGE_TYPE;
            pucImportinspectInfoPopupEntity.DATE_FROM = DATE_FROM;
            pucImportinspectInfoPopupEntity.DATE_TO = DATE_TO;
            pucImportinspectInfoPopupEntity.PROCESS_CODE = PROCESS_CODE;
            pucImportinspectInfoPopupEntity.PART_TYPE = PART_TYPE;
            pucImportinspectInfoPopupEntity.PART_NAME = PART_NAME;

            ERR_NO = pucImportinspectInfoPopupEntity.ERR_NO;
            ERR_MSG = pucImportinspectInfoPopupEntity.ERR_MSG;
            RTN_KEY = pucImportinspectInfoPopupEntity.RTN_KEY;
            RTN_SEQ = pucImportinspectInfoPopupEntity.RTN_SEQ;
            RTN_OTHERS = pucImportinspectInfoPopupEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }
    public class ucInspectRequestInfoPopup_T01Entity
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

        #region 생성자 - ucInspectRequestInfoPopup_T01Entity()

        public ucInspectRequestInfoPopup_T01Entity()
        {
        }

        #endregion

        #region 생성자 - ucInspectRequestInfoPopup_T01Entity(ucInspectRequestInfoPopup_T01Entity pucInspectRequestInfoPopup_T01Entity)

        public ucInspectRequestInfoPopup_T01Entity(ucInspectRequestInfoPopup_T01Entity pucInspectRequestInfoPopup_T01Entity)
        {
            CORP_CODE = pucInspectRequestInfoPopup_T01Entity.CORP_CODE;
            CRUD = pucInspectRequestInfoPopup_T01Entity.CRUD;
            USER_CODE = pucInspectRequestInfoPopup_T01Entity.USER_CODE;

            pucInspectRequestInfoPopup_T01Entity.WINDOW_NAME = WINDOW_NAME;
            LANGUAGE_TYPE = pucInspectRequestInfoPopup_T01Entity.LANGUAGE_TYPE;
            pucInspectRequestInfoPopup_T01Entity.DATE_FROM = DATE_FROM;
            pucInspectRequestInfoPopup_T01Entity.DATE_TO = DATE_TO;
            pucInspectRequestInfoPopup_T01Entity.PROCESS_CODE = PROCESS_CODE;
            pucInspectRequestInfoPopup_T01Entity.PART_TYPE = PART_TYPE;

            ERR_NO = pucInspectRequestInfoPopup_T01Entity.ERR_NO;
            ERR_MSG = pucInspectRequestInfoPopup_T01Entity.ERR_MSG;
            RTN_KEY = pucInspectRequestInfoPopup_T01Entity.RTN_KEY;
            RTN_SEQ = pucInspectRequestInfoPopup_T01Entity.RTN_SEQ;
            RTN_OTHERS = pucInspectRequestInfoPopup_T01Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }
    public class CheckDataRegisterEntity
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


        #endregion

        #region 생성자 - CheckDataRegisterEntity()

        public CheckDataRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - CheckDataRegisterEntity(pCheckDataRegisterEntity)

        public CheckDataRegisterEntity(CheckDataRegisterEntity pCheckDataRegisterEntity)
        {
            CORP_CODE = pCheckDataRegisterEntity.CORP_CODE;
            CRUD = pCheckDataRegisterEntity.CRUD;
            USER_CODE = pCheckDataRegisterEntity.USER_CODE;

            ERR_NO = pCheckDataRegisterEntity.ERR_NO;
            ERR_MSG = pCheckDataRegisterEntity.ERR_MSG;
            RTN_KEY = pCheckDataRegisterEntity.RTN_KEY;
            RTN_SEQ = pCheckDataRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pCheckDataRegisterEntity.RTN_OTHERS;
            LANGUAGE_TYPE = pCheckDataRegisterEntity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class FBDDataRegisterEntity
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

        //FiShbone Register 
        public string fbdName { get; set; }
        public string corpCode { get; set; }
        public string userName { get; set; }
        public string regDate { get; set; }
        public string upDate { get; set; }
        public string dscription { get; set; }
        public string useYN { get; set; }
        public string sltiCode { get; set; }
        public string orderNumber { get; set; }
        public string fbdcode { get; set; }
        public string process { get; set; }
        public int Level { get; set; }
        public string LocalName { get; set; }
        public string MiddleClass { get; set; }
        public string SmallClass { get; set; }
        public string USE_YN { get; set; }       
        public int ranking { get; set; }
        #endregion

        #region 생성자 - FBDDataRegisterEntity()

        public FBDDataRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - FBDDataRegisterEntity(pFBDDataRegisterEntity)

        public FBDDataRegisterEntity(FBDDataRegisterEntity pFBDDataRegisterEntity)
        {
            CORP_CODE = pFBDDataRegisterEntity.CORP_CODE;
            CRUD = pFBDDataRegisterEntity.CRUD;
            USER_CODE = pFBDDataRegisterEntity.USER_CODE;

            ERR_NO = pFBDDataRegisterEntity.ERR_NO;
            ERR_MSG = pFBDDataRegisterEntity.ERR_MSG;
            RTN_KEY = pFBDDataRegisterEntity.RTN_KEY;
            RTN_SEQ = pFBDDataRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pFBDDataRegisterEntity.RTN_OTHERS;
            LANGUAGE_TYPE = pFBDDataRegisterEntity.LANGUAGE_TYPE;

            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class ExcelFormDesignViewEntity
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


        #endregion

        #region 생성자 - ExcelFormDesignViewEntity()

        public ExcelFormDesignViewEntity()
        {
        }

        #endregion

        #region 생성자 - ExcelFormDesignViewEntity(pExcelFormDesignViewEntity)

        public ExcelFormDesignViewEntity(ExcelFormDesignViewEntity pExcelFormDesignViewEntity)
        {
            CORP_CODE = pExcelFormDesignViewEntity.CORP_CODE;
            CRUD = pExcelFormDesignViewEntity.CRUD;
            USER_CODE = pExcelFormDesignViewEntity.USER_CODE;

            LANGUAGE_TYPE = pExcelFormDesignViewEntity.LANGUAGE_TYPE;
            ERR_NO = pExcelFormDesignViewEntity.ERR_NO;
            ERR_MSG = pExcelFormDesignViewEntity.ERR_MSG;
            RTN_KEY = pExcelFormDesignViewEntity.RTN_KEY;
            RTN_SEQ = pExcelFormDesignViewEntity.RTN_SEQ;
            RTN_OTHERS = pExcelFormDesignViewEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class CheckDataViewEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE


        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        public String PART_NAME { get; set; }
        public String LOT_NO { get; set; }
        public String SEQ { get; set; }
        public String JSONCOL { get; set; }
        public String TRS_NO { get; set; }
        public String FPS_TRS_NO { get; set; }
     
        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String WINDOW_NAME { get; set; }


        #endregion

        #region 생성자 - CheckDataViewEntityEntity()

        public CheckDataViewEntity()
        {
        }

        #endregion

        #region 생성자 - CheckDataViewEntity(pExcelFormDesignViewEntity)

        public CheckDataViewEntity(CheckDataViewEntity pCheckDataViewEntityEntity)
        {
            CORP_CODE = pCheckDataViewEntityEntity.CORP_CODE;
            CRUD = pCheckDataViewEntityEntity.CRUD;
            USER_CODE = pCheckDataViewEntityEntity.USER_CODE;
            LANGUAGE_TYPE = pCheckDataViewEntityEntity.LANGUAGE_TYPE;
            ERR_NO = pCheckDataViewEntityEntity.ERR_NO;
            ERR_MSG = pCheckDataViewEntityEntity.ERR_MSG;
            RTN_KEY = pCheckDataViewEntityEntity.RTN_KEY;
            RTN_SEQ = pCheckDataViewEntityEntity.RTN_SEQ;
            RTN_OTHERS = pCheckDataViewEntityEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            DATE_FROM = pCheckDataViewEntityEntity.DATE_FROM;
            DATE_TO = pCheckDataViewEntityEntity.DATE_TO;
            PART_NAME = pCheckDataViewEntityEntity.PART_NAME;
            LOT_NO = pCheckDataViewEntityEntity.LOT_NO;
            SEQ = pCheckDataViewEntityEntity.SEQ;
            JSONCOL = pCheckDataViewEntityEntity.JSONCOL;
            TRS_NO = pCheckDataViewEntityEntity.TRS_NO;
            FPS_TRS_NO = pCheckDataViewEntityEntity.FPS_TRS_NO;
        }

        #endregion
    }


    public class CCPRegisterEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE


        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String PROCESS_CODE { get; set; }
        public String PROCESS_NAME { get; set; }
        public String REMARK { get; set; }
        public String CCP_DATE { get; set; }
        public String TEMPERATURE { get; set; }
        public String TEMPERATURE_UNIT { get; set; }
        public String HUMIDITY { get; set; }
        public String HUMIDITY_UNIT { get; set; }
        public String MOISTURE_VALUE { get; set; }
        public String MOISTURE_UNIT { get; set; }
        public String MEASURE { get; set; }

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

        #region 생성자 - CCPRegisterEntity()

        public CCPRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - CCPRegisterEntity(CCPRegisterEntity pCCPRegisterEntity)

        public CCPRegisterEntity(CCPRegisterEntity pCCPRegisterEntity)
        {
            CORP_CODE = pCCPRegisterEntity.CORP_CODE;
            CRUD = pCCPRegisterEntity.CRUD;
            USER_CODE = pCCPRegisterEntity.USER_CODE;

            LANGUAGE_TYPE = pCCPRegisterEntity.LANGUAGE_TYPE;

            ERR_NO = pCCPRegisterEntity.ERR_NO;
            ERR_MSG = pCCPRegisterEntity.ERR_MSG;
            RTN_KEY = pCCPRegisterEntity.RTN_KEY;
            RTN_SEQ = pCCPRegisterEntity.RTN_SEQ;
            RTN_AQ = pCCPRegisterEntity.RTN_AQ;
            RTN_SQ = pCCPRegisterEntity.RTN_SQ;
            RTN_OTHERS = pCCPRegisterEntity.RTN_OTHERS;


            PART_CODE = pCCPRegisterEntity.PART_CODE;
            PART_NAME = pCCPRegisterEntity.PART_NAME;
            PROCESS_CODE = pCCPRegisterEntity.PROCESS_CODE;
            PROCESS_NAME = pCCPRegisterEntity.PROCESS_NAME;
            REMARK = pCCPRegisterEntity.REMARK;
            USE_YN = pCCPRegisterEntity.USE_YN;
            DATE_FROM = pCCPRegisterEntity.DATE_FROM;
            DATE_TO = pCCPRegisterEntity.DATE_TO;
            CCP_DATE = pCCPRegisterEntity.CCP_DATE;
            TEMPERATURE = pCCPRegisterEntity.TEMPERATURE;
            TEMPERATURE_UNIT = pCCPRegisterEntity.TEMPERATURE_UNIT;
            HUMIDITY = pCCPRegisterEntity.HUMIDITY;
            HUMIDITY_UNIT = pCCPRegisterEntity.HUMIDITY_UNIT;
            MOISTURE_VALUE = pCCPRegisterEntity.MOISTURE_VALUE;
            MOISTURE_UNIT = pCCPRegisterEntity.MOISTURE_UNIT;
            MEASURE = pCCPRegisterEntity.MEASURE;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class CCPDetectionRegisterEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE


        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String PROCESS_CODE { get; set; }
        public String PROCESS_NAME { get; set; }
        public String REMARK { get; set; }
        public String CCP_DATE { get; set; }
        public String DETECTION_VALUE { get; set; }
        public String DETECTION { get; set; }
        public String MEASURE { get; set; }

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

        #region 생성자 - CCPRegisterEntity()

        public CCPDetectionRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - CCPDetectionRegisterEntity(CCPDetectionRegisterEntity pCCPDetectionRegisterEntity)

        public CCPDetectionRegisterEntity(CCPDetectionRegisterEntity pCCPDetectionRegisterEntity)
        {
            CORP_CODE = pCCPDetectionRegisterEntity.CORP_CODE;
            CRUD = pCCPDetectionRegisterEntity.CRUD;
            USER_CODE = pCCPDetectionRegisterEntity.USER_CODE;

            LANGUAGE_TYPE = pCCPDetectionRegisterEntity.LANGUAGE_TYPE;

            ERR_NO = pCCPDetectionRegisterEntity.ERR_NO;
            ERR_MSG = pCCPDetectionRegisterEntity.ERR_MSG;
            RTN_KEY = pCCPDetectionRegisterEntity.RTN_KEY;
            RTN_SEQ = pCCPDetectionRegisterEntity.RTN_SEQ;
            RTN_AQ = pCCPDetectionRegisterEntity.RTN_AQ;
            RTN_SQ = pCCPDetectionRegisterEntity.RTN_SQ;
            RTN_OTHERS = pCCPDetectionRegisterEntity.RTN_OTHERS;


            PART_CODE = pCCPDetectionRegisterEntity.PART_CODE;
            PART_NAME = pCCPDetectionRegisterEntity.PART_NAME;
            PROCESS_CODE = pCCPDetectionRegisterEntity.PROCESS_CODE;
            PROCESS_NAME = pCCPDetectionRegisterEntity.PROCESS_NAME;
            REMARK = pCCPDetectionRegisterEntity.REMARK;
            USE_YN = pCCPDetectionRegisterEntity.USE_YN;
            DATE_FROM = pCCPDetectionRegisterEntity.DATE_FROM;
            DATE_TO = pCCPDetectionRegisterEntity.DATE_TO;
            CCP_DATE = pCCPDetectionRegisterEntity.CCP_DATE;
            DETECTION_VALUE = pCCPDetectionRegisterEntity.DETECTION_VALUE;
            DETECTION = pCCPDetectionRegisterEntity.DETECTION;
            MEASURE = pCCPDetectionRegisterEntity.MEASURE;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class MaterialInspectRegister_T01Entity
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

        #region 생성자 - MaterialInspectRegister_T01Entity()

        public MaterialInspectRegister_T01Entity()
        {

        }

        #endregion

        #region 생성자 - MaterialInspectRegister_T01Entity(pMaterialInspectRegister_T01Entity)

        public MaterialInspectRegister_T01Entity(MaterialInspectRegister_T01Entity pMaterialInspectRegister_T01Entity)
        {
            CORP_CODE = pMaterialInspectRegister_T01Entity.CORP_CODE;
            CRUD = pMaterialInspectRegister_T01Entity.CRUD;
            USER_CODE = pMaterialInspectRegister_T01Entity.USER_CODE;
            LANGUAGE_TYPE = pMaterialInspectRegister_T01Entity.LANGUAGE_TYPE;

            pMaterialInspectRegister_T01Entity.DATE_FROM = DATE_FROM;
            pMaterialInspectRegister_T01Entity.DATE_TO = DATE_TO;
            pMaterialInspectRegister_T01Entity.CONTRACT_ID = CONTRACT_ID;
            pMaterialInspectRegister_T01Entity.PART_NAME = PART_NAME;
            pMaterialInspectRegister_T01Entity.VEND_CODE = VEND_CODE;
            pMaterialInspectRegister_T01Entity.VEND_NAME = VEND_NAME;
            pMaterialInspectRegister_T01Entity.CONTRACT_ID = CONTRACT_ID;

            pMaterialInspectRegister_T01Entity.CONTRACT_DATE = CONTRACT_DATE;
            pMaterialInspectRegister_T01Entity.CONTRACT_QTY = CONTRACT_QTY;
            pMaterialInspectRegister_T01Entity.DELIVERY_DATE = DELIVERY_DATE;
            pMaterialInspectRegister_T01Entity.DELIVERY_LOCATION = DELIVERY_LOCATION;
            pMaterialInspectRegister_T01Entity.UNITCOST = UNITCOST;
            pMaterialInspectRegister_T01Entity.COST = COST;
            pMaterialInspectRegister_T01Entity.REMARK = REMARK;
            pMaterialInspectRegister_T01Entity.USE_YN = USE_YN;
            pMaterialInspectRegister_T01Entity.USE_YN = UNIT_CODE;

            ERR_NO = pMaterialInspectRegister_T01Entity.ERR_NO;
            ERR_MSG = pMaterialInspectRegister_T01Entity.ERR_MSG;
            RTN_KEY = pMaterialInspectRegister_T01Entity.RTN_KEY;
            RTN_SEQ = pMaterialInspectRegister_T01Entity.RTN_SEQ;
            RTN_AQ = pMaterialInspectRegister_T01Entity.RTN_AQ;
            RTN_SQ = pMaterialInspectRegister_T01Entity.RTN_SQ;
            RTN_OTHERS = pMaterialInspectRegister_T01Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }


    public class FirstMiddleLastInspectRegisterEntity
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

        #region 생성자 - FirstMiddleLastInspectRegisterEntity()

        public FirstMiddleLastInspectRegisterEntity()
        {

        }

        #endregion

        #region 생성자 - FirstMiddleLastInspectRegisterEntity(pFirstMiddleLastInspectRegisterEntity)

        public FirstMiddleLastInspectRegisterEntity(FirstMiddleLastInspectRegisterEntity pFirstMiddleLastInspectRegisterEntity)
        {
            CORP_CODE = pFirstMiddleLastInspectRegisterEntity.CORP_CODE;
            CRUD = pFirstMiddleLastInspectRegisterEntity.CRUD;
            USER_CODE = pFirstMiddleLastInspectRegisterEntity.USER_CODE;
            LANGUAGE_TYPE = pFirstMiddleLastInspectRegisterEntity.LANGUAGE_TYPE;

            pFirstMiddleLastInspectRegisterEntity.DATE_FROM = DATE_FROM;
            pFirstMiddleLastInspectRegisterEntity.DATE_TO = DATE_TO;
            pFirstMiddleLastInspectRegisterEntity.CONTRACT_ID = CONTRACT_ID;
            pFirstMiddleLastInspectRegisterEntity.PART_NAME = PART_NAME;
            pFirstMiddleLastInspectRegisterEntity.VEND_CODE = VEND_CODE;
            pFirstMiddleLastInspectRegisterEntity.VEND_NAME = VEND_NAME;
            pFirstMiddleLastInspectRegisterEntity.CONTRACT_ID = CONTRACT_ID;

            pFirstMiddleLastInspectRegisterEntity.CONTRACT_DATE = CONTRACT_DATE;
            pFirstMiddleLastInspectRegisterEntity.CONTRACT_QTY = CONTRACT_QTY;
            pFirstMiddleLastInspectRegisterEntity.DELIVERY_DATE = DELIVERY_DATE;
            pFirstMiddleLastInspectRegisterEntity.DELIVERY_LOCATION = DELIVERY_LOCATION;
            pFirstMiddleLastInspectRegisterEntity.UNITCOST = UNITCOST;
            pFirstMiddleLastInspectRegisterEntity.COST = COST;
            pFirstMiddleLastInspectRegisterEntity.REMARK = REMARK;
            pFirstMiddleLastInspectRegisterEntity.USE_YN = USE_YN;
            pFirstMiddleLastInspectRegisterEntity.USE_YN = UNIT_CODE;

            ERR_NO = pFirstMiddleLastInspectRegisterEntity.ERR_NO;
            ERR_MSG = pFirstMiddleLastInspectRegisterEntity.ERR_MSG;
            RTN_KEY = pFirstMiddleLastInspectRegisterEntity.RTN_KEY;
            RTN_SEQ = pFirstMiddleLastInspectRegisterEntity.RTN_SEQ;
            RTN_AQ = pFirstMiddleLastInspectRegisterEntity.RTN_AQ;
            RTN_SQ = pFirstMiddleLastInspectRegisterEntity.RTN_SQ;
            RTN_OTHERS = pFirstMiddleLastInspectRegisterEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class MixingDegreeRegisterEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE


        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String PROCESS_CODE { get; set; }
        public String PROCESS_NAME { get; set; }
        public String REMARK { get; set; }
        public String CCP_DATE { get; set; }
        public String TEMPERATURE { get; set; }
        public String TEMPERATURE_UNIT { get; set; }
        public String HUMIDITY { get; set; }
        public String HUMIDITY_UNIT { get; set; }
        public String MOISTURE_VALUE { get; set; }
        public String MOISTURE_UNIT { get; set; }
        public String MEASURE { get; set; }

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

        #region 생성자 - MixingDegreeRegisterEntity()

        public MixingDegreeRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - MixingDegreeRegisterEntity(MixingDegreeRegisterEntity pMixingDegreeRegisterEntity)

        public MixingDegreeRegisterEntity(MixingDegreeRegisterEntity pMixingDegreeRegisterEntity)
        {
            CORP_CODE = pMixingDegreeRegisterEntity.CORP_CODE;
            CRUD = pMixingDegreeRegisterEntity.CRUD;
            USER_CODE = pMixingDegreeRegisterEntity.USER_CODE;

            LANGUAGE_TYPE = pMixingDegreeRegisterEntity.LANGUAGE_TYPE;

            ERR_NO = pMixingDegreeRegisterEntity.ERR_NO;
            ERR_MSG = pMixingDegreeRegisterEntity.ERR_MSG;
            RTN_KEY = pMixingDegreeRegisterEntity.RTN_KEY;
            RTN_SEQ = pMixingDegreeRegisterEntity.RTN_SEQ;
            RTN_AQ = pMixingDegreeRegisterEntity.RTN_AQ;
            RTN_SQ = pMixingDegreeRegisterEntity.RTN_SQ;
            RTN_OTHERS = pMixingDegreeRegisterEntity.RTN_OTHERS;


            PART_CODE = pMixingDegreeRegisterEntity.PART_CODE;
            PART_NAME = pMixingDegreeRegisterEntity.PART_NAME;
            PROCESS_CODE = pMixingDegreeRegisterEntity.PROCESS_CODE;
            PROCESS_NAME = pMixingDegreeRegisterEntity.PROCESS_NAME;
            REMARK = pMixingDegreeRegisterEntity.REMARK;
            USE_YN = pMixingDegreeRegisterEntity.USE_YN;
            DATE_FROM = pMixingDegreeRegisterEntity.DATE_FROM;
            DATE_TO = pMixingDegreeRegisterEntity.DATE_TO;
            CCP_DATE = pMixingDegreeRegisterEntity.CCP_DATE;
            TEMPERATURE = pMixingDegreeRegisterEntity.TEMPERATURE;
            TEMPERATURE_UNIT = pMixingDegreeRegisterEntity.TEMPERATURE_UNIT;
            HUMIDITY = pMixingDegreeRegisterEntity.HUMIDITY;
            HUMIDITY_UNIT = pMixingDegreeRegisterEntity.HUMIDITY_UNIT;
            MOISTURE_VALUE = pMixingDegreeRegisterEntity.MOISTURE_VALUE;
            MOISTURE_UNIT = pMixingDegreeRegisterEntity.MOISTURE_UNIT;
            MEASURE = pMixingDegreeRegisterEntity.MEASURE;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ManufacturingHistoryEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE
        public String PRODUCTION_ORDER_ID { get; set; }


        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String CONTRACT_ID { get; set; }
        public String PROCESS_CODE { get; set; }
        public String PROCESS_NAME { get; set; }
        public String REMARK { get; set; }
        public String CCP_DATE { get; set; }
        public String TEMPERATURE { get; set; }
        public String TEMPERATURE_UNIT { get; set; }
        public String HUMIDITY { get; set; }
        public String HUMIDITY_UNIT { get; set; }
        public String MOISTURE_VALUE { get; set; }
        public String MOISTURE_UNIT { get; set; }
        public String MEASURE { get; set; }

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

        #region 생성자 - ManufacturingHistoryEntity()

        public ManufacturingHistoryEntity()
        {
        }

        #endregion

        #region 생성자 - ManufacturingHistoryEntity(ManufacturingHistoryEntity pManufacturingHistoryEntity)

        public ManufacturingHistoryEntity(ManufacturingHistoryEntity pManufacturingHistoryEntity)
        {
            CORP_CODE = pManufacturingHistoryEntity.CORP_CODE;
            CRUD = pManufacturingHistoryEntity.CRUD;
            USER_CODE = pManufacturingHistoryEntity.USER_CODE;

            LANGUAGE_TYPE = pManufacturingHistoryEntity.LANGUAGE_TYPE;
            PRODUCTION_ORDER_ID = pManufacturingHistoryEntity.PRODUCTION_ORDER_ID;

            ERR_NO = pManufacturingHistoryEntity.ERR_NO;
            ERR_MSG = pManufacturingHistoryEntity.ERR_MSG;
            RTN_KEY = pManufacturingHistoryEntity.RTN_KEY;
            RTN_SEQ = pManufacturingHistoryEntity.RTN_SEQ;
            RTN_AQ = pManufacturingHistoryEntity.RTN_AQ;
            RTN_SQ = pManufacturingHistoryEntity.RTN_SQ;
            RTN_OTHERS = pManufacturingHistoryEntity.RTN_OTHERS;


            PART_CODE = pManufacturingHistoryEntity.PART_CODE;
            PART_NAME = pManufacturingHistoryEntity.PART_NAME;
            CONTRACT_ID = pManufacturingHistoryEntity.CONTRACT_ID;
            PROCESS_CODE = pManufacturingHistoryEntity.PROCESS_CODE;
            PROCESS_NAME = pManufacturingHistoryEntity.PROCESS_NAME;
            REMARK = pManufacturingHistoryEntity.REMARK;
            USE_YN = pManufacturingHistoryEntity.USE_YN;
            DATE_FROM = pManufacturingHistoryEntity.DATE_FROM;
            DATE_TO = pManufacturingHistoryEntity.DATE_TO;
            CCP_DATE = pManufacturingHistoryEntity.CCP_DATE;
            TEMPERATURE = pManufacturingHistoryEntity.TEMPERATURE;
            TEMPERATURE_UNIT = pManufacturingHistoryEntity.TEMPERATURE_UNIT;
            HUMIDITY = pManufacturingHistoryEntity.HUMIDITY;
            HUMIDITY_UNIT = pManufacturingHistoryEntity.HUMIDITY_UNIT;
            MOISTURE_VALUE = pManufacturingHistoryEntity.MOISTURE_VALUE;
            MOISTURE_UNIT = pManufacturingHistoryEntity.MOISTURE_UNIT;
            MEASURE = pManufacturingHistoryEntity.MEASURE;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ManufacturingHistory_T01Entity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE
        public String PRODUCTION_ORDER_ID { get; set; }


        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String CONTRACT_ID { get; set; }
        public String PROCESS_CODE { get; set; }
        public String PROCESS_NAME { get; set; }
        public String REMARK { get; set; }
        public String CCP_DATE { get; set; }
        public String TEMPERATURE { get; set; }
        public String TEMPERATURE_UNIT { get; set; }
        public String HUMIDITY { get; set; }
        public String HUMIDITY_UNIT { get; set; }
        public String MOISTURE_VALUE { get; set; }
        public String MOISTURE_UNIT { get; set; }
        public String MEASURE { get; set; }

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

        #region 생성자 - ManufacturingHistoryEntity()

        public ManufacturingHistory_T01Entity()
        {
        }

        #endregion

        #region 생성자 - ManufacturingHistoryEntity(ManufacturingHistoryEntity pManufacturingHistoryEntity)

        public ManufacturingHistory_T01Entity(ManufacturingHistory_T01Entity pManufacturingHistory_T01Entity)
        {
            CORP_CODE = pManufacturingHistory_T01Entity.CORP_CODE;
            CRUD = pManufacturingHistory_T01Entity.CRUD;
            USER_CODE = pManufacturingHistory_T01Entity.USER_CODE;

            LANGUAGE_TYPE = pManufacturingHistory_T01Entity.LANGUAGE_TYPE;
            PRODUCTION_ORDER_ID = pManufacturingHistory_T01Entity.PRODUCTION_ORDER_ID;

            ERR_NO = pManufacturingHistory_T01Entity.ERR_NO;
            ERR_MSG = pManufacturingHistory_T01Entity.ERR_MSG;
            RTN_KEY = pManufacturingHistory_T01Entity.RTN_KEY;
            RTN_SEQ = pManufacturingHistory_T01Entity.RTN_SEQ;
            RTN_AQ = pManufacturingHistory_T01Entity.RTN_AQ;
            RTN_SQ = pManufacturingHistory_T01Entity.RTN_SQ;
            RTN_OTHERS = pManufacturingHistory_T01Entity.RTN_OTHERS;


            PART_CODE = pManufacturingHistory_T01Entity.PART_CODE;
            PART_NAME = pManufacturingHistory_T01Entity.PART_NAME;
            CONTRACT_ID = pManufacturingHistory_T01Entity.CONTRACT_ID;
            PROCESS_CODE = pManufacturingHistory_T01Entity.PROCESS_CODE;
            PROCESS_NAME = pManufacturingHistory_T01Entity.PROCESS_NAME;
            REMARK = pManufacturingHistory_T01Entity.REMARK;
            USE_YN = pManufacturingHistory_T01Entity.USE_YN;
            DATE_FROM = pManufacturingHistory_T01Entity.DATE_FROM;
            DATE_TO = pManufacturingHistory_T01Entity.DATE_TO;
            CCP_DATE = pManufacturingHistory_T01Entity.CCP_DATE;
            TEMPERATURE = pManufacturingHistory_T01Entity.TEMPERATURE;
            TEMPERATURE_UNIT = pManufacturingHistory_T01Entity.TEMPERATURE_UNIT;
            HUMIDITY = pManufacturingHistory_T01Entity.HUMIDITY;
            HUMIDITY_UNIT = pManufacturingHistory_T01Entity.HUMIDITY_UNIT;
            MOISTURE_VALUE = pManufacturingHistory_T01Entity.MOISTURE_VALUE;
            MOISTURE_UNIT = pManufacturingHistory_T01Entity.MOISTURE_UNIT;
            MEASURE = pManufacturingHistory_T01Entity.MEASURE;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class FirstMiddleLastItemEntity
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
        public String ITEM_ID { get; set; }

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

        #region 생성자 - FirstMiddleLastInspectRegisterEntity()

        public FirstMiddleLastItemEntity()
        {

        }

        #endregion

        #region 생성자 - FirstMiddleLastInspectRegisterEntity(pFirstMiddleLastInspectRegisterEntity)

        public FirstMiddleLastItemEntity(FirstMiddleLastItemEntity pFirstMiddleLastItemEntity)
        {
            CORP_CODE = pFirstMiddleLastItemEntity.CORP_CODE;
            CRUD = pFirstMiddleLastItemEntity.CRUD;
            USER_CODE = pFirstMiddleLastItemEntity.USER_CODE;
            LANGUAGE_TYPE = pFirstMiddleLastItemEntity.LANGUAGE_TYPE;

            pFirstMiddleLastItemEntity.DATE_FROM = DATE_FROM;
            pFirstMiddleLastItemEntity.DATE_TO = DATE_TO;
            pFirstMiddleLastItemEntity.CONTRACT_ID = CONTRACT_ID;
            pFirstMiddleLastItemEntity.PART_NAME = PART_NAME;
            pFirstMiddleLastItemEntity.VEND_CODE = VEND_CODE;
            pFirstMiddleLastItemEntity.VEND_NAME = VEND_NAME;
            pFirstMiddleLastItemEntity.CONTRACT_ID = CONTRACT_ID;

            pFirstMiddleLastItemEntity.CONTRACT_DATE = CONTRACT_DATE;
            pFirstMiddleLastItemEntity.CONTRACT_QTY = CONTRACT_QTY;
            pFirstMiddleLastItemEntity.DELIVERY_DATE = DELIVERY_DATE;
            pFirstMiddleLastItemEntity.DELIVERY_LOCATION = DELIVERY_LOCATION;
            pFirstMiddleLastItemEntity.UNITCOST = UNITCOST;
            pFirstMiddleLastItemEntity.COST = COST;
            pFirstMiddleLastItemEntity.REMARK = REMARK;
            pFirstMiddleLastItemEntity.USE_YN = USE_YN;
            pFirstMiddleLastItemEntity.USE_YN = UNIT_CODE;
            pFirstMiddleLastItemEntity.ITEM_ID = ITEM_ID;

            ERR_NO = pFirstMiddleLastItemEntity.ERR_NO;
            ERR_MSG = pFirstMiddleLastItemEntity.ERR_MSG;
            RTN_KEY = pFirstMiddleLastItemEntity.RTN_KEY;
            RTN_SEQ = pFirstMiddleLastItemEntity.RTN_SEQ;
            RTN_AQ = pFirstMiddleLastItemEntity.RTN_AQ;
            RTN_SQ = pFirstMiddleLastItemEntity.RTN_SQ;
            RTN_OTHERS = pFirstMiddleLastItemEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class QualityInspectEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE
        public String PRODUCTION_ORDER_ID { get; set; }


        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String CONTRACT_ID { get; set; }
        public String PROCESS_CODE { get; set; }
        public String PROCESS_NAME { get; set; }
        public String REMARK { get; set; }
        public String CCP_DATE { get; set; }
        public String TEMPERATURE { get; set; }
        public String TEMPERATURE_UNIT { get; set; }
        public String HUMIDITY { get; set; }
        public String HUMIDITY_UNIT { get; set; }
        public String MOISTURE_VALUE { get; set; }
        public String MOISTURE_UNIT { get; set; }
        public String MEASURE { get; set; }

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

        #region 생성자 - QualityInspectEntity()

        public QualityInspectEntity()
        {
        }

        #endregion

        #region 생성자 - QualityInspectEntity(QualityInspectEntity pQualityInspectEntity)

        public QualityInspectEntity(QualityInspectEntity pQualityInspectEntity)
        {
            CORP_CODE = pQualityInspectEntity.CORP_CODE;
            CRUD = pQualityInspectEntity.CRUD;
            USER_CODE = pQualityInspectEntity.USER_CODE;

            LANGUAGE_TYPE = pQualityInspectEntity.LANGUAGE_TYPE;
            PRODUCTION_ORDER_ID = pQualityInspectEntity.PRODUCTION_ORDER_ID;

            ERR_NO = pQualityInspectEntity.ERR_NO;
            ERR_MSG = pQualityInspectEntity.ERR_MSG;
            RTN_KEY = pQualityInspectEntity.RTN_KEY;
            RTN_SEQ = pQualityInspectEntity.RTN_SEQ;
            RTN_AQ = pQualityInspectEntity.RTN_AQ;
            RTN_SQ = pQualityInspectEntity.RTN_SQ;
            RTN_OTHERS = pQualityInspectEntity.RTN_OTHERS;


            PART_CODE = pQualityInspectEntity.PART_CODE;
            PART_NAME = pQualityInspectEntity.PART_NAME;
            CONTRACT_ID = pQualityInspectEntity.CONTRACT_ID;
            PROCESS_CODE = pQualityInspectEntity.PROCESS_CODE;
            PROCESS_NAME = pQualityInspectEntity.PROCESS_NAME;
            REMARK = pQualityInspectEntity.REMARK;
            USE_YN = pQualityInspectEntity.USE_YN;
            DATE_FROM = pQualityInspectEntity.DATE_FROM;
            DATE_TO = pQualityInspectEntity.DATE_TO;
            CCP_DATE = pQualityInspectEntity.CCP_DATE;
            TEMPERATURE = pQualityInspectEntity.TEMPERATURE;
            TEMPERATURE_UNIT = pQualityInspectEntity.TEMPERATURE_UNIT;
            HUMIDITY = pQualityInspectEntity.HUMIDITY;
            HUMIDITY_UNIT = pQualityInspectEntity.HUMIDITY_UNIT;
            MOISTURE_VALUE = pQualityInspectEntity.MOISTURE_VALUE;
            MOISTURE_UNIT = pQualityInspectEntity.MOISTURE_UNIT;
            MEASURE = pQualityInspectEntity.MEASURE;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }


    public class HACCPCheckRegisterEntity
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

        #region 생성자 - HACCPCheckRegisterEntity()

        public HACCPCheckRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - HACCPCheckRegisterEntity(pHACCPCheckRegisterEntity)

        public HACCPCheckRegisterEntity(HACCPCheckRegisterEntity pHACCPCheckRegisterEntity)
        {
            CORP_CODE = pHACCPCheckRegisterEntity.CORP_CODE;
            CRUD = pHACCPCheckRegisterEntity.CRUD;
            USER_CODE = pHACCPCheckRegisterEntity.USER_CODE;

            pHACCPCheckRegisterEntity.WINDOW_NAME = WINDOW_NAME;

            HACCP_TYPE = pHACCPCheckRegisterEntity.HACCP_TYPE;
            DATE_FROM = pHACCPCheckRegisterEntity.DATE_FROM;
            DATE_TO = pHACCPCheckRegisterEntity.DATE_TO;
            PART_NAME = pHACCPCheckRegisterEntity.PART_NAME;
            HACCP_ID = pHACCPCheckRegisterEntity.HACCP_ID;
            HACCP_DATE = pHACCPCheckRegisterEntity.HACCP_DATE;
            HACCP_SEQ = pHACCPCheckRegisterEntity.HACCP_SEQ;
            PROCESS_NAME = pHACCPCheckRegisterEntity.PROCESS_NAME;
            REQUEST_DEPT = pHACCPCheckRegisterEntity.REQUEST_DEPT;
            CODE_NAME = pHACCPCheckRegisterEntity.CODE_NAME;
            INOUT_DATE = pHACCPCheckRegisterEntity.INOUT_DATE;
            INOUT_QTY = pHACCPCheckRegisterEntity.INOUT_QTY;
            PACKING_REMARK = pHACCPCheckRegisterEntity.PACKING_REMARK;
            SAMPLE_DEPT = pHACCPCheckRegisterEntity.SAMPLE_DEPT;
            SAMPLE_NO = pHACCPCheckRegisterEntity.SAMPLE_NO;
            SAMPLE_USER = pHACCPCheckRegisterEntity.SAMPLE_USER;
            REMARK = pHACCPCheckRegisterEntity.REMARK;
            USER_YN = pHACCPCheckRegisterEntity.USER_YN;
            dtListCnt = pHACCPCheckRegisterEntity.dtListCnt;

            MISSING_CHECK = pHACCPCheckRegisterEntity.MISSING_CHECK;

            ERR_NO = pHACCPCheckRegisterEntity.ERR_NO;
            ERR_MSG = pHACCPCheckRegisterEntity.ERR_MSG;
            RTN_KEY = pHACCPCheckRegisterEntity.RTN_KEY;
            RTN_SEQ = pHACCPCheckRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pHACCPCheckRegisterEntity.RTN_OTHERS;

            LANGUAGE_TYPE = pHACCPCheckRegisterEntity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }
    
    public class HACCPCheckRegisterT01Entity
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

        #region 생성자 - HACCPCheckRegisterT02Entity()

        public HACCPCheckRegisterT01Entity()
        {
        }

        #endregion

        #region 생성자 - HACCPCheckRegisterT01Entity(pHACCPCheckRegisterT01Entity)

        public HACCPCheckRegisterT01Entity(HACCPCheckRegisterT01Entity pHACCPCheckRegisterT01Entity)
        {
            CORP_CODE = pHACCPCheckRegisterT01Entity.CORP_CODE;
            CRUD = pHACCPCheckRegisterT01Entity.CRUD;
            USER_CODE = pHACCPCheckRegisterT01Entity.USER_CODE;

            pHACCPCheckRegisterT01Entity.WINDOW_NAME = WINDOW_NAME;

            HACCP_TYPE = pHACCPCheckRegisterT01Entity.HACCP_TYPE;
            DATE_FROM = pHACCPCheckRegisterT01Entity.DATE_FROM;
            DATE_TO = pHACCPCheckRegisterT01Entity.DATE_TO;
            PART_NAME = pHACCPCheckRegisterT01Entity.PART_NAME;
            HACCP_ID = pHACCPCheckRegisterT01Entity.HACCP_ID;
            HACCP_DATE = pHACCPCheckRegisterT01Entity.HACCP_DATE;
            HACCP_SEQ = pHACCPCheckRegisterT01Entity.HACCP_SEQ;
            PROCESS_NAME = pHACCPCheckRegisterT01Entity.PROCESS_NAME;
            REQUEST_DEPT = pHACCPCheckRegisterT01Entity.REQUEST_DEPT;
            CODE_NAME = pHACCPCheckRegisterT01Entity.CODE_NAME;
            INOUT_DATE = pHACCPCheckRegisterT01Entity.INOUT_DATE;
            INOUT_QTY = pHACCPCheckRegisterT01Entity.INOUT_QTY;
            PACKING_REMARK = pHACCPCheckRegisterT01Entity.PACKING_REMARK;
            SAMPLE_DEPT = pHACCPCheckRegisterT01Entity.SAMPLE_DEPT;
            SAMPLE_NO = pHACCPCheckRegisterT01Entity.SAMPLE_NO;
            SAMPLE_USER = pHACCPCheckRegisterT01Entity.SAMPLE_USER;
            REMARK = pHACCPCheckRegisterT01Entity.REMARK;
            USER_YN = pHACCPCheckRegisterT01Entity.USER_YN;
            dtListCnt = pHACCPCheckRegisterT01Entity.dtListCnt;

            MISSING_CHECK = pHACCPCheckRegisterT01Entity.MISSING_CHECK;

            ERR_NO = pHACCPCheckRegisterT01Entity.ERR_NO;
            ERR_MSG = pHACCPCheckRegisterT01Entity.ERR_MSG;
            RTN_KEY = pHACCPCheckRegisterT01Entity.RTN_KEY;
            RTN_SEQ = pHACCPCheckRegisterT01Entity.RTN_SEQ;
            RTN_OTHERS = pHACCPCheckRegisterT01Entity.RTN_OTHERS;

            LANGUAGE_TYPE = pHACCPCheckRegisterT01Entity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class HACCPCheckRegisterT02Entity
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

        #region 생성자 - HACCPCheckRegisterT02Entity()

        public HACCPCheckRegisterT02Entity()
        {
        }

        #endregion

        #region 생성자 - HACCPCheckRegisterT02Entity(pHACCPCheckRegisterT02Entity)

        public HACCPCheckRegisterT02Entity(HACCPCheckRegisterT02Entity pHACCPCheckRegisterT02Entity)
        {
            CORP_CODE = pHACCPCheckRegisterT02Entity.CORP_CODE;
            CRUD = pHACCPCheckRegisterT02Entity.CRUD;
            USER_CODE = pHACCPCheckRegisterT02Entity.USER_CODE;

            pHACCPCheckRegisterT02Entity.WINDOW_NAME = WINDOW_NAME;

            HACCP_TYPE = pHACCPCheckRegisterT02Entity.HACCP_TYPE;
            DATE_FROM = pHACCPCheckRegisterT02Entity.DATE_FROM;
            DATE_TO = pHACCPCheckRegisterT02Entity.DATE_TO;
            PART_NAME = pHACCPCheckRegisterT02Entity.PART_NAME;
            HACCP_ID = pHACCPCheckRegisterT02Entity.HACCP_ID;
            HACCP_DATE = pHACCPCheckRegisterT02Entity.HACCP_DATE;
            HACCP_SEQ = pHACCPCheckRegisterT02Entity.HACCP_SEQ;
            PROCESS_NAME = pHACCPCheckRegisterT02Entity.PROCESS_NAME;
            REQUEST_DEPT = pHACCPCheckRegisterT02Entity.REQUEST_DEPT;
            CODE_NAME = pHACCPCheckRegisterT02Entity.CODE_NAME;
            INOUT_DATE = pHACCPCheckRegisterT02Entity.INOUT_DATE;
            INOUT_QTY = pHACCPCheckRegisterT02Entity.INOUT_QTY;
            PACKING_REMARK = pHACCPCheckRegisterT02Entity.PACKING_REMARK;
            SAMPLE_DEPT = pHACCPCheckRegisterT02Entity.SAMPLE_DEPT;
            SAMPLE_NO = pHACCPCheckRegisterT02Entity.SAMPLE_NO;
            SAMPLE_USER = pHACCPCheckRegisterT02Entity.SAMPLE_USER;
            REMARK = pHACCPCheckRegisterT02Entity.REMARK;
            USER_YN = pHACCPCheckRegisterT02Entity.USER_YN;
            dtListCnt = pHACCPCheckRegisterT02Entity.dtListCnt;

            MISSING_CHECK = pHACCPCheckRegisterT02Entity.MISSING_CHECK;

            ERR_NO = pHACCPCheckRegisterT02Entity.ERR_NO;
            ERR_MSG = pHACCPCheckRegisterT02Entity.ERR_MSG;
            RTN_KEY = pHACCPCheckRegisterT02Entity.RTN_KEY;
            RTN_SEQ = pHACCPCheckRegisterT02Entity.RTN_SEQ;
            RTN_OTHERS = pHACCPCheckRegisterT02Entity.RTN_OTHERS;

            LANGUAGE_TYPE = pHACCPCheckRegisterT02Entity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class HACCPCheckRegisterT03Entity
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

        #region 생성자 - HACCPCheckRegisterT03Entity()

        public HACCPCheckRegisterT03Entity()
        {
        }

        #endregion

        #region 생성자 - HACCPCheckRegisterT03Entity(pHACCPCheckRegisterT03Entity)

        public HACCPCheckRegisterT03Entity(HACCPCheckRegisterT03Entity pHACCPCheckRegisterT03Entity)
        {
            CORP_CODE = pHACCPCheckRegisterT03Entity.CORP_CODE;
            CRUD = pHACCPCheckRegisterT03Entity.CRUD;
            USER_CODE = pHACCPCheckRegisterT03Entity.USER_CODE;

            pHACCPCheckRegisterT03Entity.WINDOW_NAME = WINDOW_NAME;

            HACCP_TYPE = pHACCPCheckRegisterT03Entity.HACCP_TYPE;
            DATE_FROM = pHACCPCheckRegisterT03Entity.DATE_FROM;
            DATE_TO = pHACCPCheckRegisterT03Entity.DATE_TO;
            PART_NAME = pHACCPCheckRegisterT03Entity.PART_NAME;
            HACCP_ID = pHACCPCheckRegisterT03Entity.HACCP_ID;
            HACCP_DATE = pHACCPCheckRegisterT03Entity.HACCP_DATE;
            HACCP_SEQ = pHACCPCheckRegisterT03Entity.HACCP_SEQ;
            PROCESS_NAME = pHACCPCheckRegisterT03Entity.PROCESS_NAME;
            REQUEST_DEPT = pHACCPCheckRegisterT03Entity.REQUEST_DEPT;
            CODE_NAME = pHACCPCheckRegisterT03Entity.CODE_NAME;
            INOUT_DATE = pHACCPCheckRegisterT03Entity.INOUT_DATE;
            INOUT_QTY = pHACCPCheckRegisterT03Entity.INOUT_QTY;
            PACKING_REMARK = pHACCPCheckRegisterT03Entity.PACKING_REMARK;
            SAMPLE_DEPT = pHACCPCheckRegisterT03Entity.SAMPLE_DEPT;
            SAMPLE_NO = pHACCPCheckRegisterT03Entity.SAMPLE_NO;
            SAMPLE_USER = pHACCPCheckRegisterT03Entity.SAMPLE_USER;
            REMARK = pHACCPCheckRegisterT03Entity.REMARK;
            USER_YN = pHACCPCheckRegisterT03Entity.USER_YN;
            dtListCnt = pHACCPCheckRegisterT03Entity.dtListCnt;

            MISSING_CHECK = pHACCPCheckRegisterT03Entity.MISSING_CHECK;

            ERR_NO = pHACCPCheckRegisterT03Entity.ERR_NO;
            ERR_MSG = pHACCPCheckRegisterT03Entity.ERR_MSG;
            RTN_KEY = pHACCPCheckRegisterT03Entity.RTN_KEY;
            RTN_SEQ = pHACCPCheckRegisterT03Entity.RTN_SEQ;
            RTN_OTHERS = pHACCPCheckRegisterT03Entity.RTN_OTHERS;

            LANGUAGE_TYPE = pHACCPCheckRegisterT03Entity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class HACCPCheckRegisterT04Entity
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

        #region 생성자 - HACCPCheckRegisterT04Entity()

        public HACCPCheckRegisterT04Entity()
        {
        }

        #endregion

        #region 생성자 - HACCPCheckRegisterT04Entity(pHACCPCheckRegisterT04Entity)

        public HACCPCheckRegisterT04Entity(HACCPCheckRegisterT04Entity pHACCPCheckRegisterT04Entity)
        {
            CORP_CODE = pHACCPCheckRegisterT04Entity.CORP_CODE;
            CRUD = pHACCPCheckRegisterT04Entity.CRUD;
            USER_CODE = pHACCPCheckRegisterT04Entity.USER_CODE;

            pHACCPCheckRegisterT04Entity.WINDOW_NAME = WINDOW_NAME;

            HACCP_TYPE = pHACCPCheckRegisterT04Entity.HACCP_TYPE;
            DATE_FROM = pHACCPCheckRegisterT04Entity.DATE_FROM;
            DATE_TO = pHACCPCheckRegisterT04Entity.DATE_TO;
            PART_NAME = pHACCPCheckRegisterT04Entity.PART_NAME;
            HACCP_ID = pHACCPCheckRegisterT04Entity.HACCP_ID;
            HACCP_DATE = pHACCPCheckRegisterT04Entity.HACCP_DATE;
            HACCP_SEQ = pHACCPCheckRegisterT04Entity.HACCP_SEQ;
            PROCESS_NAME = pHACCPCheckRegisterT04Entity.PROCESS_NAME;
            REQUEST_DEPT = pHACCPCheckRegisterT04Entity.REQUEST_DEPT;
            CODE_NAME = pHACCPCheckRegisterT04Entity.CODE_NAME;
            INOUT_DATE = pHACCPCheckRegisterT04Entity.INOUT_DATE;
            INOUT_QTY = pHACCPCheckRegisterT04Entity.INOUT_QTY;
            PACKING_REMARK = pHACCPCheckRegisterT04Entity.PACKING_REMARK;
            SAMPLE_DEPT = pHACCPCheckRegisterT04Entity.SAMPLE_DEPT;
            SAMPLE_NO = pHACCPCheckRegisterT04Entity.SAMPLE_NO;
            SAMPLE_USER = pHACCPCheckRegisterT04Entity.SAMPLE_USER;
            REMARK = pHACCPCheckRegisterT04Entity.REMARK;
            USER_YN = pHACCPCheckRegisterT04Entity.USER_YN;
            dtListCnt = pHACCPCheckRegisterT04Entity.dtListCnt;

            MISSING_CHECK = pHACCPCheckRegisterT04Entity.MISSING_CHECK;

            ERR_NO = pHACCPCheckRegisterT04Entity.ERR_NO;
            ERR_MSG = pHACCPCheckRegisterT04Entity.ERR_MSG;
            RTN_KEY = pHACCPCheckRegisterT04Entity.RTN_KEY;
            RTN_SEQ = pHACCPCheckRegisterT04Entity.RTN_SEQ;
            RTN_OTHERS = pHACCPCheckRegisterT04Entity.RTN_OTHERS;

            LANGUAGE_TYPE = pHACCPCheckRegisterT04Entity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class HACCPCheckRegisterT05Entity
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

        #region 생성자 - HACCPCheckRegisterT05Entity()

        public HACCPCheckRegisterT05Entity()
        {
        }

        #endregion

        #region 생성자 - HACCPCheckRegisterT05Entity(pHACCPCheckRegisterT05Entity)

        public HACCPCheckRegisterT05Entity(HACCPCheckRegisterT05Entity pHACCPCheckRegisterT05Entity)
        {
            CORP_CODE = pHACCPCheckRegisterT05Entity.CORP_CODE;
            CRUD = pHACCPCheckRegisterT05Entity.CRUD;
            USER_CODE = pHACCPCheckRegisterT05Entity.USER_CODE;

            pHACCPCheckRegisterT05Entity.WINDOW_NAME = WINDOW_NAME;

            HACCP_TYPE = pHACCPCheckRegisterT05Entity.HACCP_TYPE;
            DATE_FROM = pHACCPCheckRegisterT05Entity.DATE_FROM;
            DATE_TO = pHACCPCheckRegisterT05Entity.DATE_TO;
            PART_NAME = pHACCPCheckRegisterT05Entity.PART_NAME;
            HACCP_ID = pHACCPCheckRegisterT05Entity.HACCP_ID;
            HACCP_DATE = pHACCPCheckRegisterT05Entity.HACCP_DATE;
            HACCP_SEQ = pHACCPCheckRegisterT05Entity.HACCP_SEQ;
            PROCESS_NAME = pHACCPCheckRegisterT05Entity.PROCESS_NAME;
            REQUEST_DEPT = pHACCPCheckRegisterT05Entity.REQUEST_DEPT;
            CODE_NAME = pHACCPCheckRegisterT05Entity.CODE_NAME;
            INOUT_DATE = pHACCPCheckRegisterT05Entity.INOUT_DATE;
            INOUT_QTY = pHACCPCheckRegisterT05Entity.INOUT_QTY;
            PACKING_REMARK = pHACCPCheckRegisterT05Entity.PACKING_REMARK;
            SAMPLE_DEPT = pHACCPCheckRegisterT05Entity.SAMPLE_DEPT;
            SAMPLE_NO = pHACCPCheckRegisterT05Entity.SAMPLE_NO;
            SAMPLE_USER = pHACCPCheckRegisterT05Entity.SAMPLE_USER;
            REMARK = pHACCPCheckRegisterT05Entity.REMARK;
            USER_YN = pHACCPCheckRegisterT05Entity.USER_YN;
            dtListCnt = pHACCPCheckRegisterT05Entity.dtListCnt;

            MISSING_CHECK = pHACCPCheckRegisterT05Entity.MISSING_CHECK;

            ERR_NO = pHACCPCheckRegisterT05Entity.ERR_NO;
            ERR_MSG = pHACCPCheckRegisterT05Entity.ERR_MSG;
            RTN_KEY = pHACCPCheckRegisterT05Entity.RTN_KEY;
            RTN_SEQ = pHACCPCheckRegisterT05Entity.RTN_SEQ;
            RTN_OTHERS = pHACCPCheckRegisterT05Entity.RTN_OTHERS;

            LANGUAGE_TYPE = pHACCPCheckRegisterT05Entity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class HACCPCheckRegisterT06Entity
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

        #region 생성자 - HACCPCheckRegisterT06Entity()

        public HACCPCheckRegisterT06Entity()
        {
        }

        #endregion

        #region 생성자 - HACCPCheckRegisterT06Entity(pHACCPCheckRegisterT06Entity)

        public HACCPCheckRegisterT06Entity(HACCPCheckRegisterT06Entity pHACCPCheckRegisterT06Entity)
        {
            CORP_CODE = pHACCPCheckRegisterT06Entity.CORP_CODE;
            CRUD = pHACCPCheckRegisterT06Entity.CRUD;
            USER_CODE = pHACCPCheckRegisterT06Entity.USER_CODE;

            pHACCPCheckRegisterT06Entity.WINDOW_NAME = WINDOW_NAME;

            HACCP_TYPE = pHACCPCheckRegisterT06Entity.HACCP_TYPE;
            DATE_FROM = pHACCPCheckRegisterT06Entity.DATE_FROM;
            DATE_TO = pHACCPCheckRegisterT06Entity.DATE_TO;
            PART_NAME = pHACCPCheckRegisterT06Entity.PART_NAME;
            HACCP_ID = pHACCPCheckRegisterT06Entity.HACCP_ID;
            HACCP_DATE = pHACCPCheckRegisterT06Entity.HACCP_DATE;
            HACCP_SEQ = pHACCPCheckRegisterT06Entity.HACCP_SEQ;
            PROCESS_NAME = pHACCPCheckRegisterT06Entity.PROCESS_NAME;
            REQUEST_DEPT = pHACCPCheckRegisterT06Entity.REQUEST_DEPT;
            CODE_NAME = pHACCPCheckRegisterT06Entity.CODE_NAME;
            INOUT_DATE = pHACCPCheckRegisterT06Entity.INOUT_DATE;
            INOUT_QTY = pHACCPCheckRegisterT06Entity.INOUT_QTY;
            PACKING_REMARK = pHACCPCheckRegisterT06Entity.PACKING_REMARK;
            SAMPLE_DEPT = pHACCPCheckRegisterT06Entity.SAMPLE_DEPT;
            SAMPLE_NO = pHACCPCheckRegisterT06Entity.SAMPLE_NO;
            SAMPLE_USER = pHACCPCheckRegisterT06Entity.SAMPLE_USER;
            REMARK = pHACCPCheckRegisterT06Entity.REMARK;
            USER_YN = pHACCPCheckRegisterT06Entity.USER_YN;
            dtListCnt = pHACCPCheckRegisterT06Entity.dtListCnt;

            MISSING_CHECK = pHACCPCheckRegisterT06Entity.MISSING_CHECK;

            ERR_NO = pHACCPCheckRegisterT06Entity.ERR_NO;
            ERR_MSG = pHACCPCheckRegisterT06Entity.ERR_MSG;
            RTN_KEY = pHACCPCheckRegisterT06Entity.RTN_KEY;
            RTN_SEQ = pHACCPCheckRegisterT06Entity.RTN_SEQ;
            RTN_OTHERS = pHACCPCheckRegisterT06Entity.RTN_OTHERS;

            LANGUAGE_TYPE = pHACCPCheckRegisterT06Entity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class HACCPCheckRegisterT07Entity
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

        #region 생성자 - HACCPCheckRegisterT07Entity()

        public HACCPCheckRegisterT07Entity()
        {
        }

        #endregion

        #region 생성자 - HACCPCheckRegisterT07Entity(pHACCPCheckRegisterT07Entity)

        public HACCPCheckRegisterT07Entity(HACCPCheckRegisterT07Entity pHACCPCheckRegisterT07Entity)
        {
            CORP_CODE = pHACCPCheckRegisterT07Entity.CORP_CODE;
            CRUD = pHACCPCheckRegisterT07Entity.CRUD;
            USER_CODE = pHACCPCheckRegisterT07Entity.USER_CODE;

            pHACCPCheckRegisterT07Entity.WINDOW_NAME = WINDOW_NAME;

            HACCP_TYPE = pHACCPCheckRegisterT07Entity.HACCP_TYPE;
            DATE_FROM = pHACCPCheckRegisterT07Entity.DATE_FROM;
            DATE_TO = pHACCPCheckRegisterT07Entity.DATE_TO;
            PART_NAME = pHACCPCheckRegisterT07Entity.PART_NAME;
            HACCP_ID = pHACCPCheckRegisterT07Entity.HACCP_ID;
            HACCP_DATE = pHACCPCheckRegisterT07Entity.HACCP_DATE;
            HACCP_SEQ = pHACCPCheckRegisterT07Entity.HACCP_SEQ;
            PROCESS_NAME = pHACCPCheckRegisterT07Entity.PROCESS_NAME;
            REQUEST_DEPT = pHACCPCheckRegisterT07Entity.REQUEST_DEPT;
            CODE_NAME = pHACCPCheckRegisterT07Entity.CODE_NAME;
            INOUT_DATE = pHACCPCheckRegisterT07Entity.INOUT_DATE;
            INOUT_QTY = pHACCPCheckRegisterT07Entity.INOUT_QTY;
            PACKING_REMARK = pHACCPCheckRegisterT07Entity.PACKING_REMARK;
            SAMPLE_DEPT = pHACCPCheckRegisterT07Entity.SAMPLE_DEPT;
            SAMPLE_NO = pHACCPCheckRegisterT07Entity.SAMPLE_NO;
            SAMPLE_USER = pHACCPCheckRegisterT07Entity.SAMPLE_USER;
            REMARK = pHACCPCheckRegisterT07Entity.REMARK;
            USER_YN = pHACCPCheckRegisterT07Entity.USER_YN;
            dtListCnt = pHACCPCheckRegisterT07Entity.dtListCnt;

            MISSING_CHECK = pHACCPCheckRegisterT07Entity.MISSING_CHECK;

            ERR_NO = pHACCPCheckRegisterT07Entity.ERR_NO;
            ERR_MSG = pHACCPCheckRegisterT07Entity.ERR_MSG;
            RTN_KEY = pHACCPCheckRegisterT07Entity.RTN_KEY;
            RTN_SEQ = pHACCPCheckRegisterT07Entity.RTN_SEQ;
            RTN_OTHERS = pHACCPCheckRegisterT07Entity.RTN_OTHERS;

            LANGUAGE_TYPE = pHACCPCheckRegisterT07Entity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class HACCPCheckRegisterT08Entity
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

        #region 생성자 - HACCPCheckRegisterT08Entity()

        public HACCPCheckRegisterT08Entity()
        {
        }

        #endregion

        #region 생성자 - HACCPCheckRegisterT08Entity(pHACCPCheckRegisterT08Entity)

        public HACCPCheckRegisterT08Entity(HACCPCheckRegisterT08Entity pHACCPCheckRegisterT08Entity)
        {
            CORP_CODE = pHACCPCheckRegisterT08Entity.CORP_CODE;
            CRUD = pHACCPCheckRegisterT08Entity.CRUD;
            USER_CODE = pHACCPCheckRegisterT08Entity.USER_CODE;

            pHACCPCheckRegisterT08Entity.WINDOW_NAME = WINDOW_NAME;

            HACCP_TYPE = pHACCPCheckRegisterT08Entity.HACCP_TYPE;
            DATE_FROM = pHACCPCheckRegisterT08Entity.DATE_FROM;
            DATE_TO = pHACCPCheckRegisterT08Entity.DATE_TO;
            PART_NAME = pHACCPCheckRegisterT08Entity.PART_NAME;
            HACCP_ID = pHACCPCheckRegisterT08Entity.HACCP_ID;
            HACCP_DATE = pHACCPCheckRegisterT08Entity.HACCP_DATE;
            HACCP_SEQ = pHACCPCheckRegisterT08Entity.HACCP_SEQ;
            PROCESS_NAME = pHACCPCheckRegisterT08Entity.PROCESS_NAME;
            REQUEST_DEPT = pHACCPCheckRegisterT08Entity.REQUEST_DEPT;
            CODE_NAME = pHACCPCheckRegisterT08Entity.CODE_NAME;
            INOUT_DATE = pHACCPCheckRegisterT08Entity.INOUT_DATE;
            INOUT_QTY = pHACCPCheckRegisterT08Entity.INOUT_QTY;
            PACKING_REMARK = pHACCPCheckRegisterT08Entity.PACKING_REMARK;
            SAMPLE_DEPT = pHACCPCheckRegisterT08Entity.SAMPLE_DEPT;
            SAMPLE_NO = pHACCPCheckRegisterT08Entity.SAMPLE_NO;
            SAMPLE_USER = pHACCPCheckRegisterT08Entity.SAMPLE_USER;
            REMARK = pHACCPCheckRegisterT08Entity.REMARK;
            USER_YN = pHACCPCheckRegisterT08Entity.USER_YN;
            dtListCnt = pHACCPCheckRegisterT08Entity.dtListCnt;

            MISSING_CHECK = pHACCPCheckRegisterT08Entity.MISSING_CHECK;

            ERR_NO = pHACCPCheckRegisterT08Entity.ERR_NO;
            ERR_MSG = pHACCPCheckRegisterT08Entity.ERR_MSG;
            RTN_KEY = pHACCPCheckRegisterT08Entity.RTN_KEY;
            RTN_SEQ = pHACCPCheckRegisterT08Entity.RTN_SEQ;
            RTN_OTHERS = pHACCPCheckRegisterT08Entity.RTN_OTHERS;

            LANGUAGE_TYPE = pHACCPCheckRegisterT08Entity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class HACCPCheckRegisterT09Entity
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

        #region 생성자 - HACCPCheckRegisterT09Entity()

        public HACCPCheckRegisterT09Entity()
        {
        }

        #endregion

        #region 생성자 - HACCPCheckRegisterT09Entity(pHACCPCheckRegisterT09Entity)

        public HACCPCheckRegisterT09Entity(HACCPCheckRegisterT09Entity pHACCPCheckRegisterT09Entity)
        {
            CORP_CODE = pHACCPCheckRegisterT09Entity.CORP_CODE;
            CRUD = pHACCPCheckRegisterT09Entity.CRUD;
            USER_CODE = pHACCPCheckRegisterT09Entity.USER_CODE;

            pHACCPCheckRegisterT09Entity.WINDOW_NAME = WINDOW_NAME;

            HACCP_TYPE = pHACCPCheckRegisterT09Entity.HACCP_TYPE;
            DATE_FROM = pHACCPCheckRegisterT09Entity.DATE_FROM;
            DATE_TO = pHACCPCheckRegisterT09Entity.DATE_TO;
            PART_NAME = pHACCPCheckRegisterT09Entity.PART_NAME;
            HACCP_ID = pHACCPCheckRegisterT09Entity.HACCP_ID;
            HACCP_DATE = pHACCPCheckRegisterT09Entity.HACCP_DATE;
            HACCP_SEQ = pHACCPCheckRegisterT09Entity.HACCP_SEQ;
            PROCESS_NAME = pHACCPCheckRegisterT09Entity.PROCESS_NAME;
            REQUEST_DEPT = pHACCPCheckRegisterT09Entity.REQUEST_DEPT;
            CODE_NAME = pHACCPCheckRegisterT09Entity.CODE_NAME;
            INOUT_DATE = pHACCPCheckRegisterT09Entity.INOUT_DATE;
            INOUT_QTY = pHACCPCheckRegisterT09Entity.INOUT_QTY;
            PACKING_REMARK = pHACCPCheckRegisterT09Entity.PACKING_REMARK;
            SAMPLE_DEPT = pHACCPCheckRegisterT09Entity.SAMPLE_DEPT;
            SAMPLE_NO = pHACCPCheckRegisterT09Entity.SAMPLE_NO;
            SAMPLE_USER = pHACCPCheckRegisterT09Entity.SAMPLE_USER;
            REMARK = pHACCPCheckRegisterT09Entity.REMARK;
            USER_YN = pHACCPCheckRegisterT09Entity.USER_YN;
            dtListCnt = pHACCPCheckRegisterT09Entity.dtListCnt;

            MISSING_CHECK = pHACCPCheckRegisterT09Entity.MISSING_CHECK;

            ERR_NO = pHACCPCheckRegisterT09Entity.ERR_NO;
            ERR_MSG = pHACCPCheckRegisterT09Entity.ERR_MSG;
            RTN_KEY = pHACCPCheckRegisterT09Entity.RTN_KEY;
            RTN_SEQ = pHACCPCheckRegisterT09Entity.RTN_SEQ;
            RTN_OTHERS = pHACCPCheckRegisterT09Entity.RTN_OTHERS;

            LANGUAGE_TYPE = pHACCPCheckRegisterT09Entity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class BarcodeLabelPrintEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String USER_NAME { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE



        public String WINDOW_NAME { get; set; }
        public String LABEL_CODE { get; set; }
        public String LABEL_NAME { get; set; }
        public String PART_CODE { get; set; }
        public String PART_NAME { get; set; }
        public String PART_TYPE { get; set; }
        public String PROCESS_CODE_MST { get; set; } // LANGUAGE_TYPE

        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        public String CMD { get; set; }
        public String USE_YN { get; set; }
        public String APPROVAL_YN { get; set; }
        public String INSPECT_DATE { get; set; }
        public String INSPECT_ID { get; set; }
        public String VEND_CODE { get; set; }
        public String STORE_TEMP { get; set; }
        public String SPECIFIC_GRAVITY { get; set; }
        public String SPECIFIC_GRAVITY_CODE { get; set; }
        public String END_DATE { get; set; }
        public String INSPECT_NO { get; set; }
        public String MAKE_NO { get; set; }
        public String MAKE_VEND { get; set; }
        public String INOUT_ID { get; set; }
        public String REMARK { get; set; } // 리턴 기타 값

        public String PART_BARCODE { get; set; }
        public String PRINT_DATE { get; set; }
        public String PRINT_SEQ { get; set; }
        public String PRINT_CODE { get; set; }
        public String PART_QTY { get; set; }

        public String TERMINAL_NAME { get; set; }
        public String TERMINAL_CODE { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - BarcodeLabelPrintEntity()

        public BarcodeLabelPrintEntity()
        {
        }

        #endregion

        #region 생성자 - BarcodeLabelPrintEntity(pBarcodeLabelPrintEntity)

        public BarcodeLabelPrintEntity(BarcodeLabelPrintEntity pBarcodeLabelPrintEntity)
        {
            CORP_CODE = pBarcodeLabelPrintEntity.CORP_CODE;
            CRUD = pBarcodeLabelPrintEntity.CRUD;
            USER_CODE = pBarcodeLabelPrintEntity.USER_CODE;
            USER_NAME = pBarcodeLabelPrintEntity.USER_NAME;
            LANGUAGE_TYPE = pBarcodeLabelPrintEntity.LANGUAGE_TYPE;

            pBarcodeLabelPrintEntity.LABEL_CODE = LABEL_CODE;
            pBarcodeLabelPrintEntity.LABEL_NAME = LABEL_NAME;
            pBarcodeLabelPrintEntity.PART_CODE = PART_CODE;
            pBarcodeLabelPrintEntity.PART_NAME = PART_NAME;
            pBarcodeLabelPrintEntity.DATE_FROM = DATE_FROM;
            pBarcodeLabelPrintEntity.DATE_TO = DATE_TO;
            pBarcodeLabelPrintEntity.CMD = CMD;
            pBarcodeLabelPrintEntity.USE_YN = USE_YN;

            pBarcodeLabelPrintEntity.VEND_CODE = VEND_CODE;

            pBarcodeLabelPrintEntity.PART_BARCODE = PART_BARCODE;
            pBarcodeLabelPrintEntity.PRINT_DATE = PRINT_DATE;
            pBarcodeLabelPrintEntity.PRINT_SEQ = PRINT_SEQ;
            pBarcodeLabelPrintEntity.PRINT_CODE = PRINT_CODE;
            pBarcodeLabelPrintEntity.PART_QTY = PART_QTY;
            pBarcodeLabelPrintEntity.PART_TYPE = PART_TYPE;
            pBarcodeLabelPrintEntity.APPROVAL_YN = APPROVAL_YN;
            pBarcodeLabelPrintEntity.PROCESS_CODE_MST = PROCESS_CODE_MST;
            pBarcodeLabelPrintEntity.TERMINAL_NAME = TERMINAL_NAME;
            pBarcodeLabelPrintEntity.TERMINAL_CODE = TERMINAL_CODE;

            ERR_NO = pBarcodeLabelPrintEntity.ERR_NO;
            ERR_MSG = pBarcodeLabelPrintEntity.ERR_MSG;
            RTN_KEY = pBarcodeLabelPrintEntity.RTN_KEY;
            RTN_SEQ = pBarcodeLabelPrintEntity.RTN_SEQ;
            RTN_OTHERS = pBarcodeLabelPrintEntity.RTN_OTHERS;

            pBarcodeLabelPrintEntity.INSPECT_DATE = INSPECT_DATE;
            pBarcodeLabelPrintEntity.INSPECT_ID = INSPECT_ID;
            pBarcodeLabelPrintEntity.VEND_CODE = VEND_CODE;
            pBarcodeLabelPrintEntity.STORE_TEMP = STORE_TEMP;
            pBarcodeLabelPrintEntity.SPECIFIC_GRAVITY = SPECIFIC_GRAVITY;
            pBarcodeLabelPrintEntity.SPECIFIC_GRAVITY_CODE = SPECIFIC_GRAVITY_CODE;
            pBarcodeLabelPrintEntity.END_DATE = END_DATE;
            pBarcodeLabelPrintEntity.INSPECT_NO = INSPECT_NO;
            pBarcodeLabelPrintEntity.MAKE_NO = MAKE_NO;
            pBarcodeLabelPrintEntity.MAKE_VEND = MAKE_VEND;
            pBarcodeLabelPrintEntity.REMARK = REMARK;
            pBarcodeLabelPrintEntity.INOUT_ID = INOUT_ID;
            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ProductBadMonthStatusEntity
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

        #region 생성자 - ProductBadMonthStatusEntity()

        public ProductBadMonthStatusEntity()
        {
        }

        #endregion

        #region 생성자 - ProductBadMonthStatusEntity(pProductBadMonthStatusEntity)

        public ProductBadMonthStatusEntity(ProductBadMonthStatusEntity pProductBadMonthStatusEntity)
        {
            CORP_CODE = pProductBadMonthStatusEntity.CORP_CODE;
            CRUD = pProductBadMonthStatusEntity.CRUD;
            USER_CODE = pProductBadMonthStatusEntity.USER_CODE;
            LANGUAGE_TYPE = pProductBadMonthStatusEntity.LANGUAGE_TYPE;
            DATE = pProductBadMonthStatusEntity.DATE;
            ERR_NO = pProductBadMonthStatusEntity.ERR_NO;
            ERR_MSG = pProductBadMonthStatusEntity.ERR_MSG;
            RTN_KEY = pProductBadMonthStatusEntity.RTN_KEY;
            RTN_SEQ = pProductBadMonthStatusEntity.RTN_SEQ;
            RTN_OTHERS = pProductBadMonthStatusEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class FirstMiddleLastInspectRegister_T01Entity
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

        public String ORDER_ID { get; set; }
        public String FIRSTMIDDLELAST { get; set; }
        public String APPEARANCE_1 { get; set; }
        public String APPEARANCE_2 { get; set; }
        public String APPEARANCE_3 { get; set; }
        public String APPEARANCE_4 { get; set; }
        public String APPEARANCE_5 { get; set; }
        public String APPEARANCE_6 { get; set; }
        public String APPEARANCE_7 { get; set; }
        public String APPEARANCE_8 { get; set; }
        public String APPEARANCE_9 { get; set; }
        public String CARVE { get; set; }
        public String COLOR { get; set; }
        public String WEIGHT { get; set; }
        public String CF { get; set; }
        public String FINAL { get; set; }
           
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

        #region 생성자 - FirstMiddleLastInspectRegister_T01Entity()

        public FirstMiddleLastInspectRegister_T01Entity()
        {

        }

        #endregion

        #region 생성자 - FirstMiddleLastInspectRegister_T01Entity(pFirstMiddleLastInspectRegister_T01Entity)

        public FirstMiddleLastInspectRegister_T01Entity(FirstMiddleLastInspectRegister_T01Entity pFirstMiddleLastInspectRegister_T01Entity)
        {
            CORP_CODE = pFirstMiddleLastInspectRegister_T01Entity.CORP_CODE;
            CRUD = pFirstMiddleLastInspectRegister_T01Entity.CRUD;
            USER_CODE = pFirstMiddleLastInspectRegister_T01Entity.USER_CODE;
            LANGUAGE_TYPE = pFirstMiddleLastInspectRegister_T01Entity.LANGUAGE_TYPE;

            pFirstMiddleLastInspectRegister_T01Entity.DATE_FROM = DATE_FROM;
            pFirstMiddleLastInspectRegister_T01Entity.DATE_TO = DATE_TO;
            pFirstMiddleLastInspectRegister_T01Entity.CONTRACT_ID = CONTRACT_ID;
            pFirstMiddleLastInspectRegister_T01Entity.PART_NAME = PART_NAME;
            pFirstMiddleLastInspectRegister_T01Entity.VEND_CODE = VEND_CODE;
            pFirstMiddleLastInspectRegister_T01Entity.VEND_NAME = VEND_NAME;
            pFirstMiddleLastInspectRegister_T01Entity.CONTRACT_ID = CONTRACT_ID;

            pFirstMiddleLastInspectRegister_T01Entity.CONTRACT_DATE = CONTRACT_DATE;
            pFirstMiddleLastInspectRegister_T01Entity.CONTRACT_QTY = CONTRACT_QTY;
            pFirstMiddleLastInspectRegister_T01Entity.DELIVERY_DATE = DELIVERY_DATE;
            pFirstMiddleLastInspectRegister_T01Entity.DELIVERY_LOCATION = DELIVERY_LOCATION;
            pFirstMiddleLastInspectRegister_T01Entity.UNITCOST = UNITCOST;
            pFirstMiddleLastInspectRegister_T01Entity.COST = COST;
            pFirstMiddleLastInspectRegister_T01Entity.REMARK = REMARK;
            pFirstMiddleLastInspectRegister_T01Entity.USE_YN = USE_YN;
            pFirstMiddleLastInspectRegister_T01Entity.USE_YN = UNIT_CODE;

            pFirstMiddleLastInspectRegister_T01Entity.ORDER_ID = ORDER_ID;

            ERR_NO = pFirstMiddleLastInspectRegister_T01Entity.ERR_NO;
            ERR_MSG = pFirstMiddleLastInspectRegister_T01Entity.ERR_MSG;
            RTN_KEY = pFirstMiddleLastInspectRegister_T01Entity.RTN_KEY;
            RTN_SEQ = pFirstMiddleLastInspectRegister_T01Entity.RTN_SEQ;
            RTN_AQ = pFirstMiddleLastInspectRegister_T01Entity.RTN_AQ;
            RTN_SQ = pFirstMiddleLastInspectRegister_T01Entity.RTN_SQ;
            RTN_OTHERS = pFirstMiddleLastInspectRegister_T01Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class FirstMiddleLastInspectRegister_T02Entity
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
        public String PRODUCTION_ORDER_ID { get; set; }
        public String FIRSTMIDDLELAST_GUBN { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - FirstMiddleLastInspectRegister_T02Entity()

        public FirstMiddleLastInspectRegister_T02Entity()
        {
        }

        #endregion

        #region 생성자 - FirstMiddleLastInspectRegister_T02Entity(pFirstMiddleLastInspectRegister_T02Entity)

        public FirstMiddleLastInspectRegister_T02Entity(FirstMiddleLastInspectRegister_T02Entity pFirstMiddleLastInspectRegister_T02Entity)
        {
            CORP_CODE = pFirstMiddleLastInspectRegister_T02Entity.CORP_CODE;
            CRUD = pFirstMiddleLastInspectRegister_T02Entity.CRUD;
            USER_CODE = pFirstMiddleLastInspectRegister_T02Entity.USER_CODE;

            LANGUAGE_TYPE = pFirstMiddleLastInspectRegister_T02Entity.LANGUAGE_TYPE;


            pFirstMiddleLastInspectRegister_T02Entity.PART_TYPE = PART_TYPE;
            pFirstMiddleLastInspectRegister_T02Entity.PART_NAME = PART_NAME;
            pFirstMiddleLastInspectRegister_T02Entity.PART_CODE = PART_CODE;
            pFirstMiddleLastInspectRegister_T02Entity.VEND_PART_CODE = PART_CODE;
            pFirstMiddleLastInspectRegister_T02Entity.CHECK_CYCLE = CHECK_CYCLE;
            pFirstMiddleLastInspectRegister_T02Entity.EQUIPMENT_CODE = EQUIPMENT_CODE;
            pFirstMiddleLastInspectRegister_T02Entity.CHECK_DATE = CHECK_DATE;
            pFirstMiddleLastInspectRegister_T02Entity.FIRSTMIDDLELAST_GUBN = FIRSTMIDDLELAST_GUBN;
            pFirstMiddleLastInspectRegister_T02Entity.PRODUCTION_ORDER_ID = PRODUCTION_ORDER_ID;

            ERR_NO = pFirstMiddleLastInspectRegister_T02Entity.ERR_NO;
            ERR_MSG = pFirstMiddleLastInspectRegister_T02Entity.ERR_MSG;
            RTN_KEY = pFirstMiddleLastInspectRegister_T02Entity.RTN_KEY;
            RTN_SEQ = pFirstMiddleLastInspectRegister_T02Entity.RTN_SEQ;
            RTN_OTHERS = pFirstMiddleLastInspectRegister_T02Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }


    public class ImportInspectRegisterEntity
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

        public String MI_MEASURES { get; set; }
        public String MOISTURE_MEASERES { get; set; }
        public String LOT_NO { get; set; }
        public String INSPECT_DATE { get; set; }
        public String ORDER_ID { get; set; }
        public String INSPECT_ID { get; set; }
        public String INSPECT_SEQ { get; set; }
        

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

        #region 생성자 - ImportInspectRegisterEntity()

        public ImportInspectRegisterEntity()
        {

        }

        #endregion

        #region 생성자 - ContractMstRegisterEntity(pContractMstRegisterEntity)

        public ImportInspectRegisterEntity(ImportInspectRegisterEntity pImportInspectRegisterEntity)
        {
            CORP_CODE = pImportInspectRegisterEntity.CORP_CODE;
            CRUD = pImportInspectRegisterEntity.CRUD;
            USER_CODE = pImportInspectRegisterEntity.USER_CODE;
            LANGUAGE_TYPE = pImportInspectRegisterEntity.LANGUAGE_TYPE;

            pImportInspectRegisterEntity.DATE_FROM = DATE_FROM;
            pImportInspectRegisterEntity.DATE_TO = DATE_TO;
            pImportInspectRegisterEntity.CONTRACT_ID = CONTRACT_ID;
            pImportInspectRegisterEntity.PART_NAME = PART_NAME;
            pImportInspectRegisterEntity.VEND_CODE = VEND_CODE;
            pImportInspectRegisterEntity.VEND_NAME = VEND_NAME;
            pImportInspectRegisterEntity.CONTRACT_ID = CONTRACT_ID;

            pImportInspectRegisterEntity.CONTRACT_DATE = CONTRACT_DATE;
            pImportInspectRegisterEntity.CONTRACT_QTY = CONTRACT_QTY;
            pImportInspectRegisterEntity.DELIVERY_DATE = DELIVERY_DATE;
            pImportInspectRegisterEntity.DELIVERY_LOCATION = DELIVERY_LOCATION;
            pImportInspectRegisterEntity.UNITCOST = UNITCOST;
            pImportInspectRegisterEntity.COST = COST;
            pImportInspectRegisterEntity.REMARK = REMARK;
            pImportInspectRegisterEntity.USE_YN = USE_YN;
            pImportInspectRegisterEntity.USE_YN = UNIT_CODE;
            pImportInspectRegisterEntity.MI_MEASURES = MI_MEASURES;
            pImportInspectRegisterEntity.MOISTURE_MEASERES = MOISTURE_MEASERES;
            pImportInspectRegisterEntity.LOT_NO = LOT_NO;
            pImportInspectRegisterEntity.INSPECT_DATE = INSPECT_DATE;
            pImportInspectRegisterEntity.ORDER_ID = ORDER_ID;
            pImportInspectRegisterEntity.INSPECT_ID = INSPECT_ID;
            pImportInspectRegisterEntity.INSPECT_SEQ = INSPECT_SEQ;

            ERR_NO = pImportInspectRegisterEntity.ERR_NO;
            ERR_MSG = pImportInspectRegisterEntity.ERR_MSG;
            RTN_KEY = pImportInspectRegisterEntity.RTN_KEY;
            RTN_SEQ = pImportInspectRegisterEntity.RTN_SEQ;
            RTN_AQ = pImportInspectRegisterEntity.RTN_AQ;
            RTN_SQ = pImportInspectRegisterEntity.RTN_SQ;
            RTN_OTHERS = pImportInspectRegisterEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ucProductionOrderInfoPopup_T08_Entity
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
        public String TERMINAL_CODE { get; set; }
        public String PROCESS_CODE { get; set; }

        #endregion

        #region 생성자 - ucProductionOrderInfoPopup_T08_Entity()

        public ucProductionOrderInfoPopup_T08_Entity()
        {
        }

        #endregion

        #region 생성자 - ucProductionOrderInfoPopup_T08_Entity(ucProductionOrderInfoPopup_T08_Entity pucProductionOrderInfoPopup_T08_Entity)

        public ucProductionOrderInfoPopup_T08_Entity(ucProductionOrderInfoPopup_T08_Entity pucProductionOrderInfoPopup_T08_Entity)
        {
            CORP_CODE = pucProductionOrderInfoPopup_T08_Entity.CORP_CODE;
            CRUD = pucProductionOrderInfoPopup_T08_Entity.CRUD;
            USER_CODE = pucProductionOrderInfoPopup_T08_Entity.USER_CODE;
            LANGUAGE_TYPE = pucProductionOrderInfoPopup_T08_Entity.LANGUAGE_TYPE;

            ERR_NO = pucProductionOrderInfoPopup_T08_Entity.ERR_NO;
            ERR_MSG = pucProductionOrderInfoPopup_T08_Entity.ERR_MSG;
            RTN_KEY = pucProductionOrderInfoPopup_T08_Entity.RTN_KEY;
            RTN_SEQ = pucProductionOrderInfoPopup_T08_Entity.RTN_SEQ;
            RTN_AQ = pucProductionOrderInfoPopup_T08_Entity.RTN_AQ;
            RTN_SQ = pucProductionOrderInfoPopup_T08_Entity.RTN_SQ;
            RTN_OTHERS = pucProductionOrderInfoPopup_T08_Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            DATE_FROM = pucProductionOrderInfoPopup_T08_Entity.DATE_FROM;
            DATE_TO = pucProductionOrderInfoPopup_T08_Entity.DATE_TO;
            PART_CODE = pucProductionOrderInfoPopup_T08_Entity.PART_CODE;
            PART_NAME = pucProductionOrderInfoPopup_T08_Entity.PART_NAME;
            PLAN_ORDER_ID = pucProductionOrderInfoPopup_T08_Entity.PLAN_ORDER_ID;

        }

        #endregion
    }

    public class QualityAnalsisEntity
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

        #region 생성자 - QualityAnalsiEntity()

        public QualityAnalsisEntity()
        {
        }

        #endregion

        #region 생성자 - QualityAnalsiEntity(QualityAnalsiEntity pQualityAnalsiEntity)

        public QualityAnalsisEntity(QualityAnalsisEntity pQualityAnalsisEntity)
        {
            CORP_CODE = pQualityAnalsisEntity.CORP_CODE;
            CRUD = pQualityAnalsisEntity.CRUD;
            USER_CODE = pQualityAnalsisEntity.USER_CODE;
            WINDOW_NAME = pQualityAnalsisEntity.WINDOW_NAME;
            LANGUAGE_TYPE = pQualityAnalsisEntity.LANGUAGE_TYPE;

            DATE_FROM = pQualityAnalsisEntity.DATE_FROM;
            DATE_TO = pQualityAnalsisEntity.DATE_TO;
            PRODUCTION_ORDER_ID = pQualityAnalsisEntity.PRODUCTION_ORDER_ID;
            PART_CODE = pQualityAnalsisEntity.PART_CODE;
            PART_NAME = pQualityAnalsisEntity.PART_NAME;
            PRODUCTION_PLAN_ID = pQualityAnalsisEntity.PRODUCTION_PLAN_ID;
            PROCESS_CODE_MST = pQualityAnalsisEntity.PROCESS_CODE_MST;
            PROCESS_CODE = pQualityAnalsisEntity.PROCESS_CODE;
            CODE_GUBN = pQualityAnalsisEntity.CODE_GUBN;
            USE_YN = pQualityAnalsisEntity.USE_YN;
            COMPLETE_YN = pQualityAnalsisEntity.COMPLETE_YN;
            TERMINAL_CODE = pQualityAnalsisEntity.TERMINAL_CODE;
            TERMINAL_NAME = pQualityAnalsisEntity.TERMINAL_NAME;
            CHECK_LIST = pQualityAnalsisEntity.CHECK_LIST;

            ERR_NO = pQualityAnalsisEntity.ERR_NO;
            ERR_MSG = pQualityAnalsisEntity.ERR_MSG;
            RTN_KEY = pQualityAnalsisEntity.RTN_KEY;
            RTN_SEQ = pQualityAnalsisEntity.RTN_SEQ;
            RTN_OTHERS = pQualityAnalsisEntity.RTN_OTHERS;


            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class MaterialInspectRegister_T02Entity
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
        public String USER_YN { get; set; }
        public String FILE_NAME { get; set; }

        public int dtListCnt { get; set; }

        #endregion

        #region 생성자 - MaterialInspectRegister_T02Entity()

        public MaterialInspectRegister_T02Entity()
        {
        }

        #endregion

        #region 생성자 - MaterialInspectRegister_T02Entity(pMaterialInspectRegister_T02Entity)

        public MaterialInspectRegister_T02Entity(MaterialInspectRegister_T02Entity pMaterialInspectRegister_T02Entity)
        {
            CORP_CODE = pMaterialInspectRegister_T02Entity.CORP_CODE;
            CRUD = pMaterialInspectRegister_T02Entity.CRUD;
            USER_CODE = pMaterialInspectRegister_T02Entity.USER_CODE;

            pMaterialInspectRegister_T02Entity.WINDOW_NAME = WINDOW_NAME;

            DATE_FROM = pMaterialInspectRegister_T02Entity.DATE_FROM;
            DATE_TO = pMaterialInspectRegister_T02Entity.DATE_TO;
            PART_CODE = pMaterialInspectRegister_T02Entity.PART_CODE;
            PART_NAME = pMaterialInspectRegister_T02Entity.PART_NAME;
            INSPECT_STATUS = pMaterialInspectRegister_T02Entity.INSPECT_STATUS;
            INSPECT_ID = pMaterialInspectRegister_T02Entity.INSPECT_ID;
            INSPECT__DATE = pMaterialInspectRegister_T02Entity.INSPECT__DATE;
            INSPECT_SEQ = pMaterialInspectRegister_T02Entity.INSPECT_SEQ;
            VEND_PART_CODE = pMaterialInspectRegister_T02Entity.VEND_PART_CODE;
            PART_TYPE = pMaterialInspectRegister_T02Entity.PART_TYPE;
            REFERENCE_ID = pMaterialInspectRegister_T02Entity.REFERENCE_ID;
            MAKE_VEND = pMaterialInspectRegister_T02Entity.MAKE_VEND;
            MAKE_VEND_NAME = pMaterialInspectRegister_T02Entity.MAKE_VEND_NAME;
            VEND_CODE = pMaterialInspectRegister_T02Entity.VEND_CODE;
            VEND_NAME = pMaterialInspectRegister_T02Entity.VEND_NAME;
            REQUEST_DEPT = pMaterialInspectRegister_T02Entity.REQUEST_DEPT;
            CODE_NAME = pMaterialInspectRegister_T02Entity.CODE_NAME;
            INOUT_DATE = pMaterialInspectRegister_T02Entity.INOUT_DATE;
            INOUT_QTY = pMaterialInspectRegister_T02Entity.INOUT_QTY;
            PACKING_REMARK = pMaterialInspectRegister_T02Entity.PACKING_REMARK;
            SAMPLE_DATE = pMaterialInspectRegister_T02Entity.SAMPLE_DATE;
            SAMPLE_LOCATION = pMaterialInspectRegister_T02Entity.SAMPLE_LOCATION;
            SAMPLE_USER = pMaterialInspectRegister_T02Entity.SAMPLE_USER;
            SAMPLE_METHOD = pMaterialInspectRegister_T02Entity.SAMPLE_METHOD;
            SAMPLE_QTY = pMaterialInspectRegister_T02Entity.SAMPLE_QTY;
            MAKE_NO = pMaterialInspectRegister_T02Entity.MAKE_NO;
            STANDARD = pMaterialInspectRegister_T02Entity.STANDARD;
            REQUEST_DATE = pMaterialInspectRegister_T02Entity.REQUEST_DATE;
            REQUEST_USER = pMaterialInspectRegister_T02Entity.REQUEST_USER;
            END_DATE = pMaterialInspectRegister_T02Entity.END_DATE;
            TOTAL_RESULT = pMaterialInspectRegister_T02Entity.TOTAL_RESULT;
            TOTAL_DATE = pMaterialInspectRegister_T02Entity.TOTAL_DATE;
            TOTAL_USER = pMaterialInspectRegister_T02Entity.TOTAL_USER;
            COMPLETE_YN = pMaterialInspectRegister_T02Entity.COMPLETE_YN;
            REMARK = pMaterialInspectRegister_T02Entity.REMARK;
            USER_YN = pMaterialInspectRegister_T02Entity.USER_YN;
            FILE_NAME = pMaterialInspectRegister_T02Entity.FILE_NAME;
            dtListCnt = pMaterialInspectRegister_T02Entity.dtListCnt;
            //pMaterialInspectRegister_T02Entity.PROCESS_CODE = PROCESS_CODE;

            ERR_NO = pMaterialInspectRegister_T02Entity.ERR_NO;
            ERR_MSG = pMaterialInspectRegister_T02Entity.ERR_MSG;
            RTN_KEY = pMaterialInspectRegister_T02Entity.RTN_KEY;
            RTN_SEQ = pMaterialInspectRegister_T02Entity.RTN_SEQ;
            RTN_OTHERS = pMaterialInspectRegister_T02Entity.RTN_OTHERS;

            LANGUAGE_TYPE = pMaterialInspectRegister_T02Entity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class MaterialInspectRegister_T03Entity
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
        public String USER_YN { get; set; }
        public String FILE_NAME { get; set; }

        public int dtListCnt { get; set; }

        #endregion

        #region 생성자 - MaterialInspectRegister_T03Entity()

        public MaterialInspectRegister_T03Entity()
        {
        }

        #endregion

        #region 생성자 - MaterialInspectRegister_T03Entity(pMaterialInspectRegister_T03Entity)

        public MaterialInspectRegister_T03Entity(MaterialInspectRegister_T03Entity pMaterialInspectRegister_T03Entity)
        {
            CORP_CODE = pMaterialInspectRegister_T03Entity.CORP_CODE;
            CRUD = pMaterialInspectRegister_T03Entity.CRUD;
            USER_CODE = pMaterialInspectRegister_T03Entity.USER_CODE;

            pMaterialInspectRegister_T03Entity.WINDOW_NAME = WINDOW_NAME;

            DATE_FROM = pMaterialInspectRegister_T03Entity.DATE_FROM;
            DATE_TO = pMaterialInspectRegister_T03Entity.DATE_TO;
            PART_CODE = pMaterialInspectRegister_T03Entity.PART_CODE;
            PART_NAME = pMaterialInspectRegister_T03Entity.PART_NAME;
            INSPECT_STATUS = pMaterialInspectRegister_T03Entity.INSPECT_STATUS;
            INSPECT_ID = pMaterialInspectRegister_T03Entity.INSPECT_ID;
            INSPECT__DATE = pMaterialInspectRegister_T03Entity.INSPECT__DATE;
            INSPECT_SEQ = pMaterialInspectRegister_T03Entity.INSPECT_SEQ;
            VEND_PART_CODE = pMaterialInspectRegister_T03Entity.VEND_PART_CODE;
            PART_TYPE = pMaterialInspectRegister_T03Entity.PART_TYPE;
            REFERENCE_ID = pMaterialInspectRegister_T03Entity.REFERENCE_ID;
            MAKE_VEND = pMaterialInspectRegister_T03Entity.MAKE_VEND;
            MAKE_VEND_NAME = pMaterialInspectRegister_T03Entity.MAKE_VEND_NAME;
            VEND_CODE = pMaterialInspectRegister_T03Entity.VEND_CODE;
            VEND_NAME = pMaterialInspectRegister_T03Entity.VEND_NAME;
            REQUEST_DEPT = pMaterialInspectRegister_T03Entity.REQUEST_DEPT;
            CODE_NAME = pMaterialInspectRegister_T03Entity.CODE_NAME;
            INOUT_DATE = pMaterialInspectRegister_T03Entity.INOUT_DATE;
            INOUT_QTY = pMaterialInspectRegister_T03Entity.INOUT_QTY;
            PACKING_REMARK = pMaterialInspectRegister_T03Entity.PACKING_REMARK;
            SAMPLE_DATE = pMaterialInspectRegister_T03Entity.SAMPLE_DATE;
            SAMPLE_LOCATION = pMaterialInspectRegister_T03Entity.SAMPLE_LOCATION;
            SAMPLE_USER = pMaterialInspectRegister_T03Entity.SAMPLE_USER;
            SAMPLE_METHOD = pMaterialInspectRegister_T03Entity.SAMPLE_METHOD;
            SAMPLE_QTY = pMaterialInspectRegister_T03Entity.SAMPLE_QTY;
            MAKE_NO = pMaterialInspectRegister_T03Entity.MAKE_NO;
            STANDARD = pMaterialInspectRegister_T03Entity.STANDARD;
            REQUEST_DATE = pMaterialInspectRegister_T03Entity.REQUEST_DATE;
            REQUEST_USER = pMaterialInspectRegister_T03Entity.REQUEST_USER;
            END_DATE = pMaterialInspectRegister_T03Entity.END_DATE;
            TOTAL_RESULT = pMaterialInspectRegister_T03Entity.TOTAL_RESULT;
            TOTAL_DATE = pMaterialInspectRegister_T03Entity.TOTAL_DATE;
            TOTAL_USER = pMaterialInspectRegister_T03Entity.TOTAL_USER;
            COMPLETE_YN = pMaterialInspectRegister_T03Entity.COMPLETE_YN;
            REMARK = pMaterialInspectRegister_T03Entity.REMARK;
            USER_YN = pMaterialInspectRegister_T03Entity.USER_YN;
            FILE_NAME = pMaterialInspectRegister_T03Entity.FILE_NAME;
            dtListCnt = pMaterialInspectRegister_T03Entity.dtListCnt;
            //pMaterialInspectRegister_T03Entity.PROCESS_CODE = PROCESS_CODE;

            ERR_NO = pMaterialInspectRegister_T03Entity.ERR_NO;
            ERR_MSG = pMaterialInspectRegister_T03Entity.ERR_MSG;
            RTN_KEY = pMaterialInspectRegister_T03Entity.RTN_KEY;
            RTN_SEQ = pMaterialInspectRegister_T03Entity.RTN_SEQ;
            RTN_OTHERS = pMaterialInspectRegister_T03Entity.RTN_OTHERS;

            LANGUAGE_TYPE = pMaterialInspectRegister_T03Entity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }


    public class ucInspectRequestInfoPopup_T02Entity
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

        #region 생성자 - ucInspectRequestInfoPopup_T02Entity()

        public ucInspectRequestInfoPopup_T02Entity()
        {
        }

        #endregion

        #region 생성자 - ucInspectRequestInfoPopup_T02Entity(ucInspectRequestInfoPopup_T02Entity pucInspectRequestInfoPopup_T02Entity)

        public ucInspectRequestInfoPopup_T02Entity(ucInspectRequestInfoPopup_T02Entity pucInspectRequestInfoPopup_T02Entity)
        {
            CORP_CODE = pucInspectRequestInfoPopup_T02Entity.CORP_CODE;
            CRUD = pucInspectRequestInfoPopup_T02Entity.CRUD;
            USER_CODE = pucInspectRequestInfoPopup_T02Entity.USER_CODE;

            pucInspectRequestInfoPopup_T02Entity.WINDOW_NAME = WINDOW_NAME;
            LANGUAGE_TYPE = pucInspectRequestInfoPopup_T02Entity.LANGUAGE_TYPE;
            pucInspectRequestInfoPopup_T02Entity.DATE_FROM = DATE_FROM;
            pucInspectRequestInfoPopup_T02Entity.DATE_TO = DATE_TO;
            pucInspectRequestInfoPopup_T02Entity.PROCESS_CODE = PROCESS_CODE;
            pucInspectRequestInfoPopup_T02Entity.PART_TYPE = PART_TYPE;

            ERR_NO = pucInspectRequestInfoPopup_T02Entity.ERR_NO;
            ERR_MSG = pucInspectRequestInfoPopup_T02Entity.ERR_MSG;
            RTN_KEY = pucInspectRequestInfoPopup_T02Entity.RTN_KEY;
            RTN_SEQ = pucInspectRequestInfoPopup_T02Entity.RTN_SEQ;
            RTN_OTHERS = pucInspectRequestInfoPopup_T02Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class FirstMiddleLastInspectStatusEntity
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
        public String VEND_CODE { get; set; }
        public String VEND_NAME { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - FirstMiddleLastInspectStatusEntity()

        public FirstMiddleLastInspectStatusEntity()
        {
        }

        #endregion

        #region 생성자 - FirstMiddleLastInspectStatusEntity(WorkResultRegister_T02Entity pWorkResultRegister_T02Entity)

        public FirstMiddleLastInspectStatusEntity(FirstMiddleLastInspectStatusEntity pFirstMiddleLastInspectStatusEntity)
        {
            CORP_CODE = pFirstMiddleLastInspectStatusEntity.CORP_CODE;
            CRUD = pFirstMiddleLastInspectStatusEntity.CRUD;
            USER_CODE = pFirstMiddleLastInspectStatusEntity.USER_CODE;
            WINDOW_NAME = pFirstMiddleLastInspectStatusEntity.WINDOW_NAME;
            LANGUAGE_TYPE = pFirstMiddleLastInspectStatusEntity.LANGUAGE_TYPE;

            DATE_FROM = pFirstMiddleLastInspectStatusEntity.DATE_FROM;
            DATE_TO = pFirstMiddleLastInspectStatusEntity.DATE_TO;
            PRODUCTION_ORDER_ID = pFirstMiddleLastInspectStatusEntity.PRODUCTION_ORDER_ID;
            PART_CODE = pFirstMiddleLastInspectStatusEntity.PART_CODE;
            PART_NAME = pFirstMiddleLastInspectStatusEntity.PART_NAME;
            PRODUCTION_PLAN_ID = pFirstMiddleLastInspectStatusEntity.PRODUCTION_PLAN_ID;
            PROCESS_CODE_MST = pFirstMiddleLastInspectStatusEntity.PROCESS_CODE_MST;
            PROCESS_CODE = pFirstMiddleLastInspectStatusEntity.PROCESS_CODE;
            CODE_GUBN = pFirstMiddleLastInspectStatusEntity.CODE_GUBN;
            USE_YN = pFirstMiddleLastInspectStatusEntity.USE_YN;
            COMPLETE_YN = pFirstMiddleLastInspectStatusEntity.COMPLETE_YN;
            TERMINAL_CODE = pFirstMiddleLastInspectStatusEntity.TERMINAL_CODE;
            TERMINAL_NAME = pFirstMiddleLastInspectStatusEntity.TERMINAL_NAME;
            CHECK_LIST = pFirstMiddleLastInspectStatusEntity.CHECK_LIST;

            ERR_NO = pFirstMiddleLastInspectStatusEntity.ERR_NO;
            ERR_MSG = pFirstMiddleLastInspectStatusEntity.ERR_MSG;
            RTN_KEY = pFirstMiddleLastInspectStatusEntity.RTN_KEY;
            RTN_SEQ = pFirstMiddleLastInspectStatusEntity.RTN_SEQ;
            RTN_OTHERS = pFirstMiddleLastInspectStatusEntity.RTN_OTHERS;


            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class GatheringEquationRegisterEntity
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
        public String RESOURCE_TYPE { get; set; }
        public String DATE_TO { get; set; }
        public String DATE_FROM { get; set; }
        public String PART_NAME { get; set; }
        public String RESOURCE_CODE { get; set; }
        public String RESOURCE_DATE { get; set; }
        public String RESOURCE_SEQ { get; set; }
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

        #region 생성자 - GatheringEquationRegisterEntity()

        public GatheringEquationRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - GatheringEquationRegisterEntity(pGatheringEquationRegisterEntity)

        public GatheringEquationRegisterEntity(GatheringEquationRegisterEntity pGatheringEquationRegisterEntity)
        {
            CORP_CODE = pGatheringEquationRegisterEntity.CORP_CODE;
            CRUD = pGatheringEquationRegisterEntity.CRUD;
            USER_CODE = pGatheringEquationRegisterEntity.USER_CODE;

            pGatheringEquationRegisterEntity.WINDOW_NAME = WINDOW_NAME;

            RESOURCE_TYPE = pGatheringEquationRegisterEntity.RESOURCE_TYPE;
            DATE_FROM = pGatheringEquationRegisterEntity.DATE_FROM;
            DATE_TO = pGatheringEquationRegisterEntity.DATE_TO;
            PART_NAME = pGatheringEquationRegisterEntity.PART_NAME;
            RESOURCE_CODE = pGatheringEquationRegisterEntity.RESOURCE_CODE;
            RESOURCE_DATE = pGatheringEquationRegisterEntity.RESOURCE_DATE;
            RESOURCE_SEQ = pGatheringEquationRegisterEntity.RESOURCE_SEQ;
            PROCESS_NAME = pGatheringEquationRegisterEntity.PROCESS_NAME;
            REQUEST_DEPT = pGatheringEquationRegisterEntity.REQUEST_DEPT;
            CODE_NAME = pGatheringEquationRegisterEntity.CODE_NAME;
            INOUT_DATE = pGatheringEquationRegisterEntity.INOUT_DATE;
            INOUT_QTY = pGatheringEquationRegisterEntity.INOUT_QTY;
            PACKING_REMARK = pGatheringEquationRegisterEntity.PACKING_REMARK;
            SAMPLE_DEPT = pGatheringEquationRegisterEntity.SAMPLE_DEPT;
            SAMPLE_NO = pGatheringEquationRegisterEntity.SAMPLE_NO;
            SAMPLE_USER = pGatheringEquationRegisterEntity.SAMPLE_USER;
            REMARK = pGatheringEquationRegisterEntity.REMARK;
            USER_YN = pGatheringEquationRegisterEntity.USER_YN;
            dtListCnt = pGatheringEquationRegisterEntity.dtListCnt;

            MISSING_CHECK = pGatheringEquationRegisterEntity.MISSING_CHECK;

            ERR_NO = pGatheringEquationRegisterEntity.ERR_NO;
            ERR_MSG = pGatheringEquationRegisterEntity.ERR_MSG;
            RTN_KEY = pGatheringEquationRegisterEntity.RTN_KEY;
            RTN_SEQ = pGatheringEquationRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pGatheringEquationRegisterEntity.RTN_OTHERS;

            LANGUAGE_TYPE = pGatheringEquationRegisterEntity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class KPIDataRegisterEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE


        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        public String PART_NAME { get; set; }
        public String LOT_NO { get; set; }
        public String SEQ { get; set; }
        public String JSONCOL { get; set; }
        public String TRS_NO { get; set; }
        public String FPS_TRS_NO { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값
        public String WINDOW_NAME { get; set; }


        #endregion

        #region 생성자 - KPIDataRegisterEntityEntity()

        public KPIDataRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - KPIDataRegisterEntity(pExcelFormDesignViewEntity)

        public KPIDataRegisterEntity(KPIDataRegisterEntity pKPIDataRegisterEntityEntity)
        {
            CORP_CODE = pKPIDataRegisterEntityEntity.CORP_CODE;
            CRUD = pKPIDataRegisterEntityEntity.CRUD;
            USER_CODE = pKPIDataRegisterEntityEntity.USER_CODE;
            LANGUAGE_TYPE = pKPIDataRegisterEntityEntity.LANGUAGE_TYPE;
            ERR_NO = pKPIDataRegisterEntityEntity.ERR_NO;
            ERR_MSG = pKPIDataRegisterEntityEntity.ERR_MSG;
            RTN_KEY = pKPIDataRegisterEntityEntity.RTN_KEY;
            RTN_SEQ = pKPIDataRegisterEntityEntity.RTN_SEQ;
            RTN_OTHERS = pKPIDataRegisterEntityEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            DATE_FROM = pKPIDataRegisterEntityEntity.DATE_FROM;
            DATE_TO = pKPIDataRegisterEntityEntity.DATE_TO;
            PART_NAME = pKPIDataRegisterEntityEntity.PART_NAME;
            LOT_NO = pKPIDataRegisterEntityEntity.LOT_NO;
            SEQ = pKPIDataRegisterEntityEntity.SEQ;
            JSONCOL = pKPIDataRegisterEntityEntity.JSONCOL;
            TRS_NO = pKPIDataRegisterEntityEntity.TRS_NO;
            FPS_TRS_NO = pKPIDataRegisterEntityEntity.FPS_TRS_NO;
        }

        #endregion
    }

    public class EquipmentInspectRegisterEntity
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
        public String EQUIPMENT_CODE { get; set; }
        public String EQUIPMENT_NAME { get; set; }
        public String INSPECT_STATUS { get; set; }
        public String INSPECT_ID { get; set; }
        public String INSPECT__DATE { get; set; }
        public String INSPECT_SEQ { get; set; }
        public String VEND_PART_CODE { get; set; }
        public String PART_TYPE { get; set; }
        public String REFERENCE_ID { get; set; }
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
        public String USER_YN { get; set; }
        public String FILE_NAME { get; set; }

        public int dtListCnt { get; set; }

        #endregion

        #region 생성자 - EquipmentInspectRegisterEntity()

        public EquipmentInspectRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - EquipmentInspectRegisterEntity(pEquipmentInspectRegisterEntity)

        public EquipmentInspectRegisterEntity(EquipmentInspectRegisterEntity pEquipmentInspectRegisterEntity)
        {
            CORP_CODE = pEquipmentInspectRegisterEntity.CORP_CODE;
            CRUD = pEquipmentInspectRegisterEntity.CRUD;
            USER_CODE = pEquipmentInspectRegisterEntity.USER_CODE;

            pEquipmentInspectRegisterEntity.WINDOW_NAME = WINDOW_NAME;

            DATE_FROM = pEquipmentInspectRegisterEntity.DATE_FROM;
            DATE_TO = pEquipmentInspectRegisterEntity.DATE_TO;
            EQUIPMENT_CODE = pEquipmentInspectRegisterEntity.EQUIPMENT_CODE;
            EQUIPMENT_NAME = pEquipmentInspectRegisterEntity.EQUIPMENT_NAME;
            INSPECT_STATUS = pEquipmentInspectRegisterEntity.INSPECT_STATUS;
            INSPECT_ID = pEquipmentInspectRegisterEntity.INSPECT_ID;
            INSPECT__DATE = pEquipmentInspectRegisterEntity.INSPECT__DATE;
            INSPECT_SEQ = pEquipmentInspectRegisterEntity.INSPECT_SEQ;
            VEND_PART_CODE = pEquipmentInspectRegisterEntity.VEND_PART_CODE;
            PART_TYPE = pEquipmentInspectRegisterEntity.PART_TYPE;
            REFERENCE_ID = pEquipmentInspectRegisterEntity.REFERENCE_ID;
            MAKE_VEND = pEquipmentInspectRegisterEntity.MAKE_VEND;
            MAKE_VEND_NAME = pEquipmentInspectRegisterEntity.MAKE_VEND_NAME;
            VEND_CODE = pEquipmentInspectRegisterEntity.VEND_CODE;
            VEND_NAME = pEquipmentInspectRegisterEntity.VEND_NAME;
            REQUEST_DEPT = pEquipmentInspectRegisterEntity.REQUEST_DEPT;
            CODE_NAME = pEquipmentInspectRegisterEntity.CODE_NAME;
            INOUT_DATE = pEquipmentInspectRegisterEntity.INOUT_DATE;
            INOUT_QTY = pEquipmentInspectRegisterEntity.INOUT_QTY;
            PACKING_REMARK = pEquipmentInspectRegisterEntity.PACKING_REMARK;
            SAMPLE_DATE = pEquipmentInspectRegisterEntity.SAMPLE_DATE;
            SAMPLE_LOCATION = pEquipmentInspectRegisterEntity.SAMPLE_LOCATION;
            SAMPLE_USER = pEquipmentInspectRegisterEntity.SAMPLE_USER;
            SAMPLE_METHOD = pEquipmentInspectRegisterEntity.SAMPLE_METHOD;
            SAMPLE_QTY = pEquipmentInspectRegisterEntity.SAMPLE_QTY;
            MAKE_NO = pEquipmentInspectRegisterEntity.MAKE_NO;
            STANDARD = pEquipmentInspectRegisterEntity.STANDARD;
            REQUEST_DATE = pEquipmentInspectRegisterEntity.REQUEST_DATE;
            REQUEST_USER = pEquipmentInspectRegisterEntity.REQUEST_USER;
            END_DATE = pEquipmentInspectRegisterEntity.END_DATE;
            TOTAL_RESULT = pEquipmentInspectRegisterEntity.TOTAL_RESULT;
            TOTAL_DATE = pEquipmentInspectRegisterEntity.TOTAL_DATE;
            TOTAL_USER = pEquipmentInspectRegisterEntity.TOTAL_USER;
            COMPLETE_YN = pEquipmentInspectRegisterEntity.COMPLETE_YN;
            REMARK = pEquipmentInspectRegisterEntity.REMARK;
            USER_YN = pEquipmentInspectRegisterEntity.USER_YN;
            FILE_NAME = pEquipmentInspectRegisterEntity.FILE_NAME;
            dtListCnt = pEquipmentInspectRegisterEntity.dtListCnt;
            //pEquipmentInspectRegisterEntity.PROCESS_CODE = PROCESS_CODE;

            ERR_NO = pEquipmentInspectRegisterEntity.ERR_NO;
            ERR_MSG = pEquipmentInspectRegisterEntity.ERR_MSG;
            RTN_KEY = pEquipmentInspectRegisterEntity.RTN_KEY;
            RTN_SEQ = pEquipmentInspectRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pEquipmentInspectRegisterEntity.RTN_OTHERS;

            LANGUAGE_TYPE = pEquipmentInspectRegisterEntity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

}

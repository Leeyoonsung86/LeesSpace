using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoFAS_MES.UI.IM.Entity
{
    public class PartMstDownLoadEntity
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

        public String PART_SIZE { get; set; }
        public String PRODUCT_TYPE { get; set; }



        #endregion

        #region 생성자 - PartMstDownLoadEntity()

        public PartMstDownLoadEntity()
        {
        }

        #endregion

        #region 생성자 - PartMstDownLoadEntity(pPartMstDownLoadEntity)

        public PartMstDownLoadEntity(PartMstDownLoadEntity pPartMstDownLoadEntity)
        {
            CORP_CODE = pPartMstDownLoadEntity.CORP_CODE;
            CRUD = pPartMstDownLoadEntity.CRUD;
            USER_CODE = pPartMstDownLoadEntity.USER_CODE;
            LANGUAGE_TYPE = pPartMstDownLoadEntity.LANGUAGE_TYPE;

            ERR_NO = pPartMstDownLoadEntity.ERR_NO;
            ERR_MSG = pPartMstDownLoadEntity.ERR_MSG;
            RTN_KEY = pPartMstDownLoadEntity.RTN_KEY;
            RTN_SEQ = pPartMstDownLoadEntity.RTN_SEQ;
            RTN_AQ = pPartMstDownLoadEntity.RTN_AQ;
            RTN_SQ = pPartMstDownLoadEntity.RTN_SQ;
            RTN_OTHERS = pPartMstDownLoadEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            WINDOW_NAME = pPartMstDownLoadEntity.WINDOW_NAME;
            DATE_FROM = pPartMstDownLoadEntity.DATE_FROM;
            DATE_TO = pPartMstDownLoadEntity.DATE_TO;
            VEND_CODE = pPartMstDownLoadEntity.VEND_CODE;
            VEND_NAME = pPartMstDownLoadEntity.VEND_NAME;

            PART_NAME = pPartMstDownLoadEntity.PART_NAME;
            PART_SIZE = pPartMstDownLoadEntity.PART_SIZE;
            PRODUCT_TYPE = pPartMstDownLoadEntity.PRODUCT_TYPE;

            SHIPMENT_ID = pPartMstDownLoadEntity.SHIPMENT_ID;
            SHIPMENT_DATE = pPartMstDownLoadEntity.SHIPMENT_DATE;
            SHIPMENT_SEQ = pPartMstDownLoadEntity.SHIPMENT_SEQ;
            PART_CODE = pPartMstDownLoadEntity.PART_CODE;
            SHIPMENT_ORDER_QTY = pPartMstDownLoadEntity.SHIPMENT_ORDER_QTY;
            SHIPMENT_STATE = pPartMstDownLoadEntity.SHIPMENT_STATE;
            REFERENCE_ID = pPartMstDownLoadEntity.REFERENCE_ID;
            REMARK = pPartMstDownLoadEntity.REMARK;
            USE_YN = pPartMstDownLoadEntity.USE_YN;
        }
        #endregion

    }

    public class DocumentInfoRegisterEntity
    {
        #region Property

        //사용자 설정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } //언어구분
        public String FTP_IP_PORT { get; set; }
        public String FTP_ID { get; set; }
        public String FTP_PW { get; set; }

        public String DOCUMENT_ID { get; set; }
        public String DOCUMENT_TYPE { get; set; }
        public String DOCUMENT_TYPE_NAME { get; set; }
        public String DOCUMENT_SEQ { get; set; }
        public String DOCUMENT_NAME { get; set; }
        public String DOCUMENT_VER { get; set; }
        public String DOCUMENT_FILE_NAME_FULL { get; set; }
        public String DOCUMENT_FILE_NAME { get; set; }
        public String DOCUMENT_BEFROE_FILE_NAME { get; set; }

        public String CONTRACT_ID { get; set; }
        public String REFERENCE_CODE { get; set; }


        public String REMARK { get; set; } // 비고
        public String USE_YN { get; set; } // 사용유무


        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }


        #endregion

        #region 생성자 - DocumentInfoRegisterEntity()

        public DocumentInfoRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - DocumentInfoRegisterEntity(pDocumentInfoRegisterEntity)

        public DocumentInfoRegisterEntity(DocumentInfoRegisterEntity pDocumentInfoRegisterEntity)
        {
            CORP_CODE = pDocumentInfoRegisterEntity.CORP_CODE;
            CRUD = pDocumentInfoRegisterEntity.CRUD;
            USER_CODE = pDocumentInfoRegisterEntity.USER_CODE;

 
            LANGUAGE_TYPE = pDocumentInfoRegisterEntity.LANGUAGE_TYPE;


            FTP_IP_PORT = pDocumentInfoRegisterEntity.FTP_IP_PORT;
            FTP_ID = pDocumentInfoRegisterEntity.FTP_ID;
            FTP_PW = pDocumentInfoRegisterEntity.FTP_PW;

            DOCUMENT_ID = pDocumentInfoRegisterEntity.DOCUMENT_ID;
            DOCUMENT_TYPE = pDocumentInfoRegisterEntity.DOCUMENT_TYPE;
            DOCUMENT_TYPE_NAME = pDocumentInfoRegisterEntity.DOCUMENT_TYPE_NAME;
            DOCUMENT_SEQ = pDocumentInfoRegisterEntity.DOCUMENT_SEQ;
            DOCUMENT_NAME = pDocumentInfoRegisterEntity.DOCUMENT_NAME;
            DOCUMENT_VER = pDocumentInfoRegisterEntity.DOCUMENT_VER;

            DOCUMENT_FILE_NAME_FULL = pDocumentInfoRegisterEntity.DOCUMENT_FILE_NAME_FULL;
            DOCUMENT_FILE_NAME = pDocumentInfoRegisterEntity.DOCUMENT_FILE_NAME;
            DOCUMENT_BEFROE_FILE_NAME = pDocumentInfoRegisterEntity.DOCUMENT_BEFROE_FILE_NAME;

            CONTRACT_ID = pDocumentInfoRegisterEntity.CONTRACT_ID;
            REFERENCE_CODE = pDocumentInfoRegisterEntity.REFERENCE_CODE;

            REMARK = pDocumentInfoRegisterEntity.REMARK;
            USE_YN = pDocumentInfoRegisterEntity.USE_YN;

            ERR_NO = pDocumentInfoRegisterEntity.ERR_NO;
            ERR_MSG = pDocumentInfoRegisterEntity.ERR_MSG;
            RTN_KEY = pDocumentInfoRegisterEntity.RTN_KEY;
            RTN_SEQ = pDocumentInfoRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pDocumentInfoRegisterEntity.RTN_OTHERS;
        }

        #endregion

    }


    public class VendorInformationEntity
    {
        #region Property

        //사용자 설정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // 언어 정보 값

        //마스터
        public String VEND_CODE { get; set; }
        public String VEND_NAME { get; set; }
        public String VEND_EIN { get; set; }
        public String VEND_TYPE { get; set; }
        public String VEND_ENG_NAME { get; set; }
        public String VEND_CEO_NAME { get; set; }
        public String VEND_BUSINESS_OPENDATE { get; set; }
        public String VEND_SSN { get; set; }
        public String VEND_ADDRESS_1 { get; set; }
        public String VEND_ADDRESS_2 { get; set; }
        public String VEND_BUSINESS { get; set; }
        public String VEND_BUSINESS_TYPE { get; set; }
        public String VEND_TEL { get; set; }
        public String VEND_FAX { get; set; }
        public String VEND_MAIL { get; set; }
        public String VEND_FILENAME { get; set; }
        public String REMARK { get; set; }
        public String USE_YN { get; set; }

        public String T_VEND_TYPE { get; set; }

        public String T_VEND_EIN { get; set; }

        //상세
        public String VEND_SEQ { get; set; }
        public String VEND_PERSON_NAME { get; set; }
        public String VEND_TELL { get; set; }
        public String VEND_MOBILE { get; set; }


        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }

        #endregion

        #region 생성자 - VendorInformationEntity()

        public VendorInformationEntity()
        {
        }

        #endregion

        #region 생성자 - VendorInformationEntity(pVendorInformationEntity)

        public VendorInformationEntity(VendorInformationEntity pVendorInformationEntity)
        {
            CORP_CODE = pVendorInformationEntity.CORP_CODE;
            CRUD = pVendorInformationEntity.CRUD;
            USER_CODE = pVendorInformationEntity.USER_CODE;
            LANGUAGE_TYPE = pVendorInformationEntity.LANGUAGE_TYPE;

            //마스터
            VEND_CODE = pVendorInformationEntity.VEND_CODE;
            VEND_NAME = pVendorInformationEntity.VEND_NAME;
            VEND_EIN = pVendorInformationEntity.VEND_EIN;
            VEND_TYPE = pVendorInformationEntity.VEND_TYPE;
            VEND_ENG_NAME = pVendorInformationEntity.VEND_ENG_NAME;
            VEND_CEO_NAME = pVendorInformationEntity.VEND_CEO_NAME;
            VEND_BUSINESS_OPENDATE = pVendorInformationEntity.VEND_BUSINESS_OPENDATE;
            VEND_SSN = pVendorInformationEntity.VEND_SSN;
            VEND_ADDRESS_1 = pVendorInformationEntity.VEND_ADDRESS_1;
            VEND_ADDRESS_2 = pVendorInformationEntity.VEND_ADDRESS_2;
            VEND_BUSINESS = pVendorInformationEntity.VEND_BUSINESS;
            VEND_BUSINESS_TYPE = pVendorInformationEntity.VEND_BUSINESS_TYPE;
            VEND_TEL = pVendorInformationEntity.VEND_TEL;
            VEND_FAX = pVendorInformationEntity.VEND_FAX;
            VEND_MAIL = pVendorInformationEntity.VEND_MAIL;
            VEND_FILENAME = pVendorInformationEntity.VEND_FILENAME;
            REMARK = pVendorInformationEntity.REMARK;
            USE_YN = pVendorInformationEntity.USE_YN;
            T_VEND_EIN = pVendorInformationEntity.T_VEND_EIN;
            T_VEND_TYPE = pVendorInformationEntity.T_VEND_TYPE;
            //상세
            VEND_SEQ = pVendorInformationEntity.VEND_SEQ;
            VEND_PERSON_NAME = pVendorInformationEntity.VEND_PERSON_NAME;
            VEND_TELL = pVendorInformationEntity.VEND_TELL;
            VEND_MOBILE = pVendorInformationEntity.VEND_MOBILE;

            ERR_NO = pVendorInformationEntity.ERR_NO;
            ERR_MSG = pVendorInformationEntity.ERR_MSG;
            RTN_KEY = pVendorInformationEntity.RTN_KEY;
            RTN_SEQ = pVendorInformationEntity.RTN_SEQ;
            RTN_OTHERS = pVendorInformationEntity.RTN_OTHERS;
        }

        #endregion

    }

    public class VendorInformation_T01Entity
    {
        #region Property

        //사용자 설정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // 언어 정보 값

        //마스터
        public String VEND_CODE { get; set; }
        public String VEND_NAME { get; set; }
        public String VEND_EIN { get; set; }
        public String VEND_TYPE { get; set; }
        public String VEND_ENG_NAME { get; set; }
        public String VEND_CEO_NAME { get; set; }
        public String VEND_BUSINESS_OPENDATE { get; set; }
        public String VEND_SSN { get; set; }
        public String VEND_ADDRESS_1 { get; set; }
        public String VEND_ADDRESS_2 { get; set; }
        public String VEND_BUSINESS { get; set; }
        public String VEND_BUSINESS_TYPE { get; set; }
        public String VEND_TEL { get; set; }
        public String VEND_FAX { get; set; }
        public String VEND_MAIL { get; set; }
        public String VEND_FILENAME { get; set; }
        public String REMARK { get; set; }
        public String USE_YN { get; set; }

        public String T_VEND_TYPE { get; set; }

        public String T_VEND_EIN { get; set; }

        //상세
        public String VEND_SEQ { get; set; }
        public String VEND_PERSON_NAME { get; set; }
        public String VEND_TELL { get; set; }
        public String VEND_MOBILE { get; set; }


        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }

        #endregion

        #region 생성자 - VendorInformation_T01Entity()

        public VendorInformation_T01Entity()
        {
        }

        #endregion

        #region 생성자 - VendorInformation_T01Entity(VendorInformation_T01Entity pVendorInformation_T01Entity)

        public VendorInformation_T01Entity(VendorInformation_T01Entity pVendorInformation_T01Entity)
        {
            CORP_CODE = pVendorInformation_T01Entity.CORP_CODE;
            CRUD = pVendorInformation_T01Entity.CRUD;
            USER_CODE = pVendorInformation_T01Entity.USER_CODE;
            LANGUAGE_TYPE = pVendorInformation_T01Entity.LANGUAGE_TYPE;

            //마스터
            VEND_CODE = pVendorInformation_T01Entity.VEND_CODE;
            VEND_NAME = pVendorInformation_T01Entity.VEND_NAME;
            VEND_EIN = pVendorInformation_T01Entity.VEND_EIN;
            VEND_TYPE = pVendorInformation_T01Entity.VEND_TYPE;
            VEND_ENG_NAME = pVendorInformation_T01Entity.VEND_ENG_NAME;
            VEND_CEO_NAME = pVendorInformation_T01Entity.VEND_CEO_NAME;
            VEND_BUSINESS_OPENDATE = pVendorInformation_T01Entity.VEND_BUSINESS_OPENDATE;
            VEND_SSN = pVendorInformation_T01Entity.VEND_SSN;
            VEND_ADDRESS_1 = pVendorInformation_T01Entity.VEND_ADDRESS_1;
            VEND_ADDRESS_2 = pVendorInformation_T01Entity.VEND_ADDRESS_2;
            VEND_BUSINESS = pVendorInformation_T01Entity.VEND_BUSINESS;
            VEND_BUSINESS_TYPE = pVendorInformation_T01Entity.VEND_BUSINESS_TYPE;
            VEND_TEL = pVendorInformation_T01Entity.VEND_TEL;
            VEND_FAX = pVendorInformation_T01Entity.VEND_FAX;
            VEND_MAIL = pVendorInformation_T01Entity.VEND_MAIL;
            VEND_FILENAME = pVendorInformation_T01Entity.VEND_FILENAME;
            REMARK = pVendorInformation_T01Entity.REMARK;
            USE_YN = pVendorInformation_T01Entity.USE_YN;
            T_VEND_EIN = pVendorInformation_T01Entity.T_VEND_EIN;
            T_VEND_TYPE = pVendorInformation_T01Entity.T_VEND_TYPE;
            //상세
            VEND_SEQ = pVendorInformation_T01Entity.VEND_SEQ;
            VEND_PERSON_NAME = pVendorInformation_T01Entity.VEND_PERSON_NAME;
            VEND_TELL = pVendorInformation_T01Entity.VEND_TELL;
            VEND_MOBILE = pVendorInformation_T01Entity.VEND_MOBILE;

            ERR_NO = pVendorInformation_T01Entity.ERR_NO;
            ERR_MSG = pVendorInformation_T01Entity.ERR_MSG;
            RTN_KEY = pVendorInformation_T01Entity.RTN_KEY;
            RTN_SEQ = pVendorInformation_T01Entity.RTN_SEQ;
            RTN_OTHERS = pVendorInformation_T01Entity.RTN_OTHERS;
        }

        #endregion

    }

    public class GatheringInformationEntity
    {
        #region Property

        //사용자 설정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // 언어 정보 값

        //마스터
        public String VEND_CODE { get; set; }
        public String VEND_NAME { get; set; }
        public String VEND_EIN { get; set; }
        public String VEND_TYPE { get; set; }
        public String VEND_ENG_NAME { get; set; }
        public String VEND_CEO_NAME { get; set; }
        public String VEND_BUSINESS_OPENDATE { get; set; }
        public String VEND_SSN { get; set; }
        public String VEND_ADDRESS_1 { get; set; }
        public String VEND_ADDRESS_2 { get; set; }
        public String VEND_BUSINESS { get; set; }
        public String VEND_BUSINESS_TYPE { get; set; }
        public String VEND_TEL { get; set; }
        public String VEND_FAX { get; set; }
        public String VEND_MAIL { get; set; }
        public String VEND_FILENAME { get; set; }
        public String REMARK { get; set; }
        public String USE_YN { get; set; }

        public String T_VEND_TYPE { get; set; }

        public String T_VEND_EIN { get; set; }

        //상세
        public String VEND_SEQ { get; set; }
        public String VEND_PERSON_NAME { get; set; }
        public String VEND_TELL { get; set; }
        public String VEND_MOBILE { get; set; }

        //필요로하는 항목 6개 추가 --회사코드 제외
        public String GATHERING_GUBN { get; set; }
        public String GATHERING_CODE { get; set; }
        public String GATHERING_SERIAL { get; set; }
        public String GATHERING_NAME { get; set; }
        public String GATHERING_IP { get; set; }
        public String GATHERING_PORT { get; set; }
        public String GATHERING_INTERVAL { get; set; }

        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }

        #endregion

        #region 생성자 - GatheringInformationEntity()

        public GatheringInformationEntity()
        {
        }

        #endregion

        #region 생성자 - GatheringInformationEntity(pGatheringInformationEntity)

        public GatheringInformationEntity(GatheringInformationEntity pGatheringInformationEntity)
        {
            CORP_CODE = pGatheringInformationEntity.CORP_CODE;
            CRUD = pGatheringInformationEntity.CRUD;
            USER_CODE = pGatheringInformationEntity.USER_CODE;
            LANGUAGE_TYPE = pGatheringInformationEntity.LANGUAGE_TYPE;

            //마스터
            VEND_CODE = pGatheringInformationEntity.VEND_CODE;
            VEND_NAME = pGatheringInformationEntity.VEND_NAME;
            VEND_EIN = pGatheringInformationEntity.VEND_EIN;
            VEND_TYPE = pGatheringInformationEntity.VEND_TYPE;
            VEND_ENG_NAME = pGatheringInformationEntity.VEND_ENG_NAME;
            VEND_CEO_NAME = pGatheringInformationEntity.VEND_CEO_NAME;
            VEND_BUSINESS_OPENDATE = pGatheringInformationEntity.VEND_BUSINESS_OPENDATE;
            VEND_SSN = pGatheringInformationEntity.VEND_SSN;
            VEND_ADDRESS_1 = pGatheringInformationEntity.VEND_ADDRESS_1;
            VEND_ADDRESS_2 = pGatheringInformationEntity.VEND_ADDRESS_2;
            VEND_BUSINESS = pGatheringInformationEntity.VEND_BUSINESS;
            VEND_BUSINESS_TYPE = pGatheringInformationEntity.VEND_BUSINESS_TYPE;
            VEND_TEL = pGatheringInformationEntity.VEND_TEL;
            VEND_FAX = pGatheringInformationEntity.VEND_FAX;
            VEND_MAIL = pGatheringInformationEntity.VEND_MAIL;
            VEND_FILENAME = pGatheringInformationEntity.VEND_FILENAME;
            REMARK = pGatheringInformationEntity.REMARK;
            USE_YN = pGatheringInformationEntity.USE_YN;
            T_VEND_EIN = pGatheringInformationEntity.T_VEND_EIN;
            T_VEND_TYPE = pGatheringInformationEntity.T_VEND_TYPE;
            //상세
            VEND_SEQ = pGatheringInformationEntity.VEND_SEQ;
            VEND_PERSON_NAME = pGatheringInformationEntity.VEND_PERSON_NAME;
            VEND_TELL = pGatheringInformationEntity.VEND_TELL;
            VEND_MOBILE = pGatheringInformationEntity.VEND_MOBILE;

            //필요로하는 항목 7개 추가 --회사코드 제외
            GATHERING_GUBN = pGatheringInformationEntity.GATHERING_GUBN;
            GATHERING_CODE = pGatheringInformationEntity.GATHERING_CODE;
            GATHERING_SERIAL = pGatheringInformationEntity.GATHERING_SERIAL;
            GATHERING_NAME = pGatheringInformationEntity.GATHERING_NAME;
            GATHERING_IP = pGatheringInformationEntity.GATHERING_IP;
            GATHERING_PORT = pGatheringInformationEntity.GATHERING_PORT;
            GATHERING_INTERVAL = pGatheringInformationEntity.GATHERING_INTERVAL;



            ERR_NO = pGatheringInformationEntity.ERR_NO;
            ERR_MSG = pGatheringInformationEntity.ERR_MSG;
            RTN_KEY = pGatheringInformationEntity.RTN_KEY;
            RTN_SEQ = pGatheringInformationEntity.RTN_SEQ;
            RTN_OTHERS = pGatheringInformationEntity.RTN_OTHERS;
        }

        #endregion

    }

    public class ProcessCodeMstRegisterEntity
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
        public String PROCESS_MST_CODE { get; set; }
        public String PROCESS_MST_NAME { get; set; }
        public String PROCESS_CODE { get; set; }
        public String PROCESS_NAME { get; set; }
        public String PROCESS_TYPE { get; set; }
        public String PROCESS_PLANT { get; set; }
        public String PROCESS_LINE { get; set; }
        public String REMARK { get; set; }
        public String USE_YN { get; set; }

        #endregion

        #region 생성자 - ProcessCodeMstRegisterEntity()

        public ProcessCodeMstRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - ProcessCodeMstRegisterEntity(pProcessCodeMstRegisterEntity)

        public ProcessCodeMstRegisterEntity(ProcessCodeMstRegisterEntity pProcessCodeMstRegisterEntity)
        {
            CRUD = pProcessCodeMstRegisterEntity.CRUD;
            CORP_CODE = pProcessCodeMstRegisterEntity.CORP_CODE;
            USER_CODE = pProcessCodeMstRegisterEntity.USER_CODE;
            LANGUAGE_TYPE = pProcessCodeMstRegisterEntity.LANGUAGE_TYPE;
            ERR_NO = pProcessCodeMstRegisterEntity.ERR_NO;
            ERR_MSG = pProcessCodeMstRegisterEntity.ERR_MSG;
            RTN_KEY = pProcessCodeMstRegisterEntity.RTN_KEY;
            RTN_SEQ = pProcessCodeMstRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pProcessCodeMstRegisterEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            PROCESS_MST_CODE = pProcessCodeMstRegisterEntity.PROCESS_MST_CODE;
            PROCESS_MST_NAME = pProcessCodeMstRegisterEntity.PROCESS_MST_NAME;
            PROCESS_CODE = pProcessCodeMstRegisterEntity.PROCESS_CODE;
            PROCESS_NAME = pProcessCodeMstRegisterEntity.PROCESS_NAME;
            PROCESS_TYPE = pProcessCodeMstRegisterEntity.PROCESS_TYPE;
            PROCESS_PLANT = pProcessCodeMstRegisterEntity.PROCESS_PLANT;
            PROCESS_LINE = pProcessCodeMstRegisterEntity.PROCESS_LINE;
            REMARK = pProcessCodeMstRegisterEntity.REMARK;
            USE_YN = pProcessCodeMstRegisterEntity.USE_YN;
        }

        #endregion

    }

    public class TerminalInfoMstRegisterEntity
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
        public String TERMINAL_MST_CODE { get; set; }
        public String TERMINAL_MST_NAME { get; set; }
        public String TERMINAL_CODE { get; set; }
        public String TERMINAL_NAME { get; set; }
        public String TERMINAL_TYPE { get; set; }
        public String REMARK { get; set; }
        public String USE_YN { get; set; }

        #endregion

        #region 생성자 - TerminalInfoMstRegisterEntity()

        public TerminalInfoMstRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - TerminalInfoMstRegisterEntity(pTerminalInfoMstRegisterEntity)

        public TerminalInfoMstRegisterEntity(TerminalInfoMstRegisterEntity pTerminalInfoMstRegisterEntity)
        {
            CRUD = pTerminalInfoMstRegisterEntity.CRUD;
            CORP_CODE = pTerminalInfoMstRegisterEntity.CORP_CODE;
            USER_CODE = pTerminalInfoMstRegisterEntity.USER_CODE;
            LANGUAGE_TYPE = pTerminalInfoMstRegisterEntity.LANGUAGE_TYPE;
            ERR_NO = pTerminalInfoMstRegisterEntity.ERR_NO;
            ERR_MSG = pTerminalInfoMstRegisterEntity.ERR_MSG;
            RTN_KEY = pTerminalInfoMstRegisterEntity.RTN_KEY;
            RTN_SEQ = pTerminalInfoMstRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pTerminalInfoMstRegisterEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            TERMINAL_MST_CODE = pTerminalInfoMstRegisterEntity.TERMINAL_MST_CODE;
            TERMINAL_MST_NAME = pTerminalInfoMstRegisterEntity.TERMINAL_MST_NAME;
            TERMINAL_CODE = pTerminalInfoMstRegisterEntity.TERMINAL_CODE;
            TERMINAL_NAME = pTerminalInfoMstRegisterEntity.TERMINAL_NAME;
            TERMINAL_TYPE = pTerminalInfoMstRegisterEntity.TERMINAL_TYPE;
            REMARK = pTerminalInfoMstRegisterEntity.REMARK;
            USE_YN = pTerminalInfoMstRegisterEntity.USE_YN;
        }

        #endregion

    }

    public class ToolInfoMstRegisterEntity
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
        public String TOOL_MST_CODE { get; set; }
        public String TOOL_MST_NAME { get; set; }
        public String TOOL_CODE { get; set; }
        public String TOOL_NAME { get; set; }
        public String TOOL_TYPE { get; set; }
        public String REMARK { get; set; }
        public String USE_YN { get; set; }

        #endregion

        #region 생성자 - ToolInfoMstRegisterEntity()

        public ToolInfoMstRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - ToolInfoMstRegisterEntity(pToolInfoMstRegisterEntity)

        public ToolInfoMstRegisterEntity(ToolInfoMstRegisterEntity pToolInfoMstRegisterEntity)
        {
            CRUD = pToolInfoMstRegisterEntity.CRUD;
            CORP_CODE = pToolInfoMstRegisterEntity.CORP_CODE;
            USER_CODE = pToolInfoMstRegisterEntity.USER_CODE;
            LANGUAGE_TYPE = pToolInfoMstRegisterEntity.LANGUAGE_TYPE;
            ERR_NO = pToolInfoMstRegisterEntity.ERR_NO;
            ERR_MSG = pToolInfoMstRegisterEntity.ERR_MSG;
            RTN_KEY = pToolInfoMstRegisterEntity.RTN_KEY;
            RTN_SEQ = pToolInfoMstRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pToolInfoMstRegisterEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            TOOL_MST_CODE = pToolInfoMstRegisterEntity.TOOL_MST_CODE;
            TOOL_MST_NAME = pToolInfoMstRegisterEntity.TOOL_MST_NAME;
            TOOL_CODE = pToolInfoMstRegisterEntity.TOOL_CODE;
            TOOL_NAME = pToolInfoMstRegisterEntity.TOOL_NAME;
            TOOL_TYPE = pToolInfoMstRegisterEntity.TOOL_TYPE;
            REMARK = pToolInfoMstRegisterEntity.REMARK;
            USE_YN = pToolInfoMstRegisterEntity.USE_YN;
        }

        #endregion

    }

    public class ToolInfoMstRegister_T01Entity
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
        public String TOOL_MST_CODE { get; set; }
        public String TOOL_MST_NAME { get; set; }
        public String TOOL_CODE { get; set; }
        public String TOOL_NAME { get; set; }
        public String TOOL_TYPE { get; set; }
        public String REMARK { get; set; }
        public String USE_YN { get; set; }

        #endregion

        #region 생성자 - ToolInfoMstRegister_T01Entity()

        public ToolInfoMstRegister_T01Entity()
        {
        }

        #endregion

        #region 생성자 - ToolInfoMstRegister_T01Entity(ToolInfoMstRegister_T01Entity)

        public ToolInfoMstRegister_T01Entity(ToolInfoMstRegister_T01Entity pToolInfoMstRegister_T01Entity)
        {
            CRUD = pToolInfoMstRegister_T01Entity.CRUD;
            CORP_CODE = pToolInfoMstRegister_T01Entity.CORP_CODE;
            USER_CODE = pToolInfoMstRegister_T01Entity.USER_CODE;
            LANGUAGE_TYPE = pToolInfoMstRegister_T01Entity.LANGUAGE_TYPE;
            ERR_NO = pToolInfoMstRegister_T01Entity.ERR_NO;
            ERR_MSG = pToolInfoMstRegister_T01Entity.ERR_MSG;
            RTN_KEY = pToolInfoMstRegister_T01Entity.RTN_KEY;
            RTN_SEQ = pToolInfoMstRegister_T01Entity.RTN_SEQ;
            RTN_OTHERS = pToolInfoMstRegister_T01Entity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
            TOOL_MST_CODE = pToolInfoMstRegister_T01Entity.TOOL_MST_CODE;
            TOOL_MST_NAME = pToolInfoMstRegister_T01Entity.TOOL_MST_NAME;
            TOOL_CODE = pToolInfoMstRegister_T01Entity.TOOL_CODE;
            TOOL_NAME = pToolInfoMstRegister_T01Entity.TOOL_NAME;
            TOOL_TYPE = pToolInfoMstRegister_T01Entity.TOOL_TYPE;
            REMARK = pToolInfoMstRegister_T01Entity.REMARK;
            USE_YN = pToolInfoMstRegister_T01Entity.USE_YN;
        }

        #endregion

    }

    public class ProcessRoutingRegisterEntity
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
        public String LANGUAGE_TYPE { get; set; } // 언어 정보 값

        //마스터 엔티티


        public String CONFIGURATION_MST_CODE { get; set; }
        public String CONFIGURATION_SEQ { get; set; }
        public String CONFIGURATION_MST_NAME { get; set; }
        public String CONFIGURATION_VEND_CODE { get; set; }

        public String ROUTING_REVISION_NO { get; set; }
        public String REVISION_NO { get; set; }

        public String REMARK { get; set; }

        public String ROUTING_MST_CODE { get; set; }
        public String ROUTING_MST_NAME { get; set; }
        public String ROUTING_CODE { get; set; }


        public String USE_YN { get; set; }

        //메뉴별 추가 엔티티 입력
        public String PROCESS_MST_CODE { get; set; }
        public String PROCESS_CODE { get; set; }
        public String PROCESS_NAME { get; set; }
        public String PROCESS_TYPE { get; set; }





        #endregion

        #region 생성자 - ProcessRoutingRegisterEntity()

        public ProcessRoutingRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - ProcessRoutingRegisterEntity(pProcessRoutingRegisterEntity)

        public ProcessRoutingRegisterEntity(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)
        {
            CORP_CODE = pProcessRoutingRegisterEntity.CORP_CODE;
            CRUD = pProcessRoutingRegisterEntity.CRUD;
            USER_CODE = pProcessRoutingRegisterEntity.USER_CODE;
            ERR_NO = pProcessRoutingRegisterEntity.ERR_NO;
            ERR_MSG = pProcessRoutingRegisterEntity.ERR_MSG;
            RTN_KEY = pProcessRoutingRegisterEntity.RTN_KEY;
            RTN_SEQ = pProcessRoutingRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pProcessRoutingRegisterEntity.RTN_OTHERS;
            LANGUAGE_TYPE = pProcessRoutingRegisterEntity.LANGUAGE_TYPE;

            //메뉴별 추가 엔티티 입력

            CONFIGURATION_MST_CODE = pProcessRoutingRegisterEntity.CONFIGURATION_MST_CODE;
            CONFIGURATION_SEQ = pProcessRoutingRegisterEntity.CONFIGURATION_SEQ;
            CONFIGURATION_MST_NAME = pProcessRoutingRegisterEntity.CONFIGURATION_MST_NAME;
            CONFIGURATION_VEND_CODE = pProcessRoutingRegisterEntity.CONFIGURATION_VEND_CODE;

            ROUTING_REVISION_NO = pProcessRoutingRegisterEntity.ROUTING_REVISION_NO;

            REVISION_NO = pProcessRoutingRegisterEntity.REVISION_NO;

            REMARK = pProcessRoutingRegisterEntity.REMARK;


            ROUTING_MST_CODE = pProcessRoutingRegisterEntity.ROUTING_MST_CODE;
            ROUTING_MST_NAME = pProcessRoutingRegisterEntity.ROUTING_MST_NAME;

            ROUTING_CODE = pProcessRoutingRegisterEntity.ROUTING_CODE;

            PROCESS_MST_CODE = pProcessRoutingRegisterEntity.PROCESS_MST_CODE;
            PROCESS_CODE = pProcessRoutingRegisterEntity.PROCESS_CODE;
            PROCESS_NAME = pProcessRoutingRegisterEntity.PROCESS_NAME;
            PROCESS_TYPE = pProcessRoutingRegisterEntity.PROCESS_TYPE;
            USE_YN = pProcessRoutingRegisterEntity.USE_YN;
        }

        #endregion

    }

    public class ProcessConfigurationRegisterEntity
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
        public String LANGUAGE_TYPE { get; set; } // 언어 정보 값

        //마스터 엔티티


        public String CONFIGURATION_MST_CODE { get; set; }
        public String CONFIGURATION_SEQ { get; set; }
        public String CONFIGURATION_MST_NAME { get; set; }
        public String CONFIGURATION_VEND_CODE { get; set; }

        public String ROUTING_REVISION_NO { get; set; }
        public String REVISION_NO { get; set; }

        public String REMARK { get; set; }

        public String ROUTING_MST_CODE { get; set; }
        public String ROUTING_MST_NAME { get; set; }
        public String ROUTING_CODE { get; set; }


        public String USE_YN { get; set; }

        //메뉴별 추가 엔티티 입력
        public String PROCESS_MST_CODE { get; set; }
        public String PROCESS_CODE { get; set; }
        public String PROCESS_NAME { get; set; }
        public String PROCESS_TYPE { get; set; }





        #endregion

        #region 생성자 - ProcessConfigurationRegisterEntity()

        public ProcessConfigurationRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - ProcessConfigurationRegisterEntity(pProcessConfigurationRegisterEntity)

        public ProcessConfigurationRegisterEntity(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)
        {
            CORP_CODE = pProcessConfigurationRegisterEntity.CORP_CODE;
            CRUD = pProcessConfigurationRegisterEntity.CRUD;
            USER_CODE = pProcessConfigurationRegisterEntity.USER_CODE;
            ERR_NO = pProcessConfigurationRegisterEntity.ERR_NO;
            ERR_MSG = pProcessConfigurationRegisterEntity.ERR_MSG;
            RTN_KEY = pProcessConfigurationRegisterEntity.RTN_KEY;
            RTN_SEQ = pProcessConfigurationRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pProcessConfigurationRegisterEntity.RTN_OTHERS;
            LANGUAGE_TYPE = pProcessConfigurationRegisterEntity.LANGUAGE_TYPE;

            //메뉴별 추가 엔티티 입력

            CONFIGURATION_MST_CODE = pProcessConfigurationRegisterEntity.CONFIGURATION_MST_CODE;
            CONFIGURATION_SEQ = pProcessConfigurationRegisterEntity.CONFIGURATION_SEQ;
            CONFIGURATION_MST_NAME = pProcessConfigurationRegisterEntity.CONFIGURATION_MST_NAME;
            CONFIGURATION_VEND_CODE = pProcessConfigurationRegisterEntity.CONFIGURATION_VEND_CODE;

            ROUTING_REVISION_NO = pProcessConfigurationRegisterEntity.ROUTING_REVISION_NO;

            REVISION_NO = pProcessConfigurationRegisterEntity.REVISION_NO;

            REMARK = pProcessConfigurationRegisterEntity.REMARK;


            ROUTING_MST_CODE = pProcessConfigurationRegisterEntity.ROUTING_MST_CODE;
            ROUTING_MST_NAME = pProcessConfigurationRegisterEntity.ROUTING_MST_NAME;

            ROUTING_CODE = pProcessConfigurationRegisterEntity.ROUTING_CODE;

            PROCESS_MST_CODE = pProcessConfigurationRegisterEntity.PROCESS_MST_CODE;
            PROCESS_CODE = pProcessConfigurationRegisterEntity.PROCESS_CODE;
            PROCESS_NAME = pProcessConfigurationRegisterEntity.PROCESS_NAME;
            PROCESS_TYPE = pProcessConfigurationRegisterEntity.PROCESS_TYPE;
            USE_YN = pProcessConfigurationRegisterEntity.USE_YN;
        }

        #endregion

    }

    public class ProcessConfigurationRegister_T01Entity
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
        public String LANGUAGE_TYPE { get; set; } // 언어 정보 값

        //마스터 엔티티


        public String CONFIGURATION_MST_CODE { get; set; }
        public String CONFIGURATION_SEQ { get; set; }
        public String CONFIGURATION_MST_NAME { get; set; }
        public String CONFIGURATION_VEND_CODE { get; set; }
        public String REVISION_NO { get; set; }

        public String REMARK { get; set; }

        public String ROUTING_MST_CODE { get; set; }
        public String ROUTING_MST_NAME { get; set; }
        public String ROUTING_CODE { get; set; }


        public String USE_YN { get; set; }

        //메뉴별 추가 엔티티 입력
        public String PROCESS_MST_CODE { get; set; }
        public String PROCESS_CODE { get; set; }
        public String PROCESS_NAME { get; set; }
        public String PROCESS_TYPE { get; set; }





        #endregion

        #region 생성자 - ProcessConfigurationRegister_T01Entity()

        public ProcessConfigurationRegister_T01Entity()
        {
        }

        #endregion

        #region 생성자 - ProcessConfigurationRegister_T01Entity(pProcessConfigurationRegister_T01Entity)

        public ProcessConfigurationRegister_T01Entity(ProcessConfigurationRegister_T01Entity pProcessConfigurationRegister_T01Entity)
        {
            CORP_CODE = pProcessConfigurationRegister_T01Entity.CORP_CODE;
            CRUD = pProcessConfigurationRegister_T01Entity.CRUD;
            USER_CODE = pProcessConfigurationRegister_T01Entity.USER_CODE;
            ERR_NO = pProcessConfigurationRegister_T01Entity.ERR_NO;
            ERR_MSG = pProcessConfigurationRegister_T01Entity.ERR_MSG;
            RTN_KEY = pProcessConfigurationRegister_T01Entity.RTN_KEY;
            RTN_SEQ = pProcessConfigurationRegister_T01Entity.RTN_SEQ;
            RTN_OTHERS = pProcessConfigurationRegister_T01Entity.RTN_OTHERS;
            LANGUAGE_TYPE = pProcessConfigurationRegister_T01Entity.LANGUAGE_TYPE;

            //메뉴별 추가 엔티티 입력

            CONFIGURATION_MST_CODE = pProcessConfigurationRegister_T01Entity.CONFIGURATION_MST_CODE;
            CONFIGURATION_SEQ = pProcessConfigurationRegister_T01Entity.CONFIGURATION_SEQ;
            CONFIGURATION_MST_NAME = pProcessConfigurationRegister_T01Entity.CONFIGURATION_MST_NAME;
            CONFIGURATION_VEND_CODE = pProcessConfigurationRegister_T01Entity.CONFIGURATION_VEND_CODE;
            REVISION_NO = pProcessConfigurationRegister_T01Entity.REVISION_NO;

            REMARK = pProcessConfigurationRegister_T01Entity.REMARK;


            ROUTING_MST_CODE = pProcessConfigurationRegister_T01Entity.ROUTING_MST_CODE;
            ROUTING_MST_NAME = pProcessConfigurationRegister_T01Entity.ROUTING_MST_NAME;

            ROUTING_CODE = pProcessConfigurationRegister_T01Entity.ROUTING_CODE;

            PROCESS_MST_CODE = pProcessConfigurationRegister_T01Entity.PROCESS_MST_CODE;
            PROCESS_CODE = pProcessConfigurationRegister_T01Entity.PROCESS_CODE;
            PROCESS_NAME = pProcessConfigurationRegister_T01Entity.PROCESS_NAME;
            PROCESS_TYPE = pProcessConfigurationRegister_T01Entity.PROCESS_TYPE;
            USE_YN = pProcessConfigurationRegister_T01Entity.USE_YN;
        }

        #endregion

    }

    public class ProcessConfigurationRegister_T50Entity
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
        public String LANGUAGE_TYPE { get; set; } // 언어 정보 값

        //마스터 엔티티

        public String PART_CODE { get; set; }
        public String CONFIGURATION_MST_CODE { get; set; }
        public String CONFIGURATION_SEQ { get; set; }
        public String SEQ { get; set; }
        public String CONFIGURATION_MST_NAME { get; set; }

        public String CONFIGURATION_NAME { get; set; }

        public String PROCESS_GROUP { get; set; }
        public String PROCESS_GUBUN { get; set; }

        public String EQUIPMENT_GROUP { get; set; }

        public String CONFIGURATION_VEND_CODE { get; set; }
        public String REVISION_NO { get; set; }

        public String REMARK { get; set; }

        public String ROUTING_MST_CODE { get; set; }
        public String ROUTING_MST_NAME { get; set; }
        public String ROUTING_CODE { get; set; }


        public String USE_YN { get; set; }

        //메뉴별 추가 엔티티 입력
        public String PROCESS_MST_CODE { get; set; }
        public String PROCESS_CODE { get; set; }
        public String PROCESS_NAME { get; set; }
        public String PROCESS_TYPE { get; set; }





        #endregion

        #region 생성자 - ProcessConfigurationRegister_T50Entity()

        public ProcessConfigurationRegister_T50Entity()
        {
        }

        #endregion

        #region 생성자 - ProcessConfigurationRegister_T50Entity(pProcessConfigurationRegister_T50Entity)

        public ProcessConfigurationRegister_T50Entity(ProcessConfigurationRegister_T50Entity pProcessConfigurationRegister_T50Entity)
        {
            CORP_CODE = pProcessConfigurationRegister_T50Entity.CORP_CODE;
            CRUD = pProcessConfigurationRegister_T50Entity.CRUD;
            USER_CODE = pProcessConfigurationRegister_T50Entity.USER_CODE;
            ERR_NO = pProcessConfigurationRegister_T50Entity.ERR_NO;
            ERR_MSG = pProcessConfigurationRegister_T50Entity.ERR_MSG;
            RTN_KEY = pProcessConfigurationRegister_T50Entity.RTN_KEY;
            RTN_SEQ = pProcessConfigurationRegister_T50Entity.RTN_SEQ;
            RTN_OTHERS = pProcessConfigurationRegister_T50Entity.RTN_OTHERS;
            LANGUAGE_TYPE = pProcessConfigurationRegister_T50Entity.LANGUAGE_TYPE;

            //메뉴별 추가 엔티티 입력
            PART_CODE = pProcessConfigurationRegister_T50Entity.PART_CODE;
            CONFIGURATION_MST_CODE = pProcessConfigurationRegister_T50Entity.CONFIGURATION_MST_CODE;
            CONFIGURATION_SEQ = pProcessConfigurationRegister_T50Entity.CONFIGURATION_SEQ;
            CONFIGURATION_MST_NAME = pProcessConfigurationRegister_T50Entity.CONFIGURATION_MST_NAME;
            CONFIGURATION_NAME = pProcessConfigurationRegister_T50Entity.CONFIGURATION_NAME;
            CONFIGURATION_VEND_CODE = pProcessConfigurationRegister_T50Entity.CONFIGURATION_VEND_CODE;
            PROCESS_GROUP = pProcessConfigurationRegister_T50Entity.PROCESS_GROUP;
            PROCESS_GUBUN = pProcessConfigurationRegister_T50Entity.PROCESS_GUBUN;
            EQUIPMENT_GROUP = pProcessConfigurationRegister_T50Entity.EQUIPMENT_GROUP;
            REVISION_NO = pProcessConfigurationRegister_T50Entity.REVISION_NO;
            SEQ = pProcessConfigurationRegister_T50Entity.SEQ;
            REMARK = pProcessConfigurationRegister_T50Entity.REMARK;


            ROUTING_MST_CODE = pProcessConfigurationRegister_T50Entity.ROUTING_MST_CODE;
            ROUTING_MST_NAME = pProcessConfigurationRegister_T50Entity.ROUTING_MST_NAME;

            ROUTING_CODE = pProcessConfigurationRegister_T50Entity.ROUTING_CODE;

            PROCESS_MST_CODE = pProcessConfigurationRegister_T50Entity.PROCESS_MST_CODE;
            PROCESS_CODE = pProcessConfigurationRegister_T50Entity.PROCESS_CODE;
            PROCESS_NAME = pProcessConfigurationRegister_T50Entity.PROCESS_NAME;
            PROCESS_TYPE = pProcessConfigurationRegister_T50Entity.PROCESS_TYPE;
            USE_YN = pProcessConfigurationRegister_T50Entity.USE_YN;
        }

        #endregion

    }

    public class DataDictionaryEntity
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
        public String LANGUAGE_TYPE { get; set; } // 언어 정보 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - GridInfoRegisterEntity()

        public DataDictionaryEntity()
        {
        }

        #endregion

        #region 생성자 - DataDictionaryEntity(pGridInfoRegisterEntity)

        public DataDictionaryEntity(DataDictionaryEntity pDataDictionaryEntity)
        {
            CORP_CODE = pDataDictionaryEntity.CORP_CODE;
            CRUD = pDataDictionaryEntity.CRUD;
            USER_CODE = pDataDictionaryEntity.USER_CODE;
            ERR_NO = pDataDictionaryEntity.ERR_NO;
            ERR_MSG = pDataDictionaryEntity.ERR_MSG;
            RTN_KEY = pDataDictionaryEntity.RTN_KEY;
            RTN_SEQ = pDataDictionaryEntity.RTN_SEQ;
            RTN_OTHERS = pDataDictionaryEntity.RTN_OTHERS;
            LANGUAGE_TYPE = pDataDictionaryEntity.LANGUAGE_TYPE;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class RuleGeneratorEntity
    {

        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // 언어 정보 값

        //로우 데이터
        public String WORKSHOP_CODE { get; set; } // 워크센터번호
        public String WORKSHOP_NAME { get; set; } // 워크센터이름
        public String RESOURCE_CODE { get; set; } // 컴포넌트번호
        public String RESOURCE_NAME { get; set; } //컴포넌트이름
        public String PGMCODE { get; set; } // 조건식1(임시)
        public String MODELYEAR { get; set; } // 조건식2(임시)

        //rule 관리
        public String RULE_OPTION { get; set; } // OPTION
        public String IF_RULE_OPTION { get; set; } // 전체 rule
        public String PARTCODE { get; set; } // rule 번호
        public String OPTION { get; set; } // 전체 rule

        //로우 선택시 이벤트 조건식 상세 출력
        public String CONDITION_VALUE { get; set; } // 조건식 값

        //저장
        public String RULE_DETAIL { get; set; } // 조건식 값

        //고정 엔티티

        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - GridInfoRegisterEntity()

        public RuleGeneratorEntity()
        {
        }

        #endregion

        #region 생성자 - RuleGeneratorEntity(pGridInfoRegisterEntity)

        public RuleGeneratorEntity(RuleGeneratorEntity pRuleGeneratorEntity)
        {
            CORP_CODE = pRuleGeneratorEntity.CORP_CODE;
            CRUD = pRuleGeneratorEntity.CRUD;
            LANGUAGE_TYPE = pRuleGeneratorEntity.LANGUAGE_TYPE;
            WORKSHOP_CODE = pRuleGeneratorEntity.WORKSHOP_CODE;
            WORKSHOP_NAME = pRuleGeneratorEntity.WORKSHOP_NAME;
            RESOURCE_CODE = pRuleGeneratorEntity.RESOURCE_CODE;
            RESOURCE_NAME = pRuleGeneratorEntity.RESOURCE_NAME;
            PARTCODE = pRuleGeneratorEntity.PARTCODE;
            PGMCODE = pRuleGeneratorEntity.PGMCODE;
            MODELYEAR = pRuleGeneratorEntity.MODELYEAR;
            RULE_OPTION = pRuleGeneratorEntity.RULE_OPTION;
            IF_RULE_OPTION = pRuleGeneratorEntity.IF_RULE_OPTION;

            //OPT 조회
            OPTION = pRuleGeneratorEntity.OPTION;

            //로우 선택시 이벤트 조건식 상세 출력
            CONDITION_VALUE = pRuleGeneratorEntity.CONDITION_VALUE;

            //저장
            RULE_DETAIL = pRuleGeneratorEntity.RULE_DETAIL;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class RuleOptionSettingEntity
    {

        #region Property

        //고정 엔티티
        public String COMPONENT { get; set; } // 컴포넌트이름

        //고정 엔티티

        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - GridInfoRegisterEntity()

        public RuleOptionSettingEntity()
        {
        }

        #endregion

        #region 생성자 - RuleOptionSettingEntity(pGridInfoRegisterEntity)

        public RuleOptionSettingEntity(RuleOptionSettingEntity pRuleOptionSettingEntity)
        {
            COMPONENT = pRuleOptionSettingEntity.COMPONENT;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ResourceCodeMstRegisterEntity
    {
        #region Property

        //사용자 설정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // 언어 정보 값

        //마스터
        public String RESOURCE_MST_CODE { get; set; }
        public String RESOURCE_MST_NAME { get; set; }
        public String RESOURCE_CODE { get; set; }
        public String RESOURCE_NAME { get; set; }
        public String RESOURCE_TYPE { get; set; }
        public String PROCESS_CODE { get; set; }
        public String PROPERTY_CODE { get; set; }
        public String SETTING_YN { get; set; }
        public String MST_REMARK { get; set; }
        public String MST_USE_YN { get; set; }



        //상세 센서
        public String SENSOR_TYPE { get; set; }
        public String SENSOR_UNIT { get; set; }
        public String IOT_CODE { get; set; }
        public String DSP_SORT { get; set; }
        public String SENSOR_FLOAT_DIGIT { get; set; }
        public String M_LIMIT_LOW { get; set; }
        public String M_LIMIT_HIGH { get; set; }
        public String LIMIT_LOW { get; set; }
        public String LIMIT_HIGH { get; set; }
        public String SENSOR_REMARK { get; set; }
        public String SENSOR_USE_YN { get; set; }



        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }

        #endregion

        #region 생성자 - ResourceCodeMstRegisterEntity()

        public ResourceCodeMstRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - ResourceCodeMstRegisterEntity(pResourceCodeMstRegisterEntity)

        public ResourceCodeMstRegisterEntity(ResourceCodeMstRegisterEntity pResourceCodeMstRegisterEntity)
        {
            CORP_CODE = pResourceCodeMstRegisterEntity.CORP_CODE;
            CRUD = pResourceCodeMstRegisterEntity.CRUD;
            USER_CODE = pResourceCodeMstRegisterEntity.USER_CODE;
            LANGUAGE_TYPE = pResourceCodeMstRegisterEntity.LANGUAGE_TYPE;
            //마스터
            RESOURCE_MST_CODE = pResourceCodeMstRegisterEntity.RESOURCE_MST_CODE;
            RESOURCE_MST_NAME = pResourceCodeMstRegisterEntity.RESOURCE_MST_NAME;
            RESOURCE_CODE = pResourceCodeMstRegisterEntity.RESOURCE_CODE;
            RESOURCE_NAME = pResourceCodeMstRegisterEntity.RESOURCE_NAME;
          
            MST_REMARK = pResourceCodeMstRegisterEntity.MST_REMARK;

            MST_USE_YN = pResourceCodeMstRegisterEntity.MST_USE_YN;

            //상세 센서
            SENSOR_UNIT = pResourceCodeMstRegisterEntity.SENSOR_UNIT;
            SENSOR_TYPE = pResourceCodeMstRegisterEntity.SENSOR_TYPE;
            IOT_CODE = pResourceCodeMstRegisterEntity.IOT_CODE;
            SENSOR_FLOAT_DIGIT = pResourceCodeMstRegisterEntity.SENSOR_FLOAT_DIGIT;
            M_LIMIT_LOW = pResourceCodeMstRegisterEntity.M_LIMIT_LOW;
            M_LIMIT_HIGH = pResourceCodeMstRegisterEntity.M_LIMIT_HIGH;
            LIMIT_LOW = pResourceCodeMstRegisterEntity.LIMIT_LOW;
            LIMIT_HIGH = pResourceCodeMstRegisterEntity.LIMIT_HIGH;
            SENSOR_REMARK = pResourceCodeMstRegisterEntity.SENSOR_REMARK;
            SENSOR_USE_YN = pResourceCodeMstRegisterEntity.SENSOR_USE_YN;

            ERR_NO = pResourceCodeMstRegisterEntity.ERR_NO;
            ERR_MSG = pResourceCodeMstRegisterEntity.ERR_MSG;
            RTN_KEY = pResourceCodeMstRegisterEntity.RTN_KEY;
            RTN_SEQ = pResourceCodeMstRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pResourceCodeMstRegisterEntity.RTN_OTHERS;
        }

        #endregion

    }

    public class InspectCodeMstRegisterEntity
    {
        #region Property

        //사용자 설정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // 언어 정보 값

        //마스터

        public String RESOURCE_CODE { get; set; }
        public String RESOURCE_NAME { get; set; }
        public String RESOURCE_TYPE { get; set; }
        public String PROCESS_CODE { get; set; }
        public String PROPERTY_CODE { get; set; }
        public String SETTING_YN { get; set; }
        public String REMARK { get; set; }
        public String USE_YN { get; set; }



        //상세 센서
        public String SENSOR_UNIT { get; set; }
        public String SENSOR_FLOAT_DIGIT { get; set; }
        public String M_LIMIT_LOW { get; set; }
        public String M_LIMIT_HIGH { get; set; }
        public String LIMIT_LOW { get; set; }
        public String LIMIT_HIGH { get; set; }
        public String SENSOR_REMARK { get; set; }

        //시험검사
        public String INSPECT_GROUP_CODE { get; set; }
        public String INSPECT_GROUP_NAME { get; set; }
        public String INSPECT_CODE { get; set; }
        public String INSPECT_NAME { get; set; }
        public String INSPECT_VALUE { get; set; }

        //


        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }

        #endregion

        #region 생성자 - InspectCodeMstRegisterEntity()

        public InspectCodeMstRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - InspectCodeMstRegisterEntity(pInspectCodeMstRegisterEntity)

        public InspectCodeMstRegisterEntity(InspectCodeMstRegisterEntity pInspectCodeMstRegisterEntity)
        {
            CORP_CODE = pInspectCodeMstRegisterEntity.CORP_CODE;
            CRUD = pInspectCodeMstRegisterEntity.CRUD;
            USER_CODE = pInspectCodeMstRegisterEntity.USER_CODE;
            LANGUAGE_TYPE = pInspectCodeMstRegisterEntity.LANGUAGE_TYPE;
            //마스터

            RESOURCE_CODE = pInspectCodeMstRegisterEntity.RESOURCE_CODE;
            RESOURCE_NAME = pInspectCodeMstRegisterEntity.RESOURCE_NAME;
            PROCESS_CODE = pInspectCodeMstRegisterEntity.PROCESS_CODE;
            PROPERTY_CODE = pInspectCodeMstRegisterEntity.PROPERTY_CODE;

            SETTING_YN = pInspectCodeMstRegisterEntity.SETTING_YN;

            REMARK = pInspectCodeMstRegisterEntity.REMARK;

            USE_YN = pInspectCodeMstRegisterEntity.USE_YN;

            //상세 센서
            SENSOR_UNIT = pInspectCodeMstRegisterEntity.SENSOR_UNIT;
            SENSOR_FLOAT_DIGIT = pInspectCodeMstRegisterEntity.SENSOR_FLOAT_DIGIT;
            M_LIMIT_LOW = pInspectCodeMstRegisterEntity.M_LIMIT_LOW;
            M_LIMIT_HIGH = pInspectCodeMstRegisterEntity.M_LIMIT_HIGH;
            LIMIT_LOW = pInspectCodeMstRegisterEntity.LIMIT_LOW;
            LIMIT_HIGH = pInspectCodeMstRegisterEntity.LIMIT_HIGH;
            SENSOR_REMARK = pInspectCodeMstRegisterEntity.SENSOR_REMARK;



            ERR_NO = pInspectCodeMstRegisterEntity.ERR_NO;
            ERR_MSG = pInspectCodeMstRegisterEntity.ERR_MSG;
            RTN_KEY = pInspectCodeMstRegisterEntity.RTN_KEY;
            RTN_SEQ = pInspectCodeMstRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pInspectCodeMstRegisterEntity.RTN_OTHERS;
        }

        #endregion

    }

    public class BadCodeMstRegisterEntity
    {
        #region Property

        //사용자 설정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // 언어 정보 값

        //마스터
        public string BAD_GROUP_CODE { get; set; } // 불량 그룹 코드
        public string BAD_GROUP_NAME { get; set; } // 불량 그룹 이름
        public string REMARK { get; set; }  // 비고
        public string USE_YN { get; set; }  // 사용여부

        //서브

        public string BAD_CODE { get; set; } // 불량 코드
        public string BAD_NAME { get; set; } // 불량 이름

        #endregion

        #region 생성자 - BadCodeMstRegisterEntity()
        public BadCodeMstRegisterEntity()
        {
        }
        #endregion

        #region 생성자 - BadCodeMstRegisterEntity(pBadCodeMstRegisterEntity)
        public BadCodeMstRegisterEntity(BadCodeMstRegisterEntity pBadCodeMstRegisterEntity)
        {
            // 사용자 설정 엔티티
            CORP_CODE = pBadCodeMstRegisterEntity.CORP_CODE;
            USER_CODE = pBadCodeMstRegisterEntity.USER_CODE;
            CRUD = pBadCodeMstRegisterEntity.CRUD;
            LANGUAGE_TYPE = pBadCodeMstRegisterEntity.LANGUAGE_TYPE;

            // 마스터
            BAD_GROUP_CODE = pBadCodeMstRegisterEntity.BAD_GROUP_CODE;
            BAD_GROUP_NAME = pBadCodeMstRegisterEntity.BAD_GROUP_NAME;
            REMARK = pBadCodeMstRegisterEntity.REMARK;
            USE_YN = pBadCodeMstRegisterEntity.USE_YN;
        }
        #endregion
    }

    public class EquipmentStopCodeMstRegisterEntity
    {
        #region Property
        //사용자 설정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // 언어 정보 값

        // 마스터

        public string EQUIPMENT_STOP_GROUP_CODE { get; set; } // 비가동 그룹 코드
        public string EQUIPMENT_STOP_GROUP_NAME { get; set; } // 비가동 그룹 이름
        public string REMARK { get; set; } // 비고
        public string USE_YN { get; set; } // 사용여부

        // 서브
        public string EQUIP_STOP_CODE { get; set; } // 비가동 코드
        public string EQUIP_STOP_NAME { get; set; } // 비가동 이름
        #endregion

        #region 생성자 - EquipmentStopCodeMstRegisterEntity()
        public EquipmentStopCodeMstRegisterEntity()
        {
        }
        #endregion

        #region 생성자 - EquipmentStopCodeMstRegisterEntity(pEquipmentStopCodeMstRegisterEntity)

        public EquipmentStopCodeMstRegisterEntity(EquipmentStopCodeMstRegisterEntity pEquipmentStopCodeMstRegisterEntity)
        {
            // 사용자 설정 엔티티
            CORP_CODE = pEquipmentStopCodeMstRegisterEntity.CORP_CODE;
            USER_CODE = pEquipmentStopCodeMstRegisterEntity.USER_CODE;
            CRUD = pEquipmentStopCodeMstRegisterEntity.CRUD;
            LANGUAGE_TYPE = pEquipmentStopCodeMstRegisterEntity.LANGUAGE_TYPE;

            // 마스터
            EQUIPMENT_STOP_GROUP_CODE = pEquipmentStopCodeMstRegisterEntity.EQUIPMENT_STOP_GROUP_CODE;
            EQUIPMENT_STOP_GROUP_NAME = pEquipmentStopCodeMstRegisterEntity.EQUIPMENT_STOP_GROUP_NAME;
            REMARK = pEquipmentStopCodeMstRegisterEntity.REMARK;
            USE_YN = pEquipmentStopCodeMstRegisterEntity.USE_YN;
        }

        #endregion
    }

    public class InspectPartMappingRegisterEntity
    {
        #region Property
        //사용자 설정 엔티티
        public String CORP_CODE { get; set; }       // 회사코드
        public String USER_CODE { get; set; }       // 사용자 정보
        public String CRUD { get; set; }            // CRUD
        public String LANGUAGE_TYPE { get; set; }    // 언어타입

        public String PART_TYPE { get; set; }       // 품목타입
        public String PART_CODE { get; set; }       // 품목코드
        public String PART_NAME { get; set; }       // 품목명칭
        public String VEND_PART_CODE { get; set; }       // 업체품번
        public String INSPECT_CODE { get; set; }    // 시험코드
        public String REMARK { get; set; }          // 비고
        public String USE_YN { get; set; }          // 사용유무
        public String REG_DATE { get; set; }        // 등록일자
        public String REG_USER { get; set; }        // 등록자
        public String UP_DATE { get; set; }         // 수정일자
        public String UP_USER { get; set; }         // 수정자

        // 리턴값
        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_AQ { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }

        #endregion

        #region 생성자 - InspectPartMappingRegisterEntity()
        public InspectPartMappingRegisterEntity()
        {

        }
        #endregion

        #region 생성자 - InspectPartMappingRegisterEntity(pInspectPartMappingRegisterEntity)

        public InspectPartMappingRegisterEntity(InspectPartMappingRegisterEntity pInspectPartMappingRegisterEntity)
        {
            // 사용자 설정 엔티티
            CORP_CODE = pInspectPartMappingRegisterEntity.CORP_CODE;
            USER_CODE = pInspectPartMappingRegisterEntity.USER_CODE;
            CRUD = pInspectPartMappingRegisterEntity.CRUD;
            LANGUAGE_TYPE = pInspectPartMappingRegisterEntity.LANGUAGE_TYPE;

            PART_TYPE = pInspectPartMappingRegisterEntity.PART_TYPE;
            PART_CODE = pInspectPartMappingRegisterEntity.PART_CODE;
            PART_NAME = pInspectPartMappingRegisterEntity.PART_NAME;
            INSPECT_CODE = pInspectPartMappingRegisterEntity.INSPECT_CODE;
            REMARK = pInspectPartMappingRegisterEntity.REMARK;
            USE_YN = pInspectPartMappingRegisterEntity.USE_YN;
            REG_DATE = pInspectPartMappingRegisterEntity.REG_DATE;
            REG_USER = pInspectPartMappingRegisterEntity.REG_USER;
            UP_DATE = pInspectPartMappingRegisterEntity.UP_DATE;
            UP_USER = pInspectPartMappingRegisterEntity.UP_USER;
            VEND_PART_CODE = pInspectPartMappingRegisterEntity.VEND_PART_CODE;

            ERR_NO = pInspectPartMappingRegisterEntity.ERR_NO;
            ERR_MSG = pInspectPartMappingRegisterEntity.ERR_MSG;
            RTN_KEY = pInspectPartMappingRegisterEntity.RTN_KEY;
            RTN_AQ = pInspectPartMappingRegisterEntity.RTN_AQ;
            RTN_SEQ = pInspectPartMappingRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pInspectPartMappingRegisterEntity.RTN_OTHERS;
        }

        #endregion
    }

    public class PartInformationMappingRegisterEntity
    {
        #region Property
        //사용자 설정 엔티티
        public String CORP_CODE { get; set; }       // 회사코드
        public String USER_CODE { get; set; }       // 사용자 정보
        public String CRUD { get; set; }            // CRUD
        public String LANGUAGE_TYPE { get; set; }    // 언어타입

        public String PART_TYPE { get; set; }       // 품목타입
        public String PART_CODE { get; set; }       // 품목코드
        public String PART_NAME { get; set; }       // 품목명칭
        public String INSPECT_CODE { get; set; }    // 시험코드
        public String REMARK { get; set; }          // 비고
        public String USE_YN { get; set; }          // 사용유무
        public String REG_DATE { get; set; }        // 등록일자
        public String REG_USER { get; set; }        // 등록자
        public String UP_DATE { get; set; }         // 수정일자
        public String UP_USER { get; set; }         // 수정자
        public String VEND_PART_CODE { get; set; }         // 수정자

        public String MENU_TYPE { get; set; }         // 
        public String PROCESS_CODE { get; set; }         // 
        public String ROUTING_MST_CODE { get; set; }         // 
        public String PROCESS_VALUE { get; set; }         // 
        public String QA_QTY { get; set; }         // 
        public String VEND_QTY { get; set; }         // 
        public String MESH { get; set; }         // 
        public String POSITION { get; set; }         // 
        public String WORK_REMARK { get; set; }         // 
        public String OUT_BOX { get; set; }         // 
        public String IN_BOX { get; set; }         // 
        
        // 리턴값
        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_AQ { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }

        #endregion

        #region 생성자 - PartInformationMappingRegisterEntity()
        public PartInformationMappingRegisterEntity()
        {

        }
        #endregion

        #region 생성자 - PartInformationMappingRegisterEntity(pPartInformationMappingRegisterEntity)

        public PartInformationMappingRegisterEntity(PartInformationMappingRegisterEntity pPartInformationMappingRegisterEntity)
        {
            // 사용자 설정 엔티티
            CORP_CODE = pPartInformationMappingRegisterEntity.CORP_CODE;
            USER_CODE = pPartInformationMappingRegisterEntity.USER_CODE;
            CRUD = pPartInformationMappingRegisterEntity.CRUD;
            LANGUAGE_TYPE = pPartInformationMappingRegisterEntity.LANGUAGE_TYPE;

            PART_TYPE = pPartInformationMappingRegisterEntity.PART_TYPE;
            PART_CODE = pPartInformationMappingRegisterEntity.PART_CODE;
            PART_NAME = pPartInformationMappingRegisterEntity.PART_NAME;
            INSPECT_CODE = pPartInformationMappingRegisterEntity.INSPECT_CODE;
            REMARK = pPartInformationMappingRegisterEntity.REMARK;
            USE_YN = pPartInformationMappingRegisterEntity.USE_YN;
            REG_DATE = pPartInformationMappingRegisterEntity.REG_DATE;
            REG_USER = pPartInformationMappingRegisterEntity.REG_USER;
            UP_DATE = pPartInformationMappingRegisterEntity.UP_DATE;
            UP_USER = pPartInformationMappingRegisterEntity.UP_USER;
            VEND_PART_CODE = pPartInformationMappingRegisterEntity.VEND_PART_CODE;
            MENU_TYPE = pPartInformationMappingRegisterEntity.MENU_TYPE;
            POSITION = pPartInformationMappingRegisterEntity.POSITION;
            
            PROCESS_CODE = pPartInformationMappingRegisterEntity.PROCESS_CODE;
            ROUTING_MST_CODE = pPartInformationMappingRegisterEntity.ROUTING_MST_CODE;
            PROCESS_VALUE = pPartInformationMappingRegisterEntity.PROCESS_VALUE;
            QA_QTY = pPartInformationMappingRegisterEntity.QA_QTY;
            VEND_QTY = pPartInformationMappingRegisterEntity.VEND_QTY;
            MESH = pPartInformationMappingRegisterEntity.MESH;
            WORK_REMARK = pPartInformationMappingRegisterEntity.WORK_REMARK;
            OUT_BOX = pPartInformationMappingRegisterEntity.OUT_BOX;
            IN_BOX = pPartInformationMappingRegisterEntity.IN_BOX;
            ERR_NO = pPartInformationMappingRegisterEntity.ERR_NO;
            ERR_MSG = pPartInformationMappingRegisterEntity.ERR_MSG;
            RTN_KEY = pPartInformationMappingRegisterEntity.RTN_KEY;
            RTN_AQ = pPartInformationMappingRegisterEntity.RTN_AQ;
            RTN_SEQ = pPartInformationMappingRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pPartInformationMappingRegisterEntity.RTN_OTHERS;
        }

        #endregion
    }
    public class ucPartProcessMapping_PopUpEntity
    {
        #region Property
        //사용자 설정 엔티티
        public String CORP_CODE { get; set; }       // 회사코드
        public String USER_CODE { get; set; }       // 사용자 정보
        public String CRUD { get; set; }            // CRUD
        public String LANGUAGE_TYPE { get; set; }    // 언어타입

        public String CONFIGURATION_MST_CODE { get; set; }     
        public String CONFIGURATION_MST_NAME { get; set; }       // 품목코드
        public String PART_CODE { get; set; }       // 품목명칭
        public String PART_NAME { get; set; }    // 시험코드

        public Int32 DSP_SORT { get; set; }
        public String REMARK { get; set; }
        public String USE_YN { get; set; }

        // 리턴값
        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_AQ { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }

        #endregion

        #region 생성자 - ucPartProcessMapping_PopUpEntity()
        public ucPartProcessMapping_PopUpEntity()
        {

        }
        #endregion

        #region 생성자 - ucPartProcessMapping_PopUpEntity(pucPartProcessMapping_PopUpEntity)

        public ucPartProcessMapping_PopUpEntity(ucPartProcessMapping_PopUpEntity pucPartProcessMapping_PopUpEntity)
        {
            // 사용자 설정 엔티티
            CORP_CODE = pucPartProcessMapping_PopUpEntity.CORP_CODE;
            USER_CODE = pucPartProcessMapping_PopUpEntity.USER_CODE;
            CRUD = pucPartProcessMapping_PopUpEntity.CRUD;
            LANGUAGE_TYPE = pucPartProcessMapping_PopUpEntity.LANGUAGE_TYPE;


            CONFIGURATION_MST_CODE = pucPartProcessMapping_PopUpEntity.CONFIGURATION_MST_CODE;
            CONFIGURATION_MST_NAME = pucPartProcessMapping_PopUpEntity.CONFIGURATION_MST_NAME;
           
            PART_CODE = pucPartProcessMapping_PopUpEntity.PART_CODE;
            PART_NAME = pucPartProcessMapping_PopUpEntity.PART_NAME;

            DSP_SORT = pucPartProcessMapping_PopUpEntity.DSP_SORT;
            REMARK = pucPartProcessMapping_PopUpEntity.REMARK;
            USE_YN = pucPartProcessMapping_PopUpEntity.USE_YN;
        
            ERR_NO = pucPartProcessMapping_PopUpEntity.ERR_NO;
            ERR_MSG = pucPartProcessMapping_PopUpEntity.ERR_MSG;
            RTN_KEY = pucPartProcessMapping_PopUpEntity.RTN_KEY;
            RTN_AQ = pucPartProcessMapping_PopUpEntity.RTN_AQ;
            RTN_SEQ = pucPartProcessMapping_PopUpEntity.RTN_SEQ;
            RTN_OTHERS = pucPartProcessMapping_PopUpEntity.RTN_OTHERS;
        }

        #endregion
    }

    public class ucPartProcessMapping_PopUp_T01Entity
    {
        #region Property
        //사용자 설정 엔티티
        public String CORP_CODE { get; set; }       // 회사코드
        public String USER_CODE { get; set; }       // 사용자 정보
        public String CRUD { get; set; }            // CRUD
        public String LANGUAGE_TYPE { get; set; }    // 언어타입

        public String CONFIGURATION_MST_CODE { get; set; }
        public String CONFIGURATION_MST_NAME { get; set; }       // 품목코드
        public String PART_CODE { get; set; }       // 품목명칭
        public String PART_NAME { get; set; }    // 시험코드
        public String PART_HIGH { get; set; }
        public String PART_MIDDLE { get; set; }
        public String PART_LOW { get; set; }
        public Int32 DSP_SORT { get; set; }
        public String REMARK { get; set; }
        public String USE_YN { get; set; }

        // 리턴값
        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_AQ { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }

        #endregion

        #region 생성자 - ucPartProcessMapping_PopUp_T01Entity()
        public ucPartProcessMapping_PopUp_T01Entity()
        {

        }
        #endregion

        #region 생성자 - ucPartProcessMapping_PopUp_T01Entity(ucPartProcessMapping_PopUp_T01Entity)

        public ucPartProcessMapping_PopUp_T01Entity(ucPartProcessMapping_PopUp_T01Entity pucPartProcessMapping_PopUp_T01Entity)
        {
            // 사용자 설정 엔티티
            CORP_CODE = pucPartProcessMapping_PopUp_T01Entity.CORP_CODE;
            USER_CODE = pucPartProcessMapping_PopUp_T01Entity.USER_CODE;
            CRUD = pucPartProcessMapping_PopUp_T01Entity.CRUD;
            LANGUAGE_TYPE = pucPartProcessMapping_PopUp_T01Entity.LANGUAGE_TYPE;


            CONFIGURATION_MST_CODE = pucPartProcessMapping_PopUp_T01Entity.CONFIGURATION_MST_CODE;
            CONFIGURATION_MST_NAME = pucPartProcessMapping_PopUp_T01Entity.CONFIGURATION_MST_NAME;

            PART_CODE = pucPartProcessMapping_PopUp_T01Entity.PART_CODE;
            PART_NAME = pucPartProcessMapping_PopUp_T01Entity.PART_NAME;
            PART_HIGH = pucPartProcessMapping_PopUp_T01Entity.PART_HIGH;
            PART_MIDDLE = pucPartProcessMapping_PopUp_T01Entity.PART_MIDDLE;
            PART_LOW = pucPartProcessMapping_PopUp_T01Entity.PART_LOW;


            DSP_SORT = pucPartProcessMapping_PopUp_T01Entity.DSP_SORT;
            REMARK = pucPartProcessMapping_PopUp_T01Entity.REMARK;
            USE_YN = pucPartProcessMapping_PopUp_T01Entity.USE_YN;

            ERR_NO = pucPartProcessMapping_PopUp_T01Entity.ERR_NO;
            ERR_MSG = pucPartProcessMapping_PopUp_T01Entity.ERR_MSG;
            RTN_KEY = pucPartProcessMapping_PopUp_T01Entity.RTN_KEY;
            RTN_AQ = pucPartProcessMapping_PopUp_T01Entity.RTN_AQ;
            RTN_SEQ = pucPartProcessMapping_PopUp_T01Entity.RTN_SEQ;
            RTN_OTHERS = pucPartProcessMapping_PopUp_T01Entity.RTN_OTHERS;
        }

        #endregion
    }

    public class LabelCodeRegisterEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE


        public String WINDOW_NAME { get; set; }
        public String LABEL_CODE { get; set; }
        public String LABEL_NAME { get; set; }
        public String PROCESS_CODE { get; set; }
        public String PROCESS_NAME { get; set; }
        public String TERMINAL_CODE { get; set; }
        public String TERMINAL_NAME { get; set; }
        public String CMD { get; set; }
        public String USE_YN { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - LabelCodeRegisterEntity()

        public LabelCodeRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - LabelCodeRegisterEntity(pLabelCodeRegisterEntity)

        public LabelCodeRegisterEntity(LabelCodeRegisterEntity pLabelCodeRegisterEntity)
        {
            CORP_CODE = pLabelCodeRegisterEntity.CORP_CODE;
            CRUD = pLabelCodeRegisterEntity.CRUD;
            USER_CODE = pLabelCodeRegisterEntity.USER_CODE;
            LANGUAGE_TYPE = pLabelCodeRegisterEntity.LANGUAGE_TYPE;

            pLabelCodeRegisterEntity.LABEL_CODE = LABEL_CODE;
            pLabelCodeRegisterEntity.LABEL_NAME = LABEL_NAME;
            pLabelCodeRegisterEntity.PROCESS_CODE = PROCESS_CODE;
            pLabelCodeRegisterEntity.PROCESS_NAME = PROCESS_NAME;
            pLabelCodeRegisterEntity.TERMINAL_CODE = TERMINAL_CODE;
            pLabelCodeRegisterEntity.TERMINAL_NAME = TERMINAL_NAME;
            pLabelCodeRegisterEntity.CMD = CMD;
            pLabelCodeRegisterEntity.USE_YN = USE_YN;

            ERR_NO = pLabelCodeRegisterEntity.ERR_NO;
            ERR_MSG = pLabelCodeRegisterEntity.ERR_MSG;
            RTN_KEY = pLabelCodeRegisterEntity.RTN_KEY;
            RTN_SEQ = pLabelCodeRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pLabelCodeRegisterEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class BarcodePrintRegisterEntity
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
        public String DATE_FROM { get; set; }
        public String DATE_TO { get; set; }
        public String CMD { get; set; }
        public String USE_YN { get; set; }

        public String VEND_CODE { get; set; }

        public String PART_BARCODE { get; set; }
        public String PRINT_DATE { get; set; }
        public String PRINT_SEQ { get; set; }
        public String PRINT_CODE { get; set; }
        public String PART_QTY { get; set; }

        public String TERMINAL_NAME { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - BarcodePrintRegisterEntity()

        public BarcodePrintRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - BarcodePrintRegisterEntity(pBarcodePrintRegisterEntity)

        public BarcodePrintRegisterEntity(BarcodePrintRegisterEntity pBarcodePrintRegisterEntity)
        {
            CORP_CODE = pBarcodePrintRegisterEntity.CORP_CODE;
            CRUD = pBarcodePrintRegisterEntity.CRUD;
            USER_CODE = pBarcodePrintRegisterEntity.USER_CODE;
            USER_NAME = pBarcodePrintRegisterEntity.USER_NAME;
            LANGUAGE_TYPE = pBarcodePrintRegisterEntity.LANGUAGE_TYPE;

            pBarcodePrintRegisterEntity.LABEL_CODE = LABEL_CODE;
            pBarcodePrintRegisterEntity.LABEL_NAME = LABEL_NAME;
            pBarcodePrintRegisterEntity.PART_CODE = PART_CODE;
            pBarcodePrintRegisterEntity.PART_NAME = PART_NAME;
            pBarcodePrintRegisterEntity.DATE_FROM = DATE_FROM;
            pBarcodePrintRegisterEntity.DATE_TO = DATE_TO;
            pBarcodePrintRegisterEntity.CMD = CMD;
            pBarcodePrintRegisterEntity.USE_YN = USE_YN;

            pBarcodePrintRegisterEntity.VEND_CODE = VEND_CODE;

            pBarcodePrintRegisterEntity.PART_BARCODE = PART_BARCODE;
            pBarcodePrintRegisterEntity.PRINT_DATE = PRINT_DATE;
            pBarcodePrintRegisterEntity.PRINT_SEQ = PRINT_SEQ;
            pBarcodePrintRegisterEntity.PRINT_CODE = PRINT_CODE;
            pBarcodePrintRegisterEntity.PART_QTY = PART_QTY;

            pBarcodePrintRegisterEntity.TERMINAL_NAME = TERMINAL_NAME;

            ERR_NO = pBarcodePrintRegisterEntity.ERR_NO;
            ERR_MSG = pBarcodePrintRegisterEntity.ERR_MSG;
            RTN_KEY = pBarcodePrintRegisterEntity.RTN_KEY;
            RTN_SEQ = pBarcodePrintRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pBarcodePrintRegisterEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class ucTerminalDetailInfoPopup_Entity
    {
        #region Property
        //사용자 설정 엔티티
        public String CORP_CODE { get; set; }       // 회사코드
        public String USER_CODE { get; set; }       // 사용자 정보
        public String CRUD { get; set; }            // CRUD
        public String LANGUAGE_TYPE { get; set; }    // 언어타입

        public String TERMINAL_CODE { get; set; }
        public String TERMINAL_SEQ { get; set; }

        public String INFO_GUBN { get; set; }
        public String INFO_NAME { get; set; }
        public String INFO_TCPIP { get; set; }
        public String INFO_TCPPORT { get; set; }
        public String INFO_INTERVAL { get; set; }
        public String INFO_PORT_NAME { get; set; }
        public String INFO_BAUD_RATE { get; set; }
        public String INFO_PARITY { get; set; }
        public String INFO_DATA_BITS { get; set; }
        public String INFO_STOP_BITS { get; set; }
        
        public Int32 DSP_SORT { get; set; }
        public String REMARK { get; set; }
        public String USE_YN { get; set; }

        // 리턴값
        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_AQ { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }

        #endregion

        #region 생성자 - ucTerminalDetailInfoPopup_Entity()
        public ucTerminalDetailInfoPopup_Entity()
        {

        }
        #endregion

        #region 생성자 - ucTerminalDetailInfoPopup_Entity(pucTerminalDetailInfoPopup_Entity)

        public ucTerminalDetailInfoPopup_Entity(ucTerminalDetailInfoPopup_Entity pucTerminalDetailInfoPopup_Entity)
        {
            // 사용자 설정 엔티티
            CORP_CODE = pucTerminalDetailInfoPopup_Entity.CORP_CODE;
            USER_CODE = pucTerminalDetailInfoPopup_Entity.USER_CODE;
            CRUD = pucTerminalDetailInfoPopup_Entity.CRUD;
            LANGUAGE_TYPE = pucTerminalDetailInfoPopup_Entity.LANGUAGE_TYPE;
             
            TERMINAL_CODE = pucTerminalDetailInfoPopup_Entity.TERMINAL_CODE;
            TERMINAL_SEQ = pucTerminalDetailInfoPopup_Entity.TERMINAL_SEQ;

            INFO_GUBN = pucTerminalDetailInfoPopup_Entity.INFO_GUBN;
            INFO_NAME = pucTerminalDetailInfoPopup_Entity.INFO_NAME;
            INFO_TCPIP = pucTerminalDetailInfoPopup_Entity.INFO_TCPIP;
            INFO_TCPPORT = pucTerminalDetailInfoPopup_Entity.INFO_TCPPORT;
            INFO_INTERVAL = pucTerminalDetailInfoPopup_Entity.INFO_INTERVAL;
            INFO_PORT_NAME = pucTerminalDetailInfoPopup_Entity.INFO_PORT_NAME;
            INFO_BAUD_RATE = pucTerminalDetailInfoPopup_Entity.INFO_BAUD_RATE;
            INFO_PARITY = pucTerminalDetailInfoPopup_Entity.INFO_PARITY;
            INFO_DATA_BITS = pucTerminalDetailInfoPopup_Entity.INFO_DATA_BITS;
            INFO_STOP_BITS = pucTerminalDetailInfoPopup_Entity.INFO_STOP_BITS;

            DSP_SORT = pucTerminalDetailInfoPopup_Entity.DSP_SORT;
            REMARK = pucTerminalDetailInfoPopup_Entity.REMARK;
            USE_YN = pucTerminalDetailInfoPopup_Entity.USE_YN;

            ERR_NO = pucTerminalDetailInfoPopup_Entity.ERR_NO;
            ERR_MSG = pucTerminalDetailInfoPopup_Entity.ERR_MSG;
            RTN_KEY = pucTerminalDetailInfoPopup_Entity.RTN_KEY;
            RTN_AQ = pucTerminalDetailInfoPopup_Entity.RTN_AQ;
            RTN_SEQ = pucTerminalDetailInfoPopup_Entity.RTN_SEQ;
            RTN_OTHERS = pucTerminalDetailInfoPopup_Entity.RTN_OTHERS;
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

    public class NoticeRegisterEntity
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
        public String NOTICE_ID { get; set; }
        public String NOTICE_NAME { get; set; }
        public String NOTICE_DATE { get; set; }
        public String NOTICE_DETAIL { get; set; }
        public String USE_YN { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - NoticeRegisterEntity()

        public NoticeRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - NoticeRegisterEntity(pNoticeRegisterEntity)

        public NoticeRegisterEntity(NoticeRegisterEntity pNoticeRegisterEntity)
        {
            CORP_CODE = pNoticeRegisterEntity.CORP_CODE;
            CRUD = pNoticeRegisterEntity.CRUD;
            USER_CODE = pNoticeRegisterEntity.USER_CODE;
            LANGUAGE_TYPE = pNoticeRegisterEntity.LANGUAGE_TYPE;

            pNoticeRegisterEntity.DATE_FROM = DATE_FROM;
            pNoticeRegisterEntity.DATE_TO = DATE_TO;
            pNoticeRegisterEntity.NOTICE_ID = NOTICE_ID;
            pNoticeRegisterEntity.NOTICE_NAME = NOTICE_NAME;
            pNoticeRegisterEntity.NOTICE_DATE = NOTICE_DATE;
            pNoticeRegisterEntity.NOTICE_DETAIL = NOTICE_DETAIL;
            pNoticeRegisterEntity.USE_YN = USE_YN;

            ERR_NO = pNoticeRegisterEntity.ERR_NO;
            ERR_MSG = pNoticeRegisterEntity.ERR_MSG;
            RTN_KEY = pNoticeRegisterEntity.RTN_KEY;
            RTN_SEQ = pNoticeRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pNoticeRegisterEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class CommentInfoRegisterEntity
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
        public String COMMENT_ID { get; set; }
        public String COMMENT_DETAIL { get; set; }
        public String USE_YN { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - CommentInfoRegisterEntity()

        public CommentInfoRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - CommentInfoRegisterEntity(pCommentInfoRegisterEntity)

        public CommentInfoRegisterEntity(CommentInfoRegisterEntity pCommentInfoRegisterEntity)
        {
            CORP_CODE = pCommentInfoRegisterEntity.CORP_CODE;
            CRUD = pCommentInfoRegisterEntity.CRUD;
            USER_CODE = pCommentInfoRegisterEntity.USER_CODE;
            LANGUAGE_TYPE = pCommentInfoRegisterEntity.LANGUAGE_TYPE;

            pCommentInfoRegisterEntity.DATE_FROM = DATE_FROM;
            pCommentInfoRegisterEntity.DATE_TO = DATE_TO;
            pCommentInfoRegisterEntity.COMMENT_ID = COMMENT_ID;
            pCommentInfoRegisterEntity.COMMENT_DETAIL = COMMENT_DETAIL;
            pCommentInfoRegisterEntity.USE_YN = USE_YN;

            ERR_NO = pCommentInfoRegisterEntity.ERR_NO;
            ERR_MSG = pCommentInfoRegisterEntity.ERR_MSG;
            RTN_KEY = pCommentInfoRegisterEntity.RTN_KEY;
            RTN_SEQ = pCommentInfoRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pCommentInfoRegisterEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class POP_NoticeRegisterEntity
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
        public String NOTICE_ID { get; set; }
        public String NOTICE_NAME { get; set; }
        public String NOTICE_DATE { get; set; }
        public String NOTICE_DETAIL { get; set; }
        public String USE_YN { get; set; }

        public String ERR_NO { get; set; } //오류 번호
        public String ERR_MSG { get; set; } //오류 메시지
        public String RTN_KEY { get; set; } // 리턴 키값
        public String RTN_SEQ { get; set; } // 리턴 순번 값
        public String RTN_OTHERS { get; set; } // 리턴 기타 값

        //고정 엔티티


        //메뉴별 추가 엔티티 입력


        #endregion

        #region 생성자 - NoticeRegisterEntity()

        public POP_NoticeRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - NoticeRegisterEntity(pNoticeRegisterEntity)

        public POP_NoticeRegisterEntity(POP_NoticeRegisterEntity pPOP_NoticeRegisterEntity)
        {
            CORP_CODE = pPOP_NoticeRegisterEntity.CORP_CODE;
            CRUD = pPOP_NoticeRegisterEntity.CRUD;
            USER_CODE = pPOP_NoticeRegisterEntity.USER_CODE;
            LANGUAGE_TYPE = pPOP_NoticeRegisterEntity.LANGUAGE_TYPE;

            pPOP_NoticeRegisterEntity.DATE_FROM = DATE_FROM;
            pPOP_NoticeRegisterEntity.DATE_TO = DATE_TO;
            pPOP_NoticeRegisterEntity.NOTICE_ID = NOTICE_ID;
            pPOP_NoticeRegisterEntity.NOTICE_NAME = NOTICE_NAME;
            pPOP_NoticeRegisterEntity.NOTICE_DATE = NOTICE_DATE;
            pPOP_NoticeRegisterEntity.NOTICE_DETAIL = NOTICE_DETAIL;
            pPOP_NoticeRegisterEntity.USE_YN = USE_YN;

            ERR_NO = pPOP_NoticeRegisterEntity.ERR_NO;
            ERR_MSG = pPOP_NoticeRegisterEntity.ERR_MSG;
            RTN_KEY = pPOP_NoticeRegisterEntity.RTN_KEY;
            RTN_SEQ = pPOP_NoticeRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pPOP_NoticeRegisterEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }



    public class ucProcessDocumentListPopupEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String WINDOW_NAME { get; set; }
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE

        public String PROCESS_CODE { get; set; }
        public String PROCESS_NAME { get; set; }

        public String DOCUMENT_TYPE { get; set; }
        public String DOCUMENT_NAME { get; set; }
        public String DOCUMENT_VER { get; set; }
        public String DOCUMENT_FILE_NAME { get; set; }
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

        #region 생성자 - ucProcessDocumentListPopupEntity()

        public ucProcessDocumentListPopupEntity()
        {
        }

        #endregion

        #region 생성자 - ucProcessDocumentListPopupEntity(ucProcessDocumentListPopupEntity pucProcessDocumentListPopupEntity)

        public ucProcessDocumentListPopupEntity(ucProcessDocumentListPopupEntity pucProcessDocumentListPopupEntity)
        {
            CORP_CODE = pucProcessDocumentListPopupEntity.CORP_CODE;
            CRUD = pucProcessDocumentListPopupEntity.CRUD;
            USER_CODE = pucProcessDocumentListPopupEntity.USER_CODE;
            LANGUAGE_TYPE = pucProcessDocumentListPopupEntity.LANGUAGE_TYPE;
            WINDOW_NAME = pucProcessDocumentListPopupEntity.WINDOW_NAME;

            PROCESS_CODE = pucProcessDocumentListPopupEntity.PROCESS_CODE;
            PROCESS_NAME = pucProcessDocumentListPopupEntity.PROCESS_NAME;

            DOCUMENT_FILE_NAME = pucProcessDocumentListPopupEntity.DOCUMENT_FILE_NAME;
            DOCUMENT_TYPE = pucProcessDocumentListPopupEntity.DOCUMENT_TYPE;
            DOCUMENT_NAME = pucProcessDocumentListPopupEntity.DOCUMENT_NAME;
            DOCUMENT_VER = pucProcessDocumentListPopupEntity.DOCUMENT_VER;



            USE_YN = pucProcessDocumentListPopupEntity.USE_YN;

            ERR_NO = pucProcessDocumentListPopupEntity.ERR_NO;
            ERR_MSG = pucProcessDocumentListPopupEntity.ERR_MSG;
            RTN_KEY = pucProcessDocumentListPopupEntity.RTN_KEY;
            RTN_SEQ = pucProcessDocumentListPopupEntity.RTN_SEQ;
            RTN_AQ = pucProcessDocumentListPopupEntity.RTN_AQ;
            RTN_SQ = pucProcessDocumentListPopupEntity.RTN_SQ;
            RTN_OTHERS = pucProcessDocumentListPopupEntity.RTN_OTHERS;
            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class ucProRoutingDocumentListPopupEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String WINDOW_NAME { get; set; }
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE

        public String CONFIGURATION_MST_CODE { get; set; }
        public String CONFIGURATION_SEQ { get; set; }
        public String CONFIGURATION_CODE { get; set; }

        public String DOCUMENT_TYPE { get; set; }
        public String DOCUMENT_NAME { get; set; }
        public String DOCUMENT_VER { get; set; }
        public String DOCUMENT_FILE_NAME { get; set; }
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

        #region 생성자 - ucProRoutingDocumentListPopupEntity()

        public ucProRoutingDocumentListPopupEntity()
        {
        }

        #endregion

        #region 생성자 - ucProRoutingDocumentListPopupEntity(ucProRoutingDocumentListPopupEntity pucProRoutingDocumentListPopupEntity)

        public ucProRoutingDocumentListPopupEntity(ucProRoutingDocumentListPopupEntity pucProRoutingDocumentListPopupEntity)
        {
            CORP_CODE = pucProRoutingDocumentListPopupEntity.CORP_CODE;
            CRUD = pucProRoutingDocumentListPopupEntity.CRUD;
            USER_CODE = pucProRoutingDocumentListPopupEntity.USER_CODE;
            LANGUAGE_TYPE = pucProRoutingDocumentListPopupEntity.LANGUAGE_TYPE;
            WINDOW_NAME = pucProRoutingDocumentListPopupEntity.WINDOW_NAME;

            CONFIGURATION_MST_CODE = pucProRoutingDocumentListPopupEntity.CONFIGURATION_MST_CODE;
            CONFIGURATION_SEQ = pucProRoutingDocumentListPopupEntity.CONFIGURATION_SEQ;
            CONFIGURATION_CODE = pucProRoutingDocumentListPopupEntity.CONFIGURATION_CODE;

            DOCUMENT_FILE_NAME = pucProRoutingDocumentListPopupEntity.DOCUMENT_FILE_NAME;
            DOCUMENT_TYPE = pucProRoutingDocumentListPopupEntity.DOCUMENT_TYPE;
            DOCUMENT_NAME = pucProRoutingDocumentListPopupEntity.DOCUMENT_NAME;
            DOCUMENT_VER = pucProRoutingDocumentListPopupEntity.DOCUMENT_VER;



            USE_YN = pucProRoutingDocumentListPopupEntity.USE_YN;

            ERR_NO = pucProRoutingDocumentListPopupEntity.ERR_NO;
            ERR_MSG = pucProRoutingDocumentListPopupEntity.ERR_MSG;
            RTN_KEY = pucProRoutingDocumentListPopupEntity.RTN_KEY;
            RTN_SEQ = pucProRoutingDocumentListPopupEntity.RTN_SEQ;
            RTN_AQ = pucProRoutingDocumentListPopupEntity.RTN_AQ;
            RTN_SQ = pucProRoutingDocumentListPopupEntity.RTN_SQ;
            RTN_OTHERS = pucProRoutingDocumentListPopupEntity.RTN_OTHERS;
            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }
    public class ucToolDocumentListPopupEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String WINDOW_NAME { get; set; }
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE

        public String PROCESS_CODE { get; set; }
        public String PROCESS_NAME { get; set; }

        public String TOOL_MST_CODE { get; set; }
        public String TOOL_MST_NAME { get; set; }
        public String TOOL_CODE { get; set; }
        public String TOOL_NAME { get; set; }
        public String TOOL_TYPE { get; set; }
        public String REMARK { get; set; }
        public String DOCUMENT_TYPE { get; set; }
        public String DOCUMENT_NAME { get; set; }
        public String DOCUMENT_VER { get; set; }
        public String DOCUMENT_FILE_NAME { get; set; }
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

        #region 생성자 - ucProcessDocumentListPopupEntity()

        public ucToolDocumentListPopupEntity()
        {
        }

        #endregion

        #region 생성자 - ucToolDocumentListPopupEntity(ucToolDocumentListPopupEntity pucToolDocumentListPopupEntityEntity)

        public ucToolDocumentListPopupEntity(ucToolDocumentListPopupEntity pucToolDocumentListPopupEntityEntity)
        {
            CORP_CODE = pucToolDocumentListPopupEntityEntity.CORP_CODE;
            CRUD = pucToolDocumentListPopupEntityEntity.CRUD;
            USER_CODE = pucToolDocumentListPopupEntityEntity.USER_CODE;
            LANGUAGE_TYPE = pucToolDocumentListPopupEntityEntity.LANGUAGE_TYPE;
            WINDOW_NAME = pucToolDocumentListPopupEntityEntity.WINDOW_NAME;

            PROCESS_CODE = pucToolDocumentListPopupEntityEntity.PROCESS_CODE;
            PROCESS_NAME = pucToolDocumentListPopupEntityEntity.PROCESS_NAME;

            TOOL_MST_CODE = pucToolDocumentListPopupEntityEntity.TOOL_MST_CODE;
            TOOL_MST_NAME = pucToolDocumentListPopupEntityEntity.TOOL_MST_NAME;
            TOOL_CODE = pucToolDocumentListPopupEntityEntity.TOOL_CODE;
            TOOL_NAME = pucToolDocumentListPopupEntityEntity.TOOL_NAME;
            TOOL_TYPE = pucToolDocumentListPopupEntityEntity.TOOL_TYPE;
            REMARK = pucToolDocumentListPopupEntityEntity.REMARK;
            USE_YN = pucToolDocumentListPopupEntityEntity.USE_YN;

            DOCUMENT_FILE_NAME = pucToolDocumentListPopupEntityEntity.DOCUMENT_FILE_NAME;
            DOCUMENT_TYPE = pucToolDocumentListPopupEntityEntity.DOCUMENT_TYPE;
            DOCUMENT_NAME = pucToolDocumentListPopupEntityEntity.DOCUMENT_NAME;
            DOCUMENT_VER = pucToolDocumentListPopupEntityEntity.DOCUMENT_VER;



            USE_YN = pucToolDocumentListPopupEntityEntity.USE_YN;

            ERR_NO = pucToolDocumentListPopupEntityEntity.ERR_NO;
            ERR_MSG = pucToolDocumentListPopupEntityEntity.ERR_MSG;
            RTN_KEY = pucToolDocumentListPopupEntityEntity.RTN_KEY;
            RTN_SEQ = pucToolDocumentListPopupEntityEntity.RTN_SEQ;
            RTN_AQ = pucToolDocumentListPopupEntityEntity.RTN_AQ;
            RTN_SQ = pucToolDocumentListPopupEntityEntity.RTN_SQ;
            RTN_OTHERS = pucToolDocumentListPopupEntityEntity.RTN_OTHERS;
            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class ucVendDocumentListPopupEntity
    {
        #region Property

        //고정 엔티티
        public String CORP_CODE { get; set; } // 회사코드
        public String USER_CODE { get; set; } // 사용자 정보
        public String CRUD { get; set; } // CRUD
        public String WINDOW_NAME { get; set; }
        public String LANGUAGE_TYPE { get; set; } // LANGUAGE_TYPE

        public String PROCESS_CODE { get; set; }
        public String PROCESS_NAME { get; set; }

        public String VEND_CODE { get; set; }

        public String DOCUMENT_TYPE { get; set; }
        public String DOCUMENT_NAME { get; set; }
        public String DOCUMENT_VER { get; set; }
        public String DOCUMENT_FILE_NAME { get; set; }
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

        #region 생성자 - ucVendDocumentListPopupEntity()

        public ucVendDocumentListPopupEntity()
        {
        }

        #endregion

        #region 생성자 - ucVendDocumentListPopupEntity(ucVendDocumentListPopupEntity pucVendDocumentListPopupEntity)

        public ucVendDocumentListPopupEntity(ucVendDocumentListPopupEntity pucVendDocumentListPopupEntity)
        {
            CORP_CODE = pucVendDocumentListPopupEntity.CORP_CODE;
            CRUD = pucVendDocumentListPopupEntity.CRUD;
            USER_CODE = pucVendDocumentListPopupEntity.USER_CODE;
            LANGUAGE_TYPE = pucVendDocumentListPopupEntity.LANGUAGE_TYPE;
            WINDOW_NAME = pucVendDocumentListPopupEntity.WINDOW_NAME;

            PROCESS_CODE = pucVendDocumentListPopupEntity.PROCESS_CODE;
            PROCESS_NAME = pucVendDocumentListPopupEntity.PROCESS_NAME;

            VEND_CODE = pucVendDocumentListPopupEntity.VEND_CODE;

            DOCUMENT_FILE_NAME = pucVendDocumentListPopupEntity.DOCUMENT_FILE_NAME;
            DOCUMENT_TYPE = pucVendDocumentListPopupEntity.DOCUMENT_TYPE;
            DOCUMENT_NAME = pucVendDocumentListPopupEntity.DOCUMENT_NAME;
            DOCUMENT_VER = pucVendDocumentListPopupEntity.DOCUMENT_VER;



            USE_YN = pucVendDocumentListPopupEntity.USE_YN;

            ERR_NO = pucVendDocumentListPopupEntity.ERR_NO;
            ERR_MSG = pucVendDocumentListPopupEntity.ERR_MSG;
            RTN_KEY = pucVendDocumentListPopupEntity.RTN_KEY;
            RTN_SEQ = pucVendDocumentListPopupEntity.RTN_SEQ;
            RTN_AQ = pucVendDocumentListPopupEntity.RTN_AQ;
            RTN_SQ = pucVendDocumentListPopupEntity.RTN_SQ;
            RTN_OTHERS = pucVendDocumentListPopupEntity.RTN_OTHERS;
            //메뉴별 추가 엔티티 입력
        }

        #endregion
    }

    public class TabletBasedSensorInfoRegisterEntity
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

        public String COMMENT1 { get; set; }
        public String COMMENT2 { get; set; }
        public String COMMENT3 { get; set; }

        public String USER_YN { get; set; }
        public String REMARK { get; set; }



        public int dtListCnt { get; set; }

        public String MISSING_CHECK { get; set; }


        #endregion

        #region 생성자 - TabletBasedSensorInfoRegisterEntity()

        public TabletBasedSensorInfoRegisterEntity()
        {
        }

        #endregion

        #region 생성자 - TabletBasedSensorInfoRegisterEntity(pTabletBasedSensorInfoRegisterEntity)

        public TabletBasedSensorInfoRegisterEntity(TabletBasedSensorInfoRegisterEntity pTabletBasedSensorInfoRegisterEntity)
        {
            CORP_CODE = pTabletBasedSensorInfoRegisterEntity.CORP_CODE;
            CRUD = pTabletBasedSensorInfoRegisterEntity.CRUD;
            USER_CODE = pTabletBasedSensorInfoRegisterEntity.USER_CODE;

            pTabletBasedSensorInfoRegisterEntity.WINDOW_NAME = WINDOW_NAME;

            DATE_TIME = pTabletBasedSensorInfoRegisterEntity.DATE_TIME;

            RESOURCE_CODE = pTabletBasedSensorInfoRegisterEntity.RESOURCE_CODE;
            RESOURCE_NAME = pTabletBasedSensorInfoRegisterEntity.RESOURCE_NAME;
            VALUE = pTabletBasedSensorInfoRegisterEntity.VALUE;

            COMMENT1 = pTabletBasedSensorInfoRegisterEntity.COMMENT1;
            COMMENT2 = pTabletBasedSensorInfoRegisterEntity.COMMENT2;
            COMMENT3 = pTabletBasedSensorInfoRegisterEntity.COMMENT3;

            REMARK = pTabletBasedSensorInfoRegisterEntity.REMARK;
            USER_YN = pTabletBasedSensorInfoRegisterEntity.USER_YN;
            dtListCnt = pTabletBasedSensorInfoRegisterEntity.dtListCnt;

            MISSING_CHECK = pTabletBasedSensorInfoRegisterEntity.MISSING_CHECK;

            ERR_NO = pTabletBasedSensorInfoRegisterEntity.ERR_NO;
            ERR_MSG = pTabletBasedSensorInfoRegisterEntity.ERR_MSG;
            RTN_KEY = pTabletBasedSensorInfoRegisterEntity.RTN_KEY;
            RTN_SEQ = pTabletBasedSensorInfoRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pTabletBasedSensorInfoRegisterEntity.RTN_OTHERS;

            LANGUAGE_TYPE = pTabletBasedSensorInfoRegisterEntity.LANGUAGE_TYPE;
            //메뉴별 추가 엔티티 입력
        }

        #endregion

    }

    public class frmCategorySensorSettingsEntity
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
        public String RESOURCE_CODE { get; set; }
        public String CATEGORY_VALUE { get; set; }
        public String CATEGORY_NAME { get; set; }

        #endregion

        #region 생성자 - frmCategorySensorSettingsEntity()

        public frmCategorySensorSettingsEntity()
        {
        }

        #endregion

        #region 생성자 - frmCategorySensorSettingsEntity(pfrmCategorySensorSettingsEntity)

        public frmCategorySensorSettingsEntity(frmCategorySensorSettingsEntity pfrmCategorySensorSettingsEntity)
        {
            CRUD = pfrmCategorySensorSettingsEntity.CRUD;
            CORP_CODE = pfrmCategorySensorSettingsEntity.CORP_CODE;
            USER_CODE = pfrmCategorySensorSettingsEntity.USER_CODE;
            LANGUAGE_TYPE = pfrmCategorySensorSettingsEntity.LANGUAGE_TYPE;
            ERR_NO = pfrmCategorySensorSettingsEntity.ERR_NO;
            ERR_MSG = pfrmCategorySensorSettingsEntity.ERR_MSG;
            RTN_KEY = pfrmCategorySensorSettingsEntity.RTN_KEY;
            RTN_SEQ = pfrmCategorySensorSettingsEntity.RTN_SEQ;
            RTN_OTHERS = pfrmCategorySensorSettingsEntity.RTN_OTHERS;

            //메뉴별 추가 엔티티 입력

            RESOURCE_CODE = pfrmCategorySensorSettingsEntity.RESOURCE_CODE;
            CATEGORY_VALUE = pfrmCategorySensorSettingsEntity.CATEGORY_VALUE;
            CATEGORY_NAME = pfrmCategorySensorSettingsEntity.CATEGORY_NAME;

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

    public class InspectProcessMappingRegisterEntity
    {
        #region Property
        //사용자 설정 엔티티
        public String CORP_CODE { get; set; }       // 회사코드
        public String USER_CODE { get; set; }       // 사용자 정보
        public String CRUD { get; set; }            // CRUD
        public String LANGUAGE_TYPE { get; set; }    // 언어타입

        public String PART_TYPE { get; set; }       // 품목타입
        public String PART_CODE { get; set; }       // 품목코드
        public String PART_NAME { get; set; }       // 품목명칭
        public String VEND_PART_CODE { get; set; }       // 업체품번
        public String INSPECT_CODE { get; set; }    // 시험코드
        public String REMARK { get; set; }          // 비고
        public String USE_YN { get; set; }          // 사용유무
        public String REG_DATE { get; set; }        // 등록일자
        public String REG_USER { get; set; }        // 등록자
        public String UP_DATE { get; set; }         // 수정일자
        public String UP_USER { get; set; }         // 수정자
        public String PROCESS_TYPE { get; set; }
        public String PROCESS_NAME { get; set; }
        public String PROCESS_CODE { get; set; }
        public String PROCESS_MST_CODE { get; set; }
        public String PROCESS_MST_NAME { get; set; }

        public String EQUIPMENT_CODE { get; set; }

        // 리턴값
        public String ERR_NO { get; set; }
        public String ERR_MSG { get; set; }
        public String RTN_KEY { get; set; }
        public String RTN_AQ { get; set; }
        public String RTN_SEQ { get; set; }
        public String RTN_OTHERS { get; set; }

        #endregion

        #region 생성자 - InspectProcessMappingRegisterEntity()
        public InspectProcessMappingRegisterEntity()
        {

        }
        #endregion

        #region 생성자 - InspectProcessMappingRegisterEntity(pInspectProcessMappingRegisterEntity)

        public InspectProcessMappingRegisterEntity(InspectProcessMappingRegisterEntity pInspectProcessMappingRegisterEntity)
        {
            // 사용자 설정 엔티티
            CORP_CODE = pInspectProcessMappingRegisterEntity.CORP_CODE;
            USER_CODE = pInspectProcessMappingRegisterEntity.USER_CODE;
            CRUD = pInspectProcessMappingRegisterEntity.CRUD;
            LANGUAGE_TYPE = pInspectProcessMappingRegisterEntity.LANGUAGE_TYPE;

            PART_TYPE = pInspectProcessMappingRegisterEntity.PART_TYPE;
            PART_CODE = pInspectProcessMappingRegisterEntity.PART_CODE;
            PART_NAME = pInspectProcessMappingRegisterEntity.PART_NAME;
            INSPECT_CODE = pInspectProcessMappingRegisterEntity.INSPECT_CODE;
            REMARK = pInspectProcessMappingRegisterEntity.REMARK;
            USE_YN = pInspectProcessMappingRegisterEntity.USE_YN;
            REG_DATE = pInspectProcessMappingRegisterEntity.REG_DATE;
            REG_USER = pInspectProcessMappingRegisterEntity.REG_USER;
            UP_DATE = pInspectProcessMappingRegisterEntity.UP_DATE;
            UP_USER = pInspectProcessMappingRegisterEntity.UP_USER;
            VEND_PART_CODE = pInspectProcessMappingRegisterEntity.VEND_PART_CODE;
            PROCESS_TYPE = pInspectProcessMappingRegisterEntity.PROCESS_TYPE;
            PROCESS_CODE = pInspectProcessMappingRegisterEntity.PROCESS_CODE;
            PROCESS_NAME = pInspectProcessMappingRegisterEntity.PROCESS_NAME;
            PROCESS_MST_CODE = pInspectProcessMappingRegisterEntity.PROCESS_MST_CODE;
            PROCESS_MST_NAME = pInspectProcessMappingRegisterEntity.PROCESS_MST_NAME;

            EQUIPMENT_CODE = pInspectProcessMappingRegisterEntity.EQUIPMENT_CODE;

            ERR_NO = pInspectProcessMappingRegisterEntity.ERR_NO;
            ERR_MSG = pInspectProcessMappingRegisterEntity.ERR_MSG;
            RTN_KEY = pInspectProcessMappingRegisterEntity.RTN_KEY;
            RTN_AQ = pInspectProcessMappingRegisterEntity.RTN_AQ;
            RTN_SEQ = pInspectProcessMappingRegisterEntity.RTN_SEQ;
            RTN_OTHERS = pInspectProcessMappingRegisterEntity.RTN_OTHERS;
        }

        #endregion
    }

    public class frmResourceMst_PopupEntity
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
        public String INSPECT_CODE { get; set; }
        public String INSPECT_NAME { get; set; }

        public String PROCESS_MST_CODE { get; set; }
        public String EQUIPMENT_CODE { get; set; }

        //고정 엔티티

        //메뉴별 추가 엔티티 입력
        public String RESOURCE_CODE { get; set; }
        public String CATEGORY_VALUE { get; set; }
        public String CATEGORY_NAME { get; set; }

        #endregion

        #region 생성자 - frmResourceMst_PopupEntity()

        public frmResourceMst_PopupEntity()
        {
        }

        #endregion

        #region 생성자 - frmResourceMst_PopupEntity(pfrmResourceMst_PopupEntity)

        public frmResourceMst_PopupEntity(frmResourceMst_PopupEntity pfrmResourceMst_PopupEntity)
        {
            CRUD = pfrmResourceMst_PopupEntity.CRUD;
            CORP_CODE = pfrmResourceMst_PopupEntity.CORP_CODE;
            USER_CODE = pfrmResourceMst_PopupEntity.USER_CODE;
            LANGUAGE_TYPE = pfrmResourceMst_PopupEntity.LANGUAGE_TYPE;
            ERR_NO = pfrmResourceMst_PopupEntity.ERR_NO;
            ERR_MSG = pfrmResourceMst_PopupEntity.ERR_MSG;
            RTN_KEY = pfrmResourceMst_PopupEntity.RTN_KEY;
            RTN_SEQ = pfrmResourceMst_PopupEntity.RTN_SEQ;
            RTN_OTHERS = pfrmResourceMst_PopupEntity.RTN_OTHERS;
            INSPECT_CODE = pfrmResourceMst_PopupEntity.INSPECT_CODE;
            INSPECT_NAME = pfrmResourceMst_PopupEntity.INSPECT_NAME;

            PROCESS_MST_CODE = pfrmResourceMst_PopupEntity.PROCESS_MST_CODE;
            EQUIPMENT_CODE = pfrmResourceMst_PopupEntity.EQUIPMENT_CODE;

            //메뉴별 추가 엔티티 입력

            RESOURCE_CODE = pfrmResourceMst_PopupEntity.RESOURCE_CODE;
            CATEGORY_VALUE = pfrmResourceMst_PopupEntity.CATEGORY_VALUE;
            CATEGORY_NAME = pfrmResourceMst_PopupEntity.CATEGORY_NAME;

        }

        #endregion
    }
}

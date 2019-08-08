using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CoFAS_MES.POP.Data;
using CoFAS_MES.POP.Entity;

using CoFAS_MES.CORE.Entity;
using CoFAS_MES.CORE.Function;
using System.Data;
using DevExpress.Spreadsheet;

namespace CoFAS_MES.POP.Business
{


    
    public class POPSelect_INSPECT_COSMETICSBusiness
    {
        /// <summary>
        /// 작업지시 정보 조회
        /// </summary>
        public DataTable POPSelect_INSPECT_COSMETICS_Info(POPSelect_INSPECT_COSMETICSEntity pPOPSelect_INSPECT_COSMETICSEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new POPSelect_INSPECT_COSMETICSProvider(pDBManager).POPSelect_INSPECT_COSMETICS_Info_Mst(pPOPSelect_INSPECT_COSMETICSEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }
    }

    public class POPProductionOrderBusiness
    {
        /// <summary>
        /// 작업지시 정보 조회
        /// </summary>
        public DataTable POPProductionOrder_Info(POPProductionOrderEntity pPOPProductionOrderEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new POPProductionOrderProvider(pDBManager).POPProductionOrder_Info_Mst(pPOPProductionOrderEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }
        public DataSet POPProductionOrder_Info2(POPProductionOrderEntity pPOPProductionOrderEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    //DataTable pDataTable = new POPProductionOrderProvider(pDBManager).POPProductionOrder_Info_Mst(pPOPProductionOrderEntity);
                    DataSet pDataSet = new POPProductionOrderProvider(pDBManager).POPProductionOrder_Info_Mst_3(pPOPProductionOrderEntity);
                    //return pDataTable;
                    return pDataSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }
        /// <summary>
        /// 작업지시 다시조회
        /// </summary>
        public DataTable POPProductionOrder_Info_2(POPProductionOrderEntity pPOPProductionOrderEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new POPProductionOrderProvider(pDBManager).POPProductionOrder_Info_Mst_2(pPOPProductionOrderEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }

    }
    
  public class frmPOPPartStockCheckBusiness
    {
        /// <summary>
        /// 작업지시 정보 조회
        /// </summary>
        public DataTable frmPOPPartStockCheck_Info(frmPOPPartStockCheckEntity p_frmPOPPartStockCheckEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new frmPOPPartStockCheckProvider(pDBManager).frmPOPPartStockCheck_Info_Mst(p_frmPOPPartStockCheckEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }


    }
    public class POPProductionOrder_T03Business
    {
        /// <summary>
        /// 작업지시 정보 조회
        /// </summary>
        public DataTable POPProductionOrder_Info(POPProductionOrder_T03Entity pPOPProductionOrder_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new POPProductionOrder_T03Provider(pDBManager).POPProductionOrder_Info_Mst(pPOPProductionOrder_T03Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "POPProductionOrder_Info(POPProductionOrder_T03Entity pPOPProductionOrder_T03Entity)", pException);
            }
        }
        /// <summary>
        /// 작업지시 다시조회
        /// </summary>
        public DataTable POPProductionOrder_Info_2(POPProductionOrder_T03Entity pPOPProductionOrder_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new POPProductionOrder_T03Provider(pDBManager).POPProductionOrder_Info_Mst_2(pPOPProductionOrder_T03Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "POPProductionOrder_Info_2(POPProductionOrder_T03Entity pPOPProductionOrder_T03Entity)", pException);
            }
        }

    }

    public class POPProductionOrder_T50Business
    {
        /// <summary>
        /// 작업지시 정보 조회
        /// </summary>
        public DataTable POPProductionOrder_Info(POPProductionOrder_T50Entity pPOPProductionOrder_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new POPProductionOrder_T50Provider(pDBManager).POPProductionOrder_Info_Mst(pPOPProductionOrder_T50Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "POPProductionOrder_Info(POPProductionOrder_T50Entity pPOPProductionOrder_T50Entity)", pException);
            }
        }
        public DataTable USP_production_order_detail_t50_check_R10(string order_id, string seq)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new POPProductionOrder_T50Provider(pDBManager).USP_production_order_detail_t50_check_R10(order_id, seq);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "POPProductionOrder_Info(POPProductionOrder_T50Entity pPOPProductionOrder_T50Entity)", pException);
            }
        }
        /// <summary>
        /// 작업지시 다시조회
        /// </summary>
        public DataTable POPProductionOrder_Info_2(POPProductionOrder_T50Entity pPOPProductionOrder_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new POPProductionOrder_T50Provider(pDBManager).POPProductionOrder_Info_Mst_2(pPOPProductionOrder_T50Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "POPProductionOrder_Info_2(POPProductionOrder_T50Entity pPOPProductionOrder_T50Entity)", pException);
            }
        }
        public DataTable POPProductionOrder_Info_3(string id)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new POPProductionOrder_T50Provider(pDBManager).USP_PRODUCTION_ORDER_T50_R12(id);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "POPProductionOrder_Info_2(POPProductionOrder_T50Entity pPOPProductionOrder_T50Entity)", pException);
            }
        }
        public DataTable POPProductionOrder_Info_4(string id, string seq, string equipment)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new POPProductionOrder_T50Provider(pDBManager).USP_production_order_detail_t50_U10(id, seq, equipment);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "POPProductionOrder_Info_2(POPProductionOrder_T50Entity pPOPProductionOrder_T50Entity)", pException);
            }
        }
        public DataTable POPWorker_Info()
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new POPProductionOrder_T50Provider(pDBManager).USP_user_mst_R10();
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "POPProductionOrder_Info(POPProductionOrder_T50Entity pPOPProductionOrder_T50Entity)", pException);
            }
        }

    }


    public class POPLabelPrintBusiness
    {
        /// <summary>
        /// 작업지시 정보 조회
        /// </summary>
        public DataTable POPProduction_Info(POPLabelPrintEntity pPOPLabelPrintEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new POPLabelPrintProvider(pDBManager).POPProduction_Info_Mst(pPOPLabelPrintEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "POPProductionOrder_Info(POPProductionOrder_T03Entity pPOPProductionOrder_T03Entity)", pException);
            }
        }


    }
    public class frmPOPMain_RAWMATERIAL_COSMETICSBusiness
    {
        /// <summary>
        /// 작업지시 정보 조회
        /// </summary>
        public DataTable frmPOPMain_RAWMATERIAL_COSMETICS_Info(frmPOPMain_RAWMATERIAL_COSMETICSEntity pfrmPOPMain_RAWMATERIAL_COSMETICSEntity)//(string pCRUD, string pFromDate, string pToDate, string pPART_NAME, string pVEND_NAME)  //CRUD , 발주일자 , 자재명, 거래처명
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new frmPOPMain_RAWMATERIAL_COSMETICSProvider(pDBManager).frmPOPMain_RAWMATERIAL_COSMETICS_Info_Mst(pfrmPOPMain_RAWMATERIAL_COSMETICSEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }

        public bool frmPOPMain_RAWMATERIAL_COSMETICS_Info_Save(frmPOPMain_RAWMATERIAL_COSMETICSEntity pfrmPOPMain_RAWMATERIAL_COSMETICSEntity,DataTable dt)//(string pCRUD, string pFromDate, string pToDate, string pPART_NAME, string pVEND_NAME)  //CRUD , 발주일자 , 자재명, 거래처명
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new frmPOPMain_RAWMATERIAL_COSMETICSProvider(pDBManager).frmPOPMain_RAWMATERIAL_COSMETICS_Info_Save(pfrmPOPMain_RAWMATERIAL_COSMETICSEntity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }

        public bool frmPOPMain_RAWMATERIAL_COSMETICS_INSPECT_Save(frmPOPMain_RAWMATERIAL_COSMETICSEntity pfrmPOPMain_RAWMATERIAL_COSMETICSEntity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new frmPOPMain_RAWMATERIAL_COSMETICSProvider(pDBManager).frmPOPMain_RAWMATERIAL_COSMETICS_INSPECT_Save(pfrmPOPMain_RAWMATERIAL_COSMETICSEntity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "User_Info_Save(WorkResultRegister_T01Entity pWorkResultRegister_T01Entity)", pException);
            }
        }
        /// <summary>
        /// 작업지시 다시조회
        /// </summary>
        /// 
        /*
        public DataTable frmPOPMain_RAWMATERIAL_COSMETICS_Info_2(frmPOPMain_RAWMATERIAL_COSMETICSEntity pfrmPOPMain_RAWMATERIAL_COSMETICSEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new frmPOPMain_RAWMATERIAL_COSMETICSProvider(pDBManager).frmPOPMain_RAWMATERIAL_COSMETICS_Info_Mst_2(pfrmPOPMain_RAWMATERIAL_COSMETICSEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }
        */

    }

    public class frmPOPMain_MATERIAL_COSMETICSBusiness
    {
        /// <summary>
        /// 작업지시 정보 조회
        /// </summary>
        public DataTable frmPOPMain_MATERIAL_COSMETICS_Info(frmPOPMain_MATERIAL_COSMETICSEntity pfrmPOPMain_MATERIAL_COSMETICSEntity)//(string pCRUD, string pFromDate, string pToDate, string pPART_NAME, string pVEND_NAME)  //CRUD , 발주일자 , 자재명, 거래처명
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new frmPOPMain_MATERIAL_COSMETICSProvider(pDBManager).frmPOPMain_MATERIAL_COSMETICS_Info_Mst(pfrmPOPMain_MATERIAL_COSMETICSEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }
        public DataTable frmPOPMain_MATERIAL_COSMETICS_Info2(frmPOPMain_MATERIAL_COSMETICSEntity pfrmPOPMain_MATERIAL_COSMETICSEntity)//(string pCRUD, string pFromDate, string pToDate, string pPART_NAME, string pVEND_NAME)  //CRUD , 발주일자 , 자재명, 거래처명
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new frmPOPMain_MATERIAL_COSMETICSProvider(pDBManager).frmPOPMain_MATERIAL_COSMETICS_Info_Mst2(pfrmPOPMain_MATERIAL_COSMETICSEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }

        public DataTable frmPOPMain_MATERIAL_COSMETICS_Info3(frmPOPMain_MATERIAL_COSMETICSEntity pfrmPOPMain_MATERIAL_COSMETICSEntity)//(string pCRUD, string pFromDate, string pToDate, string pPART_NAME, string pVEND_NAME)  //CRUD , 발주일자 , 자재명, 거래처명
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new frmPOPMain_MATERIAL_COSMETICSProvider(pDBManager).frmPOPMain_MATERIAL_COSMETICS_Info_Mst3(pfrmPOPMain_MATERIAL_COSMETICSEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }
        //
        public DataSet frmPOPMain_MATERIAL_COSMETICS_Sub_Return(string pCRUD, string pPART_CODE)//(string pCRUD, string pFromDate, string pToDate, string pPART_NAME, string pVEND_NAME)  //CRUD , 발주일자 , 자재명, 거래처명
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new frmPOPMain_MATERIAL_COSMETICSProvider(pDBManager).frmPOPMain_MATERIAL_COSMETICS_Sub_Return(pCRUD, pPART_CODE);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }
        public bool frmPOPMain_MATERIAL_COSMETICS_Info_Save(frmPOPMain_MATERIAL_COSMETICSEntity pfrmPOPMain_MATERIAL_COSMETICSEntity, DataTable dt)//(string pCRUD, string pFromDate, string pToDate, string pPART_NAME, string pVEND_NAME)  //CRUD , 발주일자 , 자재명, 거래처명
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new frmPOPMain_MATERIAL_COSMETICSProvider(pDBManager).frmPOPMain_MATERIAL_COSMETICS_Info_Save(pfrmPOPMain_MATERIAL_COSMETICSEntity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }
        //생산출고
        public bool frmPOPMain_MATERIAL_COSMETICS_Info_Save2(frmPOPMain_MATERIAL_COSMETICSEntity pfrmPOPMain_MATERIAL_COSMETICSEntity, DataTable dt)//(string pCRUD, string pFromDate, string pToDate, string pPART_NAME, string pVEND_NAME)  //CRUD , 발주일자 , 자재명, 거래처명
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new frmPOPMain_MATERIAL_COSMETICSProvider(pDBManager).frmPOPMain_MATERIAL_COSMETICS_Info_Save2(pfrmPOPMain_MATERIAL_COSMETICSEntity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }
        public bool frmPOPMain_MATERIAL_COSMETICS_INSPECT_Save3(frmPOPMain_MATERIAL_COSMETICSEntity pfrmPOPMain_MATERIAL_COSMETICSEntity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new frmPOPMain_MATERIAL_COSMETICSProvider(pDBManager).frmPOPMain_MATERIAL_COSMETICS_INSPECT_Save3(pfrmPOPMain_MATERIAL_COSMETICSEntity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "pfrmPOPMain_PRODUCT_COSMETICS_Save(POPSelect_INSPECT_COSMETICSEntity pPOPSelect_INSPECT_COSMETICSEntity)", pException);
            }
        }
        public bool frmPOPMain_MATERIAL_COSMETICS_INSPECT_Save(frmPOPMain_MATERIAL_COSMETICSEntity pfrmPOPMain_MATERIAL_COSMETICSEntity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new frmPOPMain_MATERIAL_COSMETICSProvider(pDBManager).frmPOPMain_MATERIAL_COSMETICS_INSPECT_Save(pfrmPOPMain_MATERIAL_COSMETICSEntity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "User_Info_Save(WorkResultRegister_T01Entity pWorkResultRegister_T01Entity)", pException);
            }
        }
        /// <summary>
        /// 작업지시 다시조회
        /// </summary>
        /// 
        /*
        public DataTable frmPOPMain_MATERIAL_COSMETICS_Info_2(frmPOPMain_MATERIAL_COSMETICSEntity pfrmPOPMain_MATERIAL_COSMETICSEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new frmPOPMain_MATERIAL_COSMETICSProvider(pDBManager).frmPOPMain_MATERIAL_COSMETICS_Info_Mst_2(pfrmPOPMain_MATERIAL_COSMETICSEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }
        */

    }

    public class frmPOPMain_OUT_COSMETICSBusiness
    {
        /// <summary>
        /// 작업지시 정보 조회
        /// </summary>
        public DataTable frmPOPMain_OUT_COSMETICS_Info(frmPOPMain_OUT_COSMETICSEntity pfrmPOPMain_OUT_COSMETICSEntity)//(string pCRUD, string pFromDate, string pToDate, string pPART_NAME, string pVEND_NAME)  //CRUD , 발주일자 , 자재명, 거래처명
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new frmPOPMain_OUT_COSMETICSProvider(pDBManager).frmPOPMain_OUT_COSMETICS_Info_Mst(pfrmPOPMain_OUT_COSMETICSEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }


        public bool frmPOPMain_OUT_COSMETICS_Info_Save(frmPOPMain_OUT_COSMETICSEntity pfrmPOPMain_OUT_COSMETICSEntity, DataTable dt)//(string pCRUD, string pFromDate, string pToDate, string pPART_NAME, string pVEND_NAME)  //CRUD , 발주일자 , 자재명, 거래처명
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new frmPOPMain_OUT_COSMETICSProvider(pDBManager).frmPOPMain_OUT_COSMETICS_Info_Save(pfrmPOPMain_OUT_COSMETICSEntity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }

        public bool frmPOPMain_OUT_COSMETICS_INSPECT_Save(frmPOPMain_OUT_COSMETICSEntity pfrmPOPMain_OUT_COSMETICSEntity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new frmPOPMain_OUT_COSMETICSProvider(pDBManager).frmPOPMain_OUT_COSMETICS_INSPECT_Save(pfrmPOPMain_OUT_COSMETICSEntity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "User_Info_Save(WorkResultRegister_T01Entity pWorkResultRegister_T01Entity)", pException);
            }
        }


    }
    public class POPProductionOrderCommonBusiness
    {
        /// <summary>
        /// 작업지시 정보 조회
        /// </summary>
        public DataTable POPProductionOrderCommon_Info(POPProductionOrderCommonEntity pPOPProductionOrderCommonEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new POPProductionOrderCommonProvider(pDBManager).POPProductionOrderCommon_Info_Mst(pPOPProductionOrderCommonEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }

        /// <summary>
        /// 래시피 정보 저장 유무 확인
        /// </summary>
        public DataTable POPProductionOrderCommon_Recipe_Check(string ORDER_ID)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new POPProductionOrderCommonProvider(pDBManager).POPProductionOrderCommon_Recipe_Check(ORDER_ID);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }

        /// <summary>
        /// BOM 배합 정보 조회
        /// </summary>
        public DataTable POPProductionOrderMix_Info(POPProductionOrderCommonEntity pPOPProductionOrderCommonEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new POPProductionOrderCommonProvider(pDBManager).POPProductionOrderMix_Info_Mst(pPOPProductionOrderCommonEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }

        /// <summary>
        /// 바코드 정보 저장
        /// </summary>
        public bool POPProductionOrderCommon_Info_Save(POPProductionOrderCommonEntity pPOPProductionOrderCommonEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new POPProductionOrderCommonProvider(pDBManager).POPProductionOrderCommon_Info_Save(pPOPProductionOrderCommonEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOutRegister_Info_Save(MaterialOutRegisterEntity pMaterialOutRegisterEntity, DataTable dt)", pException);
            }
        }

        public bool POPProductionOrderCommon_Recipe_Save(POPProductionOrderCommonEntity pPOPProductionOrderCommonEntity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new POPProductionOrderCommonProvider(pDBManager).POPProductionOrderCommon_Recipe_Save(pPOPProductionOrderCommonEntity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOutRegister_Info_Save(MaterialOutRegisterEntity pMaterialOutRegisterEntity, DataTable dt)", pException);
            }
        }
    }

    public class POPProductionOrderCommonBusiness2
    {
        /// <summary>
        /// 작업지시 정보 조회
        /// </summary>
        public DataTable POPProductionOrderCommon_Info2(POPProductionOrderCommonEntity pPOPProductionOrderCommonEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new POPProductionOrderCommonProvider2(pDBManager).POPProductionOrderCommon_Info_Mst2(pPOPProductionOrderCommonEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }

        /// <summary>
        /// 바코드 정보 저장
        /// </summary>
        public bool POPProductionOrderCommon_Info_Save(POPProductionOrderCommonEntity pPOPProductionOrderCommonEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new POPProductionOrderCommonProvider(pDBManager).POPProductionOrderCommon_Info_Save(pPOPProductionOrderCommonEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOutRegister_Info_Save(MaterialOutRegisterEntity pMaterialOutRegisterEntity, DataTable dt)", pException);
            }
        }
    }

    public class POPProductMonitoringBusiness
    {
        /// <summary>
        /// 작업지시 정보 조회
        /// </summary>
        public DataTable POPProductMonitoring_Info(POPProductMonitoringEntity pPOPProductMonitoringEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new POPProductMonitoringProvider(pDBManager).POPProductMonitoring_Info_Mst2(pPOPProductMonitoringEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }

 
    }


    public class POPProductBOMCommonBusiness
    {
        /// <summary>
        /// BOM 정보 조회
        /// </summary>
        public DataTable POPProductBOM_Info(POPProductBOMEntity pPOPProductBOMEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new POPProductionOrderCommonProvider(pDBManager).POPProductBOM_Info_Mst(pPOPProductBOMEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }

        /// <summary>
        /// BOM 최신 이미지명 가져오기
        /// </summary>
        public DataTable POPProductBOM_Image_Info(POPProductBOMEntity pPOPProductBOMEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new POPProductionOrderCommonProvider(pDBManager).POPProductBOM_image_info(pPOPProductBOMEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }

        /// <summary>
        /// 바코드 정보 저장
        /// </summary>
        public bool POPProductionOrderCommon_Info_Save(POPProductionOrderCommonEntity pPOPProductionOrderCommonEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new POPProductionOrderCommonProvider(pDBManager).POPProductionOrderCommon_Info_Save(pPOPProductionOrderCommonEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOutRegister_Info_Save(MaterialOutRegisterEntity pMaterialOutRegisterEntity, DataTable dt)", pException);
            }
        }
    }


    public class DQGatheringBusiness
    {

        #region 정보 저장 - DQ_Data_Save(DQGatheringEntity pDQGatheringEntity)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool DQ_Data_Save(DQGatheringEntity pDQGatheringEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new DQGatheringProvider(pDBManager).DQ_Data_Save(pDQGatheringEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "DQ_Data_Save(DQGatheringEntity pDQGatheringEntity)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public DQGatheringEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                DQGatheringEntity pDQGatheringEntity = new DQGatheringProvider(null).GetEntity(pDataRow);
                return pDQGatheringEntity;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "GetEntity(pDataRow)",
                    pException
                );
            }
        }
        #endregion
    }



    public class DBInterfaceBusiness
    {
        
        public DataTable Interface_Data_Order()
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new DBInterfaceProvider(pDBManager).Interface_Data_Order();
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Interface_Data_Order()", pException);
            }
        }

        public DataTable Interface_Data_Order_Bokang()
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new DBInterfaceProvider(pDBManager).Interface_Data_Order_Bokang();
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Interface_Data_Order()", pException);
            }
        }

        public DataTable Interface_Data_Sensor()
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new DBInterfaceProvider(pDBManager).Interface_Data_Sensor();
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Interface_Data_Sensor()", pException);
            }
        }
        public DataTable Interface_Data_minwon(string strJSNO)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new DBInterfaceProvider(pDBManager).Interface_Data_minwon(strJSNO);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Interface_Data_Order()", pException);
            }
        }

        public DataTable Interface_Data_workorder(string PLAN_NUMB)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new DBInterfaceProvider(pDBManager).Interface_Data_workorder(PLAN_NUMB);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Interface_Data_Order()", pException);
            }
        }

        public DataTable Interface_Data_color(string strJSNO)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new DBInterfaceProvider(pDBManager).Interface_Data_color(strJSNO);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Interface_Data_Order()", pException);
            }
        }

        public DataTable Interface_Data_workplan(string strPlan)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new DBInterfaceProvider(pDBManager).Interface_Data_workplan(strPlan);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Interface_Data_Order()", pException);
            }
        }

        public DataTable Interface_Data_Order_MST(string strJSNO)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new DBInterfaceProvider(pDBManager).Interface_Data_Order_MST(strJSNO);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Interface_Data_Order()", pException);
            }
        }

        public DataTable Interface_Data_Sensor_MST(string strWORK_DATE, string strPROC_DATE, string strPROC_TIME)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new DBInterfaceProvider(pDBManager).Interface_Data_Sensor_MST(strWORK_DATE, strPROC_DATE, strPROC_TIME);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Interface_Data_Order()", pException);
            }
        }

        public DataTable Interface_Data_Sensor_MST_sarim(string strWORK_DATE, string strPROC_DATE, string strPROC_TIME)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new DBInterfaceProvider(pDBManager).Interface_Data_Sensor_MST_sarim(strWORK_DATE, strPROC_DATE, strPROC_TIME);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Interface_Data_Order()", pException);
            }
        }

        #region 정보 저장 - Interface_Data_Order_Save(DBInterfaceEntity qDBInterfaceEntity, DataTable dt)

        /// <summary>
        /// 정보 저장
        /// </summary>
        public bool Interface_Data_Order_Save(DBInterfaceEntity qDBInterfaceEntity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new DBInterfaceProvider(pDBManager).Interface_Data_Order_Save(qDBInterfaceEntity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Interface_Data_Order_Save(DBInterfaceEntity qDBInterfaceEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 정보 저장 - Interface_Data_Sensor_Save(DBInterfaceEntity qDBInterfaceEntity, DataTable dt)

        /// <summary>
        /// 정보 저장
        /// </summary>
        public bool Interface_Data_Sensor_Save(DBInterfaceEntity qDBInterfaceEntity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new DBInterfaceProvider(pDBManager).Interface_Data_Sensor_Save(qDBInterfaceEntity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Interface_Data_Sensor_Save(DBInterfaceEntity qDBInterfaceEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 정보 저장_사림 - Interface_Data_Sensor_Save_sarim(DBInterfaceEntity qDBInterfaceEntity, DataTable dt)

        /// <summary>
        /// 정보 저장
        /// </summary>
        public bool Interface_Data_Sensor_Save_sarim(DBInterfaceEntity qDBInterfaceEntity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new DBInterfaceProvider(pDBManager).Interface_Data_Sensor_Save_sarim(qDBInterfaceEntity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Interface_Data_Sensor_Save(DBInterfaceEntity qDBInterfaceEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 정보 저장_보강 - Interface_Data_Sensor_Save_Bokang_minwon(DBInterfaceEntity qDBInterfaceEntity, DataTable dt)

        /// <summary>
        /// 정보 저장
        /// </summary>
        public bool Interface_Data_Sensor_Save_Bokang_minwon(DBInterfaceEntity qDBInterfaceEntity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new DBInterfaceProvider(pDBManager).Interface_Data_Sensor_Save_Bokang_minwon(qDBInterfaceEntity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Interface_Data_Sensor_Save_Bokang_minwon(DBInterfaceEntity qDBInterfaceEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 정보 저장_보강 - Interface_Data_Sensor_Save_Bokang_workorder(DBInterfaceEntity qDBInterfaceEntity, DataTable dt)

        /// <summary>
        /// 정보 저장
        /// </summary>
        public bool Interface_Data_Sensor_Save_Bokang_workorder(DBInterfaceEntity qDBInterfaceEntity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new DBInterfaceProvider(pDBManager).Interface_Data_Sensor_Save_Bokang_workorder(qDBInterfaceEntity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Interface_Data_Sensor_Save_Bokang_workorder(DBInterfaceEntity qDBInterfaceEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 정보 저장_보강 - Interface_Data_Sensor_Save_Bokang_color(DBInterfaceEntity qDBInterfaceEntity, DataTable dt)

        /// <summary>
        /// 정보 저장
        /// </summary>
        public bool Interface_Data_Sensor_Save_Bokang_color(DBInterfaceEntity qDBInterfaceEntity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new DBInterfaceProvider(pDBManager).Interface_Data_Sensor_Save_Bokang_color(qDBInterfaceEntity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Interface_Data_Sensor_Save_Bokang_color(DBInterfaceEntity qDBInterfaceEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 정보 저장_보강plan - Interface_Data_Sensor_Save_Bokang_workplan(DBInterfaceEntity qDBInterfaceEntity, DataTable dt)

        /// <summary>
        /// 정보 저장
        /// </summary>
        public bool Interface_Data_Sensor_Save_Bokang_workplan(DBInterfaceEntity qDBInterfaceEntity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new DBInterfaceProvider(pDBManager).Interface_Data_Sensor_Save_Bokang_workplan(qDBInterfaceEntity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Interface_Data_Sensor_Save_Bokang_workplan(DBInterfaceEntity qDBInterfaceEntity, DataTable dt)", pException);
            }
        }

        #endregion


        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public DBInterfaceEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                DBInterfaceEntity pDBInterfaceEntity = new DBInterfaceProvider(null).GetEntity(pDataRow);
                return pDBInterfaceEntity;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "GetEntity(pDataRow)",
                    pException
                );
            }
        }
        #endregion
    }


    public class GatheringMainBusiness
    {
        /// <summary>
        /// 게더링 메인 화면 세팅
        /// </summary>
        public DataTable Gathering_Search_Mst(GatheringMainEntity pGatheringMainEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new GatheringMainProvider(pDBManager).Gathering_Search_Mst(pGatheringMainEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }

        public DataTable Gathering_Search_Sub(DataRow Dr)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new GatheringMainProvider(pDBManager).Gathering_Search_Sub(Dr);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }

        public DataTable Alarm_MinMax_Mst(GatheringMainEntity pGatheringMainEntity)  // 알람 조회
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new GatheringMainProvider(pDBManager).Alarm_MinMax_Mst(pGatheringMainEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }


        #region 정보 저장 - DQ_Data_Save(GatheringMainEntity pGatheringMainEntity)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool DQ_Data_Save(GatheringMainEntity pGatheringMainEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new GatheringMainProvider(pDBManager).DQ_Data_Save(pGatheringMainEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "DQ_Data_Save(DQGatheringEntity pDQGatheringEntity)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public GatheringMainEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                GatheringMainEntity pGatheringMainEntity = new GatheringMainProvider(null).GetEntity(pDataRow);
                return pGatheringMainEntity;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "GetEntity(pDataRow)",
                    pException
                );
            }
        }
        #endregion
    }

  
    public class GatheringUcCtlBusiness
    {
        /// <summary>
        /// 작업지시 정보 조회
        /// </summary>
        public DataTable Gathering_Binding_Mst(GatheringUcCtlEntity pGatheringUcCtlEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new GatheringUcCtlProvider(pDBManager).Gathering_Binding_Mst(pGatheringUcCtlEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }

        public DataTable Gathering_Binding_Sub(GatheringUcCtlEntity pGatheringUcCtlEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new GatheringUcCtlProvider(pDBManager).Gathering_Binding_Mst(pGatheringUcCtlEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }

        public DataTable Gathering_Alarm_Mst(GatheringUcCtlEntity pGatheringUcCtlEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new GatheringUcCtlProvider(pDBManager).Gathering_Alarm_Mst(pGatheringUcCtlEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }

        public DataTable Alarm_MinMax_Mst(GatheringUcCtlEntity pGatheringUcCtlEntity)  // 알람 조회
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new GatheringUcCtlProvider(pDBManager).Alarm_MinMax_Mst(pGatheringUcCtlEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }

        #region 정보 저장 - DQ_Data_Save(GatheringMainEntity pGatheringMainEntity)

        /// <summary>
        /// 서버 데이터 수집 저장
        /// </summary>
        public bool DQ_Data_Save(GatheringUcCtlEntity pGatheringUcCtlEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new GatheringUcCtlProvider(pDBManager).DQ_Data_Save(pGatheringUcCtlEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "DQ_Data_Save(DQGatheringEntity pDQGatheringEntity)", pException);
            }
        }

        #endregion

        #region 정보 저장 - DQ_Data_Trash_Save(GatheringMainEntity pGatheringMainEntity)

        /// <summary>
        /// 서버 데이터 수집 저장
        /// </summary>
        public bool DQ_Data_Trash_Save(GatheringUcCtlEntity pGatheringUcCtlEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new GatheringUcCtlProvider(pDBManager).DQ_Data_Trash_Save(pGatheringUcCtlEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "DQ_Data_Save(DQGatheringEntity pDQGatheringEntity)", pException);
            }
        }

        #endregion

        #region 정보 저장 - DQ_Data_Save(GatheringMainEntity pGatheringMainEntity)

        /// <summary>
        /// 서버 데이터 String 수집 저장
        /// </summary>
        public bool DQ_Data_Save_Str(GatheringUcCtlEntity pGatheringUcCtlEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new GatheringUcCtlProvider(pDBManager).DQ_Data_Save_Str(pGatheringUcCtlEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "DQ_Data_Save(DQGatheringEntity pDQGatheringEntity)", pException);
            }
        }

        #endregion

        #region 코아칩스 서버 저장 - CoreChips_Data_Save(GatheringMainEntity pGatheringMainEntity)

        /// <summary>
        /// 서버 데이터 수집 저장
        /// </summary>
        public bool CoreChips_Data_Save(GatheringUcCtlEntity pGatheringUcCtlEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new GatheringUcCtlProvider(pDBManager).CoreChips_Data_Save(pGatheringUcCtlEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "DQ_Data_Save(DQGatheringEntity pDQGatheringEntity)", pException);
            }
        }

        #endregion

        #region TOP 과제 정보 저장 - DQ_TOP_Data_Save(GatheringMainEntity pGatheringMainEntity)

        /// <summary>
        /// 서버 데이터 수집 저장
        /// </summary>
        public bool DQ_TOP_Data_Save(GatheringUcCtlEntity pGatheringUcCtlEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new GatheringUcCtlProvider(pDBManager).DQ_TOP_Data_Save(pGatheringUcCtlEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "DQ_TOP_Data_Save(DQGatheringEntity pDQGatheringEntity)", pException);
            }
        }

        #endregion

        #region TOP 과제전력 정보 저장 - DQ_TOP_Data_Save(GatheringMainEntity pGatheringMainEntity)

        /// <summary>
        /// 서버 데이터 수집 저장
        /// </summary>
        public bool DQ_TOP_elec_Data_Save(GatheringUcCtlEntity pGatheringUcCtlEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new GatheringUcCtlProvider(pDBManager).DQ_TOP_elec_Data_Save(pGatheringUcCtlEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "DQ_TOP_elec_Data_Save(DQGatheringEntity pDQGatheringEntity)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public GatheringMainEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                GatheringMainEntity pGatheringMainEntity = new GatheringMainProvider(null).GetEntity(pDataRow);
                return pGatheringMainEntity;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "GetEntity(pDataRow)",
                    pException
                );
            }
        }
        #endregion
    }

    #region O HPNC_작업일보등록_팝업_포장
    public class frmPOPMain_PRODUCT_COSMETICSBusiness
    {
        public bool frmPOPMain_PRODUCT_COSMETICS_Save(POPSelect_INSPECT_COSMETICSEntity pPOPSelect_INSPECT_COSMETICSEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new frmPOPMain_PRODUCT_COSMETICSProvider(pDBManager).WorkResultInfo_Save(pPOPSelect_INSPECT_COSMETICSEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "pfrmPOPMain_PRODUCT_COSMETICS_Save(POPSelect_INSPECT_COSMETICSEntity pPOPSelect_INSPECT_COSMETICSEntity)", pException);
            }
        }

        //시험검사의뢰
        public bool frmPOPMain_PRODUCT_COSMETICS_Info_Check_Save(POPSelect_INSPECT_COSMETICSEntity pPOPSelect_INSPECT_COSMETICSEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new frmPOPMain_PRODUCT_COSMETICSProvider(pDBManager).WorkResultInfo_Save_02(pPOPSelect_INSPECT_COSMETICSEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "User_Info_Save(WorkResultRegister_T01Entity pWorkResultRegister_T01Entity)", pException);
            }
        }
        public bool usWorkResultPopup_Save_01(POPSelect_INSPECT_COSMETICSEntity pPOPSelect_INSPECT_COSMETICSEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new frmPOPMain_PRODUCT_COSMETICSProvider(pDBManager).WorkResultInfo_Save_01(pPOPSelect_INSPECT_COSMETICSEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "pfrmPOPMain_PRODUCT_COSMETICS_Save(POPSelect_INSPECT_COSMETICSEntity pPOPSelect_INSPECT_COSMETICSEntity)", pException);
            }
        }

        #region 작업요청 정보 저장 -WorkResultRegister_T01_Info_REQUEST_Save(WorkResultRegister_T01Entity pWorkResultRegister_T01Entity)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        /// 
        public bool WorkResultRegister_T01_Info_REQUEST_Save(POPSelect_INSPECT_COSMETICSEntity pPOPSelect_INSPECT_COSMETICSEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new frmPOPMain_PRODUCT_COSMETICSProvider(pDBManager).frmPOPMain_PRODUCT_COSMETICS_REQUEST_Save(pPOPSelect_INSPECT_COSMETICSEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "User_Info_Save(WorkResultRegister_T01Entity pWorkResultRegister_T01Entity)", pException);
            }
        }

        #endregion
        public bool ucWorkResultPopup_T01_Info_Save(POPSelect_INSPECT_COSMETICSEntity pPOPSelect_INSPECT_COSMETICSEntity)
        {
            try
            {

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new frmPOPMain_PRODUCT_COSMETICSProvider(pDBManager).POPSelect_INSPECT_COSMETICS_Info_Save(pPOPSelect_INSPECT_COSMETICSEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(ProductOutRegisterEntity pProductInRegisterEntity, DataTable dt)", pException);
            }
        }
    }

    #endregion

    #region O HPNC_작업일보등록_팝업_포장
    public class frmPOPMain_WEIGHING_COSMETICSBusiness
    {
        //BOM조회
        public DataTable frmPOPMain_WEIGHING_COSMETICS_Main_Return(string pCRUD, string pPART_CODE, string pLANGUAGE_TYPE, string pQTY, string pPRODUCTION_ORDER_ID)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new frmPOPMain_WEIGHING_COSMETICSProvider(pDBManager).frmPOPMain_WEIGHING_COSMETICS_Main_Return(pCRUD, pPART_CODE,pLANGUAGE_TYPE, pQTY, pPRODUCTION_ORDER_ID);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "CodePopUp_Return(string pCRUD, string pSERVICE_NAME, string pCODE_TYPE, string pCODE, string pNAME, string pVALUE1, string pVALUE2, string pVALUE3, string pUSE_YN)", pException);
            }
        }


        public DataSet frmPOPMain_WEIGHING_COSMETICS_Sub_Return(string pCRUD, string pPART_CODE)
        {
            try
            {

                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new frmPOPMain_WEIGHING_COSMETICSProvider(pDBManager).frmPOPMain_WEIGHING_COSMETICS_Sub_Return(pCRUD, pPART_CODE);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Excel_Info_Mst_Save(ucInspectRequestInfoPopupEntity pucInspectRequestInfoPopupEntity, DataTable dt1, DataTable dt2)", pException);
            }
        }


        public bool frmPOPMain_WEIGHING_COSMETICS_Save(frmPOPMain_WEIGHING_COSMETICSEntity pfrmPOPMain_WEIGHING_COSMETICSEntity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new frmPOPMain_WEIGHING_COSMETICSProvider(pDBManager).frmPOPMain_WEIGHING_COSMETICS_Save(pfrmPOPMain_WEIGHING_COSMETICSEntity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "pfrmPOPMain_PRODUCT_COSMETICS_Save(POPSelect_INSPECT_COSMETICSEntity pPOPSelect_INSPECT_COSMETICSEntity)", pException);
            }
        }



    }

    #endregion


    #region O HPNC_작업일보등록_팝업_제조
    public class frmPOPMain_SEMIPRODUCT_COSMETICSBusiness
    {
        public bool frmPOPMain_SEMIPRODUCT_COSMETICS_Save(POPSelect_INSPECT_COSMETICSEntity pPOPSelect_INSPECT_COSMETICSEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new frmPOPMain_SEMIPRODUCT_COSMETICSProvider(pDBManager).WorkResultInfo_Save(pPOPSelect_INSPECT_COSMETICSEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "pfrmPOPMain_SEMIPRODUCT_COSMETICS_Save(POPSelect_INSPECT_COSMETICSEntity pPOPSelect_INSPECT_COSMETICSEntity)", pException);
            }
        }

        //시험검사의뢰
        public bool frmPOPMain_PRODUCT_COSMETIC_Info_Check_Save(POPSelect_INSPECT_COSMETICSEntity pPOPSelect_INSPECT_COSMETICSEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new frmPOPMain_SEMIPRODUCT_COSMETICSProvider(pDBManager).WorkResultInfo_Save_02(pPOPSelect_INSPECT_COSMETICSEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "User_Info_Save(WorkResultRegister_T01Entity pWorkResultRegister_T01Entity)", pException);
            }
        }
        public bool usWorkResultPopup_Save_01(POPSelect_INSPECT_COSMETICSEntity pPOPSelect_INSPECT_COSMETICSEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new frmPOPMain_SEMIPRODUCT_COSMETICSProvider(pDBManager).WorkResultInfo_Save_01(pPOPSelect_INSPECT_COSMETICSEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "pfrmPOPMain_SEMIPRODUCT_COSMETICS_Save(POPSelect_INSPECT_COSMETICSEntity pPOPSelect_INSPECT_COSMETICSEntity)", pException);
            }
        }


    }

    #endregion
    #region O HPNC_작업지시서등록_팝업
    public class frmPOPSelect_WorkOrderDoc_COSMETICSBusiness
    {
        public DataTable frmWorkOrderDocRegPopup_COSMETICS_sheet_Info(frmPOPSelect_WorkOrderDoc_COSMETICSEntity pPOPSelect_WorkOrderDoc_COSMETICSEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable isReturn =new frmPOPSelect_WorkOrderDoc_COSMETICSProvider(pDBManager).Sheet_Info_sheet(pPOPSelect_WorkOrderDoc_COSMETICSEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "pfrmPOPMain_SEMIPRODUCT_COSMETICS_Save(POPSelect_INSPECT_COSMETICSEntity pPOPSelect_INSPECT_COSMETICSEntity)", pException);
            }
        }
        public DataSet frmWorkOrderDocRegPopup_COSMETICS_Info(string pCRUD, string pLANGUAGE_TYPE, string pPRODUCTION_ORDER_ID, string pPART_NAME, string pPART_CODE, string pPROCESS_CODE_MST)
        {
            try
            {

                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new frmPOPSelect_WorkOrderDoc_COSMETICSProvider(pDBManager).frmPOPSelect_WorkOrderDoc_COSMETICS_Return(pCRUD, pLANGUAGE_TYPE, pPRODUCTION_ORDER_ID, pPART_NAME, pPART_CODE, pPROCESS_CODE_MST);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Excel_Info_Mst_Save(ucWorkOrderDocRegPopupEntity pucWorkOrderDocRegPopupEntity, DataTable dt1, DataTable dt2)", pException);
            }
        }
        //품목코드찾기
        public DataSet frmPOPSelect_WorkOrderDoc_FINDPARTCODE_COSMETICS_Return(string pCRUD,  string pPRODUCTION_ORDER_ID, string pBARCODE_ID,  string pPROCESS_CODE_MST)
        {
            try
            {

                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new frmPOPSelect_WorkOrderDoc_COSMETICSProvider(pDBManager).frmPOPSelect_WorkOrderDoc_FINDPARTCODE_COSMETICS_Return(pCRUD, pPRODUCTION_ORDER_ID, pBARCODE_ID, pPROCESS_CODE_MST);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Excel_Info_Mst_Save(ucWorkOrderDocRegPopupEntity pucWorkOrderDocRegPopupEntity, DataTable dt1, DataTable dt2)", pException);
            }
        }
        public bool frmWorkOrderDocRegPopup_COSMETICS_Save(frmPOPSelect_WorkOrderDoc_COSMETICSEntity pPOPSelect_WorkOrderDoc_COSMETICSEntity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new frmPOPSelect_WorkOrderDoc_COSMETICSProvider(pDBManager).frmPOPSelect_WorkOrderDoc_COSMETICS_Save(pPOPSelect_WorkOrderDoc_COSMETICSEntity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "User_Info_Save(UserInformationEntity pUserInformationEntity)", pException);
            }
        }

        public bool frmWorkOrderDocRegPopup_COSMETICS_Save2(frmPOPSelect_WorkOrderDoc_COSMETICSEntity pPOPSelect_WorkOrderDoc_COSMETICSEntity, Worksheet pSheet)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new frmPOPSelect_WorkOrderDoc_COSMETICSProvider(pDBManager).frmPOPSelect_WorkOrderDoc_COSMETICS_Save2(pPOPSelect_WorkOrderDoc_COSMETICSEntity, pSheet);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "User_Info_Save(UserInformationEntity pUserInformationEntity)", pException);
            }
        }

        #region 사용자 이미지 조회 - Sample_Info(InspectFinalApprovalRegisterEntity pInspectFinalApprovalRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable GetUserImage(string CRUD, string USER_CODE)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new frmPOPSelect_WorkOrderDoc_COSMETICSProvider(pDBManager).GetUserImage(CRUD, USER_CODE);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(InspectFinalApprovalRegisterEntity pInspectFinalApprovalRegisterEntity)", pException);
            }
        }

        #endregion
    }

    #endregion

    #region O HPNC_작업요청서등록_팝업
    public class frmPOPSelect_WorkRequestDoc_COSMETICSBusiness
    {
        public DataTable frmWorkOrderDocRegPopup_COSMETICS_sheet_Info(frmPOPSelect_WorkRequestDoc_COSMETICSEntity pPOPSelect_WorkOrderDoc_COSMETICSEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable isReturn = new frmPOPSelect_WorkRequestDoc_COSMETICSProvider(pDBManager).Sheet_Info_sheet(pPOPSelect_WorkOrderDoc_COSMETICSEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "pfrmPOPMain_SEMIPRODUCT_COSMETICS_Save(POPSelect_INSPECT_COSMETICSEntity pPOPSelect_INSPECT_COSMETICSEntity)", pException);
            }
        }
        public DataSet frmWorkOrderDocRegPopup_COSMETICS_Info(string pCRUD, string pLANGUAGE_TYPE, string pPRODUCTION_ORDER_ID, string pPART_NAME, string pPART_CODE, string pPROCESS_CODE_MST)
        {
            try
            {

                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new frmPOPSelect_WorkRequestDoc_COSMETICSProvider(pDBManager).frmPOPSelect_WorkRequestDoc_COSMETICS_Return(pCRUD, pLANGUAGE_TYPE, pPRODUCTION_ORDER_ID, pPART_NAME, pPART_CODE, pPROCESS_CODE_MST);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Excel_Info_Mst_Save(ucWorkOrderDocRegPopupEntity pucWorkOrderDocRegPopupEntity, DataTable dt1, DataTable dt2)", pException);
            }
        }
        public DataTable GetUserImage(string CRUD, string USER_CODE)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new frmPOPSelect_WorkRequestDoc_COSMETICSProvider(pDBManager).GetUserImage(CRUD, USER_CODE);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(InspectFinalApprovalRegisterEntity pInspectFinalApprovalRegisterEntity)", pException);
            }
        }
        public bool frmWorkOrderDocRegPopup_COSMETICS_Save(frmPOPSelect_WorkRequestDoc_COSMETICSEntity pPOPSelect_WorkOrderDoc_COSMETICSEntity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new frmPOPSelect_WorkRequestDoc_COSMETICSProvider(pDBManager).frmPOPSelect_WorkRequestDoc_COSMETICS_Save(pPOPSelect_WorkOrderDoc_COSMETICSEntity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "User_Info_Save(UserInformationEntity pUserInformationEntity)", pException);
            }
        }


    }

    #endregion

    #region O 푸른들식품_작업일보등록_팝업
    public class frmPOPMain_PRODUCT_MIXBusiness
    {
        #region 단말기 상세 정보 조회
        public DataTable frmPOPMain_PRODUCT_MIX_terminal_Info(POPSelect_INSPECT_MIXEntity pPOPSelect_INSPECT_MIXEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable isReturn = new frmPOPMain_PRODUCT_MIXProvider(pDBManager).frmPOPMain_PRODUCT_MIX_terminal_info(pPOPSelect_INSPECT_MIXEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "frmPOPMain_PRODUCT_MIX_terminal_Info(POPSelect_INSPECT_MIXEntity pPOPSelect_INSPECT_MIXEntity)", pException);
            }
        }
        #endregion

        #region 양품/불량 DATA_COLLECTION 저장
        public bool frmPOPMain_PRODUCT_MIX_Save(POPSelect_INSPECT_MIXEntity pPOPSelect_INSPECT_MIXEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new frmPOPMain_PRODUCT_MIXProvider(pDBManager).WorkResultInfo_Save(pPOPSelect_INSPECT_MIXEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "pfrmPOPMain_PRODUCT_MIX_Save(POPWorkResult_MIXEntity pPOPWorkResult_MIXEntity)", pException);
            }
        }
        #endregion

        #region 제품 실적 정보 저장 - Sample_Info_Save(POPSelect_INSPECT_MIXEntity pPOPSelect_INSPECT_MIXEntity)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool POP_ProductInRegister_Info_Save(POPSelect_INSPECT_MIXEntity pPOPSelect_INSPECT_MIXEntity)
        {
            try
            {

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new frmPOPMain_PRODUCT_MIXProvider(pDBManager).POP_ProductInRegister_Info_Save(pPOPSelect_INSPECT_MIXEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(ProductOutRegisterEntity pProductInRegister_T03Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 강제완료 저장
        public bool usWorkResultPopup_Save_01(POPSelect_INSPECT_MIXEntity pPOPSelect_INSPECT_MIXEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new frmPOPMain_PRODUCT_MIXProvider(pDBManager).WorkResultInfo_Save_01(pPOPSelect_INSPECT_MIXEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "pfrmPOPMain_PRODUCT_MIX_Save(POPSelect_INSPECT_MIXEntity pPOPSelect_INSPECT_MIXEntity)", pException);
            }
        }
        #endregion

        #region 바코드 라벨 정보 조회
        public DataTable frmPOPMain_PRODUCT_MIX_barcode_Info(POPSelect_INSPECT_MIXEntity pPOPSelect_INSPECT_MIXEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable isReturn = new frmPOPMain_PRODUCT_MIXProvider(pDBManager).frmPOPMain_PRODUCT_MIX_barcode_Info(pPOPSelect_INSPECT_MIXEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "frmPOPMain_PRODUCT_MIX_terminal_Info(POPSelect_INSPECT_MIXEntity pPOPSelect_INSPECT_MIXEntity)", pException);
            }
        }
        #endregion

        #region 업체번호 조회
        public DataTable frmPOPMain_PRODUCT_MIX_vendCode_Info(string printCode)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable isReturn = new frmPOPMain_PRODUCT_MIXProvider(pDBManager).frmPOPMain_PRODUCT_MIX_vendCode_info(printCode);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "frmPOPMain_PRODUCT_MIX_terminal_Info(POPSelect_INSPECT_MIXEntity pPOPSelect_INSPECT_MIXEntity)", pException);
            }
        }
        #endregion

    }
    #endregion


    #region O 진영정기
    public class frmPOPMain_PRESS_LINEBusiness
    {
        #region 조회 예정
        public DataTable pfrmPOPMain_PRESS_LINE_REFRESH(frmPOPMain_PRESS_LINEEntity pfrmPOPMain_PRESS_LINEEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable isReturn = new frmPOPMain_PRESS_LINEProvider(pDBManager).frmPOPMain_PRESS_LINE_REFRESH(pfrmPOPMain_PRESS_LINEEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "pfrmPOPMain_PRESS_LINE_REFRESH(frmPOPMain_PRESS_LINEEntity pfrmPOPMain_PRESS_LINEEntity", pException);
            }
        }
        #endregion

        #region LOT 불량내역 조회
        public DataTable pfrmPOPMain_PRESS_LINE_NG_LIST(frmPOPMain_PRESS_LINEEntity pfrmPOPMain_PRESS_LINEEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable isReturn = new frmPOPMain_PRESS_LINEProvider(pDBManager).frmPOPMain_PRESS_LINE_NG_LIST(pfrmPOPMain_PRESS_LINEEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "pfrmPOPMain_PRESS_LINE_NG_LIST(frmPOPMain_PRESS_LINEEntity pfrmPOPMain_PRESS_LINEEntity)", pException);
            }
        }
        #endregion

        #region LOT 생성 저장
        public bool pfrmPOPMain_PRESS_LINE_LOT_CRATE(frmPOPMain_PRESS_LINEEntity pfrmPOPMain_PRESS_LINEEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new frmPOPMain_PRESS_LINEProvider(pDBManager).PRESS_LINE_LOT_CRATE(pfrmPOPMain_PRESS_LINEEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "pfrmPOPMain_PRESS_LINE_LOT_CRATE(frmPOPMain_PRESS_LINEEntity pfrmPOPMain_PRESS_LINEEntity", pException);
            }
        }
        #endregion

        #region 결과데이터 저장
        public bool pfrmPOPMain_PRESS_LINE_LOT_RESULT(frmPOPMain_PRESS_LINEEntity pfrmPOPMain_PRESS_LINEEntity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new frmPOPMain_PRESS_LINEProvider(pDBManager).PRESS_LINE_LOT_RESULT(pfrmPOPMain_PRESS_LINEEntity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "pfrmPOPMain_PRESS_LINE_LOT_RESULT(frmPOPMain_PRESS_LINEEntity pfrmPOPMain_PRESS_LINEEntity, DataTable dt)", pException);
            }
        }
        #endregion

    }
    #endregion


    #region O 범아_작업일보등록_팝업
    public class frmPOPMain_PRODUCT_Work_MIXBusiness
    {
        #region 단말기 상세 정보 조회
        public DataTable frmPOPMain_PRODUCT_Work_MIX_terminal_Info(POPWorkResult_MIXEntity pPOPWorkResult_MIXEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable isReturn = new frmPOPMain_PRODUCT_Work_MIXProvider(pDBManager).frmPOPMain_PRODUCT_Work_MIX_terminal_info(pPOPWorkResult_MIXEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "frmPOPMain_PRODUCT_Work_MIX_terminal_Info(POPWorkResult_MIXEntity pPOPWorkResult_MIXEntity)", pException);
            }
        }
        #endregion

        #region 양품/불량 DATA_COLLECTION 저장
        public bool frmPOPMain_PRODUCT_Work_MIX_Save(POPWorkResult_MIXEntity pPOPWorkResult_MIXEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new frmPOPMain_PRODUCT_Work_MIXProvider(pDBManager).WorkResultInfo_Save(pPOPWorkResult_MIXEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "pfrmPOPMain_PRODUCT_MIX_Save(POPWorkResult_MIXEntity pPOPWorkResult_MIXEntity)", pException);
            }
        }
        #endregion

        #region 강제완료 저장
        public bool usWorkResultPopup_Save_01(POPWorkResult_MIXEntity pPOPWorkResult_MIXEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new frmPOPMain_PRODUCT_Work_MIXProvider(pDBManager).WorkResultInfo_Save_01(pPOPWorkResult_MIXEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "pfrmPOPMain_PRODUCT_MIX_Save(POPWorkResult_MIXEntity pPOPWorkResult_MIXEntity)", pException);
            }
        }
        #endregion

        #region 바코드 라벨 정보 조회
        public DataTable frmPOPMain_PRODUCT_MIX_barcode_Info(POPWorkResult_MIXEntity pPOPWorkResult_MIXEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable isReturn = new frmPOPMain_PRODUCT_Work_MIXProvider(pDBManager).frmPOPMain_PRODUCT_MIX_barcode_Info(pPOPWorkResult_MIXEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "frmPOPMain_PRODUCT_MIX_terminal_Info(POPWorkResult_MIXEntity pPOPWorkResult_MIXEntity)", pException);
            }
        }
        #endregion
        #region 바코드 라벨 정보 조회
        public DataTable frmPOPMain_PRODUCT_MIX_barcode_save_Info(POPWorkResult_MIXEntity pPOPWorkResult_MIXEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable isReturn = new frmPOPMain_PRODUCT_Work_MIXProvider(pDBManager).frmPOPMain_PRODUCT_MIX_barcode_save_Info(pPOPWorkResult_MIXEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "frmPOPMain_PRODUCT_MIX_terminal_Info(POPWorkResult_MIXEntity pPOPWorkResult_MIXEntity)", pException);
            }
        }
        #endregion

        #region 업체번호 조회
        public DataTable frmPOPMain_PRODUCT_MIX_vendCode_Info(string printCode)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable isReturn = new frmPOPMain_PRODUCT_Work_MIXProvider(pDBManager).frmPOPMain_PRODUCT_MIX_vendCode_info(printCode);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "frmPOPMain_PRODUCT_MIX_terminal_Info(POPWorkResult_MIXEntity pPOPWorkResult_MIXEntity)", pException);
            }
        }
        #endregion

        /// <summary>
        /// BOM 최신 이미지명 가져오기
        /// </summary>
        public DataTable POPProductBOM_Image_Info(POPWorkResult_MIXEntity pPOPWorkResult_MIXEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new frmPOPMain_PRODUCT_Work_MIXProvider(pDBManager).POPProductBOM_image_info(pPOPWorkResult_MIXEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }
        #region 공지사항 가져오기
        public DataTable POPProduct_notice_Info(POPWorkResult_MIXEntity pPOPWorkResult_MIXEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new frmPOPMain_PRODUCT_Work_MIXProvider(pDBManager).POPProduct_notice_info(pPOPWorkResult_MIXEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }
        #endregion
    }


    #endregion

    #region O 대성_작업일보등록_팝업
    public class frmPOPMain_PRODUCT_Work_T50Business
    {
        #region 단말기 상세 정보 조회
        public DataTable frmPOPMain_PRODUCT_Work_T50_terminal_Info(POPWorkResult_T50Entity pPOPWorkResult_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable isReturn = new frmPOPMain_PRODUCT_Work_T50Provider(pDBManager).frmPOPMain_PRODUCT_Work_T50_terminal_info(pPOPWorkResult_T50Entity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "frmPOPMain_PRODUCT_Work_T50_terminal_Info(POPWorkResult_T50Entity pPOPWorkResult_T50Entity)", pException);
            }
        }
        #endregion

        #region 양품/불량 DATA_COLLECTION 저장
        public bool frmPOPMain_PRODUCT_Work_T50_Save(POPWorkResult_T50Entity pPOPWorkResult_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new frmPOPMain_PRODUCT_Work_T50Provider(pDBManager).WorkResultInfo_Save(pPOPWorkResult_T50Entity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "pfrmPOPMain_PRODUCT_MIX_Save(POPWorkResult_T50Entity pPOPWorkResult_T50Entity)", pException);
            }
        }
        #endregion

        #region 첫공정 조회
        public DataTable USP_production_order_t50_R60(string orderid)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable isReturn = new frmPOPMain_PRODUCT_Work_T50Provider(pDBManager).USP_production_order_t50_R60(orderid);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "pfrmPOPMain_PRODUCT_MIX_Save(POPWorkResult_T50Entity pPOPWorkResult_T50Entity)", pException);
            }
        }
        #endregion

        #region 불량시 뒷공정 오더수량 업데이트
        public DataTable USP_PRODUCTION_ORDER_T50_U10(string orderid, string seq, string badqty)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable isReturn = new frmPOPMain_PRODUCT_Work_T50Provider(pDBManager).USP_PRODUCTION_ORDER_T50_U10(orderid, seq, badqty);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "pfrmPOPMain_PRODUCT_MIX_Save(POPWorkResult_T50Entity pPOPWorkResult_T50Entity)", pException);
            }
        }
        #endregion

        #region 강제완료 저장
        public bool usWorkResultPopup_Save_01(POPWorkResult_T50Entity pPOPWorkResult_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new frmPOPMain_PRODUCT_Work_T50Provider(pDBManager).WorkResultInfo_Save_01(pPOPWorkResult_T50Entity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "pfrmPOPMain_PRODUCT_MIX_Save(POPWorkResult_T50Entity pPOPWorkResult_T50Entity)", pException);
            }
        }
        #endregion

        #region 보류/선택취소
        public bool usWorkResultPopup_Save_02(POPWorkResult_T50Entity pPOPWorkResult_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new frmPOPMain_PRODUCT_Work_T50Provider(pDBManager).WorkResultInfo_Save_02(pPOPWorkResult_T50Entity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "pfrmPOPMain_PRODUCT_MIX_Save(POPWorkResult_T50Entity pPOPWorkResult_T50Entity)", pException);
            }
        }
        #endregion

        #region 바코드 라벨 정보 조회
        public DataTable frmPOPMain_PRODUCT_MIX_barcode_Info(POPWorkResult_T50Entity pPOPWorkResult_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable isReturn = new frmPOPMain_PRODUCT_Work_T50Provider(pDBManager).frmPOPMain_PRODUCT_MIX_barcode_Info(pPOPWorkResult_T50Entity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "frmPOPMain_PRODUCT_MIX_terminal_Info(POPWorkResult_T50Entity pPOPWorkResult_T50Entity)", pException);
            }
        }
        #endregion

        #region 업체번호 조회
        public DataTable frmPOPMain_PRODUCT_MIX_vendCode_Info(string printCode)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable isReturn = new frmPOPMain_PRODUCT_Work_T50Provider(pDBManager).frmPOPMain_PRODUCT_MIX_vendCode_info(printCode);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "frmPOPMain_PRODUCT_MIX_terminal_Info(POPWorkResult_T50Entity pPOPWorkResult_T50Entity)", pException);
            }
        }
        #endregion

        #region 작업중인 작지 조회
        public DataTable USP_production_order_detail_t50_R10(string code)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable isReturn = new frmPOPMain_PRODUCT_Work_T50Provider(pDBManager).USP_production_order_detail_t50_R10(code);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "frmPOPMain_PRODUCT_Work_T50_terminal_Info(POPWorkResult_T50Entity pPOPWorkResult_T50Entity)", pException);
            }
        }
        #endregion

        #region 설비 가동 비가동 상태 등록
        public DataTable USP_equipment_running_I10(POPWorkResult_T50Entity pPOPWorkResult_T50Entity, string remark)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable isReturn = new frmPOPMain_PRODUCT_Work_T50Provider(pDBManager).USP_equipment_running_I10(pPOPWorkResult_T50Entity, remark);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "frmPOPMain_PRODUCT_Work_T50_terminal_Info(POPWorkResult_T50Entity pPOPWorkResult_T50Entity)", pException);
            }
        }
        #endregion

        #region 설비 가동 비가동 상태 조회
        public DataTable USP_equipment_running_R10(POPWorkResult_T50Entity pPOPWorkResult_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable isReturn = new frmPOPMain_PRODUCT_Work_T50Provider(pDBManager).USP_equipment_running_R10(pPOPWorkResult_T50Entity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "frmPOPMain_PRODUCT_Work_T50_terminal_Info(POPWorkResult_T50Entity pPOPWorkResult_T50Entity)", pException);
            }
        }
        #endregion

    }
    #endregion

    #region 대성_도면(품목정보) 
    public class POPProductImageCommonBusiness
    {
        /// <summary>
        /// BOM 정보 조회
        /// </summary>
        public DataTable POPProductImage_Info(POPWorkResult_T50Entity _pPOPWorkResult_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new POPProductImageCommonProvider(pDBManager).POPProductImage_Info_Mst(_pPOPWorkResult_T50Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }
    }
    #endregion


    #region hpnc_단말기정보_포트
    public class BarcodeLabelPrintBusiness
    {



        #region 마스터 정보 조회 - BarcodeLabelPrint_Info(BarcodeLabelPrintEntity pBarcodeLabelPrintEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable BarcodeLabelPrint_COM_Info(string pLanguage_type, string pTerminal_Code)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new BarcodeLabelPrinttProvider(pDBManager).BarcodeLabelPrint_COM_Info(pLanguage_type, pTerminal_Code);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOutRegister_Info(MaterialOutRegisterEntity pMaterialOutRegisterEntity)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - BarcodeLabelPrint_Info(BarcodeLabelPrintEntity pBarcodeLabelPrintEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataSet BarcodeLabelPrint_inspect_Info(string pLanguage_type, string pCrud, string pBarcode_no )
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataSet = new BarcodeLabelPrinttProvider(pDBManager).BarcodeLabelPrint_Inspect_Info(pLanguage_type, pCrud, pBarcode_no);
                    return pDataSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOutRegister_Info(MaterialOutRegisterEntity pMaterialOutRegisterEntity)", pException);
            }
        }

        #endregion


    }

    #endregion


    public class POPCheckBusiness
    {
        /// <summary>
        /// 작업지시 정보 조회
        /// </summary>
        public DataTable POPCheck_Info(POPCheckEntity _pPOPCheckEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new POPCheckProvider(pDBManager).POPCheck_Info_Mst(_pPOPCheckEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }
        

        #region 그리드 정보 저장 - POPCheck_Save(POPCheckEntity pPOPCheckEntity, pDataTable)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool POPCheck_Save(POPCheckEntity pPOPCheckEntity, DataTable pDataTable)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new POPCheckProvider(pDBManager).POPCheck_Save(pPOPCheckEntity, pDataTable);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "EquipmentCheck_T01_Save(EquipmentCheck_T01Entity pEquipmentCheck_T01Entity, DataTable pDataTable)", pException);
            }
        }

        #endregion
    }

    public class POPFirstMiddleLastBusiness
    {
        /// <summary>
        /// 작업지시 정보 조회
        /// </summary>
        public DataTable POPFirstMiddleLast_Info(POPFirstMiddleLastEntity _pPOPFirstMiddleLastEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new POPFirstMiddleLastProvider(pDBManager).POPFirstMiddleLast_Info_Mst(_pPOPFirstMiddleLastEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }


        #region 그리드 정보 저장 - POPCheck_Save(POPCheckEntity pPOPCheckEntity, pDataTable)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool POPFirstMiddleLast_Save(POPFirstMiddleLastEntity pPOPFirstMiddleLastEntity, DataTable pDataTable)

        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new POPFirstMiddleLastProvider(pDBManager).POPFirstMiddleLast_Save(pPOPFirstMiddleLastEntity, pDataTable);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "EquipmentCheck_T01_Save(EquipmentCheck_T01Entity pEquipmentCheck_T01Entity, DataTable pDataTable)", pException);
            }
        }

        #endregion
    }

    public class POPStop_T01Business
    {
        /// <summary>
        /// 작업지시 정보 조회
        /// </summary>
        public DataTable POPSTOP_Info(POPCheckEntity _pPOPCheckEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new POPStop_T01Provider(pDBManager).POPStop_Info_Mst(_pPOPCheckEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }


        #region 그리드 정보 저장 - POPCheck_Save(POPCheckEntity pPOPCheckEntity)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool POPSTOP_Save(POPCheckEntity pPOPCheckEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new POPStop_T01Provider(pDBManager).POPStop_save(pPOPCheckEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "EquipmentCheck_T01_Save(EquipmentCheck_T01Entity pEquipmentCheck_T01Entity, DataTable pDataTable)", pException);
            }
        }

        #endregion
    }
    public class POPEquipmentCheckBusiness
    {
        /// <summary>
        /// 점검표 조회
        /// </summary>
        public DataTable POPEquipmentCheck_Info(POPCheckEntity _pPOPCheckEntity, string date)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new POPEquipmentCheckProvider(pDBManager).USP_equipment_check_mst_R10(_pPOPCheckEntity, date);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }

        public DataTable POPEquipmentCheck_Info_I10(object[] item, string user, string date)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new POPEquipmentCheckProvider(pDBManager).USP_equipment_check_result_I10(item, user, date);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }

        public DataTable POPEquipmentCheck_Info_R20()
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new POPEquipmentCheckProvider(pDBManager).USP_equipment_check_mst_R20();
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }
        public DataTable POPEquipmentCheck_Info_R30()
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new POPEquipmentCheckProvider(pDBManager).USP_equipment_check_mst_R30();
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }
    }


    public class CreaPopBusiness  //크레아 관련 POP Business 
    {
        /// <summary>
        /// 점검표 조회
        /// </summary>
        public DataTable MainPrinterLeft_Search(CreaPOPEntity _PCreaPOPEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new CreaPOPProvider(pDBManager).MainPrinterLeft_Search(_PCreaPOPEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }


        public DataTable MainPrinterMain_Search(CreaPOPEntity _PCreaPOPEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new CreaPOPProvider(pDBManager).MainPrinterMain_Search(_PCreaPOPEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }

        #region 작업지시업데이트 - CoreChips_Data_Save(GatheringMainEntity pGatheringMainEntity)

        /// <summary>
        /// 서버 데이터 수집 저장
        /// </summary>
        public bool MainPrinterUpdate(CreaPOPEntity _PCreaPOPEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new CreaPOPProvider(pDBManager).MainPrinterUpdate(_PCreaPOPEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "DQ_Data_Save(DQGatheringEntity pDQGatheringEntity)", pException);
            }
        }

        #endregion
    }

    public class frmPOPMain_PRODUCT_BIOCERRABusiness
    {
        #region ○ 데이터 조회




        #endregion
        #region 그리드 정보 저장 - frmPOPMain_PRODUCT_BIOCERRA_Result_Sub1(POPProductionOrderEntity pGridInfoRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool frmPOPMain_PRODUCT_BIOCERRA_Result_Sub1(POPProductionOrderEntity pPOPProductionOrderEntity)
        {
            try
            {
                bool isReturn = true;
               
                if ((pPOPProductionOrderEntity.CRUD == "C" || pPOPProductionOrderEntity.CRUD == "U"))
                {

                    using (DBManager pDBManager = new DBManager())
                    {
                        isReturn = new frmPOPMain_PRODUCT_BIOCERRAProvider(pDBManager).frmPOPMain_PRODUCT_BIOCERRA_Result_Sub1(pPOPProductionOrderEntity);
                        return isReturn;
                    }
                }
                else
                {
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Grid_Info_Save(GridInfoRegisterEntity POPProductionOrderEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - frmPOPMain_PRODUCT_BIOCERRA_Result_Sub1(POPProductionOrderEntity pGridInfoRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool frmPOPMain_PRODUCT_BIOCERRA_Result_Sub2(POPProductionOrderEntity pPOPProductionOrderEntity)
        {
            try
            {

                DataTable dtTemp = new DataTable();
                bool isReturn = true;
             

                if ((pPOPProductionOrderEntity.CRUD == "C" || pPOPProductionOrderEntity.CRUD == "U") )
                {

                    using (DBManager pDBManager = new DBManager())
                    {
                        isReturn = new frmPOPMain_PRODUCT_BIOCERRAProvider(pDBManager).frmPOPMain_PRODUCT_BIOCERRA_Result_Sub2(pPOPProductionOrderEntity);
                        return isReturn;
                    }
                }
                else
                {
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Grid_Info_Save(GridInfoRegisterEntity pPOPProductionOrderEntity, DataTable dt)", pException);
            }
        }

        #endregion


        #region ○ 정보 저장 - WorkResultMst_Save(POPProductionOrderEntity pPOPProductionOrderEntity, DataTable dt)

        public bool WorkResultMst_Save(POPProductionOrderEntity pPOPProductionOrderEntity)
        {
            try
            {
                DataTable dtTemp = null;
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new frmPOPMain_PRODUCT_BIOCERRAProvider(pDBManager).frmPOPMain_PRODUCT_BIOCERRA_Save(pPOPProductionOrderEntity);
                    return isReturn;
                }
            }

            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultMst_Save(POPProductionOrderEntity pPOPProductionOrderEntity)", pException);
            }
        }

        #endregion
    }
    public class POP_MAIN_hwtBusiness
    {
        /// <summary>
        /// 작지조회
        /// </summary>
        public DataTable USP_process_mst_hwt_R10(string process, string order_id)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new POPMAIN_HWTProvider(pDBManager).USP_process_mst_hwt_R10(process, order_id);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }

        public DataTable USP_work_state_I10(object[] item, string orderid, string process)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new POPMAIN_HWTProvider(pDBManager).USP_work_state_I10(item, orderid, process);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }

        public DataTable USP_production_order_R10()
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new POPMAIN_HWTProvider(pDBManager).USP_production_order_R10();
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "POPProductionOrder_Info(POPProductionOrder_T50Entity pPOPProductionOrder_T50Entity)", pException);
            }
        }

        public DataTable USP_production_order_I20(POPWorkResult_T50Entity pPOPWorkResult_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new POPMAIN_HWTProvider(pDBManager).USP_production_order_I20(pPOPWorkResult_T50Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "POPProductionOrder_Info(POPProductionOrder_T50Entity pPOPProductionOrder_T50Entity)", pException);
            }
        }
    }

    public class ucTABSearchBusiness
    {
        #region 정보 조회 - ucTABSearch_Info_Return(ucTABSearchEntity pucTABSearchEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ucTABSearch_Info_Return(ucTABSearchEntity pucTABSearchEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucTABSearchProvider(pDBManager).ucTABSearch_Info_Return(pucTABSearchEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucTABSearch_Info_Return(ucTABSearchEntity pucTABSearchEntity)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ucTABSearchEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ucTABSearchEntity pucTABSearchEntity = new ucTABSearchProvider(null).GetEntity(pDataRow);
                return pucTABSearchEntity;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "GetEntity(pDataRow)",
                    pException
                );
            }
        }
        #endregion
    }

    public class ucTABRegisterBusiness
    {
        #region 정보 조회 - ucTABRegister_Info_Return(ucTABRegisterEntity pucTABRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ucTABRegister_Info_Return(ucTABRegisterEntity pucTABRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucTABRegisterProvider(pDBManager).ucTABRegister_Info_Return(pucTABRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucTABRegister_Info_Return(ucTABRegisterEntity pucTABRegisterEntity)", pException);
            }
        }

        #endregion

        #region 코멘트 정보 조회 - ucTABRegister_Info_Return(ucTABRegisterEntity pucTABRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ucTABRegister_Comment_Info_Return(ucTABRegisterEntity pucTABRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucTABRegisterProvider(pDBManager).ucTABRegister_Comment_Info_Return(pucTABRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucTABRegister_Comment_Info_Return(ucTABRegisterEntity pucTABRegisterEntity)", pException);
            }
        }

        #endregion

        #region 단일 데이터 정보 저장 - ucTABRegister_Info_Save(TabletBasedSensorInfoRegisterEntity pTabletBasedSensorInfoRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ucTABRegister_Info_One_Save(ucTABRegisterEntity pucTABRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ucTABRegisterProvider(pDBManager).ucTABRegister_Info_One_Save(pucTABRegisterEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucTABRegister_Info_One_Save(ucTABRegisterEntity pucTABRegisterEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 엑셀 시트 정보 저장 - ucTABExcel_Save(ucTABRegisterEntity _pucTABRegisterEntity, Worksheet sheet_0)

        /// <summary>
        /// 정보 저장
        /// </summary>
        public bool InputData_Excel_Save(ucTABRegisterEntity _pucTABRegisterEntity, Worksheet sheet_0)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ucTABRegisterProvider(pDBManager).InputData_Excel_Save(_pucTABRegisterEntity, sheet_0);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "InputData_Excel_Save(ucTABRegisterEntity _pucTABRegisterEntity, Worksheet sheet_0)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ucTABRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ucTABRegisterEntity pucTABRegisterEntity = new ucTABRegisterProvider(null).GetEntity(pDataRow);
                return pucTABRegisterEntity;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "GetEntity(pDataRow)",
                    pException
                );
            }
        }
        #endregion
    }

    public class ucTABExcelBusiness
    {
        #region ○ 화면명에 맞는 엑셀파일 불러오기
        public DataTable Sheet_Info_Sheet(ucTABExcelEntity pucTABExcelEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pdatatable = new ucTABExcelProvider(pDBManager).Sheet_Info_sheet(pucTABExcelEntity);
                    return pdatatable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sheet_Info_Sheet(HACCPCheckRegisterT07Entity _pHACCPCheckRegisterT07Entity)", pException);
            }
        }
        #endregion

        #region ○ 엑셀 시트 저장 - ucTABExcel_Save( Worksheet sheet_0)

        /// <summary>
        /// 정보 저장
        /// </summary>
        public bool ucTABExcel_Save(ucTABExcelEntity _pucTABExcelEntity, Worksheet sheet_0)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ucTABExcelProvider(pDBManager).ucTABExcel_Save(_pucTABExcelEntity, sheet_0);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "HACCPCheckRegister_Info_Save(HACCPCheckRegisterT07Entity pHACCPCheckRegisterT07Entity, DataTable dt)", pException);
            }
        }

        #endregion
    }

    public class ucTABCommentBusiness
    {
        #region 정보 조회 - ucTABComment_Info_Return(ucTABCommentEntity pucTABCommentEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ucTABComment_Info_Return(ucTABCommentEntity pucTABCommentEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucTABCommentProvider(pDBManager).ucTABComment_Info_Return(pucTABCommentEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucTABComment_Info_Return(ucTABCommentEntity pucTABCommentEntity)", pException);
            }
        }

        #endregion

        #region 정보 저장 - ucTABComment_Info_Save(ucTABCommentEntity pucTABCommentEntity)
        public bool ucTABComment_Info_Save(ucTABCommentEntity pucTABCommentEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ucTABCommentProvider(pDBManager).ucTABComment_Info_Save(pucTABCommentEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucTABComment_Info_Save(ucTABCommentEntity pucTABCommentEntity)", pException);
            }
        }
        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ucTABCommentEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ucTABCommentEntity pucTABCommentEntity = new ucTABCommentProvider(null).GetEntity(pDataRow);
                return pucTABCommentEntity;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "GetEntity(pDataRow)",
                    pException
                );
            }
        }
        #endregion
    }

    public class ucTABLobbyBusiness
    {
        #region 정보 조회 - ucTABLobby_Info_Return(ucTABLobbyEntity pucTABLobbyEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ucTABLobby_Info_Return(ucTABLobbyEntity pucTABLobbyEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucTABLobbyProvider(pDBManager).ucTABLobby_Info_Return(pucTABLobbyEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucTABLobby_Info_Return(ucTABLobbyEntity pucTABLobbyEntity)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ucTABLobbyEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ucTABLobbyEntity pucTABLobbyEntity = new ucTABLobbyProvider(null).GetEntity(pDataRow);
                return pucTABLobbyEntity;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "GetEntity(pDataRow)",
                    pException
                );
            }
        }
        #endregion
    }

    public class ucTABEquipmentBusiness
    {
        #region 정보 조회 - ucTABEquipment_Info_Return(ucTABEquipmentEntity pucTABEquipmentEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ucTABEquipment_Info_Return(ucTABEquipmentEntity pucTABEquipmentEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucTABEquipmentProvider(pDBManager).ucTABEquipment_Info_Return(pucTABEquipmentEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucTABEquipment_Info_Return(ucTABEquipmentEntity pucTABEquipmentEntity)", pException);
            }
        }

        #endregion

        #region 코멘트 정보 조회 - ucTABEquipment_Info_Return(ucTABEquipmentEntity pucTABEquipmentEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ucTABEquipment_Comment_Info_Return(ucTABEquipmentEntity pucTABEquipmentEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucTABEquipmentProvider(pDBManager).ucTABEquipment_Comment_Info_Return(pucTABEquipmentEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucTABEquipment_Comment_Info_Return(ucTABEquipmentEntity pucTABEquipmentEntity)", pException);
            }
        }

        #endregion

        #region 점검 결과 정보 저장 - ucTABEquipment_Info_Inspect_Save(TabletBasedSensorInfoRegisterEntity pTabletBasedSensorInfoRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ucTABEquipment_Info_Inspect_Save(ucTABEquipmentEntity pucTABEquipmentEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ucTABEquipmentProvider(pDBManager).ucTABEquipment_Info_Inspect_Save(pucTABEquipmentEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucTABEquipment_Info_Inspect_Save(ucTABEquipmentEntity pucTABEquipmentEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 엑셀 시트 정보 저장 - ucTABExcel_Save(ucTABEquipmentEntity _pucTABEquipmentEntity, Worksheet sheet_0)

        /// <summary>
        /// 정보 저장
        /// </summary>
        public bool InputData_Excel_Save(ucTABEquipmentEntity _pucTABEquipmentEntity, Worksheet sheet_0)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ucTABEquipmentProvider(pDBManager).InputData_Excel_Save(_pucTABEquipmentEntity, sheet_0);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "InputData_Excel_Save(ucTABEquipmentEntity _pucTABEquipmentEntity, Worksheet sheet_0)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ucTABEquipmentEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ucTABEquipmentEntity pucTABEquipmentEntity = new ucTABEquipmentProvider(null).GetEntity(pDataRow);
                return pucTABEquipmentEntity;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "GetEntity(pDataRow)",
                    pException
                );
            }
        }
        #endregion
    }
}

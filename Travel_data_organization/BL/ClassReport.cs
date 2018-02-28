using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Travel_data_organization.DAL;
using System.Data;

namespace Travel_data_organization.BL
{
    class ClassReport
    {
        public static DataTable SelectAllDetails() 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SelectAllDetails", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable selectIMGDet(int GalDet_id) 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectIMGDet", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@GalDet_id", SqlDbType.Int, GalDet_id));
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable selectProIMG(int pro_id) 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectProIMG", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@product_id", SqlDbType.Int, pro_id));
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable selectComIMG(int Com_id)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectComIMG", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@company_id", SqlDbType.Int, Com_id));
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable selectBCIMG(int Com_id)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectBCIMG", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@company_id", SqlDbType.Int, Com_id));
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable selectCatalogIMG(int Gal_id)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectCatalogIMG", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Gallery_id", SqlDbType.Int, Gal_id));
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable selectBillIMG(int Gal_id)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectBillIMG", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Gal_id", SqlDbType.Int, Gal_id));
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable selectQuotIMG(int Gal_id)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectQuotIMG", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Gal_id", SqlDbType.Int, Gal_id));
            DataAccessLayer.Close();
            return dt;
        }
        
        //*****************************************************
        public static DataTable SearchInAllDetails(string search) 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SearchInAllDetails", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@var", SqlDbType.NVarChar, search));
            DataAccessLayer.Close();
            return dt;
        }
    }
}

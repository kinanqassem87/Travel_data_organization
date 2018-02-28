using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Travel_data_organization.DAL;
using System.Data;

namespace Travel_data_organization.BL
{
    class ClassManagment
    {
        public static DataTable selectAllCompany() 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectAllCompany", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable SearchAllCompany(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SearchAllCompany", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@search", SqlDbType.NVarChar, search));
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable selectAllIMGOneCompany(int id) 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectAllIMGOneCompany", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@company_id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return dt;
        }
        public static int deleteComImage(int id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("deleteComImage", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable selectAllComBCImage(int id)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectAllComBCImage", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@company_id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return dt;
        }
        public static int DeleteBCCompany(int id)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("DeleteBCCompany", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@CompBus_id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return i;
        }
        public static int UpdateCompanyName(int id, string CoName) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("UpdateCompanyName", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@company_id", SqlDbType.Int, id),
                DataAccessLayer.CreateParameter("@company_name", SqlDbType.NVarChar, CoName));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable SearchCategory(string Cat) 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SearchCategory", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@catogary_name", SqlDbType.NVarChar, Cat));
            DataAccessLayer.Close();
            return dt;
        }
        public static int UpdateCategory(int id, string catName) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("UpdateCategory", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@catogary_id", SqlDbType.Int, id),
                DataAccessLayer.CreateParameter("@catogary_name", SqlDbType.NVarChar, catName));
            DataAccessLayer.Close();
            return i;
        }


        //********************country managment *************************

        public static DataTable selectAllCountry() 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectAllCountry", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable searchAllCountry(string name)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("searchAllCountry", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@search", SqlDbType.NVarChar, name));
            DataAccessLayer.Close();
            return dt;
        }
        public static int updateCountry(int id, string name) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("updateCountry", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id),
                DataAccessLayer.CreateParameter("@name", SqlDbType.NVarChar, name));
            DataAccessLayer.Close();
            return i;
        }

        // ********************** city managment *************************
        public static DataTable AllCityDisplay() 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("AllCityDisplay", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable searchCityDisplay(string name)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("searchCityDisplay", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@name", SqlDbType.NVarChar, name));
            DataAccessLayer.Close();
            return dt;
        }
        public static int updateCityName(int id, string name)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("updateCityName", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id),
                DataAccessLayer.CreateParameter("@name", SqlDbType.NVarChar, name));
            DataAccessLayer.Close();
            return i;
        } 

        //*********************** Type Managment ***********************

        public static DataTable SelectAllTypeDisplay()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SelectAllTypeDisplay", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable SearchNameTypeDisplay(string name)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SearchNameTypeDisplay", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@search", SqlDbType.NVarChar, name));
            DataAccessLayer.Close();
            return dt;
        }

        public static int UpdateNameType(int id, string name)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("UpdateNameType", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id),
                DataAccessLayer.CreateParameter("@name", SqlDbType.NVarChar, name));
            DataAccessLayer.Close();
            return i;
        } 

        //*********************** Color Managment **********************

        public static DataTable DisplayAllColor()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("DisplayAllColor", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable SearchNameColor(string name)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SearchNameColor", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@name", SqlDbType.NVarChar, name));
            DataAccessLayer.Close();
            return dt;
        }

        public static int UpdateNameColor(int id, string name)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("UpdateNameColor", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id),
                DataAccessLayer.CreateParameter("@name", SqlDbType.NVarChar, name));
            DataAccessLayer.Close();
            return i;
        } 

        //*************************  Product Managment  ***************************

        public static DataTable selectOneProduct(int id) 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectOneProduct", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return dt;
        }

        public static int UpdateOneProduct(int id, int cat, string name, string barcode, int typePro, int colorPro) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("UpdateOneProduct", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id),
                DataAccessLayer.CreateParameter("@category", SqlDbType.Int, cat),
                DataAccessLayer.CreateParameter("@namePro", SqlDbType.NVarChar, name),
                DataAccessLayer.CreateParameter("@barcode", SqlDbType.NVarChar, barcode),
                DataAccessLayer.CreateParameter("@type", SqlDbType.Int, typePro),
                DataAccessLayer.CreateParameter("@color", SqlDbType.Int, colorPro));
            DataAccessLayer.Close();
            return i;
        }

        public static int UpdateOneProductinGal(int id, int cat, int typePro, int colorPro)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("UpdateOneProductinGal", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Productid", SqlDbType.Int, id),
                DataAccessLayer.CreateParameter("@category", SqlDbType.Int, cat),
                DataAccessLayer.CreateParameter("@type", SqlDbType.Int, typePro),
                DataAccessLayer.CreateParameter("@color", SqlDbType.Int, colorPro));
            DataAccessLayer.Close();
            return i;
        }

    }
}

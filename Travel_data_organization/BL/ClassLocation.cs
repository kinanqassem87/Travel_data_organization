using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Travel_data_organization.DAL;

namespace Travel_data_organization.BL
{
    class ClassLocation
    {
        public static int sp_addcountry(string name) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_addcountry", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@name", SqlDbType.NVarChar, name));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable sp_selectAllCountry() 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_selectAllCountry", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static int sp_AddCity(string name, int id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_AddCity", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@cityname", SqlDbType.NVarChar, name),
                DataAccessLayer.CreateParameter("@country_id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return i;
        }
    }
}

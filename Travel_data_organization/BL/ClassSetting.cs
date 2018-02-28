using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Travel_data_organization.DAL;

namespace Travel_data_organization.BL
{
    class ClassSetting
    {
        public static int sp_AddCatogary(string name) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_AddCatogary", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@name", SqlDbType.NVarChar, name));
            DataAccessLayer.Close();
            return i;
        }

        //*******************************

        public static int sp_addty(string name)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_addty", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@namet", SqlDbType.NVarChar, name));
            DataAccessLayer.Close();
            return i;
        }
        public static int sp_addcolorpro(string name)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_addcolorpro", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@namec", SqlDbType.NVarChar, name));
            DataAccessLayer.Close();
            return i;
        }
        public static int sp_addProduct(string name,string barcode,int cat,int col,int typ) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_addProduct", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@proName", SqlDbType.NVarChar, name),
                DataAccessLayer.CreateParameter("@proBarcode", SqlDbType.NVarChar, barcode),
                DataAccessLayer.CreateParameter("@category_id", SqlDbType.Int, cat),
                DataAccessLayer.CreateParameter("@colorpro_id", SqlDbType.Int, col),
                DataAccessLayer.CreateParameter("@typePro_id", SqlDbType.Int, typ));
            DataAccessLayer.Close();
            return i;
        }
        //*********************************************

        public static DataTable sp_allCategory() 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_allCategory", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable sp_allTypys()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_allTypys", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable sp_allColors()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_allColors", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static int sp_imgageProduct(byte[] proImg,int proID) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_imgageProduct", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ProImg_image", SqlDbType.Image, proImg),
                DataAccessLayer.CreateParameter("@product_id", SqlDbType.Int, proID));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable sp_lastProID()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_lastProID", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        //******************************************************

        public static int sp_Addcompany(string name, int city_id,int country_id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_Addcompany", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@name", SqlDbType.NVarChar, name),
                DataAccessLayer.CreateParameter("@city_id", SqlDbType.Int, city_id),
                DataAccessLayer.CreateParameter("@country_id", SqlDbType.Int, country_id));
            DataAccessLayer.Close();
            return i;
        }
        public static int sp_AddcompanyIMG(byte[] comImg, int comID) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_AddcompanyIMG", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@comIMG", SqlDbType.Image, comImg),
                DataAccessLayer.CreateParameter("@company_id", SqlDbType.Int, comID));
            DataAccessLayer.Close();
            return i;
        }
        public static int sp_AddcompanyBCard(byte[] comImgBC, int comID)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_AddcompanyBCard", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@comIMGBC", SqlDbType.Image, comImgBC),
                DataAccessLayer.CreateParameter("@company_id", SqlDbType.Int, comID));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable sp_selectTopCompany() 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_selectTopCompany", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        //************************************************************

        public static DataTable sp_selectCityOfCountry(int id) 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_selectCityOfCountry", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return dt;
        }
        //******************************************************

        public static int sp_AddToGallery(string Gyear,string Season,string Isbill,string IsQuot) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_AddToGallery", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@gallery_year", SqlDbType.NVarChar, Gyear),
                DataAccessLayer.CreateParameter("@season", SqlDbType.NVarChar, Season),
                DataAccessLayer.CreateParameter("@isbill", SqlDbType.NVarChar, Isbill),
                DataAccessLayer.CreateParameter("@isQuot", SqlDbType.NVarChar, IsQuot));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable selectlastGal() 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectlastGal", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static int AddtoGalDetails(int cat_id,int pro_id,int comp_ID,int color_id,int type_id,int gallert_id,int country_id,int city_id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("AddtoGalDetails", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@cat_id", SqlDbType.Int, cat_id),
                DataAccessLayer.CreateParameter("@pro_id", SqlDbType.Int, pro_id),
                DataAccessLayer.CreateParameter("@comp_id", SqlDbType.Int, comp_ID),
                DataAccessLayer.CreateParameter("@color_id", SqlDbType.Int, color_id),
                DataAccessLayer.CreateParameter("@type_id", SqlDbType.Int, type_id),
                DataAccessLayer.CreateParameter("@gallery_id", SqlDbType.Int, gallert_id),
                DataAccessLayer.CreateParameter("@country_id", SqlDbType.Int, country_id),
                DataAccessLayer.CreateParameter("@city_id", SqlDbType.Int, city_id));
            DataAccessLayer.Close();
            return i;
        }
        //**********************************************************
        public static int AddtoCataloge(byte[] arrIMG, int id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("AddtoCataloge", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@catImage", SqlDbType.Image, arrIMG),
                DataAccessLayer.CreateParameter("@Gal_id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return i;
        }
        //*******************************************************

        public static int addbill(DateTime BillDate, int gal_id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("addbill", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@billDate", SqlDbType.Date, BillDate),
                DataAccessLayer.CreateParameter("@galID", SqlDbType.Int, gal_id));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable selectLastBill() 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectLastBill", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static int addtoBillDetails(byte[] arr, int Bill_id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("addtoBillDetails", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@BillImg", SqlDbType.Image, arr),
                DataAccessLayer.CreateParameter("@Bill_id", SqlDbType.Int, Bill_id));
            DataAccessLayer.Close();
            return i;
        }
        //******************************************************
        public static int AddQuot(DateTime QuotDate, int id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("AddQuot", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@QuotDate", SqlDbType.Date, QuotDate),
                DataAccessLayer.CreateParameter("@Gal_id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return i;
        }

        public static DataTable selectLastQuot() 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectLastQuot", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static int addtoQuotDetails(byte[] arr, int id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("addtoQuotDetails", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@quotImg", SqlDbType.Image, arr),
                DataAccessLayer.CreateParameter("@quot_ID", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return i;
        }
        //*********************************************************
        public static DataTable selectComOfCity(int city_id,int country_id) 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectComOfCity", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@city_id", SqlDbType.Int, city_id),
                DataAccessLayer.CreateParameter("@country_id", SqlDbType.Int, country_id));
            DataAccessLayer.Close();
            return dt;
        }
        //***********************************************************
        public static DataTable selectAllProduct() 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectAllProduct", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        //************************************************************
        public static DataTable selectProductDeatail(int id) 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectProductDeatail", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@product_id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return dt;
        }

        //*************** Check Names Befor Insert ******************

        public static DataTable searchCatByName(string search) 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("searchCatByName", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@search", SqlDbType.NVarChar, search));
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable searchCityByName(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("searchCityByName", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@search", SqlDbType.NVarChar, search));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable searchColorByName(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("searchColorByName", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@search", SqlDbType.NVarChar, search));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable searchCompanyByName(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("searchCompanyByName", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@search", SqlDbType.NVarChar, search));
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable searchCountryByName(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("searchCountryByName", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@search", SqlDbType.NVarChar, search));
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable searchProductsByName(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("searchProductsByName", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@search", SqlDbType.NVarChar, search));
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable searchProTypeByName(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("searchProTypeByName", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@search", SqlDbType.NVarChar, search));
            DataAccessLayer.Close();
            return dt;
        }
        //*************** Product Managment **************************
        public static DataTable selectAllProductMaang() 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectAllProductMaang", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable searchAllProductMaang(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("searchAllProductMaang", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@search", SqlDbType.NVarChar, search));
            DataAccessLayer.Close();
            return dt;
        }

        public static int updateProductName(int id, string name) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("updateProductName", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id),
                DataAccessLayer.CreateParameter("@name", SqlDbType.NVarChar, name));
            DataAccessLayer.Close();
            return i;
        }

        public static DataTable SelectImageOnePro(int id) 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SelectImageOnePro", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return dt;
        }

        public static int deleteProImage(int id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("deleteProImage", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return i;
        }
        
        //******************************  BackUp *************************
        public static void Back_up(string Path)
        {
            DataAccessLayer.Open();
            string Query = string.Format("Backup Database TravelData to Disk = '{0}'", Path);
            DataAccessLayer.ExecuteNonQuery(Query, CommandType.Text);
            DataAccessLayer.Close();

        }
    }
}

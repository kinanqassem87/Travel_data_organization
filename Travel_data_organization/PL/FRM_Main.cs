using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Travel_data_organization.PL
{
    
    public partial class FRM_Main : Form
    {
        public static string FullName = "";
        public static string UserName = "";
        public static string U_Password = "";
        public static string u_id = "";
        public static string Per = "";
        public FRM_Main()
        {
            InitializeComponent();
        }

        private void tsIN_Click(object sender, EventArgs e)
        {
            FRM_SignIN s = new FRM_SignIN();
            s.ShowDialog();
        }

        private void FRM_Main_Activated(object sender, EventArgs e)
        {
            if (Per.Equals("admin")) 
            {
                tsReport.Enabled = tsSetting.Enabled=tsLocation.Enabled =tsOut.Enabled=TSChangePass.Enabled=tsManagment.Enabled=backupDataBaseToolStripMenuItem.Enabled= true;
                tsIN.Enabled = false;
            }
            if (Per.Equals("user"))
            {
                tsReport.Enabled=tsOut.Enabled=TSChangePass.Enabled = true;
                tsIN.Enabled = false;
            }
        }

        private void tsOut_Click(object sender, EventArgs e)
        {
            Per = "out";
            tsReport.Enabled = tsSetting.Enabled = tsLocation.Enabled = tsOut.Enabled = TSChangePass.Enabled=tsManagment.Enabled=backupDataBaseToolStripMenuItem.Enabled= false;
            tsIN.Enabled = true;
            FRM_SignIN s = new FRM_SignIN();
            s.ShowDialog();
        }

        private void TSChangePass_Click(object sender, EventArgs e)
        {
            FRM_ChangPassword c = new FRM_ChangPassword();
            c.ShowDialog();
        }

        private void tsAddcountry_Click(object sender, EventArgs e)
        {
            FRM_AddCountry a = new FRM_AddCountry();
            a.ShowDialog();
        }

        private void tsAddCity_Click(object sender, EventArgs e)
        {
            FRM_AddCity a = new FRM_AddCity();
            a.ShowDialog();
        }

        private void tsAddCategory_Click(object sender, EventArgs e)
        {
            FRM_AddCategory a = new FRM_AddCategory();
            a.ShowDialog();
        }

        private void tsAddType_Click(object sender, EventArgs e)
        {
            FRM_AddType a = new FRM_AddType();
            a.ShowDialog();
        }

        private void tsAddColor_Click(object sender, EventArgs e)
        {
            FRM_AddColor a = new FRM_AddColor();
            a.ShowDialog();
        }

        private void tsAddProduct_Click(object sender, EventArgs e)
        {
            FRM_AddProduct a = new FRM_AddProduct();
            a.ShowDialog();
        }

        private void tsAddCompany_Click(object sender, EventArgs e)
        {
            FRM_AddCompany a = new FRM_AddCompany();
            a.ShowDialog();
        }

        private void tsAddNewDetails_Click(object sender, EventArgs e)
        {
            FRM_AddItemFromGallery a = new FRM_AddItemFromGallery();
            a.ShowDialog();
        }

        private void tsReport_Click(object sender, EventArgs e)
        {
            FRM_Report r = new FRM_Report();
            r.ShowDialog();
        }

        private void tsAbout_Click(object sender, EventArgs e)
        {
            FRM_About a = new FRM_About();
            a.ShowDialog();
        }

        private void companyImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Company_Manag a = new FRM_Company_Manag("Company Image");
            a.ShowDialog();
        }

        private void companyBCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Company_Manag a = new FRM_Company_Manag("Business Card");
            a.ShowDialog();
        }

        private void categoryManagmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CategoryUpdate a = new FRM_CategoryUpdate();
            a.ShowDialog();
        }

        private void productManagmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ProductImageManag a = new FRM_ProductImageManag();
            a.ShowDialog();
        }

        private void counrtyManagmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CountryManagment a = new FRM_CountryManagment();
            a.ShowDialog();
        }

        private void cityManagmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CityManagment a = new FRM_CityManagment();
            a.ShowDialog();
        }

        private void typeManagmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_TypeManagment a = new FRM_TypeManagment();
            a.ShowDialog();
        }

        private void colorManagmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ColorManagment a = new FRM_ColorManagment();
            a.ShowDialog();
        }

        private void backupDataBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_BackUp a = new FRM_BackUp();
            a.ShowDialog();
        }
    }
}

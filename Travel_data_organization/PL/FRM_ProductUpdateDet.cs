using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Travel_data_organization.BL;

namespace Travel_data_organization.PL
{
    public partial class FRM_ProductUpdateDet : Form
    {
        int ProductId;
        public FRM_ProductUpdateDet(string s)
        {
            ProductId = int.Parse(s);
            InitializeComponent();

            DataTable dtCat = ClassSetting.sp_allCategory();
            cmbCategory.DataSource = dtCat;
            cmbCategory.DisplayMember = "catogary_name";
            cmbCategory.ValueMember = "catogary_id";

            DataTable dttype = ClassSetting.sp_allTypys();
            cmbType.DataSource = dttype;
            cmbType.DisplayMember = "typePro_name";
            cmbType.ValueMember = "typePro_id";

            DataTable dtcolor = ClassSetting.sp_allColors();
            cmbColor.DataSource = dtcolor;
            cmbColor.DisplayMember = "colorPro_name";
            cmbColor.ValueMember = "colorPro_id";

            DataTable ProductDet = ClassManagment.selectOneProduct(ProductId);
            cmbCategory.Text = ProductDet.Rows[0][0].ToString();
            txtname.Text = ProductDet.Rows[0][1].ToString();
            txtBarcode.Text = ProductDet.Rows[0][2].ToString();
            cmbType.Text = ProductDet.Rows[0][3].ToString();
            cmbColor.Text = ProductDet.Rows[0][4].ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtname.Text.Equals(""))
            {
                MessageBox.Show("Please Insert Product Name.");
            }
            else 
            {
                int i = ClassManagment.UpdateOneProduct(ProductId, (int)cmbCategory.SelectedValue, txtname.Text, txtBarcode.Text, (int)cmbType.SelectedValue, (int)cmbColor.SelectedValue);
                int updProduct = ClassManagment.UpdateOneProductinGal(ProductId, (int)cmbCategory.SelectedValue, (int)cmbType.SelectedValue, (int)cmbColor.SelectedValue);
                MessageBox.Show("Done");
                this.Close();
            }
        }

        
    }
}

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
    public partial class FRM_ProductImageManag : Form
    {
        public FRM_ProductImageManag()
        {
            InitializeComponent();
            display();
        }
        void display() 
        {
            dgvAllProduct.DataSource = ClassSetting.selectAllProductMaang();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvAllProduct.DataSource = ClassSetting.searchAllProductMaang(txtSearch.Text);
            txtName.Text = "";
        }

        private void dgvAllProduct_Click(object sender, EventArgs e)
        {
            try
            {
                txtName.Text = dgvAllProduct.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception) { }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Equals(""))
            {
                MessageBox.Show("Select One Please . .");
            }
            else
            {
                FRM_ProductUpdateDet a = new FRM_ProductUpdateDet(dgvAllProduct.CurrentRow.Cells[0].Value.ToString());
                a.ShowDialog();
            }

            
            //else
            //{
            //    int UpNameCom = ClassSetting.updateProductName(int.Parse(dgvAllProduct.CurrentRow.Cells[0].Value.ToString()), txtName.Text);
            //    txtName.Text = "";
            //    display();
            //    MessageBox.Show("Done . .");
            //}
        }

        private void dgvAllProduct_DoubleClick(object sender, EventArgs e)
        {
            FRM_ProductImageView a = new FRM_ProductImageView(dgvAllProduct.CurrentRow.Cells[0].Value.ToString());
            a.ShowDialog();
        }

        private void FRM_ProductImageManag_Activated(object sender, EventArgs e)
        {
            display();
            txtName.Text = "";
        }
    }
}

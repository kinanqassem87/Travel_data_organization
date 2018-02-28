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
    public partial class FRM_Company_Manag : Form
    {
        public FRM_Company_Manag(string s)
        {
            InitializeComponent();
            display();
            FRM_Com_Image.ComImgBC = s;
        }
        void display() 
        {
            dgvAllCompany.DataSource = ClassManagment.selectAllCompany();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvAllCompany.DataSource = ClassManagment.SearchAllCompany(txtSearch.Text);
            txtName.Text = "";
        }

        private void dgvAllCompany_DoubleClick(object sender, EventArgs e)
        {
            FRM_Com_Image a = new FRM_Com_Image(dgvAllCompany.CurrentRow.Cells[0].Value.ToString());
            a.ShowDialog();
        }

        private void dgvAllCompany_Click(object sender, EventArgs e)
        {
            try
            {
                txtName.Text = dgvAllCompany.CurrentRow.Cells[1].Value.ToString();
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
                int UpNameCom = ClassManagment.UpdateCompanyName(int.Parse(dgvAllCompany.CurrentRow.Cells[0].Value.ToString()), txtName.Text);
                txtName.Text = "";
                display();
                MessageBox.Show("Done . .");
            }
        }
    }
}

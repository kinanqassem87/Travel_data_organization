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
    public partial class FRM_CategoryUpdate : Form
    {
        public FRM_CategoryUpdate()
        {
            InitializeComponent();
            display();
        }
        void display() 
        {
            dgvCategory.DataSource = ClassSetting.sp_allCategory();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvCategory.DataSource = ClassManagment.SearchCategory(txtSearch.Text);
        }

        private void dgvCategory_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtID.Text = dgvCategory.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = dgvCategory.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception) { }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals("") || txtName.Text.Equals(""))
            {
                MessageBox.Show("Insert Data");
            }
            else 
            {
                int i = ClassManagment.UpdateCategory(int.Parse(txtID.Text), txtName.Text);
                txtID.Text = txtName.Text = "";
                display();
                MessageBox.Show("Done . .");
            }
        }
    }
}

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
    public partial class FRM_CountryManagment : Form
    {
        public FRM_CountryManagment()
        {
            InitializeComponent();
            display();
        }
        void display() 
        {
            dgvCountry.DataSource = ClassManagment.selectAllCountry();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvCountry.DataSource = ClassManagment.searchAllCountry(txtSearch.Text);
        }

        private void dgvCountry_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtID.Text = dgvCountry.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = dgvCountry.CurrentRow.Cells[1].Value.ToString();
            }
            catch(Exception) { }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals("") || txtName.Text.Equals(""))
            {
                MessageBox.Show("Select One");
            }
            else 
            {
                int i = ClassManagment.updateCountry(int.Parse(txtID.Text), txtName.Text);
                txtID.Text = txtName.Text = "";
                display();
                MessageBox.Show("Done");
            }
        }

    }
}

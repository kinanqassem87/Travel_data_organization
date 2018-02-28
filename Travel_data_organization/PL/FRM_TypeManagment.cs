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
    public partial class FRM_TypeManagment : Form
    {
        public FRM_TypeManagment()
        {
            InitializeComponent();
            display();
        }
        void display() 
        {
            dgvType.DataSource = ClassManagment.SelectAllTypeDisplay();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvType.DataSource = ClassManagment.SearchNameTypeDisplay(txtSearch.Text);
        }

        private void dgvType_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtID.Text = dgvType.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = dgvType.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception) { }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals("") || txtName.Text.Equals(""))
            {
                MessageBox.Show("Select one . . ");
            }
            else 
            {
                int i = ClassManagment.UpdateNameType(int.Parse(txtID.Text), txtName.Text);
                txtID.Text = txtName.Text = "";
                display();
                MessageBox.Show("Done . . ");
            }
        }
    }
}

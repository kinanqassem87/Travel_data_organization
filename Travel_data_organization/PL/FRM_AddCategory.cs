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
    public partial class FRM_AddCategory : Form
    {
        public FRM_AddCategory()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int found = 0;
            if (txtName.Text.Equals(""))
            {
                MessageBox.Show("Insert data Please");
            }
            else 
            {
                DataTable dt = ClassSetting.searchCatByName(txtName.Text);
                for (int i = 0; i < dt.Rows.Count; i++) 
                {
                    if (txtName.Text.Equals(dt.Rows[i][0].ToString())) { found = 1; }
                }
                if (found == 1)
                {
                    MessageBox.Show("This name already exists . .");
                }
                else
                {
                    int Add = ClassSetting.sp_AddCatogary(txtName.Text);
                    txtName.Text = "";
                    MessageBox.Show("Done");
                }
            }
        }
    }
}

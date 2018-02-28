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
    public partial class FRM_AddCity : Form
    {
        
        public FRM_AddCity()
        {
            InitializeComponent();
            fullcmb();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void fullcmb() 
        {
            DataTable dt = ClassLocation.sp_selectAllCountry();
            cmbCountry.DataSource = dt;
            cmbCountry.DisplayMember = "country_name";
            cmbCountry.ValueMember = "country_id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int found = 0;
            if (txtname.Text.Equals(""))
            {
                MessageBox.Show("Insert data Please");
            }
            else 
            {
                DataTable dt = ClassSetting.searchCityByName(txtname.Text); 
                for (int i = 0; i < dt.Rows.Count; i++) 
                {
                    if (txtname.Text.Equals(dt.Rows[i][0].ToString())) { found = 1; }
                }
                if (found == 1)
                {
                    MessageBox.Show("This name already exists . .");
                }
                else
                {
                    int add = ClassLocation.sp_AddCity(txtname.Text, int.Parse(cmbCountry.SelectedValue.ToString()));
                    txtname.Text = "";
                    MessageBox.Show("Done");
                }
            }
        } 
    }
}

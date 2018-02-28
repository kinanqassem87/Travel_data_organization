﻿using System;
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
    public partial class FRM_AddCountry : Form
    {
        public FRM_AddCountry()
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
            if (txtname.Text.Equals(""))
            {
                MessageBox.Show("Insert data please");
            }
            else 
            {
                DataTable dt = ClassSetting.searchCountryByName(txtname.Text);
                for (int j = 0; j < dt.Rows.Count; j++) 
                {
                    if (txtname.Text.Equals(dt.Rows[j][0].ToString())) { found = 1; }
                }
                if (found == 1)
                {
                    MessageBox.Show("This name already exists . .");
                }
                else
                {
                    int add = ClassLocation.sp_addcountry(txtname.Text);
                    txtname.Text = "";
                    MessageBox.Show("Done");
                }
            }
        }
    }
}

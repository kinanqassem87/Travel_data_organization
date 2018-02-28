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
    public partial class FRM_ChangPassword : Form
    {
        public FRM_ChangPassword()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCurrent.Text.Equals("") || txtNew.Text.Equals("") || txtConfirm.Text.Equals(""))
            {
                MessageBox.Show("Please Fill All Fields");
            }
            else
            {
                if (txtCurrent.Text == FRM_Main.U_Password && txtNew.Text == txtConfirm.Text)
                {
                    int i = ClassUsers.sp_changepassword(txtNew.Text, int.Parse(FRM_Main.u_id));
                    FRM_Main.U_Password = txtNew.Text;
                    MessageBox.Show("Done");
                    txtConfirm.Text = txtCurrent.Text = txtNew.Text = "";
                    Close();
                }
                else
                {
                    MessageBox.Show("Wrong Data");
                }
            }
        }
    }
}

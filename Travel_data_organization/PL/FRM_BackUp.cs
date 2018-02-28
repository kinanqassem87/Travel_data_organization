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
    public partial class FRM_BackUp : Form
    {
        public FRM_BackUp()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fd = new FolderBrowserDialog();
                fd.ShowDialog();
                txtPath.Text = fd.SelectedPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                string path = string.Format("{0}\\TravelData-{1}{2}.bak", txtPath.Text, DateTime.Now.ToShortDateString().Replace('/', '-'),
                    DateTime.Now.ToShortTimeString().Replace(':', '-'));
                //string path = txtPath.Text + "\\Pharmacy_DB " , DateTime.Now.ToShortDateString().Replace('/', '-') ,
                //    DateTime.Now.ToShortTimeString().Replace(':', '-') + ".bak";
                ClassSetting.Back_up(path);
                MessageBox.Show("تم اخذ نسخة احتياطية");
                //string.Format(txtPath.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("يرجى التخزين على قرص اخر مختلف عن قرص النظام ");
            }
        }
    }
}

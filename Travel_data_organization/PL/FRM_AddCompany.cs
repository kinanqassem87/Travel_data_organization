using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Travel_data_organization.BL;
using System.IO;

namespace Travel_data_organization.PL
{
    public partial class FRM_AddCompany : Form
    {
        int NumOfImage = 0;
        List<byte[]> images = new List<byte[]>();

        int NumOfImageBC = 0;
        List<byte[]> imagesBC = new List<byte[]>();
        

        public FRM_AddCompany()
        {
            InitializeComponent();
            fillCountry();
            fillCity();
            
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void fillCountry() 
        {
            DataTable dt = ClassLocation.sp_selectAllCountry();
            cmbCountry.DataSource = dt;
            cmbCountry.DisplayMember = "country_name";
            cmbCountry.ValueMember = "country_id";
        }
        
        void fillCity()
        {
            try
            {
                DataTable dt = ClassSetting.sp_selectCityOfCountry((int)cmbCountry.SelectedValue);
                cmbCity.DataSource = dt;
                cmbCity.DisplayMember = "city_name";
                cmbCity.ValueMember = "city_id";
            }
            catch (Exception) { }
            
        }
        
        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillCity();
        }

        private void btnSelectImG_Click(object sender, EventArgs e)
        {
            try
            {
                PictureBox img = new PictureBox();
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Please Select Images";
              //  ofd.Multiselect = true;
                ofd.Filter = "JPG|*.jpg|JPEG|*.jpeg|GIF|*.gif|PNG|*.png";
                DialogResult dr = ofd.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string[] files = ofd.FileNames;
                    foreach (string fileName in files)
                    {
                        img.Image = Image.FromFile(ofd.FileName);

                        MemoryStream ms = new MemoryStream();
                        img.Image.Save(ms, img.Image.RawFormat);
                        byte[] arr = ms.ToArray();
                        images.Add(arr);

                        NumOfImage++;
                    }
                }
                lbIMG.Text = NumOfImage.ToString();
            }
            catch (Exception) { MessageBox.Show("Wrong with Selected Image..\n Image Not Selected"); }
        }

        private void btnSelectBC_Click(object sender, EventArgs e)
        {
            try
            {
                PictureBox img = new PictureBox();
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Please Select Images";
              //  ofd.Multiselect = true;
                ofd.Filter = "JPG|*.jpg|JPEG|*.jpeg|GIF|*.gif|PNG|*.png";
                DialogResult dr = ofd.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    string[] files = ofd.FileNames;
                    foreach (string fileName in files)
                    {
                        img.Image = Image.FromFile(ofd.FileName);

                        MemoryStream ms = new MemoryStream();
                        img.Image.Save(ms, img.Image.RawFormat);
                        byte[] arr = ms.ToArray();
                        imagesBC.Add(arr);

                        NumOfImageBC++;
                    }
                }
                lbBC.Text = NumOfImageBC.ToString();
            }
            catch (Exception) { MessageBox.Show("Wrong with Selected Image..\n Image Not Selected!!!!!  Please Try Rename Image ....."); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int found = 0;

            btnSave.Enabled = false;
            if (txtCompName.Text.Equals(""))
            {
                MessageBox.Show("Please Insert Company Name !");
            }
            else
            {
                DataTable dt = ClassSetting.searchCompanyByName(txtCompName.Text);
                for (int j = 0; j < dt.Rows.Count; j++) 
                {
                    if (txtCompName.Text.Equals(dt.Rows[j][0].ToString())) { found = 1; }
                }
                if (found == 1)
                {
                    MessageBox.Show("This name already exists . .");
                }
                else
                {

                    int addcom = ClassSetting.sp_Addcompany(txtCompName.Text, (int)cmbCity.SelectedValue, (int)cmbCountry.SelectedValue);
                    DataTable LastComp = ClassSetting.sp_selectTopCompany();

                    for (int i = 0; i < images.Count; i++)
                    {
                        int addIMG = ClassSetting.sp_AddcompanyIMG(images[i], int.Parse(LastComp.Rows[0][0].ToString()));
                    }
                    for (int i = 0; i < imagesBC.Count; i++)
                    {
                        int addIMGBC = ClassSetting.sp_AddcompanyBCard(imagesBC[i], int.Parse(LastComp.Rows[0][0].ToString()));
                    }
                    MessageBox.Show("Done");
                    txtCompName.Text = "";
                    images.Clear();
                    imagesBC.Clear();
                    lbBC.Text = lbIMG.Text = "?";
                    NumOfImage = NumOfImageBC = 0;
                }
                
            }
            btnSave.Enabled = true;
        }
    }
}

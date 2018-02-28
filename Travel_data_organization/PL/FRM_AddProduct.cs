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
    public partial class FRM_AddProduct : Form
    {
        int NumOfImage = 0;
        List<byte[]> images = new List<byte[]>();

        public FRM_AddProduct()
        {
            InitializeComponent();
            DataTable dtCat = ClassSetting.sp_allCategory();
            cmbCategory.DataSource = dtCat;
            cmbCategory.DisplayMember = "catogary_name";
            cmbCategory.ValueMember = "catogary_id";

            DataTable dttype = ClassSetting.sp_allTypys();
            cmbType.DataSource = dttype;
            cmbType.DisplayMember = "typePro_name";
            cmbType.ValueMember = "typePro_id";

            DataTable dtcolor = ClassSetting.sp_allColors();
            cmbColor.DataSource = dtcolor;
            cmbColor.DisplayMember = "colorPro_name";
            cmbColor.ValueMember = "colorPro_id";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                PictureBox img = new PictureBox();
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Please Select Images";
               // ofd.Multiselect = true;
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
                LbNumOfImg.Text = NumOfImage.ToString();
            }
            catch (Exception) { MessageBox.Show("Wrong with Selected Image..\n Image Not Selected"); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int found = 0;
            btnSave.Enabled = false;
            if (txtname.Text.Equals(""))
            {
                MessageBox.Show("Insert Product Name Please.");
            }
            else 
            {
                DataTable dt = ClassSetting.searchProductsByName(txtname.Text);
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
                     int AddPro = ClassSetting.sp_addProduct(txtname.Text, txtBarcode.Text, (int)cmbCategory.SelectedValue, (int)cmbColor.SelectedValue, (int)cmbType.SelectedValue);
                     DataTable lastPro = ClassSetting.sp_lastProID();
                     for (int i = 0; i < images.Count; i++)
                     {
                         int ProImage = ClassSetting.sp_imgageProduct(images[i], int.Parse(lastPro.Rows[0][0].ToString()));
                     }
                     txtname.Text = txtBarcode.Text = "";
                     LbNumOfImg.Text = "0";
                     images.Clear();
                     NumOfImage = 0;
                     MessageBox.Show("Done");
                 }
            }
            btnSave.Enabled = true;
        }
    }
}

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
    public partial class FRM_ProductImageView : Form
    {
        string ProID;
        int numOfImag = 0;
        int counter = 1;
        DataTable dt = new DataTable();
        byte[] arr;

        public FRM_ProductImageView(string s)
        {
            InitializeComponent();
            ProID = s;
            dt = ClassSetting.SelectImageOnePro(int.Parse(s));
            numOfImag = dt.Rows.Count;
            try
            {
                txtIMGid.Text = dt.Rows[0][0].ToString();
                byte[] arr = (byte[])(dt.Rows[0][1]);
                MemoryStream ms = new MemoryStream(arr);
                picImage.Image = Image.FromStream(ms);
            }
            catch (Exception) { MessageBox.Show("No Image Found !!!"); }
        }

        private void btnNextIMG_Click(object sender, EventArgs e)
        {
            if (numOfImag > 0)
            {
                try
                {
                    txtIMGid.Text = dt.Rows[counter][0].ToString();
                    byte[] arr = (byte[])(dt.Rows[counter][1]);
                    MemoryStream ms = new MemoryStream(arr);
                    picImage.Image = Image.FromStream(ms);
                    counter++;
                }
                catch (Exception)
                {
                    txtIMGid.Text = dt.Rows[0][0].ToString();
                    byte[] arr = (byte[])(dt.Rows[0][1]);
                    MemoryStream ms = new MemoryStream(arr);
                    picImage.Image = Image.FromStream(ms);
                    counter = 1;
                }
            }
        }

        private void btnFirstIMG_Click(object sender, EventArgs e)
        {
            if (numOfImag > 0)
            {
                txtIMGid.Text = dt.Rows[0][0].ToString();
                byte[] arr = (byte[])(dt.Rows[0][1]);
                MemoryStream ms = new MemoryStream(arr);
                picImage.Image = Image.FromStream(ms);
                counter = 1;
            }
        }

        private void btnSelectOne_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Please Select Images";
                ofd.Filter = "JPG|*.jpg|JPEG|*.jpeg|GIF|*.gif|PNG|*.png";
                DialogResult dr = ofd.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    picImage.Image = Image.FromFile(ofd.FileName);

                    MemoryStream ms = new MemoryStream();
                    picImage.Image.Save(ms, picImage.Image.RawFormat);
                    arr = ms.ToArray();

                    txtIMGid.Text = "";

                }

            }
            catch (Exception) { MessageBox.Show("Wrong with Selected Image..\n Image Not Selected"); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIMGid.Text.Equals("") && picImage.Image != null)
                {
                    int addIMG = ClassSetting.sp_imgageProduct(arr, int.Parse(ProID));
                    dt = ClassSetting.SelectImageOnePro(int.Parse(ProID));
                    
                    MessageBox.Show("Done . .");
                    numOfImag = dt.Rows.Count;
                    btnFirstIMG_Click(null, null);
                }

            }
            catch (Exception) { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtIMGid.Text.Equals(""))
            {
                picImage.Image = null;
            }
            else
            {
                    int delImage = ClassSetting.deleteProImage(int.Parse(txtIMGid.Text));
                    dt = ClassSetting.SelectImageOnePro(int.Parse(ProID));
                
                MessageBox.Show("Done . .");
                txtIMGid.Text = "";
                picImage.Image = null;
            }
            numOfImag = dt.Rows.Count;
            btnFirstIMG_Click(null, null);
        }
    }
}

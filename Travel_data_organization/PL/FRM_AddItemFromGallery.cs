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
    public partial class FRM_AddItemFromGallery : Form
    {
        int cat_id = 0; int color_id = 0; int type_id = 0;

        int NumOfCatalog = 0;
        int NumOfBill = 0;
        int NumOfQuotation = 0;

        List<byte[]> CatalogIMG = new List<byte[]>();
        List<byte[]> BillIMG = new List<byte[]>();
        List<byte[]> QuotationIMG = new List<byte[]>();

        int isbill = 0;
        int isQuot = 0;

        public FRM_AddItemFromGallery()
        {
            InitializeComponent();
            fillCountry();
            fillCity();
            fillCompany();
            fillProduct();
        }

        void fillCountry() 
        {
            DataTable dt = ClassLocation.sp_selectAllCountry();
            cmbCountry.DataSource = dt;
            cmbCountry.DisplayMember = "country_name";
            cmbCountry.ValueMember = "country_id";
        }

        void fillCompany() 
        {
            try
            {
                DataTable dt = ClassSetting.selectComOfCity((int)cmbCity.SelectedValue, (int)cmbCountry.SelectedValue);
                cmbCompany.DataSource = dt;
                cmbCompany.DisplayMember = "company_name";
                cmbCompany.ValueMember = "company_id";
            }
            catch (Exception) { }
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

        void fillProduct() 
        {
            try
            {
                DataTable dt = ClassSetting.selectAllProduct();
                cmbProduct.DataSource = dt;
                cmbProduct.DisplayMember = "product_name";
                cmbProduct.ValueMember = "Product_id";
                cat_id = int.Parse(dt.Rows[0][4].ToString());
                color_id = int.Parse(dt.Rows[0][5].ToString());
                type_id = int.Parse(dt.Rows[0][6].ToString());
            }
            catch (Exception) { }
        }
        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillCity();
            fillCompany();
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillCompany();
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = ClassSetting.selectProductDeatail((int)cmbProduct.SelectedValue);
                txtColor.Text = dt.Rows[0][3].ToString();
                txtType.Text = dt.Rows[0][4].ToString();
                cat_id = int.Parse(dt.Rows[0][0].ToString());
                color_id = int.Parse(dt.Rows[0][1].ToString());
                type_id = int.Parse(dt.Rows[0][2].ToString());
            }
            catch (Exception) { }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCatalog_Click(object sender, EventArgs e)
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
                        CatalogIMG.Add(arr);

                        NumOfCatalog++;
                    }
                }
                lbCatalog.Text = NumOfCatalog.ToString();
            }
            catch (Exception) { MessageBox.Show("Wrong with Selected Image..\n Image Not Selected"); }
        }

        private void btnBill_Click(object sender, EventArgs e)
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
                        BillIMG.Add(arr);

                        NumOfBill++;
                    }
                }
                lbBill.Text = NumOfBill.ToString();
            }
            catch (Exception) { MessageBox.Show("Wrong with Selected Image..\n Image Not Selected"); }
        }

        private void btnQuotation_Click(object sender, EventArgs e)
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
                        QuotationIMG.Add(arr);

                        NumOfQuotation++;
                    }
                }
                lbQuotation.Text = NumOfQuotation.ToString();
            }
            catch (Exception) { MessageBox.Show("Wrong with Selected Image..\n Image Not Selected"); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (cmbCountry.Text.Equals("") || cmbCity.Text.Equals("") || cmbCompany.Equals("") || txtYear.Text.Equals("") || cmbProduct.Text.Equals("")||txtColor.Text.Equals(""))
            {
                MessageBox.Show("Data not completed..."); 
            }
            else 
            {
                btnSave.Enabled = false;
                string billS = "";
                string QuotS = "";
                isbill = NumOfBill;
                isQuot = NumOfQuotation;
                if (isbill != 0) { billS = "B_True"; } else { billS = "B_False"; }
                if (isQuot != 0) { QuotS = "Q_True"; } else { QuotS = "Q_False"; }

                //************************************

                int addtogal = ClassSetting.sp_AddToGallery(txtYear.Text, txtSeason.Text, billS, QuotS);
                DataTable lastGal = ClassSetting.selectlastGal();
                int addtoDet = ClassSetting.AddtoGalDetails(cat_id, (int)cmbProduct.SelectedValue, (int)cmbCompany.SelectedValue, color_id, type_id, int.Parse(lastGal.Rows[0][0].ToString()),(int)cmbCountry.SelectedValue,(int)cmbCity.SelectedValue);
                
                //************************************

                for (int iCat = 0; iCat < CatalogIMG.Count; iCat++)
                {
                    int addtocat = ClassSetting.AddtoCataloge(CatalogIMG[iCat], int.Parse(lastGal.Rows[0][0].ToString()));
                }
                
                //****************************************

                int addBill = ClassSetting.addbill(dtpBill.Value, int.Parse(lastGal.Rows[0][0].ToString()));
                DataTable lastBill = ClassSetting.selectLastBill();

                for (int ibill = 0; ibill < BillIMG.Count; ibill++) 
                {
                    int addBillDet = ClassSetting.addtoBillDetails(BillIMG[ibill], int.Parse(lastBill.Rows[0][0].ToString()));
                }
                
                //******************************************

                int addQuot = ClassSetting.AddQuot(dtpQuotation.Value, int.Parse(lastGal.Rows[0][0].ToString()));
                DataTable lastQuot = ClassSetting.selectLastQuot();

                for (int iQuot = 0; iQuot < QuotationIMG.Count; iQuot++) 
                {
                    int addQuotDet = ClassSetting.addtoQuotDetails(QuotationIMG[iQuot], int.Parse(lastQuot.Rows[0][0].ToString()));
                }

                //*****************************************

                MessageBox.Show("Done..");
                txtYear.Text = txtSeason.Text = txtColor.Text = txtType.Text = "";
                CatalogIMG.Clear();
                BillIMG.Clear();
                QuotationIMG.Clear();
                lbCatalog.Text = lbBill.Text = lbQuotation.Text = "0";
                NumOfCatalog = NumOfBill = NumOfQuotation = 0;
                btnSave.Enabled = true;
            }
        }

        

        
    }
}

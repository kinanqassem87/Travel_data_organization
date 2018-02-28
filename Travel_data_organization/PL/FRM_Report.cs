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
    public partial class FRM_Report : Form
    {
        int GalDetID;
        int Gal_id, Product_ID, company_id;
        DataTable proImg = new DataTable();
        DataTable comIMG = new DataTable();
        DataTable comBC = new DataTable();
        DataTable catalog = new DataTable();

        DataTable billIMG = new DataTable();
        DataTable QuotIMG = new DataTable();

        int picN1 = 1;
        int picN2 = 1;
        int picP1 = 0;
        int picP2 = 0;


        string pic1State = "";
        string pic2State = "";


        public FRM_Report()
        {
            InitializeComponent();
            displayData();

        }
        void displayData()
        {
            DataTable dt = ClassReport.SelectAllDetails();
            dgvDetaila.DataSource = dt;
        }

        private void dgvDetaila_DoubleClick(object sender, EventArgs e)
        {
            GalDetID = int.Parse(dgvDetaila.CurrentRow.Cells[0].Value.ToString());
            txtProduct.Text = dgvDetaila.CurrentRow.Cells[6].Value.ToString();
            txtCompany.Text = dgvDetaila.CurrentRow.Cells[7].Value.ToString();

            DataTable dt = ClassReport.selectIMGDet(GalDetID);
            Gal_id = int.Parse(dt.Rows[0][0].ToString());
            Product_ID = int.Parse(dt.Rows[0][1].ToString());
            company_id = int.Parse(dt.Rows[0][2].ToString());

            proImg = ClassReport.selectProIMG(Product_ID);
            comIMG = ClassReport.selectComIMG(company_id);
            comBC = ClassReport.selectBCIMG(company_id);
            catalog = ClassReport.selectCatalogIMG(Gal_id);

            billIMG = ClassReport.selectBillIMG(Gal_id);
            QuotIMG = ClassReport.selectQuotIMG(Gal_id);

            picN1 = picN2 = 1;
            picP1 = picP2 = 0;
            pic1State = pic2State = "";

            txtDate.Text = "";
           // picBox2.Visible = false;
           // picBox1.Visible = false;
            picBox1.Image = picBox2.Image = null;
        }

        private void btnProIMG_Click(object sender, EventArgs e)
        {
            pic1State = "Pro";
            picN1 = 1;
            picP1 = 0;
         //   picBox1.Visible = true;
            try
            {
                byte[] arr = (byte[])(proImg.Rows[0][0]);
                MemoryStream ms = new MemoryStream(arr);
                picBox1.Image = Image.FromStream(ms);
            }
            catch (Exception) { MessageBox.Show("Select one Please with Images !"); }
        }

        private void btnCompIMG_Click(object sender, EventArgs e)
        {
            pic1State = "Com";
            picN1 = 1;
            picP1 = 0;
          //  picBox1.Visible = true;
            try
            {
                byte[] arr = (byte[])(comIMG.Rows[0][0]);
                MemoryStream ms = new MemoryStream(arr);
                picBox1.Image = Image.FromStream(ms);
            }
            catch (Exception) { MessageBox.Show("Select one Please with Images !"); }
        }

        private void btnBCIMG_Click(object sender, EventArgs e)
        {
            pic1State = "BC";
            picN1 = 1;
            picP1 = 0;
          //  picBox1.Visible = true;
            try
            {
                byte[] arr = (byte[])(comBC.Rows[0][0]);
                MemoryStream ms = new MemoryStream(arr);
                picBox1.Image = Image.FromStream(ms);
            }
            catch (Exception) { MessageBox.Show("Select one Please with Images !"); }
        }

        private void btnCatIMG_Click(object sender, EventArgs e)
        {
            pic1State = "Cat";
            picN1 = 1;
            picP1 = 0;
        //    picBox1.Visible = true;
            try
            {
                byte[] arr = (byte[])(catalog.Rows[0][0]);
                MemoryStream ms = new MemoryStream(arr);
                picBox1.Image = Image.FromStream(ms);
            }
            catch (Exception) { MessageBox.Show("Select one Please with Images !"); }
        }

        private void btnBillIMG_Click(object sender, EventArgs e)
        {
            pic2State = "Bill";
            picN2 = 1;
            picP2 = 0;
          //  picBox2.Visible = true;
            try
            {
                byte[] arr = (byte[])(billIMG.Rows[0][0]);
                MemoryStream ms = new MemoryStream(arr);
                picBox2.Image = Image.FromStream(ms);
                txtDate.Text = billIMG.Rows[0][1].ToString();
            }
            catch (Exception) { MessageBox.Show("Select one Please with Images !"); }
        }

        private void btnQuotIMG_Click(object sender, EventArgs e)
        {
            pic2State = "Quot";
            picN2 = 1;
            picP2 = 0;
         //   picBox2.Visible = true;
            try
            {
                byte[] arr = (byte[])(QuotIMG.Rows[0][0]);
                MemoryStream ms = new MemoryStream(arr);
                picBox2.Image = Image.FromStream(ms);
                txtDate.Text = QuotIMG.Rows[0][1].ToString();
            }
            catch (Exception) { MessageBox.Show("Select one Please with Images !"); }
        }

        //**********************************************************************************
        //**********************************************************************************

        private void btnNext1_Click(object sender, EventArgs e)
        {

            if (pic1State.Equals("Pro") && picN1 < proImg.Rows.Count)
            {
                try
                {

                    byte[] arr = (byte[])(proImg.Rows[picN1][0]);
                    MemoryStream ms = new MemoryStream(arr);
                    picBox1.Image = Image.FromStream(ms);
                    picN1++; picP1++;
                }
                catch (Exception) { MessageBox.Show("Select one Please with Images !"); }
            }
            else if (pic1State.Equals("Com") && picN1 < comIMG.Rows.Count)
            {
                try
                {

                    byte[] arr = (byte[])(comIMG.Rows[picN1][0]);
                    MemoryStream ms = new MemoryStream(arr);
                    picBox1.Image = Image.FromStream(ms);
                    picN1++; picP1++;
                }
                catch (Exception) { MessageBox.Show("Select one Please with Images !"); }
            }
            else if (pic1State.Equals("BC") && picN1 < comBC.Rows.Count)
            {
                try
                {

                    byte[] arr = (byte[])(comBC.Rows[picN1][0]);
                    MemoryStream ms = new MemoryStream(arr);
                    picBox1.Image = Image.FromStream(ms);
                    picN1++; picP1++;
                }
                catch (Exception) { MessageBox.Show("Select one Please with Images !"); }
            }
            else if (pic1State.Equals("Cat") && picN1 < catalog.Rows.Count)
            {
                try
                {

                    byte[] arr = (byte[])(catalog.Rows[picN1][0]);
                    MemoryStream ms = new MemoryStream(arr);
                    picBox1.Image = Image.FromStream(ms);
                    picN1++; picP1++;
                }
                catch (Exception) { MessageBox.Show("Select one Please with Images !"); }
            }
            else { MessageBox.Show("No More Image"); }

        }

        //***********************************************************
        //************************************************************

        private void btnPrev1_Click(object sender, EventArgs e)
        {

            if (pic1State.Equals("Pro") && picP1 >= 0)
            {
                try
                {

                    byte[] arr = (byte[])(proImg.Rows[picP1][0]);
                    MemoryStream ms = new MemoryStream(arr);
                    picBox1.Image = Image.FromStream(ms);
                    picP1--; picN1--;
                }
                catch (Exception) { MessageBox.Show("Select one Please with Images !"); }
            }
            else if (pic1State.Equals("Com") && picP1 >= 0)
            {
                try
                {

                    byte[] arr = (byte[])(comIMG.Rows[picP1][0]);
                    MemoryStream ms = new MemoryStream(arr);
                    picBox1.Image = Image.FromStream(ms);
                    picP1--; picN1--;
                }
                catch (Exception) { MessageBox.Show("Select one Please with Images !"); }
            }
            else if (pic1State.Equals("BC") && picP1 >= 0)
            {
                try
                {

                    byte[] arr = (byte[])(comBC.Rows[picP1][0]);
                    MemoryStream ms = new MemoryStream(arr);
                    picBox1.Image = Image.FromStream(ms);
                    picP1--; picN1--;
                }
                catch (Exception) { MessageBox.Show("Select one Please with Images !"); }
            }
            else if (pic1State.Equals("Cat") && picP1 >= 0)
            {
                try
                {

                    byte[] arr = (byte[])(catalog.Rows[picP1][0]);
                    MemoryStream ms = new MemoryStream(arr);
                    picBox1.Image = Image.FromStream(ms);
                    picP1--; picN1--;
                }
                catch (Exception) { MessageBox.Show("Select one Please with Images !"); }
            }
            else { MessageBox.Show("No More Image"); }

        }

        //************************************************************
        //************************************************************


        private void btnNext2_Click(object sender, EventArgs e)
        {
            if (pic2State.Equals("Bill") && picN2 < billIMG.Rows.Count)
            {
                try
                {

                    byte[] arr = (byte[])(billIMG.Rows[picN2][0]);
                    MemoryStream ms = new MemoryStream(arr);
                    picBox2.Image = Image.FromStream(ms);
                    picN2++; picP2++;
                }
                catch (Exception) { MessageBox.Show("Select one Please with Images !"); }
            }
            else if (pic2State.Equals("Quot") && picN2 < QuotIMG.Rows.Count)
            {
                try
                {

                    byte[] arr = (byte[])(QuotIMG.Rows[picN2][0]);
                    MemoryStream ms = new MemoryStream(arr);
                    picBox2.Image = Image.FromStream(ms);
                    picN2++; picP2++;
                }
                catch (Exception) { MessageBox.Show("Select one Please with Images !"); }
            }
            else { MessageBox.Show("No More Image"); }
        }

        //*****************************************************************
        //*****************************************************************

        private void btnPrev2_Click(object sender, EventArgs e)
        {
            if (pic2State.Equals("Bill") && picP2 >= 0)
            {
                try
                {

                    byte[] arr = (byte[])(billIMG.Rows[picP2][0]);
                    MemoryStream ms = new MemoryStream(arr);
                    picBox2.Image = Image.FromStream(ms);
                    picP2--; picN2--;
                }
                catch (Exception) { MessageBox.Show("Select one Please with Images !"); }
            }
            else if (pic2State.Equals("Quot") && picP2 >= 0)
            {
                try
                {

                    byte[] arr = (byte[])(QuotIMG.Rows[picP2][0]);
                    MemoryStream ms = new MemoryStream(arr);
                    picBox2.Image = Image.FromStream(ms);
                    picP2--; picN2--;
                }
                catch (Exception) { MessageBox.Show("Select one Please with Images !"); }
            }
            else { MessageBox.Show("No More Image"); }
        }

        private void btnExport1_Click(object sender, EventArgs e)
        {
            if (picBox1.Image == null) { MessageBox.Show("No Image Selected !!."); }
            else
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                // saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif"; 
                saveFileDialog1.Filter = "JPG|*.jpg|JPEG|*.jpeg|GIF|*.gif|PNG|*.png";
                saveFileDialog1.Title = "Save an Image File";
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName != "")
                {
                    // Saves the Image via a FileStream created by the OpenFile method.  
                    
                    System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                    picBox1.Image.Save(fs, picBox1.Image.RawFormat);


                    // Saves the Image in the appropriate ImageFormat based upon the  
                    // File type selected in the dialog box.  
                    // NOTE that the FilterIndex property is one-based.  
                    //switch (saveFileDialog1.FilterIndex)
                    //{
                    //    case 1:
                    //        this.button2.Image.Save(fs,
                    //           System.Drawing.Imaging.ImageFormat.Jpeg);
                    //        break;

                    //    case 2:
                    //        this.button2.Image.Save(fs,
                    //           System.Drawing.Imaging.ImageFormat.Bmp);
                    //        break;

                    //    case 3:
                    //        this.button2.Image.Save(fs,
                    //           System.Drawing.Imaging.ImageFormat.Gif);
                    //        break;
                    //}
                }

            }
        }

        private void btnExport2_Click(object sender, EventArgs e)
        {
            if (picBox2.Image == null) { MessageBox.Show("No Image Selected !!."); }
            else
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                // saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif"; 
                saveFileDialog1.Filter = "JPG|*.jpg|JPEG|*.jpeg|GIF|*.gif|PNG|*.png";
                saveFileDialog1.Title = "Save an Image File";
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName != "")
                {
                    // Saves the Image via a FileStream created by the OpenFile method.  

                    System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                    picBox2.Image.Save(fs, picBox2.Image.RawFormat);


                    // Saves the Image in the appropriate ImageFormat based upon the  
                    // File type selected in the dialog box.  
                    // NOTE that the FilterIndex property is one-based.  
                    //switch (saveFileDialog1.FilterIndex)
                    //{
                    //    case 1:
                    //        this.button2.Image.Save(fs,
                    //           System.Drawing.Imaging.ImageFormat.Jpeg);
                    //        break;

                    //    case 2:
                    //        this.button2.Image.Save(fs,
                    //           System.Drawing.Imaging.ImageFormat.Bmp);
                    //        break;

                    //    case 3:
                    //        this.button2.Image.Save(fs,
                    //           System.Drawing.Imaging.ImageFormat.Gif);
                    //        break;
                    //}
                }

            }
        }

        //************************
        //************************

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvDetaila.DataSource = ClassReport.SearchInAllDetails(txtSearch.Text);
        }

        private void picBox1_DoubleClick(object sender, EventArgs e)
        {
            FRM_Pic1Zoom a = new FRM_Pic1Zoom(picBox1.Image);
            a.ShowDialog();
        }

        private void picBox2_DoubleClick(object sender, EventArgs e)
        {
            FRM_Pic1Zoom a = new FRM_Pic1Zoom(picBox2.Image);
            a.ShowDialog();
        }

//************************


    }
}

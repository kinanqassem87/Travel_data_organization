namespace Travel_data_organization.PL
{
    partial class FRM_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsSignIN = new System.Windows.Forms.ToolStripMenuItem();
            this.tsIN = new System.Windows.Forms.ToolStripMenuItem();
            this.tsOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.TSChangePass = new System.Windows.Forms.ToolStripMenuItem();
            this.tsReport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAddcountry = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsAddCity = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAddCompany = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsAddCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsAddType = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsAddColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsAddProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsAddNewDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsManagment = new System.Windows.Forms.ToolStripMenuItem();
            this.companyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyBCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.productManagmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.categoryManagmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.counrtyManagmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cityManagmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.typeManagmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorManagmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.backupDataBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSignIN,
            this.tsReport,
            this.tsLocation,
            this.tsSetting,
            this.tsManagment,
            this.tsAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1328, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsSignIN
            // 
            this.tsSignIN.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsIN,
            this.tsOut,
            this.toolStripSeparator7,
            this.TSChangePass,
            this.backupDataBaseToolStripMenuItem});
            this.tsSignIN.Name = "tsSignIN";
            this.tsSignIN.Size = new System.Drawing.Size(55, 20);
            this.tsSignIN.Text = "Sign In";
            // 
            // tsIN
            // 
            this.tsIN.Name = "tsIN";
            this.tsIN.Size = new System.Drawing.Size(168, 22);
            this.tsIN.Text = "Sign in";
            this.tsIN.Click += new System.EventHandler(this.tsIN_Click);
            // 
            // tsOut
            // 
            this.tsOut.Enabled = false;
            this.tsOut.Name = "tsOut";
            this.tsOut.Size = new System.Drawing.Size(168, 22);
            this.tsOut.Text = "Sign out";
            this.tsOut.Click += new System.EventHandler(this.tsOut_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(165, 6);
            // 
            // TSChangePass
            // 
            this.TSChangePass.Enabled = false;
            this.TSChangePass.Name = "TSChangePass";
            this.TSChangePass.Size = new System.Drawing.Size(168, 22);
            this.TSChangePass.Text = "Change Password";
            this.TSChangePass.Click += new System.EventHandler(this.TSChangePass_Click);
            // 
            // tsReport
            // 
            this.tsReport.Enabled = false;
            this.tsReport.Name = "tsReport";
            this.tsReport.Size = new System.Drawing.Size(54, 20);
            this.tsReport.Text = "Report";
            this.tsReport.Click += new System.EventHandler(this.tsReport_Click);
            // 
            // tsLocation
            // 
            this.tsLocation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAddcountry,
            this.toolStripSeparator1,
            this.tsAddCity});
            this.tsLocation.Enabled = false;
            this.tsLocation.Name = "tsLocation";
            this.tsLocation.Size = new System.Drawing.Size(65, 20);
            this.tsLocation.Text = "Location";
            // 
            // tsAddcountry
            // 
            this.tsAddcountry.Name = "tsAddcountry";
            this.tsAddcountry.Size = new System.Drawing.Size(142, 22);
            this.tsAddcountry.Text = "Add Country";
            this.tsAddcountry.Click += new System.EventHandler(this.tsAddcountry_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(139, 6);
            // 
            // tsAddCity
            // 
            this.tsAddCity.Name = "tsAddCity";
            this.tsAddCity.Size = new System.Drawing.Size(142, 22);
            this.tsAddCity.Text = "Add City";
            this.tsAddCity.Click += new System.EventHandler(this.tsAddCity_Click);
            // 
            // tsSetting
            // 
            this.tsSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAddCompany,
            this.toolStripSeparator3,
            this.tsAddCategory,
            this.toolStripSeparator2,
            this.tsAddType,
            this.toolStripSeparator4,
            this.tsAddColor,
            this.toolStripSeparator5,
            this.tsAddProduct,
            this.toolStripSeparator6,
            this.tsAddNewDetails});
            this.tsSetting.Enabled = false;
            this.tsSetting.Name = "tsSetting";
            this.tsSetting.Size = new System.Drawing.Size(56, 20);
            this.tsSetting.Text = "Setting";
            // 
            // tsAddCompany
            // 
            this.tsAddCompany.Name = "tsAddCompany";
            this.tsAddCompany.Size = new System.Drawing.Size(161, 22);
            this.tsAddCompany.Text = "Add Company";
            this.tsAddCompany.Click += new System.EventHandler(this.tsAddCompany_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(158, 6);
            // 
            // tsAddCategory
            // 
            this.tsAddCategory.Name = "tsAddCategory";
            this.tsAddCategory.Size = new System.Drawing.Size(161, 22);
            this.tsAddCategory.Text = "Add Category";
            this.tsAddCategory.Click += new System.EventHandler(this.tsAddCategory_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(158, 6);
            // 
            // tsAddType
            // 
            this.tsAddType.Name = "tsAddType";
            this.tsAddType.Size = new System.Drawing.Size(161, 22);
            this.tsAddType.Text = "Add Type";
            this.tsAddType.Click += new System.EventHandler(this.tsAddType_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(158, 6);
            // 
            // tsAddColor
            // 
            this.tsAddColor.Name = "tsAddColor";
            this.tsAddColor.Size = new System.Drawing.Size(161, 22);
            this.tsAddColor.Text = "Add Color";
            this.tsAddColor.Click += new System.EventHandler(this.tsAddColor_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(158, 6);
            // 
            // tsAddProduct
            // 
            this.tsAddProduct.Name = "tsAddProduct";
            this.tsAddProduct.Size = new System.Drawing.Size(161, 22);
            this.tsAddProduct.Text = "Add Product";
            this.tsAddProduct.Click += new System.EventHandler(this.tsAddProduct_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(158, 6);
            // 
            // tsAddNewDetails
            // 
            this.tsAddNewDetails.Name = "tsAddNewDetails";
            this.tsAddNewDetails.Size = new System.Drawing.Size(161, 22);
            this.tsAddNewDetails.Text = "Add New Details";
            this.tsAddNewDetails.Click += new System.EventHandler(this.tsAddNewDetails_Click);
            // 
            // tsManagment
            // 
            this.tsManagment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.companyToolStripMenuItem,
            this.toolStripSeparator10,
            this.productManagmentToolStripMenuItem,
            this.toolStripSeparator9,
            this.categoryManagmentToolStripMenuItem,
            this.toolStripSeparator8,
            this.counrtyManagmentToolStripMenuItem,
            this.cityManagmentToolStripMenuItem,
            this.toolStripSeparator11,
            this.typeManagmentToolStripMenuItem,
            this.colorManagmentToolStripMenuItem});
            this.tsManagment.Enabled = false;
            this.tsManagment.Name = "tsManagment";
            this.tsManagment.Size = new System.Drawing.Size(84, 20);
            this.tsManagment.Text = "Managment";
            // 
            // companyToolStripMenuItem
            // 
            this.companyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.companyImageToolStripMenuItem,
            this.companyBCToolStripMenuItem});
            this.companyToolStripMenuItem.Name = "companyToolStripMenuItem";
            this.companyToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.companyToolStripMenuItem.Text = "Company Managment";
            // 
            // companyImageToolStripMenuItem
            // 
            this.companyImageToolStripMenuItem.Name = "companyImageToolStripMenuItem";
            this.companyImageToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.companyImageToolStripMenuItem.Text = "Company Image";
            this.companyImageToolStripMenuItem.Click += new System.EventHandler(this.companyImageToolStripMenuItem_Click);
            // 
            // companyBCToolStripMenuItem
            // 
            this.companyBCToolStripMenuItem.Name = "companyBCToolStripMenuItem";
            this.companyBCToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.companyBCToolStripMenuItem.Text = "Company B . C .";
            this.companyBCToolStripMenuItem.Click += new System.EventHandler(this.companyBCToolStripMenuItem_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(191, 6);
            // 
            // productManagmentToolStripMenuItem
            // 
            this.productManagmentToolStripMenuItem.Name = "productManagmentToolStripMenuItem";
            this.productManagmentToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.productManagmentToolStripMenuItem.Text = "Product Managment";
            this.productManagmentToolStripMenuItem.Click += new System.EventHandler(this.productManagmentToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(191, 6);
            // 
            // categoryManagmentToolStripMenuItem
            // 
            this.categoryManagmentToolStripMenuItem.Name = "categoryManagmentToolStripMenuItem";
            this.categoryManagmentToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.categoryManagmentToolStripMenuItem.Text = "Category Managment";
            this.categoryManagmentToolStripMenuItem.Click += new System.EventHandler(this.categoryManagmentToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(191, 6);
            // 
            // counrtyManagmentToolStripMenuItem
            // 
            this.counrtyManagmentToolStripMenuItem.Name = "counrtyManagmentToolStripMenuItem";
            this.counrtyManagmentToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.counrtyManagmentToolStripMenuItem.Text = "Counrty Managment";
            this.counrtyManagmentToolStripMenuItem.Click += new System.EventHandler(this.counrtyManagmentToolStripMenuItem_Click);
            // 
            // cityManagmentToolStripMenuItem
            // 
            this.cityManagmentToolStripMenuItem.Name = "cityManagmentToolStripMenuItem";
            this.cityManagmentToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.cityManagmentToolStripMenuItem.Text = "City Managment";
            this.cityManagmentToolStripMenuItem.Click += new System.EventHandler(this.cityManagmentToolStripMenuItem_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(191, 6);
            // 
            // typeManagmentToolStripMenuItem
            // 
            this.typeManagmentToolStripMenuItem.Name = "typeManagmentToolStripMenuItem";
            this.typeManagmentToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.typeManagmentToolStripMenuItem.Text = "Type Managment";
            this.typeManagmentToolStripMenuItem.Click += new System.EventHandler(this.typeManagmentToolStripMenuItem_Click);
            // 
            // colorManagmentToolStripMenuItem
            // 
            this.colorManagmentToolStripMenuItem.Name = "colorManagmentToolStripMenuItem";
            this.colorManagmentToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.colorManagmentToolStripMenuItem.Text = "Color Managment";
            this.colorManagmentToolStripMenuItem.Click += new System.EventHandler(this.colorManagmentToolStripMenuItem_Click);
            // 
            // tsAbout
            // 
            this.tsAbout.Name = "tsAbout";
            this.tsAbout.Size = new System.Drawing.Size(52, 20);
            this.tsAbout.Text = "About";
            this.tsAbout.Click += new System.EventHandler(this.tsAbout_Click);
            // 
            // backupDataBaseToolStripMenuItem
            // 
            this.backupDataBaseToolStripMenuItem.Enabled = false;
            this.backupDataBaseToolStripMenuItem.Name = "backupDataBaseToolStripMenuItem";
            this.backupDataBaseToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.backupDataBaseToolStripMenuItem.Text = "Backup Data";
            this.backupDataBaseToolStripMenuItem.Click += new System.EventHandler(this.backupDataBaseToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Travel_data_organization.Properties.Resources.AA;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1328, 722);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FRM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 746);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FRM_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Interface";
            this.Activated += new System.EventHandler(this.FRM_Main_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsSignIN;
        private System.Windows.Forms.ToolStripMenuItem tsIN;
        private System.Windows.Forms.ToolStripMenuItem tsOut;
        private System.Windows.Forms.ToolStripMenuItem TSChangePass;
        private System.Windows.Forms.ToolStripMenuItem tsReport;
        private System.Windows.Forms.ToolStripMenuItem tsLocation;
        private System.Windows.Forms.ToolStripMenuItem tsAddcountry;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsAddCity;
        private System.Windows.Forms.ToolStripMenuItem tsSetting;
        private System.Windows.Forms.ToolStripMenuItem tsAddCategory;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsAddProduct;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsAddType;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsAddColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tsAddCompany;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem tsAddNewDetails;
        private System.Windows.Forms.ToolStripMenuItem tsAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem tsManagment;
        private System.Windows.Forms.ToolStripMenuItem companyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyBCToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem productManagmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem categoryManagmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem counrtyManagmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cityManagmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem typeManagmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorManagmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupDataBaseToolStripMenuItem;
    }
}
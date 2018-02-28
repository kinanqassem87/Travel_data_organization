namespace Travel_data_organization.PL
{
    partial class FRM_Report
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDetaila = new System.Windows.Forms.DataGridView();
            this.btnProIMG = new System.Windows.Forms.Button();
            this.btnCompIMG = new System.Windows.Forms.Button();
            this.btnBCIMG = new System.Windows.Forms.Button();
            this.btnBillIMG = new System.Windows.Forms.Button();
            this.btnQuotIMG = new System.Windows.Forms.Button();
            this.btnCatIMG = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNext1 = new System.Windows.Forms.Button();
            this.btnPrev1 = new System.Windows.Forms.Button();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPrev2 = new System.Windows.Forms.Button();
            this.btnNext2 = new System.Windows.Forms.Button();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.btnExport1 = new System.Windows.Forms.Button();
            this.btnExport2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetaila)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDetaila);
            this.groupBox1.Location = new System.Drawing.Point(12, 362);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1406, 431);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dgvDetaila
            // 
            this.dgvDetaila.AllowUserToAddRows = false;
            this.dgvDetaila.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvDetaila.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetaila.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetaila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetaila.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetaila.Location = new System.Drawing.Point(3, 16);
            this.dgvDetaila.MultiSelect = false;
            this.dgvDetaila.Name = "dgvDetaila";
            this.dgvDetaila.ReadOnly = true;
            this.dgvDetaila.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetaila.Size = new System.Drawing.Size(1400, 412);
            this.dgvDetaila.TabIndex = 0;
            this.dgvDetaila.DoubleClick += new System.EventHandler(this.dgvDetaila_DoubleClick);
            // 
            // btnProIMG
            // 
            this.btnProIMG.Location = new System.Drawing.Point(21, 12);
            this.btnProIMG.Name = "btnProIMG";
            this.btnProIMG.Size = new System.Drawing.Size(75, 23);
            this.btnProIMG.TabIndex = 1;
            this.btnProIMG.Text = "Product IMG";
            this.btnProIMG.UseVisualStyleBackColor = true;
            this.btnProIMG.Click += new System.EventHandler(this.btnProIMG_Click);
            // 
            // btnCompIMG
            // 
            this.btnCompIMG.Location = new System.Drawing.Point(102, 12);
            this.btnCompIMG.Name = "btnCompIMG";
            this.btnCompIMG.Size = new System.Drawing.Size(90, 23);
            this.btnCompIMG.TabIndex = 2;
            this.btnCompIMG.Text = "Company IMG";
            this.btnCompIMG.UseVisualStyleBackColor = true;
            this.btnCompIMG.Click += new System.EventHandler(this.btnCompIMG_Click);
            // 
            // btnBCIMG
            // 
            this.btnBCIMG.Location = new System.Drawing.Point(198, 12);
            this.btnBCIMG.Name = "btnBCIMG";
            this.btnBCIMG.Size = new System.Drawing.Size(84, 23);
            this.btnBCIMG.TabIndex = 3;
            this.btnBCIMG.Text = "Company B.C.";
            this.btnBCIMG.UseVisualStyleBackColor = true;
            this.btnBCIMG.Click += new System.EventHandler(this.btnBCIMG_Click);
            // 
            // btnBillIMG
            // 
            this.btnBillIMG.Location = new System.Drawing.Point(953, 12);
            this.btnBillIMG.Name = "btnBillIMG";
            this.btnBillIMG.Size = new System.Drawing.Size(107, 23);
            this.btnBillIMG.TabIndex = 4;
            this.btnBillIMG.Text = "Bill IMG";
            this.btnBillIMG.UseVisualStyleBackColor = true;
            this.btnBillIMG.Click += new System.EventHandler(this.btnBillIMG_Click);
            // 
            // btnQuotIMG
            // 
            this.btnQuotIMG.Location = new System.Drawing.Point(1066, 12);
            this.btnQuotIMG.Name = "btnQuotIMG";
            this.btnQuotIMG.Size = new System.Drawing.Size(107, 23);
            this.btnQuotIMG.TabIndex = 5;
            this.btnQuotIMG.Text = "Quotation IMG";
            this.btnQuotIMG.UseVisualStyleBackColor = true;
            this.btnQuotIMG.Click += new System.EventHandler(this.btnQuotIMG_Click);
            // 
            // btnCatIMG
            // 
            this.btnCatIMG.Location = new System.Drawing.Point(288, 12);
            this.btnCatIMG.Name = "btnCatIMG";
            this.btnCatIMG.Size = new System.Drawing.Size(75, 23);
            this.btnCatIMG.TabIndex = 6;
            this.btnCatIMG.Text = "Cataloge";
            this.btnCatIMG.UseVisualStyleBackColor = true;
            this.btnCatIMG.Click += new System.EventHandler(this.btnCatIMG_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNext1);
            this.groupBox2.Controls.Add(this.btnPrev1);
            this.groupBox2.Controls.Add(this.picBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 315);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Images:";
            // 
            // btnNext1
            // 
            this.btnNext1.Location = new System.Drawing.Point(478, 159);
            this.btnNext1.Name = "btnNext1";
            this.btnNext1.Size = new System.Drawing.Size(32, 23);
            this.btnNext1.TabIndex = 2;
            this.btnNext1.Text = ">>";
            this.btnNext1.UseVisualStyleBackColor = true;
            this.btnNext1.Click += new System.EventHandler(this.btnNext1_Click);
            // 
            // btnPrev1
            // 
            this.btnPrev1.Location = new System.Drawing.Point(9, 159);
            this.btnPrev1.Name = "btnPrev1";
            this.btnPrev1.Size = new System.Drawing.Size(32, 23);
            this.btnPrev1.TabIndex = 1;
            this.btnPrev1.Text = "<<";
            this.btnPrev1.UseVisualStyleBackColor = true;
            this.btnPrev1.Click += new System.EventHandler(this.btnPrev1_Click);
            // 
            // picBox1
            // 
            this.picBox1.Location = new System.Drawing.Point(47, 19);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(425, 290);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox1.TabIndex = 0;
            this.picBox1.TabStop = false;
            this.picBox1.DoubleClick += new System.EventHandler(this.picBox1_DoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPrev2);
            this.groupBox3.Controls.Add(this.btnNext2);
            this.groupBox3.Controls.Add(this.picBox2);
            this.groupBox3.Controls.Add(this.txtDate);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(901, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(517, 315);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Images:";
            // 
            // btnPrev2
            // 
            this.btnPrev2.Location = new System.Drawing.Point(3, 159);
            this.btnPrev2.Name = "btnPrev2";
            this.btnPrev2.Size = new System.Drawing.Size(32, 23);
            this.btnPrev2.TabIndex = 3;
            this.btnPrev2.Text = "<<";
            this.btnPrev2.UseVisualStyleBackColor = true;
            this.btnPrev2.Click += new System.EventHandler(this.btnPrev2_Click);
            // 
            // btnNext2
            // 
            this.btnNext2.Location = new System.Drawing.Point(481, 159);
            this.btnNext2.Name = "btnNext2";
            this.btnNext2.Size = new System.Drawing.Size(32, 23);
            this.btnNext2.TabIndex = 4;
            this.btnNext2.Text = ">>";
            this.btnNext2.UseVisualStyleBackColor = true;
            this.btnNext2.Click += new System.EventHandler(this.btnNext2_Click);
            // 
            // picBox2
            // 
            this.picBox2.Location = new System.Drawing.Point(41, 45);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(434, 264);
            this.picBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox2.TabIndex = 1;
            this.picBox2.TabStop = false;
            this.picBox2.DoubleClick += new System.EventHandler(this.picBox2_DoubleClick);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(144, 19);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(252, 20);
            this.txtDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(553, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(603, 336);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(287, 20);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = global::Travel_data_organization.Properties.Resources.s1;
            this.picBoxLogo.Location = new System.Drawing.Point(532, 12);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(363, 270);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogo.TabIndex = 11;
            this.picBoxLogo.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(556, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Product:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(726, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Company:";
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(610, 297);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.ReadOnly = true;
            this.txtProduct.Size = new System.Drawing.Size(100, 20);
            this.txtProduct.TabIndex = 14;
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(788, 297);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.ReadOnly = true;
            this.txtCompany.Size = new System.Drawing.Size(100, 20);
            this.txtCompany.TabIndex = 15;
            // 
            // btnExport1
            // 
            this.btnExport1.Location = new System.Drawing.Point(416, 12);
            this.btnExport1.Name = "btnExport1";
            this.btnExport1.Size = new System.Drawing.Size(106, 23);
            this.btnExport1.TabIndex = 16;
            this.btnExport1.Text = "Export Image";
            this.btnExport1.UseVisualStyleBackColor = true;
            this.btnExport1.Click += new System.EventHandler(this.btnExport1_Click);
            // 
            // btnExport2
            // 
            this.btnExport2.Location = new System.Drawing.Point(1270, 12);
            this.btnExport2.Name = "btnExport2";
            this.btnExport2.Size = new System.Drawing.Size(106, 23);
            this.btnExport2.TabIndex = 17;
            this.btnExport2.Text = "Export Image";
            this.btnExport2.UseVisualStyleBackColor = true;
            this.btnExport2.Click += new System.EventHandler(this.btnExport2_Click);
            // 
            // FRM_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 805);
            this.Controls.Add(this.btnExport2);
            this.Controls.Add(this.btnExport1);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picBoxLogo);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCatIMG);
            this.Controls.Add(this.btnQuotIMG);
            this.Controls.Add(this.btnBillIMG);
            this.Controls.Add(this.btnBCIMG);
            this.Controls.Add(this.btnCompIMG);
            this.Controls.Add(this.btnProIMG);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Report";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetaila)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDetaila;
        private System.Windows.Forms.Button btnProIMG;
        private System.Windows.Forms.Button btnCompIMG;
        private System.Windows.Forms.Button btnBCIMG;
        private System.Windows.Forms.Button btnBillIMG;
        private System.Windows.Forms.Button btnQuotIMG;
        private System.Windows.Forms.Button btnCatIMG;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNext1;
        private System.Windows.Forms.Button btnPrev1;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPrev2;
        private System.Windows.Forms.Button btnNext2;
        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Button btnExport1;
        private System.Windows.Forms.Button btnExport2;
    }
}
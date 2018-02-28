namespace Travel_data_organization.PL
{
    partial class FRM_AddCompany
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.txtCompName = new System.Windows.Forms.TextBox();
            this.btnSelectImG = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbIMG = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSelectBC = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lbBC = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Country Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "City Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Company Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Image Of Company:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Business card:";
            // 
            // cmbCountry
            // 
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(122, 12);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(318, 21);
            this.cmbCountry.TabIndex = 5;
            this.cmbCountry.SelectedIndexChanged += new System.EventHandler(this.cmbCountry_SelectedIndexChanged);
            // 
            // cmbCity
            // 
            this.cmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(122, 39);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(318, 21);
            this.cmbCity.TabIndex = 6;
            // 
            // txtCompName
            // 
            this.txtCompName.Location = new System.Drawing.Point(122, 66);
            this.txtCompName.Name = "txtCompName";
            this.txtCompName.Size = new System.Drawing.Size(318, 20);
            this.txtCompName.TabIndex = 7;
            // 
            // btnSelectImG
            // 
            this.btnSelectImG.Location = new System.Drawing.Point(16, 19);
            this.btnSelectImG.Name = "btnSelectImG";
            this.btnSelectImG.Size = new System.Drawing.Size(75, 23);
            this.btnSelectImG.TabIndex = 8;
            this.btnSelectImG.Text = "Select";
            this.btnSelectImG.UseVisualStyleBackColor = true;
            this.btnSelectImG.Click += new System.EventHandler(this.btnSelectImG_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Num Of IMG:";
            // 
            // lbIMG
            // 
            this.lbIMG.AutoSize = true;
            this.lbIMG.Location = new System.Drawing.Point(240, 24);
            this.lbIMG.Name = "lbIMG";
            this.lbIMG.Size = new System.Drawing.Size(12, 13);
            this.lbIMG.TabIndex = 10;
            this.lbIMG.Text = "?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelectImG);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbIMG);
            this.groupBox1.Location = new System.Drawing.Point(122, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 61);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSelectBC);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lbBC);
            this.groupBox2.Location = new System.Drawing.Point(122, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 61);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // btnSelectBC
            // 
            this.btnSelectBC.Location = new System.Drawing.Point(16, 19);
            this.btnSelectBC.Name = "btnSelectBC";
            this.btnSelectBC.Size = new System.Drawing.Size(75, 23);
            this.btnSelectBC.TabIndex = 8;
            this.btnSelectBC.Text = "Select";
            this.btnSelectBC.UseVisualStyleBackColor = true;
            this.btnSelectBC.Click += new System.EventHandler(this.btnSelectBC_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(165, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Num Of IMG:";
            // 
            // lbBC
            // 
            this.lbBC.AutoSize = true;
            this.lbBC.Location = new System.Drawing.Point(240, 24);
            this.lbBC.Name = "lbBC";
            this.lbBC.Size = new System.Drawing.Size(12, 13);
            this.lbBC.TabIndex = 10;
            this.lbBC.Text = "?";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(122, 226);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(365, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FRM_AddCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 253);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCompName);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_AddCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Company";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.TextBox txtCompName;
        private System.Windows.Forms.Button btnSelectImG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbIMG;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSelectBC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbBC;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
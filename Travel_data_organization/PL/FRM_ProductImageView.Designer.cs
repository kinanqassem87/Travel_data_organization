namespace Travel_data_organization.PL
{
    partial class FRM_ProductImageView
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
            this.txtIMGid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSelectOne = new System.Windows.Forms.Button();
            this.btnFirstIMG = new System.Windows.Forms.Button();
            this.btnNextIMG = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIMGid
            // 
            this.txtIMGid.Location = new System.Drawing.Point(79, 6);
            this.txtIMGid.Name = "txtIMGid";
            this.txtIMGid.ReadOnly = true;
            this.txtIMGid.Size = new System.Drawing.Size(94, 20);
            this.txtIMGid.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Image ID : ";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(155, 704);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(177, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete This Image";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(806, 675);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(177, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save Image";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSelectOne
            // 
            this.btnSelectOne.Location = new System.Drawing.Point(989, 675);
            this.btnSelectOne.Name = "btnSelectOne";
            this.btnSelectOne.Size = new System.Drawing.Size(177, 23);
            this.btnSelectOne.TabIndex = 11;
            this.btnSelectOne.Text = "Select New Image";
            this.btnSelectOne.UseVisualStyleBackColor = true;
            this.btnSelectOne.Click += new System.EventHandler(this.btnSelectOne_Click);
            // 
            // btnFirstIMG
            // 
            this.btnFirstIMG.Location = new System.Drawing.Point(12, 675);
            this.btnFirstIMG.Name = "btnFirstIMG";
            this.btnFirstIMG.Size = new System.Drawing.Size(228, 23);
            this.btnFirstIMG.TabIndex = 10;
            this.btnFirstIMG.Text = "First Image";
            this.btnFirstIMG.UseVisualStyleBackColor = true;
            this.btnFirstIMG.Click += new System.EventHandler(this.btnFirstIMG_Click);
            // 
            // btnNextIMG
            // 
            this.btnNextIMG.Location = new System.Drawing.Point(246, 675);
            this.btnNextIMG.Name = "btnNextIMG";
            this.btnNextIMG.Size = new System.Drawing.Size(228, 23);
            this.btnNextIMG.TabIndex = 9;
            this.btnNextIMG.Text = "Next Image";
            this.btnNextIMG.UseVisualStyleBackColor = true;
            this.btnNextIMG.Click += new System.EventHandler(this.btnNextIMG_Click);
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(12, 32);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(1154, 637);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 8;
            this.picImage.TabStop = false;
            // 
            // FRM_ProductImageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 731);
            this.Controls.Add(this.txtIMGid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSelectOne);
            this.Controls.Add(this.btnFirstIMG);
            this.Controls.Add(this.btnNextIMG);
            this.Controls.Add(this.picImage);
            this.Name = "FRM_ProductImageView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Product Image";
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIMGid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSelectOne;
        private System.Windows.Forms.Button btnFirstIMG;
        private System.Windows.Forms.Button btnNextIMG;
        private System.Windows.Forms.PictureBox picImage;
    }
}
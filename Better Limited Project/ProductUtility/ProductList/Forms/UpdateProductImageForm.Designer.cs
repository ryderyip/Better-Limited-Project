
namespace Better_Limited_Project.ProductUtility.ProductList.Forms
{
    partial class UpdateProductImageForm
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
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(149, 269);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.ReadOnly = true;
            this.tbFilePath.Size = new System.Drawing.Size(225, 20);
            this.tbFilePath.TabIndex = 175;
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnChooseImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseImage.ForeColor = System.Drawing.SystemColors.Window;
            this.btnChooseImage.Location = new System.Drawing.Point(264, 232);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(110, 31);
            this.btnChooseImage.TabIndex = 174;
            this.btnChooseImage.Text = "Choose Image";
            this.btnChooseImage.UseVisualStyleBackColor = false;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(106, 26);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(250, 26);
            this.lblHeader.TabIndex = 177;
            this.lblHeader.Text = "Update Product Image";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.Location = new System.Drawing.Point(85, 270);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(58, 15);
            this.lblPath.TabIndex = 178;
            this.lblPath.Text = "File Path:";
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(158, 77);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(141, 141);
            this.pbImage.TabIndex = 176;
            this.pbImage.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Salmon;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSubmit.Location = new System.Drawing.Point(158, 311);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(146, 54);
            this.btnSubmit.TabIndex = 179;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // UpdateProductImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 388);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.btnChooseImage);
            this.Name = "UpdateProductImageForm";
            this.Text = "UpdateProductImageForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnSubmit;
    }
}
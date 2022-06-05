using System.ComponentModel;

namespace Better_Limited_Project.ProductUtility.ProductList.Forms
{
    partial class NewProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.lblNewProduct = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.tbImagePath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNewProduct
            // 
            this.lblNewProduct.AutoSize = true;
            this.lblNewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewProduct.Location = new System.Drawing.Point(228, 24);
            this.lblNewProduct.Name = "lblNewProduct";
            this.lblNewProduct.Size = new System.Drawing.Size(148, 26);
            this.lblNewProduct.TabIndex = 54;
            this.lblNewProduct.Text = "New Product";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCreate.Location = new System.Drawing.Point(211, 380);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(183, 44);
            this.btnCreate.TabIndex = 63;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(154, 131);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(38, 15);
            this.lblPrice.TabIndex = 67;
            this.lblPrice.Text = "Price:";
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Location = new System.Drawing.Point(204, 131);
            this.nudPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(120, 20);
            this.nudPrice.TabIndex = 76;
            this.nudPrice.ThousandsSeparator = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 78;
            this.label2.Text = "Product Name:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(204, 94);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(225, 20);
            this.tbName.TabIndex = 75;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(75, 167);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(117, 15);
            this.lblDescription.TabIndex = 80;
            this.lblDescription.Text = "Product Description:";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(204, 166);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(225, 56);
            this.tbDescription.TabIndex = 81;
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(204, 237);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(120, 21);
            this.cbCategory.TabIndex = 82;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(134, 238);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(58, 15);
            this.lblCategory.TabIndex = 83;
            this.lblCategory.Text = "Category:";
            // 
            // cbSupplier
            // 
            this.cbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(204, 274);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(120, 21);
            this.cbSupplier.TabIndex = 84;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(136, 274);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(56, 15);
            this.lblSupplier.TabIndex = 85;
            this.lblSupplier.Text = "Supplier:";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImage.Location = new System.Drawing.Point(108, 311);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(90, 15);
            this.lblImage.TabIndex = 87;
            this.lblImage.Text = "Product Image:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(192, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 15);
            this.label1.TabIndex = 88;
            this.label1.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(192, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 15);
            this.label3.TabIndex = 89;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(192, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 15);
            this.label4.TabIndex = 90;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(192, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 15);
            this.label5.TabIndex = 91;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(192, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 15);
            this.label6.TabIndex = 92;
            this.label6.Text = "*";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnChooseImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseImage.ForeColor = System.Drawing.SystemColors.Window;
            this.btnChooseImage.Location = new System.Drawing.Point(435, 303);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(110, 31);
            this.btnChooseImage.TabIndex = 171;
            this.btnChooseImage.Text = "Choose Image";
            this.btnChooseImage.UseVisualStyleBackColor = false;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // tbImagePath
            // 
            this.tbImagePath.Location = new System.Drawing.Point(204, 310);
            this.tbImagePath.Name = "tbImagePath";
            this.tbImagePath.ReadOnly = true;
            this.tbImagePath.Size = new System.Drawing.Size(225, 20);
            this.tbImagePath.TabIndex = 172;
            // 
            // NewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(604, 450);
            this.Controls.Add(this.tbImagePath);
            this.Controls.Add(this.btnChooseImage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.cbSupplier);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblNewProduct);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "NewProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblNewProduct;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.Label lblSupplier;

        #endregion

        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.TextBox tbImagePath;
    }
}
using System.ComponentModel;

namespace Better_Limited_Project.ProductUtility.ProductList.Forms
{
    partial class ProductDetailsForm
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
            this.btnUpdateProductInfo = new System.Windows.Forms.Button();
            this.lblSellingPrice = new System.Windows.Forms.Label();
            this.lblOriginalPrice = new System.Windows.Forms.Label();
            this.lblProductInfo = new System.Windows.Forms.Label();
            this.tbOriginalPrice = new System.Windows.Forms.TextBox();
            this.tbSellingPrice = new System.Windows.Forms.TextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblPhasingOut = new System.Windows.Forms.Label();
            this.tbPhasingOut = new System.Windows.Forms.TextBox();
            this.tbReorderLevel = new System.Windows.Forms.TextBox();
            this.lblReorderLevel = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblSupplierInFo = new System.Windows.Forms.Label();
            this.tbSupplierName = new System.Windows.Forms.TextBox();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.lblSupplierEmail = new System.Windows.Forms.Label();
            this.lblSupplierPhone = new System.Windows.Forms.Label();
            this.tbSupplierPhone = new System.Windows.Forms.TextBox();
            this.tbSupplierEmail = new System.Windows.Forms.TextBox();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.btnEditDescription = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateImage = new System.Windows.Forms.Button();
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateProductInfo
            // 
            this.btnUpdateProductInfo.BackColor = System.Drawing.Color.Salmon;
            this.btnUpdateProductInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProductInfo.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdateProductInfo.Location = new System.Drawing.Point(392, 403);
            this.btnUpdateProductInfo.Name = "btnUpdateProductInfo";
            this.btnUpdateProductInfo.Size = new System.Drawing.Size(200, 54);
            this.btnUpdateProductInfo.TabIndex = 58;
            this.btnUpdateProductInfo.Text = "Update Product Info";
            this.btnUpdateProductInfo.UseVisualStyleBackColor = false;
            this.btnUpdateProductInfo.Click += new System.EventHandler(this.btnUpdateProductInfo_Click);
            // 
            // lblSellingPrice
            // 
            this.lblSellingPrice.AutoSize = true;
            this.lblSellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellingPrice.Location = new System.Drawing.Point(58, 352);
            this.lblSellingPrice.Name = "lblSellingPrice";
            this.lblSellingPrice.Size = new System.Drawing.Size(79, 15);
            this.lblSellingPrice.TabIndex = 49;
            this.lblSellingPrice.Text = "Selling Price:";
            // 
            // lblOriginalPrice
            // 
            this.lblOriginalPrice.AutoSize = true;
            this.lblOriginalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalPrice.Location = new System.Drawing.Point(53, 318);
            this.lblOriginalPrice.Name = "lblOriginalPrice";
            this.lblOriginalPrice.Size = new System.Drawing.Size(84, 15);
            this.lblOriginalPrice.TabIndex = 48;
            this.lblOriginalPrice.Text = "Original Price:";
            // 
            // lblProductInfo
            // 
            this.lblProductInfo.AutoSize = true;
            this.lblProductInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductInfo.Location = new System.Drawing.Point(85, 85);
            this.lblProductInfo.Name = "lblProductInfo";
            this.lblProductInfo.Size = new System.Drawing.Size(168, 20);
            this.lblProductInfo.TabIndex = 46;
            this.lblProductInfo.Text = "Product Information";
            // 
            // tbOriginalPrice
            // 
            this.tbOriginalPrice.Location = new System.Drawing.Point(143, 318);
            this.tbOriginalPrice.Name = "tbOriginalPrice";
            this.tbOriginalPrice.ReadOnly = true;
            this.tbOriginalPrice.Size = new System.Drawing.Size(139, 20);
            this.tbOriginalPrice.TabIndex = 59;
            // 
            // tbSellingPrice
            // 
            this.tbSellingPrice.Location = new System.Drawing.Point(143, 353);
            this.tbSellingPrice.Name = "tbSellingPrice";
            this.tbSellingPrice.ReadOnly = true;
            this.tbSellingPrice.Size = new System.Drawing.Size(139, 20);
            this.tbSellingPrice.TabIndex = 60;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(290, 24);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(221, 26);
            this.lblHeader.TabIndex = 61;
            this.lblHeader.Text = "Product Information";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhasingOut
            // 
            this.lblPhasingOut.AutoSize = true;
            this.lblPhasingOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhasingOut.Location = new System.Drawing.Point(58, 198);
            this.lblPhasingOut.Name = "lblPhasingOut";
            this.lblPhasingOut.Size = new System.Drawing.Size(76, 15);
            this.lblPhasingOut.TabIndex = 62;
            this.lblPhasingOut.Text = "Phasing-out:";
            // 
            // tbPhasingOut
            // 
            this.tbPhasingOut.Location = new System.Drawing.Point(143, 198);
            this.tbPhasingOut.Name = "tbPhasingOut";
            this.tbPhasingOut.ReadOnly = true;
            this.tbPhasingOut.Size = new System.Drawing.Size(139, 20);
            this.tbPhasingOut.TabIndex = 63;
            // 
            // tbReorderLevel
            // 
            this.tbReorderLevel.Location = new System.Drawing.Point(143, 275);
            this.tbReorderLevel.Name = "tbReorderLevel";
            this.tbReorderLevel.ReadOnly = true;
            this.tbReorderLevel.Size = new System.Drawing.Size(139, 20);
            this.tbReorderLevel.TabIndex = 65;
            // 
            // lblReorderLevel
            // 
            this.lblReorderLevel.AutoSize = true;
            this.lblReorderLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReorderLevel.Location = new System.Drawing.Point(50, 274);
            this.lblReorderLevel.Name = "lblReorderLevel";
            this.lblReorderLevel.Size = new System.Drawing.Size(87, 15);
            this.lblReorderLevel.TabIndex = 64;
            this.lblReorderLevel.Text = "Reorder Level:";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(143, 234);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.ReadOnly = true;
            this.tbQuantity.Size = new System.Drawing.Size(139, 20);
            this.tbQuantity.TabIndex = 67;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(24, 234);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(113, 15);
            this.lblQuantity.TabIndex = 66;
            this.lblQuantity.Text = "Quantity in Storage:";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(316, 272);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.Size = new System.Drawing.Size(208, 101);
            this.tbDescription.TabIndex = 69;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(339, 239);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(167, 20);
            this.lblDescription.TabIndex = 70;
            this.lblDescription.Text = "Product Description";
            // 
            // lblSupplierInFo
            // 
            this.lblSupplierInFo.AutoSize = true;
            this.lblSupplierInFo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierInFo.Location = new System.Drawing.Point(339, 85);
            this.lblSupplierInFo.Name = "lblSupplierInFo";
            this.lblSupplierInFo.Size = new System.Drawing.Size(172, 20);
            this.lblSupplierInFo.TabIndex = 71;
            this.lblSupplierInFo.Text = "Supplier Information";
            // 
            // tbSupplierName
            // 
            this.tbSupplierName.Location = new System.Drawing.Point(374, 124);
            this.tbSupplierName.Name = "tbSupplierName";
            this.tbSupplierName.ReadOnly = true;
            this.tbSupplierName.Size = new System.Drawing.Size(125, 20);
            this.tbSupplierName.TabIndex = 76;
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierName.Location = new System.Drawing.Point(326, 125);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(44, 15);
            this.lblSupplierName.TabIndex = 73;
            this.lblSupplierName.Text = "Name:";
            // 
            // lblSupplierEmail
            // 
            this.lblSupplierEmail.AutoSize = true;
            this.lblSupplierEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierEmail.Location = new System.Drawing.Point(326, 198);
            this.lblSupplierEmail.Name = "lblSupplierEmail";
            this.lblSupplierEmail.Size = new System.Drawing.Size(42, 15);
            this.lblSupplierEmail.TabIndex = 78;
            this.lblSupplierEmail.Text = "Email:";
            // 
            // lblSupplierPhone
            // 
            this.lblSupplierPhone.AutoSize = true;
            this.lblSupplierPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierPhone.Location = new System.Drawing.Point(322, 162);
            this.lblSupplierPhone.Name = "lblSupplierPhone";
            this.lblSupplierPhone.Size = new System.Drawing.Size(46, 15);
            this.lblSupplierPhone.TabIndex = 80;
            this.lblSupplierPhone.Text = "Phone:";
            // 
            // tbSupplierPhone
            // 
            this.tbSupplierPhone.Location = new System.Drawing.Point(374, 161);
            this.tbSupplierPhone.Name = "tbSupplierPhone";
            this.tbSupplierPhone.ReadOnly = true;
            this.tbSupplierPhone.Size = new System.Drawing.Size(125, 20);
            this.tbSupplierPhone.TabIndex = 81;
            // 
            // tbSupplierEmail
            // 
            this.tbSupplierEmail.Location = new System.Drawing.Point(374, 197);
            this.tbSupplierEmail.Name = "tbSupplierEmail";
            this.tbSupplierEmail.ReadOnly = true;
            this.tbSupplierEmail.Size = new System.Drawing.Size(125, 20);
            this.tbSupplierEmail.TabIndex = 82;
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.BackColor = System.Drawing.Color.OrangeRed;
            this.btnRemoveProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRemoveProduct.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRemoveProduct.Location = new System.Drawing.Point(42, 403);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(167, 54);
            this.btnRemoveProduct.TabIndex = 83;
            this.btnRemoveProduct.Text = "Remove Product";
            this.btnRemoveProduct.UseVisualStyleBackColor = false;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // btnEditDescription
            // 
            this.btnEditDescription.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEditDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDescription.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEditDescription.Location = new System.Drawing.Point(234, 403);
            this.btnEditDescription.Name = "btnEditDescription";
            this.btnEditDescription.Size = new System.Drawing.Size(133, 54);
            this.btnEditDescription.TabIndex = 110;
            this.btnEditDescription.Text = "Edit Description";
            this.btnEditDescription.UseVisualStyleBackColor = false;
            this.btnEditDescription.Click += new System.EventHandler(this.btnEditDescription_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(143, 123);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(139, 20);
            this.tbName.TabIndex = 112;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(90, 124);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 15);
            this.lblName.TabIndex = 111;
            this.lblName.Text = "Name:";
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(561, 123);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(214, 250);
            this.pbImage.TabIndex = 113;
            this.pbImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(607, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 114;
            this.label1.Text = "Product Image";
            // 
            // btnUpdateImage
            // 
            this.btnUpdateImage.BackColor = System.Drawing.Color.Plum;
            this.btnUpdateImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateImage.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdateImage.Location = new System.Drawing.Point(617, 403);
            this.btnUpdateImage.Name = "btnUpdateImage";
            this.btnUpdateImage.Size = new System.Drawing.Size(156, 54);
            this.btnUpdateImage.TabIndex = 169;
            this.btnUpdateImage.Text = "Upload Image";
            this.btnUpdateImage.UseVisualStyleBackColor = false;
            this.btnUpdateImage.Click += new System.EventHandler(this.btnUpdateImage_Click);
            // 
            // tbCategory
            // 
            this.tbCategory.Location = new System.Drawing.Point(143, 161);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.ReadOnly = true;
            this.tbCategory.Size = new System.Drawing.Size(139, 20);
            this.tbCategory.TabIndex = 171;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(76, 162);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(58, 15);
            this.lblCategory.TabIndex = 170;
            this.lblCategory.Text = "Category:";
            // 
            // ProductDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.tbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.btnUpdateImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnEditDescription);
            this.Controls.Add(this.btnRemoveProduct);
            this.Controls.Add(this.tbSupplierEmail);
            this.Controls.Add(this.tbSupplierPhone);
            this.Controls.Add(this.lblSupplierPhone);
            this.Controls.Add(this.lblSupplierEmail);
            this.Controls.Add(this.tbSupplierName);
            this.Controls.Add(this.lblSupplierName);
            this.Controls.Add(this.lblSupplierInFo);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.tbReorderLevel);
            this.Controls.Add(this.lblReorderLevel);
            this.Controls.Add(this.tbPhasingOut);
            this.Controls.Add(this.lblPhasingOut);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.tbSellingPrice);
            this.Controls.Add(this.tbOriginalPrice);
            this.Controls.Add(this.btnUpdateProductInfo);
            this.Controls.Add(this.lblSellingPrice);
            this.Controls.Add(this.lblOriginalPrice);
            this.Controls.Add(this.lblProductInfo);
            this.Name = "ProductDetailsForm";
            this.Text = "ProductDetailsForm";
            this.Shown += new System.EventHandler(this.OnShown);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public System.Windows.Forms.Button btnRemoveProduct;

        private System.Windows.Forms.Button btnUpdateProductInfo;

        private System.Windows.Forms.TextBox tbSupplierEmail;

        private System.Windows.Forms.TextBox tbSupplierPhone;

        private System.Windows.Forms.Label lblSupplierEmail;
        private System.Windows.Forms.Label lblSupplierPhone;

        private System.Windows.Forms.Label lblProductInfo;

        private System.Windows.Forms.TextBox tbSellingPrice;

        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lblSupplierInFo;
        private System.Windows.Forms.TextBox tbSupplierName;
        private System.Windows.Forms.Label lblSupplierName;

        private System.Windows.Forms.Label lblDescription;

        private System.Windows.Forms.TextBox tbOriginalPrice;
        private System.Windows.Forms.Label lblOriginalPrice;
        private System.Windows.Forms.Label lblSellingPrice;
        private System.Windows.Forms.TextBox tbPhasingOut;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblPhasingOut;
        private System.Windows.Forms.TextBox tbReorderLevel;
        private System.Windows.Forms.Label lblReorderLevel;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label lblQuantity;

        #endregion

        private System.Windows.Forms.Button btnEditDescription;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateImage;
        private System.Windows.Forms.TextBox tbCategory;
        private System.Windows.Forms.Label lblCategory;
    }
}
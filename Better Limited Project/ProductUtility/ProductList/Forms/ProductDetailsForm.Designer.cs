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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductDetailsForm));
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateImage = new System.Windows.Forms.Button();
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateProductInfo
            // 
            this.btnUpdateProductInfo.BackColor = System.Drawing.Color.Salmon;
            resources.ApplyResources(this.btnUpdateProductInfo, "btnUpdateProductInfo");
            this.btnUpdateProductInfo.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdateProductInfo.Name = "btnUpdateProductInfo";
            this.btnUpdateProductInfo.UseVisualStyleBackColor = false;
            this.btnUpdateProductInfo.Click += new System.EventHandler(this.btnUpdateProductInfo_Click);
            // 
            // lblSellingPrice
            // 
            resources.ApplyResources(this.lblSellingPrice, "lblSellingPrice");
            this.lblSellingPrice.Name = "lblSellingPrice";
            // 
            // lblOriginalPrice
            // 
            resources.ApplyResources(this.lblOriginalPrice, "lblOriginalPrice");
            this.lblOriginalPrice.Name = "lblOriginalPrice";
            // 
            // lblProductInfo
            // 
            resources.ApplyResources(this.lblProductInfo, "lblProductInfo");
            this.lblProductInfo.Name = "lblProductInfo";
            // 
            // tbOriginalPrice
            // 
            resources.ApplyResources(this.tbOriginalPrice, "tbOriginalPrice");
            this.tbOriginalPrice.Name = "tbOriginalPrice";
            this.tbOriginalPrice.ReadOnly = true;
            // 
            // tbSellingPrice
            // 
            resources.ApplyResources(this.tbSellingPrice, "tbSellingPrice");
            this.tbSellingPrice.Name = "tbSellingPrice";
            this.tbSellingPrice.ReadOnly = true;
            // 
            // lblHeader
            // 
            resources.ApplyResources(this.lblHeader, "lblHeader");
            this.lblHeader.Name = "lblHeader";
            // 
            // lblPhasingOut
            // 
            resources.ApplyResources(this.lblPhasingOut, "lblPhasingOut");
            this.lblPhasingOut.Name = "lblPhasingOut";
            // 
            // tbPhasingOut
            // 
            resources.ApplyResources(this.tbPhasingOut, "tbPhasingOut");
            this.tbPhasingOut.Name = "tbPhasingOut";
            this.tbPhasingOut.ReadOnly = true;
            // 
            // tbReorderLevel
            // 
            resources.ApplyResources(this.tbReorderLevel, "tbReorderLevel");
            this.tbReorderLevel.Name = "tbReorderLevel";
            this.tbReorderLevel.ReadOnly = true;
            // 
            // lblReorderLevel
            // 
            resources.ApplyResources(this.lblReorderLevel, "lblReorderLevel");
            this.lblReorderLevel.Name = "lblReorderLevel";
            // 
            // tbQuantity
            // 
            resources.ApplyResources(this.tbQuantity, "tbQuantity");
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.ReadOnly = true;
            // 
            // lblQuantity
            // 
            resources.ApplyResources(this.lblQuantity, "lblQuantity");
            this.lblQuantity.Name = "lblQuantity";
            // 
            // tbDescription
            // 
            resources.ApplyResources(this.tbDescription, "tbDescription");
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            // 
            // lblDescription
            // 
            resources.ApplyResources(this.lblDescription, "lblDescription");
            this.lblDescription.Name = "lblDescription";
            // 
            // lblSupplierInFo
            // 
            resources.ApplyResources(this.lblSupplierInFo, "lblSupplierInFo");
            this.lblSupplierInFo.Name = "lblSupplierInFo";
            // 
            // tbSupplierName
            // 
            resources.ApplyResources(this.tbSupplierName, "tbSupplierName");
            this.tbSupplierName.Name = "tbSupplierName";
            this.tbSupplierName.ReadOnly = true;
            // 
            // lblSupplierName
            // 
            resources.ApplyResources(this.lblSupplierName, "lblSupplierName");
            this.lblSupplierName.Name = "lblSupplierName";
            // 
            // lblSupplierEmail
            // 
            resources.ApplyResources(this.lblSupplierEmail, "lblSupplierEmail");
            this.lblSupplierEmail.Name = "lblSupplierEmail";
            // 
            // lblSupplierPhone
            // 
            resources.ApplyResources(this.lblSupplierPhone, "lblSupplierPhone");
            this.lblSupplierPhone.Name = "lblSupplierPhone";
            // 
            // tbSupplierPhone
            // 
            resources.ApplyResources(this.tbSupplierPhone, "tbSupplierPhone");
            this.tbSupplierPhone.Name = "tbSupplierPhone";
            this.tbSupplierPhone.ReadOnly = true;
            // 
            // tbSupplierEmail
            // 
            resources.ApplyResources(this.tbSupplierEmail, "tbSupplierEmail");
            this.tbSupplierEmail.Name = "tbSupplierEmail";
            this.tbSupplierEmail.ReadOnly = true;
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.BackColor = System.Drawing.Color.OrangeRed;
            resources.ApplyResources(this.btnRemoveProduct, "btnRemoveProduct");
            this.btnRemoveProduct.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.UseVisualStyleBackColor = false;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // btnEditDescription
            // 
            this.btnEditDescription.BackColor = System.Drawing.Color.LimeGreen;
            resources.ApplyResources(this.btnEditDescription, "btnEditDescription");
            this.btnEditDescription.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEditDescription.Name = "btnEditDescription";
            this.btnEditDescription.UseVisualStyleBackColor = false;
            this.btnEditDescription.Click += new System.EventHandler(this.btnEditDescription_Click);
            // 
            // tbName
            // 
            resources.ApplyResources(this.tbName, "tbName");
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnUpdateImage
            // 
            this.btnUpdateImage.BackColor = System.Drawing.Color.Plum;
            resources.ApplyResources(this.btnUpdateImage, "btnUpdateImage");
            this.btnUpdateImage.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdateImage.Name = "btnUpdateImage";
            this.btnUpdateImage.UseVisualStyleBackColor = false;
            this.btnUpdateImage.Click += new System.EventHandler(this.btnUpdateImage_Click);
            // 
            // tbCategory
            // 
            resources.ApplyResources(this.tbCategory, "tbCategory");
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.ReadOnly = true;
            // 
            // lblCategory
            // 
            resources.ApplyResources(this.lblCategory, "lblCategory");
            this.lblCategory.Name = "lblCategory";
            // 
            // pbImage
            // 
            resources.ApplyResources(this.pbImage, "pbImage");
            this.pbImage.Name = "pbImage";
            this.pbImage.TabStop = false;
            // 
            // ProductDetailsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
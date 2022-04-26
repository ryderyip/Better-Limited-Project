using System.ComponentModel;

namespace Better_Limited_Project.ProductUtility.ProductList
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
            this.btnUpdateSellingPrice = new System.Windows.Forms.Button();
            this.lblSellingPrice = new System.Windows.Forms.Label();
            this.lblOriginalPrice = new System.Windows.Forms.Label();
            this.lblProductInfo = new System.Windows.Forms.Label();
            this.tbOriginalPrice = new System.Windows.Forms.TextBox();
            this.tbSellingPrice = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblPhasingOut = new System.Windows.Forms.Label();
            this.tbPhasingOut = new System.Windows.Forms.TextBox();
            this.tbReorderLevel = new System.Windows.Forms.TextBox();
            this.lblReorderLevel = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblSupplierInFo = new System.Windows.Forms.Label();
            this.tbSupplierAddress = new System.Windows.Forms.TextBox();
            this.tbSupplierName = new System.Windows.Forms.TextBox();
            this.lblSupplierAddress = new System.Windows.Forms.Label();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.lblSupplierEmail = new System.Windows.Forms.Label();
            this.lblSupplierPhone = new System.Windows.Forms.Label();
            this.tbSupplierPhone = new System.Windows.Forms.TextBox();
            this.tbSupplierEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUpdateSellingPrice
            // 
            this.btnUpdateSellingPrice.BackColor = System.Drawing.Color.Salmon;
            this.btnUpdateSellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnUpdateSellingPrice.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdateSellingPrice.Location = new System.Drawing.Point(316, 367);
            this.btnUpdateSellingPrice.Name = "btnUpdateSellingPrice";
            this.btnUpdateSellingPrice.Size = new System.Drawing.Size(200, 54);
            this.btnUpdateSellingPrice.TabIndex = 58;
            this.btnUpdateSellingPrice.Text = "Update Selling Price";
            this.btnUpdateSellingPrice.UseVisualStyleBackColor = false;
            this.btnUpdateSellingPrice.Click += new System.EventHandler(this.btnUpdateSellingPrice_Click);
            // 
            // lblSellingPrice
            // 
            this.lblSellingPrice.AutoSize = true;
            this.lblSellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblSellingPrice.Location = new System.Drawing.Point(63, 183);
            this.lblSellingPrice.Name = "lblSellingPrice";
            this.lblSellingPrice.Size = new System.Drawing.Size(79, 15);
            this.lblSellingPrice.TabIndex = 49;
            this.lblSellingPrice.Text = "Selling Price:";
            // 
            // lblOriginalPrice
            // 
            this.lblOriginalPrice.AutoSize = true;
            this.lblOriginalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblOriginalPrice.Location = new System.Drawing.Point(58, 135);
            this.lblOriginalPrice.Name = "lblOriginalPrice";
            this.lblOriginalPrice.Size = new System.Drawing.Size(84, 15);
            this.lblOriginalPrice.TabIndex = 48;
            this.lblOriginalPrice.Text = "Original Price:";
            // 
            // lblProductInfo
            // 
            this.lblProductInfo.AutoSize = true;
            this.lblProductInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblProductInfo.Location = new System.Drawing.Point(85, 85);
            this.lblProductInfo.Name = "lblProductInfo";
            this.lblProductInfo.Size = new System.Drawing.Size(168, 20);
            this.lblProductInfo.TabIndex = 46;
            this.lblProductInfo.Text = "Product Information";
            // 
            // tbOriginalPrice
            // 
            this.tbOriginalPrice.Location = new System.Drawing.Point(148, 135);
            this.tbOriginalPrice.Name = "tbOriginalPrice";
            this.tbOriginalPrice.ReadOnly = true;
            this.tbOriginalPrice.Size = new System.Drawing.Size(119, 20);
            this.tbOriginalPrice.TabIndex = 59;
            // 
            // tbSellingPrice
            // 
            this.tbSellingPrice.Location = new System.Drawing.Point(148, 184);
            this.tbSellingPrice.Name = "tbSellingPrice";
            this.tbSellingPrice.ReadOnly = true;
            this.tbSellingPrice.Size = new System.Drawing.Size(119, 20);
            this.tbSellingPrice.TabIndex = 60;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblProductName.Location = new System.Drawing.Point(286, 24);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(238, 26);
            this.lblProductName.TabIndex = 61;
            this.lblProductName.Text = "(Product Name Here)";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhasingOut
            // 
            this.lblPhasingOut.AutoSize = true;
            this.lblPhasingOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblPhasingOut.Location = new System.Drawing.Point(63, 222);
            this.lblPhasingOut.Name = "lblPhasingOut";
            this.lblPhasingOut.Size = new System.Drawing.Size(76, 15);
            this.lblPhasingOut.TabIndex = 62;
            this.lblPhasingOut.Text = "Phasing-out:";
            // 
            // tbPhasingOut
            // 
            this.tbPhasingOut.Location = new System.Drawing.Point(148, 222);
            this.tbPhasingOut.Name = "tbPhasingOut";
            this.tbPhasingOut.ReadOnly = true;
            this.tbPhasingOut.Size = new System.Drawing.Size(119, 20);
            this.tbPhasingOut.TabIndex = 63;
            // 
            // tbReorderLevel
            // 
            this.tbReorderLevel.Location = new System.Drawing.Point(148, 299);
            this.tbReorderLevel.Name = "tbReorderLevel";
            this.tbReorderLevel.ReadOnly = true;
            this.tbReorderLevel.Size = new System.Drawing.Size(119, 20);
            this.tbReorderLevel.TabIndex = 65;
            // 
            // lblReorderLevel
            // 
            this.lblReorderLevel.AutoSize = true;
            this.lblReorderLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblReorderLevel.Location = new System.Drawing.Point(55, 298);
            this.lblReorderLevel.Name = "lblReorderLevel";
            this.lblReorderLevel.Size = new System.Drawing.Size(87, 15);
            this.lblReorderLevel.TabIndex = 64;
            this.lblReorderLevel.Text = "Reorder Level:";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(148, 258);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.ReadOnly = true;
            this.tbQuantity.Size = new System.Drawing.Size(119, 20);
            this.tbQuantity.TabIndex = 67;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblQuantity.Location = new System.Drawing.Point(29, 258);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(113, 15);
            this.lblQuantity.TabIndex = 66;
            this.lblQuantity.Text = "Quantity in Storage:";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(316, 134);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.Size = new System.Drawing.Size(208, 176);
            this.tbDescription.TabIndex = 69;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblDescription.Location = new System.Drawing.Point(368, 85);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 20);
            this.lblDescription.TabIndex = 70;
            this.lblDescription.Text = "Description";
            // 
            // lblSupplierInFo
            // 
            this.lblSupplierInFo.AutoSize = true;
            this.lblSupplierInFo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblSupplierInFo.Location = new System.Drawing.Point(576, 85);
            this.lblSupplierInFo.Name = "lblSupplierInFo";
            this.lblSupplierInFo.Size = new System.Drawing.Size(172, 20);
            this.lblSupplierInFo.TabIndex = 71;
            this.lblSupplierInFo.Text = "Supplier Information";
            // 
            // tbSupplierAddress
            // 
            this.tbSupplierAddress.Location = new System.Drawing.Point(656, 262);
            this.tbSupplierAddress.Name = "tbSupplierAddress";
            this.tbSupplierAddress.ReadOnly = true;
            this.tbSupplierAddress.Size = new System.Drawing.Size(119, 20);
            this.tbSupplierAddress.TabIndex = 77;
            // 
            // tbSupplierName
            // 
            this.tbSupplierName.Location = new System.Drawing.Point(656, 139);
            this.tbSupplierName.Name = "tbSupplierName";
            this.tbSupplierName.ReadOnly = true;
            this.tbSupplierName.Size = new System.Drawing.Size(119, 20);
            this.tbSupplierName.TabIndex = 76;
            // 
            // lblSupplierAddress
            // 
            this.lblSupplierAddress.AutoSize = true;
            this.lblSupplierAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblSupplierAddress.Location = new System.Drawing.Point(596, 263);
            this.lblSupplierAddress.Name = "lblSupplierAddress";
            this.lblSupplierAddress.Size = new System.Drawing.Size(54, 15);
            this.lblSupplierAddress.TabIndex = 74;
            this.lblSupplierAddress.Text = "Address:";
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblSupplierName.Location = new System.Drawing.Point(608, 140);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(44, 15);
            this.lblSupplierName.TabIndex = 73;
            this.lblSupplierName.Text = "Name:";
            // 
            // lblSupplierEmail
            // 
            this.lblSupplierEmail.AutoSize = true;
            this.lblSupplierEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblSupplierEmail.Location = new System.Drawing.Point(608, 223);
            this.lblSupplierEmail.Name = "lblSupplierEmail";
            this.lblSupplierEmail.Size = new System.Drawing.Size(42, 15);
            this.lblSupplierEmail.TabIndex = 78;
            this.lblSupplierEmail.Text = "Email:";
            // 
            // lblSupplierPhone
            // 
            this.lblSupplierPhone.AutoSize = true;
            this.lblSupplierPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblSupplierPhone.Location = new System.Drawing.Point(604, 185);
            this.lblSupplierPhone.Name = "lblSupplierPhone";
            this.lblSupplierPhone.Size = new System.Drawing.Size(46, 15);
            this.lblSupplierPhone.TabIndex = 80;
            this.lblSupplierPhone.Text = "Phone:";
            // 
            // tbSupplierPhone
            // 
            this.tbSupplierPhone.Location = new System.Drawing.Point(656, 184);
            this.tbSupplierPhone.Name = "tbSupplierPhone";
            this.tbSupplierPhone.ReadOnly = true;
            this.tbSupplierPhone.Size = new System.Drawing.Size(119, 20);
            this.tbSupplierPhone.TabIndex = 81;
            // 
            // tbSupplierEmail
            // 
            this.tbSupplierEmail.Location = new System.Drawing.Point(656, 222);
            this.tbSupplierEmail.Name = "tbSupplierEmail";
            this.tbSupplierEmail.ReadOnly = true;
            this.tbSupplierEmail.Size = new System.Drawing.Size(119, 20);
            this.tbSupplierEmail.TabIndex = 82;
            // 
            // ProductDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbSupplierEmail);
            this.Controls.Add(this.tbSupplierPhone);
            this.Controls.Add(this.lblSupplierPhone);
            this.Controls.Add(this.lblSupplierEmail);
            this.Controls.Add(this.tbSupplierAddress);
            this.Controls.Add(this.tbSupplierName);
            this.Controls.Add(this.lblSupplierAddress);
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
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.tbSellingPrice);
            this.Controls.Add(this.tbOriginalPrice);
            this.Controls.Add(this.btnUpdateSellingPrice);
            this.Controls.Add(this.lblSellingPrice);
            this.Controls.Add(this.lblOriginalPrice);
            this.Controls.Add(this.lblProductInfo);
            this.Name = "ProductDetailsForm";
            this.Text = "ProductDetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnUpdateSellingPrice;

        private System.Windows.Forms.TextBox tbSupplierEmail;

        private System.Windows.Forms.TextBox tbSupplierPhone;

        private System.Windows.Forms.Label lblSupplierEmail;
        private System.Windows.Forms.Label lblSupplierPhone;

        private System.Windows.Forms.Label lblProductInfo;

        private System.Windows.Forms.TextBox tbSellingPrice;

        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lblSupplierInFo;
        private System.Windows.Forms.TextBox tbSupplierAddress;
        private System.Windows.Forms.TextBox tbSupplierName;
        private System.Windows.Forms.Label lblSupplierAddress;
        private System.Windows.Forms.Label lblSupplierName;

        private System.Windows.Forms.Label lblDescription;

        private System.Windows.Forms.TextBox tbOriginalPrice;
        private System.Windows.Forms.Label lblOriginalPrice;
        private System.Windows.Forms.Label lblSellingPrice;
        private System.Windows.Forms.TextBox tbPhasingOut;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblPhasingOut;
        private System.Windows.Forms.TextBox tbReorderLevel;
        private System.Windows.Forms.Label lblReorderLevel;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label lblQuantity;

        private System.Windows.Forms.Button btnGoodsReceivedNote;

        #endregion
    }
}
namespace Better_Limited_Project.Sales.OrderPlacing
{
    partial class SalesOrderDetailsForm
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
            this.lblOrderInfo = new System.Windows.Forms.Label();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.lblAmtDue = new System.Windows.Forms.Label();
            this.lblAmtPaid = new System.Windows.Forms.Label();
            this.lblNeedDelivery = new System.Windows.Forms.Label();
            this.lblNeedInstallation = new System.Windows.Forms.Label();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.txtAmtDue = new System.Windows.Forms.TextBox();
            this.txtAmtPaid = new System.Windows.Forms.TextBox();
            this.txtNeedDelivery = new System.Windows.Forms.TextBox();
            this.txtNeedInstallation = new System.Windows.Forms.TextBox();
            this.lblCustInfo = new System.Windows.Forms.Label();
            this.txtCustPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.lblCustomerPhoneNumber = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblDeliveryInfo = new System.Windows.Forms.Label();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.BtnPaymentReceipt = new System.Windows.Forms.Button();
            this.btnSettleIncompletePayment = new System.Windows.Forms.Button();
            this.btnViewOrderedProducts = new System.Windows.Forms.Button();
            this.txtCustEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.dgvProductsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductsIsOutOfStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductsCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductsPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductsQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductsSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrderInfo
            // 
            this.lblOrderInfo.AutoSize = true;
            this.lblOrderInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderInfo.Location = new System.Drawing.Point(51, 46);
            this.lblOrderInfo.Name = "lblOrderInfo";
            this.lblOrderInfo.Size = new System.Drawing.Size(91, 20);
            this.lblOrderInfo.TabIndex = 0;
            this.lblOrderInfo.Text = "Order Info";
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNumber.Location = new System.Drawing.Point(37, 97);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(96, 16);
            this.lblOrderNumber.TabIndex = 1;
            this.lblOrderNumber.Text = "Order Number:";
            // 
            // lblAmtDue
            // 
            this.lblAmtDue.AutoSize = true;
            this.lblAmtDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmtDue.Location = new System.Drawing.Point(49, 148);
            this.lblAmtDue.Name = "lblAmtDue";
            this.lblAmtDue.Size = new System.Drawing.Size(84, 16);
            this.lblAmtDue.TabIndex = 2;
            this.lblAmtDue.Text = "Amount Due:";
            // 
            // lblAmtPaid
            // 
            this.lblAmtPaid.AutoSize = true;
            this.lblAmtPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmtPaid.Location = new System.Drawing.Point(44, 201);
            this.lblAmtPaid.Name = "lblAmtPaid";
            this.lblAmtPaid.Size = new System.Drawing.Size(87, 16);
            this.lblAmtPaid.TabIndex = 3;
            this.lblAmtPaid.Text = "Amount Paid:";
            // 
            // lblNeedDelivery
            // 
            this.lblNeedDelivery.AutoSize = true;
            this.lblNeedDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeedDelivery.Location = new System.Drawing.Point(33, 264);
            this.lblNeedDelivery.Name = "lblNeedDelivery";
            this.lblNeedDelivery.Size = new System.Drawing.Size(98, 16);
            this.lblNeedDelivery.TabIndex = 4;
            this.lblNeedDelivery.Text = "Need Delivery:";
            // 
            // lblNeedInstallation
            // 
            this.lblNeedInstallation.AutoSize = true;
            this.lblNeedInstallation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeedInstallation.Location = new System.Drawing.Point(22, 312);
            this.lblNeedInstallation.Name = "lblNeedInstallation";
            this.lblNeedInstallation.Size = new System.Drawing.Size(111, 16);
            this.lblNeedInstallation.TabIndex = 5;
            this.lblNeedInstallation.Text = "Need Installation:";
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Location = new System.Drawing.Point(137, 96);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.ReadOnly = true;
            this.txtOrderNumber.Size = new System.Drawing.Size(127, 20);
            this.txtOrderNumber.TabIndex = 6;
            this.txtOrderNumber.Text = "-";
            // 
            // txtAmtDue
            // 
            this.txtAmtDue.Location = new System.Drawing.Point(137, 147);
            this.txtAmtDue.Name = "txtAmtDue";
            this.txtAmtDue.ReadOnly = true;
            this.txtAmtDue.Size = new System.Drawing.Size(100, 20);
            this.txtAmtDue.TabIndex = 7;
            this.txtAmtDue.Text = "-";
            // 
            // txtAmtPaid
            // 
            this.txtAmtPaid.Location = new System.Drawing.Point(137, 200);
            this.txtAmtPaid.Name = "txtAmtPaid";
            this.txtAmtPaid.ReadOnly = true;
            this.txtAmtPaid.Size = new System.Drawing.Size(100, 20);
            this.txtAmtPaid.TabIndex = 8;
            this.txtAmtPaid.Text = "-";
            // 
            // txtNeedDelivery
            // 
            this.txtNeedDelivery.Location = new System.Drawing.Point(137, 263);
            this.txtNeedDelivery.Name = "txtNeedDelivery";
            this.txtNeedDelivery.ReadOnly = true;
            this.txtNeedDelivery.Size = new System.Drawing.Size(55, 20);
            this.txtNeedDelivery.TabIndex = 9;
            this.txtNeedDelivery.Text = "-";
            // 
            // txtNeedInstallation
            // 
            this.txtNeedInstallation.Location = new System.Drawing.Point(137, 311);
            this.txtNeedInstallation.Name = "txtNeedInstallation";
            this.txtNeedInstallation.ReadOnly = true;
            this.txtNeedInstallation.Size = new System.Drawing.Size(55, 20);
            this.txtNeedInstallation.TabIndex = 11;
            this.txtNeedInstallation.Text = "-";
            // 
            // lblCustInfo
            // 
            this.lblCustInfo.AutoSize = true;
            this.lblCustInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustInfo.Location = new System.Drawing.Point(315, 46);
            this.lblCustInfo.Name = "lblCustInfo";
            this.lblCustInfo.Size = new System.Drawing.Size(123, 20);
            this.lblCustInfo.TabIndex = 12;
            this.lblCustInfo.Text = "Customer Info";
            // 
            // txtCustPhoneNumber
            // 
            this.txtCustPhoneNumber.Location = new System.Drawing.Point(363, 159);
            this.txtCustPhoneNumber.Name = "txtCustPhoneNumber";
            this.txtCustPhoneNumber.ReadOnly = true;
            this.txtCustPhoneNumber.Size = new System.Drawing.Size(132, 20);
            this.txtCustPhoneNumber.TabIndex = 18;
            this.txtCustPhoneNumber.Text = "-";
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(363, 106);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.ReadOnly = true;
            this.txtCustName.Size = new System.Drawing.Size(132, 20);
            this.txtCustName.TabIndex = 17;
            this.txtCustName.Text = "-";
            // 
            // lblCustomerPhoneNumber
            // 
            this.lblCustomerPhoneNumber.AutoSize = true;
            this.lblCustomerPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerPhoneNumber.Location = new System.Drawing.Point(283, 160);
            this.lblCustomerPhoneNumber.Name = "lblCustomerPhoneNumber";
            this.lblCustomerPhoneNumber.Size = new System.Drawing.Size(74, 16);
            this.lblCustomerPhoneNumber.TabIndex = 15;
            this.lblCustomerPhoneNumber.Text = "Phone No.:";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustName.Location = new System.Drawing.Point(309, 107);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(48, 16);
            this.lblCustName.TabIndex = 14;
            this.lblCustName.Text = "Name:";
            // 
            // lblDeliveryInfo
            // 
            this.lblDeliveryInfo.AutoSize = true;
            this.lblDeliveryInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryInfo.Location = new System.Drawing.Point(533, 46);
            this.lblDeliveryInfo.Name = "lblDeliveryInfo";
            this.lblDeliveryInfo.Size = new System.Drawing.Size(109, 20);
            this.lblDeliveryInfo.TabIndex = 19;
            this.lblDeliveryInfo.Text = "Delivery Info";
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(536, 207);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.ReadOnly = true;
            this.txtAddress2.Size = new System.Drawing.Size(248, 20);
            this.txtAddress2.TabIndex = 83;
            this.txtAddress2.Text = "-";
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress2.Location = new System.Drawing.Point(534, 174);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(64, 15);
            this.lblAddress2.TabIndex = 82;
            this.lblAddress2.Text = "Address 2:";
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(536, 129);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.ReadOnly = true;
            this.txtAddress1.Size = new System.Drawing.Size(248, 20);
            this.txtAddress1.TabIndex = 81;
            this.txtAddress1.Text = "-";
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress1.Location = new System.Drawing.Point(534, 96);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(64, 15);
            this.lblAddress1.TabIndex = 80;
            this.lblAddress1.Text = "Address 1:";
            // 
            // BtnPaymentReceipt
            // 
            this.BtnPaymentReceipt.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnPaymentReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPaymentReceipt.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnPaymentReceipt.Location = new System.Drawing.Point(127, 363);
            this.BtnPaymentReceipt.Name = "BtnPaymentReceipt";
            this.BtnPaymentReceipt.Size = new System.Drawing.Size(129, 54);
            this.BtnPaymentReceipt.TabIndex = 84;
            this.BtnPaymentReceipt.Text = "Payment Receipt";
            this.BtnPaymentReceipt.UseVisualStyleBackColor = false;
            this.BtnPaymentReceipt.Click += new System.EventHandler(this.BtnPaymentReceipt_Click);
            // 
            // btnSettleIncompletePayment
            // 
            this.btnSettleIncompletePayment.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSettleIncompletePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettleIncompletePayment.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSettleIncompletePayment.Location = new System.Drawing.Point(329, 363);
            this.btnSettleIncompletePayment.Name = "btnSettleIncompletePayment";
            this.btnSettleIncompletePayment.Size = new System.Drawing.Size(185, 54);
            this.btnSettleIncompletePayment.TabIndex = 85;
            this.btnSettleIncompletePayment.Text = "Settle Incomplete Payment";
            this.btnSettleIncompletePayment.UseVisualStyleBackColor = false;
            // 
            // btnViewOrderedProducts
            // 
            this.btnViewOrderedProducts.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnViewOrderedProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrderedProducts.ForeColor = System.Drawing.SystemColors.Window;
            this.btnViewOrderedProducts.Location = new System.Drawing.Point(572, 363);
            this.btnViewOrderedProducts.Name = "btnViewOrderedProducts";
            this.btnViewOrderedProducts.Size = new System.Drawing.Size(188, 54);
            this.btnViewOrderedProducts.TabIndex = 86;
            this.btnViewOrderedProducts.Text = "View Ordered Products";
            this.btnViewOrderedProducts.UseVisualStyleBackColor = false;
            // 
            // txtCustEmail
            // 
            this.txtCustEmail.Location = new System.Drawing.Point(363, 212);
            this.txtCustEmail.Name = "txtCustEmail";
            this.txtCustEmail.ReadOnly = true;
            this.txtCustEmail.Size = new System.Drawing.Size(132, 20);
            this.txtCustEmail.TabIndex = 108;
            this.txtCustEmail.Text = "-";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(312, 213);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 16);
            this.lblEmail.TabIndex = 107;
            this.lblEmail.Text = "Email:";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvProductsName,
            this.dgvProductsIsOutOfStock,
            this.dgvProductsCategory,
            this.dgvProductsPrice,
            this.dgvProductsQuantity,
            this.dgvProductsSubtotal});
            this.dgvProducts.Location = new System.Drawing.Point(329, 248);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.Size = new System.Drawing.Size(431, 93);
            this.dgvProducts.TabIndex = 109;
            // 
            // dgvProductsName
            // 
            this.dgvProductsName.HeaderText = "Name";
            this.dgvProductsName.Name = "dgvProductsName";
            this.dgvProductsName.ReadOnly = true;
            // 
            // dgvProductsIsOutOfStock
            // 
            this.dgvProductsIsOutOfStock.HeaderText = "Is Out of Stock";
            this.dgvProductsIsOutOfStock.Name = "dgvProductsIsOutOfStock";
            this.dgvProductsIsOutOfStock.ReadOnly = true;
            // 
            // dgvProductsCategory
            // 
            this.dgvProductsCategory.HeaderText = "Category";
            this.dgvProductsCategory.Name = "dgvProductsCategory";
            this.dgvProductsCategory.ReadOnly = true;
            // 
            // dgvProductsPrice
            // 
            this.dgvProductsPrice.HeaderText = "Price";
            this.dgvProductsPrice.Name = "dgvProductsPrice";
            this.dgvProductsPrice.ReadOnly = true;
            // 
            // dgvProductsQuantity
            // 
            this.dgvProductsQuantity.HeaderText = "Qty";
            this.dgvProductsQuantity.Name = "dgvProductsQuantity";
            this.dgvProductsQuantity.ReadOnly = true;
            // 
            // dgvProductsSubtotal
            // 
            this.dgvProductsSubtotal.HeaderText = "Subtotal";
            this.dgvProductsSubtotal.Name = "dgvProductsSubtotal";
            this.dgvProductsSubtotal.ReadOnly = true;
            // 
            // SalesOrderDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.txtCustEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnViewOrderedProducts);
            this.Controls.Add(this.btnSettleIncompletePayment);
            this.Controls.Add(this.BtnPaymentReceipt);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.lblAddress2);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.lblAddress1);
            this.Controls.Add(this.lblDeliveryInfo);
            this.Controls.Add(this.txtCustPhoneNumber);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.lblCustomerPhoneNumber);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.lblCustInfo);
            this.Controls.Add(this.txtNeedInstallation);
            this.Controls.Add(this.txtNeedDelivery);
            this.Controls.Add(this.txtAmtPaid);
            this.Controls.Add(this.txtAmtDue);
            this.Controls.Add(this.txtOrderNumber);
            this.Controls.Add(this.lblNeedInstallation);
            this.Controls.Add(this.lblNeedDelivery);
            this.Controls.Add(this.lblAmtPaid);
            this.Controls.Add(this.lblAmtDue);
            this.Controls.Add(this.lblOrderNumber);
            this.Controls.Add(this.lblOrderInfo);
            this.Name = "SalesOrderDetailsForm";
            this.Text = "-";
            this.Shown += new System.EventHandler(this.OnFormShown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnViewOrderedProducts;

        #endregion

        private System.Windows.Forms.Label lblOrderInfo;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.Label lblAmtDue;
        private System.Windows.Forms.Label lblAmtPaid;
        private System.Windows.Forms.Label lblNeedDelivery;
        private System.Windows.Forms.Label lblNeedInstallation;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.TextBox txtAmtDue;
        private System.Windows.Forms.TextBox txtAmtPaid;
        private System.Windows.Forms.TextBox txtNeedDelivery;
        private System.Windows.Forms.TextBox txtNeedInstallation;
        private System.Windows.Forms.Label lblCustInfo;
        private System.Windows.Forms.TextBox txtCustPhoneNumber;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label lblCustomerPhoneNumber;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblDeliveryInfo;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.Button BtnPaymentReceipt;
        private System.Windows.Forms.Button btnSettleIncompletePayment;
        private System.Windows.Forms.TextBox txtCustEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductsIsOutOfStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductsCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductsPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductsQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductsSubtotal;
    }
}
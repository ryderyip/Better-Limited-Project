namespace Better_Limited_Project.Sales.OrderPlacing.UI
{
    partial class ConfirmPlacingOrderForm
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
            this.lblCustomerInfo = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblCustEmailAddress = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtCustEmailAddress = new System.Windows.Forms.TextBox();
            this.lblDeliveryInfo = new System.Windows.Forms.Label();
            this.lblCustPhoneNumber = new System.Windows.Forms.Label();
            this.txtCustPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.tbAmountDue = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.lblHeader = new System.Windows.Forms.Label();
            this.tbPriceToPayWhenStockReplenished = new System.Windows.Forms.TextBox();
            this.lblPriceToPayWhenStockReplenished = new System.Windows.Forms.Label();
            this.panDepositPrice = new System.Windows.Forms.Panel();
            this.lblOutOfStock = new System.Windows.Forms.Label();
            this.outOfStockRectangle = new System.Windows.Forms.Button();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.panDepositPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCustomerInfo
            // 
            this.lblCustomerInfo.AutoSize = true;
            this.lblCustomerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerInfo.Location = new System.Drawing.Point(42, 87);
            this.lblCustomerInfo.Name = "lblCustomerInfo";
            this.lblCustomerInfo.Size = new System.Drawing.Size(123, 20);
            this.lblCustomerInfo.TabIndex = 58;
            this.lblCustomerInfo.Text = "Customer Info";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustName.Location = new System.Drawing.Point(70, 127);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(44, 15);
            this.lblCustName.TabIndex = 60;
            this.lblCustName.Text = "Name:";
            // 
            // lblCustEmailAddress
            // 
            this.lblCustEmailAddress.AutoSize = true;
            this.lblCustEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustEmailAddress.Location = new System.Drawing.Point(25, 212);
            this.lblCustEmailAddress.Name = "lblCustEmailAddress";
            this.lblCustEmailAddress.Size = new System.Drawing.Size(89, 15);
            this.lblCustEmailAddress.TabIndex = 61;
            this.lblCustEmailAddress.Text = "Email Address:";
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(127, 127);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.ReadOnly = true;
            this.txtCustName.Size = new System.Drawing.Size(100, 20);
            this.txtCustName.TabIndex = 63;
            this.txtCustName.Text = "-";
            // 
            // txtCustEmailAddress
            // 
            this.txtCustEmailAddress.Location = new System.Drawing.Point(127, 211);
            this.txtCustEmailAddress.Name = "txtCustEmailAddress";
            this.txtCustEmailAddress.ReadOnly = true;
            this.txtCustEmailAddress.Size = new System.Drawing.Size(200, 20);
            this.txtCustEmailAddress.TabIndex = 64;
            this.txtCustEmailAddress.Text = "-";
            // 
            // lblDeliveryInfo
            // 
            this.lblDeliveryInfo.AutoSize = true;
            this.lblDeliveryInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryInfo.Location = new System.Drawing.Point(42, 301);
            this.lblDeliveryInfo.Name = "lblDeliveryInfo";
            this.lblDeliveryInfo.Size = new System.Drawing.Size(109, 20);
            this.lblDeliveryInfo.TabIndex = 65;
            this.lblDeliveryInfo.Text = "Delivery Info";
            // 
            // lblCustPhoneNumber
            // 
            this.lblCustPhoneNumber.AutoSize = true;
            this.lblCustPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustPhoneNumber.Location = new System.Drawing.Point(20, 171);
            this.lblCustPhoneNumber.Name = "lblCustPhoneNumber";
            this.lblCustPhoneNumber.Size = new System.Drawing.Size(94, 15);
            this.lblCustPhoneNumber.TabIndex = 70;
            this.lblCustPhoneNumber.Text = "Phone Number:";
            // 
            // txtCustPhoneNumber
            // 
            this.txtCustPhoneNumber.Location = new System.Drawing.Point(127, 171);
            this.txtCustPhoneNumber.Name = "txtCustPhoneNumber";
            this.txtCustPhoneNumber.ReadOnly = true;
            this.txtCustPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtCustPhoneNumber.TabIndex = 71;
            this.txtCustPhoneNumber.Text = "-";
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress1.Location = new System.Drawing.Point(57, 341);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(64, 15);
            this.lblAddress1.TabIndex = 72;
            this.lblAddress1.Text = "Address 1:";
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(127, 341);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.ReadOnly = true;
            this.txtAddress1.Size = new System.Drawing.Size(241, 20);
            this.txtAddress1.TabIndex = 73;
            this.txtAddress1.Text = "-";
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress2.Location = new System.Drawing.Point(56, 380);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(64, 15);
            this.lblAddress2.TabIndex = 74;
            this.lblAddress2.Text = "Address 2:";
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(127, 380);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.ReadOnly = true;
            this.txtAddress2.Size = new System.Drawing.Size(241, 20);
            this.txtAddress2.TabIndex = 75;
            this.txtAddress2.Text = "-";
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountDue.Location = new System.Drawing.Point(550, 375);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(84, 16);
            this.lblAmountDue.TabIndex = 93;
            this.lblAmountDue.Text = "Amount Due:";
            // 
            // tbAmountDue
            // 
            this.tbAmountDue.Location = new System.Drawing.Point(640, 374);
            this.tbAmountDue.Name = "tbAmountDue";
            this.tbAmountDue.ReadOnly = true;
            this.tbAmountDue.Size = new System.Drawing.Size(124, 20);
            this.tbAmountDue.TabIndex = 94;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPay.Location = new System.Drawing.Point(623, 416);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(141, 51);
            this.btnPay.TabIndex = 106;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.priceColumn,
            this.quantityColumn,
            this.subtotalColumn});
            this.dgvProducts.Location = new System.Drawing.Point(381, 88);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.Size = new System.Drawing.Size(383, 198);
            this.dgvProducts.TabIndex = 107;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(263, 27);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(302, 31);
            this.lblHeader.TabIndex = 108;
            this.lblHeader.Text = "Confirm Placing Order";
            // 
            // tbPriceToPayWhenStockReplenished
            // 
            this.tbPriceToPayWhenStockReplenished.Location = new System.Drawing.Point(259, 25);
            this.tbPriceToPayWhenStockReplenished.Name = "tbPriceToPayWhenStockReplenished";
            this.tbPriceToPayWhenStockReplenished.ReadOnly = true;
            this.tbPriceToPayWhenStockReplenished.Size = new System.Drawing.Size(124, 20);
            this.tbPriceToPayWhenStockReplenished.TabIndex = 112;
            // 
            // lblPriceToPayWhenStockReplenished
            // 
            this.lblPriceToPayWhenStockReplenished.AutoSize = true;
            this.lblPriceToPayWhenStockReplenished.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceToPayWhenStockReplenished.Location = new System.Drawing.Point(148, 6);
            this.lblPriceToPayWhenStockReplenished.Name = "lblPriceToPayWhenStockReplenished";
            this.lblPriceToPayWhenStockReplenished.Size = new System.Drawing.Size(241, 16);
            this.lblPriceToPayWhenStockReplenished.TabIndex = 111;
            this.lblPriceToPayWhenStockReplenished.Text = "Price To Pay When Stock Replenished";
            // 
            // panDepositPrice
            // 
            this.panDepositPrice.Controls.Add(this.lblOutOfStock);
            this.panDepositPrice.Controls.Add(this.outOfStockRectangle);
            this.panDepositPrice.Controls.Add(this.tbPriceToPayWhenStockReplenished);
            this.panDepositPrice.Controls.Add(this.lblPriceToPayWhenStockReplenished);
            this.panDepositPrice.Location = new System.Drawing.Point(381, 301);
            this.panDepositPrice.Name = "panDepositPrice";
            this.panDepositPrice.Size = new System.Drawing.Size(395, 58);
            this.panDepositPrice.TabIndex = 113;
            // 
            // lblOutOfStock
            // 
            this.lblOutOfStock.AutoSize = true;
            this.lblOutOfStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutOfStock.Location = new System.Drawing.Point(36, 25);
            this.lblOutOfStock.Name = "lblOutOfStock";
            this.lblOutOfStock.Size = new System.Drawing.Size(96, 13);
            this.lblOutOfStock.TabIndex = 115;
            this.lblOutOfStock.Text = "= Deposit Payment";
            // 
            // outOfStockRectangle
            // 
            this.outOfStockRectangle.BackColor = System.Drawing.Color.SandyBrown;
            this.outOfStockRectangle.FlatAppearance.BorderSize = 0;
            this.outOfStockRectangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.outOfStockRectangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.outOfStockRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outOfStockRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outOfStockRectangle.ForeColor = System.Drawing.Color.Black;
            this.outOfStockRectangle.Location = new System.Drawing.Point(10, 22);
            this.outOfStockRectangle.Name = "outOfStockRectangle";
            this.outOfStockRectangle.Size = new System.Drawing.Size(20, 20);
            this.outOfStockRectangle.TabIndex = 114;
            this.outOfStockRectangle.UseVisualStyleBackColor = false;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // priceColumn
            // 
            this.priceColumn.HeaderText = "Price";
            this.priceColumn.Name = "priceColumn";
            this.priceColumn.ReadOnly = true;
            this.priceColumn.Width = 120;
            // 
            // quantityColumn
            // 
            this.quantityColumn.HeaderText = "Qty";
            this.quantityColumn.Name = "quantityColumn";
            this.quantityColumn.ReadOnly = true;
            this.quantityColumn.Width = 50;
            // 
            // subtotalColumn
            // 
            this.subtotalColumn.HeaderText = "Subtotal";
            this.subtotalColumn.Name = "subtotalColumn";
            this.subtotalColumn.ReadOnly = true;
            // 
            // ConfirmPlacingOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.panDepositPrice);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.tbAmountDue);
            this.Controls.Add(this.lblAmountDue);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.lblAddress2);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.lblAddress1);
            this.Controls.Add(this.txtCustPhoneNumber);
            this.Controls.Add(this.lblCustPhoneNumber);
            this.Controls.Add(this.lblDeliveryInfo);
            this.Controls.Add(this.txtCustEmailAddress);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.lblCustEmailAddress);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.lblCustomerInfo);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "ConfirmPlacingOrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.panDepositPrice.ResumeLayout(false);
            this.panDepositPrice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblCustomerInfo;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblCustEmailAddress;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.TextBox txtCustEmailAddress;
        private System.Windows.Forms.Label lblDeliveryInfo;
        private System.Windows.Forms.Label lblCustPhoneNumber;
        private System.Windows.Forms.TextBox txtCustPhoneNumber;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.TextBox tbAmountDue;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.DataGridView dgvProducts;

        #endregion
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox tbPriceToPayWhenStockReplenished;
        private System.Windows.Forms.Label lblPriceToPayWhenStockReplenished;
        private System.Windows.Forms.Panel panDepositPrice;
        private System.Windows.Forms.Label lblOutOfStock;
        private System.Windows.Forms.Button outOfStockRectangle;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalColumn;
    }
}
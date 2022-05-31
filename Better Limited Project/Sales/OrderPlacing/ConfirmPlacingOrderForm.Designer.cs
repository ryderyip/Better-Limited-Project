namespace Better_Limited_Project.Sales.OrderPlacing
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
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDepositColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomerInfo
            // 
            this.lblCustomerInfo.AutoSize = true;
            this.lblCustomerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerInfo.Location = new System.Drawing.Point(44, 89);
            this.lblCustomerInfo.Name = "lblCustomerInfo";
            this.lblCustomerInfo.Size = new System.Drawing.Size(123, 20);
            this.lblCustomerInfo.TabIndex = 58;
            this.lblCustomerInfo.Text = "Customer Info";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustName.Location = new System.Drawing.Point(72, 129);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(44, 15);
            this.lblCustName.TabIndex = 60;
            this.lblCustName.Text = "Name:";
            // 
            // lblCustEmailAddress
            // 
            this.lblCustEmailAddress.AutoSize = true;
            this.lblCustEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustEmailAddress.Location = new System.Drawing.Point(27, 214);
            this.lblCustEmailAddress.Name = "lblCustEmailAddress";
            this.lblCustEmailAddress.Size = new System.Drawing.Size(89, 15);
            this.lblCustEmailAddress.TabIndex = 61;
            this.lblCustEmailAddress.Text = "Email Address:";
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(129, 129);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.ReadOnly = true;
            this.txtCustName.Size = new System.Drawing.Size(100, 20);
            this.txtCustName.TabIndex = 63;
            this.txtCustName.Text = "-";
            // 
            // txtCustEmailAddress
            // 
            this.txtCustEmailAddress.Location = new System.Drawing.Point(129, 213);
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
            this.lblDeliveryInfo.Location = new System.Drawing.Point(44, 280);
            this.lblDeliveryInfo.Name = "lblDeliveryInfo";
            this.lblDeliveryInfo.Size = new System.Drawing.Size(109, 20);
            this.lblDeliveryInfo.TabIndex = 65;
            this.lblDeliveryInfo.Text = "Delivery Info";
            // 
            // lblCustPhoneNumber
            // 
            this.lblCustPhoneNumber.AutoSize = true;
            this.lblCustPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustPhoneNumber.Location = new System.Drawing.Point(22, 173);
            this.lblCustPhoneNumber.Name = "lblCustPhoneNumber";
            this.lblCustPhoneNumber.Size = new System.Drawing.Size(94, 15);
            this.lblCustPhoneNumber.TabIndex = 70;
            this.lblCustPhoneNumber.Text = "Phone Number:";
            // 
            // txtCustPhoneNumber
            // 
            this.txtCustPhoneNumber.Location = new System.Drawing.Point(129, 173);
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
            this.lblAddress1.Location = new System.Drawing.Point(59, 320);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(64, 15);
            this.lblAddress1.TabIndex = 72;
            this.lblAddress1.Text = "Address 1:";
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(129, 320);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.ReadOnly = true;
            this.txtAddress1.Size = new System.Drawing.Size(257, 20);
            this.txtAddress1.TabIndex = 73;
            this.txtAddress1.Text = "-";
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress2.Location = new System.Drawing.Point(58, 359);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(64, 15);
            this.lblAddress2.TabIndex = 74;
            this.lblAddress2.Text = "Address 2:";
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(129, 359);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.ReadOnly = true;
            this.txtAddress2.Size = new System.Drawing.Size(257, 20);
            this.txtAddress2.TabIndex = 75;
            this.txtAddress2.Text = "-";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(566, 343);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(76, 16);
            this.lblTotalPrice.TabIndex = 93;
            this.lblTotalPrice.Text = "Total Price:";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(648, 342);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPrice.TabIndex = 94;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPay.Location = new System.Drawing.Point(607, 404);
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
            this.isDepositColumn,
            this.subtotalColumn});
            this.dgvProducts.Location = new System.Drawing.Point(408, 89);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.Size = new System.Drawing.Size(340, 225);
            this.dgvProducts.TabIndex = 107;
            // 
            // name
            // 
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // price
            // 
            this.priceColumn.HeaderText = "Price";
            this.priceColumn.Name = "priceColumn";
            this.priceColumn.ReadOnly = true;
            this.priceColumn.Width = 90;
            // 
            // quantity
            // 
            this.quantityColumn.HeaderText = "Qty";
            this.quantityColumn.Name = "quantityColumn";
            this.quantityColumn.ReadOnly = true;
            this.quantityColumn.Width = 50;
            // 
            // isDeposit
            // 
            this.isDepositColumn.HeaderText = "Is Deposit";
            this.isDepositColumn.Name = "isDepositColumn";
            this.isDepositColumn.ReadOnly = true;
            this.isDepositColumn.Width = 90;
            // 
            // subtotal
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
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.lblTotalPrice);
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
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.DataGridView dgvProducts;

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isDepositColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDue;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalColumn;
    }
}
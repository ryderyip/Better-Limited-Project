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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmPlacingOrderForm));
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
            resources.ApplyResources(this.lblCustomerInfo, "lblCustomerInfo");
            this.lblCustomerInfo.Name = "lblCustomerInfo";
            // 
            // lblCustName
            // 
            resources.ApplyResources(this.lblCustName, "lblCustName");
            this.lblCustName.Name = "lblCustName";
            // 
            // lblCustEmailAddress
            // 
            resources.ApplyResources(this.lblCustEmailAddress, "lblCustEmailAddress");
            this.lblCustEmailAddress.Name = "lblCustEmailAddress";
            // 
            // txtCustName
            // 
            resources.ApplyResources(this.txtCustName, "txtCustName");
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.ReadOnly = true;
            // 
            // txtCustEmailAddress
            // 
            resources.ApplyResources(this.txtCustEmailAddress, "txtCustEmailAddress");
            this.txtCustEmailAddress.Name = "txtCustEmailAddress";
            this.txtCustEmailAddress.ReadOnly = true;
            // 
            // lblDeliveryInfo
            // 
            resources.ApplyResources(this.lblDeliveryInfo, "lblDeliveryInfo");
            this.lblDeliveryInfo.Name = "lblDeliveryInfo";
            // 
            // lblCustPhoneNumber
            // 
            resources.ApplyResources(this.lblCustPhoneNumber, "lblCustPhoneNumber");
            this.lblCustPhoneNumber.Name = "lblCustPhoneNumber";
            // 
            // txtCustPhoneNumber
            // 
            resources.ApplyResources(this.txtCustPhoneNumber, "txtCustPhoneNumber");
            this.txtCustPhoneNumber.Name = "txtCustPhoneNumber";
            this.txtCustPhoneNumber.ReadOnly = true;
            // 
            // lblAddress1
            // 
            resources.ApplyResources(this.lblAddress1, "lblAddress1");
            this.lblAddress1.Name = "lblAddress1";
            // 
            // txtAddress1
            // 
            resources.ApplyResources(this.txtAddress1, "txtAddress1");
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.ReadOnly = true;
            // 
            // lblAddress2
            // 
            resources.ApplyResources(this.lblAddress2, "lblAddress2");
            this.lblAddress2.Name = "lblAddress2";
            // 
            // txtAddress2
            // 
            resources.ApplyResources(this.txtAddress2, "txtAddress2");
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.ReadOnly = true;
            // 
            // lblAmountDue
            // 
            resources.ApplyResources(this.lblAmountDue, "lblAmountDue");
            this.lblAmountDue.Name = "lblAmountDue";
            // 
            // tbAmountDue
            // 
            resources.ApplyResources(this.tbAmountDue, "tbAmountDue");
            this.tbAmountDue.Name = "tbAmountDue";
            this.tbAmountDue.ReadOnly = true;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.DarkOrange;
            resources.ApplyResources(this.btnPay, "btnPay");
            this.btnPay.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPay.Name = "btnPay";
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
            resources.ApplyResources(this.dgvProducts, "dgvProducts");
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            // 
            // lblHeader
            // 
            resources.ApplyResources(this.lblHeader, "lblHeader");
            this.lblHeader.Name = "lblHeader";
            // 
            // tbPriceToPayWhenStockReplenished
            // 
            resources.ApplyResources(this.tbPriceToPayWhenStockReplenished, "tbPriceToPayWhenStockReplenished");
            this.tbPriceToPayWhenStockReplenished.Name = "tbPriceToPayWhenStockReplenished";
            this.tbPriceToPayWhenStockReplenished.ReadOnly = true;
            // 
            // lblPriceToPayWhenStockReplenished
            // 
            resources.ApplyResources(this.lblPriceToPayWhenStockReplenished, "lblPriceToPayWhenStockReplenished");
            this.lblPriceToPayWhenStockReplenished.Name = "lblPriceToPayWhenStockReplenished";
            // 
            // panDepositPrice
            // 
            this.panDepositPrice.Controls.Add(this.lblOutOfStock);
            this.panDepositPrice.Controls.Add(this.outOfStockRectangle);
            this.panDepositPrice.Controls.Add(this.tbPriceToPayWhenStockReplenished);
            this.panDepositPrice.Controls.Add(this.lblPriceToPayWhenStockReplenished);
            resources.ApplyResources(this.panDepositPrice, "panDepositPrice");
            this.panDepositPrice.Name = "panDepositPrice";
            // 
            // lblOutOfStock
            // 
            resources.ApplyResources(this.lblOutOfStock, "lblOutOfStock");
            this.lblOutOfStock.Name = "lblOutOfStock";
            // 
            // outOfStockRectangle
            // 
            this.outOfStockRectangle.BackColor = System.Drawing.Color.SandyBrown;
            this.outOfStockRectangle.FlatAppearance.BorderSize = 0;
            this.outOfStockRectangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.outOfStockRectangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            resources.ApplyResources(this.outOfStockRectangle, "outOfStockRectangle");
            this.outOfStockRectangle.ForeColor = System.Drawing.Color.Black;
            this.outOfStockRectangle.Name = "outOfStockRectangle";
            this.outOfStockRectangle.UseVisualStyleBackColor = false;
            // 
            // nameColumn
            // 
            resources.ApplyResources(this.nameColumn, "nameColumn");
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // priceColumn
            // 
            resources.ApplyResources(this.priceColumn, "priceColumn");
            this.priceColumn.Name = "priceColumn";
            this.priceColumn.ReadOnly = true;
            // 
            // quantityColumn
            // 
            resources.ApplyResources(this.quantityColumn, "quantityColumn");
            this.quantityColumn.Name = "quantityColumn";
            this.quantityColumn.ReadOnly = true;
            // 
            // subtotalColumn
            // 
            resources.ApplyResources(this.subtotalColumn, "subtotalColumn");
            this.subtotalColumn.Name = "subtotalColumn";
            this.subtotalColumn.ReadOnly = true;
            // 
            // ConfirmPlacingOrderForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
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
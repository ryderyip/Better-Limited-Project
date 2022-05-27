namespace Better_Limited_Project.Sales.OrderPlacing
{
    partial class SalesOrderListForm
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
            this.dgvSalesOrders = new System.Windows.Forms.DataGridView();
            this.dtpSearchDate = new System.Windows.Forms.DateTimePicker();
            this.tbSearchBox = new System.Windows.Forms.TextBox();
            this.lblSearchBox = new System.Windows.Forms.Label();
            this.cbEnableSearchByDate = new System.Windows.Forms.CheckBox();
            this.salesOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retailStoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdByStaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSalesOrders
            // 
            this.dgvSalesOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salesOrderId,
            this.customerName,
            this.customerPhone,
            this.amount,
            this.createdOn,
            this.retailStoreName,
            this.createdByStaffName});
            this.dgvSalesOrders.Location = new System.Drawing.Point(27, 100);
            this.dgvSalesOrders.Name = "dgvSalesOrders";
            this.dgvSalesOrders.RowTemplate.Height = 24;
            this.dgvSalesOrders.Size = new System.Drawing.Size(536, 327);
            this.dgvSalesOrders.TabIndex = 51;
            // 
            // dtpSearchDate
            // 
            this.dtpSearchDate.Enabled = false;
            this.dtpSearchDate.Location = new System.Drawing.Point(331, 49);
            this.dtpSearchDate.Name = "dtpSearchDate";
            this.dtpSearchDate.Size = new System.Drawing.Size(200, 20);
            this.dtpSearchDate.TabIndex = 50;
            this.dtpSearchDate.ValueChanged += new System.EventHandler(this.dtpSearchDate_ValueChanged);
            // 
            // tbSearchBox
            // 
            this.tbSearchBox.Location = new System.Drawing.Point(27, 49);
            this.tbSearchBox.Name = "tbSearchBox";
            this.tbSearchBox.Size = new System.Drawing.Size(192, 20);
            this.tbSearchBox.TabIndex = 48;
            this.tbSearchBox.TextChanged += new System.EventHandler(this.tbSearchBox_TextChanged);
            // 
            // lblSearchBox
            // 
            this.lblSearchBox.AutoSize = true;
            this.lblSearchBox.Location = new System.Drawing.Point(25, 22);
            this.lblSearchBox.Name = "lblSearchBox";
            this.lblSearchBox.Size = new System.Drawing.Size(263, 13);
            this.lblSearchBox.TabIndex = 47;
            this.lblSearchBox.Text = "Search by Sales Order ID/Customer Name/Phone No.";
            // 
            // cbEnableSearchByDate
            // 
            this.cbEnableSearchByDate.AutoSize = true;
            this.cbEnableSearchByDate.Location = new System.Drawing.Point(331, 21);
            this.cbEnableSearchByDate.Name = "cbEnableSearchByDate";
            this.cbEnableSearchByDate.Size = new System.Drawing.Size(176, 17);
            this.cbEnableSearchByDate.TabIndex = 52;
            this.cbEnableSearchByDate.Text = "Enable Search by Date Created";
            this.cbEnableSearchByDate.UseVisualStyleBackColor = true;
            this.cbEnableSearchByDate.CheckedChanged += new System.EventHandler(this.cbEnableSearchByDate_CheckedChanged);
            // 
            // salesOrderId
            // 
            this.salesOrderId.HeaderText = "Order ID";
            this.salesOrderId.Name = "salesOrderId";
            this.salesOrderId.ReadOnly = true;
            this.salesOrderId.Width = 130;
            // 
            // customerName
            // 
            this.customerName.HeaderText = "Customer Name";
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            // 
            // customerPhone
            // 
            this.customerPhone.HeaderText = "Customer Phone No.";
            this.customerPhone.Name = "customerPhone";
            this.customerPhone.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.Width = 80;
            // 
            // createdOn
            // 
            this.createdOn.HeaderText = "Created On";
            this.createdOn.Name = "createdOn";
            this.createdOn.ReadOnly = true;
            // 
            // retailStoreName
            // 
            this.retailStoreName.HeaderText = "Retail Store Name";
            this.retailStoreName.Name = "retailStoreName";
            this.retailStoreName.ReadOnly = true;
            this.retailStoreName.Width = 120;
            // 
            // createdByStaffName
            // 
            this.createdByStaffName.HeaderText = "Created By Staff";
            this.createdByStaffName.Name = "createdByStaffName";
            this.createdByStaffName.ReadOnly = true;
            // 
            // SalesOrderListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 449);
            this.Controls.Add(this.cbEnableSearchByDate);
            this.Controls.Add(this.dgvSalesOrders);
            this.Controls.Add(this.dtpSearchDate);
            this.Controls.Add(this.tbSearchBox);
            this.Controls.Add(this.lblSearchBox);
            this.Name = "SalesOrderListForm";
            this.Text = "SalesOrderForm";
            this.Shown += new System.EventHandler(this.OnFormShown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSalesOrders;
        private System.Windows.Forms.DateTimePicker dtpSearchDate;
        private System.Windows.Forms.TextBox tbSearchBox;
        private System.Windows.Forms.Label lblSearchBox;
        private System.Windows.Forms.CheckBox cbEnableSearchByDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn retailStoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdByStaffName;
    }
}
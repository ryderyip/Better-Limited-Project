namespace Better_Limited_Project.Sales.OrderPlacing.UI
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
            this.salesOrderNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPhoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdOnColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retailStoreNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdByStaffNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSalesOrders
            // 
            this.dgvSalesOrders.AllowUserToAddRows = false;
            this.dgvSalesOrders.AllowUserToDeleteRows = false;
            this.dgvSalesOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salesOrderNumberColumn,
            this.customerNameColumn,
            this.customerPhoneColumn,
            this.amountColumn,
            this.createdOnColumn,
            this.retailStoreNameColumn,
            this.createdByStaffNameColumn});
            this.dgvSalesOrders.Location = new System.Drawing.Point(27, 100);
            this.dgvSalesOrders.Name = "dgvSalesOrders";
            this.dgvSalesOrders.ReadOnly = true;
            this.dgvSalesOrders.RowTemplate.Height = 24;
            this.dgvSalesOrders.Size = new System.Drawing.Size(536, 327);
            this.dgvSalesOrders.TabIndex = 51;
            this.dgvSalesOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesOrders_CellDoubleClick);
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
            this.lblSearchBox.Size = new System.Drawing.Size(240, 13);
            this.lblSearchBox.TabIndex = 47;
            this.lblSearchBox.Text = "Search by Order No./Customer Name/Phone No.";
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
            // salesOrderNumberColumn
            // 
            this.salesOrderNumberColumn.HeaderText = "Order Number";
            this.salesOrderNumberColumn.Name = "salesOrderNumberColumn";
            this.salesOrderNumberColumn.ReadOnly = true;
            this.salesOrderNumberColumn.Width = 130;
            // 
            // customerNameColumn
            // 
            this.customerNameColumn.HeaderText = "Customer Name";
            this.customerNameColumn.Name = "customerNameColumn";
            this.customerNameColumn.ReadOnly = true;
            // 
            // customerPhoneColumn
            // 
            this.customerPhoneColumn.HeaderText = "Customer Phone No.";
            this.customerPhoneColumn.Name = "customerPhoneColumn";
            this.customerPhoneColumn.ReadOnly = true;
            // 
            // amountColumn
            // 
            this.amountColumn.HeaderText = "Amount";
            this.amountColumn.Name = "amountColumn";
            this.amountColumn.ReadOnly = true;
            this.amountColumn.Width = 80;
            // 
            // createdOnColumn
            // 
            this.createdOnColumn.HeaderText = "Created On";
            this.createdOnColumn.Name = "createdOnColumn";
            this.createdOnColumn.ReadOnly = true;
            // 
            // retailStoreNameColumn
            // 
            this.retailStoreNameColumn.HeaderText = "Retail Store Name";
            this.retailStoreNameColumn.Name = "retailStoreNameColumn";
            this.retailStoreNameColumn.ReadOnly = true;
            this.retailStoreNameColumn.Width = 120;
            // 
            // createdByStaffNameColumn
            // 
            this.createdByStaffNameColumn.HeaderText = "Created By Staff";
            this.createdByStaffNameColumn.Name = "createdByStaffNameColumn";
            this.createdByStaffNameColumn.ReadOnly = true;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn salesOrderNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdOnColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn retailStoreNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdByStaffNameColumn;
    }
}

namespace Better_Limited_Project.ProductUtility.PickerForms
{
    partial class SalesOrderPickerForm
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
            this.cbEnableSearchByDate = new System.Windows.Forms.CheckBox();
            this.dtpSearchDate = new System.Windows.Forms.DateTimePicker();
            this.tbSearchBox = new System.Windows.Forms.TextBox();
            this.lblSearchBox = new System.Windows.Forms.Label();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesOrderNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPhoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerEmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdOnColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSalesOrders
            // 
            this.dgvSalesOrders.AllowUserToAddRows = false;
            this.dgvSalesOrders.AllowUserToDeleteRows = false;
            this.dgvSalesOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.salesOrderNumberColumn,
            this.customerNameColumn,
            this.customerPhoneColumn,
            this.customerEmailColumn,
            this.createdOnColumn,
            this.amountColumn});
            this.dgvSalesOrders.Location = new System.Drawing.Point(28, 95);
            this.dgvSalesOrders.Name = "dgvSalesOrders";
            this.dgvSalesOrders.ReadOnly = true;
            this.dgvSalesOrders.RowTemplate.Height = 24;
            this.dgvSalesOrders.Size = new System.Drawing.Size(723, 327);
            this.dgvSalesOrders.TabIndex = 52;
            this.dgvSalesOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesOrders_CellDoubleClick);
            // 
            // cbEnableSearchByDate
            // 
            this.cbEnableSearchByDate.AutoSize = true;
            this.cbEnableSearchByDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbEnableSearchByDate.Location = new System.Drawing.Point(393, 28);
            this.cbEnableSearchByDate.Name = "cbEnableSearchByDate";
            this.cbEnableSearchByDate.Size = new System.Drawing.Size(176, 17);
            this.cbEnableSearchByDate.TabIndex = 56;
            this.cbEnableSearchByDate.Text = "Enable Search by Date Created";
            this.cbEnableSearchByDate.UseVisualStyleBackColor = true;
            this.cbEnableSearchByDate.CheckedChanged += new System.EventHandler(this.cbEnableSearchByDate_CheckedChanged);
            // 
            // dtpSearchDate
            // 
            this.dtpSearchDate.Enabled = false;
            this.dtpSearchDate.Location = new System.Drawing.Point(393, 56);
            this.dtpSearchDate.Name = "dtpSearchDate";
            this.dtpSearchDate.Size = new System.Drawing.Size(200, 20);
            this.dtpSearchDate.TabIndex = 55;
            this.dtpSearchDate.ValueChanged += new System.EventHandler(this.dtpSearchDate_ValueChanged);
            // 
            // tbSearchBox
            // 
            this.tbSearchBox.Location = new System.Drawing.Point(28, 56);
            this.tbSearchBox.Name = "tbSearchBox";
            this.tbSearchBox.Size = new System.Drawing.Size(265, 20);
            this.tbSearchBox.TabIndex = 54;
            this.tbSearchBox.TextChanged += new System.EventHandler(this.tbSearchBox_TextChanged);
            // 
            // lblSearchBox
            // 
            this.lblSearchBox.AutoSize = true;
            this.lblSearchBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSearchBox.Location = new System.Drawing.Point(26, 29);
            this.lblSearchBox.Name = "lblSearchBox";
            this.lblSearchBox.Size = new System.Drawing.Size(311, 13);
            this.lblSearchBox.TabIndex = 53;
            this.lblSearchBox.Text = "Search by Order No./Customer Name/Phone No./Email Address";
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "id";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Visible = false;
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
            // customerEmailColumn
            // 
            this.customerEmailColumn.HeaderText = "Customer Email Address";
            this.customerEmailColumn.Name = "customerEmailColumn";
            this.customerEmailColumn.ReadOnly = true;
            this.customerEmailColumn.Width = 150;
            // 
            // createdOnColumn
            // 
            this.createdOnColumn.HeaderText = "Created On";
            this.createdOnColumn.Name = "createdOnColumn";
            this.createdOnColumn.ReadOnly = true;
            this.createdOnColumn.Width = 120;
            // 
            // amountColumn
            // 
            this.amountColumn.HeaderText = "Amount";
            this.amountColumn.Name = "amountColumn";
            this.amountColumn.ReadOnly = true;
            this.amountColumn.Width = 80;
            // 
            // SalesOrderPickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 450);
            this.Controls.Add(this.cbEnableSearchByDate);
            this.Controls.Add(this.dtpSearchDate);
            this.Controls.Add(this.tbSearchBox);
            this.Controls.Add(this.lblSearchBox);
            this.Controls.Add(this.dgvSalesOrders);
            this.Name = "SalesOrderPickerForm";
            this.Text = "SalesOrderPickerForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSalesOrders;
        private System.Windows.Forms.CheckBox cbEnableSearchByDate;
        private System.Windows.Forms.DateTimePicker dtpSearchDate;
        private System.Windows.Forms.TextBox tbSearchBox;
        private System.Windows.Forms.Label lblSearchBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesOrderNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerEmailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdOnColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountColumn;
    }
}
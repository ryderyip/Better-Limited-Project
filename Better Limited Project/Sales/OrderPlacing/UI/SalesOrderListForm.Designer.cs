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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesOrderListForm));
            this.dgvSalesOrders = new System.Windows.Forms.DataGridView();
            this.dtpSearchDate = new System.Windows.Forms.DateTimePicker();
            this.tbSearchBox = new System.Windows.Forms.TextBox();
            this.lblSearchBox = new System.Windows.Forms.Label();
            this.cbEnableSearchByDate = new System.Windows.Forms.CheckBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesOrderNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPhoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdOnColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.amountColumn,
            this.createdOnColumn,
            this.isActiveColumn});
            resources.ApplyResources(this.dgvSalesOrders, "dgvSalesOrders");
            this.dgvSalesOrders.Name = "dgvSalesOrders";
            this.dgvSalesOrders.ReadOnly = true;
            this.dgvSalesOrders.RowTemplate.Height = 24;
            this.dgvSalesOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesOrders_CellDoubleClick);
            // 
            // dtpSearchDate
            // 
            resources.ApplyResources(this.dtpSearchDate, "dtpSearchDate");
            this.dtpSearchDate.Name = "dtpSearchDate";
            this.dtpSearchDate.ValueChanged += new System.EventHandler(this.dtpSearchDate_ValueChanged);
            // 
            // tbSearchBox
            // 
            resources.ApplyResources(this.tbSearchBox, "tbSearchBox");
            this.tbSearchBox.Name = "tbSearchBox";
            this.tbSearchBox.TextChanged += new System.EventHandler(this.tbSearchBox_TextChanged);
            // 
            // lblSearchBox
            // 
            resources.ApplyResources(this.lblSearchBox, "lblSearchBox");
            this.lblSearchBox.Name = "lblSearchBox";
            // 
            // cbEnableSearchByDate
            // 
            resources.ApplyResources(this.cbEnableSearchByDate, "cbEnableSearchByDate");
            this.cbEnableSearchByDate.Name = "cbEnableSearchByDate";
            this.cbEnableSearchByDate.UseVisualStyleBackColor = true;
            this.cbEnableSearchByDate.CheckedChanged += new System.EventHandler(this.cbEnableSearchByDate_CheckedChanged);
            // 
            // progressBar
            // 
            resources.ApplyResources(this.progressBar, "progressBar");
            this.progressBar.Name = "progressBar";
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // idColumn
            // 
            resources.ApplyResources(this.idColumn, "idColumn");
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            // 
            // salesOrderNumberColumn
            // 
            resources.ApplyResources(this.salesOrderNumberColumn, "salesOrderNumberColumn");
            this.salesOrderNumberColumn.Name = "salesOrderNumberColumn";
            this.salesOrderNumberColumn.ReadOnly = true;
            // 
            // customerNameColumn
            // 
            resources.ApplyResources(this.customerNameColumn, "customerNameColumn");
            this.customerNameColumn.Name = "customerNameColumn";
            this.customerNameColumn.ReadOnly = true;
            // 
            // customerPhoneColumn
            // 
            resources.ApplyResources(this.customerPhoneColumn, "customerPhoneColumn");
            this.customerPhoneColumn.Name = "customerPhoneColumn";
            this.customerPhoneColumn.ReadOnly = true;
            // 
            // amountColumn
            // 
            resources.ApplyResources(this.amountColumn, "amountColumn");
            this.amountColumn.Name = "amountColumn";
            this.amountColumn.ReadOnly = true;
            // 
            // createdOnColumn
            // 
            resources.ApplyResources(this.createdOnColumn, "createdOnColumn");
            this.createdOnColumn.Name = "createdOnColumn";
            this.createdOnColumn.ReadOnly = true;
            // 
            // isActiveColumn
            // 
            resources.ApplyResources(this.isActiveColumn, "isActiveColumn");
            this.isActiveColumn.Name = "isActiveColumn";
            this.isActiveColumn.ReadOnly = true;
            // 
            // SalesOrderListForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.cbEnableSearchByDate);
            this.Controls.Add(this.dgvSalesOrders);
            this.Controls.Add(this.dtpSearchDate);
            this.Controls.Add(this.tbSearchBox);
            this.Controls.Add(this.lblSearchBox);
            this.Name = "SalesOrderListForm";
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
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesOrderNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdOnColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isActiveColumn;
    }
}
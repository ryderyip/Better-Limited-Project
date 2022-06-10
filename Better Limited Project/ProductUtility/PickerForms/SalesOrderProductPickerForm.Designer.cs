
namespace Better_Limited_Project.ProductUtility.PickerForms
{
    partial class SalesOrderProductPickerForm
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
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.lblCategoryFilter = new System.Windows.Forms.Label();
            this.cbCategoryFilter = new System.Windows.Forms.ComboBox();
            this.tbSearchBox = new System.Windows.Forms.TextBox();
            this.lblSearchBox = new System.Windows.Forms.Label();
            this.orderIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductList
            // 
            this.dgvProductList.AllowUserToAddRows = false;
            this.dgvProductList.AllowUserToDeleteRows = false;
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdColumn,
            this.productIdColumn,
            this.name,
            this.sellingPriceColumn,
            this.category,
            this.supplierColumn});
            this.dgvProductList.Location = new System.Drawing.Point(29, 95);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            this.dgvProductList.RowTemplate.Height = 24;
            this.dgvProductList.Size = new System.Drawing.Size(594, 265);
            this.dgvProductList.TabIndex = 3;
            this.dgvProductList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductList_CellDoubleClick);
            // 
            // lblCategoryFilter
            // 
            this.lblCategoryFilter.AutoSize = true;
            this.lblCategoryFilter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCategoryFilter.Location = new System.Drawing.Point(425, 25);
            this.lblCategoryFilter.Name = "lblCategoryFilter";
            this.lblCategoryFilter.Size = new System.Drawing.Size(89, 13);
            this.lblCategoryFilter.TabIndex = 14;
            this.lblCategoryFilter.Text = "Filter By Category";
            // 
            // cbCategoryFilter
            // 
            this.cbCategoryFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoryFilter.FormattingEnabled = true;
            this.cbCategoryFilter.Location = new System.Drawing.Point(428, 41);
            this.cbCategoryFilter.Name = "cbCategoryFilter";
            this.cbCategoryFilter.Size = new System.Drawing.Size(195, 21);
            this.cbCategoryFilter.TabIndex = 13;
            this.cbCategoryFilter.SelectedIndexChanged += new System.EventHandler(this.cbCategoryFilter_SelectedIndexChanged);
            // 
            // tbSearchBox
            // 
            this.tbSearchBox.Location = new System.Drawing.Point(29, 41);
            this.tbSearchBox.Name = "tbSearchBox";
            this.tbSearchBox.Size = new System.Drawing.Size(239, 20);
            this.tbSearchBox.TabIndex = 12;
            this.tbSearchBox.TextChanged += new System.EventHandler(this.tbSearchBox_TextChanged);
            // 
            // lblSearchBox
            // 
            this.lblSearchBox.AutoSize = true;
            this.lblSearchBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSearchBox.Location = new System.Drawing.Point(26, 25);
            this.lblSearchBox.Name = "lblSearchBox";
            this.lblSearchBox.Size = new System.Drawing.Size(169, 13);
            this.lblSearchBox.TabIndex = 11;
            this.lblSearchBox.Text = "Search by Product Name/Supplier";
            // 
            // orderIdColumn
            // 
            this.orderIdColumn.HeaderText = "order id";
            this.orderIdColumn.Name = "orderIdColumn";
            this.orderIdColumn.ReadOnly = true;
            this.orderIdColumn.Visible = false;
            // 
            // productIdColumn
            // 
            this.productIdColumn.HeaderText = "product id";
            this.productIdColumn.Name = "productIdColumn";
            this.productIdColumn.ReadOnly = true;
            this.productIdColumn.Visible = false;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 230;
            // 
            // sellingPriceColumn
            // 
            this.sellingPriceColumn.HeaderText = "Selling Price";
            this.sellingPriceColumn.Name = "sellingPriceColumn";
            this.sellingPriceColumn.ReadOnly = true;
            // 
            // category
            // 
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // supplierColumn
            // 
            this.supplierColumn.HeaderText = "Supplier";
            this.supplierColumn.Name = "supplierColumn";
            this.supplierColumn.ReadOnly = true;
            this.supplierColumn.Width = 120;
            // 
            // SalesOrderProductPickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 389);
            this.Controls.Add(this.lblCategoryFilter);
            this.Controls.Add(this.cbCategoryFilter);
            this.Controls.Add(this.tbSearchBox);
            this.Controls.Add(this.lblSearchBox);
            this.Controls.Add(this.dgvProductList);
            this.Name = "SalesOrderProductPickerForm";
            this.Text = "ProductPickerForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.Label lblCategoryFilter;
        public System.Windows.Forms.ComboBox cbCategoryFilter;
        public System.Windows.Forms.TextBox tbSearchBox;
        private System.Windows.Forms.Label lblSearchBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierColumn;
    }
}
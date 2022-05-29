namespace Better_Limited_Project.ProductUtility.ProductList.Forms
{
    partial class ProductListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSearchBox = new System.Windows.Forms.Label();
            this.tbSearchBox = new System.Windows.Forms.TextBox();
            this.btnRestock = new System.Windows.Forms.Button();
            this.cbWorkplaceSelect = new System.Windows.Forms.ComboBox();
            this.lblWorkplaceSelect = new System.Windows.Forms.Label();
            this.gpWorkplaceSelect = new System.Windows.Forms.GroupBox();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.btnNewProductClicked = new System.Windows.Forms.Button();
            this.cbCategoryFilter = new System.Windows.Forms.ComboBox();
            this.lblCategoryFilter = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selling_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpWorkplaceSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearchBox
            // 
            this.lblSearchBox.AutoSize = true;
            this.lblSearchBox.Location = new System.Drawing.Point(24, 28);
            this.lblSearchBox.Name = "lblSearchBox";
            this.lblSearchBox.Size = new System.Drawing.Size(169, 13);
            this.lblSearchBox.TabIndex = 0;
            this.lblSearchBox.Text = "Search by Product Name/Supplier";
            // 
            // tbSearchBox
            // 
            this.tbSearchBox.Location = new System.Drawing.Point(27, 44);
            this.tbSearchBox.Name = "tbSearchBox";
            this.tbSearchBox.Size = new System.Drawing.Size(239, 20);
            this.tbSearchBox.TabIndex = 1;
            this.tbSearchBox.TextChanged += new System.EventHandler(this.tbSearchBox_TextChanged);
            // 
            // btnRestock
            // 
            this.btnRestock.BackColor = System.Drawing.Color.DarkOrange;
            this.btnRestock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRestock.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRestock.Location = new System.Drawing.Point(463, 99);
            this.btnRestock.Name = "btnRestock";
            this.btnRestock.Size = new System.Drawing.Size(107, 40);
            this.btnRestock.TabIndex = 4;
            this.btnRestock.Text = "Restock";
            this.btnRestock.UseVisualStyleBackColor = false;
            this.btnRestock.Click += new System.EventHandler(this.btnRestock_Click);
            // 
            // cbWorkplaceSelect
            // 
            this.cbWorkplaceSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWorkplaceSelect.FormattingEnabled = true;
            this.cbWorkplaceSelect.Location = new System.Drawing.Point(6, 32);
            this.cbWorkplaceSelect.Name = "cbWorkplaceSelect";
            this.cbWorkplaceSelect.Size = new System.Drawing.Size(211, 21);
            this.cbWorkplaceSelect.TabIndex = 6;
            this.cbWorkplaceSelect.SelectedIndexChanged += new System.EventHandler(this.cbWorkplaceSelect_SelectedIndexChanged);
            // 
            // lblWorkplaceSelect
            // 
            this.lblWorkplaceSelect.AutoSize = true;
            this.lblWorkplaceSelect.Location = new System.Drawing.Point(6, 16);
            this.lblWorkplaceSelect.Name = "lblWorkplaceSelect";
            this.lblWorkplaceSelect.Size = new System.Drawing.Size(155, 13);
            this.lblWorkplaceSelect.TabIndex = 7;
            this.lblWorkplaceSelect.Text = "Select Retail Store/Warehouse";
            // 
            // gpWorkplaceSelect
            // 
            this.gpWorkplaceSelect.Controls.Add(this.lblWorkplaceSelect);
            this.gpWorkplaceSelect.Controls.Add(this.cbWorkplaceSelect);
            this.gpWorkplaceSelect.Location = new System.Drawing.Point(334, 28);
            this.gpWorkplaceSelect.Name = "gpWorkplaceSelect";
            this.gpWorkplaceSelect.Size = new System.Drawing.Size(236, 62);
            this.gpWorkplaceSelect.TabIndex = 8;
            this.gpWorkplaceSelect.TabStop = false;
            this.gpWorkplaceSelect.Visible = false;
            // 
            // dgvProductList
            // 
            this.dgvProductList.AllowUserToAddRows = false;
            this.dgvProductList.AllowUserToDeleteRows = false;
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.quantity,
            this.selling_price,
            this.category});
            this.dgvProductList.Location = new System.Drawing.Point(27, 158);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            this.dgvProductList.RowTemplate.Height = 24;
            this.dgvProductList.Size = new System.Drawing.Size(543, 265);
            this.dgvProductList.TabIndex = 2;
            this.dgvProductList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductList_CellDoubleClick);
            // 
            // btnNewProductClicked
            // 
            this.btnNewProductClicked.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNewProductClicked.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewProductClicked.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNewProductClicked.Location = new System.Drawing.Point(325, 99);
            this.btnNewProductClicked.Name = "btnNewProductClicked";
            this.btnNewProductClicked.Size = new System.Drawing.Size(132, 39);
            this.btnNewProductClicked.TabIndex = 9;
            this.btnNewProductClicked.Text = "New Product";
            this.btnNewProductClicked.UseVisualStyleBackColor = false;
            this.btnNewProductClicked.Visible = false;
            this.btnNewProductClicked.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // cbCategoryFilter
            // 
            this.cbCategoryFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoryFilter.FormattingEnabled = true;
            this.cbCategoryFilter.Location = new System.Drawing.Point(27, 118);
            this.cbCategoryFilter.Name = "cbCategoryFilter";
            this.cbCategoryFilter.Size = new System.Drawing.Size(195, 21);
            this.cbCategoryFilter.TabIndex = 8;
            this.cbCategoryFilter.SelectedIndexChanged += new System.EventHandler(this.cbCategoryFilter_SelectedIndexChanged);
            // 
            // lblCategoryFilter
            // 
            this.lblCategoryFilter.AutoSize = true;
            this.lblCategoryFilter.Location = new System.Drawing.Point(24, 102);
            this.lblCategoryFilter.Name = "lblCategoryFilter";
            this.lblCategoryFilter.Size = new System.Drawing.Size(89, 13);
            this.lblCategoryFilter.TabIndex = 10;
            this.lblCategoryFilter.Text = "Filter By Category";
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 230;
            // 
            // quantity
            // 
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.quantity.DefaultCellStyle = dataGridViewCellStyle1;
            this.quantity.HeaderText = "Qty";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 50;
            // 
            // selling_price
            // 
            this.selling_price.HeaderText = "Selling Price";
            this.selling_price.Name = "selling_price";
            this.selling_price.ReadOnly = true;
            // 
            // category
            // 
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Width = 120;
            // 
            // ProductListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 449);
            this.Controls.Add(this.lblCategoryFilter);
            this.Controls.Add(this.cbCategoryFilter);
            this.Controls.Add(this.btnNewProductClicked);
            this.Controls.Add(this.gpWorkplaceSelect);
            this.Controls.Add(this.btnRestock);
            this.Controls.Add(this.dgvProductList);
            this.Controls.Add(this.tbSearchBox);
            this.Controls.Add(this.lblSearchBox);
            this.KeyPreview = true;
            this.Name = "ProductListForm";
            this.Text = "ProductListForm";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductListForm_KeyPress);
            this.gpWorkplaceSelect.ResumeLayout(false);
            this.gpWorkplaceSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public System.Windows.Forms.Button btnNewProductClicked;

        public System.Windows.Forms.ComboBox cbWorkplaceSelect;
        private System.Windows.Forms.Label lblWorkplaceSelect;

        #endregion

        private System.Windows.Forms.Label lblSearchBox;
        public System.Windows.Forms.TextBox tbSearchBox;
        public System.Windows.Forms.DataGridView dgvProductList;
        public System.Windows.Forms.Button btnRestock;
        private System.Windows.Forms.GroupBox gpWorkplaceSelect;
        public System.Windows.Forms.ComboBox cbCategoryFilter;
        private System.Windows.Forms.Label lblCategoryFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn selling_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
    }
}
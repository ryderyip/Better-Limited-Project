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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductListForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSearchBox = new System.Windows.Forms.Label();
            this.tbSearchBox = new System.Windows.Forms.TextBox();
            this.btnRestock = new System.Windows.Forms.Button();
            this.cbWorkplaceSelect = new System.Windows.Forms.ComboBox();
            this.lblWorkplaceSelect = new System.Windows.Forms.Label();
            this.gpWorkplaceSelect = new System.Windows.Forms.GroupBox();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selling_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNewProductClicked = new System.Windows.Forms.Button();
            this.cbCategoryFilter = new System.Windows.Forms.ComboBox();
            this.lblCategoryFilter = new System.Windows.Forms.Label();
            this.gpWorkplaceSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearchBox
            // 
            resources.ApplyResources(this.lblSearchBox, "lblSearchBox");
            this.lblSearchBox.Name = "lblSearchBox";
            // 
            // tbSearchBox
            // 
            resources.ApplyResources(this.tbSearchBox, "tbSearchBox");
            this.tbSearchBox.Name = "tbSearchBox";
            this.tbSearchBox.TextChanged += new System.EventHandler(this.tbSearchBox_TextChanged);
            // 
            // btnRestock
            // 
            this.btnRestock.BackColor = System.Drawing.Color.DarkOrange;
            resources.ApplyResources(this.btnRestock, "btnRestock");
            this.btnRestock.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRestock.Name = "btnRestock";
            this.btnRestock.UseVisualStyleBackColor = false;
            this.btnRestock.Click += new System.EventHandler(this.btnRestock_Click);
            // 
            // cbWorkplaceSelect
            // 
            this.cbWorkplaceSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWorkplaceSelect.FormattingEnabled = true;
            resources.ApplyResources(this.cbWorkplaceSelect, "cbWorkplaceSelect");
            this.cbWorkplaceSelect.Name = "cbWorkplaceSelect";
            this.cbWorkplaceSelect.SelectedIndexChanged += new System.EventHandler(this.cbWorkplaceSelect_SelectedIndexChanged);
            // 
            // lblWorkplaceSelect
            // 
            resources.ApplyResources(this.lblWorkplaceSelect, "lblWorkplaceSelect");
            this.lblWorkplaceSelect.Name = "lblWorkplaceSelect";
            // 
            // gpWorkplaceSelect
            // 
            this.gpWorkplaceSelect.Controls.Add(this.lblWorkplaceSelect);
            this.gpWorkplaceSelect.Controls.Add(this.cbWorkplaceSelect);
            resources.ApplyResources(this.gpWorkplaceSelect, "gpWorkplaceSelect");
            this.gpWorkplaceSelect.Name = "gpWorkplaceSelect";
            this.gpWorkplaceSelect.TabStop = false;
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
            resources.ApplyResources(this.dgvProductList, "dgvProductList");
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            this.dgvProductList.RowTemplate.Height = 24;
            this.dgvProductList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductList_CellDoubleClick);
            // 
            // name
            // 
            resources.ApplyResources(this.name, "name");
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // quantity
            // 
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.quantity.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.quantity, "quantity");
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // selling_price
            // 
            resources.ApplyResources(this.selling_price, "selling_price");
            this.selling_price.Name = "selling_price";
            this.selling_price.ReadOnly = true;
            // 
            // category
            // 
            resources.ApplyResources(this.category, "category");
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // btnNewProductClicked
            // 
            this.btnNewProductClicked.BackColor = System.Drawing.Color.DarkOrange;
            resources.ApplyResources(this.btnNewProductClicked, "btnNewProductClicked");
            this.btnNewProductClicked.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNewProductClicked.Name = "btnNewProductClicked";
            this.btnNewProductClicked.UseVisualStyleBackColor = false;
            this.btnNewProductClicked.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // cbCategoryFilter
            // 
            this.cbCategoryFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoryFilter.FormattingEnabled = true;
            resources.ApplyResources(this.cbCategoryFilter, "cbCategoryFilter");
            this.cbCategoryFilter.Name = "cbCategoryFilter";
            this.cbCategoryFilter.SelectedIndexChanged += new System.EventHandler(this.cbCategoryFilter_SelectedIndexChanged);
            // 
            // lblCategoryFilter
            // 
            resources.ApplyResources(this.lblCategoryFilter, "lblCategoryFilter");
            this.lblCategoryFilter.Name = "lblCategoryFilter";
            // 
            // ProductListForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
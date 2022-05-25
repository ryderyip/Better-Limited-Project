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
            this.lblSearchKeywords = new System.Windows.Forms.Label();
            this.txtSearchKeywords = new System.Windows.Forms.TextBox();
            this.btnUpdateStockLevel = new System.Windows.Forms.Button();
            this.btnRestock = new System.Windows.Forms.Button();
            this.txtNoResults = new System.Windows.Forms.Label();
            this.cbWorkplaceSelect = new System.Windows.Forms.ComboBox();
            this.lblWorkplaceSelect = new System.Windows.Forms.Label();
            this.gpWorkplaceSelect = new System.Windows.Forms.GroupBox();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.btnNewProductClicked = new System.Windows.Forms.Button();
            this.gpWorkplaceSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearchKeywords
            // 
            this.lblSearchKeywords.AutoSize = true;
            this.lblSearchKeywords.Location = new System.Drawing.Point(25, 28);
            this.lblSearchKeywords.Name = "lblSearchKeywords";
            this.lblSearchKeywords.Size = new System.Drawing.Size(192, 13);
            this.lblSearchKeywords.TabIndex = 0;
            this.lblSearchKeywords.Text = "Search by Product ID or Product Name";
            // 
            // txtSearchKeywords
            // 
            this.txtSearchKeywords.Location = new System.Drawing.Point(27, 44);
            this.txtSearchKeywords.Name = "txtSearchKeywords";
            this.txtSearchKeywords.Size = new System.Drawing.Size(209, 20);
            this.txtSearchKeywords.TabIndex = 1;
            // 
            // btnUpdateStockLevel
            // 
            this.btnUpdateStockLevel.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdateStockLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdateStockLevel.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdateStockLevel.Location = new System.Drawing.Point(349, 28);
            this.btnUpdateStockLevel.Name = "btnUpdateStockLevel";
            this.btnUpdateStockLevel.Size = new System.Drawing.Size(160, 40);
            this.btnUpdateStockLevel.TabIndex = 3;
            this.btnUpdateStockLevel.Text = "Update Stock Level";
            this.btnUpdateStockLevel.UseVisualStyleBackColor = false;
            this.btnUpdateStockLevel.Click += new System.EventHandler(this.btnUpdateStockLevel_Click);
            // 
            // btnRestock
            // 
            this.btnRestock.BackColor = System.Drawing.Color.DarkOrange;
            this.btnRestock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRestock.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRestock.Location = new System.Drawing.Point(402, 89);
            this.btnRestock.Name = "btnRestock";
            this.btnRestock.Size = new System.Drawing.Size(107, 40);
            this.btnRestock.TabIndex = 4;
            this.btnRestock.Text = "Restock";
            this.btnRestock.UseVisualStyleBackColor = false;
            // 
            // txtNoResults
            // 
            this.txtNoResults.AutoSize = true;
            this.txtNoResults.ForeColor = System.Drawing.Color.Red;
            this.txtNoResults.Location = new System.Drawing.Point(27, 74);
            this.txtNoResults.Name = "txtNoResults";
            this.txtNoResults.Size = new System.Drawing.Size(112, 13);
            this.txtNoResults.TabIndex = 5;
            this.txtNoResults.Text = "(No Matching Results)";
            this.txtNoResults.Visible = false;
            // 
            // cbWorkplaceSelect
            // 
            this.cbWorkplaceSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWorkplaceSelect.FormattingEnabled = true;
            this.cbWorkplaceSelect.Location = new System.Drawing.Point(6, 32);
            this.cbWorkplaceSelect.Name = "cbWorkplaceSelect";
            this.cbWorkplaceSelect.Size = new System.Drawing.Size(211, 21);
            this.cbWorkplaceSelect.TabIndex = 6;
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
            this.gpWorkplaceSelect.Location = new System.Drawing.Point(27, 90);
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
            this.dgvProductList.Location = new System.Drawing.Point(27, 158);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            this.dgvProductList.RowTemplate.Height = 24;
            this.dgvProductList.Size = new System.Drawing.Size(482, 265);
            this.dgvProductList.TabIndex = 2;
            this.dgvProductList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductList_CellDoubleClick);
            // 
            // btnNewProductClicked
            // 
            this.btnNewProductClicked.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNewProductClicked.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnNewProductClicked.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNewProductClicked.Location = new System.Drawing.Point(349, 98);
            this.btnNewProductClicked.Name = "btnNewProductClicked";
            this.btnNewProductClicked.Size = new System.Drawing.Size(76, 54);
            this.btnNewProductClicked.TabIndex = 9;
            this.btnNewProductClicked.Text = "New Product";
            this.btnNewProductClicked.UseVisualStyleBackColor = false;
            this.btnNewProductClicked.Visible = false;
            this.btnNewProductClicked.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // ProductListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 449);
            this.Controls.Add(this.btnNewProductClicked);
            this.Controls.Add(this.gpWorkplaceSelect);
            this.Controls.Add(this.txtNoResults);
            this.Controls.Add(this.btnRestock);
            this.Controls.Add(this.btnUpdateStockLevel);
            this.Controls.Add(this.dgvProductList);
            this.Controls.Add(this.txtSearchKeywords);
            this.Controls.Add(this.lblSearchKeywords);
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
        public System.Windows.Forms.GroupBox gpWorkplaceSelect;

        private System.Windows.Forms.Label txtNoResults;

        #endregion

        private System.Windows.Forms.Label lblSearchKeywords;
        public System.Windows.Forms.TextBox txtSearchKeywords;
        public System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.Button btnUpdateStockLevel;
        public System.Windows.Forms.Button btnRestock;
    }
}
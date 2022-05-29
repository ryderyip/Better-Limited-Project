namespace Better_Limited_Project.ProductUtility.Restocking
{
    partial class CreateRestockRequestForm
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
            this.lblSearchBox = new System.Windows.Forms.Label();
            this.tbSearchBox = new System.Windows.Forms.TextBox();
            this.dgvProductStock = new System.Windows.Forms.DataGridView();
            this.productStockNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productStockQuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productStockCategoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSendRequest = new System.Windows.Forms.Button();
            this.dgvRestockItems = new System.Windows.Forms.DataGridView();
            this.restockItemsNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restockItemsQuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnAddToRequest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestockItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearchBox
            // 
            this.lblSearchBox.AutoSize = true;
            this.lblSearchBox.Location = new System.Drawing.Point(23, 97);
            this.lblSearchBox.Name = "lblSearchBox";
            this.lblSearchBox.Size = new System.Drawing.Size(169, 13);
            this.lblSearchBox.TabIndex = 0;
            this.lblSearchBox.Text = "Search by Product Name/Supplier";
            // 
            // tbSearchBox
            // 
            this.tbSearchBox.Location = new System.Drawing.Point(25, 123);
            this.tbSearchBox.Name = "tbSearchBox";
            this.tbSearchBox.Size = new System.Drawing.Size(174, 20);
            this.tbSearchBox.TabIndex = 1;
            this.tbSearchBox.TextChanged += new System.EventHandler(this.FilterProductStockList);
            // 
            // dgvProductStock
            // 
            this.dgvProductStock.AllowUserToAddRows = false;
            this.dgvProductStock.AllowUserToDeleteRows = false;
            this.dgvProductStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productStockNameColumn,
            this.productStockQuantityColumn,
            this.productStockCategoryColumn});
            this.dgvProductStock.Location = new System.Drawing.Point(25, 167);
            this.dgvProductStock.Name = "dgvProductStock";
            this.dgvProductStock.ReadOnly = true;
            this.dgvProductStock.RowTemplate.Height = 24;
            this.dgvProductStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductStock.Size = new System.Drawing.Size(343, 162);
            this.dgvProductStock.TabIndex = 2;
            this.dgvProductStock.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductStock_CellDoubleClick);
            // 
            // productStockNameColumn
            // 
            this.productStockNameColumn.DataPropertyName = "productStockNameColumn";
            this.productStockNameColumn.HeaderText = "Name";
            this.productStockNameColumn.Name = "productStockNameColumn";
            this.productStockNameColumn.ReadOnly = true;
            this.productStockNameColumn.Width = 160;
            // 
            // productStockQuantityColumn
            // 
            this.productStockQuantityColumn.DataPropertyName = "productStockQuantityColumn";
            this.productStockQuantityColumn.HeaderText = "Qty";
            this.productStockQuantityColumn.Name = "productStockQuantityColumn";
            this.productStockQuantityColumn.ReadOnly = true;
            this.productStockQuantityColumn.Width = 40;
            // 
            // productStockCategoryColumn
            // 
            this.productStockCategoryColumn.DataPropertyName = "productStockCategoryColumn";
            this.productStockCategoryColumn.HeaderText = "Category";
            this.productStockCategoryColumn.Name = "productStockCategoryColumn";
            this.productStockCategoryColumn.ReadOnly = true;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRemove.Location = new System.Drawing.Point(526, 89);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(119, 54);
            this.btnRemove.TabIndex = 44;
            this.btnRemove.Text = "Remove Selected";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Window;
            this.btnClear.Location = new System.Drawing.Point(667, 89);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 54);
            this.btnClear.TabIndex = 45;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSendRequest
            // 
            this.btnSendRequest.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSendRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendRequest.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSendRequest.Location = new System.Drawing.Point(308, 412);
            this.btnSendRequest.Name = "btnSendRequest";
            this.btnSendRequest.Size = new System.Drawing.Size(183, 44);
            this.btnSendRequest.TabIndex = 46;
            this.btnSendRequest.Text = "Send Request";
            this.btnSendRequest.UseVisualStyleBackColor = false;
            this.btnSendRequest.Click += new System.EventHandler(this.btnSendRequest_Click);
            // 
            // dgvRestockItems
            // 
            this.dgvRestockItems.AllowUserToAddRows = false;
            this.dgvRestockItems.AllowUserToDeleteRows = false;
            this.dgvRestockItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRestockItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.restockItemsNameColumn,
            this.restockItemsQuantityColumn});
            this.dgvRestockItems.Location = new System.Drawing.Point(430, 167);
            this.dgvRestockItems.Name = "dgvRestockItems";
            this.dgvRestockItems.RowTemplate.Height = 24;
            this.dgvRestockItems.Size = new System.Drawing.Size(343, 162);
            this.dgvRestockItems.TabIndex = 47;
            this.dgvRestockItems.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRestockItems_CellValueChanged);
            // 
            // restockItemsNameColumn
            // 
            this.restockItemsNameColumn.HeaderText = "Name";
            this.restockItemsNameColumn.Name = "restockItemsNameColumn";
            this.restockItemsNameColumn.ReadOnly = true;
            this.restockItemsNameColumn.Width = 200;
            // 
            // restockItemsQuantityColumn
            // 
            this.restockItemsQuantityColumn.HeaderText = "Restock Qty";
            this.restockItemsQuantityColumn.Name = "restockItemsQuantityColumn";
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(247, 122);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 21);
            this.cbCategory.TabIndex = 48;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.FilterProductStockList);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(244, 97);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 49;
            this.lblCategory.Text = "Category";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(225, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(352, 31);
            this.lblHeader.TabIndex = 50;
            this.lblHeader.Text = "Restock/Reorder Request";
            // 
            // btnAddToRequest
            // 
            this.btnAddToRequest.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddToRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToRequest.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAddToRequest.Location = new System.Drawing.Point(26, 346);
            this.btnAddToRequest.Name = "btnAddToRequest";
            this.btnAddToRequest.Size = new System.Drawing.Size(112, 53);
            this.btnAddToRequest.TabIndex = 51;
            this.btnAddToRequest.Text = "Add to Request";
            this.btnAddToRequest.UseVisualStyleBackColor = false;
            this.btnAddToRequest.Click += new System.EventHandler(this.btnAddToRequest_Click);
            // 
            // CreateRestockRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.btnAddToRequest);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.dgvRestockItems);
            this.Controls.Add(this.btnSendRequest);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dgvProductStock);
            this.Controls.Add(this.tbSearchBox);
            this.Controls.Add(this.lblSearchBox);
            this.Name = "CreateRestockRequestForm";
            this.Text = "CreateRestockRequestForm";
            this.Shown += new System.EventHandler(this.OnFormShown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestockItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchBox;
        private System.Windows.Forms.TextBox tbSearchBox;
        private System.Windows.Forms.DataGridView dgvProductStock;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSendRequest;
        private System.Windows.Forms.DataGridView dgvRestockItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn productStockNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productStockQuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productStockCategoryColumn;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnAddToRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn restockItemsNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn restockItemsQuantityColumn;
    }
}
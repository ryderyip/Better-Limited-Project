namespace Better_Limited_Project.ProductUtility.Reordering
{
    partial class ReorderRequestSendingForm
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
            this.btnSendReorderRequest = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvRequestedGoods = new System.Windows.Forms.DataGridView();
            this.requestedProductIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestedProductNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityToReorderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAmountToAdd = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.productIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productStockQuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchKeywords = new System.Windows.Forms.TextBox();
            this.lblSearchKeywords = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblGoodsInRequest = new System.Windows.Forms.Label();
            this.nudAmountToAdd = new System.Windows.Forms.NumericUpDown();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestedGoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountToAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSendReorderRequest
            // 
            this.btnSendReorderRequest.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSendReorderRequest.Enabled = false;
            this.btnSendReorderRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendReorderRequest.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSendReorderRequest.Location = new System.Drawing.Point(286, 405);
            this.btnSendReorderRequest.Name = "btnSendReorderRequest";
            this.btnSendReorderRequest.Size = new System.Drawing.Size(213, 52);
            this.btnSendReorderRequest.TabIndex = 57;
            this.btnSendReorderRequest.Text = "Send Reorder Request";
            this.btnSendReorderRequest.UseVisualStyleBackColor = false;
            this.btnSendReorderRequest.Click += new System.EventHandler(this.btnSendReorderRequest_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Window;
            this.btnClear.Location = new System.Drawing.Point(649, 334);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 37);
            this.btnClear.TabIndex = 56;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAdd.Location = new System.Drawing.Point(172, 334);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(73, 37);
            this.btnAdd.TabIndex = 54;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvRequestedGoods
            // 
            this.dgvRequestedGoods.AllowUserToAddRows = false;
            this.dgvRequestedGoods.AllowUserToDeleteRows = false;
            this.dgvRequestedGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequestedGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.requestedProductIdColumn,
            this.requestedProductNameColumn,
            this.quantityToReorderColumn});
            this.dgvRequestedGoods.Location = new System.Drawing.Point(462, 121);
            this.dgvRequestedGoods.Name = "dgvRequestedGoods";
            this.dgvRequestedGoods.ReadOnly = true;
            this.dgvRequestedGoods.RowTemplate.Height = 24;
            this.dgvRequestedGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequestedGoods.Size = new System.Drawing.Size(293, 196);
            this.dgvRequestedGoods.TabIndex = 53;
            // 
            // requestedProductIdColumn
            // 
            this.requestedProductIdColumn.HeaderText = "id";
            this.requestedProductIdColumn.Name = "requestedProductIdColumn";
            this.requestedProductIdColumn.ReadOnly = true;
            this.requestedProductIdColumn.Visible = false;
            // 
            // requestedProductNameColumn
            // 
            this.requestedProductNameColumn.HeaderText = "Product";
            this.requestedProductNameColumn.Name = "requestedProductNameColumn";
            this.requestedProductNameColumn.ReadOnly = true;
            this.requestedProductNameColumn.Width = 130;
            // 
            // quantityToReorderColumn
            // 
            this.quantityToReorderColumn.HeaderText = "Qty To Reorder";
            this.quantityToReorderColumn.Name = "quantityToReorderColumn";
            this.quantityToReorderColumn.ReadOnly = true;
            this.quantityToReorderColumn.Width = 120;
            // 
            // lblAmountToAdd
            // 
            this.lblAmountToAdd.AutoSize = true;
            this.lblAmountToAdd.Location = new System.Drawing.Point(31, 329);
            this.lblAmountToAdd.Name = "lblAmountToAdd";
            this.lblAmountToAdd.Size = new System.Drawing.Size(81, 13);
            this.lblAmountToAdd.TabIndex = 51;
            this.lblAmountToAdd.Text = "Amount To Add";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdColumn,
            this.productNameColumn,
            this.productStockQuantityColumn,
            this.categoryColumn});
            this.dgvProducts.Location = new System.Drawing.Point(31, 121);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(364, 196);
            this.dgvProducts.TabIndex = 50;
            this.dgvProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellDoubleClick);
            // 
            // productIdColumn
            // 
            this.productIdColumn.HeaderText = "id";
            this.productIdColumn.Name = "productIdColumn";
            this.productIdColumn.ReadOnly = true;
            this.productIdColumn.Visible = false;
            // 
            // productNameColumn
            // 
            this.productNameColumn.HeaderText = "Product";
            this.productNameColumn.Name = "productNameColumn";
            this.productNameColumn.ReadOnly = true;
            this.productNameColumn.Width = 130;
            // 
            // productStockQuantityColumn
            // 
            this.productStockQuantityColumn.HeaderText = "Qty In Stock";
            this.productStockQuantityColumn.Name = "productStockQuantityColumn";
            this.productStockQuantityColumn.ReadOnly = true;
            this.productStockQuantityColumn.Width = 90;
            // 
            // categoryColumn
            // 
            this.categoryColumn.HeaderText = "Category";
            this.categoryColumn.Name = "categoryColumn";
            this.categoryColumn.ReadOnly = true;
            // 
            // txtSearchKeywords
            // 
            this.txtSearchKeywords.Location = new System.Drawing.Point(30, 86);
            this.txtSearchKeywords.Name = "txtSearchKeywords";
            this.txtSearchKeywords.Size = new System.Drawing.Size(174, 20);
            this.txtSearchKeywords.TabIndex = 49;
            // 
            // lblSearchKeywords
            // 
            this.lblSearchKeywords.AutoSize = true;
            this.lblSearchKeywords.Location = new System.Drawing.Point(28, 60);
            this.lblSearchKeywords.Name = "lblSearchKeywords";
            this.lblSearchKeywords.Size = new System.Drawing.Size(126, 13);
            this.lblSearchKeywords.TabIndex = 48;
            this.lblSearchKeywords.Text = "Search by Product Name";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(271, 25);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(242, 25);
            this.lblHeader.TabIndex = 58;
            this.lblHeader.Text = "New Reorder Request";
            // 
            // lblGoodsInRequest
            // 
            this.lblGoodsInRequest.AutoSize = true;
            this.lblGoodsInRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoodsInRequest.Location = new System.Drawing.Point(534, 84);
            this.lblGoodsInRequest.Name = "lblGoodsInRequest";
            this.lblGoodsInRequest.Size = new System.Drawing.Size(155, 20);
            this.lblGoodsInRequest.TabIndex = 59;
            this.lblGoodsInRequest.Text = "Requested Goods";
            // 
            // nudAmountToAdd
            // 
            this.nudAmountToAdd.Location = new System.Drawing.Point(34, 345);
            this.nudAmountToAdd.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAmountToAdd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmountToAdd.Name = "nudAmountToAdd";
            this.nudAmountToAdd.Size = new System.Drawing.Size(120, 20);
            this.nudAmountToAdd.TabIndex = 60;
            this.nudAmountToAdd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.BackColor = System.Drawing.Color.Sienna;
            this.btnRemoveSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSelected.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRemoveSelected.Location = new System.Drawing.Point(462, 334);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(165, 37);
            this.btnRemoveSelected.TabIndex = 61;
            this.btnRemoveSelected.Text = "Remove Selected";
            this.btnRemoveSelected.UseVisualStyleBackColor = false;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // ReorderRequestSendingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 477);
            this.Controls.Add(this.btnRemoveSelected);
            this.Controls.Add(this.nudAmountToAdd);
            this.Controls.Add(this.lblGoodsInRequest);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnSendReorderRequest);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvRequestedGoods);
            this.Controls.Add(this.lblAmountToAdd);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.txtSearchKeywords);
            this.Controls.Add(this.lblSearchKeywords);
            this.KeyPreview = true;
            this.Name = "ReorderRequestSendingForm";
            this.Text = "ReorderRequestSendingForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestedGoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountToAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSendReorderRequest;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvRequestedGoods;
        private System.Windows.Forms.Label lblAmountToAdd;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.TextBox txtSearchKeywords;
        private System.Windows.Forms.Label lblSearchKeywords;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblGoodsInRequest;
        private System.Windows.Forms.NumericUpDown nudAmountToAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestedProductIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestedProductNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityToReorderColumn;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productStockQuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryColumn;
    }
}
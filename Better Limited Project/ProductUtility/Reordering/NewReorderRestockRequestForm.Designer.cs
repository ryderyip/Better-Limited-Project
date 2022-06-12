
namespace Better_Limited_Project.ProductUtility.Reordering
{
    partial class NewReorderRestockRequestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewReorderRestockRequestForm));
            this.lblGoodsInRequest = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.dgvRequestedGoods = new System.Windows.Forms.DataGridView();
            this.btnSendRequest = new System.Windows.Forms.Button();
            this.btnSelectGoods = new System.Windows.Forms.Button();
            this.tbNoOfProducts = new System.Windows.Forms.TextBox();
            this.lblNoOfProducts = new System.Windows.Forms.Label();
            this.tbEstimatedTotalCost = new System.Windows.Forms.TextBox();
            this.lblEstimatedTotalCost = new System.Windows.Forms.Label();
            this.requestedProductIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestedProductNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityToReorderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestedGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGoodsInRequest
            // 
            resources.ApplyResources(this.lblGoodsInRequest, "lblGoodsInRequest");
            this.lblGoodsInRequest.Name = "lblGoodsInRequest";
            // 
            // lblHeader
            // 
            resources.ApplyResources(this.lblHeader, "lblHeader");
            this.lblHeader.Name = "lblHeader";
            // 
            // dgvRequestedGoods
            // 
            this.dgvRequestedGoods.AllowUserToAddRows = false;
            this.dgvRequestedGoods.AllowUserToDeleteRows = false;
            this.dgvRequestedGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequestedGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.requestedProductIdColumn,
            this.requestedProductNameColumn,
            this.priceColumn,
            this.quantityToReorderColumn,
            this.categoryColumn});
            resources.ApplyResources(this.dgvRequestedGoods, "dgvRequestedGoods");
            this.dgvRequestedGoods.Name = "dgvRequestedGoods";
            this.dgvRequestedGoods.ReadOnly = true;
            this.dgvRequestedGoods.RowTemplate.Height = 24;
            this.dgvRequestedGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // btnSendRequest
            // 
            this.btnSendRequest.BackColor = System.Drawing.Color.DarkOrange;
            resources.ApplyResources(this.btnSendRequest, "btnSendRequest");
            this.btnSendRequest.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSendRequest.Name = "btnSendRequest";
            this.btnSendRequest.UseVisualStyleBackColor = false;
            this.btnSendRequest.Click += new System.EventHandler(this.btnSendReorderRequest_Click);
            // 
            // btnSelectGoods
            // 
            this.btnSelectGoods.BackColor = System.Drawing.Color.Sienna;
            resources.ApplyResources(this.btnSelectGoods, "btnSelectGoods");
            this.btnSelectGoods.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSelectGoods.Name = "btnSelectGoods";
            this.btnSelectGoods.UseVisualStyleBackColor = false;
            this.btnSelectGoods.Click += new System.EventHandler(this.btnSelectGoods_Click);
            // 
            // tbNoOfProducts
            // 
            resources.ApplyResources(this.tbNoOfProducts, "tbNoOfProducts");
            this.tbNoOfProducts.Name = "tbNoOfProducts";
            this.tbNoOfProducts.ReadOnly = true;
            // 
            // lblNoOfProducts
            // 
            resources.ApplyResources(this.lblNoOfProducts, "lblNoOfProducts");
            this.lblNoOfProducts.Name = "lblNoOfProducts";
            // 
            // tbEstimatedTotalCost
            // 
            resources.ApplyResources(this.tbEstimatedTotalCost, "tbEstimatedTotalCost");
            this.tbEstimatedTotalCost.Name = "tbEstimatedTotalCost";
            this.tbEstimatedTotalCost.ReadOnly = true;
            // 
            // lblEstimatedTotalCost
            // 
            resources.ApplyResources(this.lblEstimatedTotalCost, "lblEstimatedTotalCost");
            this.lblEstimatedTotalCost.Name = "lblEstimatedTotalCost";
            // 
            // requestedProductIdColumn
            // 
            resources.ApplyResources(this.requestedProductIdColumn, "requestedProductIdColumn");
            this.requestedProductIdColumn.Name = "requestedProductIdColumn";
            this.requestedProductIdColumn.ReadOnly = true;
            // 
            // requestedProductNameColumn
            // 
            resources.ApplyResources(this.requestedProductNameColumn, "requestedProductNameColumn");
            this.requestedProductNameColumn.Name = "requestedProductNameColumn";
            this.requestedProductNameColumn.ReadOnly = true;
            // 
            // priceColumn
            // 
            resources.ApplyResources(this.priceColumn, "priceColumn");
            this.priceColumn.Name = "priceColumn";
            this.priceColumn.ReadOnly = true;
            // 
            // quantityToReorderColumn
            // 
            resources.ApplyResources(this.quantityToReorderColumn, "quantityToReorderColumn");
            this.quantityToReorderColumn.Name = "quantityToReorderColumn";
            this.quantityToReorderColumn.ReadOnly = true;
            // 
            // categoryColumn
            // 
            resources.ApplyResources(this.categoryColumn, "categoryColumn");
            this.categoryColumn.Name = "categoryColumn";
            this.categoryColumn.ReadOnly = true;
            // 
            // NewReorderRequestForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbEstimatedTotalCost);
            this.Controls.Add(this.lblEstimatedTotalCost);
            this.Controls.Add(this.tbNoOfProducts);
            this.Controls.Add(this.lblNoOfProducts);
            this.Controls.Add(this.btnSelectGoods);
            this.Controls.Add(this.btnSendRequest);
            this.Controls.Add(this.lblGoodsInRequest);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.dgvRequestedGoods);
            this.Name = "NewReorderRequestForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestedGoods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGoodsInRequest;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridView dgvRequestedGoods;
        private System.Windows.Forms.Button btnSendRequest;
        private System.Windows.Forms.Button btnSelectGoods;
        private System.Windows.Forms.TextBox tbNoOfProducts;
        private System.Windows.Forms.Label lblNoOfProducts;
        private System.Windows.Forms.TextBox tbEstimatedTotalCost;
        private System.Windows.Forms.Label lblEstimatedTotalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestedProductIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestedProductNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityToReorderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryColumn;
    }
}
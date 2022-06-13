namespace Better_Limited_Project.ProductUtility.GoodsPurchasing.UI
{
    partial class PurchaseOrderDetailsForm
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
            this.tbEstimatedTotalCost = new System.Windows.Forms.TextBox();
            this.lblEstimatedTotalCost = new System.Windows.Forms.Label();
            this.tbNoOfProducts = new System.Windows.Forms.TextBox();
            this.lblNoOfProducts = new System.Windows.Forms.Label();
            this.dgvGoodsToOrder = new System.Windows.Forms.DataGridView();
            this.requestedProductIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestedProductNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityToReorderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbApprovedOn = new System.Windows.Forms.TextBox();
            this.lblApprovedOn = new System.Windows.Forms.Label();
            this.tbIsApproved = new System.Windows.Forms.TextBox();
            this.lblIsApproved = new System.Windows.Forms.Label();
            this.tbApprovedByStaffName = new System.Windows.Forms.TextBox();
            this.lblApprovedByStaffName = new System.Windows.Forms.Label();
            this.tbCreatedByStaff = new System.Windows.Forms.TextBox();
            this.lblCreatedByStaff = new System.Windows.Forms.Label();
            this.tbWarehouseName = new System.Windows.Forms.TextBox();
            this.lblWarehouseName = new System.Windows.Forms.Label();
            this.lblGoodsToOrder = new System.Windows.Forms.Label();
            this.tbCreatedOn = new System.Windows.Forms.TextBox();
            this.tbPurchaseOrderNumber = new System.Windows.Forms.TextBox();
            this.lblCreatedOn = new System.Windows.Forms.Label();
            this.lblPurchaseOrderNumber = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.tbSentToSupplierOn = new System.Windows.Forms.TextBox();
            this.lblSentToSupplierOn = new System.Windows.Forms.Label();
            this.btnApproveAndSend = new System.Windows.Forms.Button();
            this.btnCreateInwardGoodsRecord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsToOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // tbEstimatedTotalCost
            // 
            this.tbEstimatedTotalCost.Location = new System.Drawing.Point(575, 361);
            this.tbEstimatedTotalCost.Name = "tbEstimatedTotalCost";
            this.tbEstimatedTotalCost.ReadOnly = true;
            this.tbEstimatedTotalCost.Size = new System.Drawing.Size(161, 20);
            this.tbEstimatedTotalCost.TabIndex = 94;
            this.tbEstimatedTotalCost.Text = "-";
            // 
            // lblEstimatedTotalCost
            // 
            this.lblEstimatedTotalCost.AutoSize = true;
            this.lblEstimatedTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblEstimatedTotalCost.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEstimatedTotalCost.Location = new System.Drawing.Point(572, 342);
            this.lblEstimatedTotalCost.Name = "lblEstimatedTotalCost";
            this.lblEstimatedTotalCost.Size = new System.Drawing.Size(132, 16);
            this.lblEstimatedTotalCost.TabIndex = 93;
            this.lblEstimatedTotalCost.Text = "Estimated Total Cost";
            // 
            // tbNoOfProducts
            // 
            this.tbNoOfProducts.Location = new System.Drawing.Point(369, 361);
            this.tbNoOfProducts.Name = "tbNoOfProducts";
            this.tbNoOfProducts.ReadOnly = true;
            this.tbNoOfProducts.Size = new System.Drawing.Size(161, 20);
            this.tbNoOfProducts.TabIndex = 92;
            this.tbNoOfProducts.Text = "-";
            // 
            // lblNoOfProducts
            // 
            this.lblNoOfProducts.AutoSize = true;
            this.lblNoOfProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblNoOfProducts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNoOfProducts.Location = new System.Drawing.Point(366, 342);
            this.lblNoOfProducts.Name = "lblNoOfProducts";
            this.lblNoOfProducts.Size = new System.Drawing.Size(99, 16);
            this.lblNoOfProducts.TabIndex = 91;
            this.lblNoOfProducts.Text = "No. of Products";
            // 
            // dgvGoodsToOrder
            // 
            this.dgvGoodsToOrder.AllowUserToAddRows = false;
            this.dgvGoodsToOrder.AllowUserToDeleteRows = false;
            this.dgvGoodsToOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoodsToOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.requestedProductIdColumn,
            this.requestedProductNameColumn,
            this.priceColumn,
            this.quantityToReorderColumn,
            this.categoryColumn});
            this.dgvGoodsToOrder.Location = new System.Drawing.Point(369, 110);
            this.dgvGoodsToOrder.Name = "dgvGoodsToOrder";
            this.dgvGoodsToOrder.ReadOnly = true;
            this.dgvGoodsToOrder.RowTemplate.Height = 24;
            this.dgvGoodsToOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvGoodsToOrder.Size = new System.Drawing.Size(564, 212);
            this.dgvGoodsToOrder.TabIndex = 90;
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
            this.requestedProductNameColumn.Width = 180;
            // 
            // priceColumn
            // 
            this.priceColumn.HeaderText = "Price";
            this.priceColumn.Name = "priceColumn";
            this.priceColumn.ReadOnly = true;
            // 
            // quantityToReorderColumn
            // 
            this.quantityToReorderColumn.HeaderText = "Qty To Reorder";
            this.quantityToReorderColumn.Name = "quantityToReorderColumn";
            this.quantityToReorderColumn.ReadOnly = true;
            this.quantityToReorderColumn.Width = 120;
            // 
            // categoryColumn
            // 
            this.categoryColumn.HeaderText = "Category";
            this.categoryColumn.Name = "categoryColumn";
            this.categoryColumn.ReadOnly = true;
            this.categoryColumn.Width = 120;
            // 
            // tbApprovedOn
            // 
            this.tbApprovedOn.Location = new System.Drawing.Point(166, 361);
            this.tbApprovedOn.Name = "tbApprovedOn";
            this.tbApprovedOn.ReadOnly = true;
            this.tbApprovedOn.Size = new System.Drawing.Size(161, 20);
            this.tbApprovedOn.TabIndex = 89;
            this.tbApprovedOn.Text = "-";
            // 
            // lblApprovedOn
            // 
            this.lblApprovedOn.AutoSize = true;
            this.lblApprovedOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApprovedOn.Location = new System.Drawing.Point(34, 362);
            this.lblApprovedOn.Name = "lblApprovedOn";
            this.lblApprovedOn.Size = new System.Drawing.Size(91, 16);
            this.lblApprovedOn.TabIndex = 88;
            this.lblApprovedOn.Text = "Approved On:";
            // 
            // tbIsApproved
            // 
            this.tbIsApproved.Location = new System.Drawing.Point(166, 267);
            this.tbIsApproved.Name = "tbIsApproved";
            this.tbIsApproved.ReadOnly = true;
            this.tbIsApproved.Size = new System.Drawing.Size(161, 20);
            this.tbIsApproved.TabIndex = 87;
            // 
            // lblIsApproved
            // 
            this.lblIsApproved.AutoSize = true;
            this.lblIsApproved.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsApproved.Location = new System.Drawing.Point(34, 268);
            this.lblIsApproved.Name = "lblIsApproved";
            this.lblIsApproved.Size = new System.Drawing.Size(84, 16);
            this.lblIsApproved.TabIndex = 86;
            this.lblIsApproved.Text = "Is Approved:";
            // 
            // tbApprovedByStaffName
            // 
            this.tbApprovedByStaffName.Location = new System.Drawing.Point(166, 314);
            this.tbApprovedByStaffName.Name = "tbApprovedByStaffName";
            this.tbApprovedByStaffName.ReadOnly = true;
            this.tbApprovedByStaffName.Size = new System.Drawing.Size(161, 20);
            this.tbApprovedByStaffName.TabIndex = 85;
            this.tbApprovedByStaffName.Text = "-";
            // 
            // lblApprovedByStaffName
            // 
            this.lblApprovedByStaffName.AutoSize = true;
            this.lblApprovedByStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApprovedByStaffName.Location = new System.Drawing.Point(34, 315);
            this.lblApprovedByStaffName.Name = "lblApprovedByStaffName";
            this.lblApprovedByStaffName.Size = new System.Drawing.Size(119, 16);
            this.lblApprovedByStaffName.TabIndex = 84;
            this.lblApprovedByStaffName.Text = "Approved By Staff:";
            // 
            // tbCreatedByStaff
            // 
            this.tbCreatedByStaff.Location = new System.Drawing.Point(166, 163);
            this.tbCreatedByStaff.Name = "tbCreatedByStaff";
            this.tbCreatedByStaff.ReadOnly = true;
            this.tbCreatedByStaff.Size = new System.Drawing.Size(161, 20);
            this.tbCreatedByStaff.TabIndex = 83;
            // 
            // lblCreatedByStaff
            // 
            this.lblCreatedByStaff.AutoSize = true;
            this.lblCreatedByStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByStaff.Location = new System.Drawing.Point(34, 164);
            this.lblCreatedByStaff.Name = "lblCreatedByStaff";
            this.lblCreatedByStaff.Size = new System.Drawing.Size(106, 16);
            this.lblCreatedByStaff.TabIndex = 82;
            this.lblCreatedByStaff.Text = "Created by Staff:";
            // 
            // tbWarehouseName
            // 
            this.tbWarehouseName.Location = new System.Drawing.Point(166, 213);
            this.tbWarehouseName.Name = "tbWarehouseName";
            this.tbWarehouseName.ReadOnly = true;
            this.tbWarehouseName.Size = new System.Drawing.Size(161, 20);
            this.tbWarehouseName.TabIndex = 81;
            // 
            // lblWarehouseName
            // 
            this.lblWarehouseName.AutoSize = true;
            this.lblWarehouseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarehouseName.Location = new System.Drawing.Point(34, 214);
            this.lblWarehouseName.Name = "lblWarehouseName";
            this.lblWarehouseName.Size = new System.Drawing.Size(81, 16);
            this.lblWarehouseName.TabIndex = 80;
            this.lblWarehouseName.Text = "Warehouse:";
            // 
            // lblGoodsToOrder
            // 
            this.lblGoodsToOrder.AutoSize = true;
            this.lblGoodsToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoodsToOrder.Location = new System.Drawing.Point(581, 76);
            this.lblGoodsToOrder.Name = "lblGoodsToOrder";
            this.lblGoodsToOrder.Size = new System.Drawing.Size(133, 20);
            this.lblGoodsToOrder.TabIndex = 79;
            this.lblGoodsToOrder.Text = "Goods to Order";
            // 
            // tbCreatedOn
            // 
            this.tbCreatedOn.Location = new System.Drawing.Point(166, 123);
            this.tbCreatedOn.Name = "tbCreatedOn";
            this.tbCreatedOn.ReadOnly = true;
            this.tbCreatedOn.Size = new System.Drawing.Size(161, 20);
            this.tbCreatedOn.TabIndex = 78;
            // 
            // tbPurchaseOrderNumber
            // 
            this.tbPurchaseOrderNumber.Location = new System.Drawing.Point(166, 79);
            this.tbPurchaseOrderNumber.Name = "tbPurchaseOrderNumber";
            this.tbPurchaseOrderNumber.ReadOnly = true;
            this.tbPurchaseOrderNumber.Size = new System.Drawing.Size(161, 20);
            this.tbPurchaseOrderNumber.TabIndex = 77;
            // 
            // lblCreatedOn
            // 
            this.lblCreatedOn.AutoSize = true;
            this.lblCreatedOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedOn.Location = new System.Drawing.Point(34, 127);
            this.lblCreatedOn.Name = "lblCreatedOn";
            this.lblCreatedOn.Size = new System.Drawing.Size(79, 16);
            this.lblCreatedOn.TabIndex = 76;
            this.lblCreatedOn.Text = "Created On:";
            // 
            // lblPurchaseOrderNumber
            // 
            this.lblPurchaseOrderNumber.AutoSize = true;
            this.lblPurchaseOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseOrderNumber.Location = new System.Drawing.Point(34, 80);
            this.lblPurchaseOrderNumber.Name = "lblPurchaseOrderNumber";
            this.lblPurchaseOrderNumber.Size = new System.Drawing.Size(129, 16);
            this.lblPurchaseOrderNumber.TabIndex = 75;
            this.lblPurchaseOrderNumber.Text = "Purchase Order No.:";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(319, 22);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(301, 25);
            this.lblHeader.TabIndex = 74;
            this.lblHeader.Text = "Purchase Order Information";
            // 
            // tbSentToSupplierOn
            // 
            this.tbSentToSupplierOn.Location = new System.Drawing.Point(166, 403);
            this.tbSentToSupplierOn.Name = "tbSentToSupplierOn";
            this.tbSentToSupplierOn.ReadOnly = true;
            this.tbSentToSupplierOn.Size = new System.Drawing.Size(161, 20);
            this.tbSentToSupplierOn.TabIndex = 96;
            this.tbSentToSupplierOn.Text = "-";
            // 
            // lblSentToSupplierOn
            // 
            this.lblSentToSupplierOn.AutoSize = true;
            this.lblSentToSupplierOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSentToSupplierOn.Location = new System.Drawing.Point(34, 404);
            this.lblSentToSupplierOn.Name = "lblSentToSupplierOn";
            this.lblSentToSupplierOn.Size = new System.Drawing.Size(125, 16);
            this.lblSentToSupplierOn.TabIndex = 95;
            this.lblSentToSupplierOn.Text = "Sent to Supplier On:";
            // 
            // btnApproveAndSend
            // 
            this.btnApproveAndSend.BackColor = System.Drawing.Color.DarkOrange;
            this.btnApproveAndSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnApproveAndSend.ForeColor = System.Drawing.SystemColors.Window;
            this.btnApproveAndSend.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnApproveAndSend.Location = new System.Drawing.Point(746, 385);
            this.btnApproveAndSend.Name = "btnApproveAndSend";
            this.btnApproveAndSend.Size = new System.Drawing.Size(187, 52);
            this.btnApproveAndSend.TabIndex = 97;
            this.btnApproveAndSend.Text = "Approve Order + Send to Supplier";
            this.btnApproveAndSend.UseVisualStyleBackColor = false;
            this.btnApproveAndSend.Click += new System.EventHandler(this.btnApproveAndSend_Click);
            // 
            // btnCreateInwardGoodsRecord
            // 
            this.btnCreateInwardGoodsRecord.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCreateInwardGoodsRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCreateInwardGoodsRecord.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCreateInwardGoodsRecord.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCreateInwardGoodsRecord.Location = new System.Drawing.Point(780, 385);
            this.btnCreateInwardGoodsRecord.Name = "btnCreateInwardGoodsRecord";
            this.btnCreateInwardGoodsRecord.Size = new System.Drawing.Size(153, 52);
            this.btnCreateInwardGoodsRecord.TabIndex = 117;
            this.btnCreateInwardGoodsRecord.Text = "Create Inward Goods Record";
            this.btnCreateInwardGoodsRecord.UseVisualStyleBackColor = false;
            this.btnCreateInwardGoodsRecord.Visible = false;
            this.btnCreateInwardGoodsRecord.Click += new System.EventHandler(this.btnCreateInwardGoodsRecord_Click);
            // 
            // PurchaseOrderDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 461);
            this.Controls.Add(this.btnCreateInwardGoodsRecord);
            this.Controls.Add(this.btnApproveAndSend);
            this.Controls.Add(this.tbSentToSupplierOn);
            this.Controls.Add(this.lblSentToSupplierOn);
            this.Controls.Add(this.tbEstimatedTotalCost);
            this.Controls.Add(this.lblEstimatedTotalCost);
            this.Controls.Add(this.tbNoOfProducts);
            this.Controls.Add(this.lblNoOfProducts);
            this.Controls.Add(this.dgvGoodsToOrder);
            this.Controls.Add(this.tbApprovedOn);
            this.Controls.Add(this.lblApprovedOn);
            this.Controls.Add(this.tbIsApproved);
            this.Controls.Add(this.lblIsApproved);
            this.Controls.Add(this.tbApprovedByStaffName);
            this.Controls.Add(this.lblApprovedByStaffName);
            this.Controls.Add(this.tbCreatedByStaff);
            this.Controls.Add(this.lblCreatedByStaff);
            this.Controls.Add(this.tbWarehouseName);
            this.Controls.Add(this.lblWarehouseName);
            this.Controls.Add(this.lblGoodsToOrder);
            this.Controls.Add(this.tbCreatedOn);
            this.Controls.Add(this.tbPurchaseOrderNumber);
            this.Controls.Add(this.lblCreatedOn);
            this.Controls.Add(this.lblPurchaseOrderNumber);
            this.Controls.Add(this.lblHeader);
            this.Name = "PurchaseOrderDetailsForm";
            this.Text = "PurchaseOrderDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsToOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEstimatedTotalCost;
        private System.Windows.Forms.Label lblEstimatedTotalCost;
        private System.Windows.Forms.TextBox tbNoOfProducts;
        private System.Windows.Forms.Label lblNoOfProducts;
        private System.Windows.Forms.DataGridView dgvGoodsToOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestedProductIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestedProductNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityToReorderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryColumn;
        private System.Windows.Forms.TextBox tbApprovedOn;
        private System.Windows.Forms.Label lblApprovedOn;
        private System.Windows.Forms.TextBox tbIsApproved;
        private System.Windows.Forms.Label lblIsApproved;
        private System.Windows.Forms.TextBox tbApprovedByStaffName;
        private System.Windows.Forms.Label lblApprovedByStaffName;
        private System.Windows.Forms.TextBox tbCreatedByStaff;
        private System.Windows.Forms.Label lblCreatedByStaff;
        private System.Windows.Forms.TextBox tbWarehouseName;
        private System.Windows.Forms.Label lblWarehouseName;
        private System.Windows.Forms.Label lblGoodsToOrder;
        private System.Windows.Forms.TextBox tbCreatedOn;
        private System.Windows.Forms.TextBox tbPurchaseOrderNumber;
        private System.Windows.Forms.Label lblCreatedOn;
        private System.Windows.Forms.Label lblPurchaseOrderNumber;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox tbSentToSupplierOn;
        private System.Windows.Forms.Label lblSentToSupplierOn;
        private System.Windows.Forms.Button btnApproveAndSend;
        private System.Windows.Forms.Button btnCreateInwardGoodsRecord;
    }
}
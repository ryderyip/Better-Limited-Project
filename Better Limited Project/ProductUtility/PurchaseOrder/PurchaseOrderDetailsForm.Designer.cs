namespace Better_Limited_Project.ProductUtility.PurchaseOrder
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
            this.lblWarehouseInfo = new System.Windows.Forms.Label();
            this.lblWarehouseID = new System.Windows.Forms.Label();
            this.lblWarehouseName = new System.Windows.Forms.Label();
            this.lblWarehouseAddress = new System.Windows.Forms.Label();
            this.lblPurchaseOrderInfo = new System.Windows.Forms.Label();
            this.lblPurchaseOrderID = new System.Windows.Forms.Label();
            this.lblPurchaseOrderDate = new System.Windows.Forms.Label();
            this.lblPurchaseOrderRequestedBy = new System.Windows.Forms.Label();
            this.txtWarehouseID = new System.Windows.Forms.TextBox();
            this.txtWarehouseName = new System.Windows.Forms.TextBox();
            this.txtWarehouseAddress = new System.Windows.Forms.TextBox();
            this.txtPurchaseOrderID = new System.Windows.Forms.TextBox();
            this.txtPurchaseOrderDate = new System.Windows.Forms.TextBox();
            this.txtPurchaseOrderRequestedBy = new System.Windows.Forms.TextBox();
            this.lblProductsInOrder = new System.Windows.Forms.Label();
            this.dgvProductsInOrder = new System.Windows.Forms.DataGridView();
            this.btnApproveOrder = new System.Windows.Forms.Button();
            this.btnDeclineOrder = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.btnSendToSupplier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsInOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWarehouseInfo
            // 
            this.lblWarehouseInfo.AutoSize = true;
            this.lblWarehouseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarehouseInfo.Location = new System.Drawing.Point(72, 57);
            this.lblWarehouseInfo.Name = "lblWarehouseInfo";
            this.lblWarehouseInfo.Size = new System.Drawing.Size(137, 20);
            this.lblWarehouseInfo.TabIndex = 0;
            this.lblWarehouseInfo.Text = "Warehouse Info";
            // 
            // lblWarehouseID
            // 
            this.lblWarehouseID.AutoSize = true;
            this.lblWarehouseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarehouseID.Location = new System.Drawing.Point(73, 98);
            this.lblWarehouseID.Name = "lblWarehouseID";
            this.lblWarehouseID.Size = new System.Drawing.Size(22, 15);
            this.lblWarehouseID.TabIndex = 1;
            this.lblWarehouseID.Text = "ID:";
            // 
            // lblWarehouseName
            // 
            this.lblWarehouseName.AutoSize = true;
            this.lblWarehouseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarehouseName.Location = new System.Drawing.Point(73, 146);
            this.lblWarehouseName.Name = "lblWarehouseName";
            this.lblWarehouseName.Size = new System.Drawing.Size(44, 15);
            this.lblWarehouseName.TabIndex = 2;
            this.lblWarehouseName.Text = "Name:";
            // 
            // lblWarehouseAddress
            // 
            this.lblWarehouseAddress.AutoSize = true;
            this.lblWarehouseAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarehouseAddress.Location = new System.Drawing.Point(73, 195);
            this.lblWarehouseAddress.Name = "lblWarehouseAddress";
            this.lblWarehouseAddress.Size = new System.Drawing.Size(54, 15);
            this.lblWarehouseAddress.TabIndex = 3;
            this.lblWarehouseAddress.Text = "Address:";
            // 
            // lblPurchaseOrderInfo
            // 
            this.lblPurchaseOrderInfo.AutoSize = true;
            this.lblPurchaseOrderInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseOrderInfo.Location = new System.Drawing.Point(72, 240);
            this.lblPurchaseOrderInfo.Name = "lblPurchaseOrderInfo";
            this.lblPurchaseOrderInfo.Size = new System.Drawing.Size(171, 20);
            this.lblPurchaseOrderInfo.TabIndex = 4;
            this.lblPurchaseOrderInfo.Text = "Purchase Order Info";
            // 
            // lblPurchaseOrderID
            // 
            this.lblPurchaseOrderID.AutoSize = true;
            this.lblPurchaseOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseOrderID.Location = new System.Drawing.Point(73, 280);
            this.lblPurchaseOrderID.Name = "lblPurchaseOrderID";
            this.lblPurchaseOrderID.Size = new System.Drawing.Size(22, 15);
            this.lblPurchaseOrderID.TabIndex = 5;
            this.lblPurchaseOrderID.Text = "ID:";
            // 
            // lblPurchaseOrderDate
            // 
            this.lblPurchaseOrderDate.AutoSize = true;
            this.lblPurchaseOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseOrderDate.Location = new System.Drawing.Point(73, 322);
            this.lblPurchaseOrderDate.Name = "lblPurchaseOrderDate";
            this.lblPurchaseOrderDate.Size = new System.Drawing.Size(36, 15);
            this.lblPurchaseOrderDate.TabIndex = 6;
            this.lblPurchaseOrderDate.Text = "Date:";
            // 
            // lblPurchaseOrderRequestedBy
            // 
            this.lblPurchaseOrderRequestedBy.AutoSize = true;
            this.lblPurchaseOrderRequestedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseOrderRequestedBy.Location = new System.Drawing.Point(73, 371);
            this.lblPurchaseOrderRequestedBy.Name = "lblPurchaseOrderRequestedBy";
            this.lblPurchaseOrderRequestedBy.Size = new System.Drawing.Size(85, 15);
            this.lblPurchaseOrderRequestedBy.TabIndex = 7;
            this.lblPurchaseOrderRequestedBy.Text = "Requested by:";
            // 
            // txtWarehouseID
            // 
            this.txtWarehouseID.Location = new System.Drawing.Point(134, 98);
            this.txtWarehouseID.Name = "txtWarehouseID";
            this.txtWarehouseID.Size = new System.Drawing.Size(82, 22);
            this.txtWarehouseID.TabIndex = 8;
            // 
            // txtWarehouseName
            // 
            this.txtWarehouseName.Location = new System.Drawing.Point(134, 146);
            this.txtWarehouseName.Name = "txtWarehouseName";
            this.txtWarehouseName.Size = new System.Drawing.Size(100, 22);
            this.txtWarehouseName.TabIndex = 9;
            // 
            // txtWarehouseAddress
            // 
            this.txtWarehouseAddress.Location = new System.Drawing.Point(134, 195);
            this.txtWarehouseAddress.Name = "txtWarehouseAddress";
            this.txtWarehouseAddress.Size = new System.Drawing.Size(100, 22);
            this.txtWarehouseAddress.TabIndex = 10;
            // 
            // txtPurchaseOrderID
            // 
            this.txtPurchaseOrderID.Location = new System.Drawing.Point(134, 273);
            this.txtPurchaseOrderID.Name = "txtPurchaseOrderID";
            this.txtPurchaseOrderID.Size = new System.Drawing.Size(82, 22);
            this.txtPurchaseOrderID.TabIndex = 11;
            // 
            // txtPurchaseOrderDate
            // 
            this.txtPurchaseOrderDate.Location = new System.Drawing.Point(134, 322);
            this.txtPurchaseOrderDate.Name = "txtPurchaseOrderDate";
            this.txtPurchaseOrderDate.Size = new System.Drawing.Size(100, 22);
            this.txtPurchaseOrderDate.TabIndex = 12;
            // 
            // txtPurchaseOrderRequestedBy
            // 
            this.txtPurchaseOrderRequestedBy.Location = new System.Drawing.Point(164, 371);
            this.txtPurchaseOrderRequestedBy.Name = "txtPurchaseOrderRequestedBy";
            this.txtPurchaseOrderRequestedBy.Size = new System.Drawing.Size(100, 22);
            this.txtPurchaseOrderRequestedBy.TabIndex = 13;
            // 
            // lblProductsInOrder
            // 
            this.lblProductsInOrder.AutoSize = true;
            this.lblProductsInOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductsInOrder.Location = new System.Drawing.Point(361, 57);
            this.lblProductsInOrder.Name = "lblProductsInOrder";
            this.lblProductsInOrder.Size = new System.Drawing.Size(151, 20);
            this.lblProductsInOrder.TabIndex = 14;
            this.lblProductsInOrder.Text = "Products In Order";
            // 
            // dgvProductsInOrder
            // 
            this.dgvProductsInOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsInOrder.Location = new System.Drawing.Point(365, 98);
            this.dgvProductsInOrder.Name = "dgvProductsInOrder";
            this.dgvProductsInOrder.RowTemplate.Height = 24;
            this.dgvProductsInOrder.Size = new System.Drawing.Size(391, 154);
            this.dgvProductsInOrder.TabIndex = 15;
            // 
            // btnApproveOrder
            // 
            this.btnApproveOrder.BackColor = System.Drawing.Color.DarkOrange;
            this.btnApproveOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApproveOrder.ForeColor = System.Drawing.SystemColors.Window;
            this.btnApproveOrder.Location = new System.Drawing.Point(365, 280);
            this.btnApproveOrder.Name = "btnApproveOrder";
            this.btnApproveOrder.Size = new System.Drawing.Size(183, 41);
            this.btnApproveOrder.TabIndex = 42;
            this.btnApproveOrder.Text = "Approve Order";
            this.btnApproveOrder.UseVisualStyleBackColor = false;
            // 
            // btnDeclineOrder
            // 
            this.btnDeclineOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeclineOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeclineOrder.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDeclineOrder.Location = new System.Drawing.Point(570, 280);
            this.btnDeclineOrder.Name = "btnDeclineOrder";
            this.btnDeclineOrder.Size = new System.Drawing.Size(174, 41);
            this.btnDeclineOrder.TabIndex = 43;
            this.btnDeclineOrder.Text = "Decline Order";
            this.btnDeclineOrder.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Gray;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBack.Location = new System.Drawing.Point(570, 345);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(174, 70);
            this.btnBack.TabIndex = 44;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnInvoice
            // 
            this.btnInvoice.BackColor = System.Drawing.Color.DarkOrange;
            this.btnInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoice.ForeColor = System.Drawing.SystemColors.Window;
            this.btnInvoice.Location = new System.Drawing.Point(365, 327);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(183, 41);
            this.btnInvoice.TabIndex = 45;
            this.btnInvoice.Text = "Invoice";
            this.btnInvoice.UseVisualStyleBackColor = false;
            this.btnInvoice.Visible = false;
            // 
            // btnSendToSupplier
            // 
            this.btnSendToSupplier.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSendToSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendToSupplier.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSendToSupplier.Location = new System.Drawing.Point(365, 374);
            this.btnSendToSupplier.Name = "btnSendToSupplier";
            this.btnSendToSupplier.Size = new System.Drawing.Size(183, 41);
            this.btnSendToSupplier.TabIndex = 46;
            this.btnSendToSupplier.Text = "Send To Supplier";
            this.btnSendToSupplier.UseVisualStyleBackColor = false;
            // 
            // PurchaseOrderDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSendToSupplier);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDeclineOrder);
            this.Controls.Add(this.btnApproveOrder);
            this.Controls.Add(this.dgvProductsInOrder);
            this.Controls.Add(this.lblProductsInOrder);
            this.Controls.Add(this.txtPurchaseOrderRequestedBy);
            this.Controls.Add(this.txtPurchaseOrderDate);
            this.Controls.Add(this.txtPurchaseOrderID);
            this.Controls.Add(this.txtWarehouseAddress);
            this.Controls.Add(this.txtWarehouseName);
            this.Controls.Add(this.txtWarehouseID);
            this.Controls.Add(this.lblPurchaseOrderRequestedBy);
            this.Controls.Add(this.lblPurchaseOrderDate);
            this.Controls.Add(this.lblPurchaseOrderID);
            this.Controls.Add(this.lblPurchaseOrderInfo);
            this.Controls.Add(this.lblWarehouseAddress);
            this.Controls.Add(this.lblWarehouseName);
            this.Controls.Add(this.lblWarehouseID);
            this.Controls.Add(this.lblWarehouseInfo);
            this.Name = "PurchaseOrderDetailsForm";
            this.Text = "PurchaseOrderDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsInOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWarehouseInfo;
        private System.Windows.Forms.Label lblWarehouseID;
        private System.Windows.Forms.Label lblWarehouseName;
        private System.Windows.Forms.Label lblWarehouseAddress;
        private System.Windows.Forms.Label lblPurchaseOrderInfo;
        private System.Windows.Forms.Label lblPurchaseOrderID;
        private System.Windows.Forms.Label lblPurchaseOrderDate;
        private System.Windows.Forms.Label lblPurchaseOrderRequestedBy;
        private System.Windows.Forms.TextBox txtWarehouseID;
        private System.Windows.Forms.TextBox txtWarehouseName;
        private System.Windows.Forms.TextBox txtWarehouseAddress;
        private System.Windows.Forms.TextBox txtPurchaseOrderID;
        private System.Windows.Forms.TextBox txtPurchaseOrderDate;
        private System.Windows.Forms.TextBox txtPurchaseOrderRequestedBy;
        private System.Windows.Forms.Label lblProductsInOrder;
        private System.Windows.Forms.DataGridView dgvProductsInOrder;
        private System.Windows.Forms.Button btnApproveOrder;
        private System.Windows.Forms.Button btnDeclineOrder;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button btnSendToSupplier;
    }
}
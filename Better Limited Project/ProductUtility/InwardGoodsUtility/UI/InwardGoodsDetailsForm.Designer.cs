namespace Better_Limited_Project.ProductUtility.InwardGoodsUtility.UI
{
    partial class InwardGoodsDetailsForm
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
            this.lblGoodsReceived = new System.Windows.Forms.Label();
            this.tbReceivedByStaff = new System.Windows.Forms.TextBox();
            this.lblReceivedByStaffName = new System.Windows.Forms.Label();
            this.tbPurchaseOrderNumber = new System.Windows.Forms.TextBox();
            this.lblPurchaseOrderNumber = new System.Windows.Forms.Label();
            this.tbReceivedOn = new System.Windows.Forms.TextBox();
            this.lblReceivedOn = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.dgvReceivedGoods = new System.Windows.Forms.DataGridView();
            this.requestedProductIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedProductsNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedProductsQuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceivedGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGoodsReceived
            // 
            this.lblGoodsReceived.AutoSize = true;
            this.lblGoodsReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoodsReceived.Location = new System.Drawing.Point(299, 72);
            this.lblGoodsReceived.Name = "lblGoodsReceived";
            this.lblGoodsReceived.Size = new System.Drawing.Size(165, 24);
            this.lblGoodsReceived.TabIndex = 22;
            this.lblGoodsReceived.Text = "Goods Received";
            // 
            // tbReceivedByStaff
            // 
            this.tbReceivedByStaff.Location = new System.Drawing.Point(37, 285);
            this.tbReceivedByStaff.Name = "tbReceivedByStaff";
            this.tbReceivedByStaff.ReadOnly = true;
            this.tbReceivedByStaff.Size = new System.Drawing.Size(161, 20);
            this.tbReceivedByStaff.TabIndex = 89;
            // 
            // lblReceivedByStaffName
            // 
            this.lblReceivedByStaffName.AutoSize = true;
            this.lblReceivedByStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceivedByStaffName.Location = new System.Drawing.Point(34, 266);
            this.lblReceivedByStaffName.Name = "lblReceivedByStaffName";
            this.lblReceivedByStaffName.Size = new System.Drawing.Size(114, 16);
            this.lblReceivedByStaffName.TabIndex = 88;
            this.lblReceivedByStaffName.Text = "Received by Staff";
            // 
            // tbPurchaseOrderNumber
            // 
            this.tbPurchaseOrderNumber.Location = new System.Drawing.Point(37, 138);
            this.tbPurchaseOrderNumber.Name = "tbPurchaseOrderNumber";
            this.tbPurchaseOrderNumber.ReadOnly = true;
            this.tbPurchaseOrderNumber.Size = new System.Drawing.Size(161, 20);
            this.tbPurchaseOrderNumber.TabIndex = 86;
            // 
            // lblPurchaseOrderNumber
            // 
            this.lblPurchaseOrderNumber.AutoSize = true;
            this.lblPurchaseOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseOrderNumber.Location = new System.Drawing.Point(34, 119);
            this.lblPurchaseOrderNumber.Name = "lblPurchaseOrderNumber";
            this.lblPurchaseOrderNumber.Size = new System.Drawing.Size(126, 16);
            this.lblPurchaseOrderNumber.TabIndex = 84;
            this.lblPurchaseOrderNumber.Text = "Purchase Order No.";
            // 
            // tbReceivedOn
            // 
            this.tbReceivedOn.Location = new System.Drawing.Point(37, 210);
            this.tbReceivedOn.Name = "tbReceivedOn";
            this.tbReceivedOn.ReadOnly = true;
            this.tbReceivedOn.Size = new System.Drawing.Size(161, 20);
            this.tbReceivedOn.TabIndex = 91;
            // 
            // lblReceivedOn
            // 
            this.lblReceivedOn.AutoSize = true;
            this.lblReceivedOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceivedOn.Location = new System.Drawing.Point(34, 191);
            this.lblReceivedOn.Name = "lblReceivedOn";
            this.lblReceivedOn.Size = new System.Drawing.Size(87, 16);
            this.lblReceivedOn.TabIndex = 90;
            this.lblReceivedOn.Text = "Received On";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(136, 24);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(301, 25);
            this.lblHeader.TabIndex = 92;
            this.lblHeader.Text = "Purchase Order Information";
            // 
            // dgvReceivedGoods
            // 
            this.dgvReceivedGoods.AllowUserToAddRows = false;
            this.dgvReceivedGoods.AllowUserToDeleteRows = false;
            this.dgvReceivedGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceivedGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.requestedProductIdColumn,
            this.receivedProductsNameColumn,
            this.receivedProductsQuantityColumn});
            this.dgvReceivedGoods.Location = new System.Drawing.Point(242, 109);
            this.dgvReceivedGoods.Name = "dgvReceivedGoods";
            this.dgvReceivedGoods.ReadOnly = true;
            this.dgvReceivedGoods.RowTemplate.Height = 24;
            this.dgvReceivedGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceivedGoods.Size = new System.Drawing.Size(293, 196);
            this.dgvReceivedGoods.TabIndex = 218;
            // 
            // requestedProductIdColumn
            // 
            this.requestedProductIdColumn.HeaderText = "id";
            this.requestedProductIdColumn.Name = "requestedProductIdColumn";
            this.requestedProductIdColumn.ReadOnly = true;
            this.requestedProductIdColumn.Visible = false;
            // 
            // receivedProductsNameColumn
            // 
            this.receivedProductsNameColumn.HeaderText = "Product";
            this.receivedProductsNameColumn.Name = "receivedProductsNameColumn";
            this.receivedProductsNameColumn.ReadOnly = true;
            this.receivedProductsNameColumn.Width = 200;
            // 
            // receivedProductsQuantityColumn
            // 
            this.receivedProductsQuantityColumn.HeaderText = "Qty";
            this.receivedProductsQuantityColumn.Name = "receivedProductsQuantityColumn";
            this.receivedProductsQuantityColumn.ReadOnly = true;
            this.receivedProductsQuantityColumn.Width = 50;
            // 
            // InwardGoodsDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 342);
            this.Controls.Add(this.dgvReceivedGoods);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.tbReceivedOn);
            this.Controls.Add(this.lblReceivedOn);
            this.Controls.Add(this.tbReceivedByStaff);
            this.Controls.Add(this.lblReceivedByStaffName);
            this.Controls.Add(this.tbPurchaseOrderNumber);
            this.Controls.Add(this.lblPurchaseOrderNumber);
            this.Controls.Add(this.lblGoodsReceived);
            this.Name = "InwardGoodsDetailsForm";
            this.Text = "InwardGoodsDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceivedGoods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGoodsReceived;
        private System.Windows.Forms.TextBox tbReceivedByStaff;
        private System.Windows.Forms.Label lblReceivedByStaffName;
        private System.Windows.Forms.TextBox tbPurchaseOrderNumber;
        private System.Windows.Forms.Label lblPurchaseOrderNumber;
        private System.Windows.Forms.TextBox tbReceivedOn;
        private System.Windows.Forms.Label lblReceivedOn;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridView dgvReceivedGoods;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestedProductIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedProductsNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedProductsQuantityColumn;
    }
}
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
            this.tbPurchaseOrderNumber = new System.Windows.Forms.TextBox();
            this.lblPurchaseOrderNumber = new System.Windows.Forms.Label();
            this.tbReceivedOn = new System.Windows.Forms.TextBox();
            this.lblReceivedOn = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.dgvReceivedGoods = new System.Windows.Forms.DataGridView();
            this.requestedProductIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedProductsNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedProductsQuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnViewPurchaseOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceivedGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGoodsReceived
            // 
            this.lblGoodsReceived.AutoSize = true;
            this.lblGoodsReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoodsReceived.Location = new System.Drawing.Point(284, 73);
            this.lblGoodsReceived.Name = "lblGoodsReceived";
            this.lblGoodsReceived.Size = new System.Drawing.Size(165, 24);
            this.lblGoodsReceived.TabIndex = 22;
            this.lblGoodsReceived.Text = "Goods Received";
            // 
            // tbPurchaseOrderNumber
            // 
            this.tbPurchaseOrderNumber.Location = new System.Drawing.Point(24, 129);
            this.tbPurchaseOrderNumber.Name = "tbPurchaseOrderNumber";
            this.tbPurchaseOrderNumber.ReadOnly = true;
            this.tbPurchaseOrderNumber.Size = new System.Drawing.Size(161, 20);
            this.tbPurchaseOrderNumber.TabIndex = 86;
            // 
            // lblPurchaseOrderNumber
            // 
            this.lblPurchaseOrderNumber.AutoSize = true;
            this.lblPurchaseOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseOrderNumber.Location = new System.Drawing.Point(21, 110);
            this.lblPurchaseOrderNumber.Name = "lblPurchaseOrderNumber";
            this.lblPurchaseOrderNumber.Size = new System.Drawing.Size(126, 16);
            this.lblPurchaseOrderNumber.TabIndex = 84;
            this.lblPurchaseOrderNumber.Text = "Purchase Order No.";
            // 
            // tbReceivedOn
            // 
            this.tbReceivedOn.Location = new System.Drawing.Point(24, 201);
            this.tbReceivedOn.Name = "tbReceivedOn";
            this.tbReceivedOn.ReadOnly = true;
            this.tbReceivedOn.Size = new System.Drawing.Size(161, 20);
            this.tbReceivedOn.TabIndex = 91;
            // 
            // lblReceivedOn
            // 
            this.lblReceivedOn.AutoSize = true;
            this.lblReceivedOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceivedOn.Location = new System.Drawing.Point(21, 182);
            this.lblReceivedOn.Name = "lblReceivedOn";
            this.lblReceivedOn.Size = new System.Drawing.Size(87, 16);
            this.lblReceivedOn.TabIndex = 90;
            this.lblReceivedOn.Text = "Received On";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(135, 25);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(280, 25);
            this.lblHeader.TabIndex = 92;
            this.lblHeader.Text = "Inward Goods Information";
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
            this.dgvReceivedGoods.Location = new System.Drawing.Point(227, 110);
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
            // btnViewPurchaseOrder
            // 
            this.btnViewPurchaseOrder.BackColor = System.Drawing.Color.DarkOrange;
            this.btnViewPurchaseOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewPurchaseOrder.ForeColor = System.Drawing.SystemColors.Window;
            this.btnViewPurchaseOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnViewPurchaseOrder.Location = new System.Drawing.Point(24, 254);
            this.btnViewPurchaseOrder.Name = "btnViewPurchaseOrder";
            this.btnViewPurchaseOrder.Size = new System.Drawing.Size(161, 52);
            this.btnViewPurchaseOrder.TabIndex = 219;
            this.btnViewPurchaseOrder.Text = "View Purchase Orders";
            this.btnViewPurchaseOrder.UseVisualStyleBackColor = false;
            this.btnViewPurchaseOrder.Click += new System.EventHandler(this.btnViewPurchaseOrder_Click);
            // 
            // InwardGoodsDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 334);
            this.Controls.Add(this.btnViewPurchaseOrder);
            this.Controls.Add(this.dgvReceivedGoods);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.tbReceivedOn);
            this.Controls.Add(this.lblReceivedOn);
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
        private System.Windows.Forms.TextBox tbPurchaseOrderNumber;
        private System.Windows.Forms.Label lblPurchaseOrderNumber;
        private System.Windows.Forms.TextBox tbReceivedOn;
        private System.Windows.Forms.Label lblReceivedOn;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridView dgvReceivedGoods;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestedProductIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedProductsNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedProductsQuantityColumn;
        private System.Windows.Forms.Button btnViewPurchaseOrder;
    }
}
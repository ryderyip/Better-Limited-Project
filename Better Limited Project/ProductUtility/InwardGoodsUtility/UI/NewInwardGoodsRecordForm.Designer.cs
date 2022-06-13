
namespace Better_Limited_Project.ProductUtility.InwardGoodsUtility.UI
{
    partial class NewInwardGoodsRecordForm
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
            this.btnChoosePurchaseOrder = new System.Windows.Forms.Button();
            this.tbPurchaseOrder = new System.Windows.Forms.TextBox();
            this.btnChooseReceivedGoods = new System.Windows.Forms.Button();
            this.lblPurchaseOrder = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblDateReceived = new System.Windows.Forms.Label();
            this.tbDateReceived = new System.Windows.Forms.TextBox();
            this.lblReceivedGoods = new System.Windows.Forms.Label();
            this.dgvReceivedGoods = new System.Windows.Forms.DataGridView();
            this.requestedProductIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedProductsNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedProductsQuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPurchasedGoods = new System.Windows.Forms.Label();
            this.lblMissingGoods = new System.Windows.Forms.Label();
            this.dgvPurchasedGoods = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMissingGoods = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceivedGoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchasedGoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMissingGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChoosePurchaseOrder
            // 
            this.btnChoosePurchaseOrder.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnChoosePurchaseOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnChoosePurchaseOrder.ForeColor = System.Drawing.SystemColors.Window;
            this.btnChoosePurchaseOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnChoosePurchaseOrder.Location = new System.Drawing.Point(198, 129);
            this.btnChoosePurchaseOrder.Name = "btnChoosePurchaseOrder";
            this.btnChoosePurchaseOrder.Size = new System.Drawing.Size(111, 36);
            this.btnChoosePurchaseOrder.TabIndex = 212;
            this.btnChoosePurchaseOrder.Text = "Choose Order";
            this.btnChoosePurchaseOrder.UseVisualStyleBackColor = false;
            this.btnChoosePurchaseOrder.Click += new System.EventHandler(this.btnChoosePurchaseOrder_Click);
            // 
            // tbPurchaseOrder
            // 
            this.tbPurchaseOrder.Location = new System.Drawing.Point(30, 103);
            this.tbPurchaseOrder.Name = "tbPurchaseOrder";
            this.tbPurchaseOrder.ReadOnly = true;
            this.tbPurchaseOrder.Size = new System.Drawing.Size(279, 20);
            this.tbPurchaseOrder.TabIndex = 211;
            // 
            // btnChooseReceivedGoods
            // 
            this.btnChooseReceivedGoods.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnChooseReceivedGoods.Enabled = false;
            this.btnChooseReceivedGoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnChooseReceivedGoods.ForeColor = System.Drawing.SystemColors.Window;
            this.btnChooseReceivedGoods.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnChooseReceivedGoods.Location = new System.Drawing.Point(187, 498);
            this.btnChooseReceivedGoods.Name = "btnChooseReceivedGoods";
            this.btnChooseReceivedGoods.Size = new System.Drawing.Size(122, 36);
            this.btnChooseReceivedGoods.TabIndex = 210;
            this.btnChooseReceivedGoods.Text = "Choose Goods";
            this.btnChooseReceivedGoods.UseVisualStyleBackColor = false;
            this.btnChooseReceivedGoods.Click += new System.EventHandler(this.btnChooseReceivedGoods_Click);
            // 
            // lblPurchaseOrder
            // 
            this.lblPurchaseOrder.AutoSize = true;
            this.lblPurchaseOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblPurchaseOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPurchaseOrder.Location = new System.Drawing.Point(27, 85);
            this.lblPurchaseOrder.Name = "lblPurchaseOrder";
            this.lblPurchaseOrder.Size = new System.Drawing.Size(93, 15);
            this.lblPurchaseOrder.TabIndex = 205;
            this.lblPurchaseOrder.Text = "Purchase Order";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCreate.Enabled = false;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCreate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCreate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCreate.Location = new System.Drawing.Point(241, 565);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(183, 49);
            this.btnCreate.TabIndex = 198;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHeader.Location = new System.Drawing.Point(138, 23);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(403, 26);
            this.lblHeader.TabIndex = 197;
            this.lblHeader.Text = "Create/Update Inward Goods Record";
            // 
            // lblDateReceived
            // 
            this.lblDateReceived.AutoSize = true;
            this.lblDateReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblDateReceived.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDateReceived.Location = new System.Drawing.Point(27, 178);
            this.lblDateReceived.Name = "lblDateReceived";
            this.lblDateReceived.Size = new System.Drawing.Size(87, 15);
            this.lblDateReceived.TabIndex = 213;
            this.lblDateReceived.Text = "Date Received";
            // 
            // tbDateReceived
            // 
            this.tbDateReceived.Location = new System.Drawing.Point(30, 196);
            this.tbDateReceived.Name = "tbDateReceived";
            this.tbDateReceived.ReadOnly = true;
            this.tbDateReceived.Size = new System.Drawing.Size(279, 20);
            this.tbDateReceived.TabIndex = 216;
            // 
            // lblReceivedGoods
            // 
            this.lblReceivedGoods.AutoSize = true;
            this.lblReceivedGoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceivedGoods.Location = new System.Drawing.Point(96, 252);
            this.lblReceivedGoods.Name = "lblReceivedGoods";
            this.lblReceivedGoods.Size = new System.Drawing.Size(141, 20);
            this.lblReceivedGoods.TabIndex = 218;
            this.lblReceivedGoods.Text = "Received Goods";
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
            this.dgvReceivedGoods.Location = new System.Drawing.Point(30, 286);
            this.dgvReceivedGoods.Name = "dgvReceivedGoods";
            this.dgvReceivedGoods.ReadOnly = true;
            this.dgvReceivedGoods.RowTemplate.Height = 24;
            this.dgvReceivedGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceivedGoods.Size = new System.Drawing.Size(279, 196);
            this.dgvReceivedGoods.TabIndex = 217;
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
            this.receivedProductsNameColumn.Width = 170;
            // 
            // receivedProductsQuantityColumn
            // 
            this.receivedProductsQuantityColumn.HeaderText = "Qty";
            this.receivedProductsQuantityColumn.Name = "receivedProductsQuantityColumn";
            this.receivedProductsQuantityColumn.ReadOnly = true;
            this.receivedProductsQuantityColumn.Width = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(187, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 15);
            this.label3.TabIndex = 206;
            this.label3.Text = "*";
            // 
            // lblPurchasedGoods
            // 
            this.lblPurchasedGoods.AutoSize = true;
            this.lblPurchasedGoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchasedGoods.Location = new System.Drawing.Point(428, 71);
            this.lblPurchasedGoods.Name = "lblPurchasedGoods";
            this.lblPurchasedGoods.Size = new System.Drawing.Size(152, 20);
            this.lblPurchasedGoods.TabIndex = 220;
            this.lblPurchasedGoods.Text = "Purchased Goods";
            // 
            // lblMissingGoods
            // 
            this.lblMissingGoods.AutoSize = true;
            this.lblMissingGoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMissingGoods.Location = new System.Drawing.Point(440, 322);
            this.lblMissingGoods.Name = "lblMissingGoods";
            this.lblMissingGoods.Size = new System.Drawing.Size(127, 20);
            this.lblMissingGoods.TabIndex = 222;
            this.lblMissingGoods.Text = "Missing Goods";
            // 
            // dgvPurchasedGoods
            // 
            this.dgvPurchasedGoods.AllowUserToAddRows = false;
            this.dgvPurchasedGoods.AllowUserToDeleteRows = false;
            this.dgvPurchasedGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchasedGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvPurchasedGoods.Location = new System.Drawing.Point(365, 103);
            this.dgvPurchasedGoods.Name = "dgvPurchasedGoods";
            this.dgvPurchasedGoods.ReadOnly = true;
            this.dgvPurchasedGoods.RowTemplate.Height = 24;
            this.dgvPurchasedGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPurchasedGoods.Size = new System.Drawing.Size(279, 196);
            this.dgvPurchasedGoods.TabIndex = 223;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Product";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 170;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dgvMissingGoods
            // 
            this.dgvMissingGoods.AllowUserToAddRows = false;
            this.dgvMissingGoods.AllowUserToDeleteRows = false;
            this.dgvMissingGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMissingGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvMissingGoods.Location = new System.Drawing.Point(365, 356);
            this.dgvMissingGoods.Name = "dgvMissingGoods";
            this.dgvMissingGoods.ReadOnly = true;
            this.dgvMissingGoods.RowTemplate.Height = 24;
            this.dgvMissingGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMissingGoods.Size = new System.Drawing.Size(279, 178);
            this.dgvMissingGoods.TabIndex = 224;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Product";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 170;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(175, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 15);
            this.label1.TabIndex = 225;
            this.label1.Text = "*";
            // 
            // NewInwardGoodsRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 631);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMissingGoods);
            this.Controls.Add(this.dgvPurchasedGoods);
            this.Controls.Add(this.lblMissingGoods);
            this.Controls.Add(this.lblPurchasedGoods);
            this.Controls.Add(this.lblReceivedGoods);
            this.Controls.Add(this.dgvReceivedGoods);
            this.Controls.Add(this.tbDateReceived);
            this.Controls.Add(this.lblDateReceived);
            this.Controls.Add(this.btnChoosePurchaseOrder);
            this.Controls.Add(this.tbPurchaseOrder);
            this.Controls.Add(this.btnChooseReceivedGoods);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPurchaseOrder);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblHeader);
            this.Name = "NewInwardGoodsRecordForm";
            this.Text = "NewInwardGoodsRecordForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceivedGoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchasedGoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMissingGoods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChoosePurchaseOrder;
        private System.Windows.Forms.TextBox tbPurchaseOrder;
        private System.Windows.Forms.Button btnChooseReceivedGoods;
        private System.Windows.Forms.Label lblPurchaseOrder;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblDateReceived;
        private System.Windows.Forms.TextBox tbDateReceived;
        private System.Windows.Forms.Label lblReceivedGoods;
        private System.Windows.Forms.DataGridView dgvReceivedGoods;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPurchasedGoods;
        private System.Windows.Forms.Label lblMissingGoods;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestedProductIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedProductsNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedProductsQuantityColumn;
        private System.Windows.Forms.DataGridView dgvPurchasedGoods;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView dgvMissingGoods;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label1;
    }
}
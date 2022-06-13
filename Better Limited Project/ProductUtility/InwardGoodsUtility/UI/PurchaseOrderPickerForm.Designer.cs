
namespace Better_Limited_Project.ProductUtility.InwardGoodsUtility.UI
{
    partial class PurchaseOrderPickerForm
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
            this.dgvPurchaseOrders = new System.Windows.Forms.DataGridView();
            this.tbSearchBox = new System.Windows.Forms.TextBox();
            this.lblSearchBox = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderRequestNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdOnColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approvedOnColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPurchaseOrders
            // 
            this.dgvPurchaseOrders.AllowUserToAddRows = false;
            this.dgvPurchaseOrders.AllowUserToDeleteRows = false;
            this.dgvPurchaseOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.purchaseOrderNumber,
            this.reorderRequestNumberColumn,
            this.createdOnColumn,
            this.approvedOnColumn});
            this.dgvPurchaseOrders.Location = new System.Drawing.Point(38, 134);
            this.dgvPurchaseOrders.MultiSelect = false;
            this.dgvPurchaseOrders.Name = "dgvPurchaseOrders";
            this.dgvPurchaseOrders.ReadOnly = true;
            this.dgvPurchaseOrders.RowTemplate.Height = 24;
            this.dgvPurchaseOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPurchaseOrders.Size = new System.Drawing.Size(543, 272);
            this.dgvPurchaseOrders.TabIndex = 14;
            this.dgvPurchaseOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchaseOrders_CellDoubleClick);
            // 
            // tbSearchBox
            // 
            this.tbSearchBox.Location = new System.Drawing.Point(38, 89);
            this.tbSearchBox.Name = "tbSearchBox";
            this.tbSearchBox.Size = new System.Drawing.Size(252, 20);
            this.tbSearchBox.TabIndex = 13;
            this.tbSearchBox.TextChanged += new System.EventHandler(this.tbSearchBox_TextChanged);
            // 
            // lblSearchBox
            // 
            this.lblSearchBox.AutoSize = true;
            this.lblSearchBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSearchBox.Location = new System.Drawing.Point(35, 73);
            this.lblSearchBox.Name = "lblSearchBox";
            this.lblSearchBox.Size = new System.Drawing.Size(255, 13);
            this.lblSearchBox.TabIndex = 12;
            this.lblSearchBox.Text = "Search by Purchase Order No./Reoder Request No.";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHeader.Location = new System.Drawing.Point(184, 27);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(253, 26);
            this.lblHeader.TabIndex = 198;
            this.lblHeader.Text = "Select Purchase Order";
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "id";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Visible = false;
            // 
            // purchaseOrderNumber
            // 
            this.purchaseOrderNumber.HeaderText = "Purchase Order No.";
            this.purchaseOrderNumber.Name = "purchaseOrderNumber";
            this.purchaseOrderNumber.ReadOnly = true;
            this.purchaseOrderNumber.Width = 140;
            // 
            // reorderRequestNumberColumn
            // 
            this.reorderRequestNumberColumn.HeaderText = "Reorder Request No.";
            this.reorderRequestNumberColumn.Name = "reorderRequestNumberColumn";
            this.reorderRequestNumberColumn.ReadOnly = true;
            this.reorderRequestNumberColumn.Width = 140;
            // 
            // createdOnColumn
            // 
            this.createdOnColumn.HeaderText = "Created On";
            this.createdOnColumn.Name = "createdOnColumn";
            this.createdOnColumn.ReadOnly = true;
            this.createdOnColumn.Width = 110;
            // 
            // approvedOnColumn
            // 
            this.approvedOnColumn.HeaderText = "Approved On";
            this.approvedOnColumn.Name = "approvedOnColumn";
            this.approvedOnColumn.ReadOnly = true;
            this.approvedOnColumn.Width = 110;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSelect.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSelect.Location = new System.Drawing.Point(243, 427);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(134, 50);
            this.btnSelect.TabIndex = 199;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // PurchaseOrderPickerForm
            // 
            this.AcceptButton = this.btnSelect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 502);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.dgvPurchaseOrders);
            this.Controls.Add(this.tbSearchBox);
            this.Controls.Add(this.lblSearchBox);
            this.Name = "PurchaseOrderPickerForm";
            this.Text = "PurchaseOrderPickerForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvPurchaseOrders;
        public System.Windows.Forms.TextBox tbSearchBox;
        private System.Windows.Forms.Label lblSearchBox;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorderRequestNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdOnColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn approvedOnColumn;
        private System.Windows.Forms.Button btnSelect;
    }
}
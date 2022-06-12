
namespace Better_Limited_Project.ProductUtility.GoodsPurchasing.UI
{
    partial class PurchaseOrderListForm
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
            this.cbShowApproved = new System.Windows.Forms.CheckBox();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderRequestNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdOnColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isApprovedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approvedOnColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.isApprovedColumn,
            this.approvedOnColumn});
            this.dgvPurchaseOrders.Location = new System.Drawing.Point(23, 82);
            this.dgvPurchaseOrders.Name = "dgvPurchaseOrders";
            this.dgvPurchaseOrders.ReadOnly = true;
            this.dgvPurchaseOrders.RowTemplate.Height = 24;
            this.dgvPurchaseOrders.Size = new System.Drawing.Size(563, 347);
            this.dgvPurchaseOrders.TabIndex = 11;
            this.dgvPurchaseOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchaseOrders_CellDoubleClick);
            // 
            // tbSearchBox
            // 
            this.tbSearchBox.Location = new System.Drawing.Point(23, 37);
            this.tbSearchBox.Name = "tbSearchBox";
            this.tbSearchBox.Size = new System.Drawing.Size(252, 20);
            this.tbSearchBox.TabIndex = 10;
            // 
            // lblSearchBox
            // 
            this.lblSearchBox.AutoSize = true;
            this.lblSearchBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSearchBox.Location = new System.Drawing.Point(20, 21);
            this.lblSearchBox.Name = "lblSearchBox";
            this.lblSearchBox.Size = new System.Drawing.Size(255, 13);
            this.lblSearchBox.TabIndex = 9;
            this.lblSearchBox.Text = "Search by Purchase Order No./Reoder Request No.";
            // 
            // cbShowApproved
            // 
            this.cbShowApproved.AutoSize = true;
            this.cbShowApproved.Location = new System.Drawing.Point(296, 39);
            this.cbShowApproved.Name = "cbShowApproved";
            this.cbShowApproved.Size = new System.Drawing.Size(136, 17);
            this.cbShowApproved.TabIndex = 12;
            this.cbShowApproved.Text = "Show Approved Orders";
            this.cbShowApproved.UseVisualStyleBackColor = true;
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
            this.purchaseOrderNumber.Width = 130;
            // 
            // reorderRequestNumberColumn
            // 
            this.reorderRequestNumberColumn.HeaderText = "Reorder Request No.";
            this.reorderRequestNumberColumn.Name = "reorderRequestNumberColumn";
            this.reorderRequestNumberColumn.ReadOnly = true;
            this.reorderRequestNumberColumn.Width = 110;
            // 
            // createdOnColumn
            // 
            this.createdOnColumn.HeaderText = "Created On";
            this.createdOnColumn.Name = "createdOnColumn";
            this.createdOnColumn.ReadOnly = true;
            this.createdOnColumn.Width = 110;
            // 
            // isApprovedColumn
            // 
            this.isApprovedColumn.HeaderText = "Is Approved";
            this.isApprovedColumn.Name = "isApprovedColumn";
            this.isApprovedColumn.ReadOnly = true;
            this.isApprovedColumn.Width = 60;
            // 
            // approvedOnColumn
            // 
            this.approvedOnColumn.HeaderText = "Approved On";
            this.approvedOnColumn.Name = "approvedOnColumn";
            this.approvedOnColumn.ReadOnly = true;
            this.approvedOnColumn.Width = 110;
            // 
            // PurchaseOrderListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.cbShowApproved);
            this.Controls.Add(this.dgvPurchaseOrders);
            this.Controls.Add(this.tbSearchBox);
            this.Controls.Add(this.lblSearchBox);
            this.Name = "PurchaseOrderListForm";
            this.Text = "PurchaseOrderListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvPurchaseOrders;
        public System.Windows.Forms.TextBox tbSearchBox;
        private System.Windows.Forms.Label lblSearchBox;
        private System.Windows.Forms.CheckBox cbShowApproved;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorderRequestNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdOnColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isApprovedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn approvedOnColumn;
    }
}
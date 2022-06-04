
namespace Better_Limited_Project.ServiceUtility.Delivery.UI
{
    partial class DeliveryListForm
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
            this.dgvDeliveries = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryRequestIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedOnColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrangedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbSearchBox = new System.Windows.Forms.TextBox();
            this.lblSearchBox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveries)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDeliveries
            // 
            this.dgvDeliveries.AllowUserToAddRows = false;
            this.dgvDeliveries.AllowUserToDeleteRows = false;
            this.dgvDeliveries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeliveries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.deliveryRequestIdColumn,
            this.orderNumberColumn,
            this.statusColumn,
            this.updatedOnColumn,
            this.arrangedBy});
            this.dgvDeliveries.Location = new System.Drawing.Point(28, 99);
            this.dgvDeliveries.Name = "dgvDeliveries";
            this.dgvDeliveries.ReadOnly = true;
            this.dgvDeliveries.RowTemplate.Height = 24;
            this.dgvDeliveries.Size = new System.Drawing.Size(486, 323);
            this.dgvDeliveries.TabIndex = 15;
            this.dgvDeliveries.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeliveries_CellDoubleClick);
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "ID";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Visible = false;
            // 
            // deliveryRequestIdColumn
            // 
            this.deliveryRequestIdColumn.HeaderText = "Delivery Request ID";
            this.deliveryRequestIdColumn.Name = "deliveryRequestIdColumn";
            this.deliveryRequestIdColumn.ReadOnly = true;
            this.deliveryRequestIdColumn.Visible = false;
            // 
            // orderNumberColumn
            // 
            this.orderNumberColumn.HeaderText = "Order Number";
            this.orderNumberColumn.Name = "orderNumberColumn";
            this.orderNumberColumn.ReadOnly = true;
            this.orderNumberColumn.Width = 130;
            // 
            // statusColumn
            // 
            this.statusColumn.HeaderText = "Status";
            this.statusColumn.Name = "statusColumn";
            this.statusColumn.ReadOnly = true;
            // 
            // updatedOnColumn
            // 
            this.updatedOnColumn.HeaderText = "Last Updated";
            this.updatedOnColumn.Name = "updatedOnColumn";
            this.updatedOnColumn.ReadOnly = true;
            // 
            // arrangedBy
            // 
            this.arrangedBy.HeaderText = "Arranged By";
            this.arrangedBy.Name = "arrangedBy";
            this.arrangedBy.ReadOnly = true;
            // 
            // tbSearchBox
            // 
            this.tbSearchBox.Location = new System.Drawing.Point(28, 43);
            this.tbSearchBox.Name = "tbSearchBox";
            this.tbSearchBox.Size = new System.Drawing.Size(209, 20);
            this.tbSearchBox.TabIndex = 14;
            this.tbSearchBox.TextChanged += new System.EventHandler(this.tbSearchBox_TextChanged);
            // 
            // lblSearchBox
            // 
            this.lblSearchBox.AutoSize = true;
            this.lblSearchBox.Location = new System.Drawing.Point(26, 27);
            this.lblSearchBox.Name = "lblSearchBox";
            this.lblSearchBox.Size = new System.Drawing.Size(153, 13);
            this.lblSearchBox.TabIndex = 13;
            this.lblSearchBox.Text = "Search by Sales Order Number";
            // 
            // DeliveryListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 450);
            this.Controls.Add(this.dgvDeliveries);
            this.Controls.Add(this.tbSearchBox);
            this.Controls.Add(this.lblSearchBox);
            this.Name = "DeliveryListForm";
            this.Text = "DeliveryListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvDeliveries;
        public System.Windows.Forms.TextBox tbSearchBox;
        private System.Windows.Forms.Label lblSearchBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryRequestIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedOnColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrangedBy;
    }
}
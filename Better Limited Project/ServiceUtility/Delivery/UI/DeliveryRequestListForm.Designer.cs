
namespace Better_Limited_Project.ServiceUtility.Delivery.UI
{
    partial class DeliveryRequestListForm
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
            this.dgvDeliveryRequests = new System.Windows.Forms.DataGridView();
            this.orderNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdOnColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrangedOnColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliverySessionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbSearchBox = new System.Windows.Forms.TextBox();
            this.lblSearchBox = new System.Windows.Forms.Label();
            this.cbShowArrangedRequests = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveryRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDeliveryRequests
            // 
            this.dgvDeliveryRequests.AllowUserToAddRows = false;
            this.dgvDeliveryRequests.AllowUserToDeleteRows = false;
            this.dgvDeliveryRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeliveryRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNumberColumn,
            this.createdOnColumn,
            this.arrangedOnColumn,
            this.deliverySessionColumn});
            this.dgvDeliveryRequests.Location = new System.Drawing.Point(26, 99);
            this.dgvDeliveryRequests.Name = "dgvDeliveryRequests";
            this.dgvDeliveryRequests.ReadOnly = true;
            this.dgvDeliveryRequests.RowTemplate.Height = 24;
            this.dgvDeliveryRequests.Size = new System.Drawing.Size(473, 323);
            this.dgvDeliveryRequests.TabIndex = 20;
            this.dgvDeliveryRequests.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeliveryRequests_CellDoubleClick);
            // 
            // orderNumberColumn
            // 
            this.orderNumberColumn.HeaderText = "Order Number";
            this.orderNumberColumn.Name = "orderNumberColumn";
            this.orderNumberColumn.ReadOnly = true;
            this.orderNumberColumn.Width = 150;
            // 
            // createdOnColumn
            // 
            this.createdOnColumn.HeaderText = "Created On";
            this.createdOnColumn.Name = "createdOnColumn";
            this.createdOnColumn.ReadOnly = true;
            // 
            // arrangedOnColumn
            // 
            this.arrangedOnColumn.HeaderText = "Arranged On";
            this.arrangedOnColumn.Name = "arrangedOnColumn";
            this.arrangedOnColumn.ReadOnly = true;
            // 
            // deliverySessionColumn
            // 
            this.deliverySessionColumn.HeaderText = "Session";
            this.deliverySessionColumn.Name = "deliverySessionColumn";
            this.deliverySessionColumn.ReadOnly = true;
            this.deliverySessionColumn.Width = 80;
            // 
            // tbSearchBox
            // 
            this.tbSearchBox.Location = new System.Drawing.Point(26, 44);
            this.tbSearchBox.Name = "tbSearchBox";
            this.tbSearchBox.Size = new System.Drawing.Size(209, 20);
            this.tbSearchBox.TabIndex = 19;
            this.tbSearchBox.TextChanged += new System.EventHandler(this.tbSearchBox_TextChanged);
            // 
            // lblSearchBox
            // 
            this.lblSearchBox.AutoSize = true;
            this.lblSearchBox.Location = new System.Drawing.Point(24, 28);
            this.lblSearchBox.Name = "lblSearchBox";
            this.lblSearchBox.Size = new System.Drawing.Size(124, 13);
            this.lblSearchBox.TabIndex = 18;
            this.lblSearchBox.Text = "Search by Order Number";
            // 
            // cbShowArrangedRequests
            // 
            this.cbShowArrangedRequests.AutoSize = true;
            this.cbShowArrangedRequests.Location = new System.Drawing.Point(279, 46);
            this.cbShowArrangedRequests.Name = "cbShowArrangedRequests";
            this.cbShowArrangedRequests.Size = new System.Drawing.Size(147, 17);
            this.cbShowArrangedRequests.TabIndex = 21;
            this.cbShowArrangedRequests.Text = "Show Arranged Requests";
            this.cbShowArrangedRequests.UseVisualStyleBackColor = true;
            this.cbShowArrangedRequests.CheckedChanged += cbShowArrangedRequests_CheckedChanged;
            // 
            // DeliveryRequestListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 450);
            this.Controls.Add(this.cbShowArrangedRequests);
            this.Controls.Add(this.dgvDeliveryRequests);
            this.Controls.Add(this.tbSearchBox);
            this.Controls.Add(this.lblSearchBox);
            this.Name = "DeliveryRequestListForm";
            this.Text = "DeliveryRequestListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveryRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvDeliveryRequests;
        public System.Windows.Forms.TextBox tbSearchBox;
        private System.Windows.Forms.Label lblSearchBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdOnColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrangedOnColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverySessionColumn;
        private System.Windows.Forms.CheckBox cbShowArrangedRequests;
    }
}
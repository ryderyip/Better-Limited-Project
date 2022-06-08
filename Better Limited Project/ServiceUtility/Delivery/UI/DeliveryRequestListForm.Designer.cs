
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryRequestListForm));
            this.dgvDeliveryRequests = new System.Windows.Forms.DataGridView();
            this.tbSearchBox = new System.Windows.Forms.TextBox();
            this.lblSearchBox = new System.Windows.Forms.Label();
            this.cbShowArrangedRequests = new System.Windows.Forms.CheckBox();
            this.orderNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdOnColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrangedOnColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliverySessionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            resources.ApplyResources(this.dgvDeliveryRequests, "dgvDeliveryRequests");
            this.dgvDeliveryRequests.Name = "dgvDeliveryRequests";
            this.dgvDeliveryRequests.ReadOnly = true;
            this.dgvDeliveryRequests.RowTemplate.Height = 24;
            this.dgvDeliveryRequests.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeliveryRequests_CellDoubleClick);
            // 
            // tbSearchBox
            // 
            resources.ApplyResources(this.tbSearchBox, "tbSearchBox");
            this.tbSearchBox.Name = "tbSearchBox";
            this.tbSearchBox.TextChanged += new System.EventHandler(this.tbSearchBox_TextChanged);
            // 
            // lblSearchBox
            // 
            resources.ApplyResources(this.lblSearchBox, "lblSearchBox");
            this.lblSearchBox.Name = "lblSearchBox";
            // 
            // cbShowArrangedRequests
            // 
            resources.ApplyResources(this.cbShowArrangedRequests, "cbShowArrangedRequests");
            this.cbShowArrangedRequests.Name = "cbShowArrangedRequests";
            this.cbShowArrangedRequests.UseVisualStyleBackColor = true;
            // 
            // orderNumberColumn
            // 
            resources.ApplyResources(this.orderNumberColumn, "orderNumberColumn");
            this.orderNumberColumn.Name = "orderNumberColumn";
            this.orderNumberColumn.ReadOnly = true;
            // 
            // createdOnColumn
            // 
            resources.ApplyResources(this.createdOnColumn, "createdOnColumn");
            this.createdOnColumn.Name = "createdOnColumn";
            this.createdOnColumn.ReadOnly = true;
            // 
            // arrangedOnColumn
            // 
            resources.ApplyResources(this.arrangedOnColumn, "arrangedOnColumn");
            this.arrangedOnColumn.Name = "arrangedOnColumn";
            this.arrangedOnColumn.ReadOnly = true;
            // 
            // deliverySessionColumn
            // 
            resources.ApplyResources(this.deliverySessionColumn, "deliverySessionColumn");
            this.deliverySessionColumn.Name = "deliverySessionColumn";
            this.deliverySessionColumn.ReadOnly = true;
            // 
            // DeliveryRequestListForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbShowArrangedRequests);
            this.Controls.Add(this.dgvDeliveryRequests);
            this.Controls.Add(this.tbSearchBox);
            this.Controls.Add(this.lblSearchBox);
            this.Name = "DeliveryRequestListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveryRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvDeliveryRequests;
        public System.Windows.Forms.TextBox tbSearchBox;
        private System.Windows.Forms.Label lblSearchBox;
        private System.Windows.Forms.CheckBox cbShowArrangedRequests;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdOnColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrangedOnColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverySessionColumn;
    }
}
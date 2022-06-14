
namespace Better_Limited_Project.ServiceUtility.DeliveryUtility.UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryListForm));
            this.dgvDeliveries = new System.Windows.Forms.DataGridView();
            this.tbSearchBox = new System.Windows.Forms.TextBox();
            this.lblSearchBox = new System.Windows.Forms.Label();
            this.btnDailyDeliveryList = new System.Windows.Forms.Button();
            this.btnDeliveryRequests = new System.Windows.Forms.Button();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryRequestIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedOnColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrangedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            resources.ApplyResources(this.dgvDeliveries, "dgvDeliveries");
            this.dgvDeliveries.Name = "dgvDeliveries";
            this.dgvDeliveries.ReadOnly = true;
            this.dgvDeliveries.RowTemplate.Height = 24;
            this.dgvDeliveries.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeliveries_CellDoubleClick);
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
            // btnDailyDeliveryList
            // 
            this.btnDailyDeliveryList.BackColor = System.Drawing.SystemColors.MenuHighlight;
            resources.ApplyResources(this.btnDailyDeliveryList, "btnDailyDeliveryList");
            this.btnDailyDeliveryList.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDailyDeliveryList.Name = "btnDailyDeliveryList";
            this.btnDailyDeliveryList.UseVisualStyleBackColor = false;
            this.btnDailyDeliveryList.Click += new System.EventHandler(this.btnDailyDeliveryList_Click);
            // 
            // btnDeliveryRequests
            // 
            this.btnDeliveryRequests.BackColor = System.Drawing.Color.DarkOrange;
            resources.ApplyResources(this.btnDeliveryRequests, "btnDeliveryRequests");
            this.btnDeliveryRequests.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDeliveryRequests.Name = "btnDeliveryRequests";
            this.btnDeliveryRequests.UseVisualStyleBackColor = false;
            this.btnDeliveryRequests.Click += new System.EventHandler(this.btnDeliveryRequests_Click);
            // 
            // idColumn
            // 
            resources.ApplyResources(this.idColumn, "idColumn");
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            // 
            // deliveryRequestIdColumn
            // 
            resources.ApplyResources(this.deliveryRequestIdColumn, "deliveryRequestIdColumn");
            this.deliveryRequestIdColumn.Name = "deliveryRequestIdColumn";
            this.deliveryRequestIdColumn.ReadOnly = true;
            // 
            // orderNumberColumn
            // 
            resources.ApplyResources(this.orderNumberColumn, "orderNumberColumn");
            this.orderNumberColumn.Name = "orderNumberColumn";
            this.orderNumberColumn.ReadOnly = true;
            // 
            // statusColumn
            // 
            resources.ApplyResources(this.statusColumn, "statusColumn");
            this.statusColumn.Name = "statusColumn";
            this.statusColumn.ReadOnly = true;
            // 
            // updatedOnColumn
            // 
            resources.ApplyResources(this.updatedOnColumn, "updatedOnColumn");
            this.updatedOnColumn.Name = "updatedOnColumn";
            this.updatedOnColumn.ReadOnly = true;
            // 
            // arrangedBy
            // 
            resources.ApplyResources(this.arrangedBy, "arrangedBy");
            this.arrangedBy.Name = "arrangedBy";
            this.arrangedBy.ReadOnly = true;
            // 
            // DeliveryListForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDeliveryRequests);
            this.Controls.Add(this.btnDailyDeliveryList);
            this.Controls.Add(this.dgvDeliveries);
            this.Controls.Add(this.tbSearchBox);
            this.Controls.Add(this.lblSearchBox);
            this.Name = "DeliveryListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvDeliveries;
        public System.Windows.Forms.TextBox tbSearchBox;
        private System.Windows.Forms.Label lblSearchBox;
        private System.Windows.Forms.Button btnDailyDeliveryList;
        private System.Windows.Forms.Button btnDeliveryRequests;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryRequestIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedOnColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrangedBy;
    }
}
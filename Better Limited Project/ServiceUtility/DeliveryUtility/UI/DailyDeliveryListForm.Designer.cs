
namespace Better_Limited_Project.ServiceUtility.DeliveryUtility.UI
{
    partial class DailyDeliveryListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyDeliveryListForm));
            this.lblHeader = new System.Windows.Forms.Label();
            this.dgvDeliveries = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryRequestIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedOnColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrangedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.btnGenerateDeliveryList = new System.Windows.Forms.Button();
            this.btnPrintDeliveryList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveries)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            resources.ApplyResources(this.lblHeader, "lblHeader");
            this.lblHeader.Name = "lblHeader";
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
            // dtpDeliveryDate
            // 
            resources.ApplyResources(this.dtpDeliveryDate, "dtpDeliveryDate");
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.ValueChanged += new System.EventHandler(this.dtpDeliveryDate_ValueChanged);
            // 
            // lblDeliveryDate
            // 
            resources.ApplyResources(this.lblDeliveryDate, "lblDeliveryDate");
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            // 
            // btnGenerateDeliveryList
            // 
            this.btnGenerateDeliveryList.BackColor = System.Drawing.Color.DarkOrange;
            resources.ApplyResources(this.btnGenerateDeliveryList, "btnGenerateDeliveryList");
            this.btnGenerateDeliveryList.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGenerateDeliveryList.Name = "btnGenerateDeliveryList";
            this.btnGenerateDeliveryList.UseVisualStyleBackColor = false;
            this.btnGenerateDeliveryList.Click += new System.EventHandler(this.btnGenerateDeliveryList_Click);
            // 
            // btnPrintDeliveryList
            // 
            this.btnPrintDeliveryList.BackColor = System.Drawing.SystemColors.MenuHighlight;
            resources.ApplyResources(this.btnPrintDeliveryList, "btnPrintDeliveryList");
            this.btnPrintDeliveryList.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPrintDeliveryList.Name = "btnPrintDeliveryList";
            this.btnPrintDeliveryList.UseVisualStyleBackColor = false;
            this.btnPrintDeliveryList.Click += new System.EventHandler(this.btnPrintDeliveryList_Click);
            // 
            // DailyDeliveryListForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPrintDeliveryList);
            this.Controls.Add(this.btnGenerateDeliveryList);
            this.Controls.Add(this.lblDeliveryDate);
            this.Controls.Add(this.dtpDeliveryDate);
            this.Controls.Add(this.dgvDeliveries);
            this.Controls.Add(this.lblHeader);
            this.Name = "DailyDeliveryListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHeader;
        public System.Windows.Forms.DataGridView dgvDeliveries;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryRequestIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedOnColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrangedBy;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.Label lblDeliveryDate;
        private System.Windows.Forms.Button btnGenerateDeliveryList;
        private System.Windows.Forms.Button btnPrintDeliveryList;
    }
}
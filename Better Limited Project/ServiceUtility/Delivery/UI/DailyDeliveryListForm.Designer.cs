
namespace Better_Limited_Project.ServiceUtility.Delivery.UI
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
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(171, 24);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(203, 25);
            this.lblHeader.TabIndex = 111;
            this.lblHeader.Text = "Daily Delivery List";
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
            this.dgvDeliveries.Location = new System.Drawing.Point(31, 122);
            this.dgvDeliveries.Name = "dgvDeliveries";
            this.dgvDeliveries.ReadOnly = true;
            this.dgvDeliveries.RowTemplate.Height = 24;
            this.dgvDeliveries.Size = new System.Drawing.Size(474, 228);
            this.dgvDeliveries.TabIndex = 112;
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
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.Location = new System.Drawing.Point(126, 82);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDeliveryDate.TabIndex = 113;
            this.dtpDeliveryDate.ValueChanged += new System.EventHandler(this.dtpDeliveryDate_ValueChanged);
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryDate.Location = new System.Drawing.Point(28, 84);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(93, 16);
            this.lblDeliveryDate.TabIndex = 114;
            this.lblDeliveryDate.Text = "Delivery Date:";
            // 
            // btnGenerateDeliveryList
            // 
            this.btnGenerateDeliveryList.BackColor = System.Drawing.Color.DarkOrange;
            this.btnGenerateDeliveryList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateDeliveryList.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGenerateDeliveryList.Location = new System.Drawing.Point(31, 370);
            this.btnGenerateDeliveryList.Name = "btnGenerateDeliveryList";
            this.btnGenerateDeliveryList.Size = new System.Drawing.Size(185, 54);
            this.btnGenerateDeliveryList.TabIndex = 115;
            this.btnGenerateDeliveryList.Text = "Generate Delivery List";
            this.btnGenerateDeliveryList.UseVisualStyleBackColor = false;
            this.btnGenerateDeliveryList.Click += new System.EventHandler(this.btnGenerateDeliveryList_Click);
            // 
            // btnPrintDeliveryList
            // 
            this.btnPrintDeliveryList.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPrintDeliveryList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintDeliveryList.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPrintDeliveryList.Location = new System.Drawing.Point(352, 370);
            this.btnPrintDeliveryList.Name = "btnPrintDeliveryList";
            this.btnPrintDeliveryList.Size = new System.Drawing.Size(153, 54);
            this.btnPrintDeliveryList.TabIndex = 116;
            this.btnPrintDeliveryList.Text = "Print Delivery List";
            this.btnPrintDeliveryList.UseVisualStyleBackColor = false;
            this.btnPrintDeliveryList.Click += new System.EventHandler(this.btnPrintDeliveryList_Click);
            // 
            // DailyDeliveryListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 450);
            this.Controls.Add(this.btnPrintDeliveryList);
            this.Controls.Add(this.btnGenerateDeliveryList);
            this.Controls.Add(this.lblDeliveryDate);
            this.Controls.Add(this.dtpDeliveryDate);
            this.Controls.Add(this.dgvDeliveries);
            this.Controls.Add(this.lblHeader);
            this.Name = "DailyDeliveryListForm";
            this.Text = "DailyDeliveryListForm";
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
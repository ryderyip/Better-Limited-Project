namespace Better_Limited_Project.ProductUtility.PurchaseOrder
{
    partial class PurchaseOrdersForm
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
            this.lblSearchKeywords = new System.Windows.Forms.Label();
            this.txtSearchKeywords = new System.Windows.Forms.TextBox();
            this.lblSearchDate = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dgvPurchaseOrders = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearchKeywords
            // 
            this.lblSearchKeywords.AutoSize = true;
            this.lblSearchKeywords.Location = new System.Drawing.Point(56, 42);
            this.lblSearchKeywords.Name = "lblSearchKeywords";
            this.lblSearchKeywords.Size = new System.Drawing.Size(109, 12);
            this.lblSearchKeywords.TabIndex = 0;
            this.lblSearchKeywords.Text = "Search by Warehouse ";
            // 
            // txtSearchKeywords
            // 
            this.txtSearchKeywords.Location = new System.Drawing.Point(58, 67);
            this.txtSearchKeywords.Name = "txtSearchKeywords";
            this.txtSearchKeywords.Size = new System.Drawing.Size(192, 22);
            this.txtSearchKeywords.TabIndex = 1;
            // 
            // lblSearchDate
            // 
            this.lblSearchDate.AutoSize = true;
            this.lblSearchDate.Location = new System.Drawing.Point(392, 42);
            this.lblSearchDate.Name = "lblSearchDate";
            this.lblSearchDate.Size = new System.Drawing.Size(114, 12);
            this.lblSearchDate.TabIndex = 2;
            this.lblSearchDate.Text = "Search by Date Created";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(394, 66);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 3;
            // 
            // dgvPurchaseOrders
            // 
            this.dgvPurchaseOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseOrders.Location = new System.Drawing.Point(58, 128);
            this.dgvPurchaseOrders.Name = "dgvPurchaseOrders";
            this.dgvPurchaseOrders.RowTemplate.Height = 24;
            this.dgvPurchaseOrders.Size = new System.Drawing.Size(536, 245);
            this.dgvPurchaseOrders.TabIndex = 4;
            // 
            // PurchaseOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPurchaseOrders);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.lblSearchDate);
            this.Controls.Add(this.txtSearchKeywords);
            this.Controls.Add(this.lblSearchKeywords);
            this.Name = "PurchaseOrdersForm";
            this.Text = "PurchaseOrdersForm";
            this.Load += new System.EventHandler(this.PurchaseOrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchKeywords;
        private System.Windows.Forms.TextBox txtSearchKeywords;
        private System.Windows.Forms.Label lblSearchDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DataGridView dgvPurchaseOrders;
    }
}
namespace Better_Limited_Project.ServiceUtility.Delivery
{
    partial class DeliveryRequestForm
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
            this.vScrollBar = new System.Windows.Forms.VScrollBar();
            this.hScrollBar = new System.Windows.Forms.HScrollBar();
            this.dgvDeliveryRequest = new System.Windows.Forms.DataGridView();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblSearchDate = new System.Windows.Forms.Label();
            this.txtSearchKeywords = new System.Windows.Forms.TextBox();
            this.lblSearchKeywords = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveryRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // vScrollBar
            // 
            this.vScrollBar.Location = new System.Drawing.Point(651, 146);
            this.vScrollBar.Name = "vScrollBar";
            this.vScrollBar.Size = new System.Drawing.Size(18, 245);
            this.vScrollBar.TabIndex = 68;
            // 
            // hScrollBar
            // 
            this.hScrollBar.Location = new System.Drawing.Point(133, 372);
            this.hScrollBar.Name = "hScrollBar";
            this.hScrollBar.Size = new System.Drawing.Size(518, 18);
            this.hScrollBar.TabIndex = 67;
            // 
            // dgvDeliveryRequest
            // 
            this.dgvDeliveryRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeliveryRequest.Location = new System.Drawing.Point(133, 146);
            this.dgvDeliveryRequest.Name = "dgvDeliveryRequest";
            this.dgvDeliveryRequest.RowTemplate.Height = 24;
            this.dgvDeliveryRequest.Size = new System.Drawing.Size(536, 245);
            this.dgvDeliveryRequest.TabIndex = 66;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(469, 84);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 65;
            // 
            // lblSearchDate
            // 
            this.lblSearchDate.AutoSize = true;
            this.lblSearchDate.Location = new System.Drawing.Point(467, 60);
            this.lblSearchDate.Name = "lblSearchDate";
            this.lblSearchDate.Size = new System.Drawing.Size(114, 12);
            this.lblSearchDate.TabIndex = 64;
            this.lblSearchDate.Text = "Search by Date Created";
            // 
            // txtSearchKeywords
            // 
            this.txtSearchKeywords.Location = new System.Drawing.Point(133, 85);
            this.txtSearchKeywords.Name = "txtSearchKeywords";
            this.txtSearchKeywords.Size = new System.Drawing.Size(192, 22);
            this.txtSearchKeywords.TabIndex = 63;
            // 
            // lblSearchKeywords
            // 
            this.lblSearchKeywords.AutoSize = true;
            this.lblSearchKeywords.Location = new System.Drawing.Point(133, 62);
            this.lblSearchKeywords.Name = "lblSearchKeywords";
            this.lblSearchKeywords.Size = new System.Drawing.Size(208, 12);
            this.lblSearchKeywords.TabIndex = 62;
            this.lblSearchKeywords.Text = "Search by Customer Name / Phone Number";
            // 
            // DeliveryRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vScrollBar);
            this.Controls.Add(this.hScrollBar);
            this.Controls.Add(this.dgvDeliveryRequest);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.lblSearchDate);
            this.Controls.Add(this.txtSearchKeywords);
            this.Controls.Add(this.lblSearchKeywords);
            this.Name = "DeliveryRequestForm";
            this.Text = "DeliveryRequestForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveryRequest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.VScrollBar vScrollBar;
        private System.Windows.Forms.HScrollBar hScrollBar;
        private System.Windows.Forms.DataGridView dgvDeliveryRequest;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lblSearchDate;
        private System.Windows.Forms.TextBox txtSearchKeywords;
        private System.Windows.Forms.Label lblSearchKeywords;
    }
}
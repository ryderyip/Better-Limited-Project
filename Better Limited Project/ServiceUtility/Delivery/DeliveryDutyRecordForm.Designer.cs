namespace Better_Limited_Project.ServiceUtility.Delivery
{
    partial class DeliveryDutyRecordForm
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
            this.btnCreateRestockRecord = new System.Windows.Forms.Button();
            this.vScrollBar = new System.Windows.Forms.VScrollBar();
            this.hScrollBar = new System.Windows.Forms.HScrollBar();
            this.dgvInstallationDutyRecord = new System.Windows.Forms.DataGridView();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblSearchDate = new System.Windows.Forms.Label();
            this.txtSearchKeywords = new System.Windows.Forms.TextBox();
            this.lblSearchKeywords = new System.Windows.Forms.Label();
            this.btnCreateDelivery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstallationDutyRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateRestockRecord
            // 
            this.btnCreateRestockRecord.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCreateRestockRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRestockRecord.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCreateRestockRecord.Location = new System.Drawing.Point(629, 58);
            this.btnCreateRestockRecord.Name = "btnCreateRestockRecord";
            this.btnCreateRestockRecord.Size = new System.Drawing.Size(168, 55);
            this.btnCreateRestockRecord.TabIndex = 62;
            this.btnCreateRestockRecord.Text = "Create Restock Record";
            this.btnCreateRestockRecord.UseVisualStyleBackColor = false;
            this.btnCreateRestockRecord.Visible = false;
            // 
            // vScrollBar
            // 
            this.vScrollBar.Location = new System.Drawing.Point(580, 125);
            this.vScrollBar.Name = "vScrollBar";
            this.vScrollBar.Size = new System.Drawing.Size(18, 245);
            this.vScrollBar.TabIndex = 61;
            // 
            // hScrollBar
            // 
            this.hScrollBar.Location = new System.Drawing.Point(62, 351);
            this.hScrollBar.Name = "hScrollBar";
            this.hScrollBar.Size = new System.Drawing.Size(518, 18);
            this.hScrollBar.TabIndex = 60;
            // 
            // dgvInstallationDutyRecord
            // 
            this.dgvInstallationDutyRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstallationDutyRecord.Location = new System.Drawing.Point(62, 125);
            this.dgvInstallationDutyRecord.Name = "dgvInstallationDutyRecord";
            this.dgvInstallationDutyRecord.RowTemplate.Height = 24;
            this.dgvInstallationDutyRecord.Size = new System.Drawing.Size(536, 245);
            this.dgvInstallationDutyRecord.TabIndex = 59;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(398, 63);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 58;
            // 
            // lblSearchDate
            // 
            this.lblSearchDate.AutoSize = true;
            this.lblSearchDate.Location = new System.Drawing.Point(396, 39);
            this.lblSearchDate.Name = "lblSearchDate";
            this.lblSearchDate.Size = new System.Drawing.Size(114, 12);
            this.lblSearchDate.TabIndex = 57;
            this.lblSearchDate.Text = "Search by Date Created";
            // 
            // txtSearchKeywords
            // 
            this.txtSearchKeywords.Location = new System.Drawing.Point(62, 64);
            this.txtSearchKeywords.Name = "txtSearchKeywords";
            this.txtSearchKeywords.Size = new System.Drawing.Size(192, 22);
            this.txtSearchKeywords.TabIndex = 56;
            // 
            // lblSearchKeywords
            // 
            this.lblSearchKeywords.AutoSize = true;
            this.lblSearchKeywords.Location = new System.Drawing.Point(60, 39);
            this.lblSearchKeywords.Name = "lblSearchKeywords";
            this.lblSearchKeywords.Size = new System.Drawing.Size(106, 12);
            this.lblSearchKeywords.TabIndex = 55;
            this.lblSearchKeywords.Text = "Search by Staff Name";
            // 
            // btnCreateDelivery
            // 
            this.btnCreateDelivery.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCreateDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateDelivery.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCreateDelivery.Location = new System.Drawing.Point(629, 140);
            this.btnCreateDelivery.Name = "btnCreateDelivery";
            this.btnCreateDelivery.Size = new System.Drawing.Size(168, 54);
            this.btnCreateDelivery.TabIndex = 63;
            this.btnCreateDelivery.Text = "Create Delivery Record";
            this.btnCreateDelivery.UseVisualStyleBackColor = false;
            this.btnCreateDelivery.Visible = false;
            // 
            // DeliveryDutyRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreateDelivery);
            this.Controls.Add(this.btnCreateRestockRecord);
            this.Controls.Add(this.vScrollBar);
            this.Controls.Add(this.hScrollBar);
            this.Controls.Add(this.dgvInstallationDutyRecord);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.lblSearchDate);
            this.Controls.Add(this.txtSearchKeywords);
            this.Controls.Add(this.lblSearchKeywords);
            this.Name = "DeliveryDutyRecordForm";
            this.Text = "DeliveryDutyRecordForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstallationDutyRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateRestockRecord;
        private System.Windows.Forms.VScrollBar vScrollBar;
        private System.Windows.Forms.HScrollBar hScrollBar;
        private System.Windows.Forms.DataGridView dgvInstallationDutyRecord;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lblSearchDate;
        private System.Windows.Forms.TextBox txtSearchKeywords;
        private System.Windows.Forms.Label lblSearchKeywords;
        private System.Windows.Forms.Button btnCreateDelivery;
    }
}
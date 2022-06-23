
namespace Better_Limited_Project.ProductUtility.Restocking.UI
{
    partial class RestockDeliveryDetailsForm
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
            this.tbScheduledDateTime = new System.Windows.Forms.TextBox();
            this.lblScheduledDate = new System.Windows.Forms.Label();
            this.dgvGoodsToDeliver = new System.Windows.Forms.DataGridView();
            this.restcokRequestIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dasfdafs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblGoodsToDeliver = new System.Windows.Forms.Label();
            this.lblCouriers = new System.Windows.Forms.Label();
            this.dgvCouriers = new System.Windows.Forms.DataGridView();
            this.courierNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courierPhoneNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeliveryNote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsToDeliver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCouriers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(211, 31);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(270, 25);
            this.lblHeader.TabIndex = 236;
            this.lblHeader.Text = "Restock Delivery Details";
            // 
            // tbScheduledDateTime
            // 
            this.tbScheduledDateTime.Location = new System.Drawing.Point(28, 151);
            this.tbScheduledDateTime.Name = "tbScheduledDateTime";
            this.tbScheduledDateTime.ReadOnly = true;
            this.tbScheduledDateTime.Size = new System.Drawing.Size(241, 20);
            this.tbScheduledDateTime.TabIndex = 238;
            // 
            // lblScheduledDate
            // 
            this.lblScheduledDate.AutoSize = true;
            this.lblScheduledDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScheduledDate.Location = new System.Drawing.Point(25, 122);
            this.lblScheduledDate.Name = "lblScheduledDate";
            this.lblScheduledDate.Size = new System.Drawing.Size(105, 16);
            this.lblScheduledDate.TabIndex = 237;
            this.lblScheduledDate.Text = "Scheduled Date";
            // 
            // dgvGoodsToDeliver
            // 
            this.dgvGoodsToDeliver.AllowUserToAddRows = false;
            this.dgvGoodsToDeliver.AllowUserToDeleteRows = false;
            this.dgvGoodsToDeliver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoodsToDeliver.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.restcokRequestIdColumn,
            this.Column1,
            this.dasfdafs,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column2});
            this.dgvGoodsToDeliver.Location = new System.Drawing.Point(28, 284);
            this.dgvGoodsToDeliver.Name = "dgvGoodsToDeliver";
            this.dgvGoodsToDeliver.ReadOnly = true;
            this.dgvGoodsToDeliver.RowTemplate.Height = 24;
            this.dgvGoodsToDeliver.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGoodsToDeliver.Size = new System.Drawing.Size(633, 197);
            this.dgvGoodsToDeliver.TabIndex = 240;
            // 
            // restcokRequestIdColumn
            // 
            this.restcokRequestIdColumn.HeaderText = "restock request id";
            this.restcokRequestIdColumn.Name = "restcokRequestIdColumn";
            this.restcokRequestIdColumn.ReadOnly = true;
            this.restcokRequestIdColumn.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Restock Request No.";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // dasfdafs
            // 
            this.dasfdafs.HeaderText = "Retail Store";
            this.dasfdafs.Name = "dasfdafs";
            this.dasfdafs.ReadOnly = true;
            this.dasfdafs.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Product";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 170;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Delivered";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 70;
            // 
            // lblGoodsToDeliver
            // 
            this.lblGoodsToDeliver.AutoSize = true;
            this.lblGoodsToDeliver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoodsToDeliver.Location = new System.Drawing.Point(275, 252);
            this.lblGoodsToDeliver.Name = "lblGoodsToDeliver";
            this.lblGoodsToDeliver.Size = new System.Drawing.Size(143, 20);
            this.lblGoodsToDeliver.TabIndex = 239;
            this.lblGoodsToDeliver.Text = "Goods to Deliver";
            // 
            // lblCouriers
            // 
            this.lblCouriers.AutoSize = true;
            this.lblCouriers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCouriers.Location = new System.Drawing.Point(471, 90);
            this.lblCouriers.Name = "lblCouriers";
            this.lblCouriers.Size = new System.Drawing.Size(76, 20);
            this.lblCouriers.TabIndex = 244;
            this.lblCouriers.Text = "Couriers";
            // 
            // dgvCouriers
            // 
            this.dgvCouriers.AllowUserToAddRows = false;
            this.dgvCouriers.AllowUserToDeleteRows = false;
            this.dgvCouriers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCouriers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courierNameColumn,
            this.courierPhoneNumberColumn});
            this.dgvCouriers.Location = new System.Drawing.Point(367, 122);
            this.dgvCouriers.Name = "dgvCouriers";
            this.dgvCouriers.ReadOnly = true;
            this.dgvCouriers.RowTemplate.Height = 24;
            this.dgvCouriers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCouriers.Size = new System.Drawing.Size(294, 100);
            this.dgvCouriers.TabIndex = 243;
            // 
            // courierNameColumn
            // 
            this.courierNameColumn.HeaderText = "Courier";
            this.courierNameColumn.Name = "courierNameColumn";
            this.courierNameColumn.ReadOnly = true;
            this.courierNameColumn.Width = 150;
            // 
            // courierPhoneNumberColumn
            // 
            this.courierPhoneNumberColumn.HeaderText = "Phone No.";
            this.courierPhoneNumberColumn.Name = "courierPhoneNumberColumn";
            this.courierPhoneNumberColumn.ReadOnly = true;
            // 
            // btnDeliveryNote
            // 
            this.btnDeliveryNote.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDeliveryNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeliveryNote.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDeliveryNote.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeliveryNote.Location = new System.Drawing.Point(28, 499);
            this.btnDeliveryNote.Name = "btnDeliveryNote";
            this.btnDeliveryNote.Size = new System.Drawing.Size(173, 47);
            this.btnDeliveryNote.TabIndex = 245;
            this.btnDeliveryNote.Text = "Delivery Note";
            this.btnDeliveryNote.UseVisualStyleBackColor = false;
            this.btnDeliveryNote.Click += new System.EventHandler(this.btnDeliveryNote_Click);
            // 
            // RestockDeliveryDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 569);
            this.Controls.Add(this.btnDeliveryNote);
            this.Controls.Add(this.lblCouriers);
            this.Controls.Add(this.dgvCouriers);
            this.Controls.Add(this.dgvGoodsToDeliver);
            this.Controls.Add(this.lblGoodsToDeliver);
            this.Controls.Add(this.tbScheduledDateTime);
            this.Controls.Add(this.lblScheduledDate);
            this.Controls.Add(this.lblHeader);
            this.Name = "RestockDeliveryDetailsForm";
            this.Text = "RestockDeliveryDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsToDeliver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCouriers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox tbScheduledDateTime;
        private System.Windows.Forms.Label lblScheduledDate;
        private System.Windows.Forms.DataGridView dgvGoodsToDeliver;
        private System.Windows.Forms.Label lblGoodsToDeliver;
        private System.Windows.Forms.Label lblCouriers;
        private System.Windows.Forms.DataGridView dgvCouriers;
        private System.Windows.Forms.Button btnDeliveryNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn restcokRequestIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dasfdafs;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn courierNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courierPhoneNumberColumn;
    }
}
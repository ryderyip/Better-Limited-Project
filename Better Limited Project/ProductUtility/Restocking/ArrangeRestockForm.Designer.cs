
namespace Better_Limited_Project.ProductUtility.Restocking
{
    partial class ArrangeRestockForm
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
            this.btnChooseRequests = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblArrangeRestockDeliveryOn = new System.Windows.Forms.Label();
            this.dgvGoodsToDeliver = new System.Windows.Forms.DataGridView();
            this.lblGoodsToDeliver = new System.Windows.Forms.Label();
            this.dgvRestockRequests = new System.Windows.Forms.DataGridView();
            this.restockRequestIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retailStoreNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRestockRequests = new System.Windows.Forms.Label();
            this.dtpDeliverOn = new System.Windows.Forms.DateTimePicker();
            this.dtpDeliverAt = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnArrange = new System.Windows.Forms.Button();
            this.dgvCouriers = new System.Windows.Forms.DataGridView();
            this.courierIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courierNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courierPhoneNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChooseCouriers = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCouriers = new System.Windows.Forms.Label();
            this.dasfdafs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsToDeliver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestockRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCouriers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(332, 29);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(187, 25);
            this.lblHeader.TabIndex = 76;
            this.lblHeader.Text = "Arrange Restock";
            // 
            // btnChooseRequests
            // 
            this.btnChooseRequests.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnChooseRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnChooseRequests.ForeColor = System.Drawing.SystemColors.Window;
            this.btnChooseRequests.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnChooseRequests.Location = new System.Drawing.Point(236, 387);
            this.btnChooseRequests.Name = "btnChooseRequests";
            this.btnChooseRequests.Size = new System.Drawing.Size(136, 36);
            this.btnChooseRequests.TabIndex = 216;
            this.btnChooseRequests.Text = "Choose Requests";
            this.btnChooseRequests.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(225, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 15);
            this.label3.TabIndex = 214;
            this.label3.Text = "*";
            // 
            // lblArrangeRestockDeliveryOn
            // 
            this.lblArrangeRestockDeliveryOn.AutoSize = true;
            this.lblArrangeRestockDeliveryOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblArrangeRestockDeliveryOn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblArrangeRestockDeliveryOn.Location = new System.Drawing.Point(34, 111);
            this.lblArrangeRestockDeliveryOn.Name = "lblArrangeRestockDeliveryOn";
            this.lblArrangeRestockDeliveryOn.Size = new System.Drawing.Size(62, 15);
            this.lblArrangeRestockDeliveryOn.TabIndex = 217;
            this.lblArrangeRestockDeliveryOn.Text = "Deliver on";
            // 
            // dgvGoodsToDeliver
            // 
            this.dgvGoodsToDeliver.AllowUserToAddRows = false;
            this.dgvGoodsToDeliver.AllowUserToDeleteRows = false;
            this.dgvGoodsToDeliver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoodsToDeliver.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dasfdafs,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvGoodsToDeliver.Location = new System.Drawing.Point(406, 108);
            this.dgvGoodsToDeliver.Name = "dgvGoodsToDeliver";
            this.dgvGoodsToDeliver.ReadOnly = true;
            this.dgvGoodsToDeliver.RowTemplate.Height = 24;
            this.dgvGoodsToDeliver.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGoodsToDeliver.Size = new System.Drawing.Size(413, 416);
            this.dgvGoodsToDeliver.TabIndex = 225;
            // 
            // lblGoodsToDeliver
            // 
            this.lblGoodsToDeliver.AutoSize = true;
            this.lblGoodsToDeliver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoodsToDeliver.Location = new System.Drawing.Point(542, 72);
            this.lblGoodsToDeliver.Name = "lblGoodsToDeliver";
            this.lblGoodsToDeliver.Size = new System.Drawing.Size(143, 20);
            this.lblGoodsToDeliver.TabIndex = 224;
            this.lblGoodsToDeliver.Text = "Goods to Deliver";
            // 
            // dgvRestockRequests
            // 
            this.dgvRestockRequests.AllowUserToAddRows = false;
            this.dgvRestockRequests.AllowUserToDeleteRows = false;
            this.dgvRestockRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRestockRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.restockRequestIdColumn,
            this.requestNumberColumn,
            this.retailStoreNameColumn});
            this.dgvRestockRequests.Location = new System.Drawing.Point(28, 223);
            this.dgvRestockRequests.Name = "dgvRestockRequests";
            this.dgvRestockRequests.ReadOnly = true;
            this.dgvRestockRequests.RowTemplate.Height = 24;
            this.dgvRestockRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRestockRequests.Size = new System.Drawing.Size(344, 149);
            this.dgvRestockRequests.TabIndex = 226;
            // 
            // restockRequestIdColumn
            // 
            this.restockRequestIdColumn.HeaderText = "id";
            this.restockRequestIdColumn.Name = "restockRequestIdColumn";
            this.restockRequestIdColumn.ReadOnly = true;
            this.restockRequestIdColumn.Visible = false;
            // 
            // requestNumberColumn
            // 
            this.requestNumberColumn.HeaderText = "Restock Request No.";
            this.requestNumberColumn.Name = "requestNumberColumn";
            this.requestNumberColumn.ReadOnly = true;
            this.requestNumberColumn.Width = 150;
            // 
            // retailStoreNameColumn
            // 
            this.retailStoreNameColumn.HeaderText = "Retail Store";
            this.retailStoreNameColumn.Name = "retailStoreNameColumn";
            this.retailStoreNameColumn.ReadOnly = true;
            this.retailStoreNameColumn.Width = 150;
            // 
            // lblRestockRequests
            // 
            this.lblRestockRequests.AutoSize = true;
            this.lblRestockRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestockRequests.Location = new System.Drawing.Point(116, 187);
            this.lblRestockRequests.Name = "lblRestockRequests";
            this.lblRestockRequests.Size = new System.Drawing.Size(157, 20);
            this.lblRestockRequests.TabIndex = 227;
            this.lblRestockRequests.Text = "Restock Requests";
            // 
            // dtpDeliverOn
            // 
            this.dtpDeliverOn.Location = new System.Drawing.Point(37, 129);
            this.dtpDeliverOn.Name = "dtpDeliverOn";
            this.dtpDeliverOn.Size = new System.Drawing.Size(200, 20);
            this.dtpDeliverOn.TabIndex = 228;
            // 
            // dtpDeliverAt
            // 
            this.dtpDeliverAt.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDeliverAt.Location = new System.Drawing.Point(254, 129);
            this.dtpDeliverAt.Name = "dtpDeliverAt";
            this.dtpDeliverAt.Size = new System.Drawing.Size(88, 20);
            this.dtpDeliverAt.TabIndex = 229;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(251, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 230;
            this.label1.Text = "Depart At";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 20);
            this.label2.TabIndex = 231;
            this.label2.Text = "Scheduled Delivery Date && Time";
            // 
            // btnArrange
            // 
            this.btnArrange.BackColor = System.Drawing.Color.DarkOrange;
            this.btnArrange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnArrange.ForeColor = System.Drawing.SystemColors.Window;
            this.btnArrange.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnArrange.Location = new System.Drawing.Point(533, 571);
            this.btnArrange.Name = "btnArrange";
            this.btnArrange.Size = new System.Drawing.Size(163, 52);
            this.btnArrange.TabIndex = 232;
            this.btnArrange.Text = "Arrange";
            this.btnArrange.UseVisualStyleBackColor = false;
            // 
            // dgvCouriers
            // 
            this.dgvCouriers.AllowUserToAddRows = false;
            this.dgvCouriers.AllowUserToDeleteRows = false;
            this.dgvCouriers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCouriers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courierIdColumn,
            this.courierNameColumn,
            this.courierPhoneNumberColumn});
            this.dgvCouriers.Location = new System.Drawing.Point(28, 472);
            this.dgvCouriers.Name = "dgvCouriers";
            this.dgvCouriers.ReadOnly = true;
            this.dgvCouriers.RowTemplate.Height = 24;
            this.dgvCouriers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCouriers.Size = new System.Drawing.Size(344, 100);
            this.dgvCouriers.TabIndex = 233;
            // 
            // courierIdColumn
            // 
            this.courierIdColumn.HeaderText = "id";
            this.courierIdColumn.Name = "courierIdColumn";
            this.courierIdColumn.ReadOnly = true;
            this.courierIdColumn.Visible = false;
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
            this.courierPhoneNumberColumn.Width = 150;
            // 
            // btnChooseCouriers
            // 
            this.btnChooseCouriers.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnChooseCouriers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnChooseCouriers.ForeColor = System.Drawing.SystemColors.Window;
            this.btnChooseCouriers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnChooseCouriers.Location = new System.Drawing.Point(236, 587);
            this.btnChooseCouriers.Name = "btnChooseCouriers";
            this.btnChooseCouriers.Size = new System.Drawing.Size(136, 36);
            this.btnChooseCouriers.TabIndex = 235;
            this.btnChooseCouriers.Text = "Choose Couriers";
            this.btnChooseCouriers.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(225, 587);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 15);
            this.label4.TabIndex = 234;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(25, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 15);
            this.label5.TabIndex = 236;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(242, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 15);
            this.label6.TabIndex = 237;
            this.label6.Text = "*";
            // 
            // lblCouriers
            // 
            this.lblCouriers.AutoSize = true;
            this.lblCouriers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCouriers.Location = new System.Drawing.Point(130, 442);
            this.lblCouriers.Name = "lblCouriers";
            this.lblCouriers.Size = new System.Drawing.Size(132, 20);
            this.lblCouriers.TabIndex = 238;
            this.lblCouriers.Text = "Select Couriers";
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
            // ArrangeRestockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 653);
            this.Controls.Add(this.lblCouriers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnChooseCouriers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvCouriers);
            this.Controls.Add(this.btnArrange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDeliverAt);
            this.Controls.Add(this.dtpDeliverOn);
            this.Controls.Add(this.lblRestockRequests);
            this.Controls.Add(this.dgvRestockRequests);
            this.Controls.Add(this.dgvGoodsToDeliver);
            this.Controls.Add(this.lblGoodsToDeliver);
            this.Controls.Add(this.lblArrangeRestockDeliveryOn);
            this.Controls.Add(this.btnChooseRequests);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblHeader);
            this.Name = "ArrangeRestockForm";
            this.Text = "ArrangeRestockForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsToDeliver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestockRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCouriers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnChooseRequests;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblArrangeRestockDeliveryOn;
        private System.Windows.Forms.DataGridView dgvGoodsToDeliver;
        private System.Windows.Forms.Label lblGoodsToDeliver;
        private System.Windows.Forms.DataGridView dgvRestockRequests;
        private System.Windows.Forms.Label lblRestockRequests;
        private System.Windows.Forms.DateTimePicker dtpDeliverOn;
        private System.Windows.Forms.DateTimePicker dtpDeliverAt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnArrange;
        private System.Windows.Forms.DataGridViewTextBoxColumn restockRequestIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn retailStoreNameColumn;
        private System.Windows.Forms.DataGridView dgvCouriers;
        private System.Windows.Forms.DataGridViewTextBoxColumn courierIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courierNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courierPhoneNumberColumn;
        private System.Windows.Forms.Button btnChooseCouriers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCouriers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dasfdafs;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
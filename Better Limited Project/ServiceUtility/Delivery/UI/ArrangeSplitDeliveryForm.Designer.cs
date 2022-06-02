namespace Better_Limited_Project.ServiceUtility.Delivery.UI
{
    partial class ArrangeSplitDeliveryForm
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
            this.btnNewDelivery = new System.Windows.Forms.Button();
            this.btnArrangeALLDeliveries = new System.Windows.Forms.Button();
            this.dgvProductsDelivered = new System.Windows.Forms.DataGridView();
            this.lblProductsDelivered = new System.Windows.Forms.Label();
            this.txtEarliest = new System.Windows.Forms.TextBox();
            this.lblEarliest = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblSelectDate = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblSelectCourier = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAmtToAdd = new System.Windows.Forms.TextBox();
            this.lblAmtToAdd = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblProductsInDelivery = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.dgvProductsInDelivery = new System.Windows.Forms.DataGridView();
            this.btnSingleDelivery = new System.Windows.Forms.Button();
            this.lblDeliveriesAdded = new System.Windows.Forms.Label();
            this.dgvDeliveriesAdded = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsDelivered)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsInDelivery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveriesAdded)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewDelivery
            // 
            this.btnNewDelivery.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNewDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewDelivery.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNewDelivery.Location = new System.Drawing.Point(287, 415);
            this.btnNewDelivery.Name = "btnNewDelivery";
            this.btnNewDelivery.Size = new System.Drawing.Size(123, 30);
            this.btnNewDelivery.TabIndex = 128;
            this.btnNewDelivery.Text = "New Delivery";
            this.btnNewDelivery.UseVisualStyleBackColor = false;
            // 
            // btnArrangeALLDeliveries
            // 
            this.btnArrangeALLDeliveries.BackColor = System.Drawing.Color.DarkOrange;
            this.btnArrangeALLDeliveries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArrangeALLDeliveries.ForeColor = System.Drawing.SystemColors.Window;
            this.btnArrangeALLDeliveries.Location = new System.Drawing.Point(566, 274);
            this.btnArrangeALLDeliveries.Name = "btnArrangeALLDeliveries";
            this.btnArrangeALLDeliveries.Size = new System.Drawing.Size(222, 38);
            this.btnArrangeALLDeliveries.TabIndex = 127;
            this.btnArrangeALLDeliveries.Text = "Arrange ALL Deliveries";
            this.btnArrangeALLDeliveries.UseVisualStyleBackColor = false;
            // 
            // dgvProductsDelivered
            // 
            this.dgvProductsDelivered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsDelivered.Location = new System.Drawing.Point(287, 67);
            this.dgvProductsDelivered.Name = "dgvProductsDelivered";
            this.dgvProductsDelivered.RowTemplate.Height = 24;
            this.dgvProductsDelivered.Size = new System.Drawing.Size(264, 96);
            this.dgvProductsDelivered.TabIndex = 125;
            // 
            // lblProductsDelivered
            // 
            this.lblProductsDelivered.AutoSize = true;
            this.lblProductsDelivered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductsDelivered.Location = new System.Drawing.Point(283, 28);
            this.lblProductsDelivered.Name = "lblProductsDelivered";
            this.lblProductsDelivered.Size = new System.Drawing.Size(212, 20);
            this.lblProductsDelivered.TabIndex = 124;
            this.lblProductsDelivered.Text = "Products To Be Delivered";
            // 
            // txtEarliest
            // 
            this.txtEarliest.Location = new System.Drawing.Point(80, 421);
            this.txtEarliest.Name = "txtEarliest";
            this.txtEarliest.Size = new System.Drawing.Size(128, 20);
            this.txtEarliest.TabIndex = 123;
            // 
            // lblEarliest
            // 
            this.lblEarliest.AutoSize = true;
            this.lblEarliest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEarliest.Location = new System.Drawing.Point(1, 355);
            this.lblEarliest.Name = "lblEarliest";
            this.lblEarliest.Size = new System.Drawing.Size(259, 40);
            this.lblEarliest.TabIndex = 122;
            this.lblEarliest.Text = "Earliest Delivery Date Possible \r\n      For Selected Session:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(36, 304);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 121;
            // 
            // lblSelectDate
            // 
            this.lblSelectDate.AutoSize = true;
            this.lblSelectDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDate.Location = new System.Drawing.Point(33, 264);
            this.lblSelectDate.Name = "lblSelectDate";
            this.lblSelectDate.Size = new System.Drawing.Size(152, 20);
            this.lblSelectDate.TabIndex = 120;
            this.lblSelectDate.Text = "Select Delivery Date";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(37, 217);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 21);
            this.comboBox1.TabIndex = 119;
            this.comboBox1.Text = "Selected Courier";
            // 
            // lblSelectCourier
            // 
            this.lblSelectCourier.AutoSize = true;
            this.lblSelectCourier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCourier.Location = new System.Drawing.Point(33, 180);
            this.lblSelectCourier.Name = "lblSelectCourier";
            this.lblSelectCourier.Size = new System.Drawing.Size(109, 20);
            this.lblSelectCourier.TabIndex = 118;
            this.lblSelectCourier.Text = "Select Courier";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAdd.Location = new System.Drawing.Point(585, 137);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(73, 37);
            this.btnAdd.TabIndex = 131;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtAmtToAdd
            // 
            this.txtAmtToAdd.Location = new System.Drawing.Point(585, 93);
            this.txtAmtToAdd.Name = "txtAmtToAdd";
            this.txtAmtToAdd.Size = new System.Drawing.Size(141, 20);
            this.txtAmtToAdd.TabIndex = 130;
            // 
            // lblAmtToAdd
            // 
            this.lblAmtToAdd.AutoSize = true;
            this.lblAmtToAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmtToAdd.Location = new System.Drawing.Point(582, 64);
            this.lblAmtToAdd.Name = "lblAmtToAdd";
            this.lblAmtToAdd.Size = new System.Drawing.Size(153, 15);
            this.lblAmtToAdd.TabIndex = 129;
            this.lblAmtToAdd.Text = "Amount To Add To Delivery";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRemove.Location = new System.Drawing.Point(682, 137);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(85, 37);
            this.btnRemove.TabIndex = 132;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // lblProductsInDelivery
            // 
            this.lblProductsInDelivery.AutoSize = true;
            this.lblProductsInDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductsInDelivery.Location = new System.Drawing.Point(283, 191);
            this.lblProductsInDelivery.Name = "lblProductsInDelivery";
            this.lblProductsInDelivery.Size = new System.Drawing.Size(149, 20);
            this.lblProductsInDelivery.TabIndex = 133;
            this.lblProductsInDelivery.Text = "Products In Delivery";
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(438, 194);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(62, 20);
            this.txtProduct.TabIndex = 134;
            // 
            // dgvProductsInDelivery
            // 
            this.dgvProductsInDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsInDelivery.Location = new System.Drawing.Point(287, 237);
            this.dgvProductsInDelivery.Name = "dgvProductsInDelivery";
            this.dgvProductsInDelivery.RowTemplate.Height = 24;
            this.dgvProductsInDelivery.Size = new System.Drawing.Size(264, 49);
            this.dgvProductsInDelivery.TabIndex = 135;
            // 
            // btnSingleDelivery
            // 
            this.btnSingleDelivery.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSingleDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingleDelivery.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSingleDelivery.Location = new System.Drawing.Point(634, 421);
            this.btnSingleDelivery.Name = "btnSingleDelivery";
            this.btnSingleDelivery.Size = new System.Drawing.Size(145, 45);
            this.btnSingleDelivery.TabIndex = 136;
            this.btnSingleDelivery.Text = "Single Delivery";
            this.btnSingleDelivery.UseVisualStyleBackColor = false;
            this.btnSingleDelivery.Click += new System.EventHandler(this.btnSingleDelivery_Click);
            // 
            // lblDeliveriesAdded
            // 
            this.lblDeliveriesAdded.AutoSize = true;
            this.lblDeliveriesAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveriesAdded.Location = new System.Drawing.Point(302, 319);
            this.lblDeliveriesAdded.Name = "lblDeliveriesAdded";
            this.lblDeliveriesAdded.Size = new System.Drawing.Size(128, 20);
            this.lblDeliveriesAdded.TabIndex = 137;
            this.lblDeliveriesAdded.Text = "Deliveries Added";
            // 
            // dgvDeliveriesAdded
            // 
            this.dgvDeliveriesAdded.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeliveriesAdded.Location = new System.Drawing.Point(287, 355);
            this.dgvDeliveriesAdded.Name = "dgvDeliveriesAdded";
            this.dgvDeliveriesAdded.RowTemplate.Height = 24;
            this.dgvDeliveriesAdded.Size = new System.Drawing.Size(264, 49);
            this.dgvDeliveriesAdded.TabIndex = 138;
            // 
            // ArrangeSplitDeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.dgvDeliveriesAdded);
            this.Controls.Add(this.lblDeliveriesAdded);
            this.Controls.Add(this.btnSingleDelivery);
            this.Controls.Add(this.dgvProductsInDelivery);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.lblProductsInDelivery);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAmtToAdd);
            this.Controls.Add(this.lblAmtToAdd);
            this.Controls.Add(this.btnNewDelivery);
            this.Controls.Add(this.btnArrangeALLDeliveries);
            this.Controls.Add(this.dgvProductsDelivered);
            this.Controls.Add(this.lblProductsDelivered);
            this.Controls.Add(this.txtEarliest);
            this.Controls.Add(this.lblEarliest);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblSelectDate);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblSelectCourier);
            this.Name = "ArrangeSplitDeliveryForm";
            this.Text = "ArrangeSplitDeliveryForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsDelivered)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsInDelivery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveriesAdded)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewDelivery;
        private System.Windows.Forms.Button btnArrangeALLDeliveries;
        private System.Windows.Forms.DataGridView dgvProductsDelivered;
        private System.Windows.Forms.Label lblProductsDelivered;
        private System.Windows.Forms.TextBox txtEarliest;
        private System.Windows.Forms.Label lblEarliest;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblSelectDate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblSelectCourier;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAmtToAdd;
        private System.Windows.Forms.Label lblAmtToAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblProductsInDelivery;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.DataGridView dgvProductsInDelivery;
        private System.Windows.Forms.Button btnSingleDelivery;
        private System.Windows.Forms.Label lblDeliveriesAdded;
        private System.Windows.Forms.DataGridView dgvDeliveriesAdded;
    }
}
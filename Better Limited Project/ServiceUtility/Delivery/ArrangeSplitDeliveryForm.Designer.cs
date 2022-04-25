namespace Better_Limited_Project.ServieUtility.Delivery
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
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvProductsDelivered = new System.Windows.Forms.DataGridView();
            this.lblProductsDelivered = new System.Windows.Forms.Label();
            this.txtEarliest = new System.Windows.Forms.TextBox();
            this.lblEarliest = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblSelectDate = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblSelectCourier = new System.Windows.Forms.Label();
            this.radioButtonAfternoon = new System.Windows.Forms.RadioButton();
            this.radioButtonEvening = new System.Windows.Forms.RadioButton();
            this.radioButtonMorning = new System.Windows.Forms.RadioButton();
            this.lblAfternoon = new System.Windows.Forms.Label();
            this.lblEvening = new System.Windows.Forms.Label();
            this.lblMorning = new System.Windows.Forms.Label();
            this.lblSelectSession = new System.Windows.Forms.Label();
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
            this.btnNewDelivery.Location = new System.Drawing.Point(287, 383);
            this.btnNewDelivery.Name = "btnNewDelivery";
            this.btnNewDelivery.Size = new System.Drawing.Size(123, 28);
            this.btnNewDelivery.TabIndex = 128;
            this.btnNewDelivery.Text = "New Delivery";
            this.btnNewDelivery.UseVisualStyleBackColor = false;
            // 
            // btnArrangeALLDeliveries
            // 
            this.btnArrangeALLDeliveries.BackColor = System.Drawing.Color.DarkOrange;
            this.btnArrangeALLDeliveries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArrangeALLDeliveries.ForeColor = System.Drawing.SystemColors.Window;
            this.btnArrangeALLDeliveries.Location = new System.Drawing.Point(566, 253);
            this.btnArrangeALLDeliveries.Name = "btnArrangeALLDeliveries";
            this.btnArrangeALLDeliveries.Size = new System.Drawing.Size(222, 35);
            this.btnArrangeALLDeliveries.TabIndex = 127;
            this.btnArrangeALLDeliveries.Text = "Arrange ALL Deliveries";
            this.btnArrangeALLDeliveries.UseVisualStyleBackColor = false;
            this.btnArrangeALLDeliveries.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBack.Location = new System.Drawing.Point(682, 333);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 33);
            this.btnBack.TabIndex = 126;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // dgvProductsDelivered
            // 
            this.dgvProductsDelivered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsDelivered.Location = new System.Drawing.Point(287, 62);
            this.dgvProductsDelivered.Name = "dgvProductsDelivered";
            this.dgvProductsDelivered.RowTemplate.Height = 24;
            this.dgvProductsDelivered.Size = new System.Drawing.Size(264, 89);
            this.dgvProductsDelivered.TabIndex = 125;
            // 
            // lblProductsDelivered
            // 
            this.lblProductsDelivered.AutoSize = true;
            this.lblProductsDelivered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductsDelivered.Location = new System.Drawing.Point(283, 26);
            this.lblProductsDelivered.Name = "lblProductsDelivered";
            this.lblProductsDelivered.Size = new System.Drawing.Size(212, 20);
            this.lblProductsDelivered.TabIndex = 124;
            this.lblProductsDelivered.Text = "Products To Be Delivered";
            // 
            // txtEarliest
            // 
            this.txtEarliest.Location = new System.Drawing.Point(80, 389);
            this.txtEarliest.Name = "txtEarliest";
            this.txtEarliest.Size = new System.Drawing.Size(128, 22);
            this.txtEarliest.TabIndex = 123;
            // 
            // lblEarliest
            // 
            this.lblEarliest.AutoSize = true;
            this.lblEarliest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEarliest.Location = new System.Drawing.Point(1, 328);
            this.lblEarliest.Name = "lblEarliest";
            this.lblEarliest.Size = new System.Drawing.Size(259, 40);
            this.lblEarliest.TabIndex = 122;
            this.lblEarliest.Text = "Earliest Delivery Date Possible \r\n      For Selected Session:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(36, 281);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 121;
            // 
            // lblSelectDate
            // 
            this.lblSelectDate.AutoSize = true;
            this.lblSelectDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDate.Location = new System.Drawing.Point(33, 244);
            this.lblSelectDate.Name = "lblSelectDate";
            this.lblSelectDate.Size = new System.Drawing.Size(152, 20);
            this.lblSelectDate.TabIndex = 120;
            this.lblSelectDate.Text = "Select Delivery Date";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(37, 200);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 20);
            this.comboBox1.TabIndex = 119;
            this.comboBox1.Text = "Selected Courier";
            // 
            // lblSelectCourier
            // 
            this.lblSelectCourier.AutoSize = true;
            this.lblSelectCourier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCourier.Location = new System.Drawing.Point(33, 166);
            this.lblSelectCourier.Name = "lblSelectCourier";
            this.lblSelectCourier.Size = new System.Drawing.Size(109, 20);
            this.lblSelectCourier.TabIndex = 118;
            this.lblSelectCourier.Text = "Select Courier";
            // 
            // radioButtonAfternoon
            // 
            this.radioButtonAfternoon.AutoSize = true;
            this.radioButtonAfternoon.Location = new System.Drawing.Point(37, 95);
            this.radioButtonAfternoon.Name = "radioButtonAfternoon";
            this.radioButtonAfternoon.Size = new System.Drawing.Size(14, 13);
            this.radioButtonAfternoon.TabIndex = 117;
            this.radioButtonAfternoon.TabStop = true;
            this.radioButtonAfternoon.UseVisualStyleBackColor = true;
            // 
            // radioButtonEvening
            // 
            this.radioButtonEvening.AutoSize = true;
            this.radioButtonEvening.Location = new System.Drawing.Point(37, 128);
            this.radioButtonEvening.Name = "radioButtonEvening";
            this.radioButtonEvening.Size = new System.Drawing.Size(14, 13);
            this.radioButtonEvening.TabIndex = 116;
            this.radioButtonEvening.TabStop = true;
            this.radioButtonEvening.UseVisualStyleBackColor = true;
            // 
            // radioButtonMorning
            // 
            this.radioButtonMorning.AutoSize = true;
            this.radioButtonMorning.Location = new System.Drawing.Point(37, 62);
            this.radioButtonMorning.Name = "radioButtonMorning";
            this.radioButtonMorning.Size = new System.Drawing.Size(14, 13);
            this.radioButtonMorning.TabIndex = 115;
            this.radioButtonMorning.TabStop = true;
            this.radioButtonMorning.UseVisualStyleBackColor = true;
            // 
            // lblAfternoon
            // 
            this.lblAfternoon.AutoSize = true;
            this.lblAfternoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfternoon.Location = new System.Drawing.Point(57, 92);
            this.lblAfternoon.Name = "lblAfternoon";
            this.lblAfternoon.Size = new System.Drawing.Size(173, 16);
            this.lblAfternoon.TabIndex = 114;
            this.lblAfternoon.Text = "Afternoon (1:00PM - 5:00PM)";
            // 
            // lblEvening
            // 
            this.lblEvening.AutoSize = true;
            this.lblEvening.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvening.Location = new System.Drawing.Point(56, 125);
            this.lblEvening.Name = "lblEvening";
            this.lblEvening.Size = new System.Drawing.Size(172, 16);
            this.lblEvening.TabIndex = 113;
            this.lblEvening.Text = "Evening (6:00PM - 10:00PM)";
            // 
            // lblMorning
            // 
            this.lblMorning.AutoSize = true;
            this.lblMorning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMorning.Location = new System.Drawing.Point(57, 62);
            this.lblMorning.Name = "lblMorning";
            this.lblMorning.Size = new System.Drawing.Size(171, 16);
            this.lblMorning.TabIndex = 112;
            this.lblMorning.Text = "Morning (9:00AM - 12:00PM)";
            // 
            // lblSelectSession
            // 
            this.lblSelectSession.AutoSize = true;
            this.lblSelectSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectSession.Location = new System.Drawing.Point(34, 26);
            this.lblSelectSession.Name = "lblSelectSession";
            this.lblSelectSession.Size = new System.Drawing.Size(174, 20);
            this.lblSelectSession.TabIndex = 111;
            this.lblSelectSession.Text = "Select Delivery Session";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAdd.Location = new System.Drawing.Point(585, 126);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(73, 34);
            this.btnAdd.TabIndex = 131;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtAmtToAdd
            // 
            this.txtAmtToAdd.Location = new System.Drawing.Point(585, 86);
            this.txtAmtToAdd.Name = "txtAmtToAdd";
            this.txtAmtToAdd.Size = new System.Drawing.Size(141, 22);
            this.txtAmtToAdd.TabIndex = 130;
            // 
            // lblAmtToAdd
            // 
            this.lblAmtToAdd.AutoSize = true;
            this.lblAmtToAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmtToAdd.Location = new System.Drawing.Point(582, 59);
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
            this.btnRemove.Location = new System.Drawing.Point(682, 126);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(85, 34);
            this.btnRemove.TabIndex = 132;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // lblProductsInDelivery
            // 
            this.lblProductsInDelivery.AutoSize = true;
            this.lblProductsInDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductsInDelivery.Location = new System.Drawing.Point(283, 176);
            this.lblProductsInDelivery.Name = "lblProductsInDelivery";
            this.lblProductsInDelivery.Size = new System.Drawing.Size(149, 20);
            this.lblProductsInDelivery.TabIndex = 133;
            this.lblProductsInDelivery.Text = "Products In Delivery";
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(438, 179);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(62, 22);
            this.txtProduct.TabIndex = 134;
            // 
            // dgvProductsInDelivery
            // 
            this.dgvProductsInDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsInDelivery.Location = new System.Drawing.Point(287, 219);
            this.dgvProductsInDelivery.Name = "dgvProductsInDelivery";
            this.dgvProductsInDelivery.RowTemplate.Height = 24;
            this.dgvProductsInDelivery.Size = new System.Drawing.Size(264, 45);
            this.dgvProductsInDelivery.TabIndex = 135;
            // 
            // btnSingleDelivery
            // 
            this.btnSingleDelivery.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSingleDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingleDelivery.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSingleDelivery.Location = new System.Drawing.Point(643, 294);
            this.btnSingleDelivery.Name = "btnSingleDelivery";
            this.btnSingleDelivery.Size = new System.Drawing.Size(145, 33);
            this.btnSingleDelivery.TabIndex = 136;
            this.btnSingleDelivery.Text = "Single Delivery";
            this.btnSingleDelivery.UseVisualStyleBackColor = false;
            this.btnSingleDelivery.Visible = false;
            // 
            // lblDeliveriesAdded
            // 
            this.lblDeliveriesAdded.AutoSize = true;
            this.lblDeliveriesAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveriesAdded.Location = new System.Drawing.Point(302, 294);
            this.lblDeliveriesAdded.Name = "lblDeliveriesAdded";
            this.lblDeliveriesAdded.Size = new System.Drawing.Size(128, 20);
            this.lblDeliveriesAdded.TabIndex = 137;
            this.lblDeliveriesAdded.Text = "Deliveries Added";
            // 
            // dgvDeliveriesAdded
            // 
            this.dgvDeliveriesAdded.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeliveriesAdded.Location = new System.Drawing.Point(287, 328);
            this.dgvDeliveriesAdded.Name = "dgvDeliveriesAdded";
            this.dgvDeliveriesAdded.RowTemplate.Height = 24;
            this.dgvDeliveriesAdded.Size = new System.Drawing.Size(264, 45);
            this.dgvDeliveriesAdded.TabIndex = 138;
            // 
            // ArrangeSplitDeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvProductsDelivered);
            this.Controls.Add(this.lblProductsDelivered);
            this.Controls.Add(this.txtEarliest);
            this.Controls.Add(this.lblEarliest);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblSelectDate);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblSelectCourier);
            this.Controls.Add(this.radioButtonAfternoon);
            this.Controls.Add(this.radioButtonEvening);
            this.Controls.Add(this.radioButtonMorning);
            this.Controls.Add(this.lblAfternoon);
            this.Controls.Add(this.lblEvening);
            this.Controls.Add(this.lblMorning);
            this.Controls.Add(this.lblSelectSession);
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
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvProductsDelivered;
        private System.Windows.Forms.Label lblProductsDelivered;
        private System.Windows.Forms.TextBox txtEarliest;
        private System.Windows.Forms.Label lblEarliest;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblSelectDate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblSelectCourier;
        private System.Windows.Forms.RadioButton radioButtonAfternoon;
        private System.Windows.Forms.RadioButton radioButtonEvening;
        private System.Windows.Forms.RadioButton radioButtonMorning;
        private System.Windows.Forms.Label lblAfternoon;
        private System.Windows.Forms.Label lblEvening;
        private System.Windows.Forms.Label lblMorning;
        private System.Windows.Forms.Label lblSelectSession;
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
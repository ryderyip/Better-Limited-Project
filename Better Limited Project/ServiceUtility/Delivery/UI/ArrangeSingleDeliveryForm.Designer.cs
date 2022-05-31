namespace Better_Limited_Project.ServiceUtility.Delivery
{
    partial class ArrangeSingleDeliveryForm
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
            this.lblSelectSession = new System.Windows.Forms.Label();
            this.lblMorning = new System.Windows.Forms.Label();
            this.lblEvening = new System.Windows.Forms.Label();
            this.lblAfternoon = new System.Windows.Forms.Label();
            this.radioButtonMorning = new System.Windows.Forms.RadioButton();
            this.radioButtonEvening = new System.Windows.Forms.RadioButton();
            this.radioButtonAfternoon = new System.Windows.Forms.RadioButton();
            this.lblSelectCourier = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblSelectDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblEarliest = new System.Windows.Forms.Label();
            this.txtEarliest = new System.Windows.Forms.TextBox();
            this.lblProductsDelivered = new System.Windows.Forms.Label();
            this.dgvProductsDelivered = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnArrangeDelivery = new System.Windows.Forms.Button();
            this.btnSplitDelivery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsDelivered)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectSession
            // 
            this.lblSelectSession.AutoSize = true;
            this.lblSelectSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectSession.Location = new System.Drawing.Point(55, 40);
            this.lblSelectSession.Name = "lblSelectSession";
            this.lblSelectSession.Size = new System.Drawing.Size(174, 20);
            this.lblSelectSession.TabIndex = 0;
            this.lblSelectSession.Text = "Select Delivery Session";
            // 
            // lblMorning
            // 
            this.lblMorning.AutoSize = true;
            this.lblMorning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMorning.Location = new System.Drawing.Point(78, 76);
            this.lblMorning.Name = "lblMorning";
            this.lblMorning.Size = new System.Drawing.Size(171, 16);
            this.lblMorning.TabIndex = 1;
            this.lblMorning.Text = "Morning (9:00AM - 12:00PM)";
            // 
            // lblEvening
            // 
            this.lblEvening.AutoSize = true;
            this.lblEvening.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvening.Location = new System.Drawing.Point(77, 139);
            this.lblEvening.Name = "lblEvening";
            this.lblEvening.Size = new System.Drawing.Size(172, 16);
            this.lblEvening.TabIndex = 2;
            this.lblEvening.Text = "Evening (6:00PM - 10:00PM)";
            // 
            // lblAfternoon
            // 
            this.lblAfternoon.AutoSize = true;
            this.lblAfternoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfternoon.Location = new System.Drawing.Point(78, 106);
            this.lblAfternoon.Name = "lblAfternoon";
            this.lblAfternoon.Size = new System.Drawing.Size(173, 16);
            this.lblAfternoon.TabIndex = 3;
            this.lblAfternoon.Text = "Afternoon (1:00PM - 5:00PM)";
            // 
            // radioButtonMorning
            // 
            this.radioButtonMorning.AutoSize = true;
            this.radioButtonMorning.Location = new System.Drawing.Point(58, 76);
            this.radioButtonMorning.Name = "radioButtonMorning";
            this.radioButtonMorning.Size = new System.Drawing.Size(14, 13);
            this.radioButtonMorning.TabIndex = 4;
            this.radioButtonMorning.TabStop = true;
            this.radioButtonMorning.UseVisualStyleBackColor = true;
            // 
            // radioButtonEvening
            // 
            this.radioButtonEvening.AutoSize = true;
            this.radioButtonEvening.Location = new System.Drawing.Point(58, 142);
            this.radioButtonEvening.Name = "radioButtonEvening";
            this.radioButtonEvening.Size = new System.Drawing.Size(14, 13);
            this.radioButtonEvening.TabIndex = 5;
            this.radioButtonEvening.TabStop = true;
            this.radioButtonEvening.UseVisualStyleBackColor = true;
            // 
            // radioButtonAfternoon
            // 
            this.radioButtonAfternoon.AutoSize = true;
            this.radioButtonAfternoon.Location = new System.Drawing.Point(58, 109);
            this.radioButtonAfternoon.Name = "radioButtonAfternoon";
            this.radioButtonAfternoon.Size = new System.Drawing.Size(14, 13);
            this.radioButtonAfternoon.TabIndex = 6;
            this.radioButtonAfternoon.TabStop = true;
            this.radioButtonAfternoon.UseVisualStyleBackColor = true;
            // 
            // lblSelectCourier
            // 
            this.lblSelectCourier.AutoSize = true;
            this.lblSelectCourier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCourier.Location = new System.Drawing.Point(56, 199);
            this.lblSelectCourier.Name = "lblSelectCourier";
            this.lblSelectCourier.Size = new System.Drawing.Size(109, 20);
            this.lblSelectCourier.TabIndex = 7;
            this.lblSelectCourier.Text = "Select Courier";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(60, 233);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 20);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "Selected Courier";
            // 
            // lblSelectDate
            // 
            this.lblSelectDate.AutoSize = true;
            this.lblSelectDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDate.Location = new System.Drawing.Point(56, 282);
            this.lblSelectDate.Name = "lblSelectDate";
            this.lblSelectDate.Size = new System.Drawing.Size(152, 20);
            this.lblSelectDate.TabIndex = 9;
            this.lblSelectDate.Text = "Select Delivery Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(59, 319);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // lblEarliest
            // 
            this.lblEarliest.AutoSize = true;
            this.lblEarliest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEarliest.Location = new System.Drawing.Point(359, 69);
            this.lblEarliest.Name = "lblEarliest";
            this.lblEarliest.Size = new System.Drawing.Size(383, 20);
            this.lblEarliest.TabIndex = 11;
            this.lblEarliest.Text = "Earliest Delivery Date Possible For Selected Session:";
            // 
            // txtEarliest
            // 
            this.txtEarliest.Location = new System.Drawing.Point(363, 109);
            this.txtEarliest.Name = "txtEarliest";
            this.txtEarliest.Size = new System.Drawing.Size(183, 22);
            this.txtEarliest.TabIndex = 12;
            // 
            // lblProductsDelivered
            // 
            this.lblProductsDelivered.AutoSize = true;
            this.lblProductsDelivered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductsDelivered.Location = new System.Drawing.Point(359, 153);
            this.lblProductsDelivered.Name = "lblProductsDelivered";
            this.lblProductsDelivered.Size = new System.Drawing.Size(212, 20);
            this.lblProductsDelivered.TabIndex = 13;
            this.lblProductsDelivered.Text = "Products To Be Delivered";
            // 
            // dgvProductsDelivered
            // 
            this.dgvProductsDelivered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsDelivered.Location = new System.Drawing.Point(363, 190);
            this.dgvProductsDelivered.Name = "dgvProductsDelivered";
            this.dgvProductsDelivered.RowTemplate.Height = 24;
            this.dgvProductsDelivered.Size = new System.Drawing.Size(346, 126);
            this.dgvProductsDelivered.TabIndex = 14;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBack.Location = new System.Drawing.Point(363, 405);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 33);
            this.btnBack.TabIndex = 108;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnArrangeDelivery
            // 
            this.btnArrangeDelivery.BackColor = System.Drawing.Color.DarkOrange;
            this.btnArrangeDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArrangeDelivery.ForeColor = System.Drawing.SystemColors.Window;
            this.btnArrangeDelivery.Location = new System.Drawing.Point(363, 349);
            this.btnArrangeDelivery.Name = "btnArrangeDelivery";
            this.btnArrangeDelivery.Size = new System.Drawing.Size(168, 33);
            this.btnArrangeDelivery.TabIndex = 109;
            this.btnArrangeDelivery.Text = "Arrange Delivery";
            this.btnArrangeDelivery.UseVisualStyleBackColor = false;
            this.btnArrangeDelivery.Visible = false;
            // 
            // btnSplitDelivery
            // 
            this.btnSplitDelivery.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSplitDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSplitDelivery.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSplitDelivery.Location = new System.Drawing.Point(665, 410);
            this.btnSplitDelivery.Name = "btnSplitDelivery";
            this.btnSplitDelivery.Size = new System.Drawing.Size(123, 28);
            this.btnSplitDelivery.TabIndex = 110;
            this.btnSplitDelivery.Text = "Split Delivery";
            this.btnSplitDelivery.UseVisualStyleBackColor = false;
            // 
            // ArrangeSingleDeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSplitDelivery);
            this.Controls.Add(this.btnArrangeDelivery);
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
            this.Name = "ArrangeSingleDeliveryForm";
            this.Text = "ArrangeSingleDeliveryForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsDelivered)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectSession;
        private System.Windows.Forms.Label lblMorning;
        private System.Windows.Forms.Label lblEvening;
        private System.Windows.Forms.Label lblAfternoon;
        private System.Windows.Forms.RadioButton radioButtonMorning;
        private System.Windows.Forms.RadioButton radioButtonEvening;
        private System.Windows.Forms.RadioButton radioButtonAfternoon;
        private System.Windows.Forms.Label lblSelectCourier;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblSelectDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblEarliest;
        private System.Windows.Forms.TextBox txtEarliest;
        private System.Windows.Forms.Label lblProductsDelivered;
        private System.Windows.Forms.DataGridView dgvProductsDelivered;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnArrangeDelivery;
        private System.Windows.Forms.Button btnSplitDelivery;
    }
}
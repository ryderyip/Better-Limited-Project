namespace Better_Limited_Project.Sales.Sales.SalesOrder
{
    partial class DeliverySessionSelectionForm
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
            this.lblSelectDeliverySession = new System.Windows.Forms.Label();
            this.radioButtonMorning = new System.Windows.Forms.RadioButton();
            this.radioButtonEvening = new System.Windows.Forms.RadioButton();
            this.radioButtonAfternoon = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelectDeliverySession
            // 
            this.lblSelectDeliverySession.AutoSize = true;
            this.lblSelectDeliverySession.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblSelectDeliverySession.Location = new System.Drawing.Point(35, 30);
            this.lblSelectDeliverySession.Name = "lblSelectDeliverySession";
            this.lblSelectDeliverySession.Size = new System.Drawing.Size(197, 20);
            this.lblSelectDeliverySession.TabIndex = 0;
            this.lblSelectDeliverySession.Text = "Select Delivery Session";
            // 
            // radioButtonMorning
            // 
            this.radioButtonMorning.AutoSize = true;
            this.radioButtonMorning.Location = new System.Drawing.Point(46, 77);
            this.radioButtonMorning.Name = "radioButtonMorning";
            this.radioButtonMorning.Size = new System.Drawing.Size(161, 17);
            this.radioButtonMorning.TabIndex = 4;
            this.radioButtonMorning.TabStop = true;
            this.radioButtonMorning.Text = "Morning (9:00AM - 12:00PM)";
            this.radioButtonMorning.UseVisualStyleBackColor = true;
            // 
            // radioButtonEvening
            // 
            this.radioButtonEvening.AutoSize = true;
            this.radioButtonEvening.Location = new System.Drawing.Point(46, 160);
            this.radioButtonEvening.Name = "radioButtonEvening";
            this.radioButtonEvening.Size = new System.Drawing.Size(162, 17);
            this.radioButtonEvening.TabIndex = 5;
            this.radioButtonEvening.TabStop = true;
            this.radioButtonEvening.Text = "Evening (6:00PM - 10:00PM)";
            this.radioButtonEvening.UseVisualStyleBackColor = true;
            // 
            // radioButtonAfternoon
            // 
            this.radioButtonAfternoon.AutoSize = true;
            this.radioButtonAfternoon.Location = new System.Drawing.Point(46, 118);
            this.radioButtonAfternoon.Name = "radioButtonAfternoon";
            this.radioButtonAfternoon.Size = new System.Drawing.Size(163, 17);
            this.radioButtonAfternoon.TabIndex = 6;
            this.radioButtonAfternoon.TabStop = true;
            this.radioButtonAfternoon.Text = "Afternoon (1:00PM - 5:00PM)";
            this.radioButtonAfternoon.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNext.Location = new System.Drawing.Point(87, 214);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(81, 36);
            this.btnNext.TabIndex = 69;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // DeliverySessionSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 290);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.radioButtonAfternoon);
            this.Controls.Add(this.radioButtonEvening);
            this.Controls.Add(this.radioButtonMorning);
            this.Controls.Add(this.lblSelectDeliverySession);
            this.Name = "DeliverySessionSelectionForm";
            this.Text = "DeliverySessionSelectionForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblSelectDeliverySession;
        private System.Windows.Forms.RadioButton radioButtonMorning;
        private System.Windows.Forms.RadioButton radioButtonEvening;
        private System.Windows.Forms.RadioButton radioButtonAfternoon;
        private System.Windows.Forms.Button btnNext;
    }
}
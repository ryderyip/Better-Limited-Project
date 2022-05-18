namespace Better_Limited_Project.Sales.Sales.Payment
{
    partial class PaymentMethodSelectionForm
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
            this.btnNext = new System.Windows.Forms.Button();
            this.lblSelectDeliverySession = new System.Windows.Forms.Label();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.rbCreditCard = new System.Windows.Forms.RadioButton();
            this.rbOctopus = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNext.Location = new System.Drawing.Point(86, 196);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(98, 40);
            this.btnNext.TabIndex = 52;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblSelectDeliverySession
            // 
            this.lblSelectDeliverySession.AutoSize = true;
            this.lblSelectDeliverySession.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblSelectDeliverySession.Location = new System.Drawing.Point(40, 36);
            this.lblSelectDeliverySession.Name = "lblSelectDeliverySession";
            this.lblSelectDeliverySession.Size = new System.Drawing.Size(199, 20);
            this.lblSelectDeliverySession.TabIndex = 53;
            this.lblSelectDeliverySession.Text = "Select Payment Method";
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Location = new System.Drawing.Point(94, 82);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(49, 17);
            this.rbCash.TabIndex = 54;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Cash";
            this.rbCash.UseVisualStyleBackColor = true;
            // 
            // rbCreditCard
            // 
            this.rbCreditCard.AutoSize = true;
            this.rbCreditCard.Location = new System.Drawing.Point(94, 118);
            this.rbCreditCard.Name = "rbCreditCard";
            this.rbCreditCard.Size = new System.Drawing.Size(77, 17);
            this.rbCreditCard.TabIndex = 55;
            this.rbCreditCard.TabStop = true;
            this.rbCreditCard.Text = "Credit Card";
            this.rbCreditCard.UseVisualStyleBackColor = true;
            // 
            // rbOctopus
            // 
            this.rbOctopus.AutoSize = true;
            this.rbOctopus.Location = new System.Drawing.Point(94, 153);
            this.rbOctopus.Name = "rbOctopus";
            this.rbOctopus.Size = new System.Drawing.Size(90, 17);
            this.rbOctopus.TabIndex = 56;
            this.rbOctopus.TabStop = true;
            this.rbOctopus.Text = "Octopus Card";
            this.rbOctopus.UseVisualStyleBackColor = true;
            // 
            // PaymentMethodSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 278);
            this.Controls.Add(this.rbOctopus);
            this.Controls.Add(this.rbCreditCard);
            this.Controls.Add(this.rbCash);
            this.Controls.Add(this.lblSelectDeliverySession);
            this.Controls.Add(this.btnNext);
            this.Name = "PaymentMethodSelectionForm";
            this.Text = "PaymentMethod";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.RadioButton rbOctopus;
        private System.Windows.Forms.RadioButton rbCreditCard;

        private System.Windows.Forms.Label lblSelectDeliverySession;

        #endregion

        private System.Windows.Forms.Button btnNext;
    }
}
namespace Better_Limited_Project.Sales.PaymentUtility
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentMethodSelectionForm));
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
            resources.ApplyResources(this.btnNext, "btnNext");
            this.btnNext.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNext.Name = "btnNext";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblSelectDeliverySession
            // 
            resources.ApplyResources(this.lblSelectDeliverySession, "lblSelectDeliverySession");
            this.lblSelectDeliverySession.Name = "lblSelectDeliverySession";
            // 
            // rbCash
            // 
            resources.ApplyResources(this.rbCash, "rbCash");
            this.rbCash.Name = "rbCash";
            this.rbCash.TabStop = true;
            this.rbCash.UseVisualStyleBackColor = true;
            // 
            // rbCreditCard
            // 
            resources.ApplyResources(this.rbCreditCard, "rbCreditCard");
            this.rbCreditCard.Name = "rbCreditCard";
            this.rbCreditCard.TabStop = true;
            this.rbCreditCard.UseVisualStyleBackColor = true;
            // 
            // rbOctopus
            // 
            resources.ApplyResources(this.rbOctopus, "rbOctopus");
            this.rbOctopus.Name = "rbOctopus";
            this.rbOctopus.TabStop = true;
            this.rbOctopus.UseVisualStyleBackColor = true;
            // 
            // PaymentMethodSelectionForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rbOctopus);
            this.Controls.Add(this.rbCreditCard);
            this.Controls.Add(this.rbCash);
            this.Controls.Add(this.lblSelectDeliverySession);
            this.Controls.Add(this.btnNext);
            this.Name = "PaymentMethodSelectionForm";
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
namespace Better_Limited_Project.Sales.PaymentUtility.UI
{
    partial class CreditCardPaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditCardPaymentForm));
            this.lblRemind = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCashOwned = new System.Windows.Forms.TextBox();
            this.lblCashOwned = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRemind
            // 
            resources.ApplyResources(this.lblRemind, "lblRemind");
            this.lblRemind.Name = "lblRemind";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tbCashOwned
            // 
            resources.ApplyResources(this.tbCashOwned, "tbCashOwned");
            this.tbCashOwned.Name = "tbCashOwned";
            this.tbCashOwned.ReadOnly = true;
            // 
            // lblCashOwned
            // 
            resources.ApplyResources(this.lblCashOwned, "lblCashOwned");
            this.lblCashOwned.BackColor = System.Drawing.SystemColors.Control;
            this.lblCashOwned.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCashOwned.Name = "lblCashOwned";
            // 
            // CreditCardPaymentForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbCashOwned);
            this.Controls.Add(this.lblCashOwned);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRemind);
            this.Name = "CreditCardPaymentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRemind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCashOwned;
        private System.Windows.Forms.Label lblCashOwned;
    }
}
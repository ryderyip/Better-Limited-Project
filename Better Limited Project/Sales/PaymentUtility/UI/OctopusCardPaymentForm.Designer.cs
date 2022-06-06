namespace Better_Limited_Project.Sales.PaymentUtility.UI
{
    partial class OctopusCardPaymentForm
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
            this.tbCashOwned = new System.Windows.Forms.TextBox();
            this.lblCashOwned = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRemind = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbCashOwned
            // 
            this.tbCashOwned.Location = new System.Drawing.Point(143, 195);
            this.tbCashOwned.Name = "tbCashOwned";
            this.tbCashOwned.ReadOnly = true;
            this.tbCashOwned.Size = new System.Drawing.Size(144, 20);
            this.tbCashOwned.TabIndex = 58;
            // 
            // lblCashOwned
            // 
            this.lblCashOwned.AutoSize = true;
            this.lblCashOwned.BackColor = System.Drawing.SystemColors.Control;
            this.lblCashOwned.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashOwned.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCashOwned.Location = new System.Drawing.Point(147, 167);
            this.lblCashOwned.Name = "lblCashOwned";
            this.lblCashOwned.Size = new System.Drawing.Size(135, 25);
            this.lblCashOwned.TabIndex = 57;
            this.lblCashOwned.Text = "Cash Owned";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 31);
            this.label1.TabIndex = 55;
            this.label1.Text = "Scan Octopus Card";
            // 
            // lblRemind
            // 
            this.lblRemind.AutoSize = true;
            this.lblRemind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemind.Location = new System.Drawing.Point(23, 102);
            this.lblRemind.Name = "lblRemind";
            this.lblRemind.Size = new System.Drawing.Size(382, 20);
            this.lblRemind.TabIndex = 54;
            this.lblRemind.Text = "Please scan the card using the octopus card terminal";
            // 
            // OctopusCardPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 267);
            this.Controls.Add(this.tbCashOwned);
            this.Controls.Add(this.lblCashOwned);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRemind);
            this.Name = "OctopusCardPaymentForm";
            this.Text = "OctopusCardPaymentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCashOwned;
        private System.Windows.Forms.Label lblCashOwned;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRemind;
    }
}
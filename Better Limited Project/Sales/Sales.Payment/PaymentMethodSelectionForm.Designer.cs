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
            this.lblRemind = new System.Windows.Forms.Label();
            this.lblCash = new System.Windows.Forms.Label();
            this.lblCreditCard = new System.Windows.Forms.Label();
            this.lblOctopusCard = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRemind
            // 
            this.lblRemind.AutoSize = true;
            this.lblRemind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemind.Location = new System.Drawing.Point(280, 58);
            this.lblRemind.Name = "lblRemind";
            this.lblRemind.Size = new System.Drawing.Size(188, 15);
            this.lblRemind.TabIndex = 1;
            this.lblRemind.Text = "Please Select A Payment Method";
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCash.Location = new System.Drawing.Point(335, 120);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(68, 29);
            this.lblCash.TabIndex = 2;
            this.lblCash.Text = "Cash";
            // 
            // lblCreditCard
            // 
            this.lblCreditCard.AutoSize = true;
            this.lblCreditCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCard.Location = new System.Drawing.Point(305, 174);
            this.lblCreditCard.Name = "lblCreditCard";
            this.lblCreditCard.Size = new System.Drawing.Size(136, 29);
            this.lblCreditCard.TabIndex = 3;
            this.lblCreditCard.Text = "Credit Card";
            // 
            // lblOctopusCard
            // 
            this.lblOctopusCard.AutoSize = true;
            this.lblOctopusCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOctopusCard.Location = new System.Drawing.Point(294, 227);
            this.lblOctopusCard.Name = "lblOctopusCard";
            this.lblOctopusCard.Size = new System.Drawing.Size(161, 29);
            this.lblOctopusCard.TabIndex = 4;
            this.lblOctopusCard.Text = "Octopus Card";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNext.Location = new System.Drawing.Point(400, 304);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(98, 37);
            this.btnNext.TabIndex = 52;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBack.Location = new System.Drawing.Point(269, 304);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 37);
            this.btnBack.TabIndex = 51;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // PaymentMethodSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblOctopusCard);
            this.Controls.Add(this.lblCreditCard);
            this.Controls.Add(this.lblCash);
            this.Controls.Add(this.lblRemind);
            this.Name = "PaymentMethodSelectionForm";
            this.Text = "PaymentMethod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRemind;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label lblCreditCard;
        private System.Windows.Forms.Label lblOctopusCard;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
    }
}
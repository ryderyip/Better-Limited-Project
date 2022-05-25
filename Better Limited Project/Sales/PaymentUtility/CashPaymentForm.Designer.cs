namespace Better_Limited_Project.Sales.PaymentUtility
{
    partial class CashPaymentForm
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
            this.lblCashOwned = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblAmtTendered = new System.Windows.Forms.Label();
            this.txtAmtTendered = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRemind
            // 
            this.lblRemind.AutoSize = true;
            this.lblRemind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemind.Location = new System.Drawing.Point(230, 58);
            this.lblRemind.Name = "lblRemind";
            this.lblRemind.Size = new System.Drawing.Size(273, 15);
            this.lblRemind.TabIndex = 0;
            this.lblRemind.Text = "Please Enter The Amount Tendered by Customer";
            // 
            // lblCashOwned
            // 
            this.lblCashOwned.AutoSize = true;
            this.lblCashOwned.BackColor = System.Drawing.SystemColors.Control;
            this.lblCashOwned.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashOwned.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCashOwned.Location = new System.Drawing.Point(226, 137);
            this.lblCashOwned.Name = "lblCashOwned";
            this.lblCashOwned.Size = new System.Drawing.Size(211, 37);
            this.lblCashOwned.TabIndex = 45;
            this.lblCashOwned.Text = "Cash Owned:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(443, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 46;
            // 
            // lblAmtTendered
            // 
            this.lblAmtTendered.AutoSize = true;
            this.lblAmtTendered.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmtTendered.Location = new System.Drawing.Point(256, 239);
            this.lblAmtTendered.Name = "lblAmtTendered";
            this.lblAmtTendered.Size = new System.Drawing.Size(105, 15);
            this.lblAmtTendered.TabIndex = 47;
            this.lblAmtTendered.Text = "Amount Tendered";
            // 
            // txtAmtTendered
            // 
            this.txtAmtTendered.Location = new System.Drawing.Point(259, 275);
            this.txtAmtTendered.Name = "txtAmtTendered";
            this.txtAmtTendered.Size = new System.Drawing.Size(244, 22);
            this.txtAmtTendered.TabIndex = 48;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBack.Location = new System.Drawing.Point(270, 350);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 37);
            this.btnBack.TabIndex = 49;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNext.Location = new System.Drawing.Point(401, 350);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(98, 37);
            this.btnNext.TabIndex = 50;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // CashPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtAmtTendered);
            this.Controls.Add(this.lblAmtTendered);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCashOwned);
            this.Controls.Add(this.lblRemind);
            this.Name = "CashPaymentForm";
            this.Text = "CashPaymentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRemind;
        private System.Windows.Forms.Label lblCashOwned;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblAmtTendered;
        private System.Windows.Forms.TextBox txtAmtTendered;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
    }
}
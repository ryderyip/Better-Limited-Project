namespace Better_Limited_Project.Sales.PaymentUtility.UI
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblCashOwned = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.tbCashOwned = new System.Windows.Forms.TextBox();
            this.nudAmountTendered = new System.Windows.Forms.NumericUpDown();
            this.lblAmountTendered = new System.Windows.Forms.Label();
            this.tbChange = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountTendered)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(130, 37);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(541, 29);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Please Enter The Amount Tendered by Customer";
            // 
            // lblCashOwned
            // 
            this.lblCashOwned.AutoSize = true;
            this.lblCashOwned.BackColor = System.Drawing.SystemColors.Control;
            this.lblCashOwned.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashOwned.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCashOwned.Location = new System.Drawing.Point(331, 114);
            this.lblCashOwned.Name = "lblCashOwned";
            this.lblCashOwned.Size = new System.Drawing.Size(135, 25);
            this.lblCashOwned.TabIndex = 45;
            this.lblCashOwned.Text = "Cash Owned";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNext.Location = new System.Drawing.Point(351, 398);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(98, 46);
            this.btnNext.TabIndex = 50;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tbCashOwned
            // 
            this.tbCashOwned.Location = new System.Drawing.Point(326, 142);
            this.tbCashOwned.Name = "tbCashOwned";
            this.tbCashOwned.ReadOnly = true;
            this.tbCashOwned.Size = new System.Drawing.Size(144, 20);
            this.tbCashOwned.TabIndex = 46;
            // 
            // nudAmountTendered
            // 
            this.nudAmountTendered.Location = new System.Drawing.Point(313, 246);
            this.nudAmountTendered.Name = "nudAmountTendered";
            this.nudAmountTendered.Size = new System.Drawing.Size(169, 20);
            this.nudAmountTendered.TabIndex = 51;
            this.nudAmountTendered.ValueChanged += new System.EventHandler(this.nudAmountTendered_ValueChanged);
            // 
            // lblAmountTendered
            // 
            this.lblAmountTendered.AutoSize = true;
            this.lblAmountTendered.BackColor = System.Drawing.SystemColors.Control;
            this.lblAmountTendered.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountTendered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAmountTendered.Location = new System.Drawing.Point(308, 218);
            this.lblAmountTendered.Name = "lblAmountTendered";
            this.lblAmountTendered.Size = new System.Drawing.Size(183, 25);
            this.lblAmountTendered.TabIndex = 52;
            this.lblAmountTendered.Text = "Amount Tendered";
            // 
            // tbChange
            // 
            this.tbChange.Location = new System.Drawing.Point(326, 325);
            this.tbChange.Name = "tbChange";
            this.tbChange.ReadOnly = true;
            this.tbChange.Size = new System.Drawing.Size(144, 20);
            this.tbChange.TabIndex = 53;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.BackColor = System.Drawing.SystemColors.Control;
            this.lblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblChange.Location = new System.Drawing.Point(353, 297);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(87, 25);
            this.lblChange.TabIndex = 54;
            this.lblChange.Text = "Change";
            // 
            // CashPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.tbChange);
            this.Controls.Add(this.lblAmountTendered);
            this.Controls.Add(this.nudAmountTendered);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.tbCashOwned);
            this.Controls.Add(this.lblCashOwned);
            this.Controls.Add(this.lblHeader);
            this.Name = "CashPaymentForm";
            this.Text = "CashPaymentForm";
            this.Shown += new System.EventHandler(this.CashPaymentForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountTendered)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblCashOwned;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox tbCashOwned;
        private System.Windows.Forms.NumericUpDown nudAmountTendered;
        private System.Windows.Forms.Label lblAmountTendered;
        private System.Windows.Forms.TextBox tbChange;
        private System.Windows.Forms.Label lblChange;
    }
}
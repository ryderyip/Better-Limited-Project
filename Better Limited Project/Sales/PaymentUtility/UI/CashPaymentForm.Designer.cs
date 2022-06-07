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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashPaymentForm));
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
            resources.ApplyResources(this.lblHeader, "lblHeader");
            this.lblHeader.Name = "lblHeader";
            // 
            // lblCashOwned
            // 
            resources.ApplyResources(this.lblCashOwned, "lblCashOwned");
            this.lblCashOwned.BackColor = System.Drawing.SystemColors.Control;
            this.lblCashOwned.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCashOwned.Name = "lblCashOwned";
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
            // tbCashOwned
            // 
            resources.ApplyResources(this.tbCashOwned, "tbCashOwned");
            this.tbCashOwned.Name = "tbCashOwned";
            this.tbCashOwned.ReadOnly = true;
            // 
            // nudAmountTendered
            // 
            resources.ApplyResources(this.nudAmountTendered, "nudAmountTendered");
            this.nudAmountTendered.Name = "nudAmountTendered";
            this.nudAmountTendered.ValueChanged += new System.EventHandler(this.nudAmountTendered_ValueChanged);
            // 
            // lblAmountTendered
            // 
            resources.ApplyResources(this.lblAmountTendered, "lblAmountTendered");
            this.lblAmountTendered.BackColor = System.Drawing.SystemColors.Control;
            this.lblAmountTendered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAmountTendered.Name = "lblAmountTendered";
            // 
            // tbChange
            // 
            resources.ApplyResources(this.tbChange, "tbChange");
            this.tbChange.Name = "tbChange";
            this.tbChange.ReadOnly = true;
            // 
            // lblChange
            // 
            resources.ApplyResources(this.lblChange, "lblChange");
            this.lblChange.BackColor = System.Drawing.SystemColors.Control;
            this.lblChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblChange.Name = "lblChange";
            // 
            // CashPaymentForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.tbChange);
            this.Controls.Add(this.lblAmountTendered);
            this.Controls.Add(this.nudAmountTendered);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.tbCashOwned);
            this.Controls.Add(this.lblCashOwned);
            this.Controls.Add(this.lblHeader);
            this.Name = "CashPaymentForm";
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

namespace Better_Limited_Project.Sales.Sales.SalesOrder.CustomerRecord
{
    partial class IsFirstTimeCustomerSelectionForm
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
            this.btnFirstTime = new System.Windows.Forms.Button();
            this.btnOldCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFirstTime
            // 
            this.btnFirstTime.Location = new System.Drawing.Point(12, 12);
            this.btnFirstTime.Name = "btnFirstTime";
            this.btnFirstTime.Size = new System.Drawing.Size(217, 89);
            this.btnFirstTime.TabIndex = 0;
            this.btnFirstTime.Text = "First Time Customer";
            this.btnFirstTime.UseVisualStyleBackColor = true;
            this.btnFirstTime.Click += new System.EventHandler(this.btnFirstTime_Click);
            // 
            // btnOldCustomer
            // 
            this.btnOldCustomer.Location = new System.Drawing.Point(12, 110);
            this.btnOldCustomer.Name = "btnOldCustomer";
            this.btnOldCustomer.Size = new System.Drawing.Size(217, 89);
            this.btnOldCustomer.TabIndex = 1;
            this.btnOldCustomer.Text = "Old Customer";
            this.btnOldCustomer.UseVisualStyleBackColor = true;
            this.btnOldCustomer.Click += new System.EventHandler(this.btnOldCustomer_Click);
            // 
            // IsFirstTimeCustomerSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 211);
            this.Controls.Add(this.btnOldCustomer);
            this.Controls.Add(this.btnFirstTime);
            this.KeyPreview = true;
            this.Name = "IsFirstTimeCustomerSelectionForm";
            this.Text = "CustomerRecordForm";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IsFirstTimeCustomerSelectionForm_KeyPress);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnFirstTime;
        private System.Windows.Forms.Button btnOldCustomer;
    }
}

namespace Better_Limited_Project.Sales.OrderPlacing.UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IsFirstTimeCustomerSelectionForm));
            this.btnFirstTime = new System.Windows.Forms.Button();
            this.btnOldCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFirstTime
            // 
            resources.ApplyResources(this.btnFirstTime, "btnFirstTime");
            this.btnFirstTime.Name = "btnFirstTime";
            this.btnFirstTime.UseVisualStyleBackColor = true;
            this.btnFirstTime.Click += new System.EventHandler(this.btnFirstTime_Click);
            // 
            // btnOldCustomer
            // 
            resources.ApplyResources(this.btnOldCustomer, "btnOldCustomer");
            this.btnOldCustomer.Name = "btnOldCustomer";
            this.btnOldCustomer.UseVisualStyleBackColor = true;
            this.btnOldCustomer.Click += new System.EventHandler(this.btnOldCustomer_Click);
            // 
            // IsFirstTimeCustomerSelectionForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOldCustomer);
            this.Controls.Add(this.btnFirstTime);
            this.KeyPreview = true;
            this.Name = "IsFirstTimeCustomerSelectionForm";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IsFirstTimeCustomerSelectionForm_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFirstTime;
        private System.Windows.Forms.Button btnOldCustomer;
    }
}
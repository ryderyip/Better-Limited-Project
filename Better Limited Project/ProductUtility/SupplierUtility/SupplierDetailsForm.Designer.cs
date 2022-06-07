
namespace Better_Limited_Project.ProductUtility.SupplierUtility
{
    partial class SupplierDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierDetailsForm));
            this.btnRemoveCustomer = new System.Windows.Forms.Button();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tbEmailAddress = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRemoveCustomer
            // 
            this.btnRemoveCustomer.BackColor = System.Drawing.Color.OrangeRed;
            resources.ApplyResources(this.btnRemoveCustomer, "btnRemoveCustomer");
            this.btnRemoveCustomer.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRemoveCustomer.Name = "btnRemoveCustomer";
            this.btnRemoveCustomer.UseVisualStyleBackColor = false;
            this.btnRemoveCustomer.Click += new System.EventHandler(this.btnRemoveCustomer_Click);
            // 
            // tbPhone
            // 
            resources.ApplyResources(this.tbPhone, "tbPhone");
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.ReadOnly = true;
            // 
            // lblPhone
            // 
            resources.ApplyResources(this.lblPhone, "lblPhone");
            this.lblPhone.Name = "lblPhone";
            // 
            // tbEmailAddress
            // 
            resources.ApplyResources(this.tbEmailAddress, "tbEmailAddress");
            this.tbEmailAddress.Name = "tbEmailAddress";
            this.tbEmailAddress.ReadOnly = true;
            // 
            // lblEmail
            // 
            resources.ApplyResources(this.lblEmail, "lblEmail");
            this.lblEmail.Name = "lblEmail";
            // 
            // tbname
            // 
            resources.ApplyResources(this.tbname, "tbname");
            this.tbname.Name = "tbname";
            this.tbname.ReadOnly = true;
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            // 
            // lblHeader
            // 
            resources.ApplyResources(this.lblHeader, "lblHeader");
            this.lblHeader.Name = "lblHeader";
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.BackColor = System.Drawing.Color.Salmon;
            resources.ApplyResources(this.btnUpdateInfo, "btnUpdateInfo");
            this.btnUpdateInfo.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.UseVisualStyleBackColor = false;
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // SupplierDetailsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRemoveCustomer);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.tbEmailAddress);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnUpdateInfo);
            this.Name = "SupplierDetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox tbEmailAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnUpdateInfo;
        private System.Windows.Forms.Button btnRemoveCustomer;
    }
}
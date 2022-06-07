using System.ComponentModel;

namespace Better_Limited_Project.Navigation.UI
{
    partial class AdminNavigationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminNavigationForm));
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.lblAdminMode = new System.Windows.Forms.Label();
            this.btnProductList = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.lblLoggedIn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStaff
            // 
            resources.ApplyResources(this.btnStaff, "btnStaff");
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnSettings
            // 
            resources.ApplyResources(this.btnSettings, "btnSettings");
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnSupplier
            // 
            resources.ApplyResources(this.btnSupplier, "btnSupplier");
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnProfile
            // 
            resources.ApplyResources(this.btnProfile, "btnProfile");
            this.btnProfile.ForeColor = System.Drawing.Color.Red;
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // lblAdminMode
            // 
            resources.ApplyResources(this.lblAdminMode, "lblAdminMode");
            this.lblAdminMode.ForeColor = System.Drawing.Color.Red;
            this.lblAdminMode.Name = "lblAdminMode";
            // 
            // btnProductList
            // 
            resources.ApplyResources(this.btnProductList, "btnProductList");
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.UseVisualStyleBackColor = true;
            this.btnProductList.Click += new System.EventHandler(this.btnProductList_Click);
            // 
            // btnCustomer
            // 
            resources.ApplyResources(this.btnCustomer, "btnCustomer");
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // lblLoggedIn
            // 
            resources.ApplyResources(this.lblLoggedIn, "lblLoggedIn");
            this.lblLoggedIn.Name = "lblLoggedIn";
            // 
            // AdminNavigationForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblLoggedIn);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnProductList);
            this.Controls.Add(this.lblAdminMode);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnSupplier);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnStaff);
            this.Name = "AdminNavigationForm";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Label lblAdminMode;
        private System.Windows.Forms.Button btnProductList;
        private System.Windows.Forms.Button btnCustomer;

        #endregion

        private System.Windows.Forms.Label lblLoggedIn;
    }
}
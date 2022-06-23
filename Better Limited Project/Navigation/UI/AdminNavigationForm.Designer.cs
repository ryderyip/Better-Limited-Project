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
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.lblAdminMode = new System.Windows.Forms.Label();
            this.btnProductList = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.lblLoggedIn = new System.Windows.Forms.Label();
            this.btnManagePermission = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStaff
            // 
            this.btnStaff.Location = new System.Drawing.Point(40, 160);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(111, 34);
            this.btnStaff.TabIndex = 24;
            this.btnStaff.Text = "Staff";
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(40, 320);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(111, 34);
            this.btnSettings.TabIndex = 26;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.Location = new System.Drawing.Point(40, 240);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(111, 34);
            this.btnSupplier.TabIndex = 27;
            this.btnSupplier.Text = "Supplier";
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnProfile.ForeColor = System.Drawing.Color.Red;
            this.btnProfile.Location = new System.Drawing.Point(12, 55);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(164, 48);
            this.btnProfile.TabIndex = 28;
            this.btnProfile.Text = "(Name)";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // lblAdminMode
            // 
            this.lblAdminMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblAdminMode.ForeColor = System.Drawing.Color.Red;
            this.lblAdminMode.Location = new System.Drawing.Point(27, 9);
            this.lblAdminMode.Name = "lblAdminMode";
            this.lblAdminMode.Size = new System.Drawing.Size(135, 24);
            this.lblAdminMode.TabIndex = 29;
            this.lblAdminMode.Text = "ADMIN MODE";
            this.lblAdminMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProductList
            // 
            this.btnProductList.Location = new System.Drawing.Point(40, 200);
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.Size = new System.Drawing.Size(111, 34);
            this.btnProductList.TabIndex = 32;
            this.btnProductList.Text = "Product List";
            this.btnProductList.UseVisualStyleBackColor = true;
            this.btnProductList.Click += new System.EventHandler(this.btnProductList_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(40, 120);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(111, 34);
            this.btnCustomer.TabIndex = 33;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // lblLoggedIn
            // 
            this.lblLoggedIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblLoggedIn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLoggedIn.Location = new System.Drawing.Point(27, 30);
            this.lblLoggedIn.Name = "lblLoggedIn";
            this.lblLoggedIn.Size = new System.Drawing.Size(135, 22);
            this.lblLoggedIn.TabIndex = 34;
            this.lblLoggedIn.Text = "Logged in as";
            this.lblLoggedIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnManagePermission
            // 
            this.btnManagePermission.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnManagePermission.Location = new System.Drawing.Point(40, 280);
            this.btnManagePermission.Name = "btnManagePermission";
            this.btnManagePermission.Size = new System.Drawing.Size(111, 34);
            this.btnManagePermission.TabIndex = 35;
            this.btnManagePermission.Text = "Manage Permission";
            this.btnManagePermission.UseVisualStyleBackColor = true;
            this.btnManagePermission.Click += new System.EventHandler(this.btnManagePermission_Click);
            // 
            // AdminNavigationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(195, 450);
            this.Controls.Add(this.btnManagePermission);
            this.Controls.Add(this.lblLoggedIn);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnProductList);
            this.Controls.Add(this.lblAdminMode);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnSupplier);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnStaff);
            this.Location = new System.Drawing.Point(15, 15);
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
        private System.Windows.Forms.Button btnManagePermission;
    }
}
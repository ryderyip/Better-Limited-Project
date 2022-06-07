using System.ComponentModel;

namespace Better_Limited_Project.Navigation.UI
{
    partial class TechnicalSupportNavigationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TechnicalSupportNavigationForm));
            this.lblLoggedInAs = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnInstallationDuty = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnInstallationRequests = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLoggedInAs
            // 
            resources.ApplyResources(this.lblLoggedInAs, "lblLoggedInAs");
            this.lblLoggedInAs.Name = "lblLoggedInAs";
            // 
            // btnProfile
            // 
            resources.ApplyResources(this.btnProfile, "btnProfile");
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnInstallationDuty
            // 
            resources.ApplyResources(this.btnInstallationDuty, "btnInstallationDuty");
            this.btnInstallationDuty.Name = "btnInstallationDuty";
            this.btnInstallationDuty.UseVisualStyleBackColor = true;
            this.btnInstallationDuty.Click += new System.EventHandler(this.btnInstallationDuty_Click);
            // 
            // btnSettings
            // 
            resources.ApplyResources(this.btnSettings, "btnSettings");
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnInstallationRequests
            // 
            resources.ApplyResources(this.btnInstallationRequests, "btnInstallationRequests");
            this.btnInstallationRequests.Name = "btnInstallationRequests";
            this.btnInstallationRequests.UseVisualStyleBackColor = true;
            this.btnInstallationRequests.Click += new System.EventHandler(this.btnInstallationRequests_Click);
            // 
            // TechnicalSupportNavigationForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblLoggedInAs);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnInstallationDuty);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnInstallationRequests);
            this.Name = "TechnicalSupportNavigationForm";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnInstallationDuty;
        private System.Windows.Forms.Button btnInstallationRequests;

        private System.Windows.Forms.Label lblLoggedInAs;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnSettings;

        #endregion
    }
}
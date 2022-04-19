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
            this.lblLoggedInAs = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnInstallationDuty = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnInstallationRequests = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLoggedInAs
            // 
            this.lblLoggedInAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblLoggedInAs.Location = new System.Drawing.Point(27, 14);
            this.lblLoggedInAs.Name = "lblLoggedInAs";
            this.lblLoggedInAs.Size = new System.Drawing.Size(135, 22);
            this.lblLoggedInAs.TabIndex = 12;
            this.lblLoggedInAs.Text = "Logged in as";
            this.lblLoggedInAs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(12, 48);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(164, 48);
            this.btnProfile.TabIndex = 11;
            this.btnProfile.Text = "(Name)";
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnInstallationDuty
            // 
            this.btnInstallationDuty.Location = new System.Drawing.Point(39, 133);
            this.btnInstallationDuty.Name = "btnInstallationDuty";
            this.btnInstallationDuty.Size = new System.Drawing.Size(111, 34);
            this.btnInstallationDuty.TabIndex = 10;
            this.btnInstallationDuty.Text = "Installation Duty";
            this.btnInstallationDuty.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(39, 213);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(111, 34);
            this.btnSettings.TabIndex = 9;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnInstallationRequests
            // 
            this.btnInstallationRequests.Location = new System.Drawing.Point(34, 173);
            this.btnInstallationRequests.Name = "btnInstallationRequests";
            this.btnInstallationRequests.Size = new System.Drawing.Size(123, 34);
            this.btnInstallationRequests.TabIndex = 7;
            this.btnInstallationRequests.Text = "Installation Requests";
            this.btnInstallationRequests.UseVisualStyleBackColor = true;
            // 
            // TechnicalSupportNavigationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 450);
            this.Controls.Add(this.lblLoggedInAs);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnInstallationDuty);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnInstallationRequests);
            this.Name = "TechnicalSupportNavigationForm";
            this.Text = "TechnicalSupportNavigationForm";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnInstallationDuty;
        private System.Windows.Forms.Button btnInstallationRequests;

        private System.Windows.Forms.Label lblLoggedInAs;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnSalesOrder;

        #endregion
    }
}
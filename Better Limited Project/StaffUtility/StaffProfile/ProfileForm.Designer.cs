using System.ComponentModel;

namespace Better_Limited_Project.StaffUtility.StaffProfile
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblLoggedInAs = new System.Windows.Forms.Label();
            this.lblBelongTo = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStaffId = new System.Windows.Forms.Label();
            this.lblWorkplaceLocation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Firebrick;
            resources.ApplyResources(this.btnLogOut, "btnLogOut");
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblLoggedInAs
            // 
            resources.ApplyResources(this.lblLoggedInAs, "lblLoggedInAs");
            this.lblLoggedInAs.Name = "lblLoggedInAs";
            // 
            // lblBelongTo
            // 
            resources.ApplyResources(this.lblBelongTo, "lblBelongTo");
            this.lblBelongTo.Name = "lblBelongTo";
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.Name = "lblTitle";
            // 
            // lblStaffId
            // 
            resources.ApplyResources(this.lblStaffId, "lblStaffId");
            this.lblStaffId.Name = "lblStaffId";
            // 
            // lblWorkplaceLocation
            // 
            resources.ApplyResources(this.lblWorkplaceLocation, "lblWorkplaceLocation");
            this.lblWorkplaceLocation.Name = "lblWorkplaceLocation";
            // 
            // ProfileForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.lblWorkplaceLocation);
            this.Controls.Add(this.lblStaffId);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblBelongTo);
            this.Controls.Add(this.lblLoggedInAs);
            this.Controls.Add(this.btnLogOut);
            this.Name = "ProfileForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblWorkplaceLocation;

        private System.Windows.Forms.Label lblLoggedInAs;
        private System.Windows.Forms.Label lblBelongTo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStaffId;


        private System.Windows.Forms.Button btnLogOut;

        #endregion
    }
}
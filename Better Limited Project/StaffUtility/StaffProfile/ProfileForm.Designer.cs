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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblLoggedInAs = new System.Windows.Forms.Label();
            this.lblBelongTo = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStaffId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Firebrick;
            this.btnLogOut.Font = new System.Drawing.Font("Noto Sans", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogOut.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLogOut.Location = new System.Drawing.Point(259, 340);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(149, 44);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblLoggedInAs
            // 
            this.lblLoggedInAs.AutoSize = true;
            this.lblLoggedInAs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLoggedInAs.Location = new System.Drawing.Point(203, 167);
            this.lblLoggedInAs.Name = "lblLoggedInAs";
            this.lblLoggedInAs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLoggedInAs.Size = new System.Drawing.Size(116, 13);
            this.lblLoggedInAs.TabIndex = 6;
            this.lblLoggedInAs.Text = "You have logged in as:";
            // 
            // lblBelongTo
            // 
            this.lblBelongTo.AutoSize = true;
            this.lblBelongTo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBelongTo.Location = new System.Drawing.Point(240, 222);
            this.lblBelongTo.Name = "lblBelongTo";
            this.lblBelongTo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBelongTo.Size = new System.Drawing.Size(76, 13);
            this.lblBelongTo.TabIndex = 7;
            this.lblBelongTo.Text = "You belong to:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitle.Location = new System.Drawing.Point(255, 247);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitle.Size = new System.Drawing.Size(61, 13);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Your title is:";
            // 
            // lblStaffId
            // 
            this.lblStaffId.AutoSize = true;
            this.lblStaffId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStaffId.Location = new System.Drawing.Point(240, 195);
            this.lblStaffId.Name = "lblStaffId";
            this.lblStaffId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStaffId.Size = new System.Drawing.Size(79, 13);
            this.lblStaffId.TabIndex = 9;
            this.lblStaffId.Text = "Your staff ID is:";
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.lblStaffId);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblBelongTo);
            this.Controls.Add(this.lblLoggedInAs);
            this.Controls.Add(this.btnLogOut);
            this.Name = "ProfileForm";
            this.Text = "Staff Profile";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblLoggedInAs;
        private System.Windows.Forms.Label lblBelongTo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStaffId;


        private System.Windows.Forms.Button btnLogOut;

        #endregion
    }
}

namespace Better_Limited_Project.StaffUtility.StaffList
{
    partial class UpdateStaffDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateStaffDetailsForm));
            this.rbGenderNonbinary = new System.Windows.Forms.RadioButton();
            this.rbGenderFemale = new System.Windows.Forms.RadioButton();
            this.rbGenderMale = new System.Windows.Forms.RadioButton();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblAlertText = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbTitle = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblBigText = new System.Windows.Forms.Label();
            this.tbAccountUsername = new System.Windows.Forms.TextBox();
            this.lblAccountUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbGenderNonbinary
            // 
            resources.ApplyResources(this.rbGenderNonbinary, "rbGenderNonbinary");
            this.rbGenderNonbinary.Name = "rbGenderNonbinary";
            this.rbGenderNonbinary.TabStop = true;
            this.rbGenderNonbinary.UseVisualStyleBackColor = true;
            // 
            // rbGenderFemale
            // 
            resources.ApplyResources(this.rbGenderFemale, "rbGenderFemale");
            this.rbGenderFemale.Name = "rbGenderFemale";
            this.rbGenderFemale.TabStop = true;
            this.rbGenderFemale.UseVisualStyleBackColor = true;
            // 
            // rbGenderMale
            // 
            resources.ApplyResources(this.rbGenderMale, "rbGenderMale");
            this.rbGenderMale.Name = "rbGenderMale";
            this.rbGenderMale.TabStop = true;
            this.rbGenderMale.UseVisualStyleBackColor = true;
            // 
            // dtpDateOfBirth
            // 
            resources.ApplyResources(this.dtpDateOfBirth, "dtpDateOfBirth");
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            // 
            // lblAlertText
            // 
            resources.ApplyResources(this.lblAlertText, "lblAlertText");
            this.lblAlertText.Name = "lblAlertText";
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.Name = "lblTitle";
            // 
            // cbTitle
            // 
            this.cbTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTitle.FormattingEnabled = true;
            resources.ApplyResources(this.cbTitle, "cbTitle");
            this.cbTitle.Name = "cbTitle";
            // 
            // lblGender
            // 
            resources.ApplyResources(this.lblGender, "lblGender");
            this.lblGender.Name = "lblGender";
            // 
            // tbName
            // 
            resources.ApplyResources(this.tbName, "tbName");
            this.tbName.Name = "tbName";
            // 
            // lblStaffName
            // 
            resources.ApplyResources(this.lblStaffName, "lblStaffName");
            this.lblStaffName.Name = "lblStaffName";
            // 
            // lblDateOfBirth
            // 
            resources.ApplyResources(this.lblDateOfBirth, "lblDateOfBirth");
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkOrange;
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblBigText
            // 
            resources.ApplyResources(this.lblBigText, "lblBigText");
            this.lblBigText.Name = "lblBigText";
            // 
            // tbAccountUsername
            // 
            resources.ApplyResources(this.tbAccountUsername, "tbAccountUsername");
            this.tbAccountUsername.Name = "tbAccountUsername";
            // 
            // lblAccountUsername
            // 
            resources.ApplyResources(this.lblAccountUsername, "lblAccountUsername");
            this.lblAccountUsername.Name = "lblAccountUsername";
            // 
            // UpdateStaffDetailsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbAccountUsername);
            this.Controls.Add(this.lblAccountUsername);
            this.Controls.Add(this.rbGenderNonbinary);
            this.Controls.Add(this.rbGenderFemale);
            this.Controls.Add(this.rbGenderMale);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.lblAlertText);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cbTitle);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblStaffName);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblBigText);
            this.Name = "UpdateStaffDetailsForm";
            this.Shown += new System.EventHandler(this.OnFormShown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbGenderNonbinary;
        private System.Windows.Forms.RadioButton rbGenderFemale;
        private System.Windows.Forms.RadioButton rbGenderMale;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label lblAlertText;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbTitle;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblBigText;
        private System.Windows.Forms.TextBox tbAccountUsername;
        private System.Windows.Forms.Label lblAccountUsername;
    }
}
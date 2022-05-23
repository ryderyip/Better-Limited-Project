
namespace Better_Limited_Project.StaffUtility.StaffList
{
    partial class StaffDetailsForm
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbDepartment = new System.Windows.Forms.TextBox();
            this.lblDept = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.tbDateOfBirth = new System.Windows.Forms.TextBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBig = new System.Windows.Forms.Label();
            this.tbHiredOn = new System.Windows.Forms.TextBox();
            this.tbGender = new System.Windows.Forms.TextBox();
            this.btnUpdateProductInfo = new System.Windows.Forms.Button();
            this.lblHiredOn = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.OrangeRed;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRemove.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRemove.Location = new System.Drawing.Point(26, 370);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(88, 54);
            this.btnRemove.TabIndex = 108;
            this.btnRemove.Text = "Remove Staff";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(487, 259);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.ReadOnly = true;
            this.tbTitle.Size = new System.Drawing.Size(174, 20);
            this.tbTitle.TabIndex = 106;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblTitle.Location = new System.Drawing.Point(448, 260);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(33, 15);
            this.lblTitle.TabIndex = 105;
            this.lblTitle.Text = "Title:";
            // 
            // tbDepartment
            // 
            this.tbDepartment.Location = new System.Drawing.Point(487, 208);
            this.tbDepartment.Name = "tbDepartment";
            this.tbDepartment.ReadOnly = true;
            this.tbDepartment.Size = new System.Drawing.Size(174, 20);
            this.tbDepartment.TabIndex = 102;
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblDept.Location = new System.Drawing.Point(406, 209);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(75, 15);
            this.lblDept.TabIndex = 100;
            this.lblDept.Text = "Department:";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(223, 144);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(149, 20);
            this.tbId.TabIndex = 96;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblId.Location = new System.Drawing.Point(195, 145);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(22, 15);
            this.lblId.TabIndex = 95;
            this.lblId.Text = "ID:";
            // 
            // tbDateOfBirth
            // 
            this.tbDateOfBirth.Location = new System.Drawing.Point(223, 286);
            this.tbDateOfBirth.Name = "tbDateOfBirth";
            this.tbDateOfBirth.ReadOnly = true;
            this.tbDateOfBirth.Size = new System.Drawing.Size(149, 20);
            this.tbDateOfBirth.TabIndex = 94;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblDateOfBirth.Location = new System.Drawing.Point(140, 287);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(77, 15);
            this.lblDateOfBirth.TabIndex = 93;
            this.lblDateOfBirth.Text = "Date of Birth:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(223, 189);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(149, 20);
            this.tbName.TabIndex = 92;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblName.Location = new System.Drawing.Point(173, 190);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 15);
            this.lblName.TabIndex = 91;
            this.lblName.Text = "Name:";
            // 
            // lblBig
            // 
            this.lblBig.AutoSize = true;
            this.lblBig.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblBig.Location = new System.Drawing.Point(298, 38);
            this.lblBig.Name = "lblBig";
            this.lblBig.Size = new System.Drawing.Size(189, 26);
            this.lblBig.TabIndex = 90;
            this.lblBig.Text = "Staff Information";
            this.lblBig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbHiredOn
            // 
            this.tbHiredOn.Location = new System.Drawing.Point(487, 161);
            this.tbHiredOn.Name = "tbHiredOn";
            this.tbHiredOn.ReadOnly = true;
            this.tbHiredOn.Size = new System.Drawing.Size(174, 20);
            this.tbHiredOn.TabIndex = 89;
            // 
            // tbGender
            // 
            this.tbGender.Location = new System.Drawing.Point(223, 238);
            this.tbGender.Name = "tbGender";
            this.tbGender.ReadOnly = true;
            this.tbGender.Size = new System.Drawing.Size(149, 20);
            this.tbGender.TabIndex = 88;
            // 
            // btnUpdateProductInfo
            // 
            this.btnUpdateProductInfo.BackColor = System.Drawing.Color.Salmon;
            this.btnUpdateProductInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnUpdateProductInfo.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdateProductInfo.Location = new System.Drawing.Point(303, 370);
            this.btnUpdateProductInfo.Name = "btnUpdateProductInfo";
            this.btnUpdateProductInfo.Size = new System.Drawing.Size(200, 54);
            this.btnUpdateProductInfo.TabIndex = 87;
            this.btnUpdateProductInfo.Text = "Update Staff Info";
            this.btnUpdateProductInfo.UseVisualStyleBackColor = false;
            this.btnUpdateProductInfo.Click += new System.EventHandler(this.btnUpdateStaffInfo_Click);
            // 
            // lblHiredOn
            // 
            this.lblHiredOn.AutoSize = true;
            this.lblHiredOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblHiredOn.Location = new System.Drawing.Point(412, 162);
            this.lblHiredOn.Name = "lblHiredOn";
            this.lblHiredOn.Size = new System.Drawing.Size(69, 15);
            this.lblHiredOn.TabIndex = 86;
            this.lblHiredOn.Text = "Date Hired:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblGender.Location = new System.Drawing.Point(166, 239);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(51, 15);
            this.lblGender.TabIndex = 85;
            this.lblGender.Text = "Gender:";
            // 
            // StaffDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tbDepartment);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.tbDateOfBirth);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblBig);
            this.Controls.Add(this.tbHiredOn);
            this.Controls.Add(this.tbGender);
            this.Controls.Add(this.btnUpdateProductInfo);
            this.Controls.Add(this.lblHiredOn);
            this.Controls.Add(this.lblGender);
            this.Name = "StaffDetailsForm";
            this.Text = "StaffDetailsForm";
            this.Shown += new System.EventHandler(this.StaffDetailsForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbDepartment;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tbDateOfBirth;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBig;
        private System.Windows.Forms.TextBox tbHiredOn;
        private System.Windows.Forms.TextBox tbGender;
        private System.Windows.Forms.Button btnUpdateProductInfo;
        private System.Windows.Forms.Label lblHiredOn;
        private System.Windows.Forms.Label lblGender;
    }
}
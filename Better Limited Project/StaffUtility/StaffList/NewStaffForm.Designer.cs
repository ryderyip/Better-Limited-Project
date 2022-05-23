using System.ComponentModel;

namespace Better_Limited_Project.StaffUtility.StaffList
{
    partial class NewStaffForm
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
            this.lblNewStaff = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbTitle = new System.Windows.Forms.ComboBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblAlertText = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.rbGenderMale = new System.Windows.Forms.RadioButton();
            this.rbGenderFemale = new System.Windows.Forms.RadioButton();
            this.rbGenderNonbinary = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblNewStaff
            // 
            this.lblNewStaff.AutoSize = true;
            this.lblNewStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblNewStaff.Location = new System.Drawing.Point(328, 31);
            this.lblNewStaff.Name = "lblNewStaff";
            this.lblNewStaff.Size = new System.Drawing.Size(116, 26);
            this.lblNewStaff.TabIndex = 54;
            this.lblNewStaff.Text = "New Staff";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCreate.Location = new System.Drawing.Point(311, 374);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(183, 44);
            this.btnCreate.TabIndex = 63;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblPrice.Location = new System.Drawing.Point(295, 199);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(77, 15);
            this.lblPrice.TabIndex = 67;
            this.lblPrice.Text = "Date of Birth:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(295, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 78;
            this.label2.Text = "Staff Name:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(390, 116);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(120, 20);
            this.tbName.TabIndex = 79;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblDescription.Location = new System.Drawing.Point(319, 159);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(51, 15);
            this.lblDescription.TabIndex = 80;
            this.lblDescription.Text = "Gender:";
            // 
            // cbDepartment
            // 
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(390, 245);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(120, 21);
            this.cbDepartment.TabIndex = 82;
            this.cbDepartment.SelectedIndexChanged += new System.EventHandler(this.cbDepartment_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblCategory.Location = new System.Drawing.Point(300, 246);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(75, 15);
            this.lblCategory.TabIndex = 83;
            this.lblCategory.Text = "Department:";
            // 
            // cbTitle
            // 
            this.cbTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTitle.FormattingEnabled = true;
            this.cbTitle.Location = new System.Drawing.Point(390, 290);
            this.cbTitle.Name = "cbTitle";
            this.cbTitle.Size = new System.Drawing.Size(120, 21);
            this.cbTitle.TabIndex = 84;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblSupplier.Location = new System.Drawing.Point(328, 291);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(33, 15);
            this.lblSupplier.TabIndex = 85;
            this.lblSupplier.Text = "Title:";
            // 
            // lblAlertText
            // 
            this.lblAlertText.AutoSize = true;
            this.lblAlertText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblAlertText.Location = new System.Drawing.Point(340, 57);
            this.lblAlertText.Name = "lblAlertText";
            this.lblAlertText.Size = new System.Drawing.Size(136, 15);
            this.lblAlertText.TabIndex = 86;
            this.lblAlertText.Text = "(All fields must be filled)";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(390, 199);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.dtpDateOfBirth.TabIndex = 87;
            // 
            // rbGenderMale
            // 
            this.rbGenderMale.AutoSize = true;
            this.rbGenderMale.Location = new System.Drawing.Point(390, 159);
            this.rbGenderMale.Name = "rbGenderMale";
            this.rbGenderMale.Size = new System.Drawing.Size(48, 17);
            this.rbGenderMale.TabIndex = 88;
            this.rbGenderMale.TabStop = true;
            this.rbGenderMale.Text = "Male";
            this.rbGenderMale.UseVisualStyleBackColor = true;
            // 
            // rbGenderFemale
            // 
            this.rbGenderFemale.AutoSize = true;
            this.rbGenderFemale.Location = new System.Drawing.Point(444, 159);
            this.rbGenderFemale.Name = "rbGenderFemale";
            this.rbGenderFemale.Size = new System.Drawing.Size(59, 17);
            this.rbGenderFemale.TabIndex = 89;
            this.rbGenderFemale.TabStop = true;
            this.rbGenderFemale.Text = "Female";
            this.rbGenderFemale.UseVisualStyleBackColor = true;
            // 
            // rbGenderNonbinary
            // 
            this.rbGenderNonbinary.AutoSize = true;
            this.rbGenderNonbinary.Location = new System.Drawing.Point(509, 159);
            this.rbGenderNonbinary.Name = "rbGenderNonbinary";
            this.rbGenderNonbinary.Size = new System.Drawing.Size(77, 17);
            this.rbGenderNonbinary.TabIndex = 90;
            this.rbGenderNonbinary.TabStop = true;
            this.rbGenderNonbinary.Text = "Non-Binary";
            this.rbGenderNonbinary.UseVisualStyleBackColor = true;
            // 
            // NewStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbGenderNonbinary);
            this.Controls.Add(this.rbGenderFemale);
            this.Controls.Add(this.rbGenderMale);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.lblAlertText);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.cbTitle);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblNewStaff);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "NewStaffForm";
            this.Shown += new System.EventHandler(this.NewStaffForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblNewStaff;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbTitle;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblAlertText;

        #endregion
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.RadioButton rbGenderMale;
        private System.Windows.Forms.RadioButton rbGenderFemale;
        private System.Windows.Forms.RadioButton rbGenderNonbinary;
    }
}
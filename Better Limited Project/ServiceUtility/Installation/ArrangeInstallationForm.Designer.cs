namespace Better_Limited_Project.ServiceUtility.Installation
{
    partial class ArrangeInstallationForm
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
            this.lblSelectTechnician = new System.Windows.Forms.Label();
            this.comboBoxSelectTechnician = new System.Windows.Forms.ComboBox();
            this.lblSelectDateTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnArrangeInstallation = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelectTechnician
            // 
            this.lblSelectTechnician.AutoSize = true;
            this.lblSelectTechnician.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTechnician.Location = new System.Drawing.Point(366, 66);
            this.lblSelectTechnician.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectTechnician.Name = "lblSelectTechnician";
            this.lblSelectTechnician.Size = new System.Drawing.Size(151, 20);
            this.lblSelectTechnician.TabIndex = 0;
            this.lblSelectTechnician.Text = "Select Technician";
            // 
            // comboBoxSelectTechnician
            // 
            this.comboBoxSelectTechnician.FormattingEnabled = true;
            this.comboBoxSelectTechnician.Location = new System.Drawing.Point(372, 121);
            this.comboBoxSelectTechnician.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxSelectTechnician.Name = "comboBoxSelectTechnician";
            this.comboBoxSelectTechnician.Size = new System.Drawing.Size(289, 28);
            this.comboBoxSelectTechnician.TabIndex = 1;
            // 
            // lblSelectDateTime
            // 
            this.lblSelectDateTime.AutoSize = true;
            this.lblSelectDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDateTime.Location = new System.Drawing.Point(368, 182);
            this.lblSelectDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectDateTime.Name = "lblSelectDateTime";
            this.lblSelectDateTime.Size = new System.Drawing.Size(200, 20);
            this.lblSelectDateTime.TabIndex = 2;
            this.lblSelectDateTime.Text = "Installation Date + Time";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(378, 227);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 20);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(379, 279);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(47, 20);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Time:";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(435, 224);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(133, 26);
            this.txtDate.TabIndex = 5;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(435, 276);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(133, 26);
            this.txtTime.TabIndex = 6;
            // 
            // btnArrangeInstallation
            // 
            this.btnArrangeInstallation.BackColor = System.Drawing.Color.DarkOrange;
            this.btnArrangeInstallation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArrangeInstallation.ForeColor = System.Drawing.SystemColors.Window;
            this.btnArrangeInstallation.Location = new System.Drawing.Point(372, 357);
            this.btnArrangeInstallation.Name = "btnArrangeInstallation";
            this.btnArrangeInstallation.Size = new System.Drawing.Size(198, 33);
            this.btnArrangeInstallation.TabIndex = 125;
            this.btnArrangeInstallation.Text = "Arrange Installation";
            this.btnArrangeInstallation.UseVisualStyleBackColor = false;
            this.btnArrangeInstallation.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBack.Location = new System.Drawing.Point(428, 408);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 33);
            this.btnBack.TabIndex = 126;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // ArrangeInstallationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnArrangeInstallation);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblSelectDateTime);
            this.Controls.Add(this.comboBoxSelectTechnician);
            this.Controls.Add(this.lblSelectTechnician);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ArrangeInstallationForm";
            this.Text = "ArrangeInstallationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectTechnician;
        private System.Windows.Forms.ComboBox comboBoxSelectTechnician;
        private System.Windows.Forms.Label lblSelectDateTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnArrangeInstallation;
        private System.Windows.Forms.Button btnBack;
    }
}

namespace Better_Limited_Project.ServiceUtility.InstallationUtility.UI
{
    partial class TechnicianDetailsForm
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHeader.Location = new System.Drawing.Point(85, 38);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(278, 29);
            this.lblHeader.TabIndex = 129;
            this.lblHeader.Text = "Technician Information";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblName.Location = new System.Drawing.Point(123, 107);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 16);
            this.lblName.TabIndex = 131;
            this.lblName.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(126, 126);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(200, 20);
            this.tbName.TabIndex = 130;
            this.tbName.Text = "-";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblPhone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPhone.Location = new System.Drawing.Point(123, 167);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(47, 16);
            this.lblPhone.TabIndex = 133;
            this.lblPhone.Text = "Phone";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(126, 186);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.ReadOnly = true;
            this.tbPhone.Size = new System.Drawing.Size(200, 20);
            this.tbPhone.TabIndex = 132;
            this.tbPhone.Text = "-";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdate.Location = new System.Drawing.Point(276, 256);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(144, 55);
            this.btnUpdate.TabIndex = 134;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.OrangeRed;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnRemove.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRemove.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRemove.Location = new System.Drawing.Point(31, 256);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(144, 55);
            this.btnRemove.TabIndex = 135;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // TechnicianDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 334);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblHeader);
            this.Name = "TechnicianDetailsForm";
            this.Text = "TechnicianDetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
    }
}
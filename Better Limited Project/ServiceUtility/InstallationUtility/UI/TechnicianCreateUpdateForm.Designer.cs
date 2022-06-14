
namespace Better_Limited_Project.ServiceUtility.InstallationUtility.UI
{
    partial class TechnicianCreateUpdateForm
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHeader.Location = new System.Drawing.Point(36, 26);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(339, 29);
            this.lblHeader.TabIndex = 130;
            this.lblHeader.Text = "Technician Creation/Update";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblName.Location = new System.Drawing.Point(92, 96);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 16);
            this.lblName.TabIndex = 133;
            this.lblName.Text = "Name:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(148, 95);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(170, 20);
            this.tbName.TabIndex = 132;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblPhone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPhone.Location = new System.Drawing.Point(92, 142);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(50, 16);
            this.lblPhone.TabIndex = 135;
            this.lblPhone.Text = "Phone:";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(148, 141);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(170, 20);
            this.tbPhone.TabIndex = 134;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.DarkOrange;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.Window;
            this.btnConfirm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnConfirm.Location = new System.Drawing.Point(133, 199);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(144, 55);
            this.btnConfirm.TabIndex = 136;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(136, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 15);
            this.label6.TabIndex = 191;
            this.label6.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(136, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 15);
            this.label1.TabIndex = 192;
            this.label1.Text = "*";
            // 
            // TechnicianCreateUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 277);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblHeader);
            this.Name = "TechnicianCreateUpdateForm";
            this.Text = "TechnicianCreateUpdateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}
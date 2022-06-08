
namespace Better_Limited_Project.ServiceUtility.Delivery.UI
{
    partial class CourierDetailsForm
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.tbHiredOn = new System.Windows.Forms.TextBox();
            this.tbGender = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblHiredOn = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.OrangeRed;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRemove.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRemove.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRemove.Location = new System.Drawing.Point(25, 255);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(88, 54);
            this.btnRemove.TabIndex = 129;
            this.btnRemove.Text = "Remove Courier";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(169, 101);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(174, 20);
            this.tbName.TabIndex = 120;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblName.Location = new System.Drawing.Point(101, 102);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 15);
            this.lblName.TabIndex = 119;
            this.lblName.Text = "Name:";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHeader.Location = new System.Drawing.Point(126, 32);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(217, 26);
            this.lblHeader.TabIndex = 118;
            this.lblHeader.Text = "Courier Information";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbHiredOn
            // 
            this.tbHiredOn.Location = new System.Drawing.Point(169, 201);
            this.tbHiredOn.Name = "tbHiredOn";
            this.tbHiredOn.ReadOnly = true;
            this.tbHiredOn.Size = new System.Drawing.Size(174, 20);
            this.tbHiredOn.TabIndex = 117;
            // 
            // tbGender
            // 
            this.tbGender.Location = new System.Drawing.Point(169, 150);
            this.tbGender.Name = "tbGender";
            this.tbGender.ReadOnly = true;
            this.tbGender.Size = new System.Drawing.Size(174, 20);
            this.tbGender.TabIndex = 116;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Salmon;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdate.Location = new System.Drawing.Point(213, 255);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(200, 54);
            this.btnUpdate.TabIndex = 115;
            this.btnUpdate.Text = "Update Information";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblHiredOn
            // 
            this.lblHiredOn.AutoSize = true;
            this.lblHiredOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblHiredOn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHiredOn.Location = new System.Drawing.Point(94, 202);
            this.lblHiredOn.Name = "lblHiredOn";
            this.lblHiredOn.Size = new System.Drawing.Size(69, 15);
            this.lblHiredOn.TabIndex = 114;
            this.lblHiredOn.Text = "Date Hired:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblGender.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblGender.Location = new System.Drawing.Point(94, 151);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(51, 15);
            this.lblGender.TabIndex = 113;
            this.lblGender.Text = "Gender:";
            // 
            // CourierDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 333);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbHiredOn);
            this.Controls.Add(this.tbGender);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblHiredOn);
            this.Controls.Add(this.lblGender);
            this.Name = "CourierDetailsForm";
            this.Text = "CourierDetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox tbHiredOn;
        private System.Windows.Forms.TextBox tbGender;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblHiredOn;
        private System.Windows.Forms.Label lblGender;
    }
}
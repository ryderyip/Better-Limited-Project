
namespace Better_Limited_Project.ProductUtility.SupplierUtility
{
    partial class SupplierDetailsForm
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
            this.btnRemoveCustomer = new System.Windows.Forms.Button();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tbEmailAddress = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRemoveCustomer
            // 
            this.btnRemoveCustomer.BackColor = System.Drawing.Color.OrangeRed;
            this.btnRemoveCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRemoveCustomer.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRemoveCustomer.Location = new System.Drawing.Point(41, 370);
            this.btnRemoveCustomer.Name = "btnRemoveCustomer";
            this.btnRemoveCustomer.Size = new System.Drawing.Size(177, 54);
            this.btnRemoveCustomer.TabIndex = 123;
            this.btnRemoveCustomer.Text = "Remove Supplier";
            this.btnRemoveCustomer.UseVisualStyleBackColor = false;
            this.btnRemoveCustomer.Click += new System.EventHandler(this.btnRemoveCustomer_Click);
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(319, 192);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.ReadOnly = true;
            this.tbPhone.Size = new System.Drawing.Size(214, 20);
            this.tbPhone.TabIndex = 119;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(269, 193);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(46, 15);
            this.lblPhone.TabIndex = 118;
            this.lblPhone.Text = "Phone:";
            // 
            // tbEmailAddress
            // 
            this.tbEmailAddress.Location = new System.Drawing.Point(319, 246);
            this.tbEmailAddress.Name = "tbEmailAddress";
            this.tbEmailAddress.ReadOnly = true;
            this.tbEmailAddress.Size = new System.Drawing.Size(214, 20);
            this.tbEmailAddress.TabIndex = 117;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(224, 247);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(89, 15);
            this.lblEmail.TabIndex = 116;
            this.lblEmail.Text = "Email Address:";
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(319, 138);
            this.tbname.Name = "tbname";
            this.tbname.ReadOnly = true;
            this.tbname.Size = new System.Drawing.Size(214, 20);
            this.tbname.TabIndex = 115;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(269, 139);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 15);
            this.lblName.TabIndex = 114;
            this.lblName.Text = "Name:";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(287, 27);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(227, 26);
            this.lblHeader.TabIndex = 113;
            this.lblHeader.Text = "Supplier Information";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.BackColor = System.Drawing.Color.Salmon;
            this.btnUpdateInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInfo.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdateInfo.Location = new System.Drawing.Point(300, 370);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(200, 54);
            this.btnUpdateInfo.TabIndex = 112;
            this.btnUpdateInfo.Text = "Update Supplier Info";
            this.btnUpdateInfo.UseVisualStyleBackColor = false;
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // SupplierDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemoveCustomer);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.tbEmailAddress);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnUpdateInfo);
            this.Name = "SupplierDetailsForm";
            this.Text = "SupplierDetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox tbEmailAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnUpdateInfo;
        private System.Windows.Forms.Button btnRemoveCustomer;
    }
}
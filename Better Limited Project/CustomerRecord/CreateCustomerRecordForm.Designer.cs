namespace Better_Limited_Project.CustomerRecord
{
    partial class CreateCustomerRecordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateCustomerRecordForm));
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblCustPhoneNumber = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblCustomerInfo = new System.Windows.Forms.Label();
            this.lblDeliveryInfo = new System.Windows.Forms.Label();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtCustPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEmailAddress
            // 
            resources.ApplyResources(this.txtEmailAddress, "txtEmailAddress");
            this.txtEmailAddress.Name = "txtEmailAddress";
            // 
            // txtCustName
            // 
            resources.ApplyResources(this.txtCustName, "txtCustName");
            this.txtCustName.Name = "txtCustName";
            // 
            // lblEmailAddress
            // 
            resources.ApplyResources(this.lblEmailAddress, "lblEmailAddress");
            this.lblEmailAddress.Name = "lblEmailAddress";
            // 
            // lblCustPhoneNumber
            // 
            resources.ApplyResources(this.lblCustPhoneNumber, "lblCustPhoneNumber");
            this.lblCustPhoneNumber.Name = "lblCustPhoneNumber";
            // 
            // lblCustName
            // 
            resources.ApplyResources(this.lblCustName, "lblCustName");
            this.lblCustName.Name = "lblCustName";
            // 
            // lblCustomerInfo
            // 
            resources.ApplyResources(this.lblCustomerInfo, "lblCustomerInfo");
            this.lblCustomerInfo.Name = "lblCustomerInfo";
            // 
            // lblDeliveryInfo
            // 
            resources.ApplyResources(this.lblDeliveryInfo, "lblDeliveryInfo");
            this.lblDeliveryInfo.Name = "lblDeliveryInfo";
            // 
            // txtAddress2
            // 
            resources.ApplyResources(this.txtAddress2, "txtAddress2");
            this.txtAddress2.Name = "txtAddress2";
            // 
            // txtAddress1
            // 
            resources.ApplyResources(this.txtAddress1, "txtAddress1");
            this.txtAddress1.Name = "txtAddress1";
            // 
            // lblAddress2
            // 
            resources.ApplyResources(this.lblAddress2, "lblAddress2");
            this.lblAddress2.Name = "lblAddress2";
            // 
            // lblAddress1
            // 
            resources.ApplyResources(this.lblAddress1, "lblAddress1");
            this.lblAddress1.Name = "lblAddress1";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.DarkOrange;
            resources.ApplyResources(this.btnCreate, "btnCreate");
            this.btnCreate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtCustPhoneNumber
            // 
            resources.ApplyResources(this.txtCustPhoneNumber, "txtCustPhoneNumber");
            this.txtCustPhoneNumber.Name = "txtCustPhoneNumber";
            // 
            // lblHeader
            // 
            resources.ApplyResources(this.lblHeader, "lblHeader");
            this.lblHeader.Name = "lblHeader";
            // 
            // CreateCustomerRecordForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.lblAddress2);
            this.Controls.Add(this.lblAddress1);
            this.Controls.Add(this.lblDeliveryInfo);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.txtCustPhoneNumber);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.lblCustPhoneNumber);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.lblCustomerInfo);
            this.Name = "CreateCustomerRecordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnCreate;

        private System.Windows.Forms.TextBox txtCustPhoneNumber;

        #endregion

        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TextBox txtAddress2;


        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblCustPhoneNumber;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblCustomerInfo;
        private System.Windows.Forms.Label lblDeliveryInfo;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.Label lblAddress1;
        public System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblHeader;
    }
}
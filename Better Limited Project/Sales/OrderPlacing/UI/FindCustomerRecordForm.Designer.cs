namespace Better_Limited_Project.Sales.OrderPlacing.UI
{
    partial class FindCustomerRecordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindCustomerRecordForm));
            this.lblSearchKeywords = new System.Windows.Forms.Label();
            this.lblRemind = new System.Windows.Forms.Label();
            this.txtSearchKeywords = new System.Windows.Forms.TextBox();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearchKeywords
            // 
            resources.ApplyResources(this.lblSearchKeywords, "lblSearchKeywords");
            this.lblSearchKeywords.Name = "lblSearchKeywords";
            // 
            // lblRemind
            // 
            resources.ApplyResources(this.lblRemind, "lblRemind");
            this.lblRemind.Name = "lblRemind";
            // 
            // txtSearchKeywords
            // 
            resources.ApplyResources(this.txtSearchKeywords, "txtSearchKeywords");
            this.txtSearchKeywords.Name = "txtSearchKeywords";
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.phone,
            this.email,
            this.address1,
            this.address2});
            resources.ApplyResources(this.dgvCustomer, "dgvCustomer");
            this.dgvCustomer.MultiSelect = false;
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowTemplate.Height = 24;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // name
            // 
            resources.ApplyResources(this.name, "name");
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // phone
            // 
            resources.ApplyResources(this.phone, "phone");
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // email
            // 
            resources.ApplyResources(this.email, "email");
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // address1
            // 
            resources.ApplyResources(this.address1, "address1");
            this.address1.Name = "address1";
            this.address1.ReadOnly = true;
            // 
            // address2
            // 
            resources.ApplyResources(this.address2, "address2");
            this.address2.Name = "address2";
            this.address2.ReadOnly = true;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.DarkOrange;
            resources.ApplyResources(this.btnNext, "btnNext");
            this.btnNext.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNext.Name = "btnNext";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Clicked);
            // 
            // FindCustomerRecordForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.txtSearchKeywords);
            this.Controls.Add(this.lblRemind);
            this.Controls.Add(this.lblSearchKeywords);
            this.Name = "FindCustomerRecordForm";
            this.Shown += new System.EventHandler(this.OnFormShown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn address1;
        private System.Windows.Forms.DataGridViewTextBoxColumn address2;

        public System.Windows.Forms.Button btnNext;

        #endregion

        private System.Windows.Forms.Label lblSearchKeywords;
        private System.Windows.Forms.Label lblRemind;
        private System.Windows.Forms.TextBox txtSearchKeywords;
        private System.Windows.Forms.DataGridView dgvCustomer;
    }
}
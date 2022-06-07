
namespace Better_Limited_Project.ProductUtility.SupplierUtility
{
    partial class SupplierListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierListForm));
            this.btnNewSupplier = new System.Windows.Forms.Button();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbSearchBox = new System.Windows.Forms.TextBox();
            this.lblSearchBox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewSupplier
            // 
            this.btnNewSupplier.BackColor = System.Drawing.Color.DarkOrange;
            resources.ApplyResources(this.btnNewSupplier, "btnNewSupplier");
            this.btnNewSupplier.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNewSupplier.Name = "btnNewSupplier";
            this.btnNewSupplier.UseVisualStyleBackColor = false;
            this.btnNewSupplier.Click += new System.EventHandler(this.btnNewProductClicked_Click);
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.AllowUserToAddRows = false;
            this.dgvSupplier.AllowUserToDeleteRows = false;
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.phone,
            this.email});
            resources.ApplyResources(this.dgvSupplier, "dgvSupplier");
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.ReadOnly = true;
            this.dgvSupplier.RowTemplate.Height = 24;
            this.dgvSupplier.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupplier_CellDoubleClick);
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
            // tbSearchBox
            // 
            resources.ApplyResources(this.tbSearchBox, "tbSearchBox");
            this.tbSearchBox.Name = "tbSearchBox";
            this.tbSearchBox.TextChanged += new System.EventHandler(this.tbSearchBox_TextChanged);
            // 
            // lblSearchBox
            // 
            resources.ApplyResources(this.lblSearchBox, "lblSearchBox");
            this.lblSearchBox.Name = "lblSearchBox";
            // 
            // SupplierListForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNewSupplier);
            this.Controls.Add(this.dgvSupplier);
            this.Controls.Add(this.tbSearchBox);
            this.Controls.Add(this.lblSearchBox);
            this.Name = "SupplierListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnNewSupplier;
        public System.Windows.Forms.DataGridView dgvSupplier;
        public System.Windows.Forms.TextBox tbSearchBox;
        private System.Windows.Forms.Label lblSearchBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}
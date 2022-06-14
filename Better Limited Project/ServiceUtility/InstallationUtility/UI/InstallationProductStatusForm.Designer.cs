
namespace Better_Limited_Project.ServiceUtility.InstallationUtility.UI
{
    partial class InstallationProductStatusForm
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
            this.dgvTechnicians = new System.Windows.Forms.DataGridView();
            this.lblProductsToInstall = new System.Windows.Forms.Label();
            this.lblTechnician = new System.Windows.Forms.Label();
            this.dgvInstallationProduct = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbScheduledOn = new System.Windows.Forms.TextBox();
            this.lblScheduledOn = new System.Windows.Forms.Label();
            this.tbInstalledOn = new System.Windows.Forms.TextBox();
            this.lblInstalledOn = new System.Windows.Forms.Label();
            this.technicianNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.technicianPhoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechnicians)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstallationProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHeader.Location = new System.Drawing.Point(211, 23);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(218, 29);
            this.lblHeader.TabIndex = 121;
            this.lblHeader.Text = "Installation Status";
            // 
            // dgvTechnicians
            // 
            this.dgvTechnicians.AllowUserToAddRows = false;
            this.dgvTechnicians.AllowUserToDeleteRows = false;
            this.dgvTechnicians.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTechnicians.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.technicianNameColumn,
            this.technicianPhoneColumn});
            this.dgvTechnicians.Location = new System.Drawing.Point(342, 171);
            this.dgvTechnicians.Name = "dgvTechnicians";
            this.dgvTechnicians.ReadOnly = true;
            this.dgvTechnicians.Size = new System.Drawing.Size(273, 177);
            this.dgvTechnicians.TabIndex = 122;
            // 
            // lblProductsToInstall
            // 
            this.lblProductsToInstall.AutoSize = true;
            this.lblProductsToInstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblProductsToInstall.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblProductsToInstall.Location = new System.Drawing.Point(89, 137);
            this.lblProductsToInstall.Name = "lblProductsToInstall";
            this.lblProductsToInstall.Size = new System.Drawing.Size(155, 20);
            this.lblProductsToInstall.TabIndex = 123;
            this.lblProductsToInstall.Text = "Products to Install";
            // 
            // lblTechnician
            // 
            this.lblTechnician.AutoSize = true;
            this.lblTechnician.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTechnician.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTechnician.Location = new System.Drawing.Point(421, 137);
            this.lblTechnician.Name = "lblTechnician";
            this.lblTechnician.Size = new System.Drawing.Size(104, 20);
            this.lblTechnician.TabIndex = 124;
            this.lblTechnician.Text = "Technicians";
            // 
            // dgvInstallationProduct
            // 
            this.dgvInstallationProduct.AllowUserToAddRows = false;
            this.dgvInstallationProduct.AllowUserToDeleteRows = false;
            this.dgvInstallationProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstallationProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvInstallationProduct.Location = new System.Drawing.Point(31, 171);
            this.dgvInstallationProduct.Name = "dgvInstallationProduct";
            this.dgvInstallationProduct.ReadOnly = true;
            this.dgvInstallationProduct.Size = new System.Drawing.Size(273, 177);
            this.dgvInstallationProduct.TabIndex = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Product";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 180;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // tbScheduledOn
            // 
            this.tbScheduledOn.Location = new System.Drawing.Point(31, 91);
            this.tbScheduledOn.Name = "tbScheduledOn";
            this.tbScheduledOn.ReadOnly = true;
            this.tbScheduledOn.Size = new System.Drawing.Size(194, 20);
            this.tbScheduledOn.TabIndex = 129;
            // 
            // lblScheduledOn
            // 
            this.lblScheduledOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblScheduledOn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblScheduledOn.Location = new System.Drawing.Point(28, 73);
            this.lblScheduledOn.Name = "lblScheduledOn";
            this.lblScheduledOn.Size = new System.Drawing.Size(88, 15);
            this.lblScheduledOn.TabIndex = 128;
            this.lblScheduledOn.Text = "Scheduled On";
            // 
            // tbInstalledOn
            // 
            this.tbInstalledOn.Location = new System.Drawing.Point(342, 91);
            this.tbInstalledOn.Name = "tbInstalledOn";
            this.tbInstalledOn.ReadOnly = true;
            this.tbInstalledOn.Size = new System.Drawing.Size(194, 20);
            this.tbInstalledOn.TabIndex = 127;
            // 
            // lblInstalledOn
            // 
            this.lblInstalledOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblInstalledOn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblInstalledOn.Location = new System.Drawing.Point(339, 73);
            this.lblInstalledOn.Name = "lblInstalledOn";
            this.lblInstalledOn.Size = new System.Drawing.Size(75, 15);
            this.lblInstalledOn.TabIndex = 126;
            this.lblInstalledOn.Text = "Installed On";
            // 
            // technicianNameColumn
            // 
            this.technicianNameColumn.HeaderText = "Name";
            this.technicianNameColumn.Name = "technicianNameColumn";
            this.technicianNameColumn.ReadOnly = true;
            this.technicianNameColumn.Width = 120;
            // 
            // technicianPhoneColumn
            // 
            this.technicianPhoneColumn.HeaderText = "Phone No.";
            this.technicianPhoneColumn.Name = "technicianPhoneColumn";
            this.technicianPhoneColumn.ReadOnly = true;
            this.technicianPhoneColumn.Width = 110;
            // 
            // InstallationProductStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 374);
            this.Controls.Add(this.tbScheduledOn);
            this.Controls.Add(this.lblScheduledOn);
            this.Controls.Add(this.tbInstalledOn);
            this.Controls.Add(this.lblInstalledOn);
            this.Controls.Add(this.dgvInstallationProduct);
            this.Controls.Add(this.lblTechnician);
            this.Controls.Add(this.lblProductsToInstall);
            this.Controls.Add(this.dgvTechnicians);
            this.Controls.Add(this.lblHeader);
            this.Name = "InstallationProductStatusForm";
            this.Text = "InstallationProductStatusForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechnicians)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstallationProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridView dgvTechnicians;
        private System.Windows.Forms.Label lblProductsToInstall;
        private System.Windows.Forms.Label lblTechnician;
        private System.Windows.Forms.DataGridView dgvInstallationProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox tbScheduledOn;
        private System.Windows.Forms.Label lblScheduledOn;
        private System.Windows.Forms.TextBox tbInstalledOn;
        private System.Windows.Forms.Label lblInstalledOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn technicianNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn technicianPhoneColumn;
    }
}
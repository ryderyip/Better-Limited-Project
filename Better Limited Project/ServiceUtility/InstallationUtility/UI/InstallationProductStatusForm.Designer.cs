
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
            this.dgvInstallationProduct = new System.Windows.Forms.DataGridView();
            this.lblHeader = new System.Windows.Forms.Label();
            this.dgvTechnicians = new System.Windows.Forms.DataGridView();
            this.lblProductsToInstall = new System.Windows.Forms.Label();
            this.lblTechnician = new System.Windows.Forms.Label();
            this.productNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductsQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduledOnColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.installedOnColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.technicianNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.technicianPhoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstallationProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechnicians)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInstallationProduct
            // 
            this.dgvInstallationProduct.AllowUserToAddRows = false;
            this.dgvInstallationProduct.AllowUserToDeleteRows = false;
            this.dgvInstallationProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstallationProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameColumn,
            this.dgvProductsQuantity,
            this.scheduledOnColumn,
            this.installedOnColumn});
            this.dgvInstallationProduct.Location = new System.Drawing.Point(26, 130);
            this.dgvInstallationProduct.Name = "dgvInstallationProduct";
            this.dgvInstallationProduct.ReadOnly = true;
            this.dgvInstallationProduct.Size = new System.Drawing.Size(514, 139);
            this.dgvInstallationProduct.TabIndex = 110;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHeader.Location = new System.Drawing.Point(174, 29);
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
            this.dgvTechnicians.Location = new System.Drawing.Point(112, 334);
            this.dgvTechnicians.Name = "dgvTechnicians";
            this.dgvTechnicians.ReadOnly = true;
            this.dgvTechnicians.Size = new System.Drawing.Size(343, 112);
            this.dgvTechnicians.TabIndex = 122;
            // 
            // lblProductsToInstall
            // 
            this.lblProductsToInstall.AutoSize = true;
            this.lblProductsToInstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblProductsToInstall.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblProductsToInstall.Location = new System.Drawing.Point(206, 89);
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
            this.lblTechnician.Location = new System.Drawing.Point(229, 299);
            this.lblTechnician.Name = "lblTechnician";
            this.lblTechnician.Size = new System.Drawing.Size(104, 20);
            this.lblTechnician.TabIndex = 124;
            this.lblTechnician.Text = "Technicians";
            // 
            // productNameColumn
            // 
            this.productNameColumn.HeaderText = "Product";
            this.productNameColumn.Name = "productNameColumn";
            this.productNameColumn.ReadOnly = true;
            this.productNameColumn.Width = 180;
            // 
            // dgvProductsQuantity
            // 
            this.dgvProductsQuantity.HeaderText = "Qty";
            this.dgvProductsQuantity.Name = "dgvProductsQuantity";
            this.dgvProductsQuantity.ReadOnly = true;
            this.dgvProductsQuantity.Width = 50;
            // 
            // scheduledOnColumn
            // 
            this.scheduledOnColumn.HeaderText = "Scheduled On";
            this.scheduledOnColumn.Name = "scheduledOnColumn";
            this.scheduledOnColumn.ReadOnly = true;
            this.scheduledOnColumn.Width = 120;
            // 
            // installedOnColumn
            // 
            this.installedOnColumn.HeaderText = "Installed On";
            this.installedOnColumn.Name = "installedOnColumn";
            this.installedOnColumn.ReadOnly = true;
            this.installedOnColumn.Width = 120;
            // 
            // technicianNameColumn
            // 
            this.technicianNameColumn.HeaderText = "Technician Name";
            this.technicianNameColumn.Name = "technicianNameColumn";
            this.technicianNameColumn.ReadOnly = true;
            this.technicianNameColumn.Width = 150;
            // 
            // technicianPhoneColumn
            // 
            this.technicianPhoneColumn.HeaderText = "Technician Phone No.";
            this.technicianPhoneColumn.Name = "technicianPhoneColumn";
            this.technicianPhoneColumn.ReadOnly = true;
            this.technicianPhoneColumn.Width = 150;
            // 
            // InstallationProductStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 478);
            this.Controls.Add(this.lblTechnician);
            this.Controls.Add(this.lblProductsToInstall);
            this.Controls.Add(this.dgvTechnicians);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.dgvInstallationProduct);
            this.Name = "InstallationProductStatusForm";
            this.Text = "InstallationProductStatusForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstallationProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechnicians)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInstallationProduct;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridView dgvTechnicians;
        private System.Windows.Forms.Label lblProductsToInstall;
        private System.Windows.Forms.Label lblTechnician;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductsQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduledOnColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn installedOnColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn technicianNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn technicianPhoneColumn;
    }
}
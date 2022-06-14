
namespace Better_Limited_Project.ServiceUtility.InstallationUtility.UI
{
    partial class InstallationDetailsForm
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
            this.tbScheduledOn = new System.Windows.Forms.TextBox();
            this.lblScheduledOn = new System.Windows.Forms.Label();
            this.tbInstalledOn = new System.Windows.Forms.TextBox();
            this.lblInstalledOn = new System.Windows.Forms.Label();
            this.dgvInstallationProduct = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTechnician = new System.Windows.Forms.Label();
            this.lblProductsToInstall = new System.Windows.Forms.Label();
            this.dgvTechnicians = new System.Windows.Forms.DataGridView();
            this.technicianNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.technicianPhoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSetAsInstalled = new System.Windows.Forms.Button();
            this.btnViewSalesOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstallationProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechnicians)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHeader.Location = new System.Drawing.Point(180, 22);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(276, 29);
            this.lblHeader.TabIndex = 129;
            this.lblHeader.Text = "Installation Information";
            // 
            // tbScheduledOn
            // 
            this.tbScheduledOn.Location = new System.Drawing.Point(26, 89);
            this.tbScheduledOn.Name = "tbScheduledOn";
            this.tbScheduledOn.ReadOnly = true;
            this.tbScheduledOn.Size = new System.Drawing.Size(194, 20);
            this.tbScheduledOn.TabIndex = 138;
            // 
            // lblScheduledOn
            // 
            this.lblScheduledOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblScheduledOn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblScheduledOn.Location = new System.Drawing.Point(23, 71);
            this.lblScheduledOn.Name = "lblScheduledOn";
            this.lblScheduledOn.Size = new System.Drawing.Size(88, 15);
            this.lblScheduledOn.TabIndex = 137;
            this.lblScheduledOn.Text = "Scheduled On";
            // 
            // tbInstalledOn
            // 
            this.tbInstalledOn.Location = new System.Drawing.Point(337, 89);
            this.tbInstalledOn.Name = "tbInstalledOn";
            this.tbInstalledOn.ReadOnly = true;
            this.tbInstalledOn.Size = new System.Drawing.Size(194, 20);
            this.tbInstalledOn.TabIndex = 136;
            // 
            // lblInstalledOn
            // 
            this.lblInstalledOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblInstalledOn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblInstalledOn.Location = new System.Drawing.Point(334, 71);
            this.lblInstalledOn.Name = "lblInstalledOn";
            this.lblInstalledOn.Size = new System.Drawing.Size(75, 15);
            this.lblInstalledOn.TabIndex = 135;
            this.lblInstalledOn.Text = "Installed On";
            // 
            // dgvInstallationProduct
            // 
            this.dgvInstallationProduct.AllowUserToAddRows = false;
            this.dgvInstallationProduct.AllowUserToDeleteRows = false;
            this.dgvInstallationProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstallationProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvInstallationProduct.Location = new System.Drawing.Point(26, 169);
            this.dgvInstallationProduct.Name = "dgvInstallationProduct";
            this.dgvInstallationProduct.ReadOnly = true;
            this.dgvInstallationProduct.Size = new System.Drawing.Size(273, 177);
            this.dgvInstallationProduct.TabIndex = 134;
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
            // lblTechnician
            // 
            this.lblTechnician.AutoSize = true;
            this.lblTechnician.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTechnician.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTechnician.Location = new System.Drawing.Point(416, 135);
            this.lblTechnician.Name = "lblTechnician";
            this.lblTechnician.Size = new System.Drawing.Size(104, 20);
            this.lblTechnician.TabIndex = 133;
            this.lblTechnician.Text = "Technicians";
            // 
            // lblProductsToInstall
            // 
            this.lblProductsToInstall.AutoSize = true;
            this.lblProductsToInstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblProductsToInstall.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblProductsToInstall.Location = new System.Drawing.Point(84, 135);
            this.lblProductsToInstall.Name = "lblProductsToInstall";
            this.lblProductsToInstall.Size = new System.Drawing.Size(155, 20);
            this.lblProductsToInstall.TabIndex = 132;
            this.lblProductsToInstall.Text = "Products to Install";
            // 
            // dgvTechnicians
            // 
            this.dgvTechnicians.AllowUserToAddRows = false;
            this.dgvTechnicians.AllowUserToDeleteRows = false;
            this.dgvTechnicians.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTechnicians.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.technicianNameColumn,
            this.technicianPhoneColumn});
            this.dgvTechnicians.Location = new System.Drawing.Point(337, 169);
            this.dgvTechnicians.Name = "dgvTechnicians";
            this.dgvTechnicians.ReadOnly = true;
            this.dgvTechnicians.Size = new System.Drawing.Size(273, 177);
            this.dgvTechnicians.TabIndex = 131;
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
            // btnSetAsInstalled
            // 
            this.btnSetAsInstalled.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSetAsInstalled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSetAsInstalled.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSetAsInstalled.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSetAsInstalled.Location = new System.Drawing.Point(26, 371);
            this.btnSetAsInstalled.Name = "btnSetAsInstalled";
            this.btnSetAsInstalled.Size = new System.Drawing.Size(185, 54);
            this.btnSetAsInstalled.TabIndex = 139;
            this.btnSetAsInstalled.Text = "Set as Installed";
            this.btnSetAsInstalled.UseVisualStyleBackColor = false;
            this.btnSetAsInstalled.Click += new System.EventHandler(this.btnSetAsInstalled_Click);
            // 
            // btnViewSalesOrder
            // 
            this.btnViewSalesOrder.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnViewSalesOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewSalesOrder.ForeColor = System.Drawing.SystemColors.Window;
            this.btnViewSalesOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnViewSalesOrder.Location = new System.Drawing.Point(425, 371);
            this.btnViewSalesOrder.Name = "btnViewSalesOrder";
            this.btnViewSalesOrder.Size = new System.Drawing.Size(185, 54);
            this.btnViewSalesOrder.TabIndex = 140;
            this.btnViewSalesOrder.Text = "View Sales Order";
            this.btnViewSalesOrder.UseVisualStyleBackColor = false;
            this.btnViewSalesOrder.Click += new System.EventHandler(this.btnViewSalesOrder_Click);
            // 
            // InstallationDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 450);
            this.Controls.Add(this.btnViewSalesOrder);
            this.Controls.Add(this.btnSetAsInstalled);
            this.Controls.Add(this.tbScheduledOn);
            this.Controls.Add(this.lblScheduledOn);
            this.Controls.Add(this.tbInstalledOn);
            this.Controls.Add(this.lblInstalledOn);
            this.Controls.Add(this.dgvInstallationProduct);
            this.Controls.Add(this.lblTechnician);
            this.Controls.Add(this.lblProductsToInstall);
            this.Controls.Add(this.dgvTechnicians);
            this.Controls.Add(this.lblHeader);
            this.Name = "InstallationDetailsForm";
            this.Text = "InstallationDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstallationProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechnicians)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox tbScheduledOn;
        private System.Windows.Forms.Label lblScheduledOn;
        private System.Windows.Forms.TextBox tbInstalledOn;
        private System.Windows.Forms.Label lblInstalledOn;
        private System.Windows.Forms.DataGridView dgvInstallationProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label lblTechnician;
        private System.Windows.Forms.Label lblProductsToInstall;
        private System.Windows.Forms.DataGridView dgvTechnicians;
        private System.Windows.Forms.DataGridViewTextBoxColumn technicianNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn technicianPhoneColumn;
        private System.Windows.Forms.Button btnSetAsInstalled;
        private System.Windows.Forms.Button btnViewSalesOrder;
    }
}
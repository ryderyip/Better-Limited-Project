
namespace Better_Limited_Project.ServiceUtility.InstallationUtility.UI
{
    partial class InstallationRequestDetailsForm
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
            this.lblProductsToInstall = new System.Windows.Forms.Label();
            this.tbCreatedOn = new System.Windows.Forms.TextBox();
            this.lblCreatedOn = new System.Windows.Forms.Label();
            this.tbOrderNumber = new System.Windows.Forms.TextBox();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.btnArrangeInstallation = new System.Windows.Forms.Button();
            this.tbArrangedOn = new System.Windows.Forms.TextBox();
            this.lblArrangedOn = new System.Windows.Forms.Label();
            this.tbArrangedByStaffName = new System.Windows.Forms.TextBox();
            this.lblArrangedByStaffName = new System.Windows.Forms.Label();
            this.productNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductsQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnViewSalesOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstallationProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInstallationProduct
            // 
            this.dgvInstallationProduct.AllowUserToAddRows = false;
            this.dgvInstallationProduct.AllowUserToDeleteRows = false;
            this.dgvInstallationProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstallationProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameColumn,
            this.dgvProductsQuantity});
            this.dgvInstallationProduct.Location = new System.Drawing.Point(329, 119);
            this.dgvInstallationProduct.Name = "dgvInstallationProduct";
            this.dgvInstallationProduct.ReadOnly = true;
            this.dgvInstallationProduct.Size = new System.Drawing.Size(273, 177);
            this.dgvInstallationProduct.TabIndex = 111;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHeader.Location = new System.Drawing.Point(130, 25);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(380, 29);
            this.lblHeader.TabIndex = 122;
            this.lblHeader.Text = "Installation Request Information";
            // 
            // lblProductsToInstall
            // 
            this.lblProductsToInstall.AutoSize = true;
            this.lblProductsToInstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblProductsToInstall.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblProductsToInstall.Location = new System.Drawing.Point(380, 82);
            this.lblProductsToInstall.Name = "lblProductsToInstall";
            this.lblProductsToInstall.Size = new System.Drawing.Size(155, 20);
            this.lblProductsToInstall.TabIndex = 124;
            this.lblProductsToInstall.Text = "Products to Install";
            // 
            // tbCreatedOn
            // 
            this.tbCreatedOn.Location = new System.Drawing.Point(158, 168);
            this.tbCreatedOn.Name = "tbCreatedOn";
            this.tbCreatedOn.ReadOnly = true;
            this.tbCreatedOn.Size = new System.Drawing.Size(127, 20);
            this.tbCreatedOn.TabIndex = 128;
            this.tbCreatedOn.Text = "-";
            // 
            // lblCreatedOn
            // 
            this.lblCreatedOn.AutoSize = true;
            this.lblCreatedOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblCreatedOn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCreatedOn.Location = new System.Drawing.Point(38, 169);
            this.lblCreatedOn.Name = "lblCreatedOn";
            this.lblCreatedOn.Size = new System.Drawing.Size(79, 16);
            this.lblCreatedOn.TabIndex = 127;
            this.lblCreatedOn.Text = "Created On:";
            // 
            // tbOrderNumber
            // 
            this.tbOrderNumber.Location = new System.Drawing.Point(158, 119);
            this.tbOrderNumber.Name = "tbOrderNumber";
            this.tbOrderNumber.ReadOnly = true;
            this.tbOrderNumber.Size = new System.Drawing.Size(127, 20);
            this.tbOrderNumber.TabIndex = 126;
            this.tbOrderNumber.Text = "-";
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblOrderNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblOrderNumber.Location = new System.Drawing.Point(38, 120);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(96, 16);
            this.lblOrderNumber.TabIndex = 125;
            this.lblOrderNumber.Text = "Order Number:";
            // 
            // btnArrangeInstallation
            // 
            this.btnArrangeInstallation.BackColor = System.Drawing.Color.DarkOrange;
            this.btnArrangeInstallation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnArrangeInstallation.ForeColor = System.Drawing.SystemColors.Window;
            this.btnArrangeInstallation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnArrangeInstallation.Location = new System.Drawing.Point(41, 327);
            this.btnArrangeInstallation.Name = "btnArrangeInstallation";
            this.btnArrangeInstallation.Size = new System.Drawing.Size(185, 54);
            this.btnArrangeInstallation.TabIndex = 129;
            this.btnArrangeInstallation.Text = "Arrange Installation";
            this.btnArrangeInstallation.UseVisualStyleBackColor = false;
            this.btnArrangeInstallation.Click += new System.EventHandler(this.btnArrangeInstallation_Click);
            // 
            // tbArrangedOn
            // 
            this.tbArrangedOn.Location = new System.Drawing.Point(158, 216);
            this.tbArrangedOn.Name = "tbArrangedOn";
            this.tbArrangedOn.ReadOnly = true;
            this.tbArrangedOn.Size = new System.Drawing.Size(127, 20);
            this.tbArrangedOn.TabIndex = 131;
            this.tbArrangedOn.Text = "-";
            // 
            // lblArrangedOn
            // 
            this.lblArrangedOn.AutoSize = true;
            this.lblArrangedOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblArrangedOn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblArrangedOn.Location = new System.Drawing.Point(38, 217);
            this.lblArrangedOn.Name = "lblArrangedOn";
            this.lblArrangedOn.Size = new System.Drawing.Size(87, 16);
            this.lblArrangedOn.TabIndex = 130;
            this.lblArrangedOn.Text = "Arranged On:";
            // 
            // tbArrangedByStaffName
            // 
            this.tbArrangedByStaffName.Location = new System.Drawing.Point(158, 267);
            this.tbArrangedByStaffName.Name = "tbArrangedByStaffName";
            this.tbArrangedByStaffName.ReadOnly = true;
            this.tbArrangedByStaffName.Size = new System.Drawing.Size(127, 20);
            this.tbArrangedByStaffName.TabIndex = 133;
            this.tbArrangedByStaffName.Text = "-";
            // 
            // lblArrangedByStaffName
            // 
            this.lblArrangedByStaffName.AutoSize = true;
            this.lblArrangedByStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblArrangedByStaffName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblArrangedByStaffName.Location = new System.Drawing.Point(38, 268);
            this.lblArrangedByStaffName.Name = "lblArrangedByStaffName";
            this.lblArrangedByStaffName.Size = new System.Drawing.Size(114, 16);
            this.lblArrangedByStaffName.TabIndex = 132;
            this.lblArrangedByStaffName.Text = "Arranged by Staff:";
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
            // btnViewSalesOrder
            // 
            this.btnViewSalesOrder.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnViewSalesOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewSalesOrder.ForeColor = System.Drawing.SystemColors.Window;
            this.btnViewSalesOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnViewSalesOrder.Location = new System.Drawing.Point(417, 327);
            this.btnViewSalesOrder.Name = "btnViewSalesOrder";
            this.btnViewSalesOrder.Size = new System.Drawing.Size(185, 54);
            this.btnViewSalesOrder.TabIndex = 134;
            this.btnViewSalesOrder.Text = "View Sales Order";
            this.btnViewSalesOrder.UseVisualStyleBackColor = false;
            this.btnViewSalesOrder.Click += new System.EventHandler(this.btnViewSalesOrder_Click);
            // 
            // InstallationRequestDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 409);
            this.Controls.Add(this.btnViewSalesOrder);
            this.Controls.Add(this.tbArrangedByStaffName);
            this.Controls.Add(this.lblArrangedByStaffName);
            this.Controls.Add(this.tbArrangedOn);
            this.Controls.Add(this.lblArrangedOn);
            this.Controls.Add(this.btnArrangeInstallation);
            this.Controls.Add(this.tbCreatedOn);
            this.Controls.Add(this.lblCreatedOn);
            this.Controls.Add(this.tbOrderNumber);
            this.Controls.Add(this.lblOrderNumber);
            this.Controls.Add(this.lblProductsToInstall);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.dgvInstallationProduct);
            this.Name = "InstallationRequestDetailsForm";
            this.Text = "InstallationRequestDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstallationProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInstallationProduct;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblProductsToInstall;
        private System.Windows.Forms.TextBox tbCreatedOn;
        private System.Windows.Forms.Label lblCreatedOn;
        private System.Windows.Forms.TextBox tbOrderNumber;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.Button btnArrangeInstallation;
        private System.Windows.Forms.TextBox tbArrangedOn;
        private System.Windows.Forms.Label lblArrangedOn;
        private System.Windows.Forms.TextBox tbArrangedByStaffName;
        private System.Windows.Forms.Label lblArrangedByStaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductsQuantity;
        private System.Windows.Forms.Button btnViewSalesOrder;
    }
}
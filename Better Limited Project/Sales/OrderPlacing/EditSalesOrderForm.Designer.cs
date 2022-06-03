
namespace Better_Limited_Project.Sales.OrderPlacing
{
    partial class EditSalesOrderForm
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
            this.btnManageInstallation = new System.Windows.Forms.Button();
            this.btnManageDelivery = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(84, 29);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(119, 25);
            this.lblHeader.TabIndex = 127;
            this.lblHeader.Text = "Edit Order";
            // 
            // btnManageInstallation
            // 
            this.btnManageInstallation.BackColor = System.Drawing.Color.SeaGreen;
            this.btnManageInstallation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageInstallation.ForeColor = System.Drawing.SystemColors.Window;
            this.btnManageInstallation.Location = new System.Drawing.Point(44, 200);
            this.btnManageInstallation.Name = "btnManageInstallation";
            this.btnManageInstallation.Size = new System.Drawing.Size(198, 47);
            this.btnManageInstallation.TabIndex = 145;
            this.btnManageInstallation.Text = "Manage Installation";
            this.btnManageInstallation.UseVisualStyleBackColor = false;
            // 
            // btnManageDelivery
            // 
            this.btnManageDelivery.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnManageDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageDelivery.ForeColor = System.Drawing.SystemColors.Window;
            this.btnManageDelivery.Location = new System.Drawing.Point(44, 137);
            this.btnManageDelivery.Name = "btnManageDelivery";
            this.btnManageDelivery.Size = new System.Drawing.Size(198, 47);
            this.btnManageDelivery.TabIndex = 144;
            this.btnManageDelivery.Text = "Manage Delivery";
            this.btnManageDelivery.UseVisualStyleBackColor = false;
            this.btnManageDelivery.Click += new System.EventHandler(this.btnManageDelivery_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAddProduct.Location = new System.Drawing.Point(44, 74);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(198, 47);
            this.btnAddProduct.TabIndex = 143;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // EditSalesOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 286);
            this.Controls.Add(this.btnManageInstallation);
            this.Controls.Add(this.btnManageDelivery);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.lblHeader);
            this.Name = "EditSalesOrderForm";
            this.Text = "EditSalesOrderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnManageInstallation;
        private System.Windows.Forms.Button btnManageDelivery;
        private System.Windows.Forms.Button btnAddProduct;
    }
}
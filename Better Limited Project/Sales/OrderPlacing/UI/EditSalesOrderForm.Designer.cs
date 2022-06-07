
namespace Better_Limited_Project.Sales.OrderPlacing.UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSalesOrderForm));
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnManageInstallation = new System.Windows.Forms.Button();
            this.btnManageDelivery = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            resources.ApplyResources(this.lblHeader, "lblHeader");
            this.lblHeader.Name = "lblHeader";
            // 
            // btnManageInstallation
            // 
            this.btnManageInstallation.BackColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.btnManageInstallation, "btnManageInstallation");
            this.btnManageInstallation.ForeColor = System.Drawing.SystemColors.Window;
            this.btnManageInstallation.Name = "btnManageInstallation";
            this.btnManageInstallation.UseVisualStyleBackColor = false;
            // 
            // btnManageDelivery
            // 
            this.btnManageDelivery.BackColor = System.Drawing.SystemColors.MenuHighlight;
            resources.ApplyResources(this.btnManageDelivery, "btnManageDelivery");
            this.btnManageDelivery.ForeColor = System.Drawing.SystemColors.Window;
            this.btnManageDelivery.Name = "btnManageDelivery";
            this.btnManageDelivery.UseVisualStyleBackColor = false;
            this.btnManageDelivery.Click += new System.EventHandler(this.btnManageDelivery_Click);
            // 
            // EditSalesOrderForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnManageInstallation);
            this.Controls.Add(this.btnManageDelivery);
            this.Controls.Add(this.lblHeader);
            this.Name = "EditSalesOrderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnManageInstallation;
        private System.Windows.Forms.Button btnManageDelivery;
    }
}
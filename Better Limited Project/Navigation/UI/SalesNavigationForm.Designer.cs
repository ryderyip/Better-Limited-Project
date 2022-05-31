using System.ComponentModel;

namespace Better_Limited_Project.Navigation.UI
{
    partial class SalesNavigationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesNavigationForm));
            this.btnSalesOrder = new System.Windows.Forms.Button();
            this.btnProductList = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.lblLoggedInAs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalesOrder
            // 
            resources.ApplyResources(this.btnSalesOrder, "btnSalesOrder");
            this.btnSalesOrder.Name = "btnSalesOrder";
            this.btnSalesOrder.UseVisualStyleBackColor = true;
            this.btnSalesOrder.Click += new System.EventHandler(this.btnSalesOrder_Click);
            // 
            // btnProductList
            // 
            resources.ApplyResources(this.btnProductList, "btnProductList");
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.UseVisualStyleBackColor = true;
            this.btnProductList.Click += new System.EventHandler(this.btnProductList_Click);
            // 
            // btnSettings
            // 
            resources.ApplyResources(this.btnSettings, "btnSettings");
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnPlaceOrder
            // 
            resources.ApplyResources(this.btnPlaceOrder, "btnPlaceOrder");
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnProfile
            // 
            resources.ApplyResources(this.btnProfile, "btnProfile");
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // lblLoggedInAs
            // 
            resources.ApplyResources(this.lblLoggedInAs, "lblLoggedInAs");
            this.lblLoggedInAs.Name = "lblLoggedInAs";
            // 
            // SalesNavigationForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblLoggedInAs);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnProductList);
            this.Controls.Add(this.btnSalesOrder);
            this.Name = "SalesNavigationForm";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblLoggedInAs;

        private System.Windows.Forms.Button btnProfile;

        private System.Windows.Forms.Button btnPlaceOrder;

        private System.Windows.Forms.Button btnProductList;
        private System.Windows.Forms.Button btnSettings;

        private System.Windows.Forms.Button btnSalesOrder;

        #endregion
    }
}
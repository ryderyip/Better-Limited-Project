using System.ComponentModel;

namespace Better_Limited_Project.Navigation.UI
{
    partial class AccountingManagerNavigationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountingManagerNavigationForm));
            this.btnGoodsReturned = new System.Windows.Forms.Button();
            this.btnGoodsReceived = new System.Windows.Forms.Button();
            this.lblLoggedInAs = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnPurchaseOrders = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnSalesReport = new System.Windows.Forms.Button();
            this.btnSalesOrder = new System.Windows.Forms.Button();
            this.btnProductList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGoodsReturned
            // 
            resources.ApplyResources(this.btnGoodsReturned, "btnGoodsReturned");
            this.btnGoodsReturned.Name = "btnGoodsReturned";
            this.btnGoodsReturned.UseVisualStyleBackColor = true;
            this.btnGoodsReturned.Click += new System.EventHandler(this.btnGoodsReturned_Click);
            // 
            // btnGoodsReceived
            // 
            resources.ApplyResources(this.btnGoodsReceived, "btnGoodsReceived");
            this.btnGoodsReceived.Name = "btnGoodsReceived";
            this.btnGoodsReceived.UseVisualStyleBackColor = true;
            this.btnGoodsReceived.Click += new System.EventHandler(this.btnGoodsReceived_Click);
            // 
            // lblLoggedInAs
            // 
            resources.ApplyResources(this.lblLoggedInAs, "lblLoggedInAs");
            this.lblLoggedInAs.Name = "lblLoggedInAs";
            // 
            // btnProfile
            // 
            resources.ApplyResources(this.btnProfile, "btnProfile");
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnPurchaseOrders
            // 
            resources.ApplyResources(this.btnPurchaseOrders, "btnPurchaseOrders");
            this.btnPurchaseOrders.Name = "btnPurchaseOrders";
            this.btnPurchaseOrders.UseVisualStyleBackColor = true;
            this.btnPurchaseOrders.Click += new System.EventHandler(this.btnPurchaseOrders_Click);
            // 
            // btnSettings
            // 
            resources.ApplyResources(this.btnSettings, "btnSettings");
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnSalesReport
            // 
            resources.ApplyResources(this.btnSalesReport, "btnSalesReport");
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.UseVisualStyleBackColor = true;
            this.btnSalesReport.Click += new System.EventHandler(this.btnSalesReport_Click);
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
            // AccountingManagerNavigationForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnProductList);
            this.Controls.Add(this.btnGoodsReturned);
            this.Controls.Add(this.btnGoodsReceived);
            this.Controls.Add(this.lblLoggedInAs);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnPurchaseOrders);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnSalesReport);
            this.Controls.Add(this.btnSalesOrder);
            this.Name = "AccountingManagerNavigationForm";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnProductList;

        private System.Windows.Forms.Button btnGoodsReturned;
        private System.Windows.Forms.Button btnGoodsReceived;
        private System.Windows.Forms.Label lblLoggedInAs;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnPurchaseOrders;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnSalesReport;
        private System.Windows.Forms.Button btnSalesOrder;

        #endregion
    }
}
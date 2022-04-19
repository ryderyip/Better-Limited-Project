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
            this.btnGoodsReturned.Location = new System.Drawing.Point(48, 296);
            this.btnGoodsReturned.Name = "btnGoodsReturned";
            this.btnGoodsReturned.Size = new System.Drawing.Size(111, 34);
            this.btnGoodsReturned.TabIndex = 22;
            this.btnGoodsReturned.Text = "Goods Returned";
            this.btnGoodsReturned.UseVisualStyleBackColor = true;
            // 
            // btnGoodsReceived
            // 
            this.btnGoodsReceived.Location = new System.Drawing.Point(48, 256);
            this.btnGoodsReceived.Name = "btnGoodsReceived";
            this.btnGoodsReceived.Size = new System.Drawing.Size(111, 34);
            this.btnGoodsReceived.TabIndex = 21;
            this.btnGoodsReceived.Text = "Goods Received";
            this.btnGoodsReceived.UseVisualStyleBackColor = true;
            // 
            // lblLoggedInAs
            // 
            this.lblLoggedInAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblLoggedInAs.Location = new System.Drawing.Point(36, 17);
            this.lblLoggedInAs.Name = "lblLoggedInAs";
            this.lblLoggedInAs.Size = new System.Drawing.Size(135, 22);
            this.lblLoggedInAs.TabIndex = 20;
            this.lblLoggedInAs.Text = "Logged in as";
            this.lblLoggedInAs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(21, 51);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(164, 48);
            this.btnProfile.TabIndex = 19;
            this.btnProfile.Text = "(Name)";
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnPurchaseOrders
            // 
            this.btnPurchaseOrders.Location = new System.Drawing.Point(48, 136);
            this.btnPurchaseOrders.Name = "btnPurchaseOrders";
            this.btnPurchaseOrders.Size = new System.Drawing.Size(111, 34);
            this.btnPurchaseOrders.TabIndex = 18;
            this.btnPurchaseOrders.Text = "Purchase Orders";
            this.btnPurchaseOrders.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(48, 376);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(111, 34);
            this.btnSettings.TabIndex = 17;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.Location = new System.Drawing.Point(48, 216);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(111, 34);
            this.btnSalesReport.TabIndex = 16;
            this.btnSalesReport.Text = "Sales Report";
            this.btnSalesReport.UseVisualStyleBackColor = true;
            // 
            // btnSalesOrder
            // 
            this.btnSalesOrder.Location = new System.Drawing.Point(48, 176);
            this.btnSalesOrder.Name = "btnSalesOrder";
            this.btnSalesOrder.Size = new System.Drawing.Size(111, 34);
            this.btnSalesOrder.TabIndex = 15;
            this.btnSalesOrder.Text = "Sales Order";
            this.btnSalesOrder.UseVisualStyleBackColor = true;
            // 
            // btnProductList
            // 
            this.btnProductList.Location = new System.Drawing.Point(48, 336);
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.Size = new System.Drawing.Size(111, 34);
            this.btnProductList.TabIndex = 23;
            this.btnProductList.Text = "Product List";
            this.btnProductList.UseVisualStyleBackColor = true;
            // 
            // AccountingManagerNavigationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 450);
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
            this.Text = "AccountingManagerNavigationForm";
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
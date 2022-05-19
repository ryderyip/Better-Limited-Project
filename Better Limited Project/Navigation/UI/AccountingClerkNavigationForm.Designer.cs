namespace Better_Limited_Project.Navigation.UI
{
    partial class AccountingClerkNavigationForm
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
            this.lblLoggedInAs = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnPurchaseOrders = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnSalesReport = new System.Windows.Forms.Button();
            this.btnSalesOrder = new System.Windows.Forms.Button();
            this.btnGoodsReceived = new System.Windows.Forms.Button();
            this.btnGoodsReturned = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLoggedInAs
            // 
            this.lblLoggedInAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblLoggedInAs.Location = new System.Drawing.Point(27, 15);
            this.lblLoggedInAs.Name = "lblLoggedInAs";
            this.lblLoggedInAs.Size = new System.Drawing.Size(135, 22);
            this.lblLoggedInAs.TabIndex = 12;
            this.lblLoggedInAs.Text = "Logged in as";
            this.lblLoggedInAs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(12, 49);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(164, 48);
            this.btnProfile.TabIndex = 11;
            this.btnProfile.Text = "(Name)";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnPurchaseOrders
            // 
            this.btnPurchaseOrders.Location = new System.Drawing.Point(39, 134);
            this.btnPurchaseOrders.Name = "btnPurchaseOrders";
            this.btnPurchaseOrders.Size = new System.Drawing.Size(111, 34);
            this.btnPurchaseOrders.TabIndex = 10;
            this.btnPurchaseOrders.Text = "Purchase Orders";
            this.btnPurchaseOrders.UseVisualStyleBackColor = true;
            this.btnPurchaseOrders.Click += new System.EventHandler(this.btnPurchaseOrders_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(39, 334);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(111, 34);
            this.btnSettings.TabIndex = 9;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.Location = new System.Drawing.Point(39, 214);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(111, 34);
            this.btnSalesReport.TabIndex = 8;
            this.btnSalesReport.Text = "Sales Report";
            this.btnSalesReport.UseVisualStyleBackColor = true;
            this.btnSalesReport.Click += new System.EventHandler(this.btnSalesReport_Click);
            // 
            // btnSalesOrder
            // 
            this.btnSalesOrder.Location = new System.Drawing.Point(39, 174);
            this.btnSalesOrder.Name = "btnSalesOrder";
            this.btnSalesOrder.Size = new System.Drawing.Size(111, 34);
            this.btnSalesOrder.TabIndex = 7;
            this.btnSalesOrder.Text = "Sales Order";
            this.btnSalesOrder.UseVisualStyleBackColor = true;
            this.btnSalesOrder.Click += new System.EventHandler(this.btnSalesOrder_Click);
            // 
            // btnGoodsReceived
            // 
            this.btnGoodsReceived.Location = new System.Drawing.Point(39, 254);
            this.btnGoodsReceived.Name = "btnGoodsReceived";
            this.btnGoodsReceived.Size = new System.Drawing.Size(111, 34);
            this.btnGoodsReceived.TabIndex = 13;
            this.btnGoodsReceived.Text = "Goods Received";
            this.btnGoodsReceived.UseVisualStyleBackColor = true;
            this.btnGoodsReceived.Click += new System.EventHandler(this.btnGoodsReceived_Click);
            // 
            // btnGoodsReturned
            // 
            this.btnGoodsReturned.Location = new System.Drawing.Point(39, 294);
            this.btnGoodsReturned.Name = "btnGoodsReturned";
            this.btnGoodsReturned.Size = new System.Drawing.Size(111, 34);
            this.btnGoodsReturned.TabIndex = 14;
            this.btnGoodsReturned.Text = "Goods Returned";
            this.btnGoodsReturned.UseVisualStyleBackColor = true;
            this.btnGoodsReturned.Click += new System.EventHandler(this.btnGoodsReturned_Click);
            // 
            // AccountingClerkNavigationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 450);
            this.Controls.Add(this.btnGoodsReturned);
            this.Controls.Add(this.btnGoodsReceived);
            this.Controls.Add(this.lblLoggedInAs);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnPurchaseOrders);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnSalesReport);
            this.Controls.Add(this.btnSalesOrder);
            this.Name = "AccountingClerkNavigationForm";
            this.Text = "AccountingClerkNavigationForm";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnPurchaseOrders;

        private System.Windows.Forms.Button btnSalesReport;
        private System.Windows.Forms.Button btnGoodsReceived;
        private System.Windows.Forms.Button btnGoodsReturned;

        private System.Windows.Forms.Label lblLoggedInAs;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnSalesOrder;

        #endregion
    }
}
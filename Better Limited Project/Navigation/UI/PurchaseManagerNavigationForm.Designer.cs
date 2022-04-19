using System.ComponentModel;

namespace Better_Limited_Project.Navigation.UI
{
    partial class PurchaseManagerNavigationForm
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
            this.lblLoggedInAs = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnReorderRequests = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnPurchaseOrders = new System.Windows.Forms.Button();
            this.btnProductList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLoggedInAs
            // 
            this.lblLoggedInAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblLoggedInAs.Location = new System.Drawing.Point(31, 9);
            this.lblLoggedInAs.Name = "lblLoggedInAs";
            this.lblLoggedInAs.Size = new System.Drawing.Size(135, 22);
            this.lblLoggedInAs.TabIndex = 17;
            this.lblLoggedInAs.Text = "Logged in as";
            this.lblLoggedInAs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(16, 43);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(164, 48);
            this.btnProfile.TabIndex = 16;
            this.btnProfile.Text = "(Name)";
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnReorderRequests
            // 
            this.btnReorderRequests.Location = new System.Drawing.Point(43, 128);
            this.btnReorderRequests.Name = "btnReorderRequests";
            this.btnReorderRequests.Size = new System.Drawing.Size(111, 34);
            this.btnReorderRequests.TabIndex = 15;
            this.btnReorderRequests.Text = "Reorder Requests";
            this.btnReorderRequests.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(43, 248);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(111, 34);
            this.btnSettings.TabIndex = 14;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnPurchaseOrders
            // 
            this.btnPurchaseOrders.Location = new System.Drawing.Point(43, 168);
            this.btnPurchaseOrders.Name = "btnPurchaseOrders";
            this.btnPurchaseOrders.Size = new System.Drawing.Size(111, 34);
            this.btnPurchaseOrders.TabIndex = 13;
            this.btnPurchaseOrders.Text = "Purchase Orders";
            this.btnPurchaseOrders.UseVisualStyleBackColor = true;
            // 
            // btnProductList
            // 
            this.btnProductList.Location = new System.Drawing.Point(43, 208);
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.Size = new System.Drawing.Size(111, 34);
            this.btnProductList.TabIndex = 18;
            this.btnProductList.Text = "Product List";
            this.btnProductList.UseVisualStyleBackColor = true;
            // 
            // PurchaseManagerNavigationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 450);
            this.Controls.Add(this.btnProductList);
            this.Controls.Add(this.lblLoggedInAs);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnReorderRequests);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnPurchaseOrders);
            this.Name = "PurchaseManagerNavigationForm";
            this.Text = "PurchaseManagerNavigationForm";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblLoggedInAs;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnReorderRequests;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnPurchaseOrders;
        private System.Windows.Forms.Button btnProductList;

        #endregion
    }
}
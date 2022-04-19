using System.ComponentModel;

namespace Better_Limited_Project.Navigation.UI
{
    partial class InventoryClerkNavigationForm
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
            this.btnDeliveryRequests = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnGoodsReceived = new System.Windows.Forms.Button();
            this.btnGoodsReturned = new System.Windows.Forms.Button();
            this.btnReorderRequests = new System.Windows.Forms.Button();
            this.btnRestockRequests = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnDeliveryDuty = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLoggedInAs
            // 
            this.lblLoggedInAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblLoggedInAs.Location = new System.Drawing.Point(27, 16);
            this.lblLoggedInAs.Name = "lblLoggedInAs";
            this.lblLoggedInAs.Size = new System.Drawing.Size(135, 22);
            this.lblLoggedInAs.TabIndex = 17;
            this.lblLoggedInAs.Text = "Logged in as";
            this.lblLoggedInAs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(12, 50);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(164, 48);
            this.btnProfile.TabIndex = 16;
            this.btnProfile.Text = "(Name)";
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnDeliveryRequests
            // 
            this.btnDeliveryRequests.Location = new System.Drawing.Point(41, 120);
            this.btnDeliveryRequests.Name = "btnDeliveryRequests";
            this.btnDeliveryRequests.Size = new System.Drawing.Size(111, 34);
            this.btnDeliveryRequests.TabIndex = 15;
            this.btnDeliveryRequests.Text = "Delivery Requests";
            this.btnDeliveryRequests.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(41, 400);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(111, 34);
            this.btnSettings.TabIndex = 14;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnGoodsReceived
            // 
            this.btnGoodsReceived.Location = new System.Drawing.Point(41, 160);
            this.btnGoodsReceived.Name = "btnGoodsReceived";
            this.btnGoodsReceived.Size = new System.Drawing.Size(111, 34);
            this.btnGoodsReceived.TabIndex = 13;
            this.btnGoodsReceived.Text = "Goods Received";
            this.btnGoodsReceived.UseVisualStyleBackColor = true;
            // 
            // btnGoodsReturned
            // 
            this.btnGoodsReturned.Location = new System.Drawing.Point(41, 200);
            this.btnGoodsReturned.Name = "btnGoodsReturned";
            this.btnGoodsReturned.Size = new System.Drawing.Size(111, 34);
            this.btnGoodsReturned.TabIndex = 18;
            this.btnGoodsReturned.Text = "Goods Returned";
            this.btnGoodsReturned.UseVisualStyleBackColor = true;
            // 
            // btnReorderRequests
            // 
            this.btnReorderRequests.Location = new System.Drawing.Point(41, 240);
            this.btnReorderRequests.Name = "btnReorderRequests";
            this.btnReorderRequests.Size = new System.Drawing.Size(111, 34);
            this.btnReorderRequests.TabIndex = 19;
            this.btnReorderRequests.Text = "Reorder Requests";
            this.btnReorderRequests.UseVisualStyleBackColor = true;
            // 
            // btnRestockRequests
            // 
            this.btnRestockRequests.Location = new System.Drawing.Point(41, 280);
            this.btnRestockRequests.Name = "btnRestockRequests";
            this.btnRestockRequests.Size = new System.Drawing.Size(111, 34);
            this.btnRestockRequests.TabIndex = 20;
            this.btnRestockRequests.Text = "Restock Requests";
            this.btnRestockRequests.UseVisualStyleBackColor = true;
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(41, 320);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(111, 34);
            this.btnInventory.TabIndex = 21;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            // 
            // btnDeliveryDuty
            // 
            this.btnDeliveryDuty.Location = new System.Drawing.Point(41, 360);
            this.btnDeliveryDuty.Name = "btnDeliveryDuty";
            this.btnDeliveryDuty.Size = new System.Drawing.Size(111, 34);
            this.btnDeliveryDuty.TabIndex = 22;
            this.btnDeliveryDuty.Text = "Delivery Duty";
            this.btnDeliveryDuty.UseVisualStyleBackColor = true;
            // 
            // InventoryClerkNavigationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 450);
            this.Controls.Add(this.btnDeliveryDuty);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnRestockRequests);
            this.Controls.Add(this.btnReorderRequests);
            this.Controls.Add(this.btnGoodsReturned);
            this.Controls.Add(this.lblLoggedInAs);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnDeliveryRequests);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnGoodsReceived);
            this.Name = "InventoryClerkNavigationForm";
            this.Text = "InventoryClerkNavigationForm";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblLoggedInAs;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnDeliveryRequests;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnGoodsReceived;
        private System.Windows.Forms.Button btnGoodsReturned;
        private System.Windows.Forms.Button btnReorderRequests;
        private System.Windows.Forms.Button btnRestockRequests;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnDeliveryDuty;

        #endregion
    }
}
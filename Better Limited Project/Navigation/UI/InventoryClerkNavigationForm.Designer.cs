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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryClerkNavigationForm));
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
            // btnDeliveryRequests
            // 
            resources.ApplyResources(this.btnDeliveryRequests, "btnDeliveryRequests");
            this.btnDeliveryRequests.Name = "btnDeliveryRequests";
            this.btnDeliveryRequests.UseVisualStyleBackColor = true;
            this.btnDeliveryRequests.Click += new System.EventHandler(this.btnDeliveryRequests_Click);
            // 
            // btnSettings
            // 
            resources.ApplyResources(this.btnSettings, "btnSettings");
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnGoodsReceived
            // 
            resources.ApplyResources(this.btnGoodsReceived, "btnGoodsReceived");
            this.btnGoodsReceived.Name = "btnGoodsReceived";
            this.btnGoodsReceived.UseVisualStyleBackColor = true;
            this.btnGoodsReceived.Click += new System.EventHandler(this.btnGoodsReceived_Click);
            // 
            // btnGoodsReturned
            // 
            resources.ApplyResources(this.btnGoodsReturned, "btnGoodsReturned");
            this.btnGoodsReturned.Name = "btnGoodsReturned";
            this.btnGoodsReturned.UseVisualStyleBackColor = true;
            this.btnGoodsReturned.Click += new System.EventHandler(this.btnGoodsReturned_Click);
            // 
            // btnReorderRequests
            // 
            resources.ApplyResources(this.btnReorderRequests, "btnReorderRequests");
            this.btnReorderRequests.Name = "btnReorderRequests";
            this.btnReorderRequests.UseVisualStyleBackColor = true;
            this.btnReorderRequests.Click += new System.EventHandler(this.btnReorderRequests_Click);
            // 
            // btnRestockRequests
            // 
            resources.ApplyResources(this.btnRestockRequests, "btnRestockRequests");
            this.btnRestockRequests.Name = "btnRestockRequests";
            this.btnRestockRequests.UseVisualStyleBackColor = true;
            this.btnRestockRequests.Click += new System.EventHandler(this.btnRestockRequests_Click);
            // 
            // btnInventory
            // 
            resources.ApplyResources(this.btnInventory, "btnInventory");
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnDeliveryDuty
            // 
            resources.ApplyResources(this.btnDeliveryDuty, "btnDeliveryDuty");
            this.btnDeliveryDuty.Name = "btnDeliveryDuty";
            this.btnDeliveryDuty.UseVisualStyleBackColor = true;
            this.btnDeliveryDuty.Click += new System.EventHandler(this.btnDeliveryDuty_Click);
            // 
            // InventoryClerkNavigationForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
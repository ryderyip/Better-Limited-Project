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
            this.btnSalesOrder.Location = new System.Drawing.Point(39, 168);
            this.btnSalesOrder.Name = "btnSalesOrder";
            this.btnSalesOrder.Size = new System.Drawing.Size(111, 34);
            this.btnSalesOrder.TabIndex = 1;
            this.btnSalesOrder.Text = "Sales Order";
            this.btnSalesOrder.UseVisualStyleBackColor = true;
            this.btnSalesOrder.Click += new System.EventHandler(this.btnSalesOrder_Click);
            // 
            // btnProductList
            // 
            this.btnProductList.Location = new System.Drawing.Point(39, 208);
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.Size = new System.Drawing.Size(111, 34);
            this.btnProductList.TabIndex = 2;
            this.btnProductList.Text = "Product List";
            this.btnProductList.UseVisualStyleBackColor = true;
            this.btnProductList.Click += new System.EventHandler(this.btnProductList_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(39, 248);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(111, 34);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(39, 128);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(111, 34);
            this.btnPlaceOrder.TabIndex = 4;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(12, 43);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(164, 48);
            this.btnProfile.TabIndex = 5;
            this.btnProfile.Text = "(Name)";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // lblLoggedInAs
            // 
            this.lblLoggedInAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblLoggedInAs.Location = new System.Drawing.Point(27, 9);
            this.lblLoggedInAs.Name = "lblLoggedInAs";
            this.lblLoggedInAs.Size = new System.Drawing.Size(135, 22);
            this.lblLoggedInAs.TabIndex = 6;
            this.lblLoggedInAs.Text = "Logged in as";
            this.lblLoggedInAs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SalesNavigationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(188, 450);
            this.Controls.Add(this.lblLoggedInAs);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnProductList);
            this.Controls.Add(this.btnSalesOrder);
            this.Name = "SalesNavigationForm";
            this.Text = "SalesNavigationForm";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblLoggedInAs;

        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button btnPlaceOrder;

        private System.Windows.Forms.Button btnProductList;
        private System.Windows.Forms.Button btnSettings;

        private System.Windows.Forms.Button btnSalesOrder;

        private System.Windows.Forms.Button button2;

        #endregion
    }
}
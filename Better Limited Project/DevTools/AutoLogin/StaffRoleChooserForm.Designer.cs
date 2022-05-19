using System.ComponentModel;

namespace Better_Limited_Project.DevTools.AutoLogin
{
    partial class StaffRoleChooserForm
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
            this.btnSalesRep = new System.Windows.Forms.Button();
            this.btnSalesManager = new System.Windows.Forms.Button();
            this.btnPurchaseClerk = new System.Windows.Forms.Button();
            this.btnPurchaseManager = new System.Windows.Forms.Button();
            this.btnAccountingManager = new System.Windows.Forms.Button();
            this.btnAccountingClerk = new System.Windows.Forms.Button();
            this.btnReceivingClerk = new System.Windows.Forms.Button();
            this.btnInventoryClerk = new System.Windows.Forms.Button();
            this.btnTechManager = new System.Windows.Forms.Button();
            this.btnTechClerk = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalesRep
            // 
            this.btnSalesRep.Location = new System.Drawing.Point(12, 12);
            this.btnSalesRep.Name = "btnSalesRep";
            this.btnSalesRep.Size = new System.Drawing.Size(235, 55);
            this.btnSalesRep.TabIndex = 0;
            this.btnSalesRep.Text = "Sales Rep";
            this.btnSalesRep.UseVisualStyleBackColor = true;
            this.btnSalesRep.Click += new System.EventHandler(this.BtnButtonClicked);
            // 
            // btnSalesManager
            // 
            this.btnSalesManager.Location = new System.Drawing.Point(270, 12);
            this.btnSalesManager.Name = "btnSalesManager";
            this.btnSalesManager.Size = new System.Drawing.Size(235, 55);
            this.btnSalesManager.TabIndex = 1;
            this.btnSalesManager.Text = "Sales Manager";
            this.btnSalesManager.UseVisualStyleBackColor = true;
            this.btnSalesManager.Click += new System.EventHandler(this.BtnButtonClicked);
            // 
            // btnPurchaseClerk
            // 
            this.btnPurchaseClerk.Location = new System.Drawing.Point(12, 73);
            this.btnPurchaseClerk.Name = "btnPurchaseClerk";
            this.btnPurchaseClerk.Size = new System.Drawing.Size(235, 55);
            this.btnPurchaseClerk.TabIndex = 2;
            this.btnPurchaseClerk.Text = "Purchase Clerk";
            this.btnPurchaseClerk.UseVisualStyleBackColor = true;
            this.btnPurchaseClerk.Click += new System.EventHandler(this.BtnButtonClicked);
            // 
            // btnPurchaseManager
            // 
            this.btnPurchaseManager.Location = new System.Drawing.Point(270, 73);
            this.btnPurchaseManager.Name = "btnPurchaseManager";
            this.btnPurchaseManager.Size = new System.Drawing.Size(235, 55);
            this.btnPurchaseManager.TabIndex = 3;
            this.btnPurchaseManager.Text = "Purchase Manager";
            this.btnPurchaseManager.UseVisualStyleBackColor = true;
            this.btnPurchaseManager.Click += new System.EventHandler(this.BtnButtonClicked);
            // 
            // btnAccountingManager
            // 
            this.btnAccountingManager.Location = new System.Drawing.Point(270, 134);
            this.btnAccountingManager.Name = "btnAccountingManager";
            this.btnAccountingManager.Size = new System.Drawing.Size(235, 55);
            this.btnAccountingManager.TabIndex = 5;
            this.btnAccountingManager.Text = "Accounting Manager";
            this.btnAccountingManager.UseVisualStyleBackColor = true;
            this.btnAccountingManager.Click += new System.EventHandler(this.BtnButtonClicked);
            // 
            // btnAccountingClerk
            // 
            this.btnAccountingClerk.Location = new System.Drawing.Point(12, 134);
            this.btnAccountingClerk.Name = "btnAccountingClerk";
            this.btnAccountingClerk.Size = new System.Drawing.Size(235, 55);
            this.btnAccountingClerk.TabIndex = 4;
            this.btnAccountingClerk.Text = "Accounting Clerk";
            this.btnAccountingClerk.UseVisualStyleBackColor = true;
            this.btnAccountingClerk.Click += new System.EventHandler(this.BtnButtonClicked);
            // 
            // btnReceivingClerk
            // 
            this.btnReceivingClerk.Location = new System.Drawing.Point(270, 195);
            this.btnReceivingClerk.Name = "btnReceivingClerk";
            this.btnReceivingClerk.Size = new System.Drawing.Size(235, 55);
            this.btnReceivingClerk.TabIndex = 7;
            this.btnReceivingClerk.Text = "Receiving Clerk";
            this.btnReceivingClerk.UseVisualStyleBackColor = true;
            this.btnReceivingClerk.Click += new System.EventHandler(this.BtnButtonClicked);
            // 
            // btnInventoryClerk
            // 
            this.btnInventoryClerk.Location = new System.Drawing.Point(12, 195);
            this.btnInventoryClerk.Name = "btnInventoryClerk";
            this.btnInventoryClerk.Size = new System.Drawing.Size(235, 55);
            this.btnInventoryClerk.TabIndex = 6;
            this.btnInventoryClerk.Text = "Inventory Clerk";
            this.btnInventoryClerk.UseVisualStyleBackColor = true;
            this.btnInventoryClerk.Click += new System.EventHandler(this.BtnButtonClicked);
            // 
            // btnTechManager
            // 
            this.btnTechManager.Location = new System.Drawing.Point(270, 256);
            this.btnTechManager.Name = "btnTechManager";
            this.btnTechManager.Size = new System.Drawing.Size(235, 55);
            this.btnTechManager.TabIndex = 9;
            this.btnTechManager.Text = "Tech Manager";
            this.btnTechManager.UseVisualStyleBackColor = true;
            this.btnTechManager.Click += new System.EventHandler(this.BtnButtonClicked);
            // 
            // btnTechClerk
            // 
            this.btnTechClerk.Location = new System.Drawing.Point(12, 256);
            this.btnTechClerk.Name = "btnTechClerk";
            this.btnTechClerk.Size = new System.Drawing.Size(235, 55);
            this.btnTechClerk.TabIndex = 8;
            this.btnTechClerk.Text = "Tech Clerk";
            this.btnTechClerk.UseVisualStyleBackColor = true;
            this.btnTechClerk.Click += new System.EventHandler(this.BtnButtonClicked);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(12, 317);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(493, 55);
            this.btnAdmin.TabIndex = 11;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.BtnButtonClicked);
            // 
            // StaffRoleChooserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 390);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnTechManager);
            this.Controls.Add(this.btnTechClerk);
            this.Controls.Add(this.btnReceivingClerk);
            this.Controls.Add(this.btnInventoryClerk);
            this.Controls.Add(this.btnAccountingManager);
            this.Controls.Add(this.btnAccountingClerk);
            this.Controls.Add(this.btnPurchaseManager);
            this.Controls.Add(this.btnPurchaseClerk);
            this.Controls.Add(this.btnSalesManager);
            this.Controls.Add(this.btnSalesRep);
            this.Name = "StaffRoleChooserForm";
            this.Text = "DEVELOPMENT TOOL";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnReceivingClerk;

        private System.Windows.Forms.Button btnSalesRep;
        private System.Windows.Forms.Button btnSalesManager;
        private System.Windows.Forms.Button btnAccountingClerk;
        private System.Windows.Forms.Button btnAccountingManager;
        private System.Windows.Forms.Button btnPurchaseClerk;
        private System.Windows.Forms.Button btnPurchaseManager;
        private System.Windows.Forms.Button btnInventoryClerk;
        private System.Windows.Forms.Button btnInventoryManager;
        private System.Windows.Forms.Button btnTechClerk;
        private System.Windows.Forms.Button btnTechManager;
        private System.Windows.Forms.Button btnAdmin;

        #endregion
    }
}
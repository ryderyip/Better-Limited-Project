namespace Better_Limited_Project.ProductUtility.ProductList.Forms
{
    partial class UpdateSellingPriceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateSellingPriceForm));
            this.tbOriginalSellingPrice = new System.Windows.Forms.TextBox();
            this.lblOriginalSellingPrice = new System.Windows.Forms.Label();
            this.lblOriginalInfo = new System.Windows.Forms.Label();
            this.lblNewSellingPrice = new System.Windows.Forms.Label();
            this.btnUpdateSellingPrice = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nudNewSellingPrice = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewSellingPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // tbOriginalSellingPrice
            // 
            resources.ApplyResources(this.tbOriginalSellingPrice, "tbOriginalSellingPrice");
            this.tbOriginalSellingPrice.Name = "tbOriginalSellingPrice";
            this.tbOriginalSellingPrice.ReadOnly = true;
            // 
            // lblOriginalSellingPrice
            // 
            resources.ApplyResources(this.lblOriginalSellingPrice, "lblOriginalSellingPrice");
            this.lblOriginalSellingPrice.Name = "lblOriginalSellingPrice";
            // 
            // lblOriginalInfo
            // 
            resources.ApplyResources(this.lblOriginalInfo, "lblOriginalInfo");
            this.lblOriginalInfo.Name = "lblOriginalInfo";
            // 
            // lblNewSellingPrice
            // 
            resources.ApplyResources(this.lblNewSellingPrice, "lblNewSellingPrice");
            this.lblNewSellingPrice.Name = "lblNewSellingPrice";
            // 
            // btnUpdateSellingPrice
            // 
            this.btnUpdateSellingPrice.BackColor = System.Drawing.Color.DarkOrange;
            resources.ApplyResources(this.btnUpdateSellingPrice, "btnUpdateSellingPrice");
            this.btnUpdateSellingPrice.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdateSellingPrice.Name = "btnUpdateSellingPrice";
            this.btnUpdateSellingPrice.UseVisualStyleBackColor = false;
            this.btnUpdateSellingPrice.Click += new System.EventHandler(this.btnUpdateSellingPrice_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // nudNewSellingPrice
            // 
            this.nudNewSellingPrice.DecimalPlaces = 2;
            resources.ApplyResources(this.nudNewSellingPrice, "nudNewSellingPrice");
            this.nudNewSellingPrice.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudNewSellingPrice.Name = "nudNewSellingPrice";
            // 
            // UpdateSellingPriceForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.nudNewSellingPrice);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdateSellingPrice);
            this.Controls.Add(this.lblNewSellingPrice);
            this.Controls.Add(this.tbOriginalSellingPrice);
            this.Controls.Add(this.lblOriginalSellingPrice);
            this.Controls.Add(this.lblOriginalInfo);
            this.Name = "UpdateSellingPriceForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudNewSellingPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.NumericUpDown nudNewSellingPrice;

        private System.Windows.Forms.TextBox tbOriginalSellingPrice;

        private System.Windows.Forms.Label lblOriginalSellingPrice;


        private System.Windows.Forms.Button btnUpdateSellingPrice;


        #endregion

        private System.Windows.Forms.Label lblOriginalInfo;
        private System.Windows.Forms.Label lblNewSellingPrice;
        private System.Windows.Forms.Button btnCancel;
    }
}
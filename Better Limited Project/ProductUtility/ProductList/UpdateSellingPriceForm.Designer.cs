namespace Better_Limited_Project.ProductUtility.ProductList
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
            this.tbOriginalSellingPrice = new System.Windows.Forms.TextBox();
            this.lblOriginalSellingPrice = new System.Windows.Forms.Label();
            this.lblOriginalInfo = new System.Windows.Forms.Label();
            this.lblNewSellingPrice = new System.Windows.Forms.Label();
            this.btnUpdateSellingPrice = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nudNewSellingPrice = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize) (this.nudNewSellingPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // tbOriginalSellingPrice
            // 
            this.tbOriginalSellingPrice.Location = new System.Drawing.Point(282, 174);
            this.tbOriginalSellingPrice.Name = "tbOriginalSellingPrice";
            this.tbOriginalSellingPrice.ReadOnly = true;
            this.tbOriginalSellingPrice.Size = new System.Drawing.Size(215, 20);
            this.tbOriginalSellingPrice.TabIndex = 19;
            // 
            // lblOriginalSellingPrice
            // 
            this.lblOriginalSellingPrice.AutoSize = true;
            this.lblOriginalSellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblOriginalSellingPrice.Location = new System.Drawing.Point(282, 147);
            this.lblOriginalSellingPrice.Name = "lblOriginalSellingPrice";
            this.lblOriginalSellingPrice.Size = new System.Drawing.Size(125, 15);
            this.lblOriginalSellingPrice.TabIndex = 14;
            this.lblOriginalSellingPrice.Text = "Original Selling Price:";
            // 
            // lblOriginalInfo
            // 
            this.lblOriginalInfo.AutoSize = true;
            this.lblOriginalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblOriginalInfo.Location = new System.Drawing.Point(267, 56);
            this.lblOriginalInfo.Name = "lblOriginalInfo";
            this.lblOriginalInfo.Size = new System.Drawing.Size(230, 26);
            this.lblOriginalInfo.TabIndex = 13;
            this.lblOriginalInfo.Text = "Update Selling Price";
            this.lblOriginalInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNewSellingPrice
            // 
            this.lblNewSellingPrice.AutoSize = true;
            this.lblNewSellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblNewSellingPrice.Location = new System.Drawing.Point(282, 231);
            this.lblNewSellingPrice.Name = "lblNewSellingPrice";
            this.lblNewSellingPrice.Size = new System.Drawing.Size(148, 15);
            this.lblNewSellingPrice.TabIndex = 24;
            this.lblNewSellingPrice.Text = "New Selling Price (HKD$)";
            // 
            // btnUpdateSellingPrice
            // 
            this.btnUpdateSellingPrice.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdateSellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnUpdateSellingPrice.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdateSellingPrice.Location = new System.Drawing.Point(276, 345);
            this.btnUpdateSellingPrice.Name = "btnUpdateSellingPrice";
            this.btnUpdateSellingPrice.Size = new System.Drawing.Size(221, 47);
            this.btnUpdateSellingPrice.TabIndex = 26;
            this.btnUpdateSellingPrice.Text = "Update Selling Price";
            this.btnUpdateSellingPrice.UseVisualStyleBackColor = false;
            this.btnUpdateSellingPrice.Click += new System.EventHandler(this.btnUpdateSellingPrice_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCancel.Location = new System.Drawing.Point(339, 398);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 47);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // nudNewSellingPrice
            // 
            this.nudNewSellingPrice.DecimalPlaces = 2;
            this.nudNewSellingPrice.Location = new System.Drawing.Point(282, 258);
            this.nudNewSellingPrice.Maximum = new decimal(new int[] {999999, 0, 0, 0});
            this.nudNewSellingPrice.Name = "nudNewSellingPrice";
            this.nudNewSellingPrice.Size = new System.Drawing.Size(215, 20);
            this.nudNewSellingPrice.TabIndex = 28;
            this.nudNewSellingPrice.ThousandsSeparator = true;
            // 
            // UpdateSellingPriceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.nudNewSellingPrice);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdateSellingPrice);
            this.Controls.Add(this.lblNewSellingPrice);
            this.Controls.Add(this.tbOriginalSellingPrice);
            this.Controls.Add(this.lblOriginalSellingPrice);
            this.Controls.Add(this.lblOriginalInfo);
            this.Name = "UpdateSellingPriceForm";
            this.Text = "UpdateSellingPriceForm";
            ((System.ComponentModel.ISupportInitialize) (this.nudNewSellingPrice)).EndInit();
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
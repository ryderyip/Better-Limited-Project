namespace Better_Limited_Project.ProductUtility.ProductList.Forms
{
    partial class UpdateProductForm
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
            this.lblOriginalInfo = new System.Windows.Forms.Label();
            this.lblOriginalPrice = new System.Windows.Forms.Label();
            this.lblSellingPrice = new System.Windows.Forms.Label();
            this.lblPhasingOut = new System.Windows.Forms.Label();
            this.lblReorderLevel = new System.Windows.Forms.Label();
            this.txtOriginalPrice = new System.Windows.Forms.TextBox();
            this.txtSellingPrice = new System.Windows.Forms.TextBox();
            this.txtPhasingOut = new System.Windows.Forms.TextBox();
            this.txtReorderLevel = new System.Windows.Forms.TextBox();
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.nudNewStockLevel = new System.Windows.Forms.NumericUpDown();
            this.lblNewStockLevel = new System.Windows.Forms.Label();
            this.nudNewReorderLevel = new System.Windows.Forms.NumericUpDown();
            this.nudNewSellingPirce = new System.Windows.Forms.NumericUpDown();
            this.rbPhasingOutOn = new System.Windows.Forms.RadioButton();
            this.rbPhasingOutOff = new System.Windows.Forms.RadioButton();
            this.lblNewPhasingOut = new System.Windows.Forms.Label();
            this.lblNewReorderLevel = new System.Windows.Forms.Label();
            this.lblNewSellingPrice = new System.Windows.Forms.Label();
            this.tbStockLevel = new System.Windows.Forms.TextBox();
            this.lblStockLevel = new System.Windows.Forms.Label();
            this.lblNewInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewStockLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewReorderLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewSellingPirce)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOriginalInfo
            // 
            this.lblOriginalInfo.AutoSize = true;
            this.lblOriginalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalInfo.Location = new System.Drawing.Point(212, 103);
            this.lblOriginalInfo.Name = "lblOriginalInfo";
            this.lblOriginalInfo.Size = new System.Drawing.Size(107, 20);
            this.lblOriginalInfo.TabIndex = 14;
            this.lblOriginalInfo.Text = "Original Info";
            // 
            // lblOriginalPrice
            // 
            this.lblOriginalPrice.AutoSize = true;
            this.lblOriginalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalPrice.Location = new System.Drawing.Point(152, 295);
            this.lblOriginalPrice.Name = "lblOriginalPrice";
            this.lblOriginalPrice.Size = new System.Drawing.Size(84, 15);
            this.lblOriginalPrice.TabIndex = 24;
            this.lblOriginalPrice.Text = "Original Price:";
            // 
            // lblSellingPrice
            // 
            this.lblSellingPrice.AutoSize = true;
            this.lblSellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellingPrice.Location = new System.Drawing.Point(156, 332);
            this.lblSellingPrice.Name = "lblSellingPrice";
            this.lblSellingPrice.Size = new System.Drawing.Size(79, 15);
            this.lblSellingPrice.TabIndex = 25;
            this.lblSellingPrice.Text = "Selling Price:";
            // 
            // lblPhasingOut
            // 
            this.lblPhasingOut.AutoSize = true;
            this.lblPhasingOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhasingOut.Location = new System.Drawing.Point(159, 184);
            this.lblPhasingOut.Name = "lblPhasingOut";
            this.lblPhasingOut.Size = new System.Drawing.Size(76, 15);
            this.lblPhasingOut.TabIndex = 26;
            this.lblPhasingOut.Text = "Phasing-out:";
            // 
            // lblReorderLevel
            // 
            this.lblReorderLevel.AutoSize = true;
            this.lblReorderLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReorderLevel.Location = new System.Drawing.Point(149, 224);
            this.lblReorderLevel.Name = "lblReorderLevel";
            this.lblReorderLevel.Size = new System.Drawing.Size(87, 15);
            this.lblReorderLevel.TabIndex = 28;
            this.lblReorderLevel.Text = "Reorder Level:";
            // 
            // txtOriginalPrice
            // 
            this.txtOriginalPrice.Location = new System.Drawing.Point(241, 294);
            this.txtOriginalPrice.Name = "txtOriginalPrice";
            this.txtOriginalPrice.ReadOnly = true;
            this.txtOriginalPrice.Size = new System.Drawing.Size(100, 20);
            this.txtOriginalPrice.TabIndex = 29;
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.Location = new System.Drawing.Point(241, 331);
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.ReadOnly = true;
            this.txtSellingPrice.Size = new System.Drawing.Size(100, 20);
            this.txtSellingPrice.TabIndex = 30;
            // 
            // txtPhasingOut
            // 
            this.txtPhasingOut.Location = new System.Drawing.Point(241, 183);
            this.txtPhasingOut.Name = "txtPhasingOut";
            this.txtPhasingOut.ReadOnly = true;
            this.txtPhasingOut.Size = new System.Drawing.Size(46, 20);
            this.txtPhasingOut.TabIndex = 31;
            // 
            // txtReorderLevel
            // 
            this.txtReorderLevel.Location = new System.Drawing.Point(241, 220);
            this.txtReorderLevel.Name = "txtReorderLevel";
            this.txtReorderLevel.ReadOnly = true;
            this.txtReorderLevel.Size = new System.Drawing.Size(46, 20);
            this.txtReorderLevel.TabIndex = 33;
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdateInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInfo.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdateInfo.Location = new System.Drawing.Point(309, 393);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(183, 44);
            this.btnUpdateInfo.TabIndex = 41;
            this.btnUpdateInfo.Text = "Update Info";
            this.btnUpdateInfo.UseVisualStyleBackColor = false;
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 52;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(241, 146);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(155, 20);
            this.txtName.TabIndex = 53;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(317, 35);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(175, 25);
            this.lblHeader.TabIndex = 56;
            this.lblHeader.Text = "Product Update";
            // 
            // nudNewStockLevel
            // 
            this.nudNewStockLevel.Location = new System.Drawing.Point(554, 179);
            this.nudNewStockLevel.Name = "nudNewStockLevel";
            this.nudNewStockLevel.Size = new System.Drawing.Size(70, 20);
            this.nudNewStockLevel.TabIndex = 98;
            // 
            // lblNewStockLevel
            // 
            this.lblNewStockLevel.AutoSize = true;
            this.lblNewStockLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewStockLevel.Location = new System.Drawing.Point(452, 179);
            this.lblNewStockLevel.Name = "lblNewStockLevel";
            this.lblNewStockLevel.Size = new System.Drawing.Size(100, 15);
            this.lblNewStockLevel.TabIndex = 97;
            this.lblNewStockLevel.Text = "New Stock Level:";
            // 
            // nudNewReorderLevel
            // 
            this.nudNewReorderLevel.Location = new System.Drawing.Point(554, 268);
            this.nudNewReorderLevel.Name = "nudNewReorderLevel";
            this.nudNewReorderLevel.Size = new System.Drawing.Size(70, 20);
            this.nudNewReorderLevel.TabIndex = 94;
            // 
            // nudNewSellingPirce
            // 
            this.nudNewSellingPirce.Location = new System.Drawing.Point(554, 315);
            this.nudNewSellingPirce.Name = "nudNewSellingPirce";
            this.nudNewSellingPirce.Size = new System.Drawing.Size(114, 20);
            this.nudNewSellingPirce.TabIndex = 93;
            // 
            // rbPhasingOutOn
            // 
            this.rbPhasingOutOn.AutoSize = true;
            this.rbPhasingOutOn.Location = new System.Drawing.Point(554, 224);
            this.rbPhasingOutOn.Name = "rbPhasingOutOn";
            this.rbPhasingOutOn.Size = new System.Drawing.Size(39, 17);
            this.rbPhasingOutOn.TabIndex = 92;
            this.rbPhasingOutOn.TabStop = true;
            this.rbPhasingOutOn.Text = "On";
            this.rbPhasingOutOn.UseVisualStyleBackColor = true;
            // 
            // rbPhasingOutOff
            // 
            this.rbPhasingOutOff.AutoSize = true;
            this.rbPhasingOutOff.Location = new System.Drawing.Point(599, 224);
            this.rbPhasingOutOff.Name = "rbPhasingOutOff";
            this.rbPhasingOutOff.Size = new System.Drawing.Size(39, 17);
            this.rbPhasingOutOff.TabIndex = 91;
            this.rbPhasingOutOff.TabStop = true;
            this.rbPhasingOutOff.Text = "Off";
            this.rbPhasingOutOff.UseVisualStyleBackColor = true;
            // 
            // lblNewPhasingOut
            // 
            this.lblNewPhasingOut.AutoSize = true;
            this.lblNewPhasingOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPhasingOut.Location = new System.Drawing.Point(476, 224);
            this.lblNewPhasingOut.Name = "lblNewPhasingOut";
            this.lblNewPhasingOut.Size = new System.Drawing.Size(76, 15);
            this.lblNewPhasingOut.TabIndex = 90;
            this.lblNewPhasingOut.Text = "Phasing-out:";
            // 
            // lblNewReorderLevel
            // 
            this.lblNewReorderLevel.AutoSize = true;
            this.lblNewReorderLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewReorderLevel.Location = new System.Drawing.Point(437, 268);
            this.lblNewReorderLevel.Name = "lblNewReorderLevel";
            this.lblNewReorderLevel.Size = new System.Drawing.Size(115, 15);
            this.lblNewReorderLevel.TabIndex = 89;
            this.lblNewReorderLevel.Text = "New Reorder Level:";
            // 
            // lblNewSellingPrice
            // 
            this.lblNewSellingPrice.AutoSize = true;
            this.lblNewSellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewSellingPrice.Location = new System.Drawing.Point(445, 315);
            this.lblNewSellingPrice.Name = "lblNewSellingPrice";
            this.lblNewSellingPrice.Size = new System.Drawing.Size(107, 15);
            this.lblNewSellingPrice.TabIndex = 88;
            this.lblNewSellingPrice.Text = "New Selling Price:";
            // 
            // tbStockLevel
            // 
            this.tbStockLevel.Location = new System.Drawing.Point(241, 257);
            this.tbStockLevel.Name = "tbStockLevel";
            this.tbStockLevel.ReadOnly = true;
            this.tbStockLevel.Size = new System.Drawing.Size(46, 20);
            this.tbStockLevel.TabIndex = 100;
            // 
            // lblStockLevel
            // 
            this.lblStockLevel.AutoSize = true;
            this.lblStockLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockLevel.Location = new System.Drawing.Point(164, 258);
            this.lblStockLevel.Name = "lblStockLevel";
            this.lblStockLevel.Size = new System.Drawing.Size(72, 15);
            this.lblStockLevel.TabIndex = 99;
            this.lblStockLevel.Text = "Stock Level:";
            // 
            // lblNewInfo
            // 
            this.lblNewInfo.AutoSize = true;
            this.lblNewInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewInfo.Location = new System.Drawing.Point(513, 103);
            this.lblNewInfo.Name = "lblNewInfo";
            this.lblNewInfo.Size = new System.Drawing.Size(80, 20);
            this.lblNewInfo.TabIndex = 101;
            this.lblNewInfo.Text = "New Info";
            // 
            // UpdateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.lblNewInfo);
            this.Controls.Add(this.tbStockLevel);
            this.Controls.Add(this.lblStockLevel);
            this.Controls.Add(this.nudNewStockLevel);
            this.Controls.Add(this.lblNewStockLevel);
            this.Controls.Add(this.nudNewReorderLevel);
            this.Controls.Add(this.nudNewSellingPirce);
            this.Controls.Add(this.rbPhasingOutOn);
            this.Controls.Add(this.rbPhasingOutOff);
            this.Controls.Add(this.lblNewPhasingOut);
            this.Controls.Add(this.lblNewReorderLevel);
            this.Controls.Add(this.lblNewSellingPrice);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateInfo);
            this.Controls.Add(this.txtReorderLevel);
            this.Controls.Add(this.txtPhasingOut);
            this.Controls.Add(this.txtSellingPrice);
            this.Controls.Add(this.txtOriginalPrice);
            this.Controls.Add(this.lblReorderLevel);
            this.Controls.Add(this.lblPhasingOut);
            this.Controls.Add(this.lblSellingPrice);
            this.Controls.Add(this.lblOriginalPrice);
            this.Controls.Add(this.lblOriginalInfo);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "UpdateProductForm";
            this.Shown += new System.EventHandler(this.OnFormShown);
            ((System.ComponentModel.ISupportInitialize)(this.nudNewStockLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewReorderLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewSellingPirce)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblOriginalInfo;
        private System.Windows.Forms.Label lblOriginalPrice;
        private System.Windows.Forms.Label lblSellingPrice;
        private System.Windows.Forms.Label lblPhasingOut;
        private System.Windows.Forms.Label lblReorderLevel;
        private System.Windows.Forms.TextBox txtOriginalPrice;
        private System.Windows.Forms.TextBox txtSellingPrice;
        private System.Windows.Forms.TextBox txtPhasingOut;
        private System.Windows.Forms.TextBox txtReorderLevel;
        private System.Windows.Forms.Button btnUpdateInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.NumericUpDown nudNewStockLevel;
        private System.Windows.Forms.Label lblNewStockLevel;
        private System.Windows.Forms.NumericUpDown nudNewReorderLevel;
        private System.Windows.Forms.NumericUpDown nudNewSellingPirce;
        private System.Windows.Forms.RadioButton rbPhasingOutOn;
        private System.Windows.Forms.RadioButton rbPhasingOutOff;
        private System.Windows.Forms.Label lblNewPhasingOut;
        private System.Windows.Forms.Label lblNewReorderLevel;
        private System.Windows.Forms.Label lblNewSellingPrice;
        private System.Windows.Forms.TextBox tbStockLevel;
        private System.Windows.Forms.Label lblStockLevel;
        private System.Windows.Forms.Label lblNewInfo;
    }
}
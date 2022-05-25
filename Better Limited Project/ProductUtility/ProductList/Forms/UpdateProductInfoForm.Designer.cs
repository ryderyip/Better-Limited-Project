namespace Better_Limited_Project.ProductUtility.ProductList.Forms
{
    partial class UpdateProductInfoForm
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
            this.lblProductID = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lblNewSpellingPrice = new System.Windows.Forms.Label();
            this.lblNewReorderLevel = new System.Windows.Forms.Label();
            this.lblPhasing_Out = new System.Windows.Forms.Label();
            this.radioBtnPhasing_Out_Off = new System.Windows.Forms.RadioButton();
            this.radioBtnPhasing_Out_On = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.nudNewSellingPirce = new System.Windows.Forms.NumericUpDown();
            this.nudNewReorderLevel = new System.Windows.Forms.NumericUpDown();
            this.lblHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewSellingPirce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewReorderLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOriginalInfo
            // 
            this.lblOriginalInfo.AutoSize = true;
            this.lblOriginalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalInfo.Location = new System.Drawing.Point(208, 80);
            this.lblOriginalInfo.Name = "lblOriginalInfo";
            this.lblOriginalInfo.Size = new System.Drawing.Size(107, 20);
            this.lblOriginalInfo.TabIndex = 14;
            this.lblOriginalInfo.Text = "Original Info";
            // 
            // lblOriginalPrice
            // 
            this.lblOriginalPrice.AutoSize = true;
            this.lblOriginalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalPrice.Location = new System.Drawing.Point(169, 277);
            this.lblOriginalPrice.Name = "lblOriginalPrice";
            this.lblOriginalPrice.Size = new System.Drawing.Size(84, 15);
            this.lblOriginalPrice.TabIndex = 24;
            this.lblOriginalPrice.Text = "Original Price:";
            // 
            // lblSellingPrice
            // 
            this.lblSellingPrice.AutoSize = true;
            this.lblSellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellingPrice.Location = new System.Drawing.Point(175, 315);
            this.lblSellingPrice.Name = "lblSellingPrice";
            this.lblSellingPrice.Size = new System.Drawing.Size(79, 15);
            this.lblSellingPrice.TabIndex = 25;
            this.lblSellingPrice.Text = "Selling Price:";
            // 
            // lblPhasingOut
            // 
            this.lblPhasingOut.AutoSize = true;
            this.lblPhasingOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhasingOut.Location = new System.Drawing.Point(180, 201);
            this.lblPhasingOut.Name = "lblPhasingOut";
            this.lblPhasingOut.Size = new System.Drawing.Size(76, 15);
            this.lblPhasingOut.TabIndex = 26;
            this.lblPhasingOut.Text = "Phasing-out:";
            // 
            // lblReorderLevel
            // 
            this.lblReorderLevel.AutoSize = true;
            this.lblReorderLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReorderLevel.Location = new System.Drawing.Point(169, 239);
            this.lblReorderLevel.Name = "lblReorderLevel";
            this.lblReorderLevel.Size = new System.Drawing.Size(87, 15);
            this.lblReorderLevel.TabIndex = 28;
            this.lblReorderLevel.Text = "Reorder Level:";
            // 
            // txtOriginalPrice
            // 
            this.txtOriginalPrice.Location = new System.Drawing.Point(261, 276);
            this.txtOriginalPrice.Name = "txtOriginalPrice";
            this.txtOriginalPrice.ReadOnly = true;
            this.txtOriginalPrice.Size = new System.Drawing.Size(100, 20);
            this.txtOriginalPrice.TabIndex = 29;
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.Location = new System.Drawing.Point(261, 314);
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.ReadOnly = true;
            this.txtSellingPrice.Size = new System.Drawing.Size(100, 20);
            this.txtSellingPrice.TabIndex = 30;
            // 
            // txtPhasingOut
            // 
            this.txtPhasingOut.Location = new System.Drawing.Point(262, 200);
            this.txtPhasingOut.Name = "txtPhasingOut";
            this.txtPhasingOut.ReadOnly = true;
            this.txtPhasingOut.Size = new System.Drawing.Size(46, 20);
            this.txtPhasingOut.TabIndex = 31;
            // 
            // txtReorderLevel
            // 
            this.txtReorderLevel.Location = new System.Drawing.Point(262, 238);
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
            this.btnUpdateInfo.Location = new System.Drawing.Point(309, 384);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(183, 44);
            this.btnUpdateInfo.TabIndex = 41;
            this.btnUpdateInfo.Text = "Update Info";
            this.btnUpdateInfo.UseVisualStyleBackColor = false;
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.Location = new System.Drawing.Point(188, 125);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(67, 15);
            this.lblProductID.TabIndex = 43;
            this.lblProductID.Text = "Product ID:";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(261, 124);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(100, 20);
            this.txtProductID.TabIndex = 44;
            // 
            // lblNewSpellingPrice
            // 
            this.lblNewSpellingPrice.AutoSize = true;
            this.lblNewSpellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewSpellingPrice.Location = new System.Drawing.Point(470, 124);
            this.lblNewSpellingPrice.Name = "lblNewSpellingPrice";
            this.lblNewSpellingPrice.Size = new System.Drawing.Size(104, 15);
            this.lblNewSpellingPrice.TabIndex = 45;
            this.lblNewSpellingPrice.Text = "New Selling Price";
            // 
            // lblNewReorderLevel
            // 
            this.lblNewReorderLevel.AutoSize = true;
            this.lblNewReorderLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewReorderLevel.Location = new System.Drawing.Point(470, 199);
            this.lblNewReorderLevel.Name = "lblNewReorderLevel";
            this.lblNewReorderLevel.Size = new System.Drawing.Size(112, 15);
            this.lblNewReorderLevel.TabIndex = 47;
            this.lblNewReorderLevel.Text = "New Reorder Level";
            // 
            // lblPhasing_Out
            // 
            this.lblPhasing_Out.AutoSize = true;
            this.lblPhasing_Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhasing_Out.Location = new System.Drawing.Point(474, 287);
            this.lblPhasing_Out.Name = "lblPhasing_Out";
            this.lblPhasing_Out.Size = new System.Drawing.Size(73, 15);
            this.lblPhasing_Out.TabIndex = 49;
            this.lblPhasing_Out.Text = "Phasing-out";
            // 
            // radioBtnPhasing_Out_Off
            // 
            this.radioBtnPhasing_Out_Off.AutoSize = true;
            this.radioBtnPhasing_Out_Off.Location = new System.Drawing.Point(543, 320);
            this.radioBtnPhasing_Out_Off.Name = "radioBtnPhasing_Out_Off";
            this.radioBtnPhasing_Out_Off.Size = new System.Drawing.Size(39, 17);
            this.radioBtnPhasing_Out_Off.TabIndex = 50;
            this.radioBtnPhasing_Out_Off.TabStop = true;
            this.radioBtnPhasing_Out_Off.Text = "Off";
            this.radioBtnPhasing_Out_Off.UseVisualStyleBackColor = true;
            // 
            // radioBtnPhasing_Out_On
            // 
            this.radioBtnPhasing_Out_On.AutoSize = true;
            this.radioBtnPhasing_Out_On.Location = new System.Drawing.Point(476, 320);
            this.radioBtnPhasing_Out_On.Name = "radioBtnPhasing_Out_On";
            this.radioBtnPhasing_Out_On.Size = new System.Drawing.Size(39, 17);
            this.radioBtnPhasing_Out_On.TabIndex = 51;
            this.radioBtnPhasing_Out_On.TabStop = true;
            this.radioBtnPhasing_Out_On.Text = "On";
            this.radioBtnPhasing_Out_On.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 52;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(262, 162);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 53;
            // 
            // nudNewSellingPirce
            // 
            this.nudNewSellingPirce.Location = new System.Drawing.Point(470, 155);
            this.nudNewSellingPirce.Name = "nudNewSellingPirce";
            this.nudNewSellingPirce.Size = new System.Drawing.Size(164, 20);
            this.nudNewSellingPirce.TabIndex = 54;
            // 
            // nudNewReorderLevel
            // 
            this.nudNewReorderLevel.Location = new System.Drawing.Point(470, 238);
            this.nudNewReorderLevel.Name = "nudNewReorderLevel";
            this.nudNewReorderLevel.Size = new System.Drawing.Size(164, 20);
            this.nudNewReorderLevel.TabIndex = 55;
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
            // UpdateProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.nudNewReorderLevel);
            this.Controls.Add(this.nudNewSellingPirce);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioBtnPhasing_Out_On);
            this.Controls.Add(this.radioBtnPhasing_Out_Off);
            this.Controls.Add(this.lblPhasing_Out);
            this.Controls.Add(this.lblNewReorderLevel);
            this.Controls.Add(this.lblNewSpellingPrice);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lblProductID);
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
            this.Name = "UpdateProductInfoForm";
            this.Shown += new System.EventHandler(this.OnFormShown);
            ((System.ComponentModel.ISupportInitialize)(this.nudNewSellingPirce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewReorderLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.NumericUpDown nudNewSellingPirce;
        private System.Windows.Forms.NumericUpDown nudNewReorderLevel;

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
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lblNewSpellingPrice;
        private System.Windows.Forms.Label lblNewReorderLevel;
        private System.Windows.Forms.Label lblPhasing_Out;
        private System.Windows.Forms.RadioButton radioBtnPhasing_Out_Off;
        private System.Windows.Forms.RadioButton radioBtnPhasing_Out_On;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;

        #endregion

        private System.Windows.Forms.Label lblHeader;
    }
}
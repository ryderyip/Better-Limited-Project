
namespace Better_Limited_Project.ProductUtility.ProductList.Forms
{
    partial class UpdateProductAdminForm
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.nudNewReorderLevel = new System.Windows.Forms.NumericUpDown();
            this.nudNewSellingPirce = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbPhasingOutOn = new System.Windows.Forms.RadioButton();
            this.rbPhasingOutOff = new System.Windows.Forms.RadioButton();
            this.lblOutPhasingOut = new System.Windows.Forms.Label();
            this.lblNewReorderLevel = new System.Windows.Forms.Label();
            this.lblNewSellingPrice = new System.Windows.Forms.Label();
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.txtReorderLevel = new System.Windows.Forms.TextBox();
            this.txtPhasingOut = new System.Windows.Forms.TextBox();
            this.txtSellingPrice = new System.Windows.Forms.TextBox();
            this.txtOriginalPrice = new System.Windows.Forms.TextBox();
            this.lblReorderLevel = new System.Windows.Forms.Label();
            this.lblPhasingOut = new System.Windows.Forms.Label();
            this.lblSellingPrice = new System.Windows.Forms.Label();
            this.lblOriginalPrice = new System.Windows.Forms.Label();
            this.lblOriginalInfo = new System.Windows.Forms.Label();
            this.nudNewOriginalPrice = new System.Windows.Forms.NumericUpDown();
            this.lblNewOriginalPrice = new System.Windows.Forms.Label();
            this.tbNewName = new System.Windows.Forms.TextBox();
            this.lblNewName = new System.Windows.Forms.Label();
            this.lblNewInfo = new System.Windows.Forms.Label();
            this.tbStockLevel = new System.Windows.Forms.TextBox();
            this.lblStockLevel = new System.Windows.Forms.Label();
            this.lblNewStockLevel = new System.Windows.Forms.Label();
            this.nudNewStockLevel = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewReorderLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewSellingPirce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewOriginalPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewStockLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(321, 25);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(175, 25);
            this.lblHeader.TabIndex = 78;
            this.lblHeader.Text = "Product Update";
            // 
            // nudNewReorderLevel
            // 
            this.nudNewReorderLevel.Location = new System.Drawing.Point(540, 201);
            this.nudNewReorderLevel.Name = "nudNewReorderLevel";
            this.nudNewReorderLevel.Size = new System.Drawing.Size(70, 20);
            this.nudNewReorderLevel.TabIndex = 77;
            // 
            // nudNewSellingPirce
            // 
            this.nudNewSellingPirce.Location = new System.Drawing.Point(541, 315);
            this.nudNewSellingPirce.Name = "nudNewSellingPirce";
            this.nudNewSellingPirce.Size = new System.Drawing.Size(114, 20);
            this.nudNewSellingPirce.TabIndex = 76;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(206, 124);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(155, 20);
            this.txtName.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 74;
            this.label1.Text = "Name:";
            // 
            // rbPhasingOutOn
            // 
            this.rbPhasingOutOn.AutoSize = true;
            this.rbPhasingOutOn.Location = new System.Drawing.Point(540, 165);
            this.rbPhasingOutOn.Name = "rbPhasingOutOn";
            this.rbPhasingOutOn.Size = new System.Drawing.Size(39, 17);
            this.rbPhasingOutOn.TabIndex = 73;
            this.rbPhasingOutOn.TabStop = true;
            this.rbPhasingOutOn.Text = "On";
            this.rbPhasingOutOn.UseVisualStyleBackColor = true;
            // 
            // rbPhasingOutOff
            // 
            this.rbPhasingOutOff.AutoSize = true;
            this.rbPhasingOutOff.Location = new System.Drawing.Point(585, 165);
            this.rbPhasingOutOff.Name = "rbPhasingOutOff";
            this.rbPhasingOutOff.Size = new System.Drawing.Size(39, 17);
            this.rbPhasingOutOff.TabIndex = 72;
            this.rbPhasingOutOff.TabStop = true;
            this.rbPhasingOutOff.Text = "Off";
            this.rbPhasingOutOff.UseVisualStyleBackColor = true;
            // 
            // lblOutPhasingOut
            // 
            this.lblOutPhasingOut.AutoSize = true;
            this.lblOutPhasingOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutPhasingOut.Location = new System.Drawing.Point(462, 165);
            this.lblOutPhasingOut.Name = "lblOutPhasingOut";
            this.lblOutPhasingOut.Size = new System.Drawing.Size(76, 15);
            this.lblOutPhasingOut.TabIndex = 71;
            this.lblOutPhasingOut.Text = "Phasing-out:";
            // 
            // lblNewReorderLevel
            // 
            this.lblNewReorderLevel.AutoSize = true;
            this.lblNewReorderLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewReorderLevel.Location = new System.Drawing.Point(423, 201);
            this.lblNewReorderLevel.Name = "lblNewReorderLevel";
            this.lblNewReorderLevel.Size = new System.Drawing.Size(115, 15);
            this.lblNewReorderLevel.TabIndex = 70;
            this.lblNewReorderLevel.Text = "New Reorder Level:";
            // 
            // lblNewSellingPrice
            // 
            this.lblNewSellingPrice.AutoSize = true;
            this.lblNewSellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewSellingPrice.Location = new System.Drawing.Point(431, 315);
            this.lblNewSellingPrice.Name = "lblNewSellingPrice";
            this.lblNewSellingPrice.Size = new System.Drawing.Size(107, 15);
            this.lblNewSellingPrice.TabIndex = 69;
            this.lblNewSellingPrice.Text = "New Selling Price:";
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdateInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInfo.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdateInfo.Location = new System.Drawing.Point(313, 377);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(183, 44);
            this.btnUpdateInfo.TabIndex = 66;
            this.btnUpdateInfo.Text = "Update Info";
            this.btnUpdateInfo.UseVisualStyleBackColor = false;
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // txtReorderLevel
            // 
            this.txtReorderLevel.Location = new System.Drawing.Point(206, 200);
            this.txtReorderLevel.Name = "txtReorderLevel";
            this.txtReorderLevel.ReadOnly = true;
            this.txtReorderLevel.Size = new System.Drawing.Size(46, 20);
            this.txtReorderLevel.TabIndex = 65;
            // 
            // txtPhasingOut
            // 
            this.txtPhasingOut.Location = new System.Drawing.Point(206, 162);
            this.txtPhasingOut.Name = "txtPhasingOut";
            this.txtPhasingOut.ReadOnly = true;
            this.txtPhasingOut.Size = new System.Drawing.Size(46, 20);
            this.txtPhasingOut.TabIndex = 64;
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.Location = new System.Drawing.Point(206, 314);
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.ReadOnly = true;
            this.txtSellingPrice.Size = new System.Drawing.Size(100, 20);
            this.txtSellingPrice.TabIndex = 63;
            // 
            // txtOriginalPrice
            // 
            this.txtOriginalPrice.Location = new System.Drawing.Point(206, 276);
            this.txtOriginalPrice.Name = "txtOriginalPrice";
            this.txtOriginalPrice.ReadOnly = true;
            this.txtOriginalPrice.Size = new System.Drawing.Size(100, 20);
            this.txtOriginalPrice.TabIndex = 62;
            // 
            // lblReorderLevel
            // 
            this.lblReorderLevel.AutoSize = true;
            this.lblReorderLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReorderLevel.Location = new System.Drawing.Point(113, 201);
            this.lblReorderLevel.Name = "lblReorderLevel";
            this.lblReorderLevel.Size = new System.Drawing.Size(87, 15);
            this.lblReorderLevel.TabIndex = 61;
            this.lblReorderLevel.Text = "Reorder Level:";
            // 
            // lblPhasingOut
            // 
            this.lblPhasingOut.AutoSize = true;
            this.lblPhasingOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhasingOut.Location = new System.Drawing.Point(124, 163);
            this.lblPhasingOut.Name = "lblPhasingOut";
            this.lblPhasingOut.Size = new System.Drawing.Size(76, 15);
            this.lblPhasingOut.TabIndex = 60;
            this.lblPhasingOut.Text = "Phasing-out:";
            // 
            // lblSellingPrice
            // 
            this.lblSellingPrice.AutoSize = true;
            this.lblSellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellingPrice.Location = new System.Drawing.Point(124, 315);
            this.lblSellingPrice.Name = "lblSellingPrice";
            this.lblSellingPrice.Size = new System.Drawing.Size(79, 15);
            this.lblSellingPrice.TabIndex = 59;
            this.lblSellingPrice.Text = "Selling Price:";
            // 
            // lblOriginalPrice
            // 
            this.lblOriginalPrice.AutoSize = true;
            this.lblOriginalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalPrice.Location = new System.Drawing.Point(116, 277);
            this.lblOriginalPrice.Name = "lblOriginalPrice";
            this.lblOriginalPrice.Size = new System.Drawing.Size(84, 15);
            this.lblOriginalPrice.TabIndex = 58;
            this.lblOriginalPrice.Text = "Original Price:";
            // 
            // lblOriginalInfo
            // 
            this.lblOriginalInfo.AutoSize = true;
            this.lblOriginalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalInfo.Location = new System.Drawing.Point(184, 76);
            this.lblOriginalInfo.Name = "lblOriginalInfo";
            this.lblOriginalInfo.Size = new System.Drawing.Size(107, 20);
            this.lblOriginalInfo.TabIndex = 57;
            this.lblOriginalInfo.Text = "Original Info";
            // 
            // nudNewOriginalPrice
            // 
            this.nudNewOriginalPrice.Location = new System.Drawing.Point(541, 277);
            this.nudNewOriginalPrice.Name = "nudNewOriginalPrice";
            this.nudNewOriginalPrice.Size = new System.Drawing.Size(114, 20);
            this.nudNewOriginalPrice.TabIndex = 80;
            // 
            // lblNewOriginalPrice
            // 
            this.lblNewOriginalPrice.AutoSize = true;
            this.lblNewOriginalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewOriginalPrice.Location = new System.Drawing.Point(429, 277);
            this.lblNewOriginalPrice.Name = "lblNewOriginalPrice";
            this.lblNewOriginalPrice.Size = new System.Drawing.Size(109, 15);
            this.lblNewOriginalPrice.TabIndex = 79;
            this.lblNewOriginalPrice.Text = "New Orginal Price:";
            // 
            // tbNewName
            // 
            this.tbNewName.Location = new System.Drawing.Point(540, 125);
            this.tbNewName.Name = "tbNewName";
            this.tbNewName.Size = new System.Drawing.Size(155, 20);
            this.tbNewName.TabIndex = 82;
            // 
            // lblNewName
            // 
            this.lblNewName.AutoSize = true;
            this.lblNewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewName.Location = new System.Drawing.Point(490, 126);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(44, 15);
            this.lblNewName.TabIndex = 81;
            this.lblNewName.Text = "Name:";
            // 
            // lblNewInfo
            // 
            this.lblNewInfo.AutoSize = true;
            this.lblNewInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewInfo.Location = new System.Drawing.Point(536, 76);
            this.lblNewInfo.Name = "lblNewInfo";
            this.lblNewInfo.Size = new System.Drawing.Size(80, 20);
            this.lblNewInfo.TabIndex = 83;
            this.lblNewInfo.Text = "New Info";
            // 
            // tbStockLevel
            // 
            this.tbStockLevel.Location = new System.Drawing.Point(206, 238);
            this.tbStockLevel.Name = "tbStockLevel";
            this.tbStockLevel.ReadOnly = true;
            this.tbStockLevel.Size = new System.Drawing.Size(46, 20);
            this.tbStockLevel.TabIndex = 85;
            // 
            // lblStockLevel
            // 
            this.lblStockLevel.AutoSize = true;
            this.lblStockLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockLevel.Location = new System.Drawing.Point(128, 239);
            this.lblStockLevel.Name = "lblStockLevel";
            this.lblStockLevel.Size = new System.Drawing.Size(72, 15);
            this.lblStockLevel.TabIndex = 84;
            this.lblStockLevel.Text = "Stock Level:";
            // 
            // lblNewStockLevel
            // 
            this.lblNewStockLevel.AutoSize = true;
            this.lblNewStockLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewStockLevel.Location = new System.Drawing.Point(438, 240);
            this.lblNewStockLevel.Name = "lblNewStockLevel";
            this.lblNewStockLevel.Size = new System.Drawing.Size(100, 15);
            this.lblNewStockLevel.TabIndex = 86;
            this.lblNewStockLevel.Text = "New Stock Level:";
            // 
            // nudNewStockLevel
            // 
            this.nudNewStockLevel.Location = new System.Drawing.Point(540, 240);
            this.nudNewStockLevel.Name = "nudNewStockLevel";
            this.nudNewStockLevel.Size = new System.Drawing.Size(70, 20);
            this.nudNewStockLevel.TabIndex = 87;
            // 
            // UpdateProductAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudNewStockLevel);
            this.Controls.Add(this.lblNewStockLevel);
            this.Controls.Add(this.tbStockLevel);
            this.Controls.Add(this.lblStockLevel);
            this.Controls.Add(this.lblNewInfo);
            this.Controls.Add(this.tbNewName);
            this.Controls.Add(this.lblNewName);
            this.Controls.Add(this.nudNewOriginalPrice);
            this.Controls.Add(this.lblNewOriginalPrice);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.nudNewReorderLevel);
            this.Controls.Add(this.nudNewSellingPirce);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbPhasingOutOn);
            this.Controls.Add(this.rbPhasingOutOff);
            this.Controls.Add(this.lblOutPhasingOut);
            this.Controls.Add(this.lblNewReorderLevel);
            this.Controls.Add(this.lblNewSellingPrice);
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
            this.Name = "UpdateProductAdminForm";
            this.Text = "UpdateProductAdminForm";
            this.Shown += new System.EventHandler(this.UpdateProductAdminForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.nudNewReorderLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewSellingPirce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewOriginalPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewStockLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.NumericUpDown nudNewReorderLevel;
        private System.Windows.Forms.NumericUpDown nudNewSellingPirce;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbPhasingOutOn;
        private System.Windows.Forms.RadioButton rbPhasingOutOff;
        private System.Windows.Forms.Label lblOutPhasingOut;
        private System.Windows.Forms.Label lblNewReorderLevel;
        private System.Windows.Forms.Label lblNewSellingPrice;
        private System.Windows.Forms.Button btnUpdateInfo;
        private System.Windows.Forms.TextBox txtReorderLevel;
        private System.Windows.Forms.TextBox txtPhasingOut;
        private System.Windows.Forms.TextBox txtSellingPrice;
        private System.Windows.Forms.TextBox txtOriginalPrice;
        private System.Windows.Forms.Label lblReorderLevel;
        private System.Windows.Forms.Label lblPhasingOut;
        private System.Windows.Forms.Label lblSellingPrice;
        private System.Windows.Forms.Label lblOriginalPrice;
        private System.Windows.Forms.Label lblOriginalInfo;
        private System.Windows.Forms.NumericUpDown nudNewOriginalPrice;
        private System.Windows.Forms.Label lblNewOriginalPrice;
        private System.Windows.Forms.TextBox tbNewName;
        private System.Windows.Forms.Label lblNewName;
        private System.Windows.Forms.Label lblNewInfo;
        private System.Windows.Forms.TextBox tbStockLevel;
        private System.Windows.Forms.Label lblStockLevel;
        private System.Windows.Forms.Label lblNewStockLevel;
        private System.Windows.Forms.NumericUpDown nudNewStockLevel;
    }
}
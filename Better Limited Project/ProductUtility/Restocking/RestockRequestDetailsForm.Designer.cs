
namespace Better_Limited_Project.ProductUtility.Restocking
{
    partial class RestockRequestDetailsForm
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
            this.tbNoOfProducts = new System.Windows.Forms.TextBox();
            this.lblNoOfProducts = new System.Windows.Forms.Label();
            this.dgvRequestedGoods = new System.Windows.Forms.DataGridView();
            this.btnUnsendRequest = new System.Windows.Forms.Button();
            this.tbArrangedOn = new System.Windows.Forms.TextBox();
            this.lblArrangedOn = new System.Windows.Forms.Label();
            this.tbIsArranged = new System.Windows.Forms.TextBox();
            this.lblIsArranged = new System.Windows.Forms.Label();
            this.tbArrangedByStaffName = new System.Windows.Forms.TextBox();
            this.lblArrangedByStaffName = new System.Windows.Forms.Label();
            this.tbRequestedByStaffName = new System.Windows.Forms.TextBox();
            this.lblRequestedByStaffName = new System.Windows.Forms.Label();
            this.tbWarehouseName = new System.Windows.Forms.TextBox();
            this.lblWarehouseName = new System.Windows.Forms.Label();
            this.lblGoodsInRequest = new System.Windows.Forms.Label();
            this.tbRequestedOn = new System.Windows.Forms.TextBox();
            this.tbRequestNumber = new System.Windows.Forms.TextBox();
            this.lblRequestedOn = new System.Windows.Forms.Label();
            this.lblRequestNumber = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.requestedProductIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestedProductNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityToReorderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbGoodsReceivedOn = new System.Windows.Forms.TextBox();
            this.lblGoodsReceivedOn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestedGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNoOfProducts
            // 
            this.tbNoOfProducts.Location = new System.Drawing.Point(659, 360);
            this.tbNoOfProducts.Name = "tbNoOfProducts";
            this.tbNoOfProducts.ReadOnly = true;
            this.tbNoOfProducts.Size = new System.Drawing.Size(161, 20);
            this.tbNoOfProducts.TabIndex = 94;
            this.tbNoOfProducts.Text = "-";
            // 
            // lblNoOfProducts
            // 
            this.lblNoOfProducts.AutoSize = true;
            this.lblNoOfProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblNoOfProducts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNoOfProducts.Location = new System.Drawing.Point(656, 341);
            this.lblNoOfProducts.Name = "lblNoOfProducts";
            this.lblNoOfProducts.Size = new System.Drawing.Size(99, 16);
            this.lblNoOfProducts.TabIndex = 93;
            this.lblNoOfProducts.Text = "No. of Products";
            // 
            // dgvRequestedGoods
            // 
            this.dgvRequestedGoods.AllowUserToAddRows = false;
            this.dgvRequestedGoods.AllowUserToDeleteRows = false;
            this.dgvRequestedGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequestedGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.requestedProductIdColumn,
            this.requestedProductNameColumn,
            this.quantityToReorderColumn,
            this.categoryColumn});
            this.dgvRequestedGoods.Location = new System.Drawing.Point(356, 109);
            this.dgvRequestedGoods.Name = "dgvRequestedGoods";
            this.dgvRequestedGoods.ReadOnly = true;
            this.dgvRequestedGoods.RowTemplate.Height = 24;
            this.dgvRequestedGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvRequestedGoods.Size = new System.Drawing.Size(464, 212);
            this.dgvRequestedGoods.TabIndex = 92;
            // 
            // btnUnsendRequest
            // 
            this.btnUnsendRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUnsendRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnsendRequest.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUnsendRequest.Location = new System.Drawing.Point(24, 419);
            this.btnUnsendRequest.Name = "btnUnsendRequest";
            this.btnUnsendRequest.Size = new System.Drawing.Size(190, 37);
            this.btnUnsendRequest.TabIndex = 91;
            this.btnUnsendRequest.Text = "Unsend Request";
            this.btnUnsendRequest.UseVisualStyleBackColor = false;
            // 
            // tbArrangedOn
            // 
            this.tbArrangedOn.Location = new System.Drawing.Point(153, 360);
            this.tbArrangedOn.Name = "tbArrangedOn";
            this.tbArrangedOn.ReadOnly = true;
            this.tbArrangedOn.Size = new System.Drawing.Size(161, 20);
            this.tbArrangedOn.TabIndex = 90;
            this.tbArrangedOn.Text = "-";
            // 
            // lblArrangedOn
            // 
            this.lblArrangedOn.AutoSize = true;
            this.lblArrangedOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrangedOn.Location = new System.Drawing.Point(21, 361);
            this.lblArrangedOn.Name = "lblArrangedOn";
            this.lblArrangedOn.Size = new System.Drawing.Size(87, 16);
            this.lblArrangedOn.TabIndex = 89;
            this.lblArrangedOn.Text = "Arranged On:";
            // 
            // tbIsArranged
            // 
            this.tbIsArranged.Location = new System.Drawing.Point(153, 266);
            this.tbIsArranged.Name = "tbIsArranged";
            this.tbIsArranged.ReadOnly = true;
            this.tbIsArranged.Size = new System.Drawing.Size(161, 20);
            this.tbIsArranged.TabIndex = 88;
            // 
            // lblIsArranged
            // 
            this.lblIsArranged.AutoSize = true;
            this.lblIsArranged.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsArranged.Location = new System.Drawing.Point(21, 267);
            this.lblIsArranged.Name = "lblIsArranged";
            this.lblIsArranged.Size = new System.Drawing.Size(80, 16);
            this.lblIsArranged.TabIndex = 87;
            this.lblIsArranged.Text = "Is Arranged:";
            // 
            // tbArrangedByStaffName
            // 
            this.tbArrangedByStaffName.Location = new System.Drawing.Point(153, 313);
            this.tbArrangedByStaffName.Name = "tbArrangedByStaffName";
            this.tbArrangedByStaffName.ReadOnly = true;
            this.tbArrangedByStaffName.Size = new System.Drawing.Size(161, 20);
            this.tbArrangedByStaffName.TabIndex = 86;
            this.tbArrangedByStaffName.Text = "-";
            // 
            // lblArrangedByStaffName
            // 
            this.lblArrangedByStaffName.AutoSize = true;
            this.lblArrangedByStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrangedByStaffName.Location = new System.Drawing.Point(21, 314);
            this.lblArrangedByStaffName.Name = "lblArrangedByStaffName";
            this.lblArrangedByStaffName.Size = new System.Drawing.Size(115, 16);
            this.lblArrangedByStaffName.TabIndex = 85;
            this.lblArrangedByStaffName.Text = "Arranged By Staff:";
            // 
            // tbRequestedByStaffName
            // 
            this.tbRequestedByStaffName.Location = new System.Drawing.Point(153, 219);
            this.tbRequestedByStaffName.Name = "tbRequestedByStaffName";
            this.tbRequestedByStaffName.ReadOnly = true;
            this.tbRequestedByStaffName.Size = new System.Drawing.Size(161, 20);
            this.tbRequestedByStaffName.TabIndex = 84;
            // 
            // lblRequestedByStaffName
            // 
            this.lblRequestedByStaffName.AutoSize = true;
            this.lblRequestedByStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestedByStaffName.Location = new System.Drawing.Point(21, 220);
            this.lblRequestedByStaffName.Name = "lblRequestedByStaffName";
            this.lblRequestedByStaffName.Size = new System.Drawing.Size(126, 16);
            this.lblRequestedByStaffName.TabIndex = 83;
            this.lblRequestedByStaffName.Text = "Requested By Staff:";
            // 
            // tbWarehouseName
            // 
            this.tbWarehouseName.Location = new System.Drawing.Point(153, 172);
            this.tbWarehouseName.Name = "tbWarehouseName";
            this.tbWarehouseName.ReadOnly = true;
            this.tbWarehouseName.Size = new System.Drawing.Size(161, 20);
            this.tbWarehouseName.TabIndex = 82;
            // 
            // lblWarehouseName
            // 
            this.lblWarehouseName.AutoSize = true;
            this.lblWarehouseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarehouseName.Location = new System.Drawing.Point(21, 173);
            this.lblWarehouseName.Name = "lblWarehouseName";
            this.lblWarehouseName.Size = new System.Drawing.Size(81, 16);
            this.lblWarehouseName.TabIndex = 81;
            this.lblWarehouseName.Text = "Warehouse:";
            // 
            // lblGoodsInRequest
            // 
            this.lblGoodsInRequest.AutoSize = true;
            this.lblGoodsInRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoodsInRequest.Location = new System.Drawing.Point(503, 75);
            this.lblGoodsInRequest.Name = "lblGoodsInRequest";
            this.lblGoodsInRequest.Size = new System.Drawing.Size(155, 20);
            this.lblGoodsInRequest.TabIndex = 80;
            this.lblGoodsInRequest.Text = "Requested Goods";
            // 
            // tbRequestedOn
            // 
            this.tbRequestedOn.Location = new System.Drawing.Point(153, 125);
            this.tbRequestedOn.Name = "tbRequestedOn";
            this.tbRequestedOn.ReadOnly = true;
            this.tbRequestedOn.Size = new System.Drawing.Size(161, 20);
            this.tbRequestedOn.TabIndex = 79;
            // 
            // tbRequestNumber
            // 
            this.tbRequestNumber.Location = new System.Drawing.Point(153, 78);
            this.tbRequestNumber.Name = "tbRequestNumber";
            this.tbRequestNumber.ReadOnly = true;
            this.tbRequestNumber.Size = new System.Drawing.Size(161, 20);
            this.tbRequestNumber.TabIndex = 78;
            // 
            // lblRequestedOn
            // 
            this.lblRequestedOn.AutoSize = true;
            this.lblRequestedOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestedOn.Location = new System.Drawing.Point(21, 126);
            this.lblRequestedOn.Name = "lblRequestedOn";
            this.lblRequestedOn.Size = new System.Drawing.Size(98, 16);
            this.lblRequestedOn.TabIndex = 77;
            this.lblRequestedOn.Text = "Requested On:";
            // 
            // lblRequestNumber
            // 
            this.lblRequestNumber.AutoSize = true;
            this.lblRequestNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestNumber.Location = new System.Drawing.Point(21, 79);
            this.lblRequestNumber.Name = "lblRequestNumber";
            this.lblRequestNumber.Size = new System.Drawing.Size(113, 16);
            this.lblRequestNumber.TabIndex = 76;
            this.lblRequestNumber.Text = "Request Number:";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(265, 21);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(315, 25);
            this.lblHeader.TabIndex = 75;
            this.lblHeader.Text = "Restock Request Information";
            // 
            // requestedProductIdColumn
            // 
            this.requestedProductIdColumn.HeaderText = "id";
            this.requestedProductIdColumn.Name = "requestedProductIdColumn";
            this.requestedProductIdColumn.ReadOnly = true;
            this.requestedProductIdColumn.Visible = false;
            // 
            // requestedProductNameColumn
            // 
            this.requestedProductNameColumn.HeaderText = "Product";
            this.requestedProductNameColumn.Name = "requestedProductNameColumn";
            this.requestedProductNameColumn.ReadOnly = true;
            this.requestedProductNameColumn.Width = 180;
            // 
            // quantityToReorderColumn
            // 
            this.quantityToReorderColumn.HeaderText = "Qty To Reorder";
            this.quantityToReorderColumn.Name = "quantityToReorderColumn";
            this.quantityToReorderColumn.ReadOnly = true;
            this.quantityToReorderColumn.Width = 120;
            // 
            // categoryColumn
            // 
            this.categoryColumn.HeaderText = "Category";
            this.categoryColumn.Name = "categoryColumn";
            this.categoryColumn.ReadOnly = true;
            this.categoryColumn.Width = 120;
            // 
            // tbGoodsReceivedOn
            // 
            this.tbGoodsReceivedOn.Location = new System.Drawing.Point(367, 360);
            this.tbGoodsReceivedOn.Name = "tbGoodsReceivedOn";
            this.tbGoodsReceivedOn.ReadOnly = true;
            this.tbGoodsReceivedOn.Size = new System.Drawing.Size(161, 20);
            this.tbGoodsReceivedOn.TabIndex = 96;
            this.tbGoodsReceivedOn.Text = "-";
            // 
            // lblGoodsReceivedOn
            // 
            this.lblGoodsReceivedOn.AutoSize = true;
            this.lblGoodsReceivedOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoodsReceivedOn.Location = new System.Drawing.Point(364, 341);
            this.lblGoodsReceivedOn.Name = "lblGoodsReceivedOn";
            this.lblGoodsReceivedOn.Size = new System.Drawing.Size(131, 16);
            this.lblGoodsReceivedOn.TabIndex = 95;
            this.lblGoodsReceivedOn.Text = "Goods Received On";
            // 
            // RestockRequestDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 475);
            this.Controls.Add(this.tbGoodsReceivedOn);
            this.Controls.Add(this.lblGoodsReceivedOn);
            this.Controls.Add(this.tbNoOfProducts);
            this.Controls.Add(this.lblNoOfProducts);
            this.Controls.Add(this.dgvRequestedGoods);
            this.Controls.Add(this.btnUnsendRequest);
            this.Controls.Add(this.tbArrangedOn);
            this.Controls.Add(this.lblArrangedOn);
            this.Controls.Add(this.tbIsArranged);
            this.Controls.Add(this.lblIsArranged);
            this.Controls.Add(this.tbArrangedByStaffName);
            this.Controls.Add(this.lblArrangedByStaffName);
            this.Controls.Add(this.tbRequestedByStaffName);
            this.Controls.Add(this.lblRequestedByStaffName);
            this.Controls.Add(this.tbWarehouseName);
            this.Controls.Add(this.lblWarehouseName);
            this.Controls.Add(this.lblGoodsInRequest);
            this.Controls.Add(this.tbRequestedOn);
            this.Controls.Add(this.tbRequestNumber);
            this.Controls.Add(this.lblRequestedOn);
            this.Controls.Add(this.lblRequestNumber);
            this.Controls.Add(this.lblHeader);
            this.Name = "RestockRequestDetailsForm";
            this.Text = "RestockRequestDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestedGoods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbNoOfProducts;
        private System.Windows.Forms.Label lblNoOfProducts;
        private System.Windows.Forms.DataGridView dgvRequestedGoods;
        private System.Windows.Forms.Button btnUnsendRequest;
        private System.Windows.Forms.TextBox tbArrangedOn;
        private System.Windows.Forms.Label lblArrangedOn;
        private System.Windows.Forms.TextBox tbIsArranged;
        private System.Windows.Forms.Label lblIsArranged;
        private System.Windows.Forms.TextBox tbArrangedByStaffName;
        private System.Windows.Forms.Label lblArrangedByStaffName;
        private System.Windows.Forms.TextBox tbRequestedByStaffName;
        private System.Windows.Forms.Label lblRequestedByStaffName;
        private System.Windows.Forms.TextBox tbWarehouseName;
        private System.Windows.Forms.Label lblWarehouseName;
        private System.Windows.Forms.Label lblGoodsInRequest;
        private System.Windows.Forms.TextBox tbRequestedOn;
        private System.Windows.Forms.TextBox tbRequestNumber;
        private System.Windows.Forms.Label lblRequestedOn;
        private System.Windows.Forms.Label lblRequestNumber;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestedProductIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestedProductNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityToReorderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryColumn;
        private System.Windows.Forms.TextBox tbGoodsReceivedOn;
        private System.Windows.Forms.Label lblGoodsReceivedOn;
    }
}
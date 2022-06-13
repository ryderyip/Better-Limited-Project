
namespace Better_Limited_Project.ProductUtility.InwardGoodsUtility.UI
{
    partial class InwardGoodsRecordListForm
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
            this.dgvInwardGoods = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedOnColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAllGoodsReceivedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbSearchBox = new System.Windows.Forms.TextBox();
            this.lblSearchBox = new System.Windows.Forms.Label();
            this.btnReceiveGoods = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInwardGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInwardGoods
            // 
            this.dgvInwardGoods.AllowUserToAddRows = false;
            this.dgvInwardGoods.AllowUserToDeleteRows = false;
            this.dgvInwardGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInwardGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.purchaseOrderNumber,
            this.receivedOnColumn,
            this.isAllGoodsReceivedColumn});
            this.dgvInwardGoods.Location = new System.Drawing.Point(27, 80);
            this.dgvInwardGoods.Name = "dgvInwardGoods";
            this.dgvInwardGoods.ReadOnly = true;
            this.dgvInwardGoods.RowTemplate.Height = 24;
            this.dgvInwardGoods.Size = new System.Drawing.Size(534, 347);
            this.dgvInwardGoods.TabIndex = 14;
            this.dgvInwardGoods.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInwardGoods_CellDoubleClick);
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "id";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Visible = false;
            // 
            // purchaseOrderNumber
            // 
            this.purchaseOrderNumber.HeaderText = "Purchase Order No.";
            this.purchaseOrderNumber.Name = "purchaseOrderNumber";
            this.purchaseOrderNumber.ReadOnly = true;
            this.purchaseOrderNumber.Width = 140;
            // 
            // receivedOnColumn
            // 
            this.receivedOnColumn.HeaderText = "Received On";
            this.receivedOnColumn.Name = "receivedOnColumn";
            this.receivedOnColumn.ReadOnly = true;
            this.receivedOnColumn.Width = 140;
            // 
            // isAllGoodsReceivedColumn
            // 
            this.isAllGoodsReceivedColumn.HeaderText = "All Goods Received";
            this.isAllGoodsReceivedColumn.Name = "isAllGoodsReceivedColumn";
            this.isAllGoodsReceivedColumn.ReadOnly = true;
            this.isAllGoodsReceivedColumn.Width = 140;
            // 
            // tbSearchBox
            // 
            this.tbSearchBox.Location = new System.Drawing.Point(27, 35);
            this.tbSearchBox.Name = "tbSearchBox";
            this.tbSearchBox.Size = new System.Drawing.Size(252, 20);
            this.tbSearchBox.TabIndex = 13;
            // 
            // lblSearchBox
            // 
            this.lblSearchBox.AutoSize = true;
            this.lblSearchBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSearchBox.Location = new System.Drawing.Point(24, 19);
            this.lblSearchBox.Name = "lblSearchBox";
            this.lblSearchBox.Size = new System.Drawing.Size(152, 13);
            this.lblSearchBox.TabIndex = 12;
            this.lblSearchBox.Text = "Search by Purchase Order No.";
            // 
            // btnReceiveGoods
            // 
            this.btnReceiveGoods.BackColor = System.Drawing.Color.DarkOrange;
            this.btnReceiveGoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnReceiveGoods.ForeColor = System.Drawing.SystemColors.Window;
            this.btnReceiveGoods.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnReceiveGoods.Location = new System.Drawing.Point(400, 19);
            this.btnReceiveGoods.Name = "btnReceiveGoods";
            this.btnReceiveGoods.Size = new System.Drawing.Size(161, 47);
            this.btnReceiveGoods.TabIndex = 56;
            this.btnReceiveGoods.Text = "Receive Goods";
            this.btnReceiveGoods.UseVisualStyleBackColor = false;
            this.btnReceiveGoods.Click += new System.EventHandler(this.btnNewRecord_Click);
            // 
            // InwardGoodsRecordListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 450);
            this.Controls.Add(this.btnReceiveGoods);
            this.Controls.Add(this.dgvInwardGoods);
            this.Controls.Add(this.tbSearchBox);
            this.Controls.Add(this.lblSearchBox);
            this.Name = "InwardGoodsRecordListForm";
            this.Text = "InwardGoodsRecordListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInwardGoods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvInwardGoods;
        public System.Windows.Forms.TextBox tbSearchBox;
        private System.Windows.Forms.Label lblSearchBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedOnColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isAllGoodsReceivedColumn;
        private System.Windows.Forms.Button btnReceiveGoods;
    }
}
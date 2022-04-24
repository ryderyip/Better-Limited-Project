namespace Better_Limited_Project.ProductUtility.GoodsReturning
{
    partial class GoodsReturnedForm
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.vScrollBar = new System.Windows.Forms.VScrollBar();
            this.hScrollBar = new System.Windows.Forms.HScrollBar();
            this.dgvGoodsReceived = new System.Windows.Forms.DataGridView();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblSearchDate = new System.Windows.Forms.Label();
            this.txtSearchKeywords = new System.Windows.Forms.TextBox();
            this.lblSearchKeywords = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsReceived)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCreate.Location = new System.Drawing.Point(646, 79);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(85, 32);
            this.btnCreate.TabIndex = 54;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Visible = false;
            // 
            // vScrollBar
            // 
            this.vScrollBar.Location = new System.Drawing.Point(590, 146);
            this.vScrollBar.Name = "vScrollBar";
            this.vScrollBar.Size = new System.Drawing.Size(18, 245);
            this.vScrollBar.TabIndex = 53;
            // 
            // hScrollBar
            // 
            this.hScrollBar.Location = new System.Drawing.Point(72, 372);
            this.hScrollBar.Name = "hScrollBar";
            this.hScrollBar.Size = new System.Drawing.Size(518, 18);
            this.hScrollBar.TabIndex = 52;
            // 
            // dgvGoodsReceived
            // 
            this.dgvGoodsReceived.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoodsReceived.Location = new System.Drawing.Point(72, 146);
            this.dgvGoodsReceived.Name = "dgvGoodsReceived";
            this.dgvGoodsReceived.RowTemplate.Height = 24;
            this.dgvGoodsReceived.Size = new System.Drawing.Size(536, 245);
            this.dgvGoodsReceived.TabIndex = 51;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(408, 84);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 50;
            // 
            // lblSearchDate
            // 
            this.lblSearchDate.AutoSize = true;
            this.lblSearchDate.Location = new System.Drawing.Point(406, 60);
            this.lblSearchDate.Name = "lblSearchDate";
            this.lblSearchDate.Size = new System.Drawing.Size(114, 12);
            this.lblSearchDate.TabIndex = 49;
            this.lblSearchDate.Text = "Search by Date Created";
            // 
            // txtSearchKeywords
            // 
            this.txtSearchKeywords.Location = new System.Drawing.Point(72, 85);
            this.txtSearchKeywords.Name = "txtSearchKeywords";
            this.txtSearchKeywords.Size = new System.Drawing.Size(192, 22);
            this.txtSearchKeywords.TabIndex = 48;
            // 
            // lblSearchKeywords
            // 
            this.lblSearchKeywords.AutoSize = true;
            this.lblSearchKeywords.Location = new System.Drawing.Point(70, 60);
            this.lblSearchKeywords.Name = "lblSearchKeywords";
            this.lblSearchKeywords.Size = new System.Drawing.Size(109, 12);
            this.lblSearchKeywords.TabIndex = 47;
            this.lblSearchKeywords.Text = "Search by Warehouse ";
            // 
            // GoodsReturnedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.vScrollBar);
            this.Controls.Add(this.hScrollBar);
            this.Controls.Add(this.dgvGoodsReceived);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.lblSearchDate);
            this.Controls.Add(this.txtSearchKeywords);
            this.Controls.Add(this.lblSearchKeywords);
            this.Name = "GoodsReturnedForm";
            this.Text = "GoodsReturnedForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsReceived)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.VScrollBar vScrollBar;
        private System.Windows.Forms.HScrollBar hScrollBar;
        private System.Windows.Forms.DataGridView dgvGoodsReceived;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lblSearchDate;
        private System.Windows.Forms.TextBox txtSearchKeywords;
        private System.Windows.Forms.Label lblSearchKeywords;
    }
}
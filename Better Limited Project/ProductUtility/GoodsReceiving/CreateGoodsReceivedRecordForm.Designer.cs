namespace Better_Limited_Project.ProductUtility.GoodsReceiving
{
    partial class CreateGoodsReceivedRecordForm
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
            this.lblSearchKeywords = new System.Windows.Forms.Label();
            this.txtSearchKeywords = new System.Windows.Forms.TextBox();
            this.dgvGoodsReceivedList = new System.Windows.Forms.DataGridView();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsReceivedList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearchKeywords
            // 
            this.lblSearchKeywords.AutoSize = true;
            this.lblSearchKeywords.Location = new System.Drawing.Point(140, 63);
            this.lblSearchKeywords.Name = "lblSearchKeywords";
            this.lblSearchKeywords.Size = new System.Drawing.Size(210, 12);
            this.lblSearchKeywords.TabIndex = 6;
            this.lblSearchKeywords.Text = "Find Goods Received Order by Order Name";
            // 
            // txtSearchKeywords
            // 
            this.txtSearchKeywords.Location = new System.Drawing.Point(142, 90);
            this.txtSearchKeywords.Name = "txtSearchKeywords";
            this.txtSearchKeywords.Size = new System.Drawing.Size(275, 22);
            this.txtSearchKeywords.TabIndex = 7;
            // 
            // dgvGoodsReceivedList
            // 
            this.dgvGoodsReceivedList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoodsReceivedList.Location = new System.Drawing.Point(142, 150);
            this.dgvGoodsReceivedList.Name = "dgvGoodsReceivedList";
            this.dgvGoodsReceivedList.RowTemplate.Height = 24;
            this.dgvGoodsReceivedList.Size = new System.Drawing.Size(487, 136);
            this.dgvGoodsReceivedList.TabIndex = 8;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCreate.Location = new System.Drawing.Point(332, 319);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(85, 32);
            this.btnCreate.TabIndex = 47;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCancel.Location = new System.Drawing.Point(332, 370);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 33);
            this.btnCancel.TabIndex = 48;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // CreateGoodsReceivedRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dgvGoodsReceivedList);
            this.Controls.Add(this.txtSearchKeywords);
            this.Controls.Add(this.lblSearchKeywords);
            this.Name = "CreateGoodsReceivedRecordForm";
            this.Text = "CreateGoodsReceivedRecordForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsReceivedList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchKeywords;
        private System.Windows.Forms.TextBox txtSearchKeywords;
        private System.Windows.Forms.DataGridView dgvGoodsReceivedList;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
    }
}
namespace Better_Limited_Project.ServieUtility.Reordering
{
    partial class ReorderRequestForm
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblSearchDate = new System.Windows.Forms.Label();
            this.txtSearchKeywords = new System.Windows.Forms.TextBox();
            this.lblSearchKeywords = new System.Windows.Forms.Label();
            this.dgvReorderRequest = new System.Windows.Forms.DataGridView();
            this.btnCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReorderRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(402, 81);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 54;
            // 
            // lblSearchDate
            // 
            this.lblSearchDate.AutoSize = true;
            this.lblSearchDate.Location = new System.Drawing.Point(400, 57);
            this.lblSearchDate.Name = "lblSearchDate";
            this.lblSearchDate.Size = new System.Drawing.Size(129, 12);
            this.lblSearchDate.TabIndex = 53;
            this.lblSearchDate.Text = "Or Search by Date Created";
            // 
            // txtSearchKeywords
            // 
            this.txtSearchKeywords.Location = new System.Drawing.Point(66, 82);
            this.txtSearchKeywords.Name = "txtSearchKeywords";
            this.txtSearchKeywords.Size = new System.Drawing.Size(192, 22);
            this.txtSearchKeywords.TabIndex = 52;
            // 
            // lblSearchKeywords
            // 
            this.lblSearchKeywords.AutoSize = true;
            this.lblSearchKeywords.Location = new System.Drawing.Point(64, 57);
            this.lblSearchKeywords.Name = "lblSearchKeywords";
            this.lblSearchKeywords.Size = new System.Drawing.Size(120, 12);
            this.lblSearchKeywords.TabIndex = 51;
            this.lblSearchKeywords.Text = "Search by Product Name";
            // 
            // dgvReorderRequest
            // 
            this.dgvReorderRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReorderRequest.Location = new System.Drawing.Point(66, 139);
            this.dgvReorderRequest.Name = "dgvReorderRequest";
            this.dgvReorderRequest.RowTemplate.Height = 24;
            this.dgvReorderRequest.Size = new System.Drawing.Size(536, 245);
            this.dgvReorderRequest.TabIndex = 55;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCreate.Location = new System.Drawing.Point(663, 72);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(85, 32);
            this.btnCreate.TabIndex = 56;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Visible = false;
            // 
            // ReorderRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dgvReorderRequest);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.lblSearchDate);
            this.Controls.Add(this.txtSearchKeywords);
            this.Controls.Add(this.lblSearchKeywords);
            this.Name = "ReorderRequestForm";
            this.Text = "ReorderRequestForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReorderRequest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lblSearchDate;
        private System.Windows.Forms.TextBox txtSearchKeywords;
        private System.Windows.Forms.Label lblSearchKeywords;
        private System.Windows.Forms.DataGridView dgvReorderRequest;
        private System.Windows.Forms.Button btnCreate;
    }
}
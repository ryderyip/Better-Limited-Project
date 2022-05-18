namespace Better_Limited_Project.Sales.Sales.SalesOrder.CustomerRecord
{
    partial class FindCustomerRecordForm
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
            this.lblRemind = new System.Windows.Forms.Label();
            this.txtSearchKeywords = new System.Windows.Forms.TextBox();
            this.dgvCustomerList = new System.Windows.Forms.DataGridView();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.dgvCustomerList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearchKeywords
            // 
            this.lblSearchKeywords.AutoSize = true;
            this.lblSearchKeywords.Location = new System.Drawing.Point(337, 179);
            this.lblSearchKeywords.Name = "lblSearchKeywords";
            this.lblSearchKeywords.Size = new System.Drawing.Size(283, 13);
            this.lblSearchKeywords.TabIndex = 6;
            this.lblSearchKeywords.Text = "Search by Customer Name/Phone Number/ Email Address";
            // 
            // lblRemind
            // 
            this.lblRemind.AutoSize = true;
            this.lblRemind.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblRemind.Location = new System.Drawing.Point(352, 41);
            this.lblRemind.Name = "lblRemind";
            this.lblRemind.Size = new System.Drawing.Size(471, 26);
            this.lblRemind.TabIndex = 7;
            this.lblRemind.Text = "Please Find and Select a Customer Record";
            // 
            // txtSearchKeywords
            // 
            this.txtSearchKeywords.Location = new System.Drawing.Point(339, 212);
            this.txtSearchKeywords.Name = "txtSearchKeywords";
            this.txtSearchKeywords.Size = new System.Drawing.Size(207, 20);
            this.txtSearchKeywords.TabIndex = 8;
            this.txtSearchKeywords.TextChanged += new System.EventHandler(this.txtSearchKeywords_TextChanged);
            // 
            // dgvCustomerList
            // 
            this.dgvCustomerList.AllowUserToAddRows = false;
            this.dgvCustomerList.AllowUserToDeleteRows = false;
            this.dgvCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerList.Location = new System.Drawing.Point(339, 268);
            this.dgvCustomerList.MultiSelect = false;
            this.dgvCustomerList.Name = "dgvCustomerList";
            this.dgvCustomerList.ReadOnly = true;
            this.dgvCustomerList.RowTemplate.Height = 24;
            this.dgvCustomerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerList.Size = new System.Drawing.Size(448, 180);
            this.dgvCustomerList.TabIndex = 9;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNext.Location = new System.Drawing.Point(583, 483);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(86, 36);
            this.btnNext.TabIndex = 109;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Clicked);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBack.Location = new System.Drawing.Point(436, 483);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 36);
            this.btnBack.TabIndex = 110;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // FindCustomerRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.dgvCustomerList);
            this.Controls.Add(this.txtSearchKeywords);
            this.Controls.Add(this.lblRemind);
            this.Controls.Add(this.lblSearchKeywords);
            this.Name = "FindCustomerRecordForm";
            this.Text = "FindCustomerRecordForm";
            this.Shown += new System.EventHandler(this.OnFormShown);
            ((System.ComponentModel.ISupportInitialize) (this.dgvCustomerList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public System.Windows.Forms.Button btnBack;

        private System.Windows.Forms.Button button1;

        public System.Windows.Forms.Button btnNext;

        #endregion

        private System.Windows.Forms.Label lblSearchKeywords;
        private System.Windows.Forms.Label lblRemind;
        private System.Windows.Forms.TextBox txtSearchKeywords;
        private System.Windows.Forms.DataGridView dgvCustomerList;
        private System.Windows.Forms.Button button2;
    }
}
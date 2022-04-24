namespace Better_Limited_Project.ServieUtility.Installation
{
    partial class CreateInstallationDutyRecordForm
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
            this.dgvProductsDelivered = new System.Windows.Forms.DataGridView();
            this.lblProductsDelivered = new System.Windows.Forms.Label();
            this.dgvSearchList = new System.Windows.Forms.DataGridView();
            this.txtSearchKeywords = new System.Windows.Forms.TextBox();
            this.lblSearchKeywords = new System.Windows.Forms.Label();
            this.lblSelectFinished = new System.Windows.Forms.Label();
            this.comboBoxSelectFinished = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsDelivered)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCreate.Location = new System.Drawing.Point(354, 346);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(89, 32);
            this.btnCreate.TabIndex = 124;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Visible = false;
            // 
            // dgvProductsDelivered
            // 
            this.dgvProductsDelivered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsDelivered.Location = new System.Drawing.Point(433, 85);
            this.dgvProductsDelivered.Name = "dgvProductsDelivered";
            this.dgvProductsDelivered.RowTemplate.Height = 24;
            this.dgvProductsDelivered.Size = new System.Drawing.Size(346, 181);
            this.dgvProductsDelivered.TabIndex = 123;
            // 
            // lblProductsDelivered
            // 
            this.lblProductsDelivered.AutoSize = true;
            this.lblProductsDelivered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductsDelivered.Location = new System.Drawing.Point(490, 43);
            this.lblProductsDelivered.Name = "lblProductsDelivered";
            this.lblProductsDelivered.Size = new System.Drawing.Size(203, 20);
            this.lblProductsDelivered.TabIndex = 122;
            this.lblProductsDelivered.Text = "Products to be delivered";
            // 
            // dgvSearchList
            // 
            this.dgvSearchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchList.Location = new System.Drawing.Point(28, 85);
            this.dgvSearchList.Name = "dgvSearchList";
            this.dgvSearchList.RowTemplate.Height = 24;
            this.dgvSearchList.Size = new System.Drawing.Size(357, 181);
            this.dgvSearchList.TabIndex = 121;
            // 
            // txtSearchKeywords
            // 
            this.txtSearchKeywords.Location = new System.Drawing.Point(28, 46);
            this.txtSearchKeywords.Name = "txtSearchKeywords";
            this.txtSearchKeywords.Size = new System.Drawing.Size(174, 22);
            this.txtSearchKeywords.TabIndex = 120;
            // 
            // lblSearchKeywords
            // 
            this.lblSearchKeywords.AutoSize = true;
            this.lblSearchKeywords.Location = new System.Drawing.Point(26, 22);
            this.lblSearchKeywords.Name = "lblSearchKeywords";
            this.lblSearchKeywords.Size = new System.Drawing.Size(175, 12);
            this.lblSearchKeywords.TabIndex = 119;
            this.lblSearchKeywords.Text = "Find Installation Task by Staff Name";
            // 
            // lblSelectFinished
            // 
            this.lblSelectFinished.AutoSize = true;
            this.lblSelectFinished.Location = new System.Drawing.Point(26, 292);
            this.lblSelectFinished.Name = "lblSelectFinished";
            this.lblSelectFinished.Size = new System.Drawing.Size(116, 12);
            this.lblSelectFinished.TabIndex = 125;
            this.lblSelectFinished.Text = "Select Duty Finish Time";
            // 
            // comboBoxSelectFinished
            // 
            this.comboBoxSelectFinished.FormattingEnabled = true;
            this.comboBoxSelectFinished.Location = new System.Drawing.Point(28, 317);
            this.comboBoxSelectFinished.Name = "comboBoxSelectFinished";
            this.comboBoxSelectFinished.Size = new System.Drawing.Size(121, 20);
            this.comboBoxSelectFinished.TabIndex = 126;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCancel.Location = new System.Drawing.Point(354, 384);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 33);
            this.btnCancel.TabIndex = 127;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // CreateInstallationDutyRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.comboBoxSelectFinished);
            this.Controls.Add(this.lblSelectFinished);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dgvProductsDelivered);
            this.Controls.Add(this.lblProductsDelivered);
            this.Controls.Add(this.dgvSearchList);
            this.Controls.Add(this.txtSearchKeywords);
            this.Controls.Add(this.lblSearchKeywords);
            this.Name = "CreateInstallationDutyRecordForm";
            this.Text = "CreateInstallationDutyRecordForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsDelivered)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridView dgvProductsDelivered;
        private System.Windows.Forms.Label lblProductsDelivered;
        private System.Windows.Forms.DataGridView dgvSearchList;
        private System.Windows.Forms.TextBox txtSearchKeywords;
        private System.Windows.Forms.Label lblSearchKeywords;
        private System.Windows.Forms.Label lblSelectFinished;
        private System.Windows.Forms.ComboBox comboBoxSelectFinished;
        private System.Windows.Forms.Button btnCancel;
    }
}
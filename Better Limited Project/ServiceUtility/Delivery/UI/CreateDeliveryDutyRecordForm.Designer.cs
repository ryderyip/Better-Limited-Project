namespace Better_Limited_Project.ServiceUtility.Delivery.UI
{
    partial class CreateDeliveryDutyRecordForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.comboBoxSelectFinished = new System.Windows.Forms.ComboBox();
            this.lblSelectFinished = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dgvProductsInstalled = new System.Windows.Forms.DataGridView();
            this.lblProductsInstalled = new System.Windows.Forms.Label();
            this.dgvSearchList = new System.Windows.Forms.DataGridView();
            this.txtSearchKeywords = new System.Windows.Forms.TextBox();
            this.lblSearchKeywords = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsInstalled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCancel.Location = new System.Drawing.Point(352, 390);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 33);
            this.btnCancel.TabIndex = 136;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // comboBoxSelectFinished
            // 
            this.comboBoxSelectFinished.FormattingEnabled = true;
            this.comboBoxSelectFinished.Location = new System.Drawing.Point(26, 323);
            this.comboBoxSelectFinished.Name = "comboBoxSelectFinished";
            this.comboBoxSelectFinished.Size = new System.Drawing.Size(121, 20);
            this.comboBoxSelectFinished.TabIndex = 135;
            // 
            // lblSelectFinished
            // 
            this.lblSelectFinished.AutoSize = true;
            this.lblSelectFinished.Location = new System.Drawing.Point(24, 298);
            this.lblSelectFinished.Name = "lblSelectFinished";
            this.lblSelectFinished.Size = new System.Drawing.Size(116, 12);
            this.lblSelectFinished.TabIndex = 134;
            this.lblSelectFinished.Text = "Select Duty Finish Time";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCreate.Location = new System.Drawing.Point(352, 352);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(89, 32);
            this.btnCreate.TabIndex = 133;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Visible = false;
            // 
            // dgvProductsInstalled
            // 
            this.dgvProductsInstalled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsInstalled.Location = new System.Drawing.Point(431, 91);
            this.dgvProductsInstalled.Name = "dgvProductsInstalled";
            this.dgvProductsInstalled.RowTemplate.Height = 24;
            this.dgvProductsInstalled.Size = new System.Drawing.Size(346, 181);
            this.dgvProductsInstalled.TabIndex = 132;
            // 
            // lblProductsInstalled
            // 
            this.lblProductsInstalled.AutoSize = true;
            this.lblProductsInstalled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductsInstalled.Location = new System.Drawing.Point(506, 49);
            this.lblProductsInstalled.Name = "lblProductsInstalled";
            this.lblProductsInstalled.Size = new System.Drawing.Size(154, 20);
            this.lblProductsInstalled.TabIndex = 131;
            this.lblProductsInstalled.Text = "Products Installed";
            // 
            // dgvSearchList
            // 
            this.dgvSearchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchList.Location = new System.Drawing.Point(26, 91);
            this.dgvSearchList.Name = "dgvSearchList";
            this.dgvSearchList.RowTemplate.Height = 24;
            this.dgvSearchList.Size = new System.Drawing.Size(357, 181);
            this.dgvSearchList.TabIndex = 130;
            // 
            // txtSearchKeywords
            // 
            this.txtSearchKeywords.Location = new System.Drawing.Point(26, 52);
            this.txtSearchKeywords.Name = "txtSearchKeywords";
            this.txtSearchKeywords.Size = new System.Drawing.Size(174, 22);
            this.txtSearchKeywords.TabIndex = 129;
            // 
            // lblSearchKeywords
            // 
            this.lblSearchKeywords.AutoSize = true;
            this.lblSearchKeywords.Location = new System.Drawing.Point(24, 28);
            this.lblSearchKeywords.Name = "lblSearchKeywords";
            this.lblSearchKeywords.Size = new System.Drawing.Size(175, 12);
            this.lblSearchKeywords.TabIndex = 128;
            this.lblSearchKeywords.Text = "Find Installation Task by Staff Name";
            // 
            // CreateDeliveryDutyRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.comboBoxSelectFinished);
            this.Controls.Add(this.lblSelectFinished);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dgvProductsInstalled);
            this.Controls.Add(this.lblProductsInstalled);
            this.Controls.Add(this.dgvSearchList);
            this.Controls.Add(this.txtSearchKeywords);
            this.Controls.Add(this.lblSearchKeywords);
            this.Name = "CreateDeliveryDutyRecordForm";
            this.Text = "CreateDeliveryDutyRecordForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsInstalled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox comboBoxSelectFinished;
        private System.Windows.Forms.Label lblSelectFinished;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridView dgvProductsInstalled;
        private System.Windows.Forms.Label lblProductsInstalled;
        private System.Windows.Forms.DataGridView dgvSearchList;
        private System.Windows.Forms.TextBox txtSearchKeywords;
        private System.Windows.Forms.Label lblSearchKeywords;
    }
}
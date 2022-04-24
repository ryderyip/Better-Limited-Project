namespace Better_Limited_Project.ServieUtility.Reordering
{
    partial class ReorderRequestSendingForm
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
            this.btnSendReorderRequest = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvAmtToChangeList = new System.Windows.Forms.DataGridView();
            this.txtAmtToChange = new System.Windows.Forms.TextBox();
            this.lblAmtToChange = new System.Windows.Forms.Label();
            this.dgvSearchList = new System.Windows.Forms.DataGridView();
            this.txtSearchKeywords = new System.Windows.Forms.TextBox();
            this.lblSearchKeywords = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmtToChangeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCancel.Location = new System.Drawing.Point(334, 384);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 41);
            this.btnCancel.TabIndex = 58;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSendReorderRequest
            // 
            this.btnSendReorderRequest.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSendReorderRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendReorderRequest.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSendReorderRequest.Location = new System.Drawing.Point(285, 328);
            this.btnSendReorderRequest.Name = "btnSendReorderRequest";
            this.btnSendReorderRequest.Size = new System.Drawing.Size(213, 41);
            this.btnSendReorderRequest.TabIndex = 57;
            this.btnSendReorderRequest.Text = "Send Reorder Request";
            this.btnSendReorderRequest.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Window;
            this.btnClear.Location = new System.Drawing.Point(668, 221);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 41);
            this.btnClear.TabIndex = 56;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRemove.Location = new System.Drawing.Point(677, 49);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(97, 34);
            this.btnRemove.TabIndex = 55;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAdd.Location = new System.Drawing.Point(598, 49);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(73, 34);
            this.btnAdd.TabIndex = 54;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // dgvAmtToChangeList
            // 
            this.dgvAmtToChangeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmtToChangeList.Location = new System.Drawing.Point(436, 108);
            this.dgvAmtToChangeList.Name = "dgvAmtToChangeList";
            this.dgvAmtToChangeList.RowTemplate.Height = 24;
            this.dgvAmtToChangeList.Size = new System.Drawing.Size(338, 51);
            this.dgvAmtToChangeList.TabIndex = 53;
            // 
            // txtAmtToChange
            // 
            this.txtAmtToChange.Location = new System.Drawing.Point(436, 56);
            this.txtAmtToChange.Name = "txtAmtToChange";
            this.txtAmtToChange.Size = new System.Drawing.Size(141, 22);
            this.txtAmtToChange.TabIndex = 52;
            // 
            // lblAmtToChange
            // 
            this.lblAmtToChange.AutoSize = true;
            this.lblAmtToChange.Location = new System.Drawing.Point(434, 32);
            this.lblAmtToChange.Name = "lblAmtToChange";
            this.lblAmtToChange.Size = new System.Drawing.Size(98, 12);
            this.lblAmtToChange.TabIndex = 51;
            this.lblAmtToChange.Text = "Amount To Change";
            // 
            // dgvSearchList
            // 
            this.dgvSearchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchList.Location = new System.Drawing.Point(29, 101);
            this.dgvSearchList.Name = "dgvSearchList";
            this.dgvSearchList.RowTemplate.Height = 24;
            this.dgvSearchList.Size = new System.Drawing.Size(357, 181);
            this.dgvSearchList.TabIndex = 50;
            // 
            // txtSearchKeywords
            // 
            this.txtSearchKeywords.Location = new System.Drawing.Point(29, 49);
            this.txtSearchKeywords.Name = "txtSearchKeywords";
            this.txtSearchKeywords.Size = new System.Drawing.Size(174, 22);
            this.txtSearchKeywords.TabIndex = 49;
            // 
            // lblSearchKeywords
            // 
            this.lblSearchKeywords.AutoSize = true;
            this.lblSearchKeywords.Location = new System.Drawing.Point(27, 25);
            this.lblSearchKeywords.Name = "lblSearchKeywords";
            this.lblSearchKeywords.Size = new System.Drawing.Size(120, 12);
            this.lblSearchKeywords.TabIndex = 48;
            this.lblSearchKeywords.Text = "Search by Product Name";
            // 
            // ReorderRequestSendingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSendReorderRequest);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvAmtToChangeList);
            this.Controls.Add(this.txtAmtToChange);
            this.Controls.Add(this.lblAmtToChange);
            this.Controls.Add(this.dgvSearchList);
            this.Controls.Add(this.txtSearchKeywords);
            this.Controls.Add(this.lblSearchKeywords);
            this.Name = "ReorderRequestSendingForm";
            this.Text = "ReorderRequestSendingForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmtToChangeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSendReorderRequest;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvAmtToChangeList;
        private System.Windows.Forms.TextBox txtAmtToChange;
        private System.Windows.Forms.Label lblAmtToChange;
        private System.Windows.Forms.DataGridView dgvSearchList;
        private System.Windows.Forms.TextBox txtSearchKeywords;
        private System.Windows.Forms.Label lblSearchKeywords;
    }
}
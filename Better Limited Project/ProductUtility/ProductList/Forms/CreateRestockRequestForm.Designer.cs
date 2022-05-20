namespace Better_Limited_Project.ProductUtility.ProductList
{
    partial class CreateRestockRequestForm
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
            this.dgvSearchList = new System.Windows.Forms.DataGridView();
            this.lblAmtToChange = new System.Windows.Forms.Label();
            this.txtAmtToChange = new System.Windows.Forms.TextBox();
            this.dgvAmtToChangeList = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSendRequest = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmtToChangeList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearchKeywords
            // 
            this.lblSearchKeywords.AutoSize = true;
            this.lblSearchKeywords.Location = new System.Drawing.Point(41, 38);
            this.lblSearchKeywords.Name = "lblSearchKeywords";
            this.lblSearchKeywords.Size = new System.Drawing.Size(120, 12);
            this.lblSearchKeywords.TabIndex = 0;
            this.lblSearchKeywords.Text = "Search by Product Name";
            // 
            // txtSearchKeywords
            // 
            this.txtSearchKeywords.Location = new System.Drawing.Point(43, 62);
            this.txtSearchKeywords.Name = "txtSearchKeywords";
            this.txtSearchKeywords.Size = new System.Drawing.Size(174, 22);
            this.txtSearchKeywords.TabIndex = 1;
            // 
            // dgvSearchList
            // 
            this.dgvSearchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchList.Location = new System.Drawing.Point(43, 114);
            this.dgvSearchList.Name = "dgvSearchList";
            this.dgvSearchList.RowTemplate.Height = 24;
            this.dgvSearchList.Size = new System.Drawing.Size(357, 181);
            this.dgvSearchList.TabIndex = 2;
            // 
            // lblAmtToChange
            // 
            this.lblAmtToChange.AutoSize = true;
            this.lblAmtToChange.Location = new System.Drawing.Point(448, 45);
            this.lblAmtToChange.Name = "lblAmtToChange";
            this.lblAmtToChange.Size = new System.Drawing.Size(98, 12);
            this.lblAmtToChange.TabIndex = 3;
            this.lblAmtToChange.Text = "Amount To Change";
            // 
            // txtAmtToChange
            // 
            this.txtAmtToChange.Location = new System.Drawing.Point(450, 69);
            this.txtAmtToChange.Name = "txtAmtToChange";
            this.txtAmtToChange.Size = new System.Drawing.Size(141, 22);
            this.txtAmtToChange.TabIndex = 4;
            // 
            // dgvAmtToChangeList
            // 
            this.dgvAmtToChangeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmtToChangeList.Location = new System.Drawing.Point(450, 121);
            this.dgvAmtToChangeList.Name = "dgvAmtToChangeList";
            this.dgvAmtToChangeList.RowTemplate.Height = 24;
            this.dgvAmtToChangeList.Size = new System.Drawing.Size(338, 51);
            this.dgvAmtToChangeList.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAdd.Location = new System.Drawing.Point(612, 62);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(73, 34);
            this.btnAdd.TabIndex = 43;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRemove.Location = new System.Drawing.Point(691, 62);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(97, 34);
            this.btnRemove.TabIndex = 44;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Window;
            this.btnClear.Location = new System.Drawing.Point(682, 234);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 41);
            this.btnClear.TabIndex = 45;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSendRequest
            // 
            this.btnSendRequest.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSendRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendRequest.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSendRequest.Location = new System.Drawing.Point(306, 333);
            this.btnSendRequest.Name = "btnSendRequest";
            this.btnSendRequest.Size = new System.Drawing.Size(183, 41);
            this.btnSendRequest.TabIndex = 46;
            this.btnSendRequest.Text = "Send Request";
            this.btnSendRequest.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCancel.Location = new System.Drawing.Point(348, 397);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 41);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // CreateRestockRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSendRequest);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvAmtToChangeList);
            this.Controls.Add(this.txtAmtToChange);
            this.Controls.Add(this.lblAmtToChange);
            this.Controls.Add(this.dgvSearchList);
            this.Controls.Add(this.txtSearchKeywords);
            this.Controls.Add(this.lblSearchKeywords);
            this.Name = "CreateRestockRequestForm";
            this.Text = "CreateRestockRequestForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmtToChangeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchKeywords;
        private System.Windows.Forms.TextBox txtSearchKeywords;
        private System.Windows.Forms.DataGridView dgvSearchList;
        private System.Windows.Forms.Label lblAmtToChange;
        private System.Windows.Forms.TextBox txtAmtToChange;
        private System.Windows.Forms.DataGridView dgvAmtToChangeList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSendRequest;
        private System.Windows.Forms.Button btnCancel;
    }
}
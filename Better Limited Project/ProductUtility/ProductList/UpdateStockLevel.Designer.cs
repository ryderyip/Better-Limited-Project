namespace Better_Limited_Project.ProductUtility.ProductList
{
    partial class UpdateStockLevel
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
            this.dgvSearchList = new System.Windows.Forms.DataGridView();
            this.lblAmtToChange = new System.Windows.Forms.Label();
            this.txtSearchKeywords = new System.Windows.Forms.TextBox();
            this.txtAmtToChange = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dgvAmtToChangeList = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmtToChangeList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearchKeywords
            // 
            this.lblSearchKeywords.AutoSize = true;
            this.lblSearchKeywords.Location = new System.Drawing.Point(71, 50);
            this.lblSearchKeywords.Name = "lblSearchKeywords";
            this.lblSearchKeywords.Size = new System.Drawing.Size(120, 12);
            this.lblSearchKeywords.TabIndex = 0;
            this.lblSearchKeywords.Text = "Search by Product Name";
            // 
            // dgvSearchList
            // 
            this.dgvSearchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchList.Location = new System.Drawing.Point(74, 125);
            this.dgvSearchList.Name = "dgvSearchList";
            this.dgvSearchList.RowTemplate.Height = 24;
            this.dgvSearchList.Size = new System.Drawing.Size(279, 260);
            this.dgvSearchList.TabIndex = 2;
            // 
            // lblAmtToChange
            // 
            this.lblAmtToChange.AutoSize = true;
            this.lblAmtToChange.Location = new System.Drawing.Point(404, 50);
            this.lblAmtToChange.Name = "lblAmtToChange";
            this.lblAmtToChange.Size = new System.Drawing.Size(98, 12);
            this.lblAmtToChange.TabIndex = 3;
            this.lblAmtToChange.Text = "Amount To Change";
            // 
            // txtSearchKeywords
            // 
            this.txtSearchKeywords.Location = new System.Drawing.Point(73, 76);
            this.txtSearchKeywords.Name = "txtSearchKeywords";
            this.txtSearchKeywords.Size = new System.Drawing.Size(170, 22);
            this.txtSearchKeywords.TabIndex = 1;
            // 
            // txtAmtToChange
            // 
            this.txtAmtToChange.Location = new System.Drawing.Point(406, 75);
            this.txtAmtToChange.Name = "txtAmtToChange";
            this.txtAmtToChange.Size = new System.Drawing.Size(170, 22);
            this.txtAmtToChange.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAdd.Location = new System.Drawing.Point(609, 66);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(68, 33);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRemove.Location = new System.Drawing.Point(701, 67);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(78, 33);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // dgvAmtToChangeList
            // 
            this.dgvAmtToChangeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmtToChangeList.Location = new System.Drawing.Point(406, 125);
            this.dgvAmtToChangeList.Name = "dgvAmtToChangeList";
            this.dgvAmtToChangeList.RowTemplate.Height = 24;
            this.dgvAmtToChangeList.Size = new System.Drawing.Size(373, 105);
            this.dgvAmtToChangeList.TabIndex = 7;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Brown;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Window;
            this.btnClear.Location = new System.Drawing.Point(701, 267);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(78, 33);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // UpdateStockLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvAmtToChangeList);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAmtToChange);
            this.Controls.Add(this.lblAmtToChange);
            this.Controls.Add(this.dgvSearchList);
            this.Controls.Add(this.txtSearchKeywords);
            this.Controls.Add(this.lblSearchKeywords);
            this.Name = "UpdateStockLevel";
            this.Text = "UpdateStockLevel";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmtToChangeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchKeywords;
        private System.Windows.Forms.DataGridView dgvSearchList;
        private System.Windows.Forms.Label lblAmtToChange;
        private System.Windows.Forms.TextBox txtSearchKeywords;
        private System.Windows.Forms.TextBox txtAmtToChange;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dgvAmtToChangeList;
        private System.Windows.Forms.Button btnClear;
    }
}
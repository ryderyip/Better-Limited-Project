
namespace Better_Limited_Project.ProductUtility.Restocking
{
    partial class RestockRequestListForm
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
            this.btnNewRequest = new System.Windows.Forms.Button();
            this.dgvRestockRequests = new System.Windows.Forms.DataGridView();
            this.tbSearchBox = new System.Windows.Forms.TextBox();
            this.lblSearchBox = new System.Windows.Forms.Label();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestedByRetailStoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestedOnColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isArranged = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestockRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewRequest
            // 
            this.btnNewRequest.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNewRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnNewRequest.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNewRequest.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNewRequest.Location = new System.Drawing.Point(408, 20);
            this.btnNewRequest.Name = "btnNewRequest";
            this.btnNewRequest.Size = new System.Drawing.Size(137, 47);
            this.btnNewRequest.TabIndex = 60;
            this.btnNewRequest.Text = "New Request";
            this.btnNewRequest.UseVisualStyleBackColor = false;
            // 
            // dgvRestockRequests
            // 
            this.dgvRestockRequests.AllowUserToAddRows = false;
            this.dgvRestockRequests.AllowUserToDeleteRows = false;
            this.dgvRestockRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRestockRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.requestNumberColumn,
            this.requestedByRetailStoreName,
            this.requestedOnColumn,
            this.isArranged});
            this.dgvRestockRequests.Location = new System.Drawing.Point(22, 98);
            this.dgvRestockRequests.Name = "dgvRestockRequests";
            this.dgvRestockRequests.ReadOnly = true;
            this.dgvRestockRequests.RowTemplate.Height = 24;
            this.dgvRestockRequests.Size = new System.Drawing.Size(523, 327);
            this.dgvRestockRequests.TabIndex = 59;
            // 
            // tbSearchBox
            // 
            this.tbSearchBox.Location = new System.Drawing.Point(22, 47);
            this.tbSearchBox.Name = "tbSearchBox";
            this.tbSearchBox.Size = new System.Drawing.Size(192, 20);
            this.tbSearchBox.TabIndex = 58;
            // 
            // lblSearchBox
            // 
            this.lblSearchBox.AutoSize = true;
            this.lblSearchBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSearchBox.Location = new System.Drawing.Point(20, 20);
            this.lblSearchBox.Name = "lblSearchBox";
            this.lblSearchBox.Size = new System.Drawing.Size(138, 13);
            this.lblSearchBox.TabIndex = 57;
            this.lblSearchBox.Text = "Search by Request Number";
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "ID";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Visible = false;
            // 
            // requestNumberColumn
            // 
            this.requestNumberColumn.HeaderText = "Request No.";
            this.requestNumberColumn.Name = "requestNumberColumn";
            this.requestNumberColumn.ReadOnly = true;
            this.requestNumberColumn.Width = 130;
            // 
            // requestedByRetailStoreName
            // 
            this.requestedByRetailStoreName.HeaderText = "Retail Store";
            this.requestedByRetailStoreName.Name = "requestedByRetailStoreName";
            this.requestedByRetailStoreName.ReadOnly = true;
            this.requestedByRetailStoreName.Width = 120;
            // 
            // requestedOnColumn
            // 
            this.requestedOnColumn.HeaderText = "Requested On";
            this.requestedOnColumn.Name = "requestedOnColumn";
            this.requestedOnColumn.ReadOnly = true;
            this.requestedOnColumn.Width = 130;
            // 
            // isArranged
            // 
            this.isArranged.HeaderText = "Is Arranged";
            this.isArranged.Name = "isArranged";
            this.isArranged.ReadOnly = true;
            // 
            // RestockRequestListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 450);
            this.Controls.Add(this.btnNewRequest);
            this.Controls.Add(this.dgvRestockRequests);
            this.Controls.Add(this.tbSearchBox);
            this.Controls.Add(this.lblSearchBox);
            this.Name = "RestockRequestListForm";
            this.Text = "RestockRequestListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestockRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNewRequest;
        private System.Windows.Forms.DataGridView dgvRestockRequests;
        private System.Windows.Forms.TextBox tbSearchBox;
        private System.Windows.Forms.Label lblSearchBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestedByRetailStoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestedOnColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isArranged;
    }
}
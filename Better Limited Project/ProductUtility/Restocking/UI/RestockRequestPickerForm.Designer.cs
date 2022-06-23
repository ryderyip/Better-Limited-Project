
namespace Better_Limited_Project.ProductUtility.Restocking.UI
{
    partial class RestockRequestPickerForm
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.dgvRestockRequests = new System.Windows.Forms.DataGridView();
            this.tbSearchBox = new System.Windows.Forms.TextBox();
            this.lblSearchBox = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestedByRetailStoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestedOnColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestockRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(132, 19);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(292, 25);
            this.lblHeader.TabIndex = 77;
            this.lblHeader.Text = "Select Restock Request(s)";
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
            this.requestedOnColumn});
            this.dgvRestockRequests.Location = new System.Drawing.Point(32, 138);
            this.dgvRestockRequests.Name = "dgvRestockRequests";
            this.dgvRestockRequests.ReadOnly = true;
            this.dgvRestockRequests.RowTemplate.Height = 24;
            this.dgvRestockRequests.Size = new System.Drawing.Size(494, 249);
            this.dgvRestockRequests.TabIndex = 80;
            // 
            // tbSearchBox
            // 
            this.tbSearchBox.Location = new System.Drawing.Point(32, 98);
            this.tbSearchBox.Name = "tbSearchBox";
            this.tbSearchBox.Size = new System.Drawing.Size(192, 20);
            this.tbSearchBox.TabIndex = 79;
            // 
            // lblSearchBox
            // 
            this.lblSearchBox.AutoSize = true;
            this.lblSearchBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSearchBox.Location = new System.Drawing.Point(30, 71);
            this.lblSearchBox.Name = "lblSearchBox";
            this.lblSearchBox.Size = new System.Drawing.Size(138, 13);
            this.lblSearchBox.TabIndex = 78;
            this.lblSearchBox.Text = "Search by Request Number";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.DarkOrange;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.Window;
            this.btnConfirm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnConfirm.Location = new System.Drawing.Point(197, 407);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(163, 52);
            this.btnConfirm.TabIndex = 233;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
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
            this.requestNumberColumn.Width = 160;
            // 
            // requestedByRetailStoreName
            // 
            this.requestedByRetailStoreName.HeaderText = "Retail Store";
            this.requestedByRetailStoreName.Name = "requestedByRetailStoreName";
            this.requestedByRetailStoreName.ReadOnly = true;
            this.requestedByRetailStoreName.Width = 160;
            // 
            // requestedOnColumn
            // 
            this.requestedOnColumn.HeaderText = "Requested On";
            this.requestedOnColumn.Name = "requestedOnColumn";
            this.requestedOnColumn.ReadOnly = true;
            this.requestedOnColumn.Width = 130;
            // 
            // RestockRequestPickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 471);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.dgvRestockRequests);
            this.Controls.Add(this.tbSearchBox);
            this.Controls.Add(this.lblSearchBox);
            this.Controls.Add(this.lblHeader);
            this.Name = "RestockRequestPickerForm";
            this.Text = "RestockRequestPickerForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestockRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridView dgvRestockRequests;
        private System.Windows.Forms.TextBox tbSearchBox;
        private System.Windows.Forms.Label lblSearchBox;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestedByRetailStoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestedOnColumn;
    }
}
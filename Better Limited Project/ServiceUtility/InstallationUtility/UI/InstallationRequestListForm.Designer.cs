
namespace Better_Limited_Project.ServiceUtility.InstallationUtility.UI
{
    partial class InstallationRequestListForm
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
            this.dgvInstallationRequests = new System.Windows.Forms.DataGridView();
            this.tbSearchBox = new System.Windows.Forms.TextBox();
            this.lblSearchBox = new System.Windows.Forms.Label();
            this.instllationRequestIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdOnColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isArrangedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrangedOnColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstallationRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInstallationRequests
            // 
            this.dgvInstallationRequests.AllowUserToAddRows = false;
            this.dgvInstallationRequests.AllowUserToDeleteRows = false;
            this.dgvInstallationRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstallationRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.instllationRequestIdColumn,
            this.orderNumberColumn,
            this.createdOnColumn,
            this.isArrangedColumn,
            this.arrangedOnColumn});
            this.dgvInstallationRequests.Location = new System.Drawing.Point(26, 97);
            this.dgvInstallationRequests.Name = "dgvInstallationRequests";
            this.dgvInstallationRequests.ReadOnly = true;
            this.dgvInstallationRequests.RowTemplate.Height = 24;
            this.dgvInstallationRequests.Size = new System.Drawing.Size(533, 323);
            this.dgvInstallationRequests.TabIndex = 18;
            this.dgvInstallationRequests.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInstallationRequests_CellDoubleClick);
            // 
            // tbSearchBox
            // 
            this.tbSearchBox.Location = new System.Drawing.Point(26, 41);
            this.tbSearchBox.Name = "tbSearchBox";
            this.tbSearchBox.Size = new System.Drawing.Size(209, 20);
            this.tbSearchBox.TabIndex = 17;
            // 
            // lblSearchBox
            // 
            this.lblSearchBox.AutoSize = true;
            this.lblSearchBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSearchBox.Location = new System.Drawing.Point(24, 25);
            this.lblSearchBox.Name = "lblSearchBox";
            this.lblSearchBox.Size = new System.Drawing.Size(153, 13);
            this.lblSearchBox.TabIndex = 16;
            this.lblSearchBox.Text = "Search by Sales Order Number";
            // 
            // instllationRequestIdColumn
            // 
            this.instllationRequestIdColumn.HeaderText = "request id";
            this.instllationRequestIdColumn.Name = "instllationRequestIdColumn";
            this.instllationRequestIdColumn.ReadOnly = true;
            this.instllationRequestIdColumn.Visible = false;
            // 
            // orderNumberColumn
            // 
            this.orderNumberColumn.HeaderText = "Sales Order Number";
            this.orderNumberColumn.Name = "orderNumberColumn";
            this.orderNumberColumn.ReadOnly = true;
            this.orderNumberColumn.Width = 130;
            // 
            // createdOnColumn
            // 
            this.createdOnColumn.HeaderText = "Created On";
            this.createdOnColumn.Name = "createdOnColumn";
            this.createdOnColumn.ReadOnly = true;
            this.createdOnColumn.Width = 130;
            // 
            // isArrangedColumn
            // 
            this.isArrangedColumn.HeaderText = "Arranged";
            this.isArrangedColumn.Name = "isArrangedColumn";
            this.isArrangedColumn.ReadOnly = true;
            // 
            // arrangedOnColumn
            // 
            this.arrangedOnColumn.HeaderText = "Arranged On";
            this.arrangedOnColumn.Name = "arrangedOnColumn";
            this.arrangedOnColumn.ReadOnly = true;
            this.arrangedOnColumn.Width = 130;
            // 
            // InstallationRequestListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 450);
            this.Controls.Add(this.dgvInstallationRequests);
            this.Controls.Add(this.tbSearchBox);
            this.Controls.Add(this.lblSearchBox);
            this.Name = "InstallationRequestListForm";
            this.Text = "InstallationRequestListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstallationRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvInstallationRequests;
        public System.Windows.Forms.TextBox tbSearchBox;
        private System.Windows.Forms.Label lblSearchBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn instllationRequestIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdOnColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isArrangedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrangedOnColumn;
    }
}
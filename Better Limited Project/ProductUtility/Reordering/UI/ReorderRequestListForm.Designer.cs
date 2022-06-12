
namespace Better_Limited_Project.ProductUtility.Reordering.UI
{
    partial class ReorderRequestListForm
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
            this.dgvReorderRequests = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isApprovedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestedOnColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbSearchBox = new System.Windows.Forms.TextBox();
            this.lblSearchBox = new System.Windows.Forms.Label();
            this.btnNewRequest = new System.Windows.Forms.Button();
            this.cbShowApproved = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReorderRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReorderRequests
            // 
            this.dgvReorderRequests.AllowUserToAddRows = false;
            this.dgvReorderRequests.AllowUserToDeleteRows = false;
            this.dgvReorderRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReorderRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.requestNumberColumn,
            this.isApprovedColumn,
            this.requestedOnColumn});
            this.dgvReorderRequests.Location = new System.Drawing.Point(23, 100);
            this.dgvReorderRequests.Name = "dgvReorderRequests";
            this.dgvReorderRequests.ReadOnly = true;
            this.dgvReorderRequests.RowTemplate.Height = 24;
            this.dgvReorderRequests.Size = new System.Drawing.Size(538, 327);
            this.dgvReorderRequests.TabIndex = 54;
            this.dgvReorderRequests.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReorderRequest_CellDoubleClick);
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
            // isApprovedColumn
            // 
            this.isApprovedColumn.HeaderText = "Is Approved";
            this.isApprovedColumn.Name = "isApprovedColumn";
            this.isApprovedColumn.ReadOnly = true;
            // 
            // requestedOnColumn
            // 
            this.requestedOnColumn.HeaderText = "Requested On";
            this.requestedOnColumn.Name = "requestedOnColumn";
            this.requestedOnColumn.ReadOnly = true;
            this.requestedOnColumn.Width = 130;
            // 
            // tbSearchBox
            // 
            this.tbSearchBox.Location = new System.Drawing.Point(23, 49);
            this.tbSearchBox.Name = "tbSearchBox";
            this.tbSearchBox.Size = new System.Drawing.Size(192, 20);
            this.tbSearchBox.TabIndex = 53;
            // 
            // lblSearchBox
            // 
            this.lblSearchBox.AutoSize = true;
            this.lblSearchBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSearchBox.Location = new System.Drawing.Point(21, 22);
            this.lblSearchBox.Name = "lblSearchBox";
            this.lblSearchBox.Size = new System.Drawing.Size(138, 13);
            this.lblSearchBox.TabIndex = 52;
            this.lblSearchBox.Text = "Search by Request Number";
            // 
            // btnNewRequest
            // 
            this.btnNewRequest.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNewRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnNewRequest.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNewRequest.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNewRequest.Location = new System.Drawing.Point(424, 22);
            this.btnNewRequest.Name = "btnNewRequest";
            this.btnNewRequest.Size = new System.Drawing.Size(137, 47);
            this.btnNewRequest.TabIndex = 55;
            this.btnNewRequest.Text = "New Request";
            this.btnNewRequest.UseVisualStyleBackColor = false;
            this.btnNewRequest.Click += new System.EventHandler(this.btnNewRequest_Click);
            // 
            // cbShowApproved
            // 
            this.cbShowApproved.AutoSize = true;
            this.cbShowApproved.Location = new System.Drawing.Point(221, 51);
            this.cbShowApproved.Name = "cbShowApproved";
            this.cbShowApproved.Size = new System.Drawing.Size(150, 17);
            this.cbShowApproved.TabIndex = 56;
            this.cbShowApproved.Text = "Show Approved Requests";
            this.cbShowApproved.UseVisualStyleBackColor = true;
            // 
            // ReorderRequestListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 450);
            this.Controls.Add(this.cbShowApproved);
            this.Controls.Add(this.btnNewRequest);
            this.Controls.Add(this.dgvReorderRequests);
            this.Controls.Add(this.tbSearchBox);
            this.Controls.Add(this.lblSearchBox);
            this.Name = "ReorderRequestListForm";
            this.Text = "ReorderRequestListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReorderRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReorderRequests;
        private System.Windows.Forms.TextBox tbSearchBox;
        private System.Windows.Forms.Label lblSearchBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isApprovedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestedOnColumn;
        private System.Windows.Forms.Button btnNewRequest;
        private System.Windows.Forms.CheckBox cbShowApproved;
    }
}

namespace Better_Limited_Project.ServiceUtility.InstallationUtility.UI
{
    partial class TechnicianListForm
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
            this.lblSearchBar = new System.Windows.Forms.Label();
            this.tbSearchBar = new System.Windows.Forms.TextBox();
            this.btnNewTechnician = new System.Windows.Forms.Button();
            this.phoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCOlumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInstallationRequests = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstallationRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearchBar
            // 
            this.lblSearchBar.AutoSize = true;
            this.lblSearchBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSearchBar.Location = new System.Drawing.Point(22, 17);
            this.lblSearchBar.Name = "lblSearchBar";
            this.lblSearchBar.Size = new System.Drawing.Size(205, 13);
            this.lblSearchBar.TabIndex = 19;
            this.lblSearchBar.Text = "Search by Technician\'s Name/Phone No.";
            // 
            // tbSearchBar
            // 
            this.tbSearchBar.Location = new System.Drawing.Point(24, 33);
            this.tbSearchBar.Name = "tbSearchBar";
            this.tbSearchBar.Size = new System.Drawing.Size(209, 20);
            this.tbSearchBar.TabIndex = 20;
            // 
            // btnNewTechnician
            // 
            this.btnNewTechnician.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNewTechnician.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnNewTechnician.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNewTechnician.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNewTechnician.Location = new System.Drawing.Point(302, 17);
            this.btnNewTechnician.Name = "btnNewTechnician";
            this.btnNewTechnician.Size = new System.Drawing.Size(180, 51);
            this.btnNewTechnician.TabIndex = 132;
            this.btnNewTechnician.Text = "New Technician";
            this.btnNewTechnician.UseVisualStyleBackColor = false;
            this.btnNewTechnician.Click += new System.EventHandler(this.btnNewTechnician_Click);
            // 
            // phoneColumn
            // 
            this.phoneColumn.HeaderText = "Phone";
            this.phoneColumn.Name = "phoneColumn";
            this.phoneColumn.ReadOnly = true;
            this.phoneColumn.Width = 150;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            this.nameColumn.Width = 200;
            // 
            // idCOlumn
            // 
            this.idCOlumn.HeaderText = "id";
            this.idCOlumn.Name = "idCOlumn";
            this.idCOlumn.ReadOnly = true;
            this.idCOlumn.Visible = false;
            // 
            // dgvInstallationRequests
            // 
            this.dgvInstallationRequests.AllowUserToAddRows = false;
            this.dgvInstallationRequests.AllowUserToDeleteRows = false;
            this.dgvInstallationRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstallationRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCOlumn,
            this.nameColumn,
            this.phoneColumn});
            this.dgvInstallationRequests.Location = new System.Drawing.Point(24, 89);
            this.dgvInstallationRequests.Name = "dgvInstallationRequests";
            this.dgvInstallationRequests.ReadOnly = true;
            this.dgvInstallationRequests.RowTemplate.Height = 24;
            this.dgvInstallationRequests.Size = new System.Drawing.Size(458, 338);
            this.dgvInstallationRequests.TabIndex = 21;
            this.dgvInstallationRequests.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInstallationRequests_CellDoubleClick);
            // 
            // TechnicianListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 450);
            this.Controls.Add(this.btnNewTechnician);
            this.Controls.Add(this.dgvInstallationRequests);
            this.Controls.Add(this.tbSearchBar);
            this.Controls.Add(this.lblSearchBar);
            this.Name = "TechnicianListForm";
            this.Text = "TechnicianListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstallationRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSearchBar;
        public System.Windows.Forms.TextBox tbSearchBar;
        private System.Windows.Forms.Button btnNewTechnician;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCOlumn;
        public System.Windows.Forms.DataGridView dgvInstallationRequests;
    }
}
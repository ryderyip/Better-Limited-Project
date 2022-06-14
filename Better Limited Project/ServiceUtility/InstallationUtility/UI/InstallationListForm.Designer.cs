
namespace Better_Limited_Project.ServiceUtility.InstallationUtility.UI
{
    partial class InstallationListForm
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
            this.tbSearchBar = new System.Windows.Forms.TextBox();
            this.lblSearchBar = new System.Windows.Forms.Label();
            this.dgvInstallations = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduledOnColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.installedOnColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstallations)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSearchBar
            // 
            this.tbSearchBar.Location = new System.Drawing.Point(26, 35);
            this.tbSearchBar.Name = "tbSearchBar";
            this.tbSearchBar.Size = new System.Drawing.Size(209, 20);
            this.tbSearchBar.TabIndex = 23;
            // 
            // lblSearchBar
            // 
            this.lblSearchBar.AutoSize = true;
            this.lblSearchBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSearchBar.Location = new System.Drawing.Point(24, 19);
            this.lblSearchBar.Name = "lblSearchBar";
            this.lblSearchBar.Size = new System.Drawing.Size(153, 13);
            this.lblSearchBar.TabIndex = 22;
            this.lblSearchBar.Text = "Search by Sales Order Number";
            // 
            // dgvInstallations
            // 
            this.dgvInstallations.AllowUserToAddRows = false;
            this.dgvInstallations.AllowUserToDeleteRows = false;
            this.dgvInstallations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstallations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.orderNumberColumn,
            this.scheduledOnColumn,
            this.installedOnColumn});
            this.dgvInstallations.Location = new System.Drawing.Point(27, 77);
            this.dgvInstallations.Name = "dgvInstallations";
            this.dgvInstallations.ReadOnly = true;
            this.dgvInstallations.RowTemplate.Height = 24;
            this.dgvInstallations.Size = new System.Drawing.Size(454, 352);
            this.dgvInstallations.TabIndex = 134;
            this.dgvInstallations.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInstallations_CellDoubleClick);
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "id";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Visible = false;
            // 
            // orderNumberColumn
            // 
            this.orderNumberColumn.HeaderText = "Sales Order Number";
            this.orderNumberColumn.Name = "orderNumberColumn";
            this.orderNumberColumn.ReadOnly = true;
            this.orderNumberColumn.Width = 150;
            // 
            // scheduledOnColumn
            // 
            this.scheduledOnColumn.HeaderText = "Scheduled On";
            this.scheduledOnColumn.Name = "scheduledOnColumn";
            this.scheduledOnColumn.ReadOnly = true;
            this.scheduledOnColumn.Width = 130;
            // 
            // installedOnColumn
            // 
            this.installedOnColumn.HeaderText = "Installed On";
            this.installedOnColumn.Name = "installedOnColumn";
            this.installedOnColumn.ReadOnly = true;
            this.installedOnColumn.Width = 130;
            // 
            // InstallationListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 450);
            this.Controls.Add(this.dgvInstallations);
            this.Controls.Add(this.tbSearchBar);
            this.Controls.Add(this.lblSearchBar);
            this.Name = "InstallationListForm";
            this.Text = "InstallationListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstallations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox tbSearchBar;
        private System.Windows.Forms.Label lblSearchBar;
        public System.Windows.Forms.DataGridView dgvInstallations;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduledOnColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn installedOnColumn;
    }
}
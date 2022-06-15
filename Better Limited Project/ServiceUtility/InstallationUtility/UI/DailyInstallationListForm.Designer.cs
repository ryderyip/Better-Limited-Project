
namespace Better_Limited_Project.ServiceUtility.InstallationUtility.UI
{
    partial class DailyInstallationListForm
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
            this.dgvInstallations = new System.Windows.Forms.DataGridView();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnPrintInstallationList = new System.Windows.Forms.Button();
            this.btnGenerateDailyList = new System.Windows.Forms.Button();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduledOnColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfItemsToInstallColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstallations)).BeginInit();
            this.SuspendLayout();
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
            this.noOfItemsToInstallColumn});
            this.dgvInstallations.Location = new System.Drawing.Point(26, 117);
            this.dgvInstallations.Name = "dgvInstallations";
            this.dgvInstallations.ReadOnly = true;
            this.dgvInstallations.RowTemplate.Height = 24;
            this.dgvInstallations.Size = new System.Drawing.Size(454, 275);
            this.dgvInstallations.TabIndex = 137;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDate.Location = new System.Drawing.Point(23, 84);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(40, 16);
            this.lblDate.TabIndex = 140;
            this.lblDate.Text = "Date:";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(68, 82);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 139;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHeader.Location = new System.Drawing.Point(152, 24);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(199, 25);
            this.lblHeader.TabIndex = 138;
            this.lblHeader.Text = "Daily Installations";
            // 
            // btnPrintInstallationList
            // 
            this.btnPrintInstallationList.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPrintInstallationList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrintInstallationList.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPrintInstallationList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPrintInstallationList.Location = new System.Drawing.Point(327, 415);
            this.btnPrintInstallationList.Name = "btnPrintInstallationList";
            this.btnPrintInstallationList.Size = new System.Drawing.Size(153, 54);
            this.btnPrintInstallationList.TabIndex = 142;
            this.btnPrintInstallationList.Text = "Print Installation List";
            this.btnPrintInstallationList.UseVisualStyleBackColor = false;
            this.btnPrintInstallationList.Click += new System.EventHandler(this.btnPrintInstallationList_Click);
            // 
            // btnGenerateDailyList
            // 
            this.btnGenerateDailyList.BackColor = System.Drawing.Color.DarkOrange;
            this.btnGenerateDailyList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnGenerateDailyList.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGenerateDailyList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGenerateDailyList.Location = new System.Drawing.Point(26, 415);
            this.btnGenerateDailyList.Name = "btnGenerateDailyList";
            this.btnGenerateDailyList.Size = new System.Drawing.Size(185, 54);
            this.btnGenerateDailyList.TabIndex = 141;
            this.btnGenerateDailyList.Text = "Generate Installation List";
            this.btnGenerateDailyList.UseVisualStyleBackColor = false;
            this.btnGenerateDailyList.Click += new System.EventHandler(this.btnGenerateDailyList_Click);
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
            // 
            // noOfItemsToInstallColumn
            // 
            this.noOfItemsToInstallColumn.HeaderText = "No. of Items";
            this.noOfItemsToInstallColumn.Name = "noOfItemsToInstallColumn";
            this.noOfItemsToInstallColumn.ReadOnly = true;
            // 
            // DailyInstallationListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 489);
            this.Controls.Add(this.btnPrintInstallationList);
            this.Controls.Add(this.btnGenerateDailyList);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.dgvInstallations);
            this.Name = "DailyInstallationListForm";
            this.Text = "DailyInstallationListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstallations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvInstallations;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnPrintInstallationList;
        private System.Windows.Forms.Button btnGenerateDailyList;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduledOnColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfItemsToInstallColumn;
    }
}
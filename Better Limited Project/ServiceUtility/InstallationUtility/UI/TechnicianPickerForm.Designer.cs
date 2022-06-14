
namespace Better_Limited_Project.ServiceUtility.InstallationUtility.UI
{
    partial class TechnicianPickerForm
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
            this.dgvTechnicians = new System.Windows.Forms.DataGridView();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneCOlumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechnicians)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTechnicians
            // 
            this.dgvTechnicians.AllowUserToAddRows = false;
            this.dgvTechnicians.AllowUserToDeleteRows = false;
            this.dgvTechnicians.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTechnicians.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.nameColumn,
            this.phoneCOlumn});
            this.dgvTechnicians.Location = new System.Drawing.Point(37, 72);
            this.dgvTechnicians.Name = "dgvTechnicians";
            this.dgvTechnicians.ReadOnly = true;
            this.dgvTechnicians.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTechnicians.Size = new System.Drawing.Size(393, 201);
            this.dgvTechnicians.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHeader.Location = new System.Drawing.Point(105, 23);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(269, 29);
            this.lblHeader.TabIndex = 128;
            this.lblHeader.Text = "Choose Technician(s)";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.DarkOrange;
            this.btnConfirm.Enabled = false;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.Window;
            this.btnConfirm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnConfirm.Location = new System.Drawing.Point(141, 303);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(197, 55);
            this.btnConfirm.TabIndex = 132;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "id";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Visible = false;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            this.nameColumn.Width = 200;
            // 
            // phoneCOlumn
            // 
            this.phoneCOlumn.HeaderText = "Phone";
            this.phoneCOlumn.Name = "phoneCOlumn";
            this.phoneCOlumn.ReadOnly = true;
            this.phoneCOlumn.Width = 150;
            // 
            // TechnicianPickerForm
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 382);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.dgvTechnicians);
            this.Name = "TechnicianPickerForm";
            this.Text = "TechnicianPickerForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechnicians)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTechnicians;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneCOlumn;
    }
}

namespace Better_Limited_Project.ServiceUtility.DeliveryUtility.UI
{
    partial class CourierSelectorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourierSelectorForm));
            this.dgvCouriers = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblChooseCouriers = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblTips = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCouriers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCouriers
            // 
            this.dgvCouriers.AllowUserToAddRows = false;
            this.dgvCouriers.AllowUserToDeleteRows = false;
            this.dgvCouriers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCouriers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.nameColumn,
            this.phoneColumn});
            resources.ApplyResources(this.dgvCouriers, "dgvCouriers");
            this.dgvCouriers.Name = "dgvCouriers";
            this.dgvCouriers.ReadOnly = true;
            this.dgvCouriers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // idColumn
            // 
            resources.ApplyResources(this.idColumn, "idColumn");
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            // 
            // nameColumn
            // 
            resources.ApplyResources(this.nameColumn, "nameColumn");
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // phoneColumn
            // 
            resources.ApplyResources(this.phoneColumn, "phoneColumn");
            this.phoneColumn.Name = "phoneColumn";
            this.phoneColumn.ReadOnly = true;
            // 
            // lblChooseCouriers
            // 
            resources.ApplyResources(this.lblChooseCouriers, "lblChooseCouriers");
            this.lblChooseCouriers.Name = "lblChooseCouriers";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.DarkOrange;
            resources.ApplyResources(this.btnConfirm, "btnConfirm");
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.Window;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblTips
            // 
            resources.ApplyResources(this.lblTips, "lblTips");
            this.lblTips.Name = "lblTips";
            // 
            // CourierSelectorForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTips);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblChooseCouriers);
            this.Controls.Add(this.dgvCouriers);
            this.Name = "CourierSelectorForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCouriers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCouriers;
        private System.Windows.Forms.Label lblChooseCouriers;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneColumn;
        private System.Windows.Forms.Label lblTips;
    }
}
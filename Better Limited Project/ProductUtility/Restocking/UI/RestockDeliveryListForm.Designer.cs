
namespace Better_Limited_Project.ProductUtility.Restocking.UI
{
    partial class RestockDeliveryListForm
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
            this.btnRestockRequests = new System.Windows.Forms.Button();
            this.dgvRestockDeliveries = new System.Windows.Forms.DataGridView();
            this.dtpDateCreated = new System.Windows.Forms.DateTimePicker();
            this.cbSearchByDateCreated = new System.Windows.Forms.CheckBox();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestockDeliveries)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRestockRequests
            // 
            this.btnRestockRequests.BackColor = System.Drawing.Color.DarkOrange;
            this.btnRestockRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRestockRequests.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRestockRequests.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRestockRequests.Location = new System.Drawing.Point(353, 22);
            this.btnRestockRequests.Name = "btnRestockRequests";
            this.btnRestockRequests.Size = new System.Drawing.Size(173, 47);
            this.btnRestockRequests.TabIndex = 66;
            this.btnRestockRequests.Text = "Restock Requests";
            this.btnRestockRequests.UseVisualStyleBackColor = false;
            this.btnRestockRequests.Click += new System.EventHandler(this.btnRestockRequests_Click);
            // 
            // dgvRestockDeliveries
            // 
            this.dgvRestockDeliveries.AllowUserToAddRows = false;
            this.dgvRestockDeliveries.AllowUserToDeleteRows = false;
            this.dgvRestockDeliveries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRestockDeliveries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.Column1,
            this.Column2});
            this.dgvRestockDeliveries.Location = new System.Drawing.Point(24, 100);
            this.dgvRestockDeliveries.Name = "dgvRestockDeliveries";
            this.dgvRestockDeliveries.ReadOnly = true;
            this.dgvRestockDeliveries.RowTemplate.Height = 24;
            this.dgvRestockDeliveries.Size = new System.Drawing.Size(502, 327);
            this.dgvRestockDeliveries.TabIndex = 64;
            this.dgvRestockDeliveries.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRestockDeliveries_CellDoubleClick);
            // 
            // dtpDateCreated
            // 
            this.dtpDateCreated.Location = new System.Drawing.Point(25, 49);
            this.dtpDateCreated.Name = "dtpDateCreated";
            this.dtpDateCreated.Size = new System.Drawing.Size(200, 20);
            this.dtpDateCreated.TabIndex = 67;
            // 
            // cbSearchByDateCreated
            // 
            this.cbSearchByDateCreated.AutoSize = true;
            this.cbSearchByDateCreated.Location = new System.Drawing.Point(24, 22);
            this.cbSearchByDateCreated.Name = "cbSearchByDateCreated";
            this.cbSearchByDateCreated.Size = new System.Drawing.Size(176, 17);
            this.cbSearchByDateCreated.TabIndex = 68;
            this.cbSearchByDateCreated.Text = "Enable Search by Date Created";
            this.cbSearchByDateCreated.UseVisualStyleBackColor = true;
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "ID";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Created On";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Scheduled On";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // RestockDeliveryListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 450);
            this.Controls.Add(this.cbSearchByDateCreated);
            this.Controls.Add(this.dtpDateCreated);
            this.Controls.Add(this.btnRestockRequests);
            this.Controls.Add(this.dgvRestockDeliveries);
            this.Name = "RestockDeliveryListForm";
            this.Text = "RestockDeliveryListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestockDeliveries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRestockRequests;
        private System.Windows.Forms.DataGridView dgvRestockDeliveries;
        private System.Windows.Forms.DateTimePicker dtpDateCreated;
        private System.Windows.Forms.CheckBox cbSearchByDateCreated;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
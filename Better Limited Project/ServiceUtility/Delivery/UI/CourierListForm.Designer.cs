
namespace Better_Limited_Project.ServiceUtility.Delivery.UI
{
    partial class CourierListForm
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
            this.btnNewCourier = new System.Windows.Forms.Button();
            this.dgvCouriers = new System.Windows.Forms.DataGridView();
            this.tbSearchBox = new System.Windows.Forms.TextBox();
            this.lblSearchBox = new System.Windows.Forms.Label();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateHiredColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCouriers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewCourier
            // 
            this.btnNewCourier.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNewCourier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnNewCourier.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNewCourier.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNewCourier.Location = new System.Drawing.Point(245, 25);
            this.btnNewCourier.Name = "btnNewCourier";
            this.btnNewCourier.Size = new System.Drawing.Size(126, 48);
            this.btnNewCourier.TabIndex = 121;
            this.btnNewCourier.Text = "New Courier";
            this.btnNewCourier.UseVisualStyleBackColor = false;
            this.btnNewCourier.Click += new System.EventHandler(this.btnNewCourier_Click);
            // 
            // dgvCouriers
            // 
            this.dgvCouriers.AllowUserToAddRows = false;
            this.dgvCouriers.AllowUserToDeleteRows = false;
            this.dgvCouriers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCouriers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.nameColumn,
            this.phoneColumn,
            this.dateHiredColumn});
            this.dgvCouriers.Location = new System.Drawing.Point(27, 92);
            this.dgvCouriers.Name = "dgvCouriers";
            this.dgvCouriers.ReadOnly = true;
            this.dgvCouriers.RowTemplate.Height = 24;
            this.dgvCouriers.Size = new System.Drawing.Size(344, 331);
            this.dgvCouriers.TabIndex = 119;
            this.dgvCouriers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCouriers_CellDoubleClick);
            // 
            // tbSearchBox
            // 
            this.tbSearchBox.Location = new System.Drawing.Point(27, 41);
            this.tbSearchBox.Name = "tbSearchBox";
            this.tbSearchBox.Size = new System.Drawing.Size(183, 20);
            this.tbSearchBox.TabIndex = 118;
            this.tbSearchBox.TextChanged += new System.EventHandler(this.tbSearchBox_TextChanged);
            // 
            // lblSearchBox
            // 
            this.lblSearchBox.AutoSize = true;
            this.lblSearchBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSearchBox.Location = new System.Drawing.Point(25, 25);
            this.lblSearchBox.Name = "lblSearchBox";
            this.lblSearchBox.Size = new System.Drawing.Size(185, 13);
            this.lblSearchBox.TabIndex = 117;
            this.lblSearchBox.Text = "Search by Courier\'s Name/Phone No.";
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "ID";
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
            // phoneColumn
            // 
            this.phoneColumn.HeaderText = "Phone No.";
            this.phoneColumn.Name = "phoneColumn";
            this.phoneColumn.ReadOnly = true;
            // 
            // dateHiredColumn
            // 
            this.dateHiredColumn.HeaderText = "Date Hired";
            this.dateHiredColumn.Name = "dateHiredColumn";
            this.dateHiredColumn.ReadOnly = true;
            // 
            // CourierListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 450);
            this.Controls.Add(this.btnNewCourier);
            this.Controls.Add(this.dgvCouriers);
            this.Controls.Add(this.tbSearchBox);
            this.Controls.Add(this.lblSearchBox);
            this.Name = "CourierListForm";
            this.Text = "CourierListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCouriers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewCourier;
        public System.Windows.Forms.DataGridView dgvCouriers;
        public System.Windows.Forms.TextBox tbSearchBox;
        private System.Windows.Forms.Label lblSearchBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateHiredColumn;
    }
}
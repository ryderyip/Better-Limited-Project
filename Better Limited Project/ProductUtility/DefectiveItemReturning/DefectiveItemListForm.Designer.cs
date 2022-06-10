
namespace Better_Limited_Project.ProductUtility.DefectiveItemReturning
{
    partial class DefectiveItemListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefectiveItemListForm));
            this.btnNewItem = new System.Windows.Forms.Button();
            this.dgvDefectiveItems = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnedOnColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbSearchBox = new System.Windows.Forms.TextBox();
            this.lblSearchBox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDefectiveItems)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewItem
            // 
            this.btnNewItem.BackColor = System.Drawing.Color.DarkOrange;
            resources.ApplyResources(this.btnNewItem, "btnNewItem");
            this.btnNewItem.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNewItem.Name = "btnNewItem";
            this.btnNewItem.UseVisualStyleBackColor = false;
            this.btnNewItem.Click += new System.EventHandler(this.btnNewItem_Click);
            // 
            // dgvDefectiveItems
            // 
            this.dgvDefectiveItems.AllowUserToAddRows = false;
            this.dgvDefectiveItems.AllowUserToDeleteRows = false;
            this.dgvDefectiveItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDefectiveItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.orderNumberColumn,
            this.productNameColumn,
            this.quantityColumn,
            this.returnedOnColumn});
            resources.ApplyResources(this.dgvDefectiveItems, "dgvDefectiveItems");
            this.dgvDefectiveItems.Name = "dgvDefectiveItems";
            this.dgvDefectiveItems.ReadOnly = true;
            this.dgvDefectiveItems.RowTemplate.Height = 24;
            this.dgvDefectiveItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDefectiveItems_CellDoubleClick);
            // 
            // idColumn
            // 
            resources.ApplyResources(this.idColumn, "idColumn");
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            // 
            // orderNumberColumn
            // 
            resources.ApplyResources(this.orderNumberColumn, "orderNumberColumn");
            this.orderNumberColumn.Name = "orderNumberColumn";
            this.orderNumberColumn.ReadOnly = true;
            // 
            // productNameColumn
            // 
            resources.ApplyResources(this.productNameColumn, "productNameColumn");
            this.productNameColumn.Name = "productNameColumn";
            this.productNameColumn.ReadOnly = true;
            // 
            // quantityColumn
            // 
            resources.ApplyResources(this.quantityColumn, "quantityColumn");
            this.quantityColumn.Name = "quantityColumn";
            this.quantityColumn.ReadOnly = true;
            // 
            // returnedOnColumn
            // 
            resources.ApplyResources(this.returnedOnColumn, "returnedOnColumn");
            this.returnedOnColumn.Name = "returnedOnColumn";
            this.returnedOnColumn.ReadOnly = true;
            // 
            // tbSearchBox
            // 
            resources.ApplyResources(this.tbSearchBox, "tbSearchBox");
            this.tbSearchBox.Name = "tbSearchBox";
            // 
            // lblSearchBox
            // 
            resources.ApplyResources(this.lblSearchBox, "lblSearchBox");
            this.lblSearchBox.Name = "lblSearchBox";
            // 
            // DefectiveItemListForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNewItem);
            this.Controls.Add(this.dgvDefectiveItems);
            this.Controls.Add(this.tbSearchBox);
            this.Controls.Add(this.lblSearchBox);
            this.Name = "DefectiveItemListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDefectiveItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvDefectiveItems;
        public System.Windows.Forms.TextBox tbSearchBox;
        private System.Windows.Forms.Label lblSearchBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnedOnColumn;
        private System.Windows.Forms.Button btnNewItem;
    }
}
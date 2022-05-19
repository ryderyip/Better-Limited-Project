using Better_Limited_Project.ProductUtility.Entity;

namespace Better_Limited_Project.ProductUtility.ProductList
{
    partial class ProductListForm
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
            this.lblSearchKeywords = new System.Windows.Forms.Label();
            this.txtSearchKeywords = new System.Windows.Forms.TextBox();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.btnUpdateStockLevel = new System.Windows.Forms.Button();
            this.btnRestock = new System.Windows.Forms.Button();
            this.txtNoResults = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearchKeywords
            // 
            this.lblSearchKeywords.AutoSize = true;
            this.lblSearchKeywords.Location = new System.Drawing.Point(29, 32);
            this.lblSearchKeywords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchKeywords.Name = "lblSearchKeywords";
            this.lblSearchKeywords.Size = new System.Drawing.Size(211, 15);
            this.lblSearchKeywords.TabIndex = 0;
            this.lblSearchKeywords.Text = "Search by Product ID or Product Name";
            // 
            // txtSearchKeywords
            // 
            this.txtSearchKeywords.Location = new System.Drawing.Point(31, 51);
            this.txtSearchKeywords.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearchKeywords.Name = "txtSearchKeywords";
            this.txtSearchKeywords.Size = new System.Drawing.Size(243, 23);
            this.txtSearchKeywords.TabIndex = 1;
            // 
            // dgvProductList
            // 
            this.dgvProductList.AllowUserToAddRows = false;
            this.dgvProductList.AllowUserToDeleteRows = false;
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Location = new System.Drawing.Point(31, 155);
            this.dgvProductList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            this.dgvProductList.RowTemplate.Height = 24;
            this.dgvProductList.Size = new System.Drawing.Size(562, 306);
            this.dgvProductList.TabIndex = 2;
            this.dgvProductList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductList_CellDoubleClick);
            // 
            // btnUpdateStockLevel
            // 
            this.btnUpdateStockLevel.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdateStockLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateStockLevel.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdateStockLevel.Location = new System.Drawing.Point(407, 32);
            this.btnUpdateStockLevel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdateStockLevel.Name = "btnUpdateStockLevel";
            this.btnUpdateStockLevel.Size = new System.Drawing.Size(187, 46);
            this.btnUpdateStockLevel.TabIndex = 3;
            this.btnUpdateStockLevel.Text = "Update Stock Level";
            this.btnUpdateStockLevel.UseVisualStyleBackColor = false;
            this.btnUpdateStockLevel.Click += new System.EventHandler(this.btnUpdateStockLevel_Click);
            // 
            // btnRestock
            // 
            this.btnRestock.BackColor = System.Drawing.Color.DarkOrange;
            this.btnRestock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRestock.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRestock.Location = new System.Drawing.Point(469, 85);
            this.btnRestock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRestock.Name = "btnRestock";
            this.btnRestock.Size = new System.Drawing.Size(125, 46);
            this.btnRestock.TabIndex = 4;
            this.btnRestock.Text = "Restock";
            this.btnRestock.UseVisualStyleBackColor = false;
            // 
            // txtNoResults
            // 
            this.txtNoResults.AutoSize = true;
            this.txtNoResults.ForeColor = System.Drawing.Color.Red;
            this.txtNoResults.Location = new System.Drawing.Point(31, 85);
            this.txtNoResults.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtNoResults.Name = "txtNoResults";
            this.txtNoResults.Size = new System.Drawing.Size(125, 15);
            this.txtNoResults.TabIndex = 5;
            this.txtNoResults.Text = "(No Matching Results)";
            this.txtNoResults.Visible = false;
            // 
            // ProductListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 510);
            this.Controls.Add(this.txtNoResults);
            this.Controls.Add(this.btnRestock);
            this.Controls.Add(this.btnUpdateStockLevel);
            this.Controls.Add(this.dgvProductList);
            this.Controls.Add(this.txtSearchKeywords);
            this.Controls.Add(this.lblSearchKeywords);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ProductListForm";
            this.Text = "ProductListForm";
            this.Shown += new System.EventHandler(this.OnFormShown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label txtNoResults;

        #endregion

        private System.Windows.Forms.Label lblSearchKeywords;
        private System.Windows.Forms.TextBox txtSearchKeywords;
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.Button btnUpdateStockLevel;
        private System.Windows.Forms.Button btnRestock;
    }
}
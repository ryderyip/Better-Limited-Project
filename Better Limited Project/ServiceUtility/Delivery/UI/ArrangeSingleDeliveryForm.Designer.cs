namespace Better_Limited_Project.ServiceUtility.Delivery.UI
{
    partial class ArrangeSingleDeliveryForm
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
            this.lblSelectCourier = new System.Windows.Forms.Label();
            this.lblSelectDate = new System.Windows.Forms.Label();
            this.dtpSelectDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.lblEarliest = new System.Windows.Forms.Label();
            this.tbEarliestDeliveryDate = new System.Windows.Forms.TextBox();
            this.lblProductsDelivered = new System.Windows.Forms.Label();
            this.dgvProductsDelivered = new System.Windows.Forms.DataGridView();
            this.btnArrangeDelivery = new System.Windows.Forms.Button();
            this.btnSplitDelivery = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCustomerChosenDeliverySession = new System.Windows.Forms.TextBox();
            this.tbSelectedCourier = new System.Windows.Forms.TextBox();
            this.btnChooseCourier = new System.Windows.Forms.Button();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsDelivered)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectCourier
            // 
            this.lblSelectCourier.AutoSize = true;
            this.lblSelectCourier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCourier.Location = new System.Drawing.Point(97, 131);
            this.lblSelectCourier.Name = "lblSelectCourier";
            this.lblSelectCourier.Size = new System.Drawing.Size(119, 20);
            this.lblSelectCourier.TabIndex = 7;
            this.lblSelectCourier.Text = "Choose Courier";
            // 
            // lblSelectDate
            // 
            this.lblSelectDate.AutoSize = true;
            this.lblSelectDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDate.Location = new System.Drawing.Point(407, 132);
            this.lblSelectDate.Name = "lblSelectDate";
            this.lblSelectDate.Size = new System.Drawing.Size(152, 20);
            this.lblSelectDate.TabIndex = 9;
            this.lblSelectDate.Text = "Select Delivery Date";
            // 
            // dtpSelectDeliveryDate
            // 
            this.dtpSelectDeliveryDate.Location = new System.Drawing.Point(411, 155);
            this.dtpSelectDeliveryDate.Name = "dtpSelectDeliveryDate";
            this.dtpSelectDeliveryDate.Size = new System.Drawing.Size(253, 20);
            this.dtpSelectDeliveryDate.TabIndex = 10;
            // 
            // lblEarliest
            // 
            this.lblEarliest.AutoSize = true;
            this.lblEarliest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEarliest.Location = new System.Drawing.Point(407, 62);
            this.lblEarliest.Name = "lblEarliest";
            this.lblEarliest.Size = new System.Drawing.Size(379, 20);
            this.lblEarliest.TabIndex = 11;
            this.lblEarliest.Text = "Earliest Delivery Date Possible For Selected Session";
            // 
            // tbEarliestDeliveryDate
            // 
            this.tbEarliestDeliveryDate.Location = new System.Drawing.Point(411, 85);
            this.tbEarliestDeliveryDate.Name = "tbEarliestDeliveryDate";
            this.tbEarliestDeliveryDate.ReadOnly = true;
            this.tbEarliestDeliveryDate.Size = new System.Drawing.Size(253, 20);
            this.tbEarliestDeliveryDate.TabIndex = 12;
            // 
            // lblProductsDelivered
            // 
            this.lblProductsDelivered.AutoSize = true;
            this.lblProductsDelivered.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductsDelivered.Location = new System.Drawing.Point(201, 205);
            this.lblProductsDelivered.Name = "lblProductsDelivered";
            this.lblProductsDelivered.Size = new System.Drawing.Size(249, 24);
            this.lblProductsDelivered.TabIndex = 13;
            this.lblProductsDelivered.Text = "Products To Be Delivered";
            // 
            // dgvProductsDelivered
            // 
            this.dgvProductsDelivered.AllowUserToAddRows = false;
            this.dgvProductsDelivered.AllowUserToDeleteRows = false;
            this.dgvProductsDelivered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsDelivered.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.quantityColumn});
            this.dgvProductsDelivered.Location = new System.Drawing.Point(205, 241);
            this.dgvProductsDelivered.Name = "dgvProductsDelivered";
            this.dgvProductsDelivered.ReadOnly = true;
            this.dgvProductsDelivered.RowTemplate.Height = 24;
            this.dgvProductsDelivered.Size = new System.Drawing.Size(394, 137);
            this.dgvProductsDelivered.TabIndex = 14;
            // 
            // btnArrangeDelivery
            // 
            this.btnArrangeDelivery.BackColor = System.Drawing.Color.DarkOrange;
            this.btnArrangeDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArrangeDelivery.ForeColor = System.Drawing.SystemColors.Window;
            this.btnArrangeDelivery.Location = new System.Drawing.Point(302, 409);
            this.btnArrangeDelivery.Name = "btnArrangeDelivery";
            this.btnArrangeDelivery.Size = new System.Drawing.Size(197, 55);
            this.btnArrangeDelivery.TabIndex = 109;
            this.btnArrangeDelivery.Text = "Arrange Delivery";
            this.btnArrangeDelivery.UseVisualStyleBackColor = false;
            this.btnArrangeDelivery.Click += new System.EventHandler(this.btnArrangeDelivery_Click);
            // 
            // btnSplitDelivery
            // 
            this.btnSplitDelivery.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSplitDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSplitDelivery.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSplitDelivery.Location = new System.Drawing.Point(642, 422);
            this.btnSplitDelivery.Name = "btnSplitDelivery";
            this.btnSplitDelivery.Size = new System.Drawing.Size(133, 42);
            this.btnSplitDelivery.TabIndex = 110;
            this.btnSplitDelivery.Text = "Split Delivery";
            this.btnSplitDelivery.UseVisualStyleBackColor = false;
            this.btnSplitDelivery.Click += new System.EventHandler(this.btnSplitDelivery_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 20);
            this.label1.TabIndex = 111;
            this.label1.Text = "Customer Chosen Delivery Session";
            // 
            // tbCustomerChosenDeliverySession
            // 
            this.tbCustomerChosenDeliverySession.Location = new System.Drawing.Point(101, 85);
            this.tbCustomerChosenDeliverySession.Name = "tbCustomerChosenDeliverySession";
            this.tbCustomerChosenDeliverySession.ReadOnly = true;
            this.tbCustomerChosenDeliverySession.Size = new System.Drawing.Size(253, 20);
            this.tbCustomerChosenDeliverySession.TabIndex = 112;
            // 
            // tbSelectedCourier
            // 
            this.tbSelectedCourier.Location = new System.Drawing.Point(101, 155);
            this.tbSelectedCourier.Name = "tbSelectedCourier";
            this.tbSelectedCourier.ReadOnly = true;
            this.tbSelectedCourier.Size = new System.Drawing.Size(253, 20);
            this.tbSelectedCourier.TabIndex = 113;
            // 
            // btnChooseCourier
            // 
            this.btnChooseCourier.BackColor = System.Drawing.Color.ForestGreen;
            this.btnChooseCourier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseCourier.ForeColor = System.Drawing.SystemColors.Window;
            this.btnChooseCourier.Location = new System.Drawing.Point(273, 119);
            this.btnChooseCourier.Name = "btnChooseCourier";
            this.btnChooseCourier.Size = new System.Drawing.Size(81, 34);
            this.btnChooseCourier.TabIndex = 114;
            this.btnChooseCourier.Text = "Choose";
            this.btnChooseCourier.UseVisualStyleBackColor = false;
            this.btnChooseCourier.Click += new System.EventHandler(this.btnChooseCourier_Click);
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            this.nameColumn.Width = 200;
            // 
            // quantityColumn
            // 
            this.quantityColumn.HeaderText = "Quantity";
            this.quantityColumn.Name = "quantityColumn";
            this.quantityColumn.ReadOnly = true;
            this.quantityColumn.Width = 150;
            // 
            // ArrangeSingleDeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.btnChooseCourier);
            this.Controls.Add(this.tbSelectedCourier);
            this.Controls.Add(this.tbCustomerChosenDeliverySession);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSplitDelivery);
            this.Controls.Add(this.btnArrangeDelivery);
            this.Controls.Add(this.dgvProductsDelivered);
            this.Controls.Add(this.lblProductsDelivered);
            this.Controls.Add(this.tbEarliestDeliveryDate);
            this.Controls.Add(this.lblEarliest);
            this.Controls.Add(this.dtpSelectDeliveryDate);
            this.Controls.Add(this.lblSelectDate);
            this.Controls.Add(this.lblSelectCourier);
            this.Name = "ArrangeSingleDeliveryForm";
            this.Text = "ArrangeSingleDeliveryForm";
            this.Shown += new System.EventHandler(this.OnFormShown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsDelivered)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSelectCourier;
        private System.Windows.Forms.Label lblSelectDate;
        private System.Windows.Forms.DateTimePicker dtpSelectDeliveryDate;
        private System.Windows.Forms.Label lblEarliest;
        private System.Windows.Forms.TextBox tbEarliestDeliveryDate;
        private System.Windows.Forms.Label lblProductsDelivered;
        private System.Windows.Forms.DataGridView dgvProductsDelivered;
        private System.Windows.Forms.Button btnArrangeDelivery;
        private System.Windows.Forms.Button btnSplitDelivery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCustomerChosenDeliverySession;
        private System.Windows.Forms.TextBox tbSelectedCourier;
        private System.Windows.Forms.Button btnChooseCourier;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityColumn;
    }
}
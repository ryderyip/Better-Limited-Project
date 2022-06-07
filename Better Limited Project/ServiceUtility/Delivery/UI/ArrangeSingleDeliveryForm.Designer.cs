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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArrangeSingleDeliveryForm));
            this.lblSelectCourier = new System.Windows.Forms.Label();
            this.lblSelectDate = new System.Windows.Forms.Label();
            this.dtpSelectDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.lblEarliest = new System.Windows.Forms.Label();
            this.tbEarliestDeliveryDate = new System.Windows.Forms.TextBox();
            this.lblProductsDelivered = new System.Windows.Forms.Label();
            this.dgvProductsDelivered = new System.Windows.Forms.DataGridView();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnArrangeDelivery = new System.Windows.Forms.Button();
            this.btnSplitDelivery = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCustomerChosenDeliverySession = new System.Windows.Forms.TextBox();
            this.tbSelectedCourier = new System.Windows.Forms.TextBox();
            this.btnChooseCourier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsDelivered)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectCourier
            // 
            resources.ApplyResources(this.lblSelectCourier, "lblSelectCourier");
            this.lblSelectCourier.Name = "lblSelectCourier";
            // 
            // lblSelectDate
            // 
            resources.ApplyResources(this.lblSelectDate, "lblSelectDate");
            this.lblSelectDate.Name = "lblSelectDate";
            // 
            // dtpSelectDeliveryDate
            // 
            resources.ApplyResources(this.dtpSelectDeliveryDate, "dtpSelectDeliveryDate");
            this.dtpSelectDeliveryDate.Name = "dtpSelectDeliveryDate";
            // 
            // lblEarliest
            // 
            resources.ApplyResources(this.lblEarliest, "lblEarliest");
            this.lblEarliest.Name = "lblEarliest";
            // 
            // tbEarliestDeliveryDate
            // 
            resources.ApplyResources(this.tbEarliestDeliveryDate, "tbEarliestDeliveryDate");
            this.tbEarliestDeliveryDate.Name = "tbEarliestDeliveryDate";
            this.tbEarliestDeliveryDate.ReadOnly = true;
            // 
            // lblProductsDelivered
            // 
            resources.ApplyResources(this.lblProductsDelivered, "lblProductsDelivered");
            this.lblProductsDelivered.Name = "lblProductsDelivered";
            // 
            // dgvProductsDelivered
            // 
            this.dgvProductsDelivered.AllowUserToAddRows = false;
            this.dgvProductsDelivered.AllowUserToDeleteRows = false;
            this.dgvProductsDelivered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsDelivered.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.quantityColumn});
            resources.ApplyResources(this.dgvProductsDelivered, "dgvProductsDelivered");
            this.dgvProductsDelivered.Name = "dgvProductsDelivered";
            this.dgvProductsDelivered.ReadOnly = true;
            this.dgvProductsDelivered.RowTemplate.Height = 24;
            // 
            // nameColumn
            // 
            resources.ApplyResources(this.nameColumn, "nameColumn");
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // quantityColumn
            // 
            resources.ApplyResources(this.quantityColumn, "quantityColumn");
            this.quantityColumn.Name = "quantityColumn";
            this.quantityColumn.ReadOnly = true;
            // 
            // btnArrangeDelivery
            // 
            this.btnArrangeDelivery.BackColor = System.Drawing.Color.DarkOrange;
            resources.ApplyResources(this.btnArrangeDelivery, "btnArrangeDelivery");
            this.btnArrangeDelivery.ForeColor = System.Drawing.SystemColors.Window;
            this.btnArrangeDelivery.Name = "btnArrangeDelivery";
            this.btnArrangeDelivery.UseVisualStyleBackColor = false;
            this.btnArrangeDelivery.Click += new System.EventHandler(this.btnArrangeDelivery_Click);
            // 
            // btnSplitDelivery
            // 
            this.btnSplitDelivery.BackColor = System.Drawing.SystemColors.MenuHighlight;
            resources.ApplyResources(this.btnSplitDelivery, "btnSplitDelivery");
            this.btnSplitDelivery.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSplitDelivery.Name = "btnSplitDelivery";
            this.btnSplitDelivery.UseVisualStyleBackColor = false;
            this.btnSplitDelivery.Click += new System.EventHandler(this.btnSplitDelivery_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tbCustomerChosenDeliverySession
            // 
            resources.ApplyResources(this.tbCustomerChosenDeliverySession, "tbCustomerChosenDeliverySession");
            this.tbCustomerChosenDeliverySession.Name = "tbCustomerChosenDeliverySession";
            this.tbCustomerChosenDeliverySession.ReadOnly = true;
            // 
            // tbSelectedCourier
            // 
            resources.ApplyResources(this.tbSelectedCourier, "tbSelectedCourier");
            this.tbSelectedCourier.Name = "tbSelectedCourier";
            this.tbSelectedCourier.ReadOnly = true;
            // 
            // btnChooseCourier
            // 
            this.btnChooseCourier.BackColor = System.Drawing.Color.ForestGreen;
            resources.ApplyResources(this.btnChooseCourier, "btnChooseCourier");
            this.btnChooseCourier.ForeColor = System.Drawing.SystemColors.Window;
            this.btnChooseCourier.Name = "btnChooseCourier";
            this.btnChooseCourier.UseVisualStyleBackColor = false;
            this.btnChooseCourier.Click += new System.EventHandler(this.btnChooseCourier_Click);
            // 
            // ArrangeSingleDeliveryForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
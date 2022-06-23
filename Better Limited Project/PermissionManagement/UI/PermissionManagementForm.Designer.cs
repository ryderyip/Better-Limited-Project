
namespace Better_Limited_Project.PermissionManagement.UI
{
    partial class PermissionManagementForm
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblPurchasedGoods = new System.Windows.Forms.Label();
            this.cbPermissions = new System.Windows.Forms.ComboBox();
            this.lblSelectPermission = new System.Windows.Forms.Label();
            this.tbPermissionName = new System.Windows.Forms.TextBox();
            this.lblPurchaseOrder = new System.Windows.Forms.Label();
            this.tbPermissionDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cblPermittedStaffTitles = new System.Windows.Forms.CheckedListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDiscardChanges = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHeader.Location = new System.Drawing.Point(153, 23);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(222, 26);
            this.lblHeader.TabIndex = 198;
            this.lblHeader.Text = "Manage Permission";
            // 
            // lblPurchasedGoods
            // 
            this.lblPurchasedGoods.AutoSize = true;
            this.lblPurchasedGoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchasedGoods.Location = new System.Drawing.Point(29, 85);
            this.lblPurchasedGoods.Name = "lblPurchasedGoods";
            this.lblPurchasedGoods.Size = new System.Drawing.Size(180, 20);
            this.lblPurchasedGoods.TabIndex = 221;
            this.lblPurchasedGoods.Text = "Product Management";
            // 
            // cbPermissions
            // 
            this.cbPermissions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPermissions.FormattingEnabled = true;
            this.cbPermissions.Location = new System.Drawing.Point(33, 141);
            this.cbPermissions.Name = "cbPermissions";
            this.cbPermissions.Size = new System.Drawing.Size(226, 21);
            this.cbPermissions.TabIndex = 222;
            // 
            // lblSelectPermission
            // 
            this.lblSelectPermission.AutoSize = true;
            this.lblSelectPermission.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSelectPermission.Location = new System.Drawing.Point(30, 125);
            this.lblSelectPermission.Name = "lblSelectPermission";
            this.lblSelectPermission.Size = new System.Drawing.Size(90, 13);
            this.lblSelectPermission.TabIndex = 223;
            this.lblSelectPermission.Text = "Select Permission";
            // 
            // tbPermissionName
            // 
            this.tbPermissionName.Location = new System.Drawing.Point(33, 205);
            this.tbPermissionName.Name = "tbPermissionName";
            this.tbPermissionName.ReadOnly = true;
            this.tbPermissionName.Size = new System.Drawing.Size(226, 20);
            this.tbPermissionName.TabIndex = 225;
            // 
            // lblPurchaseOrder
            // 
            this.lblPurchaseOrder.AutoSize = true;
            this.lblPurchaseOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblPurchaseOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPurchaseOrder.Location = new System.Drawing.Point(30, 187);
            this.lblPurchaseOrder.Name = "lblPurchaseOrder";
            this.lblPurchaseOrder.Size = new System.Drawing.Size(41, 15);
            this.lblPurchaseOrder.TabIndex = 224;
            this.lblPurchaseOrder.Text = "Name";
            // 
            // tbPermissionDescription
            // 
            this.tbPermissionDescription.Location = new System.Drawing.Point(33, 274);
            this.tbPermissionDescription.Multiline = true;
            this.tbPermissionDescription.Name = "tbPermissionDescription";
            this.tbPermissionDescription.ReadOnly = true;
            this.tbPermissionDescription.Size = new System.Drawing.Size(226, 58);
            this.tbPermissionDescription.TabIndex = 227;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(30, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 226;
            this.label1.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(285, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 228;
            this.label2.Text = "Permitted Staff Titles";
            // 
            // cblPermittedStaffTitles
            // 
            this.cblPermittedStaffTitles.FormattingEnabled = true;
            this.cblPermittedStaffTitles.Location = new System.Drawing.Point(288, 148);
            this.cblPermittedStaffTitles.Name = "cblPermittedStaffTitles";
            this.cblPermittedStaffTitles.Size = new System.Drawing.Size(207, 184);
            this.cblPermittedStaffTitles.TabIndex = 230;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSave.Location = new System.Drawing.Point(414, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 49);
            this.btnSave.TabIndex = 231;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnDiscardChanges
            // 
            this.btnDiscardChanges.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnDiscardChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnDiscardChanges.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDiscardChanges.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDiscardChanges.Location = new System.Drawing.Point(424, 101);
            this.btnDiscardChanges.Name = "btnDiscardChanges";
            this.btnDiscardChanges.Size = new System.Drawing.Size(71, 41);
            this.btnDiscardChanges.TabIndex = 232;
            this.btnDiscardChanges.Text = "Discard Changes";
            this.btnDiscardChanges.UseVisualStyleBackColor = false;
            // 
            // PermissionManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 362);
            this.Controls.Add(this.btnDiscardChanges);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cblPermittedStaffTitles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPermissionDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPermissionName);
            this.Controls.Add(this.lblPurchaseOrder);
            this.Controls.Add(this.lblSelectPermission);
            this.Controls.Add(this.cbPermissions);
            this.Controls.Add(this.lblPurchasedGoods);
            this.Controls.Add(this.lblHeader);
            this.Name = "PermissionManagementForm";
            this.Text = "PermissionManagementForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblPurchasedGoods;
        private System.Windows.Forms.ComboBox cbPermissions;
        private System.Windows.Forms.Label lblSelectPermission;
        private System.Windows.Forms.TextBox tbPermissionName;
        private System.Windows.Forms.Label lblPurchaseOrder;
        private System.Windows.Forms.TextBox tbPermissionDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox cblPermittedStaffTitles;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDiscardChanges;
    }
}
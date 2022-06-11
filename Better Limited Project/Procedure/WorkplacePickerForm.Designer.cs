
namespace Better_Limited_Project.Procedure
{
    partial class WorkplacePickerForm
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
            this.cbWorkplace = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHeader.Location = new System.Drawing.Point(57, 22);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(218, 29);
            this.lblHeader.TabIndex = 157;
            this.lblHeader.Text = "Select Workplace";
            // 
            // cbWorkplace
            // 
            this.cbWorkplace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWorkplace.FormattingEnabled = true;
            this.cbWorkplace.Location = new System.Drawing.Point(55, 98);
            this.cbWorkplace.Name = "cbWorkplace";
            this.cbWorkplace.Size = new System.Drawing.Size(226, 21);
            this.cbWorkplace.TabIndex = 158;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSelect.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSelect.Location = new System.Drawing.Point(99, 160);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(134, 50);
            this.btnSelect.TabIndex = 160;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // WorkplacePickerForm
            // 
            this.AcceptButton = this.btnSelect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 230);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.cbWorkplace);
            this.Controls.Add(this.lblHeader);
            this.Name = "WorkplacePickerForm";
            this.Text = "WorkplacePickerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ComboBox cbWorkplace;
        private System.Windows.Forms.Button btnSelect;
    }
}
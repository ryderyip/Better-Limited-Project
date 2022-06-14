
namespace Better_Limited_Project.ServiceUtility.InstallationUtility.UI
{
    partial class ArrangeInstallationForm
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
            this.tbSelectedTechnicians = new System.Windows.Forms.TextBox();
            this.lblSelectTechnicians = new System.Windows.Forms.Label();
            this.btnSelectTechnicians = new System.Windows.Forms.Button();
            this.btnArrange = new System.Windows.Forms.Button();
            this.lblScheduledOn = new System.Windows.Forms.Label();
            this.dtpScheduledDate = new System.Windows.Forms.DateTimePicker();
            this.dtpScheduledTime = new System.Windows.Forms.DateTimePicker();
            this.helpCannotChooseScheduleDateTime = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHeader.Location = new System.Drawing.Point(51, 26);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(238, 29);
            this.lblHeader.TabIndex = 127;
            this.lblHeader.Text = "Arrange Installation";
            // 
            // tbSelectedTechnicians
            // 
            this.tbSelectedTechnicians.Location = new System.Drawing.Point(19, 169);
            this.tbSelectedTechnicians.Name = "tbSelectedTechnicians";
            this.tbSelectedTechnicians.ReadOnly = true;
            this.tbSelectedTechnicians.Size = new System.Drawing.Size(200, 20);
            this.tbSelectedTechnicians.TabIndex = 128;
            this.tbSelectedTechnicians.Text = "-";
            // 
            // lblSelectTechnicians
            // 
            this.lblSelectTechnicians.AutoSize = true;
            this.lblSelectTechnicians.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblSelectTechnicians.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSelectTechnicians.Location = new System.Drawing.Point(16, 150);
            this.lblSelectTechnicians.Name = "lblSelectTechnicians";
            this.lblSelectTechnicians.Size = new System.Drawing.Size(130, 16);
            this.lblSelectTechnicians.TabIndex = 129;
            this.lblSelectTechnicians.Text = "Select Technician(s)";
            // 
            // btnSelectTechnicians
            // 
            this.btnSelectTechnicians.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSelectTechnicians.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSelectTechnicians.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSelectTechnicians.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSelectTechnicians.Location = new System.Drawing.Point(240, 161);
            this.btnSelectTechnicians.Name = "btnSelectTechnicians";
            this.btnSelectTechnicians.Size = new System.Drawing.Size(81, 34);
            this.btnSelectTechnicians.TabIndex = 130;
            this.btnSelectTechnicians.Text = "Select";
            this.btnSelectTechnicians.UseVisualStyleBackColor = false;
            this.btnSelectTechnicians.Click += new System.EventHandler(this.btnSelectTechnicians_Click);
            // 
            // btnArrange
            // 
            this.btnArrange.BackColor = System.Drawing.Color.DarkOrange;
            this.btnArrange.Enabled = false;
            this.btnArrange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnArrange.ForeColor = System.Drawing.SystemColors.Window;
            this.btnArrange.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnArrange.Location = new System.Drawing.Point(72, 228);
            this.btnArrange.Name = "btnArrange";
            this.btnArrange.Size = new System.Drawing.Size(197, 55);
            this.btnArrange.TabIndex = 131;
            this.btnArrange.Text = "Arrange";
            this.btnArrange.UseVisualStyleBackColor = false;
            this.btnArrange.Click += new System.EventHandler(this.btnArrange_Click);
            // 
            // lblScheduledOn
            // 
            this.lblScheduledOn.AutoSize = true;
            this.lblScheduledOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblScheduledOn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblScheduledOn.Location = new System.Drawing.Point(16, 92);
            this.lblScheduledOn.Name = "lblScheduledOn";
            this.lblScheduledOn.Size = new System.Drawing.Size(93, 16);
            this.lblScheduledOn.TabIndex = 133;
            this.lblScheduledOn.Text = "Scheduled On";
            // 
            // dtpScheduledDate
            // 
            this.dtpScheduledDate.Location = new System.Drawing.Point(19, 111);
            this.dtpScheduledDate.Name = "dtpScheduledDate";
            this.dtpScheduledDate.Size = new System.Drawing.Size(200, 20);
            this.dtpScheduledDate.TabIndex = 134;
            // 
            // dtpScheduledTime
            // 
            this.dtpScheduledTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpScheduledTime.Location = new System.Drawing.Point(240, 111);
            this.dtpScheduledTime.Name = "dtpScheduledTime";
            this.dtpScheduledTime.Size = new System.Drawing.Size(85, 20);
            this.dtpScheduledTime.TabIndex = 135;
            // 
            // ArrangeInstallationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 306);
            this.Controls.Add(this.dtpScheduledTime);
            this.Controls.Add(this.dtpScheduledDate);
            this.Controls.Add(this.lblScheduledOn);
            this.Controls.Add(this.btnArrange);
            this.Controls.Add(this.btnSelectTechnicians);
            this.Controls.Add(this.lblSelectTechnicians);
            this.Controls.Add(this.tbSelectedTechnicians);
            this.Controls.Add(this.lblHeader);
            this.Name = "ArrangeInstallationForm";
            this.Text = "ArrangeInstallationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox tbSelectedTechnicians;
        private System.Windows.Forms.Label lblSelectTechnicians;
        private System.Windows.Forms.Button btnSelectTechnicians;
        private System.Windows.Forms.Button btnArrange;
        private System.Windows.Forms.Label lblScheduledOn;
        private System.Windows.Forms.DateTimePicker dtpScheduledDate;
        private System.Windows.Forms.DateTimePicker dtpScheduledTime;
        private System.Windows.Forms.HelpProvider helpCannotChooseScheduleDateTime;
    }
}
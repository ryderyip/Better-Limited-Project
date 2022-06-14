
namespace Better_Limited_Project.ServiceUtility.DeliveryUtility.UI
{
    partial class UpdateDeliveryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateDeliveryForm));
            this.tbDeliveredOn = new System.Windows.Forms.TextBox();
            this.lbltbDeliveredOn = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblScheduledOn = new System.Windows.Forms.Label();
            this.tbScheduledOn = new System.Windows.Forms.TextBox();
            this.lblDispatchedOn = new System.Windows.Forms.Label();
            this.tbDispatchedOn = new System.Windows.Forms.TextBox();
            this.dtpNewScheduledOnDate = new System.Windows.Forms.DateTimePicker();
            this.lblNewDeliveredOn = new System.Windows.Forms.Label();
            this.lblNewDispatchedOn = new System.Windows.Forms.Label();
            this.lblNewScheduledOn = new System.Windows.Forms.Label();
            this.dtpNewDispatchedOnDate = new System.Windows.Forms.DateTimePicker();
            this.dtpNewDeliveredOnDate = new System.Windows.Forms.DateTimePicker();
            this.dtpNewScheduledOnTime = new System.Windows.Forms.DateTimePicker();
            this.dtpNewDispatchedOnTime = new System.Windows.Forms.DateTimePicker();
            this.dtpNewDeliveredOnTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // tbDeliveredOn
            // 
            resources.ApplyResources(this.tbDeliveredOn, "tbDeliveredOn");
            this.tbDeliveredOn.Name = "tbDeliveredOn";
            this.tbDeliveredOn.ReadOnly = true;
            // 
            // lbltbDeliveredOn
            // 
            resources.ApplyResources(this.lbltbDeliveredOn, "lbltbDeliveredOn");
            this.lbltbDeliveredOn.Name = "lbltbDeliveredOn";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkOrange;
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblHeader
            // 
            resources.ApplyResources(this.lblHeader, "lblHeader");
            this.lblHeader.Name = "lblHeader";
            // 
            // lblScheduledOn
            // 
            resources.ApplyResources(this.lblScheduledOn, "lblScheduledOn");
            this.lblScheduledOn.Name = "lblScheduledOn";
            // 
            // tbScheduledOn
            // 
            resources.ApplyResources(this.tbScheduledOn, "tbScheduledOn");
            this.tbScheduledOn.Name = "tbScheduledOn";
            this.tbScheduledOn.ReadOnly = true;
            // 
            // lblDispatchedOn
            // 
            resources.ApplyResources(this.lblDispatchedOn, "lblDispatchedOn");
            this.lblDispatchedOn.Name = "lblDispatchedOn";
            // 
            // tbDispatchedOn
            // 
            resources.ApplyResources(this.tbDispatchedOn, "tbDispatchedOn");
            this.tbDispatchedOn.Name = "tbDispatchedOn";
            this.tbDispatchedOn.ReadOnly = true;
            // 
            // dtpNewScheduledOnDate
            // 
            resources.ApplyResources(this.dtpNewScheduledOnDate, "dtpNewScheduledOnDate");
            this.dtpNewScheduledOnDate.Name = "dtpNewScheduledOnDate";
            // 
            // lblNewDeliveredOn
            // 
            resources.ApplyResources(this.lblNewDeliveredOn, "lblNewDeliveredOn");
            this.lblNewDeliveredOn.Name = "lblNewDeliveredOn";
            // 
            // lblNewDispatchedOn
            // 
            resources.ApplyResources(this.lblNewDispatchedOn, "lblNewDispatchedOn");
            this.lblNewDispatchedOn.Name = "lblNewDispatchedOn";
            // 
            // lblNewScheduledOn
            // 
            resources.ApplyResources(this.lblNewScheduledOn, "lblNewScheduledOn");
            this.lblNewScheduledOn.Name = "lblNewScheduledOn";
            // 
            // dtpNewDispatchedOnDate
            // 
            resources.ApplyResources(this.dtpNewDispatchedOnDate, "dtpNewDispatchedOnDate");
            this.dtpNewDispatchedOnDate.Name = "dtpNewDispatchedOnDate";
            this.dtpNewDispatchedOnDate.ValueChanged += new System.EventHandler(this.dtpNewDispatchedOnDate_ValueChanged);
            this.dtpNewDispatchedOnDate.ValueChanged += new System.EventHandler((sender, e) => this.dtpNewDispatchedOnDateOrTime_ValueChanged());
            // 
            // dtpNewDeliveredOnDate
            // 
            resources.ApplyResources(this.dtpNewDeliveredOnDate, "dtpNewDeliveredOnDate");
            this.dtpNewDeliveredOnDate.Name = "dtpNewDeliveredOnDate";
            this.dtpNewDeliveredOnDate.ValueChanged += new System.EventHandler(this.dtpNewDeliveredOnDate_ValueChanged);
            // 
            // dtpNewScheduledOnTime
            // 
            this.dtpNewScheduledOnTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            resources.ApplyResources(this.dtpNewScheduledOnTime, "dtpNewScheduledOnTime");
            this.dtpNewScheduledOnTime.Name = "dtpNewScheduledOnTime";
            // 
            // dtpNewDispatchedOnTime
            // 
            this.dtpNewDispatchedOnTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            resources.ApplyResources(this.dtpNewDispatchedOnTime, "dtpNewDispatchedOnTime");
            this.dtpNewDispatchedOnTime.Name = "dtpNewDispatchedOnTime";
            this.dtpNewDispatchedOnTime.ValueChanged += new System.EventHandler(this.dtpNewDispatchedOnTime_ValueChanged);
            this.dtpNewDispatchedOnTime.ValueChanged += new System.EventHandler((sender, e) => this.dtpNewDispatchedOnDateOrTime_ValueChanged());
            // 
            // dtpNewDeliveredOnTime
            // 
            this.dtpNewDeliveredOnTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            resources.ApplyResources(this.dtpNewDeliveredOnTime, "dtpNewDeliveredOnTime");
            this.dtpNewDeliveredOnTime.Name = "dtpNewDeliveredOnTime";
            // 
            // UpdateDeliveryForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpNewDeliveredOnTime);
            this.Controls.Add(this.dtpNewDispatchedOnTime);
            this.Controls.Add(this.dtpNewScheduledOnTime);
            this.Controls.Add(this.dtpNewDeliveredOnDate);
            this.Controls.Add(this.dtpNewDispatchedOnDate);
            this.Controls.Add(this.lblNewDeliveredOn);
            this.Controls.Add(this.lblNewDispatchedOn);
            this.Controls.Add(this.lblNewScheduledOn);
            this.Controls.Add(this.dtpNewScheduledOnDate);
            this.Controls.Add(this.tbDeliveredOn);
            this.Controls.Add(this.lbltbDeliveredOn);
            this.Controls.Add(this.tbDispatchedOn);
            this.Controls.Add(this.lblDispatchedOn);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbScheduledOn);
            this.Controls.Add(this.lblScheduledOn);
            this.Controls.Add(this.lblHeader);
            this.Name = "UpdateDeliveryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDeliveredOn;
        private System.Windows.Forms.Label lbltbDeliveredOn;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblScheduledOn;
        private System.Windows.Forms.TextBox tbScheduledOn;
        private System.Windows.Forms.Label lblDispatchedOn;
        private System.Windows.Forms.TextBox tbDispatchedOn;
        private System.Windows.Forms.DateTimePicker dtpNewScheduledOnDate;
        private System.Windows.Forms.Label lblNewDeliveredOn;
        private System.Windows.Forms.Label lblNewDispatchedOn;
        private System.Windows.Forms.Label lblNewScheduledOn;
        private System.Windows.Forms.DateTimePicker dtpNewDispatchedOnDate;
        private System.Windows.Forms.DateTimePicker dtpNewDeliveredOnDate;
        private System.Windows.Forms.DateTimePicker dtpNewScheduledOnTime;
        private System.Windows.Forms.DateTimePicker dtpNewDispatchedOnTime;
        private System.Windows.Forms.DateTimePicker dtpNewDeliveredOnTime;
    }
}
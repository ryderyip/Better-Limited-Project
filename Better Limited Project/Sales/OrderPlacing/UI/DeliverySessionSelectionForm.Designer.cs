namespace Better_Limited_Project.Sales.OrderPlacing.UI
{
    partial class DeliverySessionSelectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliverySessionSelectionForm));
            this.lblSelectDeliverySession = new System.Windows.Forms.Label();
            this.radioButtonMorning = new System.Windows.Forms.RadioButton();
            this.radioButtonEvening = new System.Windows.Forms.RadioButton();
            this.radioButtonAfternoon = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelectDeliverySession
            // 
            resources.ApplyResources(this.lblSelectDeliverySession, "lblSelectDeliverySession");
            this.lblSelectDeliverySession.Name = "lblSelectDeliverySession";
            // 
            // radioButtonMorning
            // 
            resources.ApplyResources(this.radioButtonMorning, "radioButtonMorning");
            this.radioButtonMorning.Name = "radioButtonMorning";
            this.radioButtonMorning.TabStop = true;
            this.radioButtonMorning.UseVisualStyleBackColor = true;
            // 
            // radioButtonEvening
            // 
            resources.ApplyResources(this.radioButtonEvening, "radioButtonEvening");
            this.radioButtonEvening.Name = "radioButtonEvening";
            this.radioButtonEvening.TabStop = true;
            this.radioButtonEvening.UseVisualStyleBackColor = true;
            // 
            // radioButtonAfternoon
            // 
            resources.ApplyResources(this.radioButtonAfternoon, "radioButtonAfternoon");
            this.radioButtonAfternoon.Name = "radioButtonAfternoon";
            this.radioButtonAfternoon.TabStop = true;
            this.radioButtonAfternoon.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.DarkOrange;
            resources.ApplyResources(this.btnNext, "btnNext");
            this.btnNext.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNext.Name = "btnNext";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // DeliverySessionSelectionForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.radioButtonAfternoon);
            this.Controls.Add(this.radioButtonEvening);
            this.Controls.Add(this.radioButtonMorning);
            this.Controls.Add(this.lblSelectDeliverySession);
            this.Name = "DeliverySessionSelectionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectDeliverySession;
        private System.Windows.Forms.RadioButton radioButtonMorning;
        private System.Windows.Forms.RadioButton radioButtonEvening;
        private System.Windows.Forms.RadioButton radioButtonAfternoon;
        private System.Windows.Forms.Button btnNext;
    }
}
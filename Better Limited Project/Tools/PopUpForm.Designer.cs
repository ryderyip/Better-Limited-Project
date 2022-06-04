
namespace Better_Limited_Project.Tools
{
    partial class PopUpForm
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
            this.tbMainText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbMainText
            // 
            this.tbMainText.BackColor = System.Drawing.Color.DodgerBlue;
            this.tbMainText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMainText.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMainText.ForeColor = System.Drawing.Color.White;
            this.tbMainText.Location = new System.Drawing.Point(12, 12);
            this.tbMainText.Multiline = true;
            this.tbMainText.Name = "tbMainText";
            this.tbMainText.ReadOnly = true;
            this.tbMainText.Size = new System.Drawing.Size(273, 98);
            this.tbMainText.TabIndex = 1;
            this.tbMainText.Text = "(TEXT)";
            this.tbMainText.Click += new System.EventHandler(this.tbMainText_Click);
            // 
            // PopUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(297, 122);
            this.ControlBox = false;
            this.Controls.Add(this.tbMainText);
            this.KeyPreview = true;
            this.Name = "PopUpForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PopUpForm";
            this.TopMost = true;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PopUpForm_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PopUpForm_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMainText;
    }
}
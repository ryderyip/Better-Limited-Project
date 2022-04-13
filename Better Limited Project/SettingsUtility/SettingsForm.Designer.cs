using System.ComponentModel;

namespace Better_Limited_Project.SettingsUtility
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblDocument = new System.Windows.Forms.Label();
            this.lblAppearance = new System.Windows.Forms.Label();
            this.lblWorkplace = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.rbEnglish = new System.Windows.Forms.RadioButton();
            this.rbTraditionalChinese = new System.Windows.Forms.RadioButton();
            this.rbSimplifiedChinese = new System.Windows.Forms.RadioButton();
            this.lblDocPath = new System.Windows.Forms.Label();
            this.tbDocPath = new System.Windows.Forms.TextBox();
            this.btnBrowseDocPath = new System.Windows.Forms.Button();
            this.btnSelectDocPath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLanguage
            // 
            this.lblLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblLanguage.Location = new System.Drawing.Point(38, 34);
            this.lblLanguage.Margin = new System.Windows.Forms.Padding(3);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(215, 31);
            this.lblLanguage.TabIndex = 0;
            this.lblLanguage.Text = "Language Settings";
            this.lblLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDocument
            // 
            this.lblDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblDocument.Location = new System.Drawing.Point(38, 327);
            this.lblDocument.Name = "lblDocument";
            this.lblDocument.Size = new System.Drawing.Size(215, 31);
            this.lblDocument.TabIndex = 1;
            this.lblDocument.Text = "Document Settings";
            this.lblDocument.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAppearance
            // 
            this.lblAppearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblAppearance.Location = new System.Drawing.Point(38, 509);
            this.lblAppearance.Name = "lblAppearance";
            this.lblAppearance.Size = new System.Drawing.Size(247, 31);
            this.lblAppearance.TabIndex = 2;
            this.lblAppearance.Text = "Appearance Settings";
            this.lblAppearance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWorkplace
            // 
            this.lblWorkplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblWorkplace.Location = new System.Drawing.Point(38, 216);
            this.lblWorkplace.Name = "lblWorkplace";
            this.lblWorkplace.Size = new System.Drawing.Size(228, 31);
            this.lblWorkplace.TabIndex = 3;
            this.lblWorkplace.Text = "Workplace Settings";
            this.lblWorkplace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Coral;
            this.btnUpdate.Font = new System.Drawing.Font("Noto Sans", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdate.Location = new System.Drawing.Point(360, 577);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 44);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // rbEnglish
            // 
            this.rbEnglish.Location = new System.Drawing.Point(38, 78);
            this.rbEnglish.Name = "rbEnglish";
            this.rbEnglish.Size = new System.Drawing.Size(62, 24);
            this.rbEnglish.TabIndex = 7;
            this.rbEnglish.TabStop = true;
            this.rbEnglish.Text = "English";
            this.rbEnglish.UseVisualStyleBackColor = true;
            // 
            // rbTraditionalChinese
            // 
            this.rbTraditionalChinese.Location = new System.Drawing.Point(38, 108);
            this.rbTraditionalChinese.Name = "rbTraditionalChinese";
            this.rbTraditionalChinese.Size = new System.Drawing.Size(115, 24);
            this.rbTraditionalChinese.TabIndex = 8;
            this.rbTraditionalChinese.TabStop = true;
            this.rbTraditionalChinese.Text = "Traditional Chinese";
            this.rbTraditionalChinese.UseVisualStyleBackColor = true;
            // 
            // rbSimplifiedChinese
            // 
            this.rbSimplifiedChinese.Location = new System.Drawing.Point(38, 138);
            this.rbSimplifiedChinese.Name = "rbSimplifiedChinese";
            this.rbSimplifiedChinese.Size = new System.Drawing.Size(115, 24);
            this.rbSimplifiedChinese.TabIndex = 9;
            this.rbSimplifiedChinese.TabStop = true;
            this.rbSimplifiedChinese.Text = "Simplified Chinese";
            this.rbSimplifiedChinese.UseVisualStyleBackColor = true;
            // 
            // lblDocPath
            // 
            this.lblDocPath.Location = new System.Drawing.Point(47, 371);
            this.lblDocPath.Name = "lblDocPath";
            this.lblDocPath.Size = new System.Drawing.Size(128, 23);
            this.lblDocPath.TabIndex = 10;
            this.lblDocPath.Text = "Default Generation Path";
            this.lblDocPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbDocPath
            // 
            this.tbDocPath.BackColor = System.Drawing.SystemColors.Control;
            this.tbDocPath.Location = new System.Drawing.Point(47, 415);
            this.tbDocPath.Name = "tbDocPath";
            this.tbDocPath.ReadOnly = true;
            this.tbDocPath.Size = new System.Drawing.Size(380, 20);
            this.tbDocPath.TabIndex = 11;
            // 
            // btnBrowseDocPath
            // 
            this.btnBrowseDocPath.BackColor = System.Drawing.Color.Coral;
            this.btnBrowseDocPath.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnBrowseDocPath.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBrowseDocPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBrowseDocPath.Location = new System.Drawing.Point(190, 366);
            this.btnBrowseDocPath.Name = "btnBrowseDocPath";
            this.btnBrowseDocPath.Size = new System.Drawing.Size(72, 34);
            this.btnBrowseDocPath.TabIndex = 12;
            this.btnBrowseDocPath.Text = "Browse";
            this.btnBrowseDocPath.UseVisualStyleBackColor = false;
            this.btnBrowseDocPath.Click += new System.EventHandler(this.btnBrowseDocPath_Click);
            // 
            // btnSelectDocPath
            // 
            this.btnSelectDocPath.BackColor = System.Drawing.Color.Coral;
            this.btnSelectDocPath.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnSelectDocPath.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelectDocPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSelectDocPath.Location = new System.Drawing.Point(293, 366);
            this.btnSelectDocPath.Name = "btnSelectDocPath";
            this.btnSelectDocPath.Size = new System.Drawing.Size(72, 34);
            this.btnSelectDocPath.TabIndex = 13;
            this.btnSelectDocPath.Text = "Select";
            this.btnSelectDocPath.UseVisualStyleBackColor = false;
            this.btnSelectDocPath.Click += new System.EventHandler(this.btnSelectDocPath_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 30);
            this.ClientSize = new System.Drawing.Size(758, 450);
            this.Controls.Add(this.btnSelectDocPath);
            this.Controls.Add(this.btnBrowseDocPath);
            this.Controls.Add(this.tbDocPath);
            this.Controls.Add(this.lblDocPath);
            this.Controls.Add(this.rbSimplifiedChinese);
            this.Controls.Add(this.rbTraditionalChinese);
            this.Controls.Add(this.rbEnglish);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblWorkplace);
            this.Controls.Add(this.lblAppearance);
            this.Controls.Add(this.lblDocument);
            this.Controls.Add(this.lblLanguage);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnSelectDocPath;

        private System.Windows.Forms.Button btnBrowseDocPath;
        private System.Windows.Forms.TextBox tbDocPath;
        private System.Windows.Forms.Label lblDocPath;

        private System.Windows.Forms.RadioButton rbEnglish;
        private System.Windows.Forms.RadioButton rbTraditionalChinese;
        private System.Windows.Forms.RadioButton rbSimplifiedChinese;

        private System.Windows.Forms.Button btnUpdate;

        private System.Windows.Forms.Label lblDocument;
        private System.Windows.Forms.Label lblAppearance;
        private System.Windows.Forms.Label lblWorkplace;

        private System.Windows.Forms.Label lblLanguage;

        #endregion
    }
}
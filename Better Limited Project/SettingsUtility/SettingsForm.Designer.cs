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
            this.rbLightTheme = new System.Windows.Forms.RadioButton();
            this.rbDarkTheme = new System.Windows.Forms.RadioButton();
            this.cbWorkplace = new System.Windows.Forms.ComboBox();
            this.panWorkplace = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWorkplaceSelectRetailStore = new System.Windows.Forms.Label();
            this.lblWorkplaceSelectWarehouse = new System.Windows.Forms.Label();
            this.panWorkplace.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLanguage
            // 
            this.lblLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblLanguage.Location = new System.Drawing.Point(29, 25);
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
            this.lblDocument.Location = new System.Drawing.Point(38, 366);
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
            this.lblWorkplace.Location = new System.Drawing.Point(21, 21);
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
            this.rbEnglish.Location = new System.Drawing.Point(29, 69);
            this.rbEnglish.Name = "rbEnglish";
            this.rbEnglish.Size = new System.Drawing.Size(62, 24);
            this.rbEnglish.TabIndex = 7;
            this.rbEnglish.Text = "English";
            this.rbEnglish.UseVisualStyleBackColor = true;
            // 
            // rbTraditionalChinese
            // 
            this.rbTraditionalChinese.Location = new System.Drawing.Point(29, 99);
            this.rbTraditionalChinese.Name = "rbTraditionalChinese";
            this.rbTraditionalChinese.Size = new System.Drawing.Size(115, 24);
            this.rbTraditionalChinese.TabIndex = 8;
            this.rbTraditionalChinese.Text = "Traditional Chinese";
            this.rbTraditionalChinese.UseVisualStyleBackColor = true;
            // 
            // rbSimplifiedChinese
            // 
            this.rbSimplifiedChinese.Location = new System.Drawing.Point(29, 129);
            this.rbSimplifiedChinese.Name = "rbSimplifiedChinese";
            this.rbSimplifiedChinese.Size = new System.Drawing.Size(115, 24);
            this.rbSimplifiedChinese.TabIndex = 9;
            this.rbSimplifiedChinese.Text = "Simplified Chinese";
            this.rbSimplifiedChinese.UseVisualStyleBackColor = true;
            // 
            // lblDocPath
            // 
            this.lblDocPath.Location = new System.Drawing.Point(47, 410);
            this.lblDocPath.Name = "lblDocPath";
            this.lblDocPath.Size = new System.Drawing.Size(128, 23);
            this.lblDocPath.TabIndex = 10;
            this.lblDocPath.Text = "Default Generation Path";
            this.lblDocPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbDocPath
            // 
            this.tbDocPath.BackColor = System.Drawing.SystemColors.Control;
            this.tbDocPath.Location = new System.Drawing.Point(47, 454);
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
            this.btnBrowseDocPath.Location = new System.Drawing.Point(190, 405);
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
            this.btnSelectDocPath.Location = new System.Drawing.Point(293, 405);
            this.btnSelectDocPath.Name = "btnSelectDocPath";
            this.btnSelectDocPath.Size = new System.Drawing.Size(72, 34);
            this.btnSelectDocPath.TabIndex = 13;
            this.btnSelectDocPath.Text = "Select";
            this.btnSelectDocPath.UseVisualStyleBackColor = false;
            this.btnSelectDocPath.Click += new System.EventHandler(this.btnSelectDocPath_Click);
            // 
            // rbLightTheme
            // 
            this.rbLightTheme.Location = new System.Drawing.Point(47, 554);
            this.rbLightTheme.Name = "rbLightTheme";
            this.rbLightTheme.Size = new System.Drawing.Size(86, 24);
            this.rbLightTheme.TabIndex = 14;
            this.rbLightTheme.Text = "Light Theme";
            this.rbLightTheme.UseVisualStyleBackColor = true;
            // 
            // rbDarkTheme
            // 
            this.rbDarkTheme.Location = new System.Drawing.Point(47, 584);
            this.rbDarkTheme.Name = "rbDarkTheme";
            this.rbDarkTheme.Size = new System.Drawing.Size(86, 24);
            this.rbDarkTheme.TabIndex = 15;
            this.rbDarkTheme.Text = "Dart Theme";
            this.rbDarkTheme.UseVisualStyleBackColor = true;
            // 
            // cbWorkplace
            // 
            this.cbWorkplace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWorkplace.FormattingEnabled = true;
            this.cbWorkplace.Location = new System.Drawing.Point(30, 85);
            this.cbWorkplace.Name = "cbWorkplace";
            this.cbWorkplace.Size = new System.Drawing.Size(241, 21);
            this.cbWorkplace.TabIndex = 16;
            // 
            // panWorkplace
            // 
            this.panWorkplace.Controls.Add(this.lblWorkplaceSelectWarehouse);
            this.panWorkplace.Controls.Add(this.lblWorkplaceSelectRetailStore);
            this.panWorkplace.Controls.Add(this.lblWorkplace);
            this.panWorkplace.Controls.Add(this.cbWorkplace);
            this.panWorkplace.Enabled = false;
            this.panWorkplace.Location = new System.Drawing.Point(38, 205);
            this.panWorkplace.Name = "panWorkplace";
            this.panWorkplace.Size = new System.Drawing.Size(338, 141);
            this.panWorkplace.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblLanguage);
            this.panel1.Controls.Add(this.rbEnglish);
            this.panel1.Controls.Add(this.rbTraditionalChinese);
            this.panel1.Controls.Add(this.rbSimplifiedChinese);
            this.panel1.Location = new System.Drawing.Point(38, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 178);
            this.panel1.TabIndex = 20;
            // 
            // lblWorkplaceSelectRetailStore
            // 
            this.lblWorkplaceSelectRetailStore.Location = new System.Drawing.Point(29, 52);
            this.lblWorkplaceSelectRetailStore.Name = "lblWorkplaceSelectRetailStore";
            this.lblWorkplaceSelectRetailStore.Size = new System.Drawing.Size(150, 23);
            this.lblWorkplaceSelectRetailStore.TabIndex = 21;
            this.lblWorkplaceSelectRetailStore.Text = "Select Current Retail Store";
            this.lblWorkplaceSelectRetailStore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWorkplaceSelectWarehouse
            // 
            this.lblWorkplaceSelectWarehouse.Location = new System.Drawing.Point(30, 52);
            this.lblWorkplaceSelectWarehouse.Name = "lblWorkplaceSelectWarehouse";
            this.lblWorkplaceSelectWarehouse.Size = new System.Drawing.Size(150, 23);
            this.lblWorkplaceSelectWarehouse.TabIndex = 22;
            this.lblWorkplaceSelectWarehouse.Text = "Select Current Warehouse";
            this.lblWorkplaceSelectWarehouse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 30);
            this.ClientSize = new System.Drawing.Size(894, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panWorkplace);
            this.Controls.Add(this.rbDarkTheme);
            this.Controls.Add(this.rbLightTheme);
            this.Controls.Add(this.btnSelectDocPath);
            this.Controls.Add(this.btnBrowseDocPath);
            this.Controls.Add(this.tbDocPath);
            this.Controls.Add(this.lblDocPath);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblAppearance);
            this.Controls.Add(this.lblDocument);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.panWorkplace.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblWorkplaceSelectRetailStore;
        private System.Windows.Forms.Label lblWorkplaceSelectWarehouse;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Panel panWorkplace;

        private System.Windows.Forms.ComboBox cbWorkplace;

        private System.Windows.Forms.RadioButton rbLightTheme;
        private System.Windows.Forms.RadioButton rbDarkTheme;

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
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
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
            this.lblWorkplaceSelectWarehouse = new System.Windows.Forms.Label();
            this.lblWorkplaceSelectRetailStore = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panWorkplace.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLanguage
            // 
            resources.ApplyResources(this.lblLanguage, "lblLanguage");
            this.lblLanguage.Name = "lblLanguage";
            // 
            // lblDocument
            // 
            resources.ApplyResources(this.lblDocument, "lblDocument");
            this.lblDocument.Name = "lblDocument";
            // 
            // lblAppearance
            // 
            resources.ApplyResources(this.lblAppearance, "lblAppearance");
            this.lblAppearance.Name = "lblAppearance";
            // 
            // lblWorkplace
            // 
            resources.ApplyResources(this.lblWorkplace, "lblWorkplace");
            this.lblWorkplace.Name = "lblWorkplace";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Coral;
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // rbEnglish
            // 
            resources.ApplyResources(this.rbEnglish, "rbEnglish");
            this.rbEnglish.Name = "rbEnglish";
            this.rbEnglish.UseVisualStyleBackColor = true;
            // 
            // rbTraditionalChinese
            // 
            resources.ApplyResources(this.rbTraditionalChinese, "rbTraditionalChinese");
            this.rbTraditionalChinese.Name = "rbTraditionalChinese";
            this.rbTraditionalChinese.UseVisualStyleBackColor = true;
            // 
            // rbSimplifiedChinese
            // 
            resources.ApplyResources(this.rbSimplifiedChinese, "rbSimplifiedChinese");
            this.rbSimplifiedChinese.Name = "rbSimplifiedChinese";
            this.rbSimplifiedChinese.UseVisualStyleBackColor = true;
            // 
            // lblDocPath
            // 
            resources.ApplyResources(this.lblDocPath, "lblDocPath");
            this.lblDocPath.Name = "lblDocPath";
            // 
            // tbDocPath
            // 
            this.tbDocPath.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.tbDocPath, "tbDocPath");
            this.tbDocPath.Name = "tbDocPath";
            this.tbDocPath.ReadOnly = true;
            // 
            // btnBrowseDocPath
            // 
            this.btnBrowseDocPath.BackColor = System.Drawing.Color.Coral;
            resources.ApplyResources(this.btnBrowseDocPath, "btnBrowseDocPath");
            this.btnBrowseDocPath.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBrowseDocPath.Name = "btnBrowseDocPath";
            this.btnBrowseDocPath.UseVisualStyleBackColor = false;
            this.btnBrowseDocPath.Click += new System.EventHandler(this.btnBrowseDocPath_Click);
            // 
            // btnSelectDocPath
            // 
            this.btnSelectDocPath.BackColor = System.Drawing.Color.Coral;
            resources.ApplyResources(this.btnSelectDocPath, "btnSelectDocPath");
            this.btnSelectDocPath.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelectDocPath.Name = "btnSelectDocPath";
            this.btnSelectDocPath.UseVisualStyleBackColor = false;
            this.btnSelectDocPath.Click += new System.EventHandler(this.btnSelectDocPath_Click);
            // 
            // rbLightTheme
            // 
            resources.ApplyResources(this.rbLightTheme, "rbLightTheme");
            this.rbLightTheme.Name = "rbLightTheme";
            this.rbLightTheme.UseVisualStyleBackColor = true;
            // 
            // rbDarkTheme
            // 
            resources.ApplyResources(this.rbDarkTheme, "rbDarkTheme");
            this.rbDarkTheme.Name = "rbDarkTheme";
            this.rbDarkTheme.UseVisualStyleBackColor = true;
            // 
            // cbWorkplace
            // 
            this.cbWorkplace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWorkplace.FormattingEnabled = true;
            resources.ApplyResources(this.cbWorkplace, "cbWorkplace");
            this.cbWorkplace.Name = "cbWorkplace";
            // 
            // panWorkplace
            // 
            this.panWorkplace.Controls.Add(this.lblWorkplaceSelectWarehouse);
            this.panWorkplace.Controls.Add(this.lblWorkplaceSelectRetailStore);
            this.panWorkplace.Controls.Add(this.lblWorkplace);
            this.panWorkplace.Controls.Add(this.cbWorkplace);
            resources.ApplyResources(this.panWorkplace, "panWorkplace");
            this.panWorkplace.Name = "panWorkplace";
            // 
            // lblWorkplaceSelectWarehouse
            // 
            resources.ApplyResources(this.lblWorkplaceSelectWarehouse, "lblWorkplaceSelectWarehouse");
            this.lblWorkplaceSelectWarehouse.Name = "lblWorkplaceSelectWarehouse";
            // 
            // lblWorkplaceSelectRetailStore
            // 
            resources.ApplyResources(this.lblWorkplaceSelectRetailStore, "lblWorkplaceSelectRetailStore");
            this.lblWorkplaceSelectRetailStore.Name = "lblWorkplaceSelectRetailStore";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblLanguage);
            this.panel1.Controls.Add(this.rbEnglish);
            this.panel1.Controls.Add(this.rbTraditionalChinese);
            this.panel1.Controls.Add(this.rbSimplifiedChinese);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // SettingsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
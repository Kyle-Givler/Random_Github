
namespace RandomGithubWinFormsUI
{
    partial class frmRandomGitHub
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblOwner = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOwnerUrl = new System.Windows.Forms.Label();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblOwnerGHValue = new System.Windows.Forms.Label();
            this.lblOwnerValue = new System.Windows.Forms.Label();
            this.lblIdValue = new System.Windows.Forms.Label();
            this.lblNameValue = new System.Windows.Forms.Label();
            this.lblDescValue = new System.Windows.Forms.Label();
            this.lblUrlValue = new System.Windows.Forms.Label();
            this.lblLanguageValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(182, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Random Github Finder";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblId.Location = new System.Drawing.Point(12, 47);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(30, 21);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "ID:";
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOwner.Location = new System.Drawing.Point(12, 68);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(63, 21);
            this.lblOwner.TabIndex = 2;
            this.lblOwner.Text = "Owner:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // lblOwnerUrl
            // 
            this.lblOwnerUrl.AutoSize = true;
            this.lblOwnerUrl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOwnerUrl.Location = new System.Drawing.Point(12, 89);
            this.lblOwnerUrl.Name = "lblOwnerUrl";
            this.lblOwnerUrl.Size = new System.Drawing.Size(128, 21);
            this.lblOwnerUrl.TabIndex = 3;
            this.lblOwnerUrl.Text = "Owner\'s GitHub:";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUrl.Location = new System.Drawing.Point(12, 152);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(43, 21);
            this.lblUrl.TabIndex = 6;
            this.lblUrl.Text = "URL:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.Location = new System.Drawing.Point(12, 131);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(98, 21);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description:";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLanguage.Location = new System.Drawing.Point(12, 173);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(85, 21);
            this.lblLanguage.TabIndex = 7;
            this.lblLanguage.Text = "Language:";
            // 
            // lblOwnerGHValue
            // 
            this.lblOwnerGHValue.AutoSize = true;
            this.lblOwnerGHValue.Location = new System.Drawing.Point(146, 89);
            this.lblOwnerGHValue.Name = "lblOwnerGHValue";
            this.lblOwnerGHValue.Size = new System.Drawing.Size(89, 21);
            this.lblOwnerGHValue.TabIndex = 8;
            this.lblOwnerGHValue.Text = "{OwnerGH}";
            // 
            // lblOwnerValue
            // 
            this.lblOwnerValue.AutoSize = true;
            this.lblOwnerValue.Location = new System.Drawing.Point(146, 68);
            this.lblOwnerValue.Name = "lblOwnerValue";
            this.lblOwnerValue.Size = new System.Drawing.Size(67, 21);
            this.lblOwnerValue.TabIndex = 9;
            this.lblOwnerValue.Text = "{Owner}";
            // 
            // lblIdValue
            // 
            this.lblIdValue.AutoSize = true;
            this.lblIdValue.Location = new System.Drawing.Point(146, 47);
            this.lblIdValue.Name = "lblIdValue";
            this.lblIdValue.Size = new System.Drawing.Size(33, 21);
            this.lblIdValue.TabIndex = 10;
            this.lblIdValue.Text = "{id}";
            // 
            // lblNameValue
            // 
            this.lblNameValue.AutoSize = true;
            this.lblNameValue.Location = new System.Drawing.Point(146, 110);
            this.lblNameValue.Name = "lblNameValue";
            this.lblNameValue.Size = new System.Drawing.Size(62, 21);
            this.lblNameValue.TabIndex = 13;
            this.lblNameValue.Text = "{Name}";
            // 
            // lblDescValue
            // 
            this.lblDescValue.AutoSize = true;
            this.lblDescValue.Location = new System.Drawing.Point(146, 131);
            this.lblDescValue.Name = "lblDescValue";
            this.lblDescValue.Size = new System.Drawing.Size(53, 21);
            this.lblDescValue.TabIndex = 12;
            this.lblDescValue.Text = "{Desc}";
            // 
            // lblUrlValue
            // 
            this.lblUrlValue.AutoSize = true;
            this.lblUrlValue.Location = new System.Drawing.Point(146, 152);
            this.lblUrlValue.Name = "lblUrlValue";
            this.lblUrlValue.Size = new System.Drawing.Size(41, 21);
            this.lblUrlValue.TabIndex = 11;
            this.lblUrlValue.Text = "{Url}";
            // 
            // lblLanguageValue
            // 
            this.lblLanguageValue.AutoSize = true;
            this.lblLanguageValue.Location = new System.Drawing.Point(146, 173);
            this.lblLanguageValue.Name = "lblLanguageValue";
            this.lblLanguageValue.Size = new System.Drawing.Size(88, 21);
            this.lblLanguageValue.TabIndex = 14;
            this.lblLanguageValue.Text = "{Language}";
            // 
            // frmRandomGitHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLanguageValue);
            this.Controls.Add(this.lblNameValue);
            this.Controls.Add(this.lblDescValue);
            this.Controls.Add(this.lblUrlValue);
            this.Controls.Add(this.lblIdValue);
            this.Controls.Add(this.lblOwnerValue);
            this.Controls.Add(this.lblOwnerGHValue);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOwnerUrl);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Name = "frmRandomGitHub";
            this.Text = "Random GitHub";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOwnerUrl;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblOwnerGHValue;
        private System.Windows.Forms.Label lblOwnerValue;
        private System.Windows.Forms.Label lblIdValue;
        private System.Windows.Forms.Label lblNameValue;
        private System.Windows.Forms.Label lblDescValue;
        private System.Windows.Forms.Label lblUrlValue;
        private System.Windows.Forms.Label lblLanguageValue;
    }
}
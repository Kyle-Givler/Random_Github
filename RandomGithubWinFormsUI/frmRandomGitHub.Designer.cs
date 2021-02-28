
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
            this.lblOwnerValue = new System.Windows.Forms.Label();
            this.lblIdValue = new System.Windows.Forms.Label();
            this.lblNameValue = new System.Windows.Forms.Label();
            this.lblLanguageValue = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblRemainingValue = new System.Windows.Forms.Label();
            this.lblRemainingCalls = new System.Windows.Forms.Label();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.linkLabelGitHub = new System.Windows.Forms.LinkLabel();
            this.linkLabelOwner = new System.Windows.Forms.LinkLabel();
            this.linkLabelUrl = new System.Windows.Forms.LinkLabel();
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
            this.lblUrl.Location = new System.Drawing.Point(12, 293);
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
            this.lblLanguage.Location = new System.Drawing.Point(12, 314);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(85, 21);
            this.lblLanguage.TabIndex = 7;
            this.lblLanguage.Text = "Language:";
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
            // lblLanguageValue
            // 
            this.lblLanguageValue.AutoSize = true;
            this.lblLanguageValue.Location = new System.Drawing.Point(91, 314);
            this.lblLanguageValue.Name = "lblLanguageValue";
            this.lblLanguageValue.Size = new System.Drawing.Size(88, 21);
            this.lblLanguageValue.TabIndex = 14;
            this.lblLanguageValue.Text = "{Language}";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(182, 369);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(171, 58);
            this.btnFind.TabIndex = 15;
            this.btnFind.Text = "Find Random GitHub";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lblRemainingValue
            // 
            this.lblRemainingValue.AutoSize = true;
            this.lblRemainingValue.Location = new System.Drawing.Point(122, 335);
            this.lblRemainingValue.Name = "lblRemainingValue";
            this.lblRemainingValue.Size = new System.Drawing.Size(91, 21);
            this.lblRemainingValue.TabIndex = 17;
            this.lblRemainingValue.Text = "{remaining}";
            // 
            // lblRemainingCalls
            // 
            this.lblRemainingCalls.AutoSize = true;
            this.lblRemainingCalls.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRemainingCalls.Location = new System.Drawing.Point(12, 335);
            this.lblRemainingCalls.Name = "lblRemainingCalls";
            this.lblRemainingCalls.Size = new System.Drawing.Size(115, 21);
            this.lblRemainingCalls.TabIndex = 16;
            this.lblRemainingCalls.Text = "Remaing Calls:";
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(13, 156);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(510, 134);
            this.textBoxDesc.TabIndex = 18;
            // 
            // linkLabelGitHub
            // 
            this.linkLabelGitHub.AutoSize = true;
            this.linkLabelGitHub.Location = new System.Drawing.Point(150, 430);
            this.linkLabelGitHub.Name = "linkLabelGitHub";
            this.linkLabelGitHub.Size = new System.Drawing.Size(234, 21);
            this.linkLabelGitHub.TabIndex = 36;
            this.linkLabelGitHub.TabStop = true;
            this.linkLabelGitHub.Text = "https://github.com/JoyfulReaper";
            this.linkLabelGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGitHub_LinkClicked);
            // 
            // linkLabelOwner
            // 
            this.linkLabelOwner.AutoSize = true;
            this.linkLabelOwner.Location = new System.Drawing.Point(146, 89);
            this.linkLabelOwner.Name = "linkLabelOwner";
            this.linkLabelOwner.Size = new System.Drawing.Size(67, 21);
            this.linkLabelOwner.TabIndex = 37;
            this.linkLabelOwner.TabStop = true;
            this.linkLabelOwner.Text = "{Owner}";
            this.linkLabelOwner.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelOwner_LinkClicked);
            // 
            // linkLabelUrl
            // 
            this.linkLabelUrl.AutoSize = true;
            this.linkLabelUrl.Location = new System.Drawing.Point(59, 293);
            this.linkLabelUrl.Name = "linkLabelUrl";
            this.linkLabelUrl.Size = new System.Drawing.Size(41, 21);
            this.linkLabelUrl.TabIndex = 38;
            this.linkLabelUrl.TabStop = true;
            this.linkLabelUrl.Text = "{Url}";
            this.linkLabelUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelUrl_LinkClicked);
            // 
            // frmRandomGitHub
            // 
            this.AcceptButton = this.btnFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(535, 471);
            this.Controls.Add(this.linkLabelUrl);
            this.Controls.Add(this.linkLabelOwner);
            this.Controls.Add(this.linkLabelGitHub);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.lblRemainingValue);
            this.Controls.Add(this.lblRemainingCalls);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lblLanguageValue);
            this.Controls.Add(this.lblNameValue);
            this.Controls.Add(this.lblIdValue);
            this.Controls.Add(this.lblOwnerValue);
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
        private System.Windows.Forms.Label lblOwnerValue;
        private System.Windows.Forms.Label lblIdValue;
        private System.Windows.Forms.Label lblNameValue;
        private System.Windows.Forms.Label lblLanguageValue;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblRemainingValue;
        private System.Windows.Forms.Label lblRemainingCalls;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.LinkLabel linkLabelGitHub;
        private System.Windows.Forms.LinkLabel linkLabelOwner;
        private System.Windows.Forms.LinkLabel linkLabelUrl;
    }
}
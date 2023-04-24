
namespace ContactsApp.View
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.ContactsAppLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.CopywritingLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.GitHubLabel = new System.Windows.Forms.Label();
            this.EmaillinkLabel = new System.Windows.Forms.LinkLabel();
            this.GitHubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // ContactsAppLabel
            // 
            this.ContactsAppLabel.AutoSize = true;
            this.ContactsAppLabel.Location = new System.Drawing.Point(12, 9);
            this.ContactsAppLabel.Name = "ContactsAppLabel";
            this.ContactsAppLabel.Size = new System.Drawing.Size(68, 13);
            this.ContactsAppLabel.TabIndex = 0;
            this.ContactsAppLabel.Text = "ContactsApp";
            this.ContactsAppLabel.Click += new System.EventHandler(this.ContactsAppLabel_Click);
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(12, 41);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(52, 13);
            this.VersionLabel.TabIndex = 1;
            this.VersionLabel.Text = "v. 1.2.2.3";
            this.VersionLabel.Click += new System.EventHandler(this.VersionLabel_Click);
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(12, 70);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(123, 13);
            this.AuthorLabel.TabIndex = 2;
            this.AuthorLabel.Text = "Author: Nikolay Fedyaev";
            // 
            // CopywritingLabel
            // 
            this.CopywritingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CopywritingLabel.AutoSize = true;
            this.CopywritingLabel.Location = new System.Drawing.Point(12, 266);
            this.CopywritingLabel.Name = "CopywritingLabel";
            this.CopywritingLabel.Size = new System.Drawing.Size(113, 13);
            this.CopywritingLabel.TabIndex = 3;
            this.CopywritingLabel.Text = "2022 Fedyaev Nikolay";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(12, 113);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(98, 13);
            this.EmailLabel.TabIndex = 4;
            this.EmailLabel.Text = "E-mail for feerback:";
            // 
            // GitHubLabel
            // 
            this.GitHubLabel.AutoSize = true;
            this.GitHubLabel.Location = new System.Drawing.Point(12, 135);
            this.GitHubLabel.Name = "GitHubLabel";
            this.GitHubLabel.Size = new System.Drawing.Size(46, 13);
            this.GitHubLabel.TabIndex = 5;
            this.GitHubLabel.Text = "GitHub: ";
            // 
            // EmaillinkLabel
            // 
            this.EmaillinkLabel.AutoSize = true;
            this.EmaillinkLabel.Location = new System.Drawing.Point(116, 113);
            this.EmaillinkLabel.Name = "EmaillinkLabel";
            this.EmaillinkLabel.Size = new System.Drawing.Size(113, 13);
            this.EmaillinkLabel.TabIndex = 6;
            this.EmaillinkLabel.TabStop = true;
            this.EmaillinkLabel.Text = "fedyaev-2001@mail.ru";
            this.EmaillinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EmaillinkLabel_LinkClicked);
            // 
            // GitHubLinkLabel
            // 
            this.GitHubLinkLabel.AutoSize = true;
            this.GitHubLinkLabel.Location = new System.Drawing.Point(64, 135);
            this.GitHubLinkLabel.Name = "GitHubLinkLabel";
            this.GitHubLinkLabel.Size = new System.Drawing.Size(149, 13);
            this.GitHubLinkLabel.TabIndex = 7;
            this.GitHubLinkLabel.TabStop = true;
            this.GitHubLinkLabel.Text = "NikolayFedyaev/ContactsApp";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 288);
            this.Controls.Add(this.GitHubLinkLabel);
            this.Controls.Add(this.EmaillinkLabel);
            this.Controls.Add(this.GitHubLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.CopywritingLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.ContactsAppLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutForm";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ContactsAppLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label CopywritingLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label GitHubLabel;
        private System.Windows.Forms.LinkLabel EmaillinkLabel;
        private System.Windows.Forms.LinkLabel GitHubLinkLabel;
    }
}
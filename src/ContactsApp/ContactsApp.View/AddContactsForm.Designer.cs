
namespace ContactsApp.View
{
    partial class AddContactsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddContactsForm));
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.BurthdayLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.VcTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelButton.Location = new System.Drawing.Point(96, 211);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OKButton.Location = new System.Drawing.Point(15, 211);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(6, 35);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(52, 13);
            this.SurnameLabel.TabIndex = 2;
            this.SurnameLabel.Text = "Surname:";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(17, 113);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(41, 13);
            this.PhoneLabel.TabIndex = 3;
            this.PhoneLabel.Text = "Phone:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(20, 61);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Name:";
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(71, 58);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(369, 20);
            this.NameTextBox.TabIndex = 5;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneTextBox.Location = new System.Drawing.Point(71, 110);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(369, 20);
            this.PhoneTextBox.TabIndex = 6;
            this.PhoneTextBox.TextChanged += new System.EventHandler(this.PhoneTextBox_TextChanged);
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SurnameTextBox.Location = new System.Drawing.Point(71, 32);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(369, 20);
            this.SurnameTextBox.TabIndex = 7;
            this.SurnameTextBox.TextChanged += new System.EventHandler(this.SurnameTextBox_TextChanged);
            // 
            // BurthdayLabel
            // 
            this.BurthdayLabel.AutoSize = true;
            this.BurthdayLabel.Location = new System.Drawing.Point(12, 88);
            this.BurthdayLabel.Name = "BurthdayLabel";
            this.BurthdayLabel.Size = new System.Drawing.Size(52, 13);
            this.BurthdayLabel.TabIndex = 8;
            this.BurthdayLabel.Text = "Burthday:";
            this.BurthdayLabel.Click += new System.EventHandler(this.BurthdayLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Vc.com:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(20, 139);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(38, 13);
            this.EmailLabel.TabIndex = 10;
            this.EmailLabel.Text = "E-mail:";
            this.EmailLabel.Click += new System.EventHandler(this.Email_Click);
            // 
            // VcTextBox
            // 
            this.VcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VcTextBox.Location = new System.Drawing.Point(71, 162);
            this.VcTextBox.Name = "VcTextBox";
            this.VcTextBox.Size = new System.Drawing.Size(369, 20);
            this.VcTextBox.TabIndex = 11;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.Location = new System.Drawing.Point(71, 136);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(369, 20);
            this.EmailTextBox.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(71, 88);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(369, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // AddContactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 246);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.VcTextBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BurthdayLabel);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CancelButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddContactsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Contacts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label BurthdayLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox VcTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
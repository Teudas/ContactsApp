using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp.Model;

namespace ContactsApp.View
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void ContactsAppLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/NikolayFedyaev");
        }

        private void EmaillinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://mail.ru");
        }

        private void VersionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

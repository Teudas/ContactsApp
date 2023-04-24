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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AddContacts_Click(object sender, EventArgs e)
        {
            AddContactsForm addc = new AddContactsForm();
            addc.ShowDialog();
        }

        private void DeleteContacts_Click(object sender, EventArgs e)
        {
 
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            AddContactsForm addc = new AddContactsForm();
            addc.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addContactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddContactsForm addc = new AddContactsForm();
            addc.ShowDialog();
    
        }

        private void editContactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddContactsForm addc = new AddContactsForm();
            addc.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutf = new AboutForm();
            aboutf.ShowDialog();
        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

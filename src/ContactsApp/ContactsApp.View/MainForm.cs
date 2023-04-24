using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            addc.Show();
            Hide();
        }

        private void DeleteContacts_Click(object sender, EventArgs e)
        {
 
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            AddContactsForm addc = new AddContactsForm();
            addc.Show();
            Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addContactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddContactsForm addc = new AddContactsForm();
            addc.Show();
            Hide();
        }

        private void editContactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddContactsForm addc = new AddContactsForm();
            addc.Show();
            Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutf = new AboutForm();
            aboutf.Show();
        }
    }
}

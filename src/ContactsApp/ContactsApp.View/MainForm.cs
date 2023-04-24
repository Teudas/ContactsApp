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
        /// <summary>
        /// Создания листа с контактами
        /// </summary>
        private Project _project = new Project();

        /// <summary>
        /// Текущие объекты в списке
        /// </summary>
        private List<Contact> _currentContacts;

        public MainForm()
        {
            _project = new Project();
            _project = ProjectManager.LoadFromFile();
            InitializeComponent();
            _currentContacts = new List<Contact>(_project.SortBySurname());
            UpdateListBox();
        }

        /// <summary>
        /// Обновление ListBox.
        /// </summary>
        private void UpdateListBox()
        {
            ContactsListBox.Items.Clear();
            _currentContacts = _currentContacts.OrderBy(contact => contact.Surname).ToList();
            foreach (Contact contact in _currentContacts)
            {
                ContactsListBox.Items.Add(contact.Surname);
            }
        }

        /// <summary>
        /// Обновление информации текущего контакта.
        /// </summary>
        /// <param name="index">Индекс контакта в ListBox.</param>
        private void UpdateSelectedContact(int index)
        {
            if (index == -1)
            {
                ClearSelectedContact();
                return;
            }
            Contact contact = _currentContacts[index];
            SurnameTextBox.Text = contact.Surname;
            NameTextBox.Text = contact.Name;
            PhoneTextBox.Text = contact.Number.Number.ToString();
            EmailTextBox.Text = contact.Email;
            VkTextBox.Text = contact.VkId;
            BirthdaydateTimePicker.Value = contact.Birthday;
        }

        /// <summary>
        /// Удаление контакта из ListBox.
        /// </summary>
        /// <param name="index">Индекс контакта в ListBox.</param>
        /// <summary>
        /// Удаление контакта из ListBox.
        /// </summary>
        /// <param name="index">Индекс контакта в ListBox.</param>
        private void RemoveContact(int index)
        {
            if (index == -1)
            {
                return;
            }
            DialogResult result = MessageBox.Show
                ("Do you really want to remove this contact?",
                "Confirm?",
                MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                int contactIndex = _project.Contacts.FindIndex(contact =>
                contact.Surname == _currentContacts[index].Surname && contact.Number.Number == _currentContacts[index].Number.Number);
                _currentContacts.RemoveAt(index);
                _project.Contacts.RemoveAt(contactIndex);
                UpdateListBox();
                ProjectManager.SaveToFile(_project);
            }
        }

        /// <summary>
        /// Удаление информации контакта.
        /// </summary>
        private void ClearSelectedContact()
        {
            SurnameTextBox.Text = string.Empty;
            NameTextBox.Text = string.Empty;
            PhoneTextBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;
            VkTextBox.Text = string.Empty;
            BirthdaydateTimePicker.Value = BirthdaydateTimePicker.MinDate;
        }

        /// <summary>
        /// Изменение показываемого контакта при изменении индекса.
        /// </summary>
        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectedContact(ContactsListBox.SelectedIndex);
        }

        /// <summary>
        /// Действия при закрытии формы.
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show
                ("Do you really want to exit?",
                "Confirmation",
                MessageBoxButtons.OKCancel);
            if (result != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }


        /// <summary>
        /// Добавление контакта.
        /// </summary>
        public void AddContact()
        {
            ContactForm contactForm = new ContactForm();
            DialogResult result = contactForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                Contact newContact = contactForm.Contact;
                _currentContacts.Add(newContact);
                _project.Contacts.Add(contactForm._contact);
                ProjectManager.SaveToFile(_project);
            }
        }


        /// <summary>
        /// Редактирование контакта.
        /// </summary>
        /// <param name="index">Индекс контакта.</param>
        private void EditContact(int index)
        {
            if (index == -1)
            {
                MessageBox.Show("Choose contact");
                return;
            }
            Contact editContact = _currentContacts[index];
            ContactForm contactForm = new ContactForm();

            contactForm.UpdateForm();
            contactForm.ShowDialog();
            if (contactForm.DialogResult == DialogResult.OK)
            {
                editContact.Surname = contactForm.Contact.Surname;
                editContact.Name = contactForm.Contact.Name;
                editContact.Birthday = contactForm.Contact.Birthday;
                editContact.Number = contactForm.Contact.Number;
                editContact.Email = contactForm.Contact.Email;
                editContact.VkId = contactForm.Contact.VkId;
                UpdateListBox();
                UpdateSelectedContact(index);
                ContactsListBox.SelectedIndex = index;
                ProjectManager.SaveToFile(_project);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectedContact(ContactsListBox.SelectedIndex);
        }


        /// <summary>
        /// Срабатывание кнопки добавления контакта в ListBox.
        /// </summary>
        private void AddContacts_Click(object sender, EventArgs e)
        {
            AddContact();
            UpdateListBox();
        }

        /// <summary>
        /// Удаление контакта.
        /// </summary>
        private void DeleteContacts_Click(object sender, EventArgs e)
        {
            RemoveContact(ContactsListBox.SelectedIndex);
        }


        /// <summary>
        /// Открытие окна редактирования контакта.
        /// </summary>
        private void EditButton_Click(object sender, EventArgs e)
        {
            EditContact(ContactsListBox.SelectedIndex);
            UpdateListBox();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        /// <summary>
        /// Добавление контакта через Strip menu.
        /// </summary>
        private void addContactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddContact();
            UpdateListBox();
        }

        // <summary>
        /// Изменение контакта через Strip menu.
        /// </summary>
        private void editContactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditContact(ContactsListBox.SelectedIndex);
            UpdateListBox();
        }

        /// <summary>
        /// Выход через Strip menu.
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show
                ("Do you really want to exit?",
                "Confirmation",
                MessageBoxButtons.OKCancel);
            if (result != DialogResult.Cancel)
            {
                Close();
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Открытие окна About.
        /// </summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm newForm = new AboutForm();
            newForm.Show();
        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {


        }

        /// <summary>
        /// Удаление контакта через Strip menu.
        /// </summary>
        private void removeContactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveContact(ContactsListBox.SelectedIndex);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Поиск по фамилии.
        /// </summary>
        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            string text = FindTextBox.Text;
            _currentContacts = _project.SearchBySurname(text);
            UpdateListBox();
        }
    }
}

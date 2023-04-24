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
        private Project _project = new Project();

        public MainForm()
        {
            _project = new Project();
            InitializeComponent();
            ContactsListBox.Items.Clear(); 
        }

        /// <summary>
        /// Обновление ListBox.
        /// </summary>
        private void UpdateListBox()
        {
            ContactsListBox.Items.Clear();
            foreach (Contact contact in _project.Contacts)
            {
                ContactsListBox.Items.Add(contact.Surname);
            }
        }

        /// <summary>
        /// Добавление контакта в ListBox.
        /// </summary>
        private void AddContact()
        {
            var randomNames = new List<string>
            {
                "Евгений","Вячеслав","Сизый","Петька"
                ,"Никитка","Алешка", "Виталий"
            };
            var randomSurnames = new List<string>
            {
                "Чураков","Хохломов","Сидоров",
                "Майков","Федяев", "Мусэрский"
            };
            //var randomPhoneNumbers = new List<string>
            //{
            //"78005553535","79531239746","79135578913"
            //};
            var randomEmails = new List<string>
            {
                "evgexacraft@mail.ru",
                "petrketr@gmail.com",
                "berillii@inbox.ru",
                "ker124@mail.ru",
                "holymail@gmail.com",
                "maxxx123@mail.ru",
                "ded@inbox.ru"
            };
            var randomVkId = new List<string>
            {
                "id845625","kein","berilliin1","heeeeyyy"
            };
            Random random = new Random();
            Contact contact = new
                Contact(randomNames[random.Next(randomNames.Count)],
                randomSurnames[random.Next(randomSurnames.Count)],
                new PhoneNumber(79534599771),
                //randomPhoneNumbers[random.Next(randomPhoneNumbers.Count)],
                new DateTime(2001, 05, 25),
                randomEmails[random.Next(randomEmails.Count)],
                randomVkId[random.Next(randomVkId.Count)]);

            _project.Contacts.Add(contact);
        }

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
                _project.Contacts.RemoveAt(index);
                ContactsListBox.SelectedItem = -1;
                ClearSelectedContact();
                UpdateListBox();
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
            VcTextBox.Text = string.Empty;
            BirthdaydateTimePicker.Value = BirthdaydateTimePicker.MinDate;
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
            var tempContact = _project.Contacts[index];
            SurnameTextBox.Text = tempContact.Surname;
            NameTextBox.Text = tempContact.Name;
            PhoneTextBox.Text = "79138853212";
            EmailTextBox.Text = tempContact.Email;
            VcTextBox.Text = tempContact.VkId;
            BirthdaydateTimePicker.Value = tempContact.Birthday;
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
            ContactForm newForm = new ContactForm();
            newForm.Show();
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
            ContactForm newForm = new ContactForm();
            newForm.Show();
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
    }
}

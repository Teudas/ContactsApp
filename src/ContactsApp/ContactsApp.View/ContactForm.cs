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
    public partial class ContactForm : Form
    {
        private Contact _contact = new Contact("Nikolay", "Fedyaev", new PhoneNumber(79618862557),
                new DateTime(2001, 05, 25), "fedyaev-2001@mail.ru", "vkid");

        /// <summary>
        /// Тексты ошибок.
        /// </summary>
        private string _surnameError;
        private string _nameError;
        private string _phoneNumberError;
        private string _birthdayError;
        private string _emailError;
        private string _vkIdError;

        /// <summary>
        /// Проверка корректности ввода всех полей.
        /// </summary>
        /// <returns></returns>
        private bool CheckFormOnErrors()
        {
            if (_surnameError != string.Empty)
            {
                MessageBox.Show(_surnameError);
                return false;
            }

            if (_nameError != string.Empty)
            {
                MessageBox.Show(_nameError);
                return false;
            }

            if (_phoneNumberError != string.Empty)
            {
                MessageBox.Show(_phoneNumberError);
                return false;
            }

            if (_birthdayError != string.Empty)
            {
                MessageBox.Show(_birthdayError);
                return false;
            }

            if (_emailError != string.Empty)
            {
                MessageBox.Show(_emailError);
                return false;
            }

            if (_vkIdError != string.Empty)
            {
                MessageBox.Show(_vkIdError);
                return false;
            }
            if (_surnameError == string.Empty)
            {
                return true;
            }

            return true;
        }


        /// <summary>
        /// Обновление данных формы.
        /// </summary>
        private void UpdateForm()
        {
            SurnameTextBox.Text = _contact.Surname;
            NameTextBox.Text = _contact.Name;
            BirthdayTimePicker.Value = _contact.Birthday;
            PhoneTextBox.Text = "78005553537";
            EmailTextBox.Text = _contact.Email;
            VkTextBox.Text = _contact.VkId;
        }


        public ContactForm()
        {
            InitializeComponent();
            UpdateForm();
        }

        
       

        /// <summary>
        /// Занесение имени в контакт в случае изменения.
        /// </summary>
        private void Surname_Click(object sender, EventArgs e)
        {

        }

        private void NumberPhone_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Phone_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Занесение фамилии в контакт в случае изменения.
        /// </summary>
        private void SurnameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Surname = SurnameTextBox.Text;
                SurnameTextBox.BackColor = Color.White;
                _surnameError = string.Empty;
            }
            catch (ArgumentException exception)
            {
                SurnameTextBox.BackColor = Color.LightPink;
                _surnameError = exception.Message;
            }
        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void BurthdayLabel_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Занесение номера телефона в контакт в случае изменения.
        /// </summary>
        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Number.Number = Convert.ToInt64(PhoneTextBox.Text);
                PhoneTextBox.BackColor = Color.White;
                _phoneNumberError = string.Empty;
            }
            catch (System.FormatException exception)
            {
                PhoneTextBox.BackColor = Color.LightPink;
                _phoneNumberError = "Некорректный номер. Он должен начинаться с 7 и быть 11 символов";
            }
            catch (ArgumentException exception)
            {
                PhoneTextBox.BackColor = Color.LightPink;
                _phoneNumberError = exception.Message;
            }
        }

        /// <summary>
        /// Действия окна при нажатии на ОК.
        /// </summary>
        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (CheckFormOnErrors() == true)
            {
                Close();
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки Cancel.
        /// </summary>
        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            if (CheckFormOnErrors() == true)
            {
                Close();
            }
        }

        /// <summary>
        /// Занесение айди вк в контакт в случае изменения.
        /// </summary>
        private void VkTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.VkId = VkTextBox.Text;
                VkTextBox.BackColor = Color.White;
                _vkIdError = string.Empty;
            }
            catch (ArgumentException exception)
            {
                VkTextBox.BackColor = Color.LightPink;
                _vkIdError = exception.Message;
            }
        }

        /// <summary>
        /// Занесение имени в контакт в случае изменения.
        /// </summary>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Name = NameTextBox.Text;
                NameTextBox.BackColor = Color.White;
                _nameError = string.Empty;
            }
            catch (ArgumentException exception)
            {
                NameTextBox.BackColor = Color.LightPink;
                _nameError = exception.Message;
            }
        }

        /// <summary>
        /// Занесение даты рождения в контакт в случае изменения.
        /// </summary>
        private void BirthdayTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Birthday = BirthdayTimePicker.Value;
                BirthdayTimePicker.BackColor = Color.White;
                _birthdayError = string.Empty;
            }
            catch (ArgumentException exception)
            {
                BirthdayTimePicker.BackColor = Color.LightPink;
                _birthdayError = exception.Message;
            }
        }

        /// <summary>
        /// Занесение мэйла в контакт в случае изменения.
        /// </summary>
        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Email = EmailTextBox.Text;
                EmailTextBox.BackColor = Color.White;
                _emailError = string.Empty;
            }
            catch (ArgumentException exception)
            {
                EmailTextBox.BackColor = Color.LightPink;
                _emailError = exception.Message;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    /// <summary>
    /// Номер телефона контакта
    /// </summary>
    public class PhoneNumber
    {
        /// <summary>
        /// Максимальная длина номера телефона
        /// </summary>
        private const int _MAX_LENGTH = 11;

        /// <summary>
        /// Номер телефона
        /// </summary>
        private long _number;

        public long Number
        {
            get
            {
                return this._number;
            }
            set
            {
                if (value.ToString().Length > _MAX_LENGTH || !value.ToString().StartsWith("7"))
                {
                    throw new ArgumentException("Длина номера должна быть меньше 11 символов и начинаться с 7");
                }
                this._number = value;
            }
        }
        /// <summary>
        /// Создание экземпляра телефонного номера.
        /// </summary>
        /// <param name="number">Номер телефона контакта.</param>
        public PhoneNumber(long number)
        {
            this._number = number;
        }
    }
}

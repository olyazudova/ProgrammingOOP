using ObjectOrientedPractics.Services;
using System;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет клиента.
    /// </summary>
    class Customer
    {
        /// <summary>
        /// Уникальный идентификатор клиента.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Полное имя клиента.
        /// </summary>
        private string _fullname = string.Empty;

        /// <summary>
        /// Адрес клиента.
        /// </summary>
        private string _address = string.Empty;

        /// <summary>
        /// Возвращает и задает полное имя клиента.
        /// </summary>
        public string Fullname
        {
            get { return _fullname; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(_fullname));
                _fullname = value;
            }
        }

        /// <summary>
        /// Возвращает и задает адрес клиента.
        /// </summary>
        public string Address
        {
            get { return _address; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 500, nameof(_address));
                _address = value;
            }
        }

        /// <summary>
        /// Возвращает уникальный идентификатор клиента.
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullname">Полное имя клиента.</param>
        /// <param name="address">Адрес клиента.</param>
        public Customer(string fullname, string address)
        {
            Fullname = fullname;
            Address = address;
            _id = IdGenerator.GetNextId();
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        public Customer()
        {
            Fullname = string.Empty;
            Address = string.Empty;
            _id = IdGenerator.GetNextId();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsManagerApp
{
    class Contact
    {
        public Contact(string name, string number)
        {
            Name = name;
            Number = number;
        }
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Invalid name!");
                }
                else
                {
                    _name = value;
                }
            }
        }
        private string _number;
        public string Number {
            get => _number;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 9)
                {
                    throw new Exception("Invalid number!");
                }
                else
                {
                    _number = value;
                }
            }
        }

    }
}

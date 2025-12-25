using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsManagerApp
{
    class PhoneBook
    {
        public List<Contact> Contacts { get; set; }
        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }
        public void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Name: {contact.Name} | Number: {contact.Number}\n");
        }
        public void DisplayContact(string number)
        {
            var contact = Contacts.FirstOrDefault(c => c.Number == number);
            if (contact == null)
            {
                Console.WriteLine("Contact not found");
            }
            else
            {
                DisplayContactDetails(contact);
            }
        }
        public void ShowAll()
        {
            int i = 1;
            foreach (var contact in Contacts)
            {
                
                Console.WriteLine($"{i}. ");
                DisplayContactDetails(contact);

                i++;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsManagerApp
{
    class PhoneBook
    {

        private void DisplayContactsDetailList (List<Contact> contacts)
        {

            int i = 1;
            foreach (var contact in contacts)
            {

                Console.WriteLine($"{i}. ");
                DisplayContactDetails(contact);

                i++;
            }
        }
        public List<Contact> Contacts { get; set; } = new List<Contact>();
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
            DisplayContactsDetailList(Contacts);
        }

        public void DisplayMatchingContacts(string searchPhrase)
        {
            var matchingContacts = Contacts.Where(c => c.Name.Contains(searchPhrase)).ToList();
            Console.WriteLine($"Contacts matching to '{searchPhrase}': \n");
            DisplayContactsDetailList(matchingContacts);
        }
        public void DeleteContact(string number)
        {
            var contactToDelete = Contacts.FirstOrDefault(c => c.Number == number);
            if (contactToDelete != null)
            {
                Console.WriteLine($"Name: {contactToDelete.Name} | Number: {contactToDelete.Number}  has been deleted");
                Contacts.Remove(contactToDelete);


            }
            else { 
            Console.WriteLine("Contact not found!");
            }
        }


    }
}

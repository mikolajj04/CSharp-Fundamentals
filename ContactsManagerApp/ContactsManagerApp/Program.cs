using System;
using System.Security.Cryptography;
namespace ContactsManagerApp;

class Program
{
    static void Main()
    {
      var phonebook = new PhoneBook();
while (true) {  
            Console.WriteLine("------------Contacts Manager------------");
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("[1]. Show all contacts");
            Console.WriteLine("[2]. Search for contact by number");
            Console.WriteLine("[3]. Search for contact");
            Console.WriteLine("[4]. Add new contact");

            
        
            var option = Console.ReadLine();


               
            switch (option)
            {
                case "1":
                    phonebook.ShowAll();
                    break;
                case "2":
                    Console.WriteLine("Enter a number: ");
                    string number = Console.ReadLine();
                    phonebook.DisplayContact(number);
                    break;
                case "3":
                    Console.WriteLine("Enter a name or part of the name of your contact: ");
                    string phrase = Console.ReadLine();
                    phonebook.DisplayMatchingContacts(phrase);
                    break;
                case "4":
                    Console.WriteLine("Enter name of your contact:  ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter number of your contact:  ");
                    string newnumber = Console.ReadLine();
                    Contact newContact = new Contact(name, newnumber);
                    phonebook.AddContact(newContact);
                    break;
                default:
                    Console.WriteLine("Choose proper option!");
                    break;
                   
            }
            Console.WriteLine("Press Enter to reset");
            Console.WriteLine("Press X to Quit");
           ConsoleKeyInfo key= Console.ReadKey(intercept: true);
            if (key.Key == ConsoleKey.X)
            {
                return;
            }

            Console.Clear();
        } 


    
    }
}

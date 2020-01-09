using System;
using System.Collections.Generic;


namespace PhoneBook
{
class Menu            
          {      
            public void Options()
            {
            Console.WriteLine("Welcome to Phonebook application:");
            Console.WriteLine("Enter Your options:");
            Console.WriteLine("*********");
            Console.WriteLine("1.AddContact 2.DeleteContact 3.ShowContact 4.SearchContact 5.Exit ");
            Console.WriteLine("*********");
            //int option = Convert.ToInt32(Console.ReadLine());
            PhoneBooks phonebook = new PhoneBooks();
            Contact contact = new Contact(); 
            int option = Convert.ToInt32(Console.ReadLine());
            while(option!=5)
            {
            switch(option)
            {
                case 1: phonebook.AddContact(contact);
                        break;
                case 2: //phonebook.DeleteContact(contact);
                        break;
                case 3: //phonebook.ShowContact(contact);
                        break;
                case 4: //phonebook.SearchContact(contact);
                        break;
                case 5: System.Environment.Exit(0);
                        break;
                default:Console.WriteLine("Invalid option");
                        break;
            }
            Options();
           }
          }
          }
}

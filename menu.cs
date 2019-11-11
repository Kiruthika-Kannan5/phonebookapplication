using System;
using System.Collections.Generic;


namespace phonebookapplication
{
class Menu            
          {
            Console.WriteLine("Welcome to Phonebook application:");
            Console.WriteLine("Enter Your options:");
            Console.WriteLine("*********");
            Console.WriteLine(" 1.AddContact 2.DeleteContact 3.ShowContact 4.SearchContact ");
            Console.WriteLine("*********");
            int options = Convert.ToInt32(Console.ReadLine());
            switch(options)
            {
                case 1: phonebook.AddContact(contacts);
                        break;
                case 2: phonebook.DeleteContact(contacts);
                        break;
                case 3: phonebook.ShowContact(contacts);
                        break;
                case 4: phonebook.SearchContact(contacts);
                        break;
           
            }
          }


}
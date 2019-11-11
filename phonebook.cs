using System;
using System.Collections.Generic;



namespace phonebookapplication
{
     class PhoneBook
          {
            AddContact();
            DeleteContact();
            ShowContact();
            SearchContact();
          }   

        public static void AddContact()
        {
             Contact contact = new Contact();
             Console.WriteLine("enter first name:");
             contact.FirstName=Console.ReadLine();
             Console.WriteLine("enter last name:");
             contact.LastName=Console.ReadLine();
             Console.WriteLine("enter the phone number:");
             contact.PhoneNumber=Convert.Todouble(Console.ReadLine());
             Console.WriteLine("enter mailid:");
             contact.EmailId=Console.ReadLine(); 
        }
        public static void DeleteContact(List<Contact> contacts)
        {
            Console.WriteLine("Are you sure Want to delete:");
            Console.WriteLine("Enter the name:");
            string FirstName = Console.ReadLine();
            contacts.RemoveAll(FirstName,LastName,PhoneNumber,EmailId);
        }
        public static void ShowContact(List<Contact> contacts)
        {
            Console.Write("Total Contacts:");
            Console.WriteLine(contacts.Count);
            foreach (var person in contacts)
            Console.WriteLine("Name : " + person.FirstName + " " + person.LastName + ",PhoneNumber :" + person.PhoneNumber + ", Email Id:" + person.EmailId);
            
        }
        public static void SearchContact(List<Contact> contacts)
        {
            List<int> contactlist = new List<int>(contacts.FindAll(FirstName)); 
            foreach(int person in contactlist) 
            { 
               Console.WriteLine(); 
            } 

        }

}
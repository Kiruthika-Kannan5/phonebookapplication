using System;
using System.Collections.Generic;



namespace PhoneBook
{
     class PhoneBooks
        {
        public void AddContact(Contact contact)
        {
             List<Contact> contacts = new List<Contact>();
             //Contact contact = new Contact();
             Consolehandler consolehandler = new Consolehandler();
             consolehandler.GetContact();
             contacts.Add(contact);
             //FileHandler filehandler = new FileHandler();
             //filehandler.PhonebookDetails(contacts);

        }
        /*public static void DeleteContact(List<Contact> contacts)
        {
            Console.WriteLine("Are you sure Want to delete:");
            Console.WriteLine("Enter the name:");
            string FirstName = Console.ReadLine();
            contacts.RemoveAll(FirstName);
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
            Console.WriteLine("Enter the name you want to search");
            Contact contact = new Contact();
            List<string> contactlist = new List<int>(contacts.FindAll(FirstName)); 
            foreach(string person in contactlist) 
            { 
               Console.WriteLine(); 
            } 

        }*/
        }
}
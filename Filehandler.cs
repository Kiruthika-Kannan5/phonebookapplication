using System;
using System.IO;
using System.Collections.Generic;


namespace PhoneBook
{
    
     class FileHandler
    {
            // List<Contact> contacts = new List<Contact>();
        public void PhonebookDetails(List<Contact> contacts)
        {
            string path = @"C:\users\kkiruthika\Phonebook.txt";
            if(!File.Exists(path))
            {
                Console.WriteLine("FileExists");
            }
             using (var writeToFile = new StreamWriter(path, true))
            {
                foreach (var entity in contacts)
                {
                    string contactInformation = string.Concat("FirstName: ", entity.FirstName, 
                    Environment.NewLine, "LastName: ", entity.LastName, 
                    Environment.NewLine,  "PhoneNumber: ", entity.PhoneNumber, 
                    Environment.NewLine, "EmailId: ", entity.EmailId);
                    writeToFile.WriteLine(contactInformation);
                    writeToFile.WriteLine("************");
                }
            }
        }

   }
}
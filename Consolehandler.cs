using System;

namespace PhoneBook
{

public class Consolehandler : IGetcontact
{
  public void GetContact()
  {
             Contact contact = new Contact();
             
             Console.WriteLine("enter first name:");
             contact.FirstName=Console.ReadLine();
            
             Console.WriteLine("enter last name:");
             contact.LastName=Console.ReadLine();
            
             Console.WriteLine("enter the phone number:");
             contact.PhoneNumber=(Console.ReadLine());
            
             Console.WriteLine("enter mailid:");
             contact.EmailId=Console.ReadLine(); 
            
  }
  
  
}

}
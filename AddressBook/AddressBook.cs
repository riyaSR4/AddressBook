using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class CreateAddressBook
    {
        List<Contact> addressBook = new List<Contact>();
        public void CreateContact()
        {
            Console.WriteLine("Enter the details\n 1.First Name:\n 2.Last Name:\n 3.Address:\n 4.City:\n 5.State:\n" +
                " 6.Zip:\n 7.Phone Number:\n 8.Email:\n");
            Contact contact = new Contact()
            {
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Address = Console.ReadLine(),
                City = Console.ReadLine(),
                State = Console.ReadLine(),
                Zip = Console.ReadLine(),
                PhoneNumber = Console.ReadLine(),
                Email = Console.ReadLine()
            };
            Console.WriteLine("The entered details:\n" + "First Name:" + contact.FirstName + '\n' 
                + "Last Name:" + contact.LastName + '\n' + "Address:" + contact.Address + '\n' + "City:"
                + contact.City + '\n' + "State:" + contact.State + '\n' + "Zip:" + contact.Zip + '\n' 
                + "PhoneNumber:" + contact.PhoneNumber + '\n' + "Email:" + contact.Email + '\n');
            addressBook.Add(contact);
        }
    }
}

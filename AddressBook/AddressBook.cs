using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class CreateAddressBook
    {
        List<Contact> createAddressBook = new List<Contact>();
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
            createAddressBook.Add(contact);
        }
        public void EditContact(string name)
        {
            foreach(var contact in createAddressBook)
            {
                if(contact.FirstName.Equals(name) || contact.LastName.Equals(name))
                {
                    Console.WriteLine("Enter the option to edit\n 1.Last Name\n 2.Address\n 3.City\n 4.State\n " +
                        " 5.Zip\n 6.Phone Number\n 7.Email");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch(option)
                    {
                        case 1: contact.LastName = Console.ReadLine();
                            break;
                        case 2:
                            contact.Address = Console.ReadLine();
                            break;
                        case 3:
                            contact.City = Console.ReadLine();
                            break;
                        case 4:
                            contact.State = Console.ReadLine();
                            break;
                        case 5:
                            contact.Zip = Console.ReadLine();
                            break;
                        case 6:
                            contact.PhoneNumber = Console.ReadLine();
                            break;
                        case 7:
                            contact.Email = Console.ReadLine();
                            break;
                    }
                }
            }
        }
        public void DeleteContact(string name)
        {
            Contact contact = new Contact();
            foreach (var data in createAddressBook)
            {
                if(contact.FirstName.Equals(name) || contact.LastName.Equals(name))
                {
                    contact = data;
                }
            }
            createAddressBook.Remove(contact);
        }
        public void Display()
        {
            foreach (var data in createAddressBook)
            {
                Console.WriteLine(data.FirstName + "\n" + data.LastName + "\n" + data.Address + "\n" + data.City
                    + "\n" + data.State + "\n" + data.Zip + "\n" + data.PhoneNumber + "\n" + data.Email);
            }
        }
    }
}

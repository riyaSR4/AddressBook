using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class CreateAddressBook
    {

        List<Contact> createAddressBook = new List<Contact>();
        Dictionary<string, List<Contact>> dict = new Dictionary<string, List<Contact>>();
        Dictionary<string, List<Contact>> state = new Dictionary<string, List<Contact>>();
        Dictionary<string, List<Contact>> city = new Dictionary<string, List<Contact>>();
        int count = 0;
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
            foreach (var data in dict)
            {
                foreach (var item in data.Value)
                {
                    if (item.FirstName.Equals(contact.FirstName))
                    {
                        Console.WriteLine("Name already exists");
                        count++;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("The entered details:\n" + "First Name:" + contact.FirstName + '\n'
                     + "Last Name:" + contact.LastName + '\n' + "Address:" + contact.Address + '\n' + "City:"
                     + contact.City + '\n' + "State:" + contact.State + '\n' + "Zip:" + contact.Zip + '\n'
                     + "PhoneNumber:" + contact.PhoneNumber + '\n' + "Email:" + contact.Email + '\n');
                createAddressBook.Add(contact);
            }
        }
        public void AddAddressBookToDictionary()
        {
            Console.WriteLine("Enter the name");
            string uniqueName = Console.ReadLine();
            dict.Add(uniqueName, createAddressBook);
            createAddressBook = new List<Contact>();
        }

        public void AddToJsonFile(string filePath)
        {
            var json = JsonConvert.SerializeObject(dict);
            File.WriteAllText(filePath, json);
        }
        public void EditContact(string name, string contactName)
        {
            foreach (var data in dict)
            {
                if (data.Key.Equals(name))
                {
                    foreach (var contact in data.Value)
                    {
                        if (contact.FirstName.Equals(name) || contact.LastName.Equals(name))
                        {
                            Console.WriteLine("Enter the option to edit\n 1.Last Name\n 2.Address\n 3.City\n 4.State\n " +
                                " 5.Zip\n 6.Phone Number\n 7.Email");
                            int option = Convert.ToInt32(Console.ReadLine());
                            switch (option)
                            {
                                case 1:
                                    contact.LastName = Console.ReadLine();
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
            }
        }
        public void DeleteContact(string name, string contactName)
        {
            Contact contact = new Contact();
            foreach (var data in dict)
            {
                if (data.Key.Equals(name))
                {
                    foreach (var item in data.Value)
                    {
                        if (item.FirstName.Equals(name) || item.LastName.Equals(name))
                        {
                            contact = item;
                        }
                    }
                    data.Value.Remove(contact);
                }
                else
                {
                    Console.WriteLine("No dictionary with Key Exists");
                }
            }
        }
        public void Display()
        {
            foreach (var data in dict)
            {
                Console.WriteLine(data.Key);
                foreach (var contact in data.Value)
                {
                    Console.WriteLine(contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.City
                        + "\n" + contact.State + "\n" + contact.Zip + "\n" + contact.PhoneNumber + "\n" + contact.Email);
                }
            }
        }
        public void SearchByCityOrState()
        {
            int cityCount = 0, stateCount = 0;
            bool flag = true;
            while (flag)
            {
                Console.WriteLine(" 1.Search by City\n 2.Search by State\n 3.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the city to search");
                        string city = Console.ReadLine();
                        List<Contact> contact = new List<Contact>();
                        Console.WriteLine("The persons in the city are: ");
                        foreach (var data in dict)
                        {
                            contact = data.Value.Where(x => x.City == city).ToList();
                            foreach (var Contact in contact)
                            {
                                Console.WriteLine(Contact.FirstName + " " + Contact.LastName);
                                this.city.Add(data.Key, contact);
                                cityCount++;
                            }
                        }
                        Console.WriteLine("Number of persons in the city : " + cityCount);
                        break;
                    case 2:
                        Console.WriteLine("Enter the State to search");
                        string state = Console.ReadLine();
                        Console.WriteLine("The persons in the state are: ");
                        List<Contact> contact1 = new List<Contact>();
                        foreach (var data in dict)
                        {
                            contact1 = data.Value.Where(x => x.State.Equals(state)).ToList();
                            foreach (var Contact in contact1)
                            {

                                Console.WriteLine(Contact.FirstName + " " + Contact.LastName);
                                this.state.Add(data.Key, contact1);
                                stateCount++;
                            }
                        }
                        Console.WriteLine("Number of persons in the state : " + stateCount);
                        break;
                    case 3:
                        flag = false;
                        break;
                }
            }
        }

    }
}

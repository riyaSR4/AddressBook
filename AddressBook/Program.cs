using System;
namespace AddressBook
{
    class Program
    {
        const string filePath = @"D:\BridgeLabs Training\AddressBook\AddressBook\Addressbook.json";

        static void Main(string[] args)
        {
            
            bool flag = true;
            string key = null, input = null;
            CreateAddressBook createAddressBook = new CreateAddressBook();
            while (flag)
            {
                Console.WriteLine("Enter the option to proceed\n 1.Create Contact\n 2.Add to Dictionary\n " +
                "3.Edit Contact\n 4.Delete Contact\n " +
                "5.Display Contact\n 6.Add to Json\n 7.Search Person in a City or State\n 8.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        createAddressBook.CreateContact();
                        break;
                    case 2:
                        createAddressBook.AddAddressBookToDictionary();
                        break;
                    case 3:
                        Console.WriteLine("Enter Key");
                        key = Console.ReadLine();
                        Console.WriteLine("Enter the name to edit contact details");
                        input = Console.ReadLine();
                        createAddressBook.EditContact(key, input); 
                        break;
                    case 4:
                        Console.WriteLine("Enter Key");
                        key = Console.ReadLine();
                        Console.WriteLine("Enter the name of contact details to be deleted");
                        input = Console.ReadLine();
                        createAddressBook.DeleteContact(key, input);
                        break;
                    case 5:
                        createAddressBook.Display();
                        break;
                    case 6:
                        createAddressBook.AddToJsonFile(filePath);
                        break;
                    case 7:
                        createAddressBook.SearchByCityOrState();
                        break;
                    case 8:
                        flag = false;
                        break;
                }
            }
        }
    }
}

using System;
namespace AddressBook
{
    class Program
    {
        const string jsonFilePath = @"D:\BridgeLabs Training\AddressBook\AddressBook\Addressbook.json";
        static string filePath = @"D:\BridgeLabs Training\AddressBook\AddressBook\Contact.txt";
        static string csvFilePath = @"D:\BridgeLabs Training\AddressBook\AddressBook\Contact.csv";
        static string filePathJson = @"D:\BridgeLabs Training\AddressBook\AddressBook\Contact.json";
        static void Main(string[] args)
        {

            bool flag = true;
            string key = null, input = null;
            CreateAddressBook createAddressBook = new CreateAddressBook();
            while (flag)
            {
                Console.WriteLine("Enter the option to proceed\n 1.Create Contact\n 2.Add to Dictionary\n " +
                "3.Edit Contact\n 4.Delete Contact\n " +
                "5.Display Contact\n 6.Add to Json\n 7.Search and Count Persons in a City or State\n " +
                "8.Sort Persons by Name, City, State and Zip\n" +
                " 9.Write to File\n 10.Read from File\n 11.Write as CSV File\n 12.Read as CSV File\n " +
                "13.Write as JSON File\n 14.Read as JSON File\n 15.Exit");
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
                        createAddressBook.AddToJsonFile(jsonFilePath);
                        break;
                    case 7:
                        createAddressBook.SearchByCityOrState();
                        break;
                    case 8:
                        createAddressBook.Sort();
                        break;
                    case 9:
                        createAddressBook.WriteFromStreamWriter(filePath);
                        break;
                    case 10:
                        createAddressBook.ReadFromStreamReader(filePath);
                        break;
                    case 11:
                        createAddressBook.WriteFromCSVfile(csvFilePath);
                        break;
                    case 12:
                        createAddressBook.ReadFromCSVFile(csvFilePath);
                        break;
                    case 13:
                        createAddressBook.WriteToJsonFile(filePathJson);
                        break;
                    case 14:
                        createAddressBook.ReadFromJsonFile(filePathJson);
                        break;
                    case 15:
                        flag = false;
                        break;
                }
            }
        }
    }
}
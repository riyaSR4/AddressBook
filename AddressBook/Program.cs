using System;
namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the option to proceed\n 1.Create Contact\n 2.Add to Dictionary\n " +
                "3.Edit Contact\n 4.Delete Contact\n " +
                "5.Display Contact\n 6.Exit");
            bool flag = true;
            string key = null, input = null;
            CreateAddressBook createAddressBook = new CreateAddressBook();
            while (flag)
            {
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
                        flag = false;
                        break;
                }
            }
        }
    }
}

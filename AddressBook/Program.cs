using System;
namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the option to proceed\n 1.Create Contact\n 2.Edit Contact\n 3.Exit");
            bool flag = true;
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
                        Console.WriteLine("Enter the name to edit contact details");
                        string input = Console.ReadLine();
                        createAddressBook.EditContact(input); 
                        break;
                    case 3:
                        flag = false;
                        break;
                }
            }
        }
    }
}

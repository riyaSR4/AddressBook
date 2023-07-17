using System;
namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook Problem Statement");
            CreateAddressBook book = new CreateAddressBook();
            book.CreateContact();
        }
    }
}

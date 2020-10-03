using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book System!");
            
            AddressBook addressBook = new AddressBook();
            addressBook.AddDetailsOfPersons("Kretika", "Arora", "home", "faridabad", "haryana", 121001, 96578, "k@gmail.com");
            addressBook.DisplayContactPersonDetails();
        }
    }
}

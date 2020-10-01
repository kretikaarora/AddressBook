using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Welcome to Address Book ");
            AddressBook addressBook = new AddressBook();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Please enter your firstname, last name, address, city, state, zip, phone no, email ");
                string firstName = Console.ReadLine();
                if (firstName == "")
                {
                    flag = false;
                    break;
                }
                string lastName = Console.ReadLine();
                string address = Console.ReadLine();
                string city = Console.ReadLine();
                string state = Console.ReadLine();
                int zip = Convert.ToInt32(Console.ReadLine());
                double phoneNo = Convert.ToDouble(Console.ReadLine());
                string eMail = Console.ReadLine();

                addressBook.AddDetailsOfPersons(firstName, lastName, address, city, state, zip, phoneNo, eMail);
            }

           
            addressBook.DisplayContactPersonDetails();
            Console.WriteLine("To update  details Enter 'YES' or else 'NO' ");
            string updateCheck = Console.ReadLine();
            if(updateCheck =="YES")
            {
                Console.WriteLine("enter the first name & last name of the person to be updated");
                string newFirstName = Console.ReadLine();
                string newLastName = Console.ReadLine();
                addressBook.UpdateContactPersonDetails(newFirstName, newLastName);
            }
            Console.WriteLine("To delete Details enter 'Y' else enter 'N' ");
            char deleteCheck= Convert.ToChar(Console.ReadLine());
            if (deleteCheck == 'Y')
            {
                Console.WriteLine("enter the first name & last name of the person contact to be delete  ");
                string fName= Console.ReadLine();
                string lName= Console.ReadLine();
                addressBook.DeleteContactPersonDetails(fName, lName);

            }

        }
    }
}

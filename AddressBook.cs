using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;


namespace AddressBookSystem
{
    public class AddressBook
    {
        private List<ContactPerson> addressBookList;
        public AddressBook()
        {
            addressBookList = new List<ContactPerson>();

        }
        public void AddDetailsOfPersons(string firstName, string lastName, string address, string city, string state, int zip, double phoneNo, string eMail)
        {
            ContactPerson contactPerson = new ContactPerson(firstName, lastName, address, city, state, zip, phoneNo, eMail);
            addressBookList.Add(contactPerson);
        }

        public void DisplayContactPersonDetails()
        {
            int numberOfPersons = 1;
            foreach (ContactPerson contactPerson in addressBookList)
            {

                Console.WriteLine("The Details of Contact Number {0} -", numberOfPersons);
                Console.WriteLine(" the first name is : " + contactPerson.firstName + " \n the last name is :" + contactPerson.lastName + "\n the address is : " + contactPerson.address + " \n the city is : " + contactPerson.city + " \n the state is " + contactPerson.state + "\n the zip is :" + contactPerson.zip + "\n the phone number is : " + contactPerson.phoneNo + " \n the email is :" + contactPerson.email);
                numberOfPersons++;
                Console.WriteLine("******************************************************************************************");
            }
        }

        public void UpdateContactPersonDetails()
        {
            Console.WriteLine("enter the first name & last name of the person to be updated");
            string newFirstName = Console.ReadLine();
            string newLastName = Console.ReadLine();
            foreach (ContactPerson contactPerson in addressBookList)
            {
                if(newFirstName==contactPerson.firstName &&  newLastName==contactPerson.lastName )
                {
                    Console.WriteLine("Enter the details to be updated");
                    contactPerson.address = Console.ReadLine();
                    contactPerson.city = Console.ReadLine();
                    contactPerson.state = Console.ReadLine();
                    contactPerson.zip = Convert.ToInt32(Console.ReadLine());
                    contactPerson.phoneNo = Convert.ToDouble(Console.ReadLine());
                    contactPerson.email = Console.ReadLine();
                    Console.WriteLine("details has been updated");

                }
            }
        }

    }
}

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

        //public void AddMultipleDictionaries()




        public void DisplayContactPersonDetails()
        {
            int numberOfPersons = 1;
            foreach (ContactPerson contactPerson in addressBookList)
            {

                Console.WriteLine("The Details of Contact Number {0} -", numberOfPersons);
                Console.WriteLine("firstName : " + contactPerson.firstName + "  last name  :" + contactPerson.lastName + " address : " + contactPerson.address + " city : " + contactPerson.city + " state : " + contactPerson.state + "  zip : " + contactPerson.zip + " phone number : " + contactPerson.phoneNo + "  email :" + contactPerson.email);
                numberOfPersons++;
                Console.WriteLine("******************************************************************************************");
            }
        }

        public void UpdateContactPersonDetails(string newFirstName, string newLastName)
        {

            foreach (ContactPerson contactPerson in addressBookList)
            {
                if (newFirstName == contactPerson.firstName && newLastName == contactPerson.lastName)
                {
                    Console.WriteLine("Enter the details to be updated");
                    contactPerson.address = Console.ReadLine();
                    contactPerson.city = Console.ReadLine();
                    contactPerson.state = Console.ReadLine();
                    contactPerson.zip = Convert.ToInt32(Console.ReadLine());
                    contactPerson.phoneNo = Convert.ToDouble(Console.ReadLine());
                    contactPerson.email = Console.ReadLine();
                    Console.WriteLine("details has been updated");
                    Console.WriteLine("the updated list is-");
                    DisplayContactPersonDetails();

                }

            }
        }
        public void DeleteContactPersonDetails(string fName, string lName)

        {
            foreach (ContactPerson contactPerson in addressBookList)
            {
                if (fName == contactPerson.firstName && lName == contactPerson.lastName)
                {
                    addressBookList.Remove(contactPerson);
                    Console.WriteLine("contact person deleted");
                    Console.WriteLine("updated list is ");
                    DisplayContactPersonDetails();

                }
            }

        }


    }
}


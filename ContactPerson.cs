using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    public class ContactPerson
    {

        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public int zip;
        public Double phoneNo;
        public string email;
        public ContactPerson(string firstName, string lastName, string address, string city, string state, int zip, double phoneNo, string email)

        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNo = phoneNo;
            this.email = email;

        }
      







    }
}
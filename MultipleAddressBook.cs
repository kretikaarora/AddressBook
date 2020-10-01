using AddressBookSystem;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADDRESSBOOKSYSTEM
{
    public class MultipleAddressBook
    {
        Dictionary<string, AddressBook> addressBookDictionary;
        public MultipleAddressBook()
            {
              addressBookDictionary = new Dictionary<string, AddressBook>();
            }
        public void AddMultipleAddressBook(string name,AddressBook addressBook)
        {
            addressBookDictionary.Add(name, addressBook);
        }

        public void display(string name)
        {
            addressBookDictionary[name].DisplayContactPersonDetails();
        }



    }
}

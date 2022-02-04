using System;

namespace AddressBookSystemLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address Book System Using LINQ ");

            // UC1 Create a new table
            AddressBookTable addressBookTable = new AddressBookTable();

            // UC3
            addressBookTable.GetAllContacts();
        }
    }
}

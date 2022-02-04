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
            //addressBookTable.GetAllContacts();

            // UC4
            //addressBookTable.EditExistingContact("Shubham", "Seth", "PhoneNumber", "8173070519");

            // UC5
            // addressBookTable.DeleteContact("Vishal", "Singh"); 

            // UC6
            // addressBookTable.RetrieveByCityOrState("Jaunpur", "Delhi"); 

            // UC7
            addressBookTable.CountByCityOrState("Varanasi", "Uttar Pradesh");
        }
    }
}

using System;
using System.Data;

namespace AddressBookSystemLINQ
{
    class AddressBookTable
    {
        // UC1:- Create a new DataTable
        DataTable table = new DataTable("AddressBookSystem");

        /* UC2:- Ability to create a Address Book Table with first and last names, address, city, 
                 state, zip, phone number and email as its attributes
        */
        public  AddressBookTable()
        {
            table.Columns.Add("FirstName", typeof(string));   //add columns
            table.Columns.Add("LastName", typeof(string));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("City", typeof(string));
            table.Columns.Add("State", typeof(string));
            table.Columns.Add("Zip", typeof(string));
            table.Columns.Add("PhoneNumber", typeof(string));
            table.Columns.Add("Email", typeof(string));

            // UC3:- Ability to insert new Contacts to Address Book
            table.Rows.Add("Shubham", "Seth", "Kopa, Patrahi", "Jaunpur", "Uttar Pradesh", "222129", "8788566219", "shubham@gmail.com");
            table.Rows.Add("Ekta", "Verma", "Durga kund", "Varanasi", "Uttar Pradesh", "225121", "8570934858", "ekta@gmail.com");
            table.Rows.Add("Vishal", "Singh", "Machhalishahar", "Jaunpur", "Uttar Pradesh", "242206", "7894561230", "vishal@gmail.com.a");
        }

        public void GetAllContacts()
        {
            foreach (DataRow dr in table.AsEnumerable())
            {
                Console.WriteLine("\n");
                Console.WriteLine("FirstName:- " + dr.Field<string>("firstName"));  // you can write firstName as FirstName
                Console.WriteLine("LastName:- " + dr.Field<string>("lastName"));
                Console.WriteLine("Address:- " + dr.Field<string>("address"));
                Console.WriteLine("City:- " + dr.Field<string>("city"));
                Console.WriteLine("State:- " + dr.Field<string>("state"));
                Console.WriteLine("Zip:- " + dr.Field<string>("zip"));
                Console.WriteLine("PhoneNumber:- " + dr.Field<string>("phoneNumber"));
                Console.WriteLine("Email:- " + dr.Field<string>("eMail"));
            }
        }

    }
}

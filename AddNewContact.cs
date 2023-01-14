using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    internal class AddNewContact
    {
        public static void NewContact()
        {
            string yes = Console.ReadLine();
            Console.WriteLine("Add New Contact Details ? Type yes to add.");
            if (yes=="yes")
            { 
                
                    Address_Book_withContacts.Contact_Details();
                
            }
        }
    }
}

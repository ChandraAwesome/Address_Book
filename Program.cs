namespace Address_Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, Address!");
            // Address_Book_withContacts.Contact_Details();
            //AddNewContact.NewContact();
            // OR
            Console.WriteLine("ADDRESS BOOK");
            while (true)
            {
                Console.WriteLine("Enter your Program Number : 1) Contact Details \n 2) NewContact \n 3) Edit details \n 4) Delete details");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1: Address_Book_withContacts.Contact_Details(); break;
                    case 2: AddNewContact.NewContact(); break;
                    case 3: Edit_Details.Edit();break;
                    case 4: Deletedata.delete();break;
                }
            }
        }
    }
}

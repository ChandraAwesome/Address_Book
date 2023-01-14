using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    internal class Edit_Details
    {
        public static void Edit()
        {
            Console.WriteLine("Enter your first name : ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name :");
            string lastName = Console.ReadLine();
            //
            Console.WriteLine("Enter your Address :");
            string Address = Console.ReadLine();
            Console.WriteLine("Enter your City :");
            string City = Console.ReadLine();
            //
            Console.WriteLine("Enter your zipcode/pincode :");
            int zipcode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your phone number :");
            long phonenumber = Convert.ToInt64(Console.ReadLine());
            //
            Console.WriteLine("Enter your email id :");
            string emailId = Console.ReadLine();
            Console.WriteLine("\n" + "Verify your details" + "\n");
            // verify the details 
            Console.WriteLine("First name : " + firstName);
            Console.WriteLine("Last name : " + lastName);
            Console.WriteLine("Address :" + Address);
            Console.WriteLine("City :" + City);
            Console.WriteLine("Zipcode :" + zipcode);
            Console.WriteLine("Phone Number :" + phonenumber);
            Console.WriteLine("Email Id :" + emailId);
            Console.WriteLine("\n");
            Console.WriteLine("Are the above details are correct ?" + "if correst type yes.");

            // Confirm yes or no
            string yes = Console.ReadLine();
            if (yes == "yes")
            {
                Console.WriteLine("Thank You");
            }
            else { Console.WriteLine("Edit the Details");
                string NewCity = Console.ReadLine();
                Console.WriteLine("Edited data is :"+City.Replace(City,NewCity)); //  I TRIED THIS AND IT IS WORKING, BUT NEED MORE EFFICIENT WAY INSTEAD OF WRIRING LONG CODE
            }
        }
    }
}

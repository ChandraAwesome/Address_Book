﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Address_Book
{
    internal class Address_Book_withContacts
    {
        public static void Contact_Details()
        {
            // take input from the user
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
            Console.WriteLine("\n"+"Verify your details"+"\n");
            // verify the details 
            Console.WriteLine("First name : "+firstName);
            Console.WriteLine("Last name : "+lastName);
            Console.WriteLine("Address :"+Address);
            Console.WriteLine("City :"+City);
            Console.WriteLine("Zipcode :"+zipcode);
            Console.WriteLine("Phone Number :"+phonenumber);
            Console.WriteLine("Email Id :"+emailId);
            Console.WriteLine("\n");
            Console.WriteLine("Are the above details are correct ?"+"if correst type yes.");

            // Confirm yes or no
            string yes = Console.ReadLine();
            if (yes=="yes")
            {
                Console.WriteLine("Thank You");
            }
            else { Console.WriteLine("Fill the Correct Details"); }
        }
    }
}

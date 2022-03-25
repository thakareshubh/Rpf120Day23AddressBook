using System;
using System.Collections;

namespace AddressBookWelcomeMsg
{

    internal class Program
    {
        /// <summary>
        /// Creating Adress class with initialization
        /// </summary>
        public class NewPersoncontact
        {
            public string firstName, lastName, address, city, state, zip, phoneNumber, email;

            public void NewPerson(int maxPerson)
            {
                ArrayList addbook = new ArrayList();
                for (int i = 1; i < maxPerson; i++)
                {
                    Console.WriteLine("Enter First Name ");
                    firstName = Console.ReadLine();
                    addbook.Add(firstName);

                    Console.WriteLine("Enter Last Name");
                    lastName = Console.ReadLine();
                    addbook.Add(lastName);

                    Console.WriteLine("Enter Address ");
                    address = Console.ReadLine();
                    addbook.Add(address);
                    Console.WriteLine("Enter city");
                    city = Console.ReadLine();
                    addbook.Add(city);

                    Console.WriteLine("Enter state");
                    state = Console.ReadLine();
                    addbook.Add(state);
                    Console.WriteLine("Enter zip");
                    zip = Console.ReadLine();
                    addbook.Add(zip);
                    Console.WriteLine("Enter Phone Number");
                    phoneNumber = Convert.ToString(Console.ReadLine());
                    addbook.Add(phoneNumber);
                    Console.WriteLine("Enter Email");
                    email = Convert.ToString(Console.ReadLine());
                    addbook.Add(email);

                    // New person information
                    Console.WriteLine("\nGiven Detail Are : \n");
                    Console.WriteLine("First Name = " + addbook[0] + "\nLastt Name = " + addbook[1] + "\nAddress = " + addbook[2] + "\nCity = " + addbook[3] + "\nState = " + addbook[4] + "\nZip = " + addbook[5] + "\nPhone Number = " + addbook[6] + "\nEmail = " + addbook[7]);

                    Console.WriteLine("\n " + (i+1) + "person");
                }
                // Edit person deatail
                Console.WriteLine("Edit the detail by name");
                string Name = Console.ReadLine();
                if (firstName== Name)
                {
                    Console.WriteLine("Enter First Name ");
                    firstName = Console.ReadLine();
                    addbook.Add(firstName);

                    Console.WriteLine("Enter Last Name");
                    lastName = Console.ReadLine();
                    addbook.Add(lastName);

                    Console.WriteLine("Enter Address ");
                    address = Console.ReadLine();
                    addbook.Add(address);
                    Console.WriteLine("Enter city");
                    city = Console.ReadLine();
                    addbook.Add(city);

                    Console.WriteLine("Enter state");
                    state = Console.ReadLine();
                    addbook.Add(state);
                    Console.WriteLine("Enter zip");
                    zip = Console.ReadLine();
                    addbook.Add(zip);
                    Console.WriteLine("Enter Phone Number");
                    phoneNumber = Convert.ToString(Console.ReadLine());
                    addbook.Add(phoneNumber);
                    Console.WriteLine("Enter Email");
                    email = Convert.ToString(Console.ReadLine());
                    addbook.Add(email);

                    // New person information
                    Console.WriteLine("\nGiven Detail Are : \n");
                    Console.WriteLine("First Name = " + addbook[0] + "\nLastt Name = " + addbook[1] + "\nAddress = " + addbook[2] + "\nCity = " + addbook[3] + "\nState = " + addbook[4] + "\nZip = " + addbook[5] + "\nPhone Number = " + addbook[6] + "\nEmail = " + addbook[7]);


                }

            }

           
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Address Book Program");
            Console.WriteLine("Enter number person detail you want to add");
            int maxPerson =Convert.ToInt32( Console.ReadLine());
            NewPersoncontact a = new NewPersoncontact();
            a.NewPerson(maxPerson);

        }
    }
}

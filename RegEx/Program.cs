using System;
using System.Text.RegularExpressions;

namespace RegEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a valid name: ");
            string userName = Console.ReadLine();

            if (ValidateName(userName))
            {
                Console.WriteLine("Name is valid!");
            }
            else
            {
                Console.WriteLine("Sorry, name is not valid!");
            }

            Console.WriteLine("\nPlease enter a valid email address: ");
            string userEmail = Console.ReadLine();

            if (ValidateEmail(userEmail))
            {
                Console.WriteLine("Email is valid!");
            }
            else
            {
                Console.WriteLine("Sorry, email is not valid!");
            }

            Console.WriteLine("\nPlease enter a valid phone number (xxx-xxx-xxxx): ");
            string userPhone = Console.ReadLine();

            if (ValidatePhoneNumber(userPhone))
            {
                Console.WriteLine("Phone Number is valid!");
            }
            else
            {
                Console.WriteLine("Sorry, phone number is not valid!");
            }

            Console.WriteLine("\nPlease enter a valid date (dd/mm/yyyy): ");
            string userDate = Console.ReadLine();

            if (ValidateDate(userDate))
            {
                Console.WriteLine("Date is valid!");
            }
            else
            {
                Console.WriteLine("Sorry, date is not valid!");
            }

            Console.WriteLine("\nPlease enter a random HTML element: ");
            string userHTML = Console.ReadLine();

            if (ValidateHTML(userHTML))
            {
                Console.WriteLine("HTML is valid!");
            }
            else
            {
                Console.WriteLine("Sorry, HTML is not valid!");
            }
        }

        static public bool ValidateName(string input)
        {
            if (Regex.IsMatch(input, @"[A-Z{1}][a-z{1,29}]"))
            {
                return true;
            }
            else
                return false;
        }
        static public bool ValidateEmail(string input)
        {
            if (Regex.IsMatch(input, @"^([A-Za-z0-9]{5,30})@([A-Za-z]{5,10})(\.[A-Za-z]{2,3})$"))
            {
                return true;
            }
            else
                return false;
        }
        static public bool ValidatePhoneNumber(string input)
        {
            if (Regex.IsMatch(input, @"\d\d\d-\d\d\d-\d\d\d\d"))
            {
                return true;
            }
            else
                return false;
        }
        static public bool ValidateDate(string input)
        {
            if (Regex.IsMatch(input, @"[0-2]\d\/[0-1]\d\/\d\d\d\d"))
            {
                return true;
            }
            else
                return false;
        }
        static public bool ValidateHTML(string input)
        {
            if (Regex.IsMatch(input, @"\<[A-Za-z0-9]\>\<\/[A-Za-z0-9]\>"))
            {
                return true;
            }
            else
                return false;
        }
    }
}

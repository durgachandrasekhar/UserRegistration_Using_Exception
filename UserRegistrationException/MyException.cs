using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration_Using_Exception
{
    class MyException : Exception
    {
        public MyException(String message) : base(message)
        {

        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose what to Enter:");
            Console.WriteLine("-------------------------");
            Console.WriteLine("1. First Name.\n2. Last Name.\n3. Phone Number.\n4. Email Id.\n5. Password.");
            Console.WriteLine("-------------------------");

            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    try
                    {
                        Console.WriteLine("Enter your First Name:");
                        RegexPatterns name = new RegexPatterns();
                        bool result = name.ValidateName(Console.ReadLine());
                        Console.WriteLine(result);
                        if (result == false)
                        {
                            throw new MyException("Must contain characters only. Having first letter capital with minimum 3 characters.\n====================");
                        }
                    }
                    catch (MyException e)
                    {
                        Console.WriteLine("====================\nInvalid Input\n====================");
                        Console.WriteLine(e.Message);
                    }
                    break;
                case 2:
                    try
                    {
                        Console.WriteLine("Enter your Last Name:");
                        RegexPatterns lastname = new RegexPatterns();
                        bool resultlastname = lastname.ValidateLastName(Console.ReadLine());
                        Console.WriteLine(resultlastname);
                        if (resultlastname == false)
                        {
                            throw new MyException("Must contain characters only. Having first letter capital with minimum 3 characters.\n====================");
                        }
                    }
                    catch (MyException e)
                    {
                        Console.WriteLine("====================\nInvalid Input\n====================");
                        Console.WriteLine(e.Message);
                    }
                    break;
            }
        }
    }
}
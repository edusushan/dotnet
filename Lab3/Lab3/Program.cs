using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name:");
            String fname = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            String lname = Console.ReadLine();
            Console.WriteLine("Your First name is {0} and last name is  {1}", fname, lname);
            Console.ReadLine();
        }
    }
}

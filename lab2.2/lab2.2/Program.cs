using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:"); 
            string name = Console.ReadLine();
            Console.WriteLine("Hello," + name);
            Console.WriteLine("Welcome {0} to Nepal", name);
            Console.ReadLine();
        }
    }
}

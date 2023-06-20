using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10lambdaexpression
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array of numbers 
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Use a lambda expression to filter the array 
            var oddNumbers = Array.FindAll(numbers, n => n % 2 != 0);

            // Print the odd numbers to the console 
            Console.WriteLine("Odd numbers in the array:"); foreach (int num in oddNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}

//Entering and passing integer data type in c# using parse. 

using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:"); 
            int num1 = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Enter second number:"); 
            int num2 = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Enter third number:"); 
            int num3 = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Enter fourth number:"); 
            int num4 = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Enter fifth number:"); 
            int num5 = int.Parse(Console.ReadLine()); 
            int sum = num1 + num2 + num3 + num4 + num5;
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = {5}", num1, num2, num3, num4, num5, sum);
            Console.ReadLine();
        }
    }
}

//Float Double and Decimal Data Type using System; 
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab7FloatDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //float 
            float a = 45.812471294912471203f;
            Console.WriteLine("float:{0}", a);
            //double 
            double b = 560.123912489148125818749124d;
            Console.WriteLine("\ndouble:{0}", b);
            //decimal
            decimal c = 3455.123847561237812479124864464647124182m;
            Console.WriteLine("\ndecimal:{0}", c);
            Console.ReadLine();
        }
    }
}

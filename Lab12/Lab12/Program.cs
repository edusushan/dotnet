using System;
using System.Linq;

namespace Lab10Constructor
{
    class parametrizedconstrctor
    {
        public int a, b;
        // decalaring Paremetrized Constructor with ing x,y parameter
        public parametrizedconstrctor(int x, int y)  
        {
            a = x;
            b = y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            parametrizedconstrctor val = new parametrizedconstrctor(100, 175);   
            Console.WriteLine("\t");
            Console.WriteLine("value of a=" + val.a);
            Console.WriteLine("value of b=" + val.b);
            Console.ReadLine();
        }
    }
}
using System;

namespace Constructor
{
    class Staticconstrctor
    {
        public int a, b;

        static Staticconstrctor() //static constructor
        {

            Console.WriteLine("Static constructor called.");
        }

        public Staticconstrctor(int x, int y)
        {
            a = x;
            b = y;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Staticconstrctor val = new Staticconstrctor(100, 175);
            Console.WriteLine("\t");
            Console.WriteLine("value of a=" + val.a);
            Console.WriteLine("value of b=" + val.b);
            Console.ReadLine();
        }
    }
}

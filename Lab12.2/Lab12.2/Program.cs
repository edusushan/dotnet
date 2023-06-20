using System;
using System.Linq;

namespace Constructor
{
    class Copyconstrctor
    {
        public int a, b;

        //declaring copy constructor
        public Copyconstrctor(Copyconstrctor other)
        {
            a = other.a;
            b = other.b;
        }
        public Copyconstrctor(int x, int y) 
        {
            a = x;
            b = y;
        }
       

       

    }

    class Program
    {
        static void Main(string[] args)
        {
            //creating new constructor object 
            Copyconstrctor val1 = new Copyconstrctor(100, 175);  

            Console.WriteLine("Copy constructor");
           //val1 value is copied to val2
            Copyconstrctor val2 = new Copyconstrctor(val1);
            Console.WriteLine("Value of a ="+val2.a);
            Console.WriteLine("value of b ="+val2.b); 
            Console.ReadLine();
        }
    }
}

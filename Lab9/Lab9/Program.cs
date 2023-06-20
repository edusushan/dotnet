using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab9Polymorphism
{
    class Program
    {
        public void Add()
        {
            int a = 55; int b = 45;
            int c = a + b;
            Console.WriteLine(c);

        }
        public void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);


        }
        public void Add(string a, string b)
        {
            string c = a + " " + b;
            Console.WriteLine(c);
        }
        public void Add(float a, float b)
        {
            float c = a + b;
            Console.WriteLine(c);
        }
        static void Main(string[] args)
        {
            Program P = new Program();
            P.Add();
            P.Add(109, 5.5f);
            P.Add(34, 54);
            P.Add("Supriya", "Budhathoki");
            Console.ReadLine();
        }
    }
}

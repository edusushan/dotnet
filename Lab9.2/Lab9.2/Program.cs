using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab9PlymorphismDynamicOverloading
{
    class parent
    {
        public virtual void print()
        {
            Console.WriteLine("This is a method of parent class.");
        }
    }
    class child : parent
    {
        public override void print()
        {
            base.print();
            Console.WriteLine("This is a method of child class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            parent p = new child(); p.print();
            Console.ReadLine();
        }
    }
}

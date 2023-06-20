using System;
using System.Collections.Generic;
using System.Linq;
namespace Lab5DataType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("int maximum:");
            Console.WriteLine(int.MaxValue);
            Console.WriteLine("int minimum:");
            Console.WriteLine(int.MinValue);

            Console.WriteLine("\nfloat maximum:");
            Console.WriteLine(float.MaxValue);
            Console.WriteLine("float minimum:");
            Console.WriteLine(float.MinValue);

            Console.WriteLine("\nbyte maximum:");
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine("byte minimum:");
            Console.WriteLine(byte.MinValue);

            Console.WriteLine("\nsbyte maximum:");
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine("sbyte minimum:");
            Console.WriteLine(sbyte.MinValue);

            Console.WriteLine("\nchar maximum:");
            Console.WriteLine((int)char.MaxValue);
            Console.WriteLine("char minimum:");
            Console.WriteLine((int)char.MinValue);

            Console.WriteLine("\nshort maximum:");
            Console.WriteLine(short.MaxValue);
            Console.WriteLine("short minimum:");
            Console.WriteLine(short.MinValue);


            Console.WriteLine("\nuint maximum:");
            Console.WriteLine(uint.MaxValue);
            Console.WriteLine("uint minimum:");
            Console.WriteLine(uint.MinValue);

            Console.WriteLine("\nlong maximum:");
            Console.WriteLine(long.MaxValue);
            Console.WriteLine("long minimum:"); Console.WriteLine(long.MinValue);

            Console.WriteLine("\nulong maximum:");
            Console.WriteLine(ulong.MaxValue);
            Console.WriteLine("ulong minimum:");
            Console.WriteLine(ulong.MinValue);
            Console.ReadLine();
        }
    }
}


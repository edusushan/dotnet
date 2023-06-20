/*Boolean DataType 
 Bool Keyword is used for Boolean Data Type   which only stored True or False. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Boolean
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 98; int b = 45;
            //a greater than b 
            bool c = a > b;
            Console.WriteLine("a=98\nb=45\n\na>b:");
            Console.WriteLine(c); //a smaller than b
            bool d = a < b; 
            Console.WriteLine("\na<b:");
            Console.WriteLine(d);
            //a equals to b
            bool e = a == b; 
            Console.WriteLine("\na=b:");
            Console.WriteLine(e);
            Console.ReadLine();
        }
    }
}

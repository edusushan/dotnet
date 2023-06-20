using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exceptiontrycatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter dividend:"); 
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter divisor:");
            b = int.Parse(Console.ReadLine());
            try
            {
                if (b == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero.");
                }
                c = a / b;
                Console.WriteLine("Division  is = " + c);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Execution completed");
            }

            Console.ReadLine();
        }
    }
}

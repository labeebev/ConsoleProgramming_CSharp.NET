using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            Console.WriteLine("Enter number 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            num2 = Convert.ToInt32(Console.ReadLine());
            try
            {
                int quotient = num1 / num2;
                Console.WriteLine($"Division of {num1} and {num2} = {quotient}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Illegal Operation : {ex.Message}");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Console.WriteLine("This is the end of the program");
            }

        }
    }
}

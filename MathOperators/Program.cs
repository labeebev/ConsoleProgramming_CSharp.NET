using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 100;
            int num2 = 2;
            Console.WriteLine($"Addition : {num1 + num2}");
            Console.WriteLine($"Subtraction : {num1 - num2}");
            Console.WriteLine($"Multiplication : {num1 * num2}");
            Console.WriteLine($"Division : {num1 / num2}");
            Console.WriteLine($"Modulus : { num1 % num2}");

            num1 = num1 + 3;
            Console.WriteLine("New value of num1 is " + num1);
            Console.WriteLine($"Addition : {num1 + num2}");
            Console.WriteLine($"Subtraction : {num1 - num2}");
            Console.WriteLine($"Multiplication : {num1 * num2}");
            Console.WriteLine($"Division : {num1 / num2}");
            Console.WriteLine($"Modulus : { num1 % num2}");

            //Compound Assignment Operators

            num1 += 4;
            Console.WriteLine(num1);
            num1 -= 4;
            Console.WriteLine(num1);
            num1 *= 4;
            Console.WriteLine(num1);
            num1 /= 4;
            Console.WriteLine(num1);
        }
    }
}

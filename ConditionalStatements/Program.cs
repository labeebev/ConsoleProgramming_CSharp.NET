using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            //If statements (==,<,>,<=,>=,!=)

            if (num1 > num2)
            {
                Console.WriteLine("first number is greater than the second one");
            }
            else if(num1<num2)
            {
                Console.WriteLine("Second number is greater than the first one");
            }
            else if (num1 == num2)
            {
                Console.WriteLine("Both are same");
            }

            Console.WriteLine("Enter final grade :");
            int grade = Convert.ToInt32(Console.ReadLine());
            switch (grade)
            {
                case int n when n >= 0 && n <= 59:
                    Console.WriteLine("You failed");
                    break;
                case int n when n >= 60 && n <= 100:
                    Console.WriteLine("You passed");
                    break;
                default:
                    Console.WriteLine("Invalid Grade!");
                    break;
            }
        }
    }
}

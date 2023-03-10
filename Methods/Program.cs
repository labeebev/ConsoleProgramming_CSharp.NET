using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Void functions
            void PrintName()
            {
                Console.WriteLine("Hi");
            }
            void Addition(int num1,int num2)
            {
                Console.WriteLine($"The sum of {num1} and {num2} is {num1 + num2}");
            }

            PrintName();

            //Value returning functions
            int LargestNumber(int n1,int n2,int n3)
            {
                int largest = n1;
                if(largest < n2)
                {
                    largest = n2;
                }
                if (largest < n3)
                {
                    largest = n3;
                }
                return largest;
            }

            Console.WriteLine("Enter number 1:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 3:");
            int number3 = Convert.ToInt32(Console.ReadLine());
            Addition(number1, number2);
            int result =LargestNumber(number1, number2, number3);
            Console.WriteLine($"Largest number is {result}");

        }
    }
}

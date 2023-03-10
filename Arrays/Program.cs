using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5];
            //grades[0] = 1;
            //grades[1] = 25;
            //grades[2] = 38;
            //grades[3] = 45;
            //grades[4] = 54;

            //int[] grades1 = new int[] { 1, 25, 38, 45, 54 };
            for(int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine("Enter the element :");
                grades[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine(grades[i]);
            }

            //variable array
            string[] names = new string[] { "john", "joseph", "samuel" };

            //Add values in to variable array
            for(int i = 0; i < names.Length; i++)
            {
                Console.Write("Enter the name :");
                names[i] = Console.ReadLine();
            }

            //print values
            Console.WriteLine("The names are:");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }

    }
}

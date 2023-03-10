using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepititionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //for loop
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            //while loop
            int n = 0;
            while (n < 5)
            {
                Console.WriteLine(n);
                n++;
            }

            //do while loop
            n = 0;
            do
            {
                Console.WriteLine(n);
                n++;
            } while (n < 5);
        }
    }
}

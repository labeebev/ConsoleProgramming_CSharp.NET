using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            List<string> names = new List<string>();
            string name = string.Empty;

            //Add values to the list
            names.Add("Labeeb");

            Console.WriteLine("Enter names");
            while (!name.Equals("-1"))// while (name!="-1") // or while(name.Equals("-1") == false)
            {
                Console.WriteLine("Enter name:");
                name = Console.ReadLine();
                if(!string.IsNullOrEmpty(name) && !name.Equals("-1"))
                {
                    names.Add(name);
                    Console.WriteLine($"{name} is added successfully");
                }

            }

            //print values of the list
            for(int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine("Printing names via foreach loop");
            foreach(string i in names)
            {
                Console.WriteLine(i);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullname = "";
            int age;
            double salary;
            char gender = char.MinValue;
            bool working;

            Console.WriteLine("Please enter your fullname");
            fullname = Console.ReadLine();
            Console.WriteLine("Enter age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Salary");
            salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Gender(M/F)");
            gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Whether working or not");
            working = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Full Name : "+fullname);
            Console.WriteLine("Age : {0}", age);
            Console.WriteLine($"Salary : {salary}");
            Console.WriteLine("Gender : "+gender);
            Console.WriteLine("Working ? : " + working);

        }
    }
}

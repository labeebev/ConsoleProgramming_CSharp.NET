using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Person person = new Person();
            string middleName = string.Empty;
            Console.WriteLine("Enter first name :");
            person.firstName = Console.ReadLine();
            Console.WriteLine("Enter last name :");
            person.lastName = Console.ReadLine();
            Console.WriteLine("Enter the age :");
            person.age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your salary : ");
            int salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter middle name : ");
            middleName = Console.ReadLine();
            if (string.IsNullOrEmpty(middleName))
            {
                Console.WriteLine("Full name is " + person.getFullName());
            }
            else
            {
                Console.WriteLine("Full name is " + person.getFullName(middleName));
            }


            person.setSalary(salary);
           // Console.WriteLine("Full name is "+ person.getFullName());
           // Console.WriteLine("Age is : " + person.age);
            Console.WriteLine("Salary is : "+ person.getSalary());

            Console.WriteLine("Year of Birth using static : " + DateUtil.YearOfBirth(person.age));
       

        }
    }
    public class Person
    {
        //Properties when public
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }

        //fields when private
        private double salary { get; set; }

        public void setSalary(double salarylocal)
        {
            salary = salarylocal;
        }
        public double getSalary()
        {
            return salary;
        }
        public string getFullName()
        {
            return $"{firstName} {lastName}";
        }
        public string getFullName(string middleName)
        {
            return $"{firstName} {middleName} {lastName}";
        }
    }
    internal static class DateUtil
    {
        public static int YearOfBirth(int age)
        {
            return DateTime.Now.Year - age;
        }
        public static int YearOfBirth(DateTime dob)
        {
            if (dob == null)
                return 0;
            return dob.Year;
        }
        public static int Age(DateTime dob)
        {
            if (dob == null)
                return 0;
            return DateTime.Now.Year - dob.Year;
        }
    }
}

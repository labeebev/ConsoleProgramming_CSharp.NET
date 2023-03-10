using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "John";
            string lastName = "Wick";

            //Print to screen
            Console.WriteLine(firstName);
            Console.WriteLine("Hi, Welcome");

            //Concatenation
            Console.WriteLine(firstName + " " + lastName);
            Console.WriteLine("My full name is {0}, {1}", firstName, lastName);
            Console.WriteLine($"My full name is {firstName}, {lastName}");

            //String length
            int length = firstName.Length;  //Length is a property of string class
            Console.WriteLine($"Your name is {length} letters long");

            //Replace string parts
            string newName = firstName.Replace('o', 'i');
            Console.WriteLine($"Your new name is {newName}");
            string newName1 = firstName.Replace('h', ' ');
            Console.WriteLine($"Your updated name is {newName1}");

            //Append to other string variable
            string fullName = firstName + " " + lastName;
            Console.WriteLine($"Your full name is {fullName}");

            //split string
            string[] splitName = fullName.Split('h');
            for(int i = 0; i < splitName.Length; i++)
            {
                Console.WriteLine(splitName[i]);
            }

            //compare strings
            string nullString=null;
            string emptyString = "";
            string whiteSpaceString = " ";

            if (string.IsNullOrEmpty(nullString))
            {
                Console.WriteLine("String is null");
            }
            if(firstName == lastName)
            {
                Console.WriteLine("Names are equal");
            }
            if(firstName != lastName)
            {
                Console.WriteLine("Names are not equal");
            }
            int comparisonResult = string.Compare(firstName, lastName);
            if (comparisonResult == 0)
            {
                Console.WriteLine("Names are equal");
            }
            else
            {
                Console.WriteLine("Names are not equal");
            }
            //Convert to string
            string convertedString = string.Empty;
            int num = 1232432;
            convertedString = num.ToString();
            convertedString = 12321.ToString();

            Console.WriteLine(fullName.ToUpper());
            Console.WriteLine(lastName.ToLower());
        }
    }
}

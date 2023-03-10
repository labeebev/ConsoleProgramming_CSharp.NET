using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeManipulations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Empty Datetime
            DateTime date = new DateTime();

            //Create a Datetime from date and time
            DateTime dob = new DateTime(2000, 02, 13);
            Console.WriteLine(dob);

            //Create a Datetime from current timestamp
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            //Create a Datetime from a string
            DateTime dateFromString = DateTime.Parse("02/13/2000",CultureInfo.InvariantCulture);
            Console.WriteLine(dateFromString);

            //Add additional Time
            Console.WriteLine("One hour from now is " + now.AddHours(1));
            Console.WriteLine("One day from now is " + now.AddDays(1));

            //Ticks from DateTime
            Console.WriteLine("Time as a numeral : " + now.Ticks);

        }
    }
}

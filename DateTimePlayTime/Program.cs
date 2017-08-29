using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimePlayTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using the DateTime class, print to the console, the following lines:
            //Today is Wednesday.
            //Yesterday was Tuesday.
            //Tomorrow is Thursday.

            Console.WriteLine("Today is " + DateTime.Today.DayOfWeek + ".");
            Console.WriteLine("Yesterday was " + (DateTime.Today.DayOfWeek - 1) + ".");
            Console.WriteLine("Tomorrow is " + (DateTime.Today.DayOfWeek + 1) + ".");

            //Create a DateTime instance for your birth date in 2017. Print the following to the console: My birthday is the 283 day of the year.
            DateTime birthday = new DateTime(2017, 04, 14);
            Console.WriteLine("My birthday is the " + birthday.DayOfYear + " day of the year.");

            //Using DateTime, write a program that prints the number of days of a given month and year.
            Console.WriteLine("In 2017, February has " + DateTime.DaysInMonth(2017, 2) + " days.");
            Console.WriteLine("In 2017, July has " + DateTime.DaysInMonth(2017, 7) + " days.");

            //Write a program to find the leap years between 1994 and 2016.
            for (int year = 1994; year <= 2016; year++)
                if (DateTime.IsLeapYear(year))
                    Console.WriteLine(year + " is a leap year.");
                else
                    Console.WriteLine(year + " is NOT a leap year.");
        }
    }
}

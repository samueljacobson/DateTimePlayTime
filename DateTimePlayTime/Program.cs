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

            //Write a program to calculate what day of the week is 40 days from this moment.
            DateTime today = DateTime.Now;
            DateTime forty = today.AddDays(40);
            Console.WriteLine("40 days from now will be a " + forty.DayOfWeek + ".");

            //Write a program to get the difference between two dates in days.
            //For example, the difference between June 3, 2017 and June 5, 2017 is 2 days.
            DateTime date1 = new DateTime(2017, 6, 3);
            DateTime date2 = new DateTime(2017, 6, 5);
            Console.WriteLine("The difference between " + date1.ToShortDateString() + " and " + date2.ToShortDateString() + " is " 
                + (date2 - date1).TotalDays + " days.");

            //Write a program to check whether the given year, month and day are the current or not. 
            //Test Data : Input the Day: 17 Input the Month: 09 Input the Year: 2017
            //The formatted Date is : 17 / 09 / 2016
            //The current date status : False
            Console.WriteLine("Input the day:");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the month:");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the year:");
            int year2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The formatted date is: " + day + " / " + month + " / " + year2);

            bool dateStatus;
            if (DateTime.Now.Day == day && DateTime.Now.Month == month && DateTime.Now.Year == year2)
                dateStatus = true;
            else
                dateStatus = false;
            
            Console.WriteLine("The current date status: " + dateStatus);
        }
    }
}

using System;

namespace DateTimeE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime1 = new DateTime(2001, 4, 17);
            DateTime today = DateTime.Now;
            DateTime tomorrow = GetTomorrow();

            Console.WriteLine($"My birthday is {dateTime1}");
            Console.WriteLine();

            Console.WriteLine($"Today is {DateTime.Today}");
            Console.WriteLine($"Today is {DateTime.Now}");
            Console.WriteLine($"Weekday today is {DateTime.Now.DayOfWeek}");

            Console.WriteLine($"Tomorrow is {tomorrow}");

            Console.WriteLine($"The first weekday of the year is {GetFirstWeekdayOfYear(2024)}");

            int days = DateTime.DaysInMonth(2024, 2);
            Console.WriteLine($"Days in the month {days}");
        }

        static DateTime GetTomorrow()
        {
            return DateTime.Now.AddDays( 1 );
        }

        static DayOfWeek GetFirstWeekdayOfYear(int year)
        {
            DateTime temp = new DateTime(year, 1, 1);
            return temp.DayOfWeek;
        }

    }
}

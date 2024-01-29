namespace Enums
{
    internal class Program
    {
        enum Day { Monday, Tuesday, Wednesday, Thursday, Friday, Saterday, Sunday } 
        enum Month { January = 1, February, March, April, May, June, July = 12, August, Septemper, October, November, December }

        static void Main(string[] args)
        {
            Day fr = Day.Friday;
            Day su = Day.Sunday;
            Day a = Day.Friday;

            Console.WriteLine(fr == a);

            Console.WriteLine(Day.Monday);
            Console.WriteLine((int)Day.Monday);

            Console.WriteLine(Month.January);
            Console.WriteLine((int)Month.January);
            Console.WriteLine(Month.August);
            Console.WriteLine((int)Month.August);

        }
    }
}

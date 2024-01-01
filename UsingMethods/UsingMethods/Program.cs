using System.Runtime.CompilerServices;

namespace UsingMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string specific;
            int num1, num2;
            double num3, num4;

            specific = "This is an argument";
            num1 = 57;
            num2 = 5;
            num3 = 3892.34;
            num4 = 400.34;

            Console.WriteLine("This is in the main method");
            writeSomething();
            writeSometingSpecific(specific);

            Console.WriteLine($"This is the result of {num1} + {num2}: {add(num1, num2)}");
            Console.WriteLine(add(add(1,2), add(2,4)));

            Console.WriteLine($"This is the result of {num1} * {num2}: {multiply(num1, num2)}");

            Console.WriteLine($"This is the result of {num1} / {num2}: {divide(num1, num2)}");
            Console.WriteLine($"This is the result of {num3} / {num4}: {divide(num3, num4)}");
        }

        public static void writeSomething()
        {
            Console.WriteLine("I am called from the writeSomething() method");
        }

        public static void writeSometingSpecific(string something)
        {
            Console.WriteLine(something);
        }

        public static int add(int x, int y)
        {
            return x + y;
        }

        public static int multiply(int x, int y)
        {
            return x * y;
        }

        public static double divide(int x, int y)
        {
            return x / y;
        }

        public static double divide(double x, double y)
        {
            return x / y;
        }
    }
}

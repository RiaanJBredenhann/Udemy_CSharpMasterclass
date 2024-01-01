namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;
            bool isSunny = true;


            // unary operators
            num3 = -num1;
            Console.WriteLine($"num3 is {num3}");
            Console.WriteLine($"Is it suunny? {!isSunny}");

            // increment/decrement operators
            int num4 = 0;
            num4++;
            Console.WriteLine($"num4 was {--num4} and is now {++num4}");

            // relational and type operators
            bool isLower;
            isLower = num1 < num2;
            Console.WriteLine($"num1 < num2 is: {isLower}");

            //equality operator
            bool isEqual;
            isEqual = num1 == num2;
            Console.WriteLine($"num1 == num2 is: {isEqual}");
            isEqual = num1 != num2;
            Console.WriteLine($"num1 != num2 is: {isEqual}");

            // conditional operators
            bool isLowerAndSunny;
            isLowerAndSunny = isLower && isSunny;
            Console.WriteLine($"isLower && isSunny is: {isLowerAndSunny}");

            bool isLowerOrIsSunny;
            isLowerOrIsSunny = isLower || isSunny;
            Console.WriteLine($"isLower || isSunny is: {isLowerOrIsSunny}");
        }
    }
}

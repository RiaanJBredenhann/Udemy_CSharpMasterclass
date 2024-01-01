namespace UsingDatatypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2 = 7;
            int sum;
            int num3, num4, num5;

            num1 = 13;
            num2 = 100;

            sum = num1 + num2;
            Console.WriteLine("num1 is " + num1 + " and num2 is " + num2 + " and the sum of these numbers is " + sum);

            double d1 = 3.1415;
            double d2 = 5.1;
            double dDiv;

            dDiv = d1 / d2;
            Console.WriteLine(d1 + " divided by " + d2 + " is " + dDiv);

            float f1 = 3.1415f;
            float f2 = 5.1f;
            float fDiv;

            fDiv = f1 / f2;
            Console.WriteLine(f1 + " divided by " + f2 + " is " + fDiv);

            long l1 = 3164926103772070706;
            Console.WriteLine(l1);

            double dIDivDouble = d1 / num1;
            //int dIDivInt = d1 / num1;
            Console.WriteLine("d1 / num1 is " + dIDivDouble);
            //Console.WriteLine("d1 / num1 is " + dIDivInt);

            string myName = "Riaan";
            string message = "My name is " + myName;
            Console.WriteLine(message);
            Console.WriteLine(message.ToUpper());
            Console.WriteLine(message.ToLower());

            Console.WriteLine("Please press a key");
            Console.ReadKey();

            Console.Write("Please enter a string and press enter: ");
            string userInput = Console.ReadLine();
            Console.WriteLine("The string you have entered is: {0}", userInput);

            Console.Write("Please enter a string and press enter:");
            int asciiVal = Console.Read();
            Console.WriteLine("ASCII value is: {0}", asciiVal);
            Console.ReadKey();

        }
    }
}

namespace Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double myDouble = 13.37;
            int myInt;

            // explicit conversion
            myInt = (int) myDouble;
            Console.WriteLine(myInt);

            // implicit conversion
            myInt = 10;
            myDouble = myInt;
            Console.WriteLine(myDouble);

            // type conversion
            string myString = myDouble.ToString();
            Console.WriteLine(myString);

            bool sunIsShining = true;
            string myBoolString = sunIsShining.ToString();
            Console.WriteLine(myBoolString);
        }
    }
}

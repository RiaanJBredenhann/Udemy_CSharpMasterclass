namespace Parsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = "15";
            string mySecondString = "10";
            string result = myString + mySecondString;

            Console.WriteLine(result);

            int num1 = Int32.Parse(myString);
            int num2 = Int32.Parse(mySecondString);
            int  intResult = num1 + num2;

            Console.WriteLine(intResult);
        }
    }
}

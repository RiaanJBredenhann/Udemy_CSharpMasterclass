namespace ParsingAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringForFloat = "0.85"; // datatype should be float
            string stringForInt = "12345"; // datatype should be int

            float floatParse = float.Parse(stringForFloat);
            int intParse = Int32.Parse(stringForInt);

            Console.Write("String to float: " + floatParse);
            Console.Write("String to int: " + intParse);
        }
    }
}

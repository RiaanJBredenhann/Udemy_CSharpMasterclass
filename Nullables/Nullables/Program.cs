namespace NullablesE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 1337;

            double? num3 = new Double?();
            double? num4 = 3.14157;

            bool? boolval = new bool?();

            Console.WriteLine($"Our nullable numbers are: \n{num1}\n{num2}\n{num3}\n{num4}\n{boolval}");

            bool? isMale = null;

            if (isMale == true)            
                Console.WriteLine("User is male");            
            else if (isMale == false)            
                Console.WriteLine("User is femal");            
            else            
                Console.WriteLine("No gender specified");

            double? num6 = 13.1;
            double? num7 = null;
            double num8;

            if (num6 == null)
                num8 = 0.0;
            else 
                num8 = (double) num6;

            Console.WriteLine($"value of num8 is {num8}");

            num8 = num6 ?? 8.53;
            Console.WriteLine($"Value of num8 is {num8}");
            num8 = num7 ?? 8.53;
            Console.WriteLine($"Value of num8 is {num8}");
        }
    }
}

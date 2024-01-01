namespace MethodsWithUserInput
{
    internal class Program
    {
        public static void Calculate()
        {
            Console.Write("Enter first value: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second value: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"The sum of {num1} and {num2} is {num1 + num2}");
        }

        static void Main(string[] args)
        {
            Calculate();   
        }
    }
}

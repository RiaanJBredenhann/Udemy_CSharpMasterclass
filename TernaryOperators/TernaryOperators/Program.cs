namespace TernaryOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the temperature of the water?: ");
            int temp = int.Parse(Console.ReadLine());
            string stateOfMatter;

            stateOfMatter = temp < 0 ? "solid" : 
                stateOfMatter = temp < 100 ? "liquid" : "gas";
            Console.WriteLine($"State of matter is {stateOfMatter}");
        }
    }
}

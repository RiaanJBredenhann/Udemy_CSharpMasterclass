namespace Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the temperature today?: ");
            string temperature = Console.ReadLine();
            int temp;

            if (int.TryParse(temperature, out temp))
            {
                if (temp < 20)
                {
                    Console.WriteLine("Take the coat");
                }
                else if (temp == 20)
                {
                    Console.WriteLine("Maybe take a sweater just in case");
                }
                else
                {
                    Console.WriteLine("Shorts and shirt should be fine");
                }
            } else
            {
                Console.WriteLine("Please enter am integer value");
            }

            
        }
    }
}

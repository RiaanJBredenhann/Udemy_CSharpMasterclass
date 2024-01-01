namespace BreakAndContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                if (i == 3)
                {
                    Console.WriteLine("At 3 we stop!");
                    break;
                }
            }

            for (int i = 1; i <= 10; i++)
            {
                if (i == 3)
                {
                    Console.WriteLine("We skip number 3");
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}

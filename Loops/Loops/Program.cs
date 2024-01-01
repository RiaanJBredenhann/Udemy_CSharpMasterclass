namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("");

            i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 10);
            Console.WriteLine("");

            i = 0;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}

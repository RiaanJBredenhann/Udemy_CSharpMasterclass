namespace Delagates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Aiden", "John", "Sarah", "Nina", "Alex", "Lisa", "Dylan" };

            Console.WriteLine("Before remove:\n");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            names.RemoveAll(Filter);

            Console.WriteLine("After remove:\n");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

        }

        static bool Filter(string s)
        {
            return s.Contains("i");
        }
    }
}

namespace StringMAnipulationAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;

            Console.Write("Please enter a string: ");
            s = Console.ReadLine();
            Console.Write("Please enter a letter to search for: ");

            Console.WriteLine(s.ToUpper());
            Console.WriteLine(s.ToLower());
            Console.WriteLine(s.Trim());
            Console.WriteLine(s.Substring(2));

        }
    }
}

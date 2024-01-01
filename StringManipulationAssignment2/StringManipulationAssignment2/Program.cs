namespace StringManipulationAssignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;
            char letter;
            string firstName;
            string lastName;

            Console.Write("Please enter a string: ");
            s = Console.ReadLine();
            Console.Write("Please enter a letter to search for: ");
            letter = Console.ReadLine()[0];

            Console.WriteLine($"The index of the first ocurrence of {letter} is {s.IndexOf(letter)}");

            Console.Write("Please enter your first name: ");
            firstName = Console.ReadLine();
            Console.Write("Please enter your last name: ");
            lastName = Console.ReadLine();

            Console.WriteLine($"Your full name is {string.Concat(firstName, " ", lastName)}");

        }
    }
}

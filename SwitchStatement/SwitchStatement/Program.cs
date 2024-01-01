namespace SwitchStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.Write("How old are you?: ");
            string s = Console.ReadLine();
            int age = int.Parse(s);

            switch(name)
            {
                case "Riaan":
                    Console.WriteLine($"Hello, {name}");
                    break;
                case "John":
                    Console.WriteLine($"Hello, {name}");
                    break;
                case "Sam":
                    Console.WriteLine($"Hello, {name}");
                    break;
            }

            switch(age)
            {
                case 16:
                case 17:
                    Console.WriteLine("You are too young to buy alcohol");
                    break;
                case 18:
                case 19:
                case 20:
                    Console.WriteLine("You are old enough to buy alcohol but too young to go to a club");
                    break;
                case 21:
                case 22:
                case 23:
                    Console.WriteLine("You are old enough to buy alcohol and to go to a club");
                    break;
                default:
                    Console.WriteLine("Your age is outside of  the range");
                    break;
            }
        }
    }
}

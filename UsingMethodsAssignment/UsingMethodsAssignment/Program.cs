namespace UsingMethodsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string friend1 = "Polla";
            string friend2 = "Loeka";
            string friend3 = "Migaal";

            greetFriend(friend1);
            greetFriend(friend2);
            greetFriend(friend3);
        }

        public static void greetFriend(string name)
        {
            Console.WriteLine($"Hi {name}, my friend");
        }
    }
}

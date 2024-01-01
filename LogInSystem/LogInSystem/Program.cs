namespace LogInSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRegisteredUser = false;
            bool isLoggedIn = false;
            string userName = "";
            string password = "";
            string tempName;
            string tempPass;

            if (!isRegisteredUser)
            {
                Console.WriteLine("Please create an account");
                Console.Write("Name: ");
                userName = Console.ReadLine();
                Console.Write("Password:");
                password = Console.ReadLine();

                isRegisteredUser = true;
            }

            if (!isLoggedIn)
            {
                Console.WriteLine("Log In");
                Console.Write("Name:");
                tempName = Console.ReadLine();
                Console.Write("Password:");
                tempPass = Console.ReadLine();

                if (tempName != userName)
                {
                    Console.WriteLine("User does not exist");
                }

                if (tempPass != password)
                {
                    Console.WriteLine("Password is incorrect");
                }

                if (tempName == userName && tempPass == password) 
                {
                    Console.WriteLine("User logged in successfully");
                    Console.WriteLine($"Hello {userName}");
                    isLoggedIn = true;
                }

            }
        }
    }
}

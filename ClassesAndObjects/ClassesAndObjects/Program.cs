namespace ClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            
            myCar.Name = "";
            myCar.MaxSpeed = 100;
            Console.WriteLine(myCar.Name);
            Console.WriteLine(myCar.MaxSpeed);
            myCar.Drive();
            myCar.GetDetails();

            myCar.setName("namechange");
            myCar.GetDetails();
            Console.WriteLine(myCar.getName());

            Console.WriteLine("Press 1 to stop the car");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                myCar.Stop();
            } 
            else
            {
                Console.WriteLine("You broke the brakes!");
            }
        }
    }
}

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Audi(200, "Blue", "A4"),
                new BMW(250, "Red", "A3"),
                new M3(300, "Yellow", "M3")
            };

            foreach (Car car in cars)
            {
                car.Repair();
                car.ShowDetails();
                Console.WriteLine();
            }

            foreach (Car car in cars)
            {
                car.SetCarIDInfo(1, "Riaan");
            }

            foreach (Car car in cars)
            {
                car.GetCarIDInfo();
            }

        }
    }
}

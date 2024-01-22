namespace InheritanceAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee baseObj = new Employee();

            Employee employee = new Employee("John Doe", "John", 12000);
            Boss boss = new Boss("Alex Smith", "Alex", 30000, "Audi A4");
            Trainee trainee = new Trainee("Jane Frost", "Jane", 6000, 4, 4);

            boss.Lead();
            trainee.Work();

            baseObj.Work();
        }
    }
}

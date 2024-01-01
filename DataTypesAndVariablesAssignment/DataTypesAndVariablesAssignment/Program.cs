namespace DataTypesAndVariablesAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            float f = 4.5f;
            double d = 20.5;
            bool b = true;
            string s1 = "I control text";
            string s2 = "20";

            int stringToInt = int.Parse(s2);

            Console.WriteLine($"{i} {f} {d} {b} {s1} {s2} {stringToInt}");

        }
    }
}

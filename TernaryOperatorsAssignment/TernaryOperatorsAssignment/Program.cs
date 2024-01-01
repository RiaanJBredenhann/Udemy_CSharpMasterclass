namespace TernaryOperatorsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInputTemp;
            int validInputTemp;
            string output = "";

            Console.Write("What is the temperature outside?: ");
            userInputTemp = Console.ReadLine();

            if (int.TryParse(userInputTemp, out validInputTemp))
            {
                output = validInputTemp <= 15 ? "It is too cold out here" :
                    validInputTemp <= 18 ? "it is okay" : "It is hot here";
            }

            Console.WriteLine(output);
        }
    }
}

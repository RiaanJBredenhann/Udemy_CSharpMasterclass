namespace ParsingAssessment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(
                @"C:\Users\Riaan HP\Documents\Udemy\C# Masterclass\ParsingAssessment\Assets\input.txt");

            foreach (string line in lines)
            {
                if (line.Contains("split"))
                    line.Split();
            }
            System.IO.File.WriteAllText(
                @"C:\Users\Riaan HP\Documents\Udemy\C# Masterclass\ParsingAssessment\Assets\output.txt", lines[4]);
        }
    }
}

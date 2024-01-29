namespace RegexAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\Riaan HP\Documents\Udemy\C# Masterclass\RegexAssignment\Assets\input2.txt");

            foreach (string line in lines)
            {
                if (line.Contains("split"))
                {
                    string[] words = line.Split();

                    Console.Write(words[4] + " ");
                }
            }

            string text = File.ReadAllText(@"C:\Users\Riaan HP\Documents\Udemy\C# Masterclass\RegexAssignment\Assets\input2.txt");
            string pattern = @"\d{2,3}";

            Regex regex = new Regex(pattern);
            MatchCollection matchCollection = regex.Matches(text);
            List<char> results = new List<char>();

            foreach (Match hit in matchCollection)
            {
                int temp = int.Parse(hit.Value);
                char temp2 = (char)temp;
                results.Add(temp2);
            }

            foreach (char c in results)
            {
                Console.Write(c);
            }

        }

    }
}

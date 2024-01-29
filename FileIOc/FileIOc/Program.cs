namespace FileIOc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\\Users\\Riaan HP\\Documents\\Udemy\\C# Masterclass\\FileIOc\\Assets\\MyTextFile.txt");
            Console.WriteLine("Text file contains:");
            Console.WriteLine(text);

            string[] lines = System.IO.File.ReadAllLines(@"C:\\Users\\Riaan HP\\Documents\\Udemy\\C# Masterclass\\FileIOc\\Assets\\MyTextFile.txt");
            Console.WriteLine("\nText file contains");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            string[] lines2 = { "this is one line", "this is another line", "this is the last line" };

            System.IO.File.WriteAllLines(@"C:\Users\Riaan HP\Documents\Udemy\C# Masterclass\FileIOc\Assets\writeFile.txt", lines2);

            foreach (string line in lines2)
            {
                Console.WriteLine(line);
            }

        }
    }
}

namespace SpecialCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "this is a string with a slash / and a colon :";
            string s2 = "this is a \"string\" with a backslash \\ and a colon :";
            string s3 = "this is a \"string\" with a backslash \\ and a colon : and a \n line break";
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
        }
    }
}

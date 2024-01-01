namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5];
            int[] grades2 = { 1, 2, 3, 4, 5 };
            int[] grades3 = new int[] { 1, 2, 3, 4, 5 };
            string[] friends = new string[5];

            for (int i = 0; i < grades.Length; i++)
            {
                grades[i] = i+1;
                Console.WriteLine($"index {i} is {grades[i]}");
            }

            foreach (int grade in grades)
            {
                Console.WriteLine(grade);
            }

            for (int i = 0; i < friends.Length; i++)
            {
                Console.Write("Name: ");
                friends[i] = Console.ReadLine();
            }

            foreach(string friend in friends)
            {
                Console.WriteLine($"Hello there, {friend}");
            }
        }
    }
}

namespace LoopsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentScore;
            float total = 0f;
            int numStudents = 0;

            do
            {
                Console.Write("Enter a score from 0 to 20: ");
                studentScore = int.Parse(Console.ReadLine());

                if ((studentScore < -1 || studentScore > 20))
                {
                    Console.WriteLine("Please enter a valid score from 0 to 20!");
                } else if (studentScore != -1)
                {
                    total += studentScore;
                    numStudents++;
                }
            } while (studentScore != -1);

            Console.WriteLine($"The class average is {total/numStudents}");
            Console.WriteLine($"This class has {numStudents} students");
        }
    }
}

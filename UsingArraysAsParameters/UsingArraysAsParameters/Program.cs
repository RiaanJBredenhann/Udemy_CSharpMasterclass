namespace UsingArraysAsParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] studentsGrdes = new int[] { 12, 14, 23, 5, 12, 27, 34, 12, 34, 67, 28, 2 };
            Console.WriteLine(GetAverage(studentsGrdes));
            Console.WriteLine();


            int[] happiness = new int[] { 1, 2, 3, 4, 5 };

            foreach (int i in happiness) 
            {
                Console.WriteLine(i);
            }

            SunIsShining(happiness);
            Console.WriteLine();

            foreach (int i in happiness)
            {
                Console.WriteLine(i);
            }
        }

        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }

            return average = (double)sum / size;
        }

        public static void SunIsShining(int[] happy)
        {
            for (int i = 0; i < happy.Length; i++)
            {
                happy[i] += 2;
            }
        }
    }
}

namespace JaggedArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 2, 3, 5, 7, 11 };
            jaggedArray[1] = new int[] { 1, 2, 3 };
            jaggedArray[2] = new int[] { 13, 21 };

            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 1, 2, 3, 4, 5 },
                new int[] { 21, 43, 10 }
            };


            int row;
            int col;
            string name;

            string[][] friends = new string[][]
            {
                new string[] {"John", "Jane", "Joe"},
                new string[] {"Peter", "Patrick"},
                new string[] {"Elaine", "Ellen", "Elvis", "Edward"},
            };

            Console.WriteLine("Here we have three friends arrays\n");
            
            for (int i = 0; i < friends.Length; i++)
            {
                for (int j = 0; j < friends[i].Length; j++)
                {
                    Console.Write(friends[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nWhere do you want your family member to be stored?");
            Console.Write("Row: ");
            row = int.Parse(Console.ReadLine());
            Console.Write("Column: ");
            col = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            name = Console.ReadLine();

            friends[row][col] = name;

            Console.WriteLine();

            for (int i = 0; i < friends.Length; i++)
            {
                for (int j = 0; j < friends[i].Length; j++)
                {
                    Console.Write(friends[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

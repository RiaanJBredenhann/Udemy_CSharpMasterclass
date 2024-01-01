namespace _2DArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare a 2d array
            string[,] matrix;
            // declare a 3d array
            string[,,] threeD;

            int[,] array2D = new int[,] 
            {
                {1,2,3},
                {4,5,6},
                {7,7,9}
            };

            Console.Write("X: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Y: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine(array2D[x,y]);

            string[,,] array3D = new string[,,]
            {
                {
                    {"000","001"},
                    {"010","011"}
                },
                {
                    {"100","101"},
                    {"110","111"}
                }
            };

            int dimensions = array2D.Rank;
            Console.WriteLine(dimensions);
        }
    }
}

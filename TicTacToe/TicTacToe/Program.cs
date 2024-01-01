namespace TicTacToe
{
    internal class Program
    {
        public static void SetField()
        {
            Console.WriteLine( "|     |     |     |");
            Console.WriteLine($"|  {1}  |  {2}  |  {3}  |");
            Console.WriteLine( "|_____|_____|_____|");
            Console.WriteLine( "|     |     |     |");
            Console.WriteLine($"|  {4}  |  {5}  |  {6}  |");
            Console.WriteLine( "|_____|_____|_____|");
            Console.WriteLine( "|     |     |     |");
            Console.WriteLine($"|  {7}  |  {8}  |  {9}  |");
            Console.WriteLine( "|_____|_____|_____|");
        }
        static void Main(string[] args)
        {
            bool gameIsRunning = true;


            while (gameIsRunning)
            {
                SetField();

                gameIsRunning = false;
            }
        
        }
    }
}

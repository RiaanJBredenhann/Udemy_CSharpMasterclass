namespace HighScore
{
    internal class Program
    {
        static int score;
        static int highscore = 100;
        static string highscorePlayer = "Harry";
        public static void CheckHighScore(int highscore, string player)
        {
            string currentPlayer;

            Console.Write("Player Name: ");
            currentPlayer = Console.ReadLine();
            Console.Write("Player Score: ");
            score = int.Parse(Console.ReadLine());

            if (score > highscore)
            {
                Console.WriteLine($"New highscore is {score}");
                Console.WriteLine($"New highscore holder is {currentPlayer}");
            } else
            {
                Console.WriteLine($"The current highscore of {highscore} could not be broken " +
                                  $"and is still held by {player}");
            }
        }
        static void Main(string[] args)
        {
            CheckHighScore(highscore, highscorePlayer);
        }
    }
}

using System.Reflection.Metadata.Ecma335;

namespace TicTacToe
{
    internal class Program
    {
        static char[,] playField =
        {
            {'1', '2', '3'},
            {'4', '5', '6'},
            {'7', '8', '9'}
        };
        static void Main(string[] args)
        {
            Player player1 = new Player("Player 1", true, 'X');
            Player player2 = new Player("Player 2", false, 'O');
            Player activePlayer;

            int input;
            bool inputIsCorrect;
            bool gameIsRunning = true;
            int numRounds = 0;

            while (gameIsRunning)
            {
                SetField();
                numRounds++;

                if (player1.IsActive)
                    activePlayer = player1;
                else 
                    activePlayer = player2;

                Console.Write($"{activePlayer.Name}'s Turn. Select an open square: ");

                // check if player input is correct
                // will loop until player enters a valid input or a square that is open
                inputIsCorrect = false;
                while (!inputIsCorrect)
                {
                    input = Console.Read();
                    for (int i = 0; i < playField.GetLength(0); i++)
                    {
                        if (inputIsCorrect)
                        {
                            break;
                        }
                        for (int j = 0; j < playField.GetLength(1); j++)
                        {
                            if (playField[i, j] == input)
                            {
                                playField[i, j] = activePlayer.PlayerCharacter;
                                inputIsCorrect = true;
                                break;
                            }
                        }
                    }

                    if (!inputIsCorrect)
                    {
                        Console.Write("Incorrect Input. Try Again: ");
                    }
                } // end of while (!inputIsCorrect)

                if (numRounds >= 5)
                {
                    if (CheckWinner())
                    {
                        gameIsRunning = false;
                    }
                }

                if (player1.IsActive)
                {
                    player1.IsActive = false;
                    player2.IsActive = true;
                }
                else
                {
                    player1.IsActive = true;
                    player2.IsActive = false;
                }
                    
            } // end of while (gameIsRunning)

            Console.WriteLine($"{activePlayer.Name} is the winner");

        }

        // method that displays the board with the corresponding player moves from an array
        public static void SetField()
        {
            Console.WriteLine($"");
            Console.WriteLine($"      _____ _____ _____");
            Console.WriteLine($"     |     |     |     |");
            Console.WriteLine($"     |  {playField[0, 0]}  |  {playField[0, 1]}  |  {playField[0, 2]}  |");
            Console.WriteLine($"     |_____|_____|_____|");
            Console.WriteLine($"     |     |     |     |");
            Console.WriteLine($"     |  {playField[1, 0]}  |  {playField[1, 1]}  |  {playField[1, 2]}  |");
            Console.WriteLine($"     |_____|_____|_____|");
            Console.WriteLine($"     |     |     |     |");
            Console.WriteLine($"     |  {playField[2, 0]}  |  {playField[2, 1]}  |  {playField[2, 2]}  |");
            Console.WriteLine($"     |_____|_____|_____|");
            Console.WriteLine($"");
        }

        public static bool CheckWinner()
        {
            // rows
            if (playField[0, 0] == playField[0, 1] && playField[0, 1] == playField[0, 2])
                return true;
            else if (playField[1, 0] == playField[1, 1] && playField[1, 1] == playField[1, 2])
                return true;
            else if (playField[2, 0] == playField[2, 1] && playField[2, 1] == playField[2, 2])
                return true;
            // columns
            else if (playField[0, 0] == playField[1, 0] && playField[1, 0] == playField[2, 0])
                return true;
            else if (playField[0, 1] == playField[1, 1] && playField[1, 1] == playField[2, 1])
                return true;
            else if (playField[0, 2] == playField[1, 2] && playField[1, 2] == playField[2, 2])
                return true;
            // diagonals
            else if (playField[0, 0] == playField[1, 1] && playField[1, 1] == playField[2, 2])
                return true;
            else if (playField[0, 2] == playField[1, 1] && playField[1, 1] == playField[2, 0])
                return true;
        }
        
    }
}

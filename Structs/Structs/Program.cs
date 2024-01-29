namespace Structs
{
    internal class Program
    {
        struct Game
        {
            public string name;
            public string developer;
            public double rating;
            public string releaseDate;

            public Game(string name, string developer, double rating, string releaseDate)
            {
                this.name = name;
                this.developer = developer;
                this.rating = rating;
                this.releaseDate = releaseDate;
            }

            public void Display()
            {
                Console.WriteLine($"game name is {name}");
                Console.WriteLine($"game was developed by {developer}");
                Console.WriteLine($"game has a rating of {rating}");
                Console.WriteLine($"game was released on {releaseDate}");
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Game game1;
            Game game2;
            Game game3 = new Game("Stellaris", "Paradox Interactive", 4, "09.05.2016");

            game1.name = "Pokemon GO";
            game1.developer = "Niantic";
            game1.rating = 3.5;
            game1.releaseDate = "01.07.2016";

            game2.name = "Baldur's Gate 3";
            game2.developer = "Larian Studios";
            game2.rating = 5;
            game2.releaseDate = "03.08.2023";

            game1.Display();
            game2.Display();
            game3.Display();


        }

    }
}

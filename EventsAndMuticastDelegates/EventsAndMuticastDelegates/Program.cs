namespace EventsAndMuticastDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AudioSystem audioSystem = new AudioSystem();
            RenderingEngine renderingEngine = new RenderingEngine();
            
            Player player1 = new Player("Steelcow");
            Player player2 = new Player("DoggoSilva");

            GameEventManager.TriggerGameStart();

            Console.WriteLine("Game is running... Press any key to end the game");
            Console.Read();

            GameEventManager.TriggerGameOver();

        }
    }
}

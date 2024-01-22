namespace InheritenceDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the birthday wishes", true, "Riaan Bredenhann");
            Console.WriteLine(post1.ToString());

            Post post2 = new Post();
            Console.WriteLine(post2.ToString());

            ImagePost imagePost1 = new ImagePost("Check out my new shoes", true, "Riaan Bredenhann", "https://images.com/shoes");
            Console.WriteLine(imagePost1.ToString());

            VideoPost videoPost1 = new VideoPost("This is a fail video", true, "Riaan Bredenhann", "https://video.com/failvideo", 10);
            Console.WriteLine(videoPost1.ToString());

            videoPost1.Play();
            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
            videoPost1.Stop();
        }
    }
}

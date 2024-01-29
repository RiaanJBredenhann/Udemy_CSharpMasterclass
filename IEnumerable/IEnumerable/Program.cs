namespace IEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> unknownCollection;

            unknownCollection = GetCollection(1);
            foreach (int val in unknownCollection)
            {
                Console.WriteLine(val);
            }
            Console.WriteLine();

            unknownCollection = GetCollection(2);
            foreach (int val in unknownCollection)
            {
                Console.WriteLine(val);
            }
            Console.WriteLine();

            unknownCollection = GetCollection(3);
            foreach (int val in unknownCollection)
            {
                Console.WriteLine(val);
            }
            Console.WriteLine();

        }

        static IEnumerable<int> GetCollection(int option)
        {
            List<int> numbersList = new List<int>() { 1,2, 3, 4, 5 };

            Queue<int> numbersQueue = new Queue<int>();
            numbersQueue.Enqueue(6);
            numbersQueue.Enqueue(7);
            numbersQueue.Enqueue(8);
            numbersQueue.Enqueue(9);
            numbersQueue.Enqueue(10);

            if (option == 1)
            {
                return numbersList;
            }
            else if (option == 2)
            {
                return numbersQueue;
            }
            else
            {
                return new int[] { 11, 12, 13, 14, 15 };
            }

        }
    }
}

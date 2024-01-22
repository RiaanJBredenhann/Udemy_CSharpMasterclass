namespace StacksAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            Console.WriteLine(stack.Peek());
            stack.Pop();
            Console.WriteLine(stack.Peek());
            stack.Pop();
            Console.WriteLine(stack.Peek());
            Console.WriteLine();

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            Console.WriteLine(queue.Peek());
            queue.Dequeue();
            queue.Enqueue(2);
            Console.WriteLine(queue.Peek());
            queue.Dequeue();
            queue.Enqueue(3);
            Console.WriteLine(queue.Peek());
        }
    }
}

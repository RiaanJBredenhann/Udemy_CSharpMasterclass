using System.Collections;

namespace ArrayLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList myArrayList = new ArrayList();
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add('C');
            myArrayList.Add(12382.323f);
            myArrayList.Add(42789);

            foreach (object obj in myArrayList)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();

            myArrayList.Remove(25);

            foreach (object obj in myArrayList)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();

            myArrayList.RemoveAt(3);

            foreach (object obj in myArrayList)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
    }
}

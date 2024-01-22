namespace ParamsKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParamsMethod("This", "is", "a", "long", "string", "I", "don't", "know", "when", "it", "is", "going", "to", "end");
            Console.WriteLine(GetMinimumValue(23, 43533, 2313, 57, 795, 2426, 6854, 2436768, 24, 
                                              4775, 9765, 342, 24, 645, 45, 56, 3, 66, 4, 8, 344));
        }

        public static void ParamsMethod(params string[] sentence)
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                Console.Write(sentence[i] + " ");
            }
        }

        public static void ParamsMethod2(params object[] stuff)
        {
            foreach (object obj in stuff)
            {
                Console.Write(obj + " ");
            }
        }

        public static int GetMinimumValue(params int[] nums)
        {
            int min = int.MaxValue;

            foreach (int number in nums)
            {
                if (number < min)
                {
                    min = number;
                }
            }
            return min;
        }
    }
}

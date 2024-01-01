namespace TryCatchFinally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            string stringInput = Console.ReadLine();

            int num1 = 5;
            int num2 = 0;
            int result;

            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("DivideByZero Exception. You can't ivide by 0");
            }
            catch (Exception)
            {
                Console.WriteLine("General Exception.");
            }

            try
            {
                int intInput = int.Parse(stringInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format Exception. Please enter the correct type next time");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow Exception. Value too long to parse into an int");
            }
            catch (Exception)
            {
                Console.WriteLine("Genral Exception.");
            }
            finally
            {
                Console.WriteLine("This is called anyways");
            }         

        }
    }
}

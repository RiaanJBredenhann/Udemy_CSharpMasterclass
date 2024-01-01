namespace StringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 22;
            string name = "Riaan";
            char grade = 'B';
            bool passed = true;

            // string concatenation
            Console.WriteLine("String Concatenation");
            Console.WriteLine("Hello, my name is " + name + " and I am " + age + " years old.");

            // string formatting
            Console.WriteLine("String Formatting");
            Console.WriteLine("Hello, my name is {0} and I am {1} years old.", name, age);
            Console.WriteLine("Hello, my name is {0} and I am {1} years old. " +
                              "I received a {2} for my History exam. Did I pass?: {3}", name, age, grade, passed);

            // string interpolation
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hello, my name is {name} and I am {age} years old.");

            // verbatim strings
            Console.WriteLine("Verbatim String");
            Console.WriteLine(@"This is a verbatim string. Everything in this string will be displayed in the output 
                                in exactly the same way it is read.




                                here is some space




                                even more space");

            Console.WriteLine("Verbatim Strings work really well for file paths since" +
                              " backslashes indicate special characters");
            Console.WriteLine(@"C:\Users\RiaanHP\Desktop\Project\HelloWorld.sln");
            Console.WriteLine(@"the \n has no effect");
        }
    }
}

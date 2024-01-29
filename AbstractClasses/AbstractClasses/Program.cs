namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Sphere(4), new Cube(3) };

            foreach (Shape shape in shapes)
            {
                shape.GetInfo();
                Console.WriteLine($"The volume of {shape.Name} is {shape.CalculateVolume()}");

                Cube iceCube = shape as Cube;
                if (iceCube == null)
                    Console.WriteLine("\n1. This shape is a cube");
                else
                    Console.WriteLine("\n1. This shape is not a cube");

                if (shape is Cube)
                    Console.WriteLine("\n2. This shape is a cube");
                else
                    Console.WriteLine("\n2. This shape is not a cube");

                object cube1 = new Cube(8);
                Cube cube2 = (Cube)cube1;

                Console.WriteLine($"\n{cube2.Name} has a volume of {cube2.CalculateVolume()}");

            }
        }
    }
}

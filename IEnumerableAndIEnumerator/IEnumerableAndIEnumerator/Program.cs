using System.Collections;

namespace IEnumerableAndIEnumerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DogShelter shelter = new DogShelter();

            foreach (Dog dog in shelter)
            {
                if (!dog.IsNaughty)
                    dog.GiveTreat(2);
                else
                    Console.WriteLine($"{dog.Name} is naughty and won't get any treats");
            }
        }
    }

    class Dog
    {
        public string Name { get; set; }
        public bool IsNaughty { get; set; }

        public Dog(string name, bool isNaughty)
        {
            this.Name = name;
            this.IsNaughty = isNaughty;
        }

        public void GiveTreat(int numTreats)
        {
            Console.WriteLine($"{this.Name} sad woof {numTreats} times");
        }
    }

    class DogShelter : IEnumerable<Dog>
    {
        public List<Dog> dogs;

        public DogShelter()
        {
            dogs = new List<Dog>()
            {
                new Dog("Snow", true),
                new Dog("Penny", false),
                new Dog("Duke", true),
                new Dog("Muffin", true),
                new Dog("Charles", false)
            };
        }

        IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
        {
            return dogs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

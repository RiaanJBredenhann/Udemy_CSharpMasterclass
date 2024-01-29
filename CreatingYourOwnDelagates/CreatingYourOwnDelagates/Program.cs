using System.Diagnostics;

namespace CreatingYourOwnDelagates
{
    internal class Program
    {
        public delegate bool FilterDelegate(Person p);

        static void Main(string[] args)
        {
            Person p1 = new Person() { Name = "Aiden", Age = 41 };
            Person p2 = new Person() { Name = "Sif", Age = 69 };
            Person p3 = new Person() { Name = "Walter", Age = 12 };
            Person p4 = new Person() { Name = "Anatoli", Age = 25 };

            List<Person> people = new List<Person>() { p1, p2, p3, p4 };

            DisplayPeople("Kids", people, IsMinor);
            DisplayPeople("Adults", people, IsAdult);
            DisplayPeople("Elders", people, IsElder);

            FilterDelegate filter = delegate (Person p)
            {
                return p.Age >= 20 && p.Age <= 30;
            };

            DisplayPeople("Young Adults", people, filter);

            DisplayPeople("All", people, delegate (Person p) { return true; });

            string searcKeyword = "A";

            DisplayPeople($"Age > 20 with search keyword {searcKeyword}", people, (p) =>
            {
                if (p.Name.Contains(searcKeyword) && p.Age > 20)
                    return true;
                else
                    return false;
            });

            DisplayPeople($"Exactly 25", people, p => p.Age == 25);


        }

        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            Console.WriteLine(title);

            foreach (Person person in people)
            {
                if (filter(person))
                    Console.WriteLine($"{person.Name} is {person.Age} years old");
            }
            Console.WriteLine();
        }

        static bool IsMinor(Person p)
        {
            return p.Age < 18;
        }

        static bool IsAdult(Person p)
        {
            return p.Age > 18;
        }

        static bool IsElder(Person p)
        {
            return p.Age > 65;
        }

    }
}

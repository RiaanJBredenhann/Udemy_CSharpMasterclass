using System.Collections;

namespace Hashtables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();

            Student student1 = new Student(1, "John", 3.45f);
            Student student2 = new Student(2, "Edward", 3.87f);
            Student student3 = new Student(3, "Jane", 2.89f);
            Student student4 = new Student(4, "Sam", 3.12f);

            studentsTable.Add(student1.ID, student1);
            studentsTable.Add(student2.ID, student2);
            studentsTable.Add(student3.ID, student3);
            studentsTable.Add(student4.ID, student4);

            Student storedStudent1 = (Student)studentsTable[student1.ID];

            Console.WriteLine($"{storedStudent1.ID} {storedStudent1.Name} {storedStudent1.GPA}");
            Console.WriteLine();


            foreach (DictionaryEntry entry in studentsTable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine($"{temp.ID} {temp.Name} {temp.GPA}");
            }
            Console.WriteLine();

            foreach (Student stud in studentsTable.Values)
            {
                Console.WriteLine($"{stud.ID} {stud.Name} {stud.GPA}");
            }
        }
    }

    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }

        public Student(int id, string name, float gpa) 
        {
            this.ID = id;
            this.Name = name; 
            this.GPA = gpa;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    internal class Employee
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int salary { get; set; }

        public Employee()
        {
            this.Name = "Name";
            this.FirstName = "FirstName";
            this.salary = 0;
        }

        public Employee(string name, string firstName, int salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.salary = salary;
        }

        public virtual void Work()
        {
            Console.WriteLine("I work at least 8 hours every day");
        }

        public void Pause()
        {

        }
    }
}

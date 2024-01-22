using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    internal class Trainee : Employee
    {
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set;}

        public Trainee() { }

        public Trainee (string name, string firstName, int salary, int workingHours, int schoolHours) : base (name, firstName, salary)
        {
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }

        public void Learn()
        {
            Console.WriteLine("I am learning while I work");
        }

        public override void Work()
        {
            Console.WriteLine($"I work {this.WorkingHours} hours a day");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    internal class Boss : Employee
    {
        protected string _companyCar;

        public Boss() { }

        public Boss(string name, string firstName, int salary, string companyCar) : base (name, firstName, salary)
        {
            this._companyCar = companyCar;
        }

        public void Lead()
        {
            Console.WriteLine("I like to lead my employees to finish each project");
        }
    }
}

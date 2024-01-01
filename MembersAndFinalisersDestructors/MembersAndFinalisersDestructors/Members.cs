using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembersAndFinalisersDestructors
{
    class Members
    {
        // member private field
        private string _memberName;
        private string _jobTitle;
        private int _salary;

        // member public fields
        public int salary;

        // member property
        public string JobTitle 
        { 
            get
            {
                return _jobTitle;
            }
            set
            {
                _jobTitle = value;
            }  
        }

        // public member methods
        public void Introducing(bool friend)
        {
            if (friend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine($"Hi, my name is {_memberName}. I am a {_jobTitle} and I am 28 years old");
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine($"My salary is {_salary}");
        }

        // member constructor
        public Members()
        {
            Console.WriteLine("Member created");
            _memberName = "John";
            _jobTitle = "Developer";
            _salary = 100000;
        }

        // member - finaliser - destructor
        ~Members()
        {
            // cleanup statements
            Console.WriteLine("Deconstruction of Members object");
            Debug.Write("Deconstruction of Members object");
        }
    }
}

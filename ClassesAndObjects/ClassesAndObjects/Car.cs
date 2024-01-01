using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Car
    {
        // private member variables
        // access modifier private
        private string _name;
        private int _horsepower;
        private string _colour;
        private int _maxSpeed;

        public int MaxSpeed { get; set; }

        // read only
        //public int MaxSpeed { get; } = 100;

        // write only
        //public int MaxSpeed { set { _maxSpeed = value; } }

        // public porperty
        // a property can work as a getter and a setter
        // depending in how you use it in your code
        public string Name
        { 
            get { return _name; }
            set
            {
                if (value == "")
                {
                    _name = "defaultname";
                }
                else
                {
                    _name = value;
                }
            }
        }

        // Constructors
        // Default Constructor
        public Car()
        {
            _name = "noname";
            _horsepower = 0;
            _colour = "nocolour";
        }

        // Specific Constructor
        public Car(string name = "noname", int hp = 0, string colour = "nocolour") 
        {
            _name = name;
            _horsepower = hp;
            _colour = colour;
            Console.WriteLine($"{_name} was created");
        }

        public void setName(string name)
        {
            if (name == "")
            {
                _name = "defaultname";
            }
            else
            {
                _name = name;
            }
        }

        public string getName()
        {
            return _name;
        }

        public void Drive()
        {
            Console.WriteLine($"{_name} is driving");
        }

        public void Stop()
        {
            Console.WriteLine($"{_name} stopped");
        }

        public void GetDetails()
        {
            Console.WriteLine($"This car is the {this._name}. It is {this._colour} and it has {this._horsepower} horsepower");
        }
    }
}

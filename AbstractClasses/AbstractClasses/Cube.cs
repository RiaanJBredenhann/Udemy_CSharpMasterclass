using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Cube : Shape
    {
        public double Length { get; set; }

        public Cube(double length)
        {
            this.Name = "Cube";
            this.Length = length;
        }

        public override double CalculateVolume()
        {
            return Math.Pow(Length, 3);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"\nThe cube has a length of {this.Length}");
        }
    }
}

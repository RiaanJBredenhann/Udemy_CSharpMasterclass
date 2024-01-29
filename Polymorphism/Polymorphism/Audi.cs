using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Audi : Car
    {
        private string _brand = "Audi";
        public string Model { get; set; }

        public Audi()
        {

        }

        public Audi(int hp, string colour, string model) : base(hp, colour)
        {
            this.Model = model;
        }

        public override void ShowDetails()
        {
            Console.WriteLine(this.HP);
            Console.WriteLine(this.Colour);
            Console.WriteLine(this.Model);
            Console.WriteLine(this._brand);
        }

        public override void Repair()
        {
            Console.WriteLine($"{this._brand} is repaired");
        }

    }
}

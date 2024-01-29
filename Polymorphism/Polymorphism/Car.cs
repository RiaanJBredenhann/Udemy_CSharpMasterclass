using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Car
    {
        public int HP { get; set; }
        public string Colour { get; set; }

        // 'has a' relationship
        protected CarIDInfo carIDInfo = new CarIDInfo();

        public void SetCarIDInfo(int idNum, string owner)
        {
            carIDInfo.IDNumber = idNum;
            carIDInfo.Owner = owner;
        }

        public void GetCarIDInfo()
        {
            Console.WriteLine($"The car has the ID of {carIDInfo.IDNumber} and is owned by {carIDInfo.Owner}");
        }

        public Car()
        {
            this.HP = 0;
            this.Colour = "nocolour";
        }

        public Car(int hp, string colour)
        {
            this.HP = hp;
            this.Colour = colour;
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine(this.HP);
            Console.WriteLine(this.Colour);
        }

        public virtual void Repair()
        {
            Console.WriteLine($"Car is repaired");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingAnInterface
{
    internal class Chair : Furniture, IDestroyable
    {
        public string DestructionSound { get; set; }

        public Chair() { }

        public Chair (string color, string material) : base (color, material)
        {
            DestructionSound = "ChairDestructionSound.mp3";
        }

        public void Destroy()
        {
            Console.WriteLine($"The {this.Color} chair was destroyed");
            Console.WriteLine($"Playing destruction sounds {this.DestructionSound}");
            Console.WriteLine("Spawning chair parts");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideDemo
{
    internal class Dog : Animal
    {
        public bool IsHappy { get; set; }

        public Dog(string name, int age) : base(name, age)
        {
            IsHappy = true;
        }

        public override void Eat()
        {
            base.Eat();
        }

        public override void MakeSound()
        {
            Console.WriteLine("ARF ARF ARF!");
        }

        public override void Play()
        {
            if (IsHappy)
                base.Play();
            else
                Console.WriteLine($"{Name} is not happy and doesn't want to play");
        }
    }
}

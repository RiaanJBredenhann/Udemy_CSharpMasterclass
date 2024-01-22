using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Radio : ElectricalDevice
    {
        public Radio(bool isOn, string Brand) : base(isOn, Brand)
        {
            
        }

        public void ListenToRadio()
        {
            if (isOn)
                Console.WriteLine("I am listening to the radio");
            else
                Console.WriteLine("Who turned the radio off?");
        }

    }
}

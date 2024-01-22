using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class ElectricalDevice
    {
        public bool isOn { get; set; }
        public string Brand { get; set; }

        public ElectricalDevice(bool isOn, string Brand)
        {
            this.isOn = isOn;
            this.Brand = Brand;
        }

        public void SwitchOn()
        {
            isOn = true;
        }

        public void SwitchOff()
        {
            isOn = false;
        }
    }
}

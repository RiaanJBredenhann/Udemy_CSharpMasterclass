﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class TV : ElectricalDevice
    {
        public TV(bool isOn, string Brand) : base(isOn, Brand)
        {
            
        }

        public void WatchTV()
        {
            if (isOn)
                Console.WriteLine("I am watching TV");
            else
                Console.WriteLine("Someone turned the TV off!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class M3 : BMW
    {
        public M3(int hp, string colour, string model) : base(hp, colour, model)
        {
            
        }

        /*public override void Repair()
        {
            base.Repair();
        }*/
    }
}

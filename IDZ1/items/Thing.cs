using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDZ1.items
{
    abstract class Thing : IInventory
    {
        protected Thing(int number) 
        {
            Number = number;
        }

        public int Number { get; private init; }

        public override String ToString() => $"{this.GetType().Name} #{Number}";

    }
}

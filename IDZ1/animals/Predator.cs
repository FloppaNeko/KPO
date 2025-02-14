using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDZ1.animals;

namespace IDZ1
{
    abstract class Predator : Animal
    {
        protected Predator(string name, int food, int kindness) : base(name, food, kindness)
        {
        }
    }
}

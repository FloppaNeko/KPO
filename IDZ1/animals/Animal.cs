using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDZ1.animals
{
    abstract class Animal : IAlive
    {
        protected Animal(string name, int food, int kindness)
        {
            Name = name;
            Food = food;
            Kindness = kindness;
        }

        public string Name { get; }

        public int Food { get; }

        public int Kindness { get; }

        public override string ToString() => $"{this.GetType().Name} {Name} (Consumes food: {Food}; Level of kindness: {Kindness})";
    }
}

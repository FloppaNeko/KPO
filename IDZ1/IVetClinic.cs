using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDZ1.animals;

namespace IDZ1
{
    interface IVetClinic
    {
        public bool IsHealthy(Animal animal);
    }
}

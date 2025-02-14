using IDZ1.animals;
using IDZ1.items;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDZ1
{
    class Zoo
    {
        private IVetClinic vetClinic_;
        private List<Animal> animals_;
        private List<Thing> items_;

        public Zoo(ServiceCollection services) {

            var provider = services.BuildServiceProvider();

            vetClinic_ = provider.GetService<IVetClinic>();
            ArgumentNullException.ThrowIfNull(vetClinic_);

            animals_ = new List<Animal>();
            items_ = new List<Thing>();

        }

        public bool AddAnimal(Animal animal)
        {
            if (vetClinic_.IsHealthy(animal))
            {
                animals_.Add(animal);
                return true;
            } 
            else
            {
                return false;
            }
        }

        public void AddItem(Thing item)
        {
            items_.Add(item);
        }

        public int TotalFood { 
            get
            {
                int t = 0;
                foreach (var animal in animals_)
                {
                    t += animal.Food;
                }
                return t;
            }
        }

        public Animal[] KindAnimals { get => animals_.Where(animal => animal.Kindness > 5).ToArray(); }

        public Animal[] Animals { get => animals_.ToArray(); }

        public Thing[] Items { get => items_.ToArray(); }

    }
}

using IDZ1;
using IDZ1.animals;
using IDZ1.items;
using Microsoft.Extensions.DependencyInjection;

class Programm
{
    private static Animal InputAnimal()
    {
        Console.WriteLine("Input the number of the species of the animal: \n" +
            "1: Monkey\n" +
            "2: Rabbit\n" +
            "3: Tiger\n" +
            "4: Wolf");

        int speciesNumber;
        if(!int.TryParse(Console.ReadLine(), out speciesNumber) || !(1 <= speciesNumber && speciesNumber <= 4))
        {
            throw new ArgumentException("Incorrect input!");
        }

        Console.WriteLine("Input animal's name:");
        String name = Console.ReadLine();
        ArgumentNullException.ThrowIfNull(name);

        Console.WriteLine("Input the amount of food needed for the animal:");
        int food;
        if (!int.TryParse(Console.ReadLine(), out food) || food < 0)
        {
            throw new ArgumentException("Incorrect input");
        }

        Console.WriteLine("Input the animal's level of kindness:");
        int kindness;
        if (!int.TryParse(Console.ReadLine(), out kindness) || !(0 <= kindness && kindness <= 10))
        {
            throw new ArgumentException("Incorrect input");
        }

        Animal animal = speciesNumber switch
        {
            1 => new Monkey(name, food, kindness),
            2 => new Rabbit(name, food, kindness),
            3 => new Tiger(name, food, kindness),
            4 => new Wolf(name, food, kindness),
            _ => throw new ArgumentException("Incorrect input")
        };

        return animal;
    }

    private static Thing InputThing()
    {
        Console.WriteLine("Input the number of the item type:\n" +
            "1: Table\n" +
            "2: Computer");

        int type;
        if (!int.TryParse(Console.ReadLine(), out type) || !(1 <= type && type <= 2))
        {
            throw new ArgumentException("Incorrect input!");
        }

        Console.WriteLine("Input the number of the item:");
        int number;
        if (!int.TryParse(Console.ReadLine(), out number))
        {
            throw new ArgumentException("Incorrect input");
        }

        Thing item = type switch
        {
            1 => new Table(number),
            2 => new Computer(number),
            _ => throw new ArgumentException("Incorrect input")
        };

        return item;
    }

    public static void Main(string[] args)
    {
        var services = new ServiceCollection();
        services.AddTransient<IVetClinic, VetClinic>();

        var zoo = new Zoo(services);

        while (true)
        {
            Console.WriteLine("Input the number of the command:\n" +
                "1: Add an animal\n" +
                "2: Add an item\n" +
                "3: Get the total ammount of food needed for the animals\n" +
                "4: Get all the animals in the zoo\n" +
                "5: Get the kind animals who can be displayed at the contact zoo\n" +
                "6: Get all the intems in the inventory\n" +
                "7: Exit");

            int command;
            if (!int.TryParse(Console.ReadLine(), out command) || !(1 <= command && command <= 7))
            {
                Console.WriteLine("Incorrect input\n");
                continue;
            }

            if (command == 1)
            {
                Animal newAnimal;
                try
                {
                    newAnimal = InputAnimal();
                } catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message + "\n");
                    continue;
                }

                if (zoo.AddAnimal(newAnimal))
                {
                    Console.WriteLine(newAnimal.ToString() + " was successfully admitted to the zoo");
                }
                else
                {
                    Console.WriteLine(newAnimal.ToString() + " was rejected due to poor health");
                }
            }
            else if (command == 2)
            {
                Thing newItem;
                try
                {
                    newItem = InputThing();
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message + "\n");
                    continue;
                }

                zoo.AddItem(newItem);
                Console.WriteLine(newItem.ToString() + " was successfully added to the inventory");
            }
            else if (command == 3)
            {
                Console.WriteLine($"Total food needed: {zoo.TotalFood}");
            }
            else if (command == 4)
            {
                Console.WriteLine("All the animals of the zoo:");
                foreach (var animal in zoo.Animals)
                {
                    Console.WriteLine(animal.ToString());
                }
            }
            else if (command == 5)
            {
                Console.WriteLine("All the kind animals who can be displayed at the contact zoo:");
                foreach (var animal in zoo.KindAnimals)
                {
                    Console.WriteLine(animal.ToString());
                }
            }
            else if (command == 6)
            {
                Console.WriteLine("All the items in the inventory:");
                foreach (var item in zoo.Items)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else if (command == 7)
            {
                break;
            }


            Console.Write("\n\n");
        }
    }
}
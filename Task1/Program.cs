namespace S1.PedalCarAccauntingInformationSystem;

internal class Program
{
    static void Main(string[] args)
    {
        var customers = new List<Customer>
        {
            new Customer("Alice"),
            new Customer("Bob"),
            new Customer("Charlie"),
            new Customer("Diana"),
            new Customer("Eva"),
            new Customer("Fred")
        };

        var factory = new FactoryAF(customers);

        for (int i = 0; i < 5; i++)
            factory.AddCar();

        Console.WriteLine("BEFORE:");
        Console.WriteLine($"Availible cars: {factory.Cars.Count}");
        Console.WriteLine(string.Join(Environment.NewLine, factory.Cars));
        Console.WriteLine($"Customers: {factory.Customers.Count}");
        Console.WriteLine(string.Join(Environment.NewLine, factory.Customers));

        factory.SaleCar();
        Console.WriteLine(new string('-', 10));

        Console.WriteLine("AFTER:");
        Console.WriteLine($"Availible cars: {factory.Cars.Count}");
        Console.WriteLine(string.Join(Environment.NewLine, factory.Cars));
        Console.WriteLine($"Customers: {factory.Customers.Count}");
        Console.WriteLine(string.Join(Environment.NewLine, factory.Customers));

        Console.WriteLine(new string('#', 20) + "\n\n");

        for (int i = 0; i < 7; i++)
            factory.AddCar();

        Console.WriteLine("BEFORE:");
        Console.WriteLine($"Availible cars: {factory.Cars.Count}");
        Console.WriteLine(string.Join(Environment.NewLine, factory.Cars));
        Console.WriteLine($"Customers: {factory.Customers.Count}");
        Console.WriteLine(string.Join(Environment.NewLine, factory.Customers));

        factory.SaleCar();
        Console.WriteLine(new string('-', 10));

        Console.WriteLine("AFTER:");
        Console.WriteLine($"Availible cars: {factory.Cars.Count}");
        Console.WriteLine(string.Join(Environment.NewLine, factory.Cars));
        Console.WriteLine($"Customers: {factory.Customers.Count}");
        Console.WriteLine(string.Join(Environment.NewLine, factory.Customers));



    }
}

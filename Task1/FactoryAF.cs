namespace S1.PedalCarAccauntingInformationSystem;

public class FactoryAF
{
    public List<Car> Cars { get; private set; }

    public static int totalCars = 0;

    public List<Customer> Customers { get; private set; }

    public FactoryAF(List<Customer> customers)
    {
        Customers = customers;

        Cars = new List<Car> {};
    }

    internal void SaleCar()
    {
        foreach (var customer in Customers)
        {
            customer.Car = Cars.LastOrDefault();

            if (customer.Car == null)
                break;

            Cars.RemoveAt(Cars.Count - 1);
        }

        //Customers = Customers.Where(customer => customer.Car != null).ToList();
        Cars.Clear();
    }

    internal void AddCar()
    {
        var car = new Car { Number = ++totalCars};
        Cars.Add(car);
    }
}

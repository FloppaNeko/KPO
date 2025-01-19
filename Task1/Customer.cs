using System.Diagnostics.CodeAnalysis;

namespace S1.PedalCarAccauntingInformationSystem;

public class Customer
{
    public required string Name { get; set; }

    public Car? Car { get; set; }

    public Customer() { }


    [SetsRequiredMembers]
    public Customer(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        if (Car != null)
        {
            return $"{Name} owns {Car}";
        } 
        else
        {
            return $"{Name} owns no car";
        }
    }
}

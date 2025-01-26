using S2.HseCarShop.Models.Abstractions;

namespace S2.HseCarShop.Models;

/// <summary>
/// Ручной двигатель
/// </summary>
public class HandEngine : IEngine
{
    public EngineType Type => EngineType.Hand;

    public static bool IsEngineCompitable(Customer customer)
    {
        return customer.HandStrength > 5;
    }

    public override string ToString()
        => "Тип: ручной двигатель";
}
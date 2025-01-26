﻿using S2.HseCarShop.Models.Abstractions;

namespace S2.HseCarShop.Models;

/// <summary>
/// Двигатель с педальным приводом
/// </summary>
public class PedalEngine : IEngine
{
    /// <summary>
    /// Размер педалей
    /// </summary>
    public uint Size { get; }

    public EngineType Type => EngineType.Pedal;

    public PedalEngine(uint size)
    {
        Size = size;
    }


    public override string ToString()
        => $"Тип: педальный двигатель, Размер педалей: {Size}";

    public static bool IsEngineCompitable(Customer customer)
    {
        return customer.LegStrength > 5;
    }
}
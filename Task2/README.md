Добавим четырех покупателей и четыре автомобиля (две с ручным и две с педальным двигателей)

```csharp
var customers = new[]
{
    new Customer(name: "Ivan", legStrength: 6, handStrength: 4),
    new Customer(name : "Petr", legStrength : 4, handStrength : 6),
    new Customer(name : "Sidr", legStrength : 6, handStrength : 6),
    new Customer(name : "Alexei", legStrength : 4, handStrength : 4),
};
```

```csharp
carStorage.AddCar(pedalCarFactory, new PedalEngineParams(pedalSize: 2));
carStorage.AddCar(pedalCarFactory, new PedalEngineParams(pedalSize: 3));
carStorage.AddCar(handCarFactory, EmptyEngineParams.Empty);
carStorage.AddCar(handCarFactory, EmptyEngineParams.Empty);
```

Распределим машины вызовом метода `SellCars` и получим результат:

Как видим, все необходимые условия выполняются


```
=== Покупатели ===
Имя: Ivan, Сила ног: 6, Сила рук: 4, Автомобиль: Нет
Имя: Petr, Сила ног: 4, Сила рук: 6, Автомобиль: Нет
Имя: Sidr, Сила ног: 6, Сила рук: 6, Автомобиль: Нет
Имя: Alexei, Сила ног: 4, Сила рук: 4, Автомобиль: Нет

=== Продажа автомобилей ===

=== Покупатели ===
Имя: Ivan, Сила ног: 6, Сила рук: 4,
Автомобиль: { Номер: 5eb0093d-7ed6-4871-b3f4-73280a7ceddd, Двигатель: { Тип: педальный двигатель, Размер педалей: 2 } }
Имя: Petr, Сила ног: 4, Сила рук: 6,
Автомобиль: { Номер: 0481081a-6b30-4904-a57d-d5a0c7ddc0c9, Двигатель: { Тип: ручной двигатель } }
Имя: Sidr, Сила ног: 6, Сила рук: 6,
Автомобиль: { Номер: 9f89db4c-713c-4ce8-9d45-9f3603cd8cda, Двигатель: { Тип: педальный двигатель, Размер педалей: 3 } }
Имя: Alexei, Сила ног: 4, Сила рук: 4, Автомобиль: Нет
```
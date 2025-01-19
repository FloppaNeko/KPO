*Миронов Никита // группа БПИ237*

# Описание работы примера `Program.cs`

Созданим объект `FactoryAF` и 6 клиентов.

```csharp
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
```

Теперь при помощи метода `AddCar` созданим 5 машин

```csharp
for (int i = 0; i < 5; i++)
    factory.AddCar();
```

Попытаемся их продать методом `SaleCar` и получаем результат
```
BEFORE:
Availible cars: 5
Car #1 (pedal size: 4)
Car #2 (pedal size: 8)
Car #3 (pedal size: 9)
Car #4 (pedal size: 7)
Car #5 (pedal size: 3)
Customers: 6
Alice owns no car
Bob owns no car
Charlie owns no car
Diana owns no car
Eva owns no car
Fred owns no car
----------
AFTER:
Availible cars: 0

Customers: 6
Alice owns Car #5 (pedal size: 3)
Bob owns Car #4 (pedal size: 7)
Charlie owns Car #3 (pedal size: 9)
Diana owns Car #2 (pedal size: 8)
Eva owns Car #1 (pedal size: 4)
Fred owns no car
```

Как мы видим, до вызова метода `SaleCar` в массиве было 5 машин с разными номерами и размером педалей, 
а ни у кого из клиентов машины не было. После "продажи" все машины были распредлены между клиентами. Так как клиентов было больше, чем машин, последний из них - Фред - так и не получил машину.

Предопожим, произвели еще 7 новых машин
```csharp
for (int i = 0; i < 7; i++)
    factory.AddCar();
```

Тогда клиенты решили купить себе новые машины вместо старых. Снова вызываем метод `SaleCar` и получаем результатат
```
BEFORE:
Availible cars: 7
Car #6 (pedal size: 7)
Car #7 (pedal size: 9)
Car #8 (pedal size: 4)
Car #9 (pedal size: 8)
Car #10 (pedal size: 6)
Car #11 (pedal size: 9)
Car #12 (pedal size: 4)
Customers: 6
Alice owns Car #5 (pedal size: 3)
Bob owns Car #4 (pedal size: 7)
Charlie owns Car #3 (pedal size: 9)
Diana owns Car #2 (pedal size: 8)
Eva owns Car #1 (pedal size: 4)
Fred owns no car
----------
AFTER:
Availible cars: 0

Customers: 6
Alice owns Car #12 (pedal size: 4)
Bob owns Car #11 (pedal size: 9)
Charlie owns Car #10 (pedal size: 6)
Diana owns Car #9 (pedal size: 8)
Eva owns Car #8 (pedal size: 4)
Fred owns Car #7 (pedal size: 9)
```

Как видим, у всех клиентов действительно обновились их автомобили на новые с новыми номерами. Так как в этот раз машин было больше, чем клиентов, машин на всех хватило, а лишняя машина была уничтожена после отработки метода, как того требует задание






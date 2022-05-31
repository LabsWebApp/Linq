using static Core.Data;

Console.WriteLine("ToArray");
var item = Enumerable.Range(1, 20);
Console.WriteLine("Начальный тип: " + item);
var arr = item.ToArray();
Console.WriteLine("Используем ToArray: " + arr);

var cars = Cars.ToList();
Cars[0] = "Москвич";
Console.WriteLine(cars[0]);
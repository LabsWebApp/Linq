using static Core.Data;
using Core;

Console.WriteLine("ToArray");
var item = Enumerable.Range(1, 20);
Console.WriteLine("Начальный тип: " + item);
var arr = item.ToArray();
Console.WriteLine("Используем ToArray: " + arr);

var cars = Cars.ToList();
Cars[0] = "Москвич";
Console.WriteLine(cars[0]);

HashSet<int> set = new HashSet<int>(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20});
var carsSet = Enumerable.Range(1, 20).ToHashSet();
Console.WriteLine(carsSet.GetType() == set.GetType());

carsSet.CommaWriter();


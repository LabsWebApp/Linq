// (аргумент - double) (возвращаемое значение - double)
Func<double, double> expression = x => x / 2;

// Func<double, int> expression = x => x / 2;
int number = 9;

Console.WriteLine($"Результат: {expression(number)}");

// Задержка.
Console.ReadKey();
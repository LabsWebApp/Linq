using static System.Console;

// (аргумент - double) (возвращаемое значение - double)
Func<double, double> expression = x => x / 2;

// Func<double, int> expression = x => x / 2;
int number = 9;

WriteLine($"Результат: {expression(number)}");

// Задержка.
ReadKey();
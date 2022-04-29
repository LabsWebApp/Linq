using static System.Console;

// Func< (аргумент - int), (возвращаемое значение - double) >.
// Func<int, double> expression = x => x / 2;
//	Лямбда-Выражение сообщенное с делегатом.

Func<int, double> func = x => x / 2;
int number = 9;
WriteLine($"Результат: {func(number)}");

// Задержка.
ReadKey();
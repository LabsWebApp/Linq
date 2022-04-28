int number = 0;

// Анонимный метод - как аргумент метода.
WriteStream(() => number++);

Console.WriteLine($"Результат: {number}");

// Задержка.
Console.ReadKey();

// Делегат в качестве формального аргумента.
static void WriteStream(Func<int> counter)
{
    for (int i = 0; i < 10; ++i)
        Console.Write($"{counter.Invoke()}, ");
}
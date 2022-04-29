using static System.Console;

int number = 0;

// Анонимный метод - как аргумент метода.
WriteStream(() => number++);

WriteLine($"Результат: {number}");

// Задержка.
ReadKey();

// Делегат в качестве формального аргумента.
static void WriteStream(Func<int> counter)
{
    for (int i = 0; i < 10; ++i)
        Write($"{counter.Invoke()}, ");
}
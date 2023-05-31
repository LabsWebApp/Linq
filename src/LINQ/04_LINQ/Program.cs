using static System.Console;

int[] numbers = { 1, 2, 3, 4 };

var query = from x in numbers
    where x % 2 == 0
    select x * 2;

foreach (var item in query) Write(item + ", ");

// Delay.
ReadKey();

public static class LinqExtensions
{
    public static IEnumerable<T> Where<T>(this IEnumerable<T> source, Func<T, bool> predicate)
    {
        WriteLine("Вызвана собственная реализация Where.");
        foreach (var item in source) if (predicate(item)) yield return item;
    }

    public static IEnumerable<TResult> Select<T, TResult>(
        this IEnumerable<T> source, 
        Func<T, TResult> selector)
    {
        WriteLine("Вызвана собственная реализация Select.");
        foreach (var item in source) yield return selector(item);
    }
}
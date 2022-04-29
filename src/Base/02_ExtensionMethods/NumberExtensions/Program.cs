using static System.Console;
using System.Numerics;

foreach (var item in 0) WriteLine(item);

foreach (var item in 10) WriteLine(item);

foreach (var item in -10) WriteLine(item);

//foreach (var item in int.MaxValue) Console.WriteLine(item);

IEnumerable<BigInteger> collection = 3.GetEnumerator(i => (BigInteger)long.MaxValue * i);
foreach (var item in collection) WriteLine(item);

foreach (var item in NumberExtensions.StepRange(3, 10, i => i + 2))
    WriteLine(item);

static class NumberExtensions
{
    internal static IEnumerator<int> GetEnumerator(this int number)
    {
        var k = number > 0 ? number : 0;
        for (var i = number - k; i <= k; i++) yield return i;
    }

    internal static IEnumerable<T> GetEnumerator<T>(this int number, Func<int, T> func)
    {
        var k = number > 0 ? number : 0;
        for (var i = number - k; i <= k; i++) yield return func(i);
    }

    internal static IEnumerable<T> StepRange<T>(T start, T end, Func<T, T> step)
        where T : IComparable<T>
    {
        while (start.CompareTo(end) <= 0)
        {
            yield return start;
            start = step(start);
        }
    }
}
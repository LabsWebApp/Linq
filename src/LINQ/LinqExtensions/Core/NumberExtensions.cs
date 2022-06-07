using System.Text;
using static System.Console;
namespace Core;

public static class NumberExtensions
{
    public static IEnumerable<T> StepRange<T>(T start, T end, Func<T, T> step)
    where T : IComparable<T>
    {
        while (start.CompareTo(end) <= 0)
        {
            yield return start;
            start = step(start);
        }
    }

    public static IEnumerable<T> StepRange<T>(T start, T end)
        where T : IComparable<T> => StepRange(start, end, x => x);

    public static IEnumerator<int> GetEnumerator(this int number)
    {
        var k = number > 0 ? number : 0;
        for (var i = number - k; i <= k; i++) yield return i;
    }

    public static IEnumerable<T> GetEnumerator<T>(this int number, Func<int, T> func)
    {
        var k = number > 0 ? number : 0;
        for (var i = number - k; i <= k; i++) yield return func(i);
    }

    public static void CommaWriter<T>(this IEnumerable<T> numbers)
    {
        StringBuilder sb = new();
        foreach (var number in numbers) sb.Append($"{number}, ");
        var result = sb.ToString();
        result = string.IsNullOrEmpty(result) ? string.Empty : result.TrimEnd(new char[] { ' ', ',' });
        WriteLine(result);
    }
}

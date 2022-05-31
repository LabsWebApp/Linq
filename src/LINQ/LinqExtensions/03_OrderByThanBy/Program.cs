using static System.Console;
using static Core.Data;

using Core;

WriteLine("OrderBy");
IEnumerable<string> auto = Cars.OrderBy(s => s.Length);
WriteLine(auto.GetType());
foreach (string str in auto) WriteLine(str);

auto = Cars.OrderByDescending(s => s.Length);
foreach (string str in auto) WriteLine(str);

int[] numbers = { 99, 5, 54, 9, 55, 64, 48, 77, 0, -5, 9, 77, 52, -8, -26, 33};

var newOrder = numbers.OrderBy(i => i, new EvenComparer());

WriteLine();
numbers.CommaWritter();
newOrder.CommaWritter();

ReadKey();

class EvenComparer : IComparer<int>
{
    public int Compare(int x, int y) => x == y ? 0 : 
        (Math.Abs(x % 2), Math.Abs(y % 2)) switch
        {
            (1, 0) => 1,
            (0, 1) => -1,
            _ => 0
        };
}


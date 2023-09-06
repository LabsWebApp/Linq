using Core;
using static System.Console;
// ReSharper disable PossibleMultipleEnumeration

Enumerable.Range(0, 10).CommaWriter();
Enumerable.Range(5, 10).CommaWriter();

WriteLine("Union:");

Enumerable.Range(0, 10)
    .Union(Enumerable.Range(5, 10))
    .CommaWriter();

WriteLine("Concat");

var concat = Enumerable.Range(0, 10).Concat(Enumerable.Range(5, 10));
concat.CommaWriter();

WriteLine("Distinct");

concat.Distinct().CommaWriter();

WriteLine("Intersect");

Enumerable.Range(0, 10)
    .Intersect(Enumerable.Range(5, 10))
    .CommaWriter();

WriteLine("Except");

Enumerable.Range(0, 10)
    .Except(Enumerable.Range(5, 10), new YesComparer())
    .CommaWriter();

ReadKey();

class NoComparer : IEqualityComparer<int>
{
    public bool Equals(int x, int y) => false;

    public int GetHashCode(int obj) => 0;
}

class YesComparer : IEqualityComparer<int>
{
    public bool Equals(int x, int y) => true;

    public int GetHashCode(int obj) => 1;
}
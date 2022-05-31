using Core;
using static System.Console;

Enumerable.Range(0, 10).CommaWritter();
Enumerable.Range(5, 10).CommaWritter();

WriteLine("Union");

Enumerable.Range(0, 10)
    .Union(Enumerable.Range(5, 10))
    .CommaWritter();

WriteLine("Concat");

var conc = Enumerable.Range(0, 10).Concat(Enumerable.Range(5, 10));
conc.CommaWritter();

WriteLine("Distinct");

conc.Distinct().CommaWritter();

WriteLine("Intersect");

Enumerable.Range(0, 10)
    .Intersect(Enumerable.Range(5, 10))
    .CommaWritter();

WriteLine("Except");

Enumerable.Range(0, 10)
    .Except(Enumerable.Range(5, 10))
    .CommaWritter();

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
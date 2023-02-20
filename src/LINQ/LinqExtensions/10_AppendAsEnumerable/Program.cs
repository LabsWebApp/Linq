using Core;
using System.Collections;
using static System.Console;

WriteLine("Append");
IEnumerable<int> range = Enumerable.Range(0, 3);
range.CommaWriter();

range.Append(99).CommaWriter();


WriteLine("AsEnumerable");
var a = new A();

foreach (var i in a) WriteLine(i);
WriteLine("a Count() = " + a.Count());
WriteLine("IEnumerable<bool> Count() = " + a.AsEnumerable().Count());

class A : IEnumerable<bool>, IEnumerator<bool>
{
    private bool _position = false;

    public int Count() => 0;

    public bool Current => _position;

    public void Dispose() { }

    public bool MoveNext()
    {
        if (!_position)
        {
            _position = true;
            return true;
        }
        return false;
    }

    public void Reset() => _position = false;

    public IEnumerator<bool> GetEnumerator()
    {
        Reset();
        return this;
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

    object IEnumerator.Current => Current;
}
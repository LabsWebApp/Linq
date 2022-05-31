using Core;
using static System.Console;

IEnumerable<int> range = Enumerable.Range(0, 3);
range.CommaWritter();
range.Append(99).CommaWritter();
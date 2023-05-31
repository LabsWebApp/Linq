using static Core.Data;
using static System.Console;


foreach (string str in Cars) WriteLine(str);

WriteLine("\nTake");
IEnumerable<string> auto = Cars.Take(5);

foreach (string str in auto) WriteLine(str);

WriteLine("\nSkip");
auto = Cars.Skip(5);

foreach (string str in auto) WriteLine(str);

WriteLine("\nTakeWhile");
auto = Cars.TakeWhile(y => y.Length > 5);

foreach (string str in auto) WriteLine(str);

WriteLine();

auto = Cars.TakeWhile((s, i) => s.Length > 5 && i < 5);

foreach (string str in auto) WriteLine(str);

WriteLine("\nSkipWhile");
auto = Cars.SkipWhile(y => y.Length > 5);

foreach (string str in auto) WriteLine(str);

WriteLine();

auto = Cars.SkipWhile((s, i) => s.Length > 5 && i < 5);

foreach (string str in auto) WriteLine(str);

WriteLine("\nReverse");
foreach (string str in Cars.Reverse()) WriteLine(str);

ReadKey();
using static System.Console;

var repeat = Enumerable.Repeat(9, 5);
foreach (var item in repeat) WriteLine(item);

WriteLine(repeat.GetType());

var range = Enumerable.Range(6, 5);
foreach (var item in range) WriteLine(item);

WriteLine(range.GetType());

var empty = Enumerable.Empty<int>();
foreach (var item in empty) WriteLine(item);

WriteLine(empty.GetType());

var defaultIfEmpty = empty.DefaultIfEmpty();
foreach (var item in defaultIfEmpty) WriteLine(item);

WriteLine(defaultIfEmpty.GetType());

defaultIfEmpty = empty.DefaultIfEmpty(10);
foreach (var item in defaultIfEmpty) WriteLine(item);

WriteLine(defaultIfEmpty.GetType());

ReadKey();


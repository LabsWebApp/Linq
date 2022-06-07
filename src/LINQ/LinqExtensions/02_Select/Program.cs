using static Core.Data;
using static System.Console;
using Core;

var sequence = Cars.Select(p => p.Replace(" ", string.Empty).Length);
WriteLine(sequence.GetType());

//foreach (int i in sequence) Write(i + " ");
sequence.CommaWriter();
WriteLine();

var sequence2 = Cars.Select(p => new { Name = p, p.Length });
WriteLine(sequence2.GetType());

foreach (var i in sequence2) WriteLine(i);

var cars = Cars.Select((p, i) => new { Index = ++i, Name = p });

foreach (var i in cars) WriteLine($"{i.Index}. {i.Name}");

ReadKey();
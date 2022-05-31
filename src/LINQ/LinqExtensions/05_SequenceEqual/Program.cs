using Core;
using static Core.Data;

var list = new List<string>(Cars);
bool eq = Cars.SequenceEqual(list);
Console.WriteLine(eq);
list.Reverse();
eq = Cars.SequenceEqual(list);
Console.WriteLine(eq);

string[] strArr1 = { "0012", "130", "0000019", "4" };
string[] strArr2 = { "12", "0130", "019", "0004" };

eq = strArr1.SequenceEqual(strArr2, new StringifiedNumberComparer());
Console.WriteLine(eq);

Console.ReadKey();
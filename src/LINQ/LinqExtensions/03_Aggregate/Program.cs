using System.Text;
using static System.Console;

var seq = Enumerable.Range(5, 8);
int result = seq.Aggregate((x, y) => x * y);
WriteLine(result);   //19958400 


result = seq.Aggregate(0, (x, y) => x * y);
WriteLine(result);   // 0

var hayStack = new[] { "straw", "needle", "straw", "straw", "needle" };
var nNeedles = hayStack.Aggregate(0, (n, e) => e == "needle" ? ++n : n);
WriteLine(nNeedles);   // 2

var csv = hayStack.Aggregate(
    new StringBuilder(),
    (b, e) => b.Length switch
    {
        0 => b.Append(e),
        _ => b.Append($", {e}")
    },
    b => b.Append("\nEND").ToString());
WriteLine(csv);

ReadKey();
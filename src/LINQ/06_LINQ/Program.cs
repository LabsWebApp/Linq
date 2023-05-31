using static System.Console;
using System.Collections;

var numbers = new ArrayList
{
    1,
    2
};

WriteLine(numbers.GetType());

// ЯВНОЕ указание типа Int32 переменной диапазона - n.
// (var - НЕВОЗМОЖНО использовать т.к. IEnumerable не параметризированный!)
var query = 
    from int n in numbers
    select n * 2;

foreach (var item in query)
    WriteLine(item);

// Delay.
ReadKey();
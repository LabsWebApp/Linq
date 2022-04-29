using static System.Console;

// group - является средством для разделения ввода запроса.

int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

// Построить запрос.
// Разделение чисел на четные и нечетные.
var query = from x in numbers
    group x by x % 2;

foreach (var group in query)
{
    WriteLine("mod{0} == {0}", group.Key);

    foreach (var number in group)
        WriteLine($"{number}, ");
}

// Delay.
ReadKey();
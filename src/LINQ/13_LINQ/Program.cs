using static System.Console;

// group - является средством для разделения ввода запроса.

int[] numbers = {-1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

int GetMod(int number) => number == 0 ? 0 : 1;

// Построить запрос.
// Разделение чисел на четные и нечетные.
var query = 
    from x in numbers
    group x by GetMod(x % 11); 

foreach (var group in query)
{
    WriteLine($"mod{group.Key} == {group.Key}");

    foreach (var number in group)
        Write($"{number}, ");

    WriteLine();
}

// Delay.
ReadKey();
using static System.Console;

// into - подобно let, позволяет определить локальный по отношению к запросу идентификатор.

int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

// Построить запрос.
// Разделение чисел на четные и нечетные.
var query = 
    from x in numbers
    group x by x % 2 
        into partition
    //where partition.Key == 0
    select new { partition.Key, Count = partition.Count(), Group = partition };


foreach (var item in query)
{
    WriteLine($"mod2 == {item.Key}");
    WriteLine($"Count == {item.Count}");

    foreach (var number in item.Group)
        Write($"{number}, ");

    WriteLine("\n*****");
}

// Delay.
ReadKey();
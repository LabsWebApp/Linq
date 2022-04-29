using static System.Console;
// Таблица умножения

// Конструкция from похожа на оператор foreach.
// Использование нескольких конструкций from, аналогично вложенным операторам foreach.
var query = from x in Enumerable.Range(1, 9) // Таблица умножения от 1 до 9.
    from y in Enumerable.Range(1, 10)
    select new
    {
        X = x,
        Y = y,
        Product = x * y
    };

foreach (var item in query)
    WriteLine($"{item.X} * {item.Y} = {item.Product}");

// Delay.
ReadKey();
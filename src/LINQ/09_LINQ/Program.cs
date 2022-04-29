using static System.Console;

// select - (Операция проекции) используется для производства конечного результата запроса.

int[] numbers = { 1, 2, 3, 4 };

// Построить запрос.
var query = from x in numbers
    select new Result(x, x * 2);

numbers[0] = 777; // Выражение запроса выполняется в момент обращения к переменной запроса в foreach.

foreach (var item in query)
    WriteLine($"Input = {item.Input}, \t Output = {item.Output}");

// Delay.
ReadKey();

class Result
{
    public Result(int input, int output)
    {
        Input = input;
        Output = output;
    }

    public int Input { get; set; }
    public int Output { get; set; }
}
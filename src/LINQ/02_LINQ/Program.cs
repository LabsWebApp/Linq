using static System.Console;
using LinqCore;

// База данных сотрудников.
var employees = new List<Employee>
{
    new()
    {
        FirstName = "Ivan",
        LastName = "Ivanov",
        Salary = 94000,
        StartDate = DateTime.Parse("1/4/1992")
    },
    new()
    {
        FirstName = "Petr",
        LastName = "Petrov",
        Salary = 123000,
        StartDate = DateTime.Parse("12/3/1985")
    },
    new()
    {
        FirstName = "Andrew",
        LastName = "Andreev",
        Salary = 1000000,
        StartDate = DateTime.Parse("1/12/2005")
    }
};

// Выражение запроса.(Использование вызовов расширяющих методов.)
var query = // query - переменная запрса.
    employees.Where(employee => employee.Salary > 100000)
        .OrderBy(employee => employee.LastName)
        .ThenBy(employee => employee.FirstName)
        .Select(employee => new // select - Опреация проекции.
        {
            LastName = employee.LastName, FirstName = employee.FirstName
        });

WriteLine("Высокооплачиваемые сотрудники:");

foreach (var item in query)
    WriteLine($"{item.LastName} {item.FirstName}");

// Delay.
ReadKey();
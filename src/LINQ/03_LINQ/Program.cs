﻿using static System.Console;
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
        FirstName = "Andrey",
        LastName = "Petrov",
        Salary = 123000,
        StartDate = DateTime.Parse("12/3/1985")
    },
    new()
    {
        FirstName = "Ivan",
        LastName = "Andrey",
        Salary = 1000000,
        StartDate = DateTime.Parse("1/12/2005")
    },
    new()
    {
        FirstName = "Andrey",
        LastName = "Andreev",
        Salary = 1000001,
        StartDate = DateTime.Parse("1/12/2022")
    },
    new()
    {
        FirstName = "Ana",
        LastName = "Andreev",
        Salary = 1000002,
        StartDate = DateTime.Parse("1/12/2022")
    }
};

// Выражение запроса.(Использование вызовов статических методов.)
var query = // query - переменная запрса.
    Enumerable.Select(
        Enumerable.ThenBy(
            Enumerable.OrderBy(
                Enumerable.Where(
                    employees, emp => emp.Salary > 100000),
                emp => emp.LastName),
            emp => emp.FirstName),
        emp => new { LastName = emp.LastName, FirstName = emp.FirstName });

WriteLine("Высокооплачиваемые сотрудники:");

foreach (var item in query)
    WriteLine($"{item.LastName} {item.FirstName}");

// Delay.
ReadKey();
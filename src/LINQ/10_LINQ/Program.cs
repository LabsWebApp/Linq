﻿using static System.Console;

// select - (Операция проекции) используется для производства конечного результата запроса.

int[] numbers = { 1, 2, 3, 4 };

// Построить запрос.
var query = 
    from x in numbers
    select new { Input = x, Output = x * 2 };

foreach (var item in query)
    WriteLine($"Input = {item.Input}, \t Output = {item.Output} ({item.GetType()})");

// Delay.
ReadKey();
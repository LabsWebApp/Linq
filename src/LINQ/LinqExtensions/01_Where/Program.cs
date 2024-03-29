﻿using static System.Console;

var sequence = Enumerable.Range(1, 9);
WriteLine(sequence.GetType());

var where = sequence.Where(x => x % 2 == 0);
WriteLine(where.GetType());
foreach (var item in where) Write(item + ", ");

WriteLine();
foreach (var item in sequence
    .Where((x, i) => i < 5 && x % 2 == 0))
    Write(item + ", ");

ReadKey();
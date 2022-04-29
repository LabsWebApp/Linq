using static System.Console;
// Анонимные типы в анонимных типах.

var instance = new
{
    Name = "Alex", Age = 27, Id = new { Number = 123 }
};

WriteLine($"Name = {instance.Name}, Age = {instance.Age}, Id = {instance.Id.Number}");

// Delay.
ReadKey();
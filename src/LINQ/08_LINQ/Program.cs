using static System.Console;

// orderby - используется для сортировки (последовательности) результата запроса.
// Построить коллекцию сотрудников с национальностями.
var employees = new List<Employee>
{
    new() {LastName = "Andreev", FirstName = "Andrew", Nationality = "Kyrgyz"},
    new() {LastName = "Ivanov", FirstName = "Ivan", Nationality = "Kyrgyz"},
    new() {LastName = "Borisov", FirstName = "Boris", Nationality = "Armenians"}
};

// Построить запрос.
// Получение списка имен всех сотрудников вместе с их национальностями.
var query = 
    from emp in employees
    orderby 
        emp.Nationality ascending,
        emp.LastName descending, // ascending - по возрастанию | descending - по убыванию.
        emp.FirstName descending // по умолчанию - ascending.
    select emp;

foreach (var person in query)
    WriteLine($"{person.LastName}, \t{person.FirstName}, \t{person.Nationality}");

// Delay.
ReadKey();

public class Employee
{
    public string LastName { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string? Nationality { get; set; }
}
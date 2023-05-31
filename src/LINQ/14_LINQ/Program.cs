using static System.Console;

// Построить коллекцию сотрудников с национальностями.
var employees = new List<Employee>
{
    new() {LastName = "Ivanov",  FirstName = "Ivan",    Nationality = "Kyrgyz"},
    new() {LastName = "Ivanov",  FirstName = "Vasja",    Nationality = "Armenians"},
    new() {LastName = "Andreev", FirstName = "Ivan",  Nationality = "Kyrgyz"},
    new() {LastName = "Petrov",  FirstName = "Petr",    Nationality = "Armenians"},
    new() {LastName = "Andreev", FirstName = "Sergey",  Nationality = "Kyrgyz"},
    new() {LastName = "Andreev", FirstName = "Andrew",  Nationality = "Kyrgyz"},
    new() {LastName = "Petrov",  FirstName = "Slava",    Nationality = "Armenians"}
};

// Построить запрос.
var query = 
    from emp in employees
    group emp by new { Nationality = emp.Nationality, LastName = emp.LastName };

foreach (var group in query)
{
    WriteLine(group.Key);

    foreach (var employee in group)
        WriteLine(employee.FirstName);

    WriteLine("****");
}

// Delay.
ReadKey();

public class Employee
{
    public string LastName { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string Nationality { get; set; } = null!;
}
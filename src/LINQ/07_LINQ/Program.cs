using static System.Console;

// join on

// Построить коллекцию сотрудников.
var employees = new List<EmployeeId>
{
    new() {Id = "111", Name = "Ivan Ivanov"},
    new() {Id = "222", Name = "Andrey Andreev"},
    new() {Id = "333", Name = "Petr Petrov"},
    new() {Id = "444", Name = "Alex Alexeev"}
};

// Построить коллекцию подданств.
var empNationalities = new List<EmployeeNationality>
{
    new() {Id = "111", Nationality = "Kyrgyz"},
    new() {Id = "222", Nationality = "Kyrgyz"},
    new() {Id = "333", Nationality = "Armenians"},
};

// Построить запрос.
// Получение списка имен всех сотрудников вместе с их гражданствами, при этом отсортировав список по убыванию.
var query = 
    from emp in employees
    join n in empNationalities
        on emp.Id equals n.Id
    orderby n.Nationality ascending // descending // ascending - по возрастанию | descending - по убыванию.
    select new
    {
        Id = emp.Id,
        Name = emp.Name,
        Nationality = n.Nationality
    };

foreach (var person in query)
    WriteLine($"{person.Id}, {person.Name}, \t{person.Nationality}");

// Delay.
ReadKey();

public class EmployeeId
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
}

public class EmployeeNationality
{
    public string Id { get; set; } = null!;
    public string Nationality { get; set; } = null!;
}
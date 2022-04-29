using static System.Console;

// let - представляет новый локальный идентификатор, на который можно ссылаться в остальной части запроса.
// Его можно представить, как локальную переменную видимую только внутри выражения запроса.

// Построить коллекцию сотрудников.
var employees = new List<Employee>
{
    new() {LastName = "Ivanov", FirstName = "Ivan"},
    new() {LastName = "Andreev", FirstName = "Andrew"},
    new() {LastName = "Petrov", FirstName = "Petr"}
};

// Построить запрос.
var query = from emp in employees
    let fullName = emp.FirstName + " " + emp.LastName // let - новый локальный идентификатор.
    orderby fullName descending
    select fullName;

foreach (var person in query)
    WriteLine(person);

// Delay.
ReadKey();

public class Employee
{
    public string LastName { get; set; } = null!;
    public string FirstName { get; set; } = null!;
}
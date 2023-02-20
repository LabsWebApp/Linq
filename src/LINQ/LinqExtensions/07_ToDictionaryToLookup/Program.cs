using Core;
using static System.Console;

WriteLine("ToDictionary");
Dictionary<int, Employee> eDictionary =
    Employee.GetEmployeesArray().ToDictionary(k => k.Id);

var e = eDictionary[2];
WriteLine($"Сотрудником с id == 2 является {e.FirstName} {e.LastName}");

var e2Dictionary =
      Employee2.GetEmployeesArray().ToDictionary(
          k => k.Id,
          new StringifiedNumberComparer());
Employee2 e2 = e2Dictionary["2"];
WriteLine($"Сотрудником с id == \"2\" является {e2.FirstName} {e2.LastName}");

e2 = e2Dictionary["00002"];
WriteLine($"Сотрудником с id == \"00002\" является {e2.FirstName} {e2.LastName}");

Dictionary<int, string> eNameDictionary =
    Employee.GetEmployeesArray().ToDictionary(k => k.Id,
        i => $"{i.FirstName} {i.LastName}");
string name = eNameDictionary[2];
WriteLine("Сотрудником с id == 2 является " + name);

var e2NameDictionary = Employee2
    .GetEmployeesArray()
    .ToDictionary(
          k => k.Id,
          i => $"{i.FirstName} {i.LastName}",
          new StringifiedNumberComparer());

var name2 = e2NameDictionary["00002"];
WriteLine("Сотрудником с id == \"00002\" является " + name2);

ReadKey();

WriteLine("\nToLookup");

ILookup<int, Actor> lookup = Actor.GetActors().ToLookup(k => k.BirthYear);

// Посмотрим, можно ли найти кого-то, рожденного в 1964 г.
IEnumerable<Actor> actors = lookup[1964];
foreach (var actor in actors)
    WriteLine($"1964: {actor.FirstName} {actor.LastName}");

ILookup<string, Actor2> lookup2 = Actor2
    .GetActors()
    .ToLookup(k => k.BirthYear, new StringifiedNumberComparer());

IEnumerable<Actor2> actors2 = lookup2["0001964"];
foreach (var actor in actors)
    WriteLine($"0001964: {actor.FirstName} {actor.LastName}");

var nameLookup = Actor
    .GetActors()
    .ToLookup(
        k => k.BirthYear,
        a => $"{a.FirstName} {a.LastName}");

var names = nameLookup[1964];
foreach (var item in names) WriteLine(item);

var nameLookup2 = Actor2
    .GetActors()
    .ToLookup(
        k => k.BirthYear,
        a => $"{a.FirstName} {a.LastName}",
        new StringifiedNumberComparer());
names = nameLookup[1964];
foreach (var item in names) WriteLine(item);

ReadKey();
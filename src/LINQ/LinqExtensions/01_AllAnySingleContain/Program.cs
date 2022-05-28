using static System.Console;

WriteLine("All");
string[] people = { "Tom", "Tim", "Bob", "Sam" };

// проверяем, все ли элементы имеют длину в 3 символа
bool allHas3Chars = people.All(s => s.Length == 3);     // true
WriteLine(allHas3Chars);

// проверяем, все ли строки начинаются на T
bool allStartsWithT = people.All(s => s.StartsWith("T"));   // false
WriteLine(allStartsWithT);

WriteLine("Any");
//проверяем, есть ли хоть один элемент в коллекции 
bool peopleHasAny = people.Any();   // true
WriteLine(peopleHasAny);

// проверяем, все ли элементы имеют длину больше 3 символов
bool allHasMore3Chars = people.Any(s => s.Length > 3);     // false
WriteLine(allHasMore3Chars);

// проверяем, все ли строки начинаются на T
allStartsWithT = people.Any(s => s.StartsWith("T"));   // true
WriteLine(allStartsWithT);

WriteLine("Contains");

// проверяем, есть ли строка Tom
bool hasTom = people.Contains("Tom");     // true
WriteLine(hasTom);

// проверяем, есть ли строка Mike
bool hasMike = people.Contains("Mike");     // false
WriteLine(hasMike);

Person[] persons = { new Person("Tom"), new Person("Sam"), new Person("Bob") };

var tom = new Person("Tom");
var mike = new Person("Mike");

// проверяем, есть ли Tom
hasTom = persons.Contains(tom);     // true
WriteLine(hasTom);

// проверяем, есть ли строка Mike
hasMike = persons.Contains(mike);     // false
WriteLine(hasMike);

// проверяем, есть ли строка Tom
hasTom = people.Contains("tom", new CustomStringComparer());     // true
WriteLine(hasTom);

// проверяем, есть ли строка Bob
bool hasBob = people.Contains("bOb", new CustomStringComparer());     // true
WriteLine(hasBob);

class Person
{
    public string Name { get; }
    public Person(string name) => Name = name;

    public override bool Equals(object? obj)
    {
        if (obj is Person person) return Name == person.Name;
        return false;
    }

    public override int GetHashCode() => Name.GetHashCode();
}

class CustomStringComparer : IEqualityComparer<string>
{
    public bool Equals(string? x, string? y)
    {
        if (x is null || y is null) return false;
        return x.ToLower() == y.ToLower();
    }

    public int GetHashCode(string obj) => obj.ToLower().GetHashCode();
}

using static System.Console;

var members = new List<string>
{
    "Один - One",
    "Два - Two",
    "Три - Three",
    "Одиннадцать - Eleven",
};

WriteStream(members, "а", (x, y) => x.ToLower().Contains(y));

// Задержка.
ReadKey();

// Метод.
static void WriteStream(IEnumerable<string> members, string name, Func<string, string, bool> predicate)
{
    foreach (string member in members)
        if (predicate(member, name)) // Делегат-Предикат.
            WriteLine(member);
}
using Core;

using static System.Console;

int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 , -4, -5 };

// Построить запрос.
// Разделение чисел на четные и нечетные.
var query = numbers.GroupBy(i => Math.Abs(i % 2));

foreach (var group in query)
{
    WriteLine("\nmod{0} == {0}", group.Key);

    foreach (var number in group)
        Write($"{number}, ");
}

WriteLine();

ReadKey();

var comp = new FounderNumberComparer();
var empOptions = EmployeeOptionEntry.GetEmployeeOptionEntries();
IEnumerable<IGrouping<int, EmployeeOptionEntry>> opts = empOptions
  .GroupBy(o => o.Id, comp);

// Сначала перечисление по последовательности IGrouping
foreach (IGrouping<int, EmployeeOptionEntry> keyGroup in opts)
{
    WriteLine("Записи опционов для: " +
      (comp.IsFounder(keyGroup.Key) ? "основатель" : "работяга"));

    // Теперь перечисление по сгруппированной последовательности 
    // элементов EmployeeOptionEntry
    foreach (EmployeeOptionEntry element in keyGroup)
        WriteLine("id={0} : optionsCount={1} : dateAwarded={2:d}",
          element.Id, element.OptionsCount, element.DateAwarded);
}

ReadKey();

IEnumerable<IGrouping<int, DateTime>> optsDate = empOptions
  .GroupBy(o => o.Id, e => e.DateAwarded);

// Сначала перечисление по последовательности IGrouping
foreach (IGrouping<int, DateTime> keyGroup in optsDate)
{
    WriteLine("Записи опционов для сотрудника: " + keyGroup.Key);

    // Теперь перечисление по сгруппированной последовательности элементов DateTime
    foreach (DateTime date in keyGroup)
        WriteLine(date.ToShortDateString());
}

public class FounderNumberComparer : IEqualityComparer<int>
{
    public bool Equals(int x, int y) => IsFounder(x) == IsFounder(y);

    public int GetHashCode(int i) => i switch
    {
        < 100 => 100.GetHashCode(),
        _ => 1.GetHashCode()
    };

    public bool IsFounder(int id) => id < 100;
}
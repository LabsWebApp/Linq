using Core;
using static Core.Data;
using static System.Console;

var chars = Cars.SelectMany(p => p);
WriteLine(chars.GetType());
foreach (var c in chars) Write(c + ",");
WriteLine();

var employeeOptions = Employee.GetEmployeesArray()
    .SelectMany(e => EmployeeOptionEntry.GetEmployeeOptionEntries()
        .Where(eo => eo.Id == e.Id)
        .Select(eo => new
        {
            id = eo.Id,
            optionsCount = eo.OptionsCount,
            Name = e.LastName
        }));

foreach (var item in employeeOptions) WriteLine(item);
WriteLine();

ReadKey();

var employeeOptionsEx = Employee.GetEmployeesArray()
    .SelectMany(e => EmployeeOptionEntry.GetEmployeeOptionEntries()
        .Where(eo => eo.Id == e.Id)
        .GroupBy(e => e.Id),
        (e, seo) => new
        {
            Name = $"{e.FirstName} {e.LastName}",
            Option = seo
                        .Select(o => o.OptionsCount)
                        .Sum()
        });

foreach (var item in employeeOptionsEx) WriteLine(item);
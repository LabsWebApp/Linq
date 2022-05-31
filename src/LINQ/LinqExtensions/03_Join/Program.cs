using Core;
using static System.Console;

Employee[] employees = Employee.GetEmployeesArray();
EmployeeOptionEntry[] empOptions = EmployeeOptionEntry.GetEmployeeOptionEntries();

WriteLine("Join");
var employeeOptions = employees
  .Join(
    empOptions,       //  inner sequence
    e => e.Id,        //  outerKeySelector
    o => o.Id,        //  innerKeySelector
    (e, o) => new       //  resultSelector
    {
        e.Id,
        name = $"{e.FirstName} {e.LastName}",
        options = o.OptionsCount
    });

foreach (var item in employeeOptions)
    WriteLine(item);

var employeeOptions2 = Employee2
    .GetEmployeesArray()
    .Join(
    empOptions,       //  inner sequence
    e => e.Id,        //  outerKeySelector
    o => o.Id,        //  innerKeySelector
    (e, o) => new     //  resultSelector
    {
        e.Id,
        name = $"{e.FirstName} {e.LastName}",
        options = o.OptionsCount
    },
    new StrIntComparer()
    );

WriteLine(employeeOptions.GetType());
WriteLine(employeeOptions2.GetType());

foreach (var item in employeeOptions2)
    WriteLine(item);

WriteLine("GroupJoin");

var group = employees
    .GroupJoin(empOptions,
        e => e.Id,
        o => o.Id,
        (e, o) => new     //  resultSelector
        {
            e.Id,
            name = $"{e.FirstName} {e.LastName}",
            options = o.Sum(y => y.OptionsCount) // o - стало перечислением!!!
        });

WriteLine(group.GetType());
foreach (var item in group)
    WriteLine(item);

// GroupJoin с IEqualityComparer аналогичен простому Join!!!

ReadKey();
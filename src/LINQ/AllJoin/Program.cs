using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace AllJoin
{
    class Program
    {
        const string NoData = "[нет данных]";

        static void GetInfo<T>(IEnumerable<T> items, char separator = '\n')
            => WriteLine(string.Join(separator, items.Select(x => x.ToString() ?? NoData)) + '\n');

        static void Main()
        {
            DbContext db = new();

            //GetInfo(db.Staff);
            //GetInfo(db.Departments);
            //GetInfo(db.Banks);


            dynamic test =
                from employee in db.Staff
                from department in db.Departments 
                where employee.DepartmentId == department.Id
                select (employee.Name, department.Name);

            //GetInfo(test);
            //ReadKey();

            /*
             * INNER JOIN
             * Внутреннее соединение.
             * Этот вид JOIN выведет только те строки,
             * если условие соединения выполняется
             */

            test = 
                from emp in db.Staff
                join dep in db.Departments
                    on emp.DepartmentId equals dep.Id
                select (emp.Name, dep.Name);

            //GetInfo(test);
            //ReadKey();

            test = db.Staff
                .Join(
                    db.Departments,
                    employee => employee.DepartmentId,
                    department => department.Id, 
                    (employee, department) 
                        => (employee.Name, department.Name));
            //GetInfo(test);
            //ReadKey();
            /*
             * LEFT JOIN и RIGHT JOIN
             * Левое и правое соединения еще называют внешними.
             * Главное их отличие от внутреннего соединения в том,
             * что строки из левой (для LEFT JOIN)
             * или из правой таблицы (для RIGHT JOIN)
             * попадет в результаты в любом случае. 
             */

            //LEFT
            var testL = 
                from employee in db.Staff
                join department in db.Departments
                    on employee.DepartmentId equals department.Id
                    into dep
                from departmentWithNull in dep.DefaultIfEmpty()
                select (employee.Name, departmentWithNull?.Name ?? NoData);

            //GetInfo(testL);
            //ReadKey();

            testL = db.Staff
                .GroupJoin(
                    db.Departments, 
                    employee => employee.DepartmentId, 
                    department => department.Id,
                    (employee, department) 
                        => new {employee, department})
                .SelectMany(
                    t => t.department.DefaultIfEmpty(),
                    (x, nullDepartment) 
                        => (x.employee.Name, nullDepartment?.Name ?? NoData));

            //GetInfo(testL);
            //ReadKey();

            //RIGHT
            var testR = 
                from department in db.Departments
                join employee in db.Staff
                    on department.Id equals employee.DepartmentId
                    into employee
                from nullEmployee in employee.DefaultIfEmpty()
                select (nullEmployee?.Name ?? NoData, department.Name);

            //GetInfo(testR);
            //ReadKey();

            testR = db.Departments
                .GroupJoin(db.Staff, 
                    department => department.Id, employee => employee.DepartmentId,
                    (department, employee) 
                        => new {department, employee})
                .SelectMany(
                    t => t.employee.DefaultIfEmpty(),
                    (t, nullEmployee) 
                        => (nullEmployee?.Name ?? NoData, t.department.Name));
            //GetInfo(testR);

            /*
             * FULL JOIN
             * Left + Right
             */ 
            
            test = testR.Union(testL);

            //GetInfo(test);
            //ReadKey();

            //

            var testFullEmp =
                from employee in db.Staff
                join department in db.Departments
                    on employee.DepartmentId equals department.Id
                    into department
                from nullDepartment in department.DefaultIfEmpty()
                join bank in db.Banks
                    on employee.BankId equals bank.Id
                    into bank
                from nullBank in bank.DefaultIfEmpty()
                select (employee.Name,
                    nullDepartment?.Name ?? NoData,
                    nullBank?.Name ?? NoData);
            
            GetInfo(testFullEmp);
            ReadKey();

            var testFullDep =
                from department in db.Departments
                join employee in db.Staff
                    on department.Id equals employee.DepartmentId
                    into employee
                from nullEmployee in employee.DefaultIfEmpty()
                join bank in db.Banks
                    on nullEmployee?.BankId equals bank?.Id
                    into bank
                from nullBank in bank.DefaultIfEmpty()
                select (nullEmployee?.Name ?? NoData,
                    department.Name,
                    nullBank?.Name ?? NoData);
            GetInfo(testFullDep);

            var testFullBank =
                from bank in db.Banks
                join employee in db.Staff
                    on bank.Id equals employee.BankId
                    into employee
                from nullEmployee in employee.DefaultIfEmpty()
                join department in db.Departments
                    on nullEmployee?.DepartmentId equals department?.Id
                    into department
                from nullDepartment in department.DefaultIfEmpty()
                select (nullEmployee?.Name ?? NoData,
                    nullDepartment?.Name ?? NoData,
                    bank.Name);
            GetInfo(testFullBank);

            var testResult =
                testFullEmp
                    .Union(testFullDep)
                    .Union(testFullBank)
                   //ОЧЕНЬ ВАЖНО НЕМЕДЛЕННОЕ ВЫПОЛНЕНИЕ!!!
                    .ToArray();

           GetInfo(testResult);
            


            var testGroupsByBank =
                from x in testResult
                group x by x.Item3;

            //WriteLine("Банки:");
            //foreach (var item in testGroupsByBank)
            //{
            //    WriteLine(item.Key);
            //    foreach (var res in item)
            //    {
            //        WriteLine($"\t{res.Item1}");
            //    }
            //}
            //WriteLine();
            //ReadKey();
            //WriteLine("Отделы:");
            //var testGroupsByDep =
            //    from x in testResult
            //    group x by x.Item2
            //    into g
            //    select (g.Key, g.Count());
            //foreach (var group in testGroupsByDep)
            //    WriteLine($"{group.Key} - {group.Item2}");

            ReadKey();
        }
        
    }

    internal class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public object O { get; set; }
    }
}

using System.Collections;

namespace Core;

public class Employee
{
    public int Id;
    public string? FirstName;
    public string? LastName;

    public static ArrayList GetEmployeesArrayList()
    {
        ArrayList al = new ArrayList();

        al.Add(new Employee { Id = 1, FirstName = "Joe", LastName = "Rattz" });
        al.Add(new Employee { Id = 2, FirstName = "Bill", LastName = "Gates" });
        al.Add(new Employee { Id = 3, FirstName = "Anders", LastName = "Hejlsberg" });
        al.Add(new Employee { Id = 4, FirstName = "David", LastName = "Lightman" });
        al.Add(new Employee { Id = 5, FirstName = "David2", LastName = "Lightman2" });
        al.Add(new Employee { Id = 101, FirstName = "Kevin", LastName = "Flynn" });
        return (al);
    }

    public static Employee[] GetEmployeesArray() =>
        (Employee[])GetEmployeesArrayList().ToArray(typeof(Employee));
}

public class Employee2
{
    public string Id = null!;
    public string? FirstName;
    public string? LastName;

    public static ArrayList GetEmployeesArrayList()
    {
        ArrayList al = new ArrayList();

        al.Add(new Employee2 { Id = "1", FirstName = "Joe", LastName = "Rattz" });
        al.Add(new Employee2 { Id = "2", FirstName = "Bill", LastName = "Gates" });
        al.Add(new Employee2 { Id = "3", FirstName = "Anders", LastName = "Hejlsberg" });
        al.Add(new Employee2 { Id = "4", FirstName = "David", LastName = "Lightman" });
        al.Add(new Employee2 { Id = "5", FirstName = "David2", LastName = "Lightman2" });
        al.Add(new Employee2 { Id = "101", FirstName = "Kevin", LastName = "Flynn" });
        return al;
    }

    public static Employee2[] GetEmployeesArray() =>
        (Employee2[])GetEmployeesArrayList().ToArray(typeof(Employee2));
}

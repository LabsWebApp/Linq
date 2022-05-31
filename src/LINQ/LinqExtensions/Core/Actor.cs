namespace Core;

public class Actor
{
    public int BirthYear;
    public string? FirstName;
    public string? LastName;

    public static Actor[] GetActors() => new Actor[]
    {
            new Actor { BirthYear = 1964, FirstName = "Keanu", LastName = "Reeves" },
            new Actor { BirthYear = 1968, FirstName = "Owen", LastName = "Wilson" },
            new Actor { BirthYear = 1960, FirstName = "James", LastName = "Spader" },
            new Actor { BirthYear = 1964, FirstName = "Sandra", LastName = "Bullock" },
    };
}

public class Actor2
{
    public string BirthYear = null!;
    public string? FirstName;
    public string? LastName;

    public static Actor2[] GetActors() => new Actor2[]
    {
            new Actor2 { BirthYear = "1964", FirstName = "Keanu", LastName = "Reeves" },
            new Actor2 { BirthYear = "1968", FirstName = "Owen", LastName = "Wilson" },
            new Actor2 { BirthYear = "1960", FirstName = "James", LastName = "Spader" },
            // Пример даты с ведущим нулем
            new Actor2 { BirthYear = "01964", FirstName = "Sandra", LastName = "Bullock" }
    };
}

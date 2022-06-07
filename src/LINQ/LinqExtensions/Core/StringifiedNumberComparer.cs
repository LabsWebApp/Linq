namespace Core;

public class StringifiedNumberComparer : IEqualityComparer<string>
{
    public bool Equals(string? x, string? y) => (x, y) switch
    {
        (null, _) or (_, null) => false,
        _ => int.Parse(x) == int.Parse(y)
    };

    public int GetHashCode(string obj) => int.Parse(obj).ToString().GetHashCode();
}

public class StrIntComparer : IEqualityComparer<object>
{
    public new bool Equals(object? x, object? y) => (x, y) switch
    {
        (null, _) or (_, null) => false,
        (string, int) => int.Parse((string)x) == (int)y,
        (int, string) => (int)x == int.Parse((string)y),
        _ => x.Equals(y)
    };

    public int GetHashCode(object obj) => obj switch
    {
        string => int.Parse((string)obj).GetHashCode(),
        int => obj.GetHashCode(),
        _ => throw new NotSupportedException()
    };
}
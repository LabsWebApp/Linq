using System.Linq.Expressions;

namespace ExpressionTree;

public class SimpleAdd<T>
{
    private readonly Func<T, T, T> _add;

    public SimpleAdd()
    {
        var paramX = Expression.Parameter(typeof(T), "x");
        var paramY = Expression.Parameter(typeof(T), "y");

        var body = Expression.Add(paramX, paramY);

        _add = Expression
            .Lambda<Func<T, T, T>>(body, paramX, paramY)
            .Compile();
    }

    public T Add(T x, T y) => _add(x, y);
}
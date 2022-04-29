using static System.Console;

// Использование ref и out аргументов. (Аргумент расширения не может быть ни ref ни out)

int summand1 = 1, summand2 = 2;

summand1.Add(ref summand2, out var sum);
WriteLine(sum);

// Delay.
ReadKey();

static class ExtensionClass
{
    public static void Add(this int summand1, ref int summand2, out int sum)
    {
        sum = summand1++ + summand2;
        WriteLine($"{summand1} + {summand2} = {sum}");
    }
}
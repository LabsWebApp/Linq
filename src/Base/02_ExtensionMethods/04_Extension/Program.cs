using static System.Console;

// Рекурсия (простая).

string text = "Hello ";

text.ExtensionMethod(3);

// Delay.
ReadKey();

static class ExtensionClass
{
    public static void ExtensionMethod(this string value, int counter)
    {
        counter--;
        WriteLine(value + counter);

        if (counter != 0)
            value.ExtensionMethod(counter);

        WriteLine(value + counter);
    }
}

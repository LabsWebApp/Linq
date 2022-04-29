using static System.Console;

// Расширяющие методы не могут иметь опциональных параметров, но могут быть перегружены.

string text = "Hello ";

text.ExtensionMethod("world!");

"Hello ".ExtensionMethod("world!");

2.ExtensionMethod();

// Delay.
ReadKey();

static class ExtensionClass
{
    public static void ExtensionMethod(this string value) => WriteLine(value);

    public static void ExtensionMethod(this string value1, string value2) =>
        WriteLine(value1 + value2);

    public static void ExtensionMethod(this int value) => WriteLine(value);
}
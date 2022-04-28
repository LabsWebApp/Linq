// Аргумент расширения всегда должен быть только один и стоять первым в списке аргументов.

string text = "Hello ";

text.ExtensionMethod("world!");

// Delay.
Console.ReadKey();

static class ExtensionClass
{
    public static void ExtensionMethod(this string value1, string value2) =>
        Console.WriteLine(value1 + value2);
}
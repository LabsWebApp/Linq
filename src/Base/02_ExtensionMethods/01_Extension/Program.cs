﻿using static System.Console;

// Расширяющие методы. (Extension methods)
// Расширяющие методы могут быть только статическими и создаваться только в статических классах.

string text = "Тестовая строка";

// Вызов метода, как статического.
ExtensionClass.ExtensionMethod(text);

// Вызов метода, как расширяющего.
text.ExtensionMethod();

// Delay.
ReadKey();

static class ExtensionClass
{
    // this - сообщает компилятору, что данный метод является расширяющим (Extension)!
    public static void ExtensionMethod(this string value) =>
        WriteLine(value);
}
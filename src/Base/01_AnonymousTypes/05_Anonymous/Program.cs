using static System.Console;

var instance = new
{
    Delegate = new Program((string @string) => WriteLine(@string))
};

instance.Delegate("Hello world!");

// Delay.
ReadKey();

delegate void Program(string @string);
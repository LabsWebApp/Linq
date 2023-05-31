using static System.Console;

var instance = new
{
    Delegate = new Prog((string @string) => WriteLine(@string))
};

instance.Delegate.Invoke("Hello world!");

// Delay.
ReadKey();

delegate void Prog(string @string);
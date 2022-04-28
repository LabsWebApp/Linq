var instance = new
{
    Delegate = new Delegate((string @string) => Console.WriteLine(@string))
};

instance.Delegate("Hello world!");

// Delay.
Console.ReadKey();

delegate void Delegate(string @string);
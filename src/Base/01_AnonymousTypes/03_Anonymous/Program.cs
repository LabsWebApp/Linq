var instance = new { Class = new FieldsClass() };

instance.Class.Field = 1;
instance.Class.Method();

// Delay.
Console.ReadKey();

class FieldsClass
{
    public int Field { get; set; }

    public void Method() => Console.WriteLine(Field);
}
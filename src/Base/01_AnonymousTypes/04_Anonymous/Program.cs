new
{
    Class = new FieldsClass { Field = 1 }
}.Class.Method();

// Delay.
Console.ReadKey();

class FieldsClass
{
    public int Field { get; set; }

    public void Method() => Console.WriteLine(Field);
}
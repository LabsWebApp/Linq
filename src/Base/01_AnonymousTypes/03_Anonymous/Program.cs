using static System.Console;

var instance = new { Class = new FieldsClass() };

instance.Class.Field = 1;
instance.Class.Method();

// Delay.
ReadKey();

class FieldsClass
{
    public int Field { get; set; }

    public void Method() => WriteLine(Field);
}
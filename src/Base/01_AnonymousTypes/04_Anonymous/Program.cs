﻿using static System.Console;

new
{
    Class = new FieldsClass { Field = 1 }
}.Class.Method();

// Delay.
ReadKey();

class FieldsClass
{
    public int Field { get; set; }

    public void Method() => WriteLine(Field);
}
﻿using static System.Console;
// Анонимные типы.

// Анонимные типы предлагают удобный способ инкапсуляции набора свойств в один объект 
// без необходимости предварительного явного определения типа.
// Имя типа создается компилятором и недоступно на уровне исходного кода.
// Анонимные типы являются ссылочными типами, которые происходят непосредственно от класса object.
// Компилятор присваивает им имена, несмотря на то что эти имена недоступны для приложения.

var instance = new { Name = "Petja", Age = 20 };
var instance2 = new { Name = "Petja", Age = 20 };

WriteLine($"Name = {instance.Name}, Age = {instance.Age}");

Type type = instance.GetType();

WriteLine(type.ToString());
WriteLine(instance2.GetType());

// Delay.
ReadKey();
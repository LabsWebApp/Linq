using static System.Console;

object[] objects = { 1, 2, 3 };

var ints = objects.Cast<int>();

WriteLine("Cast");
WriteLine(ints.GetType());
WriteLine(ints.ElementAtOrDefault(1));

WriteLine("\nOfType");

Pet[] pets =
{
    new Dog(),
    new Cat(),
    new Dog(),
    new Dog(),
    new Cat()
};

var dogs = pets.OfType<Dog>();

WriteLine(dogs.GetType());
WriteLine(dogs.Count());

pets[1] = new Dog();

WriteLine(dogs.Count());

ReadKey();

abstract class Pet { }
class Dog : Pet { }
class Cat : Pet { }
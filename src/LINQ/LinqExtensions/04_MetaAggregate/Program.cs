using static Core.NumberExtensions;
using static System.Console;

WriteLine("(Long)Count");
int[] numbers = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };
int size = numbers.Count();
WriteLine(size);   //10

//  количество четных чисел, которые больше 10
size = numbers.Count(i => i % 2 == 0 && i > 10);
WriteLine(size);    // 3

var range = StepRange(0L, (long)int.MaxValue + 1);
//long @long = range.LongCount();
//WriteLine(@long);


WriteLine("Sum");
int sum = numbers.Sum();
WriteLine(sum);     // 340

Person[] people =
{
                new Person("Tom", 37), new Person("Sam", 28), new Person("Bob", 41)
            };

int ageSum = people.Sum(p => p.Age switch
{
    < 30 => 0,
    _ => p.Age
});
WriteLine(ageSum);     // 78


WriteLine("Min Max Average");

int min = numbers.Min();
int max = numbers.Max();
double average = numbers.Average();

WriteLine($"Min: {min}");           // Min: 1
WriteLine($"Max: {max}");           // Max: 88
WriteLine($"Average: {average}");   // Average: 34

int minAge = people.Min(p => p.Age); // минимальный возраст
int maxAge = people.Max(p => p.Age); // максимальный возраст
double averageAge = people.Average(p => p.Age); //средний возраст

WriteLine($"Min Age: {minAge}");           // Min Age: 28
WriteLine($"Max Age: {maxAge}");           // Max Age: 41
WriteLine($"Average Age: {averageAge}");   // Average Age: 35,33

ReadKey();

record Person(string Name, int Age);
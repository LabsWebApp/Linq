string[] people = { "Tom", "Bob", "Kate", "Tim", "Mike", "Sam" };

// первая строка
var first = people.First();  // Tom
Console.WriteLine(first);

// первая строка, длина которой равна 4 символам
var firstWith4Chars = people.First(s => s.Length == 4);  // Kate
Console.WriteLine(firstWith4Chars);

// первая строка, длина которой равна 9 символам
//var firstWith9Chars = people.First(s => s.Length == 9);  // исключение!
//Console.WriteLine(firstWith9Chars);

string? firstWith5Chars = people.FirstOrDefault(s => s.Length == 5, "no data");
Console.WriteLine(firstWith5Chars); // Undefined

// первый элемент из пустой коллекции строк
string? firstOrDefault = new string[] { }.FirstOrDefault("hello"); // hello - значение по умолчанию
Console.WriteLine(firstOrDefault);  // hello

// первый элемент из пустой коллекции int
int firstNumber = new int[] { }.FirstOrDefault(100); // 100 - значение по умолчанию
Console.WriteLine(firstNumber); // 100

// Last полностью аналогичен!!!

people = new string[] { "Tom"};

// первый и последний элемент
var single = people.Single();
Console.WriteLine(single);  // Tom

people = new string[] { "Tom" , "Dom"};

// первый и последний элемент
//single = people.Single();
//Console.WriteLine(single);   // Исключение

// первый и единственный элемент, начинающийся на "D"
single = people.Single(s => s[0] == 'D');
Console.WriteLine(single);   // Dom

single = (new string[] { }).SingleOrDefault();
Console.WriteLine(single ?? "default"); // default

//single = people.SingleOrDefault();
//Console.WriteLine(single);   // Исключение

// первый и единственный элемент, начинающийся на "D", если его нет, то null
single = people.SingleOrDefault(s => s[0] == 'F');
Console.WriteLine(single ?? "null");   // null

// первый и единственный элемент, начинающийся на "D", если его нет, то "default"
single = people.SingleOrDefault(s => s[0] == 'F', "default");
Console.WriteLine(single ?? "null");   // "default"

people = new string[] { "Tom", "Bob", "Kate", "Tim", "Mike", "Sam" };
single = people.ElementAt(0);
Console.WriteLine(single ?? "null");   // Tom

single = people.ElementAt(^1);
Console.WriteLine(single ?? "null");   // Sam

//single = people.ElementAt(^99);
//Console.WriteLine(single ?? "null");   // Исключение

single = people.ElementAtOrDefault(^99);
Console.WriteLine(single ?? "null");   // null


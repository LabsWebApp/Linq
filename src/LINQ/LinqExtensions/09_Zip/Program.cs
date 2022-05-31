using static System.Console;

int[] numbersSequence = { 10, 20, 30, 40, 50 };
string?[] wordsSequence = { "Ten", "Twenty", "Thirty", "Forty" };

var resultSequence = numbersSequence.Zip(wordsSequence, (first, second) => first + " - " + second);
WriteLine(resultSequence.GetType());

foreach (var item in resultSequence) WriteLine(item);
 
ReadKey();
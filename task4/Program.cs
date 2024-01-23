//Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, в которой слова расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами.



string? input = Console.ReadLine();

#pragma warning disable CS8602 // Dereference of a possibly null reference.
string[] words = input.Split(' ');
#pragma warning restore CS8602 // Dereference of a possibly null reference.

Array.Reverse(words);

string reverseString = String.Join(" ", words);

Console.WriteLine(reverseString);
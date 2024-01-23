//Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

string str = Console.ReadLine();

string strNew = "";

for (int i = str.Length - 1; i > 0; i--)
{
    strNew += str[i];
}

System.Console.WriteLine(str);
System.Console.WriteLine(strNew);
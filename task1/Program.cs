//Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

char [,] array = new char[4, 4];

Random rnd = new Random();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = Convert.ToChar(rnd.Next('a', 'a' + 27));
    }
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        System.Console.Write(array[i,j] + "\t");
    }
    System.Console.WriteLine();
}

string str = "";

for (int i = 0; i < array.GetLength(0); i++)
{
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        {
        str = str + array[i,j] + " ";
        }
    }
}

System.Console.WriteLine(str);
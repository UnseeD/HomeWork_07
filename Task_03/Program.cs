// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int length = ReadInt("m");
int secondLength = ReadInt("n");

int [,] array = GetArray(length, secondLength);

Printarray (array);
MidleAr (array);

int ReadInt(string Input)
{
    Console.Write($"Input {Input}:");
    return int.Parse(Console.ReadLine()!);
}

int[,] GetArray (int length, int secondLength)
{
    int[,] array = new int [length, secondLength];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < secondLength; j++)
        {
            array[i, j] = random.Next(10);
        }
    } 
    return array; 
}

void Printarray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array [i,j]} ");
        }
        Console.WriteLine();
    } 
}

void MidleAr (int[,] array)
{
       
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double mid = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
        mid += array[i, j];
        }
        Console.Write($"{mid / array.GetLength(0)}, ");
        
    }
    
}
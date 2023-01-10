// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

double[,] array = GetArray(ReadInt("length "), ReadInt("secondLength "));

Printarray (array);
SearchN(array);

int ReadInt(string arg)
{
    Console.Write($"Input {arg}: ");
    return int.Parse(Console.ReadLine());
}

double[,] GetArray (int length, int secondLength)
{
    double[,] array = new double [length, secondLength];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < secondLength; j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    } 
    return array; 
}

void Printarray (double[,] array)
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
void SearchN(double[,] array)
{
    Console.Write("Input N: ");
    int N = int.Parse(Console.ReadLine());
    int w = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (N == array[i,j]) 
            {
                w++;               
            }           
                                      
        }        
           
    } 
    if (w == 0)
        Console.WriteLine($"{N} not found");
}


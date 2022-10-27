// Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

Console.WriteLine("введите количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите количество строк n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] GetArray()

{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

int[,] SortArrayLines(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int s = 0; s < array.GetLength(1) - 1; s++)
            {
                if (array[i, s] < array[i, s + 1])
                {
                    int temp = array[i, s + 1];
                    array[i, s + 1] = array[i, s];
                    array[i, s] = temp;
                }

            }
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] array1 = GetArray();
PrintArray(array1);
Console.WriteLine();
PrintArray(SortArrayLines(array1));
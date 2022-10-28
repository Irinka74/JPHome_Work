// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:1 4 7 2\5 9 2 3\8 4 2 4 /17 -> такого числа в массиве нет

Console.Write("введите количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] GetArray(int m, int n)
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
/*?

    Console.Write("Введите позицию элемента a,b  ");
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());

    if (a > m && b > n)
    {
       Console.WriteLine($"такого числа в массиве нет ");
    }
    else
    {

    }

/*

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
int[,] array = GetArray(m, n);
PrintArray(array);
PrintArray(SeekNumbersArray(array));
 
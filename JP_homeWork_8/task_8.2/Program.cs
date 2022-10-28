// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7 Программа считает сумму элементов в каждой строке и 
//выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("введите количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("введите количество строк n: ");
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

int[,] LineSummArray(int[,] array)
{
    
/*

    
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
    int[,] array = GetArray();
    PrintArray(array);
    Console.WriteLine();
    PrintArray(LineSummArray(array));
  
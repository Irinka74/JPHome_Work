// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:1 4 7 2\5 9 2 3\8 4 2 4 /17 -> такого числа в массиве нет

Console.Write("Введите строку:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец:");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());

Random random = new Random();
int[,] array = new int[m, n];
Console.WriteLine("Выш массив:");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.Next(1, 100);
        Console.Write("{0} ", array[i, j]);
    }
    Console.WriteLine();
}
if (a > array.GetLength(0) || b > array.GetLength(1))
{

    Console.WriteLine("Такого элемента нет! ");
}
else
{
    Console.WriteLine("Значение элемента массива = {0}", array[a, b]);
}
Console.ReadLine();


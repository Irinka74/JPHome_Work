// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Write("введите количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
Random random = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.Next(1, 10);
    }
}

    UpdateArray(array);
    int minSumLine = 0;
    int sumLine = SumLineElements(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int tempSumLine = SumLineElements(array, i);
        if (sumLine > tempSumLine)
        {
            sumLine = tempSumLine;
            minSumLine = i;
        }
    }
    Console.Write($"строкa с наименьшей суммой: {minSumLine + 1} сумма равна {sumLine} ");
    int SumLineElements(int[,] array, int i)
    {
        int sumLine = array[i, 0];
        for (int j = 1; j < array.GetLength(1); j++)
        {
            sumLine += array[i, j];
        }
        return sumLine;
    }
    void UpdateArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }


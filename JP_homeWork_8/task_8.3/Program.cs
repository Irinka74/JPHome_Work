// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18



Console.Write("Количество строк матрицы A:    ");
int n = int.Parse(Console.ReadLine());
Console.Write("Количество столбцов матрицы A: ");
int m = int.Parse(Console.ReadLine());

int[,] MatrixA()

{
    int[,] matrixA = new int[n, m];
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            matrixA[i, j] = rnd.Next(1, 10);
        }
    }
    return matrixA;
}

Console.Write("Количество строк матрицы B: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Количество столбцов матрицы B: ");
int y = int.Parse(Console.ReadLine());

int[,] MatrixB()

{
    int[,] matrixB = new int[x, y];
    Random rnd = new Random();
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            matrixB[i, j] = rnd.Next(1, 10);
        }
    }
    return matrixB;
}
//   Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");

int[,] MatrixC()
{
/*
   




    return matrixC;
}
void PrintArray(int[,] matrixC)
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
int[,] array = Matri(();
PrintArray(array);
PrintArray(MultipiyMatrixC(array));
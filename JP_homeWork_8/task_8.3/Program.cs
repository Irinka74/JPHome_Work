// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Write("Количество строк матрицы A: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Количество столбцов матрицы A: ");
int m = int.Parse(Console.ReadLine());
int[,] matrixA = new int[n, m];
Random random = new Random();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        matrixA[i, j] = random.Next(1, 10);
    }
}

Console.Write("Количество строк матрицы B: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Количество столбцов матрицы B: ");
int y = int.Parse(Console.ReadLine());
int[,] matrixB = new int[x, y];
Random rand = new Random();
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        matrixB[i, j] = rand.Next(1, 10);
    }
}
Console.WriteLine("\nМатрица A:");
Print(matrixA);
Console.WriteLine("\nМатрица B:");
Print(matrixB);
Console.WriteLine("\nМатрица C:");
int[,] C = Multiplication(matrixA, matrixB);
Print(C);
int[,] Multiplication(int[,] A, int[,] B)
{
    if (A.GetLength(1) != B.GetLength(0)) Console.WriteLine("Матрицы нельзя умножить");
    int[,] result = new int[A.GetLength(0), B.GetLength(1)];
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < B.GetLength(1); j++)
        {
            for (int k = 0; k < B.GetLength(0); k++)
            {
                result[i, j] += A[i, k] * B[k, j];
            }
        }
    }
    return result;
}
void Print(int[,] A)
{
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
            Console.Write("{0} ", A[i, j]);
        }
        Console.WriteLine();
    }
}


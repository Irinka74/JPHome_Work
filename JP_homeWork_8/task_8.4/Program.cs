// Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

Console.Write("введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("введите z: ");
int z = Convert.ToInt32(Console.ReadLine());

int[,,] array = new int[m, n, z];

Random random = new Random();
for (int i = 0; i < array.GetLength(0); i++)

    for (int j = 0; j < array.GetLength(1); j++)

        for (int k = 0; k < array.GetLength(2); k++)

            array[i, j, k] = random.Next(10, 99);

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
               
               Console.Write($"{array[i, j, k]} ({i},{j},{k})");
            }
        }
        Console.WriteLine();
    }
}
PrintArray((array));

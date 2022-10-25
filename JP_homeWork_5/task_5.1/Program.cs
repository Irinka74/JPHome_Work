// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.[345, 897, 568, 234] -> 2


int[] CreateArray(int minValue, int MaxValue)
{
    Console.Write("Введите размер массива n: ");
    int n = int.Parse(Console.ReadLine());
    int[] array = new int[n];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue, MaxValue);
    }
    return array;
}

int GetCountPositiveElementsFromArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

string GetArray(int[] array)
{
    string count = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        count = count + $"{array[i]}| ";
    }
    return count;
}

int[] array = CreateArray(100, 1000);

Console.WriteLine(GetArray(array));
Console.WriteLine("количество чётных чисел в массиве = " + GetCountPositiveElementsFromArray(array));




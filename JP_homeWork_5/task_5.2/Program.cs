// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.[3, 7, 23, 12] -> 19  [-4, -6, 89, 6] -> 0


int[] CreateArray()
{
    Console.Write("Введите размер массива n: ");
    int n = int.Parse(Console.ReadLine());
    int[] array = new int[n];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next();
    }
    return array;
}

int GetSumPositiveElementsFromArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sum = sum + array[i];
    }

    return sum;
}

string GetArray(int[] array)
{
    string sum = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        sum = sum + $"{array[i]}| ";
    }
    return sum;
}

int[] array = CreateArray();

Console.WriteLine(GetArray(array));
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях = " + GetSumPositiveElementsFromArray(array));
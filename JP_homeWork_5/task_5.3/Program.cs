// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива. [3 7 22 2 78] -> 76


//Console.WriteLine("Введите размер массива n: ");
//double n = double.Parse(Console.ReadLine());

double[] CreateArray()
{
    Random random = new Random();
    double[] array = new double[5];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.NextDouble();
        { Console.WriteLine($"{array[i]}, "); }
    }

    return array;
}

double GetMinElementsArray(double[] array)
{
    double min = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
    }
    return min;
}

double GetMaxElementsArray(double[] array)
{
    double max = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}

double[] array = CreateArray();

Console.WriteLine($"Минимальный элемент: " + GetMinElementsArray(array));
Console.WriteLine($"Максимальный элемент: " + GetMaxElementsArray(array));
Console.WriteLine($"Разница между максимальным и минимальным элементом:" 
                  + (GetMaxElementsArray(array) - GetMinElementsArray(array)));




